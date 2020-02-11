Public Class ucImageScroll
    Dim ipauseresume As Integer = 0
    Private Sub cmdimagescrollplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdimagescrollplay.Click
        On Error Resume Next
        Dim xxx As String = ""
        Dim yyy As String = ""
        If chkPREMULTIPLY.Checked = True Then xxx = "PREMULTIPLY"
        If chkPROGRESSIVE.Checked = True Then yyy = "PROGRESSIVE"
        CasparDevice.SendString("clear " & g_int_ChannelNumber & "-" & cmblayervideoforimage.Text)
        CasparDevice.SendString("loadbg " & g_int_ChannelNumber & "-" & cmblayervideoforimage.Text & " " & """" & cmbimageforimagescroll.Text & """" & " speed " & cmbimagescrollspeed.Text & " blur " & cmbimagescrollblur.Text & " " & xxx & " " & yyy)
        Threading.Thread.Sleep(1000)
        CasparDevice.SendString("Play " & g_int_ChannelNumber & "-" & cmblayervideoforimage.Text)

        ipauseresume = 0
    End Sub

    Sub mediafilesforimagescroll()
        On Error Resume Next
        cmbimageforimagescroll.Items.Clear()

        CasparDevice.RefreshMediafiles()
        Threading.Thread.Sleep(250)
        For Each File In CasparDevice.Mediafiles
            If File.Type = Svt.Caspar.MediaType.STILL Then
                cmbimageforimagescroll.Items.Add(Replace(File.ToString, "\", "/"))
            End If
        Next
    End Sub
    Private Sub cmdrefreshimagefilesforimagescroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrefreshimagefilesforimagescroll.Click
        On Error Resume Next
        mediafilesforimagescroll()
    End Sub

    Private Sub chkPREMULTIPLY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPREMULTIPLY.CheckedChanged
        On Error Resume Next
        If chkPREMULTIPLY.Checked = True Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayervideoforimage.Text & " PREMULTIPLY 1")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayervideoforimage.Text & " PREMULTIPLY 0")

        End If

    End Sub

    Private Sub chkPROGRESSIVE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPROGRESSIVE.CheckedChanged
        On Error Resume Next
        If chkPROGRESSIVE.Checked = True Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayervideoforimage.Text & " PROGRESSIVE 1")

        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayervideoforimage.Text & " PROGRESSIVE 0")

        End If
    End Sub

    Private Sub cmbimagescrollblur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbimagescrollblur.SelectedIndexChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayervideoforimage.Text & " blur " & cmbimagescrollblur.Text)

    End Sub

    Private Sub cmbimagescrollspeed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbimagescrollspeed.SelectedIndexChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayervideoforimage.Text & " speed " & cmbimagescrollspeed.Text)

    End Sub
    Private Sub cmdimagestop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdimagestop.Click
        On Error Resume Next
        CasparDevice.SendString("stop " & g_int_ChannelNumber & "-" & cmblayervideoforimage.Text)
        ipauseresume = 0
    End Sub


    Private Sub cmdhidegbimagescroll_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub cmdPauseResume_Click(sender As Object, e As EventArgs) Handles cmdPauseResume.Click

        If Mid(frmmediaplayer.lblserverversion.Text, 1, 3) = "2.1" Then
            If ipauseresume = 0 Then
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayervideoforimage.Text & " speed 0")
            Else
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayervideoforimage.Text & " speed " & cmbimagescrollspeed.Text)
            End If
        Else
            If ipauseresume = 0 Then
                CasparDevice.SendString("pause " & g_int_ChannelNumber & "-" & cmblayervideoforimage.Text)
            Else
                CasparDevice.SendString("resume " & g_int_ChannelNumber & "-" & cmblayervideoforimage.Text)
            End If
        End If

        ipauseresume = ipauseresume + 1
        If ipauseresume > 1 Then ipauseresume = 0
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        On Error Resume Next
        Process.Start("https://drive.google.com/open?id=1DlMkTGOlqAMhw0eRReyPwv85ow6FVTBn")
    End Sub
    Private Sub ucImageScroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
