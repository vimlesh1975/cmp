Imports MasaSam.Forms.Controls
Public Class ucPlayFromAnyWhere
    Dim WithEvents aa As MasaSam.Forms.Controls.FileSystemTree
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        addcontrol()
    End Sub
    Sub addcontrol()
        On Error Resume Next
        aa = New MasaSam.Forms.Controls.FileSystemTree
        aa.Size = New Size(600, 450)
        aa.Location = New Point(10, 100)
        Me.Controls.Add(aa)
        aa.Show()
    End Sub
    Private Sub aa_FileSelected(sender As Object, e As FileInfoEventArgs) Handles aa.FileSelected
        On Error Resume Next
        lblFileName.Text = Replace(Replace(aa.GetSelectedFiles(0).FullName, ":", ":\"), "\", "/")
    End Sub
    Private Sub cmdPlayFromAnywhere_Click(sender As Object, e As EventArgs) Handles cmdPlayFromAnywhere.Click
        On Error Resume Next
        If chkloop.Checked = False Then
            'SendString(NetStream, "Play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & lblFileName.Text & """" & vbCrLf)
            CasparDevice.SendString("Play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & lblFileName.Text & """")
        Else
            'SendString(NetStream, "Play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & lblFileName.Text & """" & " loop" & vbCrLf)
            CasparDevice.SendString("Play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & lblFileName.Text & """" & " loop")
        End If
    End Sub
    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        On Error Resume Next
        Me.Controls.Remove(aa)
        addcontrol()
    End Sub

    Private Sub cmdCue_Click(sender As Object, e As EventArgs) Handles cmdCue.Click
        On Error Resume Next
        'SendString(NetStream, "load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & lblFileName.Text & """" & vbCrLf)
        CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & lblFileName.Text & """")
    End Sub

    Private Sub cmdOpenFromAnyWhere_Click(sender As Object, e As EventArgs) Handles cmdOpenFromAnyWhere.Click
        On Error Resume Next
        Dim aa As New OpenFileDialog
        If aa.ShowDialog = DialogResult.OK Then
            lblFileName.Text = Replace(Replace(aa.FileName, ":", ":\"), "\", "/")
        End If
    End Sub

    Private Sub cmdfileinfo_Click(sender As Object, e As EventArgs) Handles cmdfileinfo.Click
        On Error Resume Next
        showfileinformation(Replace(lblFileName.Text, "//", "/"))
    End Sub
End Class
