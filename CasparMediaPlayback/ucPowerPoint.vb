Imports System.IO
Public Class ucPowerPoint
    Dim strpowerpoint As String
    Dim fsw As New FileSystemWatcher
    Private Sub cmdhidegbppt_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Private Sub cmdstarPowerPointoutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstarPowerPointoutput.Click
        On Error Resume Next
        If rdojpg.Checked Then
            strpowerpoint = "play " & g_int_ChannelNumber & "-" & cmblayervideoforppt.Text & " jpg" & g_int_ChannelNumber & " " & cmbtransitionforppt.Text & " " & ntransitiondurationforppt.Value & " " & cmbtweentypeforppt.Text & " " & cmbdirectionforppt.Text
        Else
            strpowerpoint = "play " & g_int_ChannelNumber & "-" & cmblayervideoforppt.Text & " png" & g_int_ChannelNumber & " " & cmbtransitionforppt.Text & " " & ntransitiondurationforppt.Value & " " & cmbtweentypeforppt.Text & " " & cmbdirectionforppt.Text
        End If
        CasparDevice.SendString(strpowerpoint)
        addfilesytemwatcherforpowerpoint()
    End Sub
    Sub addfilesytemwatcherforpowerpoint()
        On Error Resume Next
        fsw.Path = mediafullpath
        fsw.EnableRaisingEvents = True
        AddHandler fsw.Changed, AddressOf filemodified
    End Sub

    Sub filemodified(ByVal sender As Object, ByVal e As FileSystemEventArgs)
        'On Error Resume Next
        If e.Name = "jpg" & g_int_ChannelNumber & ".jpg" Or e.Name = "png" & g_int_ChannelNumber & ".png" Then
            SendString(NetStream, strpowerpoint & vbCrLf)
        End If
    End Sub

    Private Sub cmdstoppowerpointoutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstoppowerpointoutput.Click
        On Error Resume Next
        CasparDevice.SendString("stop " & g_int_ChannelNumber & "-" & cmblayervideoforppt.Text)
        removefilesytemwatcherforpowerpoint()
    End Sub
    Sub removefilesytemwatcherforpowerpoint()
        On Error Resume Next
        fsw.EnableRaisingEvents = False
    End Sub

    Private Sub cmdstartpowerpoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstartpowerpoint.Click
        On Error Resume Next
        Process.Start("c:/casparcg/mydata/ppt/pptm.pptm")
        Threading.Thread.Sleep(1000)
        SetProcessParent2("powerpnt", Panelpowerpoint)
    End Sub
    Private Sub SetProcessParent2(ByVal processName As String, ByVal cc As Control)
        On Error Resume Next
        Dim processes() As Process = Process.GetProcessesByName(processName)
        If processes.Length = 0 Then
            MessageBox.Show(processName & " Application is not running")
        Else
            If Not parentedProcess2 Is Nothing Then
                SetParent(parentedProcess2.MainWindowHandle, Nothing)
            End If
            parentedProcess2 = processes(0)
            SetParent(parentedProcess2.MainWindowHandle, cc.Handle)
            SendMessage(parentedProcess2.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)
        End If
    End Sub

    Private Sub cmdshowpowerpointwindow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshowpowerpointwindow.Click
        On Error Resume Next
        SetProcessParent2("powerpnt", Panelpowerpoint)
    End Sub

    Private Sub cmdoutPowerPointwindow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdoutPowerPointwindow.Click
        outpptorexcell()
    End Sub

    Private Sub cmdstartexcell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstartexcell.Click
        On Error Resume Next
        Process.Start("c:/casparcg/mydata/excel/chart.xlsm")
    End Sub

    Private Sub cmdshowexcellinwindow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshowexcellinwindow.Click
        On Error Resume Next
        SetProcessParent2("excel", Panelpowerpoint)
    End Sub

    Private Sub cmdoutexcelfromwindow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdoutexcelfromwindow.Click
        outpptorexcell()
    End Sub
    Sub outpptorexcell()
        On Error Resume Next
        If Not parentedProcess2 Is Nothing Then
            SetParent(parentedProcess2.MainWindowHandle, Nothing)
        End If
    End Sub
End Class
