Imports System.IO
Imports System.Net
Public Class ucMultiBulletScroll
    Dim iPauseResumeV As Integer = 0
    Private Sub newtsscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        newdgvscroll()
    End Sub
    Sub newdgvscroll()
        On Error Resume Next
        dgvscroll.Rows.Clear()
        dgvscroll.Rows.Add(7)

        For Each row As DataGridViewRow In dgvscroll.Rows
            row.Cells(2).Tag = "C:\Casparcg\mydata\icon\cmp2.jpg"
        Next
        Me.dgvscroll.Columns(0).HeaderText = "new playlist"
    End Sub
    Private Sub opentsscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Sub openfilescroll()
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog
        ofd2.InitialDirectory = "c:\casparcg\mydata\multibullet\"
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
                    dgvscroll.Rows(g).Cells(0).Value = xyz(0)
                    dgvscroll.Rows(g).Cells(1).Value = xyz(1)
                    dgvscroll.Rows(g).Cells(2).Value = Image.FromFile(xyz(2))
                    dgvscroll.Rows(g).Cells(2).Tag = xyz(2)
                    g = g + 1
                Loop
                sr.Close()
            End Using
            Me.dgvscroll.Columns(0).HeaderText = ofd2.FileName
        End If
    End Sub

    Private Sub savetsscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub savefilescroll()
        On Error Resume Next
        osd2.InitialDirectory = "c:\casparcg\mydata\multibullet\"
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
                        sw.WriteLine(dgvscroll.Rows(f).Cells(0).Value & Chr(2) & dgvscroll.Rows(f).Cells(1).Value & Chr(2) & dgvscroll.Rows(f).Cells(2).Tag)
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            Me.dgvscroll.Columns(0).HeaderText = osd2.FileName
        End If
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

    Private Sub pastetsscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub insertcopiedscroll()
        On Error Resume Next
        Dim curRow As Integer = Me.dgvscroll.CurrentCell.RowIndex
        dgvscroll.Rows.Insert(dgvscroll.CurrentRow.Index)
        dgvscroll.CurrentCell = dgvscroll.Rows(curRow).Cells(0)
        Me.dgvscroll.Item(0, curRow).Value = tempRow.Cells(0).Value
        Me.dgvscroll.Item(1, curRow).Value = tempRow.Cells(1).Value
        Me.dgvscroll.Item(2, curRow).Value = tempRow.Cells(2).Value
        Me.dgvscroll.Item(2, curRow).Tag = tempRow.Cells(2).Tag

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
        dgvscroll.Rows(dgvscroll.CurrentRow.Index - 1).Cells(2).Tag = "C:\Casparcg\mydata\icon\cmp2.jpg"
    End Sub

    Private Sub cmddeletetsscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddeletetsscroll.Click
        On Error Resume Next
        deleteclipscroll()
    End Sub

    Private Sub nspeedscroll_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nspeedscroll.ValueChanged
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("speed", nspeedscroll.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerscroll.Text), Int(cmblayerscroll.Text), CasparCGDataCollection)

    End Sub

    Private Sub cmdplayscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayscroll.Click
        On Error Resume Next
        setdataofscroll()

        CasparCGDataCollection.SetData("speed", nspeedscroll.Value)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayerscroll.Text), Int(cmblayerscroll.Text), txmultibulletscrollerTemplate.Text, True, CasparCGDataCollection.ToAMCPEscapedXml)
        'tmrshowdatascroll.Enabled = True

    End Sub
    Private Sub cmdpausescroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpausescroll.Click
        On Error Resume Next

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("speed", 0)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerscroll.Text), Int(cmblayerscroll.Text), CasparCGDataCollection)

    End Sub

    Private Sub cmdresumescroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresumescroll.Click
        On Error Resume Next

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
        CasparCGDataCollection.Clear()
        Dim ff As Integer = 0
        For jscroll = 0 To dgvscroll.Rows.Count - 1
            If dgvscroll.Rows(jscroll).Cells(1).Value = 1 Then
                CasparCGDataCollection.SetData("loader" & ff, dgvscroll.Rows(jscroll).Cells(2).Tag)
                CasparCGDataCollection.SetData("data" & ff, Replace(dgvscroll.Rows(jscroll).Cells(0).Value, vbLf, vbNullString))
                ff = ff + 1
            End If
        Next
        CasparCGDataCollection.SetData("n", ff + 1)
        CasparCGDataCollection.SetData("texty", ntextY.Value)

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

    Private Sub cmdshowtime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshowtime.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayertime.Text), Int(cmblayertime.Text), ("CMP/time/time"), True, CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
    Private Sub cmdhidetime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdhidetime.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayertime.Text), Int(cmblayertime.Text))
    End Sub
    Private Sub ucScroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialisescrolldata()
        enumeratefontsforall()
    End Sub
    Sub initialisescrolldata()
        On Error Resume Next
        dgvscroll.Rows.Add(10)


        Me.dgvscroll.Item(0, 0).Value = "Ram eats mango."
        Me.dgvscroll.Item(0, 1).Value = "Mohan goes to home."
        Me.dgvscroll.Item(0, 2).Value = "Sita cooks food."
        Me.dgvscroll.Item(0, 3).Value = "Vimlesh does casparcg."
        Me.dgvscroll.Item(0, 4).Value = "Sumant makes storage."
        Me.dgvscroll.Item(0, 5).Value = "KD prasad is good in programing."
        Me.dgvscroll.Item(0, 6).Value = "Rajeev makes news graphics."

        Dim xx As String = "C:\Casparcg\mydata\icon\cmp2.jpg"
        Me.dgvscroll.Item(2, 0).Value = Image.FromFile(xx)
        Me.dgvscroll.Item(2, 0).Tag = xx

        Me.dgvscroll.Item(2, 1).Value = Image.FromFile(xx)
        Me.dgvscroll.Item(2, 1).Tag = xx

        Me.dgvscroll.Item(2, 2).Value = Image.FromFile(xx)
        Me.dgvscroll.Item(2, 2).Tag = xx

        Me.dgvscroll.Item(2, 3).Value = Image.FromFile(xx)
        Me.dgvscroll.Item(2, 3).Tag = xx

        Me.dgvscroll.Item(2, 4).Value = Image.FromFile(xx)
        Me.dgvscroll.Item(2, 4).Tag = xx

        Me.dgvscroll.Item(2, 5).Value = Image.FromFile(xx)
        Me.dgvscroll.Item(2, 5).Tag = xx

        Me.dgvscroll.Item(2, 6).Value = Image.FromFile(xx)
        Me.dgvscroll.Item(2, 6).Tag = xx

        Me.dgvscroll.Item(1, 0).Value = 1
        Me.dgvscroll.Item(1, 1).Value = 1
        Me.dgvscroll.Item(1, 2).Value = 1
        Me.dgvscroll.Item(1, 3).Value = 1
        Me.dgvscroll.Item(1, 4).Value = 1
        Me.dgvscroll.Item(1, 5).Value = 1
        Me.dgvscroll.Item(1, 6).Value = 1


    End Sub

    Private Sub cmdhidegbscrollandclock_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Private Sub dgvscroll_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvscroll.CellContentClick
        If e.ColumnIndex = 2 Then
            Dim aa As New OpenFileDialog
            If aa.ShowDialog = DialogResult.OK Then
                dgvscroll.CurrentRow.Cells(2).Value = Image.FromFile(aa.FileName)
                dgvscroll.CurrentRow.Cells(2).Tag = aa.FileName
            End If
        End If
    End Sub

    Private Sub ntextY_ValueChanged(sender As Object, e As EventArgs) Handles ntextY.ValueChanged
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("texty", ntextY.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerscroll.Text), Int(cmblayerscroll.Text), CasparCGDataCollection)

    End Sub

    Private Sub dgvscroll_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles dgvscroll.DefaultValuesNeeded
        On Error Resume Next
        e.Row.Cells(2).Value = Image.FromFile("C:\Casparcg\mydata\icon\cmp2.jpg")
        e.Row.Cells(2).Tag = "C:\Casparcg\mydata\icon\cmp2.jpg"
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

    Private Sub cmdPlayMultibulletHtml_Click(sender As Object, e As EventArgs) Handles cmdPlayMultibulletHtml.Click
        On Error Resume Next

        iPauseResumeV = 0

        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " [HTML] " & """" & "C:/casparcg/mydata/html/htmlscrollerMultiBullet.html" & """" & " mix 20")
        ' Threading.Thread.Sleep(1000)

        If chkltrhtmlscroll.Checked Then
            If chkbase64htmlscroller.Checked Then
                For i = dgvscroll.Rows.Count - 1 To 0 Step -1
                    If dgvscroll.Rows(i).Cells(1).Value = 1 Then
                        Dim xx As String = Replace(Me.dgvscroll.Item(0, i).Value, vbCrLf, "")
                        'xx = Replace(xx, " ", Chr(2))
                        'xx = Replace(xx, "\", Chr(5))

                        Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(" " & xx & " <img src=" & Replace(dgvscroll.Rows(i).Cells(2).Tag, " \ ", " / ") & " width=40px height=30px style=vertical-align:middle>" & " ")
                        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " marqueedatabase64('" & System.Convert.ToBase64String(array) & "')")
                    End If
                Next
            Else
                For i = dgvscroll.Rows.Count - 1 To 0 Step -1
                    If dgvscroll.Rows(i).Cells(1).Value = 1 Then
                        Dim xx As String = Replace(Me.dgvscroll.Item(0, i).Value, vbCrLf, "")
                        'xx = Replace(xx, " ", Chr(2))
                        'xx = Replace(xx, "\", Chr(5))
                        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " marqueedata('" & replacestring1(xx) & Chr(2) & "<img" & Chr(2) & "src=" & Replace(dgvscroll.Rows(i).Cells(2).Tag, "\", "/") & Chr(2) & "width=40px" & Chr(2) & "height=30px" & Chr(2) & "style=vertical-align:middle>" & Chr(2) & "')")
                    End If
                Next
            End If
        Else
            If chkbase64htmlscroller.Checked Then
                For i = 0 To dgvscroll.Rows.Count - 1
                    If dgvscroll.Rows(i).Cells(1).Value = 1 Then
                        Dim xx As String = Replace(Me.dgvscroll.Item(0, i).Value, vbCrLf, "")

                        Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(" <img src=" & Replace(dgvscroll.Rows(i).Cells(2).Tag, " \ ", " / ") & " width=40px height=30px style=vertical-align:middle>" & " " & xx)
                        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " marqueedatabase64('" & System.Convert.ToBase64String(array) & "')")
                    End If
                Next
            Else
                For i = 0 To dgvscroll.Rows.Count - 1
                    If dgvscroll.Rows(i).Cells(1).Value = 1 Then
                        Dim xx As String = Replace(Me.dgvscroll.Item(0, i).Value, vbCrLf, "")
                        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " marqueedata('" & Chr(2) & "<img" & Chr(2) & "src=" & Replace(dgvscroll.Rows(i).Cells(2).Tag, "\", "/") & Chr(2) & "width=40px" & Chr(2) & "height=30px" & Chr(2) & "style=vertical-align:middle>" & Chr(2) & replacestring1(xx) & "')")
                    End If
                Next
            End If
        End If

        'Threading.Thread.Sleep(100)
        If chkltrhtmlscroll.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " start2()")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " start1()")
        End If
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " fontcolor('" & ColorTranslator.ToHtml(cmdstripcolorhtmlscroll.ForeColor) & "')")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " stripcolor('" & ColorTranslator.ToHtml(cmdstripcolorhtmlscroll.BackColor) & "')")

        'Threading.Thread.Sleep(100)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " stripy('" & nyhtmlscroll.Value & "')")

        ' Threading.Thread.Sleep(100)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " fontsize('" & nsizehtmlscroll.Value & "')")

        'Threading.Thread.Sleep(100)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " font('" & Replace(cmbfonthtmlscroll.Text, " ", Chr(2)) & "')")

        'Threading.Thread.Sleep(100)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " Tickery('" & nyhtmlscrollticker.Value & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " speed('" & nspeedhtmlscroll.Value & "')")
    End Sub

    Sub enumeratefontsforall()
        On Error Resume Next
        Dim InstalledFonts As New Drawing.Text.InstalledFontCollection
        Dim fontfamilies() As FontFamily = InstalledFonts.Families()
        For Each fontFamily As FontFamily In fontfamilies
            cmbfonthtmlscroll.Items.Add(fontFamily.Name)
        Next
    End Sub

    Private Sub nyhtmlscroll_ValueChanged(sender As Object, e As EventArgs) Handles nyhtmlscroll.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " stripy('" & nyhtmlscroll.Value & "')")
    End Sub

    Private Sub nyhtmlscrollticker_ValueChanged(sender As Object, e As EventArgs) Handles nyhtmlscrollticker.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " Tickery('" & nyhtmlscrollticker.Value & "')")

    End Sub

    Private Sub cmdstripcolorhtmlscroll_Click(sender As Object, e As EventArgs) Handles cmdstripcolorhtmlscroll.Click
        On Error Resume Next

        Dim aa As New ColorDialog
        If (aa.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdstripcolorhtmlscroll.BackColor = aa.Color
            cmdcolorhtmlscroll.BackColor = aa.Color
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " stripcolor('" & ColorTranslator.ToHtml(cmdstripcolorhtmlscroll.BackColor) & "')")
        End If
    End Sub



    Private Sub nsizehtmlscroll_ValueChanged(sender As Object, e As EventArgs) Handles nsizehtmlscroll.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " fontsize('" & nsizehtmlscroll.Value & "')")

    End Sub
    Private Sub nspeedhtmlscroll_ValueChanged(sender As Object, e As EventArgs) Handles nspeedhtmlscroll.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " speed('" & nspeedhtmlscroll.Value & "')")

    End Sub

    Private Sub cmbfonthtmlscroll_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfonthtmlscroll.SelectedIndexChanged
        On Error Resume Next

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " font('" & Replace(cmbfonthtmlscroll.Text, " ", Chr(2)) & "')")
    End Sub

    Private Sub cmdcolorhtmlscroll_Click(sender As Object, e As EventArgs) Handles cmdcolorhtmlscroll.Click
        On Error Resume Next

        Dim aa As New ColorDialog
        If (aa.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdcolorhtmlscroll.ForeColor = aa.Color
            cmdstripcolorhtmlscroll.ForeColor = aa.Color


            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " fontcolor('" & ColorTranslator.ToHtml(cmdstripcolorhtmlscroll.ForeColor) & "')")
        End If
    End Sub

    Private Sub cmdstopcrawlhtmlscroll_Click(sender As Object, e As EventArgs) Handles cmdstopcrawlhtmlscroll.Click
        On Error Resume Next
        'CasparDevice.SendString("stop " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text)
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " empty mix 20")
    End Sub

    Private Sub cmdpauseresumehtmlscroller_Click(sender As Object, e As EventArgs) Handles cmdpauseresumehtmlscroller.Click
        pauseresume()
    End Sub
    Sub pauseresume()
        iPauseResumeV = iPauseResumeV + 1
        If iPauseResumeV = 1 Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " pause()")

        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " resume()")
            'CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerscroll.Text & " speed('" & nspeedhtmlscroll.Value & "')")
            iPauseResumeV = 0
        End If


    End Sub
End Class
