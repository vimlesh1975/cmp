Public Class uc4ChannelRecorderAndTrimmer
    Private Sub Uc4ChannelRecorderAndTrimmer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With UcnewRecorder1
            .chnumber = 1
            .oscportnumber = 6250 + .chnumber
            .cmbdecklinkforrecording.Text = .chnumber
            .txtfilename.Text = "test" & .chnumber
            .Label2.Text = "Channel " & .chnumber
            .cmbcasparcgwindowtitlerecording.Text = "Screen consumer [" & .chnumber & "|PAL]"
            .oscstartandregister(.chnumber, .oscportnumber)
        End With
        Dim rs1 = New clsResizeableControlnew(UcnewRecorder1)

        With UcnewRecorder2
            .chnumber = 2
            .oscportnumber = 6250 + .chnumber
            .cmbdecklinkforrecording.Text = .chnumber
            .txtfilename.Text = "test" & .chnumber
            .Label2.Text = "Channel " & .chnumber
            .cmbcasparcgwindowtitlerecording.Text = "Screen consumer [" & .chnumber & "|PAL]"
            .oscstartandregister(.chnumber, .oscportnumber)
        End With
        Dim rs2 = New clsResizeableControlnew(UcnewRecorder2)

        With UcnewRecorder3
            .chnumber = 3
            .oscportnumber = 6250 + .chnumber
            .cmbdecklinkforrecording.Text = .chnumber
            .txtfilename.Text = "test" & .chnumber
            .Label2.Text = "Channel " & .chnumber
            .cmbcasparcgwindowtitlerecording.Text = "Screen consumer [" & .chnumber & "|PAL]"
            .oscstartandregister(.chnumber, .oscportnumber)
        End With
        Dim rs3 = New clsResizeableControlnew(UcnewRecorder3)

        With UcnewRecorder4
            .chnumber = 4
            .oscportnumber = 6250 + .chnumber
            .cmbdecklinkforrecording.Text = .chnumber
            .txtfilename.Text = "test" & .chnumber
            .Label2.Text = "Channel " & .chnumber
            .cmbcasparcgwindowtitlerecording.Text = "Screen consumer [" & .chnumber & "|PAL]"
            .oscstartandregister(.chnumber, .oscportnumber)
        End With
        Dim rs4 = New clsResizeableControlnew(UcnewRecorder4)
        Dim rs5 = New clsResizeableControlnew(UcSystemAudio1)
        Dim rs6 = New clsResizeableControlnew(UcnewTrimmer11)
    End Sub
    Private Sub Cmdhide_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        If Not parentedProcess Is Nothing Then
            SetParent(UcnewRecorder1.parentedProcess1.MainWindowHandle, Nothing)
            SetParent(UcnewRecorder2.parentedProcess1.MainWindowHandle, Nothing)
            SetParent(UcnewRecorder3.parentedProcess1.MainWindowHandle, Nothing)
            SetParent(UcnewRecorder4.parentedProcess1.MainWindowHandle, Nothing)
        End If
        UcnewRecorder1.stoposcserver()
        UcnewRecorder2.stoposcserver()
        UcnewRecorder3.stoposcserver()
        UcnewRecorder4.stoposcserver()
        'Me.Hide()
        Me.Parent.Controls("uc4ChannelRecorderAndTrimmer1").Dispose()
    End Sub
End Class
