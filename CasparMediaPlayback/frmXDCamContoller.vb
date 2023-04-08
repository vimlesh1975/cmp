Public Class frmXDCamContoller
    Private Sub frmXDCamContoller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UcXdcamController2.txtipaddress.Text = "http://192.168.1.134/webservice/"
    End Sub
End Class