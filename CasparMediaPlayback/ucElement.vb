Public Class ucElement
    Private Sub UserControl1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        On Error Resume Next
        Dim ss As New OpenFileDialog
        If ss.ShowDialog = DialogResult.OK Then

            Form1.ElementInfo1.Type1 = "file"
            Form1.ElementInfo1.url1 = ss.FileName
            Form1.ElementInfo1.url2 = ""
            Me.Tag = Form1.ElementInfo1.Type1 & Chr(3) & Form1.ElementInfo1.url1 & Chr(3) & Form1.ElementInfo1.url2
            VlcControl1.Play(New Uri(ss.FileName), params)
            If ServerVersion > 2.1 And IsValidImage(ss.FileName) Then
                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & Me.Label1.Text & " [html] " & """" & Replace(ss.FileName, "\", "/") & """")
            Else
                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & Me.Label1.Text & " " & """" & Replace(Replace(Split(VlcControl1.VlcMediaPlayer.GetMedia.Mrl, "///")(1), ":/", "://"), "%20", " ") & """" & " loop")
            End If
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & Me.Label1.Text & " fill " & fillcommand(Me)(0))
        End If
    End Sub
    Private Sub event1(sender As Object, e As EventArgs) Handles Me.LocationChanged, Me.Resize
        On Error Resume Next
        elementmove = True
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & Me.Label1.Text & " fill " & fillcommand(sender)(0))
        VlcControl1.Size = New Size(Me.Width - 20, Me.Height - 30)

        Form1.UcMixernew1.cmbvideolayerformixer.Text = Me.Label1.Text

        'Form1.UcMixernew1.nfillx.Value = fillcommand(sender)(1)
        'Form1.UcMixernew1.nfilly.Value = fillcommand(sender)(2)
        'Form1.UcMixernew1.nfillwidth.Value = fillcommand(sender)(3)
        'Form1.UcMixernew1.nfillheight.Value = fillcommand(sender)(4)
        For Each control1 As Control In Me.Controls
            If control1.Name.Contains("media") Then
                Dim gg = CType(control1, UcCaption)
                gg.event1(gg, e)
            End If
        Next
    End Sub

    Private Sub UserControl1_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        On Error Resume Next

        Form1.ElementInfo1.Type1 = "file"
        Form1.ElementInfo1.url1 = e.Data.GetData(DataFormats.FileDrop)(0)
        Form1.ElementInfo1.url2 = ""
        Me.Tag = Form1.ElementInfo1.Type1 & Chr(3) & Form1.ElementInfo1.url1 & Chr(3) & Form1.ElementInfo1.url2

        VlcControl1.Play(New Uri(e.Data.GetData(DataFormats.FileDrop)(0)), params)
        'cd.SendString("play 1-" & Me.Label1.Text)
        If ServerVersion > 2.1 And IsValidImage(e.Data.GetData(DataFormats.FileDrop)(0)) Then
            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & Me.Label1.Text & " [html] " & """" & Replace(e.Data.GetData(DataFormats.FileDrop)(0), "\", "/") & """")
        Else
            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & Me.Label1.Text & " " & """" & Replace(Replace(Split(VlcControl1.VlcMediaPlayer.GetMedia.Mrl, "///")(1), ":/", "://"), "%20", " ") & """" & " loop")
        End If
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & Me.Label1.Text & " fill " & fillcommand(Me)(0))
    End Sub
    Private Sub UserControl1_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        On Error Resume Next
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub Element_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        On Error Resume Next
        CasparDevice.SendString("clear " & g_int_ChannelNumber & "-" & Me.Label1.Text)
        Me.Dispose()
    End Sub

    Private Sub UriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UriToolStripMenuItem.Click
        On Error Resume Next
        Dim ff As String = InputBox("Change MRL", "", VlcControl1.VlcMediaPlayer.GetMedia.Mrl)
        If ff <> "" Then
            Form1.ElementInfo1.Type1 = "file"
            Form1.ElementInfo1.url1 = ff
            Form1.ElementInfo1.url2 = ""
            Me.Tag = Form1.ElementInfo1.Type1 & Chr(3) & Form1.ElementInfo1.url1 & Chr(3) & Form1.ElementInfo1.url2
            VlcControl1.Play(New Uri(ff), params)
            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & Me.Label1.Text & " " & """" & Replace(Replace(Split(VlcControl1.VlcMediaPlayer.GetMedia.Mrl, "///")(1), ":/", "://"), "%20", " ") & """" & " loop")
        End If
    End Sub

    Private Async Sub ghfgh(sender As Object, e As EventArgs) Handles Me.MouseHover
        'On Error Resume Next
        'Form1.UcMixernew1.cmbvideolayerformixer.Text = Me.Label1.Text
        'Form1.UcMixernew1.getstausofmixer()
    End Sub

    Private Sub Decklink2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Decklink2ToolStripMenuItem.Click
        On Error Resume Next
        Dim ff = InputBox("decklink card", "", "Decklink 2")
        If ff <> "" Then
            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & Me.Label1.Text & " " & ff)
            Form1.ElementInfo1.Type1 = "decklink"
            Form1.ElementInfo1.url1 = ff
            Form1.ElementInfo1.url2 = ""
            Me.Tag = Form1.ElementInfo1.Type1 & Chr(3) & Form1.ElementInfo1.url1 & Chr(3) & Form1.ElementInfo1.url2
            Me.VlcControl1.Play(New Uri("c:/casparcg/_media/decklink_card.jpg"))
        End If
    End Sub

    Private Sub BluefishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BluefishToolStripMenuItem.Click
        On Error Resume Next
        Dim ff = InputBox("bluefish card", "", "Bluefish 2")
        If ff <> "" Then
            Form1.ElementInfo1.Type1 = "bluefish"
            Form1.ElementInfo1.url1 = ff
            Form1.ElementInfo1.url2 = ""
            Me.Tag = Form1.ElementInfo1.Type1 & Chr(3) & Form1.ElementInfo1.url1 & Chr(3) & Form1.ElementInfo1.url2
            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & Me.Label1.Text & " " & ff)
            Me.VlcControl1.Play(New Uri("c:/casparcg/_media/bluefish_card.jpg"))
        End If
    End Sub

    Private Sub StreamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StreamToolStripMenuItem.Click
        On Error Resume Next
        Dim ff As String = InputBox("Put Stream Address", "", "udp://@224.0.0.1:5004")
        If ff <> "" Then
            Form1.ElementInfo1.Type1 = "stream"
            Form1.ElementInfo1.url1 = ff
            Form1.ElementInfo1.url2 = ""
            Me.Tag = Form1.ElementInfo1.Type1 & Chr(3) & Form1.ElementInfo1.url1 & Chr(3) & Form1.ElementInfo1.url2
            VlcControl1.Play(New Uri(ff), params)
            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & Me.Label1.Text & " " & ff)
        End If
    End Sub

    Private Sub HtmlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HtmlToolStripMenuItem.Click
        On Error Resume Next
        Dim ff As String = InputBox("Put web Address", "", "http://casparcgforum.com")
        If ff <> "" Then
            Form1.ElementInfo1.Type1 = "html"
            Form1.ElementInfo1.url1 = ff
            Form1.ElementInfo1.url2 = ""
            Me.Tag = Form1.ElementInfo1.Type1 & Chr(3) & Form1.ElementInfo1.url1 & Chr(3) & Form1.ElementInfo1.url2
            VlcControl1.Play(New Uri("c:/casparcg/_media/http.png"), params)
            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & Me.Label1.Text & " [html] " & ff)
        End If
    End Sub

    Private Sub YoutubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YoutubeToolStripMenuItem.Click
        On Error Resume Next
        Dim ff, ff1 As String
        ff = InputBox("Put youtube Video ID", "", "plxV00PcX28")
        If ff <> "" Then
            ff1 = InputBox("Put Size of Channel", "", "1024x576")
            If ff1 <> "" Then
                Form1.ElementInfo1.Type1 = "youtube"
                Form1.ElementInfo1.url1 = ff
                Form1.ElementInfo1.url2 = ff1
                Me.Tag = Form1.ElementInfo1.Type1 & Chr(3) & Form1.ElementInfo1.url1 & Chr(3) & Form1.ElementInfo1.url2
                VlcControl1.Play(New Uri("c:/casparcg/_media/youtube.png"), params)
                VlcControl1.Tag = ff
                CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & Label1.Text & " [HTML]  file:///C:/casparcg/mydata/youtube/youtube.html")
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & Label1.Text & " opacity 0")
                Threading.Thread.Sleep(1000)
                CasparDevice.SendString("Call " & g_int_ChannelNumber & "-" & Label1.Text & " player.loadVideoById('" & ff & "')")
                CasparDevice.SendString("Call " & g_int_ChannelNumber & "-" & Label1.Text & " player.setSize('" & Split(ff1, "x")(0) & "','" & Split(ff1, "x")(1) & "')")
                Threading.Thread.Sleep(1000)
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & Label1.Text & " opacity 1")
            End If
        End If
    End Sub

    Private Sub SendToBackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendToBackToolStripMenuItem.Click
        Me.SendToBack()
    End Sub

    Private Sub BringToFrontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BringToFrontToolStripMenuItem.Click
        Me.BringToFront()
    End Sub

    Private Sub AddCaptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCaptionToolStripMenuItem.Click
        Dim ss As String = InputBox("Source name", "", "SOURCE 1")
        If ss <> "" Then
            intElements = intElements + 1
            Dim Media As New UcCaption
            Me.Controls.Add(Media) 'Form1.Panel1.Controls.Add(Media)
            Media.Label1.Text = intElements
            Media.Name = "media" & intElements
            Form1.UcMixernew1.cmbvideolayerformixer.Text = Media.Label1.Text
            Media.Location = New Point((Me.Width - Media.Width) / 2, (Me.Height - Media.Height))
            Dim rs1 = New clsResizeableControlnew(Media)

            Media.Label2.Text = ss
            CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & Media.Label1.Text & " [html] " & """" & "c:/casparcg/CMP/Composition/SourceName/gwd_preview_SourceName/index.html" & """")
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Media.Label1.Text & " updatestring('" & replacestring1("ccgf0") & "','" & replacestring1(ss) & "')")
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & Media.Label1.Text & " fill " & fillcommandCaption(Media)(0))
            Media.BringToFront()

            Form1.ElementInfo1.Type1 = "caption"
            Form1.ElementInfo1.url1 = ss
            Form1.ElementInfo1.url2 = Me.Name
            Media.Tag = Form1.ElementInfo1.Type1 & Chr(3) & Form1.ElementInfo1.url1 & Chr(3) & Form1.ElementInfo1.url2
        End If

    End Sub

    Private Sub ucElement_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        elementmove = False
    End Sub

    Private Sub NDIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NDIToolStripMenuItem.Click
        On Error Resume Next
        Dim aa As New Form
        Dim bb As New ucNDISource
        aa.Controls.Add(bb)
        aa.ShowDialog()
        'ndi1 = bb.cmbNDI.Text
        Form1.ElementInfo1.Type1 = "ndi"
        Form1.ElementInfo1.url1 = ndi1
            Form1.ElementInfo1.url2 = ""
            Me.Tag = Form1.ElementInfo1.Type1 & Chr(3) & Form1.ElementInfo1.url1 & Chr(3) & Form1.ElementInfo1.url2
        VlcControl1.Play(New Uri("c:/casparcg/_media/ndi.jpg"), params)
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & Me.Label1.Text & " [ndi] " & ndi1)
        'End If

    End Sub
End Class
