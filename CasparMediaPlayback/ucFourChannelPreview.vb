Public Class ucFourChannelPreview
    Private Sub ucFourChannelPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UcnewPreview1.cmbippreview.Text = "229.0.0.1:5001"
        UcnewPreview2.cmbippreview.Text = "229.0.0.1:5002"
        UcnewPreview3.cmbippreview.Text = "229.0.0.1:5003"
        UcnewPreview4.cmbippreview.Text = "229.0.0.1:5004"
        UcnewPreview1.lblchannelnumber.Text = "Channel " & 1
        UcnewPreview2.lblchannelnumber.Text = "Channel " & 2
        UcnewPreview3.lblchannelnumber.Text = "Channel " & 3
        UcnewPreview4.lblchannelnumber.Text = "Channel " & 4
        UcnewPreview1.chnumber = 1
        UcnewPreview2.chnumber = 2
        UcnewPreview3.chnumber = 3
        UcnewPreview4.chnumber = 4
    End Sub
    Private Sub Cmdhide_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
End Class
