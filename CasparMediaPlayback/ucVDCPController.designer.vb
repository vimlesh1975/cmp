<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucVDCPController
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucVDCPController))
        Me.gbrecording = New System.Windows.Forms.GroupBox()
        Me.txtresponseNative = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt422send5 = New System.Windows.Forms.TextBox()
        Me.txt422send4 = New System.Windows.Forms.TextBox()
        Me.txt422send3 = New System.Windows.Forms.TextBox()
        Me.cmd422send3command = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdcueclip = New System.Windows.Forms.Button()
        Me.txt422send2 = New System.Windows.Forms.TextBox()
        Me.txt422send = New System.Windows.Forms.TextBox()
        Me.cmd422send = New System.Windows.Forms.Button()
        Me.cmdassembleoffvtr = New System.Windows.Forms.Button()
        Me.cmdassembleonvtr = New System.Windows.Forms.Button()
        Me.cmdplusoneframevtr = New System.Windows.Forms.Button()
        Me.cmdminusoneframevtr = New System.Windows.Forms.Button()
        Me.lbloutpointvtr = New System.Windows.Forms.Label()
        Me.lblinpointvtr = New System.Windows.Forms.Label()
        Me.cmdReviewvtr = New System.Windows.Forms.Button()
        Me.cmdpreviewvtr = New System.Windows.Forms.Button()
        Me.cmdautoeditvtr = New System.Windows.Forms.Button()
        Me.cmdrecordvtr = New System.Windows.Forms.Button()
        Me.lbljogvtr = New System.Windows.Forms.Label()
        Me.HScrollBarjogvtr = New System.Windows.Forms.HScrollBar()
        Me.lblshuttlevtr = New System.Windows.Forms.Label()
        Me.HScrollBarshuttlevtr = New System.Windows.Forms.HScrollBar()
        Me.lblvariablevtr = New System.Windows.Forms.Label()
        Me.HScrollBarvtr = New System.Windows.Forms.HScrollBar()
        Me.dgvcuepointsvtr = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdmarkvtr = New System.Windows.Forms.Button()
        Me.cmdcuevtr = New System.Windows.Forms.Button()
        Me.cmdPreRollvtr = New System.Windows.Forms.Button()
        Me.cmdejectvtr = New System.Windows.Forms.Button()
        Me.cmdstandbyoffvtr = New System.Windows.Forms.Button()
        Me.cmdstandbyonvtr = New System.Windows.Forms.Button()
        Me.lbltimecode = New System.Windows.Forms.Label()
        Me.cmdffvtr = New System.Windows.Forms.Button()
        Me.cmdstopvtr = New System.Windows.Forms.Button()
        Me.cmdrewindvtr = New System.Windows.Forms.Button()
        Me.cmdoutpointvtr = New System.Windows.Forms.Button()
        Me.cmdinpointvtr = New System.Windows.Forms.Button()
        Me.cmdplayvtr = New System.Windows.Forms.Button()
        Me.cmdopenportsvtr = New System.Windows.Forms.Button()
        Me.lblcomportsvtr = New System.Windows.Forms.Label()
        Me.cmbportsvtr = New System.Windows.Forms.ComboBox()
        Me.txt422receive = New System.Windows.Forms.TextBox()
        Me.t2 = New System.Windows.Forms.TextBox()
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.gbRemoteLogging = New System.Windows.Forms.GroupBox()
        Me.cmdplaytcp = New System.Windows.Forms.Button()
        Me.cmdtcpsend = New System.Windows.Forms.Button()
        Me.txttcpsend = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label276 = New System.Windows.Forms.Label()
        Me.cmbportgbRemoteLogging = New System.Windows.Forms.ComboBox()
        Me.txtgbRemoteLogging = New System.Windows.Forms.TextBox()
        Me.cmddisConnectRemoteLogging = New System.Windows.Forms.Button()
        Me.cmdConnectRemoteLogging = New System.Windows.Forms.Button()
        Me.cmbhost = New System.Windows.Forms.ComboBox()
        Me.lblhost = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtudpportreceive = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdstopreceive = New System.Windows.Forms.Button()
        Me.cmdudpreceive = New System.Windows.Forms.Button()
        Me.cmdudpsend = New System.Windows.Forms.Button()
        Me.txtudpdata = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtudpport = New System.Windows.Forms.ComboBox()
        Me.txtudprereceive = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.sp = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrgettc = New System.Windows.Forms.Timer(Me.components)
        Me.cmdportstatus3vdcp = New System.Windows.Forms.Button()
        Me.cmdopenport = New System.Windows.Forms.Button()
        Me.cmdselectport = New System.Windows.Forms.Button()
        Me.cmdrecordvdcp = New System.Windows.Forms.Button()
        Me.cmdidlistvdcp = New System.Windows.Forms.Button()
        Me.cmdcloseport = New System.Windows.Forms.Button()
        Me.cmdplayclipname = New System.Windows.Forms.Button()
        Me.txtActiveID = New System.Windows.Forms.Label()
        Me.dgvclips = New System.Windows.Forms.DataGridView()
        Me.ClipName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsdgvclips = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CueInCsparcgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayInCasparcgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileInformationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdGetIdDuration = New System.Windows.Forms.Button()
        Me.tmrRemainingDuration = New System.Windows.Forms.Timer(Me.components)
        Me.lblRemainingDuration = New System.Windows.Forms.Label()
        Me.cmdStartPlayList = New System.Windows.Forms.Button()
        Me.tmrNextClipofPlaylist = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbportvdcp = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblclipcount = New System.Windows.Forms.Label()
        Me.cmdAddNewIDs = New System.Windows.Forms.Button()
        Me.cmdRemoveDeletedIDs = New System.Windows.Forms.Button()
        Me.cmdDeleteID = New System.Windows.Forms.Button()
        Me.cmdRenameId = New System.Windows.Forms.Button()
        Me.txtNewName = New System.Windows.Forms.TextBox()
        Me.cmdcuewithdata = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.HScrollBarjogvdcp = New System.Windows.Forms.HScrollBar()
        Me.tbvdcp = New System.Windows.Forms.TrackBar()
        Me.cmdloadcliptoeditvdcp = New System.Windows.Forms.Button()
        Me.gbVDCP = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmdvdcppause = New System.Windows.Forms.Button()
        Me.cmdvdcpresume = New System.Windows.Forms.Button()
        Me.cmdforwardoneframe = New System.Windows.Forms.Button()
        Me.cmdbackoneframe = New System.Windows.Forms.Button()
        Me.cmdvdcpstop = New System.Windows.Forms.Button()
        Me.lblCurrentFrame = New System.Windows.Forms.Label()
        Me.cmdcueclipvdcp = New System.Windows.Forms.Button()
        Me.lbltbmax = New System.Windows.Forms.Label()
        Me.cmbSourceDriveNames = New System.Windows.Forms.ComboBox()
        Me.cmbDestinationDriveNames = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmdCopyFileTovdcp = New System.Windows.Forms.Button()
        Me.txtSubclipvdcp = New System.Windows.Forms.TextBox()
        Me.cmdselectall = New System.Windows.Forms.Button()
        Me.cmddeselectall = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblplaylistname = New System.Windows.Forms.Label()
        Me.cmddeleteclip = New System.Windows.Forms.Button()
        Me.cmdmoveup = New System.Windows.Forms.Button()
        Me.cmdmovedown = New System.Windows.Forms.Button()
        Me.cmdinsert = New System.Windows.Forms.Button()
        Me.tsPlaylist = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveAsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdoPlayedDuration = New System.Windows.Forms.RadioButton()
        Me.rdoTC = New System.Windows.Forms.RadioButton()
        Me.rdoRemainduration = New System.Windows.Forms.RadioButton()
        Me.nSpeedvdcp = New System.Windows.Forms.NumericUpDown()
        Me.cmdVariableSpeed = New System.Windows.Forms.Button()
        Me.cmdEEModeAuto = New System.Windows.Forms.Button()
        Me.cmdEEModeOFF = New System.Windows.Forms.Button()
        Me.cmdEEModeON = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmdmovecommandvdcp = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtrecordfilenamevdcp = New System.Windows.Forms.TextBox()
        Me.cmdrecordinitialisevdcp = New System.Windows.Forms.Button()
        Me.cmdnewcopyvdcp = New System.Windows.Forms.Button()
        Me.lblPortStatus = New System.Windows.Forms.Label()
        Me.cmdportstatus1vdcp = New System.Windows.Forms.Button()
        Me.cmdportstatus2vdcp = New System.Windows.Forms.Button()
        Me.dgvstatuserrovdcp = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.VDCPTesting = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.cmdcloseportsvtr = New System.Windows.Forms.Button()
        Me.osd2 = New System.Windows.Forms.SaveFileDialog()
        Me.ofd2 = New System.Windows.Forms.OpenFileDialog()
        Me.ttvdcp = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.gbrecording.SuspendLayout()
        CType(Me.dgvcuepointsvtr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRemoteLogging.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvclips, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsdgvclips.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.tbvdcp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbVDCP.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsPlaylist.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.nSpeedvdcp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvstatuserrovdcp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.VDCPTesting.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbrecording
        '
        Me.gbrecording.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.gbrecording.Controls.Add(Me.txtresponseNative)
        Me.gbrecording.Controls.Add(Me.Button1)
        Me.gbrecording.Controls.Add(Me.txt422send5)
        Me.gbrecording.Controls.Add(Me.txt422send4)
        Me.gbrecording.Controls.Add(Me.txt422send3)
        Me.gbrecording.Controls.Add(Me.cmd422send3command)
        Me.gbrecording.Controls.Add(Me.Label6)
        Me.gbrecording.Controls.Add(Me.cmdcueclip)
        Me.gbrecording.Controls.Add(Me.txt422send2)
        Me.gbrecording.Controls.Add(Me.txt422send)
        Me.gbrecording.Controls.Add(Me.cmd422send)
        Me.gbrecording.Controls.Add(Me.cmdassembleoffvtr)
        Me.gbrecording.Controls.Add(Me.cmdassembleonvtr)
        Me.gbrecording.Controls.Add(Me.cmdplusoneframevtr)
        Me.gbrecording.Controls.Add(Me.cmdminusoneframevtr)
        Me.gbrecording.Controls.Add(Me.lbloutpointvtr)
        Me.gbrecording.Controls.Add(Me.lblinpointvtr)
        Me.gbrecording.Controls.Add(Me.cmdReviewvtr)
        Me.gbrecording.Controls.Add(Me.cmdpreviewvtr)
        Me.gbrecording.Controls.Add(Me.cmdautoeditvtr)
        Me.gbrecording.Controls.Add(Me.cmdrecordvtr)
        Me.gbrecording.Controls.Add(Me.lbljogvtr)
        Me.gbrecording.Controls.Add(Me.HScrollBarjogvtr)
        Me.gbrecording.Controls.Add(Me.lblshuttlevtr)
        Me.gbrecording.Controls.Add(Me.HScrollBarshuttlevtr)
        Me.gbrecording.Controls.Add(Me.lblvariablevtr)
        Me.gbrecording.Controls.Add(Me.HScrollBarvtr)
        Me.gbrecording.Controls.Add(Me.dgvcuepointsvtr)
        Me.gbrecording.Controls.Add(Me.cmdmarkvtr)
        Me.gbrecording.Controls.Add(Me.cmdcuevtr)
        Me.gbrecording.Controls.Add(Me.cmdPreRollvtr)
        Me.gbrecording.Controls.Add(Me.cmdejectvtr)
        Me.gbrecording.Controls.Add(Me.cmdstandbyoffvtr)
        Me.gbrecording.Controls.Add(Me.cmdstandbyonvtr)
        Me.gbrecording.Controls.Add(Me.lbltimecode)
        Me.gbrecording.Controls.Add(Me.cmdffvtr)
        Me.gbrecording.Controls.Add(Me.cmdstopvtr)
        Me.gbrecording.Controls.Add(Me.cmdrewindvtr)
        Me.gbrecording.Controls.Add(Me.cmdoutpointvtr)
        Me.gbrecording.Controls.Add(Me.cmdinpointvtr)
        Me.gbrecording.Controls.Add(Me.cmdplayvtr)
        Me.gbrecording.ForeColor = System.Drawing.Color.Black
        Me.gbrecording.Location = New System.Drawing.Point(6, 16)
        Me.gbrecording.Name = "gbrecording"
        Me.gbrecording.Size = New System.Drawing.Size(410, 533)
        Me.gbrecording.TabIndex = 178
        Me.gbrecording.TabStop = False
        Me.gbrecording.Text = "RS 422 VTR Control"
        '
        'txtresponseNative
        '
        Me.txtresponseNative.Location = New System.Drawing.Point(36, 423)
        Me.txtresponseNative.Multiline = True
        Me.txtresponseNative.Name = "txtresponseNative"
        Me.txtresponseNative.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtresponseNative.Size = New System.Drawing.Size(191, 38)
        Me.txtresponseNative.TabIndex = 719
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 470)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 23)
        Me.Button1.TabIndex = 718
        Me.Button1.Text = "Cue Clip dolby"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt422send5
        '
        Me.txt422send5.Location = New System.Drawing.Point(180, 375)
        Me.txt422send5.Name = "txt422send5"
        Me.txt422send5.Size = New System.Drawing.Size(41, 20)
        Me.txt422send5.TabIndex = 717
        Me.txt422send5.Text = "21"
        '
        'txt422send4
        '
        Me.txt422send4.Location = New System.Drawing.Point(125, 375)
        Me.txt422send4.Name = "txt422send4"
        Me.txt422send4.Size = New System.Drawing.Size(41, 20)
        Me.txt422send4.TabIndex = 716
        Me.txt422send4.Text = "4C"
        '
        'txt422send3
        '
        Me.txt422send3.Location = New System.Drawing.Point(76, 375)
        Me.txt422send3.Name = "txt422send3"
        Me.txt422send3.Size = New System.Drawing.Size(43, 20)
        Me.txt422send3.TabIndex = 714
        Me.txt422send3.Text = "C1"
        '
        'cmd422send3command
        '
        Me.cmd422send3command.Location = New System.Drawing.Point(230, 373)
        Me.cmd422send3command.Name = "cmd422send3command"
        Me.cmd422send3command.Size = New System.Drawing.Size(75, 23)
        Me.cmd422send3command.TabIndex = 715
        Me.cmd422send3command.Text = "Send"
        Me.cmd422send3command.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 20)
        Me.Label6.TabIndex = 712
        Me.Label6.Text = "422 command"
        '
        'cmdcueclip
        '
        Me.cmdcueclip.Location = New System.Drawing.Point(245, 258)
        Me.cmdcueclip.Name = "cmdcueclip"
        Me.cmdcueclip.Size = New System.Drawing.Size(123, 23)
        Me.cmdcueclip.TabIndex = 711
        Me.cmdcueclip.Text = "Cue Clip to first frame"
        Me.cmdcueclip.UseVisualStyleBackColor = True
        '
        'txt422send2
        '
        Me.txt422send2.Location = New System.Drawing.Point(180, 346)
        Me.txt422send2.Name = "txt422send2"
        Me.txt422send2.Size = New System.Drawing.Size(41, 20)
        Me.txt422send2.TabIndex = 706
        Me.txt422send2.Text = "14"
        '
        'txt422send
        '
        Me.txt422send.Location = New System.Drawing.Point(131, 346)
        Me.txt422send.Name = "txt422send"
        Me.txt422send.Size = New System.Drawing.Size(43, 20)
        Me.txt422send.TabIndex = 16
        Me.txt422send.Text = "A0"
        '
        'cmd422send
        '
        Me.cmd422send.Location = New System.Drawing.Point(230, 344)
        Me.cmd422send.Name = "cmd422send"
        Me.cmd422send.Size = New System.Drawing.Size(75, 23)
        Me.cmd422send.TabIndex = 705
        Me.cmd422send.Text = "Send"
        Me.cmd422send.UseVisualStyleBackColor = True
        '
        'cmdassembleoffvtr
        '
        Me.cmdassembleoffvtr.Location = New System.Drawing.Point(99, 196)
        Me.cmdassembleoffvtr.Name = "cmdassembleoffvtr"
        Me.cmdassembleoffvtr.Size = New System.Drawing.Size(86, 23)
        Me.cmdassembleoffvtr.TabIndex = 704
        Me.cmdassembleoffvtr.Text = "Assemble Off"
        Me.cmdassembleoffvtr.UseVisualStyleBackColor = True
        '
        'cmdassembleonvtr
        '
        Me.cmdassembleonvtr.Location = New System.Drawing.Point(16, 196)
        Me.cmdassembleonvtr.Name = "cmdassembleonvtr"
        Me.cmdassembleonvtr.Size = New System.Drawing.Size(78, 23)
        Me.cmdassembleonvtr.TabIndex = 703
        Me.cmdassembleonvtr.Text = "Assemble On"
        Me.cmdassembleonvtr.UseVisualStyleBackColor = True
        '
        'cmdplusoneframevtr
        '
        Me.cmdplusoneframevtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplusoneframevtr.Location = New System.Drawing.Point(292, 41)
        Me.cmdplusoneframevtr.Name = "cmdplusoneframevtr"
        Me.cmdplusoneframevtr.Size = New System.Drawing.Size(28, 25)
        Me.cmdplusoneframevtr.TabIndex = 702
        Me.cmdplusoneframevtr.Text = "+"
        Me.cmdplusoneframevtr.UseVisualStyleBackColor = True
        '
        'cmdminusoneframevtr
        '
        Me.cmdminusoneframevtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdminusoneframevtr.Location = New System.Drawing.Point(193, 42)
        Me.cmdminusoneframevtr.Name = "cmdminusoneframevtr"
        Me.cmdminusoneframevtr.Size = New System.Drawing.Size(28, 25)
        Me.cmdminusoneframevtr.TabIndex = 701
        Me.cmdminusoneframevtr.Text = "-"
        Me.cmdminusoneframevtr.UseVisualStyleBackColor = True
        '
        'lbloutpointvtr
        '
        Me.lbloutpointvtr.AutoSize = True
        Me.lbloutpointvtr.Location = New System.Drawing.Point(114, 107)
        Me.lbloutpointvtr.Name = "lbloutpointvtr"
        Me.lbloutpointvtr.Size = New System.Drawing.Size(64, 13)
        Me.lbloutpointvtr.TabIndex = 700
        Me.lbloutpointvtr.Text = "00:02:20:00"
        '
        'lblinpointvtr
        '
        Me.lblinpointvtr.AutoSize = True
        Me.lblinpointvtr.Location = New System.Drawing.Point(16, 107)
        Me.lblinpointvtr.Name = "lblinpointvtr"
        Me.lblinpointvtr.Size = New System.Drawing.Size(64, 13)
        Me.lblinpointvtr.TabIndex = 699
        Me.lblinpointvtr.Text = "00:02:00:00"
        '
        'cmdReviewvtr
        '
        Me.cmdReviewvtr.Location = New System.Drawing.Point(99, 244)
        Me.cmdReviewvtr.Name = "cmdReviewvtr"
        Me.cmdReviewvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdReviewvtr.TabIndex = 698
        Me.cmdReviewvtr.Text = "Review"
        Me.cmdReviewvtr.UseVisualStyleBackColor = True
        '
        'cmdpreviewvtr
        '
        Me.cmdpreviewvtr.Location = New System.Drawing.Point(16, 247)
        Me.cmdpreviewvtr.Name = "cmdpreviewvtr"
        Me.cmdpreviewvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdpreviewvtr.TabIndex = 697
        Me.cmdpreviewvtr.Text = "Preview"
        Me.cmdpreviewvtr.UseVisualStyleBackColor = True
        '
        'cmdautoeditvtr
        '
        Me.cmdautoeditvtr.Location = New System.Drawing.Point(99, 220)
        Me.cmdautoeditvtr.Name = "cmdautoeditvtr"
        Me.cmdautoeditvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdautoeditvtr.TabIndex = 696
        Me.cmdautoeditvtr.Text = "Auto Edit"
        Me.cmdautoeditvtr.UseVisualStyleBackColor = True
        '
        'cmdrecordvtr
        '
        Me.cmdrecordvtr.Location = New System.Drawing.Point(16, 220)
        Me.cmdrecordvtr.Name = "cmdrecordvtr"
        Me.cmdrecordvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdrecordvtr.TabIndex = 695
        Me.cmdrecordvtr.Text = "Record"
        Me.cmdrecordvtr.UseVisualStyleBackColor = True
        '
        'lbljogvtr
        '
        Me.lbljogvtr.AutoSize = True
        Me.lbljogvtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljogvtr.Location = New System.Drawing.Point(145, 275)
        Me.lbljogvtr.Name = "lbljogvtr"
        Me.lbljogvtr.Size = New System.Drawing.Size(35, 20)
        Me.lbljogvtr.TabIndex = 694
        Me.lbljogvtr.Text = "Jog"
        '
        'HScrollBarjogvtr
        '
        Me.HScrollBarjogvtr.LargeChange = 1
        Me.HScrollBarjogvtr.Location = New System.Drawing.Point(7, 275)
        Me.HScrollBarjogvtr.Maximum = 118
        Me.HScrollBarjogvtr.Minimum = -118
        Me.HScrollBarjogvtr.Name = "HScrollBarjogvtr"
        Me.HScrollBarjogvtr.Size = New System.Drawing.Size(134, 13)
        Me.HScrollBarjogvtr.TabIndex = 693
        '
        'lblshuttlevtr
        '
        Me.lblshuttlevtr.AutoSize = True
        Me.lblshuttlevtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshuttlevtr.Location = New System.Drawing.Point(145, 316)
        Me.lblshuttlevtr.Name = "lblshuttlevtr"
        Me.lblshuttlevtr.Size = New System.Drawing.Size(60, 20)
        Me.lblshuttlevtr.TabIndex = 692
        Me.lblshuttlevtr.Text = "Shuttle"
        '
        'HScrollBarshuttlevtr
        '
        Me.HScrollBarshuttlevtr.LargeChange = 1
        Me.HScrollBarshuttlevtr.Location = New System.Drawing.Point(8, 323)
        Me.HScrollBarshuttlevtr.Maximum = 118
        Me.HScrollBarshuttlevtr.Minimum = -118
        Me.HScrollBarshuttlevtr.Name = "HScrollBarshuttlevtr"
        Me.HScrollBarshuttlevtr.Size = New System.Drawing.Size(134, 13)
        Me.HScrollBarshuttlevtr.TabIndex = 691
        '
        'lblvariablevtr
        '
        Me.lblvariablevtr.AutoSize = True
        Me.lblvariablevtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvariablevtr.Location = New System.Drawing.Point(145, 294)
        Me.lblvariablevtr.Name = "lblvariablevtr"
        Me.lblvariablevtr.Size = New System.Drawing.Size(48, 20)
        Me.lblvariablevtr.TabIndex = 690
        Me.lblvariablevtr.Text = "Var F"
        '
        'HScrollBarvtr
        '
        Me.HScrollBarvtr.LargeChange = 1
        Me.HScrollBarvtr.Location = New System.Drawing.Point(7, 299)
        Me.HScrollBarvtr.Maximum = 118
        Me.HScrollBarvtr.Minimum = -118
        Me.HScrollBarvtr.Name = "HScrollBarvtr"
        Me.HScrollBarvtr.Size = New System.Drawing.Size(134, 13)
        Me.HScrollBarvtr.TabIndex = 689
        '
        'dgvcuepointsvtr
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcuepointsvtr.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvcuepointsvtr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcuepointsvtr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvcuepointsvtr.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvcuepointsvtr.Location = New System.Drawing.Point(190, 73)
        Me.dgvcuepointsvtr.Name = "dgvcuepointsvtr"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcuepointsvtr.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvcuepointsvtr.Size = New System.Drawing.Size(139, 163)
        Me.dgvcuepointsvtr.TabIndex = 688
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Time Code"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 70
        '
        'cmdmarkvtr
        '
        Me.cmdmarkvtr.Location = New System.Drawing.Point(230, 41)
        Me.cmdmarkvtr.Name = "cmdmarkvtr"
        Me.cmdmarkvtr.Size = New System.Drawing.Size(53, 27)
        Me.cmdmarkvtr.TabIndex = 687
        Me.cmdmarkvtr.Text = "Mark"
        Me.cmdmarkvtr.UseVisualStyleBackColor = True
        '
        'cmdcuevtr
        '
        Me.cmdcuevtr.Location = New System.Drawing.Point(334, 70)
        Me.cmdcuevtr.Name = "cmdcuevtr"
        Me.cmdcuevtr.Size = New System.Drawing.Size(34, 169)
        Me.cmdcuevtr.TabIndex = 686
        Me.cmdcuevtr.Text = "Cue"
        Me.cmdcuevtr.UseVisualStyleBackColor = True
        '
        'cmdPreRollvtr
        '
        Me.cmdPreRollvtr.Location = New System.Drawing.Point(16, 146)
        Me.cmdPreRollvtr.Name = "cmdPreRollvtr"
        Me.cmdPreRollvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdPreRollvtr.TabIndex = 685
        Me.cmdPreRollvtr.Text = "PreRoll"
        Me.cmdPreRollvtr.UseVisualStyleBackColor = True
        '
        'cmdejectvtr
        '
        Me.cmdejectvtr.Location = New System.Drawing.Point(99, 146)
        Me.cmdejectvtr.Name = "cmdejectvtr"
        Me.cmdejectvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdejectvtr.TabIndex = 684
        Me.cmdejectvtr.Text = "Eject"
        Me.cmdejectvtr.UseVisualStyleBackColor = True
        '
        'cmdstandbyoffvtr
        '
        Me.cmdstandbyoffvtr.Location = New System.Drawing.Point(99, 171)
        Me.cmdstandbyoffvtr.Name = "cmdstandbyoffvtr"
        Me.cmdstandbyoffvtr.Size = New System.Drawing.Size(86, 23)
        Me.cmdstandbyoffvtr.TabIndex = 683
        Me.cmdstandbyoffvtr.Text = "Standby OFF"
        Me.cmdstandbyoffvtr.UseVisualStyleBackColor = True
        '
        'cmdstandbyonvtr
        '
        Me.cmdstandbyonvtr.Location = New System.Drawing.Point(16, 171)
        Me.cmdstandbyonvtr.Name = "cmdstandbyonvtr"
        Me.cmdstandbyonvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdstandbyonvtr.TabIndex = 682
        Me.cmdstandbyonvtr.Text = "Standby ON"
        Me.cmdstandbyonvtr.UseVisualStyleBackColor = True
        '
        'lbltimecode
        '
        Me.lbltimecode.AutoSize = True
        Me.lbltimecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimecode.Location = New System.Drawing.Point(192, 10)
        Me.lbltimecode.Name = "lbltimecode"
        Me.lbltimecode.Size = New System.Drawing.Size(134, 29)
        Me.lbltimecode.TabIndex = 681
        Me.lbltimecode.Text = "Time Code"
        '
        'cmdffvtr
        '
        Me.cmdffvtr.Location = New System.Drawing.Point(99, 82)
        Me.cmdffvtr.Name = "cmdffvtr"
        Me.cmdffvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdffvtr.TabIndex = 680
        Me.cmdffvtr.Text = "Fast FW"
        Me.cmdffvtr.UseVisualStyleBackColor = True
        '
        'cmdstopvtr
        '
        Me.cmdstopvtr.Location = New System.Drawing.Point(99, 59)
        Me.cmdstopvtr.Name = "cmdstopvtr"
        Me.cmdstopvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdstopvtr.TabIndex = 679
        Me.cmdstopvtr.Text = "Stop"
        Me.cmdstopvtr.UseVisualStyleBackColor = True
        '
        'cmdrewindvtr
        '
        Me.cmdrewindvtr.Location = New System.Drawing.Point(16, 82)
        Me.cmdrewindvtr.Name = "cmdrewindvtr"
        Me.cmdrewindvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdrewindvtr.TabIndex = 678
        Me.cmdrewindvtr.Text = "Rewind"
        Me.cmdrewindvtr.UseVisualStyleBackColor = True
        '
        'cmdoutpointvtr
        '
        Me.cmdoutpointvtr.Location = New System.Drawing.Point(99, 122)
        Me.cmdoutpointvtr.Name = "cmdoutpointvtr"
        Me.cmdoutpointvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdoutpointvtr.TabIndex = 677
        Me.cmdoutpointvtr.Text = "Out"
        Me.cmdoutpointvtr.UseVisualStyleBackColor = True
        '
        'cmdinpointvtr
        '
        Me.cmdinpointvtr.Location = New System.Drawing.Point(16, 122)
        Me.cmdinpointvtr.Name = "cmdinpointvtr"
        Me.cmdinpointvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdinpointvtr.TabIndex = 676
        Me.cmdinpointvtr.Text = "In"
        Me.cmdinpointvtr.UseVisualStyleBackColor = True
        '
        'cmdplayvtr
        '
        Me.cmdplayvtr.Location = New System.Drawing.Point(16, 59)
        Me.cmdplayvtr.Name = "cmdplayvtr"
        Me.cmdplayvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdplayvtr.TabIndex = 675
        Me.cmdplayvtr.Text = "Play"
        Me.cmdplayvtr.UseVisualStyleBackColor = True
        '
        'cmdopenportsvtr
        '
        Me.cmdopenportsvtr.Location = New System.Drawing.Point(112, 18)
        Me.cmdopenportsvtr.Name = "cmdopenportsvtr"
        Me.cmdopenportsvtr.Size = New System.Drawing.Size(53, 23)
        Me.cmdopenportsvtr.TabIndex = 674
        Me.cmdopenportsvtr.Text = "Open"
        Me.cmdopenportsvtr.UseVisualStyleBackColor = True
        '
        'lblcomportsvtr
        '
        Me.lblcomportsvtr.AutoSize = True
        Me.lblcomportsvtr.Location = New System.Drawing.Point(14, 22)
        Me.lblcomportsvtr.Name = "lblcomportsvtr"
        Me.lblcomportsvtr.Size = New System.Drawing.Size(31, 13)
        Me.lblcomportsvtr.TabIndex = 673
        Me.lblcomportsvtr.Text = "Ports"
        '
        'cmbportsvtr
        '
        Me.cmbportsvtr.FormattingEnabled = True
        Me.cmbportsvtr.Location = New System.Drawing.Point(52, 19)
        Me.cmbportsvtr.Name = "cmbportsvtr"
        Me.cmbportsvtr.Size = New System.Drawing.Size(55, 21)
        Me.cmbportsvtr.TabIndex = 672
        Me.cmbportsvtr.Text = "COM3"
        '
        'txt422receive
        '
        Me.txt422receive.Location = New System.Drawing.Point(7, 46)
        Me.txt422receive.Multiline = True
        Me.txt422receive.Name = "txt422receive"
        Me.txt422receive.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt422receive.Size = New System.Drawing.Size(191, 38)
        Me.txt422receive.TabIndex = 18
        '
        't2
        '
        Me.t2.Location = New System.Drawing.Point(56, 19)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(40, 20)
        Me.t2.TabIndex = 709
        Me.t2.Text = "18"
        '
        't1
        '
        Me.t1.Location = New System.Drawing.Point(7, 20)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(43, 20)
        Me.t1.TabIndex = 707
        Me.t1.Text = "B0"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(109, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(51, 23)
        Me.Button6.TabIndex = 708
        Me.Button6.Text = "Send"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'gbRemoteLogging
        '
        Me.gbRemoteLogging.BackColor = System.Drawing.Color.Wheat
        Me.gbRemoteLogging.Controls.Add(Me.cmdplaytcp)
        Me.gbRemoteLogging.Controls.Add(Me.cmdtcpsend)
        Me.gbRemoteLogging.Controls.Add(Me.txttcpsend)
        Me.gbRemoteLogging.Controls.Add(Me.Label3)
        Me.gbRemoteLogging.Controls.Add(Me.Label276)
        Me.gbRemoteLogging.Controls.Add(Me.cmbportgbRemoteLogging)
        Me.gbRemoteLogging.Controls.Add(Me.txtgbRemoteLogging)
        Me.gbRemoteLogging.Controls.Add(Me.cmddisConnectRemoteLogging)
        Me.gbRemoteLogging.Controls.Add(Me.cmdConnectRemoteLogging)
        Me.gbRemoteLogging.Controls.Add(Me.cmbhost)
        Me.gbRemoteLogging.Controls.Add(Me.lblhost)
        Me.gbRemoteLogging.Location = New System.Drawing.Point(6, 6)
        Me.gbRemoteLogging.Name = "gbRemoteLogging"
        Me.gbRemoteLogging.Size = New System.Drawing.Size(574, 483)
        Me.gbRemoteLogging.TabIndex = 1175
        Me.gbRemoteLogging.TabStop = False
        Me.gbRemoteLogging.Text = "TCP"
        '
        'cmdplaytcp
        '
        Me.cmdplaytcp.Location = New System.Drawing.Point(102, 70)
        Me.cmdplaytcp.Name = "cmdplaytcp"
        Me.cmdplaytcp.Size = New System.Drawing.Size(84, 23)
        Me.cmdplaytcp.TabIndex = 16
        Me.cmdplaytcp.Text = "Play"
        Me.cmdplaytcp.UseVisualStyleBackColor = True
        '
        'cmdtcpsend
        '
        Me.cmdtcpsend.Location = New System.Drawing.Point(174, 50)
        Me.cmdtcpsend.Name = "cmdtcpsend"
        Me.cmdtcpsend.Size = New System.Drawing.Size(84, 23)
        Me.cmdtcpsend.TabIndex = 15
        Me.cmdtcpsend.Text = "Send"
        Me.cmdtcpsend.UseVisualStyleBackColor = True
        '
        'txttcpsend
        '
        Me.txttcpsend.Location = New System.Drawing.Point(3, 50)
        Me.txttcpsend.Name = "txttcpsend"
        Me.txttcpsend.Size = New System.Drawing.Size(165, 20)
        Me.txttcpsend.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Response"
        '
        'Label276
        '
        Me.Label276.AutoSize = True
        Me.Label276.Location = New System.Drawing.Point(9, 26)
        Me.Label276.Name = "Label276"
        Me.Label276.Size = New System.Drawing.Size(26, 13)
        Me.Label276.TabIndex = 10
        Me.Label276.Text = "Port"
        '
        'cmbportgbRemoteLogging
        '
        Me.cmbportgbRemoteLogging.FormattingEnabled = True
        Me.cmbportgbRemoteLogging.Items.AddRange(New Object() {"557", "3250", "5250"})
        Me.cmbportgbRemoteLogging.Location = New System.Drawing.Point(41, 22)
        Me.cmbportgbRemoteLogging.Name = "cmbportgbRemoteLogging"
        Me.cmbportgbRemoteLogging.Size = New System.Drawing.Size(58, 21)
        Me.cmbportgbRemoteLogging.TabIndex = 9
        Me.cmbportgbRemoteLogging.Text = "557"
        '
        'txtgbRemoteLogging
        '
        Me.txtgbRemoteLogging.Location = New System.Drawing.Point(6, 104)
        Me.txtgbRemoteLogging.Multiline = True
        Me.txtgbRemoteLogging.Name = "txtgbRemoteLogging"
        Me.txtgbRemoteLogging.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtgbRemoteLogging.Size = New System.Drawing.Size(549, 346)
        Me.txtgbRemoteLogging.TabIndex = 8
        '
        'cmddisConnectRemoteLogging
        '
        Me.cmddisConnectRemoteLogging.Enabled = False
        Me.cmddisConnectRemoteLogging.Location = New System.Drawing.Point(183, 21)
        Me.cmddisConnectRemoteLogging.Name = "cmddisConnectRemoteLogging"
        Me.cmddisConnectRemoteLogging.Size = New System.Drawing.Size(75, 23)
        Me.cmddisConnectRemoteLogging.TabIndex = 7
        Me.cmddisConnectRemoteLogging.Text = "Disconnect"
        Me.cmddisConnectRemoteLogging.UseVisualStyleBackColor = True
        '
        'cmdConnectRemoteLogging
        '
        Me.cmdConnectRemoteLogging.Location = New System.Drawing.Point(102, 21)
        Me.cmdConnectRemoteLogging.Name = "cmdConnectRemoteLogging"
        Me.cmdConnectRemoteLogging.Size = New System.Drawing.Size(75, 23)
        Me.cmdConnectRemoteLogging.TabIndex = 6
        Me.cmdConnectRemoteLogging.Text = "Connect"
        Me.cmdConnectRemoteLogging.UseVisualStyleBackColor = True
        '
        'cmbhost
        '
        Me.cmbhost.FormattingEnabled = True
        Me.cmbhost.Items.AddRange(New Object() {"127.0.0.1", "192.168.1.1", "192.168.1.2", "192.168.1.10", "172.16.10.1"})
        Me.cmbhost.Location = New System.Drawing.Point(292, 18)
        Me.cmbhost.Name = "cmbhost"
        Me.cmbhost.Size = New System.Drawing.Size(90, 21)
        Me.cmbhost.TabIndex = 1178
        Me.cmbhost.Text = "127.0.0.1"
        '
        'lblhost
        '
        Me.lblhost.AutoSize = True
        Me.lblhost.Location = New System.Drawing.Point(264, 22)
        Me.lblhost.Name = "lblhost"
        Me.lblhost.Size = New System.Drawing.Size(29, 13)
        Me.lblhost.TabIndex = 1177
        Me.lblhost.Text = "Host"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Wheat
        Me.GroupBox1.Controls.Add(Me.txtudpportreceive)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmdstopreceive)
        Me.GroupBox1.Controls.Add(Me.cmdudpreceive)
        Me.GroupBox1.Controls.Add(Me.cmdudpsend)
        Me.GroupBox1.Controls.Add(Me.txtudpdata)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtudpport)
        Me.GroupBox1.Controls.Add(Me.txtudprereceive)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 554)
        Me.GroupBox1.TabIndex = 1176
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "UDP"
        '
        'txtudpportreceive
        '
        Me.txtudpportreceive.Location = New System.Drawing.Point(95, 96)
        Me.txtudpportreceive.Name = "txtudpportreceive"
        Me.txtudpportreceive.Size = New System.Drawing.Size(73, 20)
        Me.txtudpportreceive.TabIndex = 17
        Me.txtudpportreceive.Text = "11000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Recieve port"
        '
        'cmdstopreceive
        '
        Me.cmdstopreceive.Location = New System.Drawing.Point(187, 66)
        Me.cmdstopreceive.Name = "cmdstopreceive"
        Me.cmdstopreceive.Size = New System.Drawing.Size(84, 23)
        Me.cmdstopreceive.TabIndex = 15
        Me.cmdstopreceive.Text = "Stop Recieve"
        Me.cmdstopreceive.UseVisualStyleBackColor = True
        '
        'cmdudpreceive
        '
        Me.cmdudpreceive.Location = New System.Drawing.Point(98, 66)
        Me.cmdudpreceive.Name = "cmdudpreceive"
        Me.cmdudpreceive.Size = New System.Drawing.Size(84, 23)
        Me.cmdudpreceive.TabIndex = 14
        Me.cmdudpreceive.Text = "Recieve"
        Me.cmdudpreceive.UseVisualStyleBackColor = True
        '
        'cmdudpsend
        '
        Me.cmdudpsend.Location = New System.Drawing.Point(183, 44)
        Me.cmdudpsend.Name = "cmdudpsend"
        Me.cmdudpsend.Size = New System.Drawing.Size(84, 23)
        Me.cmdudpsend.TabIndex = 13
        Me.cmdudpsend.Text = "Send"
        Me.cmdudpsend.UseVisualStyleBackColor = True
        '
        'txtudpdata
        '
        Me.txtudpdata.Location = New System.Drawing.Point(12, 44)
        Me.txtudpdata.Name = "txtudpdata"
        Me.txtudpdata.Size = New System.Drawing.Size(165, 20)
        Me.txtudpdata.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Response"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Port"
        '
        'txtudpport
        '
        Me.txtudpport.FormattingEnabled = True
        Me.txtudpport.Location = New System.Drawing.Point(41, 18)
        Me.txtudpport.Name = "txtudpport"
        Me.txtudpport.Size = New System.Drawing.Size(58, 21)
        Me.txtudpport.TabIndex = 9
        Me.txtudpport.Text = "331"
        '
        'txtudprereceive
        '
        Me.txtudprereceive.Location = New System.Drawing.Point(12, 117)
        Me.txtudprereceive.Multiline = True
        Me.txtudprereceive.Name = "txtudprereceive"
        Me.txtudprereceive.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtudprereceive.Size = New System.Drawing.Size(539, 390)
        Me.txtudprereceive.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(183, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Disconnect"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(102, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Connect"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'sp
        '
        Me.sp.BaudRate = 38400
        Me.sp.DtrEnable = True
        Me.sp.Parity = System.IO.Ports.Parity.Odd
        Me.sp.PortName = "COM3"
        Me.sp.RtsEnable = True
        '
        'tmrgettc
        '
        Me.tmrgettc.Interval = 40
        '
        'cmdportstatus3vdcp
        '
        Me.cmdportstatus3vdcp.Location = New System.Drawing.Point(32, 34)
        Me.cmdportstatus3vdcp.Name = "cmdportstatus3vdcp"
        Me.cmdportstatus3vdcp.Size = New System.Drawing.Size(83, 23)
        Me.cmdportstatus3vdcp.TabIndex = 1180
        Me.cmdportstatus3vdcp.Text = "Port Status 3"
        Me.cmdportstatus3vdcp.UseVisualStyleBackColor = True
        '
        'cmdopenport
        '
        Me.cmdopenport.Location = New System.Drawing.Point(8, 14)
        Me.cmdopenport.Name = "cmdopenport"
        Me.cmdopenport.Size = New System.Drawing.Size(75, 23)
        Me.cmdopenport.TabIndex = 1182
        Me.cmdopenport.Text = "Open port"
        Me.cmdopenport.UseVisualStyleBackColor = True
        '
        'cmdselectport
        '
        Me.cmdselectport.Location = New System.Drawing.Point(6, 37)
        Me.cmdselectport.Name = "cmdselectport"
        Me.cmdselectport.Size = New System.Drawing.Size(75, 23)
        Me.cmdselectport.TabIndex = 1183
        Me.cmdselectport.Text = "Select port"
        Me.cmdselectport.UseVisualStyleBackColor = True
        '
        'cmdrecordvdcp
        '
        Me.cmdrecordvdcp.Location = New System.Drawing.Point(911, 265)
        Me.cmdrecordvdcp.Name = "cmdrecordvdcp"
        Me.cmdrecordvdcp.Size = New System.Drawing.Size(55, 23)
        Me.cmdrecordvdcp.TabIndex = 1190
        Me.cmdrecordvdcp.Text = "Record"
        Me.cmdrecordvdcp.UseVisualStyleBackColor = True
        '
        'cmdidlistvdcp
        '
        Me.cmdidlistvdcp.Location = New System.Drawing.Point(20, 345)
        Me.cmdidlistvdcp.Name = "cmdidlistvdcp"
        Me.cmdidlistvdcp.Size = New System.Drawing.Size(70, 23)
        Me.cmdidlistvdcp.TabIndex = 1191
        Me.cmdidlistvdcp.Text = "Get ID List"
        Me.cmdidlistvdcp.UseVisualStyleBackColor = True
        '
        'cmdcloseport
        '
        Me.cmdcloseport.Location = New System.Drawing.Point(125, 37)
        Me.cmdcloseport.Name = "cmdcloseport"
        Me.cmdcloseport.Size = New System.Drawing.Size(81, 23)
        Me.cmdcloseport.TabIndex = 1196
        Me.cmdcloseport.Text = "Close Port"
        Me.cmdcloseport.UseVisualStyleBackColor = True
        '
        'cmdplayclipname
        '
        Me.cmdplayclipname.Location = New System.Drawing.Point(550, 176)
        Me.cmdplayclipname.Name = "cmdplayclipname"
        Me.cmdplayclipname.Size = New System.Drawing.Size(73, 23)
        Me.cmdplayclipname.TabIndex = 1201
        Me.cmdplayclipname.Text = "Play Clip"
        Me.cmdplayclipname.UseVisualStyleBackColor = True
        '
        'txtActiveID
        '
        Me.txtActiveID.AutoSize = True
        Me.txtActiveID.Location = New System.Drawing.Point(599, 48)
        Me.txtActiveID.Name = "txtActiveID"
        Me.txtActiveID.Size = New System.Drawing.Size(51, 13)
        Me.txtActiveID.TabIndex = 17
        Me.txtActiveID.Text = "Active ID"
        '
        'dgvclips
        '
        Me.dgvclips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvclips.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClipName, Me.Duration})
        Me.dgvclips.ContextMenuStrip = Me.cmsdgvclips
        Me.dgvclips.Location = New System.Drawing.Point(17, 372)
        Me.dgvclips.Name = "dgvclips"
        Me.dgvclips.Size = New System.Drawing.Size(432, 157)
        Me.dgvclips.TabIndex = 1204
        '
        'ClipName
        '
        Me.ClipName.HeaderText = "Clips"
        Me.ClipName.Name = "ClipName"
        Me.ClipName.Width = 300
        '
        'Duration
        '
        Me.Duration.HeaderText = "Duration"
        Me.Duration.Name = "Duration"
        Me.Duration.Width = 70
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
        'cmdGetIdDuration
        '
        Me.cmdGetIdDuration.Location = New System.Drawing.Point(96, 346)
        Me.cmdGetIdDuration.Name = "cmdGetIdDuration"
        Me.cmdGetIdDuration.Size = New System.Drawing.Size(96, 23)
        Me.cmdGetIdDuration.TabIndex = 1205
        Me.cmdGetIdDuration.Text = "Get ID Duration"
        Me.cmdGetIdDuration.UseVisualStyleBackColor = True
        '
        'tmrRemainingDuration
        '
        Me.tmrRemainingDuration.Interval = 500
        '
        'lblRemainingDuration
        '
        Me.lblRemainingDuration.AutoSize = True
        Me.lblRemainingDuration.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.lblRemainingDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemainingDuration.ForeColor = System.Drawing.Color.Yellow
        Me.lblRemainingDuration.Location = New System.Drawing.Point(561, 11)
        Me.lblRemainingDuration.Name = "lblRemainingDuration"
        Me.lblRemainingDuration.Size = New System.Drawing.Size(125, 33)
        Me.lblRemainingDuration.TabIndex = 1209
        Me.lblRemainingDuration.Text = "Counter"
        '
        'cmdStartPlayList
        '
        Me.cmdStartPlayList.Location = New System.Drawing.Point(550, 205)
        Me.cmdStartPlayList.Name = "cmdStartPlayList"
        Me.cmdStartPlayList.Size = New System.Drawing.Size(73, 23)
        Me.cmdStartPlayList.TabIndex = 1210
        Me.cmdStartPlayList.Text = "Start Playlist"
        Me.cmdStartPlayList.UseVisualStyleBackColor = True
        '
        'tmrNextClipofPlaylist
        '
        Me.tmrNextClipofPlaylist.Interval = 2000
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightCoral
        Me.GroupBox2.Controls.Add(Me.cmbportvdcp)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmdselectport)
        Me.GroupBox2.Controls.Add(Me.cmdopenport)
        Me.GroupBox2.Controls.Add(Me.cmdcloseport)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(212, 83)
        Me.GroupBox2.TabIndex = 1211
        Me.GroupBox2.TabStop = False
        '
        'cmbportvdcp
        '
        Me.cmbportvdcp.FormattingEnabled = True
        Me.cmbportvdcp.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "-1", "-2", "-3", "-4"})
        Me.cmbportvdcp.Location = New System.Drawing.Point(89, 26)
        Me.cmbportvdcp.Name = "cmbportvdcp"
        Me.cmbportvdcp.Size = New System.Drawing.Size(34, 21)
        Me.cmbportvdcp.TabIndex = 1231
        Me.cmbportvdcp.Text = "2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 13)
        Me.Label8.TabIndex = 1230
        Me.Label8.Text = "For Recording -1   for Playing 2"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.NavajoWhite
        Me.GroupBox3.Controls.Add(Me.txt422receive)
        Me.GroupBox3.Controls.Add(Me.t2)
        Me.GroupBox3.Controls.Add(Me.t1)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Location = New System.Drawing.Point(672, 445)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(204, 99)
        Me.GroupBox3.TabIndex = 1212
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "VDCP Command and Response"
        '
        'lblclipcount
        '
        Me.lblclipcount.AutoSize = True
        Me.lblclipcount.Location = New System.Drawing.Point(228, 351)
        Me.lblclipcount.Name = "lblclipcount"
        Me.lblclipcount.Size = New System.Drawing.Size(49, 13)
        Me.lblclipcount.TabIndex = 1214
        Me.lblclipcount.Text = "ID Count"
        '
        'cmdAddNewIDs
        '
        Me.cmdAddNewIDs.Location = New System.Drawing.Point(455, 423)
        Me.cmdAddNewIDs.Name = "cmdAddNewIDs"
        Me.cmdAddNewIDs.Size = New System.Drawing.Size(85, 23)
        Me.cmdAddNewIDs.TabIndex = 1216
        Me.cmdAddNewIDs.Text = "Add New IDs"
        Me.cmdAddNewIDs.UseVisualStyleBackColor = True
        '
        'cmdRemoveDeletedIDs
        '
        Me.cmdRemoveDeletedIDs.Location = New System.Drawing.Point(455, 452)
        Me.cmdRemoveDeletedIDs.Name = "cmdRemoveDeletedIDs"
        Me.cmdRemoveDeletedIDs.Size = New System.Drawing.Size(118, 23)
        Me.cmdRemoveDeletedIDs.TabIndex = 1217
        Me.cmdRemoveDeletedIDs.Text = "Remove Deleted IDs"
        Me.cmdRemoveDeletedIDs.UseVisualStyleBackColor = True
        '
        'cmdDeleteID
        '
        Me.cmdDeleteID.Location = New System.Drawing.Point(455, 481)
        Me.cmdDeleteID.Name = "cmdDeleteID"
        Me.cmdDeleteID.Size = New System.Drawing.Size(85, 23)
        Me.cmdDeleteID.TabIndex = 1218
        Me.cmdDeleteID.Text = "Delete ID"
        Me.cmdDeleteID.UseVisualStyleBackColor = True
        '
        'cmdRenameId
        '
        Me.cmdRenameId.Location = New System.Drawing.Point(455, 510)
        Me.cmdRenameId.Name = "cmdRenameId"
        Me.cmdRenameId.Size = New System.Drawing.Size(85, 23)
        Me.cmdRenameId.TabIndex = 1219
        Me.cmdRenameId.Text = "Rename Id To"
        Me.cmdRenameId.UseVisualStyleBackColor = True
        '
        'txtNewName
        '
        Me.txtNewName.Location = New System.Drawing.Point(546, 510)
        Me.txtNewName.Name = "txtNewName"
        Me.txtNewName.Size = New System.Drawing.Size(68, 20)
        Me.txtNewName.TabIndex = 1197
        Me.txtNewName.Text = "Vimlesh1"
        '
        'cmdcuewithdata
        '
        Me.cmdcuewithdata.Location = New System.Drawing.Point(736, 172)
        Me.cmdcuewithdata.Name = "cmdcuewithdata"
        Me.cmdcuewithdata.Size = New System.Drawing.Size(96, 23)
        Me.cmdcuewithdata.TabIndex = 1220
        Me.cmdcuewithdata.Text = "Cue with data"
        Me.cmdcuewithdata.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(634, 420)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 20)
        Me.Label7.TabIndex = 1222
        Me.Label7.Text = "Jog"
        '
        'HScrollBarjogvdcp
        '
        Me.HScrollBarjogvdcp.LargeChange = 1
        Me.HScrollBarjogvdcp.Location = New System.Drawing.Point(672, 423)
        Me.HScrollBarjogvdcp.Maximum = 127
        Me.HScrollBarjogvdcp.Minimum = -127
        Me.HScrollBarjogvdcp.Name = "HScrollBarjogvdcp"
        Me.HScrollBarjogvdcp.Size = New System.Drawing.Size(194, 12)
        Me.HScrollBarjogvdcp.TabIndex = 1221
        '
        'tbvdcp
        '
        Me.tbvdcp.Location = New System.Drawing.Point(13, 15)
        Me.tbvdcp.Maximum = 2160000
        Me.tbvdcp.Name = "tbvdcp"
        Me.tbvdcp.Size = New System.Drawing.Size(377, 45)
        Me.tbvdcp.TabIndex = 1224
        '
        'cmdloadcliptoeditvdcp
        '
        Me.cmdloadcliptoeditvdcp.Location = New System.Drawing.Point(455, 394)
        Me.cmdloadcliptoeditvdcp.Name = "cmdloadcliptoeditvdcp"
        Me.cmdloadcliptoeditvdcp.Size = New System.Drawing.Size(103, 23)
        Me.cmdloadcliptoeditvdcp.TabIndex = 1225
        Me.cmdloadcliptoeditvdcp.Text = "Load Clip to Edit"
        Me.cmdloadcliptoeditvdcp.UseVisualStyleBackColor = True
        '
        'gbVDCP
        '
        Me.gbVDCP.BackColor = System.Drawing.Color.MistyRose
        Me.gbVDCP.Controls.Add(Me.GroupBox5)
        Me.gbVDCP.Controls.Add(Me.cmbSourceDriveNames)
        Me.gbVDCP.Controls.Add(Me.cmbDestinationDriveNames)
        Me.gbVDCP.Controls.Add(Me.Button4)
        Me.gbVDCP.Controls.Add(Me.cmdCopyFileTovdcp)
        Me.gbVDCP.Controls.Add(Me.txtSubclipvdcp)
        Me.gbVDCP.Controls.Add(Me.cmdselectall)
        Me.gbVDCP.Controls.Add(Me.cmddeselectall)
        Me.gbVDCP.Controls.Add(Me.dgv1)
        Me.gbVDCP.Controls.Add(Me.lblplaylistname)
        Me.gbVDCP.Controls.Add(Me.cmddeleteclip)
        Me.gbVDCP.Controls.Add(Me.cmdmoveup)
        Me.gbVDCP.Controls.Add(Me.cmdmovedown)
        Me.gbVDCP.Controls.Add(Me.cmdinsert)
        Me.gbVDCP.Controls.Add(Me.tsPlaylist)
        Me.gbVDCP.Controls.Add(Me.GroupBox4)
        Me.gbVDCP.Controls.Add(Me.nSpeedvdcp)
        Me.gbVDCP.Controls.Add(Me.cmdVariableSpeed)
        Me.gbVDCP.Controls.Add(Me.cmdEEModeAuto)
        Me.gbVDCP.Controls.Add(Me.cmdEEModeOFF)
        Me.gbVDCP.Controls.Add(Me.cmdEEModeON)
        Me.gbVDCP.Controls.Add(Me.TextBox1)
        Me.gbVDCP.Controls.Add(Me.cmdmovecommandvdcp)
        Me.gbVDCP.Controls.Add(Me.Label9)
        Me.gbVDCP.Controls.Add(Me.txtrecordfilenamevdcp)
        Me.gbVDCP.Controls.Add(Me.cmdrecordinitialisevdcp)
        Me.gbVDCP.Controls.Add(Me.cmdnewcopyvdcp)
        Me.gbVDCP.Controls.Add(Me.cmdloadcliptoeditvdcp)
        Me.gbVDCP.Controls.Add(Me.Label7)
        Me.gbVDCP.Controls.Add(Me.HScrollBarjogvdcp)
        Me.gbVDCP.Controls.Add(Me.cmdcuewithdata)
        Me.gbVDCP.Controls.Add(Me.txtNewName)
        Me.gbVDCP.Controls.Add(Me.cmdRenameId)
        Me.gbVDCP.Controls.Add(Me.cmdDeleteID)
        Me.gbVDCP.Controls.Add(Me.cmdRemoveDeletedIDs)
        Me.gbVDCP.Controls.Add(Me.cmdAddNewIDs)
        Me.gbVDCP.Controls.Add(Me.lblclipcount)
        Me.gbVDCP.Controls.Add(Me.GroupBox3)
        Me.gbVDCP.Controls.Add(Me.GroupBox2)
        Me.gbVDCP.Controls.Add(Me.cmdStartPlayList)
        Me.gbVDCP.Controls.Add(Me.lblRemainingDuration)
        Me.gbVDCP.Controls.Add(Me.cmdGetIdDuration)
        Me.gbVDCP.Controls.Add(Me.dgvclips)
        Me.gbVDCP.Controls.Add(Me.txtActiveID)
        Me.gbVDCP.Controls.Add(Me.cmdplayclipname)
        Me.gbVDCP.Controls.Add(Me.cmdidlistvdcp)
        Me.gbVDCP.Controls.Add(Me.cmdrecordvdcp)
        Me.gbVDCP.Location = New System.Drawing.Point(22, 11)
        Me.gbVDCP.Name = "gbVDCP"
        Me.gbVDCP.Size = New System.Drawing.Size(1104, 544)
        Me.gbVDCP.TabIndex = 1227
        Me.gbVDCP.TabStop = False
        Me.gbVDCP.Text = "VDCP"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox5.Controls.Add(Me.cmdvdcppause)
        Me.GroupBox5.Controls.Add(Me.cmdvdcpresume)
        Me.GroupBox5.Controls.Add(Me.cmdforwardoneframe)
        Me.GroupBox5.Controls.Add(Me.cmdbackoneframe)
        Me.GroupBox5.Controls.Add(Me.cmdvdcpstop)
        Me.GroupBox5.Controls.Add(Me.lblCurrentFrame)
        Me.GroupBox5.Controls.Add(Me.cmdcueclipvdcp)
        Me.GroupBox5.Controls.Add(Me.lbltbmax)
        Me.GroupBox5.Controls.Add(Me.tbvdcp)
        Me.GroupBox5.Location = New System.Drawing.Point(589, 336)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(411, 81)
        Me.GroupBox5.TabIndex = 1274
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GroupBox5"
        '
        'cmdvdcppause
        '
        Me.cmdvdcppause.Image = CType(resources.GetObject("cmdvdcppause.Image"), System.Drawing.Image)
        Me.cmdvdcppause.Location = New System.Drawing.Point(148, 44)
        Me.cmdvdcppause.Name = "cmdvdcppause"
        Me.cmdvdcppause.Size = New System.Drawing.Size(46, 21)
        Me.cmdvdcppause.TabIndex = 1264
        Me.ttvdcp.SetToolTip(Me.cmdvdcppause, "Pause")
        Me.cmdvdcppause.UseVisualStyleBackColor = True
        '
        'cmdvdcpresume
        '
        Me.cmdvdcpresume.Image = CType(resources.GetObject("cmdvdcpresume.Image"), System.Drawing.Image)
        Me.cmdvdcpresume.Location = New System.Drawing.Point(203, 44)
        Me.cmdvdcpresume.Name = "cmdvdcpresume"
        Me.cmdvdcpresume.Size = New System.Drawing.Size(48, 23)
        Me.cmdvdcpresume.TabIndex = 1263
        Me.ttvdcp.SetToolTip(Me.cmdvdcpresume, "Resume")
        Me.cmdvdcpresume.UseVisualStyleBackColor = True
        '
        'cmdforwardoneframe
        '
        Me.cmdforwardoneframe.Image = CType(resources.GetObject("cmdforwardoneframe.Image"), System.Drawing.Image)
        Me.cmdforwardoneframe.Location = New System.Drawing.Point(302, 42)
        Me.cmdforwardoneframe.Name = "cmdforwardoneframe"
        Me.cmdforwardoneframe.Size = New System.Drawing.Size(35, 23)
        Me.cmdforwardoneframe.TabIndex = 1262
        Me.ttvdcp.SetToolTip(Me.cmdforwardoneframe, "Forward One Frame")
        Me.cmdforwardoneframe.UseVisualStyleBackColor = True
        '
        'cmdbackoneframe
        '
        Me.cmdbackoneframe.Image = CType(resources.GetObject("cmdbackoneframe.Image"), System.Drawing.Image)
        Me.cmdbackoneframe.Location = New System.Drawing.Point(265, 41)
        Me.cmdbackoneframe.Name = "cmdbackoneframe"
        Me.cmdbackoneframe.Size = New System.Drawing.Size(31, 23)
        Me.cmdbackoneframe.TabIndex = 1261
        Me.ttvdcp.SetToolTip(Me.cmdbackoneframe, "Back One Frame")
        Me.cmdbackoneframe.UseVisualStyleBackColor = True
        '
        'cmdvdcpstop
        '
        Me.cmdvdcpstop.Image = CType(resources.GetObject("cmdvdcpstop.Image"), System.Drawing.Image)
        Me.cmdvdcpstop.Location = New System.Drawing.Point(101, 43)
        Me.cmdvdcpstop.Name = "cmdvdcpstop"
        Me.cmdvdcpstop.Size = New System.Drawing.Size(37, 23)
        Me.cmdvdcpstop.TabIndex = 1260
        Me.ttvdcp.SetToolTip(Me.cmdvdcpstop, "Stop")
        Me.cmdvdcpstop.UseVisualStyleBackColor = True
        '
        'lblCurrentFrame
        '
        Me.lblCurrentFrame.AutoSize = True
        Me.lblCurrentFrame.Location = New System.Drawing.Point(155, 28)
        Me.lblCurrentFrame.Name = "lblCurrentFrame"
        Me.lblCurrentFrame.Size = New System.Drawing.Size(73, 13)
        Me.lblCurrentFrame.TabIndex = 1257
        Me.lblCurrentFrame.Text = "Current Frame"
        '
        'cmdcueclipvdcp
        '
        Me.cmdcueclipvdcp.Image = CType(resources.GetObject("cmdcueclipvdcp.Image"), System.Drawing.Image)
        Me.cmdcueclipvdcp.Location = New System.Drawing.Point(49, 43)
        Me.cmdcueclipvdcp.Name = "cmdcueclipvdcp"
        Me.cmdcueclipvdcp.Size = New System.Drawing.Size(39, 30)
        Me.cmdcueclipvdcp.TabIndex = 1265
        Me.cmdcueclipvdcp.UseVisualStyleBackColor = True
        '
        'lbltbmax
        '
        Me.lbltbmax.AutoSize = True
        Me.lbltbmax.Location = New System.Drawing.Point(356, 10)
        Me.lbltbmax.Name = "lbltbmax"
        Me.lbltbmax.Size = New System.Drawing.Size(49, 13)
        Me.lbltbmax.TabIndex = 1256
        Me.lbltbmax.Text = "2160000"
        '
        'cmbSourceDriveNames
        '
        Me.cmbSourceDriveNames.FormattingEnabled = True
        Me.cmbSourceDriveNames.Items.AddRange(New Object() {"InternalDrive", "SxS_A", "SxS_B", "PD_ProAV", "PD_BPAV", "PD_XDROOT", "USBDrive"})
        Me.cmbSourceDriveNames.Location = New System.Drawing.Point(845, 238)
        Me.cmbSourceDriveNames.Name = "cmbSourceDriveNames"
        Me.cmbSourceDriveNames.Size = New System.Drawing.Size(121, 21)
        Me.cmbSourceDriveNames.TabIndex = 1273
        Me.cmbSourceDriveNames.Text = "InternalDrive"
        '
        'cmbDestinationDriveNames
        '
        Me.cmbDestinationDriveNames.FormattingEnabled = True
        Me.cmbDestinationDriveNames.Items.AddRange(New Object() {"InternalDrive", "SxS_A", "SxS_B", "PD_ProAV", "PD_BPAV", "PD_XDROOT", "USBDrive"})
        Me.cmbDestinationDriveNames.Location = New System.Drawing.Point(974, 237)
        Me.cmbDestinationDriveNames.Name = "cmbDestinationDriveNames"
        Me.cmbDestinationDriveNames.Size = New System.Drawing.Size(121, 21)
        Me.cmbDestinationDriveNames.TabIndex = 1272
        Me.cmbDestinationDriveNames.Text = "PD_ProAV"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(736, 88)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(155, 23)
        Me.Button4.TabIndex = 1271
        Me.Button4.Text = "New Copy 8 byte"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cmdCopyFileTovdcp
        '
        Me.cmdCopyFileTovdcp.Location = New System.Drawing.Point(736, 235)
        Me.cmdCopyFileTovdcp.Name = "cmdCopyFileTovdcp"
        Me.cmdCopyFileTovdcp.Size = New System.Drawing.Size(93, 23)
        Me.cmdCopyFileTovdcp.TabIndex = 1267
        Me.cmdCopyFileTovdcp.Text = "Copy File to"
        Me.cmdCopyFileTovdcp.UseVisualStyleBackColor = True
        '
        'txtSubclipvdcp
        '
        Me.txtSubclipvdcp.Location = New System.Drawing.Point(736, 146)
        Me.txtSubclipvdcp.Name = "txtSubclipvdcp"
        Me.txtSubclipvdcp.Size = New System.Drawing.Size(100, 20)
        Me.txtSubclipvdcp.TabIndex = 1266
        Me.txtSubclipvdcp.Text = "87654321"
        '
        'cmdselectall
        '
        Me.cmdselectall.Location = New System.Drawing.Point(355, 94)
        Me.cmdselectall.Name = "cmdselectall"
        Me.cmdselectall.Size = New System.Drawing.Size(63, 23)
        Me.cmdselectall.TabIndex = 1255
        Me.cmdselectall.Text = "Select All"
        Me.cmdselectall.UseVisualStyleBackColor = True
        '
        'cmddeselectall
        '
        Me.cmddeselectall.Location = New System.Drawing.Point(355, 121)
        Me.cmddeselectall.Name = "cmddeselectall"
        Me.cmddeselectall.Size = New System.Drawing.Size(71, 23)
        Me.cmddeselectall.TabIndex = 1254
        Me.cmddeselectall.Text = "Deselect All"
        Me.cmddeselectall.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.AllowDrop = True
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column3, Me.Column4, Me.DataGridViewTextBoxColumn2})
        Me.dgv1.Location = New System.Drawing.Point(9, 147)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(531, 192)
        Me.dgv1.TabIndex = 1253
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Clips"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 250
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
        'lblplaylistname
        '
        Me.lblplaylistname.AutoSize = True
        Me.lblplaylistname.Location = New System.Drawing.Point(14, 103)
        Me.lblplaylistname.Name = "lblplaylistname"
        Me.lblplaylistname.Size = New System.Drawing.Size(39, 13)
        Me.lblplaylistname.TabIndex = 1252
        Me.lblplaylistname.Text = "Playlist"
        '
        'cmddeleteclip
        '
        Me.cmddeleteclip.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddeleteclip.Location = New System.Drawing.Point(186, 119)
        Me.cmddeleteclip.Name = "cmddeleteclip"
        Me.cmddeleteclip.Size = New System.Drawing.Size(28, 22)
        Me.cmddeleteclip.TabIndex = 1251
        Me.cmddeleteclip.UseVisualStyleBackColor = True
        '
        'cmdmoveup
        '
        Me.cmdmoveup.Image = CType(resources.GetObject("cmdmoveup.Image"), System.Drawing.Image)
        Me.cmdmoveup.Location = New System.Drawing.Point(111, 118)
        Me.cmdmoveup.Name = "cmdmoveup"
        Me.cmdmoveup.Size = New System.Drawing.Size(28, 23)
        Me.cmdmoveup.TabIndex = 1249
        Me.cmdmoveup.UseVisualStyleBackColor = True
        '
        'cmdmovedown
        '
        Me.cmdmovedown.Image = CType(resources.GetObject("cmdmovedown.Image"), System.Drawing.Image)
        Me.cmdmovedown.Location = New System.Drawing.Point(140, 118)
        Me.cmdmovedown.Name = "cmdmovedown"
        Me.cmdmovedown.Size = New System.Drawing.Size(24, 23)
        Me.cmdmovedown.TabIndex = 1250
        Me.cmdmovedown.UseVisualStyleBackColor = True
        '
        'cmdinsert
        '
        Me.cmdinsert.Image = CType(resources.GetObject("cmdinsert.Image"), System.Drawing.Image)
        Me.cmdinsert.Location = New System.Drawing.Point(164, 118)
        Me.cmdinsert.Name = "cmdinsert"
        Me.cmdinsert.Size = New System.Drawing.Size(23, 23)
        Me.cmdinsert.TabIndex = 1248
        Me.cmdinsert.UseVisualStyleBackColor = True
        '
        'tsPlaylist
        '
        Me.tsPlaylist.Dock = System.Windows.Forms.DockStyle.None
        Me.tsPlaylist.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.SaveAsToolStripButton})
        Me.tsPlaylist.Location = New System.Drawing.Point(9, 118)
        Me.tsPlaylist.MaximumSize = New System.Drawing.Size(200, 200)
        Me.tsPlaylist.Name = "tsPlaylist"
        Me.tsPlaylist.Size = New System.Drawing.Size(104, 25)
        Me.tsPlaylist.TabIndex = 1247
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
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Enabled = False
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
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
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.DarkSalmon
        Me.GroupBox4.Controls.Add(Me.rdoPlayedDuration)
        Me.GroupBox4.Controls.Add(Me.rdoTC)
        Me.GroupBox4.Controls.Add(Me.rdoRemainduration)
        Me.GroupBox4.Location = New System.Drawing.Point(435, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(117, 67)
        Me.GroupBox4.TabIndex = 1243
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Clip Counter Type"
        '
        'rdoPlayedDuration
        '
        Me.rdoPlayedDuration.AutoSize = True
        Me.rdoPlayedDuration.Location = New System.Drawing.Point(5, 28)
        Me.rdoPlayedDuration.Name = "rdoPlayedDuration"
        Me.rdoPlayedDuration.Size = New System.Drawing.Size(100, 17)
        Me.rdoPlayedDuration.TabIndex = 1243
        Me.rdoPlayedDuration.Text = "Played Duration"
        Me.rdoPlayedDuration.UseVisualStyleBackColor = True
        '
        'rdoTC
        '
        Me.rdoTC.AutoSize = True
        Me.rdoTC.Location = New System.Drawing.Point(6, 42)
        Me.rdoTC.Name = "rdoTC"
        Me.rdoTC.Size = New System.Drawing.Size(75, 17)
        Me.rdoTC.TabIndex = 1242
        Me.rdoTC.Text = "Time code"
        Me.rdoTC.UseVisualStyleBackColor = True
        '
        'rdoRemainduration
        '
        Me.rdoRemainduration.AutoSize = True
        Me.rdoRemainduration.Checked = True
        Me.rdoRemainduration.Location = New System.Drawing.Point(4, 14)
        Me.rdoRemainduration.Name = "rdoRemainduration"
        Me.rdoRemainduration.Size = New System.Drawing.Size(110, 17)
        Me.rdoRemainduration.TabIndex = 1241
        Me.rdoRemainduration.TabStop = True
        Me.rdoRemainduration.Text = "Remaing Duration"
        Me.rdoRemainduration.UseVisualStyleBackColor = True
        '
        'nSpeedvdcp
        '
        Me.nSpeedvdcp.DecimalPlaces = 2
        Me.nSpeedvdcp.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.nSpeedvdcp.Location = New System.Drawing.Point(838, 307)
        Me.nSpeedvdcp.Maximum = New Decimal(New Integer() {127, 0, 0, 0})
        Me.nSpeedvdcp.Minimum = New Decimal(New Integer() {127, 0, 0, -2147483648})
        Me.nSpeedvdcp.Name = "nSpeedvdcp"
        Me.nSpeedvdcp.Size = New System.Drawing.Size(58, 20)
        Me.nSpeedvdcp.TabIndex = 1240
        Me.nSpeedvdcp.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'cmdVariableSpeed
        '
        Me.cmdVariableSpeed.Location = New System.Drawing.Point(736, 304)
        Me.cmdVariableSpeed.Name = "cmdVariableSpeed"
        Me.cmdVariableSpeed.Size = New System.Drawing.Size(96, 23)
        Me.cmdVariableSpeed.TabIndex = 1239
        Me.cmdVariableSpeed.Text = "Speed"
        Me.cmdVariableSpeed.UseVisualStyleBackColor = True
        '
        'cmdEEModeAuto
        '
        Me.cmdEEModeAuto.Location = New System.Drawing.Point(736, 59)
        Me.cmdEEModeAuto.Name = "cmdEEModeAuto"
        Me.cmdEEModeAuto.Size = New System.Drawing.Size(96, 23)
        Me.cmdEEModeAuto.TabIndex = 1238
        Me.cmdEEModeAuto.Text = "E-E Mode Auto"
        Me.cmdEEModeAuto.UseVisualStyleBackColor = True
        '
        'cmdEEModeOFF
        '
        Me.cmdEEModeOFF.Location = New System.Drawing.Point(736, 32)
        Me.cmdEEModeOFF.Name = "cmdEEModeOFF"
        Me.cmdEEModeOFF.Size = New System.Drawing.Size(96, 23)
        Me.cmdEEModeOFF.TabIndex = 1237
        Me.cmdEEModeOFF.Text = "E-E Mode OFF"
        Me.cmdEEModeOFF.UseVisualStyleBackColor = True
        '
        'cmdEEModeON
        '
        Me.cmdEEModeON.Location = New System.Drawing.Point(736, 6)
        Me.cmdEEModeON.Name = "cmdEEModeON"
        Me.cmdEEModeON.Size = New System.Drawing.Size(96, 23)
        Me.cmdEEModeON.TabIndex = 1236
        Me.cmdEEModeON.Text = "E-E Mode ON"
        Me.cmdEEModeON.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(873, 204)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(35, 20)
        Me.TextBox1.TabIndex = 1234
        Me.TextBox1.Text = "-1"
        '
        'cmdmovecommandvdcp
        '
        Me.cmdmovecommandvdcp.Location = New System.Drawing.Point(736, 204)
        Me.cmdmovecommandvdcp.Name = "cmdmovecommandvdcp"
        Me.cmdmovecommandvdcp.Size = New System.Drawing.Size(120, 23)
        Me.cmdmovecommandvdcp.TabIndex = 1231
        Me.cmdmovecommandvdcp.Text = "Move forward frame"
        Me.cmdmovecommandvdcp.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(228, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 65)
        Me.Label9.TabIndex = 1230
        Me.Label9.Text = "Tested on XDS PD1000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Command Sequence" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Open Port, Select Port, ID List, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Drag D" &
    "rop to clip grid" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Start playlist"
        '
        'txtrecordfilenamevdcp
        '
        Me.txtrecordfilenamevdcp.Location = New System.Drawing.Point(857, 267)
        Me.txtrecordfilenamevdcp.Name = "txtrecordfilenamevdcp"
        Me.txtrecordfilenamevdcp.Size = New System.Drawing.Size(50, 20)
        Me.txtrecordfilenamevdcp.TabIndex = 1229
        Me.txtrecordfilenamevdcp.Text = "test"
        '
        'cmdrecordinitialisevdcp
        '
        Me.cmdrecordinitialisevdcp.Location = New System.Drawing.Point(736, 265)
        Me.cmdrecordinitialisevdcp.Name = "cmdrecordinitialisevdcp"
        Me.cmdrecordinitialisevdcp.Size = New System.Drawing.Size(96, 23)
        Me.cmdrecordinitialisevdcp.TabIndex = 1228
        Me.cmdrecordinitialisevdcp.Text = "Record Initialise"
        Me.cmdrecordinitialisevdcp.UseVisualStyleBackColor = True
        '
        'cmdnewcopyvdcp
        '
        Me.cmdnewcopyvdcp.Location = New System.Drawing.Point(736, 117)
        Me.cmdnewcopyvdcp.Name = "cmdnewcopyvdcp"
        Me.cmdnewcopyvdcp.Size = New System.Drawing.Size(155, 23)
        Me.cmdnewcopyvdcp.TabIndex = 1227
        Me.cmdnewcopyvdcp.Text = "New Copy variable length"
        Me.cmdnewcopyvdcp.UseVisualStyleBackColor = True
        '
        'lblPortStatus
        '
        Me.lblPortStatus.AutoSize = True
        Me.lblPortStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortStatus.Location = New System.Drawing.Point(13, 6)
        Me.lblPortStatus.Name = "lblPortStatus"
        Me.lblPortStatus.Size = New System.Drawing.Size(102, 20)
        Me.lblPortStatus.TabIndex = 1246
        Me.lblPortStatus.Text = "Port Status 3"
        '
        'cmdportstatus1vdcp
        '
        Me.cmdportstatus1vdcp.Location = New System.Drawing.Point(32, 92)
        Me.cmdportstatus1vdcp.Name = "cmdportstatus1vdcp"
        Me.cmdportstatus1vdcp.Size = New System.Drawing.Size(83, 23)
        Me.cmdportstatus1vdcp.TabIndex = 1245
        Me.cmdportstatus1vdcp.Text = "Port Status 1"
        Me.cmdportstatus1vdcp.UseVisualStyleBackColor = True
        '
        'cmdportstatus2vdcp
        '
        Me.cmdportstatus2vdcp.Location = New System.Drawing.Point(32, 63)
        Me.cmdportstatus2vdcp.Name = "cmdportstatus2vdcp"
        Me.cmdportstatus2vdcp.Size = New System.Drawing.Size(83, 23)
        Me.cmdportstatus2vdcp.TabIndex = 1244
        Me.cmdportstatus2vdcp.Text = "Port Status 2"
        Me.cmdportstatus2vdcp.UseVisualStyleBackColor = True
        '
        'dgvstatuserrovdcp
        '
        Me.dgvstatuserrovdcp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvstatuserrovdcp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvstatuserrovdcp.Location = New System.Drawing.Point(124, 6)
        Me.dgvstatuserrovdcp.Name = "dgvstatuserrovdcp"
        Me.dgvstatuserrovdcp.Size = New System.Drawing.Size(299, 531)
        Me.dgvstatuserrovdcp.TabIndex = 1235
        '
        'Column1
        '
        Me.Column1.HeaderText = "Error"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 175
        '
        'Column2
        '
        Me.Column2.HeaderText = "Status"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 50
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.VDCPTesting)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(6, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1143, 589)
        Me.TabControl1.TabIndex = 1228
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbVDCP)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1135, 563)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "VDCP"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gbrecording)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1135, 563)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "RS 422 Nexio Native"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'VDCPTesting
        '
        Me.VDCPTesting.Controls.Add(Me.dgvstatuserrovdcp)
        Me.VDCPTesting.Controls.Add(Me.cmdportstatus3vdcp)
        Me.VDCPTesting.Controls.Add(Me.cmdportstatus2vdcp)
        Me.VDCPTesting.Controls.Add(Me.cmdportstatus1vdcp)
        Me.VDCPTesting.Controls.Add(Me.lblPortStatus)
        Me.VDCPTesting.Location = New System.Drawing.Point(4, 22)
        Me.VDCPTesting.Name = "VDCPTesting"
        Me.VDCPTesting.Padding = New System.Windows.Forms.Padding(3)
        Me.VDCPTesting.Size = New System.Drawing.Size(1135, 563)
        Me.VDCPTesting.TabIndex = 2
        Me.VDCPTesting.Text = "TabPage3"
        Me.VDCPTesting.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.gbRemoteLogging)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1135, 563)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1135, 563)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'cmdcloseportsvtr
        '
        Me.cmdcloseportsvtr.Location = New System.Drawing.Point(171, 19)
        Me.cmdcloseportsvtr.Name = "cmdcloseportsvtr"
        Me.cmdcloseportsvtr.Size = New System.Drawing.Size(53, 23)
        Me.cmdcloseportsvtr.TabIndex = 1229
        Me.cmdcloseportsvtr.Text = "Close"
        Me.cmdcloseportsvtr.UseVisualStyleBackColor = True
        '
        'ofd2
        '
        Me.ofd2.FileName = "OpenFileDialog1"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox6.Controls.Add(Me.TabControl1)
        Me.GroupBox6.Controls.Add(Me.cmdcloseportsvtr)
        Me.GroupBox6.Controls.Add(Me.lblcomportsvtr)
        Me.GroupBox6.Controls.Add(Me.cmdopenportsvtr)
        Me.GroupBox6.Controls.Add(Me.cmbportsvtr)
        Me.GroupBox6.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1153, 642)
        Me.GroupBox6.TabIndex = 1230
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = " "
        '
        'ucVDCPController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1162, 650)
        Me.Controls.Add(Me.GroupBox6)
        Me.HideOnClose = True
        Me.Name = "ucVDCPController"
        Me.Text = "VDCP Controller"
        Me.gbrecording.ResumeLayout(False)
        Me.gbrecording.PerformLayout()
        CType(Me.dgvcuepointsvtr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRemoteLogging.ResumeLayout(False)
        Me.gbRemoteLogging.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvclips, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsdgvclips.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.tbvdcp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbVDCP.ResumeLayout(False)
        Me.gbVDCP.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsPlaylist.ResumeLayout(False)
        Me.tsPlaylist.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.nSpeedvdcp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvstatuserrovdcp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.VDCPTesting.ResumeLayout(False)
        Me.VDCPTesting.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbrecording As System.Windows.Forms.GroupBox
    Friend WithEvents cmdassembleoffvtr As System.Windows.Forms.Button
    Friend WithEvents cmdassembleonvtr As System.Windows.Forms.Button
    Friend WithEvents cmdplusoneframevtr As System.Windows.Forms.Button
    Friend WithEvents cmdminusoneframevtr As System.Windows.Forms.Button
    Friend WithEvents lbloutpointvtr As System.Windows.Forms.Label
    Friend WithEvents lblinpointvtr As System.Windows.Forms.Label
    Friend WithEvents cmdReviewvtr As System.Windows.Forms.Button
    Friend WithEvents cmdpreviewvtr As System.Windows.Forms.Button
    Friend WithEvents cmdautoeditvtr As System.Windows.Forms.Button
    Friend WithEvents cmdrecordvtr As System.Windows.Forms.Button
    Friend WithEvents lbljogvtr As System.Windows.Forms.Label
    Friend WithEvents HScrollBarjogvtr As System.Windows.Forms.HScrollBar
    Friend WithEvents lblshuttlevtr As System.Windows.Forms.Label
    Friend WithEvents HScrollBarshuttlevtr As System.Windows.Forms.HScrollBar
    Friend WithEvents lblvariablevtr As System.Windows.Forms.Label
    Friend WithEvents HScrollBarvtr As System.Windows.Forms.HScrollBar
    Friend WithEvents dgvcuepointsvtr As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdmarkvtr As System.Windows.Forms.Button
    Friend WithEvents cmdcuevtr As System.Windows.Forms.Button
    Friend WithEvents cmdPreRollvtr As System.Windows.Forms.Button
    Friend WithEvents cmdejectvtr As System.Windows.Forms.Button
    Friend WithEvents cmdstandbyoffvtr As System.Windows.Forms.Button
    Friend WithEvents cmdstandbyonvtr As System.Windows.Forms.Button
    Friend WithEvents lbltimecode As System.Windows.Forms.Label
    Friend WithEvents cmdffvtr As System.Windows.Forms.Button
    Friend WithEvents cmdstopvtr As System.Windows.Forms.Button
    Friend WithEvents cmdrewindvtr As System.Windows.Forms.Button
    Friend WithEvents cmdoutpointvtr As System.Windows.Forms.Button
    Friend WithEvents cmdinpointvtr As System.Windows.Forms.Button
    Friend WithEvents cmdplayvtr As System.Windows.Forms.Button
    Friend WithEvents cmdopenportsvtr As System.Windows.Forms.Button
    Friend WithEvents lblcomportsvtr As System.Windows.Forms.Label
    Friend WithEvents cmbportsvtr As System.Windows.Forms.ComboBox
    Friend WithEvents gbRemoteLogging As System.Windows.Forms.GroupBox
    Friend WithEvents cmdtcpsend As System.Windows.Forms.Button
    Friend WithEvents txttcpsend As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label276 As System.Windows.Forms.Label
    Friend WithEvents cmbportgbRemoteLogging As System.Windows.Forms.ComboBox
    Friend WithEvents txtgbRemoteLogging As System.Windows.Forms.TextBox
    Friend WithEvents cmddisConnectRemoteLogging As System.Windows.Forms.Button
    Friend WithEvents cmdConnectRemoteLogging As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdudpsend As System.Windows.Forms.Button
    Friend WithEvents txtudpdata As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtudpport As System.Windows.Forms.ComboBox
    Friend WithEvents txtudprereceive As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cmbhost As System.Windows.Forms.ComboBox
    Friend WithEvents lblhost As System.Windows.Forms.Label
    Friend WithEvents sp As System.IO.Ports.SerialPort
    Friend WithEvents tmrgettc As System.Windows.Forms.Timer
    Friend WithEvents txt422send As System.Windows.Forms.TextBox
    Friend WithEvents cmd422send As System.Windows.Forms.Button
    Friend WithEvents cmdudpreceive As System.Windows.Forms.Button
    Friend WithEvents cmdstopreceive As System.Windows.Forms.Button
    Friend WithEvents txtudpportreceive As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdplaytcp As System.Windows.Forms.Button
    Friend WithEvents txt422receive As System.Windows.Forms.TextBox
    Friend WithEvents txt422send2 As System.Windows.Forms.TextBox
    Friend WithEvents cmdportstatus3vdcp As System.Windows.Forms.Button
    Friend WithEvents cmdopenport As System.Windows.Forms.Button
    Friend WithEvents cmdselectport As System.Windows.Forms.Button
    Friend WithEvents t2 As System.Windows.Forms.TextBox
    Friend WithEvents t1 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents cmdcueclip As System.Windows.Forms.Button
    Friend WithEvents cmdrecordvdcp As System.Windows.Forms.Button
    Friend WithEvents cmdidlistvdcp As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt422send5 As System.Windows.Forms.TextBox
    Friend WithEvents txt422send4 As System.Windows.Forms.TextBox
    Friend WithEvents txt422send3 As System.Windows.Forms.TextBox
    Friend WithEvents cmd422send3command As System.Windows.Forms.Button
    Friend WithEvents cmdcloseport As System.Windows.Forms.Button
    Friend WithEvents cmdplayclipname As System.Windows.Forms.Button
    Friend WithEvents txtActiveID As System.Windows.Forms.Label
    Friend WithEvents dgvclips As System.Windows.Forms.DataGridView
    Friend WithEvents cmdGetIdDuration As System.Windows.Forms.Button
    Friend WithEvents tmrRemainingDuration As System.Windows.Forms.Timer
    Friend WithEvents cmsdgvclips As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CueInCsparcgToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayInCasparcgToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileInformationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblRemainingDuration As System.Windows.Forms.Label
    Friend WithEvents cmdStartPlayList As System.Windows.Forms.Button
    Friend WithEvents tmrNextClipofPlaylist As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ClipName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Duration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblclipcount As System.Windows.Forms.Label
    Friend WithEvents cmdAddNewIDs As System.Windows.Forms.Button
    Friend WithEvents cmdRemoveDeletedIDs As System.Windows.Forms.Button
    Friend WithEvents cmdDeleteID As System.Windows.Forms.Button
    Friend WithEvents cmdRenameId As System.Windows.Forms.Button
    Friend WithEvents txtNewName As System.Windows.Forms.TextBox
    Friend WithEvents cmdcuewithdata As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents HScrollBarjogvdcp As System.Windows.Forms.HScrollBar
    Friend WithEvents tbvdcp As System.Windows.Forms.TrackBar
    Friend WithEvents cmdloadcliptoeditvdcp As System.Windows.Forms.Button
    Friend WithEvents gbVDCP As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtresponseNative As System.Windows.Forms.TextBox
    Friend WithEvents cmdnewcopyvdcp As System.Windows.Forms.Button
    Friend WithEvents cmdrecordinitialisevdcp As System.Windows.Forms.Button
    Friend WithEvents txtrecordfilenamevdcp As System.Windows.Forms.TextBox
    Friend WithEvents cmdcloseportsvtr As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbportvdcp As System.Windows.Forms.ComboBox
    Friend WithEvents cmdmovecommandvdcp As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents dgvstatuserrovdcp As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdEEModeAuto As System.Windows.Forms.Button
    Friend WithEvents cmdEEModeOFF As System.Windows.Forms.Button
    Friend WithEvents cmdEEModeON As System.Windows.Forms.Button
    Friend WithEvents cmdVariableSpeed As System.Windows.Forms.Button
    Friend WithEvents nSpeedvdcp As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoTC As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRemainduration As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPlayedDuration As System.Windows.Forms.RadioButton
    Friend WithEvents cmdportstatus1vdcp As System.Windows.Forms.Button
    Friend WithEvents cmdportstatus2vdcp As System.Windows.Forms.Button
    Friend WithEvents lblPortStatus As System.Windows.Forms.Label
    Friend WithEvents cmddeleteclip As System.Windows.Forms.Button
    Friend WithEvents cmdmoveup As System.Windows.Forms.Button
    Friend WithEvents cmdmovedown As System.Windows.Forms.Button
    Friend WithEvents cmdinsert As System.Windows.Forms.Button
    Friend WithEvents tsPlaylist As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveAsToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblplaylistname As System.Windows.Forms.Label
    Friend WithEvents osd2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ofd2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmdselectall As System.Windows.Forms.Button
    Friend WithEvents cmddeselectall As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbltbmax As System.Windows.Forms.Label
    Friend WithEvents lblCurrentFrame As System.Windows.Forms.Label
    Friend WithEvents VDCPTesting As System.Windows.Forms.TabPage
    Friend WithEvents cmdvdcpstop As System.Windows.Forms.Button
    Friend WithEvents cmdforwardoneframe As System.Windows.Forms.Button
    Friend WithEvents cmdbackoneframe As System.Windows.Forms.Button
    Friend WithEvents cmdvdcpresume As System.Windows.Forms.Button
    Friend WithEvents cmdvdcppause As System.Windows.Forms.Button
    Friend WithEvents ttvdcp As System.Windows.Forms.ToolTip
    Friend WithEvents cmdcueclipvdcp As System.Windows.Forms.Button
    Friend WithEvents txtSubclipvdcp As System.Windows.Forms.TextBox
    Friend WithEvents cmdCopyFileTovdcp As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cmbDestinationDriveNames As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSourceDriveNames As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As GroupBox
End Class
