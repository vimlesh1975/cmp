<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMixernew
    Inherits System.Windows.Forms.UserControl
    'Inherits WeifenLuo.WinFormsUI.Docking.DockContent

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
        Me.gbMixer = New System.Windows.Forms.GroupBox()
        Me.gbScalefromCenter = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nscalexfromCenter = New System.Windows.Forms.NumericUpDown()
        Me.nscaleyfromCenter = New System.Windows.Forms.NumericUpDown()
        Me.cmdResetScalefromCenter = New System.Windows.Forms.Button()
        Me.nmixermastervolume = New System.Windows.Forms.NumericUpDown()
        Me.gbcropmixer = New System.Windows.Forms.GroupBox()
        Me.Label235 = New System.Windows.Forms.Label()
        Me.Label234 = New System.Windows.Forms.Label()
        Me.ncropbrx = New System.Windows.Forms.NumericUpDown()
        Me.ncropbry = New System.Windows.Forms.NumericUpDown()
        Me.Label189 = New System.Windows.Forms.Label()
        Me.Label193 = New System.Windows.Forms.Label()
        Me.Label194 = New System.Windows.Forms.Label()
        Me.ncroptlx = New System.Windows.Forms.NumericUpDown()
        Me.ncroptly = New System.Windows.Forms.NumericUpDown()
        Me.Label199 = New System.Windows.Forms.Label()
        Me.Label200 = New System.Windows.Forms.Label()
        Me.Label198 = New System.Windows.Forms.Label()
        Me.cmdresetcropmixer = New System.Windows.Forms.Button()
        Me.chkmipmapmixer = New System.Windows.Forms.CheckBox()
        Me.gbperspectivemixer = New System.Windows.Forms.GroupBox()
        Me.Label186 = New System.Windows.Forms.Label()
        Me.nperspectiveblx = New System.Windows.Forms.NumericUpDown()
        Me.nperspectivebly = New System.Windows.Forms.NumericUpDown()
        Me.Label187 = New System.Windows.Forms.Label()
        Me.Label188 = New System.Windows.Forms.Label()
        Me.Label183 = New System.Windows.Forms.Label()
        Me.nperspectivebrx = New System.Windows.Forms.NumericUpDown()
        Me.nperspectivebry = New System.Windows.Forms.NumericUpDown()
        Me.Label184 = New System.Windows.Forms.Label()
        Me.Label185 = New System.Windows.Forms.Label()
        Me.Label180 = New System.Windows.Forms.Label()
        Me.nperspectivetrx = New System.Windows.Forms.NumericUpDown()
        Me.nperspectivetry = New System.Windows.Forms.NumericUpDown()
        Me.Label181 = New System.Windows.Forms.Label()
        Me.Label182 = New System.Windows.Forms.Label()
        Me.Label177 = New System.Windows.Forms.Label()
        Me.nperspectivetlx = New System.Windows.Forms.NumericUpDown()
        Me.nperspectivetly = New System.Windows.Forms.NumericUpDown()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.cmdresetperspectivemixer = New System.Windows.Forms.Button()
        Me.cmdgetstatusofmixer = New System.Windows.Forms.Button()
        Me.gbrotationmixer = New System.Windows.Forms.GroupBox()
        Me.Label176 = New System.Windows.Forms.Label()
        Me.nrotationz = New System.Windows.Forms.NumericUpDown()
        Me.cmdresetrotationmixer = New System.Windows.Forms.Button()
        Me.gbanchormixer = New System.Windows.Forms.GroupBox()
        Me.nanchorx = New System.Windows.Forms.NumericUpDown()
        Me.nanchory = New System.Windows.Forms.NumericUpDown()
        Me.Label178 = New System.Windows.Forms.Label()
        Me.Label179 = New System.Windows.Forms.Label()
        Me.cmdresetanchormixer = New System.Windows.Forms.Button()
        Me.cmdmixersettingopen = New System.Windows.Forms.Button()
        Me.cmdmixersettingsave = New System.Windows.Forms.Button()
        Me.cmdmastervolume = New System.Windows.Forms.Button()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.cmdmixerclearformixemodule = New System.Windows.Forms.Button()
        Me.cmbvideolayerformixer = New System.Windows.Forms.ComboBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.cmbblend = New System.Windows.Forms.ComboBox()
        Me.gbclip = New System.Windows.Forms.GroupBox()
        Me.nclipx = New System.Windows.Forms.NumericUpDown()
        Me.nclipy = New System.Windows.Forms.NumericUpDown()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.nclipxsclae = New System.Windows.Forms.NumericUpDown()
        Me.nclipyscale = New System.Windows.Forms.NumericUpDown()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.cmdclipreset = New System.Windows.Forms.Button()
        Me.gblevels = New System.Windows.Forms.GroupBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.ngamma = New System.Windows.Forms.NumericUpDown()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.nmax_output = New System.Windows.Forms.NumericUpDown()
        Me.nmin_output = New System.Windows.Forms.NumericUpDown()
        Me.nmax_input = New System.Windows.Forms.NumericUpDown()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.nmin_input = New System.Windows.Forms.NumericUpDown()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.cmdLevels = New System.Windows.Forms.Button()
        Me.gbfill = New System.Windows.Forms.GroupBox()
        Me.nfillx = New System.Windows.Forms.NumericUpDown()
        Me.nfilly = New System.Windows.Forms.NumericUpDown()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.nfillwidth = New System.Windows.Forms.NumericUpDown()
        Me.nfillheight = New System.Windows.Forms.NumericUpDown()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.cmdfill = New System.Windows.Forms.Button()
        Me.cmdmixerclear = New System.Windows.Forms.Button()
        Me.gbothers = New System.Windows.Forms.GroupBox()
        Me.nVolume = New System.Windows.Forms.NumericUpDown()
        Me.cmdVolume = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.nContrast = New System.Windows.Forms.NumericUpDown()
        Me.nSaturation = New System.Windows.Forms.NumericUpDown()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.nbrightness = New System.Windows.Forms.NumericUpDown()
        Me.nopacity = New System.Windows.Forms.NumericUpDown()
        Me.cmdContrast = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cmdSaturation = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cmdbrightness = New System.Windows.Forms.Button()
        Me.cmdopacity = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cmdVerticalMobileToFullScreen = New System.Windows.Forms.Button()
        Me.gbMixer.SuspendLayout()
        Me.gbScalefromCenter.SuspendLayout()
        CType(Me.nscalexfromCenter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nscaleyfromCenter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmixermastervolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbcropmixer.SuspendLayout()
        CType(Me.ncropbrx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ncropbry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ncroptlx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ncroptly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbperspectivemixer.SuspendLayout()
        CType(Me.nperspectiveblx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nperspectivebly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nperspectivebrx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nperspectivebry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nperspectivetrx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nperspectivetry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nperspectivetlx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nperspectivetly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbrotationmixer.SuspendLayout()
        CType(Me.nrotationz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbanchormixer.SuspendLayout()
        CType(Me.nanchorx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nanchory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbclip.SuspendLayout()
        CType(Me.nclipx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nclipy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nclipxsclae, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nclipyscale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gblevels.SuspendLayout()
        CType(Me.ngamma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmax_output, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmin_output, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmax_input, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmin_input, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbfill.SuspendLayout()
        CType(Me.nfillx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nfilly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nfillwidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nfillheight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbothers.SuspendLayout()
        CType(Me.nVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nContrast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nSaturation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nbrightness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nopacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbMixer
        '
        Me.gbMixer.BackColor = System.Drawing.Color.Wheat
        Me.gbMixer.Controls.Add(Me.cmdVerticalMobileToFullScreen)
        Me.gbMixer.Controls.Add(Me.gbScalefromCenter)
        Me.gbMixer.Controls.Add(Me.nmixermastervolume)
        Me.gbMixer.Controls.Add(Me.gbcropmixer)
        Me.gbMixer.Controls.Add(Me.chkmipmapmixer)
        Me.gbMixer.Controls.Add(Me.gbperspectivemixer)
        Me.gbMixer.Controls.Add(Me.cmdgetstatusofmixer)
        Me.gbMixer.Controls.Add(Me.gbrotationmixer)
        Me.gbMixer.Controls.Add(Me.gbanchormixer)
        Me.gbMixer.Controls.Add(Me.cmdmixersettingopen)
        Me.gbMixer.Controls.Add(Me.cmdmixersettingsave)
        Me.gbMixer.Controls.Add(Me.cmdmastervolume)
        Me.gbMixer.Controls.Add(Me.Label108)
        Me.gbMixer.Controls.Add(Me.cmdmixerclearformixemodule)
        Me.gbMixer.Controls.Add(Me.cmbvideolayerformixer)
        Me.gbMixer.Controls.Add(Me.Label99)
        Me.gbMixer.Controls.Add(Me.Label49)
        Me.gbMixer.Controls.Add(Me.cmbblend)
        Me.gbMixer.Controls.Add(Me.gbclip)
        Me.gbMixer.Controls.Add(Me.gblevels)
        Me.gbMixer.Controls.Add(Me.gbfill)
        Me.gbMixer.Controls.Add(Me.cmdmixerclear)
        Me.gbMixer.Controls.Add(Me.gbothers)
        Me.gbMixer.Location = New System.Drawing.Point(2, 2)
        Me.gbMixer.Name = "gbMixer"
        Me.gbMixer.Size = New System.Drawing.Size(585, 552)
        Me.gbMixer.TabIndex = 423
        Me.gbMixer.TabStop = False
        Me.gbMixer.Text = " "
        '
        'gbScalefromCenter
        '
        Me.gbScalefromCenter.BackColor = System.Drawing.Color.NavajoWhite
        Me.gbScalefromCenter.Controls.Add(Me.Label1)
        Me.gbScalefromCenter.Controls.Add(Me.Label2)
        Me.gbScalefromCenter.Controls.Add(Me.nscalexfromCenter)
        Me.gbScalefromCenter.Controls.Add(Me.nscaleyfromCenter)
        Me.gbScalefromCenter.Controls.Add(Me.cmdResetScalefromCenter)
        Me.gbScalefromCenter.Location = New System.Drawing.Point(328, 77)
        Me.gbScalefromCenter.Name = "gbScalefromCenter"
        Me.gbScalefromCenter.Size = New System.Drawing.Size(127, 66)
        Me.gbScalefromCenter.TabIndex = 419
        Me.gbScalefromCenter.TabStop = False
        Me.gbScalefromCenter.Text = "Scale From Center"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 415
        Me.Label1.Text = "Y Scale"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 414
        Me.Label2.Text = "X Scale"
        '
        'nscalexfromCenter
        '
        Me.nscalexfromCenter.DecimalPlaces = 2
        Me.nscalexfromCenter.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nscalexfromCenter.Location = New System.Drawing.Point(51, 19)
        Me.nscalexfromCenter.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nscalexfromCenter.Name = "nscalexfromCenter"
        Me.nscalexfromCenter.Size = New System.Drawing.Size(46, 20)
        Me.nscalexfromCenter.TabIndex = 413
        Me.nscalexfromCenter.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nscaleyfromCenter
        '
        Me.nscaleyfromCenter.DecimalPlaces = 2
        Me.nscaleyfromCenter.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nscaleyfromCenter.Location = New System.Drawing.Point(51, 43)
        Me.nscaleyfromCenter.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nscaleyfromCenter.Name = "nscaleyfromCenter"
        Me.nscaleyfromCenter.Size = New System.Drawing.Size(46, 20)
        Me.nscaleyfromCenter.TabIndex = 412
        Me.nscaleyfromCenter.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmdResetScalefromCenter
        '
        Me.cmdResetScalefromCenter.Location = New System.Drawing.Point(100, 19)
        Me.cmdResetScalefromCenter.Name = "cmdResetScalefromCenter"
        Me.cmdResetScalefromCenter.Size = New System.Drawing.Size(21, 44)
        Me.cmdResetScalefromCenter.TabIndex = 407
        Me.cmdResetScalefromCenter.Text = "R"
        Me.cmdResetScalefromCenter.UseVisualStyleBackColor = True
        '
        'nmixermastervolume
        '
        Me.nmixermastervolume.DecimalPlaces = 1
        Me.nmixermastervolume.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nmixermastervolume.Location = New System.Drawing.Point(459, 372)
        Me.nmixermastervolume.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nmixermastervolume.Name = "nmixermastervolume"
        Me.nmixermastervolume.Size = New System.Drawing.Size(38, 20)
        Me.nmixermastervolume.TabIndex = 713
        Me.nmixermastervolume.Value = New Decimal(New Integer() {10, 0, 0, 65536})
        '
        'gbcropmixer
        '
        Me.gbcropmixer.BackColor = System.Drawing.Color.Moccasin
        Me.gbcropmixer.Controls.Add(Me.Label235)
        Me.gbcropmixer.Controls.Add(Me.Label234)
        Me.gbcropmixer.Controls.Add(Me.ncropbrx)
        Me.gbcropmixer.Controls.Add(Me.ncropbry)
        Me.gbcropmixer.Controls.Add(Me.Label189)
        Me.gbcropmixer.Controls.Add(Me.Label193)
        Me.gbcropmixer.Controls.Add(Me.Label194)
        Me.gbcropmixer.Controls.Add(Me.ncroptlx)
        Me.gbcropmixer.Controls.Add(Me.ncroptly)
        Me.gbcropmixer.Controls.Add(Me.Label199)
        Me.gbcropmixer.Controls.Add(Me.Label200)
        Me.gbcropmixer.Controls.Add(Me.Label198)
        Me.gbcropmixer.Controls.Add(Me.cmdresetcropmixer)
        Me.gbcropmixer.Location = New System.Drawing.Point(324, 190)
        Me.gbcropmixer.Name = "gbcropmixer"
        Me.gbcropmixer.Size = New System.Drawing.Size(176, 97)
        Me.gbcropmixer.TabIndex = 434
        Me.gbcropmixer.TabStop = False
        Me.gbcropmixer.Text = "Crop"
        '
        'Label235
        '
        Me.Label235.AutoSize = True
        Me.Label235.Location = New System.Drawing.Point(96, 77)
        Me.Label235.Name = "Label235"
        Me.Label235.Size = New System.Drawing.Size(40, 13)
        Me.Label235.TabIndex = 713
        Me.Label235.Text = "Bottom"
        '
        'Label234
        '
        Me.Label234.AutoSize = True
        Me.Label234.Location = New System.Drawing.Point(31, 76)
        Me.Label234.Name = "Label234"
        Me.Label234.Size = New System.Drawing.Size(26, 13)
        Me.Label234.TabIndex = 714
        Me.Label234.Text = "Top"
        '
        'ncropbrx
        '
        Me.ncropbrx.DecimalPlaces = 2
        Me.ncropbrx.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.ncropbrx.Location = New System.Drawing.Point(95, 31)
        Me.ncropbrx.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.ncropbrx.Name = "ncropbrx"
        Me.ncropbrx.Size = New System.Drawing.Size(46, 20)
        Me.ncropbrx.TabIndex = 427
        '
        'ncropbry
        '
        Me.ncropbry.DecimalPlaces = 2
        Me.ncropbry.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.ncropbry.Location = New System.Drawing.Point(95, 55)
        Me.ncropbry.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.ncropbry.Name = "ncropbry"
        Me.ncropbry.Size = New System.Drawing.Size(46, 20)
        Me.ncropbry.TabIndex = 426
        '
        'Label189
        '
        Me.Label189.AutoSize = True
        Me.Label189.Location = New System.Drawing.Point(96, 15)
        Me.Label189.Name = "Label189"
        Me.Label189.Size = New System.Drawing.Size(35, 13)
        Me.Label189.TabIndex = 433
        Me.Label189.Text = " Right"
        '
        'Label193
        '
        Me.Label193.AutoSize = True
        Me.Label193.Location = New System.Drawing.Point(79, 58)
        Me.Label193.Name = "Label193"
        Me.Label193.Size = New System.Drawing.Size(14, 13)
        Me.Label193.TabIndex = 425
        Me.Label193.Text = "Y"
        '
        'Label194
        '
        Me.Label194.AutoSize = True
        Me.Label194.Location = New System.Drawing.Point(77, 37)
        Me.Label194.Name = "Label194"
        Me.Label194.Size = New System.Drawing.Size(14, 13)
        Me.Label194.TabIndex = 424
        Me.Label194.Text = "X"
        '
        'ncroptlx
        '
        Me.ncroptlx.DecimalPlaces = 2
        Me.ncroptlx.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.ncroptlx.Location = New System.Drawing.Point(25, 28)
        Me.ncroptlx.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.ncroptlx.Name = "ncroptlx"
        Me.ncroptlx.Size = New System.Drawing.Size(46, 20)
        Me.ncroptlx.TabIndex = 417
        '
        'ncroptly
        '
        Me.ncroptly.DecimalPlaces = 2
        Me.ncroptly.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.ncroptly.Location = New System.Drawing.Point(25, 52)
        Me.ncroptly.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.ncroptly.Name = "ncroptly"
        Me.ncroptly.Size = New System.Drawing.Size(46, 20)
        Me.ncroptly.TabIndex = 416
        '
        'Label199
        '
        Me.Label199.AutoSize = True
        Me.Label199.Location = New System.Drawing.Point(11, 55)
        Me.Label199.Name = "Label199"
        Me.Label199.Size = New System.Drawing.Size(14, 13)
        Me.Label199.TabIndex = 410
        Me.Label199.Text = "Y"
        '
        'Label200
        '
        Me.Label200.AutoSize = True
        Me.Label200.Location = New System.Drawing.Point(9, 34)
        Me.Label200.Name = "Label200"
        Me.Label200.Size = New System.Drawing.Size(14, 13)
        Me.Label200.TabIndex = 408
        Me.Label200.Text = "X"
        '
        'Label198
        '
        Me.Label198.AutoSize = True
        Me.Label198.Location = New System.Drawing.Point(29, 13)
        Me.Label198.Name = "Label198"
        Me.Label198.Size = New System.Drawing.Size(25, 13)
        Me.Label198.TabIndex = 418
        Me.Label198.Text = "Left"
        '
        'cmdresetcropmixer
        '
        Me.cmdresetcropmixer.Location = New System.Drawing.Point(148, 20)
        Me.cmdresetcropmixer.Name = "cmdresetcropmixer"
        Me.cmdresetcropmixer.Size = New System.Drawing.Size(21, 69)
        Me.cmdresetcropmixer.TabIndex = 407
        Me.cmdresetcropmixer.Text = "R"
        Me.cmdresetcropmixer.UseVisualStyleBackColor = True
        '
        'chkmipmapmixer
        '
        Me.chkmipmapmixer.AutoSize = True
        Me.chkmipmapmixer.Location = New System.Drawing.Point(382, 407)
        Me.chkmipmapmixer.Name = "chkmipmapmixer"
        Me.chkmipmapmixer.Size = New System.Drawing.Size(64, 17)
        Me.chkmipmapmixer.TabIndex = 712
        Me.chkmipmapmixer.Text = "MipMap"
        Me.chkmipmapmixer.UseVisualStyleBackColor = True
        '
        'gbperspectivemixer
        '
        Me.gbperspectivemixer.BackColor = System.Drawing.Color.AntiqueWhite
        Me.gbperspectivemixer.Controls.Add(Me.Label186)
        Me.gbperspectivemixer.Controls.Add(Me.nperspectiveblx)
        Me.gbperspectivemixer.Controls.Add(Me.nperspectivebly)
        Me.gbperspectivemixer.Controls.Add(Me.Label187)
        Me.gbperspectivemixer.Controls.Add(Me.Label188)
        Me.gbperspectivemixer.Controls.Add(Me.Label183)
        Me.gbperspectivemixer.Controls.Add(Me.nperspectivebrx)
        Me.gbperspectivemixer.Controls.Add(Me.nperspectivebry)
        Me.gbperspectivemixer.Controls.Add(Me.Label184)
        Me.gbperspectivemixer.Controls.Add(Me.Label185)
        Me.gbperspectivemixer.Controls.Add(Me.Label180)
        Me.gbperspectivemixer.Controls.Add(Me.nperspectivetrx)
        Me.gbperspectivemixer.Controls.Add(Me.nperspectivetry)
        Me.gbperspectivemixer.Controls.Add(Me.Label181)
        Me.gbperspectivemixer.Controls.Add(Me.Label182)
        Me.gbperspectivemixer.Controls.Add(Me.Label177)
        Me.gbperspectivemixer.Controls.Add(Me.nperspectivetlx)
        Me.gbperspectivemixer.Controls.Add(Me.nperspectivetly)
        Me.gbperspectivemixer.Controls.Add(Me.Label111)
        Me.gbperspectivemixer.Controls.Add(Me.Label112)
        Me.gbperspectivemixer.Controls.Add(Me.cmdresetperspectivemixer)
        Me.gbperspectivemixer.Location = New System.Drawing.Point(11, 448)
        Me.gbperspectivemixer.Name = "gbperspectivemixer"
        Me.gbperspectivemixer.Size = New System.Drawing.Size(309, 97)
        Me.gbperspectivemixer.TabIndex = 420
        Me.gbperspectivemixer.TabStop = False
        Me.gbperspectivemixer.Text = "Perspective"
        '
        'Label186
        '
        Me.Label186.AutoSize = True
        Me.Label186.Location = New System.Drawing.Point(139, 19)
        Me.Label186.Name = "Label186"
        Me.Label186.Size = New System.Drawing.Size(68, 13)
        Me.Label186.TabIndex = 433
        Me.Label186.Text = "Bottom Right"
        '
        'nperspectiveblx
        '
        Me.nperspectiveblx.DecimalPlaces = 2
        Me.nperspectiveblx.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nperspectiveblx.Location = New System.Drawing.Point(218, 42)
        Me.nperspectiveblx.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nperspectiveblx.Name = "nperspectiveblx"
        Me.nperspectiveblx.Size = New System.Drawing.Size(46, 20)
        Me.nperspectiveblx.TabIndex = 432
        '
        'nperspectivebly
        '
        Me.nperspectivebly.DecimalPlaces = 2
        Me.nperspectivebly.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nperspectivebly.Location = New System.Drawing.Point(218, 66)
        Me.nperspectivebly.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nperspectivebly.Name = "nperspectivebly"
        Me.nperspectivebly.Size = New System.Drawing.Size(46, 20)
        Me.nperspectivebly.TabIndex = 431
        '
        'Label187
        '
        Me.Label187.AutoSize = True
        Me.Label187.Location = New System.Drawing.Point(202, 69)
        Me.Label187.Name = "Label187"
        Me.Label187.Size = New System.Drawing.Size(14, 13)
        Me.Label187.TabIndex = 430
        Me.Label187.Text = "Y"
        '
        'Label188
        '
        Me.Label188.AutoSize = True
        Me.Label188.Location = New System.Drawing.Point(200, 48)
        Me.Label188.Name = "Label188"
        Me.Label188.Size = New System.Drawing.Size(14, 13)
        Me.Label188.TabIndex = 429
        Me.Label188.Text = "X"
        '
        'Label183
        '
        Me.Label183.AutoSize = True
        Me.Label183.Location = New System.Drawing.Point(214, 20)
        Me.Label183.Name = "Label183"
        Me.Label183.Size = New System.Drawing.Size(61, 13)
        Me.Label183.TabIndex = 428
        Me.Label183.Text = "Bottom Left"
        '
        'nperspectivebrx
        '
        Me.nperspectivebrx.DecimalPlaces = 2
        Me.nperspectivebrx.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nperspectivebrx.Location = New System.Drawing.Point(150, 41)
        Me.nperspectivebrx.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nperspectivebrx.Name = "nperspectivebrx"
        Me.nperspectivebrx.Size = New System.Drawing.Size(46, 20)
        Me.nperspectivebrx.TabIndex = 427
        '
        'nperspectivebry
        '
        Me.nperspectivebry.DecimalPlaces = 2
        Me.nperspectivebry.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nperspectivebry.Location = New System.Drawing.Point(150, 65)
        Me.nperspectivebry.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nperspectivebry.Name = "nperspectivebry"
        Me.nperspectivebry.Size = New System.Drawing.Size(46, 20)
        Me.nperspectivebry.TabIndex = 426
        '
        'Label184
        '
        Me.Label184.AutoSize = True
        Me.Label184.Location = New System.Drawing.Point(134, 68)
        Me.Label184.Name = "Label184"
        Me.Label184.Size = New System.Drawing.Size(14, 13)
        Me.Label184.TabIndex = 425
        Me.Label184.Text = "Y"
        '
        'Label185
        '
        Me.Label185.AutoSize = True
        Me.Label185.Location = New System.Drawing.Point(132, 47)
        Me.Label185.Name = "Label185"
        Me.Label185.Size = New System.Drawing.Size(14, 13)
        Me.Label185.TabIndex = 424
        Me.Label185.Text = "X"
        '
        'Label180
        '
        Me.Label180.AutoSize = True
        Me.Label180.Location = New System.Drawing.Point(72, 20)
        Me.Label180.Name = "Label180"
        Me.Label180.Size = New System.Drawing.Size(54, 13)
        Me.Label180.TabIndex = 423
        Me.Label180.Text = "Top Right"
        '
        'nperspectivetrx
        '
        Me.nperspectivetrx.DecimalPlaces = 2
        Me.nperspectivetrx.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nperspectivetrx.Location = New System.Drawing.Point(84, 40)
        Me.nperspectivetrx.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nperspectivetrx.Name = "nperspectivetrx"
        Me.nperspectivetrx.Size = New System.Drawing.Size(46, 20)
        Me.nperspectivetrx.TabIndex = 422
        '
        'nperspectivetry
        '
        Me.nperspectivetry.DecimalPlaces = 2
        Me.nperspectivetry.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nperspectivetry.Location = New System.Drawing.Point(84, 64)
        Me.nperspectivetry.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nperspectivetry.Name = "nperspectivetry"
        Me.nperspectivetry.Size = New System.Drawing.Size(46, 20)
        Me.nperspectivetry.TabIndex = 421
        '
        'Label181
        '
        Me.Label181.AutoSize = True
        Me.Label181.Location = New System.Drawing.Point(68, 67)
        Me.Label181.Name = "Label181"
        Me.Label181.Size = New System.Drawing.Size(14, 13)
        Me.Label181.TabIndex = 420
        Me.Label181.Text = "Y"
        '
        'Label182
        '
        Me.Label182.AutoSize = True
        Me.Label182.Location = New System.Drawing.Point(65, 43)
        Me.Label182.Name = "Label182"
        Me.Label182.Size = New System.Drawing.Size(14, 13)
        Me.Label182.TabIndex = 419
        Me.Label182.Text = "X"
        '
        'Label177
        '
        Me.Label177.AutoSize = True
        Me.Label177.Location = New System.Drawing.Point(7, 18)
        Me.Label177.Name = "Label177"
        Me.Label177.Size = New System.Drawing.Size(47, 13)
        Me.Label177.TabIndex = 418
        Me.Label177.Text = "Top Left"
        '
        'nperspectivetlx
        '
        Me.nperspectivetlx.DecimalPlaces = 2
        Me.nperspectivetlx.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nperspectivetlx.Location = New System.Drawing.Point(19, 38)
        Me.nperspectivetlx.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nperspectivetlx.Name = "nperspectivetlx"
        Me.nperspectivetlx.Size = New System.Drawing.Size(46, 20)
        Me.nperspectivetlx.TabIndex = 417
        '
        'nperspectivetly
        '
        Me.nperspectivetly.DecimalPlaces = 2
        Me.nperspectivetly.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nperspectivetly.Location = New System.Drawing.Point(19, 62)
        Me.nperspectivetly.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nperspectivetly.Name = "nperspectivetly"
        Me.nperspectivetly.Size = New System.Drawing.Size(46, 20)
        Me.nperspectivetly.TabIndex = 416
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Location = New System.Drawing.Point(5, 65)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(14, 13)
        Me.Label111.TabIndex = 410
        Me.Label111.Text = "Y"
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Location = New System.Drawing.Point(3, 44)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(14, 13)
        Me.Label112.TabIndex = 408
        Me.Label112.Text = "X"
        '
        'cmdresetperspectivemixer
        '
        Me.cmdresetperspectivemixer.Location = New System.Drawing.Point(281, 22)
        Me.cmdresetperspectivemixer.Name = "cmdresetperspectivemixer"
        Me.cmdresetperspectivemixer.Size = New System.Drawing.Size(21, 69)
        Me.cmdresetperspectivemixer.TabIndex = 407
        Me.cmdresetperspectivemixer.Text = "R"
        Me.cmdresetperspectivemixer.UseVisualStyleBackColor = True
        '
        'cmdgetstatusofmixer
        '
        Me.cmdgetstatusofmixer.Location = New System.Drawing.Point(503, 13)
        Me.cmdgetstatusofmixer.Name = "cmdgetstatusofmixer"
        Me.cmdgetstatusofmixer.Size = New System.Drawing.Size(74, 27)
        Me.cmdgetstatusofmixer.TabIndex = 711
        Me.cmdgetstatusofmixer.Text = "Get Status"
        Me.cmdgetstatusofmixer.UseVisualStyleBackColor = True
        '
        'gbrotationmixer
        '
        Me.gbrotationmixer.BackColor = System.Drawing.Color.Moccasin
        Me.gbrotationmixer.Controls.Add(Me.Label176)
        Me.gbrotationmixer.Controls.Add(Me.nrotationz)
        Me.gbrotationmixer.Controls.Add(Me.cmdresetrotationmixer)
        Me.gbrotationmixer.Location = New System.Drawing.Point(185, 360)
        Me.gbrotationmixer.Name = "gbrotationmixer"
        Me.gbrotationmixer.Size = New System.Drawing.Size(131, 69)
        Me.gbrotationmixer.TabIndex = 420
        Me.gbrotationmixer.TabStop = False
        Me.gbrotationmixer.Text = "Rotation"
        '
        'Label176
        '
        Me.Label176.AutoSize = True
        Me.Label176.Location = New System.Drawing.Point(14, 19)
        Me.Label176.Name = "Label176"
        Me.Label176.Size = New System.Drawing.Size(14, 13)
        Me.Label176.TabIndex = 418
        Me.Label176.Text = "Z"
        '
        'nrotationz
        '
        Me.nrotationz.DecimalPlaces = 2
        Me.nrotationz.Location = New System.Drawing.Point(32, 15)
        Me.nrotationz.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nrotationz.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.nrotationz.Name = "nrotationz"
        Me.nrotationz.Size = New System.Drawing.Size(64, 20)
        Me.nrotationz.TabIndex = 413
        '
        'cmdresetrotationmixer
        '
        Me.cmdresetrotationmixer.Location = New System.Drawing.Point(101, 15)
        Me.cmdresetrotationmixer.Name = "cmdresetrotationmixer"
        Me.cmdresetrotationmixer.Size = New System.Drawing.Size(21, 20)
        Me.cmdresetrotationmixer.TabIndex = 407
        Me.cmdresetrotationmixer.Text = "R"
        Me.cmdresetrotationmixer.UseVisualStyleBackColor = True
        '
        'gbanchormixer
        '
        Me.gbanchormixer.BackColor = System.Drawing.Color.Bisque
        Me.gbanchormixer.Controls.Add(Me.nanchorx)
        Me.gbanchormixer.Controls.Add(Me.nanchory)
        Me.gbanchormixer.Controls.Add(Me.Label178)
        Me.gbanchormixer.Controls.Add(Me.Label179)
        Me.gbanchormixer.Controls.Add(Me.cmdresetanchormixer)
        Me.gbanchormixer.Location = New System.Drawing.Point(14, 360)
        Me.gbanchormixer.Name = "gbanchormixer"
        Me.gbanchormixer.Size = New System.Drawing.Size(149, 69)
        Me.gbanchormixer.TabIndex = 419
        Me.gbanchormixer.TabStop = False
        Me.gbanchormixer.Text = "Anchor"
        '
        'nanchorx
        '
        Me.nanchorx.DecimalPlaces = 2
        Me.nanchorx.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nanchorx.Location = New System.Drawing.Point(63, 17)
        Me.nanchorx.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nanchorx.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.nanchorx.Name = "nanchorx"
        Me.nanchorx.Size = New System.Drawing.Size(46, 20)
        Me.nanchorx.TabIndex = 417
        '
        'nanchory
        '
        Me.nanchory.DecimalPlaces = 2
        Me.nanchory.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nanchory.Location = New System.Drawing.Point(63, 41)
        Me.nanchory.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nanchory.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.nanchory.Name = "nanchory"
        Me.nanchory.Size = New System.Drawing.Size(46, 20)
        Me.nanchory.TabIndex = 416
        '
        'Label178
        '
        Me.Label178.AutoSize = True
        Me.Label178.Location = New System.Drawing.Point(47, 44)
        Me.Label178.Name = "Label178"
        Me.Label178.Size = New System.Drawing.Size(14, 13)
        Me.Label178.TabIndex = 410
        Me.Label178.Text = "Y"
        '
        'Label179
        '
        Me.Label179.AutoSize = True
        Me.Label179.Location = New System.Drawing.Point(45, 23)
        Me.Label179.Name = "Label179"
        Me.Label179.Size = New System.Drawing.Size(14, 13)
        Me.Label179.TabIndex = 408
        Me.Label179.Text = "X"
        '
        'cmdresetanchormixer
        '
        Me.cmdresetanchormixer.Location = New System.Drawing.Point(112, 15)
        Me.cmdresetanchormixer.Name = "cmdresetanchormixer"
        Me.cmdresetanchormixer.Size = New System.Drawing.Size(21, 45)
        Me.cmdresetanchormixer.TabIndex = 407
        Me.cmdresetanchormixer.Text = "R"
        Me.cmdresetanchormixer.UseVisualStyleBackColor = True
        '
        'cmdmixersettingopen
        '
        Me.cmdmixersettingopen.Location = New System.Drawing.Point(523, 214)
        Me.cmdmixersettingopen.Name = "cmdmixersettingopen"
        Me.cmdmixersettingopen.Size = New System.Drawing.Size(54, 40)
        Me.cmdmixersettingopen.TabIndex = 484
        Me.cmdmixersettingopen.Text = "Open Setting"
        Me.cmdmixersettingopen.UseVisualStyleBackColor = True
        '
        'cmdmixersettingsave
        '
        Me.cmdmixersettingsave.Location = New System.Drawing.Point(523, 169)
        Me.cmdmixersettingsave.Name = "cmdmixersettingsave"
        Me.cmdmixersettingsave.Size = New System.Drawing.Size(54, 39)
        Me.cmdmixersettingsave.TabIndex = 483
        Me.cmdmixersettingsave.Text = "Save Setting"
        Me.cmdmixersettingsave.UseVisualStyleBackColor = True
        '
        'cmdmastervolume
        '
        Me.cmdmastervolume.Location = New System.Drawing.Point(503, 372)
        Me.cmdmastervolume.Name = "cmdmastervolume"
        Me.cmdmastervolume.Size = New System.Drawing.Size(23, 22)
        Me.cmdmastervolume.TabIndex = 406
        Me.cmdmastervolume.Text = "RST"
        Me.cmdmastervolume.UseVisualStyleBackColor = True
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.Location = New System.Drawing.Point(377, 373)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(77, 13)
        Me.Label108.TabIndex = 402
        Me.Label108.Text = "Master Volume"
        '
        'cmdmixerclearformixemodule
        '
        Me.cmdmixerclearformixemodule.Location = New System.Drawing.Point(523, 45)
        Me.cmdmixerclearformixemodule.Name = "cmdmixerclearformixemodule"
        Me.cmdmixerclearformixemodule.Size = New System.Drawing.Size(54, 62)
        Me.cmdmixerclearformixemodule.TabIndex = 425
        Me.cmdmixerclearformixemodule.Text = "Reset Mixer of Channel"
        Me.cmdmixerclearformixemodule.UseVisualStyleBackColor = True
        '
        'cmbvideolayerformixer
        '
        Me.cmbvideolayerformixer.FormattingEnabled = True
        Me.cmbvideolayerformixer.Items.AddRange(New Object() {"1", "6", "11", "16", "21", "26", "31", "36", "41", "46", "51", "56", "61", "66", "71", "76", "81", "86", "9999"})
        Me.cmbvideolayerformixer.Location = New System.Drawing.Point(454, 17)
        Me.cmbvideolayerformixer.Name = "cmbvideolayerformixer"
        Me.cmbvideolayerformixer.Size = New System.Drawing.Size(44, 21)
        Me.cmbvideolayerformixer.TabIndex = 423
        Me.cmbvideolayerformixer.Text = "1"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Location = New System.Drawing.Point(386, 20)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(63, 13)
        Me.Label99.TabIndex = 422
        Me.Label99.Text = "Video Layer"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(333, 332)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(34, 13)
        Me.Label49.TabIndex = 402
        Me.Label49.Text = "Blend"
        '
        'cmbblend
        '
        Me.cmbblend.FormattingEnabled = True
        Me.cmbblend.Items.AddRange(New Object() {"Normal", "Lighten", "Darken", "Multiply", "Average", "Add", "Subtract", "Difference", "Negation", "Exclusion", "Screen", "Overlay", "Soft_Light", "Hard_Light", "Color_Dodge"})
        Me.cmbblend.Location = New System.Drawing.Point(378, 327)
        Me.cmbblend.Name = "cmbblend"
        Me.cmbblend.Size = New System.Drawing.Size(148, 21)
        Me.cmbblend.TabIndex = 421
        Me.cmbblend.Text = "Normal"
        '
        'gbclip
        '
        Me.gbclip.BackColor = System.Drawing.Color.SandyBrown
        Me.gbclip.Controls.Add(Me.nclipx)
        Me.gbclip.Controls.Add(Me.nclipy)
        Me.gbclip.Controls.Add(Me.Label35)
        Me.gbclip.Controls.Add(Me.Label42)
        Me.gbclip.Controls.Add(Me.nclipxsclae)
        Me.gbclip.Controls.Add(Me.nclipyscale)
        Me.gbclip.Controls.Add(Me.Label47)
        Me.gbclip.Controls.Add(Me.Label48)
        Me.gbclip.Controls.Add(Me.cmdclipreset)
        Me.gbclip.Location = New System.Drawing.Point(188, 10)
        Me.gbclip.Name = "gbclip"
        Me.gbclip.Size = New System.Drawing.Size(127, 138)
        Me.gbclip.TabIndex = 419
        Me.gbclip.TabStop = False
        Me.gbclip.Text = "Clip"
        '
        'nclipx
        '
        Me.nclipx.DecimalPlaces = 2
        Me.nclipx.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nclipx.Location = New System.Drawing.Point(49, 29)
        Me.nclipx.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nclipx.Name = "nclipx"
        Me.nclipx.Size = New System.Drawing.Size(46, 20)
        Me.nclipx.TabIndex = 417
        '
        'nclipy
        '
        Me.nclipy.DecimalPlaces = 2
        Me.nclipy.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nclipy.Location = New System.Drawing.Point(49, 53)
        Me.nclipy.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nclipy.Name = "nclipy"
        Me.nclipy.Size = New System.Drawing.Size(46, 20)
        Me.nclipy.TabIndex = 416
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(4, 102)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(40, 13)
        Me.Label35.TabIndex = 415
        Me.Label35.Text = "Buttom"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(17, 80)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(32, 13)
        Me.Label42.TabIndex = 414
        Me.Label42.Text = "Right"
        '
        'nclipxsclae
        '
        Me.nclipxsclae.DecimalPlaces = 2
        Me.nclipxsclae.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nclipxsclae.Location = New System.Drawing.Point(49, 77)
        Me.nclipxsclae.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nclipxsclae.Name = "nclipxsclae"
        Me.nclipxsclae.Size = New System.Drawing.Size(46, 20)
        Me.nclipxsclae.TabIndex = 413
        '
        'nclipyscale
        '
        Me.nclipyscale.DecimalPlaces = 2
        Me.nclipyscale.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nclipyscale.Location = New System.Drawing.Point(49, 101)
        Me.nclipyscale.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nclipyscale.Name = "nclipyscale"
        Me.nclipyscale.Size = New System.Drawing.Size(46, 20)
        Me.nclipyscale.TabIndex = 412
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(18, 55)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(26, 13)
        Me.Label47.TabIndex = 410
        Me.Label47.Text = "Top"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(1, 31)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(47, 13)
        Me.Label48.TabIndex = 408
        Me.Label48.Text = "From left"
        '
        'cmdclipreset
        '
        Me.cmdclipreset.Location = New System.Drawing.Point(100, 28)
        Me.cmdclipreset.Name = "cmdclipreset"
        Me.cmdclipreset.Size = New System.Drawing.Size(21, 94)
        Me.cmdclipreset.TabIndex = 407
        Me.cmdclipreset.Text = "R"
        Me.cmdclipreset.UseVisualStyleBackColor = True
        '
        'gblevels
        '
        Me.gblevels.BackColor = System.Drawing.Color.PeachPuff
        Me.gblevels.Controls.Add(Me.Label40)
        Me.gblevels.Controls.Add(Me.ngamma)
        Me.gblevels.Controls.Add(Me.Label39)
        Me.gblevels.Controls.Add(Me.Label38)
        Me.gblevels.Controls.Add(Me.nmax_output)
        Me.gblevels.Controls.Add(Me.nmin_output)
        Me.gblevels.Controls.Add(Me.nmax_input)
        Me.gblevels.Controls.Add(Me.Label37)
        Me.gblevels.Controls.Add(Me.nmin_input)
        Me.gblevels.Controls.Add(Me.Label36)
        Me.gblevels.Controls.Add(Me.cmdLevels)
        Me.gblevels.Location = New System.Drawing.Point(10, 186)
        Me.gblevels.Name = "gblevels"
        Me.gblevels.Size = New System.Drawing.Size(149, 136)
        Me.gblevels.TabIndex = 419
        Me.gblevels.TabStop = False
        Me.gblevels.Text = "Levels"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(3, 64)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(41, 13)
        Me.Label40.TabIndex = 401
        Me.Label40.Text = "gamma"
        '
        'ngamma
        '
        Me.ngamma.DecimalPlaces = 1
        Me.ngamma.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ngamma.Location = New System.Drawing.Point(64, 62)
        Me.ngamma.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.ngamma.Name = "ngamma"
        Me.ngamma.Size = New System.Drawing.Size(46, 20)
        Me.ngamma.TabIndex = 400
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(0, 112)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(62, 13)
        Me.Label39.TabIndex = 399
        Me.Label39.Text = "max_output"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(3, 90)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(59, 13)
        Me.Label38.TabIndex = 398
        Me.Label38.Text = "min_output"
        '
        'nmax_output
        '
        Me.nmax_output.DecimalPlaces = 1
        Me.nmax_output.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nmax_output.Location = New System.Drawing.Point(64, 110)
        Me.nmax_output.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmax_output.Name = "nmax_output"
        Me.nmax_output.Size = New System.Drawing.Size(46, 20)
        Me.nmax_output.TabIndex = 397
        '
        'nmin_output
        '
        Me.nmin_output.DecimalPlaces = 1
        Me.nmin_output.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nmin_output.Location = New System.Drawing.Point(64, 88)
        Me.nmin_output.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmin_output.Name = "nmin_output"
        Me.nmin_output.Size = New System.Drawing.Size(46, 20)
        Me.nmin_output.TabIndex = 396
        '
        'nmax_input
        '
        Me.nmax_input.DecimalPlaces = 1
        Me.nmax_input.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nmax_input.Location = New System.Drawing.Point(65, 38)
        Me.nmax_input.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmax_input.Name = "nmax_input"
        Me.nmax_input.Size = New System.Drawing.Size(46, 20)
        Me.nmax_input.TabIndex = 391
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(7, 40)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(55, 13)
        Me.Label37.TabIndex = 390
        Me.Label37.Text = "max_input"
        '
        'nmin_input
        '
        Me.nmin_input.DecimalPlaces = 1
        Me.nmin_input.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nmin_input.Location = New System.Drawing.Point(65, 16)
        Me.nmin_input.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmin_input.Name = "nmin_input"
        Me.nmin_input.Size = New System.Drawing.Size(46, 20)
        Me.nmin_input.TabIndex = 389
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(7, 17)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(52, 13)
        Me.Label36.TabIndex = 388
        Me.Label36.Text = "min_input"
        '
        'cmdLevels
        '
        Me.cmdLevels.Location = New System.Drawing.Point(114, 15)
        Me.cmdLevels.Name = "cmdLevels"
        Me.cmdLevels.Size = New System.Drawing.Size(21, 118)
        Me.cmdLevels.TabIndex = 387
        Me.cmdLevels.Text = "R"
        Me.cmdLevels.UseVisualStyleBackColor = True
        '
        'gbfill
        '
        Me.gbfill.BackColor = System.Drawing.Color.PapayaWhip
        Me.gbfill.Controls.Add(Me.nfillx)
        Me.gbfill.Controls.Add(Me.nfilly)
        Me.gbfill.Controls.Add(Me.Label43)
        Me.gbfill.Controls.Add(Me.Label44)
        Me.gbfill.Controls.Add(Me.nfillwidth)
        Me.gbfill.Controls.Add(Me.nfillheight)
        Me.gbfill.Controls.Add(Me.Label45)
        Me.gbfill.Controls.Add(Me.Label46)
        Me.gbfill.Controls.Add(Me.cmdfill)
        Me.gbfill.Location = New System.Drawing.Point(188, 195)
        Me.gbfill.Name = "gbfill"
        Me.gbfill.Size = New System.Drawing.Size(127, 132)
        Me.gbfill.TabIndex = 418
        Me.gbfill.TabStop = False
        Me.gbfill.Text = "Fill"
        '
        'nfillx
        '
        Me.nfillx.DecimalPlaces = 2
        Me.nfillx.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nfillx.Location = New System.Drawing.Point(49, 29)
        Me.nfillx.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nfillx.Minimum = New Decimal(New Integer() {2, 0, 0, -2147483648})
        Me.nfillx.Name = "nfillx"
        Me.nfillx.Size = New System.Drawing.Size(46, 20)
        Me.nfillx.TabIndex = 417
        '
        'nfilly
        '
        Me.nfilly.DecimalPlaces = 2
        Me.nfilly.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nfilly.Location = New System.Drawing.Point(49, 53)
        Me.nfilly.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nfilly.Minimum = New Decimal(New Integer() {2, 0, 0, -2147483648})
        Me.nfilly.Name = "nfilly"
        Me.nfilly.Size = New System.Drawing.Size(46, 20)
        Me.nfilly.TabIndex = 416
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(4, 102)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(44, 13)
        Me.Label43.TabIndex = 415
        Me.Label43.Text = "Y Scale"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(4, 82)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(44, 13)
        Me.Label44.TabIndex = 414
        Me.Label44.Text = "X Scale"
        '
        'nfillwidth
        '
        Me.nfillwidth.DecimalPlaces = 2
        Me.nfillwidth.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nfillwidth.Location = New System.Drawing.Point(49, 77)
        Me.nfillwidth.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nfillwidth.Name = "nfillwidth"
        Me.nfillwidth.Size = New System.Drawing.Size(46, 20)
        Me.nfillwidth.TabIndex = 413
        '
        'nfillheight
        '
        Me.nfillheight.DecimalPlaces = 2
        Me.nfillheight.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nfillheight.Location = New System.Drawing.Point(49, 101)
        Me.nfillheight.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nfillheight.Name = "nfillheight"
        Me.nfillheight.Size = New System.Drawing.Size(46, 20)
        Me.nfillheight.TabIndex = 412
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(33, 56)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(14, 13)
        Me.Label45.TabIndex = 410
        Me.Label45.Text = "Y"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(31, 35)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(14, 13)
        Me.Label46.TabIndex = 408
        Me.Label46.Text = "X"
        '
        'cmdfill
        '
        Me.cmdfill.Location = New System.Drawing.Point(98, 27)
        Me.cmdfill.Name = "cmdfill"
        Me.cmdfill.Size = New System.Drawing.Size(21, 94)
        Me.cmdfill.TabIndex = 407
        Me.cmdfill.Text = "R"
        Me.cmdfill.UseVisualStyleBackColor = True
        '
        'cmdmixerclear
        '
        Me.cmdmixerclear.Location = New System.Drawing.Point(523, 108)
        Me.cmdmixerclear.Name = "cmdmixerclear"
        Me.cmdmixerclear.Size = New System.Drawing.Size(54, 59)
        Me.cmdmixerclear.TabIndex = 402
        Me.cmdmixerclear.Text = "Reset  Mixer  Layer"
        Me.cmdmixerclear.UseVisualStyleBackColor = True
        '
        'gbothers
        '
        Me.gbothers.BackColor = System.Drawing.Color.Cornsilk
        Me.gbothers.Controls.Add(Me.nVolume)
        Me.gbothers.Controls.Add(Me.cmdVolume)
        Me.gbothers.Controls.Add(Me.Label41)
        Me.gbothers.Controls.Add(Me.nContrast)
        Me.gbothers.Controls.Add(Me.nSaturation)
        Me.gbothers.Controls.Add(Me.Label32)
        Me.gbothers.Controls.Add(Me.nbrightness)
        Me.gbothers.Controls.Add(Me.nopacity)
        Me.gbothers.Controls.Add(Me.cmdContrast)
        Me.gbothers.Controls.Add(Me.Label34)
        Me.gbothers.Controls.Add(Me.cmdSaturation)
        Me.gbothers.Controls.Add(Me.Label33)
        Me.gbothers.Controls.Add(Me.cmdbrightness)
        Me.gbothers.Controls.Add(Me.cmdopacity)
        Me.gbothers.Controls.Add(Me.Label31)
        Me.gbothers.Location = New System.Drawing.Point(11, 11)
        Me.gbothers.Name = "gbothers"
        Me.gbothers.Size = New System.Drawing.Size(149, 135)
        Me.gbothers.TabIndex = 420
        Me.gbothers.TabStop = False
        '
        'nVolume
        '
        Me.nVolume.DecimalPlaces = 1
        Me.nVolume.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nVolume.Location = New System.Drawing.Point(70, 13)
        Me.nVolume.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nVolume.Name = "nVolume"
        Me.nVolume.Size = New System.Drawing.Size(46, 20)
        Me.nVolume.TabIndex = 405
        '
        'cmdVolume
        '
        Me.cmdVolume.Location = New System.Drawing.Point(118, 11)
        Me.cmdVolume.Name = "cmdVolume"
        Me.cmdVolume.Size = New System.Drawing.Size(23, 22)
        Me.cmdVolume.TabIndex = 404
        Me.cmdVolume.Text = "RST"
        Me.cmdVolume.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(13, 15)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(42, 13)
        Me.Label41.TabIndex = 403
        Me.Label41.Text = "Volume"
        '
        'nContrast
        '
        Me.nContrast.DecimalPlaces = 1
        Me.nContrast.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nContrast.Location = New System.Drawing.Point(72, 109)
        Me.nContrast.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nContrast.Minimum = New Decimal(New Integer() {500, 0, 0, -2147483648})
        Me.nContrast.Name = "nContrast"
        Me.nContrast.Size = New System.Drawing.Size(46, 20)
        Me.nContrast.TabIndex = 395
        '
        'nSaturation
        '
        Me.nSaturation.DecimalPlaces = 1
        Me.nSaturation.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nSaturation.Location = New System.Drawing.Point(72, 84)
        Me.nSaturation.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nSaturation.Minimum = New Decimal(New Integer() {500, 0, 0, -2147483648})
        Me.nSaturation.Name = "nSaturation"
        Me.nSaturation.Size = New System.Drawing.Size(46, 20)
        Me.nSaturation.TabIndex = 394
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(6, 62)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(56, 13)
        Me.Label32.TabIndex = 376
        Me.Label32.Text = "Brightness"
        '
        'nbrightness
        '
        Me.nbrightness.DecimalPlaces = 1
        Me.nbrightness.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nbrightness.Location = New System.Drawing.Point(70, 60)
        Me.nbrightness.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nbrightness.Name = "nbrightness"
        Me.nbrightness.Size = New System.Drawing.Size(46, 20)
        Me.nbrightness.TabIndex = 393
        '
        'nopacity
        '
        Me.nopacity.DecimalPlaces = 1
        Me.nopacity.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nopacity.Location = New System.Drawing.Point(70, 35)
        Me.nopacity.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nopacity.Name = "nopacity"
        Me.nopacity.Size = New System.Drawing.Size(46, 20)
        Me.nopacity.TabIndex = 392
        '
        'cmdContrast
        '
        Me.cmdContrast.Location = New System.Drawing.Point(119, 107)
        Me.cmdContrast.Name = "cmdContrast"
        Me.cmdContrast.Size = New System.Drawing.Size(21, 23)
        Me.cmdContrast.TabIndex = 384
        Me.cmdContrast.Text = "Reset"
        Me.cmdContrast.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(13, 110)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(46, 13)
        Me.Label34.TabIndex = 382
        Me.Label34.Text = "Contrast"
        '
        'cmdSaturation
        '
        Me.cmdSaturation.Location = New System.Drawing.Point(119, 83)
        Me.cmdSaturation.Name = "cmdSaturation"
        Me.cmdSaturation.Size = New System.Drawing.Size(24, 19)
        Me.cmdSaturation.TabIndex = 381
        Me.cmdSaturation.Text = "Reset"
        Me.cmdSaturation.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(1, 86)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(55, 13)
        Me.Label33.TabIndex = 379
        Me.Label33.Text = "Saturation"
        '
        'cmdbrightness
        '
        Me.cmdbrightness.Location = New System.Drawing.Point(117, 58)
        Me.cmdbrightness.Name = "cmdbrightness"
        Me.cmdbrightness.Size = New System.Drawing.Size(23, 21)
        Me.cmdbrightness.TabIndex = 378
        Me.cmdbrightness.Text = "Reset"
        Me.cmdbrightness.UseVisualStyleBackColor = True
        '
        'cmdopacity
        '
        Me.cmdopacity.Location = New System.Drawing.Point(118, 33)
        Me.cmdopacity.Name = "cmdopacity"
        Me.cmdopacity.Size = New System.Drawing.Size(23, 22)
        Me.cmdopacity.TabIndex = 375
        Me.cmdopacity.Text = "RST"
        Me.cmdopacity.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(13, 37)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(43, 13)
        Me.Label31.TabIndex = 373
        Me.Label31.Text = "Opacity"
        '
        'cmdVerticalMobileToFullScreen
        '
        Me.cmdVerticalMobileToFullScreen.Location = New System.Drawing.Point(483, 466)
        Me.cmdVerticalMobileToFullScreen.Name = "cmdVerticalMobileToFullScreen"
        Me.cmdVerticalMobileToFullScreen.Size = New System.Drawing.Size(75, 55)
        Me.cmdVerticalMobileToFullScreen.TabIndex = 715
        Me.cmdVerticalMobileToFullScreen.Text = "Vertical Mobile To FullScreen"
        Me.cmdVerticalMobileToFullScreen.UseVisualStyleBackColor = True
        '
        'ucMixernew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.gbMixer)
        Me.Name = "ucMixernew"
        Me.Size = New System.Drawing.Size(591, 557)
        Me.gbMixer.ResumeLayout(False)
        Me.gbMixer.PerformLayout()
        Me.gbScalefromCenter.ResumeLayout(False)
        Me.gbScalefromCenter.PerformLayout()
        CType(Me.nscalexfromCenter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nscaleyfromCenter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmixermastervolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbcropmixer.ResumeLayout(False)
        Me.gbcropmixer.PerformLayout()
        CType(Me.ncropbrx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ncropbry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ncroptlx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ncroptly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbperspectivemixer.ResumeLayout(False)
        Me.gbperspectivemixer.PerformLayout()
        CType(Me.nperspectiveblx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nperspectivebly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nperspectivebrx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nperspectivebry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nperspectivetrx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nperspectivetry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nperspectivetlx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nperspectivetly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbrotationmixer.ResumeLayout(False)
        Me.gbrotationmixer.PerformLayout()
        CType(Me.nrotationz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbanchormixer.ResumeLayout(False)
        Me.gbanchormixer.PerformLayout()
        CType(Me.nanchorx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nanchory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbclip.ResumeLayout(False)
        Me.gbclip.PerformLayout()
        CType(Me.nclipx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nclipy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nclipxsclae, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nclipyscale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gblevels.ResumeLayout(False)
        Me.gblevels.PerformLayout()
        CType(Me.ngamma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmax_output, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmin_output, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmax_input, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmin_input, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbfill.ResumeLayout(False)
        Me.gbfill.PerformLayout()
        CType(Me.nfillx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nfilly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nfillwidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nfillheight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbothers.ResumeLayout(False)
        Me.gbothers.PerformLayout()
        CType(Me.nVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nContrast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nSaturation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nbrightness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nopacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbMixer As System.Windows.Forms.GroupBox
    Friend WithEvents nmixermastervolume As System.Windows.Forms.NumericUpDown
    Friend WithEvents gbcropmixer As System.Windows.Forms.GroupBox
    Friend WithEvents Label235 As System.Windows.Forms.Label
    Friend WithEvents Label234 As System.Windows.Forms.Label
    Friend WithEvents ncropbrx As System.Windows.Forms.NumericUpDown
    Friend WithEvents ncropbry As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label189 As System.Windows.Forms.Label
    Friend WithEvents Label193 As System.Windows.Forms.Label
    Friend WithEvents Label194 As System.Windows.Forms.Label
    Friend WithEvents ncroptlx As System.Windows.Forms.NumericUpDown
    Friend WithEvents ncroptly As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label199 As System.Windows.Forms.Label
    Friend WithEvents Label200 As System.Windows.Forms.Label
    Friend WithEvents Label198 As System.Windows.Forms.Label
    Friend WithEvents cmdresetcropmixer As System.Windows.Forms.Button
    Friend WithEvents chkmipmapmixer As System.Windows.Forms.CheckBox
    Friend WithEvents gbperspectivemixer As System.Windows.Forms.GroupBox
    Friend WithEvents Label186 As System.Windows.Forms.Label
    Friend WithEvents nperspectiveblx As System.Windows.Forms.NumericUpDown
    Friend WithEvents nperspectivebly As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label187 As System.Windows.Forms.Label
    Friend WithEvents Label188 As System.Windows.Forms.Label
    Friend WithEvents Label183 As System.Windows.Forms.Label
    Friend WithEvents nperspectivebrx As System.Windows.Forms.NumericUpDown
    Friend WithEvents nperspectivebry As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label184 As System.Windows.Forms.Label
    Friend WithEvents Label185 As System.Windows.Forms.Label
    Friend WithEvents Label180 As System.Windows.Forms.Label
    Friend WithEvents nperspectivetrx As System.Windows.Forms.NumericUpDown
    Friend WithEvents nperspectivetry As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label181 As System.Windows.Forms.Label
    Friend WithEvents Label182 As System.Windows.Forms.Label
    Friend WithEvents Label177 As System.Windows.Forms.Label
    Friend WithEvents nperspectivetlx As System.Windows.Forms.NumericUpDown
    Friend WithEvents nperspectivetly As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label111 As System.Windows.Forms.Label
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents cmdresetperspectivemixer As System.Windows.Forms.Button
    Friend WithEvents cmdgetstatusofmixer As System.Windows.Forms.Button
    Friend WithEvents gbrotationmixer As System.Windows.Forms.GroupBox
    Friend WithEvents Label176 As System.Windows.Forms.Label
    Friend WithEvents nrotationz As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdresetrotationmixer As System.Windows.Forms.Button
    Friend WithEvents gbanchormixer As System.Windows.Forms.GroupBox
    Friend WithEvents nanchorx As System.Windows.Forms.NumericUpDown
    Friend WithEvents nanchory As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label178 As System.Windows.Forms.Label
    Friend WithEvents Label179 As System.Windows.Forms.Label
    Friend WithEvents cmdresetanchormixer As System.Windows.Forms.Button
    Friend WithEvents cmdmixersettingopen As System.Windows.Forms.Button
    Friend WithEvents cmdmixersettingsave As System.Windows.Forms.Button
    Friend WithEvents cmdmastervolume As System.Windows.Forms.Button
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents cmdmixerclearformixemodule As System.Windows.Forms.Button
    Friend WithEvents cmbvideolayerformixer As System.Windows.Forms.ComboBox
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents cmbblend As System.Windows.Forms.ComboBox
    Friend WithEvents gbclip As System.Windows.Forms.GroupBox
    Friend WithEvents nclipx As System.Windows.Forms.NumericUpDown
    Friend WithEvents nclipy As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents nclipxsclae As System.Windows.Forms.NumericUpDown
    Friend WithEvents nclipyscale As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents cmdclipreset As System.Windows.Forms.Button
    Friend WithEvents gblevels As System.Windows.Forms.GroupBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents ngamma As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents nmax_output As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmin_output As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmax_input As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents nmin_input As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents cmdLevels As System.Windows.Forms.Button
    Friend WithEvents gbfill As System.Windows.Forms.GroupBox
    Friend WithEvents nfillx As System.Windows.Forms.NumericUpDown
    Friend WithEvents nfilly As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents nfillwidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents nfillheight As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents cmdfill As System.Windows.Forms.Button
    Friend WithEvents cmdmixerclear As System.Windows.Forms.Button
    Friend WithEvents gbothers As System.Windows.Forms.GroupBox
    Friend WithEvents nVolume As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdVolume As System.Windows.Forms.Button
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents nContrast As System.Windows.Forms.NumericUpDown
    Friend WithEvents nSaturation As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents nbrightness As System.Windows.Forms.NumericUpDown
    Friend WithEvents nopacity As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdContrast As System.Windows.Forms.Button
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cmdSaturation As System.Windows.Forms.Button
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cmdbrightness As System.Windows.Forms.Button
    Friend WithEvents cmdopacity As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents gbScalefromCenter As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nscalexfromCenter As NumericUpDown
    Friend WithEvents nscaleyfromCenter As NumericUpDown
    Friend WithEvents cmdResetScalefromCenter As Button
    Friend WithEvents cmdVerticalMobileToFullScreen As Button
End Class
