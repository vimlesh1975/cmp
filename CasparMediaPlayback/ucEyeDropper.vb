Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Windows.Forms.Design
Imports System.Runtime.InteropServices

#Region "gEyeDropper"

<ToolboxItem(True), ToolboxBitmap(GetType(ucEyeDropper), "ColorPickerLib.gEyeDropper.bmp")> _
<Designer(GetType(ucEyedropperDesigner))> _
<DefaultEvent("SelectedColorChanged")> _
Public Class ucEyeDropper
    Inherits UserControl

#Region "Declarations"
    Private ReadOnly szDownSize As Size = New Size(22, 22)
    Private bmpScreenShot As Bitmap
    Private DropperCursor As Cursor
    Private blnGettingPixelColor As Boolean
    Private szZoomWindowSize As Size = New Size(100, 100)
    Private bmpButtonImage As Bitmap
#End Region

#Region "Events"
    Public Event SelectedColorChanging(ByVal sender As Object, ByVal CurrColor As Color)
    Public Event SelectedColorChanged(ByVal sender As Object, ByVal CurrColor As Color)
#End Region

#Region "Initialize"

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        'InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SetStyle(ControlStyles.DoubleBuffer, True)
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)

        DoubleBuffered = True
        Size = szDownSize

    End Sub

    Private Sub gEyeDropper_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        RecalcScreenShotSize()
        'get the blank cursor to make the it dissapear when dragging
        Dim assem As Reflection.Assembly = Me.GetType().Assembly
        Dim my_namespace As String = assem.GetName().Name
        Dim mystream As IO.Stream
        Try
            mystream = assem.GetManifestResourceStream(my_namespace & ".Dropper.cur")
            DropperCursor = New Cursor(mystream)

        Catch ex As Exception
            DropperCursor = Cursors.Cross
        End Try
        DrawDropper(Color.Blue)
    End Sub

#End Region 'Initialize

#Region "Properties"

    Private _SelectedColor As Color
    <Category("Appearance EyeDropper")> _
    <Description("Current Color at the Cursor Location")> _
    Public Property SelectedColor() As Color
        Get
            Return _SelectedColor
        End Get
        Set(ByVal value As Color)
            If _SelectedColor <> value Then
                _SelectedColor = value
                RaiseEvent SelectedColorChanging(Me, _SelectedColor)
            End If
        End Set
    End Property

    Private _BorderColor As Color = Color.Blue
    <Category("Appearance EyeDropper")> _
    <Description("Color of the Border")> _
    Public Property BorderColor() As Color
        Get
            Return _BorderColor
        End Get
        Set(ByVal value As Color)
            _BorderColor = value
            Invalidate()
        End Set
    End Property

    Private _ButtonColor As Color = Color.White
    <Category("Appearance EyeDropper")> _
    <Description("Background Color for the Button")> _
    Public Property ButtonColor() As Color
        Get
            Return _ButtonColor
        End Get
        Set(ByVal value As Color)
            _ButtonColor = value
            Invalidate()
        End Set
    End Property

    Public Enum eZoomLevel
        Level1 = 5
        Level2 = 10
    End Enum
    Private _zoomLevel As eZoomLevel = eZoomLevel.Level1
    <Category("Appearance EyeDropper")> _
    <Description("Level of Zoom for the Eye Dropper Window (1-13)")> _
    Public Property ZoomLevel() As eZoomLevel
        Get
            Return _zoomLevel
        End Get
        Set(ByVal Value As eZoomLevel)
            _zoomLevel = Value
            RecalcScreenShotSize()
        End Set
    End Property

    Public Enum eZoomWindowType
        ShowOnCursor = 20
        ShowInPlace = 0
    End Enum

    Private _zoomWindowType As eZoomWindowType = eZoomWindowType.ShowOnCursor
    <Category("Appearance EyeDropper")> _
    <Description("Set if the Zoom window expands in place or becomes the cursor")> _
    Public Property ZoomWindowType() As eZoomWindowType
        Get
            Return _zoomWindowType
        End Get
        Set(ByVal Value As eZoomWindowType)
            _zoomWindowType = Value
        End Set
    End Property

    Private _showSelectedSwatch As Boolean = True
    <Category("Appearance EyeDropper")> _
    <Description("Get or Set if the SelectedColor is displayed")> _
    Public Property ShowSelectedSwatch() As Boolean
        Get
            Return _showSelectedSwatch
        End Get
        Set(ByVal Value As Boolean)
            _showSelectedSwatch = Value
        End Set
    End Property


