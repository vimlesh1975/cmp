<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucFourChannelPreview
    'Inherits System.Windows.Forms.UserControl
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UcnewPreview4 = New caspar_media_playback.ucnewPreview()
        Me.UcnewPreview3 = New caspar_media_playback.ucnewPreview()
        Me.UcnewPreview2 = New caspar_media_playback.ucnewPreview()
        Me.UcnewPreview1 = New caspar_media_playback.ucnewPreview()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.GroupBox1.Controls.Add(Me.UcnewPreview4)
        Me.GroupBox1.Controls.Add(Me.UcnewPreview3)
        Me.GroupBox1.Controls.Add(Me.UcnewPreview2)
        Me.GroupBox1.Controls.Add(Me.UcnewPreview1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(893, 707)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'UcnewPreview4
        '
        Me.UcnewPreview4.BackColor = System.Drawing.Color.LightGray
        Me.UcnewPreview4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcnewPreview4.Location = New System.Drawing.Point(447, 355)
        Me.UcnewPreview4.Name = "UcnewPreview4"
        Me.UcnewPreview4.Size = New System.Drawing.Size(442, 349)
        Me.UcnewPreview4.TabIndex = 8
        '
        'UcnewPreview3
        '
        Me.UcnewPreview3.BackColor = System.Drawing.Color.LightGray
        Me.UcnewPreview3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcnewPreview3.Location = New System.Drawing.Point(0, 354)
        Me.UcnewPreview3.Name = "UcnewPreview3"
        Me.UcnewPreview3.Size = New System.Drawing.Size(442, 349)
        Me.UcnewPreview3.TabIndex = 7
        '
        'UcnewPreview2
        '
        Me.UcnewPreview2.BackColor = System.Drawing.Color.LightGray
        Me.UcnewPreview2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcnewPreview2.Location = New System.Drawing.Point(447, 0)
        Me.UcnewPreview2.Name = "UcnewPreview2"
        Me.UcnewPreview2.Size = New System.Drawing.Size(442, 349)
        Me.UcnewPreview2.TabIndex = 6
        '
        'UcnewPreview1
        '
        Me.UcnewPreview1.BackColor = System.Drawing.Color.LightGray
        Me.UcnewPreview1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcnewPreview1.Location = New System.Drawing.Point(-1, 1)
        Me.UcnewPreview1.Name = "UcnewPreview1"
        Me.UcnewPreview1.Size = New System.Drawing.Size(442, 348)
        Me.UcnewPreview1.TabIndex = 5
        '
        'ucFourChannelPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1208, 921)
        Me.Controls.Add(Me.GroupBox1)
        Me.HideOnClose = True
        Me.Name = "ucFourChannelPreview"
        Me.Text = "Four Channel Preview"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents UcnewPreview4 As ucnewPreview
    Friend WithEvents UcnewPreview3 As ucnewPreview
    Friend WithEvents UcnewPreview2 As ucnewPreview
    Friend WithEvents UcnewPreview1 As ucnewPreview
End Class
