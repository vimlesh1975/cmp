<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucStreamPlayer
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
        Me.gbstreamPlayer = New System.Windows.Forms.GroupBox()
        Me.chkDshowAudio = New System.Windows.Forms.CheckBox()
        Me.chkdshowVideo = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmdSendRTSP = New System.Windows.Forms.Button()
        Me.txtRTSP = New System.Windows.Forms.TextBox()
        Me.cmbcapturedevicesAudio = New System.Windows.Forms.ComboBox()
        Me.cmbNDI = New System.Windows.Forms.ComboBox()
        Me.cmdplaychannelproducer = New System.Windows.Forms.Button()
        Me.txtchannelproducer = New System.Windows.Forms.TextBox()
        Me.lblchannelproducer = New System.Windows.Forms.Label()
        Me.cmdcopyon2ndchannel = New System.Windows.Forms.Button()
        Me.txtlayerproducer2 = New System.Windows.Forms.TextBox()
        Me.lbllayerproducer = New System.Windows.Forms.Label()
        Me.cmbcapturedevices = New System.Windows.Forms.ComboBox()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.cmdplayusbcamera = New System.Windows.Forms.Button()
        Me.txtdirectshowproducer = New System.Windows.Forms.TextBox()
        Me.cmdm3u8 = New System.Windows.Forms.Button()
        Me.txtm3u8 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdUDP = New System.Windows.Forms.Button()
        Me.txtUDP = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdSendRTP = New System.Windows.Forms.Button()
        Me.txtRTP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdSendNDI = New System.Windows.Forms.Button()
        Me.txtNDI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbDesktopDecklink = New System.Windows.Forms.ComboBox()
        Me.txtDesktopDecklink2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdDesktopDecklink = New System.Windows.Forms.Button()
        Me.txtDesktopDecklink = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdStreamFromHere = New System.Windows.Forms.Button()
        Me.txtStreamFromHere = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdDecklink = New System.Windows.Forms.Button()
        Me.txtDecklink = New System.Windows.Forms.TextBox()
        Me.cmdMonitor = New System.Windows.Forms.Button()
        Me.txtmontor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBinFolder = New System.Windows.Forms.TextBox()
        Me.cmdBinFolder = New System.Windows.Forms.Button()
        Me.gbstreamPlayer.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbstreamPlayer
        '
        Me.gbstreamPlayer.BackColor = System.Drawing.Color.NavajoWhite
        Me.gbstreamPlayer.Controls.Add(Me.chkDshowAudio)
        Me.gbstreamPlayer.Controls.Add(Me.chkdshowVideo)
        Me.gbstreamPlayer.Controls.Add(Me.Label13)
        Me.gbstreamPlayer.Controls.Add(Me.cmdSendRTSP)
        Me.gbstreamPlayer.Controls.Add(Me.txtRTSP)
        Me.gbstreamPlayer.Controls.Add(Me.cmbcapturedevicesAudio)
        Me.gbstreamPlayer.Controls.Add(Me.cmbNDI)
        Me.gbstreamPlayer.Controls.Add(Me.cmdplaychannelproducer)
        Me.gbstreamPlayer.Controls.Add(Me.txtchannelproducer)
        Me.gbstreamPlayer.Controls.Add(Me.lblchannelproducer)
        Me.gbstreamPlayer.Controls.Add(Me.cmdcopyon2ndchannel)
        Me.gbstreamPlayer.Controls.Add(Me.txtlayerproducer2)
        Me.gbstreamPlayer.Controls.Add(Me.lbllayerproducer)
        Me.gbstreamPlayer.Controls.Add(Me.cmbcapturedevices)
        Me.gbstreamPlayer.Controls.Add(Me.Label100)
        Me.gbstreamPlayer.Controls.Add(Me.cmdplayusbcamera)
        Me.gbstreamPlayer.Controls.Add(Me.txtdirectshowproducer)
        Me.gbstreamPlayer.Controls.Add(Me.cmdm3u8)
        Me.gbstreamPlayer.Controls.Add(Me.txtm3u8)
        Me.gbstreamPlayer.Controls.Add(Me.Label10)
        Me.gbstreamPlayer.Controls.Add(Me.cmdUDP)
        Me.gbstreamPlayer.Controls.Add(Me.txtUDP)
        Me.gbstreamPlayer.Controls.Add(Me.Label9)
        Me.gbstreamPlayer.Controls.Add(Me.cmdSendRTP)
        Me.gbstreamPlayer.Controls.Add(Me.txtRTP)
        Me.gbstreamPlayer.Controls.Add(Me.Label8)
        Me.gbstreamPlayer.Controls.Add(Me.cmdSendNDI)
        Me.gbstreamPlayer.Controls.Add(Me.txtNDI)
        Me.gbstreamPlayer.Controls.Add(Me.Label2)
        Me.gbstreamPlayer.Controls.Add(Me.GroupBox1)
        Me.gbstreamPlayer.Location = New System.Drawing.Point(2, 3)
        Me.gbstreamPlayer.Name = "gbstreamPlayer"
        Me.gbstreamPlayer.Size = New System.Drawing.Size(660, 605)
        Me.gbstreamPlayer.TabIndex = 1169
        Me.gbstreamPlayer.TabStop = False
        Me.gbstreamPlayer.Text = " "
        '
        'chkDshowAudio
        '
        Me.chkDshowAudio.AutoSize = True
        Me.chkDshowAudio.Checked = True
        Me.chkDshowAudio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDshowAudio.Location = New System.Drawing.Point(477, 177)
        Me.chkDshowAudio.Name = "chkDshowAudio"
        Me.chkDshowAudio.Size = New System.Drawing.Size(53, 17)
        Me.chkDshowAudio.TabIndex = 1230
        Me.chkDshowAudio.Text = "Audio"
        Me.chkDshowAudio.UseVisualStyleBackColor = True
        '
        'chkdshowVideo
        '
        Me.chkdshowVideo.AutoSize = True
        Me.chkdshowVideo.Checked = True
        Me.chkdshowVideo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkdshowVideo.Location = New System.Drawing.Point(238, 182)
        Me.chkdshowVideo.Name = "chkdshowVideo"
        Me.chkdshowVideo.Size = New System.Drawing.Size(53, 17)
        Me.chkdshowVideo.TabIndex = 1229
        Me.chkdshowVideo.Text = "Video"
        Me.chkdshowVideo.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(279, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(153, 13)
        Me.Label13.TabIndex = 1228
        Me.Label13.Text = "RTSP Stream (IP Camera)"
        '
        'cmdSendRTSP
        '
        Me.cmdSendRTSP.BackColor = System.Drawing.Color.Green
        Me.cmdSendRTSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSendRTSP.ForeColor = System.Drawing.Color.White
        Me.cmdSendRTSP.Location = New System.Drawing.Point(581, 121)
        Me.cmdSendRTSP.Name = "cmdSendRTSP"
        Me.cmdSendRTSP.Size = New System.Drawing.Size(73, 24)
        Me.cmdSendRTSP.TabIndex = 1227
        Me.cmdSendRTSP.Text = "Send"
        Me.cmdSendRTSP.UseVisualStyleBackColor = False
        '
        'txtRTSP
        '
        Me.txtRTSP.Location = New System.Drawing.Point(282, 121)
        Me.txtRTSP.Multiline = True
        Me.txtRTSP.Name = "txtRTSP"
        Me.txtRTSP.Size = New System.Drawing.Size(293, 20)
        Me.txtRTSP.TabIndex = 1226
        Me.txtRTSP.Text = "play 1-1 rtsp://admin:admin@192.168.5.41:554"
        '
        'cmbcapturedevicesAudio
        '
        Me.cmbcapturedevicesAudio.FormattingEnabled = True
        Me.cmbcapturedevicesAudio.Location = New System.Drawing.Point(442, 200)
        Me.cmbcapturedevicesAudio.Name = "cmbcapturedevicesAudio"
        Me.cmbcapturedevicesAudio.Size = New System.Drawing.Size(150, 21)
        Me.cmbcapturedevicesAudio.TabIndex = 1225
        '
        'cmbNDI
        '
        Me.cmbNDI.FormattingEnabled = True
        Me.cmbNDI.Location = New System.Drawing.Point(175, 32)
        Me.cmbNDI.Name = "cmbNDI"
        Me.cmbNDI.Size = New System.Drawing.Size(282, 21)
        Me.cmbNDI.TabIndex = 1224
        '
        'cmdplaychannelproducer
        '
        Me.cmdplaychannelproducer.BackColor = System.Drawing.Color.Green
        Me.cmdplaychannelproducer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplaychannelproducer.ForeColor = System.Drawing.Color.White
        Me.cmdplaychannelproducer.Location = New System.Drawing.Point(579, 86)
        Me.cmdplaychannelproducer.Name = "cmdplaychannelproducer"
        Me.cmdplaychannelproducer.Size = New System.Drawing.Size(75, 23)
        Me.cmdplaychannelproducer.TabIndex = 1223
        Me.cmdplaychannelproducer.Text = "Send"
        Me.cmdplaychannelproducer.UseVisualStyleBackColor = False
        '
        'txtchannelproducer
        '
        Me.txtchannelproducer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtchannelproducer", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtchannelproducer.Location = New System.Drawing.Point(475, 87)
        Me.txtchannelproducer.Name = "txtchannelproducer"
        Me.txtchannelproducer.Size = New System.Drawing.Size(100, 20)
        Me.txtchannelproducer.TabIndex = 1222
        Me.txtchannelproducer.Text = Global.caspar_media_playback.My.MySettings.Default.txtchannelproducer
        '
        'lblchannelproducer
        '
        Me.lblchannelproducer.AutoSize = True
        Me.lblchannelproducer.Location = New System.Drawing.Point(380, 90)
        Me.lblchannelproducer.Name = "lblchannelproducer"
        Me.lblchannelproducer.Size = New System.Drawing.Size(92, 13)
        Me.lblchannelproducer.TabIndex = 1221
        Me.lblchannelproducer.Text = "Channel Producer"
        '
        'cmdcopyon2ndchannel
        '
        Me.cmdcopyon2ndchannel.BackColor = System.Drawing.Color.Green
        Me.cmdcopyon2ndchannel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcopyon2ndchannel.ForeColor = System.Drawing.Color.White
        Me.cmdcopyon2ndchannel.Location = New System.Drawing.Point(579, 57)
        Me.cmdcopyon2ndchannel.Name = "cmdcopyon2ndchannel"
        Me.cmdcopyon2ndchannel.Size = New System.Drawing.Size(75, 23)
        Me.cmdcopyon2ndchannel.TabIndex = 1218
        Me.cmdcopyon2ndchannel.Text = "Send"
        Me.cmdcopyon2ndchannel.UseVisualStyleBackColor = False
        '
        'txtlayerproducer2
        '
        Me.txtlayerproducer2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtlayerproducer2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtlayerproducer2.Location = New System.Drawing.Point(475, 57)
        Me.txtlayerproducer2.Name = "txtlayerproducer2"
        Me.txtlayerproducer2.Size = New System.Drawing.Size(100, 20)
        Me.txtlayerproducer2.TabIndex = 1217
        Me.txtlayerproducer2.Text = Global.caspar_media_playback.My.MySettings.Default.txtlayerproducer2
        '
        'lbllayerproducer
        '
        Me.lbllayerproducer.AutoSize = True
        Me.lbllayerproducer.Location = New System.Drawing.Point(389, 62)
        Me.lbllayerproducer.Name = "lbllayerproducer"
        Me.lbllayerproducer.Size = New System.Drawing.Size(79, 13)
        Me.lbllayerproducer.TabIndex = 1216
        Me.lbllayerproducer.Text = "Layer Producer"
        '
        'cmbcapturedevices
        '
        Me.cmbcapturedevices.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbcapturedevices", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbcapturedevices.FormattingEnabled = True
        Me.cmbcapturedevices.Location = New System.Drawing.Point(238, 200)
        Me.cmbcapturedevices.Name = "cmbcapturedevices"
        Me.cmbcapturedevices.Size = New System.Drawing.Size(184, 21)
        Me.cmbcapturedevices.TabIndex = 1215
        Me.cmbcapturedevices.Text = Global.caspar_media_playback.My.MySettings.Default.cmbcapturedevices
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(7, 203)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(76, 13)
        Me.Label100.TabIndex = 1214
        Me.Label100.Text = "Direct Show"
        '
        'cmdplayusbcamera
        '
        Me.cmdplayusbcamera.BackColor = System.Drawing.Color.Green
        Me.cmdplayusbcamera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplayusbcamera.ForeColor = System.Drawing.Color.White
        Me.cmdplayusbcamera.Location = New System.Drawing.Point(603, 198)
        Me.cmdplayusbcamera.Name = "cmdplayusbcamera"
        Me.cmdplayusbcamera.Size = New System.Drawing.Size(51, 23)
        Me.cmdplayusbcamera.TabIndex = 1213
        Me.cmdplayusbcamera.Text = "Send"
        Me.cmdplayusbcamera.UseVisualStyleBackColor = False
        '
        'txtdirectshowproducer
        '
        Me.txtdirectshowproducer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtdirectshowproducer", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtdirectshowproducer.Location = New System.Drawing.Point(89, 201)
        Me.txtdirectshowproducer.Name = "txtdirectshowproducer"
        Me.txtdirectshowproducer.Size = New System.Drawing.Size(143, 20)
        Me.txtdirectshowproducer.TabIndex = 1212
        Me.txtdirectshowproducer.Text = Global.caspar_media_playback.My.MySettings.Default.txtdirectshowproducer
        '
        'cmdm3u8
        '
        Me.cmdm3u8.BackColor = System.Drawing.Color.Green
        Me.cmdm3u8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdm3u8.ForeColor = System.Drawing.Color.White
        Me.cmdm3u8.Location = New System.Drawing.Point(382, 162)
        Me.cmdm3u8.Name = "cmdm3u8"
        Me.cmdm3u8.Size = New System.Drawing.Size(75, 24)
        Me.cmdm3u8.TabIndex = 1211
        Me.cmdm3u8.Text = "Send"
        Me.cmdm3u8.UseVisualStyleBackColor = False
        '
        'txtm3u8
        '
        Me.txtm3u8.Location = New System.Drawing.Point(6, 162)
        Me.txtm3u8.Multiline = True
        Me.txtm3u8.Name = "txtm3u8"
        Me.txtm3u8.Size = New System.Drawing.Size(370, 20)
        Me.txtm3u8.TabIndex = 1210
        Me.txtm3u8.Text = "play 1-1 http://184.72.239.149/vod/smil:BigBuckBunny.smil/playlist.m3u8"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 1209
        Me.Label10.Text = "m3u8 Stream"
        '
        'cmdUDP
        '
        Me.cmdUDP.BackColor = System.Drawing.Color.Green
        Me.cmdUDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUDP.ForeColor = System.Drawing.Color.White
        Me.cmdUDP.Location = New System.Drawing.Point(214, 121)
        Me.cmdUDP.Name = "cmdUDP"
        Me.cmdUDP.Size = New System.Drawing.Size(52, 24)
        Me.cmdUDP.TabIndex = 1208
        Me.cmdUDP.Text = "Send"
        Me.cmdUDP.UseVisualStyleBackColor = False
        '
        'txtUDP
        '
        Me.txtUDP.Location = New System.Drawing.Point(6, 121)
        Me.txtUDP.Multiline = True
        Me.txtUDP.Name = "txtUDP"
        Me.txtUDP.Size = New System.Drawing.Size(202, 20)
        Me.txtUDP.TabIndex = 1207
        Me.txtUDP.Text = "play 1-1 udp://@localhost:5004"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 1206
        Me.Label9.Text = "UDP Stream"
        '
        'cmdSendRTP
        '
        Me.cmdSendRTP.BackColor = System.Drawing.Color.Green
        Me.cmdSendRTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSendRTP.ForeColor = System.Drawing.Color.White
        Me.cmdSendRTP.Location = New System.Drawing.Point(214, 78)
        Me.cmdSendRTP.Name = "cmdSendRTP"
        Me.cmdSendRTP.Size = New System.Drawing.Size(52, 24)
        Me.cmdSendRTP.TabIndex = 1205
        Me.cmdSendRTP.Text = "Send"
        Me.cmdSendRTP.UseVisualStyleBackColor = False
        '
        'txtRTP
        '
        Me.txtRTP.Location = New System.Drawing.Point(6, 78)
        Me.txtRTP.Multiline = True
        Me.txtRTP.Name = "txtRTP"
        Me.txtRTP.Size = New System.Drawing.Size(202, 20)
        Me.txtRTP.TabIndex = 1204
        Me.txtRTP.Text = "play 1-1 rtp://@192.168.15.205:8080"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 1203
        Me.Label8.Text = "RTP Stream"
        '
        'cmdSendNDI
        '
        Me.cmdSendNDI.BackColor = System.Drawing.Color.Green
        Me.cmdSendNDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSendNDI.ForeColor = System.Drawing.Color.White
        Me.cmdSendNDI.Location = New System.Drawing.Point(462, 31)
        Me.cmdSendNDI.Name = "cmdSendNDI"
        Me.cmdSendNDI.Size = New System.Drawing.Size(66, 24)
        Me.cmdSendNDI.TabIndex = 1202
        Me.cmdSendNDI.Text = "Send"
        Me.cmdSendNDI.UseVisualStyleBackColor = False
        '
        'txtNDI
        '
        Me.txtNDI.Location = New System.Drawing.Point(6, 32)
        Me.txtNDI.Multiline = True
        Me.txtNDI.Name = "txtNDI"
        Me.txtNDI.Size = New System.Drawing.Size(166, 20)
        Me.txtNDI.TabIndex = 1201
        Me.txtNDI.Text = "play 1-1 [ndi]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 13)
        Me.Label2.TabIndex = 1200
        Me.Label2.Text = "NDI Stream (Require Server 2.3)"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.BurlyWood
        Me.GroupBox1.Controls.Add(Me.cmbDesktopDecklink)
        Me.GroupBox1.Controls.Add(Me.txtDesktopDecklink2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmdDesktopDecklink)
        Me.GroupBox1.Controls.Add(Me.txtDesktopDecklink)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmdStreamFromHere)
        Me.GroupBox1.Controls.Add(Me.txtStreamFromHere)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmdDecklink)
        Me.GroupBox1.Controls.Add(Me.txtDecklink)
        Me.GroupBox1.Controls.Add(Me.cmdMonitor)
        Me.GroupBox1.Controls.Add(Me.txtmontor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBinFolder)
        Me.GroupBox1.Controls.Add(Me.cmdBinFolder)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 227)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(648, 373)
        Me.GroupBox1.TabIndex = 1199
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Srt Stream"
        '
        'cmbDesktopDecklink
        '
        Me.cmbDesktopDecklink.FormattingEnabled = True
        Me.cmbDesktopDecklink.Location = New System.Drawing.Point(217, 263)
        Me.cmbDesktopDecklink.Name = "cmbDesktopDecklink"
        Me.cmbDesktopDecklink.Size = New System.Drawing.Size(333, 21)
        Me.cmbDesktopDecklink.TabIndex = 1206
        Me.cmbDesktopDecklink.Text = "desktop"
        '
        'txtDesktopDecklink2
        '
        Me.txtDesktopDecklink2.Location = New System.Drawing.Point(8, 289)
        Me.txtDesktopDecklink2.Multiline = True
        Me.txtDesktopDecklink2.Name = "txtDesktopDecklink2"
        Me.txtDesktopDecklink2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDesktopDecklink2.Size = New System.Drawing.Size(543, 23)
        Me.txtDesktopDecklink2.TabIndex = 1205
        Me.txtDesktopDecklink2.Text = "  -tune zerolatency -f decklink -s 720x576 -pix_fmt uyvy422 -r 25 ""DeckLink Duo (" &
    "1)"""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 13)
        Me.Label11.TabIndex = 1202
        Me.Label11.Text = "Larix Broadcast"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(292, 13)
        Me.Label4.TabIndex = 1201
        Me.Label4.Text = "To Output Desktop or Windows title from Decklink"
        '
        'cmdDesktopDecklink
        '
        Me.cmdDesktopDecklink.Location = New System.Drawing.Point(560, 256)
        Me.cmdDesktopDecklink.Name = "cmdDesktopDecklink"
        Me.cmdDesktopDecklink.Size = New System.Drawing.Size(75, 66)
        Me.cmdDesktopDecklink.TabIndex = 1200
        Me.cmdDesktopDecklink.Text = "Desktop or Window Title Output To Decklink"
        Me.cmdDesktopDecklink.UseVisualStyleBackColor = True
        '
        'txtDesktopDecklink
        '
        Me.txtDesktopDecklink.Location = New System.Drawing.Point(5, 262)
        Me.txtDesktopDecklink.Multiline = True
        Me.txtDesktopDecklink.Name = "txtDesktopDecklink"
        Me.txtDesktopDecklink.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDesktopDecklink.Size = New System.Drawing.Size(207, 23)
        Me.txtDesktopDecklink.TabIndex = 1199
        Me.txtDesktopDecklink.Text = "ffmpeg.exe -f gdigrab -framerate 25 -i "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 13)
        Me.Label7.TabIndex = 1198
        Me.Label7.Text = "To Stream from This"
        '
        'cmdStreamFromHere
        '
        Me.cmdStreamFromHere.Location = New System.Drawing.Point(560, 328)
        Me.cmdStreamFromHere.Name = "cmdStreamFromHere"
        Me.cmdStreamFromHere.Size = New System.Drawing.Size(75, 40)
        Me.cmdStreamFromHere.TabIndex = 1197
        Me.cmdStreamFromHere.Text = "Stream From Here"
        Me.cmdStreamFromHere.UseVisualStyleBackColor = True
        '
        'txtStreamFromHere
        '
        Me.txtStreamFromHere.Location = New System.Drawing.Point(8, 337)
        Me.txtStreamFromHere.Multiline = True
        Me.txtStreamFromHere.Name = "txtStreamFromHere"
        Me.txtStreamFromHere.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtStreamFromHere.Size = New System.Drawing.Size(551, 23)
        Me.txtStreamFromHere.TabIndex = 1196
        Me.txtStreamFromHere.Text = "ffmpeg.exe -i c:/casparcg/_media/kabhi_kabhi.mp4 -f flv -fflags nobuffer srt://0." &
    "0.0.0:20000?mode=caller "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(105, 54)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(427, 13)
        Me.LinkLabel1.TabIndex = 1195
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://play.google.com/store/apps/details?id=com.wmspanel.larix_broadcaster&hl=e" &
    "n_IN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 16)
        Me.Label6.MaximumSize = New System.Drawing.Size(500, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(455, 26)
        Me.Label6.TabIndex = 1194
        Me.Label6.Text = "This is a program to receive stream from Mobile App Like Larix Boadcaster. To Rec" &
    "eive We need a special FFMpeg build which includes SRT protocol." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 13)
        Me.Label5.TabIndex = 1193
        Me.Label5.Text = "To Output from Decklink"
        '
        'cmdDecklink
        '
        Me.cmdDecklink.Location = New System.Drawing.Point(557, 203)
        Me.cmdDecklink.Name = "cmdDecklink"
        Me.cmdDecklink.Size = New System.Drawing.Size(75, 40)
        Me.cmdDecklink.TabIndex = 1192
        Me.cmdDecklink.Text = "Output To Decklink"
        Me.cmdDecklink.UseVisualStyleBackColor = True
        '
        'txtDecklink
        '
        Me.txtDecklink.Location = New System.Drawing.Point(5, 203)
        Me.txtDecklink.Multiline = True
        Me.txtDecklink.Name = "txtDecklink"
        Me.txtDecklink.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDecklink.Size = New System.Drawing.Size(546, 40)
        Me.txtDecklink.TabIndex = 1191
        Me.txtDecklink.Text = "ffmpeg.exe -i srt://0.0.0.0:20000?mode=listener -fflags nobuffer -tune zerolatenc" &
    "y -f decklink -s 720x576 -pix_fmt uyvy422 -r 25 ""DeckLink Duo (1)"""
        '
        'cmdMonitor
        '
        Me.cmdMonitor.Location = New System.Drawing.Point(557, 157)
        Me.cmdMonitor.Name = "cmdMonitor"
        Me.cmdMonitor.Size = New System.Drawing.Size(75, 24)
        Me.cmdMonitor.TabIndex = 1187
        Me.cmdMonitor.Text = "See"
        Me.cmdMonitor.UseVisualStyleBackColor = True
        '
        'txtmontor
        '
        Me.txtmontor.Location = New System.Drawing.Point(5, 157)
        Me.txtmontor.Multiline = True
        Me.txtmontor.Name = "txtmontor"
        Me.txtmontor.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtmontor.Size = New System.Drawing.Size(546, 24)
        Me.txtmontor.TabIndex = 1186
        Me.txtmontor.Text = "ffplay.exe -fflags nobuffer -i srt://0.0.0.0:20000?mode=listener -fflags nobuffer" &
    ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 13)
        Me.Label3.TabIndex = 1185
        Me.Label3.Text = "Just To see on Monitor only"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 13)
        Me.Label1.TabIndex = 1181
        Me.Label1.Text = "Decklink and SRT enabled Ffmpeg bin Folder Location"
        '
        'txtBinFolder
        '
        Me.txtBinFolder.Location = New System.Drawing.Point(5, 111)
        Me.txtBinFolder.Multiline = True
        Me.txtBinFolder.Name = "txtBinFolder"
        Me.txtBinFolder.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtBinFolder.Size = New System.Drawing.Size(546, 27)
        Me.txtBinFolder.TabIndex = 1180
        Me.txtBinFolder.Text = "c:\casparcg\mydata\goa\FFmpeg\bin\"
        '
        'cmdBinFolder
        '
        Me.cmdBinFolder.Location = New System.Drawing.Point(557, 111)
        Me.cmdBinFolder.Name = "cmdBinFolder"
        Me.cmdBinFolder.Size = New System.Drawing.Size(75, 23)
        Me.cmdBinFolder.TabIndex = 1179
        Me.cmdBinFolder.Text = "Change"
        Me.cmdBinFolder.UseVisualStyleBackColor = True
        '
        'ucStreamPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(666, 611)
        Me.Controls.Add(Me.gbstreamPlayer)
        Me.HideOnClose = True
        Me.Name = "ucStreamPlayer"
        Me.Text = "Stream Player"
        Me.gbstreamPlayer.ResumeLayout(False)
        Me.gbstreamPlayer.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbstreamPlayer As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdStreamFromHere As Button
    Friend WithEvents txtStreamFromHere As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdDecklink As Button
    Friend WithEvents txtDecklink As TextBox
    Friend WithEvents cmdMonitor As Button
    Friend WithEvents txtmontor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBinFolder As TextBox
    Friend WithEvents cmdBinFolder As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdSendNDI As Button
    Friend WithEvents txtNDI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdDesktopDecklink As Button
    Friend WithEvents txtDesktopDecklink As TextBox
    Friend WithEvents cmdSendRTP As Button
    Friend WithEvents txtRTP As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdUDP As Button
    Friend WithEvents txtUDP As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmdm3u8 As Button
    Friend WithEvents txtm3u8 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbcapturedevices As ComboBox
    Friend WithEvents Label100 As Label
    Friend WithEvents cmdplayusbcamera As Button
    Friend WithEvents txtdirectshowproducer As TextBox
    Friend WithEvents cmdplaychannelproducer As Button
    Friend WithEvents txtchannelproducer As TextBox
    Friend WithEvents lblchannelproducer As Label
    Friend WithEvents cmdcopyon2ndchannel As Button
    Friend WithEvents txtlayerproducer2 As TextBox
    Friend WithEvents lbllayerproducer As Label
    Friend WithEvents cmbNDI As ComboBox
    Friend WithEvents cmbcapturedevicesAudio As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbDesktopDecklink As ComboBox
    Friend WithEvents txtDesktopDecklink2 As TextBox
    Friend WithEvents cmdSendRTSP As Button
    Friend WithEvents txtRTSP As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents chkDshowAudio As CheckBox
    Friend WithEvents chkdshowVideo As CheckBox
End Class
