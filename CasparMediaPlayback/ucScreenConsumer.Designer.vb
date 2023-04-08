<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucScreenConsumer
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
        Me.cmdshowcasparcgwindowrecording = New System.Windows.Forms.Button()
        Me.pnlrecording = New System.Windows.Forms.Panel()
        Me.cmbscreenConsumres = New System.Windows.Forms.ComboBox()
        Me.cmdoutcasparcgwindowrecording = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdshowcasparcgwindowrecording
        '
        Me.cmdshowcasparcgwindowrecording.Location = New System.Drawing.Point(464, 3)
        Me.cmdshowcasparcgwindowrecording.Name = "cmdshowcasparcgwindowrecording"
        Me.cmdshowcasparcgwindowrecording.Size = New System.Drawing.Size(32, 23)
        Me.cmdshowcasparcgwindowrecording.TabIndex = 748
        Me.cmdshowcasparcgwindowrecording.Text = "IN"
        Me.cmdshowcasparcgwindowrecording.UseVisualStyleBackColor = True
        '
        'pnlrecording
        '
        Me.pnlrecording.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlrecording.Location = New System.Drawing.Point(5, 4)
        Me.pnlrecording.Name = "pnlrecording"
        Me.pnlrecording.Size = New System.Drawing.Size(416, 285)
        Me.pnlrecording.TabIndex = 743
        '
        'cmbscreenConsumres
        '
        Me.cmbscreenConsumres.FormattingEnabled = True
        Me.cmbscreenConsumres.Items.AddRange(New Object() {"Screen consumer [1|PAL]", "Screen consumer [2|PAL]", "Screen consumer [3|PAL]", "Screen consumer [4|PAL]", "Screen consumer [600|PAL]", "Screen consumer [1|NTSC]", "Screen consumer [1|NTSC]", "Screen consumer [2|NTSC]", "Screen consumer [1|1080i5000]", "Screen consumer [600|1080i5000]", "Screen consumer [2|1080i5000]", "Screen consumer [3|1080i5000]", "Screen consumer [4|1080i5000]", "Screen consumer [1|1080i5994]", "Screen consumer [1|1080i6000]", "Screen consumer [1|1080p2398]", "Screen consumer [1|1080p2400]", "Screen consumer [1|1080p2500]", "Screen consumer [1|1080p2997]", "Screen consumer [1|1080p3000]", "Screen consumer [1|1080p5000]", "Screen consumer [1|1080p5994]", "Screen consumer [1|1080p6000]", "Screen consumer [1|1556p2398]", "Screen consumer [1|1556p2400]", "Screen consumer [1|1556p2500]", "Screen consumer [1|2160p2398]", "Screen consumer [1|2160p2400]", "Screen consumer [1|2160p2500]", "Screen consumer [1| 2160p2997]", "Screen consumer [1|2160p3000]", "Screen consumer [1|576p2500]", "Screen consumer [1|720p2398]", "Screen consumer [1|720p2400]", "Screen consumer [1|720p2500]", "Screen consumer [1|720p2997]", "Screen consumer [1|720p3000]", "Screen consumer [1|720p5000]", "Screen consumer [1|720p5994]", "Screen consumer [1|720p6000]"})
        Me.cmbscreenConsumres.Location = New System.Drawing.Point(451, 32)
        Me.cmbscreenConsumres.Name = "cmbscreenConsumres"
        Me.cmbscreenConsumres.Size = New System.Drawing.Size(205, 21)
        Me.cmbscreenConsumres.TabIndex = 745
        Me.cmbscreenConsumres.Text = "Screen consumer [2|PAL]"
        '
        'cmdoutcasparcgwindowrecording
        '
        Me.cmdoutcasparcgwindowrecording.Location = New System.Drawing.Point(513, 3)
        Me.cmdoutcasparcgwindowrecording.Name = "cmdoutcasparcgwindowrecording"
        Me.cmdoutcasparcgwindowrecording.Size = New System.Drawing.Size(47, 23)
        Me.cmdoutcasparcgwindowrecording.TabIndex = 744
        Me.cmdoutcasparcgwindowrecording.Text = "OUT"
        Me.cmdoutcasparcgwindowrecording.UseVisualStyleBackColor = True
        '
        'ucScreenConsumer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Controls.Add(Me.cmdshowcasparcgwindowrecording)
        Me.Controls.Add(Me.pnlrecording)
        Me.Controls.Add(Me.cmbscreenConsumres)
        Me.Controls.Add(Me.cmdoutcasparcgwindowrecording)
        Me.Name = "ucScreenConsumer"
        Me.Size = New System.Drawing.Size(663, 306)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdshowcasparcgwindowrecording As Button
    Friend WithEvents pnlrecording As Panel
    Friend WithEvents cmbscreenConsumres As ComboBox
    Friend WithEvents cmdoutcasparcgwindowrecording As Button
End Class
