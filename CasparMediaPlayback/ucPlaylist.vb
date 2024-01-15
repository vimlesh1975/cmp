Imports System.IO
Imports System.Data
Public Class ucPlaylist
    Public i As Integer 'for loop
    Public j As Integer
    Public k As Integer
    Public jj As Integer
    Private Sub dgvclips_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvclips.CellContentClick
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
        ElseIf frmmediaplayer.uctab1.UcPlaylistSetting1.rdoclipfromserver.Checked Then
            Dim aa() As String
            If ServerVersion = 2.1 Then 'added because server 2.1 sends each files as indivisual , no folder name. 150119
                'MsgBox("from 2.1")
                CasparDevice.RefreshMediafiles()
                Threading.Thread.Sleep(500)
                ReDim aa(CasparDevice.Mediafiles.Count)
                For iclips = 0 To CasparDevice.Mediafiles.Count - 1
                    Dim foldername As String = ""
                    foldername = Mid(CasparDevice.Mediafiles.Item(iclips).Name, 1, Len(CasparDevice.Mediafiles.Item(iclips).Name) - Len(Split(CasparDevice.Mediafiles.Item(iclips).Name, "/").Last) - 1)
                    aa(iclips) = "Clips\" & Replace(foldername, "/", "\")
                Next
            ElseIf ServerVersion = 2.0 Then
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
        ElseIf frmmediaplayer.uctab1.UcPlaylistSetting1.rdoclipfromserver.Checked Then
            lblsearch.Text = Replace(Mid(tvclips.SelectedNode.FullPath, 5 + 2), "\", "/") & "/"
        End If
        If lblsearch.Text = "/" Then lblsearch.Text = ""
        txtsearch.Text = ""
    End Sub
    Sub initialiseplaylistdata()
        On Error Resume Next
        Me.DateTimePicker1.Value = Now
        Me.DateTimePicker1.CustomFormat = "dd/MMM HH:mm:ss"

        dgv1.Rows.Add(15)
        Me.dgv1.Item("File_Name", 0).Value = "go1080p25.mp4"
        Me.dgv1.Item("File_Name", 1).Value = "CG1080i50.mp4"
        Me.dgv1.Item("File_Name", 2).Value = "amb.mp4"
        Me.dgv1.Item("File_Name", 3).Value = "CG1080i50_A.mp4"
        Me.dgv1.Item("File_Name", 4).Value = "go1080p25.mp4"
        Me.dgv1.Item("File_Name", 5).Value = "CG1080i50.mp4"
        Me.dgv1.Item("File_Name", 6).Value = "amb.mp4"

        Me.dgv1.Item("Clip_Duration", 0).Value = "00:00:17"
        Me.dgv1.Item("Clip_Duration", 1).Value = "00:00:10"
        Me.dgv1.Item("Clip_Duration", 2).Value = "00:00:10"
        Me.dgv1.Item("Clip_Duration", 3).Value = "00:00:10"
        Me.dgv1.Item("Clip_Duration", 4).Value = "00:00:17"
        Me.dgv1.Item("Clip_Duration", 5).Value = "00:00:10"
        Me.dgv1.Item("Clip_Duration", 6).Value = "00:00:10"

        Me.dgv1.Item("Column3", 0).Value = System.Drawing.Image.FromFile(thumbnailsfullpath & "go1080p25.png")
        Me.dgv1.Item("Column3", 1).Value = System.Drawing.Image.FromFile(thumbnailsfullpath & "CG1080i50.png")
        Me.dgv1.Item("Column3", 2).Value = System.Drawing.Image.FromFile(thumbnailsfullpath & "amb.png")
        Me.dgv1.Item("Column3", 3).Value = System.Drawing.Image.FromFile(thumbnailsfullpath & "CG1080i50_A.png")
        Me.dgv1.Item("Column3", 4).Value = System.Drawing.Image.FromFile(thumbnailsfullpath & "go1080p25.png")
        Me.dgv1.Item("Column3", 5).Value = System.Drawing.Image.FromFile(thumbnailsfullpath & "CG1080i50.png")
        Me.dgv1.Item("Column3", 6).Value = System.Drawing.Image.FromFile(thumbnailsfullpath & "amb.png")

        Me.dgv1.Item("Template_File", 0).Value = "C:\casparcg\mydata\rundown\File_Based_Graphics_List.txt"

        Dim i As Integer
        For i = 0 To dgv1.Rows.Count - 1
            dgv1.Item("x", i).Value = 1
            dgv1.Item("Transition", i).Value = "MIX"
            dgv1.Item("T_Duration", i).Value = 10
            dgv1.Item("AudioLevel", i).Value = 1.0

        Next

        Me.dgv1.Item("FileType", 0).Value = "Others"
        Me.dgv1.Item("FileType", 1).Value = "Program"
        Me.dgv1.Item("FileType", 2).Value = "Promo"
        Me.dgv1.Item("FileType", 3).Value = "Commercial"
        Me.dgv1.Item("FileType", 4).Value = "Others"
        Me.dgv1.Item("FileType", 5).Value = "Program"
        Me.dgv1.Item("FileType", 6).Value = "Promo"

    End Sub

    Sub enableplaylist()
        On Error Resume Next
        chkplaylistlock.Checked = False
    End Sub
    Sub disableplaylist()
        On Error Resume Next
        chkplaylistlock.Checked = True
    End Sub

    Public Sub cmdstartplaylist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstartplaylist.Click
        On Error Resume Next
        startPlaylist()
    End Sub

    Public Sub startPlaylist()
        On Error Resume Next
        'if nothing is selected
        Dim bbb As Integer = 0
        For aaa = 0 To dgv1.RowCount - 1
            bbb = bbb + dgv1.Item("x", aaa).Value
        Next
        If bbb = 0 Then MsgBox("no clip is selected") : Exit Sub

        playlist()
        chkplaylistlock.Checked = True
        txtdurationofplalist.Focus() 'Remove focus from startplaylist button, so that enter button should not click it again.

        iclippauseresume = 1
    End Sub

    Sub playlist()
        On Error Resume Next

        currrow = Me.dgv1.CurrentRow.Index

        If dgv1.CurrentRow.Cells("x").Value = 1 Then
            If (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 8)).ToUpper = "DECKLINK" Then

                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & dgv1.CurrentRow.Cells("File_Name").Value & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)
                GoTo 30
            End If

            If (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "HTTP" Then
                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " [HTML] " & dgv1.CurrentRow.Cells("File_Name").Value & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)
                GoTo 30
            End If
            If (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "UDP:" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "RTP:" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "TCP:" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "RTMP" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "RTSP" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "RTCP" Then

                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & dgv1.CurrentRow.Cells("File_Name").Value & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)
                GoTo 30
            End If

            If frmmediaplayer.ucTab1.UcPlaylistSetting1.chkLoadbg.Checked Then
                If System.IO.Path.GetExtension(mediafullpath & dgv1.CurrentRow.Cells("File_Name").Value.ToString) = ".txt" Then
                    readsubclip(mediafullpath & dgv1.CurrentRow.Cells("File_Name").Value.ToString)
                    If ServerVersion > 2.1 Then
                        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek * 2 & " length " & cliplength * 2 & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)

                    Else
                        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek & " length " & cliplength & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)

                    End If
                    CasparDevice.SendString("loadbg " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(dgv1.Rows(dgv1.CurrentRow.Index + 1).Cells("File_Name").Value) & """")
                Else

                    CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(dgv1.CurrentRow.Cells("File_Name").Value) & """" & "  " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)
                    CasparDevice.SendString("loadbg " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(dgv1.Rows(dgv1.CurrentRow.Index + 1).Cells("File_Name").Value) & """")
                End If
            Else
                If System.IO.Path.GetExtension(mediafullpath & dgv1.CurrentRow.Cells("File_Name").Value.ToString) = ".txt" Then
                    readsubclip(mediafullpath & dgv1.CurrentRow.Cells("File_Name").Value.ToString)
                    CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek & " length " & cliplength & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)
                Else
                    CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(dgv1.CurrentRow.Cells("File_Name").Value) & """" & "  " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)

                End If
            End If

30:         sendmixercommandforclip() 'decklink play was not sending amcp command 'reported by forum member mrvdberg 11112019

        End If
        createasrunlog()
        If dgv1.Rows(currrow).Cells("Column11").Value = True Then
            calculateinterval()
        Else
            tmrnextclip.Interval = 1000
        End If
        tmrduration.Enabled = True

        tmrfornotskiping.Enabled = True

        Me.tmrstartattime.Enabled = False
        chkplaylistlock.Checked = True
        adjusttimeofplaylist()

        linktemplatetoplaylist()
    End Sub

    Sub sendmixercommandforclip()
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " volume " & dgv1.CurrentRow.Cells("AudioLevel").Value)
        Threading.Thread.Sleep(frmmediaplayer.ucTab1.UcPlaylistSetting1.txtmixercommandforconversion.Text)
        If dgv1.CurrentRow.Cells("Conversion").Value = 1 Then 'for conversion

            'With ucPlaylistSetting
            With frmmediaplayer.ucTab1.UcPlaylistSetting1
                If .rdocentercutsetting.Checked Then
                    CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " fill " & .txtcentercutsetting.Text)
                ElseIf .rdoletterboxsettings.Checked Then
                    CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " fill " & .txtletterboxsettings.Text)
                ElseIf .rdopillarboxsettings.Checked Then
                    CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " fill " & .txtpillarboxsettings.Text)
                ElseIf .rdocropsettings.Checked Then
                    CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " fill " & .txtcropsettings.Text)
                ElseIf .rdoanamorphic.Checked Then
                    CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " fill " & .txtanamorphic.Text)
                End If
            End With
        Else

            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " fill 0 0 1 1")
        End If

        If dgv1.Rows(currrow).Cells("AMCPCommands").Value <> "" Then

            Dim aa() = Split(dgv1.Rows(currrow).Cells("AMCPCommands").Value, ",,")
            For inumberofcommands = 0 To aa.Count - 1
                CasparDevice.SendString(aa(inumberofcommands))
            Next

        End If

    End Sub
    Sub calculateinterval()
        Dim dH As Integer
        Dim dM As Integer
        Dim dS As Integer
        Dim dd As Array = Split(dgv1.Rows(currrow).Cells("Clip_Duration").Value, ":")
        dH = dd(0)
        dM = dd(1)
        dS = dd(2)
        Dim totalsecond As Integer = dH * 3600 + dM * 60 + dS
        tmrnextclip.Interval = totalsecond * 1000 - tmrfornotskiping.Interval
    End Sub
    Sub createasrunlog()
        Dim filename As String = "c:/casparcg/mydata/asrunlog/asrunlog_" & DateTime.Now.ToString("ddMMyy") & ".txt"
        If System.IO.File.Exists(filename) = False Then
            System.IO.File.Create(filename)
        End If
        GC.Collect()
        GC.WaitForPendingFinalizers()
        Using sw As StreamWriter = System.IO.File.AppendText(filename)
            sw.WriteLine(Now & vbTab & dgv1.CurrentRow.Cells("Clip_Duration").Value & vbTab & vbTab & dgv1.CurrentRow.Cells("File_Name").Value)
            sw.Close()
        End Using
    End Sub

    Sub openfile()
        ' On Error Resume Next
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = "c:\casparcg\mydata\playlist\"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            SaveToolStripMenuItem.Enabled = True
            Using sr As StreamReader = New StreamReader(ofd2.FileName)
                'clear list
                dgv1.Rows.Clear()
                'Loop through and add list to the file.
                Dim g As Integer = 0
                Dim li As String
                Do Until sr.EndOfStream = True
                    li = sr.ReadLine()
                    dgv1.Rows.Add()
                    Dim xyz As Array = Split(li, Chr(2))
                    dgv1.Rows(g).Cells("File_Name").Value = xyz(0)
                    dgv1.Rows(g).Cells("Start_Time").Value = xyz(1)
                    dgv1.Rows(g).Cells("x").Value = xyz(2)
                    dgv1.Rows(g).Cells("Transition").Value = xyz(3)
                    dgv1.Rows(g).Cells("T_Duration").Value = xyz(4)
                    dgv1.Rows(g).Cells("LoopVideo").Value = xyz(5)
                    dgv1.Rows(g).Cells("Clip_Duration").Value = xyz(6)
                    If chkshowthumbnail.Checked Then
                        Dim aa As Array = Split(xyz(0), ".")
                        If aa.Length = 2 Then
                            If aa(1) = "txt" Then
                                readsubclip(mediafullpath & xyz(0))
                                If System.IO.File.Exists(thumbnailsfullpath & Split(masterfilename, ".")(0) & ".png") Then
                                    dgv1.Rows(g).Cells("Column3").Value = System.Drawing.Image.FromFile(thumbnailsfullpath & Split(masterfilename, ".")(0) & ".png")
                                End If
                            Else
                                If System.IO.File.Exists(thumbnailsfullpath & aa(0) & ".png") Then
                                    dgv1.Rows(g).Cells("Column3").Value = System.Drawing.Image.FromFile(thumbnailsfullpath & aa(0) & ".png")
                                End If
                            End If
                        End If
                    End If

                    dgv1.Rows(g).Cells("Column11").Value = xyz(7)
                    dgv1.Rows(g).Cells("AudioLevel").Value = xyz(8)
                    dgv1.Rows(g).Cells("Conversion").Value = xyz(9)
                    dgv1.Rows(g).Cells("clmFilter").Value = xyz(10)
                    dgv1.Rows(g).Cells("Template_File").Value = xyz(11)
                    dgv1.Rows(g).Cells("FileType").Value = xyz(12)
                    dgv1.Rows(g).Cells("BackIn").Value = xyz(13)
                    dgv1.Rows(g).Cells("AMCPCommands").Value = xyz(14)
                    g = g + 1
                Loop
                sr.Close()
            End Using
            Me.lblplalistname.Text = "playlist=  " & ofd2.FileName
        End If
    End Sub

    Sub openfile(filename As String)
        ' On Error Resume Next
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = "c:\casparcg\mydata\playlist\"

        SaveToolStripMenuItem.Enabled = True
        Using sr As StreamReader = New StreamReader(filename)
            'clear list
            dgv1.Rows.Clear()
            'Loop through and add list to the file.
            Dim g As Integer = 0
            Dim li As String
            Do Until sr.EndOfStream = True
                li = sr.ReadLine()
                dgv1.Rows.Add()
                Dim xyz As Array = Split(li, Chr(2))
                dgv1.Rows(g).Cells("File_Name").Value = xyz(0)
                dgv1.Rows(g).Cells("Start_Time").Value = xyz(1)
                dgv1.Rows(g).Cells("x").Value = xyz(2)
                dgv1.Rows(g).Cells("Transition").Value = xyz(3)
                dgv1.Rows(g).Cells("T_Duration").Value = xyz(4)
                dgv1.Rows(g).Cells("LoopVideo").Value = xyz(5)
                dgv1.Rows(g).Cells("Clip_Duration").Value = xyz(6)
                If chkshowthumbnail.Checked Then
                    Dim aa As Array = Split(xyz(0), ".")
                    If aa.Length = 2 Then
                        If aa(1) = "txt" Then
                            readsubclip(mediafullpath & xyz(0))
                            If System.IO.File.Exists(thumbnailsfullpath & Split(masterfilename, ".")(0) & ".png") Then
                                dgv1.Rows(g).Cells("Column3").Value = System.Drawing.Image.FromFile(thumbnailsfullpath & Split(masterfilename, ".")(0) & ".png")
                            End If
                        Else
                            If System.IO.File.Exists(thumbnailsfullpath & aa(0) & ".png") Then
                                dgv1.Rows(g).Cells("Column3").Value = System.Drawing.Image.FromFile(thumbnailsfullpath & aa(0) & ".png")
                            End If
                        End If
                    End If
                End If

                dgv1.Rows(g).Cells("Column11").Value = xyz(7)
                dgv1.Rows(g).Cells("AudioLevel").Value = xyz(8)
                dgv1.Rows(g).Cells("Conversion").Value = xyz(9)
                dgv1.Rows(g).Cells("clmFilter").Value = xyz(10)
                g = g + 1
            Loop
            sr.Close()
        End Using
        Me.lblplalistname.Text = "playlist=  " & ofd2.FileName

    End Sub


    Sub insertfile()
        On Error Resume Next
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = "c:\casparcg\mydata\playlist\"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)

                Dim g As Integer = dgv1.CurrentRow.Index
                Dim li As String
                Do Until sr.EndOfStream = True
                    li = sr.ReadLine()
                    dgv1.Rows.Insert(dgv1.CurrentRow.Index, 1)
                    Dim xyz As Array = Split(li, Chr(2))
                    dgv1.Rows(g).Cells("File_Name").Value = xyz(0)
                    dgv1.Rows(g).Cells("Start_Time").Value = xyz(1)
                    dgv1.Rows(g).Cells("x").Value = xyz(2)
                    dgv1.Rows(g).Cells("Transition").Value = xyz(3)
                    dgv1.Rows(g).Cells("T_Duration").Value = xyz(4)
                    dgv1.Rows(g).Cells("LoopVideo").Value = xyz(5)
                    dgv1.Rows(g).Cells("Clip_Duration").Value = xyz(6)
                    If chkshowthumbnail.Checked Then
                        Dim aa As Array = Split(xyz(0), ".")
                        If aa.Length = 2 Then
                            If aa(1) = "txt" Then
                                readsubclip(mediafullpath & xyz(0))
                                If System.IO.File.Exists(thumbnailsfullpath & Split(masterfilename, ".")(0) & ".png") Then
                                    dgv1.Rows(g).Cells("Column3").Value = System.Drawing.Image.FromFile(thumbnailsfullpath & Split(masterfilename, ".")(0) & ".png")
                                End If
                            Else
                                If System.IO.File.Exists(thumbnailsfullpath & aa(0) & ".png") Then
                                    dgv1.Rows(g).Cells("Column3").Value = System.Drawing.Image.FromFile(thumbnailsfullpath & aa(0) & ".png")
                                End If
                            End If
                        End If
                    End If
                    dgv1.Rows(g).Cells("Column11").Value = xyz(7)
                    dgv1.Rows(g).Cells("AudioLevel").Value = xyz(8)
                    dgv1.Rows(g).Cells("Conversion").Value = xyz(9)
                    dgv1.Rows(g).Cells("clmFilter").Value = xyz(10)
                    dgv1.Rows(g).Cells("Template_File").Value = xyz(11)
                    dgv1.Rows(g).Cells("FileType").Value = xyz(12)
                    dgv1.Rows(g).Cells("BackIn").Value = xyz(13)
                    dgv1.Rows(g).Cells("AMCPCommands").Value = xyz(14)
                    g = g + 1
                Loop
                sr.Close()
            End Using
            Me.lblplalistname.Text = "playlist=  " & Me.lblplalistname.Text & " + " & ofd2.FileName
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        savefile()
    End Sub
    Sub savefile()
        On Error Resume Next
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "c:\casparcg\mydata\playlist\"

        osd2.FileName = Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName((Date.Today).DayOfWeek) & "_" & (Date.Today).Day & "_" & (Date.Today).Month & "_" & (Date.Today).Year & "_" & (TimeOfDay.Hour + 1) & "HRS"
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgv1.Rows.Count = 0 Then
                    sw.Write("")
                Else
                    'Loop through and add list to the file.
                    Dim f As Integer = 0
                    Do Until f = dgv1.Rows.Count
                        If dgv1.Rows(f).Cells("x").Value = False Then dgv1.Rows(f).Cells("x").Value = "0"
                        If dgv1.Rows(f).Cells("Column11").Value = False Then dgv1.Rows(f).Cells("Column11").Value = "0"
                        If dgv1.Rows(f).Cells("Conversion").Value = False Then dgv1.Rows(f).Cells("Conversion").Value = "0"
                        If dgv1.Rows(f).Cells("BackIn").Value = False Then dgv1.Rows(f).Cells("BackIn").Value = "0"

                        sw.WriteLine(dgv1.Rows(f).Cells("File_Name").Value & Chr(2) & dgv1.Rows(f).Cells("Start_Time").Value & Chr(2) & dgv1.Rows(f).Cells("x").Value & Chr(2) & dgv1.Rows(f).Cells("Transition").Value & Chr(2) & dgv1.Rows(f).Cells("T_Duration").Value & Chr(2) & dgv1.Rows(f).Cells("LoopVideo").Value & Chr(2) & dgv1.Rows(f).Cells("Clip_Duration").Value & Chr(2) & dgv1.Rows(f).Cells("Column11").Value & Chr(2) & dgv1.Rows(f).Cells("AudioLevel").Value & Chr(2) & dgv1.Rows(f).Cells("Conversion").Value & Chr(2) & dgv1.Rows(f).Cells("clmFilter").Value & Chr(2) & dgv1.Rows(f).Cells("Template_File").Value & Chr(2) & dgv1.Rows(f).Cells("FileType").Value & Chr(2) & dgv1.Rows(f).Cells("BackIn").Value & Chr(2) & dgv1.Rows(f).Cells("AMCPCommands").Value)
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            Me.lblplalistname.Text = "playlist=  " & osd2.FileName
            SaveToolStripMenuItem.Enabled = True
        End If
    End Sub

    Sub showlivedecklink(devicenumber As Integer)
        On Error Resume Next
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " decklink " & devicenumber)
    End Sub
    Private Sub btnstartattime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstartattime.Click
        On Error Resume Next
        'if nothing is selected
        Dim bbb As Integer = 0
        For aaa = 0 To dgv1.RowCount - 1
            bbb = bbb + dgv1.Rows(aaa).Cells("x").Value
        Next
        If bbb = 0 Then MsgBox("no clip is selected") : Exit Sub

        Dim aa As Date = DateTimePicker1.Value
        Dim elapsed As Integer
        elapsed = (aa.Date - Now.Date).Days
        If ((23 < elapsed) Or (0 > elapsed)) Then
            MsgBox("value must be less than 23 days" & "Your value is " & elapsed)
            Exit Sub
        End If

        timeinterval = (86400000 * elapsed) + (aa.Hour - Now.Hour) * 3600000 + (aa.Minute - Now.Minute) * 60000 + (aa.Second - Now.Second) * 1000
        If timeinterval < 0 Then
            MsgBox("Past time is not allowed")
            Exit Sub
        End If

        Me.tmrstartattime.Interval = timeinterval
        Me.tmrstartattime.Enabled = True

        chkplaylistlock.Checked = True
    End Sub

    Private Sub tmrstartattime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrstartattime.Tick
        On Error Resume Next
        Me.tmrstartattime.Enabled = False
        playlist()
    End Sub

    Private Sub cmddurationofplaylist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddurationofplaylist.Click
        On Error Resume Next
        Dim dH As Integer = 0
        Dim dM As Integer = 0
        Dim dS As Integer = 0

        For iduration = 0 To dgv1.Rows.Count - 1
            If dgv1.Rows(iduration).Cells("x").Value = 1 Then
                Dim dd As Array = Split(dgv1.Rows(iduration).Cells("Clip_Duration").Value, ":")
                dH = dH + dd(0)
                dM = dM + dd(1)
                dS = dS + dd(2)
            End If
        Next
        Dim totalsecond As Integer = dH * 3600 + dM * 60 + dS
        Dim aa = TimeSpan.FromSeconds(totalsecond)

        txtdurationofplalist.Text = aa.Hours & ":" & aa.Minutes & ":" & aa.Seconds
    End Sub
    Private Sub cmdremainingdurationofplaylist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremainingdurationofplaylist.Click
        On Error Resume Next
        Dim dH As Integer = Split(frmmediaplayer.lblremainintime.Text, ":")(0) ' Split(dgv1.CurrentRow.Cells("Duration").Value, ":")(0)
        Dim dM As Integer = Split(frmmediaplayer.lblremainintime.Text, ":")(1)
        Dim dS As Integer = Split(frmmediaplayer.lblremainintime.Text, ":")(2)

        For iduration = ((dgv1.CurrentRow.Index) + 1) To dgv1.Rows.Count - 1
            If dgv1.Rows(iduration).Cells("x").Value = 1 Then
                Dim dd As Array = Split(dgv1.Rows(iduration).Cells("Clip_Duration").Value, ":")
                dH = dH + dd(0)
                dM = dM + dd(1)
                dS = dS + dd(2)
            End If
        Next

        Dim totalsecond As Integer = dH * 3600 + dM * 60 + dS
        Dim aa = TimeSpan.FromSeconds(totalsecond)

        txtremaingdurationofplaylist.Text = aa.Hours & ":" & aa.Minutes & ":" & aa.Seconds
    End Sub

    Public Sub PlaySingleClip()
        On Error Resume Next
        currrow = dgv1.CurrentRow.Index
        If dgv1.CurrentRow.Cells("File_Name").Value = "" Then Exit Sub

        playcommand()

        sendmixercommandforclip()
        tmrduration.Enabled = True
        createasrunlog()

        iclippauseresume = 1
    End Sub

    Sub playcommand()
        If (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 8)).ToUpper = "DECKLINK" Then
            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & dgv1.CurrentRow.Cells("File_Name").Value & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)
        ElseIf (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "HTTP" Then
            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " [HTML] " & dgv1.CurrentRow.Cells("File_Name").Value & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)

        ElseIf (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "UDP:" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "RTP:" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "TCP:" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "RTMP" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "RTSP" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "RTCP" Then

            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & dgv1.CurrentRow.Cells("File_Name").Value & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)


        ElseIf System.IO.Path.GetExtension(mediafullpath & dgv1.CurrentRow.Cells("File_Name").Value.ToString) = ".txt" Then
            readsubclip(mediafullpath & dgv1.CurrentRow.Cells("File_Name").Value.ToString)

            frmmediaplayer.ucCasparcgWindow1.txtmarkin.Text = clipseek
            frmmediaplayer.ucCasparcgWindow1.txtmarkout.Text = cliplength + clipseek
            If ServerVersion > 2.1 Then '
                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & (clipseek) * 2 & " length " & (cliplength) * 2 & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)

            Else

                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek & " length " & cliplength & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)

            End If
        Else

            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(dgv1.CurrentRow.Cells("File_Name").Value) & """" & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)

        End If
        linktemplatetoplaylist()

    End Sub

    Sub linktemplatetoplaylist()

        If chktemplatewithplaylist.Checked Then
            dgv1.CurrentRow.Cells("Start_Time").Value = Format(Now, "HH:mm:ss")

            ucTemplate.stopshedule()
            ucTemplate.dgvrundown.Rows.Clear()

            If dgv1.CurrentRow.Cells("Template_File").Value <> "" And File.Exists(dgv1.CurrentRow.Cells("Template_File").Value) Then
                ucTemplate.openfilerundown(dgv1.CurrentRow.Cells("Template_File").Value)
                ucTemplate.txtadjusttimeofrundownmin.Text = (Mid(dgv1.CurrentRow.Cells("Start_Time").Value, 1, 2)) * 60 + Mid(dgv1.CurrentRow.Cells("Start_Time").Value, 4, 2)
                ucTemplate.txtadjusttimeofrundownsec.Text = Mid(dgv1.CurrentRow.Cells("Start_Time").Value, 7, 2)
                ucTemplate.adjusttimeofrundown()
                ucTemplate.sheduletemplate()
            End If
        End If
    End Sub
    Sub nextclipplay()
        On Error Resume Next
        'if nothing is selected
        Dim bbb As Integer = 0
        For aaa = 0 To dgv1.RowCount - 1
            bbb = bbb + dgv1.Rows(aaa).Cells("x").Value
        Next
        If bbb = 0 Then MsgBox("no clip is selected") : Exit Sub

        On Error Resume Next
20:
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        If i = (dgv1.Rows.Count - 1) Then
            dgv1.CurrentCell = dgv1.Rows(0).Cells("File_Name")
            currrow = 0
        Else
            dgv1.CurrentCell = dgv1.Rows(i + 1).Cells("File_Name")
            currrow = currrow + 1
        End If
        If dgv1.CurrentRow.Cells("File_Name").Value = "" Or dgv1.CurrentRow.Cells("x").Value = 0 Then GoTo 20

        playcommand()

        sendmixercommandforclip()
        tmrduration.Enabled = True
    End Sub

    Sub nextclip()
        On Error Resume Next
20:
        Dim i As Integer
        i = dgv1.CurrentRow.Index
        If i = (dgv1.Rows.Count - 1) Then
            dgv1.CurrentCell = dgv1.Rows(0).Cells("File_Name")
            currrow = 0
        Else
            dgv1.CurrentCell = dgv1.Rows(i + 1).Cells("File_Name")
            currrow = currrow + 1
        End If

        If dgv1.CurrentRow.Cells("File_Name").Value = "" Or dgv1.CurrentRow.Cells("x").Value = 0 Then GoTo 20

        If (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 8)).ToUpper = "DECKLINK" Then
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & dgv1.CurrentRow.Cells("File_Name").Value & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)
        ElseIf (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "HTTP" Then
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " [HTML] " & dgv1.CurrentRow.Cells("File_Name").Value & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)
        ElseIf (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "UDP:" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "RTP:" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "TCP:" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "RTMP" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "RTSP" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "RTCP" Then

            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & dgv1.CurrentRow.Cells("File_Name").Value & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)

        ElseIf System.IO.Path.GetExtension(mediafullpath & dgv1.CurrentRow.Cells("File_Name").Value.ToString) = ".txt" Then
            readsubclip(mediafullpath & dgv1.CurrentRow.Cells("File_Name").Value.ToString)

            frmmediaplayer.ucCasparcgWindow1.txtmarkin.Text = clipseek
            frmmediaplayer.ucCasparcgWindow1.txtmarkout.Text = cliplength + clipseek
            If ServerVersion > 2.1 Then
                CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek * 2 & " length " & cliplength * 2 & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)

            Else
                CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek & " length " & cliplength & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)

            End If
        Else
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(dgv1.CurrentRow.Cells("File_Name").Value) & """" & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)
        End If
        sendmixercommandforclip()
        tmrduration.Enabled = True

    End Sub

    Sub clipstop()
        On Error Resume Next

        CasparDevice.SendString("stop " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)

    End Sub

    Sub clippause()
        On Error Resume Next

        If dgv1.CurrentRow.Cells("File_Name").Value = "" Then Exit Sub
        If Microsoft.VisualBasic.Strings.Right(frmmediaplayer.ucCasparcgWindow1.lblplaying.Text, 3) <> "mav" Then
            CasparDevice.SendString("pause " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)

        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " pause")
        End If
    End Sub

    Sub clipresume()
        On Error Resume Next

        If iclippauseresume = 1 Then
            If Microsoft.VisualBasic.Strings.Right(frmmediaplayer.ucCasparcgWindow1.lblplaying.Text, 3) <> "mav" Then
                CasparDevice.SendString("pause " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)
            Else
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " speed 0") 'for slow motion
            End If

        Else
            If Microsoft.VisualBasic.Strings.Right(frmmediaplayer.ucCasparcgWindow1.lblplaying.Text, 3) <> "mav" Then
                CasparDevice.SendString("resume " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)
            Else
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " speed 1") 'for slow motion
            End If

        End If
        iclippauseresume = iclippauseresume + 1
        If iclippauseresume = 3 Then iclippauseresume = 1

        tmrduration.Enabled = True
    End Sub
    Private Sub tmrnextclip_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrnextclip.Tick
        On Error Resume Next
        If dgv1.Rows(currrow).Cells("File_Name").Value = "end" Then
            tmrnextclip.Enabled = False
        Else
            nextclipofplaylist()
        End If
    End Sub
    Sub nextclipofplaylist()

        On Error Resume Next
        'if nothing is selected
        Dim bbb As Integer = 0
        For aaa = 0 To dgv1.RowCount - 1
            bbb = bbb + dgv1.Rows(aaa).Cells("x").Value
        Next
        If bbb = 0 Then tmrnextclip.Enabled = False : Exit Sub

        If ((clipsleftduration < 1.0) And (dgv1.Rows(currrow).Cells("LoopVideo").Value <> "loop")) Or (dgv1.Rows(currrow).Cells("x").Value = 0) Or tmrnextclip.Interval > 1000 Then
            Dim tempcurrentrow As Integer = dgv1.CurrentRow.Index ' for selected row to remain same. Suggested by srk 04.06.18

