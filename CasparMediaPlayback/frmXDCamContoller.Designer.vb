<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXDCamContoller
    Inherits System.Windows.Forms.Form

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
        Me.UcXdcamController1 = New caspar_media_playback.ucXdcamController()
        Me.UcXdcamController2 = New caspar_media_playback.ucXdcamController()
        Me.SuspendLayout()
        '
        'UcXdcamController1
        '
        Me.UcXdcamController1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcXdcamController1.Location = New System.Drawing.Point(3, 1)
        Me.UcXdcamController1.Name = "UcXdcamController1"
        Me.UcXdcamController1.Size = New System.Drawing.Size(607, 1040)
        Me.UcXdcamController1.TabIndex = 0
        '
        'UcXdcamController2
        '
        Me.UcXdcamController2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcXdcamController2.Location = New System.Drawing.Point(628, 1)
        Me.UcXdcamController2.Name = "UcXdcamController2"
        Me.UcXdcamController2.Size = New System.Drawing.Size(607, 1040)
        Me.UcXdcamController2.TabIndex = 1
        '
        'frmXDCamContoller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 1045)
        Me.Controls.Add(Me.UcXdcamController2)
        Me.Controls.Add(Me.UcXdcamController1)
        Me.Name = "frmXDCamContoller"
        Me.Text = "XDCamContoller"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcXdcamController1 As ucXdcamController
    Friend WithEvents UcXdcamController2 As ucXdcamController
End Class
