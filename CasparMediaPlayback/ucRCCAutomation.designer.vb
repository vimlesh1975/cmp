<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRCCAutomation
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
        Me.fsw1 = New System.IO.FileSystemWatcher()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtKeyImage = New System.Windows.Forms.TextBox()
        Me.txtKeyName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPageName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLayerNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdSend = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        CType(Me.fsw1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fsw1
        '
        Me.fsw1.EnableRaisingEvents = True
        Me.fsw1.SynchronizingObject = Me
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(1020, 38)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(108, 13)
        Me.LinkLabel1.TabIndex = 645
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://bit.ly/3jRrhDL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(899, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 20)
        Me.Label1.TabIndex = 646
        Me.Label1.Text = "Download software from here"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(915, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 20)
        Me.Label2.TabIndex = 648
        Me.Label2.Text = "Casparcg forum topic"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(933, 87)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(260, 13)
        Me.LinkLabel2.TabIndex = 647
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "https://casparcgforum.org/t/react-caspar-client/4375"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SeaShell
        Me.GroupBox2.Controls.Add(Me.cmdRefresh)
        Me.GroupBox2.Controls.Add(Me.dgv1)
        Me.GroupBox2.Controls.Add(Me.txtKeyImage)
        Me.GroupBox2.Controls.Add(Me.txtKeyName)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(558, 349)
        Me.GroupBox2.TabIndex = 650
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data"
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgv1.Location = New System.Drawing.Point(6, 37)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(547, 306)
        Me.dgv1.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 400
        '
        'txtKeyImage
        '
        Me.txtKeyImage.Location = New System.Drawing.Point(84, 11)
        Me.txtKeyImage.Name = "txtKeyImage"
        Me.txtKeyImage.Size = New System.Drawing.Size(38, 20)
        Me.txtKeyImage.TabIndex = 11
        Me.txtKeyImage.Text = "img1"
        '
        'txtKeyName
        '
        Me.txtKeyName.Location = New System.Drawing.Point(226, 11)
        Me.txtKeyName.Name = "txtKeyName"
        Me.txtKeyName.Size = New System.Drawing.Size(38, 20)
        Me.txtKeyName.TabIndex = 5
        Me.txtKeyName.Text = "f0"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.txtPageName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLayerNumber)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmdStop)
        Me.GroupBox1.Controls.Add(Me.cmdUpdate)
        Me.GroupBox1.Controls.Add(Me.cmdSend)
        Me.GroupBox1.Location = New System.Drawing.Point(576, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 332)
        Me.GroupBox1.TabIndex = 649
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Controls"
        '
        'txtPageName
        '
        Me.txtPageName.Location = New System.Drawing.Point(6, 99)
        Me.txtPageName.Name = "txtPageName"
        Me.txtPageName.Size = New System.Drawing.Size(89, 20)
        Me.txtPageName.TabIndex = 8
        Me.txtPageName.Text = "Imageandname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Page Name"
        '
        'txtLayerNumber
        '
        Me.txtLayerNumber.Location = New System.Drawing.Point(9, 41)
        Me.txtLayerNumber.Name = "txtLayerNumber"
        Me.txtLayerNumber.Size = New System.Drawing.Size(38, 20)
        Me.txtLayerNumber.TabIndex = 6
        Me.txtLayerNumber.Text = "96"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Layer Number"
        '
        'cmdStop
        '
        Me.cmdStop.Location = New System.Drawing.Point(6, 194)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(75, 23)
        Me.cmdStop.TabIndex = 3
        Me.cmdStop.Text = "Stop"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(6, 165)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(75, 23)
        Me.cmdUpdate.TabIndex = 2
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdSend
        '
        Me.cmdSend.Location = New System.Drawing.Point(6, 136)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.Size = New System.Drawing.Size(75, 23)
        Me.cmdSend.TabIndex = 0
        Me.cmdSend.Text = "Show"
        Me.cmdSend.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(274, 20)
        Me.Label5.TabIndex = 651
        Me.Label5.Text = "Check automation enable in RCC"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(289, 8)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(75, 23)
        Me.cmdRefresh.TabIndex = 14
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'ucRCCAutomation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 921)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.HideOnClose = True
        Me.Name = "ucRCCAutomation"
        Me.Text = "RCCAutomation"
        CType(Me.fsw1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fsw1 As IO.FileSystemWatcher
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents txtKeyImage As TextBox
    Friend WithEvents txtKeyName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPageName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLayerNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdStop As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdSend As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdRefresh As Button
End Class
