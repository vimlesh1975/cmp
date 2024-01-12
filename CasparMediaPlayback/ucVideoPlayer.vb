Imports System.Data
Imports System.IO
Imports System.Runtime.Remoting.Channels
Imports System.Threading.Tasks
Imports Bespoke.Common.Osc
Imports System.Net
Public Class ucVideoPlayer

    Public channelNumber = 1
    Public layerNumber = 1
    Private Async Sub cmdclipsearch_ClickAsync(sender As Object, e As EventArgs) Handles cmdclipsearch.Click
        ''On Error Resume Next
        labelclips.Text = ""
        refreshclips1()
    End Sub

    Dim WithEvents sOscServer As OscServer 'for osc
    Dim iport As Integer

    Sub oscstartandregister(aa As Integer, bb As Integer)
        On Error Resume Next
        If sOscServer.IsRunning = False Then
            Dim ttype As Integer = 1
            OscPacket.LittleEndianByteOrder = False
            sOscServer = New OscServer(ttype, IPAddress.Any, bb)
            sOscServer.Start()
            sOscServer.RegisterMethod("/channel/" & aa & "/mixer/audio/1/dBFS")
            sOscServer.RegisterMethod("/channel/" & aa & "/mixer/audio/2/dBFS")
            sOscServer.RegisterMethod("/channel/" & channelNumber & "/mixer/audio/volume") ' for server 2.2
            sOscServer.FilterRegisteredMethods = True
        End If
    End Sub
    Private Sub invokeControls1(ByVal e As OscMessageReceivedEventArgs)
        On Error Resume Next
        If Me.InvokeRequired Then
            Me.Invoke(New invokeControlsDelegate1(AddressOf Me.invokeControls1), e)
        Else
            Dim jregisteredmethods As Integer
            If ServerVersion > 2.1 Then
                If "/channel/" & channelNumber & "/mixer/audio/volume" = e.Message.Address Then
                    ProgressBar1.Value = 40 + ValuetodBFS(e.Message.Data(0))
                    ProgressBar2.Value = 40 + ValuetodBFS(e.Message.Data(1))
                End If
            Else
                If "/channel/" & channelNumber & "/mixer/audio/1/dBFS" = e.Message.Address Then
                    ProgressBar1.Value = 40 + e.Message.Data(0)
                End If
                If "/channel/" & channelNumber & "/mixer/audio/2/dBFS" = e.Message.Address Then
                    ProgressBar2.Value = 40 + e.Message.Data(0)
                End If
            End If
        End If
        If ProgressBar1.Value > 38 Then
            ProgressBar1.Color = Color.Red
        ElseIf ProgressBar1.Value > 34 And ProgressBar1.Value < 38 Then
            ProgressBar1.Color = Color.Yellow
        ElseIf ProgressBar1.Value < 34 Then
            ProgressBar1.Color = Color.Green

        End If

        If ProgressBar2.Value > 38 Then
            ProgressBar2.Color = Color.Red
        ElseIf ProgressBar2.Value > 34 And ProgressBar2.Value < 38 Then
            ProgressBar2.Color = Color.Yellow
        ElseIf ProgressBar2.Value < 34 Then
            ProgressBar2.Color = Color.Green

        End If
    End Sub

    Private Delegate Sub invokeControlsDelegate1(ByVal e As OscMessageReceivedEventArgs)
    Private Sub sOscServer_MessageReceived(ByVal sender As Object, ByVal e As OscMessageReceivedEventArgs) Handles sOscServer.MessageReceived
        On Error Resume Next
        Me.invokeControls1(e)
    End Sub
    Sub stoposcserver()
        On Error Resume Next
        sOscServer.Stop()
        sOscServer.ClearMethods()
        sOscServer = Nothing
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
                    dt.Columns.Add("File_Name")
                    dt.Columns.Add("Duration")
                End If

                Dim f1 As New FileInfo(s1(i))
                dr = dt.NewRow()
                If (Path.GetExtension(f1.FullName).ToUpper = ".MXF") Or (Path.GetExtension(f1.FullName).ToUpper = ".TS") Then
                    GoTo 40
                End If

                If (f1.Attributes And FileAttributes.Hidden) <> 0 Or CheckFileHasCopied(f1.FullName) = False Then GoTo 50
