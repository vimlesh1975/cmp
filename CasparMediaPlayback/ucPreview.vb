Public Class ucPreview
    Dim isplaying As Boolean = False
    Private Sub cmdWaveformluma_Click(sender As Object, e As EventArgs) Handles cmdWaveformluma.Click
        On Error Resume Next

        CasparDevice.SendString("ADD " & g_int_ChannelNumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text)
        Threading.Thread.Sleep(2000)

        Process.Start("CMD", "/K " & "C:/casparcg/mydata/ffmpeg/ffplay.exe " & "udp://" & cmbippreview.Text & " " & "-vf waveform=filter=lowpass:scale=ire:graticule=green:flags=numbers+dots")
        Threading.Thread.Sleep(2000)

        CasparDevice.SendString("remove " & g_int_ChannelNumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text)
        Threading.Thread.Sleep(4000)


        CasparDevice.SendString("ADD " & g_int_ChannelNumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text)
        Threading.Thread.Sleep(4000)

        CasparDevice.SendString("remove " & g_int_ChannelNumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text)
        Threading.Thread.Sleep(4000)


        CasparDevice.SendString("ADD " & g_int_ChannelNumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text)
        Threading.Thread.Sleep(4000)

        CasparDevice.SendString("remove " & g_int_ChannelNumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text)
        Threading.Thread.Sleep(4000)


        CasparDevice.SendString("ADD " & g_int_ChannelNumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text)
        Threading.Thread.Sleep(4000)

        CasparDevice.SendString("remove " & g_int_ChannelNumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text)
        Threading.Thread.Sleep(4000)


        CasparDevice.SendString("ADD " & g_int_ChannelNumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text)
        Threading.Thread.Sleep(4000)
    End Sub

    Private Sub cmdpreviewkey_Click(sender As Object, e As EventArgs) Handles cmdpreviewkey.Click
        On Error Resume Next
        If ServerVersion > 2.1 Then
            CasparDevice.SendString("ADD " & g_int_ChannelNumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text & " -filter:v alphaextract")
        Else
            CasparDevice.SendString("ADD " & g_int_ChannelNumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text & " -vf alphaextract")
        End If

        If isplaying = True Then vlcpreview.VlcMediaPlayer.Stop()
        vlcpreview.VlcMediaPlayer.SetMedia(New Uri("udp://@" & cmbippreview.Text))
        vlcpreview.VlcMediaPlayer.Play()
        isplaying = True
    End Sub

    Private Sub cmdpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpreview.Click
        On Error Resume Next
        CasparDevice.SendString("ADD " & g_int_ChannelNumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text)
        'Threading.Thread.Sleep(2000)
        If isplaying = True Then vlcpreview.VlcMediaPlayer.Stop()
        vlcpreview.VlcMediaPlayer.SetMedia(New Uri("udp://@" & cmbippreview.Text))
        vlcpreview.VlcMediaPlayer.Play()
        isplaying = True
    End Sub

    Private Sub cmdremovepreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremovepreview.Click
        On Error Resume Next
        CasparDevice.SendString("remove " & g_int_ChannelNumber & " stream " & "udp://" & cmbippreview.Text)
        vlcpreview.VlcMediaPlayer.Stop()
        isplaying = False
    End Sub

End Class
