Public Class ucOSD
    Dim selectedcolor As String = "yellow"
    Private Sub cmdStartDrawing_Click(sender As Object, e As EventArgs) Handles cmdStartDrawing.Click
        On Error Resume Next
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayerOSD.Text & " [HTML] " & """" & txOSDlTemplate.Text & """")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerOSD.Text & " color(" & selectedcolor & ")")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerOSD.Text & " sety(" & nBrushWidth.Value & ")")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerOSD.Text & " resizecanvas()")

    End Sub
    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerOSD.Text & " erase()")
    End Sub
    Private Sub myevent(sender As Object, e As EventArgs) Handles rdoBlack.CheckedChanged, rdoBlue.CheckedChanged, rdoGreen.CheckedChanged, rdoOrange.CheckedChanged, rdoRed.CheckedChanged, rdoWhite.CheckedChanged, rdoYellow.CheckedChanged, rdoNone.CheckedChanged
        If rdoBlack.Checked Then selectedcolor = "black"
        If rdoBlue.Checked Then selectedcolor = "blue"
        If rdoGreen.Checked Then selectedcolor = "green"
        If rdoOrange.Checked Then selectedcolor = "orange"
        If rdoRed.Checked Then selectedcolor = "red"
        If rdoWhite.Checked Then selectedcolor = "white"
        If rdoYellow.Checked Then selectedcolor = "yellow"
        If rdoNone.Checked Then selectedcolor = "none"
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerOSD.Text & " color(" & selectedcolor & ")")

    End Sub

    Private Sub cmdhideOSD_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Private Sub cmdStopDrawing_Click(sender As Object, e As EventArgs) Handles cmdStopDrawing.Click
        On Error Resume Next
        CasparDevice.SendString("stop " & g_int_ChannelNumber & "-" & cmblayerOSD.Text)
    End Sub
    Private Sub nBrushWidth_ValueChanged(sender As Object, e As EventArgs) Handles nBrushWidth.ValueChanged

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerOSD.Text & " sety(" & nBrushWidth.Value & ")")

    End Sub
End Class
