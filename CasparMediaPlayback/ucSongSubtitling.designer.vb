<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSongSubtitling
    'Inherits System.Windows.Forms.UserControl
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucSongSubtitling))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbSongSubtotling = New System.Windows.Forms.GroupBox()
        Me.txtwidthmutliplicationfactor = New System.Windows.Forms.TextBox()
        Me.lblwidthmutliplicationfactor = New System.Windows.Forms.Label()
        Me.cmdlengthofsubtitle = New System.Windows.Forms.Button()
        Me.cmdsubstracttime = New System.Windows.Forms.Button()
        Me.cmdaddtime = New System.Windows.Forms.Button()
        Me.txtvtrstarttime = New System.Windows.Forms.TextBox()
        Me.cmdclearinandoutpoint = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttemplateresponseframe = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdStartSubtitling = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdosubtitling = New System.Windows.Forms.RadioButton()
        Me.rdomarking = New System.Windows.Forms.RadioButton()
        Me.cmdoutpoint = New System.Windows.Forms.Button()
        Me.cmbmediaforsubtitling = New System.Windows.Forms.ComboBox()
        Me.cmdinpoint = New System.Windows.Forms.Button()
        Me.cmdrefreshmediafiles = New System.Windows.Forms.Button()
        Me.cmboscport = New System.Windows.Forms.ComboBox()
        Me.lbloscport = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cmblayeronelinesuper = New System.Windows.Forms.ComboBox()
        Me.tsoneliner = New System.Windows.Forms.ToolStrip()
        Me.newtsoneliner = New System.Windows.Forms.ToolStripButton()
        Me.opentsoneliner = New System.Windows.Forms.ToolStripButton()
        Me.savetsoneliner = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.deletetsoneliner = New System.Windows.Forms.ToolStripButton()
        Me.copytsoneliner = New System.Windows.Forms.ToolStripButton()
        Me.pasteoneliner = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.removetsoneliner = New System.Windows.Forms.Button()
        Me.uptsoneliner = New System.Windows.Forms.Button()
        Me.downtsoneliner = New System.Windows.Forms.Button()
        Me.addtsoneliner = New System.Windows.Forms.Button()
        Me.dgvonelinesuper = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdonelinesuperplay = New System.Windows.Forms.Button()
        Me.cmdonelinesuperstop = New System.Windows.Forms.Button()
        Me.tmrstartsubtitling = New System.Windows.Forms.Timer(Me.components)
        Me.cmdgotoin = New System.Windows.Forms.Button()
        Me.lblhmsf = New System.Windows.Forms.Label()
        Me.sp = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrgettc = New System.Windows.Forms.Timer(Me.components)
        Me.cmdtestsongsubtitling = New System.Windows.Forms.Button()
        Me.ttsongsubtitling = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gbSongSubtotling.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tsoneliner.SuspendLayout()
        CType(Me.dgvonelinesuper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSongSubtotling
        '
        Me.gbSongSubtotling.BackColor = System.Drawing.Color.LightSkyBlue
        Me.gbSongSubtotling.Controls.Add(Me.txtwidthmutliplicationfactor)
        Me.gbSongSubtotling.Controls.Add(Me.lblwidthmutliplicationfactor)
        Me.gbSongSubtotling.Controls.Add(Me.cmdlengthofsubtitle)
        Me.gbSongSubtotling.Controls.Add(Me.cmdsubstracttime)
        Me.gbSongSubtotling.Controls.Add(Me.cmdaddtime)
        Me.gbSongSubtotling.Controls.Add(Me.txtvtrstarttime)
        Me.gbSongSubtotling.Controls.Add(Me.cmdclearinandoutpoint)
        Me.gbSongSubtotling.Controls.Add(Me.Label2)
        Me.gbSongSubtotling.Controls.Add(Me.txttemplateresponseframe)
        Me.gbSongSubtotling.Controls.Add(Me.GroupBox2)
        Me.gbSongSubtotling.Controls.Add(Me.GroupBox1)
        Me.gbSongSubtotling.Controls.Add(Me.cmdoutpoint)
        Me.gbSongSubtotling.Controls.Add(Me.cmbmediaforsubtitling)
        Me.gbSongSubtotling.Controls.Add(Me.cmdinpoint)
        Me.gbSongSubtotling.Controls.Add(Me.cmdrefreshmediafiles)
        Me.gbSongSubtotling.Controls.Add(Me.cmboscport)
        Me.gbSongSubtotling.Controls.Add(Me.lbloscport)
        Me.gbSongSubtotling.Controls.Add(Me.Label26)
        Me.gbSongSubtotling.Controls.Add(Me.cmblayeronelinesuper)
        Me.gbSongSubtotling.Controls.Add(Me.tsoneliner)
        Me.gbSongSubtotling.Controls.Add(Me.removetsoneliner)
        Me.gbSongSubtotling.Controls.Add(Me.uptsoneliner)
        Me.gbSongSubtotling.Controls.Add(Me.downtsoneliner)
        Me.gbSongSubtotling.Controls.Add(Me.addtsoneliner)
        Me.gbSongSubtotling.Controls.Add(Me.dgvonelinesuper)
        Me.gbSongSubtotling.Controls.Add(Me.cmdonelinesuperplay)
        Me.gbSongSubtotling.Controls.Add(Me.cmdonelinesuperstop)
        Me.gbSongSubtotling.Location = New System.Drawing.Point(10, 52)
        Me.gbSongSubtotling.Name = "gbSongSubtotling"
        Me.gbSongSubtotling.Size = New System.Drawing.Size(638, 859)
        Me.gbSongSubtotling.TabIndex = 536
        Me.gbSongSubtotling.TabStop = False
        Me.gbSongSubtotling.Text = "OneLiner"
        '
        'txtwidthmutliplicationfactor
        '
        Me.txtwidthmutliplicationfactor.Location = New System.Drawing.Point(589, 67)
        Me.txtwidthmutliplicationfactor.Name = "txtwidthmutliplicationfactor"
        Me.txtwidthmutliplicationfactor.Size = New System.Drawing.Size(31, 20)
        Me.txtwidthmutliplicationfactor.TabIndex = 646
        Me.txtwidthmutliplicationfactor.Text = "4.00"
        Me.txtwidthmutliplicationfactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttsongsubtitling.SetToolTip(Me.txtwidthmutliplicationfactor, "Adjust it if you change the font in template")
        '
        'lblwidthmutliplicationfactor
        '
        Me.lblwidthmutliplicationfactor.AutoSize = True
        Me.lblwidthmutliplicationfactor.Location = New System.Drawing.Point(548, 72)
        Me.lblwidthmutliplicationfactor.Name = "lblwidthmutliplicationfactor"
        Me.lblwidthmutliplicationfactor.Size = New System.Drawing.Size(33, 13)
        Me.lblwidthmutliplicationfactor.TabIndex = 645
        Me.lblwidthmutliplicationfactor.Text = "WMF"
        '
        'cmdlengthofsubtitle
        '
        Me.cmdlengthofsubtitle.Location = New System.Drawing.Point(583, 93)
        Me.cmdlengthofsubtitle.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdlengthofsubtitle.Name = "cmdlengthofsubtitle"
        Me.cmdlengthofsubtitle.Size = New System.Drawing.Size(48, 30)
        Me.cmdlengthofsubtitle.TabIndex = 644
        Me.cmdlengthofsubtitle.Text = "Width"
        Me.cmdlengthofsubtitle.UseVisualStyleBackColor = True
        '
        'cmdsubstracttime
        '
        Me.cmdsubstracttime.Location = New System.Drawing.Point(595, 12)
        Me.cmdsubstracttime.Name = "cmdsubstracttime"
        Me.cmdsubstracttime.Size = New System.Drawing.Size(43, 23)
        Me.cmdsubstracttime.TabIndex = 643
        Me.cmdsubstracttime.Text = "-"
        Me.cmdsubstracttime.UseVisualStyleBackColor = True
        '
        'cmdaddtime
        '
        Me.cmdaddtime.Location = New System.Drawing.Point(551, 10)
        Me.cmdaddtime.Name = "cmdaddtime"
        Me.cmdaddtime.Size = New System.Drawing.Size(43, 23)
        Me.cmdaddtime.TabIndex = 642
        Me.cmdaddtime.Text = "+"
        Me.cmdaddtime.UseVisualStyleBackColor = True
        '
        'txtvtrstarttime
        '
        Me.txtvtrstarttime.Location = New System.Drawing.Point(555, 35)
        Me.txtvtrstarttime.Name = "txtvtrstarttime"
        Me.txtvtrstarttime.Size = New System.Drawing.Size(77, 20)
        Me.txtvtrstarttime.TabIndex = 640
        Me.txtvtrstarttime.Text = "00:02:00:00"
        '
        'cmdclearinandoutpoint
        '
        Me.cmdclearinandoutpoint.Location = New System.Drawing.Point(537, 95)
        Me.cmdclearinandoutpoint.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdclearinandoutpoint.Name = "cmdclearinandoutpoint"
        Me.cmdclearinandoutpoint.Size = New System.Drawing.Size(43, 30)
        Me.cmdclearinandoutpoint.TabIndex = 633
        Me.cmdclearinandoutpoint.Text = "Clear"
        Me.cmdclearinandoutpoint.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 632
        Me.Label2.Text = "Response Time"
        '
        'txttemplateresponseframe
        '
        Me.txttemplateresponseframe.Location = New System.Drawing.Point(357, 39)
        Me.txttemplateresponseframe.Name = "txttemplateresponseframe"
        Me.txttemplateresponseframe.Size = New System.Drawing.Size(73, 20)
        Me.txttemplateresponseframe.TabIndex = 631
        Me.txttemplateresponseframe.Text = "00:00:01:10"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.cmdStartSubtitling)
        Me.GroupBox2.Location = New System.Drawing.Point(193, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(103, 48)
        Me.GroupBox2.TabIndex = 630
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Auto SubTitling"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(52, 16)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 30)
        Me.Button1.TabIndex = 626
        Me.Button1.Text = "Stop"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdStartSubtitling
        '
        Me.cmdStartSubtitling.Location = New System.Drawing.Point(6, 16)
        Me.cmdStartSubtitling.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdStartSubtitling.Name = "cmdStartSubtitling"
        Me.cmdStartSubtitling.Size = New System.Drawing.Size(45, 30)
        Me.cmdStartSubtitling.TabIndex = 625
        Me.cmdStartSubtitling.Text = "Start"
        Me.cmdStartSubtitling.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdosubtitling)
        Me.GroupBox1.Controls.Add(Me.rdomarking)
        Me.GroupBox1.Location = New System.Drawing.Point(300, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 38)
        Me.GroupBox1.TabIndex = 629
        Me.GroupBox1.TabStop = False
        '
        'rdosubtitling
        '
        Me.rdosubtitling.AutoSize = True
        Me.rdosubtitling.Location = New System.Drawing.Point(61, 13)
        Me.rdosubtitling.Name = "rdosubtitling"
        Me.rdosubtitling.Size = New System.Drawing.Size(68, 17)
        Me.rdosubtitling.TabIndex = 1
        Me.rdosubtitling.Text = "Subtitling"
        Me.rdosubtitling.UseVisualStyleBackColor = True
        '
        'rdomarking
        '
        Me.rdomarking.AutoSize = True
        Me.rdomarking.Checked = True
        Me.rdomarking.Location = New System.Drawing.Point(3, 13)
        Me.rdomarking.Name = "rdomarking"
        Me.rdomarking.Size = New System.Drawing.Size(63, 17)
        Me.rdomarking.TabIndex = 0
        Me.rdomarking.TabStop = True
        Me.rdomarking.Text = "Marking"
        Me.rdomarking.UseVisualStyleBackColor = True
        '
        'cmdoutpoint
        '
        Me.cmdoutpoint.Location = New System.Drawing.Point(408, 95)
        Me.cmdoutpoint.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdoutpoint.Name = "cmdoutpoint"
        Me.cmdoutpoint.Size = New System.Drawing.Size(36, 30)
        Me.cmdoutpoint.TabIndex = 624
        Me.cmdoutpoint.Text = "out"
        Me.cmdoutpoint.UseVisualStyleBackColor = True
        '
        'cmbmediaforsubtitling
        '
        Me.cmbmediaforsubtitling.FormattingEnabled = True
        Me.cmbmediaforsubtitling.Location = New System.Drawing.Point(10, 72)
        Me.cmbmediaforsubtitling.Name = "cmbmediaforsubtitling"
        Me.cmbmediaforsubtitling.Size = New System.Drawing.Size(121, 21)
        Me.cmbmediaforsubtitling.TabIndex = 628
        Me.cmbmediaforsubtitling.Text = "kabhi_kabhi"
        '
        'cmdinpoint
        '
        Me.cmdinpoint.Location = New System.Drawing.Point(348, 94)
        Me.cmdinpoint.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdinpoint.Name = "cmdinpoint"
        Me.cmdinpoint.Size = New System.Drawing.Size(36, 30)
        Me.cmdinpoint.TabIndex = 623
        Me.cmdinpoint.Text = "in"
        Me.cmdinpoint.UseVisualStyleBackColor = True
        '
        'cmdrefreshmediafiles
        '
        Me.cmdrefreshmediafiles.Location = New System.Drawing.Point(132, 70)
        Me.cmdrefreshmediafiles.Name = "cmdrefreshmediafiles"
        Me.cmdrefreshmediafiles.Size = New System.Drawing.Size(57, 23)
        Me.cmdrefreshmediafiles.TabIndex = 627
        Me.cmdrefreshmediafiles.Text = "Refresh"
        Me.cmdrefreshmediafiles.UseVisualStyleBackColor = True
        '
        'cmboscport
        '
        Me.cmboscport.FormattingEnabled = True
        Me.cmboscport.Items.AddRange(New Object() {"6250", "5253"})
        Me.cmboscport.Location = New System.Drawing.Point(365, 17)
        Me.cmboscport.Name = "cmboscport"
        Me.cmboscport.Size = New System.Drawing.Size(56, 21)
        Me.cmboscport.TabIndex = 619
        Me.cmboscport.Text = "6251"
        '
        'lbloscport
        '
        Me.lbloscport.AutoSize = True
        Me.lbloscport.Location = New System.Drawing.Point(329, 20)
        Me.lbloscport.Name = "lbloscport"
        Me.lbloscport.Size = New System.Drawing.Size(26, 13)
        Me.lbloscport.TabIndex = 616
        Me.lbloscport.Text = "Port"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(1, 24)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(108, 13)
        Me.Label26.TabIndex = 517
        Me.Label26.Text = "video layer-flash layer"
        '
        'cmblayeronelinesuper
        '
        Me.cmblayeronelinesuper.FormattingEnabled = True
        Me.cmblayeronelinesuper.Items.AddRange(New Object() {"61", "62", "63", "64", "65"})
        Me.cmblayeronelinesuper.Location = New System.Drawing.Point(117, 20)
        Me.cmblayeronelinesuper.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmblayeronelinesuper.Name = "cmblayeronelinesuper"
        Me.cmblayeronelinesuper.Size = New System.Drawing.Size(40, 21)
        Me.cmblayeronelinesuper.TabIndex = 516
        Me.cmblayeronelinesuper.Text = "61"
        '
        'tsoneliner
        '
        Me.tsoneliner.Dock = System.Windows.Forms.DockStyle.None
        Me.tsoneliner.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newtsoneliner, Me.opentsoneliner, Me.savetsoneliner, Me.ToolStripSeparator6, Me.deletetsoneliner, Me.copytsoneliner, Me.pasteoneliner, Me.ToolStripSeparator7})
        Me.tsoneliner.Location = New System.Drawing.Point(9, 101)
        Me.tsoneliner.MaximumSize = New System.Drawing.Size(200, 200)
        Me.tsoneliner.Name = "tsoneliner"
        Me.tsoneliner.Size = New System.Drawing.Size(162, 25)
        Me.tsoneliner.TabIndex = 515
        Me.tsoneliner.Text = "ToolStrip2"
        '
        'newtsoneliner
        '
        Me.newtsoneliner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.newtsoneliner.Image = CType(resources.GetObject("newtsoneliner.Image"), System.Drawing.Image)
        Me.newtsoneliner.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newtsoneliner.Name = "newtsoneliner"
        Me.newtsoneliner.Size = New System.Drawing.Size(23, 22)
        Me.newtsoneliner.Text = "&New"
        '
        'opentsoneliner
        '
        Me.opentsoneliner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.opentsoneliner.Image = CType(resources.GetObject("opentsoneliner.Image"), System.Drawing.Image)
        Me.opentsoneliner.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.opentsoneliner.Name = "opentsoneliner"
        Me.opentsoneliner.Size = New System.Drawing.Size(23, 22)
        Me.opentsoneliner.Text = "&Open"
        '
        'savetsoneliner
        '
        Me.savetsoneliner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.savetsoneliner.Image = CType(resources.GetObject("savetsoneliner.Image"), System.Drawing.Image)
        Me.savetsoneliner.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.savetsoneliner.Name = "savetsoneliner"
        Me.savetsoneliner.Size = New System.Drawing.Size(23, 22)
        Me.savetsoneliner.Text = "&Save"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'deletetsoneliner
        '
        Me.deletetsoneliner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.deletetsoneliner.Image = CType(resources.GetObject("deletetsoneliner.Image"), System.Drawing.Image)
        Me.deletetsoneliner.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.deletetsoneliner.Name = "deletetsoneliner"
        Me.deletetsoneliner.Size = New System.Drawing.Size(23, 22)
        Me.deletetsoneliner.Text = "C&ut"
        '
        'copytsoneliner
        '
        Me.copytsoneliner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.copytsoneliner.Image = CType(resources.GetObject("copytsoneliner.Image"), System.Drawing.Image)
        Me.copytsoneliner.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.copytsoneliner.Name = "copytsoneliner"
        Me.copytsoneliner.Size = New System.Drawing.Size(23, 22)
        Me.copytsoneliner.Text = "&Copy"
        '
        'pasteoneliner
        '
        Me.pasteoneliner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.pasteoneliner.Image = CType(resources.GetObject("pasteoneliner.Image"), System.Drawing.Image)
        Me.pasteoneliner.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pasteoneliner.Name = "pasteoneliner"
        Me.pasteoneliner.Size = New System.Drawing.Size(23, 22)
        Me.pasteoneliner.Text = "&Paste"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'removetsoneliner
        '
        Me.removetsoneliner.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removetsoneliner.Location = New System.Drawing.Point(292, 103)
        Me.removetsoneliner.Name = "removetsoneliner"
        Me.removetsoneliner.Size = New System.Drawing.Size(33, 22)
        Me.removetsoneliner.TabIndex = 514
        Me.removetsoneliner.UseVisualStyleBackColor = True
        '
        'uptsoneliner
        '
        Me.uptsoneliner.Image = CType(resources.GetObject("uptsoneliner.Image"), System.Drawing.Image)
        Me.uptsoneliner.Location = New System.Drawing.Point(176, 103)
        Me.uptsoneliner.Name = "uptsoneliner"
        Me.uptsoneliner.Size = New System.Drawing.Size(28, 23)
        Me.uptsoneliner.TabIndex = 512
        Me.uptsoneliner.UseVisualStyleBackColor = True
        '
        'downtsoneliner
        '
        Me.downtsoneliner.Image = CType(resources.GetObject("downtsoneliner.Image"), System.Drawing.Image)
        Me.downtsoneliner.Location = New System.Drawing.Point(208, 103)
        Me.downtsoneliner.Name = "downtsoneliner"
        Me.downtsoneliner.Size = New System.Drawing.Size(36, 23)
        Me.downtsoneliner.TabIndex = 513
        Me.downtsoneliner.UseVisualStyleBackColor = True
        '
        'addtsoneliner
        '
        Me.addtsoneliner.Image = CType(resources.GetObject("addtsoneliner.Image"), System.Drawing.Image)
        Me.addtsoneliner.Location = New System.Drawing.Point(245, 103)
        Me.addtsoneliner.Name = "addtsoneliner"
        Me.addtsoneliner.Size = New System.Drawing.Size(41, 23)
        Me.addtsoneliner.TabIndex = 511
        Me.addtsoneliner.UseVisualStyleBackColor = True
        '
        'dgvonelinesuper
        '
        Me.dgvonelinesuper.AllowDrop = True
        Me.dgvonelinesuper.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvonelinesuper.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvonelinesuper.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvonelinesuper.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvonelinesuper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvonelinesuper.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvonelinesuper.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvonelinesuper.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvonelinesuper.Location = New System.Drawing.Point(7, 126)
        Me.dgvonelinesuper.MultiSelect = False
        Me.dgvonelinesuper.Name = "dgvonelinesuper"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvonelinesuper.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvonelinesuper.RowHeadersWidth = 25
        Me.dgvonelinesuper.Size = New System.Drawing.Size(625, 727)
        Me.dgvonelinesuper.TabIndex = 510
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("DVOT-Bhima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Lyrics Super"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 275
        '
        'Column1
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column1.HeaderText = "inframe"
        Me.Column1.Name = "Column1"
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column1.Width = 90
        '
        'Column2
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column2.HeaderText = "outframe"
        Me.Column2.Name = "Column2"
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column2.Width = 90
        '
        'Column3
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column3.HeaderText = "duration"
        Me.Column3.Name = "Column3"
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column3.Width = 90
        '
        'Column4
        '
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column4.HeaderText = "Width"
        Me.Column4.Name = "Column4"
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column4.Width = 40
        '
        'cmdonelinesuperplay
        '
        Me.cmdonelinesuperplay.Location = New System.Drawing.Point(452, 95)
        Me.cmdonelinesuperplay.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdonelinesuperplay.Name = "cmdonelinesuperplay"
        Me.cmdonelinesuperplay.Size = New System.Drawing.Size(36, 30)
        Me.cmdonelinesuperplay.TabIndex = 507
        Me.cmdonelinesuperplay.Text = "Play"
        Me.cmdonelinesuperplay.UseVisualStyleBackColor = True
        '
        'cmdonelinesuperstop
        '
        Me.cmdonelinesuperstop.Location = New System.Drawing.Point(496, 94)
        Me.cmdonelinesuperstop.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdonelinesuperstop.Name = "cmdonelinesuperstop"
        Me.cmdonelinesuperstop.Size = New System.Drawing.Size(39, 30)
        Me.cmdonelinesuperstop.TabIndex = 508
        Me.cmdonelinesuperstop.Text = "Stop"
        Me.cmdonelinesuperstop.UseVisualStyleBackColor = True
        '
        'tmrstartsubtitling
        '
        Me.tmrstartsubtitling.Interval = 20
        '
        'cmdgotoin
        '
        Me.cmdgotoin.Location = New System.Drawing.Point(654, 334)
        Me.cmdgotoin.Name = "cmdgotoin"
        Me.cmdgotoin.Size = New System.Drawing.Size(52, 96)
        Me.cmdgotoin.TabIndex = 348
        Me.cmdgotoin.Text = "GOTO IN"
        Me.cmdgotoin.UseVisualStyleBackColor = True
        '
        'lblhmsf
        '
        Me.lblhmsf.AutoSize = True
        Me.lblhmsf.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhmsf.Location = New System.Drawing.Point(179, 0)
        Me.lblhmsf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblhmsf.Name = "lblhmsf"
        Me.lblhmsf.Size = New System.Drawing.Size(182, 37)
        Me.lblhmsf.TabIndex = 636
        Me.lblhmsf.Text = "Time Code"
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
        Me.tmrgettc.Interval = 20
        '
        'cmdtestsongsubtitling
        '
        Me.cmdtestsongsubtitling.Location = New System.Drawing.Point(566, 19)
        Me.cmdtestsongsubtitling.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdtestsongsubtitling.Name = "cmdtestsongsubtitling"
        Me.cmdtestsongsubtitling.Size = New System.Drawing.Size(77, 30)
        Me.cmdtestsongsubtitling.TabIndex = 627
        Me.cmdtestsongsubtitling.Text = "Test"
        Me.cmdtestsongsubtitling.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle10.Font = New System.Drawing.Font("DVOT-Bhima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Lyrics Super"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 275
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn2.HeaderText = "inframe"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 90
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn4.HeaderText = "duration"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 90
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn5.HeaderText = "Width"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 40
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox4.Controls.Add(Me.gbSongSubtotling)
        Me.GroupBox4.Controls.Add(Me.cmdtestsongsubtitling)
        Me.GroupBox4.Controls.Add(Me.lblhmsf)
        Me.GroupBox4.Controls.Add(Me.cmdgotoin)
        Me.GroupBox4.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(712, 913)
        Me.GroupBox4.TabIndex = 637
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = " "
        '
        'ucSongSubtitling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(722, 922)
        Me.Controls.Add(Me.GroupBox4)
        Me.HideOnClose = True
        Me.Name = "ucSongSubtitling"
        Me.Text = "Song SubTitling"
        Me.gbSongSubtotling.ResumeLayout(False)
        Me.gbSongSubtotling.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tsoneliner.ResumeLayout(False)
        Me.tsoneliner.PerformLayout()
        CType(Me.dgvonelinesuper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbSongSubtotling As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cmblayeronelinesuper As System.Windows.Forms.ComboBox
    Friend WithEvents tsoneliner As System.Windows.Forms.ToolStrip
    Friend WithEvents newtsoneliner As System.Windows.Forms.ToolStripButton
    Friend WithEvents opentsoneliner As System.Windows.Forms.ToolStripButton
    Friend WithEvents savetsoneliner As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents deletetsoneliner As System.Windows.Forms.ToolStripButton
    Friend WithEvents copytsoneliner As System.Windows.Forms.ToolStripButton
    Friend WithEvents pasteoneliner As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents removetsoneliner As System.Windows.Forms.Button
    Friend WithEvents uptsoneliner As System.Windows.Forms.Button
    Friend WithEvents downtsoneliner As System.Windows.Forms.Button
    Friend WithEvents addtsoneliner As System.Windows.Forms.Button
    Friend WithEvents dgvonelinesuper As System.Windows.Forms.DataGridView
    Friend WithEvents cmdonelinesuperplay As System.Windows.Forms.Button
    Friend WithEvents cmdonelinesuperstop As System.Windows.Forms.Button
    Friend WithEvents cmboscport As System.Windows.Forms.ComboBox
    Friend WithEvents lbloscport As System.Windows.Forms.Label
    Friend WithEvents cmdoutpoint As System.Windows.Forms.Button
    Friend WithEvents cmdinpoint As System.Windows.Forms.Button
    Friend WithEvents tmrstartsubtitling As System.Windows.Forms.Timer
    Friend WithEvents cmdStartSubtitling As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdrefreshmediafiles As System.Windows.Forms.Button
    Friend WithEvents cmbmediaforsubtitling As System.Windows.Forms.ComboBox
    Friend WithEvents cmdgotoin As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdosubtitling As System.Windows.Forms.RadioButton
    Friend WithEvents rdomarking As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttemplateresponseframe As System.Windows.Forms.TextBox
    Friend WithEvents cmdclearinandoutpoint As System.Windows.Forms.Button
    Friend WithEvents lblhmsf As System.Windows.Forms.Label
    Friend WithEvents sp As System.IO.Ports.SerialPort
    Friend WithEvents tmrgettc As System.Windows.Forms.Timer
    Friend WithEvents txtvtrstarttime As System.Windows.Forms.TextBox
    Friend WithEvents cmdaddtime As System.Windows.Forms.Button
    Friend WithEvents cmdsubstracttime As System.Windows.Forms.Button
    Friend WithEvents cmdlengthofsubtitle As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdtestsongsubtitling As System.Windows.Forms.Button
    Friend WithEvents txtwidthmutliplicationfactor As System.Windows.Forms.TextBox
    Friend WithEvents lblwidthmutliplicationfactor As System.Windows.Forms.Label
    Friend WithEvents ttsongsubtitling As System.Windows.Forms.ToolTip
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As GroupBox
End Class
