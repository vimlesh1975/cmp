
Imports System.Net
Public Class ucnewSM2
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        On Error Resume Next
        Process.Start("http://casparcg.com/builds/CasparCG%20Server/2.1.0/")
    End Sub
    Private Sub cmdspeed25sm2_Click(sender As Object, e As EventArgs) Handles cmdspeed25sm2.Click
        On Error Resume Next
        CasparDevice.SendString("play " & cmbChannel.Text & "-" & 1)
        CasparDevice.SendString("call " & cmbChannel.Text & "-" & 1 & " framerate speed .25")
    End Sub
    Private Sub nSlowMotionforwardsm2_ValueChanged(sender As Object, e As EventArgs) Handles nSlowMotionforwardsm2.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("play " & cmbChannel.Text & "-" & 1)
        CasparDevice.SendString("call " & cmbChannel.Text & "-" & 1 & " framerate speed " & nSlowMotionforwardsm2.Value)
    End Sub
    Private Sub cmdspeed100sm2_Click(sender As Object, e As EventArgs) Handles cmdspeed100sm2.Click
        On Error Resume Next
        CasparDevice.SendString("play " & cmbChannel.Text & "-" & 1)
        CasparDevice.SendString("call " & cmbChannel.Text & "-" & 1 & " framerate speed 1")
    End Sub
    Private Sub cmdspeed75sm2_Click(sender As Object, e As EventArgs) Handles cmdspeed75sm2.Click
        On Error Resume Next
        CasparDevice.SendString("play " & cmbChannel.Text & "-" & 1)
        CasparDevice.SendString("call " & cmbChannel.Text & "-" & 1 & " framerate speed .75")
    End Sub
    Private Sub cmdspeed50sm2_Click(sender As Object, e As EventArgs) Handles cmdspeed50sm2.Click
        On Error Resume Next
        CasparDevice.SendString("play " & cmbChannel.Text & "-" & 1)
        CasparDevice.SendString("call " & cmbChannel.Text & "-" & 1 & " framerate speed .5")

    End Sub
    Private Sub nSm2_ValueChanged(sender As Object, e As EventArgs) Handles nSm2.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("play " & cmbChannel.Text & "-" & 1)
        CasparDevice.SendString("call " & cmbChannel.Text & "-" & 1 & " framerate speed " & nSm2.Value)

    End Sub
    Private Sub cmdspeed0sm2_Click(sender As Object, e As EventArgs) Handles cmdspeed0sm2.Click
        On Error Resume Next
        CasparDevice.SendString("play " & cmbChannel.Text & "-" & 1)
        CasparDevice.SendString("call " & cmbChannel.Text & "-" & 1 & " framerate speed 0")
    End Sub

    Private Sub cmdhidesm2_Click(sender As Object, e As EventArgs) Handles cmdhidesm2.Click
        Me.Hide()
    End Sub

    Private Sub cmdshowcasparcgwindowrecording_Click(sender As Object, e As EventArgs) Handles cmdshowcasparcgwindowrecording.Click
        On Error Resume Next
        SetProcessParentrecorder("casparcg", cmbcasparcgwindowtitlerecording, pnlrecording)
    End Sub
    Private Sub cmdoutcasparcgwindowrecording_Click(sender As Object, e As EventArgs) Handles cmdoutcasparcgwindowrecording.Click
        On Error Resume Next
        If Not parentedProcess1 Is Nothing Then
            SetParent(parentedProcess1.MainWindowHandle, Nothing)
        End If
    End Sub
    Public parentedProcess1 As Process
    Public Sub SetProcessParentrecorder(ByVal processName As String, ByVal cmb As ComboBox, ByVal pnl As Panel)
        On Error Resume Next
        'Retrieve an array of running processes with the given name
        Dim processes() As Process = Process.GetProcessesByName(processName)
        Dim iprocess As Integer

        For iprocess = 0 To processes.GetUpperBound(0)
            If processes(iprocess).MainWindowTitle = cmb.Text Then Exit For
        Next
        parentedProcess1 = processes(iprocess)
        SetParent(parentedProcess1.MainWindowHandle, pnl.Handle)
        SendMessage(parentedProcess1.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)

    End Sub

    Private Sub TrackBarseek_Scroll(sender As Object, e As EventArgs) Handles TrackBarseek.Scroll
        'no code
    End Sub
    Private Sub tmrpreview_Tick(sender As Object, e As EventArgs) Handles tmrpreview.Tick
        On Error Resume Next

        CasparDevice.SendString("load " & cmbChannel.Text & "-" & 1 & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & Int(TrackBarseek.Value))
    End Sub
    Private Sub TrackBarseek_MouseDown(sender As Object, e As MouseEventArgs) Handles TrackBarseek.MouseDown
        On Error Resume Next
        tmrpreview.Interval = 100 '
        tmrpreview.Enabled = True
    End Sub

    Private Sub TrackBarseek_MouseUp(sender As Object, e As MouseEventArgs) Handles TrackBarseek.MouseUp
        On Error Resume Next

        CasparDevice.SendString("load " & cmbChannel.Text & "-" & 1 & " " & """" & ModifyFilename(lblplaying.Text) & """" + " seek " & Int(TrackBarseek.Value))
        lblcurrentframe.Text = TrackBarseek.Value '
        tmrpreview.Enabled = False

        ucPlaylist.tmrduration.Enabled = True
    End Sub

    Private Sub ucnewSM2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub cmbChannel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChannel.SelectedIndexChanged
        Label2.Text = "Channel " & cmbChannel.Text
        cmbcasparcgwindowtitlerecording.Text = "Screen consumer [" & cmbChannel.Text & "|PAL]"
    End Sub

    Private Sub ucnewSM2_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
            For Each path In files
                lblmax.Text = HMStoF(getdurationofclip(path))
                path = Replace(Replace(path, ":", ":\"), "\", "/")

                CasparDevice.SendString("load " & cmbChannel.Text & "-" & 1 & " " & """" & path & """")
                lblplaying.Text = path
                TrackBarseek.Maximum = lblmax.Text
                TrackBarseek.Value = 0
            Next
        End If
        If e.Data.GetDataPresent(DataFormats.Text) Then
            Dim filename As String = e.Data.GetData(DataFormats.Text).ToString
            lblmax.Text = HMStoF(getdurationofclip(filename))
            filename = Replace(Replace(filename, ":", ":\"), "\", "/")

            CasparDevice.SendString("load " & cmbChannel.Text & "-" & 1 & " " & """" & filename & """")
            lblplaying.Text = filename
            TrackBarseek.Maximum = lblmax.Text
            TrackBarseek.Value = 0
        End If
    End Sub
    Private Sub ucnewSM2_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Copy
        End If

    End Sub
    Private Sub cmdCustomSpeed1_Click(sender As Object, e As EventArgs) Handles cmdCustomSpeed1.Click
        On Error Resume Next
        CasparDevice.SendString("play " & cmbChannel.Text & "-" & 1)
        CasparDevice.SendString("call " & cmbChannel.Text & "-" & 1 & " framerate speed " & txtCustomeSpped1.Text)
    End Sub

    Private Sub cmdCustomSpeed2_Click(sender As Object, e As EventArgs) Handles cmdCustomSpeed2.Click
        On Error Resume Next
        CasparDevice.SendString("play " & cmbChannel.Text & "-" & 1)
        CasparDevice.SendString("call " & cmbChannel.Text & "-" & 1 & " framerate speed " & txtCustomeSpped2.Text)

    End Sub
End Class
