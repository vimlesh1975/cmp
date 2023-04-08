Imports System.IO

Public Class UcCommandSchedulerDateWise

    'Dim g_int_ChannelNumber As Integer = 1
    Dim ofd2 As New OpenFileDialog
    Dim osd2 As New SaveFileDialog
    Public Function IntervalTill(ByVal d As DateTime) As Integer
        On Error Resume Next
        'Dim TodayTickTime As DateTime = Today.Add(d.Subtract(#12:00:00 AM#))
        'Dim TomorrowTickTime As DateTime = TodayTickTime.AddHours(24)
        Dim Difference As TimeSpan
        'If DateTime.op_LessThan(Now, TodayTickTime) Then
        '    Difference = TodayTickTime.Subtract(Now)
        'Else
        '    Difference = TomorrowTickTime.Subtract(Now)
        'End If

        Difference = d.Subtract(Now)

        Return Difference.TotalMilliseconds
    End Function
    Dim startingtimeofrecordingoal As DateTime

    Sub sortschedule()
        On Error Resume Next
        With dgvscheduler
            For iticktime = 0 To .Rows.Count - 1
                .Rows(iticktime).Cells(1).Value = IntervalTill(CType(.Rows(iticktime).Cells(0).Value, DateTime))
            Next
            For iticktime = .Rows.Count - 1 To 0 Step -1
                If .Rows(iticktime).Cells(1).Value < 0 Then
                    .Rows.RemoveAt(iticktime)
                End If

            Next

            .Sort(.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

            .CurrentCell = .Rows(0).Cells(0)
        End With
    End Sub
    Private Sub UcCommandScheduler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialisedataforscheduler()

    End Sub
    Sub initialisedataforscheduler()
        On Error Resume Next
        Dim col1 As New CalendarColumnDateWise()

        Dim col3 As New DataGridViewTextBoxColumn
        Dim col4 As New DataGridViewTextBoxColumn

        col1.HeaderText = "Start Time"
        col1.Width = 200

        col3.HeaderText = "Tick Time (ms)"

        col4.HeaderText = "Command"
        col4.Width = 2000

        With dgvscheduler
            .Columns.Add(col1)

            .Columns.Add(col3)
            .Columns.Add(col4)
            col3.Frozen = True
            col3.ReadOnly = True
            col3.Width = 0
            .Rows.Add(4)
            .Rows(0).Cells(0).Value = Now.AddSeconds(10)
            .Rows(0).Cells(2).Value = "play 1-1 amb loop,,mixer 1-2 fill .5 .2 .3 .6,, play 1-2 red,, mixer 1-2 opacity 0.5"

            .Rows(1).Cells(0).Value = Now.AddSeconds(30)
            .Rows(1).Cells(2).Value = "stop 1-1,,stop 1-2,, mixer 1 clear"

            .Rows(2).Cells(0).Value = Now.AddSeconds(50)
            .Rows(2).Cells(2).Value = "play 1-1 go1080p25 loop"

            .Rows(3).Cells(0).Value = Now.AddSeconds(70)
            .Rows(3).Cells(2).Value = "stop 1-1"
        End With

    End Sub

    Private Sub cmdStartSchedule_Click(sender As Object, e As EventArgs) Handles cmdStartSchedule.Click
        On Error Resume Next
        sortschedule()
        tmrcommandschedulestart.Interval = IntervalTill(CType(dgvscheduler.Rows(0).Cells(0).Value, DateTime))
        tmrcommandschedulestart.Enabled = True
        lbltestshedulerecording.Text = "Sheduled Started"
        lbltestshedulerecording.BackColor = Color.Green
    End Sub

    Private Sub tmrcommandschedulestart_Tick(sender As Object, e As EventArgs) Handles tmrcommandschedulestart.Tick
        On Error Resume Next
        Dim aa() = Split(dgvscheduler.Rows(0).Cells(2).Value, ",,")
        For ischeduler = 0 To aa.Count - 1
            CasparDevice.SendString(aa(ischeduler))
        Next
        startingtimeofrecordingoal = Now
        sortschedule()
        tmrcommandschedulestart.Interval = IntervalTill(CType(dgvscheduler.Rows(0).Cells(0).Value, DateTime))
    End Sub

    Private Sub cmdStopSchedule_Click(sender As Object, e As EventArgs) Handles cmdStopSchedule.Click
        tmrcommandschedulestart.Enabled = False
        lbltestshedulerecording.Text = "Schedule Stoped"
        lbltestshedulerecording.BackColor = Color.Red
    End Sub

    Private Sub newtsschedule_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        dgvscheduler.Rows.Clear()
        'dgvshedulerecording.Rows.Add(7)
        Me.lblscheduleList.Text = "Sheduler= " & "new"
    End Sub

    Private Sub opentsschedule_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = "c:\casparcg\mydata\scheduler\"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)
                'clear list
                dgvscheduler.Rows.Clear()
                'Loop through and add list to the file.
                Dim g As Integer = 0
                Dim li As String
                Do Until sr.EndOfStream = True
                    li = sr.ReadLine()
                    dgvscheduler.Rows.Add()
                    Dim xyz As Array = Split(li, Chr(2))
                    dgvscheduler.Rows(g).Cells(0).Value = xyz(0)

                    dgvscheduler.Rows(g).Cells(2).Value = xyz(1)
                    g = g + 1
                Loop
                sr.Close()
            End Using
            Me.lblscheduleList.Text = "Shedule= " & ofd2.FileName
        End If
    End Sub

    Private Sub savetsschedule_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub addschedule_Click(sender As Object, e As EventArgs) Handles addschedule.Click
        On Error Resume Next
        With dgvscheduler
            .Rows.Insert(.CurrentRow.Index)
            .Rows(.CurrentRow.Index - 1).Cells(0).Value = Now

        End With
    End Sub

    Private Sub deleteschedule_Click(sender As Object, e As EventArgs) Handles deleteschedule.Click
        On Error Resume Next
        With dgvscheduler
            .Rows.RemoveAt(.CurrentRow.Index)
        End With
    End Sub

    Private Sub cmdhideCommandSheduler_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub cmdmanualPlaycmdPlayNoe_Click(sender As Object, e As EventArgs) Handles cmdmanualPlaycmdPlayNoe.Click
        Dim aa() = Split(dgvscheduler.CurrentRow.Cells(2).Value, ",,")
        For ischeduler = 0 To aa.Count - 1
            CasparDevice.SendString(aa(ischeduler))
        Next
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        On Error Resume Next
        dgvscheduler.Rows.Clear()
        'dgvshedulerecording.Rows.Add(7)
        Me.lblscheduleList.Text = "Sheduler= " & "new"
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        On Error Resume Next
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = "c:\casparcg\mydata\scheduler\"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)
                'clear list
                dgvscheduler.Rows.Clear()
                'Loop through and add list to the file.
                Dim g As Integer = 0
                Dim li As String
                Do Until sr.EndOfStream = True
                    li = sr.ReadLine()
                    dgvscheduler.Rows.Add()
                    Dim xyz As Array = Split(li, Chr(2))
                    dgvscheduler.Rows(g).Cells(0).Value = xyz(0)

                    dgvscheduler.Rows(g).Cells(2).Value = xyz(1)
                    g = g + 1
                Loop
                sr.Close()
            End Using
            Me.lblscheduleList.Text = "Shedule= " & ofd2.FileName
        End If
    End Sub
    Private Sub MenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip1.MouseHover
        MakeMenuDropDownWhenParrented(sender)
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        On Error Resume Next
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "c:\casparcg\mydata\scheduler\"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvscheduler.Rows.Count = 0 Then
                    sw.Write("")
                Else
                    'Loop through and add list to the file.
                    Dim f As Integer = 0
                    Do Until f = dgvscheduler.Rows.Count
                        sw.WriteLine(Format(CType(dgvscheduler.Rows(f).Cells(0).Value, DateTime), "H:mm:ss") & Chr(2) & dgvscheduler.Rows(f).Cells(2).Value)
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            Me.lblscheduleList.Text = "Shedule=  " & osd2.FileName
        End If
    End Sub
End Class
