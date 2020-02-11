<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucnewOffAirLogger
    Inherits System.Windows.Forms.UserControl

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucnewOffAirLogger))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gboffairlogger = New System.Windows.Forms.GroupBox()
        Me.cmdShowInfo = New System.Windows.Forms.Button()
        Me.cmdPlayinvlc = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblsheduleStatus = New System.Windows.Forms.Label()
        Me.lblChannel = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New VerticalProgressBar.VerticalProgressBar()
        Me.ProgressBar1 = New VerticalProgressBar.VerticalProgressBar()
        Me.pnlrecording = New System.Windows.Forms.Panel()
        Me.cmbcasparcgwindowtitlerecording = New System.Windows.Forms.ComboBox()
        Me.cmdoutcasparcgwindowrecording = New System.Windows.Forms.Button()
        Me.cmdshowcasparcgwindowrecording = New System.Windows.Forms.Button()
        Me.lblEstimateddaysvalueoal = New System.Windows.Forms.Label()
        Me.lblEstimateddaysoal = New System.Windows.Forms.Label()
        Me.lblspacerequiredoal = New System.Windows.Forms.Label()
        Me.lbltotalsizeoal = New System.Windows.Forms.Label()
        Me.lbltotalsizecaptionoal = New System.Windows.Forms.Label()
        Me.Label153 = New System.Windows.Forms.Label()
        Me.lblfreespaceoal = New System.Windows.Forms.Label()
        Me.Label134 = New System.Windows.Forms.Label()
        Me.cmdlocaterecordingfileoal = New System.Windows.Forms.Button()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.Label132 = New System.Windows.Forms.Label()
        Me.Label133 = New System.Windows.Forms.Label()
        Me.lblRecordedSizeoal = New System.Windows.Forms.Label()
        Me.lblRecordeddurationoal = New System.Windows.Forms.Label()
        Me.lblrecordingfilenameoal = New System.Windows.Forms.Label()
        Me.txtextraoptionoal = New System.Windows.Forms.TextBox()
        Me.lblextraoptionoal = New System.Windows.Forms.Label()
        Me.lblshedulerecordingplaylist = New System.Windows.Forms.Label()
        Me.deleteshedulerecording = New System.Windows.Forms.Button()
        Me.addshedulerecording = New System.Windows.Forms.Button()
        Me.cmdshedulerecordingstop = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmdshedulerecording = New System.Windows.Forms.Button()
        Me.lbltestshedulerecording = New System.Windows.Forms.Label()
        Me.dgvshedulerecording = New System.Windows.Forms.DataGridView()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpdeleteoal = New System.Windows.Forms.DateTimePicker()
        Me.cmbliveoal = New System.Windows.Forms.ComboBox()
        Me.chkshowtimeofl = New System.Windows.Forms.CheckBox()
        Me.cmdmediadirectoryofl = New System.Windows.Forms.Button()
        Me.txtmediadirectoryoal = New System.Windows.Forms.TextBox()
        Me.cmdremoveinputoal = New System.Windows.Forms.Button()
        Me.cmdshowinputoal = New System.Windows.Forms.Button()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.txtdatetodeleteoal = New System.Windows.Forms.TextBox()
        Me.cmddeletefilesoal = New System.Windows.Forms.Button()
        Me.cmbfileformateoal = New System.Windows.Forms.ComboBox()
        Me.dtpoal = New System.Windows.Forms.DateTimePicker()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.txtbitrateofl = New System.Windows.Forms.TextBox()
        Me.cmdrecordoal = New System.Windows.Forms.Button()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.cmdstoprecordoal = New System.Windows.Forms.Button()
        Me.txtfilelengthofl = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.tmrrecordedfileinfooal = New System.Windows.Forms.Timer(Me.components)
        Me.tmroal = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gboffairlogger.SuspendLayout()
        CType(Me.dgvshedulerecording, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboffairlogger
        '
        Me.gboffairlogger.BackColor = System.Drawing.Color.Pink
        Me.gboffairlogger.Controls.Add(Me.MenuStrip1)
        Me.gboffairlogger.Controls.Add(Me.cmdShowInfo)
        Me.gboffairlogger.Controls.Add(Me.cmdPlayinvlc)
        Me.gboffairlogger.Controls.Add(Me.Button1)
        Me.gboffairlogger.Controls.Add(Me.Label1)
        Me.gboffairlogger.Controls.Add(Me.lblsheduleStatus)
        Me.gboffairlogger.Controls.Add(Me.lblChannel)
        Me.gboffairlogger.Controls.Add(Me.ProgressBar2)
        Me.gboffairlogger.Controls.Add(Me.ProgressBar1)
        Me.gboffairlogger.Controls.Add(Me.pnlrecording)
        Me.gboffairlogger.Controls.Add(Me.cmbcasparcgwindowtitlerecording)
        Me.gboffairlogger.Controls.Add(Me.cmdoutcasparcgwindowrecording)
        Me.gboffairlogger.Controls.Add(Me.cmdshowcasparcgwindowrecording)
        Me.gboffairlogger.Controls.Add(Me.lblEstimateddaysvalueoal)
        Me.gboffairlogger.Controls.Add(Me.lblEstimateddaysoal)
        Me.gboffairlogger.Controls.Add(Me.lblspacerequiredoal)
        Me.gboffairlogger.Controls.Add(Me.lbltotalsizeoal)
        Me.gboffairlogger.Controls.Add(Me.lbltotalsizecaptionoal)
        Me.gboffairlogger.Controls.Add(Me.Label153)
        Me.gboffairlogger.Controls.Add(Me.lblfreespaceoal)
        Me.gboffairlogger.Controls.Add(Me.Label134)
        Me.gboffairlogger.Controls.Add(Me.cmdlocaterecordingfileoal)
        Me.gboffairlogger.Controls.Add(Me.Label131)
        Me.gboffairlogger.Controls.Add(Me.Label132)
        Me.gboffairlogger.Controls.Add(Me.Label133)
        Me.gboffairlogger.Controls.Add(Me.lblRecordedSizeoal)
        Me.gboffairlogger.Controls.Add(Me.lblRecordeddurationoal)
        Me.gboffairlogger.Controls.Add(Me.lblrecordingfilenameoal)
        Me.gboffairlogger.Controls.Add(Me.txtextraoptionoal)
        Me.gboffairlogger.Controls.Add(Me.lblextraoptionoal)
        Me.gboffairlogger.Controls.Add(Me.lblshedulerecordingplaylist)
        Me.gboffairlogger.Controls.Add(Me.deleteshedulerecording)
        Me.gboffairlogger.Controls.Add(Me.addshedulerecording)
        Me.gboffairlogger.Controls.Add(Me.cmdshedulerecordingstop)
        Me.gboffairlogger.Controls.Add(Me.Button4)
        Me.gboffairlogger.Controls.Add(Me.cmdshedulerecording)
        Me.gboffairlogger.Controls.Add(Me.lbltestshedulerecording)
        Me.gboffairlogger.Controls.Add(Me.dgvshedulerecording)
        Me.gboffairlogger.Controls.Add(Me.Label127)
        Me.gboffairlogger.Controls.Add(Me.Panel2)
        Me.gboffairlogger.Controls.Add(Me.dtpdeleteoal)
        Me.gboffairlogger.Controls.Add(Me.cmbliveoal)
        Me.gboffairlogger.Controls.Add(Me.chkshowtimeofl)
        Me.gboffairlogger.Controls.Add(Me.cmdmediadirectoryofl)
        Me.gboffairlogger.Controls.Add(Me.txtmediadirectoryoal)
        Me.gboffairlogger.Controls.Add(Me.cmdremoveinputoal)
        Me.gboffairlogger.Controls.Add(Me.cmdshowinputoal)
        Me.gboffairlogger.Controls.Add(Me.Label73)
        Me.gboffairlogger.Controls.Add(Me.txtdatetodeleteoal)
        Me.gboffairlogger.Controls.Add(Me.cmddeletefilesoal)
        Me.gboffairlogger.Controls.Add(Me.cmbfileformateoal)
        Me.gboffairlogger.Controls.Add(Me.dtpoal)
        Me.gboffairlogger.Controls.Add(Me.Label51)
        Me.gboffairlogger.Controls.Add(Me.Label66)
        Me.gboffairlogger.Controls.Add(Me.txtbitrateofl)
        Me.gboffairlogger.Controls.Add(Me.cmdrecordoal)
        Me.gboffairlogger.Controls.Add(Me.Label71)
        Me.gboffairlogger.Controls.Add(Me.cmdstoprecordoal)
        Me.gboffairlogger.Controls.Add(Me.txtfilelengthofl)
        Me.gboffairlogger.Controls.Add(Me.Label72)
        Me.gboffairlogger.ForeColor = System.Drawing.Color.Black
        Me.gboffairlogger.Location = New System.Drawing.Point(2, 3)
        Me.gboffairlogger.Name = "gboffairlogger"
        Me.gboffairlogger.Size = New System.Drawing.Size(600, 423)
        Me.gboffairlogger.TabIndex = 586
        Me.gboffairlogger.TabStop = False
        Me.gboffairlogger.Text = "Off Air Logger"
        '
        'cmdShowInfo
        '
        Me.cmdShowInfo.Location = New System.Drawing.Point(122, 51)
        Me.cmdShowInfo.Name = "cmdShowInfo"
        Me.cmdShowInfo.Size = New System.Drawing.Size(82, 20)
        Me.cmdShowInfo.TabIndex = 748
        Me.cmdShowInfo.Text = "Show File Info"
        Me.cmdShowInfo.UseVisualStyleBackColor = True
        '
        'cmdPlayinvlc
        '
        Me.cmdPlayinvlc.Location = New System.Drawing.Point(50, 51)
        Me.cmdPlayinvlc.Name = "cmdPlayinvlc"
        Me.cmdPlayinvlc.Size = New System.Drawing.Size(70, 20)
        Me.cmdPlayinvlc.TabIndex = 747
        Me.cmdPlayinvlc.Text = "Play in VLC"
        Me.cmdPlayinvlc.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(431, 265)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(10, 157)
        Me.Button1.TabIndex = 746
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(441, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 20)
        Me.Label1.TabIndex = 745
        Me.Label1.Text = "Instatnt Recording"
        '
        'lblsheduleStatus
        '
        Me.lblsheduleStatus.AutoSize = True
        Me.lblsheduleStatus.BackColor = System.Drawing.Color.Red
        Me.lblsheduleStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsheduleStatus.Location = New System.Drawing.Point(51, 295)
        Me.lblsheduleStatus.Name = "lblsheduleStatus"
        Me.lblsheduleStatus.Size = New System.Drawing.Size(147, 20)
        Me.lblsheduleStatus.TabIndex = 744
        Me.lblsheduleStatus.Text = "Schedule Stoped"
        '
        'lblChannel
        '
        Me.lblChannel.AutoSize = True
        Me.lblChannel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChannel.ForeColor = System.Drawing.Color.DarkRed
        Me.lblChannel.Location = New System.Drawing.Point(397, 219)
        Me.lblChannel.Name = "lblChannel"
        Me.lblChannel.Size = New System.Drawing.Size(105, 24)
        Me.lblChannel.TabIndex = 743
        Me.lblChannel.Text = "Channel 1"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.BorderStyle = VerticalProgressBar.BorderStyles.Classic
        Me.ProgressBar2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressBar2.Location = New System.Drawing.Point(574, 39)
        Me.ProgressBar2.Maximum = 40
        Me.ProgressBar2.Minimum = 0
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(11, 176)
        Me.ProgressBar2.Step = 1
        Me.ProgressBar2.Style = VerticalProgressBar.Styles.Classic
        Me.ProgressBar2.TabIndex = 742
        Me.ProgressBar2.Value = 40
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BorderStyle = VerticalProgressBar.BorderStyles.Classic
        Me.ProgressBar1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(316, 38)
        Me.ProgressBar1.Maximum = 40
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(11, 176)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = VerticalProgressBar.Styles.Classic
        Me.ProgressBar1.TabIndex = 741
        Me.ProgressBar1.Value = 40
        '
        'pnlrecording
        '
        Me.pnlrecording.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlrecording.Location = New System.Drawing.Point(333, 39)
        Me.pnlrecording.Name = "pnlrecording"
        Me.pnlrecording.Size = New System.Drawing.Size(235, 176)
        Me.pnlrecording.TabIndex = 737
        '
        'cmbcasparcgwindowtitlerecording
        '
        Me.cmbcasparcgwindowtitlerecording.FormattingEnabled = True
        Me.cmbcasparcgwindowtitlerecording.Items.AddRange(New Object() {"Screen consumer [1|PAL]", "Screen consumer [2|PAL]", "Screen consumer [3|PAL]", "Screen consumer [4|PAL]", "Screen consumer [1|NTSC]", "Screen consumer [1|1080i5000]", "Screen consumer [2|1080i5000]", "Screen consumer [3|1080i5000]", "Screen consumer [4|1080i5000]", "Screen consumer [1|1080i5994]", "Screen consumer [1|1080i6000]", "Screen consumer [1|1080p2398]", "Screen consumer [1|1080p2400]", "Screen consumer [1|1080p2500]", "Screen consumer [1|1080p2997]", "Screen consumer [1|1080p3000]", "Screen consumer [1|1080p5000]", "Screen consumer [1|1080p5994]", "Screen consumer [1|1080p6000]", "Screen consumer [1|1556p2398]", "Screen consumer [1|1556p2400]", "Screen consumer [1|1556p2500]", "Screen consumer [1|2160p2398]", "Screen consumer [1|2160p2400]", "Screen consumer [1|2160p2500]", "Screen consumer [1| 2160p2997]", "Screen consumer [1|2160p3000]", "Screen consumer [1|576p2500]", "Screen consumer [1|720p2398]", "Screen consumer [1|720p2400]", "Screen consumer [1|720p2500]", "Screen consumer [1|720p2997]", "Screen consumer [1|720p3000]", "Screen consumer [1|720p5000]", "Screen consumer [1|720p5994]", "Screen consumer [1|720p6000]"})
        Me.cmbcasparcgwindowtitlerecording.Location = New System.Drawing.Point(322, 12)
        Me.cmbcasparcgwindowtitlerecording.Name = "cmbcasparcgwindowtitlerecording"
        Me.cmbcasparcgwindowtitlerecording.Size = New System.Drawing.Size(150, 21)
        Me.cmbcasparcgwindowtitlerecording.TabIndex = 740
        Me.cmbcasparcgwindowtitlerecording.Text = "Screen consumer [1|PAL]"
        '
        'cmdoutcasparcgwindowrecording
        '
        Me.cmdoutcasparcgwindowrecording.Location = New System.Drawing.Point(513, 11)
        Me.cmdoutcasparcgwindowrecording.Name = "cmdoutcasparcgwindowrecording"
        Me.cmdoutcasparcgwindowrecording.Size = New System.Drawing.Size(43, 23)
        Me.cmdoutcasparcgwindowrecording.TabIndex = 739
        Me.cmdoutcasparcgwindowrecording.Text = "OUT"
        Me.cmdoutcasparcgwindowrecording.UseVisualStyleBackColor = True
        '
        'cmdshowcasparcgwindowrecording
        '
        Me.cmdshowcasparcgwindowrecording.Location = New System.Drawing.Point(480, 11)
        Me.cmdshowcasparcgwindowrecording.Name = "cmdshowcasparcgwindowrecording"
        Me.cmdshowcasparcgwindowrecording.Size = New System.Drawing.Size(32, 23)
        Me.cmdshowcasparcgwindowrecording.TabIndex = 738
        Me.cmdshowcasparcgwindowrecording.Text = "IN"
        Me.cmdshowcasparcgwindowrecording.UseVisualStyleBackColor = True
        '
        'lblEstimateddaysvalueoal
        '
        Me.lblEstimateddaysvalueoal.AutoSize = True
        Me.lblEstimateddaysvalueoal.Location = New System.Drawing.Point(223, 121)
        Me.lblEstimateddaysvalueoal.Name = "lblEstimateddaysvalueoal"
        Me.lblEstimateddaysvalueoal.Size = New System.Drawing.Size(78, 13)
        Me.lblEstimateddaysvalueoal.TabIndex = 724
        Me.lblEstimateddaysvalueoal.Text = "Estimated days"
        '
        'lblEstimateddaysoal
        '
        Me.lblEstimateddaysoal.AutoSize = True
        Me.lblEstimateddaysoal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstimateddaysoal.Location = New System.Drawing.Point(132, 120)
        Me.lblEstimateddaysoal.Name = "lblEstimateddaysoal"
        Me.lblEstimateddaysoal.Size = New System.Drawing.Size(92, 13)
        Me.lblEstimateddaysoal.TabIndex = 723
        Me.lblEstimateddaysoal.Text = "Estimated days"
        '
        'lblspacerequiredoal
        '
        Me.lblspacerequiredoal.AutoSize = True
        Me.lblspacerequiredoal.Location = New System.Drawing.Point(6, 232)
        Me.lblspacerequiredoal.Name = "lblspacerequiredoal"
        Me.lblspacerequiredoal.Size = New System.Drawing.Size(164, 26)
        Me.lblspacerequiredoal.TabIndex = 722
        Me.lblspacerequiredoal.Text = " 1 TB =90 days @ 1Mbps" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "224 MB =1800 second @ 1Mbps"
        '
        'lbltotalsizeoal
        '
        Me.lbltotalsizeoal.AutoSize = True
        Me.lbltotalsizeoal.Location = New System.Drawing.Point(223, 108)
        Me.lbltotalsizeoal.Name = "lbltotalsizeoal"
        Me.lbltotalsizeoal.Size = New System.Drawing.Size(54, 13)
        Me.lbltotalsizeoal.TabIndex = 721
        Me.lbltotalsizeoal.Text = "Total Size"
        '
        'lbltotalsizecaptionoal
        '
        Me.lbltotalsizecaptionoal.AutoSize = True
        Me.lbltotalsizecaptionoal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalsizecaptionoal.Location = New System.Drawing.Point(160, 108)
        Me.lbltotalsizecaptionoal.Name = "lbltotalsizecaptionoal"
        Me.lbltotalsizecaptionoal.Size = New System.Drawing.Size(64, 13)
        Me.lbltotalsizecaptionoal.TabIndex = 720
        Me.lbltotalsizecaptionoal.Text = "Total Size"
        '
        'Label153
        '
        Me.Label153.AutoSize = True
        Me.Label153.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label153.Location = New System.Drawing.Point(152, 95)
        Me.Label153.Name = "Label153"
        Me.Label153.Size = New System.Drawing.Size(72, 13)
        Me.Label153.TabIndex = 630
        Me.Label153.Text = "Free Space"
        '
        'lblfreespaceoal
        '
        Me.lblfreespaceoal.AutoSize = True
        Me.lblfreespaceoal.Location = New System.Drawing.Point(223, 95)
        Me.lblfreespaceoal.Name = "lblfreespaceoal"
        Me.lblfreespaceoal.Size = New System.Drawing.Size(54, 13)
        Me.lblfreespaceoal.TabIndex = 629
        Me.lblfreespaceoal.Text = "freespace"
        '
        'Label134
        '
        Me.Label134.AutoSize = True
        Me.Label134.Location = New System.Drawing.Point(163, 19)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(49, 13)
        Me.Label134.TabIndex = 628
        Me.Label134.Text = "Decklink"
        '
        'cmdlocaterecordingfileoal
        '
        Me.cmdlocaterecordingfileoal.Location = New System.Drawing.Point(0, 50)
        Me.cmdlocaterecordingfileoal.Name = "cmdlocaterecordingfileoal"
        Me.cmdlocaterecordingfileoal.Size = New System.Drawing.Size(49, 20)
        Me.cmdlocaterecordingfileoal.TabIndex = 627
        Me.cmdlocaterecordingfileoal.Text = "Locate"
        Me.cmdlocaterecordingfileoal.UseVisualStyleBackColor = True
        '
        'Label131
        '
        Me.Label131.AutoSize = True
        Me.Label131.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label131.Location = New System.Drawing.Point(189, 83)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(31, 13)
        Me.Label131.TabIndex = 626
        Me.Label131.Text = "Size"
        '
        'Label132
        '
        Me.Label132.AutoSize = True
        Me.Label132.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label132.Location = New System.Drawing.Point(170, 70)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(55, 13)
        Me.Label132.TabIndex = 625
        Me.Label132.Text = "Duration"
        '
        'Label133
        '
        Me.Label133.AutoSize = True
        Me.Label133.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label133.Location = New System.Drawing.Point(-2, 35)
        Me.Label133.Name = "Label133"
        Me.Label133.Size = New System.Drawing.Size(63, 13)
        Me.Label133.TabIndex = 624
        Me.Label133.Text = "File Name"
        '
        'lblRecordedSizeoal
        '
        Me.lblRecordedSizeoal.AutoSize = True
        Me.lblRecordedSizeoal.Location = New System.Drawing.Point(223, 84)
        Me.lblRecordedSizeoal.Name = "lblRecordedSizeoal"
        Me.lblRecordedSizeoal.Size = New System.Drawing.Size(27, 13)
        Me.lblRecordedSizeoal.TabIndex = 623
        Me.lblRecordedSizeoal.Text = "Size"
        '
        'lblRecordeddurationoal
        '
        Me.lblRecordeddurationoal.AutoSize = True
        Me.lblRecordeddurationoal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordeddurationoal.ForeColor = System.Drawing.Color.Maroon
        Me.lblRecordeddurationoal.Location = New System.Drawing.Point(223, 69)
        Me.lblRecordeddurationoal.Name = "lblRecordeddurationoal"
        Me.lblRecordeddurationoal.Size = New System.Drawing.Size(67, 16)
        Me.lblRecordeddurationoal.TabIndex = 622
        Me.lblRecordeddurationoal.Text = "Duration"
        '
        'lblrecordingfilenameoal
        '
        Me.lblrecordingfilenameoal.Location = New System.Drawing.Point(69, 36)
        Me.lblrecordingfilenameoal.Name = "lblrecordingfilenameoal"
        Me.lblrecordingfilenameoal.Size = New System.Drawing.Size(242, 12)
        Me.lblrecordingfilenameoal.TabIndex = 621
        Me.lblrecordingfilenameoal.Text = "name"
        '
        'txtextraoptionoal
        '
        Me.txtextraoptionoal.Location = New System.Drawing.Point(81, 162)
        Me.txtextraoptionoal.Name = "txtextraoptionoal"
        Me.txtextraoptionoal.Size = New System.Drawing.Size(232, 20)
        Me.txtextraoptionoal.TabIndex = 620
        Me.txtextraoptionoal.Text = Global.caspar_media_playback.My.MySettings.Default.txtextraoptionoal
        Me.txtextraoptionoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblextraoptionoal
        '
        Me.lblextraoptionoal.AutoSize = True
        Me.lblextraoptionoal.Location = New System.Drawing.Point(10, 166)
        Me.lblextraoptionoal.Name = "lblextraoptionoal"
        Me.lblextraoptionoal.Size = New System.Drawing.Size(68, 13)
        Me.lblextraoptionoal.TabIndex = 619
        Me.lblextraoptionoal.Text = "Extra options"
        '
        'lblshedulerecordingplaylist
        '
        Me.lblshedulerecordingplaylist.Location = New System.Drawing.Point(9, 348)
        Me.lblshedulerecordingplaylist.Name = "lblshedulerecordingplaylist"
        Me.lblshedulerecordingplaylist.Size = New System.Drawing.Size(195, 71)
        Me.lblshedulerecordingplaylist.TabIndex = 618
        Me.lblshedulerecordingplaylist.Text = "filename=default"
        '
        'deleteshedulerecording
        '
        Me.deleteshedulerecording.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteshedulerecording.Image = Global.caspar_media_playback.My.Resources.Resources.minus
        Me.deleteshedulerecording.Location = New System.Drawing.Point(311, 266)
        Me.deleteshedulerecording.Name = "deleteshedulerecording"
        Me.deleteshedulerecording.Size = New System.Drawing.Size(33, 22)
        Me.deleteshedulerecording.TabIndex = 616
        Me.deleteshedulerecording.UseVisualStyleBackColor = True
        '
        'addshedulerecording
        '
        Me.addshedulerecording.Image = CType(resources.GetObject("addshedulerecording.Image"), System.Drawing.Image)
        Me.addshedulerecording.Location = New System.Drawing.Point(270, 265)
        Me.addshedulerecording.Name = "addshedulerecording"
        Me.addshedulerecording.Size = New System.Drawing.Size(41, 23)
        Me.addshedulerecording.TabIndex = 615
        Me.addshedulerecording.UseVisualStyleBackColor = True
        '
        'cmdshedulerecordingstop
        '
        Me.cmdshedulerecordingstop.Location = New System.Drawing.Point(2, 318)
        Me.cmdshedulerecordingstop.Name = "cmdshedulerecordingstop"
        Me.cmdshedulerecordingstop.Size = New System.Drawing.Size(47, 23)
        Me.cmdshedulerecordingstop.TabIndex = 614
        Me.cmdshedulerecordingstop.Text = "Stop"
        Me.cmdshedulerecordingstop.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Location = New System.Drawing.Point(6, 258)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(596, 10)
        Me.Button4.TabIndex = 613
        Me.Button4.UseVisualStyleBackColor = False
        '
        'cmdshedulerecording
        '
        Me.cmdshedulerecording.Location = New System.Drawing.Point(4, 295)
        Me.cmdshedulerecording.Name = "cmdshedulerecording"
        Me.cmdshedulerecording.Size = New System.Drawing.Size(43, 23)
        Me.cmdshedulerecording.TabIndex = 171
        Me.cmdshedulerecording.Text = "Start"
        Me.cmdshedulerecording.UseVisualStyleBackColor = True
        '
        'lbltestshedulerecording
        '
        Me.lbltestshedulerecording.AutoSize = True
        Me.lbltestshedulerecording.BackColor = System.Drawing.Color.Red
        Me.lbltestshedulerecording.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltestshedulerecording.Location = New System.Drawing.Point(51, 318)
        Me.lbltestshedulerecording.Name = "lbltestshedulerecording"
        Me.lbltestshedulerecording.Size = New System.Drawing.Size(154, 20)
        Me.lbltestshedulerecording.TabIndex = 170
        Me.lbltestshedulerecording.Text = "Recording Stoped"
        '
        'dgvshedulerecording
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvshedulerecording.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvshedulerecording.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvshedulerecording.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvshedulerecording.Location = New System.Drawing.Point(212, 292)
        Me.dgvshedulerecording.Name = "dgvshedulerecording"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvshedulerecording.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvshedulerecording.Size = New System.Drawing.Size(218, 127)
        Me.dgvshedulerecording.TabIndex = 169
        '
        'Label127
        '
        Me.Label127.AutoSize = True
        Me.Label127.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label127.Location = New System.Drawing.Point(4, 270)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(171, 20)
        Me.Label127.TabIndex = 168
        Me.Label127.Text = "Schedule Recording"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(260, 216)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(66, 36)
        Me.Panel2.TabIndex = 167
        '
        'dtpdeleteoal
        '
        Me.dtpdeleteoal.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdeleteoal.Enabled = False
        Me.dtpdeleteoal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdeleteoal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdeleteoal.Location = New System.Drawing.Point(267, 222)
        Me.dtpdeleteoal.Name = "dtpdeleteoal"
        Me.dtpdeleteoal.ShowUpDown = True
        Me.dtpdeleteoal.Size = New System.Drawing.Size(53, 26)
        Me.dtpdeleteoal.TabIndex = 166
        '
        'cmbliveoal
        '
        Me.cmbliveoal.FormattingEnabled = True
        Me.cmbliveoal.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbliveoal.Location = New System.Drawing.Point(216, 14)
        Me.cmbliveoal.Name = "cmbliveoal"
        Me.cmbliveoal.Size = New System.Drawing.Size(35, 21)
        Me.cmbliveoal.TabIndex = 164
        Me.cmbliveoal.Text = "1"
        '
        'chkshowtimeofl
        '
        Me.chkshowtimeofl.AutoSize = True
        Me.chkshowtimeofl.Checked = Global.caspar_media_playback.My.MySettings.Default.chkshowtimeofl
        Me.chkshowtimeofl.Location = New System.Drawing.Point(3, 70)
        Me.chkshowtimeofl.Name = "chkshowtimeofl"
        Me.chkshowtimeofl.Size = New System.Drawing.Size(79, 17)
        Me.chkshowtimeofl.TabIndex = 163
        Me.chkshowtimeofl.Text = "Show Time"
        Me.chkshowtimeofl.UseVisualStyleBackColor = True
        '
        'cmdmediadirectoryofl
        '
        Me.cmdmediadirectoryofl.Location = New System.Drawing.Point(4, 183)
        Me.cmdmediadirectoryofl.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.cmdmediadirectoryofl.Name = "cmdmediadirectoryofl"
        Me.cmdmediadirectoryofl.Size = New System.Drawing.Size(151, 23)
        Me.cmdmediadirectoryofl.TabIndex = 160
        Me.cmdmediadirectoryofl.Text = "Media Directory for deleting"
        Me.cmdmediadirectoryofl.UseVisualStyleBackColor = True
        '
        'txtmediadirectoryoal
        '
        Me.txtmediadirectoryoal.Location = New System.Drawing.Point(156, 185)
        Me.txtmediadirectoryoal.Name = "txtmediadirectoryoal"
        Me.txtmediadirectoryoal.Size = New System.Drawing.Size(157, 20)
        Me.txtmediadirectoryoal.TabIndex = 159
        Me.txtmediadirectoryoal.Text = Global.caspar_media_playback.My.MySettings.Default.txtmediadirectoryoal
        Me.txtmediadirectoryoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdremoveinputoal
        '
        Me.cmdremoveinputoal.Location = New System.Drawing.Point(74, 12)
        Me.cmdremoveinputoal.Name = "cmdremoveinputoal"
        Me.cmdremoveinputoal.Size = New System.Drawing.Size(88, 23)
        Me.cmdremoveinputoal.TabIndex = 162
        Me.cmdremoveinputoal.Text = "Remove Input"
        Me.cmdremoveinputoal.UseVisualStyleBackColor = True
        '
        'cmdshowinputoal
        '
        Me.cmdshowinputoal.Location = New System.Drawing.Point(3, 12)
        Me.cmdshowinputoal.Name = "cmdshowinputoal"
        Me.cmdshowinputoal.Size = New System.Drawing.Size(70, 21)
        Me.cmdshowinputoal.TabIndex = 161
        Me.cmdshowinputoal.Text = "Show input"
        Me.cmdshowinputoal.UseVisualStyleBackColor = True
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(188, 211)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(31, 13)
        Me.Label73.TabIndex = 156
        Me.Label73.Text = "Days"
        '
        'txtdatetodeleteoal
        '
        Me.txtdatetodeleteoal.Location = New System.Drawing.Point(140, 208)
        Me.txtdatetodeleteoal.Name = "txtdatetodeleteoal"
        Me.txtdatetodeleteoal.Size = New System.Drawing.Size(47, 20)
        Me.txtdatetodeleteoal.TabIndex = 158
        Me.txtdatetodeleteoal.Text = "180"
        Me.txtdatetodeleteoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmddeletefilesoal
        '
        Me.cmddeletefilesoal.Location = New System.Drawing.Point(6, 206)
        Me.cmddeletefilesoal.Name = "cmddeletefilesoal"
        Me.cmddeletefilesoal.Size = New System.Drawing.Size(132, 23)
        Me.cmddeletefilesoal.TabIndex = 157
        Me.cmddeletefilesoal.Text = "Delete files older than"
        Me.cmddeletefilesoal.UseVisualStyleBackColor = True
        '
        'cmbfileformateoal
        '
        Me.cmbfileformateoal.FormattingEnabled = True
        Me.cmbfileformateoal.Items.AddRange(New Object() {"avi", "dv", "mov", "mp4", "mxf", "ogg", "ts"})
        Me.cmbfileformateoal.Location = New System.Drawing.Point(77, 109)
        Me.cmbfileformateoal.Name = "cmbfileformateoal"
        Me.cmbfileformateoal.Size = New System.Drawing.Size(53, 21)
        Me.cmbfileformateoal.Sorted = True
        Me.cmbfileformateoal.TabIndex = 155
        Me.cmbfileformateoal.Text = Global.caspar_media_playback.My.MySettings.Default.cmbrecordformat
        '
        'dtpoal
        '
        Me.dtpoal.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpoal.Enabled = False
        Me.dtpoal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpoal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpoal.Location = New System.Drawing.Point(61, 135)
        Me.dtpoal.Name = "dtpoal"
        Me.dtpoal.ShowUpDown = True
        Me.dtpoal.Size = New System.Drawing.Size(183, 26)
        Me.dtpoal.TabIndex = 138
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(3, 112)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(58, 13)
        Me.Label51.TabIndex = 153
        Me.Label51.Text = "File Format"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(7, 141)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(49, 13)
        Me.Label66.TabIndex = 141
        Me.Label66.Text = "Filename"
        '
        'txtbitrateofl
        '
        Me.txtbitrateofl.Location = New System.Drawing.Point(77, 87)
        Me.txtbitrateofl.Name = "txtbitrateofl"
        Me.txtbitrateofl.Size = New System.Drawing.Size(53, 20)
        Me.txtbitrateofl.TabIndex = 142
        Me.txtbitrateofl.Text = "1"
        Me.txtbitrateofl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdrecordoal
        '
        Me.cmdrecordoal.Location = New System.Drawing.Point(473, 294)
        Me.cmdrecordoal.Name = "cmdrecordoal"
        Me.cmdrecordoal.Size = New System.Drawing.Size(88, 23)
        Me.cmdrecordoal.TabIndex = 139
        Me.cmdrecordoal.Text = "Record"
        Me.cmdrecordoal.UseVisualStyleBackColor = True
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(3, 90)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(74, 13)
        Me.Label71.TabIndex = 142
        Me.Label71.Text = "Bit Rate Mbps"
        '
        'cmdstoprecordoal
        '
        Me.cmdstoprecordoal.Location = New System.Drawing.Point(473, 318)
        Me.cmdstoprecordoal.Name = "cmdstoprecordoal"
        Me.cmdstoprecordoal.Size = New System.Drawing.Size(88, 23)
        Me.cmdstoprecordoal.TabIndex = 140
        Me.cmdstoprecordoal.Text = "Stop Record"
        Me.cmdstoprecordoal.UseVisualStyleBackColor = True
        '
        'txtfilelengthofl
        '
        Me.txtfilelengthofl.Location = New System.Drawing.Point(495, 367)
        Me.txtfilelengthofl.Name = "txtfilelengthofl"
        Me.txtfilelengthofl.Size = New System.Drawing.Size(52, 20)
        Me.txtfilelengthofl.TabIndex = 138
        Me.txtfilelengthofl.Text = "1800"
        Me.txtfilelengthofl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(461, 346)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(110, 13)
        Me.Label72.TabIndex = 138
        Me.Label72.Text = "File Length in Second"
        '
        'tmrrecordedfileinfooal
        '
        Me.tmrrecordedfileinfooal.Interval = 1000
        '
        'tmroal
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(178, 265)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(84, 24)
        Me.MenuStrip1.TabIndex = 744
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
        'ucnewOffAirLogger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.gboffairlogger)
        Me.Name = "ucnewOffAirLogger"
        Me.Size = New System.Drawing.Size(606, 429)
        Me.gboffairlogger.ResumeLayout(False)
        Me.gboffairlogger.PerformLayout()
        CType(Me.dgvshedulerecording, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gboffairlogger As System.Windows.Forms.GroupBox
    Friend WithEvents lblEstimateddaysvalueoal As System.Windows.Forms.Label
    Friend WithEvents lblEstimateddaysoal As System.Windows.Forms.Label
    Friend WithEvents lblspacerequiredoal As System.Windows.Forms.Label
    Friend WithEvents lbltotalsizeoal As System.Windows.Forms.Label
    Friend WithEvents lbltotalsizecaptionoal As System.Windows.Forms.Label
    Friend WithEvents Label153 As System.Windows.Forms.Label
    Friend WithEvents lblfreespaceoal As System.Windows.Forms.Label
    Friend WithEvents Label134 As System.Windows.Forms.Label
    Friend WithEvents cmdlocaterecordingfileoal As System.Windows.Forms.Button
    Friend WithEvents Label131 As System.Windows.Forms.Label
    Friend WithEvents Label132 As System.Windows.Forms.Label
    Friend WithEvents Label133 As System.Windows.Forms.Label
    Friend WithEvents lblRecordedSizeoal As System.Windows.Forms.Label
    Friend WithEvents lblRecordeddurationoal As System.Windows.Forms.Label
    Friend WithEvents lblrecordingfilenameoal As System.Windows.Forms.Label
    Friend WithEvents txtextraoptionoal As System.Windows.Forms.TextBox
    Friend WithEvents lblextraoptionoal As System.Windows.Forms.Label
    Friend WithEvents lblshedulerecordingplaylist As System.Windows.Forms.Label
    Friend WithEvents deleteshedulerecording As System.Windows.Forms.Button
    Friend WithEvents addshedulerecording As System.Windows.Forms.Button
    Friend WithEvents cmdshedulerecordingstop As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cmdshedulerecording As System.Windows.Forms.Button
    Friend WithEvents lbltestshedulerecording As System.Windows.Forms.Label
    Friend WithEvents dgvshedulerecording As System.Windows.Forms.DataGridView
    Friend WithEvents Label127 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtpdeleteoal As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbliveoal As System.Windows.Forms.ComboBox
    Friend WithEvents chkshowtimeofl As System.Windows.Forms.CheckBox
    Friend WithEvents cmdmediadirectoryofl As System.Windows.Forms.Button
    Friend WithEvents txtmediadirectoryoal As System.Windows.Forms.TextBox
    Friend WithEvents cmdremoveinputoal As System.Windows.Forms.Button
    Friend WithEvents cmdshowinputoal As System.Windows.Forms.Button
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents txtdatetodeleteoal As System.Windows.Forms.TextBox
    Friend WithEvents cmddeletefilesoal As System.Windows.Forms.Button
    Friend WithEvents cmbfileformateoal As System.Windows.Forms.ComboBox
    Friend WithEvents dtpoal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents txtbitrateofl As System.Windows.Forms.TextBox
    Friend WithEvents cmdrecordoal As System.Windows.Forms.Button
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents cmdstoprecordoal As System.Windows.Forms.Button
    Friend WithEvents txtfilelengthofl As System.Windows.Forms.TextBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents tmrrecordedfileinfooal As System.Windows.Forms.Timer
    Friend WithEvents tmroal As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar2 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents ProgressBar1 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents pnlrecording As Panel
    Friend WithEvents cmbcasparcgwindowtitlerecording As ComboBox
    Friend WithEvents cmdoutcasparcgwindowrecording As Button
    Friend WithEvents cmdshowcasparcgwindowrecording As Button
    Friend WithEvents lblChannel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblsheduleStatus As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdPlayinvlc As Button
    Friend WithEvents cmdShowInfo As Button
End Class