#End Region 'Properties

#Region "CreateIconIndirect"

    Private Structure IconInfo
        Public fIcon As Boolean
        Public xHotspot As Int32
        Public yHotspot As Int32
        Public hbmMask As IntPtr
        Public hbmColor As IntPtr
    End Structure

    <DllImport("user32.dll", EntryPoint:="CreateIconIndirect")> _
    Private Shared Function CreateIconIndirect(ByVal iconInfo As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function DestroyIcon(ByVal handle As IntPtr) As Boolean
    End Function

    <DllImport("gdi32.dll")> _
    Private Shared Function DeleteObject(ByVal hObject As IntPtr) As Boolean
    End Function

    Private curPtr As IntPtr
    Public Sub MakeCursor()

        If curPtr <> IntPtr.Zero Then
            DestroyIcon(curPtr)
        End If

        Using bmp As New Bitmap(120, 120), _
           g As Graphics = Graphics.FromImage(bmp), _
           pn As Pen = New Pen(_BorderColor)

            'Make the zoomed in Bitmap of the 
            'screen area around the mouse point
            MakeZoom(g)

            'Setup the Cursors IconInfo
            Dim tmp As New IconInfo
            tmp.xHotspot = 9
            tmp.yHotspot = 9
            tmp.fIcon = False
            tmp.hbmMask = bmp.GetHbitmap()
            tmp.hbmColor = bmp.GetHbitmap()

            'Create the Pointer for the Cursor Icon
            Dim pnt As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(tmp))
            Marshal.StructureToPtr(tmp, pnt, True)

            curPtr = CreateIconIndirect(pnt)
            Cursor.Current = New Cursor(curPtr)

            'Clean Up
            If pnt <> IntPtr.Zero Then DestroyIcon(pnt)
            pnt = Nothing
            If tmp.hbmMask <> IntPtr.Zero Then DeleteObject(tmp.hbmMask)
            If tmp.hbmColor <> IntPtr.Zero Then DeleteObject(tmp.hbmColor)
            tmp = Nothing

        End Using
    End Sub

    Private Sub MakeZoom(ByRef g As Graphics)

        Using pn As Pen = New Pen(_BorderColor), br As Brush = New SolidBrush(SelectedColor)
            With g
                .InterpolationMode = InterpolationMode.NearestNeighbor
                .SmoothingMode = SmoothingMode.None
                Dim centerrect As Rectangle = New Rectangle( _
                    CInt(((szZoomWindowSize.Width - _zoomLevel) / 2) + _zoomWindowType + 1), _
                    CInt(((szZoomWindowSize.Height - _zoomLevel) / 2) + _zoomWindowType + 1), _
                    CInt(_zoomLevel), _
                    CInt(_zoomLevel))

                'Draw the Zoomed piece of the screenshot
                .FillRectangle(Brushes.White, _zoomWindowType, _zoomWindowType, _
                    szZoomWindowSize.Width, szZoomWindowSize.Height)
                .DrawImage(bmpScreenShot, _
                    _zoomLevel \ 4 + _zoomWindowType, _
                    _zoomLevel \ 4 + _zoomWindowType, _
                    szZoomWindowSize.Width - 1, _
                    szZoomWindowSize.Height - 1)

                'Draw the center pixel box
                .DrawRectangle(Pens.Black, centerrect)

                'Draw The Border
                pn.Width = 3
                pn.Alignment = PenAlignment.Inset
                .DrawRectangle(pn, _zoomWindowType, _zoomWindowType, _
                    szZoomWindowSize.Width - 0, _
                    szZoomWindowSize.Height - 0)
                .DrawRectangle(Pens.White, _zoomWindowType + 1, _zoomWindowType + 1, _
                    szZoomWindowSize.Width - 3, _
                    szZoomWindowSize.Height - 3)

                'Draw the CrossHair and Swatch if requested
                .SmoothingMode = SmoothingMode.AntiAlias
                If _zoomWindowType = eZoomWindowType.ShowOnCursor Then
                    If _showSelectedSwatch Then
                        .FillEllipse(br, New Rectangle(55, 0, 30, 25))
                        .DrawEllipse(Pens.Black, New Rectangle(55, 0, 29, 24))
                        .DrawEllipse(Pens.White, New Rectangle(56, 1, 27, 22))
                    End If

                    .DrawRectangle(Pens.White, 8, 8, 2, 2)
                    .DrawLine(Pens.Black, 0, 9, 8, 9)
                    .DrawLine(Pens.Black, 9, 0, 9, 8)
                    .DrawLine(Pens.Black, 9, 10, 9, 18)
                    .DrawLine(Pens.Black, 10, 9, 18, 9)
                Else
                    If _showSelectedSwatch Then
                        .FillEllipse(br, New Rectangle(2, 2, 25, 25))
                        .DrawEllipse(Pens.Black, New Rectangle(2, 2, 24, 24))
                        .DrawEllipse(Pens.White, New Rectangle(3, 3, 22, 22))
                    End If
                End If
            End With
        End Using

    End Sub
