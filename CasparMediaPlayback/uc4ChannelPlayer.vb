Imports System.ComponentModel

Public Class uc4ChannelPlayer
    Private Sub uc4ChannelPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next

        With UcVideoPlayer1
            .channelNumber = 1
            .cmbcasparcgwindowtitle.Text = "Screen consumer [" & .channelNumber & "|PAL]"
            .oscstartandregister(.channelNumber, 6250 + .channelNumber)
            .lblChannel.Text = "Channel " & .channelNumber
        End With

        With UcVideoPlayer2
            .channelNumber = 2
            .cmbcasparcgwindowtitle.Text = "Screen consumer [" & .channelNumber & "|PAL]"
            .oscstartandregister(.channelNumber, 6250 + .channelNumber)
            .lblChannel.Text = "Channel " & .channelNumber
        End With

        With UcVideoPlayer3
            .channelNumber = 3
            .cmbcasparcgwindowtitle.Text = "Screen consumer [" & .channelNumber & "|PAL]"
            .oscstartandregister(.channelNumber, 6250 + .channelNumber)
            .lblChannel.Text = "Channel " & .channelNumber
        End With

        With UcVideoPlayer4
            .channelNumber = 4
            .cmbcasparcgwindowtitle.Text = "Screen consumer [" & .channelNumber & "|PAL]"
            .oscstartandregister(.channelNumber, 6250 + .channelNumber)
            .lblChannel.Text = "Channel " & .channelNumber
        End With
        Threading.Thread.Sleep(2000)
        UcVideoPlayer1.inWindow()
        UcVideoPlayer2.inWindow()
        UcVideoPlayer3.inWindow()
        UcVideoPlayer4.inWindow()

    End Sub

    Private Sub uc4ChannelPlayer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        On Error Resume Next
        UcVideoPlayer1.cmdoutcasparcgwindowrecording.PerformClick()
        UcVideoPlayer2.cmdoutcasparcgwindowrecording.PerformClick()
        UcVideoPlayer3.cmdoutcasparcgwindowrecording.PerformClick()
        UcVideoPlayer4.cmdoutcasparcgwindowrecording.PerformClick()
    End Sub
End Class
