<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmROI
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
        Me.cmdSetROI = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdSetROI
        '
        Me.cmdSetROI.Location = New System.Drawing.Point(2, 4)
        Me.cmdSetROI.Name = "cmdSetROI"
        Me.cmdSetROI.Size = New System.Drawing.Size(103, 23)
        Me.cmdSetROI.TabIndex = 1
        Me.cmdSetROI.Text = "Set and Close"
        Me.cmdSetROI.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-3, 30)
        Me.Label1.MaximumSize = New System.Drawing.Size(300, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 100)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Resize This form and locate to the area we need to Show. Then Click ""Set and Clos" &
    "e"" Button"
        '
        'frmROI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(328, 219)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSetROI)
        Me.Name = "frmROI"
        Me.Text = "Select Region Of Interest"
        Me.TransparencyKey = System.Drawing.Color.DarkGray
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSetROI As Button
    Friend WithEvents Label1 As Label
End Class
