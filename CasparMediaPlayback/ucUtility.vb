
Public Class ucUtility

    Sub initialiseutilitydata()
        On Error Resume Next
        dgvutility.Rows.Add(7)
        dgvutility.Rows(0).Cells(0).Value = "Media"
        dgvutility.Rows(1).Cells(0).Value = "Template"
        dgvutility.Rows(2).Cells(0).Value = "Thumbnail"
        dgvutility.Rows(3).Cells(0).Value = "Server"
        dgvutility.Rows(4).Cells(0).Value = "Log"
        dgvutility.Rows(5).Cells(0).Value = "Data"
        dgvutility.Rows(6).Cells(0).Value = "As Run Log"
        dgvutility.Rows(7).Cells(0).Value = "Font"

        dgvutility.Rows(0).Cells(1).Value = mediafullpath
        dgvutility.Rows(1).Cells(1).Value = templatefullpath
        dgvutility.Rows(2).Cells(1).Value = thumbnailsfullpath
        dgvutility.Rows(3).Cells(1).Value = initialpath
        dgvutility.Rows(4).Cells(1).Value = logpath
        dgvutility.Rows(5).Cells(1).Value = datapath
        dgvutility.Rows(6).Cells(1).Value = "C:\casparcg\mydata\asrunlog"
        dgvutility.Rows(7).Cells(1).Value = fontpath

    End Sub

    Private Sub ucUtility_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialiseutilitydata()
    End Sub
    Private Sub dgvutility_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvutility.CellContentClick
        On Error Resume Next
        If dgvutility.Columns(e.ColumnIndex).Name = "Open" Then
            Process.Start("explorer.exe", Replace(dgvutility.CurrentRow.Cells(1).Value, "/", "\"))
        End If
        If e.ColumnIndex = 3 And e.RowIndex = 6 Then
            Process.Start("notepad.exe", "c:/casparcg/mydata/asrunlog/asrunlog_" & DateTime.Now.ToString("ddMMyy") & ".txt")
        End If
        If e.ColumnIndex = 3 And e.RowIndex = 4 Then
            Process.Start("notepad.exe", Replace(dgvutility.CurrentRow.Cells(1).Value, "/", "\") & "caspar_" & DateTime.Now.ToString("yyyy-MM-dd") & ".log")
        End If
    End Sub

    Private Sub gbutility_Enter(sender As Object, e As EventArgs) Handles gbutility.Enter

    End Sub
End Class
