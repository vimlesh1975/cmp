<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucUdpChat
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
        Me.gbudpchat = New System.Windows.Forms.GroupBox()
        Me.Label206 = New System.Windows.Forms.Label()
        Me.Label215 = New System.Windows.Forms.Label()
        Me.Label216 = New System.Windows.Forms.Label()
        Me.Label217 = New System.Windows.Forms.Label()
        Me.Label218 = New System.Windows.Forms.Label()
        Me.cmdstopreceive = New System.Windows.Forms.Button()
        Me.cmdInterchangeports = New System.Windows.Forms.Button()
        Me.txtudpportreceive = New System.Windows.Forms.TextBox()
        Me.txtudprereceive = New System.Windows.Forms.TextBox()
        Me.cmdudpreceive = New System.Windows.Forms.Button()
        Me.txtudpport = New System.Windows.Forms.TextBox()
        Me.txtudpip = New System.Windows.Forms.TextBox()
        Me.txtudpdata = New System.Windows.Forms.TextBox()
        Me.cmdudpsend = New System.Windows.Forms.Button()
        Me.gbudpchat.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbudpchat
        '
        Me.gbudpchat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbudpchat.Controls.Add(Me.Label206)
        Me.gbudpchat.Controls.Add(Me.Label215)
        Me.gbudpchat.Controls.Add(Me.Label216)
        Me.gbudpchat.Controls.Add(Me.Label217)
        Me.gbudpchat.Controls.Add(Me.Label218)
        Me.gbudpchat.Controls.Add(Me.cmdstopreceive)
        Me.gbudpchat.Controls.Add(Me.cmdInterchangeports)
        Me.gbudpchat.Controls.Add(Me.txtudpportreceive)
        Me.gbudpchat.Controls.Add(Me.txtudprereceive)
        Me.gbudpchat.Controls.Add(Me.cmdudpreceive)
        Me.gbudpchat.Controls.Add(Me.txtudpport)
        Me.gbudpchat.Controls.Add(Me.txtudpip)
        Me.gbudpchat.Controls.Add(Me.txtudpdata)
        Me.gbudpchat.Controls.Add(Me.cmdudpsend)
        Me.gbudpchat.Location = New System.Drawing.Point(3, 3)
        Me.gbudpchat.Name = "gbudpchat"
        Me.gbudpchat.Size = New System.Drawing.Size(450, 265)
        Me.gbudpchat.TabIndex = 1170
        Me.gbudpchat.TabStop = False
        Me.gbudpchat.Text = " "
        '
        'Label206
        '
        Me.Label206.AutoSize = True
        Me.Label206.Location = New System.Drawing.Point(193, 174)
        Me.Label206.Name = "Label206"
        Me.Label206.Size = New System.Drawing.Size(99, 13)
        Me.Label206.TabIndex = 23
        Me.Label206.Text = "Received Message"
        '
        'Label215
        '
        Me.Label215.AutoSize = True
        Me.Label215.Location = New System.Drawing.Point(111, 139)
        Me.Label215.Name = "Label215"
        Me.Label215.Size = New System.Drawing.Size(69, 13)
        Me.Label215.TabIndex = 22
        Me.Label215.Text = "Receive Port"
        '
        'Label216
        '
        Me.Label216.AutoSize = True
        Me.Label216.Location = New System.Drawing.Point(183, 21)
        Me.Label216.Name = "Label216"
        Me.Label216.Size = New System.Drawing.Size(50, 13)
        Me.Label216.TabIndex = 21
        Me.Label216.Text = "Message"
        '
        'Label217
        '
        Me.Label217.AutoSize = True
        Me.Label217.Location = New System.Drawing.Point(108, 22)
        Me.Label217.Name = "Label217"
        Me.Label217.Size = New System.Drawing.Size(66, 13)
        Me.Label217.TabIndex = 20
        Me.Label217.Text = "Remote Port"
        '
        'Label218
        '
        Me.Label218.AutoSize = True
        Me.Label218.Location = New System.Drawing.Point(6, 22)
        Me.Label218.Name = "Label218"
        Me.Label218.Size = New System.Drawing.Size(69, 13)
        Me.Label218.TabIndex = 19
        Me.Label218.Text = "Remote Host"
        '
        'cmdstopreceive
        '
        Me.cmdstopreceive.Enabled = False
        Me.cmdstopreceive.Location = New System.Drawing.Point(332, 230)
        Me.cmdstopreceive.Name = "cmdstopreceive"
        Me.cmdstopreceive.Size = New System.Drawing.Size(100, 23)
        Me.cmdstopreceive.TabIndex = 18
        Me.cmdstopreceive.Text = "Stop Receive"
        Me.cmdstopreceive.UseVisualStyleBackColor = True
        '
        'cmdInterchangeports
        '
        Me.cmdInterchangeports.Location = New System.Drawing.Point(86, 98)
        Me.cmdInterchangeports.Name = "cmdInterchangeports"
        Me.cmdInterchangeports.Size = New System.Drawing.Size(109, 38)
        Me.cmdInterchangeports.TabIndex = 17
        Me.cmdInterchangeports.Text = "Interchange ports"
        Me.cmdInterchangeports.UseVisualStyleBackColor = True
        '
        'txtudpportreceive
        '
        Me.txtudpportreceive.Location = New System.Drawing.Point(111, 157)
        Me.txtudpportreceive.Name = "txtudpportreceive"
        Me.txtudpportreceive.Size = New System.Drawing.Size(61, 20)
        Me.txtudpportreceive.TabIndex = 15
        Me.txtudpportreceive.Text = "12000"
        '
        'txtudprereceive
        '
        Me.txtudprereceive.Location = New System.Drawing.Point(186, 190)
        Me.txtudprereceive.Multiline = True
        Me.txtudprereceive.Name = "txtudprereceive"
        Me.txtudprereceive.Size = New System.Drawing.Size(140, 63)
        Me.txtudprereceive.TabIndex = 13
        '
        'cmdudpreceive
        '
        Me.cmdudpreceive.Location = New System.Drawing.Point(332, 201)
        Me.cmdudpreceive.Name = "cmdudpreceive"
        Me.cmdudpreceive.Size = New System.Drawing.Size(100, 23)
        Me.cmdudpreceive.TabIndex = 12
        Me.cmdudpreceive.Text = "Start Receive"
        Me.cmdudpreceive.UseVisualStyleBackColor = True
        '
        'txtudpport
        '
        Me.txtudpport.Location = New System.Drawing.Point(111, 38)
        Me.txtudpport.Name = "txtudpport"
        Me.txtudpport.Size = New System.Drawing.Size(61, 20)
        Me.txtudpport.TabIndex = 3
        Me.txtudpport.Text = "11000"
        '
        'txtudpip
        '
        Me.txtudpip.Location = New System.Drawing.Point(5, 38)
        Me.txtudpip.Name = "txtudpip"
        Me.txtudpip.Size = New System.Drawing.Size(100, 20)
        Me.txtudpip.TabIndex = 2
        Me.txtudpip.Text = "127.0.0.1"
        '
        'txtudpdata
        '
        Me.txtudpdata.Location = New System.Drawing.Point(186, 37)
        Me.txtudpdata.Multiline = True
        Me.txtudpdata.Name = "txtudpdata"
        Me.txtudpdata.Size = New System.Drawing.Size(147, 55)
        Me.txtudpdata.TabIndex = 1
        Me.txtudpdata.Text = "Vimlesh"
        '
        'cmdudpsend
        '
        Me.cmdudpsend.Location = New System.Drawing.Point(339, 34)
        Me.cmdudpsend.Name = "cmdudpsend"
        Me.cmdudpsend.Size = New System.Drawing.Size(75, 58)
        Me.cmdudpsend.TabIndex = 0
        Me.cmdudpsend.Text = "Send"
        Me.cmdudpsend.UseVisualStyleBackColor = True
        '
        'ucUdpChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1221, 749)
        Me.Controls.Add(Me.gbudpchat)
        Me.HideOnClose = True
        Me.Name = "ucUdpChat"
        Me.Text = "UDP Chat"
        Me.gbudpchat.ResumeLayout(False)
        Me.gbudpchat.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbudpchat As System.Windows.Forms.GroupBox
    Friend WithEvents Label206 As System.Windows.Forms.Label
    Friend WithEvents Label215 As System.Windows.Forms.Label
    Friend WithEvents Label216 As System.Windows.Forms.Label
    Friend WithEvents Label217 As System.Windows.Forms.Label
    Friend WithEvents Label218 As System.Windows.Forms.Label
    Friend WithEvents cmdstopreceive As System.Windows.Forms.Button
    Friend WithEvents cmdInterchangeports As System.Windows.Forms.Button
    Friend WithEvents txtudpportreceive As System.Windows.Forms.TextBox
    Friend WithEvents txtudprereceive As System.Windows.Forms.TextBox
    Friend WithEvents cmdudpreceive As System.Windows.Forms.Button
    Friend WithEvents txtudpport As System.Windows.Forms.TextBox
    Friend WithEvents txtudpip As System.Windows.Forms.TextBox
    Friend WithEvents txtudpdata As System.Windows.Forms.TextBox
    Friend WithEvents cmdudpsend As System.Windows.Forms.Button

End Class
