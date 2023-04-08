<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucPlaylist
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucPlaylist))
        Me.gbplaylist = New System.Windows.Forms.GroupBox()
        Me.chktemplatewithplaylist = New System.Windows.Forms.CheckBox()
        Me.chkcheckfilesinplaylist = New System.Windows.Forms.CheckBox()
        Me.chkshowthumbnail = New System.Windows.Forms.CheckBox()
        Me.gbnowplaing = New System.Windows.Forms.GroupBox()
        Me.txtbackin = New System.Windows.Forms.TextBox()
        Me.cmdbackin = New System.Windows.Forms.Button()
        Me.cmdstopnowplaying = New System.Windows.Forms.Button()
        Me.txtcommingupnext = New System.Windows.Forms.TextBox()
        Me.cmdnowplaying = New System.Windows.Forms.Button()
        Me.cmdcommingupnext = New System.Windows.Forms.Button()
        Me.cmdremainingdurationofplaylist = New System.Windows.Forms.Button()
        Me.txtremaingdurationofplaylist = New System.Windows.Forms.TextBox()
        Me.cmddurationofplaylist = New System.Windows.Forms.Button()
        Me.txtdurationofplalist = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.File_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Start_Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.x = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Clip_Duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Conversion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FileType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.LoopVideo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Transition = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.T_Duration = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AudioLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFilter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Template_File = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackIn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AMCPCommands = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.PlayInVLCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenInTrimmerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertDecklinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertDecklinkToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertDecklinkToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertDecklinkToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertDecklinkToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertDecklinkToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertDecklinkToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertDecklinkToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertDecklinkToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowLiveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowLiveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowLiveToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowLiveToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowLiveToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowLiveToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowLiveToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowLiveToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowLiveToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshThumbnailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InserEndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeSelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetStartTimeAcoordingToCurrentRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InserPlaylistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertFilterForIMXFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForIMXFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AudioChannelLayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LToBothToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RToBothToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MixToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlyLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlyRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeInterlaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Yadif10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Yadif11ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeAllTransitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WIPEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PUSHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SLIDEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPlayinffplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtfps = New System.Windows.Forms.TextBox()
        Me.lblfps = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.lblplalistname = New System.Windows.Forms.Label()
        Me.cmddeleteclip = New System.Windows.Forms.Button()
        Me.chkplaylistlock = New System.Windows.Forms.CheckBox()
        Me.cmdmoveup = New System.Windows.Forms.Button()
        Me.cmdmovedown = New System.Windows.Forms.Button()
        Me.cmdinsert = New System.Windows.Forms.Button()
        Me.cmdstartplaylist = New System.Windows.Forms.Button()
        Me.btnstartattime = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.gbcliplist = New System.Windows.Forms.GroupBox()
        Me.cmdSmallScreen = New System.Windows.Forms.Button()
        Me.cmdFullScreen = New System.Windows.Forms.Button()
        Me.lblsearch = New System.Windows.Forms.Label()
        Me.Label237 = New System.Windows.Forms.Label()
        Me.pbclipsearchstatus = New System.Windows.Forms.ProgressBar()
        Me.cmdrefreshtvclips = New System.Windows.Forms.Button()
        Me.tvclips = New System.Windows.Forms.TreeView()
        Me.labelclips = New System.Windows.Forms.Label()
        Me.chkclipduration = New System.Windows.Forms.CheckBox()
        Me.dgvclips = New System.Windows.Forms.DataGridView()
        Me.cmsdgvclips = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CueInCsparcgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayInCasparcgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileInformationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdclipsearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.gbplayerforclipgrid = New System.Windows.Forms.GroupBox()
        Me.cmdplaynextforclipgrid = New System.Windows.Forms.Button()
        Me.cmdcuenextforclipgrid = New System.Windows.Forms.Button()
        Me.cmdstopforclipgrid = New System.Windows.Forms.Button()
        Me.cmdresumeforclipgrid = New System.Windows.Forms.Button()
        Me.cmdforwardoneframeforclipgrid = New System.Windows.Forms.Button()
        Me.cmdplayforclipgrid = New System.Windows.Forms.Button()
        Me.cmdbackoneframeforclipgrid = New System.Windows.Forms.Button()
        Me.cmdcueforclipgrid = New System.Windows.Forms.Button()
        Me.cmdpauseforclipgrid = New System.Windows.Forms.Button()
        Me.chkDeinterlace = New System.Windows.Forms.CheckBox()
        Me.chkclipcountdown = New System.Windows.Forms.CheckBox()
        Me.chknextcuefor2ndchannel = New System.Windows.Forms.CheckBox()
        Me.Label220 = New System.Windows.Forms.Label()
        Me.Label221 = New System.Windows.Forms.Label()
        Me.Label222 = New System.Windows.Forms.Label()
        Me.tmrduration = New System.Windows.Forms.Timer(Me.components)
        Me.tmrnextclip = New System.Windows.Forms.Timer(Me.components)
        Me.tmrclipcountdown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrfornotskiping = New System.Windows.Forms.Timer(Me.components)
        Me.tmrcheckfilesinplaylist = New System.Windows.Forms.Timer(Me.components)
        Me.tmrstartattime = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScaleModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STRETCHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FILLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ORIGINALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbplaylist.SuspendLayout()
        Me.gbnowplaing.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.gbcliplist.SuspendLayout()
        CType(Me.dgvclips, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsdgvclips.SuspendLayout()
        Me.gbplayerforclipgrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbplaylist
        '
        Me.gbplaylist.BackColor = System.Drawing.Color.SkyBlue
        Me.gbplaylist.Controls.Add(Me.chktemplatewithplaylist)
        Me.gbplaylist.Controls.Add(Me.chkcheckfilesinplaylist)
        Me.gbplaylist.Controls.Add(Me.chkshowthumbnail)
        Me.gbplaylist.Controls.Add(Me.gbnowplaing)
        Me.gbplaylist.Controls.Add(Me.cmdremainingdurationofplaylist)
        Me.gbplaylist.Controls.Add(Me.txtremaingdurationofplaylist)
        Me.gbplaylist.Controls.Add(Me.cmddurationofplaylist)
        Me.gbplaylist.Controls.Add(Me.txtdurationofplalist)
        Me.gbplaylist.Controls.Add(Me.MenuStrip1)
        Me.gbplaylist.Controls.Add(Me.dgv1)
        Me.gbplaylist.Controls.Add(Me.txtfps)
        Me.gbplaylist.Controls.Add(Me.lblfps)
        Me.gbplaylist.Controls.Add(Me.Label75)
        Me.gbplaylist.Controls.Add(Me.lblplalistname)
        Me.gbplaylist.Controls.Add(Me.cmddeleteclip)
        Me.gbplaylist.Controls.Add(Me.chkplaylistlock)
        Me.gbplaylist.Controls.Add(Me.cmdmoveup)
        Me.gbplaylist.Controls.Add(Me.cmdmovedown)
        Me.gbplaylist.Controls.Add(Me.cmdinsert)
        Me.gbplaylist.Controls.Add(Me.cmdstartplaylist)
        Me.gbplaylist.Controls.Add(Me.btnstartattime)
        Me.gbplaylist.Controls.Add(Me.DateTimePicker1)
        Me.gbplaylist.Controls.Add(Me.gbcliplist)
        Me.gbplaylist.Location = New System.Drawing.Point(2, 2)
        Me.gbplaylist.Name = "gbplaylist"
        Me.gbplaylist.Size = New System.Drawing.Size(1220, 950)
        Me.gbplaylist.TabIndex = 433
        Me.gbplaylist.TabStop = False
        '
        'chktemplatewithplaylist
        '
        Me.chktemplatewithplaylist.AutoSize = True
        Me.chktemplatewithplaylist.Location = New System.Drawing.Point(561, 12)
        Me.chktemplatewithplaylist.Name = "chktemplatewithplaylist"
        Me.chktemplatewithplaylist.Size = New System.Drawing.Size(150, 17)
        Me.chktemplatewithplaylist.TabIndex = 1172
        Me.chktemplatewithplaylist.Text = "Play Template with Playlist"
        Me.chktemplatewithplaylist.UseVisualStyleBackColor = True
        '
        'chkcheckfilesinplaylist
        '
        Me.chkcheckfilesinplaylist.AutoSize = True
        Me.chkcheckfilesinplaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcheckfilesinplaylist.Location = New System.Drawing.Point(728, 47)
        Me.chkcheckfilesinplaylist.Name = "chkcheckfilesinplaylist"
        Me.chkcheckfilesinplaylist.Size = New System.Drawing.Size(73, 16)
        Me.chkcheckfilesinplaylist.TabIndex = 727
        Me.chkcheckfilesinplaylist.Text = "Check Files"
        Me.ToolTip1.SetToolTip(Me.chkcheckfilesinplaylist, "Will check files on disk in interval of 10 second")
        Me.chkcheckfilesinplaylist.UseVisualStyleBackColor = True
        '
        'chkshowthumbnail
        '
        Me.chkshowthumbnail.AutoSize = True
        Me.chkshowthumbnail.Checked = True
        Me.chkshowthumbnail.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkshowthumbnail.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkshowthumbnail.Location = New System.Drawing.Point(728, 29)
        Me.chkshowthumbnail.Name = "chkshowthumbnail"
        Me.chkshowthumbnail.Size = New System.Drawing.Size(66, 16)
        Me.chkshowthumbnail.TabIndex = 726
        Me.chkshowthumbnail.Text = "Thumbnail"
        Me.ToolTip1.SetToolTip(Me.chkshowthumbnail, "Show or not Thumnail on open playlist")
        Me.chkshowthumbnail.UseVisualStyleBackColor = True
        '
        'gbnowplaing
        '
        Me.gbnowplaing.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.gbnowplaing.Controls.Add(Me.txtbackin)
        Me.gbnowplaing.Controls.Add(Me.cmdbackin)
        Me.gbnowplaing.Controls.Add(Me.cmdstopnowplaying)
        Me.gbnowplaing.Controls.Add(Me.txtcommingupnext)
        Me.gbnowplaing.Controls.Add(Me.cmdnowplaying)
        Me.gbnowplaing.Controls.Add(Me.cmdcommingupnext)
        Me.gbnowplaing.Location = New System.Drawing.Point(806, 0)
        Me.gbnowplaing.Name = "gbnowplaing"
        Me.gbnowplaing.Size = New System.Drawing.Size(170, 63)
        Me.gbnowplaing.TabIndex = 724
        Me.gbnowplaing.TabStop = False
        '
        'txtbackin
        '
        Me.txtbackin.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbackin.Location = New System.Drawing.Point(131, 34)
        Me.txtbackin.Name = "txtbackin"
        Me.txtbackin.Size = New System.Drawing.Size(31, 18)
        Me.txtbackin.TabIndex = 725
        Me.txtbackin.Text = "1"
        Me.ToolTip1.SetToolTip(Me.txtbackin, "Clip Number in Playlist")
        '
        'cmdbackin
        '
        Me.cmdbackin.BackColor = System.Drawing.SystemColors.Control
        Me.cmdbackin.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdbackin.Location = New System.Drawing.Point(85, 33)
        Me.cmdbackin.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdbackin.Name = "cmdbackin"
        Me.cmdbackin.Size = New System.Drawing.Size(43, 21)
        Me.cmdbackin.TabIndex = 724
        Me.cmdbackin.Text = "Back in"
        Me.cmdbackin.UseVisualStyleBackColor = False
        '
        'cmdstopnowplaying
        '
        Me.cmdstopnowplaying.BackColor = System.Drawing.SystemColors.Control
        Me.cmdstopnowplaying.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopnowplaying.Location = New System.Drawing.Point(41, 12)
        Me.cmdstopnowplaying.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdstopnowplaying.Name = "cmdstopnowplaying"
        Me.cmdstopnowplaying.Size = New System.Drawing.Size(42, 22)
        Me.cmdstopnowplaying.TabIndex = 723
        Me.cmdstopnowplaying.Text = "Stop"
        Me.cmdstopnowplaying.UseVisualStyleBackColor = False
        '
        'txtcommingupnext
        '
        Me.txtcommingupnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcommingupnext.Location = New System.Drawing.Point(49, 35)
        Me.txtcommingupnext.Name = "txtcommingupnext"
        Me.txtcommingupnext.Size = New System.Drawing.Size(31, 18)
        Me.txtcommingupnext.TabIndex = 722
        Me.txtcommingupnext.Text = "1"
        Me.ToolTip1.SetToolTip(Me.txtcommingupnext, "Clip Number in Playlist")
        '
        'cmdnowplaying
        '
        Me.cmdnowplaying.BackColor = System.Drawing.SystemColors.Control
        Me.cmdnowplaying.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnowplaying.Location = New System.Drawing.Point(5, 12)
        Me.cmdnowplaying.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdnowplaying.Name = "cmdnowplaying"
        Me.cmdnowplaying.Size = New System.Drawing.Size(41, 22)
        Me.cmdnowplaying.TabIndex = 721
        Me.cmdnowplaying.Text = "Now"
        Me.cmdnowplaying.UseVisualStyleBackColor = False
        '
        'cmdcommingupnext
        '
        Me.cmdcommingupnext.BackColor = System.Drawing.SystemColors.Control
        Me.cmdcommingupnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcommingupnext.Location = New System.Drawing.Point(5, 34)
        Me.cmdcommingupnext.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdcommingupnext.Name = "cmdcommingupnext"
        Me.cmdcommingupnext.Size = New System.Drawing.Size(43, 21)
        Me.cmdcommingupnext.TabIndex = 720
        Me.cmdcommingupnext.Text = "Next"
        Me.cmdcommingupnext.UseVisualStyleBackColor = False
        '
        'cmdremainingdurationofplaylist
        '
        Me.cmdremainingdurationofplaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdremainingdurationofplaylist.Location = New System.Drawing.Point(980, 32)
        Me.cmdremainingdurationofplaylist.Name = "cmdremainingdurationofplaylist"
        Me.cmdremainingdurationofplaylist.Size = New System.Drawing.Size(135, 21)
        Me.cmdremainingdurationofplaylist.TabIndex = 645
        Me.cmdremainingdurationofplaylist.Text = "Get Remaining Duration"
        Me.ToolTip1.SetToolTip(Me.cmdremainingdurationofplaylist, "Remaining Duration")
        Me.cmdremainingdurationofplaylist.UseVisualStyleBackColor = True
        '
        'txtremaingdurationofplaylist
        '
        Me.txtremaingdurationofplaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremaingdurationofplaylist.Location = New System.Drawing.Point(1115, 32)
        Me.txtremaingdurationofplaylist.Name = "txtremaingdurationofplaylist"
        Me.txtremaingdurationofplaylist.Size = New System.Drawing.Size(56, 20)
        Me.txtremaingdurationofplaylist.TabIndex = 644
        '
        'cmddurationofplaylist
        '
        Me.cmddurationofplaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddurationofplaylist.Location = New System.Drawing.Point(979, 10)
        Me.cmddurationofplaylist.Name = "cmddurationofplaylist"
        Me.cmddurationofplaylist.Size = New System.Drawing.Size(135, 21)
        Me.cmddurationofplaylist.TabIndex = 643
        Me.cmddurationofplaylist.Text = "Get Total Duration"
        Me.ToolTip1.SetToolTip(Me.cmddurationofplaylist, "Total Duration")
        Me.cmddurationofplaylist.UseVisualStyleBackColor = True
        '
        'txtdurationofplalist
        '
        Me.txtdurationofplalist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdurationofplalist.Location = New System.Drawing.Point(1115, 10)
        Me.txtdurationofplalist.Name = "txtdurationofplalist"
        Me.txtdurationofplalist.Size = New System.Drawing.Size(56, 20)
        Me.txtdurationofplalist.TabIndex = 642
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 15)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(45, 24)
        Me.MenuStrip1.TabIndex = 188
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
        'dgv1
        '
        Me.dgv1.AllowDrop = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv1.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.File_Name, Me.Start_Time, Me.x, Me.Clip_Duration, Me.Conversion, Me.FileType, Me.LoopVideo, Me.Column3, Me.Transition, Me.T_Duration, Me.Column11, Me.AudioLevel, Me.clmFilter, Me.Template_File, Me.BackIn, Me.AMCPCommands})
        Me.dgv1.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv1.Location = New System.Drawing.Point(5, 65)
        Me.dgv1.MultiSelect = False
        Me.dgv1.Name = "dgv1"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv1.RowHeadersWidth = 50
        Me.dgv1.RowTemplate.Height = 30
        Me.dgv1.Size = New System.Drawing.Size(1209, 497)
        Me.dgv1.TabIndex = 634
        '
        'File_Name
        '
        Me.File_Name.Frozen = True
        Me.File_Name.HeaderText = "File_Name"
        Me.File_Name.MinimumWidth = 280
        Me.File_Name.Name = "File_Name"
        Me.File_Name.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.File_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.File_Name.Width = 655
        '
        'Start_Time
        '
        Me.Start_Time.HeaderText = "Start_Time"
        Me.Start_Time.MinimumWidth = 10
        Me.Start_Time.Name = "Start_Time"
        Me.Start_Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Start_Time.Width = 120
        '
        'x
        '
        Me.x.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.x.DefaultCellStyle = DataGridViewCellStyle3
        Me.x.FalseValue = "0"
        Me.x.FillWeight = 20.0!
        Me.x.HeaderText = "Play"
        Me.x.Name = "x"
        Me.x.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.x.TrueValue = "1"
        Me.x.Width = 30
        '
        'Clip_Duration
        '
        Me.Clip_Duration.HeaderText = "Duration"
        Me.Clip_Duration.MinimumWidth = 10
        Me.Clip_Duration.Name = "Clip_Duration"
        Me.Clip_Duration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Clip_Duration.Width = 120
        '
        'Conversion
        '
        Me.Conversion.FalseValue = "0"
        Me.Conversion.HeaderText = "Cnvrsn"
        Me.Conversion.MinimumWidth = 45
        Me.Conversion.Name = "Conversion"
        Me.Conversion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Conversion.TrueValue = "1"
        Me.Conversion.Width = 45
        '
        'FileType
        '
        Me.FileType.HeaderText = "FileType"
        Me.FileType.Items.AddRange(New Object() {"Program", "Promo", "Commercial", "Others"})
        Me.FileType.Name = "FileType"
        Me.FileType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FileType.Width = 90
        '
        'LoopVideo
        '
        Me.LoopVideo.HeaderText = "Loop"
        Me.LoopVideo.Name = "LoopVideo"
        Me.LoopVideo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LoopVideo.TrueValue = "loop"
        Me.LoopVideo.Width = 35
        '
        'Column3
        '
        Me.Column3.HeaderText = "Thumbnail"
        Me.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column3.MinimumWidth = 70
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.Width = 70
        '
        'Transition
        '
        Me.Transition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Transition.HeaderText = "Transition"
        Me.Transition.Items.AddRange(New Object() {"CUT", "MIX", "PUSH", "WIPE", "SLIDE"})
        Me.Transition.Name = "Transition"
        Me.Transition.Width = 60
        '
        'T_Duration
        '
        Me.T_Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.T_Duration.HeaderText = "frame"
        Me.T_Duration.Items.AddRange(New Object() {"10", "15", "20", "25", "30", "35", "40", "45", "50"})
        Me.T_Duration.Name = "T_Duration"
        Me.T_Duration.Width = 50
        '
        'Column11
        '
        Me.Column11.HeaderText = "Follow Duration"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 50
        '
        'AudioLevel
        '
        Me.AudioLevel.HeaderText = "Audio Level"
        Me.AudioLevel.Name = "AudioLevel"
        Me.AudioLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AudioLevel.Width = 40
        '
        'clmFilter
        '
        Me.clmFilter.HeaderText = "Filter"
        Me.clmFilter.Name = "clmFilter"
        Me.clmFilter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Template_File
        '
        Me.Template_File.HeaderText = "Template File"
        Me.Template_File.Name = "Template_File"
        Me.Template_File.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Template_File.Width = 200
        '
        'BackIn
        '
        Me.BackIn.FalseValue = "0"
        Me.BackIn.HeaderText = "Back In"
        Me.BackIn.Name = "BackIn"
        Me.BackIn.TrueValue = "1"
        Me.BackIn.Width = 35
        '
        'AMCPCommands
        '
        Me.AMCPCommands.HeaderText = "AMCP Commands"
        Me.AMCPCommands.Name = "AMCPCommands"
        Me.AMCPCommands.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StopF1ToolStripMenuItem, Me.PlayToolStripMenuItem1, Me.CueToolStripMenuItem1, Me.PauseToolStripMenuItem1, Me.ResumeToolStripMenuItem1, Me.NextToolStripMenuItem1, Me.PlayNextF6ToolStripMenuItem, Me.InsertBlankToolStripMenuItem, Me.DeleteToolStripMenuItem1, Me.CopyToolStripMenuItem1, Me.PasteToolStripMenuItem1, Me.MoveUpToolStripMenuItem1, Me.MoveDownToolStripMenuItem1, Me.PlayInVLCToolStripMenuItem, Me.CheckFilesToolStripMenuItem, Me.OpenInTrimmerToolStripMenuItem, Me.FileInformationToolStripMenuItem, Me.InsertDecklinkToolStripMenuItem, Me.ShowLiveToolStripMenuItem, Me.RefreshThumbnailToolStripMenuItem, Me.InserEndToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.DeSelectAllToolStripMenuItem, Me.SetStartTimeAcoordingToCurrentRowToolStripMenuItem, Me.InserPlaylistToolStripMenuItem, Me.InsertFilterForIMXFile, Me.ChangeAllTransitionToolStripMenuItem, Me.mnuPlayinffplay})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(287, 620)
        '
        'StopF1ToolStripMenuItem
        '
        Me.StopF1ToolStripMenuItem.Name = "StopF1ToolStripMenuItem"
        Me.StopF1ToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.StopF1ToolStripMenuItem.Text = "Stop F1"
        '
        'PlayToolStripMenuItem1
        '
        Me.PlayToolStripMenuItem1.Name = "PlayToolStripMenuItem1"
        Me.PlayToolStripMenuItem1.Size = New System.Drawing.Size(286, 22)
        Me.PlayToolStripMenuItem1.Text = "Play F2"
        '
        'CueToolStripMenuItem1
        '
        Me.CueToolStripMenuItem1.Name = "CueToolStripMenuItem1"
        Me.CueToolStripMenuItem1.Size = New System.Drawing.Size(286, 22)
        Me.CueToolStripMenuItem1.Text = "Cue F3"
        '
        'PauseToolStripMenuItem1
        '
        Me.PauseToolStripMenuItem1.Name = "PauseToolStripMenuItem1"
        Me.PauseToolStripMenuItem1.Size = New System.Drawing.Size(286, 22)
        Me.PauseToolStripMenuItem1.Text = "Pause F4"
        '
        'ResumeToolStripMenuItem1
        '
        Me.ResumeToolStripMenuItem1.Name = "ResumeToolStripMenuItem1"
        Me.ResumeToolStripMenuItem1.Size = New System.Drawing.Size(286, 22)
        Me.ResumeToolStripMenuItem1.Text = "Resume F4"
        '
        'NextToolStripMenuItem1
        '
        Me.NextToolStripMenuItem1.Name = "NextToolStripMenuItem1"
        Me.NextToolStripMenuItem1.Size = New System.Drawing.Size(286, 22)
        Me.NextToolStripMenuItem1.Text = "Cue Next F5"
        '
        'PlayNextF6ToolStripMenuItem
        '
        Me.PlayNextF6ToolStripMenuItem.Name = "PlayNextF6ToolStripMenuItem"
        Me.PlayNextF6ToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.PlayNextF6ToolStripMenuItem.Text = "Play Next F6"
        '
        'InsertBlankToolStripMenuItem
        '
        Me.InsertBlankToolStripMenuItem.Name = "InsertBlankToolStripMenuItem"
        Me.InsertBlankToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.InsertBlankToolStripMenuItem.Text = "Insert Blank"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(286, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'CopyToolStripMenuItem1
        '
        Me.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1"
        Me.CopyToolStripMenuItem1.Size = New System.Drawing.Size(286, 22)
        Me.CopyToolStripMenuItem1.Text = "Copy"
        '
        'PasteToolStripMenuItem1
        '
        Me.PasteToolStripMenuItem1.Name = "PasteToolStripMenuItem1"
        Me.PasteToolStripMenuItem1.Size = New System.Drawing.Size(286, 22)
        Me.PasteToolStripMenuItem1.Text = "Paste"
        '
        'MoveUpToolStripMenuItem1
        '
        Me.MoveUpToolStripMenuItem1.Name = "MoveUpToolStripMenuItem1"
        Me.MoveUpToolStripMenuItem1.Size = New System.Drawing.Size(286, 22)
        Me.MoveUpToolStripMenuItem1.Text = "Move Up"
        '
        'MoveDownToolStripMenuItem1
        '
        Me.MoveDownToolStripMenuItem1.Name = "MoveDownToolStripMenuItem1"
        Me.MoveDownToolStripMenuItem1.Size = New System.Drawing.Size(286, 22)
        Me.MoveDownToolStripMenuItem1.Text = "Move Down"
        '
        'PlayInVLCToolStripMenuItem
        '
        Me.PlayInVLCToolStripMenuItem.Name = "PlayInVLCToolStripMenuItem"
        Me.PlayInVLCToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.PlayInVLCToolStripMenuItem.Text = "Play in VLC"
        '
        'CheckFilesToolStripMenuItem
        '
        Me.CheckFilesToolStripMenuItem.Name = "CheckFilesToolStripMenuItem"
        Me.CheckFilesToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.CheckFilesToolStripMenuItem.Text = "Check Files"
        '
        'OpenInTrimmerToolStripMenuItem
        '
        Me.OpenInTrimmerToolStripMenuItem.Name = "OpenInTrimmerToolStripMenuItem"
        Me.OpenInTrimmerToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.OpenInTrimmerToolStripMenuItem.Text = "Open in Trimmer"
        '
        'FileInformationToolStripMenuItem
        '
        Me.FileInformationToolStripMenuItem.Name = "FileInformationToolStripMenuItem"
        Me.FileInformationToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.FileInformationToolStripMenuItem.Text = "File information"
        '
        'InsertDecklinkToolStripMenuItem
        '
        Me.InsertDecklinkToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertDecklinkToolStripMenuItem1, Me.InsertDecklinkToolStripMenuItem2, Me.InsertDecklinkToolStripMenuItem3, Me.InsertDecklinkToolStripMenuItem4, Me.InsertDecklinkToolStripMenuItem5, Me.InsertDecklinkToolStripMenuItem6, Me.InsertDecklinkToolStripMenuItem7, Me.InsertDecklinkToolStripMenuItem8})
        Me.InsertDecklinkToolStripMenuItem.Name = "InsertDecklinkToolStripMenuItem"
        Me.InsertDecklinkToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.InsertDecklinkToolStripMenuItem.Text = "Insert Decklink"
        '
        'InsertDecklinkToolStripMenuItem1
        '
        Me.InsertDecklinkToolStripMenuItem1.Name = "InsertDecklinkToolStripMenuItem1"
        Me.InsertDecklinkToolStripMenuItem1.Size = New System.Drawing.Size(80, 22)
        Me.InsertDecklinkToolStripMenuItem1.Text = "1"
        '
        'InsertDecklinkToolStripMenuItem2
        '
        Me.InsertDecklinkToolStripMenuItem2.Name = "InsertDecklinkToolStripMenuItem2"
        Me.InsertDecklinkToolStripMenuItem2.Size = New System.Drawing.Size(80, 22)
        Me.InsertDecklinkToolStripMenuItem2.Text = "2"
        '
        'InsertDecklinkToolStripMenuItem3
        '
        Me.InsertDecklinkToolStripMenuItem3.Name = "InsertDecklinkToolStripMenuItem3"
        Me.InsertDecklinkToolStripMenuItem3.Size = New System.Drawing.Size(80, 22)
        Me.InsertDecklinkToolStripMenuItem3.Text = "3"
        '
        'InsertDecklinkToolStripMenuItem4
        '
        Me.InsertDecklinkToolStripMenuItem4.Name = "InsertDecklinkToolStripMenuItem4"
        Me.InsertDecklinkToolStripMenuItem4.Size = New System.Drawing.Size(80, 22)
        Me.InsertDecklinkToolStripMenuItem4.Text = "4"
        '
        'InsertDecklinkToolStripMenuItem5
        '
        Me.InsertDecklinkToolStripMenuItem5.Name = "InsertDecklinkToolStripMenuItem5"
        Me.InsertDecklinkToolStripMenuItem5.Size = New System.Drawing.Size(80, 22)
        Me.InsertDecklinkToolStripMenuItem5.Text = "5"
        '
        'InsertDecklinkToolStripMenuItem6
        '
        Me.InsertDecklinkToolStripMenuItem6.Name = "InsertDecklinkToolStripMenuItem6"
        Me.InsertDecklinkToolStripMenuItem6.Size = New System.Drawing.Size(80, 22)
        Me.InsertDecklinkToolStripMenuItem6.Text = "6"
        '
        'InsertDecklinkToolStripMenuItem7
        '
        Me.InsertDecklinkToolStripMenuItem7.Name = "InsertDecklinkToolStripMenuItem7"
        Me.InsertDecklinkToolStripMenuItem7.Size = New System.Drawing.Size(80, 22)
        Me.InsertDecklinkToolStripMenuItem7.Text = "7"
        '
        'InsertDecklinkToolStripMenuItem8
        '
        Me.InsertDecklinkToolStripMenuItem8.Name = "InsertDecklinkToolStripMenuItem8"
        Me.InsertDecklinkToolStripMenuItem8.Size = New System.Drawing.Size(80, 22)
        Me.InsertDecklinkToolStripMenuItem8.Text = "8"
        '
        'ShowLiveToolStripMenuItem
        '
        Me.ShowLiveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowLiveToolStripMenuItem1, Me.ShowLiveToolStripMenuItem2, Me.ShowLiveToolStripMenuItem3, Me.ShowLiveToolStripMenuItem4, Me.ShowLiveToolStripMenuItem5, Me.ShowLiveToolStripMenuItem6, Me.ShowLiveToolStripMenuItem7, Me.ShowLiveToolStripMenuItem8})
        Me.ShowLiveToolStripMenuItem.Name = "ShowLiveToolStripMenuItem"
        Me.ShowLiveToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.ShowLiveToolStripMenuItem.Text = "Show Live Decklink"
        '
        'ShowLiveToolStripMenuItem1
        '
        Me.ShowLiveToolStripMenuItem1.Name = "ShowLiveToolStripMenuItem1"
        Me.ShowLiveToolStripMenuItem1.Size = New System.Drawing.Size(80, 22)
        Me.ShowLiveToolStripMenuItem1.Text = "1"
        '
        'ShowLiveToolStripMenuItem2
        '
        Me.ShowLiveToolStripMenuItem2.Name = "ShowLiveToolStripMenuItem2"
        Me.ShowLiveToolStripMenuItem2.Size = New System.Drawing.Size(80, 22)
        Me.ShowLiveToolStripMenuItem2.Text = "2"
        '
        'ShowLiveToolStripMenuItem3
        '
        Me.ShowLiveToolStripMenuItem3.Name = "ShowLiveToolStripMenuItem3"
        Me.ShowLiveToolStripMenuItem3.Size = New System.Drawing.Size(80, 22)
        Me.ShowLiveToolStripMenuItem3.Text = "3"
        '
        'ShowLiveToolStripMenuItem4
        '
        Me.ShowLiveToolStripMenuItem4.Name = "ShowLiveToolStripMenuItem4"
        Me.ShowLiveToolStripMenuItem4.Size = New System.Drawing.Size(80, 22)
        Me.ShowLiveToolStripMenuItem4.Text = "4"
        '
        'ShowLiveToolStripMenuItem5
        '
        Me.ShowLiveToolStripMenuItem5.Name = "ShowLiveToolStripMenuItem5"
        Me.ShowLiveToolStripMenuItem5.Size = New System.Drawing.Size(80, 22)
        Me.ShowLiveToolStripMenuItem5.Text = "5"
        '
        'ShowLiveToolStripMenuItem6
        '
        Me.ShowLiveToolStripMenuItem6.Name = "ShowLiveToolStripMenuItem6"
        Me.ShowLiveToolStripMenuItem6.Size = New System.Drawing.Size(80, 22)
        Me.ShowLiveToolStripMenuItem6.Text = "6"
        '
        'ShowLiveToolStripMenuItem7
        '
        Me.ShowLiveToolStripMenuItem7.Name = "ShowLiveToolStripMenuItem7"
        Me.ShowLiveToolStripMenuItem7.Size = New System.Drawing.Size(80, 22)
        Me.ShowLiveToolStripMenuItem7.Text = "7"
        '
        'ShowLiveToolStripMenuItem8
        '
        Me.ShowLiveToolStripMenuItem8.Name = "ShowLiveToolStripMenuItem8"
        Me.ShowLiveToolStripMenuItem8.Size = New System.Drawing.Size(80, 22)
        Me.ShowLiveToolStripMenuItem8.Text = "8"
        '
        'RefreshThumbnailToolStripMenuItem
        '
        Me.RefreshThumbnailToolStripMenuItem.Name = "RefreshThumbnailToolStripMenuItem"
        Me.RefreshThumbnailToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.RefreshThumbnailToolStripMenuItem.Text = "Refresh Thumbnail"
        '
        'InserEndToolStripMenuItem
        '
        Me.InserEndToolStripMenuItem.Name = "InserEndToolStripMenuItem"
        Me.InserEndToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.InserEndToolStripMenuItem.Text = "Inser End"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'DeSelectAllToolStripMenuItem
        '
        Me.DeSelectAllToolStripMenuItem.Name = "DeSelectAllToolStripMenuItem"
        Me.DeSelectAllToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.DeSelectAllToolStripMenuItem.Text = "De Select All"
        '
        'SetStartTimeAcoordingToCurrentRowToolStripMenuItem
        '
        Me.SetStartTimeAcoordingToCurrentRowToolStripMenuItem.Name = "SetStartTimeAcoordingToCurrentRowToolStripMenuItem"
        Me.SetStartTimeAcoordingToCurrentRowToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.SetStartTimeAcoordingToCurrentRowToolStripMenuItem.Text = "Set Start Time Acoording To CurrentRow"
        '
        'InserPlaylistToolStripMenuItem
        '
        Me.InserPlaylistToolStripMenuItem.Name = "InserPlaylistToolStripMenuItem"
        Me.InserPlaylistToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.InserPlaylistToolStripMenuItem.Text = "Insert Playlist"
        '
        'InsertFilterForIMXFile
        '
        Me.InsertFilterForIMXFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForIMXFileToolStripMenuItem, Me.AudioChannelLayoutToolStripMenuItem, Me.DeInterlaceToolStripMenuItem, Me.ScaleModeToolStripMenuItem})
        Me.InsertFilterForIMXFile.Name = "InsertFilterForIMXFile"
        Me.InsertFilterForIMXFile.Size = New System.Drawing.Size(286, 22)
        Me.InsertFilterForIMXFile.Text = "Insert Filter"
        '
        'ForIMXFileToolStripMenuItem
        '
        Me.ForIMXFileToolStripMenuItem.Name = "ForIMXFileToolStripMenuItem"
        Me.ForIMXFileToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ForIMXFileToolStripMenuItem.Text = "For IMX File"
        '
        'AudioChannelLayoutToolStripMenuItem
        '
        Me.AudioChannelLayoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LToBothToolStripMenuItem, Me.RToBothToolStripMenuItem, Me.MixToolStripMenuItem1, Me.OnlyLToolStripMenuItem, Me.OnlyRToolStripMenuItem})
        Me.AudioChannelLayoutToolStripMenuItem.Name = "AudioChannelLayoutToolStripMenuItem"
        Me.AudioChannelLayoutToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AudioChannelLayoutToolStripMenuItem.Text = "Audio Channel Layout"
        '
        'LToBothToolStripMenuItem
        '
        Me.LToBothToolStripMenuItem.Name = "LToBothToolStripMenuItem"
        Me.LToBothToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.LToBothToolStripMenuItem.Text = "L_To_Both"
        '
        'RToBothToolStripMenuItem
        '
        Me.RToBothToolStripMenuItem.Name = "RToBothToolStripMenuItem"
        Me.RToBothToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.RToBothToolStripMenuItem.Text = "R_To_Both"
        '
        'MixToolStripMenuItem1
        '
        Me.MixToolStripMenuItem1.Name = "MixToolStripMenuItem1"
        Me.MixToolStripMenuItem1.Size = New System.Drawing.Size(128, 22)
        Me.MixToolStripMenuItem1.Text = "Mix"
        '
        'OnlyLToolStripMenuItem
        '
        Me.OnlyLToolStripMenuItem.Name = "OnlyLToolStripMenuItem"
        Me.OnlyLToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.OnlyLToolStripMenuItem.Text = "Only_L"
        '
        'OnlyRToolStripMenuItem
        '
        Me.OnlyRToolStripMenuItem.Name = "OnlyRToolStripMenuItem"
        Me.OnlyRToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.OnlyRToolStripMenuItem.Text = "Only_R"
        '
        'DeInterlaceToolStripMenuItem
        '
        Me.DeInterlaceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Yadif10ToolStripMenuItem, Me.Yadif11ToolStripMenuItem})
        Me.DeInterlaceToolStripMenuItem.Name = "DeInterlaceToolStripMenuItem"
        Me.DeInterlaceToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.DeInterlaceToolStripMenuItem.Text = "DeInterlace"
        '
        'Yadif10ToolStripMenuItem
        '
        Me.Yadif10ToolStripMenuItem.Name = "Yadif10ToolStripMenuItem"
        Me.Yadif10ToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.Yadif10ToolStripMenuItem.Text = "yadif=1:0"
        '
        'Yadif11ToolStripMenuItem
        '
        Me.Yadif11ToolStripMenuItem.Name = "Yadif11ToolStripMenuItem"
        Me.Yadif11ToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.Yadif11ToolStripMenuItem.Text = "yadif=1:1"
        '
        'ChangeAllTransitionToolStripMenuItem
        '
        Me.ChangeAllTransitionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MIXToolStripMenuItem, Me.CutToolStripMenuItem, Me.WIPEToolStripMenuItem, Me.PUSHToolStripMenuItem, Me.SLIDEToolStripMenuItem})
        Me.ChangeAllTransitionToolStripMenuItem.Name = "ChangeAllTransitionToolStripMenuItem"
        Me.ChangeAllTransitionToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.ChangeAllTransitionToolStripMenuItem.Text = "Change All Transition"
        '
        'MIXToolStripMenuItem
        '
        Me.MIXToolStripMenuItem.Name = "MIXToolStripMenuItem"
        Me.MIXToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.MIXToolStripMenuItem.Text = "MIX"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.CutToolStripMenuItem.Text = "CUT"
        '
        'WIPEToolStripMenuItem
        '
        Me.WIPEToolStripMenuItem.Name = "WIPEToolStripMenuItem"
        Me.WIPEToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.WIPEToolStripMenuItem.Text = "WIPE"
        '
        'PUSHToolStripMenuItem
        '
        Me.PUSHToolStripMenuItem.Name = "PUSHToolStripMenuItem"
        Me.PUSHToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.PUSHToolStripMenuItem.Text = "PUSH"
        '
        'SLIDEToolStripMenuItem
        '
        Me.SLIDEToolStripMenuItem.Name = "SLIDEToolStripMenuItem"
        Me.SLIDEToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.SLIDEToolStripMenuItem.Text = "SLIDE"
        '
        'mnuPlayinffplay
        '
        Me.mnuPlayinffplay.Name = "mnuPlayinffplay"
        Me.mnuPlayinffplay.Size = New System.Drawing.Size(286, 22)
        Me.mnuPlayinffplay.Text = "Play in ffplay"
        '
        'txtfps
        '
        Me.txtfps.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtfps", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtfps.Location = New System.Drawing.Point(210, 37)
        Me.txtfps.Name = "txtfps"
        Me.txtfps.Size = New System.Drawing.Size(42, 20)
        Me.txtfps.TabIndex = 446
        Me.txtfps.Text = "25"
        Me.txtfps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtfps, "Channel FrameRate")
        '
        'lblfps
        '
        Me.lblfps.AutoSize = True
        Me.lblfps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfps.Location = New System.Drawing.Point(176, 41)
        Me.lblfps.Name = "lblfps"
        Me.lblfps.Size = New System.Drawing.Size(30, 13)
        Me.lblfps.TabIndex = 445
        Me.lblfps.Text = "FPS"
        '
        'Label75
        '
        Me.Label75.Location = New System.Drawing.Point(447, 347)
        Me.Label75.MaximumSize = New System.Drawing.Size(300, 0)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(200, 0)
        Me.Label75.TabIndex = 438
        Me.Label75.Text = "Template will be played  from template module's rundown's current row"
        '
        'lblplalistname
        '
        Me.lblplalistname.AutoSize = True
        Me.lblplalistname.Location = New System.Drawing.Point(53, 9)
        Me.lblplalistname.MaximumSize = New System.Drawing.Size(510, 0)
        Me.lblplalistname.Name = "lblplalistname"
        Me.lblplalistname.Size = New System.Drawing.Size(76, 13)
        Me.lblplalistname.TabIndex = 434
        Me.lblplalistname.Text = "Default Playlist"
        '
        'cmddeleteclip
        '
        Me.cmddeleteclip.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddeleteclip.Image = Global.caspar_media_playback.My.Resources.Resources.minus
        Me.cmddeleteclip.Location = New System.Drawing.Point(406, 37)
        Me.cmddeleteclip.Name = "cmddeleteclip"
        Me.cmddeleteclip.Size = New System.Drawing.Size(52, 22)
        Me.cmddeleteclip.TabIndex = 429
        Me.ToolTip1.SetToolTip(Me.cmddeleteclip, "Remove Selected Row")
        Me.cmddeleteclip.UseVisualStyleBackColor = True
        '
        'chkplaylistlock
        '
        Me.chkplaylistlock.AutoSize = True
        Me.chkplaylistlock.Checked = Global.caspar_media_playback.My.MySettings.Default.chkplaylistlock
        Me.chkplaylistlock.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.caspar_media_playback.My.MySettings.Default, "chkplaylistlock", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkplaylistlock.Location = New System.Drawing.Point(727, 11)
        Me.chkplaylistlock.Name = "chkplaylistlock"
        Me.chkplaylistlock.Size = New System.Drawing.Size(50, 17)
        Me.chkplaylistlock.TabIndex = 428
        Me.chkplaylistlock.Text = "Lock"
        Me.ToolTip1.SetToolTip(Me.chkplaylistlock, "Lock The Playlist")
        Me.chkplaylistlock.UseVisualStyleBackColor = True
        '
        'cmdmoveup
        '
        Me.cmdmoveup.Image = Global.caspar_media_playback.My.Resources.Resources.UP
        Me.cmdmoveup.Location = New System.Drawing.Point(252, 37)
        Me.cmdmoveup.Name = "cmdmoveup"
        Me.cmdmoveup.Size = New System.Drawing.Size(49, 23)
        Me.cmdmoveup.TabIndex = 163
        Me.ToolTip1.SetToolTip(Me.cmdmoveup, "Move Up Selected Row")
        Me.cmdmoveup.UseVisualStyleBackColor = True
        '
        'cmdmovedown
        '
        Me.cmdmovedown.Image = Global.caspar_media_playback.My.Resources.Resources.Down
        Me.cmdmovedown.Location = New System.Drawing.Point(301, 37)
        Me.cmdmovedown.Name = "cmdmovedown"
        Me.cmdmovedown.Size = New System.Drawing.Size(50, 23)
        Me.cmdmovedown.TabIndex = 164
        Me.ToolTip1.SetToolTip(Me.cmdmovedown, "Move down Selected Row")
        Me.cmdmovedown.UseVisualStyleBackColor = True
        '
        'cmdinsert
        '
        Me.cmdinsert.Image = Global.caspar_media_playback.My.Resources.Resources.Add
        Me.cmdinsert.Location = New System.Drawing.Point(353, 37)
        Me.cmdinsert.Name = "cmdinsert"
        Me.cmdinsert.Size = New System.Drawing.Size(49, 23)
        Me.cmdinsert.TabIndex = 161
        Me.ToolTip1.SetToolTip(Me.cmdinsert, "Insert A new Row Below Selected Row")
        Me.cmdinsert.UseVisualStyleBackColor = True
        '
        'cmdstartplaylist
        '
        Me.cmdstartplaylist.Location = New System.Drawing.Point(87, 37)
        Me.cmdstartplaylist.Name = "cmdstartplaylist"
        Me.cmdstartplaylist.Size = New System.Drawing.Size(89, 23)
        Me.cmdstartplaylist.TabIndex = 81
        Me.cmdstartplaylist.Text = "Start Playlist"
        Me.cmdstartplaylist.UseVisualStyleBackColor = True
        '
        'btnstartattime
        '
        Me.btnstartattime.Location = New System.Drawing.Point(468, 36)
        Me.btnstartattime.Name = "btnstartattime"
        Me.btnstartattime.Size = New System.Drawing.Size(96, 23)
        Me.btnstartattime.TabIndex = 83
        Me.btnstartattime.Text = "Start Playlist at"
        Me.btnstartattime.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(566, 37)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(145, 22)
        Me.DateTimePicker1.TabIndex = 84
        Me.DateTimePicker1.Value = New Date(2014, 10, 3, 0, 0, 0, 0)
        '
        'gbcliplist
        '
        Me.gbcliplist.BackColor = System.Drawing.Color.Thistle
        Me.gbcliplist.Controls.Add(Me.cmdSmallScreen)
        Me.gbcliplist.Controls.Add(Me.cmdFullScreen)
        Me.gbcliplist.Controls.Add(Me.lblsearch)
        Me.gbcliplist.Controls.Add(Me.Label237)
        Me.gbcliplist.Controls.Add(Me.pbclipsearchstatus)
        Me.gbcliplist.Controls.Add(Me.cmdrefreshtvclips)
        Me.gbcliplist.Controls.Add(Me.tvclips)
        Me.gbcliplist.Controls.Add(Me.labelclips)
        Me.gbcliplist.Controls.Add(Me.chkclipduration)
        Me.gbcliplist.Controls.Add(Me.dgvclips)
        Me.gbcliplist.Controls.Add(Me.cmdclipsearch)
        Me.gbcliplist.Controls.Add(Me.txtsearch)
        Me.gbcliplist.Controls.Add(Me.gbplayerforclipgrid)
        Me.gbcliplist.Location = New System.Drawing.Point(8, 565)
        Me.gbcliplist.Name = "gbcliplist"
        Me.gbcliplist.Size = New System.Drawing.Size(1189, 373)
        Me.gbcliplist.TabIndex = 1171
        Me.gbcliplist.TabStop = False
        Me.gbcliplist.Text = "ClipGrid"
        '
        'cmdSmallScreen
        '
        Me.cmdSmallScreen.Location = New System.Drawing.Point(1096, 10)
        Me.cmdSmallScreen.Name = "cmdSmallScreen"
        Me.cmdSmallScreen.Size = New System.Drawing.Size(83, 23)
        Me.cmdSmallScreen.TabIndex = 1172
        Me.cmdSmallScreen.Text = "Small Screen"
        Me.cmdSmallScreen.UseVisualStyleBackColor = True
        '
        'cmdFullScreen
        '
        Me.cmdFullScreen.Location = New System.Drawing.Point(1015, 9)
        Me.cmdFullScreen.Name = "cmdFullScreen"
        Me.cmdFullScreen.Size = New System.Drawing.Size(75, 23)
        Me.cmdFullScreen.TabIndex = 1171
        Me.cmdFullScreen.Text = "Full Screen"
        Me.cmdFullScreen.UseVisualStyleBackColor = True
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.Location = New System.Drawing.Point(101, 13)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(0, 13)
        Me.lblsearch.TabIndex = 187
        '
        'Label237
        '
        Me.Label237.AutoSize = True
        Me.Label237.Location = New System.Drawing.Point(710, 13)
        Me.Label237.Name = "Label237"
        Me.Label237.Size = New System.Drawing.Size(31, 13)
        Me.Label237.TabIndex = 186
        Me.Label237.Text = "Total"
        '
        'pbclipsearchstatus
        '
        Me.pbclipsearchstatus.Location = New System.Drawing.Point(301, 32)
        Me.pbclipsearchstatus.Name = "pbclipsearchstatus"
        Me.pbclipsearchstatus.Size = New System.Drawing.Size(905, 6)
        Me.pbclipsearchstatus.TabIndex = 185
        '
        'cmdrefreshtvclips
        '
        Me.cmdrefreshtvclips.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdrefreshtvclips.Location = New System.Drawing.Point(5, 14)
        Me.cmdrefreshtvclips.Name = "cmdrefreshtvclips"
        Me.cmdrefreshtvclips.Size = New System.Drawing.Size(94, 21)
        Me.cmdrefreshtvclips.TabIndex = 184
        Me.cmdrefreshtvclips.Text = "Refresh Folders"
        Me.ToolTip1.SetToolTip(Me.cmdrefreshtvclips, "Refresh If new Folders has been Created")
        Me.cmdrefreshtvclips.UseVisualStyleBackColor = True
        '
        'tvclips
        '
        Me.tvclips.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvclips.Location = New System.Drawing.Point(6, 40)
        Me.tvclips.Name = "tvclips"
        Me.tvclips.Size = New System.Drawing.Size(291, 289)
        Me.tvclips.TabIndex = 183
        Me.ToolTip1.SetToolTip(Me.tvclips, "Folders in Media Directory")
        '
        'labelclips
        '
        Me.labelclips.AutoSize = True
        Me.labelclips.Location = New System.Drawing.Point(748, 12)
        Me.labelclips.Name = "labelclips"
        Me.labelclips.Size = New System.Drawing.Size(29, 13)
        Me.labelclips.TabIndex = 182
        Me.labelclips.Text = "Clips"
        '
        'chkclipduration
        '
        Me.chkclipduration.AutoSize = True
        Me.chkclipduration.Location = New System.Drawing.Point(804, 12)
        Me.chkclipduration.Name = "chkclipduration"
        Me.chkclipduration.Size = New System.Drawing.Size(213, 17)
        Me.chkclipduration.TabIndex = 178
        Me.chkclipduration.Text = "Duration And SIze  (Will take more time)"
        Me.chkclipduration.UseVisualStyleBackColor = True
        '
        'dgvclips
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvclips.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvclips.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvclips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvclips.ContextMenuStrip = Me.cmsdgvclips
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvclips.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvclips.Location = New System.Drawing.Point(301, 41)
        Me.dgvclips.MultiSelect = False
        Me.dgvclips.Name = "dgvclips"
        Me.dgvclips.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvclips.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvclips.RowHeadersWidth = 25
        Me.dgvclips.RowTemplate.Height = 30
        Me.dgvclips.Size = New System.Drawing.Size(878, 219)
        Me.dgvclips.TabIndex = 177
        '
        'cmsdgvclips
        '
        Me.cmsdgvclips.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CueInCsparcgToolStripMenuItem, Me.PlayInCasparcgToolStripMenuItem, Me.ToolStripMenuItem1, Me.FileInformationToolStripMenuItem1})
        Me.cmsdgvclips.Name = "ContextMenuStrip2"
        Me.cmsdgvclips.Size = New System.Drawing.Size(159, 92)
        '
        'CueInCsparcgToolStripMenuItem
        '
        Me.CueInCsparcgToolStripMenuItem.Name = "CueInCsparcgToolStripMenuItem"
        Me.CueInCsparcgToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.CueInCsparcgToolStripMenuItem.Text = "Cue"
        '
        'PlayInCasparcgToolStripMenuItem
        '
        Me.PlayInCasparcgToolStripMenuItem.Name = "PlayInCasparcgToolStripMenuItem"
        Me.PlayInCasparcgToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.PlayInCasparcgToolStripMenuItem.Text = "Play"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
        Me.ToolStripMenuItem1.Text = "Play in VLC"
        '
        'FileInformationToolStripMenuItem1
        '
        Me.FileInformationToolStripMenuItem1.Name = "FileInformationToolStripMenuItem1"
        Me.FileInformationToolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
        Me.FileInformationToolStripMenuItem1.Text = "File Information"
        '
        'cmdclipsearch
        '
        Me.cmdclipsearch.Location = New System.Drawing.Point(627, 8)
        Me.cmdclipsearch.Name = "cmdclipsearch"
        Me.cmdclipsearch.Size = New System.Drawing.Size(76, 25)
        Me.cmdclipsearch.TabIndex = 176
        Me.cmdclipsearch.Text = "Search Clips"
        Me.cmdclipsearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtsearch", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtsearch.Location = New System.Drawing.Point(405, 9)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(219, 20)
        Me.txtsearch.TabIndex = 175
        Me.txtsearch.Text = Global.caspar_media_playback.My.MySettings.Default.txtsearch
        Me.ToolTip1.SetToolTip(Me.txtsearch, "Few letters to search")
        '
        'gbplayerforclipgrid
        '
        Me.gbplayerforclipgrid.BackColor = System.Drawing.Color.Turquoise
        Me.gbplayerforclipgrid.Controls.Add(Me.cmdplaynextforclipgrid)
        Me.gbplayerforclipgrid.Controls.Add(Me.cmdcuenextforclipgrid)
        Me.gbplayerforclipgrid.Controls.Add(Me.cmdstopforclipgrid)
        Me.gbplayerforclipgrid.Controls.Add(Me.cmdresumeforclipgrid)
        Me.gbplayerforclipgrid.Controls.Add(Me.cmdforwardoneframeforclipgrid)
        Me.gbplayerforclipgrid.Controls.Add(Me.cmdplayforclipgrid)
        Me.gbplayerforclipgrid.Controls.Add(Me.cmdbackoneframeforclipgrid)
        Me.gbplayerforclipgrid.Controls.Add(Me.cmdcueforclipgrid)
        Me.gbplayerforclipgrid.Controls.Add(Me.cmdpauseforclipgrid)
        Me.gbplayerforclipgrid.Controls.Add(Me.chkDeinterlace)
        Me.gbplayerforclipgrid.Controls.Add(Me.chkclipcountdown)
        Me.gbplayerforclipgrid.Controls.Add(Me.chknextcuefor2ndchannel)
        Me.gbplayerforclipgrid.Controls.Add(Me.Label220)
        Me.gbplayerforclipgrid.Controls.Add(Me.Label221)
        Me.gbplayerforclipgrid.Controls.Add(Me.Label222)
        Me.gbplayerforclipgrid.Location = New System.Drawing.Point(301, 261)
        Me.gbplayerforclipgrid.Name = "gbplayerforclipgrid"
        Me.gbplayerforclipgrid.Size = New System.Drawing.Size(878, 70)
        Me.gbplayerforclipgrid.TabIndex = 1170
        Me.gbplayerforclipgrid.TabStop = False
        '
        'cmdplaynextforclipgrid
        '
        Me.cmdplaynextforclipgrid.Image = CType(resources.GetObject("cmdplaynextforclipgrid.Image"), System.Drawing.Image)
        Me.cmdplaynextforclipgrid.Location = New System.Drawing.Point(804, 16)
        Me.cmdplaynextforclipgrid.Name = "cmdplaynextforclipgrid"
        Me.cmdplaynextforclipgrid.Size = New System.Drawing.Size(47, 37)
        Me.cmdplaynextforclipgrid.TabIndex = 1188
        Me.ToolTip1.SetToolTip(Me.cmdplaynextforclipgrid, "Play Next")
        Me.cmdplaynextforclipgrid.UseVisualStyleBackColor = True
        '
        'cmdcuenextforclipgrid
        '
        Me.cmdcuenextforclipgrid.Image = CType(resources.GetObject("cmdcuenextforclipgrid.Image"), System.Drawing.Image)
        Me.cmdcuenextforclipgrid.Location = New System.Drawing.Point(739, 16)
        Me.cmdcuenextforclipgrid.Name = "cmdcuenextforclipgrid"
        Me.cmdcuenextforclipgrid.Size = New System.Drawing.Size(47, 37)
        Me.cmdcuenextforclipgrid.TabIndex = 1187
        Me.ToolTip1.SetToolTip(Me.cmdcuenextforclipgrid, "Cue Next")
        Me.cmdcuenextforclipgrid.UseVisualStyleBackColor = True
        '
        'cmdstopforclipgrid
        '
        Me.cmdstopforclipgrid.Image = CType(resources.GetObject("cmdstopforclipgrid.Image"), System.Drawing.Image)
        Me.cmdstopforclipgrid.Location = New System.Drawing.Point(667, 16)
        Me.cmdstopforclipgrid.Name = "cmdstopforclipgrid"
        Me.cmdstopforclipgrid.Size = New System.Drawing.Size(47, 37)
        Me.cmdstopforclipgrid.TabIndex = 1186
        Me.ToolTip1.SetToolTip(Me.cmdstopforclipgrid, "Stop")
        Me.cmdstopforclipgrid.UseVisualStyleBackColor = True
        '
        'cmdresumeforclipgrid
        '
        Me.cmdresumeforclipgrid.Image = CType(resources.GetObject("cmdresumeforclipgrid.Image"), System.Drawing.Image)
        Me.cmdresumeforclipgrid.Location = New System.Drawing.Point(600, 16)
        Me.cmdresumeforclipgrid.Name = "cmdresumeforclipgrid"
        Me.cmdresumeforclipgrid.Size = New System.Drawing.Size(47, 37)
        Me.cmdresumeforclipgrid.TabIndex = 1185
        Me.ToolTip1.SetToolTip(Me.cmdresumeforclipgrid, "Resume")
        Me.cmdresumeforclipgrid.UseVisualStyleBackColor = True
        '
        'cmdforwardoneframeforclipgrid
        '
        Me.cmdforwardoneframeforclipgrid.Image = CType(resources.GetObject("cmdforwardoneframeforclipgrid.Image"), System.Drawing.Image)
        Me.cmdforwardoneframeforclipgrid.Location = New System.Drawing.Point(477, 16)
        Me.cmdforwardoneframeforclipgrid.Name = "cmdforwardoneframeforclipgrid"
        Me.cmdforwardoneframeforclipgrid.Size = New System.Drawing.Size(47, 37)
        Me.cmdforwardoneframeforclipgrid.TabIndex = 1184
        Me.ToolTip1.SetToolTip(Me.cmdforwardoneframeforclipgrid, "1 Frame Forward")
        Me.cmdforwardoneframeforclipgrid.UseVisualStyleBackColor = True
        '
        'cmdplayforclipgrid
        '
        Me.cmdplayforclipgrid.Image = CType(resources.GetObject("cmdplayforclipgrid.Image"), System.Drawing.Image)
        Me.cmdplayforclipgrid.Location = New System.Drawing.Point(422, 16)
        Me.cmdplayforclipgrid.Name = "cmdplayforclipgrid"
        Me.cmdplayforclipgrid.Size = New System.Drawing.Size(47, 37)
        Me.cmdplayforclipgrid.TabIndex = 1183
        Me.ToolTip1.SetToolTip(Me.cmdplayforclipgrid, "Play From Start")
        Me.cmdplayforclipgrid.UseVisualStyleBackColor = True
        '
        'cmdbackoneframeforclipgrid
        '
        Me.cmdbackoneframeforclipgrid.Image = CType(resources.GetObject("cmdbackoneframeforclipgrid.Image"), System.Drawing.Image)
        Me.cmdbackoneframeforclipgrid.Location = New System.Drawing.Point(358, 16)
        Me.cmdbackoneframeforclipgrid.Name = "cmdbackoneframeforclipgrid"
        Me.cmdbackoneframeforclipgrid.Size = New System.Drawing.Size(47, 37)
        Me.cmdbackoneframeforclipgrid.TabIndex = 1182
        Me.ToolTip1.SetToolTip(Me.cmdbackoneframeforclipgrid, "1 Frame Back")
        Me.cmdbackoneframeforclipgrid.UseVisualStyleBackColor = True
        '
        'cmdcueforclipgrid
        '
        Me.cmdcueforclipgrid.Image = CType(resources.GetObject("cmdcueforclipgrid.Image"), System.Drawing.Image)
        Me.cmdcueforclipgrid.Location = New System.Drawing.Point(302, 16)
        Me.cmdcueforclipgrid.Name = "cmdcueforclipgrid"
        Me.cmdcueforclipgrid.Size = New System.Drawing.Size(47, 37)
        Me.cmdcueforclipgrid.TabIndex = 1181
        Me.ToolTip1.SetToolTip(Me.cmdcueforclipgrid, "Cue (Go to 1st Frame)")
        Me.cmdcueforclipgrid.UseVisualStyleBackColor = True
        '
        'cmdpauseforclipgrid
        '
        Me.cmdpauseforclipgrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdpauseforclipgrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpauseforclipgrid.Image = Global.caspar_media_playback.My.Resources.Resources.pause3
        Me.cmdpauseforclipgrid.Location = New System.Drawing.Point(541, 16)
        Me.cmdpauseforclipgrid.Name = "cmdpauseforclipgrid"
        Me.cmdpauseforclipgrid.Size = New System.Drawing.Size(47, 37)
        Me.cmdpauseforclipgrid.TabIndex = 159
        Me.cmdpauseforclipgrid.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.cmdpauseforclipgrid, "Pause")
        Me.cmdpauseforclipgrid.UseVisualStyleBackColor = True
        '
        'chkDeinterlace
        '
        Me.chkDeinterlace.AutoSize = True
        Me.chkDeinterlace.Checked = True
        Me.chkDeinterlace.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDeinterlace.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkDeinterlace.Location = New System.Drawing.Point(12, 29)
        Me.chkDeinterlace.Name = "chkDeinterlace"
        Me.chkDeinterlace.Size = New System.Drawing.Size(80, 17)
        Me.chkDeinterlace.TabIndex = 737
        Me.chkDeinterlace.Text = "Deinterlace"
        Me.chkDeinterlace.UseVisualStyleBackColor = True
        '
        'chkclipcountdown
        '
        Me.chkclipcountdown.AutoSize = True
        Me.chkclipcountdown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkclipcountdown.Location = New System.Drawing.Point(12, 46)
        Me.chkclipcountdown.Name = "chkclipcountdown"
        Me.chkclipcountdown.Size = New System.Drawing.Size(217, 17)
        Me.chkclipcountdown.TabIndex = 736
        Me.chkclipcountdown.Text = "Clip Count Down on next Upper Channel"
        Me.chkclipcountdown.UseVisualStyleBackColor = True
        '
        'chknextcuefor2ndchannel
        '
        Me.chknextcuefor2ndchannel.AutoSize = True
        Me.chknextcuefor2ndchannel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chknextcuefor2ndchannel.Location = New System.Drawing.Point(12, 13)
        Me.chknextcuefor2ndchannel.Name = "chknextcuefor2ndchannel"
        Me.chknextcuefor2ndchannel.Size = New System.Drawing.Size(257, 17)
        Me.chknextcuefor2ndchannel.TabIndex = 735
        Me.chknextcuefor2ndchannel.Text = "Next clip 10 sec loop play on next upper Channel"
        Me.chknextcuefor2ndchannel.UseVisualStyleBackColor = True
        '
        'Label220
        '
        Me.Label220.AutoSize = True
        Me.Label220.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label220.Location = New System.Drawing.Point(629, 10)
        Me.Label220.Name = "Label220"
        Me.Label220.Size = New System.Drawing.Size(10, 13)
        Me.Label220.TabIndex = 352
        Me.Label220.Text = "."
        Me.Label220.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label221
        '
        Me.Label221.AutoSize = True
        Me.Label221.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label221.Location = New System.Drawing.Point(29, 13)
        Me.Label221.Name = "Label221"
        Me.Label221.Size = New System.Drawing.Size(10, 13)
        Me.Label221.TabIndex = 335
        Me.Label221.Text = "."
        Me.Label221.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label222
        '
        Me.Label222.AutoSize = True
        Me.Label222.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label222.Location = New System.Drawing.Point(822, 10)
        Me.Label222.Name = "Label222"
        Me.Label222.Size = New System.Drawing.Size(10, 13)
        Me.Label222.TabIndex = 0
        Me.Label222.Text = "."
        Me.Label222.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrduration
        '
        Me.tmrduration.Enabled = True
        Me.tmrduration.Interval = 500
        '
        'tmrnextclip
        '
        Me.tmrnextclip.Interval = 1000
        '
        'tmrclipcountdown
        '
        Me.tmrclipcountdown.Interval = 1000
        '
        'tmrfornotskiping
        '
        Me.tmrfornotskiping.Interval = 6000
        '
        'tmrcheckfilesinplaylist
        '
        Me.tmrcheckfilesinplaylist.Interval = 10000
        '
        'tmrstartattime
        '
        Me.tmrstartattime.Interval = 2000
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "File_Name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 210
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 210
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Remaining Time"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Start_Time"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Duration"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Audio Level"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 40
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Filter"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 500
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Template File"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Width = 400
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "AMCP Commands"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ScaleModeToolStripMenuItem
        '
        Me.ScaleModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STRETCHToolStripMenuItem, Me.FITToolStripMenuItem, Me.FILLToolStripMenuItem, Me.ORIGINALToolStripMenuItem})
        Me.ScaleModeToolStripMenuItem.Name = "ScaleModeToolStripMenuItem"
        Me.ScaleModeToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ScaleModeToolStripMenuItem.Text = "Scale Mode in NRK Build"
        '
        'STRETCHToolStripMenuItem
        '
        Me.STRETCHToolStripMenuItem.Name = "STRETCHToolStripMenuItem"
        Me.STRETCHToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.STRETCHToolStripMenuItem.Text = "STRETCH"
        '
        'FITToolStripMenuItem
        '
        Me.FITToolStripMenuItem.Name = "FITToolStripMenuItem"
        Me.FITToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FITToolStripMenuItem.Text = "FIT"
        '
        'FILLToolStripMenuItem
        '
        Me.FILLToolStripMenuItem.Name = "FILLToolStripMenuItem"
        Me.FILLToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FILLToolStripMenuItem.Text = "FILL"
        '
        'ORIGINALToolStripMenuItem
        '
        Me.ORIGINALToolStripMenuItem.Name = "ORIGINALToolStripMenuItem"
        Me.ORIGINALToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ORIGINALToolStripMenuItem.Text = "ORIGINAL"
        '
        'ucPlaylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1222, 921)
        Me.Controls.Add(Me.gbplaylist)
        Me.HideOnClose = True
        Me.KeyPreview = True
        Me.Name = "ucPlaylist"
        Me.Text = "Playlist"
        Me.gbplaylist.ResumeLayout(False)
        Me.gbplaylist.PerformLayout()
        Me.gbnowplaing.ResumeLayout(False)
        Me.gbnowplaing.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.gbcliplist.ResumeLayout(False)
        Me.gbcliplist.PerformLayout()
        CType(Me.dgvclips, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsdgvclips.ResumeLayout(False)
        Me.gbplayerforclipgrid.ResumeLayout(False)
        Me.gbplayerforclipgrid.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbplaylist As System.Windows.Forms.GroupBox
    Friend WithEvents chkcheckfilesinplaylist As System.Windows.Forms.CheckBox
    Friend WithEvents chkshowthumbnail As System.Windows.Forms.CheckBox
    Friend WithEvents gbnowplaing As System.Windows.Forms.GroupBox
    Friend WithEvents txtbackin As System.Windows.Forms.TextBox
    Friend WithEvents cmdbackin As System.Windows.Forms.Button
    Friend WithEvents cmdstopnowplaying As System.Windows.Forms.Button
    Friend WithEvents txtcommingupnext As System.Windows.Forms.TextBox
    Friend WithEvents cmdnowplaying As System.Windows.Forms.Button
    Friend WithEvents cmdcommingupnext As System.Windows.Forms.Button
    Friend WithEvents cmdremainingdurationofplaylist As System.Windows.Forms.Button
    Friend WithEvents txtremaingdurationofplaylist As System.Windows.Forms.TextBox
    Friend WithEvents cmddurationofplaylist As System.Windows.Forms.Button
    Friend WithEvents txtdurationofplalist As System.Windows.Forms.TextBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtfps As System.Windows.Forms.TextBox
    Friend WithEvents lblfps As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents lblplalistname As System.Windows.Forms.Label
    Friend WithEvents cmddeleteclip As System.Windows.Forms.Button
    Friend WithEvents chkplaylistlock As System.Windows.Forms.CheckBox
    Friend WithEvents cmdmoveup As System.Windows.Forms.Button
    Friend WithEvents cmdmovedown As System.Windows.Forms.Button
    Friend WithEvents cmdinsert As System.Windows.Forms.Button
    Friend WithEvents cmdstartplaylist As System.Windows.Forms.Button
    Friend WithEvents btnstartattime As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbcliplist As System.Windows.Forms.GroupBox
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents Label237 As System.Windows.Forms.Label
    Friend WithEvents pbclipsearchstatus As System.Windows.Forms.ProgressBar
    Friend WithEvents cmdrefreshtvclips As System.Windows.Forms.Button
    Friend WithEvents tvclips As System.Windows.Forms.TreeView
    Friend WithEvents labelclips As System.Windows.Forms.Label
    Friend WithEvents chkclipduration As System.Windows.Forms.CheckBox
    Friend WithEvents dgvclips As System.Windows.Forms.DataGridView
    Friend WithEvents cmdclipsearch As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents gbplayerforclipgrid As System.Windows.Forms.GroupBox
    Friend WithEvents chkclipcountdown As System.Windows.Forms.CheckBox
    Friend WithEvents chknextcuefor2ndchannel As System.Windows.Forms.CheckBox
    Friend WithEvents Label220 As System.Windows.Forms.Label
    Friend WithEvents Label221 As System.Windows.Forms.Label
    Friend WithEvents Label222 As System.Windows.Forms.Label
    Friend WithEvents cmdpauseforclipgrid As System.Windows.Forms.Button
    Friend WithEvents tmrduration As System.Windows.Forms.Timer
    Friend WithEvents tmrnextclip As System.Windows.Forms.Timer
    Friend WithEvents tmrclipcountdown As System.Windows.Forms.Timer
    Friend WithEvents tmrfornotskiping As System.Windows.Forms.Timer
    Friend WithEvents cmsdgvclips As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CueInCsparcgToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayInCasparcgToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileInformationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrcheckfilesinplaylist As System.Windows.Forms.Timer
    Friend WithEvents tmrstartattime As System.Windows.Forms.Timer
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
    Friend WithEvents PlayInVLCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenInTrimmerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InsertDecklinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertDecklinkToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertDecklinkToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertDecklinkToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowLiveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowLiveToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowLiveToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowLiveToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowLiveToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowLiveToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowLiveToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowLiveToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowLiveToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertDecklinkToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertDecklinkToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertDecklinkToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertDecklinkToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertDecklinkToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InserEndToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeSelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetStartTimeAcoordingToCurrentRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshThumbnailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents InserPlaylistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chktemplatewithplaylist As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents InsertFilterForIMXFile As ToolStripMenuItem
    Friend WithEvents chkDeinterlace As CheckBox
    Friend WithEvents ChangeAllTransitionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MIXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WIPEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PUSHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SLIDEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuPlayinffplay As ToolStripMenuItem
    Friend WithEvents cmdSmallScreen As Button
    Friend WithEvents cmdFullScreen As Button
    Friend WithEvents cmdcueforclipgrid As Button
    Friend WithEvents cmdbackoneframeforclipgrid As Button
    Friend WithEvents cmdplayforclipgrid As Button
    Friend WithEvents cmdforwardoneframeforclipgrid As Button
    Friend WithEvents cmdresumeforclipgrid As Button
    Friend WithEvents cmdstopforclipgrid As Button
    Friend WithEvents cmdcuenextforclipgrid As Button
    Friend WithEvents cmdplaynextforclipgrid As Button
    Friend WithEvents ForIMXFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AudioChannelLayoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LToBothToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RToBothToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MixToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OnlyLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnlyRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents File_Name As DataGridViewTextBoxColumn
    Friend WithEvents Start_Time As DataGridViewTextBoxColumn
    Friend WithEvents x As DataGridViewCheckBoxColumn
    Friend WithEvents Clip_Duration As DataGridViewTextBoxColumn
    Friend WithEvents Conversion As DataGridViewCheckBoxColumn
    Friend WithEvents FileType As DataGridViewComboBoxColumn
    Friend WithEvents LoopVideo As DataGridViewCheckBoxColumn
    Friend WithEvents Column3 As DataGridViewImageColumn
    Friend WithEvents Transition As DataGridViewComboBoxColumn
    Friend WithEvents T_Duration As DataGridViewComboBoxColumn
    Friend WithEvents Column11 As DataGridViewCheckBoxColumn
    Friend WithEvents AudioLevel As DataGridViewTextBoxColumn
    Friend WithEvents clmFilter As DataGridViewTextBoxColumn
    Friend WithEvents Template_File As DataGridViewTextBoxColumn
    Friend WithEvents BackIn As DataGridViewCheckBoxColumn
    Friend WithEvents AMCPCommands As DataGridViewTextBoxColumn
    Friend WithEvents DeInterlaceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Yadif10ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Yadif11ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScaleModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STRETCHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FILLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ORIGINALToolStripMenuItem As ToolStripMenuItem
End Class
