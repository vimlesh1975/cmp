Imports System.IO
Imports Bespoke.Common
Imports Bespoke.Common.Osc
Imports System.Net
Public Class ucSMRecorder
    Public chnumber As Integer = 1
    Public oscportnumber As Integer
    Dim lengthfilename As Integer
    Dim filename As String
    Dim irecorder As Integer = 0
    Dim startingtimeofrecording As DateTime
    Private Sub cmdoutcasparcgwindowrecording_Click(sender As Object, e As EventArgs) Handles cmdoutcasparcgwindowrecording.Click
        On Error Resume Next
        If Not parentedProcess1 Is Nothing Then
            SetParent(parentedProcess1.MainWindowHandle, Nothing)
        End If
    End Sub
    Public parentedProcess1 As Process
    Public Sub SetProcessParentrecorder(ByVal processName As String, ByVal cmb As ComboBox, ByVal pnl As Panel)
        On Error Resume Next
        'Retrieve an array of running processes with the given name
        Dim processes() As Process = Process.GetProcessesByName(processName)
        Dim iprocess As Integer
        For iprocess = 0 To processes.GetUpperBound(0)
            If processes(iprocess).MainWindowTitle = cmb.Text Then Exit For
        Next
        parentedProcess1 = processes(iprocess)
        SetParent(parentedProcess1.MainWindowHandle, pnl.Handle)
        SendMessage(parentedProcess1.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)
    End Sub
    Private Sub cmdshowcasparcgwindowrecording_Click(sender As Object, e As EventArgs) Handles cmdshowcasparcgwindowrecording.Click
        On Error Resume Next
        SetProcessParentrecorder("casparcg", cmbcasparcgwindowtitlerecording, pnlrecording)
    End Sub
    Private Sub cmdinput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdinput.Click
        On Error Resume Next
        If frmmediaplayer.cmdconnect.BackColor = Color.Green Then
            Dim str As String

            str = "play " & chnumber & "-1" & " decklink " & cmbdecklinkforrecording.Text
            CasparDevice.SendString(str)
        End If
    End Sub

    Private Sub cmdlocaterecordingfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlocaterecordingfile.Click
        Process.Start("explorer.exe", "/select," & Replace(lblrecordingfilename.Text, "/", "\"))
    End Sub


    Private Sub cmdOpenFolderforRecording_Click(sender As Object, e As EventArgs) Handles cmdOpenFolderforRecording.Click
        On Error Resume Next



        Dim aa As New OpenFileDialog
        aa.DereferenceLinks = False
        aa.CheckFileExists = False
        aa.CheckPathExists = False
        aa.Filter = "folders|n"
        aa.Title = "Select Folder"
        aa.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media"
        aa.FileName = aa.InitialDirectory & "select folder"
        If aa.ShowDialog() = DialogResult.OK Then
            lblRecordingFolder.Text = Directory.GetParent(aa.FileName).ToString & "\"
        End If
    End Sub



    Private Sub cmdremove_input_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremove_input.Click
        On Error Resume Next
        If frmmediaplayer.cmdconnect.BackColor = Color.Green Then
            Dim str = "stop " & chnumber & "-1"
            CasparDevice.SendString(str)

        End If
    End Sub



    Private Sub cmdlooprecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlooprecord.Click
        On Error Resume Next
        If frmmediaplayer.cmdconnect.BackColor = Color.Green And sender.BackColor = Color.Red Then
            record()
            tmrrecorder.Interval = (txtinterval.Text) * 1000
            tmrrecorder.Enabled = True
            tmrrecordedfileinfo.Enabled = True

        End If
        lengthfilename = Len(txtfilename.Text)
        filename = txtfilename.Text
        irecorder = 0

    End Sub


    Private Sub cmdstoplooprecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstoplooprecord.Click
        On Error Resume Next
        stoprecord()
        irecorder = irecorder + 1
        Dim aa = Split(filename, "_")
        Dim bb As Integer
        If Integer.TryParse(aa.Last, bb) Then
            txtfilename.Text = Mid(filename, 1, Len(filename) - Len(aa.Last)) & aa.Last + 1
        Else
            txtfilename.Text = filename & "_" & irecorder
        End If
        tmrrecorder.Enabled = False
        tmrrecordedfileinfo.Enabled = False '  recordingfileblank()
    End Sub

    Sub record()
        On Error Resume Next
        lblRecordedduration.Text = ""
        lblRecordedSize.Text = ""

        Dim str As String
        str = "ADD " & chnumber & " FILE " & """" & Replace(Mid(lblRecordingFolder.Text, Len(mediafullpath) + 1), "\", "/") & "/" & txtfilename.Text & "." & mp4.Text & """" & " -b:v " & Val(txtbitrate.Text) & "000k -minrate " & Val(txtbitrate.Text) & "000k -maxrate " & Val(txtbitrate.Text) & "000k " & txtextrarecordoptions.Text
        CasparDevice.SendString(str)

        startingtimeofrecording = Now
        If frmmediaplayer.cmdconnect.BackColor = Color.Green Then cmdlooprecord.BackColor = Color.Green
    End Sub
    Sub stoprecord()
        On Error Resume Next
        Dim str As String
        str = "REMOVE " & chnumber & " FILE " & "/" & txtfilename.Text & "." & mp4.Text

        CasparDevice.SendString(str)
        cmdlooprecord.BackColor = Color.Red
    End Sub
    Private Sub tmrrecorder_Tick(sender As Object, e As EventArgs) Handles tmrrecorder.Tick
        On Error Resume Next
        stoprecord()
        If chksinglecliprecord.Checked = False Then
            irecorder = irecorder + 1
            txtfilename.Text = filename & "_" & irecorder
            record()
        Else
            tmrrecorder.Enabled = False
            tmrrecordedfileinfo.Enabled = False
        End If
    End Sub
    Private Sub tmrrecordedfileinfo_Tick(sender As Object, e As EventArgs) Handles tmrrecordedfileinfo.Tick

        On Error Resume Next
        lblrecordingfilename.Text = lblRecordingFolder.Text & txtfilename.Text & "." & mp4.Text
        If File.Exists(lblrecordingfilename.Text) Then
            Dim f As New FileInfo(lblrecordingfilename.Text)

            Dim recoredduration As TimeSpan = Now - startingtimeofrecording
            lblRecordedduration.Text = recoredduration.ToString("hh\:mm\:ss")
            lblRecordedSize.Text = f.Length / 1000000 & " MB"

        Else
        End If
    End Sub


    Private Sub ucnewRecorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        lblRecordingFolder.Text = mediafullpath & "Ch" & chnumber & "/"

    End Sub

    Private Sub cmdcloseRecorder_Click(sender As Object, e As EventArgs) Handles cmdcloseRecorder.Click
        stoprecord()
        cmdoutcasparcgwindowrecording.PerformClick()

        Parent.Controls.Remove(Me)
    End Sub

    Private Sub cmbChannel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChannel.SelectedIndexChanged
        chnumber = cmbChannel.Text
        lblRecordingFolder.Text = "c:\casparcg\_media\ch" & chnumber & "\"
        txtfilename.Text = "test" & chnumber
        Label2.Text = "Channel " & cmbChannel.Text
        cmbcasparcgwindowtitlerecording.Text = "Screen consumer [" & cmbChannel.Text & "|PAL]"

    End Sub

    Private Sub cmdPlay_Click(sender As Object, e As EventArgs) Handles cmdPlay.Click
        loadinsm()
    End Sub
    Sub loadinsm()
        On Error Resume Next

        With ucSlowMotion21
            If cmbChannelDestination.Text = .UcnewSM21.cmbChannel.Text Then
                CasparDevice.SendString("load " & cmbChannelDestination.Text & "-" & 1 & " " & """" & Replace(Replace(lblrecordingfilename.Text, ":", ":\"), "\", "/") & """")
                .UcnewSM21.lblmax.Text = HMStoF(getdurationofclip(lblrecordingfilename.Text))
                .UcnewSM21.lblplaying.Text = Replace(Replace(lblrecordingfilename.Text, ":", ":\"), "\", "/")
                .UcnewSM21.TrackBarseek.Maximum = .UcnewSM21.lblmax.Text
                .UcnewSM21.TrackBarseek.Value = 0

            ElseIf cmbChannelDestination.Text = .UcnewSM22.cmbChannel.Text Then
                CasparDevice.SendString("load " & cmbChannelDestination.Text & "-" & 1 & " " & """" & Replace(Replace(lblrecordingfilename.Text, ":", ":\"), "\", "/") & """")
                .UcnewSM22.lblmax.Text = HMStoF(getdurationofclip(lblrecordingfilename.Text))
                .UcnewSM22.lblplaying.Text = Replace(Replace(lblrecordingfilename.Text, ":", ":\"), "\", "/")
                .UcnewSM22.TrackBarseek.Maximum = .UcnewSM22.lblmax.Text
                .UcnewSM22.TrackBarseek.Value = 0
            End If
        End With
    End Sub

End Class


