Imports Svt.Caspar

Imports System.Net.Sockets

Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class ucNG2015
    Private Sub NG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        gymnasticsdefaultdata()
        shootingdefaultdata()
        winnerdefaultdat()
        defautdataforball()
        initialisesetscoreball()
        initialisesetscorett()
        initialisepol()
    End Sub

    Sub initialisepol()
        Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Casparcg\mydata\database\cmp.accdb")
        cn.Open()
        Dim da1 As New OleDbDataAdapter("Select * from porteam1", cn)
        Dim tbl As New DataTable
        Dim bindingsource1 As New BindingSource
        da1.Fill(tbl)
        bindingsource1.DataSource = tbl
        BindingNavigator1.BindingSource = bindingsource1

        image1.DataBindings.Add(New Binding("imagelocation", bindingsource1, "imagelocation"))
        txtplayera.DataBindings.Add(New Binding("Text", bindingsource1, "playersname"))
        txtmatches2.DataBindings.Add(New Binding("Text", bindingsource1, "bt1matches"))
        txtwickets2.DataBindings.Add(New Binding("Text", bindingsource1, "bt1wickets"))
        txtecon2.DataBindings.Add(New Binding("Text", bindingsource1, "bt1econ"))
        txt4w2.DataBindings.Add(New Binding("Text", bindingsource1, "bt13w"))
        txt5w2.DataBindings.Add(New Binding("Text", bindingsource1, "bt15w"))
        txtbest2.DataBindings.Add(New Binding("Text", bindingsource1, "bt1best"))
        txtavg2.DataBindings.Add(New Binding("Text", bindingsource1, "bt1average"))


        txtmatches4.DataBindings.Add(New Binding("Text", bindingsource1, "bt1matches4"))
        txtinnings4.DataBindings.Add(New Binding("Text", bindingsource1, "bt1innings4"))
        txtruns4.DataBindings.Add(New Binding("Text", bindingsource1, "bt1runs4"))
        txtaverage4.DataBindings.Add(New Binding("Text", bindingsource1, "bt1average4"))
        txt50s4.DataBindings.Add(New Binding("Text", bindingsource1, "bt150s4"))
        txt100s4.DataBindings.Add(New Binding("Text", bindingsource1, "bt1100s4"))
        txthighestscore4.DataBindings.Add(New Binding("Text", bindingsource1, "bt1highestscore4"))


        Dim da2 As New OleDbDataAdapter("Select * from porteam2", cn)
        Dim tb2 As New DataTable
        Dim bindingsource2 As New BindingSource
        da2.Fill(tb2)
        bindingsource2.DataSource = tb2
        BindingNavigator2.BindingSource = bindingsource2

        image2.DataBindings.Add(New Binding("imagelocation", bindingsource2, "imagelocation"))
        txtplayerb.DataBindings.Add(New Binding("Text", bindingsource2, "playersname"))
        txtmatches6.DataBindings.Add(New Binding("Text", bindingsource2, "bt1matches"))
        txtwickets6.DataBindings.Add(New Binding("Text", bindingsource2, "bt1wickets"))
        txtecon6.DataBindings.Add(New Binding("Text", bindingsource2, "bt1econ"))
        txt4w6.DataBindings.Add(New Binding("Text", bindingsource2, "bt13w"))
        txt5w6.DataBindings.Add(New Binding("Text", bindingsource2, "bt15w"))
        txtbest6.DataBindings.Add(New Binding("Text", bindingsource2, "bt1best"))
        txtavg6.DataBindings.Add(New Binding("Text", bindingsource2, "bt1average"))


        txtmatches8.DataBindings.Add(New Binding("Text", bindingsource2, "bt1matches4"))
        txtinnings8.DataBindings.Add(New Binding("Text", bindingsource2, "bt1innings4"))
        txtruns8.DataBindings.Add(New Binding("Text", bindingsource2, "bt1runs4"))
        txtaverage8.DataBindings.Add(New Binding("Text", bindingsource2, "bt1average4"))
        txt50s8.DataBindings.Add(New Binding("Text", bindingsource2, "bt150s4"))
        txt100s8.DataBindings.Add(New Binding("Text", bindingsource2, "bt1100s4"))
        txthighestscore8.DataBindings.Add(New Binding("Text", bindingsource2, "bt1highestscore4"))


        cn.Close()
    End Sub
    Private Sub initialisesetscorett()
        dgvsetscorett.Rows.Add(2)
        For isetscorett = 0 To 1
            For jsetscorett = 0 To 6
                dgvsetscorett.Rows(isetscorett).Cells(jsetscorett).Value = isetscorett & jsetscorett
            Next
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

    Sub gymnasticsdefaultdata()
        On Error Resume Next


        dgvGymnastics.Rows.Add(12)

        dgvGymnastics.Rows(0).Cells(0).Value = 1
        dgvGymnastics.Rows(0).Cells(1).Value = "MOHAMAD ALGARNI"
        dgvGymnastics.Rows(0).Cells(2).Value = "A_N"
        dgvGymnastics.Rows(0).Cells(3).Value = 54.91

        dgvGymnastics.Rows(1).Cells(0).Value = 2
        dgvGymnastics.Rows(1).Cells(1).Value = "SANDEEP KARAN SINGH"
        dgvGymnastics.Rows(1).Cells(2).Value = "ARP"
        dgvGymnastics.Rows(1).Cells(3).Value = 32.41

        dgvGymnastics.Rows(2).Cells(0).Value = 3
        dgvGymnastics.Rows(2).Cells(1).Value = "EMAD HAMED NOUR"
        dgvGymnastics.Rows(2).Cells(2).Value = "BIH"
        dgvGymnastics.Rows(2).Cells(3).Value = 51.25

        dgvGymnastics.Rows(3).Cells(0).Value = 4
        dgvGymnastics.Rows(3).Cells(1).Value = "RASHEED RAMZI"
        dgvGymnastics.Rows(3).Cells(2).Value = "CHA"
        dgvGymnastics.Rows(3).Cells(3).Value = 12.25

        dgvGymnastics.Rows(4).Cells(0).Value = 5
        dgvGymnastics.Rows(4).Cells(1).Value = "HAMZA DRIOUCH"
        dgvGymnastics.Rows(4).Cells(2).Value = "DEL"
        dgvGymnastics.Rows(4).Cells(3).Value = 52.58

        dgvGymnastics.Rows(5).Cells(0).Value = 6
        dgvGymnastics.Rows(5).Cells(1).Value = "SANDEEP KARAN SINGH"
        dgvGymnastics.Rows(5).Cells(2).Value = "DNH"
        dgvGymnastics.Rows(5).Cells(3).Value = 54.25

        dgvGymnastics.Rows(6).Cells(0).Value = 7
        dgvGymnastics.Rows(6).Cells(1).Value = "ABDULLAH OBAID"
        dgvGymnastics.Rows(6).Cells(2).Value = "GOA"
        dgvGymnastics.Rows(6).Cells(3).Value = 56.25

        dgvGymnastics.Rows(7).Cells(0).Value = 8
        dgvGymnastics.Rows(7).Cells(1).Value = "AMASSRI WESAM"
        dgvGymnastics.Rows(7).Cells(2).Value = "GUJ"
        dgvGymnastics.Rows(7).Cells(3).Value = 52.14

        dgvGymnastics.Rows(8).Cells(0).Value = 9
        dgvGymnastics.Rows(8).Cells(1).Value = "SAJAD MORADI"
        dgvGymnastics.Rows(8).Cells(2).Value = "KER"
        dgvGymnastics.Rows(8).Cells(3).Value = 32.36

        dgvGymnastics.Rows(9).Cells(0).Value = 10
        dgvGymnastics.Rows(9).Cells(1).Value = "PRANJAL GOGOI"
        dgvGymnastics.Rows(9).Cells(2).Value = "MAH"
        dgvGymnastics.Rows(9).Cells(3).Value = 31.45

        dgvGymnastics.Rows(10).Cells(0).Value = 11
        dgvGymnastics.Rows(10).Cells(1).Value = "MOHAMMAD ALAZEMI"
        dgvGymnastics.Rows(10).Cells(2).Value = "MGA"
        dgvGymnastics.Rows(10).Cells(3).Value = 47.18

        dgvGymnastics.Rows(11).Cells(0).Value = 12
        dgvGymnastics.Rows(11).Cells(1).Value = "YUKI AKIMOTO"
        dgvGymnastics.Rows(11).Cells(2).Value = "ORI"
        dgvGymnastics.Rows(11).Cells(3).Value = 41.42

        For i = 0 To dgvGymnastics.RowCount - 2
            For j = 3 To dgvGymnastics.ColumnCount - 1
                dgvGymnastics.Rows(i).Cells(j).Value = Format(i * j, "00.00")
            Next
        Next

    End Sub

    Private Sub cmdgymnasticsstsrtlist1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgymnasticsstsrtlist1.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        For i = 0 To dgvGymnastics.RowCount - 1


            If dgvGymnastics.Rows(i).Cells(0).Value <> "" Then
                If chkwithnumbergym.Checked Then
                    CasparCGDataCollection.SetData("sn" & i + 1, dgvGymnastics.Rows(i).Cells(0).Value)
                End If
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(i).Cells(2).Value & ".png")
            End If
            CasparCGDataCollection.SetData("name" & i + 1, dgvGymnastics.Rows(i).Cells(1).Value)
        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparCGDataCollection.SetData("startlist", cmbSubHeader.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/startlist1", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdgymnasticsstsrtlist2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgymnasticsstsrtlist2.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        For i = 8 To dgvGymnastics.RowCount - 1

            If dgvGymnastics.Rows(i).Cells(0).Value <> "" Then
                If chkwithnumbergym.Checked Then
                    CasparCGDataCollection.SetData("sn" & i - 7, dgvGymnastics.Rows(i).Cells(0).Value)
                End If

                CasparCGDataCollection.SetData("loader" & i - 7, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i - 7, dgvGymnastics.Rows(i).Cells(1).Value)
            End If

        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparCGDataCollection.SetData("startlist", cmbSubHeader.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/startlist1", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub
    Private Sub cmdresult1gym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresult1gym.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        For i = 0 To dgvGymnastics.RowCount - 1

            If dgvGymnastics.Rows(i).Cells(0).Value <> "" Then
                CasparCGDataCollection.SetData("sn" & i + 1, i + 1)
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i + 1, dgvGymnastics.Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("value" & i + 1, dgvGymnastics.Rows(i).Cells(CType(cmbstandingsgym.Text, Integer)).Value)
                CasparCGDataCollection.SetData("alpha" & i + 1, 1)
            End If

        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparCGDataCollection.SetData("startlist", cmbSubHeader.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/result1", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdresult2gym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresult2gym.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)

        For i = 8 To dgvGymnastics.RowCount - 1

            If dgvGymnastics.Rows(i).Cells(0).Value <> "" Then
                CasparCGDataCollection.SetData("sn" & i - 7, i + 1)
                CasparCGDataCollection.SetData("loader" & i - 7, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i - 7, dgvGymnastics.Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("value" & i - 7, dgvGymnastics.Rows(i).Cells(CType(cmbstandingsgym.Text, Integer)).Value)
                CasparCGDataCollection.SetData("alpha" & i - 7, 1)

            End If

        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparCGDataCollection.SetData("startlist", cmbSubHeader.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/result1", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub gamelogoforgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gamelogo.Click
        On Error Resume Next
        openimage("C:\casparcg\mydata\games\games logo\", sender)
    End Sub

    Private Sub eventlogoforgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eventlogo.Click
        On Error Resume Next
        openimage("C:\casparcg\mydata\games\event logo\", sender)
    End Sub

    Private Sub cmdplayeridgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayeridgym.Click

        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvGymnastics.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("f1", dgvGymnastics.CurrentRow.Cells(1).Value)

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/player_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub
    Private Sub cmdstopgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopgym.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation2()

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergames.Text), Int(cmblayergames.Text))
        Threading.Thread.Sleep(1000)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdvictoryidgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("f1", "Victory Ceremony")
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/victory_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdgoldgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("f1", dgvGymnastics.Rows(0).Cells(1).Value)

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(0).Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/medal_g", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdsilvergym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("f1", dgvGymnastics.Rows(1).Cells(1).Value)

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(1).Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/medal_s", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdbronzegym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("f1", dgvGymnastics.Rows(2).Cells(1).Value)

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(2).Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/medal_b", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdbronze2gym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("f1", dgvGymnastics.Rows(3).Cells(1).Value)
        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(3).Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/medal_b", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdmedalallgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("h1", cmbHeader.Text)
        CasparCGDataCollection.SetData("h2", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        For imedalall = 0 To 2
            CasparCGDataCollection.SetData("t" & imedalall + 1, dgvGymnastics.Rows(imedalall).Cells(1).Value)
            CasparCGDataCollection.SetData("loader" & imedalall + 1, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(imedalall).Cells(2).Value & ".png")
        Next

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/medal_three", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdmedalallbronze2gym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()


        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("h1", cmbHeader.Text)
        CasparCGDataCollection.SetData("h2", cmbSubHeader.Text)

        For imedalallbronze2 = 0 To 3
            CasparCGDataCollection.SetData("t" & imedalallbronze2 + 1, dgvGymnastics.Rows(imedalallbronze2).Cells(1).Value)
            CasparCGDataCollection.SetData("loader" & imedalallbronze2 + 1, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(imedalallbronze2).Cells(2).Value & ".png")
        Next
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/medal_three_bronze2", True, CasparCGDataCollection.ToAMCPEscapedXml)

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
        End If
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill " & x & " " & y & " 1 1 50 easeoutexpo")
    End Sub
    Sub animationtoscreen()
        If chkanimationforhdvan.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill .12 0 .76 1 50 " & "easeoutexpo")
        Else
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill 0 0 1 1 50 " & "easeoutexpo")
        End If
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
        End If
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill " & x & " " & y & " 1 1 50 easeoutexpo")
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gymnastics.Click

    End Sub

    Private Sub newgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newgym.Click
        On Error Resume Next
        newdata(dgvGymnastics, cmbHeader, cmbSubHeader, lblfilenamegym)
    End Sub

    Private Sub opengym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opengym.Click
        On Error Resume Next
        opendata("C:\casparcg\mydata\games\gymnastics\", dgvGymnastics, cmbHeader, cmbSubHeader, lblfilenamegym)
        'opendata()
    End Sub

    Private Sub savegym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savegym.Click
        On Error Resume Next
        savedata("C:\casparcg\mydata\games\gymnastics\", dgvGymnastics, cmbHeader, cmbSubHeader, lblfilenamegym)
        'savedata()
    End Sub

    Private Sub cmdrowupzym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowupzym.Click
        On Error Resume Next
        up(dgvGymnastics)
    End Sub

    Private Sub cmdrowdowngym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowdowngym.Click
        On Error Resume Next
        down(dgvGymnastics)
    End Sub

    Private Sub cmdrowinsertgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowinsertgym.Click
        On Error Resume Next
        insert(dgvGymnastics)
    End Sub
    Private Sub cmdrowdeletegym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowdeletegym.Click
        On Error Resume Next
        delete(dgvGymnastics)
    End Sub

    Private Sub dgvGymnastics_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGymnastics.CellContentClick

    End Sub

    Private Sub dgvGymnastics_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGymnastics.CellValueChanged
        On Error Resume Next
        dgvGymnastics.Rows(e.RowIndex).Cells(9).Value = Format(Val(dgvGymnastics.Rows(e.RowIndex).Cells(3).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(4).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(5).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(6).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(7).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(8).Value), "00.00")

        dgvGymnastics.Rows(e.RowIndex).Cells(14).Value = Format(Val(dgvGymnastics.Rows(e.RowIndex).Cells(10).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(11).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(12).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(13).Value), "00.00")
        If rdoaveragevaultgym.Checked Then
            dgvGymnastics.Rows(e.RowIndex).Cells(22).Value = Format((Val(dgvGymnastics.Rows(e.RowIndex).Cells(20).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(21).Value)) / 2, "00.00")

        Else
            dgvGymnastics.Rows(e.RowIndex).Cells(22).Value = Format(Val(dgvGymnastics.Rows(e.RowIndex).Cells(20).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(21).Value), "00.00")

        End If

        If rdoArtisticsgym.Checked Then
            dgvGymnastics.Rows(e.RowIndex).Cells(27).Value = Format(Val(dgvGymnastics.Rows(e.RowIndex).Cells(23).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(25).Value) - Val(dgvGymnastics.Rows(e.RowIndex).Cells(26).Value), "00.00")

        Else
            dgvGymnastics.Rows(e.RowIndex).Cells(27).Value = Format(Val(dgvGymnastics.Rows(e.RowIndex).Cells(23).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(24).Value) + Val(dgvGymnastics.Rows(e.RowIndex).Cells(25).Value) - Val(dgvGymnastics.Rows(e.RowIndex).Cells(26).Value), "00.00")

        End If


    End Sub

    Private Sub dgvGymnastics_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvGymnastics.DataError
        'dummy dont delete
    End Sub

    Private Sub cmdwelcome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdwelcome.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("w1", w1.Text)
        CasparCGDataCollection.SetData("w2", w2.Text)
        CasparCGDataCollection.SetData("w3", w3.Text)

        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/welcome", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmDvenueid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmDvenueid1.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtvenueid1.Text)

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/venue_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdrefree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrefree.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtrefreename.Text)
        CasparCGDataCollection.SetData("f1", txtrefreedegination.Text)


        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/official_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
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

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/commentators", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdMedalPresentorId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMedalPresentorId.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtofficialname.Text)
        CasparCGDataCollection.SetData("f1", txtofficialdesignation.Text)


        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/official_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
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
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/welcome", True, CasparCGDataCollection.ToAMCPEscapedXml)
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

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/event_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdVaultStandings1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVaultStandings1.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        For i = 0 To dgvGymnastics.RowCount - 1
            If dgvGymnastics.Rows(i).Cells(0).Value <> "" Then
                CasparCGDataCollection.SetData("sn" & i + 1, i + 1)
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i + 1, dgvGymnastics.Rows(i).Cells(1).Value)

                CasparCGDataCollection.SetData("vault1" & i + 1, dgvGymnastics.Rows(i).Cells(20).Value)
                CasparCGDataCollection.SetData("vault2" & i + 1, dgvGymnastics.Rows(i).Cells(21).Value)
                CasparCGDataCollection.SetData("value" & i + 1, dgvGymnastics.Rows(i).Cells(22).Value)
            End If
        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/vault_standings", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdVaultStandings2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVaultStandings2.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        For i = 8 To dgvGymnastics.RowCount - 1
            If dgvGymnastics.Rows(i).Cells(0).Value <> "" Then
                CasparCGDataCollection.SetData("sn" & i - 7, i + 1)
                CasparCGDataCollection.SetData("loader" & i - 7, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i - 7, dgvGymnastics.Rows(i).Cells(1).Value)

                CasparCGDataCollection.SetData("vault1" & i - 7, dgvGymnastics.Rows(i).Cells(20).Value)
                CasparCGDataCollection.SetData("vault2" & i - 7, dgvGymnastics.Rows(i).Cells(21).Value)
                CasparCGDataCollection.SetData("value" & i - 7, dgvGymnastics.Rows(i).Cells(22).Value)
            End If
        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/vault_standings", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdteamlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteamlist.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("subheader", cmbSubHeader.Text)
        For i = 0 To 5
            CasparCGDataCollection.SetData("f" & i, dgvGymnastics.Rows(i).Cells(1).Value)
        Next


        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/teamlist", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub dgvGymnastics_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvGymnastics.DefaultValuesNeeded

        e.Row.Cells(2).Value = "BLK"
    End Sub
    Private Sub dgvforheader_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub cmdeventshedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeventshedule.Click


        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/event_shedule", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub
    Private Sub cmdplayerscore1gym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayerscore1gym.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f1", dgvGymnastics.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("f2", dgvGymnastics.CurrentRow.Cells(9).Value)

        If chkwithnumbergym.Checked Then
            CasparCGDataCollection.SetData("f3", dgvGymnastics.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("alpha", 1)
        Else
            CasparCGDataCollection.SetData("f3", "")
            CasparCGDataCollection.SetData("alpha", 0)
        End If

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/player_score", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdplayerscore2gym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayerscore2gym.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f1", dgvGymnastics.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("f2", dgvGymnastics.CurrentRow.Cells(14).Value)
        If chkwithnumbergym.Checked Then
            CasparCGDataCollection.SetData("f3", dgvGymnastics.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("alpha", 1)
        Else
            CasparCGDataCollection.SetData("f3", "")
            CasparCGDataCollection.SetData("alpha", 0)
        End If

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/player_score", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdplayerscore3gym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayerscore3gym.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f1", dgvGymnastics.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("f2", dgvGymnastics.CurrentRow.Cells(19).Value)

        If chkwithnumbergym.Checked Then
            CasparCGDataCollection.SetData("f3", dgvGymnastics.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("alpha", 1)
        Else
            CasparCGDataCollection.SetData("f3", "")
            CasparCGDataCollection.SetData("alpha", 0)
        End If

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/player_score", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub Build1gym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Build1gym.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", dgvGymnastics.CurrentRow.Cells(1).Value)
        For i = 1 To 7
            CasparCGDataCollection.SetData("f" & i, dgvGymnastics.Columns(i + 2).HeaderText)
            CasparCGDataCollection.SetData("f" & i + 7, dgvGymnastics.CurrentRow.Cells(i + 2).Value)
        Next

        If chkwithnumbergym.Checked Then
            CasparCGDataCollection.SetData("f15", dgvGymnastics.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("alpha", 1)
        Else
            CasparCGDataCollection.SetData("f15", "")
            CasparCGDataCollection.SetData("alpha", 0)
        End If

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/build1", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub Build2gym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Build2gym.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", dgvGymnastics.CurrentRow.Cells(1).Value)
        For i = 1 To 5
            CasparCGDataCollection.SetData("f" & i, dgvGymnastics.Columns(i + 9).HeaderText)
            CasparCGDataCollection.SetData("f" & i + 5, dgvGymnastics.CurrentRow.Cells(i + 9).Value)
        Next

        If chkwithnumbergym.Checked Then
            CasparCGDataCollection.SetData("f15", dgvGymnastics.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("alpha", 1)
        Else
            CasparCGDataCollection.SetData("f15", "")
            CasparCGDataCollection.SetData("alpha", 0)
        End If

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/build2", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub Build3gym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Build3gym.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", dgvGymnastics.CurrentRow.Cells(1).Value)
        For i = 1 To 5
            CasparCGDataCollection.SetData("f" & i, dgvGymnastics.Columns(i + 14).HeaderText)
            CasparCGDataCollection.SetData("f" & i + 5, dgvGymnastics.CurrentRow.Cells(i + 14).Value)
        Next

        If chkwithnumbergym.Checked Then
            CasparCGDataCollection.SetData("f15", dgvGymnastics.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("alpha", 1)
        Else
            CasparCGDataCollection.SetData("f15", "")
            CasparCGDataCollection.SetData("alpha", 0)
        End If

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/build3", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub
    Private Sub cmdplayerscorecardgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayerscorecardgym.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvGymnastics.CurrentRow.Cells(1).Value)
        If rdoArtisticsgym.Checked Then
            CasparCGDataCollection.SetData("f1", dgvGymnastics.Columns(23).HeaderText & " " & dgvGymnastics.CurrentRow.Cells(23).Value & "   " & dgvGymnastics.Columns(25).HeaderText & " " & dgvGymnastics.CurrentRow.Cells(25).Value & "   " & dgvGymnastics.Columns(26).HeaderText & " " & dgvGymnastics.CurrentRow.Cells(26).Value)
            CasparCGDataCollection.SetData("f2", dgvGymnastics.Columns(27).HeaderText & " " & dgvGymnastics.CurrentRow.Cells(27).Value)
            If chkwithnumbergym.Checked Then
                CasparCGDataCollection.SetData("f3", dgvGymnastics.CurrentRow.Index + 1)
                CasparCGDataCollection.SetData("alpha", 1)
            Else
                CasparCGDataCollection.SetData("f3", "")
                CasparCGDataCollection.SetData("alpha", 0)
            End If
        Else
            For i = 23 To 27
                CasparCGDataCollection.SetData("f" & i - 22, dgvGymnastics.Columns(i).HeaderText)
                CasparCGDataCollection.SetData("f" & i - 17, dgvGymnastics.CurrentRow.Cells(i).Value)
            Next

            If chkwithnumbergym.Checked Then
                CasparCGDataCollection.SetData("f15", dgvGymnastics.CurrentRow.Cells(0).Value)
                CasparCGDataCollection.SetData("alpha", 1)
            Else
                CasparCGDataCollection.SetData("f15", "")
                CasparCGDataCollection.SetData("alpha", 0)
            End If
        End If

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        If rdoArtisticsgym.Checked Then
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/PlayerScorecard", True, CasparCGDataCollection.ToAMCPEscapedXml)
        Else
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/PlayerScorecard2", True, CasparCGDataCollection.ToAMCPEscapedXml)
        End If
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdwinneridgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("h1", cmbHeader.Text)
        CasparCGDataCollection.SetData("h2", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("t1", dgvGymnastics.Rows(0).Cells(1).Value)

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(0).Cells(2).Value & ".png")

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/winner", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdofficialsgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdofficialsgym.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        For i = 0 To dgvGymnastics.RowCount - 1

            If dgvGymnastics.Rows(i).Cells(0).Value <> "" Then
                'CasparCGDataCollection.SetData("sn" & i + 1, i + 1)
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i + 1, dgvGymnastics.Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("value" & i + 1, dgvGymnastics.Rows(i).Cells(29).Value)
                CasparCGDataCollection.SetData("alpha" & i + 1, 0)
            End If
        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparCGDataCollection.SetData("startlist", cmbSubHeader.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/Officials", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdteamlistwithgamenamegym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteamlistwithgamenamegym.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbHeader.Text)
        For i = 0 To dgvGymnastics.RowCount - 1

            If dgvGymnastics.Rows(i).Cells(0).Value <> "" Then
                'CasparCGDataCollection.SetData("sn" & i + 1, i + 1)
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i + 1, dgvGymnastics.Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("value" & i + 1, dgvGymnastics.Rows(i).Cells(28).Value)
                CasparCGDataCollection.SetData("alpha" & i + 1, 0)
            End If

        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparCGDataCollection.SetData("startlist", cmbSubHeader.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/Officials", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub rdoArtisticsgym_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoArtisticsgym.CheckedChanged, rdoRhythmicgym.CheckedChanged
        On Error Resume Next
        For i = 0 To dgvGymnastics.RowCount - 1
            If rdoArtisticsgym.Checked Then
                dgvGymnastics.Rows(i).Cells(27).Value = Format(Val(dgvGymnastics.Rows(i).Cells(23).Value) + Val(dgvGymnastics.Rows(i).Cells(25).Value) - Val(dgvGymnastics.Rows(i).Cells(26).Value), "00.000")

            Else
                dgvGymnastics.Rows(i).Cells(27).Value = Format(Val(dgvGymnastics.Rows(i).Cells(23).Value) + Val(dgvGymnastics.Rows(i).Cells(24).Value) + Val(dgvGymnastics.Rows(i).Cells(25).Value) - Val(dgvGymnastics.Rows(i).Cells(26).Value), "00.000")

            End If
        Next
    End Sub

    Private Sub cmdw1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdw1.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/opening", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdtop3standingsgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtop3standingsgym.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        For i = 0 To dgvGymnastics.RowCount - 1

            If dgvGymnastics.Rows(i).Cells(0).Value <> "" Then
                'CasparCGDataCollection.SetData("sn" & i + 1, i + 1)
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i + 1, dgvGymnastics.Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("value" & i + 1, dgvGymnastics.Rows(i).Cells(CType(cmbstandingsgym.Text, Integer)).Value)
                CasparCGDataCollection.SetData("alpha" & i + 1, 1)
            End If

        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparCGDataCollection.SetData("startlist", cmbSubHeader.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/top_three", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdplayerscorecard2ndvaultgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayerscorecard2ndvaultgym.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvGymnastics.CurrentRow.Cells(1).Value)
        If rdoArtisticsgym.Checked Then
            CasparCGDataCollection.SetData("f1", dgvGymnastics.Columns(23).HeaderText & " " & dgvGymnastics.CurrentRow.Cells(23).Value & "   " & dgvGymnastics.Columns(25).HeaderText & " " & dgvGymnastics.CurrentRow.Cells(25).Value & "   " & dgvGymnastics.Columns(26).HeaderText & " " & dgvGymnastics.CurrentRow.Cells(26).Value)
            CasparCGDataCollection.SetData("f2", dgvGymnastics.Columns(27).HeaderText & " " & dgvGymnastics.CurrentRow.Cells(27).Value)
            CasparCGDataCollection.SetData("f4", dgvGymnastics.Columns(20).HeaderText & " " & dgvGymnastics.CurrentRow.Cells(20).Value)
            If rdoaveragevaultgym.Checked Then
                CasparCGDataCollection.SetData("f5", "Total" & " " & (Val(dgvGymnastics.CurrentRow.Cells(27).Value) + Val(dgvGymnastics.CurrentRow.Cells(20).Value)) / 2)
            Else
                CasparCGDataCollection.SetData("f5", "Total" & " " & (Val(dgvGymnastics.CurrentRow.Cells(27).Value) + Val(dgvGymnastics.CurrentRow.Cells(20).Value)))

            End If


            If chkwithnumbergym.Checked Then
                CasparCGDataCollection.SetData("f3", dgvGymnastics.CurrentRow.Index + 1)
                CasparCGDataCollection.SetData("alpha", 1)
            Else
                CasparCGDataCollection.SetData("f3", "")
                CasparCGDataCollection.SetData("alpha", 0)
            End If
        Else
            For i = 23 To 27
                CasparCGDataCollection.SetData("f" & i - 22, dgvGymnastics.Columns(i).HeaderText)
                CasparCGDataCollection.SetData("f" & i - 17, dgvGymnastics.CurrentRow.Cells(i).Value)
            Next

            If chkwithnumbergym.Checked Then
                CasparCGDataCollection.SetData("f15", dgvGymnastics.CurrentRow.Cells(0).Value)
                CasparCGDataCollection.SetData("alpha", 1)
            Else
                CasparCGDataCollection.SetData("f15", "")
                CasparCGDataCollection.SetData("alpha", 0)
            End If
        End If

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        If rdoArtisticsgym.Checked Then
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/PlayerScorecard2ndvault", True, CasparCGDataCollection.ToAMCPEscapedXml)
        Else
            'CasparDevice.Channels(g_int_ChannelNumber-1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/PlayerScorecard2", True, CasparCGDataCollection.ToAMCPEscapedXml)
        End If
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub


    Private Sub cmdplayergamepointgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayergamepointgym.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f1", dgvGymnastics.CurrentRow.Cells(1).Value)
        CasparCGDataCollection.SetData("f2", dgvGymnastics.Columns(CType(cmbplayergamepointgym.Text, Integer)).HeaderText)
        CasparCGDataCollection.SetData("f4", dgvGymnastics.CurrentRow.Cells(CType(cmbplayergamepointgym.Text, Integer)).Value)

        If chkwithnumbergym.Checked Then
            CasparCGDataCollection.SetData("f3", dgvGymnastics.CurrentRow.Cells(0).Value)
            CasparCGDataCollection.SetData("alpha", 1)
        Else
            CasparCGDataCollection.SetData("f3", "")
            CasparCGDataCollection.SetData("alpha", 0)
        End If

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvGymnastics.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Gymnastics/player_any_score", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdchangecolumnnamegym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdchangecolumnnamegym.Click
        On Error Resume Next
        dgvGymnastics.Columns(CType(cmbchangecolumnnamegym.Text, Integer)).HeaderText = txtchangecolumnnamegym.Text
    End Sub

    Private Sub cmbgames_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgames.SelectedIndexChanged
        If cmbgames.Text = "Aquatics" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games\games logo\AQ" & ".png"
        If cmbgames.Text = "Atheletics" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games\games logo\AT" & ".png"
        If cmbgames.Text = "Badminton" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games\games logo\BD" & ".png"
        If cmbgames.Text = "Basketball" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games\games logo\BK" & ".png"
        If cmbgames.Text = "Boxing" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games\games logo\BX" & ".png"
        If cmbgames.Text = "Football" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games\games logo\FB" & ".png"
        If cmbgames.Text = "Gymnastics - Artistic" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games\games logo\Gymnastics - Artistic" & ".png"
        If cmbgames.Text = "Gymnastics - Rhythmic" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games\games logo\Gymnastics - Rhythmic" & ".png"
        If cmbgames.Text = "Gymnastics - Trampoline" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games\games logo\Gymnastics - Trampoline" & ".png"
        If cmbgames.Text = "hockey" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games\games logo\HO" & ".png"
        If cmbgames.Text = "Kabaddi" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games\games logo\KB" & ".png"
        If cmbgames.Text = "Shooting" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games\games logo\SH" & ".png"
        If cmbgames.Text = "TableTennis" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games\games logo\TT" & ".png"
        If cmbgames.Text = "Tennis" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games\games logo\TE" & ".png"
        If cmbgames.Text = "Volleyball" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games\games logo\VB" & ".png"
        If cmbgames.Text = "Weight lift" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games\games logo\WL" & ".png"
        If cmbgames.Text = "Wrestling" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games\games logo\WR" & ".png"
        If cmbgames.Text = "Black" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games\games logo\BLK" & ".png"
        If cmbgames.Text = "Handball" Then gamelogo.ImageLocation = "C:\casparcg\mydata\games\games logo\hb" & ".png"


    End Sub

    Private Sub gamelogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        Dim picofd As New OpenFileDialog
        picofd.InitialDirectory = "C:\casparcg\mydata\games\games logo\"
        If (picofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            gamelogo.ImageLocation = picofd.FileName
        End If
    End Sub

    Private Sub piceventcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        Dim picofd As New OpenFileDialog
        picofd.InitialDirectory = "C:\casparcg\mydata\games\games logo\"
        If (picofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            eventlogo.ImageLocation = picofd.FileName
        End If
    End Sub
    ' Shooting code----------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub shootingdefaultdata()
        On Error Resume Next


        dgvShooting.Rows.Add(12)

        dgvShooting.Rows(0).Cells(0).Value = 1
        dgvShooting.Rows(0).Cells(1).Value = "MOHAMAD ALGARNI"
        dgvShooting.Rows(0).Cells(2).Value = "A_N"
        dgvShooting.Rows(0).Cells(3).Value = 54.914

        dgvShooting.Rows(1).Cells(0).Value = 2
        dgvShooting.Rows(1).Cells(1).Value = "SANDEEP KARAN SINGH"
        dgvShooting.Rows(1).Cells(2).Value = "ARP"
        dgvShooting.Rows(1).Cells(3).Value = 32.412

        dgvShooting.Rows(2).Cells(0).Value = 3
        dgvShooting.Rows(2).Cells(1).Value = "EMAD HAMED NOUR"
        dgvShooting.Rows(2).Cells(2).Value = "BIH"
        dgvShooting.Rows(2).Cells(3).Value = 51.251

        dgvShooting.Rows(3).Cells(0).Value = 4
        dgvShooting.Rows(3).Cells(1).Value = "RASHEED RAMZI"
        dgvShooting.Rows(3).Cells(2).Value = "CHA"
        dgvShooting.Rows(3).Cells(3).Value = 12.256

        dgvShooting.Rows(4).Cells(0).Value = 5
        dgvShooting.Rows(4).Cells(1).Value = "HAMZA DRIOUCH"
        dgvShooting.Rows(4).Cells(2).Value = "DEL"
        dgvShooting.Rows(4).Cells(3).Value = 52.586

        dgvShooting.Rows(5).Cells(0).Value = 6
        dgvShooting.Rows(5).Cells(1).Value = "SANDEEP KARAN SINGH"
        dgvShooting.Rows(5).Cells(2).Value = "DNH"
        dgvShooting.Rows(5).Cells(3).Value = 54.258

        dgvShooting.Rows(6).Cells(0).Value = 7
        dgvShooting.Rows(6).Cells(1).Value = "ABDULLAH OBAID"
        dgvShooting.Rows(6).Cells(2).Value = "GOA"
        dgvShooting.Rows(6).Cells(3).Value = 56.258

        dgvShooting.Rows(7).Cells(0).Value = 8
        dgvShooting.Rows(7).Cells(1).Value = "AMASSRI WESAM"
        dgvShooting.Rows(7).Cells(2).Value = "GUJ"
        dgvShooting.Rows(7).Cells(3).Value = 52.147

        dgvShooting.Rows(8).Cells(0).Value = 9
        dgvShooting.Rows(8).Cells(1).Value = "SAJAD MORADI"
        dgvShooting.Rows(8).Cells(2).Value = "KER"
        dgvShooting.Rows(8).Cells(3).Value = 32.365

        dgvShooting.Rows(9).Cells(0).Value = 10
        dgvShooting.Rows(9).Cells(1).Value = "PRANJAL GOGOI"
        dgvShooting.Rows(9).Cells(2).Value = "MAH"
        dgvShooting.Rows(9).Cells(3).Value = 31.457

        dgvShooting.Rows(10).Cells(0).Value = 11
        dgvShooting.Rows(10).Cells(1).Value = "MOHAMMAD ALAZEMI"
        dgvShooting.Rows(10).Cells(2).Value = "MGA"
        dgvShooting.Rows(10).Cells(3).Value = 47.185

        dgvShooting.Rows(11).Cells(0).Value = 12
        dgvShooting.Rows(11).Cells(1).Value = "YUKI AKIMOTO"
        dgvShooting.Rows(11).Cells(2).Value = "ORI"
        dgvShooting.Rows(11).Cells(3).Value = 41.421

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
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games/State_Short_Name/" & dgvShooting.Rows(i).Cells(2).Value & ".png")
            End If
            CasparCGDataCollection.SetData("name" & i + 1, dgvShooting.Rows(i).Cells(1).Value)
        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparCGDataCollection.SetData("startlist", cmbSubHeader.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Shooting/startlist1", True, CasparCGDataCollection.ToAMCPEscapedXml)

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

                CasparCGDataCollection.SetData("loader" & i - 7, "C:/casparcg/mydata/games/State_Short_Name/" & dgvShooting.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i - 7, dgvShooting.Rows(i).Cells(1).Value)
            End If

        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparCGDataCollection.SetData("startlist", cmbSubHeader.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Shooting/startlist1", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdplayeridShooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayeridShooting.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvShooting.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("f1", dgvShooting.CurrentRow.Cells(1).Value)

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvShooting.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Shooting/player_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
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

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Shooting/event_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub


    Private Sub cmdrowinsertShooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowinsertShooting.Click
        On Error Resume Next
        With dgvShooting
            .Rows.Insert(.CurrentRow.Index)
        End With
    End Sub
    Private Sub cmdrowdownShooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowdownShooting.Click
        down(dgvShooting)
    End Sub
    Private Sub tsShooting_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsShooting.ItemClicked

    End Sub
    Private Sub cmdrowupShooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowupShooting.Click
        up(dgvShooting)
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

        opendata("C:\casparcg\mydata\games\shooting\", dgvShooting, cmbHeader, cmbSubHeader, lblfilenameShooting)
    End Sub


    Private Sub saveShooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveShooting.Click
        savedata("C:\casparcg\mydata\games\shooting\", dgvShooting, cmbHeader, cmbSubHeader, lblfilenameShooting)
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
            aa.InitialDirectory = "C:\casparcg\mydata\games\GAMES2015\State_Full_Name\"
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

            .Rows(0).Cells(0).Value = Image.FromFile("C:\casparcg\mydata\games\State_Short_Name\bih.png")
            .Rows(0).Cells(1).Value = "BIHAR"
            .Rows(0).Cells(2).Value = "C:\casparcg\mydata\games\State_Short_Name\bih.png"

            .Rows(1).Cells(0).Value = Image.FromFile("C:\casparcg\mydata\games\State_Short_Name\goa.png")
            .Rows(1).Cells(1).Value = "GOA"
            .Rows(1).Cells(2).Value = "C:\casparcg\mydata\games\State_Short_Name\GOA.png"

            .Rows(2).Cells(0).Value = Image.FromFile("C:\casparcg\mydata\games\State_Short_Name\DEL.png")
            .Rows(2).Cells(1).Value = "DELHI"
            .Rows(2).Cells(2).Value = "C:\casparcg\mydata\games\State_Short_Name\DEL.png"

            .Rows(3).Cells(0).Value = Image.FromFile("C:\casparcg\mydata\games\State_Short_Name\KER.png")
            .Rows(3).Cells(1).Value = "KERALA"
            .Rows(3).Cells(2).Value = "C:\casparcg\mydata\games\State_Short_Name\KER.png"



            .Rows(4).Cells(0).Value = Image.FromFile("C:\casparcg\mydata\games\State_Short_Name\ASM.png")
            .Rows(4).Cells(1).Value = "ASAM"
            .Rows(4).Cells(2).Value = "C:\casparcg\mydata\games\State_Short_Name\ASM.png"

            .Rows(5).Cells(0).Value = Image.FromFile("C:\casparcg\mydata\games\State_Short_Name\CHA.png")
            .Rows(5).Cells(1).Value = "CHANDIGARH"
            .Rows(5).Cells(2).Value = "C:\casparcg\mydata\games\State_Short_Name\CHA.png"



            .Rows(6).Cells(0).Value = Image.FromFile("C:\casparcg\mydata\games\State_Short_Name\A_N.png")
            .Rows(6).Cells(1).Value = "ANDAMAN NICOBAR"
            .Rows(6).Cells(2).Value = "C:\casparcg\mydata\games\State_Short_Name\A_N.png"

            .Rows(7).Cells(0).Value = Image.FromFile("C:\casparcg\mydata\games\State_Short_Name\PUN.png")
            .Rows(7).Cells(1).Value = "PUNJAB"
            .Rows(7).Cells(2).Value = "C:\casparcg\mydata\games\State_Short_Name\PUN.png"

        End With
    End Sub

    Private Sub cmdRoadToSemiFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRoadToSemiFinal.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbheadercg.Text)
        CasparCGDataCollection.SetData("header2", cmbsubheadercg.Text)
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

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/RoadToSemiFinal", True, CasparCGDataCollection.ToAMCPEscapedXml)

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

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/event_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
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
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/medal_g", True, CasparCGDataCollection.ToAMCPEscapedXml)

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
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/medal_s", True, CasparCGDataCollection.ToAMCPEscapedXml)

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
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/medal_b", True, CasparCGDataCollection.ToAMCPEscapedXml)

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
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/medal_b", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdvictoryidcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdvictoryidcg.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", cmbSubHeader.Text)
        CasparCGDataCollection.SetData("f1", "Victory Ceremony")
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/victory_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdrunnerupridcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrunnerupridcg.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("h1", cmbHeader.Text)
        If rdosinglecg.Checked Then
            CasparCGDataCollection.SetData("h2", "Runner Up-" & cmbsubheadercg.Text)
        Else
            CasparCGDataCollection.SetData("h2", "Runners Up-" & cmbsubheadercg.Text)
        End If


        CasparCGDataCollection.SetData("t1", dgvwinner.Rows(1).Cells(1).Value)


        CasparCGDataCollection.SetData("loader1", dgvwinner.Rows(1).Cells(2).Value)

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg//winner", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdwinneridcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdwinneridcg.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("h1", cmbHeader.Text)
        If rdosinglecg.Checked Then
            CasparCGDataCollection.SetData("h2", "Winner-" & cmbsubheadercg.Text)
        Else
            CasparCGDataCollection.SetData("h2", "Winners-" & cmbsubheadercg.Text)
        End If


        CasparCGDataCollection.SetData("t1", dgvwinner.Rows(0).Cells(1).Value)


        CasparCGDataCollection.SetData("loader1", dgvwinner.Rows(0).Cells(2).Value)

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/winner", True, CasparCGDataCollection.ToAMCPEscapedXml)

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

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/medal_three", True, CasparCGDataCollection.ToAMCPEscapedXml)

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


        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/medal_three_bronze2", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdplayeridcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayeridcg.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvwinner.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("f1", dgvwinner.CurrentRow.Cells(1).Value)

        CasparCGDataCollection.SetData("loader1", dgvwinner.CurrentRow.Cells(2).Value)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/player_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
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


            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & .CurrentRow.Cells(2).Value & ".png")
            CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/shooting/player_score", True, CasparCGDataCollection.ToAMCPEscapedXml)
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
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games/State_Short_Name/" & dgvShooting.Rows(i).Cells(2).Value & ".png")
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
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/shooting/result1", True, CasparCGDataCollection.ToAMCPEscapedXml)
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


            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & .CurrentRow.Cells(2).Value & ".png")
            CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/shooting/PlayerScorecard", True, CasparCGDataCollection.ToAMCPEscapedXml)

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


            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & .CurrentRow.Cells(2).Value & ".png")
            CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/shooting/PlayerScorecard2", True, CasparCGDataCollection.ToAMCPEscapedXml)

            If chkanimationzym.Checked Then animationtoscreen()
        End With
    End Sub
    Private Sub cmdtop3standingsShooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtop3standingsShooting.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        With dgvShooting
            For i = 0 To .RowCount - 1

                If .Rows(i).Cells(0).Value <> "" Then

                    CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games/State_Short_Name/" & .Rows(i).Cells(2).Value & ".png")
                    CasparCGDataCollection.SetData("name" & i + 1, .Rows(i).Cells(1).Value)
                    CasparCGDataCollection.SetData("value" & i + 1, .Rows(i).Cells(CType(cmbstandingsShooting.Text, Integer)).Value)
                    CasparCGDataCollection.SetData("alpha" & i + 1, 1)
                End If

            Next
            CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
            CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

            CasparCGDataCollection.SetData("startlist", txttop3.Text)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/shooting/top_three", True, CasparCGDataCollection.ToAMCPEscapedXml)
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
            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & .CurrentRow.Cells(2).Value & ".png")
            CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/shooting/player_any_score", True, CasparCGDataCollection.ToAMCPEscapedXml)

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
        seriestemplate("Series 1", 4, 5, "cmp/games/shooting/series_score1", 6)
    End Sub

    Private Sub cmdseries2shooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries2shooting.Click
        On Error Resume Next
        seriestemplate("Series 2", 7, 8, "cmp/games/shooting/series_score1", 9)
    End Sub

    Private Sub cmdseries3shooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries3shooting.Click
        On Error Resume Next
        seriestemplate("Series 3", 10, 11, "cmp/games/shooting/series_score2")
    End Sub

    Private Sub cmdseries4shooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries4shooting.Click
        On Error Resume Next
        seriestemplate("Series 4", 12, 13, "cmp/games/shooting/series_score2")
    End Sub

    Private Sub cmdseries5shooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries5shooting.Click
        On Error Resume Next
        seriestemplate("Series 5", 14, 15, "cmp/games/shooting/series_score2")
    End Sub

    Private Sub cmdseries6shooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries6shooting.Click
        On Error Resume Next
        seriestemplate("Series 6", 16, 17, "cmp/games/shooting/series_score2")
    End Sub

    Private Sub cmdseries7shooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries7shooting.Click
        On Error Resume Next
        seriestemplate("Series 7", 18, 19, "cmp/games/shooting/series_score2")

    End Sub

    Private Sub cmdseries8shooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries8shooting.Click
        On Error Resume Next
        seriestemplate("Series 8", 20, 21, "cmp/games/shooting/series_score2")
    End Sub

    Private Sub cmdseries9shooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries9shooting.Click
        On Error Resume Next
        seriestemplate("Series 9", 22, 23, "cmp/games/shooting/series_score2")
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

            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & .CurrentRow.Cells(2).Value & ".png")

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

            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & .CurrentRow.Cells(2).Value & ".png")
            CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), templatename, True, CasparCGDataCollection.ToAMCPEscapedXml)
            If chkanimationzym.Checked Then animationtoscreen()
        End With
    End Sub
    Private Sub cmdseries1shooting25m_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries1shooting25m.Click
        On Error Resume Next
        seriestemplate25m("Series 1", 4, 5, 6, 7, 8, "cmp/games/shooting/series_score25m")
    End Sub

    Private Sub cmdseries2shooting25m_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries2shooting25m.Click
        On Error Resume Next
        seriestemplate25m("Series 2", 9, 10, 11, 12, 13, "cmp/games/shooting/series_score25m")

    End Sub

    Private Sub cmdseries3shooting25m_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries3shooting25m.Click
        On Error Resume Next
        seriestemplate25m("Series 3", 14, 15, 16, 17, 18, "cmp/games/shooting/series_score25m")

    End Sub

    Private Sub cmdseries4shooting25m_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries4shooting25m.Click
        On Error Resume Next
        seriestemplate25m("Series 4", 19, 20, 21, 22, 23, "cmp/games/shooting/series_score25m")

    End Sub

    Private Sub cmdseries5shooting25m_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdseries5shooting25m.Click
        On Error Resume Next
        seriestemplate25m("Series 5", 24, 25, 26, 27, 28, "cmp/games/shooting/series_score25m")

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

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games/State_Short_Name/" & dgvShooting.CurrentRow.Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader2", "C:/casparcg/mydata/games/State_Short_Name/" & dgvShooting.Rows(dgvShooting.CurrentRow.Index + 1).Cells(2).Value & ".png")


        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/Shooting/medalMatch", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()
    End Sub


    Private Sub cmdShootoffshooting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShootoffshooting.Click
        On Error Resume Next
        seriestemplate25m("Shoot-Off", 30, 31, 32, 33, 34, "cmp/games/shooting/Shootoffshooting25")
        CasparCGDataCollection.SetData("f3", "+" & dgvShooting.CurrentRow.Cells(35).Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)


    End Sub

    Private Sub cmdroadtofinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdroadtofinal.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("header1", cmbheadercg.Text)
        CasparCGDataCollection.SetData("header2", cmbsubheadercg.Text)
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


        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/cg/RoadToFinal", True, CasparCGDataCollection.ToAMCPEscapedXml)

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


    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Click

    End Sub

    Private Sub rdoaveragevaultgym_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoaveragevaultgym.CheckedChanged, rdoaddvaultgym.CheckedChanged
        On Error Resume Next
        For i = 0 To dgvGymnastics.RowCount - 1
            If rdoaveragevaultgym.Checked Then
                dgvGymnastics.Rows(i).Cells(22).Value = Format((Val(dgvGymnastics.Rows(i).Cells(20).Value) + Val(dgvGymnastics.Rows(i).Cells(21).Value)) / 2, "00.00")
            Else
                dgvGymnastics.Rows(i).Cells(22).Value = Format(Val(dgvGymnastics.Rows(i).Cells(20).Value) + Val(dgvGymnastics.Rows(i).Cells(21).Value), "00.00")
            End If
        Next
    End Sub

    Private Sub cmdcleardatagym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcleardatagym.Click
        On Error Resume Next
        For i = 0 To dgvGymnastics.RowCount - 1
            For j = 3 To dgvGymnastics.ColumnCount - 1
                dgvGymnastics.Rows(i).Cells(j).Value = ""
            Next

        Next
    End Sub

    Private Sub pict1logoball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pict1logoball.Click
        On Error Resume Next
        txtt1ball.Text = openimage("C:\casparcg\mydata\games\State_Full_Name", sender)
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
        txtt2ball.Text = openimage("C:\casparcg\mydata\games\State_Full_Name", sender)
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



        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "cmp/games/ball/score", True, CasparCGDataCollection.ToAMCPEscapedXml)
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

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "cmp/games/ball/score", True, CasparCGDataCollection.ToAMCPEscapedXml)
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
        showtemplate("cmp/games/ball/teamlineup", CasparCGDataCollection.ToAMCPEscapedXml)
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
        showtemplate("cmp/games/ball/teamlineup", CasparCGDataCollection.ToAMCPEscapedXml)
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
        showtemplate("cmp/games/ball/yellow_card", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdt2yball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2yball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("loader1", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games/ball/yellow_card", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
    Private Sub cmdt1rball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt1rball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvt1ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games/ball/red_card", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdt1gball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt1gball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvt1ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games/ball/goal", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdt2rball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2rball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("loader1", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games/ball/red_card", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdt2gball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2gball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("loader1", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games/ball/goal", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdt1inoutball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt1inoutball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtt1inball.Text)
        CasparCGDataCollection.SetData("f1", txtt1outball.Text)
        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games/ball/in_out", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdt2inoutball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdt2inoutball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtt2inball.Text)
        CasparCGDataCollection.SetData("f1", txtt2outball.Text)
        CasparCGDataCollection.SetData("loader1", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games/ball/in_out", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdteam2inball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteam2inball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtt2inball.Text)
        CasparCGDataCollection.SetData("f1", txtt2outball.Text)
        CasparCGDataCollection.SetData("loader1", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games/ball/in", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdteam1inball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteam1inball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtt1inball.Text)
        CasparCGDataCollection.SetData("f1", txtt1outball.Text)
        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games/ball/in", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub


    Private Sub cmdteam2outball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteam2outball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", txtt2outball.Text)
        CasparCGDataCollection.SetData("loader1", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games/ball/out", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
    Private Sub cmdteam1outball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteam1outball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", txtt1outball.Text)
        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games/ball/out", CasparCGDataCollection.ToAMCPEscapedXml)
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
        showtemplate("cmp/games/cg/versus", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub


    Private Sub cmdsavet1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsavet1ball.Click
        On Error Resume Next
        savedata("C:\casparcg\mydata\games\ball\", dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)
    End Sub

    Private Sub cmdnewt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnewt1ball.Click
        On Error Resume Next
        newdata(dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)
    End Sub

    Private Sub cmdopent1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdopent1ball.Click
        On Error Resume Next
        opendata("C:\casparcg\mydata\games\ball\", dgvt1ball, cmbHeader, cmbSubHeader, lblfilenamet1ball)

    End Sub

    Private Sub cmduprowt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmduprowt1ball.Click
        On Error Resume Next
        up(dgvt1ball)
    End Sub

    Private Sub cmddownrowt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddownrowt1ball.Click
        On Error Resume Next
        down(dgvt1ball)
    End Sub

    Private Sub cmdaddrowt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaddrowt1ball.Click
        insert(dgvt1ball)
    End Sub

    Private Sub cmdremoverowt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremoverowt1ball.Click
        delete(dgvt1ball)
    End Sub

    Private Sub cmdnewt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnewt2ball.Click
        newdata(dgvt2ball, cmbHeader, cmbSubHeader, lblfilenamet2ball)

    End Sub

    Private Sub cmdopent2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdopent2ball.Click
        On Error Resume Next
        opendata("C:\casparcg\mydata\games\ball\", dgvt2ball, cmbHeader, cmbSubHeader, lblfilenamet2ball)

    End Sub

    Private Sub cmdsavet2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsavet2ball.Click
        On Error Resume Next
        savedata("C:\casparcg\mydata\games\ball\", dgvt2ball, cmbHeader, cmbSubHeader, lblfilenamet2ball)

    End Sub

    Private Sub cmduprowt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmduprowt2ball.Click
        up(dgvt2ball)
    End Sub

    Private Sub cmdremoverowt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremoverowt2ball.Click
        delete(dgvt2ball)
    End Sub

    Private Sub cmdaddrowt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaddrowt2ball.Click
        insert(dgvt2ball)
    End Sub

    Private Sub cmddownrowt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddownrowt2ball.Click
        down(dgvt2ball)
    End Sub


    Private Sub cmdeventidcg_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeventidcg.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", cmbheadercg.Text)
        CasparCGDataCollection.SetData("f1", cmbsubheadercg.Text)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        showtemplate("cmp/games/cg/event_id", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdplayeridt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayeridt1ball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f1", dgvt1ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        showtemplate("cmp/games/ball/player_id", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdplayeridt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayeridt2ball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f1", dgvt2ball.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("loader1", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        showtemplate("cmp/games/ball/player_id", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdtteamridt1ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtteamridt1ball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f1", txtt1ball.Text)
        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        showtemplate("cmp/games/cg/player_id", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdtteamridt2ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtteamridt2ball.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f1", txtt2ball.Text)
        CasparCGDataCollection.SetData("loader1", pict2logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        showtemplate("cmp/games/cg/player_id", CasparCGDataCollection.ToAMCPEscapedXml)

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
        showtemplate("cmp/games/cg/versus", CasparCGDataCollection.ToAMCPEscapedXml)

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
        showtemplate("cmp/games/ball/Goal_Summary", CasparCGDataCollection.ToAMCPEscapedXml)

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


        showtemplate("cmp/games/cg/group", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub tsnewcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsnewcg.Click
        On Error Resume Next
        newdata(dgvwinner, cmbheadercg, cmbsubheadercg, lblfilenamecg)
    End Sub

    Private Sub tsopencg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsopencg.Click
        On Error Resume Next
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog

        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = "C:\casparcg\mydata\games\cg\"
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
        On Error Resume Next
        Dim osd2 As New SaveFileDialog
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "C:\casparcg\mydata\games\cg\"
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
        up(dgvwinner)
    End Sub

    Private Sub cmddowncg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddowncg.Click
        On Error Resume Next
        down(dgvwinner)
    End Sub

    Private Sub cmdinsercg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdinsercg.Click
        On Error Resume Next
        insert(dgvwinner)
    End Sub

    Private Sub cmddeleteg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddeleteg.Click
        On Error Resume Next
        delete(dgvwinner)
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


        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "cmp/games/ball/score", True, CasparCGDataCollection.ToAMCPEscapedXml)
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


        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "cmp/games/ball/score", True, CasparCGDataCollection.ToAMCPEscapedXml)
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
        showtemplate("cmp/games/cg/oneliner", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
    Private Sub cmdleftotopcg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdleftotopcg.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", cmblefttopcg.Text)
        showtemplate("cmp/games/cg/lefttop", CasparCGDataCollection.ToAMCPEscapedXml)
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
        showtemplate("cmp/games/ball/set7", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub Ball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ball.Click

    End Sub

    Private Sub dgvsetscoreball_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvsetscoreball.CellContentClick

    End Sub

    Private Sub pict1tt_Click(sender As System.Object, e As System.EventArgs) Handles pict1tt.Click
        On Error Resume Next
        openlogoandcountryfullname(sender, e, txtfullnamet1tt)
    End Sub

    Private Sub pict2tt_Click(sender As System.Object, e As System.EventArgs) Handles pict2tt.Click
        On Error Resume Next
        openlogoandcountryfullname(sender, e, txtfullnamet2tt)
    End Sub

    Private Sub cmdpointdecreaset1tt_Click(sender As System.Object, e As System.EventArgs) Handles cmdpointdecreaset1tt.Click
        On Error Resume Next
        If rdolawntennis.Checked Then
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
        If rdolawntennis.Checked Then
            If txtpointt1tt.Text = "0" Then txtpointt1tt.Text = "15" : Exit Sub
            If txtpointt1tt.Text = "15" Then txtpointt1tt.Text = "30" : Exit Sub
            If txtpointt1tt.Text = "30" Then txtpointt1tt.Text = "40" : Exit Sub
            If txtpointt1tt.Text = "40" Then txtpointt1tt.Text = "Ad" : Exit Sub
            If txtpointt1tt.Text = "Ad" Then txtpointt1tt.Text = "0" : Exit Sub
        Else
            txtpointt1tt.Text = txtpointt1tt.Text + 1
        End If

    End Sub

    Private Sub cmdpointincreaset2tt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpointincreaset2tt.Click
        On Error Resume Next
        If rdolawntennis.Checked Then
            If txtpointt2tt.Text = "0" Then txtpointt2tt.Text = "15" : Exit Sub
            If txtpointt2tt.Text = "15" Then txtpointt2tt.Text = "30" : Exit Sub
            If txtpointt2tt.Text = "30" Then txtpointt2tt.Text = "40" : Exit Sub
            If txtpointt2tt.Text = "40" Then txtpointt2tt.Text = "Ad" : Exit Sub
            If txtpointt2tt.Text = "Ad" Then txtpointt2tt.Text = "0" : Exit Sub

        Else
            txtpointt2tt.Text = txtpointt2tt.Text + 1
        End If
    End Sub

    Private Sub cmdpointdecreaset2tt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpointdecreaset2tt.Click
        On Error Resume Next
        If rdolawntennis.Checked Then
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
                CasparCGDataCollection.SetData("loader3", "c:/casparcg/mydata/tt/serve.png")
                CasparCGDataCollection.SetData("loader4", "c:/casparcg/mydata/tt/blk.png")
            Else
                CasparCGDataCollection.SetData("loader3", "c:/casparcg/mydata/tt/blk.png")
                CasparCGDataCollection.SetData("loader4", "c:/casparcg/mydata/tt/serve.png")
            End If
        End If

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        If chkshowsettt.Checked = False Then
            showtemplate("cmp/games/tt/score", CasparCGDataCollection.ToAMCPEscapedXml)
        Else
            showtemplate("cmp/games/tt/scorewithset", CasparCGDataCollection.ToAMCPEscapedXml)
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
        If chkshowservicett.Checked Then
            If rdoservicet1tt.Checked Then
                CasparCGDataCollection.SetData("loader3", "c:/casparcg/mydata/tt/serve.png")
                CasparCGDataCollection.SetData("loader4", "c:/casparcg/mydata/tt/blk.png")
            Else
                CasparCGDataCollection.SetData("loader3", "c:/casparcg/mydata/tt/blk.png")
                CasparCGDataCollection.SetData("loader4", "c:/casparcg/mydata/tt/serve.png")
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
                CasparCGDataCollection.SetData("loader3", "c:/casparcg/mydata/tt/serve.png")
                CasparCGDataCollection.SetData("loader4", "c:/casparcg/mydata/tt/blk.png")
            Else
                CasparCGDataCollection.SetData("loader3", "c:/casparcg/mydata/tt/blk.png")
                CasparCGDataCollection.SetData("loader4", "c:/casparcg/mydata/tt/serve.png")
            End If
        End If

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        If chkshowsettt.Checked = False Then
            showtemplate("cmp/games/tt/score1", CasparCGDataCollection.ToAMCPEscapedXml)
        Else
            showtemplate("cmp/games/tt/score1withset", CasparCGDataCollection.ToAMCPEscapedXml)
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
                CasparCGDataCollection.SetData("loader3", "c:/casparcg/mydata/tt/serve.png")
                CasparCGDataCollection.SetData("loader4", "c:/casparcg/mydata/tt/blk.png")
            Else
                CasparCGDataCollection.SetData("loader3", "c:/casparcg/mydata/tt/blk.png")
                CasparCGDataCollection.SetData("loader4", "c:/casparcg/mydata/tt/serve.png")
            End If
        End If
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayergames.Text), Int(cmblayergames.Text), CasparCGDataCollection)

    End Sub

    Private Sub cmdversustt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdversustt.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("h1", cmbHeader.Text)
        CasparCGDataCollection.SetData("h2", cmbSubHeader.Text)

        CasparCGDataCollection.SetData("t1", txtfullnamet1tt.Text)
        CasparCGDataCollection.SetData("t2", txtfullnamet2tt.Text)

        CasparCGDataCollection.SetData("loader1", pict1tt.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2tt.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        showtemplate("cmp/games/tt/verses", CasparCGDataCollection.ToAMCPEscapedXml)
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
        CasparCGDataCollection.SetData("h1", cmbHeader.Text)
        CasparCGDataCollection.SetData("h2", cmbSubHeader.Text)

        CasparCGDataCollection.SetData("t1", txtfullnamet1tt.Text)
        CasparCGDataCollection.SetData("t2", txtfullnamet2tt.Text)

        CasparCGDataCollection.SetData("loader1", pict1tt.ImageLocation)
        CasparCGDataCollection.SetData("loader2", pict2tt.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)

        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        showtemplate("cmp/games/tt/set7", CasparCGDataCollection.ToAMCPEscapedXml)

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

        showtemplate("cmp/games/tt/lefttop", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdpontindicatert1tt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpontindicatert1tt.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", cmblefttoptt.Text)
        CasparCGDataCollection.SetData("f1", txtfullnamet1tt.Text)
        CasparCGDataCollection.SetData("loader1", pict1tt.ImageLocation)

        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        showtemplate("cmp/games/tt/pointindicator", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdpontindicatert2tt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpontindicatert2tt.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", cmblefttoptt.Text)

        CasparCGDataCollection.SetData("f1", txtfullnamet2tt.Text)
        CasparCGDataCollection.SetData("loader1", pict2tt.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)

        showtemplate("cmp/games/tt/pointindicator", CasparCGDataCollection.ToAMCPEscapedXml)
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

        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparCGDataCollection.SetData("loader7", eventlogo.ImageLocation)

        showtemplate("cmp/games/tt/position", CasparCGDataCollection.ToAMCPEscapedXml)
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

        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparCGDataCollection.SetData("loader7", eventlogo.ImageLocation)
        showtemplate("cmp/games/tt/position_horizontal", CasparCGDataCollection.ToAMCPEscapedXml)
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

    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        CasparCGDataCollection.SetData("f0", Me.txtteama.Text)
        CasparCGDataCollection.SetData("f1", Me.txtplayera.Text)
        CasparCGDataCollection.SetData("f2", Me.txtcareer1.Text)
        CasparCGDataCollection.SetData("f3", Me.txtmatches1.Text)
        CasparCGDataCollection.SetData("f4", Me.txtwickets1.Text)
        CasparCGDataCollection.SetData("f5", Me.txtecon1.Text)
        CasparCGDataCollection.SetData("f6", Me.txt4w1.Text)
        CasparCGDataCollection.SetData("f7", Me.txt5w1.Text)
        CasparCGDataCollection.SetData("f8", Me.txtbest1.Text)
        CasparCGDataCollection.SetData("f9", Me.txtavg1.Text)
        CasparCGDataCollection.SetData("f33", Me.txtmatches2.Text)
        CasparCGDataCollection.SetData("f44", Me.txtwickets2.Text)
        CasparCGDataCollection.SetData("f55", Me.txtecon2.Text)
        CasparCGDataCollection.SetData("f66", Me.txt4w2.Text)
        CasparCGDataCollection.SetData("f77", Me.txt5w2.Text)
        CasparCGDataCollection.SetData("f88", Me.txtbest2.Text)
        CasparCGDataCollection.SetData("f99", Me.txtavg2.Text)
        CasparCGDataCollection.SetData("logo1", Replace(Me.logo1.ImageLocation, "\", "/"))
        CasparCGDataCollection.SetData("image1", Replace(Me.image1.ImageLocation, "\", "/"))
        showtemplate("CMP/games/por/Statics", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub


    Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click
        CasparCGDataCollection.SetData("f0", Me.txtteama.Text)
        CasparCGDataCollection.SetData("f1", Me.txtplayera.Text)
        CasparCGDataCollection.SetData("f2", Me.txtcareer1.Text)
        CasparCGDataCollection.SetData("f3", Me.txtmatches3.Text)
        CasparCGDataCollection.SetData("f4", Me.txtinnings3.Text)
        CasparCGDataCollection.SetData("f5", Me.txtruns3.Text)
        CasparCGDataCollection.SetData("f6", Me.txtaverage3.Text)
        CasparCGDataCollection.SetData("f7", Me.txt50s3.Text)
        CasparCGDataCollection.SetData("f8", Me.txt100s3.Text)
        CasparCGDataCollection.SetData("f9", Me.txthighestscore3.Text)
        CasparCGDataCollection.SetData("f33", Me.txtmatches4.Text)
        CasparCGDataCollection.SetData("f44", Me.txtinnings4.Text)
        CasparCGDataCollection.SetData("f55", Me.txtruns4.Text)
        CasparCGDataCollection.SetData("f66", Me.txtaverage4.Text)
        CasparCGDataCollection.SetData("f77", Me.txt50s4.Text)
        CasparCGDataCollection.SetData("f88", Me.txt100s4.Text)
        CasparCGDataCollection.SetData("f99", Me.txthighestscore4.Text)
        CasparCGDataCollection.SetData("logo1", Replace(Me.logo1.ImageLocation, "\", "/"))
        CasparCGDataCollection.SetData("image1", Replace(Me.image1.ImageLocation, "\", "/"))
        showtemplate("CMP/games/por/Statics", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd3.Click
        CasparCGDataCollection.SetData("f0", Me.txtteamb.Text)
        CasparCGDataCollection.SetData("f1", Me.txtplayerb.Text)
        CasparCGDataCollection.SetData("f2", Me.txtcareer2.Text)
        CasparCGDataCollection.SetData("f3", Me.txtmatches5.Text)
        CasparCGDataCollection.SetData("f4", Me.txtwickets5.Text)
        CasparCGDataCollection.SetData("f5", Me.txtecon5.Text)
        CasparCGDataCollection.SetData("f6", Me.txt4w5.Text)
        CasparCGDataCollection.SetData("f7", Me.txt5w5.Text)
        CasparCGDataCollection.SetData("f8", Me.txtbest5.Text)
        CasparCGDataCollection.SetData("f9", Me.txtavg5.Text)
        CasparCGDataCollection.SetData("f33", Me.txtmatches6.Text)
        CasparCGDataCollection.SetData("f44", Me.txtwickets6.Text)
        CasparCGDataCollection.SetData("f55", Me.txtecon6.Text)
        CasparCGDataCollection.SetData("f66", Me.txt4w6.Text)
        CasparCGDataCollection.SetData("f77", Me.txt5w6.Text)
        CasparCGDataCollection.SetData("f88", Me.txtbest6.Text)
        CasparCGDataCollection.SetData("f99", Me.txtavg6.Text)
        CasparCGDataCollection.SetData("logo1", Replace(Me.logo2.ImageLocation, "\", "/"))
        CasparCGDataCollection.SetData("image1", Replace(Me.image2.ImageLocation, "\", "/"))
        showtemplate("CMP/games/por/Statics", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd4.Click
        CasparCGDataCollection.SetData("f0", Me.txtteamb.Text)
        CasparCGDataCollection.SetData("f1", Me.txtplayerb.Text)
        CasparCGDataCollection.SetData("f2", Me.txtcareer2.Text)
        CasparCGDataCollection.SetData("f3", Me.txtmatches7.Text)
        CasparCGDataCollection.SetData("f4", Me.txtinnings7.Text)
        CasparCGDataCollection.SetData("f5", Me.txtruns7.Text)
        CasparCGDataCollection.SetData("f6", Me.txtaverage7.Text)
        CasparCGDataCollection.SetData("f7", Me.txt50s7.Text)
        CasparCGDataCollection.SetData("f8", Me.txt100s7.Text)
        CasparCGDataCollection.SetData("f9", Me.txthighestscore7.Text)
        CasparCGDataCollection.SetData("f33", Me.txtmatches8.Text)
        CasparCGDataCollection.SetData("f44", Me.txtinnings8.Text)
        CasparCGDataCollection.SetData("f55", Me.txtruns8.Text)
        CasparCGDataCollection.SetData("f66", Me.txtaverage8.Text)
        CasparCGDataCollection.SetData("f77", Me.txt50s8.Text)
        CasparCGDataCollection.SetData("f88", Me.txt100s8.Text)
        CasparCGDataCollection.SetData("f99", Me.txthighestscore8.Text)
        CasparCGDataCollection.SetData("logo1", Replace(Me.logo2.ImageLocation, "\", "/"))
        CasparCGDataCollection.SetData("image1", Replace(Me.image2.ImageLocation, "\", "/"))
        showtemplate("CMP/games/por/Statics", CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub logo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo1.Click
        If (ofd1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Me.logo1.ImageLocation = Me.ofd1.FileName
        End If
    End Sub
    Private Sub image1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles image1.Click
        If (ofd1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Me.image1.ImageLocation = Me.ofd1.FileName
        End If
    End Sub

    Private Sub logo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo2.Click
        If (ofd1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Me.logo2.ImageLocation = Me.ofd1.FileName
        End If
    End Sub
    Private Sub image2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles image2.Click
        If (ofd1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Me.image2.ImageLocation = Me.ofd1.FileName
        End If
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


        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "cmp/games/boxing/score", True, CasparCGDataCollection.ToAMCPEscapedXml)
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
        showtemplate("cmp/games/boxing/versus", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub

    Private Sub cmdplayeridboxing_Click(sender As Object, e As EventArgs) Handles cmdplayeridboxing.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        If rdoTeamARed.Checked Then
            CasparCGDataCollection.SetData("f1", dgvt1ball.CurrentRow.Cells(0).Value)
            showtemplate("cmp/games/boxing/player_id_red", CasparCGDataCollection.ToAMCPEscapedXml)
        Else
            CasparCGDataCollection.SetData("f1", dgvt2ball.CurrentRow.Cells(0).Value)
            showtemplate("cmp/games/boxing/player_id_blue", CasparCGDataCollection.ToAMCPEscapedXml)
        End If

    End Sub
    Private Sub cmdwinnerBoxing_Click(sender As Object, e As EventArgs) Handles cmdwinnerBoxing.Click
        On Error Resume Next
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("h1", cmbHeader.Text)
        If rdosinglecg.Checked Then
            CasparCGDataCollection.SetData("h2", "Winner-" & cmbSubHeader.Text)
        Else
            CasparCGDataCollection.SetData("h2", "Winners-" & cmbSubHeader.Text)
        End If

        If rdoTeamARed.Checked Then
            CasparCGDataCollection.SetData("t1", dgvt1ball.CurrentRow.Cells(0).Value & " " & cmbwinningmethodboxing.Text)
            CasparCGDataCollection.SetData("loader1", pict1logoball.ImageLocation)
        Else
            CasparCGDataCollection.SetData("t1", dgvt2ball.CurrentRow.Cells(0).Value & " " & cmbwinningmethodboxing.Text)
            CasparCGDataCollection.SetData("loader1", pict2logoball.ImageLocation)
        End If
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), "cmp/games/boxing/winner", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdscorewithclockboxing_Click(sender As Object, e As EventArgs) Handles cmdscorewithclockboxing.Click
        On Error Resume Next

        If chkanimationzym.Checked Then CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text + 1 & " fill -1 0 1 1 50 easeoutexpo")
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtt1ball.Text)
        CasparCGDataCollection.SetData("f1", txtt2ball.Text)
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

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text) + 1, Int(cmblayergames.Text) + 1, "cmp/games/boxing/score", True, CasparCGDataCollection.ToAMCPEscapedXml)
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

        showtemplate("cmp/games/boxing/set7", CasparCGDataCollection.ToAMCPEscapedXml)

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
        showtemplate("cmp/games/boxing/Goal_Summary", CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
    Private Sub cmdhide_Click(sender As Object, e As EventArgs)
        Hide()
    End Sub
End Class

