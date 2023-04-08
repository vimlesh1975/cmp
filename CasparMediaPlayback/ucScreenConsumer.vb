Public Class ucScreenConsumer
    Public parentedProcess1 As Process
    Private Sub Cmdshowcasparcgwindowrecording_Click(sender As Object, e As EventArgs) Handles cmdshowcasparcgwindowrecording.Click
        On Error Resume Next
        SetProcessParentrecorder("casparcg", cmbscreenConsumres, pnlrecording)
    End Sub

    Public Sub SetProcessParentrecorder(ByVal processName As String, ByVal cmb As ComboBox, ByVal pnl As Panel)
        On Error Resume Next

        Dim processes() As Process = Process.GetProcessesByName(processName)
        Dim iprocess As Integer

        For iprocess = 0 To processes.GetUpperBound(0)
            If processes(iprocess).MainWindowTitle = cmb.Text Then Exit For
        Next

        parentedProcess1 = processes(iprocess)
        SetParent(parentedProcess1.MainWindowHandle, pnl.Handle)
        SendMessage(parentedProcess1.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)

    End Sub

    Private Sub Cmdoutcasparcgwindowrecording_Click(sender As Object, e As EventArgs) Handles cmdoutcasparcgwindowrecording.Click
        On Error Resume Next
        If Not parentedProcess1 Is Nothing Then
            SetParent(parentedProcess1.MainWindowHandle, Nothing)
        End If
    End Sub

    Private Sub ucScreenConsumer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbscreenConsumres.DataSource = New BindingSource(screenConsumres, "")
        cmbscreenConsumres.Text = "Screen consumer [2|PAL]"
    End Sub
End Class
