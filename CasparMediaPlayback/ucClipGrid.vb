Imports System.Data
Imports System.IO
Imports System.Threading.Tasks

Public Class ucClipGrid
    Private Async Sub cmdclipsearch_ClickAsync(sender As Object, e As EventArgs) Handles cmdclipsearch.Click
        ''On Error Resume Next
        labelclips.Text = ""
        refreshclips1()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
    End Sub

    Private Async Sub txtsearch_KeyPressAsync(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) And cmdclipsearch.Enabled = True Then
            labelclips.Text = ""
            refreshclips1()
        End If
    End Sub
    Private Function CheckFileHasCopied(FilePath As String) As Boolean
        Try
            If 5 = 5 Then
                Using File.OpenRead(FilePath)
                    Return True
                End Using
            Else
                Return False
            End If
        Catch generatedExceptionName As Exception
            Return False
        End Try
    End Function

    Dim dt As New DataTable()
    Dim strcurrentrowcell0value As String
    Dim searchnumber As Integer = 1
    Sub refreshclips1()
        On Error Resume Next
        cmdclipsearch.Enabled = False
        Control.CheckForIllegalCrossThreadCalls = False
        strcurrentrowcell0value = dgvclips.CurrentRow.Cells(0).Value


        dt.Clear()
        Dim dr As DataRow

        If frmmediaplayer.ucTab1.UcPlaylistSetting1.rdoclipfromfilesystem.Checked = True Then
            'MsgBox("from file sysytem")
            Dim s1 As [String]()
            s1 = Directory.GetFiles(mediafullpath & lblsearch.Text, "*.*", 1)
            pbclipsearchstatus.Maximum = s1.Length - 1
            For i As Integer = 0 To s1.Length - 1
                If i = 0 Then
                    dt.Columns.Add("Name")
                    dt.Columns.Add("Duration")
                End If

                Dim f1 As New FileInfo(s1(i))
                dr = dt.NewRow()
                If (Path.GetExtension(f1.FullName).ToUpper = ".MXF") Or (Path.GetExtension(f1.FullName).ToUpper = ".TS") Then
                    GoTo 40
                End If

                If (f1.Attributes And FileAttributes.Hidden) <> 0 Or CheckFileHasCopied(f1.FullName) = False Then GoTo 50