#End Region

#Region "Mouse Events"

    Private Sub EyeDropScreen_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If _zoomWindowType = eZoomWindowType.ShowInPlace Then

                Cursor = DropperCursor
                blnGettingPixelColor = True
                Size = szZoomWindowSize
                BringToFront()
                Invalidate()

            End If
        End If
    End Sub

    Private Sub EyeDropScreen_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            GetScreenShot()
            If _zoomWindowType = eZoomWindowType.ShowOnCursor Then
                MakeCursor()
            Else
                Invalidate()
            End If
        End If
    End Sub

    Private Sub EyeDropScreen_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseUp
        Cursor = Cursors.Default
        blnGettingPixelColor = False
        Size = szDownSize
        DrawDropper(_SelectedColor)

        RaiseEvent SelectedColorChanged(Me, _SelectedColor)

        Invalidate()
    End Sub

#End Region 'Mouse Events

#Region "Screen Capture"

    Sub RecalcScreenShotSize()
        If bmpScreenShot IsNot Nothing Then
            bmpScreenShot.Dispose()
        End If
        'Determine the size of the screenshot to put in the zoom box
        bmpScreenShot = New Bitmap(CInt(szZoomWindowSize.Width / _zoomLevel), _
            CInt(szZoomWindowSize.Height / _zoomLevel))
    End Sub

    Sub GetScreenShot()

        'The Mouse position is in the middle of the zoom box
        '  Determine the upper right corner point 
        '  of the zoom box from the mouse's position
        Dim scrPt As Point = Control.MousePosition
        scrPt.X = CInt(scrPt.X - bmpScreenShot.Width / 2)
        scrPt.Y = CInt(scrPt.Y - bmpScreenShot.Height / 2)

        'Copy the current piece of the screen to the bmpScreenShot Bitmap
        Using g As Graphics = Graphics.FromImage(bmpScreenShot)
            g.CopyFromScreen(scrPt, New Point(0, 0), bmpScreenShot.Size)
        End Using

        'Determine the color of the pixel in the center of the box
        SelectedColor = bmpScreenShot.GetPixel( _
            CInt(bmpScreenShot.Size.Width / 2), _
            CInt(bmpScreenShot.Size.Height / 2))

    End Sub

#End Region 'Screen Capture

