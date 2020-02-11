
Public Class ucPlaylistSetting
    Private Sub ucPlaylistSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Sub resizeoptions() Handles rdocentercutsetting.CheckedChanged, rdoletterboxsettings.CheckedChanged, rdopillarboxsettings.CheckedChanged, rdocentercutsetting.CheckedChanged, rdoanamorphic.CheckedChanged
        On Error Resume Next
        If rdocentercutsetting.Checked And rdocentercutsetting.IsHandleCreated Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " fill " & txtcentercutsetting.Text)
        ElseIf rdoletterboxsettings.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " fill " & txtletterboxsettings.Text)
        ElseIf rdopillarboxsettings.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " fill " & txtpillarboxsettings.Text)
        ElseIf rdocropsettings.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " fill " & txtcropsettings.Text)
        ElseIf rdoanamorphic.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " fill " & txtanamorphic.Text)

        End If
    End Sub

    Function folderbrowsing(originaldirectory As String)
        On Error Resume Next
        Dim fbd As New FolderBrowserDialog
        If fbd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Return fbd.SelectedPath & "\"
        Else
            Return originaldirectory
        End If
    End Function
    Private Sub SetChannel_Click(sender As Object, e As EventArgs) Handles SetChannel.Click
        On Error Resume Next
        setchannelnumber(cmbchannelnewinstance.Text)
    End Sub
    Public Sub setchannelnumber(chn As Integer)
        With frmmediaplayer
            .cmbchannel.Text = chn
            .cmbchannel.Enabled = False
            ucOSC.stoposcserver()
            ucOSC.cmboscport.Text = 6249 + chn
            ucOSC.cmboscport.Enabled = False
            ucOSC.oscstartandregister()
            .ucCasparcgWindow1.cmbcasparcgwindowtitle.Text = "Screen consumer [" & chn & "|PAL]"
        End With
    End Sub
    Private Sub chkSendFileNameWithoutExtension_CheckedChanged(sender As Object, e As EventArgs) Handles chkSendFileNameWithoutExtension.CheckedChanged
        If chkSendFileNameWithoutExtension.Checked = True Then
            filenamewithoutextensioncheck = True
        Else
            filenamewithoutextensioncheck = False
        End If
    End Sub
End Class
