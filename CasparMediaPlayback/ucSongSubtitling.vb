Imports Svt.Caspar

Imports Bespoke.Common.Osc
Imports System.Net
Imports System.IO

Public Class ucSongSubtitling

    Dim ikeypress As Integer = 1

    Dim tempRow As DataGridViewRow

    Dim WithEvents sOscServer As OscServer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialiseonelinerdata()

        oscstartandregister()
        refreshmmedia()
    End Sub

    Sub frametohms(ByVal aa As Integer)

    End Sub
    Sub stoposcserver()
        On Error Resume Next
        sOscServer.Stop()
        sOscServer.ClearMethods()
        sOscServer = Nothing
    End Sub
    Sub oscstartandregister()
        On Error Resume Next
        If sOscServer.IsRunning = False Then
            Dim ttype As Integer = 1
            Bespoke.Common.Osc.OscPacket.LittleEndianByteOrder = False
            sOscServer = New OscServer(ttype, IPAddress.Any, cmboscport.Text)
            sOscServer.Start()
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/file/frame")
            sOscServer.FilterRegisteredMethods = False

        End If
    End Sub
    Private Sub invokeControls1(ByVal e As OscMessageReceivedEventArgs)
        On Error Resume Next
        If Me.InvokeRequired Then
            Me.Invoke(New invokeControlsDelegate1(AddressOf Me.invokeControls1), e)
        Else
            If e.Message.Address = "/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/file/frame" Then
                lblhmsf.Text = FToHMSF(e.Message.Data(0))
            End If
        End If
    End Sub

    Private Function FToHMSF(ByVal frame As Integer) As String
        '
        Dim ts As TimeSpan
        Dim totHrs As Integer
        Dim H, M, S, F, HMSF As String

        ts = TimeSpan.FromMilliseconds(frame * 1000 / 25)

        totHrs = Math.Truncate(ts.TotalHours) 'strip away decimal points
        H = Format(totHrs, "0#") & ":"
        M = Format(ts.Minutes, "0#") & ":"
        S = Format(ts.Seconds, "0#") & ":"
        F = Format((ts.Milliseconds) * fps / 1000, "0#")

        HMSF = H & M & S & F
        '
        Return HMSF

    End Function
    Private Function HMSFtoF(ByVal HMSF As String) As String
        Dim F As String
        F = (Val(Mid(HMSF, 1, 2)) * fps * 60 * 60 + Val(Mid(HMSF, 4, 2)) * fps * 60 + Val(Mid(HMSF, 7, 2)) * fps + Val(Mid(HMSF, 10, 2))).ToString
        Return F
    End Function

    Private Delegate Sub invokeControlsDelegate1(ByVal e As OscMessageReceivedEventArgs)

    Private Sub sOscServer_MessageReceived(ByVal sender As Object, ByVal e As OscMessageReceivedEventArgs) Handles sOscServer.MessageReceived
        On Error Resume Next
        Me.invokeControls1(e)
    End Sub
    Sub initialiseonelinerdata()
        'On Error Resume Next
        Using sr As StreamReader = New StreamReader("c:\casparcg\mydata\songsubtitling\hindi.txt")

            dgvonelinesuper.Rows.Clear()

            Dim g As Integer = 0
            Dim li As String
            Do Until sr.EndOfStream = True
                li = sr.ReadLine()
                dgvonelinesuper.Rows.Add()
                Dim xyz As Array = Split(li, Chr(2))
                dgvonelinesuper.Rows(g).Cells(0).Value = xyz(0)
                dgvonelinesuper.Rows(g).Cells(1).Value = xyz(1)
                dgvonelinesuper.Rows(g).Cells(2).Value = xyz(2)
                dgvonelinesuper.Rows(g).Cells(3).Value = xyz(3)
                dgvonelinesuper.Rows(g).Cells(4).Value = xyz(4)
                g = g + 1
            Loop
            sr.Close()
        End Using
        Me.dgvonelinesuper.Columns(0).HeaderText = ("c:\casparcg\mydata\songsubtitling\hindi.txt")


    End Sub

    Private Sub cmdonelinesuperplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdonelinesuperplay.Click
        On Error Resume Next
        playoneliner()
    End Sub
    Sub playoneliner()
        On Error Resume Next
        CasparCGDataCollection.Clear()
        Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(dgvonelinesuper.CurrentRow.Cells(0).Value)
        CasparCGDataCollection.SetData("xf0", System.Convert.ToBase64String(array))
        CasparCGDataCollection.SetData("scrolling_speed", (Val(dgvonelinesuper.CurrentRow.Cells(4).Value) / 2) / HMSFtoF(dgvonelinesuper.CurrentRow.Cells(3).Value))
        ' CasparCGDataCollection.SetData("xf0", dgvonelinesuper.CurrentRow.Cells(0).Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayeronelinesuper.Text), Int(cmblayeronelinesuper.Text), ("CMP/songsubtitling/songsubtitling"), True, CasparCGDataCollection.ToAMCPEscapedXml)
        ikeypress = 2
    End Sub


    Private Sub cmdonelinesuperstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdonelinesuperstop.Click
        stoponeliner()
    End Sub
    Sub stoponeliner()
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayeronelinesuper.Text), Int(cmblayeronelinesuper.Text))
        dgvonelinesuper.CurrentCell = dgvonelinesuper.Rows(dgvonelinesuper.CurrentRow.Index + 1).Cells(0)
        ikeypress = 1
    End Sub


    Private Sub txtrecievekeyboard_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdinpoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdinpoint.Click
        markinpoint()
    End Sub
    Sub markinpoint()
        On Error Resume Next
        dgvonelinesuper.CurrentRow.Cells(1).Value = lblhmsf.Text
        ikeypress = 2

    End Sub
    Private Sub cmdoutpoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdoutpoint.Click
        markoutpoint()

    End Sub

    Sub markoutpoint()
        On Error Resume Next
        dgvonelinesuper.CurrentRow.Cells(2).Value = lblhmsf.Text
        dgvonelinesuper.CurrentRow.Cells(3).Value = FToHMSF(HMSFtoF(dgvonelinesuper.CurrentRow.Cells(2).Value) - HMSFtoF(dgvonelinesuper.CurrentRow.Cells(1).Value))
        dgvonelinesuper.CurrentCell = dgvonelinesuper.Rows(dgvonelinesuper.CurrentRow.Index + 1).Cells(0)
        ikeypress = 1
    End Sub

    Private Sub cmdStartSubtitling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStartSubtitling.Click
        On Error Resume Next
        tmrstartsubtitling.Enabled = True
    End Sub

    Private Sub tmrstartsubtitling_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrstartsubtitling.Tick
        ' On Error Resume Next
        For i = 0 To dgvonelinesuper.Rows.Count - 1
            If (lblhmsf.Text) = FToHMSF(HMSFtoF(dgvonelinesuper.Rows(i).Cells(1).Value) - HMSFtoF((txttemplateresponseframe.Text))) Then
                dgvonelinesuper.CurrentCell = dgvonelinesuper.Rows(i).Cells(0)
                playoneliner()
            End If
            If (lblhmsf.Text) = FToHMSF(HMSFtoF(dgvonelinesuper.Rows(i).Cells(2).Value) - HMSFtoF((txttemplateresponseframe.Text))) Then
                dgvonelinesuper.CurrentCell = dgvonelinesuper.Rows(i).Cells(0)
                stoponeliner()
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        tmrstartsubtitling.Enabled = False
    End Sub
    Private Sub cmdrefreshmediafiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrefreshmediafiles.Click
        refreshmmedia()
    End Sub
    Sub refreshmmedia()
        On Error Resume Next
        cmbmediaforsubtitling.Items.Clear()
        CasparDevice.RefreshMediafiles()
        Threading.Thread.Sleep(250)
        For Each File In CasparDevice.Mediafiles
            cmbmediaforsubtitling.Items.Add(Replace(File.ToString, "\", "/"))
        Next
    End Sub

    Sub playclip()
        On Error Resume Next

        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & cmbmediaforsubtitling.Text & """" & " loop")



    End Sub
    Private Sub cmdpause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pauseplay()
    End Sub
    Sub pauseplay()
        On Error Resume Next

        CasparDevice.SendString("pause " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer)

    End Sub
    Private Sub cmdgotoin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgotoin.Click
        On Error Resume Next
        tmrstartsubtitling.Enabled = False

        CasparDevice.SendString("load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & cmbmediaforsubtitling.Text & """" & " seek " & (HMSFtoF(dgvonelinesuper.CurrentRow.Cells(1).Value)))

    End Sub

    Private Sub opentsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opentsoneliner.Click
        On Error Resume Next
        openfileoneliner()
    End Sub
    Sub openfileoneliner()
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog
        ofd2.InitialDirectory = "c:\casparcg\mydata\songsubtitling\"
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sr As StreamReader = New StreamReader(ofd2.FileName)

                dgvonelinesuper.Rows.Clear()

                Dim g As Integer = 0
                Dim li As String
                Do Until sr.EndOfStream = True
                    li = sr.ReadLine()
                    dgvonelinesuper.Rows.Add()
                    Dim xyz As Array = Split(li, Chr(2))
                    dgvonelinesuper.Rows(g).Cells(0).Value = xyz(0)
                    dgvonelinesuper.Rows(g).Cells(1).Value = xyz(1)
                    dgvonelinesuper.Rows(g).Cells(2).Value = xyz(2)
                    dgvonelinesuper.Rows(g).Cells(3).Value = xyz(3)
                    dgvonelinesuper.Rows(g).Cells(4).Value = xyz(4)
                    g = g + 1
                Loop
                sr.Close()
            End Using
            Me.dgvonelinesuper.Columns(0).HeaderText = ofd2.FileName
        End If
    End Sub

    Private Sub savetsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savetsoneliner.Click
        On Error Resume Next
        savefileoneliner()
    End Sub
    Sub savefileoneliner()
        On Error Resume Next
        Dim osd2 As New SaveFileDialog
        osd2.InitialDirectory = "c:\casparcg\mydata\songsubtitling\"
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgvonelinesuper.Rows.Count = 0 Then
                    sw.Write("")
                Else

                    Dim f As Integer = 0
                    Do Until f = dgvonelinesuper.Rows.Count

                        sw.WriteLine(dgvonelinesuper.Rows(f).Cells(0).Value & Chr(2) & dgvonelinesuper.Rows(f).Cells(1).Value & Chr(2) & dgvonelinesuper.Rows(f).Cells(2).Value & Chr(2) & dgvonelinesuper.Rows(f).Cells(3).Value & Chr(2) & dgvonelinesuper.Rows(f).Cells(4).Value & Chr(2))
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            Me.dgvonelinesuper.Columns(0).HeaderText = osd2.FileName
        End If
    End Sub

    Private Sub newtsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newtsoneliner.Click
        On Error Resume Next
        newdgvoneliner()
    End Sub
    Sub newdgvoneliner()
        On Error Resume Next
        dgvonelinesuper.Rows.Clear()
        dgvonelinesuper.Rows.Add(7)
        Me.dgvonelinesuper.Columns(0).HeaderText = "new playlist"
    End Sub

    Private Sub deletetsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletetsoneliner.Click
        On Error Resume Next
        deletecliponeliner()
    End Sub
    Sub deletecliponeliner()
        On Error Resume Next
        dgvonelinesuper.Rows.RemoveAt(dgvonelinesuper.CurrentRow.Index)
    End Sub

    Private Sub copytsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles copytsoneliner.Click
        On Error Resume Next
        copyoneliner()
    End Sub
    Sub copyoneliner()
        On Error Resume Next
        tempRow = Me.dgvonelinesuper.CurrentRow
    End Sub

    Private Sub pasteoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pasteoneliner.Click
        insertcopiedoneliner()
    End Sub

    Sub insertcopiedoneliner()
        On Error Resume Next
        Dim curRow As Integer = Me.dgvonelinesuper.CurrentCell.RowIndex
        dgvonelinesuper.Rows.Insert(dgvonelinesuper.CurrentRow.Index)
        dgvonelinesuper.CurrentCell = dgvonelinesuper.Rows(curRow).Cells(0)
        Me.dgvonelinesuper.Item(0, curRow).Value = tempRow.Cells(0).Value
        Me.dgvonelinesuper.Item(1, curRow).Value = tempRow.Cells(1).Value
    End Sub

    Private Sub downtsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles downtsoneliner.Click
        On Error Resume Next
        clipmovedownoneliner()
    End Sub
    Sub clipmovedownoneliner()
        On Error Resume Next
        If Me.dgvonelinesuper.CurrentCell.RowIndex <> dgvonelinesuper.Rows.Count - 2 Then
            Dim curRow As Integer = Me.dgvonelinesuper.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvonelinesuper.CurrentRow
            Me.dgvonelinesuper.Rows.Remove(myRow)
            Me.dgvonelinesuper.Rows.Insert(curRow + 1, myRow)
            dgvonelinesuper.CurrentCell = dgvonelinesuper.Rows(curRow + 1).Cells(0)

        End If
    End Sub

    Private Sub uptsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uptsoneliner.Click

        On Error Resume Next
        clipmoveuponeliner()
    End Sub
    Sub clipmoveuponeliner()
        On Error Resume Next
        If Me.dgvonelinesuper.CurrentCell.RowIndex <> 0 Then
            Dim curRow As Integer = Me.dgvonelinesuper.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvonelinesuper.CurrentRow
            Me.dgvonelinesuper.Rows.Remove(myRow)
            Me.dgvonelinesuper.Rows.Insert(curRow - 1, myRow)
            dgvonelinesuper.CurrentCell = dgvonelinesuper.Rows(curRow - 1).Cells(0)
        End If
    End Sub

    Private Sub addtsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addtsoneliner.Click
        On Error Resume Next
        clipinsertoneliner()
    End Sub
    Sub clipinsertoneliner()
        On Error Resume Next
        dgvonelinesuper.Rows.Insert(dgvonelinesuper.CurrentRow.Index)

    End Sub

    Private Sub removetsoneliner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removetsoneliner.Click
        On Error Resume Next
        deletecliponeliner()
    End Sub
    Private Sub rdosubtitling_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdosubtitling.CheckedChanged, rdomarking.CheckedChanged
        ikeypress = 1
    End Sub
    Private Sub cmdclearinandoutpoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclearinandoutpoint.Click
        On Error Resume Next
        For i = 0 To dgvonelinesuper.Rows.Count - 1
            dgvonelinesuper.Rows(i).Cells(1).Value = ""
            dgvonelinesuper.Rows(i).Cells(2).Value = ""
            dgvonelinesuper.Rows(i).Cells(3).Value = ""
            dgvonelinesuper.Rows(i).Cells(4).Value = ""
        Next
    End Sub



    Private Sub cmdaddtime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaddtime.Click
        For i = 0 To dgvonelinesuper.Rows.Count - 1
            dgvonelinesuper.Rows(i).Cells(1).Value = FToHMSF(Val(HMSFtoF(dgvonelinesuper.Rows(i).Cells(1).Value)) + Val(HMSFtoF(txtvtrstarttime.Text)))
            dgvonelinesuper.Rows(i).Cells(2).Value = FToHMSF(Val(HMSFtoF(dgvonelinesuper.Rows(i).Cells(2).Value)) + Val(HMSFtoF(txtvtrstarttime.Text)))

        Next
    End Sub
    Private Sub cmdsubstracttime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsubstracttime.Click
        For i = 0 To dgvonelinesuper.Rows.Count - 1
            dgvonelinesuper.Rows(i).Cells(1).Value = FToHMSF(Val(HMSFtoF(dgvonelinesuper.Rows(i).Cells(1).Value)) - Val(HMSFtoF(txtvtrstarttime.Text)))
            dgvonelinesuper.Rows(i).Cells(2).Value = FToHMSF(Val(HMSFtoF(dgvonelinesuper.Rows(i).Cells(2).Value)) - Val(HMSFtoF(txtvtrstarttime.Text)))

        Next
    End Sub

    Private Sub cmdlengthofsubtitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlengthofsubtitle.Click
        On Error Resume Next
        lengthofsubtitle()
    End Sub
    Sub lengthofsubtitle()
        On Error Resume Next
        Dim DVOTBhima As New Font("DVOT-Bhima", 10.0F, FontStyle.Bold)
        For i = 0 To dgvonelinesuper.Rows.Count - 1
            dgvonelinesuper.Rows(i).Cells(4).Value = Format((TextRenderer.MeasureText(dgvonelinesuper.Rows(i).Cells(0).Value, DVOTBhima).Width) * txtwidthmutliplicationfactor.Text, "0")
        Next
    End Sub

    Private Sub cmdtestsongsubtitling_Click(sender As System.Object, e As System.EventArgs) Handles cmdtestsongsubtitling.Click
        On Error Resume Next
        tmrstartsubtitling.Enabled = True
        playclip()
    End Sub


End Class
