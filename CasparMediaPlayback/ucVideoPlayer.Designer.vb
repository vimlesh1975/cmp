<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucVideoPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucVideoPlayer))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbcliplist = New System.Windows.Forms.GroupBox()
        Me.ProgressBar2 = New VerticalProgressBar.VerticalProgressBar()
        Me.ProgressBar1 = New VerticalProgressBar.VerticalProgressBar()
        Me.gbplayerforclipgrid = New System.Windows.Forms.GroupBox()
        Me.lblChannel = New System.Windows.Forms.Label()
        Me.cmdplaynextforclipgrid = New System.Windows.Forms.Button()
        Me.cmdcuenextforclipgrid = New System.Windows.Forms.Button()
        Me.cmdstopforclipgrid = New System.Windows.Forms.Button()
        Me.cmdresumeforclipgrid = New System.Windows.Forms.Button()
        Me.cmdplayforclipgrid = New System.Windows.Forms.Button()
        Me.cmdcueforclipgrid = New System.Windows.Forms.Button()
        Me.cmdpauseforclipgrid = New System.Windows.Forms.Button()
        Me.Label220 = New System.Windows.Forms.Label()
        Me.Label221 = New System.Windows.Forms.Label()
        Me.Label222 = New System.Windows.Forms.Label()
        Me.pnlrecording = New System.Windows.Forms.Panel()
        Me.cmbcasparcgwindowtitle = New System.Windows.Forms.ComboBox()
        Me.cmdoutcasparcgwindowrecording = New System.Windows.Forms.Button()
        Me.cmdshowcasparcgwindowrecording = New System.Windows.Forms.Button()
        Me.lblsearch = New System.Windows.Forms.Label()
        Me.Label237 = New System.Windows.Forms.Label()
        Me.pbclipsearchstatus = New System.Windows.Forms.ProgressBar()
        Me.cmdrefreshtvclips = New System.Windows.Forms.Button()
        Me.tvclips = New System.Windows.Forms.TreeView()
        Me.labelclips = New System.Windows.Forms.Label()
        Me.chkclipduration = New System.Windows.Forms.CheckBox()
        Me.dgvclips = New System.Windows.Forms.DataGridView()
        Me.cmdclipsearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.cmdLoopPlay = New System.Windows.Forms.Button()
        Me.gbcliplist.SuspendLayout()
        Me.gbplayerforclipgrid.SuspendLayout()
        CType(Me.dgvclips, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbcliplist
        '
        Me.gbcliplist.BackColor = System.Drawing.Color.Thistle
        Me.gbcliplist.Controls.Add(Me.ProgressBar2)
        Me.gbcliplist.Controls.Add(Me.ProgressBar1)
        Me.gbcliplist.Controls.Add(Me.gbplayerforclipgrid)
        Me.gbcliplist.Controls.Add(Me.pnlrecording)
        Me.gbcliplist.Controls.Add(Me.cmbcasparcgwindowtitle)
        Me.gbcliplist.Controls.Add(Me.cmdoutcasparcgwindowrecording)
        Me.gbcliplist.Controls.Add(Me.cmdshowcasparcgwindowrecording)
        Me.gbcliplist.Controls.Add(Me.lblsearch)
        Me.gbcliplist.Controls.Add(Me.Label237)
        Me.gbcliplist.Controls.Add(Me.pbclipsearchstatus)
        Me.gbcliplist.Controls.Add(Me.cmdrefreshtvclips)
        Me.gbcliplist.Controls.Add(Me.tvclips)
        Me.gbcliplist.Controls.Add(Me.labelclips)
        Me.gbcliplist.Controls.Add(Me.chkclipduration)
        Me.gbcliplist.Controls.Add(Me.dgvclips)
        Me.gbcliplist.Controls.Add(Me.cmdclipsearch)
        Me.gbcliplist.Controls.Add(Me.txtsearch)
        Me.gbcliplist.Location = New System.Drawing.Point(3, 3)
        Me.gbcliplist.Name = "gbcliplist"
        Me.gbcliplist.Size = New System.Drawing.Size(588, 312)
        Me.gbcliplist.TabIndex = 1172
        Me.gbcliplist.TabStop = False
        Me.gbcliplist.Text = "Video Player"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.BackColor = System.Drawing.Color.Turquoise
        Me.ProgressBar2.BorderStyle = VerticalProgressBar.BorderStyles.Classic
        Me.ProgressBar2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressBar2.Location = New System.Drawing.Point(576, 120)
        Me.ProgressBar2.Maximum = 40
        Me.ProgressBar2.Minimum = 0
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(11, 129)
        Me.ProgressBar2.Step = 1
        Me.ProgressBar2.Style = VerticalProgressBar.Styles.Classic
        Me.ProgressBar2.TabIndex = 1172
        Me.ProgressBar2.Value = 40
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Turquoise
        Me.ProgressBar1.BorderStyle = VerticalProgressBar.BorderStyles.Classic
        Me.ProgressBar1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(407, 122)
        Me.ProgressBar1.Maximum = 40
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(10, 131)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = VerticalProgressBar.Styles.Classic
        Me.ProgressBar1.TabIndex = 737
        Me.ProgressBar1.Value = 40
        '
        'gbplayerforclipgrid
        '
        Me.gbplayerforclipgrid.BackColor = System.Drawing.Color.Turquoise
        Me.gbplayerforclipgrid.Controls.Add(Me.cmdLoopPlay)
        Me.gbplayerforclipgrid.Controls.Add(Me.lblChannel)
        Me.gbplayerforclipgrid.Controls.Add(Me.cmdplaynextforclipgrid)
        Me.gbplayerforclipgrid.Controls.Add(Me.cmdcuenextforclipgrid)
        Me.gbplayerforclipgrid.Controls.Add(Me.cmdstopforclipgrid)
        Me.gbplayerforclipgrid.Controls.Add(Me.cmdresumeforclipgrid)
        Me.gbplayerforclipgrid.Controls.Add(Me.cmdplayforclipgrid)
        Me.gbplayerforclipgrid.Controls.Add(Me.cmdcueforclipgrid)
        Me.gbplayerforclipgrid.Controls.Add(Me.cmdpauseforclipgrid)
        Me.gbplayerforclipgrid.Controls.Add(Me.Label220)
        Me.gbplayerforclipgrid.Controls.Add(Me.Label221)
        Me.gbplayerforclipgrid.Controls.Add(Me.Label222)
        Me.gbplayerforclipgrid.Location = New System.Drawing.Point(1, 259)
        Me.gbplayerforclipgrid.Name = "gbplayerforclipgrid"
        Me.gbplayerforclipgrid.Size = New System.Drawing.Size(586, 55)
        Me.gbplayerforclipgrid.TabIndex = 1171
        Me.gbplayerforclipgrid.TabStop = False
        '
        'lblChannel
        '
        Me.lblChannel.AutoSize = True
        Me.lblChannel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChannel.ForeColor = System.Drawing.Color.DarkRed
        Me.lblChannel.Location = New System.Drawing.Point(440, 17)
        Me.lblChannel.Name = "lblChannel"
        Me.lblChannel.Size = New System.Drawing.Size(105, 24)
        Me.lblChannel.TabIndex = 1189
        Me.lblChannel.Text = "Channel 1"
        '
        'cmdplaynextforclipgrid
        '
        Me.cmdplaynextforclipgrid.Image = CType(resources.GetObject("cmdplaynextforclipgrid.Image"), System.Drawing.Image)
        Me.cmdplaynextforclipgrid.Location = New System.Drawing.Point(310, 13)
        Me.cmdplaynextforclipgrid.Name = "cmdplaynextforclipgrid"
        Me.cmdplaynextforclipgrid.Size = New System.Drawing.Size(47, 37)
        Me.cmdplaynextforclipgrid.TabIndex = 1188
        Me.cmdplaynextforclipgrid.UseVisualStyleBackColor = True
        '
        'cmdcuenextforclipgrid
        '
        Me.cmdcuenextforclipgrid.Image = CType(resources.GetObject("cmdcuenextforclipgrid.Image"), System.Drawing.Image)
        Me.cmdcuenextforclipgrid.Location = New System.Drawing.Point(259, 13)
        Me.cmdcuenextforclipgrid.Name = "cmdcuenextforclipgrid"
        Me.cmdcuenextforclipgrid.Size = New System.Drawing.Size(47, 37)
        Me.cmdcuenextforclipgrid.TabIndex = 1187
        Me.cmdcuenextforclipgrid.UseVisualStyleBackColor = True
        '
        'cmdstopforclipgrid
        '
        Me.cmdstopforclipgrid.Image = CType(resources.GetObject("cmdstopforclipgrid.Image"), System.Drawing.Image)
        Me.cmdstopforclipgrid.Location = New System.Drawing.Point(208, 13)
        Me.cmdstopforclipgrid.Name = "cmdstopforclipgrid"
        Me.cmdstopforclipgrid.Size = New System.Drawing.Size(47, 37)
        Me.cmdstopforclipgrid.TabIndex = 1186
        Me.cmdstopforclipgrid.UseVisualStyleBackColor = True
        '
        'cmdresumeforclipgrid
        '
        Me.cmdresumeforclipgrid.Image = CType(resources.GetObject("cmdresumeforclipgrid.Image"), System.Drawing.Image)
        Me.cmdresumeforclipgrid.Location = New System.Drawing.Point(159, 13)
        Me.cmdresumeforclipgrid.Name = "cmdresumeforclipgrid"
        Me.cmdresumeforclipgrid.Size = New System.Drawing.Size(47, 37)
        Me.cmdresumeforclipgrid.TabIndex = 1185
        Me.cmdresumeforclipgrid.UseVisualStyleBackColor = True
        '
        'cmdplayforclipgrid
        '
        Me.cmdplayforclipgrid.Image = CType(resources.GetObject("cmdplayforclipgrid.Image"), System.Drawing.Image)
        Me.cmdplayforclipgrid.Location = New System.Drawing.Point(57, 12)
        Me.cmdplayforclipgrid.Name = "cmdplayforclipgrid"
        Me.cmdplayforclipgrid.Size = New System.Drawing.Size(47, 37)
        Me.cmdplayforclipgrid.TabIndex = 1183
        Me.cmdplayforclipgrid.UseVisualStyleBackColor = True
        '
        'cmdcueforclipgrid
        '
        Me.cmdcueforclipgrid.Image = CType(resources.GetObject("cmdcueforclipgrid.Image"), System.Drawing.Image)
        Me.cmdcueforclipgrid.Location = New System.Drawing.Point(3, 13)
        Me.cmdcueforclipgrid.Name = "cmdcueforclipgrid"
        Me.cmdcueforclipgrid.Size = New System.Drawing.Size(47, 37)
        Me.cmdcueforclipgrid.TabIndex = 1181
        Me.cmdcueforclipgrid.UseVisualStyleBackColor = True
        '
        'cmdpauseforclipgrid
        '
        Me.cmdpauseforclipgrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdpauseforclipgrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpauseforclipgrid.Image = Global.caspar_media_playback.My.Resources.Resources.pause3
        Me.cmdpauseforclipgrid.Location = New System.Drawing.Point(109, 13)
        Me.cmdpauseforclipgrid.Name = "cmdpauseforclipgrid"
        Me.cmdpauseforclipgrid.Size = New System.Drawing.Size(47, 37)
        Me.cmdpauseforclipgrid.TabIndex = 159
        Me.cmdpauseforclipgrid.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdpauseforclipgrid.UseVisualStyleBackColor = True
        '
        'Label220
        '
        Me.Label220.AutoSize = True
        Me.Label220.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label220.Location = New System.Drawing.Point(466, 10)
        Me.Label220.Name = "Label220"
        Me.Label220.Size = New System.Drawing.Size(10, 13)
        Me.Label220.TabIndex = 352
        Me.Label220.Text = "."
        Me.Label220.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label221
        '
        Me.Label221.AutoSize = True
        Me.Label221.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label221.Location = New System.Drawing.Point(29, 13)
        Me.Label221.Name = "Label221"
        Me.Label221.Size = New System.Drawing.Size(10, 13)
        Me.Label221.TabIndex = 335
        Me.Label221.Text = "."
        Me.Label221.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label222
        '
        Me.Label222.AutoSize = True
        Me.Label222.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label222.Location = New System.Drawing.Point(822, 10)
        Me.Label222.Name = "Label222"
        Me.Label222.Size = New System.Drawing.Size(10, 13)
        Me.Label222.TabIndex = 0
        Me.Label222.Text = "."
        Me.Label222.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlrecording
        '
        Me.pnlrecording.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlrecording.Location = New System.Drawing.Point(420, 122)
        Me.pnlrecording.Name = "pnlrecording"
        Me.pnlrecording.Size = New System.Drawing.Size(154, 129)
        Me.pnlrecording.TabIndex = 734
        '
        'cmbcasparcgwindowtitle
        '
        Me.cmbcasparcgwindowtitle.FormattingEnabled = True
        Me.cmbcasparcgwindowtitle.Location = New System.Drawing.Point(407, 71)
        Me.cmbcasparcgwindowtitle.Name = "cmbcasparcgwindowtitle"
        Me.cmbcasparcgwindowtitle.Size = New System.Drawing.Size(175, 21)
        Me.cmbcasparcgwindowtitle.TabIndex = 737
        Me.cmbcasparcgwindowtitle.Text = " "
        '
        'cmdoutcasparcgwindowrecording
        '
        Me.cmdoutcasparcgwindowrecording.Location = New System.Drawing.Point(445, 96)
        Me.cmdoutcasparcgwindowrecording.Name = "cmdoutcasparcgwindowrecording"
        Me.cmdoutcasparcgwindowrecording.Size = New System.Drawing.Size(47, 23)
        Me.cmdoutcasparcgwindowrecording.TabIndex = 736
        Me.cmdoutcasparcgwindowrecording.Text = "OUT"
        Me.cmdoutcasparcgwindowrecording.UseVisualStyleBackColor = True
        '
        'cmdshowcasparcgwindowrecording
        '
        Me.cmdshowcasparcgwindowrecording.Location = New System.Drawing.Point(411, 96)
        Me.cmdshowcasparcgwindowrecording.Name = "cmdshowcasparcgwindowrecording"
        Me.cmdshowcasparcgwindowrecording.Size = New System.Drawing.Size(32, 23)
        Me.cmdshowcasparcgwindowrecording.TabIndex = 735
        Me.cmdshowcasparcgwindowrecording.Text = "IN"
        Me.cmdshowcasparcgwindowrecording.UseVisualStyleBackColor = True
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.Location = New System.Drawing.Point(101, 13)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(0, 13)
        Me.lblsearch.TabIndex = 187
        '
        'Label237
        '
        Me.Label237.AutoSize = True
        Me.Label237.Location = New System.Drawing.Point(402, 11)
        Me.Label237.Name = "Label237"
        Me.Label237.Size = New System.Drawing.Size(31, 13)
        Me.Label237.TabIndex = 186
        Me.Label237.Text = "Total"
        '
        'pbclipsearchstatus
        '
        Me.pbclipsearchstatus.Location = New System.Drawing.Point(108, 30)
        Me.pbclipsearchstatus.Name = "pbclipsearchstatus"
        Me.pbclipsearchstatus.Size = New System.Drawing.Size(296, 10)
        Me.pbclipsearchstatus.TabIndex = 185
        '
        'cmdrefreshtvclips
        '
        Me.cmdrefreshtvclips.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdrefreshtvclips.Location = New System.Drawing.Point(1, 14)
        Me.cmdrefreshtvclips.Name = "cmdrefreshtvclips"
        Me.cmdrefreshtvclips.Size = New System.Drawing.Size(94, 21)
        Me.cmdrefreshtvclips.TabIndex = 184
        Me.cmdrefreshtvclips.Text = "Refresh Folders"
        Me.cmdrefreshtvclips.UseVisualStyleBackColor = True
        '
        'tvclips
        '
        Me.tvclips.Location = New System.Drawing.Point(2, 40)
        Me.tvclips.Name = "tvclips"
        Me.tvclips.Size = New System.Drawing.Size(104, 214)
        Me.tvclips.TabIndex = 183
        '
        'labelclips
        '
        Me.labelclips.AutoSize = True
        Me.labelclips.Location = New System.Drawing.Point(437, 10)
        Me.labelclips.Name = "labelclips"
        Me.labelclips.Size = New System.Drawing.Size(29, 13)
        Me.labelclips.TabIndex = 182
        Me.labelclips.Text = "Clips"
        '
        'chkclipduration
        '
        Me.chkclipduration.AutoSize = True
        Me.chkclipduration.Location = New System.Drawing.Point(413, 30)
        Me.chkclipduration.Name = "chkclipduration"
        Me.chkclipduration.Size = New System.Drawing.Size(164, 17)
        Me.chkclipduration.TabIndex = 178
        Me.chkclipduration.Text = "Duration (Will take more time)"
        Me.chkclipduration.UseVisualStyleBackColor = True
        '
        'dgvclips
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvclips.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvclips.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvclips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvclips.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvclips.Location = New System.Drawing.Point(109, 41)
        Me.dgvclips.MultiSelect = False
        Me.dgvclips.Name = "dgvclips"
        Me.dgvclips.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvclips.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvclips.RowHeadersWidth = 25
        Me.dgvclips.Size = New System.Drawing.Size(295, 213)
        Me.dgvclips.TabIndex = 177
        '
        'cmdclipsearch
        '
        Me.cmdclipsearch.Location = New System.Drawing.Point(324, 6)
        Me.cmdclipsearch.Name = "cmdclipsearch"
        Me.cmdclipsearch.Size = New System.Drawing.Size(76, 25)
        Me.cmdclipsearch.TabIndex = 176
        Me.cmdclipsearch.Text = "Search Clips"
        Me.cmdclipsearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(251, 9)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(70, 20)
        Me.txtsearch.TabIndex = 175
        '
        'cmdLoopPlay
        '
        Me.cmdLoopPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoopPlay.Location = New System.Drawing.Point(369, 13)
        Me.cmdLoopPlay.Name = "cmdLoopPlay"
        Me.cmdLoopPlay.Size = New System.Drawing.Size(47, 37)
        Me.cmdLoopPlay.TabIndex = 1190
        Me.cmdLoopPlay.Text = "Loop Play"
        Me.cmdLoopPlay.UseVisualStyleBackColor = True
        '
        'ucVideoPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.gbcliplist)
        Me.Name = "ucVideoPlayer"
        Me.Size = New System.Drawing.Size(594, 331)
        Me.gbcliplist.ResumeLayout(False)
        Me.gbcliplist.PerformLayout()
        Me.gbplayerforclipgrid.ResumeLayout(False)
        Me.gbplayerforclipgrid.PerformLayout()
        CType(Me.dgvclips, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbcliplist As GroupBox
    Friend WithEvents lblsearch As Label
    Friend WithEvents Label237 As Label
    Friend WithEvents pbclipsearchstatus As ProgressBar
    Friend WithEvents cmdrefreshtvclips As Button
    Friend WithEvents tvclips As TreeView
    Friend WithEvents labelclips As Label
    Friend WithEvents chkclipduration As CheckBox
    Friend WithEvents dgvclips As DataGridView
    Friend WithEvents cmdclipsearch As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents pnlrecording As Panel
    Friend WithEvents cmbcasparcgwindowtitle As ComboBox
    Friend WithEvents cmdoutcasparcgwindowrecording As Button
    Friend WithEvents cmdshowcasparcgwindowrecording As Button
    Friend WithEvents gbplayerforclipgrid As GroupBox
    Friend WithEvents cmdplaynextforclipgrid As Button
    Friend WithEvents cmdcuenextforclipgrid As Button
    Friend WithEvents cmdstopforclipgrid As Button
    Friend WithEvents cmdresumeforclipgrid As Button
    Friend WithEvents cmdplayforclipgrid As Button
    Friend WithEvents cmdcueforclipgrid As Button
    Friend WithEvents cmdpauseforclipgrid As Button
    Friend WithEvents Label220 As Label
    Friend WithEvents Label221 As Label
    Friend WithEvents Label222 As Label
    Friend WithEvents ProgressBar1 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents ProgressBar2 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents lblChannel As Label
    Friend WithEvents cmdLoopPlay As Button
End Class
