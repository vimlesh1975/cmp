Public Class UcCaption
    Private Sub UcCaption_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub event1(sender As Object, e As EventArgs) Handles Me.LocationChanged, Me.Resize
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & Me.Label1.Text & " fill " & fillcommandCaption(sender)(0))
        Label2.Size = New Size(Me.Width - 2, Me.Height - 2)
        If elementmove = False Then
            Form1.UcMixernew1.cmbvideolayerformixer.Text = Me.Label1.Text
        End If

        'Form1.UcMixernew1.nfillx.Value = fillcommandCaption(sender)(1)
        'Form1.UcMixernew1.nfilly.Value = fillcommandCaption(sender)(2)
        'Form1.UcMixernew1.nfillwidth.Value = fillcommandCaption(sender)(3)
        'Form1.UcMixernew1.nfillheight.Value = fillcommandCaption(sender)(4)

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        On Error Resume Next
        CasparDevice.SendString("clear " & g_int_ChannelNumber & "-" & Me.Label1.Text)
        Me.Dispose()
    End Sub

    Private Sub UcCaption_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        elementmove = False
    End Sub
End Class
