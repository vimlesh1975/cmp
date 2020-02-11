Imports Svt.Caspar
Imports System.Net.Sockets
Imports System.IO

Public Class ucWeightLifting

    Private currentRow As Integer
    Private currentColumn As Integer
    Dim judge As Integer

    Private Sub NG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        opendatadefault()
    End Sub

    Sub gymnasticsdefaultdata()
        On Error Resume Next
        dgv1.Rows.Add(12)

        dgv1.Rows(0).Cells(0).Value = 1
        dgv1.Rows(0).Cells(1).Value = "MOHAMAD ALGARNI"
        dgv1.Rows(0).Cells(2).Value = "ANG"
        dgv1.Rows(0).Cells(3).Value = 54.914

        dgv1.Rows(1).Cells(0).Value = 2
        dgv1.Rows(1).Cells(1).Value = "SANDEEP KARAN SINGH"
        dgv1.Rows(1).Cells(2).Value = "IND"
        dgv1.Rows(1).Cells(3).Value = 32.412

        dgv1.Rows(2).Cells(0).Value = 3
        dgv1.Rows(2).Cells(1).Value = "EMAD HAMED NOUR"
        dgv1.Rows(2).Cells(2).Value = "SRI"
        dgv1.Rows(2).Cells(3).Value = 51.251

        dgv1.Rows(3).Cells(0).Value = 4
        dgv1.Rows(3).Cells(1).Value = "RASHEED RAMZI"
        dgv1.Rows(3).Cells(2).Value = "BRA"
        dgv1.Rows(3).Cells(3).Value = 12.256
    End Sub
    Private Sub cmdstartlist1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstartlist1.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("h1", EVENTIDTEXT.Text)
        CasparCGDataCollection.SetData("h2", GENDER.Text & " " & WEIGHT.Text)
        For i = 0 To dgv1.RowCount - 1
            CasparCGDataCollection.SetData("sn" & i + 1, dgv1.Rows(i).Cells(0).Value)
            If dgv1.Rows(i).Cells(0).Value <> "" Then
                CasparCGDataCollection.SetData("name" & i + 1, dgv1.Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("value" & i + 1, dgv1.Rows(i).Cells(3).Value & "Kg")
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(2).Value & ".png")
            End If
        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/startlist1", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdstartlist2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstartlist2.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("h1", EVENTIDTEXT.Text)
        CasparCGDataCollection.SetData("h2", GENDER.Text & " " & WEIGHT.Text)

        For i = 8 To dgv1.RowCount - 1
            CasparCGDataCollection.SetData("sn" & i - 7, dgv1.Rows(i).Cells(0).Value)
            If dgv1.Rows(i).Cells(0).Value <> "" Then
                CasparCGDataCollection.SetData("name" & i - 7, dgv1.Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("value" & i - 7, dgv1.Rows(i).Cells(3).Value & "Kg")
                CasparCGDataCollection.SetData("loader" & i - 7, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(2).Value & ".png")
            End If

        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/startlist1", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub
    Private Sub cmdresult1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresult1.Click
        On Error Resume Next
        dgv1.Update()
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("h1", GENDER.Text & " " & WEIGHT.Text)
        CasparCGDataCollection.SetData("h2", "Standings")
        For i = 0 To dgv1.RowCount - 1

            If dgv1.Rows(i).Cells(0).Value <> "" Then
                CasparCGDataCollection.SetData("sn" & i + 1, dgv1.Rows(i).Cells(19).Value)
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i + 1, dgv1.Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("value" & i + 1, dgv1.Rows(i).Cells(3).Value)
                CasparCGDataCollection.SetData("s1" & i + 1, dgv1.Rows(i).Cells(4).Value)
                CasparCGDataCollection.SetData("s2" & i + 1, dgv1.Rows(i).Cells(6).Value)
                CasparCGDataCollection.SetData("s3" & i + 1, dgv1.Rows(i).Cells(8).Value)
                CasparCGDataCollection.SetData("loaders1" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(5).Value & ".png")
                CasparCGDataCollection.SetData("loaders2" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(7).Value & ".png")
                CasparCGDataCollection.SetData("loaders3" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(9).Value & ".png")
            End If

        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/snatch_Result1", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdplayerid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayerid.Click

        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", dgv1.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("f1", dgv1.CurrentRow.Cells(1).Value)

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.CurrentRow.Cells(2).Value & ".png")

        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/player_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdstopgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopgym.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation2()

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text))
        Threading.Thread.Sleep(1000)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdvictoryidgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", GENDER.Text & " " & WEIGHT.Text)
        CasparCGDataCollection.SetData("f1", "Victory Ceremony")

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/victory_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()


    End Sub

    Private Sub cmdgoldgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", GENDER.Text & " " & WEIGHT.Text)
        CasparCGDataCollection.SetData("f1", dgv1.Rows(0).Cells(1).Value)

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(0).Cells(2).Value & ".png")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/medal_g", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdsilvergym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", GENDER.Text & " " & WEIGHT.Text)
        CasparCGDataCollection.SetData("f1", dgv1.Rows(1).Cells(1).Value)

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(1).Cells(2).Value & ".png")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/medal_s", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdbronzegym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()


        CasparCGDataCollection.Clear()

        CasparCGDataCollection.SetData("f0", GENDER.Text & " " & WEIGHT.Text)
        CasparCGDataCollection.SetData("f1", dgv1.Rows(2).Cells(1).Value)

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(2).Cells(2).Value & ".png")

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/medal_b", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()


    End Sub


    Private Sub cmdmedalallgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("h1", GENDER.Text & " " & WEIGHT.Text)
        CasparCGDataCollection.SetData("h2", "Victory Ceremony")
        For imedalall = 0 To 2
            CasparCGDataCollection.SetData("t" & imedalall + 1, dgv1.Rows(imedalall).Cells(1).Value)
            CasparCGDataCollection.SetData("loader" & imedalall + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(imedalall).Cells(2).Value & ".png")
        Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/medal_three", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()
    End Sub


    Sub animation1()
        CasparDevice.SendString("mixer " & g_int_ChannelNumber - 1 + 1 & "-" & cmblayergymnastics.Text & " fill -1 0 1 1 50 easeoutexpo")
    End Sub
    Sub animationtoscreen()
        CasparDevice.SendString("mixer " & g_int_ChannelNumber - 1 + 1 & "-" & cmblayergymnastics.Text & " fill 0 0 1 1 50 easeoutexpo")
    End Sub
    Sub animation2()
        CasparDevice.SendString("mixer " & g_int_ChannelNumber - 1 + 1 & "-" & cmblayergymnastics.Text & " fill 1 0 1 1 50 easeoutexpo")
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub newgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newgym.Click, ToolStripButton1.Click
        On Error Resume Next
        dgv1.Rows.Clear()
        dgv1.Rows.Add(11)
        lblfilenamegym.Text = "new"

    End Sub

    Private Sub opengym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opengym.Click, ToolStripButton2.Click
        On Error Resume Next

        opendata()
    End Sub
    Sub opendatadefault()

        On Error Resume Next
        Dim ofd2 As New OpenFileDialog With {
            .FileName = "C:\casparcg\mydata\games2\wl\MEN'S68 KG.txt"
        }

        Using sr As StreamReader = New StreamReader(ofd2.FileName)
            'clear list
            dgv1.Rows.Clear()
            'Loop through and add list to the file.
            Dim g As Integer = 0
            Dim li As String = ""

            li = sr.ReadLine()
            GENDER.Text = Split(li, ",")(0)
            WEIGHT.Text = Split(li, ",")(1)

            li = ""
            li = sr.ReadLine()
            For i = 0 To dgv1.ColumnCount - 1
                dgv1.Columns(i).HeaderText = Split(li, ",")(i)
            Next

            li = ""
            Do Until sr.EndOfStream
                li = sr.ReadLine()
                dgv1.Rows.Add()
                Dim xyz As Array = Split(li, ",")
                For k = 0 To dgv1.ColumnCount - 1
                    dgv1.Rows(g).Cells(k).Value = xyz(k) 'CType(xyz(0), Integer)
                    Select Case k
                        Case 4, 6, 8, 10, 12, 14
                            If xyz(k + 1) = 1 And dgv1.Rows(g).Cells(k).Value > 0 Then
                                dgv1.Rows(g).Cells(k).Style.BackColor = Color.OrangeRed
                                ' dgv1.Rows(g).Cells(k + 1).Value = 0
                            ElseIf xyz(k + 1) = 0 And dgv1.Rows(g).Cells(k).Value > 0 Then
                                dgv1.Rows(g).Cells(k).Style.BackColor = Color.Green
                                '  dgv1.Rows(g).Cells(k + 1).Value = 1
                            Else
                                dgv1.Rows(g).Cells(k).Style.BackColor = Color.White
                                ' dgv1.Rows(g).Cells(k + 1).Value = 0
                            End If
                        Case 5, 7, 9, 11, 13, 15
                            If xyz(k) = 0 Then
                                dgv1.Rows(g).Cells(k).Value = 0
                            End If
                            If xyz(k) = 1 Then
                                dgv1.Rows(g).Cells(k).Value = 1
                            End If

                    End Select

                Next
                g = g + 1
            Loop

            sr.Close()

            dgv1.Rows.RemoveAt(dgv1.RowCount - 1)
        End Using
        lblfilenamegym.Text = ofd2.FileName

    End Sub


    Private Sub opendata()
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog With {
            .Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
            .InitialDirectory = "C:\casparcg\mydata\games2\wl\"
        }
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)
                'clear list
                dgv1.Rows.Clear()
                'Loop through and add list to the file.
                Dim g As Integer = 0
                Dim li As String = ""

                li = sr.ReadLine()
                GENDER.Text = Split(li, ",")(0)
                WEIGHT.Text = Split(li, ",")(1)

                li = ""
                li = sr.ReadLine()
                For i = 0 To dgv1.ColumnCount - 1
                    dgv1.Columns(i).HeaderText = Split(li, ",")(i)
                Next

                li = ""
                Do Until sr.EndOfStream
                    li = sr.ReadLine()
                    dgv1.Rows.Add()
                    Dim xyz As Array = Split(li, ",")
                    For k = 0 To dgv1.ColumnCount - 1
                        dgv1.Rows(g).Cells(k).Value = xyz(k) 'CType(xyz(0), Integer)
                        Select Case k
                            Case 4, 6, 8, 10, 12, 14
                                If xyz(k + 1) = 1 And dgv1.Rows(g).Cells(k).Value > 0 Then
                                    dgv1.Rows(g).Cells(k).Style.BackColor = Color.OrangeRed
                                    ' dgv1.Rows(g).Cells(k + 1).Value = 0
                                ElseIf xyz(k + 1) = 0 And dgv1.Rows(g).Cells(k).Value > 0 Then
                                    dgv1.Rows(g).Cells(k).Style.BackColor = Color.Green
                                    '  dgv1.Rows(g).Cells(k + 1).Value = 1
                                Else
                                    dgv1.Rows(g).Cells(k).Style.BackColor = Color.White
                                    ' dgv1.Rows(g).Cells(k + 1).Value = 0
                                End If
                            Case 5, 7, 9, 11, 13, 15
                                If xyz(k) = 0 Then
                                    dgv1.Rows(g).Cells(k).Value = 0
                                End If
                                If xyz(k) = 1 Then
                                    dgv1.Rows(g).Cells(k).Value = 1
                                End If

                        End Select

                    Next
                    g = g + 1
                Loop

                sr.Close()

                dgv1.Rows.RemoveAt(dgv1.RowCount - 1)
            End Using
            lblfilenamegym.Text = ofd2.FileName

        End If
    End Sub
    Private Sub savegym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savegym.Click, ToolStripButton3.Click
        On Error Resume Next
        savedata()
    End Sub
    Sub savedata()
        On Error Resume Next
        Dim gender1 As String
        Dim weight1 As String
        gender1 = GENDER.Text
        weight1 = WEIGHT.Text
        Dim fname2 As String = "C:\casparcg\Weightlifting\data\" + gender1 + weight1 + ".txt"
        Dim fi As New IO.FileInfo(fname2)
        Dim alamat = fname2

        ' Check if file already exists. If yes, delete it.
        If fi.Exists Then
            File.SetAttributes(alamat, FileAttributes.Normal)
            fi.Delete()
        End If
        '' Create a new file
        Using sw As StreamWriter = fi.CreateText()
            'Using sw As StreamWriter = New StreamWriter(osd2.FileName)
            If dgv1.Rows.Count = 0 Then
                sw.Write("")
            Else
                'write header and subheader
                sw.WriteLine(GENDER.Text & "," & WEIGHT.Text)

                'write headers of datagrid
                Dim header1 As String = ""
                For i = 0 To dgv1.ColumnCount - 1
                    header1 = header1 & dgv1.Columns(i).HeaderText & ","
                Next
                sw.WriteLine(header1)

                'Loop through and add list to the file.
                Dim f As Integer = 0
                Do Until f = dgv1.Rows.Count - 1
                    Dim str As String = ""
                    For k = 0 To dgv1.ColumnCount - 1
                        str = str & dgv1.Rows(f).Cells(k).Value & ","
                    Next
                    sw.WriteLine(str)
                    f = f + 1
                Loop
            End If
            sw.Close()
        End Using
        '   lblfilenamegym.Text = osd2.FileName
        lblfilenamegym.Text = fname2
        ' End If
    End Sub

    Private Sub cmdrowupzym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowupzym.Click
        On Error Resume Next
        If Me.dgv1.CurrentCell.RowIndex <> 0 Then
            Dim curRow As Integer = Me.dgv1.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgv1.CurrentRow
            Me.dgv1.Rows.Remove(myRow)
            Me.dgv1.Rows.Insert(curRow - 1, myRow)
            dgv1.CurrentCell = dgv1.Rows(curRow - 1).Cells(0)
        End If
    End Sub

    Private Sub cmdrowdowngym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowdowngym.Click
        On Error Resume Next
        If Me.dgv1.CurrentCell.RowIndex <> dgv1.Rows.Count - 2 Then
            Dim curRow As Integer = Me.dgv1.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgv1.CurrentRow
            Me.dgv1.Rows.Remove(myRow)
            Me.dgv1.Rows.Insert(curRow + 1, myRow)
            dgv1.CurrentCell = dgv1.Rows(curRow + 1).Cells(0)
        End If
    End Sub

    Private Sub cmdrowinsertgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowinsertgym.Click
        On Error Resume Next
        dgv1.Rows.Insert(dgv1.CurrentRow.Index)
    End Sub

    Private Sub cmdrowdeletegym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowdeletegym.Click
        On Error Resume Next
        dgv1.Rows.RemoveAt(dgv1.CurrentRow.Index)
    End Sub

    Private Sub dgv1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        PopulateAttemptBox()
    End Sub

    Sub RefreeClear()
        Ref1.Checked = False
        Ref2.Checked = False
        Ref3.Checked = False
        Ref1.BackColor = Color.White
        Ref2.BackColor = Color.White
        Ref3.BackColor = Color.White
    End Sub

    Private Sub dgv1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        dgv1.CurrentCell.Value = " "
        dgv1.CurrentCell.Value = load_weight.Text
        dgv1.Update()
        currentColumn = e.ColumnIndex
        currentRow = e.RowIndex
        dgv1(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.Blue
        PopulateAttemptBox()
    End Sub
    Private Sub dgv1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellEndEdit

        currentColumn = e.ColumnIndex
        currentRow = e.RowIndex
        dgv1(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.Blue

        PopulateAttemptBox()

        dgv1.Update()

    End Sub
    Sub PopulateAttemptBox()
        Dim C As Integer
        C = dgv1.CurrentCellAddress.X 'Column  
        If C < 4 Or C > 15 Then
            Exit Sub
        End If
        Select Case C
            Case 4, 10
                TextWeight.Text = dgv1.CurrentCell.Value + "Kg"
                TextStyle.Text = "Attempt 1"
                RefreeClear()
            Case 6, 12
                TextWeight.Text = dgv1.CurrentCell.Value + "Kg"
                TextStyle.Text = "Attempt 2"
                RefreeClear()
            Case 8, 14
                TextWeight.Text = dgv1.CurrentCell.Value + "Kg"
                TextStyle.Text = "Attempt 3"
                RefreeClear()
        End Select
    End Sub



    Private Sub dgv1_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgv1.CellEnter
    End Sub


    Private Sub dgv1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellValueChanged
        On Error Resume Next
        '  dgv1.Rows(e.RowIndex).Cells(18).Value = Format(Val(dgv1.Rows(e.RowIndex).Cells(16).Value) + Val(dgv1.Rows(e.RowIndex).Cells(17).Value), "00.00")
    End Sub

    Private Sub dgv1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv1.DataError
        'dummy dont delete
    End Sub





    Private Sub cmDvenueid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmDvenueid1.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtvenueid1.Text)
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/venue_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdeventid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeventid.Click

        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", EVENTIDTEXT.Text)
        CasparCGDataCollection.SetData("f1", GENDER.Text & " " & WEIGHT.Text)

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/event_id", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub





    Private Sub dgv1_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgv1.DefaultValuesNeeded

        e.Row.Cells(2).Value = "BLK"
    End Sub

    Private Sub cmdresetdatagym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresetdatagym.Click
        On Error Resume Next
        Dim j As Integer
        j = 4

        dgv1.Rows.RemoveAt(dgv1.RowCount - 1)
        dgv1.Rows.RemoveAt(dgv1.RowCount - 1)
        For i = 0 To dgv1.Rows.Count - 1
            For j = 4 To 19
                dgv1.Rows(i).Cells(j).Value = "0"
                dgv1.Rows(i).Cells(j).Style.BackColor = Color.White
            Next

        Next

    End Sub

    Private Sub dgvforheader_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub



    Private Sub Ref1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ref1.CheckedChanged
        On Error Resume Next
        If Ref1.Checked = True Then
            Ref1.BackColor = Color.OrangeRed
        Else
            Ref1.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub Ref2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ref2.CheckedChanged
        On Error Resume Next
        If Ref2.Checked = True Then
            Ref2.BackColor = Color.OrangeRed
        Else
            Ref2.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub Ref3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ref3.CheckedChanged
        On Error Resume Next
        If Ref3.Checked = True Then
            Ref3.BackColor = Color.OrangeRed
        Else
            Ref3.BackColor = Color.WhiteSmoke
        End If
    End Sub




    Private Sub Clear_cell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_cell.Click
        On Error Resume Next
        Dim testvalue As Integer
        testvalue = 0
        dgv1.CurrentCell.Style.BackColor = Color.White
        dgv1.CurrentCell.Value = "0"
    End Sub




    Private Sub Snach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Snach.Click
        On Error Resume Next
        Dim imajoritycount As Integer
        Dim c As Integer
        Dim y As Integer
        Dim dasht, dashc, dash1, dash2, dash3 As String
        Dim snatch, Clean_Jerk, total As String

        c = dgv1.CurrentCellAddress.X 'Column 
        y = dgv1.CurrentCellAddress.Y 'Row
        c = dgv1.CurrentCellAddress.X 'Column  
        If c < 4 Or c > 15 Then
            Exit Sub
        End If
        Select Case c

            Case 4

                If chkanimationzym.Checked Then animation1()

                CasparCGDataCollection.Clear()
                CasparCGDataCollection.SetData("f0", dgv1.CurrentRow.Cells(1).Value)
                CasparCGDataCollection.SetData("f1", "Snatch")
                CasparCGDataCollection.SetData("f2", "Lift1 " & dgv1.CurrentRow.Cells(4).Value & "Kg")
                '  CasparCGDataCollection.SetData("f3", "Lift1 " + dgv1.CurrentRow.Cells(4).Value + "Kg")
                If dgv1.Rows(y).Cells(0).Value <> "" Then
                    CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.CurrentRow.Cells(2).Value & ".png")
                End If
                CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
                CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

                CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/snatch1", True, CasparCGDataCollection.ToAMCPEscapedXml)

                If chkanimationzym.Checked Then animationtoscreen()



            Case 6

                If chkanimationzym.Checked Then animation1()

                If chkanimationzym.Checked Then animation1()
                If dgv1.CurrentRow.Cells(16).Value = 0 Then
                    dasht = "dash"
                    snatch = "Snatch"
                Else
                    dasht = "BLK"
                    snatch = "snatch " & dgv1.CurrentRow.Cells(16).Value & "Kg"
                End If
                If dgv1.CurrentRow.Cells(5).Value = 1 Then
                    dash1 = "dash"
                Else
                    dash1 = "BLK"
                End If

                CasparCGDataCollection.Clear()
                CasparCGDataCollection.SetData("f0", dgv1.CurrentRow.Cells(1).Value)
                CasparCGDataCollection.SetData("f1", snatch)
                CasparCGDataCollection.SetData("f2", "Lift1 " & dgv1.CurrentRow.Cells(4).Value & "Kg")
                CasparCGDataCollection.SetData("f3", "Lift2 " & dgv1.CurrentRow.Cells(6).Value & "Kg")
                If dgv1.Rows(y).Cells(0).Value <> "" Then
                    CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.CurrentRow.Cells(2).Value & ".png")
                End If
                CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
                CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

                CasparCGDataCollection.SetData("loader2", "C:/casparcg/mydata/games2/country/WithName/" & dasht & ".png")
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/country/WithName/" & dash1 & ".png")
                CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/snatch2", True, CasparCGDataCollection.ToAMCPEscapedXml)

                If chkanimationzym.Checked Then animationtoscreen()
            Case 8

                If chkanimationzym.Checked Then animation1()
                If dgv1.CurrentRow.Cells(16).Value = 0 Then
                    dasht = "dash"
                    snatch = "Snatch"
                Else
                    dasht = "BLK"
                    snatch = "snatch " & dgv1.CurrentRow.Cells(16).Value & "Kg"
                End If
                If dgv1.CurrentRow.Cells(5).Value = 1 Then
                    dash1 = "dash"
                Else
                    dash1 = "BLK"
                End If
                If dgv1.CurrentRow.Cells(7).Value = 1 Then
                    dash2 = "dash"
                Else
                    dash2 = "BLK"
                End If


                CasparCGDataCollection.Clear()
                CasparCGDataCollection.SetData("f0", dgv1.CurrentRow.Cells(1).Value)
                CasparCGDataCollection.SetData("f1", snatch)
                CasparCGDataCollection.SetData("f2", "Lift1 " & dgv1.CurrentRow.Cells(4).Value & "Kg")
                CasparCGDataCollection.SetData("f3", "Lift2 " & dgv1.CurrentRow.Cells(6).Value & "Kg")
                CasparCGDataCollection.SetData("f4", "Lift3 " & dgv1.CurrentRow.Cells(8).Value & "Kg")
                If dgv1.Rows(y).Cells(0).Value <> "" Then
                    CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.CurrentRow.Cells(2).Value & ".png")
                End If

                CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
                CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

                CasparCGDataCollection.SetData("loader2", "C:/casparcg/mydata/games2/country/WithName/" & dasht & ".png")
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/country/WithName/" & dash1 & ".png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games2/country/WithName/" & dash2 & ".png")
                CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/snatch3", True, CasparCGDataCollection.ToAMCPEscapedXml)

                If chkanimationzym.Checked Then animationtoscreen()
            Case 10

                If chkanimationzym.Checked Then animation1()

                CasparCGDataCollection.Clear()
                CasparCGDataCollection.SetData("f0", dgv1.CurrentRow.Cells(1).Value)
                CasparCGDataCollection.SetData("f1", "Snatch " & dgv1.CurrentRow.Cells(16).Value & "Kg")

                CasparCGDataCollection.SetData("f2", "Lift1 " & dgv1.CurrentRow.Cells(10).Value & "Kg")
                If dgv1.Rows(y).Cells(0).Value <> "" Then
                    CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.CurrentRow.Cells(2).Value & ".png")
                End If


                CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
                CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)


                CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/c&j1", True, CasparCGDataCollection.ToAMCPEscapedXml)

                If chkanimationzym.Checked Then animationtoscreen()
            Case 12
                If chkanimationzym.Checked Then animation1()

                If dgv1.CurrentRow.Cells(17).Value = 0 Then
                    dashc = "dash"
                    Clean_Jerk = "Clean&Jerk"
                Else
                    dashc = "BLK"
                    Clean_Jerk = "Clean&Jerk " & dgv1.CurrentRow.Cells(17).Value & "Kg"
                End If
                If dgv1.CurrentRow.Cells(18).Value = 0 Then
                    dasht = "dash"
                    total = "Total"
                Else
                    dasht = "BLK"
                    total = "Total " & dgv1.CurrentRow.Cells(18).Value & "Kg"
                End If
                If dgv1.CurrentRow.Cells(11).Value = 1 Then
                    dash1 = "dash"
                Else
                    dash1 = "BLK"
                End If
                If dgv1.CurrentRow.Cells(13).Value = 1 Then
                    dash2 = "dash"
                Else
                    dash2 = "BLK"
                End If
                If dgv1.CurrentRow.Cells(15).Value = 1 Then
                    dash3 = "dash"
                Else
                    dash3 = "BLK"
                End If

                CasparCGDataCollection.Clear()
                CasparCGDataCollection.SetData("f0", dgv1.CurrentRow.Cells(1).Value)
                CasparCGDataCollection.SetData("f1", "Snatch " & dgv1.CurrentRow.Cells(16).Value & "Kg")
                CasparCGDataCollection.SetData("f2", Clean_Jerk)
                CasparCGDataCollection.SetData("f3", total)
                CasparCGDataCollection.SetData("f4", "Lift1 " & dgv1.CurrentRow.Cells(10).Value & "Kg")
                CasparCGDataCollection.SetData("f5", "Lift2 " & dgv1.CurrentRow.Cells(12).Value & "Kg")
                If dgv1.Rows(y).Cells(0).Value <> "" Then
                    CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.CurrentRow.Cells(2).Value & ".png")
                End If

                CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
                CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

                CasparCGDataCollection.SetData("loader2", "C:/casparcg/mydata/games2/country/WithName/" & dashc & ".png")
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/country/WithName/" & dasht & ".png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games2/country/WithName/" & dash1 & ".png")




                CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/c&j2", True, CasparCGDataCollection.ToAMCPEscapedXml)

                If chkanimationzym.Checked Then animationtoscreen()

                If chkanimationzym.Checked Then animationtoscreen()
            Case 14



                If chkanimationzym.Checked Then animation1()
                If chkanimationzym.Checked Then animation1()

                If dgv1.CurrentRow.Cells(17).Value = 0 Then
                    dashc = "dash"
                    Clean_Jerk = "Clean&Jerk"
                Else
                    dashc = "BLK"
                    Clean_Jerk = "Clean&Jerk " & dgv1.CurrentRow.Cells(17).Value & "Kg"
                End If
                If dgv1.CurrentRow.Cells(18).Value = 0 Then
                    dasht = "dash"
                    total = "Total"
                Else
                    dasht = "BLK"
                    total = "Total " & dgv1.CurrentRow.Cells(18).Value & "Kg"
                End If
                If dgv1.CurrentRow.Cells(11).Value = 1 Then
                    dash1 = "dash"
                Else
                    dash1 = "BLK"
                End If
                If dgv1.CurrentRow.Cells(13).Value = 1 Then
                    dash2 = "dash"
                Else
                    dash2 = "BLK"
                End If
                If dgv1.CurrentRow.Cells(15).Value = 1 Then
                    dash3 = "dash"
                Else
                    dash3 = "BLK"
                End If

                CasparCGDataCollection.Clear()
                CasparCGDataCollection.SetData("f0", dgv1.CurrentRow.Cells(1).Value)
                CasparCGDataCollection.SetData("f1", "Snatch " & dgv1.CurrentRow.Cells(16).Value & "Kg")
                CasparCGDataCollection.SetData("f2", Clean_Jerk)
                CasparCGDataCollection.SetData("f3", total)
                CasparCGDataCollection.SetData("f4", "Lift1 " & dgv1.CurrentRow.Cells(10).Value & "Kg")
                CasparCGDataCollection.SetData("f5", "Lift2 " & dgv1.CurrentRow.Cells(12).Value & "Kg")
                CasparCGDataCollection.SetData("f6", "Lift3 " & dgv1.CurrentRow.Cells(14).Value & "Kg")
                If dgv1.Rows(y).Cells(0).Value <> "" Then
                    CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.CurrentRow.Cells(2).Value & ".png")
                End If
                CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
                CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)


                CasparCGDataCollection.SetData("loader2", "C:/casparcg/mydata/games2/country/WithName/" & dashc & ".png")
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/country/WithName/" & dasht & ".png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games2/country/WithName/" & dash1 & ".png")
                CasparCGDataCollection.SetData("loader5", "C:/casparcg/mydata/games2/country/WithName/" & dash2 & ".png")



                CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/c&j3", True, CasparCGDataCollection.ToAMCPEscapedXml)

                If chkanimationzym.Checked Then animationtoscreen()

        End Select


    End Sub
    Sub resulupdate()
        On Error Resume Next
        Dim first, second, third, fourth, fifth, six, snatch, cj, total As Integer
        Dim EVENT_SELC As String
        Dim i, j, k As Integer
        Dim C As Integer
        Dim Rank As Double

        C = dgv1.CurrentCellAddress.X 'Column  

        If C < 4 Or C > 15 Then
            Exit Sub
        End If
        cj = " "
        snatch = " "
        total = " "

        dgv1.Update()
        For i = 0 To dgv1.Rows.Count - 1

            If dgv1.Rows(i).Cells(4).Style.BackColor = Color.Green Then
                first = dgv1.Rows(i).Cells(4).Value
            Else
                first = 0
            End If
            If dgv1.Rows(i).Cells(6).Style.BackColor = Color.Green Then
                second = dgv1.Rows(i).Cells(6).Value
            Else
                second = 0
            End If
            If dgv1.Rows(i).Cells(8).Style.BackColor = Color.Green Then
                third = dgv1.Rows(i).Cells(8).Value
            Else
                third = 0
            End If

            If first >= second And first >= third Then
                snatch = first
            ElseIf second >= first And second >= third Then
                snatch = second
            ElseIf third >= first And third >= second Then
                snatch = third
            End If
            If snatch >= 0 Then dgv1.Rows(i).Cells(16).Value = snatch

            first = 0
            second = 0
            third = 0
            fourth = 0
            fifth = 0
            six = 0
            snatch = 0
            cj = 0
        Next

        For k = 0 To dgv1.Rows.Count - 2
            Rank = Val(dgv1.Rows(k).Cells(3).Value)
            If Rank > 0 Then dgv1.Rows(k).Cells(3).Value = Rank

        Next
        If RB_Snatch.Checked = True Then

            dgv1.Sort(dgv1.Columns(3), System.ComponentModel.ListSortDirection.Ascending)
            dgv1.Update()

            dgv1.Sort(dgv1.Columns(16), System.ComponentModel.ListSortDirection.Descending)
            dgv1.Update()
            For k = 0 To dgv1.Rows.Count - 2
                If dgv1.Rows(k).Cells(16).Value > 0 Then

                    dgv1.Rows(k).Cells(19).Value = k + 1
                Else
                    dgv1.Rows(k).Cells(19).Value = " "
                End If
            Next
        End If
    End Sub

    Sub resulupdate2()
        On Error Resume Next
        Dim first, second, third, fourth, fifth, six, snatch, cj, total As Integer
        Dim EVENT_SELC As String
        Dim i, j, k As Integer
        Dim C As Integer
        Dim Rank As Double

        C = dgv1.CurrentCellAddress.X 'Column  

        If C < 4 Or C > 15 Then
            Exit Sub
        End If
        cj = " "
        snatch = " "
        total = " "
        dgv1.Update()
        For i = 0 To dgv1.Rows.Count - 2

            If dgv1.Rows(i).Cells(4).Style.BackColor = Color.Green Then
                first = dgv1.Rows(i).Cells(4).Value
            Else
                first = 0
            End If
            If dgv1.Rows(i).Cells(6).Style.BackColor = Color.Green Then
                second = dgv1.Rows(i).Cells(6).Value
            Else
                second = 0
            End If
            If dgv1.Rows(i).Cells(8).Style.BackColor = Color.Green Then
                third = dgv1.Rows(i).Cells(8).Value
            Else
                third = 0
            End If
            If dgv1.Rows(i).Cells(10).Style.BackColor = Color.Green Then
                fourth = dgv1.Rows(i).Cells(10).Value
            Else
                fourth = 0
            End If
            If dgv1.Rows(i).Cells(12).Style.BackColor = Color.Green Then
                fifth = dgv1.Rows(i).Cells(12).Value
            Else
                fifth = 0
            End If
            If dgv1.Rows(i).Cells(14).Style.BackColor = Color.Green Then
                six = dgv1.Rows(i).Cells(14).Value
            Else
                six = 0
            End If

            If first >= second And first >= third Then
                snatch = first
            ElseIf second >= first And second >= third Then
                snatch = second
            ElseIf third >= first And third >= second Then
                snatch = third
            End If

            If fourth >= fifth And fourth >= six Then
                cj = fourth
            ElseIf fifth >= fourth And fifth >= six Then
                cj = fifth
            ElseIf six >= fourth And six >= fifth Then
                cj = six

            End If
            If snatch >= 0 Then dgv1.Rows(i).Cells(16).Value = snatch
            If cj >= 0 Then dgv1.Rows(i).Cells(17).Value = cj

            If Val(snatch) > 0 And Val(cj) > 0 Then
                total = Val(snatch) + Val(cj)
                dgv1.Rows(i).Cells(18).Value = CStr(total)
            Else
                total = " "

            End If

            first = 0
            second = 0
            third = 0
            fourth = 0
            fifth = 0
            six = 0
            snatch = 0
            cj = 0
        Next


        If RRB_CJ.Checked = True Then
            dgv1.Sort(dgv1.Columns(3), System.ComponentModel.ListSortDirection.Ascending)
            dgv1.Update()
            dgv1.Sort(dgv1.Columns(18), System.ComponentModel.ListSortDirection.Descending)
            dgv1.Update()

            For k = 0 To dgv1.Rows.Count - 2
                If dgv1.Rows(k).Cells(18).Value > 0 Then
                    dgv1.Rows(k).Cells(19).Value = k + 1
                Else
                    dgv1.Rows(k).Cells(19).Value = " "
                End If
            Next

        End If

    End Sub

    Private Sub Ref_lights_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ref_lights.Click
        On Error Resume Next
        Dim light1, light2, light3 As String
        If Ref1.Checked = True Then
            light1 = "Light_R"
        Else
            light1 = "Light_W"

        End If
        If Ref2.Checked = True Then
            light2 = "Light_R"
        Else
            light2 = "Light_W"

        End If
        If Ref3.Checked = True Then
            light3 = "Light_R"
        Else
            light3 = "Light_W"

        End If
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", TextStyle.Text)
        CasparCGDataCollection.SetData("f1", TextWeight.Text)

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & light1 & ".png")
        CasparCGDataCollection.SetData("loader2", "C:/casparcg/mydata/games2/country/WithName/" & light2 & ".png")
        CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/country/WithName/" & light3 & ".png")

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/Attempt", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
        update_lift_R()
    End Sub
    Private Sub Update_Lift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update_Lift.Click
        On Error Resume Next
        update_lift_R()
    End Sub
    Sub update_lift_R()
        On Error Resume Next
        Dim imajoritycount As Integer
        Dim c As Integer
        Dim y As Integer
        c = dgv1.CurrentCellAddress.X 'Column 
        y = dgv1.CurrentCellAddress.Y 'Row
        c = dgv1.CurrentCellAddress.X 'Column  
        If c < 4 Or c > 15 Then
            Exit Sub
        End If
        If dgv1.CurrentRow.Cells(16).Value = "" Then
            dgv1.CurrentRow.Cells(16).Value = 0
        End If

        imajoritycount = 0

        If Ref1.BackColor = Color.OrangeRed Then imajoritycount = imajoritycount + 1
        If Ref2.BackColor = Color.OrangeRed Then imajoritycount = imajoritycount + 1
        If Ref3.BackColor = Color.OrangeRed Then imajoritycount = imajoritycount + 1
        If imajoritycount > 1 Then
            dgv1.CurrentCell.Style.BackColor = Color.OrangeRed
            dgv1.Rows(y).Cells(c + 1).Value = 1
        Else
            dgv1.CurrentCell.Style.BackColor = Color.Green
            dgv1.Rows(y).Cells(c + 1).Value = 0
        End If
        If RB_Snatch.Checked = True Then Call resulupdate()
        If RRB_CJ.Checked = True Then Call resulupdate2()
    End Sub
    Private Sub Result_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Result.Click
        On Error Resume Next
        Dim imajoritycount As Integer
        Dim c As Integer
        Dim y As Integer
        Dim dasht, dashc, dash1, dash2, dash3 As String
        Dim snatch, Clean_Jerk, total As String

        c = dgv1.CurrentCellAddress.X 'Column 
        y = dgv1.CurrentCellAddress.Y 'Row
        c = dgv1.CurrentCellAddress.X 'Column  
        If c < 4 Or c > 15 Then
            Exit Sub
        End If
        Select Case c

            Case 4

                If chkanimationzym.Checked Then animation1()
                If dgv1.CurrentRow.Cells(16).Value = 0 Then
                    dasht = "dash"
                    snatch = "Snatch"
                Else
                    dasht = "BLK"
                    snatch = "snatch " & dgv1.CurrentRow.Cells(16).Value & "Kg"
                End If
                If dgv1.CurrentRow.Cells(5).Value = 1 Then
                    dash1 = "dash"
                Else
                    dash1 = "BLK"
                End If

                CasparCGDataCollection.Clear()
                CasparCGDataCollection.SetData("f0", dgv1.CurrentRow.Cells(1).Value)
                CasparCGDataCollection.SetData("f1", snatch)
                CasparCGDataCollection.SetData("f2", "Lift1 " & dgv1.CurrentRow.Cells(4).Value & "Kg")
                CasparCGDataCollection.SetData("f3", dgv1.CurrentRow.Cells(19).Value)
                If dgv1.Rows(y).Cells(0).Value <> "" Then
                    CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.CurrentRow.Cells(2).Value & ".png")
                End If
                CasparCGDataCollection.SetData("loader2", "C:/casparcg/mydata/games2/country/WithName/" & dasht & ".png")
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/country/WithName/" & dash1 & ".png")
                CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
                CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)


                CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/snatchr1", True, CasparCGDataCollection.ToAMCPEscapedXml)

                If chkanimationzym.Checked Then animationtoscreen()



            Case 6

                If chkanimationzym.Checked Then animation1()
                If dgv1.CurrentRow.Cells(16).Value = 0 Then
                    dasht = "dash"
                    snatch = "Snatch"
                Else
                    dasht = "BLK"
                    snatch = "snatch " & dgv1.CurrentRow.Cells(16).Value & "Kg"
                End If
                If dgv1.CurrentRow.Cells(5).Value = 1 Then
                    dash1 = "dash"
                Else
                    dash1 = "BLK"
                End If
                If dgv1.CurrentRow.Cells(7).Value = 1 Then
                    dash2 = "dash"
                Else
                    dash2 = "BLK"
                End If


                CasparCGDataCollection.Clear()
                CasparCGDataCollection.SetData("f0", dgv1.CurrentRow.Cells(1).Value)
                CasparCGDataCollection.SetData("f1", snatch)
                CasparCGDataCollection.SetData("f2", "Lift1 " & dgv1.CurrentRow.Cells(4).Value & "Kg")
                CasparCGDataCollection.SetData("f3", "Lift2 " & dgv1.CurrentRow.Cells(6).Value & "Kg")
                CasparCGDataCollection.SetData("f4", dgv1.CurrentRow.Cells(19).Value)
                If dgv1.Rows(y).Cells(0).Value <> "" Then
                    CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.CurrentRow.Cells(2).Value & ".png")
                End If
                CasparCGDataCollection.SetData("loader2", "C:/casparcg/mydata/games2/country/WithName/" & dasht & ".png")
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/country/WithName/" & dash1 & ".png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games2/country/WithName/" & dash2 & ".png")
                '  CasparCGDataCollection.SetData("loader52", eventlogoforgym.ImageLocation)

                CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
                CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

                CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/snatchr2", True, CasparCGDataCollection.ToAMCPEscapedXml)

                If chkanimationzym.Checked Then animationtoscreen()
            Case 8

                If chkanimationzym.Checked Then animation1()
                If dgv1.CurrentRow.Cells(16).Value = 0 Then
                    dasht = "dash"
                    snatch = "Snatch"
                Else
                    dasht = "BLK"
                    snatch = "snatch " & dgv1.CurrentRow.Cells(16).Value & "Kg"
                End If
                If dgv1.CurrentRow.Cells(5).Value = 1 Then
                    dash1 = "dash"
                Else
                    dash1 = "BLK"
                End If
                If dgv1.CurrentRow.Cells(7).Value = 1 Then
                    dash2 = "dash"
                Else
                    dash2 = "BLK"
                End If
                If dgv1.CurrentRow.Cells(9).Value = 1 Then
                    dash3 = "dash"
                Else
                    dash3 = "BLK"
                End If
                CasparCGDataCollection.Clear()
                CasparCGDataCollection.SetData("f0", dgv1.CurrentRow.Cells(1).Value)
                CasparCGDataCollection.SetData("f1", snatch)
                CasparCGDataCollection.SetData("f2", "Lift1 " & dgv1.CurrentRow.Cells(4).Value & "Kg")
                CasparCGDataCollection.SetData("f3", "Lift2 " & dgv1.CurrentRow.Cells(6).Value & "Kg")
                CasparCGDataCollection.SetData("f4", "Lift3 " & dgv1.CurrentRow.Cells(8).Value & "Kg")
                CasparCGDataCollection.SetData("f5", dgv1.CurrentRow.Cells(19).Value)
                If dgv1.Rows(y).Cells(0).Value <> "" Then
                    CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.CurrentRow.Cells(2).Value & ".png")
                End If
                CasparCGDataCollection.SetData("loader2", "C:/casparcg/mydata/games2/country/WithName/" & dasht & ".png")
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/country/WithName/" & dash1 & ".png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games2/country/WithName/" & dash2 & ".png")
                CasparCGDataCollection.SetData("loader5", "C:/casparcg/mydata/games2/country/WithName/" & dash3 & ".png")

                CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
                CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

                CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/snatchr3", True, CasparCGDataCollection.ToAMCPEscapedXml)

                If chkanimationzym.Checked Then animationtoscreen()
            Case 10

                If chkanimationzym.Checked Then animation1()

                If dgv1.CurrentRow.Cells(17).Value = 0 Then
                    dashc = "dash"
                    Clean_Jerk = "Clean&Jerk"
                Else
                    dashc = "BLK"
                    Clean_Jerk = "Clean&Jerk " & dgv1.CurrentRow.Cells(17).Value & "Kg"
                End If
                If dgv1.CurrentRow.Cells(18).Value = 0 Then
                    dasht = "dash"
                    total = "Total"
                Else
                    dasht = "BLK"
                    total = "Total " & dgv1.CurrentRow.Cells(18).Value & "Kg"
                End If
                If dgv1.CurrentRow.Cells(11).Value = 1 Then
                    dash1 = "dash"
                Else
                    dash1 = "BLK"
                End If
                If dgv1.CurrentRow.Cells(13).Value = 1 Then
                    dash2 = "dash"
                Else
                    dash2 = "BLK"
                End If
                If dgv1.CurrentRow.Cells(15).Value = 1 Then
                    dash3 = "dash"
                Else
                    dash3 = "BLK"
                End If

                CasparCGDataCollection.Clear()
                CasparCGDataCollection.SetData("f0", dgv1.CurrentRow.Cells(1).Value)
                CasparCGDataCollection.SetData("f1", "Snatch " & dgv1.CurrentRow.Cells(16).Value & "Kg")
                CasparCGDataCollection.SetData("f2", Clean_Jerk)
                CasparCGDataCollection.SetData("f3", total)
                CasparCGDataCollection.SetData("f4", "Lift1 " & dgv1.CurrentRow.Cells(10).Value & "Kg")
                CasparCGDataCollection.SetData("f5", dgv1.CurrentRow.Cells(19).Value)
                'CasparCGDataCollection.SetData("f4", "Lift2 " + dgv1.CurrentRow.Cells(6).Value + "Kg")
                'CasparCGDataCollection.SetData("f5", "Lift3 " + dgv1.CurrentRow.Cells(8).Value + "Kg")
                'CasparCGDataCollection.SetData("f2", "" + dgv1.CurrentRow.Cells(16).Value + "Kg")
                If dgv1.Rows(y).Cells(0).Value <> "" Then
                    CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.CurrentRow.Cells(2).Value & ".png")
                End If
                CasparCGDataCollection.SetData("loader2", "C:/casparcg/mydata/games2/country/WithName/" & dashc & ".png")
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/country/WithName/" & dasht & ".png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games2/country/WithName/" & dash1 & ".png")

                CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
                CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)
                '   CasparCGDataCollection.SetData("loader52", eventlogoforgym.ImageLocation)
                CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/C&J_R1", True, CasparCGDataCollection.ToAMCPEscapedXml)

                If chkanimationzym.Checked Then animationtoscreen()
            Case 12


                If chkanimationzym.Checked Then animation1()
                If chkanimationzym.Checked Then animation1()

                If dgv1.CurrentRow.Cells(17).Value = 0 Then
                    dashc = "dash"
                    Clean_Jerk = "Clean&Jerk"
                Else
                    dashc = "BLK"
                    Clean_Jerk = "Clean&Jerk " & dgv1.CurrentRow.Cells(17).Value & "Kg"
                End If
                If dgv1.CurrentRow.Cells(18).Value = 0 Then
                    dasht = "dash"
                    total = "Total"
                Else
                    dasht = "BLK"
                    total = "Total " & dgv1.CurrentRow.Cells(18).Value & "Kg"
                End If
                If dgv1.CurrentRow.Cells(11).Value = 1 Then
                    dash1 = "dash"
                Else
                    dash1 = "BLK"
                End If
                If dgv1.CurrentRow.Cells(13).Value = 1 Then
                    dash2 = "dash"
                Else
                    dash2 = "BLK"
                End If
                If dgv1.CurrentRow.Cells(15).Value = 1 Then
                    dash3 = "dash"
                Else
                    dash3 = "BLK"
                End If

                CasparCGDataCollection.Clear()
                CasparCGDataCollection.SetData("f0", dgv1.CurrentRow.Cells(1).Value)
                CasparCGDataCollection.SetData("f1", "Snatch " & dgv1.CurrentRow.Cells(16).Value & "Kg")
                CasparCGDataCollection.SetData("f2", Clean_Jerk)
                CasparCGDataCollection.SetData("f3", total)
                CasparCGDataCollection.SetData("f4", "Lift1 " & dgv1.CurrentRow.Cells(10).Value & "Kg")
                CasparCGDataCollection.SetData("f5", "Lift2 " & dgv1.CurrentRow.Cells(12).Value & "Kg")
                CasparCGDataCollection.SetData("f6", dgv1.CurrentRow.Cells(19).Value)
                'CasparCGDataCollection.SetData("f4", "Lift2 " + dgv1.CurrentRow.Cells(6).Value + "Kg")
                'CasparCGDataCollection.SetData("f5", "Lift3 " + dgv1.CurrentRow.Cells(8).Value + "Kg")
                'CasparCGDataCollection.SetData("f2", "" + dgv1.CurrentRow.Cells(16).Value + "Kg")
                If dgv1.Rows(y).Cells(0).Value <> "" Then
                    CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.CurrentRow.Cells(2).Value & ".png")
                End If
                CasparCGDataCollection.SetData("loader2", "C:/casparcg/mydata/games2/country/WithName/" & dashc & ".png")
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/country/WithName/" & dasht & ".png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games2/country/WithName/" & dash1 & ".png")
                CasparCGDataCollection.SetData("loader5", "C:/casparcg/mydata/games2/country/WithName/" & dash2 & ".png")

                CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
                CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

                CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/C&J_R2", True, CasparCGDataCollection.ToAMCPEscapedXml)



                If chkanimationzym.Checked Then animationtoscreen()
            Case 14


                If chkanimationzym.Checked Then animation1()


                If chkanimationzym.Checked Then animation1()
                If chkanimationzym.Checked Then animation1()

                If dgv1.CurrentRow.Cells(17).Value = 0 Then
                    dashc = "dash"
                    Clean_Jerk = "Clean&Jerk"
                Else
                    dashc = "BLK"
                    Clean_Jerk = "Clean&Jerk " & dgv1.CurrentRow.Cells(17).Value & "Kg"
                End If
                If dgv1.CurrentRow.Cells(18).Value = 0 Then
                    dasht = "dash"
                    total = "Total"
                Else
                    dasht = "BLK"
                    total = "Total " & dgv1.CurrentRow.Cells(18).Value & "Kg"
                End If
                If dgv1.CurrentRow.Cells(11).Value = 1 Then
                    dash1 = "dash"
                Else
                    dash1 = "BLK"
                End If
                If dgv1.CurrentRow.Cells(13).Value = 1 Then
                    dash2 = "dash"
                Else
                    dash2 = "BLK"
                End If
                If dgv1.CurrentRow.Cells(15).Value = 1 Then
                    dash3 = "dash"
                Else
                    dash3 = "BLK"
                End If

                CasparCGDataCollection.Clear()
                CasparCGDataCollection.SetData("f0", dgv1.CurrentRow.Cells(1).Value)
                CasparCGDataCollection.SetData("f1", "Snatch " & dgv1.CurrentRow.Cells(16).Value & "Kg")
                CasparCGDataCollection.SetData("f2", Clean_Jerk)
                CasparCGDataCollection.SetData("f3", total)
                CasparCGDataCollection.SetData("f4", "Lift1 " & dgv1.CurrentRow.Cells(10).Value & "Kg")
                CasparCGDataCollection.SetData("f5", "Lift2 " & dgv1.CurrentRow.Cells(12).Value & "Kg")
                CasparCGDataCollection.SetData("f6", "Lift3 " & dgv1.CurrentRow.Cells(14).Value & "Kg")
                CasparCGDataCollection.SetData("f7", dgv1.CurrentRow.Cells(19).Value)
                'CasparCGDataCollection.SetData("f4", "Lift2 " + dgv1.CurrentRow.Cells(6).Value + "Kg")
                'CasparCGDataCollection.SetData("f5", "Lift3 " + dgv1.CurrentRow.Cells(8).Value + "Kg")
                'CasparCGDataCollection.SetData("f2", "" + dgv1.CurrentRow.Cells(16).Value + "Kg")
                If dgv1.Rows(y).Cells(0).Value <> "" Then
                    CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.CurrentRow.Cells(2).Value & ".png")
                End If
                CasparCGDataCollection.SetData("loader2", "C:/casparcg/mydata/games2/country/WithName/" & dashc & ".png")
                CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/country/WithName/" & dasht & ".png")
                CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games2/country/WithName/" & dash1 & ".png")
                CasparCGDataCollection.SetData("loader5", "C:/casparcg/mydata/games2/country/WithName/" & dash2 & ".png")
                CasparCGDataCollection.SetData("loader6", "C:/casparcg/mydata/games2/country/WithName/" & dash3 & ".png")

                CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
                CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

                CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/C&J_R3", True, CasparCGDataCollection.ToAMCPEscapedXml)

                If chkanimationzym.Checked Then animationtoscreen()
        End Select
    End Sub

    Private Sub snatch_final_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles snatch_final.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("h1", GENDER.Text & " " & WEIGHT.Text)
        CasparCGDataCollection.SetData("h2", "Standings")
        For i = 0 To dgv1.RowCount - 1

            If dgv1.Rows(i).Cells(0).Value <> "" Then
                CasparCGDataCollection.SetData("sn" & i + 1, dgv1.Rows(i).Cells(19).Value)
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i + 1, dgv1.Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("value" & i + 1, dgv1.Rows(i).Cells(3).Value)
                CasparCGDataCollection.SetData("s1" & i + 1, dgv1.Rows(i).Cells(16).Value & "Kg")
                'CasparCGDataCollection.SetData("s2" & i + 1, dgv1.Rows(i).Cells(6).Value)
                'CasparCGDataCollection.SetData("s3" & i + 1, dgv1.Rows(i).Cells(8).Value)
                'CasparCGDataCollection.SetData("loaders1" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(5).Value & ".png")
                'CasparCGDataCollection.SetData("loaders2" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(7).Value & ".png")
                'CasparCGDataCollection.SetData("loaders3" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(9).Value & ".png")
            End If

        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        CasparCGDataCollection.SetData("startlist", WEIGHT.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/snatch_Final", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        dgv1.Update()
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("h1", GENDER.Text & " " & WEIGHT.Text)
        CasparCGDataCollection.SetData("h2", "Standings")
        For i = 0 To dgv1.RowCount - 1

            If dgv1.Rows(i).Cells(0).Value <> "" Then
                CasparCGDataCollection.SetData("sn" & i + 1, dgv1.Rows(i).Cells(19).Value)
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i + 1, dgv1.Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("value" & i + 1, dgv1.Rows(i).Cells(3).Value)
                CasparCGDataCollection.SetData("s" & i + 1, dgv1.Rows(i).Cells(16).Value)
                CasparCGDataCollection.SetData("s1" & i + 1, dgv1.Rows(i).Cells(10).Value)
                CasparCGDataCollection.SetData("s2" & i + 1, dgv1.Rows(i).Cells(12).Value)
                CasparCGDataCollection.SetData("s3" & i + 1, dgv1.Rows(i).Cells(14).Value)
                CasparCGDataCollection.SetData("t" & i + 1, dgv1.Rows(i).Cells(18).Value)

                CasparCGDataCollection.SetData("loaders1" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(11).Value & ".png")
                CasparCGDataCollection.SetData("loaders2" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(13).Value & ".png")
                CasparCGDataCollection.SetData("loaders3" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(15).Value & ".png")

                CasparCGDataCollection.SetData("loaderr" & i + 1, "C:/casparcg/mydata/games2/country/WithName/Rank.png")
                CasparCGDataCollection.SetData("loaders" & i + 1, "C:/casparcg/mydata/games2/country/WithName/Snatch.png")
                CasparCGDataCollection.SetData("loadert" & i + 1, "C:/casparcg/mydata/games2/country/WithName/Total.png")

            End If

        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)

        ' CasparCGDataCollection.SetData("startlist", WEIGHT.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/c&j_Results", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub



    Private Sub Results_Breakdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Results_Breakdown.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("h1", GENDER.Text & " " & WEIGHT.Text)
        CasparCGDataCollection.SetData("h2", "Standings")
        For i = 0 To dgv1.RowCount - 1

            If dgv1.Rows(i).Cells(0).Value <> "" Then
                CasparCGDataCollection.SetData("sn" & i + 1, dgv1.Rows(i).Cells(19).Value)
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i + 1, dgv1.Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("value" & i + 1, dgv1.Rows(i).Cells(3).Value)

                CasparCGDataCollection.SetData("s1" & i + 1, dgv1.Rows(i).Cells(16).Value)
                CasparCGDataCollection.SetData("s2" & i + 1, dgv1.Rows(i).Cells(17).Value)
                CasparCGDataCollection.SetData("s3" & i + 1, dgv1.Rows(i).Cells(18).Value)
            End If

        Next
        CasparCGDataCollection.SetData("loader51", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader52", eventlogo.ImageLocation)


        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/Results_Breakdown", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub Third_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Third.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("h1", GENDER.Text & " " & WEIGHT.Text)
        CasparCGDataCollection.SetData("h2", "THIRD")
        CasparCGDataCollection.SetData("f0", dgv1.Rows(2).Cells(1).Value)
        CasparCGDataCollection.SetData("f1", "Snatch " + dgv1.Rows(2).Cells(16).Value + "Kg")
        CasparCGDataCollection.SetData("f2", "C&J " + dgv1.Rows(2).Cells(17).Value + "Kg")
        CasparCGDataCollection.SetData("f3", "Total " + dgv1.Rows(2).Cells(18).Value + "Kg")
        If dgv1.Rows(0).Cells(0).Value <> "" Then
            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(2).Cells(2).Value & ".png")
        End If

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/Winner", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()


    End Sub

    Private Sub Winner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Winner.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("h1", GENDER.Text & " " & WEIGHT.Text)
        CasparCGDataCollection.SetData("h2", "WINNER")
        CasparCGDataCollection.SetData("f0", dgv1.Rows(0).Cells(1).Value)
        CasparCGDataCollection.SetData("f1", "Snatch " + dgv1.Rows(0).Cells(16).Value + "Kg")
        CasparCGDataCollection.SetData("f2", "C&J " + dgv1.Rows(0).Cells(17).Value + "Kg")
        CasparCGDataCollection.SetData("f3", "Total " + dgv1.Rows(0).Cells(18).Value + "Kg")
        If dgv1.Rows(0).Cells(0).Value <> "" Then
            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(0).Cells(2).Value & ".png")
        End If
        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/Winner", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()


    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next
        Dim first, second, third, fourth, fifth, six, snatch, cj, total As String
        Dim EVENT_SELC As String
        Dim i, j, k As Integer
        Dim C As Integer
        C = dgv1.CurrentCellAddress.X 'Column  

        If C < 4 Or C > 15 Then
            Exit Sub
        End If
        cj = " "
        snatch = " "
        For i = 0 To dgv1.Rows.Count - 1

            If dgv1.Rows(i).Cells(4).Style.BackColor = Color.Green Then
                first = dgv1.Rows(i).Cells(4).Value
            Else
                first = 0
            End If
            If dgv1.Rows(i).Cells(6).Style.BackColor = Color.Green Then
                second = dgv1.Rows(i).Cells(6).Value
            Else
                second = 0
            End If
            If dgv1.Rows(i).Cells(8).Style.BackColor = Color.Green Then
                third = dgv1.Rows(i).Cells(8).Value
            Else
                third = 0
            End If
            If dgv1.Rows(i).Cells(10).Style.BackColor = Color.Green Then
                fourth = dgv1.Rows(i).Cells(10).Value
            Else
                fourth = 0
            End If
            If dgv1.Rows(i).Cells(12).Style.BackColor = Color.Green Then
                fifth = dgv1.Rows(i).Cells(12).Value
            Else
                fifth = 0
            End If
            If dgv1.Rows(i).Cells(14).Style.BackColor = Color.Green Then
                six = dgv1.Rows(i).Cells(14).Value
            Else
                six = 0
            End If

            If first >= second And first >= third Then
                snatch = first
            ElseIf second >= first And second >= third Then
                snatch = second
            ElseIf third >= first And third >= second Then
                snatch = third
            End If

            If snatch > 0 Then dgv1.Rows(i).Cells(16).Value = snatch

            first = 0
            second = 0
            third = 0
            fourth = 0
            fifth = 0
            six = 0
            snatch = 0
            cj = 0
        Next


        dgv1.Sort(dgv1.Columns(3), System.ComponentModel.ListSortDirection.Ascending)
        dgv1.Sort(dgv1.Columns(16), System.ComponentModel.ListSortDirection.Descending)
        For k = 0 To dgv1.Rows.Count - 2

            If dgv1.Rows(k).Cells(16).Value > 0 Then
                dgv1.Rows(k).Cells(19).Value = k + 1
            Else
                dgv1.Rows(k).Cells(19).Value = " "
            End If
        Next
        dgv1.Update()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error Resume Next
        Dim first, second, third, fourth, fifth, six, snatch, cj, total As String
        Dim EVENT_SELC As String
        Dim i, j, k As Integer
        Dim C As Integer
        C = dgv1.CurrentCellAddress.X 'Column  

        If C < 4 Or C > 15 Then
            Exit Sub
        End If
        cj = " "
        snatch = " "
        For i = 0 To dgv1.Rows.Count - 1

            If dgv1.Rows(i).Cells(4).Style.BackColor = Color.Green Then
                first = dgv1.Rows(i).Cells(4).Value
            Else
                first = 0
            End If
            If dgv1.Rows(i).Cells(6).Style.BackColor = Color.Green Then
                second = dgv1.Rows(i).Cells(6).Value
            Else
                second = 0
            End If
            If dgv1.Rows(i).Cells(8).Style.BackColor = Color.Green Then
                third = dgv1.Rows(i).Cells(8).Value
            Else
                third = 0
            End If
            If dgv1.Rows(i).Cells(10).Style.BackColor = Color.Green Then
                fourth = dgv1.Rows(i).Cells(10).Value
            Else
                fourth = 0
            End If
            If dgv1.Rows(i).Cells(12).Style.BackColor = Color.Green Then
                fifth = dgv1.Rows(i).Cells(12).Value
            Else
                fifth = 0
            End If
            If dgv1.Rows(i).Cells(14).Style.BackColor = Color.Green Then
                six = dgv1.Rows(i).Cells(14).Value
            Else
                six = 0
            End If

            If first >= second And first >= third Then
                snatch = first
            ElseIf second >= first And second >= third Then
                snatch = second
            ElseIf third >= first And third >= second Then
                snatch = third
            End If

            If fourth >= fifth And fourth >= six Then
                cj = fourth
            ElseIf fifth >= fourth And fifth >= six Then
                cj = fifth
            ElseIf six >= fourth And six >= fifth Then
                cj = six
            End If
            If snatch > 0 Then dgv1.Rows(i).Cells(16).Value = snatch
            If cj > 0 Then dgv1.Rows(i).Cells(17).Value = cj

            If Val(snatch) > 0 And Val(cj) > 0 Then
                total = Val(snatch) + Val(cj)
                dgv1.Rows(i).Cells(18).Value = total
            Else
                total = "0"

            End If

            first = 0
            second = 0
            third = 0
            fourth = 0
            fifth = 0
            six = 0
            snatch = 0
            cj = 0
        Next

        dgv1.Sort(dgv1.Columns(3), System.ComponentModel.ListSortDirection.Ascending)
        dgv1.Sort(dgv1.Columns(18), System.ComponentModel.ListSortDirection.Descending)
        For k = 0 To dgv1.Rows.Count - 2
            If dgv1.Rows(k).Cells(18).Value > 0 Then

                dgv1.Rows(k).Cells(19).Value = k + 1
            Else
                dgv1.Rows(k).Cells(19).Value = " "
            End If
        Next
        dgv1.Update()

    End Sub

    Private Sub Second_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Second.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("h1", GENDER.Text & " " & WEIGHT.Text)
        CasparCGDataCollection.SetData("h2", "SECOND")
        CasparCGDataCollection.SetData("f0", dgv1.Rows(1).Cells(1).Value)
        CasparCGDataCollection.SetData("f1", "Snatch " + dgv1.Rows(1).Cells(16).Value + "Kg")
        CasparCGDataCollection.SetData("f2", "C&J " + dgv1.Rows(1).Cells(17).Value + "Kg")
        CasparCGDataCollection.SetData("f3", "Total " + dgv1.Rows(1).Cells(18).Value + "Kg")
        If dgv1.Rows(0).Cells(0).Value <> "" Then
            CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(1).Cells(2).Value & ".png")
        End If

        CasparCGDataCollection.SetData("loader5", gamelogo.ImageLocation)
        CasparCGDataCollection.SetData("loader6", eventlogo.ImageLocation)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/Winner", True, CasparCGDataCollection.ToAMCPEscapedXml)

        If chkanimationzym.Checked Then animationtoscreen()


    End Sub




    Private Sub Top3_Total_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Top3_Total.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("h1", "Total")

        For i = 0 To dgv1.RowCount - 1

            If dgv1.Rows(i).Cells(0).Value <> "" Then
                CasparCGDataCollection.SetData("sn" & i + 1, dgv1.Rows(i).Cells(19).Value)
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i + 1, dgv1.Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("value" & i + 1, dgv1.Rows(i).Cells(3).Value)
                CasparCGDataCollection.SetData("t" & i + 1, dgv1.Rows(i).Cells(18).Value + "Kg")
                'CasparCGDataCollection.SetData("s2" & i + 1, dgv1.Rows(i).Cells(6).Value)
                'CasparCGDataCollection.SetData("s3" & i + 1, dgv1.Rows(i).Cells(8).Value)
                'CasparCGDataCollection.SetData("loaders1" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(5).Value & ".png")
                'CasparCGDataCollection.SetData("loaders2" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(7).Value & ".png")
                'CasparCGDataCollection.SetData("loaders3" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(9).Value & ".png")
            End If

        Next

        'CasparCGDataCollection.SetData("startlist", WEIGHT.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/top3", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub



    Private Sub Top3_Snatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Top3_Snatch.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()

        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("h1", "Snatch")

        For i = 0 To dgv1.RowCount - 1

            If dgv1.Rows(i).Cells(0).Value <> "" Then
                CasparCGDataCollection.SetData("sn" & i + 1, dgv1.Rows(i).Cells(19).Value)
                CasparCGDataCollection.SetData("loader" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(2).Value & ".png")
                CasparCGDataCollection.SetData("name" & i + 1, dgv1.Rows(i).Cells(1).Value)
                CasparCGDataCollection.SetData("value" & i + 1, dgv1.Rows(i).Cells(3).Value)
                CasparCGDataCollection.SetData("t" & i + 1, dgv1.Rows(i).Cells(16).Value + "Kg")
                'CasparCGDataCollection.SetData("s2" & i + 1, dgv1.Rows(i).Cells(6).Value)
                'CasparCGDataCollection.SetData("s3" & i + 1, dgv1.Rows(i).Cells(8).Value)
                'CasparCGDataCollection.SetData("loaders1" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(5).Value & ".png")
                'CasparCGDataCollection.SetData("loaders2" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(7).Value & ".png")
                'CasparCGDataCollection.SetData("loaders3" & i + 1, "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(i).Cells(9).Value & ".png")
            End If

        Next

        'CasparCGDataCollection.SetData("startlist", WEIGHT.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/top3", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub Rank_Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rank_Reset.Click
        On Error Resume Next
        Dim rank As Integer

        dgv1.Update()
        For k = 0 To dgv1.Rows.Count - 2
            rank = Val(dgv1.Rows(k).Cells(19).Value)
            If rank = 0 Then dgv1.Rows(k).Cells(19).Value = 100
            If rank > 0 Then dgv1.Rows(k).Cells(19).Value = rank

        Next

        dgv1.Sort(dgv1.Columns(19), System.ComponentModel.ListSortDirection.Ascending)
        For k = 0 To dgv1.Rows.Count - 2
            If dgv1.Rows(k).Cells(19).Value = 100 Then
                dgv1.Rows(k).Cells(19).Value = " "

            Else
                dgv1.Rows(k).Cells(19).Value = dgv1.Rows(k).Cells(19).Value

            End If

        Next
    End Sub







    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        On Error Resume Next

        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        ' CasparCGDataCollection.SetData("f0", dgv1.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("f1", TextWeight.Text)

        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & GR.Text & ".png")



        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/Game_record", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub SNATCH_SMALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SNATCH_SMALL.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("h1", "Snatch")
        '  CasparCGDataCollection.SetData("sn" & i + 1, dgv1.Rows(i).Cells(19).Value)
        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(0).Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader2", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(1).Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(2).Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("t1", dgv1.Rows(0).Cells(16).Value & "Kg")
        CasparCGDataCollection.SetData("t2", dgv1.Rows(1).Cells(16).Value & "Kg")
        CasparCGDataCollection.SetData("t3", dgv1.Rows(2).Cells(16).Value & "Kg")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/Snatch_short", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()


    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("h1", "Snatch")
        '  CasparCGDataCollection.SetData("sn" & i + 1, dgv1.Rows(i).Cells(19).Value)
        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(0).Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader2", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(1).Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(2).Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(3).Cells(2).Value & ".png")

        CasparCGDataCollection.SetData("t1", dgv1.Rows(0).Cells(16).Value & "Kg")
        CasparCGDataCollection.SetData("t2", dgv1.Rows(1).Cells(16).Value & "Kg")
        CasparCGDataCollection.SetData("t3", dgv1.Rows(2).Cells(16).Value & "Kg")
        CasparCGDataCollection.SetData("t4", dgv1.Rows(3).Cells(16).Value & "Kg")



        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/Snatch_short4", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()


    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("h1", "Total")
        '  CasparCGDataCollection.SetData("sn" & i + 1, dgv1.Rows(i).Cells(19).Value)
        CasparCGDataCollection.SetData("t1", dgv1.Rows(0).Cells(18).Value + "Kg")
        CasparCGDataCollection.SetData("t2", dgv1.Rows(1).Cells(18).Value + "Kg")
        CasparCGDataCollection.SetData("t3", dgv1.Rows(2).Cells(18).Value + "Kg")
        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(0).Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader2", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(1).Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(2).Cells(2).Value & ".png")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/Snatch_short", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("h1", "Total")
        '  CasparCGDataCollection.SetData("sn" & i + 1, dgv1.Rows(i).Cells(19).Value)
        CasparCGDataCollection.SetData("loader1", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(0).Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader2", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(1).Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader3", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(2).Cells(2).Value & ".png")
        CasparCGDataCollection.SetData("loader4", "C:/casparcg/mydata/games2/country/WithName/" & dgv1.Rows(3).Cells(2).Value & ".png")

        CasparCGDataCollection.SetData("t1", dgv1.Rows(0).Cells(18).Value + "Kg")
        CasparCGDataCollection.SetData("t2", dgv1.Rows(1).Cells(18).Value + "Kg")
        CasparCGDataCollection.SetData("t3", dgv1.Rows(2).Cells(18).Value + "Kg")
        CasparCGDataCollection.SetData("t4", dgv1.Rows(3).Cells(18).Value + "Kg")



        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergymnastics.Text), Int(cmblayergymnastics.Text), "cmp/games2/wl/Snatch_short4", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If chkanimationzym.Checked Then animationtoscreen()


    End Sub















    Private Sub Highlights_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub eventlogo_Click(sender As Object, e As EventArgs) Handles eventlogo.Click
        On Error Resume Next
        openimage("C:\casparcg\mydata\games2\event logo\", sender)
    End Sub

    Private Sub gamelogo_Click(sender As Object, e As EventArgs) Handles gamelogo.Click
        On Error Resume Next
        openimage("C:\casparcg\mydata\games2\games logo\", sender)
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

    Private Sub dgv1_SelectionChanged(sender As Object, e As EventArgs) Handles dgv1.SelectionChanged
        Label6.Text = dgv1.CurrentCell.RowIndex
        Label7.Text = dgv1.CurrentCell.ColumnIndex
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdhide_Click(sender As Object, e As EventArgs)
        Hide()
    End Sub
End Class
