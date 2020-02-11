Public Class clsResizeableControl

    Private WithEvents mControl As Control
    Private mMouseDown As Boolean = False
    Private mEdge As EdgeEnum = EdgeEnum.None
    Private mWidth As Integer = 8
    Private mOutlineDrawn As Boolean = False
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Enum EdgeEnum
        None
        Right
        Left
        Top
        Bottom
        Moving
        BottomRight
        BottomLeft
        TopLeft
        TopRight
    End Enum

    Public Sub New(ByVal Control As Control)
        mControl = Control
    End Sub

    Private Sub mControl_MouseDown(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles mControl.MouseDown
        'CreateQuiz.QuizDesignPanel.Refresh()
        mouseX = e.X
        mouseY = e.Y
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mMouseDown = True
            ' CreateQuiz.ControlCreativePanel.Visible = False
            'CreateQuiz.PicCreativePanel.Visible = False
            'CreateQuiz.PanelCreativePanel.Visible = False
        End If
    End Sub

    Private Sub mControl_MouseUp(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles mControl.MouseUp
        mMouseDown = False
    End Sub



    Private SelControl As Control
    Private Sub mControl_MouseMove(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.MouseEventArgs) _
    Handles mControl.MouseMove
        If multimodulechek = True Then


            Dim c As Control = CType(sender, Control)
            Dim g As Graphics = c.CreateGraphics
            Select Case mEdge
                Case EdgeEnum.Moving
                    mOutlineDrawn = True
                Case EdgeEnum.BottomRight
                    DrawOrangeSquares(c, g)
                    g.FillRectangle(Brushes.Fuchsia,
               c.Width - mWidth, c.Height - mWidth, mWidth, mWidth)
                    mOutlineDrawn = True
                Case EdgeEnum.BottomLeft
                    DrawOrangeSquares(c, g)
                    g.FillRectangle(Brushes.Fuchsia,
               0, c.Height - mWidth, mWidth, mWidth)
                    mOutlineDrawn = True
                Case EdgeEnum.TopRight
                    DrawOrangeSquares(c, g)
                    g.FillRectangle(Brushes.Fuchsia,
                    c.Width - mWidth, 0, mWidth, mWidth)    'top right
                    mOutlineDrawn = True
                Case EdgeEnum.TopLeft
                    DrawOrangeSquares(c, g)
                    g.FillRectangle(Brushes.Fuchsia,
                    0, 0, mWidth, mWidth)    'top left
                    mOutlineDrawn = True
                Case EdgeEnum.Left
                    DrawOrangeSquares(c, g)
                    g.FillRectangle(Brushes.Fuchsia,
                    0, c.Height \ 2 - 4, mWidth, mWidth)            'left
                    mOutlineDrawn = True
                Case EdgeEnum.TopRight
                    DrawOrangeSquares(c, g)
                    g.FillRectangle(Brushes.Fuchsia,
                    c.Width - mWidth, 0, mWidth, mWidth)
                Case EdgeEnum.Right
                    DrawOrangeSquares(c, g)
                    g.FillRectangle(Brushes.Fuchsia,
                    c.Width - mWidth, c.Height \ 2 - 4, mWidth, mWidth)    'right
                    mOutlineDrawn = True
                Case EdgeEnum.Top
                    DrawOrangeSquares(c, g)
                    g.FillRectangle(Brushes.Fuchsia,
                    c.Width \ 2 - 4, 0, mWidth, mWidth)          'top
                    mOutlineDrawn = True
                Case EdgeEnum.Bottom
                    DrawOrangeSquares(c, g)
                    g.FillRectangle(Brushes.Fuchsia,
                        c.Width \ 2 - 4, c.Height - mWidth, mWidth, mWidth)   'bottom
                    mOutlineDrawn = True
                Case EdgeEnum.None
                    If mOutlineDrawn Then
                        c.Refresh()
                        mOutlineDrawn = False
                    End If
            End Select

            If mMouseDown And mEdge <> EdgeEnum.None Then
                ' MsgBox(c.ToString)
                c.SuspendLayout()
                Select Case mEdge
                    Case EdgeEnum.TopRight
                        c.SetBounds(c.Left, c.Top,
                c.Width - (c.Width - e.X), c.Height)
                        c.SetBounds(c.Left, c.Top + e.Y,
                c.Width, c.Height - e.Y)
                    Case EdgeEnum.TopLeft
                        c.SetBounds(c.Left + e.X, c.Top,
                 c.Width - e.X, c.Height)
                        c.SetBounds(c.Left, c.Top + e.Y,
                c.Width, c.Height - e.Y)
                    Case EdgeEnum.BottomRight
                        c.SetBounds(c.Left, c.Top,
                    c.Width - (c.Width - e.X), c.Height)
                        c.SetBounds(c.Left, c.Top,
                    c.Width, c.Height - (c.Height - e.Y))
                    Case EdgeEnum.BottomLeft
                        c.SetBounds(c.Left + e.X, c.Top,
                c.Width - e.X, c.Height)
                        c.SetBounds(c.Left, c.Top,
                    c.Width, c.Height - (c.Height - e.Y))
                    Case EdgeEnum.Left
                        c.SetBounds(c.Left + e.X, c.Top,
                c.Width - e.X, c.Height)
                    Case EdgeEnum.Right
                        c.SetBounds(c.Left, c.Top,
                c.Width - (c.Width - e.X), c.Height)
                    Case EdgeEnum.Top
                        c.SetBounds(c.Left, c.Top + e.Y,
                c.Width, c.Height - e.Y)
                    Case EdgeEnum.Bottom
                        c.SetBounds(c.Left, c.Top,
                c.Width, c.Height - (c.Height - e.Y))
                    Case EdgeEnum.Moving
                        c.SetBounds(c.Left + e.X - mouseX, c.Top + e.Y - mouseY,
                c.Width, c.Height)
                End Select
                c.ResumeLayout()
            Else
                Select Case True
                    Case e.X > c.Width - (mWidth) And
                        e.Y > c.Height - (mWidth) 'Bottom right corner
                        c.Cursor = Cursors.SizeNWSE
                        mEdge = EdgeEnum.BottomRight
                    Case e.X <= mWidth And
                       e.Y > c.Height - (mWidth) 'Bottom Left corner
                        c.Cursor = Cursors.SizeNESW
                        mEdge = EdgeEnum.BottomLeft
                    Case e.X > c.Width - (mWidth) And
                        e.Y <= mWidth 'Top Right corner
                        c.Cursor = Cursors.SizeNESW
                        mEdge = EdgeEnum.TopRight
                    Case e.X <= mWidth And
                        e.Y <= mWidth 'Top Left corner
                        c.Cursor = Cursors.SizeNWSE
                        mEdge = EdgeEnum.TopLeft
                    Case e.X <= mWidth And
                        e.Y >= c.Height \ 2 - 4 And e.Y _
                        <= c.Height \ 2 + 4 'left edge
                        c.Cursor = Cursors.SizeWE
                        mEdge = EdgeEnum.Left
                    Case e.X >= c.Width - mWidth And
                        e.Y >= c.Height \ 2 - 4 And e.Y _
                        <= c.Height \ 2 + 4 'right edge
                        c.Cursor = Cursors.SizeWE
                        mEdge = EdgeEnum.Right
                    Case e.X >= c.Width \ 2 - 4 And
                        e.X <= c.Width \ 2 + 4 And
                        e.Y <= mWidth 'top edge
                        c.Cursor = Cursors.SizeNS
                        mEdge = EdgeEnum.Top
                    Case e.X >= c.Width \ 2 - 4 And
                        e.X <= c.Width \ 2 + 4 And
                        e.Y >= c.Height - mWidth 'bottom edge
                        c.Cursor = Cursors.SizeNS
                        mEdge = EdgeEnum.Bottom
                    Case e.X <= c.Width And e.Y <= c.Height 'move
                        c.Cursor = Cursors.SizeAll
                        mEdge = EdgeEnum.Moving
                        DrawOrangeSquares(c, g)
                    Case Else 'no edge
                        c.Cursor = Cursors.Default
                        mEdge = EdgeEnum.None
                End Select
            End If

        End If
    End Sub

    Private Sub mControl_MouseLeave(ByVal sender As Object, _
        ByVal e As System.EventArgs) _
        Handles mControl.MouseLeave

        Dim c As Control = CType(sender, Control)
        mEdge = EdgeEnum.None
        c.Refresh()
        c.Cursor = Cursors.Default

    End Sub

    Sub DrawOrangeSquares(ByVal c As Control, ByVal g As Graphics)

        g.FillRectangle(Brushes.White, _
c.Width - mWidth - 1, c.Height - mWidth - 1, mWidth + 1, mWidth + 1)
        g.FillRectangle(Brushes.OrangeRed, _
c.Width - mWidth, c.Height - mWidth, mWidth, mWidth)   'bottom right

        g.FillRectangle(Brushes.White, _
        0, c.Height - mWidth - 1, mWidth + 1, mWidth + 1)
        g.FillRectangle(Brushes.OrangeRed, _
        0, c.Height - mWidth, mWidth, mWidth)   'bottom left

        g.FillRectangle(Brushes.White, _
        0, c.Height \ 2 - 5, mWidth + 1, mWidth + 2)
        g.FillRectangle(Brushes.OrangeRed, _
        0, c.Height \ 2 - 4, mWidth, mWidth)            'left

        g.FillRectangle(Brushes.White, _
        c.Width - mWidth - 1, c.Height \ 2 - 5, mWidth + 1, mWidth + 2)
        g.FillRectangle(Brushes.OrangeRed, _
        c.Width - mWidth, c.Height \ 2 - 4, mWidth, mWidth)    'right

        g.FillRectangle(Brushes.White, _
        c.Width \ 2 - 5, 0, mWidth + 2, mWidth + 1)
        g.FillRectangle(Brushes.OrangeRed, _
        c.Width \ 2 - 4, 0, mWidth, mWidth)          'top

        g.FillRectangle(Brushes.White, _
        c.Width \ 2 - 5, c.Height - mWidth - 1, mWidth + 2, mWidth + 1)
        g.FillRectangle(Brushes.OrangeRed, _
        c.Width \ 2 - 4, c.Height - mWidth, mWidth, mWidth)   'bottom

        g.FillRectangle(Brushes.White, _
        c.Width - mWidth - 1, 0, mWidth + 1, mWidth + 1)
        g.FillRectangle(Brushes.OrangeRed, _
        c.Width - mWidth, 0, mWidth, mWidth)    'top right

        g.FillRectangle(Brushes.White, _
        0, 0, mWidth + 1, mWidth + 1)
        g.FillRectangle(Brushes.OrangeRed, _
        0, 0, mWidth, mWidth)                'top left
    End Sub
End Class
