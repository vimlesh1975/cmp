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
        Me.gbstreaming.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbstreaming
        '
        Me.gbstreaming.BackColor = System.Drawing.Color.NavajoWhite
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
        Me.gbstreaming.Size = New System.Drawing.Size(1121, 829)
        Me.gbstreaming.TabIndex = 1169
        Me.gbstreaming.TabStop = False
        Me.gbstreaming.Text = " "
        '
        'txtStopTestSignal
        '
        Me.txtStopTestSignal.Location = New System.Drawing.Point(705, 117)
        Me.txtStopTestSignal.Multiline = True
        Me.txtStopTestSignal.Name = "txtStopTestSignal"
        Me.txtStopTestSignal.Size = New System.Drawing.Size(344, 59)
        Me.txtStopTestSignal.TabIndex = 1214
        Me.txtStopTestSignal.Text = "Stop 1-1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stop 1-2"
        '
        'txtPlayTestSignal
        '
        Me.txtPlayTestSignal.Location = New System.Drawing.Point(705, 52)
        Me.txtPlayTestSignal.Multiline = True
        Me.txtPlayTestSignal.Name = "txtPlayTestSignal"
        Me.txtPlayTestSignal.Size = New System.Drawing.Size(344, 59)
        Me.txtPlayTestSignal.TabIndex = 1213
        Me.txtPlayTestSignal.Text = "Play 1-1 go1080p25 loop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cg 1-2 add 2 cmp/cg_template/clock 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "play 1-2 2"
        '
        'cmdStopTestSignal
        '
        Me.cmdStopTestSignal.Location = New System.Drawing.Point(1055, 117)
        Me.cmdStopTestSignal.Name = "cmdStopTestSignal"
        Me.cmdStopTestSignal.Size = New System.Drawing.Size(63, 59)
        Me.cmdStopTestSignal.TabIndex = 1212
        Me.cmdStopTestSignal.Text = "Stop Test Signal"
        Me.cmdStopTestSignal.UseVisualStyleBackColor = True
        '
        'cmdPlayTestSignal
        '
        Me.cmdPlayTestSignal.Location = New System.Drawing.Point(1055, 55)
        Me.cmdPlayTestSignal.Name = "cmdPlayTestSignal"
        Me.cmdPlayTestSignal.Size = New System.Drawing.Size(63, 56)
        Me.cmdPlayTestSignal.TabIndex = 1210
        Me.cmdPlayTestSignal.Text = "Play Test Signal"
        Me.cmdPlayTestSignal.UseVisualStyleBackColor = True
        '
        'Label233
        '
        Me.Label233.AutoSize = True
        Me.Label233.Location = New System.Drawing.Point(702, 5)
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
        Me.cmbdecklinkforrecording.Location = New System.Drawing.Point(705, 23)
        Me.cmbdecklinkforrecording.Name = "cmbdecklinkforrecording"
        Me.cmbdecklinkforrecording.Size = New System.Drawing.Size(39, 21)
        Me.cmbdecklinkforrecording.TabIndex = 1208
        Me.cmbdecklinkforrecording.Text = "1"
        '
        'cmdremove_input
        '
        Me.cmdremove_input.Location = New System.Drawing.Point(831, 19)
        Me.cmdremove_input.Name = "cmdremove_input"
        Me.cmdremove_input.Size = New System.Drawing.Size(92, 27)
        Me.cmdremove_input.TabIndex = 1207
        Me.cmdremove_input.Text = "Remove Input"
        Me.cmdremove_input.UseVisualStyleBackColor = True
        '
        'cmdinput
        '
        Me.cmdinput.Location = New System.Drawing.Point(757, 19)
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
        Me.GroupBox6.Location = New System.Drawing.Point(6, 744)
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
        Me.GroupBox5.Location = New System.Drawing.Point(6, 654)
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
        Me.GroupBox4.Location = New System.Drawing.Point(6, 497)
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
        Me.cmdstophlsstreaming.Size = New System.Drawing.Size(50, 76)
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
        Me.txtstreamnamehlsstreaming.Text = "myStream.m3u8"
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
        Me.GroupBox3.Location = New System.Drawing.Point(6, 338)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(670, 144)
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
        Me.GroupBox2.Location = New System.Drawing.Point(6, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(670, 149)
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
        Me.cmdstopfbstreaming.Size = New System.Drawing.Size(50, 73)
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
        Me.txtoptionsfbstreaming.Size = New System.Drawing.Size(538, 75)
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
        Me.cmdsendfbstreaming.Size = New System.Drawing.Size(50, 73)
        Me.cmdsendfbstreaming.TabIndex = 1179
        Me.cmdsendfbstreaming.Text = "Send"
        Me.cmdsendfbstreaming.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 809)
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
        Me.GroupBox1.Location = New System.Drawing.Point(6, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 149)
        Me.GroupBox1.TabIndex = 1200
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "YouTube"
        '
        'cmdstopytstreaming
        '
        Me.cmdstopytstreaming.BackColor = System.Drawing.Color.Red
        Me.cmdstopytstreaming.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopytstreaming.ForeColor = System.Drawing.Color.White
        Me.cmdstopytstreaming.Location = New System.Drawing.Point(618, 39)
        Me.cmdstopytstreaming.Name = "cmdstopytstreaming"
        Me.cmdstopytstreaming.Size = New System.Drawing.Size(50, 104)
        Me.cmdstopytstreaming.TabIndex = 26
        Me.cmdstopytstreaming.Text = "Stop"
        Me.cmdstopytstreaming.UseVisualStyleBackColor = False
        '
        'txtcommandytstreaming
        '
        Me.txtcommandytstreaming.Location = New System.Drawing.Point(9, 39)
        Me.txtcommandytstreaming.Name = "txtcommandytstreaming"
        Me.txtcommandytstreaming.Size = New System.Drawing.Size(94, 20)
        Me.txtcommandytstreaming.TabIndex = 18
        Me.txtcommandytstreaming.Text = "ADD 1 STREAM"
        '
        'Label211
        '
        Me.Label211.AutoSize = True
        Me.Label211.Location = New System.Drawing.Point(9, 25)
        Me.Label211.Name = "Label211"
        Me.Label211.Size = New System.Drawing.Size(54, 13)
        Me.Label211.TabIndex = 17
        Me.Label211.Text = "Command"
        '
        'Label210
        '
        Me.Label210.AutoSize = True
        Me.Label210.Location = New System.Drawing.Point(9, 60)
        Me.Label210.Name = "Label210"
        Me.Label210.Size = New System.Drawing.Size(43, 13)
        Me.Label210.TabIndex = 16
        Me.Label210.Text = "Options"
        '
        'txtaddressytstreaming
        '
        Me.txtaddressytstreaming.Location = New System.Drawing.Point(109, 39)
        Me.txtaddressytstreaming.Name = "txtaddressytstreaming"
        Me.txtaddressytstreaming.Size = New System.Drawing.Size(171, 20)
        Me.txtaddressytstreaming.TabIndex = 15
        Me.txtaddressytstreaming.Text = "rtmp://a.rtmp.youtube.com"
        '
        'Label207
        '
        Me.Label207.AutoSize = True
        Me.Label207.Location = New System.Drawing.Point(106, 25)
        Me.Label207.Name = "Label207"
        Me.Label207.Size = New System.Drawing.Size(45, 13)
        Me.Label207.TabIndex = 14
        Me.Label207.Text = "Address"
        '
        'txtstreamnameytstreaming
        '
        Me.txtstreamnameytstreaming.Location = New System.Drawing.Point(357, 39)
        Me.txtstreamnameytstreaming.Name = "txtstreamnameytstreaming"
        Me.txtstreamnameytstreaming.Size = New System.Drawing.Size(190, 20)
        Me.txtstreamnameytstreaming.TabIndex = 11
        Me.txtstreamnameytstreaming.Text = "yeuh-c3wm-x3j0-7gdz"
        '
        'txtapplicationameytstreaming
        '
        Me.txtapplicationameytstreaming.Location = New System.Drawing.Point(283, 39)
        Me.txtapplicationameytstreaming.Name = "txtapplicationameytstreaming"
        Me.txtapplicationameytstreaming.Size = New System.Drawing.Size(68, 20)
        Me.txtapplicationameytstreaming.TabIndex = 10
        Me.txtapplicationameytstreaming.Text = "live2"
        '
        'Label175
        '
        Me.Label175.AutoSize = True
        Me.Label175.Location = New System.Drawing.Point(413, 19)
        Me.Label175.Name = "Label175"
        Me.Label175.Size = New System.Drawing.Size(71, 13)
        Me.Label175.TabIndex = 9
        Me.Label175.Text = "Stream Name"
        '
        'Label205
        '
        Me.Label205.AutoSize = True
        Me.Label205.Location = New System.Drawing.Point(280, 23)
        Me.Label205.Name = "Label205"
        Me.Label205.Size = New System.Drawing.Size(90, 13)
        Me.Label205.TabIndex = 8
        Me.Label205.Text = "Application Name"
        '
        'txtoptionsytstreaming
        '
        Me.txtoptionsytstreaming.Location = New System.Drawing.Point(9, 74)
        Me.txtoptionsytstreaming.Name = "txtoptionsytstreaming"
        Me.txtoptionsytstreaming.Size = New System.Drawing.Size(538, 69)
        Me.txtoptionsytstreaming.TabIndex = 1
        Me.txtoptionsytstreaming.Text = resources.GetString("txtoptionsytstreaming.Text")
        '
        'cmdsendytstreaming
        '
        Me.cmdsendytstreaming.BackColor = System.Drawing.Color.Green
        Me.cmdsendytstreaming.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsendytstreaming.ForeColor = System.Drawing.Color.White
        Me.cmdsendytstreaming.Location = New System.Drawing.Point(553, 39)
        Me.cmdsendytstreaming.Name = "cmdsendytstreaming"
        Me.cmdsendytstreaming.Size = New System.Drawing.Size(50, 104)
        Me.cmdsendytstreaming.TabIndex = 0
        Me.cmdsendytstreaming.Text = "Send"
        Me.cmdsendytstreaming.UseVisualStyleBackColor = False
        '
        'ucStreaming
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1127, 839)
        Me.Controls.Add(Me.gbstreaming)
        Me.HideOnClose = True
        Me.Name = "ucStreaming"
        Me.Text = "Streaming"
        Me.gbstreaming.ResumeLayout(False)
        Me.gbstreaming.PerformLayout()
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
End Class
