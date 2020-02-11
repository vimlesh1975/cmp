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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTrimmer))
        Me.gbTrimmer = New System.Windows.Forms.GroupBox()
        Me.cmdFreezeDetect = New System.Windows.Forms.Button()
        Me.cmdBlackDetect = New System.Windows.Forms.Button()
        Me.UcnewTrimmer11 = New caspar_media_playback.ucnewTrimmer1()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TrancodingProfiles = New System.Windows.Forms.TabPage()
        Me.cmdExportClipwithTranscodingProfile = New System.Windows.Forms.Button()
        Me.UcTranscodingProfile1 = New caspar_media_playback.ucTranscodingProfile()
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
        Me.ClipName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INPoint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutPoint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdGotoINSegments = New System.Windows.Forms.Button()
        Me.Transcoder = New System.Windows.Forms.TabPage()
        Me.gbTranscoder = New System.Windows.Forms.GroupBox()
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
        Me.Label255 = New System.Windows.Forms.Label()
        Me.cmbbitrate5 = New System.Windows.Forms.ComboBox()
        Me.cmdffmbcexport = New System.Windows.Forms.Button()
        Me.cmbaudiocodec5 = New System.Windows.Forms.ComboBox()
        Me.cmbvideocodec5 = New System.Windows.Forms.ComboBox()
        Me.Label224 = New System.Windows.Forms.Label()
        Me.Label249 = New System.Windows.Forms.Label()
        Me.cmbbitrate = New System.Windows.Forms.ComboBox()
        Me.Label251 = New System.Windows.Forms.Label()
        Me.Label252 = New System.Windows.Forms.Label()
        Me.txtoptionstrimmer = New System.Windows.Forms.TextBox()
        Me.Label253 = New System.Windows.Forms.Label()
        Me.chkaudiocodeccopy = New System.Windows.Forms.CheckBox()
        Me.Label254 = New System.Windows.Forms.Label()
        Me.chkvideocodeccopy = New System.Windows.Forms.CheckBox()
        Me.nlogoheightforexport = New System.Windows.Forms.NumericUpDown()
        Me.cmbbitrate4 = New System.Windows.Forms.ComboBox()
        Me.nlogowidthforexport = New System.Windows.Forms.NumericUpDown()
        Me.lblexportclipinfo4 = New System.Windows.Forms.Label()
        Me.piclogoforexport = New System.Windows.Forms.PictureBox()
        Me.txtoptionstrimmer4 = New System.Windows.Forms.TextBox()
        Me.nlogoyposition = New System.Windows.Forms.NumericUpDown()
        Me.cmbaudiocodec = New System.Windows.Forms.ComboBox()
        Me.nlogoxposition = New System.Windows.Forms.NumericUpDown()
        Me.cmdclipcuttrimmer = New System.Windows.Forms.Button()
        Me.pbexportclip4 = New System.Windows.Forms.ProgressBar()
        Me.cmdlogoexport = New System.Windows.Forms.Button()
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
        Me.cmdfileopenforjoin3 = New System.Windows.Forms.Button()
        Me.cmdfileopenforjoin2 = New System.Windows.Forms.Button()
        Me.cmdfileopenforjoin1 = New System.Windows.Forms.Button()
        Me.txtclip3forjoin = New System.Windows.Forms.TextBox()
        Me.txtclip2forjoin = New System.Windows.Forms.TextBox()
        Me.txtclip1forjoin = New System.Windows.Forms.TextBox()
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
        Me.gbTrimmer.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TrancodingProfiles.SuspendLayout()
        Me.Segmentation.SuspendLayout()
        Me.gbsegmentation.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvsegmentation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Transcoder.SuspendLayout()
        Me.gbTranscoder.SuspendLayout()
        CType(Me.nlogoheightforexport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nlogowidthforexport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piclogoforexport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nlogoyposition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nlogoxposition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClipJoinder.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
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
        Me.gbTrimmer.Location = New System.Drawing.Point(2, 2)
        Me.gbTrimmer.Name = "gbTrimmer"
        Me.gbTrimmer.Size = New System.Drawing.Size(1220, 667)
        Me.gbTrimmer.TabIndex = 1166
        Me.gbTrimmer.TabStop = False
        '
        'cmdFreezeDetect
        '
        Me.cmdFreezeDetect.Location = New System.Drawing.Point(102, 517)
        Me.cmdFreezeDetect.Name = "cmdFreezeDetect"
        Me.cmdFreezeDetect.Size = New System.Drawing.Size(86, 23)
        Me.cmdFreezeDetect.TabIndex = 802
        Me.cmdFreezeDetect.Text = "Freeze Detect"
        Me.cmdFreezeDetect.UseVisualStyleBackColor = True
        '
        'cmdBlackDetect
        '
        Me.cmdBlackDetect.Location = New System.Drawing.Point(10, 517)
        Me.cmdBlackDetect.Name = "cmdBlackDetect"
        Me.cmdBlackDetect.Size = New System.Drawing.Size(86, 23)
        Me.cmdBlackDetect.TabIndex = 801
        Me.cmdBlackDetect.Text = "Black Detect"
        Me.cmdBlackDetect.UseVisualStyleBackColor = True
        '
        'UcnewTrimmer11
        '
        Me.UcnewTrimmer11.AllowDrop = True
        Me.UcnewTrimmer11.BackColor = System.Drawing.Color.LightGray
        Me.UcnewTrimmer11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcnewTrimmer11.Location = New System.Drawing.Point(3, 7)
        Me.UcnewTrimmer11.Name = "UcnewTrimmer11"
        Me.UcnewTrimmer11.Size = New System.Drawing.Size(486, 503)
        Me.UcnewTrimmer11.TabIndex = 799
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TrancodingProfiles)
        Me.TabControl1.Controls.Add(Me.Segmentation)
        Me.TabControl1.Controls.Add(Me.Transcoder)
        Me.TabControl1.Controls.Add(Me.ClipJoinder)
        Me.TabControl1.Location = New System.Drawing.Point(496, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(714, 653)
        Me.TabControl1.TabIndex = 798
        '
        'TrancodingProfiles
        '
        Me.TrancodingProfiles.Controls.Add(Me.cmdExportClipwithTranscodingProfile)
        Me.TrancodingProfiles.Controls.Add(Me.UcTranscodingProfile1)
        Me.TrancodingProfiles.Location = New System.Drawing.Point(4, 22)
        Me.TrancodingProfiles.Name = "TrancodingProfiles"
        Me.TrancodingProfiles.Padding = New System.Windows.Forms.Padding(3)
        Me.TrancodingProfiles.Size = New System.Drawing.Size(706, 627)
        Me.TrancodingProfiles.TabIndex = 3
        Me.TrancodingProfiles.Text = "Trancoding Profiles"
        Me.TrancodingProfiles.UseVisualStyleBackColor = True
        '
        'cmdExportClipwithTranscodingProfile
        '
        Me.cmdExportClipwithTranscodingProfile.Location = New System.Drawing.Point(15, 591)
        Me.cmdExportClipwithTranscodingProfile.Name = "cmdExportClipwithTranscodingProfile"
        Me.cmdExportClipwithTranscodingProfile.Size = New System.Drawing.Size(198, 23)
        Me.cmdExportClipwithTranscodingProfile.TabIndex = 737
        Me.cmdExportClipwithTranscodingProfile.Text = "Export Clip with Transcoding Profile"
        Me.cmdExportClipwithTranscodingProfile.UseVisualStyleBackColor = True
        '
        'UcTranscodingProfile1
        '
        Me.UcTranscodingProfile1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcTranscodingProfile1.Location = New System.Drawing.Point(6, 6)
        Me.UcTranscodingProfile1.Name = "UcTranscodingProfile1"
        Me.UcTranscodingProfile1.Size = New System.Drawing.Size(387, 626)
        Me.UcTranscodingProfile1.TabIndex = 0
        '
        'Segmentation
        '
        Me.Segmentation.Controls.Add(Me.gbsegmentation)
        Me.Segmentation.Location = New System.Drawing.Point(4, 22)
        Me.Segmentation.Name = "Segmentation"
        Me.Segmentation.Padding = New System.Windows.Forms.Padding(3)
        Me.Segmentation.Size = New System.Drawing.Size(706, 627)
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
        Me.cmdExportSegments.Location = New System.Drawing.Point(632, 105)
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
        Me.cmdMakeSegments.Location = New System.Drawing.Point(585, 105)
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
        Me.dgvsegmentation.Size = New System.Drawing.Size(573, 450)
        Me.dgvsegmentation.TabIndex = 0
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
        Me.Transcoder.Size = New System.Drawing.Size(706, 627)
        Me.Transcoder.TabIndex = 0
        Me.Transcoder.Text = "Transcoder"
        Me.Transcoder.UseVisualStyleBackColor = True
        '
        'gbTranscoder
        '
        Me.gbTranscoder.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
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
        Me.gbTranscoder.Controls.Add(Me.Label255)
        Me.gbTranscoder.Controls.Add(Me.cmbbitrate5)
        Me.gbTranscoder.Controls.Add(Me.cmdffmbcexport)
        Me.gbTranscoder.Controls.Add(Me.cmbaudiocodec5)
        Me.gbTranscoder.Controls.Add(Me.cmbvideocodec5)
        Me.gbTranscoder.Controls.Add(Me.Label224)
        Me.gbTranscoder.Controls.Add(Me.Label249)
        Me.gbTranscoder.Controls.Add(Me.cmbbitrate)
        Me.gbTranscoder.Controls.Add(Me.Label251)
        Me.gbTranscoder.Controls.Add(Me.Label252)
        Me.gbTranscoder.Controls.Add(Me.txtoptionstrimmer)
        Me.gbTranscoder.Controls.Add(Me.Label253)
        Me.gbTranscoder.Controls.Add(Me.chkaudiocodeccopy)
        Me.gbTranscoder.Controls.Add(Me.Label254)
        Me.gbTranscoder.Controls.Add(Me.chkvideocodeccopy)
        Me.gbTranscoder.Controls.Add(Me.nlogoheightforexport)
        Me.gbTranscoder.Controls.Add(Me.cmbbitrate4)
        Me.gbTranscoder.Controls.Add(Me.nlogowidthforexport)
        Me.gbTranscoder.Controls.Add(Me.lblexportclipinfo4)
        Me.gbTranscoder.Controls.Add(Me.piclogoforexport)
        Me.gbTranscoder.Controls.Add(Me.txtoptionstrimmer4)
        Me.gbTranscoder.Controls.Add(Me.nlogoyposition)
        Me.gbTranscoder.Controls.Add(Me.cmbaudiocodec)
        Me.gbTranscoder.Controls.Add(Me.nlogoxposition)
        Me.gbTranscoder.Controls.Add(Me.cmdclipcuttrimmer)
        Me.gbTranscoder.Controls.Add(Me.pbexportclip4)
        Me.gbTranscoder.Controls.Add(Me.cmdlogoexport)
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
        Me.gbTranscoder.Size = New System.Drawing.Size(694, 614)
        Me.gbTranscoder.TabIndex = 797
        Me.gbTranscoder.TabStop = False
        Me.gbTranscoder.Text = "Transcoder"
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
        'Label255
        '
        Me.Label255.AutoSize = True
        Me.Label255.Location = New System.Drawing.Point(560, 550)
        Me.Label255.Name = "Label255"
        Me.Label255.Size = New System.Drawing.Size(126, 13)
        Me.Label255.TabIndex = 781
        Me.Label255.Text = "Status on ffmpeg window"
        '
        'cmbbitrate5
        '
        Me.cmbbitrate5.FormattingEnabled = True
        Me.cmbbitrate5.Items.AddRange(New Object() {"0.5", "1.0", "1.5", "2.0", "3", "4", "5", "6", "7", "8", "9", "10", "15", "20", "25", "30", "35", "40", "45", "50"})
        Me.cmbbitrate5.Location = New System.Drawing.Point(184, 579)
        Me.cmbbitrate5.Name = "cmbbitrate5"
        Me.cmbbitrate5.Size = New System.Drawing.Size(46, 21)
        Me.cmbbitrate5.TabIndex = 794
        Me.cmbbitrate5.Text = "1.0"
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
        'cmbaudiocodec5
        '
        Me.cmbaudiocodec5.FormattingEnabled = True
        Me.cmbaudiocodec5.Location = New System.Drawing.Point(106, 578)
        Me.cmbaudiocodec5.Name = "cmbaudiocodec5"
        Me.cmbaudiocodec5.Size = New System.Drawing.Size(76, 21)
        Me.cmbaudiocodec5.Sorted = True
        Me.cmbaudiocodec5.TabIndex = 793
        Me.cmbaudiocodec5.Text = "aac"
        '
        'cmbvideocodec5
        '
        Me.cmbvideocodec5.FormattingEnabled = True
        Me.cmbvideocodec5.Location = New System.Drawing.Point(15, 578)
        Me.cmbvideocodec5.Name = "cmbvideocodec5"
        Me.cmbvideocodec5.Size = New System.Drawing.Size(88, 21)
        Me.cmbvideocodec5.Sorted = True
        Me.cmbvideocodec5.TabIndex = 792
        Me.cmbvideocodec5.Text = "libx264"
        '
        'Label224
        '
        Me.Label224.AutoSize = True
        Me.Label224.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label224.Location = New System.Drawing.Point(552, 43)
        Me.Label224.Name = "Label224"
        Me.Label224.Size = New System.Drawing.Size(136, 13)
        Me.Label224.TabIndex = 772
        Me.Label224.Text = "Status on FFMpeg Window"
        Me.Label224.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label249
        '
        Me.Label249.AutoSize = True
        Me.Label249.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label249.Location = New System.Drawing.Point(14, 562)
        Me.Label249.Name = "Label249"
        Me.Label249.Size = New System.Drawing.Size(122, 13)
        Me.Label249.TabIndex = 791
        Me.Label249.Text = "Transcode with logo"
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
        'Label251
        '
        Me.Label251.AutoSize = True
        Me.Label251.Location = New System.Drawing.Point(510, 567)
        Me.Label251.Name = "Label251"
        Me.Label251.Size = New System.Drawing.Size(14, 13)
        Me.Label251.TabIndex = 790
        Me.Label251.Text = "Y"
        '
        'Label252
        '
        Me.Label252.AutoSize = True
        Me.Label252.Location = New System.Drawing.Point(444, 566)
        Me.Label252.Name = "Label252"
        Me.Label252.Size = New System.Drawing.Size(14, 13)
        Me.Label252.TabIndex = 789
        Me.Label252.Text = "X"
        '
        'txtoptionstrimmer
        '
        Me.txtoptionstrimmer.Location = New System.Drawing.Point(254, 36)
        Me.txtoptionstrimmer.Name = "txtoptionstrimmer"
        Me.txtoptionstrimmer.Size = New System.Drawing.Size(204, 20)
        Me.txtoptionstrimmer.TabIndex = 717
        '
        'Label253
        '
        Me.Label253.AutoSize = True
        Me.Label253.Location = New System.Drawing.Point(509, 589)
        Me.Label253.Name = "Label253"
        Me.Label253.Size = New System.Drawing.Size(15, 13)
        Me.Label253.TabIndex = 788
        Me.Label253.Text = "H"
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
        'Label254
        '
        Me.Label254.AutoSize = True
        Me.Label254.Location = New System.Drawing.Point(440, 592)
        Me.Label254.Name = "Label254"
        Me.Label254.Size = New System.Drawing.Size(18, 13)
        Me.Label254.TabIndex = 787
        Me.Label254.Text = "W"
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
        'nlogoheightforexport
        '
        Me.nlogoheightforexport.Location = New System.Drawing.Point(528, 587)
        Me.nlogoheightforexport.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.nlogoheightforexport.Name = "nlogoheightforexport"
        Me.nlogoheightforexport.Size = New System.Drawing.Size(37, 20)
        Me.nlogoheightforexport.TabIndex = 786
        Me.nlogoheightforexport.Value = New Decimal(New Integer() {75, 0, 0, 0})
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
        'nlogowidthforexport
        '
        Me.nlogowidthforexport.Location = New System.Drawing.Point(464, 587)
        Me.nlogowidthforexport.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.nlogowidthforexport.Name = "nlogowidthforexport"
        Me.nlogowidthforexport.Size = New System.Drawing.Size(45, 20)
        Me.nlogowidthforexport.TabIndex = 785
        Me.nlogowidthforexport.Value = New Decimal(New Integer() {75, 0, 0, 0})
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
        'piclogoforexport
        '
        Me.piclogoforexport.ImageLocation = "c:\casparcg\_media\sd_frame.png"
        Me.piclogoforexport.Location = New System.Drawing.Point(567, 565)
        Me.piclogoforexport.Name = "piclogoforexport"
        Me.piclogoforexport.Size = New System.Drawing.Size(44, 39)
        Me.piclogoforexport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piclogoforexport.TabIndex = 784
        Me.piclogoforexport.TabStop = False
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
        'nlogoyposition
        '
        Me.nlogoyposition.Location = New System.Drawing.Point(528, 564)
        Me.nlogoyposition.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.nlogoyposition.Name = "nlogoyposition"
        Me.nlogoyposition.Size = New System.Drawing.Size(37, 20)
        Me.nlogoyposition.TabIndex = 783
        Me.nlogoyposition.Value = New Decimal(New Integer() {30, 0, 0, 0})
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
        'nlogoxposition
        '
        Me.nlogoxposition.Location = New System.Drawing.Point(464, 563)
        Me.nlogoxposition.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.nlogoxposition.Name = "nlogoxposition"
        Me.nlogoxposition.Size = New System.Drawing.Size(45, 20)
        Me.nlogoxposition.TabIndex = 782
        Me.nlogoxposition.Value = New Decimal(New Integer() {615, 0, 0, 0})
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
        'cmdlogoexport
        '
        Me.cmdlogoexport.Location = New System.Drawing.Point(622, 566)
        Me.cmdlogoexport.Name = "cmdlogoexport"
        Me.cmdlogoexport.Size = New System.Drawing.Size(56, 47)
        Me.cmdlogoexport.TabIndex = 780
        Me.cmdlogoexport.Text = "Export with Logo"
        Me.cmdlogoexport.UseVisualStyleBackColor = True
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
        Me.ClipJoinder.Size = New System.Drawing.Size(706, 627)
        Me.ClipJoinder.TabIndex = 2
        Me.ClipJoinder.Text = "Clip Joinder"
        Me.ClipJoinder.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.cmdfileopenforjoin3)
        Me.GroupBox5.Controls.Add(Me.cmdfileopenforjoin2)
        Me.GroupBox5.Controls.Add(Me.cmdfileopenforjoin1)
        Me.GroupBox5.Controls.Add(Me.txtclip3forjoin)
        Me.GroupBox5.Controls.Add(Me.txtclip2forjoin)
        Me.GroupBox5.Controls.Add(Me.txtclip1forjoin)
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
        Me.GroupBox5.Size = New System.Drawing.Size(683, 114)
        Me.GroupBox5.TabIndex = 723
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Join Clips (Only for Mpeg Codec)"
        '
        'cmdfileopenforjoin3
        '
        Me.cmdfileopenforjoin3.Location = New System.Drawing.Point(365, 62)
        Me.cmdfileopenforjoin3.Name = "cmdfileopenforjoin3"
        Me.cmdfileopenforjoin3.Size = New System.Drawing.Size(29, 22)
        Me.cmdfileopenforjoin3.TabIndex = 728
        Me.cmdfileopenforjoin3.Text = "---"
        Me.cmdfileopenforjoin3.UseVisualStyleBackColor = True
        '
        'cmdfileopenforjoin2
        '
        Me.cmdfileopenforjoin2.Location = New System.Drawing.Point(365, 41)
        Me.cmdfileopenforjoin2.Name = "cmdfileopenforjoin2"
        Me.cmdfileopenforjoin2.Size = New System.Drawing.Size(29, 22)
        Me.cmdfileopenforjoin2.TabIndex = 727
        Me.cmdfileopenforjoin2.Text = "---"
        Me.cmdfileopenforjoin2.UseVisualStyleBackColor = True
        '
        'cmdfileopenforjoin1
        '
        Me.cmdfileopenforjoin1.Location = New System.Drawing.Point(365, 19)
        Me.cmdfileopenforjoin1.Name = "cmdfileopenforjoin1"
        Me.cmdfileopenforjoin1.Size = New System.Drawing.Size(29, 22)
        Me.cmdfileopenforjoin1.TabIndex = 726
        Me.cmdfileopenforjoin1.Text = "---"
        Me.cmdfileopenforjoin1.UseVisualStyleBackColor = True
        '
        'txtclip3forjoin
        '
        Me.txtclip3forjoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclip3forjoin.Location = New System.Drawing.Point(209, 61)
        Me.txtclip3forjoin.Name = "txtclip3forjoin"
        Me.txtclip3forjoin.Size = New System.Drawing.Size(153, 18)
        Me.txtclip3forjoin.TabIndex = 725
        '
        'txtclip2forjoin
        '
        Me.txtclip2forjoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclip2forjoin.Location = New System.Drawing.Point(209, 41)
        Me.txtclip2forjoin.Name = "txtclip2forjoin"
        Me.txtclip2forjoin.Size = New System.Drawing.Size(153, 18)
        Me.txtclip2forjoin.TabIndex = 724
        '
        'txtclip1forjoin
        '
        Me.txtclip1forjoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclip1forjoin.Location = New System.Drawing.Point(208, 21)
        Me.txtclip1forjoin.Name = "txtclip1forjoin"
        Me.txtclip1forjoin.Size = New System.Drawing.Size(153, 18)
        Me.txtclip1forjoin.TabIndex = 723
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
        Me.Label228.Location = New System.Drawing.Point(401, 24)
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
        Me.txtoptionstrimmerjoin.Location = New System.Drawing.Point(400, 38)
        Me.txtoptionstrimmerjoin.Name = "txtoptionstrimmerjoin"
        Me.txtoptionstrimmerjoin.Size = New System.Drawing.Size(177, 20)
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
        Me.cmdclipjoin.Location = New System.Drawing.Point(597, 35)
        Me.cmdclipjoin.Name = "cmdclipjoin"
        Me.cmdclipjoin.Size = New System.Drawing.Size(80, 23)
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
        Me.cmdCueFromCurrentPosition.Location = New System.Drawing.Point(22, 553)
        Me.cmdCueFromCurrentPosition.Name = "cmdCueFromCurrentPosition"
        Me.cmdCueFromCurrentPosition.Size = New System.Drawing.Size(74, 82)
        Me.cmdCueFromCurrentPosition.TabIndex = 796
        Me.cmdCueFromCurrentPosition.Text = "Cue in Casparcg From Current Position"
        Me.cmdCueFromCurrentPosition.UseVisualStyleBackColor = True
        '
        'cmdPlayFromCurrentPosition
        '
        Me.cmdPlayFromCurrentPosition.Location = New System.Drawing.Point(102, 553)
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
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'ucTrimmer
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1229, 675)
        Me.Controls.Add(Me.gbTrimmer)
        Me.HideOnClose = True
        Me.Name = "ucTrimmer"
        Me.Text = "Trimmer"
        Me.gbTrimmer.ResumeLayout(False)
        Me.gbTrimmer.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
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
        CType(Me.nlogoheightforexport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nlogowidthforexport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piclogoforexport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nlogoyposition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nlogoxposition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClipJoinder.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbTrimmer As System.Windows.Forms.GroupBox
    Friend WithEvents cmbbitrate5 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbaudiocodec5 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbvideocodec5 As System.Windows.Forms.ComboBox
    Friend WithEvents Label249 As System.Windows.Forms.Label
    Friend WithEvents Label251 As System.Windows.Forms.Label
    Friend WithEvents Label252 As System.Windows.Forms.Label
    Friend WithEvents Label253 As System.Windows.Forms.Label
    Friend WithEvents Label254 As System.Windows.Forms.Label
    Friend WithEvents nlogoheightforexport As System.Windows.Forms.NumericUpDown
    Friend WithEvents nlogowidthforexport As System.Windows.Forms.NumericUpDown
    Friend WithEvents piclogoforexport As System.Windows.Forms.PictureBox
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
    Friend WithEvents cmdfileopenforjoin3 As System.Windows.Forms.Button
    Friend WithEvents cmdfileopenforjoin2 As System.Windows.Forms.Button
    Friend WithEvents cmdfileopenforjoin1 As System.Windows.Forms.Button
    Friend WithEvents txtclip3forjoin As System.Windows.Forms.TextBox
    Friend WithEvents txtclip2forjoin As System.Windows.Forms.TextBox
    Friend WithEvents txtclip1forjoin As System.Windows.Forms.TextBox
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
End Class
