<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSystemAudio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucSystemAudio))
        Me.gbSystemAudio = New System.Windows.Forms.GroupBox()
        Me.cmdcloseRecorder = New System.Windows.Forms.Button()
        Me.cmdSystemAudio = New System.Windows.Forms.Button()
        Me.chkSystemAudioch4 = New System.Windows.Forms.CheckBox()
        Me.chkSystemAudioch3 = New System.Windows.Forms.CheckBox()
        Me.chkSystemAudioch2 = New System.Windows.Forms.CheckBox()
        Me.chkSystemAudioch1 = New System.Windows.Forms.CheckBox()
        Me.gbSystemAudio.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSystemAudio
        '
        Me.gbSystemAudio.BackColor = System.Drawing.Color.Khaki
        Me.gbSystemAudio.Controls.Add(Me.cmdcloseRecorder)
        Me.gbSystemAudio.Controls.Add(Me.cmdSystemAudio)
        Me.gbSystemAudio.Controls.Add(Me.chkSystemAudioch4)
        Me.gbSystemAudio.Controls.Add(Me.chkSystemAudioch3)
        Me.gbSystemAudio.Controls.Add(Me.chkSystemAudioch2)
        Me.gbSystemAudio.Controls.Add(Me.chkSystemAudioch1)
        Me.gbSystemAudio.Location = New System.Drawing.Point(4, 4)
        Me.gbSystemAudio.Name = "gbSystemAudio"
        Me.gbSystemAudio.Size = New System.Drawing.Size(129, 95)
        Me.gbSystemAudio.TabIndex = 737
        Me.gbSystemAudio.TabStop = False
        Me.gbSystemAudio.Text = "System Audio"
        '
        'cmdcloseRecorder
        '
        Me.cmdcloseRecorder.Image = CType(resources.GetObject("cmdcloseRecorder.Image"), System.Drawing.Image)
        Me.cmdcloseRecorder.Location = New System.Drawing.Point(98, 0)
        Me.cmdcloseRecorder.Name = "cmdcloseRecorder"
        Me.cmdcloseRecorder.Size = New System.Drawing.Size(28, 27)
        Me.cmdcloseRecorder.TabIndex = 1197
        Me.cmdcloseRecorder.UseVisualStyleBackColor = True
        '
        'cmdSystemAudio
        '
        Me.cmdSystemAudio.Location = New System.Drawing.Point(55, 21)
        Me.cmdSystemAudio.Name = "cmdSystemAudio"
        Me.cmdSystemAudio.Size = New System.Drawing.Size(40, 70)
        Me.cmdSystemAudio.TabIndex = 4
        Me.cmdSystemAudio.Text = "Send"
        Me.cmdSystemAudio.UseVisualStyleBackColor = True
        '
        'chkSystemAudioch4
        '
        Me.chkSystemAudioch4.AutoSize = True
        Me.chkSystemAudioch4.Location = New System.Drawing.Point(7, 76)
        Me.chkSystemAudioch4.Name = "chkSystemAudioch4"
        Me.chkSystemAudioch4.Size = New System.Drawing.Size(50, 17)
        Me.chkSystemAudioch4.TabIndex = 3
        Me.chkSystemAudioch4.Text = "CH 4"
        Me.chkSystemAudioch4.UseVisualStyleBackColor = True
        '
        'chkSystemAudioch3
        '
        Me.chkSystemAudioch3.AutoSize = True
        Me.chkSystemAudioch3.Location = New System.Drawing.Point(7, 58)
        Me.chkSystemAudioch3.Name = "chkSystemAudioch3"
        Me.chkSystemAudioch3.Size = New System.Drawing.Size(50, 17)
        Me.chkSystemAudioch3.TabIndex = 2
        Me.chkSystemAudioch3.Text = "CH 3"
        Me.chkSystemAudioch3.UseVisualStyleBackColor = True
        '
        'chkSystemAudioch2
        '
        Me.chkSystemAudioch2.AutoSize = True
        Me.chkSystemAudioch2.Location = New System.Drawing.Point(7, 38)
        Me.chkSystemAudioch2.Name = "chkSystemAudioch2"
        Me.chkSystemAudioch2.Size = New System.Drawing.Size(50, 17)
        Me.chkSystemAudioch2.TabIndex = 1
        Me.chkSystemAudioch2.Text = "CH 2"
        Me.chkSystemAudioch2.UseVisualStyleBackColor = True
        '
        'chkSystemAudioch1
        '
        Me.chkSystemAudioch1.AutoSize = True
        Me.chkSystemAudioch1.Location = New System.Drawing.Point(7, 19)
        Me.chkSystemAudioch1.Name = "chkSystemAudioch1"
        Me.chkSystemAudioch1.Size = New System.Drawing.Size(50, 17)
        Me.chkSystemAudioch1.TabIndex = 0
        Me.chkSystemAudioch1.Text = "CH 1"
        Me.chkSystemAudioch1.UseVisualStyleBackColor = True
        '
        'ucSystemAudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.gbSystemAudio)
        Me.Name = "ucSystemAudio"
        Me.Size = New System.Drawing.Size(137, 102)
        Me.gbSystemAudio.ResumeLayout(False)
        Me.gbSystemAudio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbSystemAudio As GroupBox
    Friend WithEvents cmdSystemAudio As Button
    Friend WithEvents chkSystemAudioch4 As CheckBox
    Friend WithEvents chkSystemAudioch3 As CheckBox
    Friend WithEvents chkSystemAudioch2 As CheckBox
    Friend WithEvents chkSystemAudioch1 As CheckBox
    Friend WithEvents cmdcloseRecorder As Button
End Class
