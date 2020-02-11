Imports System.IO

Public Class ucTemplate
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

        CasparCGDataCollection.Clear() 'cgData.Clear()

        Dim ianytemplate As Integer
        For ianytemplate = 0 To dgvanytemplate.Rows.Count
            CasparCGDataCollection.SetData(dgvanytemplate.Rows(ianytemplate).Cells(0).Value, dgvanytemplate.Rows(ianytemplate).Cells(1).Value)
        Next
        CasparCGDataCollection.SetData("font", cmbfonttemplate.Text)

        dgvrundown.CurrentRow.Cells(0).Value = dgvanytemplate.Rows(0).Cells(1).Value
        dgvrundown.CurrentRow.Cells(1).Value = lsttemplate.SelectedItem.ToString

        dgvrundown.CurrentRow.Cells(2).Value = cmbvideolayerfortemplate.Text
        dgvrundown.CurrentRow.Cells(3).Value = cmblayertemplate.Text
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
        CasparCGDataCollection.Clear()
        For ianytemplate = 0 To dgvanytemplate.Rows.Count
            CasparCGDataCollection.SetData(dgvanytemplate.Rows(ianytemplate).Cells(0).Value, dgvanytemplate.Rows(ianytemplate).Cells(1).Value)
        Next
        CasparDevice.SendString("cg " & g_int_ChannelNumber & "-" & dgvrundown.CurrentRow.Cells(2).Value & " add " & dgvrundown.CurrentRow.Cells(3).Value & " " & """" & dgvrundown.CurrentRow.Cells(1).Value & """" & " 1 " & """" & CasparCGDataCollection.ToAMCPEscapedXml & """")

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
        CasparDevice.SendString("cg " & g_int_ChannelNumber & "-" & dgvrundown.CurrentRow.Cells(2).Value & " NEXT " & dgvrundown.CurrentRow.Cells(3).Value & vbCrLf)

    End Sub
    Private Sub stoptsrundown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stoptsrundown.Click

        On Error Resume Next
        CasparDevice.SendString("cg " & g_int_ChannelNumber & "-" & dgvrundown.CurrentRow.Cells(2).Value & " stop " & dgvrundown.CurrentRow.Cells(3).Value & vbCrLf)

    End Sub
    Private Sub cmdrundowninvoke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrundowninvoke.Click
        On Error Resume Next
        CasparDevice.SendString("cg " & g_int_ChannelNumber & "-" & dgvrundown.CurrentRow.Cells(2).Value & " invoke " & dgvrundown.CurrentRow.Cells(3).Value & " " & cmbrundowninvoke.Text & vbCrLf)

    End Sub
    Private Sub newtsrundown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub newdgvrundown()
        On Error Resume Next
        dgvrundown.Rows.Clear()
        dgvrundown.Rows.Add(1)
        Me.dgvrundown.Columns(0).HeaderText = "new rundown"
    End Sub

    Private Sub opentsrundown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub openfilerundown()
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog
        ofd2.InitialDirectory = "c:\casparcg\mydata\rundown\"
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

    End Sub
    Sub savefilerundown()
        On Error Resume Next
        osd2.InitialDirectory = "c:\casparcg\mydata\rundown\"
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

    End Sub
    Sub deleterundown()
        On Error Resume Next
        dgvrundown.Rows.RemoveAt(dgvrundown.CurrentRow.Index)
    End Sub


    Private Sub copytsrundown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub copyrundown()
        On Error Resume Next
        tempRow = Me.dgvrundown().CurrentRow
    End Sub

    Private Sub pastetsrundown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    End Sub
    Private Sub dgvrundown_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvrundown.SelectionChanged
        On Error Resume Next
        rundownrowsselectedchanged()

    End Sub

    Sub rundownrowsselectedchanged()
        On Error Resume Next

        txtsearchtemplate.Text = ""
        lsttemplate.SelectedIndex = lsttemplate.FindStringExact(dgvrundown.CurrentRow.Cells(1).Value)

        'for template info
        If lsttemplate.SelectedItem = Nothing Then
            Exit Sub
        End If
        Dim str As String
        str = "info template " & """" & lsttemplate.SelectedItem.ToString & """" & vbCrLf
        SendString(NetStream, str)

        Threading.Thread.Sleep(100)

        Dim data(10024) As Byte
        NetStream.Read(data, 0, 10024)
        Dim xmlString1 As String = System.Text.Encoding.UTF8.GetString(data)

        xmlString1 = xmlString1.Substring(xmlString1.IndexOf("<"))

        Dim response1 As New MSXML2.DOMDocument60
        response1.loadXML(xmlString1)

        cmbrundowninvoke.Items.Clear()
        For Each keyframe As MSXML2.IXMLDOMElement In response1.getElementsByTagName("keyframe")
            cmbrundowninvoke.Items.Add(keyframe.getAttribute("name"))
        Next

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
            dgvanytemplate.Rows(ianytemplate).Cells(1).Value = instance.getAttribute("value")
            ianytemplate = ianytemplate + 1
        Next

    End Sub
    Private Sub cmdupdatetemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdatetemplate.Click
        anytemplateupdate()
    End Sub

    Sub anytemplateupdate()
        On Error Resume Next
        CasparCGDataCollection.Clear()
        For ianytemplate = 0 To dgvanytemplate.Rows.Count - 1
            CasparCGDataCollection.SetData(dgvanytemplate.Rows(ianytemplate).Cells(0).Value, dgvanytemplate.Rows(ianytemplate).Cells(1).Value)
        Next
        CasparCGDataCollection.SetData("font", cmbfonttemplate.Text)
        Dim str As String
        str = "cg " & g_int_ChannelNumber & "-" & cmbvideolayerfortemplate.Text & " UPDATE " & cmblayertemplate.Text & """" & CasparCGDataCollection.ToAMCPEscapedXml & """" & vbCrLf
        SendString(NetStream, str)
    End Sub

    Private Sub lsttemplate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsttemplate.SelectedIndexChanged
        On Error Resume Next
        picanytemplate.Movie = Replace(templatefullpath & lsttemplate.SelectedItem.ToString, "/", "\") & ".ft"
    End Sub

    Private Sub cmdinvoke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdinvoke.Click
        On Error Resume Next
        anytemplateinvoke()
    End Sub
    Sub anytemplateinvoke()
        On Error Resume Next
        Dim str As String
        str = "cg " & g_int_ChannelNumber & "-" & cmbvideolayerfortemplate.Text & " INVOKE " & cmblayertemplate.Text & " " & cmbinvoke.Text & vbCrLf
        SendString(NetStream, str)
    End Sub


    Private Sub cmdclosegbtemplate_Click(sender As Object, e As EventArgs) 
        Me.Hide()
    End Sub

    Private Sub ucTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialiserundown()
        cmdclipsearchtemplate.PerformClick() 'refreshtemplate()
        enumfonts()

    End Sub

    Sub enumfonts()
        On Error Resume Next
        For Each Filefound As String In Directory.GetFiles("c:/casparcg/mydata/fonts", "*.swf")
            Dim stringtocut As Integer = 26
            Dim filefound1 = Split(Mid(Filefound, stringtocut), ".")
            cmbfonttemplate.Items.Add(filefound1(0))

        Next
    End Sub
    Private Sub dgvanytemplate_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvanytemplate.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

            Dim ofdanytemplate As New OpenFileDialog
            ofdanytemplate.InitialDirectory = "c:/casparcg/mydata/flag/"
            If (ofdanytemplate.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                dgvanytemplate.CurrentRow.Cells(1).Value = ofdanytemplate.FileName

            End If
        End If
    End Sub
    Sub initialiserundown()
        On Error Resume Next
        dgvrundown.Rows.Add(5)

        dgvrundown.Rows(0).Cells(0).Value = "live phonein"
        dgvrundown.Rows(0).Cells(1).Value = "CMP/cg_template/LIVE_PHONEIN"

        dgvrundown.Rows(0).Cells(2).Value = "96"
        dgvrundown.Rows(0).Cells(3).Value = "96"
        dgvrundown.Rows(0).Cells(4).Value = "<templateData><componentData id='font'><data id='text' value='Calibri' /></componentData><componentData id='f0'><data id='text' value='Value of f0' /></componentData></templateData>"

        dgvanytemplate.Rows(0).Cells(0).Value = "f0"
        dgvanytemplate.Rows(0).Cells(1).Value = "value of f0"

        dgvrundown.Rows(1).Cells(0).Value = "clock"
        dgvrundown.Rows(1).Cells(1).Value = "CMP/cg_template/CLOCK"

        dgvrundown.Rows(1).Cells(2).Value = "96"
        dgvrundown.Rows(1).Cells(3).Value = "96"
        dgvrundown.Rows(1).Cells(4).Value = "<templateData><componentData id='font'><data id='text' value='Calibri' /></componentData><componentData id='f0'><data id='text' value='Value of f0' /></componentData></templateData>"

        dgvrundown.Rows(2).Cells(0).Value = "top left"
        dgvrundown.Rows(2).Cells(1).Value = "CMP/cg_template/TOP_LEFT"

        dgvrundown.Rows(2).Cells(2).Value = "96"
        dgvrundown.Rows(2).Cells(3).Value = "96"
        dgvrundown.Rows(2).Cells(4).Value = "<templateData><componentData id='font'><data id='text' value='Calibri' /></componentData><componentData id='f0'><data id='text' value='Value of f0' /></componentData></templateData>"

        dgvrundown.Rows(3).Cells(0).Value = "top_right"
        dgvrundown.Rows(3).Cells(1).Value = "CMP/cg_template/TOP_RIGHT"

        dgvrundown.Rows(3).Cells(2).Value = "96"
        dgvrundown.Rows(3).Cells(3).Value = "96"
        dgvrundown.Rows(3).Cells(4).Value = "<templateData><componentData id='font'><data id='text' value='Calibri' /></componentData><componentData id='f0'><data id='text' value='Value of f0' /></componentData></templateData>"

        dgvrundown.Rows(4).Cells(0).Value = "OFF_AIR_LOGGER_CLOCK"
        dgvrundown.Rows(4).Cells(1).Value = "CMP/off_air_logger_clock/OFF_AIR_LOGGER_CLOCK"

        dgvrundown.Rows(4).Cells(2).Value = "96"
        dgvrundown.Rows(4).Cells(3).Value = "96"
        dgvrundown.Rows(4).Cells(4).Value = "<templateData><componentData id='font'><data id='text' value='Calibri' /></componentData><componentData id='f0'><data id='text' value='Value of f0' /></componentData></templateData>"


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

        'dgvrundown.Rows.Add(4)
        dgvrundown.Rows(0).Cells(5).Value = Now.AddSeconds(50)
        dgvrundown.Rows(0).Cells(6).Value = "10"
        dgvrundown.Rows(1).Cells(5).Value = Now.AddSeconds(70)
        dgvrundown.Rows(1).Cells(6).Value = "10"

        dgvrundown.Rows(2).Cells(5).Value = Now.AddSeconds(90)
        dgvrundown.Rows(2).Cells(6).Value = "10"
        dgvrundown.Rows(3).Cells(5).Value = Now.AddSeconds(110)
        dgvrundown.Rows(3).Cells(6).Value = "10"
        dgvrundown.Rows(4).Cells(5).Value = Now.AddSeconds(150)
        dgvrundown.Rows(4).Cells(6).Value = "10"

    End Sub

    Private Sub cmdclipsearchtemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclipsearchtemplate.Click
        On Error Resume Next
        If frmmediaplayer.ucTab1.UcPlaylistSetting1.rdotemplatefromfilesystem.Checked Then
            lsttemplate.Items.Clear()
            Dim s1 As [String]()
            s1 = Directory.GetFiles(templatefullpath, "*.*", 1)

            For i As Integer = 0 To s1.Length - 1

                Dim f1 As New FileInfo(s1(i))
                If f1.Extension = ".ft" Then

                    'If UCase(f1.FullName.Substring(Len(templatefullpath))).ToString Like "*" & UCase(txtsearchtemplate.Text) & "*" Then
                    If UCase(f1.FullName.Substring(Len(templatefullpath))).ToString Like "*" & UCase(Replace(txtsearchtemplate.Text, "/", "\")) & "*" Then
                        Dim dd As Integer = Len((f1.FullName.Substring(Len(templatefullpath))))
                        lsttemplate.Items.Add(Replace(Mid((f1.FullName.Substring(Len(templatefullpath)).ToString), 1, dd - 3), "\", "/"))
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
                lsttemplate.Items.Add(aa(ss))
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
        'refreshtemplate()'don't make on
    End Sub



    Sub subfortemplateupdate()
        'MsgBox("dfdfdf")
        On Error Resume Next
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf subfortemplateupdate))
        Else
            For Each File In CasparDevice.Templates.All
                If UCase(File.FullName) Like "*" & UCase(Replace(txtsearchtemplate.Text, "\", "/")) & "*" Then
                    If System.IO.File.Exists(templatefullpath & File.FullName & ".ft") Then
                        lsttemplate.Items.Add((Replace((File.FullName), "\", "/")))
                    End If

                End If
            Next
            lsttemplate.Refresh()
        End If
    End Sub




    Private Sub lsttemplate_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsttemplate.MouseDown

        On Error Resume Next
        picanytemplate.Movie = Replace(templatefullpath & lsttemplate.SelectedItem.ToString, "/", "\") & ".ft"

        Dim str As String
        str = "info template " & """" & lsttemplate.SelectedItem.ToString & """" & vbCrLf
        SendString(NetStream, str)

        Threading.Thread.Sleep(100)

        Dim data(10024) As Byte
        NetStream.Read(data, 0, 10024)
        Dim xmlString As String = System.Text.Encoding.UTF8.GetString(data)

        xmlString = xmlString.Substring(xmlString.IndexOf("<"))

        Dim response As New MSXML2.DOMDocument60
        response.loadXML(xmlString)

        cmbinvoke.Items.Clear()
        For Each keyframe As MSXML2.IXMLDOMElement In response.getElementsByTagName("keyframe")
            cmbinvoke.Items.Add(keyframe.getAttribute("name"))
        Next

        dgvanytemplate.Rows.Clear()

        Dim ianytemplate As Integer = 1
        dgvanytemplate.Rows.Add()
        dgvanytemplate.Rows(0).Cells(0).Value = "Label"
        dgvanytemplate.Rows(0).Cells(1).Value = lsttemplate.SelectedItem.ToString '"Label Name" '250814

        For Each instance As MSXML2.IXMLDOMElement In response.getElementsByTagName("instance")
            dgvanytemplate.Rows.Add()
            dgvanytemplate.Rows(ianytemplate).Cells(0).Value = instance.getAttribute("name")
            dgvanytemplate.Rows(ianytemplate).Cells(1).Value = instance.getAttribute("name")
            ianytemplate = ianytemplate + 1
        Next

        For Each instance As MSXML2.IXMLDOMElement In response.getElementsByTagName("parameter")
            dgvanytemplate.Rows.Add()
            dgvanytemplate.Rows(ianytemplate).Cells(0).Value = instance.getAttribute("id")
            dgvanytemplate.Rows(ianytemplate).Cells(1).Value = instance.getAttribute("id") '171119
            ianytemplate = ianytemplate + 1
        Next

        dgvanytemplate.Rows.Add(6)
        dgvanytemplate.Rows(ianytemplate).Cells(0).Value = "loader1"
        dgvanytemplate.Rows(ianytemplate).Cells(1).Value = "C:\casparcg\mydata\photo\india\anjum.jpeg"

        dgvanytemplate.Rows(ianytemplate + 1).Cells(0).Value = "loader2"
        dgvanytemplate.Rows(ianytemplate + 1).Cells(1).Value = "C:\casparcg\mydata\photo\india\archana.jpeg"

        dgvanytemplate.Rows(ianytemplate + 2).Cells(0).Value = "loader3"
        dgvanytemplate.Rows(ianytemplate + 2).Cells(1).Value = "C:\casparcg\mydata\photo\india\ekta.jpeg"

        dgvanytemplate.Rows(ianytemplate + 3).Cells(0).Value = "loader4"
        dgvanytemplate.Rows(ianytemplate + 3).Cells(1).Value = "C:\casparcg\mydata\photo\india\gauhar.jpeg"

        dgvanytemplate.Rows(ianytemplate + 4).Cells(0).Value = "loader5"
        dgvanytemplate.Rows(ianytemplate + 4).Cells(1).Value = "C:\casparcg\mydata\photo\india\jhulan.jpeg"

        dgvanytemplate.Rows(ianytemplate + 5).Cells(0).Value = "loader6"
        dgvanytemplate.Rows(ianytemplate + 5).Cells(1).Value = "C:\casparcg\mydata\photo\india\mamta.jpeg"


    End Sub


    Private Sub cmdanytemplateplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdanytemplateplay.Click
        On Error Resume Next
        anytemplate()
    End Sub

    Sub anytemplate()

        On Error Resume Next
        If chkanimatetemplate.Checked Then frmmediaplayer.animation1()


        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("font", cmbfonttemplate.Text)
        Dim ianytemplate As Integer
        For ianytemplate = 0 To dgvanytemplate.Rows.Count
            CasparCGDataCollection.SetData(dgvanytemplate.Rows(ianytemplate).Cells(0).Value, dgvanytemplate.Rows(ianytemplate).Cells(1).Value)
        Next
        Dim str As String
        str = "cg " & g_int_ChannelNumber & "-" & cmbvideolayerfortemplate.Text & " add " & cmblayertemplate.Text & " " & """" & Replace(lsttemplate.SelectedItem.ToString, "\", "/") & """" & " 1 " & """" & CasparCGDataCollection.ToAMCPEscapedXml & """" & vbCrLf
        SendString(NetStream, str)
        If chkanimatetemplate.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayertemplate.Text & " fill 0 0 1 1 50 " & "easeoutexpo")
        End If

    End Sub

    Private Sub cmdanytemplatestop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdanytemplatestop.Click
        anytemplatestop()
    End Sub
    Sub anytemplatestop()
        On Error Resume Next
        If chkanimatetemplate.Checked Then frmmediaplayer.animation2()
        Dim str As String
        str = "cg " & g_int_ChannelNumber & "-" & cmbvideolayerfortemplate.Text & " STOP " & cmblayertemplate.Text & vbCrLf
        SendString(NetStream, str)
        Threading.Thread.Sleep(1000)
        If chkanimatetemplate.Checked Then frmmediaplayer.animationtoscreen()

    End Sub


    Private Sub cmdnextframe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnextframe.Click
        anytemplatenextframe()
    End Sub
    Sub anytemplatenextframe()
        On Error Resume Next
        Dim str As String
        str = "cg " & g_int_ChannelNumber & "-" & cmbvideolayerfortemplate.Text & " NEXT " & cmblayertemplate.Text & vbCrLf
        SendString(NetStream, str)
    End Sub



    Private Sub cmbfonttemplate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfonttemplate.SelectedIndexChanged
        On Error Resume Next
        Dim fontname As String = cmbfonttemplate.Text
        Dim fontsize As Integer = frmmediaplayer.nfontsizeforall.Value
        Dim fs As New Font(fontname, fontsize, FontStyle.Regular)

        dgvanytemplate.Font = fs

        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("font", cmbfonttemplate.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayertemplate.Text), CasparCGDataCollection)

    End Sub


    ' shedule template code starts------------
    Private Sub cmdstopsheduletemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopsheduletemplate.Click
        On Error Resume Next
        stopshedule()
    End Sub

    Public Sub stopshedule()
        On Error Resume Next
        tmrsheduletemplatestart.Enabled = False
        tmrshedultemplateend.Enabled = False
        lblsheduleStatus.Text = "Schedule Stopped"
        lblsheduleStatus.BackColor = Color.Red
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
        lblsheduleStatus.Text = "Schedule Started"
        lblsheduleStatus.BackColor = Color.Green
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
        CasparDevice.SendString("cg " & g_int_ChannelNumber & "-" & dgvrundown.Rows(0).Cells(2).Value & " add " & dgvrundown.Rows(0).Cells(3).Value & " " & """" & dgvrundown.Rows(0).Cells(1).Value & """" & " 1 " & """" & CasparCGDataCollection.ToAMCPEscapedXml & """" & vbCrLf)

        tmrsheduletemplatestart.Enabled = False

        tmrshedultemplateend.Interval = dgvrundown.Rows(0).Cells(6).Value * 1000
        tmrshedultemplateend.Enabled = True
    End Sub

    Private Sub tmrshedultemplateend_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrshedultemplateend.Tick
        On Error Resume Next
        CasparDevice.SendString("cg " & g_int_ChannelNumber & "-" & dgvrundown.Rows(0).Cells(2).Value & " stop " & dgvrundown.Rows(0).Cells(3).Value)
        tmrshedultemplateend.Enabled = False
        sortsheduletemplate()
        tmrsheduletemplatestart.Interval = IntervalTill(CType(dgvrundown.Rows(0).Cells(5).Value, Date).TimeOfDay.ToString)
        tmrsheduletemplatestart.Enabled = True
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
    Private Sub gbtemplate_Enter(sender As Object, e As EventArgs) Handles gbtemplate.Enter

    End Sub
End Class
