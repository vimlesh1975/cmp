
Imports Svt.Caspar
Public Class ucRccBall
    'Public WithEvents CasparDevice As New Svt.Caspar.CasparDevice


    Private Sub NG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        defautdataforball()
        initialisesetscoreball()

        dgvpenaltyball.Rows.Add(2)
        dgvpenaltyball.Rows(0).Cells(0).Value = 0
        dgvpenaltyball.Rows(0).Cells(1).Value = 0
        dgvpenaltyball.Rows(0).Cells(2).Value = 1
        dgvpenaltyball.Rows(0).Cells(3).Value = 0
        dgvpenaltyball.Rows(0).Cells(4).Value = 1

        dgvpenaltyball.Rows(1).Cells(0).Value = 1
        dgvpenaltyball.Rows(1).Cells(1).Value = 0
        dgvpenaltyball.Rows(1).Cells(2).Value = 1
        dgvpenaltyball.Rows(1).Cells(3).Value = 0
        dgvpenaltyball.Rows(1).Cells(4).Value = 0

        'refreshdatacg2()

        CasparDevice.Connect("localhost", 5250)

    End Sub

    Private Sub initialisesetscoreball()
        dgvsetscoreball.Rows.Add(3)


        For isetscorett = 0 To 2
            If isetscorett = 0 Then
                For jsetscorett = 0 To 5
                    dgvsetscoreball.Rows(isetscorett).Cells(jsetscorett).Value = dgvsetscoreball.Columns(jsetscorett).HeaderText
                Next
            Else
                For jsetscorett = 0 To 5
                    dgvsetscoreball.Rows(isetscorett).Cells(jsetscorett).Value = isetscorett & jsetscorett
                Next
            End If

        Next
    End Sub

    Private Sub gamelogoforgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gamelogo.Click
        On Error Resume Next
        openimage("C:/casparcg/mydata/games5/games logo/", sender)
    End Sub

    Private Sub eventlogoforgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eventlogo.Click
        On Error Resume Next
        openimage("C:/casparcg/mydata/games5/event logo/", sender)
    End Sub




    Private Sub cmdstopgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopgym.Click
        On Error Resume Next
        If chkanimation.Checked Then animation2(Int(cmblayergames.Text))

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text), Int(cmblayergames.Text))
        Threading.Thread.Sleep(1000)
        If chkanimation.Checked Then animationtoscreen(Int(cmblayergames.Text))

    End Sub

    Sub animation1(videolayer)

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
        ElseIf rdoSqueezeIn.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & videolayer & " fill 0.5 0 0 1 50 easeoutexpo")
            Exit Sub
        ElseIf rdoFedIN.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & videolayer & " opacity  0")
            GoTo 50
        End If
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & videolayer & " fill " & x & " " & y & " 1 1 50 easeoutexpo")
50:
    End Sub
    Sub animationtoscreen(videolayer)
        If rdoFedIN.Checked Or rdoFedOut.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & videolayer & " opacity 1 50 easeoutexpo")

            If chkanimationforhdvan.Checked Then
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & videolayer & " fill .1 0 .8 1 50 " & "easeoutexpo")
            End If
            GoTo 50
        End If
        If chkanimationforhdvan.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & videolayer & " fill .1 0 .8 1 50 " & "easeoutexpo")
        Else
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & videolayer & " fill 0 0 1 1 50 " & "easeoutexpo")
        End If
