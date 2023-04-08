<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucSlowMotion21
    'Inherits System.Windows.Forms.UserControl
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.UcClipGrid1 = New caspar_media_playback.ucClipGrid()
        Me.UcSMRecorder2 = New caspar_media_playback.ucSMRecorder()
        Me.UcnewSM21 = New caspar_media_playback.ucnewSM2()
        Me.UcnewSM22 = New caspar_media_playback.ucnewSM2()
        Me.UcSMRecorder1 = New caspar_media_playback.ucSMRecorder()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSalmon
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.UcClipGrid1)
        Me.GroupBox1.Controls.Add(Me.UcSMRecorder2)
        Me.GroupBox1.Controls.Add(Me.UcnewSM21)
        Me.GroupBox1.Controls.Add(Me.UcnewSM22)
        Me.GroupBox1.Controls.Add(Me.UcSMRecorder1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1037, 900)
        Me.GroupBox1.TabIndex = 1210
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(740, 634)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(275, 194)
        Me.TextBox1.TabIndex = 1210
        Me.TextBox1.Text = "Shuttle Pro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Button1 = Record" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Button2 = Stop Record" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Button3 = Load in SM Player" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shuutle Right = Increase Speed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shuttle Left = Spped 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jog Right = Next Frame" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jog Left = Previous Frame"
        '
        'UcClipGrid1
        '
        Me.UcClipGrid1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcClipGrid1.Location = New System.Drawing.Point(4, 555)
        Me.UcClipGrid1.Name = "UcClipGrid1"
        Me.UcClipGrid1.Size = New System.Drawing.Size(705, 342)
        Me.UcClipGrid1.TabIndex = 1209
        '
        'UcSMRecorder2
        '
        Me.UcSMRecorder2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcSMRecorder2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcSMRecorder2.Location = New System.Drawing.Point(3, 279)
        Me.UcSMRecorder2.Name = "UcSMRecorder2"
        Me.UcSMRecorder2.Size = New System.Drawing.Size(567, 274)
        Me.UcSMRecorder2.TabIndex = 1205
        '
        'UcnewSM21
        '
        Me.UcnewSM21.AllowDrop = True
        Me.UcnewSM21.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcnewSM21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcnewSM21.Location = New System.Drawing.Point(570, 1)
        Me.UcnewSM21.Name = "UcnewSM21"
        Me.UcnewSM21.Size = New System.Drawing.Size(467, 276)
        Me.UcnewSM21.TabIndex = 1
        '
        'UcnewSM22
        '
        Me.UcnewSM22.AllowDrop = True
        Me.UcnewSM22.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcnewSM22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcnewSM22.Location = New System.Drawing.Point(570, 278)
        Me.UcnewSM22.Name = "UcnewSM22"
        Me.UcnewSM22.Size = New System.Drawing.Size(467, 274)
        Me.UcnewSM22.TabIndex = 1206
        '
        'UcSMRecorder1
        '
        Me.UcSMRecorder1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcSMRecorder1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcSMRecorder1.Location = New System.Drawing.Point(2, 1)
        Me.UcSMRecorder1.Name = "UcSMRecorder1"
        Me.UcSMRecorder1.Size = New System.Drawing.Size(567, 276)
        Me.UcSMRecorder1.TabIndex = 0
        '
        'ucSlowMotion21
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1221, 749)
        Me.Controls.Add(Me.GroupBox1)
        Me.HideOnClose = True
        Me.MaximumSize = New System.Drawing.Size(3000, 1080)
        Me.Name = "ucSlowMotion21"
        Me.Text = "Slow Motion in Server 2.1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcSMRecorder1 As ucSMRecorder
    Friend WithEvents UcnewSM21 As ucnewSM2
    Friend WithEvents UcnewSM22 As ucnewSM2
    Friend WithEvents UcSMRecorder2 As ucSMRecorder
    Friend WithEvents UcClipGrid1 As ucClipGrid
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
End Class
