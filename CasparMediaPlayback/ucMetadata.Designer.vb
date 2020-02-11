<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMetadata
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbmetadata = New System.Windows.Forms.GroupBox()
        Me.lblfilenamemetadata = New System.Windows.Forms.Label()
        Me.Label238 = New System.Windows.Forms.Label()
        Me.cmdclearfieldmetadata = New System.Windows.Forms.Button()
        Me.cmdwritemetadata = New System.Windows.Forms.Button()
        Me.cmdreadmetadata = New System.Windows.Forms.Button()
        Me.dgvmetadata = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbmetadata.SuspendLayout()
        CType(Me.dgvmetadata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbmetadata
        '
        Me.gbmetadata.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbmetadata.Controls.Add(Me.lblfilenamemetadata)
        Me.gbmetadata.Controls.Add(Me.Label238)
        Me.gbmetadata.Controls.Add(Me.cmdclearfieldmetadata)
        Me.gbmetadata.Controls.Add(Me.cmdwritemetadata)
        Me.gbmetadata.Controls.Add(Me.cmdreadmetadata)
        Me.gbmetadata.Controls.Add(Me.dgvmetadata)
        Me.gbmetadata.Location = New System.Drawing.Point(4, 4)
        Me.gbmetadata.Name = "gbmetadata"
        Me.gbmetadata.Size = New System.Drawing.Size(660, 605)
        Me.gbmetadata.TabIndex = 1172
        Me.gbmetadata.TabStop = False
        Me.gbmetadata.Text = " "
        '
        'lblfilenamemetadata
        '
        Me.lblfilenamemetadata.AutoSize = True
        Me.lblfilenamemetadata.Location = New System.Drawing.Point(251, 18)
        Me.lblfilenamemetadata.Name = "lblfilenamemetadata"
        Me.lblfilenamemetadata.Size = New System.Drawing.Size(10, 13)
        Me.lblfilenamemetadata.TabIndex = 5
        Me.lblfilenamemetadata.Text = "."
        '
        'Label238
        '
        Me.Label238.AutoSize = True
        Me.Label238.Location = New System.Drawing.Point(191, 18)
        Me.Label238.Name = "Label238"
        Me.Label238.Size = New System.Drawing.Size(54, 13)
        Me.Label238.TabIndex = 4
        Me.Label238.Text = "File Name"
        '
        'cmdclearfieldmetadata
        '
        Me.cmdclearfieldmetadata.Location = New System.Drawing.Point(122, 12)
        Me.cmdclearfieldmetadata.Name = "cmdclearfieldmetadata"
        Me.cmdclearfieldmetadata.Size = New System.Drawing.Size(65, 23)
        Me.cmdclearfieldmetadata.TabIndex = 3
        Me.cmdclearfieldmetadata.Text = "Clear Field"
        Me.cmdclearfieldmetadata.UseVisualStyleBackColor = True
        '
        'cmdwritemetadata
        '
        Me.cmdwritemetadata.Location = New System.Drawing.Point(62, 13)
        Me.cmdwritemetadata.Name = "cmdwritemetadata"
        Me.cmdwritemetadata.Size = New System.Drawing.Size(58, 23)
        Me.cmdwritemetadata.TabIndex = 2
        Me.cmdwritemetadata.Text = "Write"
        Me.cmdwritemetadata.UseVisualStyleBackColor = True
        '
        'cmdreadmetadata
        '
        Me.cmdreadmetadata.Location = New System.Drawing.Point(6, 12)
        Me.cmdreadmetadata.Name = "cmdreadmetadata"
        Me.cmdreadmetadata.Size = New System.Drawing.Size(54, 23)
        Me.cmdreadmetadata.TabIndex = 1
        Me.cmdreadmetadata.Text = "Read"
        Me.cmdreadmetadata.UseVisualStyleBackColor = True
        '
        'dgvmetadata
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmetadata.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvmetadata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmetadata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvmetadata.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvmetadata.Location = New System.Drawing.Point(6, 42)
        Me.dgvmetadata.Name = "dgvmetadata"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmetadata.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvmetadata.Size = New System.Drawing.Size(648, 557)
        Me.dgvmetadata.TabIndex = 0
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Field"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 150
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Value"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 400
        '
        'ucMetadata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(668, 614)
        Me.Controls.Add(Me.gbmetadata)
        Me.HideOnClose = True
        Me.Name = "ucMetadata"
        Me.Text = "Metadata"
        Me.gbmetadata.ResumeLayout(False)
        Me.gbmetadata.PerformLayout()
        CType(Me.dgvmetadata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbmetadata As System.Windows.Forms.GroupBox
    Friend WithEvents lblfilenamemetadata As System.Windows.Forms.Label
    Friend WithEvents Label238 As System.Windows.Forms.Label
    Friend WithEvents cmdclearfieldmetadata As System.Windows.Forms.Button
    Friend WithEvents cmdwritemetadata As System.Windows.Forms.Button
    Friend WithEvents cmdreadmetadata As System.Windows.Forms.Button
    Friend WithEvents dgvmetadata As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
