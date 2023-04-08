Imports DirectShowLib
Imports AudioSwitcher.AudioApi.CoreAudio
Public Class ucStreamPlayer

    Dim bb
    Dim dd

    Private Sub cmdhidegbstreaming_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Private Sub ucStreamPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nw.Value = Screen.PrimaryScreen.Bounds.Width
        nw.Maximum = Screen.PrimaryScreen.Bounds.Width

        nh.Value = Screen.PrimaryScreen.Bounds.Height
        nh.Maximum = Screen.PrimaryScreen.Bounds.Height
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


    Private Sub cmbNDI_Click(sender As Object, e As EventArgs) Handles cmbNDI.Click

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
    Private Sub cmdSendNDI_Click(sender As Object, e As EventArgs) Handles cmdSendNDI.Click
        On Error Resume Next
        CasparDevice.SendString(txtNDI.Text & " " & cmbNDI.Text)
    End Sub
    Private Sub CmdSendNDI2_Click(sender As Object, e As EventArgs) Handles cmdSendNDI2.Click
        On Error Resume Next
        CasparDevice.SendString(txtNDI2.Text & " " & cmbNDI2.Text)
    End Sub
    Private Sub CmdSendNDI3_Click(sender As Object, e As EventArgs) Handles cmdSendNDI3.Click
        On Error Resume Next
        CasparDevice.SendString(txtNDI3.Text & " " & cmbNDI3.Text)
    End Sub
    Private Sub CmdSendNDI4_Click(sender As Object, e As EventArgs) Handles cmdSendNDI4.Click
        On Error Resume Next
        CasparDevice.SendString(txtNDI4.Text & " " & cmbNDI4.Text)
    End Sub

    Private Sub Cmdstopndi_Click(sender As Object, e As EventArgs) Handles cmdstopndi.Click
        On Error Resume Next
        CasparDevice.SendString("stop " & Mid(Split(txtNDI.Text, "play ")(1), 1, 3))
    End Sub

    Private Sub Cmdstopndi2_Click(sender As Object, e As EventArgs) Handles cmdstopndi2.Click
        On Error Resume Next
        CasparDevice.SendString("stop " & Mid(Split(txtNDI2.Text, "play ")(1), 1, 3))
    End Sub

    Private Sub Cmdstopndi3_Click(sender As Object, e As EventArgs) Handles cmdstopndi3.Click
        On Error Resume Next
        CasparDevice.SendString("stop " & Mid(Split(txtNDI3.Text, "play ")(1), 1, 3))
    End Sub

    Private Sub Cmdstopndi4_Click(sender As Object, e As EventArgs) Handles cmdstopndi4.Click
        On Error Resume Next
        CasparDevice.SendString("stop " & Mid(Split(txtNDI4.Text, "play ")(1), 1, 3))
    End Sub

    Private Sub CmdRefreshNDISources_Click(sender As Object, e As EventArgs) Handles cmdRefreshNDISources.Click
        Dim str As String
        str = "ndi list"
        SendString(NetStream, str + vbCrLf)
        getresponse()
    End Sub
    Sub getresponse()
        On Error Resume Next
        System.Threading.Thread.Sleep(250)
        Dim data(10024) As Byte
        NetStream.Read(data, 0, 10024)
        Dim returndata As String = ""
        returndata = System.Text.Encoding.UTF8.GetString(data)
        Dim aa = Split(returndata, vbNewLine)

        cmbNDI.Items.Clear()
        cmbNDI2.Items.Clear()
        cmbNDI3.Items.Clear()
        cmbNDI4.Items.Clear()

        For i = 1 To aa.Count - 3
            cmbNDI.Items.Add(Split(Mid(aa(i), 3), ")")(0) & ")" & """")
            cmbNDI2.Items.Add(Split(Mid(aa(i), 3), ")")(0) & ")" & """")
            cmbNDI3.Items.Add(Split(Mid(aa(i), 3), ")")(0) & ")" & """")
            cmbNDI4.Items.Add(Split(Mid(aa(i), 3), ")")(0) & ")" & """")

        Next

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start(LinkLabel2.Text)
    End Sub

    Private Sub Cmbcapturedevices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcapturedevices.SelectedIndexChanged
        On Error Resume Next
        If (cmbcapturedevices.Text = "UScreenCapture") Or (cmbcapturedevices.Text = "screen-capture-recorder") Then
            gbUscreen.Visible = True
        Else
            gbUscreen.Visible = False
        End If
    End Sub

    Private Sub Nx_ValueChanged(sender As Object, e As EventArgs) Handles nx.ValueChanged, ny.ValueChanged, nw.ValueChanged, nh.ValueChanged
        On Error Resume Next
        If nx.Value + nw.Value > nw.Maximum Then
            nw.Value = nw.Maximum - nx.Value
        End If

        If ny.Value + nh.Value > nh.Maximum Then
            nh.Value = nh.Maximum - ny.Value
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles cmdSetFullScreen.Click
        On Error Resume Next
        nx.Value = 0
        ny.Value = 0
        nw.Value = nw.Maximum
        nh.Value = nh.Maximum
    End Sub

    Private Sub CmdShowScreen_Click(sender As Object, e As EventArgs) Handles cmdShowScreen.Click
        On Error Resume Next
        sendcommandUscreenCommand()
    End Sub
    Sub sendcommandUscreenCommand()
        'CasparDevice.SendString("play 1-1 " & """" & "dshow://video=UScreenCapture" & """" & " filter crop=" & nw.Value & ":" & nh.Value & ":" & nx.Value & ":" & ny.Value)

        On Error Resume Next
        Dim filterstring As String = ""
        If ServerVersion > 2.1 Then
            filterstring = " vf crop=" & nw.Value & ":" & nh.Value & ":" & nx.Value & ":" & ny.Value
        Else
            filterstring = " filter crop=" & nw.Value & ":" & nh.Value & ":" & nx.Value & ":" & ny.Value
        End If

        If chkdshowVideo.Checked And chkDshowAudio.Checked Then
            CasparDevice.SendString(txtdirectshowproducer.Text & " " & """" & "dshow://video=" & cmbcapturedevices.Text & ":audio=" & cmbcapturedevicesAudio.Text & """" & filterstring)

        ElseIf chkdshowVideo.Checked And chkDshowAudio.Checked = False Then
            CasparDevice.SendString(txtdirectshowproducer.Text & " " & """" & "dshow://video=" & cmbcapturedevices.Text & """" & filterstring)

        ElseIf chkDshowAudio.Checked And chkdshowVideo.Checked = False Then
            CasparDevice.SendString(txtdirectshowproducer.Text & " " & """" & "dshow://audio=" & cmbcapturedevicesAudio.Text & """" & filterstring)

        End If
    End Sub

    Private Sub CmdSetRegionOfInterest_Click(sender As Object, e As EventArgs) Handles cmdSetRegionOfInterest.Click
        On Error Resume Next
        frmROI.Show()
    End Sub

    Private Sub cmdListDevices_Click(sender As Object, e As EventArgs) Handles cmdListDevices.Click
        lstPlaybackDevices.Items.Clear()
        lstCaptureDevices.Items.Clear()

        Dim aa As New CoreAudioController
        bb = aa.GetCaptureDevices()
        For i = 0 To bb.Count - 1
            lstCaptureDevices.Items.Add(bb(i).FullName)
        Next
        dd = aa.GetPlaybackDevices
        For i = 0 To dd.Count - 1
            lstPlaybackDevices.Items.Add(dd(i).FullName)
        Next

        Dim defaultCaptureDevice As CoreAudioDevice = New CoreAudioController().DefaultCaptureDevice
        lblDefaultcaptureDevice.Text = defaultCaptureDevice.FullName

        Dim defaultPlaybackDevice As CoreAudioDevice = New CoreAudioController().DefaultPlaybackDevice
        lblDefaultPlaybackDevice.Text = defaultPlaybackDevice.FullName

    End Sub

    Private Sub cmdsetDefaultplaybackdevice_Click(sender As Object, e As EventArgs) Handles cmdsetDefaultplaybackdevice.Click
        dd(lstPlaybackDevices.SelectedIndex).SetAsDefault

        Dim defaultPlaybackDevice As CoreAudioDevice = New CoreAudioController().DefaultPlaybackDevice
        lblDefaultPlaybackDevice.Text = defaultPlaybackDevice.FullName

    End Sub

    Private Sub cmdsetDefaultCapturedevice_Click(sender As Object, e As EventArgs) Handles cmdsetDefaultCapturedevice.Click
        bb(lstCaptureDevices.SelectedIndex).SetAsDefault
        Dim defaultCaptureDevice As CoreAudioDevice = New CoreAudioController().DefaultCaptureDevice
        lblDefaultcaptureDevice.Text = defaultCaptureDevice.FullName
    End Sub

    Private Sub cmdgetGetdefaultCaptureDevice_Click(sender As Object, e As EventArgs) Handles cmdgetGetdefaultCaptureDevice.Click
        Dim defaultCaptureDevice As CoreAudioDevice = New CoreAudioController().DefaultCaptureDevice
        lblDefaultcaptureDevice.Text = defaultCaptureDevice.FullName
    End Sub

    Private Sub cmdgetDefaultPlaybackDevice_Click(sender As Object, e As EventArgs) Handles cmdgetDefaultPlaybackDevice.Click
        Dim defaultPlaybackDevice As CoreAudioDevice = New CoreAudioController().DefaultPlaybackDevice
        lblDefaultPlaybackDevice.Text = defaultPlaybackDevice.FullName
    End Sub
    Private Sub cmdGetvolumeMixer_Click(sender As Object, e As EventArgs) Handles cmdGetvolumeMixer.Click
        SurroundingSub()
    End Sub
    Private Sub SurroundingSub()
        'On Error Resume Next
        pnlVolumeMixer.Controls.Clear()
        Dim processlist As Process() = Process.GetProcesses()
        Dim hh As Integer = 0
        For Each process As Process In processlist
            If VolumeMixer.GetApplicationVolume(process.Id) IsNot Nothing Then
                'lstProcesses.Items.Add(process.ProcessName & " # " & process.MainWindowTitle & " # " & process.Id & " # " & VolumeMixer.GetApplicationVolume(process.Id).ToString)
                Dim gg As New TrackBar
                gg.Orientation = Orientation.Vertical
                gg.Location = New Point(((100 * hh)), 0)

                gg.Height = 100
                gg.Maximum = 100

                AddHandler gg.Scroll, Sub(ByVal sender As System.Object, ByVal e As System.EventArgs)
                                          VolumeMixer.SetApplicationVolume(process.Id, gg.Value)
                                      End Sub
                pnlVolumeMixer.Controls.Add(gg)

                Try
                    gg.Value = VolumeMixer.GetApplicationVolume(process.Id)
                Catch ex As Exception
                End Try

                Dim lbl As New Label
                lbl.Height = 50
                lbl.Text = process.ProcessName & vbNewLine & process.MainWindowTitle
                lbl.Location = New Point(((100 * hh)), 100)
                pnlVolumeMixer.Controls.Add(lbl)

                Dim pic As New PictureBox
                pic.Location = New Point(((100 * hh)), 150)
                pnlVolumeMixer.Controls.Add(pic)
                Try
                    pic.Image = Icon.ExtractAssociatedIcon(process.MainModule.FileName).ToBitmap
                Catch ex As Exception
                End Try

                hh += 1
            End If
        Next

    End Sub

    Private Sub cmdRecord_Click(sender As Object, e As EventArgs) Handles cmdRecord.Click
        On Error Resume Next
        Dim command As String = "/K " & txtBinFolder.Text & txtRecord.Text
        Process.Start("CMD", command)
    End Sub
End Class
