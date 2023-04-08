<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucMultiBulletScroll
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucMultiBulletScroll))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbscroll = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkAutoUpdate = New System.Windows.Forms.CheckBox()
        Me.cmdstopcrawlhtmlscroll = New System.Windows.Forms.Button()
        Me.cmdpauseresumehtmlscroller = New System.Windows.Forms.Button()
        Me.Label156 = New System.Windows.Forms.Label()
        Me.cmbfonthtmlscroll = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label157 = New System.Windows.Forms.Label()
        Me.Label160 = New System.Windows.Forms.Label()
        Me.nspeedhtmlscroll = New System.Windows.Forms.NumericUpDown()
        Me.nsizehtmlscroll = New System.Windows.Forms.NumericUpDown()
        Me.cmdcolorhtmlscroll = New System.Windows.Forms.Button()
        Me.chkbase64htmlscroller = New System.Windows.Forms.CheckBox()
        Me.nyhtmlscrollticker = New System.Windows.Forms.NumericUpDown()
        Me.Label190 = New System.Windows.Forms.Label()
        Me.cmdstripcolorhtmlscroll = New System.Windows.Forms.Button()
        Me.chkltrhtmlscroll = New System.Windows.Forms.CheckBox()
        Me.Label161 = New System.Windows.Forms.Label()
        Me.Label162 = New System.Windows.Forms.Label()
        Me.nyhtmlscroll = New System.Windows.Forms.NumericUpDown()
        Me.Label163 = New System.Windows.Forms.Label()
        Me.cmdPlayMultibulletHtml = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txmultibulletscrollerTemplate = New System.Windows.Forms.TextBox()
        Me.ntextY = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdselectallforscroll = New System.Windows.Forms.Button()
        Me.cmddeselectallforscroll = New System.Windows.Forms.Button()
        Me.cmdpausescroll = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtclockTemplate = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.cmblayertime = New System.Windows.Forms.ComboBox()
        Me.cmdhidetime = New System.Windows.Forms.Button()
        Me.cmdshowtime = New System.Windows.Forms.Button()
        Me.cmdplayscroll = New System.Windows.Forms.Button()
        Me.cmdstopscroll = New System.Windows.Forms.Button()
        Me.cmddeletetsscroll = New System.Windows.Forms.Button()
        Me.cmduptsscroll = New System.Windows.Forms.Button()
        Me.cmddowntsscroll = New System.Windows.Forms.Button()
        Me.cmdinserttsscroll = New System.Windows.Forms.Button()
        Me.dgvscroll = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IMG = New System.Windows.Forms.DataGridViewImageColumn()
        Me.nspeedscroll = New System.Windows.Forms.NumericUpDown()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmblayerscroll = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tmrshowdatascroll = New System.Windows.Forms.Timer(Me.components)
        Me.tmrshowdatascrollHtml = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbscroll.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nspeedhtmlscroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nsizehtmlscroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nyhtmlscrollticker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nyhtmlscroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ntextY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvscroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nspeedscroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbscroll
        '
        Me.gbscroll.BackColor = System.Drawing.Color.Bisque
        Me.gbscroll.Controls.Add(Me.GroupBox1)
        Me.gbscroll.Controls.Add(Me.MenuStrip1)
        Me.gbscroll.Controls.Add(Me.Label2)
        Me.gbscroll.Controls.Add(Me.txmultibulletscrollerTemplate)
        Me.gbscroll.Controls.Add(Me.ntextY)
        Me.gbscroll.Controls.Add(Me.Label1)
        Me.gbscroll.Controls.Add(Me.cmdselectallforscroll)
        Me.gbscroll.Controls.Add(Me.cmddeselectallforscroll)
        Me.gbscroll.Controls.Add(Me.cmdpausescroll)
        Me.gbscroll.Controls.Add(Me.GroupBox2)
        Me.gbscroll.Controls.Add(Me.cmdplayscroll)
        Me.gbscroll.Controls.Add(Me.cmdstopscroll)
        Me.gbscroll.Controls.Add(Me.cmddeletetsscroll)
        Me.gbscroll.Controls.Add(Me.cmduptsscroll)
        Me.gbscroll.Controls.Add(Me.cmddowntsscroll)
        Me.gbscroll.Controls.Add(Me.cmdinserttsscroll)
        Me.gbscroll.Controls.Add(Me.dgvscroll)
        Me.gbscroll.Controls.Add(Me.nspeedscroll)
        Me.gbscroll.Controls.Add(Me.Label20)
        Me.gbscroll.Controls.Add(Me.cmblayerscroll)
        Me.gbscroll.Controls.Add(Me.Label21)
        Me.gbscroll.Location = New System.Drawing.Point(4, 5)
        Me.gbscroll.Name = "gbscroll"
        Me.gbscroll.Size = New System.Drawing.Size(660, 605)
        Me.gbscroll.TabIndex = 533
        Me.gbscroll.TabStop = False
        Me.gbscroll.Text = " "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Peru
        Me.GroupBox1.Controls.Add(Me.chkAutoUpdate)
        Me.GroupBox1.Controls.Add(Me.cmdstopcrawlhtmlscroll)
        Me.GroupBox1.Controls.Add(Me.cmdpauseresumehtmlscroller)
        Me.GroupBox1.Controls.Add(Me.Label156)
        Me.GroupBox1.Controls.Add(Me.cmbfonthtmlscroll)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label157)
        Me.GroupBox1.Controls.Add(Me.Label160)
        Me.GroupBox1.Controls.Add(Me.nspeedhtmlscroll)
        Me.GroupBox1.Controls.Add(Me.nsizehtmlscroll)
        Me.GroupBox1.Controls.Add(Me.cmdcolorhtmlscroll)
        Me.GroupBox1.Controls.Add(Me.chkbase64htmlscroller)
        Me.GroupBox1.Controls.Add(Me.nyhtmlscrollticker)
        Me.GroupBox1.Controls.Add(Me.Label190)
        Me.GroupBox1.Controls.Add(Me.cmdstripcolorhtmlscroll)
        Me.GroupBox1.Controls.Add(Me.chkltrhtmlscroll)
        Me.GroupBox1.Controls.Add(Me.Label161)
        Me.GroupBox1.Controls.Add(Me.Label162)
        Me.GroupBox1.Controls.Add(Me.nyhtmlscroll)
        Me.GroupBox1.Controls.Add(Me.Label163)
        Me.GroupBox1.Controls.Add(Me.cmdPlayMultibulletHtml)
        Me.GroupBox1.Location = New System.Drawing.Point(366, 417)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 182)
        Me.GroupBox1.TabIndex = 750
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HTML Template"
        '
        'chkAutoUpdate
        '
        Me.chkAutoUpdate.AutoSize = True
        Me.chkAutoUpdate.Location = New System.Drawing.Point(8, 78)
        Me.chkAutoUpdate.Name = "chkAutoUpdate"
        Me.chkAutoUpdate.Size = New System.Drawing.Size(83, 17)
        Me.chkAutoUpdate.TabIndex = 753
        Me.chkAutoUpdate.Text = "AutoUpdate"
        Me.chkAutoUpdate.UseVisualStyleBackColor = True
        '
        'cmdstopcrawlhtmlscroll
        '
        Me.cmdstopcrawlhtmlscroll.BackColor = System.Drawing.Color.Red
        Me.cmdstopcrawlhtmlscroll.ForeColor = System.Drawing.Color.White
        Me.cmdstopcrawlhtmlscroll.Location = New System.Drawing.Point(222, 91)
        Me.cmdstopcrawlhtmlscroll.Name = "cmdstopcrawlhtmlscroll"
        Me.cmdstopcrawlhtmlscroll.Size = New System.Drawing.Size(60, 40)
        Me.cmdstopcrawlhtmlscroll.TabIndex = 751
        Me.cmdstopcrawlhtmlscroll.Text = "Stop"
        Me.cmdstopcrawlhtmlscroll.UseVisualStyleBackColor = False
        '
        'cmdpauseresumehtmlscroller
        '
        Me.cmdpauseresumehtmlscroller.BackColor = System.Drawing.Color.Yellow
        Me.cmdpauseresumehtmlscroller.Location = New System.Drawing.Point(222, 48)
        Me.cmdpauseresumehtmlscroller.Name = "cmdpauseresumehtmlscroller"
        Me.cmdpauseresumehtmlscroller.Size = New System.Drawing.Size(60, 40)
        Me.cmdpauseresumehtmlscroller.TabIndex = 752
        Me.cmdpauseresumehtmlscroller.Text = "Pause / Resume"
        Me.cmdpauseresumehtmlscroller.UseVisualStyleBackColor = False
        '
        'Label156
        '
        Me.Label156.AutoSize = True
        Me.Label156.Location = New System.Drawing.Point(110, 134)
        Me.Label156.Name = "Label156"
        Me.Label156.Size = New System.Drawing.Size(38, 13)
        Me.Label156.TabIndex = 748
        Me.Label156.Text = "Speed"
        '
        'cmbfonthtmlscroll
        '
        Me.cmbfonthtmlscroll.FormattingEnabled = True
        Me.cmbfonthtmlscroll.Location = New System.Drawing.Point(98, 157)
        Me.cmbfonthtmlscroll.Name = "cmbfonthtmlscroll"
        Me.cmbfonthtmlscroll.Size = New System.Drawing.Size(116, 21)
        Me.cmbfonthtmlscroll.TabIndex = 743
        Me.cmbfonthtmlscroll.Text = "DVOT-Bhima"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(97, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 749
        Me.Label4.Text = "font color"
        '
        'Label157
        '
        Me.Label157.AutoSize = True
        Me.Label157.Location = New System.Drawing.Point(121, 108)
        Me.Label157.Name = "Label157"
        Me.Label157.Size = New System.Drawing.Size(27, 13)
        Me.Label157.TabIndex = 747
        Me.Label157.Text = "Size"
        '
        'Label160
        '
        Me.Label160.AutoSize = True
        Me.Label160.Location = New System.Drawing.Point(55, 157)
        Me.Label160.Name = "Label160"
        Me.Label160.Size = New System.Drawing.Size(28, 13)
        Me.Label160.TabIndex = 746
        Me.Label160.Text = "Font"
        '
        'nspeedhtmlscroll
        '
        Me.nspeedhtmlscroll.Location = New System.Drawing.Point(160, 131)
        Me.nspeedhtmlscroll.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nspeedhtmlscroll.Name = "nspeedhtmlscroll"
        Me.nspeedhtmlscroll.Size = New System.Drawing.Size(54, 20)
        Me.nspeedhtmlscroll.TabIndex = 742
        Me.nspeedhtmlscroll.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'nsizehtmlscroll
        '
        Me.nsizehtmlscroll.Location = New System.Drawing.Point(160, 105)
        Me.nsizehtmlscroll.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nsizehtmlscroll.Name = "nsizehtmlscroll"
        Me.nsizehtmlscroll.Size = New System.Drawing.Size(54, 20)
        Me.nsizehtmlscroll.TabIndex = 741
        Me.nsizehtmlscroll.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'cmdcolorhtmlscroll
        '
        Me.cmdcolorhtmlscroll.BackColor = System.Drawing.Color.Purple
        Me.cmdcolorhtmlscroll.ForeColor = System.Drawing.Color.Yellow
        Me.cmdcolorhtmlscroll.Location = New System.Drawing.Point(160, 81)
        Me.cmdcolorhtmlscroll.Name = "cmdcolorhtmlscroll"
        Me.cmdcolorhtmlscroll.Size = New System.Drawing.Size(54, 23)
        Me.cmdcolorhtmlscroll.TabIndex = 744
        Me.cmdcolorhtmlscroll.Text = "Color"
        Me.cmdcolorhtmlscroll.UseVisualStyleBackColor = False
        '
        'chkbase64htmlscroller
        '
        Me.chkbase64htmlscroller.AutoSize = True
        Me.chkbase64htmlscroller.Location = New System.Drawing.Point(6, 106)
        Me.chkbase64htmlscroller.Name = "chkbase64htmlscroller"
        Me.chkbase64htmlscroller.Size = New System.Drawing.Size(62, 17)
        Me.chkbase64htmlscroller.TabIndex = 740
        Me.chkbase64htmlscroller.Text = "Base64"
        Me.chkbase64htmlscroller.UseVisualStyleBackColor = True
        '
        'nyhtmlscrollticker
        '
        Me.nyhtmlscrollticker.Location = New System.Drawing.Point(160, 35)
        Me.nyhtmlscrollticker.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.nyhtmlscrollticker.Minimum = New Decimal(New Integer() {4000, 0, 0, -2147483648})
        Me.nyhtmlscrollticker.Name = "nyhtmlscrollticker"
        Me.nyhtmlscrollticker.Size = New System.Drawing.Size(54, 20)
        Me.nyhtmlscrollticker.TabIndex = 739
        Me.nyhtmlscrollticker.Value = New Decimal(New Integer() {89, 0, 0, 0})
        '
        'Label190
        '
        Me.Label190.AutoSize = True
        Me.Label190.Location = New System.Drawing.Point(58, 37)
        Me.Label190.Name = "Label190"
        Me.Label190.Size = New System.Drawing.Size(90, 13)
        Me.Label190.TabIndex = 738
        Me.Label190.Text = "Ticker Y  Position"
        '
        'cmdstripcolorhtmlscroll
        '
        Me.cmdstripcolorhtmlscroll.BackColor = System.Drawing.Color.Purple
        Me.cmdstripcolorhtmlscroll.ForeColor = System.Drawing.Color.Yellow
        Me.cmdstripcolorhtmlscroll.Location = New System.Drawing.Point(160, 57)
        Me.cmdstripcolorhtmlscroll.Name = "cmdstripcolorhtmlscroll"
        Me.cmdstripcolorhtmlscroll.Size = New System.Drawing.Size(54, 23)
        Me.cmdstripcolorhtmlscroll.TabIndex = 735
        Me.cmdstripcolorhtmlscroll.Text = "color"
        Me.cmdstripcolorhtmlscroll.UseVisualStyleBackColor = False
        '
        'chkltrhtmlscroll
        '
        Me.chkltrhtmlscroll.AutoSize = True
        Me.chkltrhtmlscroll.Location = New System.Drawing.Point(6, 129)
        Me.chkltrhtmlscroll.Name = "chkltrhtmlscroll"
        Me.chkltrhtmlscroll.Size = New System.Drawing.Size(88, 17)
        Me.chkltrhtmlscroll.TabIndex = 734
        Me.chkltrhtmlscroll.Text = "Left To Right"
        Me.chkltrhtmlscroll.UseVisualStyleBackColor = True
        '
        'Label161
        '
        Me.Label161.AutoSize = True
        Me.Label161.Location = New System.Drawing.Point(144, 82)
        Me.Label161.Name = "Label161"
        Me.Label161.Size = New System.Drawing.Size(0, 13)
        Me.Label161.TabIndex = 733
        '
        'Label162
        '
        Me.Label162.AutoSize = True
        Me.Label162.Location = New System.Drawing.Point(94, 62)
        Me.Label162.Name = "Label162"
        Me.Label162.Size = New System.Drawing.Size(54, 13)
        Me.Label162.TabIndex = 732
        Me.Label162.Text = "Strip color"
        '
        'nyhtmlscroll
        '
        Me.nyhtmlscroll.Location = New System.Drawing.Point(160, 14)
        Me.nyhtmlscroll.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.nyhtmlscroll.Minimum = New Decimal(New Integer() {4000, 0, 0, -2147483648})
        Me.nyhtmlscroll.Name = "nyhtmlscroll"
        Me.nyhtmlscroll.Size = New System.Drawing.Size(54, 20)
        Me.nyhtmlscroll.TabIndex = 731
        Me.nyhtmlscroll.Value = New Decimal(New Integer() {89, 0, 0, 0})
        '
        'Label163
        '
        Me.Label163.AutoSize = True
        Me.Label163.Location = New System.Drawing.Point(67, 16)
        Me.Label163.Name = "Label163"
        Me.Label163.Size = New System.Drawing.Size(81, 13)
        Me.Label163.TabIndex = 730
        Me.Label163.Text = "Strip Y  Position"
        '
        'cmdPlayMultibulletHtml
        '
        Me.cmdPlayMultibulletHtml.BackColor = System.Drawing.Color.Green
        Me.cmdPlayMultibulletHtml.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPlayMultibulletHtml.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdPlayMultibulletHtml.Location = New System.Drawing.Point(222, 14)
        Me.cmdPlayMultibulletHtml.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdPlayMultibulletHtml.Name = "cmdPlayMultibulletHtml"
        Me.cmdPlayMultibulletHtml.Size = New System.Drawing.Size(60, 30)
        Me.cmdPlayMultibulletHtml.TabIndex = 718
        Me.cmdPlayMultibulletHtml.Text = "Play"
        Me.cmdPlayMultibulletHtml.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 102)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(84, 24)
        Me.MenuStrip1.TabIndex = 717
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.NewToolStripMenuItem.Text = "New"
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
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 716
        Me.Label2.Text = "Template"
        '
        'txmultibulletscrollerTemplate
        '
        Me.txmultibulletscrollerTemplate.Location = New System.Drawing.Point(69, 19)
        Me.txmultibulletscrollerTemplate.Name = "txmultibulletscrollerTemplate"
        Me.txmultibulletscrollerTemplate.Size = New System.Drawing.Size(353, 20)
        Me.txmultibulletscrollerTemplate.TabIndex = 715
        Me.txmultibulletscrollerTemplate.Text = "cmp/multibullet/multibullet"
        '
        'ntextY
        '
        Me.ntextY.Location = New System.Drawing.Point(57, 69)
        Me.ntextY.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.ntextY.Name = "ntextY"
        Me.ntextY.Size = New System.Drawing.Size(47, 20)
        Me.ntextY.TabIndex = 714
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 713
        Me.Label1.Text = "Text Y"
        '
        'cmdselectallforscroll
        '
        Me.cmdselectallforscroll.Location = New System.Drawing.Point(564, 69)
        Me.cmdselectallforscroll.Name = "cmdselectallforscroll"
        Me.cmdselectallforscroll.Size = New System.Drawing.Size(75, 23)
        Me.cmdselectallforscroll.TabIndex = 513
        Me.cmdselectallforscroll.Text = "Select All"
        Me.cmdselectallforscroll.UseVisualStyleBackColor = True
        '
        'cmddeselectallforscroll
        '
        Me.cmddeselectallforscroll.Location = New System.Drawing.Point(564, 103)
        Me.cmddeselectallforscroll.Name = "cmddeselectallforscroll"
        Me.cmddeselectallforscroll.Size = New System.Drawing.Size(73, 23)
        Me.cmddeselectallforscroll.TabIndex = 512
        Me.cmddeselectallforscroll.Text = "Deselect All"
        Me.cmddeselectallforscroll.UseVisualStyleBackColor = True
        '
        'cmdpausescroll
        '
        Me.cmdpausescroll.BackColor = System.Drawing.Color.Yellow
        Me.cmdpausescroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpausescroll.Location = New System.Drawing.Point(386, 94)
        Me.cmdpausescroll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdpausescroll.Name = "cmdpausescroll"
        Me.cmdpausescroll.Size = New System.Drawing.Size(117, 30)
        Me.cmdpausescroll.TabIndex = 508
        Me.cmdpausescroll.Text = "Pause/Resume"
        Me.cmdpausescroll.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtclockTemplate)
        Me.GroupBox2.Controls.Add(Me.Label50)
        Me.GroupBox2.Controls.Add(Me.cmblayertime)
        Me.GroupBox2.Controls.Add(Me.cmdhidetime)
        Me.GroupBox2.Controls.Add(Me.cmdshowtime)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 508)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 91)
        Me.GroupBox2.TabIndex = 507
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Time Day Date Month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 720
        Me.Label3.Text = "Template"
        '
        'txtclockTemplate
        '
        Me.txtclockTemplate.Location = New System.Drawing.Point(79, 29)
        Me.txtclockTemplate.Name = "txtclockTemplate"
        Me.txtclockTemplate.Size = New System.Drawing.Size(219, 21)
        Me.txtclockTemplate.TabIndex = 719
        Me.txtclockTemplate.Text = "CMP/time2/time"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(12, 60)
        Me.Label50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(124, 15)
        Me.Label50.TabIndex = 505
        Me.Label50.Text = "video layer-flash layer"
        '
        'cmblayertime
        '
        Me.cmblayertime.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmblayertime", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmblayertime.FormattingEnabled = True
        Me.cmblayertime.Items.AddRange(New Object() {"56", "57", "58", "59", "60"})
        Me.cmblayertime.Location = New System.Drawing.Point(140, 57)
        Me.cmblayertime.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmblayertime.Name = "cmblayertime"
        Me.cmblayertime.Size = New System.Drawing.Size(40, 23)
        Me.cmblayertime.TabIndex = 504
        Me.cmblayertime.Text = "56"
        '
        'cmdhidetime
        '
        Me.cmdhidetime.Location = New System.Drawing.Point(240, 57)
        Me.cmdhidetime.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdhidetime.Name = "cmdhidetime"
        Me.cmdhidetime.Size = New System.Drawing.Size(45, 28)
        Me.cmdhidetime.TabIndex = 503
        Me.cmdhidetime.Text = "Stop"
        Me.cmdhidetime.UseVisualStyleBackColor = True
        '
        'cmdshowtime
        '
        Me.cmdshowtime.Location = New System.Drawing.Point(188, 56)
        Me.cmdshowtime.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdshowtime.Name = "cmdshowtime"
        Me.cmdshowtime.Size = New System.Drawing.Size(44, 29)
        Me.cmdshowtime.TabIndex = 502
        Me.cmdshowtime.Text = "Play"
        Me.cmdshowtime.UseVisualStyleBackColor = True
        '
        'cmdplayscroll
        '
        Me.cmdplayscroll.BackColor = System.Drawing.Color.Green
        Me.cmdplayscroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplayscroll.ForeColor = System.Drawing.Color.White
        Me.cmdplayscroll.Location = New System.Drawing.Point(331, 96)
        Me.cmdplayscroll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdplayscroll.Name = "cmdplayscroll"
        Me.cmdplayscroll.Size = New System.Drawing.Size(52, 30)
        Me.cmdplayscroll.TabIndex = 498
        Me.cmdplayscroll.Text = "Play"
        Me.cmdplayscroll.UseVisualStyleBackColor = False
        '
        'cmdstopscroll
        '
        Me.cmdstopscroll.BackColor = System.Drawing.Color.Red
        Me.cmdstopscroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopscroll.ForeColor = System.Drawing.Color.White
        Me.cmdstopscroll.Location = New System.Drawing.Point(511, 94)
        Me.cmdstopscroll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdstopscroll.Name = "cmdstopscroll"
        Me.cmdstopscroll.Size = New System.Drawing.Size(48, 30)
        Me.cmdstopscroll.TabIndex = 499
        Me.cmdstopscroll.Text = "Stop"
        Me.cmdstopscroll.UseVisualStyleBackColor = False
        '
        'cmddeletetsscroll
        '
        Me.cmddeletetsscroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddeletetsscroll.Image = Global.caspar_media_playback.My.Resources.Resources.minus
        Me.cmddeletetsscroll.Location = New System.Drawing.Point(218, 98)
        Me.cmddeletetsscroll.Name = "cmddeletetsscroll"
        Me.cmddeletetsscroll.Size = New System.Drawing.Size(33, 22)
        Me.cmddeletetsscroll.TabIndex = 496
        Me.cmddeletetsscroll.UseVisualStyleBackColor = True
        '
        'cmduptsscroll
        '
        Me.cmduptsscroll.Image = CType(resources.GetObject("cmduptsscroll.Image"), System.Drawing.Image)
        Me.cmduptsscroll.Location = New System.Drawing.Point(104, 98)
        Me.cmduptsscroll.Name = "cmduptsscroll"
        Me.cmduptsscroll.Size = New System.Drawing.Size(28, 23)
        Me.cmduptsscroll.TabIndex = 494
        Me.cmduptsscroll.UseVisualStyleBackColor = True
        '
        'cmddowntsscroll
        '
        Me.cmddowntsscroll.Image = CType(resources.GetObject("cmddowntsscroll.Image"), System.Drawing.Image)
        Me.cmddowntsscroll.Location = New System.Drawing.Point(135, 98)
        Me.cmddowntsscroll.Name = "cmddowntsscroll"
        Me.cmddowntsscroll.Size = New System.Drawing.Size(36, 23)
        Me.cmddowntsscroll.TabIndex = 495
        Me.cmddowntsscroll.UseVisualStyleBackColor = True
        '
        'cmdinserttsscroll
        '
        Me.cmdinserttsscroll.Image = CType(resources.GetObject("cmdinserttsscroll.Image"), System.Drawing.Image)
        Me.cmdinserttsscroll.Location = New System.Drawing.Point(172, 98)
        Me.cmdinserttsscroll.Name = "cmdinserttsscroll"
        Me.cmdinserttsscroll.Size = New System.Drawing.Size(41, 23)
        Me.cmdinserttsscroll.TabIndex = 493
        Me.cmdinserttsscroll.UseVisualStyleBackColor = True
        '
        'dgvscroll
        '
        Me.dgvscroll.AllowDrop = True
        Me.dgvscroll.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvscroll.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvscroll.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvscroll.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvscroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvscroll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn2, Me.IMG})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvscroll.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvscroll.Location = New System.Drawing.Point(6, 130)
        Me.dgvscroll.MultiSelect = False
        Me.dgvscroll.Name = "dgvscroll"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvscroll.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvscroll.RowHeadersWidth = 25
        Me.dgvscroll.Size = New System.Drawing.Size(648, 281)
        Me.dgvscroll.TabIndex = 492
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "Scroll"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 530
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 530
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.FalseValue = "0"
        Me.DataGridViewCheckBoxColumn2.FillWeight = 20.0!
        Me.DataGridViewCheckBoxColumn2.HeaderText = ""
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn2.TrueValue = "1"
        Me.DataGridViewCheckBoxColumn2.Width = 30
        '
        'IMG
        '
        Me.IMG.HeaderText = "IMG"
        Me.IMG.Image = CType(resources.GetObject("IMG.Image"), System.Drawing.Image)
        Me.IMG.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.IMG.Name = "IMG"
        Me.IMG.Width = 50
        '
        'nspeedscroll
        '
        Me.nspeedscroll.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.caspar_media_playback.My.MySettings.Default, "nspeedscroll", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nspeedscroll.DecimalPlaces = 1
        Me.nspeedscroll.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.nspeedscroll.Location = New System.Drawing.Point(258, 96)
        Me.nspeedscroll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nspeedscroll.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nspeedscroll.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.nspeedscroll.Name = "nspeedscroll"
        Me.nspeedscroll.Size = New System.Drawing.Size(46, 20)
        Me.nspeedscroll.TabIndex = 452
        Me.nspeedscroll.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(268, 76)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 13)
        Me.Label20.TabIndex = 451
        Me.Label20.Text = "speed"
        '
        'cmblayerscroll
        '
        Me.cmblayerscroll.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmblayerscroll", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmblayerscroll.FormattingEnabled = True
        Me.cmblayerscroll.Items.AddRange(New Object() {"51", "52", "53", "54", "55"})
        Me.cmblayerscroll.Location = New System.Drawing.Point(579, 11)
        Me.cmblayerscroll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmblayerscroll.Name = "cmblayerscroll"
        Me.cmblayerscroll.Size = New System.Drawing.Size(40, 21)
        Me.cmblayerscroll.TabIndex = 450
        Me.cmblayerscroll.Text = "51"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(463, 14)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(108, 13)
        Me.Label21.TabIndex = 449
        Me.Label21.Text = "video layer-flash layer"
        '
        'tmrshowdatascroll
        '
        Me.tmrshowdatascroll.Interval = 4000
        '
        'tmrshowdatascrollHtml
        '
        Me.tmrshowdatascrollHtml.Interval = 4000
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn1.HeaderText = "Scroll"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 530
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 530
        '
        'ucMultiBulletScroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1208, 921)
        Me.Controls.Add(Me.gbscroll)
        Me.HideOnClose = True
        Me.Name = "ucMultiBulletScroll"
        Me.Text = "Multi Bullet Scroll"
        Me.gbscroll.ResumeLayout(False)
        Me.gbscroll.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nspeedhtmlscroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nsizehtmlscroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nyhtmlscrollticker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nyhtmlscroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ntextY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvscroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nspeedscroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbscroll As System.Windows.Forms.GroupBox
    Friend WithEvents cmdselectallforscroll As System.Windows.Forms.Button
    Friend WithEvents cmddeselectallforscroll As System.Windows.Forms.Button
    Friend WithEvents cmdpausescroll As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents cmblayertime As System.Windows.Forms.ComboBox
    Friend WithEvents cmdhidetime As System.Windows.Forms.Button
    Friend WithEvents cmdshowtime As System.Windows.Forms.Button
    Friend WithEvents cmdplayscroll As System.Windows.Forms.Button
    Friend WithEvents cmdstopscroll As System.Windows.Forms.Button
    Friend WithEvents cmddeletetsscroll As System.Windows.Forms.Button
    Friend WithEvents cmduptsscroll As System.Windows.Forms.Button
    Friend WithEvents cmddowntsscroll As System.Windows.Forms.Button
    Friend WithEvents cmdinserttsscroll As System.Windows.Forms.Button
    Friend WithEvents dgvscroll As System.Windows.Forms.DataGridView
    Friend WithEvents nspeedscroll As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmblayerscroll As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tmrshowdatascroll As System.Windows.Forms.Timer
    Friend WithEvents ntextY As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IMG As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txmultibulletscrollerTemplate As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdPlayMultibulletHtml As Button
    Friend WithEvents chkbase64htmlscroller As CheckBox
    Friend WithEvents nyhtmlscrollticker As NumericUpDown
    Friend WithEvents Label190 As Label
    Friend WithEvents cmdstripcolorhtmlscroll As Button
    Friend WithEvents chkltrhtmlscroll As CheckBox
    Friend WithEvents Label161 As Label
    Friend WithEvents Label162 As Label
    Friend WithEvents nyhtmlscroll As NumericUpDown
    Friend WithEvents Label163 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents nspeedhtmlscroll As NumericUpDown
    Friend WithEvents nsizehtmlscroll As NumericUpDown
    Friend WithEvents cmbfonthtmlscroll As ComboBox
    Friend WithEvents cmdcolorhtmlscroll As Button
    Friend WithEvents Label156 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label157 As Label
    Friend WithEvents Label160 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdstopcrawlhtmlscroll As Button
    Friend WithEvents cmdpauseresumehtmlscroller As Button
    Friend WithEvents tmrshowdatascrollHtml As Timer
    Friend WithEvents chkAutoUpdate As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtclockTemplate As TextBox
End Class
