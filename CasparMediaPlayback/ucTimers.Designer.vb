<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTimers
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
        Me.gbtimers = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtInitialValueofBackinTimer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdplayBackinTimer = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdStopBoth = New System.Windows.Forms.Button()
        Me.cmdStoploop = New System.Windows.Forms.Button()
        Me.cmdloopvideo = New System.Windows.Forms.Button()
        Me.txtloopvideo = New System.Windows.Forms.TextBox()
        Me.txtExactTime = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProgramName = New System.Windows.Forms.TextBox()
        Me.txtsheduleTime = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdplayclipCountDowntimer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttimersTemplate = New System.Windows.Forms.TextBox()
        Me.Label197 = New System.Windows.Forms.Label()
        Me.cmbvflayertimers = New System.Windows.Forms.ComboBox()
        Me.cmdstoptimer = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cmdplayclocktimer = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cmdplayquiztimetimer = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cmdplayfulltimetimer = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label201 = New System.Windows.Forms.Label()
        Me.txtintialvaluecut = New System.Windows.Forms.TextBox()
        Me.Label202 = New System.Windows.Forms.Label()
        Me.cmdplaycountuptimer = New System.Windows.Forms.Button()
        Me.gb = New System.Windows.Forms.GroupBox()
        Me.Label203 = New System.Windows.Forms.Label()
        Me.txtintialvaluecdt = New System.Windows.Forms.TextBox()
        Me.Label204 = New System.Windows.Forms.Label()
        Me.cmdplaycountdowntimer = New System.Windows.Forms.Button()
        Me.tmrclipcountdown = New System.Windows.Forms.Timer(Me.components)
        Me.gbtimers.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbtimers
        '
        Me.gbtimers.BackColor = System.Drawing.Color.PapayaWhip
        Me.gbtimers.Controls.Add(Me.GroupBox3)
        Me.gbtimers.Controls.Add(Me.GroupBox2)
        Me.gbtimers.Controls.Add(Me.GroupBox1)
        Me.gbtimers.Controls.Add(Me.Label1)
        Me.gbtimers.Controls.Add(Me.txttimersTemplate)
        Me.gbtimers.Controls.Add(Me.Label197)
        Me.gbtimers.Controls.Add(Me.cmbvflayertimers)
        Me.gbtimers.Controls.Add(Me.cmdstoptimer)
        Me.gbtimers.Controls.Add(Me.GroupBox6)
        Me.gbtimers.Controls.Add(Me.GroupBox7)
        Me.gbtimers.Controls.Add(Me.GroupBox8)
        Me.gbtimers.Controls.Add(Me.GroupBox9)
        Me.gbtimers.Controls.Add(Me.gb)
        Me.gbtimers.Location = New System.Drawing.Point(4, 4)
        Me.gbtimers.Name = "gbtimers"
        Me.gbtimers.Size = New System.Drawing.Size(594, 520)
        Me.gbtimers.TabIndex = 1162
        Me.gbtimers.TabStop = False
        Me.gbtimers.Text = " "
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Moccasin
        Me.GroupBox3.Controls.Add(Me.txtInitialValueofBackinTimer)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cmdplayBackinTimer)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 277)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 58)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Back in Timer"
        '
        'txtInitialValueofBackinTimer
        '
        Me.txtInitialValueofBackinTimer.Location = New System.Drawing.Point(24, 35)
        Me.txtInitialValueofBackinTimer.Name = "txtInitialValueofBackinTimer"
        Me.txtInitialValueofBackinTimer.Size = New System.Drawing.Size(50, 20)
        Me.txtInitialValueofBackinTimer.TabIndex = 17
        Me.txtInitialValueofBackinTimer.Text = "20"
        Me.txtInitialValueofBackinTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 726
        Me.Label5.Text = "InitialValue in Second"
        '
        'cmdplayBackinTimer
        '
        Me.cmdplayBackinTimer.BackColor = System.Drawing.Color.Green
        Me.cmdplayBackinTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplayBackinTimer.ForeColor = System.Drawing.Color.White
        Me.cmdplayBackinTimer.Location = New System.Drawing.Point(127, 19)
        Me.cmdplayBackinTimer.Name = "cmdplayBackinTimer"
        Me.cmdplayBackinTimer.Size = New System.Drawing.Size(57, 33)
        Me.cmdplayBackinTimer.TabIndex = 6
        Me.cmdplayBackinTimer.Text = "Play"
        Me.cmdplayBackinTimer.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.cmdStopBoth)
        Me.GroupBox2.Controls.Add(Me.cmdStoploop)
        Me.GroupBox2.Controls.Add(Me.cmdloopvideo)
        Me.GroupBox2.Controls.Add(Me.txtloopvideo)
        Me.GroupBox2.Controls.Add(Me.txtExactTime)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtProgramName)
        Me.GroupBox2.Controls.Add(Me.txtsheduleTime)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 358)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(513, 155)
        Me.GroupBox2.TabIndex = 725
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Program CountDown"
        '
        'cmdStopBoth
        '
        Me.cmdStopBoth.BackColor = System.Drawing.Color.Red
        Me.cmdStopBoth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStopBoth.ForeColor = System.Drawing.Color.White
        Me.cmdStopBoth.Location = New System.Drawing.Point(422, 29)
        Me.cmdStopBoth.Name = "cmdStopBoth"
        Me.cmdStopBoth.Size = New System.Drawing.Size(56, 102)
        Me.cmdStopBoth.TabIndex = 16
        Me.cmdStopBoth.Text = "Stop both"
        Me.cmdStopBoth.UseVisualStyleBackColor = False
        '
        'cmdStoploop
        '
        Me.cmdStoploop.BackColor = System.Drawing.Color.Red
        Me.cmdStoploop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStoploop.ForeColor = System.Drawing.Color.White
        Me.cmdStoploop.Location = New System.Drawing.Point(378, 27)
        Me.cmdStoploop.Name = "cmdStoploop"
        Me.cmdStoploop.Size = New System.Drawing.Size(43, 49)
        Me.cmdStoploop.TabIndex = 15
        Me.cmdStoploop.Text = "Stop"
        Me.cmdStoploop.UseVisualStyleBackColor = False
        '
        'cmdloopvideo
        '
        Me.cmdloopvideo.BackColor = System.Drawing.Color.Green
        Me.cmdloopvideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdloopvideo.ForeColor = System.Drawing.Color.White
        Me.cmdloopvideo.Location = New System.Drawing.Point(325, 29)
        Me.cmdloopvideo.Name = "cmdloopvideo"
        Me.cmdloopvideo.Size = New System.Drawing.Size(46, 43)
        Me.cmdloopvideo.TabIndex = 14
        Me.cmdloopvideo.Text = "Play"
        Me.cmdloopvideo.UseVisualStyleBackColor = False
        '
        'txtloopvideo
        '
        Me.txtloopvideo.Location = New System.Drawing.Point(89, 29)
        Me.txtloopvideo.Multiline = True
        Me.txtloopvideo.Name = "txtloopvideo"
        Me.txtloopvideo.Size = New System.Drawing.Size(230, 40)
        Me.txtloopvideo.TabIndex = 13
        Me.txtloopvideo.Text = "play 1-499 amb loop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mixer 1-499 fill 0.06 0.06 0.20 0.20"
        '
        'txtExactTime
        '
        Me.txtExactTime.Location = New System.Drawing.Point(90, 96)
        Me.txtExactTime.Name = "txtExactTime"
        Me.txtExactTime.Size = New System.Drawing.Size(230, 20)
        Me.txtExactTime.TabIndex = 12
        Me.txtExactTime.Text = "At 20:30 PM"
        Me.txtExactTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Exact Time"
        '
        'txtProgramName
        '
        Me.txtProgramName.Location = New System.Drawing.Point(90, 75)
        Me.txtProgramName.Name = "txtProgramName"
        Me.txtProgramName.Size = New System.Drawing.Size(230, 20)
        Me.txtProgramName.TabIndex = 10
        Me.txtProgramName.Text = "Program Name"
        Me.txtProgramName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsheduleTime
        '
        Me.txtsheduleTime.Location = New System.Drawing.Point(89, 118)
        Me.txtsheduleTime.Name = "txtsheduleTime"
        Me.txtsheduleTime.Size = New System.Drawing.Size(230, 20)
        Me.txtsheduleTime.TabIndex = 9
        Me.txtsheduleTime.Text = "Jan 04 20:30:00 GMT+0530 2020"
        Me.txtsheduleTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Shedule Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Program Name"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(325, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 62)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Play"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox1.Controls.Add(Me.cmdplayclipCountDowntimer)
        Me.GroupBox1.Location = New System.Drawing.Point(277, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 58)
        Me.GroupBox1.TabIndex = 724
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clip Name and Countdown"
        '
        'cmdplayclipCountDowntimer
        '
        Me.cmdplayclipCountDowntimer.BackColor = System.Drawing.Color.Green
        Me.cmdplayclipCountDowntimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplayclipCountDowntimer.ForeColor = System.Drawing.Color.White
        Me.cmdplayclipCountDowntimer.Location = New System.Drawing.Point(127, 19)
        Me.cmdplayclipCountDowntimer.Name = "cmdplayclipCountDowntimer"
        Me.cmdplayclipCountDowntimer.Size = New System.Drawing.Size(57, 33)
        Me.cmdplayclipCountDowntimer.TabIndex = 6
        Me.cmdplayclipCountDowntimer.Text = "Play"
        Me.cmdplayclipCountDowntimer.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 723
        Me.Label1.Text = "Template Folder"
        '
        'txttimersTemplate
        '
        Me.txttimersTemplate.Location = New System.Drawing.Point(104, 11)
        Me.txttimersTemplate.Name = "txttimersTemplate"
        Me.txttimersTemplate.Size = New System.Drawing.Size(353, 20)
        Me.txttimersTemplate.TabIndex = 722
        Me.txttimersTemplate.Text = "cmp/timers"
        '
        'Label197
        '
        Me.Label197.AutoSize = True
        Me.Label197.Location = New System.Drawing.Point(472, 11)
        Me.Label197.Name = "Label197"
        Me.Label197.Size = New System.Drawing.Size(52, 13)
        Me.Label197.TabIndex = 16
        Me.Label197.Text = "V-F Layer"
        '
        'cmbvflayertimers
        '
        Me.cmbvflayertimers.FormattingEnabled = True
        Me.cmbvflayertimers.Items.AddRange(New Object() {"500", "501", "502", "503", "504"})
        Me.cmbvflayertimers.Location = New System.Drawing.Point(534, 8)
        Me.cmbvflayertimers.Name = "cmbvflayertimers"
        Me.cmbvflayertimers.Size = New System.Drawing.Size(55, 21)
        Me.cmbvflayertimers.TabIndex = 9
        Me.cmbvflayertimers.Text = "500"
        '
        'cmdstoptimer
        '
        Me.cmdstoptimer.BackColor = System.Drawing.Color.Red
        Me.cmdstoptimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstoptimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdstoptimer.Location = New System.Drawing.Point(528, 58)
        Me.cmdstoptimer.Name = "cmdstoptimer"
        Me.cmdstoptimer.Size = New System.Drawing.Size(61, 455)
        Me.cmdstoptimer.TabIndex = 5
        Me.cmdstoptimer.Text = "Stop"
        Me.cmdstoptimer.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.LightSalmon
        Me.GroupBox6.Controls.Add(Me.cmdplayclocktimer)
        Me.GroupBox6.Location = New System.Drawing.Point(19, 201)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 58)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Clock"
        '
        'cmdplayclocktimer
        '
        Me.cmdplayclocktimer.BackColor = System.Drawing.Color.Green
        Me.cmdplayclocktimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplayclocktimer.ForeColor = System.Drawing.Color.White
        Me.cmdplayclocktimer.Location = New System.Drawing.Point(127, 19)
        Me.cmdplayclocktimer.Name = "cmdplayclocktimer"
        Me.cmdplayclocktimer.Size = New System.Drawing.Size(57, 33)
        Me.cmdplayclocktimer.TabIndex = 6
        Me.cmdplayclocktimer.Text = "Play"
        Me.cmdplayclocktimer.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox7.Controls.Add(Me.cmdplayquiztimetimer)
        Me.GroupBox7.Location = New System.Drawing.Point(276, 134)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(200, 58)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Quiz_time"
        '
        'cmdplayquiztimetimer
        '
        Me.cmdplayquiztimetimer.BackColor = System.Drawing.Color.Green
        Me.cmdplayquiztimetimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplayquiztimetimer.ForeColor = System.Drawing.Color.White
        Me.cmdplayquiztimetimer.Location = New System.Drawing.Point(137, 19)
        Me.cmdplayquiztimetimer.Name = "cmdplayquiztimetimer"
        Me.cmdplayquiztimetimer.Size = New System.Drawing.Size(57, 33)
        Me.cmdplayquiztimetimer.TabIndex = 7
        Me.cmdplayquiztimetimer.Text = "Play"
        Me.cmdplayquiztimetimer.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Tan
        Me.GroupBox8.Controls.Add(Me.cmdplayfulltimetimer)
        Me.GroupBox8.Location = New System.Drawing.Point(19, 134)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(200, 58)
        Me.GroupBox8.TabIndex = 2
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Full_time"
        '
        'cmdplayfulltimetimer
        '
        Me.cmdplayfulltimetimer.BackColor = System.Drawing.Color.Green
        Me.cmdplayfulltimetimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplayfulltimetimer.ForeColor = System.Drawing.Color.White
        Me.cmdplayfulltimetimer.Location = New System.Drawing.Point(137, 19)
        Me.cmdplayfulltimetimer.Name = "cmdplayfulltimetimer"
        Me.cmdplayfulltimetimer.Size = New System.Drawing.Size(57, 33)
        Me.cmdplayfulltimetimer.TabIndex = 9
        Me.cmdplayfulltimetimer.Text = "Play"
        Me.cmdplayfulltimetimer.UseVisualStyleBackColor = False
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.NavajoWhite
        Me.GroupBox9.Controls.Add(Me.Label201)
        Me.GroupBox9.Controls.Add(Me.txtintialvaluecut)
        Me.GroupBox9.Controls.Add(Me.Label202)
        Me.GroupBox9.Controls.Add(Me.cmdplaycountuptimer)
        Me.GroupBox9.Location = New System.Drawing.Point(276, 42)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(200, 82)
        Me.GroupBox9.TabIndex = 1
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Count-up-timer"
        '
        'Label201
        '
        Me.Label201.AutoSize = True
        Me.Label201.Location = New System.Drawing.Point(10, 52)
        Me.Label201.Name = "Label201"
        Me.Label201.Size = New System.Drawing.Size(61, 13)
        Me.Label201.TabIndex = 15
        Me.Label201.Text = "Initial Value"
        '
        'txtintialvaluecut
        '
        Me.txtintialvaluecut.Location = New System.Drawing.Point(77, 49)
        Me.txtintialvaluecut.Name = "txtintialvaluecut"
        Me.txtintialvaluecut.Size = New System.Drawing.Size(51, 20)
        Me.txtintialvaluecut.TabIndex = 14
        Me.txtintialvaluecut.Text = "0"
        '
        'Label202
        '
        Me.Label202.AutoSize = True
        Me.Label202.Location = New System.Drawing.Point(134, 52)
        Me.Label202.Name = "Label202"
        Me.Label202.Size = New System.Drawing.Size(20, 13)
        Me.Label202.TabIndex = 13
        Me.Label202.Text = "ms"
        '
        'cmdplaycountuptimer
        '
        Me.cmdplaycountuptimer.BackColor = System.Drawing.Color.Green
        Me.cmdplaycountuptimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplaycountuptimer.ForeColor = System.Drawing.Color.White
        Me.cmdplaycountuptimer.Location = New System.Drawing.Point(137, 16)
        Me.cmdplaycountuptimer.Name = "cmdplaycountuptimer"
        Me.cmdplaycountuptimer.Size = New System.Drawing.Size(57, 33)
        Me.cmdplaycountuptimer.TabIndex = 11
        Me.cmdplaycountuptimer.Text = "Play"
        Me.cmdplaycountuptimer.UseVisualStyleBackColor = False
        '
        'gb
        '
        Me.gb.BackColor = System.Drawing.Color.SandyBrown
        Me.gb.Controls.Add(Me.Label203)
        Me.gb.Controls.Add(Me.txtintialvaluecdt)
        Me.gb.Controls.Add(Me.Label204)
        Me.gb.Controls.Add(Me.cmdplaycountdowntimer)
        Me.gb.Location = New System.Drawing.Point(19, 42)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(200, 82)
        Me.gb.TabIndex = 0
        Me.gb.TabStop = False
        Me.gb.Text = "Count-down-timer"
        '
        'Label203
        '
        Me.Label203.AutoSize = True
        Me.Label203.Location = New System.Drawing.Point(13, 52)
        Me.Label203.Name = "Label203"
        Me.Label203.Size = New System.Drawing.Size(61, 13)
        Me.Label203.TabIndex = 16
        Me.Label203.Text = "Initial Value"
        '
        'txtintialvaluecdt
        '
        Me.txtintialvaluecdt.Location = New System.Drawing.Point(80, 49)
        Me.txtintialvaluecdt.Name = "txtintialvaluecdt"
        Me.txtintialvaluecdt.Size = New System.Drawing.Size(59, 20)
        Me.txtintialvaluecdt.TabIndex = 12
        Me.txtintialvaluecdt.Text = "180000"
        '
        'Label204
        '
        Me.Label204.AutoSize = True
        Me.Label204.Location = New System.Drawing.Point(145, 52)
        Me.Label204.Name = "Label204"
        Me.Label204.Size = New System.Drawing.Size(20, 13)
        Me.Label204.TabIndex = 11
        Me.Label204.Text = "ms"
        '
        'cmdplaycountdowntimer
        '
        Me.cmdplaycountdowntimer.BackColor = System.Drawing.Color.Green
        Me.cmdplaycountdowntimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplaycountdowntimer.ForeColor = System.Drawing.Color.White
        Me.cmdplaycountdowntimer.Location = New System.Drawing.Point(137, 16)
        Me.cmdplaycountdowntimer.Name = "cmdplaycountdowntimer"
        Me.cmdplaycountdowntimer.Size = New System.Drawing.Size(57, 33)
        Me.cmdplaycountdowntimer.TabIndex = 10
        Me.cmdplaycountdowntimer.Text = "Play"
        Me.cmdplaycountdowntimer.UseVisualStyleBackColor = False
        '
        'tmrclipcountdown
        '
        Me.tmrclipcountdown.Interval = 1000
        '
        'ucTimers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1221, 749)
        Me.Controls.Add(Me.gbtimers)
        Me.HideOnClose = True
        Me.Name = "ucTimers"
        Me.Text = "Timers"
        Me.gbtimers.ResumeLayout(False)
        Me.gbtimers.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.gb.ResumeLayout(False)
        Me.gb.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbtimers As System.Windows.Forms.GroupBox
    Friend WithEvents Label197 As System.Windows.Forms.Label
    Friend WithEvents cmbvflayertimers As System.Windows.Forms.ComboBox
    Friend WithEvents cmdstoptimer As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdplayclocktimer As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdplayquiztimetimer As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdplayfulltimetimer As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label201 As System.Windows.Forms.Label
    Friend WithEvents txtintialvaluecut As System.Windows.Forms.TextBox
    Friend WithEvents Label202 As System.Windows.Forms.Label
    Friend WithEvents cmdplaycountuptimer As System.Windows.Forms.Button
    Friend WithEvents gb As System.Windows.Forms.GroupBox
    Friend WithEvents Label203 As System.Windows.Forms.Label
    Friend WithEvents txtintialvaluecdt As System.Windows.Forms.TextBox
    Friend WithEvents Label204 As System.Windows.Forms.Label
    Friend WithEvents cmdplaycountdowntimer As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txttimersTemplate As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdplayclipCountDowntimer As Button
    Friend WithEvents tmrclipcountdown As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtProgramName As TextBox
    Friend WithEvents txtsheduleTime As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtExactTime As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdloopvideo As Button
    Friend WithEvents txtloopvideo As TextBox
    Friend WithEvents cmdStoploop As Button
    Friend WithEvents cmdStopBoth As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtInitialValueofBackinTimer As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdplayBackinTimer As Button
End Class
