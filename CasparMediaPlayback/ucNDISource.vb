Public Class ucNDISource
    Private Sub CmbNDI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNDI.SelectedIndexChanged

    End Sub
    Sub getresponse()
        On Error Resume Next
        Threading.Thread.Sleep(250)
        Dim data(10024) As Byte
        NetStream.Read(data, 0, 10024)
        Dim returndata As String = ""
        returndata = System.Text.Encoding.UTF8.GetString(data)
        Dim aa = Split(returndata, vbNewLine)

        cmbNDI.Items.Clear()
        For i = 1 To aa.Count - 3
            cmbNDI.Items.Add(Split(Mid(aa(i), 3), ")")(0) & ")" & """")
        Next

    End Sub

    Private Sub cmbNDI_Click(sender As Object, e As EventArgs) Handles cmbNDI.Click
        Dim str As String
        str = "ndi list"
        SendString(NetStream, str + vbCrLf)
        getresponse()
    End Sub

    Private Sub CmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        ndi1 = cmbNDI.Text
        Me.Parent.Dispose()
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Parent.Dispose()
    End Sub

    Private Sub UcNDISource_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
