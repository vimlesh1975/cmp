﻿Public Class ucSlowMotion21
    Private Sub frmSlowMotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rs1 = New clsResizeableControlnew(UcnewSM21)
        Dim rs2 = New clsResizeableControlnew(UcnewSM22)
        Dim rs3 = New clsResizeableControlnew(UcSMRecorder1)
        Dim rs4 = New clsResizeableControlnew(UcSMRecorder2)
        Dim rs5 = New clsResizeableControlnew(UcClipGrid1)

        UcSMRecorder2.cmbChannel.Text = 3
        UcSMRecorder2.Label2.Text = "Channel 3"
        UcSMRecorder2.cmbcasparcgwindowtitlerecording.Text = "Screen consumer [3|PAL]"
        UcSMRecorder2.cmbChannelDestination.Text = 4
        UcSMRecorder2.cmbdecklinkforrecording.Text = 3
        UcnewSM22.cmbChannel.Text = 4
        UcnewSM22.Label2.Text = "Channel 4"
        UcnewSM22.cmbcasparcgwindowtitlerecording.Text = "Screen consumer [4|PAL]"
    End Sub

End Class