<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucUtility
    Inherits System.Windows.Forms.UserControl
    'Inherits WeifenLuo.WinFormsUI.Docking.DockContent

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbutility = New System.Windows.Forms.GroupBox()
        Me.dgvutility = New System.Windows.Forms.DataGridView()
        Me.Paths = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vaue_Paths = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Open = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Openlattestfile = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbutility.SuspendLayout()
        CType(Me.dgvutility, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbutility
        '
        Me.gbutility.BackColor = System.Drawing.Color.Wheat
        Me.gbutility.Controls.Add(Me.dgvutility)
        Me.gbutility.Location = New System.Drawing.Point(2, 2)
        Me.gbutility.Name = "gbutility"
        Me.gbutility.Size = New System.Drawing.Size(622, 239)
        Me.gbutility.TabIndex = 608
        Me.gbutility.TabStop = False
        Me.gbutility.Text = "Utility"
        '
        'dgvutility
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvutility.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvutility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvutility.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Paths, Me.Vaue_Paths, Me.Open, Me.Openlattestfile})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvutility.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvutility.Location = New System.Drawing.Point(3, 2)
        Me.dgvutility.Name = "dgvutility"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvutility.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvutility.Size = New System.Drawing.Size(610, 231)
        Me.dgvutility.TabIndex = 655
        '
        'Paths
        '
        Me.Paths.HeaderText = "Paths"
        Me.Paths.Name = "Paths"
        Me.Paths.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Paths.Width = 70
        '
        'Vaue_Paths
        '
        Me.Vaue_Paths.HeaderText = "Value"
        Me.Vaue_Paths.Name = "Vaue_Paths"
        Me.Vaue_Paths.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Vaue_Paths.Width = 295
        '
        'Open
        '
        Me.Open.HeaderText = "Open Folder"
        Me.Open.Name = "Open"
        Me.Open.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Open.Text = "...."
        Me.Open.ToolTipText = "Click to Open"
        Me.Open.Width = 75
        '
        'Openlattestfile
        '
        Me.Openlattestfile.HeaderText = "Open Lattest File"
        Me.Openlattestfile.Name = "Openlattestfile"
        Me.Openlattestfile.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Openlattestfile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Openlattestfile.Width = 110
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Paths"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Value"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 295
        '
        'ucUtility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.gbutility)
        Me.Name = "ucUtility"
        Me.Size = New System.Drawing.Size(626, 239)
        Me.gbutility.ResumeLayout(False)
        CType(Me.dgvutility, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbutility As System.Windows.Forms.GroupBox
    Friend WithEvents dgvutility As System.Windows.Forms.DataGridView
    Friend WithEvents Paths As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vaue_Paths As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Open As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Openlattestfile As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
