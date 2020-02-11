Public Class ucCG
    Private Sub cmdclockplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclockplay.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        'CasparCGDataCollection.SetData("font", cmbfontsforall.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(8, txtTemplateDirectoryCg.Text & "/" & "clock", True, CasparCGDataCollection.ToAMCPEscapedXml)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Play(8)
    End Sub
    Private Sub cmdplaytwolinecenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplaytwolinecenter.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        'CasparCGDataCollection.SetData("font", cmbfontsforall.Text)
        CasparCGDataCollection.SetData("f0", txttwolinecenter1.Text)
        CasparCGDataCollection.SetData("f1", txttwolinecenter2.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(8, txtTemplateDirectoryCg.Text & "/" & "/" & "twoline_center", True, CasparCGDataCollection.ToAMCPEscapedXml)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Play(8)

    End Sub

    Private Sub cmdplaythreelinecenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplaythreelinecenter.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        'CasparCGDataCollection.SetData("font", cmbfontsforall.Text)
        CasparCGDataCollection.SetData("f0", txtthreelinecenter1.Text)
        CasparCGDataCollection.SetData("f1", txtthreelinecenter2.Text)
        CasparCGDataCollection.SetData("f2", txtthreelinecenter3.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(8, txtTemplateDirectoryCg.Text & "/" & "threeline_center", True, CasparCGDataCollection.ToAMCPEscapedXml)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Play(8)
    End Sub
    Private Sub cmdplayfourlinecenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayfourlinecenter.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        ' CasparCGDataCollection.SetData("font", cmbfontsforall.Text)
        CasparCGDataCollection.SetData("f0", txtfourlinecenter1.Text)
        CasparCGDataCollection.SetData("f1", txtfourlinecenter2.Text)
        CasparCGDataCollection.SetData("f2", txtfourlinecenter3.Text)
        CasparCGDataCollection.SetData("f3", txtfourlinecenter4.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(8, txtTemplateDirectoryCg.Text & "/" & "fourline_center", True, CasparCGDataCollection.ToAMCPEscapedXml)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Play(8)

    End Sub
    Private Sub cmdplaytopleft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplaytopleft.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        'CasparCGDataCollection.SetData("font", cmbfontsforall.Text)
        CasparCGDataCollection.SetData("f0", txttopleft.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(8, txtTemplateDirectoryCg.Text & "/" & "top_left", True, CasparCGDataCollection.ToAMCPEscapedXml)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Play(8)
    End Sub

    Private Sub cmdplaytopright_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplaytopright.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        'CasparCGDataCollection.SetData("font", cmbfontsforall.Text)
        CasparCGDataCollection.SetData("f0", txttopright.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(8, txtTemplateDirectoryCg.Text & "/" & "top_right", True, CasparCGDataCollection.ToAMCPEscapedXml)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Play(8)
    End Sub
    Private Sub cmdclocktotoprightstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclocktotoprightstop.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(8)
    End Sub

    Private Sub cmdplaylivephonein1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplaylivephonein1.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        'CasparCGDataCollection.SetData("font", cmbfontsforall.Text)
        CasparCGDataCollection.SetData("f0", txtlivephonein1.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(9, txtTemplateDirectoryCg.Text & "/" & "live_phonein", True, CasparCGDataCollection.ToAMCPEscapedXml)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Play(9)
    End Sub

    Private Sub cmdplaylivephonein2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplaylivephonein2.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        ' CasparCGDataCollection.SetData("font", cmbfontsforall.Text)
        CasparCGDataCollection.SetData("f0", txtlivephonein2.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(9, txtTemplateDirectoryCg.Text & "/" & "live_phonein", True, CasparCGDataCollection.ToAMCPEscapedXml)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Play(9)
    End Sub
    Private Sub cmdstoplivephonein_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstoplivephonein.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(9)
    End Sub


    Private Sub cmdhidecg_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub ucCG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub cmdPlayHtmlClock_Click(sender As Object, e As EventArgs) Handles cmdPlayHtmlClock.Click
        On Error Resume Next
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & "9999" & " [HTML] c:/casparcg/CMP/cg_template/html/clock/gwd_preview_clock/index.html")
    End Sub
    Private Sub cmdstophtmlcgtemplate_Click(sender As Object, e As EventArgs) Handles cmdstophtmlcgtemplate.Click
        On Error Resume Next
        CasparDevice.SendString("stop " & g_int_ChannelNumber & "-" & "9999")

    End Sub
    Private Sub cmdPlayHtmlTwolineCenter_Click(sender As Object, e As EventArgs)

    End Sub
End Class
