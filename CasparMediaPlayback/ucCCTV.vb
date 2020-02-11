Imports Svt.Caspar
Public Class ucCCTV
    Sub sendCommand(intIP As Integer)
        On Error Resume Next
        CasparDevice.SendString("play 1-1 rtsp://" & txtUserName.Text & ":" & txtPassword.Text & "@" & txtIpNetwork.Text & intIP & ":" & txtipport.Text)
    End Sub
    Private Sub ucCCTV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next

        openbydefalt()
    End Sub
    Sub clearall()
        On Error Resume Next
        CasparDevice.SendString("clear 1")
        CasparDevice.SendString("mixer 1 clear")
    End Sub

    Private Sub Cmd20_Click(sender As Object, e As EventArgs) Handles _
           cmd20.Click _
         , cmd21.Click _
         , cmd22.Click _
         , cmd23.Click _
         , cmd24.Click _
         , cmd25.Click _
         , cmd26.Click _
         , cmd27.Click _
         , cmd28.Click _
         , cmd29.Click _
         , cmd30.Click _
         , cmd31.Click _
         , cmd32.Click _
         , cmd33.Click _
         , cmd34.Click _
         , cmd35.Click _
         , cmd36.Click _
         , cmd37.Click _
         , cmd38.Click _
         , cmd39.Click _
         , cmd40.Click _
         , cmd41.Click _
         , cmd42.Click _
         , cmd43.Click _
         , cmd44.Click _
         , cmd45.Click _
         , cmd46.Click _
         , cmd47.Click _
         , cmd48.Click _
         , cmd49.Click _
         , cmd50.Click _
         , cmd51.Click _
         , cmd52.Click _
         , cmd53.Click _
         , cmd54.Click _
         , cmd55.Click _
         , cmd56.Click _
         , cmd57.Click _
         , cmd58.Click _
         , cmd59.Click _
         , cmd60.Click _
         , cmd61.Click _
         , cmd62.Click _
         , cmd63.Click
        On Error Resume Next
        sendCommand(sender.tag)
    End Sub

    Sub fourcamera(ip1 As Integer, ip2 As Integer, ip3 As Integer, ip4 As Integer)
        On Error Resume Next
        CasparDevice.SendString("play 1-1 rtsp://" & txtUserName.Text & ":" & txtPassword.Text & "@" & txtIpNetwork.Text & "" & ip1 & ":" & txtipport.Text)
        CasparDevice.SendString("play 1-2 rtsp://" & txtUserName.Text & ":" & txtPassword.Text & "@" & txtIpNetwork.Text & "" & ip2 & ":" & txtipport.Text)
        CasparDevice.SendString("play 1-3 rtsp://" & txtUserName.Text & ":" & txtPassword.Text & "@" & txtIpNetwork.Text & "" & ip3 & ":" & txtipport.Text)
        CasparDevice.SendString("play 1-4 rtsp://" & txtUserName.Text & ":" & txtPassword.Text & "@" & txtIpNetwork.Text & "" & ip4 & ":" & txtipport.Text)
        CasparDevice.SendString("mixer 1 grid 2")
    End Sub

    Private Sub Send1_Click(sender As Object, e As EventArgs) Handles Send1.Click
        On Error Resume Next
        fourcamera(cmd20.Tag, cmd21.Tag, cmd22.Tag, cmd23.Tag)
    End Sub

    Private Sub Send2_Click(sender As Object, e As EventArgs) Handles Send2.Click
        On Error Resume Next
        fourcamera(cmd24.Tag, cmd25.Tag, cmd26.Tag, cmd27.Tag)
    End Sub

    Private Sub Send3_Click(sender As Object, e As EventArgs) Handles Send3.Click
        On Error Resume Next
        fourcamera(cmd28.Tag, cmd29.Tag, cmd30.Tag, cmd31.Tag)
    End Sub

    Private Sub Send4_Click(sender As Object, e As EventArgs) Handles Send4.Click
        On Error Resume Next
        fourcamera(cmd32.Tag, cmd33.Tag, cmd34.Tag, cmd35.Tag)
    End Sub

    Private Sub Send5_Click(sender As Object, e As EventArgs) Handles Send5.Click
        On Error Resume Next
        fourcamera(cmd36.Tag, cmd37.Tag, cmd38.Tag, cmd39.Tag)
    End Sub

    Private Sub Send6_Click(sender As Object, e As EventArgs) Handles Send6.Click
        On Error Resume Next
        fourcamera(cmd40.Tag, cmd41.Tag, cmd42.Tag, cmd43.Tag)
    End Sub

    Private Sub Send7_Click(sender As Object, e As EventArgs) Handles Send7.Click
        On Error Resume Next
        fourcamera(cmd44.Tag, cmd45.Tag, cmd46.Tag, cmd47.Tag)
    End Sub

    Private Sub Send8_Click(sender As Object, e As EventArgs) Handles Send8.Click
        On Error Resume Next
        fourcamera(cmd48.Tag, cmd49.Tag, cmd50.Tag, cmd51.Tag)
    End Sub

    Private Sub send9_Click(sender As Object, e As EventArgs) Handles Send9.Click
        On Error Resume Next
        fourcamera(cmd52.Tag, cmd53.Tag, cmd54.Tag, cmd55.Tag)
    End Sub

    Private Sub send10_Click(sender As Object, e As EventArgs) Handles send10.Click
        On Error Resume Next
        fourcamera(cmd56.Tag, cmd57.Tag, cmd58.Tag, cmd59.Tag)
    End Sub

    Private Sub Send11_Click(sender As Object, e As EventArgs) Handles Send11.Click
        On Error Resume Next
        fourcamera(cmd60.Tag, cmd61.Tag, cmd62.Tag, cmd63.Tag)
    End Sub
    Dim bb = 1
    Dim cc = 1
    Private Sub TmrSwitch_Tick(sender As Object, e As EventArgs) Handles tmrSwitch.Tick
        On Error Resume Next

        If rdo1Camera.Checked Then
            CasparDevice.SendString("play 1-1 rtsp://" & txtUserName.Text & ":" & txtPassword.Text & "@" & txtIpNetwork.Text & 19 + cc & ":" & txtipport.Text)
            cc = cc + 1
            If cc > Val(txtTotalCameras.Text) Then cc = 1
        Else
            CasparDevice.SendString("mixer 1 grid 2")
            If bb = 1 Then
                Send1.PerformClick()
            End If
            If bb = 2 Then
                Send2.PerformClick()
            End If
            If bb = 3 Then
                Send3.PerformClick()
            End If
            If bb = 4 Then
                Send4.PerformClick()
            End If

            If bb = 5 Then
                Send5.PerformClick()
            End If

            If bb = 6 Then
                Send6.PerformClick()
            End If
            If bb = 7 Then
                Send7.PerformClick()
            End If
            If bb = 8 Then
                Send8.PerformClick()
            End If
            If bb = 9 Then
                Send9.PerformClick()
            End If
            If bb = 10 Then
                send10.PerformClick()
            End If
            If bb = 11 Then
                Send11.PerformClick()
            End If
            bb = bb + 1
            If bb > Math.Ceiling(Val(txtTotalCameras.Text) / 4) Then bb = 1
        End If
    End Sub
    Private Sub chkSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles chkSwitch.CheckedChanged
        On Error Resume Next
        tmrSwitch.Interval = Val(txtInterval.Text) * 1000
        If chkSwitch.Checked Then
            tmrSwitch.Enabled = True
        Else
            tmrSwitch.Enabled = False
        End If
    End Sub

    Private Sub cmdStopall_Click(sender As Object, e As EventArgs) Handles cmdStopall.Click
        On Error Resume Next
        clearall()
    End Sub

    Private Sub txtInterval_TextChanged(sender As Object, e As EventArgs) Handles txtInterval.TextChanged
        On Error Resume Next
        tmrSwitch.Interval = Val(txtInterval.Text) * 1000
    End Sub
    Private Sub Rdo4Camera_CheckedChanged(sender As Object, e As EventArgs) Handles rdo4Camera.CheckedChanged, rdo1Camera.CheckedChanged
        On Error Resume Next
        If rdo4Camera.Checked Then
            CasparDevice.SendString("mixer 1 grid 2")
        Else
            CasparDevice.SendString("mixer 1 clear")
        End If
    End Sub
    Private Sub cmdOpenCameraList_Click(sender As Object, e As EventArgs) Handles cmdOpenCameraList.Click
        'On Error Resume Next
        Dim ofd1 As New OpenFileDialog
        ofd1.InitialDirectory = "c:\casparcg\mydata\cctv\"
        If ofd1.ShowDialog = DialogResult.OK Then
            Dim objReader As New System.IO.StreamReader(ofd1.FileName)
            For i = 1 To 44
                Dim ss As String = objReader.ReadLine()
                cmdOpenCameraList.Parent.Controls("cmd" & 19 + i).Text = Split(ss, "(")(0)
                cmdOpenCameraList.Parent.Controls("cmd" & 19 + i).Tag = Split(Split(ss, "(")(1), ")")(0)
            Next
            objReader.Dispose()
        End If
    End Sub
    Sub openbydefalt()
        On Error Resume Next
        Dim objReader As New System.IO.StreamReader("c:\casparcg\mydata\cctv\cctv1.txt")
        For i = 1 To 44
            Dim ss As String = objReader.ReadLine()
            cmdOpenCameraList.Parent.Controls("cmd" & 19 + i).Text = Split(ss, "(")(0)
            cmdOpenCameraList.Parent.Controls("cmd" & 19 + i).Tag = Split(Split(ss, "(")(1), ")")(0)
        Next
        objReader.Dispose()
    End Sub

    Private Sub CmdEditCameraList_Click(sender As Object, e As EventArgs) Handles cmdEditCameraList.Click
        On Error Resume Next
        Process.Start("c:\casparcg\mydata\cctv\cctv1.txt")
    End Sub
    Private Sub Cmdhide_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox(cmd20.Parent.ToString)
    End Sub
End Class
