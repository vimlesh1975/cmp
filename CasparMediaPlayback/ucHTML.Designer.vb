<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucHTML
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
        Me.gbhtml = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDebugPort = New System.Windows.Forms.TextBox()
        Me.cdOpenremoteDebugging = New System.Windows.Forms.Button()
        Me.gbNewYouTube = New System.Windows.Forms.GroupBox()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.cmdGetDuration = New System.Windows.Forms.Button()
        Me.lblCurrentTime = New System.Windows.Forms.Label()
        Me.cmdSetDuration = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtduration = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtheight = New System.Windows.Forms.TextBox()
        Me.txtwidth = New System.Windows.Forms.TextBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.cmdResume = New System.Windows.Forms.Button()
        Me.cmdPause = New System.Windows.Forms.Button()
        Me.txtvideoId = New System.Windows.Forms.TextBox()
        Me.cmdLoadVideo = New System.Windows.Forms.Button()
        Me.cmdreplaceurlforyoutubehtml = New System.Windows.Forms.Button()
        Me.cmdhtmlopen = New System.Windows.Forms.Button()
        Me.cmblayerhtml = New System.Windows.Forms.ComboBox()
        Me.lbllayerhtml = New System.Windows.Forms.Label()
        Me.cmdplayhtml = New System.Windows.Forms.Button()
        Me.cmdstophtml = New System.Windows.Forms.Button()
        Me.lblurlhtml = New System.Windows.Forms.Label()
        Me.txturlhtml = New System.Windows.Forms.TextBox()
        Me.gbhtml.SuspendLayout()
        Me.gbNewYouTube.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbhtml
        '
        Me.gbhtml.BackColor = System.Drawing.Color.MistyRose
        Me.gbhtml.Controls.Add(Me.Label5)
        Me.gbhtml.Controls.Add(Me.txtDebugPort)
        Me.gbhtml.Controls.Add(Me.cdOpenremoteDebugging)
        Me.gbhtml.Controls.Add(Me.gbNewYouTube)
        Me.gbhtml.Controls.Add(Me.cmdreplaceurlforyoutubehtml)
        Me.gbhtml.Controls.Add(Me.cmdhtmlopen)
        Me.gbhtml.Controls.Add(Me.cmblayerhtml)
        Me.gbhtml.Controls.Add(Me.lbllayerhtml)
        Me.gbhtml.Controls.Add(Me.cmdplayhtml)
        Me.gbhtml.Controls.Add(Me.cmdstophtml)
        Me.gbhtml.Controls.Add(Me.lblurlhtml)
        Me.gbhtml.Controls.Add(Me.txturlhtml)
        Me.gbhtml.Location = New System.Drawing.Point(4, 6)
        Me.gbhtml.Name = "gbhtml"
        Me.gbhtml.Size = New System.Drawing.Size(576, 484)
        Me.gbhtml.TabIndex = 630
        Me.gbhtml.TabStop = False
        Me.gbhtml.Text = " "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(338, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 744
        Me.Label5.Text = "Debug Port"
        '
        'txtDebugPort
        '
        Me.txtDebugPort.Location = New System.Drawing.Point(405, 106)
        Me.txtDebugPort.Name = "txtDebugPort"
        Me.txtDebugPort.Size = New System.Drawing.Size(55, 20)
        Me.txtDebugPort.TabIndex = 743
        Me.txtDebugPort.Text = "1024"
        Me.txtDebugPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cdOpenremoteDebugging
        '
        Me.cdOpenremoteDebugging.Location = New System.Drawing.Point(179, 102)
        Me.cdOpenremoteDebugging.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cdOpenremoteDebugging.Name = "cdOpenremoteDebugging"
        Me.cdOpenremoteDebugging.Size = New System.Drawing.Size(153, 26)
        Me.cdOpenremoteDebugging.TabIndex = 742
        Me.cdOpenremoteDebugging.Text = "Open Remote-debugging"
        Me.cdOpenremoteDebugging.UseVisualStyleBackColor = True
        '
        'gbNewYouTube
        '
        Me.gbNewYouTube.BackColor = System.Drawing.Color.LightCoral
        Me.gbNewYouTube.Controls.Add(Me.lblDuration)
        Me.gbNewYouTube.Controls.Add(Me.cmdGetDuration)
        Me.gbNewYouTube.Controls.Add(Me.lblCurrentTime)
        Me.gbNewYouTube.Controls.Add(Me.cmdSetDuration)
        Me.gbNewYouTube.Controls.Add(Me.Label4)
        Me.gbNewYouTube.Controls.Add(Me.txtduration)
        Me.gbNewYouTube.Controls.Add(Me.Label3)
        Me.gbNewYouTube.Controls.Add(Me.Label2)
        Me.gbNewYouTube.Controls.Add(Me.Label1)
        Me.gbNewYouTube.Controls.Add(Me.txtheight)
        Me.gbNewYouTube.Controls.Add(Me.txtwidth)
        Me.gbNewYouTube.Controls.Add(Me.TrackBar1)
        Me.gbNewYouTube.Controls.Add(Me.cmdResume)
        Me.gbNewYouTube.Controls.Add(Me.cmdPause)
        Me.gbNewYouTube.Controls.Add(Me.txtvideoId)
        Me.gbNewYouTube.Controls.Add(Me.cmdLoadVideo)
        Me.gbNewYouTube.Location = New System.Drawing.Point(7, 160)
        Me.gbNewYouTube.Name = "gbNewYouTube"
        Me.gbNewYouTube.Size = New System.Drawing.Size(432, 310)
        Me.gbNewYouTube.TabIndex = 741
        Me.gbNewYouTube.TabStop = False
        Me.gbNewYouTube.Text = "New YouTube Method"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(300, 131)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(47, 13)
        Me.lblDuration.TabIndex = 742
        Me.lblDuration.Text = "Duration"
        '
        'cmdGetDuration
        '
        Me.cmdGetDuration.Location = New System.Drawing.Point(194, 126)
        Me.cmdGetDuration.Name = "cmdGetDuration"
        Me.cmdGetDuration.Size = New System.Drawing.Size(100, 23)
        Me.cmdGetDuration.TabIndex = 741
        Me.cmdGetDuration.Text = "Get Duration"
        Me.cmdGetDuration.UseVisualStyleBackColor = True
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.AutoSize = True
        Me.lblCurrentTime.Location = New System.Drawing.Point(141, 226)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(34, 13)
        Me.lblCurrentTime.TabIndex = 740
        Me.lblCurrentTime.Text = "Value"
        '
        'cmdSetDuration
        '
        Me.cmdSetDuration.Location = New System.Drawing.Point(194, 165)
        Me.cmdSetDuration.Name = "cmdSetDuration"
        Me.cmdSetDuration.Size = New System.Drawing.Size(100, 23)
        Me.cmdSetDuration.TabIndex = 739
        Me.cmdSetDuration.Text = "Sett Duration"
        Me.cmdSetDuration.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 738
        Me.Label4.Text = "Duration in Second"
        '
        'txtduration
        '
        Me.txtduration.Location = New System.Drawing.Point(115, 165)
        Me.txtduration.Name = "txtduration"
        Me.txtduration.Size = New System.Drawing.Size(73, 20)
        Me.txtduration.TabIndex = 737
        Me.txtduration.Text = "489"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 736
        Me.Label3.Text = "Video ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 735
        Me.Label2.Text = "Height"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 734
        Me.Label1.Text = "Width"
        '
        'txtheight
        '
        Me.txtheight.Location = New System.Drawing.Point(69, 74)
        Me.txtheight.Name = "txtheight"
        Me.txtheight.Size = New System.Drawing.Size(53, 20)
        Me.txtheight.TabIndex = 733
        Me.txtheight.Text = "576"
        '
        'txtwidth
        '
        Me.txtwidth.Location = New System.Drawing.Point(69, 48)
        Me.txtwidth.Name = "txtwidth"
        Me.txtwidth.Size = New System.Drawing.Size(53, 20)
        Me.txtwidth.TabIndex = 732
        Me.txtwidth.Text = "1024"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(21, 194)
        Me.TrackBar1.Maximum = 489
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(273, 45)
        Me.TrackBar1.TabIndex = 731
        '
        'cmdResume
        '
        Me.cmdResume.BackColor = System.Drawing.Color.Yellow
        Me.cmdResume.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResume.Location = New System.Drawing.Point(194, 97)
        Me.cmdResume.Name = "cmdResume"
        Me.cmdResume.Size = New System.Drawing.Size(100, 23)
        Me.cmdResume.TabIndex = 730
        Me.cmdResume.Text = "Resume"
        Me.cmdResume.UseVisualStyleBackColor = False
        '
        'cmdPause
        '
        Me.cmdPause.BackColor = System.Drawing.Color.Yellow
        Me.cmdPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPause.Location = New System.Drawing.Point(194, 71)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.Size = New System.Drawing.Size(100, 23)
        Me.cmdPause.TabIndex = 729
        Me.cmdPause.Text = "Pause"
        Me.cmdPause.UseVisualStyleBackColor = False
        '
        'txtvideoId
        '
        Me.txtvideoId.Location = New System.Drawing.Point(69, 100)
        Me.txtvideoId.Name = "txtvideoId"
        Me.txtvideoId.Size = New System.Drawing.Size(119, 20)
        Me.txtvideoId.TabIndex = 728
        Me.txtvideoId.Text = "plxV00PcX28"
        '
        'cmdLoadVideo
        '
        Me.cmdLoadVideo.BackColor = System.Drawing.Color.Green
        Me.cmdLoadVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoadVideo.ForeColor = System.Drawing.Color.White
        Me.cmdLoadVideo.Location = New System.Drawing.Point(194, 38)
        Me.cmdLoadVideo.Name = "cmdLoadVideo"
        Me.cmdLoadVideo.Size = New System.Drawing.Size(100, 30)
        Me.cmdLoadVideo.TabIndex = 727
        Me.cmdLoadVideo.Text = "Load and Play"
        Me.cmdLoadVideo.UseVisualStyleBackColor = False
        '
        'cmdreplaceurlforyoutubehtml
        '
        Me.cmdreplaceurlforyoutubehtml.Location = New System.Drawing.Point(6, 70)
        Me.cmdreplaceurlforyoutubehtml.Name = "cmdreplaceurlforyoutubehtml"
        Me.cmdreplaceurlforyoutubehtml.Size = New System.Drawing.Size(238, 26)
        Me.cmdreplaceurlforyoutubehtml.TabIndex = 726
        Me.cmdreplaceurlforyoutubehtml.Text = "Replace URL for full screen YouTube Video"
        Me.cmdreplaceurlforyoutubehtml.UseVisualStyleBackColor = True
        '
        'cmdhtmlopen
        '
        Me.cmdhtmlopen.Location = New System.Drawing.Point(10, 102)
        Me.cmdhtmlopen.Name = "cmdhtmlopen"
        Me.cmdhtmlopen.Size = New System.Drawing.Size(73, 26)
        Me.cmdhtmlopen.TabIndex = 634
        Me.cmdhtmlopen.Text = "File Open"
        Me.cmdhtmlopen.UseVisualStyleBackColor = True
        '
        'cmblayerhtml
        '
        Me.cmblayerhtml.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmblayerhtml", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmblayerhtml.FormattingEnabled = True
        Me.cmblayerhtml.Items.AddRange(New Object() {"91", "92", "93", "94", "95"})
        Me.cmblayerhtml.Location = New System.Drawing.Point(373, 17)
        Me.cmblayerhtml.Name = "cmblayerhtml"
        Me.cmblayerhtml.Size = New System.Drawing.Size(50, 21)
        Me.cmblayerhtml.TabIndex = 322
        Me.cmblayerhtml.Text = Global.caspar_media_playback.My.MySettings.Default.cmblayerhtml
        '
        'lbllayerhtml
        '
        Me.lbllayerhtml.AutoSize = True
        Me.lbllayerhtml.Location = New System.Drawing.Point(331, 21)
        Me.lbllayerhtml.Name = "lbllayerhtml"
        Me.lbllayerhtml.Size = New System.Drawing.Size(33, 13)
        Me.lbllayerhtml.TabIndex = 321
        Me.lbllayerhtml.Text = "Layer"
        '
        'cmdplayhtml
        '
        Me.cmdplayhtml.BackColor = System.Drawing.Color.Green
        Me.cmdplayhtml.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplayhtml.ForeColor = System.Drawing.Color.White
        Me.cmdplayhtml.Location = New System.Drawing.Point(90, 102)
        Me.cmdplayhtml.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdplayhtml.Name = "cmdplayhtml"
        Me.cmdplayhtml.Size = New System.Drawing.Size(77, 26)
        Me.cmdplayhtml.TabIndex = 627
        Me.cmdplayhtml.Text = "Play"
        Me.cmdplayhtml.UseVisualStyleBackColor = False
        '
        'cmdstophtml
        '
        Me.cmdstophtml.BackColor = System.Drawing.Color.Red
        Me.cmdstophtml.ForeColor = System.Drawing.Color.White
        Me.cmdstophtml.Location = New System.Drawing.Point(477, 72)
        Me.cmdstophtml.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdstophtml.Name = "cmdstophtml"
        Me.cmdstophtml.Size = New System.Drawing.Size(77, 398)
        Me.cmdstophtml.TabIndex = 628
        Me.cmdstophtml.Text = "Stop"
        Me.cmdstophtml.UseVisualStyleBackColor = False
        '
        'lblurlhtml
        '
        Me.lblurlhtml.AutoSize = True
        Me.lblurlhtml.Location = New System.Drawing.Point(16, 21)
        Me.lblurlhtml.Name = "lblurlhtml"
        Me.lblurlhtml.Size = New System.Drawing.Size(29, 13)
        Me.lblurlhtml.TabIndex = 625
        Me.lblurlhtml.Text = "URL"
        '
        'txturlhtml
        '
        Me.txturlhtml.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txturlhtml", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txturlhtml.Location = New System.Drawing.Point(6, 46)
        Me.txturlhtml.Name = "txturlhtml"
        Me.txturlhtml.Size = New System.Drawing.Size(558, 20)
        Me.txturlhtml.TabIndex = 624
        Me.txturlhtml.Text = Global.caspar_media_playback.My.MySettings.Default.txturlhtml
        '
        'ucHTML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(583, 493)
        Me.Controls.Add(Me.gbhtml)
        Me.HideOnClose = True
        Me.Name = "ucHTML"
        Me.Text = "HTML"
        Me.gbhtml.ResumeLayout(False)
        Me.gbhtml.PerformLayout()
        Me.gbNewYouTube.ResumeLayout(False)
        Me.gbNewYouTube.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbhtml As System.Windows.Forms.GroupBox
    Friend WithEvents cmdreplaceurlforyoutubehtml As System.Windows.Forms.Button
    Friend WithEvents cmdhtmlopen As System.Windows.Forms.Button
    Friend WithEvents cmblayerhtml As System.Windows.Forms.ComboBox
    Friend WithEvents lbllayerhtml As System.Windows.Forms.Label
    Friend WithEvents cmdstophtml As System.Windows.Forms.Button
    Friend WithEvents lblurlhtml As System.Windows.Forms.Label
    Friend WithEvents txturlhtml As System.Windows.Forms.TextBox
    Friend WithEvents cmdplayhtml As Button
    Friend WithEvents gbNewYouTube As GroupBox
    Friend WithEvents lblCurrentTime As Label
    Friend WithEvents cmdSetDuration As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtduration As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtheight As TextBox
    Friend WithEvents txtwidth As TextBox
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents cmdResume As Button
    Friend WithEvents cmdPause As Button
    Friend WithEvents txtvideoId As TextBox
    Friend WithEvents cmdLoadVideo As Button
    Friend WithEvents cmdGetDuration As Button
    Friend WithEvents lblDuration As Label
    Friend WithEvents cdOpenremoteDebugging As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDebugPort As TextBox
End Class
