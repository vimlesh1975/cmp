<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBreakingNews
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucBreakingNews))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbbreakingnews = New System.Windows.Forms.GroupBox()
        Me.cmdPlayHTML = New System.Windows.Forms.Button()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txtclockTemplate = New System.Windows.Forms.TextBox()
        Me.cmblayertime = New System.Windows.Forms.ComboBox()
        Me.cmdhidetime = New System.Windows.Forms.Button()
        Me.cmdshowtime = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbnTemplate = New System.Windows.Forms.TextBox()
        Me.lblbnfilename = New System.Windows.Forms.Label()
        Me.cmdbreakingnewsselectall = New System.Windows.Forms.Button()
        Me.cmdbreakingnewssdeelectall = New System.Windows.Forms.Button()
        Me.txtbreakingnewsupdateinterval = New System.Windows.Forms.TextBox()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.cmddeleteclipbreakingnews = New System.Windows.Forms.Button()
        Me.cmdmoveupbreakingnews = New System.Windows.Forms.Button()
        Me.cmdmovedownbreakingnews = New System.Windows.Forms.Button()
        Me.cmdinsertbreakingnews = New System.Windows.Forms.Button()
        Me.dgvbreakingnews = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdplaybreakingnews = New System.Windows.Forms.Button()
        Me.cmdstopbrekingnews = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmblayerbreakingnews = New System.Windows.Forms.ComboBox()
        Me.tmrshowdata = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbbreakingnews.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvbreakingnews, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbbreakingnews
        '
        Me.gbbreakingnews.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gbbreakingnews.Controls.Add(Me.cmdPlayHTML)
        Me.gbbreakingnews.Controls.Add(Me.MenuStrip1)
        Me.gbbreakingnews.Controls.Add(Me.GroupBox2)
        Me.gbbreakingnews.Controls.Add(Me.Label1)
        Me.gbbreakingnews.Controls.Add(Me.txtbnTemplate)
        Me.gbbreakingnews.Controls.Add(Me.lblbnfilename)
        Me.gbbreakingnews.Controls.Add(Me.cmdbreakingnewsselectall)
        Me.gbbreakingnews.Controls.Add(Me.cmdbreakingnewssdeelectall)
        Me.gbbreakingnews.Controls.Add(Me.txtbreakingnewsupdateinterval)
        Me.gbbreakingnews.Controls.Add(Me.Label113)
        Me.gbbreakingnews.Controls.Add(Me.cmddeleteclipbreakingnews)
        Me.gbbreakingnews.Controls.Add(Me.cmdmoveupbreakingnews)
        Me.gbbreakingnews.Controls.Add(Me.cmdmovedownbreakingnews)
        Me.gbbreakingnews.Controls.Add(Me.cmdinsertbreakingnews)
        Me.gbbreakingnews.Controls.Add(Me.dgvbreakingnews)
        Me.gbbreakingnews.Controls.Add(Me.cmdplaybreakingnews)
        Me.gbbreakingnews.Controls.Add(Me.cmdstopbrekingnews)
        Me.gbbreakingnews.Controls.Add(Me.Label11)
        Me.gbbreakingnews.Controls.Add(Me.cmblayerbreakingnews)
        Me.gbbreakingnews.Location = New System.Drawing.Point(3, 4)
        Me.gbbreakingnews.Name = "gbbreakingnews"
        Me.gbbreakingnews.Size = New System.Drawing.Size(1209, 450)
        Me.gbbreakingnews.TabIndex = 532
        Me.gbbreakingnews.TabStop = False
        Me.gbbreakingnews.Text = "BreakingNews"
        '
        'cmdPlayHTML
        '
        Me.cmdPlayHTML.BackColor = System.Drawing.Color.Green
        Me.cmdPlayHTML.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPlayHTML.ForeColor = System.Drawing.Color.White
        Me.cmdPlayHTML.Location = New System.Drawing.Point(554, 75)
        Me.cmdPlayHTML.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdPlayHTML.Name = "cmdPlayHTML"
        Me.cmdPlayHTML.Size = New System.Drawing.Size(99, 30)
        Me.cmdPlayHTML.TabIndex = 717
        Me.cmdPlayHTML.Text = "Play HTML"
        Me.ToolTip1.SetToolTip(Me.cmdPlayHTML, "Works good with server 2.3")
        Me.cmdPlayHTML.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(12, 72)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(84, 24)
        Me.MenuStrip1.TabIndex = 716
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
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
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
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label50)
        Me.GroupBox2.Controls.Add(Me.txtclockTemplate)
        Me.GroupBox2.Controls.Add(Me.cmblayertime)
        Me.GroupBox2.Controls.Add(Me.cmdhidetime)
        Me.GroupBox2.Controls.Add(Me.cmdshowtime)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(767, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 94)
        Me.GroupBox2.TabIndex = 715
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Time Day Date Month"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 718
        Me.Label2.Text = "Template"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(7, 61)
        Me.Label50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(124, 15)
        Me.Label50.TabIndex = 505
        Me.Label50.Text = "video layer-flash layer"
        '
        'txtclockTemplate
        '
        Me.txtclockTemplate.Location = New System.Drawing.Point(77, 30)
        Me.txtclockTemplate.Name = "txtclockTemplate"
        Me.txtclockTemplate.Size = New System.Drawing.Size(219, 21)
        Me.txtclockTemplate.TabIndex = 717
        Me.txtclockTemplate.Text = "CMP/time/time"
        '
        'cmblayertime
        '
        Me.cmblayertime.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmblayertime", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmblayertime.FormattingEnabled = True
        Me.cmblayertime.Items.AddRange(New Object() {"56", "57", "58", "59", "60"})
        Me.cmblayertime.Location = New System.Drawing.Point(135, 58)
        Me.cmblayertime.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmblayertime.Name = "cmblayertime"
        Me.cmblayertime.Size = New System.Drawing.Size(40, 23)
        Me.cmblayertime.TabIndex = 504
        Me.cmblayertime.Text = "56"
        '
        'cmdhidetime
        '
        Me.cmdhidetime.BackColor = System.Drawing.Color.Red
        Me.cmdhidetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdhidetime.ForeColor = System.Drawing.Color.White
        Me.cmdhidetime.Location = New System.Drawing.Point(248, 58)
        Me.cmdhidetime.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdhidetime.Name = "cmdhidetime"
        Me.cmdhidetime.Size = New System.Drawing.Size(48, 30)
        Me.cmdhidetime.TabIndex = 503
        Me.cmdhidetime.Text = "Stop"
        Me.cmdhidetime.UseVisualStyleBackColor = False
        '
        'cmdshowtime
        '
        Me.cmdshowtime.BackColor = System.Drawing.Color.Green
        Me.cmdshowtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdshowtime.ForeColor = System.Drawing.Color.White
        Me.cmdshowtime.Location = New System.Drawing.Point(183, 58)
        Me.cmdshowtime.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdshowtime.Name = "cmdshowtime"
        Me.cmdshowtime.Size = New System.Drawing.Size(52, 30)
        Me.cmdshowtime.TabIndex = 502
        Me.cmdshowtime.Text = "Play"
        Me.cmdshowtime.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 714
        Me.Label1.Text = "Template"
        '
        'txtbnTemplate
        '
        Me.txtbnTemplate.Location = New System.Drawing.Point(62, 19)
        Me.txtbnTemplate.Name = "txtbnTemplate"
        Me.txtbnTemplate.Size = New System.Drawing.Size(353, 20)
        Me.txtbnTemplate.TabIndex = 713
        Me.txtbnTemplate.Text = "CMP/BreakingNews/BreakingNews"
        '
        'lblbnfilename
        '
        Me.lblbnfilename.AutoSize = True
        Me.lblbnfilename.Location = New System.Drawing.Point(9, 41)
        Me.lblbnfilename.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblbnfilename.Name = "lblbnfilename"
        Me.lblbnfilename.Size = New System.Drawing.Size(23, 13)
        Me.lblbnfilename.TabIndex = 712
        Me.lblbnfilename.Text = "File"
        '
        'cmdbreakingnewsselectall
        '
        Me.cmdbreakingnewsselectall.Location = New System.Drawing.Point(446, 76)
        Me.cmdbreakingnewsselectall.Name = "cmdbreakingnewsselectall"
        Me.cmdbreakingnewsselectall.Size = New System.Drawing.Size(75, 23)
        Me.cmdbreakingnewsselectall.TabIndex = 495
        Me.cmdbreakingnewsselectall.Text = "Select All"
        Me.cmdbreakingnewsselectall.UseVisualStyleBackColor = True
        '
        'cmdbreakingnewssdeelectall
        '
        Me.cmdbreakingnewssdeelectall.Location = New System.Drawing.Point(446, 51)
        Me.cmdbreakingnewssdeelectall.Name = "cmdbreakingnewssdeelectall"
        Me.cmdbreakingnewssdeelectall.Size = New System.Drawing.Size(75, 23)
        Me.cmdbreakingnewssdeelectall.TabIndex = 494
        Me.cmdbreakingnewssdeelectall.Text = "Deselect All"
        Me.cmdbreakingnewssdeelectall.UseVisualStyleBackColor = True
        '
        'txtbreakingnewsupdateinterval
        '
        Me.txtbreakingnewsupdateinterval.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtbreakingnewsupdateinterval", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtbreakingnewsupdateinterval.Location = New System.Drawing.Point(704, 43)
        Me.txtbreakingnewsupdateinterval.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtbreakingnewsupdateinterval.Name = "txtbreakingnewsupdateinterval"
        Me.txtbreakingnewsupdateinterval.Size = New System.Drawing.Size(32, 20)
        Me.txtbreakingnewsupdateinterval.TabIndex = 493
        Me.txtbreakingnewsupdateinterval.Text = "4000"
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Location = New System.Drawing.Point(597, 47)
        Me.Label113.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(99, 13)
        Me.Label113.TabIndex = 492
        Me.Label113.Text = "Update Interval(ms)"
        '
        'cmddeleteclipbreakingnews
        '
        Me.cmddeleteclipbreakingnews.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddeleteclipbreakingnews.Image = Global.caspar_media_playback.My.Resources.Resources.minus
        Me.cmddeleteclipbreakingnews.Location = New System.Drawing.Point(213, 74)
        Me.cmddeleteclipbreakingnews.Name = "cmddeleteclipbreakingnews"
        Me.cmddeleteclipbreakingnews.Size = New System.Drawing.Size(33, 22)
        Me.cmddeleteclipbreakingnews.TabIndex = 490
        Me.cmddeleteclipbreakingnews.UseVisualStyleBackColor = True
        '
        'cmdmoveupbreakingnews
        '
        Me.cmdmoveupbreakingnews.Image = CType(resources.GetObject("cmdmoveupbreakingnews.Image"), System.Drawing.Image)
        Me.cmdmoveupbreakingnews.Location = New System.Drawing.Point(104, 74)
        Me.cmdmoveupbreakingnews.Name = "cmdmoveupbreakingnews"
        Me.cmdmoveupbreakingnews.Size = New System.Drawing.Size(28, 23)
        Me.cmdmoveupbreakingnews.TabIndex = 488
        Me.cmdmoveupbreakingnews.UseVisualStyleBackColor = True
        '
        'cmdmovedownbreakingnews
        '
        Me.cmdmovedownbreakingnews.Image = CType(resources.GetObject("cmdmovedownbreakingnews.Image"), System.Drawing.Image)
        Me.cmdmovedownbreakingnews.Location = New System.Drawing.Point(133, 74)
        Me.cmdmovedownbreakingnews.Name = "cmdmovedownbreakingnews"
        Me.cmdmovedownbreakingnews.Size = New System.Drawing.Size(36, 23)
        Me.cmdmovedownbreakingnews.TabIndex = 489
        Me.cmdmovedownbreakingnews.UseVisualStyleBackColor = True
        '
        'cmdinsertbreakingnews
        '
        Me.cmdinsertbreakingnews.Image = CType(resources.GetObject("cmdinsertbreakingnews.Image"), System.Drawing.Image)
        Me.cmdinsertbreakingnews.Location = New System.Drawing.Point(170, 74)
        Me.cmdinsertbreakingnews.Name = "cmdinsertbreakingnews"
        Me.cmdinsertbreakingnews.Size = New System.Drawing.Size(41, 23)
        Me.cmdinsertbreakingnews.TabIndex = 487
        Me.cmdinsertbreakingnews.UseVisualStyleBackColor = True
        '
        'dgvbreakingnews
        '
        Me.dgvbreakingnews.AllowDrop = True
        Me.dgvbreakingnews.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvbreakingnews.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvbreakingnews.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvbreakingnews.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvbreakingnews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbreakingnews.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewCheckBoxColumn1, Me.Column9, Me.Column10})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvbreakingnews.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvbreakingnews.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvbreakingnews.Location = New System.Drawing.Point(7, 104)
        Me.dgvbreakingnews.MultiSelect = False
        Me.dgvbreakingnews.Name = "dgvbreakingnews"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvbreakingnews.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvbreakingnews.RowHeadersWidth = 25
        Me.dgvbreakingnews.RowTemplate.Height = 30
        Me.dgvbreakingnews.Size = New System.Drawing.Size(754, 341)
        Me.dgvbreakingnews.TabIndex = 486
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "xf2"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 350
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 440
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.FalseValue = "0"
        Me.DataGridViewCheckBoxColumn1.FillWeight = 20.0!
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.TrueValue = "1"
        Me.DataGridViewCheckBoxColumn1.Width = 30
        '
        'Column9
        '
        Me.Column9.HeaderText = "xf0"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 125
        '
        'Column10
        '
        Me.Column10.HeaderText = "xf1"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 125
        '
        'cmdplaybreakingnews
        '
        Me.cmdplaybreakingnews.BackColor = System.Drawing.Color.Green
        Me.cmdplaybreakingnews.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplaybreakingnews.ForeColor = System.Drawing.Color.White
        Me.cmdplaybreakingnews.Location = New System.Drawing.Point(661, 73)
        Me.cmdplaybreakingnews.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdplaybreakingnews.Name = "cmdplaybreakingnews"
        Me.cmdplaybreakingnews.Size = New System.Drawing.Size(48, 30)
        Me.cmdplaybreakingnews.TabIndex = 434
        Me.cmdplaybreakingnews.Text = "Play"
        Me.cmdplaybreakingnews.UseVisualStyleBackColor = False
        '
        'cmdstopbrekingnews
        '
        Me.cmdstopbrekingnews.BackColor = System.Drawing.Color.Red
        Me.cmdstopbrekingnews.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopbrekingnews.ForeColor = System.Drawing.Color.White
        Me.cmdstopbrekingnews.Location = New System.Drawing.Point(709, 72)
        Me.cmdstopbrekingnews.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdstopbrekingnews.Name = "cmdstopbrekingnews"
        Me.cmdstopbrekingnews.Size = New System.Drawing.Size(51, 30)
        Me.cmdstopbrekingnews.TabIndex = 435
        Me.cmdstopbrekingnews.Text = "Stop"
        Me.cmdstopbrekingnews.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(575, 16)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 13)
        Me.Label11.TabIndex = 431
        Me.Label11.Text = "video layer-flash layer"
        '
        'cmblayerbreakingnews
        '
        Me.cmblayerbreakingnews.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmblayerbreakingnews", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmblayerbreakingnews.FormattingEnabled = True
        Me.cmblayerbreakingnews.Items.AddRange(New Object() {"46", "47", "48", "49", "50"})
        Me.cmblayerbreakingnews.Location = New System.Drawing.Point(686, 12)
        Me.cmblayerbreakingnews.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmblayerbreakingnews.Name = "cmblayerbreakingnews"
        Me.cmblayerbreakingnews.Size = New System.Drawing.Size(40, 21)
        Me.cmblayerbreakingnews.TabIndex = 430
        Me.cmblayerbreakingnews.Text = "46"
        '
        'tmrshowdata
        '
        Me.tmrshowdata.Interval = 4000
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "xf0"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "xf1"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'ucBreakingNews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.gbbreakingnews)
        Me.Name = "ucBreakingNews"
        Me.Size = New System.Drawing.Size(1216, 458)
        Me.gbbreakingnews.ResumeLayout(False)
        Me.gbbreakingnews.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvbreakingnews, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbbreakingnews As System.Windows.Forms.GroupBox
    Friend WithEvents lblbnfilename As System.Windows.Forms.Label
    Friend WithEvents cmdbreakingnewsselectall As System.Windows.Forms.Button
    Friend WithEvents cmdbreakingnewssdeelectall As System.Windows.Forms.Button
    Friend WithEvents txtbreakingnewsupdateinterval As System.Windows.Forms.TextBox
    Friend WithEvents Label113 As System.Windows.Forms.Label
    Friend WithEvents cmddeleteclipbreakingnews As System.Windows.Forms.Button
    Friend WithEvents cmdmoveupbreakingnews As System.Windows.Forms.Button
    Friend WithEvents cmdmovedownbreakingnews As System.Windows.Forms.Button
    Friend WithEvents cmdinsertbreakingnews As System.Windows.Forms.Button
    Friend WithEvents dgvbreakingnews As System.Windows.Forms.DataGridView
    Friend WithEvents cmdplaybreakingnews As System.Windows.Forms.Button
    Friend WithEvents cmdstopbrekingnews As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmblayerbreakingnews As System.Windows.Forms.ComboBox
    Friend WithEvents tmrshowdata As System.Windows.Forms.Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbnTemplate As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label50 As Label
    Friend WithEvents cmblayertime As ComboBox
    Friend WithEvents cmdhidetime As Button
    Friend WithEvents cmdshowtime As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents txtclockTemplate As TextBox
    Friend WithEvents cmdPlayHTML As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As ToolStripMenuItem
End Class
