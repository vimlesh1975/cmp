<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAMCPcommands
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
        Me.gbamcpcommands = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.lblfilenameamcp = New System.Windows.Forms.Label()
        Me.cmdMiscellaneous = New System.Windows.Forms.Button()
        Me.cmbMiscellaneous = New System.Windows.Forms.ComboBox()
        Me.txtresponse = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.cmdanyamcpcommand = New System.Windows.Forms.Button()
        Me.txtanyamcpcommand = New System.Windows.Forms.TextBox()
        Me.gbamcpcommands.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbamcpcommands
        '
        Me.gbamcpcommands.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbamcpcommands.BackColor = System.Drawing.Color.SandyBrown
        Me.gbamcpcommands.Controls.Add(Me.MenuStrip1)
        Me.gbamcpcommands.Controls.Add(Me.Label110)
        Me.gbamcpcommands.Controls.Add(Me.lblfilenameamcp)
        Me.gbamcpcommands.Controls.Add(Me.cmdMiscellaneous)
        Me.gbamcpcommands.Controls.Add(Me.cmbMiscellaneous)
        Me.gbamcpcommands.Controls.Add(Me.txtresponse)
        Me.gbamcpcommands.Controls.Add(Me.Label64)
        Me.gbamcpcommands.Controls.Add(Me.Label63)
        Me.gbamcpcommands.Controls.Add(Me.cmdanyamcpcommand)
        Me.gbamcpcommands.Controls.Add(Me.txtanyamcpcommand)
        Me.gbamcpcommands.Location = New System.Drawing.Point(5, 6)
        Me.gbamcpcommands.Name = "gbamcpcommands"
        Me.gbamcpcommands.Size = New System.Drawing.Size(502, 273)
        Me.gbamcpcommands.TabIndex = 436
        Me.gbamcpcommands.TabStop = False
        Me.gbamcpcommands.Text = "AMCP Commands"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(11, 12)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(45, 24)
        Me.MenuStrip1.TabIndex = 711
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Location = New System.Drawing.Point(108, 16)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(54, 13)
        Me.Label110.TabIndex = 595
        Me.Label110.Text = "File Name"
        '
        'lblfilenameamcp
        '
        Me.lblfilenameamcp.AutoSize = True
        Me.lblfilenameamcp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "lblfilenameamcp", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lblfilenameamcp.Location = New System.Drawing.Point(168, 16)
        Me.lblfilenameamcp.Name = "lblfilenameamcp"
        Me.lblfilenameamcp.Size = New System.Drawing.Size(60, 13)
        Me.lblfilenameamcp.TabIndex = 594
        Me.lblfilenameamcp.Text = Global.caspar_media_playback.My.MySettings.Default.lblfilenameamcp
        '
        'cmdMiscellaneous
        '
        Me.cmdMiscellaneous.Location = New System.Drawing.Point(451, 140)
        Me.cmdMiscellaneous.Name = "cmdMiscellaneous"
        Me.cmdMiscellaneous.Size = New System.Drawing.Size(46, 23)
        Me.cmdMiscellaneous.TabIndex = 592
        Me.cmdMiscellaneous.Text = "Send"
        Me.cmdMiscellaneous.UseVisualStyleBackColor = True
        '
        'cmbMiscellaneous
        '
        Me.cmbMiscellaneous.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbMiscellaneous", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbMiscellaneous.FormattingEnabled = True
        Me.cmbMiscellaneous.Items.AddRange(New Object() {"ADD 1 AUDIO", "ADD 1 BLUEFISH 1", "ADD 1 DECKLINK 1", "add 1 decklink 1 keyer_internal", "ADD 1 EMBEDDED_AUDIO", "ADD 1 FILE FILENAME.MP4 SEPARATE_KEY", "add 1 file xyz.mxf mono_streams", "ADD 1 IMAGE FILENAME", "ADD 1 NDI", "add 1 ndi name ch1", "add 1 ndi name ch1 allow_fields", "ADD 1 newtek_ivga", "ADD 1 SCREEN 0", "ADD 1 SCREEN 0 FULLSCREEN", "ADD 1 SCREEN 0 INTERACTIVE", "ADD 1 SCREEN 0 NON_INTERACTIVE", "ADD 1 SCREEN 0 WINDOWED", "ADD 1 SCREEN 1 name Preview", "ADD 1 SCREEN 1 NO_AUTO_DEINTERLACE", "Add 1 screen 2 key_only", "add 2 ndi name ch2", "ADD 2 SCREEN 0", "add 3 ndi name ch3", "add 4 ndi name ch4", "BYE", "call 1-1 framerate speed 0.3", "CALL 1-1 LOOP 0", "CALL 1-1 LOOP 1", "call 1-1 seek -30 rel", "call 1-1 seek 30 end", "call 1-1 seek 30 rel", "CHANNEL_GRID", "CLS", "DATA LIST", "DATA REMOVE my_data", "DATA RETRIEVE my_data", "DATA STORE my_data ""Some useful data""", "DIAG", "FLS", "GL GC", "GL INFO", "HELP", "HELP PLAY", "INFO", "INFO 1", "INFO 1-1", "INFO 1-1 B", "INFO 1-1 F", "INFO 1 DELAY", "INFO CONFIG", "INFO PATHS", "INFO QUEUES", "INFO SERVER", "INFO SYSTEM", "INFO THREADS", "KILL", "LOCK 1 ACQUIRE secret", "LOCK 1 CLEAR", "LOCK 1 RELEASE", "LOG LEVEL debug", "LOG LEVEL error", "LOG LEVEL fatal", "LOG LEVEL info", "LOG LEVEL trace", "LOG LEVEL warning", "MIXER 1-0 KEYER 1", "MIXER 1-1 CLEAR", "MIXER 1 CLEAR", "MIXER 1 STRAIGHT_ALPHA_OUTPUT 0", "MIXER 1 STRAIGHT_ALPHA_OUTPUT 1", "MIXER 5 GRID 2", "NDI LIST", "PLAY 1-1 ""ndi://DEVICE-NAME/Source+Name""", "PLAY 1-1 [NDI] ""DEVICE-NAME (Source Name)""", "PLAY 1-1 AMB STING wipe_mask 0 wipe_overlay", "PLAY 2-10 route://1-10 BACKGROUND", "PLAY 2-10 route://1-10 NEXT", "PRINT 1", "REMOVE 1 AUDIO", "REMOVE 1 BLUEFISH 1", "REMOVE 1 DECKLINK 1", "REMOVE 1 EMBEDDED_AUDIO", "REMOVE 1 FILE", "remove 1 ndi", "REMOVE 1 NDI", "REMOVE 1 newtek_ivga", "REMOVE 1 REPLAY", "REMOVE 1 SCREEN", "REMOVE 1 STREAM udp://localhost:5004", "remove 2 ndi", "REMOVE 2 SCREEN", "remove 3 ndi", "remove 4 ndi", "RESTART", "RESUME 1-1", "SET 1 CHANNEL_LAYOUT 8ch", "SET 1 MODE 1080i5000", "SET 1 MODE 1080i5994", "SET 1 MODE 1080i6000", "SET 1 MODE 1080p2398", "SET 1 MODE 1080p2400", "SET 1 MODE 1080p2500", "SET 1 MODE 1080p2997", "SET 1 MODE 1080p3000", "SET 1 MODE 1080p5000", "SET 1 MODE 1080p5994", "SET 1 MODE 1080p6000", "SET 1 MODE 1556p2398", "SET 1 MODE 1556p2400", "SET 1 MODE 1556p2500", "SET 1 MODE 2160p2398", "SET 1 MODE 2160p2400", "SET 1 MODE 2160p2500", "SET 1 MODE 2160p2997", "SET 1 MODE 2160p3000", "SET 1 MODE 576p2500", "SET 1 MODE 720p2398", "SET 1 MODE 720p2400", "SET 1 MODE 720p2500", "SET 1 MODE 720p2997", "SET 1 MODE 720p3000", "SET 1 MODE 720p5000", "SET 1 MODE 720p5994", "SET 1 MODE 720p6000", "SET 1 MODE dci1080p2398", "SET 1 MODE dci1080p2400", "SET 1 MODE dci1080p2500", "SET 1 MODE dci2160p2398", "SET 1 MODE dci2160p2400", "SET 1 MODE dci2160p2500", "SET 1 MODE NTSC", "SET 1 MODE PAL", "Swap 1-1 1-2", "THUMBNAIL GENERATE_ALL", "THUMBNAIL LIST", "TLS", "VERSION FLASH", "VERSION SERVER", "VERSION TEMPLATEH"})
        Me.cmbMiscellaneous.Location = New System.Drawing.Point(139, 141)
        Me.cmbMiscellaneous.Name = "cmbMiscellaneous"
        Me.cmbMiscellaneous.Size = New System.Drawing.Size(306, 21)
        Me.cmbMiscellaneous.Sorted = True
        Me.cmbMiscellaneous.TabIndex = 591
        Me.cmbMiscellaneous.Text = Global.caspar_media_playback.My.MySettings.Default.cmbMiscellaneous
        '
        'txtresponse
        '
        Me.txtresponse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtresponse.Location = New System.Drawing.Point(6, 179)
        Me.txtresponse.Multiline = True
        Me.txtresponse.Name = "txtresponse"
        Me.txtresponse.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtresponse.Size = New System.Drawing.Size(439, 90)
        Me.txtresponse.TabIndex = 590
        Me.txtresponse.Text = "Response data"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(6, 161)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(55, 13)
        Me.Label64.TabIndex = 589
        Me.Label64.Text = "Response"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(8, 142)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(129, 13)
        Me.Label63.TabIndex = 588
        Me.Label63.Text = "Miscellaneous Commands"
        '
        'cmdanyamcpcommand
        '
        Me.cmdanyamcpcommand.Location = New System.Drawing.Point(451, 38)
        Me.cmdanyamcpcommand.Name = "cmdanyamcpcommand"
        Me.cmdanyamcpcommand.Size = New System.Drawing.Size(44, 99)
        Me.cmdanyamcpcommand.TabIndex = 362
        Me.cmdanyamcpcommand.Text = "Send"
        Me.cmdanyamcpcommand.UseVisualStyleBackColor = True
        '
        'txtanyamcpcommand
        '
        Me.txtanyamcpcommand.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtanyamcpcommand", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtanyamcpcommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtanyamcpcommand.Location = New System.Drawing.Point(5, 38)
        Me.txtanyamcpcommand.Multiline = True
        Me.txtanyamcpcommand.Name = "txtanyamcpcommand"
        Me.txtanyamcpcommand.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtanyamcpcommand.Size = New System.Drawing.Size(440, 99)
        Me.txtanyamcpcommand.TabIndex = 361
        Me.txtanyamcpcommand.Text = Global.caspar_media_playback.My.MySettings.Default.txtanyamcpcommand
        '
        'ucAMCPcommands
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.gbamcpcommands)
        Me.Name = "ucAMCPcommands"
        Me.Size = New System.Drawing.Size(514, 283)
        Me.gbamcpcommands.ResumeLayout(False)
        Me.gbamcpcommands.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbamcpcommands As System.Windows.Forms.GroupBox
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents lblfilenameamcp As System.Windows.Forms.Label
    Friend WithEvents cmdMiscellaneous As System.Windows.Forms.Button
    Friend WithEvents cmbMiscellaneous As System.Windows.Forms.ComboBox
    Friend WithEvents txtresponse As System.Windows.Forms.TextBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents cmdanyamcpcommand As System.Windows.Forms.Button
    Friend WithEvents txtanyamcpcommand As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
End Class
