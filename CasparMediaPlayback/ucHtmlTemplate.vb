Imports System.IO

Public Class ucHtmlTemplate
    Public brundownrowselectedchanged As Boolean = False
    Private Sub cmdadjusttimeofrundown_Click(sender As Object, e As EventArgs) Handles cmdadjusttimeofrundown.Click
        On Error Resume Next
        adjusttimeofrundown()
    End Sub
    Public Sub adjusttimeofrundown()
        On Error Resume Next
        Dim aa, bb As Date
        For iadjusttime = 0 To dgvrundown.Rows.Count - 1
            aa = dgvrundown.Rows(iadjusttime).Cells(5).Value
            bb = aa.AddMinutes(Val(txtadjusttimeofrundownmin.Text))
            bb = bb.AddSeconds(Val(txtadjusttimeofrundownsec.Text))
            dgvrundown.Rows(iadjusttime).Cells(5).Value = bb
        Next
    End Sub
    Private Sub cmdaddtorundown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaddtorundown.Click
        On Error Resume Next
        dgvrundown.Rows.Insert(dgvrundown.Rows.Count - 1)
        dgvrundown.CurrentRow.Cells(0).Value = dgvanytemplate.Rows(0).Cells(1).Value
        dgvrundown.CurrentRow.Cells(1).Value = lsttemplate.SelectedItem.ToString
        dgvrundown.CurrentRow.Cells(3).Value = cmblayertemplate.Text

        Dim ianytemplate As Integer
        CasparCGDataCollection.Clear() 'cgData.Clear()
        For ianytemplate = 0 To dgvanytemplate.Rows.Count - 1
            CasparCGDataCollection.SetData(dgvanytemplate.Rows(ianytemplate).Cells(0).Value, dgvanytemplate.Rows(ianytemplate).Cells(1).Value & "ddddd" & dgvanytemplate.Rows(ianytemplate).Cells(3).Value.ToString)

        Next
        dgvrundown.CurrentRow.Cells(4).Value = CasparCGDataCollection.ToXml
        If dgvrundown.CurrentRow.Index = 0 Then
            dgvrundown.CurrentRow.Cells(5).Value = Now.AddMinutes(1)
        Else
            dgvrundown.CurrentRow.Cells(5).Value = (dgvrundown.Rows(dgvrundown.CurrentRow.Index - 1).Cells(5).Value).AddMinutes(1)
        End If
        dgvrundown.CurrentRow.Cells(6).Value = 20
        Dim icurrentrow As Integer = dgvrundown.CurrentRow.Index
        dgvrundown.CurrentCell = dgvrundown.Rows(icurrentrow + 1).Cells(0)

    End Sub
    Private Sub playtsrundown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playtsrundown.Click
        On Error Resume Next
        playfromrundown()
    End Sub
    Sub playfromrundown()
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayertemplate.Text & " opacity 0")

        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & dgvrundown.CurrentRow.Cells(3).Value & " [HTML] " & """" & Replace(templatefullpath, "\", "/") & dgvrundown.CurrentRow.Cells(1).Value & """")

        Threading.Thread.Sleep(Val(txtupdatedelay.Text))
        anytemplateupdatefromrundown()
        Threading.Thread.Sleep(Val(txtupdatedelay.Text))
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayertemplate.Text & " opacity 1")
    End Sub
    Sub playrundownforvideo()
        On Error Resume Next
        CasparCGDataCollection.Clear()
        For ianytemplate = 0 To dgvanytemplate.Rows.Count
            CasparCGDataCollection.SetData(dgvanytemplate.Rows(ianytemplate).Cells(0).Value, dgvanytemplate.Rows(ianytemplate).Cells(1).Value)
        Next
        CasparDevice.SendString("cg " & g_int_ChannelNumber & "-21 add 21 " & """" & dgvrundown.CurrentRow.Cells(1).Value & """" & " 1 " & """" & CasparCGDataCollection.ToAMCPEscapedXml & """" & vbCrLf)
        dgvrundown.CurrentCell = dgvrundown.Rows(dgvrundown.CurrentRow.Index + 1).Cells(0)
    End Sub

    Private Sub nexttsrundown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nexttsrundown.Click
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & dgvrundown.CurrentRow.Cells(3).Value & " next()")
    End Sub
    Private Sub stoptsrundown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stoptsrundown.Click

        On Error Resume Next

        CasparDevice.SendString("stop " & g_int_ChannelNumber & "-" & dgvrundown.CurrentRow.Cells(3).Value)

    End Sub
    Private Sub cmdrundowninvoke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrundowninvoke.Click
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & dgvrundown.CurrentRow.Cells(3).Value & " " & cmbrundowninvoke.Text)
    End Sub
    Private Sub newtsrundown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        newdgvrundown()
    End Sub
    Sub newdgvrundown()
        On Error Resume Next
        dgvrundown.Rows.Clear()
        dgvrundown.Rows.Add(1)
        Me.dgvrundown.Columns(0).HeaderText = "new rundown"
    End Sub

    Private Sub opentsrundown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        openfilerundown()
    End Sub
    Sub openfilerundown()
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog
        ofd2.InitialDirectory = "c:\casparcg\mydata\rundownHTML\"
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)

                dgvrundown.Rows.Clear()

                Dim g As Integer = 0
                Dim li As String
                Do Until sr.EndOfStream = True
                    li = sr.ReadLine()
                    dgvrundown.Rows.Add()
                    Dim xyz As Array = Split(li, Chr(2))
                    dgvrundown.Rows(g).Cells(0).Value = xyz(0)
                    dgvrundown.Rows(g).Cells(1).Value = xyz(1)

                    dgvrundown.Rows(g).Cells(2).Value = xyz(2)
                    dgvrundown.Rows(g).Cells(3).Value = xyz(3)
                    dgvrundown.Rows(g).Cells(4).Value = Replace(xyz(4), "vbnewline", vbNewLine)
                    dgvrundown.Rows(g).Cells(5).Value = xyz(5)
                    dgvrundown.Rows(g).Cells(6).Value = xyz(6)

                    g = g + 1
                Loop
                sr.Close()
            End Using
            Me.dgvrundown.Columns(0).HeaderText = ofd2.FileName
        End If
    End Sub

    Public Sub openfilerundown(filename As String)
        On Error Resume Next

        Using sr As StreamReader = New StreamReader(filename)

            dgvrundown.Rows.Clear()

            Dim g As Integer = 0
            Dim li As String
            Do Until sr.EndOfStream = True
                li = sr.ReadLine()
                dgvrundown.Rows.Add()
                Dim xyz As Array = Split(li, Chr(2))
                dgvrundown.Rows(g).Cells(0).Value = xyz(0)
                dgvrundown.Rows(g).Cells(1).Value = xyz(1)

                dgvrundown.Rows(g).Cells(2).Value = xyz(2)
                dgvrundown.Rows(g).Cells(3).Value = xyz(3)
                dgvrundown.Rows(g).Cells(4).Value = Replace(xyz(4), "vbnewline", vbNewLine)
                dgvrundown.Rows(g).Cells(5).Value = xyz(5)
                dgvrundown.Rows(g).Cells(6).Value = xyz(6)

                g = g + 1
            Loop
            sr.Close()
        End Using
        Me.dgvrundown.Columns(0).HeaderText = ofd2.FileName

    End Sub

    Private Sub savetsrundown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        savefilerundown()
    End Sub
    Sub savefilerundown()
        ' On Error Resume Next
        osd2.InitialDirectory = "c:\casparcg\mydata\rundownHTML\"
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvrundown.Rows.Count = 0 Then
                    sw.Write("")
                Else

                    Dim f As Integer = 0
                    Do Until f = dgvrundown.Rows.Count
                        sw.WriteLine(dgvrundown.Rows(f).Cells(0).Value & Chr(2) & dgvrundown.Rows(f).Cells(1).Value & Chr(2) & dgvrundown.Rows(f).Cells(2).Value & Chr(2) & dgvrundown.Rows(f).Cells(3).Value & Chr(2) & Replace(dgvrundown.Rows(f).Cells(4).Value, vbNewLine, "vbnewline") & Chr(2) & Format(CType(dgvrundown.Rows(f).Cells(5).Value, DateTime), "H:mm:ss") & Chr(2) & dgvrundown.Rows(f).Cells(6).Value)
                        'sw.WriteLine(dgvrundown.Rows(f).Cells(0).Value & Chr(2))
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            Me.dgvrundown.Columns(0).HeaderText = osd2.FileName
        End If
    End Sub

    Private Sub cuttsrundown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        deleterundown()
    End Sub
    Sub deleterundown()
        On Error Resume Next
        dgvrundown.Rows.RemoveAt(dgvrundown.CurrentRow.Index)
    End Sub
    Private Sub copytsrundown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        copyrundown()
    End Sub
    Sub copyrundown()
        On Error Resume Next
        tempRow = Me.dgvrundown().CurrentRow
    End Sub
    Private Sub pastetsrundown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        insertcopiedrundown()
    End Sub

    Sub insertcopiedrundown()
        On Error Resume Next
        Dim curRow As Integer = Me.dgvrundown.CurrentCell.RowIndex
        dgvrundown.Rows.Insert(dgvrundown.CurrentRow.Index)
        dgvrundown.CurrentCell = dgvrundown.Rows(curRow).Cells(0)
        For ii = 0 To dgvrundown.RowCount - 1
            Me.dgvrundown.Item(ii, curRow).Value = tempRow.Cells(ii).Value
        Next

    End Sub

    Private Sub uptsrundown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uptsrundown.Click
        On Error Resume Next
        clipmoveuprundown()
    End Sub
    Sub clipmoveuprundown()
        On Error Resume Next
        If Me.dgvrundown.CurrentCell.RowIndex <> 0 Then
            Dim curRow As Integer = Me.dgvrundown.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvrundown.CurrentRow
            Me.dgvrundown.Rows.Remove(myRow)
            Me.dgvrundown.Rows.Insert(curRow - 1, myRow)
            dgvrundown.CurrentCell = dgvrundown.Rows(curRow - 1).Cells(0)
        End If
    End Sub
    Private Sub downtsrundown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles downtsrundown.Click
        On Error Resume Next
        clipmovedownrundown()
    End Sub
    Sub clipmovedownrundown()
        On Error Resume Next
        If Me.dgvrundown.CurrentCell.RowIndex <> dgvrundown.Rows.Count - 2 Then
            Dim curRow As Integer = Me.dgvrundown.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvrundown.CurrentRow
            Me.dgvrundown.Rows.Remove(myRow)
            Me.dgvrundown.Rows.Insert(curRow + 1, myRow)
            dgvrundown.CurrentCell = dgvrundown.Rows(curRow + 1).Cells(0)

        End If
    End Sub

    Private Sub addtsrundown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addtsrundown.Click
        On Error Resume Next
        clipinsertrundown()
    End Sub
    Sub clipinsertrundown()
        On Error Resume Next
        dgvrundown.Rows.Insert(dgvrundown.CurrentRow.Index)
        dgvrundown.Rows(dgvrundown.CurrentRow.Index - 1).Cells(0).Value = Now
        dgvrundown.Rows(dgvrundown.CurrentRow.Index - 1).Cells(1).Value = 10
    End Sub
    Private Sub removetsrundown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removetsrundown.Click
        On Error Resume Next
        deleterundown()
    End Sub
    Private Sub dgvrundown_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvrundown.CellContentClick
        'dont delete
    End Sub
    Private Sub dgvrundown_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvrundown.SelectionChanged
        On Error Resume Next
        rundownrowsselectedchanged()
    End Sub

    Sub rundownrowsselectedchanged()
        On Error Resume Next
        brundownrowselectedchanged = True
        txtsearchtemplate.Text = ""
        lsttemplate.SelectedIndex = lsttemplate.FindStringExact(dgvrundown.CurrentRow.Cells(1).Value)

        Dim xmlString As String = dgvrundown.CurrentRow.Cells(4).Value
        Dim response As New MSXML2.DOMDocument60
        response.loadXML(xmlString)

        Dim ianytemplate As Integer = 0
        dgvanytemplate.Rows.Clear()

        For Each instance As MSXML2.IXMLDOMElement In response.getElementsByTagName("componentData")
            dgvanytemplate.Rows.Add()
            dgvanytemplate.Rows(ianytemplate).Cells(0).Value = instance.getAttribute("id")
            ianytemplate = ianytemplate + 1
        Next


        ianytemplate = 0
        For Each instance As MSXML2.IXMLDOMElement In response.getElementsByTagName("data")
            dgvanytemplate.Rows(ianytemplate).Cells(1).Value = Split(instance.getAttribute("value"), "ddddd")(0)

            Dim str11 = dgvanytemplate.Rows(ianytemplate).Cells(1).Value
            If str11.Contains("file") Then str11 = Mid(str11, 9)
            dgvanytemplate.Rows(ianytemplate).Cells(2).Value = Image.FromFile(str11)
            dgvanytemplate.Rows(ianytemplate).Cells(3).Value = CType((Split(instance.getAttribute("value"), "ddddd")(1)), Integer)
            ianytemplate = ianytemplate + 1
        Next

    End Sub
    Private Sub cmdupdatetemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdatetemplate.Click
        anytemplateupdate()
    End Sub

    Sub anytemplateupdate()
        On Error Resume Next
        For ianytemplate = 1 To dgvanytemplate.Rows.Count - 2
            If dgvanytemplate.Rows(ianytemplate).Cells(3).Value = 0 Then '

                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayertemplate.Text & " updatestring('" & replacestring1(dgvanytemplate.Rows(ianytemplate).Cells(0).Value) & "','" & replacestring1(dgvanytemplate.Rows(ianytemplate).Cells(1).Value) & "')")
            Else
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayertemplate.Text & " updateimage('" & replacestring1(dgvanytemplate.Rows(ianytemplate).Cells(0).Value) & "','" & replacestring1(dgvanytemplate.Rows(ianytemplate).Cells(1).Value) & "')")
            End If
        Next
    End Sub

    Sub anytemplateupdatefromrundown()
        On Error Resume Next
        For ianytemplate = 1 To dgvanytemplate.Rows.Count - 2
            If dgvanytemplate.Rows(ianytemplate).Cells(3).Value = 0 Then '
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & dgvrundown.CurrentRow.Cells(3).Value & " updatestring('" & replacestring1(dgvanytemplate.Rows(ianytemplate).Cells(0).Value) & "','" & replacestring1(dgvanytemplate.Rows(ianytemplate).Cells(1).Value) & "')")
            Else
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & dgvrundown.CurrentRow.Cells(3).Value & " updateimage('" & replacestring1(dgvanytemplate.Rows(ianytemplate).Cells(0).Value) & "','" & replacestring1(dgvanytemplate.Rows(ianytemplate).Cells(1).Value) & "')")
            End If

        Next
    End Sub


    Private Sub lsttemplate_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsttemplate.MouseDown
        On Error Resume Next
        brundownrowselectedchanged = False

        WB1.Navigate(templatefullpath & lsttemplate.SelectedItem.ToString)

    End Sub
    Private Sub cmdinvoke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdinvoke.Click
        On Error Resume Next
        anytemplateinvoke()
    End Sub
    Sub anytemplateinvoke()
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayertemplate.Text & " " & cmbinvoke.Text)
    End Sub

    Private Sub cmdclosegbtemplate_Click(sender As Object, e As EventArgs) 
        Me.Hide()
    End Sub


    Sub enumfonts()
        On Error Resume Next
        For Each Filefound As String In Directory.GetFiles("c:/casparcg/mydata/fonts", "*.swf")
            Dim stringtocut As Integer = 26
            Dim filefound1 = Split(Mid(Filefound, stringtocut), ".")

        Next
    End Sub
    Private Sub dgvanytemplate_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvanytemplate.CellContentClick
        On Error Resume Next
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then

            Dim ofdanytemplate As New OpenFileDialog
            ofdanytemplate.InitialDirectory = "c:/casparcg/mydata/flag/"
            If (ofdanytemplate.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                dgvanytemplate.CurrentRow.Cells(1).Value = Replace(ofdanytemplate.FileName, "\", "/")
                dgvanytemplate.CurrentRow.Cells(2).Value = Image.FromFile(dgvanytemplate.CurrentRow.Cells(1).Value)


            End If
        End If
    End Sub
    Sub initialiserundown()
        On Error Resume Next
        dgvrundown.Rows.Add(2)


        Dim col1 As New CalendarColumn()
        Dim col2 As New DataGridViewTextBoxColumn
        Dim col3 As New DataGridViewTextBoxColumn

        col1.HeaderText = "Start Time"
        col2.HeaderText = "Duration in second"
        col2.Width = 50
        col3.HeaderText = "Tick Time (ms)"
        col3.ReadOnly = True
        col3.Width = 0

        dgvrundown.Columns.Add(col1)
        dgvrundown.Columns.Add(col2)
        dgvrundown.Columns.Add(col3)

    End Sub

    Private Sub cmdclipsearchtemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclipsearchtemplate.Click
        On Error Resume Next
        If frmmediaplayer.ucTab1.UcPlaylistSetting1.rdotemplatefromfilesystem.Checked Then
            lsttemplate.Items.Clear()
            Dim s1 As [String]()
            s1 = Directory.GetFiles(templatefullpath, "*.*", 1)

            For i As Integer = 0 To s1.Length - 1

                Dim f1 As New FileInfo(s1(i))
                If f1.Extension = ".html" Then

                    If UCase(f1.FullName.Substring(Len(templatefullpath))).ToString Like "*" & UCase(Replace(txtsearchtemplate.Text, "/", "\")) & "*" Then
                        Dim dd As Integer = Len((f1.FullName.Substring(Len(templatefullpath))))
                        lsttemplate.Items.Add(Replace(Mid((f1.FullName.Substring(Len(templatefullpath)).ToString), 1, dd), "\", "/"))
                    End If
                End If
            Next
        Else
            refreshtemplate()
        End If

    End Sub
    Sub refreshtemplate()
        On Error Resume Next
        lsttemplate.Items.Clear()

        If ServerVersion > 2.1 Then
            templatefromServer22()
        Else
            CasparDevice.RefreshTemplates()
            Threading.Thread.Sleep(500)
            subfortemplateupdate()
        End If

    End Sub
    Sub templatefromServer22()
        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString("http://" & frmmediaplayer.cmbhost.Text & ":8000/tls")
        Dim aa() = Split(result, vbNewLine)

        For ss = 1 To aa.Count - 3

            If UCase(aa(ss)) Like "*" & UCase(txtsearchtemplate.Text) & "*" Then
                lsttemplate.Items.Add(aa(ss) & ".html")
            End If
        Next

    End Sub


    Private Sub txtsearchtemplate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsearchtemplate.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            'refreshtemplate()
            cmdclipsearchtemplate.PerformClick()
        End If
    End Sub

    Private Sub txtsearchtemplate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearchtemplate.TextChanged
        On Error Resume Next
        'refreshtemplate() 'don't make it on
    End Sub

    Sub subfortemplateupdate()

        On Error Resume Next
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf subfortemplateupdate))
        Else
            For Each File In CasparDevice.Templates.All

                If UCase(File.FullName) Like "*" & UCase(Replace(txtsearchtemplate.Text, "\", "/")) & "*" Then
                    If System.IO.File.Exists(templatefullpath & File.FullName & ".html") Then
                        lsttemplate.Items.Add((Replace((File.FullName), "\", "/")) & ".html")
                    End If

                End If
            Next
            lsttemplate.Refresh()
        End If
        'MsgBox(CasparDevice.Templates.All.First.GetType.ToString)
    End Sub

    Private Sub cmdanytemplateplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdanytemplateplay.Click
        On Error Resume Next
        anytemplate()
    End Sub

    Sub anytemplate()
        On Error Resume Next
        Dim ianytemplate As Integer
        If chkanimatetemplate.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayertemplate.Text & " fill -1 0 1 1")
        End If
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayertemplate.Text & " [HTML] " & """" & Replace(templatefullpath, "\", "/") & lsttemplate.SelectedItem.ToString & """")
        If chkanimatetemplate.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayertemplate.Text & " fill 0 0 1 1 50 " & "easeoutexpo")
        End If
    End Sub

    Private Sub cmdanytemplatestop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdanytemplatestop.Click
        anytemplatestop()
    End Sub
    Sub anytemplatestop()
        On Error Resume Next
        If chkanimatetemplate.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayertemplate.Text & " fill 1 0 1 1 50 easeoutexpo")
            Threading.Thread.Sleep(1000)
        End If
        CasparDevice.SendString("stop " & g_int_ChannelNumber & "-" & cmblayertemplate.Text)

        If chkanimatetemplate.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayertemplate.Text & " fill 0 0 1 1 50 " & "easeoutexpo")
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayertemplate.Text & " opacity 1")
        End If
    End Sub
    Private Sub cmdnextframe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnextframe.Click
        anytemplatenextframe()
    End Sub
    Sub anytemplatenextframe()
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayertemplate.Text & " next()")
    End Sub

    Private Sub cmdstopsheduletemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopsheduletemplate.Click
        On Error Resume Next
        stopshedule()
    End Sub

    Public Sub stopshedule()
        On Error Resume Next
        tmrsheduletemplatestart.Enabled = False
        tmrshedultemplateend.Enabled = False
    End Sub
    Private Sub cmdstartsheduletemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstartsheduletemplate.Click
        On Error Resume Next
        sheduletemplate()
    End Sub

    Public Sub sheduletemplate()
        On Error Resume Next
        sortsheduletemplate()
        tmrsheduletemplatestart.Interval = IntervalTill(CType(dgvrundown.Rows(0).Cells(5).Value, Date).TimeOfDay.ToString)
        tmrsheduletemplatestart.Enabled = True
    End Sub
    Sub sortsheduletemplate()
        On Error Resume Next
        For iticktime = 0 To dgvrundown.Rows.Count - 1
            dgvrundown.Rows(iticktime).Cells(7).Value = IntervalTill(CType(dgvrundown.Rows(iticktime).Cells(5).Value, Date).TimeOfDay.ToString)
        Next
        dgvrundown.Sort(dgvrundown.Columns(7), System.ComponentModel.ListSortDirection.Ascending)
        dgvrundown.CurrentCell = dgvrundown.Rows(0).Cells(0)
        rundownrowsselectedchanged()

    End Sub
    Private Sub tmrsheduletemplatestart_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrsheduletemplatestart.Tick
        On Error Resume Next
        CasparCGDataCollection.Clear()
        For ianytemplate = 0 To dgvanytemplate.Rows.Count
            CasparCGDataCollection.SetData(dgvanytemplate.Rows(ianytemplate).Cells(0).Value, dgvanytemplate.Rows(ianytemplate).Cells(1).Value)
        Next
        playfromrundown()
        tmrsheduletemplatestart.Enabled = False

        tmrshedultemplateend.Interval = dgvrundown.Rows(0).Cells(6).Value * 1000
        tmrshedultemplateend.Enabled = True
    End Sub

    Private Sub tmrshedultemplateend_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrshedultemplateend.Tick
        On Error Resume Next
        CasparDevice.SendString("stop " & g_int_ChannelNumber & "-" & dgvrundown.CurrentRow.Cells(3).Value)
        tmrshedultemplateend.Enabled = False
        sortsheduletemplate()
        tmrsheduletemplatestart.Interval = IntervalTill(CType(dgvrundown.Rows(0).Cells(5).Value, Date).TimeOfDay.ToString)
        tmrsheduletemplatestart.Enabled = True
    End Sub
    Private Sub cmdanytemplatePause_Click(sender As Object, e As EventArgs) Handles cmdanytemplatePause.Click
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayertemplate.Text & " pause()")
    End Sub
    Private Sub lsttemplate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsttemplate.SelectedIndexChanged

        On Error Resume Next

        WB1.Navigate(templatefullpath & lsttemplate.SelectedItem.ToString)
    End Sub
    Private Sub WB1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WB1.DocumentCompleted

        Try
            Dim MyWeb As Object = WB1.ActiveXInstance
            ' MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 25, IntPtr.Zero)
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 75, IntPtr.Zero)

        Catch ex As Exception
        End Try
        If brundownrowselectedchanged = True Then
            Exit Sub
        End If
        dgvanytemplate.Rows.Clear()

        Dim ianytemplate As Integer = 1
        dgvanytemplate.Rows.Add()
        dgvanytemplate.Rows(0).Cells(0).Value = "Template"
        dgvanytemplate.Rows(0).Cells(1).Value = lsttemplate.SelectedItem.ToString
        dgvanytemplate.Rows(0).Cells(3).Value = 0

        For Each element As HtmlElement In Me.WB1.Document.All

            If element.Id <> "" And Mid(element.Id, 1, 3) = "ccg" Then
                If element.TagName <> "IMG" Then

                    dgvanytemplate.Rows.Add()
                    dgvanytemplate.Rows(ianytemplate).Cells(0).Value = element.Id
                    dgvanytemplate.Rows(ianytemplate).Cells(1).Value = element.InnerHtml
                    dgvanytemplate.Rows(ianytemplate).Cells(3).Value = 0 'CheckState.Unchecked
                    ianytemplate = ianytemplate + 1
                End If
            End If
        Next
        For Each element As HtmlElement In Me.WB1.Document.All
            If element.Id <> "" And Mid(element.Id, 1, 3) = "ccg" Then
                If element.TagName = "IMG" Then
                    dgvanytemplate.Rows.Add()
                    dgvanytemplate.Rows(ianytemplate).Cells(0).Value = element.Id
                    dgvanytemplate.Rows(ianytemplate).Cells(1).Value = element.GetAttribute("src").ToString


                    Dim str11 = dgvanytemplate.Rows(ianytemplate).Cells(1).Value
                    If str11.Contains("file") Then str11 = Mid(str11, 9)
                    dgvanytemplate.Rows(ianytemplate).Cells(2).Value = Image.FromFile(str11)
                    dgvanytemplate.Rows(ianytemplate).Cells(3).Value = 1 'CheckState.Checked

                    ianytemplate = ianytemplate + 1
                End If
                'element.
            End If
        Next
        brundownrowselectedchanged = False
    End Sub

    Private Enum Exec
        OLECMDID_OPTICAL_ZOOM = 63
    End Enum

    Private Enum execOpt
        OLECMDEXECOPT_DODEFAULT = 0
        OLECMDEXECOPT_PROMPTUSER = 1
        OLECMDEXECOPT_DONTPROMPTUSER = 2
        OLECMDEXECOPT_SHOWHELP = 3
    End Enum

    Private Sub cmdPlayandUpdate_Click(sender As Object, e As EventArgs) Handles cmdPlayandUpdate.Click
        On Error Resume Next

        Dim ianytemplate As Integer
        If chkanimatetemplate.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayertemplate.Text & " fill -1 0 1 1")
        End If
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayertemplate.Text & " [HTML] " & """" & Replace(templatefullpath, "\", "/") & lsttemplate.SelectedItem.ToString & """")
        Threading.Thread.Sleep(Val(txtupdatedelay.Text))
        anytemplateupdate()
        If chkanimatetemplate.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayertemplate.Text & " fill 0 0 1 1 50 " & "easeoutexpo")
        End If
    End Sub
    Private Sub cmdPutTestdata_Click(sender As Object, e As EventArgs) Handles cmdPutTestdata.Click
        On Error Resume Next
        Dim eachFileInMydirectory As String() = System.IO.Directory.GetFiles("C:/casparcg/mydata/flag")
        Dim ii
        For ii = 1 To dgvanytemplate.Rows.Count - 2
            If dgvanytemplate.Rows(ii).Cells(3).Value = 1 Then
                dgvanytemplate.Rows(ii).Cells(1).Value = Replace(eachFileInMydirectory(ii), "\", "/")
                dgvanytemplate.Rows(ii).Cells(2).Value = Image.FromFile(dgvanytemplate.Rows(ii).Cells(1).Value)
            Else
                dgvanytemplate.Rows(ii).Cells(1).Value = dgvanytemplate.Rows(ii).Cells(0).Value
            End If

        Next
    End Sub

    Private Sub ucHtmlTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialiserundown()
        cmdclipsearchtemplate.PerformClick() 'refreshtemplate()


        Dim aa As DataGridViewImageColumn = dgvanytemplate.Columns(2)
        aa.ImageLayout = DataGridViewImageCellLayout.Stretch

        Dim aa1 As New DataGridViewCheckBoxColumn
        aa1.HeaderText = "Image?"
        aa1.Width = 50
        dgvanytemplate.Columns.Add(aa1)
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        On Error Resume Next
        newdgvrundown()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        On Error Resume Next
        openfilerundown()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

        savefilerundown()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        On Error Resume Next
        deleterundown()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        On Error Resume Next
        copyrundown()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        On Error Resume Next
        insertcopiedrundown()
    End Sub
    Private Sub MenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip1.MouseHover
        MakeMenuDropDownWhenParrented(sender)
    End Sub
End Class
