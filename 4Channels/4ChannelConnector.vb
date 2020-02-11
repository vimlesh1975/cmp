Imports System.Environment
Imports System.IO
Imports System.Runtime.InteropServices
Public Class _4ChannelConnector

    Public parentedProcess1 As Process
    Private Const WM_SYSCOMMAND As Integer = 274
    Private Const SC_MAXIMIZE As Integer = 61488
    <Runtime.InteropServices.DllImport("user32.dll")>
    Public Shared Function SetParent(ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    End Function
    <Runtime.InteropServices.DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function
    Private Structure SENDSTRUCT
        Dim var1 As Integer
        Dim str1 As String
    End Structure
    Private WithEvents BS As New BuildString
    Public Sub SetProcessParent(ByVal processid As Integer, cntlhandle As IntPtr, ByRef parentedprocess As Process)
        On Error Resume Next
        parentedprocess = Process.GetProcessById(processid)
        If Not parentedprocess Is Nothing Then
            SetParent(parentedprocess.MainWindowHandle, Nothing)
        End If
        SetParent(parentedprocess.MainWindowHandle, cntlhandle)
        SendMessage(parentedprocess.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)
    End Sub
    Private Async Sub cmdStartCMP1_ClickAsync(sender As Object, e As EventArgs) Handles cmdStartCMP1.Click
        Dim myProcess As New Process
        Dim a1 As New Task(Sub()
                               myProcess.StartInfo.FileName = "C:\Program Files (x86)\Doordarshan\CasparMediaPlaybackSetup\caspar_media_playback.exe"
                               myProcess.Start()
                           End Sub
                           )
        a1.Start()

        Await a1
        txtChannel1.Text = myProcess.Id.ToString
        Threading.Thread.Sleep(3000)
        SetProcessParent(myProcess.Id, Me.Parent.Handle, parentedProcess1)

        Dim hwnd As Integer = parentedProcess1.MainWindowHandle.ToInt32
        If hwnd <> 0 Then
            BS.PostString(hwnd, &H400, 0, Me.Parent.Tag.ToString)

        End If
        Threading.Thread.Sleep(2000)
        ddd()
    End Sub

    Private Sub cmdinChannel1_Click(sender As Object, e As EventArgs) Handles cmdinChannel1.Click
        On Error Resume Next
        If Not parentedProcess1 Is Nothing Then
            SetParent(parentedProcess1.MainWindowHandle, Nothing)
        End If
        SetProcessParent(CType(txtChannel1.Text, Integer), Me.Parent.Handle, parentedProcess1)
        BS.PostString(parentedProcess1.MainWindowHandle.ToInt32, &H400, 0, Me.Parent.Tag.ToString)
        Threading.Thread.Sleep(3000)
        ddd()


    End Sub

    Private Sub cmdoutChannel1_Click(sender As Object, e As EventArgs) Handles cmdoutChannel1.Click
        On Error Resume Next
        If Not parentedProcess1 Is Nothing Then
            SetParent(parentedProcess1.MainWindowHandle, Nothing)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ddd()
    End Sub
    Sub ddd()

        BS.PostString(parentedProcess1.MainWindowHandle.ToInt32, &H400, 0, "move")
    End Sub

    Private Sub txtChannel1_TextChanged(sender As Object, e As EventArgs) Handles txtChannel1.TextChanged

    End Sub

    Private Sub txtChannel1_DragEnter(sender As Object, e As DragEventArgs) Handles txtChannel1.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub txtChannel1_DragDrop(sender As Object, e As DragEventArgs) Handles txtChannel1.DragDrop
        txtChannel1.Text = e.Data.GetData(DataFormats.Text).ToString
    End Sub

    Private Sub cmdResetCMP_Click(sender As Object, e As EventArgs) Handles cmdResetCMP.Click
        On Error Resume Next
        Dim di As DirectoryInfo = New DirectoryInfo(GetFolderPath(SpecialFolder.LocalApplicationData) & "\microsoft")
        Dim aa = di.GetDirectories("caspar_media_playback*")
        For i = 0 To aa.Count - 1
            aa(i).Delete(True)
        Next
    End Sub
End Class
