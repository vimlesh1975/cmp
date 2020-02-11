Imports System.IO
'for tcp
Imports System.Net.Sockets
Imports Svt.Caspar
Public Class ucSG2016

    Private Sub NG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        shootingdefaultdata()
        winnerdefaultdat()
        defautdataforball()
        initialisesetscoreball()
        initialisesetscorett()

        defauttrackdata()
        defautfielddata()
        makedatatypeforsorting(dgvFE, dgvferesult)

        dgvpenaltyball.Rows.Add(2)
        refreshdatacg2()
    End Sub
    Sub defautfielddata()

        With dgvFE
            .Rows.Add(8)

            .Rows(0).Cells(0).Value = 1
            .Rows(0).Cells(1).Value = 452
            .Rows(0).Cells(2).Value = "India"
            .Rows(0).Cells(3).Value = "MOHAMAD ALGARNI"
            .Rows(0).Cells(4).Value = 54.91

            .Rows(1).Cells(0).Value = 2
            .Rows(1).Cells(1).Value = 245
            .Rows(1).Cells(2).Value = "Afganistan"
            .Rows(1).Cells(3).Value = "SANDEEP KARAN SINGH"
            .Rows(1).Cells(4).Value = 32.41

            .Rows(2).Cells(0).Value = 3
            .Rows(2).Cells(1).Value = 632
            .Rows(2).Cells(2).Value = "Pakistan"
            .Rows(2).Cells(3).Value = "EMAD HAMED NOUR"
            .Rows(2).Cells(4).Value = 51.25
            .Rows(2).Cells(5).Value = 3

            .Rows(3).Cells(0).Value = 4
            .Rows(3).Cells(1).Value = 12
            .Rows(3).Cells(2).Value = "Nepal"
            .Rows(3).Cells(3).Value = "RASHEED RAMZI"
            .Rows(3).Cells(4).Value = 12.25

            .Rows(3).Cells(6).Value = 80.25
            .Rows(3).Cells(7).Value = 90.58
            .Rows(3).Cells(8).Value = 11.25
            .Rows(3).Cells(9).Value = 78.0
            .Rows(3).Cells(10).Value = 47.25
            .Rows(3).Cells(11).Value = 33.25

            .Rows(4).Cells(6).Value = "SSR"
            .Rows(4).Cells(7).Value = "SSS"
            .Rows(4).Cells(8).Value = "RSR"
            .Rows(4).Cells(9).Value = "SSS"
            .Rows(4).Cells(10).Value = "R"
            .Rows(4).Cells(11).Value = "SR"
            .Rows(4).Cells(12).Value = "RRR"
            .Rows(4).Cells(13).Value = "SSR"


            .Rows(4).Cells(0).Value = 5
            .Rows(4).Cells(1).Value = 700
            .Rows(4).Cells(2).Value = "Srilanka"
            .Rows(4).Cells(3).Value = "HAMZA DRIOUCH"
            .Rows(4).Cells(4).Value = 52.58

            .Rows(5).Cells(0).Value = 6
            .Rows(5).Cells(1).Value = 796
            .Rows(5).Cells(2).Value = "Bhutan"
            .Rows(5).Cells(3).Value = "RAM PRASAD SAHANI"
            .Rows(5).Cells(4).Value = 54.25
            .Rows(5).Cells(5).Value = 1

            .Rows(6).Cells(0).Value = 7
            .Rows(6).Cells(1).Value = 125
            .Rows(6).Cells(2).Value = "Maldives"
            .Rows(6).Cells(3).Value = "ABDULLAH OBAID"
            .Rows(6).Cells(4).Value = 56.25

            .Rows(7).Cells(0).Value = 8
            .Rows(7).Cells(1).Value = 426
            .Rows(7).Cells(2).Value = "Bangladesh"
            .Rows(7).Cells(3).Value = "VIMLESH KUMAR"
            .Rows(7).Cells(4).Value = 50.0
            .Rows(7).Cells(5).Value = 2

        End With
    End Sub

    Sub defauttrackdata()
        With dgvtrack
            .Rows.Add(8)

            .Rows(0).Cells(0).Value = 1
            .Rows(0).Cells(1).Value = 452
            .Rows(0).Cells(2).Value = "India"
            .Rows(0).Cells(3).Value = "MOHAMAD ALGARNI"
            .Rows(0).Cells(4).Value = 54.91

            .Rows(1).Cells(0).Value = 2
            .Rows(1).Cells(1).Value = 245
            .Rows(1).Cells(2).Value = "Afganistan"
            .Rows(1).Cells(3).Value = "SANDEEP KARAN SINGH"
            .Rows(1).Cells(4).Value = 32.41

            .Rows(2).Cells(0).Value = 3
            .Rows(2).Cells(1).Value = 632
            .Rows(2).Cells(2).Value = "Pakistan"
            .Rows(2).Cells(3).Value = "EMAD HAMED NOUR"
            .Rows(2).Cells(4).Value = 51.25
            .Rows(2).Cells(5).Value = 3

            .Rows(3).Cells(0).Value = 4
            .Rows(3).Cells(1).Value = 12
            .Rows(3).Cells(2).Value = "Nepal"
            .Rows(3).Cells(3).Value = "RASHEED RAMZI"
            .Rows(3).Cells(4).Value = 12.25

            .Rows(4).Cells(0).Value = 5
            .Rows(4).Cells(1).Value = 700
            .Rows(4).Cells(2).Value = "Srilanka"
            .Rows(4).Cells(3).Value = "HAMZA DRIOUCH"
            .Rows(4).Cells(4).Value = 52.58

            .Rows(5).Cells(0).Value = 6
            .Rows(5).Cells(1).Value = 796
            .Rows(5).Cells(2).Value = "Bhutan"
            .Rows(5).Cells(3).Value = "RAM PRASAD SAHANI"
            .Rows(5).Cells(4).Value = 54.25
            .Rows(5).Cells(5).Value = 1

            .Rows(6).Cells(0).Value = 7
            .Rows(6).Cells(1).Value = 125
            .Rows(6).Cells(2).Value = "Maldives"
            .Rows(6).Cells(3).Value = "ABDULLAH OBAID"
            .Rows(6).Cells(4).Value = 56.25

            .Rows(7).Cells(0).Value = 8
            .Rows(7).Cells(1).Value = 426
            .Rows(7).Cells(2).Value = "Bangladesh"
            .Rows(7).Cells(3).Value = "VIMLESH KUMAR"
            .Rows(7).Cells(4).Value = 50.0
            .Rows(7).Cells(5).Value = 2

        End With
    End Sub

    Private Sub initialisesetscorett()
        dgvsetscorett.Rows.Add(2)

        For jsetscorett = 0 To 6
            dgvsetscorett.Rows(0).Cells(jsetscorett).Value = jsetscorett
            dgvsetscorett.Rows(1).Cells(jsetscorett).Value = 6 - jsetscorett
        Next

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
        openimage("C:\casparcg\mydata\games2\games logo\", sender)
    End Sub

    Private Sub eventlogoforgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eventlogo.Click
        On Error Resume Next
        openimage("C:\casparcg\mydata\games2\event logo\", sender)
    End Sub




    Private Sub cmdstopgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopgym.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation2()

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text), Int(cmblayergames.Text))
        Threading.Thread.Sleep(1000)
        If chkanimationzym.Checked Then animationtoscreen()

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
        ElseIf rdoSqueezeIn.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill 0.5 0 0 1 50 easeoutexpo")
            Exit Sub
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
        ElseIf rdoSqueezeout.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill 0.5 0 0 1 50 easeoutexpo")
            Exit Sub
        ElseIf rdoFedOut.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " opacity 0 50 easeoutexpo")
            GoTo 50
        End If
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill " & x & " " & y & " 1 1 50 easeoutexpo")
50:
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdwelcome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdwelcome.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("w1", w1.Text)
        CasparCGDataCollection.SetData("w2", w2.Text)
        CasparCGDataCollection.SetData("w3", w3.Text)

        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/welcome", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmDvenueid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmDvenueid1.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtvenueid1.Text)

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/venue_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub


    Private Sub cmdrefree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrefree.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtrefreename.Text)
        CasparCGDataCollection.SetData("f1", txtrefreedegination.Text)


        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/official_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdcomentator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcomentator.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("w1", txtcommentatordesignation.Text)
        CasparCGDataCollection.SetData("w2", txtcommentatorname1.Text)
        CasparCGDataCollection.SetData("w3", txtcommentatorname2.Text)

        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/commentators", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdMedalPresentorId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMedalPresentorId.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtofficialname.Text)
        CasparCGDataCollection.SetData("f1", txtofficialdesignation.Text)


        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/official_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdp1.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("w1", p1.Text)
        CasparCGDataCollection.SetData("w2", p2.Text)
        CasparCGDataCollection.SetData("w3", p3.Text)

        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/welcome", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub




    Private Sub cmdeventid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeventid.Click

        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", cmbHeader.Text)
        CasparCGDataCollection.SetData("f1", cmbSubHeader.Text)

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/event_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub


    Private Sub cmdeventshedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeventshedule.Click


        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/event_shedule", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdw1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdw1.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/opening", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub piceventcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        Dim picofd As New OpenFileDialog
        picofd.InitialDirectory = "C:\casparcg\mydata\games2\games logo\"
        If (picofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            eventlogo.ImageLocation = picofd.FileName
        End If
    End Sub
    Private Sub shootingdefaultdata()
        On Error Resume Next


        dgvShooting.Rows.Add(8)

        dgvShooting.Rows(0).Cells(0).Value = 1
        dgvShooting.Rows(0).Cells(1).Value = "MOHAMAD ALGARNI"
        dgvShooting.Rows(0).Cells(2).Value = "Afganistan"
        dgvShooting.Rows(0).Cells(3).Value = 54.914

        dgvShooting.Rows(1).Cells(0).Value = 2
        dgvShooting.Rows(1).Cells(1).Value = "SANDEEP KARAN SINGH"
        dgvShooting.Rows(1).Cells(2).Value = "Bangladesh"
        dgvShooting.Rows(1).Cells(3).Value = 32.412

        dgvShooting.Rows(2).Cells(0).Value = 3
        dgvShooting.Rows(2).Cells(1).Value = "EMAD HAMED NOUR"
        dgvShooting.Rows(2).Cells(2).Value = "Bhutan"
        dgvShooting.Rows(2).Cells(3).Value = 51.251

        dgvShooting.Rows(3).Cells(0).Value = 4
        dgvShooting.Rows(3).Cells(1).Value = "RASHEED RAMZI"
        dgvShooting.Rows(3).Cells(2).Value = "India"
        dgvShooting.Rows(3).Cells(3).Value = 12.256

        dgvShooting.Rows(4).Cells(0).Value = 5
        dgvShooting.Rows(4).Cells(1).Value = "HAMZA DRIOUCH"
        dgvShooting.Rows(4).Cells(2).Value = "Maldives"
        dgvShooting.Rows(4).Cells(3).Value = 52.586

        dgvShooting.Rows(5).Cells(0).Value = 6
        dgvShooting.Rows(5).Cells(1).Value = "SANDEEP KARAN SINGH"
        dgvShooting.Rows(5).Cells(2).Value = "Nepal"
        dgvShooting.Rows(5).Cells(3).Value = 54.258

        dgvShooting.Rows(6).Cells(0).Value = 7
        dgvShooting.Rows(6).Cells(1).Value = "ABDULLAH OBAID"
        dgvShooting.Rows(6).Cells(2).Value = "Pakistan"
        dgvShooting.Rows(6).Cells(3).Value = 56.258

        dgvShooting.Rows(7).Cells(0).Value = 8
        dgvShooting.Rows(7).Cells(1).Value = "AMASSRI WESAM"
        dgvShooting.Rows(7).Cells(2).Value = "Srilanka"
        dgvShooting.Rows(7).Cells(3).Value = 52.147

        For i = 0 To dgvShooting.RowCount - 2
            For j = 3 To 28
                dgvShooting.Rows(i).Cells(j).Value = Format(i * j, "00.0")
            Next
        Next

        For i = 0 To dgvShooting.RowCount - 2
            For j = 30 To 31
                dgvShooting.Rows(i).Cells(j).Value = 1
            Next
            For j = 32 To 33
                dgvShooting.Rows(i).Cells(j).Value = 0
            Next
            For j = 34 To 34
                dgvShooting.Rows(i).Cells(j).Value = ""
            Next
            For j = 35 To 35
                dgvShooting.Rows(i).Cells(j).Value = 2
            Next
        Next
    End Sub

    Private Sub cmdShootingstartlist1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShootingstartlist1.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        For i = 0 To dgvShooting.RowCount - 1


            If dgvShooting.Rows(i).Cells(0).Value <> "" Then
                If chkwithnumberShooting.Checked Then
                    CasparCGDataCollection.SetData("sn" & i + 1, i + 1)
                End If
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgvShooting.Rows(i).Cells(2).Value & ".png")
            End If
            CasparCGDataCollection.SetData("name" & i + 1, dgvShooting.Rows(i).Cells(1).Value)
        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparCGDataCollection.SetData("startlist", cmbSubHeader.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/startlist1", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdShootingstartlist2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShootingstartlist2.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        For i = 8 To dgvShooting.RowCount - 1

            If dgvShooting.Rows(i).Cells(0).Value <> "" Then
                If chkwithnumberShooting.Checked Then
                    CasparCGDataCollection.SetData("sn" & i - 7, i + 1)
                End If

                CasparCGDataCollection.SetData("loader" & i - 7, "C:/casparcg/mydata/games2/country/WithName/" & dgvShooting.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i - 7, dgvShooting.Rows(i).Cells(1).Value)
            End If

        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparCGDataCollection.SetData("startlist", cmbSubHeader.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/startlist1", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdplayeridShooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayeridShooting.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvShooting.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("f1", dgvShooting.CurrentRow.Cells(1).Value)

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgvShooting.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/player_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdeventidShooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", cmbHeader.Text)
        CasparCGDataCollection.SetData("f1", cmbSubHeader.Text)

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/Shooting/event_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub


    Private Sub cmdrowinsertShooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowinsertShooting.Click
        On Error Resume Next
        With dgvShooting
            .Rows.Insert(.CurrentRow.Index)
        End With
    End Sub
    Private Sub cmdrowdownShooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowdownShooting.Click
        downsg(dgvShooting)
    End Sub
    Private Sub tsShooting_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsShooting.ItemClicked

    End Sub
    Private Sub cmdrowupShooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowupShooting.Click
        upsg(dgvShooting)
    End Sub
    Private Sub cmdrowdeleteShooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowdeleteShooting.Click
        On Error Resume Next
        With dgvShooting
            .Rows.RemoveAt(.CurrentRow.Index)

        End With
    End Sub

    Private Sub newShooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newShooting.Click
        On Error Resume Next
        dgvShooting.Rows.Clear()
        dgvShooting.Rows.Add(11)
        lblfilenameShooting.Text = "new"
    End Sub

    Private Sub openShooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openShooting.Click
        On Error Resume Next

        opendatasg("C:\casparcg\mydata\games2\shooting\", dgvShooting, cmbHeader, cmbSubHeader, lblfilenameShooting)
    End Sub


    Private Sub saveShooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveShooting.Click
        savedatasg("C:\casparcg\mydata\games2\shooting\", dgvShooting, cmbHeader, cmbSubHeader, lblfilenameShooting)
    End Sub

    Private Sub dgvShooting_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvShooting.CellContentClick

    End Sub

    Private Sub dgvShooting_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvShooting.CellValueChanged
        On Error Resume Next
        Dim aa As Double = 0.0
        With dgvShooting

            For i = 4 To 28
                aa = Format(aa + Val(.Rows(e.RowIndex).Cells(i).Value), "0.00")
            Next
            .Rows(e.RowIndex).Cells(29).Value = aa

        End With
    End Sub

    Private Sub dgvwinner_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvwinner.CellContentClick

    End Sub

    Private Sub dgvwinner_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvwinner.CellDoubleClick
        On Error Resume Next
        If e.ColumnIndex = 0 Then
            Dim aa As New OpenFileDialog
            aa.InitialDirectory = "C:\casparcg\mydata\games2\country\withname\"
            If aa.ShowDialog = Windows.Forms.DialogResult.OK Then
                With dgvwinner
                    .Rows(e.RowIndex).Cells(0).Value = System.Drawing.Image.FromFile(aa.FileName)
                    .Rows(e.RowIndex).Cells(1).Value = UCase(Split(aa.SafeFileName, ".")(0))
                    .Rows(e.RowIndex).Cells(2).Value = aa.FileName
                End With
                aa.Dispose()
            End If
        End If
    End Sub

    Private Sub dgvwinner_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvwinner.DataError
        'dummy code don't delete
    End Sub

    Private Sub winnerdefaultdat()
        On Error Resume Next

        With dgvwinner
            .Rows.Add(8)

            .Rows(0).Cells(0).Value = Image.FromFile("C:\casparcg\mydata\games2\country\withname\Afganistan.png")
            .Rows(0).Cells(1).Value = "Afganistan"
            .Rows(0).Cells(2).Value = "C:\casparcg\mydata\games2\country\withname\Afganistan.png"

            .Rows(1).Cells(0).Value = Image.FromFile("C:\casparcg\mydata\games2\country\withname\Bangladesh.png")
            .Rows(1).Cells(1).Value = "Bangladesh"
            .Rows(1).Cells(2).Value = "C:\casparcg\mydata\games2\country\withname\Bangladesh.png"

            .Rows(2).Cells(0).Value = Image.FromFile("C:\casparcg\mydata\games2\country\withname\Bhutan.png")
            .Rows(2).Cells(1).Value = "Bhutan"
            .Rows(2).Cells(2).Value = "C:\casparcg\mydata\games2\country\withname\Bhutan.png"

            .Rows(3).Cells(0).Value = Image.FromFile("C:\casparcg\mydata\games2\country\withname\India.png")
            .Rows(3).Cells(1).Value = "India"
            .Rows(3).Cells(2).Value = "C:\casparcg\mydata\games2\country\withname\India.png"



            .Rows(4).Cells(0).Value = Image.FromFile("C:\casparcg\mydata\games2\country\withname\Maldives.png")
            .Rows(4).Cells(1).Value = "Maldives"
            .Rows(4).Cells(2).Value = "C:\casparcg\mydata\games2\country\withname\Maldives.png"

            .Rows(5).Cells(0).Value = Image.FromFile("C:\casparcg\mydata\games2\country\withname\Nepal.png")
            .Rows(5).Cells(1).Value = "Nepal"
            .Rows(5).Cells(2).Value = "C:\casparcg\mydata\games2\country\withname\Nepal.png"



            .Rows(6).Cells(0).Value = Image.FromFile("C:\casparcg\mydata\games2\country\withname\Pakistan.png")
            .Rows(6).Cells(1).Value = "Pakistan"
            .Rows(6).Cells(2).Value = "C:\casparcg\mydata\games2\country\withname\Pakistan.png"

            .Rows(7).Cells(0).Value = Image.FromFile("C:\casparcg\mydata\games2\country\withname\Srilanka.png")
            .Rows(7).Cells(1).Value = "Srilanka"
            .Rows(7).Cells(2).Value = "C:\casparcg\mydata\games2\country\withname\Srilanka.png"



        End With
    End Sub

    Private Sub cmdRoadToSemiFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRoadToSemiFinal.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbheadercg.Text)
        CasparCGDataCollection.SetData("header2", "Road To SemiFinal- " & cmbsubheadercg.Text)
        For i = 0 To 7
            CasparCGDataCollection.SetData("loader" & i + 1, dgvwinner.Rows(i).Cells(2).Value)
            CasparCGDataCollection.SetData("name" & i + 1, dgvwinner.Rows(i).Cells(1).Value)
        Next

        If rdo0.Checked Then
            CasparCGDataCollection.SetData("loader9", dgvwinner.Rows(0).Cells(2).Value)
            CasparCGDataCollection.SetData("name9", dgvwinner.Rows(0).Cells(1).Value)
        Else
            CasparCGDataCollection.SetData("loader9", dgvwinner.Rows(1).Cells(2).Value)
            CasparCGDataCollection.SetData("name9", dgvwinner.Rows(1).Cells(1).Value)
        End If

        If rdo2.Checked Then
            CasparCGDataCollection.SetData("loader10", dgvwinner.Rows(2).Cells(2).Value)
            CasparCGDataCollection.SetData("name10", dgvwinner.Rows(2).Cells(1).Value)
        Else
            CasparCGDataCollection.SetData("loader10", dgvwinner.Rows(3).Cells(2).Value)
            CasparCGDataCollection.SetData("name10", dgvwinner.Rows(3).Cells(1).Value)
        End If

        If rdo4.Checked Then
            CasparCGDataCollection.SetData("loader11", dgvwinner.Rows(4).Cells(2).Value)
            CasparCGDataCollection.SetData("name11", dgvwinner.Rows(4).Cells(1).Value)
        Else
            CasparCGDataCollection.SetData("loader11", dgvwinner.Rows(5).Cells(2).Value)
            CasparCGDataCollection.SetData("name11", dgvwinner.Rows(5).Cells(1).Value)
        End If

        If rdo6.Checked Then
            CasparCGDataCollection.SetData("loader12", dgvwinner.Rows(6).Cells(2).Value)
            CasparCGDataCollection.SetData("name12", dgvwinner.Rows(6).Cells(1).Value)
        Else
            CasparCGDataCollection.SetData("loader12", dgvwinner.Rows(7).Cells(2).Value)
            CasparCGDataCollection.SetData("name12", dgvwinner.Rows(7).Cells(1).Value)
        End If
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)


        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/RoadToSemiFinal", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdeventidcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", cmbHeader.Text)
        CasparCGDataCollection.SetData("f1", cmbSubHeader.Text)

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/event_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdgoldcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgoldcg.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", cmbsubheadercg.Text)
        CasparCGDataCollection.SetData("f1", dgvwinner.Rows(0).Cells(1).Value)

        CasparCGDataCollection.SetData("loader1", dgvwinner.Rows(0).Cells(2).Value)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/medal_g", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdsilvercg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsilvercg.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", cmbsubheadercg.Text)
        CasparCGDataCollection.SetData("f1", dgvwinner.Rows(1).Cells(1).Value)

        CasparCGDataCollection.SetData("loader1", dgvwinner.Rows(1).Cells(2).Value)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/medal_s", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdbronzecg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbronzecg.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", cmbsubheadercg.Text)
        CasparCGDataCollection.SetData("f1", dgvwinner.Rows(2).Cells(1).Value)

        CasparCGDataCollection.SetData("loader1", dgvwinner.Rows(2).Cells(2).Value)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/medal_b", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdbronze2cg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbronze2cg.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", cmbsubheadercg.Text)
        CasparCGDataCollection.SetData("f1", dgvwinner.Rows(3).Cells(1).Value)

        CasparCGDataCollection.SetData("loader1", dgvwinner.Rows(3).Cells(2).Value)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/medal_b2", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdvictoryidcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdvictoryidcg.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", cmbsubheadercg.Text)
        CasparCGDataCollection.SetData("f1", "Victory Ceremony")
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/victory_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdrunnerupridcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrunnerupridcg.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("h1", cmbheadercg.Text)
        If rdosinglecg.Checked Then
            CasparCGDataCollection.SetData("h2", "Runner Up-" & cmbsubheadercg.Text)
        Else
            CasparCGDataCollection.SetData("h2", "Runners Up-" & cmbsubheadercg.Text)
        End If


        CasparCGDataCollection.SetData("t1", dgvwinner.Rows(1).Cells(1).Value)


        CasparCGDataCollection.SetData("loader1", dgvwinner.Rows(1).Cells(2).Value)

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg//winner", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdwinneridcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdwinneridcg.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("h1", cmbheadercg.Text)
        If rdosinglecg.Checked Then
            CasparCGDataCollection.SetData("h2", "Winner-" & cmbsubheadercg.Text)
        Else
            CasparCGDataCollection.SetData("h2", "Winners-" & cmbsubheadercg.Text)
        End If


        CasparCGDataCollection.SetData("t1", dgvwinner.Rows(0).Cells(1).Value)


        CasparCGDataCollection.SetData("loader1", dgvwinner.Rows(0).Cells(2).Value)

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/winner", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdmedalallcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmedalallcg.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("h1", cmbheadercg.Text)
        CasparCGDataCollection.SetData("h2", cmbsubheadercg.Text)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        For imedalall = 0 To 2
            CasparCGDataCollection.SetData("t" & imedalall + 1, dgvwinner.Rows(imedalall).Cells(1).Value)
            CasparCGDataCollection.SetData("loader" & imedalall + 1, dgvwinner.Rows(imedalall).Cells(2).Value)
        Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/medal_three", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdmedalallbronze2cg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmedalallbronze2cg.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()


        CasparCGDataCollection.Clear()


        CasparCGDataCollection.SetData("h1", cmbheadercg.Text)
        CasparCGDataCollection.SetData("h2", cmbsubheadercg.Text)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        For imedalall = 0 To 3
            CasparCGDataCollection.SetData("t" & imedalall + 1, dgvwinner.Rows(imedalall).Cells(1).Value)
            CasparCGDataCollection.SetData("loader" & imedalall + 1, dgvwinner.Rows(imedalall).Cells(2).Value)
        Next


        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/medal_three_bronze2", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()

    End Sub
    Private Sub cmdplayeridcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayeridcg.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvwinner.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("f1", dgvwinner.CurrentRow.Cells(1).Value)

        CasparCGDataCollection.SetData("loader1", dgvwinner.CurrentRow.Cells(2).Value)
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/player_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub


    Private Sub cmdplayerqualification_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayerqualification.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        With dgvShooting
            CasparCGDataCollection.SetData("f1", .CurrentRow.Cells(1).Value)
            CasparCGDataCollection.SetData("f2", .CurrentRow.Cells(3).Value)


            If chkwithnumberShooting.Checked Then
                CasparCGDataCollection.SetData("f3", .CurrentRow.Cells(0).Value)
                CasparCGDataCollection.SetData("alpha", 1)
            Else
                CasparCGDataCollection.SetData("f3", "")
                CasparCGDataCollection.SetData("alpha", 0)
            End If


            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & .CurrentRow.Cells(2).Value & ".png")
            CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
            CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/shooting/player_score", True, CasparCGDataCollection.ToAMCPEscapedXml)
            If chkanimationzym.Checked Then animationtoscreen()
        End With
    End Sub

    Private Sub cmdresult1Shooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresult1Shooting.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        For i = 0 To 7
            If dgvShooting.Rows(i).Cells(0).Value <> "" Then
                CasparCGDataCollection.SetData("sn" & i + 1, i + 1)
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgvShooting.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i + 1, dgvShooting.Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("value" & i + 1, dgvShooting.Rows(i).Cells(CType(cmbstandingsShooting.Text, Integer)).Value)
                CasparCGDataCollection.SetData("alpha" & i + 1, 1)
            End If
        Next

        For j As Integer = 0 To Int(txteleminationshooting.Text)
            CasparCGDataCollection.SetData("alpha" & (17 - j), 1)
        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparCGDataCollection.SetData("startlist", cmbSubHeader.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/result1", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdplayerscorecardShooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayerscorecardShooting.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        With dgvShooting
            CasparCGDataCollection.SetData("f0", .CurrentRow.Cells(1).Value)
            ' CasparCGDataCollection.SetData("f1", .Columns(3).HeaderText & " " & .CurrentRow.Cells(3).Value & "                          " & .Columns(24).HeaderText & " " & .CurrentRow.Cells(29).Value)
            CasparCGDataCollection.SetData("f2", "Score " & .CurrentRow.Cells(29).Value)
            Dim str As String = ""
            For i = 4 To 13
                str = str + .CurrentRow.Cells(i).Value + "    "
            Next
            CasparCGDataCollection.SetData("score10", str)

            If chkwithnumberShooting.Checked Then
                CasparCGDataCollection.SetData("f3", .CurrentRow.Cells(0).Value)
                CasparCGDataCollection.SetData("alpha", 1)
            Else
                CasparCGDataCollection.SetData("f3", "")
                CasparCGDataCollection.SetData("alpha", 0)
            End If


            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & .CurrentRow.Cells(2).Value & ".png")
            CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/shooting/PlayerScorecard", True, CasparCGDataCollection.ToAMCPEscapedXml)

            If chkanimationzym.Checked Then animationtoscreen()
        End With
    End Sub

    Private Sub cmdplayerscorecard2Shooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayerscorecard2Shooting.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        With dgvShooting
            CasparCGDataCollection.SetData("f0", .CurrentRow.Cells(1).Value)
            ' CasparCGDataCollection.SetData("f1", .Columns(3).HeaderText & " " & .CurrentRow.Cells(3).Value & "                          " & .Columns(24).HeaderText & " " & .CurrentRow.Cells(29).Value)
            CasparCGDataCollection.SetData("f2", "Score " & .CurrentRow.Cells(29).Value)
            Dim str10 As String = ""
            For i = 4 To 13
                str10 = str10 + .CurrentRow.Cells(i).Value + "    "
            Next
            CasparCGDataCollection.SetData("score10", str10)

            Dim str20 As String = ""
            For i = 14 To 23
                str20 = str20 + .CurrentRow.Cells(i).Value + "    "
            Next
            CasparCGDataCollection.SetData("score20", str20)

            If chkwithnumberShooting.Checked Then
                CasparCGDataCollection.SetData("f3", .CurrentRow.Cells(0).Value)
                CasparCGDataCollection.SetData("alpha", 1)
            Else
                CasparCGDataCollection.SetData("f3", "")
                CasparCGDataCollection.SetData("alpha", 0)
            End If


            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & .CurrentRow.Cells(2).Value & ".png")
            CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/shooting/PlayerScorecard2", True, CasparCGDataCollection.ToAMCPEscapedXml)

            If chkanimationzym.Checked Then animationtoscreen()
        End With
    End Sub



    Private Sub cmdtop3standingsShooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtop3standingsShooting.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        With dgvShooting
            For i = 0 To 2

                If .Rows(i).Cells(0).Value <> "" Then
                    CasparCGDataCollection.SetData("sn" & i + 1, i + 1)
                    CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & .Rows(i).Cells(2).Value & ".png")
                    CasparCGDataCollection.SetData("name" & i + 1, .Rows(i).Cells(1).Value)
                    CasparCGDataCollection.SetData("value" & i + 1, .Rows(i).Cells(CType(cmbstandingsShooting.Text, Integer)).Value)

                End If

            Next
            CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
            CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

            CasparCGDataCollection.SetData("startlist", "Top Three- " & cmbSubHeader.Text)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/resultthree", True, CasparCGDataCollection.ToAMCPEscapedXml)
        End With
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdplayergamepointShooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayergamepointShooting.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        With dgvShooting
            CasparCGDataCollection.SetData("f1", .CurrentRow.Cells(1).Value)
            CasparCGDataCollection.SetData("f2", txtaftershots.Text)
            CasparCGDataCollection.SetData("f3", .CurrentRow.Cells(CType(cmbplayergamepointShooting.Text, Integer)).Value)

            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & .CurrentRow.Cells(2).Value & ".png")
            CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
            CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/shooting/player_any_score", True, CasparCGDataCollection.ToAMCPEscapedXml)

        End With
        If chkanimationzym.Checked Then animationtoscreen()
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

    Private Sub cmdseries1shooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries1shooting.Click
        On Error Resume Next
        seriestemplate("Series 1", 4, 5, "cmp/games2/shooting/series_score1", 6)
    End Sub

    Private Sub cmdseries2shooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries2shooting.Click
        On Error Resume Next
        seriestemplate("Series 2", 7, 8, "cmp/games2/shooting/series_score1", 9)
    End Sub

    Private Sub cmdseries3shooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries3shooting.Click
        On Error Resume Next
        seriestemplate("Series 3", 10, 11, "cmp/games2/shooting/series_score2")
    End Sub

    Private Sub cmdseries4shooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries4shooting.Click
        On Error Resume Next
        seriestemplate("Series 4", 12, 13, "cmp/games2/shooting/series_score2")
    End Sub

    Private Sub cmdseries5shooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries5shooting.Click
        On Error Resume Next
        seriestemplate("Series 5", 14, 15, "cmp/games2/shooting/series_score2")
    End Sub

    Private Sub cmdseries6shooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries6shooting.Click
        On Error Resume Next
        seriestemplate("Series 6", 16, 17, "cmp/games2/shooting/series_score2")
    End Sub

    Private Sub cmdseries7shooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries7shooting.Click
        On Error Resume Next
        seriestemplate("Series 7", 18, 19, "cmp/games2/shooting/series_score2")

    End Sub

    Private Sub cmdseries8shooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries8shooting.Click
        On Error Resume Next
        seriestemplate("Series 8", 20, 21, "cmp/games2/shooting/series_score2")
    End Sub

    Private Sub cmdseries9shooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries9shooting.Click
        On Error Resume Next
        seriestemplate("Series 9", 22, 23, "cmp/games2/shooting/series_score2")
    End Sub
    Sub seriestemplate(ByVal seriesname As String, ByVal col1 As Integer, ByVal col2 As Integer, ByVal templatename As String, Optional ByVal col3 As Integer = 0)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        With dgvShooting

            CasparCGDataCollection.SetData("f1", cmbHeader.Text)

            CasparCGDataCollection.SetData("f0", .CurrentRow.Cells(1).Value)
            CasparCGDataCollection.SetData("f2", seriesname)
            CasparCGDataCollection.SetData("f3", .CurrentRow.Cells(col1).Value)
            CasparCGDataCollection.SetData("f4", .CurrentRow.Cells(col2).Value)
            CasparCGDataCollection.SetData("f5", .CurrentRow.Cells(col3).Value)
            CasparCGDataCollection.SetData("f6", .CurrentRow.Cells(29).Value)

            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & .CurrentRow.Cells(2).Value & ".png")

            CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
            CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), templatename, True, CasparCGDataCollection.ToAMCPEscapedXml)
            If chkanimationzym.Checked Then animationtoscreen()
        End With
    End Sub
    Sub seriestemplate25m(ByVal seriesname As String, ByVal col1 As Integer, ByVal col2 As Integer, ByVal col3 As Integer, ByVal col4 As Integer, ByVal col5 As Integer, ByVal templatename As String)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        With dgvShooting
            CasparCGDataCollection.SetData("f0", .CurrentRow.Cells(1).Value)
            CasparCGDataCollection.SetData("f1", seriesname)
            CasparCGDataCollection.SetData("f2", .CurrentRow.Cells(29).Value)

            If .CurrentRow.Cells(col1).Value <> "" Then
                CasparCGDataCollection.SetData("g1", .CurrentRow.Cells(col1).Value)
                CasparCGDataCollection.SetData("r1", 1 - .CurrentRow.Cells(col1).Value)
            End If
            If .CurrentRow.Cells(col2).Value <> "" Then
                CasparCGDataCollection.SetData("g2", .CurrentRow.Cells(col2).Value)
                CasparCGDataCollection.SetData("r2", 1 - .CurrentRow.Cells(col2).Value)
            End If
            If .CurrentRow.Cells(col3).Value <> "" Then
                CasparCGDataCollection.SetData("g3", .CurrentRow.Cells(col3).Value)
                CasparCGDataCollection.SetData("r3", 1 - .CurrentRow.Cells(col3).Value)
            End If
            If .CurrentRow.Cells(col4).Value <> "" Then
                CasparCGDataCollection.SetData("g4", .CurrentRow.Cells(col4).Value)
                CasparCGDataCollection.SetData("r4", 1 - .CurrentRow.Cells(col4).Value)
            End If
            If .CurrentRow.Cells(col5).Value <> "" Then
                CasparCGDataCollection.SetData("g5", .CurrentRow.Cells(col5).Value)
                CasparCGDataCollection.SetData("r5", 1 - .CurrentRow.Cells(col5).Value)
            End If

            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & .CurrentRow.Cells(2).Value & ".png")
            CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), templatename, True, CasparCGDataCollection.ToAMCPEscapedXml)
            If chkanimationzym.Checked Then animationtoscreen()
        End With
    End Sub
    Private Sub cmdseries1shooting25m_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries1shooting25m.Click
        On Error Resume Next
        seriestemplate25m("Series 1", 4, 5, 6, 7, 8, "cmp/games2/shooting/series_score25m")
    End Sub

    Private Sub cmdseries2shooting25m_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries2shooting25m.Click
        On Error Resume Next
        seriestemplate25m("Series 2", 9, 10, 11, 12, 13, "cmp/games2/shooting/series_score25m")

    End Sub

    Private Sub cmdseries3shooting25m_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries3shooting25m.Click
        On Error Resume Next
        seriestemplate25m("Series 3", 14, 15, 16, 17, 18, "cmp/games2/shooting/series_score25m")

    End Sub

    Private Sub cmdseries4shooting25m_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries4shooting25m.Click
        On Error Resume Next
        seriestemplate25m("Series 4", 19, 20, 21, 22, 23, "cmp/games2/shooting/series_score25m")

    End Sub

    Private Sub cmdseries5shooting25m_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries5shooting25m.Click
        On Error Resume Next
        seriestemplate25m("Series 5", 24, 25, 26, 27, 28, "cmp/games2/shooting/series_score25m")

    End Sub
    Private Sub cmdmedalmatchshooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmedalmatchshooting.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", cmbHeader.Text)
        CasparCGDataCollection.SetData("f1", cmbSubHeader.Text)

        CasparCGDataCollection.SetData("f2", dgvShooting.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("f3", dgvShooting.Rows(dgvShooting.CurrentRow.Index + 1).Cells(1).Value)

        CasparCGDataCollection.SetData("f4", dgvShooting.CurrentRow.Cells(35).Value)
        CasparCGDataCollection.SetData("f5", dgvShooting.Rows(dgvShooting.CurrentRow.Index + 1).Cells(35).Value)

        With dgvShooting
            For i = 30 To 34
                If .CurrentRow.Cells(i).Value <> "" Then
                    CasparCGDataCollection.SetData("g" & i - 29, .CurrentRow.Cells(i).Value)
                    CasparCGDataCollection.SetData("r" & i - 29, 1 - .CurrentRow.Cells(i).Value)
                End If
                If .Rows(.CurrentRow.Index + 1).Cells(i).Value <> "" Then
                    CasparCGDataCollection.SetData("g" & i - 24, .Rows(.CurrentRow.Index + 1).Cells(i).Value)
                    CasparCGDataCollection.SetData("r" & i - 24, 1 - .Rows(.CurrentRow.Index + 1).Cells(i).Value)
                End If
            Next
        End With

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgvShooting.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader2", "C:/casparcg/mydata/games2/country/WithName/" & dgvShooting.Rows(dgvShooting.CurrentRow.Index + 1).Cells(2).Value & ".png")


        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/Shooting/medalMatch", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()
    End Sub


    Private Sub cmdShootoffshooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShootoffshooting.Click
        On Error Resume Next
        seriestemplate25m("Shoot-Off", 30, 31, 32, 33, 34, "cmp/games2/shooting/Shootoffshooting25")
        CasparCGDataCollection.SetData("f3", "+" & dgvShooting.CurrentRow.Cells(35).Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)


    End Sub

    Private Sub cmdroadtofinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdroadtofinal.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbheadercg.Text)
        CasparCGDataCollection.SetData("header2", "Road To Final- " & cmbsubheadercg.Text)
        For i = 0 To 3
            CasparCGDataCollection.SetData("loader" & i + 1, dgvwinner.Rows(i).Cells(2).Value)
            CasparCGDataCollection.SetData("name" & i + 1, dgvwinner.Rows(i).Cells(1).Value)
        Next

        If rdo0.Checked Then
            CasparCGDataCollection.SetData("loader9", dgvwinner.Rows(0).Cells(2).Value)
            CasparCGDataCollection.SetData("name9", dgvwinner.Rows(0).Cells(1).Value)
        Else
            CasparCGDataCollection.SetData("loader9", dgvwinner.Rows(1).Cells(2).Value)
            CasparCGDataCollection.SetData("name9", dgvwinner.Rows(1).Cells(1).Value)
        End If

        If rdo2.Checked Then
            CasparCGDataCollection.SetData("loader10", dgvwinner.Rows(2).Cells(2).Value)
            CasparCGDataCollection.SetData("name10", dgvwinner.Rows(2).Cells(1).Value)
        Else
            CasparCGDataCollection.SetData("loader10", dgvwinner.Rows(3).Cells(2).Value)
            CasparCGDataCollection.SetData("name10", dgvwinner.Rows(3).Cells(1).Value)
        End If

        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)


        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/RoadToFinal", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()
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
        txtt1ball.Text = openimage("C:\casparcg\mydata\games2\country\withname\", sender)
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
        Return Split(picofd.SafeFileName, ".")(0)
    End Function

    Private Sub pict2logoball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pict2logoball.Click
        On Error Resume Next
        txtt2ball.Text = openimage("C:\casparcg\mydata\games2\country\withname\", sender)
    End Sub

    Private Sub cmdscoreball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscoreball.Click
        On Error Resume Next

        If chkanimationzym.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtt1ball.Text)
        CasparCGDataCollection.SetData("f1", txtt2ball.Text)
        CasparCGDataCollection.SetData("f2", txtt1gball.Text)
        CasparCGDataCollection.SetData("f3", txtt2gball.Text)
        CasparCGDataCollection.SetData("time", txtminball.Text & ":" & txtsecball.Text)
        CasparCGDataCollection.SetData("f5", cmbhalfball.Text)

        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader6", pict2logoball.ImageLocation)

        CasparCGDataCollection.SetData("mc1", "0")
        CasparCGDataCollection.SetData("mc2", "0")


        CasparCGDataCollection.SetData("team1color", cmdt1colorball.BackColor.ToArgb)
        CasparCGDataCollection.SetData("team2color", cmdt2colorball.BackColor.ToArgb)



        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "cmp/games2/ball/score", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then
            If chkanimationforhdvan.Checked Then
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill .1 0 .8 1 50 easeoutexpo")

            Else
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill 0 0 1 1 50 easeoutexpo")

            End If

        End If
        tmrtimeupdateontemplate.Enabled = False
        tmrupdateontemplateextra.Enabled = False
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
        CasparCGDataCollection.SetData("time", txtminball.Text & ":" & txtsecball.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, CasparCGDataCollection)

    End Sub

    Private Sub tmrupdateontemplateextra_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrupdateontemplateextra.Tick
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("time", txthalftimeball.Text & ":00")
        CasparCGDataCollection.SetData("extra", txtminball.Text & ":" & txtsecball.Text)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, CasparCGDataCollection)
    End Sub

    Private Sub cmdscorewithextraball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscorewithextraball.Click
        On Error Resume Next

        If chkanimationzym.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtt1ball.Text)
        CasparCGDataCollection.SetData("f1", txtt2ball.Text)
        CasparCGDataCollection.SetData("f2", txtt1gball.Text)
        CasparCGDataCollection.SetData("f3", txtt2gball.Text)

        CasparCGDataCollection.SetData("time", txthalftimeball.Text & ":00")
        CasparCGDataCollection.SetData("extra", txtminball.Text & ":" & txtsecball.Text)

        CasparCGDataCollection.SetData("f5", cmbhalfball.Text)

        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader6", pict2logoball.ImageLocation)


        CasparCGDataCollection.SetData("mc1", "1")
        CasparCGDataCollection.SetData("mc2", "0")


        CasparCGDataCollection.SetData("extraalpha", "1")


        CasparCGDataCollection.SetData("team1color", cmdt1colorball.BackColor.ToArgb)
        CasparCGDataCollection.SetData("team2color", cmdt2colorball.BackColor.ToArgb)


        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "cmp/games2/ball/score", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then
            If chkanimationforhdvan.Checked Then
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill .1 0 .8 1 50 easeoutexpo")

            Else
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill 0 0 1 1 50 easeoutexpo")

            End If

        End If
        tmrtimeupdateontemplate.Enabled = False
        tmrupdateontemplateextra.Enabled = True
    End Sub

    Private Sub cmdstopscoreball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopscoreball.Click
        On Error Resume Next
        If chkanimationzym.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1)
        Threading.Thread.Sleep(2000)
        If chkanimationzym.Checked Then
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
            CasparCGDataCollection.SetData("f" & i, dgvt1ball.Rows(i).Cells(0).Value)
        Next
        CasparCGDataCollection.SetData("header", txtt1ball.Text)
        CasparCGDataCollection.SetData("subheader", "Starting Lineup")
        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/ball/teamlineup", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub



    Private Sub cmdt2lineupball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2lineupball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        For i = 0 To 22
            CasparCGDataCollection.SetData("f" & i, dgvt2ball.Rows(i).Cells(0).Value)
        Next
        CasparCGDataCollection.SetData("header", txtt2ball.Text)
        CasparCGDataCollection.SetData("subheader", "Starting Lineup")
        CasparCGDataCollection.SetData("loader1", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/ball/teamlineup", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Sub showtemplate(ByVal templatename As String, ByVal datacollection As String)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), templatename, True, datacollection)
        If chkanimationzym.Checked Then animationtoscreen()
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
        CasparCGDataCollection.SetData("f0", dgvt1ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/ball/yellow_card", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdt2yball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2yball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("loader1", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/ball/yellow_card", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdt1rball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt1rball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvt1ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/ball/red_card", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdt1gball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt1gball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvt1ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/ball/goal", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdt2rball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2rball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("loader1", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/ball/red_card", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdt2gball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2gball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("loader1", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/ball/goal", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdt1inoutball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt1inoutball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtt1inball.Text)
        CasparCGDataCollection.SetData("f1", txtt1outball.Text)
        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/ball/in_out", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdt2inoutball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2inoutball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtt2inball.Text)
        CasparCGDataCollection.SetData("f1", txtt2outball.Text)
        CasparCGDataCollection.SetData("loader1", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/ball/in_out", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdteam2inball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteam2inball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtt2inball.Text)
        CasparCGDataCollection.SetData("f1", txtt2outball.Text)
        CasparCGDataCollection.SetData("loader1", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/ball/in", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdteam1inball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteam1inball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtt1inball.Text)
        CasparCGDataCollection.SetData("f1", txtt1outball.Text)
        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/ball/in", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub


    Private Sub cmdteam2outball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteam2outball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", txtt2outball.Text)
        CasparCGDataCollection.SetData("loader1", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/ball/out", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdteam1outball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteam1outball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", txtt1outball.Text)
        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/ball/out", CasparCGDataCollection.ToAMCPEscapedXml)




    End Sub

    Private Sub cmdvsball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdvsball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", cmbHeader.Text)
        CasparCGDataCollection.SetData("f1", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("f2", txtt1ball.Text)
        CasparCGDataCollection.SetData("f3", txtt2ball.Text)

        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/cg/versus", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub


    Private Sub cmdsavet1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsavet1ball.Click
        On Error Resume Next
        savedatasg("C:\casparcg\mydata\games2\ball\", dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)
    End Sub

    Private Sub cmdnewt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnewt1ball.Click
        On Error Resume Next
        newdatasg(dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)
    End Sub

    Private Sub cmdopent1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdopent1ball.Click
        On Error Resume Next
        opendatasg("C:\casparcg\mydata\games2\ball\", dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)

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
        opendatasg("C:\casparcg\mydata\games2\ball\", dgvt2ball, cmbHeader, cmbSubHeader, lblfilenamet2ball)

    End Sub

    Private Sub cmdsavet2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsavet2ball.Click
        On Error Resume Next
        savedatasg("C:\casparcg\mydata\games2\ball\", dgvt2ball, cmbHeader, cmbSubHeader, lblfilenamet2ball)

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
    Private Sub cmdeventidcg_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeventidcg.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", cmbheadercg.Text)
        CasparCGDataCollection.SetData("f1", cmbsubheadercg.Text)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/cg/event_id", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdplayeridt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayeridt1ball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f1", dgvt1ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        showtemplate("cmp/games2/cg/player_id", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdplayeridt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayeridt2ball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f1", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("loader1", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        showtemplate("cmp/games2/cg/player_id", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdtteamridt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtteamridt1ball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f1", txtt1ball.Text)
        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        showtemplate("cmp/games2/cg/player_id", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdtteamridt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtteamridt2ball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f1", txtt2ball.Text)
        CasparCGDataCollection.SetData("loader1", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        showtemplate("cmp/games2/cg/player_id", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmd2refereescg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2refereescg.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", cmbheadercg.Text)
        CasparCGDataCollection.SetData("f1", cmbsubheadercg.Text)
        CasparCGDataCollection.SetData("f2", dgvwinner.Rows(0).Cells(1).Value)
        CasparCGDataCollection.SetData("f3", dgvwinner.Rows(1).Cells(1).Value)

        CasparCGDataCollection.SetData("loader1", dgvwinner.Rows(0).Cells(2).Value)
        CasparCGDataCollection.SetData("loader2", dgvwinner.Rows(1).Cells(2).Value)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/cg/versus", CasparCGDataCollection.ToAMCPEscapedXml)

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
        CasparCGDataCollection.SetData("f2", txtt1gball.Text)
        CasparCGDataCollection.SetData("f3", txtt2gball.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, CasparCGDataCollection)

    End Sub

    Private Sub cmdgoalSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgoalSummary.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", cmbgoalsummary.Text)
        CasparCGDataCollection.SetData("f1", txtt1gball.Text & "-" & txtt2gball.Text)

        CasparCGDataCollection.SetData("f2", txtt1ball.Text)
        CasparCGDataCollection.SetData("f3", txtt2ball.Text)

        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2logoball.ImageLocation)

        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)

        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        showtemplate("cmp/games2/ball/Goal_Summary", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdgroupcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgroupcg.Click
        On Error Resume Next


        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbheadercg.Text)

        For i = 0 To 7
            CasparCGDataCollection.SetData("loader" & i + 1, dgvwinner.Rows(i).Cells(2).Value)
            CasparCGDataCollection.SetData("name" & i + 1, dgvwinner.Rows(i).Cells(1).Value)
        Next

        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)


        showtemplate("cmp/games2/cg/group", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub tsnewcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsnewcg.Click
        On Error Resume Next
        newdatasg(dgvwinner, cmbheadercg, cmbsubheadercg, lblfilenamecg)
    End Sub

    Private Sub tsopencg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsopencg.Click
        On Error Resume Next
        'opendatasg("C:\casparcg\mydata\games2\cg\", dgvwinner, cmbheadercg, cmbsubheadercg, lblfilenamecg)
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog

        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = "C:\casparcg\mydata\games2\cg\"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)
                'clear list
                dgvwinner.Rows.Clear()
                'Loop through and add list to the file.
                Dim g As Integer = 0
                Dim li As String = ""

                li = sr.ReadLine()
                cmbheadercg.Text = Split(li, ",")(0)
                cmbsubheadercg.Text = Split(li, ",")(1)

                li = ""
                li = sr.ReadLine()
                For i = 0 To dgvwinner.ColumnCount - 1
                    dgvwinner.Columns(i).HeaderText = Split(li, ",")(i)
                Next

                li = ""
                Do Until sr.EndOfStream
                    li = sr.ReadLine()
                    dgvwinner.Rows.Add()
                    Dim xyz As Array = Split(li, ",")
                    For k = 0 To dgvwinner.ColumnCount - 1

                        If k = 0 Then
                            dgvwinner.Rows(g).Cells(k).Value = System.Drawing.Image.FromFile(xyz(k))

                        Else
                            dgvwinner.Rows(g).Cells(k).Value = xyz(k)
                        End If

                    Next
                    g = g + 1
                Loop
                sr.Close()
            End Using
            lblfilenamecg.Text = ofd2.FileName
        End If
    End Sub

    Private Sub tssavecg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssavecg.Click
        On Error Resume Next
        'savedatasg("C:\casparcg\mydata\games2\cg\", dgvwinner, cmbheadercg, cmbsubheadercg, lblfilenamecg)
        On Error Resume Next
        Dim osd2 As New SaveFileDialog
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "C:\casparcg\mydata\games2\cg\"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvwinner.Rows.Count = 0 Then
                    sw.Write("")
                Else
                    'write header and subheader
                    sw.WriteLine(cmbheadercg.Text & "," & cmbsubheadercg.Text)

                    'write headers of datagrid
                    Dim header1 As String = ""
                    For i = 0 To dgvwinner.ColumnCount - 1
                        header1 = header1 & dgvwinner.Columns(i).HeaderText & ","
                    Next
                    sw.WriteLine(header1)

                    'Loop through and add list to the file.
                    Dim f As Integer = 0
                    Do Until f = dgvwinner.Rows.Count
                        Dim str As String = ""
                        For k = 0 To dgvwinner.ColumnCount - 1
                            If k = 0 Then
                                str = str & dgvwinner.Rows(f).Cells(2).Value & ","
                            Else
                                str = str & dgvwinner.Rows(f).Cells(k).Value & ","
                            End If

                        Next
                        sw.WriteLine(str)
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            lblfilenamecg.Text = osd2.FileName
        End If
    End Sub


    Private Sub cmdupcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupcg.Click
        On Error Resume Next
        upsg(dgvwinner)
    End Sub

    Private Sub cmddowncg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddowncg.Click
        On Error Resume Next
        downsg(dgvwinner)
    End Sub

    Private Sub cmdinsercg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdinsercg.Click
        On Error Resume Next
        insertsg(dgvwinner)
    End Sub

    Private Sub cmddeleteg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddeleteg.Click
        On Error Resume Next
        deletesg(dgvwinner)
    End Sub

    Private Sub cmdscorewithclock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscorewithclock.Click
        On Error Resume Next

        If chkanimationzym.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtt1ball.Text)
        CasparCGDataCollection.SetData("f1", txtt2ball.Text)
        CasparCGDataCollection.SetData("f2", txtt1gball.Text)
        CasparCGDataCollection.SetData("f3", txtt2gball.Text)
        CasparCGDataCollection.SetData("time", txtminball.Text & ":" & txtsecball.Text)
        CasparCGDataCollection.SetData("f5", cmbhalfball.Text)

        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader6", pict2logoball.ImageLocation)

        CasparCGDataCollection.SetData("mc1", "1")
        CasparCGDataCollection.SetData("mc2", "0")



        CasparCGDataCollection.SetData("team1color", cmdt1colorball.BackColor.ToArgb)
        CasparCGDataCollection.SetData("team2color", cmdt2colorball.BackColor.ToArgb)


        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "cmp/games2/ball/score", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then
            If chkanimationforhdvan.Checked Then
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill .1 0 .8 1 50 easeoutexpo")

            Else
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill 0 0 1 1 50 easeoutexpo")

            End If

        End If
        tmrtimeupdateontemplate.Enabled = True
        tmrupdateontemplateextra.Enabled = False
    End Sub

    Private Sub cmdscorewithinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscorewithinfo.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("mc1", "0")
        CasparCGDataCollection.SetData("mc2", "1")


        If chkanimationzym.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")


        CasparCGDataCollection.SetData("f0", txtt1ball.Text)
        CasparCGDataCollection.SetData("f1", txtt2ball.Text)
        CasparCGDataCollection.SetData("f2", txtt1gball.Text)
        CasparCGDataCollection.SetData("f3", txtt2gball.Text)
        CasparCGDataCollection.SetData("time", txtminball.Text & ":" & txtsecball.Text)
        CasparCGDataCollection.SetData("f5", cmbhalfball.Text)

        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader6", pict2logoball.ImageLocation)


        CasparCGDataCollection.SetData("info", cmbinfoball.Text)

        CasparCGDataCollection.SetData("team1color", cmdt1colorball.BackColor.ToArgb)
        CasparCGDataCollection.SetData("team2color", cmdt2colorball.BackColor.ToArgb)


        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "cmp/games2/ball/score", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then
            If chkanimationforhdvan.Checked Then
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill .1 0 .8 1 50 easeoutexpo")
            Else
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill 0 0 1 1 50 easeoutexpo")
            End If
        End If
        tmrtimeupdateontemplate.Enabled = True
        tmrupdateontemplateextra.Enabled = False
    End Sub

    Private Sub cmdonelinercg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdonelinercg.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtonelinercg.Text)
        showtemplate("cmp/games2/cg/oneliner", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
    Private Sub cmdleftotopcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdleftotopcg.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", cmblefttopcg.Text)
        showtemplate("cmp/games2/cg/lefttop", CasparCGDataCollection.ToAMCPEscapedXml)
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
            CasparCGDataCollection.SetData("f" & isetscore, dgvsetscoreball.Rows(0).Cells(isetscore - 1).Value)
        Next

        For isetscore = 1 To 2
            For jsetscore = 1 To 6
                CasparCGDataCollection.SetData("f" & isetscore & jsetscore, dgvsetscoreball.Rows(isetscore).Cells(jsetscore - 1).Value)
            Next
        Next

        CasparCGDataCollection.SetData("h1", cmbHeader.Text)
        CasparCGDataCollection.SetData("h2", cmbSubHeader.Text)

        CasparCGDataCollection.SetData("t1", txtt1ball.Text)
        CasparCGDataCollection.SetData("t2", txtt2ball.Text)

        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2logoball.ImageLocation)

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/cg/set7", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub Ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ball.Click

    End Sub

    Private Sub dgvsetscoreball_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvsetscoreball.CellContentClick

    End Sub

    Private Sub pict1tt_Click(sender As System.Object, e As System.EventArgs) Handles pict1tt.Click
        On Error Resume Next
        openlogoandcountryfullnamesg(sender, e, txtfullnamet1tt)
    End Sub

    Private Sub pict2tt_Click(sender As System.Object, e As System.EventArgs) Handles pict2tt.Click
        On Error Resume Next
        openlogoandcountryfullnamesg(sender, e, txtfullnamet2tt)
    End Sub

    Private Sub cmdpointdecreaset1tt_Click(sender As System.Object, e As System.EventArgs) Handles cmdpointdecreaset1tt.Click
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

    Private Sub cmdpointincreaset1tt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpointincreaset1tt.Click
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

    Private Sub cmdpointincreaset2tt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpointincreaset2tt.Click
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

    Private Sub cmdpointdecreaset2tt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpointdecreaset2tt.Click
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

    Private Sub cmdresetscorett_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresetscorett.Click
        txtgamet1tt.Text = "0"
        txtgamet2tt.Text = "0"
        txtpointt1tt.Text = "0"
        txtpointt2tt.Text = "0"
        txtset1tt.Text = "0"
        txtset2tt.Text = "0"
    End Sub

    Private Sub cmdshowscorett_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshowscorett.Click
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
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/tt/serve.png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games2/tt/blk.png")
            Else
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/tt/blk.png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games2/tt/serve.png")
            End If
        End If

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        If chkshowsettt.Checked = False Then
            showtemplate("cmp/games2/tt/score", CasparCGDataCollection.ToAMCPEscapedXml)
        Else
            showtemplate("cmp/games2/tt/scorewithset", CasparCGDataCollection.ToAMCPEscapedXml)
        End If
    End Sub
    Private Sub cmdupdatescorett_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdatescorett.Click
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

        'CasparCGDataCollection.SetData("loader1", pict1.ImageLocation)
        'CasparCGDataCollection.SetData("loader2", pict2.ImageLocation)
        If chkshowservicett.Checked Then
            If rdoservicet1tt.Checked Then
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/tt/serve.png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games2/tt/blk.png")
            Else
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/tt/blk.png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games2/tt/serve.png")
            End If
        End If
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)

    End Sub

    Private Sub cmdshowscore1tt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshowscore1tt.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("t1", txtfullnamet1tt.Text)
        CasparCGDataCollection.SetData("t2", txtfullnamet2tt.Text)
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
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/tt/serve.png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games2/tt/blk.png")
            Else
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/tt/blk.png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games2/tt/serve.png")
            End If
        End If

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        If chkshowsettt.Checked = False Then
            showtemplate("cmp/games2/tt/score1", CasparCGDataCollection.ToAMCPEscapedXml)
        Else
            showtemplate("cmp/games2/tt/score1withset", CasparCGDataCollection.ToAMCPEscapedXml)
        End If
    End Sub

    Private Sub cmdupdatescore1tt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdatescore1tt.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("t1", txtfullnamet1tt.Text)
        CasparCGDataCollection.SetData("t2", txtfullnamet2tt.Text)
        CasparCGDataCollection.SetData("g1", txtgamet1tt.Text)
        CasparCGDataCollection.SetData("g2", txtgamet2tt.Text)
        CasparCGDataCollection.SetData("p1", txtpointt1tt.Text)
        CasparCGDataCollection.SetData("p2", txtpointt2tt.Text)


        CasparCGDataCollection.SetData("s1", txtset1tt.Text)
        CasparCGDataCollection.SetData("s2", txtset2tt.Text)
        If chkshowservicett.Checked Then
            If rdoservicet1tt.Checked Then
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/tt/serve.png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games2/tt/blk.png")
            Else
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/tt/blk.png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games2/tt/serve.png")
            End If
        End If
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)

    End Sub

    Private Sub cmdversustt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdversustt.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", cmbHeader.Text)
        CasparCGDataCollection.SetData("f1", cmbSubHeader.Text)

        CasparCGDataCollection.SetData("f2", txtfullnamet1tt.Text)
        CasparCGDataCollection.SetData("f3", txtfullnamet2tt.Text)

        CasparCGDataCollection.SetData("loader1", pict1tt.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2tt.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        showtemplate("cmp/games2/cg/versus", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdshowsetscorett_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshowsetscorett.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        Dim setscore As Integer
        If rdo3settt.Checked Then setscore = 3
        If rdo5settt.Checked Then setscore = 5
        If rdo7settt.Checked Then setscore = 7

        For isetscore = 1 To setscore
            CasparCGDataCollection.SetData("f" & isetscore, dgvsetscorett.Columns(isetscore - 1).HeaderText)
        Next

        For isetscore = 1 To 2
            For jsetscore = 1 To setscore
                CasparCGDataCollection.SetData("f" & isetscore & jsetscore, dgvsetscorett.Rows(isetscore - 1).Cells(jsetscore - 1).Value)
            Next
        Next

        CasparCGDataCollection.SetData("h1", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("h2", "")

        CasparCGDataCollection.SetData("t1", txtfullnamet1tt.Text)
        CasparCGDataCollection.SetData("t2", txtfullnamet2tt.Text)

        CasparCGDataCollection.SetData("loader1", pict1tt.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2tt.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/cg/set7", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdscoreresettt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscoreresettt.Click
        On Error Resume Next
        For iscore = 0 To 1
            For jscore = 0 To 6
                dgvsetscorett.Rows(iscore).Cells(jscore).Value = ""
            Next
        Next
    End Sub
    Private Sub cmdleftotoptt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdleftotoptt.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", cmblefttoptt.Text)

        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)

        showtemplate("cmp/games2/tt/lefttop", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdpontindicatert1tt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpontindicatert1tt.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", cmblefttoptt.Text)
        CasparCGDataCollection.SetData("f1", txtfullnamet1tt.Text)
        CasparCGDataCollection.SetData("loader1", pict1tt.ImageLocation)

        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        showtemplate("cmp/games2/tt/pointindicator", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdpontindicatert2tt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpontindicatert2tt.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", cmblefttoptt.Text)

        CasparCGDataCollection.SetData("f1", txtfullnamet2tt.Text)
        CasparCGDataCollection.SetData("loader1", pict2tt.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)

        showtemplate("cmp/games2/tt/pointindicator", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub


    Private Sub cmdpositiontt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpositiontt.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()


        If rdostraightposiontt.Checked Then
            CasparCGDataCollection.SetData("f0", txtfullnamet1tt.Text)
            CasparCGDataCollection.SetData("f1", txtfullnamet2tt.Text)

            CasparCGDataCollection.SetData("loader1", pict1tt.ImageLocation)
            CasparCGDataCollection.SetData("loader2", pict2tt.ImageLocation)
        Else
            CasparCGDataCollection.SetData("f0", txtfullnamet2tt.Text)
            CasparCGDataCollection.SetData("f1", txtfullnamet1tt.Text)

            CasparCGDataCollection.SetData("loader1", pict2tt.ImageLocation)
            CasparCGDataCollection.SetData("loader2", pict1tt.ImageLocation)
        End If

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        showtemplate("cmp/games2/tt/position", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdpositionhorizontaltt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpositionhorizontaltt.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()


        If rdostraightposiontt.Checked Then
            CasparCGDataCollection.SetData("f0", txtfullnamet1tt.Text)
            CasparCGDataCollection.SetData("f1", txtfullnamet2tt.Text)

            CasparCGDataCollection.SetData("loader1", pict1tt.ImageLocation)
            CasparCGDataCollection.SetData("loader2", pict2tt.ImageLocation)
        Else
            CasparCGDataCollection.SetData("f0", txtfullnamet2tt.Text)
            CasparCGDataCollection.SetData("f1", txtfullnamet1tt.Text)

            CasparCGDataCollection.SetData("loader1", pict2tt.ImageLocation)
            CasparCGDataCollection.SetData("loader2", pict1tt.ImageLocation)
        End If

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        showtemplate("cmp/games2/tt/position_horizontal", CasparCGDataCollection.ToAMCPEscapedXml)
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
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("mc1", "0")
        CasparCGDataCollection.SetData("mc2", "1")


        If chkanimationzym.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")


        CasparCGDataCollection.SetData("f0", txtt1ball.Text)
        CasparCGDataCollection.SetData("f1", txtt2ball.Text)
        CasparCGDataCollection.SetData("time", txtminball.Text & ":" & txtsecball.Text)
        CasparCGDataCollection.SetData("f5", cmbhalfball.Text)

        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader6", pict2logoball.ImageLocation)


        CasparCGDataCollection.SetData("info", cmbinfoball.Text)

        CasparCGDataCollection.SetData("team1color", cmdt1colorball.BackColor.ToArgb)
        CasparCGDataCollection.SetData("team2color", cmdt2colorball.BackColor.ToArgb)


        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "cmp/games2/boxing/score", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then
            If chkanimationforhdvan.Checked Then
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill .1 0 .8 1 50 easeoutexpo")
            Else
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill 0 0 1 1 50 easeoutexpo")
            End If
        End If
        tmrtimeupdateontemplate.Enabled = True
        tmrupdateontemplateextra.Enabled = False
    End Sub

    Private Sub cmdversusboxing_Click(sender As Object, e As EventArgs) Handles cmdversusboxing.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", cmbHeader.Text)
        CasparCGDataCollection.SetData("f1", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("f2", txtt1ball.Text)
        CasparCGDataCollection.SetData("f3", txtt2ball.Text)

        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games2/boxing/versus", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdplayeridboxing_Click(sender As Object, e As EventArgs) Handles cmdplayeridboxing.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        If rdoTeamARed.Checked Then
            CasparCGDataCollection.SetData("f1", dgvt1ball.CurrentRow.Cells(0).Value)
            showtemplate("cmp/games2/boxing/player_id_red", CasparCGDataCollection.ToAMCPEscapedXml)
        Else
            CasparCGDataCollection.SetData("f1", dgvt2ball.CurrentRow.Cells(0).Value)
            showtemplate("cmp/games2/boxing/player_id_blue", CasparCGDataCollection.ToAMCPEscapedXml)
        End If

    End Sub

    Private Sub cmdwinnerBoxing_Click(sender As Object, e As EventArgs) Handles cmdwinnerBoxing.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("h1", cmbHeader.Text)
        CasparCGDataCollection.SetData("h2", cmbwinningmethodboxing.Text & "- " & cmbSubHeader.Text)

        If rdoTeamARed.Checked Then
            CasparCGDataCollection.SetData("t1", dgvt1ball.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        Else
            CasparCGDataCollection.SetData("t1", dgvt2ball.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("loader1", pict2logoball.ImageLocation)
        End If
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/boxing/winner", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub


    Private Sub cmdscorewithclockboxing_Click(sender As Object, e As EventArgs) Handles cmdscorewithclockboxing.Click
        On Error Resume Next

        If chkanimationzym.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtt1ball.Text)
        CasparCGDataCollection.SetData("f1", txtt2ball.Text)
        'CasparCGDataCollection.SetData("f2", txtt1gball.Text)
        'CasparCGDataCollection.SetData("f3", txtt2gball.Text)
        CasparCGDataCollection.SetData("time", txtminball.Text & ":" & txtsecball.Text)
        CasparCGDataCollection.SetData("f5", cmbhalfball.Text)

        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader6", pict2logoball.ImageLocation)

        CasparCGDataCollection.SetData("mc1", "1")
        CasparCGDataCollection.SetData("mc2", "0")



        CasparCGDataCollection.SetData("team1color", cmdt1colorball.BackColor.ToArgb)
        CasparCGDataCollection.SetData("team2color", cmdt2colorball.BackColor.ToArgb)


        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "cmp/games2/boxing/score", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then
            If chkanimationforhdvan.Checked Then
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill .1 0 .8 1 50 easeoutexpo")

            Else
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill 0 0 1 1 50 easeoutexpo")

            End If

        End If
        tmrtimeupdateontemplate.Enabled = True
        tmrupdateontemplateextra.Enabled = False
    End Sub

    Private Sub cmdsetscoreboxing_Click(sender As Object, e As EventArgs) Handles cmdsetscoreboxing.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()



        For isetscore = 1 To 6
            CasparCGDataCollection.SetData("f" & isetscore, dgvsetscoreball.Rows(0).Cells(isetscore - 1).Value)
        Next

        For isetscore = 1 To 2
            For jsetscore = 1 To 6
                CasparCGDataCollection.SetData("f" & isetscore & jsetscore, dgvsetscoreball.Rows(isetscore).Cells(jsetscore - 1).Value)
            Next
        Next

        CasparCGDataCollection.SetData("h1", cmbHeader.Text)
        CasparCGDataCollection.SetData("h2", cmbSubHeader.Text)

        CasparCGDataCollection.SetData("t1", txtt1ball.Text)
        CasparCGDataCollection.SetData("t2", txtt2ball.Text)

        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2logoball.ImageLocation)

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)


        showtemplate("cmp/games2/boxing/set7", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdroundscoreboxing_Click(sender As Object, e As EventArgs) Handles cmdroundscoreboxing.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", cmbgoalsummary.Text)
        CasparCGDataCollection.SetData("f1", txtt1gball.Text & "-" & txtt2gball.Text)

        CasparCGDataCollection.SetData("f2", txtt1ball.Text)
        CasparCGDataCollection.SetData("f3", txtt2ball.Text)

        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2logoball.ImageLocation)

        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        showtemplate("cmp/games2/boxing/Goal_Summary", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub Athletics_Click(sender As Object, e As EventArgs) Handles Athletics.Click

    End Sub


    Sub makedatatypeforsorting(dgv1 As DataGridView, dgv2 As DataGridView)
        dgv1.Columns(5).ValueType = GetType(Integer)
        dgv2.Columns(5).ValueType = GetType(Integer)
    End Sub
    Private Sub dgvtrack_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvtrack.DataError
        'dummy code dont delete
    End Sub

    Private Sub dgvtrackresult_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        'dummy code dont delete
    End Sub

    Private Sub cmdstartlisttrack_Click(sender As Object, e As EventArgs) Handles cmdstartlisttrack.Click
        startlist(dgvtrack)
    End Sub
    Sub startlist(dgv As DataGridView)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)

        With dgv
            For i = 0 To 7

                If .Rows(i).Cells(0).Value <> "" Then

                    CasparCGDataCollection.SetData("sn" & i + 1, .Rows(i).Cells(0).Value)
                    CasparCGDataCollection.SetData("plid" & i + 1, .Rows(i).Cells(1).Value)

                    CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & .Rows(i).Cells(2).Value & ".png")

                    CasparCGDataCollection.SetData("name" & i + 1, .Rows(i).Cells(3).Value)
                End If
            Next
            CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
            CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

            CasparCGDataCollection.SetData("startlist", "Startlist- " & cmbSubHeader.Text)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/startlist1", True, CasparCGDataCollection.ToAMCPEscapedXml)

            If chkanimationzym.Checked Then animationtoscreen()
        End With
    End Sub
    Private Sub cmdfillresulttrack_Click(sender As Object, e As EventArgs) Handles cmdfillresulttrack.Click
        On Error Resume Next

        'sortresult(dgvtrack, dgvtrackresult, 5)

        sortresult1(dgvtrack, dgvtrackresult, 5)
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

    Private Sub cmdresulttrack_Click(sender As Object, e As EventArgs) Handles cmdresulttrack.Click
        result(dgvtrackresult)
    End Sub

    Private Sub cmdtopthreetrack_Click(sender As Object, e As EventArgs) Handles cmdtopthreetrack.Click
        topthree(dgvtrackresult)
    End Sub

    Private Sub newtrack_Click(sender As Object, e As EventArgs) Handles newtrack.Click
        On Error Resume Next
        newdatasg(dgvtrack, cmbHeader, cmbSubHeader, lblfilenametrack)
        dgvtrackresult.Rows.Clear()
    End Sub

    Private Sub opentrack_Click(sender As Object, e As EventArgs) Handles opentrack.Click

        opendatasg("C:\casparcg\mydata\games2\track\", dgvtrack, cmbHeader, cmbSubHeader, lblfilenametrack)
        maketrack6thcolumninteger(dgvtrack)
        dgvtrackresult.Rows.Clear()
    End Sub

    Private Sub savetrack_Click(sender As Object, e As EventArgs) Handles savetrack.Click
        savedatasg("C:\casparcg\mydata\games2\track\", dgvtrack, cmbHeader, cmbSubHeader, lblfilenametrack)
    End Sub

    Private Sub uprowtrack_Click(sender As Object, e As EventArgs) Handles uprowtrack.Click
        upsg(dgvtrack)
    End Sub

    Private Sub downrowtrack_Click(sender As Object, e As EventArgs) Handles downrowtrack.Click
        downsg(dgvtrack)
    End Sub

    Private Sub addrowtrack_Click(sender As Object, e As EventArgs) Handles addrowtrack.Click
        insertsg(dgvtrack)
    End Sub

    Private Sub deleterowtrack_Click(sender As Object, e As EventArgs) Handles deleterowtrack.Click
        deletesg(dgvtrack)
    End Sub
    Sub maketrack6thcolumninteger(dgv As DataGridView)
        On Error Resume Next
        With dgv
            For ii = 0 To dgvtrack.RowCount - 1
                .Rows(ii).Cells(5).Value = CType(.Rows(ii).Cells(5).Value, Integer)
            Next
        End With
    End Sub

    Private Sub cmdPlyerIdtrack_Click(sender As Object, e As EventArgs) Handles cmdPlyerIdtrack.Click
        'playerid(dgvtrack)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        With dgvtrack
            CasparCGDataCollection.SetData("trackid", .CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & .CurrentRow.Cells(2).Value & ".png")
            CasparCGDataCollection.SetData("f1", .CurrentRow.Cells(1).Value & "  " & .CurrentRow.Cells(3).Value)
            CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
            CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/player_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        End With
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdallthreebronze2track_Click(sender As Object, e As EventArgs) Handles cmdallthreebronze2track.Click
        medalallthree2(dgvtrackresult)
    End Sub
    Private Sub cmdallthreetrack_Click(sender As Object, e As EventArgs) Handles cmdallthreetrack.Click
        medalallthree(dgvtrackresult)
    End Sub
    Private Sub cmdbronze2track_Click(sender As Object, e As EventArgs) Handles cmdbronze2track.Click
        medalBronze2(dgvtrackresult)
    End Sub
    Private Sub cmdbronzetrack_Click(sender As Object, e As EventArgs) Handles cmdbronzetrack.Click
        medalBronze(dgvtrackresult)
    End Sub
    Private Sub cmdsilvertrck_Click(sender As Object, e As EventArgs) Handles cmdsilvertrck.Click
        medalSilver(dgvtrackresult)
    End Sub

    Private Sub cmdgoldtrack_Click(sender As Object, e As EventArgs) Handles cmdgoldtrack.Click
        medalGold(dgvtrackresult)
    End Sub


    Sub medalallthree2(dgv As DataGridView)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        With dgv
            CasparCGDataCollection.SetData("h1", cmbHeader.Text)
            CasparCGDataCollection.SetData("h2", cmbSubHeader.Text)
            CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
            CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
            For imedalall = 0 To 3
                CasparCGDataCollection.SetData("t" & imedalall + 1, .Rows(imedalall).Cells(3).Value)
                CasparCGDataCollection.SetData("loader" & imedalall + 1, "C:/casparcg/mydata/games2/country/WithName/" & .Rows(imedalall).Cells(2).Value & ".png")
            Next
        End With
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/medal_three_bronze2", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub
    Sub medalallthree(dgv As DataGridView)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        With dgv
            CasparCGDataCollection.SetData("h1", cmbHeader.Text)
            CasparCGDataCollection.SetData("h2", cmbSubHeader.Text)
            CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
            CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
            For imedalall = 0 To 2
                CasparCGDataCollection.SetData("t" & imedalall + 1, .Rows(imedalall).Cells(3).Value)
                CasparCGDataCollection.SetData("loader" & imedalall + 1, "C:/casparcg/mydata/games2/country/WithName/" & .Rows(imedalall).Cells(2).Value & ".png")
            Next
        End With
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/medal_three", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub


    Sub medalBronze2(dgv As DataGridView)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        With dgv
            CasparCGDataCollection.SetData("f0", cmbSubHeader.Text)
            CasparCGDataCollection.SetData("f1", .Rows(3).Cells(3).Value)
            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & .Rows(3).Cells(2).Value & ".png")
            CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
            CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/medal_b2", True, CasparCGDataCollection.ToAMCPEscapedXml)
        End With
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub
    Sub medalBronze(dgv As DataGridView)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        With dgv
            CasparCGDataCollection.SetData("f0", cmbSubHeader.Text)
            CasparCGDataCollection.SetData("f1", .Rows(2).Cells(3).Value)
            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & .Rows(2).Cells(2).Value & ".png")
            CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
            CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/medal_b", True, CasparCGDataCollection.ToAMCPEscapedXml)
        End With
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub
    Sub medalSilver(dgv As DataGridView)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        With dgv
            CasparCGDataCollection.SetData("f0", cmbSubHeader.Text)
            CasparCGDataCollection.SetData("f1", .Rows(1).Cells(3).Value)
            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & .Rows(1).Cells(2).Value & ".png")
            CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
            CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/medal_s", True, CasparCGDataCollection.ToAMCPEscapedXml)
        End With
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub
    Sub medalGold(dgv As DataGridView)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        With dgv
            CasparCGDataCollection.SetData("f0", cmbSubHeader.Text)
            CasparCGDataCollection.SetData("f1", .Rows(0).Cells(3).Value)
            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & .Rows(0).Cells(2).Value & ".png")
            CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
            CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/medal_g", True, CasparCGDataCollection.ToAMCPEscapedXml)
        End With
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdvictoryidtrack_Click(sender As Object, e As EventArgs) Handles cmdvictoryidtrack.Click
        victoryid()
    End Sub
    Sub victoryid()
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("f1", "Victory Ceremony")
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/victory_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub
    Private Sub cmdtimertrack_Click(sender As Object, e As EventArgs) Handles cmdtimertrack.Click
        On Error Resume Next
        If chkanimationzym.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("initialvalue", (txttimerminutetrac.Text) * 60000 + (txttimersecondtrack.Text) * 1000)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "cmp/games2/Track/count_up_timer", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then
            If chkanimationforhdvan.Checked Then
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill .1 0 .8 1 50 easeoutexpo")
            Else
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill 0 0 1 1 50 easeoutexpo")

            End If
        End If
    End Sub

    Private Sub cmdtimerpausetrack_Click(sender As Object, e As EventArgs) Handles cmdtimerpausetrack.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("pause", "")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, CasparCGDataCollection)
    End Sub


    Private Sub ntimeropactitytrack_ValueChanged(sender As Object, e As EventArgs) Handles ntimeropactitytrack.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " opacity " & ntimeropactitytrack.Value)
    End Sub

    Private Sub cmdtimerresumetrack_Click(sender As Object, e As EventArgs) Handles cmdtimerresumetrack.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("resume", "")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, CasparCGDataCollection)

    End Sub

    Private Sub cmdlaptrack_Click(sender As Object, e As EventArgs) Handles cmdlaptrack.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("lap", txtlaptrack.Text)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/track/lap", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdtimerremovetrack_Click(sender As Object, e As EventArgs) Handles cmdtimerremovetrack.Click
        On Error Resume Next
        If chkanimationzym.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1)
        Threading.Thread.Sleep(2000)
        If chkanimationzym.Checked Then
            If chkanimationforhdvan.Checked Then
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill .1 0 .8 1 50 easeoutexpo")
            Else
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill 0 0 1 1 50 easeoutexpo")
            End If
        End If
    End Sub

    Private Sub cmdindivisualresulttrack_Click(sender As Object, e As EventArgs) Handles cmdindivisualresulttrack.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        With dgvtrackresult
            CasparCGDataCollection.SetData("f0", cmbHeader.Text)
            CasparCGDataCollection.SetData("f1", cmbSubHeader.Text)
            CasparCGDataCollection.SetData("f2", .CurrentRow.Cells(3).Value)
            CasparCGDataCollection.SetData("f3", .CurrentRow.Cells(4).Value)
            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgvtrackresult.CurrentRow.Cells(2).Value & ".png")
        End With
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/track/Indivisualscore", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdstartlistfe_Click(sender As Object, e As EventArgs) Handles cmdstartlistfe.Click
        startlist(dgvFE)
    End Sub



    Private Sub cmdindivisualresultfe_Click(sender As Object, e As EventArgs) Handles cmdindivisualresultfe.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        With dgvferesult
            CasparCGDataCollection.SetData("h1", .CurrentRow.Cells(3).Value)
            CasparCGDataCollection.SetData("h2", cmbSubHeader.Text)

            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & .CurrentRow.Cells(2).Value & ".png")

            CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
            CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

            If chkhighjump.Checked Then

                CasparCGDataCollection.SetData("f11", txth1.Text)
                CasparCGDataCollection.SetData("f12", txth2.Text)
                CasparCGDataCollection.SetData("f13", txth3.Text)
                CasparCGDataCollection.SetData("f14", txth4.Text)
                CasparCGDataCollection.SetData("f15", txth5.Text)
                CasparCGDataCollection.SetData("f16", txth6.Text)
                CasparCGDataCollection.SetData("f17", txth7.Text)
                CasparCGDataCollection.SetData("f18", txth8.Text)

                For ii = 1 To 8
                    CasparCGDataCollection.SetData("f" & 20 + ii, .CurrentRow.Cells(5 + ii).Value)
                Next
                CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/fe/PlayerScoreHighJump", True, CasparCGDataCollection.ToAMCPEscapedXml)
            Else
                If rdo3attemptfe.Checked Then
                    For ii = 1 To 3
                        CasparCGDataCollection.SetData("f" & 10 + ii, ii)
                        CasparCGDataCollection.SetData("f" & 20 + ii, .CurrentRow.Cells(5 + ii).Value)
                    Next
                    CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/fe/playerscore3attempt", True, CasparCGDataCollection.ToAMCPEscapedXml)

                Else
                    For ii = 1 To 6
                        CasparCGDataCollection.SetData("f" & 10 + ii, ii)
                        CasparCGDataCollection.SetData("f" & 20 + ii, .CurrentRow.Cells(5 + ii).Value)
                    Next
                    CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/fe/playerscore", True, CasparCGDataCollection.ToAMCPEscapedXml)

                End If
            End If
        End With
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub
    Private Sub cmdvictoryidfe_Click(sender As Object, e As EventArgs) Handles cmdvictoryidfe.Click
        victoryid()
    End Sub
    Private Sub cmdallthreebronze2fe_Click(sender As Object, e As EventArgs) Handles cmdallthreebronze2fe.Click
        medalallthree2(dgvferesult)
    End Sub
    Private Sub cmdallthreefe_Click(sender As Object, e As EventArgs) Handles cmdallthreefe.Click
        medalallthree(dgvferesult)
    End Sub


    Private Sub cmdbronze2fe_Click(sender As Object, e As EventArgs) Handles cmdbronze2fe.Click
        medalBronze2(dgvferesult)
    End Sub

    Private Sub cmdbronzefe_Click(sender As Object, e As EventArgs) Handles cmdbronzefe.Click
        medalBronze(dgvferesult)
    End Sub

    Private Sub cmdsilverfe_Click(sender As Object, e As EventArgs) Handles cmdsilverfe.Click
        medalSilver(dgvferesult)
    End Sub

    Private Sub cdmgoldfe_Click(sender As Object, e As EventArgs) Handles cdmgoldfe.Click
        medalGold(dgvferesult)
    End Sub

    Private Sub cmdresultfe_Click(sender As Object, e As EventArgs) Handles cmdresultfe.Click
        result(dgvferesult)
    End Sub

    Sub result(dgv As DataGridView)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)

        With dgv
            For i = 0 To .RowCount - 1
                If .Rows(i).Cells(0).Value <> vbNullString Then
                    CasparCGDataCollection.SetData("sn" & i + 1, i + 1)
                    CasparCGDataCollection.SetData("plid" & i + 1, .Rows(i).Cells(1).Value)
                    CasparCGDataCollection.SetData("value" & i + 1, .Rows(i).Cells(4).Value)
                    CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & .Rows(i).Cells(2).Value & ".png")
                    CasparCGDataCollection.SetData("name" & i + 1, .Rows(i).Cells(3).Value)
                    CasparCGDataCollection.SetData("alpha" & i + 1, 1)
                End If
            Next
            CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
            CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

            CasparCGDataCollection.SetData("startlist", "Result- " & cmbSubHeader.Text)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/result1", True, CasparCGDataCollection.ToAMCPEscapedXml)

            If chkanimationzym.Checked Then animationtoscreen()
        End With
    End Sub

    Private Sub cmdtopthreefe_Click(sender As Object, e As EventArgs) Handles cmdtopthreefe.Click
        topthree(dgvferesult)
    End Sub
    Sub topthree(dgv As DataGridView)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        With dgv
            For i = 0 To 2
                If .Rows(i).Cells(0).Value <> "" Then
                    CasparCGDataCollection.SetData("sn" & i + 1, i + 1)
                    CasparCGDataCollection.SetData("plid" & i + 1, .Rows(i).Cells(1).Value)
                    CasparCGDataCollection.SetData("value" & i + 1, .Rows(i).Cells(4).Value)
                    CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & .Rows(i).Cells(2).Value & ".png")
                End If
                CasparCGDataCollection.SetData("name" & i + 1, .Rows(i).Cells(3).Value)
            Next
            CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
            CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
            CasparCGDataCollection.SetData("startlist", "Top Three- " & cmbSubHeader.Text)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/resultthree", True, CasparCGDataCollection.ToAMCPEscapedXml)
            If chkanimationzym.Checked Then animationtoscreen()
        End With
    End Sub
    Private Sub cmdshortresultfe_Click(sender As Object, e As EventArgs) Handles cmdshortresultfe.Click
        sortresult1(dgvFE, dgvferesult, 5)
    End Sub

    Private Sub cmdplayeridfe_Click(sender As Object, e As EventArgs) Handles cmdplayeridfe.Click
        playerid(dgvFE)
    End Sub
    Sub playerid(dgv As DataGridView)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        With dgv
            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & .CurrentRow.Cells(2).Value & ".png")
            CasparCGDataCollection.SetData("f1", .CurrentRow.Cells(1).Value & "  " & .CurrentRow.Cells(3).Value)
            CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
            CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/player_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        End With
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub
    Private Sub dgvFE_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvFE.DataError
        'dummy code dont delete
    End Sub


    Private Sub dgvFEresult_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        'dummy code dont delete
    End Sub

    Private Sub newFE_Click(sender As Object, e As EventArgs) Handles newFE.Click
        On Error Resume Next
        newdatasg(dgvFE, cmbHeader, cmbSubHeader, lblfilenamefe)
        dgvferesult.Rows.Clear()
    End Sub

    Private Sub openFE_Click(sender As Object, e As EventArgs) Handles openFE.Click
        On Error Resume Next
        opendatasg("C:\casparcg\mydata\games2\fe\", dgvFE, cmbHeader, cmbSubHeader, lblfilenamefe)
        maketrack6thcolumninteger(dgvFE)
        dgvferesult.Rows.Clear()
    End Sub

    Private Sub saveFE_Click(sender As Object, e As EventArgs) Handles saveFE.Click
        savedatasg("C:\casparcg\mydata\games2\fe\", dgvFE, cmbHeader, cmbSubHeader, lblfilenamefe)

    End Sub

    Private Sub addFE_Click(sender As Object, e As EventArgs) Handles addFE.Click
        insertsg(dgvFE)
    End Sub

    Private Sub upFE_Click(sender As Object, e As EventArgs) Handles upFE.Click
        upsg(dgvFE)
    End Sub

    Private Sub removeFE_Click(sender As Object, e As EventArgs) Handles removeFE.Click
        deletesg(dgvFE)
    End Sub

    Private Sub downFE_Click(sender As Object, e As EventArgs) Handles downFE.Click
        downsg(dgvFE)
    End Sub


    Private Sub cmbgames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbgames.SelectedIndexChanged
        If cmbgames.Text = "Aquatics" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\AQ" & ".png"
        If cmbgames.Text = "Archery" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\AR" & ".png"
        If cmbgames.Text = "Atheletics" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\AT" & ".png"
        If cmbgames.Text = "Badminton" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\BD" & ".png"
        If cmbgames.Text = "Basketball" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\BK" & ".png"
        If cmbgames.Text = "Black" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\BLK" & ".png"
        If cmbgames.Text = "Boxing" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\BX" & ".png"
        If cmbgames.Text = "Cycling" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\CY" & ".png"
        If cmbgames.Text = "Diving" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\DIV" & ".png"
        If cmbgames.Text = "Football" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\FB" & ".png"
        If cmbgames.Text = "Gymnastics - Artistic" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\Gymnastics - Artistic" & ".png"
        If cmbgames.Text = "Gymnastics - Rhythmic" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\Gymnastics - Rhythmic" & ".png"
        If cmbgames.Text = "Gymnastics - Trampoline" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\Gymnastics - Trampoline" & ".png"
        If cmbgames.Text = "Handball" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\HB" & ".png"
        If cmbgames.Text = "Hockey" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\HO" & ".png"
        If cmbgames.Text = "Judo" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\HO" & ".png"
        If cmbgames.Text = "Kabaddi" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\KB" & ".png"
        If cmbgames.Text = "Kayaking" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\KK" & ".png"
        If cmbgames.Text = "Shooting" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\SH" & ".png"
        If cmbgames.Text = "Squash" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\SQ" & ".png"
        If cmbgames.Text = "Swimming" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\SW" & ".png"
        If cmbgames.Text = "TableTennis" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\TT" & ".png"
        If cmbgames.Text = "Taekwondo" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\TK" & ".png"
        If cmbgames.Text = "Tennis" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\TE" & ".png"
        If cmbgames.Text = "Triathlon" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\TRI" & ".png"
        If cmbgames.Text = "Volleyball" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\VB" & ".png"
        If cmbgames.Text = "Weight lift" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\WL" & ".png"
        If cmbgames.Text = "Wrestling" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\WR" & ".png"
        If cmbgames.Text = "Wushu" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games2\games logo\WU" & ".png"

    End Sub

    Private Sub chkhighjump_CheckedChanged(sender As Object, e As EventArgs) Handles chkhighjump.CheckedChanged
        On Error Resume Next
        For ii = 6 To 13
            If chkhighjump.Checked Then
                dgvFE.Columns(ii).DefaultCellStyle.Font = New Font("Wingdings 2", 8, FontStyle.Regular)
                dgvferesult.Columns(ii).DefaultCellStyle.Font = New Font("Wingdings 2", 8, FontStyle.Regular)
            Else
                dgvFE.Columns(ii).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 6.75, FontStyle.Bold)
                dgvferesult.Columns(ii).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 6.75, FontStyle.Bold)
            End If
        Next
    End Sub


    Private Sub cmdsortbyvaluetrack_Click(sender As Object, e As EventArgs) Handles cmdsortbyvaluetrack.Click
        sortresult1(dgvtrack, dgvtrackresult, 4)
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

    Private Sub cmdsortresultbyvaluefe_Click(sender As Object, e As EventArgs) Handles cmdsortresultbyvaluefe.Click
        sortresult1(dgvFE, dgvferesult, 4)
    End Sub


    Private Sub cmdeventshedule2_Click(sender As Object, e As EventArgs) Handles cmdeventshedule2.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg/event_shedule2", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub rdo6attemptfe_CheckedChanged(sender As Object, e As EventArgs) Handles rdo6attemptfe.CheckedChanged
        On Error Resume Next
        If rdo6attemptfe.Checked Then
            For ii = 9 To 13
                dgvFE.Columns(ii).Visible = True
                dgvferesult.Columns(ii).Visible = True
            Next

        Else
            For ii = 9 To 13
                dgvFE.Columns(ii).Visible = False
                dgvferesult.Columns(ii).Visible = False
            Next
        End If


    End Sub

    Private Sub cmdattemptidfe_Click(sender As Object, e As EventArgs) Handles cmdattemptidfe.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        With dgvFE
            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & .CurrentRow.Cells(2).Value & ".png")
            CasparCGDataCollection.SetData("f1", .CurrentRow.Cells(1).Value & "  " & .CurrentRow.Cells(3).Value)
            CasparCGDataCollection.SetData("attemptid", txtattemptidfe.Text)
            CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
            CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/fe/attempt_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        End With
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub


    Private Sub cmdcalculatebestvalue_Click(sender As Object, e As EventArgs) Handles cmdcalculatebestvalue.Click
        bestvaluesg(dgvFE, 6, 4)
    End Sub

    Private Sub cmdgrouptosemifinalball_Click(sender As Object, e As EventArgs) Handles cmdgrouptosemifinalball.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/ball/grouptosemifinal", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdgroupresultball_Click(sender As Object, e As EventArgs) Handles cmdgroupresultball.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/ball/groupresult1", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdgroupresul2tball_Click(sender As Object, e As EventArgs) Handles cmdgroupresul2tball.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/ball/groupresult2", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdmatchstatics_Click(sender As Object, e As EventArgs) Handles cmdmatchstatics.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/ball/MatchStatics", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdgoalsummarywithtime_Click(sender As Object, e As EventArgs) Handles cmdgoalsummarywithtime.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/ball/goalsummarywithtime", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdpenaltyball_Click(sender As Object, e As EventArgs) Handles cmdpenaltyball.Click
        On Error Resume Next

        If chkanimationzym.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtt1ball.Text)
        CasparCGDataCollection.SetData("f1", txtt2ball.Text)
        CasparCGDataCollection.SetData("f2", txtt1gball.Text)
        CasparCGDataCollection.SetData("f3", txtt2gball.Text)
        CasparCGDataCollection.SetData("time", txtminball.Text & ":" & txtsecball.Text)
        CasparCGDataCollection.SetData("f5", cmbhalfball.Text)

        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader6", pict2logoball.ImageLocation)

        CasparCGDataCollection.SetData("mc1", "0")
        CasparCGDataCollection.SetData("mc2", "0")


        CasparCGDataCollection.SetData("team1color", cmdt1colorball.BackColor.ToArgb)
        CasparCGDataCollection.SetData("team2color", cmdt2colorball.BackColor.ToArgb)


        With dgvpenaltyball



            For iii = 0 To 4
                If .Rows(0).Cells(iii).Value <> "" Then
                    CasparCGDataCollection.SetData("g" & iii + 1, .Rows(0).Cells(iii).Value)
                    CasparCGDataCollection.SetData("r" & iii + 1, 1 - .Rows(0).Cells(iii).Value)
                End If

            Next

            For iii = 0 To 4
                If .Rows(1).Cells(iii).Value <> "" Then
                    CasparCGDataCollection.SetData("g1" & iii + 1, .Rows(1).Cells(iii).Value)
                    CasparCGDataCollection.SetData("r1" & iii + 1, 1 - .Rows(1).Cells(iii).Value)
                End If

            Next

        End With



        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "cmp/games2/ball/scorewithpenalty", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then
            If chkanimationforhdvan.Checked Then
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill .1 0 .8 1 50 easeoutexpo")

            Else
                CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill 0 0 1 1 50 easeoutexpo")

            End If

        End If
        tmrtimeupdateontemplate.Enabled = False
        tmrupdateontemplateextra.Enabled = False
    End Sub

    Private Sub cmdvenueidcg2_Click(sender As Object, e As EventArgs) Handles cmdvenueidcg2.Click

        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        Dim i As Integer = dgvinfocg2.CurrentRow.Index
        CasparCGDataCollection.SetData("f" & i - dgvinfocg2.CurrentRow.Index, dgvinfocg2.Rows(i).Cells(0).Value)

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg2/venue_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdeventidcg2_Click(sender As Object, e As EventArgs) Handles cmdeventidcg2.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        Dim i As Integer = dgvinfocg2.CurrentRow.Index
        CasparCGDataCollection.SetData("f" & i - dgvinfocg2.CurrentRow.Index, dgvinfocg2.Rows(i).Cells(0).Value)
        CasparCGDataCollection.SetData("f" & i + 1 - dgvinfocg2.CurrentRow.Index, dgvinfocg2.Rows(i + 1).Cells(0).Value)

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg2/event_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdEventShedulecg2_Click(sender As Object, e As EventArgs) Handles cmdEventShedulecg2.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()

        Dim i As Integer = dgvinfocg2.CurrentRow.Index
        For i = dgvinfocg2.CurrentRow.Index To dgvinfocg2.CurrentRow.Index + 15
            CasparCGDataCollection.SetData("f" & i - dgvinfocg2.CurrentRow.Index, dgvinfocg2.Rows(i).Cells(0).Value)

        Next
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg2/event_shedule", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdOfficialID_Click(sender As Object, e As EventArgs) Handles cmdOfficialID.Click

        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()

        Dim i As Integer = dgvinfocg2.CurrentRow.Index
        For i = dgvinfocg2.CurrentRow.Index To dgvinfocg2.CurrentRow.Index + 1
            CasparCGDataCollection.SetData("f" & i - dgvinfocg2.CurrentRow.Index, dgvinfocg2.Rows(i).Cells(0).Value)

        Next
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg2/official_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdvictoryidcg2_Click(sender As Object, e As EventArgs) Handles cmdvictoryidcg2.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()

        Dim i As Integer = dgvinfocg2.CurrentRow.Index
        For i = dgvinfocg2.CurrentRow.Index To dgvinfocg2.CurrentRow.Index + 1
            CasparCGDataCollection.SetData("f" & i - dgvinfocg2.CurrentRow.Index, dgvinfocg2.Rows(i).Cells(0).Value)

        Next
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg2/victory_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmd10linercg2_Click(sender As Object, e As EventArgs) Handles cmd10linercg2.Click
        cg2dataandtemplate(10)
    End Sub

    Private Sub cmd9linercg2_Click(sender As Object, e As EventArgs) Handles cmd9linercg2.Click
        cg2dataandtemplate(9)
    End Sub

    Private Sub cmd8linercg2_Click(sender As Object, e As EventArgs) Handles cmd8linercg2.Click
        cg2dataandtemplate(8)
    End Sub

    Private Sub cmd7linercg2_Click(sender As Object, e As EventArgs) Handles cmd7linercg2.Click
        cg2dataandtemplate(7)
    End Sub

    Private Sub cmd6linercg2_Click(sender As Object, e As EventArgs) Handles cmd6linercg2.Click
        cg2dataandtemplate(6)
    End Sub

    Private Sub cmd5linercg2_Click(sender As Object, e As EventArgs) Handles cmd5linercg2.Click
        cg2dataandtemplate(5)
    End Sub

    Private Sub cmd4linercg2_Click(sender As Object, e As EventArgs) Handles cmd4linercg2.Click
        cg2dataandtemplate(4)
    End Sub

    Private Sub cmdthreelinercg2_Click(sender As Object, e As EventArgs) Handles cmdthreelinercg2.Click
        cg2dataandtemplate(3)
    End Sub

    Private Sub cmdtwolinercg2_Click(sender As Object, e As EventArgs) Handles cmdtwolinercg2.Click
        cg2dataandtemplate(2)
    End Sub
    Sub cg2dataandtemplate(ByVal cg2 As Integer)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        Dim i As Integer = dgvinfocg2.CurrentRow.Index
        For jcg2 = 0 To (cg2 - 1)
            CasparCGDataCollection.SetData("f" & jcg2, dgvinfocg2.Rows(i + jcg2).Cells(0).Value)
        Next

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg2/" & cg2 & "line", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub
    Private Sub cmdonelinercg2_Click(sender As Object, e As EventArgs) Handles cmdonelinercg2.Click
        cg2dataandtemplate(1)
    End Sub

    Private Sub cmdremoverowcg2_Click(sender As Object, e As EventArgs) Handles cmdremoverowcg2.Click
        deletesg(dgvinfocg2)
    End Sub

    Private Sub cmdrefreshdatacg2_Click(sender As Object, e As EventArgs) Handles cmdrefreshdatacg2.Click

        refreshdatacg2()
    End Sub
    Sub refreshdatacg2()
        On Error Resume Next
        Using sr As StreamReader = New StreamReader(lblfilenamecg2.Text)
            dgvinfocg2.Rows.Clear()
            Dim g As Integer = 0
            Dim li As String
            Do Until sr.EndOfStream = True
                li = sr.ReadLine()
                dgvinfocg2.Rows.Add()
                Dim xyz As Array = Split(li, Chr(2))
                dgvinfocg2.Rows(g).Cells(0).Value = xyz(0)
                g = g + 1
            Loop
            sr.Close()
        End Using
    End Sub

    Private Sub cmdsaveasnewfilecg2_Click(sender As Object, e As EventArgs) Handles cmdsaveasnewfilecg2.Click
        On Error Resume Next
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "C:\casparcg\mydata\games2\cg2\"
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvinfocg2.Rows.Count = 0 Then
                    sw.Write("")
                Else
                    'Loop through and add list to the file.
                    Dim f As Integer = 0
                    Do Until f = dgvinfocg2.Rows.Count
                        sw.WriteLine(dgvinfocg2.Rows(f).Cells(0).Value)
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            lblfilenamecg2.Text = osd2.FileName
        End If
    End Sub

    Private Sub cmdnewcg2_Click(sender As Object, e As EventArgs) Handles cmdnewcg2.Click
        On Error Resume Next
        dgvinfocg2.Rows.Clear()

        lblfilenamecg2.Text = "New"
    End Sub

    Private Sub cmdopencg2_Click(sender As Object, e As EventArgs) Handles cmdopencg2.Click
        Dim bb As New OpenFileDialog
        bb.InitialDirectory = "C:\casparcg\mydata\games2\cg2\"
        If bb.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblfilenamecg2.Text = bb.FileName
            refreshdatacg2()
            bb.Dispose()
        End If
    End Sub

    Private Sub cmdsavecg2_Click(sender As Object, e As EventArgs) Handles cmdsavecg2.Click
        On Error Resume Next
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "C:\casparcg\mydata\games2\cg2\"
        osd2.FileName = ""
        Using sw As StreamWriter = New StreamWriter(lblfilenamecg2.Text)
            If dgvinfocg2.Rows.Count = 0 Then
                sw.Write("")
            Else
                'Loop through and add list to the file.
                Dim f As Integer = 0
                Do Until f = dgvinfocg2.Rows.Count
                    sw.WriteLine(dgvinfocg2.Rows(f).Cells(0).Value)
                    f = f + 1
                Loop
            End If
            sw.Close()
        End Using
    End Sub

    Private Sub cmduprowcg2_Click(sender As Object, e As EventArgs) Handles cmduprowcg2.Click
        upsg(dgvinfocg2)
    End Sub

    Private Sub cmddownrowcg2_Click(sender As Object, e As EventArgs) Handles cmddownrowcg2.Click
        downsg(dgvinfocg2)
    End Sub

    Private Sub cmdaddrowcg2_Click(sender As Object, e As EventArgs) Handles cmdaddrowcg2.Click
        insertsg(dgvinfocg2)
    End Sub

    Private Sub cmd3linercentercg2_Click(sender As Object, e As EventArgs) Handles cmd3linercentercg2.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        Dim i As Integer = dgvinfocg2.CurrentRow.Index
        For jcg2 = 0 To 2
            CasparCGDataCollection.SetData("f" & jcg2, dgvinfocg2.Rows(i + jcg2).Cells(0).Value)
        Next
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/cg2/3linecenter", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub dgvinfocg2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvinfocg2.CellClick
        On Error Resume Next
        For ddd = 0 To dgvinfocg2.RowCount - 1
            dgvinfocg2.Rows(ddd).Cells(1).Value = ""
        Next

        For ddd = 1 To 20
            dgvinfocg2.Rows(dgvinfocg2.CurrentRow.Index + ddd - 1).Cells(1).Value = ddd
        Next
    End Sub



    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip2.ItemClicked

    End Sub

    Private Sub CmdATPScore_Click(sender As Object, e As EventArgs) Handles cmdATPScore.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()


        CasparCGDataCollection.SetData("f0", txtfullnamet1tt.Text)
        CasparCGDataCollection.SetData("f1", txtfullnamet2tt.Text)

        CasparCGDataCollection.SetData("f2", txtpointt1tt.Text)
        CasparCGDataCollection.SetData("f3", txtpointt2tt.Text)


        CasparCGDataCollection.SetData("f4", dgvsetscorett.Rows(0).Cells(0).Value)
        CasparCGDataCollection.SetData("f5", dgvsetscorett.Rows(1).Cells(0).Value)
        CasparCGDataCollection.SetData("f6", dgvsetscorett.Rows(0).Cells(1).Value)
        CasparCGDataCollection.SetData("f7", dgvsetscorett.Rows(1).Cells(1).Value)
        CasparCGDataCollection.SetData("f8", dgvsetscorett.Rows(0).Cells(2).Value)
        CasparCGDataCollection.SetData("f9", dgvsetscorett.Rows(1).Cells(2).Value)



        If rdoScoreonly.Checked Then CasparCGDataCollection.SetData("1", "")
        If rdoScoreAnd1stSet.Checked Then CasparCGDataCollection.SetData("2", "")
        If rdoScoreAnd2ndSet.Checked Then CasparCGDataCollection.SetData("3", "")
        If rdoScoreAnd3rdSet.Checked Then CasparCGDataCollection.SetData("4", "")

        If chkshowservicett.Checked = False Then
            CasparCGDataCollection.SetData("non", "")
        Else
            If rdoservicet1tt.Checked Then CasparCGDataCollection.SetData("service1", "")
            If rdoservicet2tt.Checked Then CasparCGDataCollection.SetData("service2", "")
        End If

        If chkanimationzym.Checked Then animation1()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games2/atp/score", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub CmdATPSUpdate_Click(sender As Object, e As EventArgs) Handles cmdATPSUpdate.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", txtfullnamet1tt.Text)
        CasparCGDataCollection.SetData("f1", txtfullnamet2tt.Text)

        CasparCGDataCollection.SetData("f2", txtpointt1tt.Text)
        CasparCGDataCollection.SetData("f3", txtpointt2tt.Text)

        CasparCGDataCollection.SetData("f4", dgvsetscorett.Rows(0).Cells(0).Value)
        CasparCGDataCollection.SetData("f5", dgvsetscorett.Rows(1).Cells(0).Value)
        CasparCGDataCollection.SetData("f6", dgvsetscorett.Rows(0).Cells(1).Value)
        CasparCGDataCollection.SetData("f7", dgvsetscorett.Rows(1).Cells(1).Value)
        CasparCGDataCollection.SetData("f8", dgvsetscorett.Rows(0).Cells(2).Value)
        CasparCGDataCollection.SetData("f9", dgvsetscorett.Rows(1).Cells(2).Value)

        If rdoScoreonly.Checked Then CasparCGDataCollection.SetData("1", "")
        If rdoScoreAnd1stSet.Checked Then CasparCGDataCollection.SetData("2", "")
        If rdoScoreAnd2ndSet.Checked Then CasparCGDataCollection.SetData("3", "")
        If rdoScoreAnd3rdSet.Checked Then CasparCGDataCollection.SetData("4", "")

        If chkshowservicett.Checked = False Then
            CasparCGDataCollection.SetData("non", "")
        Else
            If rdoservicet1tt.Checked Then CasparCGDataCollection.SetData("service1", "")
            If rdoservicet2tt.Checked Then CasparCGDataCollection.SetData("service2", "")
        End If
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)
    End Sub

End Class
