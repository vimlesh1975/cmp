<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucytlive
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucytlive))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdCreate = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStreamKey = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cmbPrivacyStatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdGetStatus = New System.Windows.Forms.Button()
        Me.cmdTesting = New System.Windows.Forms.Button()
        Me.cmbTitle = New System.Windows.Forms.ComboBox()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.lbllifecyclestatus = New System.Windows.Forms.Label()
        Me.cmdEndLive = New System.Windows.Forms.Button()
        Me.cmdGoLive = New System.Windows.Forms.Button()
        Me.lblCreate = New System.Windows.Forms.Label()
        Me.cmdCreateytobject = New System.Windows.Forms.Button()
        Me.lstLiveBroadcast = New System.Windows.Forms.ListBox()
        Me.lstlLiveStream = New System.Windows.Forms.ListBox()
        Me.cmdDeleteBroadcastStraem = New System.Windows.Forms.Button()
        Me.cmdListBroadcastStream = New System.Windows.Forms.Button()
        Me.cmdDeleteAllBroadcast = New System.Windows.Forms.Button()
        Me.cmdListBroadcast = New System.Windows.Forms.Button()
        Me.lblytoblect = New System.Windows.Forms.Label()
        Me.lbllistbroadcast = New System.Windows.Forms.Label()
        Me.lbldeletebroadcast = New System.Windows.Forms.Label()
        Me.lbllistStream = New System.Windows.Forms.Label()
        Me.lbldleteStream = New System.Windows.Forms.Label()
        Me.lstbroadcastTitle = New System.Windows.Forms.ListBox()
        Me.lstlLiveStreamTitle = New System.Windows.Forms.ListBox()
        Me.lstkey = New System.Windows.Forms.ListBox()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.cmdLogout = New System.Windows.Forms.Button()
        Me.cmdSelectForLive = New System.Windows.Forms.Button()
        Me.cmdBindSelectedBroadcastwithSelectedStream = New System.Windows.Forms.Button()
        Me.lblBind = New System.Windows.Forms.Label()
        Me.cmdCreateBroadcastStream = New System.Windows.Forms.Button()
        Me.txtbsTitle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCreateBrodcastStream = New System.Windows.Forms.Label()
        Me.tmrStatus = New System.Windows.Forms.Timer(Me.components)
        Me.cmdListLiveBroadcast = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblUploadStatus = New System.Windows.Forms.Label()
        Me.cmdUpload = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdSelectforSchedule = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.tmrStatusOnOff = New System.Windows.Forms.Timer(Me.components)
        Me.tmrstartLive = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEndLive = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPreparelive = New System.Windows.Forms.Timer(Me.components)
        Me.lblscheduleList = New System.Windows.Forms.Label()
        Me.deleteschedule = New System.Windows.Forms.Button()
        Me.addschedule = New System.Windows.Forms.Button()
        Me.cmdStopSchedule = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbltestshedulerecording = New System.Windows.Forms.Label()
        Me.dgvscheduler = New System.Windows.Forms.DataGridView()
        Me.tmrcommandschedulestart = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblErrors = New System.Windows.Forms.Label()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.cmdofd1 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvscheduler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCreate
        '
        Me.cmdCreate.BackColor = System.Drawing.Color.Yellow
        Me.cmdCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreate.Location = New System.Drawing.Point(38, 164)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(85, 38)
        Me.cmdCreate.TabIndex = 0
        Me.cmdCreate.Text = "Create"
        Me.cmdCreate.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(75, 96)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(75, 120)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel2.TabIndex = 3
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "LinkLabel2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "To See"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "To Manage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Title"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Stream Key"
        '
        'txtStreamKey
        '
        Me.txtStreamKey.Location = New System.Drawing.Point(75, 141)
        Me.txtStreamKey.Name = "txtStreamKey"
        Me.txtStreamKey.Size = New System.Drawing.Size(221, 20)
        Me.txtStreamKey.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Time"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(75, 46)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(205, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'cmbPrivacyStatus
        '
        Me.cmbPrivacyStatus.FormattingEnabled = True
        Me.cmbPrivacyStatus.Items.AddRange(New Object() {"public", "private", "unlisted"})
        Me.cmbPrivacyStatus.Location = New System.Drawing.Point(75, 72)
        Me.cmbPrivacyStatus.Name = "cmbPrivacyStatus"
        Me.cmbPrivacyStatus.Size = New System.Drawing.Size(101, 21)
        Me.cmbPrivacyStatus.TabIndex = 17
        Me.cmbPrivacyStatus.Text = "private"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightPink
        Me.GroupBox1.Controls.Add(Me.cmdGetStatus)
        Me.GroupBox1.Controls.Add(Me.cmdTesting)
        Me.GroupBox1.Controls.Add(Me.cmbTitle)
        Me.GroupBox1.Controls.Add(Me.lblUpdate)
        Me.GroupBox1.Controls.Add(Me.cmdUpdate)
        Me.GroupBox1.Controls.Add(Me.lbllifecyclestatus)
        Me.GroupBox1.Controls.Add(Me.cmdEndLive)
        Me.GroupBox1.Controls.Add(Me.cmdGoLive)
        Me.GroupBox1.Controls.Add(Me.lblCreate)
        Me.GroupBox1.Controls.Add(Me.cmbPrivacyStatus)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtStreamKey)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.cmdCreate)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 278)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Shedule Live"
        '
        'cmdGetStatus
        '
        Me.cmdGetStatus.Location = New System.Drawing.Point(10, 225)
        Me.cmdGetStatus.Name = "cmdGetStatus"
        Me.cmdGetStatus.Size = New System.Drawing.Size(98, 23)
        Me.cmdGetStatus.TabIndex = 48
        Me.cmdGetStatus.Text = "Get Status"
        Me.cmdGetStatus.UseVisualStyleBackColor = True
        '
        'cmdTesting
        '
        Me.cmdTesting.Enabled = False
        Me.cmdTesting.Location = New System.Drawing.Point(10, 249)
        Me.cmdTesting.Name = "cmdTesting"
        Me.cmdTesting.Size = New System.Drawing.Size(98, 23)
        Me.cmdTesting.TabIndex = 47
        Me.cmdTesting.Text = "Prepare For LIve"
        Me.cmdTesting.UseVisualStyleBackColor = True
        '
        'cmbTitle
        '
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"साडेआठच्या बातम्या Live दि.", "अकराच्या बातम्या Live दि.", "एकच्या बातम्या Live दि.", "साडेचारच्या बातम्या Live दि.", "सातच्या बातम्या Live दि.", "साडेनऊच्या बातम्या Live दि."})
        Me.cmbTitle.Location = New System.Drawing.Point(75, 19)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(224, 21)
        Me.cmbTitle.TabIndex = 46
        Me.cmbTitle.Text = "साडेआठच्या बातम्या Live दि."
        '
        'lblUpdate
        '
        Me.lblUpdate.AutoSize = True
        Me.lblUpdate.Location = New System.Drawing.Point(132, 205)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(71, 13)
        Me.lblUpdate.TabIndex = 45
        Me.lblUpdate.Text = "Update Label"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.Color.Yellow
        Me.cmdUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(129, 164)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(85, 38)
        Me.cmdUpdate.TabIndex = 44
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = False
        '
        'lbllifecyclestatus
        '
        Me.lbllifecyclestatus.AutoSize = True
        Me.lbllifecyclestatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllifecyclestatus.ForeColor = System.Drawing.Color.Red
        Me.lbllifecyclestatus.Location = New System.Drawing.Point(112, 223)
        Me.lbllifecyclestatus.Name = "lbllifecyclestatus"
        Me.lbllifecyclestatus.Size = New System.Drawing.Size(79, 25)
        Me.lbllifecyclestatus.TabIndex = 43
        Me.lbllifecyclestatus.Text = "Status"
        '
        'cmdEndLive
        '
        Me.cmdEndLive.Enabled = False
        Me.cmdEndLive.Location = New System.Drawing.Point(192, 249)
        Me.cmdEndLive.Name = "cmdEndLive"
        Me.cmdEndLive.Size = New System.Drawing.Size(75, 23)
        Me.cmdEndLive.TabIndex = 41
        Me.cmdEndLive.Text = "End Live"
        Me.cmdEndLive.UseVisualStyleBackColor = True
        '
        'cmdGoLive
        '
        Me.cmdGoLive.Enabled = False
        Me.cmdGoLive.Location = New System.Drawing.Point(114, 249)
        Me.cmdGoLive.Name = "cmdGoLive"
        Me.cmdGoLive.Size = New System.Drawing.Size(75, 23)
        Me.cmdGoLive.TabIndex = 40
        Me.cmdGoLive.Text = "Go Live"
        Me.cmdGoLive.UseVisualStyleBackColor = True
        '
        'lblCreate
        '
        Me.lblCreate.AutoSize = True
        Me.lblCreate.Location = New System.Drawing.Point(45, 205)
        Me.lblCreate.Name = "lblCreate"
        Me.lblCreate.Size = New System.Drawing.Size(63, 13)
        Me.lblCreate.TabIndex = 39
        Me.lblCreate.Text = "Create label"
        '
        'cmdCreateytobject
        '
        Me.cmdCreateytobject.BackColor = System.Drawing.Color.Yellow
        Me.cmdCreateytobject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreateytobject.Location = New System.Drawing.Point(110, 25)
        Me.cmdCreateytobject.Name = "cmdCreateytobject"
        Me.cmdCreateytobject.Size = New System.Drawing.Size(81, 34)
        Me.cmdCreateytobject.TabIndex = 18
        Me.cmdCreateytobject.Text = "Login"
        Me.cmdCreateytobject.UseVisualStyleBackColor = False
        '
        'lstLiveBroadcast
        '
        Me.lstLiveBroadcast.FormattingEnabled = True
        Me.lstLiveBroadcast.HorizontalScrollbar = True
        Me.lstLiveBroadcast.Location = New System.Drawing.Point(163, 56)
        Me.lstLiveBroadcast.Name = "lstLiveBroadcast"
        Me.lstLiveBroadcast.Size = New System.Drawing.Size(89, 95)
        Me.lstLiveBroadcast.TabIndex = 33
        '
        'lstlLiveStream
        '
        Me.lstlLiveStream.FormattingEnabled = True
        Me.lstlLiveStream.HorizontalScrollbar = True
        Me.lstlLiveStream.Location = New System.Drawing.Point(3, 63)
        Me.lstlLiveStream.Name = "lstlLiveStream"
        Me.lstlLiveStream.Size = New System.Drawing.Size(268, 95)
        Me.lstlLiveStream.TabIndex = 32
        '
        'cmdDeleteBroadcastStraem
        '
        Me.cmdDeleteBroadcastStraem.BackColor = System.Drawing.Color.Yellow
        Me.cmdDeleteBroadcastStraem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeleteBroadcastStraem.Location = New System.Drawing.Point(558, 70)
        Me.cmdDeleteBroadcastStraem.Name = "cmdDeleteBroadcastStraem"
        Me.cmdDeleteBroadcastStraem.Size = New System.Drawing.Size(101, 70)
        Me.cmdDeleteBroadcastStraem.TabIndex = 31
        Me.cmdDeleteBroadcastStraem.Text = "Delete Broadcast Stream"
        Me.cmdDeleteBroadcastStraem.UseVisualStyleBackColor = False
        '
        'cmdListBroadcastStream
        '
        Me.cmdListBroadcastStream.BackColor = System.Drawing.Color.Yellow
        Me.cmdListBroadcastStream.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdListBroadcastStream.Location = New System.Drawing.Point(3, 15)
        Me.cmdListBroadcastStream.Name = "cmdListBroadcastStream"
        Me.cmdListBroadcastStream.Size = New System.Drawing.Size(212, 34)
        Me.cmdListBroadcastStream.TabIndex = 30
        Me.cmdListBroadcastStream.Text = "List Broadcast Streams"
        Me.cmdListBroadcastStream.UseVisualStyleBackColor = False
        '
        'cmdDeleteAllBroadcast
        '
        Me.cmdDeleteAllBroadcast.BackColor = System.Drawing.Color.Yellow
        Me.cmdDeleteAllBroadcast.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeleteAllBroadcast.Location = New System.Drawing.Point(4, 42)
        Me.cmdDeleteAllBroadcast.Name = "cmdDeleteAllBroadcast"
        Me.cmdDeleteAllBroadcast.Size = New System.Drawing.Size(93, 45)
        Me.cmdDeleteAllBroadcast.TabIndex = 29
        Me.cmdDeleteAllBroadcast.Text = "Delete Broadcast"
        Me.cmdDeleteAllBroadcast.UseVisualStyleBackColor = False
        '
        'cmdListBroadcast
        '
        Me.cmdListBroadcast.BackColor = System.Drawing.Color.Yellow
        Me.cmdListBroadcast.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdListBroadcast.Location = New System.Drawing.Point(6, 14)
        Me.cmdListBroadcast.Name = "cmdListBroadcast"
        Me.cmdListBroadcast.Size = New System.Drawing.Size(205, 31)
        Me.cmdListBroadcast.TabIndex = 28
        Me.cmdListBroadcast.Text = "List UpComming Broadcast"
        Me.cmdListBroadcast.UseVisualStyleBackColor = False
        '
        'lblytoblect
        '
        Me.lblytoblect.AutoSize = True
        Me.lblytoblect.Location = New System.Drawing.Point(139, 10)
        Me.lblytoblect.Name = "lblytoblect"
        Me.lblytoblect.Size = New System.Drawing.Size(101, 13)
        Me.lblytoblect.TabIndex = 34
        Me.lblytoblect.Text = "Create Object Label"
        '
        'lbllistbroadcast
        '
        Me.lbllistbroadcast.AutoSize = True
        Me.lbllistbroadcast.Location = New System.Drawing.Point(253, 24)
        Me.lbllistbroadcast.Name = "lbllistbroadcast"
        Me.lbllistbroadcast.Size = New System.Drawing.Size(95, 13)
        Me.lbllistbroadcast.TabIndex = 35
        Me.lbllistbroadcast.Text = "list Broadcast label"
        '
        'lbldeletebroadcast
        '
        Me.lbldeletebroadcast.AutoSize = True
        Me.lbldeletebroadcast.Location = New System.Drawing.Point(6, 88)
        Me.lbldeletebroadcast.Name = "lbldeletebroadcast"
        Me.lbldeletebroadcast.Size = New System.Drawing.Size(108, 13)
        Me.lbldeletebroadcast.TabIndex = 36
        Me.lbldeletebroadcast.Text = "Delet Broadcast label"
        '
        'lbllistStream
        '
        Me.lbllistStream.AutoSize = True
        Me.lbllistStream.Location = New System.Drawing.Point(7, 47)
        Me.lbllistStream.Name = "lbllistStream"
        Me.lbllistStream.Size = New System.Drawing.Size(88, 13)
        Me.lbllistStream.TabIndex = 37
        Me.lbllistStream.Text = "List Stream Label"
        '
        'lbldleteStream
        '
        Me.lbldleteStream.AutoSize = True
        Me.lbldleteStream.Location = New System.Drawing.Point(558, 143)
        Me.lbldleteStream.Name = "lbldleteStream"
        Me.lbldleteStream.Size = New System.Drawing.Size(103, 13)
        Me.lbldleteStream.TabIndex = 38
        Me.lbldleteStream.Text = "Delete Stream Label"
        '
        'lstbroadcastTitle
        '
        Me.lstbroadcastTitle.Enabled = False
        Me.lstbroadcastTitle.FormattingEnabled = True
        Me.lstbroadcastTitle.HorizontalScrollbar = True
        Me.lstbroadcastTitle.Location = New System.Drawing.Point(258, 55)
        Me.lstbroadcastTitle.Name = "lstbroadcastTitle"
        Me.lstbroadcastTitle.Size = New System.Drawing.Size(207, 95)
        Me.lstbroadcastTitle.TabIndex = 39
        '
        'lstlLiveStreamTitle
        '
        Me.lstlLiveStreamTitle.Enabled = False
        Me.lstlLiveStreamTitle.FormattingEnabled = True
        Me.lstlLiveStreamTitle.HorizontalScrollbar = True
        Me.lstlLiveStreamTitle.Location = New System.Drawing.Point(277, 63)
        Me.lstlLiveStreamTitle.Name = "lstlLiveStreamTitle"
        Me.lstlLiveStreamTitle.Size = New System.Drawing.Size(127, 95)
        Me.lstlLiveStreamTitle.TabIndex = 40
        '
        'lstkey
        '
        Me.lstkey.Enabled = False
        Me.lstkey.FormattingEnabled = True
        Me.lstkey.HorizontalScrollbar = True
        Me.lstkey.Location = New System.Drawing.Point(410, 64)
        Me.lstkey.Name = "lstkey"
        Me.lstkey.Size = New System.Drawing.Size(145, 95)
        Me.lstkey.TabIndex = 41
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.Location = New System.Drawing.Point(113, 63)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(84, 16)
        Me.lbluser.TabIndex = 42
        Me.lbluser.Text = "User Label"
        '
        'picUser
        '
        Me.picUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picUser.Location = New System.Drawing.Point(4, 17)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(103, 71)
        Me.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUser.TabIndex = 46
        Me.picUser.TabStop = False
        '
        'cmdLogout
        '
        Me.cmdLogout.BackColor = System.Drawing.Color.Red
        Me.cmdLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdLogout.Location = New System.Drawing.Point(191, 22)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Size = New System.Drawing.Size(96, 34)
        Me.cmdLogout.TabIndex = 47
        Me.cmdLogout.Text = "Log OUT"
        Me.cmdLogout.UseVisualStyleBackColor = False
        '
        'cmdSelectForLive
        '
        Me.cmdSelectForLive.BackColor = System.Drawing.Color.Yellow
        Me.cmdSelectForLive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelectForLive.Location = New System.Drawing.Point(4, 104)
        Me.cmdSelectForLive.Name = "cmdSelectForLive"
        Me.cmdSelectForLive.Size = New System.Drawing.Size(154, 48)
        Me.cmdSelectForLive.TabIndex = 48
        Me.cmdSelectForLive.Text = "Select for Live" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<<---<<<"
        Me.cmdSelectForLive.UseVisualStyleBackColor = False
        '
        'cmdBindSelectedBroadcastwithSelectedStream
        '
        Me.cmdBindSelectedBroadcastwithSelectedStream.BackColor = System.Drawing.Color.Yellow
        Me.cmdBindSelectedBroadcastwithSelectedStream.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBindSelectedBroadcastwithSelectedStream.Location = New System.Drawing.Point(221, 14)
        Me.cmdBindSelectedBroadcastwithSelectedStream.Name = "cmdBindSelectedBroadcastwithSelectedStream"
        Me.cmdBindSelectedBroadcastwithSelectedStream.Size = New System.Drawing.Size(407, 34)
        Me.cmdBindSelectedBroadcastwithSelectedStream.TabIndex = 49
        Me.cmdBindSelectedBroadcastwithSelectedStream.Text = "Bind Selected Broadcast with Selected Stream"
        Me.cmdBindSelectedBroadcastwithSelectedStream.UseVisualStyleBackColor = False
        '
        'lblBind
        '
        Me.lblBind.AutoSize = True
        Me.lblBind.Location = New System.Drawing.Point(230, 47)
        Me.lblBind.Name = "lblBind"
        Me.lblBind.Size = New System.Drawing.Size(57, 13)
        Me.lblBind.TabIndex = 50
        Me.lblBind.Text = "Bind Label"
        '
        'cmdCreateBroadcastStream
        '
        Me.cmdCreateBroadcastStream.BackColor = System.Drawing.Color.Yellow
        Me.cmdCreateBroadcastStream.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreateBroadcastStream.Location = New System.Drawing.Point(31, 39)
        Me.cmdCreateBroadcastStream.Name = "cmdCreateBroadcastStream"
        Me.cmdCreateBroadcastStream.Size = New System.Drawing.Size(239, 28)
        Me.cmdCreateBroadcastStream.TabIndex = 51
        Me.cmdCreateBroadcastStream.Text = "Create Broadcast Stream"
        Me.cmdCreateBroadcastStream.UseVisualStyleBackColor = False
        '
        'txtbsTitle
        '
        Me.txtbsTitle.Location = New System.Drawing.Point(31, 20)
        Me.txtbsTitle.Name = "txtbsTitle"
        Me.txtbsTitle.Size = New System.Drawing.Size(278, 20)
        Me.txtbsTitle.TabIndex = 52
        Me.txtbsTitle.Text = "Test500"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Title"
        '
        'lblCreateBrodcastStream
        '
        Me.lblCreateBrodcastStream.AutoSize = True
        Me.lblCreateBrodcastStream.Location = New System.Drawing.Point(95, 70)
        Me.lblCreateBrodcastStream.Name = "lblCreateBrodcastStream"
        Me.lblCreateBrodcastStream.Size = New System.Drawing.Size(158, 13)
        Me.lblCreateBrodcastStream.TabIndex = 53
        Me.lblCreateBrodcastStream.Text = "Create Broadcast Stream Status"
        '
        'tmrStatus
        '
        Me.tmrStatus.Interval = 1000
        '
        'cmdListLiveBroadcast
        '
        Me.cmdListLiveBroadcast.BackColor = System.Drawing.Color.Yellow
        Me.cmdListLiveBroadcast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdListLiveBroadcast.Location = New System.Drawing.Point(354, 9)
        Me.cmdListLiveBroadcast.Name = "cmdListLiveBroadcast"
        Me.cmdListLiveBroadcast.Size = New System.Drawing.Size(177, 38)
        Me.cmdListLiveBroadcast.TabIndex = 54
        Me.cmdListLiveBroadcast.Text = "List Live Broadcast"
        Me.cmdListLiveBroadcast.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(314, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(14, 398)
        Me.Button1.TabIndex = 55
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox2.Controls.Add(Me.lblCreateBrodcastStream)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtbsTitle)
        Me.GroupBox2.Controls.Add(Me.cmdCreateBroadcastStream)
        Me.GroupBox2.Location = New System.Drawing.Point(671, 406)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 85)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Create Live Stream"
        '
        'lblUploadStatus
        '
        Me.lblUploadStatus.AutoSize = True
        Me.lblUploadStatus.Location = New System.Drawing.Point(95, 49)
        Me.lblUploadStatus.Name = "lblUploadStatus"
        Me.lblUploadStatus.Size = New System.Drawing.Size(74, 13)
        Me.lblUploadStatus.TabIndex = 55
        Me.lblUploadStatus.Text = "Upload Status"
        '
        'cmdUpload
        '
        Me.cmdUpload.Location = New System.Drawing.Point(7, 44)
        Me.cmdUpload.Name = "cmdUpload"
        Me.cmdUpload.Size = New System.Drawing.Size(74, 23)
        Me.cmdUpload.TabIndex = 54
        Me.cmdUpload.Text = "Upload"
        Me.cmdUpload.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox3.Controls.Add(Me.lblBind)
        Me.GroupBox3.Controls.Add(Me.cmdBindSelectedBroadcastwithSelectedStream)
        Me.GroupBox3.Controls.Add(Me.lstkey)
        Me.GroupBox3.Controls.Add(Me.lstlLiveStreamTitle)
        Me.GroupBox3.Controls.Add(Me.lbldleteStream)
        Me.GroupBox3.Controls.Add(Me.lbllistStream)
        Me.GroupBox3.Controls.Add(Me.lstlLiveStream)
        Me.GroupBox3.Controls.Add(Me.cmdDeleteBroadcastStraem)
        Me.GroupBox3.Controls.Add(Me.cmdListBroadcastStream)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 406)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(663, 166)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "LIve Streams"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox4.Controls.Add(Me.cmdSelectforSchedule)
        Me.GroupBox4.Controls.Add(Me.cmdSelectForLive)
        Me.GroupBox4.Controls.Add(Me.cmdListLiveBroadcast)
        Me.GroupBox4.Controls.Add(Me.lstbroadcastTitle)
        Me.GroupBox4.Controls.Add(Me.lbldeletebroadcast)
        Me.GroupBox4.Controls.Add(Me.lbllistbroadcast)
        Me.GroupBox4.Controls.Add(Me.lstLiveBroadcast)
        Me.GroupBox4.Controls.Add(Me.cmdDeleteAllBroadcast)
        Me.GroupBox4.Controls.Add(Me.cmdListBroadcast)
        Me.GroupBox4.Location = New System.Drawing.Point(333, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(663, 155)
        Me.GroupBox4.TabIndex = 58
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Live Broadcasts"
        '
        'cmdSelectforSchedule
        '
        Me.cmdSelectforSchedule.BackColor = System.Drawing.Color.Yellow
        Me.cmdSelectforSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelectforSchedule.Location = New System.Drawing.Point(471, 65)
        Me.cmdSelectforSchedule.Name = "cmdSelectforSchedule"
        Me.cmdSelectforSchedule.Size = New System.Drawing.Size(129, 84)
        Me.cmdSelectforSchedule.TabIndex = 55
        Me.cmdSelectforSchedule.Text = "Select for Schedule" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "↓↓" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "↓↓↓"
        Me.cmdSelectforSchedule.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Plum
        Me.GroupBox5.Controls.Add(Me.cmdLogout)
        Me.GroupBox5.Controls.Add(Me.picUser)
        Me.GroupBox5.Controls.Add(Me.lbluser)
        Me.GroupBox5.Controls.Add(Me.lblytoblect)
        Me.GroupBox5.Controls.Add(Me.cmdCreateytobject)
        Me.GroupBox5.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(307, 114)
        Me.GroupBox5.TabIndex = 59
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Login"
        '
        'tmrStatusOnOff
        '
        Me.tmrStatusOnOff.Interval = 10000
        '
        'tmrstartLive
        '
        Me.tmrstartLive.Interval = 1000
        '
        'tmrEndLive
        '
        Me.tmrEndLive.Interval = 1000
        '
        'tmrPreparelive
        '
        Me.tmrPreparelive.Interval = 1000
        '
        'lblscheduleList
        '
        Me.lblscheduleList.AutoSize = True
        Me.lblscheduleList.Location = New System.Drawing.Point(63, 45)
        Me.lblscheduleList.Name = "lblscheduleList"
        Me.lblscheduleList.Size = New System.Drawing.Size(19, 13)
        Me.lblscheduleList.TabIndex = 1221
        Me.lblscheduleList.Text = "dd"
        '
        'deleteschedule
        '
        Me.deleteschedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteschedule.Location = New System.Drawing.Point(58, 68)
        Me.deleteschedule.Name = "deleteschedule"
        Me.deleteschedule.Size = New System.Drawing.Size(56, 23)
        Me.deleteschedule.TabIndex = 1220
        Me.deleteschedule.Text = "Delete"
        Me.deleteschedule.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.deleteschedule.UseVisualStyleBackColor = True
        '
        'addschedule
        '
        Me.addschedule.Image = CType(resources.GetObject("addschedule.Image"), System.Drawing.Image)
        Me.addschedule.Location = New System.Drawing.Point(11, 68)
        Me.addschedule.Name = "addschedule"
        Me.addschedule.Size = New System.Drawing.Size(41, 23)
        Me.addschedule.TabIndex = 1219
        Me.addschedule.UseVisualStyleBackColor = True
        '
        'cmdStopSchedule
        '
        Me.cmdStopSchedule.Location = New System.Drawing.Point(241, 13)
        Me.cmdStopSchedule.Name = "cmdStopSchedule"
        Me.cmdStopSchedule.Size = New System.Drawing.Size(64, 23)
        Me.cmdStopSchedule.TabIndex = 1218
        Me.cmdStopSchedule.Text = "Stop"
        Me.cmdStopSchedule.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(7, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1217
        Me.Button2.Text = "Start"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lbltestshedulerecording
        '
        Me.lbltestshedulerecording.AutoSize = True
        Me.lbltestshedulerecording.BackColor = System.Drawing.Color.Red
        Me.lbltestshedulerecording.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltestshedulerecording.Location = New System.Drawing.Point(88, 16)
        Me.lbltestshedulerecording.Name = "lbltestshedulerecording"
        Me.lbltestshedulerecording.Size = New System.Drawing.Size(147, 20)
        Me.lbltestshedulerecording.TabIndex = 1216
        Me.lbltestshedulerecording.Text = "Schedule Stoped"
        '
        'dgvscheduler
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvscheduler.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvscheduler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvscheduler.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvscheduler.Location = New System.Drawing.Point(9, 95)
        Me.dgvscheduler.Name = "dgvscheduler"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvscheduler.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvscheduler.Size = New System.Drawing.Size(636, 137)
        Me.dgvscheduler.TabIndex = 1215
        '
        'tmrcommandschedulestart
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 42)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(45, 24)
        Me.MenuStrip1.TabIndex = 1222
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
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.NavajoWhite
        Me.GroupBox6.Controls.Add(Me.lblErrors)
        Me.GroupBox6.Controls.Add(Me.lblscheduleList)
        Me.GroupBox6.Controls.Add(Me.deleteschedule)
        Me.GroupBox6.Controls.Add(Me.addschedule)
        Me.GroupBox6.Controls.Add(Me.cmdStopSchedule)
        Me.GroupBox6.Controls.Add(Me.Button2)
        Me.GroupBox6.Controls.Add(Me.lbltestshedulerecording)
        Me.GroupBox6.Controls.Add(Me.dgvscheduler)
        Me.GroupBox6.Controls.Add(Me.MenuStrip1)
        Me.GroupBox6.Location = New System.Drawing.Point(333, 163)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(663, 237)
        Me.GroupBox6.TabIndex = 1223
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Live Scheduler Date Wsie"
        '
        'lblErrors
        '
        Me.lblErrors.AutoSize = True
        Me.lblErrors.Location = New System.Drawing.Point(311, 16)
        Me.lblErrors.Name = "lblErrors"
        Me.lblErrors.Size = New System.Drawing.Size(34, 13)
        Me.lblErrors.TabIndex = 1223
        Me.lblErrors.Text = "Errors"
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(87, 19)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(186, 13)
        Me.lblFile.TabIndex = 56
        Me.lblFile.Text = "c:/casparcg/_media/go1080p25.mp4"
        '
        'cmdofd1
        '
        Me.cmdofd1.Location = New System.Drawing.Point(6, 14)
        Me.cmdofd1.Name = "cmdofd1"
        Me.cmdofd1.Size = New System.Drawing.Size(75, 23)
        Me.cmdofd1.TabIndex = 57
        Me.cmdofd1.Text = "Open File"
        Me.cmdofd1.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Coral
        Me.GroupBox7.Controls.Add(Me.cmdofd1)
        Me.GroupBox7.Controls.Add(Me.lblFile)
        Me.GroupBox7.Controls.Add(Me.lblUploadStatus)
        Me.GroupBox7.Controls.Add(Me.cmdUpload)
        Me.GroupBox7.Location = New System.Drawing.Point(671, 497)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(326, 74)
        Me.GroupBox7.TabIndex = 1224
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "File Upload"
        '
        'ucytlive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1000, 573)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.HideOnClose = True
        Me.Name = "ucytlive"
        Me.Text = "Yt Live"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvscheduler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdCreate As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStreamKey As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cmbPrivacyStatus As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdCreateytobject As Button
    Friend WithEvents lstLiveBroadcast As ListBox
    Friend WithEvents lstlLiveStream As ListBox
    Friend WithEvents cmdDeleteBroadcastStraem As Button
    Friend WithEvents cmdListBroadcastStream As Button
    Friend WithEvents cmdDeleteAllBroadcast As Button
    Friend WithEvents cmdListBroadcast As Button
    Friend WithEvents lblytoblect As Label
    Friend WithEvents lbllistbroadcast As Label
    Friend WithEvents lbldeletebroadcast As Label
    Friend WithEvents lbllistStream As Label
    Friend WithEvents lbldleteStream As Label
    Friend WithEvents lblCreate As Label
    Friend WithEvents cmdGoLive As Button
    Friend WithEvents cmdEndLive As Button
    Friend WithEvents lstbroadcastTitle As ListBox
    Friend WithEvents lstlLiveStreamTitle As ListBox
    Friend WithEvents lstkey As ListBox
    Friend WithEvents lbllifecyclestatus As Label
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents lblUpdate As Label
    Friend WithEvents lbluser As Label
    Friend WithEvents picUser As PictureBox
    Friend WithEvents cmdLogout As Button
    Friend WithEvents cmdSelectForLive As Button
    Friend WithEvents cmbTitle As ComboBox
    Friend WithEvents cmdBindSelectedBroadcastwithSelectedStream As Button
    Friend WithEvents lblBind As Label
    Friend WithEvents cmdCreateBroadcastStream As Button
    Friend WithEvents txtbsTitle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCreateBrodcastStream As Label
    Friend WithEvents tmrStatus As Timer
    Friend WithEvents cmdListLiveBroadcast As Button
    Friend WithEvents cmdTesting As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cmdGetStatus As Button
    Friend WithEvents tmrStatusOnOff As Timer
    Friend WithEvents tmrstartLive As Timer
    Friend WithEvents tmrEndLive As Timer
    Friend WithEvents tmrPreparelive As Timer
    Friend WithEvents cmdSelectforSchedule As Button
    Friend WithEvents lblscheduleList As Label
    Friend WithEvents deleteschedule As Button
    Friend WithEvents addschedule As Button
    Friend WithEvents cmdStopSchedule As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lbltestshedulerecording As Label
    Friend WithEvents dgvscheduler As DataGridView
    Friend WithEvents tmrcommandschedulestart As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lblErrors As Label
    Friend WithEvents cmdUpload As Button
    Friend WithEvents lblUploadStatus As Label
    Friend WithEvents cmdofd1 As Button
    Friend WithEvents lblFile As Label
    Friend WithEvents GroupBox7 As GroupBox
End Class
