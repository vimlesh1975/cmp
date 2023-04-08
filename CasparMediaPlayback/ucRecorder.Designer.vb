<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucRecorder
    'Inherits System.Windows.Forms.UserControl
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbrecording = New System.Windows.Forms.GroupBox()
        Me.Label241 = New System.Windows.Forms.Label()
        Me.Label240 = New System.Windows.Forms.Label()
        Me.cmbaudiocodec = New System.Windows.Forms.ComboBox()
        Me.cmbvideocodec = New System.Windows.Forms.ComboBox()
        Me.cmbRecordingProfile = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlrecording = New System.Windows.Forms.Panel()
        Me.cmbscreenConsumres = New System.Windows.Forms.ComboBox()
        Me.cmdoutcasparcgwindowrecording = New System.Windows.Forms.Button()
        Me.cmdshowcasparcgwindowrecording = New System.Windows.Forms.Button()
        Me.Label233 = New System.Windows.Forms.Label()
        Me.cmbdecklinkforrecording = New System.Windows.Forms.ComboBox()
        Me.cmdopenintrimmer = New System.Windows.Forms.Button()
        Me.lblRecordingFolder = New System.Windows.Forms.Label()
        Me.cmdOpenFolderforRecording = New System.Windows.Forms.Button()
        Me.gbSynchRecording = New System.Windows.Forms.GroupBox()
        Me.cmdstopsr = New System.Windows.Forms.Button()
        Me.cmdstartsr = New System.Windows.Forms.Button()
        Me.txtoutpointsr = New System.Windows.Forms.TextBox()
        Me.txtinpointsr = New System.Windows.Forms.TextBox()
        Me.cmdoutpointsr = New System.Windows.Forms.Button()
        Me.cmdinpointsr = New System.Windows.Forms.Button()
        Me.Label173 = New System.Windows.Forms.Label()
        Me.cmdassembleoffvtr = New System.Windows.Forms.Button()
        Me.cmdassembleonvtr = New System.Windows.Forms.Button()
        Me.cmdplusoneframevtr = New System.Windows.Forms.Button()
        Me.cmdminusoneframevtr = New System.Windows.Forms.Button()
        Me.lbloutpointvtr = New System.Windows.Forms.Label()
        Me.lblinpointvtr = New System.Windows.Forms.Label()
        Me.cmdReviewvtr = New System.Windows.Forms.Button()
        Me.cmdpreviewvtr = New System.Windows.Forms.Button()
        Me.cmdautoeditvtr = New System.Windows.Forms.Button()
        Me.cmdrecordvtr = New System.Windows.Forms.Button()
        Me.lbljogvtr = New System.Windows.Forms.Label()
        Me.HScrollBarjogvtr = New System.Windows.Forms.HScrollBar()
        Me.lblshuttlevtr = New System.Windows.Forms.Label()
        Me.HScrollBarshuttlevtr = New System.Windows.Forms.HScrollBar()
        Me.lblvariablevtr = New System.Windows.Forms.Label()
        Me.HScrollBarvtr = New System.Windows.Forms.HScrollBar()
        Me.dgvcuepointsvtr = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdmarkvtr = New System.Windows.Forms.Button()
        Me.cmdcuevtr = New System.Windows.Forms.Button()
        Me.cmdPreRollvtr = New System.Windows.Forms.Button()
        Me.cmdejectvtr = New System.Windows.Forms.Button()
        Me.cmdstandbyoffvtr = New System.Windows.Forms.Button()
        Me.cmdstandbyonvtr = New System.Windows.Forms.Button()
        Me.lbltimecode = New System.Windows.Forms.Label()
        Me.cmdffvtr = New System.Windows.Forms.Button()
        Me.cmdstopvtr = New System.Windows.Forms.Button()
        Me.cmdrewindvtr = New System.Windows.Forms.Button()
        Me.cmdoutpointvtr = New System.Windows.Forms.Button()
        Me.cmdinpointvtr = New System.Windows.Forms.Button()
        Me.cmdplayvtr = New System.Windows.Forms.Button()
        Me.cmdopenportsvtr = New System.Windows.Forms.Button()
        Me.lblcomportsvtr = New System.Windows.Forms.Label()
        Me.cmbportsvtr = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label152 = New System.Windows.Forms.Label()
        Me.lblfreespace = New System.Windows.Forms.Label()
        Me.cmdlocaterecordingfile = New System.Windows.Forms.Button()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.lblRecordedSize = New System.Windows.Forms.Label()
        Me.lblRecordedduration = New System.Windows.Forms.Label()
        Me.lblrecordingfilename = New System.Windows.Forms.Label()
        Me.chksinglecliprecord = New System.Windows.Forms.CheckBox()
        Me.txtextrarecordoptions = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtfilename = New System.Windows.Forms.TextBox()
        Me.cmdremove_input = New System.Windows.Forms.Button()
        Me.mp4 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbitrate = New System.Windows.Forms.TextBox()
        Me.cmdlooprecord = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdstoplooprecord = New System.Windows.Forms.Button()
        Me.txtinterval = New System.Windows.Forms.TextBox()
        Me.lblinterval = New System.Windows.Forms.Label()
        Me.cmdinput = New System.Windows.Forms.Button()
        Me.tmrsr = New System.Windows.Forms.Timer(Me.components)
        Me.tmrrecorder = New System.Windows.Forms.Timer(Me.components)
        Me.tmrrecordedfileinfo = New System.Windows.Forms.Timer(Me.components)
        Me.sp = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrgettc = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbrecording.SuspendLayout()
        Me.gbSynchRecording.SuspendLayout()
        CType(Me.dgvcuepointsvtr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbrecording
        '
        Me.gbrecording.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.gbrecording.Controls.Add(Me.Label241)
        Me.gbrecording.Controls.Add(Me.Label240)
        Me.gbrecording.Controls.Add(Me.cmbaudiocodec)
        Me.gbrecording.Controls.Add(Me.cmbvideocodec)
        Me.gbrecording.Controls.Add(Me.cmbRecordingProfile)
        Me.gbrecording.Controls.Add(Me.Label2)
        Me.gbrecording.Controls.Add(Me.pnlrecording)
        Me.gbrecording.Controls.Add(Me.cmbscreenConsumres)
        Me.gbrecording.Controls.Add(Me.cmdoutcasparcgwindowrecording)
        Me.gbrecording.Controls.Add(Me.cmdshowcasparcgwindowrecording)
        Me.gbrecording.Controls.Add(Me.Label233)
        Me.gbrecording.Controls.Add(Me.cmbdecklinkforrecording)
        Me.gbrecording.Controls.Add(Me.cmdopenintrimmer)
        Me.gbrecording.Controls.Add(Me.lblRecordingFolder)
        Me.gbrecording.Controls.Add(Me.cmdOpenFolderforRecording)
        Me.gbrecording.Controls.Add(Me.gbSynchRecording)
        Me.gbrecording.Controls.Add(Me.Label173)
        Me.gbrecording.Controls.Add(Me.cmdassembleoffvtr)
        Me.gbrecording.Controls.Add(Me.cmdassembleonvtr)
        Me.gbrecording.Controls.Add(Me.cmdplusoneframevtr)
        Me.gbrecording.Controls.Add(Me.cmdminusoneframevtr)
        Me.gbrecording.Controls.Add(Me.lbloutpointvtr)
        Me.gbrecording.Controls.Add(Me.lblinpointvtr)
        Me.gbrecording.Controls.Add(Me.cmdReviewvtr)
        Me.gbrecording.Controls.Add(Me.cmdpreviewvtr)
        Me.gbrecording.Controls.Add(Me.cmdautoeditvtr)
        Me.gbrecording.Controls.Add(Me.cmdrecordvtr)
        Me.gbrecording.Controls.Add(Me.lbljogvtr)
        Me.gbrecording.Controls.Add(Me.HScrollBarjogvtr)
        Me.gbrecording.Controls.Add(Me.lblshuttlevtr)
        Me.gbrecording.Controls.Add(Me.HScrollBarshuttlevtr)
        Me.gbrecording.Controls.Add(Me.lblvariablevtr)
        Me.gbrecording.Controls.Add(Me.HScrollBarvtr)
        Me.gbrecording.Controls.Add(Me.dgvcuepointsvtr)
        Me.gbrecording.Controls.Add(Me.cmdmarkvtr)
        Me.gbrecording.Controls.Add(Me.cmdcuevtr)
        Me.gbrecording.Controls.Add(Me.cmdPreRollvtr)
        Me.gbrecording.Controls.Add(Me.cmdejectvtr)
        Me.gbrecording.Controls.Add(Me.cmdstandbyoffvtr)
        Me.gbrecording.Controls.Add(Me.cmdstandbyonvtr)
        Me.gbrecording.Controls.Add(Me.lbltimecode)
        Me.gbrecording.Controls.Add(Me.cmdffvtr)
        Me.gbrecording.Controls.Add(Me.cmdstopvtr)
        Me.gbrecording.Controls.Add(Me.cmdrewindvtr)
        Me.gbrecording.Controls.Add(Me.cmdoutpointvtr)
        Me.gbrecording.Controls.Add(Me.cmdinpointvtr)
        Me.gbrecording.Controls.Add(Me.cmdplayvtr)
        Me.gbrecording.Controls.Add(Me.cmdopenportsvtr)
        Me.gbrecording.Controls.Add(Me.lblcomportsvtr)
        Me.gbrecording.Controls.Add(Me.cmbportsvtr)
        Me.gbrecording.Controls.Add(Me.Button5)
        Me.gbrecording.Controls.Add(Me.Label152)
        Me.gbrecording.Controls.Add(Me.lblfreespace)
        Me.gbrecording.Controls.Add(Me.cmdlocaterecordingfile)
        Me.gbrecording.Controls.Add(Me.Label128)
        Me.gbrecording.Controls.Add(Me.Label129)
        Me.gbrecording.Controls.Add(Me.Label130)
        Me.gbrecording.Controls.Add(Me.lblRecordedSize)
        Me.gbrecording.Controls.Add(Me.lblRecordedduration)
        Me.gbrecording.Controls.Add(Me.lblrecordingfilename)
        Me.gbrecording.Controls.Add(Me.chksinglecliprecord)
        Me.gbrecording.Controls.Add(Me.txtextrarecordoptions)
        Me.gbrecording.Controls.Add(Me.Label22)
        Me.gbrecording.Controls.Add(Me.txtfilename)
        Me.gbrecording.Controls.Add(Me.cmdremove_input)
        Me.gbrecording.Controls.Add(Me.mp4)
        Me.gbrecording.Controls.Add(Me.Label4)
        Me.gbrecording.Controls.Add(Me.Label1)
        Me.gbrecording.Controls.Add(Me.txtbitrate)
        Me.gbrecording.Controls.Add(Me.cmdlooprecord)
        Me.gbrecording.Controls.Add(Me.Label3)
        Me.gbrecording.Controls.Add(Me.cmdstoplooprecord)
        Me.gbrecording.Controls.Add(Me.txtinterval)
        Me.gbrecording.Controls.Add(Me.lblinterval)
        Me.gbrecording.Controls.Add(Me.cmdinput)
        Me.gbrecording.ForeColor = System.Drawing.Color.Black
        Me.gbrecording.Location = New System.Drawing.Point(3, 3)
        Me.gbrecording.Name = "gbrecording"
        Me.gbrecording.Size = New System.Drawing.Size(660, 573)
        Me.gbrecording.TabIndex = 178
        Me.gbrecording.TabStop = False
        Me.gbrecording.Text = " "
        '
        'Label241
        '
        Me.Label241.AutoSize = True
        Me.Label241.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label241.Location = New System.Drawing.Point(566, 86)
        Me.Label241.Name = "Label241"
        Me.Label241.Size = New System.Drawing.Size(68, 13)
        Me.Label241.TabIndex = 748
        Me.Label241.Text = "Audio Codec"
        Me.Label241.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label240
        '
        Me.Label240.AutoSize = True
        Me.Label240.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label240.Location = New System.Drawing.Point(453, 86)
        Me.Label240.Name = "Label240"
        Me.Label240.Size = New System.Drawing.Size(68, 13)
        Me.Label240.TabIndex = 747
        Me.Label240.Text = "Video Codec"
        Me.Label240.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbaudiocodec
        '
        Me.cmbaudiocodec.FormattingEnabled = True
        Me.cmbaudiocodec.Items.AddRange(New Object() {"aac", "ac3", "ac3_fixed", "adpcm_adx", "adpcm_ima_qt", "adpcm_ima_wav", "adpcm_ms", "adpcm_swf", "adpcm_yamaha", "alac", "comfortnoise", "eac3", "flac", "g722", "g723_1", "g726", "libgsm", "libgsm_ms", "libilbc", "libmp3lame", "libopencore_amrnb", "libopus", "libspeex", "libtwolame", "libvo_aacenc", "libvo_amrwbenc", "libvorbis", "libwavpack", "mp2", "mp2fixed", "nellymoser", "pcm_alaw", "pcm_f32be", "pcm_f32le", "pcm_f64be", "pcm_f64le", "pcm_mulaw", "pcm_s16be", "pcm_s16be_planar", "pcm_s16le", "pcm_s16le_planar", "pcm_s24be", "pcm_s24daud", "pcm_s24le", "pcm_s24le_planar", "pcm_s32be", "pcm_s32le", "pcm_s32le_planar", "pcm_s8", "pcm_s8_planar", "pcm_u16be", "pcm_u16le", "pcm_u24be", "pcm_u24le", "pcm_u32be", "pcm_u32le", "pcm_u8", "real_144", "roq_dpcm", "tta", "wavpack", "wmav1", "wmav2"})
        Me.cmbaudiocodec.Location = New System.Drawing.Point(569, 102)
        Me.cmbaudiocodec.Name = "cmbaudiocodec"
        Me.cmbaudiocodec.Size = New System.Drawing.Size(87, 21)
        Me.cmbaudiocodec.Sorted = True
        Me.cmbaudiocodec.TabIndex = 746
        '
        'cmbvideocodec
        '
        Me.cmbvideocodec.FormattingEnabled = True
        Me.cmbvideocodec.Items.AddRange(New Object() {"a64multi", "a64multi5", "alias_pix", "amv", "apng", "asv1", "asv2", "avrp", "avui", "ayuv", "bmp", "cinepak", "cljr", "dnxhd", "dpx", "dvvideo", "ffv1", "ffvhuff", "flashsv", "flashsv2", "flv", "gif", "h261", "h263", "h263p", "huffyuv", "jpeg2000", "jpegls", "libopenjpeg", "libschroedinger", "libtheora", "libvpx", "libvpx-vp9", "libwebp", "libx264", "libx264rgb", "libx265", "libxavs", "libxvid", "ljpeg", "mjpeg", "mpeg1video", "mpeg2video", "mpeg4", "msmpeg4", "msmpeg4v2", "msvideo1", "pam", "pbm", "pcx", "pgm", "pgmyuv", "png", "ppm", "prores", "prores_aw", "prores_ks", "qtrle", "r10k", "r210", "rawvideo", "roqvideo", "rv10", "rv20", "sgi", "snow", "sunrast", "svq1", "targa", "tiff", "utvideo", "v210", "v308", "v408", "v410", "wmv1", "wmv2", "xbm", "xface", "xwd", "y41p", "yuv4", "zlib", "zmbv"})
        Me.cmbvideocodec.Location = New System.Drawing.Point(456, 102)
        Me.cmbvideocodec.Name = "cmbvideocodec"
        Me.cmbvideocodec.Size = New System.Drawing.Size(107, 21)
        Me.cmbvideocodec.Sorted = True
        Me.cmbvideocodec.TabIndex = 745
        '
        'cmbRecordingProfile
        '
        Me.cmbRecordingProfile.FormattingEnabled = True
        Me.cmbRecordingProfile.Items.AddRange(New Object() {"dvcam", "dvcpro", "dvcpro50", "dvcproHD", "AlphaVideo", "AlphaVideo2", "H264", "H265", "XDCAMHD422", "IMX30", "IMX40", "IMX50", "MP3 Audio only"})
        Me.cmbRecordingProfile.Location = New System.Drawing.Point(329, 102)
        Me.cmbRecordingProfile.Name = "cmbRecordingProfile"
        Me.cmbRecordingProfile.Size = New System.Drawing.Size(121, 21)
        Me.cmbRecordingProfile.TabIndex = 744
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(326, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 743
        Me.Label2.Text = "Recording Profile"
        '
        'pnlrecording
        '
        Me.pnlrecording.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlrecording.Location = New System.Drawing.Point(381, 246)
        Me.pnlrecording.Name = "pnlrecording"
        Me.pnlrecording.Size = New System.Drawing.Size(275, 210)
        Me.pnlrecording.TabIndex = 157
        '
        'cmbscreenConsumres
        '
        Me.cmbscreenConsumres.FormattingEnabled = True
        Me.cmbscreenConsumres.Location = New System.Drawing.Point(381, 221)
        Me.cmbscreenConsumres.Name = "cmbscreenConsumres"
        Me.cmbscreenConsumres.Size = New System.Drawing.Size(186, 21)
        Me.cmbscreenConsumres.TabIndex = 733
        Me.cmbscreenConsumres.Text = " "
        '
        'cmdoutcasparcgwindowrecording
        '
        Me.cmdoutcasparcgwindowrecording.Location = New System.Drawing.Point(605, 218)
        Me.cmdoutcasparcgwindowrecording.Name = "cmdoutcasparcgwindowrecording"
        Me.cmdoutcasparcgwindowrecording.Size = New System.Drawing.Size(47, 23)
        Me.cmdoutcasparcgwindowrecording.TabIndex = 732
        Me.cmdoutcasparcgwindowrecording.Text = "OUT"
        Me.cmdoutcasparcgwindowrecording.UseVisualStyleBackColor = True
        '
        'cmdshowcasparcgwindowrecording
        '
        Me.cmdshowcasparcgwindowrecording.Location = New System.Drawing.Point(572, 218)
        Me.cmdshowcasparcgwindowrecording.Name = "cmdshowcasparcgwindowrecording"
        Me.cmdshowcasparcgwindowrecording.Size = New System.Drawing.Size(32, 23)
        Me.cmdshowcasparcgwindowrecording.TabIndex = 731
        Me.cmdshowcasparcgwindowrecording.Text = "IN"
        Me.cmdshowcasparcgwindowrecording.UseVisualStyleBackColor = True
        '
        'Label233
        '
        Me.Label233.AutoSize = True
        Me.Label233.Location = New System.Drawing.Point(1, 18)
        Me.Label233.Name = "Label233"
        Me.Label233.Size = New System.Drawing.Size(49, 13)
        Me.Label233.TabIndex = 713
        Me.Label233.Text = "Decklink"
        '
        'cmbdecklinkforrecording
        '
        Me.cmbdecklinkforrecording.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbliveoal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbdecklinkforrecording.FormattingEnabled = True
        Me.cmbdecklinkforrecording.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbdecklinkforrecording.Location = New System.Drawing.Point(4, 36)
        Me.cmbdecklinkforrecording.Name = "cmbdecklinkforrecording"
        Me.cmbdecklinkforrecording.Size = New System.Drawing.Size(39, 21)
        Me.cmbdecklinkforrecording.TabIndex = 712
        Me.cmbdecklinkforrecording.Text = "1"
        '
        'cmdopenintrimmer
        '
        Me.cmdopenintrimmer.Location = New System.Drawing.Point(219, 39)
        Me.cmdopenintrimmer.Name = "cmdopenintrimmer"
        Me.cmdopenintrimmer.Size = New System.Drawing.Size(93, 23)
        Me.cmdopenintrimmer.TabIndex = 711
        Me.cmdopenintrimmer.Text = "Open in Trimmer"
        Me.cmdopenintrimmer.UseVisualStyleBackColor = True
        '
        'lblRecordingFolder
        '
        Me.lblRecordingFolder.AutoSize = True
        Me.lblRecordingFolder.Location = New System.Drawing.Point(96, 187)
        Me.lblRecordingFolder.Name = "lblRecordingFolder"
        Me.lblRecordingFolder.Size = New System.Drawing.Size(104, 13)
        Me.lblRecordingFolder.TabIndex = 709
        Me.lblRecordingFolder.Text = "c:\casparcg\_media"
        '
        'cmdOpenFolderforRecording
        '
        Me.cmdOpenFolderforRecording.Location = New System.Drawing.Point(8, 182)
        Me.cmdOpenFolderforRecording.Name = "cmdOpenFolderforRecording"
        Me.cmdOpenFolderforRecording.Size = New System.Drawing.Size(85, 23)
        Me.cmdOpenFolderforRecording.TabIndex = 708
        Me.cmdOpenFolderforRecording.Text = "Select Folder"
        Me.cmdOpenFolderforRecording.UseVisualStyleBackColor = True
        '
        'gbSynchRecording
        '
        Me.gbSynchRecording.BackColor = System.Drawing.Color.DarkSalmon
        Me.gbSynchRecording.Controls.Add(Me.cmdstopsr)
        Me.gbSynchRecording.Controls.Add(Me.cmdstartsr)
        Me.gbSynchRecording.Controls.Add(Me.txtoutpointsr)
        Me.gbSynchRecording.Controls.Add(Me.txtinpointsr)
        Me.gbSynchRecording.Controls.Add(Me.cmdoutpointsr)
        Me.gbSynchRecording.Controls.Add(Me.cmdinpointsr)
        Me.gbSynchRecording.Location = New System.Drawing.Point(212, 478)
        Me.gbSynchRecording.Name = "gbSynchRecording"
        Me.gbSynchRecording.Size = New System.Drawing.Size(168, 86)
        Me.gbSynchRecording.TabIndex = 707
        Me.gbSynchRecording.TabStop = False
        Me.gbSynchRecording.Text = "Synch Recording from VTR"
        '
        'cmdstopsr
        '
        Me.cmdstopsr.Location = New System.Drawing.Point(87, 58)
        Me.cmdstopsr.Name = "cmdstopsr"
        Me.cmdstopsr.Size = New System.Drawing.Size(75, 23)
        Me.cmdstopsr.TabIndex = 5
        Me.cmdstopsr.Text = "Stop"
        Me.cmdstopsr.UseVisualStyleBackColor = True
        '
        'cmdstartsr
        '
        Me.cmdstartsr.Location = New System.Drawing.Point(6, 58)
        Me.cmdstartsr.Name = "cmdstartsr"
        Me.cmdstartsr.Size = New System.Drawing.Size(75, 23)
        Me.cmdstartsr.TabIndex = 4
        Me.cmdstartsr.Text = "Record"
        Me.cmdstartsr.UseVisualStyleBackColor = True
        '
        'txtoutpointsr
        '
        Me.txtoutpointsr.Location = New System.Drawing.Point(87, 15)
        Me.txtoutpointsr.Name = "txtoutpointsr"
        Me.txtoutpointsr.Size = New System.Drawing.Size(75, 20)
        Me.txtoutpointsr.TabIndex = 3
        Me.txtoutpointsr.Text = "00:02:20:00"
        Me.txtoutpointsr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtinpointsr
        '
        Me.txtinpointsr.Location = New System.Drawing.Point(6, 15)
        Me.txtinpointsr.Name = "txtinpointsr"
        Me.txtinpointsr.Size = New System.Drawing.Size(75, 20)
        Me.txtinpointsr.TabIndex = 2
        Me.txtinpointsr.Text = "00:02:00:00"
        Me.txtinpointsr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdoutpointsr
        '
        Me.cmdoutpointsr.Location = New System.Drawing.Point(87, 35)
        Me.cmdoutpointsr.Name = "cmdoutpointsr"
        Me.cmdoutpointsr.Size = New System.Drawing.Size(75, 23)
        Me.cmdoutpointsr.TabIndex = 1
        Me.cmdoutpointsr.Text = "OUT"
        Me.cmdoutpointsr.UseVisualStyleBackColor = True
        '
        'cmdinpointsr
        '
        Me.cmdinpointsr.Location = New System.Drawing.Point(6, 35)
        Me.cmdinpointsr.Name = "cmdinpointsr"
        Me.cmdinpointsr.Size = New System.Drawing.Size(75, 23)
        Me.cmdinpointsr.TabIndex = 0
        Me.cmdinpointsr.Text = "IN"
        Me.cmdinpointsr.UseVisualStyleBackColor = True
        '
        'Label173
        '
        Me.Label173.AutoSize = True
        Me.Label173.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label173.Location = New System.Drawing.Point(13, 225)
        Me.Label173.Name = "Label173"
        Me.Label173.Size = New System.Drawing.Size(178, 24)
        Me.Label173.TabIndex = 705
        Me.Label173.Text = "RS 422 VTR Control"
        '
        'cmdassembleoffvtr
        '
        Me.cmdassembleoffvtr.Location = New System.Drawing.Point(108, 423)
        Me.cmdassembleoffvtr.Name = "cmdassembleoffvtr"
        Me.cmdassembleoffvtr.Size = New System.Drawing.Size(86, 23)
        Me.cmdassembleoffvtr.TabIndex = 704
        Me.cmdassembleoffvtr.Text = "Assemble Off"
        Me.cmdassembleoffvtr.UseVisualStyleBackColor = True
        '
        'cmdassembleonvtr
        '
        Me.cmdassembleonvtr.Location = New System.Drawing.Point(25, 423)
        Me.cmdassembleonvtr.Name = "cmdassembleonvtr"
        Me.cmdassembleonvtr.Size = New System.Drawing.Size(78, 23)
        Me.cmdassembleonvtr.TabIndex = 703
        Me.cmdassembleonvtr.Text = "Assemble On"
        Me.cmdassembleonvtr.UseVisualStyleBackColor = True
        '
        'cmdplusoneframevtr
        '
        Me.cmdplusoneframevtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplusoneframevtr.Location = New System.Drawing.Point(301, 268)
        Me.cmdplusoneframevtr.Name = "cmdplusoneframevtr"
        Me.cmdplusoneframevtr.Size = New System.Drawing.Size(28, 25)
        Me.cmdplusoneframevtr.TabIndex = 702
        Me.cmdplusoneframevtr.Text = "+"
        Me.cmdplusoneframevtr.UseVisualStyleBackColor = True
        '
        'cmdminusoneframevtr
        '
        Me.cmdminusoneframevtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdminusoneframevtr.Location = New System.Drawing.Point(202, 269)
        Me.cmdminusoneframevtr.Name = "cmdminusoneframevtr"
        Me.cmdminusoneframevtr.Size = New System.Drawing.Size(28, 25)
        Me.cmdminusoneframevtr.TabIndex = 701
        Me.cmdminusoneframevtr.Text = "-"
        Me.cmdminusoneframevtr.UseVisualStyleBackColor = True
        '
        'lbloutpointvtr
        '
        Me.lbloutpointvtr.AutoSize = True
        Me.lbloutpointvtr.Location = New System.Drawing.Point(123, 334)
        Me.lbloutpointvtr.Name = "lbloutpointvtr"
        Me.lbloutpointvtr.Size = New System.Drawing.Size(64, 13)
        Me.lbloutpointvtr.TabIndex = 700
        Me.lbloutpointvtr.Text = "00:02:20:00"
        '
        'lblinpointvtr
        '
        Me.lblinpointvtr.AutoSize = True
        Me.lblinpointvtr.Location = New System.Drawing.Point(25, 334)
        Me.lblinpointvtr.Name = "lblinpointvtr"
        Me.lblinpointvtr.Size = New System.Drawing.Size(64, 13)
        Me.lblinpointvtr.TabIndex = 699
        Me.lblinpointvtr.Text = "00:02:00:00"
        '
        'cmdReviewvtr
        '
        Me.cmdReviewvtr.Location = New System.Drawing.Point(108, 471)
        Me.cmdReviewvtr.Name = "cmdReviewvtr"
        Me.cmdReviewvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdReviewvtr.TabIndex = 698
        Me.cmdReviewvtr.Text = "Review"
        Me.cmdReviewvtr.UseVisualStyleBackColor = True
        '
        'cmdpreviewvtr
        '
        Me.cmdpreviewvtr.Location = New System.Drawing.Point(25, 474)
        Me.cmdpreviewvtr.Name = "cmdpreviewvtr"
        Me.cmdpreviewvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdpreviewvtr.TabIndex = 697
        Me.cmdpreviewvtr.Text = "Preview"
        Me.cmdpreviewvtr.UseVisualStyleBackColor = True
        '
        'cmdautoeditvtr
        '
        Me.cmdautoeditvtr.Location = New System.Drawing.Point(108, 447)
        Me.cmdautoeditvtr.Name = "cmdautoeditvtr"
        Me.cmdautoeditvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdautoeditvtr.TabIndex = 696
        Me.cmdautoeditvtr.Text = "Auto Edit"
        Me.cmdautoeditvtr.UseVisualStyleBackColor = True
        '
        'cmdrecordvtr
        '
        Me.cmdrecordvtr.Location = New System.Drawing.Point(25, 447)
        Me.cmdrecordvtr.Name = "cmdrecordvtr"
        Me.cmdrecordvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdrecordvtr.TabIndex = 695
        Me.cmdrecordvtr.Text = "Record"
        Me.cmdrecordvtr.UseVisualStyleBackColor = True
        '
        'lbljogvtr
        '
        Me.lbljogvtr.AutoSize = True
        Me.lbljogvtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljogvtr.Location = New System.Drawing.Point(154, 502)
        Me.lbljogvtr.Name = "lbljogvtr"
        Me.lbljogvtr.Size = New System.Drawing.Size(35, 20)
        Me.lbljogvtr.TabIndex = 694
        Me.lbljogvtr.Text = "Jog"
        '
        'HScrollBarjogvtr
        '
        Me.HScrollBarjogvtr.LargeChange = 1
        Me.HScrollBarjogvtr.Location = New System.Drawing.Point(16, 502)
        Me.HScrollBarjogvtr.Maximum = 118
        Me.HScrollBarjogvtr.Minimum = -118
        Me.HScrollBarjogvtr.Name = "HScrollBarjogvtr"
        Me.HScrollBarjogvtr.Size = New System.Drawing.Size(134, 13)
        Me.HScrollBarjogvtr.TabIndex = 693
        '
        'lblshuttlevtr
        '
        Me.lblshuttlevtr.AutoSize = True
        Me.lblshuttlevtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshuttlevtr.Location = New System.Drawing.Point(154, 541)
        Me.lblshuttlevtr.Name = "lblshuttlevtr"
        Me.lblshuttlevtr.Size = New System.Drawing.Size(60, 20)
        Me.lblshuttlevtr.TabIndex = 692
        Me.lblshuttlevtr.Text = "Shuttle"
        '
        'HScrollBarshuttlevtr
        '
        Me.HScrollBarshuttlevtr.LargeChange = 1
        Me.HScrollBarshuttlevtr.Location = New System.Drawing.Point(16, 545)
        Me.HScrollBarshuttlevtr.Maximum = 118
        Me.HScrollBarshuttlevtr.Minimum = -118
        Me.HScrollBarshuttlevtr.Name = "HScrollBarshuttlevtr"
        Me.HScrollBarshuttlevtr.Size = New System.Drawing.Size(134, 13)
        Me.HScrollBarshuttlevtr.TabIndex = 691
        '
        'lblvariablevtr
        '
        Me.lblvariablevtr.AutoSize = True
        Me.lblvariablevtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvariablevtr.Location = New System.Drawing.Point(154, 521)
        Me.lblvariablevtr.Name = "lblvariablevtr"
        Me.lblvariablevtr.Size = New System.Drawing.Size(48, 20)
        Me.lblvariablevtr.TabIndex = 690
        Me.lblvariablevtr.Text = "Var F"
        '
        'HScrollBarvtr
        '
        Me.HScrollBarvtr.LargeChange = 1
        Me.HScrollBarvtr.Location = New System.Drawing.Point(16, 526)
        Me.HScrollBarvtr.Maximum = 118
        Me.HScrollBarvtr.Minimum = -118
        Me.HScrollBarvtr.Name = "HScrollBarvtr"
        Me.HScrollBarvtr.Size = New System.Drawing.Size(134, 13)
        Me.HScrollBarvtr.TabIndex = 689
        '
        'dgvcuepointsvtr
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcuepointsvtr.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvcuepointsvtr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcuepointsvtr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvcuepointsvtr.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvcuepointsvtr.Location = New System.Drawing.Point(199, 300)
        Me.dgvcuepointsvtr.Name = "dgvcuepointsvtr"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcuepointsvtr.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvcuepointsvtr.Size = New System.Drawing.Size(139, 163)
        Me.dgvcuepointsvtr.TabIndex = 688
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Time Code"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 70
        '
        'cmdmarkvtr
        '
        Me.cmdmarkvtr.Location = New System.Drawing.Point(239, 268)
        Me.cmdmarkvtr.Name = "cmdmarkvtr"
        Me.cmdmarkvtr.Size = New System.Drawing.Size(53, 27)
        Me.cmdmarkvtr.TabIndex = 687
        Me.cmdmarkvtr.Text = "Mark"
        Me.cmdmarkvtr.UseVisualStyleBackColor = True
        '
        'cmdcuevtr
        '
        Me.cmdcuevtr.Location = New System.Drawing.Point(343, 297)
        Me.cmdcuevtr.Name = "cmdcuevtr"
        Me.cmdcuevtr.Size = New System.Drawing.Size(34, 169)
        Me.cmdcuevtr.TabIndex = 686
        Me.cmdcuevtr.Text = "Cue"
        Me.cmdcuevtr.UseVisualStyleBackColor = True
        '
        'cmdPreRollvtr
        '
        Me.cmdPreRollvtr.Location = New System.Drawing.Point(25, 373)
        Me.cmdPreRollvtr.Name = "cmdPreRollvtr"
        Me.cmdPreRollvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdPreRollvtr.TabIndex = 685
        Me.cmdPreRollvtr.Text = "PreRoll"
        Me.cmdPreRollvtr.UseVisualStyleBackColor = True
        '
        'cmdejectvtr
        '
        Me.cmdejectvtr.Location = New System.Drawing.Point(108, 373)
        Me.cmdejectvtr.Name = "cmdejectvtr"
        Me.cmdejectvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdejectvtr.TabIndex = 684
        Me.cmdejectvtr.Text = "Eject"
        Me.cmdejectvtr.UseVisualStyleBackColor = True
        '
        'cmdstandbyoffvtr
        '
        Me.cmdstandbyoffvtr.Location = New System.Drawing.Point(108, 398)
        Me.cmdstandbyoffvtr.Name = "cmdstandbyoffvtr"
        Me.cmdstandbyoffvtr.Size = New System.Drawing.Size(86, 23)
        Me.cmdstandbyoffvtr.TabIndex = 683
        Me.cmdstandbyoffvtr.Text = "Standby OFF"
        Me.cmdstandbyoffvtr.UseVisualStyleBackColor = True
        '
        'cmdstandbyonvtr
        '
        Me.cmdstandbyonvtr.Location = New System.Drawing.Point(25, 398)
        Me.cmdstandbyonvtr.Name = "cmdstandbyonvtr"
        Me.cmdstandbyonvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdstandbyonvtr.TabIndex = 682
        Me.cmdstandbyonvtr.Text = "Standby ON"
        Me.cmdstandbyonvtr.UseVisualStyleBackColor = True
        '
        'lbltimecode
        '
        Me.lbltimecode.AutoSize = True
        Me.lbltimecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimecode.Location = New System.Drawing.Point(201, 237)
        Me.lbltimecode.Name = "lbltimecode"
        Me.lbltimecode.Size = New System.Drawing.Size(134, 29)
        Me.lbltimecode.TabIndex = 681
        Me.lbltimecode.Text = "Time Code"
        '
        'cmdffvtr
        '
        Me.cmdffvtr.Location = New System.Drawing.Point(108, 309)
        Me.cmdffvtr.Name = "cmdffvtr"
        Me.cmdffvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdffvtr.TabIndex = 680
        Me.cmdffvtr.Text = "Fast FW"
        Me.cmdffvtr.UseVisualStyleBackColor = True
        '
        'cmdstopvtr
        '
        Me.cmdstopvtr.Location = New System.Drawing.Point(108, 286)
        Me.cmdstopvtr.Name = "cmdstopvtr"
        Me.cmdstopvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdstopvtr.TabIndex = 679
        Me.cmdstopvtr.Text = "Stop"
        Me.cmdstopvtr.UseVisualStyleBackColor = True
        '
        'cmdrewindvtr
        '
        Me.cmdrewindvtr.Location = New System.Drawing.Point(25, 309)
        Me.cmdrewindvtr.Name = "cmdrewindvtr"
        Me.cmdrewindvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdrewindvtr.TabIndex = 678
        Me.cmdrewindvtr.Text = "Rewind"
        Me.cmdrewindvtr.UseVisualStyleBackColor = True
        '
        'cmdoutpointvtr
        '
        Me.cmdoutpointvtr.Location = New System.Drawing.Point(108, 349)
        Me.cmdoutpointvtr.Name = "cmdoutpointvtr"
        Me.cmdoutpointvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdoutpointvtr.TabIndex = 677
        Me.cmdoutpointvtr.Text = "Out"
        Me.cmdoutpointvtr.UseVisualStyleBackColor = True
        '
        'cmdinpointvtr
        '
        Me.cmdinpointvtr.Location = New System.Drawing.Point(25, 349)
        Me.cmdinpointvtr.Name = "cmdinpointvtr"
        Me.cmdinpointvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdinpointvtr.TabIndex = 676
        Me.cmdinpointvtr.Text = "In"
        Me.cmdinpointvtr.UseVisualStyleBackColor = True
        '
        'cmdplayvtr
        '
        Me.cmdplayvtr.Location = New System.Drawing.Point(25, 286)
        Me.cmdplayvtr.Name = "cmdplayvtr"
        Me.cmdplayvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdplayvtr.TabIndex = 675
        Me.cmdplayvtr.Text = "Play"
        Me.cmdplayvtr.UseVisualStyleBackColor = True
        '
        'cmdopenportsvtr
        '
        Me.cmdopenportsvtr.Location = New System.Drawing.Point(120, 260)
        Me.cmdopenportsvtr.Name = "cmdopenportsvtr"
        Me.cmdopenportsvtr.Size = New System.Drawing.Size(53, 23)
        Me.cmdopenportsvtr.TabIndex = 674
        Me.cmdopenportsvtr.Text = "Open"
        Me.cmdopenportsvtr.UseVisualStyleBackColor = True
        '
        'lblcomportsvtr
        '
        Me.lblcomportsvtr.AutoSize = True
        Me.lblcomportsvtr.Location = New System.Drawing.Point(22, 264)
        Me.lblcomportsvtr.Name = "lblcomportsvtr"
        Me.lblcomportsvtr.Size = New System.Drawing.Size(31, 13)
        Me.lblcomportsvtr.TabIndex = 673
        Me.lblcomportsvtr.Text = "Ports"
        '
        'cmbportsvtr
        '
        Me.cmbportsvtr.FormattingEnabled = True
        Me.cmbportsvtr.Location = New System.Drawing.Point(60, 261)
        Me.cmbportsvtr.Name = "cmbportsvtr"
        Me.cmbportsvtr.Size = New System.Drawing.Size(55, 21)
        Me.cmbportsvtr.TabIndex = 672
        Me.cmbportsvtr.Text = "COM3"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.Location = New System.Drawing.Point(7, 205)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(663, 10)
        Me.Button5.TabIndex = 671
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label152
        '
        Me.Label152.AutoSize = True
        Me.Label152.Location = New System.Drawing.Point(457, 68)
        Me.Label152.Name = "Label152"
        Me.Label152.Size = New System.Drawing.Size(62, 13)
        Me.Label152.TabIndex = 168
        Me.Label152.Text = "Free Space"
        '
        'lblfreespace
        '
        Me.lblfreespace.AutoSize = True
        Me.lblfreespace.Location = New System.Drawing.Point(525, 67)
        Me.lblfreespace.Name = "lblfreespace"
        Me.lblfreespace.Size = New System.Drawing.Size(103, 13)
        Me.lblfreespace.TabIndex = 167
        Me.lblfreespace.Text = "lblfreespacerecorcer"
        '
        'cmdlocaterecordingfile
        '
        Me.cmdlocaterecordingfile.Location = New System.Drawing.Point(579, 10)
        Me.cmdlocaterecordingfile.Name = "cmdlocaterecordingfile"
        Me.cmdlocaterecordingfile.Size = New System.Drawing.Size(51, 20)
        Me.cmdlocaterecordingfile.TabIndex = 166
        Me.cmdlocaterecordingfile.Text = "Locate"
        Me.cmdlocaterecordingfile.UseVisualStyleBackColor = True
        '
        'Label128
        '
        Me.Label128.AutoSize = True
        Me.Label128.Location = New System.Drawing.Point(441, 52)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(77, 13)
        Me.Label128.TabIndex = 165
        Me.Label128.Text = "Recorded Size"
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.Location = New System.Drawing.Point(423, 38)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(97, 13)
        Me.Label129.TabIndex = 164
        Me.Label129.Text = "Recorded Duration"
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.Location = New System.Drawing.Point(220, 12)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(23, 13)
        Me.Label130.TabIndex = 163
        Me.Label130.Text = "File"
        '
        'lblRecordedSize
        '
        Me.lblRecordedSize.AutoSize = True
        Me.lblRecordedSize.Location = New System.Drawing.Point(521, 53)
        Me.lblRecordedSize.Name = "lblRecordedSize"
        Me.lblRecordedSize.Size = New System.Drawing.Size(77, 13)
        Me.lblRecordedSize.TabIndex = 162
        Me.lblRecordedSize.Text = "Recorded Size"
        '
        'lblRecordedduration
        '
        Me.lblRecordedduration.AutoSize = True
        Me.lblRecordedduration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordedduration.ForeColor = System.Drawing.Color.DarkRed
        Me.lblRecordedduration.Location = New System.Drawing.Point(520, 37)
        Me.lblRecordedduration.Name = "lblRecordedduration"
        Me.lblRecordedduration.Size = New System.Drawing.Size(139, 16)
        Me.lblRecordedduration.TabIndex = 161
        Me.lblRecordedduration.Text = "Recorded Duration"
        '
        'lblrecordingfilename
        '
        Me.lblrecordingfilename.AutoSize = True
        Me.lblrecordingfilename.Location = New System.Drawing.Point(242, 13)
        Me.lblrecordingfilename.MaximumSize = New System.Drawing.Size(300, 0)
        Me.lblrecordingfilename.Name = "lblrecordingfilename"
        Me.lblrecordingfilename.Size = New System.Drawing.Size(297, 13)
        Me.lblrecordingfilename.TabIndex = 160
        Me.lblrecordingfilename.Text = "D:\CasparCG Server020715\CasparCG Server\Server/media"
        '
        'chksinglecliprecord
        '
        Me.chksinglecliprecord.AutoSize = True
        Me.chksinglecliprecord.Checked = Global.caspar_media_playback.My.MySettings.Default.chksinglecliprecord
        Me.chksinglecliprecord.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chksinglecliprecord.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.caspar_media_playback.My.MySettings.Default, "chksinglecliprecord", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chksinglecliprecord.Location = New System.Drawing.Point(179, 65)
        Me.chksinglecliprecord.Name = "chksinglecliprecord"
        Me.chksinglecliprecord.Size = New System.Drawing.Size(75, 17)
        Me.chksinglecliprecord.TabIndex = 159
        Me.chksinglecliprecord.Text = "Single Clip"
        Me.chksinglecliprecord.UseVisualStyleBackColor = True
        '
        'txtextrarecordoptions
        '
        Me.txtextrarecordoptions.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtextrarecordoptions", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtextrarecordoptions.Location = New System.Drawing.Point(255, 130)
        Me.txtextrarecordoptions.Multiline = True
        Me.txtextrarecordoptions.Name = "txtextrarecordoptions"
        Me.txtextrarecordoptions.Size = New System.Drawing.Size(401, 57)
        Me.txtextrarecordoptions.TabIndex = 158
        Me.txtextrarecordoptions.Text = Global.caspar_media_playback.My.MySettings.Default.txtextrarecordoptions
        Me.txtextrarecordoptions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(255, 116)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 13)
        Me.Label22.TabIndex = 157
        Me.Label22.Text = "Extra options"
        '
        'txtfilename
        '
        Me.txtfilename.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtfilename", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtfilename.Location = New System.Drawing.Point(120, 132)
        Me.txtfilename.Name = "txtfilename"
        Me.txtfilename.Size = New System.Drawing.Size(129, 20)
        Me.txtfilename.TabIndex = 156
        Me.txtfilename.Text = Global.caspar_media_playback.My.MySettings.Default.txtfilename
        Me.txtfilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdremove_input
        '
        Me.cmdremove_input.Location = New System.Drawing.Point(123, 12)
        Me.cmdremove_input.Name = "cmdremove_input"
        Me.cmdremove_input.Size = New System.Drawing.Size(92, 27)
        Me.cmdremove_input.TabIndex = 155
        Me.cmdremove_input.Text = "Remove Input"
        Me.cmdremove_input.UseVisualStyleBackColor = True
        '
        'mp4
        '
        Me.mp4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbrecordformat", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.mp4.FormattingEnabled = True
        Me.mp4.Items.AddRange(New Object() {"avi", "dv", "mov", "mp3", "mp4", "mxf", "ogg", "ts", "wav"})
        Me.mp4.Location = New System.Drawing.Point(120, 107)
        Me.mp4.Name = "mp4"
        Me.mp4.Size = New System.Drawing.Size(53, 21)
        Me.mp4.Sorted = True
        Me.mp4.TabIndex = 155
        Me.mp4.Text = Global.caspar_media_playback.My.MySettings.Default.cmbrecordformat
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "File Format"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Filename"
        '
        'txtbitrate
        '
        Me.txtbitrate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtbitrate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtbitrate.Location = New System.Drawing.Point(120, 85)
        Me.txtbitrate.Name = "txtbitrate"
        Me.txtbitrate.Size = New System.Drawing.Size(53, 20)
        Me.txtbitrate.TabIndex = 142
        Me.txtbitrate.Text = "8"
        Me.txtbitrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdlooprecord
        '
        Me.cmdlooprecord.BackColor = System.Drawing.Color.Red
        Me.cmdlooprecord.Location = New System.Drawing.Point(47, 39)
        Me.cmdlooprecord.Name = "cmdlooprecord"
        Me.cmdlooprecord.Size = New System.Drawing.Size(73, 23)
        Me.cmdlooprecord.TabIndex = 139
        Me.cmdlooprecord.Text = "Record"
        Me.cmdlooprecord.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Bit Rate Mbps"
        '
        'cmdstoplooprecord
        '
        Me.cmdstoplooprecord.Location = New System.Drawing.Point(122, 38)
        Me.cmdstoplooprecord.Name = "cmdstoplooprecord"
        Me.cmdstoplooprecord.Size = New System.Drawing.Size(93, 23)
        Me.cmdstoplooprecord.TabIndex = 140
        Me.cmdstoplooprecord.Text = "Stop Record"
        Me.cmdstoplooprecord.UseVisualStyleBackColor = True
        '
        'txtinterval
        '
        Me.txtinterval.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtinterval", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtinterval.Location = New System.Drawing.Point(120, 64)
        Me.txtinterval.Name = "txtinterval"
        Me.txtinterval.Size = New System.Drawing.Size(53, 20)
        Me.txtinterval.TabIndex = 138
        Me.txtinterval.Text = "3600"
        Me.txtinterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblinterval
        '
        Me.lblinterval.AutoSize = True
        Me.lblinterval.Location = New System.Drawing.Point(5, 66)
        Me.lblinterval.Name = "lblinterval"
        Me.lblinterval.Size = New System.Drawing.Size(110, 13)
        Me.lblinterval.TabIndex = 138
        Me.lblinterval.Text = "File Length in Second"
        '
        'cmdinput
        '
        Me.cmdinput.Location = New System.Drawing.Point(49, 12)
        Me.cmdinput.Name = "cmdinput"
        Me.cmdinput.Size = New System.Drawing.Size(70, 27)
        Me.cmdinput.TabIndex = 142
        Me.cmdinput.Text = "Show input"
        Me.cmdinput.UseVisualStyleBackColor = True
        '
        'tmrsr
        '
        Me.tmrsr.Interval = 40
        '
        'tmrrecorder
        '
        '
        'tmrrecordedfileinfo
        '
        Me.tmrrecordedfileinfo.Interval = 1000
        '
        'sp
        '
        Me.sp.BaudRate = 38400
        Me.sp.DtrEnable = True
        Me.sp.Parity = System.IO.Ports.Parity.Odd
        Me.sp.PortName = "COM3"
        Me.sp.RtsEnable = True
        '
        'tmrgettc
        '
        Me.tmrgettc.Interval = 40
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Time Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'ucRecorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1221, 749)
        Me.Controls.Add(Me.gbrecording)
        Me.HideOnClose = True
        Me.Name = "ucRecorder"
        Me.Text = "General Recorder"
        Me.gbrecording.ResumeLayout(False)
        Me.gbrecording.PerformLayout()
        Me.gbSynchRecording.ResumeLayout(False)
        Me.gbSynchRecording.PerformLayout()
        CType(Me.dgvcuepointsvtr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbrecording As System.Windows.Forms.GroupBox
    Friend WithEvents pnlrecording As System.Windows.Forms.Panel
    Friend WithEvents cmbscreenConsumres As System.Windows.Forms.ComboBox
    Friend WithEvents cmdoutcasparcgwindowrecording As System.Windows.Forms.Button
    Friend WithEvents cmdshowcasparcgwindowrecording As System.Windows.Forms.Button
    Friend WithEvents Label233 As System.Windows.Forms.Label
    Friend WithEvents cmbdecklinkforrecording As System.Windows.Forms.ComboBox
    Friend WithEvents cmdopenintrimmer As System.Windows.Forms.Button
    Friend WithEvents lblRecordingFolder As System.Windows.Forms.Label
    Friend WithEvents cmdOpenFolderforRecording As System.Windows.Forms.Button
    Friend WithEvents gbSynchRecording As System.Windows.Forms.GroupBox
    Friend WithEvents cmdstopsr As System.Windows.Forms.Button
    Friend WithEvents cmdstartsr As System.Windows.Forms.Button
    Friend WithEvents txtoutpointsr As System.Windows.Forms.TextBox
    Friend WithEvents txtinpointsr As System.Windows.Forms.TextBox
    Friend WithEvents cmdoutpointsr As System.Windows.Forms.Button
    Friend WithEvents cmdinpointsr As System.Windows.Forms.Button
    Friend WithEvents Label173 As System.Windows.Forms.Label
    Friend WithEvents cmdassembleoffvtr As System.Windows.Forms.Button
    Friend WithEvents cmdassembleonvtr As System.Windows.Forms.Button
    Friend WithEvents cmdplusoneframevtr As System.Windows.Forms.Button
    Friend WithEvents cmdminusoneframevtr As System.Windows.Forms.Button
    Friend WithEvents lbloutpointvtr As System.Windows.Forms.Label
    Friend WithEvents lblinpointvtr As System.Windows.Forms.Label
    Friend WithEvents cmdReviewvtr As System.Windows.Forms.Button
    Friend WithEvents cmdpreviewvtr As System.Windows.Forms.Button
    Friend WithEvents cmdautoeditvtr As System.Windows.Forms.Button
    Friend WithEvents cmdrecordvtr As System.Windows.Forms.Button
    Friend WithEvents lbljogvtr As System.Windows.Forms.Label
    Friend WithEvents HScrollBarjogvtr As System.Windows.Forms.HScrollBar
    Friend WithEvents lblshuttlevtr As System.Windows.Forms.Label
    Friend WithEvents HScrollBarshuttlevtr As System.Windows.Forms.HScrollBar
    Friend WithEvents lblvariablevtr As System.Windows.Forms.Label
    Friend WithEvents HScrollBarvtr As System.Windows.Forms.HScrollBar
    Friend WithEvents dgvcuepointsvtr As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdmarkvtr As System.Windows.Forms.Button
    Friend WithEvents cmdcuevtr As System.Windows.Forms.Button
    Friend WithEvents cmdPreRollvtr As System.Windows.Forms.Button
    Friend WithEvents cmdejectvtr As System.Windows.Forms.Button
    Friend WithEvents cmdstandbyoffvtr As System.Windows.Forms.Button
    Friend WithEvents cmdstandbyonvtr As System.Windows.Forms.Button
    Friend WithEvents lbltimecode As System.Windows.Forms.Label
    Friend WithEvents cmdffvtr As System.Windows.Forms.Button
    Friend WithEvents cmdstopvtr As System.Windows.Forms.Button
    Friend WithEvents cmdrewindvtr As System.Windows.Forms.Button
    Friend WithEvents cmdoutpointvtr As System.Windows.Forms.Button
    Friend WithEvents cmdinpointvtr As System.Windows.Forms.Button
    Friend WithEvents cmdplayvtr As System.Windows.Forms.Button
    Friend WithEvents cmdopenportsvtr As System.Windows.Forms.Button
    Friend WithEvents lblcomportsvtr As System.Windows.Forms.Label
    Friend WithEvents cmbportsvtr As System.Windows.Forms.ComboBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label152 As System.Windows.Forms.Label
    Friend WithEvents lblfreespace As System.Windows.Forms.Label
    Friend WithEvents cmdlocaterecordingfile As System.Windows.Forms.Button
    Friend WithEvents Label128 As System.Windows.Forms.Label
    Friend WithEvents Label129 As System.Windows.Forms.Label
    Friend WithEvents Label130 As System.Windows.Forms.Label
    Friend WithEvents lblRecordedSize As System.Windows.Forms.Label
    Friend WithEvents lblRecordedduration As System.Windows.Forms.Label
    Friend WithEvents lblrecordingfilename As System.Windows.Forms.Label
    Friend WithEvents chksinglecliprecord As System.Windows.Forms.CheckBox
    Friend WithEvents txtextrarecordoptions As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtfilename As System.Windows.Forms.TextBox
    Friend WithEvents cmdremove_input As System.Windows.Forms.Button
    Friend WithEvents mp4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbitrate As System.Windows.Forms.TextBox
    Friend WithEvents cmdlooprecord As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdstoplooprecord As System.Windows.Forms.Button
    Friend WithEvents txtinterval As System.Windows.Forms.TextBox
    Friend WithEvents lblinterval As System.Windows.Forms.Label
    Friend WithEvents cmdinput As System.Windows.Forms.Button
    Friend WithEvents tmrsr As System.Windows.Forms.Timer
    Friend WithEvents tmrrecorder As System.Windows.Forms.Timer
    Friend WithEvents tmrrecordedfileinfo As System.Windows.Forms.Timer
    Friend WithEvents sp As System.IO.Ports.SerialPort
    Friend WithEvents tmrgettc As System.Windows.Forms.Timer
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label241 As System.Windows.Forms.Label
    Friend WithEvents Label240 As System.Windows.Forms.Label
    Friend WithEvents cmbaudiocodec As System.Windows.Forms.ComboBox
    Friend WithEvents cmbvideocodec As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRecordingProfile As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
