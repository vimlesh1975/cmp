Imports System.IO

Public Class ucAMCPcommands
    Private Sub newtsamcp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        txtanyamcpcommand.Text = ""
        lblfilenameamcp.Text = "New"
    End Sub
    Private Sub opentsamcp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        openfileamcp()
    End Sub
    Sub openfileamcp()
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog
        ofd2.InitialDirectory = "c:\casparcg\mydata\amcp\"
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            If (ofd2.FileName <> "") Then
                Dim objFileInfo As New FileInfo(ofd2.FileName)
                ReadTextFile(objFileInfo.FullName, txtanyamcpcommand)
                lblfilenameamcp.Text = objFileInfo.FullName
            End If
        End If
    End Sub

    Private Sub savetsamcp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        savefileamcp()
    End Sub
    Sub savefileamcp()
        On Error Resume Next
        Dim osd2 As New SaveFileDialog
        osd2.InitialDirectory = "c:\casparcg\mydata\amcp\"
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            If (osd2.FileName <> "") Then
                Dim objFileInfo As New FileInfo(osd2.FileName)
                Dim objWriter As New System.IO.StreamWriter(objFileInfo.FullName)
                objWriter.Write(txtanyamcpcommand.Text)
                objWriter.Close()
                lblfilenameamcp.Text = objFileInfo.FullName
            End If
        End If
    End Sub
    Private Sub cmdMiscellaneous_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMiscellaneous.Click
        On Error Resume Next
        SendString(NetStream, cmbMiscellaneous.Text & vbCrLf)
        getresponse()
    End Sub
    Private Sub cmdanyamcpcommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdanyamcpcommand.Click
        On Error Resume Next
        SendString(NetStream, txtanyamcpcommand.Text & vbCrLf)
        getresponse()
    End Sub
    Sub getresponse()
        On Error Resume Next
        Threading.Thread.Sleep(250)
        Dim data(10024) As Byte
        NetStream.Read(data, 0, 10024)
        Dim returndata As String = ""
        returndata = System.Text.Encoding.UTF8.GetString(data)
        txtresponse.Text = returndata
    End Sub

    Private Sub ucAMCPcommands_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        On Error Resume Next
        txtanyamcpcommand.Text = ""
        lblfilenameamcp.Text = "New"
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        On Error Resume Next
        openfileamcp()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        On Error Resume Next
        savefileamcp()
    End Sub
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
    Private Sub MenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip1.MouseHover
        MakeMenuDropDownWhenParrented(sender)
    End Sub
End Class
