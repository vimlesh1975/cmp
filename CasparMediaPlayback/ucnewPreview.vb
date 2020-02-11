Public Class ucnewPreview
    Public chnumber As Integer = 1
    Dim isplaying As Boolean = False
    Private Sub cmdpreviewkey_Click(sender As Object, e As EventArgs) Handles cmdpreviewkey.Click
        On Error Resume Next
        CasparDevice.SendString("ADD " & chnumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text & " -vf alphaextract")
        ''Threading.Thread.Sleep(2000)
        'vlcpreview.playlist.items.clear()
        'vlcpreview.playlist.add("udp://@" & cmbippreview.Text)
        'vlcpreview.playlist.play()

        If isplaying = True Then vlcpreview.VlcMediaPlayer.Stop()
        vlcpreview.VlcMediaPlayer.SetMedia(New Uri("udp://@" & cmbippreview.Text))
        vlcpreview.VlcMediaPlayer.Play()
        isplaying = True


    End Sub

    Private Sub cmdpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpreview.Click
        On Error Resume Next
        CasparDevice.SendString("ADD " & chnumber & " STREAM " & "udp://" & cmbippreview.Text & " " & txtoptionspreview.Text)
        'Threading.Thread.Sleep(2000)
        If isplaying = True Then vlcpreview.VlcMediaPlayer.Stop()
        vlcpreview.VlcMediaPlayer.SetMedia(New Uri("udp://@" & cmbippreview.Text))
        vlcpreview.VlcMediaPlayer.Play()
        isplaying = True
    End Sub

    Private Sub cmdremovepreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremovepreview.Click
        On Error Resume Next
        CasparDevice.SendString("remove " & chnumber & " stream " & "udp://" & cmbippreview.Text)
        vlcpreview.VlcMediaPlayer.Stop()
        isplaying = False
    End Sub

    Private Sub Cmdhid_Click(sender As Object, e As EventArgs) Handles cmdhid.Click
        Hide()
    End Sub
End Class
