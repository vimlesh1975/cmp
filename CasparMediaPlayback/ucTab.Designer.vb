<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucTab
    Inherits System.Windows.Forms.UserControl

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTab))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.UcChannelInfo1 = New caspar_media_playback.ucChannelInfo()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.UcSystemAudio1 = New caspar_media_playback.ucSystemAudio()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.UcPositionAndSize1 = New caspar_media_playback.ucPositionAndSize()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.UcPlaylistScheduler1 = New caspar_media_playback.UcPlaylistScheduler()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.UcLogo1 = New caspar_media_playback.ucLogo()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.UcUtility1 = New caspar_media_playback.ucUtility()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.UcCreatePng1 = New caspar_media_playback.ucCreatePng()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.UcAMCPcommands1 = New caspar_media_playback.ucAMCPcommands()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.UcSwfPlayer1 = New caspar_media_playback.ucSwfPlayer()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.UcPlaylistSetting1 = New caspar_media_playback.ucPlaylistSetting()
        Me.cmdhide = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage10)
        Me.TabControl1.Location = New System.Drawing.Point(2, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(681, 338)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.UcChannelInfo1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(673, 312)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Channel Info"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'UcChannelInfo1
        '
        Me.UcChannelInfo1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcChannelInfo1.Location = New System.Drawing.Point(6, 6)
        Me.UcChannelInfo1.Name = "UcChannelInfo1"
        Me.UcChannelInfo1.Size = New System.Drawing.Size(664, 300)
        Me.UcChannelInfo1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.UcSystemAudio1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(673, 312)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "System Audio"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'UcSystemAudio1
        '
        Me.UcSystemAudio1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcSystemAudio1.Location = New System.Drawing.Point(6, 6)
        Me.UcSystemAudio1.Name = "UcSystemAudio1"
        Me.UcSystemAudio1.Size = New System.Drawing.Size(137, 102)
        Me.UcSystemAudio1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.UcPositionAndSize1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(673, 312)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Position And Size"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'UcPositionAndSize1
        '
        Me.UcPositionAndSize1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcPositionAndSize1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcPositionAndSize1.Location = New System.Drawing.Point(5, 5)
        Me.UcPositionAndSize1.Name = "UcPositionAndSize1"
        Me.UcPositionAndSize1.Size = New System.Drawing.Size(153, 133)
        Me.UcPositionAndSize1.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.UcPlaylistScheduler1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(673, 312)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Playlist"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'UcPlaylistScheduler1
        '
        Me.UcPlaylistScheduler1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcPlaylistScheduler1.Location = New System.Drawing.Point(3, 3)
        Me.UcPlaylistScheduler1.Name = "UcPlaylistScheduler1"
        Me.UcPlaylistScheduler1.Size = New System.Drawing.Size(664, 307)
        Me.UcPlaylistScheduler1.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.UcLogo1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(673, 312)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Logo"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'UcLogo1
        '
        Me.UcLogo1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcLogo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcLogo1.Location = New System.Drawing.Point(6, 3)
        Me.UcLogo1.Name = "UcLogo1"
        Me.UcLogo1.Size = New System.Drawing.Size(656, 299)
        Me.UcLogo1.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.UcUtility1)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(673, 312)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Utility"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'UcUtility1
        '
        Me.UcUtility1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcUtility1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcUtility1.Location = New System.Drawing.Point(6, 6)
        Me.UcUtility1.Name = "UcUtility1"
        Me.UcUtility1.Size = New System.Drawing.Size(653, 247)
        Me.UcUtility1.TabIndex = 0
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.UcCreatePng1)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(673, 312)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Create PNG"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'UcCreatePng1
        '
        Me.UcCreatePng1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcCreatePng1.Location = New System.Drawing.Point(17, 24)
        Me.UcCreatePng1.Name = "UcCreatePng1"
        Me.UcCreatePng1.Size = New System.Drawing.Size(145, 85)
        Me.UcCreatePng1.TabIndex = 0
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.UcAMCPcommands1)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(673, 312)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "AMCP"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'UcAMCPcommands1
        '
        Me.UcAMCPcommands1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcAMCPcommands1.Location = New System.Drawing.Point(6, 6)
        Me.UcAMCPcommands1.Name = "UcAMCPcommands1"
        Me.UcAMCPcommands1.Size = New System.Drawing.Size(514, 283)
        Me.UcAMCPcommands1.TabIndex = 0
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.UcSwfPlayer1)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(673, 312)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "swf player"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'UcSwfPlayer1
        '
        Me.UcSwfPlayer1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcSwfPlayer1.Location = New System.Drawing.Point(3, 3)
        Me.UcSwfPlayer1.Name = "UcSwfPlayer1"
        Me.UcSwfPlayer1.Size = New System.Drawing.Size(332, 229)
        Me.UcSwfPlayer1.TabIndex = 0
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.UcPlaylistSetting1)
        Me.TabPage10.Location = New System.Drawing.Point(4, 22)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(673, 312)
        Me.TabPage10.TabIndex = 9
        Me.TabPage10.Text = "Playlist Setting"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'UcPlaylistSetting1
        '
        Me.UcPlaylistSetting1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcPlaylistSetting1.Location = New System.Drawing.Point(3, 4)
        Me.UcPlaylistSetting1.Name = "UcPlaylistSetting1"
        Me.UcPlaylistSetting1.Size = New System.Drawing.Size(624, 240)
        Me.UcPlaylistSetting1.TabIndex = 0
        '
        'cmdhide
        '
        Me.cmdhide.Image = CType(resources.GetObject("cmdhide.Image"), System.Drawing.Image)
        Me.cmdhide.Location = New System.Drawing.Point(656, -2)
        Me.cmdhide.Name = "cmdhide"
        Me.cmdhide.Size = New System.Drawing.Size(28, 27)
        Me.cmdhide.TabIndex = 1178
        Me.cmdhide.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Layer"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Producer/ Consumer"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "File Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'ucTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.cmdhide)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ucTab"
        Me.Size = New System.Drawing.Size(686, 344)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents UcChannelInfo1 As ucChannelInfo
    Friend WithEvents UcSystemAudio1 As ucSystemAudio
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents UcPlaylistScheduler1 As UcPlaylistScheduler
    Friend WithEvents cmdhide As Button
    Friend WithEvents UcPositionAndSize1 As ucPositionAndSize
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents UcLogo1 As ucLogo
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents UcUtility1 As ucUtility
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents UcCreatePng1 As ucCreatePng
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents UcSwfPlayer1 As ucSwfPlayer
    Friend WithEvents UcAMCPcommands1 As ucAMCPcommands
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents UcPlaylistSetting1 As ucPlaylistSetting
End Class
