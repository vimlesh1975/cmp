Imports System.IO
Public Class ucBreakingNews
    Dim ibreakingnews As Integer
    Dim jbreakingnews As Integer
    Dim kbreakingnews As Integer

    Dim ar1() As String
    Dim ar2() As String
    Dim ar3() As String
    Dim ar4() As String
    Dim ar5() As String
    Dim ar6() As String
    Private Sub cmdhidebreakingnews_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Private Sub MenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip1.MouseHover
        MakeMenuDropDownWhenParrented(sender)
    End Sub
    Private Sub ucBreakingNews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialisebreakingnewsdata()
    End Sub
    Sub initialisebreakingnewsdata()
        On Error Resume Next
        Using sr As StreamReader = New StreamReader("c:\casparcg\mydata\breakingnews\04.08.17.txt")
            'clear list
            dgvbreakingnews.Rows.Clear()
            'Loop through and add list to the file.
            Dim g As Integer = 0
            Dim li As String
            Do Until sr.EndOfStream = True
                li = sr.ReadLine()
                dgvbreakingnews.Rows.Add()
                Dim xyz As Array = Split(li, Chr(2))
                dgvbreakingnews.Rows(g).Cells(0).Value = xyz(0)
                dgvbreakingnews.Rows(g).Cells(1).Value = xyz(1)

                dgvbreakingnews.Rows(g).Cells(2).Value = xyz(2)
                dgvbreakingnews.Rows(g).Cells(3).Value = xyz(3)
                g = g + 1
            Loop
            sr.Close()
        End Using
        lblbnfilename.Text = "c:\casparcg\mydata\breakingnews\04.08.17.txt"

    End Sub
    Private Sub cmdplaybreakingnews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplaybreakingnews.Click
        On Error Resume Next
        makearray()
        setdataofbreakingnews()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayerbreakingnews.Text), Int(cmblayerbreakingnews.Text), txtbnTemplate.Text, True, CasparCGDataCollection.ToAMCPEscapedXml)
        tmrshowdata.Interval = Val(txtbreakingnewsupdateinterval.Text)
        tmrshowdata.Enabled = True
    End Sub
    Private Sub cmdbreakingnewsselectall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbreakingnewsselectall.Click
        On Error Resume Next
        Dim ibreakingnewsforselectall As Integer
        For ibreakingnewsforselectall = 0 To dgvbreakingnews.RowCount - 1
            dgvbreakingnews.Rows(ibreakingnewsforselectall).Cells(1).Value = 1
        Next
    End Sub

    Private Sub cmdbreakingnewssdeelectall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbreakingnewssdeelectall.Click
        On Error Resume Next
        Dim ibreakingnewsfordeselectall As Integer
        For ibreakingnewsfordeselectall = 0 To dgvbreakingnews.RowCount - 1
            dgvbreakingnews.Rows(ibreakingnewsfordeselectall).Cells(1).Value = 0
        Next
    End Sub
    Sub makearray()
        On Error Resume Next
        ibreakingnews = 0
        jbreakingnews = 0
        kbreakingnews = 0
        Dim ar1(dgvbreakingnews.Rows.Count - 1) As String
        Dim ar3(dgvbreakingnews.Rows.Count - 1) As String
        Dim ar5(dgvbreakingnews.Rows.Count - 1) As String

        For Me.ibreakingnews = 0 To dgvbreakingnews.Rows.Count - 1
            If dgvbreakingnews.Rows(ibreakingnews).Cells(1).Value = 1 Then

                ar1(jbreakingnews) = dgvbreakingnews.Rows(ibreakingnews).Cells(0).Value
                ar3(jbreakingnews) = dgvbreakingnews.Rows(ibreakingnews).Cells(2).Value
                ar5(jbreakingnews) = dgvbreakingnews.Rows(ibreakingnews).Cells(3).Value

                jbreakingnews = jbreakingnews + 1
            End If
        Next
        ar2 = ar1
        ar4 = ar3
        ar6 = ar5
    End Sub

    Sub updatedata()
        On Error Resume Next
        setdataofbreakingnews()
        'CasparDevice.Channels(cmbchannel.Text-1).CG.Invoke(Int(cmblayerbreakingnews.Text), Int(cmblayerbreakingnews.Text), "loop")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerbreakingnews.Text), Int(cmblayerbreakingnews.Text), CasparCGDataCollection)


        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerbreakingnews.Text & " gwd.actions.timeline.gotoAndPlay('document.body','loop')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerbreakingnews.Text & " updatestring('" & replacestring1("ccgf0") & "','" & replacestring1(ar2(kbreakingnews)) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerbreakingnews.Text & " updatestring('" & replacestring1("ccgf1") & "','" & replacestring1(ar4(kbreakingnews)) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerbreakingnews.Text & " stf('" & replacestring1("ccgf0") & "')")

    End Sub

    Sub setdataofbreakingnews()
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData(dgvbreakingnews.Columns(2).HeaderText, (ar4(kbreakingnews)))
        CasparCGDataCollection.SetData(dgvbreakingnews.Columns(3).HeaderText, (ar6(kbreakingnews)))
        CasparCGDataCollection.SetData(dgvbreakingnews.Columns(0).HeaderText, (ar2(kbreakingnews)))
    End Sub

    Private Sub cmdstopbrekingnews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopbrekingnews.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Invoke(Int(cmblayerbreakingnews.Text), Int(cmblayerbreakingnews.Text), "out")
        Threading.Thread.Sleep(500)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayerbreakingnews.Text), Int(cmblayerbreakingnews.Text))
        tmrshowdata.Enabled = False

        CasparDevice.SendString("Stop " & g_int_ChannelNumber & "-" & Int(cmblayerbreakingnews.Text))
    End Sub

    Private Sub tmrshowdata_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrshowdata.Tick
        On Error Resume Next
        kbreakingnews = kbreakingnews + 1
        If ar2(kbreakingnews) = "" Then
            makearray()
        End If
        updatedata()
    End Sub

    Private Sub newtsbreakingnews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        newdgvbreakingnews()
    End Sub
    Sub newdgvbreakingnews()

        On Error Resume Next
        dgvbreakingnews.Rows.Clear()
        dgvbreakingnews.Rows.Add(7)
        lblbnfilename.Text = "new playlist"

    End Sub

    Private Sub opentsbreakingnews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        openfilebreakingnews()
    End Sub
    Sub openfilebreakingnews()
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = "c:\casparcg\mydata\breakingnews\"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)
                'clear list
                dgvbreakingnews.Rows.Clear()
                'Loop through and add list to the file.
                Dim g As Integer = 0
                Dim li As String
                Do Until sr.EndOfStream = True
                    li = sr.ReadLine()
                    dgvbreakingnews.Rows.Add()
                    Dim xyz As Array = Split(li, Chr(2))
                    dgvbreakingnews.Rows(g).Cells(0).Value = Replace(xyz(0), Chr(2), " ")
                    dgvbreakingnews.Rows(g).Cells(1).Value = xyz(1)
                    dgvbreakingnews.Rows(g).Cells(2).Value = Replace(xyz(2), Chr(2), " ")
                    dgvbreakingnews.Rows(g).Cells(3).Value = Replace(xyz(3), Chr(2), " ")


                    g = g + 1
                Loop
                sr.Close()
            End Using
            lblbnfilename.Text = ofd2.FileName
        End If
    End Sub
    Sub insertfilebreakingnews()
        'On Error Resume Next
        Dim ofd2 As New OpenFileDialog
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = "c:\casparcg\mydata\breakingnews\"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)
                'clear list
                'dgvbreakingnews.Rows.Clear()
                'Loop through and add list to the file.
                Dim g As Integer = dgvbreakingnews.CurrentRow.Index
                Dim li As String
                Do Until sr.EndOfStream = True
                    li = sr.ReadLine()
                    dgvbreakingnews.Rows.Insert(g)
                    Dim xyz As Array = Split(li, Chr(2))
                    'dgvbreakingnews.Rows(g).Cells(0).Value = xyz(0)
                    'dgvbreakingnews.Rows(g).Cells(1).Value = xyz(1)

                    'dgvbreakingnews.Rows(g).Cells(2).Value = xyz(2)
                    'dgvbreakingnews.Rows(g).Cells(3).Value = xyz(3)


                    dgvbreakingnews.Rows(g).Cells(0).Value = Replace(xyz(0), Chr(2), " ")
                    dgvbreakingnews.Rows(g).Cells(1).Value = xyz(1)
                    dgvbreakingnews.Rows(g).Cells(2).Value = Replace(xyz(2), Chr(2), " ")
                    dgvbreakingnews.Rows(g).Cells(3).Value = Replace(xyz(3), Chr(2), " ")


                    g = g + 1
                Loop
                sr.Close()
            End Using
            'lblbnfilename.Text = ofd2.FileName
        End If
    End Sub


    Private Sub savetsbreakingnews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        saveasfilebreakingnews()
    End Sub
    Sub saveasfilebreakingnews()
        On Error Resume Next

        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "c:\casparcg\mydata\breakingnews\"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvbreakingnews.Rows.Count = 0 Then
                    sw.Write("")
                Else
                    'Loop through and add list to the file.
                    Dim f As Integer = 0
                    Do Until f = dgvbreakingnews.Rows.Count
                        If dgvbreakingnews.Rows(f).Cells(1).Value = False Then dgvbreakingnews.Rows(f).Cells(1).Value = "0"
                        'sw.WriteLine(dgvbreakingnews.Rows(f).Cells(0).Value & Chr(2) & dgvbreakingnews.Rows(f).Cells(1).Value & Chr(2) & dgvbreakingnews.Rows(f).Cells(2).Value & Chr(2) & dgvbreakingnews.Rows(f).Cells(3).Value)
                        sw.WriteLine(Replace(dgvbreakingnews.Rows(f).Cells(0).Value, Chr(2), " ") & Chr(2) & dgvbreakingnews.Rows(f).Cells(1).Value & Chr(2) & Replace(dgvbreakingnews.Rows(f).Cells(2).Value, Chr(2), " ") & Chr(2) & Replace(dgvbreakingnews.Rows(f).Cells(3).Value, Chr(2), " "))

                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            lblbnfilename.Text = osd2.FileName
        End If
    End Sub


    Sub savefilebreakingnews()
        On Error Resume Next

        Using sw As StreamWriter = New StreamWriter(lblbnfilename.Text)
            If dgvbreakingnews.Rows.Count = 0 Then
                sw.Write("")
            Else

                Dim f As Integer = 0
                Do Until f = dgvbreakingnews.Rows.Count
                    If dgvbreakingnews.Rows(f).Cells(1).Value = False Then dgvbreakingnews.Rows(f).Cells(1).Value = "0"
                    sw.WriteLine(Replace(dgvbreakingnews.Rows(f).Cells(0).Value, Chr(2), " ") & Chr(2) & dgvbreakingnews.Rows(f).Cells(1).Value & Chr(2) & Replace(dgvbreakingnews.Rows(f).Cells(2).Value, Chr(2), " ") & Chr(2) & Replace(dgvbreakingnews.Rows(f).Cells(3).Value, Chr(2), " "))
                    f = f + 1
                Loop
            End If
            sw.Close()
        End Using

    End Sub

    Private Sub cuttsbreakingnews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        deleteclipbreakingnews()
    End Sub
    Sub deleteclipbreakingnews()
        On Error Resume Next
        dgvbreakingnews.Rows.RemoveAt(dgvbreakingnews.CurrentRow.Index)
    End Sub

    Private Sub copytsbreakingnews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        copybreakingnews()
    End Sub
    Sub copybreakingnews()
        On Error Resume Next
        tempRow = Me.dgvbreakingnews.CurrentRow
    End Sub

    Private Sub pastetsbreakingnews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        insertcopiedbreakingnews()
    End Sub
    Sub insertcopiedbreakingnews()
        On Error Resume Next
        Dim curRow As Integer = Me.dgvbreakingnews.CurrentCell.RowIndex
        dgvbreakingnews.Rows.Insert(dgvbreakingnews.CurrentRow.Index)
        dgvbreakingnews.CurrentCell = dgvbreakingnews.Rows(curRow).Cells(0)
        Me.dgvbreakingnews.Item(0, curRow).Value = tempRow.Cells(0).Value
        Me.dgvbreakingnews.Item(1, curRow).Value = tempRow.Cells(1).Value
    End Sub



    Private Sub cmdmovedownbreakingnews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmovedownbreakingnews.Click
        On Error Resume Next
        clipmovedownbreakingnews()
    End Sub
    Sub clipmovedownbreakingnews()
        On Error Resume Next
        If Me.dgvbreakingnews.CurrentCell.RowIndex <> dgvbreakingnews.Rows.Count - 2 Then
            Dim curRow As Integer = Me.dgvbreakingnews.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvbreakingnews.CurrentRow
            Me.dgvbreakingnews.Rows.Remove(myRow)
            Me.dgvbreakingnews.Rows.Insert(curRow + 1, myRow)
            dgvbreakingnews.CurrentCell = dgvbreakingnews.Rows(curRow + 1).Cells(0)

        End If
    End Sub

    Private Sub cmdmoveupbreakingnews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmoveupbreakingnews.Click
        On Error Resume Next
        clipmoveupbrekingnews()
    End Sub
    Sub clipmoveupbrekingnews()
        On Error Resume Next
        If Me.dgvbreakingnews.CurrentCell.RowIndex <> 0 Then
            Dim curRow As Integer = Me.dgvbreakingnews.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvbreakingnews.CurrentRow
            Me.dgvbreakingnews.Rows.Remove(myRow)
            Me.dgvbreakingnews.Rows.Insert(curRow - 1, myRow)
            dgvbreakingnews.CurrentCell = dgvbreakingnews.Rows(curRow - 1).Cells(0)
        End If
    End Sub

    Private Sub cmdinsertbreakingnews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdinsertbreakingnews.Click
        On Error Resume Next
        clipinsertbreakingnews()
    End Sub
    Sub clipinsertbreakingnews()
        On Error Resume Next
        dgvbreakingnews.Rows.Insert(dgvbreakingnews.CurrentRow.Index)
        dgvbreakingnews.Rows(dgvbreakingnews.CurrentRow.Index - 1).Cells(3).Value = 1
    End Sub

    Private Sub cmddeleteclipbreakingnews_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddeleteclipbreakingnews.Click
        On Error Resume Next
        deleteclipbreakingnews()
    End Sub

    Private Sub cmdshowtime_Click(sender As Object, e As EventArgs) Handles cmdshowtime.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayertime.Text), Int(cmblayertime.Text), txtclockTemplate.Text, True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdhidetime_Click(sender As Object, e As EventArgs) Handles cmdhidetime.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayertime.Text), Int(cmblayertime.Text))

    End Sub

    Private Sub NewToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        On Error Resume Next
        newdgvbreakingnews()
    End Sub

    Private Sub OpenToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        On Error Resume Next
        openfilebreakingnews()
    End Sub

    Private Sub SaveToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        On Error Resume Next
        savefilebreakingnews()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        On Error Resume Next
        deleteclipbreakingnews()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        On Error Resume Next
        copybreakingnews()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        On Error Resume Next
        insertcopiedbreakingnews()
    End Sub

    Private Sub cmdPlayHTML_Click(sender As Object, e As EventArgs) Handles cmdPlayHTML.Click
        On Error Resume Next
        makearray()
        setdataofbreakingnews()
        tmrshowdata.Interval = Val(txtbreakingnewsupdateinterval.Text)
        tmrshowdata.Enabled = True
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayerbreakingnews.Text & " [HTML] c:/casparcg/CMP/BreakingNews/gwd3/gwd_preview_gwd3/index.html")
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        On Error Resume Next
        saveasfilebreakingnews()
    End Sub

    Private Sub InsertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertToolStripMenuItem.Click
        insertfilebreakingnews()
    End Sub

    Private Sub Dgvbreakingnews_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbreakingnews.CellContentClick

    End Sub

    Private Sub dgvbreakingnews_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvbreakingnews.DataError
        'dont delete
    End Sub
End Class
