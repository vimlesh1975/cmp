<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucOffAirLogger
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrrecordedfileinfooal = New System.Windows.Forms.Timer(Me.components)
        Me.tmroal = New System.Windows.Forms.Timer(Me.components)
        Me.UcnewOffAirLogger1 = New caspar_media_playback.ucnewOffAirLogger()
        Me.SuspendLayout()
        '
        'tmrrecordedfileinfooal
        '
        Me.tmrrecordedfileinfooal.Interval = 1000
        '
        'UcnewOffAirLogger1
        '
        Me.UcnewOffAirLogger1.BackColor = System.Drawing.Color.LightGray
        Me.UcnewOffAirLogger1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcnewOffAirLogger1.Location = New System.Drawing.Point(2, 4)
        Me.UcnewOffAirLogger1.Name = "UcnewOffAirLogger1"
        Me.UcnewOffAirLogger1.Size = New System.Drawing.Size(608, 428)
        Me.UcnewOffAirLogger1.TabIndex = 0
        '
        'ucOffAirLogger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(614, 436)
        Me.Controls.Add(Me.UcnewOffAirLogger1)
        Me.HideOnClose = True
        Me.Name = "ucOffAirLogger"
        Me.Text = "Off Air Logger"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrrecordedfileinfooal As System.Windows.Forms.Timer
    Friend WithEvents tmroal As System.Windows.Forms.Timer
    Friend WithEvents UcnewOffAirLogger1 As ucnewOffAirLogger
End Class
