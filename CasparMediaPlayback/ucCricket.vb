Imports Svt.Caspar
Imports Svt.Network
Imports System.IO

Imports System.Xml
Public Class ucCricket
    Private Sub NG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        opendefaultbatmandata()
        opendefaultdatabowler()
        dgvFOW.Rows.Add(1)
    End Sub
    Private Sub gamelogoforgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gamelogo.Click
        On Error Resume Next
        openimage("C:\casparcg\mydata\games\games logo\", sender)
    End Sub
    Private Sub eventlogoforgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eventlogo.Click
        On Error Resume Next
        openimage("C:\casparcg\mydata\games\event logo\", sender)
    End Sub
    Private Sub cmdstopgym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopgym.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation2()

        Threading.Thread.Sleep(200)
        CasparDevice.SendString("stop " & g_int_ChannelNumber & "-" & cmblayergames.Text)

        Threading.Thread.Sleep(1000)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Sub animation1()
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill -1 0 1 1")
    End Sub
    Sub animationtoscreen()
        On Error Resume Next
        If chkanimationforhdvan.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill .1 0 .8 1 50 easeoutexpo")
        Else
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill 0 0 1 1 50 easeoutexpo")
        End If
    End Sub
    Sub animation2()
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " fill 1 0 1 1 50 easeoutexpo")
    End Sub

    Private Sub cmdeventid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeventid.Click

        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/event_id/gwd_preview_event_id/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(cmbHeader.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(cmbSubHeader.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(gamelogo.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")
        If chkanimationzym.Checked Then animationtoscreen()

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
    Function openimage(ByVal defaultdirectory As String, ByVal picname As PictureBox)
        On Error Resume Next
        Dim picofd As New OpenFileDialog
        picofd.InitialDirectory = defaultdirectory
        If (picofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            picname.ImageLocation = picofd.FileName
        End If
        Return Split(picofd.SafeFileName, ".")(0)
    End Function
    Private Sub cmdstartclockball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tmrtimeonform.Enabled = True
        aa = Val(Now.Second.ToString) 'new code
    End Sub
    Dim aa As Integer 'new code

    Private Sub cmdpauseclockball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tmrtimeonform.Enabled = False
    End Sub
    Private Sub cmdstopscoreball_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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



    Sub showtemplate(ByVal templatename As String, ByVal datacollection As String)
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayergames.Text), Int(cmblayergames.Text), templatename, True, datacollection)
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private counter As Integer
    Private Sub cmdrun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrun.Click
        On Error Resume Next
        txtrun.Text = txtrun.Text + 1
        cmbinfo.Text = ""
        txtinfo.Text = ""
        dgvbatsman.Rows(strkingplayer).Cells(2).Value = Val(dgvbatsman.Rows(strkingplayer).Cells(2).Value) + 1
        dgvbowler.Rows(bowler).Cells(3).Value = Val(dgvbowler.Rows(bowler).Cells(3).Value) + 1
    End Sub
    Private Sub cmdwicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdwicket.Click
        On Error Resume Next
        txtwicket.Text = txtwicket.Text + 1
        cmbinfo.Text = ""
        txtinfo.Text = ""

        dgvbatsman.Rows(strkingplayer).Cells(1).Value = "Out"

        dgvbowler.Rows(bowler).Cells(4).Value = Val(dgvbowler.Rows(bowler).Cells(4).Value) + 1

        Dim dd As Integer = Int(Val(txtwicket.Text))
        dgvFOW.Rows(0).Cells(dd - 1).Value = txtwicket.Text & "/" & txtrun.Text
    End Sub

    Private Sub cmdover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdover.Click
        On Error Resume Next
        Dim z As Integer
        Dim x, y As Double
        txtover.Text = Val(txtover.Text) + 0.1
        y = System.Math.Round(Val(txtover.Text), 0)
        x = Val(txtover.Text)
        z = 10 * (y - x)
        If z = 4 Then txtover.Text = y
        cmbinfo.Text = ""
        txtinfo.Text = ""

        dgvbatsman.Rows(strkingplayer).Cells(3).Value = Val(dgvbatsman.Rows(strkingplayer).Cells(3).Value) + 1

        dgvbowler.Rows(bowler).Cells(1).Value = Val(dgvbowler.Rows(bowler).Cells(1).Value) + 0.1
        If Val(dgvbowler.Rows(bowler).Cells(1).Value) - Int(Val(dgvbowler.Rows(bowler).Cells(1).Value)) > 0.5 Then
            dgvbowler.Rows(bowler).Cells(1).Value = Int(Val(dgvbowler.Rows(bowler).Cells(1).Value)) + 1
        End If
    End Sub

    Private Sub cmdscore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscore.Click
        On Error Resume Next

        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/cricket_bottom_score/gwd_preview_cricket_bottom_score/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(txtteamname.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txtrun.Text + "/" + txtwicket.Text + "(" + txtover.Text + ")") & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(cmbinfo.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(txtinfo.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict1logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdscoreupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscoreupdate.Click
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(txtteamname.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txtrun.Text + "/" + txtwicket.Text + "(" + txtover.Text + ")") & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(cmbinfo.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(txtinfo.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict1logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")

    End Sub
    Private Sub cmdscore1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscore1.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/cricket_bottom_score/gwd_preview_cricket_bottom_score/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(txtteamname.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txtrun.Text + "/" + txtwicket.Text + "(" + txtover.Text + ")") & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(cmbinfo1.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(txtinfo1.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict1logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdscore1update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscore1update.Click
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(txtteamname.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txtrun.Text + "/" + txtwicket.Text + "(" + txtover.Text + ")") & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(cmbinfo1.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(txtinfo1.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict1logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")
    End Sub
    Private Sub cmdscore2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscore2.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/cricket_bottom_score/gwd_preview_cricket_bottom_score/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(txtteamname.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txtrun.Text + "/" + txtwicket.Text + "(" + txtover.Text + ")") & "')")

        If chkStrinkingPostionA.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(cmbinfo2.Text & "*") & "')")

        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(cmbinfo2.Text) & "')")

        End If
        If chkStrinkingPostionB.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(txtinfo2.Text & "*") & "')")

        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(txtinfo2.Text) & "')")

        End If

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict1logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdscore2update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdscore2update.Click

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(txtteamname.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txtrun.Text + "/" + txtwicket.Text + "(" + txtover.Text + ")") & "')")

        If chkStrinkingPostionA.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(cmbinfo2.Text & "*") & "')")

        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(cmbinfo2.Text) & "')")

        End If
        If chkStrinkingPostionB.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(txtinfo2.Text & "*") & "')")

        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(txtinfo2.Text) & "')")

        End If

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict1logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")

    End Sub

    Private Sub cmdcleardatabowlerstatics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcleardatabowlerstatics.Click
        On Error Resume Next
        For i = 0 To dgvbowler.RowCount - 1
            For j = 1 To dgvbowler.ColumnCount - 1
                dgvbowler.Rows(i).Cells(j).Value = ""
            Next
        Next
        txtnb.Text = ""
        txtwd.Text = ""
        txtlb.Text = ""
        txtby.Text = ""
        txttotalextra.Text = ""
        dgvFOW.Rows.Clear()
        dgvFOW.Rows.Add()

    End Sub

    Private Sub cmdplayeridbatsman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayeridbatsman.Click
        On Error Resume Next

        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/player_id/gwd_preview_player_id/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(dgvbatsman.CurrentRow.Cells(0).Value) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txtteamnamea.Text) & "')")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict1logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")

        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayergames.Text & " opacity 1")
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdbatsmanstatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbatsmanstatus.Click
        On Error Resume Next

        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/batsman_status/gwd_preview_batsman_status/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(dgvbatsman.CurrentRow.Cells(0).Value) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(dgvbatsman.CurrentRow.Cells(1).Value) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(dgvbatsman.CurrentRow.Cells(2).Value) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(dgvbatsman.CurrentRow.Cells(3).Value) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf4") & "','" & replacestring(txtteamnamea.Text) & "')")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict1logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdplayeridbowler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayeridbowler.Click
        On Error Resume Next

        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/player_id/gwd_preview_player_id/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(dgvbowler.CurrentRow.Cells(0).Value) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txtteamnameb.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict2logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdbowlerstatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbowlerstatus.Click
        On Error Resume Next

        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/bowler_status/gwd_preview_bowler_status/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(dgvbowler.CurrentRow.Cells(0).Value) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(dgvbowler.CurrentRow.Cells(1).Value) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(dgvbowler.CurrentRow.Cells(2).Value) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(dgvbowler.CurrentRow.Cells(3).Value) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf4") & "','" & replacestring(dgvbowler.CurrentRow.Cells(4).Value) & "')")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf5") & "','" & replacestring(txtteamnameb.Text) & "')")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict2logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdteama_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteamlinupbatsman.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/teamlineup/gwd_preview_teamlineup/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        For i = 0 To 11
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & ("ccgf" & i) & "','" & replacestring(dgvbatsman.Rows(i).Cells(0).Value) & "')")
        Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf12") & "','" & replacestring(txtteamnamea.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict1logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdbattingcarda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbattingcard.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/batting_card1/gwd_preview_batting_card1/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        For i = 0 To 10
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & ("ccgf" & i) & "','" & replacestring(dgvbatsman.Rows(i).Cells(0).Value) & "')")
        Next
        For i = 11 To 21
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & ("ccgf" & i) & "','" & replacestring(dgvbatsman.Rows(i - 11).Cells(1).Value) & "')")
        Next
        For i = 22 To 32
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & ("ccgf" & i) & "','" & replacestring(dgvbatsman.Rows(i - 22).Cells(2).Value) & "')")
        Next
        For i = 33 To 43
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & ("ccgf" & i) & "','" & replacestring(dgvbatsman.Rows(i - 33).Cells(3).Value) & "')")
        Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf44") & "','" & replacestring(txtoversbatman.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf45") & "','" & replacestring(txtoversbatmanvalue.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf46") & "','" & replacestring(txtextrabatman.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf47") & "','" & replacestring(txtextrabatmanvalue.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf48") & "','" & replacestring(txttotalbatsman.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf49") & "','" & replacestring(txttotalbatsmanvalue.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf50") & "','" & replacestring(txtteamnamea.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf51") & "','" & replacestring(txttotalbatsman.Text) & "')")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict2logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdteamb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdteamlinupbowler.Click
        On Error Resume Next

        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/teamlineup/gwd_preview_teamlineup/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        For i = 0 To 11
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & ("ccgf" & i) & "','" & replacestring(dgvbowler.Rows(i).Cells(0).Value) & "')")
        Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf12") & "','" & replacestring(txtteamnameb.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict2logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub
    Private Sub cmdbowlingcard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbowlingcard.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/bowling_card/gwd_preview_bowling_card/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & ("ccgf0") & "','" & replacestring(txtteamnameb.Text) & "')")
        For i = 0 To 7
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & ("ccgf" & i + 1) & "','" & replacestring(dgvbowler.Rows(i).Cells(0).Value) & "')")
        Next

        For i = 8 To 15
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & ("ccgf" & i + 1) & "','" & replacestring(dgvbowler.Rows(i - 8).Cells(1).Value) & "')")
        Next

        For i = 16 To 23
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & ("ccgf" & i + 1) & "','" & replacestring(dgvbowler.Rows(i - 16).Cells(2).Value) & "')")
        Next

        For i = 24 To 31
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & ("ccgf" & i + 1) & "','" & replacestring(dgvbowler.Rows(i - 24).Cells(3).Value) & "')")
        Next

        For i = 32 To 39
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & ("ccgf" & i + 1) & "','" & replacestring(dgvbowler.Rows(i - 32).Cells(4).Value) & "')")
        Next

        For i = 0 To 9
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & ("ccgf" & 41 + i) & "','" & replacestring(dgvFOW.Rows(0).Cells(i).Value) & "')")
        Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf51") & "','" & replacestring(txtnb.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf52") & "','" & replacestring(txtwd.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf53") & "','" & replacestring(txtlb.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf54") & "','" & replacestring(txtby.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf55") & "','" & replacestring(txttotalextra.Text) & "')")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict2logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub Cricket_Click(sender As System.Object, e As System.EventArgs) Handles Cricket.Click

    End Sub

    Private Sub newdatabowler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newdatabowler.Click
        On Error Resume Next
        dgvbowler.Rows.Clear()
        dgvbowler.Rows.Add(11)
        lblfilenamebowler.Text = "new"
    End Sub

    Private Sub tsopendatabowler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsopendatabowler.Click
        On Error Resume Next
        dgvbowler.Focus()
        opendatabowler()
    End Sub

    Private Sub tssavedatabowler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssavedatabowler.Click
        On Error Resume Next
        savedatabowler()
    End Sub

    Private Sub cmdrowupbowler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowupbowler.Click
        On Error Resume Next
        If Me.dgvbowler.CurrentCell.RowIndex <> 0 Then
            Dim curRow As Integer = Me.dgvbowler.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvbowler.CurrentRow
            Me.dgvbowler.Rows.Remove(myRow)
            Me.dgvbowler.Rows.Insert(curRow - 1, myRow)
            dgvbowler.CurrentCell = dgvbowler.Rows(curRow - 1).Cells(0)
        End If
    End Sub
    Private Sub cmdrowdownbowler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowdownbowler.Click
        On Error Resume Next
        If Me.dgvbowler.CurrentCell.RowIndex <> dgvbowler.Rows.Count - 2 Then
            Dim curRow As Integer = Me.dgvbowler.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvbowler.CurrentRow
            Me.dgvbowler.Rows.Remove(myRow)
            Me.dgvbowler.Rows.Insert(curRow + 1, myRow)
            dgvbowler.CurrentCell = dgvbowler.Rows(curRow + 1).Cells(0)
        End If
    End Sub

    Private Sub cmdrowinsertbowler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowinsertbowler.Click
        On Error Resume Next
        dgvbowler.Rows.Insert(dgvbowler.CurrentRow.Index)
    End Sub

    Private Sub cmdrowdeletebowler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowdeletebowler.Click
        On Error Resume Next
        dgvbowler.Rows.RemoveAt(dgvbowler.CurrentRow.Index)
    End Sub

    Private Sub openbatsmandata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openbatsmandata.Click
        On Error Resume Next
        dgvbatsman.Focus()
        opendatabatsman()
    End Sub

    Private Sub savebatsmandata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savebatsmandata.Click
        On Error Resume Next
        savedatabatsman()
    End Sub

    Private Sub cmdrowupbatsman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowupbatsman.Click
        On Error Resume Next
        If Me.dgvbatsman.CurrentCell.RowIndex <> 0 Then
            Dim curRow As Integer = Me.dgvbatsman.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvbatsman.CurrentRow
            Me.dgvbatsman.Rows.Remove(myRow)
            Me.dgvbatsman.Rows.Insert(curRow - 1, myRow)
            dgvbatsman.CurrentCell = dgvbatsman.Rows(curRow - 1).Cells(0)
        End If
    End Sub

    Private Sub cmdrowdownbatsman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowdownbatsman.Click
        On Error Resume Next
        If Me.dgvbatsman.CurrentCell.RowIndex <> dgvbatsman.Rows.Count - 2 Then
            Dim curRow As Integer = Me.dgvbatsman.CurrentCell.RowIndex
            Dim myRow As DataGridViewRow = Me.dgvbatsman.CurrentRow
            Me.dgvbatsman.Rows.Remove(myRow)
            Me.dgvbatsman.Rows.Insert(curRow + 1, myRow)
            dgvbatsman.CurrentCell = dgvbatsman.Rows(curRow + 1).Cells(0)
        End If
    End Sub

    Private Sub cmdrowinsertbatsman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowinsertbatsman.Click
        On Error Resume Next
        dgvbatsman.Rows.Insert(dgvbatsman.CurrentRow.Index)
    End Sub

    Private Sub cmdrowdeletebatsman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrowdeletebatsman.Click
        On Error Resume Next
        dgvbatsman.Rows.RemoveAt(dgvbatsman.CurrentRow.Index)
    End Sub

    Private Sub opendatabatsman()
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog
        ofd2.InitialDirectory = "c:\casparcg\mydata\games\cricket\"
        ofd2.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then

            Dim response As New MSXML2.DOMDocument60
            response.load(ofd2.FileName)
            dgvbatsman.Rows.Clear()

            Dim i As Integer = 0
            For Each instance As MSXML2.IXMLDOMElement In response.getElementsByTagName("player")
                dgvbatsman.Rows.Add()
                dgvbatsman.Rows(i).Cells(0).Value = instance.getAttribute("name")
                dgvbatsman.Rows(i).Cells(1).Value = instance.getAttribute("status")
                dgvbatsman.Rows(i).Cells(2).Value = instance.getAttribute("runs")
                dgvbatsman.Rows(i).Cells(3).Value = instance.getAttribute("balls")

                i = i + 1
            Next

            lblfilenamebatsman.Text = ofd2.FileName
        End If
    End Sub

    Sub opendefaultbatmandata()
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog
        ofd2.FileName = "c:\casparcg\mydata\games\cricket\dyp_a.xml"
        Dim response As New MSXML2.DOMDocument60
        response.load(ofd2.FileName)
        dgvbatsman.Rows.Clear()

        Dim i As Integer = 0
        For Each instance As MSXML2.IXMLDOMElement In response.getElementsByTagName("player")
            dgvbatsman.Rows.Add()
            dgvbatsman.Rows(i).Cells(0).Value = instance.getAttribute("name")
            dgvbatsman.Rows(i).Cells(1).Value = instance.getAttribute("status")
            dgvbatsman.Rows(i).Cells(2).Value = instance.getAttribute("runs")
            dgvbatsman.Rows(i).Cells(3).Value = instance.getAttribute("balls")

            i = i + 1
        Next

        lblfilenamebatsman.Text = ofd2.FileName

    End Sub

    Sub savedatabatsman()
        On Error Resume Next
        Dim osd2 As New SaveFileDialog
        osd2.InitialDirectory = "c:\casparcg\mydata\games\cricket\"
        osd2.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            For i = 0 To dgvbatsman.RowCount - 1
                For j = 0 To dgvbatsman.ColumnCount - 1
                    If dgvbatsman.Rows(i).Cells(j).Value = "" Then dgvbatsman.Rows(i).Cells(j).Value = " "
                Next
            Next
            Dim xmlsetting As New XmlWriterSettings
            xmlsetting.Indent = True
            Using writer As XmlWriter = XmlWriter.Create(osd2.FileName, xmlsetting)

                writer.WriteStartDocument()

                writer.WriteStartElement("batsmandata") ' Root.

                For i = 0 To dgvbatsman.Rows.Count - 1
                    If dgvbatsman.Rows(i).Cells(0).Value = vbNullString Then Exit For
                    writer.WriteStartElement("player")
                    writer.WriteStartAttribute("name")
                    writer.WriteValue(dgvbatsman.Rows(i).Cells(0).Value.ToString)
                    writer.WriteStartAttribute("status")
                    writer.WriteValue(dgvbatsman.Rows(i).Cells(1).Value.ToString)
                    writer.WriteStartAttribute("runs")
                    writer.WriteValue(dgvbatsman.Rows(i).Cells(2).Value.ToString)
                    writer.WriteStartAttribute("balls")
                    writer.WriteValue(dgvbatsman.Rows(i).Cells(3).Value.ToString)
                    writer.WriteEndAttribute()
                    writer.WriteEndElement()
                Next

                writer.WriteEndElement()

                writer.WriteEndDocument()
            End Using
            lblfilenamebatsman.Text = osd2.FileName
        End If
    End Sub

    Private Sub opendatabowler()
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog
        ofd2.InitialDirectory = "c:\casparcg\mydata\games\cricket\"
        ofd2.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then

            Dim response As New MSXML2.DOMDocument60
            response.load(ofd2.FileName)
            dgvbowler.Rows.Clear()

            Dim i As Integer = 0
            For Each instance As MSXML2.IXMLDOMElement In response.getElementsByTagName("player")
                dgvbowler.Rows.Add()
                dgvbowler.Rows(i).Cells(0).Value = instance.getAttribute("name")
                dgvbowler.Rows(i).Cells(1).Value = instance.getAttribute("o")
                dgvbowler.Rows(i).Cells(2).Value = instance.getAttribute("m")
                dgvbowler.Rows(i).Cells(3).Value = instance.getAttribute("r")
                dgvbowler.Rows(i).Cells(4).Value = instance.getAttribute("w")
                i = i + 1
            Next

            lblfilenamebowler.Text = ofd2.FileName
        End If
    End Sub

    Sub opendefaultdatabowler()
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog
        ofd2.FileName = "c:\casparcg\mydata\games\cricket\ongc.xml"
        Dim response As New MSXML2.DOMDocument60
        response.load(ofd2.FileName)
        dgvbowler.Rows.Clear()

        Dim i As Integer = 0
        For Each instance As MSXML2.IXMLDOMElement In response.getElementsByTagName("player")
            dgvbowler.Rows.Add()
            dgvbowler.Rows(i).Cells(0).Value = instance.getAttribute("name")
            dgvbowler.Rows(i).Cells(1).Value = instance.getAttribute("o")
            dgvbowler.Rows(i).Cells(2).Value = instance.getAttribute("m")
            dgvbowler.Rows(i).Cells(3).Value = instance.getAttribute("r")
            dgvbowler.Rows(i).Cells(4).Value = instance.getAttribute("w")
            i = i + 1
        Next

        lblfilenamebowler.Text = ofd2.FileName

    End Sub
    Sub savedatabowler()
        On Error Resume Next
        Dim osd2 As New SaveFileDialog
        osd2.InitialDirectory = "c:\casparcg\mydata\games\cricket\"
        osd2.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            For i = 0 To dgvbowler.RowCount - 1
                For j = 0 To dgvbowler.ColumnCount - 1
                    If dgvbowler.Rows(i).Cells(j).Value = "" Then dgvbowler.Rows(i).Cells(j).Value = " "
                Next
            Next
            Dim xmlsetting As New XmlWriterSettings
            xmlsetting.Indent = True
            Using writer As XmlWriter = XmlWriter.Create(osd2.FileName, xmlsetting)

                writer.WriteStartDocument()

                writer.WriteStartElement("bowlerdata") ' Root.

                For i = 0 To dgvbowler.Rows.Count - 1
                    If dgvbowler.Rows(i).Cells(0).Value = vbNullString Then Exit For
                    writer.WriteStartElement("player")
                    writer.WriteStartAttribute("name")
                    writer.WriteValue(dgvbowler.Rows(i).Cells(0).Value.ToString)
                    writer.WriteStartAttribute("o")
                    writer.WriteValue(dgvbowler.Rows(i).Cells(1).Value.ToString)
                    writer.WriteStartAttribute("m")
                    writer.WriteValue(dgvbowler.Rows(i).Cells(2).Value.ToString)
                    writer.WriteStartAttribute("r")
                    writer.WriteValue(dgvbowler.Rows(i).Cells(3).Value.ToString)
                    writer.WriteStartAttribute("w")
                    writer.WriteValue(dgvbowler.Rows(i).Cells(4).Value.ToString)
                    writer.WriteEndAttribute()
                    writer.WriteEndElement()
                Next

                writer.WriteEndElement()

                writer.WriteEndDocument()
            End Using
            lblfilenamebowler.Text = osd2.FileName
        End If
    End Sub


    Private Sub cmdclearbatsmanstatics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclearbatsmanstatics.Click
        For i = 0 To dgvbatsman.RowCount - 1
            For j = 1 To dgvbatsman.ColumnCount - 1
                dgvbatsman.Rows(i).Cells(j).Value = ""
            Next
        Next
        txtoversbatmanvalue.Text = ""
        txtextrabatmanvalue.Text = ""
        txttotalbatsmanvalue.Text = ""

    End Sub
    Private Sub cmbinfo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbinfo.SelectedIndexChanged
        On Error Resume Next
        Dim overs_remaining As Double
        Dim balls_remaining As Double
        Dim Wickets_At_Hand As Integer
        Dim to_win As Integer
        Dim target As Integer
        Dim Run_Rate As Double
        Dim Required_Run_Rate As Double
        Dim balls_delivered As Integer
        Dim total_balls As Integer

        balls_delivered = Int(txtover.Text) * 6 + (txtover.Text - Int(txtover.Text)) * 10
        total_balls = Int(txtmatchover.Text) * 6 + (txtmatchover.Text - Int(txtmatchover.Text)) * 10
        overs_remaining = Int((Val(txtmatchover.Text) * 6 - Int(Val(txtover.Text)) * 6 - 10 * (Val(txtover.Text) - Int(Val(txtover.Text)))) / 6) + ((Val(txtmatchover.Text) * 6 - Int(Val(txtover.Text)) * 6 - 10 * (Val(txtover.Text) - Int(Val(txtover.Text)))) - 6 * Int((Val(txtmatchover.Text) * 6 - Int(Val(txtover.Text)) * 6 - 10 * (Val(txtover.Text) - Int(Val(txtover.Text)))) / 6)) / 10
        balls_remaining = total_balls - balls_delivered ' Int(overs_remaining) * 6 + (overs_remaining - Int(overs_remaining)) * 10
        Wickets_At_Hand = 10 - Val(txtwicket.Text)
        to_win = Val(txt1stinningscore.Text) - Val(txtrun.Text) + 1
        target = txt1stinningscore.Text + 1
        Run_Rate = System.Math.Round(Val(txtrun.Text) * 6 / balls_delivered, 2)
        Required_Run_Rate = System.Math.Round((Val(txt1stinningscore.Text) - Val(txtrun.Text) + 1) * 6 / balls_remaining, 2)

        If cmbinfo.Text = "Overs Remaining" Then txtinfo.Text = overs_remaining
        If cmbinfo.Text = "Balls Remaining" Then txtinfo.Text = balls_remaining
        If cmbinfo.Text = "Wickets At Hand" Then txtinfo.Text = Wickets_At_Hand
        If cmbinfo.Text = "To Win" Then txtinfo.Text = to_win
        If cmbinfo.Text = "Target" Then txtinfo.Text = target
        If cmbinfo.Text = "Run Rate" Then txtinfo.Text = Run_Rate
        If cmbinfo.Text = "Required Run Rate" Then txtinfo.Text = Required_Run_Rate
        If cmbinfo.Text = "" Then txtinfo.Text = ""

        If cmbinfo.Text = "This Over" Then txtinfo.Text = txtthisover.Text
        If cmbinfo.Text = "Free Hit" Then txtinfo.Text = ""
        If cmbinfo.Text = "Last Wicket At" Then txtinfo.Text = txtlastwicketat.Text
        If cmbinfo.Text = "Equation" Then

            txtinfo.Text = to_win & " Runs Required in /" & balls_remaining & " Balls"

        End If
    End Sub
    Private Sub pict1logocricket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pict1logocricket.Click
        On Error Resume Next
        openimage("C:\casparcg\mydata\games\Team_Logo\", sender)
    End Sub

    Private Sub pict2logocricket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pict2logocricket.Click
        On Error Resume Next
        openimage("C:\casparcg\mydata\games\Team_Logo\", sender)
    End Sub

    Private Sub txtrun_TextChanged(sender As Object, e As EventArgs) Handles txtrun.TextChanged, txtwicket.TextChanged
        txttotalbatsmanvalue.Text = txtrun.Text & "/" & txtwicket.Text
    End Sub

    Private Sub txtover_TextChanged(sender As Object, e As EventArgs) Handles txtover.TextChanged
        txtoversbatmanvalue.Text = txtover.Text
    End Sub

    Private Sub newbatmandata_Click(sender As Object, e As EventArgs) Handles newbatmandata.Click
        On Error Resume Next
        dgvbatsman.Rows.Clear()
        dgvbatsman.Rows.Add(11)
        lblfilenamebatsman.Text = "new"
    End Sub
    Private Sub cmdcleardatascore_Click(sender As Object, e As EventArgs) Handles cmdcleardatascore.Click
        txtrun.Text = 0
        txtwicket.Text = 0
        txtover.Text = 0
    End Sub

    Private Sub dgvbatsman_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbatsman.CellContentClick
        ' cmbinfo2.Text =
    End Sub
    Dim info2placement As Integer = 1
    Private Sub dgvbatsman_DoubleClick(sender As Object, e As EventArgs) Handles dgvbatsman.DoubleClick
        On Error Resume Next
        If info2placement = 1 Then
            cmbinfo2.Text = dgvbatsman.CurrentRow.Cells(0).Value & " " & dgvbatsman.CurrentRow.Cells(2).Value
        Else
            txtinfo2.Text = dgvbatsman.CurrentRow.Cells(0).Value & " " & dgvbatsman.CurrentRow.Cells(2).Value
        End If
        info2placement = info2placement + 1
        If info2placement > 2 Then info2placement = 1

    End Sub
    Dim strkingplayer As Integer = 0

    Private Sub rdoP0_CheckedChanged(sender As Object, e As EventArgs) Handles rdoP0.CheckedChanged, rdoP1.CheckedChanged, rdoP2.CheckedChanged, rdoP3.CheckedChanged, rdoP4.CheckedChanged, rdoP5.CheckedChanged, rdoP6.CheckedChanged, rdoP7.CheckedChanged, rdoP8.CheckedChanged, rdoP9.CheckedChanged, rdoP10.CheckedChanged, rdoP11.CheckedChanged
        On Error Resume Next
        strkingplayer = sender.tag
        txtinfo4.Text = dgvbatsman.Rows(strkingplayer).Cells(0).Value
    End Sub

    Dim bowler As Integer = 0
    Private Sub rdoB0_CheckedChanged(sender As Object, e As EventArgs) Handles rdoB0.CheckedChanged, rdoB1.CheckedChanged, rdoB2.CheckedChanged, rdoB3.CheckedChanged, rdoB4.CheckedChanged, rdoB5.CheckedChanged, rdoB6.CheckedChanged, rdoB7.CheckedChanged, rdoB8.CheckedChanged, rdoB9.CheckedChanged, rdoB10.CheckedChanged, rdoB11.CheckedChanged
        On Error Resume Next
        bowler = sender.tag
        txtinfo5.Text = dgvbowler.Rows(bowler).Cells(0).Value
    End Sub

    Private Sub txtnb_TextChanged(sender As Object, e As EventArgs) Handles txtnb.TextChanged, txtwd.TextChanged, txtlb.TextChanged, txtby.TextChanged
        On Error Resume Next
        txttotalextra.Text = Val(txtnb.Text) + Val(txtwd.Text) + Val(txtlb.Text) + Val(txtby.Text)

        txtextrabatmanvalue.Text = txttotalextra.Text
    End Sub

    Private Sub cmdscore3_Click(sender As Object, e As EventArgs) Handles cmdscore3.Click

        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/cricket_bottom_score/gwd_preview_cricket_bottom_score/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(txtteamname.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txtrun.Text + "/" + txtwicket.Text + "(" + txtover.Text + ")") & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(cmbinfo3.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(txtinfo3.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict1logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdscore3update_Click(sender As Object, e As EventArgs) Handles cmdscore3update.Click
        On Error Resume Next

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(txtteamname.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txtrun.Text + "/" + txtwicket.Text + "(" + txtover.Text + ")") & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(cmbinfo3.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(txtinfo3.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict1logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")
    End Sub

    Private Sub cmdscore4_Click(sender As Object, e As EventArgs) Handles cmdscore4.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/cricket_bottom_score/gwd_preview_cricket_bottom_score/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(txtteamname.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txtrun.Text + "/" + txtwicket.Text + "(" + txtover.Text + ")") & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(cmbinfo4.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(txtinfo4.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict1logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdscore4update_Click(sender As Object, e As EventArgs) Handles cmdscore4update.Click
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(txtteamname.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txtrun.Text + "/" + txtwicket.Text + "(" + txtover.Text + ")") & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(cmbinfo4.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(txtinfo4.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict1logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")

    End Sub

    Private Sub cmdscore5_Click(sender As Object, e As EventArgs) Handles cmdscore5.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/cricket_bottom_score/gwd_preview_cricket_bottom_score/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(txtteamname.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txtrun.Text + "/" + txtwicket.Text + "(" + txtover.Text + ")") & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(cmbinfo5.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(txtinfo5.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict1logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdscore5update_Click(sender As Object, e As EventArgs) Handles cmdscore5update.Click
        On Error Resume Next

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(txtteamname.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txtrun.Text + "/" + txtwicket.Text + "(" + txtover.Text + ")") & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(cmbinfo5.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(txtinfo5.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict1logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")

    End Sub


    Private Sub cmdscore6_Click(sender As Object, e As EventArgs) Handles cmdscore6.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/cricket_bottom_score/gwd_preview_cricket_bottom_score/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(txtteamname.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txtrun.Text + "/" + txtwicket.Text + "(" + txtover.Text + ")") & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(cmbinfo6.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(txtinfo6.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict1logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub
    Private Sub cmdscore6update_Click(sender As Object, e As EventArgs) Handles cmdscore6update.Click
        On Error Resume Next


        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(txtteamname.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txtrun.Text + "/" + txtwicket.Text + "(" + txtover.Text + ")") & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(cmbinfo6.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(txtinfo6.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict1logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")

    End Sub


    Private Sub cmdscore7_Click(sender As Object, e As EventArgs) Handles cmdscore7.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/cricket_bottom_score/gwd_preview_cricket_bottom_score/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(txtteamname.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txtrun.Text + "/" + txtwicket.Text + "(" + txtover.Text + ")") & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(cmbinfo7.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(txtinfo7.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict1logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub
    Private Sub cmdscore7update_Click(sender As Object, e As EventArgs) Handles cmdscore7update.Click
        On Error Resume Next

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(txtteamname.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txtrun.Text + "/" + txtwicket.Text + "(" + txtover.Text + ")") & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(cmbinfo7.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf3") & "','" & replacestring(txtinfo7.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage1") & "','" & replacestring(Replace(pict1logocricket.ImageLocation, "\", "/")) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updateimage('" & replacestring("ccgimage2") & "','" & replacestring(Replace(eventlogo.ImageLocation, "\", "/")) & "')")

    End Sub
    Function replacestring(str As String) As String
        str = Replace(str, vbCrLf, "<br />")
        str = Replace(str, " ", "xxx")
        str = Replace(str, "'", "yyy")
        str = Replace(str, """", "zzz")
        Return str
    End Function
    Private Sub cmdonliner_Click(sender As Object, e As EventArgs) Handles cmdonliner.Click
        On Error Resume Next

        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/1line/gwd_preview_1line/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(txtoneliner.Text) & "')")
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmdtwoliner_Click(sender As Object, e As EventArgs) Handles cmdtwoliner.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/2line/gwd_preview_2line/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(txttwoliner1.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txttwoliner2.Text) & "')")
        If chkanimationzym.Checked Then animationtoscreen()
    End Sub

    Private Sub cmd3liner_Click(sender As Object, e As EventArgs) Handles cmd3liner.Click
        On Error Resume Next
        If chkanimationzym.Checked Then animation1()
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayergames.Text & " [html] c:/casparcg/CMP/games/HtmlCricket/3line/gwd_preview_3line/index.html")
        Threading.Thread.Sleep(Val(txthtmlupdateDelay.Text))
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf0") & "','" & replacestring(txt3liner1.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf1") & "','" & replacestring(txt3liner2.Text) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayergames.Text & " updatestring('" & replacestring("ccgf2") & "','" & replacestring(txt3liner3.Text) & "')")
        If chkanimationzym.Checked Then animationtoscreen()

    End Sub

    Private Sub cmdaddoutput_Click(sender As Object, e As EventArgs) Handles cmdaddoutput.Click
        On Error Resume Next

        CasparDevice.SendString("add " & g_int_ChannelNumber & " decklink 1 " & "embedded_audio")
        CasparDevice.SendString("add " & g_int_ChannelNumber & " bluefish 1 " & "embedded_audio")

        CasparDevice.SendString("add " & g_int_ChannelNumber & " decklink 2 " & "key_only") ' for key
        CasparDevice.SendString("add " & g_int_ChannelNumber & " bluefish 2 " & "key_only") ' for key
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

    Private Sub Cmdhide_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
End Class