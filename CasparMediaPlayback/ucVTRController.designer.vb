<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucVTRController
    Inherits System.Windows.Forms.UserControl

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
        Me.tmrsr = New System.Windows.Forms.Timer(Me.components)
        Me.tmrrecorder = New System.Windows.Forms.Timer(Me.components)
        Me.tmrrecordedfileinfo = New System.Windows.Forms.Timer(Me.components)
        Me.sp = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrgettc = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbportsvtr = New System.Windows.Forms.ComboBox()
        Me.lblcomportsvtr = New System.Windows.Forms.Label()
        Me.cmdopenportsvtr = New System.Windows.Forms.Button()
        Me.cmdplayvtr = New System.Windows.Forms.Button()
        Me.cmdinpointvtr = New System.Windows.Forms.Button()
        Me.cmdoutpointvtr = New System.Windows.Forms.Button()
        Me.cmdrewindvtr = New System.Windows.Forms.Button()
        Me.cmdstopvtr = New System.Windows.Forms.Button()
        Me.cmdffvtr = New System.Windows.Forms.Button()
        Me.cmdstandbyonvtr = New System.Windows.Forms.Button()
        Me.cmdstandbyoffvtr = New System.Windows.Forms.Button()
        Me.cmdejectvtr = New System.Windows.Forms.Button()
        Me.cmdPreRollvtr = New System.Windows.Forms.Button()
        Me.cmdcuevtr = New System.Windows.Forms.Button()
        Me.cmdmarkvtr = New System.Windows.Forms.Button()
        Me.dgvcuepointsvtr = New System.Windows.Forms.DataGridView()
        Me.HScrollBarvtr = New System.Windows.Forms.HScrollBar()
        Me.lblvariablevtr = New System.Windows.Forms.Label()
        Me.HScrollBarshuttlevtr = New System.Windows.Forms.HScrollBar()
        Me.lblshuttlevtr = New System.Windows.Forms.Label()
        Me.HScrollBarjogvtr = New System.Windows.Forms.HScrollBar()
        Me.lbljogvtr = New System.Windows.Forms.Label()
        Me.cmdrecordvtr = New System.Windows.Forms.Button()
        Me.cmdautoeditvtr = New System.Windows.Forms.Button()
        Me.cmdpreviewvtr = New System.Windows.Forms.Button()
        Me.cmdReviewvtr = New System.Windows.Forms.Button()
        Me.cmdminusoneframevtr = New System.Windows.Forms.Button()
        Me.cmdplusoneframevtr = New System.Windows.Forms.Button()
        Me.cmdassembleonvtr = New System.Windows.Forms.Button()
        Me.cmdassembleoffvtr = New System.Windows.Forms.Button()
        Me.Label173 = New System.Windows.Forms.Label()
        Me.gbrecording = New System.Windows.Forms.GroupBox()
        Me.lbltimecode = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdCueToOutPoint = New System.Windows.Forms.Button()
        Me.cmdCuetoINPoint = New System.Windows.Forms.Button()
        Me.txtoutpointvtr = New System.Windows.Forms.TextBox()
        Me.txtinpointvtr = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdputinvtr = New System.Windows.Forms.Button()
        Me.cmdcuevtrout = New System.Windows.Forms.Button()
        Me.cmdmarkvtrout = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeCodeOUT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvcuepointsvtr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbrecording.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrsr
        '
        Me.tmrsr.Interval = 40
        '
        'tmrrecordedfileinfo
        '
        Me.tmrrecordedfileinfo.Interval = 1000
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Time Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'cmbportsvtr
        '
        Me.cmbportsvtr.FormattingEnabled = True
        Me.cmbportsvtr.Location = New System.Drawing.Point(82, 18)
        Me.cmbportsvtr.Name = "cmbportsvtr"
        Me.cmbportsvtr.Size = New System.Drawing.Size(55, 21)
        Me.cmbportsvtr.TabIndex = 672
        Me.cmbportsvtr.Text = "COM3"
        '
        'lblcomportsvtr
        '
        Me.lblcomportsvtr.AutoSize = True
        Me.lblcomportsvtr.Location = New System.Drawing.Point(44, 21)
        Me.lblcomportsvtr.Name = "lblcomportsvtr"
        Me.lblcomportsvtr.Size = New System.Drawing.Size(31, 13)
        Me.lblcomportsvtr.TabIndex = 673
        Me.lblcomportsvtr.Text = "Ports"
        '
        'cmdopenportsvtr
        '
        Me.cmdopenportsvtr.Location = New System.Drawing.Point(142, 17)
        Me.cmdopenportsvtr.Name = "cmdopenportsvtr"
        Me.cmdopenportsvtr.Size = New System.Drawing.Size(53, 23)
        Me.cmdopenportsvtr.TabIndex = 674
        Me.cmdopenportsvtr.Text = "Open"
        Me.cmdopenportsvtr.UseVisualStyleBackColor = True
        '
        'cmdplayvtr
        '
        Me.cmdplayvtr.Location = New System.Drawing.Point(47, 43)
        Me.cmdplayvtr.Name = "cmdplayvtr"
        Me.cmdplayvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdplayvtr.TabIndex = 675
        Me.cmdplayvtr.Text = "Play"
        Me.cmdplayvtr.UseVisualStyleBackColor = True
        '
        'cmdinpointvtr
        '
        Me.cmdinpointvtr.Location = New System.Drawing.Point(47, 118)
        Me.cmdinpointvtr.Name = "cmdinpointvtr"
        Me.cmdinpointvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdinpointvtr.TabIndex = 676
        Me.cmdinpointvtr.Text = "Mark In"
        Me.cmdinpointvtr.UseVisualStyleBackColor = True
        '
        'cmdoutpointvtr
        '
        Me.cmdoutpointvtr.Location = New System.Drawing.Point(130, 118)
        Me.cmdoutpointvtr.Name = "cmdoutpointvtr"
        Me.cmdoutpointvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdoutpointvtr.TabIndex = 677
        Me.cmdoutpointvtr.Text = "Mark Out"
        Me.cmdoutpointvtr.UseVisualStyleBackColor = True
        '
        'cmdrewindvtr
        '
        Me.cmdrewindvtr.Location = New System.Drawing.Point(47, 66)
        Me.cmdrewindvtr.Name = "cmdrewindvtr"
        Me.cmdrewindvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdrewindvtr.TabIndex = 678
        Me.cmdrewindvtr.Text = "Rewind"
        Me.cmdrewindvtr.UseVisualStyleBackColor = True
        '
        'cmdstopvtr
        '
        Me.cmdstopvtr.Location = New System.Drawing.Point(130, 43)
        Me.cmdstopvtr.Name = "cmdstopvtr"
        Me.cmdstopvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdstopvtr.TabIndex = 679
        Me.cmdstopvtr.Text = "Stop"
        Me.cmdstopvtr.UseVisualStyleBackColor = True
        '
        'cmdffvtr
        '
        Me.cmdffvtr.Location = New System.Drawing.Point(130, 66)
        Me.cmdffvtr.Name = "cmdffvtr"
        Me.cmdffvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdffvtr.TabIndex = 680
        Me.cmdffvtr.Text = "Fast FW"
        Me.cmdffvtr.UseVisualStyleBackColor = True
        '
        'cmdstandbyonvtr
        '
        Me.cmdstandbyonvtr.Location = New System.Drawing.Point(47, 167)
        Me.cmdstandbyonvtr.Name = "cmdstandbyonvtr"
        Me.cmdstandbyonvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdstandbyonvtr.TabIndex = 682
        Me.cmdstandbyonvtr.Text = "Standby ON"
        Me.cmdstandbyonvtr.UseVisualStyleBackColor = True
        '
        'cmdstandbyoffvtr
        '
        Me.cmdstandbyoffvtr.Location = New System.Drawing.Point(130, 167)
        Me.cmdstandbyoffvtr.Name = "cmdstandbyoffvtr"
        Me.cmdstandbyoffvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdstandbyoffvtr.TabIndex = 683
        Me.cmdstandbyoffvtr.Text = "Standby OFF"
        Me.cmdstandbyoffvtr.UseVisualStyleBackColor = True
        '
        'cmdejectvtr
        '
        Me.cmdejectvtr.Location = New System.Drawing.Point(130, 142)
        Me.cmdejectvtr.Name = "cmdejectvtr"
        Me.cmdejectvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdejectvtr.TabIndex = 684
        Me.cmdejectvtr.Text = "Eject"
        Me.cmdejectvtr.UseVisualStyleBackColor = True
        '
        'cmdPreRollvtr
        '
        Me.cmdPreRollvtr.Location = New System.Drawing.Point(47, 142)
        Me.cmdPreRollvtr.Name = "cmdPreRollvtr"
        Me.cmdPreRollvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdPreRollvtr.TabIndex = 685
        Me.cmdPreRollvtr.Text = "PreRoll"
        Me.cmdPreRollvtr.UseVisualStyleBackColor = True
        '
        'cmdcuevtr
        '
        Me.cmdcuevtr.Location = New System.Drawing.Point(217, 95)
        Me.cmdcuevtr.Name = "cmdcuevtr"
        Me.cmdcuevtr.Size = New System.Drawing.Size(54, 58)
        Me.cmdcuevtr.TabIndex = 686
        Me.cmdcuevtr.Text = "Cue IN"
        Me.cmdcuevtr.UseVisualStyleBackColor = True
        '
        'cmdmarkvtr
        '
        Me.cmdmarkvtr.Location = New System.Drawing.Point(57, 24)
        Me.cmdmarkvtr.Name = "cmdmarkvtr"
        Me.cmdmarkvtr.Size = New System.Drawing.Size(62, 27)
        Me.cmdmarkvtr.TabIndex = 687
        Me.cmdmarkvtr.Text = "Mark IN"
        Me.cmdmarkvtr.UseVisualStyleBackColor = True
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
        Me.dgvcuepointsvtr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.TimeCodeOUT})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvcuepointsvtr.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvcuepointsvtr.Location = New System.Drawing.Point(13, 61)
        Me.dgvcuepointsvtr.Name = "dgvcuepointsvtr"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcuepointsvtr.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvcuepointsvtr.Size = New System.Drawing.Size(198, 284)
        Me.dgvcuepointsvtr.TabIndex = 688
        '
        'HScrollBarvtr
        '
        Me.HScrollBarvtr.LargeChange = 1
        Me.HScrollBarvtr.Location = New System.Drawing.Point(38, 295)
        Me.HScrollBarvtr.Maximum = 118
        Me.HScrollBarvtr.Minimum = -118
        Me.HScrollBarvtr.Name = "HScrollBarvtr"
        Me.HScrollBarvtr.Size = New System.Drawing.Size(134, 13)
        Me.HScrollBarvtr.TabIndex = 689
        '
        'lblvariablevtr
        '
        Me.lblvariablevtr.AutoSize = True
        Me.lblvariablevtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvariablevtr.Location = New System.Drawing.Point(176, 290)
        Me.lblvariablevtr.Name = "lblvariablevtr"
        Me.lblvariablevtr.Size = New System.Drawing.Size(48, 20)
        Me.lblvariablevtr.TabIndex = 690
        Me.lblvariablevtr.Text = "Var F"
        '
        'HScrollBarshuttlevtr
        '
        Me.HScrollBarshuttlevtr.LargeChange = 1
        Me.HScrollBarshuttlevtr.Location = New System.Drawing.Point(36, 317)
        Me.HScrollBarshuttlevtr.Maximum = 118
        Me.HScrollBarshuttlevtr.Minimum = -118
        Me.HScrollBarshuttlevtr.Name = "HScrollBarshuttlevtr"
        Me.HScrollBarshuttlevtr.Size = New System.Drawing.Size(134, 13)
        Me.HScrollBarshuttlevtr.TabIndex = 691
        '
        'lblshuttlevtr
        '
        Me.lblshuttlevtr.AutoSize = True
        Me.lblshuttlevtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshuttlevtr.Location = New System.Drawing.Point(174, 313)
        Me.lblshuttlevtr.Name = "lblshuttlevtr"
        Me.lblshuttlevtr.Size = New System.Drawing.Size(60, 20)
        Me.lblshuttlevtr.TabIndex = 692
        Me.lblshuttlevtr.Text = "Shuttle"
        '
        'HScrollBarjogvtr
        '
        Me.HScrollBarjogvtr.LargeChange = 1
        Me.HScrollBarjogvtr.Location = New System.Drawing.Point(38, 271)
        Me.HScrollBarjogvtr.Maximum = 118
        Me.HScrollBarjogvtr.Minimum = -118
        Me.HScrollBarjogvtr.Name = "HScrollBarjogvtr"
        Me.HScrollBarjogvtr.Size = New System.Drawing.Size(134, 13)
        Me.HScrollBarjogvtr.TabIndex = 693
        '
        'lbljogvtr
        '
        Me.lbljogvtr.AutoSize = True
        Me.lbljogvtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljogvtr.Location = New System.Drawing.Point(176, 271)
        Me.lbljogvtr.Name = "lbljogvtr"
        Me.lbljogvtr.Size = New System.Drawing.Size(35, 20)
        Me.lbljogvtr.TabIndex = 694
        Me.lbljogvtr.Text = "Jog"
        '
        'cmdrecordvtr
        '
        Me.cmdrecordvtr.Location = New System.Drawing.Point(47, 216)
        Me.cmdrecordvtr.Name = "cmdrecordvtr"
        Me.cmdrecordvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdrecordvtr.TabIndex = 695
        Me.cmdrecordvtr.Text = "Record"
        Me.cmdrecordvtr.UseVisualStyleBackColor = True
        '
        'cmdautoeditvtr
        '
        Me.cmdautoeditvtr.Location = New System.Drawing.Point(130, 216)
        Me.cmdautoeditvtr.Name = "cmdautoeditvtr"
        Me.cmdautoeditvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdautoeditvtr.TabIndex = 696
        Me.cmdautoeditvtr.Text = "Auto Edit"
        Me.cmdautoeditvtr.UseVisualStyleBackColor = True
        '
        'cmdpreviewvtr
        '
        Me.cmdpreviewvtr.Location = New System.Drawing.Point(47, 243)
        Me.cmdpreviewvtr.Name = "cmdpreviewvtr"
        Me.cmdpreviewvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdpreviewvtr.TabIndex = 697
        Me.cmdpreviewvtr.Text = "Preview"
        Me.cmdpreviewvtr.UseVisualStyleBackColor = True
        '
        'cmdReviewvtr
        '
        Me.cmdReviewvtr.Location = New System.Drawing.Point(130, 240)
        Me.cmdReviewvtr.Name = "cmdReviewvtr"
        Me.cmdReviewvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdReviewvtr.TabIndex = 698
        Me.cmdReviewvtr.Text = "Review"
        Me.cmdReviewvtr.UseVisualStyleBackColor = True
        '
        'cmdminusoneframevtr
        '
        Me.cmdminusoneframevtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdminusoneframevtr.Location = New System.Drawing.Point(23, 24)
        Me.cmdminusoneframevtr.Name = "cmdminusoneframevtr"
        Me.cmdminusoneframevtr.Size = New System.Drawing.Size(28, 25)
        Me.cmdminusoneframevtr.TabIndex = 701
        Me.cmdminusoneframevtr.Text = "-"
        Me.cmdminusoneframevtr.UseVisualStyleBackColor = True
        '
        'cmdplusoneframevtr
        '
        Me.cmdplusoneframevtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplusoneframevtr.Location = New System.Drawing.Point(205, 24)
        Me.cmdplusoneframevtr.Name = "cmdplusoneframevtr"
        Me.cmdplusoneframevtr.Size = New System.Drawing.Size(28, 25)
        Me.cmdplusoneframevtr.TabIndex = 702
        Me.cmdplusoneframevtr.Text = "+"
        Me.cmdplusoneframevtr.UseVisualStyleBackColor = True
        '
        'cmdassembleonvtr
        '
        Me.cmdassembleonvtr.Location = New System.Drawing.Point(47, 192)
        Me.cmdassembleonvtr.Name = "cmdassembleonvtr"
        Me.cmdassembleonvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdassembleonvtr.TabIndex = 703
        Me.cmdassembleonvtr.Text = "Assemble On"
        Me.cmdassembleonvtr.UseVisualStyleBackColor = True
        '
        'cmdassembleoffvtr
        '
        Me.cmdassembleoffvtr.Location = New System.Drawing.Point(130, 192)
        Me.cmdassembleoffvtr.Name = "cmdassembleoffvtr"
        Me.cmdassembleoffvtr.Size = New System.Drawing.Size(75, 23)
        Me.cmdassembleoffvtr.TabIndex = 704
        Me.cmdassembleoffvtr.Text = "Assemble Off"
        Me.cmdassembleoffvtr.UseVisualStyleBackColor = True
        '
        'Label173
        '
        Me.Label173.AutoSize = True
        Me.Label173.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label173.Location = New System.Drawing.Point(8, 10)
        Me.Label173.Name = "Label173"
        Me.Label173.Size = New System.Drawing.Size(178, 24)
        Me.Label173.TabIndex = 705
        Me.Label173.Text = "RS 422 VTR Control"
        '
        'gbrecording
        '
        Me.gbrecording.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.gbrecording.Controls.Add(Me.lbltimecode)
        Me.gbrecording.Controls.Add(Me.GroupBox2)
        Me.gbrecording.Controls.Add(Me.GroupBox1)
        Me.gbrecording.Controls.Add(Me.Label173)
        Me.gbrecording.ForeColor = System.Drawing.Color.Black
        Me.gbrecording.Location = New System.Drawing.Point(2, 3)
        Me.gbrecording.Name = "gbrecording"
        Me.gbrecording.Size = New System.Drawing.Size(555, 404)
        Me.gbrecording.TabIndex = 178
        Me.gbrecording.TabStop = False
        '
        'lbltimecode
        '
        Me.lbltimecode.AutoSize = True
        Me.lbltimecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimecode.Location = New System.Drawing.Point(400, 10)
        Me.lbltimecode.Name = "lbltimecode"
        Me.lbltimecode.Size = New System.Drawing.Size(104, 24)
        Me.lbltimecode.TabIndex = 712
        Me.lbltimecode.Text = "Time Code"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FloralWhite
        Me.GroupBox2.Controls.Add(Me.cmdCueToOutPoint)
        Me.GroupBox2.Controls.Add(Me.cmdCuetoINPoint)
        Me.GroupBox2.Controls.Add(Me.txtoutpointvtr)
        Me.GroupBox2.Controls.Add(Me.txtinpointvtr)
        Me.GroupBox2.Controls.Add(Me.cmdassembleoffvtr)
        Me.GroupBox2.Controls.Add(Me.cmdassembleonvtr)
        Me.GroupBox2.Controls.Add(Me.cmdReviewvtr)
        Me.GroupBox2.Controls.Add(Me.cmdpreviewvtr)
        Me.GroupBox2.Controls.Add(Me.cmdautoeditvtr)
        Me.GroupBox2.Controls.Add(Me.cmdrecordvtr)
        Me.GroupBox2.Controls.Add(Me.lbljogvtr)
        Me.GroupBox2.Controls.Add(Me.HScrollBarjogvtr)
        Me.GroupBox2.Controls.Add(Me.lblshuttlevtr)
        Me.GroupBox2.Controls.Add(Me.HScrollBarshuttlevtr)
        Me.GroupBox2.Controls.Add(Me.lblvariablevtr)
        Me.GroupBox2.Controls.Add(Me.HScrollBarvtr)
        Me.GroupBox2.Controls.Add(Me.cmdPreRollvtr)
        Me.GroupBox2.Controls.Add(Me.cmdejectvtr)
        Me.GroupBox2.Controls.Add(Me.cmdstandbyoffvtr)
        Me.GroupBox2.Controls.Add(Me.cmdstandbyonvtr)
        Me.GroupBox2.Controls.Add(Me.cmdffvtr)
        Me.GroupBox2.Controls.Add(Me.cmdstopvtr)
        Me.GroupBox2.Controls.Add(Me.cmdrewindvtr)
        Me.GroupBox2.Controls.Add(Me.cmdoutpointvtr)
        Me.GroupBox2.Controls.Add(Me.cmdinpointvtr)
        Me.GroupBox2.Controls.Add(Me.cmdplayvtr)
        Me.GroupBox2.Controls.Add(Me.cmdopenportsvtr)
        Me.GroupBox2.Controls.Add(Me.lblcomportsvtr)
        Me.GroupBox2.Controls.Add(Me.cmbportsvtr)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 358)
        Me.GroupBox2.TabIndex = 711
        Me.GroupBox2.TabStop = False
        '
        'cmdCueToOutPoint
        '
        Me.cmdCueToOutPoint.Location = New System.Drawing.Point(211, 118)
        Me.cmdCueToOutPoint.Name = "cmdCueToOutPoint"
        Me.cmdCueToOutPoint.Size = New System.Drawing.Size(40, 23)
        Me.cmdCueToOutPoint.TabIndex = 709
        Me.cmdCueToOutPoint.Text = "Cue"
        Me.cmdCueToOutPoint.UseVisualStyleBackColor = True
        '
        'cmdCuetoINPoint
        '
        Me.cmdCuetoINPoint.Location = New System.Drawing.Point(3, 118)
        Me.cmdCuetoINPoint.Name = "cmdCuetoINPoint"
        Me.cmdCuetoINPoint.Size = New System.Drawing.Size(40, 23)
        Me.cmdCuetoINPoint.TabIndex = 708
        Me.cmdCuetoINPoint.Text = "Cue"
        Me.cmdCuetoINPoint.UseVisualStyleBackColor = True
        '
        'txtoutpointvtr
        '
        Me.txtoutpointvtr.Location = New System.Drawing.Point(130, 96)
        Me.txtoutpointvtr.Name = "txtoutpointvtr"
        Me.txtoutpointvtr.Size = New System.Drawing.Size(75, 20)
        Me.txtoutpointvtr.TabIndex = 707
        Me.txtoutpointvtr.Text = "00:03:00:00"
        Me.txtoutpointvtr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtinpointvtr
        '
        Me.txtinpointvtr.Location = New System.Drawing.Point(47, 94)
        Me.txtinpointvtr.Name = "txtinpointvtr"
        Me.txtinpointvtr.Size = New System.Drawing.Size(75, 20)
        Me.txtinpointvtr.TabIndex = 706
        Me.txtinpointvtr.Text = "00:02:00:00"
        Me.txtinpointvtr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.OldLace
        Me.GroupBox1.Controls.Add(Me.cmdputinvtr)
        Me.GroupBox1.Controls.Add(Me.cmdcuevtrout)
        Me.GroupBox1.Controls.Add(Me.cmdmarkvtrout)
        Me.GroupBox1.Controls.Add(Me.cmdplusoneframevtr)
        Me.GroupBox1.Controls.Add(Me.cmdminusoneframevtr)
        Me.GroupBox1.Controls.Add(Me.dgvcuepointsvtr)
        Me.GroupBox1.Controls.Add(Me.cmdmarkvtr)
        Me.GroupBox1.Controls.Add(Me.cmdcuevtr)
        Me.GroupBox1.Location = New System.Drawing.Point(271, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 358)
        Me.GroupBox1.TabIndex = 710
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Time Code"
        '
        'cmdputinvtr
        '
        Me.cmdputinvtr.Location = New System.Drawing.Point(217, 252)
        Me.cmdputinvtr.Name = "cmdputinvtr"
        Me.cmdputinvtr.Size = New System.Drawing.Size(54, 56)
        Me.cmdputinvtr.TabIndex = 705
        Me.cmdputinvtr.Text = "Put in Vtr Control"
        Me.cmdputinvtr.UseVisualStyleBackColor = True
        '
        'cmdcuevtrout
        '
        Me.cmdcuevtrout.Location = New System.Drawing.Point(217, 170)
        Me.cmdcuevtrout.Name = "cmdcuevtrout"
        Me.cmdcuevtrout.Size = New System.Drawing.Size(54, 58)
        Me.cmdcuevtrout.TabIndex = 704
        Me.cmdcuevtrout.Text = "Cue OUT"
        Me.cmdcuevtrout.UseVisualStyleBackColor = True
        '
        'cmdmarkvtrout
        '
        Me.cmdmarkvtrout.Location = New System.Drawing.Point(133, 24)
        Me.cmdmarkvtrout.Name = "cmdmarkvtrout"
        Me.cmdmarkvtrout.Size = New System.Drawing.Size(66, 27)
        Me.cmdmarkvtrout.TabIndex = 703
        Me.cmdmarkvtrout.Text = "Mark OUT"
        Me.cmdmarkvtrout.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Time Code IN"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 70
        '
        'TimeCodeOUT
        '
        Me.TimeCodeOUT.HeaderText = "Time Code OUT"
        Me.TimeCodeOUT.Name = "TimeCodeOUT"
        Me.TimeCodeOUT.Width = 70
        '
        'ucRecorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.gbrecording)
        Me.Name = "ucRecorder"
        Me.Size = New System.Drawing.Size(566, 412)
        CType(Me.dgvcuepointsvtr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbrecording.ResumeLayout(False)
        Me.gbrecording.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrsr As System.Windows.Forms.Timer
    Friend WithEvents tmrrecorder As System.Windows.Forms.Timer
    Friend WithEvents tmrrecordedfileinfo As System.Windows.Forms.Timer
    Friend WithEvents sp As System.IO.Ports.SerialPort
    Friend WithEvents tmrgettc As System.Windows.Forms.Timer
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbportsvtr As System.Windows.Forms.ComboBox
    Friend WithEvents lblcomportsvtr As System.Windows.Forms.Label
    Friend WithEvents cmdopenportsvtr As System.Windows.Forms.Button
    Friend WithEvents cmdplayvtr As System.Windows.Forms.Button
    Friend WithEvents cmdinpointvtr As System.Windows.Forms.Button
    Friend WithEvents cmdoutpointvtr As System.Windows.Forms.Button
    Friend WithEvents cmdrewindvtr As System.Windows.Forms.Button
    Friend WithEvents cmdstopvtr As System.Windows.Forms.Button
    Friend WithEvents cmdffvtr As System.Windows.Forms.Button
    Friend WithEvents cmdstandbyonvtr As System.Windows.Forms.Button
    Friend WithEvents cmdstandbyoffvtr As System.Windows.Forms.Button
    Friend WithEvents cmdejectvtr As System.Windows.Forms.Button
    Friend WithEvents cmdPreRollvtr As System.Windows.Forms.Button
    Friend WithEvents cmdcuevtr As System.Windows.Forms.Button
    Friend WithEvents cmdmarkvtr As System.Windows.Forms.Button
    Friend WithEvents dgvcuepointsvtr As System.Windows.Forms.DataGridView
    Friend WithEvents HScrollBarvtr As System.Windows.Forms.HScrollBar
    Friend WithEvents lblvariablevtr As System.Windows.Forms.Label
    Friend WithEvents HScrollBarshuttlevtr As System.Windows.Forms.HScrollBar
    Friend WithEvents lblshuttlevtr As System.Windows.Forms.Label
    Friend WithEvents HScrollBarjogvtr As System.Windows.Forms.HScrollBar
    Friend WithEvents lbljogvtr As System.Windows.Forms.Label
    Friend WithEvents cmdrecordvtr As System.Windows.Forms.Button
    Friend WithEvents cmdautoeditvtr As System.Windows.Forms.Button
    Friend WithEvents cmdpreviewvtr As System.Windows.Forms.Button
    Friend WithEvents cmdReviewvtr As System.Windows.Forms.Button
    Friend WithEvents cmdminusoneframevtr As System.Windows.Forms.Button
    Friend WithEvents cmdplusoneframevtr As System.Windows.Forms.Button
    Friend WithEvents cmdassembleonvtr As System.Windows.Forms.Button
    Friend WithEvents cmdassembleoffvtr As System.Windows.Forms.Button
    Friend WithEvents Label173 As System.Windows.Forms.Label
    Friend WithEvents gbrecording As System.Windows.Forms.GroupBox
    Friend WithEvents txtoutpointvtr As System.Windows.Forms.TextBox
    Friend WithEvents txtinpointvtr As System.Windows.Forms.TextBox
    Friend WithEvents cmdCueToOutPoint As System.Windows.Forms.Button
    Friend WithEvents cmdCuetoINPoint As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbltimecode As Label
    Friend WithEvents cmdmarkvtrout As Button
    Friend WithEvents cmdcuevtrout As Button
    Friend WithEvents cmdputinvtr As Button
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents TimeCodeOUT As DataGridViewTextBoxColumn
End Class
