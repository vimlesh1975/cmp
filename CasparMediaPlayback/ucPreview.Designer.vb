<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucPreview))
        Me.gbpreview = New System.Windows.Forms.GroupBox()
        Me.vlcpreview = New Vlc.DotNet.Forms.VlcControl()
        Me.cmbippreview = New System.Windows.Forms.ComboBox()
        Me.cmdWaveformluma = New System.Windows.Forms.Button()
        Me.cmdpreviewkey = New System.Windows.Forms.Button()
        Me.txtoptionspreview = New System.Windows.Forms.TextBox()
        Me.cmdremovepreview = New System.Windows.Forms.Button()
        Me.cmdpreview = New System.Windows.Forms.Button()
        Me.gbpreview.SuspendLayout()
        CType(Me.vlcpreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbpreview
        '
        Me.gbpreview.BackColor = System.Drawing.Color.PeachPuff
        Me.gbpreview.Controls.Add(Me.vlcpreview)
        Me.gbpreview.Controls.Add(Me.cmbippreview)
        Me.gbpreview.Controls.Add(Me.cmdWaveformluma)
        Me.gbpreview.Controls.Add(Me.cmdpreviewkey)
        Me.gbpreview.Controls.Add(Me.txtoptionspreview)
        Me.gbpreview.Controls.Add(Me.cmdremovepreview)
        Me.gbpreview.Controls.Add(Me.cmdpreview)
        Me.gbpreview.Location = New System.Drawing.Point(1, 1)
        Me.gbpreview.Name = "gbpreview"
        Me.gbpreview.Size = New System.Drawing.Size(596, 446)
        Me.gbpreview.TabIndex = 1168
        Me.gbpreview.TabStop = False
        '
        'vlcpreview
        '
        Me.vlcpreview.BackColor = System.Drawing.Color.Black
        Me.vlcpreview.Location = New System.Drawing.Point(3, 47)
        Me.vlcpreview.Name = "vlcpreview"
        Me.vlcpreview.Size = New System.Drawing.Size(588, 396)
        Me.vlcpreview.Spu = -1
        Me.vlcpreview.TabIndex = 1174
        Me.vlcpreview.Text = "VlcControl1"
        Me.vlcpreview.VlcLibDirectory = CType(resources.GetObject("vlcpreview.VlcLibDirectory"), System.IO.DirectoryInfo)
        Me.vlcpreview.VlcMediaplayerOptions = Nothing
        '
        'cmbippreview
        '
        Me.cmbippreview.FormattingEnabled = True
        Me.cmbippreview.Items.AddRange(New Object() {"224.0.0.1:5004", "127.0.0.1:5004", "192.168.1.1:5004", "192.168.1.2:5004", "192.168.1.3:5004"})
        Me.cmbippreview.Location = New System.Drawing.Point(2, 2)
        Me.cmbippreview.Name = "cmbippreview"
        Me.cmbippreview.Size = New System.Drawing.Size(99, 21)
        Me.cmbippreview.TabIndex = 1173
        Me.cmbippreview.Text = "224.0.0.1:5004"
        '
        'cmdWaveformluma
        '
        Me.cmdWaveformluma.Location = New System.Drawing.Point(457, 22)
        Me.cmdWaveformluma.Name = "cmdWaveformluma"
        Me.cmdWaveformluma.Size = New System.Drawing.Size(132, 24)
        Me.cmdWaveformluma.TabIndex = 1172
        Me.cmdWaveformluma.Text = "Show Luma Waveform"
        Me.cmdWaveformluma.UseVisualStyleBackColor = True
        '
        'cmdpreviewkey
        '
        Me.cmdpreviewkey.Location = New System.Drawing.Point(206, 22)
        Me.cmdpreviewkey.Name = "cmdpreviewkey"
        Me.cmdpreviewkey.Size = New System.Drawing.Size(74, 22)
        Me.cmdpreviewkey.TabIndex = 1171
        Me.cmdpreviewkey.Text = "Preview Key"
        Me.cmdpreviewkey.UseVisualStyleBackColor = True
        '
        'txtoptionspreview
        '
        Me.txtoptionspreview.Location = New System.Drawing.Point(106, 1)
        Me.txtoptionspreview.Multiline = True
        Me.txtoptionspreview.Name = "txtoptionspreview"
        Me.txtoptionspreview.Size = New System.Drawing.Size(484, 20)
        Me.txtoptionspreview.TabIndex = 1170
        Me.txtoptionspreview.Text = "-vcodec libx264 -tune zerolatency -preset ultrafast -crf 25 -format mpegts scale=" &
    "240:180"
        '
        'cmdremovepreview
        '
        Me.cmdremovepreview.Location = New System.Drawing.Point(302, 22)
        Me.cmdremovepreview.Name = "cmdremovepreview"
        Me.cmdremovepreview.Size = New System.Drawing.Size(124, 22)
        Me.cmdremovepreview.TabIndex = 1168
        Me.cmdremovepreview.Text = "Remove Preview"
        Me.cmdremovepreview.UseVisualStyleBackColor = True
        '
        'cmdpreview
        '
        Me.cmdpreview.Location = New System.Drawing.Point(107, 22)
        Me.cmdpreview.Name = "cmdpreview"
        Me.cmdpreview.Size = New System.Drawing.Size(80, 22)
        Me.cmdpreview.TabIndex = 1167
        Me.cmdpreview.Text = "Preview Fill"
        Me.cmdpreview.UseVisualStyleBackColor = True
        '
        'ucPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.gbpreview)
        Me.Name = "ucPreview"
        Me.Size = New System.Drawing.Size(600, 450)
        Me.gbpreview.ResumeLayout(False)
        Me.gbpreview.PerformLayout()
        CType(Me.vlcpreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbpreview As System.Windows.Forms.GroupBox
    Friend WithEvents cmbippreview As System.Windows.Forms.ComboBox
    Friend WithEvents cmdWaveformluma As System.Windows.Forms.Button
    Friend WithEvents cmdpreviewkey As System.Windows.Forms.Button
    Friend WithEvents txtoptionspreview As System.Windows.Forms.TextBox
    Friend WithEvents cmdremovepreview As System.Windows.Forms.Button
    Friend WithEvents cmdpreview As System.Windows.Forms.Button
    Friend WithEvents vlcpreview As Vlc.DotNet.Forms.VlcControl
End Class
