Imports System.IO

Public Class ucScroll
    Dim tempspeed As Double

    Sub newdgvscroll()
        On Error Resume Next
        dgvscroll.Rows.Clear()
        dgvscroll.Rows.Add(7)
        Me.dgvscroll.Columns(0).HeaderText = "new playlist"
    End Sub

    Sub openfilescroll()
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog
        ofd2.InitialDirectory = "c:\casparcg\mydata\scroll\"
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)

                dgvscroll.Rows.Clear()

                Dim g As Integer = 0
                Dim li As String
                Do Until sr.EndOfStream = True
                    li = sr.ReadLine()
                    dgvscroll.Rows.Add()
                    Dim xyz As Array = Split(li, Chr(2))
                    dgvscroll.Rows(g).Cells(0).Value = Replace(xyz(0), Chr(2), " ") 'xyz(0)
                    dgvscroll.Rows(g).Cells(1).Value = xyz(1)
                    g = g + 1
                Loop
                sr.Close()
            End Using
            Me.dgvscroll.Columns(0).HeaderText = ofd2.FileName
        End If
    End Sub
    Sub insertfilescroll()
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog
        ofd2.InitialDirectory = "c:\casparcg\mydata\scroll\"
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)

                'dgvscroll.Rows.Clear()

                Dim g As Integer = dgvscroll.CurrentRow.Index
                Dim li As String
                Do Until sr.EndOfStream = True
                    li = sr.ReadLine()
                    dgvscroll.Rows.Insert(g)
                    Dim xyz As Array = Split(li, Chr(2))
                    dgvscroll.Rows(g).Cells(0).Value = Replace(xyz(0), Chr(2), " ")
                    dgvscroll.Rows(g).Cells(1).Value = xyz(1)
                    g = g + 1
                Loop
                sr.Close()
            End Using
            'Me.dgvscroll.Columns(0).HeaderText = ofd2.FileName
        End If
    End Sub
    Sub saveasfilescroll()
        On Error Resume Next
        osd2.InitialDirectory = "c:\casparcg\mydata\scroll\"
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvscroll.Rows.Count = 0 Then
                    sw.Write("")
                Else

                    Dim f As Integer = 0
                    Do Until f = dgvscroll.Rows.Count
                        If dgvscroll.Rows(f).Cells(1).Value = False Then dgvscroll.Rows(f).Cells(1).Value = "0"
                        'sw.WriteLine(dgvscroll.Rows(f).Cells(0).Value & Chr(2) & dgvscroll.Rows(f).Cells(1).Value)
                        sw.WriteLine(Replace(dgvscroll.Rows(f).Cells(0).Value, Chr(2), " ") & Chr(2) & dgvscroll.Rows(f).Cells(1).Value)
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            Me.dgvscroll.Columns(0).HeaderText = osd2.FileName
        End If
    End Sub

    Sub savefilescroll()
        On Error Resume Next
        'osd2.InitialDirectory = "c:\casparcg\mydata\scroll\"
        'osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        'osd2.FileName = ""
        'If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
        Using sw As StreamWriter = New StreamWriter(dgvscroll.Columns(0).HeaderText)
                If dgvscroll.Rows.Count = 0 Then
                    sw.Write("")
                Else

                    Dim f As Integer = 0
                    Do Until f = dgvscroll.Rows.Count
                        If dgvscroll.Rows(f).Cells(1).Value = False Then dgvscroll.Rows(f).Cells(1).Value = "0"
                    sw.WriteLine(Replace(dgvscroll.Rows(f).Cells(0).Value, Chr(2), " ") & Chr(2) & dgvscroll.Rows(f).Cells(1).Value)
                    f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
        'Me.dgvscroll.Columns(0).HeaderText = osd2.FileName
        'End If
    End Sub
    Private Sub cuttsscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub deleteclipscroll()
        On Error Resume Next
        dgvscroll.Rows.RemoveAt(dgvscroll.CurrentRow.Index)
    End Sub

    Private Sub copytsscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub copyscroll()
        tempRow = Me.dgvscroll.CurrentRow
    End Sub

    Sub insertcopiedscroll()
        On Error Resume Next
        Dim curRow As Integer = Me.dgvscroll.CurrentCell.RowIndex
        dgvscroll.Rows.Insert(dgvscroll.CurrentRow.Index)
        dgvscroll.CurrentCell = dgvscroll.Rows(curRow).Cells(0)
        Me.dgvscroll.Item(0, curRow).Value = tempRow.Cells(0).Value
        Me.dgvscroll.Item(1, curRow).Value = tempRow.Cells(1).Value
    End Sub

    Private Sub cmduptsscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmduptsscroll.Click
        clipmoveupscroll()
    End Sub
    Sub clipmoveupscroll()
        On Error Resume Next
        If Me.dgvscroll.CurrentCell.RowIndex <> 0 Then
            Dim curRow As Integer = Me.dgvscroll.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvscroll.CurrentRow
            Me.dgvscroll.Rows.Remove(myRow)
            Me.dgvscroll.Rows.Insert(curRow - 1, myRow)
            dgvscroll.CurrentCell = dgvscroll.Rows(curRow - 1).Cells(0)
        End If
    End Sub

    Private Sub cmddowntsscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddowntsscroll.Click
        On Error Resume Next
        clipmovedownscroll()
    End Sub
    Sub clipmovedownscroll()
        On Error Resume Next
        If Me.dgvscroll.CurrentCell.RowIndex <> dgvscroll.Rows.Count - 2 Then
            Dim curRow As Integer = Me.dgvscroll.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvscroll.CurrentRow
            Me.dgvscroll.Rows.Remove(myRow)
            Me.dgvscroll.Rows.Insert(curRow + 1, myRow)
            dgvscroll.CurrentCell = dgvscroll.Rows(curRow + 1).Cells(0)

        End If
    End Sub

    Private Sub cmdinserttsscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdinserttsscroll.Click
        On Error Resume Next
        clipinsertscroll()
    End Sub
    Sub clipinsertscroll()
        On Error Resume Next
        dgvscroll.Rows.Insert(dgvscroll.CurrentRow.Index)
        dgvscroll.Rows(dgvscroll.CurrentRow.Index - 1).Cells(3).Value = 1
    End Sub

    Private Sub cmddeletetsscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddeletetsscroll.Click
        On Error Resume Next
        deleteclipscroll()
    End Sub

    Private Sub nspeedscroll_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nspeedscroll.ValueChanged
        On Error Resume Next
        If nspeedscroll.Value <> 0 Then
            tempspeed = nspeedscroll.Value
        End If
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("speed", nspeedscroll.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerscroll.Text), Int(cmblayerscroll.Text), CasparCGDataCollection)

    End Sub
    Private Sub picscrollbullet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picscrollbullet.Click
        On Error Resume Next
        Dim aa As New OpenFileDialog
        If (aa.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            picscrollbullet.ImageLocation = aa.FileName
        End If
    End Sub
    Private Sub cmdplayscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayscroll.Click
        On Error Resume Next

        nspeedscroll.Value = tempspeed
        setdataofscroll()
        CasparCGDataCollection.SetData("speed", nspeedscroll.Value)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayerscroll.Text), Int(cmblayerscroll.Text), txtScrollTemplate.Text, True, CasparCGDataCollection.ToAMCPEscapedXml)
        tmrshowdatascroll.Enabled = True

    End Sub
    Private Sub cmdpausescroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpausescroll.Click
        On Error Resume Next
        If nspeedscroll.Value <> 0 Then
            tempspeed = nspeedscroll.Value
        End If

        nspeedscroll.Value = 0
    End Sub

    Private Sub cmdresumescroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresumescroll.Click
        On Error Resume Next
        nspeedscroll.Value = tempspeed

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("speed", nspeedscroll.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerscroll.Text), Int(cmblayerscroll.Text), CasparCGDataCollection)

    End Sub
    Private Sub cmdselectallforscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdselectallforscroll.Click
        On Error Resume Next
        Dim iscrollselectall As Integer
        For iscrollselectall = 0 To dgvscroll.RowCount - 1
            dgvscroll.Rows(iscrollselectall).Cells(1).Value = 1
        Next
    End Sub

    Private Sub cmddeselectallforscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddeselectallforscroll.Click
        On Error Resume Next
        Dim iscrolldeselectall As Integer
        For iscrolldeselectall = 0 To dgvscroll.RowCount - 1
            dgvscroll.Rows(iscrolldeselectall).Cells(1).Value = 0
        Next
    End Sub
    Sub setdataofscroll()
        On Error Resume Next

        Dim str As String = ""
        For jscroll = 0 To dgvscroll.Rows.Count - 1
            If dgvscroll.Rows(jscroll).Cells(1).Value = 1 Then str = str + Replace(dgvscroll.Rows(jscroll).Cells(0).Value, vbLf, vbNullString) + txtdelemeterforscroll.Text
        Next

        CasparCGDataCollection.Clear()
        If chkCapitalise.Checked Then
            CasparCGDataCollection.SetData("scrolldatacapitalised", str)
        Else
            CasparCGDataCollection.SetData("scrolldata", str)
        End If

        CasparCGDataCollection.SetData("loader1", picscrollbullet.ImageLocation)

    End Sub

    Private Sub cmdstopscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopscroll.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayerscroll.Text), Int(cmblayerscroll.Text))
        tmrshowdatascroll.Enabled = False
    End Sub
    Private Sub tmrshowdatascroll_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrshowdatascroll.Tick
        On Error Resume Next
        updatedatascroll()
    End Sub
    Sub updatedatascroll()
        setdataofscroll()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerscroll.Text), Int(cmblayerscroll.Text), CasparCGDataCollection)
    End Sub







    Private Sub ucScroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialisescrolldata()
        tempspeed = nspeedscroll.Value
    End Sub
    Sub initialisescrolldata()

        On Error Resume Next

        Using sr As StreamReader = New StreamReader("c:\casparcg\mydata\scroll\04.08.17.txt")

            dgvscroll.Rows.Clear()

            Dim g As Integer = 0
            Dim li As String
            Do Until sr.EndOfStream = True
                li = sr.ReadLine()
                dgvscroll.Rows.Add()
                Dim xyz As Array = Split(li, Chr(2))
                dgvscroll.Rows(g).Cells(0).Value = xyz(0)
                dgvscroll.Rows(g).Cells(1).Value = xyz(1)
                g = g + 1
            Loop
            sr.Close()
        End Using
        Me.dgvscroll.Columns(0).HeaderText = "c:\casparcg\mydata\scroll\04.08.17.txt"

    End Sub

    Private Sub cmdhidegbscrollandclock_Click(sender As Object, e As EventArgs) Handles cmdhidegbscrollandclock.Click
        Me.Hide()
    End Sub

    Private Sub chkCapitalise_CheckedChanged(sender As Object, e As EventArgs) Handles chkCapitalise.CheckedChanged

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        On Error Resume Next
        newdgvscroll()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        On Error Resume Next
        openfilescroll()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        On Error Resume Next
        savefilescroll()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        On Error Resume Next
        deleteclipscroll()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        copyscroll()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        insertcopiedscroll()
    End Sub

    Private Sub MenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip1.MouseHover
        MakeMenuDropDownWhenParrented(sender)
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        On Error Resume Next
        saveasfilescroll()
    End Sub

    Private Sub InsertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertToolStripMenuItem.Click
        insertfilescroll()
    End Sub

    Private Sub Dgvscroll_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvscroll.CellContentClick

    End Sub

    Private Sub dgvscroll_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvscroll.DataError
        'dont delete it
    End Sub
End Class