40:             If UCase(Replace(f1.FullName.Substring(Len(mediafullpath)), "\", "/").ToString) Like "*" & UCase(Replace(txtsearch.Text, "\", "/")) & "*" Then

                    dr("Name") = Replace(f1.FullName.Substring(Len(mediafullpath)), "\", "/").ToString
                    If chkclipduration.Checked Then
                        dr("Duration") = getdurationofclip(f1.FullName)
                    End If
                    dt.Rows.Add(dr)
                End If
50:             'hidden file
                pbclipsearchstatus.Value = i
                labelclips.Text = dt.Rows.Count
            Next


        ElseIf frmmediaplayer.ucTab1.UcPlaylistSetting1.rdoclipfromserver.Checked = True Then
            If ServerVersion > 2.1 Then
                'MsgBox("from 2.2 or 2.3")
                Dim webClient As New System.Net.WebClient
                Dim result As String = webClient.DownloadString("http://" & frmmediaplayer.cmbhost.Text & ":8000/cls")
                Dim aa() = Split(result, vbNewLine)

                pbclipsearchstatus.Maximum = aa.Count - 3
                For ss = 1 To aa.Count - 3
                    If ss = 1 Then
                        dt.Columns.Add("Name")
                        dt.Columns.Add("Duration")
                    End If
                    If UCase(Replace(Replace(Split(aa(ss), "  ")(0), "\", "/"), """", "")) Like lblsearch.Text & "*" & UCase(Replace(txtsearch.Text, "\", "/")) & "*" Then

                        dr = dt.NewRow()
                        dr("Name") = Replace(Replace(Split(aa(ss), "  ")(0), "\", "/"), """", "")
                        'dr("Name") = aa(ss)
                        dr("Duration") = "" 'Mid(CasparDevice.Mediafiles.Item(i).Timecode, 1, 8)
                        dt.Rows.Add(dr)
                    End If

                    pbclipsearchstatus.Value = ss
                    labelclips.Text = dt.Rows.Count
                Next

            Else
                'MsgBox("from 2.1")
                CasparDevice.RefreshMediafiles()
                Threading.Thread.Sleep(250)
                pbclipsearchstatus.Maximum = CasparDevice.Mediafiles.Count - 1
                For i As Integer = 0 To CasparDevice.Mediafiles.Count - 1
                    If i = 0 Then
                        dt.Columns.Add("Name")
                        dt.Columns.Add("Duration")
                    End If
                    If UCase(Replace(CasparDevice.Mediafiles.Item(i).ToString, "\", "/").ToString) Like lblsearch.Text & "*" & UCase(Replace(txtsearch.Text, "\", "/")) & "*" Then

                        dr = dt.NewRow()
                        dr("Name") = Replace(CasparDevice.Mediafiles.Item(i).ToString, "\", "/")
                        dr("Duration") = Mid(CasparDevice.Mediafiles.Item(i).Timecode, 1, 8)
                        dt.Rows.Add(dr)
                    End If

                    pbclipsearchstatus.Value = i
                    labelclips.Text = dt.Rows.Count
                Next
            End If


        End If
        clipsearchcomplete()
        searchnumber = searchnumber + 1
    End Sub
    Sub clipsearchcomplete()
        On Error Resume Next

        Me.dgvclips.DataSource = dt
        'labelclips.Text = dt.Rows.Count

        dgvclips.Columns("Name").Width = 400

        dgvclips.Columns("Duration").Width = 60

        dgvclips.Sort(dgvclips.Columns("Name"), System.ComponentModel.ListSortDirection.Ascending)

        For iii = 0 To dgvclips.RowCount - 1
            If dgvclips.Rows(iii).Cells(0).Value = strcurrentrowcell0value Then
                dgvclips.CurrentCell = dgvclips.Rows(iii).Cells(0)
                Exit For
            End If
        Next

        cmdclipsearch.Enabled = True

        pbclipsearchstatus.Value = 0

        dgvclips.Columns(0).DefaultCellStyle.Font = New Font("Arial Black", frmmediaplayer.nfontsizeforall.Value, FontStyle.Regular)

    End Sub

    Private Sub cmdrefreshtvclips_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrefreshtvclips.Click
        On Error Resume Next
        initialisetvclips()
    End Sub
    Sub initialisetvclips()
        On Error Resume Next
        tvclips.Nodes.Clear()
        Dim xx As String = ""
        If frmmediaplayer.ucTab1.UcPlaylistSetting1.rdoclipfromfilesystem.Checked Then
            tvclips.Nodes.Add(mediafullpath)
            PopulateTreeView(mediafullpath, tvclips.Nodes(0))
        ElseIf frmmediaplayer.ucTab1.UcPlaylistSetting1.rdoclipfromserver.Checked Then
            Dim aa() As String
            If Mid(frmmediaplayer.lblserverversion.Text, 1, 3) = "2.1" Then 'added because server 2.1 sends each files as indivisual , no folder name. 150119
                'MsgBox("from 2.1")
                CasparDevice.RefreshMediafiles()
                Threading.Thread.Sleep(500)
                ReDim aa(CasparDevice.Mediafiles.Count)
                For iclips = 0 To CasparDevice.Mediafiles.Count - 1
                    Dim foldername As String = ""
                    foldername = Mid(CasparDevice.Mediafiles.Item(iclips).Name, 1, Len(CasparDevice.Mediafiles.Item(iclips).Name) - Len(Split(CasparDevice.Mediafiles.Item(iclips).Name, "/").Last) - 1)
                    aa(iclips) = "Clips\" & Replace(foldername, "/", "\")
                Next
            ElseIf Mid(frmmediaplayer.lblserverversion.Text, 1, 3) = "2.0" Then
                'MsgBox("from 2.07")
                CasparDevice.RefreshMediafiles()
                Threading.Thread.Sleep(500)
                ReDim aa(CasparDevice.Mediafiles.Count)
                For iclips = 0 To CasparDevice.Mediafiles.Count - 1
                    aa(iclips) = "Clips\" & CasparDevice.Mediafiles.Item(iclips).Folder
                Next

            ElseIf ServerVersion > 2.1 Then
                'MsgBox("from 2.2 or 2.3")
                Dim webClient As New System.Net.WebClient
                Dim result As String = webClient.DownloadString("http://" & frmmediaplayer.cmbhost.Text & ":8000/cls")
                Dim bb() = Split(result, vbNewLine)
                ReDim aa(bb.Count)
                For iclips = 0 To bb.Count - 1
                    Dim foldername As String = ""
                    Dim clipname As String = Replace(Replace(Split(bb(iclips), "  ")(0), "\", "/"), """", "")
                    foldername = Mid(clipname, 1, Len(clipname) - Len(Split(clipname, "/").Last) - 1)
                    aa(iclips) = "Clips\" & Replace(foldername, "/", "\")
                Next
            End If
50:
            createTreeview(aa)
        End If
        tvclips.Sort() '210515
        tvclips.Nodes(0).Expand()
    End Sub
    Sub createTreeview(aa() As String)

        Dim nodeData As New List(Of String)(aa)
        Dim TN As TreeNode
        For Each nodePath As String In nodeData
            TN = Nothing
            For Each node As String In nodePath.Split("\"c)
                If node <> "" Then
                    If IsNothing(TN) Then
                        If tvclips.Nodes.ContainsKey(node) Then
                            TN = tvclips.Nodes(node)
                        Else
                            TN = tvclips.Nodes.Add(node, node)
                        End If
                    Else
                        If TN.Nodes.ContainsKey(node) Then
                            TN = TN.Nodes(node)
                        Else
                            TN = TN.Nodes.Add(node, node)
                        End If
                    End If
                End If
            Next
        Next

    End Sub
    Private Sub PopulateTreeView(ByVal dir As String, ByVal parentNode As TreeNode)
        On Error Resume Next
        Dim folder As String = String.Empty
        Dim folders() As String = Directory.GetDirectories(dir)
        If folders.Length <> 0 Then
            Dim childNode As TreeNode = Nothing
            For Each folder In folders
                childNode = New TreeNode(IO.Path.GetFileName(folder))
                parentNode.Nodes.Add(childNode)
                PopulateTreeView(folder, childNode)
            Next
        End If

    End Sub

    Private Sub tvclips_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvclips.AfterSelect
        On Error Resume Next
        If frmmediaplayer.ucTab1.UcPlaylistSetting1.rdoclipfromfilesystem.Checked Then
            lblsearch.Text = Replace(Mid(tvclips.SelectedNode.FullPath, Len(mediafullpath) + 2), "\", "/") & "/"
        ElseIf frmmediaplayer.ucTab1.UcPlaylistSetting1.rdoclipfromserver.Checked Then
            lblsearch.Text = Replace(Mid(tvclips.SelectedNode.FullPath, 5 + 2), "\", "/") & "/"
        End If
        If lblsearch.Text = "/" Then lblsearch.Text = ""
        txtsearch.Text = ""
    End Sub

    Private Sub dgvclips_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvclips.CellContentClick

    End Sub

    Private Sub dgvclips_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvclips.DataError
        'dont delete dummy code
    End Sub


    Private Sub dgvclips_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvclips.CellDoubleClick
        LoadinSM()

    End Sub
    Sub LoadinSM()
        On Error Resume Next
        Dim fullpath As String = mediafullpath & dgvclips.CurrentRow.Cells(0).Value

        With ucSlowMotion21
            If cmbChannelDestination.Text = .UcnewSM21.cmbChannel.Text Then

                CasparDevice.SendString("load " & cmbChannelDestination.Text & "-" & 1 & " " & """" & Replace(Replace(fullpath, ":", ":\"), "\", "/") & """")

                .UcnewSM21.lblmax.Text = HMStoF(getdurationofclip(fullpath))
                .UcnewSM21.lblplaying.Text = Replace(Replace(fullpath, ":", ":\"), "\", "/")
                .UcnewSM21.TrackBarseek.Maximum = .UcnewSM21.lblmax.Text
                .UcnewSM21.TrackBarseek.Value = 0

            ElseIf cmbChannelDestination.Text = .UcnewSM22.cmbChannel.Text Then
                CasparDevice.SendString("load " & cmbChannelDestination.Text & "-" & 1 & " " & """" & Replace(Replace(fullpath, ":", ":\"), "\", "/") & """")
                .UcnewSM22.lblmax.Text = HMStoF(getdurationofclip(fullpath))
                .UcnewSM22.lblplaying.Text = Replace(Replace(fullpath, ":", ":\"), "\", "/")
                .UcnewSM22.TrackBarseek.Maximum = .UcnewSM22.lblmax.Text
                .UcnewSM22.TrackBarseek.Value = 0
            End If
        End With

    End Sub
    Private Sub cmdLoadinSMPlayer_Click(sender As Object, e As EventArgs) Handles cmdLoadinSMPlayer.Click
        LoadinSM()
    End Sub
    Private Sub dgvclips_DoubleClick(sender As Object, e As EventArgs) Handles dgvclips.DoubleClick
        LoadinSM()
    End Sub

    Private MouseDownPos As Point
    Private MouseIsDown As Boolean = False
    Private Sub dgvclips_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvclips.MouseDown
        On Error Resume Next
        MouseDownPos = e.Location
        If dgvclips.Cursor = System.Windows.Forms.Cursors.SizeWE Then
            MouseIsDown = False
        Else
            MouseIsDown = True
        End If

    End Sub
    Private Sub dgvclips_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvclips.MouseMove
        On Error Resume Next
        If e.Button = MouseButtons.Left Then
            Dim dx = e.X - MouseDownPos.X
            Dim dy = e.Y - MouseDownPos.Y
            If Math.Abs(dx) >= SystemInformation.DoubleClickSize.Width OrElse
               Math.Abs(dy) >= SystemInformation.DoubleClickSize.Height Then

                Dim cellX, cellY As Integer

                Dim grvScreenLocation As Point = dgvclips.PointToScreen(dgvclips.Location)
                Dim tempX As Integer = DataGridView.MousePosition.X - grvScreenLocation.X + dgvclips.Left
                Dim tempY As Integer = DataGridView.MousePosition.Y - grvScreenLocation.Y + dgvclips.Top
                Dim hit As DataGridView.HitTestInfo = dgvclips.HitTest(tempX, tempY)
                cellX = hit.RowIndex
                cellY = hit.ColumnIndex
                dgvclips.CurrentCell = dgvclips.Rows(cellX).Cells(0)


                If MouseIsDown = True Then 'And dgv1.Cursor <> System.Windows.Forms.Cursors.SizeWE Then
                    dgvclips.DoDragDrop(mediafullpath & dgvclips.CurrentRow.Cells(0).Value, DragDropEffects.Copy)
                    MouseIsDown = False
                End If
            End If
        End If

    End Sub

    Private Sub ucClipGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
