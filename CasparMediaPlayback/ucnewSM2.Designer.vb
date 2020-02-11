<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucnewSM2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucnewSM2))
        Me.gbSm2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCustomeSpped2 = New System.Windows.Forms.TextBox()
        Me.txtCustomeSpped1 = New System.Windows.Forms.TextBox()
        Me.cmdCustomSpeed2 = New System.Windows.Forms.Button()
        Me.cmdCustomSpeed1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbChannel = New System.Windows.Forms.ComboBox()
        Me.lblplaying = New System.Windows.Forms.Label()
        Me.lblcurrentframe = New System.Windows.Forms.Label()
        Me.lblmin = New System.Windows.Forms.Label()
        Me.lblmax = New System.Windows.Forms.Label()
        Me.TrackBarseek = New System.Windows.Forms.TrackBar()
        Me.pnlrecording = New System.Windows.Forms.Panel()
        Me.cmbcasparcgwindowtitlerecording = New System.Windows.Forms.ComboBox()
        Me.cmdoutcasparcgwindowrecording = New System.Windows.Forms.Button()
        Me.cmdshowcasparcgwindowrecording = New System.Windows.Forms.Button()
        Me.cmdhidesm2 = New System.Windows.Forms.Button()
        Me.cmdspeed0sm2 = New System.Windows.Forms.Button()
        Me.Label266 = New System.Windows.Forms.Label()
        Me.nSlowMotionforwardsm2 = New System.Windows.Forms.NumericUpDown()
        Me.cmdspeed100sm2 = New System.Windows.Forms.Button()
        Me.cmdspeed75sm2 = New System.Windows.Forms.Button()
        Me.cmdspeed50sm2 = New System.Windows.Forms.Button()
        Me.cmdspeed25sm2 = New System.Windows.Forms.Button()
        Me.Label267 = New System.Windows.Forms.Label()
        Me.nSm2 = New System.Windows.Forms.NumericUpDown()
        Me.tmrpreview = New System.Windows.Forms.Timer(Me.components)
        Me.gbSm2.SuspendLayout()
        CType(Me.TrackBarseek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nSlowMotionforwardsm2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nSm2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbSm2
        '
        Me.gbSm2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.gbSm2.Controls.Add(Me.Label1)
        Me.gbSm2.Controls.Add(Me.txtCustomeSpped2)
        Me.gbSm2.Controls.Add(Me.txtCustomeSpped1)
        Me.gbSm2.Controls.Add(Me.cmdCustomSpeed2)
        Me.gbSm2.Controls.Add(Me.cmdCustomSpeed1)
        Me.gbSm2.Controls.Add(Me.Label2)
        Me.gbSm2.Controls.Add(Me.Label5)
        Me.gbSm2.Controls.Add(Me.cmbChannel)
        Me.gbSm2.Controls.Add(Me.lblplaying)
        Me.gbSm2.Controls.Add(Me.lblcurrentframe)
        Me.gbSm2.Controls.Add(Me.lblmin)
        Me.gbSm2.Controls.Add(Me.lblmax)
        Me.gbSm2.Controls.Add(Me.TrackBarseek)
        Me.gbSm2.Controls.Add(Me.pnlrecording)
        Me.gbSm2.Controls.Add(Me.cmbcasparcgwindowtitlerecording)
        Me.gbSm2.Controls.Add(Me.cmdoutcasparcgwindowrecording)
        Me.gbSm2.Controls.Add(Me.cmdshowcasparcgwindowrecording)
        Me.gbSm2.Controls.Add(Me.cmdhidesm2)
        Me.gbSm2.Controls.Add(Me.cmdspeed0sm2)
        Me.gbSm2.Controls.Add(Me.Label266)
        Me.gbSm2.Controls.Add(Me.nSlowMotionforwardsm2)
        Me.gbSm2.Controls.Add(Me.cmdspeed100sm2)
        Me.gbSm2.Controls.Add(Me.cmdspeed75sm2)
        Me.gbSm2.Controls.Add(Me.cmdspeed50sm2)
        Me.gbSm2.Controls.Add(Me.cmdspeed25sm2)
        Me.gbSm2.Controls.Add(Me.Label267)
        Me.gbSm2.Controls.Add(Me.nSm2)
        Me.gbSm2.Location = New System.Drawing.Point(3, 3)
        Me.gbSm2.Name = "gbSm2"
        Me.gbSm2.Size = New System.Drawing.Size(455, 261)
        Me.gbSm2.TabIndex = 1174
        Me.gbSm2.TabStop = False
        Me.gbSm2.Text = "Slow Motion in Server 2.1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 104)
        Me.Label1.MaximumSize = New System.Drawing.Size(75, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 72)
        Me.Label1.TabIndex = 1212
        Me.Label1.Text = "Drop Here to Play"
        '
        'txtCustomeSpped2
        '
        Me.txtCustomeSpped2.Location = New System.Drawing.Point(126, 224)
        Me.txtCustomeSpped2.Name = "txtCustomeSpped2"
        Me.txtCustomeSpped2.Size = New System.Drawing.Size(40, 20)
        Me.txtCustomeSpped2.TabIndex = 1211
        Me.txtCustomeSpped2.Text = "0.15"
        Me.txtCustomeSpped2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCustomeSpped1
        '
        Me.txtCustomeSpped1.Location = New System.Drawing.Point(126, 187)
        Me.txtCustomeSpped1.Name = "txtCustomeSpped1"
        Me.txtCustomeSpped1.Size = New System.Drawing.Size(40, 20)
        Me.txtCustomeSpped1.TabIndex = 1210
        Me.txtCustomeSpped1.Text = "0.80"
        Me.txtCustomeSpped1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdCustomSpeed2
        '
        Me.cmdCustomSpeed2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustomSpeed2.Location = New System.Drawing.Point(69, 217)
        Me.cmdCustomSpeed2.Name = "cmdCustomSpeed2"
        Me.cmdCustomSpeed2.Size = New System.Drawing.Size(55, 34)
        Me.cmdCustomSpeed2.TabIndex = 1209
        Me.cmdCustomSpeed2.Text = "Play"
        Me.cmdCustomSpeed2.UseVisualStyleBackColor = True
        '
        'cmdCustomSpeed1
        '
        Me.cmdCustomSpeed1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustomSpeed1.Location = New System.Drawing.Point(69, 179)
        Me.cmdCustomSpeed1.Name = "cmdCustomSpeed1"
        Me.cmdCustomSpeed1.Size = New System.Drawing.Size(55, 34)
        Me.cmdCustomSpeed1.TabIndex = 1208
        Me.cmdCustomSpeed1.Text = "Play"
        Me.cmdCustomSpeed1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(76, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 1207
        Me.Label2.Text = "Channel 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 1206
        Me.Label5.Text = "CH"
        '
        'cmbChannel
        '
        Me.cmbChannel.AllowDrop = True
        Me.cmbChannel.FormattingEnabled = True
        Me.cmbChannel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cmbChannel.Location = New System.Drawing.Point(33, 18)
        Me.cmbChannel.Name = "cmbChannel"
        Me.cmbChannel.Size = New System.Drawing.Size(39, 21)
        Me.cmbChannel.TabIndex = 1199
        Me.cmbChannel.Text = "2"
        '
        'lblplaying
        '
        Me.lblplaying.AutoSize = True
        Me.lblplaying.Location = New System.Drawing.Point(201, 32)
        Me.lblplaying.MaximumSize = New System.Drawing.Size(340, 0)
        Me.lblplaying.Name = "lblplaying"
        Me.lblplaying.Size = New System.Drawing.Size(52, 13)
        Me.lblplaying.TabIndex = 1185
        Me.lblplaying.Text = "File name"
        '
        'lblcurrentframe
        '
        Me.lblcurrentframe.AutoSize = True
        Me.lblcurrentframe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcurrentframe.Location = New System.Drawing.Point(303, 238)
        Me.lblcurrentframe.Name = "lblcurrentframe"
        Me.lblcurrentframe.Size = New System.Drawing.Size(10, 13)
        Me.lblcurrentframe.TabIndex = 1184
        Me.lblcurrentframe.Text = "."
        Me.lblcurrentframe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblmin
        '
        Me.lblmin.AutoSize = True
        Me.lblmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmin.Location = New System.Drawing.Point(211, 238)
        Me.lblmin.Name = "lblmin"
        Me.lblmin.Size = New System.Drawing.Size(13, 13)
        Me.lblmin.TabIndex = 1183
        Me.lblmin.Text = "0"
        Me.lblmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblmax
        '
        Me.lblmax.AutoSize = True
        Me.lblmax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmax.Location = New System.Drawing.Point(409, 238)
        Me.lblmax.Name = "lblmax"
        Me.lblmax.Size = New System.Drawing.Size(10, 13)
        Me.lblmax.TabIndex = 1181
        Me.lblmax.Text = "."
        Me.lblmax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrackBarseek
        '
        Me.TrackBarseek.AutoSize = False
        Me.TrackBarseek.BackColor = System.Drawing.SystemColors.Control
        Me.TrackBarseek.LargeChange = 2
        Me.TrackBarseek.Location = New System.Drawing.Point(204, 204)
        Me.TrackBarseek.Maximum = 999999999
        Me.TrackBarseek.Name = "TrackBarseek"
        Me.TrackBarseek.Size = New System.Drawing.Size(235, 31)
        Me.TrackBarseek.TabIndex = 1182
        Me.TrackBarseek.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'pnlrecording
        '
        Me.pnlrecording.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlrecording.Location = New System.Drawing.Point(204, 50)
        Me.pnlrecording.Name = "pnlrecording"
        Me.pnlrecording.Size = New System.Drawing.Size(235, 148)
        Me.pnlrecording.TabIndex = 1177
        '
        'cmbcasparcgwindowtitlerecording
        '
        Me.cmbcasparcgwindowtitlerecording.FormattingEnabled = True
        Me.cmbcasparcgwindowtitlerecording.Items.AddRange(New Object() {"Screen consumer [1|PAL]", "Screen consumer [2|PAL]", "Screen consumer [3|PAL]", "Screen consumer [4|PAL]", "Screen consumer [1|NTSC]", "Screen consumer [1|1080i5000]", "Screen consumer [2|1080i5000]", "Screen consumer [3|1080i5000]", "Screen consumer [4|1080i5000]", "Screen consumer [1|1080i5994]", "Screen consumer [1|1080i6000]", "Screen consumer [1|1080p2398]", "Screen consumer [1|1080p2400]", "Screen consumer [1|1080p2500]", "Screen consumer [1|1080p2997]", "Screen consumer [1|1080p3000]", "Screen consumer [1|1080p5000]", "Screen consumer [1|1080p5994]", "Screen consumer [1|1080p6000]", "Screen consumer [1|1556p2398]", "Screen consumer [1|1556p2400]", "Screen consumer [1|1556p2500]", "Screen consumer [1|2160p2398]", "Screen consumer [1|2160p2400]", "Screen consumer [1|2160p2500]", "Screen consumer [1| 2160p2997]", "Screen consumer [1|2160p3000]", "Screen consumer [1|576p2500]", "Screen consumer [1|720p2398]", "Screen consumer [1|720p2400]", "Screen consumer [1|720p2500]", "Screen consumer [1|720p2997]", "Screen consumer [1|720p3000]", "Screen consumer [1|720p5000]", "Screen consumer [1|720p5994]", "Screen consumer [1|720p6000]"})
        Me.cmbcasparcgwindowtitlerecording.Location = New System.Drawing.Point(179, 10)
        Me.cmbcasparcgwindowtitlerecording.Name = "cmbcasparcgwindowtitlerecording"
        Me.cmbcasparcgwindowtitlerecording.Size = New System.Drawing.Size(150, 21)
        Me.cmbcasparcgwindowtitlerecording.TabIndex = 1180
        Me.cmbcasparcgwindowtitlerecording.Text = "Screen consumer [2|PAL]"
        '
        'cmdoutcasparcgwindowrecording
        '
        Me.cmdoutcasparcgwindowrecording.Location = New System.Drawing.Point(367, 7)
        Me.cmdoutcasparcgwindowrecording.Name = "cmdoutcasparcgwindowrecording"
        Me.cmdoutcasparcgwindowrecording.Size = New System.Drawing.Size(47, 23)
        Me.cmdoutcasparcgwindowrecording.TabIndex = 1179
        Me.cmdoutcasparcgwindowrecording.Text = "OUT"
        Me.cmdoutcasparcgwindowrecording.UseVisualStyleBackColor = True
        '
        'cmdshowcasparcgwindowrecording
        '
        Me.cmdshowcasparcgwindowrecording.Location = New System.Drawing.Point(334, 7)
        Me.cmdshowcasparcgwindowrecording.Name = "cmdshowcasparcgwindowrecording"
        Me.cmdshowcasparcgwindowrecording.Size = New System.Drawing.Size(32, 23)
        Me.cmdshowcasparcgwindowrecording.TabIndex = 1178
        Me.cmdshowcasparcgwindowrecording.Text = "IN"
        Me.cmdshowcasparcgwindowrecording.UseVisualStyleBackColor = True
        '
        'cmdhidesm2
        '
        Me.cmdhidesm2.Image = CType(resources.GetObject("cmdhidesm2.Image"), System.Drawing.Image)
        Me.cmdhidesm2.Location = New System.Drawing.Point(420, 3)
        Me.cmdhidesm2.Name = "cmdhidesm2"
        Me.cmdhidesm2.Size = New System.Drawing.Size(28, 27)
        Me.cmdhidesm2.TabIndex = 1176
        Me.cmdhidesm2.UseVisualStyleBackColor = True
        '
        'cmdspeed0sm2
        '
        Me.cmdspeed0sm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdspeed0sm2.Location = New System.Drawing.Point(69, 100)
        Me.cmdspeed0sm2.Name = "cmdspeed0sm2"
        Me.cmdspeed0sm2.Size = New System.Drawing.Size(55, 34)
        Me.cmdspeed0sm2.TabIndex = 718
        Me.cmdspeed0sm2.Text = "0%"
        Me.cmdspeed0sm2.UseVisualStyleBackColor = True
        '
        'Label266
        '
        Me.Label266.AutoSize = True
        Me.Label266.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label266.Location = New System.Drawing.Point(6, 73)
        Me.Label266.Name = "Label266"
        Me.Label266.Size = New System.Drawing.Size(124, 24)
        Me.Label266.TabIndex = 641
        Me.Label266.Text = "Slow Motion"
        '
        'nSlowMotionforwardsm2
        '
        Me.nSlowMotionforwardsm2.DecimalPlaces = 2
        Me.nSlowMotionforwardsm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nSlowMotionforwardsm2.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nSlowMotionforwardsm2.Location = New System.Drawing.Point(132, 70)
        Me.nSlowMotionforwardsm2.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nSlowMotionforwardsm2.Name = "nSlowMotionforwardsm2"
        Me.nSlowMotionforwardsm2.Size = New System.Drawing.Size(66, 31)
        Me.nSlowMotionforwardsm2.TabIndex = 640
        Me.nSlowMotionforwardsm2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nSlowMotionforwardsm2.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'cmdspeed100sm2
        '
        Me.cmdspeed100sm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdspeed100sm2.Location = New System.Drawing.Point(69, 139)
        Me.cmdspeed100sm2.Name = "cmdspeed100sm2"
        Me.cmdspeed100sm2.Size = New System.Drawing.Size(55, 34)
        Me.cmdspeed100sm2.TabIndex = 635
        Me.cmdspeed100sm2.Text = "100%"
        Me.cmdspeed100sm2.UseVisualStyleBackColor = True
        '
        'cmdspeed75sm2
        '
        Me.cmdspeed75sm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdspeed75sm2.Location = New System.Drawing.Point(8, 171)
        Me.cmdspeed75sm2.Name = "cmdspeed75sm2"
        Me.cmdspeed75sm2.Size = New System.Drawing.Size(55, 34)
        Me.cmdspeed75sm2.TabIndex = 634
        Me.cmdspeed75sm2.Text = "75%"
        Me.cmdspeed75sm2.UseVisualStyleBackColor = True
        '
        'cmdspeed50sm2
        '
        Me.cmdspeed50sm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdspeed50sm2.Location = New System.Drawing.Point(8, 135)
        Me.cmdspeed50sm2.Name = "cmdspeed50sm2"
        Me.cmdspeed50sm2.Size = New System.Drawing.Size(55, 34)
        Me.cmdspeed50sm2.TabIndex = 633
        Me.cmdspeed50sm2.Text = "50%"
        Me.cmdspeed50sm2.UseVisualStyleBackColor = True
        '
        'cmdspeed25sm2
        '
        Me.cmdspeed25sm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdspeed25sm2.Location = New System.Drawing.Point(8, 100)
        Me.cmdspeed25sm2.Name = "cmdspeed25sm2"
        Me.cmdspeed25sm2.Size = New System.Drawing.Size(55, 34)
        Me.cmdspeed25sm2.TabIndex = 632
        Me.cmdspeed25sm2.Text = "25%"
        Me.cmdspeed25sm2.UseVisualStyleBackColor = True
        '
        'Label267
        '
        Me.Label267.AutoSize = True
        Me.Label267.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label267.Location = New System.Drawing.Point(12, 40)
        Me.Label267.Name = "Label267"
        Me.Label267.Size = New System.Drawing.Size(118, 24)
        Me.Label267.TabIndex = 602
        Me.Label267.Text = "Fast Motion"
        '
        'nSm2
        '
        Me.nSm2.DecimalPlaces = 2
        Me.nSm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nSm2.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nSm2.Location = New System.Drawing.Point(132, 37)
        Me.nSm2.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nSm2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nSm2.Name = "nSm2"
        Me.nSm2.Size = New System.Drawing.Size(66, 31)
        Me.nSm2.TabIndex = 0
        Me.nSm2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nSm2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tmrpreview
        '
        Me.tmrpreview.Interval = 1000
        '
        'ucnewSM2
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.gbSm2)
        Me.Name = "ucnewSM2"
        Me.Size = New System.Drawing.Size(462, 268)
        Me.gbSm2.ResumeLayout(False)
        Me.gbSm2.PerformLayout()
        CType(Me.TrackBarseek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nSlowMotionforwardsm2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nSm2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbSm2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdspeed0sm2 As System.Windows.Forms.Button
    Friend WithEvents Label266 As System.Windows.Forms.Label
    Friend WithEvents nSlowMotionforwardsm2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdspeed100sm2 As System.Windows.Forms.Button
    Friend WithEvents cmdspeed75sm2 As System.Windows.Forms.Button
    Friend WithEvents cmdspeed50sm2 As System.Windows.Forms.Button
    Friend WithEvents cmdspeed25sm2 As System.Windows.Forms.Button
    Friend WithEvents Label267 As System.Windows.Forms.Label
    Friend WithEvents nSm2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdhidesm2 As System.Windows.Forms.Button
    Friend WithEvents pnlrecording As Panel
    Friend WithEvents cmbcasparcgwindowtitlerecording As ComboBox
    Friend WithEvents cmdoutcasparcgwindowrecording As Button
    Friend WithEvents cmdshowcasparcgwindowrecording As Button
    Friend WithEvents lblcurrentframe As Label
    Friend WithEvents lblmin As Label
    Friend WithEvents lblmax As Label
    Friend WithEvents TrackBarseek As TrackBar
    Friend WithEvents tmrpreview As Timer
    Friend WithEvents lblplaying As Label
    Friend WithEvents cmbChannel As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCustomeSpped2 As TextBox
    Friend WithEvents txtCustomeSpped1 As TextBox
    Friend WithEvents cmdCustomSpeed2 As Button
    Friend WithEvents cmdCustomSpeed1 As Button
    Friend WithEvents Label1 As Label
End Class
