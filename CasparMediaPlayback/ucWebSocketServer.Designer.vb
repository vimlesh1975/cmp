<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucWebSocketServer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdStartWebSocketServer = New System.Windows.Forms.Button()
        Me.txtwsport = New System.Windows.Forms.TextBox()
        Me.hiddenText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdOpenWebSocketClientPage = New System.Windows.Forms.Button()
        Me.chkSendtoCasparCG = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(445, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Status"
        '
        'cmdStartWebSocketServer
        '
        Me.cmdStartWebSocketServer.Location = New System.Drawing.Point(381, 19)
        Me.cmdStartWebSocketServer.Name = "cmdStartWebSocketServer"
        Me.cmdStartWebSocketServer.Size = New System.Drawing.Size(75, 23)
        Me.cmdStartWebSocketServer.TabIndex = 4
        Me.cmdStartWebSocketServer.Text = "Start"
        Me.cmdStartWebSocketServer.UseVisualStyleBackColor = True
        '
        'txtwsport
        '
        Me.txtwsport.Location = New System.Drawing.Point(196, 17)
        Me.txtwsport.Name = "txtwsport"
        Me.txtwsport.Size = New System.Drawing.Size(169, 20)
        Me.txtwsport.TabIndex = 5
        Me.txtwsport.Text = "http://localhost:8081"
        '
        'hiddenText
        '
        Me.hiddenText.Location = New System.Drawing.Point(19, 109)
        Me.hiddenText.Multiline = True
        Me.hiddenText.Name = "hiddenText"
        Me.hiddenText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.hiddenText.Size = New System.Drawing.Size(601, 189)
        Me.hiddenText.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 13)
        Me.Label2.TabIndex = 718
        Me.Label2.Text = "Web Socket Address (HttpListener)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 719
        Me.Label3.Text = "Received Message"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(445, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 13)
        Me.Label4.TabIndex = 721
        Me.Label4.Text = "Status of Wes Socket Server"
        '
        'cmdOpenWebSocketClientPage
        '
        Me.cmdOpenWebSocketClientPage.Location = New System.Drawing.Point(196, 57)
        Me.cmdOpenWebSocketClientPage.Name = "cmdOpenWebSocketClientPage"
        Me.cmdOpenWebSocketClientPage.Size = New System.Drawing.Size(204, 23)
        Me.cmdOpenWebSocketClientPage.TabIndex = 722
        Me.cmdOpenWebSocketClientPage.Text = "Open Web page having Wescoket client"
        Me.cmdOpenWebSocketClientPage.UseVisualStyleBackColor = True
        '
        'chkSendtoCasparCG
        '
        Me.chkSendtoCasparCG.AutoSize = True
        Me.chkSendtoCasparCG.Checked = True
        Me.chkSendtoCasparCG.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSendtoCasparCG.Location = New System.Drawing.Point(135, 86)
        Me.chkSendtoCasparCG.Name = "chkSendtoCasparCG"
        Me.chkSendtoCasparCG.Size = New System.Drawing.Size(114, 17)
        Me.chkSendtoCasparCG.TabIndex = 723
        Me.chkSendtoCasparCG.Text = "Send to CasparCG"
        Me.chkSendtoCasparCG.UseVisualStyleBackColor = True
        '
        'ucWebSocketServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(625, 304)
        Me.Controls.Add(Me.chkSendtoCasparCG)
        Me.Controls.Add(Me.cmdOpenWebSocketClientPage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.hiddenText)
        Me.Controls.Add(Me.txtwsport)
        Me.Controls.Add(Me.cmdStartWebSocketServer)
        Me.Controls.Add(Me.Label1)
        Me.HideOnClose = True
        Me.Name = "ucWebSocketServer"
        Me.Text = "Web Socket Server"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmdStartWebSocketServer As Button
    Friend WithEvents txtwsport As TextBox
    Friend WithEvents hiddenText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdOpenWebSocketClientPage As Button
    Friend WithEvents chkSendtoCasparCG As CheckBox
End Class
