﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucnewRecorder
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucnewRecorder))
        Me.gbrecording = New System.Windows.Forms.GroupBox()
        Me.cmdcloseRecorder = New System.Windows.Forms.Button()
        Me.ProgressBar2 = New VerticalProgressBar.VerticalProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New VerticalProgressBar.VerticalProgressBar()
        Me.pnlrecording = New System.Windows.Forms.Panel()
        Me.cmbcasparcgwindowtitlerecording = New System.Windows.Forms.ComboBox()
        Me.cmdoutcasparcgwindowrecording = New System.Windows.Forms.Button()
        Me.cmdshowcasparcgwindowrecording = New System.Windows.Forms.Button()
        Me.Label233 = New System.Windows.Forms.Label()
        Me.cmbdecklinkforrecording = New System.Windows.Forms.ComboBox()
        Me.cmdopenintrimmer = New System.Windows.Forms.Button()
        Me.lblRecordingFolder = New System.Windows.Forms.Label()
        Me.cmdOpenFolderforRecording = New System.Windows.Forms.Button()
        Me.Label152 = New System.Windows.Forms.Label()
        Me.lblfreespace = New System.Windows.Forms.Label()
        Me.cmdlocaterecordingfile = New System.Windows.Forms.Button()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.lblRecordedSize = New System.Windows.Forms.Label()
        Me.lblRecordedduration = New System.Windows.Forms.Label()
        Me.lblrecordingfilename = New System.Windows.Forms.Label()
        Me.chksinglecliprecord = New System.Windows.Forms.CheckBox()
        Me.txtextrarecordoptions = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtfilename = New System.Windows.Forms.TextBox()
        Me.cmdremove_input = New System.Windows.Forms.Button()
        Me.mp4 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbitrate = New System.Windows.Forms.TextBox()
        Me.cmdlooprecord = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdstoplooprecord = New System.Windows.Forms.Button()
        Me.txtinterval = New System.Windows.Forms.TextBox()
        Me.lblinterval = New System.Windows.Forms.Label()
        Me.cmdinput = New System.Windows.Forms.Button()
        Me.tmrrecorder = New System.Windows.Forms.Timer(Me.components)
        Me.tmrrecordedfileinfo = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbrecording.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbrecording
        '
        Me.gbrecording.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.gbrecording.Controls.Add(Me.cmdcloseRecorder)
        Me.gbrecording.Controls.Add(Me.ProgressBar2)
        Me.gbrecording.Controls.Add(Me.Label2)
        Me.gbrecording.Controls.Add(Me.ProgressBar1)
        Me.gbrecording.Controls.Add(Me.pnlrecording)
        Me.gbrecording.Controls.Add(Me.cmbcasparcgwindowtitlerecording)
        Me.gbrecording.Controls.Add(Me.cmdoutcasparcgwindowrecording)
        Me.gbrecording.Controls.Add(Me.cmdshowcasparcgwindowrecording)
        Me.gbrecording.Controls.Add(Me.Label233)
        Me.gbrecording.Controls.Add(Me.cmbdecklinkforrecording)
        Me.gbrecording.Controls.Add(Me.cmdopenintrimmer)
        Me.gbrecording.Controls.Add(Me.lblRecordingFolder)
        Me.gbrecording.Controls.Add(Me.cmdOpenFolderforRecording)
        Me.gbrecording.Controls.Add(Me.Label152)
        Me.gbrecording.Controls.Add(Me.lblfreespace)
        Me.gbrecording.Controls.Add(Me.cmdlocaterecordingfile)
        Me.gbrecording.Controls.Add(Me.Label128)
        Me.gbrecording.Controls.Add(Me.Label129)
        Me.gbrecording.Controls.Add(Me.Label130)
        Me.gbrecording.Controls.Add(Me.lblRecordedSize)
        Me.gbrecording.Controls.Add(Me.lblRecordedduration)
        Me.gbrecording.Controls.Add(Me.lblrecordingfilename)
        Me.gbrecording.Controls.Add(Me.chksinglecliprecord)
        Me.gbrecording.Controls.Add(Me.txtextrarecordoptions)
        Me.gbrecording.Controls.Add(Me.Label22)
        Me.gbrecording.Controls.Add(Me.txtfilename)
        Me.gbrecording.Controls.Add(Me.cmdremove_input)
        Me.gbrecording.Controls.Add(Me.mp4)
        Me.gbrecording.Controls.Add(Me.Label4)
        Me.gbrecording.Controls.Add(Me.Label1)
        Me.gbrecording.Controls.Add(Me.txtbitrate)
        Me.gbrecording.Controls.Add(Me.cmdlooprecord)
        Me.gbrecording.Controls.Add(Me.Label3)
        Me.gbrecording.Controls.Add(Me.cmdstoplooprecord)
        Me.gbrecording.Controls.Add(Me.txtinterval)
        Me.gbrecording.Controls.Add(Me.lblinterval)
        Me.gbrecording.Controls.Add(Me.cmdinput)
        Me.gbrecording.ForeColor = System.Drawing.Color.Black
        Me.gbrecording.Location = New System.Drawing.Point(2, 3)
        Me.gbrecording.Name = "gbrecording"
        Me.gbrecording.Size = New System.Drawing.Size(567, 286)
        Me.gbrecording.TabIndex = 178
        Me.gbrecording.TabStop = False
        Me.gbrecording.Text = "Recording"
        '
        'cmdcloseRecorder
        '
        Me.cmdcloseRecorder.Image = CType(resources.GetObject("cmdcloseRecorder.Image"), System.Drawing.Image)
        Me.cmdcloseRecorder.Location = New System.Drawing.Point(532, 11)
        Me.cmdcloseRecorder.Name = "cmdcloseRecorder"
        Me.cmdcloseRecorder.Size = New System.Drawing.Size(28, 27)
        Me.cmdcloseRecorder.TabIndex = 1196
        Me.cmdcloseRecorder.UseVisualStyleBackColor = True
        '
        'ProgressBar2
        '
        Me.ProgressBar2.BorderStyle = VerticalProgressBar.BorderStyles.Classic
        Me.ProgressBar2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressBar2.Location = New System.Drawing.Point(549, 108)
        Me.ProgressBar2.Maximum = 40
        Me.ProgressBar2.Minimum = 0
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(11, 176)
        Me.ProgressBar2.Step = 1
        Me.ProgressBar2.Style = VerticalProgressBar.Styles.Classic
        Me.ProgressBar2.TabIndex = 736
        Me.ProgressBar2.Value = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(75, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 734
        Me.Label2.Text = "Channel 1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BorderStyle = VerticalProgressBar.BorderStyles.Classic
        Me.ProgressBar1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(296, 108)
        Me.ProgressBar1.Maximum = 40
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(11, 176)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = VerticalProgressBar.Styles.Classic
        Me.ProgressBar1.TabIndex = 735
        Me.ProgressBar1.Value = 40
        '
        'pnlrecording
        '
        Me.pnlrecording.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlrecording.Location = New System.Drawing.Point(308, 108)
        Me.pnlrecording.Name = "pnlrecording"
        Me.pnlrecording.Size = New System.Drawing.Size(235, 176)
        Me.pnlrecording.TabIndex = 157
        '
        'cmbcasparcgwindowtitlerecording
        '
        Me.cmbcasparcgwindowtitlerecording.FormattingEnabled = True
        Me.cmbcasparcgwindowtitlerecording.Items.AddRange(New Object() {"Screen consumer [1|PAL]", "Screen consumer [2|PAL]", "Screen consumer [3|PAL]", "Screen consumer [4|PAL]", "Screen consumer [1|NTSC]", "Screen consumer [1|1080i5000]", "Screen consumer [1|1080i5994]", "Screen consumer [1|1080i6000]", "Screen consumer [1|1080p2398]", "Screen consumer [1|1080p2400]", "Screen consumer [1|1080p2500]", "Screen consumer [1|1080p2997]", "Screen consumer [1|1080p3000]", "Screen consumer [1|1080p5000]", "Screen consumer [1|1080p5994]", "Screen consumer [1|1080p6000]", "Screen consumer [1|1556p2398]", "Screen consumer [1|1556p2400]", "Screen consumer [1|1556p2500]", "Screen consumer [1|2160p2398]", "Screen consumer [1|2160p2400]", "Screen consumer [1|2160p2500]", "Screen consumer [1| 2160p2997]", "Screen consumer [1|2160p3000]", "Screen consumer [1|576p2500]", "Screen consumer [1|720p2398]", "Screen consumer [1|720p2400]", "Screen consumer [1|720p2500]", "Screen consumer [1|720p2997]", "Screen consumer [1|720p3000]", "Screen consumer [1|720p5000]", "Screen consumer [1|720p5994]", "Screen consumer [1|720p6000]"})
        Me.cmbcasparcgwindowtitlerecording.Location = New System.Drawing.Point(294, 82)
        Me.cmbcasparcgwindowtitlerecording.Name = "cmbcasparcgwindowtitlerecording"
        Me.cmbcasparcgwindowtitlerecording.Size = New System.Drawing.Size(150, 21)
        Me.cmbcasparcgwindowtitlerecording.TabIndex = 733
        Me.cmbcasparcgwindowtitlerecording.Text = "Screen consumer [1|PAL]"
        '
        'cmdoutcasparcgwindowrecording
        '
        Me.cmdoutcasparcgwindowrecording.Location = New System.Drawing.Point(482, 79)
        Me.cmdoutcasparcgwindowrecording.Name = "cmdoutcasparcgwindowrecording"
        Me.cmdoutcasparcgwindowrecording.Size = New System.Drawing.Size(47, 23)
        Me.cmdoutcasparcgwindowrecording.TabIndex = 732
        Me.cmdoutcasparcgwindowrecording.Text = "OUT"
        Me.cmdoutcasparcgwindowrecording.UseVisualStyleBackColor = True
        '
        'cmdshowcasparcgwindowrecording
        '
        Me.cmdshowcasparcgwindowrecording.Location = New System.Drawing.Point(449, 79)
        Me.cmdshowcasparcgwindowrecording.Name = "cmdshowcasparcgwindowrecording"
        Me.cmdshowcasparcgwindowrecording.Size = New System.Drawing.Size(32, 23)
        Me.cmdshowcasparcgwindowrecording.TabIndex = 731
        Me.cmdshowcasparcgwindowrecording.Text = "IN"
        Me.cmdshowcasparcgwindowrecording.UseVisualStyleBackColor = True
        '
        'Label233
        '
        Me.Label233.AutoSize = True
        Me.Label233.Location = New System.Drawing.Point(1, 18)
        Me.Label233.Name = "Label233"
        Me.Label233.Size = New System.Drawing.Size(49, 13)
        Me.Label233.TabIndex = 713
        Me.Label233.Text = "Decklink"
        '
        'cmbdecklinkforrecording
        '
        Me.cmbdecklinkforrecording.FormattingEnabled = True
        Me.cmbdecklinkforrecording.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbdecklinkforrecording.Location = New System.Drawing.Point(4, 36)
        Me.cmbdecklinkforrecording.Name = "cmbdecklinkforrecording"
        Me.cmbdecklinkforrecording.Size = New System.Drawing.Size(39, 21)
        Me.cmbdecklinkforrecording.TabIndex = 712
        Me.cmbdecklinkforrecording.Text = "1"
        '
        'cmdopenintrimmer
        '
        Me.cmdopenintrimmer.Location = New System.Drawing.Point(185, 234)
        Me.cmdopenintrimmer.Name = "cmdopenintrimmer"
        Me.cmdopenintrimmer.Size = New System.Drawing.Size(93, 23)
        Me.cmdopenintrimmer.TabIndex = 711
        Me.cmdopenintrimmer.Text = "Open in Trimmer"
        Me.cmdopenintrimmer.UseVisualStyleBackColor = True
        '
        'lblRecordingFolder
        '
        Me.lblRecordingFolder.AutoSize = True
        Me.lblRecordingFolder.Location = New System.Drawing.Point(102, 87)
        Me.lblRecordingFolder.Name = "lblRecordingFolder"
        Me.lblRecordingFolder.Size = New System.Drawing.Size(109, 13)
        Me.lblRecordingFolder.TabIndex = 709
        Me.lblRecordingFolder.Text = "c:\casparcg\_media\"
        '
        'cmdOpenFolderforRecording
        '
        Me.cmdOpenFolderforRecording.Location = New System.Drawing.Point(7, 82)
        Me.cmdOpenFolderforRecording.Name = "cmdOpenFolderforRecording"
        Me.cmdOpenFolderforRecording.Size = New System.Drawing.Size(85, 23)
        Me.cmdOpenFolderforRecording.TabIndex = 708
        Me.cmdOpenFolderforRecording.Text = "Select Folder"
        Me.cmdOpenFolderforRecording.UseVisualStyleBackColor = True
        '
        'Label152
        '
        Me.Label152.AutoSize = True
        Me.Label152.Location = New System.Drawing.Point(274, 40)
        Me.Label152.Name = "Label152"
        Me.Label152.Size = New System.Drawing.Size(62, 13)
        Me.Label152.TabIndex = 168
        Me.Label152.Text = "Free Space"
        '
        'lblfreespace
        '
        Me.lblfreespace.AutoSize = True
        Me.lblfreespace.Location = New System.Drawing.Point(342, 42)
        Me.lblfreespace.Name = "lblfreespace"
        Me.lblfreespace.Size = New System.Drawing.Size(103, 13)
        Me.lblfreespace.TabIndex = 167
        Me.lblfreespace.Text = "lblfreespacerecorcer"
        '
        'cmdlocaterecordingfile
        '
        Me.cmdlocaterecordingfile.Location = New System.Drawing.Point(5, 62)
        Me.cmdlocaterecordingfile.Name = "cmdlocaterecordingfile"
        Me.cmdlocaterecordingfile.Size = New System.Drawing.Size(51, 20)
        Me.cmdlocaterecordingfile.TabIndex = 166
        Me.cmdlocaterecordingfile.Text = "Locate"
        Me.cmdlocaterecordingfile.UseVisualStyleBackColor = True
        '
        'Label128
        '
        Me.Label128.AutoSize = True
        Me.Label128.Location = New System.Drawing.Point(259, 25)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(77, 13)
        Me.Label128.TabIndex = 165
        Me.Label128.Text = "Recorded Size"
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.Location = New System.Drawing.Point(239, 10)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(97, 13)
        Me.Label129.TabIndex = 164
        Me.Label129.Text = "Recorded Duration"
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.Location = New System.Drawing.Point(69, 66)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(23, 13)
        Me.Label130.TabIndex = 163
        Me.Label130.Text = "File"
        '
        'lblRecordedSize
        '
        Me.lblRecordedSize.AutoSize = True
        Me.lblRecordedSize.Location = New System.Drawing.Point(342, 26)
        Me.lblRecordedSize.Name = "lblRecordedSize"
        Me.lblRecordedSize.Size = New System.Drawing.Size(77, 13)
        Me.lblRecordedSize.TabIndex = 162
        Me.lblRecordedSize.Text = "Recorded Size"
        '
        'lblRecordedduration
        '
        Me.lblRecordedduration.AutoSize = True
        Me.lblRecordedduration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordedduration.ForeColor = System.Drawing.Color.DarkRed
        Me.lblRecordedduration.Location = New System.Drawing.Point(342, 10)
        Me.lblRecordedduration.Name = "lblRecordedduration"
        Me.lblRecordedduration.Size = New System.Drawing.Size(139, 16)
        Me.lblRecordedduration.TabIndex = 161
        Me.lblRecordedduration.Text = "Recorded Duration"
        '
        'lblrecordingfilename
        '
        Me.lblrecordingfilename.AutoSize = True
        Me.lblrecordingfilename.Location = New System.Drawing.Point(99, 65)
        Me.lblrecordingfilename.MaximumSize = New System.Drawing.Size(300, 0)
        Me.lblrecordingfilename.Name = "lblrecordingfilename"
        Me.lblrecordingfilename.Size = New System.Drawing.Size(51, 13)
        Me.lblrecordingfilename.TabIndex = 160
        Me.lblrecordingfilename.Text = "FileName"
        '
        'chksinglecliprecord
        '
        Me.chksinglecliprecord.AutoSize = True
        Me.chksinglecliprecord.Checked = True
        Me.chksinglecliprecord.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chksinglecliprecord.Location = New System.Drawing.Point(158, 113)
        Me.chksinglecliprecord.Name = "chksinglecliprecord"
        Me.chksinglecliprecord.Size = New System.Drawing.Size(75, 17)
        Me.chksinglecliprecord.TabIndex = 159
        Me.chksinglecliprecord.Text = "Single Clip"
        Me.chksinglecliprecord.UseVisualStyleBackColor = True
        '
        'txtextrarecordoptions
        '
        Me.txtextrarecordoptions.Location = New System.Drawing.Point(83, 208)
        Me.txtextrarecordoptions.Name = "txtextrarecordoptions"
        Me.txtextrarecordoptions.Size = New System.Drawing.Size(209, 20)
        Me.txtextrarecordoptions.TabIndex = 158
        Me.txtextrarecordoptions.Text = "-codec:v mpeg4 -g 1 -alternate_scan 1"
        Me.txtextrarecordoptions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(7, 211)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 13)
        Me.Label22.TabIndex = 157
        Me.Label22.Text = "Extra options"
        '
        'txtfilename
        '
        Me.txtfilename.Location = New System.Drawing.Point(65, 182)
        Me.txtfilename.Name = "txtfilename"
        Me.txtfilename.Size = New System.Drawing.Size(209, 20)
        Me.txtfilename.TabIndex = 156
        Me.txtfilename.Text = "test1"
        Me.txtfilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdremove_input
        '
        Me.cmdremove_input.Location = New System.Drawing.Point(123, 35)
        Me.cmdremove_input.Name = "cmdremove_input"
        Me.cmdremove_input.Size = New System.Drawing.Size(92, 27)
        Me.cmdremove_input.TabIndex = 155
        Me.cmdremove_input.Text = "Remove Input"
        Me.cmdremove_input.UseVisualStyleBackColor = True
        '
        'mp4
        '
        Me.mp4.FormattingEnabled = True
        Me.mp4.Items.AddRange(New Object() {"avi", "dv", "mov", "mp4", "mxf", "ogg", "ts"})
        Me.mp4.Location = New System.Drawing.Point(73, 155)
        Me.mp4.Name = "mp4"
        Me.mp4.Size = New System.Drawing.Size(53, 21)
        Me.mp4.Sorted = True
        Me.mp4.TabIndex = 155
        Me.mp4.Text = "mp4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "File Format"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Filename"
        '
        'txtbitrate
        '
        Me.txtbitrate.Location = New System.Drawing.Point(89, 133)
        Me.txtbitrate.Name = "txtbitrate"
        Me.txtbitrate.Size = New System.Drawing.Size(53, 20)
        Me.txtbitrate.TabIndex = 142
        Me.txtbitrate.Text = "15"
        Me.txtbitrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdlooprecord
        '
        Me.cmdlooprecord.BackColor = System.Drawing.Color.Red
        Me.cmdlooprecord.Location = New System.Drawing.Point(11, 235)
        Me.cmdlooprecord.Name = "cmdlooprecord"
        Me.cmdlooprecord.Size = New System.Drawing.Size(73, 23)
        Me.cmdlooprecord.TabIndex = 139
        Me.cmdlooprecord.Text = "Record"
        Me.cmdlooprecord.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Bit Rate Mbps"
        '
        'cmdstoplooprecord
        '
        Me.cmdstoplooprecord.Location = New System.Drawing.Point(86, 234)
        Me.cmdstoplooprecord.Name = "cmdstoplooprecord"
        Me.cmdstoplooprecord.Size = New System.Drawing.Size(93, 23)
        Me.cmdstoplooprecord.TabIndex = 140
        Me.cmdstoplooprecord.Text = "Stop Record"
        Me.cmdstoplooprecord.UseVisualStyleBackColor = True
        '
        'txtinterval
        '
        Me.txtinterval.Location = New System.Drawing.Point(97, 112)
        Me.txtinterval.Name = "txtinterval"
        Me.txtinterval.Size = New System.Drawing.Size(53, 20)
        Me.txtinterval.TabIndex = 138
        Me.txtinterval.Text = "3600"
        Me.txtinterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblinterval
        '
        Me.lblinterval.AutoSize = True
        Me.lblinterval.Location = New System.Drawing.Point(7, 114)
        Me.lblinterval.Name = "lblinterval"
        Me.lblinterval.Size = New System.Drawing.Size(87, 13)
        Me.lblinterval.TabIndex = 138
        Me.lblinterval.Text = "File Length (Sec)"
        '
        'cmdinput
        '
        Me.cmdinput.Location = New System.Drawing.Point(49, 35)
        Me.cmdinput.Name = "cmdinput"
        Me.cmdinput.Size = New System.Drawing.Size(70, 27)
        Me.cmdinput.TabIndex = 142
        Me.cmdinput.Text = "Show input"
        Me.cmdinput.UseVisualStyleBackColor = True
        '
        'tmrrecorder
        '
        '
        'tmrrecordedfileinfo
        '
        Me.tmrrecordedfileinfo.Interval = 1000
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Time Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'ucnewRecorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.gbrecording)
        Me.Name = "ucnewRecorder"
        Me.Size = New System.Drawing.Size(572, 292)
        Me.gbrecording.ResumeLayout(False)
        Me.gbrecording.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbrecording As System.Windows.Forms.GroupBox
    Friend WithEvents pnlrecording As System.Windows.Forms.Panel
    Friend WithEvents cmbcasparcgwindowtitlerecording As System.Windows.Forms.ComboBox
    Friend WithEvents cmdoutcasparcgwindowrecording As System.Windows.Forms.Button
    Friend WithEvents cmdshowcasparcgwindowrecording As System.Windows.Forms.Button
    Friend WithEvents Label233 As System.Windows.Forms.Label
    Friend WithEvents cmbdecklinkforrecording As System.Windows.Forms.ComboBox
    Friend WithEvents cmdopenintrimmer As System.Windows.Forms.Button
    Friend WithEvents lblRecordingFolder As System.Windows.Forms.Label
    Friend WithEvents cmdOpenFolderforRecording As System.Windows.Forms.Button
    Friend WithEvents Label152 As System.Windows.Forms.Label
    Friend WithEvents lblfreespace As System.Windows.Forms.Label
    Friend WithEvents cmdlocaterecordingfile As System.Windows.Forms.Button
    Friend WithEvents Label128 As System.Windows.Forms.Label
    Friend WithEvents Label129 As System.Windows.Forms.Label
    Friend WithEvents Label130 As System.Windows.Forms.Label
    Friend WithEvents lblRecordedSize As System.Windows.Forms.Label
    Friend WithEvents lblRecordedduration As System.Windows.Forms.Label
    Friend WithEvents lblrecordingfilename As System.Windows.Forms.Label
    Friend WithEvents chksinglecliprecord As System.Windows.Forms.CheckBox
    Friend WithEvents txtextrarecordoptions As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtfilename As System.Windows.Forms.TextBox
    Friend WithEvents cmdremove_input As System.Windows.Forms.Button
    Friend WithEvents mp4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbitrate As System.Windows.Forms.TextBox
    Friend WithEvents cmdlooprecord As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdstoplooprecord As System.Windows.Forms.Button
    Friend WithEvents txtinterval As System.Windows.Forms.TextBox
    Friend WithEvents lblinterval As System.Windows.Forms.Label
    Friend WithEvents cmdinput As System.Windows.Forms.Button
    Friend WithEvents tmrrecorder As System.Windows.Forms.Timer
    Friend WithEvents tmrrecordedfileinfo As System.Windows.Forms.Timer
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents ProgressBar1 As VerticalProgressBar.VerticalProgressBar
    Friend WithEvents cmdcloseRecorder As System.Windows.Forms.Button
End Class
