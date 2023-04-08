<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucVS2
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
        Me.gbvs2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtvs2Templatehtml = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdpausevs2html = New System.Windows.Forms.Button()
        Me.nspeedVs2html = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdstopcrawlVs2html = New System.Windows.Forms.Button()
        Me.cmdshowcrawlVs2html = New System.Windows.Forms.Button()
        Me.Flash = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtvs2Template = New System.Windows.Forms.TextBox()
        Me.Label263 = New System.Windows.Forms.Label()
        Me.cmdpausevs2 = New System.Windows.Forms.Button()
        Me.nspeedVs2 = New System.Windows.Forms.NumericUpDown()
        Me.Label265 = New System.Windows.Forms.Label()
        Me.cmdstopcrawlVs2 = New System.Windows.Forms.Button()
        Me.cmdshowcrawlVs2 = New System.Windows.Forms.Button()
        Me.cmblayervs2 = New System.Windows.Forms.ComboBox()
        Me.Label264 = New System.Windows.Forms.Label()
        Me.gbvs2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nspeedVs2html, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Flash.SuspendLayout()
        CType(Me.nspeedVs2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbvs2
        '
        Me.gbvs2.BackColor = System.Drawing.Color.LightCyan
        Me.gbvs2.Controls.Add(Me.GroupBox1)
        Me.gbvs2.Controls.Add(Me.Flash)
        Me.gbvs2.Controls.Add(Me.cmblayervs2)
        Me.gbvs2.Controls.Add(Me.Label264)
        Me.gbvs2.Location = New System.Drawing.Point(2, 2)
        Me.gbvs2.Name = "gbvs2"
        Me.gbvs2.Size = New System.Drawing.Size(509, 544)
        Me.gbvs2.TabIndex = 1173
        Me.gbvs2.TabStop = False
        Me.gbvs2.Text = " "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Aqua
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtvs2Templatehtml)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmdpausevs2html)
        Me.GroupBox1.Controls.Add(Me.nspeedVs2html)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmdstopcrawlVs2html)
        Me.GroupBox1.Controls.Add(Me.cmdshowcrawlVs2html)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 309)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 231)
        Me.GroupBox1.TabIndex = 722
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HTML"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 720
        Me.Label2.Text = "Template"
        '
        'txtvs2Templatehtml
        '
        Me.txtvs2Templatehtml.Location = New System.Drawing.Point(74, 38)
        Me.txtvs2Templatehtml.Name = "txtvs2Templatehtml"
        Me.txtvs2Templatehtml.Size = New System.Drawing.Size(353, 20)
        Me.txtvs2Templatehtml.TabIndex = 719
        Me.txtvs2Templatehtml.Text = "file:///C:/casparcg/CMP/vs2/html/gwd_preview_HtmlRoll/index.html"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 61)
        Me.Label3.MaximumSize = New System.Drawing.Size(400, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(396, 54)
        Me.Label3.TabIndex = 710
        Me.Label3.Text = "Edit the content in file:///C:/casparcg/CMP/vs2/html/gwd_preview_HtmlRoll/index.h" &
    "tml"
        '
        'cmdpausevs2html
        '
        Me.cmdpausevs2html.BackColor = System.Drawing.Color.Yellow
        Me.cmdpausevs2html.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpausevs2html.Location = New System.Drawing.Point(246, 164)
        Me.cmdpausevs2html.Name = "cmdpausevs2html"
        Me.cmdpausevs2html.Size = New System.Drawing.Size(117, 59)
        Me.cmdpausevs2html.TabIndex = 256
        Me.cmdpausevs2html.Text = "Pause / Resume"
        Me.cmdpausevs2html.UseVisualStyleBackColor = False
        '
        'nspeedVs2html
        '
        Me.nspeedVs2html.DecimalPlaces = 1
        Me.nspeedVs2html.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nspeedVs2html.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nspeedVs2html.Location = New System.Drawing.Point(134, 166)
        Me.nspeedVs2html.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nspeedVs2html.Minimum = New Decimal(New Integer() {20, 0, 0, -2147483648})
        Me.nspeedVs2html.Name = "nspeedVs2html"
        Me.nspeedVs2html.Size = New System.Drawing.Size(106, 54)
        Me.nspeedVs2html.TabIndex = 249
        Me.nspeedVs2html.Value = New Decimal(New Integer() {80, 0, 0, 65536})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(145, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 248
        Me.Label5.Text = "speed"
        '
        'cmdstopcrawlVs2html
        '
        Me.cmdstopcrawlVs2html.BackColor = System.Drawing.Color.Red
        Me.cmdstopcrawlVs2html.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopcrawlVs2html.ForeColor = System.Drawing.Color.White
        Me.cmdstopcrawlVs2html.Location = New System.Drawing.Point(369, 165)
        Me.cmdstopcrawlVs2html.Name = "cmdstopcrawlVs2html"
        Me.cmdstopcrawlVs2html.Size = New System.Drawing.Size(58, 57)
        Me.cmdstopcrawlVs2html.TabIndex = 244
        Me.cmdstopcrawlVs2html.Text = "Stop"
        Me.cmdstopcrawlVs2html.UseVisualStyleBackColor = False
        '
        'cmdshowcrawlVs2html
        '
        Me.cmdshowcrawlVs2html.BackColor = System.Drawing.Color.Green
        Me.cmdshowcrawlVs2html.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdshowcrawlVs2html.ForeColor = System.Drawing.Color.White
        Me.cmdshowcrawlVs2html.Location = New System.Drawing.Point(73, 163)
        Me.cmdshowcrawlVs2html.Name = "cmdshowcrawlVs2html"
        Me.cmdshowcrawlVs2html.Size = New System.Drawing.Size(58, 59)
        Me.cmdshowcrawlVs2html.TabIndex = 243
        Me.cmdshowcrawlVs2html.Text = "Start"
        Me.cmdshowcrawlVs2html.UseVisualStyleBackColor = False
        '
        'Flash
        '
        Me.Flash.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Flash.Controls.Add(Me.Label1)
        Me.Flash.Controls.Add(Me.txtvs2Template)
        Me.Flash.Controls.Add(Me.Label263)
        Me.Flash.Controls.Add(Me.cmdpausevs2)
        Me.Flash.Controls.Add(Me.nspeedVs2)
        Me.Flash.Controls.Add(Me.Label265)
        Me.Flash.Controls.Add(Me.cmdstopcrawlVs2)
        Me.Flash.Controls.Add(Me.cmdshowcrawlVs2)
        Me.Flash.Location = New System.Drawing.Point(15, 46)
        Me.Flash.Name = "Flash"
        Me.Flash.Size = New System.Drawing.Size(481, 231)
        Me.Flash.TabIndex = 721
        Me.Flash.TabStop = False
        Me.Flash.Text = "Flash"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 720
        Me.Label1.Text = "Template"
        '
        'txtvs2Template
        '
        Me.txtvs2Template.Location = New System.Drawing.Point(115, 15)
        Me.txtvs2Template.Name = "txtvs2Template"
        Me.txtvs2Template.Size = New System.Drawing.Size(353, 20)
        Me.txtvs2Template.TabIndex = 719
        Me.txtvs2Template.Text = "CMP/vs2/tlfroll"
        '
        'Label263
        '
        Me.Label263.AutoSize = True
        Me.Label263.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label263.Location = New System.Drawing.Point(70, 83)
        Me.Label263.Name = "Label263"
        Me.Label263.Size = New System.Drawing.Size(332, 20)
        Me.Label263.TabIndex = 710
        Me.Label263.Text = "Edit the content in cmp/TlfRoll/TlfRoll.fla"
        '
        'cmdpausevs2
        '
        Me.cmdpausevs2.BackColor = System.Drawing.Color.Yellow
        Me.cmdpausevs2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpausevs2.Location = New System.Drawing.Point(218, 144)
        Me.cmdpausevs2.Name = "cmdpausevs2"
        Me.cmdpausevs2.Size = New System.Drawing.Size(117, 59)
        Me.cmdpausevs2.TabIndex = 256
        Me.cmdpausevs2.Text = "Pause / Resume"
        Me.cmdpausevs2.UseVisualStyleBackColor = False
        '
        'nspeedVs2
        '
        Me.nspeedVs2.DecimalPlaces = 1
        Me.nspeedVs2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nspeedVs2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nspeedVs2.Location = New System.Drawing.Point(134, 145)
        Me.nspeedVs2.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nspeedVs2.Minimum = New Decimal(New Integer() {20, 0, 0, -2147483648})
        Me.nspeedVs2.Name = "nspeedVs2"
        Me.nspeedVs2.Size = New System.Drawing.Size(78, 54)
        Me.nspeedVs2.TabIndex = 249
        Me.nspeedVs2.Value = New Decimal(New Integer() {11, 0, 0, 65536})
        '
        'Label265
        '
        Me.Label265.AutoSize = True
        Me.Label265.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label265.Location = New System.Drawing.Point(145, 121)
        Me.Label265.Name = "Label265"
        Me.Label265.Size = New System.Drawing.Size(53, 20)
        Me.Label265.TabIndex = 248
        Me.Label265.Text = "speed"
        '
        'cmdstopcrawlVs2
        '
        Me.cmdstopcrawlVs2.BackColor = System.Drawing.Color.Red
        Me.cmdstopcrawlVs2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopcrawlVs2.ForeColor = System.Drawing.Color.White
        Me.cmdstopcrawlVs2.Location = New System.Drawing.Point(341, 145)
        Me.cmdstopcrawlVs2.Name = "cmdstopcrawlVs2"
        Me.cmdstopcrawlVs2.Size = New System.Drawing.Size(58, 57)
        Me.cmdstopcrawlVs2.TabIndex = 244
        Me.cmdstopcrawlVs2.Text = "Stop"
        Me.cmdstopcrawlVs2.UseVisualStyleBackColor = False
        '
        'cmdshowcrawlVs2
        '
        Me.cmdshowcrawlVs2.BackColor = System.Drawing.Color.Green
        Me.cmdshowcrawlVs2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdshowcrawlVs2.ForeColor = System.Drawing.Color.White
        Me.cmdshowcrawlVs2.Location = New System.Drawing.Point(73, 142)
        Me.cmdshowcrawlVs2.Name = "cmdshowcrawlVs2"
        Me.cmdshowcrawlVs2.Size = New System.Drawing.Size(58, 59)
        Me.cmdshowcrawlVs2.TabIndex = 243
        Me.cmdshowcrawlVs2.Text = "Start"
        Me.cmdshowcrawlVs2.UseVisualStyleBackColor = False
        '
        'cmblayervs2
        '
        Me.cmblayervs2.FormattingEnabled = True
        Me.cmblayervs2.Items.AddRange(New Object() {"26", "27", "28", "29", "30"})
        Me.cmblayervs2.Location = New System.Drawing.Point(64, 19)
        Me.cmblayervs2.Name = "cmblayervs2"
        Me.cmblayervs2.Size = New System.Drawing.Size(56, 21)
        Me.cmblayervs2.TabIndex = 324
        Me.cmblayervs2.Text = "27"
        '
        'Label264
        '
        Me.Label264.AutoSize = True
        Me.Label264.Location = New System.Drawing.Point(12, 20)
        Me.Label264.Name = "Label264"
        Me.Label264.Size = New System.Drawing.Size(35, 13)
        Me.Label264.TabIndex = 323
        Me.Label264.Text = "VL-FL"
        '
        'ucVS2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1221, 749)
        Me.Controls.Add(Me.gbvs2)
        Me.HideOnClose = True
        Me.Name = "ucVS2"
        Me.Text = "Vertical Scroll 2"
        Me.gbvs2.ResumeLayout(False)
        Me.gbvs2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nspeedVs2html, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Flash.ResumeLayout(False)
        Me.Flash.PerformLayout()
        CType(Me.nspeedVs2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbvs2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label263 As System.Windows.Forms.Label
    Friend WithEvents cmblayervs2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label264 As System.Windows.Forms.Label
    Friend WithEvents cmdpausevs2 As System.Windows.Forms.Button
    Friend WithEvents nspeedVs2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label265 As System.Windows.Forms.Label
    Friend WithEvents cmdstopcrawlVs2 As System.Windows.Forms.Button
    Friend WithEvents cmdshowcrawlVs2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtvs2Template As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtvs2Templatehtml As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdpausevs2html As Button
    Friend WithEvents nspeedVs2html As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdstopcrawlVs2html As Button
    Friend WithEvents cmdshowcrawlVs2html As Button
    Friend WithEvents Flash As GroupBox
End Class
