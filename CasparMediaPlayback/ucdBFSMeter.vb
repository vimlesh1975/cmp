Public Class ucdBFSMeter
    Private Sub cmdhidedbfsmeter1_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub
    Private Sub ucdBFSMeter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub tmraudio_Tick(sender As Object, e As EventArgs) Handles tmraudio.Tick
        On Error Resume Next
        With ucOSC
            If ServerVersion > 2.1 Then

                If .dgvosc.Rows(57).Cells(1).Value <> "" Then
                    DBFS_Meter1.DBFS_Value = ValuetodBFS(.dgvosc.Rows(57).Cells(1).Value)
                Else
                    DBFS_Meter1.DBFS_Value = -40
                End If

                If .dgvosc.Rows(57).Cells(2).Value <> "" Then
                    DBFS_Meter2.DBFS_Value = ValuetodBFS(.dgvosc.Rows(57).Cells(2).Value)
                Else
                    DBFS_Meter2.DBFS_Value = -40
                End If

                If .dgvosc.Rows(57).Cells(3).Value <> "" Then
                    DBFS_Meter3.DBFS_Value = ValuetodBFS(.dgvosc.Rows(57).Cells(3).Value)
                Else
                    DBFS_Meter3.DBFS_Value = -40
                End If

                If .dgvosc.Rows(57).Cells(4).Value <> "" Then
                    DBFS_Meter4.DBFS_Value = ValuetodBFS(.dgvosc.Rows(57).Cells(4).Value)
                Else
                    DBFS_Meter4.DBFS_Value = -40
                End If

                If .dgvosc.Rows(57).Cells(5).Value <> "" Then
                    DBFS_Meter5.DBFS_Value = ValuetodBFS(.dgvosc.Rows(57).Cells(5).Value)
                Else
                    DBFS_Meter5.DBFS_Value = -40
                End If

                If .dgvosc.Rows(57).Cells(6).Value <> "" Then
                    DBFS_Meter6.DBFS_Value = ValuetodBFS(.dgvosc.Rows(57).Cells(6).Value)
                Else
                    DBFS_Meter6.DBFS_Value = -40
                End If

                If .dgvosc.Rows(57).Cells(7).Value <> "" Then
                    DBFS_Meter7.DBFS_Value = ValuetodBFS(.dgvosc.Rows(57).Cells(7).Value)
                Else
                    DBFS_Meter7.DBFS_Value = -40
                End If

                If .dgvosc.Rows(57).Cells(8).Value <> "" Then
                    DBFS_Meter8.DBFS_Value = ValuetodBFS(.dgvosc.Rows(57).Cells(8).Value)
                Else
                    DBFS_Meter8.DBFS_Value = -40
                End If

                If .dgvosc.Rows(57).Cells(9).Value <> "" Then
                    DBFS_Meter9.DBFS_Value = ValuetodBFS(.dgvosc.Rows(57).Cells(9).Value)
                Else
                    DBFS_Meter9.DBFS_Value = -40
                End If

                If .dgvosc.Rows(57).Cells(10).Value <> "" Then
                    DBFS_Meter10.DBFS_Value = ValuetodBFS(.dgvosc.Rows(57).Cells(10).Value)
                Else
                    DBFS_Meter10.DBFS_Value = -40
                End If

                If .dgvosc.Rows(57).Cells(11).Value <> "" Then
                    DBFS_Meter11.DBFS_Value = ValuetodBFS(.dgvosc.Rows(57).Cells(11).Value)
                Else
                    DBFS_Meter11.DBFS_Value = -40
                End If

                If .dgvosc.Rows(57).Cells(12).Value <> "" Then
                    DBFS_Meter12.DBFS_Value = ValuetodBFS(.dgvosc.Rows(57).Cells(12).Value)
                Else
                    DBFS_Meter12.DBFS_Value = -40
                End If

                If .dgvosc.Rows(57).Cells(13).Value <> "" Then
                    DBFS_Meter13.DBFS_Value = ValuetodBFS(.dgvosc.Rows(57).Cells(13).Value)
                Else
                    DBFS_Meter13.DBFS_Value = -40
                End If

                If .dgvosc.Rows(57).Cells(14).Value <> "" Then
                    DBFS_Meter14.DBFS_Value = ValuetodBFS(.dgvosc.Rows(57).Cells(14).Value)
                Else
                    DBFS_Meter14.DBFS_Value = -40
                End If

                If .dgvosc.Rows(57).Cells(15).Value <> "" Then
                    DBFS_Meter15.DBFS_Value = ValuetodBFS(.dgvosc.Rows(57).Cells(15).Value)
                Else
                    DBFS_Meter15.DBFS_Value = -40
                End If

                If .dgvosc.Rows(57).Cells(16).Value <> "" Then
                    DBFS_Meter16.DBFS_Value = ValuetodBFS(.dgvosc.Rows(57).Cells(16).Value)
                Else
                    DBFS_Meter16.DBFS_Value = -40
                End If

            Else
                If .dgvosc.Rows(30).Cells(1).Value <> "" Then
                    DBFS_Meter1.DBFS_Value = .dgvosc.Rows(30).Cells(1).Value
                Else
                    DBFS_Meter1.DBFS_Value = -40
                End If

                If .dgvosc.Rows(31).Cells(1).Value <> "" Then
                    DBFS_Meter2.DBFS_Value = .dgvosc.Rows(31).Cells(1).Value
                Else
                    DBFS_Meter2.DBFS_Value = -40
                End If

                If .dgvosc.Rows(32).Cells(1).Value <> "" Then
                    DBFS_Meter3.DBFS_Value = .dgvosc.Rows(32).Cells(1).Value
                Else
                    DBFS_Meter3.DBFS_Value = -40
                End If

                If .dgvosc.Rows(33).Cells(1).Value <> "" Then
                    DBFS_Meter4.DBFS_Value = .dgvosc.Rows(33).Cells(1).Value
                Else
                    DBFS_Meter4.DBFS_Value = -40
                End If
                If .dgvosc.Rows(34).Cells(1).Value <> "" Then
                    DBFS_Meter5.DBFS_Value = .dgvosc.Rows(34).Cells(1).Value
                Else
                    DBFS_Meter5.DBFS_Value = -40
                End If

                If .dgvosc.Rows(35).Cells(1).Value <> "" Then
                    DBFS_Meter6.DBFS_Value = .dgvosc.Rows(35).Cells(1).Value
                Else
                    DBFS_Meter6.DBFS_Value = -40
                End If


                If .dgvosc.Rows(36).Cells(1).Value <> "" Then
                    DBFS_Meter7.DBFS_Value = .dgvosc.Rows(36).Cells(1).Value
                Else
                    DBFS_Meter7.DBFS_Value = -40
                End If

                If .dgvosc.Rows(37).Cells(1).Value <> "" Then
                    DBFS_Meter8.DBFS_Value = .dgvosc.Rows(37).Cells(1).Value
                Else
                    DBFS_Meter8.DBFS_Value = -40
                End If


                If .dgvosc.Rows(38).Cells(1).Value <> "" Then
                    DBFS_Meter9.DBFS_Value = .dgvosc.Rows(38).Cells(1).Value
                Else
                    DBFS_Meter9.DBFS_Value = -40
                End If

                If .dgvosc.Rows(39).Cells(1).Value <> "" Then
                    DBFS_Meter10.DBFS_Value = .dgvosc.Rows(39).Cells(1).Value
                Else
                    DBFS_Meter10.DBFS_Value = -40
                End If

                If .dgvosc.Rows(40).Cells(1).Value <> "" Then
                    DBFS_Meter11.DBFS_Value = .dgvosc.Rows(40).Cells(1).Value
                Else
                    DBFS_Meter11.DBFS_Value = -40
                End If

                If .dgvosc.Rows(41).Cells(1).Value <> "" Then
                    DBFS_Meter12.DBFS_Value = .dgvosc.Rows(41).Cells(1).Value
                Else
                    DBFS_Meter12.DBFS_Value = -40
                End If

                If .dgvosc.Rows(42).Cells(1).Value <> "" Then
                    DBFS_Meter13.DBFS_Value = .dgvosc.Rows(42).Cells(1).Value
                Else
                    DBFS_Meter13.DBFS_Value = -40
                End If

                If .dgvosc.Rows(43).Cells(1).Value <> "" Then
                    DBFS_Meter14.DBFS_Value = .dgvosc.Rows(43).Cells(1).Value
                Else
                    DBFS_Meter14.DBFS_Value = -40
                End If

                If .dgvosc.Rows(44).Cells(1).Value <> "" Then
                    DBFS_Meter15.DBFS_Value = .dgvosc.Rows(44).Cells(1).Value
                Else
                    DBFS_Meter15.DBFS_Value = -40
                End If

                If .dgvosc.Rows(45).Cells(1).Value <> "" Then
                    DBFS_Meter16.DBFS_Value = .dgvosc.Rows(45).Cells(1).Value
                Else
                    DBFS_Meter16.DBFS_Value = -40
                End If
            End If

        End With
    End Sub

    Private Sub cmdL_to_Both_Click(sender As Object, e As EventArgs) Handles cmdL_to_Both.Click
        On Error Resume Next
        With frmmediaplayer
            If ServerVersion > 2.1 Then
                CasparDevice.SendString("play " & .cmbchannel.Text & "-" & .cmblayervideo.Text & " " & """" & ModifyFilename(ucOSC.dgvosc.Rows(56).Cells(1).Value) & """" & " seek " & (ucOSC.dgvosc.Rows(6).Cells(1).Value + 3) * 2 & " af pan=stereo|c0=c0|c1=c0")

            Else
                CasparDevice.SendString("play " & .cmbchannel.Text & "-" & .cmblayervideo.Text & " " & """" & ModifyFilename(ucOSC.dgvosc.Rows(8).Cells(1).Value) & """" & " seek " & ucOSC.dgvosc.Rows(6).Cells(1).Value + 12 & " channel_layout L_to_Both")

            End If
        End With
    End Sub

    Private Sub cmdR_to_Both_Click(sender As Object, e As EventArgs) Handles cmdR_to_Both.Click
        On Error Resume Next
        With frmmediaplayer
            If ServerVersion > 2.1 Then
                CasparDevice.SendString("play " & .cmbchannel.Text & "-" & .cmblayervideo.Text & " " & """" & ModifyFilename(ucOSC.dgvosc.Rows(56).Cells(1).Value) & """" & " seek " & (ucOSC.dgvosc.Rows(6).Cells(1).Value + 3) * 2 & " af pan=stereo|c0=c1|c1=c1")
            Else
                CasparDevice.SendString("play " & .cmbchannel.Text & "-" & .cmblayervideo.Text & " " & """" & ModifyFilename(ucOSC.dgvosc.Rows(8).Cells(1).Value) & """" & " seek " & ucOSC.dgvosc.Rows(6).Cells(1).Value + 12 & " channel_layout R_to_Both")

            End If
        End With
    End Sub
    Private Sub cmdrefreshmediaforaudiotest_Click(sender As Object, e As EventArgs) Handles cmdrefreshmediaforaudiotest.Click
        On Error Resume Next
        frmmediaplayer.mediafilesforvisionmixer()
    End Sub

    Private Sub cmdaudiotest_Click(sender As Object, e As EventArgs) Handles cmdaudiotest.Click
        On Error Resume Next
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & cmbmediaforaudiotest.Text & """" & " CHANNEL_LAYOUT " & """" & cmbchannel_layout.Text & """" & " loop")

    End Sub

    Private Sub CmdMix_Click(sender As Object, e As EventArgs) Handles cmdMix.Click
        On Error Resume Next
        With frmmediaplayer
            If ServerVersion > 2.1 Then
                CasparDevice.SendString("play " & .cmbchannel.Text & "-" & .cmblayervideo.Text & " " & """" & ModifyFilename(ucOSC.dgvosc.Rows(56).Cells(1).Value) & """" & " seek " & (ucOSC.dgvosc.Rows(6).Cells(1).Value + 3) * 2 & " af pan=stereo|c0=0.7c0+0.7c1|c1=0.7c0+0.7c1")
            Else
                CasparDevice.SendString("play " & .cmbchannel.Text & "-" & .cmblayervideo.Text & " " & """" & ModifyFilename(ucOSC.dgvosc.Rows(8).Cells(1).Value) & """" & " seek " & ucOSC.dgvosc.Rows(6).Cells(1).Value + 12 & " channel_layout Mix")

            End If
        End With
    End Sub

    Private Sub CmdOnly_L_Click(sender As Object, e As EventArgs) Handles cmdOnly_L.Click
        On Error Resume Next
        With frmmediaplayer
            If ServerVersion > 2.1 Then
                CasparDevice.SendString("play " & .cmbchannel.Text & "-" & .cmblayervideo.Text & " " & """" & ModifyFilename(ucOSC.dgvosc.Rows(56).Cells(1).Value) & """" & " seek " & (ucOSC.dgvosc.Rows(6).Cells(1).Value + 3) * 2 & " af pan=stereo|c0=c0|c1=0c1")
            Else
                CasparDevice.SendString("play " & .cmbchannel.Text & "-" & .cmblayervideo.Text & " " & """" & ModifyFilename(ucOSC.dgvosc.Rows(8).Cells(1).Value) & """" & " seek " & ucOSC.dgvosc.Rows(6).Cells(1).Value + 12 & " channel_layout Only_L")

            End If
        End With
    End Sub

    Private Sub CmdOnly_R_Click(sender As Object, e As EventArgs) Handles cmdOnly_R.Click
        On Error Resume Next
        With frmmediaplayer
            If ServerVersion > 2.1 Then
                CasparDevice.SendString("play " & .cmbchannel.Text & "-" & .cmblayervideo.Text & " " & """" & ModifyFilename(ucOSC.dgvosc.Rows(56).Cells(1).Value) & """" & " seek " & (ucOSC.dgvosc.Rows(6).Cells(1).Value + 3) * 2 & " af pan=stereo|c0=0c0|c1=c1")
            Else
                CasparDevice.SendString("play " & .cmbchannel.Text & "-" & .cmblayervideo.Text & " " & """" & ModifyFilename(ucOSC.dgvosc.Rows(8).Cells(1).Value) & """" & " seek " & ucOSC.dgvosc.Rows(6).Cells(1).Value + 12 & " channel_layout Only_R")

            End If
        End With
    End Sub

    Private Sub TbAudioControl_Scroll(sender As Object, e As EventArgs) Handles tbAudioControl0.Scroll, tbAudioControl1.Scroll, tbAudioControl2.Scroll, tbAudioControl3.Scroll, tbAudioControl4.Scroll, tbAudioControl5.Scroll, tbAudioControl6.Scroll, tbAudioControl7.Scroll, cmbAudioControl0.SelectedIndexChanged, cmbAudioControl1.SelectedIndexChanged, cmbAudioControl2.SelectedIndexChanged, cmbAudioControl3.SelectedIndexChanged, cmbAudioControl4.SelectedIndexChanged, cmbAudioControl5.SelectedIndexChanged, cmbAudioControl6.SelectedIndexChanged, cmbAudioControl7.SelectedIndexChanged
        On Error Resume Next
        With frmmediaplayer
            If ServerVersion > 2.1 Then
                CasparDevice.SendString("play " & .cmbchannel.Text & "-" & .cmblayervideo.Text & " " & """" & ModifyFilename(ucOSC.dgvosc.Rows(56).Cells(1).Value) & """" & " seek " & (ucOSC.dgvosc.Rows(6).Cells(1).Value + 3) * 2 & " af pan=octagonal|c0=" & (tbAudioControl0.Value / 10) & cmbAudioControl0.Text & "|c1=" & (tbAudioControl1.Value / 10) & cmbAudioControl1.Text & "|c2=" & (tbAudioControl2.Value / 10) & cmbAudioControl2.Text & "|c3=" & (tbAudioControl3.Value / 10) & cmbAudioControl3.Text & "|c4=" & (tbAudioControl4.Value / 10) & cmbAudioControl4.Text & "|c5=" & (tbAudioControl5.Value / 10) & cmbAudioControl5.Text & "|c6=" & (tbAudioControl6.Value / 10) & cmbAudioControl6.Text & "|c7=" & (tbAudioControl7.Value / 10) & cmbAudioControl7.Text)

            End If
        End With
    End Sub


End Class
