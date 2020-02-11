Imports System.IO
Public Class Form1
    Dim savefilename As String = "C:\casparcg\mydata\composition\test1.txt"
    Public Structure ElementInfo
        Public Property Type1 As String
        Public Property url1 As String
        Public Property url2 As String
        Public Property Width As Integer
        Public Property Height As Integer
        Public Property Note As String
    End Structure
    Public ElementInfo1 As New ElementInfo
    Private Sub cmdAddMedia_Click(sender As Object, e As EventArgs) Handles cmdAddMedia.Click
        On Error Resume Next
        intElements = intElements + 1

        Dim media As New ucElement
        media.Name = "media" & intElements
        Dim rs2 = New clsResizeableControlnew(media)
        media.Label1.Text = intElements

        ElementInfo1.Type1 = "file"
        ElementInfo1.url1 = "c:/casparcg/_media/kabhi_kabhi.mp4"
        ElementInfo1.url2 = ""
        media.Tag = ElementInfo1.Type1 & Chr(3) & ElementInfo1.url1 & Chr(3) & ElementInfo1.url2

        UcMixernew1.cmbvideolayerformixer.Text = media.Label1.Text

        Dim xpoint As Integer = (media.Width) * xx
        Dim ypoint As Integer = (media.Height) * yy
        media.Location = New Point(xpoint, ypoint)
        If xpoint < (Panel1.Width - media.Width) Then
            xx = xx + 1
        Else
            xx = 0
            yy = yy + 1
        End If
        If intElements = 10 Then
            xx = 0
            yy = 0
        End If
        Panel1.Controls.Add(media)

        media.VlcControl1.Play(New Uri("c:/casparcg/_media/kabhi_kabhi.mp4"), params)
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & media.Label1.Text & " " & """" & Replace(Replace(Split(media.VlcControl1.VlcMediaPlayer.GetMedia.Mrl, "///")(1), ":/", "://"), "%20", " ") & """" & " loop")
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & media.Label1.Text & " fill " & fillcommand(media)(0))

        media.BringToFront()

    End Sub

    Private Sub cmdClearChannel_Click(sender As Object, e As EventArgs) Handles cmdClearChannel.Click
        On Error Resume Next
        CasparDevice.SendString("clear " & g_int_ChannelNumber)
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & " clear")
        Dim cControl As List(Of Control) = New List(Of Control)()
        For Each cControl1 As Control In Panel1.Controls
            If (TypeOf cControl1 Is ucElement) Then
                cControl.Add(cControl1)
            End If
        Next
        For Each cControl2 As Control In cControl
            cControl2.Dispose()
        Next
        intElements = 1
        xx = 0
        yy = 0
    End Sub
    Private Sub cmdPlayAllfromBegining_Click(sender As Object, e As EventArgs) Handles cmdPlayAllfromBegining.Click
        On Error Resume Next
        Dim cControl As Control
        For Each cControl In Me.Panel1.Controls
            If (TypeOf cControl Is ucElement) Then
                Dim tb As ucElement = CType(cControl, ucElement)
                tb.VlcControl1.Time = 0
                tb.VlcControl1.Play()
                If tb.VlcControl1.Tag <> "" Then
                    CasparDevice.SendString("Call " & g_int_ChannelNumber & "-" & tb.Label1.Text & " player.loadVideoById('" & tb.VlcControl1.Tag & "')")
                Else
                    CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & tb.Label1.Text & " " & """" & Replace(Replace(Split(tb.VlcControl1.VlcMediaPlayer.GetMedia.Mrl, "///")(1), ":/", "://"), "%20", " ") & """" & " loop")
                End If
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & tb.Label1.Text & " fill " & fillcommand(tb)(0))
            End If
        Next cControl
    End Sub
    Private Sub cmdPauseAll_Click(sender As Object, e As EventArgs) Handles cmdPauseAll.Click
        On Error Resume Next
        Dim cControl As Control
        For Each cControl In Me.Panel1.Controls
            If (TypeOf cControl Is ucElement) Then
                Dim tb As ucElement = CType(cControl, ucElement)
                tb.VlcControl1.Pause()
                If tb.VlcControl1.Tag <> "" Then
                    CasparDevice.SendString("Call " & g_int_ChannelNumber & "-" & tb.Label1.Text & " player.pauseVideo()")
                Else
                    CasparDevice.SendString("pause " & g_int_ChannelNumber & "-" & tb.Label1.Text)
                End If
            End If
        Next cControl
    End Sub
    Private Sub CmdResumeAll_Click(sender As Object, e As EventArgs) Handles cmdResumeAll.Click
        On Error Resume Next
        Dim cControl As Control
        For Each cControl In Me.Panel1.Controls
            If (TypeOf cControl Is ucElement) Then
                Dim tb As ucElement = CType(cControl, ucElement)
                tb.VlcControl1.Play()
                If tb.VlcControl1.Tag <> "" Then
                    CasparDevice.SendString("Call " & g_int_ChannelNumber & "-" & tb.Label1.Text & " player.playVideo()")
                Else
                    CasparDevice.SendString("resume " & g_int_ChannelNumber & "-" & tb.Label1.Text)
                End If
            End If
        Next cControl
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CmdAddDummyMedia_Click(sender As Object, e As EventArgs) Handles cmdAddDummyMedia.Click
        On Error Resume Next
        intElements = intElements + 1
        Dim media As New ucElement
        media.Name = "media" & intElements
        Dim rs2 = New clsResizeableControlnew(media)
        media.Label1.Text = InputBox("Input layer Number", "", "96").ToString 'intElements

        UcMixernew1.cmbvideolayerformixer.Text = media.Label1.Text

        ElementInfo1.Type1 = "empty1"
        ElementInfo1.url1 = "empty1"
        ElementInfo1.url2 = ""
        media.Tag = ElementInfo1.Type1 & Chr(3) & ElementInfo1.url1 & Chr(3) & ElementInfo1.url2

        Dim xpoint As Integer = (media.Width) * xx
        Dim ypoint As Integer = (media.Height) * yy
        media.Location = New Point(xpoint, ypoint)
        If xpoint < (Panel1.Width - media.Width) Then
            xx = xx + 1
        Else
            xx = 0
            yy = yy + 1
        End If
        If intElements = 10 Then
            xx = 0
            yy = 0
        End If
        Panel1.Controls.Add(media)
        media.VlcControl1.Play(New Uri("C:/casparcg/mydata/games/event logo/BLK.png"), params)
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & media.Label1.Text & " fill " & fillcommand(media)(0))

        media.BringToFront()
    End Sub

    Private Sub CmdSaveFile_Click(sender As Object, e As EventArgs) Handles cmdSaveFile.Click
        On Error Resume Next
        Dim sw As StreamWriter = New StreamWriter(savefilename)
        'Dim sw As StreamWriter = New StreamWriter("c:/casparcg/mydata/composition/test1.txt")
        For Each cControl1 As Control In Panel1.Controls
            'If (TypeOf cControl1 Is ucElement) Then
            Dim tb As ucElement = CType(cControl1, ucElement)
            sw.WriteLine(tb.Name & Chr(2) & tb.Label1.Text & Chr(2) & tb.Tag & Chr(2) & tb.Location.ToString & Chr(2) & tb.Size.ToString & Chr(2) & tb.VlcControl1.VlcMediaPlayer.GetMedia.Mrl)
            'End If
            For Each cControl2 As Control In tb.Controls
                If (TypeOf cControl2 Is UcCaption) Then
                    Dim tb1 As UcCaption = CType(cControl2, UcCaption)
                    sw.WriteLine(tb1.Name & Chr(2) & tb1.Label1.Text & Chr(2) & tb1.Tag & Chr(2) & tb1.Location.ToString & Chr(2) & tb1.Size.ToString & Chr(2) & "file:///c:/casparcg/CMP/Composition/SourceName/gwd_preview_SourceName/index.html")
                End If
            Next
        Next
        sw.Close()
    End Sub

    Private Sub CmdOpenFile_Click(sender As Object, e As EventArgs) Handles cmdOpenFile.Click
        'On Error Resume Next
        Dim aa As New OpenFileDialog
        aa.InitialDirectory = "C:\casparcg\mydata\composition"
        aa.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*"
        If aa.ShowDialog = DialogResult.OK Then
            savefilename = aa.FileName
            lblFileName.Text = savefilename
        Else
            Exit Sub
        End If
        cmdClearChannel.PerformClick()

        Dim sr As StreamReader = New StreamReader(savefilename)
        Dim li As String
        Dim g As Integer = 0
        intElements = 0
        Do Until sr.EndOfStream = True
            g = g + 1
            li = sr.ReadLine()
            Dim xyz As Array = Split(li, Chr(2))

            If xyz(1) > intElements Then
                intElements = xyz(1)
            End If

            ElementInfo1.Type1 = Split(xyz(2), Chr(3))(0)
            ElementInfo1.url1 = Split(xyz(2), Chr(3))(1)
            ElementInfo1.url2 = Split(xyz(2), Chr(3))(2)

            Dim media ' As New ucElement

            If ElementInfo1.Type1 = "caption" Then
                media = New UcCaption
                Panel1.Controls(ElementInfo1.url2).Controls.Add(media)
                media.label2.text = ElementInfo1.url1
                media.Location = New Point((Panel1.Controls(ElementInfo1.url2).Width - media.Width) / 2, (Panel1.Controls(ElementInfo1.url2).Height - media.Height))
                media.BringToFront()
            Else
                media = New ucElement
                Panel1.Controls.Add(media)
                media.Location = stringtopoint(xyz(3))
                media.VlcControl1.VlcMediaPlayer.SetMedia(New Uri(xyz(5)))
                media.VlcControl1.Play(New Uri(xyz(5)), params)
                media.SendToBack()
            End If

            media.Name = xyz(0)
            Dim rs2 = New clsResizeableControlnew(media)
            media.Label1.Text = xyz(1)
            media.Tag = xyz(2)
            media.Size = stringtopoint(xyz(4))

            If ElementInfo1.Type1 = "file" Then
                If ServerVersion > 2.1 And IsValidImage(Replace(Replace(Split(media.VlcControl1.VlcMediaPlayer.GetMedia.Mrl, "///")(1), ":/", "://"), "%20", " ")) Then
                    CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & media.Label1.Text & " [html] " & """" & Replace(Replace(Split(media.VlcControl1.VlcMediaPlayer.GetMedia.Mrl, "///")(1), ":/", "://"), "%20", " ") & """")
                Else
                    CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & media.Label1.Text & " " & """" & Replace(Replace(Split(media.VlcControl1.VlcMediaPlayer.GetMedia.Mrl, "///")(1), ":/", "://"), "%20", " ") & """" & " loop")
                End If

            ElseIf ElementInfo1.Type1 = "decklink" Then
                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & media.Label1.Text & " " & ElementInfo1.url1)

            ElseIf ElementInfo1.Type1 = "bluefish" Then
                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & media.Label1.Text & " " & ElementInfo1.url1)
            ElseIf ElementInfo1.Type1 = "empty" Then

            ElseIf ElementInfo1.Type1 = "stream" Then
                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & media.Label1.Text & " " & ElementInfo1.url1)
            ElseIf ElementInfo1.Type1 = "ndi" Then
                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & media.Label1.Text & " [ndi] " & ElementInfo1.url1)
            ElseIf ElementInfo1.Type1 = "html" Then
                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & media.Label1.Text & " [html] " & ElementInfo1.url1)
            ElseIf ElementInfo1.Type1 = "caption" Then

                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & media.Label1.Text & " [html] " & """" & "c:/casparcg/CMP/Composition/SourceName/gwd_preview_SourceName/index.html" & """")
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & media.Label1.Text & " updatestring('" & replacestring1("ccgf0") & "','" & replacestring1(media.label2.text) & "')")
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & media.Label1.Text & " fill " & fillcommandCaption(media)(0))


            ElseIf ElementInfo1.Type1 = "youtube" Then
                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & media.Label1.Text & " [HTML]  file:///C:/casparcg/mydata/youtube/youtube.html")
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & media.Label1.Text & " opacity 0")
                Threading.Thread.Sleep(1000)
                CasparDevice.SendString("Call " & g_int_ChannelNumber & "-" & media.Label1.Text & " player.loadVideoById('" & ElementInfo1.url1 & "')")
                CasparDevice.SendString("Call " & g_int_ChannelNumber & "-" & media.Label1.Text & " player.setSize('" & Split(ElementInfo1.url2, "x")(0) & "','" & Split(ElementInfo1.url2, "x")(1) & "')")
                Threading.Thread.Sleep(1000)
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & media.Label1.Text & " opacity 1")
            End If

            If ElementInfo1.Type1 = "caption" Then
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & media.Label1.Text & " fill " & fillcommandCaption(media)(0))
            Else
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & media.Label1.Text & " fill " & fillcommand(media)(0))
            End If         '
        Loop
        sr.Close()

    End Sub

    Private Sub cmdSaveFileAs_Click(sender As Object, e As EventArgs) Handles cmdSaveFileAs.Click
        Dim aa As New SaveFileDialog
        aa.InitialDirectory = "C:\casparcg\mydata\composition"
        aa.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*"
        If aa.ShowDialog = DialogResult.OK Then
            savefilename = aa.FileName
            cmdSaveFile.PerformClick()
        End If
    End Sub
End Class