<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucVlcStreamTester
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucVlcStreamTester))
        Me.gbVlcTester = New System.Windows.Forms.GroupBox()
        Me.txtCaspar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdPlayinCasparcg = New System.Windows.Forms.Button()
        Me.btnPreviewcombo = New System.Windows.Forms.Button()
        Me.cmbAddress = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtaddress8 = New System.Windows.Forms.TextBox()
        Me.cmdpreview8 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtaddress7 = New System.Windows.Forms.TextBox()
        Me.cmdpreview7 = New System.Windows.Forms.Button()
        Me.txtaddress6 = New System.Windows.Forms.TextBox()
        Me.cmdpreview6 = New System.Windows.Forms.Button()
        Me.txtaddress5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdpreview5 = New System.Windows.Forms.Button()
        Me.vlcpreview = New Vlc.DotNet.Forms.VlcControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtaddress4 = New System.Windows.Forms.TextBox()
        Me.cmdpreview4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtaddress3 = New System.Windows.Forms.TextBox()
        Me.cmdpreview3 = New System.Windows.Forms.Button()
        Me.txtaddress2 = New System.Windows.Forms.TextBox()
        Me.cmdpreview2 = New System.Windows.Forms.Button()
        Me.txtaddress1 = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.cmdremovepreview = New System.Windows.Forms.Button()
        Me.cmdpreview = New System.Windows.Forms.Button()
        Me.gbVlcTester.SuspendLayout()
        CType(Me.vlcpreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbVlcTester
        '
        Me.gbVlcTester.BackColor = System.Drawing.Color.PeachPuff
        Me.gbVlcTester.Controls.Add(Me.txtCaspar)
        Me.gbVlcTester.Controls.Add(Me.Label8)
        Me.gbVlcTester.Controls.Add(Me.cmdPlayinCasparcg)
        Me.gbVlcTester.Controls.Add(Me.btnPreviewcombo)
        Me.gbVlcTester.Controls.Add(Me.cmbAddress)
        Me.gbVlcTester.Controls.Add(Me.Label4)
        Me.gbVlcTester.Controls.Add(Me.txtaddress8)
        Me.gbVlcTester.Controls.Add(Me.cmdpreview8)
        Me.gbVlcTester.Controls.Add(Me.Label5)
        Me.gbVlcTester.Controls.Add(Me.Label6)
        Me.gbVlcTester.Controls.Add(Me.txtaddress7)
        Me.gbVlcTester.Controls.Add(Me.cmdpreview7)
        Me.gbVlcTester.Controls.Add(Me.txtaddress6)
        Me.gbVlcTester.Controls.Add(Me.cmdpreview6)
        Me.gbVlcTester.Controls.Add(Me.txtaddress5)
        Me.gbVlcTester.Controls.Add(Me.Label7)
        Me.gbVlcTester.Controls.Add(Me.cmdpreview5)
        Me.gbVlcTester.Controls.Add(Me.vlcpreview)
        Me.gbVlcTester.Controls.Add(Me.Label3)
        Me.gbVlcTester.Controls.Add(Me.txtaddress4)
        Me.gbVlcTester.Controls.Add(Me.cmdpreview4)
        Me.gbVlcTester.Controls.Add(Me.Label2)
        Me.gbVlcTester.Controls.Add(Me.Label1)
        Me.gbVlcTester.Controls.Add(Me.txtaddress3)
        Me.gbVlcTester.Controls.Add(Me.cmdpreview3)
        Me.gbVlcTester.Controls.Add(Me.txtaddress2)
        Me.gbVlcTester.Controls.Add(Me.cmdpreview2)
        Me.gbVlcTester.Controls.Add(Me.txtaddress1)
        Me.gbVlcTester.Controls.Add(Me.lblAddress)
        Me.gbVlcTester.Controls.Add(Me.cmdremovepreview)
        Me.gbVlcTester.Controls.Add(Me.cmdpreview)
        Me.gbVlcTester.Location = New System.Drawing.Point(3, 4)
        Me.gbVlcTester.Name = "gbVlcTester"
        Me.gbVlcTester.Size = New System.Drawing.Size(1202, 907)
        Me.gbVlcTester.TabIndex = 1168
        Me.gbVlcTester.TabStop = False
        Me.gbVlcTester.Text = " "
        '
        'txtCaspar
        '
        Me.txtCaspar.Location = New System.Drawing.Point(662, 122)
        Me.txtCaspar.Name = "txtCaspar"
        Me.txtCaspar.Size = New System.Drawing.Size(154, 20)
        Me.txtCaspar.TabIndex = 1208
        Me.txtCaspar.Text = "Play 1-1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 1207
        Me.Label8.Text = "Addres"
        '
        'cmdPlayinCasparcg
        '
        Me.cmdPlayinCasparcg.BackColor = System.Drawing.Color.Green
        Me.cmdPlayinCasparcg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPlayinCasparcg.ForeColor = System.Drawing.Color.White
        Me.cmdPlayinCasparcg.Location = New System.Drawing.Point(525, 122)
        Me.cmdPlayinCasparcg.Name = "cmdPlayinCasparcg"
        Me.cmdPlayinCasparcg.Size = New System.Drawing.Size(130, 22)
        Me.cmdPlayinCasparcg.TabIndex = 1206
        Me.cmdPlayinCasparcg.Text = "Play in CasparCG"
        Me.cmdPlayinCasparcg.UseVisualStyleBackColor = False
        '
        'btnPreviewcombo
        '
        Me.btnPreviewcombo.BackColor = System.Drawing.Color.Green
        Me.btnPreviewcombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviewcombo.ForeColor = System.Drawing.Color.White
        Me.btnPreviewcombo.Location = New System.Drawing.Point(457, 123)
        Me.btnPreviewcombo.Name = "btnPreviewcombo"
        Me.btnPreviewcombo.Size = New System.Drawing.Size(62, 22)
        Me.btnPreviewcombo.TabIndex = 1205
        Me.btnPreviewcombo.Text = "Play"
        Me.btnPreviewcombo.UseVisualStyleBackColor = False
        '
        'cmbAddress
        '
        Me.cmbAddress.FormattingEnabled = True
        Me.cmbAddress.Items.AddRange(New Object() {"http://iptv.kitv.live:1935/live/MamunHome/HomeSonyTv/104.ts", "http://iptv.kitv.live:1935/live/MamunHome/HomeSonyTv/105.ts", "http://iptv.kitv.live:1935/live/MamunHome/HomeSonyTv/106.ts"})
        Me.cmbAddress.Location = New System.Drawing.Point(65, 123)
        Me.cmbAddress.Name = "cmbAddress"
        Me.cmbAddress.Size = New System.Drawing.Size(389, 21)
        Me.cmbAddress.TabIndex = 1204
        Me.cmbAddress.Text = "http://iptv.kitv.live:1935/live/MamunHome/HomeSonyTv/170.ts"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(557, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 1203
        Me.Label4.Text = "File4"
        '
        'txtaddress8
        '
        Me.txtaddress8.Location = New System.Drawing.Point(592, 94)
        Me.txtaddress8.Name = "txtaddress8"
        Me.txtaddress8.Size = New System.Drawing.Size(389, 20)
        Me.txtaddress8.TabIndex = 1202
        Me.txtaddress8.Text = "c:/casparcg/_media/scroll_loop.mp4"
        '
        'cmdpreview8
        '
        Me.cmdpreview8.BackColor = System.Drawing.Color.Green
        Me.cmdpreview8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpreview8.ForeColor = System.Drawing.Color.White
        Me.cmdpreview8.Location = New System.Drawing.Point(984, 92)
        Me.cmdpreview8.Name = "cmdpreview8"
        Me.cmdpreview8.Size = New System.Drawing.Size(62, 22)
        Me.cmdpreview8.TabIndex = 1201
        Me.cmdpreview8.Text = "Play"
        Me.cmdpreview8.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(557, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 1200
        Me.Label5.Text = "File3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(538, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 1199
        Me.Label6.Text = "Address4"
        '
        'txtaddress7
        '
        Me.txtaddress7.Location = New System.Drawing.Point(592, 66)
        Me.txtaddress7.Name = "txtaddress7"
        Me.txtaddress7.Size = New System.Drawing.Size(389, 20)
        Me.txtaddress7.TabIndex = 1198
        Me.txtaddress7.Text = "c:/casparcg/_media/kabhi_kabhi.mp4"
        '
        'cmdpreview7
        '
        Me.cmdpreview7.BackColor = System.Drawing.Color.Green
        Me.cmdpreview7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpreview7.ForeColor = System.Drawing.Color.White
        Me.cmdpreview7.Location = New System.Drawing.Point(984, 64)
        Me.cmdpreview7.Name = "cmdpreview7"
        Me.cmdpreview7.Size = New System.Drawing.Size(62, 22)
        Me.cmdpreview7.TabIndex = 1197
        Me.cmdpreview7.Text = "Play"
        Me.cmdpreview7.UseVisualStyleBackColor = False
        '
        'txtaddress6
        '
        Me.txtaddress6.Location = New System.Drawing.Point(592, 38)
        Me.txtaddress6.Name = "txtaddress6"
        Me.txtaddress6.Size = New System.Drawing.Size(389, 20)
        Me.txtaddress6.TabIndex = 1196
        Me.txtaddress6.Text = "http://localhost/test/mystream.m3u8"
        '
        'cmdpreview6
        '
        Me.cmdpreview6.BackColor = System.Drawing.Color.Green
        Me.cmdpreview6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpreview6.ForeColor = System.Drawing.Color.White
        Me.cmdpreview6.Location = New System.Drawing.Point(984, 36)
        Me.cmdpreview6.Name = "cmdpreview6"
        Me.cmdpreview6.Size = New System.Drawing.Size(62, 22)
        Me.cmdpreview6.TabIndex = 1195
        Me.cmdpreview6.Text = "Play"
        Me.cmdpreview6.UseVisualStyleBackColor = False
        '
        'txtaddress5
        '
        Me.txtaddress5.Location = New System.Drawing.Point(592, 10)
        Me.txtaddress5.Name = "txtaddress5"
        Me.txtaddress5.Size = New System.Drawing.Size(389, 20)
        Me.txtaddress5.TabIndex = 1194
        Me.txtaddress5.Text = "rtmp://45.116.3.113:1940/tata/livestream"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(538, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 1193
        Me.Label7.Text = "Address3"
        '
        'cmdpreview5
        '
        Me.cmdpreview5.BackColor = System.Drawing.Color.Green
        Me.cmdpreview5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpreview5.ForeColor = System.Drawing.Color.White
        Me.cmdpreview5.Location = New System.Drawing.Point(984, 8)
        Me.cmdpreview5.Name = "cmdpreview5"
        Me.cmdpreview5.Size = New System.Drawing.Size(62, 22)
        Me.cmdpreview5.TabIndex = 1191
        Me.cmdpreview5.Text = "Play"
        Me.cmdpreview5.UseVisualStyleBackColor = False
        '
        'vlcpreview
        '
        Me.vlcpreview.BackColor = System.Drawing.Color.Black
        Me.vlcpreview.Location = New System.Drawing.Point(7, 231)
        Me.vlcpreview.Name = "vlcpreview"
        Me.vlcpreview.Size = New System.Drawing.Size(1178, 669)
        Me.vlcpreview.Spu = -1
        Me.vlcpreview.TabIndex = 1190
        Me.vlcpreview.Text = "VlcControl1"
        Me.vlcpreview.VlcLibDirectory = CType(resources.GetObject("vlcpreview.VlcLibDirectory"), System.IO.DirectoryInfo)
        Me.vlcpreview.VlcMediaplayerOptions = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 1189
        Me.Label3.Text = "File2"
        '
        'txtaddress4
        '
        Me.txtaddress4.Location = New System.Drawing.Point(65, 96)
        Me.txtaddress4.Name = "txtaddress4"
        Me.txtaddress4.Size = New System.Drawing.Size(389, 20)
        Me.txtaddress4.TabIndex = 1188
        Me.txtaddress4.Text = "c:/casparcg/_media/scroll_loop.mp4"
        '
        'cmdpreview4
        '
        Me.cmdpreview4.BackColor = System.Drawing.Color.Green
        Me.cmdpreview4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpreview4.ForeColor = System.Drawing.Color.White
        Me.cmdpreview4.Location = New System.Drawing.Point(457, 94)
        Me.cmdpreview4.Name = "cmdpreview4"
        Me.cmdpreview4.Size = New System.Drawing.Size(62, 22)
        Me.cmdpreview4.TabIndex = 1187
        Me.cmdpreview4.Text = "Play"
        Me.cmdpreview4.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1186
        Me.Label2.Text = "File1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1185
        Me.Label1.Text = "Address2"
        '
        'txtaddress3
        '
        Me.txtaddress3.Location = New System.Drawing.Point(65, 68)
        Me.txtaddress3.Name = "txtaddress3"
        Me.txtaddress3.Size = New System.Drawing.Size(389, 20)
        Me.txtaddress3.TabIndex = 1184
        Me.txtaddress3.Text = "http://iptv.kitv.live:1935/live/MamunHome/HomeSonyTv/190.ts"
        '
        'cmdpreview3
        '
        Me.cmdpreview3.BackColor = System.Drawing.Color.Green
        Me.cmdpreview3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpreview3.ForeColor = System.Drawing.Color.White
        Me.cmdpreview3.Location = New System.Drawing.Point(457, 66)
        Me.cmdpreview3.Name = "cmdpreview3"
        Me.cmdpreview3.Size = New System.Drawing.Size(62, 22)
        Me.cmdpreview3.TabIndex = 1183
        Me.cmdpreview3.Text = "Play"
        Me.cmdpreview3.UseVisualStyleBackColor = False
        '
        'txtaddress2
        '
        Me.txtaddress2.Location = New System.Drawing.Point(65, 40)
        Me.txtaddress2.Name = "txtaddress2"
        Me.txtaddress2.Size = New System.Drawing.Size(389, 20)
        Me.txtaddress2.TabIndex = 1182
        Me.txtaddress2.Text = "http://192.168.0.143:86/playlist.m3u8?camera=1&quality=High"
        '
        'cmdpreview2
        '
        Me.cmdpreview2.BackColor = System.Drawing.Color.Green
        Me.cmdpreview2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpreview2.ForeColor = System.Drawing.Color.White
        Me.cmdpreview2.Location = New System.Drawing.Point(457, 38)
        Me.cmdpreview2.Name = "cmdpreview2"
        Me.cmdpreview2.Size = New System.Drawing.Size(62, 22)
        Me.cmdpreview2.TabIndex = 1181
        Me.cmdpreview2.Text = "Play"
        Me.cmdpreview2.UseVisualStyleBackColor = False
        '
        'txtaddress1
        '
        Me.txtaddress1.Location = New System.Drawing.Point(65, 12)
        Me.txtaddress1.Name = "txtaddress1"
        Me.txtaddress1.Size = New System.Drawing.Size(389, 20)
        Me.txtaddress1.TabIndex = 1180
        Me.txtaddress1.Text = "http://120.63.236.151:86/playlist.m3u8?camera=1&quality=High"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(11, 15)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(51, 13)
        Me.lblAddress.TabIndex = 1179
        Me.lblAddress.Text = "Address1"
        '
        'cmdremovepreview
        '
        Me.cmdremovepreview.BackColor = System.Drawing.Color.Red
        Me.cmdremovepreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdremovepreview.ForeColor = System.Drawing.Color.White
        Me.cmdremovepreview.Location = New System.Drawing.Point(9, 147)
        Me.cmdremovepreview.Name = "cmdremovepreview"
        Me.cmdremovepreview.Size = New System.Drawing.Size(1176, 78)
        Me.cmdremovepreview.TabIndex = 1168
        Me.cmdremovepreview.Text = "Stop"
        Me.cmdremovepreview.UseVisualStyleBackColor = False
        '
        'cmdpreview
        '
        Me.cmdpreview.BackColor = System.Drawing.Color.Green
        Me.cmdpreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpreview.ForeColor = System.Drawing.Color.White
        Me.cmdpreview.Location = New System.Drawing.Point(457, 10)
        Me.cmdpreview.Name = "cmdpreview"
        Me.cmdpreview.Size = New System.Drawing.Size(62, 22)
        Me.cmdpreview.TabIndex = 1167
        Me.cmdpreview.Text = "Play"
        Me.cmdpreview.UseVisualStyleBackColor = False
        '
        'ucVlcStreamTester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1208, 921)
        Me.Controls.Add(Me.gbVlcTester)
        Me.HideOnClose = True
        Me.Name = "ucVlcStreamTester"
        Me.Text = "VLC Stream Tester"
        Me.gbVlcTester.ResumeLayout(False)
        Me.gbVlcTester.PerformLayout()
        CType(Me.vlcpreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbVlcTester As System.Windows.Forms.GroupBox
    Friend WithEvents cmdremovepreview As System.Windows.Forms.Button
    Friend WithEvents cmdpreview As System.Windows.Forms.Button
    Friend WithEvents txtaddress1 As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtaddress4 As System.Windows.Forms.TextBox
    Friend WithEvents cmdpreview4 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtaddress3 As System.Windows.Forms.TextBox
    Friend WithEvents cmdpreview3 As System.Windows.Forms.Button
    Friend WithEvents txtaddress2 As System.Windows.Forms.TextBox
    Friend WithEvents cmdpreview2 As System.Windows.Forms.Button
    Friend WithEvents vlcpreview As Vlc.DotNet.Forms.VlcControl
    Friend WithEvents Label4 As Label
    Friend WithEvents txtaddress8 As TextBox
    Friend WithEvents cmdpreview8 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtaddress7 As TextBox
    Friend WithEvents cmdpreview7 As Button
    Friend WithEvents txtaddress6 As TextBox
    Friend WithEvents cmdpreview6 As Button
    Friend WithEvents txtaddress5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdpreview5 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdPlayinCasparcg As Button
    Friend WithEvents btnPreviewcombo As Button
    Friend WithEvents cmbAddress As ComboBox
    Friend WithEvents txtCaspar As TextBox
End Class
