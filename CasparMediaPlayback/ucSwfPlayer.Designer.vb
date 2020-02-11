<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSwfPlayer
    Inherits System.Windows.Forms.UserControl
    'Inherits WeifenLuo.WinFormsUI.Docking.DockContent

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucSwfPlayer))
        Me.gbswfplayer = New System.Windows.Forms.GroupBox()
        Me.picswf = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.cmbflashlayerforswf = New System.Windows.Forms.ComboBox()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.cmdswfopen = New System.Windows.Forms.Button()
        Me.cmdswfstop = New System.Windows.Forms.Button()
        Me.cmdswfplay = New System.Windows.Forms.Button()
        Me.gbswfplayer.SuspendLayout()
        CType(Me.picswf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbswfplayer
        '
        Me.gbswfplayer.BackColor = System.Drawing.Color.LightGreen
        Me.gbswfplayer.Controls.Add(Me.picswf)
        Me.gbswfplayer.Controls.Add(Me.cmbflashlayerforswf)
        Me.gbswfplayer.Controls.Add(Me.Label96)
        Me.gbswfplayer.Controls.Add(Me.cmdswfopen)
        Me.gbswfplayer.Controls.Add(Me.cmdswfstop)
        Me.gbswfplayer.Controls.Add(Me.cmdswfplay)
        Me.gbswfplayer.Location = New System.Drawing.Point(4, 4)
        Me.gbswfplayer.Name = "gbswfplayer"
        Me.gbswfplayer.Size = New System.Drawing.Size(324, 221)
        Me.gbswfplayer.TabIndex = 442
        Me.gbswfplayer.TabStop = False
        Me.gbswfplayer.Text = "Swf or image Player"
        '
        'picswf
        '
        Me.picswf.Enabled = True
        Me.picswf.Location = New System.Drawing.Point(6, 37)
        Me.picswf.MaximumSize = New System.Drawing.Size(241, 178)
        Me.picswf.MinimumSize = New System.Drawing.Size(10, 10)
        Me.picswf.Name = "picswf"
        Me.picswf.OcxState = CType(resources.GetObject("picswf.OcxState"), System.Windows.Forms.AxHost.State)
        Me.picswf.Size = New System.Drawing.Size(241, 178)
        Me.picswf.TabIndex = 454
        '
        'cmbflashlayerforswf
        '
        Me.cmbflashlayerforswf.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbflashlayerforswf", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbflashlayerforswf.FormattingEnabled = True
        Me.cmbflashlayerforswf.Items.AddRange(New Object() {"16", "17", "18", "19", "20"})
        Me.cmbflashlayerforswf.Location = New System.Drawing.Point(136, 10)
        Me.cmbflashlayerforswf.Name = "cmbflashlayerforswf"
        Me.cmbflashlayerforswf.Size = New System.Drawing.Size(45, 21)
        Me.cmbflashlayerforswf.TabIndex = 452
        Me.cmbflashlayerforswf.Text = "16"
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Location = New System.Drawing.Point(10, 16)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(120, 13)
        Me.Label96.TabIndex = 453
        Me.Label96.Text = "Video Layer-Flash Layer"
        '
        'cmdswfopen
        '
        Me.cmdswfopen.Location = New System.Drawing.Point(253, 78)
        Me.cmdswfopen.Name = "cmdswfopen"
        Me.cmdswfopen.Size = New System.Drawing.Size(65, 24)
        Me.cmdswfopen.TabIndex = 437
        Me.cmdswfopen.Text = "Open"
        Me.cmdswfopen.UseVisualStyleBackColor = True
        '
        'cmdswfstop
        '
        Me.cmdswfstop.BackColor = System.Drawing.Color.Red
        Me.cmdswfstop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdswfstop.ForeColor = System.Drawing.Color.White
        Me.cmdswfstop.Location = New System.Drawing.Point(253, 138)
        Me.cmdswfstop.Name = "cmdswfstop"
        Me.cmdswfstop.Size = New System.Drawing.Size(65, 24)
        Me.cmdswfstop.TabIndex = 440
        Me.cmdswfstop.Text = "Stop"
        Me.cmdswfstop.UseVisualStyleBackColor = False
        '
        'cmdswfplay
        '
        Me.cmdswfplay.BackColor = System.Drawing.Color.Green
        Me.cmdswfplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdswfplay.ForeColor = System.Drawing.Color.White
        Me.cmdswfplay.Location = New System.Drawing.Point(253, 108)
        Me.cmdswfplay.Name = "cmdswfplay"
        Me.cmdswfplay.Size = New System.Drawing.Size(65, 24)
        Me.cmdswfplay.TabIndex = 439
        Me.cmdswfplay.Text = "Play"
        Me.cmdswfplay.UseVisualStyleBackColor = False
        '
        'ucSwfPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.gbswfplayer)
        Me.Name = "ucSwfPlayer"
        Me.Size = New System.Drawing.Size(332, 228)
        Me.gbswfplayer.ResumeLayout(False)
        Me.gbswfplayer.PerformLayout()
        CType(Me.picswf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbswfplayer As System.Windows.Forms.GroupBox
    Friend WithEvents cmbflashlayerforswf As System.Windows.Forms.ComboBox
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents cmdswfopen As System.Windows.Forms.Button
    Friend WithEvents cmdswfstop As System.Windows.Forms.Button
    Friend WithEvents cmdswfplay As System.Windows.Forms.Button
    Friend WithEvents picswf As AxShockwaveFlashObjects.AxShockwaveFlash
End Class
