Public Class ucVlcStreamTester
    Dim isplaying As Boolean = False
    Sub PreviewInVlc(aa As String)
        On Error Resume Next
        If isplaying = True Then vlcpreview.VlcMediaPlayer.Stop()
        vlcpreview.VlcMediaPlayer.SetMedia(New Uri(aa))
        vlcpreview.VlcMediaPlayer.Play()
        isplaying = True
    End Sub
    Private Sub cmdremovepreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremovepreview.Click
        On Error Resume Next
        vlcpreview.VlcMediaPlayer.Stop()
        isplaying = False
    End Sub
    Private Sub cmdpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpreview.Click
        PreviewInVlc(txtaddress1.Text)
    End Sub

    Private Sub cmdpreview2_Click(sender As Object, e As EventArgs) Handles cmdpreview2.Click
        PreviewInVlc(txtaddress2.Text)
    End Sub

    Private Sub cmdpreview3_Click(sender As Object, e As EventArgs) Handles cmdpreview3.Click
        PreviewInVlc(txtaddress3.Text)
    End Sub

    Private Sub cmdpreview4_Click(sender As Object, e As EventArgs) Handles cmdpreview4.Click
        PreviewInVlc(txtaddress4.Text)
    End Sub

    Private Sub cmdpreview5_Click(sender As Object, e As EventArgs) Handles cmdpreview5.Click
        PreviewInVlc(txtaddress5.Text)
    End Sub

    Private Sub cmdpreview6_Click(sender As Object, e As EventArgs) Handles cmdpreview6.Click
        PreviewInVlc(txtaddress6.Text)
    End Sub

    Private Sub cmdpreview7_Click(sender As Object, e As EventArgs) Handles cmdpreview7.Click
        PreviewInVlc(txtaddress7.Text)
    End Sub

    Private Sub cmdpreview8_Click(sender As Object, e As EventArgs) Handles cmdpreview8.Click
        PreviewInVlc(txtaddress8.Text)
    End Sub
End Class
