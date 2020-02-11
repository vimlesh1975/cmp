Imports System.IO
Imports System.Net

Public Class ucTwoLiner

    Sub newdgvtwoliner()
        On Error Resume Next
        dgvtwolinesuper.Rows.Clear()
        dgvtwolinesuper.Rows.Add(7)
        Me.dgvtwolinesuper.Columns(0).HeaderText = "new playlist"
    End Sub

    Sub openfiletwoliner()
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog
        ofd2.InitialDirectory = "c:\casparcg\mydata\twoliner\"
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)

                dgvtwolinesuper.Rows.Clear()

                Dim g As Integer = 0
                Dim li As String
                Do Until sr.EndOfStream = True
                    li = sr.ReadLine()
                    dgvtwolinesuper.Rows.Add()
                    Dim xyz As Array = Split(li, Chr(2))
                    dgvtwolinesuper.Rows(g).Cells(0).Value = xyz(0)

                    g = g + 1
                Loop
                sr.Close()
            End Using
            Me.dgvtwolinesuper.Columns(0).HeaderText = ofd2.FileName
        End If
    End Sub

    Private Sub savetstwoliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub savefiletwoliner()
        On Error Resume Next

        osd2.InitialDirectory = "c:\casparcg\mydata\twoliner\"
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvtwolinesuper.Rows.Count = 0 Then
                    sw.Write("")
                Else

                    Dim f As Integer = 0
                    Do Until f = dgvtwolinesuper.Rows.Count

                        sw.WriteLine(dgvtwolinesuper.Rows(f).Cells(0).Value & Chr(2))
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            Me.dgvtwolinesuper.Columns(0).HeaderText = osd2.FileName
        End If
    End Sub

    Private Sub cuttstwoliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub deletecliptwoliner()
        On Error Resume Next
        dgvtwolinesuper.Rows.RemoveAt(dgvtwolinesuper.CurrentRow.Index)
    End Sub

    Private Sub copytstwoliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub copytwoliner()
        On Error Resume Next
        tempRow = Me.dgvtwolinesuper.CurrentRow
    End Sub

    Private Sub pastetstwoliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub insertcopiedtwoliner()
        On Error Resume Next
        Dim curRow As Integer = Me.dgvtwolinesuper.CurrentCell.RowIndex
        dgvtwolinesuper.Rows.Insert(dgvtwolinesuper.CurrentRow.Index)
        dgvtwolinesuper.CurrentCell = dgvtwolinesuper.Rows(curRow).Cells(0)
        Me.dgvtwolinesuper.Item(0, curRow).Value = tempRow.Cells(0).Value
        Me.dgvtwolinesuper.Item(1, curRow).Value = tempRow.Cells(1).Value
    End Sub

    Private Sub uptstwoliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uptstwoliner.Click
        On Error Resume Next
        clipmoveuptwoliner()
    End Sub
    Sub clipmoveuptwoliner()
        On Error Resume Next
        If Me.dgvtwolinesuper.CurrentCell.RowIndex <> 0 Then
            Dim curRow As Integer = Me.dgvtwolinesuper.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvtwolinesuper.CurrentRow
            Me.dgvtwolinesuper.Rows.Remove(myRow)
            Me.dgvtwolinesuper.Rows.Insert(curRow - 1, myRow)
            dgvtwolinesuper.CurrentCell = dgvtwolinesuper.Rows(curRow - 1).Cells(0)
        End If
    End Sub

    Private Sub downtstwoliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles downtstwoliner.Click
        clipmovedowntwoliner()
    End Sub
    Sub clipmovedowntwoliner()
        On Error Resume Next
        If Me.dgvtwolinesuper.CurrentCell.RowIndex <> dgvtwolinesuper.Rows.Count - 2 Then
            Dim curRow As Integer = Me.dgvtwolinesuper.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvtwolinesuper.CurrentRow
            Me.dgvtwolinesuper.Rows.Remove(myRow)
            Me.dgvtwolinesuper.Rows.Insert(curRow + 1, myRow)
            dgvtwolinesuper.CurrentCell = dgvtwolinesuper.Rows(curRow + 1).Cells(0)

        End If
    End Sub

    Private Sub addtstwoliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addtstwoliner.Click
        On Error Resume Next
        clipinserttwoliner()
    End Sub
    Sub clipinserttwoliner()
        On Error Resume Next
        dgvtwolinesuper.Rows.Insert(dgvtwolinesuper.CurrentRow.Index)
        dgvtwolinesuper.Rows(dgvtwolinesuper.CurrentRow.Index - 1).Cells(3).Value = 1
    End Sub

    Private Sub removetstwoliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removetstwoliner.Click
        On Error Resume Next
        deletecliptwoliner()
    End Sub



    Private Sub ucTwoLiner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialisetwolinerdata()
        enumeratefontsforall()
    End Sub
    Sub enumeratefontsforall()
        On Error Resume Next
        Dim InstalledFonts As New Drawing.Text.InstalledFontCollection
        Dim fontfamilies() As FontFamily = InstalledFonts.Families()
        For Each fontFamily As FontFamily In fontfamilies
            cmbfonthtmloneliner.Items.Add(fontFamily.Name)
            cmbfonthtmloneliner2.Items.Add(fontFamily.Name)
        Next
    End Sub
    Sub initialisetwolinerdata()
        On Error Resume Next
        dgvtwolinesuper.Rows.Add(8)
        Me.dgvtwolinesuper.Item(0, 0).Value = "Vimlesh Kumar Tanti"
        Me.dgvtwolinesuper.Item(0, 1).Value = "Engineering Assistant, Doordarsahan Kendra, Mumbai, India"
        Me.dgvtwolinesuper.Item(0, 2).Value = "Ram Lal Tripathi"
        Me.dgvtwolinesuper.Item(0, 3).Value = "Senior Lab Assistant"
        Me.dgvtwolinesuper.Item(0, 4).Value = "میرا نام تشخیص ہے"
        Me.dgvtwolinesuper.Item(0, 5).Value = "मेरा नाम विमलेश है"
    End Sub

    Private Sub cmdhidegbtwoliner_Click(sender As Object, e As EventArgs) 
        Me.Hide()
    End Sub

    Private Sub cmdtwolinesuperplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtwolinesuperplay.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        Dim array1() As Byte = System.Text.Encoding.UTF8.GetBytes(dgvtwolinesuper.CurrentRow.Cells(0).Value)
        If dgvtwolinesuper.CurrentRow.Cells(0).Value = "" Then
            CasparCGDataCollection.SetData("x" & txtvariable1.Text, "")
        Else
            CasparCGDataCollection.SetData("x" & txtvariable1.Text, System.Convert.ToBase64String(array1))
        End If


        CasparCGDataCollection.SetData(txtvariable1.Text, dgvtwolinesuper.CurrentRow.Cells(0).Value)


        Dim array2() As Byte = System.Text.Encoding.UTF8.GetBytes(dgvtwolinesuper.Rows(dgvtwolinesuper.CurrentRow.Index + 1).Cells(0).Value)

        If dgvtwolinesuper.Rows(dgvtwolinesuper.CurrentRow.Index + 1).Cells(0).Value = "" Then
            CasparCGDataCollection.SetData("x" & txtvariable2.Text, "")
        Else
            CasparCGDataCollection.SetData("x" & txtvariable2.Text, System.Convert.ToBase64String(array2))
        End If


        CasparCGDataCollection.SetData(txtvariable2.Text, dgvtwolinesuper.Rows(dgvtwolinesuper.CurrentRow.Index + 1).Cells(0).Value)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayertwolinesuper.Text), Int(cmblayertwolinesuper.Text), (cmbTemplateTwoliner.Text), True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdtwolinesupernext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtwolinesupernext.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Next(Int(cmblayertwolinesuper.Text), Int(cmblayertwolinesuper.Text))
    End Sub

    Private Sub cmdtwolinesuperstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtwolinesuperstop.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayertwolinesuper.Text), Int(cmblayertwolinesuper.Text))

    End Sub
    ' Html code-------------------------------

    Function replacestring(str As String) As String
        str = Replace(str, " ", Chr(2))
        str = Replace(str, "\", Chr(5))
        Return str
    End Function

    Private Sub cmdonelinesuperplayhtml_Click(sender As Object, e As EventArgs) Handles cmdonelinesuperplayhtml.Click
        On Error Resume Next

        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " [HTML] " & """" & "file:///C:/casparcg/mydata/html/twoliner.html" & """")

        If chkbase64htmloneliner.Checked Then
            Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(replacestring(dgvtwolinesuper.CurrentRow.Cells(0).Value))
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " marqueedatabase64('" & System.Convert.ToBase64String(array) & "')")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " marqueedata('" & (replacestring1(dgvtwolinesuper.CurrentRow.Cells(0).Value)) & "')")
        End If

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " stripy('" & nyhtmloneliner.Value & "%')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " Tickery('" & nyhtmltextoneliner.Value & "%')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontsize('" & nsizehtmloneliner.Value & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " font('" & Replace(cmbfonthtmloneliner.Text, " ", Chr(2)) & "')")


        If chkitalic.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontitalic('" & "italic" & "')")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontitalic('" & "normal" & "')")
        End If


        If chkBold.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontbold('" & "bold" & "')")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontbold('" & "normal" & "')")
        End If



        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontcolor('" & ColorTranslator.ToHtml(cmdcolorhtmloneliner.ForeColor) & "')")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " stripcolor('" & ColorTranslator.ToHtml(cmdcolorhtmloneliner.BackColor) & "')")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " stripheight('" & nheighthtmloneliner.Value & "')")


        '2nd line
        Dim zz = dgvtwolinesuper.Rows(dgvtwolinesuper.CurrentRow.Index + 1).Cells(0).Value

        If chkbase64htmloneliner2.Checked Then
            Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(zz)
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " marqueedatabase642('" & System.Convert.ToBase64String(array) & "')")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " marqueedata2('" & (replacestring1(zz)) & "')")
        End If

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " stripy2('" & nyhtmloneliner2.Value & "%')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " Tickery2('" & nyhtmltextoneliner2.Value & "%')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontsize2('" & nsizehtmloneliner2.Value & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " font2('" & Replace(cmbfonthtmloneliner2.Text, " ", Chr(2)) & "')")


        If chkitalic2.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontitalic2('" & "italic" & "')")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontitalic2('" & "normal" & "')")
        End If


        If chkBold2.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontbold2('" & "bold" & "')")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontbold2('" & "normal" & "')")
        End If


        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontcolor2('" & ColorTranslator.ToHtml(cmdcolorhtmloneliner2.ForeColor) & "')")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " stripcolor2('" & ColorTranslator.ToHtml(cmdcolorhtmloneliner2.BackColor) & "')")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " stripheight2('" & nheighthtmloneliner2.Value & "')")



    End Sub


    Private Sub nyhtmloneliner_ValueChanged(sender As Object, e As EventArgs) Handles nyhtmloneliner.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " stripy('" & nyhtmloneliner.Value & "%')")

    End Sub

    Private Sub nyhtmltextoneliner_ValueChanged(sender As Object, e As EventArgs) Handles nyhtmltextoneliner.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " Tickery('" & nyhtmltextoneliner.Value & "%')")

    End Sub

    Private Sub nsizehtmloneliner_ValueChanged(sender As Object, e As EventArgs) Handles nsizehtmloneliner.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontsize('" & nsizehtmloneliner.Value & "')")


    End Sub

    Private Sub cmbfonthtmloneliner_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfonthtmloneliner.SelectedIndexChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " font('" & Replace(cmbfonthtmloneliner.Text, " ", Chr(2)) & "')")

    End Sub

    Private Sub chkitalic_CheckedChanged(sender As Object, e As EventArgs) Handles chkitalic.CheckedChanged
        On Error Resume Next
        If chkitalic.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontitalic('" & "italic" & "')")

        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontitalic('" & "normal" & "')")

        End If

    End Sub

    Private Sub chkBold_CheckedChanged(sender As Object, e As EventArgs) Handles chkBold.CheckedChanged
        On Error Resume Next
        If chkBold.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontbold('" & "bold" & "')")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontbold('" & "normal" & "')")
        End If
    End Sub

    Private Sub cmdcolorhtmloneliner_Click(sender As Object, e As EventArgs) Handles cmdcolorhtmloneliner.Click
        On Error Resume Next

        Dim aa As New ColorDialog
        If (aa.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdcolorhtmloneliner.ForeColor = aa.Color
            cmdstripcolorhtmloneliner.ForeColor = aa.Color

            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontcolor('" & ColorTranslator.ToHtml(cmdstripcolorhtmloneliner.ForeColor) & "')")
        End If
    End Sub

    Private Sub cmdstripcolorhtmloneliner_Click(sender As Object, e As EventArgs) Handles cmdstripcolorhtmloneliner.Click
        On Error Resume Next

        Dim aa As New ColorDialog
        If (aa.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdcolorhtmloneliner.BackColor = aa.Color
            cmdstripcolorhtmloneliner.BackColor = aa.Color


            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " stripcolor('" & ColorTranslator.ToHtml(cmdstripcolorhtmloneliner.BackColor) & "')")
        End If
    End Sub

    Private Sub nheighthtmloneliner_ValueChanged(sender As Object, e As EventArgs) Handles nheighthtmloneliner.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " stripheight('" & nheighthtmloneliner.Value & "')")

    End Sub

    Private Sub cmdonelinesuperstophtml_Click(sender As Object, e As EventArgs) Handles cmdonelinesuperstophtml.Click
        On Error Resume Next
        CasparDevice.SendString("stop " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text))

    End Sub

    Private Sub chkbase64htmloneliner_CheckedChanged(sender As Object, e As EventArgs) Handles chkbase64htmloneliner.CheckedChanged
        On Error Resume Next
        If chkbase64htmloneliner.Checked Then
            Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(dgvtwolinesuper.CurrentRow.Cells(0).Value)
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " marqueedatabase64('" & System.Convert.ToBase64String(array) & "')")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " marqueedata('" & WebUtility.HtmlEncode(dgvtwolinesuper.CurrentRow.Cells(0).Value) & "')")
        End If
    End Sub

    Private Sub chkbase64htmloneliner2_CheckedChanged(sender As Object, e As EventArgs) Handles chkbase64htmloneliner2.CheckedChanged
        On Error Resume Next
        If chkbase64htmloneliner2.Checked Then
            Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(dgvtwolinesuper.Rows(dgvtwolinesuper.CurrentRow.Index + 1).Cells(0).Value)
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " marqueedatabase642('" & System.Convert.ToBase64String(array) & "')")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " marqueedata2('" & WebUtility.HtmlEncode(dgvtwolinesuper.Rows(dgvtwolinesuper.CurrentRow.Index + 1).Cells(0).Value) & "')")
        End If
    End Sub

    Private Sub cmbfonthtmloneliner2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfonthtmloneliner2.SelectedIndexChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " font2('" & Replace(cmbfonthtmloneliner2.Text, " ", Chr(2)) & "')")

    End Sub

    Private Sub nsizehtmloneliner2_ValueChanged(sender As Object, e As EventArgs) Handles nsizehtmloneliner2.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontsize2('" & nsizehtmloneliner2.Value & "')")

    End Sub

    Private Sub chkitalic2_CheckedChanged(sender As Object, e As EventArgs) Handles chkitalic2.CheckedChanged
        On Error Resume Next
        If chkitalic2.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontitalic2('" & "italic" & "')")

        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontitalic2('" & "normal" & "')")

        End If
    End Sub

    Private Sub chkBold2_CheckedChanged(sender As Object, e As EventArgs) Handles chkBold2.CheckedChanged
        On Error Resume Next
        If chkBold2.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontbold2('" & "bold" & "')")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontbold2('" & "normal" & "')")
        End If
    End Sub

    Private Sub nyhtmltextoneliner2_ValueChanged(sender As Object, e As EventArgs) Handles nyhtmltextoneliner2.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " Tickery2('" & nyhtmltextoneliner2.Value & "%')")

    End Sub

    Private Sub cmdcolorhtmloneliner2_Click(sender As Object, e As EventArgs) Handles cmdcolorhtmloneliner2.Click
        On Error Resume Next

        Dim aa As New ColorDialog
        If (aa.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdcolorhtmloneliner2.ForeColor = aa.Color
            cmdstripcolorhtmloneliner2.ForeColor = aa.Color


            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " fontcolor2('" & ColorTranslator.ToHtml(cmdcolorhtmloneliner2.ForeColor) & "')")
        End If
    End Sub

    Private Sub nheighthtmloneliner2_ValueChanged(sender As Object, e As EventArgs) Handles nheighthtmloneliner2.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " stripheight2('" & nheighthtmloneliner2.Value & "')")

    End Sub

    Private Sub cmdstripcolorhtmloneliner2_Click(sender As Object, e As EventArgs) Handles cmdstripcolorhtmloneliner2.Click
        On Error Resume Next

        Dim aa As New ColorDialog
        If (aa.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdcolorhtmloneliner2.BackColor = aa.Color
            cmdstripcolorhtmloneliner2.BackColor = aa.Color


            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " stripcolor2('" & ColorTranslator.ToHtml(cmdcolorhtmloneliner2.BackColor) & "')")
        End If
    End Sub

    Private Sub nyhtmloneliner2_ValueChanged(sender As Object, e As EventArgs) Handles nyhtmloneliner2.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayertwolinesuper.Text) & " stripy2('" & nyhtmloneliner2.Value & "%')")

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        On Error Resume Next
        newdgvtwoliner()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        On Error Resume Next
        openfiletwoliner()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        On Error Resume Next
        savefiletwoliner()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        On Error Resume Next
        deletecliptwoliner()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        On Error Resume Next
        copytwoliner()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        On Error Resume Next
        insertcopiedtwoliner()
    End Sub

    Private Sub MenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip1.MouseHover
        MakeMenuDropDownWhenParrented(sender)
    End Sub
End Class
