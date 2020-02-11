<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucScroll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucScroll))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbscroll = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtScrollTemplate = New System.Windows.Forms.TextBox()
        Me.chkCapitalise = New System.Windows.Forms.CheckBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cmdhidegbscrollandclock = New System.Windows.Forms.Button()
        Me.picscrollbullet = New System.Windows.Forms.PictureBox()
        Me.cmdselectallforscroll = New System.Windows.Forms.Button()
        Me.cmddeselectallforscroll = New System.Windows.Forms.Button()
        Me.txtdelemeterforscroll = New System.Windows.Forms.TextBox()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.cmdresumescroll = New System.Windows.Forms.Button()
        Me.cmdpausescroll = New System.Windows.Forms.Button()
        Me.cmdplayscroll = New System.Windows.Forms.Button()
        Me.cmdstopscroll = New System.Windows.Forms.Button()
        Me.cmddeletetsscroll = New System.Windows.Forms.Button()
        Me.cmduptsscroll = New System.Windows.Forms.Button()
        Me.cmddowntsscroll = New System.Windows.Forms.Button()
        Me.cmdinserttsscroll = New System.Windows.Forms.Button()
        Me.dgvscroll = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.nspeedscroll = New System.Windows.Forms.NumericUpDown()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmblayerscroll = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tmrshowdatascroll = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UcBreakingNews1 = New caspar_media_playback.ucBreakingNews()
        Me.gbscroll.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picscrollbullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvscroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nspeedscroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbscroll
        '
        Me.gbscroll.BackColor = System.Drawing.Color.Bisque
        Me.gbscroll.Controls.Add(Me.MenuStrip1)
        Me.gbscroll.Controls.Add(Me.Label2)
        Me.gbscroll.Controls.Add(Me.txtScrollTemplate)
        Me.gbscroll.Controls.Add(Me.chkCapitalise)
        Me.gbscroll.Controls.Add(Me.Label29)
        Me.gbscroll.Controls.Add(Me.cmdhidegbscrollandclock)
        Me.gbscroll.Controls.Add(Me.picscrollbullet)
        Me.gbscroll.Controls.Add(Me.cmdselectallforscroll)
        Me.gbscroll.Controls.Add(Me.cmddeselectallforscroll)
        Me.gbscroll.Controls.Add(Me.txtdelemeterforscroll)
        Me.gbscroll.Controls.Add(Me.Label114)
        Me.gbscroll.Controls.Add(Me.cmdresumescroll)
        Me.gbscroll.Controls.Add(Me.cmdpausescroll)
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
        Me.gbscroll.Location = New System.Drawing.Point(5, 456)
        Me.gbscroll.Name = "gbscroll"
        Me.gbscroll.Size = New System.Drawing.Size(1209, 465)
        Me.gbscroll.TabIndex = 533
        Me.gbscroll.TabStop = False
        Me.gbscroll.Text = "Scroll And Clock"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 42)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(84, 24)
        Me.MenuStrip1.TabIndex = 1170
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.InsertToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save as"
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.InsertToolStripMenuItem.Text = "Insert"
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
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1169
        Me.Label2.Text = "Template"
        '
        'txtScrollTemplate
        '
        Me.txtScrollTemplate.Location = New System.Drawing.Point(63, 19)
        Me.txtScrollTemplate.Name = "txtScrollTemplate"
        Me.txtScrollTemplate.Size = New System.Drawing.Size(353, 20)
        Me.txtScrollTemplate.TabIndex = 1168
        Me.txtScrollTemplate.Text = "CMP/scroll/scroll"
        '
        'chkCapitalise
        '
        Me.chkCapitalise.AutoSize = True
        Me.chkCapitalise.Checked = Global.caspar_media_playback.My.MySettings.Default.chkcapitalised
        Me.chkCapitalise.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.caspar_media_playback.My.MySettings.Default, "chkcapitalised", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkCapitalise.Location = New System.Drawing.Point(9, 78)
        Me.chkCapitalise.Name = "chkCapitalise"
        Me.chkCapitalise.Size = New System.Drawing.Size(71, 17)
        Me.chkCapitalise.TabIndex = 1167
        Me.chkCapitalise.Text = "Capitalise"
        Me.chkCapitalise.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(99, 49)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 13)
        Me.Label29.TabIndex = 1166
        Me.Label29.Text = "Bullet"
        '
        'cmdhidegbscrollandclock
        '
        Me.cmdhidegbscrollandclock.Image = CType(resources.GetObject("cmdhidegbscrollandclock.Image"), System.Drawing.Image)
        Me.cmdhidegbscrollandclock.Location = New System.Drawing.Point(1175, 8)
        Me.cmdhidegbscrollandclock.Name = "cmdhidegbscrollandclock"
        Me.cmdhidegbscrollandclock.Size = New System.Drawing.Size(28, 27)
        Me.cmdhidegbscrollandclock.TabIndex = 712
        Me.cmdhidegbscrollandclock.UseVisualStyleBackColor = True
        '
        'picscrollbullet
        '
        Me.picscrollbullet.ImageLocation = "C:\Casparcg\mydata\html\dd.png"
        Me.picscrollbullet.InitialImage = CType(resources.GetObject("picscrollbullet.InitialImage"), System.Drawing.Image)
        Me.picscrollbullet.Location = New System.Drawing.Point(139, 42)
        Me.picscrollbullet.Name = "picscrollbullet"
        Me.picscrollbullet.Size = New System.Drawing.Size(32, 26)
        Me.picscrollbullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picscrollbullet.TabIndex = 1165
        Me.picscrollbullet.TabStop = False
        '
        'cmdselectallforscroll
        '
        Me.cmdselectallforscroll.Location = New System.Drawing.Point(1106, 49)
        Me.cmdselectallforscroll.Name = "cmdselectallforscroll"
        Me.cmdselectallforscroll.Size = New System.Drawing.Size(76, 23)
        Me.cmdselectallforscroll.TabIndex = 513
        Me.cmdselectallforscroll.Text = "Select All"
        Me.cmdselectallforscroll.UseVisualStyleBackColor = True
        '
        'cmddeselectallforscroll
        '
        Me.cmddeselectallforscroll.Location = New System.Drawing.Point(1103, 76)
        Me.cmddeselectallforscroll.Name = "cmddeselectallforscroll"
        Me.cmddeselectallforscroll.Size = New System.Drawing.Size(79, 23)
        Me.cmddeselectallforscroll.TabIndex = 512
        Me.cmddeselectallforscroll.Text = "Deselect All"
        Me.cmddeselectallforscroll.UseVisualStyleBackColor = True
        '
        'txtdelemeterforscroll
        '
        Me.txtdelemeterforscroll.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "newdelemterforscrollandclock", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtdelemeterforscroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdelemeterforscroll.Location = New System.Drawing.Point(302, 45)
        Me.txtdelemeterforscroll.Name = "txtdelemeterforscroll"
        Me.txtdelemeterforscroll.Size = New System.Drawing.Size(69, 26)
        Me.txtdelemeterforscroll.TabIndex = 511
        Me.txtdelemeterforscroll.Text = Global.caspar_media_playback.My.MySettings.Default.newdelemterforscrollandclock
        Me.txtdelemeterforscroll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Location = New System.Drawing.Point(175, 47)
        Me.Label114.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(122, 13)
        Me.Label114.TabIndex = 510
        Me.Label114.Text = "Delimeter between items"
        '
        'cmdresumescroll
        '
        Me.cmdresumescroll.BackColor = System.Drawing.Color.Yellow
        Me.cmdresumescroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdresumescroll.Location = New System.Drawing.Point(968, 72)
        Me.cmdresumescroll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdresumescroll.Name = "cmdresumescroll"
        Me.cmdresumescroll.Size = New System.Drawing.Size(63, 30)
        Me.cmdresumescroll.TabIndex = 509
        Me.cmdresumescroll.Text = "Resume"
        Me.cmdresumescroll.UseVisualStyleBackColor = False
        '
        'cmdpausescroll
        '
        Me.cmdpausescroll.BackColor = System.Drawing.Color.Yellow
        Me.cmdpausescroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpausescroll.Location = New System.Drawing.Point(902, 72)
        Me.cmdpausescroll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdpausescroll.Name = "cmdpausescroll"
        Me.cmdpausescroll.Size = New System.Drawing.Size(58, 30)
        Me.cmdpausescroll.TabIndex = 508
        Me.cmdpausescroll.Text = "Pause"
        Me.cmdpausescroll.UseVisualStyleBackColor = False
        '
        'cmdplayscroll
        '
        Me.cmdplayscroll.BackColor = System.Drawing.Color.Green
        Me.cmdplayscroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplayscroll.ForeColor = System.Drawing.Color.White
        Me.cmdplayscroll.Location = New System.Drawing.Point(850, 72)
        Me.cmdplayscroll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdplayscroll.Name = "cmdplayscroll"
        Me.cmdplayscroll.Size = New System.Drawing.Size(48, 30)
        Me.cmdplayscroll.TabIndex = 498
        Me.cmdplayscroll.Text = "Play"
        Me.cmdplayscroll.UseVisualStyleBackColor = False
        '
        'cmdstopscroll
        '
        Me.cmdstopscroll.BackColor = System.Drawing.Color.Red
        Me.cmdstopscroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopscroll.ForeColor = System.Drawing.Color.White
        Me.cmdstopscroll.Location = New System.Drawing.Point(1038, 72)
        Me.cmdstopscroll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdstopscroll.Name = "cmdstopscroll"
        Me.cmdstopscroll.Size = New System.Drawing.Size(58, 30)
        Me.cmdstopscroll.TabIndex = 499
        Me.cmdstopscroll.Text = "Stop"
        Me.cmdstopscroll.UseVisualStyleBackColor = False
        '
        'cmddeletetsscroll
        '
        Me.cmddeletetsscroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddeletetsscroll.Image = Global.caspar_media_playback.My.Resources.Resources.minus
        Me.cmddeletetsscroll.Location = New System.Drawing.Point(198, 75)
        Me.cmddeletetsscroll.Name = "cmddeletetsscroll"
        Me.cmddeletetsscroll.Size = New System.Drawing.Size(33, 22)
        Me.cmddeletetsscroll.TabIndex = 496
        Me.cmddeletetsscroll.UseVisualStyleBackColor = True
        '
        'cmduptsscroll
        '
        Me.cmduptsscroll.Image = CType(resources.GetObject("cmduptsscroll.Image"), System.Drawing.Image)
        Me.cmduptsscroll.Location = New System.Drawing.Point(84, 75)
        Me.cmduptsscroll.Name = "cmduptsscroll"
        Me.cmduptsscroll.Size = New System.Drawing.Size(28, 23)
        Me.cmduptsscroll.TabIndex = 494
        Me.cmduptsscroll.UseVisualStyleBackColor = True
        '
        'cmddowntsscroll
        '
        Me.cmddowntsscroll.Image = CType(resources.GetObject("cmddowntsscroll.Image"), System.Drawing.Image)
        Me.cmddowntsscroll.Location = New System.Drawing.Point(115, 75)
        Me.cmddowntsscroll.Name = "cmddowntsscroll"
        Me.cmddowntsscroll.Size = New System.Drawing.Size(36, 23)
        Me.cmddowntsscroll.TabIndex = 495
        Me.cmddowntsscroll.UseVisualStyleBackColor = True
        '
        'cmdinserttsscroll
        '
        Me.cmdinserttsscroll.Image = CType(resources.GetObject("cmdinserttsscroll.Image"), System.Drawing.Image)
        Me.cmdinserttsscroll.Location = New System.Drawing.Point(152, 75)
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
        Me.dgvscroll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn2})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvscroll.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvscroll.Location = New System.Drawing.Point(4, 106)
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
        Me.dgvscroll.RowTemplate.Height = 30
        Me.dgvscroll.Size = New System.Drawing.Size(1199, 353)
        Me.dgvscroll.TabIndex = 492
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Scroll"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 550
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 1100
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
        'nspeedscroll
        '
        Me.nspeedscroll.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.caspar_media_playback.My.MySettings.Default, "nnewspeed", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nspeedscroll.DecimalPlaces = 1
        Me.nspeedscroll.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.nspeedscroll.Location = New System.Drawing.Point(796, 72)
        Me.nspeedscroll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nspeedscroll.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nspeedscroll.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.nspeedscroll.Name = "nspeedscroll"
        Me.nspeedscroll.Size = New System.Drawing.Size(46, 20)
        Me.nspeedscroll.TabIndex = 452
        Me.nspeedscroll.Value = Global.caspar_media_playback.My.MySettings.Default.nnewspeed
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(758, 72)
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
        Me.cmblayerscroll.Location = New System.Drawing.Point(550, 23)
        Me.cmblayerscroll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmblayerscroll.Name = "cmblayerscroll"
        Me.cmblayerscroll.Size = New System.Drawing.Size(40, 21)
        Me.cmblayerscroll.TabIndex = 450
        Me.cmblayerscroll.Text = "51"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(434, 25)
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
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Scroll"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 550
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 580
        '
        'UcBreakingNews1
        '
        Me.UcBreakingNews1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcBreakingNews1.Location = New System.Drawing.Point(1, -1)
        Me.UcBreakingNews1.Name = "UcBreakingNews1"
        Me.UcBreakingNews1.Size = New System.Drawing.Size(1217, 452)
        Me.UcBreakingNews1.TabIndex = 534
        '
        'ucScroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1221, 924)
        Me.Controls.Add(Me.UcBreakingNews1)
        Me.Controls.Add(Me.gbscroll)
        Me.HideOnClose = True
        Me.Name = "ucScroll"
        Me.Text = "Scroll"
        Me.gbscroll.ResumeLayout(False)
        Me.gbscroll.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picscrollbullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvscroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nspeedscroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbscroll As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cmdhidegbscrollandclock As System.Windows.Forms.Button
    Friend WithEvents picscrollbullet As System.Windows.Forms.PictureBox
    Friend WithEvents cmdselectallforscroll As System.Windows.Forms.Button
    Friend WithEvents cmddeselectallforscroll As System.Windows.Forms.Button
    Friend WithEvents txtdelemeterforscroll As System.Windows.Forms.TextBox
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents cmdresumescroll As System.Windows.Forms.Button
    Friend WithEvents cmdpausescroll As System.Windows.Forms.Button
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
    Friend WithEvents chkCapitalise As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtScrollTemplate As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UcBreakingNews1 As ucBreakingNews
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As ToolStripMenuItem
End Class
