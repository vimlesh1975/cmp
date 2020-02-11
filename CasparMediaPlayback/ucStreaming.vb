Public Class ucStreaming
    Private Sub cmdsendhlsstreaming_Click(sender As Object, e As EventArgs) Handles cmdsendhlsstreaming.Click
        On Error Resume Next
        CasparDevice.SendString(txtcommandhlstreaming.Text & " " & txtaddresshlsstreaming.Text & "/" & txtapplicationamehlsstreaming.Text & "/" & txtstreamnamehlsstreaming.Text & " " & txtoptionshlsstreaming.Text)

    End Sub
    Private Sub cmdstophlsstreaming_Click(sender As Object, e As EventArgs) Handles cmdstophlsstreaming.Click
        On Error Resume Next
        CasparDevice.SendString("remove " & Mid(txtcommandhlstreaming.Text, 4) & " " & txtaddresshlsstreaming.Text & "/" & txtapplicationamehlsstreaming.Text & "/" & txtstreamnamehlsstreaming.Text & " " & txtoptionshlsstreaming.Text)
    End Sub
    Private Sub cmdsendwsstreaming_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsendwsstreaming.Click
        On Error Resume Next
        CasparDevice.SendString(txtcommandwsstreaming.Text & " " & txtaddresswsstreaming.Text & "/" & txtapplicationamewsstreaming.Text & "/" & txtstreamnamewsstreaming.Text & " " & txtoptionswsstreaming.Text)
    End Sub

    Private Sub cmdsendytstreaming_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsendytstreaming.Click
        On Error Resume Next
        CasparDevice.SendString(txtcommandytstreaming.Text & " " & txtaddressytstreaming.Text & "/" & txtapplicationameytstreaming.Text & "/" & txtstreamnameytstreaming.Text & " " & txtoptionsytstreaming.Text)
    End Sub
    Private Sub cmdstopwsstreaming_Click(sender As Object, e As EventArgs) Handles cmdstopwsstreaming.Click
        On Error Resume Next
        CasparDevice.SendString("remove " & Mid(txtcommandwsstreaming.Text, 4) & " " & txtaddresswsstreaming.Text & "/" & txtapplicationamewsstreaming.Text & "/" & txtstreamnamewsstreaming.Text & " " & txtoptionswsstreaming.Text)

    End Sub
    Private Sub cmdstopytstreaming_Click(sender As Object, e As EventArgs) Handles cmdstopytstreaming.Click
        On Error Resume Next
        CasparDevice.SendString("remove " & Mid(txtcommandytstreaming.Text, 4) & " " & txtaddressytstreaming.Text & "/" & txtapplicationameytstreaming.Text & "/" & txtstreamnameytstreaming.Text)

    End Sub

    Private Sub cmdhidegbstreaming_Click(sender As Object, e As EventArgs) 
        Me.Hide()
    End Sub

    Private Sub cmdsendfbstreaming_Click(sender As Object, e As EventArgs) Handles cmdsendfbstreaming.Click
        On Error Resume Next
        CasparDevice.SendString(txtcommandfbstreaming.Text & " " & txtaddressfbstreaming.Text & txtstreamnamefbstreaming.Text & " " & txtoptionsfbstreaming.Text)

    End Sub

    Private Sub cmdstopfbstreaming_Click(sender As Object, e As EventArgs) Handles cmdstopfbstreaming.Click
        On Error Resume Next
        CasparDevice.SendString("remove " & Mid(txtcommandfbstreaming.Text, 4) & " " & txtaddressfbstreaming.Text & txtstreamnamefbstreaming.Text)

    End Sub

    Private Sub cmdplaystreamingcosumer_Click(sender As Object, e As EventArgs) Handles cmdplaystreamingcosumer.Click
        On Error Resume Next
        CasparDevice.SendString(txtudp.Text)
    End Sub

    Private Sub cmdStopUDP_Click(sender As Object, e As EventArgs) Handles cmdStopUDP.Click
        CasparDevice.SendString("remove " & Split(txtudp.Text, " ")(1) & " " & Split(txtudp.Text, " ")(2) & " " & Split(txtudp.Text, " ")(3))
    End Sub

    Private Sub cmdRemoveNDI_Click(sender As Object, e As EventArgs) Handles cmdRemoveNDI.Click
        CasparDevice.SendString("remove " & Split(txtndi.Text, " ")(1) & " ndi")
    End Sub

    Private Sub cmdAddNDI_Click(sender As Object, e As EventArgs) Handles cmdAddNDI.Click
        CasparDevice.SendString(txtndi.Text)
    End Sub

    Private Sub cmdinput_Click(sender As Object, e As EventArgs) Handles cmdinput.Click
        On Error Resume Next
        If frmmediaplayer.cmdconnect.BackColor = Color.Green Then
            Dim str As String
            str = "play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " decklink " & cmbdecklinkforrecording.Text
            CasparDevice.SendString(str)
        End If
    End Sub

    Private Sub cmdremove_input_Click(sender As Object, e As EventArgs) Handles cmdremove_input.Click
        On Error Resume Next
        If frmmediaplayer.cmdconnect.BackColor = Color.Green Then
            Dim str = "stop " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer
            CasparDevice.SendString(str)
        End If
    End Sub

    Private Sub cmdPlayTestSignal_Click(sender As Object, e As EventArgs) Handles cmdPlayTestSignal.Click
        On Error Resume Next
        SendString(NetStream, txtPlayTestSignal.Text & vbCrLf)
    End Sub

    Private Sub cmdStopTestSignal_Click(sender As Object, e As EventArgs) Handles cmdStopTestSignal.Click
        On Error Resume Next
        SendString(NetStream, txtStopTestSignal.Text & vbCrLf)
    End Sub
End Class
