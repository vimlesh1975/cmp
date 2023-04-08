<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucXdcamSoapClient
    'Inherits System.Windows.Forms.UserControl
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucXdcamSoapClient))
        Me.lblnote = New System.Windows.Forms.Label()
        Me.cmdgetclipnames = New System.Windows.Forms.Button()
        Me.cmdcopy = New System.Windows.Forms.Button()
        Me.cmbdestinationDriveNames = New System.Windows.Forms.ComboBox()
        Me.tmrGetTC = New System.Windows.Forms.Timer(Me.components)
        Me.dgvclips = New System.Windows.Forms.DataGridView()
        Me.ClipName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UMMID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartTimeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Thumbnail = New System.Windows.Forms.DataGridViewImageColumn()
        Me.cmsdgvclips = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CueInCsparcgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayInCasparcgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayInVlcToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayInLoopToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblRemainingDuration = New System.Windows.Forms.Label()
        Me.lblActiveID = New System.Windows.Forms.Label()
        Me.txtSubClipName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPlayedDuration = New System.Windows.Forms.Label()
        Me.lblnewName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbClipDrive = New System.Windows.Forms.ComboBox()
        Me.cmdOpenRecorder = New System.Windows.Forms.Button()
        Me.txtRecordFileName = New System.Windows.Forms.TextBox()
        Me.cmdCloseRecord = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UcVTRController1 = New caspar_media_playback.ucVTRController()
        Me.cmdRecordfrombeta = New System.Windows.Forms.Button()
        Me.cmdDurationFromVtrControl = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbRecordDrive = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRecordingDuration = New System.Windows.Forms.TextBox()
        Me.lblRecorderStatus = New System.Windows.Forms.Label()
        Me.cmdGetRecoredrStatus = New System.Windows.Forms.Button()
        Me.gbTrimming = New System.Windows.Forms.GroupBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UMMID1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StopF1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CueToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayNextF6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertBlankToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveUpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveDownToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InserEndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayInVlcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayInLoopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSaveSubClipSopa = New System.Windows.Forms.Button()
        Me.tmrpreview = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkPlaySMIasXMF = New System.Windows.Forms.CheckBox()
        Me.cmdgotoend = New System.Windows.Forms.Button()
        Me.chkTimeLinePlayBackMethod = New System.Windows.Forms.CheckBox()
        Me.cmdFastReverse = New System.Windows.Forms.Button()
        Me.cmdFastFarward = New System.Windows.Forms.Button()
        Me.cmdpausevdcp = New System.Windows.Forms.Button()
        Me.cmdnextplay = New System.Windows.Forms.Button()
        Me.cmdforwardoneframe = New System.Windows.Forms.Button()
        Me.cmdbackoneframe = New System.Windows.Forms.Button()
        Me.cmdcueclip = New System.Windows.Forms.Button()
        Me.cmdresume = New System.Windows.Forms.Button()
        Me.cmdcuenext = New System.Windows.Forms.Button()
        Me.cmdPlaySingleClip = New System.Windows.Forms.Button()
        Me.cmdstop = New System.Windows.Forms.Button()
        Me.cmdCueFromClipGrid = New System.Windows.Forms.Button()
        Me.cmdCueFromPlaylist = New System.Windows.Forms.Button()
        Me.chkThumbnail = New System.Windows.Forms.CheckBox()
        Me.lblUMID = New System.Windows.Forms.Label()
        Me.lblClips = New System.Windows.Forms.Label()
        Me.cmdStartPlayList = New System.Windows.Forms.Button()
        Me.tmrNextClipofPlaylist = New System.Windows.Forms.Timer(Me.components)
        Me.cmddeleteclip = New System.Windows.Forms.Button()
        Me.tsPlaylist = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveAsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.lblplaylistname = New System.Windows.Forms.Label()
        Me.tmrfornotskipping = New System.Windows.Forms.Timer(Me.components)
        Me.gbplayer = New System.Windows.Forms.GroupBox()
        Me.nvlcspeed = New System.Windows.Forms.NumericUpDown()
        Me.cmdspeed1trimmer = New System.Windows.Forms.Button()
        Me.lbltrimmedduration = New System.Windows.Forms.Label()
        Me.cmdforwardsecond = New System.Windows.Forms.Button()
        Me.lbloriginalduration = New System.Windows.Forms.Label()
        Me.Label232 = New System.Windows.Forms.Label()
        Me.txtforwardsecond = New System.Windows.Forms.TextBox()
        Me.Label231 = New System.Windows.Forms.Label()
        Me.txtgototccasparcgwindow = New System.Windows.Forms.TextBox()
        Me.cmdplayfromout = New System.Windows.Forms.Button()
        Me.cmdgototccasparcgwindow = New System.Windows.Forms.Button()
        Me.cmdplayfromin = New System.Windows.Forms.Button()
        Me.cmdplaylast5seccasaprcgwindow = New System.Windows.Forms.Button()
        Me.lbltimecode = New System.Windows.Forms.Label()
        Me.lblCurrentFrame = New System.Windows.Forms.Label()
        Me.cmdgotoout = New System.Windows.Forms.Button()
        Me.cmdgotoin = New System.Windows.Forms.Button()
        Me.cmdmarkout = New System.Windows.Forms.Button()
        Me.cmdmarkin = New System.Windows.Forms.Button()
        Me.txtmarkoutsoap = New System.Windows.Forms.TextBox()
        Me.txtmarkinsoap = New System.Windows.Forms.TextBox()
        Me.lblmin = New System.Windows.Forms.Label()
        Me.lbltbmax = New System.Windows.Forms.Label()
        Me.tbsoap = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMoreInfo = New System.Windows.Forms.Label()
        Me.lblMoreInfo2 = New System.Windows.Forms.Label()
        Me.cmdSetXdcam = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Trimmer = New System.Windows.Forms.TabPage()
        Me.AddEssenceMark = New System.Windows.Forms.TabPage()
        Me.lblessenceMarkStatus = New System.Windows.Forms.Label()
        Me.cmdAddEssenceMark = New System.Windows.Forms.Button()
        Me.dgvEssenceMark = New System.Windows.Forms.DataGridView()
        Me.SystemFunction = New System.Windows.Forms.TabPage()
        Me.lblSystemErrorWarning = New System.Windows.Forms.Label()
        Me.cmdGetSystemErrorWarning = New System.Windows.Forms.Button()
        Me.lblSystemStatus = New System.Windows.Forms.Label()
        Me.cmdGetSystemStatus = New System.Windows.Forms.Button()
        Me.lblSystemProperties = New System.Windows.Forms.Label()
        Me.cmdGetSystemProperties = New System.Windows.Forms.Button()
        Me.cmbEjectDrive = New System.Windows.Forms.ComboBox()
        Me.cdmEject = New System.Windows.Forms.Button()
        Me.cmdShutDown = New System.Windows.Forms.Button()
        Me.Settings = New System.Windows.Forms.TabPage()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtipaddress = New System.Windows.Forms.TextBox()
        Me.cmbMappedDriveName = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Help = New System.Windows.Forms.TabPage()
        Me.MoreInfo = New System.Windows.Forms.TabPage()
        Me.Recorder = New System.Windows.Forms.TabPage()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.tmrRecoderStatus = New System.Windows.Forms.Timer(Me.components)
        Me.cmdGetThumbNail = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdmoveup = New System.Windows.Forms.Button()
        Me.cmdmovedown = New System.Windows.Forms.Button()
        Me.cmdinsert = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvclips, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsdgvclips.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbTrimming.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.tsPlaylist.SuspendLayout()
        Me.gbplayer.SuspendLayout()
        CType(Me.nvlcspeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbsoap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Trimmer.SuspendLayout()
        Me.AddEssenceMark.SuspendLayout()
        CType(Me.dgvEssenceMark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SystemFunction.SuspendLayout()
        Me.Settings.SuspendLayout()
        Me.Help.SuspendLayout()
        Me.MoreInfo.SuspendLayout()
        Me.Recorder.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblnote
        '
        Me.lblnote.AutoSize = True
        Me.lblnote.Location = New System.Drawing.Point(6, 13)
        Me.lblnote.Name = "lblnote"
        Me.lblnote.Size = New System.Drawing.Size(384, 104)
        Me.lblnote.TabIndex = 4
        Me.lblnote.Text = resources.GetString("lblnote.Text")
        '
        'cmdgetclipnames
        '
        Me.cmdgetclipnames.Location = New System.Drawing.Point(112, 457)
        Me.cmdgetclipnames.Name = "cmdgetclipnames"
        Me.cmdgetclipnames.Size = New System.Drawing.Size(75, 23)
        Me.cmdgetclipnames.TabIndex = 5
        Me.cmdgetclipnames.Text = "Search"
        Me.cmdgetclipnames.UseVisualStyleBackColor = True
        '
        'cmdcopy
        '
        Me.cmdcopy.Location = New System.Drawing.Point(6, 22)
        Me.cmdcopy.Name = "cmdcopy"
        Me.cmdcopy.Size = New System.Drawing.Size(86, 23)
        Me.cmdcopy.TabIndex = 6
        Me.cmdcopy.Text = "Make New File"
        Me.cmdcopy.UseVisualStyleBackColor = True
        '
        'cmbdestinationDriveNames
        '
        Me.cmbdestinationDriveNames.FormattingEnabled = True
        Me.cmbdestinationDriveNames.Items.AddRange(New Object() {"InternalDrive", "SxS_A", "SxS_B", "PD_ProAV", "PD_BPAV", "PD_XDROOT", "USBDrive"})
        Me.cmbdestinationDriveNames.Location = New System.Drawing.Point(210, 23)
        Me.cmbdestinationDriveNames.Name = "cmbdestinationDriveNames"
        Me.cmbdestinationDriveNames.Size = New System.Drawing.Size(121, 21)
        Me.cmbdestinationDriveNames.TabIndex = 1273
        Me.cmbdestinationDriveNames.Text = "InternalDrive"
        '
        'tmrGetTC
        '
        '
        'dgvclips
        '
        Me.dgvclips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvclips.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClipName, Me.Duration, Me.UMMID, Me.StartTimeCode, Me.Thumbnail})
        Me.dgvclips.ContextMenuStrip = Me.cmsdgvclips
        Me.dgvclips.Location = New System.Drawing.Point(3, 483)
        Me.dgvclips.Name = "dgvclips"
        Me.dgvclips.Size = New System.Drawing.Size(577, 211)
        Me.dgvclips.TabIndex = 1281
        '
        'ClipName
        '
        Me.ClipName.HeaderText = "Clips"
        Me.ClipName.Name = "ClipName"
        Me.ClipName.ReadOnly = True
        Me.ClipName.Width = 240
        '
        'Duration
        '
        Me.Duration.HeaderText = "Duration"
        Me.Duration.Name = "Duration"
        Me.Duration.Width = 70
        '
        'UMMID
        '
        Me.UMMID.HeaderText = "UMMID"
        Me.UMMID.Name = "UMMID"
        Me.UMMID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UMMID.Width = 5
        '
        'StartTimeCode
        '
        Me.StartTimeCode.HeaderText = "StartTimeCode"
        Me.StartTimeCode.Name = "StartTimeCode"
        '
        'Thumbnail
        '
        Me.Thumbnail.HeaderText = "Thumbnail"
        Me.Thumbnail.Name = "Thumbnail"
        '
        'cmsdgvclips
        '
        Me.cmsdgvclips.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CueInCsparcgToolStripMenuItem, Me.PlayInCasparcgToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.RenameFileToolStripMenuItem, Me.PlayInVlcToolStripMenuItem1, Me.PlayInLoopToolStripMenuItem1})
        Me.cmsdgvclips.Name = "ContextMenuStrip2"
        Me.cmsdgvclips.Size = New System.Drawing.Size(140, 136)
        '
        'CueInCsparcgToolStripMenuItem
        '
        Me.CueInCsparcgToolStripMenuItem.Name = "CueInCsparcgToolStripMenuItem"
        Me.CueInCsparcgToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.CueInCsparcgToolStripMenuItem.Text = "Cue"
        '
        'PlayInCasparcgToolStripMenuItem
        '
        Me.PlayInCasparcgToolStripMenuItem.Name = "PlayInCasparcgToolStripMenuItem"
        Me.PlayInCasparcgToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PlayInCasparcgToolStripMenuItem.Text = "Play"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'RenameFileToolStripMenuItem
        '
        Me.RenameFileToolStripMenuItem.Name = "RenameFileToolStripMenuItem"
        Me.RenameFileToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.RenameFileToolStripMenuItem.Text = "Rename File"
        '
        'PlayInVlcToolStripMenuItem1
        '
        Me.PlayInVlcToolStripMenuItem1.Name = "PlayInVlcToolStripMenuItem1"
        Me.PlayInVlcToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.PlayInVlcToolStripMenuItem1.Text = "Play In Vlc"
        '
        'PlayInLoopToolStripMenuItem1
        '
        Me.PlayInLoopToolStripMenuItem1.Name = "PlayInLoopToolStripMenuItem1"
        Me.PlayInLoopToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.PlayInLoopToolStripMenuItem1.Text = "Play in Loop"
        '
        'lblRemainingDuration
        '
        Me.lblRemainingDuration.AutoSize = True
        Me.lblRemainingDuration.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.lblRemainingDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemainingDuration.ForeColor = System.Drawing.Color.Yellow
        Me.lblRemainingDuration.Location = New System.Drawing.Point(452, 16)
        Me.lblRemainingDuration.Name = "lblRemainingDuration"
        Me.lblRemainingDuration.Size = New System.Drawing.Size(125, 33)
        Me.lblRemainingDuration.TabIndex = 1284
        Me.lblRemainingDuration.Text = "Counter"
        '
        'lblActiveID
        '
        Me.lblActiveID.AutoSize = True
        Me.lblActiveID.ForeColor = System.Drawing.Color.Maroon
        Me.lblActiveID.Location = New System.Drawing.Point(470, 52)
        Me.lblActiveID.Name = "lblActiveID"
        Me.lblActiveID.Size = New System.Drawing.Size(51, 13)
        Me.lblActiveID.TabIndex = 1285
        Me.lblActiveID.Text = "Active ID"
        Me.lblActiveID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSubClipName
        '
        Me.txtSubClipName.Location = New System.Drawing.Point(98, 23)
        Me.txtSubClipName.Name = "txtSubClipName"
        Me.txtSubClipName.Size = New System.Drawing.Size(100, 20)
        Me.txtSubClipName.TabIndex = 1288
        Me.txtSubClipName.Text = "Vimlesh"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(348, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1289
        Me.Label2.Text = "Remaining duration"
        '
        'lblPlayedDuration
        '
        Me.lblPlayedDuration.AutoSize = True
        Me.lblPlayedDuration.ForeColor = System.Drawing.Color.Navy
        Me.lblPlayedDuration.Location = New System.Drawing.Point(458, 69)
        Me.lblPlayedDuration.Name = "lblPlayedDuration"
        Me.lblPlayedDuration.Size = New System.Drawing.Size(82, 13)
        Me.lblPlayedDuration.TabIndex = 1290
        Me.lblPlayedDuration.Text = "Played Duration"
        Me.lblPlayedDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblnewName
        '
        Me.lblnewName.AutoSize = True
        Me.lblnewName.Location = New System.Drawing.Point(98, 10)
        Me.lblnewName.Name = "lblnewName"
        Me.lblnewName.Size = New System.Drawing.Size(60, 13)
        Me.lblnewName.TabIndex = 1291
        Me.lblnewName.Text = "New Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(199, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 1293
        Me.Label4.Text = "Destination Drive"
        '
        'cmbClipDrive
        '
        Me.cmbClipDrive.FormattingEnabled = True
        Me.cmbClipDrive.Items.AddRange(New Object() {"InternalDrive", "SxS_A", "SxS_B", "PD_ProAV", "PD_BPAV", "PD_XDROOT", "USBDrive"})
        Me.cmbClipDrive.Location = New System.Drawing.Point(190, 459)
        Me.cmbClipDrive.Name = "cmbClipDrive"
        Me.cmbClipDrive.Size = New System.Drawing.Size(86, 21)
        Me.cmbClipDrive.TabIndex = 1294
        Me.cmbClipDrive.Text = "InternalDrive"
        '
        'cmdOpenRecorder
        '
        Me.cmdOpenRecorder.Location = New System.Drawing.Point(434, 27)
        Me.cmdOpenRecorder.Name = "cmdOpenRecorder"
        Me.cmdOpenRecorder.Size = New System.Drawing.Size(50, 23)
        Me.cmdOpenRecorder.TabIndex = 1296
        Me.cmdOpenRecorder.Text = "Record"
        Me.ToolTip1.SetToolTip(Me.cmdOpenRecorder, "Record And Play VTR")
        Me.cmdOpenRecorder.UseVisualStyleBackColor = True
        '
        'txtRecordFileName
        '
        Me.txtRecordFileName.Location = New System.Drawing.Point(143, 32)
        Me.txtRecordFileName.Name = "txtRecordFileName"
        Me.txtRecordFileName.Size = New System.Drawing.Size(182, 20)
        Me.txtRecordFileName.TabIndex = 1297
        Me.txtRecordFileName.Text = "Vimlesh1"
        '
        'cmdCloseRecord
        '
        Me.cmdCloseRecord.Location = New System.Drawing.Point(490, 28)
        Me.cmdCloseRecord.Name = "cmdCloseRecord"
        Me.cmdCloseRecord.Size = New System.Drawing.Size(78, 23)
        Me.cmdCloseRecord.TabIndex = 1299
        Me.cmdCloseRecord.Text = "Stop Record"
        Me.cmdCloseRecord.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(373, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 1301
        Me.Label5.Text = "Played Duration"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(410, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 1302
        Me.Label6.Text = "Active ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Tan
        Me.GroupBox2.Controls.Add(Me.UcVTRController1)
        Me.GroupBox2.Controls.Add(Me.cmdRecordfrombeta)
        Me.GroupBox2.Controls.Add(Me.cmdDurationFromVtrControl)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cmbRecordDrive)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtRecordingDuration)
        Me.GroupBox2.Controls.Add(Me.lblRecorderStatus)
        Me.GroupBox2.Controls.Add(Me.cmdGetRecoredrStatus)
        Me.GroupBox2.Controls.Add(Me.cmdCloseRecord)
        Me.GroupBox2.Controls.Add(Me.txtRecordFileName)
        Me.GroupBox2.Controls.Add(Me.cmdOpenRecorder)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 532)
        Me.GroupBox2.TabIndex = 1305
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recording"
        '
        'UcVTRController1
        '
        Me.UcVTRController1.BackColor = System.Drawing.Color.LightGray
        Me.UcVTRController1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcVTRController1.Location = New System.Drawing.Point(6, 112)
        Me.UcVTRController1.Name = "UcVTRController1"
        Me.UcVTRController1.Size = New System.Drawing.Size(566, 412)
        Me.UcVTRController1.TabIndex = 1357
        '
        'cmdRecordfrombeta
        '
        Me.cmdRecordfrombeta.Location = New System.Drawing.Point(9, 59)
        Me.cmdRecordfrombeta.Name = "cmdRecordfrombeta"
        Me.cmdRecordfrombeta.Size = New System.Drawing.Size(125, 23)
        Me.cmdRecordfrombeta.TabIndex = 1356
        Me.cmdRecordfrombeta.Text = "Record from Beta"
        Me.ToolTip1.SetToolTip(Me.cmdRecordfrombeta, "Preroll VTR and after 5 sec record")
        Me.cmdRecordfrombeta.UseVisualStyleBackColor = True
        '
        'cmdDurationFromVtrControl
        '
        Me.cmdDurationFromVtrControl.Location = New System.Drawing.Point(328, 56)
        Me.cmdDurationFromVtrControl.Name = "cmdDurationFromVtrControl"
        Me.cmdDurationFromVtrControl.Size = New System.Drawing.Size(154, 23)
        Me.cmdDurationFromVtrControl.TabIndex = 1354
        Me.cmdDurationFromVtrControl.Text = "Duration From VTR Control"
        Me.cmdDurationFromVtrControl.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(30, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 1352
        Me.Label12.Text = "Recording Drive"
        '
        'cmbRecordDrive
        '
        Me.cmbRecordDrive.FormattingEnabled = True
        Me.cmbRecordDrive.Items.AddRange(New Object() {"InternalDrive", "SxS_A", "SxS_B", "PD_ProAV", "PD_BPAV", "PD_XDROOT", "USBDrive"})
        Me.cmbRecordDrive.Location = New System.Drawing.Point(33, 32)
        Me.cmbRecordDrive.Name = "cmbRecordDrive"
        Me.cmbRecordDrive.Size = New System.Drawing.Size(86, 21)
        Me.cmbRecordDrive.TabIndex = 1351
        Me.cmbRecordDrive.Text = "InternalDrive"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(140, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 1350
        Me.Label11.Text = "File Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(329, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 1349
        Me.Label1.Text = "Recording Duration"
        '
        'txtRecordingDuration
        '
        Me.txtRecordingDuration.Location = New System.Drawing.Point(328, 30)
        Me.txtRecordingDuration.Name = "txtRecordingDuration"
        Me.txtRecordingDuration.Size = New System.Drawing.Size(100, 20)
        Me.txtRecordingDuration.TabIndex = 1348
        Me.txtRecordingDuration.Text = "00:00:10:00"
        Me.txtRecordingDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtRecordingDuration, "Recording Duration in H:M:S:F format")
        '
        'lblRecorderStatus
        '
        Me.lblRecorderStatus.AutoSize = True
        Me.lblRecorderStatus.Location = New System.Drawing.Point(140, 88)
        Me.lblRecorderStatus.Name = "lblRecorderStatus"
        Me.lblRecorderStatus.Size = New System.Drawing.Size(98, 13)
        Me.lblRecorderStatus.TabIndex = 1347
        Me.lblRecorderStatus.Text = "Remaining duration"
        '
        'cmdGetRecoredrStatus
        '
        Me.cmdGetRecoredrStatus.Location = New System.Drawing.Point(9, 83)
        Me.cmdGetRecoredrStatus.Name = "cmdGetRecoredrStatus"
        Me.cmdGetRecoredrStatus.Size = New System.Drawing.Size(125, 23)
        Me.cmdGetRecoredrStatus.TabIndex = 1300
        Me.cmdGetRecoredrStatus.Text = "Recorder Status"
        Me.cmdGetRecoredrStatus.UseVisualStyleBackColor = True
        '
        'gbTrimming
        '
        Me.gbTrimming.BackColor = System.Drawing.Color.LightSalmon
        Me.gbTrimming.Controls.Add(Me.Label4)
        Me.gbTrimming.Controls.Add(Me.lblnewName)
        Me.gbTrimming.Controls.Add(Me.txtSubClipName)
        Me.gbTrimming.Controls.Add(Me.cmbdestinationDriveNames)
        Me.gbTrimming.Controls.Add(Me.cmdcopy)
        Me.gbTrimming.Location = New System.Drawing.Point(3, 173)
        Me.gbTrimming.Name = "gbTrimming"
        Me.gbTrimming.Size = New System.Drawing.Size(599, 52)
        Me.gbTrimming.TabIndex = 1316
        Me.gbTrimming.TabStop = False
        Me.gbTrimming.Text = "Trimming"
        '
        'dgv1
        '
        Me.dgv1.AllowDrop = True
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column3, Me.Column4, Me.DataGridViewTextBoxColumn2, Me.UMMID1})
        Me.dgv1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgv1.Location = New System.Drawing.Point(5, 136)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(575, 318)
        Me.dgv1.TabIndex = 1317
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Clips"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 325
        '
        'Column3
        '
        Me.Column3.HeaderText = "Start Time"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 70
        '
        'Column4
        '
        Me.Column4.FalseValue = "0"
        Me.Column4.HeaderText = "Play"
        Me.Column4.Name = "Column4"
        Me.Column4.TrueValue = "1"
        Me.Column4.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Duration"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'UMMID1
        '
        Me.UMMID1.HeaderText = "UMMID"
        Me.UMMID1.Name = "UMMID1"
        Me.UMMID1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UMMID1.Width = 5
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StopF1ToolStripMenuItem, Me.PlayToolStripMenuItem1, Me.CueToolStripMenuItem1, Me.PauseToolStripMenuItem1, Me.ResumeToolStripMenuItem1, Me.NextToolStripMenuItem1, Me.PlayNextF6ToolStripMenuItem, Me.InsertBlankToolStripMenuItem, Me.DeleteToolStripMenuItem1, Me.CopyToolStripMenuItem1, Me.PasteToolStripMenuItem1, Me.MoveUpToolStripMenuItem1, Me.MoveDownToolStripMenuItem1, Me.InserEndToolStripMenuItem, Me.PlayInVlcToolStripMenuItem, Me.PlayInLoopToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(140, 356)
        '
        'StopF1ToolStripMenuItem
        '
        Me.StopF1ToolStripMenuItem.Name = "StopF1ToolStripMenuItem"
        Me.StopF1ToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.StopF1ToolStripMenuItem.Text = "Stop F1"
        '
        'PlayToolStripMenuItem1
        '
        Me.PlayToolStripMenuItem1.Name = "PlayToolStripMenuItem1"
        Me.PlayToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.PlayToolStripMenuItem1.Text = "Play F2"
        '
        'CueToolStripMenuItem1
        '
        Me.CueToolStripMenuItem1.Name = "CueToolStripMenuItem1"
        Me.CueToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.CueToolStripMenuItem1.Text = "Cue F3"
        '
        'PauseToolStripMenuItem1
        '
        Me.PauseToolStripMenuItem1.Name = "PauseToolStripMenuItem1"
        Me.PauseToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.PauseToolStripMenuItem1.Text = "Pause F4"
        '
        'ResumeToolStripMenuItem1
        '
        Me.ResumeToolStripMenuItem1.Name = "ResumeToolStripMenuItem1"
        Me.ResumeToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.ResumeToolStripMenuItem1.Text = "Resume F4"
        '
        'NextToolStripMenuItem1
        '
        Me.NextToolStripMenuItem1.Name = "NextToolStripMenuItem1"
        Me.NextToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.NextToolStripMenuItem1.Text = "Cue Next F5"
        '
        'PlayNextF6ToolStripMenuItem
        '
        Me.PlayNextF6ToolStripMenuItem.Name = "PlayNextF6ToolStripMenuItem"
        Me.PlayNextF6ToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PlayNextF6ToolStripMenuItem.Text = "Play Next F6"
        '
        'InsertBlankToolStripMenuItem
        '
        Me.InsertBlankToolStripMenuItem.Name = "InsertBlankToolStripMenuItem"
        Me.InsertBlankToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.InsertBlankToolStripMenuItem.Text = "Insert Blank"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'CopyToolStripMenuItem1
        '
        Me.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1"
        Me.CopyToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.CopyToolStripMenuItem1.Text = "Copy"
        '
        'PasteToolStripMenuItem1
        '
        Me.PasteToolStripMenuItem1.Name = "PasteToolStripMenuItem1"
        Me.PasteToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.PasteToolStripMenuItem1.Text = "Paste"
        '
        'MoveUpToolStripMenuItem1
        '
        Me.MoveUpToolStripMenuItem1.Name = "MoveUpToolStripMenuItem1"
        Me.MoveUpToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.MoveUpToolStripMenuItem1.Text = "Move Up"
        '
        'MoveDownToolStripMenuItem1
        '
        Me.MoveDownToolStripMenuItem1.Name = "MoveDownToolStripMenuItem1"
        Me.MoveDownToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.MoveDownToolStripMenuItem1.Text = "Move Down"
        '
        'InserEndToolStripMenuItem
        '
        Me.InserEndToolStripMenuItem.Name = "InserEndToolStripMenuItem"
        Me.InserEndToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.InserEndToolStripMenuItem.Text = "Inser End"
        '
        'PlayInVlcToolStripMenuItem
        '
        Me.PlayInVlcToolStripMenuItem.Name = "PlayInVlcToolStripMenuItem"
        Me.PlayInVlcToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PlayInVlcToolStripMenuItem.Text = "PlayInVlc"
        '
        'PlayInLoopToolStripMenuItem
        '
        Me.PlayInLoopToolStripMenuItem.Name = "PlayInLoopToolStripMenuItem"
        Me.PlayInLoopToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PlayInLoopToolStripMenuItem.Text = "Play in Loop"
        '
        'cmdSaveSubClipSopa
        '
        Me.cmdSaveSubClipSopa.Location = New System.Drawing.Point(3, 119)
        Me.cmdSaveSubClipSopa.Name = "cmdSaveSubClipSopa"
        Me.cmdSaveSubClipSopa.Size = New System.Drawing.Size(89, 23)
        Me.cmdSaveSubClipSopa.TabIndex = 1325
        Me.cmdSaveSubClipSopa.Text = "Save Sub Clip"
        Me.cmdSaveSubClipSopa.UseVisualStyleBackColor = True
        '
        'tmrpreview
        '
        '
        'chkPlaySMIasXMF
        '
        Me.chkPlaySMIasXMF.AutoSize = True
        Me.chkPlaySMIasXMF.Checked = True
        Me.chkPlaySMIasXMF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPlaySMIasXMF.Location = New System.Drawing.Point(24, 264)
        Me.chkPlaySMIasXMF.Name = "chkPlaySMIasXMF"
        Me.chkPlaySMIasXMF.Size = New System.Drawing.Size(101, 17)
        Me.chkPlaySMIasXMF.TabIndex = 1349
        Me.chkPlaySMIasXMF.Text = "Play SMI as mxf"
        Me.ToolTip1.SetToolTip(Me.chkPlaySMIasXMF, "Chek this to avoid blankon startup of smi file")
        Me.chkPlaySMIasXMF.UseVisualStyleBackColor = True
        '
        'cmdgotoend
        '
        Me.cmdgotoend.Location = New System.Drawing.Point(458, 67)
        Me.cmdgotoend.Name = "cmdgotoend"
        Me.cmdgotoend.Size = New System.Drawing.Size(36, 23)
        Me.cmdgotoend.TabIndex = 1171
        Me.ToolTip1.SetToolTip(Me.cmdgotoend, "Go To End")
        Me.cmdgotoend.UseVisualStyleBackColor = True
        '
        'chkTimeLinePlayBackMethod
        '
        Me.chkTimeLinePlayBackMethod.AutoSize = True
        Me.chkTimeLinePlayBackMethod.Location = New System.Drawing.Point(24, 232)
        Me.chkTimeLinePlayBackMethod.Name = "chkTimeLinePlayBackMethod"
        Me.chkTimeLinePlayBackMethod.Size = New System.Drawing.Size(155, 17)
        Me.chkTimeLinePlayBackMethod.TabIndex = 1353
        Me.chkTimeLinePlayBackMethod.Text = "TimeLine Playback Method"
        Me.ToolTip1.SetToolTip(Me.chkTimeLinePlayBackMethod, "Chek this to avoid blankon startup of smi file")
        Me.chkTimeLinePlayBackMethod.UseVisualStyleBackColor = True
        '
        'cmdFastReverse
        '
        Me.cmdFastReverse.Image = Global.caspar_media_playback.My.Resources.Resources.fr
        Me.cmdFastReverse.Location = New System.Drawing.Point(376, 131)
        Me.cmdFastReverse.Name = "cmdFastReverse"
        Me.cmdFastReverse.Size = New System.Drawing.Size(37, 23)
        Me.cmdFastReverse.TabIndex = 1327
        Me.ToolTip1.SetToolTip(Me.cmdFastReverse, "fast Rewind")
        Me.cmdFastReverse.UseVisualStyleBackColor = True
        '
        'cmdFastFarward
        '
        Me.cmdFastFarward.Image = Global.caspar_media_playback.My.Resources.Resources.ff
        Me.cmdFastFarward.Location = New System.Drawing.Point(416, 132)
        Me.cmdFastFarward.Name = "cmdFastFarward"
        Me.cmdFastFarward.Size = New System.Drawing.Size(40, 23)
        Me.cmdFastFarward.TabIndex = 1326
        Me.ToolTip1.SetToolTip(Me.cmdFastFarward, "Fast Farward")
        Me.cmdFastFarward.UseVisualStyleBackColor = True
        '
        'cmdpausevdcp
        '
        Me.cmdpausevdcp.Image = CType(resources.GetObject("cmdpausevdcp.Image"), System.Drawing.Image)
        Me.cmdpausevdcp.Location = New System.Drawing.Point(240, 67)
        Me.cmdpausevdcp.Name = "cmdpausevdcp"
        Me.cmdpausevdcp.Size = New System.Drawing.Size(37, 21)
        Me.cmdpausevdcp.TabIndex = 1264
        Me.ToolTip1.SetToolTip(Me.cmdpausevdcp, "Pause")
        Me.cmdpausevdcp.UseVisualStyleBackColor = True
        '
        'cmdnextplay
        '
        Me.cmdnextplay.Image = CType(resources.GetObject("cmdnextplay.Image"), System.Drawing.Image)
        Me.cmdnextplay.Location = New System.Drawing.Point(416, 68)
        Me.cmdnextplay.Name = "cmdnextplay"
        Me.cmdnextplay.Size = New System.Drawing.Size(33, 23)
        Me.cmdnextplay.TabIndex = 355
        Me.ToolTip1.SetToolTip(Me.cmdnextplay, "Play Next")
        Me.cmdnextplay.UseVisualStyleBackColor = True
        '
        'cmdforwardoneframe
        '
        Me.cmdforwardoneframe.Image = CType(resources.GetObject("cmdforwardoneframe.Image"), System.Drawing.Image)
        Me.cmdforwardoneframe.Location = New System.Drawing.Point(204, 66)
        Me.cmdforwardoneframe.Name = "cmdforwardoneframe"
        Me.cmdforwardoneframe.Size = New System.Drawing.Size(35, 23)
        Me.cmdforwardoneframe.TabIndex = 354
        Me.ToolTip1.SetToolTip(Me.cmdforwardoneframe, "1 Frame Forward")
        Me.cmdforwardoneframe.UseVisualStyleBackColor = True
        '
        'cmdbackoneframe
        '
        Me.cmdbackoneframe.Image = CType(resources.GetObject("cmdbackoneframe.Image"), System.Drawing.Image)
        Me.cmdbackoneframe.Location = New System.Drawing.Point(137, 65)
        Me.cmdbackoneframe.Name = "cmdbackoneframe"
        Me.cmdbackoneframe.Size = New System.Drawing.Size(31, 23)
        Me.cmdbackoneframe.TabIndex = 353
        Me.ToolTip1.SetToolTip(Me.cmdbackoneframe, "1 Frame Back")
        Me.cmdbackoneframe.UseVisualStyleBackColor = True
        '
        'cmdcueclip
        '
        Me.cmdcueclip.Image = CType(resources.GetObject("cmdcueclip.Image"), System.Drawing.Image)
        Me.cmdcueclip.Location = New System.Drawing.Point(93, 66)
        Me.cmdcueclip.Name = "cmdcueclip"
        Me.cmdcueclip.Size = New System.Drawing.Size(38, 23)
        Me.cmdcueclip.TabIndex = 168
        Me.ToolTip1.SetToolTip(Me.cmdcueclip, "Cue")
        Me.cmdcueclip.UseVisualStyleBackColor = True
        '
        'cmdresume
        '
        Me.cmdresume.Image = CType(resources.GetObject("cmdresume.Image"), System.Drawing.Image)
        Me.cmdresume.Location = New System.Drawing.Point(279, 66)
        Me.cmdresume.Name = "cmdresume"
        Me.cmdresume.Size = New System.Drawing.Size(48, 23)
        Me.cmdresume.TabIndex = 160
        Me.ToolTip1.SetToolTip(Me.cmdresume, "Resume")
        Me.cmdresume.UseVisualStyleBackColor = True
        '
        'cmdcuenext
        '
        Me.cmdcuenext.Image = CType(resources.GetObject("cmdcuenext.Image"), System.Drawing.Image)
        Me.cmdcuenext.Location = New System.Drawing.Point(376, 67)
        Me.cmdcuenext.Name = "cmdcuenext"
        Me.cmdcuenext.Size = New System.Drawing.Size(29, 23)
        Me.cmdcuenext.TabIndex = 158
        Me.ToolTip1.SetToolTip(Me.cmdcuenext, "Cue Next")
        Me.cmdcuenext.UseVisualStyleBackColor = True
        '
        'cmdPlaySingleClip
        '
        Me.cmdPlaySingleClip.Image = CType(resources.GetObject("cmdPlaySingleClip.Image"), System.Drawing.Image)
        Me.cmdPlaySingleClip.Location = New System.Drawing.Point(174, 66)
        Me.cmdPlaySingleClip.Name = "cmdPlaySingleClip"
        Me.cmdPlaySingleClip.Size = New System.Drawing.Size(26, 23)
        Me.cmdPlaySingleClip.TabIndex = 157
        Me.cmdPlaySingleClip.Text = "0"
        Me.ToolTip1.SetToolTip(Me.cmdPlaySingleClip, "Play From Start")
        Me.cmdPlaySingleClip.UseVisualStyleBackColor = True
        '
        'cmdstop
        '
        Me.cmdstop.Image = CType(resources.GetObject("cmdstop.Image"), System.Drawing.Image)
        Me.cmdstop.Location = New System.Drawing.Point(331, 66)
        Me.cmdstop.Name = "cmdstop"
        Me.cmdstop.Size = New System.Drawing.Size(37, 23)
        Me.cmdstop.TabIndex = 79
        Me.ToolTip1.SetToolTip(Me.cmdstop, "Stop")
        Me.cmdstop.UseVisualStyleBackColor = True
        '
        'cmdCueFromClipGrid
        '
        Me.cmdCueFromClipGrid.Image = CType(resources.GetObject("cmdCueFromClipGrid.Image"), System.Drawing.Image)
        Me.cmdCueFromClipGrid.Location = New System.Drawing.Point(541, 697)
        Me.cmdCueFromClipGrid.Name = "cmdCueFromClipGrid"
        Me.cmdCueFromClipGrid.Size = New System.Drawing.Size(39, 30)
        Me.cmdCueFromClipGrid.TabIndex = 1327
        Me.ToolTip1.SetToolTip(Me.cmdCueFromClipGrid, "Cue from Clipgrid")
        Me.cmdCueFromClipGrid.UseVisualStyleBackColor = True
        '
        'cmdCueFromPlaylist
        '
        Me.cmdCueFromPlaylist.Image = CType(resources.GetObject("cmdCueFromPlaylist.Image"), System.Drawing.Image)
        Me.cmdCueFromPlaylist.Location = New System.Drawing.Point(541, 99)
        Me.cmdCueFromPlaylist.Name = "cmdCueFromPlaylist"
        Me.cmdCueFromPlaylist.Size = New System.Drawing.Size(39, 30)
        Me.cmdCueFromPlaylist.TabIndex = 1326
        Me.ToolTip1.SetToolTip(Me.cmdCueFromPlaylist, "Cue From Playlist")
        Me.cmdCueFromPlaylist.UseVisualStyleBackColor = True
        '
        'chkThumbnail
        '
        Me.chkThumbnail.AutoSize = True
        Me.chkThumbnail.Location = New System.Drawing.Point(413, 462)
        Me.chkThumbnail.Name = "chkThumbnail"
        Me.chkThumbnail.Size = New System.Drawing.Size(75, 17)
        Me.chkThumbnail.TabIndex = 1323
        Me.chkThumbnail.Text = "Thumbnail"
        Me.chkThumbnail.UseVisualStyleBackColor = True
        '
        'lblUMID
        '
        Me.lblUMID.AutoSize = True
        Me.lblUMID.Location = New System.Drawing.Point(561, 52)
        Me.lblUMID.Name = "lblUMID"
        Me.lblUMID.Size = New System.Drawing.Size(35, 13)
        Me.lblUMID.TabIndex = 1325
        Me.lblUMID.Text = "UMID"
        Me.lblUMID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUMID.Visible = False
        '
        'lblClips
        '
        Me.lblClips.AutoSize = True
        Me.lblClips.Location = New System.Drawing.Point(331, 463)
        Me.lblClips.Name = "lblClips"
        Me.lblClips.Size = New System.Drawing.Size(58, 13)
        Me.lblClips.TabIndex = 1328
        Me.lblClips.Text = "No of Clips"
        '
        'cmdStartPlayList
        '
        Me.cmdStartPlayList.Location = New System.Drawing.Point(230, 106)
        Me.cmdStartPlayList.Name = "cmdStartPlayList"
        Me.cmdStartPlayList.Size = New System.Drawing.Size(73, 23)
        Me.cmdStartPlayList.TabIndex = 1329
        Me.cmdStartPlayList.Text = "Start Playlist"
        Me.cmdStartPlayList.UseVisualStyleBackColor = True
        '
        'tmrNextClipofPlaylist
        '
        '
        'cmddeleteclip
        '
        Me.cmddeleteclip.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddeleteclip.Location = New System.Drawing.Point(183, 107)
        Me.cmddeleteclip.Name = "cmddeleteclip"
        Me.cmddeleteclip.Size = New System.Drawing.Size(28, 22)
        Me.cmddeleteclip.TabIndex = 1334
        Me.cmddeleteclip.UseVisualStyleBackColor = True
        '
        'tsPlaylist
        '
        Me.tsPlaylist.Dock = System.Windows.Forms.DockStyle.None
        Me.tsPlaylist.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveAsToolStripButton})
        Me.tsPlaylist.Location = New System.Drawing.Point(6, 106)
        Me.tsPlaylist.MaximumSize = New System.Drawing.Size(200, 200)
        Me.tsPlaylist.Name = "tsPlaylist"
        Me.tsPlaylist.Size = New System.Drawing.Size(81, 25)
        Me.tsPlaylist.TabIndex = 1330
        Me.tsPlaylist.Text = "tsplaylist"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveAsToolStripButton
        '
        Me.SaveAsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveAsToolStripButton.Image = CType(resources.GetObject("SaveAsToolStripButton.Image"), System.Drawing.Image)
        Me.SaveAsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveAsToolStripButton.Name = "SaveAsToolStripButton"
        Me.SaveAsToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveAsToolStripButton.Text = "&SaveAs"
        '
        'lblplaylistname
        '
        Me.lblplaylistname.AutoSize = True
        Me.lblplaylistname.Location = New System.Drawing.Point(6, 69)
        Me.lblplaylistname.Name = "lblplaylistname"
        Me.lblplaylistname.Size = New System.Drawing.Size(39, 13)
        Me.lblplaylistname.TabIndex = 1335
        Me.lblplaylistname.Text = "Playlist"
        '
        'tmrfornotskipping
        '
        Me.tmrfornotskipping.Interval = 3000
        '
        'gbplayer
        '
        Me.gbplayer.BackColor = System.Drawing.Color.DarkSalmon
        Me.gbplayer.Controls.Add(Me.cmdFastReverse)
        Me.gbplayer.Controls.Add(Me.cmdFastFarward)
        Me.gbplayer.Controls.Add(Me.nvlcspeed)
        Me.gbplayer.Controls.Add(Me.cmdspeed1trimmer)
        Me.gbplayer.Controls.Add(Me.cmdpausevdcp)
        Me.gbplayer.Controls.Add(Me.lbltrimmedduration)
        Me.gbplayer.Controls.Add(Me.cmdforwardsecond)
        Me.gbplayer.Controls.Add(Me.lbloriginalduration)
        Me.gbplayer.Controls.Add(Me.Label232)
        Me.gbplayer.Controls.Add(Me.txtforwardsecond)
        Me.gbplayer.Controls.Add(Me.Label231)
        Me.gbplayer.Controls.Add(Me.cmdSaveSubClipSopa)
        Me.gbplayer.Controls.Add(Me.txtgototccasparcgwindow)
        Me.gbplayer.Controls.Add(Me.cmdplayfromout)
        Me.gbplayer.Controls.Add(Me.cmdgototccasparcgwindow)
        Me.gbplayer.Controls.Add(Me.cmdplayfromin)
        Me.gbplayer.Controls.Add(Me.cmdplaylast5seccasaprcgwindow)
        Me.gbplayer.Controls.Add(Me.cmdgotoend)
        Me.gbplayer.Controls.Add(Me.lbltimecode)
        Me.gbplayer.Controls.Add(Me.cmdnextplay)
        Me.gbplayer.Controls.Add(Me.cmdforwardoneframe)
        Me.gbplayer.Controls.Add(Me.cmdbackoneframe)
        Me.gbplayer.Controls.Add(Me.lblCurrentFrame)
        Me.gbplayer.Controls.Add(Me.cmdgotoout)
        Me.gbplayer.Controls.Add(Me.cmdgotoin)
        Me.gbplayer.Controls.Add(Me.cmdmarkout)
        Me.gbplayer.Controls.Add(Me.cmdmarkin)
        Me.gbplayer.Controls.Add(Me.txtmarkoutsoap)
        Me.gbplayer.Controls.Add(Me.txtmarkinsoap)
        Me.gbplayer.Controls.Add(Me.lblmin)
        Me.gbplayer.Controls.Add(Me.lbltbmax)
        Me.gbplayer.Controls.Add(Me.cmdcueclip)
        Me.gbplayer.Controls.Add(Me.cmdresume)
        Me.gbplayer.Controls.Add(Me.cmdcuenext)
        Me.gbplayer.Controls.Add(Me.cmdPlaySingleClip)
        Me.gbplayer.Controls.Add(Me.cmdstop)
        Me.gbplayer.Controls.Add(Me.tbsoap)
        Me.gbplayer.Location = New System.Drawing.Point(1, 3)
        Me.gbplayer.Name = "gbplayer"
        Me.gbplayer.Size = New System.Drawing.Size(601, 164)
        Me.gbplayer.TabIndex = 1337
        Me.gbplayer.TabStop = False
        '
        'nvlcspeed
        '
        Me.nvlcspeed.DecimalPlaces = 1
        Me.nvlcspeed.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nvlcspeed.Location = New System.Drawing.Point(549, 134)
        Me.nvlcspeed.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nvlcspeed.Minimum = New Decimal(New Integer() {2, 0, 0, -2147483648})
        Me.nvlcspeed.Name = "nvlcspeed"
        Me.nvlcspeed.Size = New System.Drawing.Size(38, 20)
        Me.nvlcspeed.TabIndex = 1305
        Me.nvlcspeed.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmdspeed1trimmer
        '
        Me.cmdspeed1trimmer.Location = New System.Drawing.Point(488, 133)
        Me.cmdspeed1trimmer.Name = "cmdspeed1trimmer"
        Me.cmdspeed1trimmer.Size = New System.Drawing.Size(57, 23)
        Me.cmdspeed1trimmer.TabIndex = 1300
        Me.cmdspeed1trimmer.Text = "Speed 1"
        Me.cmdspeed1trimmer.UseVisualStyleBackColor = True
        '
        'lbltrimmedduration
        '
        Me.lbltrimmedduration.AutoSize = True
        Me.lbltrimmedduration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltrimmedduration.ForeColor = System.Drawing.Color.Maroon
        Me.lbltrimmedduration.Location = New System.Drawing.Point(179, 138)
        Me.lbltrimmedduration.Name = "lbltrimmedduration"
        Me.lbltrimmedduration.Size = New System.Drawing.Size(131, 16)
        Me.lbltrimmedduration.TabIndex = 1304
        Me.lbltrimmedduration.Text = "Trimmed Duration"
        '
        'cmdforwardsecond
        '
        Me.cmdforwardsecond.Location = New System.Drawing.Point(249, 90)
        Me.cmdforwardsecond.Name = "cmdforwardsecond"
        Me.cmdforwardsecond.Size = New System.Drawing.Size(76, 23)
        Me.cmdforwardsecond.TabIndex = 1176
        Me.cmdforwardsecond.Text = "Forward Sec"
        Me.cmdforwardsecond.UseVisualStyleBackColor = True
        '
        'lbloriginalduration
        '
        Me.lbloriginalduration.AutoSize = True
        Me.lbloriginalduration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloriginalduration.ForeColor = System.Drawing.Color.Maroon
        Me.lbloriginalduration.Location = New System.Drawing.Point(179, 119)
        Me.lbloriginalduration.Name = "lbloriginalduration"
        Me.lbloriginalduration.Size = New System.Drawing.Size(124, 16)
        Me.lbloriginalduration.TabIndex = 1303
        Me.lbloriginalduration.Text = "Original Duration"
        '
        'Label232
        '
        Me.Label232.AutoSize = True
        Me.Label232.Location = New System.Drawing.Point(93, 137)
        Me.Label232.Name = "Label232"
        Me.Label232.Size = New System.Drawing.Size(90, 13)
        Me.Label232.TabIndex = 1302
        Me.Label232.Text = "Trimmed Duration"
        '
        'txtforwardsecond
        '
        Me.txtforwardsecond.Location = New System.Drawing.Point(325, 91)
        Me.txtforwardsecond.Name = "txtforwardsecond"
        Me.txtforwardsecond.Size = New System.Drawing.Size(26, 20)
        Me.txtforwardsecond.TabIndex = 1177
        Me.txtforwardsecond.Text = "5"
        Me.txtforwardsecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label231
        '
        Me.Label231.AutoSize = True
        Me.Label231.Location = New System.Drawing.Point(98, 119)
        Me.Label231.Name = "Label231"
        Me.Label231.Size = New System.Drawing.Size(85, 13)
        Me.Label231.TabIndex = 1301
        Me.Label231.Text = "Original Duration"
        '
        'txtgototccasparcgwindow
        '
        Me.txtgototccasparcgwindow.Location = New System.Drawing.Point(180, 92)
        Me.txtgototccasparcgwindow.Name = "txtgototccasparcgwindow"
        Me.txtgototccasparcgwindow.Size = New System.Drawing.Size(66, 20)
        Me.txtgototccasparcgwindow.TabIndex = 1172
        Me.txtgototccasparcgwindow.Text = "00:02:00:00"
        '
        'cmdplayfromout
        '
        Me.cmdplayfromout.Location = New System.Drawing.Point(446, 91)
        Me.cmdplayfromout.Name = "cmdplayfromout"
        Me.cmdplayfromout.Size = New System.Drawing.Size(80, 23)
        Me.cmdplayfromout.TabIndex = 1173
        Me.cmdplayfromout.Text = "Play from Out"
        Me.cmdplayfromout.UseVisualStyleBackColor = True
        '
        'cmdgototccasparcgwindow
        '
        Me.cmdgototccasparcgwindow.Location = New System.Drawing.Point(121, 90)
        Me.cmdgototccasparcgwindow.Name = "cmdgototccasparcgwindow"
        Me.cmdgototccasparcgwindow.Size = New System.Drawing.Size(60, 23)
        Me.cmdgototccasparcgwindow.TabIndex = 1171
        Me.cmdgototccasparcgwindow.Text = "GoToTC"
        Me.cmdgototccasparcgwindow.UseVisualStyleBackColor = True
        '
        'cmdplayfromin
        '
        Me.cmdplayfromin.Location = New System.Drawing.Point(54, 90)
        Me.cmdplayfromin.Name = "cmdplayfromin"
        Me.cmdplayfromin.Size = New System.Drawing.Size(70, 23)
        Me.cmdplayfromin.TabIndex = 1172
        Me.cmdplayfromin.Text = "Play from In"
        Me.cmdplayfromin.UseVisualStyleBackColor = True
        '
        'cmdplaylast5seccasaprcgwindow
        '
        Me.cmdplaylast5seccasaprcgwindow.Location = New System.Drawing.Point(355, 92)
        Me.cmdplaylast5seccasaprcgwindow.Name = "cmdplaylast5seccasaprcgwindow"
        Me.cmdplaylast5seccasaprcgwindow.Size = New System.Drawing.Size(89, 23)
        Me.cmdplaylast5seccasaprcgwindow.TabIndex = 1175
        Me.cmdplaylast5seccasaprcgwindow.Text = "Play Last 5 Sec"
        Me.cmdplaylast5seccasaprcgwindow.UseVisualStyleBackColor = True
        '
        'lbltimecode
        '
        Me.lbltimecode.AutoSize = True
        Me.lbltimecode.BackColor = System.Drawing.Color.Yellow
        Me.lbltimecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimecode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbltimecode.Location = New System.Drawing.Point(255, 9)
        Me.lbltimecode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltimecode.Name = "lbltimecode"
        Me.lbltimecode.Size = New System.Drawing.Size(67, 13)
        Me.lbltimecode.TabIndex = 637
        Me.lbltimecode.Text = "Time Code"
        '
        'lblCurrentFrame
        '
        Me.lblCurrentFrame.AutoSize = True
        Me.lblCurrentFrame.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentFrame.Location = New System.Drawing.Point(276, 49)
        Me.lblCurrentFrame.Name = "lblCurrentFrame"
        Me.lblCurrentFrame.Size = New System.Drawing.Size(10, 13)
        Me.lblCurrentFrame.TabIndex = 352
        Me.lblCurrentFrame.Text = "."
        Me.lblCurrentFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdgotoout
        '
        Me.cmdgotoout.Location = New System.Drawing.Point(526, 92)
        Me.cmdgotoout.Name = "cmdgotoout"
        Me.cmdgotoout.Size = New System.Drawing.Size(73, 23)
        Me.cmdgotoout.TabIndex = 349
        Me.cmdgotoout.Text = "GOTO OUT"
        Me.cmdgotoout.UseVisualStyleBackColor = True
        '
        'cmdgotoin
        '
        Me.cmdgotoin.Location = New System.Drawing.Point(2, 91)
        Me.cmdgotoin.Name = "cmdgotoin"
        Me.cmdgotoin.Size = New System.Drawing.Size(53, 23)
        Me.cmdgotoin.TabIndex = 348
        Me.cmdgotoin.Text = "Go to In"
        Me.cmdgotoin.UseVisualStyleBackColor = True
        '
        'cmdmarkout
        '
        Me.cmdmarkout.Location = New System.Drawing.Point(549, 67)
        Me.cmdmarkout.Name = "cmdmarkout"
        Me.cmdmarkout.Size = New System.Drawing.Size(47, 23)
        Me.cmdmarkout.TabIndex = 347
        Me.cmdmarkout.Text = "OUT"
        Me.cmdmarkout.UseVisualStyleBackColor = True
        '
        'cmdmarkin
        '
        Me.cmdmarkin.Location = New System.Drawing.Point(3, 66)
        Me.cmdmarkin.Name = "cmdmarkin"
        Me.cmdmarkin.Size = New System.Drawing.Size(37, 23)
        Me.cmdmarkin.TabIndex = 346
        Me.cmdmarkin.Text = "IN"
        Me.cmdmarkin.UseVisualStyleBackColor = True
        '
        'txtmarkoutsoap
        '
        Me.txtmarkoutsoap.Location = New System.Drawing.Point(503, 69)
        Me.txtmarkoutsoap.Name = "txtmarkoutsoap"
        Me.txtmarkoutsoap.Size = New System.Drawing.Size(43, 20)
        Me.txtmarkoutsoap.TabIndex = 345
        Me.txtmarkoutsoap.Text = "300"
        '
        'txtmarkinsoap
        '
        Me.txtmarkinsoap.Location = New System.Drawing.Point(43, 68)
        Me.txtmarkinsoap.Name = "txtmarkinsoap"
        Me.txtmarkinsoap.Size = New System.Drawing.Size(48, 20)
        Me.txtmarkinsoap.TabIndex = 344
        Me.txtmarkinsoap.Text = "100"
        '
        'lblmin
        '
        Me.lblmin.AutoSize = True
        Me.lblmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmin.Location = New System.Drawing.Point(28, 49)
        Me.lblmin.Name = "lblmin"
        Me.lblmin.Size = New System.Drawing.Size(10, 13)
        Me.lblmin.TabIndex = 335
        Me.lblmin.Text = "."
        Me.lblmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltbmax
        '
        Me.lbltbmax.AutoSize = True
        Me.lbltbmax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltbmax.Location = New System.Drawing.Point(531, 51)
        Me.lbltbmax.Name = "lbltbmax"
        Me.lbltbmax.Size = New System.Drawing.Size(10, 13)
        Me.lbltbmax.TabIndex = 0
        Me.lbltbmax.Text = "."
        Me.lbltbmax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbsoap
        '
        Me.tbsoap.AutoSize = False
        Me.tbsoap.BackColor = System.Drawing.SystemColors.Control
        Me.tbsoap.LargeChange = 2
        Me.tbsoap.Location = New System.Drawing.Point(19, 17)
        Me.tbsoap.Maximum = 999999999
        Me.tbsoap.Name = "tbsoap"
        Me.tbsoap.Size = New System.Drawing.Size(530, 31)
        Me.tbsoap.TabIndex = 329
        Me.tbsoap.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 463)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 1338
        Me.Label3.Text = "Total Clips"
        '
        'lblMoreInfo
        '
        Me.lblMoreInfo.AutoSize = True
        Me.lblMoreInfo.Location = New System.Drawing.Point(38, 22)
        Me.lblMoreInfo.Name = "lblMoreInfo"
        Me.lblMoreInfo.Size = New System.Drawing.Size(51, 13)
        Me.lblMoreInfo.TabIndex = 1339
        Me.lblMoreInfo.Text = "More info"
        '
        'lblMoreInfo2
        '
        Me.lblMoreInfo2.AutoSize = True
        Me.lblMoreInfo2.Location = New System.Drawing.Point(316, 31)
        Me.lblMoreInfo2.Name = "lblMoreInfo2"
        Me.lblMoreInfo2.Size = New System.Drawing.Size(57, 13)
        Me.lblMoreInfo2.TabIndex = 1340
        Me.lblMoreInfo2.Text = "More info2"
        '
        'cmdSetXdcam
        '
        Me.cmdSetXdcam.Location = New System.Drawing.Point(324, 20)
        Me.cmdSetXdcam.Name = "cmdSetXdcam"
        Me.cmdSetXdcam.Size = New System.Drawing.Size(50, 76)
        Me.cmdSetXdcam.TabIndex = 1344
        Me.cmdSetXdcam.Text = "Set Xdcam"
        Me.cmdSetXdcam.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Trimmer)
        Me.TabControl1.Controls.Add(Me.AddEssenceMark)
        Me.TabControl1.Controls.Add(Me.SystemFunction)
        Me.TabControl1.Controls.Add(Me.Settings)
        Me.TabControl1.Controls.Add(Me.Help)
        Me.TabControl1.Controls.Add(Me.MoreInfo)
        Me.TabControl1.Controls.Add(Me.Recorder)
        Me.TabControl1.Location = New System.Drawing.Point(586, 136)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(614, 592)
        Me.TabControl1.TabIndex = 1345
        '
        'Trimmer
        '
        Me.Trimmer.Controls.Add(Me.gbplayer)
        Me.Trimmer.Controls.Add(Me.gbTrimming)
        Me.Trimmer.Location = New System.Drawing.Point(4, 22)
        Me.Trimmer.Name = "Trimmer"
        Me.Trimmer.Padding = New System.Windows.Forms.Padding(3)
        Me.Trimmer.Size = New System.Drawing.Size(606, 566)
        Me.Trimmer.TabIndex = 0
        Me.Trimmer.Text = "Trimmer"
        Me.Trimmer.UseVisualStyleBackColor = True
        '
        'AddEssenceMark
        '
        Me.AddEssenceMark.Controls.Add(Me.lblessenceMarkStatus)
        Me.AddEssenceMark.Controls.Add(Me.cmdAddEssenceMark)
        Me.AddEssenceMark.Controls.Add(Me.dgvEssenceMark)
        Me.AddEssenceMark.Location = New System.Drawing.Point(4, 22)
        Me.AddEssenceMark.Name = "AddEssenceMark"
        Me.AddEssenceMark.Padding = New System.Windows.Forms.Padding(3)
        Me.AddEssenceMark.Size = New System.Drawing.Size(606, 566)
        Me.AddEssenceMark.TabIndex = 6
        Me.AddEssenceMark.Text = "Add Essence Mark"
        Me.AddEssenceMark.UseVisualStyleBackColor = True
        '
        'lblessenceMarkStatus
        '
        Me.lblessenceMarkStatus.AutoSize = True
        Me.lblessenceMarkStatus.Location = New System.Drawing.Point(493, 31)
        Me.lblessenceMarkStatus.Name = "lblessenceMarkStatus"
        Me.lblessenceMarkStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblessenceMarkStatus.TabIndex = 1348
        Me.lblessenceMarkStatus.Text = "Status"
        '
        'cmdAddEssenceMark
        '
        Me.cmdAddEssenceMark.Location = New System.Drawing.Point(375, 2)
        Me.cmdAddEssenceMark.Name = "cmdAddEssenceMark"
        Me.cmdAddEssenceMark.Size = New System.Drawing.Size(128, 23)
        Me.cmdAddEssenceMark.TabIndex = 1
        Me.cmdAddEssenceMark.Text = "Add Essence Mark"
        Me.cmdAddEssenceMark.UseVisualStyleBackColor = True
        '
        'dgvEssenceMark
        '
        Me.dgvEssenceMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEssenceMark.Location = New System.Drawing.Point(10, 31)
        Me.dgvEssenceMark.Name = "dgvEssenceMark"
        Me.dgvEssenceMark.Size = New System.Drawing.Size(472, 251)
        Me.dgvEssenceMark.TabIndex = 0
        '
        'SystemFunction
        '
        Me.SystemFunction.Controls.Add(Me.lblSystemErrorWarning)
        Me.SystemFunction.Controls.Add(Me.cmdGetSystemErrorWarning)
        Me.SystemFunction.Controls.Add(Me.lblSystemStatus)
        Me.SystemFunction.Controls.Add(Me.cmdGetSystemStatus)
        Me.SystemFunction.Controls.Add(Me.lblSystemProperties)
        Me.SystemFunction.Controls.Add(Me.cmdGetSystemProperties)
        Me.SystemFunction.Controls.Add(Me.cmbEjectDrive)
        Me.SystemFunction.Controls.Add(Me.cdmEject)
        Me.SystemFunction.Controls.Add(Me.cmdShutDown)
        Me.SystemFunction.Location = New System.Drawing.Point(4, 22)
        Me.SystemFunction.Name = "SystemFunction"
        Me.SystemFunction.Padding = New System.Windows.Forms.Padding(3)
        Me.SystemFunction.Size = New System.Drawing.Size(606, 566)
        Me.SystemFunction.TabIndex = 5
        Me.SystemFunction.Text = "System Function"
        Me.SystemFunction.UseVisualStyleBackColor = True
        '
        'lblSystemErrorWarning
        '
        Me.lblSystemErrorWarning.AutoSize = True
        Me.lblSystemErrorWarning.Location = New System.Drawing.Point(409, 32)
        Me.lblSystemErrorWarning.Name = "lblSystemErrorWarning"
        Me.lblSystemErrorWarning.Size = New System.Drawing.Size(109, 13)
        Me.lblSystemErrorWarning.TabIndex = 1352
        Me.lblSystemErrorWarning.Text = "System Error Warning"
        '
        'cmdGetSystemErrorWarning
        '
        Me.cmdGetSystemErrorWarning.Location = New System.Drawing.Point(400, 3)
        Me.cmdGetSystemErrorWarning.Name = "cmdGetSystemErrorWarning"
        Me.cmdGetSystemErrorWarning.Size = New System.Drawing.Size(173, 23)
        Me.cmdGetSystemErrorWarning.TabIndex = 1351
        Me.cmdGetSystemErrorWarning.Text = "Get System Error Warning"
        Me.cmdGetSystemErrorWarning.UseVisualStyleBackColor = True
        '
        'lblSystemStatus
        '
        Me.lblSystemStatus.AutoSize = True
        Me.lblSystemStatus.Location = New System.Drawing.Point(238, 32)
        Me.lblSystemStatus.Name = "lblSystemStatus"
        Me.lblSystemStatus.Size = New System.Drawing.Size(71, 13)
        Me.lblSystemStatus.TabIndex = 1350
        Me.lblSystemStatus.Text = "SystemStatus"
        '
        'cmdGetSystemStatus
        '
        Me.cmdGetSystemStatus.Location = New System.Drawing.Point(230, 6)
        Me.cmdGetSystemStatus.Name = "cmdGetSystemStatus"
        Me.cmdGetSystemStatus.Size = New System.Drawing.Size(129, 23)
        Me.cmdGetSystemStatus.TabIndex = 1349
        Me.cmdGetSystemStatus.Text = "Get System Status"
        Me.cmdGetSystemStatus.UseVisualStyleBackColor = True
        '
        'lblSystemProperties
        '
        Me.lblSystemProperties.AutoSize = True
        Me.lblSystemProperties.Location = New System.Drawing.Point(10, 90)
        Me.lblSystemProperties.Name = "lblSystemProperties"
        Me.lblSystemProperties.Size = New System.Drawing.Size(91, 13)
        Me.lblSystemProperties.TabIndex = 1348
        Me.lblSystemProperties.Text = "System Properties"
        '
        'cmdGetSystemProperties
        '
        Me.cmdGetSystemProperties.Location = New System.Drawing.Point(6, 64)
        Me.cmdGetSystemProperties.Name = "cmdGetSystemProperties"
        Me.cmdGetSystemProperties.Size = New System.Drawing.Size(129, 23)
        Me.cmdGetSystemProperties.TabIndex = 1296
        Me.cmdGetSystemProperties.Text = "Get System Properties"
        Me.cmdGetSystemProperties.UseVisualStyleBackColor = True
        '
        'cmbEjectDrive
        '
        Me.cmbEjectDrive.FormattingEnabled = True
        Me.cmbEjectDrive.Items.AddRange(New Object() {"InternalDrive", "SxS_A", "SxS_B", "PD_ProAV", "PD_BPAV", "PD_XDROOT", "USBDrive"})
        Me.cmbEjectDrive.Location = New System.Drawing.Point(86, 37)
        Me.cmbEjectDrive.Name = "cmbEjectDrive"
        Me.cmbEjectDrive.Size = New System.Drawing.Size(86, 21)
        Me.cmbEjectDrive.TabIndex = 1295
        Me.cmbEjectDrive.Text = "PD_ProAV"
        '
        'cdmEject
        '
        Me.cdmEject.Location = New System.Drawing.Point(5, 35)
        Me.cdmEject.Name = "cdmEject"
        Me.cdmEject.Size = New System.Drawing.Size(75, 23)
        Me.cdmEject.TabIndex = 1
        Me.cdmEject.Text = "Eject"
        Me.cdmEject.UseVisualStyleBackColor = True
        '
        'cmdShutDown
        '
        Me.cmdShutDown.Location = New System.Drawing.Point(5, 6)
        Me.cmdShutDown.Name = "cmdShutDown"
        Me.cmdShutDown.Size = New System.Drawing.Size(75, 23)
        Me.cmdShutDown.TabIndex = 0
        Me.cmdShutDown.Text = "Shut Down"
        Me.cmdShutDown.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.Settings.Controls.Add(Me.txtPassword)
        Me.Settings.Controls.Add(Me.txtUsername)
        Me.Settings.Controls.Add(Me.txtipaddress)
        Me.Settings.Controls.Add(Me.chkTimeLinePlayBackMethod)
        Me.Settings.Controls.Add(Me.cmbMappedDriveName)
        Me.Settings.Controls.Add(Me.Label10)
        Me.Settings.Controls.Add(Me.chkPlaySMIasXMF)
        Me.Settings.Controls.Add(Me.Label9)
        Me.Settings.Controls.Add(Me.Label8)
        Me.Settings.Controls.Add(Me.Label7)
        Me.Settings.Controls.Add(Me.cmdSetXdcam)
        Me.Settings.Location = New System.Drawing.Point(4, 22)
        Me.Settings.Name = "Settings"
        Me.Settings.Padding = New System.Windows.Forms.Padding(3)
        Me.Settings.Size = New System.Drawing.Size(606, 566)
        Me.Settings.TabIndex = 1
        Me.Settings.Text = "Settings"
        Me.Settings.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "xdcampassword", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtPassword.Location = New System.Drawing.Point(112, 79)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(208, 20)
        Me.txtPassword.TabIndex = 1356
        Me.txtPassword.Text = Global.caspar_media_playback.My.MySettings.Default.xdcampassword
        '
        'txtUsername
        '
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "xdcamusername", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtUsername.Location = New System.Drawing.Point(110, 53)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(208, 20)
        Me.txtUsername.TabIndex = 1355
        Me.txtUsername.Text = Global.caspar_media_playback.My.MySettings.Default.xdcamusername
        '
        'txtipaddress
        '
        Me.txtipaddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "xdcamaddress1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtipaddress.Location = New System.Drawing.Point(110, 27)
        Me.txtipaddress.Name = "txtipaddress"
        Me.txtipaddress.Size = New System.Drawing.Size(208, 20)
        Me.txtipaddress.TabIndex = 1354
        Me.txtipaddress.Text = Global.caspar_media_playback.My.MySettings.Default.xdcamaddress1
        '
        'cmbMappedDriveName
        '
        Me.cmbMappedDriveName.FormattingEnabled = True
        Me.cmbMappedDriveName.Items.AddRange(New Object() {"X:\", "Y:\", "Z:\"})
        Me.cmbMappedDriveName.Location = New System.Drawing.Point(165, 151)
        Me.cmbMappedDriveName.Name = "cmbMappedDriveName"
        Me.cmbMappedDriveName.Size = New System.Drawing.Size(59, 21)
        Me.cmbMappedDriveName.TabIndex = 1352
        Me.cmbMappedDriveName.Text = "Z:\"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 13)
        Me.Label10.TabIndex = 1351
        Me.Label10.Text = "Mapped Xdcam Drive Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(51, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 1350
        Me.Label9.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 1349
        Me.Label8.Text = "User Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 1348
        Me.Label7.Text = "Xdcam Address"
        '
        'Help
        '
        Me.Help.Controls.Add(Me.lblnote)
        Me.Help.Location = New System.Drawing.Point(4, 22)
        Me.Help.Name = "Help"
        Me.Help.Padding = New System.Windows.Forms.Padding(3)
        Me.Help.Size = New System.Drawing.Size(606, 566)
        Me.Help.TabIndex = 2
        Me.Help.Text = "Help"
        Me.Help.UseVisualStyleBackColor = True
        '
        'MoreInfo
        '
        Me.MoreInfo.Controls.Add(Me.lblMoreInfo2)
        Me.MoreInfo.Controls.Add(Me.lblMoreInfo)
        Me.MoreInfo.Location = New System.Drawing.Point(4, 22)
        Me.MoreInfo.Name = "MoreInfo"
        Me.MoreInfo.Size = New System.Drawing.Size(606, 566)
        Me.MoreInfo.TabIndex = 3
        Me.MoreInfo.Text = "More Info Of Online Clip"
        Me.MoreInfo.UseVisualStyleBackColor = True
        '
        'Recorder
        '
        Me.Recorder.Controls.Add(Me.GroupBox2)
        Me.Recorder.Location = New System.Drawing.Point(4, 22)
        Me.Recorder.Name = "Recorder"
        Me.Recorder.Padding = New System.Windows.Forms.Padding(3)
        Me.Recorder.Size = New System.Drawing.Size(606, 566)
        Me.Recorder.TabIndex = 4
        Me.Recorder.Text = "Recorder"
        Me.Recorder.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(9, 459)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 1346
        '
        'tmrRecoderStatus
        '
        Me.tmrRecoderStatus.Interval = 2000
        '
        'cmdGetThumbNail
        '
        Me.cmdGetThumbNail.Location = New System.Drawing.Point(494, 458)
        Me.cmdGetThumbNail.Name = "cmdGetThumbNail"
        Me.cmdGetThumbNail.Size = New System.Drawing.Size(86, 23)
        Me.cmdGetThumbNail.TabIndex = 1347
        Me.cmdGetThumbNail.Text = "Get ThumbNail"
        Me.cmdGetThumbNail.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(154, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(146, 13)
        Me.Label13.TabIndex = 1348
        Me.Label13.Text = "Put pdw-hd1550 in Net Mode"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.lblRemainingDuration)
        Me.GroupBox1.Controls.Add(Me.lblActiveID)
        Me.GroupBox1.Controls.Add(Me.cmdGetThumbNail)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblPlayedDuration)
        Me.GroupBox1.Controls.Add(Me.lblClips)
        Me.GroupBox1.Controls.Add(Me.cmddeleteclip)
        Me.GroupBox1.Controls.Add(Me.cmdCueFromClipGrid)
        Me.GroupBox1.Controls.Add(Me.cmdCueFromPlaylist)
        Me.GroupBox1.Controls.Add(Me.lblplaylistname)
        Me.GroupBox1.Controls.Add(Me.chkThumbnail)
        Me.GroupBox1.Controls.Add(Me.cmdmoveup)
        Me.GroupBox1.Controls.Add(Me.dgv1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbClipDrive)
        Me.GroupBox1.Controls.Add(Me.cmdmovedown)
        Me.GroupBox1.Controls.Add(Me.dgvclips)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmdgetclipnames)
        Me.GroupBox1.Controls.Add(Me.cmdinsert)
        Me.GroupBox1.Controls.Add(Me.lblUMID)
        Me.GroupBox1.Controls.Add(Me.tsPlaylist)
        Me.GroupBox1.Controls.Add(Me.cmdStartPlayList)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1220, 770)
        Me.GroupBox1.TabIndex = 1349
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'cmdmoveup
        '
        Me.cmdmoveup.Image = CType(resources.GetObject("cmdmoveup.Image"), System.Drawing.Image)
        Me.cmdmoveup.Location = New System.Drawing.Point(108, 106)
        Me.cmdmoveup.Name = "cmdmoveup"
        Me.cmdmoveup.Size = New System.Drawing.Size(28, 23)
        Me.cmdmoveup.TabIndex = 1332
        Me.cmdmoveup.UseVisualStyleBackColor = True
        '
        'cmdmovedown
        '
        Me.cmdmovedown.Image = CType(resources.GetObject("cmdmovedown.Image"), System.Drawing.Image)
        Me.cmdmovedown.Location = New System.Drawing.Point(137, 106)
        Me.cmdmovedown.Name = "cmdmovedown"
        Me.cmdmovedown.Size = New System.Drawing.Size(24, 23)
        Me.cmdmovedown.TabIndex = 1333
        Me.cmdmovedown.UseVisualStyleBackColor = True
        '
        'cmdinsert
        '
        Me.cmdinsert.Image = CType(resources.GetObject("cmdinsert.Image"), System.Drawing.Image)
        Me.cmdinsert.Location = New System.Drawing.Point(161, 106)
        Me.cmdinsert.Name = "cmdinsert"
        Me.cmdinsert.Size = New System.Drawing.Size(23, 23)
        Me.cmdinsert.TabIndex = 1331
        Me.cmdinsert.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Duration"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "UMMID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn4.Width = 5
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Clips"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 240
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Duration"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "UMMID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn7.Width = 5
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "StartTimeCode"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'ucXdcamSoapClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1221, 749)
        Me.Controls.Add(Me.GroupBox1)
        Me.HideOnClose = True
        Me.Name = "ucXdcamSoapClient"
        Me.Text = "XDCamSoapClient"
        CType(Me.dgvclips, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsdgvclips.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbTrimming.ResumeLayout(False)
        Me.gbTrimming.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.tsPlaylist.ResumeLayout(False)
        Me.tsPlaylist.PerformLayout()
        Me.gbplayer.ResumeLayout(False)
        Me.gbplayer.PerformLayout()
        CType(Me.nvlcspeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbsoap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Trimmer.ResumeLayout(False)
        Me.AddEssenceMark.ResumeLayout(False)
        Me.AddEssenceMark.PerformLayout()
        CType(Me.dgvEssenceMark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SystemFunction.ResumeLayout(False)
        Me.SystemFunction.PerformLayout()
        Me.Settings.ResumeLayout(False)
        Me.Settings.PerformLayout()
        Me.Help.ResumeLayout(False)
        Me.Help.PerformLayout()
        Me.MoreInfo.ResumeLayout(False)
        Me.MoreInfo.PerformLayout()
        Me.Recorder.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblnote As System.Windows.Forms.Label
    Friend WithEvents cmdgetclipnames As System.Windows.Forms.Button
    Friend WithEvents cmdcopy As System.Windows.Forms.Button
    Friend WithEvents cmbdestinationDriveNames As System.Windows.Forms.ComboBox
    Friend WithEvents dgvclips As System.Windows.Forms.DataGridView
    Friend WithEvents lblRemainingDuration As System.Windows.Forms.Label
    Friend WithEvents lblActiveID As System.Windows.Forms.Label
    Friend WithEvents tmrGetTC As System.Windows.Forms.Timer
    Friend WithEvents txtSubClipName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPlayedDuration As System.Windows.Forms.Label
    Friend WithEvents lblnewName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbClipDrive As System.Windows.Forms.ComboBox
    Friend WithEvents cmdOpenRecorder As System.Windows.Forms.Button
    Friend WithEvents txtRecordFileName As System.Windows.Forms.TextBox
    Friend WithEvents cmdCloseRecord As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gbTrimming As System.Windows.Forms.GroupBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents tmrpreview As System.Windows.Forms.Timer
    Friend WithEvents cmdSaveSubClipSopa As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents chkThumbnail As System.Windows.Forms.CheckBox
    Friend WithEvents lblUMID As System.Windows.Forms.Label
    Friend WithEvents cmdCueFromPlaylist As System.Windows.Forms.Button
    Friend WithEvents cmdCueFromClipGrid As System.Windows.Forms.Button
    Friend WithEvents lblClips As System.Windows.Forms.Label
    Friend WithEvents cmdStartPlayList As System.Windows.Forms.Button
    Friend WithEvents tmrNextClipofPlaylist As System.Windows.Forms.Timer
    Friend WithEvents cmddeleteclip As System.Windows.Forms.Button
    Friend WithEvents cmdmoveup As System.Windows.Forms.Button
    Friend WithEvents cmdmovedown As System.Windows.Forms.Button
    Friend WithEvents cmdinsert As System.Windows.Forms.Button
    Friend WithEvents tsPlaylist As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveAsToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblplaylistname As System.Windows.Forms.Label
    Friend WithEvents tmrfornotskipping As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StopF1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CueToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayNextF6ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertBlankToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveUpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveDownToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsdgvclips As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CueInCsparcgToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayInCasparcgToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InserEndToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbplayer As System.Windows.Forms.GroupBox
    Friend WithEvents cmdforwardsecond As System.Windows.Forms.Button
    Friend WithEvents txtforwardsecond As System.Windows.Forms.TextBox
    Friend WithEvents txtgototccasparcgwindow As System.Windows.Forms.TextBox
    Friend WithEvents cmdplayfromout As System.Windows.Forms.Button
    Friend WithEvents cmdgototccasparcgwindow As System.Windows.Forms.Button
    Friend WithEvents cmdplayfromin As System.Windows.Forms.Button
    Friend WithEvents cmdplaylast5seccasaprcgwindow As System.Windows.Forms.Button
    Friend WithEvents cmdgotoend As System.Windows.Forms.Button
    Friend WithEvents lbltimecode As System.Windows.Forms.Label
    Friend WithEvents cmdnextplay As System.Windows.Forms.Button
    Friend WithEvents cmdforwardoneframe As System.Windows.Forms.Button
    Friend WithEvents cmdbackoneframe As System.Windows.Forms.Button
    Friend WithEvents lblCurrentFrame As System.Windows.Forms.Label
    Friend WithEvents cmdgotoout As System.Windows.Forms.Button
    Friend WithEvents cmdgotoin As System.Windows.Forms.Button
    Friend WithEvents cmdmarkout As System.Windows.Forms.Button
    Friend WithEvents cmdmarkin As System.Windows.Forms.Button
    Friend WithEvents txtmarkoutsoap As System.Windows.Forms.TextBox
    Friend WithEvents txtmarkinsoap As System.Windows.Forms.TextBox
    Friend WithEvents lblmin As System.Windows.Forms.Label
    Friend WithEvents lbltbmax As System.Windows.Forms.Label
    Friend WithEvents cmdcueclip As System.Windows.Forms.Button
    Friend WithEvents cmdresume As System.Windows.Forms.Button
    Friend WithEvents cmdcuenext As System.Windows.Forms.Button
    Friend WithEvents cmdPlaySingleClip As System.Windows.Forms.Button
    Friend WithEvents cmdstop As System.Windows.Forms.Button
    Friend WithEvents tbsoap As System.Windows.Forms.TrackBar
    Friend WithEvents cmdpausevdcp As System.Windows.Forms.Button
    Friend WithEvents nvlcspeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdspeed1trimmer As System.Windows.Forms.Button
    Friend WithEvents lbltrimmedduration As System.Windows.Forms.Label
    Friend WithEvents lbloriginalduration As System.Windows.Forms.Label
    Friend WithEvents Label232 As System.Windows.Forms.Label
    Friend WithEvents Label231 As System.Windows.Forms.Label
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenameFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblMoreInfo As System.Windows.Forms.Label
    Friend WithEvents lblMoreInfo2 As System.Windows.Forms.Label
    Friend WithEvents cmdSetXdcam As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Trimmer As System.Windows.Forms.TabPage
    Friend WithEvents Settings As System.Windows.Forms.TabPage
    Friend WithEvents Help As System.Windows.Forms.TabPage
    Friend WithEvents MoreInfo As System.Windows.Forms.TabPage
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbMappedDriveName As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PlayInVlcToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayInVlcToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdFastReverse As System.Windows.Forms.Button
    Friend WithEvents cmdFastFarward As System.Windows.Forms.Button
    Friend WithEvents lblRecorderStatus As System.Windows.Forms.Label
    Friend WithEvents cmdGetRecoredrStatus As System.Windows.Forms.Button
    Friend WithEvents Recorder As System.Windows.Forms.TabPage
    Friend WithEvents tmrRecoderStatus As System.Windows.Forms.Timer
    Friend WithEvents cmdGetThumbNail As System.Windows.Forms.Button
    Friend WithEvents SystemFunction As System.Windows.Forms.TabPage
    Friend WithEvents cmdShutDown As System.Windows.Forms.Button
    Friend WithEvents cdmEject As System.Windows.Forms.Button
    Friend WithEvents cmbEjectDrive As System.Windows.Forms.ComboBox
    Friend WithEvents lblSystemProperties As System.Windows.Forms.Label
    Friend WithEvents cmdGetSystemProperties As System.Windows.Forms.Button
    Friend WithEvents cmdGetSystemStatus As System.Windows.Forms.Button
    Friend WithEvents lblSystemStatus As System.Windows.Forms.Label
    Friend WithEvents lblSystemErrorWarning As System.Windows.Forms.Label
    Friend WithEvents cmdGetSystemErrorWarning As System.Windows.Forms.Button
    Friend WithEvents AddEssenceMark As System.Windows.Forms.TabPage
    Friend WithEvents cmdAddEssenceMark As System.Windows.Forms.Button
    Friend WithEvents dgvEssenceMark As System.Windows.Forms.DataGridView
    Friend WithEvents lblessenceMarkStatus As System.Windows.Forms.Label
    Friend WithEvents txtRecordingDuration As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkPlaySMIasXMF As System.Windows.Forms.CheckBox
    Friend WithEvents PlayInLoopToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayInLoopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbRecordDrive As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdDurationFromVtrControl As System.Windows.Forms.Button
    Friend WithEvents chkTimeLinePlayBackMethod As System.Windows.Forms.CheckBox
    Friend WithEvents cmdRecordfrombeta As System.Windows.Forms.Button
    Friend WithEvents ClipName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Duration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UMMID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartTimeCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Thumbnail As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UMMID1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents UcVTRController1 As ucVTRController
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtipaddress As TextBox
End Class
