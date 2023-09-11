<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucOnLineCG
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
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCLientId = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cmblayercgOnline = New System.Windows.Forms.ComboBox()
        Me.cmdinitialize = New System.Windows.Forms.Button()
        Me.cmdOpenOnlineCG = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdStop
        '
        Me.cmdStop.Location = New System.Drawing.Point(400, 230)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(75, 23)
        Me.cmdStop.TabIndex = 614
        Me.cmdStop.Text = "Stop"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 613
        Me.Label1.Text = "Client ID"
        '
        'txtCLientId
        '
        Me.txtCLientId.Location = New System.Drawing.Point(92, 232)
        Me.txtCLientId.Name = "txtCLientId"
        Me.txtCLientId.Size = New System.Drawing.Size(100, 20)
        Me.txtCLientId.TabIndex = 612
        Me.txtCLientId.Text = "1234"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(9, 15)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(49, 13)
        Me.Label28.TabIndex = 610
        Me.Label28.Text = "VF Layer"
        '
        'cmblayercgOnline
        '
        Me.cmblayercgOnline.FormattingEnabled = True
        Me.cmblayercgOnline.Items.AddRange(New Object() {"200", "201", "202", "203", "204"})
        Me.cmblayercgOnline.Location = New System.Drawing.Point(78, 12)
        Me.cmblayercgOnline.Name = "cmblayercgOnline"
        Me.cmblayercgOnline.Size = New System.Drawing.Size(56, 21)
        Me.cmblayercgOnline.TabIndex = 611
        Me.cmblayercgOnline.Text = "200"
        '
        'cmdinitialize
        '
        Me.cmdinitialize.Location = New System.Drawing.Point(198, 230)
        Me.cmdinitialize.Name = "cmdinitialize"
        Me.cmdinitialize.Size = New System.Drawing.Size(75, 23)
        Me.cmdinitialize.TabIndex = 609
        Me.cmdinitialize.Text = "initialize"
        Me.cmdinitialize.UseVisualStyleBackColor = True
        '
        'cmdOpenOnlineCG
        '
        Me.cmdOpenOnlineCG.Location = New System.Drawing.Point(279, 229)
        Me.cmdOpenOnlineCG.Name = "cmdOpenOnlineCG"
        Me.cmdOpenOnlineCG.Size = New System.Drawing.Size(115, 23)
        Me.cmdOpenOnlineCG.TabIndex = 615
        Me.cmdOpenOnlineCG.Text = "Open Online CG"
        Me.cmdOpenOnlineCG.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 202)
        Me.Label2.MaximumSize = New System.Drawing.Size(500, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(416, 13)
        Me.Label2.TabIndex = 616
        Me.Label2.Text = "Put this Client id To RCC Client ID and Use any Play Button There to show in Casp" &
    "arcg"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.caspar_media_playback.My.Resources.Resources.RCC
        Me.PictureBox1.Location = New System.Drawing.Point(167, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 160)
        Me.PictureBox1.TabIndex = 617
        Me.PictureBox1.TabStop = False
        '
        'ucOnLineCG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 541)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdOpenOnlineCG)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCLientId)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.cmblayercgOnline)
        Me.Controls.Add(Me.cmdinitialize)
        Me.Name = "ucOnLineCG"
        Me.Text = "On Line CG RCC"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdStop As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCLientId As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents cmblayercgOnline As ComboBox
    Friend WithEvents cmdinitialize As Button
    Friend WithEvents cmdOpenOnlineCG As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
