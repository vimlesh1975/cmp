<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcPlaylistScheduler
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UcPlaylistScheduler))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblscheduleList = New System.Windows.Forms.Label()
        Me.deleteschedule = New System.Windows.Forms.Button()
        Me.addschedule = New System.Windows.Forms.Button()
        Me.cmdStopSchedule = New System.Windows.Forms.Button()
        Me.cmdStartSchedule = New System.Windows.Forms.Button()
        Me.lbltestshedulerecording = New System.Windows.Forms.Label()
        Me.dgvscheduler = New System.Windows.Forms.DataGridView()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.tmrcommandschedulestart = New System.Windows.Forms.Timer(Me.components)
        Me.cmdmanualPlaycmdPlayNow = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdmoveup = New System.Windows.Forms.Button()
        Me.cmdmovedown = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdmanualPlaycmdCueNow = New System.Windows.Forms.Button()
        CType(Me.dgvscheduler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblscheduleList
        '
        Me.lblscheduleList.AutoSize = True
        Me.lblscheduleList.Location = New System.Drawing.Point(288, 9)
        Me.lblscheduleList.Name = "lblscheduleList"
        Me.lblscheduleList.Size = New System.Drawing.Size(73, 13)
        Me.lblscheduleList.TabIndex = 627
        Me.lblscheduleList.Text = "Scheduled list"
        '
        'deleteschedule
        '
        Me.deleteschedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteschedule.Image = Global.caspar_media_playback.My.Resources.Resources.minus
        Me.deleteschedule.Location = New System.Drawing.Point(232, 64)
        Me.deleteschedule.Name = "deleteschedule"
        Me.deleteschedule.Size = New System.Drawing.Size(35, 20)
        Me.deleteschedule.TabIndex = 625
        Me.deleteschedule.UseVisualStyleBackColor = True
        '
        'addschedule
        '
        Me.addschedule.Image = CType(resources.GetObject("addschedule.Image"), System.Drawing.Image)
        Me.addschedule.Location = New System.Drawing.Point(273, 63)
        Me.addschedule.Name = "addschedule"
        Me.addschedule.Size = New System.Drawing.Size(41, 23)
        Me.addschedule.TabIndex = 624
        Me.addschedule.UseVisualStyleBackColor = True
        '
        'cmdStopSchedule
        '
        Me.cmdStopSchedule.Location = New System.Drawing.Point(240, 30)
        Me.cmdStopSchedule.Name = "cmdStopSchedule"
        Me.cmdStopSchedule.Size = New System.Drawing.Size(64, 23)
        Me.cmdStopSchedule.TabIndex = 623
        Me.cmdStopSchedule.Text = "Stop"
        Me.cmdStopSchedule.UseVisualStyleBackColor = True
        '
        'cmdStartSchedule
        '
        Me.cmdStartSchedule.Location = New System.Drawing.Point(6, 33)
        Me.cmdStartSchedule.Name = "cmdStartSchedule"
        Me.cmdStartSchedule.Size = New System.Drawing.Size(75, 23)
        Me.cmdStartSchedule.TabIndex = 622
        Me.cmdStartSchedule.Text = "Start"
        Me.cmdStartSchedule.UseVisualStyleBackColor = True
        '
        'lbltestshedulerecording
        '
        Me.lbltestshedulerecording.AutoSize = True
        Me.lbltestshedulerecording.BackColor = System.Drawing.Color.Red
        Me.lbltestshedulerecording.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltestshedulerecording.Location = New System.Drawing.Point(87, 33)
        Me.lbltestshedulerecording.Name = "lbltestshedulerecording"
        Me.lbltestshedulerecording.Size = New System.Drawing.Size(147, 20)
        Me.lbltestshedulerecording.TabIndex = 621
        Me.lbltestshedulerecording.Text = "Schedule Stoped"
        '
        'dgvscheduler
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvscheduler.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvscheduler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvscheduler.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvscheduler.Location = New System.Drawing.Point(6, 87)
        Me.dgvscheduler.Name = "dgvscheduler"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvscheduler.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvscheduler.Size = New System.Drawing.Size(601, 204)
        Me.dgvscheduler.TabIndex = 620
        '
        'Label127
        '
        Me.Label127.AutoSize = True
        Me.Label127.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label127.Location = New System.Drawing.Point(32, 2)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(176, 24)
        Me.Label127.TabIndex = 619
        Me.Label127.Text = "Playlist Scheduler"
        '
        'tmrcommandschedulestart
        '
        '
        'cmdmanualPlaycmdPlayNow
        '
        Me.cmdmanualPlaycmdPlayNow.Location = New System.Drawing.Point(608, 164)
        Me.cmdmanualPlaycmdPlayNow.Name = "cmdmanualPlaycmdPlayNow"
        Me.cmdmanualPlaycmdPlayNow.Size = New System.Drawing.Size(50, 68)
        Me.cmdmanualPlaycmdPlayNow.TabIndex = 1178
        Me.cmdmanualPlaycmdPlayNow.Text = "Load and Play Now "
        Me.cmdmanualPlaycmdPlayNow.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(6, 63)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(45, 24)
        Me.MenuStrip1.TabIndex = 1213
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
        'cmdmoveup
        '
        Me.cmdmoveup.Image = Global.caspar_media_playback.My.Resources.Resources.UP
        Me.cmdmoveup.Location = New System.Drawing.Point(323, 61)
        Me.cmdmoveup.Name = "cmdmoveup"
        Me.cmdmoveup.Size = New System.Drawing.Size(49, 23)
        Me.cmdmoveup.TabIndex = 1214
        Me.cmdmoveup.UseVisualStyleBackColor = True
        '
        'cmdmovedown
        '
        Me.cmdmovedown.Image = Global.caspar_media_playback.My.Resources.Resources.Down
        Me.cmdmovedown.Location = New System.Drawing.Point(372, 61)
        Me.cmdmovedown.Name = "cmdmovedown"
        Me.cmdmovedown.Size = New System.Drawing.Size(50, 23)
        Me.cmdmovedown.TabIndex = 1215
        Me.cmdmovedown.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(320, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 13)
        Me.Label1.TabIndex = 1216
        Me.Label1.Text = "Double click in Playlist_file column to open playlist file"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.cmdmanualPlaycmdCueNow)
        Me.GroupBox1.Controls.Add(Me.cmdmanualPlaycmdPlayNow)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label127)
        Me.GroupBox1.Controls.Add(Me.cmdmoveup)
        Me.GroupBox1.Controls.Add(Me.dgvscheduler)
        Me.GroupBox1.Controls.Add(Me.cmdmovedown)
        Me.GroupBox1.Controls.Add(Me.lbltestshedulerecording)
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Controls.Add(Me.cmdStartSchedule)
        Me.GroupBox1.Controls.Add(Me.cmdStopSchedule)
        Me.GroupBox1.Controls.Add(Me.addschedule)
        Me.GroupBox1.Controls.Add(Me.lblscheduleList)
        Me.GroupBox1.Controls.Add(Me.deleteschedule)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 299)
        Me.GroupBox1.TabIndex = 1217
        Me.GroupBox1.TabStop = False
        '
        'cmdmanualPlaycmdCueNow
        '
        Me.cmdmanualPlaycmdCueNow.Location = New System.Drawing.Point(610, 90)
        Me.cmdmanualPlaycmdCueNow.Name = "cmdmanualPlaycmdCueNow"
        Me.cmdmanualPlaycmdCueNow.Size = New System.Drawing.Size(50, 68)
        Me.cmdmanualPlaycmdCueNow.TabIndex = 1217
        Me.cmdmanualPlaycmdCueNow.Text = "Load and Cue Now "
        Me.cmdmanualPlaycmdCueNow.UseVisualStyleBackColor = True
        '
        'UcPlaylistScheduler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UcPlaylistScheduler"
        Me.Size = New System.Drawing.Size(666, 307)
        CType(Me.dgvscheduler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblscheduleList As System.Windows.Forms.Label
    Friend WithEvents deleteschedule As System.Windows.Forms.Button
    Friend WithEvents addschedule As System.Windows.Forms.Button
    Friend WithEvents cmdStopSchedule As System.Windows.Forms.Button
    Friend WithEvents cmdStartSchedule As System.Windows.Forms.Button
    Friend WithEvents lbltestshedulerecording As System.Windows.Forms.Label
    Friend WithEvents dgvscheduler As System.Windows.Forms.DataGridView
    Friend WithEvents Label127 As System.Windows.Forms.Label
    Friend WithEvents tmrcommandschedulestart As System.Windows.Forms.Timer
    Friend WithEvents cmdmanualPlaycmdPlayNow As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdmoveup As Button
    Friend WithEvents cmdmovedown As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdmanualPlaycmdCueNow As Button
End Class
