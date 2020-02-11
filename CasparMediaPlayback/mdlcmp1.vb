Imports System.IO
Imports System.Net.Sockets
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports MediaInfoLib
Imports Svt.Caspar

Module mdlcmp1
    Public multimodulechek As Boolean = False
    Public filenamewithoutextensioncheck As Boolean = True
    Public fps As Double = 25.0

    Public modulestartpoint As New Point(0, 60)
    Public modulesize As New Size(1228, 957)
    Public modulegbsize As New Size(1220, 950)

    Public casparwindowstartpoint As New Point(1230, 55) ' Public casparwindowstartpoint As New Point(680, 60)

    Public casparwindowssize As New Size(692, 620)

    Public client As TcpClient
    Public NetStream As NetworkStream

    Public osd2 As New SaveFileDialog

    Public ofd2 As New OpenFileDialog

    Public ofd1 As New OpenFileDialog

    Public picofd As New OpenFileDialog
    Public cd1 As New ColorDialog
    Public tempRow As DataGridViewRow

    Public CasparCGDataCollection As New CasparCGDataCollection
    Public WithEvents CasparDevice As New Svt.Caspar.CasparDevice

    Public g_int_ChannelNumber As Integer = 1
    Public g_int_PlaylistLayer As Integer = 1

    Public mediafullpath As String = "c:/casparcg/_media\"
    Public masterfilename As String

    'for subclip
    Public clipseek As Integer
    Public cliplength As Integer
    Public currrow As Integer
    'for template

    Public templatepath As String = "c:/casparcg\"
    Public templatefullpath As String = "c:/casparcg\"

    Public iclippauseresume As Integer = 1
    Public seconndchannelloopvideoname As String

    'Declaring some constants to use with the SendMessage API
    Public Const WM_SYSCOMMAND As Integer = 274
    Public Const SC_MAXIMIZE As Integer = 61488

    Public parentedProcess2 As Process 'for power point

    Public iaddimage As Integer = 1

    ' Dim tempRow As DataGridViewRow
    Public timeinterval As Int64
    Public clipsleftduration As Double
    Public dropedclipsleftduration As Integer  'Dim dropedclipsleftduration As Double
    Public mediapath As String = "c:/casparcg/_media\"

    Public thumbnailspath As String = "c:/casparcg/_thumbnails\"
    Public thumbnailsfullpath As String = "c:/casparcg/_thumbnails\"

    Public initialpath As String = "D:\CasparCG Server 2.0.7\Server"

    Public logpath As String = ""
    Public datapath As String = ""
    Public fontpath As String = "c:/windows/fonts"

    Public formname As String

    Public islowmotion As Integer

    Public ChannelName As String

    Public deinterlaced As String = " filter yadif=1:0"
    Public g_int_NumberOfChannels As Integer
    Public m_PerformanceCounter As New System.Diagnostics.PerformanceCounter("Processor", "% Processor Time", "_Total") ' for cup uses
    Public ServerVersion As Double
    Public lastlayout As String = "C:/casparcg/mydata/layouts/lastlayout.xml"

    'for composition------------------------------------------------------------------
    Public fillstring As String
    Public intElements As Integer = 1
    Public params As String() = {"input-repeat=65535"}
    Public elementmove As Boolean
    Public ndi1 As String

    Public xx As Integer = 0
    Public yy As Integer = 0

    ' for osc
    Public audiovalue1 As Double
    Public audiovalue2 As Double
    Public framesPlayed As Integer
    Public framesTotal As Integer
    Public playingfilename As String
    'for osc end

    'for composition end---------------------------------------------------------
    Public Function fillcommand(aaa As Control) As String()

        On Error Resume Next
        Dim ss = aaa.Parent
        Dim x As Double = (aaa.Left) / Form1.Panel1.Width
        Dim y As Double = aaa.Top / Form1.Panel1.Height
        Dim xx As Double = aaa.Size.Width / Form1.Panel1.Width
        Dim yy As Double = aaa.Size.Height / Form1.Panel1.Height
        fillstring = x & " " & y & " " & xx & " " & yy
        Return {fillstring, x, y, xx, yy}
    End Function
    Public Function fillcommandCaption(aaa As Control) As String()

        On Error Resume Next
        Dim ss = aaa.Parent
        Dim x As Double = ((aaa.Left) + (ss.Left)) / Form1.Panel1.Width
        Dim y As Double = ((aaa.Top) + (ss.Top)) / Form1.Panel1.Height
        Dim xx As Double = aaa.Size.Width / Form1.Panel1.Width
        Dim yy As Double = aaa.Size.Height / Form1.Panel1.Height
        fillstring = x & " " & y & " " & xx & " " & yy
        Return {fillstring, x, y, xx, yy}
    End Function

    Public Sub Changebackcolor(oBackColor As Object)
        Dim cc As New ColorDialog
        If cc.ShowDialog = DialogResult.OK Then
            oBackColor.BackColor = cc.Color
        End If
    End Sub
    Public Function ValuetodBFS(value As Int32) As Double
        Try
            If value <> 0 Then
                Return 20 * (Math.Log10(value / Int32.MaxValue))
            Else Return -35
            End If
        Catch ex As Exception
            Return -35
        End Try

    End Function

    Public Function CntrlExistsIn(ctrlName As String, parent As Control) As Boolean
        Dim bResult As Boolean = False
        For Each elem As Control In parent.Controls
            If elem.Name = ctrlName Then
                bResult = True
                Exit For
            End If
        Next
        Return bResult
    End Function

    Public Sub playinvlc(filename As String)
        On Error Resume Next
        Dim PlayerPath As String = ""
        If System.IO.File.Exists("C:\Program Files\VideoLAN\VLC\vlc.exe") Then
            PlayerPath = "C:\Program Files\VideoLAN\VLC\vlc.exe"
        ElseIf System.IO.File.Exists("C:\Program Files (x86)\VideoLAN\VLC\vlc.exe") Then
            PlayerPath = "C:\Program Files (x86)\VideoLAN\VLC\vlc.exe"
        Else
            PlayerPath = "C:\casparcg\mydata\vlc\vlc-2.2.1-win32\vlc-2.2.1\vlc.exe"
        End If
        Dim process As Process = New Process
        process.StartInfo.FileName = PlayerPath
        process.StartInfo.Verb = "open"
        If System.IO.Path.GetExtension(filename) = ".txt" Then
            readsubclip(filename)
            process.StartInfo.Arguments = """" & Replace(mediafullpath & masterfilename, "/", "\") & """"
        Else
            process.StartInfo.Arguments = """" & Replace(filename, "/", "\") & """"
        End If
        process.Start()
    End Sub
    Public Sub playinffplay(filename As String)
        On Error Resume Next
        Dim PlayerPath As String = ""
        PlayerPath = "C:\casparcg\mydata\ffmpeg\ffplay.exe"
        Dim process As Process = New Process
        process.StartInfo.FileName = PlayerPath
        process.StartInfo.Verb = "open"
        If System.IO.Path.GetExtension(filename) = ".txt" Then
            readsubclip(filename)
            process.StartInfo.Arguments = """" & Replace(mediafullpath & masterfilename, "/", "\") & """"
        Else
            process.StartInfo.Arguments = """" & Replace(filename, "/", "\") & """"
        End If
        process.Start()
    End Sub

    Public Function IntervalTill(ByVal d As DateTime) As Integer
        On Error Resume Next
        Dim TodayTickTime As DateTime = Today.Add(d.Subtract(#12:00:00 AM#))
        Dim TomorrowTickTime As DateTime = TodayTickTime.AddHours(24)
        Dim Difference As TimeSpan
        If DateTime.op_LessThan(Now, TodayTickTime) Then
            Difference = TodayTickTime.Subtract(Now)
        Else
            Difference = TomorrowTickTime.Subtract(Now)
        End If
        Return Difference.TotalMilliseconds
    End Function

    Public Sub readsubclip(subcliptextfilename As String)
        On Error Resume Next
        Using sr As StreamReader = New StreamReader(subcliptextfilename)
            Dim str As Array = Split(sr.ReadLine, Chr(2))
            masterfilename = str(0)

            clipseek = str(1)
            cliplength = str(2) - str(1)
        End Using
    End Sub
    Public Sub showfileinformation(filename As String)
        On Error Resume Next
        Dim fileinformation As New MediaInfoLib.MediaInfo
        If System.IO.Path.GetExtension(filename) = ".txt" Then
            readsubclip(filename)
            fileinformation.Open(mediafullpath & masterfilename)
        Else
            fileinformation.Open(filename)
        End If



        Dim aa As Array = Split(fileinformation.Inform, vbNewLine)

        Dim obj As New frmfileinformation
        With obj
            '.dgvfileinformation.Rows.Clear()
            For iii = 0 To aa.Length
                .dgvfileinformation.Rows.Add()
                .dgvfileinformation.Rows(iii).Cells(0).Value = Split(aa(iii), ":")(0)
                .dgvfileinformation.Rows(iii).Cells(1).Value = aa(iii).ToString.Substring(.dgvfileinformation.Rows(iii).Cells(0).Value.ToString.Length + 1)
            Next
            ' .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub
    Public Function FToHMSF(ByVal frame As Integer) As String
        On Error Resume Next
        Dim ts As TimeSpan
        Dim totHrs As Integer
        Dim H, M, S, F, HMSF As String
        '
        ts = TimeSpan.FromSeconds(frame / fps)

        '
        totHrs = Math.Truncate(ts.TotalHours) 'strip away decimal points
        H = Format(totHrs, "0#") & ":"
        M = Format(ts.Minutes, "0#") & ":"
        S = Format(ts.Seconds, "0#") & ":"
        F = Format((ts.Milliseconds) * fps / 1000, "0#")

        HMSF = H & M & S & F
        '
        Return HMSF

    End Function
    Public Function FToHMS(ByVal frame As Integer) As String
        On Error Resume Next
        Dim ts As TimeSpan
        Dim totHrs As Integer
        Dim H, M, S, HMS As String
        '
        ts = TimeSpan.FromSeconds(frame / fps)

        '
        totHrs = Math.Truncate(ts.TotalHours) 'strip away decimal points
        H = Format(totHrs, "0#") & ":"
        M = Format(ts.Minutes, "0#") & ":"
        S = Format(ts.Seconds, "0#")
        'F = Format((ts.Milliseconds) * fps / 1000, "0#")

        HMS = H & M & S
        '
        Return HMS

    End Function
    Public Function HMSFtoF(ByVal HMSF As String) As Integer
        On Error Resume Next
        Dim F As Integer
        F = (Val(Mid(HMSF, 1, 2)) * fps * 60 * 60 + Val(Mid(HMSF, 4, 2)) * fps * 60 + Val(Mid(HMSF, 7, 2)) * fps + Val(Mid(HMSF, 10, 2))).ToString
        Return F
    End Function
    Public Function HMStoF(ByVal HMS As String) As Integer
        On Error Resume Next
        Dim F As Integer
        F = (Val(Mid(HMS, 1, 2)) * fps * 60 * 60 + Val(Mid(HMS, 4, 2)) * fps * 60 + Val(Mid(HMS, 7, 2)) * fps)
        Return F
    End Function
    Function mstohms(ms As Integer) As String
        Return (TimeSpan.FromMilliseconds(ms)).ToString("hh\:mm\:ss")
    End Function

    'This is used when response in needed.
    Sub SendString(ByVal Stream As NetworkStream, ByVal Data As String)
        On Error Resume Next
        Dim Bytes As [Byte]() = Encoding.UTF8.GetBytes(Data)
        If Stream.CanTimeout Then
            Stream.WriteTimeout = 1000 * 5
        End If
        Stream.Write(Bytes, 0, Bytes.Length)
        Return
    End Sub

    Function ModifyFilename(FilenameWithExtension As String) As String
        On Error Resume Next

        If FilenameWithExtension.IndexOf("://") <> -1 Then
            Return FilenameWithExtension
            Exit Function
        End If

        If filenamewithoutextensioncheck = True Then
            Dim fileExtPos As Integer = FilenameWithExtension.LastIndexOf(".")
            If (fileExtPos >= 0) Then
                Return FilenameWithExtension.Substring(0, fileExtPos)
            Else
                Return FilenameWithExtension
            End If
        Else
            Return FilenameWithExtension
        End If
    End Function
    Function getdurationofclip(clipfullname As String) As String
        On Error Resume Next
        Dim durationofclip As String

        If System.IO.Path.GetExtension(clipfullname) = ".txt" Then
            Using sr As StreamReader = New StreamReader(clipfullname)
                Dim str As Array = Split(sr.ReadLine, Chr(2))
                durationofclip = mstohms(((str(2) - str(1)) * 1000) / fps)
            End Using
        Else
            Dim clipfullnameduration As New MediaInfoLib.MediaInfo
            clipfullnameduration.Open(clipfullname)

            durationofclip = Mid(clipfullnameduration.Get(StreamKind.Video, 0, "Duration/String3"), 1, 8)
        End If

        Return durationofclip
    End Function
    Async Function getdurationofclipAsync(clipfullname As String) As Task(Of String)
        'On Error Resume Next
        Dim durationofclip As String
        Await Task.Run(Sub()
                           If System.IO.Path.GetExtension(clipfullname) = ".txt" Then
                               Using sr As StreamReader = New StreamReader(clipfullname)
                                   Dim str As Array = Split(sr.ReadLine, Chr(2))
                                   durationofclip = mstohms(((str(2) - str(1)) * 1000) / fps)
                               End Using
                           Else
                               Dim clipfullnameduration As New MediaInfoLib.MediaInfo
                               clipfullnameduration.Open(clipfullname)

                               durationofclip = Mid(clipfullnameduration.Get(StreamKind.Video, 0, "Duration/String3"), 1, 8)
                           End If
                       End Sub)
        Return durationofclip
    End Function

    Function getallvaules(clipfullname As String) As String
        On Error Resume Next
        Dim durationofclip As String
        Dim size As String

        If System.IO.Path.GetExtension(clipfullname) = ".txt" Then
            Using sr As StreamReader = New StreamReader(clipfullname)
                Dim str As Array = Split(sr.ReadLine, Chr(2))
                durationofclip = mstohms(((str(2) - str(1)) * 1000) / fps)
            End Using
        Else
            Dim clipfullnameduration As New MediaInfoLib.MediaInfo
            clipfullnameduration.Open(clipfullname)

            durationofclip = Mid(clipfullnameduration.Get(StreamKind.Video, 0, "Duration/String3"), 1, 8)

            If durationofclip <> "" Then
                size = Mid(clipfullnameduration.Get(StreamKind.Video, 0, "Width"), 1, 8) & "x" & Mid(clipfullnameduration.Get(StreamKind.Video, 0, "Height"), 1, 8)
            Else
                size = Mid(clipfullnameduration.Get(StreamKind.Image, 0, "Width"), 1, 8) & "x" & Mid(clipfullnameduration.Get(StreamKind.Image, 0, "Height"), 1, 8)
            End If

        End If
        Dim allvalues As String = durationofclip & Chr(2) & size
        Return allvalues
    End Function


    Public Async Function getallvaluesAsync(ByVal filename As String) As Task(Of String)
        Dim allvalues As String
        Await Task.Run(Sub()
                           Dim size As String
                           Dim clipfullnameduration As New MediaInfoLib.MediaInfo
                           clipfullnameduration.Open(filename)
                           Dim durationofclip As String = ""
                           durationofclip = Mid(clipfullnameduration.Get(StreamKind.Video, 0, "Duration/String3"), 1, 8)
                           If durationofclip <> "" Then
                               size = Mid(clipfullnameduration.Get(StreamKind.Video, 0, "Width"), 1, 8) & "x" & Mid(clipfullnameduration.Get(StreamKind.Video, 0, "Height"), 1, 8)
                           Else
                               size = Mid(clipfullnameduration.Get(StreamKind.Image, 0, "Width"), 1, 8) & "x" & Mid(clipfullnameduration.Get(StreamKind.Image, 0, "Height"), 1, 8)
                           End If
                           allvalues = durationofclip & Chr(2) & size
                       End Sub)
        Return allvalues
    End Function


    Public Sub ReadTextFile(ByVal sFileName As String, ByVal ttt As TextBox)
        On Error Resume Next
        Dim sLineData As String = ""
        Dim objTextReader As System.IO.TextReader
        objTextReader = New StreamReader(sFileName)
        sLineData = objTextReader.ReadToEnd
        ttt.Text = sLineData
        objTextReader.Close()
    End Sub
    Public Function FToHMSms(ByVal frame As Integer) As String 'microsecond
        On Error Resume Next
        Dim ts As TimeSpan
        Dim totHrs As Integer
        Dim H, M, S, ms, HMSms As String
        ts = TimeSpan.FromSeconds(frame / 25)
        totHrs = Math.Truncate(ts.TotalHours) 'strip away decimal points
        H = Format(totHrs, "0#") & ":"
        M = Format(ts.Minutes, "0#") & ":"
        S = Format(ts.Seconds, "0#") & "."
        ms = Format((ts.Milliseconds * 1000), "00000#")
        HMSms = H & M & S & ms     '
        Return HMSms
    End Function

    'This is the API that does all the hard work
    <Runtime.InteropServices.DllImport("user32.dll")>
    Function SetParent(ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    End Function

    'This is the API used to maximize the window
    <Runtime.InteropServices.DllImport("user32.dll")>
    Public Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    'This is the process that is currently set as a child to the form
    Public parentedProcess As Process

    Sub SetProcessParent(ByVal processName As String, ByVal cmb As ComboBox, ByVal pnl As Panel)
        On Error Resume Next
        'Retrieve an array of running processes with the given name
        Dim processes() As Process = Process.GetProcessesByName(processName)
        Dim iprocess As Integer

        If Not parentedProcess Is Nothing Then
            SetParent(parentedProcess.MainWindowHandle, Nothing)
        End If
        For iprocess = 0 To processes.GetUpperBound(0)
            If processes(iprocess).MainWindowTitle = cmb.Text Then Exit For
        Next

        parentedProcess = processes(iprocess)
        SetParent(parentedProcess.MainWindowHandle, pnl.Handle)
        SendMessage(parentedProcess.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)

    End Sub
    Sub delete(ByVal dgv As DataGridView)
        On Error Resume Next
        With dgv
            .Rows.RemoveAt(.CurrentRow.Index)
        End With
    End Sub
    Sub openlogoandcountryfullname(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal txt As TextBox)
        On Error Resume Next
        Dim aa As New OpenFileDialog
        aa.InitialDirectory = "c:\casparcg\mydata\flag\"
        If aa.ShowDialog = Windows.Forms.DialogResult.OK Then
            sender.ImageLocation = aa.FileName
            txt.Text = UCase(Split(aa.SafeFileName, ".")(0))
            aa.Dispose()
        End If
    End Sub
    Sub insert(ByVal dgv As DataGridView)
        On Error Resume Next
        With dgv
            .Rows.Insert(.CurrentRow.Index)
        End With
    End Sub

    Sub down(ByVal dgv As DataGridView)
        On Error Resume Next
        If dgv.CurrentCell.RowIndex <> dgv.Rows.Count - 2 Then
            Dim curRow As Integer = dgv.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = dgv.CurrentRow
            dgv.Rows.Remove(myRow)
            dgv.Rows.Insert(curRow + 1, myRow)
            dgv.CurrentCell = dgv.Rows(curRow + 1).Cells(0)
        End If
    End Sub
    Sub up(ByVal dgv As DataGridView)
        On Error Resume Next
        If dgv.CurrentCell.RowIndex <> 0 Then
            Dim curRow As Integer = dgv.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = dgv.CurrentRow
            dgv.Rows.Remove(myRow)
            dgv.Rows.Insert(curRow - 1, myRow)
            dgv.CurrentCell = dgv.Rows(curRow - 1).Cells(0)
        End If
    End Sub
    Sub opendata(ByVal initialdirectory As String, ByVal dgvname As DataGridView, ByVal headername As ComboBox, ByVal subheadername As ComboBox, ByVal lblfilename As Label)
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog

        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = initialdirectory
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)
                'clear list
                dgvname.Rows.Clear()
                'Loop through and add list to the file.
                Dim g As Integer = 0
                Dim li As String = ""

                li = sr.ReadLine()
                headername.Text = Split(li, ",")(0)
                subheadername.Text = Split(li, ",")(1)

                li = ""
                li = sr.ReadLine()
                For i = 0 To dgvname.ColumnCount - 1
                    dgvname.Columns(i).HeaderText = Split(li, ",")(i)
                Next

                li = ""
                Do Until sr.EndOfStream
                    li = sr.ReadLine()
                    dgvname.Rows.Add()
                    Dim xyz As Array = Split(li, ",")
                    For k = 0 To dgvname.ColumnCount - 1
                        dgvname.Rows(g).Cells(k).Value = xyz(k) 'CType(xyz(0), Integer)
                    Next
                    g = g + 1
                Loop
                sr.Close()
            End Using
            lblfilename.Text = ofd2.FileName
        End If
    End Sub
    Sub savedata(ByVal initialdirectory As String, ByVal dgvname As DataGridView, ByVal headername As ComboBox, ByVal subheadername As ComboBox, ByVal lblfilename As Label)
        On Error Resume Next
        Dim osd2 As New SaveFileDialog
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = initialdirectory
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvname.Rows.Count = 0 Then
                    sw.Write("")
                Else
                    'write header and subheader
                    sw.WriteLine(headername.Text & "," & subheadername.Text)

                    'write headers of datagrid
                    Dim header1 As String = ""
                    For i = 0 To dgvname.ColumnCount - 1
                        header1 = header1 & dgvname.Columns(i).HeaderText & ","
                    Next
                    sw.WriteLine(header1)

                    'Loop through and add list to the file.
                    Dim f As Integer = 0
                    Do Until f = dgvname.Rows.Count
                        Dim str As String = ""
                        For k = 0 To dgvname.ColumnCount - 1
                            str = str & dgvname.Rows(f).Cells(k).Value & ","
                        Next
                        sw.WriteLine(str)
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            lblfilename.Text = osd2.FileName
        End If
    End Sub
    Sub newdata(ByVal dgvname As DataGridView, ByVal headername As ComboBox, ByVal subheadername As ComboBox, ByVal lblfilename As Label)
        On Error Resume Next
        dgvname.Rows.Clear()
        headername.Text = ""
        subheadername.Text = ""
        lblfilename.Text = "New"
    End Sub

    Sub newdatasg(ByVal dgvname As DataGridView, ByVal headername As ComboBox, ByVal subheadername As ComboBox, ByVal lblfilename As Label)
        On Error Resume Next
        dgvname.Rows.Clear()
        'headername.Text = ""
        subheadername.Text = ""
        lblfilename.Text = "New"


        With dgvname
            .Rows.Add(8)
            For ii = 0 To 7
                .Rows(ii).Cells(0).Value = ii + 1
                .Rows(ii).Cells(2).Value = "BLK"
            Next
        End With
    End Sub
    Sub bestvaluesg(dgv As DataGridView, startcoulumnnumber As Integer, bestvaluecolumnnumber As Integer)
        On Error Resume Next
        Dim aa(6) As Decimal
        With dgv
            For ii = 0 To .RowCount - 1
                For jj = startcoulumnnumber To startcoulumnnumber + 5

                    If .Rows(ii).Cells(jj).Value() = "x" Or .Rows(ii).Cells(jj).Value() = "X" Then
                        aa(jj - startcoulumnnumber) = 0
                    Else
                        aa(jj - startcoulumnnumber) = .Rows(ii).Cells(jj).Value
                    End If

                Next
                .Rows(ii).Cells(bestvaluecolumnnumber).Value = aa.Max

                ReDim aa(6)
            Next
        End With
    End Sub
    Sub deletesg(ByVal dgv As DataGridView)
        On Error Resume Next
        With dgv
            .Rows.RemoveAt(.CurrentRow.Index)
        End With
    End Sub

    Sub openlogoandcountryfullnamesg(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal txt As TextBox)
        On Error Resume Next
        Dim aa As New OpenFileDialog
        aa.InitialDirectory = "c:\casparcg\mydata\games2\country\withname\"
        If aa.ShowDialog = Windows.Forms.DialogResult.OK Then
            sender.ImageLocation = aa.FileName
            txt.Text = UCase(Split(aa.SafeFileName, ".")(0))
            aa.Dispose()
        End If
    End Sub

    Sub insertsg(ByVal dgv As DataGridView)
        On Error Resume Next
        With dgv
            .Rows.Insert(.CurrentRow.Index)
        End With
    End Sub

    Sub downsg(ByVal dgv As DataGridView)
        On Error Resume Next
        If dgv.CurrentCell.RowIndex <> dgv.Rows.Count - 2 Then
            Dim curRow As Integer = dgv.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = dgv.CurrentRow
            dgv.Rows.Remove(myRow)
            dgv.Rows.Insert(curRow + 1, myRow)
            dgv.CurrentCell = dgv.Rows(curRow + 1).Cells(0)
        End If
    End Sub
    Sub upsg(ByVal dgv As DataGridView)
        On Error Resume Next
        If dgv.CurrentCell.RowIndex <> 0 Then
            Dim curRow As Integer = dgv.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = dgv.CurrentRow
            dgv.Rows.Remove(myRow)
            dgv.Rows.Insert(curRow - 1, myRow)
            dgv.CurrentCell = dgv.Rows(curRow - 1).Cells(0)
        End If
    End Sub

    Sub opendatasg(ByVal initialdirectory As String, ByVal dgvname As DataGridView, ByVal headername As ComboBox, ByVal subheadername As ComboBox, ByVal lblfilename As Label)
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog

        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = initialdirectory
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then

            Using sr As StreamReader = New StreamReader(ofd2.FileName)
                'clear list
                dgvname.Rows.Clear()
                'Loop through and add list to the file.
                Dim g As Integer = 0
                Dim li As String = ""

                li = sr.ReadLine()
                headername.Text = Split(li, ",")(0)
                subheadername.Text = Split(li, ",")(1)

                li = ""
                li = sr.ReadLine()
                For i = 0 To dgvname.ColumnCount - 1
                    dgvname.Columns(i).HeaderText = Split(li, ",")(i)
                Next

                li = ""
                Do Until sr.EndOfStream
                    li = sr.ReadLine()
                    dgvname.Rows.Add()
                    Dim xyz As Array = Split(li, ",")
                    For k = 0 To dgvname.ColumnCount - 1

                        dgvname.Rows(g).Cells(k).Value = xyz(k) 'CType(xyz(0), Integer)

                    Next
                    g = g + 1
                Loop
                sr.Close()
            End Using
            lblfilename.Text = ofd2.FileName
        End If
    End Sub
    Sub savedatasg(ByVal initialdirectory As String, ByVal dgvname As DataGridView, ByVal headername As ComboBox, ByVal subheadername As ComboBox, ByVal lblfilename As Label)
        On Error Resume Next

        Dim osd2 As New SaveFileDialog
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = initialdirectory
        osd2.FileName = "001_" & ucSG2016.cmbHeader.Text & "_" & ucSG2016.cmbSubHeader.Text
        If File.Exists(lblfilename.Text) = True Then
            osd2.FileName = lblfilename.Text
            GoTo 20
        End If
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
20:
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvname.Rows.Count = 0 Then
                    sw.Write("")
                Else
                    'write header and subheader
                    sw.WriteLine(headername.Text & "," & subheadername.Text)

                    'write headers of datagrid
                    Dim header1 As String = ""
                    For i = 0 To dgvname.ColumnCount - 1
                        header1 = header1 & dgvname.Columns(i).HeaderText & ","
                    Next
                    sw.WriteLine(header1)

                    'Loop through and add list to the file.
                    Dim f As Integer = 0
                    Do Until f = dgvname.Rows.Count
                        Dim str As String = ""
                        For k = 0 To dgvname.ColumnCount - 1
                            str = str & dgvname.Rows(f).Cells(k).Value & ","
                        Next
                        sw.WriteLine(str)
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            lblfilename.Text = osd2.FileName
        End If
    End Sub

    Public Sub MakeMenuDropDownWhenParrented(ByVal sender As Object)
        'Dim m As New ToolStripMenuItem
        'm = CType(sender, ToolStripMenuItem)
        'm.ShowDropDown()

        sender.Focus()
        SendKeys.Send("{DOWN}")
    End Sub
    Public Function replacestring1(str As String) As String

        'str = Replace(str, " ", "&nbsp") ' numeric method doen't produce multiple sapce.
        str = Replace(str, " ", "&#8194;")
        str = Replace(str, "'", "&#39;") '&apos not working
        str = Replace(str, """", "&#34;")
        str = Replace(str, "<", "&#60;")
        str = Replace(str, "\", "&#92;")
        str = Replace(str, vbCr, "<br/>")
        str = Replace(str, vbLf, "<br/>")
        str = Replace(str, vbCrLf, "<br/>") ' shuld be placed last so that it is not replaced.
        Return str
    End Function
    Function GetProcessMemory(processname As String) As String
        On Error Resume Next
        Return Int(FormatNumber((Process.GetProcessesByName(processname)(0).WorkingSet64 / 1024) / 1024)) & "MB"
    End Function

    Function IsValidImage(filename As String) As Boolean
        Try
            Dim img As System.Drawing.Image = System.Drawing.Image.FromFile(filename)
        Catch generatedExceptionName As OutOfMemoryException
            Return False
        End Try
        Return True
    End Function
    Function stringtopoint(myString As String) As Point
        Dim g = Regex.Replace(myString, "[\{\}a-zA-Z=]", "").Split(","c)
        Dim pointResult As Point = New Point(Integer.Parse(g(0)), Integer.Parse(g(1)))
        Return pointResult
    End Function
End Module
