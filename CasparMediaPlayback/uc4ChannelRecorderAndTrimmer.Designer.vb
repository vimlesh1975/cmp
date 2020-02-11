<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc4ChannelRecorderAndTrimmer
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
        Me.gb4ChannelRecorderAndTrimmer = New System.Windows.Forms.GroupBox()
        Me.UcSystemAudio1 = New caspar_media_playback.ucSystemAudio()
        Me.UcnewTrimmer11 = New caspar_media_playback.ucnewTrimmer1()
        Me.UcnewRecorder4 = New caspar_media_playback.ucnewRecorder()
        Me.UcnewRecorder3 = New caspar_media_playback.ucnewRecorder()
        Me.UcnewRecorder2 = New caspar_media_playback.ucnewRecorder()
        Me.UcnewRecorder1 = New caspar_media_playback.ucnewRecorder()
        Me.gb4ChannelRecorderAndTrimmer.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb4ChannelRecorderAndTrimmer
        '
        Me.gb4ChannelRecorderAndTrimmer.BackColor = System.Drawing.Color.SkyBlue
        Me.gb4ChannelRecorderAndTrimmer.Controls.Add(Me.UcSystemAudio1)
        Me.gb4ChannelRecorderAndTrimmer.Controls.Add(Me.UcnewTrimmer11)
        Me.gb4ChannelRecorderAndTrimmer.Controls.Add(Me.UcnewRecorder4)
        Me.gb4ChannelRecorderAndTrimmer.Controls.Add(Me.UcnewRecorder3)
        Me.gb4ChannelRecorderAndTrimmer.Controls.Add(Me.UcnewRecorder2)
        Me.gb4ChannelRecorderAndTrimmer.Controls.Add(Me.UcnewRecorder1)
        Me.gb4ChannelRecorderAndTrimmer.Location = New System.Drawing.Point(3, 3)
        Me.gb4ChannelRecorderAndTrimmer.Name = "gb4ChannelRecorderAndTrimmer"
        Me.gb4ChannelRecorderAndTrimmer.Size = New System.Drawing.Size(1159, 933)
        Me.gb4ChannelRecorderAndTrimmer.TabIndex = 0
        Me.gb4ChannelRecorderAndTrimmer.TabStop = False
        '
        'UcSystemAudio1
        '
        Me.UcSystemAudio1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcSystemAudio1.Location = New System.Drawing.Point(840, 802)
        Me.UcSystemAudio1.Name = "UcSystemAudio1"
        Me.UcSystemAudio1.Size = New System.Drawing.Size(137, 102)
        Me.UcSystemAudio1.TabIndex = 5
        '
        'UcnewTrimmer11
        '
        Me.UcnewTrimmer11.AllowDrop = True
        Me.UcnewTrimmer11.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcnewTrimmer11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcnewTrimmer11.Location = New System.Drawing.Point(634, 296)
        Me.UcnewTrimmer11.Name = "UcnewTrimmer11"
        Me.UcnewTrimmer11.Size = New System.Drawing.Size(484, 503)
        Me.UcnewTrimmer11.TabIndex = 4
        '
        'UcnewRecorder4
        '
        Me.UcnewRecorder4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcnewRecorder4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcnewRecorder4.Location = New System.Drawing.Point(581, 2)
        Me.UcnewRecorder4.Name = "UcnewRecorder4"
        Me.UcnewRecorder4.Size = New System.Drawing.Size(572, 292)
        Me.UcnewRecorder4.TabIndex = 3
        '
        'UcnewRecorder3
        '
        Me.UcnewRecorder3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcnewRecorder3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcnewRecorder3.Location = New System.Drawing.Point(6, 590)
        Me.UcnewRecorder3.Name = "UcnewRecorder3"
        Me.UcnewRecorder3.Size = New System.Drawing.Size(572, 292)
        Me.UcnewRecorder3.TabIndex = 2
        '
        'UcnewRecorder2
        '
        Me.UcnewRecorder2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcnewRecorder2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcnewRecorder2.Location = New System.Drawing.Point(6, 295)
        Me.UcnewRecorder2.Name = "UcnewRecorder2"
        Me.UcnewRecorder2.Size = New System.Drawing.Size(572, 292)
        Me.UcnewRecorder2.TabIndex = 1
        '
        'UcnewRecorder1
        '
        Me.UcnewRecorder1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcnewRecorder1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcnewRecorder1.Location = New System.Drawing.Point(6, 1)
        Me.UcnewRecorder1.Name = "UcnewRecorder1"
        Me.UcnewRecorder1.Size = New System.Drawing.Size(572, 292)
        Me.UcnewRecorder1.TabIndex = 0
        '
        'uc4ChannelRecorderAndTrimmer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1171, 945)
        Me.Controls.Add(Me.gb4ChannelRecorderAndTrimmer)
        Me.HideOnClose = True
        Me.Name = "uc4ChannelRecorderAndTrimmer"
        Me.Text = "4 Channel Recorder And Trimmer"
        Me.gb4ChannelRecorderAndTrimmer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb4ChannelRecorderAndTrimmer As GroupBox
    Friend WithEvents UcnewTrimmer11 As ucnewTrimmer1
    Friend WithEvents UcnewRecorder4 As ucnewRecorder
    Friend WithEvents UcnewRecorder3 As ucnewRecorder
    Friend WithEvents UcnewRecorder2 As ucnewRecorder
    Friend WithEvents UcnewRecorder1 As ucnewRecorder
    Friend WithEvents UcSystemAudio1 As ucSystemAudio
End Class
