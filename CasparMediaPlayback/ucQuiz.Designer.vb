<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucQuiz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucQuiz))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbquiz = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQuizTemplate = New System.Windows.Forms.TextBox()
        Me.cmdplayanswerquiz = New System.Windows.Forms.Button()
        Me.cmdpausetimerquiz = New System.Windows.Forms.Button()
        Me.cmdstoptimerquiz = New System.Windows.Forms.Button()
        Me.cmdplaytimerquiz = New System.Windows.Forms.Button()
        Me.cmbvideolayerquiz = New System.Windows.Forms.ComboBox()
        Me.cmdanswerquiz = New System.Windows.Forms.Button()
        Me.lblfilenamequiz = New System.Windows.Forms.Label()
        Me.cmdcutquiz = New System.Windows.Forms.Button()
        Me.cmdupquiz = New System.Windows.Forms.Button()
        Me.cmddownquiz = New System.Windows.Forms.Button()
        Me.cmdaddquiz = New System.Windows.Forms.Button()
        Me.dgvquiz = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cmdplayquiz = New System.Windows.Forms.Button()
        Me.cmdstopquiz = New System.Windows.Forms.Button()
        Me.Label195 = New System.Windows.Forms.Label()
        Me.gbquiz.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvquiz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbquiz
        '
        Me.gbquiz.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gbquiz.Controls.Add(Me.MenuStrip1)
        Me.gbquiz.Controls.Add(Me.Label3)
        Me.gbquiz.Controls.Add(Me.txtQuizTemplate)
        Me.gbquiz.Controls.Add(Me.cmdplayanswerquiz)
        Me.gbquiz.Controls.Add(Me.cmdpausetimerquiz)
        Me.gbquiz.Controls.Add(Me.cmdstoptimerquiz)
        Me.gbquiz.Controls.Add(Me.cmdplaytimerquiz)
        Me.gbquiz.Controls.Add(Me.cmbvideolayerquiz)
        Me.gbquiz.Controls.Add(Me.cmdanswerquiz)
        Me.gbquiz.Controls.Add(Me.lblfilenamequiz)
        Me.gbquiz.Controls.Add(Me.cmdcutquiz)
        Me.gbquiz.Controls.Add(Me.cmdupquiz)
        Me.gbquiz.Controls.Add(Me.cmddownquiz)
        Me.gbquiz.Controls.Add(Me.cmdaddquiz)
        Me.gbquiz.Controls.Add(Me.dgvquiz)
        Me.gbquiz.Controls.Add(Me.cmdplayquiz)
        Me.gbquiz.Controls.Add(Me.cmdstopquiz)
        Me.gbquiz.Controls.Add(Me.Label195)
        Me.gbquiz.Location = New System.Drawing.Point(3, 3)
        Me.gbquiz.Name = "gbquiz"
        Me.gbquiz.Size = New System.Drawing.Size(660, 605)
        Me.gbquiz.TabIndex = 714
        Me.gbquiz.TabStop = False
        Me.gbquiz.Text = " "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 80)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(84, 24)
        Me.MenuStrip1.TabIndex = 1181
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
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 1180
        Me.Label3.Text = "Template folder"
        '
        'txtQuizTemplate
        '
        Me.txtQuizTemplate.Location = New System.Drawing.Point(98, 19)
        Me.txtQuizTemplate.Name = "txtQuizTemplate"
        Me.txtQuizTemplate.Size = New System.Drawing.Size(226, 20)
        Me.txtQuizTemplate.TabIndex = 1179
        Me.txtQuizTemplate.Text = "cmp/quiz"
        '
        'cmdplayanswerquiz
        '
        Me.cmdplayanswerquiz.BackColor = System.Drawing.Color.Green
        Me.cmdplayanswerquiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplayanswerquiz.ForeColor = System.Drawing.Color.White
        Me.cmdplayanswerquiz.Location = New System.Drawing.Point(410, 81)
        Me.cmdplayanswerquiz.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdplayanswerquiz.Name = "cmdplayanswerquiz"
        Me.cmdplayanswerquiz.Size = New System.Drawing.Size(86, 30)
        Me.cmdplayanswerquiz.TabIndex = 718
        Me.cmdplayanswerquiz.Text = "Play Answer"
        Me.cmdplayanswerquiz.UseVisualStyleBackColor = False
        '
        'cmdpausetimerquiz
        '
        Me.cmdpausetimerquiz.BackColor = System.Drawing.Color.Yellow
        Me.cmdpausetimerquiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpausetimerquiz.Location = New System.Drawing.Point(481, 39)
        Me.cmdpausetimerquiz.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdpausetimerquiz.Name = "cmdpausetimerquiz"
        Me.cmdpausetimerquiz.Size = New System.Drawing.Size(51, 30)
        Me.cmdpausetimerquiz.TabIndex = 717
        Me.cmdpausetimerquiz.Text = "Pause"
        Me.cmdpausetimerquiz.UseVisualStyleBackColor = False
        '
        'cmdstoptimerquiz
        '
        Me.cmdstoptimerquiz.BackColor = System.Drawing.Color.Red
        Me.cmdstoptimerquiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstoptimerquiz.ForeColor = System.Drawing.Color.White
        Me.cmdstoptimerquiz.Location = New System.Drawing.Point(536, 39)
        Me.cmdstoptimerquiz.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdstoptimerquiz.Name = "cmdstoptimerquiz"
        Me.cmdstoptimerquiz.Size = New System.Drawing.Size(56, 30)
        Me.cmdstoptimerquiz.TabIndex = 716
        Me.cmdstoptimerquiz.Text = "Stop"
        Me.cmdstoptimerquiz.UseVisualStyleBackColor = False
        '
        'cmdplaytimerquiz
        '
        Me.cmdplaytimerquiz.BackColor = System.Drawing.Color.Green
        Me.cmdplaytimerquiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplaytimerquiz.ForeColor = System.Drawing.Color.White
        Me.cmdplaytimerquiz.Location = New System.Drawing.Point(395, 39)
        Me.cmdplaytimerquiz.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdplaytimerquiz.Name = "cmdplaytimerquiz"
        Me.cmdplaytimerquiz.Size = New System.Drawing.Size(81, 30)
        Me.cmdplaytimerquiz.TabIndex = 715
        Me.cmdplaytimerquiz.Text = "Play Timer"
        Me.cmdplaytimerquiz.UseVisualStyleBackColor = False
        '
        'cmbvideolayerquiz
        '
        Me.cmbvideolayerquiz.FormattingEnabled = True
        Me.cmbvideolayerquiz.Items.AddRange(New Object() {"301", "302", "303", "304", "305"})
        Me.cmbvideolayerquiz.Location = New System.Drawing.Point(519, 9)
        Me.cmbvideolayerquiz.Name = "cmbvideolayerquiz"
        Me.cmbvideolayerquiz.Size = New System.Drawing.Size(77, 21)
        Me.cmbvideolayerquiz.TabIndex = 714
        Me.cmbvideolayerquiz.Text = "301"
        '
        'cmdanswerquiz
        '
        Me.cmdanswerquiz.BackColor = System.Drawing.Color.Green
        Me.cmdanswerquiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdanswerquiz.ForeColor = System.Drawing.Color.White
        Me.cmdanswerquiz.Location = New System.Drawing.Point(499, 81)
        Me.cmdanswerquiz.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdanswerquiz.Name = "cmdanswerquiz"
        Me.cmdanswerquiz.Size = New System.Drawing.Size(93, 30)
        Me.cmdanswerquiz.TabIndex = 713
        Me.cmdanswerquiz.Text = "Show Answer"
        Me.cmdanswerquiz.UseVisualStyleBackColor = False
        '
        'lblfilenamequiz
        '
        Me.lblfilenamequiz.AutoSize = True
        Me.lblfilenamequiz.Location = New System.Drawing.Point(11, 61)
        Me.lblfilenamequiz.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfilenamequiz.Name = "lblfilenamequiz"
        Me.lblfilenamequiz.Size = New System.Drawing.Size(23, 13)
        Me.lblfilenamequiz.TabIndex = 712
        Me.lblfilenamequiz.Text = "File"
        '
        'cmdcutquiz
        '
        Me.cmdcutquiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcutquiz.Image = Global.caspar_media_playback.My.Resources.Resources.minus
        Me.cmdcutquiz.Location = New System.Drawing.Point(263, 82)
        Me.cmdcutquiz.Name = "cmdcutquiz"
        Me.cmdcutquiz.Size = New System.Drawing.Size(33, 22)
        Me.cmdcutquiz.TabIndex = 490
        Me.cmdcutquiz.UseVisualStyleBackColor = True
        '
        'cmdupquiz
        '
        Me.cmdupquiz.Image = CType(resources.GetObject("cmdupquiz.Image"), System.Drawing.Image)
        Me.cmdupquiz.Location = New System.Drawing.Point(157, 82)
        Me.cmdupquiz.Name = "cmdupquiz"
        Me.cmdupquiz.Size = New System.Drawing.Size(28, 23)
        Me.cmdupquiz.TabIndex = 488
        Me.cmdupquiz.UseVisualStyleBackColor = True
        '
        'cmddownquiz
        '
        Me.cmddownquiz.Image = CType(resources.GetObject("cmddownquiz.Image"), System.Drawing.Image)
        Me.cmddownquiz.Location = New System.Drawing.Point(185, 82)
        Me.cmddownquiz.Name = "cmddownquiz"
        Me.cmddownquiz.Size = New System.Drawing.Size(36, 23)
        Me.cmddownquiz.TabIndex = 489
        Me.cmddownquiz.UseVisualStyleBackColor = True
        '
        'cmdaddquiz
        '
        Me.cmdaddquiz.Image = CType(resources.GetObject("cmdaddquiz.Image"), System.Drawing.Image)
        Me.cmdaddquiz.Location = New System.Drawing.Point(221, 82)
        Me.cmdaddquiz.Name = "cmdaddquiz"
        Me.cmdaddquiz.Size = New System.Drawing.Size(41, 23)
        Me.cmdaddquiz.TabIndex = 487
        Me.cmdaddquiz.UseVisualStyleBackColor = True
        '
        'dgvquiz
        '
        Me.dgvquiz.AllowDrop = True
        Me.dgvquiz.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvquiz.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvquiz.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvquiz.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvquiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvquiz.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewCheckBoxColumn3})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvquiz.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvquiz.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvquiz.Location = New System.Drawing.Point(10, 117)
        Me.dgvquiz.MultiSelect = False
        Me.dgvquiz.Name = "dgvquiz"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvquiz.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvquiz.RowHeadersWidth = 25
        Me.dgvquiz.Size = New System.Drawing.Size(644, 482)
        Me.dgvquiz.TabIndex = 486
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.Frozen = True
        Me.DataGridViewTextBoxColumn16.HeaderText = "Quiz"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 350
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn16.Width = 500
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.FalseValue = "0"
        Me.DataGridViewCheckBoxColumn3.FillWeight = 20.0!
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Answer"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn3.TrueValue = "1"
        Me.DataGridViewCheckBoxColumn3.Width = 50
        '
        'cmdplayquiz
        '
        Me.cmdplayquiz.BackColor = System.Drawing.Color.Green
        Me.cmdplayquiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplayquiz.ForeColor = System.Drawing.Color.White
        Me.cmdplayquiz.Location = New System.Drawing.Point(303, 81)
        Me.cmdplayquiz.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdplayquiz.Name = "cmdplayquiz"
        Me.cmdplayquiz.Size = New System.Drawing.Size(105, 30)
        Me.cmdplayquiz.TabIndex = 434
        Me.cmdplayquiz.Text = "Play Question"
        Me.cmdplayquiz.UseVisualStyleBackColor = False
        '
        'cmdstopquiz
        '
        Me.cmdstopquiz.BackColor = System.Drawing.Color.Red
        Me.cmdstopquiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopquiz.ForeColor = System.Drawing.Color.White
        Me.cmdstopquiz.Location = New System.Drawing.Point(592, 81)
        Me.cmdstopquiz.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdstopquiz.Name = "cmdstopquiz"
        Me.cmdstopquiz.Size = New System.Drawing.Size(44, 30)
        Me.cmdstopquiz.TabIndex = 435
        Me.cmdstopquiz.Text = "Stop"
        Me.cmdstopquiz.UseVisualStyleBackColor = False
        '
        'Label195
        '
        Me.Label195.AutoSize = True
        Me.Label195.Location = New System.Drawing.Point(407, 12)
        Me.Label195.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label195.Name = "Label195"
        Me.Label195.Size = New System.Drawing.Size(108, 13)
        Me.Label195.TabIndex = 431
        Me.Label195.Text = "video layer-flash layer"
        '
        'ucQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(668, 612)
        Me.Controls.Add(Me.gbquiz)
        Me.HideOnClose = True
        Me.Name = "ucQuiz"
        Me.Text = "Quiz"
        Me.gbquiz.ResumeLayout(False)
        Me.gbquiz.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvquiz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbquiz As System.Windows.Forms.GroupBox
    Friend WithEvents cmdplayanswerquiz As System.Windows.Forms.Button
    Friend WithEvents cmdpausetimerquiz As System.Windows.Forms.Button
    Friend WithEvents cmdstoptimerquiz As System.Windows.Forms.Button
    Friend WithEvents cmdplaytimerquiz As System.Windows.Forms.Button
    Friend WithEvents cmbvideolayerquiz As System.Windows.Forms.ComboBox
    Friend WithEvents cmdanswerquiz As System.Windows.Forms.Button
    Friend WithEvents lblfilenamequiz As System.Windows.Forms.Label
    Friend WithEvents cmdcutquiz As System.Windows.Forms.Button
    Friend WithEvents cmdupquiz As System.Windows.Forms.Button
    Friend WithEvents cmddownquiz As System.Windows.Forms.Button
    Friend WithEvents cmdaddquiz As System.Windows.Forms.Button
    Friend WithEvents dgvquiz As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cmdplayquiz As System.Windows.Forms.Button
    Friend WithEvents cmdstopquiz As System.Windows.Forms.Button
    Friend WithEvents Label195 As System.Windows.Forms.Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQuizTemplate As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
End Class
