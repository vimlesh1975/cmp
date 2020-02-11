
Imports Svt.Caspar
Public Class ucdc
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        initialisesetscorett()
    End Sub
    Sub animation1()
        Dim x, y As Decimal
        If rdoLeftIN.Checked Then
            x = -1
            y = 0
        ElseIf rdoRightIN.Checked Then
            x = 1
            y = 0
        ElseIf rdoUpIN.Checked Then
            x = 0
            y = -1
        ElseIf rdoDownIN.Checked Then
            x = 0
            y = 1
            y = -1
        ElseIf rdoFedIN.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " opacity  0")
            GoTo 50
        End If
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill " & x & " " & y & " 1 1 50 easeoutexpo")
50:
    End Sub
    Sub animationtoscreen()

        If rdoFedIN.Checked Or rdoFedOut.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " opacity 1 50 easeoutexpo")
            If chkanimationforhdvan.Checked Then
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill .1 0 .8 1 50 " & "easeoutexpo")
            End If
            GoTo 50
        End If
        If chkanimationforhdvan.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill .1 0 .8 1 50 " & "easeoutexpo")
        Else
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill 0 0 1 1 50 " & "easeoutexpo")
        End If
50:
    End Sub
    Sub animation2()
        Dim x, y As Decimal
        If rdoleftOut.Checked Then
            x = -1
            y = 0
        ElseIf rdoRightOut.Checked Then
            x = 1
            y = 0
        ElseIf rdoUpOut.Checked Then
            x = 0
            y = -1
        ElseIf rdoDownOut.Checked Then
            x = 0
            y = 1
        ElseIf rdoFedOut.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " opacity 0 50 easeoutexpo")
            'Threading.Thread.Sleep(2000)
            'CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " opacity 1")
            GoTo 50
        End If
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill " & x & " " & y & " 1 1 50 easeoutexpo")
50:
    End Sub

    'Sub outccgwindow()
    '    On Error Resume Next
    '    'This is important! If you have a child process on your form, it will terminate along with your form if you do not set its parent to Nothing
    '    If Not parentedProcess Is Nothing Then
    '        SetParent(parentedProcess.MainWindowHandle, Nothing)
    '    End If
    'End Sub


    Private Sub initialisesetscorett()
        dgvsetscorett.Rows.Add(3)
        For isetscorett = 0 To 2
            For jsetscorett = 0 To 6
                dgvsetscorett.Rows(isetscorett).Cells(jsetscorett).Value = isetscorett & jsetscorett
            Next
        Next
    End Sub

    Private Sub gbsetscorett_Enter(sender As Object, e As EventArgs) Handles gbsetscorett.Enter

    End Sub

    Private Sub cmdshowscorett_Click(sender As Object, e As EventArgs) Handles cmdshowscorett.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("t1", txtshortnamet1tt.Text)
        CasparCGDataCollection.SetData("t2", txtshortnamet2tt.Text)
        CasparCGDataCollection.SetData("g1", txtgamet1tt.Text)
        CasparCGDataCollection.SetData("g2", txtgamet2tt.Text)
        CasparCGDataCollection.SetData("p1", txtpointt1tt.Text)
        CasparCGDataCollection.SetData("p2", txtpointt2tt.Text)

        CasparCGDataCollection.SetData("s1", txtset1tt.Text)
        CasparCGDataCollection.SetData("s2", txtset2tt.Text)

        CasparCGDataCollection.SetData("loader1", pict1tt.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2tt.ImageLocation)
        If chkshowservicett.Checked Then
            If rdoservicet1tt.Checked Then
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games4/tt/serve.png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games4/tt/blk.png")
            Else
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games4/tt/blk.png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games4/tt/serve.png")
            End If
        End If
        showtemplate("CMP/games4/davis_cup/dc_scorebug", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Sub showtemplate(ByVal templatename As String, ByVal datacollection As String)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), templatename, True, datacollection)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdupdatescorett_Click(sender As Object, e As EventArgs) Handles cmdupdatescorett.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("t1", txtshortnamet1tt.Text)
        CasparCGDataCollection.SetData("t2", txtshortnamet2tt.Text)
        CasparCGDataCollection.SetData("g1", txtgamet1tt.Text)
        CasparCGDataCollection.SetData("g2", txtgamet2tt.Text)
        CasparCGDataCollection.SetData("p1", txtpointt1tt.Text)
        CasparCGDataCollection.SetData("p2", txtpointt2tt.Text)

        CasparCGDataCollection.SetData("s1", txtset1tt.Text)
        CasparCGDataCollection.SetData("s2", txtset2tt.Text)

        If chkshowservicett.Checked Then
            If rdoservicet1tt.Checked Then
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games4/tt/serve.png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games4/tt/blk.png")
            Else
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games4/tt/blk.png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games4/tt/serve.png")
            End If
        End If
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)

    End Sub

    Private Sub cmdstopall_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        CasparDevice.SendString("clear 1")
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " clear")

    End Sub

    Private Sub cmdpointdecreaset1tt_Click(sender As Object, e As EventArgs) Handles cmdpointdecreaset1tt.Click
        On Error Resume Next
        If chklawntennis.Checked Then
            If txtpointt1tt.Text = "0" Then txtpointt1tt.Text = "Ad" : Exit Sub
            If txtpointt1tt.Text = "15" Then txtpointt1tt.Text = "0" : Exit Sub
            If txtpointt1tt.Text = "30" Then txtpointt1tt.Text = "15" : Exit Sub
            If txtpointt1tt.Text = "40" Then txtpointt1tt.Text = "30" : Exit Sub
            If txtpointt1tt.Text = "Ad" Then txtpointt1tt.Text = 40 : Exit Sub
        Else
            txtpointt1tt.Text = txtpointt1tt.Text - 1
        End If
    End Sub

    Private Sub cmdpointincreaset1tt_Click(sender As Object, e As EventArgs) Handles cmdpointincreaset1tt.Click
        On Error Resume Next
        If chklawntennis.Checked Then
            If txtpointt1tt.Text = "0" Then txtpointt1tt.Text = "15" : Exit Sub
            If txtpointt1tt.Text = "15" Then txtpointt1tt.Text = "30" : Exit Sub

            If txtpointt1tt.Text = "30" Then
                txtpointt1tt.Text = "40"
                If txtpointt2tt.Text = "40" Then
                    cmblefttoptt.Text = "Deuce"
                End If
                Exit Sub
            End If


            If txtpointt1tt.Text = "40" And txtpointt2tt.Text = "40" Then
                txtpointt1tt.Text = "Ad"
                cmblefttoptt.Text = "Advantage"
                Exit Sub
            ElseIf txtpointt1tt.Text = "40" And (txtpointt2tt.Text) <> "Ad" Then
                txtpointt1tt.Text = "0"
                txtpointt2tt.Text = "0"
                txtgamet1tt.Text = txtgamet1tt.Text + 1
                cmblefttoptt.Text = ""
                Exit Sub
            ElseIf txtpointt1tt.Text = "40" And txtpointt2tt.Text = "Ad" Then

                txtpointt2tt.Text = "40"
                cmblefttoptt.Text = "Deuce"
                Exit Sub
            End If

            If txtpointt1tt.Text = "Ad" Then
                txtpointt1tt.Text = "0"
                txtpointt2tt.Text = "0"
                txtgamet1tt.Text = txtgamet1tt.Text + 1
                cmblefttoptt.Text = ""
            End If


        Else
            txtpointt1tt.Text = txtpointt1tt.Text + 1
        End If

    End Sub

    Private Sub cmdpointincreaset2tt_Click(sender As Object, e As EventArgs) Handles cmdpointincreaset2tt.Click
        On Error Resume Next
        If chklawntennis.Checked Then

            If txtpointt2tt.Text = "0" Then txtpointt2tt.Text = "15" : Exit Sub
            If txtpointt2tt.Text = "15" Then txtpointt2tt.Text = "30" : Exit Sub

            If txtpointt2tt.Text = "30" Then
                txtpointt2tt.Text = "40"
                If txtpointt1tt.Text = "40" Then
                    cmblefttoptt.Text = "Deuce"
                End If
                Exit Sub

            End If

            If txtpointt2tt.Text = "40" And txtpointt1tt.Text = "40" Then
                txtpointt2tt.Text = "Ad"
                cmblefttoptt.Text = "Advantage"
                Exit Sub
            ElseIf txtpointt2tt.Text = "40" And (txtpointt1tt.Text) <> "Ad" Then
                txtpointt1tt.Text = "0"
                txtpointt2tt.Text = "0"
                txtgamet2tt.Text = txtgamet2tt.Text + 1
                cmblefttoptt.Text = ""
                Exit Sub
            ElseIf txtpointt2tt.Text = "40" And txtpointt1tt.Text = "Ad" Then

                txtpointt1tt.Text = "40"
                cmblefttoptt.Text = "Deuce"
                Exit Sub
            End If

            If txtpointt2tt.Text = "Ad" Then
                txtpointt1tt.Text = "0"
                txtpointt2tt.Text = "0"
                txtgamet2tt.Text = txtgamet2tt.Text + 1
                cmblefttoptt.Text = ""
            End If

        Else
            txtpointt2tt.Text = txtpointt2tt.Text + 1
        End If
    End Sub

    Private Sub cmdpointdecreaset2tt_Click(sender As Object, e As EventArgs) Handles cmdpointdecreaset2tt.Click
        On Error Resume Next
        If chklawntennis.Checked Then
            If txtpointt2tt.Text = "0" Then txtpointt2tt.Text = "Ad" : Exit Sub
            If txtpointt2tt.Text = "15" Then txtpointt2tt.Text = "0" : Exit Sub
            If txtpointt2tt.Text = "30" Then txtpointt2tt.Text = "15" : Exit Sub
            If txtpointt2tt.Text = "40" Then txtpointt2tt.Text = "30" : Exit Sub
            If txtpointt2tt.Text = "Ad" Then txtpointt2tt.Text = "40" : Exit Sub
        Else
            txtpointt2tt.Text = txtpointt2tt.Text - 1
        End If
    End Sub

    Private Sub cmdresetscorett_Click(sender As Object, e As EventArgs) Handles cmdresetscorett.Click
        txtgamet1tt.Text = "0"
        txtgamet2tt.Text = "0"
        txtpointt1tt.Text = "0"
        txtpointt2tt.Text = "0"
        txtset1tt.Text = "0"
        txtset2tt.Text = "0"
    End Sub

    Private Sub cmdversustt_Click(sender As Object, e As EventArgs) Handles cmdversustt.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", cmbHeader.Text)
        CasparCGDataCollection.SetData("f1", cmbSubHeader.Text)

        CasparCGDataCollection.SetData("f2", txtfullnamet1tt.Text)
        CasparCGDataCollection.SetData("f3", txtfullnamet2tt.Text)

        CasparCGDataCollection.SetData("loader1", pict1tt.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2tt.ImageLocation)
        showtemplate("cmp/games4/davis_cup/dc_matchid", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub pict1tt_Click(sender As Object, e As EventArgs) Handles pict1tt.Click
        On Error Resume Next
        openlogoandcountryfullnamesg(sender, e, txtfullnamet1tt)
    End Sub

    Private Sub pict2tt_Click(sender As Object, e As EventArgs) Handles pict2tt.Click
        On Error Resume Next
        openlogoandcountryfullnamesg(sender, e, txtfullnamet2tt)
    End Sub

    Private Sub cmdshowsetscorett_Click(sender As Object, e As EventArgs) Handles cmdshowsetscorett.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        Dim setscore As Integer
        If rdo3settt.Checked Then setscore = 3
        If rdo5settt.Checked Then setscore = 5
        If rdo7settt.Checked Then setscore = 7

        If chkShowTime.Checked Then
            For isetscore = 1 To setscore
                CasparCGDataCollection.SetData("f" & isetscore, dgvsetscorett.Rows(2).Cells(isetscore - 1).Value)
            Next
        Else
            For isetscore = 1 To setscore
                CasparCGDataCollection.SetData("f" & isetscore, dgvsetscorett.Columns(isetscore - 1).HeaderText)
            Next
        End If
        For isetscore = 1 To 2
            For jsetscore = 1 To setscore
                CasparCGDataCollection.SetData("f" & isetscore & jsetscore, dgvsetscorett.Rows(isetscore - 1).Cells(jsetscore - 1).Value)
            Next
        Next

        CasparCGDataCollection.SetData("h1", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("h2", txtResult.Text)

        CasparCGDataCollection.SetData("t1", txtfullnamet1tt.Text)
        CasparCGDataCollection.SetData("t2", txtfullnamet2tt.Text)

        CasparCGDataCollection.SetData("loader1", pict1tt.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2tt.ImageLocation)

        If chkshowservicett.Checked Then
            If rdoservicet1tt.Checked Then
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games4/tt/serve.png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games4/tt/blk.png")
            Else
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games4/tt/blk.png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games4/tt/serve.png")
            End If
        End If

        showtemplate("cmp/games4/davis_cup/dc_scorestrap", CasparCGDataCollection.ToAMCPEscapedXml)


    End Sub

    Private Sub cmdscoreresettt_Click(sender As Object, e As EventArgs) Handles cmdscoreresettt.Click
        On Error Resume Next
        For iscore = 0 To 2
            For jscore = 0 To 6
                dgvsetscorett.Rows(iscore).Cells(jscore).Value = ""
            Next
        Next
    End Sub

    Private Sub cmdeventid_Click(sender As Object, e As EventArgs) Handles cmdeventid.Click

    End Sub
    Private Sub cmdw1_Click(sender As Object, e As EventArgs) Handles cmdw1.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games4/davis_cup/dc_playervsplayer", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdshowinfo_Click(sender As Object, e As EventArgs) Handles cmdshowinfo.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", cmblefttoptt.Text)
        'showtemplate("cmp/games4/davis_cup/dc_info", CasparCGDataCollection.ToAMCPEscapedXml)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text) + 1, "cmp/games4/davis_cup/dc_info", True, CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text), Int(cmblayergames.Text) + 1)

    End Sub

    Private Sub cmdstopgym_Click(sender As Object, e As EventArgs) Handles cmdstopgym.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation2()

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text), Int(cmblayergames.Text))
        Threading.Thread.Sleep(1000)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub
    Private Sub cmdDailyHighlights_Click(sender As Object, e As EventArgs) Handles cmdDailyHighlights.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games4/davis_cup/dc_newshighlights", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdRanking_Click(sender As Object, e As EventArgs) Handles cmdRanking.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games4/davis_cup/dc_rankings", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdPlayersRanking_Click(sender As Object, e As EventArgs) Handles cmdPlayersRanking.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games4/davis_cup/dc_teamboard", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub
    Private Sub cmdOneliner_Click(sender As Object, e As EventArgs) Handles cmdOneliner.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtoneliner1.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games4/davis_cup/oneliner", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", TextBox1.Text)
        CasparCGDataCollection.SetData("f1", TextBox2.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games4/davis_cup/twoliner", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games4/davis_cup/welcome", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub Cmdhide_Click(sender As Object, e As EventArgs) Handles cmdhide.Click
        Me.Hide()
    End Sub
End Class