50:
    End Sub
    Sub animation2(videolayer)
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
        ElseIf rdoSqueezeOut.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & videolayer & " fill 0.5 0 0 1 50 easeoutexpo")
            Exit Sub
        ElseIf rdoFedOut.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & videolayer & " opacity 0 50 easeoutexpo")
            GoTo 50
        End If
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & videolayer & " fill " & x & " " & y & " 1 1 50 easeoutexpo")
50:
    End Sub

    Private Sub cmdeventid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeventid.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", cmbHeader.Text)
        CasparCGDataCollection.SetData("ccgf1", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))

        showtemplate("cmp/games5/rcc/ball/event_id", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub


    Private Sub dgvwinner_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        'dummy code don't delete
    End Sub


    Private Sub cmdaddoutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaddoutput.Click
        On Error Resume Next

        CasparDevice.SendString("add " & g_int_ChannelNumber & " decklink 1 " & "embedded_audio")
        CasparDevice.SendString("add " & g_int_ChannelNumber & " bluefish 1 " & "embedded_audio")

        CasparDevice.SendString("add " & g_int_ChannelNumber & " decklink 2 " & "key_only") ' for key
        CasparDevice.SendString("add " & g_int_ChannelNumber & " bluefish 2 " & "key_only") ' for key
    End Sub

    Private Sub cmdremoveoutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremoveoutput.Click
        On Error Resume Next

        CasparDevice.SendString("remove " & g_int_ChannelNumber & " decklink 1")
        CasparDevice.SendString("remove " & g_int_ChannelNumber & " bluefish 1")
        CasparDevice.SendString("remove " & g_int_ChannelNumber & " decklink 2") ' for key
        CasparDevice.SendString("remove " & g_int_ChannelNumber & " bluefish 2") ' for key
    End Sub
    Private Sub cmdhd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdhd.Click
        On Error Resume Next
        CasparDevice.SendString("set " & g_int_ChannelNumber & " mode 1080i5000")

    End Sub
    Private Sub cmdsd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsd.Click
        On Error Resume Next
        CasparDevice.SendString("set " & g_int_ChannelNumber & " mode PAL")
    End Sub

    Private Sub cmdsqueezeforsafesd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsqueezeforsafesd.Click
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill .1 0 .8 1 50 easeoutexpo")

    End Sub

    Private Sub cmdfillnormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfillnormal.Click
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill 0 0 1 1 50 easeoutexpo")

    End Sub


    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub pict1logoball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pict1logoball.Click
        On Error Resume Next
        txtt1ball.Text = openimage("C:\casparcg\mydata\games5\country\withname\", sender)
    End Sub
    Private Sub cmdadjustminball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadjustminball.Click
        On Error Resume Next
        txtminball.Text = cmbputminuteball.Text
    End Sub

    Private Sub cmdadjustsecball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadjustsecball.Click
        On Error Resume Next
        txtsecball.Text = cmbputsecondball.Text
    End Sub

    Function openimage(ByVal defaultdirectory As String, ByVal picname As PictureBox)
        On Error Resume Next
        Dim picofd As New OpenFileDialog
        picofd.InitialDirectory = defaultdirectory
        If (picofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            picname.ImageLocation = picofd.FileName
        End If
        Return (Split(picofd.SafeFileName, ".")(0)).Replace("\", "/")
    End Function

    Private Sub pict2logoball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pict2logoball.Click
        On Error Resume Next
        txtt2ball.Text = openimage("C:\casparcg\mydata\games5\country\withname\", sender)
    End Sub

    Private Sub cmdstartclockball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstartclockball.Click
        tmrtimeonform.Enabled = True
        aa = Val(Now.Second.ToString) 'new code
    End Sub
    Dim aa As Integer 'new code

    Private Sub cmdresetclockball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresetclockball.Click
        txtminball.Text = "00"
        txtsecball.Text = "00"
    End Sub

    Private Sub cmdpauseclockball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpauseclockball.Click
        tmrtimeonform.Enabled = False
    End Sub

    Private Sub tmrtimeonform_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrtimeonform.Tick
        On Error Resume Next
        Dim bb = Val(Now.Second.ToString)

        Dim dif As Integer = (bb - aa)
        aa = bb
        If dif < 0 Then dif = dif + 60

        If rdodowncounterball.Checked = True Then
            txtsecball.Text = Format(Val(txtsecball.Text - dif), "00")
            If Val(txtsecball.Text) < 0 Then
                txtsecball.Text = 59
                txtminball.Text = Format(txtminball.Text - 1, "00")
            End If
            If Val(txtminball.Text) < 0 Then
                txtsecball.Text = "00"
                txtminball.Text = "00"
            End If
        End If
        If rdoupcounterball.Checked = True Then
            txtsecball.Text = Format(Val(txtsecball.Text + dif), "00")
            If txtsecball.Text > 59 Then
                txtsecball.Text = "00"
                txtminball.Text = Format(txtminball.Text + 1, "00")
            End If
        End If
    End Sub

    Private Sub tmrtimeupdateontemplate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrtimeupdateontemplate.Tick
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgtime", txtminball.Text & ":" & txtsecball.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, CasparCGDataCollection)

    End Sub

    Private Sub tmrupdateontemplateextra_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrupdateontemplateextra.Tick
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgtime", txthalftimeball.Text & ":00")
        CasparCGDataCollection.SetData("ccgextra", txtminball.Text & ":" & txtsecball.Text)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, CasparCGDataCollection)
    End Sub

    Private Sub cmdscorewithextraball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscorewithextraball.Click
        On Error Resume Next

        ' If chkanimationzym.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt2ball.Text)
        CasparCGDataCollection.SetData("ccgf2", txtt1gball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2gball.Text)
        CasparCGDataCollection.SetData("ccgtime", txthalftimeball.Text & ":00")
        CasparCGDataCollection.SetData("ccgf5", cmbhalfball.Text)
        CasparCGDataCollection.SetData("ccgextra", txtminball.Text & ":" & txtsecball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))
        showtemplatescore("cmp/games5/rcc/ball/score", CasparCGDataCollection.ToAMCPEscapedXml)

        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "cmp/games5/rcc/ball/score", True, CasparCGDataCollection.ToAMCPEscapedXml)
        'If chkanimationzym.Checked Then
        '    If chkanimationforhdvan.Checked Then
        '        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill .1 0 .8 1 50 easeoutexpo")
        '    Else
        '        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill 0 0 1 1 50 easeoutexpo")
        '    End If
        'End If
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "extraalpha('1')" & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "showClockAndhalf('1')" & """")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setTeamcolor('ccgteam1color'," & "'" & ColorTranslator.ToHtml(cmdt1colorball.BackColor) & "')" & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setTeamcolor('ccgteam2color'," & "'" & ColorTranslator.ToHtml(cmdt2colorball.BackColor) & "')" & """")

        tmrtimeupdateontemplate.Enabled = False
        tmrupdateontemplateextra.Enabled = True

    End Sub

    Private Sub cmdstopscoreball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopscoreball.Click
        On Error Resume Next
        If chkanimation.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1)
        Threading.Thread.Sleep(2000)
        If chkanimation.Checked Then
            If chkanimationforhdvan.Checked Then
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill .1 0 .8 1 50 easeoutexpo")

            Else
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill 0 0 1 1 50 easeoutexpo")

            End If

        End If
        tmrtimeupdateontemplate.Enabled = False
        tmrupdateontemplateextra.Enabled = False
    End Sub

    Private Sub defautdataforball()
        On Error Resume Next
        With dgvt1ball
            .Rows.Add(22)
            .Rows(0).Cells(0).Value = "21 K Bharadwaja"
            .Rows(1).Cells(0).Value = "52 N Sri Sai"
            .Rows(2).Cells(0).Value = "73 A K Prajapati"
            .Rows(3).Cells(0).Value = "34 Deepesh Sahu"
            .Rows(4).Cells(0).Value = "18 Vatsal Reshamwala"
            .Rows(5).Cells(0).Value = "22 Devanshu Soni"
            .Rows(6).Cells(0).Value = "23 Honey Mehra"
            .Rows(7).Cells(0).Value = "24 Mayank Jain"
            .Rows(8).Cells(0).Value = "25 Baleshwar Nayak"
            .Rows(9).Cells(0).Value = "26 Manoj Thapa"
            .Rows(10).Cells(0).Value = "27 Rahul Chitrasen"

            .Rows(11).Cells(0).Value = "28 Vidwath Sundaraju"
            .Rows(12).Cells(0).Value = "29 M. Shinoj"
            .Rows(13).Cells(0).Value = "06 Bhaskar Das"
            .Rows(14).Cells(0).Value = "13 Anuj Rathi"
            .Rows(15).Cells(0).Value = "15 Bapi Roy"
            .Rows(16).Cells(0).Value = "20 Yogeshwar Singh"
            .Rows(17).Cells(0).Value = "22 Devanshu Soni"
            .Rows(18).Cells(0).Value = "34 Rajeev R"
            .Rows(19).Cells(0).Value = "31 Sarath G.L."
            .Rows(20).Cells(0).Value = "32 Sarath Gopal"
            .Rows(21).Cells(0).Value = "33 Jithu V. S,"
            .Rows(22).Cells(0).Value = "Coach-Madhvan Nair"

        End With
        With dgvt2ball
            .Rows.Add(22)
            .Rows(0).Cells(0).Value = "36 Abhishek Chatterjee"
            .Rows(1).Cells(0).Value = "37 Ashutosh Verma"
            .Rows(2).Cells(0).Value = "38 Bharat Batham"
            .Rows(3).Cells(0).Value = "39 Jagat Sharma"
            .Rows(4).Cells(0).Value = "40 Narendra Mahawar"
            .Rows(5).Cells(0).Value = "41 Rohit Jadhav"
            .Rows(6).Cells(0).Value = "42 Sunder Verma"
            .Rows(7).Cells(0).Value = "43 Akash Dongre"
            .Rows(8).Cells(0).Value = "44 Anish Joshi"
            .Rows(9).Cells(0).Value = "45 Narsimha Chavhan"
            .Rows(10).Cells(0).Value = "46 Prithviraj Phadnis"

            .Rows(11).Cells(0).Value = "47 Sagar Sawant"
            .Rows(12).Cells(0).Value = "48 Vijay Ingle"
            .Rows(13).Cells(0).Value = "06 Vimesh Kumar"
            .Rows(14).Cells(0).Value = "49 Vinayak Auti"
            .Rows(15).Cells(0).Value = "50 B Tulshidas Sharma"
            .Rows(16).Cells(0).Value = "51 Ch Meiraba Meitei"
            .Rows(17).Cells(0).Value = "52 K Roopakanta Sharma"
            .Rows(18).Cells(0).Value = "53 Rajeev Gopinathan"
            .Rows(19).Cells(0).Value = "54 M Chandrashekhar"
            .Rows(20).Cells(0).Value = "55 Peter Rose"
            .Rows(21).Cells(0).Value = "56 V B Hadap"
            .Rows(22).Cells(0).Value = "Coach-Ramakrishna Panigrahi"

        End With

    End Sub


    Private Sub cmdt1lineupball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt1lineupball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        For i = 0 To 22
            CasparCGDataCollection.SetData("ccgf" & i, dgvt1ball.Rows(i).Cells(0).Value)
        Next
        CasparCGDataCollection.SetData("ccgheader", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgsubheader", "Starting Lineup")
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/teamlineup", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub



    Private Sub cmdt2lineupball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2lineupball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        For i = 0 To 22
            CasparCGDataCollection.SetData("ccgf" & i, dgvt2ball.Rows(i).Cells(0).Value)
        Next
        CasparCGDataCollection.SetData("ccgheader", txtt2ball.Text)
        CasparCGDataCollection.SetData("ccgsubheader", "Starting Lineup")
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/teamlineup", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Sub showtemplate(ByVal templatename As String, ByVal datacollection As String)
        On Error Resume Next
        If chkanimation.Checked Then animation1(Int(cmblayergames.Text))
        Threading.Thread.Sleep(250)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), templatename, True, datacollection)
        Threading.Thread.Sleep(1300)
        If chkanimation.Checked Then animationtoscreen(cmblayergames.Text)
    End Sub
    Sub showtemplatescore(ByVal templatename As String, ByVal datacollection As String)
        On Error Resume Next
        If chkanimation.Checked Then animation1(Int(cmblayergames.Text) + 1)
        Threading.Thread.Sleep(250)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, templatename, True, datacollection)
        Threading.Thread.Sleep(1300)
        If chkanimation.Checked Then animationtoscreen(Int(cmblayergames.Text) + 1)
    End Sub
    Private counter As Integer
    Private Sub dgvt2ball_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvt2ball.CellDoubleClick
        On Error Resume Next
        If counter = 0 Then
            txtt2inball.Text = sender.CurrentRow.Cells(0).Value
            counter = counter + 1
        Else
            txtt2outball.Text = sender.CurrentRow.Cells(0).Value
            counter = 0
        End If
    End Sub

    Private Sub dgvt1ball_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvt1ball.CellDoubleClick
        On Error Resume Next
        If counter = 0 Then
            txtt1inball.Text = sender.CurrentRow.Cells(0).Value
            counter = counter + 1
        Else
            txtt1outball.Text = sender.CurrentRow.Cells(0).Value
            counter = 0
        End If
    End Sub

    Private Sub cmdt1yball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt1yball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt1ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/yellow_card", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdt2yball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2yball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/yellow_card", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdt1rball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt1rball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt1ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/red_card", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdt1gball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt1gball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt1ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/goal", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdt2rball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2rball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/red_card", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdt2gball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2gball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/goal", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdt1inoutball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt1inoutball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt1inball.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt1outball.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/in_out", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdt2inoutball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2inoutball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt2inball.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt2outball.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/in_out", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdteam2inball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteam2inball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("ccgf0", txtt2inball.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/in", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdteam1inball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteam1inball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("ccgf0", txtt1inball.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/in", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub


    Private Sub cmdteam2outball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteam2outball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("ccgf0", txtt2outball.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/out", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
    Private Sub cmdteam1outball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteam1outball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("ccgf0", txtt1outball.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/out", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdvsball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdvsball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", cmbHeader.Text)
        CasparCGDataCollection.SetData("ccgf1", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("ccgf2", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2ball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/versus", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub


    Private Sub cmdsavet1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsavet1ball.Click
        On Error Resume Next
        savedatasg("C:\casparcg\mydata\games5\ball\", dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)
    End Sub

    Private Sub cmdnewt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnewt1ball.Click
        On Error Resume Next
        newdatasg(dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)
    End Sub

    Private Sub cmdopent1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdopent1ball.Click
        On Error Resume Next
        opendatasg("C:\casparcg\mydata\games5\ball\", dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)

    End Sub

    Private Sub cmduprowt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmduprowt1ball.Click
        On Error Resume Next
        upsg(dgvt1ball)
    End Sub

    Private Sub cmddownrowt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddownrowt1ball.Click
        On Error Resume Next
        downsg(dgvt1ball)
    End Sub

    Private Sub cmdaddrowt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaddrowt1ball.Click
        insertsg(dgvt1ball)
    End Sub

    Private Sub cmdremoverowt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremoverowt1ball.Click
        deletesg(dgvt1ball)
    End Sub

    Private Sub cmdnewt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnewt2ball.Click
        newdatasg(dgvt2ball, cmbHeader, cmbSubHeader, lblfilenamet2ball)

    End Sub

    Private Sub cmdopent2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdopent2ball.Click
        On Error Resume Next
        opendatasg("C:\casparcg\mydata\games5\ball\", dgvt2ball, cmbHeader, cmbSubHeader, lblfilenamet2ball)

    End Sub

    Private Sub cmdsavet2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsavet2ball.Click
        On Error Resume Next
        savedatasg("C:\casparcg\mydata\games5\ball\", dgvt2ball, cmbHeader, cmbSubHeader, lblfilenamet2ball)

    End Sub

    Private Sub cmduprowt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmduprowt2ball.Click
        upsg(dgvt2ball)
    End Sub

    Private Sub cmdremoverowt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremoverowt2ball.Click
        deletesg(dgvt2ball)
    End Sub

    Private Sub cmdaddrowt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaddrowt2ball.Click
        insertsg(dgvt2ball)
    End Sub

    Private Sub cmddownrowt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddownrowt2ball.Click
        downsg(dgvt2ball)
    End Sub


    Private Sub cmdplayeridt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayeridt1ball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt1ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/player_id", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdplayeridt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayeridt2ball.Click

        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/player_id", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdtteamridt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtteamridt1ball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/player_id", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdtteamridt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtteamridt2ball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt2ball.Text)
        CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/player_id", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub


    Private Sub cmdclockwithinfoball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdt1colorball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt1colorball.Click
        On Error Resume Next
        Dim cdb As New ColorDialog
        If cdb.ShowDialog = DialogResult.OK Then
            sender.backcolor = cdb.Color
        End If
    End Sub

    Private Sub cmdt2colorball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2colorball.Click
        On Error Resume Next
        Dim cdb As New ColorDialog
        If cdb.ShowDialog = DialogResult.OK Then
            sender.backcolor = cdb.Color
        End If
    End Sub

    Private Sub cmdadd1t2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd1t2ball.Click
        txtt2gball.Text += 1
    End Sub

    Private Sub cmdadd1t1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd1t1ball.Click
        txtt1gball.Text += 1
    End Sub

    Private Sub cmdscoreupdateball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscoreupdateball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf2", txtt1gball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2gball.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, CasparCGDataCollection)

    End Sub

    Private Sub cmdgoalSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgoalSummary.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("ccgf0", cmbgoalsummary.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt1gball.Text & "-" & txtt2gball.Text)

        CasparCGDataCollection.SetData("ccgf2", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2ball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))

        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))

        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/Goal_Summary", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdscoreball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscoreball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt2ball.Text)
        CasparCGDataCollection.SetData("ccgf2", txtt1gball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2gball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))
        showtemplatescore("cmp/games5/rcc/ball/score", CasparCGDataCollection.ToAMCPEscapedXml)


        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setTeamcolor('ccgteam1color'," & "'" & ColorTranslator.ToHtml(cmdt1colorball.BackColor) & "')" & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setTeamcolor('ccgteam2color'," & "'" & ColorTranslator.ToHtml(cmdt2colorball.BackColor) & "')" & """")
        tmrtimeupdateontemplate.Enabled = False
        tmrupdateontemplateextra.Enabled = False
    End Sub
    Private Sub cmdscorewithclock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscorewithclock.Click
        On Error Resume Next

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt2ball.Text)
        CasparCGDataCollection.SetData("ccgf2", txtt1gball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2gball.Text)
        CasparCGDataCollection.SetData("ccgtime", txtminball.Text & ":" & txtsecball.Text)
        CasparCGDataCollection.SetData("ccgf5", cmbhalfball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))

        showtemplatescore("cmp/games5/rcc/ball/score", CasparCGDataCollection.ToAMCPEscapedXml)

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "showClockAndhalf('1')" & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setTeamcolor('ccgteam1color'," & "'" & ColorTranslator.ToHtml(cmdt1colorball.BackColor) & "')" & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setTeamcolor('ccgteam2color'," & "'" & ColorTranslator.ToHtml(cmdt2colorball.BackColor) & "')" & """")

        tmrtimeupdateontemplate.Enabled = True
        tmrupdateontemplateextra.Enabled = False
    End Sub

    Private Sub cmdscorewithinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscorewithinfo.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccginfo", cmbinfoball.Text)

        CasparCGDataCollection.SetData("ccgf0", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt2ball.Text)
        CasparCGDataCollection.SetData("ccgf2", txtt1gball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2gball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))

        showtemplatescore("cmp/games5/rcc/ball/score", CasparCGDataCollection.ToAMCPEscapedXml)

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "showinfo('1')" & """")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setTeamcolor('ccgteam1color'," & "'" & ColorTranslator.ToHtml(cmdt1colorball.BackColor) & "')" & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setTeamcolor('ccgteam2color'," & "'" & ColorTranslator.ToHtml(cmdt2colorball.BackColor) & "')" & """")

        tmrtimeupdateontemplate.Enabled = False
        tmrupdateontemplateextra.Enabled = False

    End Sub


    Private Sub cmdscoreresetball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscoreresetball.Click
        On Error Resume Next
        For iscore = 1 To 2
            For jscore = 0 To 6
                dgvsetscoreball.Rows(iscore).Cells(jscore).Value = ""
            Next
        Next
    End Sub

    Private Sub cmdshowsetscoreball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshowsetscoreball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        For isetscore = 1 To 6
            CasparCGDataCollection.SetData("ccgf" & isetscore, dgvsetscoreball.Rows(0).Cells(isetscore - 1).Value)
        Next
        For isetscore = 1 To 2
            For jsetscore = 1 To 6
                CasparCGDataCollection.SetData("ccgf" & isetscore & jsetscore, dgvsetscoreball.Rows(isetscore).Cells(jsetscore - 1).Value)
            Next
        Next

        CasparCGDataCollection.SetData("ccgh1", cmbHeader.Text)
        CasparCGDataCollection.SetData("ccgh2", cmbSubHeader.Text)

        CasparCGDataCollection.SetData("ccgt1", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgt2", txtt2ball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))

        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/set7", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub Ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ball.Click

    End Sub

    Private Sub dgvsetscoreball_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvsetscoreball.CellContentClick

    End Sub

    Sub capitalisetext(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            sender.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtshortnamet1tt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        On Error Resume Next
        capitalisetext(sender, e)
    End Sub

    Private Sub txtshortnamet2tt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        On Error Resume Next
        capitalisetext(sender, e)
    End Sub


    Private Sub txtfullnamet2tt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        On Error Resume Next
        capitalisetext(sender, e)
    End Sub


    Private Sub txtfullnamet1tt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        On Error Resume Next
        capitalisetext(sender, e)
    End Sub

    Private Sub dgvtt_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub cmdscoreboxing_Click(sender As Object, e As EventArgs) Handles cmdscoreboxing.Click
        On Error Resume Next
        If chkanimation.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccginfo", cmbinfoball.Text)

        CasparCGDataCollection.SetData("ccgf0", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt2ball.Text)
        CasparCGDataCollection.SetData("ccgf2", txtt1gball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2gball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))

        showtemplatescore("cmp/games5/rcc/ball/score", CasparCGDataCollection.ToAMCPEscapedXml)


        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "cmp/games5/rcc/ball/score", True, CasparCGDataCollection.ToAMCPEscapedXml)
        'If chkanimationzym.Checked Then
        '    If chkanimationforhdvan.Checked Then
        '        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill .1 0 .8 1 50 easeoutexpo")
        '    Else
        '        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill 0 0 1 1 50 easeoutexpo")
        '    End If
        'End If
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "showinfo('1')" & """")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setTeamcolor('ccgteam1color'," & "'" & ColorTranslator.ToHtml(Color.Red) & "')" & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setTeamcolor('ccgteam2color'," & "'" & ColorTranslator.ToHtml(Color.Blue) & "')" & """")

        tmrtimeupdateontemplate.Enabled = False
        tmrupdateontemplateextra.Enabled = False
    End Sub

    Private Sub cmdversusboxing_Click(sender As Object, e As EventArgs) Handles cmdversusboxing.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", cmbHeader.Text)
        CasparCGDataCollection.SetData("ccgf1", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("ccgf2", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2ball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/versusBoxing", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdplayeridboxing_Click(sender As Object, e As EventArgs) Handles cmdplayeridboxing.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader51", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader52", eventlogo.ImageLocation.Replace("\", "/"))
        If rdoTeamARed.Checked Then
            CasparCGDataCollection.SetData("ccgf1", dgvt1ball.CurrentRow.Cells(0).Value)
            showtemplate("cmp/games5/rcc/ball/player_id_red", CasparCGDataCollection.ToAMCPEscapedXml)
        Else
            CasparCGDataCollection.SetData("ccgf1", dgvt2ball.CurrentRow.Cells(0).Value)
            showtemplate("cmp/games5/rcc/ball/player_id_blue", CasparCGDataCollection.ToAMCPEscapedXml)
        End If

    End Sub

    Private Sub cmdwinnerBoxing_Click(sender As Object, e As EventArgs) Handles cmdwinnerBoxing.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("ccgh1", cmbHeader.Text)
        CasparCGDataCollection.SetData("ccgh2", cmbwinningmethodboxing.Text & "- " & cmbSubHeader.Text)

        If rdoTeamARed.Checked Then
            CasparCGDataCollection.SetData("ccgt1", dgvt1ball.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        Else
            CasparCGDataCollection.SetData("ccgt1", dgvt2ball.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("ccgloader1", pict2logoball.ImageLocation.Replace("\", "/"))
        End If
        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/winner", CasparCGDataCollection.ToAMCPEscapedXml)

        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games5/rcc/ball/winner", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdscorewithclockboxing_Click(sender As Object, e As EventArgs) Handles cmdscorewithclockboxing.Click
        On Error Resume Next

        If chkanimation.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt2ball.Text)
        'CasparCGDataCollection.SetData("ccgf2", txtt1gball.Text)
        'CasparCGDataCollection.SetData("ccgf3", txtt2gball.Text)
        CasparCGDataCollection.SetData("ccgtime", txtminball.Text & ":" & txtsecball.Text)
        CasparCGDataCollection.SetData("ccgf5", cmbhalfball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))
        showtemplatescore("cmp/games5/rcc/ball/score_boxing", CasparCGDataCollection.ToAMCPEscapedXml)

        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "cmp/games5/rcc/ball/score_boxing", True, CasparCGDataCollection.ToAMCPEscapedXml)
        'If chkanimationzym.Checked Then
        '    If chkanimationforhdvan.Checked Then
        '        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill .1 0 .8 1 50 easeoutexpo")
        '    Else
        '        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill 0 0 1 1 50 easeoutexpo")
        '    End If
        'End If
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "showClockAndhalf('1')" & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setTeamcolor('ccgteam1color'," & "'" & ColorTranslator.ToHtml(Color.Red) & "')" & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setTeamcolor('ccgteam2color'," & "'" & ColorTranslator.ToHtml(Color.Blue) & "')" & """")

        tmrtimeupdateontemplate.Enabled = True
        tmrupdateontemplateextra.Enabled = False
    End Sub

    Private Sub cmdsetscoreboxing_Click(sender As Object, e As EventArgs) Handles cmdsetscoreboxing.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        For isetscore = 1 To 6
            CasparCGDataCollection.SetData("ccgf" & isetscore, dgvsetscoreball.Rows(0).Cells(isetscore - 1).Value)
        Next
        For isetscore = 1 To 2
            For jsetscore = 1 To 6
                CasparCGDataCollection.SetData("ccgf" & isetscore & jsetscore, dgvsetscoreball.Rows(isetscore).Cells(jsetscore - 1).Value)
            Next
        Next

        CasparCGDataCollection.SetData("ccgh1", cmbHeader.Text)
        CasparCGDataCollection.SetData("ccgh2", cmbSubHeader.Text)

        CasparCGDataCollection.SetData("ccgt1", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgt2", txtt2ball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))

        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/set7Boxing", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdroundscoreboxing_Click(sender As Object, e As EventArgs) Handles cmdroundscoreboxing.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("ccgf0", cmbgoalsummary.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt1gball.Text & "-" & txtt2gball.Text)

        CasparCGDataCollection.SetData("ccgf2", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2ball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))

        CasparCGDataCollection.SetData("ccgloader5", gamelogo.ImageLocation.Replace("\", "/"))

        CasparCGDataCollection.SetData("ccgloader6", eventlogo.ImageLocation.Replace("\", "/"))
        showtemplate("cmp/games5/rcc/ball/Goal_SummaryBoxing", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Sub makedatatypeforsorting(dgv1 As DataGridView, dgv2 As DataGridView)
        dgv1.Columns(5).ValueType = GetType(Integer)
        dgv2.Columns(5).ValueType = GetType(Integer)
    End Sub
    Private Sub dgvtrack_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        'dummy code dont delete
    End Sub

    Private Sub dgvtrackresult_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        'dummy code dont delete
    End Sub


    Sub sortresult(sourcegrid As DataGridView, targetgrid As DataGridView, columntosort As Integer)
        On Error Resume Next

        Dim targetRows = New List(Of DataGridViewRow)
        For Each sourceRow As DataGridViewRow In sourcegrid.Rows
            If (Not sourceRow.IsNewRow) Then
                Dim targetRow = CType(sourceRow.Clone(), DataGridViewRow)
                For Each cell As DataGridViewCell In sourceRow.Cells
                    If cell.Value = vbNullString And cell.ColumnIndex = columntosort Then
                        targetRow.Cells(cell.ColumnIndex).Value = Int(8)
                    Else
                        targetRow.Cells(cell.ColumnIndex).Value = cell.Value
                    End If
                Next
                targetRows.Add(targetRow)
            End If
        Next
        targetgrid.Columns.Clear()
        For Each column As DataGridViewColumn In sourcegrid.Columns
            targetgrid.Columns.Add(CType(column.Clone(), DataGridViewColumn))
        Next
        targetgrid.Rows.AddRange(targetRows.ToArray())
        targetgrid.Sort(targetgrid.Columns(columntosort), System.ComponentModel.ListSortDirection.Ascending)

    End Sub



    Private Sub cmdtimerresumetrack_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("resume", "")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, CasparCGDataCollection)

    End Sub



    Private Sub dgvFE_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        'dummy code dont delete
    End Sub


    Private Sub dgvFEresult_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        'dummy code dont delete
    End Sub

    Private Sub cmbgames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbgames.SelectedIndexChanged
        If cmbgames.Text = "Aquatics" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\AQ" & ".png"
        If cmbgames.Text = "Archery" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\AR" & ".png"
        If cmbgames.Text = "Atheletics" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\AT" & ".png"
        If cmbgames.Text = "Badminton" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\BD" & ".png"
        If cmbgames.Text = "Basketball" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\BK" & ".png"
        If cmbgames.Text = "Black" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\BLK" & ".png"
        If cmbgames.Text = "Boxing" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\BX" & ".png"
        If cmbgames.Text = "Cycling" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\CY" & ".png"
        If cmbgames.Text = "Diving" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\DIV" & ".png"
        If cmbgames.Text = "Football" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\FB" & ".png"
        If cmbgames.Text = "Gymnastics - Artistic" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\Gymnastics - Artistic" & ".png"
        If cmbgames.Text = "Gymnastics - Rhythmic" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\Gymnastics - Rhythmic" & ".png"
        If cmbgames.Text = "Gymnastics - Trampoline" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\Gymnastics - Trampoline" & ".png"
        If cmbgames.Text = "Handball" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\HB" & ".png"
        If cmbgames.Text = "Hockey" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\HO" & ".png"
        If cmbgames.Text = "Judo" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\HO" & ".png"
        If cmbgames.Text = "Kabaddi" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\KB" & ".png"
        If cmbgames.Text = "Kayaking" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\KK" & ".png"
        If cmbgames.Text = "Shooting" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\SH" & ".png"
        If cmbgames.Text = "Squash" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\SQ" & ".png"
        If cmbgames.Text = "Swimming" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\SW" & ".png"
        If cmbgames.Text = "TableTennis" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\TT" & ".png"
        If cmbgames.Text = "Taekwondo" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\TK" & ".png"
        If cmbgames.Text = "Tennis" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\TE" & ".png"
        If cmbgames.Text = "Triathlon" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\TRI" & ".png"
        If cmbgames.Text = "Volleyball" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\VB" & ".png"
        If cmbgames.Text = "Weight lift" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\WL" & ".png"
        If cmbgames.Text = "Wrestling" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\WR" & ".png"
        If cmbgames.Text = "Wushu" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games5\games logo\WU" & ".png"

    End Sub

    Sub sortresult1(sourcegrid As DataGridView, targetgrid As DataGridView, columntosort As Integer)
        On Error Resume Next
        Dim aa As Integer = 0
        With targetgrid
            .Rows.Clear()
            For ii = 0 To sourcegrid.RowCount - 1
                If (sourcegrid.Rows(ii).Cells(columntosort).Value) <> vbNullString Then
                    .Rows.Add()
                    For jj = 0 To sourcegrid.ColumnCount - 1
                        .Rows(aa).Cells(jj).Value = sourcegrid.Rows(ii).Cells(jj).Value
                    Next
                    aa = aa + 1
                End If
            Next
            For bb = 0 To .RowCount - 1
                .Rows(bb).Cells(columntosort).Value = CType(.Rows(bb).Cells(columntosort).Value, Double)
            Next

            If sourcegrid.Name = "dgvFE" And columntosort = 4 Then
                .Sort(.Columns(columntosort), System.ComponentModel.ListSortDirection.Descending)
            Else
                .Sort(.Columns(columntosort), System.ComponentModel.ListSortDirection.Ascending)
            End If

        End With
    End Sub


    Private Sub cmdgrouptosemifinalball_Click(sender As Object, e As EventArgs) Handles cmdgrouptosemifinalball.Click
        'On Error Resume Next
        'If chkanimationzym.Checked Then animation1()
        'CasparCGDataCollection.Clear()

        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games5/rcc/ball/grouptosemifinal", True, CasparCGDataCollection.ToAMCPEscapedXml)

        'If chkanimationzym.Checked Then animationtoscreen()

        showtemplate("cmp/games5/rcc/ball/grouptosemifinal", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdgroupresultball_Click(sender As Object, e As EventArgs) Handles cmdgroupresultball.Click
        On Error Resume Next
        'If chkanimationzym.Checked Then animation1()
        'CasparCGDataCollection.Clear()

        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games5/rcc/ball/groupresult1", True, CasparCGDataCollection.ToAMCPEscapedXml)
        'If chkanimationzym.Checked Then animationtoscreen()

        showtemplate("cmp/games5/rcc/ball/groupresult1", CasparCGDataCollection.ToAMCPEscapedXml)


    End Sub

    Private Sub cmdgroupresul2tball_Click(sender As Object, e As EventArgs) Handles cmdgroupresul2tball.Click
        On Error Resume Next
        'If chkanimationzym.Checked Then animation1()
        'CasparCGDataCollection.Clear()

        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games5/rcc/ball/groupresult2", True, CasparCGDataCollection.ToAMCPEscapedXml)
        'If chkanimationzym.Checked Then animationtoscreen()

        showtemplate("cmp/games5/rcc/ball/groupresult2", CasparCGDataCollection.ToAMCPEscapedXml)


    End Sub

    Private Sub cmdmatchstatics_Click(sender As Object, e As EventArgs) Handles cmdmatchstatics.Click
        On Error Resume Next
        'If chkanimationzym.Checked Then animation1()
        'CasparCGDataCollection.Clear()

        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games5/rcc/ball/MatchStatics", True, CasparCGDataCollection.ToAMCPEscapedXml)
        'If chkanimationzym.Checked Then animationtoscreen()
        showtemplate("cmp/games5/rcc/ball/MatchStatics", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdgoalsummarywithtime_Click(sender As Object, e As EventArgs) Handles cmdgoalsummarywithtime.Click
        On Error Resume Next
        'If chkanimationzym.Checked Then animation1()
        'CasparCGDataCollection.Clear()

        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games5/rcc/ball/goalsummarywithtime", True, CasparCGDataCollection.ToAMCPEscapedXml)
        'If chkanimationzym.Checked Then animationtoscreen()
        showtemplate("cmp/games5/rcc/ball/goalsummarywithtime", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdpenaltyball_Click(sender As Object, e As EventArgs) Handles cmdpenaltyball.Click
        On Error Resume Next
        'If chkanimationzym.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("ccgf0", txtt1ball.Text)
        CasparCGDataCollection.SetData("ccgf1", txtt2ball.Text)
        CasparCGDataCollection.SetData("ccgf2", txtt1gball.Text)
        CasparCGDataCollection.SetData("ccgf3", txtt2gball.Text)

        CasparCGDataCollection.SetData("ccgloader1", pict1logoball.ImageLocation.Replace("\", "/"))
        CasparCGDataCollection.SetData("ccgloader2", pict2logoball.ImageLocation.Replace("\", "/"))
        showtemplatescore("cmp/games5/rcc/ball/score", CasparCGDataCollection.ToAMCPEscapedXml)

        'CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "cmp/games5/rcc/ball/score", True, CasparCGDataCollection.ToAMCPEscapedXml)
        'If chkanimationzym.Checked Then
        '    If chkanimationforhdvan.Checked Then
        '        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill .1 0 .8 1 50 easeoutexpo")
        '    Else
        '        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill 0 0 1 1 50 easeoutexpo")
        '    End If
        'End If
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "showPenalty('1')" & """")

        With dgvpenaltyball
            For iii = 0 To 4
                If .Rows(0).Cells(iii).Value <> "" Then
                    If .Rows(0).Cells(iii).Value = 0 Then
                        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setCircleColor('ccgpenaltycircle" & iii + 1 & "'," & "'" & ColorTranslator.ToHtml(Color.Red) & "')" & """")
                    Else
                        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setCircleColor('ccgpenaltycircle" & iii + 1 & "'," & "'" & ColorTranslator.ToHtml(Color.Green) & "')" & """")
                    End If

                End If
            Next
            For iii = 0 To 4
                If .Rows(1).Cells(iii).Value <> "" Then
                    If .Rows(1).Cells(iii).Value = 0 Then
                        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setCircleColor('ccgpenaltycircle" & iii + 1 + 5 & "'," & "'" & ColorTranslator.ToHtml(Color.Red) & "')" & """")
                    Else
                        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setCircleColor('ccgpenaltycircle" & iii + 1 + 5 & "'," & "'" & ColorTranslator.ToHtml(Color.Green) & "')" & """")
                    End If

                End If
            Next

        End With

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setTeamcolor('ccgteam1color'," & "'" & ColorTranslator.ToHtml(cmdt1colorball.BackColor) & "')" & """")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setTeamcolor('ccgteam2color'," & "'" & ColorTranslator.ToHtml(cmdt2colorball.BackColor) & "')" & """")

        tmrtimeupdateontemplate.Enabled = False
        tmrupdateontemplateextra.Enabled = False
    End Sub
    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click
        CasparDevice.Connect("localhost", 5250)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CasparDevice.Disconnect()
    End Sub

    'Private Sub CasparDevice_ConnectionStatusChanged(sender As Object, e As Svt.Network.ConnectionEventArgs) Handles CasparDevice.ConnectionStatusChanged
    '    If CasparDevice.IsConnected Then
    '        cmdConnect.BackColor = Color.Green
    '    Else
    '        cmdConnect.BackColor = Color.Red

    '    End If
    '    cmdConnect.ForeColor = Color.White

    'End Sub

    Private Sub cmdPenaltyUpfate_Click(sender As Object, e As EventArgs) Handles cmdPenaltyUpfate.Click
        On Error Resume Next
        With dgvpenaltyball
            For iii = 0 To 4
                If .Rows(0).Cells(iii).Value <> "" Then
                    If .Rows(0).Cells(iii).Value = 0 Then
                        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setCircleColor('ccgpenaltycircle" & iii + 1 & "'," & "'" & ColorTranslator.ToHtml(Color.Red) & "')" & """")
                    Else
                        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setCircleColor('ccgpenaltycircle" & iii + 1 & "'," & "'" & ColorTranslator.ToHtml(Color.Green) & "')" & """")
                    End If
                End If
            Next
            For iii = 0 To 4
                If .Rows(1).Cells(iii).Value <> "" Then
                    If .Rows(1).Cells(iii).Value = 0 Then
                        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setCircleColor('ccgpenaltycircle" & iii + 1 + 5 & "'," & "'" & ColorTranslator.ToHtml(Color.Red) & "')" & """")
                    Else
                        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & Int(cmblayergames.Text) + 1 & " " & """" & "setCircleColor('ccgpenaltycircle" & iii + 1 + 5 & "'," & "'" & ColorTranslator.ToHtml(Color.Green) & "')" & """")
                    End If
                End If
            Next
        End With
    End Sub
End Class
