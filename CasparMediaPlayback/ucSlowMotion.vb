Imports System.IO
Public Class ucSlowMotion
    Private Sub cmdhidegbslowmotion_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Private Sub ucSlowMotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialiseslowmotiondata()
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        On Error Resume Next
        Process.Start("http://casparcg.com/forum/viewtopic.php?f=3&t=1310")
    End Sub
    Private Sub cmdLiveSeekEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLiveSeekEnd.Click
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " speed 1")
        Threading.Thread.Sleep(250)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " seek |0")
    End Sub
    Private Sub nSlowMotion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nSlowMotion.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " speed " & nSlowMotion.Value)
        ucPlaylist.tmrduration.Enabled = True
    End Sub
    Private Sub nSlowMotionforward_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nSlowMotionforward.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " speed " & nSlowMotionforward.Value)
        ucPlaylist.tmrduration.Enabled = True
    End Sub

    Private Sub nSlowMotionbackward_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nSlowMotionbackward.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " speed " & nSlowMotionbackward.Value)
        ucPlaylist.tmrduration.Enabled = True
    End Sub
    Sub playwithspeed0()
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " speed 0")
        Threading.Thread.Sleep(250)
    End Sub
    Private Sub cmdgotoin1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgotoin1.Click
        On Error Resume Next
        playwithspeed0()
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " seek " & txtmarkin1.Text)
    End Sub

    Private Sub cmdgotoin2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgotoin2.Click
        On Error Resume Next
        playwithspeed0()
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " seek |" & txtmarkin2.Text)
    End Sub

    Private Sub cmdgotoin3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgotoin3.Click
        On Error Resume Next
        playwithspeed0()
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " seek +" & txtmarkin3.Text)
    End Sub

    Private Sub cmdgotoin4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgotoin4.Click
        On Error Resume Next
        playwithspeed0()
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & """" & " seek -" & txtmarkin4.Text)
    End Sub

    Private Sub cmdplaydecklinksm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplaydecklinksm.Click
        On Error Resume Next
        If frmmediaplayer.cmdconnect.BackColor = Color.Green Then
            CasparDevice.SendString(txtplaydecklinksm.Text)
        End If
    End Sub
    Private Sub cmdplayforslowmotion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayforslowmotion.Click
        On Error Resume Next

        CasparDevice.SendString(txtplayforslowmotion.Text)
        getStratTimeCode()

    End Sub

    Sub getStratTimeCode()
        On Error Resume Next

        SendString(NetStream, "info 2-1" & vbCrLf)

        Threading.Thread.Sleep(100)

        Dim returndata As String = ""
        Dim data(10024) As Byte
        NetStream.Read(data, 0, 10024)
        returndata = System.Text.Encoding.UTF8.GetString(data)


        Dim kplayhead As Array = Split(returndata, "<start-timecode>")
        Dim lplayhead As Array = Split(kplayhead(1), "</start-timecode>")
        lblstrat_time_code.Text = lplayhead(0)



    End Sub
    Private Sub cmdrecordforslowmotion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrecordforslowmotion.Click
        On Error Resume Next
        If frmmediaplayer.cmdconnect.BackColor = Color.Green Then
            cmdrecordforslowmotion.BackColor = Color.Green
            CasparDevice.SendString(txtrecordforslowmotion.Text & " " & lblslowmotionrecordquality.Text & " " & cmbslowmotionrecordquality.Text & " " & lblslowmotionrecordsubsampling.Text & " " & cmbslowmotionrecordsubsampling.Text)
        End If
    End Sub

    Private Sub cmdstoprecordforslowmotion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstoprecordforslowmotion.Click
        On Error Resume Next
        CasparDevice.SendString(txtstoprecordforslowmotion.Text)
        cmdrecordforslowmotion.BackColor = Color.Red
    End Sub
    Private Sub cmdmarkinslowmotion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmarkinslowmotion.Click
        On Error Resume Next
        dgvslowmotion.CurrentRow.Cells(0).Value = "IN Point " & ucOSC.dgvosc.Rows(6).Cells(1).Value
        dgvslowmotion.CurrentRow.Cells(1).Value = ucOSC.dgvosc.Rows(6).Cells(1).Value
        dgvslowmotion.Rows.Insert(dgvslowmotion.Rows.Count - 1)
        dgvslowmotion.CurrentCell = dgvslowmotion.Rows(dgvslowmotion.CurrentRow.Index + 1).Cells(0)
    End Sub

    Private Sub dgvslowmotion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvslowmotion.CellContentClick
        On Error Resume Next
        If dgvslowmotion.Columns(e.ColumnIndex).Name = "gotoin" Then
            playwithspeed0()
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " seek " & dgvslowmotion.CurrentRow.Cells(1).Value)
        End If
    End Sub
    Sub initialiseslowmotiondata()
        On Error Resume Next
        dgvslowmotion.Rows.Add(8)
        dgvslowmotion.Rows(0).Cells(0).Value = "In Pont 1"
        dgvslowmotion.Rows(1).Cells(0).Value = "In Pont 2"
        dgvslowmotion.Rows(2).Cells(0).Value = "In Pont 3"
        dgvslowmotion.Rows(3).Cells(0).Value = "In Pont 4"
        dgvslowmotion.Rows(4).Cells(0).Value = "In Pont 5"

        dgvslowmotion.Rows(0).Cells(1).Value = "100"
        dgvslowmotion.Rows(1).Cells(1).Value = "200"
        dgvslowmotion.Rows(2).Cells(1).Value = "300"
        dgvslowmotion.Rows(3).Cells(1).Value = "400"
        dgvslowmotion.Rows(4).Cells(1).Value = "500"
    End Sub



    Private Sub newtsslowmotion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        newdgvslowmotion()
    End Sub
    Sub newdgvslowmotion()
        On Error Resume Next
        dgvslowmotion.Rows.Clear()
        dgvslowmotion.Rows.Add(2)
        lblinpointlist.Text = "IN Point List= " & "New IN Ponit List"
    End Sub

    Private Sub opentsslowmotion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub openfileslowmotion()
        On Error Resume Next
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = "c:\casparcg\mydata\inpoint\"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)
                'clear list
                dgvslowmotion.Rows.Clear()
                'Loop through and add list to the file.
                Dim g As Integer = 0
                Dim li As String
                Do Until sr.EndOfStream = True
                    li = sr.ReadLine()
                    dgvslowmotion.Rows.Add()
                    Dim xyz As Array = Split(li, ",")
                    dgvslowmotion.Rows(g).Cells(0).Value = xyz(0)
                    dgvslowmotion.Rows(g).Cells(1).Value = xyz(1)

                    g = g + 1
                Loop
                sr.Close()
            End Using
            Me.lblinpointlist.Text = "In Point List=  " & ofd2.FileName
        End If
    End Sub

    Private Sub savetsslowmotion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub savefileslowmotion()
        On Error Resume Next
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "c:\casparcg\mydata\inpoint\"
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvslowmotion.Rows.Count = 0 Then
                    sw.Write("")
                Else
                    'Loop through and add list to the file.
                    Dim f As Integer = 0
                    Do Until f = dgvslowmotion.Rows.Count
                        sw.WriteLine(dgvslowmotion.Rows(f).Cells(0).Value & "," & dgvslowmotion.Rows(f).Cells(1).Value)
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            Me.lblinpointlist.Text = "In Point List=  " & osd2.FileName
        End If
    End Sub

    Private Sub cuttsslowmotion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub deleteclipslowmotion()
        On Error Resume Next
        dgvslowmotion.Rows.RemoveAt(dgvslowmotion.CurrentRow.Index)
    End Sub

    Private Sub copytsslowmotion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub clipcopyslowmotion()
        On Error Resume Next
        tempRow = Me.dgvslowmotion.CurrentRow
    End Sub

    Private Sub pastetsslowmotion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub insertcopiedslowmotion()
        On Error Resume Next
        Dim curRow As Integer = Me.dgvslowmotion.CurrentCell.RowIndex
        dgvslowmotion.Rows.Insert(dgvslowmotion.CurrentRow.Index)
        dgvslowmotion.CurrentCell = dgvslowmotion.Rows(curRow).Cells(0)
        Me.dgvslowmotion.Item(0, curRow).Value = tempRow.Cells(0).Value
        Me.dgvslowmotion.Item(1, curRow).Value = tempRow.Cells(1).Value
    End Sub

    Private Sub uptsslowmotion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uptsslowmotion.Click
        On Error Resume Next
        clipmoveupslowmotion()
    End Sub
    Sub clipmoveupslowmotion()
        On Error Resume Next
        If Me.dgvslowmotion.CurrentCell.RowIndex <> 0 Then
            Dim curRow As Integer = Me.dgvslowmotion.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvslowmotion.CurrentRow
            Me.dgvslowmotion.Rows.Remove(myRow)
            Me.dgvslowmotion.Rows.Insert(curRow - 1, myRow)
            dgvslowmotion.CurrentCell = dgvslowmotion.Rows(curRow - 1).Cells(0)
        End If
    End Sub

    Private Sub downtsslowmotion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles downtsslowmotion.Click
        On Error Resume Next
        clipmovedownslowmotion()
    End Sub
    Sub clipmovedownslowmotion()
        On Error Resume Next
        If dgvslowmotion.CurrentCell.RowIndex <> dgvslowmotion.Rows.Count - 2 Then
            Dim curRow As Integer = Me.dgvslowmotion.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvslowmotion.CurrentRow
            Me.dgvslowmotion.Rows.Remove(myRow)
            dgvslowmotion.Rows.Insert(curRow + 1, myRow)
            dgvslowmotion.CurrentCell = dgvslowmotion.Rows(curRow + 1).Cells(0)

        End If
    End Sub

    Private Sub inserttsslowmotion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inserttsslowmotion.Click
        On Error Resume Next
        clipinsertslowmotion()
    End Sub
    Sub clipinsertslowmotion()
        On Error Resume Next
        dgvslowmotion.Rows.Insert(dgvslowmotion.CurrentRow.Index)
    End Sub

    Private Sub deletetsslowmotion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletetsslowmotion.Click
        On Error Resume Next
        deleteclipslowmotion()
    End Sub


    Private Sub cmdspeed25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdspeed25.Click
        On Error Resume Next
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " speed .25")
    End Sub

    Private Sub cmdspeed50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdspeed50.Click
        On Error Resume Next
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " speed .5")
    End Sub

    Private Sub cmdspeed75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdspeed75.Click
        On Error Resume Next
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " speed .75")
    End Sub

    Private Sub cmdspeed100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdspeed100.Click
        On Error Resume Next
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " speed 1")
    End Sub

    Private Sub cmdspeedminus25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdspeedminus25.Click
        On Error Resume Next
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " speed -.25")
    End Sub

    Private Sub cmdspeedminus50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdspeedminus50.Click
        On Error Resume Next
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " speed -.5")
    End Sub

    Private Sub cmdspeedminus75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdspeedminus75.Click
        On Error Resume Next
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " speed -.75")
    End Sub

    Private Sub cmdspeedminus100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdspeedminus100.Click
        On Error Resume Next
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " speed -1")
    End Sub

    Private Sub cmdspeed0_Click(sender As Object, e As EventArgs) Handles cmdspeed0.Click
        On Error Resume Next
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " speed 0")
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        On Error Resume Next
        newdgvslowmotion()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        On Error Resume Next
        openfileslowmotion()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        On Error Resume Next
        savefileslowmotion()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        On Error Resume Next
        deleteclipslowmotion()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        On Error Resume Next
        clipcopyslowmotion()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        On Error Resume Next
        insertcopiedslowmotion()
    End Sub

    Private Sub MenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip1.MouseHover
        MakeMenuDropDownWhenParrented(sender)
    End Sub
End Class
