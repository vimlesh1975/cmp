<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSrtPlayer
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbsrt = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSRTTemplate = New System.Windows.Forms.TextBox()
        Me.Label196 = New System.Windows.Forms.Label()
        Me.cmdsubstracttime = New System.Windows.Forms.Button()
        Me.cmdaddtime = New System.Windows.Forms.Button()
        Me.txtvtrstarttime = New System.Windows.Forms.TextBox()
        Me.Label191 = New System.Windows.Forms.Label()
        Me.txttemplateresponseframe = New System.Windows.Forms.TextBox()
        Me.cmdstopsrt = New System.Windows.Forms.Button()
        Me.cmdstartsrt = New System.Windows.Forms.Button()
        Me.lblfilenamesrt = New System.Windows.Forms.Label()
        Me.cmblayersrt = New System.Windows.Forms.ComboBox()
        Me.Label192 = New System.Windows.Forms.Label()
        Me.cmdopensrtfile = New System.Windows.Forms.Button()
        Me.dgvsrt = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tmrsrt = New System.Windows.Forms.Timer(Me.components)
        Me.gbsrt.SuspendLayout()
        CType(Me.dgvsrt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbsrt
        '
        Me.gbsrt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gbsrt.Controls.Add(Me.Label2)
        Me.gbsrt.Controls.Add(Me.txtSRTTemplate)
        Me.gbsrt.Controls.Add(Me.Label196)
        Me.gbsrt.Controls.Add(Me.cmdsubstracttime)
        Me.gbsrt.Controls.Add(Me.cmdaddtime)
        Me.gbsrt.Controls.Add(Me.txtvtrstarttime)
        Me.gbsrt.Controls.Add(Me.Label191)
        Me.gbsrt.Controls.Add(Me.txttemplateresponseframe)
        Me.gbsrt.Controls.Add(Me.cmdstopsrt)
        Me.gbsrt.Controls.Add(Me.cmdstartsrt)
        Me.gbsrt.Controls.Add(Me.lblfilenamesrt)
        Me.gbsrt.Controls.Add(Me.cmblayersrt)
        Me.gbsrt.Controls.Add(Me.Label192)
        Me.gbsrt.Controls.Add(Me.cmdopensrtfile)
        Me.gbsrt.Controls.Add(Me.dgvsrt)
        Me.gbsrt.Location = New System.Drawing.Point(5, 5)
        Me.gbsrt.Name = "gbsrt"
        Me.gbsrt.Size = New System.Drawing.Size(660, 605)
        Me.gbsrt.TabIndex = 1161
        Me.gbsrt.TabStop = False
        Me.gbsrt.Text = " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1171
        Me.Label2.Text = "Template"
        '
        'txtSRTTemplate
        '
        Me.txtSRTTemplate.Location = New System.Drawing.Point(70, 26)
        Me.txtSRTTemplate.Name = "txtSRTTemplate"
        Me.txtSRTTemplate.Size = New System.Drawing.Size(353, 20)
        Me.txtSRTTemplate.TabIndex = 1170
        Me.txtSRTTemplate.Text = "CMP/srt/srt1"
        '
        'Label196
        '
        Me.Label196.AutoSize = True
        Me.Label196.Location = New System.Drawing.Point(565, 58)
        Me.Label196.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label196.Name = "Label196"
        Me.Label196.Size = New System.Drawing.Size(59, 13)
        Me.Label196.TabIndex = 647
        Me.Label196.Text = "Adjustment"
        '
        'cmdsubstracttime
        '
        Me.cmdsubstracttime.Location = New System.Drawing.Point(597, 74)
        Me.cmdsubstracttime.Name = "cmdsubstracttime"
        Me.cmdsubstracttime.Size = New System.Drawing.Size(43, 23)
        Me.cmdsubstracttime.TabIndex = 646
        Me.cmdsubstracttime.Text = "-"
        Me.cmdsubstracttime.UseVisualStyleBackColor = True
        '
        'cmdaddtime
        '
        Me.cmdaddtime.Location = New System.Drawing.Point(553, 74)
        Me.cmdaddtime.Name = "cmdaddtime"
        Me.cmdaddtime.Size = New System.Drawing.Size(43, 23)
        Me.cmdaddtime.TabIndex = 645
        Me.cmdaddtime.Text = "+"
        Me.cmdaddtime.UseVisualStyleBackColor = True
        '
        'txtvtrstarttime
        '
        Me.txtvtrstarttime.Location = New System.Drawing.Point(557, 97)
        Me.txtvtrstarttime.Name = "txtvtrstarttime"
        Me.txtvtrstarttime.Size = New System.Drawing.Size(77, 20)
        Me.txtvtrstarttime.TabIndex = 644
        Me.txtvtrstarttime.Text = "00:00:01:00"
        '
        'Label191
        '
        Me.Label191.AutoSize = True
        Me.Label191.Location = New System.Drawing.Point(10, 99)
        Me.Label191.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label191.Name = "Label191"
        Me.Label191.Size = New System.Drawing.Size(128, 13)
        Me.Label191.TabIndex = 639
        Me.Label191.Text = "Template Response Time"
        '
        'txttemplateresponseframe
        '
        Me.txttemplateresponseframe.Location = New System.Drawing.Point(147, 95)
        Me.txttemplateresponseframe.Name = "txttemplateresponseframe"
        Me.txttemplateresponseframe.Size = New System.Drawing.Size(73, 20)
        Me.txttemplateresponseframe.TabIndex = 638
        Me.txttemplateresponseframe.Text = "00:00:00:00"
        '
        'cmdstopsrt
        '
        Me.cmdstopsrt.BackColor = System.Drawing.Color.Red
        Me.cmdstopsrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopsrt.ForeColor = System.Drawing.Color.White
        Me.cmdstopsrt.Location = New System.Drawing.Point(334, 74)
        Me.cmdstopsrt.Name = "cmdstopsrt"
        Me.cmdstopsrt.Size = New System.Drawing.Size(90, 46)
        Me.cmdstopsrt.TabIndex = 6
        Me.cmdstopsrt.Text = "Stop"
        Me.cmdstopsrt.UseVisualStyleBackColor = False
        '
        'cmdstartsrt
        '
        Me.cmdstartsrt.BackColor = System.Drawing.Color.Green
        Me.cmdstartsrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstartsrt.ForeColor = System.Drawing.Color.White
        Me.cmdstartsrt.Location = New System.Drawing.Point(238, 74)
        Me.cmdstartsrt.Name = "cmdstartsrt"
        Me.cmdstartsrt.Size = New System.Drawing.Size(90, 46)
        Me.cmdstartsrt.TabIndex = 5
        Me.cmdstartsrt.Text = "Start"
        Me.cmdstartsrt.UseVisualStyleBackColor = False
        '
        'lblfilenamesrt
        '
        Me.lblfilenamesrt.AutoSize = True
        Me.lblfilenamesrt.Location = New System.Drawing.Point(67, 65)
        Me.lblfilenamesrt.Name = "lblfilenamesrt"
        Me.lblfilenamesrt.Size = New System.Drawing.Size(54, 13)
        Me.lblfilenamesrt.TabIndex = 4
        Me.lblfilenamesrt.Text = "File Name"
        '
        'cmblayersrt
        '
        Me.cmblayersrt.FormattingEnabled = True
        Me.cmblayersrt.Items.AddRange(New Object() {"400", "401", "402", "403", "404"})
        Me.cmblayersrt.Location = New System.Drawing.Point(576, 23)
        Me.cmblayersrt.Name = "cmblayersrt"
        Me.cmblayersrt.Size = New System.Drawing.Size(43, 21)
        Me.cmblayersrt.TabIndex = 3
        Me.cmblayersrt.Text = "400"
        '
        'Label192
        '
        Me.Label192.AutoSize = True
        Me.Label192.Location = New System.Drawing.Point(533, 26)
        Me.Label192.Name = "Label192"
        Me.Label192.Size = New System.Drawing.Size(35, 13)
        Me.Label192.TabIndex = 2
        Me.Label192.Text = "VL-FL"
        '
        'cmdopensrtfile
        '
        Me.cmdopensrtfile.Location = New System.Drawing.Point(4, 60)
        Me.cmdopensrtfile.Name = "cmdopensrtfile"
        Me.cmdopensrtfile.Size = New System.Drawing.Size(57, 23)
        Me.cmdopensrtfile.TabIndex = 0
        Me.cmdopensrtfile.Text = "Open file"
        Me.cmdopensrtfile.UseVisualStyleBackColor = True
        '
        'dgvsrt
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsrt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvsrt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsrt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvsrt.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvsrt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvsrt.Location = New System.Drawing.Point(6, 126)
        Me.dgvsrt.Name = "dgvsrt"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsrt.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvsrt.Size = New System.Drawing.Size(648, 473)
        Me.dgvsrt.TabIndex = 1
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "SN"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 40
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn17.Width = 40
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Start"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 70
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn18.Width = 70
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "End"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 70
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn19.Width = 70
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "1st Line"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn20.Width = 300
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.HeaderText = "2nd line"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'tmrsrt
        '
        Me.tmrsrt.Interval = 1000
        '
        'ucSrtPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(669, 613)
        Me.Controls.Add(Me.gbsrt)
        Me.HideOnClose = True
        Me.Name = "ucSrtPlayer"
        Me.Text = "SRT Player"
        Me.gbsrt.ResumeLayout(False)
        Me.gbsrt.PerformLayout()
        CType(Me.dgvsrt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbsrt As System.Windows.Forms.GroupBox
    Friend WithEvents Label196 As System.Windows.Forms.Label
    Friend WithEvents cmdsubstracttime As System.Windows.Forms.Button
    Friend WithEvents cmdaddtime As System.Windows.Forms.Button
    Friend WithEvents txtvtrstarttime As System.Windows.Forms.TextBox
    Friend WithEvents Label191 As System.Windows.Forms.Label
    Friend WithEvents txttemplateresponseframe As System.Windows.Forms.TextBox
    Friend WithEvents cmdstopsrt As System.Windows.Forms.Button
    Friend WithEvents cmdstartsrt As System.Windows.Forms.Button
    Friend WithEvents lblfilenamesrt As System.Windows.Forms.Label
    Friend WithEvents cmblayersrt As System.Windows.Forms.ComboBox
    Friend WithEvents Label192 As System.Windows.Forms.Label
    Friend WithEvents cmdopensrtfile As System.Windows.Forms.Button
    Private WithEvents dgvsrt As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tmrsrt As System.Windows.Forms.Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSRTTemplate As TextBox
End Class
