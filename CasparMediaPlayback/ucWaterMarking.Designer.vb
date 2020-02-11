<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucWaterMarking
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
        Me.gbWaterMarking = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtWaterMarkingTemplate = New System.Windows.Forms.TextBox()
        Me.gbRandom = New System.Windows.Forms.GroupBox()
        Me.txtTimerInterval = New System.Windows.Forms.TextBox()
        Me.cmdSetMaxY = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdSetMinY = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdSetMaxX = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdSetMinX = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmaxY = New System.Windows.Forms.TextBox()
        Me.txtminY = New System.Windows.Forms.TextBox()
        Me.txtminX = New System.Windows.Forms.TextBox()
        Me.txtmaxX = New System.Windows.Forms.TextBox()
        Me.chkRandomePosition = New System.Windows.Forms.CheckBox()
        Me.cmbwm = New System.Windows.Forms.ComboBox()
        Me.cmdstopwm = New System.Windows.Forms.Button()
        Me.cmdplaywm = New System.Windows.Forms.Button()
        Me.cmbvideolayerwm = New System.Windows.Forms.ComboBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.gbfillwm = New System.Windows.Forms.GroupBox()
        Me.nfillxwm = New System.Windows.Forms.NumericUpDown()
        Me.nfillywm = New System.Windows.Forms.NumericUpDown()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.nfillwidthwm = New System.Windows.Forms.NumericUpDown()
        Me.nopacitywm = New System.Windows.Forms.NumericUpDown()
        Me.nfillheightwm = New System.Windows.Forms.NumericUpDown()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.cmdopacitywm = New System.Windows.Forms.Button()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label277 = New System.Windows.Forms.Label()
        Me.cmdfillwm = New System.Windows.Forms.Button()
        Me.tmrRandome = New System.Windows.Forms.Timer(Me.components)
        Me.gbWaterMarking.SuspendLayout()
        Me.gbRandom.SuspendLayout()
        Me.gbfillwm.SuspendLayout()
        CType(Me.nfillxwm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nfillywm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nfillwidthwm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nopacitywm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nfillheightwm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbWaterMarking
        '
        Me.gbWaterMarking.BackColor = System.Drawing.Color.MistyRose
        Me.gbWaterMarking.Controls.Add(Me.Label6)
        Me.gbWaterMarking.Controls.Add(Me.txtWaterMarkingTemplate)
        Me.gbWaterMarking.Controls.Add(Me.gbRandom)
        Me.gbWaterMarking.Controls.Add(Me.cmbwm)
        Me.gbWaterMarking.Controls.Add(Me.cmdstopwm)
        Me.gbWaterMarking.Controls.Add(Me.cmdplaywm)
        Me.gbWaterMarking.Controls.Add(Me.cmbvideolayerwm)
        Me.gbWaterMarking.Controls.Add(Me.Label77)
        Me.gbWaterMarking.Controls.Add(Me.gbfillwm)
        Me.gbWaterMarking.Location = New System.Drawing.Point(4, 4)
        Me.gbWaterMarking.Name = "gbWaterMarking"
        Me.gbWaterMarking.Size = New System.Drawing.Size(364, 321)
        Me.gbWaterMarking.TabIndex = 1176
        Me.gbWaterMarking.TabStop = False
        Me.gbWaterMarking.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 1173
        Me.Label6.Text = "Template"
        '
        'txtWaterMarkingTemplate
        '
        Me.txtWaterMarkingTemplate.Location = New System.Drawing.Point(67, 72)
        Me.txtWaterMarkingTemplate.Name = "txtWaterMarkingTemplate"
        Me.txtWaterMarkingTemplate.Size = New System.Drawing.Size(292, 20)
        Me.txtWaterMarkingTemplate.TabIndex = 1172
        Me.txtWaterMarkingTemplate.Text = "cmp/watermarking/watermarking1"
        '
        'gbRandom
        '
        Me.gbRandom.BackColor = System.Drawing.Color.Coral
        Me.gbRandom.Controls.Add(Me.txtTimerInterval)
        Me.gbRandom.Controls.Add(Me.cmdSetMaxY)
        Me.gbRandom.Controls.Add(Me.Label3)
        Me.gbRandom.Controls.Add(Me.cmdSetMinY)
        Me.gbRandom.Controls.Add(Me.Label4)
        Me.gbRandom.Controls.Add(Me.cmdSetMaxX)
        Me.gbRandom.Controls.Add(Me.Label2)
        Me.gbRandom.Controls.Add(Me.cmdSetMinX)
        Me.gbRandom.Controls.Add(Me.Label1)
        Me.gbRandom.Controls.Add(Me.Label5)
        Me.gbRandom.Controls.Add(Me.txtmaxY)
        Me.gbRandom.Controls.Add(Me.txtminY)
        Me.gbRandom.Controls.Add(Me.txtminX)
        Me.gbRandom.Controls.Add(Me.txtmaxX)
        Me.gbRandom.Controls.Add(Me.chkRandomePosition)
        Me.gbRandom.Location = New System.Drawing.Point(172, 141)
        Me.gbRandom.Name = "gbRandom"
        Me.gbRandom.Size = New System.Drawing.Size(187, 172)
        Me.gbRandom.TabIndex = 729
        Me.gbRandom.TabStop = False
        Me.gbRandom.Text = "Randome Settings"
        '
        'txtTimerInterval
        '
        Me.txtTimerInterval.Location = New System.Drawing.Point(136, 144)
        Me.txtTimerInterval.Name = "txtTimerInterval"
        Me.txtTimerInterval.Size = New System.Drawing.Size(43, 20)
        Me.txtTimerInterval.TabIndex = 724
        Me.txtTimerInterval.Text = "1"
        '
        'cmdSetMaxY
        '
        Me.cmdSetMaxY.Location = New System.Drawing.Point(6, 120)
        Me.cmdSetMaxY.Name = "cmdSetMaxY"
        Me.cmdSetMaxY.Size = New System.Drawing.Size(75, 23)
        Me.cmdSetMaxY.TabIndex = 728
        Me.cmdSetMaxY.Text = "Set Max Y"
        Me.cmdSetMaxY.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 722
        Me.Label3.Text = "Max Y"
        '
        'cmdSetMinY
        '
        Me.cmdSetMinY.Location = New System.Drawing.Point(6, 93)
        Me.cmdSetMinY.Name = "cmdSetMinY"
        Me.cmdSetMinY.Size = New System.Drawing.Size(75, 23)
        Me.cmdSetMinY.TabIndex = 727
        Me.cmdSetMinY.Text = "Set Min Y"
        Me.cmdSetMinY.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 721
        Me.Label4.Text = "Min Y"
        '
        'cmdSetMaxX
        '
        Me.cmdSetMaxX.Location = New System.Drawing.Point(6, 64)
        Me.cmdSetMaxX.Name = "cmdSetMaxX"
        Me.cmdSetMaxX.Size = New System.Drawing.Size(75, 23)
        Me.cmdSetMaxX.TabIndex = 726
        Me.cmdSetMaxX.Text = "Set Max X"
        Me.cmdSetMaxX.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 720
        Me.Label2.Text = "Max X"
        '
        'cmdSetMinX
        '
        Me.cmdSetMinX.Location = New System.Drawing.Point(6, 40)
        Me.cmdSetMinX.Name = "cmdSetMinX"
        Me.cmdSetMinX.Size = New System.Drawing.Size(75, 23)
        Me.cmdSetMinX.TabIndex = 725
        Me.cmdSetMinX.Text = "Set Min X"
        Me.cmdSetMinX.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 719
        Me.Label1.Text = "Min X"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 13)
        Me.Label5.TabIndex = 723
        Me.Label5.Text = "Timer Interval in Second"
        '
        'txtmaxY
        '
        Me.txtmaxY.Location = New System.Drawing.Point(136, 123)
        Me.txtmaxY.Name = "txtmaxY"
        Me.txtmaxY.Size = New System.Drawing.Size(43, 20)
        Me.txtmaxY.TabIndex = 718
        Me.txtmaxY.Text = "0.4"
        '
        'txtminY
        '
        Me.txtminY.Location = New System.Drawing.Point(136, 99)
        Me.txtminY.Name = "txtminY"
        Me.txtminY.Size = New System.Drawing.Size(43, 20)
        Me.txtminY.TabIndex = 717
        Me.txtminY.Text = "-0.5"
        '
        'txtminX
        '
        Me.txtminX.Location = New System.Drawing.Point(136, 43)
        Me.txtminX.Name = "txtminX"
        Me.txtminX.Size = New System.Drawing.Size(43, 20)
        Me.txtminX.TabIndex = 716
        Me.txtminX.Text = "-0.2"
        '
        'txtmaxX
        '
        Me.txtmaxX.Location = New System.Drawing.Point(136, 68)
        Me.txtmaxX.Name = "txtmaxX"
        Me.txtmaxX.Size = New System.Drawing.Size(43, 20)
        Me.txtmaxX.TabIndex = 715
        Me.txtmaxX.Text = "0.5"
        '
        'chkRandomePosition
        '
        Me.chkRandomePosition.AutoSize = True
        Me.chkRandomePosition.Location = New System.Drawing.Point(6, 19)
        Me.chkRandomePosition.Name = "chkRandomePosition"
        Me.chkRandomePosition.Size = New System.Drawing.Size(106, 17)
        Me.chkRandomePosition.TabIndex = 714
        Me.chkRandomePosition.Text = "Random Position"
        Me.chkRandomePosition.UseVisualStyleBackColor = True
        '
        'cmbwm
        '
        Me.cmbwm.FormattingEnabled = True
        Me.cmbwm.Items.AddRange(New Object() {"DD EXCLUSIVE", "SAHYADRI ONLY", "DD SPORTS ONLY"})
        Me.cmbwm.Location = New System.Drawing.Point(13, 113)
        Me.cmbwm.Name = "cmbwm"
        Me.cmbwm.Size = New System.Drawing.Size(153, 21)
        Me.cmbwm.TabIndex = 712
        Me.cmbwm.Text = "DD EXCLUSIVE"
        '
        'cmdstopwm
        '
        Me.cmdstopwm.BackColor = System.Drawing.Color.Red
        Me.cmdstopwm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopwm.ForeColor = System.Drawing.Color.White
        Me.cmdstopwm.Location = New System.Drawing.Point(284, 98)
        Me.cmdstopwm.Name = "cmdstopwm"
        Me.cmdstopwm.Size = New System.Drawing.Size(75, 38)
        Me.cmdstopwm.TabIndex = 429
        Me.cmdstopwm.Text = "Stop"
        Me.cmdstopwm.UseVisualStyleBackColor = False
        '
        'cmdplaywm
        '
        Me.cmdplaywm.BackColor = System.Drawing.Color.Green
        Me.cmdplaywm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplaywm.ForeColor = System.Drawing.Color.White
        Me.cmdplaywm.Location = New System.Drawing.Point(203, 97)
        Me.cmdplaywm.Name = "cmdplaywm"
        Me.cmdplaywm.Size = New System.Drawing.Size(75, 38)
        Me.cmdplaywm.TabIndex = 428
        Me.cmdplaywm.Text = "Show"
        Me.cmdplaywm.UseVisualStyleBackColor = False
        '
        'cmbvideolayerwm
        '
        Me.cmbvideolayerwm.FormattingEnabled = True
        Me.cmbvideolayerwm.Items.AddRange(New Object() {"1", "6", "11", "16", "21", "26", "31", "36", "41", "46", "51", "56", "61", "66", "71", "76", "81", "86", "9999"})
        Me.cmbvideolayerwm.Location = New System.Drawing.Point(83, 33)
        Me.cmbvideolayerwm.Name = "cmbvideolayerwm"
        Me.cmbvideolayerwm.Size = New System.Drawing.Size(44, 21)
        Me.cmbvideolayerwm.TabIndex = 427
        Me.cmbvideolayerwm.Text = "100"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(14, 36)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(52, 13)
        Me.Label77.TabIndex = 426
        Me.Label77.Text = "V-F Layer"
        '
        'gbfillwm
        '
        Me.gbfillwm.BackColor = System.Drawing.Color.DarkSalmon
        Me.gbfillwm.Controls.Add(Me.nfillxwm)
        Me.gbfillwm.Controls.Add(Me.nfillywm)
        Me.gbfillwm.Controls.Add(Me.Label78)
        Me.gbfillwm.Controls.Add(Me.Label79)
        Me.gbfillwm.Controls.Add(Me.nfillwidthwm)
        Me.gbfillwm.Controls.Add(Me.nopacitywm)
        Me.gbfillwm.Controls.Add(Me.nfillheightwm)
        Me.gbfillwm.Controls.Add(Me.Label121)
        Me.gbfillwm.Controls.Add(Me.cmdopacitywm)
        Me.gbfillwm.Controls.Add(Me.Label76)
        Me.gbfillwm.Controls.Add(Me.Label277)
        Me.gbfillwm.Controls.Add(Me.cmdfillwm)
        Me.gbfillwm.Location = New System.Drawing.Point(17, 141)
        Me.gbfillwm.Name = "gbfillwm"
        Me.gbfillwm.Size = New System.Drawing.Size(149, 172)
        Me.gbfillwm.TabIndex = 424
        Me.gbfillwm.TabStop = False
        Me.gbfillwm.Text = "Fill"
        '
        'nfillxwm
        '
        Me.nfillxwm.DecimalPlaces = 2
        Me.nfillxwm.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nfillxwm.Location = New System.Drawing.Point(66, 29)
        Me.nfillxwm.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nfillxwm.Minimum = New Decimal(New Integer() {2, 0, 0, -2147483648})
        Me.nfillxwm.Name = "nfillxwm"
        Me.nfillxwm.Size = New System.Drawing.Size(46, 20)
        Me.nfillxwm.TabIndex = 417
        '
        'nfillywm
        '
        Me.nfillywm.DecimalPlaces = 2
        Me.nfillywm.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nfillywm.Location = New System.Drawing.Point(66, 53)
        Me.nfillywm.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nfillywm.Minimum = New Decimal(New Integer() {2, 0, 0, -2147483648})
        Me.nfillywm.Name = "nfillywm"
        Me.nfillywm.Size = New System.Drawing.Size(46, 20)
        Me.nfillywm.TabIndex = 416
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(21, 102)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(44, 13)
        Me.Label78.TabIndex = 415
        Me.Label78.Text = "Y Scale"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(21, 82)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(44, 13)
        Me.Label79.TabIndex = 414
        Me.Label79.Text = "X Scale"
        '
        'nfillwidthwm
        '
        Me.nfillwidthwm.DecimalPlaces = 2
        Me.nfillwidthwm.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nfillwidthwm.Location = New System.Drawing.Point(66, 77)
        Me.nfillwidthwm.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nfillwidthwm.Name = "nfillwidthwm"
        Me.nfillwidthwm.Size = New System.Drawing.Size(46, 20)
        Me.nfillwidthwm.TabIndex = 413
        Me.nfillwidthwm.Value = New Decimal(New Integer() {100, 0, 0, 131072})
        '
        'nopacitywm
        '
        Me.nopacitywm.DecimalPlaces = 1
        Me.nopacitywm.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nopacitywm.Location = New System.Drawing.Point(67, 129)
        Me.nopacitywm.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nopacitywm.Name = "nopacitywm"
        Me.nopacitywm.Size = New System.Drawing.Size(46, 20)
        Me.nopacitywm.TabIndex = 392
        Me.nopacitywm.Value = New Decimal(New Integer() {10, 0, 0, 65536})
        '
        'nfillheightwm
        '
        Me.nfillheightwm.DecimalPlaces = 2
        Me.nfillheightwm.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nfillheightwm.Location = New System.Drawing.Point(66, 101)
        Me.nfillheightwm.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nfillheightwm.Name = "nfillheightwm"
        Me.nfillheightwm.Size = New System.Drawing.Size(46, 20)
        Me.nfillheightwm.TabIndex = 412
        Me.nfillheightwm.Value = New Decimal(New Integer() {100, 0, 0, 131072})
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.Location = New System.Drawing.Point(50, 56)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(14, 13)
        Me.Label121.TabIndex = 410
        Me.Label121.Text = "Y"
        '
        'cmdopacitywm
        '
        Me.cmdopacitywm.Location = New System.Drawing.Point(115, 127)
        Me.cmdopacitywm.Name = "cmdopacitywm"
        Me.cmdopacitywm.Size = New System.Drawing.Size(23, 22)
        Me.cmdopacitywm.TabIndex = 375
        Me.cmdopacitywm.Text = "RST"
        Me.cmdopacitywm.UseVisualStyleBackColor = True
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(10, 131)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(43, 13)
        Me.Label76.TabIndex = 373
        Me.Label76.Text = "Opacity"
        '
        'Label277
        '
        Me.Label277.AutoSize = True
        Me.Label277.Location = New System.Drawing.Point(48, 35)
        Me.Label277.Name = "Label277"
        Me.Label277.Size = New System.Drawing.Size(14, 13)
        Me.Label277.TabIndex = 408
        Me.Label277.Text = "X"
        '
        'cmdfillwm
        '
        Me.cmdfillwm.Location = New System.Drawing.Point(115, 27)
        Me.cmdfillwm.Name = "cmdfillwm"
        Me.cmdfillwm.Size = New System.Drawing.Size(21, 94)
        Me.cmdfillwm.TabIndex = 407
        Me.cmdfillwm.Text = "R"
        Me.cmdfillwm.UseVisualStyleBackColor = True
        '
        'tmrRandome
        '
        Me.tmrRandome.Interval = 1000
        '
        'ucWaterMarking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(373, 329)
        Me.Controls.Add(Me.gbWaterMarking)
        Me.HideOnClose = True
        Me.Name = "ucWaterMarking"
        Me.Text = "Water Marking"
        Me.gbWaterMarking.ResumeLayout(False)
        Me.gbWaterMarking.PerformLayout()
        Me.gbRandom.ResumeLayout(False)
        Me.gbRandom.PerformLayout()
        Me.gbfillwm.ResumeLayout(False)
        Me.gbfillwm.PerformLayout()
        CType(Me.nfillxwm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nfillywm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nfillwidthwm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nopacitywm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nfillheightwm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbWaterMarking As System.Windows.Forms.GroupBox
    Friend WithEvents cmbwm As System.Windows.Forms.ComboBox
    Friend WithEvents cmdstopwm As System.Windows.Forms.Button
    Friend WithEvents cmdplaywm As System.Windows.Forms.Button
    Friend WithEvents nopacitywm As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbvideolayerwm As System.Windows.Forms.ComboBox
    Friend WithEvents cmdopacitywm As System.Windows.Forms.Button
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents gbfillwm As System.Windows.Forms.GroupBox
    Friend WithEvents nfillxwm As System.Windows.Forms.NumericUpDown
    Friend WithEvents nfillywm As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents nfillwidthwm As System.Windows.Forms.NumericUpDown
    Friend WithEvents nfillheightwm As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label121 As System.Windows.Forms.Label
    Friend WithEvents Label277 As System.Windows.Forms.Label
    Friend WithEvents cmdfillwm As System.Windows.Forms.Button
    Friend WithEvents chkRandomePosition As System.Windows.Forms.CheckBox
    Friend WithEvents tmrRandome As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmaxY As System.Windows.Forms.TextBox
    Friend WithEvents txtminY As System.Windows.Forms.TextBox
    Friend WithEvents txtminX As System.Windows.Forms.TextBox
    Friend WithEvents txtmaxX As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTimerInterval As System.Windows.Forms.TextBox
    Friend WithEvents gbRandom As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSetMaxY As System.Windows.Forms.Button
    Friend WithEvents cmdSetMinY As System.Windows.Forms.Button
    Friend WithEvents cmdSetMaxX As System.Windows.Forms.Button
    Friend WithEvents cmdSetMinX As System.Windows.Forms.Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtWaterMarkingTemplate As TextBox
End Class
