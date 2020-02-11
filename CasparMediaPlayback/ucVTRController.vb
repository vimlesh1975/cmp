Imports System.IO
Public Class ucVTRController

    Dim lengthfilename As Integer
    Dim filename As String
    Dim irecorder As Integer = 0
    Dim startingtimeofrecording As DateTime
    Private Sub cmdopenportsvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdopenportsvtr.Click
        On Error Resume Next
        openport()
    End Sub
    Sub openport()
        On Error Resume Next
        If sp.IsOpen = False Then
            sp.PortName = cmbportsvtr.Text
            sp.Encoding = System.Text.Encoding.Default
            sp.Open()
        End If
        tmrgettc.Enabled = True
    End Sub
    Private Sub cmdplayvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(CInt("&H20")) & Chr(1) & Chr(33))
    End Sub

    Private Sub cmdstopvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(0) & Chr(32))
    End Sub

    Private Sub cmdrewindvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrewindvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(32) & Chr(64))
    End Sub
    Private Sub cmdffvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdffvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(16) & Chr(48))
    End Sub

    Private Sub cmdinpointvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdinpointvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(64) & Chr(16) & Chr(80))

        txtinpointvtr.Text = lbltimecode.Text
    End Sub

    Private Sub cmdoutpointvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdoutpointvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(64) & Chr(17) & Chr(81))

        txtoutpointvtr.Text = lbltimecode.Text
    End Sub

    Private Sub cmdPreRollvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreRollvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(48) & Chr(80))
    End Sub

    Private Sub cmdejectvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdejectvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(15) & Chr(47))
    End Sub

    Private Sub cmdstandbyonvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstandbyonvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(5) & Chr(37))
    End Sub

    Private Sub cmdstandbyoffvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstandbyoffvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(4) & Chr(36))
    End Sub

    Private Sub cmdcuevtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcuevtr.Click
        On Error Resume Next

        Dim aa As Array = Split(dgvcuepointsvtr.CurrentRow.Cells(0).Value, ":")
        Dim bb As String = Chr(36) & Chr(49) & Chr(System.Convert.ToInt32(aa(3), 16)) & Chr(System.Convert.ToInt32(aa(2), 16)) & Chr(System.Convert.ToInt32(aa(1), 16)) & Chr(System.Convert.ToInt32(aa(0), 16)) & _
         Chr(36 + 49 + System.Convert.ToInt32(aa(3), 16) + System.Convert.ToInt32(aa(2), 16) + System.Convert.ToInt32(aa(1), 16) + System.Convert.ToInt32(aa(0), 16))
        sp.WriteLine(bb)
    End Sub

    Private Sub cmdmarkvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmarkvtr.Click
        On Error Resume Next
        dgvcuepointsvtr.CurrentRow.Cells(0).Value = lbltimecode.Text
        dgvcuepointsvtr.Rows.Add()
        dgvcuepointsvtr.CurrentCell = dgvcuepointsvtr.CurrentRow.Cells(1)

    End Sub
    Sub bbb() Handles HScrollBarjogvtr.MouseLeave, HScrollBarvtr.MouseLeave, HScrollBarshuttlevtr.MouseLeave
        On Error Resume Next
        HScrollBarjogvtr.Value = 0
        HScrollBarvtr.Value = 0
        HScrollBarshuttlevtr.Value = 0
    End Sub

    Private Sub HScrollBarshuttlevtr_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HScrollBarshuttlevtr.ValueChanged
        On Error Resume Next
        Dim aa As Integer = HScrollBarshuttlevtr.Value
        If aa > 0 Then
            sp.WriteLine(Chr(33) & Chr(19) & Chr(aa) & Chr(33 + 19 + aa))
        Else
            sp.WriteLine(Chr(33) & Chr(35) & Chr(Math.Abs(aa)) & Chr(33 + 35 + Math.Abs(aa)))
        End If
    End Sub

    Private Sub HScrollBarvtr_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HScrollBarvtr.ValueChanged
        On Error Resume Next
        Dim aa As Integer = HScrollBarvtr.Value
        If aa > 0 Then
            sp.WriteLine(Chr(33) & Chr(18) & Chr(aa) & Chr(33 + 18 + aa))
        Else
            sp.WriteLine(Chr(33) & Chr(34) & Chr(Math.Abs(aa)) & Chr(33 + 34 + Math.Abs(aa)))
        End If
    End Sub

    Private Sub HScrollBarjogvtr_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HScrollBarjogvtr.ValueChanged
        On Error Resume Next
        Dim aa As Integer = HScrollBarjogvtr.Value
        If aa > 0 Then
            sp.WriteLine(Chr(33) & Chr(17) & Chr(aa) & Chr(33 + 17 + aa))
        Else
            sp.WriteLine(Chr(33) & Chr(33) & Chr(Math.Abs(aa)) & Chr(33 + 33 + Math.Abs(aa)))
        End If
    End Sub

    Private Sub cmdrecordvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrecordvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(2) & Chr(32 + 2))
    End Sub

    Private Sub cmdautoeditvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdautoeditvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(66) & Chr(32 + 66))
    End Sub

    Private Sub cmdpreviewvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpreviewvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(64) & Chr(32 + 64))
    End Sub

    Private Sub cmdReviewvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReviewvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(65) & Chr(32 + 65))
    End Sub

    Private Sub cmdplusoneframevtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplusoneframevtr.Click
        On Error Resume Next

        Dim aa As Array = Split(lbltimecode.Text, ":")
        Dim bb As String = Chr(36) & Chr(49) & Chr(System.Convert.ToInt32(aa(3), 16) + 1) & Chr(System.Convert.ToInt32(aa(2), 16)) & Chr(System.Convert.ToInt32(aa(1), 16)) & Chr(System.Convert.ToInt32(aa(0), 16)) &
         Chr(36 + 49 + System.Convert.ToInt32(aa(3), 16) + 1 + System.Convert.ToInt32(aa(2), 16) + System.Convert.ToInt32(aa(1), 16) + System.Convert.ToInt32(aa(0), 16))
        sp.WriteLine(bb)
    End Sub

    Private Sub cmdminusoneframevtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdminusoneframevtr.Click
        On Error Resume Next

        Dim aa As Array = Split(lbltimecode.Text, ":")

        Dim bb As String = Chr(36) & Chr(49) & Chr(System.Convert.ToInt32(aa(3) - 1, 16)) & Chr(System.Convert.ToInt32(aa(2), 16)) & Chr(System.Convert.ToInt32(aa(1), 16)) & Chr(System.Convert.ToInt32(aa(0), 16)) &
         Chr(36 + 49 + System.Convert.ToInt32(aa(3) - 1, 16) + System.Convert.ToInt32(aa(2), 16) + System.Convert.ToInt32(aa(1), 16) + System.Convert.ToInt32(aa(0), 16))
        sp.WriteLine(bb)
    End Sub

    Private Sub cmdassembleonvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdassembleonvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(66) & Chr(48) & Chr(32) & Chr(0) & Chr(66 + 48 + 32 + 0))
    End Sub

    Private Sub cmdassembleoffvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdassembleoffvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(66) & Chr(48) & Chr(0) & Chr(0) & Chr(66 + 48 + 0 + 0))
    End Sub

    Private Sub cmdstartsr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        tmrsr.Enabled = True

    End Sub
    Sub GetSerialPortNames()
        On Error Resume Next
        cmbportsvtr.Items.AddRange(IO.Ports.SerialPort.GetPortNames())
    End Sub

    Private Sub initialisedatafordgvcuepointsvtr()
        dgvcuepointsvtr.Rows.Add(10)
        dgvcuepointsvtr.Rows(0).Cells(0).Value = "00:00:00:00"
        dgvcuepointsvtr.Rows(1).Cells(0).Value = "00:01:00:00"
        dgvcuepointsvtr.Rows(2).Cells(0).Value = "00:02:00:00"
        dgvcuepointsvtr.Rows(3).Cells(0).Value = "00:03:00:00"
        dgvcuepointsvtr.Rows(4).Cells(0).Value = "00:04:00:00"
        dgvcuepointsvtr.Rows(5).Cells(0).Value = "00:05:00:00"
        dgvcuepointsvtr.Rows(6).Cells(0).Value = "00:06:00:00"
        dgvcuepointsvtr.Rows(7).Cells(0).Value = "00:07:00:00"
        dgvcuepointsvtr.Rows(8).Cells(0).Value = "00:08:00:00"
        dgvcuepointsvtr.Rows(9).Cells(0).Value = "00:09:00:00"
        dgvcuepointsvtr.CurrentCell = dgvcuepointsvtr.Rows(2).Cells(0)
    End Sub
    Private Sub tmrgettc_Tick(sender As Object, e As EventArgs) Handles tmrgettc.Tick
        On Error Resume Next
        sp.WriteLine(Chr(97) & Chr(12) & Chr(1) & Chr(110))
        Threading.Thread.Sleep(15)

        Dim timecode As String = ""
        Dim bb As String = sp.ReadExisting

        Dim str As String = ""
        For ivtr = 3 To Len(bb) - 1
            str = Mid(bb, ivtr, 1)
            Dim byteArray() As Byte
            byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(str)
            timecode = Val(Hex(byteArray(0))).ToString("00") & ":" & timecode

        Next

        lbltimecode.Text = Mid(timecode, 13, 11)
    End Sub

    Private Sub bbb(sender As Object, e As EventArgs) Handles HScrollBarvtr.MouseLeave, HScrollBarshuttlevtr.MouseLeave, HScrollBarjogvtr.MouseLeave

    End Sub

    Private Sub ucRecorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSerialPortNames()
        dgvcuepointsvtr.Rows.Add(4)
        dgvcuepointsvtr.Rows(0).Cells(0).Value = "00:03:00:00"
        dgvcuepointsvtr.Rows(0).Cells(1).Value = "00:04:00:00"

        dgvcuepointsvtr.Rows(1).Cells(0).Value = "00:05:00:00"
        dgvcuepointsvtr.Rows(1).Cells(1).Value = "00:06:00:00"

        dgvcuepointsvtr.Rows(2).Cells(0).Value = "00:07:00:00"
        dgvcuepointsvtr.Rows(2).Cells(1).Value = "00:08:00:00"

        dgvcuepointsvtr.Rows(3).Cells(0).Value = "00:09:00:00"
        dgvcuepointsvtr.Rows(3).Cells(1).Value = "00:10:00:00"
    End Sub

    Private Sub HScrollBarjogvtr_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBarjogvtr.Scroll

    End Sub

    Private Sub cmdCuetoINPoint_Click(sender As Object, e As EventArgs) Handles cmdCuetoINPoint.Click
        On Error Resume Next

        Dim aa As Array = Split(txtinpointvtr.Text, ":")
        Dim bb As String = Chr(36) & Chr(49) & Chr(System.Convert.ToInt32(aa(3), 16)) & Chr(System.Convert.ToInt32(aa(2), 16)) & Chr(System.Convert.ToInt32(aa(1), 16)) & Chr(System.Convert.ToInt32(aa(0), 16)) & _
         Chr(36 + 49 + System.Convert.ToInt32(aa(3), 16) + System.Convert.ToInt32(aa(2), 16) + System.Convert.ToInt32(aa(1), 16) + System.Convert.ToInt32(aa(0), 16))
        sp.WriteLine(bb)
    End Sub

    Private Sub cmdCueToOutPoint_Click(sender As Object, e As EventArgs) Handles cmdCueToOutPoint.Click
        On Error Resume Next

        Dim aa As Array = Split(txtoutpointvtr.Text, ":")
        Dim bb As String = Chr(36) & Chr(49) & Chr(System.Convert.ToInt32(aa(3), 16)) & Chr(System.Convert.ToInt32(aa(2), 16)) & Chr(System.Convert.ToInt32(aa(1), 16)) & Chr(System.Convert.ToInt32(aa(0), 16)) & _
         Chr(36 + 49 + System.Convert.ToInt32(aa(3), 16) + System.Convert.ToInt32(aa(2), 16) + System.Convert.ToInt32(aa(1), 16) + System.Convert.ToInt32(aa(0), 16))
        sp.WriteLine(bb)
    End Sub

    Private Sub cmdmarkvtrout_Click(sender As Object, e As EventArgs) Handles cmdmarkvtrout.Click
        On Error Resume Next
        dgvcuepointsvtr.CurrentRow.Cells(1).Value = lbltimecode.Text
        dgvcuepointsvtr.Rows.Add()
        dgvcuepointsvtr.CurrentCell = dgvcuepointsvtr.Rows(dgvcuepointsvtr.CurrentRow.Index + 1).Cells(0)
    End Sub

    Private Sub cmdcuevtrout_Click(sender As Object, e As EventArgs) Handles cmdcuevtrout.Click
        On Error Resume Next

        Dim aa As Array = Split(dgvcuepointsvtr.CurrentRow.Cells(1).Value, ":")
        Dim bb As String = Chr(36) & Chr(49) & Chr(System.Convert.ToInt32(aa(3), 16)) & Chr(System.Convert.ToInt32(aa(2), 16)) & Chr(System.Convert.ToInt32(aa(1), 16)) & Chr(System.Convert.ToInt32(aa(0), 16)) &
         Chr(36 + 49 + System.Convert.ToInt32(aa(3), 16) + System.Convert.ToInt32(aa(2), 16) + System.Convert.ToInt32(aa(1), 16) + System.Convert.ToInt32(aa(0), 16))
        sp.WriteLine(bb)
    End Sub

    Private Sub cmdputinvtr_Click(sender As Object, e As EventArgs) Handles cmdputinvtr.Click
        On Error Resume Next
        txtinpointvtr.Text = dgvcuepointsvtr.CurrentRow.Cells(0).Value
        txtoutpointvtr.Text = dgvcuepointsvtr.CurrentRow.Cells(1).Value
    End Sub
End Class
