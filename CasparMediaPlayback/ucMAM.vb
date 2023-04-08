Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports System.ComponentModel
Imports MediaInfoLib
Imports System.Data
Imports Microsoft.Win32 'for number of processor
Public Class ucMAM
    Dim ibt As Integer

    Dim fps As Integer = 25
    Dim proc As New Process
    Dim i As Integer = 0

    Dim threadstousefortranscoding As String

    Dim dtmediabase As New DataTable()
    Dim drmediabase As DataRow
    Dim mediafolder, symlinkedfolder1, symlinkedfolder2 As String
    Dim alias1, alias2 As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        getnumberofprocessors()
    End Sub

    Public Sub ProcessDirectory(ByVal targetDirectory As String, aa As ListBox)
        On Error Resume Next
        Dim fileEntries As String() = Directory.GetFiles(targetDirectory)
        ' Process the list of files found in the directory.
        Dim fileName As String

        For Each fileName In fileEntries
            ProcessFile(fileName, aa)
        Next fileName
        Dim subdirectoryEntries As String() = Directory.GetDirectories(targetDirectory)
        ' Recurse into subdirectories of this directory.
        Dim subdirectory As String
        Dim lstbox As ListBox = aa
        For Each subdirectory In subdirectoryEntries
            ProcessDirectory(subdirectory, lstbox)
        Next subdirectory

    End Sub
    Public Sub ProcessFile(ByVal path As String, aa As ListBox)
        On Error Resume Next
        aa.Items.Add(path)
    End Sub

    Private Sub cmdCopy_Click(sender As Object, e As EventArgs) Handles cmdCopy.Click
        On Error Resume Next
        Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(lstSourceDirectory.SelectedItem.ToString, txtDestinationDirectory.Text & getfilenamewithoutdirectoty(lstSourceDirectory.SelectedItem.ToString), UIOption.AllDialogs)
    End Sub
    Private Sub cmdMove_Click(sender As Object, e As EventArgs) Handles cmdMove.Click
        On Error Resume Next
        Microsoft.VisualBasic.FileIO.FileSystem.MoveFile(lstSourceDirectory.SelectedItem.ToString, txtDestinationDirectory.Text & getfilenamewithoutdirectoty(lstSourceDirectory.SelectedItem.ToString), UIOption.AllDialogs)

    End Sub
    Private Sub cmdshowfilesinSourcelistbox_Click(sender As Object, e As EventArgs) Handles cmdshowfilesinSourcelistbox.Click
        On Error Resume Next
        lstSourceDirectory.Items.Clear()

        ProcessDirectory(txtSourceDirectory.Text, lstSourceDirectory)
    End Sub

    Private Sub cmdshowfilesinDestinationlistbox_Click(sender As Object, e As EventArgs) Handles cmdshowfilesinDestinationlistbox.Click
        On Error Resume Next
        lstDestinationDirectory.Items.Clear()
        ProcessDirectory(txtDestinationDirectory.Text, lstDestinationDirectory)
    End Sub

    Private Sub cmdmakeproxy_Click(sender As Object, e As EventArgs) Handles cmdmakeproxy.Click
        On Error Resume Next
        UcTranscodingProfile1.getextensionfortranscoding()
        UcTranscodingProfile1.ofdtrimmer.FileName = lstSourceDirectory.SelectedItem.ToString
        UcTranscodingProfile1.osdcutfilename.FileName = txtDestinationDirectoryProxy.Text & getfilenamewithoutdirectotyandExtension(lstSourceDirectory.SelectedItem.ToString) & UcTranscodingProfile1.strFileExtension
        UcTranscodingProfile1.gettranscodingcommand()
        Process.Start("CMD", " /K c:\casparcg\mydata\ffmpeg\ffmpeg.exe " & UcTranscodingProfile1.cmdtranscodingcommand)
    End Sub

    Function ModifyFilenamewithoutextension(FilenameWithExtension As String) As String
        On Error Resume Next
        Dim fileExtPos As Integer = FilenameWithExtension.LastIndexOf(".")
        If (fileExtPos >= 0) Then
            Return FilenameWithExtension.Substring(0, fileExtPos)
        Else
            Return FilenameWithExtension
        End If
    End Function

    Private Sub cmdshowfilesinDestinationlistboxproxy_Click(sender As Object, e As EventArgs) Handles cmdshowfilesinDestinationlistboxproxy.Click
        On Error Resume Next
        lstDestinationDirectoryProxy.Items.Clear()
        ProcessDirectory(txtDestinationDirectoryProxy.Text, lstDestinationDirectoryProxy)
    End Sub
    Private Sub cmdopendestinationdirectory_Click(sender As Object, e As EventArgs) Handles cmdopendestinationdirectory.Click
        On Error Resume Next
        txtDestinationDirectory.Text = folderbrowsing(txtDestinationDirectory.Text)
    End Sub
    Private Sub cmdopendestinationdirectoryproxy_Click(sender As Object, e As EventArgs) Handles cmdopendestinationdirectoryproxy.Click
        On Error Resume Next
        txtDestinationDirectoryProxy.Text = folderbrowsing(txtDestinationDirectoryProxy.Text)
    End Sub
    Private Sub cmdopensourcedirectory_Click(sender As Object, e As EventArgs) Handles cmdopensourcedirectory.Click
        On Error Resume Next
        txtSourceDirectory.Text = folderbrowsing(txtSourceDirectory.Text)
    End Sub

    Function getfilenamewithoutdirectoty(aa As String)
        On Error Resume Next
        Dim bb As New OpenFileDialog
        bb.FileName = aa
        Dim cc As String = bb.SafeFileName
        Return cc
    End Function
    Function getfilenamewithoutdirectotyandExtension(aa As String)
        On Error Resume Next
        aa = getfilenamewithoutdirectoty(aa)
        Dim fileExtPos As Integer = aa.LastIndexOf(".")
        If (fileExtPos >= 0) Then
            Return aa.Substring(0, fileExtPos)
        Else
            Return aa
        End If
    End Function

    Private Sub cmdselectsourcefolderfortranscoding_Click(sender As Object, e As EventArgs) Handles cmdselectsourcefolderfortranscoding.Click
        On Error Resume Next
        Dim aa As New FolderBrowserDialog
        aa.SelectedPath = txtsourcedirectorybt.Text
        If aa.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtsourcedirectorybt.Text = aa.SelectedPath & "\"
        End If
    End Sub

    Private Sub cmdselectdestinationfolderfortranscoding_Click(sender As Object, e As EventArgs) Handles cmdselectdestinationfolderfortranscoding.Click
        On Error Resume Next
        Dim aa As New FolderBrowserDialog
        aa.SelectedPath = txtdestinationdirectorybt.Text
        If aa.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtdestinationdirectorybt.Text = aa.SelectedPath & "\"
        End If

    End Sub
    Private Sub cmdfilldatgridbt_Click(sender As Object, e As EventArgs) Handles cmdfilldatgridbt.Click
        filldatagridbt()
    End Sub

    Sub filldatagridbt()
        On Error Resume Next
        ibt = 0
        dgvtranscoder.Rows.Clear()
        ProcessDirectorybt(txtsourcedirectorybt.Text)
    End Sub

    Public Sub ProcessDirectorybt(ByVal targetDirectory As String)
        On Error Resume Next
        Dim fileEntries As String() = Directory.GetFiles(targetDirectory)
        For Each fileName As String In fileEntries
            ProcessFilebt(fileName)
        Next fileName
        Dim subdirectoryEntries As String() = Directory.GetDirectories(targetDirectory)

        For Each subdirectory As String In subdirectoryEntries
            ProcessDirectorybt(subdirectory)
        Next subdirectory

    End Sub
    Function ModifyFilename(FilenameWithExtension As String) As String
        On Error Resume Next
        Dim fileExtPos As Integer = FilenameWithExtension.LastIndexOf(".")
        If (fileExtPos >= 0) Then
            Return FilenameWithExtension.Substring(0, fileExtPos)
        Else
            Return FilenameWithExtension
        End If
    End Function
    Public Sub ProcessFilebt(ByVal path As String)
        On Error Resume Next
        dgvtranscoder.Rows.Add()
        dgvtranscoder.Rows(ibt).Cells(0).Value = path
        ibt = ibt + 1
    End Sub

    Private Sub cmdstarttranscoding_Click(sender As Object, e As EventArgs) Handles cmdstarttranscoding.Click
        On Error Resume Next
        ibt = 0
        UcTranscodingProfile1.getextensionfortranscoding()
        UcTranscodingProfile1.strinout = ""
        starttranscoding()
    End Sub

    Sub starttranscoding()
        On Error Resume Next
