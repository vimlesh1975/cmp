Imports System.IO
Imports System.Threading
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Services
Imports Google.Apis.Upload
Imports Google.Apis.Util.Store
Imports Google.Apis.YouTube.v3
Imports Google.Apis.YouTube.v3.Data
Public Class ucytlive
    Dim ytObj As YouTubeService
    Dim gg As LiveBroadcast
    Dim sr As LiveStream
    Dim ls As LiveStream

    Dim ofst As String
    Dim ytCred As UserCredential
    ReadOnly credPath As String = "C:\casparcg\mydata\ytlive1_cmp_desktop_client\token.json\"

    ReadOnly ofd2 As New OpenFileDialog
    ReadOnly osd2 As New SaveFileDialog

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MMM/yyyy HH:mm:ss"


        Dim localZone As TimeZone = TimeZone.CurrentTimeZone
        Dim currentDate As DateTime = DateTime.Now
        Dim currentUTC As DateTime = localZone.ToUniversalTime(currentDate)
        Dim currentOffset As TimeSpan = localZone.GetUtcOffset(currentDate)


        If Mid(currentOffset.ToString, 1, 1) = "-" Then
            ofst = Mid(currentOffset.ToString, 1, 5)
        Else
            ofst = "+" & Mid(currentOffset.ToString, 1, 5)
        End If

        cmdCreateytobject.PerformClick()

        cmdListBroadcast.PerformClick()
        cmdListBroadcastStream.PerformClick()

        initialisedataforscheduler()
    End Sub
    Sub initialisedataforscheduler()
        On Error Resume Next
        Dim col1 As New CalendarColumnDateWise()

        Dim col3 As New DataGridViewTextBoxColumn
        Dim col4 As New DataGridViewTextBoxColumn
        Dim col5 As New DataGridViewTextBoxColumn
        Dim col6 As New DataGridViewTextBoxColumn

        col1.HeaderText = "Start Time"
        col1.Width = 130

        col3.HeaderText = "Tick Time (ms)"

        col4.HeaderText = "Broadcast id"
        col4.Width = 100

        col5.HeaderText = "Broadcast Title"
        col5.Width = 250


        col6.HeaderText = "Duration(Minutes)"
        col6.Width = 100

        With dgvscheduler
            .Columns.Add(col1)

            .Columns.Add(col3)
            .Columns.Add(col4)
            .Columns.Add(col5)
            .Columns.Add(col6)

            col3.Frozen = True
            col3.ReadOnly = True
            col3.Width = 0
            .Rows.Add(1)
            .Rows(0).Cells(0).Value = Now.AddSeconds(60)
            .Rows(0).Cells(2).Value = ""
            .Rows(0).Cells(3).Value = ""
            .Rows(0).Cells(4).Value = "1"

            .Rows(1).Cells(0).Value = Now.AddSeconds(120)
            .Rows(1).Cells(2).Value = ""
            .Rows(1).Cells(3).Value = ""
            .Rows(1).Cells(4).Value = "1"


        End With

    End Sub
    Private Async Sub cmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click
        Try

            lblCreate.Text = "Wait"
            Dim localZone As TimeZone = TimeZone.CurrentTimeZone
            Dim currentDate As DateTime = DateTime.Now
            Dim currentUTC As DateTime = localZone.ToUniversalTime(currentDate)
            Dim currentOffset As TimeSpan = localZone.GetUtcOffset(currentDate)

            Dim ofst As String
            If Mid(currentOffset.ToString, 1, 1) = "-" Then
                ofst = Mid(currentOffset.ToString, 1, 5)
            Else
                ofst = "+" & Mid(currentOffset.ToString, 1, 5)
            End If

            Dim lb As New LiveBroadcast
            Dim lbs As New LiveBroadcastStatus
            Dim lbsn As New LiveBroadcastSnippet
            Dim cdtl As New LiveBroadcastContentDetails
            Dim ms As New MonitorStreamInfo



            lbsn.Title = cmbTitle.Text & " " & DateTimePicker1.Value.Date
            lbsn.ScheduledStartTime = DateTimePicker1.Value & ofst ' & "Z+" & currentOffset.ToString '"2020-11-02T20:30+05:30"
            'lbsn.ScheduledStartTime = "2020-11-04T20:30+05:30"

            lbs.PrivacyStatus = cmbPrivacyStatus.Text
            lbs.SelfDeclaredMadeForKids = False


            ms.EnableMonitorStream = True

            cdtl.MonitorStream = ms

            lb.Snippet = lbsn
            lb.Status = lbs
            lb.ContentDetails = cdtl

            gg = Await ytObj.LiveBroadcasts.Insert(lb, "snippet,status,ContentDetails").ExecuteAsync


            LinkLabel1.Text = "https://youtu.be/" & gg.Id
            LinkLabel2.Text = "https://studio.youtube.com/video/" & gg.Id & "/" & "livestreaming"



            Dim aa1 = ytObj.LiveStreams.List("snippet,contentDetails,status,cdn")
            aa1.Mine = True
            aa1.MaxResults = 50

            Dim bb1 = Await aa1.ExecuteAsync()
            Dim ii As Integer = -1
            For i = 0 To bb1.Items.Count - 1
                If bb1.Items(i).Snippet.Title = "Default stream key" Then
                    ii = i
                    GoTo 50
                End If
            Next
