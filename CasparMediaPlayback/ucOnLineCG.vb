Public Class ucOnLineCG
    Private Sub cmdinitialize_Click(sender As Object, e As EventArgs) Handles cmdinitialize.Click
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayercgOnline.Text & " [html] https://vimlesh1975.github.io/ReactCasparClient/html/" + txtCLientId.Text)
    End Sub

    Private Sub cmdStop_Click(sender As Object, e As EventArgs) Handles cmdStop.Click
        CasparDevice.SendString("stop " & g_int_ChannelNumber & "-" & cmblayercgOnline.Text)
    End Sub

    Private Sub cmdOpenOnlineCG_Click(sender As Object, e As EventArgs) Handles cmdOpenOnlineCG.Click
        Process.Start("https://vimlesh1975.github.io/ReactCasparClient/")
    End Sub
End Class
