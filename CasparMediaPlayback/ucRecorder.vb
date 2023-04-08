Imports System.IO

Public Class ucRecorder

    Dim lengthfilename As Integer
    Dim filename As String
    Dim irecorder As Integer = 0
    Dim startingtimeofrecording As DateTime
    Private Sub cmdoutcasparcgwindowrecording_Click(sender As Object, e As EventArgs) Handles cmdoutcasparcgwindowrecording.Click
        On Error Resume Next
        outcasparcgwindown()
    End Sub
    Public Sub outcasparcgwindown()
        On Error Resume Next
        'This is important! If you have a child process on your form, it will terminate along with your form if you do not set its parent to Nothing
        If Not parentedProcess Is Nothing Then
            SetParent(parentedProcess.MainWindowHandle, Nothing)
        End If
    End Sub
    Private Sub cmdshowcasparcgwindowrecording_Click(sender As Object, e As EventArgs) Handles cmdshowcasparcgwindowrecording.Click
        On Error Resume Next
        SetProcessParent("casparcg", cmbscreenConsumres, pnlrecording)
    End Sub

    Private Sub cmdinput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdinput.Click
        On Error Resume Next
        If frmmediaplayer.cmdconnect.BackColor = Color.Green Then
            Dim str As String

            str = "play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " decklink " & cmbdecklinkforrecording.Text
            CasparDevice.SendString(str)

        End If
    End Sub

    Private Sub cmdlocaterecordingfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlocaterecordingfile.Click
        Process.Start("explorer.exe", "/select," & Replace(lblrecordingfilename.Text, "/", "\"))
    End Sub


    Private Sub cmdOpenFolderforRecording_Click(sender As Object, e As EventArgs) Handles cmdOpenFolderforRecording.Click
        On Error Resume Next

        Dim aa As New OpenFileDialog
        aa.DereferenceLinks = False
        aa.CheckFileExists = False
        aa.CheckPathExists = False
        aa.Filter = "folders|n"
        aa.Title = "Select Folder"
        aa.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media"
        aa.FileName = aa.InitialDirectory & "select folder"
        If aa.ShowDialog() = DialogResult.OK Then
            lblRecordingFolder.Text = Directory.GetParent(aa.FileName).ToString & "\"
        End If

    End Sub

    Private Sub cmdopenintrimmer_Click(sender As Object, e As EventArgs) Handles cmdopenintrimmer.Click
        On Error Resume Next
        frmmediaplayer.rdotrimmer.Select()
        ucTrimmer.UcnewTrimmer11.openfileintrimmer(lblrecordingfilename.Text)
    End Sub

    Private Sub cmdremove_input_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremove_input.Click
        On Error Resume Next
        If frmmediaplayer.cmdconnect.BackColor = Color.Green Then
            Dim str = "stop " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer
            CasparDevice.SendString(str)

        End If
    End Sub

    Private Sub cmdhidegbrecording_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub cmdlooprecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlooprecord.Click
        On Error Resume Next
        If frmmediaplayer.cmdconnect.BackColor = Color.Green And sender.BackColor = Color.Red Then
            record()
            tmrrecorder.Interval = (txtinterval.Text) * 1000
            tmrrecorder.Enabled = True
            tmrrecordedfileinfo.Enabled = True

        End If
        lengthfilename = Len(txtfilename.Text)
        filename = txtfilename.Text
        irecorder = 0
    End Sub
    Private Sub cmdopenportsvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdopenportsvtr.Click
        On Error Resume Next
        openport()
    End Sub
    Sub openport()
        On Error Resume Next
        If sp.IsOpen = False Then
            sp.PortName = cmbportsvtr.Text
            sp.Encoding = System.Text.Encoding.Default
            sp.Open()
        End If
        tmrgettc.Enabled = True
    End Sub
    Private Sub cmdplayvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(CInt("&H20")) & Chr(1) & Chr(33))
    End Sub

    Private Sub cmdstopvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(0) & Chr(32))
    End Sub

    Private Sub cmdrewindvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrewindvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(32) & Chr(64))
    End Sub
    Private Sub cmdffvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdffvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(16) & Chr(48))
    End Sub

    Private Sub cmdinpointvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdinpointvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(64) & Chr(16) & Chr(80))
        lblinpointvtr.Text = lbltimecode.Text
    End Sub

    Private Sub cmdoutpointvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdoutpointvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(64) & Chr(17) & Chr(81))
        lbloutpointvtr.Text = lbltimecode.Text
    End Sub

    Private Sub cmdPreRollvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreRollvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(48) & Chr(80))
    End Sub

    Private Sub cmdejectvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdejectvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(15) & Chr(47))
    End Sub

    Private Sub cmdstandbyonvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstandbyonvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(5) & Chr(37))
    End Sub

    Private Sub cmdstandbyoffvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstandbyoffvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(4) & Chr(36))
    End Sub

    Private Sub cmdcuevtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcuevtr.Click
        On Error Resume Next

        Dim aa As Array = Split(dgvcuepointsvtr.CurrentRow.Cells(0).Value, ":")
        Dim bb As String = Chr(36) & Chr(49) & Chr(System.Convert.ToInt32(aa(3), 16)) & Chr(System.Convert.ToInt32(aa(2), 16)) & Chr(System.Convert.ToInt32(aa(1), 16)) & Chr(System.Convert.ToInt32(aa(0), 16)) &
         Chr(36 + 49 + System.Convert.ToInt32(aa(3), 16) + System.Convert.ToInt32(aa(2), 16) + System.Convert.ToInt32(aa(1), 16) + System.Convert.ToInt32(aa(0), 16))
        sp.WriteLine(bb)
    End Sub

    Private Sub cmdmarkvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmarkvtr.Click
        On Error Resume Next
        dgvcuepointsvtr.CurrentRow.Cells(0).Value = lbltimecode.Text
        dgvcuepointsvtr.Rows.Add()
        dgvcuepointsvtr.CurrentCell = dgvcuepointsvtr.Rows(dgvcuepointsvtr.CurrentRow.Index + 1).Cells(0)

    End Sub


    Sub bbb() Handles HScrollBarjogvtr.MouseLeave, HScrollBarvtr.MouseLeave, HScrollBarshuttlevtr.MouseLeave
        On Error Resume Next
        HScrollBarjogvtr.Value = 0
        HScrollBarvtr.Value = 0
        HScrollBarshuttlevtr.Value = 0
    End Sub

    Private Sub HScrollBarshuttlevtr_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HScrollBarshuttlevtr.ValueChanged
        On Error Resume Next
        Dim aa As Integer = HScrollBarshuttlevtr.Value
        If aa > 0 Then
            sp.WriteLine(Chr(33) & Chr(19) & Chr(aa) & Chr(33 + 19 + aa))
        Else
            sp.WriteLine(Chr(33) & Chr(35) & Chr(Math.Abs(aa)) & Chr(33 + 35 + Math.Abs(aa)))
        End If
    End Sub

    Private Sub HScrollBarvtr_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HScrollBarvtr.ValueChanged
        On Error Resume Next
        Dim aa As Integer = HScrollBarvtr.Value
        If aa > 0 Then
            sp.WriteLine(Chr(33) & Chr(18) & Chr(aa) & Chr(33 + 18 + aa))
        Else
            sp.WriteLine(Chr(33) & Chr(34) & Chr(Math.Abs(aa)) & Chr(33 + 34 + Math.Abs(aa)))
        End If
    End Sub

    Private Sub HScrollBarjogvtr_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HScrollBarjogvtr.ValueChanged
        On Error Resume Next
        Dim aa As Integer = HScrollBarjogvtr.Value
        If aa > 0 Then
            sp.WriteLine(Chr(33) & Chr(17) & Chr(aa) & Chr(33 + 17 + aa))
        Else
            sp.WriteLine(Chr(33) & Chr(33) & Chr(Math.Abs(aa)) & Chr(33 + 33 + Math.Abs(aa)))
        End If
    End Sub

    Private Sub cmdrecordvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrecordvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(2) & Chr(32 + 2))
    End Sub

    Private Sub cmdautoeditvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdautoeditvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(66) & Chr(32 + 66))
    End Sub

    Private Sub cmdpreviewvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpreviewvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(64) & Chr(32 + 64))
    End Sub

    Private Sub cmdReviewvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReviewvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(65) & Chr(32 + 65))
    End Sub

    Private Sub cmdplusoneframevtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplusoneframevtr.Click
        On Error Resume Next

        Dim aa As Array = Split(lbltimecode.Text, ":")
        Dim bb As String = Chr(36) & Chr(49) & Chr(System.Convert.ToInt32(aa(3), 16) + 1) & Chr(System.Convert.ToInt32(aa(2), 16)) & Chr(System.Convert.ToInt32(aa(1), 16)) & Chr(System.Convert.ToInt32(aa(0), 16)) &
         Chr(36 + 49 + System.Convert.ToInt32(aa(3), 16) + 1 + System.Convert.ToInt32(aa(2), 16) + System.Convert.ToInt32(aa(1), 16) + System.Convert.ToInt32(aa(0), 16))
        sp.WriteLine(bb)
    End Sub

    Private Sub cmdminusoneframevtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdminusoneframevtr.Click
        On Error Resume Next

        Dim aa As Array = Split(lbltimecode.Text, ":")

        Dim bb As String = Chr(36) & Chr(49) & Chr(System.Convert.ToInt32(aa(3) - 1, 16)) & Chr(System.Convert.ToInt32(aa(2), 16)) & Chr(System.Convert.ToInt32(aa(1), 16)) & Chr(System.Convert.ToInt32(aa(0), 16)) &
         Chr(36 + 49 + System.Convert.ToInt32(aa(3) - 1, 16) + System.Convert.ToInt32(aa(2), 16) + System.Convert.ToInt32(aa(1), 16) + System.Convert.ToInt32(aa(0), 16))
        sp.WriteLine(bb)
    End Sub

    Private Sub cmdassembleonvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdassembleonvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(66) & Chr(48) & Chr(32) & Chr(0) & Chr(66 + 48 + 32 + 0))
    End Sub

    Private Sub cmdassembleoffvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdassembleoffvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(66) & Chr(48) & Chr(0) & Chr(0) & Chr(66 + 48 + 0 + 0))
    End Sub


    Private Sub cmdstoplooprecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstoplooprecord.Click
        On Error Resume Next
        stoprecord()
        txtfilename.Text = ""
        tmrrecorder.Enabled = False
        tmrrecordedfileinfo.Enabled = False

    End Sub

    Sub record()
        On Error Resume Next
        lblRecordedduration.Text = ""
        lblRecordedSize.Text = ""

        Dim str As String
        str = "ADD " & g_int_ChannelNumber & " FILE " & """" & Replace(Mid(lblRecordingFolder.Text, Len(mediafullpath) + 1), "\", "/") & "/" & txtfilename.Text & "." & mp4.Text & """" & " -b:v " & Val(txtbitrate.Text) * 1000000 & " " & txtextrarecordoptions.Text
        CasparDevice.SendString(str)

        startingtimeofrecording = Now
        If frmmediaplayer.cmdconnect.BackColor = Color.Green Then cmdlooprecord.BackColor = Color.Green
    End Sub
    Sub stoprecord()
        On Error Resume Next
        Dim str As String
        str = "REMOVE " & g_int_ChannelNumber & " FILE " & "/" & txtfilename.Text & "." & mp4.Text

        CasparDevice.SendString(str)
        cmdlooprecord.BackColor = Color.Red
    End Sub





    'synch record code start
    Private Sub cmdstopsr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopsr.Click
        On Error Resume Next
        tmrsr.Enabled = False
        tmrrecordedfileinfo.Enabled = False
        stoprecord()
    End Sub

    Private Sub cmdinpointsr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdinpointsr.Click
        On Error Resume Next
        txtinpointsr.Text = lbltimecode.Text
    End Sub

    Private Sub cmdoutpointsr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdoutpointsr.Click
        On Error Resume Next
        txtoutpointsr.Text = lbltimecode.Text
    End Sub

    Private Sub cmdstartsr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstartsr.Click
        On Error Resume Next
        tmrsr.Enabled = True

    End Sub
    Private Sub tmrsr_Tick(sender As Object, e As EventArgs) Handles tmrsr.Tick

        On Error Resume Next
        If lbltimecode.Text = txtinpointsr.Text Then
            record()
            tmrrecordedfileinfo.Enabled = True
        ElseIf lbltimecode.Text = txtoutpointsr.Text Then
            stoprecord()
            tmrrecordedfileinfo.Enabled = False
            tmrsr.Enabled = False
        End If
    End Sub

    Private Sub tmrrecorder_Tick(sender As Object, e As EventArgs) Handles tmrrecorder.Tick

        On Error Resume Next

        stoprecord()
        If chksinglecliprecord.Checked = False Then
            irecorder = irecorder + 1
            txtfilename.Text = filename & "_" & irecorder
            record()
        Else
            tmrrecorder.Enabled = False
            tmrrecordedfileinfo.Enabled = False
        End If
    End Sub


    Private Sub tmrrecordedfileinfo_Tick(sender As Object, e As EventArgs) Handles tmrrecordedfileinfo.Tick

        On Error Resume Next
        lblrecordingfilename.Text = lblRecordingFolder.Text & txtfilename.Text & "." & mp4.Text
        If File.Exists(lblrecordingfilename.Text) Then
            Dim f As New FileInfo(lblrecordingfilename.Text)

            Dim recoredduration As TimeSpan = Now - startingtimeofrecording
            lblRecordedduration.Text = recoredduration.ToString("hh\:mm\:ss")
            lblRecordedSize.Text = f.Length / 1000000 & " MB"

        Else
        End If


        lblfreespace.Text = Int(My.Computer.FileSystem.GetDriveInfo(Mid(mediafullpath, 1, 2)).TotalFreeSpace / 1000000000) & " GB"
    End Sub
    'vtr code---------------

    Sub GetSerialPortNames()
        On Error Resume Next
        cmbportsvtr.Items.AddRange(IO.Ports.SerialPort.GetPortNames())
    End Sub

    Private Sub initialisedatafordgvcuepointsvtr()
        dgvcuepointsvtr.Rows.Add(10)
        dgvcuepointsvtr.Rows(0).Cells(0).Value = "00:00:00:00"
        dgvcuepointsvtr.Rows(1).Cells(0).Value = "00:01:00:00"
        dgvcuepointsvtr.Rows(2).Cells(0).Value = "00:02:00:00"
        dgvcuepointsvtr.Rows(3).Cells(0).Value = "00:03:00:00"
        dgvcuepointsvtr.Rows(4).Cells(0).Value = "00:04:00:00"
        dgvcuepointsvtr.Rows(5).Cells(0).Value = "00:05:00:00"
        dgvcuepointsvtr.Rows(6).Cells(0).Value = "00:06:00:00"
        dgvcuepointsvtr.Rows(7).Cells(0).Value = "00:07:00:00"
        dgvcuepointsvtr.Rows(8).Cells(0).Value = "00:08:00:00"
        dgvcuepointsvtr.Rows(9).Cells(0).Value = "00:09:00:00"
        dgvcuepointsvtr.CurrentCell = dgvcuepointsvtr.Rows(2).Cells(0)
    End Sub


    Private Sub tmrgettc_Tick(sender As Object, e As EventArgs) Handles tmrgettc.Tick
        On Error Resume Next
        sp.WriteLine(Chr(97) & Chr(12) & Chr(1) & Chr(110))
        Threading.Thread.Sleep(15)

        Dim timecode As String = ""
        Dim bb As String = sp.ReadExisting

        Dim str As String = ""
        For ivtr = 3 To Len(bb) - 1
            str = Mid(bb, ivtr, 1)
            Dim byteArray() As Byte
            byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(str)
            timecode = Val(Hex(byteArray(0))).ToString("00") & ":" & timecode

        Next

        lbltimecode.Text = Mid(timecode, 13, 11)
    End Sub



    Private Sub ucRecorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbscreenConsumres.DataSource = screenConsumres
        cmbscreenConsumres.Text = "Screen consumer [1|PAL]"
        GetSerialPortNames()
        initialisedatafordgvcuepointsvtr()

        lblRecordingFolder.Text = mediafullpath
    End Sub

    Private Sub cmbRecordingProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRecordingProfile.SelectedIndexChanged
        If cmbRecordingProfile.Text = "dvcam" Then
            txtextrarecordoptions.Text = "-codec:v dvvideo -codec:a pcm_s16le -pix_fmt yuv420p -vf setdar=4:3"
            txtbitrate.Text = 25
            mp4.Text = "mxf"
        End If

        If cmbRecordingProfile.Text = "dvcpro" Then
            txtextrarecordoptions.Text = "-codec:v dvvideo -codec:a pcm_s16le -pix_fmt yuv411p -vf setdar=4:3"
            txtbitrate.Text = 25
            mp4.Text = "mxf"
        End If

        If cmbRecordingProfile.Text = "dvcpro50" Then
            txtextrarecordoptions.Text = "-codec:v dvvideo -codec:a pcm_s16le -pix_fmt yuv422p -vf setdar=4:3"
            txtbitrate.Text = 50
            mp4.Text = "mxf"
        End If


        If cmbRecordingProfile.Text = "dvcproHD" Then
            txtextrarecordoptions.Text = "-codec:v dvvideo -codec:a pcm_s16le -pix_fmt yuv422p"
            txtbitrate.Text = 100
            mp4.Text = "mxf"
        End If

        If cmbRecordingProfile.Text = "AlphaVideo" Then
            txtextrarecordoptions.Text = "-codec:v prores_ks -pix_fmt yuva444p10le"
            txtbitrate.Text = 50
            mp4.Text = "mov"
        End If

        If cmbRecordingProfile.Text = "AlphaVideo2" Then
            txtextrarecordoptions.Text = "-codec:v qtrle"
            txtbitrate.Text = 50
            mp4.Text = "mov"
        End If

        If cmbRecordingProfile.Text = "H264" Then
            txtextrarecordoptions.Text = "-codec:v libx264"
            txtbitrate.Text = 12
            mp4.Text = "mp4"
        End If

        If cmbRecordingProfile.Text = "H265" Then
            If Mid(frmmediaplayer.lblserverversion.Text, 1, 3) = "2.0" Then
                txtextrarecordoptions.Text = "-codec:v libx265 -strict experimental -aspect 4:3"
            Else
                txtextrarecordoptions.Text = "-codec:v libx265 -strict experimental -vf setdar=4:3"
            End If

            txtbitrate.Text = 12
            mp4.Text = "mp4"
        End If

        If cmbRecordingProfile.Text = "XDCAMHD422" Then
            txtextrarecordoptions.Text = "-codec:a pcm_s24le -codec:v mpeg2video -pix_fmt yuv422p -alternate_scan 1  -g 12 -bf 2 -minrate 50000k -maxrate 50000k  -timecode 00:02:00:00 -metadata creation_time=now -color_primaries bt709 -color_trc 1  -colorspace 1 -f mxf mono_streams"
            txtbitrate.Text = 50
            mp4.Text = "mxf"
        End If

        If cmbRecordingProfile.Text = "IMX30" Then
            txtextrarecordoptions.Text = "-codec:a pcm_s16le -codec:v mpeg2video -pix_fmt yuv422p -alternate_scan 1  -g 1  -minrate 30000k -maxrate 30000k  -timecode 17:28:07:10 -metadata creation_time=now -color_primaries bt470bg -color_trc 1  -colorspace bt470bg -vf setdar=4:3 -f mxf_d10 -d10_channelcount 8"
            txtbitrate.Text = 30
            mp4.Text = "mxf"
        End If

        If cmbRecordingProfile.Text = "IMX40" Then
            txtextrarecordoptions.Text = "-codec:a pcm_s16le -codec:v mpeg2video -pix_fmt yuv422p -alternate_scan 1  -g 1  -minrate 40000k -maxrate 40000k  -timecode 17:28:07:10 -metadata creation_time=now -color_primaries bt470bg -color_trc 1  -colorspace bt470bg -vf setdar=4:3 -f mxf_d10 -d10_channelcount 8"
            txtbitrate.Text = 40
            mp4.Text = "mxf"
        End If


        If cmbRecordingProfile.Text = "IMX50" Then
            txtextrarecordoptions.Text = "-codec:a pcm_s16le -codec:v mpeg2video -pix_fmt yuv422p -alternate_scan 1  -g 1  -minrate 50000k -maxrate 50000k  -timecode 17:28:07:10 -metadata creation_time=now -color_primaries bt470bg -color_trc 1  -colorspace bt470bg -vf setdar=4:3 -f mxf_d10 -d10_channelcount 8"
            txtbitrate.Text = 50
            mp4.Text = "mxf"
        End If
        If cmbRecordingProfile.Text = "MP3 Audio only" Then
            txtextrarecordoptions.Text = "-codec:a libmp3lame"
            txtbitrate.Text = 1
            mp4.Text = "mp3"
        End If


    End Sub

    Private Sub cmbvideocodec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbvideocodec.SelectedIndexChanged
        On Error Resume Next
        Dim aa() = Split(txtextrarecordoptions.Text, " ")
        Dim ii As Integer = 0
        For ii = 0 To aa.Count
            If aa(ii) = "-codec:v" Then Exit For
        Next
        If ii < aa.Count Then
            txtextrarecordoptions.Text = Replace(txtextrarecordoptions.Text, aa(ii + 1), cmbvideocodec.Text)
        Else
            txtextrarecordoptions.Text = "-codec:v " & cmbvideocodec.Text & " " & txtextrarecordoptions.Text
        End If
    End Sub

    Private Sub cmbaudiocodec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbaudiocodec.SelectedIndexChanged
        On Error Resume Next
        Dim aa() = Split(txtextrarecordoptions.Text, " ")
        Dim ii As Integer = 0
        For ii = 0 To aa.Count
            If aa(ii) = "-codec:a" Then Exit For
        Next
        If ii < aa.Count Then
            txtextrarecordoptions.Text = Replace(txtextrarecordoptions.Text, aa(ii + 1), cmbaudiocodec.Text)
        Else
            txtextrarecordoptions.Text = "-codec:a " & cmbaudiocodec.Text & " " & txtextrarecordoptions.Text
        End If
    End Sub
End Class
