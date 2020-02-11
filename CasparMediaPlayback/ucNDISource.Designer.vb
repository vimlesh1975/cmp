<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucNDISource
    Inherits System.Windows.Forms.UserControl

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
        Me.cmbNDI = New System.Windows.Forms.ComboBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbNDI
        '
        Me.cmbNDI.FormattingEnabled = True
        Me.cmbNDI.Location = New System.Drawing.Point(3, 56)
        Me.cmbNDI.Name = "cmbNDI"
        Me.cmbNDI.Size = New System.Drawing.Size(282, 21)
        Me.cmbNDI.TabIndex = 1225
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(36, 98)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(52, 23)
        Me.cmdOK.TabIndex = 1226
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(104, 98)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(52, 23)
        Me.cmdCancel.TabIndex = 1227
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'ucNDISource
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmbNDI)
        Me.Name = "ucNDISource"
        Me.Size = New System.Drawing.Size(329, 134)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbNDI As ComboBox
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdCancel As Button
End Class
