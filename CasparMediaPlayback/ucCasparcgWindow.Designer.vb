<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucCasparcgWindow
    Inherits System.Windows.Forms.UserControl

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucCasparcgWindow))
        Me.gbcasparcgwindow = New System.Windows.Forms.GroupBox()
        Me.lblMasterVolume = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mdResetAudio = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbAudioControl = New System.Windows.Forms.GroupBox()
        Me.tbAudioConytrol = New System.Windows.Forms.TrackBar()
        Me.cmbcasparcgwindowtitle = New System.Windows.Forms.ComboBox()
        Me.gbplayer = New System.Windows.Forms.GroupBox()
        Me.cmdFastFarward = New System.Windows.Forms.Button()
        Me.cmdFastReverse = New System.Windows.Forms.Button()
        Me.cmdGoToEnd = New System.Windows.Forms.Button()
        Me.cmdnextplay = New System.Windows.Forms.Button()
        Me.cmdcuenext = New System.Windows.Forms.Button()
        Me.cmdstop = New System.Windows.Forms.Button()
        Me.cmdresume = New System.Windows.Forms.Button()
        Me.cmdforwardoneframe = New System.Windows.Forms.Button()
        Me.cmdPlaySingleClip = New System.Windows.Forms.Button()
        Me.cmdbackoneframe = New System.Windows.Forms.Button()
        Me.cmdcueclip = New System.Windows.Forms.Button()
        Me.cmdplayfroInToOut = New System.Windows.Forms.Button()
        Me.cmdplaylast5seccasaprcgwindow = New System.Windows.Forms.Button()
        Me.txtforwardsecond = New System.Windows.Forms.TextBox()
        Me.txtgototccasparcgwindow = New System.Windows.Forms.TextBox()
        Me.cmdgototccasparcgwindow = New System.Windows.Forms.Button()
        Me.cmdplayfromin = New System.Windows.Forms.Button()
        Me.lblhmsf = New System.Windows.Forms.Label()
        Me.lblcurrentframe = New System.Windows.Forms.Label()
        Me.cmdgotoout = New System.Windows.Forms.Button()
        Me.cmdgotoin = New System.Windows.Forms.Button()
        Me.cmdmarkout = New System.Windows.Forms.Button()
        Me.cmdmarkin = New System.Windows.Forms.Button()
        Me.txtmarkout = New System.Windows.Forms.TextBox()
        Me.txtmarkin = New System.Windows.Forms.TextBox()
        Me.lblmin = New System.Windows.Forms.Label()
        Me.lblmax = New System.Windows.Forms.Label()
        Me.TrackBarseek = New System.Windows.Forms.TrackBar()
        Me.picaudiometer = New System.Windows.Forms.PictureBox()
        Me.chkaspectratio = New System.Windows.Forms.CheckBox()
        Me.lblplaying = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New VerticalProgressBar.VerticalProgressBar()
        Me.ProgressBar1 = New VerticalProgressBar.VerticalProgressBar()
        Me.cmdoutcasparcgwindow = New System.Windows.Forms.Button()
        Me.cmdshowcasparcgwindow = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tmrpreview = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmraudio = New System.Windows.Forms.Timer(Me.components)
        Me.gbcasparcgwindow.SuspendLayout()
        Me.gbAudioControl.SuspendLayout()
        CType(Me.tbAudioConytrol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbplayer.SuspendLayout()
        CType(Me.TrackBarseek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picaudiometer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbcasparcgwindow
        '
        Me.gbcasparcgwindow.BackColor = System.Drawing.Color.SkyBlue
        Me.gbcasparcgwindow.Controls.Add(Me.lblMasterVolume)
        Me.gbcasparcgwindow.Controls.Add(Me.Label5)
        Me.gbcasparcgwindow.Controls.Add(Me.Label4)
        Me.gbcasparcgwindow.Controls.Add(Me.mdResetAudio)
        Me.gbcasparcgwindow.Controls.Add(Me.Label3)
        Me.gbcasparcgwindow.Controls.Add(Me.Label2)
        Me.gbcasparcgwindow.Controls.Add(Me.Label1)
        Me.gbcasparcgwindow.Controls.Add(Me.gbAudioControl)
        Me.gbcasparcgwindow.Controls.Add(Me.cmbcasparcgwindowtitle)
        Me.gbcasparcgwindow.Controls.Add(Me.gbplayer)
        Me.gbcasparcgwindow.Controls.Add(Me.picaudiometer)
        Me.gbcasparcgwindow.Controls.Add(Me.chkaspectratio)
        Me.gbcasparcgwindow.Controls.Add(Me.lblplaying)
        Me.gbcasparcgwindow.Controls.Add(Me.Label27)
        Me.gbcasparcgwindow.Controls.Add(Me.ProgressBar2)
        Me.gbcasparcgwindow.Controls.Add(Me.ProgressBar1)
        Me.gbcasparcgwindow.Controls.Add(Me.cmdoutcasparcgwindow)
        Me.gbcasparcgwindow.Controls.Add(Me.cmdshowcasparcgwindow)
        Me.gbcasparcgwindow.Controls.Add(Me.Panel1)
        Me.gbcasparcgwindow.Location = New System.Drawing.Point(3, 4)
        Me.gbcasparcgwindow.Name = "gbcasparcgwindow"
        Me.gbcasparcgwindow.Size = New System.Drawing.Size(682, 609)
        Me.gbcasparcgwindow.TabIndex = 432
        Me.gbcasparcgwindow.TabStop = False
        Me.gbcasparcgwindow.Text = "Casparcg Window"
        '
        'lblMasterVolume
        '
        Me.lblMasterVolume.AutoSize = True
        Me.lblMasterVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMasterVolume.Location = New System.Drawing.Point(0, 506)
        Me.lblMasterVolume.Name = "lblMasterVolume"
        Me.lblMasterVolume.Size = New System.Drawing.Size(21, 12)
        Me.lblMasterVolume.TabIndex = 1181
        Me.lblMasterVolume.Text = "1.0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-2, 539)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 9)
        Me.Label5.TabIndex = 1180
        Me.Label5.Text = "3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-1, 557)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 9)
        Me.Label4.TabIndex = 1179
        Me.Label4.Text = "2"
        '
        'mdResetAudio
        '
        Me.mdResetAudio.Location = New System.Drawing.Point(26, 502)
        Me.mdResetAudio.Name = "mdResetAudio"
        Me.mdResetAudio.Size = New System.Drawing.Size(18, 18)
        Me.mdResetAudio.TabIndex = 1178
        Me.mdResetAudio.Text = "1"
        Me.mdResetAudio.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-1, 597)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 9)
        Me.Label3.TabIndex = 1173
        Me.Label3.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-1, 577)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 9)
        Me.Label2.TabIndex = 1172
        Me.Label2.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 524)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 9)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "4"
        '
        'gbAudioControl
        '
        Me.gbAudioControl.BackColor = System.Drawing.SystemColors.Control
        Me.gbAudioControl.Controls.Add(Me.tbAudioConytrol)
        Me.gbAudioControl.Location = New System.Drawing.Point(11, 524)
        Me.gbAudioControl.Name = "gbAudioControl"
        Me.gbAudioControl.Size = New System.Drawing.Size(27, 81)
        Me.gbAudioControl.TabIndex = 1171
        Me.gbAudioControl.TabStop = False
        '
        'tbAudioConytrol
        '
        Me.tbAudioConytrol.BackColor = System.Drawing.SystemColors.Control
        Me.tbAudioConytrol.Location = New System.Drawing.Point(5, -12)
        Me.tbAudioConytrol.Margin = New System.Windows.Forms.Padding(0)
        Me.tbAudioConytrol.Maximum = 400
        Me.tbAudioConytrol.Name = "tbAudioConytrol"
        Me.tbAudioConytrol.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudioConytrol.Size = New System.Drawing.Size(45, 102)
        Me.tbAudioConytrol.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.tbAudioConytrol, "Master Volume")
        Me.tbAudioConytrol.Value = 100
        '
        'cmbcasparcgwindowtitle
        '
        Me.cmbcasparcgwindowtitle.FormattingEnabled = True
        Me.cmbcasparcgwindowtitle.Location = New System.Drawing.Point(50, 11)
        Me.cmbcasparcgwindowtitle.Name = "cmbcasparcgwindowtitle"
        Me.cmbcasparcgwindowtitle.Size = New System.Drawing.Size(164, 21)
        Me.cmbcasparcgwindowtitle.TabIndex = 727
        Me.cmbcasparcgwindowtitle.Text = "Screen consumer [1|1080i5000]"
        '
        'gbplayer
        '
        Me.gbplayer.Controls.Add(Me.cmdFastFarward)
        Me.gbplayer.Controls.Add(Me.cmdFastReverse)
        Me.gbplayer.Controls.Add(Me.cmdGoToEnd)
        Me.gbplayer.Controls.Add(Me.cmdnextplay)
        Me.gbplayer.Controls.Add(Me.cmdcuenext)
        Me.gbplayer.Controls.Add(Me.cmdstop)
        Me.gbplayer.Controls.Add(Me.cmdresume)
        Me.gbplayer.Controls.Add(Me.cmdforwardoneframe)
        Me.gbplayer.Controls.Add(Me.cmdPlaySingleClip)
        Me.gbplayer.Controls.Add(Me.cmdbackoneframe)
        Me.gbplayer.Controls.Add(Me.cmdcueclip)
        Me.gbplayer.Controls.Add(Me.cmdplayfroInToOut)
        Me.gbplayer.Controls.Add(Me.cmdplaylast5seccasaprcgwindow)
        Me.gbplayer.Controls.Add(Me.txtforwardsecond)
        Me.gbplayer.Controls.Add(Me.txtgototccasparcgwindow)
        Me.gbplayer.Controls.Add(Me.cmdgototccasparcgwindow)
        Me.gbplayer.Controls.Add(Me.cmdplayfromin)
        Me.gbplayer.Controls.Add(Me.lblhmsf)
        Me.gbplayer.Controls.Add(Me.lblcurrentframe)
        Me.gbplayer.Controls.Add(Me.cmdgotoout)
        Me.gbplayer.Controls.Add(Me.cmdgotoin)
        Me.gbplayer.Controls.Add(Me.cmdmarkout)
        Me.gbplayer.Controls.Add(Me.cmdmarkin)
        Me.gbplayer.Controls.Add(Me.txtmarkout)
        Me.gbplayer.Controls.Add(Me.txtmarkin)
        Me.gbplayer.Controls.Add(Me.lblmin)
        Me.gbplayer.Controls.Add(Me.lblmax)
        Me.gbplayer.Controls.Add(Me.TrackBarseek)
        Me.gbplayer.Location = New System.Drawing.Point(44, 488)
        Me.gbplayer.Name = "gbplayer"
        Me.gbplayer.Size = New System.Drawing.Size(602, 120)
        Me.gbplayer.TabIndex = 366
        Me.gbplayer.TabStop = False
        '
        'cmdFastFarward
        '
        Me.cmdFastFarward.Image = Global.caspar_media_playback.My.Resources.Resources.ff
        Me.cmdFastFarward.Location = New System.Drawing.Point(406, 91)
        Me.cmdFastFarward.Name = "cmdFastFarward"
        Me.cmdFastFarward.Size = New System.Drawing.Size(40, 23)
        Me.cmdFastFarward.TabIndex = 1329
        Me.ToolTip1.SetToolTip(Me.cmdFastFarward, "Fast Farward")
        Me.cmdFastFarward.UseVisualStyleBackColor = True
        '
        'cmdFastReverse
        '
        Me.cmdFastReverse.Image = Global.caspar_media_playback.My.Resources.Resources.fr
        Me.cmdFastReverse.Location = New System.Drawing.Point(341, 91)
        Me.cmdFastReverse.Name = "cmdFastReverse"
        Me.cmdFastReverse.Size = New System.Drawing.Size(37, 23)
        Me.cmdFastReverse.TabIndex = 1328
        Me.ToolTip1.SetToolTip(Me.cmdFastReverse, "fast Rewind")
        Me.cmdFastReverse.UseVisualStyleBackColor = True
        '
        'cmdGoToEnd
        '
        Me.cmdGoToEnd.Image = Global.caspar_media_playback.My.Resources.Resources.Untitled1
        Me.cmdGoToEnd.Location = New System.Drawing.Point(463, 60)
        Me.cmdGoToEnd.Name = "cmdGoToEnd"
        Me.cmdGoToEnd.Size = New System.Drawing.Size(36, 23)
        Me.cmdGoToEnd.TabIndex = 1188
        Me.ToolTip1.SetToolTip(Me.cmdGoToEnd, "Go To last Frame")
        Me.cmdGoToEnd.UseVisualStyleBackColor = True
        '
        'cmdnextplay
        '
        Me.cmdnextplay.Image = CType(resources.GetObject("cmdnextplay.Image"), System.Drawing.Image)
        Me.cmdnextplay.Location = New System.Drawing.Point(419, 60)
        Me.cmdnextplay.Name = "cmdnextplay"
        Me.cmdnextplay.Size = New System.Drawing.Size(36, 23)
        Me.cmdnextplay.TabIndex = 1187
        Me.ToolTip1.SetToolTip(Me.cmdnextplay, "Play Next")
        Me.cmdnextplay.UseVisualStyleBackColor = True
        '
        'cmdcuenext
        '
        Me.cmdcuenext.Image = CType(resources.GetObject("cmdcuenext.Image"), System.Drawing.Image)
        Me.cmdcuenext.Location = New System.Drawing.Point(373, 60)
        Me.cmdcuenext.Name = "cmdcuenext"
        Me.cmdcuenext.Size = New System.Drawing.Size(36, 23)
        Me.cmdcuenext.TabIndex = 1186
        Me.ToolTip1.SetToolTip(Me.cmdcuenext, "Cue Next")
        Me.cmdcuenext.UseVisualStyleBackColor = True
        '
        'cmdstop
        '
        Me.cmdstop.Image = CType(resources.GetObject("cmdstop.Image"), System.Drawing.Image)
        Me.cmdstop.Location = New System.Drawing.Point(331, 60)
        Me.cmdstop.Name = "cmdstop"
        Me.cmdstop.Size = New System.Drawing.Size(36, 23)
        Me.cmdstop.TabIndex = 1185
        Me.ToolTip1.SetToolTip(Me.cmdstop, "Stop")
        Me.cmdstop.UseVisualStyleBackColor = True
        '
        'cmdresume
        '
        Me.cmdresume.Image = CType(resources.GetObject("cmdresume.Image"), System.Drawing.Image)
        Me.cmdresume.Location = New System.Drawing.Point(282, 60)
        Me.cmdresume.Name = "cmdresume"
        Me.cmdresume.Size = New System.Drawing.Size(36, 23)
        Me.cmdresume.TabIndex = 1184
        Me.ToolTip1.SetToolTip(Me.cmdresume, "Resume")
        Me.cmdresume.UseVisualStyleBackColor = True
        '
        'cmdforwardoneframe
        '
        Me.cmdforwardoneframe.Image = CType(resources.GetObject("cmdforwardoneframe.Image"), System.Drawing.Image)
        Me.cmdforwardoneframe.Location = New System.Drawing.Point(236, 60)
        Me.cmdforwardoneframe.Name = "cmdforwardoneframe"
        Me.cmdforwardoneframe.Size = New System.Drawing.Size(36, 23)
        Me.cmdforwardoneframe.TabIndex = 1183
        Me.ToolTip1.SetToolTip(Me.cmdforwardoneframe, "1 Frame Forward")
        Me.cmdforwardoneframe.UseVisualStyleBackColor = True
        '
        'cmdPlaySingleClip
        '
        Me.cmdPlaySingleClip.Image = CType(resources.GetObject("cmdPlaySingleClip.Image"), System.Drawing.Image)
        Me.cmdPlaySingleClip.Location = New System.Drawing.Point(189, 60)
        Me.cmdPlaySingleClip.Name = "cmdPlaySingleClip"
        Me.cmdPlaySingleClip.Size = New System.Drawing.Size(36, 23)
        Me.cmdPlaySingleClip.TabIndex = 1182
        Me.cmdPlaySingleClip.Text = "0"
        Me.ToolTip1.SetToolTip(Me.cmdPlaySingleClip, "Play From Start")
        Me.cmdPlaySingleClip.UseVisualStyleBackColor = True
        '
        'cmdbackoneframe
        '
        Me.cmdbackoneframe.Image = CType(resources.GetObject("cmdbackoneframe.Image"), System.Drawing.Image)
        Me.cmdbackoneframe.Location = New System.Drawing.Point(141, 60)
        Me.cmdbackoneframe.Name = "cmdbackoneframe"
        Me.cmdbackoneframe.Size = New System.Drawing.Size(36, 23)
        Me.cmdbackoneframe.TabIndex = 1181
        Me.ToolTip1.SetToolTip(Me.cmdbackoneframe, "1 Frame Back")
        Me.cmdbackoneframe.UseVisualStyleBackColor = True
        '
        'cmdcueclip
        '
        Me.cmdcueclip.Image = CType(resources.GetObject("cmdcueclip.Image"), System.Drawing.Image)
        Me.cmdcueclip.Location = New System.Drawing.Point(97, 60)
        Me.cmdcueclip.Name = "cmdcueclip"
        Me.cmdcueclip.Size = New System.Drawing.Size(36, 23)
        Me.cmdcueclip.TabIndex = 1180
        Me.ToolTip1.SetToolTip(Me.cmdcueclip, "Cue (Go to 1st Frame)")
        Me.cmdcueclip.UseVisualStyleBackColor = True
        '
        'cmdplayfroInToOut
        '
        Me.cmdplayfroInToOut.Location = New System.Drawing.Point(124, 91)
        Me.cmdplayfroInToOut.Name = "cmdplayfroInToOut"
        Me.cmdplayfroInToOut.Size = New System.Drawing.Size(91, 23)
        Me.cmdplayfroInToOut.TabIndex = 1173
        Me.cmdplayfroInToOut.Text = "Play In To Out"
        Me.ToolTip1.SetToolTip(Me.cmdplayfroInToOut, "Play From In To Out")
        Me.cmdplayfroInToOut.UseVisualStyleBackColor = True
        '
        'cmdplaylast5seccasaprcgwindow
        '
        Me.cmdplaylast5seccasaprcgwindow.Location = New System.Drawing.Point(443, 90)
        Me.cmdplaylast5seccasaprcgwindow.Name = "cmdplaylast5seccasaprcgwindow"
        Me.cmdplaylast5seccasaprcgwindow.Size = New System.Drawing.Size(89, 26)
        Me.cmdplaylast5seccasaprcgwindow.TabIndex = 1175
        Me.cmdplaylast5seccasaprcgwindow.Text = "Play Last 5 Sec"
        Me.cmdplaylast5seccasaprcgwindow.UseVisualStyleBackColor = True
        '
        'txtforwardsecond
        '
        Me.txtforwardsecond.Location = New System.Drawing.Point(378, 93)
        Me.txtforwardsecond.Name = "txtforwardsecond"
        Me.txtforwardsecond.Size = New System.Drawing.Size(26, 20)
        Me.txtforwardsecond.TabIndex = 1177
        Me.txtforwardsecond.Text = "5"
        Me.txtforwardsecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtgototccasparcgwindow
        '
        Me.txtgototccasparcgwindow.Location = New System.Drawing.Point(274, 92)
        Me.txtgototccasparcgwindow.Name = "txtgototccasparcgwindow"
        Me.txtgototccasparcgwindow.Size = New System.Drawing.Size(66, 20)
        Me.txtgototccasparcgwindow.TabIndex = 1172
        Me.txtgototccasparcgwindow.Text = "00:02:00:00"
        '
        'cmdgototccasparcgwindow
        '
        Me.cmdgototccasparcgwindow.Location = New System.Drawing.Point(215, 90)
        Me.cmdgototccasparcgwindow.Name = "cmdgototccasparcgwindow"
        Me.cmdgototccasparcgwindow.Size = New System.Drawing.Size(60, 23)
        Me.cmdgototccasparcgwindow.TabIndex = 1171
        Me.cmdgototccasparcgwindow.Text = "GoTo TC"
        Me.cmdgototccasparcgwindow.UseVisualStyleBackColor = True
        '
        'cmdplayfromin
        '
        Me.cmdplayfromin.Location = New System.Drawing.Point(54, 90)
        Me.cmdplayfromin.Name = "cmdplayfromin"
        Me.cmdplayfromin.Size = New System.Drawing.Size(70, 23)
        Me.cmdplayfromin.TabIndex = 1172
        Me.cmdplayfromin.Text = "Play from In"
        Me.cmdplayfromin.UseVisualStyleBackColor = True
        '
        'lblhmsf
        '
        Me.lblhmsf.AutoSize = True
        Me.lblhmsf.BackColor = System.Drawing.Color.Yellow
        Me.lblhmsf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhmsf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblhmsf.Location = New System.Drawing.Point(255, 9)
        Me.lblhmsf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblhmsf.Name = "lblhmsf"
        Me.lblhmsf.Size = New System.Drawing.Size(67, 13)
        Me.lblhmsf.TabIndex = 637
        Me.lblhmsf.Text = "Time Code"
        '
        'lblcurrentframe
        '
        Me.lblcurrentframe.AutoSize = True
        Me.lblcurrentframe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcurrentframe.Location = New System.Drawing.Point(298, 49)
        Me.lblcurrentframe.Name = "lblcurrentframe"
        Me.lblcurrentframe.Size = New System.Drawing.Size(10, 13)
        Me.lblcurrentframe.TabIndex = 352
        Me.lblcurrentframe.Text = "."
        Me.lblcurrentframe.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdgotoout
        '
        Me.cmdgotoout.Location = New System.Drawing.Point(533, 92)
        Me.cmdgotoout.Name = "cmdgotoout"
        Me.cmdgotoout.Size = New System.Drawing.Size(67, 23)
        Me.cmdgotoout.TabIndex = 349
        Me.cmdgotoout.Text = "Go to OUT"
        Me.cmdgotoout.UseVisualStyleBackColor = True
        '
        'cmdgotoin
        '
        Me.cmdgotoin.Location = New System.Drawing.Point(0, 91)
        Me.cmdgotoin.Name = "cmdgotoin"
        Me.cmdgotoin.Size = New System.Drawing.Size(55, 23)
        Me.cmdgotoin.TabIndex = 348
        Me.cmdgotoin.Text = "Go to IN"
        Me.cmdgotoin.UseVisualStyleBackColor = True
        '
        'cmdmarkout
        '
        Me.cmdmarkout.Location = New System.Drawing.Point(549, 62)
        Me.cmdmarkout.Name = "cmdmarkout"
        Me.cmdmarkout.Size = New System.Drawing.Size(47, 28)
        Me.cmdmarkout.TabIndex = 347
        Me.cmdmarkout.Text = "Out"
        Me.cmdmarkout.UseVisualStyleBackColor = True
        '
        'cmdmarkin
        '
        Me.cmdmarkin.Location = New System.Drawing.Point(3, 62)
        Me.cmdmarkin.Name = "cmdmarkin"
        Me.cmdmarkin.Size = New System.Drawing.Size(37, 27)
        Me.cmdmarkin.TabIndex = 346
        Me.cmdmarkin.Text = "IN"
        Me.cmdmarkin.UseVisualStyleBackColor = True
        '
        'txtmarkout
        '
        Me.txtmarkout.Location = New System.Drawing.Point(503, 69)
        Me.txtmarkout.Name = "txtmarkout"
        Me.txtmarkout.Size = New System.Drawing.Size(43, 20)
        Me.txtmarkout.TabIndex = 345
        Me.txtmarkout.Text = "300"
        '
        'txtmarkin
        '
        Me.txtmarkin.Location = New System.Drawing.Point(43, 68)
        Me.txtmarkin.Name = "txtmarkin"
        Me.txtmarkin.Size = New System.Drawing.Size(48, 20)
        Me.txtmarkin.TabIndex = 344
        Me.txtmarkin.Text = "100"
        '
        'lblmin
        '
        Me.lblmin.AutoSize = True
        Me.lblmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmin.Location = New System.Drawing.Point(28, 49)
        Me.lblmin.Name = "lblmin"
        Me.lblmin.Size = New System.Drawing.Size(10, 13)
        Me.lblmin.TabIndex = 335
        Me.lblmin.Text = "."
        Me.lblmin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblmax
        '
        Me.lblmax.AutoSize = True
        Me.lblmax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmax.Location = New System.Drawing.Point(558, 51)
        Me.lblmax.Name = "lblmax"
        Me.lblmax.Size = New System.Drawing.Size(10, 13)
        Me.lblmax.TabIndex = 0
        Me.lblmax.Text = "."
        Me.lblmax.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TrackBarseek
        '
        Me.TrackBarseek.AutoSize = False
        Me.TrackBarseek.BackColor = System.Drawing.SystemColors.Control
        Me.TrackBarseek.LargeChange = 2
        Me.TrackBarseek.Location = New System.Drawing.Point(33, 17)
        Me.TrackBarseek.Maximum = 999999999
        Me.TrackBarseek.Name = "TrackBarseek"
        Me.TrackBarseek.Size = New System.Drawing.Size(530, 31)
        Me.TrackBarseek.TabIndex = 329
        Me.TrackBarseek.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'picaudiometer
        '
        Me.picaudiometer.Image = Global.caspar_media_playback.My.Resources.Resources.audiometer
        Me.picaudiometer.Location = New System.Drawing.Point(5, 41)
        Me.picaudiometer.Name = "picaudiometer"
        Me.picaudiometer.Size = New System.Drawing.Size(24, 459)
        Me.picaudiometer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picaudiometer.TabIndex = 1170
        Me.picaudiometer.TabStop = False
        '
        'chkaspectratio
        '
        Me.chkaspectratio.AutoSize = True
        Me.chkaspectratio.Checked = Global.caspar_media_playback.My.MySettings.Default.chkaspectratio
        Me.chkaspectratio.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.caspar_media_playback.My.MySettings.Default, "chkaspectratio", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkaspectratio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkaspectratio.Location = New System.Drawing.Point(4, 13)
        Me.chkaspectratio.Name = "chkaspectratio"
        Me.chkaspectratio.Size = New System.Drawing.Size(47, 17)
        Me.chkaspectratio.TabIndex = 365
        Me.chkaspectratio.Text = "16:9"
        Me.chkaspectratio.UseVisualStyleBackColor = True
        '
        'lblplaying
        '
        Me.lblplaying.AutoSize = True
        Me.lblplaying.Location = New System.Drawing.Point(338, 7)
        Me.lblplaying.MaximumSize = New System.Drawing.Size(340, 0)
        Me.lblplaying.Name = "lblplaying"
        Me.lblplaying.Size = New System.Drawing.Size(52, 13)
        Me.lblplaying.TabIndex = 364
        Me.lblplaying.Text = "File name"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Maroon
        Me.Label27.Location = New System.Drawing.Point(288, 6)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 13)
        Me.Label27.TabIndex = 363
        Me.Label27.Text = "Playing"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.BorderStyle = VerticalProgressBar.BorderStyles.Classic
        Me.ProgressBar2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressBar2.Location = New System.Drawing.Point(647, 43)
        Me.ProgressBar2.Maximum = 40
        Me.ProgressBar2.Minimum = 0
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(11, 439)
        Me.ProgressBar2.Step = 1
        Me.ProgressBar2.Style = VerticalProgressBar.Styles.Classic
        Me.ProgressBar2.TabIndex = 343
        Me.ProgressBar2.Value = 40
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BorderStyle = VerticalProgressBar.BorderStyles.Classic
        Me.ProgressBar1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(30, 41)
        Me.ProgressBar1.Maximum = 40
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(11, 439)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = VerticalProgressBar.Styles.Classic
        Me.ProgressBar1.TabIndex = 342
        Me.ProgressBar1.Value = 0
        '
        'cmdoutcasparcgwindow
        '
        Me.cmdoutcasparcgwindow.Location = New System.Drawing.Point(246, 8)
        Me.cmdoutcasparcgwindow.Name = "cmdoutcasparcgwindow"
        Me.cmdoutcasparcgwindow.Size = New System.Drawing.Size(44, 23)
        Me.cmdoutcasparcgwindow.TabIndex = 327
        Me.cmdoutcasparcgwindow.Text = "OUT"
        Me.cmdoutcasparcgwindow.UseVisualStyleBackColor = True
        '
        'cmdshowcasparcgwindow
        '
        Me.cmdshowcasparcgwindow.Location = New System.Drawing.Point(215, 8)
        Me.cmdshowcasparcgwindow.Name = "cmdshowcasparcgwindow"
        Me.cmdshowcasparcgwindow.Size = New System.Drawing.Size(32, 23)
        Me.cmdshowcasparcgwindow.TabIndex = 155
        Me.cmdshowcasparcgwindow.Text = "IN"
        Me.cmdshowcasparcgwindow.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(44, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 450)
        Me.Panel1.TabIndex = 156
        '
        'tmrpreview
        '
        Me.tmrpreview.Interval = 1000
        '
        'tmraudio
        '
        Me.tmraudio.Enabled = True
        '
        'ucCasparcgWindow
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.gbcasparcgwindow)
        Me.Name = "ucCasparcgWindow"
        Me.Size = New System.Drawing.Size(689, 617)
        Me.gbcasparcgwindow.ResumeLayout(False)
        Me.gbcasparcgwindow.PerformLayout()
        Me.gbAudioControl.ResumeLayout(False)
        Me.gbAudioControl.PerformLayout()
        CType(Me.tbAudioConytrol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbplayer.ResumeLayout(False)
        Me.gbplayer.PerformLayout()
        CType(Me.TrackBarseek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picaudiometer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbcasparcgwindow As System.Windows.Forms.GroupBox
    Friend WithEvents cmbcasparcgwindowtitle As System.Windows.Forms.ComboBox
    Friend WithEvents gbplayer As System.Windows.Forms.GroupBox
    Friend WithEvents txtforwardsecond As System.Windows.Forms.TextBox
    Friend WithEvents txtgototccasparcgwindow As System.Windows.Forms.TextBox
    Friend WithEvents cmdplayfroInToOut As System.Windows.Forms.Button
    Friend WithEvents cmdgototccasparcgwindow As System.Windows.Forms.Button
    Friend WithEvents cmdplayfromin As System.Windows.Forms.Button
    Friend WithEvents cmdplaylast5seccasaprcgwindow As System.Windows.Forms.Button
    Friend WithEvents lblhmsf As System.Windows.Forms.Label
    Friend WithEvents lblcurrentframe As System.Windows.Forms.Label
    Friend WithEvents cmdgotoout As System.Windows.Forms.Button
    Friend WithEvents cmdgotoin As System.Windows.Forms.Button
    Friend WithEvents cmdmarkout As System.Windows.Forms.Button
    Friend WithEvents cmdmarkin As System.Windows.Forms.Button
    Friend WithEvents txtmarkout As System.Windows.Forms.TextBox
    Friend WithEvents txtmarkin As System.Windows.Forms.TextBox
    Friend WithEvents lblmin As System.Windows.Forms.Label
    Friend WithEvents lblmax As System.Windows.Forms.Label
    Friend WithEvents TrackBarseek As System.Windows.Forms.TrackBar
    Friend WithEvents picaudiometer As System.Windows.Forms.PictureBox
    Friend WithEvents chkaspectratio As System.Windows.Forms.CheckBox
    Friend WithEvents lblplaying As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents ProgressBar1 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents cmdoutcasparcgwindow As System.Windows.Forms.Button
    Friend WithEvents cmdshowcasparcgwindow As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tmrpreview As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tbAudioConytrol As System.Windows.Forms.TrackBar
    Friend WithEvents gbAudioControl As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mdResetAudio As System.Windows.Forms.Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdcueclip As Button
    Friend WithEvents cmdbackoneframe As Button
    Friend WithEvents cmdPlaySingleClip As Button
    Friend WithEvents cmdforwardoneframe As Button
    Friend WithEvents cmdresume As Button
    Friend WithEvents cmdstop As Button
    Friend WithEvents cmdcuenext As Button
    Friend WithEvents cmdnextplay As Button
    Friend WithEvents cmdGoToEnd As Button
    Friend WithEvents cmdFastReverse As Button
    Friend WithEvents cmdFastFarward As Button
    Friend WithEvents tmraudio As Timer
    Friend WithEvents lblMasterVolume As Label
End Class
