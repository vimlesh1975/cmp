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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pnlVolumeMixer = New System.Windows.Forms.Panel()
        Me.cmdGetvolumeMixer = New System.Windows.Forms.Button()
        Me.cmdgetDefaultPlaybackDevice = New System.Windows.Forms.Button()
        Me.cmdgetGetdefaultCaptureDevice = New System.Windows.Forms.Button()
        Me.lblDefaultcaptureDevice = New System.Windows.Forms.Label()
        Me.cmdsetDefaultCapturedevice = New System.Windows.Forms.Button()
        Me.lstPlaybackDevices = New System.Windows.Forms.ListBox()
        Me.lstCaptureDevices = New System.Windows.Forms.ListBox()
        Me.cmdsetDefaultplaybackdevice = New System.Windows.Forms.Button()
        Me.lblPlaybackDevices = New System.Windows.Forms.Label()
        Me.lblcaptureDevices = New System.Windows.Forms.Label()
        Me.lblDefaultPlaybackDevice = New System.Windows.Forms.Label()
        Me.cmdListDevices = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.gbUscreen = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmdSetFullScreen = New System.Windows.Forms.Button()
        Me.cmdSetRegionOfInterest = New System.Windows.Forms.Button()
        Me.nh = New System.Windows.Forms.NumericUpDown()
        Me.nw = New System.Windows.Forms.NumericUpDown()
        Me.ny = New System.Windows.Forms.NumericUpDown()
        Me.nx = New System.Windows.Forms.NumericUpDown()
        Me.cmdShowScreen = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.cmdRefreshNDISources = New System.Windows.Forms.Button()
        Me.cmdstopndi4 = New System.Windows.Forms.Button()
        Me.cmdstopndi3 = New System.Windows.Forms.Button()
        Me.cmdstopndi2 = New System.Windows.Forms.Button()
        Me.cmdstopndi = New System.Windows.Forms.Button()
        Me.txtNDI4 = New System.Windows.Forms.TextBox()
        Me.txtNDI3 = New System.Windows.Forms.TextBox()
        Me.txtNDI2 = New System.Windows.Forms.TextBox()
        Me.cmdSendNDI4 = New System.Windows.Forms.Button()
        Me.cmdSendNDI2 = New System.Windows.Forms.Button()
        Me.cmdSendNDI3 = New System.Windows.Forms.Button()
        Me.cmbNDI4 = New System.Windows.Forms.ComboBox()
        Me.cmbNDI3 = New System.Windows.Forms.ComboBox()
        Me.cmbNDI2 = New System.Windows.Forms.ComboBox()
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
        Me.cmdRecord = New System.Windows.Forms.Button()
        Me.txtRecord = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
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
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.gbstreamPlayer.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbUscreen.SuspendLayout()
        CType(Me.nh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ny, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbstreamPlayer
        '
        Me.gbstreamPlayer.BackColor = System.Drawing.Color.NavajoWhite
        Me.gbstreamPlayer.Controls.Add(Me.Label20)
        Me.gbstreamPlayer.Controls.Add(Me.LinkLabel3)
        Me.gbstreamPlayer.Controls.Add(Me.GroupBox2)
        Me.gbstreamPlayer.Controls.Add(Me.Label18)
        Me.gbstreamPlayer.Controls.Add(Me.gbUscreen)
        Me.gbstreamPlayer.Controls.Add(Me.Label12)
        Me.gbstreamPlayer.Controls.Add(Me.LinkLabel2)
        Me.gbstreamPlayer.Controls.Add(Me.cmdRefreshNDISources)
        Me.gbstreamPlayer.Controls.Add(Me.cmdstopndi4)
        Me.gbstreamPlayer.Controls.Add(Me.cmdstopndi3)
        Me.gbstreamPlayer.Controls.Add(Me.cmdstopndi2)
        Me.gbstreamPlayer.Controls.Add(Me.cmdstopndi)
        Me.gbstreamPlayer.Controls.Add(Me.txtNDI4)
        Me.gbstreamPlayer.Controls.Add(Me.txtNDI3)
        Me.gbstreamPlayer.Controls.Add(Me.txtNDI2)
        Me.gbstreamPlayer.Controls.Add(Me.cmdSendNDI4)
        Me.gbstreamPlayer.Controls.Add(Me.cmdSendNDI2)
        Me.gbstreamPlayer.Controls.Add(Me.cmdSendNDI3)
        Me.gbstreamPlayer.Controls.Add(Me.cmbNDI4)
        Me.gbstreamPlayer.Controls.Add(Me.cmbNDI3)
        Me.gbstreamPlayer.Controls.Add(Me.cmbNDI2)
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
        Me.gbstreamPlayer.Size = New System.Drawing.Size(1194, 911)
        Me.gbstreamPlayer.TabIndex = 1169
        Me.gbstreamPlayer.TabStop = False
        Me.gbstreamPlayer.Text = " "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox2.Controls.Add(Me.pnlVolumeMixer)
        Me.GroupBox2.Controls.Add(Me.cmdGetvolumeMixer)
        Me.GroupBox2.Controls.Add(Me.cmdgetDefaultPlaybackDevice)
        Me.GroupBox2.Controls.Add(Me.cmdgetGetdefaultCaptureDevice)
        Me.GroupBox2.Controls.Add(Me.lblDefaultcaptureDevice)
        Me.GroupBox2.Controls.Add(Me.cmdsetDefaultCapturedevice)
        Me.GroupBox2.Controls.Add(Me.lstPlaybackDevices)
        Me.GroupBox2.Controls.Add(Me.lstCaptureDevices)
        Me.GroupBox2.Controls.Add(Me.cmdsetDefaultplaybackdevice)
        Me.GroupBox2.Controls.Add(Me.lblPlaybackDevices)
        Me.GroupBox2.Controls.Add(Me.lblcaptureDevices)
        Me.GroupBox2.Controls.Add(Me.lblDefaultPlaybackDevice)
        Me.GroupBox2.Controls.Add(Me.cmdListDevices)
        Me.GroupBox2.Location = New System.Drawing.Point(592, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(597, 445)
        Me.GroupBox2.TabIndex = 1248
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Audio Utility"
        '
        'pnlVolumeMixer
        '
        Me.pnlVolumeMixer.Location = New System.Drawing.Point(3, 227)
        Me.pnlVolumeMixer.Name = "pnlVolumeMixer"
        Me.pnlVolumeMixer.Size = New System.Drawing.Size(588, 205)
        Me.pnlVolumeMixer.TabIndex = 30
        '
        'cmdGetvolumeMixer
        '
        Me.cmdGetvolumeMixer.Location = New System.Drawing.Point(10, 198)
        Me.cmdGetvolumeMixer.Name = "cmdGetvolumeMixer"
        Me.cmdGetvolumeMixer.Size = New System.Drawing.Size(103, 23)
        Me.cmdGetvolumeMixer.TabIndex = 13
        Me.cmdGetvolumeMixer.Text = "Get Volume Mixer"
        Me.cmdGetvolumeMixer.UseVisualStyleBackColor = True
        '
        'cmdgetDefaultPlaybackDevice
        '
        Me.cmdgetDefaultPlaybackDevice.Location = New System.Drawing.Point(287, 166)
        Me.cmdgetDefaultPlaybackDevice.Name = "cmdgetDefaultPlaybackDevice"
        Me.cmdgetDefaultPlaybackDevice.Size = New System.Drawing.Size(113, 23)
        Me.cmdgetDefaultPlaybackDevice.TabIndex = 12
        Me.cmdgetDefaultPlaybackDevice.Text = "get playback device"
        Me.cmdgetDefaultPlaybackDevice.UseVisualStyleBackColor = True
        '
        'cmdgetGetdefaultCaptureDevice
        '
        Me.cmdgetGetdefaultCaptureDevice.Location = New System.Drawing.Point(10, 169)
        Me.cmdgetGetdefaultCaptureDevice.Name = "cmdgetGetdefaultCaptureDevice"
        Me.cmdgetGetdefaultCaptureDevice.Size = New System.Drawing.Size(116, 23)
        Me.cmdgetGetdefaultCaptureDevice.TabIndex = 11
        Me.cmdgetGetdefaultCaptureDevice.Text = "Get Capture device"
        Me.cmdgetGetdefaultCaptureDevice.UseVisualStyleBackColor = True
        '
        'lblDefaultcaptureDevice
        '
        Me.lblDefaultcaptureDevice.AutoSize = True
        Me.lblDefaultcaptureDevice.Location = New System.Drawing.Point(128, 173)
        Me.lblDefaultcaptureDevice.Name = "lblDefaultcaptureDevice"
        Me.lblDefaultcaptureDevice.Size = New System.Drawing.Size(111, 13)
        Me.lblDefaultcaptureDevice.TabIndex = 10
        Me.lblDefaultcaptureDevice.Text = "DefaultcaptureDevice"
        '
        'cmdsetDefaultCapturedevice
        '
        Me.cmdsetDefaultCapturedevice.Location = New System.Drawing.Point(169, 56)
        Me.cmdsetDefaultCapturedevice.Name = "cmdsetDefaultCapturedevice"
        Me.cmdsetDefaultCapturedevice.Size = New System.Drawing.Size(111, 23)
        Me.cmdsetDefaultCapturedevice.TabIndex = 9
        Me.cmdsetDefaultCapturedevice.Text = "Set Capture device"
        Me.cmdsetDefaultCapturedevice.UseVisualStyleBackColor = True
        '
        'lstPlaybackDevices
        '
        Me.lstPlaybackDevices.FormattingEnabled = True
        Me.lstPlaybackDevices.Location = New System.Drawing.Point(287, 80)
        Me.lstPlaybackDevices.Name = "lstPlaybackDevices"
        Me.lstPlaybackDevices.Size = New System.Drawing.Size(273, 82)
        Me.lstPlaybackDevices.TabIndex = 8
        '
        'lstCaptureDevices
        '
        Me.lstCaptureDevices.FormattingEnabled = True
        Me.lstCaptureDevices.Location = New System.Drawing.Point(9, 80)
        Me.lstCaptureDevices.Name = "lstCaptureDevices"
        Me.lstCaptureDevices.Size = New System.Drawing.Size(271, 82)
        Me.lstCaptureDevices.TabIndex = 7
        '
        'cmdsetDefaultplaybackdevice
        '
        Me.cmdsetDefaultplaybackdevice.Location = New System.Drawing.Point(443, 56)
        Me.cmdsetDefaultplaybackdevice.Name = "cmdsetDefaultplaybackdevice"
        Me.cmdsetDefaultplaybackdevice.Size = New System.Drawing.Size(116, 23)
        Me.cmdsetDefaultplaybackdevice.TabIndex = 6
        Me.cmdsetDefaultplaybackdevice.Text = "Set playback device"
        Me.cmdsetDefaultplaybackdevice.UseVisualStyleBackColor = True
        '
        'lblPlaybackDevices
        '
        Me.lblPlaybackDevices.AutoSize = True
        Me.lblPlaybackDevices.Location = New System.Drawing.Point(284, 61)
        Me.lblPlaybackDevices.Name = "lblPlaybackDevices"
        Me.lblPlaybackDevices.Size = New System.Drawing.Size(93, 13)
        Me.lblPlaybackDevices.TabIndex = 5
        Me.lblPlaybackDevices.Text = "Playback Devices"
        '
        'lblcaptureDevices
        '
        Me.lblcaptureDevices.AutoSize = True
        Me.lblcaptureDevices.Location = New System.Drawing.Point(6, 51)
        Me.lblcaptureDevices.Name = "lblcaptureDevices"
        Me.lblcaptureDevices.Size = New System.Drawing.Size(86, 13)
        Me.lblcaptureDevices.TabIndex = 4
        Me.lblcaptureDevices.Text = "Capture Devices"
        '
        'lblDefaultPlaybackDevice
        '
        Me.lblDefaultPlaybackDevice.AutoSize = True
        Me.lblDefaultPlaybackDevice.Location = New System.Drawing.Point(403, 171)
        Me.lblDefaultPlaybackDevice.Name = "lblDefaultPlaybackDevice"
        Me.lblDefaultPlaybackDevice.Size = New System.Drawing.Size(119, 13)
        Me.lblDefaultPlaybackDevice.TabIndex = 3
        Me.lblDefaultPlaybackDevice.Text = "DefaultPlaybackDevice"
        '
        'cmdListDevices
        '
        Me.cmdListDevices.Location = New System.Drawing.Point(9, 12)
        Me.cmdListDevices.Name = "cmdListDevices"
        Me.cmdListDevices.Size = New System.Drawing.Size(195, 23)
        Me.cmdListDevices.TabIndex = 2
        Me.cmdListDevices.Text = "List All Capture and Playback Devices"
        Me.cmdListDevices.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 445)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(548, 16)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "For Desktop Capture Select Screen capture recorder and virtual audio recoder"
        '
        'gbUscreen
        '
        Me.gbUscreen.BackColor = System.Drawing.Color.DarkOrange
        Me.gbUscreen.Controls.Add(Me.Label14)
        Me.gbUscreen.Controls.Add(Me.Label15)
        Me.gbUscreen.Controls.Add(Me.Label16)
        Me.gbUscreen.Controls.Add(Me.Label17)
        Me.gbUscreen.Controls.Add(Me.cmdSetFullScreen)
        Me.gbUscreen.Controls.Add(Me.cmdSetRegionOfInterest)
        Me.gbUscreen.Controls.Add(Me.nh)
        Me.gbUscreen.Controls.Add(Me.nw)
        Me.gbUscreen.Controls.Add(Me.ny)
        Me.gbUscreen.Controls.Add(Me.nx)
        Me.gbUscreen.Controls.Add(Me.cmdShowScreen)
        Me.gbUscreen.Location = New System.Drawing.Point(299, 309)
        Me.gbUscreen.Name = "gbUscreen"
        Me.gbUscreen.Size = New System.Drawing.Size(287, 119)
        Me.gbUscreen.TabIndex = 1247
        Me.gbUscreen.TabStop = False
        Me.gbUscreen.Text = "Seeting for Uscreencapture Filter for Screen capture"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 16)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "H"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(22, 16)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "W"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 44)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 16)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Y"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(10, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(17, 16)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "X"
        '
        'cmdSetFullScreen
        '
        Me.cmdSetFullScreen.Location = New System.Drawing.Point(88, 26)
        Me.cmdSetFullScreen.Name = "cmdSetFullScreen"
        Me.cmdSetFullScreen.Size = New System.Drawing.Size(134, 31)
        Me.cmdSetFullScreen.TabIndex = 16
        Me.cmdSetFullScreen.Text = "Set Full Screen"
        Me.cmdSetFullScreen.UseVisualStyleBackColor = True
        '
        'cmdSetRegionOfInterest
        '
        Me.cmdSetRegionOfInterest.Location = New System.Drawing.Point(88, 60)
        Me.cmdSetRegionOfInterest.Name = "cmdSetRegionOfInterest"
        Me.cmdSetRegionOfInterest.Size = New System.Drawing.Size(134, 29)
        Me.cmdSetRegionOfInterest.TabIndex = 15
        Me.cmdSetRegionOfInterest.Text = "Set Region Of Interest"
        Me.cmdSetRegionOfInterest.UseVisualStyleBackColor = True
        '
        'nh
        '
        Me.nh.Location = New System.Drawing.Point(33, 94)
        Me.nh.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.nh.Name = "nh"
        Me.nh.Size = New System.Drawing.Size(49, 20)
        Me.nh.TabIndex = 14
        '
        'nw
        '
        Me.nw.Location = New System.Drawing.Point(33, 68)
        Me.nw.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.nw.Name = "nw"
        Me.nw.Size = New System.Drawing.Size(49, 20)
        Me.nw.TabIndex = 13
        '
        'ny
        '
        Me.ny.Location = New System.Drawing.Point(33, 42)
        Me.ny.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.ny.Name = "ny"
        Me.ny.Size = New System.Drawing.Size(49, 20)
        Me.ny.TabIndex = 12
        '
        'nx
        '
        Me.nx.Location = New System.Drawing.Point(33, 16)
        Me.nx.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.nx.Name = "nx"
        Me.nx.Size = New System.Drawing.Size(49, 20)
        Me.nx.TabIndex = 11
        '
        'cmdShowScreen
        '
        Me.cmdShowScreen.Location = New System.Drawing.Point(228, 23)
        Me.cmdShowScreen.Name = "cmdShowScreen"
        Me.cmdShowScreen.Size = New System.Drawing.Size(55, 63)
        Me.cmdShowScreen.TabIndex = 10
        Me.cmdShowScreen.Text = "Show Screen"
        Me.cmdShowScreen.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 1246
        Me.Label12.Text = "NDI Files"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(71, 6)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(382, 13)
        Me.LinkLabel2.TabIndex = 1245
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "https://drive.google.com/open?id=13gz0NeFkSw5oEBK8JaZJcr0MJBuv4TmG"
        '
        'cmdRefreshNDISources
        '
        Me.cmdRefreshNDISources.Location = New System.Drawing.Point(325, 27)
        Me.cmdRefreshNDISources.Name = "cmdRefreshNDISources"
        Me.cmdRefreshNDISources.Size = New System.Drawing.Size(136, 23)
        Me.cmdRefreshNDISources.TabIndex = 1244
        Me.cmdRefreshNDISources.Text = "Refresh NDI Sources"
        Me.cmdRefreshNDISources.UseVisualStyleBackColor = True
        '
        'cmdstopndi4
        '
        Me.cmdstopndi4.BackColor = System.Drawing.Color.Red
        Me.cmdstopndi4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopndi4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdstopndi4.Location = New System.Drawing.Point(446, 135)
        Me.cmdstopndi4.Name = "cmdstopndi4"
        Me.cmdstopndi4.Size = New System.Drawing.Size(74, 24)
        Me.cmdstopndi4.TabIndex = 1243
        Me.cmdstopndi4.Text = "Stop"
        Me.cmdstopndi4.UseVisualStyleBackColor = False
        '
        'cmdstopndi3
        '
        Me.cmdstopndi3.BackColor = System.Drawing.Color.Red
        Me.cmdstopndi3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopndi3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdstopndi3.Location = New System.Drawing.Point(446, 111)
        Me.cmdstopndi3.Name = "cmdstopndi3"
        Me.cmdstopndi3.Size = New System.Drawing.Size(74, 24)
        Me.cmdstopndi3.TabIndex = 1242
        Me.cmdstopndi3.Text = "Stop"
        Me.cmdstopndi3.UseVisualStyleBackColor = False
        '
        'cmdstopndi2
        '
        Me.cmdstopndi2.BackColor = System.Drawing.Color.Red
        Me.cmdstopndi2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopndi2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdstopndi2.Location = New System.Drawing.Point(446, 83)
        Me.cmdstopndi2.Name = "cmdstopndi2"
        Me.cmdstopndi2.Size = New System.Drawing.Size(74, 24)
        Me.cmdstopndi2.TabIndex = 1241
        Me.cmdstopndi2.Text = "Stop"
        Me.cmdstopndi2.UseVisualStyleBackColor = False
        '
        'cmdstopndi
        '
        Me.cmdstopndi.BackColor = System.Drawing.Color.Red
        Me.cmdstopndi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopndi.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdstopndi.Location = New System.Drawing.Point(446, 57)
        Me.cmdstopndi.Name = "cmdstopndi"
        Me.cmdstopndi.Size = New System.Drawing.Size(74, 24)
        Me.cmdstopndi.TabIndex = 1240
        Me.cmdstopndi.Text = "Stop"
        Me.cmdstopndi.UseVisualStyleBackColor = False
        '
        'txtNDI4
        '
        Me.txtNDI4.Location = New System.Drawing.Point(7, 142)
        Me.txtNDI4.Multiline = True
        Me.txtNDI4.Name = "txtNDI4"
        Me.txtNDI4.Size = New System.Drawing.Size(75, 20)
        Me.txtNDI4.TabIndex = 1239
        Me.txtNDI4.Text = "play 4-1 [ndi]"
        '
        'txtNDI3
        '
        Me.txtNDI3.Location = New System.Drawing.Point(6, 115)
        Me.txtNDI3.Multiline = True
        Me.txtNDI3.Name = "txtNDI3"
        Me.txtNDI3.Size = New System.Drawing.Size(75, 20)
        Me.txtNDI3.TabIndex = 1238
        Me.txtNDI3.Text = "play 3-1 [ndi]"
        '
        'txtNDI2
        '
        Me.txtNDI2.Location = New System.Drawing.Point(6, 87)
        Me.txtNDI2.Multiline = True
        Me.txtNDI2.Name = "txtNDI2"
        Me.txtNDI2.Size = New System.Drawing.Size(75, 20)
        Me.txtNDI2.TabIndex = 1237
        Me.txtNDI2.Text = "play 2-1 [ndi]"
        '
        'cmdSendNDI4
        '
        Me.cmdSendNDI4.BackColor = System.Drawing.Color.Green
        Me.cmdSendNDI4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSendNDI4.ForeColor = System.Drawing.Color.White
        Me.cmdSendNDI4.Location = New System.Drawing.Point(374, 138)
        Me.cmdSendNDI4.Name = "cmdSendNDI4"
        Me.cmdSendNDI4.Size = New System.Drawing.Size(66, 24)
        Me.cmdSendNDI4.TabIndex = 1236
        Me.cmdSendNDI4.Text = "Send"
        Me.cmdSendNDI4.UseVisualStyleBackColor = False
        '
        'cmdSendNDI2
        '
        Me.cmdSendNDI2.BackColor = System.Drawing.Color.Green
        Me.cmdSendNDI2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSendNDI2.ForeColor = System.Drawing.Color.White
        Me.cmdSendNDI2.Location = New System.Drawing.Point(374, 84)
        Me.cmdSendNDI2.Name = "cmdSendNDI2"
        Me.cmdSendNDI2.Size = New System.Drawing.Size(66, 24)
        Me.cmdSendNDI2.TabIndex = 1235
        Me.cmdSendNDI2.Text = "Send"
        Me.cmdSendNDI2.UseVisualStyleBackColor = False
        '
        'cmdSendNDI3
        '
        Me.cmdSendNDI3.BackColor = System.Drawing.Color.Green
        Me.cmdSendNDI3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSendNDI3.ForeColor = System.Drawing.Color.White
        Me.cmdSendNDI3.Location = New System.Drawing.Point(374, 111)
        Me.cmdSendNDI3.Name = "cmdSendNDI3"
        Me.cmdSendNDI3.Size = New System.Drawing.Size(66, 24)
        Me.cmdSendNDI3.TabIndex = 1234
        Me.cmdSendNDI3.Text = "Send"
        Me.cmdSendNDI3.UseVisualStyleBackColor = False
        '
        'cmbNDI4
        '
        Me.cmbNDI4.FormattingEnabled = True
        Me.cmbNDI4.Location = New System.Drawing.Point(87, 141)
        Me.cmbNDI4.Name = "cmbNDI4"
        Me.cmbNDI4.Size = New System.Drawing.Size(282, 21)
        Me.cmbNDI4.TabIndex = 1233
        '
        'cmbNDI3
        '
        Me.cmbNDI3.FormattingEnabled = True
        Me.cmbNDI3.Location = New System.Drawing.Point(87, 114)
        Me.cmbNDI3.Name = "cmbNDI3"
        Me.cmbNDI3.Size = New System.Drawing.Size(282, 21)
        Me.cmbNDI3.TabIndex = 1232
        '
        'cmbNDI2
        '
        Me.cmbNDI2.FormattingEnabled = True
        Me.cmbNDI2.Location = New System.Drawing.Point(87, 87)
        Me.cmbNDI2.Name = "cmbNDI2"
        Me.cmbNDI2.Size = New System.Drawing.Size(282, 21)
        Me.cmbNDI2.TabIndex = 1231
        '
        'chkDshowAudio
        '
        Me.chkDshowAudio.AutoSize = True
        Me.chkDshowAudio.Location = New System.Drawing.Point(425, 459)
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
        Me.chkdshowVideo.Location = New System.Drawing.Point(231, 464)
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
        Me.Label13.Location = New System.Drawing.Point(3, 190)
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
        Me.cmdSendRTSP.Location = New System.Drawing.Point(459, 187)
        Me.cmdSendRTSP.Name = "cmdSendRTSP"
        Me.cmdSendRTSP.Size = New System.Drawing.Size(73, 24)
        Me.cmdSendRTSP.TabIndex = 1227
        Me.cmdSendRTSP.Text = "Send"
        Me.cmdSendRTSP.UseVisualStyleBackColor = False
        '
        'txtRTSP
        '
        Me.txtRTSP.Location = New System.Drawing.Point(160, 187)
        Me.txtRTSP.Multiline = True
        Me.txtRTSP.Name = "txtRTSP"
        Me.txtRTSP.Size = New System.Drawing.Size(293, 20)
        Me.txtRTSP.TabIndex = 1226
        Me.txtRTSP.Text = "play 1-1 rtsp://admin:admin@192.168.5.41:554"
        '
        'cmbcapturedevicesAudio
        '
        Me.cmbcapturedevicesAudio.FormattingEnabled = True
        Me.cmbcapturedevicesAudio.Location = New System.Drawing.Point(423, 482)
        Me.cmbcapturedevicesAudio.Name = "cmbcapturedevicesAudio"
        Me.cmbcapturedevicesAudio.Size = New System.Drawing.Size(150, 21)
        Me.cmbcapturedevicesAudio.TabIndex = 1225
        '
        'cmbNDI
        '
        Me.cmbNDI.FormattingEnabled = True
        Me.cmbNDI.Location = New System.Drawing.Point(87, 60)
        Me.cmbNDI.Name = "cmbNDI"
        Me.cmbNDI.Size = New System.Drawing.Size(282, 21)
        Me.cmbNDI.TabIndex = 1224
        '
        'cmdplaychannelproducer
        '
        Me.cmdplaychannelproducer.BackColor = System.Drawing.Color.Green
        Me.cmdplaychannelproducer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplaychannelproducer.ForeColor = System.Drawing.Color.White
        Me.cmdplaychannelproducer.Location = New System.Drawing.Point(220, 329)
        Me.cmdplaychannelproducer.Name = "cmdplaychannelproducer"
        Me.cmdplaychannelproducer.Size = New System.Drawing.Size(75, 23)
        Me.cmdplaychannelproducer.TabIndex = 1223
        Me.cmdplaychannelproducer.Text = "Send"
        Me.cmdplaychannelproducer.UseVisualStyleBackColor = False
        '
        'txtchannelproducer
        '
        Me.txtchannelproducer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtchannelproducer", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtchannelproducer.Location = New System.Drawing.Point(116, 330)
        Me.txtchannelproducer.Name = "txtchannelproducer"
        Me.txtchannelproducer.Size = New System.Drawing.Size(100, 20)
        Me.txtchannelproducer.TabIndex = 1222
        Me.txtchannelproducer.Text = Global.caspar_media_playback.My.MySettings.Default.txtchannelproducer
        '
        'lblchannelproducer
        '
        Me.lblchannelproducer.AutoSize = True
        Me.lblchannelproducer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchannelproducer.Location = New System.Drawing.Point(2, 333)
        Me.lblchannelproducer.Name = "lblchannelproducer"
        Me.lblchannelproducer.Size = New System.Drawing.Size(108, 13)
        Me.lblchannelproducer.TabIndex = 1221
        Me.lblchannelproducer.Text = "Channel Producer"
        '
        'cmdcopyon2ndchannel
        '
        Me.cmdcopyon2ndchannel.BackColor = System.Drawing.Color.Green
        Me.cmdcopyon2ndchannel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcopyon2ndchannel.ForeColor = System.Drawing.Color.White
        Me.cmdcopyon2ndchannel.Location = New System.Drawing.Point(220, 300)
        Me.cmdcopyon2ndchannel.Name = "cmdcopyon2ndchannel"
        Me.cmdcopyon2ndchannel.Size = New System.Drawing.Size(75, 23)
        Me.cmdcopyon2ndchannel.TabIndex = 1218
        Me.cmdcopyon2ndchannel.Text = "Send"
        Me.cmdcopyon2ndchannel.UseVisualStyleBackColor = False
        '
        'txtlayerproducer2
        '
        Me.txtlayerproducer2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtlayerproducer2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtlayerproducer2.Location = New System.Drawing.Point(116, 300)
        Me.txtlayerproducer2.Name = "txtlayerproducer2"
        Me.txtlayerproducer2.Size = New System.Drawing.Size(100, 20)
        Me.txtlayerproducer2.TabIndex = 1217
        Me.txtlayerproducer2.Text = Global.caspar_media_playback.My.MySettings.Default.txtlayerproducer2
        '
        'lbllayerproducer
        '
        Me.lbllayerproducer.AutoSize = True
        Me.lbllayerproducer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllayerproducer.Location = New System.Drawing.Point(11, 305)
        Me.lbllayerproducer.Name = "lbllayerproducer"
        Me.lbllayerproducer.Size = New System.Drawing.Size(93, 13)
        Me.lbllayerproducer.TabIndex = 1216
        Me.lbllayerproducer.Text = "Layer Producer"
        '
        'cmbcapturedevices
        '
        Me.cmbcapturedevices.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbcapturedevices", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbcapturedevices.FormattingEnabled = True
        Me.cmbcapturedevices.Location = New System.Drawing.Point(231, 482)
        Me.cmbcapturedevices.Name = "cmbcapturedevices"
        Me.cmbcapturedevices.Size = New System.Drawing.Size(184, 21)
        Me.cmbcapturedevices.TabIndex = 1215
        Me.cmbcapturedevices.Text = Global.caspar_media_playback.My.MySettings.Default.cmbcapturedevices
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(6, 485)
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
        Me.cmdplayusbcamera.Location = New System.Drawing.Point(578, 480)
        Me.cmdplayusbcamera.Name = "cmdplayusbcamera"
        Me.cmdplayusbcamera.Size = New System.Drawing.Size(57, 23)
        Me.cmdplayusbcamera.TabIndex = 1213
        Me.cmdplayusbcamera.Text = "Send"
        Me.cmdplayusbcamera.UseVisualStyleBackColor = False
        '
        'txtdirectshowproducer
        '
        Me.txtdirectshowproducer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtdirectshowproducer", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtdirectshowproducer.Location = New System.Drawing.Point(82, 483)
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
        Me.cmdm3u8.Location = New System.Drawing.Point(466, 274)
        Me.cmdm3u8.Name = "cmdm3u8"
        Me.cmdm3u8.Size = New System.Drawing.Size(75, 24)
        Me.cmdm3u8.TabIndex = 1211
        Me.cmdm3u8.Text = "Send"
        Me.cmdm3u8.UseVisualStyleBackColor = False
        '
        'txtm3u8
        '
        Me.txtm3u8.Location = New System.Drawing.Point(90, 274)
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
        Me.Label10.Location = New System.Drawing.Point(5, 276)
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
        Me.cmdUDP.Location = New System.Drawing.Point(298, 245)
        Me.cmdUDP.Name = "cmdUDP"
        Me.cmdUDP.Size = New System.Drawing.Size(52, 24)
        Me.cmdUDP.TabIndex = 1208
        Me.cmdUDP.Text = "Send"
        Me.cmdUDP.UseVisualStyleBackColor = False
        '
        'txtUDP
        '
        Me.txtUDP.Location = New System.Drawing.Point(90, 245)
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
        Me.Label9.Location = New System.Drawing.Point(7, 245)
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
        Me.cmdSendRTP.Location = New System.Drawing.Point(298, 215)
        Me.cmdSendRTP.Name = "cmdSendRTP"
        Me.cmdSendRTP.Size = New System.Drawing.Size(52, 24)
        Me.cmdSendRTP.TabIndex = 1205
        Me.cmdSendRTP.Text = "Send"
        Me.cmdSendRTP.UseVisualStyleBackColor = False
        '
        'txtRTP
        '
        Me.txtRTP.Location = New System.Drawing.Point(90, 215)
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
        Me.Label8.Location = New System.Drawing.Point(7, 215)
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
        Me.cmdSendNDI.Location = New System.Drawing.Point(374, 59)
        Me.cmdSendNDI.Name = "cmdSendNDI"
        Me.cmdSendNDI.Size = New System.Drawing.Size(66, 24)
        Me.cmdSendNDI.TabIndex = 1202
        Me.cmdSendNDI.Text = "Send"
        Me.cmdSendNDI.UseVisualStyleBackColor = False
        '
        'txtNDI
        '
        Me.txtNDI.Location = New System.Drawing.Point(7, 59)
        Me.txtNDI.Multiline = True
        Me.txtNDI.Name = "txtNDI"
        Me.txtNDI.Size = New System.Drawing.Size(75, 20)
        Me.txtNDI.TabIndex = 1201
        Me.txtNDI.Text = "play 1-1 [ndi]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 13)
        Me.Label2.TabIndex = 1200
        Me.Label2.Text = "NDI Stream (Require Server 2.3)"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.BurlyWood
        Me.GroupBox1.Controls.Add(Me.cmdRecord)
        Me.GroupBox1.Controls.Add(Me.txtRecord)
        Me.GroupBox1.Controls.Add(Me.Label19)
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
        Me.GroupBox1.Location = New System.Drawing.Point(6, 509)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 397)
        Me.GroupBox1.TabIndex = 1199
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Srt Stream"
        '
        'cmdRecord
        '
        Me.cmdRecord.Location = New System.Drawing.Point(529, 178)
        Me.cmdRecord.Name = "cmdRecord"
        Me.cmdRecord.Size = New System.Drawing.Size(75, 24)
        Me.cmdRecord.TabIndex = 1209
        Me.cmdRecord.Text = "Record"
        Me.cmdRecord.UseVisualStyleBackColor = True
        '
        'txtRecord
        '
        Me.txtRecord.Location = New System.Drawing.Point(8, 180)
        Me.txtRecord.Multiline = True
        Me.txtRecord.Name = "txtRecord"
        Me.txtRecord.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRecord.Size = New System.Drawing.Size(509, 24)
        Me.txtRecord.TabIndex = 1208
        Me.txtRecord.Text = "ffmpeg.exe -y  -i srt://0.0.0.0:20000?mode=listener -fflags nobuffer c:/casparcg/" &
    "_media/srt.mp4"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(5, 164)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 13)
        Me.Label19.TabIndex = 1207
        Me.Label19.Text = "To Record"
        '
        'cmbDesktopDecklink
        '
        Me.cmbDesktopDecklink.FormattingEnabled = True
        Me.cmbDesktopDecklink.Location = New System.Drawing.Point(217, 289)
        Me.cmbDesktopDecklink.Name = "cmbDesktopDecklink"
        Me.cmbDesktopDecklink.Size = New System.Drawing.Size(296, 21)
        Me.cmbDesktopDecklink.TabIndex = 1206
        Me.cmbDesktopDecklink.Text = "desktop"
        '
        'txtDesktopDecklink2
        '
        Me.txtDesktopDecklink2.Location = New System.Drawing.Point(8, 315)
        Me.txtDesktopDecklink2.Multiline = True
        Me.txtDesktopDecklink2.Name = "txtDesktopDecklink2"
        Me.txtDesktopDecklink2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDesktopDecklink2.Size = New System.Drawing.Size(506, 23)
        Me.txtDesktopDecklink2.TabIndex = 1205
        Me.txtDesktopDecklink2.Text = "  -tune zerolatency -f decklink -s 720x576 -pix_fmt uyvy422 -r 25 ""DeckLink Duo (" &
    "1)"""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 13)
        Me.Label11.TabIndex = 1202
        Me.Label11.Text = "Larix Broadcast"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(292, 13)
        Me.Label4.TabIndex = 1201
        Me.Label4.Text = "To Output Desktop or Windows title from Decklink"
        '
        'cmdDesktopDecklink
        '
        Me.cmdDesktopDecklink.Location = New System.Drawing.Point(529, 280)
        Me.cmdDesktopDecklink.Name = "cmdDesktopDecklink"
        Me.cmdDesktopDecklink.Size = New System.Drawing.Size(75, 66)
        Me.cmdDesktopDecklink.TabIndex = 1200
        Me.cmdDesktopDecklink.Text = "Desktop or Window Title Output To Decklink"
        Me.cmdDesktopDecklink.UseVisualStyleBackColor = True
        '
        'txtDesktopDecklink
        '
        Me.txtDesktopDecklink.Location = New System.Drawing.Point(5, 288)
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
        Me.Label7.Location = New System.Drawing.Point(5, 346)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 13)
        Me.Label7.TabIndex = 1198
        Me.Label7.Text = "To Stream from This"
        '
        'cmdStreamFromHere
        '
        Me.cmdStreamFromHere.Location = New System.Drawing.Point(529, 352)
        Me.cmdStreamFromHere.Name = "cmdStreamFromHere"
        Me.cmdStreamFromHere.Size = New System.Drawing.Size(75, 40)
        Me.cmdStreamFromHere.TabIndex = 1197
        Me.cmdStreamFromHere.Text = "Stream From Here"
        Me.cmdStreamFromHere.UseVisualStyleBackColor = True
        '
        'txtStreamFromHere
        '
        Me.txtStreamFromHere.Location = New System.Drawing.Point(8, 363)
        Me.txtStreamFromHere.Multiline = True
        Me.txtStreamFromHere.Name = "txtStreamFromHere"
        Me.txtStreamFromHere.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtStreamFromHere.Size = New System.Drawing.Size(514, 23)
        Me.txtStreamFromHere.TabIndex = 1196
        Me.txtStreamFromHere.Text = "ffmpeg.exe -i c:/casparcg/_media/kabhi_kabhi.mp4 -f flv -fflags nobuffer srt://0." &
    "0.0.0:20000?mode=caller "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(105, 49)
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
        Me.Label5.Location = New System.Drawing.Point(2, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 13)
        Me.Label5.TabIndex = 1193
        Me.Label5.Text = "To Output from Decklink"
        '
        'cmdDecklink
        '
        Me.cmdDecklink.Location = New System.Drawing.Point(526, 227)
        Me.cmdDecklink.Name = "cmdDecklink"
        Me.cmdDecklink.Size = New System.Drawing.Size(75, 40)
        Me.cmdDecklink.TabIndex = 1192
        Me.cmdDecklink.Text = "Output To Decklink"
        Me.cmdDecklink.UseVisualStyleBackColor = True
        '
        'txtDecklink
        '
        Me.txtDecklink.Location = New System.Drawing.Point(5, 229)
        Me.txtDecklink.Multiline = True
        Me.txtDecklink.Name = "txtDecklink"
        Me.txtDecklink.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDecklink.Size = New System.Drawing.Size(509, 40)
        Me.txtDecklink.TabIndex = 1191
        Me.txtDecklink.Text = "ffmpeg.exe -i srt://0.0.0.0:20000?mode=listener -fflags nobuffer -tune zerolatenc" &
    "y -f decklink -s 720x576 -pix_fmt uyvy422 -r 25 ""DeckLink Duo (1)"""
        '
        'cmdMonitor
        '
        Me.cmdMonitor.Location = New System.Drawing.Point(526, 132)
        Me.cmdMonitor.Name = "cmdMonitor"
        Me.cmdMonitor.Size = New System.Drawing.Size(75, 24)
        Me.cmdMonitor.TabIndex = 1187
        Me.cmdMonitor.Text = "See"
        Me.cmdMonitor.UseVisualStyleBackColor = True
        '
        'txtmontor
        '
        Me.txtmontor.Location = New System.Drawing.Point(5, 134)
        Me.txtmontor.Multiline = True
        Me.txtmontor.Name = "txtmontor"
        Me.txtmontor.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtmontor.Size = New System.Drawing.Size(509, 24)
        Me.txtmontor.TabIndex = 1186
        Me.txtmontor.Text = "ffplay.exe -fflags nobuffer -i srt://0.0.0.0:20000?mode=listener -fflags nobuffer" &
    ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 13)
        Me.Label3.TabIndex = 1185
        Me.Label3.Text = "Just To see on Monitor only"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 13)
        Me.Label1.TabIndex = 1181
        Me.Label1.Text = "Decklink and SRT enabled Ffmpeg bin Folder Location"
        '
        'txtBinFolder
        '
        Me.txtBinFolder.Location = New System.Drawing.Point(5, 85)
        Me.txtBinFolder.Multiline = True
        Me.txtBinFolder.Name = "txtBinFolder"
        Me.txtBinFolder.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtBinFolder.Size = New System.Drawing.Size(509, 27)
        Me.txtBinFolder.TabIndex = 1180
        Me.txtBinFolder.Text = "c:\casparcg\mydata\goa\FFmpeg\bin\"
        '
        'cmdBinFolder
        '
        Me.cmdBinFolder.Location = New System.Drawing.Point(526, 83)
        Me.cmdBinFolder.Name = "cmdBinFolder"
        Me.cmdBinFolder.Size = New System.Drawing.Size(75, 23)
        Me.cmdBinFolder.TabIndex = 1179
        Me.cmdBinFolder.Text = "Change"
        Me.cmdBinFolder.UseVisualStyleBackColor = True
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(5, 401)
        Me.LinkLabel3.MaximumSize = New System.Drawing.Size(290, 0)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(290, 39)
        Me.LinkLabel3.TabIndex = 1210
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "https://github.com/rdp/screen-capture-recorder-to-video-windows-free/releases/dow" &
    "nload/0.12.10/Setup.Screen.Capturer.Recorder.v0.12.10.exe"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(4, 369)
        Me.Label20.MaximumSize = New System.Drawing.Size(290, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(276, 26)
        Me.Label20.TabIndex = 1249
        Me.Label20.Text = "Screen Capture Recorder link (Install if Screen Capture recorder is not avalilabl" &
    "e here.)"
        '
        'ucStreamPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1208, 921)
        Me.Controls.Add(Me.gbstreamPlayer)
        Me.HideOnClose = True
        Me.Name = "ucStreamPlayer"
        Me.Text = "Stream Player"
        Me.gbstreamPlayer.ResumeLayout(False)
        Me.gbstreamPlayer.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbUscreen.ResumeLayout(False)
        Me.gbUscreen.PerformLayout()
        CType(Me.nh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ny, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nx, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtNDI4 As TextBox
    Friend WithEvents txtNDI3 As TextBox
    Friend WithEvents txtNDI2 As TextBox
    Friend WithEvents cmdSendNDI4 As Button
    Friend WithEvents cmdSendNDI2 As Button
    Friend WithEvents cmdSendNDI3 As Button
    Friend WithEvents cmbNDI4 As ComboBox
    Friend WithEvents cmbNDI3 As ComboBox
    Friend WithEvents cmbNDI2 As ComboBox
    Friend WithEvents cmdstopndi4 As Button
    Friend WithEvents cmdstopndi3 As Button
    Friend WithEvents cmdstopndi2 As Button
    Friend WithEvents cmdstopndi As Button
    Friend WithEvents cmdRefreshNDISources As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label18 As Label
    Friend WithEvents gbUscreen As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmdSetFullScreen As Button
    Friend WithEvents cmdSetRegionOfInterest As Button
    Friend WithEvents nh As NumericUpDown
    Friend WithEvents nw As NumericUpDown
    Friend WithEvents ny As NumericUpDown
    Friend WithEvents nx As NumericUpDown
    Friend WithEvents cmdShowScreen As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents pnlVolumeMixer As Panel
    Friend WithEvents cmdGetvolumeMixer As Button
    Friend WithEvents cmdgetDefaultPlaybackDevice As Button
    Friend WithEvents cmdgetGetdefaultCaptureDevice As Button
    Friend WithEvents lblDefaultcaptureDevice As Label
    Friend WithEvents cmdsetDefaultCapturedevice As Button
    Friend WithEvents lstPlaybackDevices As ListBox
    Friend WithEvents lstCaptureDevices As ListBox
    Friend WithEvents cmdsetDefaultplaybackdevice As Button
    Friend WithEvents lblPlaybackDevices As Label
    Friend WithEvents lblcaptureDevices As Label
    Friend WithEvents lblDefaultPlaybackDevice As Label
    Friend WithEvents cmdListDevices As Button
    Friend WithEvents cmdRecord As Button
    Friend WithEvents txtRecord As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents LinkLabel3 As LinkLabel
End Class