40:             If UCase(Replace(f1.FullName.Substring(Len(mediafullpath)), "\", "/").ToString) Like "*" & UCase(Replace(txtsearch.Text, "\", "/")) & "*" Then

                    dr("File_Name") = Replace(f1.FullName.Substring(Len(mediafullpath)), "\", "/").ToString
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
                        dt.Columns.Add("File_Name")
                        dt.Columns.Add("Duration")
                    End If
                    If UCase(Replace(Replace(Split(aa(ss), "  ")(0), "\", "/"), """", "")) Like lblsearch.Text & "*" & UCase(Replace(txtsearch.Text, "\", "/")) & "*" Then

                        dr = dt.NewRow()
                        dr("File_Name") = Replace(Replace(Split(aa(ss), "  ")(0), "\", "/"), """", "")
                        'dr("File_Name") = aa(ss)
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
                        dt.Columns.Add("File_Name")
                        dt.Columns.Add("Duration")
                    End If
                    If UCase(Replace(CasparDevice.Mediafiles.Item(i).ToString, "\", "/").ToString) Like lblsearch.Text & "*" & UCase(Replace(txtsearch.Text, "\", "/")) & "*" Then

                        dr = dt.NewRow()
                        dr("File_Name") = Replace(CasparDevice.Mediafiles.Item(i).ToString, "\", "/")
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

        dgvclips.Columns("File_Name").Width = 400

        dgvclips.Columns("Duration").Width = 60

        dgvclips.Sort(dgvclips.Columns("File_Name"), System.ComponentModel.ListSortDirection.Ascending)

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
        cmbcasparcgwindowtitle.DataSource = New BindingSource(screenConsumres, "")
        cmbcasparcgwindowtitle.Text = "Screen consumer [2|PAL]"



    End Sub

    Private Sub cmdcueforclipgrid_Click(sender As Object, e As EventArgs) Handles cmdcueforclipgrid.Click
        On Error Resume Next
        cuefromclipgrid()
    End Sub
    Sub cuefromclipgrid()
        On Error Resume Next
        If dgvclips.CurrentRow.Cells("File_Name").Value = "" Then Exit Sub
        If System.IO.Path.GetExtension(mediafullpath & dgvclips.CurrentRow.Cells("File_Name").Value.ToString) = ".txt" Then
            readsubclip(mediafullpath & dgvclips.CurrentRow.Cells("File_Name").Value.ToString)
            If ServerVersion > 2.1 Then
                SendString(NetStream, "load " & channelNumber & "-" & layerNumber & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek * 2 & deinterlaced & vbCrLf)

            Else
                SendString(NetStream, "load " & channelNumber & "-" & layerNumber & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek & deinterlaced & vbCrLf)

            End If

        Else
            SendString(NetStream, "load " & channelNumber & "-" & layerNumber & " " & """" & ModifyFilename(dgvclips.CurrentRow.Cells("File_Name").Value) & """" & deinterlaced + vbCrLf)

        End If

        lastclickedbutton(cmdcueforclipgrid)
    End Sub
    Sub lastclickedbutton(sender As Object)
        cmdcueforclipgrid.BackColor = SystemColors.Control
        cmdcueforclipgrid.ForeColor = Color.Black

        cmdcuenextforclipgrid.BackColor = SystemColors.Control
        cmdcuenextforclipgrid.ForeColor = Color.Black

        cmdstopforclipgrid.BackColor = SystemColors.Control
        cmdstopforclipgrid.ForeColor = Color.Black

        cmdresumeforclipgrid.BackColor = SystemColors.Control
        cmdresumeforclipgrid.ForeColor = Color.Black



        cmdplayforclipgrid.BackColor = SystemColors.Control
        cmdplayforclipgrid.ForeColor = Color.Black

        cmdplaynextforclipgrid.BackColor = SystemColors.Control
        cmdplaynextforclipgrid.ForeColor = Color.Black



        cmdpauseforclipgrid.BackColor = SystemColors.Control
        cmdpauseforclipgrid.ForeColor = Color.Black

        sender.BackColor = Color.Green
        sender.ForeColor = Color.White
    End Sub



    Private Sub cmdplayforclipgrid_Click(sender As Object, e As EventArgs) Handles cmdplayforclipgrid.Click
        On Error Resume Next
        playfromclipgrid()
    End Sub
    Sub playfromclipgrid()
        On Error Resume Next

        If dgvclips.CurrentRow.Cells("File_Name").Value = "" Then Exit Sub
        If System.IO.Path.GetExtension(mediafullpath & dgvclips.CurrentRow.Cells("File_Name").Value.ToString) = ".txt" Then
            readsubclip(mediafullpath & dgvclips.CurrentRow.Cells("File_Name").Value.ToString)
            If ServerVersion > 2.1 Then
                CasparDevice.SendString("play " & channelNumber & "-" & layerNumber & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek * 2 & " length " & cliplength * 2 & deinterlaced)
            Else
                CasparDevice.SendString("play " & channelNumber & "-" & layerNumber & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek & " length " & cliplength & deinterlaced)
            End If
        Else
            CasparDevice.SendString("play " & channelNumber & "-" & layerNumber & " " & """" & ModifyFilename(dgvclips.CurrentRow.Cells("File_Name").Value) & """" & deinterlaced)
        End If

        'tmrduration.Enabled = True
        lastclickedbutton(cmdplayforclipgrid)
    End Sub


    Private Sub cmdpauseforclipgrid_Click(sender As Object, e As EventArgs) Handles cmdpauseforclipgrid.Click
        On Error Resume Next
        CasparDevice.SendString("pause " & channelNumber & "-" & layerNumber)
        lastclickedbutton(sender)
    End Sub

    Private Sub cmdresumeforclipgrid_Click(sender As Object, e As EventArgs) Handles cmdresumeforclipgrid.Click
        On Error Resume Next
        CasparDevice.SendString("play " & channelNumber & "-" & layerNumber)
        lastclickedbutton(sender)
    End Sub

    Private Sub cmdstopforclipgrid_Click(sender As Object, e As EventArgs) Handles cmdstopforclipgrid.Click
        On Error Resume Next
        CasparDevice.SendString("stop " & channelNumber & "-" & layerNumber)
        lastclickedbutton(sender)
    End Sub

    Private Sub cmdcuenextforclipgrid_Click(sender As Object, e As EventArgs) Handles cmdcuenextforclipgrid.Click
        On Error Resume Next
        Dim i As Integer
        i = dgvclips.CurrentRow.Index
        If i = (dgvclips.Rows.Count - 1) Then
            dgvclips.CurrentCell = dgvclips.Rows(0).Cells("File_Name")
        Else
            dgvclips.CurrentCell = dgvclips.Rows(i + 1).Cells("File_Name")
        End If

        If System.IO.Path.GetExtension(mediafullpath & dgvclips.CurrentRow.Cells("File_Name").Value.ToString) = ".txt" Then
            readsubclip(mediafullpath & dgvclips.CurrentRow.Cells("File_Name").Value.ToString)
            CasparDevice.SendString("load " & channelNumber & "-" & layerNumber & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek & " length " & cliplength & deinterlaced)
        Else
            CasparDevice.SendString("load " & channelNumber & "-" & layerNumber & " " & """" & ModifyFilename(dgvclips.CurrentRow.Cells("File_Name").Value) & """" & deinterlaced)
        End If
        'tmrduration.Enabled = True

        lastclickedbutton(sender)
    End Sub

    Private Sub cmdplaynextforclipgrid_Click(sender As Object, e As EventArgs) Handles cmdplaynextforclipgrid.Click
        On Error Resume Next
        Dim i As Integer
        i = dgvclips.CurrentRow.Index
        If i = (dgvclips.Rows.Count - 1) Then
            dgvclips.CurrentCell = dgvclips.Rows(0).Cells("File_Name")
        Else
            dgvclips.CurrentCell = dgvclips.Rows(i + 1).Cells("File_Name")
        End If

        If System.IO.Path.GetExtension(mediafullpath & dgvclips.CurrentRow.Cells("File_Name").Value.ToString) = ".txt" Then
            readsubclip(mediafullpath & dgvclips.CurrentRow.Cells("File_Name").Value.ToString)
            CasparDevice.SendString("play " & channelNumber & "-" & layerNumber & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek & " length " & cliplength & deinterlaced)
        Else
            CasparDevice.SendString("play " & channelNumber & "-" & layerNumber & " " & """" & ModifyFilename(dgvclips.CurrentRow.Cells("File_Name").Value) & """" & deinterlaced)
        End If
        'tmrduration.Enabled = True
        'palyloopinsecondchannel()
        lastclickedbutton(sender)
    End Sub

    Private Sub gbcliplist_Enter(sender As Object, e As EventArgs) Handles gbcliplist.Enter

    End Sub

    Public Sub cmdshowcasparcgwindowrecording_Click(sender As Object, e As EventArgs) Handles cmdshowcasparcgwindowrecording.Click
        On Error Resume Next
        SetProcessParentrecorder("casparcg", cmbcasparcgwindowtitle, pnlrecording)
    End Sub

    Public Sub inWindow()
        On Error Resume Next
        SetProcessParentrecorder("casparcg", cmbcasparcgwindowtitle, pnlrecording)
    End Sub

    Public Sub SetProcessParentrecorder(ByVal processName As String, ByVal cmb As ComboBox, ByVal pnl As Panel)
        On Error Resume Next
        Dim processes() As Process = Process.GetProcessesByName(processName)
        Dim iprocess As Integer

        For iprocess = 0 To processes.GetUpperBound(0)
            If processes(iprocess).MainWindowTitle = cmb.Text Then Exit For
        Next
        parentedProcess1 = processes(iprocess)
        SetParent(parentedProcess1.MainWindowHandle, pnl.Handle)
        SendMessage(parentedProcess1.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)

    End Sub
    Public parentedProcess1 As Process
    Private Sub cmdoutcasparcgwindowrecording_Click(sender As Object, e As EventArgs) Handles cmdoutcasparcgwindowrecording.Click
        On Error Resume Next
        If Not parentedProcess1 Is Nothing Then
            SetParent(parentedProcess1.MainWindowHandle, Nothing)
        End If
    End Sub

    Private Sub ucVideoPlayer_DockChanged(sender As Object, e As EventArgs) Handles Me.DockChanged
        Me.cmdoutcasparcgwindowrecording.PerformClick()
    End Sub
End Class