20:
            Dim inextclipofplaylist As Integer
            inextclipofplaylist = dgv1.Rows(currrow).Index
            If inextclipofplaylist = (dgv1.Rows.Count - 1) Then
                dgv1.CurrentCell = dgv1.Rows(0).Cells("File_Name")
                currrow = 0
            Else
                dgv1.CurrentCell = dgv1.Rows(inextclipofplaylist + 1).Cells("File_Name")
                currrow = currrow + 1
            End If
            If dgv1.Rows(currrow).Cells("File_Name").Value = "" Or dgv1.Rows(currrow).Cells("x").Value = 0 Then GoTo 20

            If Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 8) = "decklink" Then
                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & dgv1.CurrentRow.Cells("File_Name").Value & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)
                GoTo 30
            End If

            If (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "HTTP" Then
                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " [HTML] " & dgv1.CurrentRow.Cells("File_Name").Value & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)
                GoTo 30
            End If

            If (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "UDP:" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "RTP:" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "TCP:" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "RTMP" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "RTSP" Or
                (Mid(dgv1.CurrentRow.Cells("File_Name").Value, 1, 4)).ToUpper = "RTCP" Then

                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & dgv1.CurrentRow.Cells("File_Name").Value & " " & dgv1.CurrentRow.Cells("Transition").Value & " " & dgv1.CurrentRow.Cells("T_Duration").Value & " " & dgv1.CurrentRow.Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)
                GoTo 30
            End If

            If frmmediaplayer.ucTab1.UcPlaylistSetting1.chkLoadbg.Checked Then
                If System.IO.Path.GetExtension(mediafullpath & dgv1.Rows(currrow).Cells("File_Name").Value.ToString) = ".txt" Then
                    readsubclip(mediafullpath & dgv1.CurrentRow.Cells("File_Name").Value.ToString)
                    If ServerVersion > 2.1 Then
                        CasparDevice.SendString("PLAY " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek * 2 & " length " & cliplength * 2 & " " & dgv1.Rows(currrow).Cells("Transition").Value & " " & dgv1.Rows(currrow).Cells("T_Duration").Value & " " & dgv1.Rows(currrow).Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)

                    Else
                        CasparDevice.SendString("PLAY " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek & " length " & cliplength & " " & dgv1.Rows(currrow).Cells("Transition").Value & " " & dgv1.Rows(currrow).Cells("T_Duration").Value & " " & dgv1.Rows(currrow).Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)

                    End If
                    CasparDevice.SendString("loadbg " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(dgv1.Rows(currrow + 1).Cells("File_Name").Value) & """")

                Else

                    CasparDevice.SendString("PLAY " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(dgv1.Rows(currrow).Cells("File_Name").Value) & """" & "  " & dgv1.Rows(currrow).Cells("Transition").Value & " " & dgv1.Rows(currrow).Cells("T_Duration").Value & " " & dgv1.Rows(currrow).Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)
                    CasparDevice.SendString("loadbg " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(dgv1.Rows(currrow + 1).Cells("File_Name").Value) & """")

                End If
            Else
                If System.IO.Path.GetExtension(mediafullpath & dgv1.CurrentRow.Cells("File_Name").Value.ToString) = ".txt" Then
                    readsubclip(mediafullpath & dgv1.CurrentRow.Cells("File_Name").Value.ToString)
                    CasparDevice.SendString("PLAY " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek & " length " & cliplength & " " & dgv1.Rows(currrow).Cells("Transition").Value & " " & dgv1.Rows(currrow).Cells("T_Duration").Value & " " & dgv1.Rows(currrow).Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)
                Else

                    CasparDevice.SendString("PLAY " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(dgv1.Rows(currrow).Cells("File_Name").Value) & """" & "  " & dgv1.Rows(currrow).Cells("Transition").Value & " " & dgv1.Rows(currrow).Cells("T_Duration").Value & " " & dgv1.Rows(currrow).Cells("LoopVideo").Value & " " & dgv1.CurrentRow.Cells("clmFilter").Value)

                End If
            End If

30:
            sendmixercommandforclip()
            If dgv1.Rows(currrow).Cells("File_Name").Value <> "end" Then 'no chance to enable  tmrnextclip
                tmrfornotskiping.Enabled = True
            End If

            If dgv1.Rows(currrow).Cells("Column11").Value = True Then
                calculateinterval()
            Else
                tmrnextclip.Interval = 1000
            End If

            adjusttimeofplaylist()
            tmrnextclip.Enabled = False

            createasrunlog()

            linktemplatetoplaylist()

            If frmmediaplayer.ucTab1.UcPlaylistSetting1.chkStayOnSelected.Checked Then
                dgv1.CurrentCell = dgv1.Rows(tempcurrentrow).Cells("File_Name") ' for selected row to remain same. Suggested by srk 04.06.18
            End If

        End If

    End Sub
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        newdgv()
    End Sub
    Sub newdgv()
        On Error Resume Next
        dgv1.Rows.Clear()
        dgv1.Rows.Add(20)
        Me.lblplalistname.Text = "playlist= " & "new playlist"
    End Sub

    Sub insertend()
        On Error Resume Next
        dgv1.Rows.Insert(dgv1.CurrentRow.Index + 1)
        dgv1.CurrentCell = dgv1.Rows(dgv1.CurrentRow.Index + 1).Cells("File_Name")

        dgv1.Rows(dgv1.CurrentRow.Index).Cells("File_Name").Value = "end"
        dgv1.Rows(dgv1.CurrentRow.Index).Cells("x").Value = 1
        dgv1.Rows(dgv1.CurrentRow.Index).Cells("Transition").Value = "MIX"
        dgv1.Rows(dgv1.CurrentRow.Index).Cells("T_Duration").Value = 10
    End Sub
    Sub insertlivedecklink(devicenumber As Integer)
        On Error Resume Next
        dgv1.Rows.Insert(dgv1.CurrentRow.Index + 1)
        dgv1.CurrentCell = dgv1.Rows(dgv1.CurrentRow.Index + 1).Cells("File_Name")

        dgv1.Rows(dgv1.CurrentRow.Index).Cells("File_Name").Value = "decklink " & devicenumber
        dgv1.Rows(dgv1.CurrentRow.Index).Cells("x").Value = 1
        dgv1.Rows(dgv1.CurrentRow.Index).Cells("Transition").Value = "MIX"
        dgv1.Rows(dgv1.CurrentRow.Index).Cells("T_Duration").Value = 10

        dgv1.Rows(dgv1.CurrentRow.Index).Cells("Clip_Duration").Value = "00:30:00"
        dgv1.Rows(dgv1.CurrentRow.Index).Cells("Column11").Value = True
        dgv1.Rows(dgv1.CurrentRow.Index).Cells("AudioLevel").Value = 1.0
        dgv1.CurrentRow.Cells("FileType").Value = "Others"
    End Sub
    'ttt
    Private Sub cmdinsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdinsert.Click
        On Error Resume Next
        clipinsert()
    End Sub
    Sub clipinsert()
        On Error Resume Next
        If dgv1.CurrentRow.Index < currrow Then
            currrow = currrow + 1
        End If
        dgv1.NotifyCurrentCellDirty(True)
        dgv1.NotifyCurrentCellDirty(False)

        dgv1.Rows.Insert(dgv1.CurrentRow.Index + 1)
        dgv1.Rows(dgv1.CurrentRow.Index + 1).Cells("x").Value = 1
        dgv1.Rows(dgv1.CurrentRow.Index + 1).Cells("Transition").Value = "MIX"
        dgv1.Rows(dgv1.CurrentRow.Index + 1).Cells("T_Duration").Value = 10

        dgv1.Rows(dgv1.CurrentRow.Index + 1).Cells("AudioLevel").Value = 1.0

    End Sub
    Sub deleteclip()
        On Error Resume Next
        If dgv1.CurrentRow.DefaultCellStyle.BackColor <> Color.LightGreen Then
            If dgv1.CurrentRow.Index < currrow Then
                currrow = currrow - 1
            End If

            dgv1.NotifyCurrentCellDirty(True)
            dgv1.NotifyCurrentCellDirty(False)

            dgv1.Rows.RemoveAt(dgv1.CurrentRow.Index)
            adjusttimeofplaylistfornewclip(dgv1.CurrentRow.Index)
        Else
            MsgBox("Online clip cann't be deleted.")
        End If
    End Sub
    Private Sub CasparcgWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        frmmediaplayer.ucCasparcgWindow1.SetProcessParent("casparcg")
    End Sub
    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        playlist()
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        nextclip()
    End Sub

    Private Sub PauseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        clippause()
    End Sub


    Private Sub ResumeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        clipresume()
    End Sub

    Private Sub InToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        clipinsert()
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        deleteclip()
    End Sub
    Private Sub cmdmoveup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmoveup.Click
        On Error Resume Next
        clipmoveup()
    End Sub
    Sub clipmoveup()
        On Error Resume Next
        If Me.dgv1.CurrentCell.RowIndex <> 0 Then

            Dim curRow As Integer = Me.dgv1.CurrentCell.RowIndex
            If curRow = currrow Then
                currrow = currrow - 1
            ElseIf curRow = currrow + 1 Then
                currrow = currrow + 1
            End If

            Dim aaa2 As String = dgv1.Rows(curRow - 1).Cells("Start_Time").Value

            Dim myRow As DataGridViewRow = Me.dgv1.CurrentRow

            dgv1.NotifyCurrentCellDirty(True)
            dgv1.NotifyCurrentCellDirty(False)

            Me.dgv1.Rows.Remove(myRow)
            Me.dgv1.Rows.Insert(curRow - 1, myRow)
            dgv1.CurrentCell = dgv1.Rows(curRow - 1).Cells("File_Name")

            dgv1.Rows(curRow - 1).Cells("Start_Time").Value = aaa2

            Dim xxx As Integer

            xxx = (Mid(dgv1.Rows(curRow - 1).Cells("Clip_Duration").Value, 1, 2)) * 3600 + (Mid(dgv1.Rows(curRow - 1).Cells("Clip_Duration").Value, 4, 2)) * 60 + (Mid(dgv1.Rows(curRow - 1).Cells("Clip_Duration").Value, 7, 2))
            Dim aa As Date = dgv1.Rows(curRow - 1).Cells("Start_Time").Value
            dgv1.Rows(curRow).Cells("Start_Time").Value = Format(aa.AddSeconds(xxx), "HH:mm:ss")

        End If
    End Sub
    Private Sub cmdmovedown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmovedown.Click
        clipmovedown()
    End Sub
    Sub clipmovedown()
        On Error Resume Next
        If Me.dgv1.CurrentCell.RowIndex <> dgv1.Rows.Count - 2 Then

            Dim curRow As Integer = Me.dgv1.CurrentCell.RowIndex
            If curRow = currrow Then
                currrow = currrow + 1
            ElseIf curRow = currrow - 1 Then
                currrow = currrow - 1
            End If

            Dim aaa2 As String = dgv1.Rows(curRow).Cells("Start_Time").Value

            Dim myRow As DataGridViewRow = Me.dgv1.CurrentRow
            Me.dgv1.Rows.Remove(myRow)
            Me.dgv1.Rows.Insert(curRow + 1, myRow)
            dgv1.CurrentCell = dgv1.Rows(curRow + 1).Cells("File_Name")

            dgv1.Rows(curRow).Cells("Start_Time").Value = aaa2

            Dim xxx As Integer

            xxx = (Mid(dgv1.Rows(curRow).Cells("Clip_Duration").Value, 1, 2)) * 3600 + (Mid(dgv1.Rows(curRow).Cells("Clip_Duration").Value, 4, 2)) * 60 + (Mid(dgv1.Rows(curRow).Cells("Clip_Duration").Value, 7, 2))
            Dim aa As Date = dgv1.Rows(curRow).Cells("Start_Time").Value
            dgv1.Rows(curRow + 1).Cells("Start_Time").Value = Format(aa.AddSeconds(xxx), "HH:mm:ss")
        End If
    End Sub
    Sub getdurationbyosc()
        On Error Resume Next
        With frmmediaplayer
            ucOSC.oscstartandregister()

            .ucCasparcgWindow1.TrackBarseek.Maximum = framesTotal
            .ucCasparcgWindow1.TrackBarseek.Value = framesPlayed
            .ucCasparcgWindow1.lblmax.Text = framesTotal
            .ucCasparcgWindow1.lblmin.Text = .ucCasparcgWindow1.TrackBarseek.Minimum
            .ucCasparcgWindow1.lblcurrentframe.Text = framesPlayed
            .ucCasparcgWindow1.lblhmsf.Text = FToHMSF(framesPlayed)
            .ucCasparcgWindow1.lblplaying.Text = playingfilename

            ucSlowMotion.lblplayhead.Text = ucOSC.dgvosc.Rows(53).Cells(1).Value
            ucSlowMotion.lblspeedofslowmotion.Text = ucOSC.dgvosc.Rows(54).Cells(1).Value

            If dgv1.Rows(currrow).Cells("File_Name").Value.ToString = "" Then
                GoTo 30
            End If

            If System.IO.Path.GetExtension(mediafullpath & dgv1.Rows(currrow).Cells("File_Name").Value.ToString) = ".txt" Then
                readsubclip(mediafullpath & dgv1.Rows(currrow).Cells("File_Name").Value.ToString)
                clipsleftduration = (cliplength + clipseek - framesPlayed) / fps

            ElseIf (Mid(dgv1.Rows(currrow).Cells("File_Name").Value, 1, 8)).ToUpper = "DECKLINK" Then
                clipsleftduration = 0.6
            Else
30:
                clipsleftduration = ((framesTotal - framesPlayed)) / fps
            End If

            .lblremainintime.Text = mstohms(clipsleftduration * 1000)

        End With

    End Sub



    Sub clipcopy()
        On Error Resume Next
        tempRow = Me.dgv1.CurrentRow
    End Sub

    Sub insertcopied()
        On Error Resume Next
        Dim curRow As Integer = Me.dgv1.CurrentCell.RowIndex
        dgv1.Rows.Insert(dgv1.CurrentRow.Index)
        dgv1.CurrentCell = dgv1.Rows(curRow).Cells("File_Name")
        For cc = 0 To dgv1.ColumnCount - 1
            Me.dgv1.Item(cc, curRow).Value = tempRow.Cells(cc).Value
        Next
        adjusttimeofplaylistfornewclip(dgv1.CurrentRow.Index)
    End Sub
    Sub cueclip()
        On Error Resume Next
        If dgv1.CurrentRow.Cells("File_Name").Value = "" Then Exit Sub
        frmmediaplayer.ucCasparcgWindow1.txtmarkin.Text = ""
        frmmediaplayer.ucCasparcgWindow1.txtmarkout.Text = ""

        If System.IO.Path.GetExtension(mediafullpath & dgv1.CurrentRow.Cells("File_Name").Value.ToString) = ".txt" Then
            readsubclip(mediafullpath & dgv1.CurrentRow.Cells("File_Name").Value.ToString)
            frmmediaplayer.ucCasparcgWindow1.txtmarkin.Text = clipseek
            frmmediaplayer.ucCasparcgWindow1.txtmarkout.Text = cliplength + clipseek
            If ServerVersion > 2.1 Then
                SendString(NetStream, "load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek * 2 & " length " & cliplength * 2 & vbCrLf)

            Else
                SendString(NetStream, "load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek & " length " & cliplength & vbCrLf)

            End If
        Else
            SendString(NetStream, "load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(dgv1.CurrentRow.Cells("File_Name").Value) & """" + vbCrLf)
        End If

        sendmixercommandforclip()

        currrow = dgv1.CurrentRow.Index
    End Sub
    Private Sub CueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        cueclip()
    End Sub
    Private Sub PlayNextF6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayNextF6ToolStripMenuItem.Click
        nextclipplay()
    End Sub
    Private Sub StopF1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopF1ToolStripMenuItem.Click
        clipstop()
    End Sub
    Private Sub PlayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        PlaySingleClip()
    End Sub
    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        clipcopy()
    End Sub
    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        insertcopied()
    End Sub
    Private Sub MoveUPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        clipmoveup()
    End Sub
    Private Sub MoveDownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        clipmovedown()
    End Sub
    Private Sub CueToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CueToolStripMenuItem1.Click
        On Error Resume Next
        cueclip()
    End Sub
    Private Sub PlayToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayToolStripMenuItem1.Click
        On Error Resume Next
        PlaySingleClip()
    End Sub
    Private Sub PauseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PauseToolStripMenuItem1.Click
        On Error Resume Next
        clippause()
    End Sub
    Private Sub ResumeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumeToolStripMenuItem1.Click
        On Error Resume Next
        clipresume()
    End Sub
    Private Sub NextToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem1.Click
        On Error Resume Next
        nextclip()
    End Sub

    Private Sub InsertBlankToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertBlankToolStripMenuItem.Click
        On Error Resume Next
        clipinsert()
    End Sub
    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        On Error Resume Next
        deleteclip()
    End Sub
    Private Sub CopyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem1.Click
        On Error Resume Next
        clipcopy()
    End Sub
    Private Sub PasteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem1.Click
        On Error Resume Next
        insertcopied()
    End Sub
    Private Sub MoveUpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveUpToolStripMenuItem1.Click
        On Error Resume Next
        clipmoveup()
    End Sub

    Private Sub MoveDownToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveDownToolStripMenuItem1.Click
        On Error Resume Next
        clipmovedown()
    End Sub
    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        newdgv()
    End Sub
    Private Sub SaveAsToolStripButton_Click(sender As Object, e As EventArgs)
        savefile()
    End Sub
    Sub saveplaylist(filename As String)
        On Error Resume Next
        Using sw As StreamWriter = New StreamWriter(Mid(filename, 11))
            If dgv1.Rows.Count = 0 Then
                sw.Write("")
            Else
                'Loop through and add list to the file.
                Dim f As Integer = 0
                Do Until f = dgv1.Rows.Count
                    If dgv1.Rows(f).Cells("x").Value = False Then dgv1.Rows(f).Cells("x").Value = "0"
                    If dgv1.Rows(f).Cells("Column11").Value = False Then dgv1.Rows(f).Cells("Column11").Value = "0"

                    If dgv1.Rows(f).Cells("Conversion").Value = False Then dgv1.Rows(f).Cells("Conversion").Value = "0"
                    If dgv1.Rows(f).Cells("BackIn").Value = False Then dgv1.Rows(f).Cells("BackIn").Value = "0"
                    sw.WriteLine(dgv1.Rows(f).Cells("File_Name").Value & Chr(2) & dgv1.Rows(f).Cells("Start_Time").Value & Chr(2) & dgv1.Rows(f).Cells("x").Value & Chr(2) & dgv1.Rows(f).Cells("Transition").Value & Chr(2) & dgv1.Rows(f).Cells("T_Duration").Value & Chr(2) & dgv1.Rows(f).Cells("LoopVideo").Value & Chr(2) & dgv1.Rows(f).Cells("Clip_Duration").Value & Chr(2) & dgv1.Rows(f).Cells("Column11").Value & Chr(2) & dgv1.Rows(f).Cells("AudioLevel").Value & Chr(2) & dgv1.Rows(f).Cells("Conversion").Value & Chr(2) & dgv1.Rows(f).Cells("clmFilter").Value & Chr(2) & dgv1.Rows(f).Cells("Template_File").Value & Chr(2) & dgv1.Rows(f).Cells("FileType").Value & Chr(2) & dgv1.Rows(f).Cells("BackIn").Value & Chr(2) & dgv1.Rows(f).Cells("AMCPCommands").Value)
                    f = f + 1
                Loop
            End If
            sw.Close()
        End Using
    End Sub
    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        openfile()
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        saveplaylist(lblplalistname.Text)

    End Sub
    Private Sub dgv1_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        On Error Resume Next
        If e.Button = Windows.Forms.MouseButtons.Right Then
            dgv1.CurrentCell = dgv1.Rows(e.RowIndex).Cells("File_Name")
        End If
    End Sub
    Private Sub dgv1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        'nothing
    End Sub
    Sub SetStartTimeAccordingToCurrentRow()
        On Error Resume Next
        Dim i As Integer
        Dim curRow As Integer = Me.dgv1.CurrentCell.RowIndex

        For i = curRow To dgv1.RowCount - 1
            Dim aa As Date = dgv1.Rows(i).Cells("Start_Time").Value
            If dgv1.Rows(i).Cells("x").Value = 0 Then
                dgv1.Rows(i + 1).Cells("Start_Time").Value = Format(aa, "HH:mm:ss")
            Else
                Dim xxx As Integer
                xxx = (Mid(dgv1.Rows(i).Cells("Clip_Duration").Value, 1, 2)) * 3600 + (Mid(dgv1.Rows(i).Cells("Clip_Duration").Value, 4, 2)) * 60 + (Mid(dgv1.Rows(i).Cells("Clip_Duration").Value, 7, 2))
                dgv1.Rows(i + 1).Cells("Start_Time").Value = Format(aa.AddSeconds(xxx), "HH:mm:ss")
            End If
        Next
    End Sub
    Sub adjusttimeofplaylist()
        On Error Resume Next
        Dim i As Integer
        Dim curRow As Integer = Me.dgv1.CurrentCell.RowIndex
        dgv1.CurrentRow.Cells("Start_Time").Value = Format(Now, "HH:mm:ss")

        For i = curRow To dgv1.RowCount - 1
            Dim aa As Date = dgv1.Rows(i).Cells("Start_Time").Value
            If dgv1.Rows(i).Cells("x").Value = 0 Then
                dgv1.Rows(i + 1).Cells("Start_Time").Value = Format(aa, "HH:mm:ss")
            Else
                Dim xxx As Integer
                xxx = (Mid(dgv1.Rows(i).Cells("Clip_Duration").Value, 1, 2)) * 3600 + (Mid(dgv1.Rows(i).Cells("Clip_Duration").Value, 4, 2)) * 60 + (Mid(dgv1.Rows(i).Cells("Clip_Duration").Value, 7, 2))
                dgv1.Rows(i + 1).Cells("Start_Time").Value = Format(aa.AddSeconds(xxx), "HH:mm:ss")
            End If
        Next
    End Sub
    Sub adjusttimeofplaylistfornewclip(ByVal hitrow As Integer)
        On Error Resume Next
        Dim i As Integer
        For i = hitrow - 1 To dgv1.RowCount - 1
            Dim aa As Date = dgv1.Rows(i).Cells("Start_Time").Value
            If dgv1.Rows(i).Cells("x").Value = 0 Then
                dgv1.Rows(i + 1).Cells("Start_Time").Value = Format(aa, "HH:mm:ss")
            Else
                Dim xxx As Integer
                xxx = (Mid(dgv1.Rows(i).Cells("Clip_Duration").Value, 1, 2)) * 3600 + (Mid(dgv1.Rows(i).Cells("Clip_Duration").Value, 4, 2)) * 60 + (Mid(dgv1.Rows(i).Cells("Clip_Duration").Value, 7, 2))
                dgv1.Rows(i + 1).Cells("Start_Time").Value = Format(aa.AddSeconds(xxx), "HH:mm:ss")
            End If
        Next
    End Sub
    Private Async Sub txtsearch_KeyPressAsync(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) And cmdclipsearch.Enabled = True Then
            labelclips.Text = ""
            refreshclips1()
        End If
    End Sub
    Private Async Sub cmdclipsearch_ClickAsync(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclipsearch.Click
        'On Error Resume Next
        labelclips.Text = ""
        refreshclips1()
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
    Async Sub refreshclips1()
        Try
            'cmdclipsearch.Enabled = False
            Control.CheckForIllegalCrossThreadCalls = False
            If dt.Columns.Contains("File_Name") = True Then ' And dgvclips.CurrentRow.Cells("File_Name").Value <> DBNull.Value Then '0 Then 'dt.Columns.Contains("File_Name") = True And
                'MsgBox(dgvclips.Rows.Count)
                If dgvclips.Rows.Count > 1 Then ' 1 is important
                    strcurrentrowcell0value = dgvclips.CurrentRow.Cells("File_Name").Value
                End If
            End If

            Dim dr As DataRow
            dt.Clear()

            If frmmediaplayer.ucTab1.UcPlaylistSetting1.rdoclipfromfilesystem.Checked = True Then
                'MsgBox("from file sysytem")
                Dim s1 As [String]()
                s1 = Directory.GetFiles(mediafullpath & lblsearch.Text, "*.*", 1)
                'If s1.Count = 0 Then Exit Sub
                pbclipsearchstatus.Maximum = s1.Length - 1
                For i As Integer = 0 To s1.Length - 1
                    If i = 0 Then
                        If dt.Columns.Contains("File_Name") = False Then
                            dt.Columns.Add("File_Name")
                            dt.Columns.Add("Duration")
                            dt.Columns.Add("Size")
                        End If

                    End If

                    Dim f1 As New FileInfo(s1(i))
                    dr = dt.NewRow()
                    If (Path.GetExtension(f1.FullName).ToUpper = ".MXF") Or (Path.GetExtension(f1.FullName).ToUpper = ".TS") Then
                        GoTo 40
                    End If

                    If (f1.Attributes And FileAttributes.Hidden) <> 0 Or CheckFileHasCopied(f1.FullName) = False Then
                        GoTo 50
                    End If
40:                 If UCase(Replace(f1.FullName.Substring(Len(mediafullpath)), "\", "/").ToString) Like "*" & UCase(Replace(txtsearch.Text, "\", "/")) & "*" Then

                        dr("File_Name") = Replace(f1.FullName.Substring(Len(mediafullpath)), "\", "/").ToString
                        If chkclipduration.Checked Then
                            'Dim dd As String = getallvaules(f1.FullName)
                            Dim dd As String = Await getallvaluesAsync(f1.FullName)
                            dr("Duration") = Split(dd, Chr(2))(0)
                            dr("Size") = Split(dd, Chr(2))(1)
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
                            If dt.Columns.Contains("File_Name") = False Then
                                dt.Columns.Add("File_Name")
                                dt.Columns.Add("Duration")
                            End If

                        End If
                        If UCase(Replace(Replace(Split(aa(ss), "  ")(0), "\", "/"), """", "")) Like lblsearch.Text & "*" & UCase(Replace(txtsearch.Text, "\", "/")) & "*" Then
                            dr = dt.NewRow()
                            dr("File_Name") = Replace(Replace(Split(aa(ss), "  ")(0), "\", "/"), """", "")

                            Dim singleclip() = Split(aa(ss), "  ")
                            Dim duration As String = ""
                            duration = Split(singleclip(2), " ")(2)
                            If duration = "NaN" Then
                                duration = "100"
                            End If
                            dr("Duration") = FToHMS(duration)

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
                    Dim i As Integer
                    For i = 1 To CasparDevice.Mediafiles.Count - 1
                        'MsgBox(CasparDevice.Mediafiles.Count)
                        If dt.Columns.Contains("File_Name") = False Then
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
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub
    Sub clipsearchcomplete()
        On Error Resume Next

        Me.dgvclips.DataSource = dt
        dgvclips.Columns(0).Width = 725
        dgvclips.Columns(1).Width = 62
        dgvclips.Columns(2).Width = 73

        dgvclips.Sort(dgvclips.Columns("File_Name"), System.ComponentModel.ListSortDirection.Ascending)

        For iii = 0 To dgvclips.RowCount - 1
            If dgvclips.Rows(iii).Cells("File_Name").Value = strcurrentrowcell0value Then
                dgvclips.CurrentCell = dgvclips.Rows(iii).Cells("File_Name")
                Exit For
            End If
        Next
        cmdclipsearch.Enabled = True
        pbclipsearchstatus.Value = 0
        dgvclips.Columns("File_Name").DefaultCellStyle.Font = New Font("Arial Black", frmmediaplayer.nfontsizeforall.Value, FontStyle.Regular)
    End Sub
    Private Sub chkplaylistlock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkplaylistlock.CheckedChanged
        On Error Resume Next
        If chkplaylistlock.Checked = True Then
            dgv1.Enabled = False
            frmmediaplayer.ucCasparcgWindow1.gbplayer.Enabled = False
            cmdstartplaylist.Enabled = False
        Else
            dgv1.Enabled = True
            frmmediaplayer.ucCasparcgWindow1.gbplayer.Enabled = True
            cmdstartplaylist.Enabled = True
        End If
    End Sub
    Sub selectAll()
        On Error Resume Next
        Dim iplalistselectall As Integer
        For iplalistselectall = 0 To dgv1.RowCount - 1
            dgv1.Rows(iplalistselectall).Cells("x").Value = 1
        Next
    End Sub
    Sub deselectAll()
        On Error Resume Next
        Dim iplalistdeselectall As Integer
        For iplalistdeselectall = 0 To dgv1.RowCount - 1
            dgv1.Rows(iplalistdeselectall).Cells("x").Value = 0
        Next
    End Sub

    Private Sub cmddeleteclip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddeleteclip.Click

        On Error Resume Next
        deleteclip()
    End Sub


    Private Sub dgv1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        On Error Resume Next
        'If dgv1.CurrentCell.ColumnIndex = 2 Then
        If sender.columns(e.ColumnIndex).headercell.value = "Play" Then
            dgv1.EndEdit()
            adjusttimeofplaylistfornewclip(dgv1.CurrentRow.Index)
        End If

    End Sub

    Private Sub dgv1_DataError1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv1.DataError
        'dummy data dont delete
    End Sub

    Private Sub dgv1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles dgv1.DragDrop
        On Error Resume Next

        Dim clientPoint As Point = dgv1.PointToClient(New Point(e.X, e.Y))
        Dim datatocopy As Array

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files() As String = e.Data.GetData(DataFormats.FileDrop)

            If (Directory.Exists(files(0))) Then
                Dim di As New DirectoryInfo(files(0))
                Dim fiArr As FileInfo() = di.GetFiles()
                Dim path As FileInfo

                Dim xx As Integer = 0
                For Each path In fiArr

                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("File_Name").Value = Replace(Replace(path.FullName, ":", ":\"), "\", "/")
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("Clip_Duration").Value = getdurationofclip(path.FullName)
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("Column3").Value = ""

                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("x").Value = 1
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("Transition").Value = "MIX"
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells("T_Duration").Value = 10

                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("Column11").Value = 0 'follow duration
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("AudioLevel").Value = "1" 'audio lavel
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("Conversion").Value = 0 'conversion
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("clmFilter").Value = "" 'filter
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("Template_File").Value = "" 'template
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("FileType").Value = "Others" 'file type
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("BackIn").Value = 0 ' back in
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("AMCPCommands").Value = "" ' amcp commands

                    If xx < fiArr.Count - 1 Then
                        dgv1.Rows.Insert(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx + 1)
                        xx = xx + 1
                    End If
                Next
                GoTo 20

            Else
                Dim xx As Integer = 0
                For Each path In files

                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("File_Name").Value = Replace(Replace(path, ":", ":\"), "\", "/")
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("Clip_Duration").Value = getdurationofclip(path)
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("Column3").Value = ""

                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("x").Value = 1
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("Transition").Value = "MIX"
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells("T_Duration").Value = 10

                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("Column11").Value = 0 'follow duration
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("AudioLevel").Value = "1" 'audio lavel
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("Conversion").Value = 0 'conversion
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("clmFilter").Value = "" 'filter
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("Template_File").Value = "" 'template
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("FileType").Value = "Others" 'file type
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("BackIn").Value = 0 ' back in
                    dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx).Cells("AMCPCommands").Value = "" ' amcp commands

                    If xx < files.Count - 1 Then
                        dgv1.Rows.Insert(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex + xx + 1)
                        xx = xx + 1
                    End If
                Next
                GoTo 20
            End If


        Else
            datatocopy = Split(e.Data.GetData("System.String"), Chr(2))
            dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells("File_Name").Value = datatocopy(0)
        End If

        If System.IO.Path.GetExtension(mediafullpath & datatocopy(0)) = ".txt" Then
            Using sr As StreamReader = New StreamReader(mediafullpath & datatocopy(0).ToString)
                Dim str As Array = Split(sr.ReadLine, Chr(2))
                masterfilename = str(0)
                clipseek = str(1)
                cliplength = str(2) - str(1)
            End Using
            Dim aa As Array = Split(masterfilename, ".")
            dropedclipsleftduration = cliplength / fps

            dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells("Clip_Duration").Value = mstohms(cliplength * 1000 / fps)
            dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells("Column3").Value = System.Drawing.Image.FromFile(thumbnailsfullpath & aa(0) & ".png")
        Else

            If datatocopy(1) = "" Then
                Dim f1 As FileSystemInfo = New FileInfo(mediafullpath & "/" & datatocopy(0))
                dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells("Clip_Duration").Value = getdurationofclip(f1.FullName) 'mstohms(mediainfofile.duratio
            Else
                dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells("Clip_Duration").Value = datatocopy(1)
            End If

            Dim aa As Array = Split(e.Data.GetData("System.String"), ".")
            dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells("Column3").Value = System.Drawing.Image.FromFile(thumbnailsfullpath & aa(0) & ".png")

        End If


        dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells("x").Value = 1
        dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells("Transition").Value = "MIX"
        dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells("T_Duration").Value = 10

        dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells("Column11").Value = 0 'follow duration
        dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells("AudioLevel").Value = "1" 'audio lavel
        dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells("Conversion").Value = 0 'conversion
        dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells("clmFilter").Value = "" 'filter
        dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells("Template_File").Value = "" 'template
        dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells("FileType").Value = "Others" 'file type
        dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells("BackIn").Value = 0 ' back in
        dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells("AMCPCommands").Value = "" ' amcp commands
20:
        Dim hitrow As Integer = dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex
        adjusttimeofplaylistfornewclip(hitrow)
    End Sub

    Private Sub dgv1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles dgv1.DragEnter
        On Error Resume Next

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub dgvclips_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvclips.CellContentDoubleClick
    End Sub
    Private Sub dgvclips_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvclips.CellDoubleClick
    End Sub
    Private Sub dgvclips_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvclips.DoubleClick
        On Error Resume Next
        Dim cellX, cellY As Integer
            Dim grvScreenLocation As Point = dgvclips.PointToScreen(dgvclips.Location)
            Dim tempX As Integer = DataGridView.MousePosition.X - grvScreenLocation.X + dgvclips.Left
            Dim tempY As Integer = DataGridView.MousePosition.Y - grvScreenLocation.Y + dgvclips.Top
            Dim hit As DataGridView.HitTestInfo = dgvclips.HitTest(tempX, tempY)
            cellX = hit.RowIndex
            cellY = hit.ColumnIndex
        If hit.Type <> DataGridViewHitTestType.ColumnHeader Then
            dgvclips.CurrentCell = dgvclips.Rows(cellX).Cells("File_Name")

            If dgv1.CurrentRow.Index = 0 And dgv1.Rows(0).Cells("File_Name").Value = "" Then
                'do not insert new row
            Else
                clipinsert()
                dgv1.CurrentCell = dgv1.Rows(dgv1.CurrentRow.Index + 1).Cells("File_Name")
            End If
            dgv1.CurrentRow.Cells("File_Name").Value = dgvclips.CurrentRow.Cells("File_Name").Value
            dgv1.CurrentRow.Cells("x").Value = 1
            dgv1.CurrentRow.Cells("Transition").Value = "MIX"
            dgv1.CurrentRow.Cells("T_Duration").Value = 10
            dgv1.CurrentRow.Cells("AudioLevel").Value = 1.0
            dgv1.CurrentRow.Cells("FileType").Value = "Others"
            dgv1.CurrentRow.Cells("BackIn").Value = 0
            dgv1.CurrentRow.Cells("AMCPCommands").Value = ""  'AMCP Commands 

            If dgvclips.CurrentRow.Cells("Duration").Value = "" Then

                If System.IO.Path.GetExtension(mediafullpath & "/" & dgvclips.CurrentRow.Cells("File_Name").Value) = ".txt" Then
                    Using sr As StreamReader = New StreamReader(mediafullpath & dgvclips.CurrentRow.Cells("File_Name").Value.ToString)
                        Dim str As Array = Split(sr.ReadLine, Chr(2))
                        cliplength = str(2) - str(1)
                    End Using
                    dgv1.CurrentRow.Cells("Clip_Duration").Value = mstohms(cliplength * 1000 / fps)
                Else

                    Dim f1 As FileSystemInfo = New FileInfo(mediafullpath & "/" & dgvclips.CurrentRow.Cells("File_Name").Value)
                    dgv1.CurrentRow.Cells("Clip_Duration").Value = getdurationofclip(f1.FullName)
                End If
            Else
                dgv1.CurrentRow.Cells("Clip_Duration").Value = dgvclips.CurrentRow.Cells("Duration").Value
            End If
            If System.IO.Path.GetExtension(mediafullpath & dgv1.CurrentRow.Cells("File_Name").Value) = ".txt" Then
                Using sr As StreamReader = New StreamReader(mediafullpath & dgv1.CurrentRow.Cells("File_Name").Value.ToString)
                    Dim str As Array = Split(sr.ReadLine, Chr(2))
                    masterfilename = str(0)
                    clipseek = str(1)
                    cliplength = str(2) - str(1)
                End Using

                Dim aa As Array = Split(masterfilename, ".")
                dgv1.CurrentRow.Cells("Column3").Value = System.Drawing.Image.FromFile(thumbnailsfullpath & aa(0) & ".png")
            Else

                Dim aa As Array = Split(dgv1.CurrentRow.Cells("File_Name").Value, ".")
                dgv1.CurrentRow.Cells("Column3").Value = System.Drawing.Image.FromFile(thumbnailsfullpath & aa(0) & ".png")
            End If
        End If

        Dim hitrow As Integer = dgv1.CurrentRow.Index
            adjusttimeofplaylistfornewclip(hitrow)

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
                If e.Button = Windows.Forms.MouseButtons.Right Then
                    cmsdgvclips.Show(MousePosition)
                Else
                    Dim cellX, cellY As Integer

                    Dim grvScreenLocation As Point = dgvclips.PointToScreen(dgvclips.Location)
                    Dim tempX As Integer = DataGridView.MousePosition.X - grvScreenLocation.X + dgvclips.Left
                    Dim tempY As Integer = DataGridView.MousePosition.Y - grvScreenLocation.Y + dgvclips.Top
                    Dim hit As DataGridView.HitTestInfo = dgvclips.HitTest(tempX, tempY)
                    cellX = hit.RowIndex
                    cellY = hit.ColumnIndex
                    dgvclips.CurrentCell = dgvclips.Rows(cellX).Cells("File_Name")

                    Dim datatocopy As String = dgvclips.CurrentRow.Cells("File_Name").Value & Chr(2) & dgvclips.CurrentRow.Cells("Duration").Value
                    If MouseIsDown = True And dgv1.Cursor <> System.Windows.Forms.Cursors.SizeWE Then
                        dgvclips.DoDragDrop(datatocopy, DragDropEffects.Copy)
                        MouseIsDown = False
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub PlayInVLCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayInVLCToolStripMenuItem.Click
        On Error Resume Next

        If (dgv1.CurrentRow.Cells("File_Name").Value.ToString.ToLower).Contains("p://") Then
            playinvlc(dgv1.CurrentRow.Cells("File_Name").Value.ToString)
            Exit Sub
        End If

        If dgv1.CurrentRow.Cells("File_Name").Value.ToString.Contains("://") Then

            playinvlc(Replace(dgv1.CurrentRow.Cells("File_Name").Value.ToString, "://", ":/"))
        Else
            playinvlc(mediafullpath & dgv1.CurrentRow.Cells("File_Name").Value.ToString)
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        On Error Resume Next
        playinvlc(mediafullpath & dgvclips.CurrentRow.Cells("File_Name").Value.ToString)
    End Sub
    Private Sub PlayInCasparcgToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayInCasparcgToolStripMenuItem.Click
        playfromclipgrid()
    End Sub
    Sub playfromclipgrid()
        On Error Resume Next

        If dgvclips.CurrentRow.Cells("File_Name").Value = "" Then Exit Sub
        If System.IO.Path.GetExtension(mediafullpath & dgvclips.CurrentRow.Cells("File_Name").Value.ToString) = ".txt" Then
            readsubclip(mediafullpath & dgvclips.CurrentRow.Cells("File_Name").Value.ToString)
            If ServerVersion > 2.1 Then
                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek * 2 & " length " & cliplength * 2 & deinterlaced)
            Else
                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek & " length " & cliplength & deinterlaced)
            End If
        Else
            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(dgvclips.CurrentRow.Cells("File_Name").Value) & """" & deinterlaced)
        End If

        palyloopinsecondchannel()
        tmrduration.Enabled = True
        lastclickedbutton(cmdplayforclipgrid)
    End Sub

    Sub palyloopinsecondchannel()
        seconndchannelloopvideoname = ""
        If chknextcuefor2ndchannel.Checked Then
            CasparDevice.SendString("play " & g_int_ChannelNumber + 1 & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(dgvclips.Rows(dgvclips.CurrentRow.Index + 1).Cells("File_Name").Value) & """" & " length 250 loop ")
            seconndchannelloopvideoname = ModifyFilename(dgvclips.Rows(dgvclips.CurrentRow.Index + 1).Cells("File_Name").Value)
        End If
    End Sub



    Private Sub tmrcheckfilesinplaylist_Tick(sender As Object, e As EventArgs) Handles tmrcheckfilesinplaylist.Tick
        checkfilesinpaylist()
    End Sub

    Private Sub CheckFilesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckFilesToolStripMenuItem.Click
        checkfilesinpaylist()
    End Sub
    Sub checkfilesinpaylist()
        On Error Resume Next
        For iCheckFiles = 0 To dgv1.Rows.Count - 1
            If System.IO.File.Exists(mediafullpath & dgv1.Rows(iCheckFiles).Cells("File_Name").Value) = False And dgv1.Rows(iCheckFiles).Cells("File_Name").Value <> "" Then
                dgv1.Rows(iCheckFiles).DefaultCellStyle.BackColor = Color.Red
            Else
                If dgv1.Rows(iCheckFiles).DefaultCellStyle.BackColor <> Color.LightGreen Then
                    dgv1.Rows(iCheckFiles).DefaultCellStyle.BackColor = Color.White()
                    colorchange(iCheckFiles)
                End If

            End If
        Next
    End Sub
    Private Sub chkcheckfilesinplaylist_CheckedChanged(sender As Object, e As EventArgs) Handles chkcheckfilesinplaylist.CheckedChanged
        If sender.checked Then
            tmrcheckfilesinplaylist.Enabled = True
        Else
            tmrcheckfilesinplaylist.Enabled = False
        End If
    End Sub
    Private Sub CueInCsparcgToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CueInCsparcgToolStripMenuItem.Click
        On Error Resume Next
        cuefromclipgrid()
    End Sub
    Sub cuefromclipgrid()
        On Error Resume Next
        If dgvclips.CurrentRow.Cells("File_Name").Value = "" Then Exit Sub
        If System.IO.Path.GetExtension(mediafullpath & dgvclips.CurrentRow.Cells("File_Name").Value.ToString) = ".txt" Then
            readsubclip(mediafullpath & dgvclips.CurrentRow.Cells("File_Name").Value.ToString)
            If ServerVersion > 2.1 Then
                SendString(NetStream, "load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek * 2 & deinterlaced & vbCrLf)

            Else
                SendString(NetStream, "load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek & deinterlaced & vbCrLf)

            End If

        Else
            SendString(NetStream, "load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(dgvclips.CurrentRow.Cells("File_Name").Value) & """" & deinterlaced + vbCrLf)

        End If
        palyloopinsecondchannel()
        lastclickedbutton(cmdcueforclipgrid)
    End Sub

    Private Sub cmdclosegbplaylist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        Me.Hide()
    End Sub
    Sub RefreshThumbnail()
        On Error Resume Next
        For g = 0 To dgv1.Rows.Count - 1
            Dim aa As Array = Split(dgv1.Rows(g).Cells("File_Name").Value, ".")
            If aa.Length = 2 Then
                If aa(1) = "txt" Then
                    readsubclip(mediafullpath & dgv1.Rows(g).Cells("File_Name").Value)
                    If System.IO.File.Exists(thumbnailsfullpath & Split(masterfilename, ".")(0) & ".png") Then
                        dgv1.Rows(g).Cells("Column3").Value = System.Drawing.Image.FromFile(thumbnailsfullpath & Split(masterfilename, ".")(0) & ".png")
                    End If
                Else
                    If System.IO.File.Exists(thumbnailsfullpath & aa(0) & ".png") Then
                        dgv1.Rows(g).Cells("Column3").Value = System.Drawing.Image.FromFile(thumbnailsfullpath & aa(0) & ".png")
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub cmdnowplaying_Click(sender As System.Object, e As System.EventArgs) Handles cmdnowplaying.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", "Showing Now")

        Dim aa1 As Array = Split(Replace(dgv1.Rows(currrow).Cells("File_Name").Value, "\", "/"), "/")
        CasparCGDataCollection.SetData("f1", Split((aa1(aa1.Length - 1)), ".")(0))

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(8, "CMP/cg_template/commingupnext", True, CasparCGDataCollection.ToAMCPEscapedXml)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Play(8)
    End Sub
    Private Sub cmdcommingupnext_Click(sender As System.Object, e As System.EventArgs) Handles cmdcommingupnext.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", "Comming Up Next")

        Dim aa1 As Array = Split(Replace(dgv1.Rows(currrow + txtcommingupnext.Text).Cells("File_Name").Value, "\", "/"), "/")
        CasparCGDataCollection.SetData("f1", Split((aa1(aa1.Length - 1)), ".")(0))

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(8, "CMP/cg_template/commingupnext", True, CasparCGDataCollection.ToAMCPEscapedXml)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Play(8)
    End Sub
    Private Sub cmdstopnowplaying_Click(sender As System.Object, e As System.EventArgs) Handles cmdstopnowplaying.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(8)
    End Sub

    Private Sub cmdbackin_Click(sender As System.Object, e As System.EventArgs) Handles cmdbackin.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", "Back In")

        Dim dH As Integer = 0
        Dim dM As Integer = 0
        Dim dS As Integer = 0

        Dim dd As Array = Split(dgv1.Rows(dgv1.CurrentRow.Index + txtbackin.Text).Cells("Start_Time").Value, ":")
        dH = dH + dd(0)
        dM = dM + dd(1)
        dS = dS + dd(2)

        Dim totalsecond As Integer = dH * 3600 + dM * 60 + dS
        Dim aa = TimeSpan.FromSeconds(totalsecond)
        Dim date1 As New Date(Now.Year, Now.Month, Now.Day, dH, dM, dS)

        Dim bb As TimeSpan = date1 - Now

        CasparCGDataCollection.SetData("initialvalue", bb.TotalMilliseconds)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(8, "CMP/cg_template/backin", True, CasparCGDataCollection.ToAMCPEscapedXml)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Play(8)
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

        cmdforwardoneframeforclipgrid.BackColor = SystemColors.Control
        cmdforwardoneframeforclipgrid.ForeColor = Color.Black

        cmdplayforclipgrid.BackColor = SystemColors.Control
        cmdplayforclipgrid.ForeColor = Color.Black

        cmdplaynextforclipgrid.BackColor = SystemColors.Control
        cmdplaynextforclipgrid.ForeColor = Color.Black

        cmdbackoneframeforclipgrid.BackColor = SystemColors.Control
        cmdbackoneframeforclipgrid.ForeColor = Color.Black

        cmdpauseforclipgrid.BackColor = SystemColors.Control
        cmdpauseforclipgrid.ForeColor = Color.Black

        sender.BackColor = Color.Green
        sender.ForeColor = Color.White
    End Sub

    Private Sub cmdpauseforclipgrid_Click(sender As Object, e As EventArgs) Handles cmdpauseforclipgrid.Click
        On Error Resume Next
        CasparDevice.SendString("pause " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)
        lastclickedbutton(sender)
    End Sub
    Private Sub OpenInTrimmerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenInTrimmerToolStripMenuItem.Click
        On Error Resume Next

        If dgv1.CurrentRow.Cells("File_Name").Value.ToString.Contains("://") Then
            ucTrimmer.UcnewTrimmer11.openfileintrimmer(Replace(dgv1.CurrentRow.Cells("File_Name").Value, "://", ":/"))
        Else
            ucTrimmer.UcnewTrimmer11.openfileintrimmer(Replace(mediafullpath & dgv1.CurrentRow.Cells("File_Name").Value, "\", "/"))
        End If
        ucTrimmer.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document
        ucTrimmer.Show(frmmediaplayer.DockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document)
        ucTrimmer.Focus()
    End Sub


    Private Async Sub FileInformationToolStripMenuItem1_ClickAsync(sender As Object, e As EventArgs) Handles FileInformationToolStripMenuItem1.Click
        showfileinformation(mediafullpath & dgvclips.CurrentRow.Cells("File_Name").Value.ToString)
    End Sub

    Private Sub FileInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileInformationToolStripMenuItem.Click
        On Error Resume Next
        If dgv1.CurrentRow.Cells("File_Name").Value.ToString.Contains("://") Then

            showfileinformation(Replace(dgv1.CurrentRow.Cells("File_Name").Value.ToString, "://", ":/"))
        Else
            showfileinformation(mediafullpath & dgv1.CurrentRow.Cells("File_Name").Value.ToString)
        End If

    End Sub

    Private Sub dgvclips_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgv1.DataError, dgvclips.DataError
        'dummy code Don't delete.
    End Sub

    Private Sub chkclipcountdown_CheckedChanged(sender As Object, e As EventArgs) Handles chkclipcountdown.CheckedChanged
        On Error Resume Next
        If chkclipcountdown.Checked Then

            'CasparCGDataCollection.Clear()
            'CasparCGDataCollection.SetData("f0", mstohms(clipsleftduration * 1000))
            'CasparDevice.Channels(g_int_ChannelNumber).CG.Add(12, 12, "cmp/clipcountdown/clipcountdown1", True, CasparCGDataCollection.ToAMCPEscapedXml)
            Dim str As String = "play " & g_int_ChannelNumber + 1 & "-12 [html] " & "c:/casparcg/CMP/clipcountdown/ClipCountDown1_html.html"
            CasparDevice.SendString(str)

            tmrclipcountdown.Enabled = True
        Else
            'CasparDevice.Channels(g_int_ChannelNumber).CG.Stop(12, 12)
            Dim str As String = "stop " & g_int_ChannelNumber + 1 & "-12"
            CasparDevice.SendString(str)

            tmrclipcountdown.Enabled = False
        End If
    End Sub
    Private Sub chknextcuefor2ndchannel_CheckedChanged(sender As Object, e As EventArgs) Handles chknextcuefor2ndchannel.CheckedChanged

        If chknextcuefor2ndchannel.Checked Then
        Else
            CasparDevice.SendString("stop " & g_int_ChannelNumber + 1 & "-" & g_int_PlaylistLayer)
            seconndchannelloopvideoname = ""
        End If
    End Sub
    Private Sub cmdplaylistfullscreen_Click(sender As Object, e As EventArgs)
        Me.Size = New Size(1372, 620)
        Me.Location = New Point(0, 60)

        gbplaylist.Size = New Size(1360, 610)

        gbplaylist.Location = New Point(3, 3)

        gbcliplist.Hide()
        tvclips.Hide()
        gbplayerforclipgrid.Hide()

        dgv1.Height = 510
        dgv1.Width = 1360
        frmmediaplayer.ucCasparcgWindow1.Location = casparwindowstartpoint

        Me.BringToFront()
    End Sub

    Private Sub ucPlaylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        initialiseplaylistdata()
        initialisetvclips()

        dgv1.Columns("File_Name").DefaultCellStyle.Font = New Font("Arial Black", 13, FontStyle.Regular)
        dgvclips.Columns("File_Name").DefaultCellStyle.Font = New Font("Arial Black", 13, FontStyle.Regular)
        tvclips.Font = New Font("Arial Black", 13, FontStyle.Regular)
    End Sub
    Private Sub dgv1_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs)
        On Error Resume Next
        e.Row.Cells("x").Value = 1
        e.Row.Cells("Transition").Value = "MIX"
        e.Row.Cells("T_Duration").Value = 10

        e.Row.Cells("AudioLevel").Value = 1.0
        e.Row.Cells("FileType").Value = "Others"

    End Sub
    Sub colorchange(i As Integer)
        If dgv1.Rows(i).Cells("FileType").Value = "Program" Then dgv1.Rows(i).DefaultCellStyle.BackColor = Color.Yellow : dgv1.Rows(i).Cells(0).Style.BackColor = Color.Yellow
        If dgv1.Rows(i).Cells("FileType").Value = "Promo" Then dgv1.Rows(i).DefaultCellStyle.BackColor = Color.Pink : dgv1.Rows(i).Cells(0).Style.BackColor = Color.Pink
        If dgv1.Rows(i).Cells("FileType").Value = "Commercial" Then dgv1.Rows(i).DefaultCellStyle.BackColor = Color.Orange : dgv1.Rows(i).Cells(0).Style.BackColor = Color.Orange
        If dgv1.Rows(i).Cells("FileType").Value = "Others" Then dgv1.Rows(i).DefaultCellStyle.BackColor = Color.White : dgv1.Rows(i).Cells(0).Style.BackColor = Color.White
        If dgv1.Rows(i).Cells("FileType").Value = "" Then dgv1.Rows(i).DefaultCellStyle.BackColor = Color.White : dgv1.Rows(i).Cells(0).Style.BackColor = Color.White
    End Sub
    Private Sub tmrduration_Tick(sender As Object, e As EventArgs) Handles tmrduration.Tick
        On Error Resume Next
        getdurationbyosc()
        For i As Integer = 0 To dgv1.Rows.Count - 1
            If i = currrow Then
                dgv1.Rows(currrow).Cells(0).Style.BackColor = Color.LightGreen
            Else
                If dgv1.Rows(i).DefaultCellStyle.BackColor <> Color.Red Then
                    colorchange(i)
                End If

            End If
        Next i
        If chktemplatewithplaylist.Checked = True Then
            If dgv1.Rows(currrow).Cells("BackIn").Value = 1 Then
                Dim backinduration As Double = Val(frmmediaplayer.ucTab1.UcPlaylistSetting1.txtBackinTimer.Text)
                If clipsleftduration > (backinduration + 1.7) And clipsleftduration < (backinduration + 2.3) Then

                    CasparCGDataCollection.Clear()
                    CasparCGDataCollection.SetData("initialvalue", (backinduration + 2) * 1000)
                    CasparCGDataCollection.SetData("f0", "Back In")

                    CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(8, "CMP/cg_template/backin", True, CasparCGDataCollection.ToAMCPEscapedXml)
                    CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Play(8)
                End If
            End If
        End If
    End Sub

    Private Sub tmrclipcountdown_Tick(sender As Object, e As EventArgs) Handles tmrclipcountdown.Tick
        On Error Resume Next
        'CasparCGDataCollection.Clear()
        'CasparCGDataCollection.SetData("f0", mstohms(clipsleftduration * 1000))
        'CasparCGDataCollection.SetData("f1", onlyfilenamewithoutextension(playingfilename))
        'CasparCGDataCollection.SetData("f2", onlyfilename(seconndchannelloopvideoname))
        'CasparDevice.Channels(g_int_ChannelNumber).CG.Update(12, 12, CasparCGDataCollection)
        Dim str = "call " & g_int_ChannelNumber + 1 & "-12 " & """" & "document.getElementById('ccgf0').innerText='" + onlyfilenamewithoutextension(playingfilename) + "';document.getElementById('ccgf1').innerText='" + mstohms(clipsleftduration * 1000) + "';document.getElementById('ccgf2').innerText='" + onlyfilename(seconndchannelloopvideoname) + "'" + """"
        CasparDevice.SendString(str)

    End Sub

    Private Sub tmrfornotskiping_Tick(sender As Object, e As EventArgs) Handles tmrfornotskiping.Tick
        On Error Resume Next
        tmrnextclip.Enabled = True
        tmrfornotskiping.Enabled = False
    End Sub
    Private Sub InsertDecklinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InsertDecklinkToolStripMenuItem1.Click, InsertDecklinkToolStripMenuItem2.Click, InsertDecklinkToolStripMenuItem3.Click, InsertDecklinkToolStripMenuItem4.Click, InsertDecklinkToolStripMenuItem5.Click, InsertDecklinkToolStripMenuItem6.Click, InsertDecklinkToolStripMenuItem7.Click, InsertDecklinkToolStripMenuItem8.Click
        On Error Resume Next
        insertlivedecklink(sender.text)
    End Sub

    Private Sub ShowLiveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ShowLiveToolStripMenuItem1.Click, ShowLiveToolStripMenuItem2.Click, ShowLiveToolStripMenuItem3.Click, ShowLiveToolStripMenuItem4.Click, ShowLiveToolStripMenuItem5.Click, ShowLiveToolStripMenuItem6.Click, ShowLiveToolStripMenuItem7.Click, ShowLiveToolStripMenuItem8.Click
        On Error Resume Next
        showlivedecklink(sender.text)
    End Sub
    Private Sub InserEndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InserEndToolStripMenuItem.Click
        On Error Resume Next
        insertend()
    End Sub

    Private Sub DeSelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeSelectAllToolStripMenuItem.Click
        On Error Resume Next
        deselectAll()
    End Sub
    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        On Error Resume Next
        selectAll()
    End Sub
    Private Sub SetStartTimeAcoordingToCurrentRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetStartTimeAcoordingToCurrentRowToolStripMenuItem.Click
        On Error Resume Next
        SetStartTimeAccordingToCurrentRow()
    End Sub

    Private Sub RefreshThumbnailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshThumbnailToolStripMenuItem.Click
        On Error Resume Next
        RefreshThumbnail()
    End Sub

    Private Sub InserPlaylistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InserPlaylistToolStripMenuItem.Click
        On Error Resume Next
        insertfile()
    End Sub

    Private Sub txtfps_TextChanged(sender As Object, e As EventArgs) Handles txtfps.TextChanged
        On Error Resume Next
        fps = txtfps.Text
    End Sub


    Function makedoubledigit(number As String)
        If number < 10 Then number = "0" & number
        Return number
    End Function

    Function getfilenamewithoutdirectoty(aa As String)
        On Error Resume Next
        Dim bb As New OpenFileDialog
        bb.FileName = aa
        Dim cc As String = bb.SafeFileName
        Return cc
    End Function

    Private Sub dgv1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        'If e.ColumnIndex = 13 Then
        If sender.columns(e.ColumnIndex).headercell.value = "Template File" Then
            Dim aa As New OpenFileDialog
            aa.InitialDirectory = "c:\casparcg\mydata\rundown\"
            If aa.ShowDialog = DialogResult.OK Then
                dgv1.CurrentCell.Value = aa.FileName
            End If
        End If
    End Sub
    Private Sub dgv1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgv1.RowsAdded
        updaterownumber()
    End Sub

    Private Sub dgv1_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgv1.RowsRemoved
        updaterownumber()
    End Sub
    Sub updaterownumber()
        On Error Resume Next
        For irownumberupdate = 0 To dgv1.Rows.Count - 1
            dgv1.Rows(irownumberupdate).HeaderCell.Value = irownumberupdate.ToString
        Next
    End Sub
    Private Sub chktemplatewithplaylist_CheckedChanged(sender As Object, e As EventArgs) Handles chktemplatewithplaylist.CheckedChanged

    End Sub
    Private Sub InsertFilterForIMXFile_Click(sender As Object, e As EventArgs) Handles InsertFilterForIMXFile.Click

    End Sub
    Private Sub gbplaylist_DoubleClick(sender As Object, e As EventArgs) Handles gbplaylist.DoubleClick
        Changebackcolor(sender)
    End Sub

    Private Sub chkDeinterlace_CheckedChanged(sender As Object, e As EventArgs) Handles chkDeinterlace.CheckedChanged
        On Error Resume Next
        If ServerVersion > 2.1 Then
            If sender.checked = True Then
                deinterlaced = " vf yadif=1:0"
            Else
                deinterlaced = ""

            End If
        Else
            If sender.checked = True Then
                deinterlaced = " filter yadif=1:0"
            Else
                deinterlaced = ""
            End If
        End If
    End Sub
    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        On Error Resume Next
        For i = 0 To dgv1.Rows.Count - 1
            dgv1.Rows(i).Cells("Transition").Value = "CUT"
        Next
    End Sub
    Private Sub MIXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MIXToolStripMenuItem.Click
        On Error Resume Next
        For i = 0 To dgv1.Rows.Count - 1
            dgv1.Rows(i).Cells("Transition").Value = "MIX"
        Next
    End Sub
    Private Sub WIPEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WIPEToolStripMenuItem.Click
        On Error Resume Next
        For i = 0 To dgv1.Rows.Count - 1
            dgv1.Rows(i).Cells("Transition").Value = "WIPE"
        Next
    End Sub

    Private Sub PUSHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PUSHToolStripMenuItem.Click
        On Error Resume Next
        For i = 0 To dgv1.Rows.Count - 1
            dgv1.Rows(i).Cells("Transition").Value = "PUSH"
        Next
    End Sub

    Private Sub SLIDEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SLIDEToolStripMenuItem.Click
        On Error Resume Next
        For i = 0 To dgv1.Rows.Count - 1
            dgv1.Rows(i).Cells("Transition").Value = "SLIDE"
        Next
    End Sub

    Private Sub NewToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        On Error Resume Next
        newdgv()
    End Sub

    Private Sub OpenToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        On Error Resume Next
        openfile()
    End Sub
    Private Sub SaveToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        On Error Resume Next
        saveplaylist(lblplalistname.Text)
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        savefile()
    End Sub
    Private Sub MenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip1.MouseHover
        MakeMenuDropDownWhenParrented(sender)
    End Sub

    Private Sub MnuPlayinffplay_Click(sender As Object, e As EventArgs) Handles mnuPlayinffplay.Click
        On Error Resume Next


        If (dgv1.CurrentRow.Cells("File_Name").Value.ToString.ToLower).Contains("p://") Then
            playinffplay(dgv1.CurrentRow.Cells("File_Name").Value.ToString)
            Exit Sub
        End If
        If dgv1.CurrentRow.Cells("File_Name").Value.ToString.Contains("://") Then

            playinffplay(Replace(dgv1.CurrentRow.Cells("File_Name").Value.ToString, "://", ":/"))
        Else
            playinffplay(mediafullpath & dgv1.CurrentRow.Cells("File_Name").Value.ToString)
        End If


    End Sub
    Private Sub Txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
    End Sub
    Private Sub InsertDecklinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertDecklinkToolStripMenuItem.Click
    End Sub
    Private Sub cmdFullScreen_Click(sender As Object, e As EventArgs) Handles cmdFullScreen.Click
        gbcliplist.BringToFront()
        gbcliplist.Size = modulegbsize
        gbcliplist.Top = 0 'frmmediaplayer.pnlServer.Height + 1
        tvclips.Height = 296 + 560
        dgvclips.Height = 223 + 560
        gbplayerforclipgrid.Top = dgvclips.Height + dgvclips.Top + 2
    End Sub

    Private Sub cmdSmallScreen_Click(sender As Object, e As EventArgs) Handles cmdSmallScreen.Click
        gbcliplist.Size = New Size(1221, 373) ' modulegbsize
        gbcliplist.Location = New Point(8, 565) ' New Point(8, 579) 'modulestartpoint
        tvclips.Height = 296 ' + 500
        dgvclips.Height = 223 ' + 500
        gbplayerforclipgrid.Top = dgvclips.Height + dgvclips.Top + 2
    End Sub

    Private Sub Cmdcueclip_Click(sender As Object, e As EventArgs) Handles cmdcueforclipgrid.Click
        On Error Resume Next
        cuefromclipgrid()
    End Sub
    Private Sub Cmdbackoneframe_Click(sender As Object, e As EventArgs) Handles cmdbackoneframeforclipgrid.Click
        On Error Resume Next
        CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(ucOSC.dgvosc.Rows(8).Cells(1).Value) & """" + " seek " & frmmediaplayer.ucCasparcgWindow1.lblcurrentframe.Text - 1)
        lastclickedbutton(sender)
    End Sub
    Private Sub CmdPlaySingleClip_Click(sender As Object, e As EventArgs) Handles cmdplayforclipgrid.Click
        On Error Resume Next
        playfromclipgrid()

    End Sub

    Private Sub cmdforwardoneframeforclipgrid_Click(sender As Object, e As EventArgs) Handles cmdforwardoneframeforclipgrid.Click
        On Error Resume Next
        CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(ucOSC.dgvosc.Rows(8).Cells(1).Value) & """" + " seek " & frmmediaplayer.ucCasparcgWindow1.lblcurrentframe.Text + 1)
        lastclickedbutton(sender)
    End Sub

    Private Sub cmdresumeforclipgrid_Click(sender As Object, e As EventArgs) Handles cmdresumeforclipgrid.Click
        On Error Resume Next
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)
        lastclickedbutton(sender)
    End Sub

    Private Sub cmdstopforclipgrid_Click(sender As Object, e As EventArgs) Handles cmdstopforclipgrid.Click
        On Error Resume Next
        CasparDevice.SendString("stop " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)
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
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek & " length " & cliplength & deinterlaced)
        Else
            CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(dgvclips.CurrentRow.Cells("File_Name").Value) & """" & deinterlaced)
        End If
        tmrduration.Enabled = True
        palyloopinsecondchannel()

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
            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(masterfilename) & """" + " seek " & clipseek & " length " & cliplength & deinterlaced)
        Else
            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & ModifyFilename(dgvclips.CurrentRow.Cells("File_Name").Value) & """" & deinterlaced)
        End If
        tmrduration.Enabled = True
        palyloopinsecondchannel()
        lastclickedbutton(sender)
    End Sub
    Private Sub dgvclips_DragEnter(sender As Object, e As DragEventArgs) Handles dgvclips.DragEnter
    End Sub
    Private Sub dgvclips_DragDrop(sender As Object, e As DragEventArgs) Handles dgvclips.DragDrop
    End Sub

    Private Sub ucPlaylist_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If chkplaylistlock.Checked = False Then
            Select Case e.KeyCode
                Case Keys.F1
                    clipstop()
                Case Keys.F2
                    PlaySingleClip()
                Case Keys.F3
                    cueclip()
                Case Keys.F4
                    clipresume()
                Case Keys.F5
                    nextclip()

                Case Keys.F6
                    nextclipplay()

                Case Keys.F11
                    CasparDevice.SendString("clear " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)

                Case Keys.F12
                    CasparDevice.SendString("clear " & g_int_ChannelNumber)
                    CasparDevice.SendString("mixer " & g_int_ChannelNumber & " clear")

            End Select
        End If
    End Sub

    Private Sub ForIMXFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForIMXFileToolStripMenuItem.Click
        If ServerVersion > 2.1 Then
            dgv1.CurrentRow.Cells("clmFilter").Value = "vf crop=720:576:0:32"
        Else
            dgv1.CurrentRow.Cells("clmFilter").Value = "filter crop=720:576:0:32"
        End If
    End Sub

    Private Sub LToBothToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LToBothToolStripMenuItem.Click
        If ServerVersion > 2.1 Then
            dgv1.CurrentRow.Cells("clmFilter").Value = "af pan=stereo|c0=c0|c1=c0"
        Else
            dgv1.CurrentRow.Cells("clmFilter").Value = "Channel_Layout L_To_Both"
        End If
    End Sub

    Private Sub RToBothToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RToBothToolStripMenuItem.Click
        If ServerVersion > 2.1 Then
            dgv1.CurrentRow.Cells("clmFilter").Value = "af pan=stereo|c0=c1|c1=c1"
        Else
            dgv1.CurrentRow.Cells("clmFilter").Value = "Channel_Layout R_To_Both"
        End If
    End Sub

    Private Sub MixToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MixToolStripMenuItem1.Click
        If ServerVersion > 2.1 Then
            dgv1.CurrentRow.Cells("clmFilter").Value = "af pan=stereo|c0=0.7c0+0.7c1|c1=0.7c0+0.7c1"
        Else
            dgv1.CurrentRow.Cells("clmFilter").Value = "Channel_Layout Mix"
        End If
    End Sub

    Private Sub OnlyLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnlyLToolStripMenuItem.Click
        If ServerVersion > 2.1 Then
            dgv1.CurrentRow.Cells("clmFilter").Value = "af pan=stereo|c0=c0|c1=0c1"
        Else
            dgv1.CurrentRow.Cells("clmFilter").Value = "Channel_Layout Only_L"
        End If
    End Sub

    Private Sub OnlyRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnlyRToolStripMenuItem.Click
        If ServerVersion > 2.1 Then
            dgv1.CurrentRow.Cells("clmFilter").Value = "af pan=stereo|c0=0c0|c1=c1"
        Else
            dgv1.CurrentRow.Cells("clmFilter").Value = "Channel_Layout Only_R"
        End If
    End Sub

    Private Sub Yadif10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Yadif10ToolStripMenuItem.Click
        If ServerVersion > 2.1 Then
            dgv1.CurrentRow.Cells("clmFilter").Value = "vf yadif=1:0"
        Else
            dgv1.CurrentRow.Cells("clmFilter").Value = "filter yadif=1:0"
        End If
    End Sub

    Private Sub Yadif11ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Yadif11ToolStripMenuItem.Click
        If ServerVersion > 2.1 Then
            dgv1.CurrentRow.Cells("clmFilter").Value = "vf yadif=1:1"
        Else
            dgv1.CurrentRow.Cells("clmFilter").Value = "filter yadif=1:1"
        End If
    End Sub

    Private Sub STRETCHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STRETCHToolStripMenuItem.Click
        If ServerVersion > 2.0 Then
            dgv1.CurrentRow.Cells("clmFilter").Value = "SCALE_MODE STRETCH"
        End If

    End Sub

    Private Sub FITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FITToolStripMenuItem.Click
        If ServerVersion > 2.0 Then
            dgv1.CurrentRow.Cells("clmFilter").Value = "SCALE_MODE FIT"
        End If
    End Sub

    Private Sub FILLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FILLToolStripMenuItem.Click
        If ServerVersion > 2.0 Then
            dgv1.CurrentRow.Cells("clmFilter").Value = "SCALE_MODE FILL"
        End If
    End Sub

    Private Sub ORIGINALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORIGINALToolStripMenuItem.Click
        If ServerVersion > 2.0 Then
            dgv1.CurrentRow.Cells("clmFilter").Value = "SCALE_MODE ORIGINAL"
        End If
    End Sub
End Class
