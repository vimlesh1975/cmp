Imports DirectShowLib
Public Class ucStreamPlayer
    Private Sub cmdhidegbstreaming_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Private Sub ucStreamPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdBinFolder_Click(sender As Object, e As EventArgs) Handles cmdBinFolder.Click
        On Error Resume Next
        Dim aa As New FolderBrowserDialog
        aa.SelectedPath = txtBinFolder.Text
        If aa.ShowDialog = DialogResult.OK Then
            txtBinFolder.Text = aa.SelectedPath & "\"
        End If
    End Sub
    Private Sub cmdMonitor_Click(sender As Object, e As EventArgs) Handles cmdMonitor.Click
        On Error Resume Next
        Dim command As String = "/K " & txtBinFolder.Text & txtmontor.Text
        Process.Start("CMD", command)
    End Sub


    Private Sub cmdDecklink_Click(sender As Object, e As EventArgs) Handles cmdDecklink.Click
        On Error Resume Next
        Dim command As String = "/K " & txtBinFolder.Text & txtDecklink.Text
        Process.Start("CMD", command)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(LinkLabel1.Text)
    End Sub

    Private Sub cmdStreamFromHere_Click(sender As Object, e As EventArgs) Handles cmdStreamFromHere.Click
        On Error Resume Next
        Dim command As String = "/K " & txtBinFolder.Text & txtStreamFromHere.Text
        Process.Start("CMD", command)
    End Sub

    Private Sub cmdDesktopDecklink_Click(sender As Object, e As EventArgs) Handles cmdDesktopDecklink.Click
        On Error Resume Next
        Dim command As String = "/K " & txtBinFolder.Text & txtDesktopDecklink.Text & " " & cmbDesktopDecklink.Text & " " & txtDesktopDecklink2.Text
        Process.Start("CMD", command)
    End Sub

    Private Sub cmdSendNDI_Click(sender As Object, e As EventArgs) Handles cmdSendNDI.Click
        On Error Resume Next
        CasparDevice.SendString(txtNDI.Text & " " & cmbNDI.Text)
    End Sub

    Private Sub cmdSendRTP_Click(sender As Object, e As EventArgs) Handles cmdSendRTP.Click
        On Error Resume Next
        CasparDevice.SendString(txtRTP.Text)
    End Sub

    Private Sub cmdUDP_Click(sender As Object, e As EventArgs) Handles cmdUDP.Click
        On Error Resume Next
        CasparDevice.SendString(txtUDP.Text)
    End Sub

    Private Sub cmdm3u8_Click(sender As Object, e As EventArgs) Handles cmdm3u8.Click
        On Error Resume Next
        CasparDevice.SendString(txtm3u8.Text)
    End Sub

    Private Sub cmdplayusbcamera_Click(sender As Object, e As EventArgs) Handles cmdplayusbcamera.Click
        On Error Resume Next
        If chkdshowVideo.Checked And chkDshowAudio.Checked Then
            CasparDevice.SendString(txtdirectshowproducer.Text & " " & """" & "dshow://video=" & cmbcapturedevices.Text & ":audio=" & cmbcapturedevicesAudio.Text & """")

        ElseIf chkdshowVideo.Checked And chkDshowAudio.Checked = False Then
            CasparDevice.SendString(txtdirectshowproducer.Text & " " & """" & "dshow://video=" & cmbcapturedevices.Text & """")

        ElseIf chkDshowAudio.Checked And chkdshowVideo.Checked = False Then
            CasparDevice.SendString(txtdirectshowproducer.Text & " " & """" & "dshow://audio=" & cmbcapturedevicesAudio.Text & """")

        End If
    End Sub
    Private Sub cmbcapturedevices_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcapturedevices.Click
        On Error Resume Next
        cmbcapturedevices.Items.Clear()
        For Each bb As DirectShowLib.DsDevice In DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice)
            cmbcapturedevices.Items.Add(bb.Name)
        Next
    End Sub
    Private Sub cmbcapturedevicesAudio_Click(sender As Object, e As EventArgs) Handles cmbcapturedevicesAudio.Click
        cmbcapturedevicesAudio.Items.Clear()
        For Each bb As DirectShowLib.DsDevice In DsDevice.GetDevicesOfCat(FilterCategory.AudioInputDevice)
            cmbcapturedevicesAudio.Items.Add(bb.Name)
        Next
    End Sub
    Private Sub cmdcopyon2ndchannel_Click(sender As Object, e As EventArgs) Handles cmdcopyon2ndchannel.Click
        On Error Resume Next
        CasparDevice.SendString(txtlayerproducer2.Text)
    End Sub

    Private Sub cmdplaychannelproducer_Click(sender As Object, e As EventArgs) Handles cmdplaychannelproducer.Click
        On Error Resume Next
        CasparDevice.SendString(txtchannelproducer.Text)
    End Sub

    Private Sub cmbNDI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNDI.SelectedIndexChanged

    End Sub
    Sub getresponse()
        On Error Resume Next
        Threading.Thread.Sleep(250)
        Dim data(10024) As Byte
        NetStream.Read(data, 0, 10024)
        Dim returndata As String = ""
        returndata = System.Text.Encoding.UTF8.GetString(data)
        Dim aa = Split(returndata, vbNewLine)

        cmbNDI.Items.Clear()
        For i = 1 To aa.Count - 3
            cmbNDI.Items.Add(Split(Mid(aa(i), 3), ")")(0) & ")" & """")
        Next

    End Sub

    Private Sub cmbNDI_Click(sender As Object, e As EventArgs) Handles cmbNDI.Click
        Dim str As String
        str = "ndi list"
        SendString(NetStream, str + vbCrLf)

        getresponse()
    End Sub


    Private Sub cmbDesktopDecklink_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDesktopDecklink.SelectedIndexChanged

    End Sub

    Private Sub cmbDesktopDecklink_Click(sender As Object, e As EventArgs) Handles cmbDesktopDecklink.Click
        On Error Resume Next
        cmbDesktopDecklink.Items.Clear()
        cmbDesktopDecklink.Items.Add("desktop")
        For Each p As Process In Process.GetProcesses

            If p.MainWindowTitle = String.Empty = False Then
                cmbDesktopDecklink.Items.Add("title=" & """" & p.MainWindowTitle & """")
            End If
        Next
    End Sub

    Private Sub cmdSendRTSP_Click(sender As Object, e As EventArgs) Handles cmdSendRTSP.Click
        On Error Resume Next
        CasparDevice.SendString(txtRTSP.Text)
    End Sub
End Class
