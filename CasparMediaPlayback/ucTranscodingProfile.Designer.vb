<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTranscodingProfile
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTranscodingProfile))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtnumberofprocessors = New System.Windows.Forms.TextBox()
        Me.lblnumberofprocessors = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtExtraCrop = New System.Windows.Forms.TextBox()
        Me.rdoHDblacktoHDoverBlurVideo = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBoxSize = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotalSize = New System.Windows.Forms.TextBox()
        Me.cmdBorderColor = New System.Windows.Forms.Button()
        Me.nborderwidth = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rdoSDtoSDoverBlurVideo = New System.Windows.Forms.RadioButton()
        Me.cmdOpenLogo = New System.Windows.Forms.Button()
        Me.vlcLogo = New Vlc.DotNet.Forms.VlcControl()
        Me.txtFPS = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rdoanytoAnamorphicXDcamHD422Mxf = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbextension5 = New System.Windows.Forms.ComboBox()
        Me.rdoTranscodeWithLogo = New System.Windows.Forms.RadioButton()
        Me.Label251 = New System.Windows.Forms.Label()
        Me.Label252 = New System.Windows.Forms.Label()
        Me.Label253 = New System.Windows.Forms.Label()
        Me.Label254 = New System.Windows.Forms.Label()
        Me.nlogoheightforexport = New System.Windows.Forms.NumericUpDown()
        Me.nlogowidthforexport = New System.Windows.Forms.NumericUpDown()
        Me.nlogoyposition = New System.Windows.Forms.NumericUpDown()
        Me.nlogoxposition = New System.Windows.Forms.NumericUpDown()
        Me.cmbbitrate5 = New System.Windows.Forms.ComboBox()
        Me.cmbaudiocodec5 = New System.Windows.Forms.ComboBox()
        Me.cmbvideocodec5 = New System.Windows.Forms.ComboBox()
        Me.cmbbitrate = New System.Windows.Forms.ComboBox()
        Me.cmbaudiocodec = New System.Windows.Forms.ComboBox()
        Me.cmbvideocodec = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbextensioncodecbased = New System.Windows.Forms.ComboBox()
        Me.rdoCodecBased = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ntranscodeinmp4bitratehevc = New System.Windows.Forms.NumericUpDown()
        Me.rdoTrancodemp4hevc = New System.Windows.Forms.RadioButton()
        Me.cmbformatforhdtoAnamorphicdv = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbextensionhdtoAnamprphicdv = New System.Windows.Forms.ComboBox()
        Me.rdoHDtoAnamorphicmov = New System.Windows.Forms.RadioButton()
        Me.cmbformatforhdtoLetterBoxdv = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cmbextensionhdtoLetterBoxdv = New System.Windows.Forms.ComboBox()
        Me.rdoHDtoLetterBoxSDmov = New System.Windows.Forms.RadioButton()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.ntranscodeinmp4bitrate = New System.Windows.Forms.NumericUpDown()
        Me.cmbformatforhdtocentercutdv = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbextensionhdtocentercutdv = New System.Windows.Forms.ComboBox()
        Me.cmbformatedvcpro50 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbextensiondvcpro50 = New System.Windows.Forms.ComboBox()
        Me.rdodvcpro50dv = New System.Windows.Forms.RadioButton()
        Me.rdoHDtoCenterCutSDmov = New System.Windows.Forms.RadioButton()
        Me.rdoNX5CameraMTSHDtoCenterCutSDmpg = New System.Windows.Forms.RadioButton()
        Me.rdoTrancodemp4 = New System.Windows.Forms.RadioButton()
        Me.rdoCustomTranscode = New System.Windows.Forms.RadioButton()
        Me.rdoHDtoXDCAMHD422mxfwithFFMBC = New System.Windows.Forms.RadioButton()
        Me.rdoHD1920x1080tosdCenterCutmxf = New System.Windows.Forms.RadioButton()
        Me.rdoSDtoXDcamHD422Mxf = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdocustomtranscodeffmbc = New System.Windows.Forms.RadioButton()
        Me.rdocustomtranscodeffmpeg = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbextensioncustom = New System.Windows.Forms.ComboBox()
        Me.txtoptionstrimmercustom = New System.Windows.Forms.TextBox()
        Me.ckkUseSuffix = New System.Windows.Forms.CheckBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nborderwidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vlcLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nlogoheightforexport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nlogowidthforexport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nlogoyposition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nlogoxposition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ntranscodeinmp4bitratehevc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ntranscodeinmp4bitrate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.ckkUseSuffix)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.txtnumberofprocessors)
        Me.GroupBox3.Controls.Add(Me.lblnumberofprocessors)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(379, 795)
        Me.GroupBox3.TabIndex = 806
        Me.GroupBox3.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 773)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(128, 13)
        Me.Label24.TabIndex = 814
        Me.Label24.Text = "Use cores for transcoding"
        '
        'txtnumberofprocessors
        '
        Me.txtnumberofprocessors.Location = New System.Drawing.Point(140, 770)
        Me.txtnumberofprocessors.Name = "txtnumberofprocessors"
        Me.txtnumberofprocessors.Size = New System.Drawing.Size(29, 20)
        Me.txtnumberofprocessors.TabIndex = 813
        Me.txtnumberofprocessors.Text = "4"
        '
        'lblnumberofprocessors
        '
        Me.lblnumberofprocessors.AutoSize = True
        Me.lblnumberofprocessors.Location = New System.Drawing.Point(11, 752)
        Me.lblnumberofprocessors.Name = "lblnumberofprocessors"
        Me.lblnumberofprocessors.Size = New System.Drawing.Size(112, 13)
        Me.lblnumberofprocessors.TabIndex = 812
        Me.lblnumberofprocessors.Text = "lblnumberofprocessors"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtExtraCrop)
        Me.GroupBox1.Controls.Add(Me.rdoHDblacktoHDoverBlurVideo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtBoxSize)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtTotalSize)
        Me.GroupBox1.Controls.Add(Me.cmdBorderColor)
        Me.GroupBox1.Controls.Add(Me.nborderwidth)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.rdoSDtoSDoverBlurVideo)
        Me.GroupBox1.Controls.Add(Me.cmdOpenLogo)
        Me.GroupBox1.Controls.Add(Me.vlcLogo)
        Me.GroupBox1.Controls.Add(Me.txtFPS)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.rdoanytoAnamorphicXDcamHD422Mxf)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbextension5)
        Me.GroupBox1.Controls.Add(Me.rdoTranscodeWithLogo)
        Me.GroupBox1.Controls.Add(Me.Label251)
        Me.GroupBox1.Controls.Add(Me.Label252)
        Me.GroupBox1.Controls.Add(Me.Label253)
        Me.GroupBox1.Controls.Add(Me.Label254)
        Me.GroupBox1.Controls.Add(Me.nlogoheightforexport)
        Me.GroupBox1.Controls.Add(Me.nlogowidthforexport)
        Me.GroupBox1.Controls.Add(Me.nlogoyposition)
        Me.GroupBox1.Controls.Add(Me.nlogoxposition)
        Me.GroupBox1.Controls.Add(Me.cmbbitrate5)
        Me.GroupBox1.Controls.Add(Me.cmbaudiocodec5)
        Me.GroupBox1.Controls.Add(Me.cmbvideocodec5)
        Me.GroupBox1.Controls.Add(Me.cmbbitrate)
        Me.GroupBox1.Controls.Add(Me.cmbaudiocodec)
        Me.GroupBox1.Controls.Add(Me.cmbvideocodec)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbextensioncodecbased)
        Me.GroupBox1.Controls.Add(Me.rdoCodecBased)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ntranscodeinmp4bitratehevc)
        Me.GroupBox1.Controls.Add(Me.rdoTrancodemp4hevc)
        Me.GroupBox1.Controls.Add(Me.cmbformatforhdtoAnamorphicdv)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbextensionhdtoAnamprphicdv)
        Me.GroupBox1.Controls.Add(Me.rdoHDtoAnamorphicmov)
        Me.GroupBox1.Controls.Add(Me.cmbformatforhdtoLetterBoxdv)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.cmbextensionhdtoLetterBoxdv)
        Me.GroupBox1.Controls.Add(Me.rdoHDtoLetterBoxSDmov)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.ntranscodeinmp4bitrate)
        Me.GroupBox1.Controls.Add(Me.cmbformatforhdtocentercutdv)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbextensionhdtocentercutdv)
        Me.GroupBox1.Controls.Add(Me.cmbformatedvcpro50)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbextensiondvcpro50)
        Me.GroupBox1.Controls.Add(Me.rdodvcpro50dv)
        Me.GroupBox1.Controls.Add(Me.rdoHDtoCenterCutSDmov)
        Me.GroupBox1.Controls.Add(Me.rdoNX5CameraMTSHDtoCenterCutSDmpg)
        Me.GroupBox1.Controls.Add(Me.rdoTrancodemp4)
        Me.GroupBox1.Controls.Add(Me.rdoCustomTranscode)
        Me.GroupBox1.Controls.Add(Me.rdoHDtoXDCAMHD422mxfwithFFMBC)
        Me.GroupBox1.Controls.Add(Me.rdoHD1920x1080tosdCenterCutmxf)
        Me.GroupBox1.Controls.Add(Me.rdoSDtoXDcamHD422Mxf)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 585)
        Me.GroupBox1.TabIndex = 776
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transcoding Profiles"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(212, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 1213
        Me.Label13.Text = "Extra Crop"
        '
        'txtExtraCrop
        '
        Me.txtExtraCrop.Location = New System.Drawing.Point(271, 98)
        Me.txtExtraCrop.Name = "txtExtraCrop"
        Me.txtExtraCrop.Size = New System.Drawing.Size(39, 20)
        Me.txtExtraCrop.TabIndex = 1212
        Me.txtExtraCrop.Text = "0"
        '
        'rdoHDblacktoHDoverBlurVideo
        '
        Me.rdoHDblacktoHDoverBlurVideo.AutoSize = True
        Me.rdoHDblacktoHDoverBlurVideo.Location = New System.Drawing.Point(12, 147)
        Me.rdoHDblacktoHDoverBlurVideo.Name = "rdoHDblacktoHDoverBlurVideo"
        Me.rdoHDblacktoHDoverBlurVideo.Size = New System.Drawing.Size(254, 17)
        Me.rdoHDblacktoHDoverBlurVideo.TabIndex = 1211
        Me.rdoHDblacktoHDoverBlurVideo.Text = "HD with black pillar box to HD over Blured Video"
        Me.rdoHDblacktoHDoverBlurVideo.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(141, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 1210
        Me.Label12.Text = "Box Size"
        '
        'txtBoxSize
        '
        Me.txtBoxSize.Location = New System.Drawing.Point(196, 123)
        Me.txtBoxSize.Name = "txtBoxSize"
        Me.txtBoxSize.Size = New System.Drawing.Size(66, 20)
        Me.txtBoxSize.TabIndex = 1209
        Me.txtBoxSize.Text = "1350:1080"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 1208
        Me.Label11.Text = "Total Size"
        '
        'txtTotalSize
        '
        Me.txtTotalSize.Location = New System.Drawing.Point(69, 120)
        Me.txtTotalSize.Name = "txtTotalSize"
        Me.txtTotalSize.Size = New System.Drawing.Size(66, 20)
        Me.txtTotalSize.TabIndex = 1207
        Me.txtTotalSize.Text = "1920:1080"
        '
        'cmdBorderColor
        '
        Me.cmdBorderColor.BackColor = System.Drawing.Color.Red
        Me.cmdBorderColor.ForeColor = System.Drawing.Color.White
        Me.cmdBorderColor.Location = New System.Drawing.Point(129, 94)
        Me.cmdBorderColor.Name = "cmdBorderColor"
        Me.cmdBorderColor.Size = New System.Drawing.Size(75, 23)
        Me.cmdBorderColor.TabIndex = 1206
        Me.cmdBorderColor.Text = "Border Color"
        Me.cmdBorderColor.UseVisualStyleBackColor = False
        '
        'nborderwidth
        '
        Me.nborderwidth.Location = New System.Drawing.Point(85, 96)
        Me.nborderwidth.Name = "nborderwidth"
        Me.nborderwidth.Size = New System.Drawing.Size(38, 20)
        Me.nborderwidth.TabIndex = 1205
        Me.nborderwidth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 1204
        Me.Label8.Text = "Border Width"
        '
        'rdoSDtoSDoverBlurVideo
        '
        Me.rdoSDtoSDoverBlurVideo.AutoSize = True
        Me.rdoSDtoSDoverBlurVideo.Location = New System.Drawing.Point(9, 68)
        Me.rdoSDtoSDoverBlurVideo.Name = "rdoSDtoSDoverBlurVideo"
        Me.rdoSDtoSDoverBlurVideo.Size = New System.Drawing.Size(158, 17)
        Me.rdoSDtoSDoverBlurVideo.TabIndex = 1203
        Me.rdoSDtoSDoverBlurVideo.Text = "SD to HD over Blured Video"
        Me.rdoSDtoSDoverBlurVideo.UseVisualStyleBackColor = True
        '
        'cmdOpenLogo
        '
        Me.cmdOpenLogo.Location = New System.Drawing.Point(243, 508)
        Me.cmdOpenLogo.Name = "cmdOpenLogo"
        Me.cmdOpenLogo.Size = New System.Drawing.Size(75, 36)
        Me.cmdOpenLogo.TabIndex = 1202
        Me.cmdOpenLogo.Text = "Open Logo"
        Me.cmdOpenLogo.UseVisualStyleBackColor = True
        '
        'vlcLogo
        '
        Me.vlcLogo.BackColor = System.Drawing.Color.Black
        Me.vlcLogo.Location = New System.Drawing.Point(149, 504)
        Me.vlcLogo.Name = "vlcLogo"
        Me.vlcLogo.Size = New System.Drawing.Size(87, 61)
        Me.vlcLogo.Spu = -1
        Me.vlcLogo.TabIndex = 1201
        Me.vlcLogo.Text = "VlcControl1"
        Me.vlcLogo.VlcLibDirectory = CType(resources.GetObject("vlcLogo.VlcLibDirectory"), System.IO.DirectoryInfo)
        Me.vlcLogo.VlcMediaplayerOptions = Nothing
        '
        'txtFPS
        '
        Me.txtFPS.Location = New System.Drawing.Point(267, 41)
        Me.txtFPS.Name = "txtFPS"
        Me.txtFPS.Size = New System.Drawing.Size(32, 20)
        Me.txtFPS.TabIndex = 835
        Me.txtFPS.Text = "25"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(234, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 834
        Me.Label7.Text = "FPS"
        '
        'rdoanytoAnamorphicXDcamHD422Mxf
        '
        Me.rdoanytoAnamorphicXDcamHD422Mxf.AutoSize = True
        Me.rdoanytoAnamorphicXDcamHD422Mxf.Location = New System.Drawing.Point(9, 41)
        Me.rdoanytoAnamorphicXDcamHD422Mxf.Name = "rdoanytoAnamorphicXDcamHD422Mxf"
        Me.rdoanytoAnamorphicXDcamHD422Mxf.Size = New System.Drawing.Size(220, 17)
        Me.rdoanytoAnamorphicXDcamHD422Mxf.TabIndex = 833
        Me.rdoanytoAnamorphicXDcamHD422Mxf.Text = "Any to Anamorphic XDCAM HD 422 MXF"
        Me.rdoanytoAnamorphicXDcamHD422Mxf.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(245, 481)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 832
        Me.Label6.Text = "Extension"
        '
        'cmbextension5
        '
        Me.cmbextension5.FormattingEnabled = True
        Me.cmbextension5.Items.AddRange(New Object() {".avi", ".mp4", ".ogg", ".mxf", ".mov", ".mkv", ".mpg", ".mts", ".dv"})
        Me.cmbextension5.Location = New System.Drawing.Point(299, 477)
        Me.cmbextension5.Name = "cmbextension5"
        Me.cmbextension5.Size = New System.Drawing.Size(56, 21)
        Me.cmbextension5.TabIndex = 831
        Me.cmbextension5.Text = ".mov"
        '
        'rdoTranscodeWithLogo
        '
        Me.rdoTranscodeWithLogo.AutoSize = True
        Me.rdoTranscodeWithLogo.Location = New System.Drawing.Point(10, 459)
        Me.rdoTranscodeWithLogo.Name = "rdoTranscodeWithLogo"
        Me.rdoTranscodeWithLogo.Size = New System.Drawing.Size(121, 17)
        Me.rdoTranscodeWithLogo.TabIndex = 830
        Me.rdoTranscodeWithLogo.Text = "Transcode with logo"
        Me.rdoTranscodeWithLogo.UseVisualStyleBackColor = True
        '
        'Label251
        '
        Me.Label251.AutoSize = True
        Me.Label251.Location = New System.Drawing.Point(88, 509)
        Me.Label251.Name = "Label251"
        Me.Label251.Size = New System.Drawing.Size(14, 13)
        Me.Label251.TabIndex = 829
        Me.Label251.Text = "Y"
        '
        'Label252
        '
        Me.Label252.AutoSize = True
        Me.Label252.Location = New System.Drawing.Point(22, 508)
        Me.Label252.Name = "Label252"
        Me.Label252.Size = New System.Drawing.Size(14, 13)
        Me.Label252.TabIndex = 828
        Me.Label252.Text = "X"
        '
        'Label253
        '
        Me.Label253.AutoSize = True
        Me.Label253.Location = New System.Drawing.Point(87, 531)
        Me.Label253.Name = "Label253"
        Me.Label253.Size = New System.Drawing.Size(15, 13)
        Me.Label253.TabIndex = 827
        Me.Label253.Text = "H"
        '
        'Label254
        '
        Me.Label254.AutoSize = True
        Me.Label254.Location = New System.Drawing.Point(18, 534)
        Me.Label254.Name = "Label254"
        Me.Label254.Size = New System.Drawing.Size(18, 13)
        Me.Label254.TabIndex = 826
        Me.Label254.Text = "W"
        '
        'nlogoheightforexport
        '
        Me.nlogoheightforexport.Location = New System.Drawing.Point(106, 529)
        Me.nlogoheightforexport.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.nlogoheightforexport.Name = "nlogoheightforexport"
        Me.nlogoheightforexport.Size = New System.Drawing.Size(37, 20)
        Me.nlogoheightforexport.TabIndex = 825
        Me.nlogoheightforexport.Value = New Decimal(New Integer() {75, 0, 0, 0})
        '
        'nlogowidthforexport
        '
        Me.nlogowidthforexport.Location = New System.Drawing.Point(42, 529)
        Me.nlogowidthforexport.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.nlogowidthforexport.Name = "nlogowidthforexport"
        Me.nlogowidthforexport.Size = New System.Drawing.Size(45, 20)
        Me.nlogowidthforexport.TabIndex = 824
        Me.nlogowidthforexport.Value = New Decimal(New Integer() {75, 0, 0, 0})
        '
        'nlogoyposition
        '
        Me.nlogoyposition.Location = New System.Drawing.Point(106, 506)
        Me.nlogoyposition.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.nlogoyposition.Name = "nlogoyposition"
        Me.nlogoyposition.Size = New System.Drawing.Size(37, 20)
        Me.nlogoyposition.TabIndex = 822
        Me.nlogoyposition.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'nlogoxposition
        '
        Me.nlogoxposition.Location = New System.Drawing.Point(42, 505)
        Me.nlogoxposition.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.nlogoxposition.Name = "nlogoxposition"
        Me.nlogoxposition.Size = New System.Drawing.Size(45, 20)
        Me.nlogoxposition.TabIndex = 821
        Me.nlogoxposition.Value = New Decimal(New Integer() {615, 0, 0, 0})
        '
        'cmbbitrate5
        '
        Me.cmbbitrate5.FormattingEnabled = True
        Me.cmbbitrate5.Items.AddRange(New Object() {"0.5", "1.0", "1.5", "2.0", "3", "4", "5", "6", "7", "8", "9", "10", "15", "20", "25", "30", "35", "40", "45", "50"})
        Me.cmbbitrate5.Location = New System.Drawing.Point(195, 478)
        Me.cmbbitrate5.Name = "cmbbitrate5"
        Me.cmbbitrate5.Size = New System.Drawing.Size(46, 21)
        Me.cmbbitrate5.TabIndex = 819
        Me.cmbbitrate5.Text = "1.0"
        '
        'cmbaudiocodec5
        '
        Me.cmbaudiocodec5.FormattingEnabled = True
        Me.cmbaudiocodec5.Location = New System.Drawing.Point(108, 477)
        Me.cmbaudiocodec5.Name = "cmbaudiocodec5"
        Me.cmbaudiocodec5.Size = New System.Drawing.Size(76, 21)
        Me.cmbaudiocodec5.Sorted = True
        Me.cmbaudiocodec5.TabIndex = 818
        Me.cmbaudiocodec5.Text = "aac"
        '
        'cmbvideocodec5
        '
        Me.cmbvideocodec5.FormattingEnabled = True
        Me.cmbvideocodec5.Location = New System.Drawing.Point(17, 477)
        Me.cmbvideocodec5.Name = "cmbvideocodec5"
        Me.cmbvideocodec5.Size = New System.Drawing.Size(88, 21)
        Me.cmbvideocodec5.Sorted = True
        Me.cmbvideocodec5.TabIndex = 817
        Me.cmbvideocodec5.Text = "libx264"
        '
        'cmbbitrate
        '
        Me.cmbbitrate.FormattingEnabled = True
        Me.cmbbitrate.Items.AddRange(New Object() {"0.5", "1.0", "1.5", "2.0", "3", "4", "5", "6", "7", "8", "9", "10", "15", "20", "25", "30", "35", "40", "45", "50"})
        Me.cmbbitrate.Location = New System.Drawing.Point(195, 433)
        Me.cmbbitrate.Name = "cmbbitrate"
        Me.cmbbitrate.Size = New System.Drawing.Size(46, 21)
        Me.cmbbitrate.TabIndex = 815
        Me.cmbbitrate.Text = "12"
        '
        'cmbaudiocodec
        '
        Me.cmbaudiocodec.FormattingEnabled = True
        Me.cmbaudiocodec.Location = New System.Drawing.Point(110, 433)
        Me.cmbaudiocodec.Name = "cmbaudiocodec"
        Me.cmbaudiocodec.Size = New System.Drawing.Size(76, 21)
        Me.cmbaudiocodec.Sorted = True
        Me.cmbaudiocodec.TabIndex = 811
        Me.cmbaudiocodec.Text = "aac"
        '
        'cmbvideocodec
        '
        Me.cmbvideocodec.FormattingEnabled = True
        Me.cmbvideocodec.Location = New System.Drawing.Point(17, 433)
        Me.cmbvideocodec.Name = "cmbvideocodec"
        Me.cmbvideocodec.Size = New System.Drawing.Size(88, 21)
        Me.cmbvideocodec.Sorted = True
        Me.cmbvideocodec.TabIndex = 810
        Me.cmbvideocodec.Text = "libx264"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(246, 437)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 809
        Me.Label4.Text = "Extension"
        '
        'cmbextensioncodecbased
        '
        Me.cmbextensioncodecbased.FormattingEnabled = True
        Me.cmbextensioncodecbased.Items.AddRange(New Object() {".avi", ".mp4", ".ogg", ".mxf", ".mov", ".mkv", ".mpg", ".mts", ".dv"})
        Me.cmbextensioncodecbased.Location = New System.Drawing.Point(300, 433)
        Me.cmbextensioncodecbased.Name = "cmbextensioncodecbased"
        Me.cmbextensioncodecbased.Size = New System.Drawing.Size(56, 21)
        Me.cmbextensioncodecbased.TabIndex = 808
        Me.cmbextensioncodecbased.Text = ".mov"
        '
        'rdoCodecBased
        '
        Me.rdoCodecBased.AutoSize = True
        Me.rdoCodecBased.Location = New System.Drawing.Point(9, 413)
        Me.rdoCodecBased.Name = "rdoCodecBased"
        Me.rdoCodecBased.Size = New System.Drawing.Size(89, 17)
        Me.rdoCodecBased.TabIndex = 807
        Me.rdoCodecBased.Text = "Codec Based"
        Me.rdoCodecBased.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 805
        Me.Label2.Text = "BitRate mbps"
        '
        'ntranscodeinmp4bitratehevc
        '
        Me.ntranscodeinmp4bitratehevc.Location = New System.Drawing.Point(260, 262)
        Me.ntranscodeinmp4bitratehevc.Minimum = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.ntranscodeinmp4bitratehevc.Name = "ntranscodeinmp4bitratehevc"
        Me.ntranscodeinmp4bitratehevc.Size = New System.Drawing.Size(50, 20)
        Me.ntranscodeinmp4bitratehevc.TabIndex = 806
        Me.ntranscodeinmp4bitratehevc.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rdoTrancodemp4hevc
        '
        Me.rdoTrancodemp4hevc.AutoSize = True
        Me.rdoTrancodemp4hevc.Location = New System.Drawing.Point(7, 260)
        Me.rdoTrancodemp4hevc.Name = "rdoTrancodemp4hevc"
        Me.rdoTrancodemp4hevc.Size = New System.Drawing.Size(180, 17)
        Me.rdoTrancodemp4hevc.TabIndex = 804
        Me.rdoTrancodemp4hevc.Text = "Trancode in mp4   hevc (libx265)"
        Me.rdoTrancodemp4hevc.UseVisualStyleBackColor = True
        '
        'cmbformatforhdtoAnamorphicdv
        '
        Me.cmbformatforhdtoAnamorphicdv.FormattingEnabled = True
        Me.cmbformatforhdtoAnamorphicdv.Items.AddRange(New Object() {"vcd", "dvd", "dvcpro", "dvcpro50", "dvcprohd", "imx30", "imx50", "xdcamhd422"})
        Me.cmbformatforhdtoAnamorphicdv.Location = New System.Drawing.Point(142, 360)
        Me.cmbformatforhdtoAnamorphicdv.Name = "cmbformatforhdtoAnamorphicdv"
        Me.cmbformatforhdtoAnamorphicdv.Size = New System.Drawing.Size(101, 21)
        Me.cmbformatforhdtoAnamorphicdv.TabIndex = 803
        Me.cmbformatforhdtoAnamorphicdv.Text = "dvcpro50"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(245, 364)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 802
        Me.Label1.Text = "Extension"
        '
        'cmbextensionhdtoAnamprphicdv
        '
        Me.cmbextensionhdtoAnamprphicdv.FormattingEnabled = True
        Me.cmbextensionhdtoAnamprphicdv.Items.AddRange(New Object() {".avi", ".mp4", ".ogg", ".mxf", ".mov", ".mkv", ".mpg", ".mts", ".dv"})
        Me.cmbextensionhdtoAnamprphicdv.Location = New System.Drawing.Point(299, 362)
        Me.cmbextensionhdtoAnamprphicdv.Name = "cmbextensionhdtoAnamprphicdv"
        Me.cmbextensionhdtoAnamprphicdv.Size = New System.Drawing.Size(56, 21)
        Me.cmbextensionhdtoAnamprphicdv.TabIndex = 801
        Me.cmbextensionhdtoAnamprphicdv.Text = ".mov"
        '
        'rdoHDtoAnamorphicmov
        '
        Me.rdoHDtoAnamorphicmov.AutoSize = True
        Me.rdoHDtoAnamorphicmov.Location = New System.Drawing.Point(8, 361)
        Me.rdoHDtoAnamorphicmov.Name = "rdoHDtoAnamorphicmov"
        Me.rdoHDtoAnamorphicmov.Size = New System.Drawing.Size(130, 17)
        Me.rdoHDtoAnamorphicmov.TabIndex = 800
        Me.rdoHDtoAnamorphicmov.Text = "HD to Anamorphic DV"
        Me.rdoHDtoAnamorphicmov.UseVisualStyleBackColor = True
        '
        'cmbformatforhdtoLetterBoxdv
        '
        Me.cmbformatforhdtoLetterBoxdv.FormattingEnabled = True
        Me.cmbformatforhdtoLetterBoxdv.Items.AddRange(New Object() {"vcd", "dvd", "dvcpro", "dvcpro50", "dvcprohd", "imx30", "imx50", "xdcamhd422"})
        Me.cmbformatforhdtoLetterBoxdv.Location = New System.Drawing.Point(142, 335)
        Me.cmbformatforhdtoLetterBoxdv.Name = "cmbformatforhdtoLetterBoxdv"
        Me.cmbformatforhdtoLetterBoxdv.Size = New System.Drawing.Size(101, 21)
        Me.cmbformatforhdtoLetterBoxdv.TabIndex = 799
        Me.cmbformatforhdtoLetterBoxdv.Text = "dvcpro50"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(245, 339)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(53, 13)
        Me.Label34.TabIndex = 798
        Me.Label34.Text = "Extension"
        '
        'cmbextensionhdtoLetterBoxdv
        '
        Me.cmbextensionhdtoLetterBoxdv.FormattingEnabled = True
        Me.cmbextensionhdtoLetterBoxdv.Items.AddRange(New Object() {".avi", ".mp4", ".ogg", ".mxf", ".mov", ".mkv", ".mpg", ".mts", ".dv"})
        Me.cmbextensionhdtoLetterBoxdv.Location = New System.Drawing.Point(299, 337)
        Me.cmbextensionhdtoLetterBoxdv.Name = "cmbextensionhdtoLetterBoxdv"
        Me.cmbextensionhdtoLetterBoxdv.Size = New System.Drawing.Size(56, 21)
        Me.cmbextensionhdtoLetterBoxdv.TabIndex = 797
        Me.cmbextensionhdtoLetterBoxdv.Text = ".mov"
        '
        'rdoHDtoLetterBoxSDmov
        '
        Me.rdoHDtoLetterBoxSDmov.AutoSize = True
        Me.rdoHDtoLetterBoxSDmov.Location = New System.Drawing.Point(8, 338)
        Me.rdoHDtoLetterBoxSDmov.Name = "rdoHDtoLetterBoxSDmov"
        Me.rdoHDtoLetterBoxSDmov.Size = New System.Drawing.Size(125, 17)
        Me.rdoHDtoLetterBoxSDmov.TabIndex = 796
        Me.rdoHDtoLetterBoxSDmov.Text = "HD to  Letter Box DV"
        Me.rdoHDtoLetterBoxSDmov.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(187, 239)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(70, 13)
        Me.Label33.TabIndex = 790
        Me.Label33.Text = "BitRate mbps"
        '
        'ntranscodeinmp4bitrate
        '
        Me.ntranscodeinmp4bitrate.Location = New System.Drawing.Point(261, 236)
        Me.ntranscodeinmp4bitrate.Minimum = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.ntranscodeinmp4bitrate.Name = "ntranscodeinmp4bitrate"
        Me.ntranscodeinmp4bitrate.Size = New System.Drawing.Size(50, 20)
        Me.ntranscodeinmp4bitrate.TabIndex = 795
        Me.ntranscodeinmp4bitrate.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmbformatforhdtocentercutdv
        '
        Me.cmbformatforhdtocentercutdv.FormattingEnabled = True
        Me.cmbformatforhdtocentercutdv.Items.AddRange(New Object() {"vcd", "dvd", "dvcpro", "dvcpro50", "dvcprohd", "imx30", "imx50", "xdcamhd422"})
        Me.cmbformatforhdtocentercutdv.Location = New System.Drawing.Point(142, 310)
        Me.cmbformatforhdtocentercutdv.Name = "cmbformatforhdtocentercutdv"
        Me.cmbformatforhdtocentercutdv.Size = New System.Drawing.Size(101, 21)
        Me.cmbformatforhdtocentercutdv.TabIndex = 794
        Me.cmbformatforhdtocentercutdv.Text = "dvcpro50"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(245, 314)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 793
        Me.Label10.Text = "Extension"
        '
        'cmbextensionhdtocentercutdv
        '
        Me.cmbextensionhdtocentercutdv.FormattingEnabled = True
        Me.cmbextensionhdtocentercutdv.Items.AddRange(New Object() {".avi", ".mp4", ".ogg", ".mxf", ".mov", ".mkv", ".mpg", ".mts", ".dv"})
        Me.cmbextensionhdtocentercutdv.Location = New System.Drawing.Point(299, 312)
        Me.cmbextensionhdtocentercutdv.Name = "cmbextensionhdtocentercutdv"
        Me.cmbextensionhdtocentercutdv.Size = New System.Drawing.Size(56, 21)
        Me.cmbextensionhdtocentercutdv.TabIndex = 792
        Me.cmbextensionhdtocentercutdv.Text = ".mov"
        '
        'cmbformatedvcpro50
        '
        Me.cmbformatedvcpro50.FormattingEnabled = True
        Me.cmbformatedvcpro50.Items.AddRange(New Object() {"vcd", "dvd", "dvcpro", "dvcpro50", "dvcprohd", "imx30", "imx50", "xdcamhd422"})
        Me.cmbformatedvcpro50.Location = New System.Drawing.Point(142, 385)
        Me.cmbformatedvcpro50.Name = "cmbformatedvcpro50"
        Me.cmbformatedvcpro50.Size = New System.Drawing.Size(101, 21)
        Me.cmbformatedvcpro50.TabIndex = 791
        Me.cmbformatedvcpro50.Text = "dvcpro50"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 390)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 790
        Me.Label3.Text = "Extension"
        '
        'cmbextensiondvcpro50
        '
        Me.cmbextensiondvcpro50.FormattingEnabled = True
        Me.cmbextensiondvcpro50.Items.AddRange(New Object() {".avi", ".mp4", ".ogg", ".mxf", ".mov", ".mkv", ".mpg", ".mts", ".dv"})
        Me.cmbextensiondvcpro50.Location = New System.Drawing.Point(299, 386)
        Me.cmbextensiondvcpro50.Name = "cmbextensiondvcpro50"
        Me.cmbextensiondvcpro50.Size = New System.Drawing.Size(56, 21)
        Me.cmbextensiondvcpro50.TabIndex = 789
        Me.cmbextensiondvcpro50.Text = ".mov"
        '
        'rdodvcpro50dv
        '
        Me.rdodvcpro50dv.AutoSize = True
        Me.rdodvcpro50dv.Location = New System.Drawing.Point(9, 385)
        Me.rdodvcpro50dv.Name = "rdodvcpro50dv"
        Me.rdodvcpro50dv.Size = New System.Drawing.Size(70, 17)
        Me.rdodvcpro50dv.TabIndex = 783
        Me.rdodvcpro50dv.Text = "SD to DV"
        Me.rdodvcpro50dv.UseVisualStyleBackColor = True
        '
        'rdoHDtoCenterCutSDmov
        '
        Me.rdoHDtoCenterCutSDmov.AutoSize = True
        Me.rdoHDtoCenterCutSDmov.Location = New System.Drawing.Point(8, 313)
        Me.rdoHDtoCenterCutSDmov.Name = "rdoHDtoCenterCutSDmov"
        Me.rdoHDtoCenterCutSDmov.Size = New System.Drawing.Size(127, 17)
        Me.rdoHDtoCenterCutSDmov.TabIndex = 782
        Me.rdoHDtoCenterCutSDmov.Text = "HD to  Center Cut DV"
        Me.rdoHDtoCenterCutSDmov.UseVisualStyleBackColor = True
        '
        'rdoNX5CameraMTSHDtoCenterCutSDmpg
        '
        Me.rdoNX5CameraMTSHDtoCenterCutSDmpg.AutoSize = True
        Me.rdoNX5CameraMTSHDtoCenterCutSDmpg.Location = New System.Drawing.Point(8, 288)
        Me.rdoNX5CameraMTSHDtoCenterCutSDmpg.Name = "rdoNX5CameraMTSHDtoCenterCutSDmpg"
        Me.rdoNX5CameraMTSHDtoCenterCutSDmpg.Size = New System.Drawing.Size(236, 17)
        Me.rdoNX5CameraMTSHDtoCenterCutSDmpg.TabIndex = 781
        Me.rdoNX5CameraMTSHDtoCenterCutSDmpg.Text = "NX5 Camera MTS HD to Center Cut SD mpg"
        Me.rdoNX5CameraMTSHDtoCenterCutSDmpg.UseVisualStyleBackColor = True
        '
        'rdoTrancodemp4
        '
        Me.rdoTrancodemp4.AutoSize = True
        Me.rdoTrancodemp4.Location = New System.Drawing.Point(8, 235)
        Me.rdoTrancodemp4.Name = "rdoTrancodemp4"
        Me.rdoTrancodemp4.Size = New System.Drawing.Size(138, 17)
        Me.rdoTrancodemp4.TabIndex = 780
        Me.rdoTrancodemp4.Text = "Trancode in mp4   h264"
        Me.rdoTrancodemp4.UseVisualStyleBackColor = True
        '
        'rdoCustomTranscode
        '
        Me.rdoCustomTranscode.AutoSize = True
        Me.rdoCustomTranscode.Checked = True
        Me.rdoCustomTranscode.Location = New System.Drawing.Point(10, 562)
        Me.rdoCustomTranscode.Name = "rdoCustomTranscode"
        Me.rdoCustomTranscode.Size = New System.Drawing.Size(114, 17)
        Me.rdoCustomTranscode.TabIndex = 779
        Me.rdoCustomTranscode.TabStop = True
        Me.rdoCustomTranscode.Text = "Custom Transcode"
        Me.rdoCustomTranscode.UseVisualStyleBackColor = True
        '
        'rdoHDtoXDCAMHD422mxfwithFFMBC
        '
        Me.rdoHDtoXDCAMHD422mxfwithFFMBC.AutoSize = True
        Me.rdoHDtoXDCAMHD422mxfwithFFMBC.Location = New System.Drawing.Point(8, 213)
        Me.rdoHDtoXDCAMHD422mxfwithFFMBC.Name = "rdoHDtoXDCAMHD422mxfwithFFMBC"
        Me.rdoHDtoXDCAMHD422mxfwithFFMBC.Size = New System.Drawing.Size(210, 17)
        Me.rdoHDtoXDCAMHD422mxfwithFFMBC.TabIndex = 778
        Me.rdoHDtoXDCAMHD422mxfwithFFMBC.Text = "HD to XDCAM HD422 with FFMBC mxf"
        Me.rdoHDtoXDCAMHD422mxfwithFFMBC.UseVisualStyleBackColor = True
        '
        'rdoHD1920x1080tosdCenterCutmxf
        '
        Me.rdoHD1920x1080tosdCenterCutmxf.AutoSize = True
        Me.rdoHD1920x1080tosdCenterCutmxf.Location = New System.Drawing.Point(8, 193)
        Me.rdoHD1920x1080tosdCenterCutmxf.Name = "rdoHD1920x1080tosdCenterCutmxf"
        Me.rdoHD1920x1080tosdCenterCutmxf.Size = New System.Drawing.Size(195, 17)
        Me.rdoHD1920x1080tosdCenterCutmxf.TabIndex = 777
        Me.rdoHD1920x1080tosdCenterCutmxf.Text = "HD 1920x1080 to sd Center Cut mxf"
        Me.rdoHD1920x1080tosdCenterCutmxf.UseVisualStyleBackColor = True
        '
        'rdoSDtoXDcamHD422Mxf
        '
        Me.rdoSDtoXDcamHD422Mxf.AutoSize = True
        Me.rdoSDtoXDcamHD422Mxf.Location = New System.Drawing.Point(8, 18)
        Me.rdoSDtoXDcamHD422Mxf.Name = "rdoSDtoXDcamHD422Mxf"
        Me.rdoSDtoXDcamHD422Mxf.Size = New System.Drawing.Size(242, 17)
        Me.rdoSDtoXDcamHD422Mxf.TabIndex = 774
        Me.rdoSDtoXDcamHD422Mxf.Text = "SD to pillar box XDCAM HD 422 50i PAL MXF"
        Me.rdoSDtoXDcamHD422Mxf.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmbextensioncustom)
        Me.GroupBox2.Controls.Add(Me.txtoptionstrimmercustom)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 601)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 150)
        Me.GroupBox2.TabIndex = 783
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Custom Trancoding options"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdocustomtranscodeffmbc)
        Me.GroupBox4.Controls.Add(Me.rdocustomtranscodeffmpeg)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(128, 28)
        Me.GroupBox4.TabIndex = 789
        Me.GroupBox4.TabStop = False
        '
        'rdocustomtranscodeffmbc
        '
        Me.rdocustomtranscodeffmbc.AutoSize = True
        Me.rdocustomtranscodeffmbc.Location = New System.Drawing.Point(71, 9)
        Me.rdocustomtranscodeffmbc.Name = "rdocustomtranscodeffmbc"
        Me.rdocustomtranscodeffmbc.Size = New System.Drawing.Size(51, 17)
        Me.rdocustomtranscodeffmbc.TabIndex = 796
        Me.rdocustomtranscodeffmbc.Text = "ffmbc"
        Me.rdocustomtranscodeffmbc.UseVisualStyleBackColor = True
        '
        'rdocustomtranscodeffmpeg
        '
        Me.rdocustomtranscodeffmpeg.AutoSize = True
        Me.rdocustomtranscodeffmpeg.Checked = True
        Me.rdocustomtranscodeffmpeg.Location = New System.Drawing.Point(3, 9)
        Me.rdocustomtranscodeffmpeg.Name = "rdocustomtranscodeffmpeg"
        Me.rdocustomtranscodeffmpeg.Size = New System.Drawing.Size(57, 17)
        Me.rdocustomtranscodeffmpeg.TabIndex = 795
        Me.rdocustomtranscodeffmpeg.TabStop = True
        Me.rdocustomtranscodeffmpeg.Text = "ffmpeg"
        Me.rdocustomtranscodeffmpeg.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(241, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 788
        Me.Label9.Text = "Extension"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(159, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 784
        Me.Label5.Text = "Commands"
        '
        'cmbextensioncustom
        '
        Me.cmbextensioncustom.FormattingEnabled = True
        Me.cmbextensioncustom.Items.AddRange(New Object() {".avi", ".mp4", ".ogg", ".mxf", ".mov", ".mkv", ".mpg", ".mts", ".dv"})
        Me.cmbextensioncustom.Location = New System.Drawing.Point(300, 11)
        Me.cmbextensioncustom.Name = "cmbextensioncustom"
        Me.cmbextensioncustom.Size = New System.Drawing.Size(56, 21)
        Me.cmbextensioncustom.TabIndex = 782
        Me.cmbextensioncustom.Text = ".mxf"
        '
        'txtoptionstrimmercustom
        '
        Me.txtoptionstrimmercustom.Location = New System.Drawing.Point(9, 46)
        Me.txtoptionstrimmercustom.Multiline = True
        Me.txtoptionstrimmercustom.Name = "txtoptionstrimmercustom"
        Me.txtoptionstrimmercustom.Size = New System.Drawing.Size(347, 98)
        Me.txtoptionstrimmercustom.TabIndex = 768
        Me.txtoptionstrimmercustom.Text = " -vcodec mpeg2video -acodec pcm_s24le -r 25 -s 1920x1080 -ar 48000 -b:v 50000k -a" &
    "lternate_scan 1"
        '
        'ckkUseSuffix
        '
        Me.ckkUseSuffix.AutoSize = True
        Me.ckkUseSuffix.Checked = True
        Me.ckkUseSuffix.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckkUseSuffix.Location = New System.Drawing.Point(218, 769)
        Me.ckkUseSuffix.Name = "ckkUseSuffix"
        Me.ckkUseSuffix.Size = New System.Drawing.Size(116, 17)
        Me.ckkUseSuffix.TabIndex = 815
        Me.ckkUseSuffix.Text = "Use Suffix in Name"
        Me.ckkUseSuffix.UseVisualStyleBackColor = True
        '
        'ucTranscodingProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "ucTranscodingProfile"
        Me.Size = New System.Drawing.Size(387, 803)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nborderwidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vlcLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nlogoheightforexport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nlogowidthforexport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nlogoyposition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nlogoxposition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ntranscodeinmp4bitratehevc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ntranscodeinmp4bitrate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbformatforhdtoLetterBoxdv As ComboBox
    Friend WithEvents Label34 As Label
    Friend WithEvents cmbextensionhdtoLetterBoxdv As ComboBox
    Friend WithEvents rdoHDtoLetterBoxSDmov As RadioButton
    Friend WithEvents Label33 As Label
    Friend WithEvents ntranscodeinmp4bitrate As NumericUpDown
    Friend WithEvents cmbformatforhdtocentercutdv As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbextensionhdtocentercutdv As ComboBox
    Friend WithEvents cmbformatedvcpro50 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbextensiondvcpro50 As ComboBox
    Friend WithEvents rdodvcpro50dv As RadioButton
    Friend WithEvents rdoHDtoCenterCutSDmov As RadioButton
    Friend WithEvents rdoNX5CameraMTSHDtoCenterCutSDmpg As RadioButton
    Friend WithEvents rdoTrancodemp4 As RadioButton
    Friend WithEvents rdoCustomTranscode As RadioButton
    Friend WithEvents rdoHDtoXDCAMHD422mxfwithFFMBC As RadioButton
    Friend WithEvents rdoHD1920x1080tosdCenterCutmxf As RadioButton
    Friend WithEvents rdoSDtoXDcamHD422Mxf As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rdocustomtranscodeffmbc As RadioButton
    Friend WithEvents rdocustomtranscodeffmpeg As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbextensioncustom As ComboBox
    Friend WithEvents txtoptionstrimmercustom As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtnumberofprocessors As TextBox
    Friend WithEvents lblnumberofprocessors As Label
    Friend WithEvents cmbformatforhdtoAnamorphicdv As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbextensionhdtoAnamprphicdv As ComboBox
    Friend WithEvents rdoHDtoAnamorphicmov As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents ntranscodeinmp4bitratehevc As NumericUpDown
    Friend WithEvents rdoTrancodemp4hevc As RadioButton
    Friend WithEvents rdoCodecBased As RadioButton
    Friend WithEvents cmbbitrate5 As ComboBox
    Friend WithEvents cmbaudiocodec5 As ComboBox
    Friend WithEvents cmbvideocodec5 As ComboBox
    Friend WithEvents nlogoheightforexport As NumericUpDown
    Friend WithEvents nlogowidthforexport As NumericUpDown
    Friend WithEvents nlogoyposition As NumericUpDown
    Friend WithEvents nlogoxposition As NumericUpDown
    Friend WithEvents rdoTranscodeWithLogo As RadioButton
    Friend WithEvents Label251 As Label
    Friend WithEvents Label252 As Label
    Friend WithEvents Label253 As Label
    Friend WithEvents Label254 As Label
    Friend WithEvents cmbbitrate As ComboBox
    Friend WithEvents cmbaudiocodec As ComboBox
    Friend WithEvents cmbvideocodec As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbextensioncodecbased As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbextension5 As ComboBox
    Friend WithEvents txtFPS As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents rdoanytoAnamorphicXDcamHD422Mxf As RadioButton
    Friend WithEvents cmdOpenLogo As Button
    Friend WithEvents vlcLogo As Vlc.DotNet.Forms.VlcControl
    Friend WithEvents rdoSDtoSDoverBlurVideo As RadioButton
    Friend WithEvents nborderwidth As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdBorderColor As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBoxSize As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTotalSize As TextBox
    Friend WithEvents rdoHDblacktoHDoverBlurVideo As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents txtExtraCrop As TextBox
    Friend WithEvents ckkUseSuffix As CheckBox
End Class
