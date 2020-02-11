<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSceneScroller
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
        Me.gbhorizontalscroll2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSceneTemplate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nopacity = New System.Windows.Forms.NumericUpDown()
        Me.Label151 = New System.Windows.Forms.Label()
        Me.Label135 = New System.Windows.Forms.Label()
        Me.cmblayerhs2 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblstripcolor2 = New System.Windows.Forms.Label()
        Me.ny2 = New System.Windows.Forms.NumericUpDown()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmdfile2 = New System.Windows.Forms.Button()
        Me.nspeed2 = New System.Windows.Forms.NumericUpDown()
        Me.cmdstopcrawl2 = New System.Windows.Forms.Button()
        Me.cmdshowcrawl2 = New System.Windows.Forms.Button()
        Me.txtcrawl2 = New System.Windows.Forms.TextBox()
        Me.ofd1 = New System.Windows.Forms.OpenFileDialog()
        Me.cd1 = New System.Windows.Forms.ColorDialog()
        Me.gbhorizontalscroll2.SuspendLayout()
        CType(Me.nopacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ny2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nspeed2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbhorizontalscroll2
        '
        Me.gbhorizontalscroll2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gbhorizontalscroll2.Controls.Add(Me.Label2)
        Me.gbhorizontalscroll2.Controls.Add(Me.txtSceneTemplate)
        Me.gbhorizontalscroll2.Controls.Add(Me.Label1)
        Me.gbhorizontalscroll2.Controls.Add(Me.nopacity)
        Me.gbhorizontalscroll2.Controls.Add(Me.Label151)
        Me.gbhorizontalscroll2.Controls.Add(Me.Label135)
        Me.gbhorizontalscroll2.Controls.Add(Me.cmblayerhs2)
        Me.gbhorizontalscroll2.Controls.Add(Me.Label17)
        Me.gbhorizontalscroll2.Controls.Add(Me.lblstripcolor2)
        Me.gbhorizontalscroll2.Controls.Add(Me.ny2)
        Me.gbhorizontalscroll2.Controls.Add(Me.Label25)
        Me.gbhorizontalscroll2.Controls.Add(Me.cmdfile2)
        Me.gbhorizontalscroll2.Controls.Add(Me.nspeed2)
        Me.gbhorizontalscroll2.Controls.Add(Me.cmdstopcrawl2)
        Me.gbhorizontalscroll2.Controls.Add(Me.cmdshowcrawl2)
        Me.gbhorizontalscroll2.Controls.Add(Me.txtcrawl2)
        Me.gbhorizontalscroll2.Location = New System.Drawing.Point(3, 4)
        Me.gbhorizontalscroll2.Name = "gbhorizontalscroll2"
        Me.gbhorizontalscroll2.Size = New System.Drawing.Size(660, 605)
        Me.gbhorizontalscroll2.TabIndex = 430
        Me.gbhorizontalscroll2.TabStop = False
        Me.gbhorizontalscroll2.Text = "Scene Scroller for server 2.1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 723
        Me.Label2.Text = "Template"
        '
        'txtSceneTemplate
        '
        Me.txtSceneTemplate.Location = New System.Drawing.Point(62, 23)
        Me.txtSceneTemplate.Name = "txtSceneTemplate"
        Me.txtSceneTemplate.Size = New System.Drawing.Size(353, 20)
        Me.txtSceneTemplate.TabIndex = 722
        Me.txtSceneTemplate.Text = "cmp/scene/crawler/crawler1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(534, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 709
        Me.Label1.Text = "Opacity"
        '
        'nopacity
        '
        Me.nopacity.DecimalPlaces = 1
        Me.nopacity.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nopacity.Location = New System.Drawing.Point(591, 172)
        Me.nopacity.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nopacity.Name = "nopacity"
        Me.nopacity.Size = New System.Drawing.Size(46, 20)
        Me.nopacity.TabIndex = 708
        Me.nopacity.Value = New Decimal(New Integer() {8, 0, 0, 65536})
        '
        'Label151
        '
        Me.Label151.AutoSize = True
        Me.Label151.Location = New System.Drawing.Point(541, 96)
        Me.Label151.Name = "Label151"
        Me.Label151.Size = New System.Drawing.Size(38, 13)
        Me.Label151.TabIndex = 360
        Me.Label151.Text = "Speed"
        '
        'Label135
        '
        Me.Label135.AutoSize = True
        Me.Label135.Location = New System.Drawing.Point(30, 69)
        Me.Label135.Name = "Label135"
        Me.Label135.Size = New System.Drawing.Size(477, 13)
        Me.Label135.TabIndex = 357
        Me.Label135.Text = "Copy from source file and paste here. Sometimes fileopen method doesn't copy the " &
    "content properly."
        '
        'cmblayerhs2
        '
        Me.cmblayerhs2.FormattingEnabled = True
        Me.cmblayerhs2.Items.AddRange(New Object() {"31", "32", "33", "34", "35"})
        Me.cmblayerhs2.Location = New System.Drawing.Point(547, 23)
        Me.cmblayerhs2.Name = "cmblayerhs2"
        Me.cmblayerhs2.Size = New System.Drawing.Size(56, 21)
        Me.cmblayerhs2.TabIndex = 322
        Me.cmblayerhs2.Text = "31"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(493, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 321
        Me.Label17.Text = "VL-FL"
        '
        'lblstripcolor2
        '
        Me.lblstripcolor2.AutoSize = True
        Me.lblstripcolor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstripcolor2.Location = New System.Drawing.Point(586, 341)
        Me.lblstripcolor2.Name = "lblstripcolor2"
        Me.lblstripcolor2.Size = New System.Drawing.Size(0, 13)
        Me.lblstripcolor2.TabIndex = 276
        '
        'ny2
        '
        Me.ny2.Location = New System.Drawing.Point(591, 119)
        Me.ny2.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.ny2.Name = "ny2"
        Me.ny2.Size = New System.Drawing.Size(46, 20)
        Me.ny2.TabIndex = 273
        Me.ny2.Value = New Decimal(New Integer() {510, 0, 0, 0})
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(529, 121)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(54, 13)
        Me.Label25.TabIndex = 271
        Me.Label25.Text = "Y Position"
        '
        'cmdfile2
        '
        Me.cmdfile2.Location = New System.Drawing.Point(591, 209)
        Me.cmdfile2.Name = "cmdfile2"
        Me.cmdfile2.Size = New System.Drawing.Size(46, 23)
        Me.cmdfile2.TabIndex = 269
        Me.cmdfile2.Text = "fileopen"
        Me.cmdfile2.UseVisualStyleBackColor = True
        '
        'nspeed2
        '
        Me.nspeed2.Location = New System.Drawing.Point(591, 93)
        Me.nspeed2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nspeed2.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.nspeed2.Name = "nspeed2"
        Me.nspeed2.Size = New System.Drawing.Size(46, 20)
        Me.nspeed2.TabIndex = 268
        Me.nspeed2.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'cmdstopcrawl2
        '
        Me.cmdstopcrawl2.BackColor = System.Drawing.Color.Red
        Me.cmdstopcrawl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopcrawl2.ForeColor = System.Drawing.Color.White
        Me.cmdstopcrawl2.Location = New System.Drawing.Point(541, 323)
        Me.cmdstopcrawl2.Name = "cmdstopcrawl2"
        Me.cmdstopcrawl2.Size = New System.Drawing.Size(96, 46)
        Me.cmdstopcrawl2.TabIndex = 263
        Me.cmdstopcrawl2.Text = "Stop"
        Me.cmdstopcrawl2.UseVisualStyleBackColor = False
        '
        'cmdshowcrawl2
        '
        Me.cmdshowcrawl2.BackColor = System.Drawing.Color.Green
        Me.cmdshowcrawl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdshowcrawl2.ForeColor = System.Drawing.Color.White
        Me.cmdshowcrawl2.Location = New System.Drawing.Point(541, 280)
        Me.cmdshowcrawl2.Name = "cmdshowcrawl2"
        Me.cmdshowcrawl2.Size = New System.Drawing.Size(96, 46)
        Me.cmdshowcrawl2.TabIndex = 262
        Me.cmdshowcrawl2.Text = "Start"
        Me.cmdshowcrawl2.UseVisualStyleBackColor = False
        '
        'txtcrawl2
        '
        Me.txtcrawl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcrawl2.Location = New System.Drawing.Point(12, 89)
        Me.txtcrawl2.Multiline = True
        Me.txtcrawl2.Name = "txtcrawl2"
        Me.txtcrawl2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtcrawl2.Size = New System.Drawing.Size(511, 510)
        Me.txtcrawl2.TabIndex = 261
        Me.txtcrawl2.Text = "Welcome To Doordarshan . This is SCENE SCROLLER testing in server 2.1. All are we" &
    "lcome to contribute."
        '
        'ofd1
        '
        Me.ofd1.FileName = "OpenFileDialog1"
        '
        'ucSceneScroller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(668, 614)
        Me.Controls.Add(Me.gbhorizontalscroll2)
        Me.HideOnClose = True
        Me.Name = "ucSceneScroller"
        Me.Text = "Scene Scroller"
        Me.gbhorizontalscroll2.ResumeLayout(False)
        Me.gbhorizontalscroll2.PerformLayout()
        CType(Me.nopacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ny2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nspeed2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbhorizontalscroll2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label151 As System.Windows.Forms.Label
    Friend WithEvents Label135 As System.Windows.Forms.Label
    Friend WithEvents cmblayerhs2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblstripcolor2 As System.Windows.Forms.Label
    Friend WithEvents ny2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmdfile2 As System.Windows.Forms.Button
    Friend WithEvents nspeed2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdstopcrawl2 As System.Windows.Forms.Button
    Friend WithEvents cmdshowcrawl2 As System.Windows.Forms.Button
    Friend WithEvents txtcrawl2 As System.Windows.Forms.TextBox
    Friend WithEvents ofd1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cd1 As System.Windows.Forms.ColorDialog
    Friend WithEvents nopacity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSceneTemplate As TextBox
End Class
