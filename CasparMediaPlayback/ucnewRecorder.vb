Imports System.IO
Imports Bespoke.Common
Imports Bespoke.Common.Osc
Imports System.Net
Public Class ucnewRecorder
    Public chnumber As Integer
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
        SetProcessParentrecorder("casparcg", cmbcasparcgwindowtitle, pnlrecording)
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

    Private Sub cmdopenintrimmer_Click(sender As Object, e As EventArgs) Handles cmdopenintrimmer.Click
        On Error Resume Next
        If Me.Parent.Name = "FourChannelRecorder" Then
            'FourChannelRecorder.UcnewTrimmer11.openfileintrimmer(lblrecordingfilename.Text)
        ElseIf Me.Parent.Name = "gb4ChannelRecorderAndTrimmer" Then
            uc4ChannelRecorderAndTrimmer.UcnewTrimmer11.openfileintrimmer(lblrecordingfilename.Text)
        End If
        ' MsgBox(Me.Parent.Name)
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
    Sub record()
        On Error Resume Next
        lblRecordedduration.Text = ""
        lblRecordedSize.Text = ""
        Dim str As String
        str = "ADD " & chnumber & " FILE " & """" & Replace(Mid(lblRecordingFolder.Text, Len(mediafullpath) + 1), "\", "/") & "/" & txtfilename.Text & "." & mp4.Text & """" & " -b:v " & Val(txtbitrate.Text) & "000k -minrate " & Val(txtbitrate.Text) & "000k -maxrate " & Val(txtbitrate.Text) & "000k " & txtextrarecordoptions.Text
        CasparDevice.SendString(str)

        startingtimeofrecording = Now
        cmdlooprecord.BackColor = Color.Green
    End Sub
    Private Sub tmrrecorder_Tick(sender As Object, e As EventArgs) Handles tmrrecorder.Tick
        On Error Resume Next
        stoprecord()
        If chksinglecliprecord.Checked = False Then
            irecorder = irecorder + 1
            txtfilename.Text = filename & "_" & irecorder
            record()

        Else
            tmrrecordedfileinfo.Enabled = False
            tmrrecorder.Enabled = False
        End If
    End Sub
    Private Sub cmdstoplooprecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstoplooprecord.Click
        On Error Resume Next
        stoprecord()
        txtfilename.Text = ""

        tmrrecorder.Enabled = False
        tmrrecordedfileinfo.Enabled = False
    End Sub
    Sub stoprecord()
        On Error Resume Next
        Dim str As String
        str = "REMOVE " & chnumber & " FILE " & "/" & txtfilename.Text & "." & mp4.Text

        CasparDevice.SendString(str)
        cmdlooprecord.BackColor = Color.Red
    End Sub

    Private Sub tmrrecordedfileinfo_Tick(sender As Object, e As EventArgs) Handles tmrrecordedfileinfo.Tick

        On Error Resume Next
        lblrecordingfilename.Text = lblRecordingFolder.Text & txtfilename.Text & "." & mp4.Text
        If File.Exists(lblrecordingfilename.Text) Then
            Dim f As New FileInfo(lblrecordingfilename.Text)

            Dim recoredduration As TimeSpan = Now - startingtimeofrecording
            lblRecordedduration.Text = recoredduration.ToString("hh\:mm\:ss")
            lblRecordedSize.Text = (f.Length / 1000000) & " MB"
        Else
        End If
        lblfreespace.Text = Int(My.Computer.FileSystem.GetDriveInfo(Mid(mediafullpath, 1, 2)).TotalFreeSpace / 1000000000) & " GB"
    End Sub


    Dim WithEvents sOscServer As OscServer 'for osc
    Dim ichannel As Integer
    Dim iport As Integer

    Sub oscstartandregister(aa As Integer, bb As Integer)
        On Error Resume Next
        ichannel = aa
        iport = bb
        If sOscServer.IsRunning = False Then
            Dim ttype As Integer = 1
            Bespoke.Common.Osc.OscPacket.LittleEndianByteOrder = False
            sOscServer = New OscServer(ttype, IPAddress.Any, iport)
            sOscServer.Start()
            sOscServer.RegisterMethod("/channel/" & ichannel & "/mixer/audio/1/dBFS")
            sOscServer.RegisterMethod("/channel/" & ichannel & "/mixer/audio/2/dBFS")

            sOscServer.RegisterMethod("/channel/" & ichannel & "/mixer/audio/volume") ' for server 2.2
            sOscServer.FilterRegisteredMethods = True
        End If
    End Sub

    Private Sub invokeControls1(ByVal e As OscMessageReceivedEventArgs)
        On Error Resume Next
        If Me.InvokeRequired Then
            Me.Invoke(New invokeControlsDelegate1(AddressOf Me.invokeControls1), e)
        Else
            Dim jregisteredmethods As Integer
            If ServerVersion > 2.1 Then
                If "/channel/" & ichannel & "/mixer/audio/volume" = e.Message.Address Then
                    ProgressBar1.Value = 40 + ValuetodBFS(e.Message.Data(0))
                    ProgressBar2.Value = 40 + ValuetodBFS(e.Message.Data(1))
                End If

            Else
                If "/channel/" & ichannel & "/mixer/audio/1/dBFS" = e.Message.Address Then
                    ProgressBar1.Value = 40 + e.Message.Data(0)
                End If
                If "/channel/" & ichannel & "/mixer/audio/2/dBFS" = e.Message.Address Then
                    ProgressBar2.Value = 40 + e.Message.Data(0)
                End If
            End If

        End If

        If ProgressBar1.Value > 38 Then
            ProgressBar1.Color = Color.Red
        ElseIf ProgressBar1.Value > 34 And ProgressBar1.Value < 38 Then
            ProgressBar1.Color = Color.Yellow
        ElseIf ProgressBar1.Value < 34 Then
            ProgressBar1.Color = Color.Green

        End If

        If ProgressBar2.Value > 38 Then
            ProgressBar2.Color = Color.Red
        ElseIf ProgressBar2.Value > 34 And ProgressBar2.Value < 38 Then
            ProgressBar2.Color = Color.Yellow
        ElseIf ProgressBar2.Value < 34 Then
            ProgressBar2.Color = Color.Green

        End If
    End Sub


    Private Delegate Sub invokeControlsDelegate1(ByVal e As OscMessageReceivedEventArgs)


    Private Sub sOscServer_MessageReceived(ByVal sender As Object, ByVal e As OscMessageReceivedEventArgs) Handles sOscServer.MessageReceived
        On Error Resume Next
        Me.invokeControls1(e)
    End Sub
    Sub stoposcserver()
        On Error Resume Next
        sOscServer.Stop()
        sOscServer.ClearMethods()
        sOscServer = Nothing
    End Sub
    Private Sub ucnewRecorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next

        cmbcasparcgwindowtitle.DataSource = New BindingSource(screenConsumres, "")
        'cmbcasparcgwindowtitle.Text = "Screen consumer [1|PAL]"
        lblRecordingFolder.Text = mediafullpath

    End Sub
    Private Sub cmdcloseRecorder_Click(sender As Object, e As EventArgs) Handles cmdcloseRecorder.Click
        stoprecord()
        cmdoutcasparcgwindowrecording.PerformClick()
        stoposcserver()
        Parent.Controls.Remove(Me)
    End Sub
End Class


