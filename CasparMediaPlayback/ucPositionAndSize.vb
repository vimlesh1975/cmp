Public Class ucPositionAndSize
    Private Sub cmdfill_Click(sender As Object, e As EventArgs) Handles cmdfill.Click
        On Error Resume Next
        mixerfillreset()
    End Sub
    Sub mixerfillreset()
        On Error Resume Next
        nfillx.Value = 0
        nfilly.Value = 0
        nfillwidth.Value = 1
        nfillheight.Value = 1
    End Sub

    Private Sub nfillx_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nfillx.ValueChanged, nfilly.ValueChanged, nfillwidth.ValueChanged, nfillheight.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbVideoLayerforPositionAndSize.Text & " fill " & Replace(nfillx.Value, ",", ".") & " " & Replace(nfilly.Value, ",", ".") & " " & Replace(nfillwidth.Value, ",", ".") & " " & Replace(nfillheight.Value, ",", "."))
    End Sub
    Private Sub cmdhidegboscmonitor_Click(sender As Object, e As EventArgs) Handles cmdhidegboscmonitor.Click
        Parent.Controls.Remove(Me)
    End Sub
End Class
