Public Class ucSwfPlayer
    Private Sub cmdswfplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdswfplay.Click
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("loader1", Replace(picswf.Movie, "\", "/"))
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmbflashlayerforswf.Text), Int(cmbflashlayerforswf.Text), "CMP/swf/swf", True, CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
    Private Sub cmdswfstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdswfstop.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmbflashlayerforswf.Text), Int(cmbflashlayerforswf.Text))
    End Sub
    Private Sub picswf_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdswfopen.Click
        On Error Resume Next

        If (picofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            picswf.Movie = picofd.FileName
        End If
    End Sub

    Private Sub UcSwfPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
