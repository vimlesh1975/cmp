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
        Me.ChannelInfo = New System.Windows.Forms.TabPage()
        Me.UcChannelInfo1 = New caspar_media_playback.ucChannelInfo()
        Me.ScreenConsumer = New System.Windows.Forms.TabPage()
        Me.UcScreenConsumer1 = New caspar_media_playback.ucScreenConsumer()
        Me.Playlist = New System.Windows.Forms.TabPage()
        Me.UcPlaylistScheduler1 = New caspar_media_playback.UcPlaylistScheduler()
        Me.Utility = New System.Windows.Forms.TabPage()
        Me.UcUtility1 = New caspar_media_playback.ucUtility()
        Me.AMCP = New System.Windows.Forms.TabPage()
        Me.UcAMCPcommands1 = New caspar_media_playback.ucAMCPcommands()
        Me.SwfPlayer = New System.Windows.Forms.TabPage()
        Me.UcSwfPlayer1 = New caspar_media_playback.ucSwfPlayer()
        Me.PlaylistSetting = New System.Windows.Forms.TabPage()
        Me.UcPlaylistSetting1 = New caspar_media_playback.ucPlaylistSetting()
        Me.Logo = New System.Windows.Forms.TabPage()
        Me.UcLogo1 = New caspar_media_playback.ucLogo()
        Me.SystemAudioPNGPositionAndSize = New System.Windows.Forms.TabPage()
        Me.UcPositionAndSize1 = New caspar_media_playback.ucPositionAndSize()
        Me.UcCreatePng1 = New caspar_media_playback.ucCreatePng()
        Me.UcSystemAudio1 = New caspar_media_playback.ucSystemAudio()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdhide = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.ChannelInfo.SuspendLayout()
        Me.ScreenConsumer.SuspendLayout()
        Me.Playlist.SuspendLayout()
        Me.Utility.SuspendLayout()
        Me.AMCP.SuspendLayout()
        Me.SwfPlayer.SuspendLayout()
        Me.PlaylistSetting.SuspendLayout()
        Me.Logo.SuspendLayout()
        Me.SystemAudioPNGPositionAndSize.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Utility)
        Me.TabControl1.Controls.Add(Me.ChannelInfo)
        Me.TabControl1.Controls.Add(Me.ScreenConsumer)
        Me.TabControl1.Controls.Add(Me.Playlist)
        Me.TabControl1.Controls.Add(Me.AMCP)
        Me.TabControl1.Controls.Add(Me.SwfPlayer)
        Me.TabControl1.Controls.Add(Me.PlaylistSetting)
        Me.TabControl1.Controls.Add(Me.Logo)
        Me.TabControl1.Controls.Add(Me.SystemAudioPNGPositionAndSize)
        Me.TabControl1.Location = New System.Drawing.Point(2, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(681, 338)
        Me.TabControl1.TabIndex = 0
        '
        'ChannelInfo
        '
        Me.ChannelInfo.Controls.Add(Me.UcChannelInfo1)
        Me.ChannelInfo.Location = New System.Drawing.Point(4, 22)
        Me.ChannelInfo.Name = "ChannelInfo"
        Me.ChannelInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.ChannelInfo.Size = New System.Drawing.Size(673, 312)
        Me.ChannelInfo.TabIndex = 0
        Me.ChannelInfo.Text = "Channel Info"
        Me.ChannelInfo.UseVisualStyleBackColor = True
        '
        'UcChannelInfo1
        '
        Me.UcChannelInfo1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcChannelInfo1.Location = New System.Drawing.Point(6, 6)
        Me.UcChannelInfo1.Name = "UcChannelInfo1"
        Me.UcChannelInfo1.Size = New System.Drawing.Size(664, 300)
        Me.UcChannelInfo1.TabIndex = 0
        '
        'ScreenConsumer
        '
        Me.ScreenConsumer.Controls.Add(Me.UcScreenConsumer1)
        Me.ScreenConsumer.Location = New System.Drawing.Point(4, 22)
        Me.ScreenConsumer.Name = "ScreenConsumer"
        Me.ScreenConsumer.Padding = New System.Windows.Forms.Padding(3)
        Me.ScreenConsumer.Size = New System.Drawing.Size(673, 312)
        Me.ScreenConsumer.TabIndex = 10
        Me.ScreenConsumer.Text = "Screen Consumer"
        Me.ScreenConsumer.UseVisualStyleBackColor = True
        '
        'UcScreenConsumer1
        '
        Me.UcScreenConsumer1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UcScreenConsumer1.Location = New System.Drawing.Point(6, 6)
        Me.UcScreenConsumer1.Name = "UcScreenConsumer1"
        Me.UcScreenConsumer1.Size = New System.Drawing.Size(663, 306)
        Me.UcScreenConsumer1.TabIndex = 0
        '
        'Playlist
        '
        Me.Playlist.Controls.Add(Me.UcPlaylistScheduler1)
        Me.Playlist.Location = New System.Drawing.Point(4, 22)
        Me.Playlist.Name = "Playlist"
        Me.Playlist.Padding = New System.Windows.Forms.Padding(3)
        Me.Playlist.Size = New System.Drawing.Size(673, 312)
        Me.Playlist.TabIndex = 3
        Me.Playlist.Text = "Playlist"
        Me.Playlist.UseVisualStyleBackColor = True
        '
        'UcPlaylistScheduler1
        '
        Me.UcPlaylistScheduler1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcPlaylistScheduler1.Location = New System.Drawing.Point(3, 3)
        Me.UcPlaylistScheduler1.Name = "UcPlaylistScheduler1"
        Me.UcPlaylistScheduler1.Size = New System.Drawing.Size(664, 307)
        Me.UcPlaylistScheduler1.TabIndex = 0
        '
        'Utility
        '
        Me.Utility.Controls.Add(Me.UcUtility1)
        Me.Utility.Location = New System.Drawing.Point(4, 22)
        Me.Utility.Name = "Utility"
        Me.Utility.Padding = New System.Windows.Forms.Padding(3)
        Me.Utility.Size = New System.Drawing.Size(673, 312)
        Me.Utility.TabIndex = 5
        Me.Utility.Text = "Utility"
        Me.Utility.UseVisualStyleBackColor = True
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
        'AMCP
        '
        Me.AMCP.Controls.Add(Me.UcAMCPcommands1)
        Me.AMCP.Location = New System.Drawing.Point(4, 22)
        Me.AMCP.Name = "AMCP"
        Me.AMCP.Padding = New System.Windows.Forms.Padding(3)
        Me.AMCP.Size = New System.Drawing.Size(673, 312)
        Me.AMCP.TabIndex = 7
        Me.AMCP.Text = "AMCP"
        Me.AMCP.UseVisualStyleBackColor = True
        '
        'UcAMCPcommands1
        '
        Me.UcAMCPcommands1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcAMCPcommands1.Location = New System.Drawing.Point(6, 6)
        Me.UcAMCPcommands1.Name = "UcAMCPcommands1"
        Me.UcAMCPcommands1.Size = New System.Drawing.Size(514, 283)
        Me.UcAMCPcommands1.TabIndex = 0
        '
        'SwfPlayer
        '
        Me.SwfPlayer.Controls.Add(Me.UcSwfPlayer1)
        Me.SwfPlayer.Location = New System.Drawing.Point(4, 22)
        Me.SwfPlayer.Name = "SwfPlayer"
        Me.SwfPlayer.Size = New System.Drawing.Size(673, 312)
        Me.SwfPlayer.TabIndex = 8
        Me.SwfPlayer.Text = "swf player"
        Me.SwfPlayer.UseVisualStyleBackColor = True
        '
        'UcSwfPlayer1
        '
        Me.UcSwfPlayer1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcSwfPlayer1.Location = New System.Drawing.Point(3, 3)
        Me.UcSwfPlayer1.Name = "UcSwfPlayer1"
        Me.UcSwfPlayer1.Size = New System.Drawing.Size(332, 229)
        Me.UcSwfPlayer1.TabIndex = 0
        '
        'PlaylistSetting
        '
        Me.PlaylistSetting.Controls.Add(Me.UcPlaylistSetting1)
        Me.PlaylistSetting.Location = New System.Drawing.Point(4, 22)
        Me.PlaylistSetting.Name = "PlaylistSetting"
        Me.PlaylistSetting.Size = New System.Drawing.Size(673, 312)
        Me.PlaylistSetting.TabIndex = 9
        Me.PlaylistSetting.Text = "Playlist Setting"
        Me.PlaylistSetting.UseVisualStyleBackColor = True
        '
        'UcPlaylistSetting1
        '
        Me.UcPlaylistSetting1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcPlaylistSetting1.Location = New System.Drawing.Point(3, 4)
        Me.UcPlaylistSetting1.Name = "UcPlaylistSetting1"
        Me.UcPlaylistSetting1.Size = New System.Drawing.Size(624, 240)
        Me.UcPlaylistSetting1.TabIndex = 0
        '
        'Logo
        '
        Me.Logo.Controls.Add(Me.UcLogo1)
        Me.Logo.Location = New System.Drawing.Point(4, 22)
        Me.Logo.Name = "Logo"
        Me.Logo.Padding = New System.Windows.Forms.Padding(3)
        Me.Logo.Size = New System.Drawing.Size(673, 312)
        Me.Logo.TabIndex = 4
        Me.Logo.Text = "Logo"
        Me.Logo.UseVisualStyleBackColor = True
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
        'SystemAudioPNGPositionAndSize
        '
        Me.SystemAudioPNGPositionAndSize.Controls.Add(Me.UcPositionAndSize1)
        Me.SystemAudioPNGPositionAndSize.Controls.Add(Me.UcCreatePng1)
        Me.SystemAudioPNGPositionAndSize.Controls.Add(Me.UcSystemAudio1)
        Me.SystemAudioPNGPositionAndSize.Location = New System.Drawing.Point(4, 22)
        Me.SystemAudioPNGPositionAndSize.Name = "SystemAudioPNGPositionAndSize"
        Me.SystemAudioPNGPositionAndSize.Padding = New System.Windows.Forms.Padding(3)
        Me.SystemAudioPNGPositionAndSize.Size = New System.Drawing.Size(673, 312)
        Me.SystemAudioPNGPositionAndSize.TabIndex = 1
        Me.SystemAudioPNGPositionAndSize.Text = "Audio, PNG, Position And Size"
        Me.SystemAudioPNGPositionAndSize.UseVisualStyleBackColor = True
        '
        'UcPositionAndSize1
        '
        Me.UcPositionAndSize1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcPositionAndSize1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcPositionAndSize1.Location = New System.Drawing.Point(439, 22)
        Me.UcPositionAndSize1.Name = "UcPositionAndSize1"
        Me.UcPositionAndSize1.Size = New System.Drawing.Size(153, 133)
        Me.UcPositionAndSize1.TabIndex = 2
        '
        'UcCreatePng1
        '
        Me.UcCreatePng1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcCreatePng1.Location = New System.Drawing.Point(227, 22)
        Me.UcCreatePng1.Name = "UcCreatePng1"
        Me.UcCreatePng1.Size = New System.Drawing.Size(145, 85)
        Me.UcCreatePng1.TabIndex = 1
        '
        'UcSystemAudio1
        '
        Me.UcSystemAudio1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcSystemAudio1.Location = New System.Drawing.Point(17, 22)
        Me.UcSystemAudio1.Name = "UcSystemAudio1"
        Me.UcSystemAudio1.Size = New System.Drawing.Size(137, 102)
        Me.UcSystemAudio1.TabIndex = 0
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
        'cmdhide
        '
        Me.cmdhide.Image = CType(resources.GetObject("cmdhide.Image"), System.Drawing.Image)
        Me.cmdhide.Location = New System.Drawing.Point(656, -2)
        Me.cmdhide.Name = "cmdhide"
        Me.cmdhide.Size = New System.Drawing.Size(28, 27)
        Me.cmdhide.TabIndex = 1178
        Me.cmdhide.UseVisualStyleBackColor = True
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
        Me.ChannelInfo.ResumeLayout(False)
        Me.ScreenConsumer.ResumeLayout(False)
        Me.Playlist.ResumeLayout(False)
        Me.Utility.ResumeLayout(False)
        Me.AMCP.ResumeLayout(False)
        Me.SwfPlayer.ResumeLayout(False)
        Me.PlaylistSetting.ResumeLayout(False)
        Me.Logo.ResumeLayout(False)
        Me.SystemAudioPNGPositionAndSize.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ChannelInfo As TabPage
    Friend WithEvents SystemAudioPNGPositionAndSize As TabPage
    Friend WithEvents UcChannelInfo1 As ucChannelInfo
    Friend WithEvents UcSystemAudio1 As ucSystemAudio
    Friend WithEvents Playlist As TabPage
    Friend WithEvents UcPlaylistScheduler1 As UcPlaylistScheduler
    Friend WithEvents cmdhide As Button
    Friend WithEvents Logo As TabPage
    Friend WithEvents UcLogo1 As ucLogo
    Friend WithEvents Utility As TabPage
    Friend WithEvents UcUtility1 As ucUtility
    Friend WithEvents AMCP As TabPage
    Friend WithEvents SwfPlayer As TabPage
    Friend WithEvents UcSwfPlayer1 As ucSwfPlayer
    Friend WithEvents UcAMCPcommands1 As ucAMCPcommands
    Friend WithEvents PlaylistSetting As TabPage
    Friend WithEvents UcPlaylistSetting1 As ucPlaylistSetting
    Friend WithEvents UcPositionAndSize1 As ucPositionAndSize
    Friend WithEvents UcCreatePng1 As ucCreatePng
    Friend WithEvents ScreenConsumer As TabPage
    Friend WithEvents UcScreenConsumer1 As ucScreenConsumer
End Class
