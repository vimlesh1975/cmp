<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _4ChannelConnector
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdStartCMP1 = New System.Windows.Forms.Button()
        Me.cmdoutChannel1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdinChannel1 = New System.Windows.Forms.Button()
        Me.txtChannel1 = New System.Windows.Forms.TextBox()
        Me.cmdResetCMP = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Bisque
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cmdResetCMP)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.cmdStartCMP1)
        Me.Panel1.Controls.Add(Me.cmdoutChannel1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmdinChannel1)
        Me.Panel1.Controls.Add(Me.txtChannel1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 32)
        Me.Panel1.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(378, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Fit Window"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdStartCMP1
        '
        Me.cmdStartCMP1.Location = New System.Drawing.Point(7, 4)
        Me.cmdStartCMP1.Name = "cmdStartCMP1"
        Me.cmdStartCMP1.Size = New System.Drawing.Size(75, 23)
        Me.cmdStartCMP1.TabIndex = 16
        Me.cmdStartCMP1.Text = "Start CMP"
        Me.cmdStartCMP1.UseVisualStyleBackColor = True
        '
        'cmdoutChannel1
        '
        Me.cmdoutChannel1.Location = New System.Drawing.Point(305, 4)
        Me.cmdoutChannel1.Name = "cmdoutChannel1"
        Me.cmdoutChannel1.Size = New System.Drawing.Size(67, 23)
        Me.cmdoutChannel1.TabIndex = 3
        Me.cmdoutChannel1.Text = "out"
        Me.cmdoutChannel1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Process Id of CMP"
        '
        'cmdinChannel1
        '
        Me.cmdinChannel1.Location = New System.Drawing.Point(241, 4)
        Me.cmdinChannel1.Name = "cmdinChannel1"
        Me.cmdinChannel1.Size = New System.Drawing.Size(58, 23)
        Me.cmdinChannel1.TabIndex = 1
        Me.cmdinChannel1.Text = "in"
        Me.cmdinChannel1.UseVisualStyleBackColor = True
        '
        'txtChannel1
        '
        Me.txtChannel1.AllowDrop = True
        Me.txtChannel1.Location = New System.Drawing.Point(194, 6)
        Me.txtChannel1.Name = "txtChannel1"
        Me.txtChannel1.Size = New System.Drawing.Size(41, 20)
        Me.txtChannel1.TabIndex = 2
        Me.txtChannel1.Text = "5000"
        '
        'cmdResetCMP
        '
        Me.cmdResetCMP.Location = New System.Drawing.Point(465, 3)
        Me.cmdResetCMP.Name = "cmdResetCMP"
        Me.cmdResetCMP.Size = New System.Drawing.Size(99, 23)
        Me.cmdResetCMP.TabIndex = 18
        Me.cmdResetCMP.Text = "Reset CMP Settings"
        Me.cmdResetCMP.UseVisualStyleBackColor = True
        '
        '_4ChannelConnector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "_4ChannelConnector"
        Me.Size = New System.Drawing.Size(593, 41)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub



    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdStartCMP1 As Button
    Friend WithEvents cmdoutChannel1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdinChannel1 As Button
    Friend WithEvents txtChannel1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdResetCMP As Button
End Class
