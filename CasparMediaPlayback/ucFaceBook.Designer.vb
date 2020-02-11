<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucFaceBook
    'Inherits System.Windows.Forms.UserControl
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbfacebook = New System.Windows.Forms.GroupBox()
        Me.pbfacebook = New System.Windows.Forms.ProgressBar()
        Me.dgvfacebook = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmblayerfacebook = New System.Windows.Forms.ComboBox()
        Me.Label146 = New System.Windows.Forms.Label()
        Me.cmdplayfacebook = New System.Windows.Forms.Button()
        Me.cmdnextstepfacebook = New System.Windows.Forms.Button()
        Me.cmdstopfacebook = New System.Windows.Forms.Button()
        Me.Label142 = New System.Windows.Forms.Label()
        Me.txtgraphfacebook = New System.Windows.Forms.TextBox()
        Me.Label143 = New System.Windows.Forms.Label()
        Me.txtquery = New System.Windows.Forms.TextBox()
        Me.Label144 = New System.Windows.Forms.Label()
        Me.cmdreadkeyforfacebook = New System.Windows.Forms.Button()
        Me.txtaccesstoken = New System.Windows.Forms.TextBox()
        Me.cmdsearchqueryfacebook = New System.Windows.Forms.Button()
        Me.bwfacebook = New System.ComponentModel.BackgroundWorker()
        Me.gbfacebook.SuspendLayout()
        CType(Me.dgvfacebook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbfacebook
        '
        Me.gbfacebook.BackColor = System.Drawing.Color.CornflowerBlue
        Me.gbfacebook.Controls.Add(Me.pbfacebook)
        Me.gbfacebook.Controls.Add(Me.dgvfacebook)
        Me.gbfacebook.Controls.Add(Me.cmblayerfacebook)
        Me.gbfacebook.Controls.Add(Me.Label146)
        Me.gbfacebook.Controls.Add(Me.cmdplayfacebook)
        Me.gbfacebook.Controls.Add(Me.cmdnextstepfacebook)
        Me.gbfacebook.Controls.Add(Me.cmdstopfacebook)
        Me.gbfacebook.Controls.Add(Me.Label142)
        Me.gbfacebook.Controls.Add(Me.txtgraphfacebook)
        Me.gbfacebook.Controls.Add(Me.Label143)
        Me.gbfacebook.Controls.Add(Me.txtquery)
        Me.gbfacebook.Controls.Add(Me.Label144)
        Me.gbfacebook.Controls.Add(Me.cmdreadkeyforfacebook)
        Me.gbfacebook.Controls.Add(Me.txtaccesstoken)
        Me.gbfacebook.Controls.Add(Me.cmdsearchqueryfacebook)
        Me.gbfacebook.Location = New System.Drawing.Point(3, 5)
        Me.gbfacebook.Name = "gbfacebook"
        Me.gbfacebook.Size = New System.Drawing.Size(660, 605)
        Me.gbfacebook.TabIndex = 622
        Me.gbfacebook.TabStop = False
        Me.gbfacebook.Text = " "
        '
        'pbfacebook
        '
        Me.pbfacebook.Location = New System.Drawing.Point(66, 89)
        Me.pbfacebook.Name = "pbfacebook"
        Me.pbfacebook.Size = New System.Drawing.Size(234, 17)
        Me.pbfacebook.TabIndex = 727
        '
        'dgvfacebook
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvfacebook.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvfacebook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvfacebook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn3, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn8})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvfacebook.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvfacebook.Location = New System.Drawing.Point(9, 109)
        Me.dgvfacebook.Name = "dgvfacebook"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvfacebook.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvfacebook.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvfacebook.Size = New System.Drawing.Size(647, 490)
        Me.dgvfacebook.TabIndex = 534
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.HeaderText = "Image"
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn35
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn35.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn35.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn36.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn36.HeaderText = "Comment"
        Me.DataGridViewTextBoxColumn36.MinimumWidth = 375
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.Width = 375
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "imagelocation"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 5
        '
        'cmblayerfacebook
        '
        Me.cmblayerfacebook.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmblayerfacebook", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmblayerfacebook.FormattingEnabled = True
        Me.cmblayerfacebook.Items.AddRange(New Object() {"86", "87", "88", "89", "90"})
        Me.cmblayerfacebook.Location = New System.Drawing.Point(432, 82)
        Me.cmblayerfacebook.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmblayerfacebook.Name = "cmblayerfacebook"
        Me.cmblayerfacebook.Size = New System.Drawing.Size(47, 21)
        Me.cmblayerfacebook.TabIndex = 533
        Me.cmblayerfacebook.Text = Global.caspar_media_playback.My.MySettings.Default.cmblayerfacebook
        '
        'Label146
        '
        Me.Label146.AutoSize = True
        Me.Label146.Location = New System.Drawing.Point(318, 86)
        Me.Label146.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label146.Name = "Label146"
        Me.Label146.Size = New System.Drawing.Size(108, 13)
        Me.Label146.TabIndex = 532
        Me.Label146.Text = "video layer-flash layer"
        '
        'cmdplayfacebook
        '
        Me.cmdplayfacebook.Location = New System.Drawing.Point(498, 76)
        Me.cmdplayfacebook.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdplayfacebook.Name = "cmdplayfacebook"
        Me.cmdplayfacebook.Size = New System.Drawing.Size(36, 30)
        Me.cmdplayfacebook.TabIndex = 528
        Me.cmdplayfacebook.Text = "Play"
        Me.cmdplayfacebook.UseVisualStyleBackColor = True
        '
        'cmdnextstepfacebook
        '
        Me.cmdnextstepfacebook.Location = New System.Drawing.Point(538, 76)
        Me.cmdnextstepfacebook.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdnextstepfacebook.Name = "cmdnextstepfacebook"
        Me.cmdnextstepfacebook.Size = New System.Drawing.Size(66, 30)
        Me.cmdnextstepfacebook.TabIndex = 530
        Me.cmdnextstepfacebook.Text = "Next Step"
        Me.cmdnextstepfacebook.UseVisualStyleBackColor = True
        '
        'cmdstopfacebook
        '
        Me.cmdstopfacebook.Location = New System.Drawing.Point(608, 76)
        Me.cmdstopfacebook.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdstopfacebook.Name = "cmdstopfacebook"
        Me.cmdstopfacebook.Size = New System.Drawing.Size(39, 30)
        Me.cmdstopfacebook.TabIndex = 529
        Me.cmdstopfacebook.Text = "Stop"
        Me.cmdstopfacebook.UseVisualStyleBackColor = True
        '
        'Label142
        '
        Me.Label142.AutoSize = True
        Me.Label142.Location = New System.Drawing.Point(10, 91)
        Me.Label142.Name = "Label142"
        Me.Label142.Size = New System.Drawing.Size(55, 13)
        Me.Label142.TabIndex = 23
        Me.Label142.Text = "Response"
        '
        'txtgraphfacebook
        '
        Me.txtgraphfacebook.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtgraphfacebook", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtgraphfacebook.Location = New System.Drawing.Point(78, 19)
        Me.txtgraphfacebook.Name = "txtgraphfacebook"
        Me.txtgraphfacebook.Size = New System.Drawing.Size(167, 20)
        Me.txtgraphfacebook.TabIndex = 7
        Me.txtgraphfacebook.Text = Global.caspar_media_playback.My.MySettings.Default.txtgraphfacebook
        '
        'Label143
        '
        Me.Label143.AutoSize = True
        Me.Label143.Location = New System.Drawing.Point(19, 21)
        Me.Label143.Name = "Label143"
        Me.Label143.Size = New System.Drawing.Size(33, 13)
        Me.Label143.TabIndex = 5
        Me.Label143.Text = "query"
        '
        'txtquery
        '
        Me.txtquery.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtquery", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtquery.Location = New System.Drawing.Point(251, 19)
        Me.txtquery.Name = "txtquery"
        Me.txtquery.Size = New System.Drawing.Size(305, 20)
        Me.txtquery.TabIndex = 4
        Me.txtquery.Text = Global.caspar_media_playback.My.MySettings.Default.txtquery
        '
        'Label144
        '
        Me.Label144.AutoSize = True
        Me.Label144.Location = New System.Drawing.Point(3, 45)
        Me.Label144.Name = "Label144"
        Me.Label144.Size = New System.Drawing.Size(74, 13)
        Me.Label144.TabIndex = 3
        Me.Label144.Text = "access_token"
        '
        'cmdreadkeyforfacebook
        '
        Me.cmdreadkeyforfacebook.Location = New System.Drawing.Point(6, 64)
        Me.cmdreadkeyforfacebook.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdreadkeyforfacebook.Name = "cmdreadkeyforfacebook"
        Me.cmdreadkeyforfacebook.Size = New System.Drawing.Size(107, 24)
        Me.cmdreadkeyforfacebook.TabIndex = 622
        Me.cmdreadkeyforfacebook.Text = "Read d:/key.txt"
        Me.cmdreadkeyforfacebook.UseVisualStyleBackColor = True
        '
        'txtaccesstoken
        '
        Me.txtaccesstoken.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtaccesstoken", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtaccesstoken.Location = New System.Drawing.Point(78, 43)
        Me.txtaccesstoken.Name = "txtaccesstoken"
        Me.txtaccesstoken.Size = New System.Drawing.Size(478, 20)
        Me.txtaccesstoken.TabIndex = 2
        Me.txtaccesstoken.Text = Global.caspar_media_playback.My.MySettings.Default.txtaccesstoken
        '
        'cmdsearchqueryfacebook
        '
        Me.cmdsearchqueryfacebook.Location = New System.Drawing.Point(562, 19)
        Me.cmdsearchqueryfacebook.Name = "cmdsearchqueryfacebook"
        Me.cmdsearchqueryfacebook.Size = New System.Drawing.Size(47, 46)
        Me.cmdsearchqueryfacebook.TabIndex = 1
        Me.cmdsearchqueryfacebook.Text = "search"
        Me.cmdsearchqueryfacebook.UseVisualStyleBackColor = True
        '
        'bwfacebook
        '
        Me.bwfacebook.WorkerSupportsCancellation = True
        '
        'ucFaceBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(668, 613)
        Me.Controls.Add(Me.gbfacebook)
        Me.HideOnClose = True
        Me.Name = "ucFaceBook"
        Me.Text = "FaceBook"
        Me.gbfacebook.ResumeLayout(False)
        Me.gbfacebook.PerformLayout()
        CType(Me.dgvfacebook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbfacebook As System.Windows.Forms.GroupBox
    Friend WithEvents pbfacebook As System.Windows.Forms.ProgressBar
    Friend WithEvents dgvfacebook As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmblayerfacebook As System.Windows.Forms.ComboBox
    Friend WithEvents Label146 As System.Windows.Forms.Label
    Friend WithEvents cmdplayfacebook As System.Windows.Forms.Button
    Friend WithEvents cmdnextstepfacebook As System.Windows.Forms.Button
    Friend WithEvents cmdstopfacebook As System.Windows.Forms.Button
    Friend WithEvents Label142 As System.Windows.Forms.Label
    Friend WithEvents txtgraphfacebook As System.Windows.Forms.TextBox
    Friend WithEvents Label143 As System.Windows.Forms.Label
    Friend WithEvents txtquery As System.Windows.Forms.TextBox
    Friend WithEvents Label144 As System.Windows.Forms.Label
    Friend WithEvents cmdreadkeyforfacebook As System.Windows.Forms.Button
    Friend WithEvents txtaccesstoken As System.Windows.Forms.TextBox
    Friend WithEvents cmdsearchqueryfacebook As System.Windows.Forms.Button
    Friend WithEvents bwfacebook As System.ComponentModel.BackgroundWorker

End Class
