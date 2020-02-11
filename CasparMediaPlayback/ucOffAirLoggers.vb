Public Class ucOffAirLoggers
    Private Sub UcOffAirLoggers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With UcnewOffAirLogger1
            .ichannel = 1
            .cmbcasparcgwindowtitlerecording.Text = "Screen consumer [" & .ichannel & "|PAL]"
            .oscstartandregister(.ichannel, 6250 + .ichannel)
            .txtmediadirectoryoal.Text = mediafullpath & "ch" & .ichannel & "/"
            .cmbliveoal.Text = .ichannel
            .lblChannel.Text = "Channel " & .ichannel
        End With

        With UcnewOffAirLogger2
            .ichannel = 2
            .cmbcasparcgwindowtitlerecording.Text = "Screen consumer [" & .ichannel & "|PAL]"
            .oscstartandregister(.ichannel, 6250 + .ichannel)
            .txtmediadirectoryoal.Text = mediafullpath & "ch" & .ichannel & "/"
            .cmbliveoal.Text = .ichannel
            .lblChannel.Text = "Channel " & .ichannel
        End With

        With UcnewOffAirLogger3
            .ichannel = 3
            .cmbcasparcgwindowtitlerecording.Text = "Screen consumer [" & .ichannel & "|PAL]"
            .oscstartandregister(.ichannel, 6250 + .ichannel)
            .txtmediadirectoryoal.Text = mediafullpath & "ch" & .ichannel & "/"
            .cmbliveoal.Text = .ichannel
            .lblChannel.Text = "Channel " & .ichannel
        End With

        With UcnewOffAirLogger4
            .ichannel = 4
            .cmbcasparcgwindowtitlerecording.Text = "Screen consumer [" & .ichannel & "|PAL]"
            .oscstartandregister(.ichannel, 6250 + .ichannel)
            .txtmediadirectoryoal.Text = mediafullpath & "ch" & .ichannel & "/"
            .cmbliveoal.Text = .ichannel
            .lblChannel.Text = "Channel " & .ichannel
        End With
    End Sub

    Private Sub cmdhideoffairlogger1_Click(sender As Object, e As EventArgs) Handles cmdhideoffairlogger1.Click
        'On Error Resume Next
        UcnewOffAirLogger1.stoprecordoal()
        UcnewOffAirLogger1.cmdoutcasparcgwindowrecording.PerformClick()
        UcnewOffAirLogger1.stoposcserver()

        UcnewOffAirLogger1.Hide()
        sender.Hide()

    End Sub

    Private Sub cmdhideoffairlogger2_Click(sender As Object, e As EventArgs) Handles cmdhideoffairlogger2.Click
        On Error Resume Next
        UcnewOffAirLogger2.stoprecordoal()
        UcnewOffAirLogger2.cmdoutcasparcgwindowrecording.PerformClick()
        UcnewOffAirLogger2.stoposcserver()

        UcnewOffAirLogger2.Hide()
        sender.Hide()
    End Sub

    Private Sub cmdhideoffairlogger3_Click(sender As Object, e As EventArgs) Handles cmdhideoffairlogger3.Click
        On Error Resume Next
        UcnewOffAirLogger3.stoprecordoal()
        UcnewOffAirLogger3.cmdoutcasparcgwindowrecording.PerformClick()
        UcnewOffAirLogger3.stoposcserver()

        UcnewOffAirLogger3.Hide()
        sender.Hide()

    End Sub

    Private Sub cmdhideoffairlogger4_Click(sender As Object, e As EventArgs) Handles cmdhideoffairlogger4.Click
        On Error Resume Next
        UcnewOffAirLogger4.stoprecordoal()
        UcnewOffAirLogger4.cmdoutcasparcgwindowrecording.PerformClick()
        UcnewOffAirLogger4.stoposcserver()

        UcnewOffAirLogger4.Hide()
        sender.Hide()
    End Sub

    Private Sub Cmdhideoffairlogger_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        If Not UcnewOffAirLogger1.parentedProcess1 Is Nothing Then
            SetParent(UcnewOffAirLogger1.parentedProcess1.MainWindowHandle, Nothing)
        End If

        If Not UcnewOffAirLogger2.parentedProcess1 Is Nothing Then
            SetParent(UcnewOffAirLogger2.parentedProcess1.MainWindowHandle, Nothing)
        End If

        If Not UcnewOffAirLogger3.parentedProcess1 Is Nothing Then
            SetParent(UcnewOffAirLogger3.parentedProcess1.MainWindowHandle, Nothing)
        End If
        If Not UcnewOffAirLogger4.parentedProcess1 Is Nothing Then
            SetParent(UcnewOffAirLogger4.parentedProcess1.MainWindowHandle, Nothing)
        End If

        UcnewOffAirLogger1.stoposcserver()
        UcnewOffAirLogger2.stoposcserver()
        UcnewOffAirLogger3.stoposcserver()
        UcnewOffAirLogger4.stoposcserver()

        Me.Parent.Controls("ucOffAirLoggers1").Dispose()
    End Sub
End Class