50:         If ii = -1 Then MsgBox("Default Stream Not found, you need to bind it manualy") : GoTo 60
            Dim jj = ytObj.LiveBroadcasts.Bind(gg.Id, "id,snippet,contentDetails,status")
            jj.StreamId = bb1.Items(ii).Id
            Await jj.ExecuteAsync()
            '
            txtStreamKey.Text = bb1.Items(ii).Cdn.IngestionInfo.StreamName
            lblCreate.Text = "Created"

            tmrStatus.Enabled = True
            tmrStatusOnOff.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
60:

    End Sub
    Private Async Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Try
            lblUpdate.Text = "Wait...."

            Dim lb As New LiveBroadcast
            Dim lbs As New LiveBroadcastStatus
            Dim lbsn As New LiveBroadcastSnippet
            Dim cdtl As New LiveBroadcastContentDetails

            Dim aa = ytObj.LiveBroadcasts.List("snippet,contentDetails,status")
            aa.Id = gg.Id
            Dim bb = Await aa.ExecuteAsync()


            lb.ContentDetails = bb.Items(0).ContentDetails


            lbsn.Title = cmbTitle.Text ' & " " & DateTimePicker1.Value.Date
            lbsn.ScheduledStartTime = DateTimePicker1.Value & ofst ' & "Z+" & currentOffset.ToString '"2020-11-02T20:30+05:30"
            'lbsn.ScheduledStartTime = "2020-11-04T20:30+05:30"

            lbs.PrivacyStatus = cmbPrivacyStatus.Text
            lbs.SelfDeclaredMadeForKids = True

            lb.Snippet = lbsn
            lb.Status = lbs

            lb.Id = gg.Id
            Dim cc = ytObj.LiveBroadcasts.Update(lb, "snippet,contentDetails,status")
            Dim dd = Await cc.ExecuteAsync()
            lblUpdate.Text = "Updated"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim statusrequest As LiveBroadcastsResource.ListRequest
    Private Async Sub getstatus()
        Try
            'lbllifecyclestatus.Text = "wait"

            statusrequest = ytObj.LiveBroadcasts.List("status")
            statusrequest.ETagAction = Google.Apis.ETagAction.IfNoneMatch
            statusrequest.Fields = "items.status.lifeCycleStatus" ' first letter of field should be samll and all other letter as specified in dotnet as for example LifeCycleStatus ->lifeCycleStatus
            statusrequest.Id = gg.Id

            Dim bb = Await statusrequest.ExecuteAsync()
            'Dim eenew = bb.ETag



            If bb.Items(0).Status.LifeCycleStatus = "testing" Then
                lbllifecyclestatus.Text = "Ready for Live"
            Else
                lbllifecyclestatus.Text = bb.Items(0).Status.LifeCycleStatus
            End If



        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        On Error Resume Next
        System.Diagnostics.Process.Start(LinkLabel1.Text)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        On Error Resume Next
        System.Diagnostics.Process.Start(sender.Text)
    End Sub


    Private Async Sub cmdCreateytobject_Click(sender As Object, e As EventArgs) Handles cmdCreateytobject.Click
        Try
            lblytoblect.Text = "wait"
            Using stream = New FileStream("C:\casparcg\mydata\ytlive1_cmp_desktop_client\ytlive1_cmp_desktop_client.json", FileMode.Open, FileAccess.Read)
                'Using stream = New FileStream("ddsahyadri_news.json", FileMode.Open, FileAccess.Read)
                ytCred = Await GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, {YouTubeService.Scope.Youtube}, "user", CancellationToken.None, New FileDataStore(credPath, True))
            End Using
            ytObj = New YouTubeService(New BaseClientService.Initializer() With {.HttpClientInitializer = ytCred, .GZipEnabled = True, .ApplicationName = Me.[GetType]().ToString()})
            lblytoblect.Text = "Logged IN"

            Dim aa = ytObj.Channels.List("snippet")

            aa.Fields = "items.snippet.title,items.snippet.thumbnails.high.url"
            aa.Mine = True
            Dim bb = Await aa.ExecuteAsync()

            lbluser.Text = "User= " & bb.Items(0).Snippet.Title
            picUser.ImageLocation = bb.Items(0).Snippet.Thumbnails.High.Url



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim alllive As LiveBroadcastListResponse
    Dim alllivestream As LiveStreamListResponse
    Private Async Sub cmdDeleteAllBroadcast_Click_1(sender As Object, e As EventArgs) Handles cmdDeleteAllBroadcast.Click
        Try
            lbldeletebroadcast.Text = "Wait"
            Dim ss = Await ytObj.LiveBroadcasts.Delete(lstLiveBroadcast.SelectedItem.ToString).ExecuteAsync
            lbldeletebroadcast.Text = "Ok"

            cmdListBroadcast.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Async Sub cmdListBroadcast_Click_1(sender As Object, e As EventArgs) Handles cmdListBroadcast.Click
        Try
            lbllistbroadcast.Text = "wait"
            Dim aa = ytObj.LiveBroadcasts.List("snippet")
            'aa.Mine = False
            aa.BroadcastType = LiveBroadcastsResource.ListRequest.BroadcastTypeEnum.Event__
            aa.BroadcastStatus = LiveBroadcastsResource.ListRequest.BroadcastStatusEnum.Upcoming
            aa.MaxResults = 50
            aa.Fields = "items.id,items.snippet.title"
            alllive = Await aa.ExecuteAsync()


            lstLiveBroadcast.Items.Clear()
            lstbroadcastTitle.Items.Clear()
            For i = 0 To alllive.Items.Count - 1
                lstLiveBroadcast.Items.Add(alllive.Items(i).Id)
                lstbroadcastTitle.Items.Add(alllive.Items(i).Snippet.Title)
            Next

            lbllistbroadcast.Text = "OK"

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub
    Private Async Sub cmdListBroadcastStrem_Click(sender As Object, e As EventArgs) Handles cmdListBroadcastStream.Click
        Try
            lbllistStream.Text = "Wait"
            Dim aa = ytObj.LiveStreams.List("snippet,cdn")
            aa.Mine = True
            aa.MaxResults = 50
            aa.Fields = "items(id,snippet(title),cdn(ingestionInfo(streamName)))"

            alllivestream = Await aa.ExecuteAsync()

            lstlLiveStream.Items.Clear()
            lstlLiveStreamTitle.Items.Clear()
            lstkey.Items.Clear()

            For i = 0 To alllivestream.Items.Count - 1
                lstlLiveStream.Items.Add(alllivestream.Items(i).Id)
                lstlLiveStreamTitle.Items.Add(alllivestream.Items(i).Snippet.Title)
                lstkey.Items.Add(alllivestream.Items(i).Cdn.IngestionInfo.StreamName)
            Next
            lbllistStream.Text = "OK"
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub
    Private Async Sub cmdDeleteBroadcastStraem_Click(sender As Object, e As EventArgs) Handles cmdDeleteBroadcastStraem.Click
        Try
            lbldleteStream.Text = "Wait"
            Dim ss = Await ytObj.LiveStreams.Delete(lstlLiveStream.SelectedItem.ToString).ExecuteAsync
            lbldleteStream.Text = "Deleted"
            cmdListBroadcastStream.PerformClick()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Async Sub cmdGoLive_Click(sender As Object, e As EventArgs) Handles cmdGoLive.Click
        Try
            Dim tt = Await ytObj.LiveBroadcasts.Transition(LiveBroadcastsResource.TransitionRequest.BroadcastStatusEnum.Live, gg.Id, "id").ExecuteAsync

            tmrStatus.Enabled = True
            tmrStatusOnOff.Enabled = True


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Async Sub cmdEndLive_Click(sender As Object, e As EventArgs) Handles cmdEndLive.Click
        Try
            Dim tt = Await ytObj.LiveBroadcasts.Transition(LiveBroadcastsResource.TransitionRequest.BroadcastStatusEnum.Complete, gg.Id, "id").ExecuteAsync()

            tmrStatus.Enabled = True
            tmrStatusOnOff.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub lstlLiveStream_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstlLiveStream.SelectedIndexChanged

    End Sub



    Private Async Sub cmdLogout_Click(sender As Object, e As EventArgs) Handles cmdLogout.Click
        MsgBox(Await ytCred.RevokeTokenAsync(CancellationToken.None))
        picUser.ImageLocation = ""
        lbluser.Text = "User= Non"
        lblytoblect.Text = "Logged OUT"
    End Sub

    Private Async Sub cmdSelectForLive_Click(sender As Object, e As EventArgs) Handles cmdSelectForLive.Click
        Try
            txtStreamKey.Text = "Wait...."


            Dim lb As New LiveBroadcast
            Dim lbs As New LiveBroadcastStatus
            Dim lbsn As New LiveBroadcastSnippet
            Dim cdtl As New LiveBroadcastContentDetails

            Dim aa = ytObj.LiveBroadcasts.List("snippet,status,contentDetails")
            aa.Id = lstLiveBroadcast.SelectedItem.ToString

            aa.Fields = "items(snippet(title,scheduledStartTime),status(privacyStatus),contentDetails.boundStreamId)"
            Dim bb = Await aa.ExecuteAsync()

            cmbTitle.Text = bb.Items(0).Snippet.Title
            cmbPrivacyStatus.Text = bb.Items(0).Status.PrivacyStatus
            DateTimePicker1.Value = bb.Items(0).Snippet.ScheduledStartTime

            LinkLabel1.Text = "https://youtu.be/" & lstLiveBroadcast.SelectedItem.ToString
            LinkLabel2.Text = "https://studio.youtube.com/video/" & lstLiveBroadcast.SelectedItem.ToString & "/" & "livestreaming"

            gg = New LiveBroadcast With {
                .Id = lstLiveBroadcast.SelectedItem.ToString
            }


            Dim aa1 = ytObj.LiveStreams.List("cdn")
            aa1.Fields = "items(cdn.ingestionInfo.streamName)"

            If bb.Items(0).ContentDetails.BoundStreamId = "" Then
                MsgBox("ID is not bound to a stream, Bind it manualy")
            Else
                aa1.Id = bb.Items(0).ContentDetails.BoundStreamId

                Dim bb1 = Await aa1.ExecuteAsync()
                txtStreamKey.Text = bb1.Items(0).Cdn.IngestionInfo.StreamName

            End If

            tmrStatus.Enabled = True
            tmrStatusOnOff.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
            txtStreamKey.Text = "Error"
        End Try
    End Sub

    Private Async Sub cmdBindSelectedBroadcastwithSelectedStream_Click(sender As Object, e As EventArgs) Handles cmdBindSelectedBroadcastwithSelectedStream.Click
        lblBind.Text = "Wai...."
        Try
            'Dim jj = ytObj.LiveBroadcasts.Bind(lstLiveBroadcast.SelectedItem.ToString, "id,snippet,contentDetails,status")
            Dim jj = ytObj.LiveBroadcasts.Bind(lstLiveBroadcast.SelectedItem.ToString, "id")
            jj.StreamId = lstlLiveStream.SelectedItem.ToString 'sr.Id

            Await jj.ExecuteAsync()
            lblBind.Text = "Bind Success"
        Catch ex As Exception
            MsgBox(ex.Message)
            lblBind.Text = "Bind Fail"
        End Try


    End Sub

    Private Async Sub cmdCreateBroadcastStream_Click(sender As Object, e As EventArgs) Handles cmdCreateBroadcastStream.Click
        Try

            lblCreateBrodcastStream.Text = "Wait..."
            ls = New LiveStream
            Dim lssnippet As New LiveStreamSnippet
            Dim cdn As New CdnSettings
            Dim lbsn As New LiveBroadcastSnippet


            lssnippet.Title = txtbsTitle.Text ' & " " & DateTimePicker1.Value.Date

            cdn.IngestionType = "rtmp"
            cdn.FrameRate = "30fps"
            cdn.Resolution = "720p"

            ls.Cdn = cdn
            ls.Snippet = lssnippet
            ls.Kind = "youtube#liveStream"

            'sr = Await ytObj.LiveStreams.Insert(ls, "snippet,cdn,status").ExecuteAsync
            sr = Await ytObj.LiveStreams.Insert(ls, "snippet,cdn").ExecuteAsync
            lblCreateBrodcastStream.Text = "Created"
            cmdListBroadcastStream.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tmrStatus_Tick(sender As Object, e As EventArgs) Handles tmrStatus.Tick
        getstatus()
        If lbllifecyclestatus.Text = "Ready for Live" Then

            cmdGoLive.Enabled = True
        Else
            cmdGoLive.Enabled = False
        End If

        If lbllifecyclestatus.Text = "live" Then
            cmdEndLive.Enabled = True
        Else
            cmdEndLive.Enabled = False
        End If

        If lbllifecyclestatus.Text = "ready" Then
            cmdTesting.Enabled = True
        Else
            cmdTesting.Enabled = False
        End If

        If lbllifecyclestatus.Text = "complete" Then
            tmrStatus.Enabled = False
        End If

    End Sub

    Private Async Sub cmdListLiveBroadcast_Click(sender As Object, e As EventArgs) Handles cmdListLiveBroadcast.Click
        Try
            lbllistbroadcast.Text = "wait"
            Dim aa = ytObj.LiveBroadcasts.List("snippet")
            'aa.Mine = False
            aa.BroadcastType = LiveBroadcastsResource.ListRequest.BroadcastTypeEnum.Event__
            aa.BroadcastStatus = LiveBroadcastsResource.ListRequest.BroadcastStatusEnum.Active
            aa.MaxResults = 50
            aa.Fields = "items.id, items.snippet.title"
            alllive = Await aa.ExecuteAsync()

            lstLiveBroadcast.Items.Clear()
            lstbroadcastTitle.Items.Clear()
            For i = 0 To alllive.Items.Count - 1
                lstLiveBroadcast.Items.Add(alllive.Items(i).Id)
                lstbroadcastTitle.Items.Add(alllive.Items(i).Snippet.Title)
            Next

            lbllistbroadcast.Text = "OK"

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Async Sub cmdTesting_Click(sender As Object, e As EventArgs) Handles cmdTesting.Click
        Try
            'Dim tt = Await ytObj.LiveBroadcasts.Transition(LiveBroadcastsResource.TransitionRequest.BroadcastStatusEnum.Testing, gg.Id, "id,snippet,contentDetails,status").ExecuteAsync()
            Dim tt = Await ytObj.LiveBroadcasts.Transition(LiveBroadcastsResource.TransitionRequest.BroadcastStatusEnum.Testing, gg.Id, "id").ExecuteAsync()

            tmrStatus.Enabled = True
            tmrStatusOnOff.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tmrStatusOnOff_Tick(sender As Object, e As EventArgs) Handles tmrStatusOnOff.Tick
        tmrStatus.Enabled = False
        tmrStatusOnOff.Enabled = False
    End Sub

    Private Sub cmdGetStatus_Click(sender As Object, e As EventArgs) Handles cmdGetStatus.Click
        tmrStatus.Enabled = True
        tmrStatusOnOff.Enabled = True
    End Sub
    Async Sub prepareSchedule(xyz As String)
        Try


            Await ytObj.LiveBroadcasts.Transition(LiveBroadcastsResource.TransitionRequest.BroadcastStatusEnum.Testing, xyz, "id").ExecuteAsync()
        Catch ex As Exception
            lblErrors.Text = ex.Message
        End Try
    End Sub

    Async Sub startSchedule(xyz As String)
        Try

            Await ytObj.LiveBroadcasts.Transition(LiveBroadcastsResource.TransitionRequest.BroadcastStatusEnum.Live, xyz, "id").ExecuteAsync()

        Catch ex As Exception
            lblErrors.Text = ex.Message
        End Try
    End Sub
    Async Sub endSchedule(xyz As String)
        Try
            Await ytObj.LiveBroadcasts.Transition(LiveBroadcastsResource.TransitionRequest.BroadcastStatusEnum.Complete, xyz, "id").ExecuteAsync()

        Catch ex As Exception
            lblErrors.Text = ex.Message
        End Try
    End Sub



    Public Sub startschedule()

        tmrPreparelive.Enabled = True
    End Sub
    Private Sub tmrPreparelive_Tick(sender As Object, e As EventArgs) Handles tmrPreparelive.Tick
        prepareSchedule(liveid)
        tmrPreparelive.Enabled = False

        tmrstartLive.Interval = 15000
        tmrstartLive.Enabled = True
    End Sub
    Private Sub tmrstartLive_Tick(sender As Object, e As EventArgs) Handles tmrstartLive.Tick
        startSchedule(liveid)
        tmrstartLive.Enabled = False

        tmrEndLive.Interval = liveduration * 60000  '20000
        tmrEndLive.Enabled = True
    End Sub

    Private Sub tmrEndLive_Tick(sender As Object, e As EventArgs) Handles tmrEndLive.Tick
        endSchedule(liveid)
        tmrEndLive.Enabled = False
    End Sub

    Private Async Sub cmdSelectforSchedule_Click(sender As Object, e As EventArgs) Handles cmdSelectforSchedule.Click
        Dim lb As New LiveBroadcast
        Dim lbs As New LiveBroadcastStatus
        Dim lbsn As New LiveBroadcastSnippet
        Dim cdtl As New LiveBroadcastContentDetails

        Dim aa = ytObj.LiveBroadcasts.List("snippet")
        aa.Id = lstLiveBroadcast.SelectedItem.ToString

        aa.Fields = "items(snippet(scheduledStartTime))"
        Dim bb = Await aa.ExecuteAsync()

        dgvscheduler.CurrentRow.Cells(0).Value = CType(bb.Items(0).Snippet.ScheduledStartTime, Date) ', "dd/MM/yyyy HH:mm:ss")

        dgvscheduler.CurrentRow.Cells(2).Value = lstLiveBroadcast.SelectedItem.ToString
        dgvscheduler.CurrentRow.Cells(3).Value = lstbroadcastTitle.Items(lstLiveBroadcast.SelectedIndex).ToString

    End Sub

    Private Sub UcCommandSchedulerDateWise1_Load(sender As Object, e As EventArgs)
        On Error Resume Next
        sortschedule()
        tmrcommandschedulestart.Interval = IntervalTill(CType(dgvscheduler.Rows(0).Cells(0).Value, DateTime))
        tmrcommandschedulestart.Enabled = True
        lbltestshedulerecording.Text = "Sheduled Started"
        lbltestshedulerecording.BackColor = Color.Green
    End Sub

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

        Return Difference.TotalMilliseconds - 15000
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
    Private Sub cmdStopSchedule_Click(sender As Object, e As EventArgs) Handles cmdStopSchedule.Click
        tmrcommandschedulestart.Enabled = False
        lbltestshedulerecording.Text = "Schedule Stoped"
        lbltestshedulerecording.BackColor = Color.Red
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
                    dgvscheduler.Rows(g).Cells(3).Value = xyz(2)
                    dgvscheduler.Rows(g).Cells(4).Value = xyz(3)

                    g += 1
                Loop
                sr.Close()
            End Using
            Me.lblscheduleList.Text = "Shedule= " & ofd2.FileName
        End If
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
                        sw.WriteLine(Format(CType(dgvscheduler.Rows(f).Cells(0).Value, DateTime), "dd/MM/yyyy HH:mm:ss") & Chr(2) & dgvscheduler.Rows(f).Cells(2).Value & Chr(2) & dgvscheduler.Rows(f).Cells(3).Value & Chr(2) & dgvscheduler.Rows(f).Cells(4).Value)
                        f += 1
                    Loop
                End If
                sw.Close()
            End Using
            Me.lblscheduleList.Text = "Shedule=  " & osd2.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next
        sortschedule()
        tmrcommandschedulestart.Interval = IntervalTill(CType(dgvscheduler.Rows(0).Cells(0).Value, DateTime))
        tmrcommandschedulestart.Enabled = True
        lbltestshedulerecording.Text = "Sheduled Started"
        lbltestshedulerecording.BackColor = Color.Green
    End Sub
    Dim liveduration As Integer
    Dim liveid As String
    Private Sub tmrcommandschedulestart_Tick(sender As Object, e As EventArgs) Handles tmrcommandschedulestart.Tick
        On Error Resume Next
        If dgvscheduler.Rows(0).Cells(2).Value <> "" Then
            liveid = dgvscheduler.Rows(0).Cells(2).Value
            liveduration = Val(dgvscheduler.Rows(0).Cells(4).Value)

            startschedule()

            startingtimeofrecordingoal = Now
            sortschedule()
            tmrcommandschedulestart.Interval = IntervalTill(CType(dgvscheduler.Rows(0).Cells(0).Value, DateTime))
        Else
            cmdStopSchedule.PerformClick()
        End If


    End Sub

    Dim WithEvents cc1 As VideosResource.InsertMediaUpload
    Dim filelength As Long
    Private Async Sub cmdUpload_Click(sender As Object, e As EventArgs) Handles cmdUpload.Click
        Try
            Dim aa As New Video
            aa.Snippet = New VideoSnippet

            aa.Snippet.Title = "video5"
            aa.Snippet.Description = "description1"
            aa.Snippet.Tags = New String() {"tag1", "tag2"}
            aa.Snippet.CategoryId = "22"
            aa.Status = New VideoStatus
            aa.Status.PrivacyStatus = "private"

            Dim bb As New FileStream(lblFile.Text, FileMode.Open)
            filelength = bb.Length

            cc1 = ytObj.Videos.Insert(aa, "snippet,status", bb, "video/*")
            Dim dd = Await cc1.UploadAsync

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cc1_ProgressChanged(obj As IUploadProgress) Handles cc1.ProgressChanged
        lblUploadStatus.Text = obj.Status.ToString & "  " & Format(((obj.BytesSent) * 100 / filelength), "#000.0").ToString & "%"
    End Sub

    Private Sub cmdofd1_Click(sender As Object, e As EventArgs) Handles cmdofd1.Click
        Dim ofd3 As New OpenFileDialog
        If ofd3.ShowDialog = DialogResult.OK Then
            lblFile.Text = ofd3.FileName
        End If
    End Sub
End Class
