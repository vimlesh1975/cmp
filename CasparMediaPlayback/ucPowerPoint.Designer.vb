<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPowerPoint
    'Inherits System.Windows.Forms.UserControl
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucPowerPoint))
        Me.gbPowerPoint = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.rdopng = New System.Windows.Forms.RadioButton()
        Me.rdojpg = New System.Windows.Forms.RadioButton()
        Me.cmdstoppowerpointoutput = New System.Windows.Forms.Button()
        Me.cmdstarPowerPointoutput = New System.Windows.Forms.Button()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.cmbdirectionforppt = New System.Windows.Forms.ComboBox()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.cmbtweentypeforppt = New System.Windows.Forms.ComboBox()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.ntransitiondurationforppt = New System.Windows.Forms.NumericUpDown()
        Me.cmbtransitionforppt = New System.Windows.Forms.ComboBox()
        Me.cmblayervideoforppt = New System.Windows.Forms.ComboBox()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.cmdoutexcelfromwindow = New System.Windows.Forms.Button()
        Me.cmdshowexcellinwindow = New System.Windows.Forms.Button()
        Me.cmdstartexcell = New System.Windows.Forms.Button()
        Me.cmdoutPowerPointwindow = New System.Windows.Forms.Button()
        Me.cmdshowpowerpointwindow = New System.Windows.Forms.Button()
        Me.cmdstartpowerpoint = New System.Windows.Forms.Button()
        Me.Panelpowerpoint = New System.Windows.Forms.Panel()
        Me.txtpowerpointreame = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbPowerPoint.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.ntransitiondurationforppt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelpowerpoint.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbPowerPoint
        '
        Me.gbPowerPoint.BackColor = System.Drawing.Color.Yellow
        Me.gbPowerPoint.Controls.Add(Me.GroupBox10)
        Me.gbPowerPoint.Controls.Add(Me.cmdstoppowerpointoutput)
        Me.gbPowerPoint.Controls.Add(Me.cmdstarPowerPointoutput)
        Me.gbPowerPoint.Controls.Add(Me.Label123)
        Me.gbPowerPoint.Controls.Add(Me.cmbdirectionforppt)
        Me.gbPowerPoint.Controls.Add(Me.Label124)
        Me.gbPowerPoint.Controls.Add(Me.cmbtweentypeforppt)
        Me.gbPowerPoint.Controls.Add(Me.Label125)
        Me.gbPowerPoint.Controls.Add(Me.Label126)
        Me.gbPowerPoint.Controls.Add(Me.ntransitiondurationforppt)
        Me.gbPowerPoint.Controls.Add(Me.cmbtransitionforppt)
        Me.gbPowerPoint.Controls.Add(Me.cmblayervideoforppt)
        Me.gbPowerPoint.Controls.Add(Me.Label107)
        Me.gbPowerPoint.Controls.Add(Me.cmdoutexcelfromwindow)
        Me.gbPowerPoint.Controls.Add(Me.cmdshowexcellinwindow)
        Me.gbPowerPoint.Controls.Add(Me.cmdstartexcell)
        Me.gbPowerPoint.Controls.Add(Me.cmdoutPowerPointwindow)
        Me.gbPowerPoint.Controls.Add(Me.cmdshowpowerpointwindow)
        Me.gbPowerPoint.Controls.Add(Me.cmdstartpowerpoint)
        Me.gbPowerPoint.Controls.Add(Me.Panelpowerpoint)
        Me.gbPowerPoint.Location = New System.Drawing.Point(3, 3)
        Me.gbPowerPoint.Name = "gbPowerPoint"
        Me.gbPowerPoint.Size = New System.Drawing.Size(1184, 874)
        Me.gbPowerPoint.TabIndex = 538
        Me.gbPowerPoint.TabStop = False
        Me.gbPowerPoint.Text = " "
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.rdopng)
        Me.GroupBox10.Controls.Add(Me.rdojpg)
        Me.GroupBox10.Location = New System.Drawing.Point(999, -1)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(63, 48)
        Me.GroupBox10.TabIndex = 716
        Me.GroupBox10.TabStop = False
        '
        'rdopng
        '
        Me.rdopng.AutoSize = True
        Me.rdopng.Location = New System.Drawing.Point(7, 25)
        Me.rdopng.Name = "rdopng"
        Me.rdopng.Size = New System.Drawing.Size(43, 17)
        Me.rdopng.TabIndex = 1
        Me.rdopng.TabStop = True
        Me.rdopng.Text = "png"
        Me.rdopng.UseVisualStyleBackColor = True
        '
        'rdojpg
        '
        Me.rdojpg.AutoSize = True
        Me.rdojpg.Checked = True
        Me.rdojpg.Location = New System.Drawing.Point(7, 7)
        Me.rdojpg.Name = "rdojpg"
        Me.rdojpg.Size = New System.Drawing.Size(39, 17)
        Me.rdojpg.TabIndex = 0
        Me.rdojpg.TabStop = True
        Me.rdojpg.Text = "jpg"
        Me.rdojpg.UseVisualStyleBackColor = True
        '
        'cmdstoppowerpointoutput
        '
        Me.cmdstoppowerpointoutput.BackColor = System.Drawing.Color.Red
        Me.cmdstoppowerpointoutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstoppowerpointoutput.ForeColor = System.Drawing.Color.White
        Me.cmdstoppowerpointoutput.Location = New System.Drawing.Point(1123, 12)
        Me.cmdstoppowerpointoutput.Name = "cmdstoppowerpointoutput"
        Me.cmdstoppowerpointoutput.Size = New System.Drawing.Size(53, 25)
        Me.cmdstoppowerpointoutput.TabIndex = 65
        Me.cmdstoppowerpointoutput.Text = "Stop"
        Me.cmdstoppowerpointoutput.UseVisualStyleBackColor = False
        '
        'cmdstarPowerPointoutput
        '
        Me.cmdstarPowerPointoutput.BackColor = System.Drawing.Color.Green
        Me.cmdstarPowerPointoutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstarPowerPointoutput.ForeColor = System.Drawing.Color.White
        Me.cmdstarPowerPointoutput.Location = New System.Drawing.Point(1068, 12)
        Me.cmdstarPowerPointoutput.Name = "cmdstarPowerPointoutput"
        Me.cmdstarPowerPointoutput.Size = New System.Drawing.Size(49, 25)
        Me.cmdstarPowerPointoutput.TabIndex = 66
        Me.cmdstarPowerPointoutput.Text = "Play"
        Me.cmdstarPowerPointoutput.UseVisualStyleBackColor = False
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Location = New System.Drawing.Point(887, 9)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(49, 13)
        Me.Label123.TabIndex = 618
        Me.Label123.Text = "Direction"
        '
        'cmbdirectionforppt
        '
        Me.cmbdirectionforppt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbdirectionforppt", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbdirectionforppt.FormattingEnabled = True
        Me.cmbdirectionforppt.Items.AddRange(New Object() {"LEFT", "RIGHT"})
        Me.cmbdirectionforppt.Location = New System.Drawing.Point(890, 25)
        Me.cmbdirectionforppt.Name = "cmbdirectionforppt"
        Me.cmbdirectionforppt.Size = New System.Drawing.Size(103, 21)
        Me.cmbdirectionforppt.TabIndex = 617
        Me.cmbdirectionforppt.Text = Global.caspar_media_playback.My.MySettings.Default.cmbdirectionforppt
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.Location = New System.Drawing.Point(753, 8)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(40, 13)
        Me.Label124.TabIndex = 616
        Me.Label124.Text = "Tween"
        '
        'cmbtweentypeforppt
        '
        Me.cmbtweentypeforppt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbtweentypeforppt", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbtweentypeforppt.FormattingEnabled = True
        Me.cmbtweentypeforppt.Items.AddRange(New Object() {"linear", "easenone", "easeinquad", "easeoutquad", "easeinoutquad", "easeoutinquad", "easeincubic", "easeoutcubic", "easeinoutcubic", "easeoutincubic", "easeinquart", "easeoutquart", "easeinoutquart", "easeoutinquart", "easeinquint", "easeoutquint", "easeinoutquint", "easeoutinquint", "easeinsine", "easeoutsine", "easeinoutsine", "easeoutinsine", "easeinexpo", "easeoutexpo", "easeinoutexpo", "easeoutinexpo", "easeincirc", "easeoutcirc", "easeinoutcirc", "easeoutincirc", "easeinelastic", "easeoutelastic", "easeinoutelastic", "easeoutinelastic", "easeinback", "easeoutback", "easeinoutback", "easeoutintback", "easeoutbounce", "easeinbounce", "easeinoutbounce", "easeoutinbounce"})
        Me.cmbtweentypeforppt.Location = New System.Drawing.Point(756, 23)
        Me.cmbtweentypeforppt.Name = "cmbtweentypeforppt"
        Me.cmbtweentypeforppt.Size = New System.Drawing.Size(103, 21)
        Me.cmbtweentypeforppt.TabIndex = 615
        Me.cmbtweentypeforppt.Text = Global.caspar_media_playback.My.MySettings.Default.cmbtweentypeforppt
        '
        'Label125
        '
        Me.Label125.AutoSize = True
        Me.Label125.Location = New System.Drawing.Point(640, 8)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(96, 13)
        Me.Label125.TabIndex = 614
        Me.Label125.Text = "Transition Duration"
        '
        'Label126
        '
        Me.Label126.AutoSize = True
        Me.Label126.Location = New System.Drawing.Point(530, 8)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(80, 13)
        Me.Label126.TabIndex = 613
        Me.Label126.Text = "Transition Type"
        '
        'ntransitiondurationforppt
        '
        Me.ntransitiondurationforppt.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.caspar_media_playback.My.MySettings.Default, "ntransitiondurationforppt", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ntransitiondurationforppt.Location = New System.Drawing.Point(644, 24)
        Me.ntransitiondurationforppt.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.ntransitiondurationforppt.Name = "ntransitiondurationforppt"
        Me.ntransitiondurationforppt.Size = New System.Drawing.Size(38, 20)
        Me.ntransitiondurationforppt.TabIndex = 611
        Me.ntransitiondurationforppt.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'cmbtransitionforppt
        '
        Me.cmbtransitionforppt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbtransitionforppt", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbtransitionforppt.FormattingEnabled = True
        Me.cmbtransitionforppt.Items.AddRange(New Object() {"CUT", "MIX", "PUSH", "WIPE", "SLIDE"})
        Me.cmbtransitionforppt.Location = New System.Drawing.Point(533, 26)
        Me.cmbtransitionforppt.Name = "cmbtransitionforppt"
        Me.cmbtransitionforppt.Size = New System.Drawing.Size(103, 21)
        Me.cmbtransitionforppt.TabIndex = 612
        Me.cmbtransitionforppt.Text = Global.caspar_media_playback.My.MySettings.Default.cmbtransitionforppt
        '
        'cmblayervideoforppt
        '
        Me.cmblayervideoforppt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmblayervideoforppt", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmblayervideoforppt.FormattingEnabled = True
        Me.cmblayervideoforppt.Items.AddRange(New Object() {"11", "12", "13", "14", "15"})
        Me.cmblayervideoforppt.Location = New System.Drawing.Point(479, 13)
        Me.cmblayervideoforppt.Name = "cmblayervideoforppt"
        Me.cmblayervideoforppt.Size = New System.Drawing.Size(38, 21)
        Me.cmblayervideoforppt.TabIndex = 610
        Me.cmblayervideoforppt.Text = "11"
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Location = New System.Drawing.Point(410, 16)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(63, 13)
        Me.Label107.TabIndex = 609
        Me.Label107.Text = "Video Layer"
        '
        'cmdoutexcelfromwindow
        '
        Me.cmdoutexcelfromwindow.Location = New System.Drawing.Point(358, 14)
        Me.cmdoutexcelfromwindow.Name = "cmdoutexcelfromwindow"
        Me.cmdoutexcelfromwindow.Size = New System.Drawing.Size(49, 23)
        Me.cmdoutexcelfromwindow.TabIndex = 335
        Me.cmdoutexcelfromwindow.Text = "OUT"
        Me.cmdoutexcelfromwindow.UseVisualStyleBackColor = True
        '
        'cmdshowexcellinwindow
        '
        Me.cmdshowexcellinwindow.Location = New System.Drawing.Point(317, 14)
        Me.cmdshowexcellinwindow.Name = "cmdshowexcellinwindow"
        Me.cmdshowexcellinwindow.Size = New System.Drawing.Size(35, 23)
        Me.cmdshowexcellinwindow.TabIndex = 334
        Me.cmdshowexcellinwindow.Text = "IN"
        Me.cmdshowexcellinwindow.UseVisualStyleBackColor = True
        '
        'cmdstartexcell
        '
        Me.cmdstartexcell.Location = New System.Drawing.Point(211, 14)
        Me.cmdstartexcell.Name = "cmdstartexcell"
        Me.cmdstartexcell.Size = New System.Drawing.Size(100, 24)
        Me.cmdstartexcell.TabIndex = 333
        Me.cmdstartexcell.Text = "Start Excel"
        Me.cmdstartexcell.UseVisualStyleBackColor = True
        '
        'cmdoutPowerPointwindow
        '
        Me.cmdoutPowerPointwindow.Location = New System.Drawing.Point(156, 14)
        Me.cmdoutPowerPointwindow.Name = "cmdoutPowerPointwindow"
        Me.cmdoutPowerPointwindow.Size = New System.Drawing.Size(49, 23)
        Me.cmdoutPowerPointwindow.TabIndex = 331
        Me.cmdoutPowerPointwindow.Text = "OUT"
        Me.cmdoutPowerPointwindow.UseVisualStyleBackColor = True
        '
        'cmdshowpowerpointwindow
        '
        Me.cmdshowpowerpointwindow.Location = New System.Drawing.Point(115, 14)
        Me.cmdshowpowerpointwindow.Name = "cmdshowpowerpointwindow"
        Me.cmdshowpowerpointwindow.Size = New System.Drawing.Size(35, 23)
        Me.cmdshowpowerpointwindow.TabIndex = 330
        Me.cmdshowpowerpointwindow.Text = "IN"
        Me.cmdshowpowerpointwindow.UseVisualStyleBackColor = True
        '
        'cmdstartpowerpoint
        '
        Me.cmdstartpowerpoint.Location = New System.Drawing.Point(9, 14)
        Me.cmdstartpowerpoint.Name = "cmdstartpowerpoint"
        Me.cmdstartpowerpoint.Size = New System.Drawing.Size(100, 24)
        Me.cmdstartpowerpoint.TabIndex = 332
        Me.cmdstartpowerpoint.Text = "Start PowerPoint"
        Me.cmdstartpowerpoint.UseVisualStyleBackColor = True
        '
        'Panelpowerpoint
        '
        Me.Panelpowerpoint.Controls.Add(Me.txtpowerpointreame)
        Me.Panelpowerpoint.Controls.Add(Me.PictureBox1)
        Me.Panelpowerpoint.Location = New System.Drawing.Point(11, 49)
        Me.Panelpowerpoint.Name = "Panelpowerpoint"
        Me.Panelpowerpoint.Size = New System.Drawing.Size(1165, 815)
        Me.Panelpowerpoint.TabIndex = 76
        '
        'txtpowerpointreame
        '
        Me.txtpowerpointreame.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpowerpointreame.Location = New System.Drawing.Point(4, 55)
        Me.txtpowerpointreame.Multiline = True
        Me.txtpowerpointreame.Name = "txtpowerpointreame"
        Me.txtpowerpointreame.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtpowerpointreame.Size = New System.Drawing.Size(941, 114)
        Me.txtpowerpointreame.TabIndex = 337
        Me.txtpowerpointreame.Text = resources.GetString("txtpowerpointreame.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 48)
        Me.PictureBox1.TabIndex = 336
        Me.PictureBox1.TabStop = False
        '
        'ucPowerPoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1194, 880)
        Me.Controls.Add(Me.gbPowerPoint)
        Me.HideOnClose = True
        Me.Name = "ucPowerPoint"
        Me.Text = "Power Point to Casparcg"
        Me.gbPowerPoint.ResumeLayout(False)
        Me.gbPowerPoint.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.ntransitiondurationforppt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelpowerpoint.ResumeLayout(False)
        Me.Panelpowerpoint.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbPowerPoint As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents rdopng As System.Windows.Forms.RadioButton
    Friend WithEvents rdojpg As System.Windows.Forms.RadioButton
    Friend WithEvents Label123 As System.Windows.Forms.Label
    Friend WithEvents cmbdirectionforppt As System.Windows.Forms.ComboBox
    Friend WithEvents Label124 As System.Windows.Forms.Label
    Friend WithEvents cmbtweentypeforppt As System.Windows.Forms.ComboBox
    Friend WithEvents Label125 As System.Windows.Forms.Label
    Friend WithEvents Label126 As System.Windows.Forms.Label
    Friend WithEvents ntransitiondurationforppt As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbtransitionforppt As System.Windows.Forms.ComboBox
    Friend WithEvents cmblayervideoforppt As System.Windows.Forms.ComboBox
    Friend WithEvents Label107 As System.Windows.Forms.Label
    Friend WithEvents cmdoutexcelfromwindow As System.Windows.Forms.Button
    Friend WithEvents cmdshowexcellinwindow As System.Windows.Forms.Button
    Friend WithEvents cmdstartexcell As System.Windows.Forms.Button
    Friend WithEvents cmdoutPowerPointwindow As System.Windows.Forms.Button
    Friend WithEvents cmdshowpowerpointwindow As System.Windows.Forms.Button
    Friend WithEvents cmdstartpowerpoint As System.Windows.Forms.Button
    Friend WithEvents Panelpowerpoint As System.Windows.Forms.Panel
    Friend WithEvents txtpowerpointreame As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdstarPowerPointoutput As System.Windows.Forms.Button
    Friend WithEvents cmdstoppowerpointoutput As System.Windows.Forms.Button

End Class
