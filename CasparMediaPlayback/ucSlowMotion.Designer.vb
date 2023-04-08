<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSlowMotion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucSlowMotion))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbSlowMotion = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdspeed0 = New System.Windows.Forms.Button()
        Me.lblslowmotionrecordsubsampling = New System.Windows.Forms.Label()
        Me.lblslowmotionrecordquality = New System.Windows.Forms.Label()
        Me.cmbslowmotionrecordsubsampling = New System.Windows.Forms.ComboBox()
        Me.cmbslowmotionrecordquality = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.nSlowMotionbackward = New System.Windows.Forms.NumericUpDown()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.nSlowMotionforward = New System.Windows.Forms.NumericUpDown()
        Me.cmdspeedminus100 = New System.Windows.Forms.Button()
        Me.cmdspeedminus75 = New System.Windows.Forms.Button()
        Me.cmdspeedminus50 = New System.Windows.Forms.Button()
        Me.cmdspeedminus25 = New System.Windows.Forms.Button()
        Me.cmdspeed100 = New System.Windows.Forms.Button()
        Me.cmdspeed75 = New System.Windows.Forms.Button()
        Me.cmdspeed50 = New System.Windows.Forms.Button()
        Me.cmdspeed25 = New System.Windows.Forms.Button()
        Me.txtplayforslowmotion = New System.Windows.Forms.TextBox()
        Me.cmdplayforslowmotion = New System.Windows.Forms.Button()
        Me.lblinpointlist = New System.Windows.Forms.Label()
        Me.deletetsslowmotion = New System.Windows.Forms.Button()
        Me.uptsslowmotion = New System.Windows.Forms.Button()
        Me.downtsslowmotion = New System.Windows.Forms.Button()
        Me.inserttsslowmotion = New System.Windows.Forms.Button()
        Me.cmdmarkinslowmotion = New System.Windows.Forms.Button()
        Me.dgvslowmotion = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gotoin = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cmdLiveSeekEnd = New System.Windows.Forms.Button()
        Me.lblstrat_time_code = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.lblplayhead = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.lblspeedofslowmotion = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.cmdplaydecklinksm = New System.Windows.Forms.Button()
        Me.txtplaydecklinksm = New System.Windows.Forms.TextBox()
        Me.txtstoprecordforslowmotion = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.txtrecordforslowmotion = New System.Windows.Forms.TextBox()
        Me.cmdstoprecordforslowmotion = New System.Windows.Forms.Button()
        Me.cmdrecordforslowmotion = New System.Windows.Forms.Button()
        Me.cmdgotoin4 = New System.Windows.Forms.Button()
        Me.cmdgotoin3 = New System.Windows.Forms.Button()
        Me.cmdgotoin2 = New System.Windows.Forms.Button()
        Me.cmdgotoin1 = New System.Windows.Forms.Button()
        Me.txtmarkin4 = New System.Windows.Forms.TextBox()
        Me.txtmarkin3 = New System.Windows.Forms.TextBox()
        Me.txtmarkin2 = New System.Windows.Forms.TextBox()
        Me.txtmarkin1 = New System.Windows.Forms.TextBox()
        Me.nSlowMotion = New System.Windows.Forms.NumericUpDown()
        Me.gbSlowMotion.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.nSlowMotionbackward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nSlowMotionforward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvslowmotion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nSlowMotion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbSlowMotion
        '
        Me.gbSlowMotion.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.gbSlowMotion.Controls.Add(Me.MenuStrip1)
        Me.gbSlowMotion.Controls.Add(Me.cmdspeed0)
        Me.gbSlowMotion.Controls.Add(Me.lblslowmotionrecordsubsampling)
        Me.gbSlowMotion.Controls.Add(Me.lblslowmotionrecordquality)
        Me.gbSlowMotion.Controls.Add(Me.cmbslowmotionrecordsubsampling)
        Me.gbSlowMotion.Controls.Add(Me.cmbslowmotionrecordquality)
        Me.gbSlowMotion.Controls.Add(Me.LinkLabel1)
        Me.gbSlowMotion.Controls.Add(Me.Label81)
        Me.gbSlowMotion.Controls.Add(Me.nSlowMotionbackward)
        Me.gbSlowMotion.Controls.Add(Me.Label80)
        Me.gbSlowMotion.Controls.Add(Me.nSlowMotionforward)
        Me.gbSlowMotion.Controls.Add(Me.cmdspeedminus100)
        Me.gbSlowMotion.Controls.Add(Me.cmdspeedminus75)
        Me.gbSlowMotion.Controls.Add(Me.cmdspeedminus50)
        Me.gbSlowMotion.Controls.Add(Me.cmdspeedminus25)
        Me.gbSlowMotion.Controls.Add(Me.cmdspeed100)
        Me.gbSlowMotion.Controls.Add(Me.cmdspeed75)
        Me.gbSlowMotion.Controls.Add(Me.cmdspeed50)
        Me.gbSlowMotion.Controls.Add(Me.cmdspeed25)
        Me.gbSlowMotion.Controls.Add(Me.txtplayforslowmotion)
        Me.gbSlowMotion.Controls.Add(Me.cmdplayforslowmotion)
        Me.gbSlowMotion.Controls.Add(Me.lblinpointlist)
        Me.gbSlowMotion.Controls.Add(Me.deletetsslowmotion)
        Me.gbSlowMotion.Controls.Add(Me.uptsslowmotion)
        Me.gbSlowMotion.Controls.Add(Me.downtsslowmotion)
        Me.gbSlowMotion.Controls.Add(Me.inserttsslowmotion)
        Me.gbSlowMotion.Controls.Add(Me.cmdmarkinslowmotion)
        Me.gbSlowMotion.Controls.Add(Me.dgvslowmotion)
        Me.gbSlowMotion.Controls.Add(Me.cmdLiveSeekEnd)
        Me.gbSlowMotion.Controls.Add(Me.lblstrat_time_code)
        Me.gbSlowMotion.Controls.Add(Me.Label89)
        Me.gbSlowMotion.Controls.Add(Me.lblplayhead)
        Me.gbSlowMotion.Controls.Add(Me.Label88)
        Me.gbSlowMotion.Controls.Add(Me.lblspeedofslowmotion)
        Me.gbSlowMotion.Controls.Add(Me.Label86)
        Me.gbSlowMotion.Controls.Add(Me.Label85)
        Me.gbSlowMotion.Controls.Add(Me.Label84)
        Me.gbSlowMotion.Controls.Add(Me.Label83)
        Me.gbSlowMotion.Controls.Add(Me.Label82)
        Me.gbSlowMotion.Controls.Add(Me.cmdplaydecklinksm)
        Me.gbSlowMotion.Controls.Add(Me.txtplaydecklinksm)
        Me.gbSlowMotion.Controls.Add(Me.txtstoprecordforslowmotion)
        Me.gbSlowMotion.Controls.Add(Me.Label65)
        Me.gbSlowMotion.Controls.Add(Me.txtrecordforslowmotion)
        Me.gbSlowMotion.Controls.Add(Me.cmdstoprecordforslowmotion)
        Me.gbSlowMotion.Controls.Add(Me.cmdrecordforslowmotion)
        Me.gbSlowMotion.Controls.Add(Me.cmdgotoin4)
        Me.gbSlowMotion.Controls.Add(Me.cmdgotoin3)
        Me.gbSlowMotion.Controls.Add(Me.cmdgotoin2)
        Me.gbSlowMotion.Controls.Add(Me.cmdgotoin1)
        Me.gbSlowMotion.Controls.Add(Me.txtmarkin4)
        Me.gbSlowMotion.Controls.Add(Me.txtmarkin3)
        Me.gbSlowMotion.Controls.Add(Me.txtmarkin2)
        Me.gbSlowMotion.Controls.Add(Me.txtmarkin1)
        Me.gbSlowMotion.Controls.Add(Me.nSlowMotion)
        Me.gbSlowMotion.Location = New System.Drawing.Point(2, 2)
        Me.gbSlowMotion.Name = "gbSlowMotion"
        Me.gbSlowMotion.Size = New System.Drawing.Size(660, 605)
        Me.gbSlowMotion.TabIndex = 584
        Me.gbSlowMotion.TabStop = False
        Me.gbSlowMotion.Text = "Slow Motion in JStar software"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(180, 193)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(84, 24)
        Me.MenuStrip1.TabIndex = 719
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
        'cmdspeed0
        '
        Me.cmdspeed0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdspeed0.Location = New System.Drawing.Point(422, 115)
        Me.cmdspeed0.Name = "cmdspeed0"
        Me.cmdspeed0.Size = New System.Drawing.Size(142, 28)
        Me.cmdspeed0.TabIndex = 718
        Me.cmdspeed0.Text = "Pause 0%"
        Me.cmdspeed0.UseVisualStyleBackColor = True
        '
        'lblslowmotionrecordsubsampling
        '
        Me.lblslowmotionrecordsubsampling.AutoSize = True
        Me.lblslowmotionrecordsubsampling.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblslowmotionrecordsubsampling.Location = New System.Drawing.Point(181, 60)
        Me.lblslowmotionrecordsubsampling.Name = "lblslowmotionrecordsubsampling"
        Me.lblslowmotionrecordsubsampling.Size = New System.Drawing.Size(65, 13)
        Me.lblslowmotionrecordsubsampling.TabIndex = 648
        Me.lblslowmotionrecordsubsampling.Text = "subsampling"
        '
        'lblslowmotionrecordquality
        '
        Me.lblslowmotionrecordquality.AutoSize = True
        Me.lblslowmotionrecordquality.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblslowmotionrecordquality.Location = New System.Drawing.Point(138, 59)
        Me.lblslowmotionrecordquality.Name = "lblslowmotionrecordquality"
        Me.lblslowmotionrecordquality.Size = New System.Drawing.Size(37, 13)
        Me.lblslowmotionrecordquality.TabIndex = 647
        Me.lblslowmotionrecordquality.Text = "quality"
        '
        'cmbslowmotionrecordsubsampling
        '
        Me.cmbslowmotionrecordsubsampling.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbslowmotionrecordsubsampling", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbslowmotionrecordsubsampling.FormattingEnabled = True
        Me.cmbslowmotionrecordsubsampling.Items.AddRange(New Object() {"444", "422", "420", "411"})
        Me.cmbslowmotionrecordsubsampling.Location = New System.Drawing.Point(186, 76)
        Me.cmbslowmotionrecordsubsampling.Name = "cmbslowmotionrecordsubsampling"
        Me.cmbslowmotionrecordsubsampling.Size = New System.Drawing.Size(41, 21)
        Me.cmbslowmotionrecordsubsampling.TabIndex = 646
        Me.cmbslowmotionrecordsubsampling.Text = "422"
        '
        'cmbslowmotionrecordquality
        '
        Me.cmbslowmotionrecordquality.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbslowmotionrecordquality", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbslowmotionrecordquality.FormattingEnabled = True
        Me.cmbslowmotionrecordquality.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60", "70", "80", "90", "100"})
        Me.cmbslowmotionrecordquality.Location = New System.Drawing.Point(134, 74)
        Me.cmbslowmotionrecordquality.Name = "cmbslowmotionrecordquality"
        Me.cmbslowmotionrecordquality.Size = New System.Drawing.Size(40, 21)
        Me.cmbslowmotionrecordquality.TabIndex = 645
        Me.cmbslowmotionrecordquality.Text = "90"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(10, 14)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(261, 13)
        Me.LinkLabel1.TabIndex = 644
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://casparcg.com/forum/viewtopic.php?f=3&t=1310"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(309, 78)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(87, 24)
        Me.Label81.TabIndex = 643
        Me.Label81.Text = "Reverse"
        '
        'nSlowMotionbackward
        '
        Me.nSlowMotionbackward.DecimalPlaces = 2
        Me.nSlowMotionbackward.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nSlowMotionbackward.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nSlowMotionbackward.Location = New System.Drawing.Point(402, 78)
        Me.nSlowMotionbackward.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nSlowMotionbackward.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.nSlowMotionbackward.Name = "nSlowMotionbackward"
        Me.nSlowMotionbackward.Size = New System.Drawing.Size(66, 31)
        Me.nSlowMotionbackward.TabIndex = 642
        Me.nSlowMotionbackward.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(309, 49)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(87, 24)
        Me.Label80.TabIndex = 641
        Me.Label80.Text = "Forward"
        '
        'nSlowMotionforward
        '
        Me.nSlowMotionforward.DecimalPlaces = 2
        Me.nSlowMotionforward.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nSlowMotionforward.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nSlowMotionforward.Location = New System.Drawing.Point(402, 45)
        Me.nSlowMotionforward.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nSlowMotionforward.Name = "nSlowMotionforward"
        Me.nSlowMotionforward.Size = New System.Drawing.Size(66, 31)
        Me.nSlowMotionforward.TabIndex = 640
        Me.nSlowMotionforward.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nSlowMotionforward.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'cmdspeedminus100
        '
        Me.cmdspeedminus100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdspeedminus100.Location = New System.Drawing.Point(474, 86)
        Me.cmdspeedminus100.Name = "cmdspeedminus100"
        Me.cmdspeedminus100.Size = New System.Drawing.Size(53, 23)
        Me.cmdspeedminus100.TabIndex = 639
        Me.cmdspeedminus100.Text = "-100%"
        Me.cmdspeedminus100.UseVisualStyleBackColor = True
        '
        'cmdspeedminus75
        '
        Me.cmdspeedminus75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdspeedminus75.Location = New System.Drawing.Point(474, 62)
        Me.cmdspeedminus75.Name = "cmdspeedminus75"
        Me.cmdspeedminus75.Size = New System.Drawing.Size(53, 23)
        Me.cmdspeedminus75.TabIndex = 638
        Me.cmdspeedminus75.Text = "-75%"
        Me.cmdspeedminus75.UseVisualStyleBackColor = True
        '
        'cmdspeedminus50
        '
        Me.cmdspeedminus50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdspeedminus50.Location = New System.Drawing.Point(474, 38)
        Me.cmdspeedminus50.Name = "cmdspeedminus50"
        Me.cmdspeedminus50.Size = New System.Drawing.Size(53, 23)
        Me.cmdspeedminus50.TabIndex = 637
        Me.cmdspeedminus50.Text = "-50%"
        Me.cmdspeedminus50.UseVisualStyleBackColor = True
        '
        'cmdspeedminus25
        '
        Me.cmdspeedminus25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdspeedminus25.Location = New System.Drawing.Point(474, 13)
        Me.cmdspeedminus25.Name = "cmdspeedminus25"
        Me.cmdspeedminus25.Size = New System.Drawing.Size(53, 23)
        Me.cmdspeedminus25.TabIndex = 636
        Me.cmdspeedminus25.Text = "-25%"
        Me.cmdspeedminus25.UseVisualStyleBackColor = True
        '
        'cmdspeed100
        '
        Me.cmdspeed100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdspeed100.Location = New System.Drawing.Point(533, 86)
        Me.cmdspeed100.Name = "cmdspeed100"
        Me.cmdspeed100.Size = New System.Drawing.Size(53, 23)
        Me.cmdspeed100.TabIndex = 635
        Me.cmdspeed100.Text = "100%"
        Me.cmdspeed100.UseVisualStyleBackColor = True
        '
        'cmdspeed75
        '
        Me.cmdspeed75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdspeed75.Location = New System.Drawing.Point(533, 62)
        Me.cmdspeed75.Name = "cmdspeed75"
        Me.cmdspeed75.Size = New System.Drawing.Size(53, 23)
        Me.cmdspeed75.TabIndex = 634
        Me.cmdspeed75.Text = "75%"
        Me.cmdspeed75.UseVisualStyleBackColor = True
        '
        'cmdspeed50
        '
        Me.cmdspeed50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdspeed50.Location = New System.Drawing.Point(533, 38)
        Me.cmdspeed50.Name = "cmdspeed50"
        Me.cmdspeed50.Size = New System.Drawing.Size(53, 23)
        Me.cmdspeed50.TabIndex = 633
        Me.cmdspeed50.Text = "50%"
        Me.cmdspeed50.UseVisualStyleBackColor = True
        '
        'cmdspeed25
        '
        Me.cmdspeed25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdspeed25.Location = New System.Drawing.Point(533, 13)
        Me.cmdspeed25.Name = "cmdspeed25"
        Me.cmdspeed25.Size = New System.Drawing.Size(53, 23)
        Me.cmdspeed25.TabIndex = 632
        Me.cmdspeed25.Text = "25%"
        Me.cmdspeed25.UseVisualStyleBackColor = True
        '
        'txtplayforslowmotion
        '
        Me.txtplayforslowmotion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtplayforslowmotion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtplayforslowmotion.Location = New System.Drawing.Point(7, 102)
        Me.txtplayforslowmotion.Name = "txtplayforslowmotion"
        Me.txtplayforslowmotion.Size = New System.Drawing.Size(119, 20)
        Me.txtplayforslowmotion.TabIndex = 631
        Me.txtplayforslowmotion.Text = Global.caspar_media_playback.My.MySettings.Default.txtplayforslowmotion
        '
        'cmdplayforslowmotion
        '
        Me.cmdplayforslowmotion.Location = New System.Drawing.Point(128, 99)
        Me.cmdplayforslowmotion.Name = "cmdplayforslowmotion"
        Me.cmdplayforslowmotion.Size = New System.Drawing.Size(75, 23)
        Me.cmdplayforslowmotion.TabIndex = 630
        Me.cmdplayforslowmotion.Text = "Play"
        Me.cmdplayforslowmotion.UseVisualStyleBackColor = True
        '
        'lblinpointlist
        '
        Me.lblinpointlist.AutoSize = True
        Me.lblinpointlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinpointlist.Location = New System.Drawing.Point(179, 174)
        Me.lblinpointlist.Name = "lblinpointlist"
        Me.lblinpointlist.Size = New System.Drawing.Size(93, 13)
        Me.lblinpointlist.TabIndex = 629
        Me.lblinpointlist.Text = "In Point List Name"
        '
        'deletetsslowmotion
        '
        Me.deletetsslowmotion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletetsslowmotion.Image = Global.caspar_media_playback.My.Resources.Resources.minus
        Me.deletetsslowmotion.Location = New System.Drawing.Point(521, 194)
        Me.deletetsslowmotion.Name = "deletetsslowmotion"
        Me.deletetsslowmotion.Size = New System.Drawing.Size(26, 22)
        Me.deletetsslowmotion.TabIndex = 628
        Me.deletetsslowmotion.UseVisualStyleBackColor = True
        '
        'uptsslowmotion
        '
        Me.uptsslowmotion.Image = CType(resources.GetObject("uptsslowmotion.Image"), System.Drawing.Image)
        Me.uptsslowmotion.Location = New System.Drawing.Point(410, 193)
        Me.uptsslowmotion.Name = "uptsslowmotion"
        Me.uptsslowmotion.Size = New System.Drawing.Size(21, 23)
        Me.uptsslowmotion.TabIndex = 626
        Me.uptsslowmotion.UseVisualStyleBackColor = True
        '
        'downtsslowmotion
        '
        Me.downtsslowmotion.Image = CType(resources.GetObject("downtsslowmotion.Image"), System.Drawing.Image)
        Me.downtsslowmotion.Location = New System.Drawing.Point(442, 193)
        Me.downtsslowmotion.Name = "downtsslowmotion"
        Me.downtsslowmotion.Size = New System.Drawing.Size(29, 23)
        Me.downtsslowmotion.TabIndex = 627
        Me.downtsslowmotion.UseVisualStyleBackColor = True
        '
        'inserttsslowmotion
        '
        Me.inserttsslowmotion.Image = CType(resources.GetObject("inserttsslowmotion.Image"), System.Drawing.Image)
        Me.inserttsslowmotion.Location = New System.Drawing.Point(479, 193)
        Me.inserttsslowmotion.Name = "inserttsslowmotion"
        Me.inserttsslowmotion.Size = New System.Drawing.Size(34, 23)
        Me.inserttsslowmotion.TabIndex = 625
        Me.inserttsslowmotion.UseVisualStyleBackColor = True
        '
        'cmdmarkinslowmotion
        '
        Me.cmdmarkinslowmotion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdmarkinslowmotion.Location = New System.Drawing.Point(553, 214)
        Me.cmdmarkinslowmotion.Name = "cmdmarkinslowmotion"
        Me.cmdmarkinslowmotion.Size = New System.Drawing.Size(74, 385)
        Me.cmdmarkinslowmotion.TabIndex = 623
        Me.cmdmarkinslowmotion.Text = "Mark IN"
        Me.cmdmarkinslowmotion.UseVisualStyleBackColor = True
        '
        'dgvslowmotion
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvslowmotion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvslowmotion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvslowmotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvslowmotion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.gotoin})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvslowmotion.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvslowmotion.Location = New System.Drawing.Point(180, 219)
        Me.dgvslowmotion.Name = "dgvslowmotion"
        Me.dgvslowmotion.Size = New System.Drawing.Size(367, 380)
        Me.dgvslowmotion.TabIndex = 622
        '
        'Column2
        '
        Me.Column2.HeaderText = "IN Point Name"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column1
        '
        Me.Column1.HeaderText = "In Point"
        Me.Column1.Name = "Column1"
        '
        'gotoin
        '
        Me.gotoin.HeaderText = "Go To In"
        Me.gotoin.Name = "gotoin"
        Me.gotoin.Width = 60
        '
        'cmdLiveSeekEnd
        '
        Me.cmdLiveSeekEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLiveSeekEnd.Location = New System.Drawing.Point(10, 155)
        Me.cmdLiveSeekEnd.Name = "cmdLiveSeekEnd"
        Me.cmdLiveSeekEnd.Size = New System.Drawing.Size(106, 30)
        Me.cmdLiveSeekEnd.TabIndex = 621
        Me.cmdLiveSeekEnd.Text = "Live (Seek End)"
        Me.cmdLiveSeekEnd.UseVisualStyleBackColor = True
        '
        'lblstrat_time_code
        '
        Me.lblstrat_time_code.AutoSize = True
        Me.lblstrat_time_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstrat_time_code.Location = New System.Drawing.Point(22, 415)
        Me.lblstrat_time_code.Name = "lblstrat_time_code"
        Me.lblstrat_time_code.Size = New System.Drawing.Size(97, 13)
        Me.lblstrat_time_code.TabIndex = 620
        Me.lblstrat_time_code.Text = "strat_time_code"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(12, 398)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(118, 16)
        Me.Label89.TabIndex = 619
        Me.Label89.Text = "strat_time_code"
        '
        'lblplayhead
        '
        Me.lblplayhead.AutoSize = True
        Me.lblplayhead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblplayhead.Location = New System.Drawing.Point(81, 354)
        Me.lblplayhead.Name = "lblplayhead"
        Me.lblplayhead.Size = New System.Drawing.Size(74, 16)
        Me.lblplayhead.TabIndex = 618
        Me.lblplayhead.Text = "Playhead"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(1, 355)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(74, 16)
        Me.Label88.TabIndex = 617
        Me.Label88.Text = "Playhead"
        '
        'lblspeedofslowmotion
        '
        Me.lblspeedofslowmotion.AutoSize = True
        Me.lblspeedofslowmotion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblspeedofslowmotion.Location = New System.Drawing.Point(502, 149)
        Me.lblspeedofslowmotion.Name = "lblspeedofslowmotion"
        Me.lblspeedofslowmotion.Size = New System.Drawing.Size(97, 31)
        Me.lblspeedofslowmotion.TabIndex = 616
        Me.lblspeedofslowmotion.Text = "Speed"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(395, 158)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(101, 16)
        Me.Label86.TabIndex = 615
        Me.Label86.Text = "Actual Speed"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(8, 316)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(110, 16)
        Me.Label85.TabIndex = 614
        Me.Label85.Text = "Frame Backward"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(8, 274)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(99, 16)
        Me.Label84.TabIndex = 613
        Me.Label84.Text = "Frame Forward"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(8, 228)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(96, 16)
        Me.Label83.TabIndex = 612
        Me.Label83.Text = "Seek from End"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(8, 186)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(132, 16)
        Me.Label82.TabIndex = 611
        Me.Label82.Text = "Seek from Beginning"
        '
        'cmdplaydecklinksm
        '
        Me.cmdplaydecklinksm.Location = New System.Drawing.Point(127, 30)
        Me.cmdplaydecklinksm.Name = "cmdplaydecklinksm"
        Me.cmdplaydecklinksm.Size = New System.Drawing.Size(75, 23)
        Me.cmdplaydecklinksm.TabIndex = 607
        Me.cmdplaydecklinksm.Text = "Input"
        Me.cmdplaydecklinksm.UseVisualStyleBackColor = True
        '
        'txtplaydecklinksm
        '
        Me.txtplaydecklinksm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtplaydecklinksm", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtplaydecklinksm.Location = New System.Drawing.Point(6, 33)
        Me.txtplaydecklinksm.Name = "txtplaydecklinksm"
        Me.txtplaydecklinksm.Size = New System.Drawing.Size(124, 20)
        Me.txtplaydecklinksm.TabIndex = 606
        Me.txtplaydecklinksm.Text = Global.caspar_media_playback.My.MySettings.Default.txtplaydecklinksm
        '
        'txtstoprecordforslowmotion
        '
        Me.txtstoprecordforslowmotion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtstoprecordforslowmotion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtstoprecordforslowmotion.Location = New System.Drawing.Point(7, 127)
        Me.txtstoprecordforslowmotion.Name = "txtstoprecordforslowmotion"
        Me.txtstoprecordforslowmotion.Size = New System.Drawing.Size(119, 20)
        Me.txtstoprecordforslowmotion.TabIndex = 603
        Me.txtstoprecordforslowmotion.Text = Global.caspar_media_playback.My.MySettings.Default.txtstoprecordforslowmotion
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(347, 14)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(49, 24)
        Me.Label65.TabIndex = 602
        Me.Label65.Text = "Fast"
        '
        'txtrecordforslowmotion
        '
        Me.txtrecordforslowmotion.AcceptsReturn = True
        Me.txtrecordforslowmotion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtrecordforslowmotion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtrecordforslowmotion.Location = New System.Drawing.Point(6, 74)
        Me.txtrecordforslowmotion.Name = "txtrecordforslowmotion"
        Me.txtrecordforslowmotion.Size = New System.Drawing.Size(119, 20)
        Me.txtrecordforslowmotion.TabIndex = 601
        Me.txtrecordforslowmotion.Text = Global.caspar_media_playback.My.MySettings.Default.txtrecordforslowmotion
        '
        'cmdstoprecordforslowmotion
        '
        Me.cmdstoprecordforslowmotion.Location = New System.Drawing.Point(128, 124)
        Me.cmdstoprecordforslowmotion.Name = "cmdstoprecordforslowmotion"
        Me.cmdstoprecordforslowmotion.Size = New System.Drawing.Size(75, 23)
        Me.cmdstoprecordforslowmotion.TabIndex = 600
        Me.cmdstoprecordforslowmotion.Text = "Stop Record"
        Me.cmdstoprecordforslowmotion.UseVisualStyleBackColor = True
        '
        'cmdrecordforslowmotion
        '
        Me.cmdrecordforslowmotion.BackColor = System.Drawing.Color.Red
        Me.cmdrecordforslowmotion.Location = New System.Drawing.Point(236, 75)
        Me.cmdrecordforslowmotion.Name = "cmdrecordforslowmotion"
        Me.cmdrecordforslowmotion.Size = New System.Drawing.Size(58, 23)
        Me.cmdrecordforslowmotion.TabIndex = 599
        Me.cmdrecordforslowmotion.Text = "Record"
        Me.cmdrecordforslowmotion.UseVisualStyleBackColor = False
        '
        'cmdgotoin4
        '
        Me.cmdgotoin4.Location = New System.Drawing.Point(59, 330)
        Me.cmdgotoin4.Name = "cmdgotoin4"
        Me.cmdgotoin4.Size = New System.Drawing.Size(76, 23)
        Me.cmdgotoin4.TabIndex = 598
        Me.cmdgotoin4.Text = "Go"
        Me.cmdgotoin4.UseVisualStyleBackColor = True
        '
        'cmdgotoin3
        '
        Me.cmdgotoin3.Location = New System.Drawing.Point(59, 288)
        Me.cmdgotoin3.Name = "cmdgotoin3"
        Me.cmdgotoin3.Size = New System.Drawing.Size(76, 23)
        Me.cmdgotoin3.TabIndex = 597
        Me.cmdgotoin3.Text = "Go"
        Me.cmdgotoin3.UseVisualStyleBackColor = True
        '
        'cmdgotoin2
        '
        Me.cmdgotoin2.Location = New System.Drawing.Point(61, 243)
        Me.cmdgotoin2.Name = "cmdgotoin2"
        Me.cmdgotoin2.Size = New System.Drawing.Size(76, 23)
        Me.cmdgotoin2.TabIndex = 596
        Me.cmdgotoin2.Text = "seek"
        Me.cmdgotoin2.UseVisualStyleBackColor = True
        '
        'cmdgotoin1
        '
        Me.cmdgotoin1.Location = New System.Drawing.Point(59, 200)
        Me.cmdgotoin1.Name = "cmdgotoin1"
        Me.cmdgotoin1.Size = New System.Drawing.Size(76, 23)
        Me.cmdgotoin1.TabIndex = 595
        Me.cmdgotoin1.Text = "seek"
        Me.cmdgotoin1.UseVisualStyleBackColor = True
        '
        'txtmarkin4
        '
        Me.txtmarkin4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtmarkin4", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtmarkin4.Location = New System.Drawing.Point(10, 332)
        Me.txtmarkin4.Name = "txtmarkin4"
        Me.txtmarkin4.Size = New System.Drawing.Size(43, 20)
        Me.txtmarkin4.TabIndex = 590
        Me.txtmarkin4.Text = "100"
        '
        'txtmarkin3
        '
        Me.txtmarkin3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtmarkin3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtmarkin3.Location = New System.Drawing.Point(10, 289)
        Me.txtmarkin3.Name = "txtmarkin3"
        Me.txtmarkin3.Size = New System.Drawing.Size(43, 20)
        Me.txtmarkin3.TabIndex = 589
        Me.txtmarkin3.Text = "100"
        '
        'txtmarkin2
        '
        Me.txtmarkin2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtmarkin2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtmarkin2.Location = New System.Drawing.Point(12, 243)
        Me.txtmarkin2.Name = "txtmarkin2"
        Me.txtmarkin2.Size = New System.Drawing.Size(43, 20)
        Me.txtmarkin2.TabIndex = 588
        Me.txtmarkin2.Text = "100"
        '
        'txtmarkin1
        '
        Me.txtmarkin1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtmarkin1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtmarkin1.Location = New System.Drawing.Point(10, 200)
        Me.txtmarkin1.Name = "txtmarkin1"
        Me.txtmarkin1.Size = New System.Drawing.Size(43, 20)
        Me.txtmarkin1.TabIndex = 587
        Me.txtmarkin1.Text = "100"
        '
        'nSlowMotion
        '
        Me.nSlowMotion.DecimalPlaces = 2
        Me.nSlowMotion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nSlowMotion.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nSlowMotion.Location = New System.Drawing.Point(402, 12)
        Me.nSlowMotion.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nSlowMotion.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.nSlowMotion.Name = "nSlowMotion"
        Me.nSlowMotion.Size = New System.Drawing.Size(66, 31)
        Me.nSlowMotion.TabIndex = 0
        Me.nSlowMotion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nSlowMotion.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'ucSlowMotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1221, 749)
        Me.Controls.Add(Me.gbSlowMotion)
        Me.HideOnClose = True
        Me.Name = "ucSlowMotion"
        Me.Text = "Slow Motion Jstar and  Krzyc"
        Me.gbSlowMotion.ResumeLayout(False)
        Me.gbSlowMotion.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.nSlowMotionbackward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nSlowMotionforward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvslowmotion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nSlowMotion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbSlowMotion As System.Windows.Forms.GroupBox
    Friend WithEvents lblslowmotionrecordsubsampling As System.Windows.Forms.Label
    Friend WithEvents lblslowmotionrecordquality As System.Windows.Forms.Label
    Friend WithEvents cmbslowmotionrecordsubsampling As System.Windows.Forms.ComboBox
    Friend WithEvents cmbslowmotionrecordquality As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents nSlowMotionbackward As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents nSlowMotionforward As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdspeedminus100 As System.Windows.Forms.Button
    Friend WithEvents cmdspeedminus75 As System.Windows.Forms.Button
    Friend WithEvents cmdspeedminus50 As System.Windows.Forms.Button
    Friend WithEvents cmdspeedminus25 As System.Windows.Forms.Button
    Friend WithEvents cmdspeed100 As System.Windows.Forms.Button
    Friend WithEvents cmdspeed75 As System.Windows.Forms.Button
    Friend WithEvents cmdspeed50 As System.Windows.Forms.Button
    Friend WithEvents cmdspeed25 As System.Windows.Forms.Button
    Friend WithEvents txtplayforslowmotion As System.Windows.Forms.TextBox
    Friend WithEvents cmdplayforslowmotion As System.Windows.Forms.Button
    Friend WithEvents lblinpointlist As System.Windows.Forms.Label
    Friend WithEvents deletetsslowmotion As System.Windows.Forms.Button
    Friend WithEvents uptsslowmotion As System.Windows.Forms.Button
    Friend WithEvents downtsslowmotion As System.Windows.Forms.Button
    Friend WithEvents inserttsslowmotion As System.Windows.Forms.Button
    Friend WithEvents cmdmarkinslowmotion As System.Windows.Forms.Button
    Friend WithEvents dgvslowmotion As System.Windows.Forms.DataGridView
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gotoin As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cmdLiveSeekEnd As System.Windows.Forms.Button
    Friend WithEvents lblstrat_time_code As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents lblplayhead As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents lblspeedofslowmotion As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents cmdplaydecklinksm As System.Windows.Forms.Button
    Friend WithEvents txtplaydecklinksm As System.Windows.Forms.TextBox
    Friend WithEvents txtstoprecordforslowmotion As System.Windows.Forms.TextBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents txtrecordforslowmotion As System.Windows.Forms.TextBox
    Friend WithEvents cmdstoprecordforslowmotion As System.Windows.Forms.Button
    Friend WithEvents cmdrecordforslowmotion As System.Windows.Forms.Button
    Friend WithEvents cmdgotoin4 As System.Windows.Forms.Button
    Friend WithEvents cmdgotoin3 As System.Windows.Forms.Button
    Friend WithEvents cmdgotoin2 As System.Windows.Forms.Button
    Friend WithEvents cmdgotoin1 As System.Windows.Forms.Button
    Friend WithEvents txtmarkin4 As System.Windows.Forms.TextBox
    Friend WithEvents txtmarkin3 As System.Windows.Forms.TextBox
    Friend WithEvents txtmarkin2 As System.Windows.Forms.TextBox
    Friend WithEvents txtmarkin1 As System.Windows.Forms.TextBox
    Friend WithEvents nSlowMotion As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdspeed0 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
End Class