20:
        If dgvtranscoder.Rows(ibt).Cells(1).Value = 1 Then
            UcTranscodingProfile1.ofdtrimmer.FileName = dgvtranscoder.Rows(ibt).Cells(0).Value
        Else
            ibt = ibt + 1
            If dgvtranscoder.Rows.Count > ibt Then GoTo 20
        End If

        If dgvtranscoder.Rows.Count <= ibt Then
            lblexportclipinfobt.Text = "Completed"
            lbltrandingfilename.Text = ""
            Exit Sub
        End If
        Dim newdir As String
        newdir = txtdestinationdirectorybt.Text & Mid(Path.GetDirectoryName(UcTranscodingProfile1.ofdtrimmer.FileName), Len(txtsourcedirectorybt.Text) + 1)

        Directory.CreateDirectory(newdir)

        UcTranscodingProfile1.osdcutfilename.FileName = ModifyFilename(newdir & "\" & UcTranscodingProfile1.ofdtrimmer.SafeFileName) & UcTranscodingProfile1.strFileExtension
        lbltrandingfilename.Text = UcTranscodingProfile1.ofdtrimmer.FileName
        bwforexportclipbt.RunWorkerAsync()
    End Sub

    Private Sub cmdstoptranscoding_Click(sender As Object, e As EventArgs) Handles cmdstoptranscoding.Click
        On Error Resume Next
        proc.Kill()
        For Each p As Process In System.Diagnostics.Process.GetProcessesByName("ffmpeg")
            p.Kill()
        Next
        For Each p As Process In System.Diagnostics.Process.GetProcessesByName("ffmbc-0.7.4-x64")
            p.Kill()
        Next
        ibt = dgvtranscoder.Rows.Count
    End Sub

    Private Sub bwforexportclipbt_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwforexportclipbt.DoWork
        Try
            Control.CheckForIllegalCrossThreadCalls = False

            Dim startinfo As New System.Diagnostics.ProcessStartInfo
            Dim sr As StreamReader

            UcTranscodingProfile1.gettranscodingcommand()
            UcTranscodingProfile1.getstartinfofilename()

            Dim ffmpegOutput As String = ""

            startinfo.FileName = UcTranscodingProfile1.startinfofilename
            startinfo.Arguments = UcTranscodingProfile1.cmdtranscodingcommand

            startinfo.UseShellExecute = False
            startinfo.WindowStyle = ProcessWindowStyle.Hidden
            startinfo.RedirectStandardError = True
            startinfo.RedirectStandardOutput = True
            startinfo.CreateNoWindow = True

            proc.StartInfo = startinfo
            If UcTranscodingProfile1.rdoSDtoXDcamHD422Mxf.Checked Then
                startinfo.FileName = "cmd.exe"
                startinfo.Arguments = " /K c:\casparcg\mydata\ffmpeg\ffmpeg.exe  -y -i " & UcTranscodingProfile1.ofdtrimmer.FileName & " -vcodec mpeg2video -acodec pcm_s24le -vf scale=1440:1080,pad=1920:1080:240:0,setfield=tff -pix_fmt yuv422p -alternate_scan 1  -g 12 -bf 2 -b:v 50000k -minrate 50000k -maxrate 50000k -aspect 16:9 -ac 1 -map 0:0 -map 0:1 -map 0:1 -map 0:1 -map 0:1 -map 0:1 -map 0:1 -map 0:1 -map 0:1 -timecode 00:02:00:00 -metadata creation_time=now -color_primaries bt709 -color_trc 1  -colorspace 1 -f mxf  pipe:1 | c:\casparcg\mydata\ffmbc\ffmbc-0.7.4-x64.exe  -i - -threads 4 -tff -target xdcamhd422 -f mxf -y -an " & UcTranscodingProfile1.osdcutfilename.FileName & " -acodec pcm_s24le -ar 48000 -newaudio -acodec pcm_s24le -ar 48000 -newaudio -acodec pcm_s24le -ar 48000 -newaudio -acodec pcm_s24le -ar 48000 -newaudio -acodec pcm_s24le -ar 48000 -newaudio -acodec pcm_s24le -ar 48000 -newaudio -acodec pcm_s24le -ar 48000 -newaudio -acodec pcm_s24le -ar 48000 -newaudio -map_audio_channel 0:1:0:0:1:0 -map_audio_channel 0:1:0:0:2:0 -map_audio_channel 0:1:0:0:3:0  -map_audio_channel 0:1:0:0:4:0 -map_audio_channel 0:1:0:0:5:0 -map_audio_channel 0:1:0:0:6:0 -map_audio_channel 0:1:0:0:7:0  -map_audio_channel 0:1:0:0:8:0 "
                proc.Start()
                sr = proc.StandardError
                lblexportclipinfobt.Text = ""
                Do
                    ffmpegOutput = sr.ReadLine
                    txtffmpegoutput.Text = ffmpegOutput
                Loop Until ffmpegOutput.Contains("muxing overhead")
                proc.Kill()
            Else
                proc.Start()
                sr = proc.StandardError
                lblexportclipinfobt.Text = ""
                Do
                    ffmpegOutput = sr.ReadLine
                    txtffmpegoutput.Text = ffmpegOutput
                Loop Until proc.HasExited And ffmpegOutput = Nothing Or ffmpegOutput = ""
            End If

        Catch ex As Exception
            proc.Kill()
        End Try
    End Sub

    Private Sub bwforexportclipbt_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwforexportclipbt.RunWorkerCompleted
        On Error Resume Next
        If bwforexportclipbt.CancellationPending = False Then
            ibt = ibt + 1
            If dgvtranscoder.Rows.Count > ibt Then
                Threading.Thread.Sleep(4000)
                'proc.Kill()
                starttranscoding()
            End If
        End If
    End Sub

    Function mstohms(ms As Integer) As String
        Return (TimeSpan.FromMilliseconds(ms)).ToString("hh\:mm\:ss")
    End Function
    Private Function FToHMSF(ByVal frame As Integer) As String     '
        On Error Resume Next
        Dim ts As TimeSpan
        Dim totHrs As Integer
        Dim H, M, S, F, HMSF As String
        ts = TimeSpan.FromMilliseconds(frame * 1000 / fps)

        totHrs = Math.Truncate(ts.TotalHours) 'strip away decimal points
        H = Format(totHrs, "0#") & ":"
        M = Format(ts.Minutes, "0#") & ":"
        S = Format(ts.Seconds, "0#") & ":"
        F = Format((ts.Milliseconds) * fps / 1000, "0#")

        HMSF = H & M & S & F
        '
        Return HMSF

    End Function

    Sub deleteclip(filename As String)
        On Error Resume Next
        Dim ideleted As Integer
        For ideleted = 0 To dtmediabase.Rows.Count - 1
            If dtmediabase.Rows(ideleted).Item(0).ToString Like (Replace(filename, "\", "/") & "*") Then Exit For
        Next
        dtmediabase.Rows.RemoveAt(ideleted)
        For ideleted = dtmediabase.Rows.Count - 1 To 0 Step -1
            If dtmediabase.Rows(ideleted).Item(0).ToString Like (filename & "/" & "*") Then dtmediabase.Rows.RemoveAt(ideleted)
        Next
        searchclip()
    End Sub
    Private Function CheckFileHasCopied(FilePath As String) As Boolean
        Try
            If File.Exists(FilePath) Then
                Using File.OpenRead(FilePath)
                    Return True
                End Using
            Else
                Return False
            End If
        Catch generatedExceptionName As Exception
            Threading.Thread.Sleep(100)
            Return CheckFileHasCopied(FilePath)
        End Try
    End Function

    Sub incrimentalclip(filename As String)
        On Error Resume Next
        Do Until CheckFileHasCopied(mediafolder & filename) = True
        Loop
        If chkmediabackup.Checked Then
            File.Copy(mediafolder & filename, txtmediabackupfplder.Text & filename)
        End If

        If chktranscode.Checked Then
            UcTranscodingProfile1.getextensionfortranscoding()
            UcTranscodingProfile1.ofdtrimmer.FileName = mediafolder & filename
            UcTranscodingProfile1.osdcutfilename.FileName = (txttranscodedirectory.Text & Path.GetFileNameWithoutExtension(filename)) & UcTranscodingProfile1.strFileExtension
            UcTranscodingProfile1.gettranscodingcommand()
            'Process.Start("CMD", UcTranscodingProfile1.cmdtranscodingcommand)
            Process.Start("CMD", " /K c:\casparcg\mydata\ffmpeg\ffmpeg.exe " & UcTranscodingProfile1.cmdtranscodingcommand)
        End If


        Dim f As New FileInfo(mediafolder & filename)
        If (f.Attributes And FileAttributes.Hidden) <> 0 Then GoTo 50
        drmediabase = dtmediabase.NewRow()
        Dim mediainfofile As MediaInfoDotNet.MediaFile = New MediaInfoDotNet.MediaFile(f.FullName)
        drmediabase("Name") = Replace(filename, "\", "/")
        drmediabase("Duration") = mstohms(mediainfofile.duration)
        drmediabase("FPS") = (mediainfofile.Video(0).frameRate)
        drmediabase("Size") = (f.Length \ 1024).ToString() & " KB"
        drmediabase("Date") = f.CreationTime.[Date].ToString("dd/MM/yyyy")
        drmediabase("Type") = f.Extension
        dtmediabase.Rows.Add(drmediabase)
50:     'hidden file
        searchclip()
    End Sub

    Sub allclips()

        On Error Resume Next

        Dim ts1 As TimeSpan
        Dim t1 As Date = Now
        Dim mediainfofile As MediaInfoDotNet.MediaFile

        dtmediabase.Clear()
        Dim s1 As [String]()
        Dim aa As String = mediafolder
        s1 = Directory.GetFiles(aa, "*.*", 1)
        For i As Integer = 0 To s1.Length - 1
            If i = 0 Then
                dtmediabase.Columns.Add("Name")
                dtmediabase.Columns.Add("Duration")
                dtmediabase.Columns.Add("FPS")
                dtmediabase.Columns.Add("Size")
                dtmediabase.Columns.Add("Date")
                dtmediabase.Columns.Add("Type")
            End If
            Dim f As New FileInfo(s1(i))
            drmediabase = dtmediabase.NewRow()
            If (f.Attributes And FileAttributes.Hidden) <> 0 Then GoTo 50

            drmediabase("Name") = Replace(f.FullName.Substring(Len(aa)), "\", "/").ToString

            If chkwithduration.Checked Then
                If System.IO.Path.GetExtension(f.FullName) = ".txt" Then
                    Using sr As StreamReader = New StreamReader(f.FullName)
                        Dim str As Array = Split(sr.ReadLine, Chr(2))
                        drmediabase("Duration") = Mid(FToHMSF(str(2) - str(1)), 1, 8)

                        Dim aaa As New MediaInfoLib.MediaInfo
                        aaa.Open(f.FullName)
                        drmediabase("FPS") = Mid(aaa.Get(StreamKind.Video, 0, "FrameRate"), 1, 2)
                    End Using
                Else
                    Dim aaa As New MediaInfoLib.MediaInfo
                    aaa.Open(f.FullName)
                    drmediabase("Duration") = Mid(aaa.Get(StreamKind.Video, 0, "Duration/String3"), 1, 8)
                    drmediabase("FPS") = Mid(aaa.Get(StreamKind.Video, 0, "FrameRate"), 1, 2)
                End If
            End If



            drmediabase("Size") = (f.Length \ 1024).ToString() & " KB"
            drmediabase("Date") = f.CreationTime.[Date].ToString("dd/MM/yyyy")
            drmediabase("Type") = f.Extension
            dtmediabase.Rows.Add(drmediabase)

50:         'hidden file
            pbsearchprogress.Maximum = s1.Length - 1
            pbsearchprogress.Value = i
        Next

    End Sub
    Sub addfilesytemwatcherforlocaldrive()
        On Error Resume Next

        RemoveHandler fsw.Created, AddressOf filemodified
        RemoveHandler fsw.Deleted, AddressOf filemodified
        RemoveHandler fsw.Renamed, AddressOf filerenamed

        fsw.Path = mediafolder
        fsw.EnableRaisingEvents = True

        ' AddHandler fsw.Changed, AddressOf filemodified
        AddHandler fsw.Created, AddressOf filemodified
        AddHandler fsw.Deleted, AddressOf filemodified
        AddHandler fsw.Renamed, AddressOf filerenamed
    End Sub
    Sub addfilesytemwatcherforalias1()
        On Error Resume Next

        RemoveHandler fswalias1.Created, AddressOf filemodifiedalias1
        RemoveHandler fswalias1.Deleted, AddressOf filemodifiedalias1
        RemoveHandler fswalias1.Renamed, AddressOf filerenamedalias1

        fswalias1.Path = symlinkedfolder1 '"z:/casparcg/_media/"
        fswalias1.EnableRaisingEvents = True

        ' AddHandler fsw.Changed, AddressOf filemodified
        AddHandler fswalias1.Created, AddressOf filemodifiedalias1
        AddHandler fswalias1.Deleted, AddressOf filemodifiedalias1
        AddHandler fswalias1.Renamed, AddressOf filerenamedalias1
    End Sub
    Sub addfilesytemwatcherforalias2()
        On Error Resume Next

        RemoveHandler fswalias2.Created, AddressOf filemodifiedalias2
        RemoveHandler fswalias2.Deleted, AddressOf filemodifiedalias2
        RemoveHandler fswalias2.Renamed, AddressOf filerenamedalias2

        fswalias2.Path = symlinkedfolder2 '"s:/casparcg/_media/"
        fswalias2.EnableRaisingEvents = True

        ' AddHandler fsw.Changed, AddressOf filemodified
        AddHandler fswalias2.Created, AddressOf filemodifiedalias2
        AddHandler fswalias2.Deleted, AddressOf filemodifiedalias2
        AddHandler fswalias2.Renamed, AddressOf filerenamedalias2
    End Sub
    Sub filemodified(ByVal sender As Object, ByVal e As FileSystemEventArgs)

        On Error Resume Next

        Dim bb As String = ""
        If e.ChangeType = IO.WatcherChangeTypes.Changed Then
            bb = "changed"
        End If
        If e.ChangeType = IO.WatcherChangeTypes.Created Then
            bb = "Created "
            incrimentalclip(e.Name)
        End If
        If e.ChangeType = IO.WatcherChangeTypes.Deleted Then
            bb = "Deleted"
            deleteclip(e.Name)
        End If
        If e.ChangeType = IO.WatcherChangeTypes.Renamed Then
            bb = "Renamed"
        End If
        eventnotification(e.Name & " " & bb)

    End Sub
    Sub filemodifiedalias1(ByVal sender As Object, ByVal e As FileSystemEventArgs)

        On Error Resume Next

        Dim bb As String = ""
        If e.ChangeType = IO.WatcherChangeTypes.Changed Then
            bb = "changed"
        End If
        If e.ChangeType = IO.WatcherChangeTypes.Created Then
            bb = "Created "
            incrimentalclip(alias1 & "/" & e.Name)
        End If
        If e.ChangeType = IO.WatcherChangeTypes.Deleted Then
            bb = "Deleted"
            deleteclip(alias1 & "/" & e.Name)
        End If
        If e.ChangeType = IO.WatcherChangeTypes.Renamed Then
            bb = "Renamed"
        End If

        eventnotification(alias1 & "/" & e.Name & " " & bb)
    End Sub

    Sub filemodifiedalias2(ByVal sender As Object, ByVal e As FileSystemEventArgs)
        On Error Resume Next
        Dim bb As String = ""
        If e.ChangeType = IO.WatcherChangeTypes.Changed Then
            bb = "changed"
        End If
        If e.ChangeType = IO.WatcherChangeTypes.Created Then
            bb = "Created "
            incrimentalclip(alias2 & "/" & e.Name)
        End If
        If e.ChangeType = IO.WatcherChangeTypes.Deleted Then
            bb = "Deleted"
            deleteclip(alias2 & "/" & e.Name)
        End If
        If e.ChangeType = IO.WatcherChangeTypes.Renamed Then
            bb = "Renamed"
        End If
        eventnotification(alias2 & "/" & e.Name & " " & bb)
    End Sub


    Sub filerenamed(ByVal sender As Object, ByVal e As RenamedEventArgs)
        On Error Resume Next
        Dim bb As String = ""

        If e.ChangeType = IO.WatcherChangeTypes.Renamed Then
            bb = e.OldName & " Renamed to " & e.Name
        End If
        eventnotification(bb)

        incrimentalclip(e.Name)
        deleteclip(e.OldName)

    End Sub
    Sub filerenamedalias1(ByVal sender As Object, ByVal e As RenamedEventArgs)
        On Error Resume Next
        Dim bb As String = ""
        If e.ChangeType = IO.WatcherChangeTypes.Renamed Then
            bb = alias1 & "/" & e.OldName & " Renamed to " & alias1 & "/" & e.Name
        End If
        eventnotification(bb)

        incrimentalclip(alias1 & "/" & e.Name)
        deleteclip(alias1 & "/" & e.OldName)
    End Sub
    Sub filerenamedalias2(ByVal sender As Object, ByVal e As RenamedEventArgs)
        On Error Resume Next
        Dim bb As String = ""
        If e.ChangeType = IO.WatcherChangeTypes.Renamed Then
            bb = alias2 & "/" & e.OldName & " Renamed to " & alias2 & "/" & e.Name
        End If
        eventnotification(bb)

        incrimentalclip(alias2 & "/" & e.Name)
        deleteclip(alias2 & "/" & e.OldName)
    End Sub
    Sub eventnotification(ByVal eventnameofdatatable As String)
        On Error Resume Next

        txtfilechanged.Text = eventnameofdatatable & vbNewLine & txtfilechanged.Text
    End Sub
    Sub searchclip()
        On Error Resume Next
        Dim strcurrentrowcell0value As String = dgvclips.CurrentRow.Cells(0).Value
        Dim dt1 As New DataTable()
        dt1.Clear()
        dt1.Columns.Add("Name")
        dt1.Columns.Add("Duration")
        dt1.Columns.Add("FPS")
        dt1.Columns.Add("Size")
        dt1.Columns.Add("Date")
        dt1.Columns.Add("Type")

        For Each row1 As DataRow In dtmediabase.Rows
            If UCase(row1.Item(0)) Like "*" & UCase(txtsearchclip.Text) & "*" Then
                dt1.ImportRow(row1)
            End If


        Next
        dgvclips.DataSource = dt1
        dgvclips.Columns("Name").Width = 370
        dgvclips.Columns("Duration").Width = 50
        dgvclips.Columns("FPS").Width = 40
        dgvclips.Columns("Size").Width = 70
        dgvclips.Columns("Date").Width = 80
        dgvclips.Columns("Type").Width = 40
        dgvclips.Sort(dgvclips.Columns("Name"), System.ComponentModel.ListSortDirection.Ascending)

        For iii = 0 To dgvclips.RowCount - 1
            If dgvclips.Rows(iii).Cells(0).Value = strcurrentrowcell0value Then
                dgvclips.CurrentCell = dgvclips.Rows(iii).Cells(0)
                Exit For
            End If
        Next

        labelclips.Text = "Total " & dt1.Rows.Count
    End Sub



    Private Sub cmdsearchdatatable_Click(sender As Object, e As EventArgs) Handles cmdsearchdatatable.Click
        On Error Resume Next
        searchclip()
    End Sub

    Private Sub cmdcreatdatatable_Click(sender As Object, e As EventArgs) Handles cmdcreatdatatable.Click
        On Error Resume Next
        mediafolder = txtmainmediafolder.Text
        symlinkedfolder1 = txtsymlinked1mediafolder.Text
        symlinkedfolder2 = txtsymlinked2mediafolder.Text

        alias1 = txtsymlinkedalis1.Text
        alias2 = txtsymlinkedalis2.Text

        addfilesytemwatcherforlocaldrive()
        If chksymlinkedalis1.Checked Then addfilesytemwatcherforalias1()
        If chksymlinkedalis2.Checked Then addfilesytemwatcherforalias2()


        allclips()
        Threading.Thread.Sleep(1000)
        searchclip()
    End Sub

    Private Sub txtsearchclip_TextChanged(sender As Object, e As EventArgs) Handles txtsearchclip.TextChanged
        On Error Resume Next
        searchclip()
    End Sub


    Private Sub cmdSelectDirectoryForAutoCopy_Click(sender As Object, e As EventArgs) Handles cmdSelectDirectoryForAutoCopy.Click
        On Error Resume Next
        txtmediabackupfplder.Text = folderbrowsing(txtmediabackupfplder.Text)
    End Sub

    Function folderbrowsing(originaldirectory As String)
        On Error Resume Next
        Dim fbd As New FolderBrowserDialog
        If fbd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Return fbd.SelectedPath & "\"
        Else
            Return originaldirectory
        End If
    End Function

    Private Sub cmdSelectDirectoryForAutoTranscode_Click(sender As Object, e As EventArgs) Handles cmdSelectDirectoryForAutoTranscode.Click
        On Error Resume Next
        txttranscodedirectory.Text = folderbrowsing(txttranscodedirectory.Text)
    End Sub

    Private Sub cmdSelectDirectoryformainMediawatchfolder_Click(sender As Object, e As EventArgs) Handles cmdSelectDirectoryformainMediawatchfolder.Click
        On Error Resume Next
        txtmainmediafolder.Text = folderbrowsing(txtmainmediafolder.Text)
    End Sub

    Private Sub cmdSelectDirectoryforSymlinked1Mediawatchfolder_Click(sender As Object, e As EventArgs) Handles cmdSelectDirectoryforSymlinked1Mediawatchfolder.Click
        On Error Resume Next
        txtsymlinked1mediafolder.Text = folderbrowsing(txtsymlinked1mediafolder.Text)
    End Sub

    Private Sub cmdSelectDirectoryforSymlinked2Mediawatchfolder_Click(sender As Object, e As EventArgs) Handles cmdSelectDirectoryforSymlinked2Mediawatchfolder.Click
        On Error Resume Next
        txtsymlinked2mediafolder.Text = folderbrowsing(txtsymlinked2mediafolder.Text)
    End Sub

    Private Sub cmdstopwatching_Click(sender As Object, e As EventArgs) Handles cmdstopwatching.Click
        On Error Resume Next
        fsw.EnableRaisingEvents = False
        fswalias1.EnableRaisingEvents = False
        fswalias2.EnableRaisingEvents = False

        RemoveHandler fsw.Created, AddressOf filemodified
        RemoveHandler fsw.Deleted, AddressOf filemodified
        RemoveHandler fsw.Renamed, AddressOf filerenamed
    End Sub

    Private Sub cmdSelectAll_Click(sender As Object, e As EventArgs) Handles cmdSelectAll.Click

        On Error Resume Next
        For ii = 0 To dgvtranscoder.RowCount - 1
            dgvtranscoder.Rows(ii).Cells(1).Value = 1
        Next


    End Sub

    Private Sub cmdDeSelectAll_Click(sender As Object, e As EventArgs) Handles cmdDeSelectAll.Click
        On Error Resume Next
        For ii = 0 To dgvtranscoder.RowCount - 1
            dgvtranscoder.Rows(ii).Cells(1).Value = 0
        Next
    End Sub

    Private Sub dgvtranscoder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtranscoder.CellContentClick
        On Error Resume Next
        lblplayinvlc.Text = dgvtranscoder.CurrentRow.Cells(0).Value
    End Sub



    Private Sub lstSourceDirectory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSourceDirectory.SelectedIndexChanged
        On Error Resume Next
        lblplayinvlc.Text = lstSourceDirectory.SelectedItem.ToString
    End Sub

    Private Sub lstDestinationDirectory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDestinationDirectory.SelectedIndexChanged
        On Error Resume Next
        lblplayinvlc.Text = lstDestinationDirectory.SelectedItem.ToString
    End Sub

    Private Sub lstDestinationDirectoryProxy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDestinationDirectoryProxy.SelectedIndexChanged
        On Error Resume Next
        lblplayinvlc.Text = lstDestinationDirectoryProxy.SelectedItem.ToString
    End Sub

    Private Sub dgvclips_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvclips.CellContentClick
        On Error Resume Next
        lblplayinvlc.Text = txtmainmediafolder.Text & dgvclips.CurrentRow.Cells(0).Value
    End Sub


    Private Sub cmdplayinvlc_Click(sender As Object, e As EventArgs) Handles cmdplayinvlc.Click
        On Error Resume Next
        'Dim PlayerPath As String = ""
        'If System.IO.File.Exists("C:\Program Files\VideoLAN\VLC\vlc.exe") Then
        '    PlayerPath = "C:\Program Files\VideoLAN\VLC\vlc.exe"
        'Else
        '    PlayerPath = "C:\Program Files (x86)\VideoLAN\VLC\vlc.exe"
        'End If


        Dim process As Process = New Process
        process.StartInfo.FileName = vlcplayerpath() 'PlayerPath
        process.StartInfo.Verb = "open"
        process.StartInfo.Arguments = """" & Replace(lblplayinvlc.Text, "/", "\") & """"

        process.Start()



    End Sub

    Private Sub cmdshowfileinformation_Click(sender As Object, e As EventArgs) Handles cmdshowfileinformation.Click

        On Error Resume Next
        Dim fileinformation As New MediaInfoLib.MediaInfo

        fileinformation.Open(lblplayinvlc.Text)

        frmfileinformation.dgvfileinformation.Rows.Clear()
        Dim aa As Array = Split(fileinformation.Inform, vbNewLine)
        For iii = 0 To aa.Length
            frmfileinformation.dgvfileinformation.Rows.Add()
            frmfileinformation.dgvfileinformation.Rows(iii).Cells(0).Value = Split(aa(iii), ":")(0)
            frmfileinformation.dgvfileinformation.Rows(iii).Cells(1).Value = aa(iii).ToString.Substring(frmfileinformation.dgvfileinformation.Rows(iii).Cells(0).Value.ToString.Length + 1)
        Next
        frmfileinformation.StartPosition = FormStartPosition.CenterScreen
        frmfileinformation.Show()
    End Sub

    Private Sub cmdsequencetovideomam_Click(sender As Object, e As EventArgs) Handles cmdsequencetovideomam.Click
        On Error Resume Next
        Dim zerocount As Integer
        Dim bb As String = onlyfilenamewithoutextension(txtfirstfile.Text)

        If Microsoft.VisualBasic.Right(bb, 1) = "1" Then zerocount = 1
        If Microsoft.VisualBasic.Right(bb, 2) = "01" Then zerocount = 2
        If Microsoft.VisualBasic.Right(bb, 3) = "001" Then zerocount = 3
        If Microsoft.VisualBasic.Right(bb, 4) = "0001" Then zerocount = 4
        If Microsoft.VisualBasic.Right(bb, 5) = "00001" Then zerocount = 5
        If Microsoft.VisualBasic.Right(bb, 6) = "000001" Then zerocount = 6
        If Microsoft.VisualBasic.Right(bb, 7) = "0000001" Then zerocount = 7
        If Microsoft.VisualBasic.Right(bb, 8) = "00000001" Then zerocount = 8
        If Microsoft.VisualBasic.Right(bb, 9) = "000000001" Then zerocount = 9
        If Microsoft.VisualBasic.Right(bb, 10) = "0000000001" Then zerocount = 10
        Dim cc As String = Replace(Path.GetDirectoryName(txtfirstfile.Text), "\", "/")
        Dim filenamefinal As String = cc & "/" & Mid(bb, 1, Len(bb) - zerocount) & "%" & zerocount & "d" & Path.GetExtension(txtfirstfile.Text)



        Dim sequencetovideomamcommand As String = "/K c:/casparcg/mydata/ffmpeg/ffmpeg.exe -y -i " & """" & filenamefinal & """" & " -codec:v png " & """" & Replace(txtdistinationalphavideo.Text, "\", "/") & """"
        Process.Start("CMD", sequencetovideomamcommand)
    End Sub
    Private Sub cmdvideotosequencemam_Click(sender As Object, e As EventArgs) Handles cmdvideotosequencemam.Click
        On Error Resume Next

        Dim codecname As String
        If cmbcodecforalpha.Text = "tga" Then
            codecname = "targa"
        Else
            codecname = "png"
        End If
        Dim videotosequenceomam As String = "/K c:/casparcg/mydata/ffmpeg/ffmpeg.exe -y -i " & """" & txtsourcefileforalphavideo.Text & """" & " -vcodec " & codecname & " " & """" & txtdestinationfolderforalphaimage.Text & txtfilenameforimage.Text & """" & "%5d." & cmbcodecforalpha.Text
        Process.Start("CMD", videotosequenceomam)

    End Sub

    Private Sub cmdaddingaudiotracktovideomam_Click(sender As Object, e As EventArgs) Handles cmdaddingaudiotracktovideomam.Click
        On Error Resume Next
        Dim addingaudiotracktovideomam As String = "/K " & txtaddingaudiotracktovideomam.Text
        Process.Start("CMD", addingaudiotracktovideomam)
    End Sub
    Private Sub cmdaudioinsinglestream_Click(sender As Object, e As EventArgs) Handles cmdaudioinsinglestream.Click

        On Error Resume Next
        Dim cmdaudioinsinglestream As String = "/K " & txtaudioinsinglestream.Text
        Process.Start("CMD", cmdaudioinsinglestream)

    End Sub

    Sub getnumberofprocessors()
        On Error Resume Next
        Dim rk As RegistryKey = Registry.LocalMachine
        Dim subKeys As Array = rk.OpenSubKey("HARDWARE").OpenSubKey("DESCRIPTION").OpenSubKey("System").OpenSubKey("CentralProcessor").GetSubKeyNames()
        UcTranscodingProfile1.lblnumberofprocessors.Text = "Total number of cores:" + subKeys.Length.ToString()
        UcTranscodingProfile1.txtnumberofprocessors.Text = subKeys.Length - 2
        threadstousefortranscoding = " -threads " & UcTranscodingProfile1.txtnumberofprocessors.Text
    End Sub
    Private Sub txtnumberofprocessors_TextChanged(sender As Object, e As EventArgs)
        On Error Resume Next
        threadstousefortranscoding = " -threads " & UcTranscodingProfile1.txtnumberofprocessors.Text
    End Sub

    Private Sub cmdDeSelectAllfromcurrentposition_Click(sender As Object, e As EventArgs) Handles cmdDeSelectAllfromcurrentposition.Click

        On Error Resume Next
        With dgvtranscoder
            For ii = .CurrentRow.Index To .RowCount - 1
                .Rows(ii).Cells(1).Value = 1
            Next
        End With
    End Sub

    Private Sub cmdvideoforimage_Click(sender As Object, e As EventArgs) Handles cmdvideoforimage.Click
        On Error Resume Next

        If ofd2.ShowDialog() = DialogResult.OK Then
            txtsourcefileforalphavideo.Text = ofd2.FileName
        End If

    End Sub
    Private Sub cmddestinationfolderforalphaimage_Click(sender As Object, e As EventArgs) Handles cmddestinationfolderforalphaimage.Click
        On Error Resume Next
        txtdestinationfolderforalphaimage.Text = folderbrowsing(txtdestinationfolderforalphaimage.Text)
    End Sub

    Private Sub cmdvideosd_Click(sender As Object, e As EventArgs) Handles cmdvideosd.Click
        On Error Resume Next

        If ofd2.ShowDialog() = DialogResult.OK Then
            txtsourcefileforalphavideosd.Text = ofd2.FileName
        End If
    End Sub

    Private Sub cmddestinationfolderforhd_Click(sender As Object, e As EventArgs) Handles cmddestinationfolderforhd.Click
        On Error Resume Next
        txtdestinationfolderforhd.Text = folderbrowsing(txtdestinationfolderforhd.Text)
    End Sub

    Private Sub cmdvideohd_Click(sender As Object, e As EventArgs) Handles cmdvideohd.Click
        On Error Resume Next
        Dim codecname As String
        Dim sdtohdscaling As String = "/K c:/casparcg/mydata/ffmpeg/ffmpeg.exe -y -i " & """" & txtsourcefileforalphavideosd.Text & """" & " -vcodec qtrle -vf scale=1920:1080 " & """" & txtdestinationfolderforhd.Text & txtfilenameforhd.Text & """" & ".mov"
        Process.Start("CMD", sdtohdscaling)
    End Sub


    Private Sub cmdFfmbcTargetTranscoding_Click(sender As Object, e As EventArgs) Handles cmdFfmbcTargetTranscoding.Click
        On Error Resume Next
        Dim cmdFfmbcTargetTranscoding As String = "/K " & txtFfmbcTargetTranscoding.Text
        Process.Start("CMD", cmdFfmbcTargetTranscoding)
    End Sub

    Private Sub cmdsearchdatagridbt_Click(sender As Object, e As EventArgs) Handles cmdsearchdatagridbt.Click, txtsearchdatagridbt.TextChanged
        On Error Resume Next
        filldatagridbt()
        With dgvtranscoder
            For ii = .Rows.Count - 1 To 0 Step -1
                If UCase(.Rows(ii).Cells(0).Value) Like UCase("*" & txtsearchdatagridbt.Text & "*") Then
                Else
                    .Rows.RemoveAt(ii)
                End If
            Next
        End With

    End Sub

    Sub searchdatagridbt()
        With dgvtranscoder
            For ii = .Rows.Count - 1 To 0 Step -1
                If UCase(.Rows(ii).Cells(0).Value) Like UCase("*" & txtsearchdatagridbt.Text & "*") Then
                Else
                    .Rows.RemoveAt(ii)
                End If
            Next
        End With
    End Sub
    'ebu core metadata
    Private Sub cmdreadmetadata_Click(sender As Object, e As EventArgs) Handles cmdreadmetadata.Click
        On Error Resume Next
        Dim ofdmetadata As New OpenFileDialog
        If ofdmetadata.ShowDialog = Windows.Forms.DialogResult.OK Then
            dgvmetadata.Rows.Clear()
            dgvmetadata.Rows.Add(1)
            File.Delete("c:/casparcg/mydata/ebumxf/v2.xml")
            Process.Start("CMD", "/K " & "c:/casparcg/mydata/ebumxf/mxf2ebu --ebu-core " & "c:/casparcg/mydata/ebumxf/v2.xml " & """" & ofdmetadata.FileName & """")
            lblfilenamemetadata.Text = ofdmetadata.FileName
            Threading.Thread.Sleep(1000)

            Dim webAddress As String = "c:/casparcg/mydata/ebumxf/v2.xml"
            Process.Start(webAddress)

        End If
    End Sub

    Private Sub cmdwritemetadata_Click(sender As Object, e As EventArgs) Handles cmdwritemetadata.Click
        On Error Resume Next

        Process.Start("CMD", "/K " & "c:/casparcg/mydata/ebumxf/ebu2mxf.exe --remove " & """" & lblfilenamemetadata.Text & """")
        Using sw As StreamWriter = New StreamWriter("c:/casparcg/mydata/ebumxf/v1.xml")

            sw.WriteLine("<?xml version='1.0' encoding='UTF-8'?><ebuCoreMain xmlns:dc='http://purl.org/dc/elements/1.1/' xmlns:default='http://iptc.org/std/nar/2006-10-01/' xmlns:ebu = 'http://ebu.org/nar-extensions/' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns ='urn:ebu:metadata-schema:ebuCore_2012' Schema='EBU_CORE_20120817.xsd' Version = '1.3' dateLastModified='2011-01-31'><coreMetadata>")

            For imetadata = 0 To dgvmetadata.Rows.Count - 1
                If dgvmetadata.Rows(imetadata).Cells(0).Value <> "" Then
                    sw.WriteLine("<" & Replace(dgvmetadata.Rows(imetadata).Cells(0).Value, " ", "_") & "><dc:" & Replace(dgvmetadata.Rows(imetadata).Cells(0).Value, " ", "_") & ">" & dgvmetadata.Rows(imetadata).Cells(1).Value & "</dc:" & Replace(dgvmetadata.Rows(imetadata).Cells(0).Value, " ", "_") & "></" & Replace(dgvmetadata.Rows(imetadata).Cells(0).Value, " ", "_") & ">")
                End If
            Next

            sw.WriteLine("</coreMetadata>")
            sw.WriteLine("</ebuCoreMain>")
        End Using

        Threading.Thread.Sleep(1000)
        Process.Start("CMD", "/K " & "c:/casparcg/mydata/ebumxf/ebu2mxf.exe --dark --ebu-core " & "c:/casparcg/mydata/ebumxf/v1.xml " & """" & lblfilenamemetadata.Text & """")
    End Sub

    Private Sub cmdclearfieldmetadata_Click(sender As Object, e As EventArgs) Handles cmdclearfieldmetadata.Click
        On Error Resume Next
        dgvmetadata.Rows.Clear()
    End Sub

    Private Sub cmdanalyse_Click(sender As Object, e As EventArgs) Handles cmdanalyse.Click

        Process.Start("CMD", "/K " & "c:/casparcg/mydata/ebumxf/mxfanalyzer.exe " & cmbanalyzeroption.Text & " " & """" & lblfilenamemetadata.Text & """")

        Threading.Thread.Sleep(1000)

        Dim webAddress As String = "c:/casparcg/mydata/ebumxf/report.xml"
        Process.Start(webAddress)
    End Sub

    Private Sub cmdebu2mxf_Click(sender As Object, e As EventArgs) Handles cmdebu2mxf.Click

        Process.Start("CMD", "/K " & "c:/casparcg/mydata/ebumxf/ebu2mxf.exe " & cmbebu2mxfoption.Text & " " & """" & lblfilenamemetadata.Text & """")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        Dim cmd As String = "/K " & txtffplay.Text
        Process.Start("CMD", cmd)

    End Sub

    Private Sub cmdFFMpeg_Click(sender As Object, e As EventArgs) Handles cmdFFMpeg.Click
        On Error Resume Next
        Dim cmd As String = "/K " & txtFFMpeg.Text
        Process.Start("CMD", cmd)
    End Sub

    Private Sub cmdhide_Click(sender As Object, e As EventArgs)
        Hide()
    End Sub

    Private Sub Cmdrecord_Click(sender As Object, e As EventArgs) Handles cmdrecord.Click
        On Error Resume Next
        Dim cmd As String = "/K " & txtrecord.Text
        Process.Start("CMD", cmd)
    End Sub

    Private Sub CmdOutputToDecklink_Click(sender As Object, e As EventArgs) Handles cmdOutputToDecklink.Click
        On Error Resume Next
        Dim cmd As String = "/K " & txtOutputToDecklink.Text
        Process.Start("CMD", cmd)
    End Sub

    Private Sub Chktranscode_CheckedChanged(sender As Object, e As EventArgs) Handles chktranscode.CheckedChanged

    End Sub

    Private Sub Chkmediabackup_CheckedChanged(sender As Object, e As EventArgs) Handles chkmediabackup.CheckedChanged

    End Sub

    Private Sub CmdScreenRecorder_Click(sender As Object, e As EventArgs) Handles cmdScreenRecorderwithMicrophone.Click
        On Error Resume Next
        Dim cmdScreenRecorder As String = "/K " & txtScreenRecorderwithmicrophone.Text
        Process.Start("CMD", cmdScreenRecorder)
    End Sub

    Private Sub CmdScreenRecorderwithSystemAudio_Click(sender As Object, e As EventArgs) Handles cmdScreenRecorderwithSystemAudio.Click
        On Error Resume Next
        Dim cmdScreenRecorder As String = "/K " & txtScreenRecorderwirhSystemAudio.Text
        Process.Start("CMD", cmdScreenRecorder)
    End Sub

    Private Sub cmdopenfirstfile_Click(sender As Object, e As EventArgs) Handles cmdopenfirstfile.Click

        If ofd2.ShowDialog() = DialogResult.OK Then
            txtfirstfile.Text = Replace(ofd2.FileName, "\", "/")
        End If


    End Sub

    Private Sub cdmDesinationDirectoryyt_Click(sender As Object, e As EventArgs) Handles cdmDesinationDirectoryyt.Click
        On Error Resume Next
        Dim aa As New FolderBrowserDialog
        aa.SelectedPath = txtDesinationDirectoryyt.Text
        If aa.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtDesinationDirectoryyt.Text = Replace(aa.SelectedPath, "\", "/") & "/"
        End If
    End Sub

    Private Sub cmdDownloadyoutubeVideo_Click(sender As Object, e As EventArgs) Handles cmdDownloadyoutubeVideo.Click
        Dim commandyt As String = "/K c:/casparcg/mydata/ffmpeg/youtube-dl.exe -o " & """" & txtDesinationDirectoryyt.Text & "/%(title)s.%(ext)s" & """" & " " & txtYTurl.Text
        Process.Start("CMD", commandyt)

    End Sub

    Sub defaultmetadata()
        On Error Resume Next
        Using sr As StreamReader = New StreamReader("c:/casparcg/mydata/ebumxf/metadata.txt")
            dgvmetadata.Rows.Clear()
            'Loop through and add list to the file.
            Dim g As Integer = 0
            Dim li As String
            Do Until sr.EndOfStream = True
                li = sr.ReadLine()
                dgvmetadata.Rows.Add()
                dgvmetadata.Rows(g).Cells(0).Value = li
                dgvmetadata.Rows(g).Cells(1).Value = "Vimlesh " & li
                g = g + 1
            Loop
        End Using

    End Sub

    Private Sub cmddefaultmetadata_Click(sender As Object, e As EventArgs) Handles cmddefaultmetadata.Click
        defaultmetadata()
    End Sub

    Private Sub txtDestinationDirectoryProxy_TextChanged(sender As Object, e As EventArgs) Handles txtDestinationDirectoryProxy.TextChanged

    End Sub
End Class