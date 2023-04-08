Public Class frmROI
    Private Sub CmdSetROI_Click(sender As Object, e As EventArgs) Handles cmdSetROI.Click
        On Error Resume Next
        ucStreamPlayer.nx.Value = Me.Location.X
        ucStreamPlayer.ny.Value = Me.Location.Y
        ucStreamPlayer.nw.Value = Me.Width
        ucStreamPlayer.nh.Value = Me.Height
        ucStreamPlayer.sendcommandUscreenCommand()
        Me.Close()
    End Sub

    Private Sub FrmROI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        'AllowTransparency = True
        'TransparencyKey = Color.Red


        Location = New Point(ucStreamPlayer.nx.Value, ucStreamPlayer.ny.Value)
        Size = New Size(ucStreamPlayer.nw.Value, ucStreamPlayer.nh.Value)


    End Sub
End Class