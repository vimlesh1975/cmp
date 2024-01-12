Imports System.IO

'Imports Bespoke.Common
Imports Bespoke.Common.Osc
Imports System.Net
Public Class ucnewOffAirLogger
    Dim WithEvents tmrshedulerecordingstart As New Timer
    Dim WithEvents tmrshedulerecordingend As New Timer


    Public ichannel As Integer
    Dim WithEvents sOscServer As OscServer 'for osc
    Dim iport As Integer

    Sub oscstartandregister(aa As Integer, bb As Integer)
        On Error Resume Next
        If sOscServer.IsRunning = False Then
            Dim ttype As Integer = 1
            OscPacket.LittleEndianByteOrder = False
            sOscServer = New OscServer(ttype, IPAddress.Any, bb)
            sOscServer.Start()
            sOscServer.RegisterMethod("/channel/" & aa & "/mixer/audio/1/dBFS")
            sOscServer.RegisterMethod("/channel/" & aa & "/mixer/audio/2/dBFS")
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
    Sub sortshedulerecording()
        On Error Resume Next
        For iticktime = 0 To dgvshedulerecording.Rows.Count - 1
            dgvshedulerecording.Rows(iticktime).Cells(2).Value = IntervalTill(CType(dgvshedulerecording.Rows(iticktime).Cells(0).Value, Date).TimeOfDay.ToString)
        Next
        dgvshedulerecording.Sort(dgvshedulerecording.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
        dgvshedulerecording.CurrentCell = dgvshedulerecording.Rows(0).Cells(0)
    End Sub

    Private Sub tmrshedulerecordingstart_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrshedulerecordingstart.Tick
        On Error Resume Next

        recordoal()

        lbltestshedulerecording.Text = "Recordind Started"
        lbltestshedulerecording.BackColor = Color.Green
        tmrshedulerecordingstart.Enabled = False

        tmrshedulerecordingend.Interval = dgvshedulerecording.Rows(0).Cells(1).Value * 1000
        tmrshedulerecordingend.Enabled = True
        tmrrecordedfileinfooal.Enabled = True

        deletefilesoal()
    End Sub
    Private Sub addshedulerecording_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addshedulerecording.Click
        On Error Resume Next
        dgvshedulerecording.Rows.Insert(dgvshedulerecording.CurrentRow.Index)
        dgvshedulerecording.Rows(dgvshedulerecording.CurrentRow.Index - 1).Cells(0).Value = Now
        dgvshedulerecording.Rows(dgvshedulerecording.CurrentRow.Index - 1).Cells(1).Value = 10
    End Sub

    Private Sub deleteshedulerecording_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteshedulerecording.Click
        On Error Resume Next
        dgvshedulerecording.Rows.RemoveAt(dgvshedulerecording.CurrentRow.Index)
    End Sub
    Private Sub cmdshedulerecording_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshedulerecording.Click
        On Error Resume Next
        sortshedulerecording()
        tmrshedulerecordingstart.Interval = IntervalTill(CType(dgvshedulerecording.Rows(0).Cells(0).Value, Date).TimeOfDay.ToString)
        tmrshedulerecordingstart.Enabled = True
        tmroal.Enabled = False

        lblsheduleStatus.Text = "Schedule Started"
        lblsheduleStatus.BackColor = Color.Green
    End Sub

    Private Sub cmdshowinputoal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshowinputoal.Click
        On Error Resume Next
        If frmmediaplayer.cmdconnect.BackColor = Color.Green Then
            Dim str As String
            str = "play " & ichannel & "-" & 1 & " decklink " & cmbliveoal.Text
            CasparDevice.SendString(str)

            ucPlaylist.tmrduration.Enabled = True
        End If
    End Sub

    Private Sub cmdremoveinputoal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremoveinputoal.Click
        On Error Resume Next
        If frmmediaplayer.cmdconnect.BackColor = Color.Green Then
            Dim str As String
            str = "stop " & ichannel & "-" & 1 & " decklink " & cmbliveoal.Text
            CasparDevice.SendString(str)
        End If
    End Sub
    Private Sub cmdlocaterecordingfileoal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlocaterecordingfileoal.Click
        Process.Start("explorer.exe", "/select," & Replace(lblrecordingfilenameoal.Text, "/", "\"))
    End Sub
    Private Sub cmdrecordoal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrecordoal.Click
        On Error Resume Next
        If frmmediaplayer.cmdconnect.BackColor = Color.Green Then
            recordoal()
            tmroal.Interval = (txtfilelengthofl.Text) * 1000
            tmroal.Enabled = True
            tmrrecordedfileinfooal.Enabled = True
            cmdrecordoal.BackColor = Color.Green

            tmrshedulerecordingstart.Enabled = False
            lblsheduleStatus.Text = "Schedule Stopped"
            lblsheduleStatus.BackColor = Color.Red

        End If
    End Sub

    Private Sub tmrrecordedfileinfooal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrrecordedfileinfooal.Tick
        On Error Resume Next
        lblrecordingfilenameoal.Text = mediafullpath & "ch" & ichannel & "/" & dtpoal.Text & "." & cmbfileformateoal.Text
        If File.Exists(lblrecordingfilenameoal.Text) Then
            Dim f As New FileInfo(lblrecordingfilenameoal.Text)
            Dim recoreddurationoal As TimeSpan = Now - startingtimeofrecordingoal
            lblRecordeddurationoal.Text = recoreddurationoal.ToString("hh\:mm\:ss")
            lblRecordedSizeoal.Text = (f.Length / 1000000) & " MB"
        Else
            lblRecordeddurationoal.Text = "Not Recording"
            lblRecordedSizeoal.Text = "Not Recording"
        End If
        lblfreespaceoal.Text = Int(My.Computer.FileSystem.GetDriveInfo(Mid(mediafullpath, 1, 2)).TotalFreeSpace / 1000000000) & " GB"
        lbltotalsizeoal.Text = Int(My.Computer.FileSystem.GetDriveInfo(Mid(mediafullpath, 1, 2)).TotalSize / 1000000000) & " GB"
        lblEstimateddaysvalueoal.Text = (Format(Val(lblfreespaceoal.Text) / (10.8 * Val(txtbitrateofl.Text)), "000.0")) & " Days"
    End Sub
    Dim startingtimeofrecordingoal As DateTime
    Sub recordoal()
        On Error Resume Next
        Directory.CreateDirectory(mediafullpath & "ch" & ichannel & "/")
        lblRecordeddurationoal.Text = ""
        lblRecordedSizeoal.Text = ""
        dtpoal.Text = Now
        Dim str As String
        If ServerVersion = "2.0" Then
            str = "ADD " & ichannel & " FILE " & "ch" & ichannel & "/" & dtpoal.Text & "." & cmbfileformateoal.Text & " -b " & Val(txtbitrateofl.Text) * 1000000 & " " & txtextraoptionoal.Text
        ElseIf ServerVersion = "2.1" Then
            str = "ADD " & ichannel & " FILE " & "ch" & ichannel & "/" & dtpoal.Text & "." & cmbfileformateoal.Text & " -b:v " & Val(txtbitrateofl.Text) * 1000000 & " -maxrate:v " & Val(txtbitrateofl.Text) * 1000000 & " -bufsize:v " & 1000000 & " -b:a 128k -pix_fmt yuv420p -preset slow -crf 22 " & txtextraoptionoal.Text
        Else
            str = "ADD " & ichannel & " FILE " & "ch" & ichannel & "/" & dtpoal.Text & "." & cmbfileformateoal.Text & " -b:v " & Val(txtbitrateofl.Text) * 1000000 & " -maxrate:v " & Val(txtbitrateofl.Text) * 1000000 & " -bufsize:v " & 1000000 & " -filter:v format=pix_fmts=yuv420p -filter:a pan=stereo|c0=c0|c1=c1 " & txtextraoptionoal.Text
        End If
        CasparDevice.SendString(str)
        startingtimeofrecordingoal = Now
    End Sub

    Private Sub cmdstoprecordoal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstoprecordoal.Click
        On Error Resume Next
        stoprecordoal()
        tmrrecordedfileinfooal.Enabled = False
        tmroal.Enabled = False
    End Sub

    Sub stoprecordoal()
        On Error Resume Next
        Dim str As String
        str = "REMOVE " & ichannel & " FILE " & "ch" & ichannel & "/" & dtpoal.Text & "." & cmbfileformateoal.Text
        CasparDevice.SendString(str)
        cmdrecordoal.BackColor = Color.Red
    End Sub

    Private Sub tmroal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmroal.Tick
        On Error Resume Next
        stoprecordoal()
        recordoal()
        deletefilesoal()
        cmdrecordoal.BackColor = Color.Green
    End Sub
    Private Sub cmddeletefilesoal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddeletefilesoal.Click
        On Error Resume Next
        deletefilesoal()

    End Sub
    Sub deletefilesoal()
        On Error Resume Next
        dtpdeleteoal.Text = Now.AddDays(-Val(Me.txtdatetodeleteoal.Text))
        Dim Filefound = New DirectoryInfo(txtmediadirectoryoal.Text).GetFiles("*.*")
        For aaa As Integer = 0 To Filefound.Count - 1
            Dim filefound1 = Split(Filefound(aaa).ToString, ".")

            If (Len(filefound1(0)).ToString = 14) And (dtpdeleteoal.Text > filefound1(0).ToString) Then
                System.IO.File.Delete(txtmediadirectoryoal.Text & "\" & Filefound(aaa).ToString)
            End If
        Next
    End Sub
    Private Sub cmdmediadirectoryofl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmediadirectoryofl.Click
        On Error Resume Next
        Dim fbd1 As New FolderBrowserDialog
        If (fbd1.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Me.txtmediadirectoryoal.Text = fbd1.SelectedPath
        End If
    End Sub

    Private Sub chkshowtimeofl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkshowtimeofl.CheckedChanged
        On Error Resume Next
        If chkshowtimeofl.Checked Then
            ' Dim str As String = "cg " & ichannel & " add 21 " & "CMP/off_air_logger_clock/off_air_logger_clock 1"
            Dim str As String = "play " & ichannel & "-21 [html] " & "c:/casparcg/CMP/off_air_logger_clock/clock_html.html"
            CasparDevice.SendString(str)
        Else
            Dim str As String = "stop " & ichannel & "-21"
            CasparDevice.SendString(str)
        End If

    End Sub
    Private Sub tmrshedulerecordingend_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrshedulerecordingend.Tick
        On Error Resume Next

        stoprecordoal()


        lbltestshedulerecording.Text = "Recordind Stoped"
        lbltestshedulerecording.BackColor = Color.Red

        tmrshedulerecordingend.Enabled = False



        sortshedulerecording()

        tmrshedulerecordingstart.Interval = IntervalTill(CType(dgvshedulerecording.Rows(0).Cells(0).Value, Date).TimeOfDay.ToString)
        tmrshedulerecordingstart.Enabled = True
        tmrrecordedfileinfooal.Enabled = False

    End Sub
    Private Sub cmdshedulerecordingstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshedulerecordingstop.Click
        On Error Resume Next
        CasparDevice.SendString("REMOVE " & ichannel & " FILE")
        lbltestshedulerecording.Text = "Recordind Stoped"
        lbltestshedulerecording.BackColor = Color.Red

        tmrshedulerecordingstart.Enabled = False
        tmrshedulerecordingend.Enabled = False
        tmrrecordedfileinfooal.Enabled = False
        cmdrecordoal.BackColor = Color.Red

        lblsheduleStatus.Text = "Schedule Stopped"
        lblsheduleStatus.BackColor = Color.Red

    End Sub
    Sub initialisedataforshedulerecording()
        On Error Resume Next
        Dim col1 As New CalendarColumn()
        Dim col2 As New DataGridViewTextBoxColumn
        Dim col3 As New DataGridViewTextBoxColumn

        col1.HeaderText = "Start Time"
        col2.HeaderText = "Duration in second"
        col3.HeaderText = "Tick Time (ms)"
        col3.ReadOnly = True


        col1.Width = 70
        col2.Width = 70
        col3.Width = 0

        dgvshedulerecording.Columns.Add(col1)
        dgvshedulerecording.Columns.Add(col2)
        dgvshedulerecording.Columns.Add(col3)

        dgvshedulerecording.Rows.Add(4)
        dgvshedulerecording.Rows(0).Cells(0).Value = Now.AddSeconds(10)
        dgvshedulerecording.Rows(0).Cells(1).Value = "10"
        dgvshedulerecording.Rows(1).Cells(0).Value = Now.AddSeconds(30)
        dgvshedulerecording.Rows(1).Cells(1).Value = "10"

        dgvshedulerecording.Rows(2).Cells(0).Value = Now.AddSeconds(50)
        dgvshedulerecording.Rows(2).Cells(1).Value = "10"
        dgvshedulerecording.Rows(3).Cells(0).Value = Now.AddSeconds(70)
        dgvshedulerecording.Rows(3).Cells(1).Value = "10"

    End Sub


    Private Sub cmdshowcasparcgwindowrecording_Click(sender As Object, e As EventArgs) Handles cmdshowcasparcgwindowrecording.Click
        On Error Resume Next
        SetProcessParentrecorder("casparcg", cmbscreenConsumres, pnlrecording)

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
    Private Sub cmdoutcasparcgwindowrecording_Click(sender As Object, e As EventArgs) Handles cmdoutcasparcgwindowrecording.Click
        On Error Resume Next
        If Not parentedProcess1 Is Nothing Then
            SetParent(parentedProcess1.MainWindowHandle, Nothing)
        End If
    End Sub

    Private Sub ucnewOffAirLogger_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbscreenConsumres.DataSource = New BindingSource(screenConsumres, "")

        initialisedataforshedulerecording()
        Me.dtpoal.CustomFormat = "yyyyMMddHHmmss"
        Me.dtpdeleteoal.CustomFormat = "yyyyMMddHHmmss"

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        On Error Resume Next
        dgvshedulerecording.Rows.Clear()
        Me.lblshedulerecordingplaylist.Text = "Shedule Recording= " & "new playlist"
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        On Error Resume Next
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = "c:\casparcg\mydata\shedule_recording\"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)
                dgvshedulerecording.Rows.Clear()
                Dim g As Integer = 0
                Dim li As String
                Do Until sr.EndOfStream = True
                    li = sr.ReadLine()
                    dgvshedulerecording.Rows.Add()
                    Dim xyz As Array = Split(li, ",")
                    dgvshedulerecording.Rows(g).Cells(0).Value = xyz(0)
                    dgvshedulerecording.Rows(g).Cells(1).Value = xyz(1)
                    g = g + 1
                Loop
                sr.Close()
            End Using
            Me.lblshedulerecordingplaylist.Text = "Shedule Recording= " & ofd2.FileName
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        On Error Resume Next
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "c:\casparcg\mydata\shedule_recording\"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvshedulerecording.Rows.Count = 0 Then
                    sw.Write("")
                Else
                    Dim f As Integer = 0
                    Do Until f = dgvshedulerecording.Rows.Count
                        sw.WriteLine(Format(CType(dgvshedulerecording.Rows(f).Cells(0).Value, DateTime), "H:mm:ss") & "," & dgvshedulerecording.Rows(f).Cells(1).Value)
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            Me.lblshedulerecordingplaylist.Text = "Shedule Recording=  " & osd2.FileName
        End If
    End Sub
    Private Sub MenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip1.MouseHover
        MakeMenuDropDownWhenParrented(sender)
    End Sub

    Private Sub CmdPlayinvlc_Click(sender As Object, e As EventArgs) Handles cmdPlayinvlc.Click
        On Error Resume Next
        playinvlc(lblrecordingfilenameoal.Text)
    End Sub

    Private Sub CmdShowInfo_Click(sender As Object, e As EventArgs) Handles cmdShowInfo.Click
        On Error Resume Next
        showfileinformation(lblrecordingfilenameoal.Text)
    End Sub

    Private Sub gboffairlogger_Enter(sender As Object, e As EventArgs) Handles gboffairlogger.Enter

    End Sub
End Class
