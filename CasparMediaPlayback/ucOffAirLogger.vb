
Public Class ucOffAirLogger
    Private Sub ucOffAirLogger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With UcnewOffAirLogger1
            .ichannel = g_int_ChannelNumber
            .cmbcasparcgwindowtitlerecording.Text = "Screen consumer [" & .ichannel & "|PAL]"
            .oscstartandregister(.ichannel, 6250 + .ichannel)
            .txtmediadirectoryoal.Text = mediafullpath & "ch" & .ichannel & "/"
            .cmbliveoal.Text = .ichannel
            .lblChannel.Text = "Channel " & .ichannel
        End With
    End Sub
    Private Sub UcnewOffAirLogger1_Load(sender As Object, e As EventArgs) Handles UcnewOffAirLogger1.Load
    End Sub
    Private Sub cmdhideoffairlogger_Click(sender As Object, e As EventArgs) 
        UcnewOffAirLogger1.stoprecordoal()
        UcnewOffAirLogger1.cmdoutcasparcgwindowrecording.PerformClick()
        UcnewOffAirLogger1.stoposcserver()
        Parent.Controls.Remove(Me)

    End Sub
End Class
