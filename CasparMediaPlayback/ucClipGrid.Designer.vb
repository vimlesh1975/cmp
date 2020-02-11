<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucClipGrid
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbcliplist = New System.Windows.Forms.GroupBox()
        Me.cmbChannelDestination = New System.Windows.Forms.ComboBox()
        Me.cmdLoadinSMPlayer = New System.Windows.Forms.Button()
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
        Me.gbcliplist.SuspendLayout()
        CType(Me.dgvclips, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbcliplist
        '
        Me.gbcliplist.BackColor = System.Drawing.Color.Thistle
        Me.gbcliplist.Controls.Add(Me.cmbChannelDestination)
        Me.gbcliplist.Controls.Add(Me.cmdLoadinSMPlayer)
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
        Me.gbcliplist.Location = New System.Drawing.Point(6, 5)
        Me.gbcliplist.Name = "gbcliplist"
        Me.gbcliplist.Size = New System.Drawing.Size(692, 334)
        Me.gbcliplist.TabIndex = 1172
        Me.gbcliplist.TabStop = False
        Me.gbcliplist.Text = "ClipGrid"
        '
        'cmbChannelDestination
        '
        Me.cmbChannelDestination.FormattingEnabled = True
        Me.cmbChannelDestination.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbChannelDestination.Location = New System.Drawing.Point(88, 308)
        Me.cmbChannelDestination.Name = "cmbChannelDestination"
        Me.cmbChannelDestination.Size = New System.Drawing.Size(41, 21)
        Me.cmbChannelDestination.TabIndex = 189
        Me.cmbChannelDestination.Text = "2"
        '
        'cmdLoadinSMPlayer
        '
        Me.cmdLoadinSMPlayer.Location = New System.Drawing.Point(135, 307)
        Me.cmdLoadinSMPlayer.Name = "cmdLoadinSMPlayer"
        Me.cmdLoadinSMPlayer.Size = New System.Drawing.Size(551, 23)
        Me.cmdLoadinSMPlayer.TabIndex = 188
        Me.cmdLoadinSMPlayer.Text = "Load in SM Player"
        Me.cmdLoadinSMPlayer.UseVisualStyleBackColor = True
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
        Me.Label237.Location = New System.Drawing.Point(421, 11)
        Me.Label237.Name = "Label237"
        Me.Label237.Size = New System.Drawing.Size(31, 13)
        Me.Label237.TabIndex = 186
        Me.Label237.Text = "Total"
        '
        'pbclipsearchstatus
        '
        Me.pbclipsearchstatus.Location = New System.Drawing.Point(135, 30)
        Me.pbclipsearchstatus.Name = "pbclipsearchstatus"
        Me.pbclipsearchstatus.Size = New System.Drawing.Size(551, 10)
        Me.pbclipsearchstatus.TabIndex = 185
        '
        'cmdrefreshtvclips
        '
        Me.cmdrefreshtvclips.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdrefreshtvclips.Location = New System.Drawing.Point(5, 14)
        Me.cmdrefreshtvclips.Name = "cmdrefreshtvclips"
        Me.cmdrefreshtvclips.Size = New System.Drawing.Size(94, 21)
        Me.cmdrefreshtvclips.TabIndex = 184
        Me.cmdrefreshtvclips.Text = "Refresh Folders"
        Me.cmdrefreshtvclips.UseVisualStyleBackColor = True
        '
        'tvclips
        '
        Me.tvclips.Location = New System.Drawing.Point(6, 40)
        Me.tvclips.Name = "tvclips"
        Me.tvclips.Size = New System.Drawing.Size(126, 266)
        Me.tvclips.TabIndex = 183
        '
        'labelclips
        '
        Me.labelclips.AutoSize = True
        Me.labelclips.Location = New System.Drawing.Point(449, 10)
        Me.labelclips.Name = "labelclips"
        Me.labelclips.Size = New System.Drawing.Size(29, 13)
        Me.labelclips.TabIndex = 182
        Me.labelclips.Text = "Clips"
        '
        'chkclipduration
        '
        Me.chkclipduration.AutoSize = True
        Me.chkclipduration.Location = New System.Drawing.Point(485, 10)
        Me.chkclipduration.Name = "chkclipduration"
        Me.chkclipduration.Size = New System.Drawing.Size(164, 17)
        Me.chkclipduration.TabIndex = 178
        Me.chkclipduration.Text = "Duration (Will take more time)"
        Me.chkclipduration.UseVisualStyleBackColor = True
        '
        'dgvclips
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvclips.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvclips.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvclips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvclips.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvclips.Location = New System.Drawing.Point(135, 41)
        Me.dgvclips.MultiSelect = False
        Me.dgvclips.Name = "dgvclips"
        Me.dgvclips.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvclips.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvclips.RowHeadersWidth = 25
        Me.dgvclips.Size = New System.Drawing.Size(551, 265)
        Me.dgvclips.TabIndex = 177
        '
        'cmdclipsearch
        '
        Me.cmdclipsearch.Location = New System.Drawing.Point(344, 6)
        Me.cmdclipsearch.Name = "cmdclipsearch"
        Me.cmdclipsearch.Size = New System.Drawing.Size(76, 25)
        Me.cmdclipsearch.TabIndex = 176
        Me.cmdclipsearch.Text = "Search Clips"
        Me.cmdclipsearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtsearch", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtsearch.Location = New System.Drawing.Point(271, 9)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(70, 20)
        Me.txtsearch.TabIndex = 175
        Me.txtsearch.Text = Global.caspar_media_playback.My.MySettings.Default.txtsearch
        '
        'ucClipGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.gbcliplist)
        Me.Name = "ucClipGrid"
        Me.Size = New System.Drawing.Size(703, 343)
        Me.gbcliplist.ResumeLayout(False)
        Me.gbcliplist.PerformLayout()
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
    Friend WithEvents cmbChannelDestination As ComboBox
    Friend WithEvents cmdLoadinSMPlayer As Button
End Class
