<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucTemplate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTemplate))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbtemplate = New System.Windows.Forms.GroupBox()
        Me.cmdUpdatePreview = New System.Windows.Forms.Button()
        Me.picanytemplate = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.chkLBand = New System.Windows.Forms.CheckBox()
        Me.txtLBand = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkanimatetemplate = New System.Windows.Forms.CheckBox()
        Me.gbrundown = New System.Windows.Forms.GroupBox()
        Me.lblsheduleStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label269 = New System.Windows.Forms.Label()
        Me.Label268 = New System.Windows.Forms.Label()
        Me.txtadjusttimeofrundownsec = New System.Windows.Forms.TextBox()
        Me.txtadjusttimeofrundownmin = New System.Windows.Forms.TextBox()
        Me.cmdadjusttimeofrundown = New System.Windows.Forms.Button()
        Me.cmdstopsheduletemplate = New System.Windows.Forms.Button()
        Me.cmdstartsheduletemplate = New System.Windows.Forms.Button()
        Me.cmbrundowninvoke = New System.Windows.Forms.ComboBox()
        Me.cmdrundowninvoke = New System.Windows.Forms.Button()
        Me.removetsrundown = New System.Windows.Forms.Button()
        Me.nexttsrundown = New System.Windows.Forms.Button()
        Me.uptsrundown = New System.Windows.Forms.Button()
        Me.downtsrundown = New System.Windows.Forms.Button()
        Me.addtsrundown = New System.Windows.Forms.Button()
        Me.playtsrundown = New System.Windows.Forms.Button()
        Me.stoptsrundown = New System.Windows.Forms.Button()
        Me.dgvrundown = New System.Windows.Forms.DataGridView()
        Me.Label = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.V = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdaddtorundown = New System.Windows.Forms.Button()
        Me.dgvanytemplate = New System.Windows.Forms.DataGridView()
        Me.InstanceName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cmbvideolayerfortemplate = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbinvoke = New System.Windows.Forms.ComboBox()
        Me.cmdinvoke = New System.Windows.Forms.Button()
        Me.cmdupdatetemplate = New System.Windows.Forms.Button()
        Me.cmblayertemplate = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmdnextframe = New System.Windows.Forms.Button()
        Me.txtsearchtemplate = New System.Windows.Forms.TextBox()
        Me.lsttemplate = New System.Windows.Forms.ListBox()
        Me.cmdclipsearchtemplate = New System.Windows.Forms.Button()
        Me.cmbfonttemplate = New System.Windows.Forms.ComboBox()
        Me.cmdanytemplatestop = New System.Windows.Forms.Button()
        Me.cmdanytemplateplay = New System.Windows.Forms.Button()
        Me.tmrsheduletemplatestart = New System.Windows.Forms.Timer(Me.components)
        Me.tmrshedultemplateend = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdOnlyUpdatePreview = New System.Windows.Forms.Button()
        Me.gbtemplate.SuspendLayout()
        CType(Me.picanytemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbrundown.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvrundown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvanytemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbtemplate
        '
        Me.gbtemplate.BackColor = System.Drawing.Color.LightGreen
        Me.gbtemplate.Controls.Add(Me.cmdOnlyUpdatePreview)
        Me.gbtemplate.Controls.Add(Me.cmdUpdatePreview)
        Me.gbtemplate.Controls.Add(Me.picanytemplate)
        Me.gbtemplate.Controls.Add(Me.chkLBand)
        Me.gbtemplate.Controls.Add(Me.txtLBand)
        Me.gbtemplate.Controls.Add(Me.Label2)
        Me.gbtemplate.Controls.Add(Me.chkanimatetemplate)
        Me.gbtemplate.Controls.Add(Me.gbrundown)
        Me.gbtemplate.Controls.Add(Me.cmdaddtorundown)
        Me.gbtemplate.Controls.Add(Me.dgvanytemplate)
        Me.gbtemplate.Controls.Add(Me.cmbvideolayerfortemplate)
        Me.gbtemplate.Controls.Add(Me.Label10)
        Me.gbtemplate.Controls.Add(Me.cmbinvoke)
        Me.gbtemplate.Controls.Add(Me.cmdinvoke)
        Me.gbtemplate.Controls.Add(Me.cmdupdatetemplate)
        Me.gbtemplate.Controls.Add(Me.cmblayertemplate)
        Me.gbtemplate.Controls.Add(Me.Label19)
        Me.gbtemplate.Controls.Add(Me.cmdnextframe)
        Me.gbtemplate.Controls.Add(Me.txtsearchtemplate)
        Me.gbtemplate.Controls.Add(Me.lsttemplate)
        Me.gbtemplate.Controls.Add(Me.cmdclipsearchtemplate)
        Me.gbtemplate.Controls.Add(Me.cmbfonttemplate)
        Me.gbtemplate.Controls.Add(Me.cmdanytemplatestop)
        Me.gbtemplate.Controls.Add(Me.cmdanytemplateplay)
        Me.gbtemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtemplate.Location = New System.Drawing.Point(3, 3)
        Me.gbtemplate.Margin = New System.Windows.Forms.Padding(0)
        Me.gbtemplate.Name = "gbtemplate"
        Me.gbtemplate.Size = New System.Drawing.Size(1220, 920)
        Me.gbtemplate.TabIndex = 425
        Me.gbtemplate.TabStop = False
        Me.gbtemplate.Text = " "
        '
        'cmdUpdatePreview
        '
        Me.cmdUpdatePreview.Location = New System.Drawing.Point(1020, 59)
        Me.cmdUpdatePreview.Name = "cmdUpdatePreview"
        Me.cmdUpdatePreview.Size = New System.Drawing.Size(92, 23)
        Me.cmdUpdatePreview.TabIndex = 646
        Me.cmdUpdatePreview.Text = "Add to Preview"
        Me.cmdUpdatePreview.UseVisualStyleBackColor = True
        '
        'picanytemplate
        '
        Me.picanytemplate.Enabled = True
        Me.picanytemplate.Location = New System.Drawing.Point(290, 36)
        Me.picanytemplate.MaximumSize = New System.Drawing.Size(500, 500)
        Me.picanytemplate.Name = "picanytemplate"
        Me.picanytemplate.OcxState = CType(resources.GetObject("picanytemplate.OcxState"), System.Windows.Forms.AxHost.State)
        Me.picanytemplate.Size = New System.Drawing.Size(399, 342)
        Me.picanytemplate.TabIndex = 644
        '
        'chkLBand
        '
        Me.chkLBand.AutoSize = True
        Me.chkLBand.Location = New System.Drawing.Point(888, 56)
        Me.chkLBand.Name = "chkLBand"
        Me.chkLBand.Size = New System.Drawing.Size(133, 17)
        Me.chkLBand.TabIndex = 643
        Me.chkLBand.Text = "Apply L band Squeeze"
        Me.chkLBand.UseVisualStyleBackColor = True
        '
        'txtLBand
        '
        Me.txtLBand.Location = New System.Drawing.Point(695, 56)
        Me.txtLBand.Name = "txtLBand"
        Me.txtLBand.Size = New System.Drawing.Size(187, 20)
        Me.txtLBand.TabIndex = 642
        Me.txtLBand.Text = "fill 0.18 0 0.82 0.83 25 easeoutexpo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(696, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 641
        Me.Label2.Text = "L Band squeeze"
        '
        'chkanimatetemplate
        '
        Me.chkanimatetemplate.AutoSize = True
        Me.chkanimatetemplate.Checked = True
        Me.chkanimatetemplate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkanimatetemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkanimatetemplate.Location = New System.Drawing.Point(1116, 36)
        Me.chkanimatetemplate.Name = "chkanimatetemplate"
        Me.chkanimatetemplate.Size = New System.Drawing.Size(64, 17)
        Me.chkanimatetemplate.TabIndex = 640
        Me.chkanimatetemplate.Text = "Animate"
        Me.chkanimatetemplate.UseVisualStyleBackColor = True
        '
        'gbrundown
        '
        Me.gbrundown.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.gbrundown.Controls.Add(Me.lblsheduleStatus)
        Me.gbrundown.Controls.Add(Me.Label1)
        Me.gbrundown.Controls.Add(Me.MenuStrip1)
        Me.gbrundown.Controls.Add(Me.Label269)
        Me.gbrundown.Controls.Add(Me.Label268)
        Me.gbrundown.Controls.Add(Me.txtadjusttimeofrundownsec)
        Me.gbrundown.Controls.Add(Me.txtadjusttimeofrundownmin)
        Me.gbrundown.Controls.Add(Me.cmdadjusttimeofrundown)
        Me.gbrundown.Controls.Add(Me.cmdstopsheduletemplate)
        Me.gbrundown.Controls.Add(Me.cmdstartsheduletemplate)
        Me.gbrundown.Controls.Add(Me.cmbrundowninvoke)
        Me.gbrundown.Controls.Add(Me.cmdrundowninvoke)
        Me.gbrundown.Controls.Add(Me.removetsrundown)
        Me.gbrundown.Controls.Add(Me.nexttsrundown)
        Me.gbrundown.Controls.Add(Me.uptsrundown)
        Me.gbrundown.Controls.Add(Me.downtsrundown)
        Me.gbrundown.Controls.Add(Me.addtsrundown)
        Me.gbrundown.Controls.Add(Me.playtsrundown)
        Me.gbrundown.Controls.Add(Me.stoptsrundown)
        Me.gbrundown.Controls.Add(Me.dgvrundown)
        Me.gbrundown.Location = New System.Drawing.Point(6, 378)
        Me.gbrundown.Name = "gbrundown"
        Me.gbrundown.Size = New System.Drawing.Size(684, 502)
        Me.gbrundown.TabIndex = 638
        Me.gbrundown.TabStop = False
        Me.gbrundown.Text = "Rundown"
        '
        'lblsheduleStatus
        '
        Me.lblsheduleStatus.AutoSize = True
        Me.lblsheduleStatus.BackColor = System.Drawing.Color.Red
        Me.lblsheduleStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsheduleStatus.Location = New System.Drawing.Point(212, 39)
        Me.lblsheduleStatus.Name = "lblsheduleStatus"
        Me.lblsheduleStatus.Size = New System.Drawing.Size(147, 20)
        Me.lblsheduleStatus.TabIndex = 1177
        Me.lblsheduleStatus.Text = "Schedule Stoped"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(110, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 24)
        Me.Label1.TabIndex = 1176
        Me.Label1.Text = "Play or Schedule"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(4, 14)
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
        'Label269
        '
        Me.Label269.AutoSize = True
        Me.Label269.Location = New System.Drawing.Point(617, 43)
        Me.Label269.Name = "Label269"
        Me.Label269.Size = New System.Drawing.Size(26, 13)
        Me.Label269.TabIndex = 1175
        Me.Label269.Text = "Sec"
        '
        'Label268
        '
        Me.Label268.AutoSize = True
        Me.Label268.Location = New System.Drawing.Point(558, 41)
        Me.Label268.Name = "Label268"
        Me.Label268.Size = New System.Drawing.Size(24, 13)
        Me.Label268.TabIndex = 1174
        Me.Label268.Text = "Min"
        '
        'txtadjusttimeofrundownsec
        '
        Me.txtadjusttimeofrundownsec.Location = New System.Drawing.Point(588, 40)
        Me.txtadjusttimeofrundownsec.Name = "txtadjusttimeofrundownsec"
        Me.txtadjusttimeofrundownsec.Size = New System.Drawing.Size(28, 20)
        Me.txtadjusttimeofrundownsec.TabIndex = 533
        Me.txtadjusttimeofrundownsec.Text = "00"
        '
        'txtadjusttimeofrundownmin
        '
        Me.txtadjusttimeofrundownmin.Location = New System.Drawing.Point(528, 39)
        Me.txtadjusttimeofrundownmin.Name = "txtadjusttimeofrundownmin"
        Me.txtadjusttimeofrundownmin.Size = New System.Drawing.Size(27, 20)
        Me.txtadjusttimeofrundownmin.TabIndex = 532
        Me.txtadjusttimeofrundownmin.Text = "01"
        '
        'cmdadjusttimeofrundown
        '
        Me.cmdadjusttimeofrundown.Location = New System.Drawing.Point(455, 38)
        Me.cmdadjusttimeofrundown.Name = "cmdadjusttimeofrundown"
        Me.cmdadjusttimeofrundown.Size = New System.Drawing.Size(71, 23)
        Me.cmdadjusttimeofrundown.TabIndex = 531
        Me.cmdadjusttimeofrundown.Text = "Adjust Time"
        Me.cmdadjusttimeofrundown.UseVisualStyleBackColor = True
        '
        'cmdstopsheduletemplate
        '
        Me.cmdstopsheduletemplate.Location = New System.Drawing.Point(363, 37)
        Me.cmdstopsheduletemplate.Name = "cmdstopsheduletemplate"
        Me.cmdstopsheduletemplate.Size = New System.Drawing.Size(89, 23)
        Me.cmdstopsheduletemplate.TabIndex = 530
        Me.cmdstopsheduletemplate.Text = "Stop Schedule"
        Me.cmdstopsheduletemplate.UseVisualStyleBackColor = True
        '
        'cmdstartsheduletemplate
        '
        Me.cmdstartsheduletemplate.Location = New System.Drawing.Point(144, 38)
        Me.cmdstartsheduletemplate.Name = "cmdstartsheduletemplate"
        Me.cmdstartsheduletemplate.Size = New System.Drawing.Size(61, 23)
        Me.cmdstartsheduletemplate.TabIndex = 529
        Me.cmdstartsheduletemplate.Text = "Schedule"
        Me.cmdstartsheduletemplate.UseVisualStyleBackColor = True
        '
        'cmbrundowninvoke
        '
        Me.cmbrundowninvoke.FormattingEnabled = True
        Me.cmbrundowninvoke.Items.AddRange(New Object() {"in", "out", "loop", "Stop", "20", "Next", "labelname", "framenumber", "methodname"})
        Me.cmbrundowninvoke.Location = New System.Drawing.Point(380, 11)
        Me.cmbrundowninvoke.Name = "cmbrundowninvoke"
        Me.cmbrundowninvoke.Size = New System.Drawing.Size(50, 21)
        Me.cmbrundowninvoke.TabIndex = 526
        Me.cmbrundowninvoke.Text = "out"
        '
        'cmdrundowninvoke
        '
        Me.cmdrundowninvoke.Location = New System.Drawing.Point(430, 11)
        Me.cmdrundowninvoke.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdrundowninvoke.Name = "cmdrundowninvoke"
        Me.cmdrundowninvoke.Size = New System.Drawing.Size(50, 23)
        Me.cmdrundowninvoke.TabIndex = 525
        Me.cmdrundowninvoke.Text = "Invoke"
        Me.cmdrundowninvoke.UseVisualStyleBackColor = True
        '
        'removetsrundown
        '
        Me.removetsrundown.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removetsrundown.Image = Global.caspar_media_playback.My.Resources.Resources.minus
        Me.removetsrundown.Location = New System.Drawing.Point(108, 40)
        Me.removetsrundown.Name = "removetsrundown"
        Me.removetsrundown.Size = New System.Drawing.Size(33, 22)
        Me.removetsrundown.TabIndex = 522
        Me.removetsrundown.UseVisualStyleBackColor = True
        '
        'nexttsrundown
        '
        Me.nexttsrundown.BackColor = System.Drawing.Color.Yellow
        Me.nexttsrundown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nexttsrundown.Location = New System.Drawing.Point(530, 11)
        Me.nexttsrundown.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nexttsrundown.Name = "nexttsrundown"
        Me.nexttsrundown.Size = New System.Drawing.Size(63, 23)
        Me.nexttsrundown.TabIndex = 518
        Me.nexttsrundown.Text = "Next Step"
        Me.nexttsrundown.UseVisualStyleBackColor = False
        '
        'uptsrundown
        '
        Me.uptsrundown.Image = CType(resources.GetObject("uptsrundown.Image"), System.Drawing.Image)
        Me.uptsrundown.Location = New System.Drawing.Point(-1, 40)
        Me.uptsrundown.Name = "uptsrundown"
        Me.uptsrundown.Size = New System.Drawing.Size(28, 23)
        Me.uptsrundown.TabIndex = 520
        Me.uptsrundown.UseVisualStyleBackColor = True
        '
        'downtsrundown
        '
        Me.downtsrundown.Image = CType(resources.GetObject("downtsrundown.Image"), System.Drawing.Image)
        Me.downtsrundown.Location = New System.Drawing.Point(28, 40)
        Me.downtsrundown.Name = "downtsrundown"
        Me.downtsrundown.Size = New System.Drawing.Size(36, 23)
        Me.downtsrundown.TabIndex = 521
        Me.downtsrundown.UseVisualStyleBackColor = True
        '
        'addtsrundown
        '
        Me.addtsrundown.Image = CType(resources.GetObject("addtsrundown.Image"), System.Drawing.Image)
        Me.addtsrundown.Location = New System.Drawing.Point(65, 40)
        Me.addtsrundown.Name = "addtsrundown"
        Me.addtsrundown.Size = New System.Drawing.Size(41, 23)
        Me.addtsrundown.TabIndex = 519
        Me.addtsrundown.UseVisualStyleBackColor = True
        '
        'playtsrundown
        '
        Me.playtsrundown.BackColor = System.Drawing.Color.Green
        Me.playtsrundown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playtsrundown.ForeColor = System.Drawing.Color.White
        Me.playtsrundown.Location = New System.Drawing.Point(483, 11)
        Me.playtsrundown.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.playtsrundown.Name = "playtsrundown"
        Me.playtsrundown.Size = New System.Drawing.Size(48, 23)
        Me.playtsrundown.TabIndex = 516
        Me.playtsrundown.Text = "Play"
        Me.playtsrundown.UseVisualStyleBackColor = False
        '
        'stoptsrundown
        '
        Me.stoptsrundown.BackColor = System.Drawing.Color.Red
        Me.stoptsrundown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stoptsrundown.ForeColor = System.Drawing.Color.White
        Me.stoptsrundown.Location = New System.Drawing.Point(592, 11)
        Me.stoptsrundown.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.stoptsrundown.Name = "stoptsrundown"
        Me.stoptsrundown.Size = New System.Drawing.Size(52, 23)
        Me.stoptsrundown.TabIndex = 517
        Me.stoptsrundown.Text = "Stop"
        Me.stoptsrundown.UseVisualStyleBackColor = False
        '
        'dgvrundown
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvrundown.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvrundown.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvrundown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvrundown.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Label, Me.DataGridViewTextBoxColumn5, Me.V, Me.T, Me.Data})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvrundown.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvrundown.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvrundown.Location = New System.Drawing.Point(4, 62)
        Me.dgvrundown.Name = "dgvrundown"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvrundown.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvrundown.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvrundown.Size = New System.Drawing.Size(680, 430)
        Me.dgvrundown.TabIndex = 370
        '
        'Label
        '
        Me.Label.HeaderText = "Label"
        Me.Label.Name = "Label"
        Me.Label.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Label.Width = 180
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Template"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'V
        '
        Me.V.HeaderText = "V"
        Me.V.Name = "V"
        Me.V.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.V.Width = 30
        '
        'T
        '
        Me.T.HeaderText = "T"
        Me.T.Name = "T"
        Me.T.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.T.Width = 30
        '
        'Data
        '
        Me.Data.HeaderText = "Data"
        Me.Data.Name = "Data"
        Me.Data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cmdaddtorundown
        '
        Me.cmdaddtorundown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdaddtorundown.Location = New System.Drawing.Point(711, 7)
        Me.cmdaddtorundown.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdaddtorundown.Name = "cmdaddtorundown"
        Me.cmdaddtorundown.Size = New System.Drawing.Size(150, 33)
        Me.cmdaddtorundown.TabIndex = 524
        Me.cmdaddtorundown.Text = "Add to Rundown"
        Me.cmdaddtorundown.UseVisualStyleBackColor = True
        '
        'dgvanytemplate
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvanytemplate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvanytemplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvanytemplate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InstanceName, Me.Value, Me.Column4})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvanytemplate.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvanytemplate.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvanytemplate.Location = New System.Drawing.Point(695, 82)
        Me.dgvanytemplate.Name = "dgvanytemplate"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvanytemplate.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvanytemplate.Size = New System.Drawing.Size(490, 788)
        Me.dgvanytemplate.TabIndex = 369
        '
        'InstanceName
        '
        Me.InstanceName.HeaderText = "Instance/Label Name"
        Me.InstanceName.Name = "InstanceName"
        Me.InstanceName.Width = 105
        '
        'Value
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Value.DefaultCellStyle = DataGridViewCellStyle6
        Me.Value.HeaderText = "Value"
        Me.Value.Name = "Value"
        Me.Value.Width = 290
        '
        'Column4
        '
        Me.Column4.HeaderText = ""
        Me.Column4.Name = "Column4"
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column4.Width = 30
        '
        'cmbvideolayerfortemplate
        '
        Me.cmbvideolayerfortemplate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbvideolayerfortemplate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbvideolayerfortemplate.FormattingEnabled = True
        Me.cmbvideolayerfortemplate.Items.AddRange(New Object() {"21", "22", "23", "24", "25"})
        Me.cmbvideolayerfortemplate.Location = New System.Drawing.Point(561, 13)
        Me.cmbvideolayerfortemplate.Name = "cmbvideolayerfortemplate"
        Me.cmbvideolayerfortemplate.Size = New System.Drawing.Size(40, 21)
        Me.cmbvideolayerfortemplate.TabIndex = 367
        Me.cmbvideolayerfortemplate.Text = "96"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(495, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 368
        Me.Label10.Text = "Video Layer"
        '
        'cmbinvoke
        '
        Me.cmbinvoke.FormattingEnabled = True
        Me.cmbinvoke.Items.AddRange(New Object() {"in", "out", "loop", "Stop", "20", "Next", "labelname", "framenumber", "methodname"})
        Me.cmbinvoke.Location = New System.Drawing.Point(255, 13)
        Me.cmbinvoke.Name = "cmbinvoke"
        Me.cmbinvoke.Size = New System.Drawing.Size(128, 21)
        Me.cmbinvoke.TabIndex = 366
        Me.cmbinvoke.Text = "out"
        '
        'cmdinvoke
        '
        Me.cmdinvoke.Location = New System.Drawing.Point(389, 13)
        Me.cmdinvoke.Name = "cmdinvoke"
        Me.cmdinvoke.Size = New System.Drawing.Size(104, 21)
        Me.cmdinvoke.TabIndex = 365
        Me.cmdinvoke.Text = "Invoke Method"
        Me.cmdinvoke.UseVisualStyleBackColor = True
        '
        'cmdupdatetemplate
        '
        Me.cmdupdatetemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdupdatetemplate.Location = New System.Drawing.Point(1051, 10)
        Me.cmdupdatetemplate.Name = "cmdupdatetemplate"
        Me.cmdupdatetemplate.Size = New System.Drawing.Size(57, 26)
        Me.cmdupdatetemplate.TabIndex = 358
        Me.cmdupdatetemplate.Text = "Update"
        Me.cmdupdatetemplate.UseVisualStyleBackColor = True
        '
        'cmblayertemplate
        '
        Me.cmblayertemplate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmblayertemplate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmblayertemplate.FormattingEnabled = True
        Me.cmblayertemplate.Items.AddRange(New Object() {"21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.cmblayertemplate.Location = New System.Drawing.Point(666, 11)
        Me.cmblayertemplate.Name = "cmblayertemplate"
        Me.cmblayertemplate.Size = New System.Drawing.Size(40, 21)
        Me.cmblayertemplate.TabIndex = 291
        Me.cmblayertemplate.Text = "96"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(603, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 13)
        Me.Label19.TabIndex = 325
        Me.Label19.Text = "Flash Layer"
        '
        'cmdnextframe
        '
        Me.cmdnextframe.BackColor = System.Drawing.Color.Yellow
        Me.cmdnextframe.Location = New System.Drawing.Point(923, 10)
        Me.cmdnextframe.Name = "cmdnextframe"
        Me.cmdnextframe.Size = New System.Drawing.Size(66, 27)
        Me.cmdnextframe.TabIndex = 309
        Me.cmdnextframe.Text = "Next Step"
        Me.cmdnextframe.UseVisualStyleBackColor = False
        '
        'txtsearchtemplate
        '
        Me.txtsearchtemplate.Location = New System.Drawing.Point(5, 13)
        Me.txtsearchtemplate.Name = "txtsearchtemplate"
        Me.txtsearchtemplate.Size = New System.Drawing.Size(174, 20)
        Me.txtsearchtemplate.TabIndex = 302
        '
        'lsttemplate
        '
        Me.lsttemplate.AllowDrop = True
        Me.lsttemplate.BackColor = System.Drawing.SystemColors.Control
        Me.lsttemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsttemplate.FormattingEnabled = True
        Me.lsttemplate.HorizontalScrollbar = True
        Me.lsttemplate.Location = New System.Drawing.Point(6, 35)
        Me.lsttemplate.Name = "lsttemplate"
        Me.lsttemplate.ScrollAlwaysVisible = True
        Me.lsttemplate.Size = New System.Drawing.Size(279, 342)
        Me.lsttemplate.TabIndex = 304
        '
        'cmdclipsearchtemplate
        '
        Me.cmdclipsearchtemplate.Location = New System.Drawing.Point(185, 13)
        Me.cmdclipsearchtemplate.Name = "cmdclipsearchtemplate"
        Me.cmdclipsearchtemplate.Size = New System.Drawing.Size(64, 22)
        Me.cmdclipsearchtemplate.TabIndex = 303
        Me.cmdclipsearchtemplate.Text = "Search"
        Me.cmdclipsearchtemplate.UseVisualStyleBackColor = True
        '
        'cmbfonttemplate
        '
        Me.cmbfonttemplate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbfonttemplate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbfonttemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfonttemplate.FormattingEnabled = True
        Me.cmbfonttemplate.Location = New System.Drawing.Point(1113, 10)
        Me.cmbfonttemplate.Name = "cmbfonttemplate"
        Me.cmbfonttemplate.Size = New System.Drawing.Size(67, 20)
        Me.cmbfonttemplate.TabIndex = 290
        Me.cmbfonttemplate.Text = Global.caspar_media_playback.My.MySettings.Default.cmbfonttemplate
        '
        'cmdanytemplatestop
        '
        Me.cmdanytemplatestop.BackColor = System.Drawing.Color.Red
        Me.cmdanytemplatestop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdanytemplatestop.ForeColor = System.Drawing.Color.White
        Me.cmdanytemplatestop.Location = New System.Drawing.Point(991, 10)
        Me.cmdanytemplatestop.Name = "cmdanytemplatestop"
        Me.cmdanytemplatestop.Size = New System.Drawing.Size(54, 26)
        Me.cmdanytemplatestop.TabIndex = 289
        Me.cmdanytemplatestop.Text = "Stop"
        Me.cmdanytemplatestop.UseVisualStyleBackColor = False
        '
        'cmdanytemplateplay
        '
        Me.cmdanytemplateplay.BackColor = System.Drawing.Color.Green
        Me.cmdanytemplateplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdanytemplateplay.ForeColor = System.Drawing.Color.White
        Me.cmdanytemplateplay.Location = New System.Drawing.Point(863, 10)
        Me.cmdanytemplateplay.Name = "cmdanytemplateplay"
        Me.cmdanytemplateplay.Size = New System.Drawing.Size(54, 29)
        Me.cmdanytemplateplay.TabIndex = 288
        Me.cmdanytemplateplay.Text = "Play"
        Me.cmdanytemplateplay.UseVisualStyleBackColor = False
        '
        'tmrsheduletemplatestart
        '
        Me.tmrsheduletemplatestart.Interval = 10000
        '
        'tmrshedultemplateend
        '
        Me.tmrshedultemplateend.Interval = 7000
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Label"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 180
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Template"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "V"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 30
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "T"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 30
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Instance/Label Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 85
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn7.HeaderText = "Value"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 290
        '
        'cmdOnlyUpdatePreview
        '
        Me.cmdOnlyUpdatePreview.Location = New System.Drawing.Point(1112, 59)
        Me.cmdOnlyUpdatePreview.Name = "cmdOnlyUpdatePreview"
        Me.cmdOnlyUpdatePreview.Size = New System.Drawing.Size(92, 23)
        Me.cmdOnlyUpdatePreview.TabIndex = 647
        Me.cmdOnlyUpdatePreview.Text = "Update Preview"
        Me.cmdOnlyUpdatePreview.UseVisualStyleBackColor = True
        '
        'ucTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1208, 921)
        Me.Controls.Add(Me.gbtemplate)
        Me.HideOnClose = True
        Me.KeyPreview = True
        Me.Name = "ucTemplate"
        Me.Text = "Flash Template"
        Me.gbtemplate.ResumeLayout(False)
        Me.gbtemplate.PerformLayout()
        CType(Me.picanytemplate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbrundown.ResumeLayout(False)
        Me.gbrundown.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvrundown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvanytemplate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbtemplate As System.Windows.Forms.GroupBox
    Friend WithEvents chkanimatetemplate As System.Windows.Forms.CheckBox
    Friend WithEvents gbrundown As System.Windows.Forms.GroupBox
    Friend WithEvents Label269 As System.Windows.Forms.Label
    Friend WithEvents Label268 As System.Windows.Forms.Label
    Friend WithEvents txtadjusttimeofrundownsec As System.Windows.Forms.TextBox
    Friend WithEvents txtadjusttimeofrundownmin As System.Windows.Forms.TextBox
    Friend WithEvents cmdadjusttimeofrundown As System.Windows.Forms.Button
    Friend WithEvents cmdstopsheduletemplate As System.Windows.Forms.Button
    Friend WithEvents cmdstartsheduletemplate As System.Windows.Forms.Button
    Friend WithEvents cmbrundowninvoke As System.Windows.Forms.ComboBox
    Friend WithEvents cmdrundowninvoke As System.Windows.Forms.Button
    Friend WithEvents removetsrundown As System.Windows.Forms.Button
    Friend WithEvents nexttsrundown As System.Windows.Forms.Button
    Friend WithEvents uptsrundown As System.Windows.Forms.Button
    Friend WithEvents downtsrundown As System.Windows.Forms.Button
    Friend WithEvents addtsrundown As System.Windows.Forms.Button
    Friend WithEvents playtsrundown As System.Windows.Forms.Button
    Friend WithEvents stoptsrundown As System.Windows.Forms.Button
    Friend WithEvents dgvrundown As System.Windows.Forms.DataGridView
    Friend WithEvents cmdaddtorundown As System.Windows.Forms.Button
    Friend WithEvents dgvanytemplate As System.Windows.Forms.DataGridView
    Friend WithEvents cmbvideolayerfortemplate As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbinvoke As System.Windows.Forms.ComboBox
    Friend WithEvents cmdinvoke As System.Windows.Forms.Button
    Friend WithEvents cmdupdatetemplate As System.Windows.Forms.Button
    Friend WithEvents cmblayertemplate As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmdnextframe As System.Windows.Forms.Button
    Friend WithEvents txtsearchtemplate As System.Windows.Forms.TextBox
    Friend WithEvents lsttemplate As System.Windows.Forms.ListBox
    Friend WithEvents cmdclipsearchtemplate As System.Windows.Forms.Button
    Friend WithEvents cmbfonttemplate As System.Windows.Forms.ComboBox
    Friend WithEvents cmdanytemplatestop As System.Windows.Forms.Button
    Friend WithEvents cmdanytemplateplay As System.Windows.Forms.Button
    Friend WithEvents tmrsheduletemplatestart As System.Windows.Forms.Timer
    Friend WithEvents tmrshedultemplateend As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lblsheduleStatus As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Label As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents V As DataGridViewTextBoxColumn
    Friend WithEvents T As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents InstanceName As DataGridViewTextBoxColumn
    Friend WithEvents Value As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewButtonColumn
    Friend WithEvents chkLBand As CheckBox
    Friend WithEvents txtLBand As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents picanytemplate As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents cmdUpdatePreview As Button
    Friend WithEvents cmdOnlyUpdatePreview As Button
End Class
