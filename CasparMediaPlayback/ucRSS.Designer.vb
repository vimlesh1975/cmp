<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRssFeed
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
        Me.gbrss = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbnTemplate = New System.Windows.Forms.TextBox()
        Me.txtbreakingnewsupdateinterval = New System.Windows.Forms.TextBox()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.cmdplaybreakingnews = New System.Windows.Forms.Button()
        Me.cmdstopbrekingnews = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtclockTemplate = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.cmblayertimerss = New System.Windows.Forms.ComboBox()
        Me.cmdhidetime = New System.Windows.Forms.Button()
        Me.cmdshowtime = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRSSTemplate = New System.Windows.Forms.TextBox()
        Me.cmdrssmanuallyadd = New System.Windows.Forms.Button()
        Me.nrsstable = New System.Windows.Forms.NumericUpDown()
        Me.Label167 = New System.Windows.Forms.Label()
        Me.cmdselectallrssfeed = New System.Windows.Forms.Button()
        Me.cmddeselectallrssfedd = New System.Windows.Forms.Button()
        Me.chkrssdescription = New System.Windows.Forms.CheckBox()
        Me.chkrsstitle = New System.Windows.Forms.CheckBox()
        Me.chkautomaticupdaterss = New System.Windows.Forms.CheckBox()
        Me.chkautomaticreadrss = New System.Windows.Forms.CheckBox()
        Me.txtrsstimerinterval = New System.Windows.Forms.TextBox()
        Me.lblrsstimerinterval = New System.Windows.Forms.Label()
        Me.txtrssdelemeter = New System.Windows.Forms.TextBox()
        Me.lblrssdelimeter = New System.Windows.Forms.Label()
        Me.cmdrsspause = New System.Windows.Forms.Button()
        Me.cmdrssplay = New System.Windows.Forms.Button()
        Me.cmdrssstop = New System.Windows.Forms.Button()
        Me.nrssspeed = New System.Windows.Forms.NumericUpDown()
        Me.lblrssspeed = New System.Windows.Forms.Label()
        Me.cmbrssvideoflashlayer = New System.Windows.Forms.ComboBox()
        Me.lblrssvideoflashlayer = New System.Windows.Forms.Label()
        Me.dgvrss = New System.Windows.Forms.DataGridView()
        Me.cmdrssread = New System.Windows.Forms.Button()
        Me.lblrssaddress = New System.Windows.Forms.Label()
        Me.txtrssaddress = New System.Windows.Forms.TextBox()
        Me.tmrshowdatarss = New System.Windows.Forms.Timer(Me.components)
        Me.tmrshowdata = New System.Windows.Forms.Timer(Me.components)
        Me.gbrss.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nrsstable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nrssspeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvrss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbrss
        '
        Me.gbrss.BackColor = System.Drawing.Color.RosyBrown
        Me.gbrss.Controls.Add(Me.GroupBox1)
        Me.gbrss.Controls.Add(Me.GroupBox2)
        Me.gbrss.Controls.Add(Me.Label1)
        Me.gbrss.Controls.Add(Me.txtRSSTemplate)
        Me.gbrss.Controls.Add(Me.cmdrssmanuallyadd)
        Me.gbrss.Controls.Add(Me.nrsstable)
        Me.gbrss.Controls.Add(Me.Label167)
        Me.gbrss.Controls.Add(Me.cmdselectallrssfeed)
        Me.gbrss.Controls.Add(Me.cmddeselectallrssfedd)
        Me.gbrss.Controls.Add(Me.chkrssdescription)
        Me.gbrss.Controls.Add(Me.chkrsstitle)
        Me.gbrss.Controls.Add(Me.chkautomaticupdaterss)
        Me.gbrss.Controls.Add(Me.chkautomaticreadrss)
        Me.gbrss.Controls.Add(Me.txtrsstimerinterval)
        Me.gbrss.Controls.Add(Me.lblrsstimerinterval)
        Me.gbrss.Controls.Add(Me.txtrssdelemeter)
        Me.gbrss.Controls.Add(Me.lblrssdelimeter)
        Me.gbrss.Controls.Add(Me.cmdrsspause)
        Me.gbrss.Controls.Add(Me.cmdrssplay)
        Me.gbrss.Controls.Add(Me.cmdrssstop)
        Me.gbrss.Controls.Add(Me.nrssspeed)
        Me.gbrss.Controls.Add(Me.lblrssspeed)
        Me.gbrss.Controls.Add(Me.cmbrssvideoflashlayer)
        Me.gbrss.Controls.Add(Me.lblrssvideoflashlayer)
        Me.gbrss.Controls.Add(Me.dgvrss)
        Me.gbrss.Controls.Add(Me.cmdrssread)
        Me.gbrss.Controls.Add(Me.lblrssaddress)
        Me.gbrss.Controls.Add(Me.txtrssaddress)
        Me.gbrss.Location = New System.Drawing.Point(3, 3)
        Me.gbrss.Name = "gbrss"
        Me.gbrss.Size = New System.Drawing.Size(660, 605)
        Me.gbrss.TabIndex = 619
        Me.gbrss.TabStop = False
        Me.gbrss.Text = " "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightCoral
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtbnTemplate)
        Me.GroupBox1.Controls.Add(Me.txtbreakingnewsupdateinterval)
        Me.GroupBox1.Controls.Add(Me.Label113)
        Me.GroupBox1.Controls.Add(Me.cmdplaybreakingnews)
        Me.GroupBox1.Controls.Add(Me.cmdstopbrekingnews)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 524)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 75)
        Me.GroupBox1.TabIndex = 729
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Show as Breaking news"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 727
        Me.Label2.Text = "Template"
        '
        'txtbnTemplate
        '
        Me.txtbnTemplate.Location = New System.Drawing.Point(53, 42)
        Me.txtbnTemplate.Name = "txtbnTemplate"
        Me.txtbnTemplate.Size = New System.Drawing.Size(293, 20)
        Me.txtbnTemplate.TabIndex = 726
        Me.txtbnTemplate.Text = "CMP/BreakingNews/BreakingNews"
        '
        'txtbreakingnewsupdateinterval
        '
        Me.txtbreakingnewsupdateinterval.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtbreakingnewsupdateinterval", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtbreakingnewsupdateinterval.Location = New System.Drawing.Point(114, 19)
        Me.txtbreakingnewsupdateinterval.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtbreakingnewsupdateinterval.Name = "txtbreakingnewsupdateinterval"
        Me.txtbreakingnewsupdateinterval.Size = New System.Drawing.Size(32, 20)
        Me.txtbreakingnewsupdateinterval.TabIndex = 725
        Me.txtbreakingnewsupdateinterval.Text = "4000"
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Location = New System.Drawing.Point(7, 23)
        Me.Label113.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(99, 13)
        Me.Label113.TabIndex = 724
        Me.Label113.Text = "Update Interval(ms)"
        '
        'cmdplaybreakingnews
        '
        Me.cmdplaybreakingnews.BackColor = System.Drawing.Color.Green
        Me.cmdplaybreakingnews.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplaybreakingnews.ForeColor = System.Drawing.Color.White
        Me.cmdplaybreakingnews.Location = New System.Drawing.Point(233, 10)
        Me.cmdplaybreakingnews.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdplaybreakingnews.Name = "cmdplaybreakingnews"
        Me.cmdplaybreakingnews.Size = New System.Drawing.Size(51, 30)
        Me.cmdplaybreakingnews.TabIndex = 722
        Me.cmdplaybreakingnews.Text = "Play"
        Me.cmdplaybreakingnews.UseVisualStyleBackColor = False
        '
        'cmdstopbrekingnews
        '
        Me.cmdstopbrekingnews.BackColor = System.Drawing.Color.Red
        Me.cmdstopbrekingnews.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopbrekingnews.ForeColor = System.Drawing.Color.White
        Me.cmdstopbrekingnews.Location = New System.Drawing.Point(292, 9)
        Me.cmdstopbrekingnews.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdstopbrekingnews.Name = "cmdstopbrekingnews"
        Me.cmdstopbrekingnews.Size = New System.Drawing.Size(54, 30)
        Me.cmdstopbrekingnews.TabIndex = 723
        Me.cmdstopbrekingnews.Text = "Stop"
        Me.cmdstopbrekingnews.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Coral
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtclockTemplate)
        Me.GroupBox2.Controls.Add(Me.Label50)
        Me.GroupBox2.Controls.Add(Me.cmblayertimerss)
        Me.GroupBox2.Controls.Add(Me.cmdhidetime)
        Me.GroupBox2.Controls.Add(Me.cmdshowtime)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(364, 524)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 75)
        Me.GroupBox2.TabIndex = 728
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Time Day Date Month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 720
        Me.Label3.Text = "Template"
        '
        'txtclockTemplate
        '
        Me.txtclockTemplate.Location = New System.Drawing.Point(77, 16)
        Me.txtclockTemplate.Name = "txtclockTemplate"
        Me.txtclockTemplate.Size = New System.Drawing.Size(200, 21)
        Me.txtclockTemplate.TabIndex = 719
        Me.txtclockTemplate.Text = "CMP/time2/time"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(4, 46)
        Me.Label50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(124, 15)
        Me.Label50.TabIndex = 505
        Me.Label50.Text = "video layer-flash layer"
        '
        'cmblayertimerss
        '
        Me.cmblayertimerss.FormattingEnabled = True
        Me.cmblayertimerss.Items.AddRange(New Object() {"56", "57", "58", "59", "60"})
        Me.cmblayertimerss.Location = New System.Drawing.Point(128, 43)
        Me.cmblayertimerss.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmblayertimerss.Name = "cmblayertimerss"
        Me.cmblayertimerss.Size = New System.Drawing.Size(40, 23)
        Me.cmblayertimerss.TabIndex = 504
        Me.cmblayertimerss.Text = "78"
        '
        'cmdhidetime
        '
        Me.cmdhidetime.BackColor = System.Drawing.Color.Red
        Me.cmdhidetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdhidetime.ForeColor = System.Drawing.Color.White
        Me.cmdhidetime.Location = New System.Drawing.Point(233, 40)
        Me.cmdhidetime.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdhidetime.Name = "cmdhidetime"
        Me.cmdhidetime.Size = New System.Drawing.Size(47, 31)
        Me.cmdhidetime.TabIndex = 503
        Me.cmdhidetime.Text = "Stop"
        Me.cmdhidetime.UseVisualStyleBackColor = False
        '
        'cmdshowtime
        '
        Me.cmdshowtime.BackColor = System.Drawing.Color.Green
        Me.cmdshowtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdshowtime.ForeColor = System.Drawing.Color.White
        Me.cmdshowtime.Location = New System.Drawing.Point(172, 40)
        Me.cmdshowtime.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdshowtime.Name = "cmdshowtime"
        Me.cmdshowtime.Size = New System.Drawing.Size(59, 29)
        Me.cmdshowtime.TabIndex = 502
        Me.cmdshowtime.Text = "Play"
        Me.cmdshowtime.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 721
        Me.Label1.Text = "Template"
        '
        'txtRSSTemplate
        '
        Me.txtRSSTemplate.Location = New System.Drawing.Point(61, 22)
        Me.txtRSSTemplate.Name = "txtRSSTemplate"
        Me.txtRSSTemplate.Size = New System.Drawing.Size(375, 20)
        Me.txtRSSTemplate.TabIndex = 720
        Me.txtRSSTemplate.Text = "CMP/rss/scroll"
        '
        'cmdrssmanuallyadd
        '
        Me.cmdrssmanuallyadd.Location = New System.Drawing.Point(126, 162)
        Me.cmdrssmanuallyadd.Name = "cmdrssmanuallyadd"
        Me.cmdrssmanuallyadd.Size = New System.Drawing.Size(92, 23)
        Me.cmdrssmanuallyadd.TabIndex = 719
        Me.cmdrssmanuallyadd.Text = "Manually Add"
        Me.cmdrssmanuallyadd.UseVisualStyleBackColor = True
        '
        'nrsstable
        '
        Me.nrsstable.Location = New System.Drawing.Point(488, 67)
        Me.nrsstable.Name = "nrsstable"
        Me.nrsstable.Size = New System.Drawing.Size(46, 20)
        Me.nrsstable.TabIndex = 639
        Me.nrsstable.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label167
        '
        Me.Label167.AutoSize = True
        Me.Label167.Location = New System.Drawing.Point(451, 70)
        Me.Label167.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label167.Name = "Label167"
        Me.Label167.Size = New System.Drawing.Size(34, 13)
        Me.Label167.TabIndex = 638
        Me.Label167.Text = "Table"
        '
        'cmdselectallrssfeed
        '
        Me.cmdselectallrssfeed.Location = New System.Drawing.Point(493, 166)
        Me.cmdselectallrssfeed.Name = "cmdselectallrssfeed"
        Me.cmdselectallrssfeed.Size = New System.Drawing.Size(75, 23)
        Me.cmdselectallrssfeed.TabIndex = 637
        Me.cmdselectallrssfeed.Text = "Select All"
        Me.cmdselectallrssfeed.UseVisualStyleBackColor = True
        '
        'cmddeselectallrssfedd
        '
        Me.cmddeselectallrssfedd.Location = New System.Drawing.Point(572, 165)
        Me.cmddeselectallrssfedd.Name = "cmddeselectallrssfedd"
        Me.cmddeselectallrssfedd.Size = New System.Drawing.Size(75, 23)
        Me.cmddeselectallrssfedd.TabIndex = 636
        Me.cmddeselectallrssfedd.Text = "Deselect All"
        Me.cmddeselectallrssfedd.UseVisualStyleBackColor = True
        '
        'chkrssdescription
        '
        Me.chkrssdescription.AutoSize = True
        Me.chkrssdescription.Checked = Global.caspar_media_playback.My.MySettings.Default.chkrssdescription
        Me.chkrssdescription.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.caspar_media_playback.My.MySettings.Default, "chkrssdescription", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkrssdescription.Location = New System.Drawing.Point(258, 170)
        Me.chkrssdescription.Name = "chkrssdescription"
        Me.chkrssdescription.Size = New System.Drawing.Size(79, 17)
        Me.chkrssdescription.TabIndex = 635
        Me.chkrssdescription.Text = "Description"
        Me.chkrssdescription.UseVisualStyleBackColor = True
        '
        'chkrsstitle
        '
        Me.chkrsstitle.AutoSize = True
        Me.chkrsstitle.Checked = Global.caspar_media_playback.My.MySettings.Default.chkrsstitle
        Me.chkrsstitle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkrsstitle.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.caspar_media_playback.My.MySettings.Default, "chkrsstitle", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkrsstitle.Location = New System.Drawing.Point(61, 170)
        Me.chkrsstitle.Name = "chkrsstitle"
        Me.chkrsstitle.Size = New System.Drawing.Size(46, 17)
        Me.chkrsstitle.TabIndex = 634
        Me.chkrsstitle.Text = "Title"
        Me.chkrsstitle.UseVisualStyleBackColor = True
        '
        'chkautomaticupdaterss
        '
        Me.chkautomaticupdaterss.AutoSize = True
        Me.chkautomaticupdaterss.Checked = Global.caspar_media_playback.My.MySettings.Default.chkautomaticupdaterss
        Me.chkautomaticupdaterss.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.caspar_media_playback.My.MySettings.Default, "chkautomaticupdaterss", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkautomaticupdaterss.Location = New System.Drawing.Point(542, 142)
        Me.chkautomaticupdaterss.Name = "chkautomaticupdaterss"
        Me.chkautomaticupdaterss.Size = New System.Drawing.Size(111, 17)
        Me.chkautomaticupdaterss.TabIndex = 633
        Me.chkautomaticupdaterss.Text = "Automatic Update"
        Me.chkautomaticupdaterss.UseVisualStyleBackColor = True
        '
        'chkautomaticreadrss
        '
        Me.chkautomaticreadrss.AutoSize = True
        Me.chkautomaticreadrss.Checked = Global.caspar_media_playback.My.MySettings.Default.chkautomaticreadrss
        Me.chkautomaticreadrss.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.caspar_media_playback.My.MySettings.Default, "chkautomaticreadrss", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkautomaticreadrss.Location = New System.Drawing.Point(542, 119)
        Me.chkautomaticreadrss.Name = "chkautomaticreadrss"
        Me.chkautomaticreadrss.Size = New System.Drawing.Size(102, 17)
        Me.chkautomaticreadrss.TabIndex = 632
        Me.chkautomaticreadrss.Text = "Automatic Read"
        Me.chkautomaticreadrss.UseVisualStyleBackColor = True
        '
        'txtrsstimerinterval
        '
        Me.txtrsstimerinterval.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtrsstimerinterval", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtrsstimerinterval.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrsstimerinterval.Location = New System.Drawing.Point(161, 126)
        Me.txtrsstimerinterval.Name = "txtrsstimerinterval"
        Me.txtrsstimerinterval.Size = New System.Drawing.Size(69, 22)
        Me.txtrsstimerinterval.TabIndex = 631
        Me.txtrsstimerinterval.Text = "10000"
        Me.txtrsstimerinterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblrsstimerinterval
        '
        Me.lblrsstimerinterval.AutoSize = True
        Me.lblrsstimerinterval.Location = New System.Drawing.Point(5, 130)
        Me.lblrsstimerinterval.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblrsstimerinterval.Name = "lblrsstimerinterval"
        Me.lblrsstimerinterval.Size = New System.Drawing.Size(152, 13)
        Me.lblrsstimerinterval.TabIndex = 630
        Me.lblrsstimerinterval.Text = "Read and Update Interval (ms)"
        '
        'txtrssdelemeter
        '
        Me.txtrssdelemeter.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "rss_delimeter", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtrssdelemeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrssdelemeter.Location = New System.Drawing.Point(162, 102)
        Me.txtrssdelemeter.Name = "txtrssdelemeter"
        Me.txtrssdelemeter.Size = New System.Drawing.Size(69, 22)
        Me.txtrssdelemeter.TabIndex = 627
        Me.txtrssdelemeter.Text = Global.caspar_media_playback.My.MySettings.Default.rss_delimeter
        Me.txtrssdelemeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblrssdelimeter
        '
        Me.lblrssdelimeter.AutoSize = True
        Me.lblrssdelimeter.Location = New System.Drawing.Point(33, 106)
        Me.lblrssdelimeter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblrssdelimeter.Name = "lblrssdelimeter"
        Me.lblrssdelimeter.Size = New System.Drawing.Size(122, 13)
        Me.lblrssdelimeter.TabIndex = 626
        Me.lblrssdelimeter.Text = "Delimeter between items"
        '
        'cmdrsspause
        '
        Me.cmdrsspause.BackColor = System.Drawing.Color.Yellow
        Me.cmdrsspause.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdrsspause.Location = New System.Drawing.Point(295, 133)
        Me.cmdrsspause.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdrsspause.Name = "cmdrsspause"
        Me.cmdrsspause.Size = New System.Drawing.Size(123, 30)
        Me.cmdrsspause.TabIndex = 624
        Me.cmdrsspause.Text = "Pause/Resume"
        Me.cmdrsspause.UseVisualStyleBackColor = False
        '
        'cmdrssplay
        '
        Me.cmdrssplay.BackColor = System.Drawing.Color.Green
        Me.cmdrssplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdrssplay.ForeColor = System.Drawing.Color.White
        Me.cmdrssplay.Location = New System.Drawing.Point(239, 134)
        Me.cmdrssplay.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdrssplay.Name = "cmdrssplay"
        Me.cmdrssplay.Size = New System.Drawing.Size(52, 30)
        Me.cmdrssplay.TabIndex = 622
        Me.cmdrssplay.Text = "Play"
        Me.cmdrssplay.UseVisualStyleBackColor = False
        '
        'cmdrssstop
        '
        Me.cmdrssstop.BackColor = System.Drawing.Color.Red
        Me.cmdrssstop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdrssstop.ForeColor = System.Drawing.Color.White
        Me.cmdrssstop.Location = New System.Drawing.Point(426, 134)
        Me.cmdrssstop.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdrssstop.Name = "cmdrssstop"
        Me.cmdrssstop.Size = New System.Drawing.Size(55, 30)
        Me.cmdrssstop.TabIndex = 623
        Me.cmdrssstop.Text = "Stop"
        Me.cmdrssstop.UseVisualStyleBackColor = False
        '
        'nrssspeed
        '
        Me.nrssspeed.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.caspar_media_playback.My.MySettings.Default, "nrssspeed", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nrssspeed.DecimalPlaces = 1
        Me.nrssspeed.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.nrssspeed.Location = New System.Drawing.Point(282, 105)
        Me.nrssspeed.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nrssspeed.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nrssspeed.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.nrssspeed.Name = "nrssspeed"
        Me.nrssspeed.Size = New System.Drawing.Size(40, 20)
        Me.nrssspeed.TabIndex = 621
        Me.nrssspeed.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lblrssspeed
        '
        Me.lblrssspeed.AutoSize = True
        Me.lblrssspeed.Location = New System.Drawing.Point(244, 104)
        Me.lblrssspeed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblrssspeed.Name = "lblrssspeed"
        Me.lblrssspeed.Size = New System.Drawing.Size(36, 13)
        Me.lblrssspeed.TabIndex = 620
        Me.lblrssspeed.Text = "speed"
        '
        'cmbrssvideoflashlayer
        '
        Me.cmbrssvideoflashlayer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbrssvideoflashlayer", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbrssvideoflashlayer.FormattingEnabled = True
        Me.cmbrssvideoflashlayer.Items.AddRange(New Object() {"76", "77", "78", "79", "80"})
        Me.cmbrssvideoflashlayer.Location = New System.Drawing.Point(572, 19)
        Me.cmbrssvideoflashlayer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbrssvideoflashlayer.Name = "cmbrssvideoflashlayer"
        Me.cmbrssvideoflashlayer.Size = New System.Drawing.Size(40, 21)
        Me.cmbrssvideoflashlayer.TabIndex = 619
        Me.cmbrssvideoflashlayer.Text = "76"
        '
        'lblrssvideoflashlayer
        '
        Me.lblrssvideoflashlayer.AutoSize = True
        Me.lblrssvideoflashlayer.Location = New System.Drawing.Point(456, 22)
        Me.lblrssvideoflashlayer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblrssvideoflashlayer.Name = "lblrssvideoflashlayer"
        Me.lblrssvideoflashlayer.Size = New System.Drawing.Size(108, 13)
        Me.lblrssvideoflashlayer.TabIndex = 618
        Me.lblrssvideoflashlayer.Text = "video layer-flash layer"
        '
        'dgvrss
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvrss.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvrss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvrss.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvrss.Location = New System.Drawing.Point(13, 195)
        Me.dgvrss.Name = "dgvrss"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvrss.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvrss.Size = New System.Drawing.Size(636, 314)
        Me.dgvrss.TabIndex = 617
        '
        'cmdrssread
        '
        Me.cmdrssread.Location = New System.Drawing.Point(546, 66)
        Me.cmdrssread.Name = "cmdrssread"
        Me.cmdrssread.Size = New System.Drawing.Size(75, 23)
        Me.cmdrssread.TabIndex = 616
        Me.cmdrssread.Text = "Read"
        Me.cmdrssread.UseVisualStyleBackColor = True
        '
        'lblrssaddress
        '
        Me.lblrssaddress.AutoSize = True
        Me.lblrssaddress.Location = New System.Drawing.Point(24, 66)
        Me.lblrssaddress.Name = "lblrssaddress"
        Me.lblrssaddress.Size = New System.Drawing.Size(29, 13)
        Me.lblrssaddress.TabIndex = 615
        Me.lblrssaddress.Text = "URL"
        '
        'txtrssaddress
        '
        Me.txtrssaddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "rss", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtrssaddress.Location = New System.Drawing.Point(59, 63)
        Me.txtrssaddress.Name = "txtrssaddress"
        Me.txtrssaddress.Size = New System.Drawing.Size(377, 20)
        Me.txtrssaddress.TabIndex = 614
        Me.txtrssaddress.Text = Global.caspar_media_playback.My.MySettings.Default.rss
        '
        'tmrshowdatarss
        '
        Me.tmrshowdatarss.Interval = 4000
        '
        'tmrshowdata
        '
        Me.tmrshowdata.Interval = 4000
        '
        'ucRssFeed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1221, 749)
        Me.Controls.Add(Me.gbrss)
        Me.HideOnClose = True
        Me.Name = "ucRssFeed"
        Me.Text = "RSS Feed"
        Me.gbrss.ResumeLayout(False)
        Me.gbrss.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nrsstable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nrssspeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvrss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbrss As System.Windows.Forms.GroupBox
    Friend WithEvents cmdrssmanuallyadd As System.Windows.Forms.Button
    Friend WithEvents nrsstable As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label167 As System.Windows.Forms.Label
    Friend WithEvents cmdselectallrssfeed As System.Windows.Forms.Button
    Friend WithEvents cmddeselectallrssfedd As System.Windows.Forms.Button
    Friend WithEvents chkrssdescription As System.Windows.Forms.CheckBox
    Friend WithEvents chkrsstitle As System.Windows.Forms.CheckBox
    Friend WithEvents chkautomaticupdaterss As System.Windows.Forms.CheckBox
    Friend WithEvents chkautomaticreadrss As System.Windows.Forms.CheckBox
    Friend WithEvents txtrsstimerinterval As System.Windows.Forms.TextBox
    Friend WithEvents lblrsstimerinterval As System.Windows.Forms.Label
    Friend WithEvents txtrssdelemeter As System.Windows.Forms.TextBox
    Friend WithEvents lblrssdelimeter As System.Windows.Forms.Label
    Friend WithEvents cmdrsspause As System.Windows.Forms.Button
    Friend WithEvents cmdrssplay As System.Windows.Forms.Button
    Friend WithEvents cmdrssstop As System.Windows.Forms.Button
    Friend WithEvents nrssspeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblrssspeed As System.Windows.Forms.Label
    Friend WithEvents cmbrssvideoflashlayer As System.Windows.Forms.ComboBox
    Friend WithEvents lblrssvideoflashlayer As System.Windows.Forms.Label
    Friend WithEvents dgvrss As System.Windows.Forms.DataGridView
    Friend WithEvents cmdrssread As System.Windows.Forms.Button
    Friend WithEvents lblrssaddress As System.Windows.Forms.Label
    Friend WithEvents txtrssaddress As System.Windows.Forms.TextBox
    Friend WithEvents tmrshowdatarss As System.Windows.Forms.Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRSSTemplate As TextBox
    Friend WithEvents cmdplaybreakingnews As Button
    Friend WithEvents cmdstopbrekingnews As Button
    Friend WithEvents txtbreakingnewsupdateinterval As TextBox
    Friend WithEvents Label113 As Label
    Friend WithEvents tmrshowdata As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbnTemplate As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label50 As Label
    Friend WithEvents cmblayertimerss As ComboBox
    Friend WithEvents cmdhidetime As Button
    Friend WithEvents cmdshowtime As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtclockTemplate As TextBox
End Class
