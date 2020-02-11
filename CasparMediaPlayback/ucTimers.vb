Public Class ucTimers

    '----start timers code
    Private Sub cmdstoptimer_Click(sender As System.Object, e As System.EventArgs) Handles cmdstoptimer.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmbvflayertimers.Text), Int(cmbvflayertimers.Text))
        tmrclipcountdown.Enabled = False
    End Sub

    Private Sub cmdplaycountdowntimer_Click(sender As System.Object, e As System.EventArgs) Handles cmdplaycountdowntimer.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("initialvalue", txtintialvaluecdt.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmbvflayertimers.Text), Int(cmbvflayertimers.Text), txttimersTemplate.Text & "/count_down_timer/count_down_timer", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdplayquiztimetimer_Click(sender As System.Object, e As System.EventArgs) Handles cmdplayquiztimetimer.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmbvflayertimers.Text), Int(cmbvflayertimers.Text), txttimersTemplate.Text & "/quiz_time/timer", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdplayfulltimetimer_Click(sender As System.Object, e As System.EventArgs) Handles cmdplayfulltimetimer.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmbvflayertimers.Text), Int(cmbvflayertimers.Text), txttimersTemplate.Text & "/full_time/off_air_logger_clock", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdplaycountuptimer_Click(sender As System.Object, e As System.EventArgs) Handles cmdplaycountuptimer.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("initialvalue", txtintialvaluecut.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmbvflayertimers.Text), Int(cmbvflayertimers.Text), txttimersTemplate.Text & "/count_up_timer/count_up_timer", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdplayclocktimer_Click(sender As System.Object, e As System.EventArgs) Handles cmdplayclocktimer.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmbvflayertimers.Text), Int(cmbvflayertimers.Text), txttimersTemplate.Text & "/time/clock", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

  
  
    Private Sub cmdhidetimers_Click(sender As Object, e As EventArgs) 
        Me.Hide()
    End Sub

    Private Sub tmrclipcountdown_Tick(sender As Object, e As EventArgs) Handles tmrclipcountdown.Tick
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("time", frmmediaplayer.lblremainintime.Text)
        Dim aa1 As Array = Split(Replace(frmmediaplayer.ucCasparcgWindow1.lblplaying.Text, "\", "/"), "/")
        CasparCGDataCollection.SetData("filename", Split((aa1(aa1.Length - 1)), ".")(0))
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmbvflayertimers.Text), Int(cmbvflayertimers.Text), CasparCGDataCollection)
    End Sub

    Private Sub cmdplayclipCountDowntimer_Click(sender As Object, e As EventArgs) Handles cmdplayclipCountDowntimer.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("time", frmmediaplayer.lblremainintime.Text)
        Dim aa1 As Array = Split(Replace(frmmediaplayer.ucCasparcgWindow1.lblplaying.Text, "\", "/"), "/")
        CasparCGDataCollection.SetData("filename", Split((aa1(aa1.Length - 1)), ".")(0))
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmbvflayertimers.Text), Int(cmbvflayertimers.Text), txttimersTemplate.Text & "/ClipCountDown/ClipCountDown2", True, CasparCGDataCollection.ToAMCPEscapedXml)
        tmrclipcountdown.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ProgramName", txtProgramName.Text)
        CasparCGDataCollection.SetData("someDate", txtsheduleTime.Text)
        CasparCGDataCollection.SetData("ExactTime", txtExactTime.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmbvflayertimers.Text), Int(cmbvflayertimers.Text), txttimersTemplate.Text & "/ProgramCountDown/ProgramCountDown1", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdloopvideo_Click(sender As Object, e As EventArgs) Handles cmdloopvideo.Click
        On Error Resume Next
        CasparDevice.SendString(txtloopvideo.Text)
    End Sub

    Private Sub cmdStoploop_Click(sender As Object, e As EventArgs) Handles cmdStoploop.Click
        On Error Resume Next
        CasparDevice.SendString("Stop 1-499")
    End Sub

    Private Sub cmdStopBoth_Click(sender As Object, e As EventArgs) Handles cmdStopBoth.Click
        On Error Resume Next
        CasparDevice.SendString("Stop 1-499")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmbvflayertimers.Text), Int(cmbvflayertimers.Text))

    End Sub

    Private Sub ucTimers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtsheduleTime.Text = MonthName(Now.Month, 1) & " " & Now.Day & " " & "20:30:00 GMT+" & Replace(Mid(DateTimeOffset.Now.Offset.ToString, 1, 5), ":", "") & " " & Now.Year
    End Sub

    Private Sub cmdplayBackinTimer_Click(sender As Object, e As EventArgs) Handles cmdplayBackinTimer.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", "Back In")
        CasparCGDataCollection.SetData("initialvalue", (Val(txtInitialValueofBackinTimer.Text) * 1000) + 2000)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmbvflayertimers.Text), Int(cmbvflayertimers.Text), txttimersTemplate.Text & "/backin/backin", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
End Class
