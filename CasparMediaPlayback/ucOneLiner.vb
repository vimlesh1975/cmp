Imports System.IO
Imports System.Net
Imports Google.Cloud.Translation.V2
Imports Newtonsoft.Json
Public Class ucOneLiner
    Dim client As TranslationClient

    Dim client1 As New WebClient()

    Sub newdgvoneliner()
        On Error Resume Next
        dgvonelinesuper.Rows.Clear()
        dgvonelinesuper.Rows.Add(7)
        Me.dgvonelinesuper.Columns(0).HeaderText = "new playlist"
    End Sub
    Private Sub opentsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Sub openfileoneliner()
        On Error Resume Next
        ofd2.InitialDirectory = "c:\casparcg\mydata\oneliner\"
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)
                dgvonelinesuper.Rows.Clear()
                Dim g As Integer = 0
                Dim li As String
                Do Until sr.EndOfStream = True
                    li = sr.ReadLine()
                    dgvonelinesuper.Rows.Add()
                    Dim xyz As Array = Split(li, Chr(2))
                    dgvonelinesuper.Rows(g).Cells(0).Value = xyz(0)

                    g = g + 1
                Loop
                sr.Close()
            End Using
            Me.dgvonelinesuper.Columns(0).HeaderText = ofd2.FileName
        End If
    End Sub

    Private Sub savetsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub savefileoneliner()

        On Error Resume Next

        osd2.InitialDirectory = "c:\casparcg\mydata\oneliner\"
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvonelinesuper.Rows.Count = 0 Then
                    sw.Write("")
                Else

                    Dim f As Integer = 0
                    Do Until f = dgvonelinesuper.Rows.Count

                        sw.WriteLine(dgvonelinesuper.Rows(f).Cells(0).Value & Chr(2))
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            Me.dgvonelinesuper.Columns(0).HeaderText = osd2.FileName
        End If
    End Sub


    Sub deletecliponeliner()
        On Error Resume Next
        dgvonelinesuper.Rows.RemoveAt(dgvonelinesuper.CurrentRow.Index)
    End Sub

    Private Sub copytsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub copyoneliner()
        On Error Resume Next
        tempRow = Me.dgvonelinesuper.CurrentRow
    End Sub
    Private Sub pasteoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub insertcopiedoneliner()
        On Error Resume Next
        Dim curRow As Integer = Me.dgvonelinesuper.CurrentCell.RowIndex
        dgvonelinesuper.Rows.Insert(dgvonelinesuper.CurrentRow.Index)
        dgvonelinesuper.CurrentCell = dgvonelinesuper.Rows(curRow).Cells(0)
        Me.dgvonelinesuper.Item(0, curRow).Value = tempRow.Cells(0).Value
        Me.dgvonelinesuper.Item(1, curRow).Value = tempRow.Cells(1).Value
    End Sub

    Private Sub uptsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uptsoneliner.Click
        On Error Resume Next
        clipmoveuponeliner()
    End Sub


    Private Sub downtsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles downtsoneliner.Click
        On Error Resume Next
        clipmovedownoneliner()
    End Sub
    Sub clipmovedownoneliner()
        On Error Resume Next
        If Me.dgvonelinesuper.CurrentCell.RowIndex <> dgvonelinesuper.Rows.Count - 2 Then
            Dim curRow As Integer = Me.dgvonelinesuper.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvonelinesuper.CurrentRow
            Me.dgvonelinesuper.Rows.Remove(myRow)
            Me.dgvonelinesuper.Rows.Insert(curRow + 1, myRow)
            dgvonelinesuper.CurrentCell = dgvonelinesuper.Rows(curRow + 1).Cells(0)

        End If
    End Sub

    Private Sub addtsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addtsoneliner.Click
        On Error Resume Next
        clipinsertoneliner()
    End Sub
    Sub clipinsertoneliner()
        On Error Resume Next
        dgvonelinesuper.Rows.Insert(dgvonelinesuper.CurrentRow.Index)

    End Sub

    Private Sub removetsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removetsoneliner.Click
        On Error Resume Next
        deletecliponeliner()
    End Sub


    Sub clipmoveuponeliner()
        On Error Resume Next
        If Me.dgvonelinesuper.CurrentCell.RowIndex <> 0 Then
            Dim curRow As Integer = Me.dgvonelinesuper.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvonelinesuper.CurrentRow
            Me.dgvonelinesuper.Rows.Remove(myRow)
            Me.dgvonelinesuper.Rows.Insert(curRow - 1, myRow)
            dgvonelinesuper.CurrentCell = dgvonelinesuper.Rows(curRow - 1).Cells(0)
        End If
    End Sub


    Private Sub deletetsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub cmdonelinesuperstop_Click(sender As Object, e As EventArgs) Handles cmdonelinesuperstop.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayeronelinesuper.Text), Int(cmblayeronelinesuper.Text))

    End Sub
    Private Sub cmdonelinesupernext_Click(sender As Object, e As EventArgs) Handles cmdonelinesupernext.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Next(Int(cmblayeronelinesuper.Text), Int(cmblayeronelinesuper.Text))

    End Sub
    Private Sub cmdonelinesuperplay_Click(sender As Object, e As EventArgs) Handles cmdonelinesuperplay.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        If chkPlayFromTraslatedGrigFlash.Checked Then
            Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(dgvonelinesuperTranslated.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("base64", System.Convert.ToBase64String(array))
            CasparCGDataCollection.SetData(txtvariable1.Text, dgvonelinesuperTranslated.CurrentRow.Cells(0).Value)

        Else
            Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(dgvonelinesuper.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("base64", System.Convert.ToBase64String(array))
            CasparCGDataCollection.SetData(txtvariable1.Text, dgvonelinesuper.CurrentRow.Cells(0).Value)
        End If

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayeronelinesuper.Text), Int(cmblayeronelinesuper.Text), (cmbTemplateOneliner.Text), True, CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub


    Private Sub ucOneLiner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialiseonelinerdata()
        enumeratefontsforall()

        System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "C:\casparcg\mydata\GoogleTranslate\Quickstart-4d2796c29251.json")
        client = TranslationClient.Create()
        ListLanguageNames()
    End Sub
    Public Function ListLanguageNames() As IList(Of Language)
        cmblanguage.Items.Clear()
        Dim languages As IList(Of Language)
        Try
            languages = client.ListLanguages(target:="en")
            For Each language In languages
                cmblanguage.Items.Add(language.Code & " (" & language.Name & ")")
            Next
            Return languages
        Catch ex As Exception
            'Return ""
        End Try

    End Function


    Sub enumeratefontsforall()
        On Error Resume Next
        Dim InstalledFonts As New Drawing.Text.InstalledFontCollection
        Dim fontfamilies() As FontFamily = InstalledFonts.Families()
        For Each fontFamily As FontFamily In fontfamilies
            cmbfonthtmloneliner.Items.Add(fontFamily.Name)
        Next
    End Sub
    Sub initialiseonelinerdata()
        On Error Resume Next
        dgvonelinesuper.Rows.Add(8)
        dgvonelinesuperTranslated.Rows.Add(8)
        Me.dgvonelinesuper.Item(0, 0).Value = "When nothing is sure, Everything is possible."
        Me.dgvonelinesuper.Item(0, 1).Value = "People lie, Actions don't."
        Me.dgvonelinesuper.Item(0, 2).Value = "Hurt me with the truth but don't comfort me with a lie"
        Me.dgvonelinesuper.Item(0, 3).Value = "When you start believing, it seems to happen."
        Me.dgvonelinesuper.Item(0, 4).Value = "The best apology Is Changed Behavior."
        Me.dgvonelinesuper.Item(0, 5).Value = "our mind knows everything, you learn to ask."
    End Sub

    Private Sub cmdhidegboneliner_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Private Sub cmdonelinesuperstophtml_Click(sender As Object, e As EventArgs) Handles cmdonelinesuperstophtml.Click
        On Error Resume Next
        CasparDevice.SendString("stop " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text))

    End Sub

    Function replacestring(str As String) As String
        str = Replace(str, " ", Chr(2))
        str = Replace(str, "\", Chr(5))
        Return str
    End Function
    Private Sub cmdonelinesuperplayhtml_Click(sender As Object, e As EventArgs) Handles cmdonelinesuperplayhtml.Click
        On Error Resume Next

        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " [HTML] " & """" & "file:///C:/casparcg/mydata/html/oneliner.html" & """")

        If chkPlayFromTraslatedGrigHTML.Checked Then
            If chkbase64htmloneliner.Checked Then
                Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes((replacestring(dgvonelinesuperTranslated.CurrentRow.Cells(0).Value)))
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " marqueedatabase64('" & System.Convert.ToBase64String(array) & "')")
            Else
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " marqueedata('" & (replacestring1(dgvonelinesuperTranslated.CurrentRow.Cells(0).Value)) & "')")
            End If
        Else
            If chkbase64htmloneliner.Checked Then
                Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes((replacestring(dgvonelinesuper.CurrentRow.Cells(0).Value)))
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " marqueedatabase64('" & System.Convert.ToBase64String(array) & "')")
            Else
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " marqueedata('" & (replacestring1(dgvonelinesuper.CurrentRow.Cells(0).Value)) & "')")
            End If
        End If

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " stripy('" & nyhtmloneliner.Value & "%')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " Tickery('" & nyhtmltextoneliner.Value & "%')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " fontsize('" & nsizehtmloneliner.Value & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " font('" & Replace(cmbfonthtmloneliner.Text, " ", Chr(2)) & "')")

        If chkitalic.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " fontitalic('" & "italic" & "')")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " fontitalic('" & "normal" & "')")
        End If

        If chkBold.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " fontbold('" & "bold" & "')")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " fontbold('" & "normal" & "')")
        End If

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " fontcolor('" & ColorTranslator.ToHtml(cmdstripcolorhtmloneliner.ForeColor) & "')")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " stripcolor('" & ColorTranslator.ToHtml(cmdstripcolorhtmloneliner.BackColor) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " stripheight('" & nheighthtmloneliner.Value & "')")

    End Sub

    Private Sub nyhtmloneliner_ValueChanged(sender As Object, e As EventArgs) Handles nyhtmloneliner.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " stripy('" & nyhtmloneliner.Value & "%')")

    End Sub

    Private Sub nyhtmltextoneliner_ValueChanged(sender As Object, e As EventArgs) Handles nyhtmltextoneliner.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " Tickery('" & nyhtmltextoneliner.Value & "%')")

    End Sub

    Private Sub nsizehtmloneliner_ValueChanged(sender As Object, e As EventArgs) Handles nsizehtmloneliner.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " fontsize('" & nsizehtmloneliner.Value & "')")


    End Sub

    Private Sub cmbfonthtmloneliner_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfonthtmloneliner.SelectedIndexChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " font('" & Replace(cmbfonthtmloneliner.Text, " ", Chr(2)) & "')")

    End Sub

    Private Sub chkitalic_CheckedChanged(sender As Object, e As EventArgs) Handles chkitalic.CheckedChanged
        On Error Resume Next
        If chkitalic.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " fontitalic('" & "italic" & "')")

        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " fontitalic('" & "normal" & "')")

        End If

    End Sub

    Private Sub chkBold_CheckedChanged(sender As Object, e As EventArgs) Handles chkBold.CheckedChanged
        On Error Resume Next
        If chkBold.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " fontbold('" & "bold" & "')")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " fontbold('" & "normal" & "')")
        End If
    End Sub

    Private Sub cmdcolorhtmloneliner_Click(sender As Object, e As EventArgs) Handles cmdcolorhtmloneliner.Click
        On Error Resume Next

        Dim aa As New ColorDialog
        If (aa.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdcolorhtmloneliner.ForeColor = aa.Color
            cmdstripcolorhtmloneliner.ForeColor = aa.Color

            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " fontcolor('" & ColorTranslator.ToHtml(cmdstripcolorhtmloneliner.ForeColor) & "')")
        End If
    End Sub

    Private Sub cmdstripcolorhtmloneliner_Click(sender As Object, e As EventArgs) Handles cmdstripcolorhtmloneliner.Click
        On Error Resume Next

        Dim aa As New ColorDialog
        If (aa.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdcolorhtmloneliner.BackColor = aa.Color
            cmdstripcolorhtmloneliner.BackColor = aa.Color

            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " stripcolor('" & ColorTranslator.ToHtml(cmdstripcolorhtmloneliner.BackColor) & "')")
        End If
    End Sub

    Private Sub nheighthtmloneliner_ValueChanged(sender As Object, e As EventArgs) Handles nheighthtmloneliner.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " stripheight('" & nheighthtmloneliner.Value & "')")

    End Sub

    Private Sub chkbase64htmloneliner_CheckedChanged(sender As Object, e As EventArgs) Handles chkbase64htmloneliner.CheckedChanged
        On Error Resume Next
        If chkbase64htmloneliner.Checked Then
            Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(dgvonelinesuper.CurrentRow.Cells(0).Value)
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " marqueedatabase64('" & System.Convert.ToBase64String(array) & "')")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " marqueedata('" & WebUtility.HtmlEncode(dgvonelinesuper.CurrentRow.Cells(0).Value) & "')")
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        On Error Resume Next
        newdgvoneliner()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        On Error Resume Next
        openfileoneliner()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        On Error Resume Next
        savefileoneliner()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        On Error Resume Next
        deletecliponeliner()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        On Error Resume Next
        copyoneliner()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        insertcopiedoneliner()
    End Sub

    Private Sub MenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip1.MouseHover
        MakeMenuDropDownWhenParrented(sender)
    End Sub

    Private Async Sub cmdTranslate_Click(sender As Object, e As EventArgs) Handles cmdTranslate.Click
        dgvonelinesuperTranslated.Rows.Clear()
        dgvonelinesuperTranslated.Rows.Add(dgvonelinesuper.RowCount)
        Try
            For i = 0 To dgvonelinesuper.RowCount - 1
                dgvonelinesuperTranslated.Rows(i).Cells(0).Value = Await translate(dgvonelinesuper.Rows(i).Cells(0).Value)
            Next
        Catch ex As Exception
        End Try
    End Sub
    Async Function translate(bb As String) As Threading.Tasks.Task(Of String)
        Dim aa As String = (Await client.TranslateTextAsync(bb, Split(cmblanguage.Text, " ")(0))).TranslatedText
        Return aa
    End Function

    Private Sub cmdGetLanguage_Click(sender As Object, e As EventArgs) Handles cmdGetLanguage.Click
        ListLanguageNames()
    End Sub

    Private Async Sub dgvonelinesuper_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvonelinesuper.CellContentClick
        Try
            If dgvonelinesuper.Columns(e.ColumnIndex).Name = "colTranslate" Then
                dgvonelinesuperTranslated.Rows(dgvonelinesuper.CurrentRow.Index).Cells(0).Value = Await translate(dgvonelinesuper.CurrentRow.Cells(0).Value)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdfittextoneliner_Click(sender As Object, e As EventArgs) Handles cmdfittextoneliner.Click
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " fit1()")

    End Sub

    Private Sub cmdRCCPlayer1_Click(sender As Object, e As EventArgs) Handles cmdRCCPlayer1.Click
        Try
            Dim data1
            If chkPlayFromTraslatedGrigRCC.Checked Then
                data1 = New rccData With {.key = txtvariable1.Text, .value = dgvonelinesuperTranslated.CurrentRow.Cells(0).Value, .type = "text"}
            Else
                data1 = New rccData With {.key = txtvariable1.Text, .value = dgvonelinesuper.CurrentRow.Cells(0).Value, .type = "text"}
            End If
            Dim allData = {data1}
            Dim postData As String = "layerNumber=" & cmblayeronelinesuper.Text & "&pageName=" & txtTemplatename.Text & "&data=" & JsonConvert.SerializeObject(allData)
            Dim data As Byte() = System.Text.Encoding.UTF8.GetBytes(postData)
            Dim url As String = "http://localhost:8080/recallPage"
            client1.Headers.Add("Content-Type", "application/x-www-form-urlencoded")
            client1.UploadData(url, data)
        Catch ex As Exception

        End Try
    End Sub

    Private Class rccData
        Public key As String
        Public value As String
        Public type As String
    End Class

    Private Sub cmdRCCStop1_Click(sender As Object, e As EventArgs) Handles cmdRCCStop1.Click
        Try
            Dim postData As String = "layerNumber=" & cmblayeronelinesuper.Text
            Dim data As Byte() = System.Text.Encoding.UTF8.GetBytes(postData)
            Dim url As String = "http://localhost:8080/stopGraphics"
            client1.Headers.Add("Content-Type", "application/x-www-form-urlencoded")
            client1.UploadData(url, data)
        Catch ex As Exception

        End Try
    End Sub
End Class
