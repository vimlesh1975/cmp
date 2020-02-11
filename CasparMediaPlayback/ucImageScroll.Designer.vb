<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucImageScroll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucImageScroll))
        Me.gbimagescroll = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdPauseResume = New System.Windows.Forms.Button()
        Me.cmblayervideoforimage = New System.Windows.Forms.ComboBox()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.txtimagescrollidea = New System.Windows.Forms.TextBox()
        Me.txtimagescrollwiki = New System.Windows.Forms.TextBox()
        Me.cmdimagestop = New System.Windows.Forms.Button()
        Me.chkPROGRESSIVE = New System.Windows.Forms.CheckBox()
        Me.chkPREMULTIPLY = New System.Windows.Forms.CheckBox()
        Me.cmbimagescrollblur = New System.Windows.Forms.ComboBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.cmdrefreshimagefilesforimagescroll = New System.Windows.Forms.Button()
        Me.cmbimageforimagescroll = New System.Windows.Forms.ComboBox()
        Me.cmbimagescrollspeed = New System.Windows.Forms.ComboBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.cmdimagescrollplay = New System.Windows.Forms.Button()
        Me.gbimagescroll.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbimagescroll
        '
        Me.gbimagescroll.BackColor = System.Drawing.Color.PeachPuff
        Me.gbimagescroll.Controls.Add(Me.Label4)
        Me.gbimagescroll.Controls.Add(Me.Label3)
        Me.gbimagescroll.Controls.Add(Me.Label2)
        Me.gbimagescroll.Controls.Add(Me.LinkLabel1)
        Me.gbimagescroll.Controls.Add(Me.PictureBox2)
        Me.gbimagescroll.Controls.Add(Me.PictureBox1)
        Me.gbimagescroll.Controls.Add(Me.Label1)
        Me.gbimagescroll.Controls.Add(Me.cmdPauseResume)
        Me.gbimagescroll.Controls.Add(Me.cmblayervideoforimage)
        Me.gbimagescroll.Controls.Add(Me.Label106)
        Me.gbimagescroll.Controls.Add(Me.txtimagescrollidea)
        Me.gbimagescroll.Controls.Add(Me.txtimagescrollwiki)
        Me.gbimagescroll.Controls.Add(Me.cmdimagestop)
        Me.gbimagescroll.Controls.Add(Me.chkPROGRESSIVE)
        Me.gbimagescroll.Controls.Add(Me.chkPREMULTIPLY)
        Me.gbimagescroll.Controls.Add(Me.cmbimagescrollblur)
        Me.gbimagescroll.Controls.Add(Me.Label94)
        Me.gbimagescroll.Controls.Add(Me.cmdrefreshimagefilesforimagescroll)
        Me.gbimagescroll.Controls.Add(Me.cmbimageforimagescroll)
        Me.gbimagescroll.Controls.Add(Me.cmbimagescrollspeed)
        Me.gbimagescroll.Controls.Add(Me.Label92)
        Me.gbimagescroll.Controls.Add(Me.cmdimagescrollplay)
        Me.gbimagescroll.Location = New System.Drawing.Point(3, 3)
        Me.gbimagescroll.Name = "gbimagescroll"
        Me.gbimagescroll.Size = New System.Drawing.Size(926, 763)
        Me.gbimagescroll.TabIndex = 594
        Me.gbimagescroll.TabStop = False
        Me.gbimagescroll.Text = " "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 521)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 13)
        Me.Label4.TabIndex = 727
        Me.Label4.Text = "Pannel can be accessed as below"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 726
        Me.Label3.Text = "Put The files as below"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 13)
        Me.Label2.TabIndex = 725
        Me.Label2.Text = "Targa Generator File for photoshop"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(194, 314)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(390, 13)
        Me.LinkLabel1.TabIndex = 724
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://drive.google.com/open?id=1DlMkTGOlqAMhw0eRReyPwv85ow6FVTBn"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.caspar_media_playback.My.Resources.Resources.IMG_20190910_WA00331
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(6, 537)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(805, 220)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 723
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.caspar_media_playback.My.Resources.Resources.IMG_20190910_WA0032
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(10, 348)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(784, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 722
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 20)
        Me.Label1.TabIndex = 721
        Me.Label1.Text = "Use Server 2.07 for smoother Scroll"
        '
        'cmdPauseResume
        '
        Me.cmdPauseResume.BackColor = System.Drawing.Color.Yellow
        Me.cmdPauseResume.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPauseResume.Location = New System.Drawing.Point(805, 51)
        Me.cmdPauseResume.Name = "cmdPauseResume"
        Me.cmdPauseResume.Size = New System.Drawing.Size(115, 23)
        Me.cmdPauseResume.TabIndex = 720
        Me.cmdPauseResume.Text = "Pause / Resume"
        Me.cmdPauseResume.UseVisualStyleBackColor = False
        '
        'cmblayervideoforimage
        '
        Me.cmblayervideoforimage.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmblayervideoforimage", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmblayervideoforimage.FormattingEnabled = True
        Me.cmblayervideoforimage.Items.AddRange(New Object() {"6", "7", "8", "9", "10"})
        Me.cmblayervideoforimage.Location = New System.Drawing.Point(744, 12)
        Me.cmblayervideoforimage.Name = "cmblayervideoforimage"
        Me.cmblayervideoforimage.Size = New System.Drawing.Size(50, 21)
        Me.cmblayervideoforimage.TabIndex = 608
        Me.cmblayervideoforimage.Text = "6"
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.Location = New System.Drawing.Point(675, 15)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(63, 13)
        Me.Label106.TabIndex = 607
        Me.Label106.Text = "Video Layer"
        '
        'txtimagescrollidea
        '
        Me.txtimagescrollidea.Location = New System.Drawing.Point(9, 100)
        Me.txtimagescrollidea.Multiline = True
        Me.txtimagescrollidea.Name = "txtimagescrollidea"
        Me.txtimagescrollidea.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtimagescrollidea.Size = New System.Drawing.Size(785, 90)
        Me.txtimagescrollidea.TabIndex = 606
        Me.txtimagescrollidea.Text = resources.GetString("txtimagescrollidea.Text")
        '
        'txtimagescrollwiki
        '
        Me.txtimagescrollwiki.Location = New System.Drawing.Point(10, 196)
        Me.txtimagescrollwiki.Multiline = True
        Me.txtimagescrollwiki.Name = "txtimagescrollwiki"
        Me.txtimagescrollwiki.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtimagescrollwiki.Size = New System.Drawing.Size(784, 111)
        Me.txtimagescrollwiki.TabIndex = 605
        Me.txtimagescrollwiki.Text = resources.GetString("txtimagescrollwiki.Text")
        '
        'cmdimagestop
        '
        Me.cmdimagestop.BackColor = System.Drawing.Color.Red
        Me.cmdimagestop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdimagestop.ForeColor = System.Drawing.Color.White
        Me.cmdimagestop.Location = New System.Drawing.Point(861, 80)
        Me.cmdimagestop.Name = "cmdimagestop"
        Me.cmdimagestop.Size = New System.Drawing.Size(59, 23)
        Me.cmdimagestop.TabIndex = 604
        Me.cmdimagestop.Text = "Stop"
        Me.cmdimagestop.UseVisualStyleBackColor = False
        '
        'chkPROGRESSIVE
        '
        Me.chkPROGRESSIVE.AutoSize = True
        Me.chkPROGRESSIVE.Checked = Global.caspar_media_playback.My.MySettings.Default.chkPROGRESSIVE
        Me.chkPROGRESSIVE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPROGRESSIVE.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.caspar_media_playback.My.MySettings.Default, "chkPROGRESSIVE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkPROGRESSIVE.Location = New System.Drawing.Point(446, 76)
        Me.chkPROGRESSIVE.Name = "chkPROGRESSIVE"
        Me.chkPROGRESSIVE.Size = New System.Drawing.Size(103, 17)
        Me.chkPROGRESSIVE.TabIndex = 601
        Me.chkPROGRESSIVE.Text = "PROGRESSIVE"
        Me.chkPROGRESSIVE.UseVisualStyleBackColor = True
        '
        'chkPREMULTIPLY
        '
        Me.chkPREMULTIPLY.AutoSize = True
        Me.chkPREMULTIPLY.Checked = Global.caspar_media_playback.My.MySettings.Default.chkPREMULTIPLY
        Me.chkPREMULTIPLY.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPREMULTIPLY.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.caspar_media_playback.My.MySettings.Default, "chkPREMULTIPLY", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkPREMULTIPLY.Location = New System.Drawing.Point(339, 77)
        Me.chkPREMULTIPLY.Name = "chkPREMULTIPLY"
        Me.chkPREMULTIPLY.Size = New System.Drawing.Size(101, 17)
        Me.chkPREMULTIPLY.TabIndex = 600
        Me.chkPREMULTIPLY.Text = "PREMULTIPLY"
        Me.chkPREMULTIPLY.UseVisualStyleBackColor = True
        '
        'cmbimagescrollblur
        '
        Me.cmbimagescrollblur.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbimagescrollblur", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbimagescrollblur.FormattingEnabled = True
        Me.cmbimagescrollblur.Items.AddRange(New Object() {"00", "10", "20", "30", "40", "50", "60", "70", "80", "90", "100"})
        Me.cmbimagescrollblur.Location = New System.Drawing.Point(287, 76)
        Me.cmbimagescrollblur.Name = "cmbimagescrollblur"
        Me.cmbimagescrollblur.Size = New System.Drawing.Size(44, 21)
        Me.cmbimagescrollblur.TabIndex = 599
        Me.cmbimagescrollblur.Text = "0"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Location = New System.Drawing.Point(256, 80)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(25, 13)
        Me.Label94.TabIndex = 598
        Me.Label94.Text = "Blur"
        '
        'cmdrefreshimagefilesforimagescroll
        '
        Me.cmdrefreshimagefilesforimagescroll.Location = New System.Drawing.Point(6, 48)
        Me.cmdrefreshimagefilesforimagescroll.Name = "cmdrefreshimagefilesforimagescroll"
        Me.cmdrefreshimagefilesforimagescroll.Size = New System.Drawing.Size(111, 23)
        Me.cmdrefreshimagefilesforimagescroll.TabIndex = 596
        Me.cmdrefreshimagefilesforimagescroll.Text = "Refresh Image files"
        Me.cmdrefreshimagefilesforimagescroll.UseVisualStyleBackColor = True
        '
        'cmbimageforimagescroll
        '
        Me.cmbimageforimagescroll.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbimageforimagescroll", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbimageforimagescroll.FormattingEnabled = True
        Me.cmbimageforimagescroll.Location = New System.Drawing.Point(9, 74)
        Me.cmbimageforimagescroll.Name = "cmbimageforimagescroll"
        Me.cmbimageforimagescroll.Size = New System.Drawing.Size(125, 21)
        Me.cmbimageforimagescroll.TabIndex = 595
        Me.cmbimageforimagescroll.Text = Global.caspar_media_playback.My.MySettings.Default.cmbimageforimagescroll
        '
        'cmbimagescrollspeed
        '
        Me.cmbimagescrollspeed.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbimagescrollspeed", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbimagescrollspeed.FormattingEnabled = True
        Me.cmbimagescrollspeed.Items.AddRange(New Object() {"-1", "-2", "-3", "-4", "-5", "-6", "-7", "-8", "-9", "-10", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "0"})
        Me.cmbimagescrollspeed.Location = New System.Drawing.Point(197, 76)
        Me.cmbimagescrollspeed.Name = "cmbimagescrollspeed"
        Me.cmbimagescrollspeed.Size = New System.Drawing.Size(44, 21)
        Me.cmbimagescrollspeed.TabIndex = 594
        Me.cmbimagescrollspeed.Text = "3"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Location = New System.Drawing.Point(153, 80)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(38, 13)
        Me.Label92.TabIndex = 593
        Me.Label92.Text = "Speed"
        '
        'cmdimagescrollplay
        '
        Me.cmdimagescrollplay.BackColor = System.Drawing.Color.Green
        Me.cmdimagescrollplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdimagescrollplay.ForeColor = System.Drawing.Color.White
        Me.cmdimagescrollplay.Location = New System.Drawing.Point(850, 22)
        Me.cmdimagescrollplay.Name = "cmdimagescrollplay"
        Me.cmdimagescrollplay.Size = New System.Drawing.Size(59, 23)
        Me.cmdimagescrollplay.TabIndex = 592
        Me.cmdimagescrollplay.Text = "Play"
        Me.cmdimagescrollplay.UseVisualStyleBackColor = False
        '
        'ucImageScroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(941, 778)
        Me.Controls.Add(Me.gbimagescroll)
        Me.HideOnClose = True
        Me.Name = "ucImageScroll"
        Me.Text = "Image Scroll"
        Me.gbimagescroll.ResumeLayout(False)
        Me.gbimagescroll.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbimagescroll As System.Windows.Forms.GroupBox
    Friend WithEvents cmblayervideoforimage As System.Windows.Forms.ComboBox
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents txtimagescrollidea As System.Windows.Forms.TextBox
    Friend WithEvents txtimagescrollwiki As System.Windows.Forms.TextBox
    Friend WithEvents cmdimagestop As System.Windows.Forms.Button
    Friend WithEvents chkPROGRESSIVE As System.Windows.Forms.CheckBox
    Friend WithEvents chkPREMULTIPLY As System.Windows.Forms.CheckBox
    Friend WithEvents cmbimagescrollblur As System.Windows.Forms.ComboBox
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents cmdrefreshimagefilesforimagescroll As System.Windows.Forms.Button
    Friend WithEvents cmbimageforimagescroll As System.Windows.Forms.ComboBox
    Friend WithEvents cmbimagescrollspeed As System.Windows.Forms.ComboBox
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents cmdimagescrollplay As System.Windows.Forms.Button
    Friend WithEvents cmdPauseResume As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
