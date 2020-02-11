Public Class ucVS2
    Private Sub cmdshowcrawlVs2_Click(sender As Object, e As EventArgs) Handles cmdshowcrawlVs2.Click
        On Error Resume Next
        crawlvs2()
    End Sub
    Sub crawlvs2()
        On Error Resume Next
        CasparCGDataCollection.Clear()
        Dim str As String

        CasparCGDataCollection.SetData("speed", Int(nspeedVs2.Value))

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayervs2.Text), Int(cmblayervs2.Text), txtvs2Template.Text, True, CasparCGDataCollection.ToAMCPEscapedXml)
        If nspeedVs2.Value <> 0 Then iPauseResumeVs2 = 1
    End Sub

    Private Sub cmdstopcrawlVs2_Click(sender As Object, e As EventArgs) Handles cmdstopcrawlVs2.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayervs2.Text), Int(cmblayervs2.Text))
    End Sub

    Private Sub nspeedVs2_ValueChanged(sender As Object, e As EventArgs) Handles nspeedVs2.ValueChanged
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("speed", nspeedVs2.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayervs2.Text), Int(cmblayervs2.Text), CasparCGDataCollection)

        If nspeedVs2.Value <> 0 Then iPauseResumeVs2 = 1
    End Sub

    Private Sub cmdpausevs2_Click(sender As Object, e As EventArgs) Handles cmdpausevs2.Click
        On Error Resume Next
        PauseResumeVs2()
    End Sub
    Dim iPauseResumeVs2 As Integer = 0
    Sub PauseResumeVs2()
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        If iPauseResumeVs2 = 1 Then
            CasparCGDataCollection.SetData("speed", "0")
        Else
            CasparCGDataCollection.SetData("speed", nspeedVs2.Value)
        End If
        iPauseResumeVs2 = iPauseResumeVs2 + 1
        If iPauseResumeVs2 > 1 Then iPauseResumeVs2 = 0
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayervs2.Text), Int(cmblayervs2.Text), CasparCGDataCollection)

    End Sub
    Private Sub cmdhidevs2_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub cmdshowcrawlVs2html_Click(sender As Object, e As EventArgs) Handles cmdshowcrawlVs2html.Click
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & Int(cmblayervs2.Text) & " opacity 0")

        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & Int(cmblayervs2.Text) & " [HTML] " & """" & txtvs2Templatehtml.Text & """")
        Threading.Thread.Sleep(300)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayervs2.Text) & " speed('" & nspeedVs2html.Value & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayervs2.Text) & " start1()")
        Threading.Thread.Sleep(300)
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & Int(cmblayervs2.Text) & " opacity 1")

        iPauseResumeVs2 = 0
    End Sub

    Private Sub nspeedVs2html_ValueChanged(sender As Object, e As EventArgs) Handles nspeedVs2html.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayervs2.Text) & " speed('" & nspeedVs2html.Value & "')")
    End Sub

    Private Sub cmdstopcrawlVs2html_Click(sender As Object, e As EventArgs) Handles cmdstopcrawlVs2html.Click
        On Error Resume Next
        CasparDevice.SendString("stop " & g_int_ChannelNumber & "-" & Int(cmblayervs2.Text))
    End Sub

    Private Sub cmdpausevs2html_Click(sender As Object, e As EventArgs) Handles cmdpausevs2html.Click
        On Error Resume Next
        If iPauseResumeVs2 = 0 Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayervs2.Text) & " pause()")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayervs2.Text) & " resume()")
        End If
        iPauseResumeVs2 = iPauseResumeVs2 + 1
        If iPauseResumeVs2 > 1 Then iPauseResumeVs2 = 0
    End Sub

    Private Sub UcVS2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
