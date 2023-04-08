<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucHtmlScroller
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucHtmlScroller))
        Me.gbhtmlscroller = New System.Windows.Forms.GroupBox()
        Me.chkFlip = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdshowhtmlscroll = New System.Windows.Forms.Button()
        Me.cmdpauseresumehtmlscrollerhorizontal = New System.Windows.Forms.Button()
        Me.nyhtmlscroll = New System.Windows.Forms.NumericUpDown()
        Me.Label163 = New System.Windows.Forms.Label()
        Me.nyhtmlscrollticker = New System.Windows.Forms.NumericUpDown()
        Me.Label190 = New System.Windows.Forms.Label()
        Me.chkltrhtmlscroll = New System.Windows.Forms.CheckBox()
        Me.cmdstripcolorhtmlscroll = New System.Windows.Forms.Button()
        Me.Label162 = New System.Windows.Forms.Label()
        Me.Label161 = New System.Windows.Forms.Label()
        Me.pichtmlscroller = New System.Windows.Forms.PictureBox()
        Me.Label155 = New System.Windows.Forms.Label()
        Me.cmdFlip2ndChannel = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdfilehtmlscroll = New System.Windows.Forms.Button()
        Me.cmdstopcrawlhtmlscroll = New System.Windows.Forms.Button()
        Me.nspeedhtmlscroll = New System.Windows.Forms.NumericUpDown()
        Me.Label156 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nsizehtmlscroll = New System.Windows.Forms.NumericUpDown()
        Me.Label157 = New System.Windows.Forms.Label()
        Me.cmbfonthtmlscroll = New System.Windows.Forms.ComboBox()
        Me.Label164 = New System.Windows.Forms.Label()
        Me.chkbase64htmlscroller = New System.Windows.Forms.CheckBox()
        Me.cmblayerhtmlscroll = New System.Windows.Forms.ComboBox()
        Me.Label159 = New System.Windows.Forms.Label()
        Me.gbcropmixer = New System.Windows.Forms.GroupBox()
        Me.ncropbrx = New System.Windows.Forms.NumericUpDown()
        Me.Label189 = New System.Windows.Forms.Label()
        Me.Label194 = New System.Windows.Forms.Label()
        Me.ncroptlx = New System.Windows.Forms.NumericUpDown()
        Me.Label200 = New System.Windows.Forms.Label()
        Me.Label198 = New System.Windows.Forms.Label()
        Me.cmdresetcropmixer = New System.Windows.Forms.Button()
        Me.Label160 = New System.Windows.Forms.Label()
        Me.cmdcolorhtmlscroll = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdpauseresumehtmlscroller = New System.Windows.Forms.Button()
        Me.chkShuttlePro = New System.Windows.Forms.CheckBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.cmdstartFromMiddle = New System.Windows.Forms.Button()
        Me.cmdCueFromMiddle = New System.Windows.Forms.Button()
        Me.cmdCueFromButtom = New System.Windows.Forms.Button()
        Me.cmdupodateverticalscroll = New System.Windows.Forms.Button()
        Me.chkwebutility = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdStartFromButtom = New System.Windows.Forms.Button()
        Me.txthtmlscollerTemplatevertical = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txthtmlscollerTemplate = New System.Windows.Forms.TextBox()
        Me.Label158 = New System.Windows.Forms.Label()
        Me.txtcrawlhtmlscroll = New System.Windows.Forms.TextBox()
        Me.gbhtmlscroller.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nyhtmlscroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nyhtmlscrollticker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pichtmlscroller, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nspeedhtmlscroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nsizehtmlscroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbcropmixer.SuspendLayout()
        CType(Me.ncropbrx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ncroptlx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbhtmlscroller
        '
        Me.gbhtmlscroller.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gbhtmlscroller.Controls.Add(Me.chkFlip)
        Me.gbhtmlscroller.Controls.Add(Me.Button1)
        Me.gbhtmlscroller.Controls.Add(Me.GroupBox3)
        Me.gbhtmlscroller.Controls.Add(Me.cmdFlip2ndChannel)
        Me.gbhtmlscroller.Controls.Add(Me.GroupBox2)
        Me.gbhtmlscroller.Controls.Add(Me.Label4)
        Me.gbhtmlscroller.Controls.Add(Me.GroupBox1)
        Me.gbhtmlscroller.Controls.Add(Me.Label2)
        Me.gbhtmlscroller.Controls.Add(Me.txthtmlscollerTemplate)
        Me.gbhtmlscroller.Controls.Add(Me.Label158)
        Me.gbhtmlscroller.Controls.Add(Me.txtcrawlhtmlscroll)
        Me.gbhtmlscroller.Location = New System.Drawing.Point(2, 4)
        Me.gbhtmlscroller.Name = "gbhtmlscroller"
        Me.gbhtmlscroller.Size = New System.Drawing.Size(1212, 910)
        Me.gbhtmlscroller.TabIndex = 634
        Me.gbhtmlscroller.TabStop = False
        Me.gbhtmlscroller.Text = " "
        '
        'chkFlip
        '
        Me.chkFlip.AutoSize = True
        Me.chkFlip.Location = New System.Drawing.Point(680, 41)
        Me.chkFlip.Name = "chkFlip"
        Me.chkFlip.Size = New System.Drawing.Size(42, 17)
        Me.chkFlip.TabIndex = 751
        Me.chkFlip.Text = "Flip"
        Me.chkFlip.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(895, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(10, 892)
        Me.Button1.TabIndex = 750
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.cmdshowhtmlscroll)
        Me.GroupBox3.Controls.Add(Me.cmdpauseresumehtmlscrollerhorizontal)
        Me.GroupBox3.Controls.Add(Me.nyhtmlscroll)
        Me.GroupBox3.Controls.Add(Me.Label163)
        Me.GroupBox3.Controls.Add(Me.nyhtmlscrollticker)
        Me.GroupBox3.Controls.Add(Me.Label190)
        Me.GroupBox3.Controls.Add(Me.chkltrhtmlscroll)
        Me.GroupBox3.Controls.Add(Me.cmdstripcolorhtmlscroll)
        Me.GroupBox3.Controls.Add(Me.Label162)
        Me.GroupBox3.Controls.Add(Me.Label161)
        Me.GroupBox3.Controls.Add(Me.pichtmlscroller)
        Me.GroupBox3.Controls.Add(Me.Label155)
        Me.GroupBox3.Location = New System.Drawing.Point(910, 232)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(253, 175)
        Me.GroupBox3.TabIndex = 749
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Horozontal Scroll"
        '
        'cmdshowhtmlscroll
        '
        Me.cmdshowhtmlscroll.BackColor = System.Drawing.Color.Green
        Me.cmdshowhtmlscroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdshowhtmlscroll.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdshowhtmlscroll.Location = New System.Drawing.Point(2, 19)
        Me.cmdshowhtmlscroll.Name = "cmdshowhtmlscroll"
        Me.cmdshowhtmlscroll.Size = New System.Drawing.Size(76, 58)
        Me.cmdshowhtmlscroll.TabIndex = 262
        Me.cmdshowhtmlscroll.Text = "Start"
        Me.cmdshowhtmlscroll.UseVisualStyleBackColor = False
        '
        'cmdpauseresumehtmlscrollerhorizontal
        '
        Me.cmdpauseresumehtmlscrollerhorizontal.BackColor = System.Drawing.Color.Yellow
        Me.cmdpauseresumehtmlscrollerhorizontal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpauseresumehtmlscrollerhorizontal.Location = New System.Drawing.Point(79, 19)
        Me.cmdpauseresumehtmlscrollerhorizontal.Name = "cmdpauseresumehtmlscrollerhorizontal"
        Me.cmdpauseresumehtmlscrollerhorizontal.Size = New System.Drawing.Size(76, 55)
        Me.cmdpauseresumehtmlscrollerhorizontal.TabIndex = 739
        Me.cmdpauseresumehtmlscrollerhorizontal.Text = "Pause / Resume"
        Me.cmdpauseresumehtmlscrollerhorizontal.UseVisualStyleBackColor = False
        '
        'nyhtmlscroll
        '
        Me.nyhtmlscroll.Location = New System.Drawing.Point(84, 80)
        Me.nyhtmlscroll.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.nyhtmlscroll.Minimum = New Decimal(New Integer() {4000, 0, 0, -2147483648})
        Me.nyhtmlscroll.Name = "nyhtmlscroll"
        Me.nyhtmlscroll.Size = New System.Drawing.Size(41, 20)
        Me.nyhtmlscroll.TabIndex = 273
        Me.nyhtmlscroll.Value = New Decimal(New Integer() {87, 0, 0, 0})
        '
        'Label163
        '
        Me.Label163.AutoSize = True
        Me.Label163.Location = New System.Drawing.Point(3, 82)
        Me.Label163.Name = "Label163"
        Me.Label163.Size = New System.Drawing.Size(81, 13)
        Me.Label163.TabIndex = 271
        Me.Label163.Text = "Strip Y  Position"
        '
        'nyhtmlscrollticker
        '
        Me.nyhtmlscrollticker.Location = New System.Drawing.Point(93, 106)
        Me.nyhtmlscrollticker.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.nyhtmlscrollticker.Minimum = New Decimal(New Integer() {4000, 0, 0, -2147483648})
        Me.nyhtmlscrollticker.Name = "nyhtmlscrollticker"
        Me.nyhtmlscrollticker.Size = New System.Drawing.Size(41, 20)
        Me.nyhtmlscrollticker.TabIndex = 728
        Me.nyhtmlscrollticker.Value = New Decimal(New Integer() {87, 0, 0, 0})
        '
        'Label190
        '
        Me.Label190.AutoSize = True
        Me.Label190.Location = New System.Drawing.Point(4, 108)
        Me.Label190.Name = "Label190"
        Me.Label190.Size = New System.Drawing.Size(90, 13)
        Me.Label190.TabIndex = 727
        Me.Label190.Text = "Ticker Y  Position"
        '
        'chkltrhtmlscroll
        '
        Me.chkltrhtmlscroll.AutoSize = True
        Me.chkltrhtmlscroll.Location = New System.Drawing.Point(160, 19)
        Me.chkltrhtmlscroll.Name = "chkltrhtmlscroll"
        Me.chkltrhtmlscroll.Size = New System.Drawing.Size(88, 17)
        Me.chkltrhtmlscroll.TabIndex = 356
        Me.chkltrhtmlscroll.Text = "Left To Right"
        Me.chkltrhtmlscroll.UseVisualStyleBackColor = True
        '
        'cmdstripcolorhtmlscroll
        '
        Me.cmdstripcolorhtmlscroll.BackColor = System.Drawing.Color.Purple
        Me.cmdstripcolorhtmlscroll.ForeColor = System.Drawing.Color.Yellow
        Me.cmdstripcolorhtmlscroll.Location = New System.Drawing.Point(173, 67)
        Me.cmdstripcolorhtmlscroll.Name = "cmdstripcolorhtmlscroll"
        Me.cmdstripcolorhtmlscroll.Size = New System.Drawing.Size(59, 23)
        Me.cmdstripcolorhtmlscroll.TabIndex = 361
        Me.cmdstripcolorhtmlscroll.Text = "color"
        Me.cmdstripcolorhtmlscroll.UseVisualStyleBackColor = False
        '
        'Label162
        '
        Me.Label162.AutoSize = True
        Me.Label162.Location = New System.Drawing.Point(178, 51)
        Me.Label162.Name = "Label162"
        Me.Label162.Size = New System.Drawing.Size(54, 13)
        Me.Label162.TabIndex = 274
        Me.Label162.Text = "Strip color"
        '
        'Label161
        '
        Me.Label161.AutoSize = True
        Me.Label161.Location = New System.Drawing.Point(58, 176)
        Me.Label161.Name = "Label161"
        Me.Label161.Size = New System.Drawing.Size(0, 13)
        Me.Label161.TabIndex = 276
        '
        'pichtmlscroller
        '
        Me.pichtmlscroller.ImageLocation = "C:\Casparcg\mydata\html\dd.png"
        Me.pichtmlscroller.InitialImage = CType(resources.GetObject("pichtmlscroller.InitialImage"), System.Drawing.Image)
        Me.pichtmlscroller.Location = New System.Drawing.Point(174, 122)
        Me.pichtmlscroller.Name = "pichtmlscroller"
        Me.pichtmlscroller.Size = New System.Drawing.Size(54, 42)
        Me.pichtmlscroller.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pichtmlscroller.TabIndex = 363
        Me.pichtmlscroller.TabStop = False
        '
        'Label155
        '
        Me.Label155.AutoSize = True
        Me.Label155.Location = New System.Drawing.Point(180, 106)
        Me.Label155.Name = "Label155"
        Me.Label155.Size = New System.Drawing.Size(33, 13)
        Me.Label155.TabIndex = 364
        Me.Label155.Text = "Bullet"
        '
        'cmdFlip2ndChannel
        '
        Me.cmdFlip2ndChannel.Location = New System.Drawing.Point(680, 12)
        Me.cmdFlip2ndChannel.Name = "cmdFlip2ndChannel"
        Me.cmdFlip2ndChannel.Size = New System.Drawing.Size(146, 23)
        Me.cmdFlip2ndChannel.TabIndex = 748
        Me.cmdFlip2ndChannel.Text = "Show on Second Channel"
        Me.cmdFlip2ndChannel.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox2.Controls.Add(Me.cmdfilehtmlscroll)
        Me.GroupBox2.Controls.Add(Me.cmdstopcrawlhtmlscroll)
        Me.GroupBox2.Controls.Add(Me.nspeedhtmlscroll)
        Me.GroupBox2.Controls.Add(Me.Label156)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.nsizehtmlscroll)
        Me.GroupBox2.Controls.Add(Me.Label157)
        Me.GroupBox2.Controls.Add(Me.cmbfonthtmlscroll)
        Me.GroupBox2.Controls.Add(Me.Label164)
        Me.GroupBox2.Controls.Add(Me.chkbase64htmlscroller)
        Me.GroupBox2.Controls.Add(Me.cmblayerhtmlscroll)
        Me.GroupBox2.Controls.Add(Me.Label159)
        Me.GroupBox2.Controls.Add(Me.gbcropmixer)
        Me.GroupBox2.Controls.Add(Me.Label160)
        Me.GroupBox2.Controls.Add(Me.cmdcolorhtmlscroll)
        Me.GroupBox2.Location = New System.Drawing.Point(906, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 214)
        Me.GroupBox2.TabIndex = 746
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Common Controls"
        '
        'cmdfilehtmlscroll
        '
        Me.cmdfilehtmlscroll.Location = New System.Drawing.Point(7, 23)
        Me.cmdfilehtmlscroll.Name = "cmdfilehtmlscroll"
        Me.cmdfilehtmlscroll.Size = New System.Drawing.Size(69, 26)
        Me.cmdfilehtmlscroll.TabIndex = 269
        Me.cmdfilehtmlscroll.Text = "fileopen"
        Me.cmdfilehtmlscroll.UseVisualStyleBackColor = True
        '
        'cmdstopcrawlhtmlscroll
        '
        Me.cmdstopcrawlhtmlscroll.BackColor = System.Drawing.Color.Red
        Me.cmdstopcrawlhtmlscroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopcrawlhtmlscroll.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdstopcrawlhtmlscroll.Location = New System.Drawing.Point(11, 161)
        Me.cmdstopcrawlhtmlscroll.Name = "cmdstopcrawlhtmlscroll"
        Me.cmdstopcrawlhtmlscroll.Size = New System.Drawing.Size(136, 47)
        Me.cmdstopcrawlhtmlscroll.TabIndex = 263
        Me.cmdstopcrawlhtmlscroll.Text = "Stop"
        Me.cmdstopcrawlhtmlscroll.UseVisualStyleBackColor = False
        '
        'nspeedhtmlscroll
        '
        Me.nspeedhtmlscroll.Location = New System.Drawing.Point(46, 78)
        Me.nspeedhtmlscroll.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nspeedhtmlscroll.Name = "nspeedhtmlscroll"
        Me.nspeedhtmlscroll.Size = New System.Drawing.Size(54, 20)
        Me.nspeedhtmlscroll.TabIndex = 268
        Me.nspeedhtmlscroll.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label156
        '
        Me.Label156.AutoSize = True
        Me.Label156.Location = New System.Drawing.Point(8, 81)
        Me.Label156.Name = "Label156"
        Me.Label156.Size = New System.Drawing.Size(38, 13)
        Me.Label156.TabIndex = 360
        Me.Label156.Text = "Speed"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 731
        Me.Label1.Text = "font color"
        '
        'nsizehtmlscroll
        '
        Me.nsizehtmlscroll.Location = New System.Drawing.Point(46, 52)
        Me.nsizehtmlscroll.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nsizehtmlscroll.Name = "nsizehtmlscroll"
        Me.nsizehtmlscroll.Size = New System.Drawing.Size(54, 20)
        Me.nsizehtmlscroll.TabIndex = 266
        Me.nsizehtmlscroll.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label157
        '
        Me.Label157.AutoSize = True
        Me.Label157.Location = New System.Drawing.Point(13, 55)
        Me.Label157.Name = "Label157"
        Me.Label157.Size = New System.Drawing.Size(27, 13)
        Me.Label157.TabIndex = 359
        Me.Label157.Text = "Size"
        '
        'cmbfonthtmlscroll
        '
        Me.cmbfonthtmlscroll.FormattingEnabled = True
        Me.cmbfonthtmlscroll.Location = New System.Drawing.Point(53, 105)
        Me.cmbfonthtmlscroll.Name = "cmbfonthtmlscroll"
        Me.cmbfonthtmlscroll.Size = New System.Drawing.Size(116, 21)
        Me.cmbfonthtmlscroll.TabIndex = 312
        Me.cmbfonthtmlscroll.Text = "DVOT-Bhima"
        '
        'Label164
        '
        Me.Label164.AutoSize = True
        Me.Label164.Location = New System.Drawing.Point(112, 137)
        Me.Label164.Name = "Label164"
        Me.Label164.Size = New System.Drawing.Size(0, 13)
        Me.Label164.TabIndex = 270
        '
        'chkbase64htmlscroller
        '
        Me.chkbase64htmlscroller.AutoSize = True
        Me.chkbase64htmlscroller.Location = New System.Drawing.Point(182, 114)
        Me.chkbase64htmlscroller.Name = "chkbase64htmlscroller"
        Me.chkbase64htmlscroller.Size = New System.Drawing.Size(62, 17)
        Me.chkbase64htmlscroller.TabIndex = 729
        Me.chkbase64htmlscroller.Text = "Base64"
        Me.chkbase64htmlscroller.UseVisualStyleBackColor = True
        '
        'cmblayerhtmlscroll
        '
        Me.cmblayerhtmlscroll.FormattingEnabled = True
        Me.cmblayerhtmlscroll.Items.AddRange(New Object() {"210", "211", "212", "213", "214"})
        Me.cmblayerhtmlscroll.Location = New System.Drawing.Point(187, 142)
        Me.cmblayerhtmlscroll.Name = "cmblayerhtmlscroll"
        Me.cmblayerhtmlscroll.Size = New System.Drawing.Size(59, 21)
        Me.cmblayerhtmlscroll.TabIndex = 322
        Me.cmblayerhtmlscroll.Text = "210"
        '
        'Label159
        '
        Me.Label159.AutoSize = True
        Me.Label159.Location = New System.Drawing.Point(150, 145)
        Me.Label159.Name = "Label159"
        Me.Label159.Size = New System.Drawing.Size(20, 13)
        Me.Label159.TabIndex = 321
        Me.Label159.Text = "VL"
        '
        'gbcropmixer
        '
        Me.gbcropmixer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbcropmixer.Controls.Add(Me.ncropbrx)
        Me.gbcropmixer.Controls.Add(Me.Label189)
        Me.gbcropmixer.Controls.Add(Me.Label194)
        Me.gbcropmixer.Controls.Add(Me.ncroptlx)
        Me.gbcropmixer.Controls.Add(Me.Label200)
        Me.gbcropmixer.Controls.Add(Me.Label198)
        Me.gbcropmixer.Controls.Add(Me.cmdresetcropmixer)
        Me.gbcropmixer.Location = New System.Drawing.Point(134, 6)
        Me.gbcropmixer.Name = "gbcropmixer"
        Me.gbcropmixer.Size = New System.Drawing.Size(110, 97)
        Me.gbcropmixer.TabIndex = 730
        Me.gbcropmixer.TabStop = False
        Me.gbcropmixer.Text = "Crop"
        '
        'ncropbrx
        '
        Me.ncropbrx.DecimalPlaces = 2
        Me.ncropbrx.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.ncropbrx.Location = New System.Drawing.Point(28, 69)
        Me.ncropbrx.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.ncropbrx.Name = "ncropbrx"
        Me.ncropbrx.Size = New System.Drawing.Size(46, 20)
        Me.ncropbrx.TabIndex = 427
        Me.ncropbrx.Value = Global.caspar_media_playback.My.MySettings.Default.ncropbrx
        '
        'Label189
        '
        Me.Label189.AutoSize = True
        Me.Label189.Location = New System.Drawing.Point(29, 53)
        Me.Label189.Name = "Label189"
        Me.Label189.Size = New System.Drawing.Size(35, 13)
        Me.Label189.TabIndex = 433
        Me.Label189.Text = " Right"
        '
        'Label194
        '
        Me.Label194.AutoSize = True
        Me.Label194.Location = New System.Drawing.Point(10, 73)
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
        Me.ncroptlx.Value = Global.caspar_media_playback.My.MySettings.Default.ncroptlx
        '
        'Label200
        '
        Me.Label200.AutoSize = True
        Me.Label200.Location = New System.Drawing.Point(9, 32)
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
        Me.cmdresetcropmixer.Location = New System.Drawing.Point(77, 28)
        Me.cmdresetcropmixer.Name = "cmdresetcropmixer"
        Me.cmdresetcropmixer.Size = New System.Drawing.Size(21, 58)
        Me.cmdresetcropmixer.TabIndex = 407
        Me.cmdresetcropmixer.Text = "R"
        Me.cmdresetcropmixer.UseVisualStyleBackColor = True
        '
        'Label160
        '
        Me.Label160.AutoSize = True
        Me.Label160.Location = New System.Drawing.Point(12, 109)
        Me.Label160.Name = "Label160"
        Me.Label160.Size = New System.Drawing.Size(28, 13)
        Me.Label160.TabIndex = 311
        Me.Label160.Text = "Font"
        '
        'cmdcolorhtmlscroll
        '
        Me.cmdcolorhtmlscroll.BackColor = System.Drawing.Color.Purple
        Me.cmdcolorhtmlscroll.ForeColor = System.Drawing.Color.Yellow
        Me.cmdcolorhtmlscroll.Location = New System.Drawing.Point(61, 132)
        Me.cmdcolorhtmlscroll.Name = "cmdcolorhtmlscroll"
        Me.cmdcolorhtmlscroll.Size = New System.Drawing.Size(59, 23)
        Me.cmdcolorhtmlscroll.TabIndex = 362
        Me.cmdcolorhtmlscroll.Text = "Color"
        Me.cmdcolorhtmlscroll.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 745
        Me.Label4.Text = "Scroll Text"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmdpauseresumehtmlscroller)
        Me.GroupBox1.Controls.Add(Me.chkShuttlePro)
        Me.GroupBox1.Controls.Add(Me.TrackBar1)
        Me.GroupBox1.Controls.Add(Me.cmdstartFromMiddle)
        Me.GroupBox1.Controls.Add(Me.cmdCueFromMiddle)
        Me.GroupBox1.Controls.Add(Me.cmdCueFromButtom)
        Me.GroupBox1.Controls.Add(Me.cmdupodateverticalscroll)
        Me.GroupBox1.Controls.Add(Me.chkwebutility)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmdStartFromButtom)
        Me.GroupBox1.Controls.Add(Me.txthtmlscollerTemplatevertical)
        Me.GroupBox1.Location = New System.Drawing.Point(912, 413)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 474)
        Me.GroupBox1.TabIndex = 737
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vertical Scroll"
        '
        'cmdpauseresumehtmlscroller
        '
        Me.cmdpauseresumehtmlscroller.BackColor = System.Drawing.Color.Yellow
        Me.cmdpauseresumehtmlscroller.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmdpauseresumehtmlscroller.Location = New System.Drawing.Point(153, 22)
        Me.cmdpauseresumehtmlscroller.Name = "cmdpauseresumehtmlscroller"
        Me.cmdpauseresumehtmlscroller.Size = New System.Drawing.Size(70, 46)
        Me.cmdpauseresumehtmlscroller.TabIndex = 738
        Me.cmdpauseresumehtmlscroller.Text = "Pause / Resume"
        Me.cmdpauseresumehtmlscroller.UseVisualStyleBackColor = False
        '
        'chkShuttlePro
        '
        Me.chkShuttlePro.AutoSize = True
        Me.chkShuttlePro.Location = New System.Drawing.Point(4, 130)
        Me.chkShuttlePro.Name = "chkShuttlePro"
        Me.chkShuttlePro.Size = New System.Drawing.Size(78, 17)
        Me.chkShuttlePro.TabIndex = 745
        Me.chkShuttlePro.Text = "Shuttle Pro"
        Me.chkShuttlePro.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(2, 236)
        Me.TrackBar1.Maximum = 20
        Me.TrackBar1.Minimum = -20
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(233, 45)
        Me.TrackBar1.TabIndex = 744
        '
        'cmdstartFromMiddle
        '
        Me.cmdstartFromMiddle.BackColor = System.Drawing.Color.Green
        Me.cmdstartFromMiddle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstartFromMiddle.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdstartFromMiddle.Location = New System.Drawing.Point(70, 19)
        Me.cmdstartFromMiddle.Name = "cmdstartFromMiddle"
        Me.cmdstartFromMiddle.Size = New System.Drawing.Size(71, 47)
        Me.cmdstartFromMiddle.TabIndex = 743
        Me.cmdstartFromMiddle.Text = "Start Fom Middle"
        Me.cmdstartFromMiddle.UseVisualStyleBackColor = False
        '
        'cmdCueFromMiddle
        '
        Me.cmdCueFromMiddle.BackColor = System.Drawing.Color.Green
        Me.cmdCueFromMiddle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCueFromMiddle.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdCueFromMiddle.Location = New System.Drawing.Point(76, 73)
        Me.cmdCueFromMiddle.Name = "cmdCueFromMiddle"
        Me.cmdCueFromMiddle.Size = New System.Drawing.Size(68, 47)
        Me.cmdCueFromMiddle.TabIndex = 742
        Me.cmdCueFromMiddle.Text = "Cue From Middle"
        Me.cmdCueFromMiddle.UseVisualStyleBackColor = False
        '
        'cmdCueFromButtom
        '
        Me.cmdCueFromButtom.BackColor = System.Drawing.Color.Green
        Me.cmdCueFromButtom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCueFromButtom.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdCueFromButtom.Location = New System.Drawing.Point(6, 73)
        Me.cmdCueFromButtom.Name = "cmdCueFromButtom"
        Me.cmdCueFromButtom.Size = New System.Drawing.Size(62, 47)
        Me.cmdCueFromButtom.TabIndex = 741
        Me.cmdCueFromButtom.Text = "Cue From Buttom"
        Me.cmdCueFromButtom.UseVisualStyleBackColor = False
        '
        'cmdupodateverticalscroll
        '
        Me.cmdupodateverticalscroll.Location = New System.Drawing.Point(156, 74)
        Me.cmdupodateverticalscroll.Name = "cmdupodateverticalscroll"
        Me.cmdupodateverticalscroll.Size = New System.Drawing.Size(70, 50)
        Me.cmdupodateverticalscroll.TabIndex = 738
        Me.cmdupodateverticalscroll.Text = "Update"
        Me.cmdupodateverticalscroll.UseVisualStyleBackColor = True
        '
        'chkwebutility
        '
        Me.chkwebutility.AutoSize = True
        Me.chkwebutility.Location = New System.Drawing.Point(0, 210)
        Me.chkwebutility.Name = "chkwebutility"
        Me.chkwebutility.Size = New System.Drawing.Size(162, 17)
        Me.chkwebutility.TabIndex = 737
        Me.chkwebutility.Text = "Check for Non Unicode Font"
        Me.chkwebutility.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 736
        Me.Label3.Text = "Html Template"
        '
        'cmdStartFromButtom
        '
        Me.cmdStartFromButtom.BackColor = System.Drawing.Color.Green
        Me.cmdStartFromButtom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStartFromButtom.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdStartFromButtom.Location = New System.Drawing.Point(6, 20)
        Me.cmdStartFromButtom.Name = "cmdStartFromButtom"
        Me.cmdStartFromButtom.Size = New System.Drawing.Size(62, 47)
        Me.cmdStartFromButtom.TabIndex = 734
        Me.cmdStartFromButtom.Text = "Start Fom Buttom"
        Me.cmdStartFromButtom.UseVisualStyleBackColor = False
        '
        'txthtmlscollerTemplatevertical
        '
        Me.txthtmlscollerTemplatevertical.Location = New System.Drawing.Point(5, 175)
        Me.txthtmlscollerTemplatevertical.Name = "txthtmlscollerTemplatevertical"
        Me.txthtmlscollerTemplatevertical.Size = New System.Drawing.Size(239, 20)
        Me.txthtmlscollerTemplatevertical.TabIndex = 735
        Me.txthtmlscollerTemplatevertical.Text = "file:///C:/casparcg/mydata/html/vertical.html"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 733
        Me.Label2.Text = "Template"
        '
        'txthtmlscollerTemplate
        '
        Me.txthtmlscollerTemplate.Location = New System.Drawing.Point(70, 19)
        Me.txthtmlscollerTemplate.Name = "txthtmlscollerTemplate"
        Me.txthtmlscollerTemplate.Size = New System.Drawing.Size(353, 20)
        Me.txthtmlscollerTemplate.TabIndex = 732
        Me.txthtmlscollerTemplate.Text = "file:///C:/casparcg/mydata/html/htmlscroller.html"
        '
        'Label158
        '
        Me.Label158.AutoSize = True
        Me.Label158.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label158.ForeColor = System.Drawing.Color.Red
        Me.Label158.Location = New System.Drawing.Point(8, 47)
        Me.Label158.Name = "Label158"
        Me.Label158.Size = New System.Drawing.Size(505, 32)
        Me.Label158.TabIndex = 357
        Me.Label158.Text = "If Content is not comming properly-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Copy the content to notepad++ and Then copy " &
    "from there and paste here"
        '
        'txtcrawlhtmlscroll
        '
        Me.txtcrawlhtmlscroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcrawlhtmlscroll.Location = New System.Drawing.Point(6, 103)
        Me.txtcrawlhtmlscroll.Multiline = True
        Me.txtcrawlhtmlscroll.Name = "txtcrawlhtmlscroll"
        Me.txtcrawlhtmlscroll.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtcrawlhtmlscroll.Size = New System.Drawing.Size(885, 784)
        Me.txtcrawlhtmlscroll.TabIndex = 261
        Me.txtcrawlhtmlscroll.Text = resources.GetString("txtcrawlhtmlscroll.Text")
        '
        'ucHtmlScroller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1208, 921)
        Me.Controls.Add(Me.gbhtmlscroller)
        Me.HideOnClose = True
        Me.KeyPreview = True
        Me.Name = "ucHtmlScroller"
        Me.Text = "HTML Scroller"
        Me.gbhtmlscroller.ResumeLayout(False)
        Me.gbhtmlscroller.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nyhtmlscroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nyhtmlscrollticker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pichtmlscroller, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nspeedhtmlscroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nsizehtmlscroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbcropmixer.ResumeLayout(False)
        Me.gbcropmixer.PerformLayout()
        CType(Me.ncropbrx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ncroptlx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbhtmlscroller As System.Windows.Forms.GroupBox
    Friend WithEvents chkbase64htmlscroller As System.Windows.Forms.CheckBox
    Friend WithEvents nyhtmlscrollticker As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label190 As System.Windows.Forms.Label
    Friend WithEvents Label155 As System.Windows.Forms.Label
    Friend WithEvents pichtmlscroller As System.Windows.Forms.PictureBox
    Friend WithEvents cmdcolorhtmlscroll As System.Windows.Forms.Button
    Friend WithEvents cmdstripcolorhtmlscroll As System.Windows.Forms.Button
    Friend WithEvents Label156 As System.Windows.Forms.Label
    Friend WithEvents Label157 As System.Windows.Forms.Label
    Friend WithEvents Label158 As System.Windows.Forms.Label
    Friend WithEvents chkltrhtmlscroll As System.Windows.Forms.CheckBox
    Friend WithEvents cmblayerhtmlscroll As System.Windows.Forms.ComboBox
    Friend WithEvents Label159 As System.Windows.Forms.Label
    Friend WithEvents cmbfonthtmlscroll As System.Windows.Forms.ComboBox
    Friend WithEvents Label160 As System.Windows.Forms.Label
    Friend WithEvents Label161 As System.Windows.Forms.Label
    Friend WithEvents Label162 As System.Windows.Forms.Label
    Friend WithEvents nyhtmlscroll As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label163 As System.Windows.Forms.Label
    Friend WithEvents Label164 As System.Windows.Forms.Label
    Friend WithEvents cmdfilehtmlscroll As System.Windows.Forms.Button
    Friend WithEvents nspeedhtmlscroll As System.Windows.Forms.NumericUpDown
    Friend WithEvents nsizehtmlscroll As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdstopcrawlhtmlscroll As System.Windows.Forms.Button
    Friend WithEvents cmdshowhtmlscroll As System.Windows.Forms.Button
    Friend WithEvents txtcrawlhtmlscroll As System.Windows.Forms.TextBox
    Friend WithEvents gbcropmixer As GroupBox
    Friend WithEvents ncropbrx As NumericUpDown
    Friend WithEvents Label189 As Label
    Friend WithEvents Label194 As Label
    Friend WithEvents ncroptlx As NumericUpDown
    Friend WithEvents Label200 As Label
    Friend WithEvents Label198 As Label
    Friend WithEvents cmdresetcropmixer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txthtmlscollerTemplate As TextBox
    Friend WithEvents cmdStartFromButtom As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txthtmlscollerTemplatevertical As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdpauseresumehtmlscroller As Button
    Friend WithEvents chkwebutility As CheckBox
    Friend WithEvents cmdupodateverticalscroll As Button
    Friend WithEvents cmdCueFromMiddle As Button
    Friend WithEvents cmdCueFromButtom As Button
    Friend WithEvents cmdstartFromMiddle As Button
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkShuttlePro As CheckBox
    Friend WithEvents cmdpauseresumehtmlscrollerhorizontal As Button
    Friend WithEvents cmdFlip2ndChannel As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkFlip As CheckBox
End Class
