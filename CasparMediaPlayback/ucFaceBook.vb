Imports Facebook
Imports System.ComponentModel
Public Class ucFaceBook
    Private Sub cmdsearchqueryfacebook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearchqueryfacebook.Click
        On Error Resume Next
        bwfacebook.RunWorkerAsync()
    End Sub
    Private Sub cmdplayfacebook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayfacebook.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("loader1", dgvfacebook.CurrentRow.Cells(3).Value)
        CasparCGDataCollection.SetData("f0", dgvfacebook.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("f1", dgvfacebook.CurrentRow.Cells(2).Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayerfacebook.Text), Int(cmblayerfacebook.Text), ("CMP/facebook/facebook"), True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdnextstepfacebook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnextstepfacebook.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Next(Int(cmblayerfacebook.Text), Int(cmblayerfacebook.Text))

    End Sub
    Private Sub cmdstopfacebook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopfacebook.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayerfacebook.Text), Int(cmblayerfacebook.Text))

    End Sub
    Private Sub bwfacebook_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwfacebook.DoWork
        On Error Resume Next
        Control.CheckForIllegalCrossThreadCalls = False
        dgvfacebook.Rows.Clear()
        dgvfacebook.RowTemplate.Height = 75

        Dim fbc As New FacebookClient
        Dim str As String = txtgraphfacebook.Text & txtquery.Text & "&access_token=" & txtaccesstoken.Text
        Dim Result = fbc.Get(str)
        Threading.Thread.Sleep(2000)
        Dim ifacebook As Integer = 0
        pbfacebook.Maximum = Result.data.count
        For Each fdata In Result.data
            dgvfacebook.Rows.Add()
            dgvfacebook.Rows(ifacebook).Cells(0).Value = Image.FromStream(System.Net.HttpWebRequest.Create("https://graph.facebook.com/" + fdata.from.id + "/picture?type=square&width=75&height=75").GetResponse().GetResponseStream())
            dgvfacebook.Rows(ifacebook).Cells(1).Value = fdata.from.name
            dgvfacebook.Rows(ifacebook).Cells(2).Value = fdata.message
            dgvfacebook.Rows(ifacebook).Cells(3).Value = "https://graph.facebook.com/" + fdata.from.id + "/picture?type=square&width=75&height=75"
            ifacebook = ifacebook + 1

            pbfacebook.Value = ifacebook
        Next
    End Sub

    Private Sub bwfacebook_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwfacebook.RunWorkerCompleted
        On Error Resume Next
        dgvfacebook.ScrollBars = ScrollBars.Both
    End Sub

    Private Sub cmdhidegbfacebook_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Private Sub cmdreadkeyforfacebook_Click(sender As Object, e As EventArgs) Handles cmdreadkeyforfacebook.Click
        On Error Resume Next
        Using sr As IO.StreamReader = New IO.StreamReader("d:/key.txt")
            Dim g As Integer = 0
            Dim li As String
            Do Until sr.EndOfStream = True
                li = sr.ReadLine()
                Dim xyz As Array = Split(li, ",")

                If g = 4 Then txtaccesstoken.Text = xyz(1)
                g = g + 1
            Loop
            sr.Close()
        End Using
    End Sub
    Private Sub ucFaceBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
