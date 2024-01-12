<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc4ChannelPlayer
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
        Me.UcVideoPlayer4 = New caspar_media_playback.ucVideoPlayer()
        Me.UcVideoPlayer3 = New caspar_media_playback.ucVideoPlayer()
        Me.UcVideoPlayer2 = New caspar_media_playback.ucVideoPlayer()
        Me.UcVideoPlayer1 = New caspar_media_playback.ucVideoPlayer()
        Me.SuspendLayout()
        '
        'UcVideoPlayer4
        '
        Me.UcVideoPlayer4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcVideoPlayer4.Location = New System.Drawing.Point(604, 405)
        Me.UcVideoPlayer4.Name = "UcVideoPlayer4"
        Me.UcVideoPlayer4.Size = New System.Drawing.Size(595, 326)
        Me.UcVideoPlayer4.TabIndex = 3
        '
        'UcVideoPlayer3
        '
        Me.UcVideoPlayer3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcVideoPlayer3.Location = New System.Drawing.Point(3, 405)
        Me.UcVideoPlayer3.Name = "UcVideoPlayer3"
        Me.UcVideoPlayer3.Size = New System.Drawing.Size(595, 326)
        Me.UcVideoPlayer3.TabIndex = 2
        '
        'UcVideoPlayer2
        '
        Me.UcVideoPlayer2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcVideoPlayer2.Location = New System.Drawing.Point(604, 31)
        Me.UcVideoPlayer2.Name = "UcVideoPlayer2"
        Me.UcVideoPlayer2.Size = New System.Drawing.Size(595, 326)
        Me.UcVideoPlayer2.TabIndex = 1
        '
        'UcVideoPlayer1
        '
        Me.UcVideoPlayer1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcVideoPlayer1.Location = New System.Drawing.Point(3, 31)
        Me.UcVideoPlayer1.Name = "UcVideoPlayer1"
        Me.UcVideoPlayer1.Size = New System.Drawing.Size(595, 326)
        Me.UcVideoPlayer1.TabIndex = 0
        '
        'uc4ChannelPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 827)
        Me.Controls.Add(Me.UcVideoPlayer4)
        Me.Controls.Add(Me.UcVideoPlayer3)
        Me.Controls.Add(Me.UcVideoPlayer2)
        Me.Controls.Add(Me.UcVideoPlayer1)
        Me.HideOnClose = True
        Me.Name = "uc4ChannelPlayer"
        Me.Text = "4 Channel Player"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcVideoPlayer1 As ucVideoPlayer
    Friend WithEvents UcVideoPlayer2 As ucVideoPlayer
    Friend WithEvents UcVideoPlayer4 As ucVideoPlayer
    Friend WithEvents UcVideoPlayer3 As ucVideoPlayer
End Class
