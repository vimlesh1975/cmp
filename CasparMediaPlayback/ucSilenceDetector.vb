
Imports AudioSwitcher.AudioApi
Imports AudioSwitcher.AudioApi.CoreAudio
Public Class ucSilenceDetector
    Dim aa As Integer = 1
    Dim bb As Double
    Private Sub TmrSilenceDetect_Tick(sender As Object, e As EventArgs) Handles tmrSilenceDetect.Tick
        On Error Resume Next
        If ServerVersion > 2.1 Then
            bb = ucOSC.dgvosc.Rows(57).Cells(1).Value
            If bb = 0 And aa < Val(txtSilenceDuration.Text) Then
                aa = aa + 1
            ElseIf bb = 0 And aa = Val(txtSilenceDuration.Text) Then
                sendotherinfo()
            Else
                aa = 1
            End If
        Else
            bb = ucOSC.dgvosc.Rows(30).Cells(1).Value
            If bb < -190 And aa < Val(txtSilenceDuration.Text) Then
                aa = aa + 1
            ElseIf bb < -190 And aa = Val(txtSilenceDuration.Text) Then
                sendotherinfo()
            Else
                aa = 1
            End If
        End If
    End Sub
    Sub sendotherinfo()
        On Error Resume Next
        If chkPlayToneinVLC.Checked Then
            Dim defaultPlaybackDevice As CoreAudioDevice = New CoreAudioController().DefaultPlaybackDevice
            defaultPlaybackDevice.SetMuteAsync(False)
            defaultPlaybackDevice.SetVolumeAsync(100)
            Dim startInfo As New ProcessStartInfo
            startInfo.FileName = "C:\casparcg\mydata\vlc\vlc-2.2.1-win32\vlc-2.2.1\vlc.exe"
            startInfo.Arguments = "c:\casparcg\_media\tone.mp4 --directx-volume=2 --loop"
            Process.Start(startInfo)
        End If
        If chkSendMail.Checked Then
            Dim aa As New mailtest.clsSendMail
            aa.sendmail(txtTo.Text, txtMessage.Text, "Problem in Casparcg")
        End If
        If chkSwitchTo2ndInput.Checked Then
            CasparDevice.SendString(txtSecondSource.Text)
        End If
        chkSilenceDetect.Checked = False
        tmrSilenceDetect.Enabled = False
        aa = 1
    End Sub
    Private Sub cmdhideSilenceDetector_Click(sender As Object, e As EventArgs) 
        Me.Hide()
    End Sub

    Private Sub ChkSilenceDetect_CheckedChanged(sender As Object, e As EventArgs) Handles chkSilenceDetect.CheckedChanged
        On Error Resume Next
        If chkSilenceDetect.Checked Then
            tmrSilenceDetect.Enabled = True
        Else
            tmrSilenceDetect.Enabled = False
        End If
    End Sub

    Private Sub cmdFirstSource_Click(sender As Object, e As EventArgs) Handles cmdFirstSource.Click
        On Error Resume Next
        CasparDevice.SendString(txtFirstSource.Text)
    End Sub

    Private Sub cmdSecondSource_Click(sender As Object, e As EventArgs) Handles cmdSecondSource.Click
        On Error Resume Next
        CasparDevice.SendString(txtSecondSource.Text)
    End Sub

    Private Sub cmdOutputSource_Click(sender As Object, e As EventArgs) Handles cmdOutputSource.Click
        On Error Resume Next
        CasparDevice.SendString(txtOutputSource.Text)
    End Sub

    Private Sub UcSilenceDetector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
