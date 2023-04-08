<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucWeather
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucWeather))
        Me.gbweather = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtWeatherTemplate = New System.Windows.Forms.TextBox()
        Me.lblweatherfilename = New System.Windows.Forms.Label()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.cmdrefreshmedaiforweather = New System.Windows.Forms.Button()
        Me.cmbweathericon4 = New System.Windows.Forms.ComboBox()
        Me.nweathericon4height = New System.Windows.Forms.NumericUpDown()
        Me.nweathericon4width = New System.Windows.Forms.NumericUpDown()
        Me.nweathericon4y = New System.Windows.Forms.NumericUpDown()
        Me.nweathericon4x = New System.Windows.Forms.NumericUpDown()
        Me.weathericon4 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.cmbweathericon3 = New System.Windows.Forms.ComboBox()
        Me.nweathericon3height = New System.Windows.Forms.NumericUpDown()
        Me.nweathericon3width = New System.Windows.Forms.NumericUpDown()
        Me.nweathericon3y = New System.Windows.Forms.NumericUpDown()
        Me.nweathericon3x = New System.Windows.Forms.NumericUpDown()
        Me.weathericon3 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.cmbweathericon2 = New System.Windows.Forms.ComboBox()
        Me.nweathericon2height = New System.Windows.Forms.NumericUpDown()
        Me.nweathericon2width = New System.Windows.Forms.NumericUpDown()
        Me.nweathericon2y = New System.Windows.Forms.NumericUpDown()
        Me.nweathericon2x = New System.Windows.Forms.NumericUpDown()
        Me.weathericon2 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.txtweathericon4 = New System.Windows.Forms.TextBox()
        Me.txtweathericon3 = New System.Windows.Forms.TextBox()
        Me.txtweathericon2 = New System.Windows.Forms.TextBox()
        Me.cmbweathericon1 = New System.Windows.Forms.ComboBox()
        Me.txtweathericon1 = New System.Windows.Forms.TextBox()
        Me.cmbweathericon1videolayer = New System.Windows.Forms.ComboBox()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.nweathericon1height = New System.Windows.Forms.NumericUpDown()
        Me.nweathericon1width = New System.Windows.Forms.NumericUpDown()
        Me.nweathericon1y = New System.Windows.Forms.NumericUpDown()
        Me.nweathericon1x = New System.Windows.Forms.NumericUpDown()
        Me.cmdweathericon1stop = New System.Windows.Forms.Button()
        Me.weathericon1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.cmdweathericon1play = New System.Windows.Forms.Button()
        Me.gbweather.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.nweathericon4height, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nweathericon4width, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nweathericon4y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nweathericon4x, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.weathericon4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nweathericon3height, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nweathericon3width, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nweathericon3y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nweathericon3x, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.weathericon3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nweathericon2height, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nweathericon2width, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nweathericon2y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nweathericon2x, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.weathericon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nweathericon1height, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nweathericon1width, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nweathericon1y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nweathericon1x, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.weathericon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbweather
        '
        Me.gbweather.BackColor = System.Drawing.Color.Lime
        Me.gbweather.Controls.Add(Me.MenuStrip1)
        Me.gbweather.Controls.Add(Me.Label6)
        Me.gbweather.Controls.Add(Me.txtWeatherTemplate)
        Me.gbweather.Controls.Add(Me.lblweatherfilename)
        Me.gbweather.Controls.Add(Me.Label120)
        Me.gbweather.Controls.Add(Me.cmdrefreshmedaiforweather)
        Me.gbweather.Controls.Add(Me.cmbweathericon4)
        Me.gbweather.Controls.Add(Me.nweathericon4height)
        Me.gbweather.Controls.Add(Me.nweathericon4width)
        Me.gbweather.Controls.Add(Me.nweathericon4y)
        Me.gbweather.Controls.Add(Me.nweathericon4x)
        Me.gbweather.Controls.Add(Me.weathericon4)
        Me.gbweather.Controls.Add(Me.cmbweathericon3)
        Me.gbweather.Controls.Add(Me.nweathericon3height)
        Me.gbweather.Controls.Add(Me.nweathericon3width)
        Me.gbweather.Controls.Add(Me.nweathericon3y)
        Me.gbweather.Controls.Add(Me.nweathericon3x)
        Me.gbweather.Controls.Add(Me.weathericon3)
        Me.gbweather.Controls.Add(Me.cmbweathericon2)
        Me.gbweather.Controls.Add(Me.nweathericon2height)
        Me.gbweather.Controls.Add(Me.nweathericon2width)
        Me.gbweather.Controls.Add(Me.nweathericon2y)
        Me.gbweather.Controls.Add(Me.nweathericon2x)
        Me.gbweather.Controls.Add(Me.weathericon2)
        Me.gbweather.Controls.Add(Me.txtweathericon4)
        Me.gbweather.Controls.Add(Me.txtweathericon3)
        Me.gbweather.Controls.Add(Me.txtweathericon2)
        Me.gbweather.Controls.Add(Me.cmbweathericon1)
        Me.gbweather.Controls.Add(Me.txtweathericon1)
        Me.gbweather.Controls.Add(Me.cmbweathericon1videolayer)
        Me.gbweather.Controls.Add(Me.Label115)
        Me.gbweather.Controls.Add(Me.Label116)
        Me.gbweather.Controls.Add(Me.Label117)
        Me.gbweather.Controls.Add(Me.Label118)
        Me.gbweather.Controls.Add(Me.Label119)
        Me.gbweather.Controls.Add(Me.nweathericon1height)
        Me.gbweather.Controls.Add(Me.nweathericon1width)
        Me.gbweather.Controls.Add(Me.nweathericon1y)
        Me.gbweather.Controls.Add(Me.nweathericon1x)
        Me.gbweather.Controls.Add(Me.cmdweathericon1stop)
        Me.gbweather.Controls.Add(Me.weathericon1)
        Me.gbweather.Controls.Add(Me.cmdweathericon1play)
        Me.gbweather.Location = New System.Drawing.Point(3, 2)
        Me.gbweather.Name = "gbweather"
        Me.gbweather.Size = New System.Drawing.Size(660, 365)
        Me.gbweather.TabIndex = 454
        Me.gbweather.TabStop = False
        Me.gbweather.Text = " "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(8, 42)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(45, 24)
        Me.MenuStrip1.TabIndex = 1176
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 1175
        Me.Label6.Text = "Template"
        '
        'txtWeatherTemplate
        '
        Me.txtWeatherTemplate.Location = New System.Drawing.Point(68, 19)
        Me.txtWeatherTemplate.Name = "txtWeatherTemplate"
        Me.txtWeatherTemplate.Size = New System.Drawing.Size(290, 20)
        Me.txtWeatherTemplate.TabIndex = 1174
        Me.txtWeatherTemplate.Text = "CMP/weather/weather"
        '
        'lblweatherfilename
        '
        Me.lblweatherfilename.AutoSize = True
        Me.lblweatherfilename.Location = New System.Drawing.Point(68, 76)
        Me.lblweatherfilename.Name = "lblweatherfilename"
        Me.lblweatherfilename.Size = New System.Drawing.Size(57, 13)
        Me.lblweatherfilename.TabIndex = 597
        Me.lblweatherfilename.Text = "Default file"
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.Location = New System.Drawing.Point(10, 75)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(58, 13)
        Me.Label120.TabIndex = 596
        Me.Label120.Text = "File name:-"
        '
        'cmdrefreshmedaiforweather
        '
        Me.cmdrefreshmedaiforweather.Location = New System.Drawing.Point(513, 208)
        Me.cmdrefreshmedaiforweather.Name = "cmdrefreshmedaiforweather"
        Me.cmdrefreshmedaiforweather.Size = New System.Drawing.Size(64, 34)
        Me.cmdrefreshmedaiforweather.TabIndex = 595
        Me.cmdrefreshmedaiforweather.Text = "Refresh Media"
        Me.cmdrefreshmedaiforweather.UseVisualStyleBackColor = True
        '
        'cmbweathericon4
        '
        Me.cmbweathericon4.FormattingEnabled = True
        Me.cmbweathericon4.Location = New System.Drawing.Point(393, 210)
        Me.cmbweathericon4.Name = "cmbweathericon4"
        Me.cmbweathericon4.Size = New System.Drawing.Size(118, 21)
        Me.cmbweathericon4.Sorted = True
        Me.cmbweathericon4.TabIndex = 563
        Me.cmbweathericon4.Text = "4.png"
        '
        'nweathericon4height
        '
        Me.nweathericon4height.Location = New System.Drawing.Point(456, 316)
        Me.nweathericon4height.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nweathericon4height.Name = "nweathericon4height"
        Me.nweathericon4height.Size = New System.Drawing.Size(55, 20)
        Me.nweathericon4height.TabIndex = 562
        Me.nweathericon4height.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'nweathericon4width
        '
        Me.nweathericon4width.Location = New System.Drawing.Point(456, 290)
        Me.nweathericon4width.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nweathericon4width.Name = "nweathericon4width"
        Me.nweathericon4width.Size = New System.Drawing.Size(55, 20)
        Me.nweathericon4width.TabIndex = 561
        Me.nweathericon4width.Value = New Decimal(New Integer() {140, 0, 0, 0})
        '
        'nweathericon4y
        '
        Me.nweathericon4y.Location = New System.Drawing.Point(456, 264)
        Me.nweathericon4y.Maximum = New Decimal(New Integer() {576, 0, 0, 0})
        Me.nweathericon4y.Minimum = New Decimal(New Integer() {576, 0, 0, -2147483648})
        Me.nweathericon4y.Name = "nweathericon4y"
        Me.nweathericon4y.Size = New System.Drawing.Size(55, 20)
        Me.nweathericon4y.TabIndex = 560
        Me.nweathericon4y.Value = New Decimal(New Integer() {260, 0, 0, 0})
        '
        'nweathericon4x
        '
        Me.nweathericon4x.Location = New System.Drawing.Point(456, 238)
        Me.nweathericon4x.Maximum = New Decimal(New Integer() {768, 0, 0, 0})
        Me.nweathericon4x.Minimum = New Decimal(New Integer() {768, 0, 0, -2147483648})
        Me.nweathericon4x.Name = "nweathericon4x"
        Me.nweathericon4x.Size = New System.Drawing.Size(55, 20)
        Me.nweathericon4x.TabIndex = 559
        Me.nweathericon4x.Value = New Decimal(New Integer() {590, 0, 0, 0})
        '
        'weathericon4
        '
        Me.weathericon4.Enabled = True
        Me.weathericon4.Location = New System.Drawing.Point(396, 95)
        Me.weathericon4.MaximumSize = New System.Drawing.Size(400, 300)
        Me.weathericon4.MinimumSize = New System.Drawing.Size(62, 33)
        Me.weathericon4.Name = "weathericon4"
        Me.weathericon4.OcxState = CType(resources.GetObject("weathericon4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.weathericon4.Size = New System.Drawing.Size(117, 85)
        Me.weathericon4.TabIndex = 558
        '
        'cmbweathericon3
        '
        Me.cmbweathericon3.FormattingEnabled = True
        Me.cmbweathericon3.Location = New System.Drawing.Point(265, 208)
        Me.cmbweathericon3.Name = "cmbweathericon3"
        Me.cmbweathericon3.Size = New System.Drawing.Size(118, 21)
        Me.cmbweathericon3.Sorted = True
        Me.cmbweathericon3.TabIndex = 556
        Me.cmbweathericon3.Text = "3.png"
        '
        'nweathericon3height
        '
        Me.nweathericon3height.Location = New System.Drawing.Point(328, 314)
        Me.nweathericon3height.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nweathericon3height.Name = "nweathericon3height"
        Me.nweathericon3height.Size = New System.Drawing.Size(55, 20)
        Me.nweathericon3height.TabIndex = 555
        Me.nweathericon3height.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'nweathericon3width
        '
        Me.nweathericon3width.Location = New System.Drawing.Point(328, 288)
        Me.nweathericon3width.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nweathericon3width.Name = "nweathericon3width"
        Me.nweathericon3width.Size = New System.Drawing.Size(55, 20)
        Me.nweathericon3width.TabIndex = 554
        Me.nweathericon3width.Value = New Decimal(New Integer() {140, 0, 0, 0})
        '
        'nweathericon3y
        '
        Me.nweathericon3y.Location = New System.Drawing.Point(328, 262)
        Me.nweathericon3y.Maximum = New Decimal(New Integer() {576, 0, 0, 0})
        Me.nweathericon3y.Minimum = New Decimal(New Integer() {576, 0, 0, -2147483648})
        Me.nweathericon3y.Name = "nweathericon3y"
        Me.nweathericon3y.Size = New System.Drawing.Size(55, 20)
        Me.nweathericon3y.TabIndex = 553
        Me.nweathericon3y.Value = New Decimal(New Integer() {260, 0, 0, 0})
        '
        'nweathericon3x
        '
        Me.nweathericon3x.Location = New System.Drawing.Point(328, 236)
        Me.nweathericon3x.Maximum = New Decimal(New Integer() {768, 0, 0, 0})
        Me.nweathericon3x.Minimum = New Decimal(New Integer() {768, 0, 0, -2147483648})
        Me.nweathericon3x.Name = "nweathericon3x"
        Me.nweathericon3x.Size = New System.Drawing.Size(55, 20)
        Me.nweathericon3x.TabIndex = 552
        Me.nweathericon3x.Value = New Decimal(New Integer() {400, 0, 0, 0})
        '
        'weathericon3
        '
        Me.weathericon3.Enabled = True
        Me.weathericon3.Location = New System.Drawing.Point(268, 93)
        Me.weathericon3.MaximumSize = New System.Drawing.Size(400, 300)
        Me.weathericon3.MinimumSize = New System.Drawing.Size(62, 33)
        Me.weathericon3.Name = "weathericon3"
        Me.weathericon3.OcxState = CType(resources.GetObject("weathericon3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.weathericon3.Size = New System.Drawing.Size(117, 85)
        Me.weathericon3.TabIndex = 551
        '
        'cmbweathericon2
        '
        Me.cmbweathericon2.FormattingEnabled = True
        Me.cmbweathericon2.Location = New System.Drawing.Point(139, 210)
        Me.cmbweathericon2.Name = "cmbweathericon2"
        Me.cmbweathericon2.Size = New System.Drawing.Size(118, 21)
        Me.cmbweathericon2.Sorted = True
        Me.cmbweathericon2.TabIndex = 549
        Me.cmbweathericon2.Text = "2.png"
        '
        'nweathericon2height
        '
        Me.nweathericon2height.Location = New System.Drawing.Point(202, 316)
        Me.nweathericon2height.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nweathericon2height.Name = "nweathericon2height"
        Me.nweathericon2height.Size = New System.Drawing.Size(55, 20)
        Me.nweathericon2height.TabIndex = 547
        Me.nweathericon2height.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'nweathericon2width
        '
        Me.nweathericon2width.Location = New System.Drawing.Point(202, 290)
        Me.nweathericon2width.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nweathericon2width.Name = "nweathericon2width"
        Me.nweathericon2width.Size = New System.Drawing.Size(55, 20)
        Me.nweathericon2width.TabIndex = 546
        Me.nweathericon2width.Value = New Decimal(New Integer() {140, 0, 0, 0})
        '
        'nweathericon2y
        '
        Me.nweathericon2y.Location = New System.Drawing.Point(202, 264)
        Me.nweathericon2y.Maximum = New Decimal(New Integer() {576, 0, 0, 0})
        Me.nweathericon2y.Minimum = New Decimal(New Integer() {576, 0, 0, -2147483648})
        Me.nweathericon2y.Name = "nweathericon2y"
        Me.nweathericon2y.Size = New System.Drawing.Size(55, 20)
        Me.nweathericon2y.TabIndex = 545
        Me.nweathericon2y.Value = New Decimal(New Integer() {260, 0, 0, 0})
        '
        'nweathericon2x
        '
        Me.nweathericon2x.Location = New System.Drawing.Point(202, 238)
        Me.nweathericon2x.Maximum = New Decimal(New Integer() {768, 0, 0, 0})
        Me.nweathericon2x.Minimum = New Decimal(New Integer() {768, 0, 0, -2147483648})
        Me.nweathericon2x.Name = "nweathericon2x"
        Me.nweathericon2x.Size = New System.Drawing.Size(55, 20)
        Me.nweathericon2x.TabIndex = 544
        Me.nweathericon2x.Value = New Decimal(New Integer() {230, 0, 0, 0})
        '
        'weathericon2
        '
        Me.weathericon2.Enabled = True
        Me.weathericon2.Location = New System.Drawing.Point(142, 95)
        Me.weathericon2.MaximumSize = New System.Drawing.Size(400, 300)
        Me.weathericon2.MinimumSize = New System.Drawing.Size(62, 33)
        Me.weathericon2.Name = "weathericon2"
        Me.weathericon2.OcxState = CType(resources.GetObject("weathericon2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.weathericon2.Size = New System.Drawing.Size(117, 85)
        Me.weathericon2.TabIndex = 543
        '
        'txtweathericon4
        '
        Me.txtweathericon4.Location = New System.Drawing.Point(396, 186)
        Me.txtweathericon4.Name = "txtweathericon4"
        Me.txtweathericon4.Size = New System.Drawing.Size(117, 20)
        Me.txtweathericon4.TabIndex = 542
        Me.txtweathericon4.Text = "Chennai 32° C"
        Me.txtweathericon4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtweathericon3
        '
        Me.txtweathericon3.Location = New System.Drawing.Point(268, 185)
        Me.txtweathericon3.Name = "txtweathericon3"
        Me.txtweathericon3.Size = New System.Drawing.Size(117, 20)
        Me.txtweathericon3.TabIndex = 541
        Me.txtweathericon3.Text = "Kolkatta 23° C"
        Me.txtweathericon3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtweathericon2
        '
        Me.txtweathericon2.Location = New System.Drawing.Point(142, 187)
        Me.txtweathericon2.Name = "txtweathericon2"
        Me.txtweathericon2.Size = New System.Drawing.Size(117, 20)
        Me.txtweathericon2.TabIndex = 540
        Me.txtweathericon2.Text = "Delhi 35° C"
        Me.txtweathericon2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbweathericon1
        '
        Me.cmbweathericon1.FormattingEnabled = True
        Me.cmbweathericon1.Location = New System.Drawing.Point(11, 210)
        Me.cmbweathericon1.Name = "cmbweathericon1"
        Me.cmbweathericon1.Size = New System.Drawing.Size(118, 21)
        Me.cmbweathericon1.Sorted = True
        Me.cmbweathericon1.TabIndex = 539
        Me.cmbweathericon1.Text = "1.png"
        '
        'txtweathericon1
        '
        Me.txtweathericon1.Location = New System.Drawing.Point(12, 186)
        Me.txtweathericon1.Name = "txtweathericon1"
        Me.txtweathericon1.Size = New System.Drawing.Size(117, 20)
        Me.txtweathericon1.TabIndex = 452
        Me.txtweathericon1.Text = "Mumbai 25° C"
        Me.txtweathericon1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbweathericon1videolayer
        '
        Me.cmbweathericon1videolayer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbweathericon1videolayer", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbweathericon1videolayer.FormattingEnabled = True
        Me.cmbweathericon1videolayer.Items.AddRange(New Object() {"71", "72", "73", "74", "75"})
        Me.cmbweathericon1videolayer.Location = New System.Drawing.Point(568, 14)
        Me.cmbweathericon1videolayer.Name = "cmbweathericon1videolayer"
        Me.cmbweathericon1videolayer.Size = New System.Drawing.Size(45, 21)
        Me.cmbweathericon1videolayer.TabIndex = 321
        Me.cmbweathericon1videolayer.Text = "71"
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Location = New System.Drawing.Point(454, 14)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(108, 13)
        Me.Label115.TabIndex = 451
        Me.Label115.Text = "video layer-flash layer"
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Location = New System.Drawing.Point(32, 319)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(38, 13)
        Me.Label116.TabIndex = 449
        Me.Label116.Text = "Height"
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.Location = New System.Drawing.Point(32, 292)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(35, 13)
        Me.Label117.TabIndex = 448
        Me.Label117.Text = "Width"
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.Location = New System.Drawing.Point(53, 268)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(14, 13)
        Me.Label118.TabIndex = 447
        Me.Label118.Text = "Y"
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Location = New System.Drawing.Point(53, 241)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(14, 13)
        Me.Label119.TabIndex = 446
        Me.Label119.Text = "X"
        '
        'nweathericon1height
        '
        Me.nweathericon1height.Location = New System.Drawing.Point(74, 316)
        Me.nweathericon1height.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nweathericon1height.Name = "nweathericon1height"
        Me.nweathericon1height.Size = New System.Drawing.Size(55, 20)
        Me.nweathericon1height.TabIndex = 444
        Me.nweathericon1height.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'nweathericon1width
        '
        Me.nweathericon1width.Location = New System.Drawing.Point(74, 290)
        Me.nweathericon1width.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nweathericon1width.Name = "nweathericon1width"
        Me.nweathericon1width.Size = New System.Drawing.Size(55, 20)
        Me.nweathericon1width.TabIndex = 443
        Me.nweathericon1width.Value = New Decimal(New Integer() {140, 0, 0, 0})
        '
        'nweathericon1y
        '
        Me.nweathericon1y.Location = New System.Drawing.Point(74, 264)
        Me.nweathericon1y.Maximum = New Decimal(New Integer() {576, 0, 0, 0})
        Me.nweathericon1y.Minimum = New Decimal(New Integer() {576, 0, 0, -2147483648})
        Me.nweathericon1y.Name = "nweathericon1y"
        Me.nweathericon1y.Size = New System.Drawing.Size(55, 20)
        Me.nweathericon1y.TabIndex = 442
        Me.nweathericon1y.Value = New Decimal(New Integer() {260, 0, 0, 0})
        '
        'nweathericon1x
        '
        Me.nweathericon1x.Location = New System.Drawing.Point(74, 238)
        Me.nweathericon1x.Maximum = New Decimal(New Integer() {768, 0, 0, 0})
        Me.nweathericon1x.Minimum = New Decimal(New Integer() {768, 0, 0, -2147483648})
        Me.nweathericon1x.Name = "nweathericon1x"
        Me.nweathericon1x.Size = New System.Drawing.Size(55, 20)
        Me.nweathericon1x.TabIndex = 441
        Me.nweathericon1x.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'cmdweathericon1stop
        '
        Me.cmdweathericon1stop.BackColor = System.Drawing.Color.Red
        Me.cmdweathericon1stop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdweathericon1stop.ForeColor = System.Drawing.Color.White
        Me.cmdweathericon1stop.Location = New System.Drawing.Point(583, 241)
        Me.cmdweathericon1stop.Name = "cmdweathericon1stop"
        Me.cmdweathericon1stop.Size = New System.Drawing.Size(71, 122)
        Me.cmdweathericon1stop.TabIndex = 440
        Me.cmdweathericon1stop.Text = "Stop"
        Me.cmdweathericon1stop.UseVisualStyleBackColor = False
        '
        'weathericon1
        '
        Me.weathericon1.Enabled = True
        Me.weathericon1.Location = New System.Drawing.Point(14, 95)
        Me.weathericon1.MaximumSize = New System.Drawing.Size(400, 300)
        Me.weathericon1.MinimumSize = New System.Drawing.Size(62, 33)
        Me.weathericon1.Name = "weathericon1"
        Me.weathericon1.OcxState = CType(resources.GetObject("weathericon1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.weathericon1.Size = New System.Drawing.Size(117, 85)
        Me.weathericon1.TabIndex = 358
        '
        'cmdweathericon1play
        '
        Me.cmdweathericon1play.BackColor = System.Drawing.Color.Green
        Me.cmdweathericon1play.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdweathericon1play.ForeColor = System.Drawing.Color.White
        Me.cmdweathericon1play.Location = New System.Drawing.Point(585, 95)
        Me.cmdweathericon1play.Name = "cmdweathericon1play"
        Me.cmdweathericon1play.Size = New System.Drawing.Size(69, 124)
        Me.cmdweathericon1play.TabIndex = 439
        Me.cmdweathericon1play.Text = "Play"
        Me.cmdweathericon1play.UseVisualStyleBackColor = False
        '
        'ucWeather
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1221, 749)
        Me.Controls.Add(Me.gbweather)
        Me.HideOnClose = True
        Me.Name = "ucWeather"
        Me.Text = "Weather"
        Me.gbweather.ResumeLayout(False)
        Me.gbweather.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.nweathericon4height, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nweathericon4width, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nweathericon4y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nweathericon4x, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.weathericon4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nweathericon3height, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nweathericon3width, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nweathericon3y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nweathericon3x, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.weathericon3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nweathericon2height, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nweathericon2width, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nweathericon2y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nweathericon2x, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.weathericon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nweathericon1height, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nweathericon1width, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nweathericon1y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nweathericon1x, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.weathericon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbweather As System.Windows.Forms.GroupBox
    Friend WithEvents lblweatherfilename As System.Windows.Forms.Label
    Friend WithEvents Label120 As System.Windows.Forms.Label
    Friend WithEvents cmdrefreshmedaiforweather As System.Windows.Forms.Button
    Friend WithEvents cmbweathericon4 As System.Windows.Forms.ComboBox
    Friend WithEvents nweathericon4height As System.Windows.Forms.NumericUpDown
    Friend WithEvents nweathericon4width As System.Windows.Forms.NumericUpDown
    Friend WithEvents nweathericon4y As System.Windows.Forms.NumericUpDown
    Friend WithEvents nweathericon4x As System.Windows.Forms.NumericUpDown
    Friend WithEvents weathericon4 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents cmbweathericon3 As System.Windows.Forms.ComboBox
    Friend WithEvents nweathericon3height As System.Windows.Forms.NumericUpDown
    Friend WithEvents nweathericon3width As System.Windows.Forms.NumericUpDown
    Friend WithEvents nweathericon3y As System.Windows.Forms.NumericUpDown
    Friend WithEvents nweathericon3x As System.Windows.Forms.NumericUpDown
    Friend WithEvents weathericon3 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents cmbweathericon2 As System.Windows.Forms.ComboBox
    Friend WithEvents nweathericon2height As System.Windows.Forms.NumericUpDown
    Friend WithEvents nweathericon2width As System.Windows.Forms.NumericUpDown
    Friend WithEvents nweathericon2y As System.Windows.Forms.NumericUpDown
    Friend WithEvents nweathericon2x As System.Windows.Forms.NumericUpDown
    Friend WithEvents weathericon2 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents txtweathericon4 As System.Windows.Forms.TextBox
    Friend WithEvents txtweathericon3 As System.Windows.Forms.TextBox
    Friend WithEvents txtweathericon2 As System.Windows.Forms.TextBox
    Friend WithEvents cmbweathericon1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtweathericon1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbweathericon1videolayer As System.Windows.Forms.ComboBox
    Friend WithEvents Label115 As System.Windows.Forms.Label
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents Label117 As System.Windows.Forms.Label
    Friend WithEvents Label118 As System.Windows.Forms.Label
    Friend WithEvents Label119 As System.Windows.Forms.Label
    Friend WithEvents nweathericon1height As System.Windows.Forms.NumericUpDown
    Friend WithEvents nweathericon1width As System.Windows.Forms.NumericUpDown
    Friend WithEvents nweathericon1y As System.Windows.Forms.NumericUpDown
    Friend WithEvents nweathericon1x As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdweathericon1stop As System.Windows.Forms.Button
    Friend WithEvents weathericon1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents cmdweathericon1play As System.Windows.Forms.Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtWeatherTemplate As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
End Class
