<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMySqlTest
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
        Me.cmdFillTablenames = New System.Windows.Forms.Button()
        Me.cmbTables = New System.Windows.Forms.ComboBox()
        Me.dgvContents = New System.Windows.Forms.DataGridView()
        Me.cmdShowContents = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdsetserver = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkIntegratedSecurity = New System.Windows.Forms.CheckBox()
        Me.txtInsert = New System.Windows.Forms.TextBox()
        Me.txtUpdate = New System.Windows.Forms.TextBox()
        Me.txtDelete = New System.Windows.Forms.TextBox()
        Me.cmdInsert = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdAny = New System.Windows.Forms.Button()
        Me.txtAnyCommand = New System.Windows.Forms.TextBox()
        Me.cmdShowincasparcg = New System.Windows.Forms.Button()
        Me.lbllayerhtml = New System.Windows.Forms.Label()
        Me.cmdStopSqlLayer = New System.Windows.Forms.Button()
        Me.chkAllRow = New System.Windows.Forms.CheckBox()
        Me.chkAllColumns = New System.Windows.Forms.CheckBox()
        Me.txtrows = New System.Windows.Forms.TextBox()
        Me.txtcolumns = New System.Windows.Forms.TextBox()
        Me.nFontSizesql = New System.Windows.Forms.NumericUpDown()
        Me.FontSizesql = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdfontcolorsql = New System.Windows.Forms.Button()
        Me.Label162 = New System.Windows.Forms.Label()
        Me.cmdbgcolorsql = New System.Windows.Forms.Button()
        Me.cmbfontsql = New System.Windows.Forms.ComboBox()
        Me.Label160 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdSetServerMySql = New System.Windows.Forms.Button()
        Me.txtdatabasemysql = New System.Windows.Forms.TextBox()
        Me.txtpasswordMysql = New System.Windows.Forms.TextBox()
        Me.txtusemysql = New System.Windows.Forms.TextBox()
        Me.txtservermysql = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtport = New System.Windows.Forms.TextBox()
        Me.cmblayerSqlhtml = New System.Windows.Forms.ComboBox()
        Me.txtdatabase = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtserver = New System.Windows.Forms.TextBox()
        CType(Me.dgvContents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nFontSizesql, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdFillTablenames
        '
        Me.cmdFillTablenames.Location = New System.Drawing.Point(7, 396)
        Me.cmdFillTablenames.Name = "cmdFillTablenames"
        Me.cmdFillTablenames.Size = New System.Drawing.Size(105, 23)
        Me.cmdFillTablenames.TabIndex = 19
        Me.cmdFillTablenames.Text = "Get Table Names"
        Me.cmdFillTablenames.UseVisualStyleBackColor = True
        '
        'cmbTables
        '
        Me.cmbTables.FormattingEnabled = True
        Me.cmbTables.Location = New System.Drawing.Point(122, 398)
        Me.cmbTables.Name = "cmbTables"
        Me.cmbTables.Size = New System.Drawing.Size(171, 21)
        Me.cmbTables.TabIndex = 18
        '
        'dgvContents
        '
        Me.dgvContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContents.Location = New System.Drawing.Point(10, 479)
        Me.dgvContents.Name = "dgvContents"
        Me.dgvContents.Size = New System.Drawing.Size(1180, 393)
        Me.dgvContents.TabIndex = 17
        '
        'cmdShowContents
        '
        Me.cmdShowContents.Location = New System.Drawing.Point(7, 447)
        Me.cmdShowContents.Name = "cmdShowContents"
        Me.cmdShowContents.Size = New System.Drawing.Size(146, 23)
        Me.cmdShowContents.TabIndex = 16
        Me.cmdShowContents.Text = "Show Contenets of Tables"
        Me.cmdShowContents.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Port"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Database"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Server"
        '
        'cmdsetserver
        '
        Me.cmdsetserver.Location = New System.Drawing.Point(202, 19)
        Me.cmdsetserver.Name = "cmdsetserver"
        Me.cmdsetserver.Size = New System.Drawing.Size(46, 94)
        Me.cmdsetserver.TabIndex = 4
        Me.cmdsetserver.Text = "Set Server"
        Me.cmdsetserver.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.chkIntegratedSecurity)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtdatabase)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.txtuser)
        Me.GroupBox1.Controls.Add(Me.txtserver)
        Me.GroupBox1.Controls.Add(Me.cmdsetserver)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 161)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SQL Settings"
        '
        'chkIntegratedSecurity
        '
        Me.chkIntegratedSecurity.AutoSize = True
        Me.chkIntegratedSecurity.Checked = True
        Me.chkIntegratedSecurity.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIntegratedSecurity.Location = New System.Drawing.Point(59, 128)
        Me.chkIntegratedSecurity.Name = "chkIntegratedSecurity"
        Me.chkIntegratedSecurity.Size = New System.Drawing.Size(115, 17)
        Me.chkIntegratedSecurity.TabIndex = 14
        Me.chkIntegratedSecurity.Text = "Integrated Security"
        Me.chkIntegratedSecurity.UseVisualStyleBackColor = True
        '
        'txtInsert
        '
        Me.txtInsert.Location = New System.Drawing.Point(303, 46)
        Me.txtInsert.Multiline = True
        Me.txtInsert.Name = "txtInsert"
        Me.txtInsert.Size = New System.Drawing.Size(551, 71)
        Me.txtInsert.TabIndex = 712
        Me.txtInsert.Text = "insert into clients (ipfrom, ipto) values (3,5)"
        '
        'txtUpdate
        '
        Me.txtUpdate.Location = New System.Drawing.Point(303, 123)
        Me.txtUpdate.Multiline = True
        Me.txtUpdate.Name = "txtUpdate"
        Me.txtUpdate.Size = New System.Drawing.Size(551, 71)
        Me.txtUpdate.TabIndex = 713
        Me.txtUpdate.Text = "update clients set ipfrom=15 where ipto=5"
        '
        'txtDelete
        '
        Me.txtDelete.Location = New System.Drawing.Point(303, 200)
        Me.txtDelete.Multiline = True
        Me.txtDelete.Name = "txtDelete"
        Me.txtDelete.Size = New System.Drawing.Size(551, 71)
        Me.txtDelete.TabIndex = 714
        Me.txtDelete.Text = "delete from clients where ipto=5"
        '
        'cmdInsert
        '
        Me.cmdInsert.Location = New System.Drawing.Point(860, 62)
        Me.cmdInsert.Name = "cmdInsert"
        Me.cmdInsert.Size = New System.Drawing.Size(63, 35)
        Me.cmdInsert.TabIndex = 15
        Me.cmdInsert.Text = "Insert Command"
        Me.cmdInsert.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(860, 137)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(63, 35)
        Me.cmdUpdate.TabIndex = 715
        Me.cmdUpdate.Text = "Update Command"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(860, 214)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(63, 35)
        Me.cmdDelete.TabIndex = 716
        Me.cmdDelete.Text = "Delete Command"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdAny
        '
        Me.cmdAny.Location = New System.Drawing.Point(860, 298)
        Me.cmdAny.Name = "cmdAny"
        Me.cmdAny.Size = New System.Drawing.Size(63, 35)
        Me.cmdAny.TabIndex = 718
        Me.cmdAny.Text = "Any Command"
        Me.cmdAny.UseVisualStyleBackColor = True
        '
        'txtAnyCommand
        '
        Me.txtAnyCommand.Location = New System.Drawing.Point(303, 280)
        Me.txtAnyCommand.Multiline = True
        Me.txtAnyCommand.Name = "txtAnyCommand"
        Me.txtAnyCommand.Size = New System.Drawing.Size(551, 71)
        Me.txtAnyCommand.TabIndex = 717
        '
        'cmdShowincasparcg
        '
        Me.cmdShowincasparcg.BackColor = System.Drawing.Color.Green
        Me.cmdShowincasparcg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdShowincasparcg.ForeColor = System.Drawing.Color.White
        Me.cmdShowincasparcg.Location = New System.Drawing.Point(953, 434)
        Me.cmdShowincasparcg.Name = "cmdShowincasparcg"
        Me.cmdShowincasparcg.Size = New System.Drawing.Size(156, 36)
        Me.cmdShowincasparcg.TabIndex = 719
        Me.cmdShowincasparcg.Text = "Show in Caspacrg by HTML Template"
        Me.cmdShowincasparcg.UseVisualStyleBackColor = False
        '
        'lbllayerhtml
        '
        Me.lbllayerhtml.AutoSize = True
        Me.lbllayerhtml.Location = New System.Drawing.Point(1078, 9)
        Me.lbllayerhtml.Name = "lbllayerhtml"
        Me.lbllayerhtml.Size = New System.Drawing.Size(33, 13)
        Me.lbllayerhtml.TabIndex = 720
        Me.lbllayerhtml.Text = "Layer"
        '
        'cmdStopSqlLayer
        '
        Me.cmdStopSqlLayer.BackColor = System.Drawing.Color.Red
        Me.cmdStopSqlLayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStopSqlLayer.ForeColor = System.Drawing.Color.White
        Me.cmdStopSqlLayer.Location = New System.Drawing.Point(1115, 434)
        Me.cmdStopSqlLayer.Name = "cmdStopSqlLayer"
        Me.cmdStopSqlLayer.Size = New System.Drawing.Size(75, 36)
        Me.cmdStopSqlLayer.TabIndex = 722
        Me.cmdStopSqlLayer.Text = "Stop"
        Me.cmdStopSqlLayer.UseVisualStyleBackColor = False
        '
        'chkAllRow
        '
        Me.chkAllRow.AutoSize = True
        Me.chkAllRow.Location = New System.Drawing.Point(676, 451)
        Me.chkAllRow.Name = "chkAllRow"
        Me.chkAllRow.Size = New System.Drawing.Size(67, 17)
        Me.chkAllRow.TabIndex = 723
        Me.chkAllRow.Text = "All Rows"
        Me.chkAllRow.UseVisualStyleBackColor = True
        '
        'chkAllColumns
        '
        Me.chkAllColumns.AutoSize = True
        Me.chkAllColumns.Location = New System.Drawing.Point(823, 450)
        Me.chkAllColumns.Name = "chkAllColumns"
        Me.chkAllColumns.Size = New System.Drawing.Size(80, 17)
        Me.chkAllColumns.TabIndex = 724
        Me.chkAllColumns.Text = "All Columns"
        Me.chkAllColumns.UseVisualStyleBackColor = True
        '
        'txtrows
        '
        Me.txtrows.Location = New System.Drawing.Point(749, 450)
        Me.txtrows.Name = "txtrows"
        Me.txtrows.Size = New System.Drawing.Size(38, 20)
        Me.txtrows.TabIndex = 725
        Me.txtrows.Text = "4"
        '
        'txtcolumns
        '
        Me.txtcolumns.Location = New System.Drawing.Point(909, 447)
        Me.txtcolumns.Name = "txtcolumns"
        Me.txtcolumns.Size = New System.Drawing.Size(38, 20)
        Me.txtcolumns.TabIndex = 726
        Me.txtcolumns.Text = "4"
        '
        'nFontSizesql
        '
        Me.nFontSizesql.Location = New System.Drawing.Point(594, 449)
        Me.nFontSizesql.Name = "nFontSizesql"
        Me.nFontSizesql.Size = New System.Drawing.Size(58, 20)
        Me.nFontSizesql.TabIndex = 727
        Me.nFontSizesql.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'FontSizesql
        '
        Me.FontSizesql.AutoSize = True
        Me.FontSizesql.Location = New System.Drawing.Point(591, 431)
        Me.FontSizesql.Name = "FontSizesql"
        Me.FontSizesql.Size = New System.Drawing.Size(51, 13)
        Me.FontSizesql.TabIndex = 728
        Me.FontSizesql.Text = "Font Size"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(284, 431)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 746
        Me.Label7.Text = "font color"
        '
        'cmdfontcolorsql
        '
        Me.cmdfontcolorsql.BackColor = System.Drawing.Color.Purple
        Me.cmdfontcolorsql.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdfontcolorsql.ForeColor = System.Drawing.Color.Yellow
        Me.cmdfontcolorsql.Location = New System.Drawing.Point(276, 450)
        Me.cmdfontcolorsql.Name = "cmdfontcolorsql"
        Me.cmdfontcolorsql.Size = New System.Drawing.Size(59, 23)
        Me.cmdfontcolorsql.TabIndex = 745
        Me.cmdfontcolorsql.Text = "Color"
        Me.cmdfontcolorsql.UseVisualStyleBackColor = False
        '
        'Label162
        '
        Me.Label162.AutoSize = True
        Me.Label162.Location = New System.Drawing.Point(151, 431)
        Me.Label162.Name = "Label162"
        Me.Label162.Size = New System.Drawing.Size(93, 13)
        Me.Label162.TabIndex = 743
        Me.Label162.Text = "BackGround color"
        '
        'cmdbgcolorsql
        '
        Me.cmdbgcolorsql.BackColor = System.Drawing.Color.Purple
        Me.cmdbgcolorsql.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdbgcolorsql.ForeColor = System.Drawing.Color.Yellow
        Me.cmdbgcolorsql.Location = New System.Drawing.Point(174, 446)
        Me.cmdbgcolorsql.Name = "cmdbgcolorsql"
        Me.cmdbgcolorsql.Size = New System.Drawing.Size(59, 23)
        Me.cmdbgcolorsql.TabIndex = 744
        Me.cmdbgcolorsql.Text = "color"
        Me.cmdbgcolorsql.UseVisualStyleBackColor = False
        '
        'cmbfontsql
        '
        Me.cmbfontsql.FormattingEnabled = True
        Me.cmbfontsql.Location = New System.Drawing.Point(381, 450)
        Me.cmbfontsql.Name = "cmbfontsql"
        Me.cmbfontsql.Size = New System.Drawing.Size(173, 21)
        Me.cmbfontsql.TabIndex = 749
        Me.cmbfontsql.Text = "DVOT-Bhima"
        '
        'Label160
        '
        Me.Label160.AutoSize = True
        Me.Label160.Location = New System.Drawing.Point(393, 431)
        Me.Label160.Name = "Label160"
        Me.Label160.Size = New System.Drawing.Size(28, 13)
        Me.Label160.TabIndex = 748
        Me.Label160.Text = "Font"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmdSetServerMySql)
        Me.GroupBox2.Controls.Add(Me.txtport)
        Me.GroupBox2.Controls.Add(Me.txtdatabasemysql)
        Me.GroupBox2.Controls.Add(Me.txtpasswordMysql)
        Me.GroupBox2.Controls.Add(Me.txtusemysql)
        Me.GroupBox2.Controls.Add(Me.txtservermysql)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 188)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 151)
        Me.GroupBox2.TabIndex = 750
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MySql Setting"
        '
        'cmdSetServerMySql
        '
        Me.cmdSetServerMySql.Location = New System.Drawing.Point(201, 18)
        Me.cmdSetServerMySql.Name = "cmdSetServerMySql"
        Me.cmdSetServerMySql.Size = New System.Drawing.Size(46, 120)
        Me.cmdSetServerMySql.TabIndex = 18
        Me.cmdSetServerMySql.Text = "Set Server"
        Me.cmdSetServerMySql.UseVisualStyleBackColor = True
        '
        'txtdatabasemysql
        '
        Me.txtdatabasemysql.Location = New System.Drawing.Point(60, 92)
        Me.txtdatabasemysql.Name = "txtdatabasemysql"
        Me.txtdatabasemysql.Size = New System.Drawing.Size(137, 20)
        Me.txtdatabasemysql.TabIndex = 22
        Me.txtdatabasemysql.Text = "cmp"
        '
        'txtpasswordMysql
        '
        Me.txtpasswordMysql.Location = New System.Drawing.Point(60, 66)
        Me.txtpasswordMysql.Name = "txtpasswordMysql"
        Me.txtpasswordMysql.Size = New System.Drawing.Size(137, 20)
        Me.txtpasswordMysql.TabIndex = 21
        Me.txtpasswordMysql.Text = "root"
        '
        'txtusemysql
        '
        Me.txtusemysql.Location = New System.Drawing.Point(60, 41)
        Me.txtusemysql.Name = "txtusemysql"
        Me.txtusemysql.Size = New System.Drawing.Size(137, 20)
        Me.txtusemysql.TabIndex = 20
        Me.txtusemysql.Text = "root"
        '
        'txtservermysql
        '
        Me.txtservermysql.Location = New System.Drawing.Point(60, 18)
        Me.txtservermysql.Name = "txtservermysql"
        Me.txtservermysql.Size = New System.Drawing.Size(137, 20)
        Me.txtservermysql.TabIndex = 19
        Me.txtservermysql.Text = "localhost"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "User"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Database"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Server"
        '
        'txtport
        '
        Me.txtport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtsqlport", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtport.Location = New System.Drawing.Point(60, 118)
        Me.txtport.Name = "txtport"
        Me.txtport.Size = New System.Drawing.Size(137, 20)
        Me.txtport.TabIndex = 13
        Me.txtport.Text = Global.caspar_media_playback.My.MySettings.Default.txtsqlport
        '
        'cmblayerSqlhtml
        '
        Me.cmblayerSqlhtml.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmblayerSqlhtml", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmblayerSqlhtml.FormattingEnabled = True
        Me.cmblayerSqlhtml.Items.AddRange(New Object() {"201", "202", "203", "204", "205"})
        Me.cmblayerSqlhtml.Location = New System.Drawing.Point(1118, 9)
        Me.cmblayerSqlhtml.Name = "cmblayerSqlhtml"
        Me.cmblayerSqlhtml.Size = New System.Drawing.Size(72, 21)
        Me.cmblayerSqlhtml.TabIndex = 721
        Me.cmblayerSqlhtml.Text = Global.caspar_media_playback.My.MySettings.Default.cmblayerSqlhtml
        '
        'txtdatabase
        '
        Me.txtdatabase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtsqldatabase", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtdatabase.Location = New System.Drawing.Point(59, 93)
        Me.txtdatabase.Name = "txtdatabase"
        Me.txtdatabase.Size = New System.Drawing.Size(137, 20)
        Me.txtdatabase.TabIndex = 8
        Me.txtdatabase.Text = Global.caspar_media_playback.My.MySettings.Default.txtsqldatabase
        '
        'txtpassword
        '
        Me.txtpassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtsqlpassword", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtpassword.Location = New System.Drawing.Point(59, 68)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(137, 20)
        Me.txtpassword.TabIndex = 7
        Me.txtpassword.Text = Global.caspar_media_playback.My.MySettings.Default.txtsqlpassword
        '
        'txtuser
        '
        Me.txtuser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtsqluser", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtuser.Location = New System.Drawing.Point(59, 42)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(137, 20)
        Me.txtuser.TabIndex = 6
        Me.txtuser.Text = Global.caspar_media_playback.My.MySettings.Default.txtsqluser
        '
        'txtserver
        '
        Me.txtserver.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtsqlserver", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtserver.Location = New System.Drawing.Point(59, 19)
        Me.txtserver.Name = "txtserver"
        Me.txtserver.Size = New System.Drawing.Size(137, 20)
        Me.txtserver.TabIndex = 5
        Me.txtserver.Text = Global.caspar_media_playback.My.MySettings.Default.txtsqlserver
        '
        'ucMySqlTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(1202, 884)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmbfontsql)
        Me.Controls.Add(Me.Label160)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdfontcolorsql)
        Me.Controls.Add(Me.Label162)
        Me.Controls.Add(Me.cmdbgcolorsql)
        Me.Controls.Add(Me.FontSizesql)
        Me.Controls.Add(Me.nFontSizesql)
        Me.Controls.Add(Me.txtcolumns)
        Me.Controls.Add(Me.txtrows)
        Me.Controls.Add(Me.chkAllColumns)
        Me.Controls.Add(Me.chkAllRow)
        Me.Controls.Add(Me.cmdStopSqlLayer)
        Me.Controls.Add(Me.cmblayerSqlhtml)
        Me.Controls.Add(Me.lbllayerhtml)
        Me.Controls.Add(Me.cmdShowincasparcg)
        Me.Controls.Add(Me.cmdAny)
        Me.Controls.Add(Me.txtAnyCommand)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdInsert)
        Me.Controls.Add(Me.txtDelete)
        Me.Controls.Add(Me.txtUpdate)
        Me.Controls.Add(Me.txtInsert)
        Me.Controls.Add(Me.cmdFillTablenames)
        Me.Controls.Add(Me.cmbTables)
        Me.Controls.Add(Me.dgvContents)
        Me.Controls.Add(Me.cmdShowContents)
        Me.Controls.Add(Me.GroupBox1)
        Me.HideOnClose = True
        Me.Name = "ucMySqlTest"
        Me.Text = "MySql Tester"
        CType(Me.dgvContents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nFontSizesql, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdFillTablenames As Button
    Friend WithEvents cmbTables As ComboBox
    Friend WithEvents dgvContents As DataGridView
    Friend WithEvents cmdShowContents As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtport As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdatabase As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtserver As TextBox
    Friend WithEvents cmdsetserver As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtInsert As TextBox
    Friend WithEvents txtUpdate As TextBox
    Friend WithEvents txtDelete As TextBox
    Friend WithEvents cmdInsert As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdAny As Button
    Friend WithEvents txtAnyCommand As TextBox
    Friend WithEvents cmdShowincasparcg As Button
    Friend WithEvents lbllayerhtml As Label
    Friend WithEvents cmblayerSqlhtml As ComboBox
    Friend WithEvents cmdStopSqlLayer As Button
    Friend WithEvents chkAllRow As CheckBox
    Friend WithEvents chkAllColumns As CheckBox
    Friend WithEvents txtrows As TextBox
    Friend WithEvents txtcolumns As TextBox
    Friend WithEvents nFontSizesql As NumericUpDown
    Friend WithEvents FontSizesql As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdfontcolorsql As Button
    Friend WithEvents Label162 As Label
    Friend WithEvents cmdbgcolorsql As Button
    Friend WithEvents cmbfontsql As ComboBox
    Friend WithEvents Label160 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtdatabasemysql As TextBox
    Friend WithEvents txtpasswordMysql As TextBox
    Friend WithEvents txtusemysql As TextBox
    Friend WithEvents txtservermysql As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmdSetServerMySql As Button
    Friend WithEvents chkIntegratedSecurity As CheckBox
End Class
