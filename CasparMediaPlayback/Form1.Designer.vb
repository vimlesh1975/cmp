<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    'Inherits System.Windows.Forms.Form
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent
    'Form overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdResumeAll = New System.Windows.Forms.Button()
        Me.cmdPauseAll = New System.Windows.Forms.Button()
        Me.cmdPlayAllfromBegining = New System.Windows.Forms.Button()
        Me.cmdClearChannel = New System.Windows.Forms.Button()
        Me.cmdAddMedia = New System.Windows.Forms.Button()
        Me.cmdAddDummyMedia = New System.Windows.Forms.Button()
        Me.cmdSaveFile = New System.Windows.Forms.Button()
        Me.cmdOpenFile = New System.Windows.Forms.Button()
        Me.UcMixernew1 = New caspar_media_playback.ucMixernew()
        Me.cmdSaveFileAs = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.chkMuteAudio = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(800, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Casparcg Screen"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MistyRose
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(601, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 445)
        Me.Panel1.TabIndex = 25
        '
        'cmdResumeAll
        '
        Me.cmdResumeAll.Location = New System.Drawing.Point(1004, 510)
        Me.cmdResumeAll.Name = "cmdResumeAll"
        Me.cmdResumeAll.Size = New System.Drawing.Size(71, 23)
        Me.cmdResumeAll.TabIndex = 24
        Me.cmdResumeAll.Text = "Resume All"
        Me.cmdResumeAll.UseVisualStyleBackColor = True
        '
        'cmdPauseAll
        '
        Me.cmdPauseAll.Location = New System.Drawing.Point(936, 510)
        Me.cmdPauseAll.Name = "cmdPauseAll"
        Me.cmdPauseAll.Size = New System.Drawing.Size(63, 23)
        Me.cmdPauseAll.TabIndex = 23
        Me.cmdPauseAll.Text = "Pause All"
        Me.cmdPauseAll.UseVisualStyleBackColor = True
        '
        'cmdPlayAllfromBegining
        '
        Me.cmdPlayAllfromBegining.Location = New System.Drawing.Point(807, 510)
        Me.cmdPlayAllfromBegining.Name = "cmdPlayAllfromBegining"
        Me.cmdPlayAllfromBegining.Size = New System.Drawing.Size(123, 23)
        Me.cmdPlayAllfromBegining.TabIndex = 22
        Me.cmdPlayAllfromBegining.Text = "Play All from Begining"
        Me.cmdPlayAllfromBegining.UseVisualStyleBackColor = True
        '
        'cmdClearChannel
        '
        Me.cmdClearChannel.Location = New System.Drawing.Point(992, 470)
        Me.cmdClearChannel.Name = "cmdClearChannel"
        Me.cmdClearChannel.Size = New System.Drawing.Size(95, 23)
        Me.cmdClearChannel.TabIndex = 21
        Me.cmdClearChannel.Text = "Clear Channel"
        Me.cmdClearChannel.UseVisualStyleBackColor = True
        '
        'cmdAddMedia
        '
        Me.cmdAddMedia.Location = New System.Drawing.Point(759, 469)
        Me.cmdAddMedia.Name = "cmdAddMedia"
        Me.cmdAddMedia.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddMedia.TabIndex = 20
        Me.cmdAddMedia.Text = "Add Media"
        Me.cmdAddMedia.UseVisualStyleBackColor = True
        '
        'cmdAddDummyMedia
        '
        Me.cmdAddDummyMedia.Location = New System.Drawing.Point(854, 468)
        Me.cmdAddDummyMedia.Name = "cmdAddDummyMedia"
        Me.cmdAddDummyMedia.Size = New System.Drawing.Size(120, 23)
        Me.cmdAddDummyMedia.TabIndex = 28
        Me.cmdAddDummyMedia.Text = "Add Dummy Media"
        Me.cmdAddDummyMedia.UseVisualStyleBackColor = True
        '
        'cmdSaveFile
        '
        Me.cmdSaveFile.Location = New System.Drawing.Point(899, 581)
        Me.cmdSaveFile.Name = "cmdSaveFile"
        Me.cmdSaveFile.Size = New System.Drawing.Size(75, 23)
        Me.cmdSaveFile.TabIndex = 29
        Me.cmdSaveFile.Text = "Save file"
        Me.cmdSaveFile.UseVisualStyleBackColor = True
        '
        'cmdOpenFile
        '
        Me.cmdOpenFile.Location = New System.Drawing.Point(899, 610)
        Me.cmdOpenFile.Name = "cmdOpenFile"
        Me.cmdOpenFile.Size = New System.Drawing.Size(75, 23)
        Me.cmdOpenFile.TabIndex = 30
        Me.cmdOpenFile.Text = "Open File"
        Me.cmdOpenFile.UseVisualStyleBackColor = True
        '
        'UcMixernew1
        '
        Me.UcMixernew1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcMixernew1.Location = New System.Drawing.Point(3, 2)
        Me.UcMixernew1.Name = "UcMixernew1"
        Me.UcMixernew1.Size = New System.Drawing.Size(592, 560)
        Me.UcMixernew1.TabIndex = 27
        '
        'cmdSaveFileAs
        '
        Me.cmdSaveFileAs.Location = New System.Drawing.Point(980, 581)
        Me.cmdSaveFileAs.Name = "cmdSaveFileAs"
        Me.cmdSaveFileAs.Size = New System.Drawing.Size(95, 23)
        Me.cmdSaveFileAs.TabIndex = 31
        Me.cmdSaveFileAs.Text = "Save file as"
        Me.cmdSaveFileAs.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(622, 556)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "File Name"
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(683, 556)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(54, 13)
        Me.lblFileName.TabIndex = 33
        Me.lblFileName.Text = "File Name"
        '
        'chkMuteAudio
        '
        Me.chkMuteAudio.AutoSize = True
        Me.chkMuteAudio.Location = New System.Drawing.Point(601, 476)
        Me.chkMuteAudio.Name = "chkMuteAudio"
        Me.chkMuteAudio.Size = New System.Drawing.Size(80, 17)
        Me.chkMuteAudio.TabIndex = 34
        Me.chkMuteAudio.Text = "Mute Audio"
        Me.chkMuteAudio.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 918)
        Me.Controls.Add(Me.chkMuteAudio)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdSaveFileAs)
        Me.Controls.Add(Me.cmdOpenFile)
        Me.Controls.Add(Me.cmdSaveFile)
        Me.Controls.Add(Me.cmdAddDummyMedia)
        Me.Controls.Add(Me.UcMixernew1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdResumeAll)
        Me.Controls.Add(Me.cmdPauseAll)
        Me.Controls.Add(Me.cmdPlayAllfromBegining)
        Me.Controls.Add(Me.cmdClearChannel)
        Me.Controls.Add(Me.cmdAddMedia)
        Me.HideOnClose = True
        Me.Name = "Form1"
        Me.Text = "Composition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdResumeAll As Button
    Friend WithEvents cmdPauseAll As Button
    Friend WithEvents cmdPlayAllfromBegining As Button
    Friend WithEvents cmdClearChannel As Button
    Friend WithEvents cmdAddMedia As Button
    Friend WithEvents UcMixernew1 As ucMixernew
    Friend WithEvents cmdAddDummyMedia As Button
    Friend WithEvents cmdSaveFile As Button
    Friend WithEvents cmdOpenFile As Button
    Friend WithEvents cmdSaveFileAs As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFileName As Label
    Friend WithEvents chkMuteAudio As CheckBox
End Class