#Region "Painting"

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)

        If bmpScreenShot IsNot Nothing Then
            Using pn As Pen = New Pen(_BorderColor)
                With e.Graphics
                    Try
                        If blnGettingPixelColor And _zoomWindowType = eZoomWindowType.ShowInPlace Then
                            MakeZoom(e.Graphics)
                        Else
                            .SmoothingMode = SmoothingMode.AntiAlias
                            .FillRectangle(New SolidBrush(BackColor), _
                                New Rectangle(New Point(0, 0), szDownSize))
                            .FillPath(New SolidBrush(_ButtonColor), _
                                GetRectPath(New Rectangle(0, 0, _
                                szDownSize.Width, szDownSize.Height), 3))
                            .DrawImage(bmpButtonImage, 3, 3)
                            .DrawPath(pn, _
                                GetRectPath(New Rectangle(0, 0, _
                                szDownSize.Width, szDownSize.Height), 3))
                        End If

                    Catch ex As Exception
                    End Try
                End With
            End Using
        End If
    End Sub

    Private Sub DrawDropper(ByVal TipColor As Color)
        bmpButtonImage = New Bitmap(16, 16)
        Using g As Graphics = Graphics.FromImage(bmpButtonImage), _
          pnTip As Pen = New Pen(TipColor)
            g.SmoothingMode = SmoothingMode.AntiAlias
            'Tube Border
            g.DrawLine(Pens.Gray, 0, 15, 0, 13)
            g.DrawLine(Pens.Black, 0, 13, 7, 6)
            g.DrawLine(Pens.Gray, 0, 15, 2, 15)
            g.DrawLine(Pens.Black, 2, 15, 9, 8)

            'Tube Fill
            g.DrawLine(Pens.White, 1, 13, 8, 6)
            g.DrawLine(Pens.Silver, 1, 14, 8, 7)
            g.DrawLine(Pens.Silver, 2, 14, 9, 7)
            g.DrawLine(pnTip, 1, 13, 4, 10)
            g.DrawLine(pnTip, 1, 14, 5, 10)
            g.DrawLine(pnTip, 2, 14, 6, 10)

            'Bulb Hilt
            g.DrawLine(Pens.Black, 6, 3, 12, 9)
            g.DrawLine(Pens.Black, 7, 3, 12, 8)

            'Bulb Border
            g.DrawLine(Pens.Black, 9, 3, 12, 0)
            g.DrawLine(Pens.Black, 12, 0, 14, 0)
            g.DrawLine(Pens.Black, 15, 1, 15, 3)
            g.DrawLine(Pens.Black, 12, 6, 15, 3)

            'Bulb Fill
            g.DrawLine(Pens.Gray, 9, 4, 12, 1)
            g.DrawLine(Pens.White, 10, 4, 13, 1)
            g.DrawLine(Pens.DimGray, 10, 5, 14, 1)
            g.DrawLine(Pens.DimGray, 11, 5, 14, 2)
            g.DrawLine(Pens.Black, 11, 6, 14, 3)
        End Using
    End Sub

    Public Shared Function GetRectPath(ByVal BaseRect As RectangleF, ByVal CornerRadius As Integer) As GraphicsPath

        Dim BorderRect As Rectangle = New Rectangle(0, 0, CInt(BaseRect.Width - 2), CInt(BaseRect.Height - 2))

        Dim ArcRect As RectangleF
        Dim MyPath As New GraphicsPath()
        If CornerRadius = 0 Then
            MyPath.AddRectangle(BorderRect)
        Else
            With MyPath
                ArcRect = New RectangleF(BorderRect.Location, _
                    New SizeF(CornerRadius * 2, CornerRadius * 2))
                ' top left arc
                .AddArc(ArcRect, 180, 90)

                ' top right arc
                ArcRect.X = BorderRect.Right - (CornerRadius * 2)
                .AddArc(ArcRect, 270, 90)

                ' bottom right arc
                ArcRect.Y = BorderRect.Bottom - (CornerRadius * 2)
                .AddArc(ArcRect, 0, 90)

                ' bottom left arc
                ArcRect.X = BorderRect.Left
                .AddArc(ArcRect, 90, 90)

                .CloseFigure()
            End With
        End If

        Return MyPath

    End Function

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'ucEyeDropper
        '
        Me.Name = "ucEyeDropper"
        Me.ResumeLayout(False)

    End Sub

    Private Sub ucEyeDropper_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region 'Painting 

End Class

#End Region

#Region "gEyedropperDesigner"
Public Class ucEyedropperDesigner
    Inherits ControlDesigner

    Public Overrides ReadOnly Property SelectionRules() As SelectionRules
        Get
            Return Windows.Forms.Design.SelectionRules.Visible _
                   Or Windows.Forms.Design.SelectionRules.Moveable
        End Get
    End Property

End Class
#End Region
