Public Class ucCreatePng
    Private Sub cmdaddimage_Click(sender As Object, e As EventArgs) Handles cmdaddimage.Click
        On Error Resume Next

        If chkaaddimagetoplaylist.Checked Then
            With ucPlaylist
                .dgv1.Rows.Insert(.dgv1.CurrentRow.Index + 1)
                .dgv1.CurrentCell = .dgv1.Rows(.dgv1.CurrentRow.Index + 1).Cells("File_Name")
                .dgv1.Rows(.dgv1.CurrentRow.Index).Cells("File_Name").Value = txtaddimagename.Text & ".png"
                .dgv1.Rows(.dgv1.CurrentRow.Index).Cells("x").Value = 1
                .dgv1.Rows(.dgv1.CurrentRow.Index).Cells("Transition").Value = "CUT"
                .dgv1.Rows(.dgv1.CurrentRow.Index).Cells("T_Duration").Value = 10
            End With

        End If
        CasparDevice.SendString("add " & g_int_ChannelNumber & " image " & """" & txtaddimagename.Text & """")
        iaddimage = iaddimage + 1
        If Split(txtaddimagename.Text, "_")(1) = "" Then iaddimage = 1
        txtaddimagename.Text = Split(txtaddimagename.Text, "_")(0) & "_" & iaddimage
    End Sub

    Private Sub ucCreatePng_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
