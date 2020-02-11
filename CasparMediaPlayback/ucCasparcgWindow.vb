Public Class ucCasparcgWindow
    Private Sub cmdplayfromin_Click(sender As Object, e As EventArgs) Handles cmdplayfromin.Click
        On Error Resume Next
        If ServerVersion > 2.1 Then
            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & 2 * (txtmarkin.Text))
        Else
            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & txtmarkin.Text)
        End If
    End Sub
    Private Sub cmdoutcasparcgwindow_Click(sender As Object, e As EventArgs) Handles cmdoutcasparcgwindow.Click
        outcasparcgwindown()
    End Sub

    Public Sub outcasparcgwindown()
        On Error Resume Next
        'This is important! If you have a child process on your form, it will terminate along with your form if you do not set its parent to Nothing
        If Not parentedProcess Is Nothing Then
            SetParent(parentedProcess.MainWindowHandle, Nothing)
        End If
    End Sub

    Private Sub chkaspectratio_CheckedChanged(sender As Object, e As EventArgs) Handles chkaspectratio.CheckedChanged
        On Error Resume Next
        If chkaspectratio.Checked Then
            Panel1.Size = New Size(600, 337)

            ProgressBar1.Size = New Size(11, 337)
            ProgressBar2.Size = New Size(11, 337)

            gbplayer.Location = New Point(44, 375)

            picaudiometer.Height = 345
        Else
            Panel1.Size = New Size(600, 450)

            ProgressBar1.Size = New Size(11, 450)
            ProgressBar2.Size = New Size(11, 450)

            gbplayer.Location = New Point(44, 488)

            picaudiometer.Height = 459
        End If
        SetProcessParent("casparcg")
    End Sub



    'This is the API that does all the hard work
    <Runtime.InteropServices.DllImport("user32.dll")>
    Public Shared Function SetParent(ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    End Function

    'This is the API used to maximize the window
    <Runtime.InteropServices.DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    Dim parentedProcess As Process

    Public Sub SetProcessParent(ByVal processName As String)
        On Error Resume Next

        Dim processes() As Process = Process.GetProcessesByName(processName)
        Dim iprocess As Integer
        If (processes.Length = 0) And (frmmediaplayer.BackColor = Color.Red) Then
            MessageBox.Show("Casparcg is not running")
        Else
            If Not parentedProcess Is Nothing Then
                SetParent(parentedProcess.MainWindowHandle, Nothing)
            End If
            For iprocess = 0 To processes.GetUpperBound(0)
                If processes(iprocess).MainWindowTitle = cmbcasparcgwindowtitle.Text Then Exit For
            Next
        End If
        parentedProcess = processes(iprocess)
        SetParent(parentedProcess.MainWindowHandle, Me.Panel1.Handle)
        SendMessage(parentedProcess.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)

    End Sub

    Private Sub cmdshowcasparcgwindow_Click(sender As Object, e As EventArgs) Handles cmdshowcasparcgwindow.Click
        On Error Resume Next
        SetProcessParent("casparcg")
    End Sub

    Private Sub cmdmarkout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmarkout.Click
        On Error Resume Next
        txtmarkout.Text = lblcurrentframe.Text 'TrackBarseek.Value
    End Sub


    Private Sub cmdgotoout_Click(sender As Object, e As EventArgs) Handles cmdgotoout.Click
        On Error Resume Next
        If ServerVersion > 2.1 Then

            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & (txtmarkout.Text) * 2)
        Else
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & txtmarkout.Text)
        End If
        iclippauseresume = 2
    End Sub


    Private Sub cmdgotoin_Click(sender As Object, e As EventArgs) Handles cmdgotoin.Click
        On Error Resume Next
        If ServerVersion > 2.1 Then
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & (txtmarkin.Text) * 2)

        Else
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & txtmarkin.Text)
        End If
        iclippauseresume = 2
    End Sub

    Private Sub cmdplaylast5seccasaprcgwindow_Click(sender As Object, e As EventArgs) Handles cmdplaylast5seccasaprcgwindow.Click
        On Error Resume Next
        If System.IO.Path.GetExtension(mediafullpath & ucPlaylist.dgv1.CurrentRow.Cells(0).Value.ToString) = ".txt" Then
            readsubclip(mediafullpath & ucPlaylist.dgv1.CurrentRow.Cells(0).Value.ToString)
            If ServerVersion > 2.1 Then
                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & 2 * (cliplength + clipseek - fps * 5) & " " & "length " & fps * 10)

            Else
                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & (cliplength + clipseek - fps * 5) & " " & "length " & fps * 5)

            End If
        Else
            If ServerVersion > 2.1 Then
                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & (lblmax.Text - fps * 5) * 2)

            Else
                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & (lblmax.Text - fps * 5))

            End If
        End If
    End Sub

    Private Sub TrackBarseek_Scroll(sender As Object, e As EventArgs) Handles TrackBarseek.Scroll
        'no code
    End Sub
    Private Sub tmrpreview_Tick(sender As Object, e As EventArgs) Handles tmrpreview.Tick
        On Error Resume Next
        If ServerVersion > 2.1 Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " seek " & Int(TrackBarseek.Value) * 2)

        Else
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & Int(TrackBarseek.Value))
        End If

    End Sub
    Private Sub TrackBarseek_MouseDown(sender As Object, e As MouseEventArgs) Handles TrackBarseek.MouseDown
        On Error Resume Next
        ucPlaylist.tmrduration.Enabled = False

        tmrpreview.Interval = Val(frmmediaplayer.ucTab1.UcPlaylistSetting1.txtscrubbingtimerinterval.Text)
        tmrpreview.Enabled = True

        iclippauseresume = 2
    End Sub

    Private Sub TrackBarseek_MouseUp(sender As Object, e As MouseEventArgs) Handles TrackBarseek.MouseUp
        On Error Resume Next

        If ServerVersion > 2.1 Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " seek " & Int(TrackBarseek.Value) * 2)

        Else
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & Int(TrackBarseek.Value))

        End If
        lblcurrentframe.Text = ucOSC.dgvosc.Rows(6).Cells(1).Value 'for Current Frame Number

        tmrpreview.Enabled = False

        ucPlaylist.tmrduration.Enabled = True
    End Sub
    Private Sub cmdmarkin_Click(sender As Object, e As EventArgs) Handles cmdmarkin.Click
        On Error Resume Next
        txtmarkin.Text = lblcurrentframe.Text 'TrackBarseek.Value
    End Sub

    Private Sub cmdgototccasparcgwindow_Click_1(sender As Object, e As EventArgs) Handles cmdgototccasparcgwindow.Click
        On Error Resume Next
        If ServerVersion > 2.1 Then
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & (HMSFtoF(txtgototccasparcgwindow.Text)) * 2)

        Else
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & HMSFtoF(txtgototccasparcgwindow.Text))

        End If
        iclippauseresume = 2
    End Sub

    Private Sub ucCasparcgWindow_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            SendString(NetStream, "Play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & Replace(Replace(path, ":", ":\"), "\", "/") & """" & vbCrLf)
        Next
    End Sub
    Private Sub ucCasparcgWindow_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub ucCasparcgWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub tbAudioConytrol_Scroll(sender As Object, e As EventArgs) Handles tbAudioConytrol.Scroll
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & " mastervolume " & tbAudioConytrol.Value / 100)

    End Sub
    Private Sub mdResetAudio_Click(sender As Object, e As EventArgs) Handles mdResetAudio.Click
        On Error Resume Next
        tbAudioConytrol.Value = 100
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & " mastervolume " & tbAudioConytrol.Value / 100)
    End Sub
    Private Sub gbcasparcgwindow_DoubleClick(sender As Object, e As EventArgs) Handles gbcasparcgwindow.DoubleClick
        Changebackcolor(sender)
    End Sub

    Private Sub cmdhidecasparcgWindow_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub CmdplayfroInToOut_Click(sender As Object, e As EventArgs) Handles cmdplayfroInToOut.Click
        On Error Resume Next


        If ServerVersion > 2.1 Then

            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & 2 * (txtmarkin.Text) & " length " & 2 * (txtmarkout.Text - txtmarkin.Text))

        Else
            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & txtmarkin.Text & " length " & txtmarkout.Text - txtmarkin.Text)

        End If
    End Sub
    Private Sub Cmdcueclip_Click(sender As Object, e As EventArgs) Handles cmdcueclip.Click
        On Error Resume Next
        ucPlaylist.cueclip()
    End Sub
    Private Sub Cmdbackoneframe_Click_1(sender As Object, e As EventArgs) Handles cmdbackoneframe.Click
        On Error Resume Next
        If Microsoft.VisualBasic.Strings.Right(lblplaying.Text, 3) = "mav" Then
            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)
        End If
        If Mid(frmmediaplayer.lblserverversion.Text, 1, 3) = "2.0" Then
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & (lblcurrentframe.Text - 1 - 2))
        ElseIf ServerVersion > 2.1 Then
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & (lblcurrentframe.Text - 1) * 2)

        Else
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & (lblcurrentframe.Text - 1 - 3))

        End If
        iclippauseresume = 2
    End Sub

    Private Sub CmdPlaySingleClip_Click_1(sender As Object, e As EventArgs) Handles cmdPlaySingleClip.Click
        On Error Resume Next
        ucPlaylist.PlaySingleClip()
    End Sub


    Private Sub Cmdforwardoneframe_Click_1(sender As Object, e As EventArgs) Handles cmdforwardoneframe.Click
        On Error Resume Next
        If Microsoft.VisualBasic.Strings.Right(lblplaying.Text, 3) = "mav" Then
            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)
        End If
        If Mid(frmmediaplayer.lblserverversion.Text, 1, 3) = "2.0" Then
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & (lblcurrentframe.Text + 1 - 2))
        ElseIf ServerVersion > 2.1 Then
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & (lblcurrentframe.Text + 1) * 2)

        Else
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & (lblcurrentframe.Text + 1 - 3))

        End If
        iclippauseresume = 2
    End Sub

    Private Sub Cmdresume_Click_1(sender As Object, e As EventArgs) Handles cmdresume.Click
        On Error Resume Next
        ucPlaylist.clipresume()

    End Sub

    Private Sub Cmdstop_Click(sender As Object, e As EventArgs) Handles cmdstop.Click
        On Error Resume Next
        ucPlaylist.clipstop()
    End Sub
    Private Sub Cmdcuenext_Click(sender As Object, e As EventArgs) Handles cmdcuenext.Click
        On Error Resume Next
        'if nothing is selected
        Dim bbb As Integer = 0
        For aaa = 0 To ucPlaylist.dgv1.RowCount - 1
            bbb = bbb + ucPlaylist.dgv1.Item("x", aaa).Value

        Next
        If bbb = 0 Then MsgBox("no clip is selected") : Exit Sub
        ucPlaylist.nextclip()
    End Sub

    Private Sub Cmdnextplay_Click_1(sender As Object, e As EventArgs) Handles cmdnextplay.Click
        On Error Resume Next
        ucPlaylist.nextclipplay()
    End Sub

    Private Sub CmdGoToEnd_Click(sender As Object, e As EventArgs) Handles cmdGoToEnd.Click
        On Error Resume Next
        If ServerVersion > 2.1 Then
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & ModifyFilename(lblplaying.Text) & " seek " & Val(lblmax.Text) * 2)
        Else
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & ModifyFilename(lblplaying.Text) & " seek " & Val(lblmax.Text))
        End If
    End Sub

    Private Sub CmdFastReverse_Click(sender As Object, e As EventArgs) Handles cmdFastReverse.Click
        On Error Resume Next
        If ServerVersion > 2.1 Then
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & (Int(TrackBarseek.Value) - (Val(txtforwardsecond.Text) * fps)) * 2)

        Else
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & Int(TrackBarseek.Value) - (Val(txtforwardsecond.Text) * fps))

        End If
        iclippauseresume = 2
    End Sub
    Private Sub CmdFastFarward_Click(sender As Object, e As EventArgs) Handles cmdFastFarward.Click
        On Error Resume Next
        If ServerVersion > 2.1 Then
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & (Int(TrackBarseek.Value) + (Val(txtforwardsecond.Text) * fps)) * 2)

        Else
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & Int(TrackBarseek.Value) + (Val(txtforwardsecond.Text) * fps))

        End If
        iclippauseresume = 2
    End Sub

    Private Sub tmraudio_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmraudio.Tick
        On Error Resume Next
        ProgressBar1.Value = (40 + (audiovalue1))
        ProgressBar2.Value = (40 + (audiovalue2))

        If ProgressBar1.Value > 38 Then
                ProgressBar1.Color = Color.Red
            ElseIf ProgressBar1.Value > 34 And ProgressBar1.Value < 38 Then
                ProgressBar1.Color = Color.Yellow
            ElseIf ProgressBar1.Value < 34 Then
                ProgressBar1.Color = Color.Green
            End If

        If ProgressBar2.Value > 38 Then
            ProgressBar2.Color = Color.Red
        ElseIf ProgressBar2.Value > 34 And ProgressBar2.Value < 38 Then
            ProgressBar2.Color = Color.Yellow
        ElseIf ProgressBar2.Value < 34 Then
            ProgressBar2.Color = Color.Green
        End If
    End Sub
End Class
