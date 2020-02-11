<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTwitter
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbtwitter = New System.Windows.Forms.GroupBox()
        Me.cmdHtmlplay = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTwitterTemplate = New System.Windows.Forms.TextBox()
        Me.cmdreadkeyforTwitter = New System.Windows.Forms.Button()
        Me.nNumberoftweets = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtsearchbywordtwitter = New System.Windows.Forms.TextBox()
        Me.cmdtxtsearchbywordtwitter = New System.Windows.Forms.Button()
        Me.Label275 = New System.Windows.Forms.Label()
        Me.pbtwitter = New System.Windows.Forms.ProgressBar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label172 = New System.Windows.Forms.Label()
        Me.ndaysoftweet = New System.Windows.Forms.NumericUpDown()
        Me.Label171 = New System.Windows.Forms.Label()
        Me.txthashtag = New System.Windows.Forms.TextBox()
        Me.cmdsearchquerytwitterbyscreenname = New System.Windows.Forms.Button()
        Me.Label170 = New System.Windows.Forms.Label()
        Me.txtsearchlimit = New System.Windows.Forms.TextBox()
        Me.Label145 = New System.Windows.Forms.Label()
        Me.cmblayertwitter = New System.Windows.Forms.ComboBox()
        Me.cmdplaytwitter = New System.Windows.Forms.Button()
        Me.cmdnextsteptwitter = New System.Windows.Forms.Button()
        Me.cmdstoptwitter = New System.Windows.Forms.Button()
        Me.Label141 = New System.Windows.Forms.Label()
        Me.dgvtwitter = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imagelocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtAccesstokensecret = New System.Windows.Forms.TextBox()
        Me.txtAccesstokentwitter = New System.Windows.Forms.TextBox()
        Me.txtConsumersecret = New System.Windows.Forms.TextBox()
        Me.txtConsumerkey = New System.Windows.Forms.TextBox()
        Me.Label137 = New System.Windows.Forms.Label()
        Me.Label138 = New System.Windows.Forms.Label()
        Me.Label139 = New System.Windows.Forms.Label()
        Me.Label140 = New System.Windows.Forms.Label()
        Me.cmdsearchquerytwitter = New System.Windows.Forms.Button()
        Me.bwtwitter = New System.ComponentModel.BackgroundWorker()
        Me.bwtwitterscreenname = New System.ComponentModel.BackgroundWorker()
        Me.gbtwitter.SuspendLayout()
        CType(Me.nNumberoftweets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ndaysoftweet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvtwitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbtwitter
        '
        Me.gbtwitter.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.gbtwitter.Controls.Add(Me.cmdHtmlplay)
        Me.gbtwitter.Controls.Add(Me.Label2)
        Me.gbtwitter.Controls.Add(Me.txtTwitterTemplate)
        Me.gbtwitter.Controls.Add(Me.cmdreadkeyforTwitter)
        Me.gbtwitter.Controls.Add(Me.nNumberoftweets)
        Me.gbtwitter.Controls.Add(Me.GroupBox4)
        Me.gbtwitter.Controls.Add(Me.Label275)
        Me.gbtwitter.Controls.Add(Me.pbtwitter)
        Me.gbtwitter.Controls.Add(Me.GroupBox3)
        Me.gbtwitter.Controls.Add(Me.Label170)
        Me.gbtwitter.Controls.Add(Me.txtsearchlimit)
        Me.gbtwitter.Controls.Add(Me.Label145)
        Me.gbtwitter.Controls.Add(Me.cmblayertwitter)
        Me.gbtwitter.Controls.Add(Me.cmdplaytwitter)
        Me.gbtwitter.Controls.Add(Me.cmdnextsteptwitter)
        Me.gbtwitter.Controls.Add(Me.cmdstoptwitter)
        Me.gbtwitter.Controls.Add(Me.Label141)
        Me.gbtwitter.Controls.Add(Me.dgvtwitter)
        Me.gbtwitter.Controls.Add(Me.txtAccesstokensecret)
        Me.gbtwitter.Controls.Add(Me.txtAccesstokentwitter)
        Me.gbtwitter.Controls.Add(Me.txtConsumersecret)
        Me.gbtwitter.Controls.Add(Me.txtConsumerkey)
        Me.gbtwitter.Controls.Add(Me.Label137)
        Me.gbtwitter.Controls.Add(Me.Label138)
        Me.gbtwitter.Controls.Add(Me.Label139)
        Me.gbtwitter.Controls.Add(Me.Label140)
        Me.gbtwitter.Controls.Add(Me.cmdsearchquerytwitter)
        Me.gbtwitter.Location = New System.Drawing.Point(3, 2)
        Me.gbtwitter.Name = "gbtwitter"
        Me.gbtwitter.Size = New System.Drawing.Size(660, 605)
        Me.gbtwitter.TabIndex = 621
        Me.gbtwitter.TabStop = False
        Me.gbtwitter.Text = " "
        '
        'cmdHtmlplay
        '
        Me.cmdHtmlplay.BackColor = System.Drawing.Color.Green
        Me.cmdHtmlplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHtmlplay.ForeColor = System.Drawing.Color.White
        Me.cmdHtmlplay.Location = New System.Drawing.Point(443, 203)
        Me.cmdHtmlplay.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdHtmlplay.Name = "cmdHtmlplay"
        Me.cmdHtmlplay.Size = New System.Drawing.Size(149, 30)
        Me.cmdHtmlplay.TabIndex = 1174
        Me.cmdHtmlplay.Text = "Play Html FullScreen"
        Me.cmdHtmlplay.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1173
        Me.Label2.Text = "Template"
        '
        'txtTwitterTemplate
        '
        Me.txtTwitterTemplate.Location = New System.Drawing.Point(64, 18)
        Me.txtTwitterTemplate.Name = "txtTwitterTemplate"
        Me.txtTwitterTemplate.Size = New System.Drawing.Size(353, 20)
        Me.txtTwitterTemplate.TabIndex = 1172
        Me.txtTwitterTemplate.Text = "CMP/twitter/twitter"
        '
        'cmdreadkeyforTwitter
        '
        Me.cmdreadkeyforTwitter.Location = New System.Drawing.Point(6, 214)
        Me.cmdreadkeyforTwitter.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdreadkeyforTwitter.Name = "cmdreadkeyforTwitter"
        Me.cmdreadkeyforTwitter.Size = New System.Drawing.Size(90, 25)
        Me.cmdreadkeyforTwitter.TabIndex = 729
        Me.cmdreadkeyforTwitter.Text = "Read d:/key.txt"
        Me.cmdreadkeyforTwitter.UseVisualStyleBackColor = True
        '
        'nNumberoftweets
        '
        Me.nNumberoftweets.Location = New System.Drawing.Point(546, 80)
        Me.nNumberoftweets.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nNumberoftweets.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nNumberoftweets.Name = "nNumberoftweets"
        Me.nNumberoftweets.Size = New System.Drawing.Size(46, 20)
        Me.nNumberoftweets.TabIndex = 530
        Me.nNumberoftweets.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtsearchbywordtwitter)
        Me.GroupBox4.Controls.Add(Me.cmdtxtsearchbywordtwitter)
        Me.GroupBox4.Location = New System.Drawing.Point(121, 181)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(280, 39)
        Me.GroupBox4.TabIndex = 530
        Me.GroupBox4.TabStop = False
        '
        'txtsearchbywordtwitter
        '
        Me.txtsearchbywordtwitter.Location = New System.Drawing.Point(6, 12)
        Me.txtsearchbywordtwitter.Name = "txtsearchbywordtwitter"
        Me.txtsearchbywordtwitter.Size = New System.Drawing.Size(147, 20)
        Me.txtsearchbywordtwitter.TabIndex = 525
        Me.txtsearchbywordtwitter.Text = "india"
        Me.txtsearchbywordtwitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdtxtsearchbywordtwitter
        '
        Me.cmdtxtsearchbywordtwitter.Location = New System.Drawing.Point(159, 9)
        Me.cmdtxtsearchbywordtwitter.Name = "cmdtxtsearchbywordtwitter"
        Me.cmdtxtsearchbywordtwitter.Size = New System.Drawing.Size(101, 26)
        Me.cmdtxtsearchbywordtwitter.TabIndex = 523
        Me.cmdtxtsearchbywordtwitter.Text = "Search by Word"
        Me.cmdtxtsearchbywordtwitter.UseVisualStyleBackColor = True
        '
        'Label275
        '
        Me.Label275.AutoSize = True
        Me.Label275.Location = New System.Drawing.Point(534, 64)
        Me.Label275.Name = "Label275"
        Me.Label275.Size = New System.Drawing.Size(81, 13)
        Me.Label275.TabIndex = 531
        Me.Label275.Text = "Nos. Of Tweets"
        '
        'pbtwitter
        '
        Me.pbtwitter.Location = New System.Drawing.Point(64, 254)
        Me.pbtwitter.Name = "pbtwitter"
        Me.pbtwitter.Size = New System.Drawing.Size(375, 10)
        Me.pbtwitter.TabIndex = 728
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label172)
        Me.GroupBox3.Controls.Add(Me.ndaysoftweet)
        Me.GroupBox3.Controls.Add(Me.Label171)
        Me.GroupBox3.Controls.Add(Me.txthashtag)
        Me.GroupBox3.Controls.Add(Me.cmdsearchquerytwitterbyscreenname)
        Me.GroupBox3.Location = New System.Drawing.Point(443, 103)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(160, 94)
        Me.GroupBox3.TabIndex = 529
        Me.GroupBox3.TabStop = False
        '
        'Label172
        '
        Me.Label172.AutoSize = True
        Me.Label172.Location = New System.Drawing.Point(11, 52)
        Me.Label172.Name = "Label172"
        Me.Label172.Size = New System.Drawing.Size(72, 13)
        Me.Label172.TabIndex = 529
        Me.Label172.Text = "Screen Name"
        '
        'ndaysoftweet
        '
        Me.ndaysoftweet.Location = New System.Drawing.Point(97, 68)
        Me.ndaysoftweet.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.ndaysoftweet.Name = "ndaysoftweet"
        Me.ndaysoftweet.Size = New System.Drawing.Size(57, 20)
        Me.ndaysoftweet.TabIndex = 526
        Me.ndaysoftweet.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label171
        '
        Me.Label171.AutoSize = True
        Me.Label171.Location = New System.Drawing.Point(109, 51)
        Me.Label171.Name = "Label171"
        Me.Label171.Size = New System.Drawing.Size(45, 13)
        Me.Label171.TabIndex = 528
        Me.Label171.Text = "Day Old"
        '
        'txthashtag
        '
        Me.txthashtag.Location = New System.Drawing.Point(10, 68)
        Me.txthashtag.Name = "txthashtag"
        Me.txthashtag.Size = New System.Drawing.Size(81, 20)
        Me.txthashtag.TabIndex = 525
        Me.txthashtag.Text = "pmoindia"
        '
        'cmdsearchquerytwitterbyscreenname
        '
        Me.cmdsearchquerytwitterbyscreenname.Location = New System.Drawing.Point(7, 18)
        Me.cmdsearchquerytwitterbyscreenname.Name = "cmdsearchquerytwitterbyscreenname"
        Me.cmdsearchquerytwitterbyscreenname.Size = New System.Drawing.Size(142, 26)
        Me.cmdsearchquerytwitterbyscreenname.TabIndex = 523
        Me.cmdsearchquerytwitterbyscreenname.Text = "Search Screen Name"
        Me.cmdsearchquerytwitterbyscreenname.UseVisualStyleBackColor = True
        '
        'Label170
        '
        Me.Label170.AutoSize = True
        Me.Label170.Location = New System.Drawing.Point(34, 158)
        Me.Label170.Name = "Label170"
        Me.Label170.Size = New System.Drawing.Size(65, 13)
        Me.Label170.TabIndex = 527
        Me.Label170.Text = "Search Limit"
        '
        'txtsearchlimit
        '
        Me.txtsearchlimit.Enabled = False
        Me.txtsearchlimit.Location = New System.Drawing.Point(105, 155)
        Me.txtsearchlimit.Name = "txtsearchlimit"
        Me.txtsearchlimit.Size = New System.Drawing.Size(334, 20)
        Me.txtsearchlimit.TabIndex = 524
        '
        'Label145
        '
        Me.Label145.AutoSize = True
        Me.Label145.Location = New System.Drawing.Point(450, 25)
        Me.Label145.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label145.Name = "Label145"
        Me.Label145.Size = New System.Drawing.Size(108, 13)
        Me.Label145.TabIndex = 522
        Me.Label145.Text = "video layer-flash layer"
        '
        'cmblayertwitter
        '
        Me.cmblayertwitter.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmblayertwitter", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmblayertwitter.FormattingEnabled = True
        Me.cmblayertwitter.Items.AddRange(New Object() {"81", "82", "83", "84", "85"})
        Me.cmblayertwitter.Location = New System.Drawing.Point(575, 23)
        Me.cmblayertwitter.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmblayertwitter.Name = "cmblayertwitter"
        Me.cmblayertwitter.Size = New System.Drawing.Size(40, 21)
        Me.cmblayertwitter.TabIndex = 521
        Me.cmblayertwitter.Text = Global.caspar_media_playback.My.MySettings.Default.cmblayertwitter
        '
        'cmdplaytwitter
        '
        Me.cmdplaytwitter.BackColor = System.Drawing.Color.Green
        Me.cmdplaytwitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplaytwitter.ForeColor = System.Drawing.Color.White
        Me.cmdplaytwitter.Location = New System.Drawing.Point(446, 234)
        Me.cmdplaytwitter.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdplaytwitter.Name = "cmdplaytwitter"
        Me.cmdplaytwitter.Size = New System.Drawing.Size(58, 30)
        Me.cmdplaytwitter.TabIndex = 518
        Me.cmdplaytwitter.Text = "Play"
        Me.cmdplaytwitter.UseVisualStyleBackColor = False
        '
        'cmdnextsteptwitter
        '
        Me.cmdnextsteptwitter.Location = New System.Drawing.Point(508, 232)
        Me.cmdnextsteptwitter.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdnextsteptwitter.Name = "cmdnextsteptwitter"
        Me.cmdnextsteptwitter.Size = New System.Drawing.Size(66, 30)
        Me.cmdnextsteptwitter.TabIndex = 520
        Me.cmdnextsteptwitter.Text = "Next Step"
        Me.cmdnextsteptwitter.UseVisualStyleBackColor = True
        '
        'cmdstoptwitter
        '
        Me.cmdstoptwitter.BackColor = System.Drawing.Color.Red
        Me.cmdstoptwitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstoptwitter.ForeColor = System.Drawing.Color.White
        Me.cmdstoptwitter.Location = New System.Drawing.Point(575, 234)
        Me.cmdstoptwitter.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdstoptwitter.Name = "cmdstoptwitter"
        Me.cmdstoptwitter.Size = New System.Drawing.Size(60, 30)
        Me.cmdstoptwitter.TabIndex = 519
        Me.cmdstoptwitter.Text = "Stop"
        Me.cmdstoptwitter.UseVisualStyleBackColor = False
        '
        'Label141
        '
        Me.Label141.AutoSize = True
        Me.Label141.Location = New System.Drawing.Point(3, 249)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(55, 13)
        Me.Label141.TabIndex = 22
        Me.Label141.Text = "Response"
        '
        'dgvtwitter
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvtwitter.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvtwitter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtwitter.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.imagelocation})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvtwitter.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvtwitter.Location = New System.Drawing.Point(6, 267)
        Me.dgvtwitter.Name = "dgvtwitter"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvtwitter.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvtwitter.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvtwitter.Size = New System.Drawing.Size(637, 332)
        Me.dgvtwitter.TabIndex = 21
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Image"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn6.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tweet"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 375
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 375
        '
        'imagelocation
        '
        Me.imagelocation.HeaderText = "imagelocation"
        Me.imagelocation.Name = "imagelocation"
        Me.imagelocation.Width = 5
        '
        'txtAccesstokensecret
        '
        Me.txtAccesstokensecret.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtAccesstokensecret", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtAccesstokensecret.Location = New System.Drawing.Point(105, 133)
        Me.txtAccesstokensecret.Name = "txtAccesstokensecret"
        Me.txtAccesstokensecret.Size = New System.Drawing.Size(334, 20)
        Me.txtAccesstokensecret.TabIndex = 20
        Me.txtAccesstokensecret.Text = Global.caspar_media_playback.My.MySettings.Default.txtAccesstokensecret
        '
        'txtAccesstokentwitter
        '
        Me.txtAccesstokentwitter.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtAccesstokentwitter", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtAccesstokentwitter.Location = New System.Drawing.Point(105, 109)
        Me.txtAccesstokentwitter.Name = "txtAccesstokentwitter"
        Me.txtAccesstokentwitter.Size = New System.Drawing.Size(334, 20)
        Me.txtAccesstokentwitter.TabIndex = 19
        Me.txtAccesstokentwitter.Text = Global.caspar_media_playback.My.MySettings.Default.txtAccesstokentwitter
        '
        'txtConsumersecret
        '
        Me.txtConsumersecret.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtConsumersecret", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtConsumersecret.Location = New System.Drawing.Point(105, 86)
        Me.txtConsumersecret.Name = "txtConsumersecret"
        Me.txtConsumersecret.Size = New System.Drawing.Size(334, 20)
        Me.txtConsumersecret.TabIndex = 18
        Me.txtConsumersecret.Text = Global.caspar_media_playback.My.MySettings.Default.txtConsumersecret
        '
        'txtConsumerkey
        '
        Me.txtConsumerkey.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtConsumerkey", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtConsumerkey.Location = New System.Drawing.Point(105, 63)
        Me.txtConsumerkey.Name = "txtConsumerkey"
        Me.txtConsumerkey.Size = New System.Drawing.Size(334, 20)
        Me.txtConsumerkey.TabIndex = 17
        Me.txtConsumerkey.Text = Global.caspar_media_playback.My.MySettings.Default.txtConsumerkey
        '
        'Label137
        '
        Me.Label137.AutoSize = True
        Me.Label137.Location = New System.Drawing.Point(-1, 134)
        Me.Label137.Name = "Label137"
        Me.Label137.Size = New System.Drawing.Size(104, 13)
        Me.Label137.TabIndex = 16
        Me.Label137.Text = "Access token secret"
        '
        'Label138
        '
        Me.Label138.AutoSize = True
        Me.Label138.Location = New System.Drawing.Point(31, 112)
        Me.Label138.Name = "Label138"
        Me.Label138.Size = New System.Drawing.Size(72, 13)
        Me.Label138.TabIndex = 15
        Me.Label138.Text = "Access token"
        '
        'Label139
        '
        Me.Label139.AutoSize = True
        Me.Label139.Location = New System.Drawing.Point(17, 90)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(86, 13)
        Me.Label139.TabIndex = 14
        Me.Label139.Text = "Consumer secret"
        '
        'Label140
        '
        Me.Label140.AutoSize = True
        Me.Label140.Location = New System.Drawing.Point(29, 66)
        Me.Label140.Name = "Label140"
        Me.Label140.Size = New System.Drawing.Size(74, 13)
        Me.Label140.TabIndex = 13
        Me.Label140.Text = "Consumer key"
        '
        'cmdsearchquerytwitter
        '
        Me.cmdsearchquerytwitter.Location = New System.Drawing.Point(444, 62)
        Me.cmdsearchquerytwitter.Name = "cmdsearchquerytwitter"
        Me.cmdsearchquerytwitter.Size = New System.Drawing.Size(90, 45)
        Me.cmdsearchquerytwitter.TabIndex = 11
        Me.cmdsearchquerytwitter.Text = "Search HomeTimeLine"
        Me.cmdsearchquerytwitter.UseVisualStyleBackColor = True
        '
        'bwtwitter
        '
        Me.bwtwitter.WorkerSupportsCancellation = True
        '
        'bwtwitterscreenname
        '
        Me.bwtwitterscreenname.WorkerSupportsCancellation = True
        '
        'ucTwitter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(668, 610)
        Me.Controls.Add(Me.gbtwitter)
        Me.HideOnClose = True
        Me.Name = "ucTwitter"
        Me.Text = "Twitter"
        Me.gbtwitter.ResumeLayout(False)
        Me.gbtwitter.PerformLayout()
        CType(Me.nNumberoftweets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ndaysoftweet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvtwitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbtwitter As System.Windows.Forms.GroupBox
    Friend WithEvents nNumberoftweets As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsearchbywordtwitter As System.Windows.Forms.TextBox
    Friend WithEvents cmdtxtsearchbywordtwitter As System.Windows.Forms.Button
    Friend WithEvents Label275 As System.Windows.Forms.Label
    Friend WithEvents pbtwitter As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label172 As System.Windows.Forms.Label
    Friend WithEvents ndaysoftweet As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label171 As System.Windows.Forms.Label
    Friend WithEvents txthashtag As System.Windows.Forms.TextBox
    Friend WithEvents cmdsearchquerytwitterbyscreenname As System.Windows.Forms.Button
    Friend WithEvents Label170 As System.Windows.Forms.Label
    Friend WithEvents txtsearchlimit As System.Windows.Forms.TextBox
    Friend WithEvents Label145 As System.Windows.Forms.Label
    Friend WithEvents cmblayertwitter As System.Windows.Forms.ComboBox
    Friend WithEvents cmdplaytwitter As System.Windows.Forms.Button
    Friend WithEvents cmdnextsteptwitter As System.Windows.Forms.Button
    Friend WithEvents cmdstoptwitter As System.Windows.Forms.Button
    Friend WithEvents Label141 As System.Windows.Forms.Label
    Friend WithEvents dgvtwitter As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents imagelocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtAccesstokensecret As System.Windows.Forms.TextBox
    Friend WithEvents txtAccesstokentwitter As System.Windows.Forms.TextBox
    Friend WithEvents txtConsumersecret As System.Windows.Forms.TextBox
    Friend WithEvents txtConsumerkey As System.Windows.Forms.TextBox
    Friend WithEvents Label137 As System.Windows.Forms.Label
    Friend WithEvents Label138 As System.Windows.Forms.Label
    Friend WithEvents Label139 As System.Windows.Forms.Label
    Friend WithEvents Label140 As System.Windows.Forms.Label
    Friend WithEvents cmdsearchquerytwitter As System.Windows.Forms.Button
    Friend WithEvents bwtwitter As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwtwitterscreenname As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmdreadkeyforTwitter As System.Windows.Forms.Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTwitterTemplate As TextBox
    Friend WithEvents cmdHtmlplay As Button
End Class
