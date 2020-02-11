Public Class ucSystemAudio
    Private Sub cmdSystemAudio_Click(sender As Object, e As EventArgs) Handles cmdSystemAudio.Click
        On Error Resume Next
        If g_int_NumberOfChannels >= 1 Then
            If chkSystemAudioch1.Checked Then
                CasparDevice.SendString("add 1 audio")
            Else
                CasparDevice.SendString("remove 1 audio")
            End If
        End If
        If g_int_NumberOfChannels >= 2 Then
            If chkSystemAudioch2.Checked Then
                CasparDevice.SendString("add 2 audio")
            Else
                CasparDevice.SendString("remove 2 audio")
            End If
        End If
        If g_int_NumberOfChannels >= 3 Then
            If chkSystemAudioch3.Checked Then
                CasparDevice.SendString("add 3 audio")
            Else
                CasparDevice.SendString("remove 3 audio")
            End If
        End If
        If g_int_NumberOfChannels >= 4 Then
            If chkSystemAudioch4.Checked Then
                CasparDevice.SendString("add 4 audio")
            Else
                CasparDevice.SendString("remove 4 audio")
            End If
        End If

    End Sub
    Private Sub cmdcloseRecorder_Click(sender As Object, e As EventArgs) Handles cmdcloseRecorder.Click
        Parent.Controls.Remove(Me)
    End Sub
    Private Sub GbSystemAudio_Enter(sender As Object, e As EventArgs) Handles gbSystemAudio.Enter

    End Sub
End Class
