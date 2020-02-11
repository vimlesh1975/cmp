Imports System.IO

Public Class ucQuiz
    Private Sub cmdplayquiz_Click(sender As System.Object, e As System.EventArgs) Handles cmdplayquiz.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        Dim cr As Integer = dgvquiz.CurrentRow.Index
        Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(dgvquiz.Rows(cr).Cells(0).Value)
        CasparCGDataCollection.SetData("xf0", System.Convert.ToBase64String(array))
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmbvideolayerquiz.Text), Int(cmbvideolayerquiz.Text), txtQuizTemplate.Text & "/quiz", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdstopquiz_Click(sender As System.Object, e As System.EventArgs) Handles cmdstopquiz.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmbvideolayerquiz.Text), Int(cmbvideolayerquiz.Text))
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmbvideolayerquiz.Text) + 1, Int(cmbvideolayerquiz.Text) + 1)
    End Sub

    Private Sub cmdanswerquiz_Click(sender As System.Object, e As System.EventArgs) Handles cmdanswerquiz.Click
        On Error Resume Next
        Dim cr As Integer = dgvquiz.CurrentRow.Index
        If dgvquiz.Rows(cr + 1).Cells(1).Value = 1 Then
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Invoke(Int(cmbvideolayerquiz.Text) + 1, Int(cmbvideolayerquiz.Text) + 1, "A")

        ElseIf dgvquiz.Rows(cr + 2).Cells(1).Value = 1 Then
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Invoke(Int(cmbvideolayerquiz.Text) + 1, Int(cmbvideolayerquiz.Text) + 1, "B")

        ElseIf dgvquiz.Rows(cr + 3).Cells(1).Value = 1 Then
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Invoke(Int(cmbvideolayerquiz.Text) + 1, Int(cmbvideolayerquiz.Text) + 1, "C")

        ElseIf dgvquiz.Rows(cr + 4).Cells(1).Value = 1 Then
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Invoke(Int(cmbvideolayerquiz.Text) + 1, Int(cmbvideolayerquiz.Text) + 1, "D")

        End If
    End Sub

    Private Sub tsnewquiz_Click(sender As System.Object, e As System.EventArgs)
    End Sub
    Sub newdgvquiz()

        On Error Resume Next
        dgvquiz.Rows.Clear()
        dgvquiz.Rows.Add(10)
        lblfilenamequiz.Text = "new"
    End Sub

    Private Sub tsopenquiz_Click(sender As System.Object, e As System.EventArgs)
    End Sub
    Sub openfilequiz()
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = "c:\casparcg\mydata\quiz\"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)
                'clear list
                dgvquiz.Rows.Clear()
                'Loop through and add list to the file.
                Dim g As Integer = 0
                Dim li As String
                Do Until sr.EndOfStream = True
                    li = sr.ReadLine()
                    dgvquiz.Rows.Add()
                    Dim xyz As Array = Split(li, Chr(2))
                    dgvquiz.Rows(g).Cells(0).Value = xyz(0)
                    dgvquiz.Rows(g).Cells(1).Value = xyz(1)
                    g = g + 1
                Loop
                sr.Close()
            End Using
            lblfilenamequiz.Text = ofd2.FileName
        End If
    End Sub

    Private Sub tssavequiz_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Sub savefilequiz()
        On Error Resume Next
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "c:\casparcg\mydata\quiz\"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvquiz.Rows.Count = 0 Then
                    sw.Write("")
                Else
                    'Loop through and add list to the file.
                    Dim f As Integer = 0
                    Do Until f = dgvquiz.Rows.Count
                        If dgvquiz.Rows(f).Cells(1).Value = False Then dgvquiz.Rows(f).Cells(1).Value = "0"
                        sw.WriteLine(dgvquiz.Rows(f).Cells(0).Value & Chr(2) & dgvquiz.Rows(f).Cells(1).Value)
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            lblfilenamequiz.Text = osd2.FileName
        End If
    End Sub
    Private Sub tscutquiz_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Sub deleteclipquiz()
        On Error Resume Next
        dgvquiz.Rows.RemoveAt(dgvquiz.CurrentRow.Index)
    End Sub

    Private Sub cmdaddquiz_Click(sender As System.Object, e As System.EventArgs) Handles cmdaddquiz.Click
        On Error Resume Next
        clipinsertquiz()
    End Sub
    Sub clipinsertquiz()
        On Error Resume Next
        dgvquiz.Rows.Insert(dgvquiz.CurrentRow.Index)
        dgvquiz.Rows(dgvquiz.CurrentRow.Index - 1).Cells(3).Value = 1
    End Sub

    Private Sub cmddownquiz_Click(sender As System.Object, e As System.EventArgs) Handles cmddownquiz.Click
        On Error Resume Next
        clipmovedownquiz()
    End Sub
    Sub clipmovedownquiz()
        On Error Resume Next
        If Me.dgvquiz.CurrentCell.RowIndex <> dgvquiz.Rows.Count - 2 Then
            Dim curRow As Integer = Me.dgvquiz.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvquiz.CurrentRow
            Me.dgvquiz.Rows.Remove(myRow)
            Me.dgvquiz.Rows.Insert(curRow + 1, myRow)
            dgvquiz.CurrentCell = dgvquiz.Rows(curRow + 1).Cells(0)

        End If
    End Sub

    Private Sub cmdupquiz_Click(sender As System.Object, e As System.EventArgs) Handles cmdupquiz.Click
        On Error Resume Next
        clipmoveupquiz()
    End Sub
    Sub clipmoveupquiz()
        On Error Resume Next
        If Me.dgvquiz.CurrentCell.RowIndex <> 0 Then
            Dim curRow As Integer = Me.dgvquiz.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvquiz.CurrentRow
            Me.dgvquiz.Rows.Remove(myRow)
            Me.dgvquiz.Rows.Insert(curRow - 1, myRow)
            dgvquiz.CurrentCell = dgvquiz.Rows(curRow - 1).Cells(0)
        End If
    End Sub

    Private Sub tspastequiz_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Sub insertcopiedquiz()
        On Error Resume Next
        Dim curRow As Integer = Me.dgvquiz.CurrentCell.RowIndex
        dgvquiz.Rows.Insert(dgvquiz.CurrentRow.Index)
        dgvquiz.CurrentCell = dgvquiz.Rows(curRow).Cells(0)
        Me.dgvquiz.Item(0, curRow).Value = tempRow.Cells(0).Value
        Me.dgvquiz.Item(1, curRow).Value = tempRow.Cells(1).Value
    End Sub
    Private Sub cmdcutquiz_Click(sender As System.Object, e As System.EventArgs) Handles cmdcutquiz.Click
        On Error Resume Next
        deleteclipquiz()
    End Sub

    Private Sub tscopyquiz_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Sub copyquiz()
        On Error Resume Next
        tempRow = Me.dgvquiz.CurrentRow
    End Sub

    Private Sub cmdplaytimerquiz_Click(sender As System.Object, e As System.EventArgs) Handles cmdplaytimerquiz.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmbvideolayerquiz.Text) + 2, Int(cmbvideolayerquiz.Text) + 2, txtQuizTemplate.Text & "/timer", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdstoptimerquiz_Click(sender As System.Object, e As System.EventArgs) Handles cmdstoptimerquiz.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmbvideolayerquiz.Text) + 2, Int(cmbvideolayerquiz.Text) + 2)

    End Sub

    Private Sub cmdpausetimerquiz_Click(sender As System.Object, e As System.EventArgs) Handles cmdpausetimerquiz.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("stoptimer", "")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmbvideolayerquiz.Text) + 2, Int(cmbvideolayerquiz.Text) + 2, CasparCGDataCollection)

    End Sub
    Private Sub cmdplayanswerquiz_Click(sender As System.Object, e As System.EventArgs) Handles cmdplayanswerquiz.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        Dim cr As Integer = dgvquiz.CurrentRow.Index
        Dim array1() As Byte = System.Text.Encoding.UTF8.GetBytes("A: " & dgvquiz.Rows(cr + 1).Cells(0).Value)
        Dim array2() As Byte = System.Text.Encoding.UTF8.GetBytes("B: " & dgvquiz.Rows(cr + 2).Cells(0).Value)
        Dim array3() As Byte = System.Text.Encoding.UTF8.GetBytes("C: " & dgvquiz.Rows(cr + 3).Cells(0).Value)
        Dim array4() As Byte = System.Text.Encoding.UTF8.GetBytes("D: " & dgvquiz.Rows(cr + 4).Cells(0).Value)


        CasparCGDataCollection.SetData("xf1", System.Convert.ToBase64String(array1))
        CasparCGDataCollection.SetData("xf2", System.Convert.ToBase64String(array2))
        CasparCGDataCollection.SetData("xf3", System.Convert.ToBase64String(array3))
        CasparCGDataCollection.SetData("xf4", System.Convert.ToBase64String(array4))

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmbvideolayerquiz.Text) + 1, Int(cmbvideolayerquiz.Text) + 1, txtQuizTemplate.Text & "/quiz1", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdhidequiz_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Sub initialisquizdata()
        On Error Resume Next
        dgvquiz.Rows.Add(10)
        dgvquiz.Item(0, 0).Value = "Where is Mumbai? "
        dgvquiz.Item(0, 1).Value = "America"
        dgvquiz.Item(0, 2).Value = "England"
        dgvquiz.Item(0, 3).Value = "India"
        dgvquiz.Item(0, 4).Value = "Japan"
        dgvquiz.Item(1, 3).Value = 1
    End Sub

    Private Sub ucQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialisquizdata()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        On Error Resume Next
        newdgvquiz()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        On Error Resume Next
        openfilequiz()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        On Error Resume Next
        savefilequiz()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        On Error Resume Next
        deleteclipquiz()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        On Error Resume Next
        copyquiz()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        On Error Resume Next
        insertcopiedquiz()
    End Sub

    Private Sub MenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip1.MouseHover
        MakeMenuDropDownWhenParrented(sender)
    End Sub
End Class
