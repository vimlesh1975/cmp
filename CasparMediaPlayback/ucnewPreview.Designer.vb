<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucnewPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucnewPreview))
        Me.gbpreview = New System.Windows.Forms.GroupBox()
        Me.vlcpreview = New Vlc.DotNet.Forms.VlcControl()
        Me.cmdhid = New System.Windows.Forms.Button()
        Me.lblchannelnumber = New System.Windows.Forms.Label()
        Me.cmdremovepreview = New System.Windows.Forms.Button()
        Me.cmdpreviewkey = New System.Windows.Forms.Button()
        Me.cmbippreview = New System.Windows.Forms.ComboBox()
        Me.cmdpreview = New System.Windows.Forms.Button()
        Me.txtoptionspreview = New System.Windows.Forms.TextBox()
        Me.gbpreview.SuspendLayout()
        CType(Me.vlcpreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbpreview
        '
        Me.gbpreview.BackColor = System.Drawing.Color.PeachPuff
        Me.gbpreview.Controls.Add(Me.vlcpreview)
        Me.gbpreview.Controls.Add(Me.cmdhid)
        Me.gbpreview.Controls.Add(Me.lblchannelnumber)
        Me.gbpreview.Controls.Add(Me.cmdremovepreview)
        Me.gbpreview.Controls.Add(Me.cmdpreviewkey)
        Me.gbpreview.Controls.Add(Me.cmbippreview)
        Me.gbpreview.Controls.Add(Me.cmdpreview)
        Me.gbpreview.Controls.Add(Me.txtoptionspreview)
        Me.gbpreview.Location = New System.Drawing.Point(2, 2)
        Me.gbpreview.Name = "gbpreview"
        Me.gbpreview.Size = New System.Drawing.Size(431, 338)
        Me.gbpreview.TabIndex = 1168
        Me.gbpreview.TabStop = False
        Me.gbpreview.Text = "Preview"
        '
        'vlcpreview
        '
        Me.vlcpreview.BackColor = System.Drawing.Color.Black
        Me.vlcpreview.Location = New System.Drawing.Point(6, 77)
        Me.vlcpreview.Name = "vlcpreview"
        Me.vlcpreview.Size = New System.Drawing.Size(419, 255)
        Me.vlcpreview.Spu = -1
        Me.vlcpreview.TabIndex = 1178
        Me.vlcpreview.Text = "VlcControl1"
        Me.vlcpreview.VlcLibDirectory = CType(resources.GetObject("vlcpreview.VlcLibDirectory"), System.IO.DirectoryInfo)
        Me.vlcpreview.VlcMediaplayerOptions = Nothing
        '
        'cmdhid
        '
        Me.cmdhid.Image = CType(resources.GetObject("cmdhid.Image"), System.Drawing.Image)
        Me.cmdhid.Location = New System.Drawing.Point(397, 6)
        Me.cmdhid.Name = "cmdhid"
        Me.cmdhid.Size = New System.Drawing.Size(28, 27)
        Me.cmdhid.TabIndex = 1177
        Me.cmdhid.UseVisualStyleBackColor = True
        '
        'lblchannelnumber
        '
        Me.lblchannelnumber.AutoSize = True
        Me.lblchannelnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchannelnumber.ForeColor = System.Drawing.Color.DarkRed
        Me.lblchannelnumber.Location = New System.Drawing.Point(278, 48)
        Me.lblchannelnumber.Name = "lblchannelnumber"
        Me.lblchannelnumber.Size = New System.Drawing.Size(119, 25)
        Me.lblchannelnumber.TabIndex = 1169
        Me.lblchannelnumber.Text = "Channel 1"
        '
        'cmdremovepreview
        '
        Me.cmdremovepreview.Location = New System.Drawing.Point(164, 49)
        Me.cmdremovepreview.Name = "cmdremovepreview"
        Me.cmdremovepreview.Size = New System.Drawing.Size(108, 22)
        Me.cmdremovepreview.TabIndex = 1168
        Me.cmdremovepreview.Text = "Remove Preview"
        Me.cmdremovepreview.UseVisualStyleBackColor = True
        '
        'cmdpreviewkey
        '
        Me.cmdpreviewkey.Location = New System.Drawing.Point(84, 49)
        Me.cmdpreviewkey.Name = "cmdpreviewkey"
        Me.cmdpreviewkey.Size = New System.Drawing.Size(74, 22)
        Me.cmdpreviewkey.TabIndex = 1171
        Me.cmdpreviewkey.Text = "Preview Key"
        Me.cmdpreviewkey.UseVisualStyleBackColor = True
        '
        'cmbippreview
        '
        Me.cmbippreview.FormattingEnabled = True
        Me.cmbippreview.Items.AddRange(New Object() {"224.0.0.1:5004", "127.0.0.1:5004", "192.168.1.1:5004", "192.168.1.2:5004", "192.168.1.3:5004"})
        Me.cmbippreview.Location = New System.Drawing.Point(11, 16)
        Me.cmbippreview.Name = "cmbippreview"
        Me.cmbippreview.Size = New System.Drawing.Size(99, 21)
        Me.cmbippreview.TabIndex = 1173
        Me.cmbippreview.Text = "224.0.0.1:5004"
        '
        'cmdpreview
        '
        Me.cmdpreview.Location = New System.Drawing.Point(4, 48)
        Me.cmdpreview.Name = "cmdpreview"
        Me.cmdpreview.Size = New System.Drawing.Size(80, 22)
        Me.cmdpreview.TabIndex = 1167
        Me.cmdpreview.Text = "Preview Fill"
        Me.cmdpreview.UseVisualStyleBackColor = True
        '
        'txtoptionspreview
        '
        Me.txtoptionspreview.Location = New System.Drawing.Point(116, 10)
        Me.txtoptionspreview.Multiline = True
        Me.txtoptionspreview.Name = "txtoptionspreview"
        Me.txtoptionspreview.Size = New System.Drawing.Size(275, 36)
        Me.txtoptionspreview.TabIndex = 1170
        Me.txtoptionspreview.Text = "-vcodec libx264 -tune zerolatency -preset ultrafast -crf 25 -format mpegts scale=" &
    "240:180"
        '
        'ucnewPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.gbpreview)
        Me.Name = "ucnewPreview"
        Me.Size = New System.Drawing.Size(437, 343)
        Me.gbpreview.ResumeLayout(False)
        Me.gbpreview.PerformLayout()
        CType(Me.vlcpreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbpreview As System.Windows.Forms.GroupBox
    Friend WithEvents cmbippreview As System.Windows.Forms.ComboBox
    Friend WithEvents cmdpreviewkey As System.Windows.Forms.Button
    Friend WithEvents txtoptionspreview As System.Windows.Forms.TextBox
    Friend WithEvents cmdremovepreview As System.Windows.Forms.Button
    Friend WithEvents cmdpreview As System.Windows.Forms.Button
    Friend WithEvents lblchannelnumber As Label
    Friend WithEvents cmdhid As Button
    Friend WithEvents vlcpreview As Vlc.DotNet.Forms.VlcControl
End Class
