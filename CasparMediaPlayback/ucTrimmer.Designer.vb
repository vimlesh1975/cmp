<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTrimmer
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTrimmer))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbTrimmer = New System.Windows.Forms.GroupBox()
        Me.cmdFreezeDetect = New System.Windows.Forms.Button()
        Me.cmdBlackDetect = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbGraphics = New System.Windows.Forms.TabPage()
        Me.dgvgraphics2 = New System.Windows.Forms.DataGridView()
        Me.dgvgraphics = New System.Windows.Forms.DataGridView()
        Me.pngOpen = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cmbfont = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbFontSize = New System.Windows.Forms.ComboBox()
        Me.cmdFontColor = New System.Windows.Forms.Button()
        Me.cmdStripColor = New System.Windows.Forms.Button()
        Me.cmdExportGrapchics2 = New System.Windows.Forms.Button()
        Me.gotoOutGraphics2 = New System.Windows.Forms.Button()
        Me.GotoInGraphics2 = New System.Windows.Forms.Button()
        Me.markOutGraphics2 = New System.Windows.Forms.Button()
        Me.markInGraphics2 = New System.Windows.Forms.Button()
        Me.gotoOutGraphics = New System.Windows.Forms.Button()
        Me.GotoInGraphics = New System.Windows.Forms.Button()
        Me.cmdExportGrapchics = New System.Windows.Forms.Button()
        Me.markOutGraphics = New System.Windows.Forms.Button()
        Me.markInGraphics = New System.Windows.Forms.Button()
        Me.TrancodingProfiles = New System.Windows.Forms.TabPage()
        Me.cmdExportClipwithTranscodingProfile = New System.Windows.Forms.Button()
        Me.Segmentation = New System.Windows.Forms.TabPage()
        Me.gbsegmentation = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdexportsubclipsinTranscodingProfile = New System.Windows.Forms.Button()
        Me.cmdExportSegments = New System.Windows.Forms.Button()
        Me.cmddelete = New System.Windows.Forms.Button()
        Me.lblTDSegmentation = New System.Windows.Forms.Label()
        Me.cmdTDSegmentation = New System.Windows.Forms.Button()
        Me.cmdinsert = New System.Windows.Forms.Button()
        Me.lblsegmentlist = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdmarkOUTSegmentation = New System.Windows.Forms.Button()
        Me.cmdmarkINSegmentation = New System.Windows.Forms.Button()
        Me.cmdMakeSegments = New System.Windows.Forms.Button()
        Me.cmdGotoOUTSegments = New System.Windows.Forms.Button()
        Me.dgvsegmentation = New System.Windows.Forms.DataGridView()
        Me.cmdGotoINSegments = New System.Windows.Forms.Button()
        Me.Transcoder = New System.Windows.Forms.TabPage()
        Me.gbTranscoder = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdfontcolor1 = New System.Windows.Forms.Button()
        Me.cmdstripcolor1 = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkrtl = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.nstripopacity = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoLogoAndScroll = New System.Windows.Forms.RadioButton()
        Me.rdoOnlyScroll = New System.Windows.Forms.RadioButton()
        Me.rdoOnlyLogo = New System.Windows.Forms.RadioButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbvideocodec5 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.nlogoxposition = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.nYPositionScroll = New System.Windows.Forms.NumericUpDown()
        Me.nlogoyposition = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.nlogowidthforexport = New System.Windows.Forms.NumericUpDown()
        Me.Label255 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.nlogoheightforexport = New System.Windows.Forms.NumericUpDown()
        Me.Label254 = New System.Windows.Forms.Label()
        Me.nSpeedScroll = New System.Windows.Forms.NumericUpDown()
        Me.Label253 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label252 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label251 = New System.Windows.Forms.Label()
        Me.cmdlogoexport = New System.Windows.Forms.Button()
        Me.cmbScrollText = New System.Windows.Forms.ComboBox()
        Me.nopacity = New System.Windows.Forms.NumericUpDown()
        Me.cmbaudiocodec5 = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cmbbitrate5 = New System.Windows.Forms.ComboBox()
        Me.cmbfontscroll = New System.Windows.Forms.ComboBox()
        Me.vlcLogo = New Vlc.DotNet.Forms.VlcControl()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdOpenLogo = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbfontsizescroll = New System.Windows.Forms.ComboBox()
        Me.cmbvideocodec6 = New System.Windows.Forms.ComboBox()
        Me.cmbbitrate6 = New System.Windows.Forms.ComboBox()
        Me.lblexportclipinfo6 = New System.Windows.Forms.Label()
        Me.txtoptionstrimmer6 = New System.Windows.Forms.TextBox()
        Me.pbexportclip6 = New System.Windows.Forms.ProgressBar()
        Me.cmdclipcuttrimmer6 = New System.Windows.Forms.Button()
        Me.cmbaudiocodec6 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label250 = New System.Windows.Forms.Label()
        Me.lblexportclipinfo3 = New System.Windows.Forms.Label()
        Me.txtoptionsffmbc = New System.Windows.Forms.TextBox()
        Me.Label226 = New System.Windows.Forms.Label()
        Me.cmdffmbcexport = New System.Windows.Forms.Button()
        Me.Label224 = New System.Windows.Forms.Label()
        Me.cmbbitrate = New System.Windows.Forms.ComboBox()
        Me.txtoptionstrimmer = New System.Windows.Forms.TextBox()
        Me.chkaudiocodeccopy = New System.Windows.Forms.CheckBox()
        Me.chkvideocodeccopy = New System.Windows.Forms.CheckBox()
        Me.cmbbitrate4 = New System.Windows.Forms.ComboBox()
        Me.lblexportclipinfo4 = New System.Windows.Forms.Label()
        Me.txtoptionstrimmer4 = New System.Windows.Forms.TextBox()
        Me.cmbaudiocodec = New System.Windows.Forms.ComboBox()
        Me.cmdclipcuttrimmer = New System.Windows.Forms.Button()
        Me.pbexportclip4 = New System.Windows.Forms.ProgressBar()
        Me.cmdclipcuttrimmer4 = New System.Windows.Forms.Button()
        Me.cmbaudiocodec4 = New System.Windows.Forms.ComboBox()
        Me.Label248 = New System.Windows.Forms.Label()
        Me.Label245 = New System.Windows.Forms.Label()
        Me.txtoptionstrimmer3 = New System.Windows.Forms.TextBox()
        Me.cmbvideocodec3 = New System.Windows.Forms.ComboBox()
        Me.cmbvideocodec4 = New System.Windows.Forms.ComboBox()
        Me.cmbbitrate3 = New System.Windows.Forms.ComboBox()
        Me.pbexportclip3 = New System.Windows.Forms.ProgressBar()
        Me.cmbvideocodec = New System.Windows.Forms.ComboBox()
        Me.Label247 = New System.Windows.Forms.Label()
        Me.cmdclipcuttrimmer3 = New System.Windows.Forms.Button()
        Me.cmbaudiocodec3 = New System.Windows.Forms.ComboBox()
        Me.Label244 = New System.Windows.Forms.Label()
        Me.cmbbitrate2 = New System.Windows.Forms.ComboBox()
        Me.cmbvideocodec1 = New System.Windows.Forms.ComboBox()
        Me.lblexportclipinfo2 = New System.Windows.Forms.Label()
        Me.txtoptionstrimmer2 = New System.Windows.Forms.TextBox()
        Me.pbexportclip2 = New System.Windows.Forms.ProgressBar()
        Me.cmdclipcuttrimmer2 = New System.Windows.Forms.Button()
        Me.cmbaudiocodec2 = New System.Windows.Forms.ComboBox()
        Me.cmbvideocodec2 = New System.Windows.Forms.ComboBox()
        Me.Label243 = New System.Windows.Forms.Label()
        Me.Label242 = New System.Windows.Forms.Label()
        Me.cmbbitrate1 = New System.Windows.Forms.ComboBox()
        Me.Label241 = New System.Windows.Forms.Label()
        Me.Label240 = New System.Windows.Forms.Label()
        Me.lblexportclipinfo1 = New System.Windows.Forms.Label()
        Me.txtoptionstrimmer1 = New System.Windows.Forms.TextBox()
        Me.pbexportclip1 = New System.Windows.Forms.ProgressBar()
        Me.cmdclipcuttrimmer1 = New System.Windows.Forms.Button()
        Me.cmbaudiocodec1 = New System.Windows.Forms.ComboBox()
        Me.ClipJoinder = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgvjoiner = New System.Windows.Forms.DataGridView()
        Me.Openfile = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label227 = New System.Windows.Forms.Label()
        Me.Label228 = New System.Windows.Forms.Label()
        Me.chkaudiocodeccopyjoin = New System.Windows.Forms.CheckBox()
        Me.txtoptionstrimmerjoin = New System.Windows.Forms.TextBox()
        Me.chkvideocodeccopyjoin = New System.Windows.Forms.CheckBox()
        Me.Label229 = New System.Windows.Forms.Label()
        Me.cmdclipjoin = New System.Windows.Forms.Button()
        Me.cmbaudiocodecjoin = New System.Windows.Forms.ComboBox()
        Me.cmbvideocodecjoin = New System.Windows.Forms.ComboBox()
        Me.cmdCueFromCurrentPosition = New System.Windows.Forms.Button()
        Me.cmdPlayFromCurrentPosition = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FileOpen = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.bwforexportclip1 = New System.ComponentModel.BackgroundWorker()
        Me.bwforexportclip2 = New System.ComponentModel.BackgroundWorker()
        Me.bwforexportclip4 = New System.ComponentModel.BackgroundWorker()
        Me.bwforexportclip3 = New System.ComponentModel.BackgroundWorker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.bwforexportclip6 = New System.ComponentModel.BackgroundWorker()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UcnewTrimmer11 = New caspar_media_playback.ucnewTrimmer1()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UcTranscodingProfile1 = New caspar_media_playback.ucTranscodingProfile()
        Me.ClipName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INPoint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutPoint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.File = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbTrimmer.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbGraphics.SuspendLayout()
        CType(Me.dgvgraphics2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvgraphics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TrancodingProfiles.SuspendLayout()
        Me.Segmentation.SuspendLayout()
        Me.gbsegmentation.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvsegmentation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Transcoder.SuspendLayout()
        Me.gbTranscoder.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nstripopacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nlogoxposition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nYPositionScroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nlogoyposition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nlogowidthforexport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nlogoheightforexport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nSpeedScroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nopacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vlcLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClipJoinder.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvjoiner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbTrimmer
        '
        Me.gbTrimmer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbTrimmer.Controls.Add(Me.cmdFreezeDetect)
        Me.gbTrimmer.Controls.Add(Me.cmdBlackDetect)
        Me.gbTrimmer.Controls.Add(Me.UcnewTrimmer11)
        Me.gbTrimmer.Controls.Add(Me.TabControl1)
        Me.gbTrimmer.Controls.Add(Me.cmdCueFromCurrentPosition)
        Me.gbTrimmer.Controls.Add(Me.cmdPlayFromCurrentPosition)
        Me.gbTrimmer.Controls.Add(Me.Label2)
        Me.gbTrimmer.Location = New System.Drawing.Point(3, 4)
        Me.gbTrimmer.Name = "gbTrimmer"
        Me.gbTrimmer.Size = New System.Drawing.Size(1220, 912)
        Me.gbTrimmer.TabIndex = 1166
        Me.gbTrimmer.TabStop = False
        '
        'cmdFreezeDetect
        '
        Me.cmdFreezeDetect.Location = New System.Drawing.Point(102, 583)
        Me.cmdFreezeDetect.Name = "cmdFreezeDetect"
        Me.cmdFreezeDetect.Size = New System.Drawing.Size(86, 23)
        Me.cmdFreezeDetect.TabIndex = 802
        Me.cmdFreezeDetect.Text = "Freeze Detect"
        Me.cmdFreezeDetect.UseVisualStyleBackColor = True
        '
        'cmdBlackDetect
        '
        Me.cmdBlackDetect.Location = New System.Drawing.Point(10, 583)
        Me.cmdBlackDetect.Name = "cmdBlackDetect"
        Me.cmdBlackDetect.Size = New System.Drawing.Size(86, 23)
        Me.cmdBlackDetect.TabIndex = 801
        Me.cmdBlackDetect.Text = "Black Detect"
        Me.cmdBlackDetect.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbGraphics)
        Me.TabControl1.Controls.Add(Me.TrancodingProfiles)
        Me.TabControl1.Controls.Add(Me.Segmentation)
        Me.TabControl1.Controls.Add(Me.Transcoder)
        Me.TabControl1.Controls.Add(Me.ClipJoinder)
        Me.TabControl1.Location = New System.Drawing.Point(496, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(714, 898)
        Me.TabControl1.TabIndex = 798
        '
        'tbGraphics
        '
        Me.tbGraphics.Controls.Add(Me.dgvgraphics2)
        Me.tbGraphics.Controls.Add(Me.dgvgraphics)
        Me.tbGraphics.Controls.Add(Me.cmbfont)
        Me.tbGraphics.Controls.Add(Me.Label7)
        Me.tbGraphics.Controls.Add(Me.Label6)
        Me.tbGraphics.Controls.Add(Me.Label5)
        Me.tbGraphics.Controls.Add(Me.Label4)
        Me.tbGraphics.Controls.Add(Me.cmbFontSize)
        Me.tbGraphics.Controls.Add(Me.cmdFontColor)
        Me.tbGraphics.Controls.Add(Me.cmdStripColor)
        Me.tbGraphics.Controls.Add(Me.cmdExportGrapchics2)
        Me.tbGraphics.Controls.Add(Me.gotoOutGraphics2)
        Me.tbGraphics.Controls.Add(Me.GotoInGraphics2)
        Me.tbGraphics.Controls.Add(Me.markOutGraphics2)
        Me.tbGraphics.Controls.Add(Me.markInGraphics2)
        Me.tbGraphics.Controls.Add(Me.gotoOutGraphics)
        Me.tbGraphics.Controls.Add(Me.GotoInGraphics)
        Me.tbGraphics.Controls.Add(Me.cmdExportGrapchics)
        Me.tbGraphics.Controls.Add(Me.markOutGraphics)
        Me.tbGraphics.Controls.Add(Me.markInGraphics)
        Me.tbGraphics.Location = New System.Drawing.Point(4, 22)
        Me.tbGraphics.Name = "tbGraphics"
        Me.tbGraphics.Size = New System.Drawing.Size(706, 872)
        Me.tbGraphics.TabIndex = 4
        Me.tbGraphics.Text = "Graphics"
        Me.tbGraphics.UseVisualStyleBackColor = True
        '
        'dgvgraphics2
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvgraphics2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvgraphics2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvgraphics2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvgraphics2.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvgraphics2.Location = New System.Drawing.Point(8, 487)
        Me.dgvgraphics2.Name = "dgvgraphics2"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvgraphics2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvgraphics2.Size = New System.Drawing.Size(551, 231)
        Me.dgvgraphics2.TabIndex = 1227
        '
        'dgvgraphics
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvgraphics.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvgraphics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvgraphics.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.pngOpen, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvgraphics.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvgraphics.Location = New System.Drawing.Point(7, 137)
        Me.dgvgraphics.Name = "dgvgraphics"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvgraphics.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvgraphics.Size = New System.Drawing.Size(551, 216)
        Me.dgvgraphics.TabIndex = 1226
        '
        'pngOpen
        '
        Me.pngOpen.HeaderText = "Open  File"
        Me.pngOpen.Name = "pngOpen"
        Me.pngOpen.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pngOpen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.pngOpen.Width = 50
        '
        'cmbfont
        '
        Me.cmbfont.FormattingEnabled = True
        Me.cmbfont.Location = New System.Drawing.Point(378, 743)
        Me.cmbfont.Name = "cmbfont"
        Me.cmbfont.Size = New System.Drawing.Size(180, 21)
        Me.cmbfont.TabIndex = 1225
        Me.cmbfont.Text = "arialuni.ttf"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(350, 746)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 1224
        Me.Label7.Text = "Font"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(396, 39)
        Me.Label6.TabIndex = 1223
        Me.Label6.Text = "Simple super with PNG"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(57, 380)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(447, 39)
        Me.Label5.TabIndex = 1222
        Me.Label5.Text = "Simple super without PNG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(244, 749)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 1221
        Me.Label4.Text = "Font Size"
        '
        'cmbFontSize
        '
        Me.cmbFontSize.FormattingEnabled = True
        Me.cmbFontSize.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60", "70", "80"})
        Me.cmbFontSize.Location = New System.Drawing.Point(301, 746)
        Me.cmbFontSize.Name = "cmbFontSize"
        Me.cmbFontSize.Size = New System.Drawing.Size(43, 21)
        Me.cmbFontSize.TabIndex = 1220
        Me.cmbFontSize.Text = "40"
        '
        'cmdFontColor
        '
        Me.cmdFontColor.BackColor = System.Drawing.Color.Red
        Me.cmdFontColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFontColor.ForeColor = System.Drawing.Color.Yellow
        Me.cmdFontColor.Location = New System.Drawing.Point(8, 741)
        Me.cmdFontColor.Name = "cmdFontColor"
        Me.cmdFontColor.Size = New System.Drawing.Size(112, 34)
        Me.cmdFontColor.TabIndex = 1219
        Me.cmdFontColor.Text = "Font Color"
        Me.cmdFontColor.UseVisualStyleBackColor = False
        '
        'cmdStripColor
        '
        Me.cmdStripColor.BackColor = System.Drawing.Color.Red
        Me.cmdStripColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStripColor.ForeColor = System.Drawing.Color.Yellow
        Me.cmdStripColor.Location = New System.Drawing.Point(126, 741)
        Me.cmdStripColor.Name = "cmdStripColor"
        Me.cmdStripColor.Size = New System.Drawing.Size(114, 34)
        Me.cmdStripColor.TabIndex = 1218
        Me.cmdStripColor.Text = " Strip Color"
        Me.cmdStripColor.UseVisualStyleBackColor = False
        '
        'cmdExportGrapchics2
        '
        Me.cmdExportGrapchics2.Location = New System.Drawing.Point(573, 553)
        Me.cmdExportGrapchics2.Name = "cmdExportGrapchics2"
        Me.cmdExportGrapchics2.Size = New System.Drawing.Size(75, 52)
        Me.cmdExportGrapchics2.TabIndex = 1217
        Me.cmdExportGrapchics2.Text = "Export clip with Graphics"
        Me.cmdExportGrapchics2.UseVisualStyleBackColor = True
        '
        'gotoOutGraphics2
        '
        Me.gotoOutGraphics2.Location = New System.Drawing.Point(430, 463)
        Me.gotoOutGraphics2.Name = "gotoOutGraphics2"
        Me.gotoOutGraphics2.Size = New System.Drawing.Size(74, 23)
        Me.gotoOutGraphics2.TabIndex = 1214
        Me.gotoOutGraphics2.Text = "GOTO OUT"
        Me.gotoOutGraphics2.UseVisualStyleBackColor = True
        '
        'GotoInGraphics2
        '
        Me.GotoInGraphics2.Location = New System.Drawing.Point(348, 463)
        Me.GotoInGraphics2.Name = "GotoInGraphics2"
        Me.GotoInGraphics2.Size = New System.Drawing.Size(60, 23)
        Me.GotoInGraphics2.TabIndex = 1213
        Me.GotoInGraphics2.Text = "GOTO IN"
        Me.GotoInGraphics2.UseVisualStyleBackColor = True
        '
        'markOutGraphics2
        '
        Me.markOutGraphics2.Location = New System.Drawing.Point(429, 434)
        Me.markOutGraphics2.Name = "markOutGraphics2"
        Me.markOutGraphics2.Size = New System.Drawing.Size(75, 23)
        Me.markOutGraphics2.TabIndex = 1216
        Me.markOutGraphics2.Text = "Markl Out"
        Me.markOutGraphics2.UseVisualStyleBackColor = True
        '
        'markInGraphics2
        '
        Me.markInGraphics2.Location = New System.Drawing.Point(348, 434)
        Me.markInGraphics2.Name = "markInGraphics2"
        Me.markInGraphics2.Size = New System.Drawing.Size(75, 23)
        Me.markInGraphics2.TabIndex = 1215
        Me.markInGraphics2.Text = "Mark IN"
        Me.markInGraphics2.UseVisualStyleBackColor = True
        '
        'gotoOutGraphics
        '
        Me.gotoOutGraphics.Location = New System.Drawing.Point(484, 108)
        Me.gotoOutGraphics.Name = "gotoOutGraphics"
        Me.gotoOutGraphics.Size = New System.Drawing.Size(74, 23)
        Me.gotoOutGraphics.TabIndex = 1204
        Me.gotoOutGraphics.Text = "GOTO OUT"
        Me.gotoOutGraphics.UseVisualStyleBackColor = True
        '
        'GotoInGraphics
        '
        Me.GotoInGraphics.Location = New System.Drawing.Point(401, 108)
        Me.GotoInGraphics.Name = "GotoInGraphics"
        Me.GotoInGraphics.Size = New System.Drawing.Size(60, 23)
        Me.GotoInGraphics.TabIndex = 1203
        Me.GotoInGraphics.Text = "GOTO IN"
        Me.GotoInGraphics.UseVisualStyleBackColor = True
        '
        'cmdExportGrapchics
        '
        Me.cmdExportGrapchics.Location = New System.Drawing.Point(564, 190)
        Me.cmdExportGrapchics.Name = "cmdExportGrapchics"
        Me.cmdExportGrapchics.Size = New System.Drawing.Size(84, 52)
        Me.cmdExportGrapchics.TabIndex = 1208
        Me.cmdExportGrapchics.Text = "Export clip with Graphics"
        Me.cmdExportGrapchics.UseVisualStyleBackColor = True
        '
        'markOutGraphics
        '
        Me.markOutGraphics.Location = New System.Drawing.Point(484, 79)
        Me.markOutGraphics.Name = "markOutGraphics"
        Me.markOutGraphics.Size = New System.Drawing.Size(75, 23)
        Me.markOutGraphics.TabIndex = 1207
        Me.markOutGraphics.Text = "Markl Out"
        Me.markOutGraphics.UseVisualStyleBackColor = True
        '
        'markInGraphics
        '
        Me.markInGraphics.Location = New System.Drawing.Point(401, 79)
        Me.markInGraphics.Name = "markInGraphics"
        Me.markInGraphics.Size = New System.Drawing.Size(75, 23)
        Me.markInGraphics.TabIndex = 1206
        Me.markInGraphics.Text = "Mark IN"
        Me.markInGraphics.UseVisualStyleBackColor = True
        '
        'TrancodingProfiles
        '
        Me.TrancodingProfiles.Controls.Add(Me.cmdExportClipwithTranscodingProfile)
        Me.TrancodingProfiles.Controls.Add(Me.UcTranscodingProfile1)
        Me.TrancodingProfiles.Location = New System.Drawing.Point(4, 22)
        Me.TrancodingProfiles.Name = "TrancodingProfiles"
        Me.TrancodingProfiles.Padding = New System.Windows.Forms.Padding(3)
        Me.TrancodingProfiles.Size = New System.Drawing.Size(706, 872)
        Me.TrancodingProfiles.TabIndex = 3
        Me.TrancodingProfiles.Text = "Trancoding Profiles"
        Me.TrancodingProfiles.UseVisualStyleBackColor = True
        '
        'cmdExportClipwithTranscodingProfile
        '
        Me.cmdExportClipwithTranscodingProfile.Location = New System.Drawing.Point(11, 777)
        Me.cmdExportClipwithTranscodingProfile.Name = "cmdExportClipwithTranscodingProfile"
        Me.cmdExportClipwithTranscodingProfile.Size = New System.Drawing.Size(198, 23)
        Me.cmdExportClipwithTranscodingProfile.TabIndex = 737
        Me.cmdExportClipwithTranscodingProfile.Text = "Export Clip with Transcoding Profile"
        Me.cmdExportClipwithTranscodingProfile.UseVisualStyleBackColor = True
        '
        'Segmentation
        '
        Me.Segmentation.Controls.Add(Me.gbsegmentation)
        Me.Segmentation.Location = New System.Drawing.Point(4, 22)
        Me.Segmentation.Name = "Segmentation"
        Me.Segmentation.Padding = New System.Windows.Forms.Padding(3)
        Me.Segmentation.Size = New System.Drawing.Size(706, 872)
        Me.Segmentation.TabIndex = 1
        Me.Segmentation.Text = "Segmentation"
        Me.Segmentation.UseVisualStyleBackColor = True
        '
        'gbsegmentation
        '
        Me.gbsegmentation.BackColor = System.Drawing.Color.MistyRose
        Me.gbsegmentation.Controls.Add(Me.MenuStrip1)
        Me.gbsegmentation.Controls.Add(Me.cmdexportsubclipsinTranscodingProfile)
        Me.gbsegmentation.Controls.Add(Me.cmdExportSegments)
        Me.gbsegmentation.Controls.Add(Me.cmddelete)
        Me.gbsegmentation.Controls.Add(Me.lblTDSegmentation)
        Me.gbsegmentation.Controls.Add(Me.cmdTDSegmentation)
        Me.gbsegmentation.Controls.Add(Me.cmdinsert)
        Me.gbsegmentation.Controls.Add(Me.lblsegmentlist)
        Me.gbsegmentation.Controls.Add(Me.Label1)
        Me.gbsegmentation.Controls.Add(Me.cmdmarkOUTSegmentation)
        Me.gbsegmentation.Controls.Add(Me.cmdmarkINSegmentation)
        Me.gbsegmentation.Controls.Add(Me.cmdMakeSegments)
        Me.gbsegmentation.Controls.Add(Me.cmdGotoOUTSegments)
        Me.gbsegmentation.Controls.Add(Me.dgvsegmentation)
        Me.gbsegmentation.Controls.Add(Me.cmdGotoINSegments)
        Me.gbsegmentation.Location = New System.Drawing.Point(10, 8)
        Me.gbsegmentation.Name = "gbsegmentation"
        Me.gbsegmentation.Size = New System.Drawing.Size(683, 613)
        Me.gbsegmentation.TabIndex = 795
        Me.gbsegmentation.TabStop = False
        Me.gbsegmentation.Text = "Segmentation"
        Me.ToolTip1.SetToolTip(Me.gbsegmentation, "Delete row")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 66)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(45, 24)
        Me.MenuStrip1.TabIndex = 801
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem})
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
        'cmdexportsubclipsinTranscodingProfile
        '
        Me.cmdexportsubclipsinTranscodingProfile.Location = New System.Drawing.Point(9, 561)
        Me.cmdexportsubclipsinTranscodingProfile.Name = "cmdexportsubclipsinTranscodingProfile"
        Me.cmdexportsubclipsinTranscodingProfile.Size = New System.Drawing.Size(242, 46)
        Me.cmdexportsubclipsinTranscodingProfile.TabIndex = 800
        Me.cmdexportsubclipsinTranscodingProfile.Text = "Export Sub Clips with Transcoding Profile Selected in Transcoding Profile Tab"
        Me.ToolTip1.SetToolTip(Me.cmdexportsubclipsinTranscodingProfile, "Makes Actual Clips")
        Me.cmdexportsubclipsinTranscodingProfile.UseVisualStyleBackColor = True
        '
        'cmdExportSegments
        '
        Me.cmdExportSegments.Location = New System.Drawing.Point(618, 105)
        Me.cmdExportSegments.Name = "cmdExportSegments"
        Me.cmdExportSegments.Size = New System.Drawing.Size(45, 450)
        Me.cmdExportSegments.TabIndex = 799
        Me.cmdExportSegments.Text = "Export Sub Clips"
        Me.ToolTip1.SetToolTip(Me.cmdExportSegments, "Makes Actual Clips")
        Me.cmdExportSegments.UseVisualStyleBackColor = True
        '
        'cmddelete
        '
        Me.cmddelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.Image = Global.caspar_media_playback.My.Resources.Resources.minus
        Me.cmddelete.Location = New System.Drawing.Point(206, 77)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(25, 22)
        Me.cmddelete.TabIndex = 798
        Me.ToolTip1.SetToolTip(Me.cmddelete, "Delete row")
        Me.cmddelete.UseVisualStyleBackColor = True
        '
        'lblTDSegmentation
        '
        Me.lblTDSegmentation.AutoSize = True
        Me.lblTDSegmentation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTDSegmentation.ForeColor = System.Drawing.Color.Maroon
        Me.lblTDSegmentation.Location = New System.Drawing.Point(543, 81)
        Me.lblTDSegmentation.Name = "lblTDSegmentation"
        Me.lblTDSegmentation.Size = New System.Drawing.Size(106, 16)
        Me.lblTDSegmentation.TabIndex = 797
        Me.lblTDSegmentation.Text = "Total Duration"
        '
        'cmdTDSegmentation
        '
        Me.cmdTDSegmentation.Location = New System.Drawing.Point(460, 78)
        Me.cmdTDSegmentation.Name = "cmdTDSegmentation"
        Me.cmdTDSegmentation.Size = New System.Drawing.Size(82, 23)
        Me.cmdTDSegmentation.TabIndex = 740
        Me.cmdTDSegmentation.Text = "Total Duration"
        Me.cmdTDSegmentation.UseVisualStyleBackColor = True
        '
        'cmdinsert
        '
        Me.cmdinsert.Image = CType(resources.GetObject("cmdinsert.Image"), System.Drawing.Image)
        Me.cmdinsert.Location = New System.Drawing.Point(179, 75)
        Me.cmdinsert.Name = "cmdinsert"
        Me.cmdinsert.Size = New System.Drawing.Size(23, 23)
        Me.cmdinsert.TabIndex = 739
        Me.ToolTip1.SetToolTip(Me.cmdinsert, "Add row")
        Me.cmdinsert.UseVisualStyleBackColor = True
        '
        'lblsegmentlist
        '
        Me.lblsegmentlist.AutoSize = True
        Me.lblsegmentlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsegmentlist.Location = New System.Drawing.Point(72, 28)
        Me.lblsegmentlist.Name = "lblsegmentlist"
        Me.lblsegmentlist.Size = New System.Drawing.Size(0, 13)
        Me.lblsegmentlist.TabIndex = 738
        Me.lblsegmentlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 737
        Me.Label1.Text = "Segmentlist="
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdmarkOUTSegmentation
        '
        Me.cmdmarkOUTSegmentation.Location = New System.Drawing.Point(377, 78)
        Me.cmdmarkOUTSegmentation.Name = "cmdmarkOUTSegmentation"
        Me.cmdmarkOUTSegmentation.Size = New System.Drawing.Size(82, 23)
        Me.cmdmarkOUTSegmentation.TabIndex = 5
        Me.cmdmarkOUTSegmentation.Text = "Mark OUT"
        Me.cmdmarkOUTSegmentation.UseVisualStyleBackColor = True
        '
        'cmdmarkINSegmentation
        '
        Me.cmdmarkINSegmentation.Location = New System.Drawing.Point(293, 78)
        Me.cmdmarkINSegmentation.Name = "cmdmarkINSegmentation"
        Me.cmdmarkINSegmentation.Size = New System.Drawing.Size(82, 23)
        Me.cmdmarkINSegmentation.TabIndex = 4
        Me.cmdmarkINSegmentation.Text = "Mark IN"
        Me.cmdmarkINSegmentation.UseVisualStyleBackColor = True
        '
        'cmdMakeSegments
        '
        Me.cmdMakeSegments.Location = New System.Drawing.Point(574, 105)
        Me.cmdMakeSegments.Name = "cmdMakeSegments"
        Me.cmdMakeSegments.Size = New System.Drawing.Size(41, 450)
        Me.cmdMakeSegments.TabIndex = 3
        Me.cmdMakeSegments.Text = "Save Sub Clips"
        Me.ToolTip1.SetToolTip(Me.cmdMakeSegments, "Makes text files")
        Me.cmdMakeSegments.UseVisualStyleBackColor = True
        '
        'cmdGotoOUTSegments
        '
        Me.cmdGotoOUTSegments.Location = New System.Drawing.Point(390, 573)
        Me.cmdGotoOUTSegments.Name = "cmdGotoOUTSegments"
        Me.cmdGotoOUTSegments.Size = New System.Drawing.Size(75, 23)
        Me.cmdGotoOUTSegments.TabIndex = 2
        Me.cmdGotoOUTSegments.Text = "GoTo OUT"
        Me.cmdGotoOUTSegments.UseVisualStyleBackColor = True
        '
        'dgvsegmentation
        '
        Me.dgvsegmentation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsegmentation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClipName, Me.INPoint, Me.OutPoint, Me.Duration})
        Me.dgvsegmentation.Location = New System.Drawing.Point(6, 105)
        Me.dgvsegmentation.Name = "dgvsegmentation"
        Me.dgvsegmentation.Size = New System.Drawing.Size(561, 450)
        Me.dgvsegmentation.TabIndex = 0
        '
        'cmdGotoINSegments
        '
        Me.cmdGotoINSegments.Location = New System.Drawing.Point(309, 573)
        Me.cmdGotoINSegments.Name = "cmdGotoINSegments"
        Me.cmdGotoINSegments.Size = New System.Drawing.Size(75, 23)
        Me.cmdGotoINSegments.TabIndex = 0
        Me.cmdGotoINSegments.Text = "GoTo IN"
        Me.cmdGotoINSegments.UseVisualStyleBackColor = True
        '
        'Transcoder
        '
        Me.Transcoder.Controls.Add(Me.gbTranscoder)
        Me.Transcoder.Location = New System.Drawing.Point(4, 22)
        Me.Transcoder.Name = "Transcoder"
        Me.Transcoder.Padding = New System.Windows.Forms.Padding(3)
        Me.Transcoder.Size = New System.Drawing.Size(706, 872)
        Me.Transcoder.TabIndex = 0
        Me.Transcoder.Text = "Transcoder"
        Me.Transcoder.UseVisualStyleBackColor = True
        '
        'gbTranscoder
        '
        Me.gbTranscoder.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbTranscoder.Controls.Add(Me.GroupBox1)
        Me.gbTranscoder.Controls.Add(Me.cmbvideocodec6)
        Me.gbTranscoder.Controls.Add(Me.cmbbitrate6)
        Me.gbTranscoder.Controls.Add(Me.lblexportclipinfo6)
        Me.gbTranscoder.Controls.Add(Me.txtoptionstrimmer6)
        Me.gbTranscoder.Controls.Add(Me.pbexportclip6)
        Me.gbTranscoder.Controls.Add(Me.cmdclipcuttrimmer6)
        Me.gbTranscoder.Controls.Add(Me.cmbaudiocodec6)
        Me.gbTranscoder.Controls.Add(Me.Label3)
        Me.gbTranscoder.Controls.Add(Me.Label250)
        Me.gbTranscoder.Controls.Add(Me.lblexportclipinfo3)
        Me.gbTranscoder.Controls.Add(Me.txtoptionsffmbc)
        Me.gbTranscoder.Controls.Add(Me.Label226)
        Me.gbTranscoder.Controls.Add(Me.cmdffmbcexport)
        Me.gbTranscoder.Controls.Add(Me.Label224)
        Me.gbTranscoder.Controls.Add(Me.cmbbitrate)
        Me.gbTranscoder.Controls.Add(Me.txtoptionstrimmer)
        Me.gbTranscoder.Controls.Add(Me.chkaudiocodeccopy)
        Me.gbTranscoder.Controls.Add(Me.chkvideocodeccopy)
        Me.gbTranscoder.Controls.Add(Me.cmbbitrate4)
        Me.gbTranscoder.Controls.Add(Me.lblexportclipinfo4)
        Me.gbTranscoder.Controls.Add(Me.txtoptionstrimmer4)
        Me.gbTranscoder.Controls.Add(Me.cmbaudiocodec)
        Me.gbTranscoder.Controls.Add(Me.cmdclipcuttrimmer)
        Me.gbTranscoder.Controls.Add(Me.pbexportclip4)
        Me.gbTranscoder.Controls.Add(Me.cmdclipcuttrimmer4)
        Me.gbTranscoder.Controls.Add(Me.cmbaudiocodec4)
        Me.gbTranscoder.Controls.Add(Me.Label248)
        Me.gbTranscoder.Controls.Add(Me.Label245)
        Me.gbTranscoder.Controls.Add(Me.txtoptionstrimmer3)
        Me.gbTranscoder.Controls.Add(Me.cmbvideocodec3)
        Me.gbTranscoder.Controls.Add(Me.cmbvideocodec4)
        Me.gbTranscoder.Controls.Add(Me.cmbbitrate3)
        Me.gbTranscoder.Controls.Add(Me.pbexportclip3)
        Me.gbTranscoder.Controls.Add(Me.cmbvideocodec)
        Me.gbTranscoder.Controls.Add(Me.Label247)
        Me.gbTranscoder.Controls.Add(Me.cmdclipcuttrimmer3)
        Me.gbTranscoder.Controls.Add(Me.cmbaudiocodec3)
        Me.gbTranscoder.Controls.Add(Me.Label244)
        Me.gbTranscoder.Controls.Add(Me.cmbbitrate2)
        Me.gbTranscoder.Controls.Add(Me.cmbvideocodec1)
        Me.gbTranscoder.Controls.Add(Me.lblexportclipinfo2)
        Me.gbTranscoder.Controls.Add(Me.txtoptionstrimmer2)
        Me.gbTranscoder.Controls.Add(Me.pbexportclip2)
        Me.gbTranscoder.Controls.Add(Me.cmdclipcuttrimmer2)
        Me.gbTranscoder.Controls.Add(Me.cmbaudiocodec2)
        Me.gbTranscoder.Controls.Add(Me.cmbvideocodec2)
        Me.gbTranscoder.Controls.Add(Me.Label243)
        Me.gbTranscoder.Controls.Add(Me.Label242)
        Me.gbTranscoder.Controls.Add(Me.cmbbitrate1)
        Me.gbTranscoder.Controls.Add(Me.Label241)
        Me.gbTranscoder.Controls.Add(Me.Label240)
        Me.gbTranscoder.Controls.Add(Me.lblexportclipinfo1)
        Me.gbTranscoder.Controls.Add(Me.txtoptionstrimmer1)
        Me.gbTranscoder.Controls.Add(Me.pbexportclip1)
        Me.gbTranscoder.Controls.Add(Me.cmdclipcuttrimmer1)
        Me.gbTranscoder.Controls.Add(Me.cmbaudiocodec1)
        Me.gbTranscoder.Location = New System.Drawing.Point(6, 7)
        Me.gbTranscoder.Name = "gbTranscoder"
        Me.gbTranscoder.Size = New System.Drawing.Size(694, 862)
        Me.gbTranscoder.TabIndex = 797
        Me.gbTranscoder.TabStop = False
        Me.gbTranscoder.Text = "Transcoder"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmdfontcolor1)
        Me.GroupBox1.Controls.Add(Me.cmdstripcolor1)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.chkrtl)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.nstripopacity)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.cmbvideocodec5)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.nlogoxposition)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.nYPositionScroll)
        Me.GroupBox1.Controls.Add(Me.nlogoyposition)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.nlogowidthforexport)
        Me.GroupBox1.Controls.Add(Me.Label255)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.nlogoheightforexport)
        Me.GroupBox1.Controls.Add(Me.Label254)
        Me.GroupBox1.Controls.Add(Me.nSpeedScroll)
        Me.GroupBox1.Controls.Add(Me.Label253)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label252)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label251)
        Me.GroupBox1.Controls.Add(Me.cmdlogoexport)
        Me.GroupBox1.Controls.Add(Me.cmbScrollText)
        Me.GroupBox1.Controls.Add(Me.nopacity)
        Me.GroupBox1.Controls.Add(Me.cmbaudiocodec5)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.cmbbitrate5)
        Me.GroupBox1.Controls.Add(Me.cmbfontscroll)
        Me.GroupBox1.Controls.Add(Me.vlcLogo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmdOpenLogo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbfontsizescroll)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 556)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 300)
        Me.GroupBox1.TabIndex = 1250
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transcode with logo and Scroll"
        '
        'cmdfontcolor1
        '
        Me.cmdfontcolor1.BackColor = System.Drawing.Color.Red
        Me.cmdfontcolor1.ForeColor = System.Drawing.Color.Yellow
        Me.cmdfontcolor1.Location = New System.Drawing.Point(339, 197)
        Me.cmdfontcolor1.Name = "cmdfontcolor1"
        Me.cmdfontcolor1.Size = New System.Drawing.Size(75, 23)
        Me.cmdfontcolor1.TabIndex = 1264
        Me.cmdfontcolor1.Text = "Font Color"
        Me.cmdfontcolor1.UseVisualStyleBackColor = False
        '
        'cmdstripcolor1
        '
        Me.cmdstripcolor1.BackColor = System.Drawing.Color.Red
        Me.cmdstripcolor1.ForeColor = System.Drawing.Color.Yellow
        Me.cmdstripcolor1.Location = New System.Drawing.Point(339, 167)
        Me.cmdstripcolor1.Name = "cmdstripcolor1"
        Me.cmdstripcolor1.Size = New System.Drawing.Size(75, 23)
        Me.cmdstripcolor1.TabIndex = 1263
        Me.cmdstripcolor1.Text = "Strip Color"
        Me.cmdstripcolor1.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(268, 203)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 13)
        Me.Label22.TabIndex = 1262
        Me.Label22.Text = "Font color"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(267, 168)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 1260
        Me.Label15.Text = "Strip color"
        '
        'chkrtl
        '
        Me.chkrtl.AutoSize = True
        Me.chkrtl.Checked = True
        Me.chkrtl.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkrtl.Location = New System.Drawing.Point(339, 257)
        Me.chkrtl.Name = "chkrtl"
        Me.chkrtl.Size = New System.Drawing.Size(15, 14)
        Me.chkrtl.TabIndex = 1258
        Me.chkrtl.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(254, 255)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 1257
        Me.Label14.Text = "Right to Left"
        '
        'nstripopacity
        '
        Me.nstripopacity.DecimalPlaces = 1
        Me.nstripopacity.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nstripopacity.Location = New System.Drawing.Point(339, 142)
        Me.nstripopacity.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nstripopacity.Name = "nstripopacity"
        Me.nstripopacity.Size = New System.Drawing.Size(46, 20)
        Me.nstripopacity.TabIndex = 1256
        Me.nstripopacity.Value = New Decimal(New Integer() {10, 0, 0, 65536})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(252, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 13)
        Me.Label13.TabIndex = 1255
        Me.Label13.Text = "Strip Opacity"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.rdoLogoAndScroll)
        Me.GroupBox2.Controls.Add(Me.rdoOnlyScroll)
        Me.GroupBox2.Controls.Add(Me.rdoOnlyLogo)
        Me.GroupBox2.Location = New System.Drawing.Point(533, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(133, 89)
        Me.GroupBox2.TabIndex = 1254
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select"
        '
        'rdoLogoAndScroll
        '
        Me.rdoLogoAndScroll.AutoSize = True
        Me.rdoLogoAndScroll.Checked = True
        Me.rdoLogoAndScroll.Location = New System.Drawing.Point(7, 61)
        Me.rdoLogoAndScroll.Name = "rdoLogoAndScroll"
        Me.rdoLogoAndScroll.Size = New System.Drawing.Size(115, 17)
        Me.rdoLogoAndScroll.TabIndex = 1253
        Me.rdoLogoAndScroll.TabStop = True
        Me.rdoLogoAndScroll.Text = "Logo And Scroll"
        Me.rdoLogoAndScroll.UseVisualStyleBackColor = True
        '
        'rdoOnlyScroll
        '
        Me.rdoOnlyScroll.AutoSize = True
        Me.rdoOnlyScroll.Location = New System.Drawing.Point(7, 38)
        Me.rdoOnlyScroll.Name = "rdoOnlyScroll"
        Me.rdoOnlyScroll.Size = New System.Drawing.Size(86, 17)
        Me.rdoOnlyScroll.TabIndex = 1252
        Me.rdoOnlyScroll.Text = "Only Scroll"
        Me.rdoOnlyScroll.UseVisualStyleBackColor = True
        '
        'rdoOnlyLogo
        '
        Me.rdoOnlyLogo.AutoSize = True
        Me.rdoOnlyLogo.Location = New System.Drawing.Point(7, 16)
        Me.rdoOnlyLogo.Name = "rdoOnlyLogo"
        Me.rdoOnlyLogo.Size = New System.Drawing.Size(82, 17)
        Me.rdoOnlyLogo.TabIndex = 1251
        Me.rdoOnlyLogo.Text = "Only Logo"
        Me.rdoOnlyLogo.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(45, 207)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 13)
        Me.Label21.TabIndex = 1250
        Me.Label21.Text = "Logo"
        '
        'cmbvideocodec5
        '
        Me.cmbvideocodec5.FormattingEnabled = True
        Me.cmbvideocodec5.Location = New System.Drawing.Point(88, 19)
        Me.cmbvideocodec5.Name = "cmbvideocodec5"
        Me.cmbvideocodec5.Size = New System.Drawing.Size(88, 21)
        Me.cmbvideocodec5.Sorted = True
        Me.cmbvideocodec5.TabIndex = 792
        Me.cmbvideocodec5.Text = "libx264"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(335, 12)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 13)
        Me.Label18.TabIndex = 1249
        Me.Label18.Text = "Scoll Setting"
        '
        'nlogoxposition
        '
        Me.nlogoxposition.Location = New System.Drawing.Point(90, 99)
        Me.nlogoxposition.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.nlogoxposition.Name = "nlogoxposition"
        Me.nlogoxposition.Size = New System.Drawing.Size(45, 20)
        Me.nlogoxposition.TabIndex = 782
        Me.nlogoxposition.Value = New Decimal(New Integer() {615, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(396, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 13)
        Me.Label11.TabIndex = 1244
        Me.Label11.Text = "px"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(4, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 13)
        Me.Label17.TabIndex = 1248
        Me.Label17.Text = "Video Codec"
        '
        'nYPositionScroll
        '
        Me.nYPositionScroll.Location = New System.Drawing.Point(339, 275)
        Me.nYPositionScroll.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.nYPositionScroll.Name = "nYPositionScroll"
        Me.nYPositionScroll.Size = New System.Drawing.Size(46, 20)
        Me.nYPositionScroll.TabIndex = 1243
        Me.nYPositionScroll.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'nlogoyposition
        '
        Me.nlogoyposition.Location = New System.Drawing.Point(89, 124)
        Me.nlogoyposition.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.nlogoyposition.Name = "nlogoyposition"
        Me.nlogoyposition.Size = New System.Drawing.Size(37, 20)
        Me.nlogoyposition.TabIndex = 783
        Me.nlogoyposition.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(246, 277)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 1242
        Me.Label16.Text = "Above Bottom"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(4, 49)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 13)
        Me.Label19.TabIndex = 1246
        Me.Label19.Text = "Audio Codec"
        '
        'nlogowidthforexport
        '
        Me.nlogowidthforexport.Location = New System.Drawing.Point(90, 148)
        Me.nlogowidthforexport.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.nlogowidthforexport.Name = "nlogowidthforexport"
        Me.nlogowidthforexport.Size = New System.Drawing.Size(45, 20)
        Me.nlogowidthforexport.TabIndex = 785
        Me.nlogowidthforexport.Value = New Decimal(New Integer() {75, 0, 0, 0})
        '
        'Label255
        '
        Me.Label255.AutoSize = True
        Me.Label255.Location = New System.Drawing.Point(517, 16)
        Me.Label255.Name = "Label255"
        Me.Label255.Size = New System.Drawing.Size(149, 13)
        Me.Label255.TabIndex = 781
        Me.Label255.Text = "Status on ffmpeg window"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(42, 76)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 13)
        Me.Label20.TabIndex = 1245
        Me.Label20.Text = "Bitrate"
        '
        'nlogoheightforexport
        '
        Me.nlogoheightforexport.Location = New System.Drawing.Point(90, 172)
        Me.nlogoheightforexport.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.nlogoheightforexport.Name = "nlogoheightforexport"
        Me.nlogoheightforexport.Size = New System.Drawing.Size(37, 20)
        Me.nlogoheightforexport.TabIndex = 786
        Me.nlogoheightforexport.Value = New Decimal(New Integer() {75, 0, 0, 0})
        '
        'Label254
        '
        Me.Label254.AutoSize = True
        Me.Label254.Location = New System.Drawing.Point(66, 153)
        Me.Label254.Name = "Label254"
        Me.Label254.Size = New System.Drawing.Size(19, 13)
        Me.Label254.TabIndex = 787
        Me.Label254.Text = "W"
        '
        'nSpeedScroll
        '
        Me.nSpeedScroll.Location = New System.Drawing.Point(339, 232)
        Me.nSpeedScroll.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.nSpeedScroll.Name = "nSpeedScroll"
        Me.nSpeedScroll.Size = New System.Drawing.Size(46, 20)
        Me.nSpeedScroll.TabIndex = 1237
        Me.nSpeedScroll.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label253
        '
        Me.Label253.AutoSize = True
        Me.Label253.Location = New System.Drawing.Point(71, 174)
        Me.Label253.Name = "Label253"
        Me.Label253.Size = New System.Drawing.Size(16, 13)
        Me.Label253.TabIndex = 788
        Me.Label253.Text = "H"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(289, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 1236
        Me.Label12.Text = "Speed"
        '
        'Label252
        '
        Me.Label252.AutoSize = True
        Me.Label252.Location = New System.Drawing.Point(70, 102)
        Me.Label252.Name = "Label252"
        Me.Label252.Size = New System.Drawing.Size(15, 13)
        Me.Label252.TabIndex = 789
        Me.Label252.Text = "X"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(268, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 1233
        Me.Label10.Text = "Scroll text"
        '
        'Label251
        '
        Me.Label251.AutoSize = True
        Me.Label251.Location = New System.Drawing.Point(71, 127)
        Me.Label251.Name = "Label251"
        Me.Label251.Size = New System.Drawing.Size(15, 13)
        Me.Label251.TabIndex = 790
        Me.Label251.Text = "Y"
        '
        'cmdlogoexport
        '
        Me.cmdlogoexport.Location = New System.Drawing.Point(585, 32)
        Me.cmdlogoexport.Name = "cmdlogoexport"
        Me.cmdlogoexport.Size = New System.Drawing.Size(70, 100)
        Me.cmdlogoexport.TabIndex = 780
        Me.cmdlogoexport.Text = "Export with Logo and Scroll"
        Me.cmdlogoexport.UseVisualStyleBackColor = True
        '
        'cmbScrollText
        '
        Me.cmbScrollText.FormattingEnabled = True
        Me.cmbScrollText.Items.AddRange(New Object() {"DD EXCLUSIVE", "DD SAHYADRI", "DD SPORTS ONLY", "DD ARCHIVES"})
        Me.cmbScrollText.Location = New System.Drawing.Point(339, 40)
        Me.cmbScrollText.Name = "cmbScrollText"
        Me.cmbScrollText.Size = New System.Drawing.Size(180, 21)
        Me.cmbScrollText.TabIndex = 1232
        Me.cmbScrollText.Text = "DD SAHYADRI"
        '
        'nopacity
        '
        Me.nopacity.DecimalPlaces = 1
        Me.nopacity.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nopacity.Location = New System.Drawing.Point(339, 119)
        Me.nopacity.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nopacity.Name = "nopacity"
        Me.nopacity.Size = New System.Drawing.Size(46, 20)
        Me.nopacity.TabIndex = 1231
        Me.nopacity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmbaudiocodec5
        '
        Me.cmbaudiocodec5.FormattingEnabled = True
        Me.cmbaudiocodec5.Location = New System.Drawing.Point(88, 46)
        Me.cmbaudiocodec5.Name = "cmbaudiocodec5"
        Me.cmbaudiocodec5.Size = New System.Drawing.Size(76, 21)
        Me.cmbaudiocodec5.Sorted = True
        Me.cmbaudiocodec5.TabIndex = 793
        Me.cmbaudiocodec5.Text = "aac"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(253, 121)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(79, 13)
        Me.Label31.TabIndex = 1230
        Me.Label31.Text = "Font Opacity"
        '
        'cmbbitrate5
        '
        Me.cmbbitrate5.FormattingEnabled = True
        Me.cmbbitrate5.Items.AddRange(New Object() {"0.5", "1.0", "1.5", "2.0", "3", "4", "5", "6", "7", "8", "9", "10", "15", "20", "25", "30", "35", "40", "45", "50"})
        Me.cmbbitrate5.Location = New System.Drawing.Point(88, 73)
        Me.cmbbitrate5.Name = "cmbbitrate5"
        Me.cmbbitrate5.Size = New System.Drawing.Size(46, 21)
        Me.cmbbitrate5.TabIndex = 794
        Me.cmbbitrate5.Text = "1.0"
        '
        'cmbfontscroll
        '
        Me.cmbfontscroll.FormattingEnabled = True
        Me.cmbfontscroll.Location = New System.Drawing.Point(339, 65)
        Me.cmbfontscroll.Name = "cmbfontscroll"
        Me.cmbfontscroll.Size = New System.Drawing.Size(180, 21)
        Me.cmbfontscroll.TabIndex = 1229
        Me.cmbfontscroll.Text = "arialuni.ttf"
        '
        'vlcLogo
        '
        Me.vlcLogo.BackColor = System.Drawing.Color.Black
        Me.vlcLogo.Location = New System.Drawing.Point(90, 199)
        Me.vlcLogo.Name = "vlcLogo"
        Me.vlcLogo.Size = New System.Drawing.Size(67, 41)
        Me.vlcLogo.Spu = -1
        Me.vlcLogo.TabIndex = 1199
        Me.vlcLogo.Text = "VlcControl1"
        Me.vlcLogo.VlcLibDirectory = CType(resources.GetObject("vlcLogo.VlcLibDirectory"), System.IO.DirectoryInfo)
        Me.vlcLogo.VlcMediaplayerOptions = Nothing
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(300, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 1228
        Me.Label8.Text = "Font"
        '
        'cmdOpenLogo
        '
        Me.cmdOpenLogo.Location = New System.Drawing.Point(84, 246)
        Me.cmdOpenLogo.Name = "cmdOpenLogo"
        Me.cmdOpenLogo.Size = New System.Drawing.Size(92, 23)
        Me.cmdOpenLogo.TabIndex = 1200
        Me.cmdOpenLogo.Text = "Open Logo"
        Me.cmdOpenLogo.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(272, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 1227
        Me.Label9.Text = "Font Size"
        '
        'cmbfontsizescroll
        '
        Me.cmbfontsizescroll.FormattingEnabled = True
        Me.cmbfontsizescroll.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60", "70", "80", "90", "100"})
        Me.cmbfontsizescroll.Location = New System.Drawing.Point(339, 92)
        Me.cmbfontsizescroll.Name = "cmbfontsizescroll"
        Me.cmbfontsizescroll.Size = New System.Drawing.Size(43, 21)
        Me.cmbfontsizescroll.TabIndex = 1226
        Me.cmbfontsizescroll.Text = "25"
        '
        'cmbvideocodec6
        '
        Me.cmbvideocodec6.FormattingEnabled = True
        Me.cmbvideocodec6.Location = New System.Drawing.Point(12, 393)
        Me.cmbvideocodec6.Name = "cmbvideocodec6"
        Me.cmbvideocodec6.Size = New System.Drawing.Size(88, 21)
        Me.cmbvideocodec6.Sorted = True
        Me.cmbvideocodec6.TabIndex = 802
        Me.cmbvideocodec6.Text = "mpeg2video"
        '
        'cmbbitrate6
        '
        Me.cmbbitrate6.FormattingEnabled = True
        Me.cmbbitrate6.Items.AddRange(New Object() {"0.5", "1.0", "1.5", "2.0", "3", "4", "5", "6", "7", "8", "9", "10", "15", "20", "25", "30", "35", "40", "45", "50"})
        Me.cmbbitrate6.Location = New System.Drawing.Point(178, 394)
        Me.cmbbitrate6.Name = "cmbbitrate6"
        Me.cmbbitrate6.Size = New System.Drawing.Size(46, 21)
        Me.cmbbitrate6.TabIndex = 801
        Me.cmbbitrate6.Text = "50"
        '
        'lblexportclipinfo6
        '
        Me.lblexportclipinfo6.AutoSize = True
        Me.lblexportclipinfo6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexportclipinfo6.Location = New System.Drawing.Point(623, 392)
        Me.lblexportclipinfo6.Name = "lblexportclipinfo6"
        Me.lblexportclipinfo6.Size = New System.Drawing.Size(37, 13)
        Me.lblexportclipinfo6.TabIndex = 800
        Me.lblexportclipinfo6.Text = "Status"
        Me.lblexportclipinfo6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtoptionstrimmer6
        '
        Me.txtoptionstrimmer6.Location = New System.Drawing.Point(9, 416)
        Me.txtoptionstrimmer6.Multiline = True
        Me.txtoptionstrimmer6.Name = "txtoptionstrimmer6"
        Me.txtoptionstrimmer6.Size = New System.Drawing.Size(644, 45)
        Me.txtoptionstrimmer6.TabIndex = 797
        Me.txtoptionstrimmer6.Text = resources.GetString("txtoptionstrimmer6.Text")
        '
        'pbexportclip6
        '
        Me.pbexportclip6.Location = New System.Drawing.Point(522, 391)
        Me.pbexportclip6.Maximum = 268
        Me.pbexportclip6.Name = "pbexportclip6"
        Me.pbexportclip6.Size = New System.Drawing.Size(95, 19)
        Me.pbexportclip6.TabIndex = 799
        '
        'cmdclipcuttrimmer6
        '
        Me.cmdclipcuttrimmer6.Location = New System.Drawing.Point(449, 391)
        Me.cmdclipcuttrimmer6.Name = "cmdclipcuttrimmer6"
        Me.cmdclipcuttrimmer6.Size = New System.Drawing.Size(69, 23)
        Me.cmdclipcuttrimmer6.TabIndex = 796
        Me.cmdclipcuttrimmer6.Text = "Export Clip"
        Me.cmdclipcuttrimmer6.UseVisualStyleBackColor = True
        '
        'cmbaudiocodec6
        '
        Me.cmbaudiocodec6.FormattingEnabled = True
        Me.cmbaudiocodec6.Location = New System.Drawing.Point(100, 393)
        Me.cmbaudiocodec6.Name = "cmbaudiocodec6"
        Me.cmbaudiocodec6.Size = New System.Drawing.Size(76, 21)
        Me.cmbaudiocodec6.Sorted = True
        Me.cmbaudiocodec6.TabIndex = 798
        Me.cmbaudiocodec6.Text = "pcm_s24le"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 378)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 13)
        Me.Label3.TabIndex = 795
        Me.Label3.Text = "HD 1920x1080  to SD Letter Box"
        '
        'Label250
        '
        Me.Label250.AutoSize = True
        Me.Label250.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label250.Location = New System.Drawing.Point(283, 463)
        Me.Label250.Name = "Label250"
        Me.Label250.Size = New System.Drawing.Size(136, 13)
        Me.Label250.TabIndex = 779
        Me.Label250.Text = "Status on FFMpeg Window"
        Me.Label250.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblexportclipinfo3
        '
        Me.lblexportclipinfo3.AutoSize = True
        Me.lblexportclipinfo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexportclipinfo3.Location = New System.Drawing.Point(522, 189)
        Me.lblexportclipinfo3.Name = "lblexportclipinfo3"
        Me.lblexportclipinfo3.Size = New System.Drawing.Size(136, 13)
        Me.lblexportclipinfo3.TabIndex = 778
        Me.lblexportclipinfo3.Text = "Status on FFMpeg Window"
        Me.lblexportclipinfo3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtoptionsffmbc
        '
        Me.txtoptionsffmbc.Location = New System.Drawing.Point(12, 476)
        Me.txtoptionsffmbc.Multiline = True
        Me.txtoptionsffmbc.Name = "txtoptionsffmbc"
        Me.txtoptionsffmbc.Size = New System.Drawing.Size(598, 74)
        Me.txtoptionsffmbc.TabIndex = 777
        Me.txtoptionsffmbc.Text = resources.GetString("txtoptionsffmbc.Text")
        '
        'Label226
        '
        Me.Label226.AutoSize = True
        Me.Label226.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label226.Location = New System.Drawing.Point(17, 462)
        Me.Label226.Name = "Label226"
        Me.Label226.Size = New System.Drawing.Size(234, 13)
        Me.Label226.TabIndex = 776
        Me.Label226.Text = "HD to XDCAM HD422 MXF with FFMBC "
        '
        'cmdffmbcexport
        '
        Me.cmdffmbcexport.Location = New System.Drawing.Point(616, 479)
        Me.cmdffmbcexport.Name = "cmdffmbcexport"
        Me.cmdffmbcexport.Size = New System.Drawing.Size(55, 63)
        Me.cmdffmbcexport.TabIndex = 775
        Me.cmdffmbcexport.Text = "Export Clip"
        Me.cmdffmbcexport.UseVisualStyleBackColor = True
        '
        'Label224
        '
        Me.Label224.AutoSize = True
        Me.Label224.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label224.Location = New System.Drawing.Point(540, 39)
        Me.Label224.Name = "Label224"
        Me.Label224.Size = New System.Drawing.Size(136, 13)
        Me.Label224.TabIndex = 772
        Me.Label224.Text = "Status on FFMpeg Window"
        Me.Label224.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbbitrate
        '
        Me.cmbbitrate.FormattingEnabled = True
        Me.cmbbitrate.Items.AddRange(New Object() {"0.5", "1.0", "1.5", "2.0", "3", "4", "5", "6", "7", "8", "9", "10", "15", "20", "25", "30", "35", "40", "45", "50"})
        Me.cmbbitrate.Location = New System.Drawing.Point(185, 33)
        Me.cmbbitrate.Name = "cmbbitrate"
        Me.cmbbitrate.Size = New System.Drawing.Size(46, 21)
        Me.cmbbitrate.TabIndex = 771
        Me.cmbbitrate.Text = "12"
        '
        'txtoptionstrimmer
        '
        Me.txtoptionstrimmer.Location = New System.Drawing.Point(254, 36)
        Me.txtoptionstrimmer.Name = "txtoptionstrimmer"
        Me.txtoptionstrimmer.Size = New System.Drawing.Size(204, 20)
        Me.txtoptionstrimmer.TabIndex = 717
        '
        'chkaudiocodeccopy
        '
        Me.chkaudiocodeccopy.AutoSize = True
        Me.chkaudiocodeccopy.Location = New System.Drawing.Point(101, 57)
        Me.chkaudiocodeccopy.Name = "chkaudiocodeccopy"
        Me.chkaudiocodeccopy.Size = New System.Drawing.Size(50, 17)
        Me.chkaudiocodeccopy.TabIndex = 721
        Me.chkaudiocodeccopy.Text = "Copy"
        Me.chkaudiocodeccopy.UseVisualStyleBackColor = True
        '
        'chkvideocodeccopy
        '
        Me.chkvideocodeccopy.AutoSize = True
        Me.chkvideocodeccopy.Location = New System.Drawing.Point(13, 57)
        Me.chkvideocodeccopy.Name = "chkvideocodeccopy"
        Me.chkvideocodeccopy.Size = New System.Drawing.Size(50, 17)
        Me.chkvideocodeccopy.TabIndex = 720
        Me.chkvideocodeccopy.Text = "Copy"
        Me.chkvideocodeccopy.UseVisualStyleBackColor = True
        '
        'cmbbitrate4
        '
        Me.cmbbitrate4.FormattingEnabled = True
        Me.cmbbitrate4.Items.AddRange(New Object() {"0.5", "1.0", "1.5", "2.0", "3", "4", "5", "6", "7", "8", "9", "10", "15", "20", "25", "30", "35", "40", "45", "50"})
        Me.cmbbitrate4.Location = New System.Drawing.Point(181, 309)
        Me.cmbbitrate4.Name = "cmbbitrate4"
        Me.cmbbitrate4.Size = New System.Drawing.Size(46, 21)
        Me.cmbbitrate4.TabIndex = 766
        Me.cmbbitrate4.Text = "50"
        '
        'lblexportclipinfo4
        '
        Me.lblexportclipinfo4.AutoSize = True
        Me.lblexportclipinfo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexportclipinfo4.Location = New System.Drawing.Point(626, 312)
        Me.lblexportclipinfo4.Name = "lblexportclipinfo4"
        Me.lblexportclipinfo4.Size = New System.Drawing.Size(37, 13)
        Me.lblexportclipinfo4.TabIndex = 765
        Me.lblexportclipinfo4.Text = "Status"
        Me.lblexportclipinfo4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtoptionstrimmer4
        '
        Me.txtoptionstrimmer4.Location = New System.Drawing.Point(12, 332)
        Me.txtoptionstrimmer4.Multiline = True
        Me.txtoptionstrimmer4.Name = "txtoptionstrimmer4"
        Me.txtoptionstrimmer4.Size = New System.Drawing.Size(644, 45)
        Me.txtoptionstrimmer4.TabIndex = 762
        Me.txtoptionstrimmer4.Text = resources.GetString("txtoptionstrimmer4.Text")
        '
        'cmbaudiocodec
        '
        Me.cmbaudiocodec.FormattingEnabled = True
        Me.cmbaudiocodec.Location = New System.Drawing.Point(100, 33)
        Me.cmbaudiocodec.Name = "cmbaudiocodec"
        Me.cmbaudiocodec.Size = New System.Drawing.Size(76, 21)
        Me.cmbaudiocodec.Sorted = True
        Me.cmbaudiocodec.TabIndex = 717
        Me.cmbaudiocodec.Text = "aac"
        '
        'cmdclipcuttrimmer
        '
        Me.cmdclipcuttrimmer.Location = New System.Drawing.Point(468, 34)
        Me.cmdclipcuttrimmer.Name = "cmdclipcuttrimmer"
        Me.cmdclipcuttrimmer.Size = New System.Drawing.Size(68, 23)
        Me.cmdclipcuttrimmer.TabIndex = 639
        Me.cmdclipcuttrimmer.Text = "Export Clip"
        Me.cmdclipcuttrimmer.UseVisualStyleBackColor = True
        '
        'pbexportclip4
        '
        Me.pbexportclip4.Location = New System.Drawing.Point(525, 311)
        Me.pbexportclip4.Maximum = 268
        Me.pbexportclip4.Name = "pbexportclip4"
        Me.pbexportclip4.Size = New System.Drawing.Size(95, 19)
        Me.pbexportclip4.TabIndex = 764
        '
        'cmdclipcuttrimmer4
        '
        Me.cmdclipcuttrimmer4.Location = New System.Drawing.Point(452, 311)
        Me.cmdclipcuttrimmer4.Name = "cmdclipcuttrimmer4"
        Me.cmdclipcuttrimmer4.Size = New System.Drawing.Size(69, 23)
        Me.cmdclipcuttrimmer4.TabIndex = 760
        Me.cmdclipcuttrimmer4.Text = "Export Clip"
        Me.cmdclipcuttrimmer4.UseVisualStyleBackColor = True
        '
        'cmbaudiocodec4
        '
        Me.cmbaudiocodec4.FormattingEnabled = True
        Me.cmbaudiocodec4.Location = New System.Drawing.Point(103, 309)
        Me.cmbaudiocodec4.Name = "cmbaudiocodec4"
        Me.cmbaudiocodec4.Size = New System.Drawing.Size(76, 21)
        Me.cmbaudiocodec4.Sorted = True
        Me.cmbaudiocodec4.TabIndex = 763
        Me.cmbaudiocodec4.Text = "pcm_s24le"
        '
        'Label248
        '
        Me.Label248.AutoSize = True
        Me.Label248.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label248.Location = New System.Drawing.Point(13, 294)
        Me.Label248.Name = "Label248"
        Me.Label248.Size = New System.Drawing.Size(193, 13)
        Me.Label248.TabIndex = 759
        Me.Label248.Text = "HD 1920x1080  to SD center cut"
        '
        'Label245
        '
        Me.Label245.AutoSize = True
        Me.Label245.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label245.Location = New System.Drawing.Point(11, 120)
        Me.Label245.Name = "Label245"
        Me.Label245.Size = New System.Drawing.Size(60, 13)
        Me.Label245.TabIndex = 769
        Me.Label245.Text = "HD Proxy"
        '
        'txtoptionstrimmer3
        '
        Me.txtoptionstrimmer3.Location = New System.Drawing.Point(12, 211)
        Me.txtoptionstrimmer3.Multiline = True
        Me.txtoptionstrimmer3.Name = "txtoptionstrimmer3"
        Me.txtoptionstrimmer3.Size = New System.Drawing.Size(612, 73)
        Me.txtoptionstrimmer3.TabIndex = 753
        Me.txtoptionstrimmer3.Text = resources.GetString("txtoptionstrimmer3.Text")
        '
        'cmbvideocodec3
        '
        Me.cmbvideocodec3.Enabled = False
        Me.cmbvideocodec3.FormattingEnabled = True
        Me.cmbvideocodec3.Location = New System.Drawing.Point(12, 185)
        Me.cmbvideocodec3.Name = "cmbvideocodec3"
        Me.cmbvideocodec3.Size = New System.Drawing.Size(88, 21)
        Me.cmbvideocodec3.Sorted = True
        Me.cmbvideocodec3.TabIndex = 752
        Me.cmbvideocodec3.Text = "mpeg2video"
        '
        'cmbvideocodec4
        '
        Me.cmbvideocodec4.FormattingEnabled = True
        Me.cmbvideocodec4.Location = New System.Drawing.Point(12, 307)
        Me.cmbvideocodec4.Name = "cmbvideocodec4"
        Me.cmbvideocodec4.Size = New System.Drawing.Size(88, 21)
        Me.cmbvideocodec4.Sorted = True
        Me.cmbvideocodec4.TabIndex = 761
        Me.cmbvideocodec4.Text = "mpeg2video"
        '
        'cmbbitrate3
        '
        Me.cmbbitrate3.Enabled = False
        Me.cmbbitrate3.FormattingEnabled = True
        Me.cmbbitrate3.Items.AddRange(New Object() {"0.5", "1.0", "1.5", "2.0", "3", "4", "5", "6", "7", "8", "9", "10", "15", "20", "25", "30", "35", "40", "45", "50"})
        Me.cmbbitrate3.Location = New System.Drawing.Point(179, 187)
        Me.cmbbitrate3.Name = "cmbbitrate3"
        Me.cmbbitrate3.Size = New System.Drawing.Size(46, 21)
        Me.cmbbitrate3.TabIndex = 757
        Me.cmbbitrate3.Text = "50"
        '
        'pbexportclip3
        '
        Me.pbexportclip3.Location = New System.Drawing.Point(523, 186)
        Me.pbexportclip3.Maximum = 268
        Me.pbexportclip3.Name = "pbexportclip3"
        Me.pbexportclip3.Size = New System.Drawing.Size(42, 19)
        Me.pbexportclip3.TabIndex = 755
        '
        'cmbvideocodec
        '
        Me.cmbvideocodec.FormattingEnabled = True
        Me.cmbvideocodec.Location = New System.Drawing.Point(7, 33)
        Me.cmbvideocodec.Name = "cmbvideocodec"
        Me.cmbvideocodec.Size = New System.Drawing.Size(88, 21)
        Me.cmbvideocodec.Sorted = True
        Me.cmbvideocodec.TabIndex = 716
        Me.cmbvideocodec.Text = "libx264"
        '
        'Label247
        '
        Me.Label247.AutoSize = True
        Me.Label247.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label247.Location = New System.Drawing.Point(6, 75)
        Me.Label247.Name = "Label247"
        Me.Label247.Size = New System.Drawing.Size(59, 13)
        Me.Label247.TabIndex = 758
        Me.Label247.Text = "SD Proxy"
        '
        'cmdclipcuttrimmer3
        '
        Me.cmdclipcuttrimmer3.Location = New System.Drawing.Point(450, 186)
        Me.cmdclipcuttrimmer3.Name = "cmdclipcuttrimmer3"
        Me.cmdclipcuttrimmer3.Size = New System.Drawing.Size(69, 23)
        Me.cmdclipcuttrimmer3.TabIndex = 751
        Me.cmdclipcuttrimmer3.Text = "Export Clip"
        Me.cmdclipcuttrimmer3.UseVisualStyleBackColor = True
        '
        'cmbaudiocodec3
        '
        Me.cmbaudiocodec3.Enabled = False
        Me.cmbaudiocodec3.FormattingEnabled = True
        Me.cmbaudiocodec3.Location = New System.Drawing.Point(101, 186)
        Me.cmbaudiocodec3.Name = "cmbaudiocodec3"
        Me.cmbaudiocodec3.Size = New System.Drawing.Size(76, 21)
        Me.cmbaudiocodec3.Sorted = True
        Me.cmbaudiocodec3.TabIndex = 754
        Me.cmbaudiocodec3.Text = "pcm_s24le"
        '
        'Label244
        '
        Me.Label244.AutoSize = True
        Me.Label244.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label244.Location = New System.Drawing.Point(13, 169)
        Me.Label244.Name = "Label244"
        Me.Label244.Size = New System.Drawing.Size(523, 13)
        Me.Label244.TabIndex = 750
        Me.Label244.Text = "SD 720x576  to HD 1920x1080 pillar box and then HD to XDCAM HD422 MXF with FFMBC " &
    ""
        '
        'cmbbitrate2
        '
        Me.cmbbitrate2.FormattingEnabled = True
        Me.cmbbitrate2.Items.AddRange(New Object() {"0.5", "1.0", "1.5", "2.0", "3", "4", "5", "6", "7", "8", "9", "10", "15", "20", "25", "30", "35", "40", "45", "50"})
        Me.cmbbitrate2.Location = New System.Drawing.Point(185, 136)
        Me.cmbbitrate2.Name = "cmbbitrate2"
        Me.cmbbitrate2.Size = New System.Drawing.Size(46, 21)
        Me.cmbbitrate2.TabIndex = 749
        Me.cmbbitrate2.Text = "2.0"
        '
        'cmbvideocodec1
        '
        Me.cmbvideocodec1.FormattingEnabled = True
        Me.cmbvideocodec1.Location = New System.Drawing.Point(8, 94)
        Me.cmbvideocodec1.Name = "cmbvideocodec1"
        Me.cmbvideocodec1.Size = New System.Drawing.Size(88, 21)
        Me.cmbvideocodec1.Sorted = True
        Me.cmbvideocodec1.TabIndex = 724
        Me.cmbvideocodec1.Text = "libx264"
        '
        'lblexportclipinfo2
        '
        Me.lblexportclipinfo2.AutoSize = True
        Me.lblexportclipinfo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexportclipinfo2.Location = New System.Drawing.Point(641, 137)
        Me.lblexportclipinfo2.Name = "lblexportclipinfo2"
        Me.lblexportclipinfo2.Size = New System.Drawing.Size(37, 13)
        Me.lblexportclipinfo2.TabIndex = 748
        Me.lblexportclipinfo2.Text = "Status"
        Me.lblexportclipinfo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtoptionstrimmer2
        '
        Me.txtoptionstrimmer2.Location = New System.Drawing.Point(254, 134)
        Me.txtoptionstrimmer2.Name = "txtoptionstrimmer2"
        Me.txtoptionstrimmer2.Size = New System.Drawing.Size(204, 20)
        Me.txtoptionstrimmer2.TabIndex = 745
        '
        'pbexportclip2
        '
        Me.pbexportclip2.Location = New System.Drawing.Point(543, 133)
        Me.pbexportclip2.Maximum = 268
        Me.pbexportclip2.Name = "pbexportclip2"
        Me.pbexportclip2.Size = New System.Drawing.Size(95, 19)
        Me.pbexportclip2.TabIndex = 747
        '
        'cmdclipcuttrimmer2
        '
        Me.cmdclipcuttrimmer2.Location = New System.Drawing.Point(468, 134)
        Me.cmdclipcuttrimmer2.Name = "cmdclipcuttrimmer2"
        Me.cmdclipcuttrimmer2.Size = New System.Drawing.Size(69, 23)
        Me.cmdclipcuttrimmer2.TabIndex = 743
        Me.cmdclipcuttrimmer2.Text = "Export Clip"
        Me.cmdclipcuttrimmer2.UseVisualStyleBackColor = True
        '
        'cmbaudiocodec2
        '
        Me.cmbaudiocodec2.FormattingEnabled = True
        Me.cmbaudiocodec2.Location = New System.Drawing.Point(99, 136)
        Me.cmbaudiocodec2.Name = "cmbaudiocodec2"
        Me.cmbaudiocodec2.Size = New System.Drawing.Size(76, 21)
        Me.cmbaudiocodec2.Sorted = True
        Me.cmbaudiocodec2.TabIndex = 746
        Me.cmbaudiocodec2.Text = "aac"
        '
        'cmbvideocodec2
        '
        Me.cmbvideocodec2.FormattingEnabled = True
        Me.cmbvideocodec2.Location = New System.Drawing.Point(8, 136)
        Me.cmbvideocodec2.Name = "cmbvideocodec2"
        Me.cmbvideocodec2.Size = New System.Drawing.Size(88, 21)
        Me.cmbvideocodec2.Sorted = True
        Me.cmbvideocodec2.TabIndex = 744
        Me.cmbvideocodec2.Text = "libx264"
        '
        'Label243
        '
        Me.Label243.AutoSize = True
        Me.Label243.Enabled = False
        Me.Label243.Location = New System.Drawing.Point(273, 20)
        Me.Label243.Name = "Label243"
        Me.Label243.Size = New System.Drawing.Size(70, 13)
        Me.Label243.TabIndex = 723
        Me.Label243.Text = "More Options"
        '
        'Label242
        '
        Me.Label242.AutoSize = True
        Me.Label242.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label242.Location = New System.Drawing.Point(182, 17)
        Me.Label242.Name = "Label242"
        Me.Label242.Size = New System.Drawing.Size(45, 13)
        Me.Label242.TabIndex = 742
        Me.Label242.Text = "Bit Rate"
        Me.Label242.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbbitrate1
        '
        Me.cmbbitrate1.FormattingEnabled = True
        Me.cmbbitrate1.Items.AddRange(New Object() {"0.5", "1.0", "1.5", "2.0", "3", "4", "5", "6", "7", "8", "9", "10", "15", "20", "25", "30", "35", "40", "45", "50"})
        Me.cmbbitrate1.Location = New System.Drawing.Point(185, 95)
        Me.cmbbitrate1.Name = "cmbbitrate1"
        Me.cmbbitrate1.Size = New System.Drawing.Size(46, 21)
        Me.cmbbitrate1.TabIndex = 741
        Me.cmbbitrate1.Text = "1.0"
        '
        'Label241
        '
        Me.Label241.AutoSize = True
        Me.Label241.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label241.Location = New System.Drawing.Point(100, 17)
        Me.Label241.Name = "Label241"
        Me.Label241.Size = New System.Drawing.Size(68, 13)
        Me.Label241.TabIndex = 740
        Me.Label241.Text = "Audio Codec"
        Me.Label241.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label240
        '
        Me.Label240.AutoSize = True
        Me.Label240.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label240.Location = New System.Drawing.Point(1, 17)
        Me.Label240.Name = "Label240"
        Me.Label240.Size = New System.Drawing.Size(68, 13)
        Me.Label240.TabIndex = 739
        Me.Label240.Text = "Video Codec"
        Me.Label240.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblexportclipinfo1
        '
        Me.lblexportclipinfo1.AutoSize = True
        Me.lblexportclipinfo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexportclipinfo1.Location = New System.Drawing.Point(640, 98)
        Me.lblexportclipinfo1.Name = "lblexportclipinfo1"
        Me.lblexportclipinfo1.Size = New System.Drawing.Size(37, 13)
        Me.lblexportclipinfo1.TabIndex = 738
        Me.lblexportclipinfo1.Text = "Status"
        Me.lblexportclipinfo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtoptionstrimmer1
        '
        Me.txtoptionstrimmer1.Location = New System.Drawing.Point(254, 95)
        Me.txtoptionstrimmer1.Name = "txtoptionstrimmer1"
        Me.txtoptionstrimmer1.Size = New System.Drawing.Size(204, 20)
        Me.txtoptionstrimmer1.TabIndex = 725
        '
        'pbexportclip1
        '
        Me.pbexportclip1.Location = New System.Drawing.Point(543, 96)
        Me.pbexportclip1.Maximum = 268
        Me.pbexportclip1.Name = "pbexportclip1"
        Me.pbexportclip1.Size = New System.Drawing.Size(95, 19)
        Me.pbexportclip1.TabIndex = 737
        '
        'cmdclipcuttrimmer1
        '
        Me.cmdclipcuttrimmer1.Location = New System.Drawing.Point(468, 93)
        Me.cmdclipcuttrimmer1.Name = "cmdclipcuttrimmer1"
        Me.cmdclipcuttrimmer1.Size = New System.Drawing.Size(69, 23)
        Me.cmdclipcuttrimmer1.TabIndex = 723
        Me.cmdclipcuttrimmer1.Text = "Export Clip"
        Me.cmdclipcuttrimmer1.UseVisualStyleBackColor = True
        '
        'cmbaudiocodec1
        '
        Me.cmbaudiocodec1.FormattingEnabled = True
        Me.cmbaudiocodec1.Location = New System.Drawing.Point(101, 94)
        Me.cmbaudiocodec1.Name = "cmbaudiocodec1"
        Me.cmbaudiocodec1.Size = New System.Drawing.Size(76, 21)
        Me.cmbaudiocodec1.Sorted = True
        Me.cmbaudiocodec1.TabIndex = 726
        Me.cmbaudiocodec1.Text = "aac"
        '
        'ClipJoinder
        '
        Me.ClipJoinder.Controls.Add(Me.GroupBox5)
        Me.ClipJoinder.Location = New System.Drawing.Point(4, 22)
        Me.ClipJoinder.Name = "ClipJoinder"
        Me.ClipJoinder.Padding = New System.Windows.Forms.Padding(3)
        Me.ClipJoinder.Size = New System.Drawing.Size(706, 872)
        Me.ClipJoinder.TabIndex = 2
        Me.ClipJoinder.Text = "Clip Joiner"
        Me.ClipJoinder.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.dgvjoiner)
        Me.GroupBox5.Controls.Add(Me.Label227)
        Me.GroupBox5.Controls.Add(Me.Label228)
        Me.GroupBox5.Controls.Add(Me.chkaudiocodeccopyjoin)
        Me.GroupBox5.Controls.Add(Me.txtoptionstrimmerjoin)
        Me.GroupBox5.Controls.Add(Me.chkvideocodeccopyjoin)
        Me.GroupBox5.Controls.Add(Me.Label229)
        Me.GroupBox5.Controls.Add(Me.cmdclipjoin)
        Me.GroupBox5.Controls.Add(Me.cmbaudiocodecjoin)
        Me.GroupBox5.Controls.Add(Me.cmbvideocodecjoin)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 17)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(683, 588)
        Me.GroupBox5.TabIndex = 723
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Try with similar clips"
        '
        'dgvjoiner
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvjoiner.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvjoiner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvjoiner.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.File, Me.Openfile})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvjoiner.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvjoiner.Location = New System.Drawing.Point(6, 96)
        Me.dgvjoiner.Name = "dgvjoiner"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvjoiner.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvjoiner.Size = New System.Drawing.Size(671, 320)
        Me.dgvjoiner.TabIndex = 729
        '
        'Openfile
        '
        Me.Openfile.HeaderText = "Open  File"
        Me.Openfile.Name = "Openfile"
        Me.Openfile.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Openfile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Openfile.Width = 50
        '
        'Label227
        '
        Me.Label227.AutoSize = True
        Me.Label227.Location = New System.Drawing.Point(12, 24)
        Me.Label227.Name = "Label227"
        Me.Label227.Size = New System.Drawing.Size(68, 13)
        Me.Label227.TabIndex = 722
        Me.Label227.Text = "Video Codec"
        '
        'Label228
        '
        Me.Label228.AutoSize = True
        Me.Label228.Location = New System.Drawing.Point(187, 429)
        Me.Label228.Name = "Label228"
        Me.Label228.Size = New System.Drawing.Size(70, 13)
        Me.Label228.TabIndex = 716
        Me.Label228.Text = "More Options"
        '
        'chkaudiocodeccopyjoin
        '
        Me.chkaudiocodeccopyjoin.AutoSize = True
        Me.chkaudiocodeccopyjoin.Location = New System.Drawing.Point(98, 64)
        Me.chkaudiocodeccopyjoin.Name = "chkaudiocodeccopyjoin"
        Me.chkaudiocodeccopyjoin.Size = New System.Drawing.Size(50, 17)
        Me.chkaudiocodeccopyjoin.TabIndex = 721
        Me.chkaudiocodeccopyjoin.Text = "Copy"
        Me.chkaudiocodeccopyjoin.UseVisualStyleBackColor = True
        '
        'txtoptionstrimmerjoin
        '
        Me.txtoptionstrimmerjoin.Location = New System.Drawing.Point(6, 443)
        Me.txtoptionstrimmerjoin.Name = "txtoptionstrimmerjoin"
        Me.txtoptionstrimmerjoin.Size = New System.Drawing.Size(462, 20)
        Me.txtoptionstrimmerjoin.TabIndex = 717
        '
        'chkvideocodeccopyjoin
        '
        Me.chkvideocodeccopyjoin.AutoSize = True
        Me.chkvideocodeccopyjoin.Location = New System.Drawing.Point(11, 63)
        Me.chkvideocodeccopyjoin.Name = "chkvideocodeccopyjoin"
        Me.chkvideocodeccopyjoin.Size = New System.Drawing.Size(50, 17)
        Me.chkvideocodeccopyjoin.TabIndex = 720
        Me.chkvideocodeccopyjoin.Text = "Copy"
        Me.chkvideocodeccopyjoin.UseVisualStyleBackColor = True
        '
        'Label229
        '
        Me.Label229.AutoSize = True
        Me.Label229.Location = New System.Drawing.Point(92, 24)
        Me.Label229.Name = "Label229"
        Me.Label229.Size = New System.Drawing.Size(68, 13)
        Me.Label229.TabIndex = 719
        Me.Label229.Text = "Audio Codec"
        '
        'cmdclipjoin
        '
        Me.cmdclipjoin.Location = New System.Drawing.Point(474, 422)
        Me.cmdclipjoin.Name = "cmdclipjoin"
        Me.cmdclipjoin.Size = New System.Drawing.Size(80, 61)
        Me.cmdclipjoin.TabIndex = 639
        Me.cmdclipjoin.Text = "Join Clips"
        Me.cmdclipjoin.UseVisualStyleBackColor = True
        '
        'cmbaudiocodecjoin
        '
        Me.cmbaudiocodecjoin.FormattingEnabled = True
        Me.cmbaudiocodecjoin.Location = New System.Drawing.Point(95, 38)
        Me.cmbaudiocodecjoin.Name = "cmbaudiocodecjoin"
        Me.cmbaudiocodecjoin.Size = New System.Drawing.Size(88, 21)
        Me.cmbaudiocodecjoin.Sorted = True
        Me.cmbaudiocodecjoin.TabIndex = 717
        Me.cmbaudiocodecjoin.Text = "copy"
        '
        'cmbvideocodecjoin
        '
        Me.cmbvideocodecjoin.FormattingEnabled = True
        Me.cmbvideocodecjoin.Location = New System.Drawing.Point(4, 38)
        Me.cmbvideocodecjoin.Name = "cmbvideocodecjoin"
        Me.cmbvideocodecjoin.Size = New System.Drawing.Size(88, 21)
        Me.cmbvideocodecjoin.Sorted = True
        Me.cmbvideocodecjoin.TabIndex = 716
        Me.cmbvideocodecjoin.Text = "copy"
        '
        'cmdCueFromCurrentPosition
        '
        Me.cmdCueFromCurrentPosition.Location = New System.Drawing.Point(22, 619)
        Me.cmdCueFromCurrentPosition.Name = "cmdCueFromCurrentPosition"
        Me.cmdCueFromCurrentPosition.Size = New System.Drawing.Size(74, 82)
        Me.cmdCueFromCurrentPosition.TabIndex = 796
        Me.cmdCueFromCurrentPosition.Text = "Cue in Casparcg From Current Position"
        Me.cmdCueFromCurrentPosition.UseVisualStyleBackColor = True
        '
        'cmdPlayFromCurrentPosition
        '
        Me.cmdPlayFromCurrentPosition.Location = New System.Drawing.Point(102, 619)
        Me.cmdPlayFromCurrentPosition.Name = "cmdPlayFromCurrentPosition"
        Me.cmdPlayFromCurrentPosition.Size = New System.Drawing.Size(74, 82)
        Me.cmdPlayFromCurrentPosition.TabIndex = 171
        Me.cmdPlayFromCurrentPosition.Text = "Play in Casparcg From Current Position"
        Me.cmdPlayFromCurrentPosition.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 13)
        Me.Label2.TabIndex = 800
        Me.Label2.Text = "Trimmer   Works only with vlc  version 2.2.1 32bit"
        '
        'FileOpen
        '
        Me.FileOpen.HeaderText = "Open  File"
        Me.FileOpen.Name = "FileOpen"
        Me.FileOpen.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FileOpen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FileOpen.Width = 50
        '
        'bwforexportclip1
        '
        Me.bwforexportclip1.WorkerSupportsCancellation = True
        '
        'bwforexportclip2
        '
        Me.bwforexportclip2.WorkerSupportsCancellation = True
        '
        'bwforexportclip4
        '
        Me.bwforexportclip4.WorkerSupportsCancellation = True
        '
        'bwforexportclip3
        '
        Me.bwforexportclip3.WorkerSupportsCancellation = True
        '
        'bwforexportclip6
        '
        Me.bwforexportclip6.WorkerSupportsCancellation = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sub Clip Name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 250
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 250
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "IN Point"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "OutPoint"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Duration"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 250
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 300
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "File"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 550
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "File"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 300
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Caption"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 250
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Width = 300
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "In"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.Width = 75
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Out"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 75
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Duration"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "File"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn11.Width = 550
        '
        'UcnewTrimmer11
        '
        Me.UcnewTrimmer11.AllowDrop = True
        Me.UcnewTrimmer11.BackColor = System.Drawing.Color.LightGray
        Me.UcnewTrimmer11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcnewTrimmer11.Location = New System.Drawing.Point(3, 7)
        Me.UcnewTrimmer11.Name = "UcnewTrimmer11"
        Me.UcnewTrimmer11.Size = New System.Drawing.Size(486, 533)
        Me.UcnewTrimmer11.TabIndex = 799
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Caption"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn15.Width = 300
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "In"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 75
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Out"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 75
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "File"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn12.Width = 300
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "In"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 75
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Out"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 75
        '
        'UcTranscodingProfile1
        '
        Me.UcTranscodingProfile1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcTranscodingProfile1.Location = New System.Drawing.Point(6, 6)
        Me.UcTranscodingProfile1.Name = "UcTranscodingProfile1"
        Me.UcTranscodingProfile1.Size = New System.Drawing.Size(387, 847)
        Me.UcTranscodingProfile1.TabIndex = 0
        '
        'ClipName
        '
        Me.ClipName.HeaderText = "Sub Clip Name"
        Me.ClipName.MinimumWidth = 250
        Me.ClipName.Name = "ClipName"
        Me.ClipName.Width = 250
        '
        'INPoint
        '
        Me.INPoint.HeaderText = "IN Point"
        Me.INPoint.Name = "INPoint"
        Me.INPoint.Width = 80
        '
        'OutPoint
        '
        Me.OutPoint.HeaderText = "OutPoint"
        Me.OutPoint.Name = "OutPoint"
        Me.OutPoint.Width = 80
        '
        'Duration
        '
        Me.Duration.HeaderText = "Duration"
        Me.Duration.Name = "Duration"
        '
        'File
        '
        Me.File.HeaderText = "File"
        Me.File.Name = "File"
        Me.File.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.File.Width = 550
        '
        'Column1
        '
        Me.Column1.HeaderText = "In"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 75
        '
        'Column2
        '
        Me.Column2.HeaderText = "Out"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 75
        '
        'ucTrimmer
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1340, 932)
        Me.Controls.Add(Me.gbTrimmer)
        Me.HideOnClose = True
        Me.Name = "ucTrimmer"
        Me.Text = "Trimmer"
        Me.gbTrimmer.ResumeLayout(False)
        Me.gbTrimmer.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tbGraphics.ResumeLayout(False)
        Me.tbGraphics.PerformLayout()
        CType(Me.dgvgraphics2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvgraphics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TrancodingProfiles.ResumeLayout(False)
        Me.Segmentation.ResumeLayout(False)
        Me.gbsegmentation.ResumeLayout(False)
        Me.gbsegmentation.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvsegmentation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Transcoder.ResumeLayout(False)
        Me.gbTranscoder.ResumeLayout(False)
        Me.gbTranscoder.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nstripopacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nlogoxposition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nYPositionScroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nlogoyposition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nlogowidthforexport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nlogoheightforexport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nSpeedScroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nopacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vlcLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClipJoinder.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvjoiner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbTrimmer As System.Windows.Forms.GroupBox
    Friend WithEvents cmbbitrate5 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbaudiocodec5 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbvideocodec5 As System.Windows.Forms.ComboBox
    Friend WithEvents Label251 As System.Windows.Forms.Label
    Friend WithEvents Label252 As System.Windows.Forms.Label
    Friend WithEvents Label253 As System.Windows.Forms.Label
    Friend WithEvents Label254 As System.Windows.Forms.Label
    Friend WithEvents nlogoheightforexport As System.Windows.Forms.NumericUpDown
    Friend WithEvents nlogowidthforexport As System.Windows.Forms.NumericUpDown
    Friend WithEvents nlogoyposition As System.Windows.Forms.NumericUpDown
    Friend WithEvents nlogoxposition As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label255 As System.Windows.Forms.Label
    Friend WithEvents cmdlogoexport As System.Windows.Forms.Button
    Friend WithEvents Label250 As System.Windows.Forms.Label
    Friend WithEvents lblexportclipinfo3 As System.Windows.Forms.Label
    Friend WithEvents txtoptionsffmbc As System.Windows.Forms.TextBox
    Friend WithEvents Label226 As System.Windows.Forms.Label
    Friend WithEvents cmdffmbcexport As System.Windows.Forms.Button
    Friend WithEvents Label224 As System.Windows.Forms.Label
    Friend WithEvents cmbbitrate As System.Windows.Forms.ComboBox
    Friend WithEvents Label245 As System.Windows.Forms.Label
    Friend WithEvents txtoptionstrimmer As System.Windows.Forms.TextBox
    Friend WithEvents chkaudiocodeccopy As System.Windows.Forms.CheckBox
    Friend WithEvents chkvideocodeccopy As System.Windows.Forms.CheckBox
    Friend WithEvents cmbbitrate4 As System.Windows.Forms.ComboBox
    Friend WithEvents lblexportclipinfo4 As System.Windows.Forms.Label
    Friend WithEvents txtoptionstrimmer4 As System.Windows.Forms.TextBox
    Friend WithEvents cmbaudiocodec As System.Windows.Forms.ComboBox
    Friend WithEvents cmbvideocodec As System.Windows.Forms.ComboBox
    Friend WithEvents cmdclipcuttrimmer As System.Windows.Forms.Button
    Friend WithEvents pbexportclip4 As System.Windows.Forms.ProgressBar
    Friend WithEvents cmdclipcuttrimmer4 As System.Windows.Forms.Button
    Friend WithEvents cmbaudiocodec4 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbvideocodec4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label248 As System.Windows.Forms.Label
    Friend WithEvents Label247 As System.Windows.Forms.Label
    Friend WithEvents cmbbitrate3 As System.Windows.Forms.ComboBox
    Friend WithEvents txtoptionstrimmer3 As System.Windows.Forms.TextBox
    Friend WithEvents pbexportclip3 As System.Windows.Forms.ProgressBar
    Friend WithEvents cmdclipcuttrimmer3 As System.Windows.Forms.Button
    Friend WithEvents cmbaudiocodec3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbvideocodec3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label244 As System.Windows.Forms.Label
    Friend WithEvents cmbbitrate2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblexportclipinfo2 As System.Windows.Forms.Label
    Friend WithEvents txtoptionstrimmer2 As System.Windows.Forms.TextBox
    Friend WithEvents pbexportclip2 As System.Windows.Forms.ProgressBar
    Friend WithEvents cmdclipcuttrimmer2 As System.Windows.Forms.Button
    Friend WithEvents cmbaudiocodec2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbvideocodec2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label243 As System.Windows.Forms.Label
    Friend WithEvents Label242 As System.Windows.Forms.Label
    Friend WithEvents cmbbitrate1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label241 As System.Windows.Forms.Label
    Friend WithEvents Label240 As System.Windows.Forms.Label
    Friend WithEvents lblexportclipinfo1 As System.Windows.Forms.Label
    Friend WithEvents txtoptionstrimmer1 As System.Windows.Forms.TextBox
    Friend WithEvents pbexportclip1 As System.Windows.Forms.ProgressBar
    Friend WithEvents cmdclipcuttrimmer1 As System.Windows.Forms.Button
    Friend WithEvents cmbaudiocodec1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbvideocodec1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label227 As System.Windows.Forms.Label
    Friend WithEvents Label228 As System.Windows.Forms.Label
    Friend WithEvents chkaudiocodeccopyjoin As System.Windows.Forms.CheckBox
    Friend WithEvents txtoptionstrimmerjoin As System.Windows.Forms.TextBox
    Friend WithEvents chkvideocodeccopyjoin As System.Windows.Forms.CheckBox
    Friend WithEvents Label229 As System.Windows.Forms.Label
    Friend WithEvents cmdclipjoin As System.Windows.Forms.Button
    Friend WithEvents cmbaudiocodecjoin As System.Windows.Forms.ComboBox
    Friend WithEvents cmbvideocodecjoin As System.Windows.Forms.ComboBox
    Friend WithEvents bwforexportclip1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwforexportclip2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwforexportclip4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwforexportclip3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents gbsegmentation As System.Windows.Forms.GroupBox
    Friend WithEvents cmdmarkOUTSegmentation As System.Windows.Forms.Button
    Friend WithEvents cmdmarkINSegmentation As System.Windows.Forms.Button
    Friend WithEvents cmdMakeSegments As System.Windows.Forms.Button
    Friend WithEvents cmdGotoOUTSegments As System.Windows.Forms.Button
    Friend WithEvents dgvsegmentation As System.Windows.Forms.DataGridView
    Friend WithEvents cmdGotoINSegments As System.Windows.Forms.Button
    Friend WithEvents cmdCueFromCurrentPosition As System.Windows.Forms.Button
    Friend WithEvents cmdPlayFromCurrentPosition As System.Windows.Forms.Button
    Friend WithEvents lblsegmentlist As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdinsert As System.Windows.Forms.Button
    Friend WithEvents ClipName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INPoint As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OutPoint As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Duration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTDSegmentation As System.Windows.Forms.Label
    Friend WithEvents cmdTDSegmentation As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Transcoder As System.Windows.Forms.TabPage
    Friend WithEvents gbTranscoder As System.Windows.Forms.GroupBox
    Friend WithEvents Segmentation As System.Windows.Forms.TabPage
    Friend WithEvents ClipJoinder As System.Windows.Forms.TabPage
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents cmbvideocodec6 As ComboBox
    Friend WithEvents cmbbitrate6 As ComboBox
    Friend WithEvents lblexportclipinfo6 As Label
    Friend WithEvents txtoptionstrimmer6 As TextBox
    Friend WithEvents pbexportclip6 As ProgressBar
    Friend WithEvents cmdclipcuttrimmer6 As Button
    Friend WithEvents cmbaudiocodec6 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents bwforexportclip6 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TrancodingProfiles As TabPage
    Friend WithEvents UcTranscodingProfile1 As ucTranscodingProfile
    Friend WithEvents cmdExportClipwithTranscodingProfile As Button
    Friend WithEvents UcnewTrimmer11 As ucnewTrimmer1
    Friend WithEvents cmdExportSegments As Button
    Friend WithEvents cmdexportsubclipsinTranscodingProfile As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdFreezeDetect As Button
    Friend WithEvents cmdBlackDetect As Button
    Friend WithEvents dgvjoiner As DataGridView
    Friend WithEvents File As DataGridViewTextBoxColumn
    Friend WithEvents Openfile As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents vlcLogo As Vlc.DotNet.Forms.VlcControl
    Friend WithEvents cmdOpenLogo As Button
    Friend WithEvents tbGraphics As TabPage
    Friend WithEvents gotoOutGraphics As Button
    Friend WithEvents GotoInGraphics As Button
    Friend WithEvents cmdExportGrapchics As Button
    Friend WithEvents markOutGraphics As Button
    Friend WithEvents markInGraphics As Button
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents FileOpen As DataGridViewButtonColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbFontSize As ComboBox
    Friend WithEvents cmdFontColor As Button
    Friend WithEvents cmdStripColor As Button
    Friend WithEvents cmdExportGrapchics2 As Button
    Friend WithEvents gotoOutGraphics2 As Button
    Friend WithEvents GotoInGraphics2 As Button
    Friend WithEvents markOutGraphics2 As Button
    Friend WithEvents markInGraphics2 As Button
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbfont As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbfontscroll As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbfontsizescroll As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents nopacity As NumericUpDown
    Friend WithEvents Label31 As Label
    Friend WithEvents cmbScrollText As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents nSpeedScroll As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents nYPositionScroll As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdoLogoAndScroll As RadioButton
    Friend WithEvents rdoOnlyScroll As RadioButton
    Friend WithEvents rdoOnlyLogo As RadioButton
    Friend WithEvents Label21 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents dgvgraphics As DataGridView
    Friend WithEvents dgvgraphics2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents pngOpen As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents chkrtl As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents nstripopacity As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cmdfontcolor1 As Button
    Friend WithEvents cmdstripcolor1 As Button
End Class
