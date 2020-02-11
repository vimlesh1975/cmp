<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucPlaylistSetting
    Inherits System.Windows.Forms.UserControl
    'Inherits WeifenLuo.WinFormsUI.Docking.DockContent

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
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.txtanamorphic = New System.Windows.Forms.TextBox()
        Me.rdoanamorphic = New System.Windows.Forms.RadioButton()
        Me.txtpillarboxsettings = New System.Windows.Forms.TextBox()
        Me.txtcropsettings = New System.Windows.Forms.TextBox()
        Me.txtletterboxsettings = New System.Windows.Forms.TextBox()
        Me.txtcentercutsetting = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label246 = New System.Windows.Forms.Label()
        Me.rdocropsettings = New System.Windows.Forms.RadioButton()
        Me.rdopillarboxsettings = New System.Windows.Forms.RadioButton()
        Me.rdoletterboxsettings = New System.Windows.Forms.RadioButton()
        Me.rdocentercutsetting = New System.Windows.Forms.RadioButton()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmixercommandforconversion = New System.Windows.Forms.TextBox()
        Me.chkStayOnSelected = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdotemplatefromserver = New System.Windows.Forms.RadioButton()
        Me.rdotemplatefromfilesystem = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gbClipSearchMethod = New System.Windows.Forms.GroupBox()
        Me.rdoclipfromserver = New System.Windows.Forms.RadioButton()
        Me.rdoclipfromfilesystem = New System.Windows.Forms.RadioButton()
        Me.chkLoadbg = New System.Windows.Forms.CheckBox()
        Me.txtscrubbingtimerinterval = New System.Windows.Forms.TextBox()
        Me.Label225 = New System.Windows.Forms.Label()
        Me.chkSendFileNameWithoutExtension = New System.Windows.Forms.CheckBox()
        Me.ttPlayListSetting = New System.Windows.Forms.ToolTip(Me.components)
        Me.GbNewInstancesetting = New System.Windows.Forms.GroupBox()
        Me.SetChannel = New System.Windows.Forms.Button()
        Me.cmbchannelnewinstance = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBPlaylistCGSetting = New System.Windows.Forms.GroupBox()
        Me.txtBackinTimer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tmrSilenceDetect = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbClipSearchMethod.SuspendLayout()
        Me.GbNewInstancesetting.SuspendLayout()
        Me.GBPlaylistCGSetting.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.Goldenrod
        Me.GroupBox11.Controls.Add(Me.txtanamorphic)
        Me.GroupBox11.Controls.Add(Me.rdoanamorphic)
        Me.GroupBox11.Controls.Add(Me.txtpillarboxsettings)
        Me.GroupBox11.Controls.Add(Me.txtcropsettings)
        Me.GroupBox11.Controls.Add(Me.txtletterboxsettings)
        Me.GroupBox11.Controls.Add(Me.txtcentercutsetting)
        Me.GroupBox11.Controls.Add(Me.Label16)
        Me.GroupBox11.Controls.Add(Me.Label246)
        Me.GroupBox11.Controls.Add(Me.rdocropsettings)
        Me.GroupBox11.Controls.Add(Me.rdopillarboxsettings)
        Me.GroupBox11.Controls.Add(Me.rdoletterboxsettings)
        Me.GroupBox11.Controls.Add(Me.rdocentercutsetting)
        Me.GroupBox11.Location = New System.Drawing.Point(256, 3)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(212, 168)
        Me.GroupBox11.TabIndex = 715
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Conversion Setting"
        '
        'txtanamorphic
        '
        Me.txtanamorphic.Location = New System.Drawing.Point(6, 142)
        Me.txtanamorphic.Name = "txtanamorphic"
        Me.txtanamorphic.Size = New System.Drawing.Size(100, 20)
        Me.txtanamorphic.TabIndex = 11
        Me.txtanamorphic.Text = "0 0 1 1"
        '
        'rdoanamorphic
        '
        Me.rdoanamorphic.AutoSize = True
        Me.rdoanamorphic.Location = New System.Drawing.Point(112, 142)
        Me.rdoanamorphic.Name = "rdoanamorphic"
        Me.rdoanamorphic.Size = New System.Drawing.Size(81, 17)
        Me.rdoanamorphic.TabIndex = 10
        Me.rdoanamorphic.TabStop = True
        Me.rdoanamorphic.Text = "Anamorphic"
        Me.rdoanamorphic.UseVisualStyleBackColor = True
        '
        'txtpillarboxsettings
        '
        Me.txtpillarboxsettings.Location = New System.Drawing.Point(6, 115)
        Me.txtpillarboxsettings.Name = "txtpillarboxsettings"
        Me.txtpillarboxsettings.Size = New System.Drawing.Size(100, 20)
        Me.txtpillarboxsettings.TabIndex = 9
        Me.txtpillarboxsettings.Text = "0.12 0.0 0.76 1.0"
        '
        'txtcropsettings
        '
        Me.txtcropsettings.Location = New System.Drawing.Point(6, 92)
        Me.txtcropsettings.Name = "txtcropsettings"
        Me.txtcropsettings.Size = New System.Drawing.Size(100, 20)
        Me.txtcropsettings.TabIndex = 8
        Me.txtcropsettings.Text = "0.0 -0.12 1.0 1.24"
        '
        'txtletterboxsettings
        '
        Me.txtletterboxsettings.Location = New System.Drawing.Point(8, 51)
        Me.txtletterboxsettings.Name = "txtletterboxsettings"
        Me.txtletterboxsettings.Size = New System.Drawing.Size(100, 20)
        Me.txtletterboxsettings.TabIndex = 7
        Me.txtletterboxsettings.Text = "0.0 0.12 1.0 0.76"
        '
        'txtcentercutsetting
        '
        Me.txtcentercutsetting.Location = New System.Drawing.Point(8, 28)
        Me.txtcentercutsetting.Name = "txtcentercutsetting"
        Me.txtcentercutsetting.Size = New System.Drawing.Size(100, 20)
        Me.txtcentercutsetting.TabIndex = 6
        Me.txtcentercutsetting.Text = "-0.17 0.0 1.34 1.0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "For HD Channel"
        '
        'Label246
        '
        Me.Label246.AutoSize = True
        Me.Label246.Location = New System.Drawing.Point(5, 13)
        Me.Label246.Name = "Label246"
        Me.Label246.Size = New System.Drawing.Size(82, 13)
        Me.Label246.TabIndex = 4
        Me.Label246.Text = "For SD Channel"
        '
        'rdocropsettings
        '
        Me.rdocropsettings.AutoSize = True
        Me.rdocropsettings.Location = New System.Drawing.Point(112, 95)
        Me.rdocropsettings.Name = "rdocropsettings"
        Me.rdocropsettings.Size = New System.Drawing.Size(47, 17)
        Me.rdocropsettings.TabIndex = 3
        Me.rdocropsettings.TabStop = True
        Me.rdocropsettings.Text = "Crop"
        Me.rdocropsettings.UseVisualStyleBackColor = True
        '
        'rdopillarboxsettings
        '
        Me.rdopillarboxsettings.AutoSize = True
        Me.rdopillarboxsettings.Location = New System.Drawing.Point(112, 115)
        Me.rdopillarboxsettings.Name = "rdopillarboxsettings"
        Me.rdopillarboxsettings.Size = New System.Drawing.Size(68, 17)
        Me.rdopillarboxsettings.TabIndex = 2
        Me.rdopillarboxsettings.TabStop = True
        Me.rdopillarboxsettings.Text = "Pillar Box"
        Me.rdopillarboxsettings.UseVisualStyleBackColor = True
        '
        'rdoletterboxsettings
        '
        Me.rdoletterboxsettings.AutoSize = True
        Me.rdoletterboxsettings.Location = New System.Drawing.Point(111, 49)
        Me.rdoletterboxsettings.Name = "rdoletterboxsettings"
        Me.rdoletterboxsettings.Size = New System.Drawing.Size(69, 17)
        Me.rdoletterboxsettings.TabIndex = 1
        Me.rdoletterboxsettings.TabStop = True
        Me.rdoletterboxsettings.Text = "Letterbox"
        Me.rdoletterboxsettings.UseVisualStyleBackColor = True
        '
        'rdocentercutsetting
        '
        Me.rdocentercutsetting.AutoSize = True
        Me.rdocentercutsetting.Checked = True
        Me.rdocentercutsetting.Location = New System.Drawing.Point(112, 30)
        Me.rdocentercutsetting.Name = "rdocentercutsetting"
        Me.rdocentercutsetting.Size = New System.Drawing.Size(102, 17)
        Me.rdocentercutsetting.TabIndex = 0
        Me.rdocentercutsetting.TabStop = True
        Me.rdocentercutsetting.Text = "Crop (Centercut)"
        Me.rdocentercutsetting.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.LightCoral
        Me.GroupBox12.Controls.Add(Me.Label5)
        Me.GroupBox12.Controls.Add(Me.txtmixercommandforconversion)
        Me.GroupBox12.Controls.Add(Me.chkStayOnSelected)
        Me.GroupBox12.Controls.Add(Me.GroupBox3)
        Me.GroupBox12.Controls.Add(Me.GroupBox2)
        Me.GroupBox12.Controls.Add(Me.chkLoadbg)
        Me.GroupBox12.Controls.Add(Me.txtscrubbingtimerinterval)
        Me.GroupBox12.Controls.Add(Me.Label225)
        Me.GroupBox12.Controls.Add(Me.chkSendFileNameWithoutExtension)
        Me.GroupBox12.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(240, 233)
        Me.GroupBox12.TabIndex = 731
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Playlist Settings"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 201)
        Me.Label5.MaximumSize = New System.Drawing.Size(150, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 26)
        Me.Label5.TabIndex = 1185
        Me.Label5.Text = "Delay in mixer command for conversion (ms)"
        '
        'txtmixercommandforconversion
        '
        Me.txtmixercommandforconversion.Location = New System.Drawing.Point(161, 206)
        Me.txtmixercommandforconversion.Name = "txtmixercommandforconversion"
        Me.txtmixercommandforconversion.Size = New System.Drawing.Size(40, 20)
        Me.txtmixercommandforconversion.TabIndex = 1184
        Me.txtmixercommandforconversion.Text = "400"
        Me.txtmixercommandforconversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkStayOnSelected
        '
        Me.chkStayOnSelected.AutoSize = True
        Me.chkStayOnSelected.Checked = True
        Me.chkStayOnSelected.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkStayOnSelected.Location = New System.Drawing.Point(11, 178)
        Me.chkStayOnSelected.Name = "chkStayOnSelected"
        Me.chkStayOnSelected.Size = New System.Drawing.Size(127, 17)
        Me.chkStayOnSelected.TabIndex = 1183
        Me.chkStayOnSelected.Text = "Stay on Selected Clip"
        Me.chkStayOnSelected.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdotemplatefromserver)
        Me.GroupBox3.Controls.Add(Me.rdotemplatefromfilesystem)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 134)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(217, 41)
        Me.GroupBox3.TabIndex = 1182
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Template Search Method"
        '
        'rdotemplatefromserver
        '
        Me.rdotemplatefromserver.AutoSize = True
        Me.rdotemplatefromserver.Location = New System.Drawing.Point(114, 18)
        Me.rdotemplatefromserver.Name = "rdotemplatefromserver"
        Me.rdotemplatefromserver.Size = New System.Drawing.Size(56, 17)
        Me.rdotemplatefromserver.TabIndex = 1
        Me.rdotemplatefromserver.Text = "Server"
        Me.rdotemplatefromserver.UseVisualStyleBackColor = True
        '
        'rdotemplatefromfilesystem
        '
        Me.rdotemplatefromfilesystem.AutoSize = True
        Me.rdotemplatefromfilesystem.Checked = True
        Me.rdotemplatefromfilesystem.Location = New System.Drawing.Point(18, 18)
        Me.rdotemplatefromfilesystem.Name = "rdotemplatefromfilesystem"
        Me.rdotemplatefromfilesystem.Size = New System.Drawing.Size(78, 17)
        Me.rdotemplatefromfilesystem.TabIndex = 0
        Me.rdotemplatefromfilesystem.TabStop = True
        Me.rdotemplatefromfilesystem.Text = "File System"
        Me.rdotemplatefromfilesystem.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gbClipSearchMethod)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(217, 60)
        Me.GroupBox2.TabIndex = 1181
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " "
        '
        'gbClipSearchMethod
        '
        Me.gbClipSearchMethod.Controls.Add(Me.rdoclipfromserver)
        Me.gbClipSearchMethod.Controls.Add(Me.rdoclipfromfilesystem)
        Me.gbClipSearchMethod.Location = New System.Drawing.Point(16, 14)
        Me.gbClipSearchMethod.Name = "gbClipSearchMethod"
        Me.gbClipSearchMethod.Size = New System.Drawing.Size(169, 35)
        Me.gbClipSearchMethod.TabIndex = 1177
        Me.gbClipSearchMethod.TabStop = False
        Me.gbClipSearchMethod.Text = "Clip Serach Method"
        '
        'rdoclipfromserver
        '
        Me.rdoclipfromserver.AutoSize = True
        Me.rdoclipfromserver.Location = New System.Drawing.Point(87, 13)
        Me.rdoclipfromserver.Name = "rdoclipfromserver"
        Me.rdoclipfromserver.Size = New System.Drawing.Size(56, 17)
        Me.rdoclipfromserver.TabIndex = 1176
        Me.rdoclipfromserver.Text = "Server"
        Me.ttPlayListSetting.SetToolTip(Me.rdoclipfromserver, "use this when server is remote and no symlinked folder")
        Me.rdoclipfromserver.UseVisualStyleBackColor = True
        '
        'rdoclipfromfilesystem
        '
        Me.rdoclipfromfilesystem.AutoSize = True
        Me.rdoclipfromfilesystem.Checked = True
        Me.rdoclipfromfilesystem.Location = New System.Drawing.Point(6, 14)
        Me.rdoclipfromfilesystem.Name = "rdoclipfromfilesystem"
        Me.rdoclipfromfilesystem.Size = New System.Drawing.Size(78, 17)
        Me.rdoclipfromfilesystem.TabIndex = 1175
        Me.rdoclipfromfilesystem.TabStop = True
        Me.rdoclipfromfilesystem.Text = "File System"
        Me.ttPlayListSetting.SetToolTip(Me.rdoclipfromfilesystem, "Use this when server is lical")
        Me.rdoclipfromfilesystem.UseVisualStyleBackColor = True
        '
        'chkLoadbg
        '
        Me.chkLoadbg.AutoSize = True
        Me.chkLoadbg.Checked = True
        Me.chkLoadbg.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLoadbg.Location = New System.Drawing.Point(6, 31)
        Me.chkLoadbg.Name = "chkLoadbg"
        Me.chkLoadbg.Size = New System.Drawing.Size(90, 17)
        Me.chkLoadbg.TabIndex = 734
        Me.chkLoadbg.Text = "Send Loadbg"
        Me.chkLoadbg.UseVisualStyleBackColor = True
        '
        'txtscrubbingtimerinterval
        '
        Me.txtscrubbingtimerinterval.Location = New System.Drawing.Point(145, 46)
        Me.txtscrubbingtimerinterval.Name = "txtscrubbingtimerinterval"
        Me.txtscrubbingtimerinterval.Size = New System.Drawing.Size(32, 20)
        Me.txtscrubbingtimerinterval.TabIndex = 733
        Me.txtscrubbingtimerinterval.Text = "100"
        '
        'Label225
        '
        Me.Label225.AutoSize = True
        Me.Label225.Location = New System.Drawing.Point(5, 50)
        Me.Label225.Name = "Label225"
        Me.Label225.Size = New System.Drawing.Size(137, 13)
        Me.Label225.TabIndex = 732
        Me.Label225.Text = "Scrubbing Timer interval ms"
        '
        'chkSendFileNameWithoutExtension
        '
        Me.chkSendFileNameWithoutExtension.AutoSize = True
        Me.chkSendFileNameWithoutExtension.Checked = True
        Me.chkSendFileNameWithoutExtension.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSendFileNameWithoutExtension.Location = New System.Drawing.Point(6, 14)
        Me.chkSendFileNameWithoutExtension.Name = "chkSendFileNameWithoutExtension"
        Me.chkSendFileNameWithoutExtension.Size = New System.Drawing.Size(181, 17)
        Me.chkSendFileNameWithoutExtension.TabIndex = 729
        Me.chkSendFileNameWithoutExtension.Text = "Send FileNme Without Extension"
        Me.chkSendFileNameWithoutExtension.UseVisualStyleBackColor = True
        '
        'GbNewInstancesetting
        '
        Me.GbNewInstancesetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GbNewInstancesetting.Controls.Add(Me.SetChannel)
        Me.GbNewInstancesetting.Controls.Add(Me.cmbchannelnewinstance)
        Me.GbNewInstancesetting.Controls.Add(Me.Label2)
        Me.GbNewInstancesetting.Location = New System.Drawing.Point(477, 8)
        Me.GbNewInstancesetting.Name = "GbNewInstancesetting"
        Me.GbNewInstancesetting.Size = New System.Drawing.Size(139, 71)
        Me.GbNewInstancesetting.TabIndex = 734
        Me.GbNewInstancesetting.TabStop = False
        Me.GbNewInstancesetting.Text = "New Instance setting"
        '
        'SetChannel
        '
        Me.SetChannel.Location = New System.Drawing.Point(42, 36)
        Me.SetChannel.Name = "SetChannel"
        Me.SetChannel.Size = New System.Drawing.Size(75, 23)
        Me.SetChannel.TabIndex = 320
        Me.SetChannel.Text = "Set Channel"
        Me.SetChannel.UseVisualStyleBackColor = True
        '
        'cmbchannelnewinstance
        '
        Me.cmbchannelnewinstance.FormattingEnabled = True
        Me.cmbchannelnewinstance.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cmbchannelnewinstance.Location = New System.Drawing.Point(6, 36)
        Me.cmbchannelnewinstance.Name = "cmbchannelnewinstance"
        Me.cmbchannelnewinstance.Size = New System.Drawing.Size(30, 21)
        Me.cmbchannelnewinstance.TabIndex = 319
        Me.cmbchannelnewinstance.Text = "2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Configure for Channel"
        '
        'GBPlaylistCGSetting
        '
        Me.GBPlaylistCGSetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GBPlaylistCGSetting.Controls.Add(Me.txtBackinTimer)
        Me.GBPlaylistCGSetting.Controls.Add(Me.Label3)
        Me.GBPlaylistCGSetting.Location = New System.Drawing.Point(476, 89)
        Me.GBPlaylistCGSetting.Name = "GBPlaylistCGSetting"
        Me.GBPlaylistCGSetting.Size = New System.Drawing.Size(141, 81)
        Me.GBPlaylistCGSetting.TabIndex = 735
        Me.GBPlaylistCGSetting.TabStop = False
        Me.GBPlaylistCGSetting.Text = "Playlist CG Setting"
        '
        'txtBackinTimer
        '
        Me.txtBackinTimer.Location = New System.Drawing.Point(12, 53)
        Me.txtBackinTimer.Name = "txtBackinTimer"
        Me.txtBackinTimer.Size = New System.Drawing.Size(47, 20)
        Me.txtBackinTimer.TabIndex = 322
        Me.txtBackinTimer.Text = "8"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 24)
        Me.Label3.MaximumSize = New System.Drawing.Size(140, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 26)
        Me.Label3.TabIndex = 321
        Me.Label3.Text = "Back In Timer Duration in Second"
        '
        'tmrSilenceDetect
        '
        Me.tmrSilenceDetect.Interval = 1000
        '
        'ucPlaylistSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(624, 240)
        Me.Controls.Add(Me.GBPlaylistCGSetting)
        Me.Controls.Add(Me.GbNewInstancesetting)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.GroupBox11)
        'Me.HideOnClose = True
        Me.Name = "ucPlaylistSetting"
        Me.Text = "Play List Setting"
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbClipSearchMethod.ResumeLayout(False)
        Me.gbClipSearchMethod.PerformLayout()
        Me.GbNewInstancesetting.ResumeLayout(False)
        Me.GbNewInstancesetting.PerformLayout()
        Me.GBPlaylistCGSetting.ResumeLayout(False)
        Me.GBPlaylistCGSetting.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpillarboxsettings As System.Windows.Forms.TextBox
    Friend WithEvents txtcropsettings As System.Windows.Forms.TextBox
    Friend WithEvents txtletterboxsettings As System.Windows.Forms.TextBox
    Friend WithEvents txtcentercutsetting As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label246 As System.Windows.Forms.Label
    Friend WithEvents rdocropsettings As System.Windows.Forms.RadioButton
    Friend WithEvents rdopillarboxsettings As System.Windows.Forms.RadioButton
    Friend WithEvents rdoletterboxsettings As System.Windows.Forms.RadioButton
    Friend WithEvents rdocentercutsetting As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents gbClipSearchMethod As System.Windows.Forms.GroupBox
    Friend WithEvents rdoclipfromserver As System.Windows.Forms.RadioButton
    Friend WithEvents rdoclipfromfilesystem As System.Windows.Forms.RadioButton
    Friend WithEvents chkLoadbg As System.Windows.Forms.CheckBox
    Friend WithEvents txtscrubbingtimerinterval As System.Windows.Forms.TextBox
    Friend WithEvents Label225 As System.Windows.Forms.Label
    Friend WithEvents chkSendFileNameWithoutExtension As System.Windows.Forms.CheckBox
    Friend WithEvents ttPlayListSetting As System.Windows.Forms.ToolTip
    Friend WithEvents txtanamorphic As System.Windows.Forms.TextBox
    Friend WithEvents rdoanamorphic As System.Windows.Forms.RadioButton
    Friend WithEvents GbNewInstancesetting As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbchannelnewinstance As System.Windows.Forms.ComboBox
    Friend WithEvents SetChannel As System.Windows.Forms.Button
    Friend WithEvents GBPlaylistCGSetting As GroupBox
    Friend WithEvents txtBackinTimer As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rdotemplatefromserver As RadioButton
    Friend WithEvents rdotemplatefromfilesystem As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkStayOnSelected As CheckBox
    Friend WithEvents tmrSilenceDetect As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents txtmixercommandforconversion As TextBox
End Class
