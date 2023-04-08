<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucOSD
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.rdoWhite = New System.Windows.Forms.RadioButton()
        Me.rdoBlack = New System.Windows.Forms.RadioButton()
        Me.rdoOrange = New System.Windows.Forms.RadioButton()
        Me.rdoYellow = New System.Windows.Forms.RadioButton()
        Me.rdoRed = New System.Windows.Forms.RadioButton()
        Me.rdoBlue = New System.Windows.Forms.RadioButton()
        Me.rdoGreen = New System.Windows.Forms.RadioButton()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdStartDrawing = New System.Windows.Forms.Button()
        Me.lbllayerhtml = New System.Windows.Forms.Label()
        Me.cmblayerOSD = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdStopDrawing = New System.Windows.Forms.Button()
        Me.nBrushWidth = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label274 = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txOSDlTemplate = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nBrushWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoNone)
        Me.GroupBox1.Controls.Add(Me.rdoWhite)
        Me.GroupBox1.Controls.Add(Me.rdoBlack)
        Me.GroupBox1.Controls.Add(Me.rdoOrange)
        Me.GroupBox1.Controls.Add(Me.rdoYellow)
        Me.GroupBox1.Controls.Add(Me.rdoRed)
        Me.GroupBox1.Controls.Add(Me.rdoBlue)
        Me.GroupBox1.Controls.Add(Me.rdoGreen)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(85, 214)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Color"
        '
        'rdoNone
        '
        Me.rdoNone.AutoSize = True
        Me.rdoNone.Location = New System.Drawing.Point(10, 181)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(51, 17)
        Me.rdoNone.TabIndex = 7
        Me.rdoNone.Text = "None"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'rdoWhite
        '
        Me.rdoWhite.AutoSize = True
        Me.rdoWhite.Location = New System.Drawing.Point(9, 158)
        Me.rdoWhite.Name = "rdoWhite"
        Me.rdoWhite.Size = New System.Drawing.Size(53, 17)
        Me.rdoWhite.TabIndex = 6
        Me.rdoWhite.Text = "White"
        Me.rdoWhite.UseVisualStyleBackColor = True
        '
        'rdoBlack
        '
        Me.rdoBlack.AutoSize = True
        Me.rdoBlack.Location = New System.Drawing.Point(9, 135)
        Me.rdoBlack.Name = "rdoBlack"
        Me.rdoBlack.Size = New System.Drawing.Size(52, 17)
        Me.rdoBlack.TabIndex = 5
        Me.rdoBlack.Text = "Black"
        Me.rdoBlack.UseVisualStyleBackColor = True
        '
        'rdoOrange
        '
        Me.rdoOrange.AutoSize = True
        Me.rdoOrange.Location = New System.Drawing.Point(9, 112)
        Me.rdoOrange.Name = "rdoOrange"
        Me.rdoOrange.Size = New System.Drawing.Size(60, 17)
        Me.rdoOrange.TabIndex = 4
        Me.rdoOrange.Text = "Orange"
        Me.rdoOrange.UseVisualStyleBackColor = True
        '
        'rdoYellow
        '
        Me.rdoYellow.AutoSize = True
        Me.rdoYellow.Checked = True
        Me.rdoYellow.Location = New System.Drawing.Point(9, 89)
        Me.rdoYellow.Name = "rdoYellow"
        Me.rdoYellow.Size = New System.Drawing.Size(56, 17)
        Me.rdoYellow.TabIndex = 3
        Me.rdoYellow.TabStop = True
        Me.rdoYellow.Text = "Yellow"
        Me.rdoYellow.UseVisualStyleBackColor = True
        '
        'rdoRed
        '
        Me.rdoRed.AutoSize = True
        Me.rdoRed.Location = New System.Drawing.Point(9, 66)
        Me.rdoRed.Name = "rdoRed"
        Me.rdoRed.Size = New System.Drawing.Size(45, 17)
        Me.rdoRed.TabIndex = 2
        Me.rdoRed.Text = "Red"
        Me.rdoRed.UseVisualStyleBackColor = True
        '
        'rdoBlue
        '
        Me.rdoBlue.AutoSize = True
        Me.rdoBlue.Location = New System.Drawing.Point(9, 43)
        Me.rdoBlue.Name = "rdoBlue"
        Me.rdoBlue.Size = New System.Drawing.Size(46, 17)
        Me.rdoBlue.TabIndex = 1
        Me.rdoBlue.Text = "Blue"
        Me.rdoBlue.UseVisualStyleBackColor = True
        '
        'rdoGreen
        '
        Me.rdoGreen.AutoSize = True
        Me.rdoGreen.Location = New System.Drawing.Point(9, 20)
        Me.rdoGreen.Name = "rdoGreen"
        Me.rdoGreen.Size = New System.Drawing.Size(54, 17)
        Me.rdoGreen.TabIndex = 0
        Me.rdoGreen.Text = "Green"
        Me.rdoGreen.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(106, 189)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 23)
        Me.cmdClear.TabIndex = 1
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdStartDrawing
        '
        Me.cmdStartDrawing.Location = New System.Drawing.Point(106, 163)
        Me.cmdStartDrawing.Name = "cmdStartDrawing"
        Me.cmdStartDrawing.Size = New System.Drawing.Size(82, 23)
        Me.cmdStartDrawing.TabIndex = 2
        Me.cmdStartDrawing.Text = "Start Drawing"
        Me.cmdStartDrawing.UseVisualStyleBackColor = True
        '
        'lbllayerhtml
        '
        Me.lbllayerhtml.AutoSize = True
        Me.lbllayerhtml.Location = New System.Drawing.Point(71, 16)
        Me.lbllayerhtml.Name = "lbllayerhtml"
        Me.lbllayerhtml.Size = New System.Drawing.Size(33, 13)
        Me.lbllayerhtml.TabIndex = 323
        Me.lbllayerhtml.Text = "Layer"
        '
        'cmblayerOSD
        '
        Me.cmblayerOSD.FormattingEnabled = True
        Me.cmblayerOSD.Items.AddRange(New Object() {"106", "107", "108", "109", "110"})
        Me.cmblayerOSD.Location = New System.Drawing.Point(113, 12)
        Me.cmblayerOSD.Name = "cmblayerOSD"
        Me.cmblayerOSD.Size = New System.Drawing.Size(50, 21)
        Me.cmblayerOSD.TabIndex = 324
        Me.cmblayerOSD.Text = Global.caspar_media_playback.My.MySettings.Default.cmblayerosd
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 719
        Me.Label1.Text = "Brush Width"
        '
        'cmdStopDrawing
        '
        Me.cmdStopDrawing.Location = New System.Drawing.Point(106, 218)
        Me.cmdStopDrawing.Name = "cmdStopDrawing"
        Me.cmdStopDrawing.Size = New System.Drawing.Size(82, 23)
        Me.cmdStopDrawing.TabIndex = 721
        Me.cmdStopDrawing.Text = "Stop Drawing"
        Me.cmdStopDrawing.UseVisualStyleBackColor = True
        '
        'nBrushWidth
        '
        Me.nBrushWidth.Location = New System.Drawing.Point(114, 124)
        Me.nBrushWidth.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nBrushWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nBrushWidth.Name = "nBrushWidth"
        Me.nBrushWidth.Size = New System.Drawing.Size(62, 20)
        Me.nBrushWidth.TabIndex = 722
        Me.nBrushWidth.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 13)
        Me.Label2.TabIndex = 723
        Me.Label2.Text = "On Screen Drawing in Server 2.1"
        '
        'Label274
        '
        Me.Label274.AutoSize = True
        Me.Label274.Location = New System.Drawing.Point(181, 62)
        Me.Label274.Name = "Label274"
        Me.Label274.Size = New System.Drawing.Size(137, 13)
        Me.Label274.TabIndex = 1176
        Me.Label274.Text = "Download server from here."
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(181, 75)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(140, 13)
        Me.LinkLabel3.TabIndex = 1175
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "http://builds.casparcg.com/"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 1178
        Me.Label3.Text = "Template"
        '
        'txOSDlTemplate
        '
        Me.txOSDlTemplate.Location = New System.Drawing.Point(70, 39)
        Me.txOSDlTemplate.Name = "txOSDlTemplate"
        Me.txOSDlTemplate.Size = New System.Drawing.Size(247, 20)
        Me.txOSDlTemplate.TabIndex = 1177
        Me.txOSDlTemplate.Text = "C:/casparcg/mydata/OSD/OnScreenDrawing.html"
        '
        'ucOSD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(1221, 749)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txOSDlTemplate)
        Me.Controls.Add(Me.Label274)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nBrushWidth)
        Me.Controls.Add(Me.cmdStopDrawing)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmblayerOSD)
        Me.Controls.Add(Me.lbllayerhtml)
        Me.Controls.Add(Me.cmdStartDrawing)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.HideOnClose = True
        Me.Name = "ucOSD"
        Me.Text = "OSD"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nBrushWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoWhite As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBlack As System.Windows.Forms.RadioButton
    Friend WithEvents rdoOrange As System.Windows.Forms.RadioButton
    Friend WithEvents rdoYellow As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRed As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBlue As System.Windows.Forms.RadioButton
    Friend WithEvents rdoGreen As System.Windows.Forms.RadioButton
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdStartDrawing As System.Windows.Forms.Button
    Friend WithEvents cmblayerOSD As System.Windows.Forms.ComboBox
    Friend WithEvents lbllayerhtml As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdoNone As System.Windows.Forms.RadioButton
    Friend WithEvents cmdStopDrawing As System.Windows.Forms.Button
    Friend WithEvents nBrushWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label274 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents txOSDlTemplate As TextBox
End Class
