﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSilenceDetector
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkPlayToneinVLC = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkSwitchTo2ndInput = New System.Windows.Forms.CheckBox()
        Me.cmdOutputSource = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOutputSource = New System.Windows.Forms.TextBox()
        Me.cmdSecondSource = New System.Windows.Forms.Button()
        Me.cmdFirstSource = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSecondSource = New System.Windows.Forms.TextBox()
        Me.txtFirstSource = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkSendMail = New System.Windows.Forms.CheckBox()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.chkSilenceDetect = New System.Windows.Forms.CheckBox()
        Me.txtSilenceDuration = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tmrSilenceDetect = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.chkSilenceDetect)
        Me.GroupBox4.Controls.Add(Me.txtSilenceDuration)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(474, 604)
        Me.GroupBox4.TabIndex = 737
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Channel Silence Detect"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.chkPlayToneinVLC)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(457, 42)
        Me.GroupBox3.TabIndex = 748
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Play Color Bar Tone in VLC"
        '
        'chkPlayToneinVLC
        '
        Me.chkPlayToneinVLC.AutoSize = True
        Me.chkPlayToneinVLC.Location = New System.Drawing.Point(9, 19)
        Me.chkPlayToneinVLC.Name = "chkPlayToneinVLC"
        Me.chkPlayToneinVLC.Size = New System.Drawing.Size(222, 17)
        Me.chkPlayToneinVLC.TabIndex = 744
        Me.chkPlayToneinVLC.Text = "Play Color Bar Tone in VLC in Full Volume"
        Me.chkPlayToneinVLC.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.chkSwitchTo2ndInput)
        Me.GroupBox2.Controls.Add(Me.cmdOutputSource)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtOutputSource)
        Me.GroupBox2.Controls.Add(Me.cmdSecondSource)
        Me.GroupBox2.Controls.Add(Me.cmdFirstSource)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtSecondSource)
        Me.GroupBox2.Controls.Add(Me.txtFirstSource)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(460, 364)
        Me.GroupBox2.TabIndex = 747
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Switch to 2nd Input"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.caspar_media_playback.My.Resources.Resources.Untitled
        Me.PictureBox1.Location = New System.Drawing.Point(12, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(436, 209)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 749
        Me.PictureBox1.TabStop = False
        '
        'chkSwitchTo2ndInput
        '
        Me.chkSwitchTo2ndInput.AutoSize = True
        Me.chkSwitchTo2ndInput.Location = New System.Drawing.Point(9, 21)
        Me.chkSwitchTo2ndInput.Name = "chkSwitchTo2ndInput"
        Me.chkSwitchTo2ndInput.Size = New System.Drawing.Size(118, 17)
        Me.chkSwitchTo2ndInput.TabIndex = 738
        Me.chkSwitchTo2ndInput.Text = "Switch to 2nd Input"
        Me.chkSwitchTo2ndInput.UseVisualStyleBackColor = True
        '
        'cmdOutputSource
        '
        Me.cmdOutputSource.Location = New System.Drawing.Point(307, 330)
        Me.cmdOutputSource.Name = "cmdOutputSource"
        Me.cmdOutputSource.Size = New System.Drawing.Size(141, 23)
        Me.cmdOutputSource.TabIndex = 746
        Me.cmdOutputSource.Text = "Take Output by 3rd Card"
        Me.cmdOutputSource.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 745
        Me.Label3.Text = "Take Output"
        '
        'txtOutputSource
        '
        Me.txtOutputSource.Location = New System.Drawing.Point(96, 329)
        Me.txtOutputSource.Name = "txtOutputSource"
        Me.txtOutputSource.Size = New System.Drawing.Size(205, 20)
        Me.txtOutputSource.TabIndex = 744
        Me.txtOutputSource.Text = "add 1  decklink 3 embedded_audio"
        '
        'cmdSecondSource
        '
        Me.cmdSecondSource.Location = New System.Drawing.Point(307, 301)
        Me.cmdSecondSource.Name = "cmdSecondSource"
        Me.cmdSecondSource.Size = New System.Drawing.Size(141, 23)
        Me.cmdSecondSource.TabIndex = 743
        Me.cmdSecondSource.Text = "Play 2nd Source"
        Me.cmdSecondSource.UseVisualStyleBackColor = True
        '
        'cmdFirstSource
        '
        Me.cmdFirstSource.Location = New System.Drawing.Point(307, 272)
        Me.cmdFirstSource.Name = "cmdFirstSource"
        Me.cmdFirstSource.Size = New System.Drawing.Size(141, 23)
        Me.cmdFirstSource.TabIndex = 742
        Me.cmdFirstSource.Text = "Play 1st Source"
        Me.cmdFirstSource.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 741
        Me.Label2.Text = "Second Source"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 740
        Me.Label1.Text = "First Source"
        '
        'txtSecondSource
        '
        Me.txtSecondSource.Location = New System.Drawing.Point(96, 300)
        Me.txtSecondSource.Name = "txtSecondSource"
        Me.txtSecondSource.Size = New System.Drawing.Size(205, 20)
        Me.txtSecondSource.TabIndex = 739
        Me.txtSecondSource.Text = "play 1-1 decklink 2"
        '
        'txtFirstSource
        '
        Me.txtFirstSource.Location = New System.Drawing.Point(96, 274)
        Me.txtFirstSource.Name = "txtFirstSource"
        Me.txtFirstSource.Size = New System.Drawing.Size(205, 20)
        Me.txtFirstSource.TabIndex = 738
        Me.txtFirstSource.Text = "play 1-1 decklink 1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.chkSendMail)
        Me.GroupBox1.Controls.Add(Me.txtMessage)
        Me.GroupBox1.Controls.Add(Me.txtTo)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 122)
        Me.GroupBox1.TabIndex = 738
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Send mail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 743
        Me.Label5.Text = "Message"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 13)
        Me.Label6.TabIndex = 742
        Me.Label6.Text = "To"
        '
        'chkSendMail
        '
        Me.chkSendMail.AutoSize = True
        Me.chkSendMail.Location = New System.Drawing.Point(6, 19)
        Me.chkSendMail.Name = "chkSendMail"
        Me.chkSendMail.Size = New System.Drawing.Size(73, 17)
        Me.chkSendMail.TabIndex = 737
        Me.chkSendMail.Text = "Send Mail"
        Me.chkSendMail.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(76, 68)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(369, 49)
        Me.txtMessage.TabIndex = 735
        Me.txtMessage.Text = "Hi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "There is problem in Casparcg."
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(76, 42)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(369, 20)
        Me.txtTo.TabIndex = 734
        Me.txtTo.Text = "vimlesh1975@gmail.com"
        '
        'chkSilenceDetect
        '
        Me.chkSilenceDetect.AutoSize = True
        Me.chkSilenceDetect.Location = New System.Drawing.Point(18, 21)
        Me.chkSilenceDetect.Name = "chkSilenceDetect"
        Me.chkSilenceDetect.Size = New System.Drawing.Size(146, 17)
        Me.chkSilenceDetect.TabIndex = 323
        Me.chkSilenceDetect.Text = "Enabel Silence Detection"
        Me.chkSilenceDetect.UseVisualStyleBackColor = True
        '
        'txtSilenceDuration
        '
        Me.txtSilenceDuration.Location = New System.Drawing.Point(321, 22)
        Me.txtSilenceDuration.Name = "txtSilenceDuration"
        Me.txtSilenceDuration.Size = New System.Drawing.Size(38, 20)
        Me.txtSilenceDuration.TabIndex = 322
        Me.txtSilenceDuration.Text = "10"
        Me.txtSilenceDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(179, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 321
        Me.Label4.Text = "Silence Duration in Second"
        '
        'tmrSilenceDetect
        '
        Me.tmrSilenceDetect.Interval = 1000
        '
        'ucSilenceDetector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(480, 611)
        Me.Controls.Add(Me.GroupBox4)
        Me.HideOnClose = True
        Me.Name = "ucSilenceDetector"
        Me.Text = "Silence Detector"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chkSilenceDetect As CheckBox
    Friend WithEvents txtSilenceDuration As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tmrSilenceDetect As Timer
    Friend WithEvents chkSendMail As CheckBox
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents txtTo As TextBox
    Friend WithEvents cmdOutputSource As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOutputSource As TextBox
    Friend WithEvents cmdSecondSource As Button
    Friend WithEvents cmdFirstSource As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSecondSource As TextBox
    Friend WithEvents txtFirstSource As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkSwitchTo2ndInput As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkPlayToneinVLC As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
