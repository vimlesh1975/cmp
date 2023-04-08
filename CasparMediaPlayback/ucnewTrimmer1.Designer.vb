<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucnewTrimmer1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucnewTrimmer1))
        Me.gbTrimmer = New System.Windows.Forms.GroupBox()
        Me.vlc1 = New Vlc.DotNet.Forms.VlcControl()
        Me.cmdclosenewTrimmer1 = New System.Windows.Forms.Button()
        Me.cmdtrimmerfilePlayencoded = New System.Windows.Forms.Button()
        Me.cmdtrimmerfileinfoencoded = New System.Windows.Forms.Button()
        Me.cmdtrimmerfileinfo = New System.Windows.Forms.Button()
        Me.lblfilenametrimmer = New System.Windows.Forms.Label()
        Me.cmdopenfiletrimmer = New System.Windows.Forms.Button()
        Me.gbplayertrimmer = New System.Windows.Forms.GroupBox()
        Me.nforwardFrame = New System.Windows.Forms.NumericUpDown()
        Me.cmdbackTenframetrimmer = New System.Windows.Forms.Button()
        Me.cmdforwardtenframetrimmer = New System.Windows.Forms.Button()
        Me.cmdexportmpeg2mov = New System.Windows.Forms.Button()
        Me.lblexportclipinfo = New System.Windows.Forms.Label()
        Me.pbexportclip = New System.Windows.Forms.ProgressBar()
        Me.txtgototcvlc = New System.Windows.Forms.TextBox()
        Me.cmdgototcvlc = New System.Windows.Forms.Button()
        Me.nvlcspeed = New System.Windows.Forms.NumericUpDown()
        Me.cmdplaylast5sectrimmer = New System.Windows.Forms.Button()
        Me.cmdgotoendtrimmer = New System.Windows.Forms.Button()
        Me.lbltrimmedduration = New System.Windows.Forms.Label()
        Me.lbloriginalduration = New System.Windows.Forms.Label()
        Me.Label232 = New System.Windows.Forms.Label()
        Me.Label231 = New System.Windows.Forms.Label()
        Me.cmdexportclipwithoutanychanges = New System.Windows.Forms.Button()
        Me.cmdspeed1trimmer = New System.Windows.Forms.Button()
        Me.lblhmsftrimmer = New System.Windows.Forms.Label()
        Me.cmdforwardoneframetrimmer = New System.Windows.Forms.Button()
        Me.cmdbackoneframetrimmer = New System.Windows.Forms.Button()
        Me.lblcurrentframetrimmer = New System.Windows.Forms.Label()
        Me.cmdclipsavetrimmer = New System.Windows.Forms.Button()
        Me.cmdgotoouttrimmer = New System.Windows.Forms.Button()
        Me.cmdgotointrimmer = New System.Windows.Forms.Button()
        Me.cmdmarkouttrimmer = New System.Windows.Forms.Button()
        Me.cmdmarkintrimmer = New System.Windows.Forms.Button()
        Me.txtmarkouttrimmer = New System.Windows.Forms.TextBox()
        Me.txtmarkintrimmer = New System.Windows.Forms.TextBox()
        Me.lblmintrimmer = New System.Windows.Forms.Label()
        Me.lblmaxtrimmer = New System.Windows.Forms.Label()
        Me.cmdcuecliptrimmer = New System.Windows.Forms.Button()
        Me.cmdresumetrimmer = New System.Windows.Forms.Button()
        Me.cmdPlaySingleCliptrimmer = New System.Windows.Forms.Button()
        Me.cmdstoptrimmer = New System.Windows.Forms.Button()
        Me.TrackBarseektrimmer = New System.Windows.Forms.TrackBar()
        Me.bwforexportclip = New System.ComponentModel.BackgroundWorker()
        Me.tmrtrimmer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdExportOnlyAudio = New System.Windows.Forms.Button()
        Me.bwforexportclip1 = New System.ComponentModel.BackgroundWorker()
        Me.gbTrimmer.SuspendLayout()
        CType(Me.vlc1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbplayertrimmer.SuspendLayout()
        CType(Me.nforwardFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nvlcspeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarseektrimmer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbTrimmer
        '
        Me.gbTrimmer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbTrimmer.Controls.Add(Me.vlc1)
        Me.gbTrimmer.Controls.Add(Me.cmdclosenewTrimmer1)
        Me.gbTrimmer.Controls.Add(Me.cmdtrimmerfilePlayencoded)
        Me.gbTrimmer.Controls.Add(Me.cmdtrimmerfileinfoencoded)
        Me.gbTrimmer.Controls.Add(Me.cmdtrimmerfileinfo)
        Me.gbTrimmer.Controls.Add(Me.lblfilenametrimmer)
        Me.gbTrimmer.Controls.Add(Me.cmdopenfiletrimmer)
        Me.gbTrimmer.Controls.Add(Me.gbplayertrimmer)
        Me.gbTrimmer.Location = New System.Drawing.Point(2, 3)
        Me.gbTrimmer.Name = "gbTrimmer"
        Me.gbTrimmer.Size = New System.Drawing.Size(478, 517)
        Me.gbTrimmer.TabIndex = 1166
        Me.gbTrimmer.TabStop = False
        Me.gbTrimmer.Text = "Trimmer"
        '
        'vlc1
        '
        Me.vlc1.BackColor = System.Drawing.Color.Black
        Me.vlc1.Location = New System.Drawing.Point(10, 54)
        Me.vlc1.Name = "vlc1"
        Me.vlc1.Size = New System.Drawing.Size(461, 264)
        Me.vlc1.Spu = -1
        Me.vlc1.TabIndex = 1198
        Me.vlc1.Text = "VlcControl1"
        Me.vlc1.VlcLibDirectory = CType(resources.GetObject("vlc1.VlcLibDirectory"), System.IO.DirectoryInfo)
        Me.vlc1.VlcMediaplayerOptions = Nothing
        '
        'cmdclosenewTrimmer1
        '
        Me.cmdclosenewTrimmer1.Image = CType(resources.GetObject("cmdclosenewTrimmer1.Image"), System.Drawing.Image)
        Me.cmdclosenewTrimmer1.Location = New System.Drawing.Point(446, 13)
        Me.cmdclosenewTrimmer1.Name = "cmdclosenewTrimmer1"
        Me.cmdclosenewTrimmer1.Size = New System.Drawing.Size(28, 27)
        Me.cmdclosenewTrimmer1.TabIndex = 1197
        Me.cmdclosenewTrimmer1.UseVisualStyleBackColor = True
        '
        'cmdtrimmerfilePlayencoded
        '
        Me.cmdtrimmerfilePlayencoded.Location = New System.Drawing.Point(307, 14)
        Me.cmdtrimmerfilePlayencoded.Name = "cmdtrimmerfilePlayencoded"
        Me.cmdtrimmerfilePlayencoded.Size = New System.Drawing.Size(116, 23)
        Me.cmdtrimmerfilePlayencoded.TabIndex = 773
        Me.cmdtrimmerfilePlayencoded.Text = "Play Trimmed File"
        Me.cmdtrimmerfilePlayencoded.UseVisualStyleBackColor = True
        '
        'cmdtrimmerfileinfoencoded
        '
        Me.cmdtrimmerfileinfoencoded.Location = New System.Drawing.Point(173, 14)
        Me.cmdtrimmerfileinfoencoded.Name = "cmdtrimmerfileinfoencoded"
        Me.cmdtrimmerfileinfoencoded.Size = New System.Drawing.Size(130, 23)
        Me.cmdtrimmerfileinfoencoded.TabIndex = 768
        Me.cmdtrimmerfileinfoencoded.Text = "Show Trimmed File Info"
        Me.cmdtrimmerfileinfoencoded.UseVisualStyleBackColor = True
        '
        'cmdtrimmerfileinfo
        '
        Me.cmdtrimmerfileinfo.Location = New System.Drawing.Point(79, 14)
        Me.cmdtrimmerfileinfo.Name = "cmdtrimmerfileinfo"
        Me.cmdtrimmerfileinfo.Size = New System.Drawing.Size(88, 23)
        Me.cmdtrimmerfileinfo.TabIndex = 767
        Me.cmdtrimmerfileinfo.Text = "Show File Info"
        Me.cmdtrimmerfileinfo.UseVisualStyleBackColor = True
        '
        'lblfilenametrimmer
        '
        Me.lblfilenametrimmer.AutoSize = True
        Me.lblfilenametrimmer.Location = New System.Drawing.Point(11, 38)
        Me.lblfilenametrimmer.Name = "lblfilenametrimmer"
        Me.lblfilenametrimmer.Size = New System.Drawing.Size(49, 13)
        Me.lblfilenametrimmer.TabIndex = 639
        Me.lblfilenametrimmer.Text = "Filename"
        '
        'cmdopenfiletrimmer
        '
        Me.cmdopenfiletrimmer.Location = New System.Drawing.Point(8, 14)
        Me.cmdopenfiletrimmer.Name = "cmdopenfiletrimmer"
        Me.cmdopenfiletrimmer.Size = New System.Drawing.Size(68, 23)
        Me.cmdopenfiletrimmer.TabIndex = 638
        Me.cmdopenfiletrimmer.Text = "Open File"
        Me.cmdopenfiletrimmer.UseVisualStyleBackColor = True
        '
        'gbplayertrimmer
        '
        Me.gbplayertrimmer.Controls.Add(Me.cmdExportOnlyAudio)
        Me.gbplayertrimmer.Controls.Add(Me.nforwardFrame)
        Me.gbplayertrimmer.Controls.Add(Me.cmdbackTenframetrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.cmdforwardtenframetrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.cmdexportmpeg2mov)
        Me.gbplayertrimmer.Controls.Add(Me.lblexportclipinfo)
        Me.gbplayertrimmer.Controls.Add(Me.pbexportclip)
        Me.gbplayertrimmer.Controls.Add(Me.txtgototcvlc)
        Me.gbplayertrimmer.Controls.Add(Me.cmdgototcvlc)
        Me.gbplayertrimmer.Controls.Add(Me.nvlcspeed)
        Me.gbplayertrimmer.Controls.Add(Me.cmdplaylast5sectrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.cmdgotoendtrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.lbltrimmedduration)
        Me.gbplayertrimmer.Controls.Add(Me.lbloriginalduration)
        Me.gbplayertrimmer.Controls.Add(Me.Label232)
        Me.gbplayertrimmer.Controls.Add(Me.Label231)
        Me.gbplayertrimmer.Controls.Add(Me.cmdexportclipwithoutanychanges)
        Me.gbplayertrimmer.Controls.Add(Me.cmdspeed1trimmer)
        Me.gbplayertrimmer.Controls.Add(Me.lblhmsftrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.cmdforwardoneframetrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.cmdbackoneframetrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.lblcurrentframetrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.cmdclipsavetrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.cmdgotoouttrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.cmdgotointrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.cmdmarkouttrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.cmdmarkintrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.txtmarkouttrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.txtmarkintrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.lblmintrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.lblmaxtrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.cmdcuecliptrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.cmdresumetrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.cmdPlaySingleCliptrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.cmdstoptrimmer)
        Me.gbplayertrimmer.Controls.Add(Me.TrackBarseektrimmer)
        Me.gbplayertrimmer.Location = New System.Drawing.Point(7, 312)
        Me.gbplayertrimmer.Name = "gbplayertrimmer"
        Me.gbplayertrimmer.Size = New System.Drawing.Size(463, 209)
        Me.gbplayertrimmer.TabIndex = 367
        Me.gbplayertrimmer.TabStop = False
        '
        'nforwardFrame
        '
        Me.nforwardFrame.Location = New System.Drawing.Point(168, 90)
        Me.nforwardFrame.Name = "nforwardFrame"
        Me.nforwardFrame.Size = New System.Drawing.Size(44, 20)
        Me.nforwardFrame.TabIndex = 1333
        Me.ToolTip1.SetToolTip(Me.nforwardFrame, "No of Frames")
        Me.nforwardFrame.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'cmdbackTenframetrimmer
        '
        Me.cmdbackTenframetrimmer.Image = CType(resources.GetObject("cmdbackTenframetrimmer.Image"), System.Drawing.Image)
        Me.cmdbackTenframetrimmer.Location = New System.Drawing.Point(134, 89)
        Me.cmdbackTenframetrimmer.Name = "cmdbackTenframetrimmer"
        Me.cmdbackTenframetrimmer.Size = New System.Drawing.Size(31, 23)
        Me.cmdbackTenframetrimmer.TabIndex = 1332
        Me.ToolTip1.SetToolTip(Me.cmdbackTenframetrimmer, "10 Frame Back")
        Me.cmdbackTenframetrimmer.UseVisualStyleBackColor = True
        '
        'cmdforwardtenframetrimmer
        '
        Me.cmdforwardtenframetrimmer.Image = CType(resources.GetObject("cmdforwardtenframetrimmer.Image"), System.Drawing.Image)
        Me.cmdforwardtenframetrimmer.Location = New System.Drawing.Point(216, 89)
        Me.cmdforwardtenframetrimmer.Name = "cmdforwardtenframetrimmer"
        Me.cmdforwardtenframetrimmer.Size = New System.Drawing.Size(35, 23)
        Me.cmdforwardtenframetrimmer.TabIndex = 1331
        Me.ToolTip1.SetToolTip(Me.cmdforwardtenframetrimmer, "10 Frame Forward")
        Me.cmdforwardtenframetrimmer.UseVisualStyleBackColor = True
        '
        'cmdexportmpeg2mov
        '
        Me.cmdexportmpeg2mov.Location = New System.Drawing.Point(300, 179)
        Me.cmdexportmpeg2mov.Name = "cmdexportmpeg2mov"
        Me.cmdexportmpeg2mov.Size = New System.Drawing.Size(166, 23)
        Me.cmdexportmpeg2mov.TabIndex = 737
        Me.cmdexportmpeg2mov.Text = "Export MPeg2 for Oasys Server"
        Me.cmdexportmpeg2mov.UseVisualStyleBackColor = True
        '
        'lblexportclipinfo
        '
        Me.lblexportclipinfo.AutoSize = True
        Me.lblexportclipinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexportclipinfo.Location = New System.Drawing.Point(154, 139)
        Me.lblexportclipinfo.Name = "lblexportclipinfo"
        Me.lblexportclipinfo.Size = New System.Drawing.Size(37, 13)
        Me.lblexportclipinfo.TabIndex = 736
        Me.lblexportclipinfo.Text = "Status"
        Me.lblexportclipinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbexportclip
        '
        Me.pbexportclip.Location = New System.Drawing.Point(147, 119)
        Me.pbexportclip.Maximum = 268
        Me.pbexportclip.Name = "pbexportclip"
        Me.pbexportclip.Size = New System.Drawing.Size(136, 19)
        Me.pbexportclip.TabIndex = 735
        '
        'txtgototcvlc
        '
        Me.txtgototcvlc.Location = New System.Drawing.Point(73, 146)
        Me.txtgototcvlc.Name = "txtgototcvlc"
        Me.txtgototcvlc.Size = New System.Drawing.Size(70, 20)
        Me.txtgototcvlc.TabIndex = 732
        Me.txtgototcvlc.Text = "00:02:00:00"
        '
        'cmdgototcvlc
        '
        Me.cmdgototcvlc.Location = New System.Drawing.Point(6, 145)
        Me.cmdgototcvlc.Name = "cmdgototcvlc"
        Me.cmdgototcvlc.Size = New System.Drawing.Size(60, 23)
        Me.cmdgototcvlc.TabIndex = 731
        Me.cmdgototcvlc.Text = "GoTo TC"
        Me.cmdgototcvlc.UseVisualStyleBackColor = True
        '
        'nvlcspeed
        '
        Me.nvlcspeed.DecimalPlaces = 1
        Me.nvlcspeed.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nvlcspeed.Location = New System.Drawing.Point(157, 173)
        Me.nvlcspeed.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nvlcspeed.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.nvlcspeed.Name = "nvlcspeed"
        Me.nvlcspeed.Size = New System.Drawing.Size(38, 20)
        Me.nvlcspeed.TabIndex = 730
        Me.nvlcspeed.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmdplaylast5sectrimmer
        '
        Me.cmdplaylast5sectrimmer.Location = New System.Drawing.Point(285, 116)
        Me.cmdplaylast5sectrimmer.Name = "cmdplaylast5sectrimmer"
        Me.cmdplaylast5sectrimmer.Size = New System.Drawing.Size(96, 23)
        Me.cmdplaylast5sectrimmer.TabIndex = 729
        Me.cmdplaylast5sectrimmer.Text = "Play Last 5 Sec"
        Me.cmdplaylast5sectrimmer.UseVisualStyleBackColor = True
        '
        'cmdgotoendtrimmer
        '
        Me.cmdgotoendtrimmer.Image = Global.caspar_media_playback.My.Resources.Resources.GoToLastFrame
        Me.cmdgotoendtrimmer.Location = New System.Drawing.Point(326, 54)
        Me.cmdgotoendtrimmer.Name = "cmdgotoendtrimmer"
        Me.cmdgotoendtrimmer.Size = New System.Drawing.Size(37, 31)
        Me.cmdgotoendtrimmer.TabIndex = 728
        Me.ToolTip1.SetToolTip(Me.cmdgotoendtrimmer, "Go To last Frame")
        Me.cmdgotoendtrimmer.UseVisualStyleBackColor = True
        '
        'lbltrimmedduration
        '
        Me.lbltrimmedduration.AutoSize = True
        Me.lbltrimmedduration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltrimmedduration.ForeColor = System.Drawing.Color.Maroon
        Me.lbltrimmedduration.Location = New System.Drawing.Point(336, 160)
        Me.lbltrimmedduration.Name = "lbltrimmedduration"
        Me.lbltrimmedduration.Size = New System.Drawing.Size(131, 16)
        Me.lbltrimmedduration.TabIndex = 727
        Me.lbltrimmedduration.Text = "Trimmed Duration"
        '
        'lbloriginalduration
        '
        Me.lbloriginalduration.AutoSize = True
        Me.lbloriginalduration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloriginalduration.ForeColor = System.Drawing.Color.Maroon
        Me.lbloriginalduration.Location = New System.Drawing.Point(336, 141)
        Me.lbloriginalduration.Name = "lbloriginalduration"
        Me.lbloriginalduration.Size = New System.Drawing.Size(124, 16)
        Me.lbloriginalduration.TabIndex = 726
        Me.lbloriginalduration.Text = "Original Duration"
        '
        'Label232
        '
        Me.Label232.AutoSize = True
        Me.Label232.Location = New System.Drawing.Point(253, 159)
        Me.Label232.Name = "Label232"
        Me.Label232.Size = New System.Drawing.Size(90, 13)
        Me.Label232.TabIndex = 725
        Me.Label232.Text = "Trimmed Duration"
        '
        'Label231
        '
        Me.Label231.AutoSize = True
        Me.Label231.Location = New System.Drawing.Point(257, 141)
        Me.Label231.Name = "Label231"
        Me.Label231.Size = New System.Drawing.Size(85, 13)
        Me.Label231.TabIndex = 724
        Me.Label231.Text = "Original Duration"
        '
        'cmdexportclipwithoutanychanges
        '
        Me.cmdexportclipwithoutanychanges.Location = New System.Drawing.Point(74, 117)
        Me.cmdexportclipwithoutanychanges.Name = "cmdexportclipwithoutanychanges"
        Me.cmdexportclipwithoutanychanges.Size = New System.Drawing.Size(70, 23)
        Me.cmdexportclipwithoutanychanges.TabIndex = 723
        Me.cmdexportclipwithoutanychanges.Text = "Export Clip"
        Me.cmdexportclipwithoutanychanges.UseVisualStyleBackColor = True
        '
        'cmdspeed1trimmer
        '
        Me.cmdspeed1trimmer.Location = New System.Drawing.Point(96, 172)
        Me.cmdspeed1trimmer.Name = "cmdspeed1trimmer"
        Me.cmdspeed1trimmer.Size = New System.Drawing.Size(57, 23)
        Me.cmdspeed1trimmer.TabIndex = 638
        Me.cmdspeed1trimmer.Text = "Speed 1"
        Me.cmdspeed1trimmer.UseVisualStyleBackColor = True
        '
        'lblhmsftrimmer
        '
        Me.lblhmsftrimmer.AutoSize = True
        Me.lblhmsftrimmer.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblhmsftrimmer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhmsftrimmer.ForeColor = System.Drawing.SystemColors.Control
        Me.lblhmsftrimmer.Location = New System.Drawing.Point(190, 9)
        Me.lblhmsftrimmer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblhmsftrimmer.Name = "lblhmsftrimmer"
        Me.lblhmsftrimmer.Size = New System.Drawing.Size(67, 13)
        Me.lblhmsftrimmer.TabIndex = 637
        Me.lblhmsftrimmer.Text = "Time Code"
        '
        'cmdforwardoneframetrimmer
        '
        Me.cmdforwardoneframetrimmer.Image = CType(resources.GetObject("cmdforwardoneframetrimmer.Image"), System.Drawing.Image)
        Me.cmdforwardoneframetrimmer.Location = New System.Drawing.Point(204, 63)
        Me.cmdforwardoneframetrimmer.Name = "cmdforwardoneframetrimmer"
        Me.cmdforwardoneframetrimmer.Size = New System.Drawing.Size(35, 23)
        Me.cmdforwardoneframetrimmer.TabIndex = 354
        Me.ToolTip1.SetToolTip(Me.cmdforwardoneframetrimmer, "1 Frame Forward")
        Me.cmdforwardoneframetrimmer.UseVisualStyleBackColor = True
        '
        'cmdbackoneframetrimmer
        '
        Me.cmdbackoneframetrimmer.Image = CType(resources.GetObject("cmdbackoneframetrimmer.Image"), System.Drawing.Image)
        Me.cmdbackoneframetrimmer.Location = New System.Drawing.Point(142, 63)
        Me.cmdbackoneframetrimmer.Name = "cmdbackoneframetrimmer"
        Me.cmdbackoneframetrimmer.Size = New System.Drawing.Size(31, 23)
        Me.cmdbackoneframetrimmer.TabIndex = 353
        Me.ToolTip1.SetToolTip(Me.cmdbackoneframetrimmer, "1 Frame Back")
        Me.cmdbackoneframetrimmer.UseVisualStyleBackColor = True
        '
        'lblcurrentframetrimmer
        '
        Me.lblcurrentframetrimmer.AutoSize = True
        Me.lblcurrentframetrimmer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcurrentframetrimmer.Location = New System.Drawing.Point(190, 49)
        Me.lblcurrentframetrimmer.Name = "lblcurrentframetrimmer"
        Me.lblcurrentframetrimmer.Size = New System.Drawing.Size(76, 13)
        Me.lblcurrentframetrimmer.TabIndex = 352
        Me.lblcurrentframetrimmer.Text = "lblcurrentframe"
        Me.lblcurrentframetrimmer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdclipsavetrimmer
        '
        Me.cmdclipsavetrimmer.Location = New System.Drawing.Point(5, 172)
        Me.cmdclipsavetrimmer.Name = "cmdclipsavetrimmer"
        Me.cmdclipsavetrimmer.Size = New System.Drawing.Size(84, 23)
        Me.cmdclipsavetrimmer.TabIndex = 350
        Me.cmdclipsavetrimmer.Text = "Save Sub Clip"
        Me.cmdclipsavetrimmer.UseVisualStyleBackColor = True
        '
        'cmdgotoouttrimmer
        '
        Me.cmdgotoouttrimmer.Location = New System.Drawing.Point(384, 116)
        Me.cmdgotoouttrimmer.Name = "cmdgotoouttrimmer"
        Me.cmdgotoouttrimmer.Size = New System.Drawing.Size(74, 23)
        Me.cmdgotoouttrimmer.TabIndex = 349
        Me.cmdgotoouttrimmer.Text = "GOTO OUT"
        Me.cmdgotoouttrimmer.UseVisualStyleBackColor = True
        '
        'cmdgotointrimmer
        '
        Me.cmdgotointrimmer.Location = New System.Drawing.Point(6, 116)
        Me.cmdgotointrimmer.Name = "cmdgotointrimmer"
        Me.cmdgotointrimmer.Size = New System.Drawing.Size(60, 23)
        Me.cmdgotointrimmer.TabIndex = 348
        Me.cmdgotointrimmer.Text = "GOTO IN"
        Me.cmdgotointrimmer.UseVisualStyleBackColor = True
        '
        'cmdmarkouttrimmer
        '
        Me.cmdmarkouttrimmer.Location = New System.Drawing.Point(413, 65)
        Me.cmdmarkouttrimmer.Name = "cmdmarkouttrimmer"
        Me.cmdmarkouttrimmer.Size = New System.Drawing.Size(47, 23)
        Me.cmdmarkouttrimmer.TabIndex = 347
        Me.cmdmarkouttrimmer.Text = "Out"
        Me.cmdmarkouttrimmer.UseVisualStyleBackColor = True
        '
        'cmdmarkintrimmer
        '
        Me.cmdmarkintrimmer.Location = New System.Drawing.Point(6, 65)
        Me.cmdmarkintrimmer.Name = "cmdmarkintrimmer"
        Me.cmdmarkintrimmer.Size = New System.Drawing.Size(37, 23)
        Me.cmdmarkintrimmer.TabIndex = 346
        Me.cmdmarkintrimmer.Text = "IN"
        Me.cmdmarkintrimmer.UseVisualStyleBackColor = True
        '
        'txtmarkouttrimmer
        '
        Me.txtmarkouttrimmer.Location = New System.Drawing.Point(369, 65)
        Me.txtmarkouttrimmer.Name = "txtmarkouttrimmer"
        Me.txtmarkouttrimmer.Size = New System.Drawing.Size(41, 20)
        Me.txtmarkouttrimmer.TabIndex = 345
        Me.txtmarkouttrimmer.Text = "200"
        '
        'txtmarkintrimmer
        '
        Me.txtmarkintrimmer.Location = New System.Drawing.Point(53, 65)
        Me.txtmarkintrimmer.Name = "txtmarkintrimmer"
        Me.txtmarkintrimmer.Size = New System.Drawing.Size(47, 20)
        Me.txtmarkintrimmer.TabIndex = 344
        Me.txtmarkintrimmer.Text = "0"
        '
        'lblmintrimmer
        '
        Me.lblmintrimmer.AutoSize = True
        Me.lblmintrimmer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmintrimmer.Location = New System.Drawing.Point(16, 49)
        Me.lblmintrimmer.Name = "lblmintrimmer"
        Me.lblmintrimmer.Size = New System.Drawing.Size(33, 13)
        Me.lblmintrimmer.TabIndex = 335
        Me.lblmintrimmer.Text = "lblmin"
        Me.lblmintrimmer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblmaxtrimmer
        '
        Me.lblmaxtrimmer.AutoSize = True
        Me.lblmaxtrimmer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmaxtrimmer.Location = New System.Drawing.Point(410, 49)
        Me.lblmaxtrimmer.Name = "lblmaxtrimmer"
        Me.lblmaxtrimmer.Size = New System.Drawing.Size(36, 13)
        Me.lblmaxtrimmer.TabIndex = 0
        Me.lblmaxtrimmer.Text = "lblmax"
        Me.lblmaxtrimmer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdcuecliptrimmer
        '
        Me.cmdcuecliptrimmer.Image = Global.caspar_media_playback.My.Resources.Resources.GotToFirstFrame
        Me.cmdcuecliptrimmer.Location = New System.Drawing.Point(102, 54)
        Me.cmdcuecliptrimmer.Name = "cmdcuecliptrimmer"
        Me.cmdcuecliptrimmer.Size = New System.Drawing.Size(38, 32)
        Me.cmdcuecliptrimmer.TabIndex = 168
        Me.ToolTip1.SetToolTip(Me.cmdcuecliptrimmer, "Go To 1st Frame")
        Me.cmdcuecliptrimmer.UseVisualStyleBackColor = True
        '
        'cmdresumetrimmer
        '
        Me.cmdresumetrimmer.Image = CType(resources.GetObject("cmdresumetrimmer.Image"), System.Drawing.Image)
        Me.cmdresumetrimmer.Location = New System.Drawing.Point(240, 63)
        Me.cmdresumetrimmer.Name = "cmdresumetrimmer"
        Me.cmdresumetrimmer.Size = New System.Drawing.Size(48, 23)
        Me.cmdresumetrimmer.TabIndex = 160
        Me.ToolTip1.SetToolTip(Me.cmdresumetrimmer, "Pause / Resume")
        Me.cmdresumetrimmer.UseVisualStyleBackColor = True
        '
        'cmdPlaySingleCliptrimmer
        '
        Me.cmdPlaySingleCliptrimmer.Image = CType(resources.GetObject("cmdPlaySingleCliptrimmer.Image"), System.Drawing.Image)
        Me.cmdPlaySingleCliptrimmer.Location = New System.Drawing.Point(177, 63)
        Me.cmdPlaySingleCliptrimmer.Name = "cmdPlaySingleCliptrimmer"
        Me.cmdPlaySingleCliptrimmer.Size = New System.Drawing.Size(26, 23)
        Me.cmdPlaySingleCliptrimmer.TabIndex = 157
        Me.cmdPlaySingleCliptrimmer.Text = "0"
        Me.ToolTip1.SetToolTip(Me.cmdPlaySingleCliptrimmer, "Play")
        Me.cmdPlaySingleCliptrimmer.UseVisualStyleBackColor = True
        '
        'cmdstoptrimmer
        '
        Me.cmdstoptrimmer.Image = CType(resources.GetObject("cmdstoptrimmer.Image"), System.Drawing.Image)
        Me.cmdstoptrimmer.Location = New System.Drawing.Point(288, 63)
        Me.cmdstoptrimmer.Name = "cmdstoptrimmer"
        Me.cmdstoptrimmer.Size = New System.Drawing.Size(37, 23)
        Me.cmdstoptrimmer.TabIndex = 79
        Me.ToolTip1.SetToolTip(Me.cmdstoptrimmer, "Stop")
        Me.cmdstoptrimmer.UseVisualStyleBackColor = True
        '
        'TrackBarseektrimmer
        '
        Me.TrackBarseektrimmer.AutoSize = False
        Me.TrackBarseektrimmer.BackColor = System.Drawing.SystemColors.Control
        Me.TrackBarseektrimmer.LargeChange = 2
        Me.TrackBarseektrimmer.Location = New System.Drawing.Point(6, 17)
        Me.TrackBarseektrimmer.Maximum = 999999999
        Me.TrackBarseektrimmer.Name = "TrackBarseektrimmer"
        Me.TrackBarseektrimmer.Size = New System.Drawing.Size(457, 31)
        Me.TrackBarseektrimmer.TabIndex = 329
        Me.TrackBarseektrimmer.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'bwforexportclip
        '
        Me.bwforexportclip.WorkerSupportsCancellation = True
        '
        'tmrtrimmer
        '
        Me.tmrtrimmer.Interval = 10
        '
        'cmdExportOnlyAudio
        '
        Me.cmdExportOnlyAudio.Location = New System.Drawing.Point(198, 180)
        Me.cmdExportOnlyAudio.Name = "cmdExportOnlyAudio"
        Me.cmdExportOnlyAudio.Size = New System.Drawing.Size(102, 23)
        Me.cmdExportOnlyAudio.TabIndex = 1334
        Me.cmdExportOnlyAudio.Text = "Export only Audio"
        Me.cmdExportOnlyAudio.UseVisualStyleBackColor = True
        '
        'bwforexportclip1
        '
        Me.bwforexportclip1.WorkerSupportsCancellation = True
        '
        'ucnewTrimmer1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.gbTrimmer)
        Me.Name = "ucnewTrimmer1"
        Me.Size = New System.Drawing.Size(484, 523)
        Me.gbTrimmer.ResumeLayout(False)
        Me.gbTrimmer.PerformLayout()
        CType(Me.vlc1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbplayertrimmer.ResumeLayout(False)
        Me.gbplayertrimmer.PerformLayout()
        CType(Me.nforwardFrame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nvlcspeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarseektrimmer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbTrimmer As System.Windows.Forms.GroupBox
    Friend WithEvents cmdtrimmerfileinfo As System.Windows.Forms.Button
    Friend WithEvents lblfilenametrimmer As System.Windows.Forms.Label
    Friend WithEvents cmdopenfiletrimmer As System.Windows.Forms.Button
    Friend WithEvents gbplayertrimmer As System.Windows.Forms.GroupBox
    Friend WithEvents lblexportclipinfo As System.Windows.Forms.Label
    Friend WithEvents pbexportclip As System.Windows.Forms.ProgressBar
    Friend WithEvents txtgototcvlc As System.Windows.Forms.TextBox
    Friend WithEvents cmdgototcvlc As System.Windows.Forms.Button
    Friend WithEvents nvlcspeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdplaylast5sectrimmer As System.Windows.Forms.Button
    Friend WithEvents cmdgotoendtrimmer As System.Windows.Forms.Button
    Friend WithEvents lbltrimmedduration As System.Windows.Forms.Label
    Friend WithEvents lbloriginalduration As System.Windows.Forms.Label
    Friend WithEvents Label232 As System.Windows.Forms.Label
    Friend WithEvents Label231 As System.Windows.Forms.Label
    Friend WithEvents cmdexportclipwithoutanychanges As System.Windows.Forms.Button
    Friend WithEvents cmdspeed1trimmer As System.Windows.Forms.Button
    Friend WithEvents lblhmsftrimmer As System.Windows.Forms.Label
    Friend WithEvents cmdforwardoneframetrimmer As System.Windows.Forms.Button
    Friend WithEvents cmdbackoneframetrimmer As System.Windows.Forms.Button
    Friend WithEvents lblcurrentframetrimmer As System.Windows.Forms.Label
    Friend WithEvents cmdclipsavetrimmer As System.Windows.Forms.Button
    Friend WithEvents cmdgotoouttrimmer As System.Windows.Forms.Button
    Friend WithEvents cmdgotointrimmer As System.Windows.Forms.Button
    Friend WithEvents cmdmarkouttrimmer As System.Windows.Forms.Button
    Friend WithEvents cmdmarkintrimmer As System.Windows.Forms.Button
    Friend WithEvents txtmarkouttrimmer As System.Windows.Forms.TextBox
    Friend WithEvents txtmarkintrimmer As System.Windows.Forms.TextBox
    Friend WithEvents lblmintrimmer As System.Windows.Forms.Label
    Friend WithEvents lblmaxtrimmer As System.Windows.Forms.Label
    Friend WithEvents cmdcuecliptrimmer As System.Windows.Forms.Button
    Friend WithEvents cmdresumetrimmer As System.Windows.Forms.Button
    Friend WithEvents cmdPlaySingleCliptrimmer As System.Windows.Forms.Button
    Friend WithEvents cmdstoptrimmer As System.Windows.Forms.Button
    Friend WithEvents TrackBarseektrimmer As System.Windows.Forms.TrackBar
    Friend WithEvents bwforexportclip As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmrtrimmer As System.Windows.Forms.Timer
    Friend WithEvents cmdtrimmerfilePlayencoded As System.Windows.Forms.Button
    Friend WithEvents cmdtrimmerfileinfoencoded As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdclosenewTrimmer1 As Button
    Friend WithEvents cmdexportmpeg2mov As Button
    Friend WithEvents vlc1 As Vlc.DotNet.Forms.VlcControl
    Friend WithEvents cmdbackTenframetrimmer As Button
    Friend WithEvents cmdforwardtenframetrimmer As Button
    Friend WithEvents nforwardFrame As NumericUpDown
    Friend WithEvents cmdExportOnlyAudio As Button
    Friend WithEvents bwforexportclip1 As System.ComponentModel.BackgroundWorker
End Class
