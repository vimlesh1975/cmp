<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucStreaming
    'Inherits System.Windows.Forms.UserControl
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucStreaming))
        Me.gbstreaming = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.cmduseinffmpeg = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtremovepipe = New System.Windows.Forms.TextBox()
        Me.txtuseinffmpeg = New System.Windows.Forms.RichTextBox()
        Me.cmdstoppipe = New System.Windows.Forms.Button()
        Me.txtcommandpipe = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmdsendpipe = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cmdstopfbstreaming23 = New System.Windows.Forms.Button()
        Me.txtcommandfbstreaming23 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtaddressfbstreaming23 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtstreamnamefbstreaming23 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtoptionsfbstreaming23 = New System.Windows.Forms.RichTextBox()
        Me.cmdsendfbstreaming23 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cmdstopytstreaming23 = New System.Windows.Forms.Button()
        Me.txtcommandytstreaming23 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtaddressytstreaming23 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtstreamnameytstreaming23 = New System.Windows.Forms.TextBox()
        Me.txtapplicationameytstreaming23 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtoptionsytstreaming23 = New System.Windows.Forms.RichTextBox()
        Me.cmdsendytstreaming23 = New System.Windows.Forms.Button()
        Me.txtStopTestSignal = New System.Windows.Forms.TextBox()
        Me.txtPlayTestSignal = New System.Windows.Forms.TextBox()
        Me.cmdStopTestSignal = New System.Windows.Forms.Button()
        Me.cmdPlayTestSignal = New System.Windows.Forms.Button()
        Me.Label233 = New System.Windows.Forms.Label()
        Me.cmbdecklinkforrecording = New System.Windows.Forms.ComboBox()
        Me.cmdremove_input = New System.Windows.Forms.Button()
        Me.cmdinput = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtndi = New System.Windows.Forms.TextBox()
        Me.cmdRemoveNDI = New System.Windows.Forms.Button()
        Me.cmdAddNDI = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmdStopUDP = New System.Windows.Forms.Button()
        Me.cmdplaystreamingcosumer = New System.Windows.Forms.Button()
        Me.txtudp = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdstophlsstreaming = New System.Windows.Forms.Button()
        Me.cmdsendhlsstreaming = New System.Windows.Forms.Button()
        Me.txtcommandhlstreaming = New System.Windows.Forms.TextBox()
        Me.Label256 = New System.Windows.Forms.Label()
        Me.txtaddresshlsstreaming = New System.Windows.Forms.TextBox()
        Me.Label257 = New System.Windows.Forms.Label()
        Me.txtoptionshlsstreaming = New System.Windows.Forms.RichTextBox()
        Me.txtstreamnamehlsstreaming = New System.Windows.Forms.TextBox()
        Me.txtapplicationamehlsstreaming = New System.Windows.Forms.TextBox()
        Me.Label259 = New System.Windows.Forms.Label()
        Me.Label260 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdstopwsstreaming = New System.Windows.Forms.Button()
        Me.cmdsendwsstreaming = New System.Windows.Forms.Button()
        Me.txtcommandwsstreaming = New System.Windows.Forms.TextBox()
        Me.Label212 = New System.Windows.Forms.Label()
        Me.Label213 = New System.Windows.Forms.Label()
        Me.txtaddresswsstreaming = New System.Windows.Forms.TextBox()
        Me.Label214 = New System.Windows.Forms.Label()
        Me.txtoptionswsstreaming = New System.Windows.Forms.RichTextBox()
        Me.txtstreamnamewsstreaming = New System.Windows.Forms.TextBox()
        Me.txtapplicationamewsstreaming = New System.Windows.Forms.TextBox()
        Me.Label166 = New System.Windows.Forms.Label()
        Me.Label165 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdstopfbstreaming = New System.Windows.Forms.Button()
        Me.txtcommandfbstreaming = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtaddressfbstreaming = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtstreamnamefbstreaming = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtoptionsfbstreaming = New System.Windows.Forms.RichTextBox()
        Me.cmdsendfbstreaming = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdstopytstreaming = New System.Windows.Forms.Button()
        Me.txtcommandytstreaming = New System.Windows.Forms.TextBox()
        Me.Label211 = New System.Windows.Forms.Label()
        Me.Label210 = New System.Windows.Forms.Label()
        Me.txtaddressytstreaming = New System.Windows.Forms.TextBox()
        Me.Label207 = New System.Windows.Forms.Label()
        Me.txtstreamnameytstreaming = New System.Windows.Forms.TextBox()
        Me.txtapplicationameytstreaming = New System.Windows.Forms.TextBox()
        Me.Label175 = New System.Windows.Forms.Label()
        Me.Label205 = New System.Windows.Forms.Label()
        Me.txtoptionsytstreaming = New System.Windows.Forms.RichTextBox()
        Me.cmdsendytstreaming = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.cmdstopIGstreaming = New System.Windows.Forms.Button()
        Me.txtcommandIGstreaming = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtaddressIGstreaming = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtstreamnameIGstreaming = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtoptionsIGstreaming = New System.Windows.Forms.RichTextBox()
        Me.cmdsendIGstreaming = New System.Windows.Forms.Button()
        Me.gbstreaming.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbstreaming
        '
        Me.gbstreaming.BackColor = System.Drawing.Color.NavajoWhite
        Me.gbstreaming.Controls.Add(Me.GroupBox10)
        Me.gbstreaming.Controls.Add(Me.GroupBox9)
        Me.gbstreaming.Controls.Add(Me.GroupBox8)
        Me.gbstreaming.Controls.Add(Me.Label11)
        Me.gbstreaming.Controls.Add(Me.GroupBox7)
        Me.gbstreaming.Controls.Add(Me.txtStopTestSignal)
        Me.gbstreaming.Controls.Add(Me.txtPlayTestSignal)
        Me.gbstreaming.Controls.Add(Me.cmdStopTestSignal)
        Me.gbstreaming.Controls.Add(Me.cmdPlayTestSignal)
        Me.gbstreaming.Controls.Add(Me.Label233)
        Me.gbstreaming.Controls.Add(Me.cmbdecklinkforrecording)
        Me.gbstreaming.Controls.Add(Me.cmdremove_input)
        Me.gbstreaming.Controls.Add(Me.cmdinput)
        Me.gbstreaming.Controls.Add(Me.GroupBox6)
        Me.gbstreaming.Controls.Add(Me.GroupBox5)
        Me.gbstreaming.Controls.Add(Me.GroupBox4)
        Me.gbstreaming.Controls.Add(Me.GroupBox3)
        Me.gbstreaming.Controls.Add(Me.GroupBox2)
        Me.gbstreaming.Controls.Add(Me.Label7)
        Me.gbstreaming.Controls.Add(Me.GroupBox1)
        Me.gbstreaming.Location = New System.Drawing.Point(2, 3)
        Me.gbstreaming.Name = "gbstreaming"
        Me.gbstreaming.Size = New System.Drawing.Size(1197, 906)
        Me.gbstreaming.TabIndex = 1169
        Me.gbstreaming.TabStop = False
        Me.gbstreaming.Text = " "
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox9.Controls.Add(Me.Label18)
        Me.GroupBox9.Controls.Add(Me.LinkLabel1)
        Me.GroupBox9.Controls.Add(Me.cmduseinffmpeg)
        Me.GroupBox9.Controls.Add(Me.Label17)
        Me.GroupBox9.Controls.Add(Me.txtremovepipe)
        Me.GroupBox9.Controls.Add(Me.txtuseinffmpeg)
        Me.GroupBox9.Controls.Add(Me.cmdstoppipe)
        Me.GroupBox9.Controls.Add(Me.txtcommandpipe)
        Me.GroupBox9.Controls.Add(Me.Label16)
        Me.GroupBox9.Controls.Add(Me.cmdsendpipe)
        Me.GroupBox9.Location = New System.Drawing.Point(686, 592)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(508, 230)
        Me.GroupBox9.TabIndex = 1203
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Named pipe consumer"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 13)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Pipe Server"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(87, 20)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(350, 13)
        Me.LinkLabel1.TabIndex = 30
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://github.com/philipstarkey/CasparCGServer/releases/tag/PR1335"
        '
        'cmduseinffmpeg
        '
        Me.cmduseinffmpeg.BackColor = System.Drawing.Color.Green
        Me.cmduseinffmpeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmduseinffmpeg.ForeColor = System.Drawing.Color.White
        Me.cmduseinffmpeg.Location = New System.Drawing.Point(452, 150)
        Me.cmduseinffmpeg.Name = "cmduseinffmpeg"
        Me.cmduseinffmpeg.Size = New System.Drawing.Size(50, 62)
        Me.cmduseinffmpeg.TabIndex = 29
        Me.cmduseinffmpeg.Text = "Use"
        Me.cmduseinffmpeg.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 136)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 13)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Use in FFMpeg"
        '
        'txtremovepipe
        '
        Me.txtremovepipe.Location = New System.Drawing.Point(12, 101)
        Me.txtremovepipe.Name = "txtremovepipe"
        Me.txtremovepipe.Size = New System.Drawing.Size(275, 20)
        Me.txtremovepipe.TabIndex = 27
        Me.txtremovepipe.Text = "Remove 1 PIPE 1"
        '
        'txtuseinffmpeg
        '
        Me.txtuseinffmpeg.Location = New System.Drawing.Point(12, 150)
        Me.txtuseinffmpeg.Name = "txtuseinffmpeg"
        Me.txtuseinffmpeg.Size = New System.Drawing.Size(427, 62)
        Me.txtuseinffmpeg.TabIndex = 27
        Me.txtuseinffmpeg.Text = resources.GetString("txtuseinffmpeg.Text")
        '
        'cmdstoppipe
        '
        Me.cmdstoppipe.BackColor = System.Drawing.Color.Red
        Me.cmdstoppipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstoppipe.ForeColor = System.Drawing.Color.White
        Me.cmdstoppipe.Location = New System.Drawing.Point(453, 85)
        Me.cmdstoppipe.Name = "cmdstoppipe"
        Me.cmdstoppipe.Size = New System.Drawing.Size(50, 51)
        Me.cmdstoppipe.TabIndex = 26
        Me.cmdstoppipe.Text = "Stop"
        Me.cmdstoppipe.UseVisualStyleBackColor = False
        '
        'txtcommandpipe
        '
        Me.txtcommandpipe.Location = New System.Drawing.Point(9, 59)
        Me.txtcommandpipe.Name = "txtcommandpipe"
        Me.txtcommandpipe.Size = New System.Drawing.Size(496, 20)
        Me.txtcommandpipe.TabIndex = 18
        Me.txtcommandpipe.Text = "ADD 1 PIPE 1 VIDEO_PIPE \\\\.\\pipe\\CasparCGVideo AUDIO_PIPE \\\\.\\pipe\\Caspar" &
    "CGAudio"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 13)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Command"
        '
        'cmdsendpipe
        '
        Me.cmdsendpipe.BackColor = System.Drawing.Color.Green
        Me.cmdsendpipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsendpipe.ForeColor = System.Drawing.Color.White
        Me.cmdsendpipe.Location = New System.Drawing.Point(453, 6)
        Me.cmdsendpipe.Name = "cmdsendpipe"
        Me.cmdsendpipe.Size = New System.Drawing.Size(50, 51)
        Me.cmdsendpipe.TabIndex = 0
        Me.cmdsendpipe.Text = "Send"
        Me.cmdsendpipe.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox8.Controls.Add(Me.cmdstopfbstreaming23)
        Me.GroupBox8.Controls.Add(Me.txtcommandfbstreaming23)
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.txtaddressfbstreaming23)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.Controls.Add(Me.txtstreamnamefbstreaming23)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Controls.Add(Me.txtoptionsfbstreaming23)
        Me.GroupBox8.Controls.Add(Me.cmdsendfbstreaming23)
        Me.GroupBox8.Location = New System.Drawing.Point(681, 426)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(508, 140)
        Me.GroupBox8.TabIndex = 1202
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Facebook"
        '
        'cmdstopfbstreaming23
        '
        Me.cmdstopfbstreaming23.BackColor = System.Drawing.Color.Red
        Me.cmdstopfbstreaming23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopfbstreaming23.ForeColor = System.Drawing.Color.White
        Me.cmdstopfbstreaming23.Location = New System.Drawing.Point(448, 79)
        Me.cmdstopfbstreaming23.Name = "cmdstopfbstreaming23"
        Me.cmdstopfbstreaming23.Size = New System.Drawing.Size(50, 51)
        Me.cmdstopfbstreaming23.TabIndex = 26
        Me.cmdstopfbstreaming23.Text = "Stop"
        Me.cmdstopfbstreaming23.UseVisualStyleBackColor = False
        '
        'txtcommandfbstreaming23
        '
        Me.txtcommandfbstreaming23.Location = New System.Drawing.Point(9, 39)
        Me.txtcommandfbstreaming23.Name = "txtcommandfbstreaming23"
        Me.txtcommandfbstreaming23.Size = New System.Drawing.Size(94, 20)
        Me.txtcommandfbstreaming23.TabIndex = 18
        Me.txtcommandfbstreaming23.Text = "ADD 1 STREAM"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Command"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Options"
        '
        'txtaddressfbstreaming23
        '
        Me.txtaddressfbstreaming23.Location = New System.Drawing.Point(109, 39)
        Me.txtaddressfbstreaming23.Name = "txtaddressfbstreaming23"
        Me.txtaddressfbstreaming23.Size = New System.Drawing.Size(171, 20)
        Me.txtaddressfbstreaming23.TabIndex = 15
        Me.txtaddressfbstreaming23.Text = "rtmps://live-api-s.facebook.com:443/rtmp/"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(106, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Address"
        '
        'txtstreamnamefbstreaming23
        '
        Me.txtstreamnamefbstreaming23.Location = New System.Drawing.Point(283, 39)
        Me.txtstreamnamefbstreaming23.Name = "txtstreamnamefbstreaming23"
        Me.txtstreamnamefbstreaming23.Size = New System.Drawing.Size(215, 20)
        Me.txtstreamnamefbstreaming23.TabIndex = 11
        Me.txtstreamnamefbstreaming23.Text = "943597992503642?ds=1&s_sw=0&s_vt=api-s&a=AbxLVBHuJ9Oys2YH"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(390, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Stream Name"
        '
        'txtoptionsfbstreaming23
        '
        Me.txtoptionsfbstreaming23.Location = New System.Drawing.Point(9, 74)
        Me.txtoptionsfbstreaming23.Name = "txtoptionsfbstreaming23"
        Me.txtoptionsfbstreaming23.Size = New System.Drawing.Size(361, 56)
        Me.txtoptionsfbstreaming23.TabIndex = 1
        Me.txtoptionsfbstreaming23.Text = "-codec:v libx264 -codec:a aac -strict -2  -b:a 128k -ar:a 48000 -b:v 2750k -filte" &
    "r:v format=pix_fmts=yuv422p,scale=1024x576,fps=25 -filter:a pan=stereo|c0=c0|c1=" &
    "c1 -format flv"
        '
        'cmdsendfbstreaming23
        '
        Me.cmdsendfbstreaming23.BackColor = System.Drawing.Color.Green
        Me.cmdsendfbstreaming23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsendfbstreaming23.ForeColor = System.Drawing.Color.White
        Me.cmdsendfbstreaming23.Location = New System.Drawing.Point(383, 79)
        Me.cmdsendfbstreaming23.Name = "cmdsendfbstreaming23"
        Me.cmdsendfbstreaming23.Size = New System.Drawing.Size(50, 51)
        Me.cmdsendfbstreaming23.TabIndex = 0
        Me.cmdsendfbstreaming23.Text = "Send"
        Me.cmdsendfbstreaming23.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(691, 232)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 20)
        Me.Label11.TabIndex = 1192
        Me.Label11.Text = "Server 2.3"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox7.Controls.Add(Me.cmdstopytstreaming23)
        Me.GroupBox7.Controls.Add(Me.txtcommandytstreaming23)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.txtaddressytstreaming23)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.txtstreamnameytstreaming23)
        Me.GroupBox7.Controls.Add(Me.txtapplicationameytstreaming23)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.txtoptionsytstreaming23)
        Me.GroupBox7.Controls.Add(Me.cmdsendytstreaming23)
        Me.GroupBox7.Location = New System.Drawing.Point(681, 268)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(508, 140)
        Me.GroupBox7.TabIndex = 1201
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "YouTube"
        '
        'cmdstopytstreaming23
        '
        Me.cmdstopytstreaming23.BackColor = System.Drawing.Color.Red
        Me.cmdstopytstreaming23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopytstreaming23.ForeColor = System.Drawing.Color.White
        Me.cmdstopytstreaming23.Location = New System.Drawing.Point(448, 79)
        Me.cmdstopytstreaming23.Name = "cmdstopytstreaming23"
        Me.cmdstopytstreaming23.Size = New System.Drawing.Size(50, 51)
        Me.cmdstopytstreaming23.TabIndex = 26
        Me.cmdstopytstreaming23.Text = "Stop"
        Me.cmdstopytstreaming23.UseVisualStyleBackColor = False
        '
        'txtcommandytstreaming23
        '
        Me.txtcommandytstreaming23.Location = New System.Drawing.Point(9, 39)
        Me.txtcommandytstreaming23.Name = "txtcommandytstreaming23"
        Me.txtcommandytstreaming23.Size = New System.Drawing.Size(94, 20)
        Me.txtcommandytstreaming23.TabIndex = 18
        Me.txtcommandytstreaming23.Text = "ADD 1 STREAM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Command"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Options"
        '
        'txtaddressytstreaming23
        '
        Me.txtaddressytstreaming23.Location = New System.Drawing.Point(109, 39)
        Me.txtaddressytstreaming23.Name = "txtaddressytstreaming23"
        Me.txtaddressytstreaming23.Size = New System.Drawing.Size(171, 20)
        Me.txtaddressytstreaming23.TabIndex = 15
        Me.txtaddressytstreaming23.Text = "rtmp://a.rtmp.youtube.com"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(106, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Address"
        '
        'txtstreamnameytstreaming23
        '
        Me.txtstreamnameytstreaming23.Location = New System.Drawing.Point(357, 39)
        Me.txtstreamnameytstreaming23.Name = "txtstreamnameytstreaming23"
        Me.txtstreamnameytstreaming23.Size = New System.Drawing.Size(141, 20)
        Me.txtstreamnameytstreaming23.TabIndex = 11
        Me.txtstreamnameytstreaming23.Text = "yeuh-c3wm-x3j0-7gdz"
        '
        'txtapplicationameytstreaming23
        '
        Me.txtapplicationameytstreaming23.Location = New System.Drawing.Point(283, 39)
        Me.txtapplicationameytstreaming23.Name = "txtapplicationameytstreaming23"
        Me.txtapplicationameytstreaming23.Size = New System.Drawing.Size(68, 20)
        Me.txtapplicationameytstreaming23.TabIndex = 10
        Me.txtapplicationameytstreaming23.Text = "live2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(390, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Stream Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(269, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Application Name"
        '
        'txtoptionsytstreaming23
        '
        Me.txtoptionsytstreaming23.Location = New System.Drawing.Point(9, 74)
        Me.txtoptionsytstreaming23.Name = "txtoptionsytstreaming23"
        Me.txtoptionsytstreaming23.Size = New System.Drawing.Size(361, 56)
        Me.txtoptionsytstreaming23.TabIndex = 1
        Me.txtoptionsytstreaming23.Text = "-codec:a aac -strict -2  -b:a 128k -ar:a 48000 -b:v 2750k -filter:v format=pix_fm" &
    "ts=yuv422p,scale=1024x576,fps=25 -filter:a pan=stereo|c0=c0|c1=c1 -format flv"
        '
        'cmdsendytstreaming23
        '
        Me.cmdsendytstreaming23.BackColor = System.Drawing.Color.Green
        Me.cmdsendytstreaming23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsendytstreaming23.ForeColor = System.Drawing.Color.White
        Me.cmdsendytstreaming23.Location = New System.Drawing.Point(383, 79)
        Me.cmdsendytstreaming23.Name = "cmdsendytstreaming23"
        Me.cmdsendytstreaming23.Size = New System.Drawing.Size(50, 51)
        Me.cmdsendytstreaming23.TabIndex = 0
        Me.cmdsendytstreaming23.Text = "Send"
        Me.cmdsendytstreaming23.UseVisualStyleBackColor = False
        '
        'txtStopTestSignal
        '
        Me.txtStopTestSignal.Location = New System.Drawing.Point(695, 117)
        Me.txtStopTestSignal.Multiline = True
        Me.txtStopTestSignal.Name = "txtStopTestSignal"
        Me.txtStopTestSignal.Size = New System.Drawing.Size(344, 59)
        Me.txtStopTestSignal.TabIndex = 1214
        Me.txtStopTestSignal.Text = "Stop 1-1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stop 1-2"
        '
        'txtPlayTestSignal
        '
        Me.txtPlayTestSignal.Location = New System.Drawing.Point(695, 52)
        Me.txtPlayTestSignal.Multiline = True
        Me.txtPlayTestSignal.Name = "txtPlayTestSignal"
        Me.txtPlayTestSignal.Size = New System.Drawing.Size(344, 59)
        Me.txtPlayTestSignal.TabIndex = 1213
        Me.txtPlayTestSignal.Text = "Play 1-1 go1080p25 loop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cg 1-2 add 2 cmp/cg_template/clock 1"
        '
        'cmdStopTestSignal
        '
        Me.cmdStopTestSignal.Location = New System.Drawing.Point(1045, 117)
        Me.cmdStopTestSignal.Name = "cmdStopTestSignal"
        Me.cmdStopTestSignal.Size = New System.Drawing.Size(63, 59)
        Me.cmdStopTestSignal.TabIndex = 1212
        Me.cmdStopTestSignal.Text = "Stop Test Signal"
        Me.cmdStopTestSignal.UseVisualStyleBackColor = True
        '
        'cmdPlayTestSignal
        '
        Me.cmdPlayTestSignal.Location = New System.Drawing.Point(1045, 55)
        Me.cmdPlayTestSignal.Name = "cmdPlayTestSignal"
        Me.cmdPlayTestSignal.Size = New System.Drawing.Size(63, 56)
        Me.cmdPlayTestSignal.TabIndex = 1210
        Me.cmdPlayTestSignal.Text = "Play Test Signal"
        Me.cmdPlayTestSignal.UseVisualStyleBackColor = True
        '
        'Label233
        '
        Me.Label233.AutoSize = True
        Me.Label233.Location = New System.Drawing.Point(692, 5)
        Me.Label233.Name = "Label233"
        Me.Label233.Size = New System.Drawing.Size(49, 13)
        Me.Label233.TabIndex = 1209
        Me.Label233.Text = "Decklink"
        '
        'cmbdecklinkforrecording
        '
        Me.cmbdecklinkforrecording.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbliveoal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbdecklinkforrecording.FormattingEnabled = True
        Me.cmbdecklinkforrecording.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbdecklinkforrecording.Location = New System.Drawing.Point(695, 23)
        Me.cmbdecklinkforrecording.Name = "cmbdecklinkforrecording"
        Me.cmbdecklinkforrecording.Size = New System.Drawing.Size(39, 21)
        Me.cmbdecklinkforrecording.TabIndex = 1208
        Me.cmbdecklinkforrecording.Text = "1"
        '
        'cmdremove_input
        '
        Me.cmdremove_input.Location = New System.Drawing.Point(821, 19)
        Me.cmdremove_input.Name = "cmdremove_input"
        Me.cmdremove_input.Size = New System.Drawing.Size(92, 27)
        Me.cmdremove_input.TabIndex = 1207
        Me.cmdremove_input.Text = "Remove Input"
        Me.cmdremove_input.UseVisualStyleBackColor = True
        '
        'cmdinput
        '
        Me.cmdinput.Location = New System.Drawing.Point(747, 19)
        Me.cmdinput.Name = "cmdinput"
        Me.cmdinput.Size = New System.Drawing.Size(70, 27)
        Me.cmdinput.TabIndex = 1206
        Me.cmdinput.Text = "Show input"
        Me.cmdinput.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox6.Controls.Add(Me.txtndi)
        Me.GroupBox6.Controls.Add(Me.cmdRemoveNDI)
        Me.GroupBox6.Controls.Add(Me.cmdAddNDI)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 818)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(670, 60)
        Me.GroupBox6.TabIndex = 1205
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "NDI"
        '
        'txtndi
        '
        Me.txtndi.Location = New System.Drawing.Point(7, 26)
        Me.txtndi.Name = "txtndi"
        Me.txtndi.Size = New System.Drawing.Size(535, 20)
        Me.txtndi.TabIndex = 1199
        Me.txtndi.Text = "add 1 ndi name ch1"
        '
        'cmdRemoveNDI
        '
        Me.cmdRemoveNDI.BackColor = System.Drawing.Color.Red
        Me.cmdRemoveNDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemoveNDI.ForeColor = System.Drawing.Color.White
        Me.cmdRemoveNDI.Location = New System.Drawing.Point(618, 26)
        Me.cmdRemoveNDI.Name = "cmdRemoveNDI"
        Me.cmdRemoveNDI.Size = New System.Drawing.Size(50, 28)
        Me.cmdRemoveNDI.TabIndex = 1198
        Me.cmdRemoveNDI.Text = "Stop"
        Me.cmdRemoveNDI.UseVisualStyleBackColor = False
        '
        'cmdAddNDI
        '
        Me.cmdAddNDI.BackColor = System.Drawing.Color.Green
        Me.cmdAddNDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddNDI.ForeColor = System.Drawing.Color.White
        Me.cmdAddNDI.Location = New System.Drawing.Point(560, 26)
        Me.cmdAddNDI.Name = "cmdAddNDI"
        Me.cmdAddNDI.Size = New System.Drawing.Size(50, 28)
        Me.cmdAddNDI.TabIndex = 1196
        Me.cmdAddNDI.Text = "Send"
        Me.cmdAddNDI.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox5.Controls.Add(Me.cmdStopUDP)
        Me.GroupBox5.Controls.Add(Me.cmdplaystreamingcosumer)
        Me.GroupBox5.Controls.Add(Me.txtudp)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 740)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(670, 68)
        Me.GroupBox5.TabIndex = 1204
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "UDP"
        '
        'cmdStopUDP
        '
        Me.cmdStopUDP.BackColor = System.Drawing.Color.Red
        Me.cmdStopUDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStopUDP.ForeColor = System.Drawing.Color.White
        Me.cmdStopUDP.Location = New System.Drawing.Point(618, 19)
        Me.cmdStopUDP.Name = "cmdStopUDP"
        Me.cmdStopUDP.Size = New System.Drawing.Size(50, 36)
        Me.cmdStopUDP.TabIndex = 1193
        Me.cmdStopUDP.Text = "Stop"
        Me.cmdStopUDP.UseVisualStyleBackColor = False
        '
        'cmdplaystreamingcosumer
        '
        Me.cmdplaystreamingcosumer.BackColor = System.Drawing.Color.Green
        Me.cmdplaystreamingcosumer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplaystreamingcosumer.ForeColor = System.Drawing.Color.White
        Me.cmdplaystreamingcosumer.Location = New System.Drawing.Point(560, 21)
        Me.cmdplaystreamingcosumer.Name = "cmdplaystreamingcosumer"
        Me.cmdplaystreamingcosumer.Size = New System.Drawing.Size(50, 36)
        Me.cmdplaystreamingcosumer.TabIndex = 661
        Me.cmdplaystreamingcosumer.Text = "Send"
        Me.cmdplaystreamingcosumer.UseVisualStyleBackColor = False
        '
        'txtudp
        '
        Me.txtudp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtstreamingcosumer", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtudp.Location = New System.Drawing.Point(10, 17)
        Me.txtudp.Multiline = True
        Me.txtudp.Name = "txtudp"
        Me.txtudp.Size = New System.Drawing.Size(532, 40)
        Me.txtudp.TabIndex = 660
        Me.txtudp.Text = Global.caspar_media_playback.My.MySettings.Default.txtstreamingcosumer
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox4.Controls.Add(Me.cmdstophlsstreaming)
        Me.GroupBox4.Controls.Add(Me.cmdsendhlsstreaming)
        Me.GroupBox4.Controls.Add(Me.txtcommandhlstreaming)
        Me.GroupBox4.Controls.Add(Me.Label256)
        Me.GroupBox4.Controls.Add(Me.txtaddresshlsstreaming)
        Me.GroupBox4.Controls.Add(Me.Label257)
        Me.GroupBox4.Controls.Add(Me.txtoptionshlsstreaming)
        Me.GroupBox4.Controls.Add(Me.txtstreamnamehlsstreaming)
        Me.GroupBox4.Controls.Add(Me.txtapplicationamehlsstreaming)
        Me.GroupBox4.Controls.Add(Me.Label259)
        Me.GroupBox4.Controls.Add(Me.Label260)
        Me.GroupBox4.Location = New System.Drawing.Point(4, 442)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(670, 136)
        Me.GroupBox4.TabIndex = 1203
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "HLS Streaming"
        '
        'cmdstophlsstreaming
        '
        Me.cmdstophlsstreaming.BackColor = System.Drawing.Color.Red
        Me.cmdstophlsstreaming.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstophlsstreaming.ForeColor = System.Drawing.Color.White
        Me.cmdstophlsstreaming.Location = New System.Drawing.Point(614, 30)
        Me.cmdstophlsstreaming.Name = "cmdstophlsstreaming"
        Me.cmdstophlsstreaming.Size = New System.Drawing.Size(50, 89)
        Me.cmdstophlsstreaming.TabIndex = 39
        Me.cmdstophlsstreaming.Text = "Stop"
        Me.cmdstophlsstreaming.UseVisualStyleBackColor = False
        '
        'cmdsendhlsstreaming
        '
        Me.cmdsendhlsstreaming.BackColor = System.Drawing.Color.Green
        Me.cmdsendhlsstreaming.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsendhlsstreaming.ForeColor = System.Drawing.Color.White
        Me.cmdsendhlsstreaming.Location = New System.Drawing.Point(549, 31)
        Me.cmdsendhlsstreaming.Name = "cmdsendhlsstreaming"
        Me.cmdsendhlsstreaming.Size = New System.Drawing.Size(50, 88)
        Me.cmdsendhlsstreaming.TabIndex = 38
        Me.cmdsendhlsstreaming.Text = "Send"
        Me.cmdsendhlsstreaming.UseVisualStyleBackColor = False
        '
        'txtcommandhlstreaming
        '
        Me.txtcommandhlstreaming.Location = New System.Drawing.Point(7, 30)
        Me.txtcommandhlstreaming.Name = "txtcommandhlstreaming"
        Me.txtcommandhlstreaming.Size = New System.Drawing.Size(94, 20)
        Me.txtcommandhlstreaming.TabIndex = 37
        Me.txtcommandhlstreaming.Text = "ADD 1 STREAM"
        '
        'Label256
        '
        Me.Label256.AutoSize = True
        Me.Label256.Location = New System.Drawing.Point(7, 15)
        Me.Label256.Name = "Label256"
        Me.Label256.Size = New System.Drawing.Size(54, 13)
        Me.Label256.TabIndex = 36
        Me.Label256.Text = "Command"
        '
        'txtaddresshlsstreaming
        '
        Me.txtaddresshlsstreaming.Location = New System.Drawing.Point(107, 30)
        Me.txtaddresshlsstreaming.Name = "txtaddresshlsstreaming"
        Me.txtaddresshlsstreaming.Size = New System.Drawing.Size(171, 20)
        Me.txtaddresshlsstreaming.TabIndex = 35
        Me.txtaddresshlsstreaming.Text = "C:/wamp/www"
        '
        'Label257
        '
        Me.Label257.AutoSize = True
        Me.Label257.Location = New System.Drawing.Point(110, 13)
        Me.Label257.Name = "Label257"
        Me.Label257.Size = New System.Drawing.Size(45, 13)
        Me.Label257.TabIndex = 34
        Me.Label257.Text = "Address"
        '
        'txtoptionshlsstreaming
        '
        Me.txtoptionshlsstreaming.Location = New System.Drawing.Point(7, 56)
        Me.txtoptionshlsstreaming.Name = "txtoptionshlsstreaming"
        Me.txtoptionshlsstreaming.Size = New System.Drawing.Size(536, 63)
        Me.txtoptionshlsstreaming.TabIndex = 33
        Me.txtoptionshlsstreaming.Text = resources.GetString("txtoptionshlsstreaming.Text")
        '
        'txtstreamnamehlsstreaming
        '
        Me.txtstreamnamehlsstreaming.Location = New System.Drawing.Point(398, 30)
        Me.txtstreamnamehlsstreaming.Name = "txtstreamnamehlsstreaming"
        Me.txtstreamnamehlsstreaming.Size = New System.Drawing.Size(145, 20)
        Me.txtstreamnamehlsstreaming.TabIndex = 31
        Me.txtstreamnamehlsstreaming.Text = "playlist.m3u8"
        '
        'txtapplicationamehlsstreaming
        '
        Me.txtapplicationamehlsstreaming.Location = New System.Drawing.Point(286, 29)
        Me.txtapplicationamehlsstreaming.Name = "txtapplicationamehlsstreaming"
        Me.txtapplicationamehlsstreaming.Size = New System.Drawing.Size(100, 20)
        Me.txtapplicationamehlsstreaming.TabIndex = 30
        Me.txtapplicationamehlsstreaming.Text = "test"
        '
        'Label259
        '
        Me.Label259.AutoSize = True
        Me.Label259.Location = New System.Drawing.Point(405, 15)
        Me.Label259.Name = "Label259"
        Me.Label259.Size = New System.Drawing.Size(71, 13)
        Me.Label259.TabIndex = 29
        Me.Label259.Text = "Stream Name"
        '
        'Label260
        '
        Me.Label260.AutoSize = True
        Me.Label260.Location = New System.Drawing.Point(283, 13)
        Me.Label260.Name = "Label260"
        Me.Label260.Size = New System.Drawing.Size(90, 13)
        Me.Label260.TabIndex = 28
        Me.Label260.Text = "Application Name"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox3.Controls.Add(Me.cmdstopwsstreaming)
        Me.GroupBox3.Controls.Add(Me.cmdsendwsstreaming)
        Me.GroupBox3.Controls.Add(Me.txtcommandwsstreaming)
        Me.GroupBox3.Controls.Add(Me.Label212)
        Me.GroupBox3.Controls.Add(Me.Label213)
        Me.GroupBox3.Controls.Add(Me.txtaddresswsstreaming)
        Me.GroupBox3.Controls.Add(Me.Label214)
        Me.GroupBox3.Controls.Add(Me.txtoptionswsstreaming)
        Me.GroupBox3.Controls.Add(Me.txtstreamnamewsstreaming)
        Me.GroupBox3.Controls.Add(Me.txtapplicationamewsstreaming)
        Me.GroupBox3.Controls.Add(Me.Label166)
        Me.GroupBox3.Controls.Add(Me.Label165)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 585)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(668, 147)
        Me.GroupBox3.TabIndex = 1202
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "WowzaStreamingEngine"
        '
        'cmdstopwsstreaming
        '
        Me.cmdstopwsstreaming.BackColor = System.Drawing.Color.Red
        Me.cmdstopwsstreaming.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopwsstreaming.ForeColor = System.Drawing.Color.White
        Me.cmdstopwsstreaming.Location = New System.Drawing.Point(614, 34)
        Me.cmdstopwsstreaming.Name = "cmdstopwsstreaming"
        Me.cmdstopwsstreaming.Size = New System.Drawing.Size(50, 77)
        Me.cmdstopwsstreaming.TabIndex = 27
        Me.cmdstopwsstreaming.Text = "Stop"
        Me.cmdstopwsstreaming.UseVisualStyleBackColor = False
        '
        'cmdsendwsstreaming
        '
        Me.cmdsendwsstreaming.BackColor = System.Drawing.Color.Green
        Me.cmdsendwsstreaming.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsendwsstreaming.ForeColor = System.Drawing.Color.White
        Me.cmdsendwsstreaming.Location = New System.Drawing.Point(557, 37)
        Me.cmdsendwsstreaming.Name = "cmdsendwsstreaming"
        Me.cmdsendwsstreaming.Size = New System.Drawing.Size(50, 101)
        Me.cmdsendwsstreaming.TabIndex = 25
        Me.cmdsendwsstreaming.Text = "Send"
        Me.cmdsendwsstreaming.UseVisualStyleBackColor = False
        '
        'txtcommandwsstreaming
        '
        Me.txtcommandwsstreaming.Location = New System.Drawing.Point(15, 34)
        Me.txtcommandwsstreaming.Name = "txtcommandwsstreaming"
        Me.txtcommandwsstreaming.Size = New System.Drawing.Size(94, 20)
        Me.txtcommandwsstreaming.TabIndex = 24
        Me.txtcommandwsstreaming.Text = "ADD 1 STREAM"
        '
        'Label212
        '
        Me.Label212.AutoSize = True
        Me.Label212.Location = New System.Drawing.Point(17, 15)
        Me.Label212.Name = "Label212"
        Me.Label212.Size = New System.Drawing.Size(54, 13)
        Me.Label212.TabIndex = 23
        Me.Label212.Text = "Command"
        '
        'Label213
        '
        Me.Label213.AutoSize = True
        Me.Label213.Location = New System.Drawing.Point(18, 57)
        Me.Label213.Name = "Label213"
        Me.Label213.Size = New System.Drawing.Size(43, 13)
        Me.Label213.TabIndex = 22
        Me.Label213.Text = "Options"
        '
        'txtaddresswsstreaming
        '
        Me.txtaddresswsstreaming.Location = New System.Drawing.Point(115, 34)
        Me.txtaddresswsstreaming.Name = "txtaddresswsstreaming"
        Me.txtaddresswsstreaming.Size = New System.Drawing.Size(171, 20)
        Me.txtaddresswsstreaming.TabIndex = 21
        Me.txtaddresswsstreaming.Text = "rtmp://localhost:1935"
        '
        'Label214
        '
        Me.Label214.AutoSize = True
        Me.Label214.Location = New System.Drawing.Point(118, 17)
        Me.Label214.Name = "Label214"
        Me.Label214.Size = New System.Drawing.Size(45, 13)
        Me.Label214.TabIndex = 20
        Me.Label214.Text = "Address"
        '
        'txtoptionswsstreaming
        '
        Me.txtoptionswsstreaming.Location = New System.Drawing.Point(15, 69)
        Me.txtoptionswsstreaming.Name = "txtoptionswsstreaming"
        Me.txtoptionswsstreaming.Size = New System.Drawing.Size(536, 69)
        Me.txtoptionswsstreaming.TabIndex = 19
        Me.txtoptionswsstreaming.Text = resources.GetString("txtoptionswsstreaming.Text")
        '
        'txtstreamnamewsstreaming
        '
        Me.txtstreamnamewsstreaming.Location = New System.Drawing.Point(406, 37)
        Me.txtstreamnamewsstreaming.Name = "txtstreamnamewsstreaming"
        Me.txtstreamnamewsstreaming.Size = New System.Drawing.Size(145, 20)
        Me.txtstreamnamewsstreaming.TabIndex = 6
        Me.txtstreamnamewsstreaming.Text = "myStream"
        '
        'txtapplicationamewsstreaming
        '
        Me.txtapplicationamewsstreaming.Location = New System.Drawing.Point(294, 33)
        Me.txtapplicationamewsstreaming.Name = "txtapplicationamewsstreaming"
        Me.txtapplicationamewsstreaming.Size = New System.Drawing.Size(100, 20)
        Me.txtapplicationamewsstreaming.TabIndex = 5
        Me.txtapplicationamewsstreaming.Text = "live"
        '
        'Label166
        '
        Me.Label166.AutoSize = True
        Me.Label166.Location = New System.Drawing.Point(413, 19)
        Me.Label166.Name = "Label166"
        Me.Label166.Size = New System.Drawing.Size(71, 13)
        Me.Label166.TabIndex = 4
        Me.Label166.Text = "Stream Name"
        '
        'Label165
        '
        Me.Label165.AutoSize = True
        Me.Label165.Location = New System.Drawing.Point(291, 17)
        Me.Label165.Name = "Label165"
        Me.Label165.Size = New System.Drawing.Size(90, 13)
        Me.Label165.TabIndex = 3
        Me.Label165.Text = "Application Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox2.Controls.Add(Me.cmdstopfbstreaming)
        Me.GroupBox2.Controls.Add(Me.txtcommandfbstreaming)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtaddressfbstreaming)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtstreamnamefbstreaming)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtoptionsfbstreaming)
        Me.GroupBox2.Controls.Add(Me.cmdsendfbstreaming)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(670, 135)
        Me.GroupBox2.TabIndex = 1201
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Facebook"
        '
        'cmdstopfbstreaming
        '
        Me.cmdstopfbstreaming.BackColor = System.Drawing.Color.Red
        Me.cmdstopfbstreaming.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopfbstreaming.ForeColor = System.Drawing.Color.White
        Me.cmdstopfbstreaming.Location = New System.Drawing.Point(618, 70)
        Me.cmdstopfbstreaming.Name = "cmdstopfbstreaming"
        Me.cmdstopfbstreaming.Size = New System.Drawing.Size(50, 53)
        Me.cmdstopfbstreaming.TabIndex = 1191
        Me.cmdstopfbstreaming.Text = "Stop"
        Me.cmdstopfbstreaming.UseVisualStyleBackColor = False
        '
        'txtcommandfbstreaming
        '
        Me.txtcommandfbstreaming.Location = New System.Drawing.Point(16, 33)
        Me.txtcommandfbstreaming.Name = "txtcommandfbstreaming"
        Me.txtcommandfbstreaming.Size = New System.Drawing.Size(94, 20)
        Me.txtcommandfbstreaming.TabIndex = 1190
        Me.txtcommandfbstreaming.Text = "ADD 1 STREAM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1189
        Me.Label1.Text = "Command"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1188
        Me.Label2.Text = "Options"
        '
        'txtaddressfbstreaming
        '
        Me.txtaddressfbstreaming.Location = New System.Drawing.Point(114, 33)
        Me.txtaddressfbstreaming.Name = "txtaddressfbstreaming"
        Me.txtaddressfbstreaming.Size = New System.Drawing.Size(209, 20)
        Me.txtaddressfbstreaming.TabIndex = 1187
        Me.txtaddressfbstreaming.Text = "rtmps://live-api-s.facebook.com:443/rtmp/"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 1186
        Me.Label3.Text = "Address"
        '
        'txtstreamnamefbstreaming
        '
        Me.txtstreamnamefbstreaming.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstreamnamefbstreaming.Location = New System.Drawing.Point(329, 33)
        Me.txtstreamnamefbstreaming.Name = "txtstreamnamefbstreaming"
        Me.txtstreamnamefbstreaming.Size = New System.Drawing.Size(315, 18)
        Me.txtstreamnamefbstreaming.TabIndex = 1185
        Me.txtstreamnamefbstreaming.Text = "943597992503642?ds=1&s_sw=0&s_vt=api-s&a=AbxLVBHuJ9Oys2YH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(512, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 1183
        Me.Label4.Text = "Stream Name"
        '
        'txtoptionsfbstreaming
        '
        Me.txtoptionsfbstreaming.Location = New System.Drawing.Point(16, 68)
        Me.txtoptionsfbstreaming.Name = "txtoptionsfbstreaming"
        Me.txtoptionsfbstreaming.Size = New System.Drawing.Size(538, 55)
        Me.txtoptionsfbstreaming.TabIndex = 1180
        Me.txtoptionsfbstreaming.Text = resources.GetString("txtoptionsfbstreaming.Text")
        '
        'cmdsendfbstreaming
        '
        Me.cmdsendfbstreaming.BackColor = System.Drawing.Color.Green
        Me.cmdsendfbstreaming.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsendfbstreaming.ForeColor = System.Drawing.Color.White
        Me.cmdsendfbstreaming.Location = New System.Drawing.Point(560, 70)
        Me.cmdsendfbstreaming.Name = "cmdsendfbstreaming"
        Me.cmdsendfbstreaming.Size = New System.Drawing.Size(50, 53)
        Me.cmdsendfbstreaming.TabIndex = 1179
        Me.cmdsendfbstreaming.Text = "Send"
        Me.cmdsendfbstreaming.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 883)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(598, 13)
        Me.Label7.TabIndex = 1194
        Me.Label7.Text = "for server version 2.2 and 2.3 -crf should be replaced with -crf:v and -vf should" &
    " be replaced with -filter:v"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox1.Controls.Add(Me.cmdstopytstreaming)
        Me.GroupBox1.Controls.Add(Me.txtcommandytstreaming)
        Me.GroupBox1.Controls.Add(Me.Label211)
        Me.GroupBox1.Controls.Add(Me.Label210)
        Me.GroupBox1.Controls.Add(Me.txtaddressytstreaming)
        Me.GroupBox1.Controls.Add(Me.Label207)
        Me.GroupBox1.Controls.Add(Me.txtstreamnameytstreaming)
        Me.GroupBox1.Controls.Add(Me.txtapplicationameytstreaming)
        Me.GroupBox1.Controls.Add(Me.Label175)
        Me.GroupBox1.Controls.Add(Me.Label205)
        Me.GroupBox1.Controls.Add(Me.txtoptionsytstreaming)
        Me.GroupBox1.Controls.Add(Me.cmdsendytstreaming)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 139)
        Me.GroupBox1.TabIndex = 1200
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "YouTube"
        '
        'cmdstopytstreaming
        '
        Me.cmdstopytstreaming.BackColor = System.Drawing.Color.Red
        Me.cmdstopytstreaming.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopytstreaming.ForeColor = System.Drawing.Color.White
        Me.cmdstopytstreaming.Location = New System.Drawing.Point(618, 31)
        Me.cmdstopytstreaming.Name = "cmdstopytstreaming"
        Me.cmdstopytstreaming.Size = New System.Drawing.Size(50, 94)
        Me.cmdstopytstreaming.TabIndex = 26
        Me.cmdstopytstreaming.Text = "Stop"
        Me.cmdstopytstreaming.UseVisualStyleBackColor = False
        '
        'txtcommandytstreaming
        '
        Me.txtcommandytstreaming.Location = New System.Drawing.Point(9, 31)
        Me.txtcommandytstreaming.Name = "txtcommandytstreaming"
        Me.txtcommandytstreaming.Size = New System.Drawing.Size(94, 20)
        Me.txtcommandytstreaming.TabIndex = 18
        Me.txtcommandytstreaming.Text = "ADD 1 STREAM"
        '
        'Label211
        '
        Me.Label211.AutoSize = True
        Me.Label211.Location = New System.Drawing.Point(9, 17)
        Me.Label211.Name = "Label211"
        Me.Label211.Size = New System.Drawing.Size(54, 13)
        Me.Label211.TabIndex = 17
        Me.Label211.Text = "Command"
        '
        'Label210
        '
        Me.Label210.AutoSize = True
        Me.Label210.Location = New System.Drawing.Point(9, 52)
        Me.Label210.Name = "Label210"
        Me.Label210.Size = New System.Drawing.Size(43, 13)
        Me.Label210.TabIndex = 16
        Me.Label210.Text = "Options"
        '
        'txtaddressytstreaming
        '
        Me.txtaddressytstreaming.Location = New System.Drawing.Point(109, 31)
        Me.txtaddressytstreaming.Name = "txtaddressytstreaming"
        Me.txtaddressytstreaming.Size = New System.Drawing.Size(171, 20)
        Me.txtaddressytstreaming.TabIndex = 15
        Me.txtaddressytstreaming.Text = "rtmp://a.rtmp.youtube.com"
        '
        'Label207
        '
        Me.Label207.AutoSize = True
        Me.Label207.Location = New System.Drawing.Point(106, 17)
        Me.Label207.Name = "Label207"
        Me.Label207.Size = New System.Drawing.Size(45, 13)
        Me.Label207.TabIndex = 14
        Me.Label207.Text = "Address"
        '
        'txtstreamnameytstreaming
        '
        Me.txtstreamnameytstreaming.Location = New System.Drawing.Point(357, 31)
        Me.txtstreamnameytstreaming.Name = "txtstreamnameytstreaming"
        Me.txtstreamnameytstreaming.Size = New System.Drawing.Size(190, 20)
        Me.txtstreamnameytstreaming.TabIndex = 11
        Me.txtstreamnameytstreaming.Text = "yeuh-c3wm-x3j0-7gdz"
        '
        'txtapplicationameytstreaming
        '
        Me.txtapplicationameytstreaming.Location = New System.Drawing.Point(283, 31)
        Me.txtapplicationameytstreaming.Name = "txtapplicationameytstreaming"
        Me.txtapplicationameytstreaming.Size = New System.Drawing.Size(68, 20)
        Me.txtapplicationameytstreaming.TabIndex = 10
        Me.txtapplicationameytstreaming.Text = "live2"
        '
        'Label175
        '
        Me.Label175.AutoSize = True
        Me.Label175.Location = New System.Drawing.Point(413, 11)
        Me.Label175.Name = "Label175"
        Me.Label175.Size = New System.Drawing.Size(71, 13)
        Me.Label175.TabIndex = 9
        Me.Label175.Text = "Stream Name"
        '
        'Label205
        '
        Me.Label205.AutoSize = True
        Me.Label205.Location = New System.Drawing.Point(280, 15)
        Me.Label205.Name = "Label205"
        Me.Label205.Size = New System.Drawing.Size(90, 13)
        Me.Label205.TabIndex = 8
        Me.Label205.Text = "Application Name"
        '
        'txtoptionsytstreaming
        '
        Me.txtoptionsytstreaming.Location = New System.Drawing.Point(9, 66)
        Me.txtoptionsytstreaming.Name = "txtoptionsytstreaming"
        Me.txtoptionsytstreaming.Size = New System.Drawing.Size(538, 59)
        Me.txtoptionsytstreaming.TabIndex = 1
        Me.txtoptionsytstreaming.Text = resources.GetString("txtoptionsytstreaming.Text")
        '
        'cmdsendytstreaming
        '
        Me.cmdsendytstreaming.BackColor = System.Drawing.Color.Green
        Me.cmdsendytstreaming.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsendytstreaming.ForeColor = System.Drawing.Color.White
        Me.cmdsendytstreaming.Location = New System.Drawing.Point(553, 31)
        Me.cmdsendytstreaming.Name = "cmdsendytstreaming"
        Me.cmdsendytstreaming.Size = New System.Drawing.Size(50, 94)
        Me.cmdsendytstreaming.TabIndex = 0
        Me.cmdsendytstreaming.Text = "Send"
        Me.cmdsendytstreaming.UseVisualStyleBackColor = False
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox10.Controls.Add(Me.cmdstopIGstreaming)
        Me.GroupBox10.Controls.Add(Me.txtcommandIGstreaming)
        Me.GroupBox10.Controls.Add(Me.Label19)
        Me.GroupBox10.Controls.Add(Me.Label20)
        Me.GroupBox10.Controls.Add(Me.txtaddressIGstreaming)
        Me.GroupBox10.Controls.Add(Me.Label21)
        Me.GroupBox10.Controls.Add(Me.txtstreamnameIGstreaming)
        Me.GroupBox10.Controls.Add(Me.Label22)
        Me.GroupBox10.Controls.Add(Me.txtoptionsIGstreaming)
        Me.GroupBox10.Controls.Add(Me.cmdsendIGstreaming)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 299)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(670, 135)
        Me.GroupBox10.TabIndex = 1202
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Instagram"
        '
        'cmdstopIGstreaming
        '
        Me.cmdstopIGstreaming.BackColor = System.Drawing.Color.Red
        Me.cmdstopIGstreaming.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopIGstreaming.ForeColor = System.Drawing.Color.White
        Me.cmdstopIGstreaming.Location = New System.Drawing.Point(618, 70)
        Me.cmdstopIGstreaming.Name = "cmdstopIGstreaming"
        Me.cmdstopIGstreaming.Size = New System.Drawing.Size(50, 53)
        Me.cmdstopIGstreaming.TabIndex = 1191
        Me.cmdstopIGstreaming.Text = "Stop"
        Me.cmdstopIGstreaming.UseVisualStyleBackColor = False
        '
        'txtcommandIGstreaming
        '
        Me.txtcommandIGstreaming.Location = New System.Drawing.Point(16, 33)
        Me.txtcommandIGstreaming.Name = "txtcommandIGstreaming"
        Me.txtcommandIGstreaming.Size = New System.Drawing.Size(94, 20)
        Me.txtcommandIGstreaming.TabIndex = 1190
        Me.txtcommandIGstreaming.Text = "ADD 1 STREAM"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(16, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 13)
        Me.Label19.TabIndex = 1189
        Me.Label19.Text = "Command"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(16, 54)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 13)
        Me.Label20.TabIndex = 1188
        Me.Label20.Text = "Options"
        '
        'txtaddressIGstreaming
        '
        Me.txtaddressIGstreaming.Location = New System.Drawing.Point(114, 33)
        Me.txtaddressIGstreaming.Name = "txtaddressIGstreaming"
        Me.txtaddressIGstreaming.Size = New System.Drawing.Size(230, 20)
        Me.txtaddressIGstreaming.TabIndex = 1187
        Me.txtaddressIGstreaming.Text = "rtmps://live-upload.instagram.com:443/rtmp/"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(113, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 1186
        Me.Label21.Text = "Address"
        '
        'txtstreamnameIGstreaming
        '
        Me.txtstreamnameIGstreaming.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstreamnameIGstreaming.Location = New System.Drawing.Point(350, 33)
        Me.txtstreamnameIGstreaming.Name = "txtstreamnameIGstreaming"
        Me.txtstreamnameIGstreaming.Size = New System.Drawing.Size(315, 18)
        Me.txtstreamnameIGstreaming.TabIndex = 1185
        Me.txtstreamnameIGstreaming.Text = "17963323864397049?s_sw=0&s_vt=ig&a=AbwjD78_Hr_oPPPh"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(512, 17)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(61, 13)
        Me.Label22.TabIndex = 1183
        Me.Label22.Text = "Stream Key"
        '
        'txtoptionsIGstreaming
        '
        Me.txtoptionsIGstreaming.Location = New System.Drawing.Point(16, 68)
        Me.txtoptionsIGstreaming.Name = "txtoptionsIGstreaming"
        Me.txtoptionsIGstreaming.Size = New System.Drawing.Size(538, 55)
        Me.txtoptionsIGstreaming.TabIndex = 1180
        Me.txtoptionsIGstreaming.Text = resources.GetString("txtoptionsIGstreaming.Text")
        '
        'cmdsendIGstreaming
        '
        Me.cmdsendIGstreaming.BackColor = System.Drawing.Color.Green
        Me.cmdsendIGstreaming.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsendIGstreaming.ForeColor = System.Drawing.Color.White
        Me.cmdsendIGstreaming.Location = New System.Drawing.Point(560, 70)
        Me.cmdsendIGstreaming.Name = "cmdsendIGstreaming"
        Me.cmdsendIGstreaming.Size = New System.Drawing.Size(50, 53)
        Me.cmdsendIGstreaming.TabIndex = 1179
        Me.cmdsendIGstreaming.Text = "Send"
        Me.cmdsendIGstreaming.UseVisualStyleBackColor = False
        '
        'ucStreaming
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1208, 921)
        Me.Controls.Add(Me.gbstreaming)
        Me.HideOnClose = True
        Me.Name = "ucStreaming"
        Me.Text = "Streaming"
        Me.gbstreaming.ResumeLayout(False)
        Me.gbstreaming.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbstreaming As System.Windows.Forms.GroupBox
    Friend WithEvents cmdstophlsstreaming As System.Windows.Forms.Button
    Friend WithEvents cmdsendhlsstreaming As System.Windows.Forms.Button
    Friend WithEvents txtcommandhlstreaming As System.Windows.Forms.TextBox
    Friend WithEvents Label256 As System.Windows.Forms.Label
    Friend WithEvents txtaddresshlsstreaming As System.Windows.Forms.TextBox
    Friend WithEvents Label257 As System.Windows.Forms.Label
    Friend WithEvents txtoptionshlsstreaming As System.Windows.Forms.RichTextBox
    Friend WithEvents txtstreamnamehlsstreaming As System.Windows.Forms.TextBox
    Friend WithEvents txtapplicationamehlsstreaming As System.Windows.Forms.TextBox
    Friend WithEvents Label259 As System.Windows.Forms.Label
    Friend WithEvents Label260 As System.Windows.Forms.Label
    Friend WithEvents cmdstopwsstreaming As System.Windows.Forms.Button
    Friend WithEvents cmdstopytstreaming As System.Windows.Forms.Button
    Friend WithEvents cmdsendwsstreaming As System.Windows.Forms.Button
    Friend WithEvents txtcommandwsstreaming As System.Windows.Forms.TextBox
    Friend WithEvents Label212 As System.Windows.Forms.Label
    Friend WithEvents Label213 As System.Windows.Forms.Label
    Friend WithEvents txtaddresswsstreaming As System.Windows.Forms.TextBox
    Friend WithEvents Label214 As System.Windows.Forms.Label
    Friend WithEvents txtoptionswsstreaming As System.Windows.Forms.RichTextBox
    Friend WithEvents txtcommandytstreaming As System.Windows.Forms.TextBox
    Friend WithEvents Label211 As System.Windows.Forms.Label
    Friend WithEvents Label210 As System.Windows.Forms.Label
    Friend WithEvents txtaddressytstreaming As System.Windows.Forms.TextBox
    Friend WithEvents Label207 As System.Windows.Forms.Label
    Friend WithEvents txtstreamnameytstreaming As System.Windows.Forms.TextBox
    Friend WithEvents txtapplicationameytstreaming As System.Windows.Forms.TextBox
    Friend WithEvents Label175 As System.Windows.Forms.Label
    Friend WithEvents Label205 As System.Windows.Forms.Label
    Friend WithEvents txtstreamnamewsstreaming As System.Windows.Forms.TextBox
    Friend WithEvents txtapplicationamewsstreaming As System.Windows.Forms.TextBox
    Friend WithEvents Label166 As System.Windows.Forms.Label
    Friend WithEvents Label165 As System.Windows.Forms.Label
    Friend WithEvents txtoptionsytstreaming As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdsendytstreaming As System.Windows.Forms.Button
    Friend WithEvents cmdstopfbstreaming As System.Windows.Forms.Button
    Friend WithEvents txtcommandfbstreaming As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtaddressfbstreaming As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtstreamnamefbstreaming As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtoptionsfbstreaming As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdsendfbstreaming As System.Windows.Forms.Button
    Friend WithEvents cmdplaystreamingcosumer As Button
    Friend WithEvents txtudp As TextBox
    Friend WithEvents cmdStopUDP As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtndi As TextBox
    Friend WithEvents cmdRemoveNDI As Button
    Friend WithEvents cmdAddNDI As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label233 As Label
    Friend WithEvents cmbdecklinkforrecording As ComboBox
    Friend WithEvents cmdremove_input As Button
    Friend WithEvents cmdinput As Button
    Friend WithEvents cmdStopTestSignal As Button
    Friend WithEvents cmdPlayTestSignal As Button
    Friend WithEvents txtPlayTestSignal As TextBox
    Friend WithEvents txtStopTestSignal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents cmdstopytstreaming23 As Button
    Friend WithEvents txtcommandytstreaming23 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtaddressytstreaming23 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtstreamnameytstreaming23 As TextBox
    Friend WithEvents txtapplicationameytstreaming23 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtoptionsytstreaming23 As RichTextBox
    Friend WithEvents cmdsendytstreaming23 As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents cmdstopfbstreaming23 As Button
    Friend WithEvents txtcommandfbstreaming23 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtaddressfbstreaming23 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtstreamnamefbstreaming23 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtoptionsfbstreaming23 As RichTextBox
    Friend WithEvents cmdsendfbstreaming23 As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents cmdstoppipe As Button
    Friend WithEvents txtcommandpipe As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cmdsendpipe As Button
    Friend WithEvents txtremovepipe As TextBox
    Friend WithEvents cmduseinffmpeg As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents txtuseinffmpeg As RichTextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents cmdstopIGstreaming As Button
    Friend WithEvents txtcommandIGstreaming As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtaddressIGstreaming As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtstreamnameIGstreaming As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtoptionsIGstreaming As RichTextBox
    Friend WithEvents cmdsendIGstreaming As Button
End Class
