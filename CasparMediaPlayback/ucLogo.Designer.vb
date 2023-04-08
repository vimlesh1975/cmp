<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucLogo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucLogo))
        Me.gblogo = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nopacitylogo = New System.Windows.Forms.NumericUpDown()
        Me.txtlogolocation = New System.Windows.Forms.TextBox()
        Me.lbllogofilename = New System.Windows.Forms.Label()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.cmdresetlogo = New System.Windows.Forms.Button()
        Me.cmbflashlayerforlogo = New System.Windows.Forms.ComboBox()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.cmdlogoopen = New System.Windows.Forms.Button()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.nlogoheight = New System.Windows.Forms.NumericUpDown()
        Me.nlogowidth = New System.Windows.Forms.NumericUpDown()
        Me.nlogoy = New System.Windows.Forms.NumericUpDown()
        Me.nlogox = New System.Windows.Forms.NumericUpDown()
        Me.cmdstoplogo = New System.Windows.Forms.Button()
        Me.piclogo = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.cmdplaylogo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtvideoloopaslogostop = New System.Windows.Forms.TextBox()
        Me.Label261 = New System.Windows.Forms.Label()
        Me.stopvideoloopaslogo = New System.Windows.Forms.Button()
        Me.cmdvideoloopaslogo = New System.Windows.Forms.Button()
        Me.txtvideoloopaslogo = New System.Windows.Forms.TextBox()
        Me.cmdhidegblogo = New System.Windows.Forms.Button()
        Me.gblogo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.nopacitylogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nlogoheight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nlogowidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nlogoy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nlogox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gblogo
        '
        Me.gblogo.BackColor = System.Drawing.Color.LightSeaGreen
        Me.gblogo.Controls.Add(Me.GroupBox2)
        Me.gblogo.Controls.Add(Me.GroupBox1)
        Me.gblogo.Controls.Add(Me.cmdhidegblogo)
        Me.gblogo.Location = New System.Drawing.Point(3, 2)
        Me.gblogo.Name = "gblogo"
        Me.gblogo.Size = New System.Drawing.Size(650, 296)
        Me.gblogo.TabIndex = 443
        Me.gblogo.TabStop = False
        Me.gblogo.Text = "Logo"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.GroupBox2.Controls.Add(Me.MenuStrip1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.nopacitylogo)
        Me.GroupBox2.Controls.Add(Me.txtlogolocation)
        Me.GroupBox2.Controls.Add(Me.lbllogofilename)
        Me.GroupBox2.Controls.Add(Me.Label122)
        Me.GroupBox2.Controls.Add(Me.cmdresetlogo)
        Me.GroupBox2.Controls.Add(Me.cmbflashlayerforlogo)
        Me.GroupBox2.Controls.Add(Me.Label95)
        Me.GroupBox2.Controls.Add(Me.cmdlogoopen)
        Me.GroupBox2.Controls.Add(Me.Label70)
        Me.GroupBox2.Controls.Add(Me.Label69)
        Me.GroupBox2.Controls.Add(Me.Label68)
        Me.GroupBox2.Controls.Add(Me.Label67)
        Me.GroupBox2.Controls.Add(Me.nlogoheight)
        Me.GroupBox2.Controls.Add(Me.nlogowidth)
        Me.GroupBox2.Controls.Add(Me.nlogoy)
        Me.GroupBox2.Controls.Add(Me.nlogox)
        Me.GroupBox2.Controls.Add(Me.cmdstoplogo)
        Me.GroupBox2.Controls.Add(Me.piclogo)
        Me.GroupBox2.Controls.Add(Me.cmdplaylogo)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(330, 262)
        Me.GroupBox2.TabIndex = 1179
        Me.GroupBox2.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(7, 15)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(45, 24)
        Me.MenuStrip1.TabIndex = 1177
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 724
        Me.Label1.Text = "Opacity"
        '
        'nopacitylogo
        '
        Me.nopacitylogo.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.caspar_media_playback.My.MySettings.Default, "nopacitylogo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nopacitylogo.DecimalPlaces = 1
        Me.nopacitylogo.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nopacitylogo.Location = New System.Drawing.Point(230, 80)
        Me.nopacitylogo.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nopacitylogo.Name = "nopacitylogo"
        Me.nopacitylogo.Size = New System.Drawing.Size(46, 20)
        Me.nopacitylogo.TabIndex = 723
        Me.nopacitylogo.Value = Global.caspar_media_playback.My.MySettings.Default.nopacitylogo
        '
        'txtlogolocation
        '
        Me.txtlogolocation.Location = New System.Drawing.Point(19, 208)
        Me.txtlogolocation.Name = "txtlogolocation"
        Me.txtlogolocation.Size = New System.Drawing.Size(245, 20)
        Me.txtlogolocation.TabIndex = 601
        Me.txtlogolocation.Text = "file:///C:/Casparcg/mydata/logo/time.png"
        '
        'lbllogofilename
        '
        Me.lbllogofilename.AutoSize = True
        Me.lbllogofilename.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "lbllogofilename", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lbllogofilename.Location = New System.Drawing.Point(225, 53)
        Me.lbllogofilename.MaximumSize = New System.Drawing.Size(200, 0)
        Me.lbllogofilename.Name = "lbllogofilename"
        Me.lbllogofilename.Size = New System.Drawing.Size(57, 13)
        Me.lbllogofilename.TabIndex = 600
        Me.lbllogofilename.Text = Global.caspar_media_playback.My.MySettings.Default.lbllogofilename
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.Location = New System.Drawing.Point(167, 52)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(58, 13)
        Me.Label122.TabIndex = 599
        Me.Label122.Text = "File name:-"
        '
        'cmdresetlogo
        '
        Me.cmdresetlogo.Location = New System.Drawing.Point(280, 80)
        Me.cmdresetlogo.Name = "cmdresetlogo"
        Me.cmdresetlogo.Size = New System.Drawing.Size(35, 126)
        Me.cmdresetlogo.TabIndex = 452
        Me.cmdresetlogo.Text = "R"
        Me.cmdresetlogo.UseVisualStyleBackColor = True
        '
        'cmbflashlayerforlogo
        '
        Me.cmbflashlayerforlogo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbflashlayerforlogo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbflashlayerforlogo.FormattingEnabled = True
        Me.cmbflashlayerforlogo.Items.AddRange(New Object() {"41", "42", "43", "44", "45"})
        Me.cmbflashlayerforlogo.Location = New System.Drawing.Point(286, 30)
        Me.cmbflashlayerforlogo.Name = "cmbflashlayerforlogo"
        Me.cmbflashlayerforlogo.Size = New System.Drawing.Size(40, 21)
        Me.cmbflashlayerforlogo.TabIndex = 321
        Me.cmbflashlayerforlogo.Text = "41"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Location = New System.Drawing.Point(172, 33)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(108, 13)
        Me.Label95.TabIndex = 451
        Me.Label95.Text = "video layer-flash layer"
        '
        'cmdlogoopen
        '
        Me.cmdlogoopen.Location = New System.Drawing.Point(15, 238)
        Me.cmdlogoopen.Name = "cmdlogoopen"
        Me.cmdlogoopen.Size = New System.Drawing.Size(48, 23)
        Me.cmdlogoopen.TabIndex = 450
        Me.cmdlogoopen.Text = "Open"
        Me.cmdlogoopen.UseVisualStyleBackColor = True
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(181, 188)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(38, 13)
        Me.Label70.TabIndex = 449
        Me.Label70.Text = "Height"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(181, 161)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(35, 13)
        Me.Label69.TabIndex = 448
        Me.Label69.Text = "Width"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(202, 137)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(14, 13)
        Me.Label68.TabIndex = 447
        Me.Label68.Text = "Y"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(202, 112)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(14, 13)
        Me.Label67.TabIndex = 446
        Me.Label67.Text = "X"
        '
        'nlogoheight
        '
        Me.nlogoheight.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.caspar_media_playback.My.MySettings.Default, "nlogoheight", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nlogoheight.Location = New System.Drawing.Point(223, 185)
        Me.nlogoheight.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nlogoheight.Name = "nlogoheight"
        Me.nlogoheight.Size = New System.Drawing.Size(55, 20)
        Me.nlogoheight.TabIndex = 444
        Me.nlogoheight.Value = New Decimal(New Integer() {120, 0, 0, 0})
        '
        'nlogowidth
        '
        Me.nlogowidth.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.caspar_media_playback.My.MySettings.Default, "nlogowidth", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nlogowidth.Location = New System.Drawing.Point(223, 159)
        Me.nlogowidth.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nlogowidth.Name = "nlogowidth"
        Me.nlogowidth.Size = New System.Drawing.Size(55, 20)
        Me.nlogowidth.TabIndex = 443
        Me.nlogowidth.Value = New Decimal(New Integer() {160, 0, 0, 0})
        '
        'nlogoy
        '
        Me.nlogoy.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.caspar_media_playback.My.MySettings.Default, "nlogoy", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nlogoy.Location = New System.Drawing.Point(223, 133)
        Me.nlogoy.Maximum = New Decimal(New Integer() {576, 0, 0, 0})
        Me.nlogoy.Minimum = New Decimal(New Integer() {576, 0, 0, -2147483648})
        Me.nlogoy.Name = "nlogoy"
        Me.nlogoy.Size = New System.Drawing.Size(55, 20)
        Me.nlogoy.TabIndex = 442
        Me.nlogoy.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'nlogox
        '
        Me.nlogox.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.caspar_media_playback.My.MySettings.Default, "nlogox", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nlogox.Location = New System.Drawing.Point(223, 107)
        Me.nlogox.Maximum = New Decimal(New Integer() {768, 0, 0, 0})
        Me.nlogox.Minimum = New Decimal(New Integer() {768, 0, 0, -2147483648})
        Me.nlogox.Name = "nlogox"
        Me.nlogox.Size = New System.Drawing.Size(55, 20)
        Me.nlogox.TabIndex = 441
        Me.nlogox.Value = New Decimal(New Integer() {592, 0, 0, 0})
        '
        'cmdstoplogo
        '
        Me.cmdstoplogo.BackColor = System.Drawing.Color.Red
        Me.cmdstoplogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstoplogo.ForeColor = System.Drawing.Color.White
        Me.cmdstoplogo.Location = New System.Drawing.Point(116, 238)
        Me.cmdstoplogo.Name = "cmdstoplogo"
        Me.cmdstoplogo.Size = New System.Drawing.Size(49, 23)
        Me.cmdstoplogo.TabIndex = 440
        Me.cmdstoplogo.Text = "Stop"
        Me.cmdstoplogo.UseVisualStyleBackColor = False
        '
        'piclogo
        '
        Me.piclogo.Enabled = True
        Me.piclogo.Location = New System.Drawing.Point(7, 56)
        Me.piclogo.MaximumSize = New System.Drawing.Size(161, 145)
        Me.piclogo.MinimumSize = New System.Drawing.Size(62, 33)
        Me.piclogo.Name = "piclogo"
        Me.piclogo.OcxState = CType(resources.GetObject("piclogo.OcxState"), System.Windows.Forms.AxHost.State)
        Me.piclogo.Size = New System.Drawing.Size(161, 145)
        Me.piclogo.TabIndex = 358
        '
        'cmdplaylogo
        '
        Me.cmdplaylogo.BackColor = System.Drawing.Color.Green
        Me.cmdplaylogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplaylogo.ForeColor = System.Drawing.Color.White
        Me.cmdplaylogo.Location = New System.Drawing.Point(63, 238)
        Me.cmdplaylogo.Name = "cmdplaylogo"
        Me.cmdplaylogo.Size = New System.Drawing.Size(47, 23)
        Me.cmdplaylogo.TabIndex = 439
        Me.cmdplaylogo.Text = "Play"
        Me.cmdplaylogo.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GreenYellow
        Me.GroupBox1.Controls.Add(Me.txtvideoloopaslogostop)
        Me.GroupBox1.Controls.Add(Me.Label261)
        Me.GroupBox1.Controls.Add(Me.stopvideoloopaslogo)
        Me.GroupBox1.Controls.Add(Me.cmdvideoloopaslogo)
        Me.GroupBox1.Controls.Add(Me.txtvideoloopaslogo)
        Me.GroupBox1.Location = New System.Drawing.Point(353, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 263)
        Me.GroupBox1.TabIndex = 1178
        Me.GroupBox1.TabStop = False
        '
        'txtvideoloopaslogostop
        '
        Me.txtvideoloopaslogostop.Location = New System.Drawing.Point(5, 115)
        Me.txtvideoloopaslogostop.Multiline = True
        Me.txtvideoloopaslogostop.Name = "txtvideoloopaslogostop"
        Me.txtvideoloopaslogostop.Size = New System.Drawing.Size(229, 46)
        Me.txtvideoloopaslogostop.TabIndex = 722
        Me.txtvideoloopaslogostop.Text = "stop 1-20000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mixer 1-20000 fill 0 0 1 1"
        '
        'Label261
        '
        Me.Label261.AutoSize = True
        Me.Label261.Location = New System.Drawing.Point(4, 12)
        Me.Label261.MaximumSize = New System.Drawing.Size(300, 0)
        Me.Label261.Name = "Label261"
        Me.Label261.Size = New System.Drawing.Size(276, 26)
        Me.Label261.TabIndex = 721
        Me.Label261.Text = "Video loop as logo ---video from media folder only--amb is video file name"
        '
        'stopvideoloopaslogo
        '
        Me.stopvideoloopaslogo.BackColor = System.Drawing.Color.Red
        Me.stopvideoloopaslogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopvideoloopaslogo.ForeColor = System.Drawing.Color.White
        Me.stopvideoloopaslogo.Location = New System.Drawing.Point(240, 115)
        Me.stopvideoloopaslogo.Name = "stopvideoloopaslogo"
        Me.stopvideoloopaslogo.Size = New System.Drawing.Size(49, 48)
        Me.stopvideoloopaslogo.TabIndex = 720
        Me.stopvideoloopaslogo.Text = "Stop"
        Me.stopvideoloopaslogo.UseVisualStyleBackColor = False
        '
        'cmdvideoloopaslogo
        '
        Me.cmdvideoloopaslogo.BackColor = System.Drawing.Color.Green
        Me.cmdvideoloopaslogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdvideoloopaslogo.ForeColor = System.Drawing.Color.White
        Me.cmdvideoloopaslogo.Location = New System.Drawing.Point(240, 56)
        Me.cmdvideoloopaslogo.Name = "cmdvideoloopaslogo"
        Me.cmdvideoloopaslogo.Size = New System.Drawing.Size(47, 48)
        Me.cmdvideoloopaslogo.TabIndex = 719
        Me.cmdvideoloopaslogo.Text = "Play"
        Me.cmdvideoloopaslogo.UseVisualStyleBackColor = False
        '
        'txtvideoloopaslogo
        '
        Me.txtvideoloopaslogo.Location = New System.Drawing.Point(7, 56)
        Me.txtvideoloopaslogo.Multiline = True
        Me.txtvideoloopaslogo.Name = "txtvideoloopaslogo"
        Me.txtvideoloopaslogo.Size = New System.Drawing.Size(229, 46)
        Me.txtvideoloopaslogo.TabIndex = 718
        Me.txtvideoloopaslogo.Text = "play 1-20000 amb loop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mixer 1-20000 fill 0.75 0.05 0.20 0.20"
        '
        'cmdhidegblogo
        '
        Me.cmdhidegblogo.Image = CType(resources.GetObject("cmdhidegblogo.Image"), System.Drawing.Image)
        Me.cmdhidegblogo.Location = New System.Drawing.Point(622, -2)
        Me.cmdhidegblogo.Name = "cmdhidegblogo"
        Me.cmdhidegblogo.Size = New System.Drawing.Size(28, 27)
        Me.cmdhidegblogo.TabIndex = 717
        Me.cmdhidegblogo.UseVisualStyleBackColor = True
        '
        'ucLogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.gblogo)
        Me.Name = "ucLogo"
        Me.Size = New System.Drawing.Size(656, 299)
        Me.gblogo.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.nopacitylogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nlogoheight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nlogowidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nlogoy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nlogox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gblogo As System.Windows.Forms.GroupBox
    Friend WithEvents txtvideoloopaslogostop As System.Windows.Forms.TextBox
    Friend WithEvents Label261 As System.Windows.Forms.Label
    Friend WithEvents stopvideoloopaslogo As System.Windows.Forms.Button
    Friend WithEvents cmdvideoloopaslogo As System.Windows.Forms.Button
    Friend WithEvents txtvideoloopaslogo As System.Windows.Forms.TextBox
    Friend WithEvents cmdhidegblogo As System.Windows.Forms.Button
    Friend WithEvents txtlogolocation As System.Windows.Forms.TextBox
    Friend WithEvents lbllogofilename As System.Windows.Forms.Label
    Friend WithEvents Label122 As System.Windows.Forms.Label
    Friend WithEvents cmdresetlogo As System.Windows.Forms.Button
    Friend WithEvents cmbflashlayerforlogo As System.Windows.Forms.ComboBox
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents cmdlogoopen As System.Windows.Forms.Button
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents nlogoheight As System.Windows.Forms.NumericUpDown
    Friend WithEvents nlogowidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents nlogoy As System.Windows.Forms.NumericUpDown
    Friend WithEvents nlogox As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdstoplogo As System.Windows.Forms.Button
    Friend WithEvents piclogo As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents cmdplaylogo As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nopacitylogo As NumericUpDown
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
