
Imports System.Net
Imports Newtonsoft.Json.Linq
Public Class ucHTML
    Private Sub cmdplayhtml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayhtml.Click
        On Error Resume Next
        playhtml()
    End Sub
    Sub playhtml()
        On Error Resume Next
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayerhtml.Text & " [HTML] " & """" & txturlhtml.Text & """")
    End Sub

    Private Sub cmdstophtml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstophtml.Click
        On Error Resume Next
        CasparDevice.SendString("stop " & g_int_ChannelNumber & "-" & cmblayerhtml.Text)
    End Sub
    Private Sub cmdhidegbhtml_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub cmdreplaceurlforyoutubehtml_Click(sender As Object, e As EventArgs) Handles cmdreplaceurlforyoutubehtml.Click
        On Error Resume Next
        txturlhtml.Text = Replace(txturlhtml.Text, "watch?v=", "embed/") & "?autoplay=true"
    End Sub
    Private Sub cmdhtmlopen_Click(sender As Object, e As EventArgs) Handles cmdhtmlopen.Click
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog
        ofd2.Filter = "All files (*.*)|*.*"
        'ofd2.InitialDirectory = "c:\casparcg\mydata\logo\logo_list\"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            txturlhtml.Text = "file:///" & Replace(ofd2.FileName, "\", "/")
        End If
    End Sub
    Function replacestring(str As String) As String
        str = Replace(str, vbCrLf, "<br />")
        str = Replace(str, " ", "xxx")
        str = Replace(str, "'", "yyy")
        str = Replace(str, """", "zzz")
        Return str
    End Function

    Private Sub cmdLoadVideo_Click(sender As Object, e As EventArgs) Handles cmdLoadVideo.Click
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayerhtml.Text & " [HTML]  file:///C:/casparcg/mydata/youtube/youtube.html")
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayerhtml.Text & " opacity 0")
        Threading.Thread.Sleep(1000)
        CasparDevice.SendString("Call " & g_int_ChannelNumber & "-" & cmblayerhtml.Text & " player.loadVideoById('" & txtvideoId.Text & "')")
        CasparDevice.SendString("Call " & g_int_ChannelNumber & "-" & cmblayerhtml.Text & " player.setSize('" & txtwidth.Text & "','" & txtheight.Text & "')")
        Threading.Thread.Sleep(1000)
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayerhtml.Text & " opacity 1")
    End Sub
    Private Sub cmdPause_Click(sender As Object, e As EventArgs) Handles cmdPause.Click
        CasparDevice.SendString("Call " & g_int_ChannelNumber & "-" & cmblayerhtml.Text & " player.pauseVideo()")
    End Sub

    Private Sub cmdResume_Click(sender As Object, e As EventArgs) Handles cmdResume.Click
        CasparDevice.SendString("Call " & g_int_ChannelNumber & "-" & cmblayerhtml.Text & " player.playVideo()")
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        CasparDevice.SendString("Call " & g_int_ChannelNumber & "-" & cmblayerhtml.Text & " player.seekTo('" & TrackBar1.Value & "','True')")
        lblCurrentTime.Text = TrackBar1.Value
    End Sub

    Private Sub cmdSetDuration_Click(sender As Object, e As EventArgs) Handles cmdSetDuration.Click
        TrackBar1.Maximum = txtduration.Text
    End Sub
    Private Sub cmdGetDuration_Click(sender As Object, e As EventArgs) Handles cmdGetDuration.Click
        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString("https://www.googleapis.com/youtube/v3/videos?id=" & txtvideoId.Text & "&part=contentDetails&key=AIzaSyA7uT2JcYKG6g4aULmp9KiSGFsHu-uEP6I")

        Threading.Thread.Sleep(2000)
        'Dim json = JObject.Parse(result)

        lblDuration.Text = JObject.Parse(result).Item("items")(0).Item("contentDetails").Item("duration")
    End Sub
    Private Sub cdOpenremoteDebugging_Click(sender As Object, e As EventArgs) Handles cdOpenremoteDebugging.Click
        On Error Resume Next
        Process.Start("http://localhost:" & txtDebugPort.Text)
    End Sub
    Private Sub ucHTML_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
