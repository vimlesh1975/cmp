Imports System.IO
Imports System.Net

Imports Google.Cloud.Translation.V2
Imports System
Public Class ucFullPageCaption
    Dim client As TranslationClient
    Sub newdgvoneliner()
        On Error Resume Next
        dgvFullPageCaption.Rows.Clear()
        dgvFullPageCaption.Rows.Add(7)
        Me.dgvFullPageCaption.Columns(0).HeaderText = "new playlist"
    End Sub
    Private Sub opentsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Sub openfileoneliner()
        On Error Resume Next
        ofd2.InitialDirectory = "c:\casparcg\mydata\fullpagecaption\"
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)

                dgvFullPageCaption.Rows.Clear()

                Dim g As Integer = 0
                Dim li As String
                Do Until sr.EndOfStream = True
                    li = sr.ReadLine()
                    dgvFullPageCaption.Rows.Add()
                    Dim xyz As Array = Split(li, Chr(2))
                    dgvFullPageCaption.Rows(g).Cells(0).Value = xyz(0)
                    dgvFullPageCaption.Rows(g).Cells(1).Value = xyz(1)
                    g = g + 1
                Loop
                sr.Close()
            End Using
            Me.dgvFullPageCaption.Columns(0).HeaderText = ofd2.FileName
        End If
    End Sub

    Private Sub savetsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub savefileoneliner()
        On Error Resume Next
        osd2.InitialDirectory = "c:\casparcg\mydata\fullpagecaption\"
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvFullPageCaption.Rows.Count = 0 Then
                    sw.Write("")
                Else

                    Dim f As Integer = 0
                    Do Until f = dgvFullPageCaption.Rows.Count
                        sw.WriteLine(dgvFullPageCaption.Rows(f).Cells(0).Value & Chr(2) & dgvFullPageCaption.Rows(f).Cells(1).Value & Chr(2))
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            Me.dgvFullPageCaption.Columns(0).HeaderText = osd2.FileName
        End If
    End Sub
    Sub deletecliponeliner()
        On Error Resume Next
        dgvFullPageCaption.Rows.RemoveAt(dgvFullPageCaption.CurrentRow.Index)
    End Sub

    Private Sub copytsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub copyoneliner()
        On Error Resume Next
        tempRow = Me.dgvFullPageCaption.CurrentRow
    End Sub
    Private Sub pasteoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub insertcopiedoneliner()
        On Error Resume Next
        Dim curRow As Integer = Me.dgvFullPageCaption.CurrentCell.RowIndex
        dgvFullPageCaption.Rows.Insert(dgvFullPageCaption.CurrentRow.Index)
        dgvFullPageCaption.CurrentCell = dgvFullPageCaption.Rows(curRow).Cells(0)
        Me.dgvFullPageCaption.Item(0, curRow).Value = tempRow.Cells(0).Value
        Me.dgvFullPageCaption.Item(1, curRow).Value = tempRow.Cells(1).Value
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
        If Me.dgvFullPageCaption.CurrentCell.RowIndex <> dgvFullPageCaption.Rows.Count - 2 Then
            Dim curRow As Integer = Me.dgvFullPageCaption.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvFullPageCaption.CurrentRow
            Me.dgvFullPageCaption.Rows.Remove(myRow)
            Me.dgvFullPageCaption.Rows.Insert(curRow + 1, myRow)
            dgvFullPageCaption.CurrentCell = dgvFullPageCaption.Rows(curRow + 1).Cells(0)

        End If
    End Sub
    Private Sub addtsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addtsoneliner.Click
        On Error Resume Next
        clipinsertoneliner()
    End Sub
    Sub clipinsertoneliner()
        On Error Resume Next
        dgvFullPageCaption.Rows.Insert(dgvFullPageCaption.CurrentRow.Index)

    End Sub
    Private Sub removetsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removetsoneliner.Click
        On Error Resume Next
        deletecliponeliner()
    End Sub

    Sub clipmoveuponeliner()
        On Error Resume Next
        If Me.dgvFullPageCaption.CurrentCell.RowIndex <> 0 Then
            Dim curRow As Integer = Me.dgvFullPageCaption.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvFullPageCaption.CurrentRow
            Me.dgvFullPageCaption.Rows.Remove(myRow)
            Me.dgvFullPageCaption.Rows.Insert(curRow - 1, myRow)
            dgvFullPageCaption.CurrentCell = dgvFullPageCaption.Rows(curRow - 1).Cells(0)
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
        CasparCGDataCollection.SetData("xf0", dgvFullPageCaption.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("xf1", dgvFullPageCaption.CurrentRow.Cells(1).Value)
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
        dgvFullPageCaption.Rows.Add(3)
        dgvonelinesuperTranslated.Rows.Add(3)
        With dgvFullPageCaption
            .Rows(0).Cells(0).Value = "महाराष्ट्र में कब बनेगी सरकार? गतिरोध के बीच NCP की अहम बैठक आज"
            .Rows(0).Cells(1).Value = "महाराष्ट्र की सियासत में लगातार गरमाहट बनी हुई है. अब तक सरकार गठन पर तस्वीर साफ़ नहीं हुई है. शिवसेना, एनसीपी और कांग्रेस तीनों ने मिलकर न्यूनतम साझा कार्यक्रम बना लिया है."

            .Rows(1).Cells(0).Value = "अयोध्या: रिव्यू पिटीशन और 5 एकड़ जमीन पर मुस्लिम पर्सनल लॉ बोर्ड में असमंजस"
            .Rows(1).Cells(1).Value = "सुप्रीम कोर्ट का फैसला आने के बाद से ही अयोध्या मुद्दे पर मुस्लिम पर्सनल लॉ बोर्ड में दो राय बनी हुई है. सूत्रों की मानें तो रिव्यू पिटीशन दाखिल करने को लेकर सस्पेंस बना हुआ है, जबकि इस बात पर करीब सभी सदस्य एकमत हैं कि मस्जिद बनाने के लिए 5 एकड़ जमीन नहीं ली जानी चाहिए.."

            .Rows(2).Cells(0).Value = "Jharkhand Election 2019: कांग्रेस ने सरयू राय पर डाले डोरे, विपक्षी खेमे में हमदर्दी;"
            .Rows(2).Cells(1).Value = "रांची, राज्य ब्यूरो। Jharkhand Assembly Election 2019 भाजपा नेता सरयू राय को अब तक टिकट नहीं देना भाजपा की गले की फांस बनता जा रहा है। विपक्षी पर्टियां भी इस पर पैनी नजर बनाए हुए हैैं और सरयू राय को अपने पाले में करने की कोशिश कर रही है। कांग्रेस सरयू राय के प्रति सिंपैथी की भावना रख रही है। उम्मीद जताई जा रही है कि कांग्रेस सरयू राय के खिलाफ उम्मीदवार नहीं देगी। हालांकि सरयू राय ने किसी पार्टी से चुनाव लडऩे की बात नहीं कही है।"
        End With
    End Sub

    Private Sub cmdhidegboneliner_Click(sender As Object, e As EventArgs) 
        Me.Hide()
    End Sub
    Private Sub cmdonelinesuperstophtml_Click(sender As Object, e As EventArgs) Handles cmdonelinesuperstophtml.Click
        On Error Resume Next
        ' CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayeronelinesuper.Text), Int(cmblayeronelinesuper.Text))
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
                Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes((replacestring(dgvFullPageCaption.CurrentRow.Cells(0).Value)))
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " marqueedatabase64('" & System.Convert.ToBase64String(array) & "')")
            Else
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " marqueedata('" & (replacestring1(dgvFullPageCaption.CurrentRow.Cells(0).Value)) & "')")
            End If
        End If



        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " stripy('" & nyhtmloneliner.Value & "%')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " Tickery('" & nyhtmltextoneliner.Value & "%')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " fontsize('" & nsizehtmloneliner.Value & "')")
        'CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " font('" & Replace(cmbfonthtmloneliner.Text, " ", Chr(2)) & "')")
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
            Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(dgvFullPageCaption.CurrentRow.Cells(0).Value)
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " marqueedatabase64('" & System.Convert.ToBase64String(array) & "')")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayeronelinesuper.Text) & " marqueedata('" & WebUtility.HtmlEncode(dgvFullPageCaption.CurrentRow.Cells(0).Value) & "')")
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
        dgvonelinesuperTranslated.Rows.Add(dgvFullPageCaption.RowCount)
        Try
            For i = 0 To dgvFullPageCaption.RowCount - 1
                dgvonelinesuperTranslated.Rows(i).Cells(0).Value = Await translate(dgvFullPageCaption.Rows(i).Cells(0).Value)
                dgvonelinesuperTranslated.Rows(i).Cells(1).Value = Await translate(dgvFullPageCaption.Rows(i).Cells(1).Value)
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



    Private Sub Gboneliner_Enter(sender As Object, e As EventArgs) Handles gboneliner.Enter

    End Sub

    Private Sub CmdonelinesuperplayfromTranslatedGrid_Click(sender As Object, e As EventArgs) Handles cmdonelinesuperplayfromTranslatedGrid.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("xf0", dgvonelinesuperTranslated.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("xf1", dgvonelinesuperTranslated.CurrentRow.Cells(1).Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayeronelinesuper.Text), Int(cmblayeronelinesuper.Text), (cmbTemplateOneliner.Text), True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub


    Private Async Sub dgvonelinesuper_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFullPageCaption.CellContentClick
        Try
            If dgvFullPageCaption.Columns(e.ColumnIndex).Name = "colTranslate" Then
                dgvonelinesuperTranslated.Rows(dgvFullPageCaption.CurrentRow.Index).Cells(0).Value = Await translate(dgvFullPageCaption.CurrentRow.Cells(0).Value)
                dgvonelinesuperTranslated.Rows(dgvFullPageCaption.CurrentRow.Index).Cells(1).Value = Await translate(dgvFullPageCaption.CurrentRow.Cells(1).Value)

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
