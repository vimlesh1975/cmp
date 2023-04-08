
Imports System.ComponentModel
Imports LinqToTwitter
Imports TweetSharp

Public Class ucTwitter
    Private Sub cmdhidetwitter_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub cmdsearchquerytwitterbyscreenname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearchquerytwitterbyscreenname.Click
        On Error Resume Next
        bwtwitterscreenname.RunWorkerAsync()
    End Sub
    Private Sub cmdplaytwitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplaytwitter.Click
        On Error Resume Next
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayertwitter.Text & " [HTML] c:/casparcg/CMP/twitter/twitter1/twitter1.html")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayertwitter.Text & " updatestring('" & replacestring1("ccgf0") & "','" & replacestring1(dgvtwitter.CurrentRow.Cells(1).Value) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayertwitter.Text & " updatestring('" & replacestring1("ccgf1") & "','" & replacestring1(dgvtwitter.CurrentRow.Cells(2).Value) & "')")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayertwitter.Text & " updateimage('" & replacestring1("ccgimage1") & "','" & replacestring1(Replace(dgvtwitter.CurrentRow.Cells(3).Value, "_normal", "")) & "')")
    End Sub

    Private Sub cmdnextsteptwitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnextsteptwitter.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Next(Int(cmblayertwitter.Text), Int(cmblayertwitter.Text))
    End Sub

    Private Sub cmdstoptwitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstoptwitter.Click
        On Error Resume Next
        CasparDevice.SendString("Stop " & g_int_ChannelNumber & "-" & Int(cmblayertwitter.Text))
    End Sub
    Private Sub bwtwitterscreenname_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwtwitterscreenname.DoWork
        ' Try
        dgvtwitter.Rows.Clear()
        dgvtwitter.RowTemplate.Height = 75

        Dim oCredential As New InMemoryCredentials
        oCredential.ConsumerKey = txtConsumerkey.Text
        oCredential.ConsumerSecret = txtConsumersecret.Text

        '*** Use application-only authentication to connect to Twitter. ***
        Dim oAuthorizer = New ApplicationOnlyAuthorizer With {
            .Credentials = oCredential
        }
        oAuthorizer.Authorize()

        '*** Define a list of screen names to check for public tweets. ***
        Dim screenNames As String = txthashtag.Text '"vimlesh1975" ' "LambtonAlerts,LambtonFireInfo,SarniaPolice"

        '*** Define a cutoff date, e.g., 1-day old. ***
        Dim cutoffDate As Date = Now.Subtract(New TimeSpan(ndaysoftweet.Value, 0, 0, 0))

        '*** This is to remove the time from the date. ***
        cutoffDate = cutoffDate.Date

        Using oTwitterContext As New TwitterContext(oAuthorizer)

            '*** Instantiate a master list of tweets. ***
            Dim allTweets As New List(Of LinqToTwitter.Status)

            Threading.Thread.Sleep(2000)

            '*** Need to check one screen name at a time. ***
            For Each s As String In screenNames.Split(",")

                Dim screenName As String = s.Trim

                If String.IsNullOrEmpty(screenName) = False Then


                    Dim tweets = (From tweet In oTwitterContext.Status
                                  Where tweet.ScreenName = txthashtag.Text _
                                            And tweet.Type = StatusType.User _
                                              And tweet.Count = nNumberoftweets.Value _
                                            And tweet.CreatedAt.ToLocalTime >= cutoffDate _
                                            And tweet.ExcludeReplies = True
                                  Select tweet).ToList

                    '*** Add tweets to the master list. ***
                    If tweets.Count > 0 Then allTweets.AddRange(tweets)

                End If

            Next

            '*** Display all the tweets from newest to oldest. ***

            dgvtwitter.Rows.Add(1)
            pbtwitter.Value = 0
            pbtwitter.Maximum = allTweets.Count

            For Each tweet In allTweets.OrderByDescending(Function(a) a.CreatedAt)

                dgvtwitter.Rows.Add(1)
                dgvtwitter.CurrentRow.Cells(0).Value = Image.FromStream(System.Net.HttpWebRequest.Create(tweet.User.ProfileImageUrl).GetResponse().GetResponseStream())


                dgvtwitter.CurrentRow.Cells(1).Value = tweet.ScreenName
                dgvtwitter.CurrentRow.Cells(2).Value = tweet.Text
                dgvtwitter.CurrentRow.Cells(3).Value = tweet.User.ProfileImageUrl
                Dim i = dgvtwitter.CurrentRow.Index

                dgvtwitter.CurrentCell = dgvtwitter.Rows(i + 1).Cells(0)
                pbtwitter.Value = pbtwitter.Value + 1
            Next

            '*** To display current rate limit info. ***
            Dim resetWhen As New DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            resetWhen = resetWhen.AddSeconds(oTwitterContext.RateLimitReset).ToLocalTime()

            txtsearchlimit.Text = String.Format("Remaining = {0}; Limit = {1}; Next Reset = {2}", oTwitterContext.RateLimitRemaining, oTwitterContext.RateLimitCurrent, resetWhen.ToString)

        End Using
        'Catch ex As Exception
        'dummy
        'End Try
    End Sub

    Private Sub bwtwitterscreenname_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwtwitterscreenname.RunWorkerCompleted
        On Error Resume Next
        dgvtwitter.ScrollBars = ScrollBars.Both
    End Sub
    Private Sub cmdtxtsearchbywordtwitter_Click(sender As Object, e As EventArgs) Handles cmdtxtsearchbywordtwitter.Click
        dgvtwitter.Rows.Clear()
        dgvtwitter.RowTemplate.Height = 75

        Dim oCredential As New InMemoryCredentials
        oCredential.ConsumerKey = txtConsumerkey.Text
        oCredential.ConsumerSecret = txtConsumersecret.Text

        '*** Use application-only authentication to connect to Twitter. ***
        Dim oAuthorizer As New ApplicationOnlyAuthorizer With {
            .Credentials = oCredential
        }
        oAuthorizer.Authorize()
        'On Error Resume Next

        Using oTwitterContext As New TwitterContext(oAuthorizer)
            Threading.Thread.Sleep(2000)
            dgvtwitter.Rows.Add()
            pbtwitter.Value = 0
            Dim srch = (From search In oTwitterContext.Search Where search.Type = SearchType.Search AndAlso search.Query = txtsearchbywordtwitter.Text AndAlso search.Count = nNumberoftweets.Value Select search).SingleOrDefault()
            pbtwitter.Maximum = srch.Statuses.Count



            For Each entry As LinqToTwitter.Status In srch.Statuses

                dgvtwitter.CurrentRow.Cells(0).Value = Image.FromStream(System.Net.HttpWebRequest.Create(entry.User.ProfileImageUrl).GetResponse().GetResponseStream())
                dgvtwitter.CurrentRow.Cells(1).Value = entry.User.Name
                dgvtwitter.CurrentRow.Cells(2).Value = entry.Text
                dgvtwitter.CurrentRow.Cells(3).Value = entry.User.ProfileImageUrl
                pbtwitter.Value = pbtwitter.Value + 1
                dgvtwitter.Rows.Add()
                dgvtwitter.CurrentCell = dgvtwitter.Rows(dgvtwitter.CurrentRow.Index + 1).Cells(0)

            Next
            dgvtwitter.ScrollBars = ScrollBars.Both
            ''*** To display current rate limit info. ***
            Dim resetWhen As New DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            resetWhen = resetWhen.AddSeconds(oTwitterContext.RateLimitReset).ToLocalTime()

            txtsearchlimit.Text = String.Format("Remaining = {0}; Limit = {1}; Next Reset = {2}", oTwitterContext.RateLimitRemaining, oTwitterContext.RateLimitCurrent, resetWhen.ToString)

        End Using

    End Sub
    Private Sub cmdsearchquerytwitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearchquerytwitter.Click
        On Error Resume Next
        bwtwitter.RunWorkerAsync()

    End Sub
    Private Sub bwtwitter_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwtwitter.DoWork
        On Error Resume Next

        Control.CheckForIllegalCrossThreadCalls = False

        dgvtwitter.RowTemplate.Height = 75
        Dim service = New TwitterService(txtConsumerkey.Text, txtConsumersecret.Text)
        service.AuthenticateWith(txtAccesstokentwitter.Text, txtAccesstokensecret.Text)
        Dim tweets = service.ListTweetsOnHomeTimeline(New ListTweetsOnHomeTimelineOptions() With {.Count = nNumberoftweets.Value})

        Threading.Thread.Sleep(2000)

        Dim itwitter As Integer = 0
        dgvtwitter.Rows.Clear()

        pbtwitter.Minimum = 0
        pbtwitter.Maximum = tweets.Count

        For Each tweet In tweets
            dgvtwitter.Rows.Add()
            dgvtwitter.Rows(itwitter).Cells(0).Value = Image.FromStream(System.Net.HttpWebRequest.Create(tweet.User.ProfileImageUrl).GetResponse().GetResponseStream())
            dgvtwitter.Rows(itwitter).Cells(1).Value = tweet.User.ScreenName
            dgvtwitter.Rows(itwitter).Cells(2).Value = tweet.Text
            dgvtwitter.Rows(itwitter).Cells(3).Value = tweet.User.ProfileImageUrl
            itwitter = itwitter + 1

            pbtwitter.Value = itwitter
        Next
    End Sub

    Private Sub bwtwitter_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwtwitter.RunWorkerCompleted
        On Error Resume Next
        dgvtwitter.ScrollBars = ScrollBars.Both
    End Sub

    Private Sub cmdreadkeyforTwitter_Click(sender As Object, e As EventArgs) Handles cmdreadkeyforTwitter.Click
        On Error Resume Next
        Using sr As IO.StreamReader = New IO.StreamReader("d:/key.txt")
            Dim g As Integer = 0
            Dim li As String
            Do Until sr.EndOfStream = True
                li = sr.ReadLine()
                Dim xyz As Array = Split(li, ",")
                If g = 0 Then txtConsumerkey.Text = xyz(1)
                If g = 1 Then txtConsumersecret.Text = xyz(1)
                If g = 2 Then txtAccesstokentwitter.Text = xyz(1)
                If g = 3 Then txtAccesstokensecret.Text = xyz(1)

                g = g + 1
            Loop
            sr.Close()
        End Using
    End Sub

    Private Sub ucTwitter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hghh
    End Sub

    Private Sub cmdHtmlplay_Click(sender As Object, e As EventArgs) Handles cmdHtmlplay.Click
        On Error Resume Next
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayertwitter.Text & " [HTML] c:/casparcg/CMP/twitter/twitter1fullpage/twitter1.html")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayertwitter.Text & " updatestring('" & replacestring1("ccgf0") & "','" & replacestring1(dgvtwitter.CurrentRow.Cells(1).Value) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayertwitter.Text & " updatestring('" & replacestring1("ccgf1") & "','" & replacestring1(dgvtwitter.CurrentRow.Cells(2).Value) & "')")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayertwitter.Text & " updateimage('" & replacestring1("ccgimage1") & "','" & replacestring1(Replace(dgvtwitter.CurrentRow.Cells(3).Value, "_normal", "")) & "')")

    End Sub
End Class
