Imports System.IO
Public Class ucHtmlScroller
    Dim iPauseResumeV As Integer = 0
    Private Sub cmdhidegbhtmlscroller_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Private Sub cmbfonthtmlscroll_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfonthtmlscroll.SelectedIndexChanged
        On Error Resume Next
        txtcrawlhtmlscroll.Font = New Font(cmbfonthtmlscroll.Text, frmmediaplayer.nfontsizeforall.Value)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " font('" & Replace(cmbfonthtmlscroll.Text, " ", Chr(2)) & "')")

    End Sub
    Private Sub nsizehtmlscroll_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nsizehtmlscroll.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " fontsize('" & nsizehtmlscroll.Value & "')")

    End Sub

    Private Sub nspeedhtmlscroll_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nspeedhtmlscroll.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " speed('" & nspeedhtmlscroll.Value & "')")
    End Sub

    Private Sub nyhtmlscroll_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nyhtmlscroll.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " stripy('" & nyhtmlscroll.Value & "')")
    End Sub
    Private Sub cmdcolorhtmlscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcolorhtmlscroll.Click
        On Error Resume Next

        Dim aa As New ColorDialog
        If (aa.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdcolorhtmlscroll.ForeColor = aa.Color
            cmdstripcolorhtmlscroll.ForeColor = aa.Color
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " fontcolor('" & ColorTranslator.ToHtml(cmdstripcolorhtmlscroll.ForeColor) & "')")
        End If
    End Sub

    Private Sub cmdstripcolorhtmlscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstripcolorhtmlscroll.Click
        On Error Resume Next

        Dim aa As New ColorDialog
        If (aa.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdstripcolorhtmlscroll.BackColor = aa.Color
            cmdcolorhtmlscroll.BackColor = aa.Color


            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " stripcolor('" & ColorTranslator.ToHtml(cmdstripcolorhtmlscroll.BackColor) & "')")
        End If
    End Sub
    Private Sub cmdstopcrawlhtmlscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopcrawlhtmlscroll.Click
        On Error Resume Next
        'CasparDevice.SendString("stop " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text)
        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " empty mix 20")
    End Sub


    Private Sub chkltrhtmlscroll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkltrhtmlscroll.CheckedChanged
        If chkltrhtmlscroll.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " start2()")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " start1()")
        End If
    End Sub
    Private Sub cmdfilehtmlscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfilehtmlscroll.Click
        On Error Resume Next

        ofd1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd1.InitialDirectory = "C:\casparcg\mydata\html_scroll\"
        If (ofd1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            If (ofd1.FileName <> "") Then
                Dim objFileInfo As FileInfo
                objFileInfo = New FileInfo(ofd1.FileName)

                ReadTextFile(objFileInfo.FullName, txtcrawlhtmlscroll)
            End If
        End If
    End Sub
    Private Sub pichtmlscroller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pichtmlscroller.Click
        On Error Resume Next
        Dim aa As New OpenFileDialog

        If (aa.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            pichtmlscroller.ImageLocation = aa.FileName
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " bullet('" & Replace(pichtmlscroller.ImageLocation, "\", "/") & "')")

        End If
    End Sub

    Private Sub cmdshowhtmlscroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshowhtmlscroll.Click
        On Error Resume Next
        iPauseResumeV = 0

        Dim xx As String = Replace(txtcrawlhtmlscroll.Text, vbCrLf, "")
        'xx = Replace(xx, " ", Chr(2))
        'xx = Replace(xx, "\", Chr(5))
        xx = replacestring1(xx)

        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " [HTML] " & """" & txthtmlscollerTemplate.Text & """" & " mix 40")
        'Threading.Thread.Sleep(100)
        If chkbase64htmlscroller.Checked Then
            Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(xx)
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " marqueedatabase64('" & System.Convert.ToBase64String(array) & "')")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " marqueedata('" & xx & "')")
        End If
        'Threading.Thread.Sleep(100)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " bullet('" & Replace(pichtmlscroller.ImageLocation, "\", "/") & "')")

        'Threading.Thread.Sleep(100)
        If chkltrhtmlscroll.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " start2()")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " start1()")
        End If
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " fontcolor('" & ColorTranslator.ToHtml(cmdstripcolorhtmlscroll.ForeColor) & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " stripcolor('" & ColorTranslator.ToHtml(cmdstripcolorhtmlscroll.BackColor) & "')")

        'Threading.Thread.Sleep(100)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " stripy('" & nyhtmlscroll.Value & "')")
        ' Threading.Thread.Sleep(100)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " fontsize('" & nsizehtmlscroll.Value & "')")

        'Threading.Thread.Sleep(100)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " font('" & Replace(cmbfonthtmlscroll.Text, " ", Chr(2)) & "')")

        'Threading.Thread.Sleep(100)
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " Tickery('" & nyhtmlscrollticker.Value & "')")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " speed('" & nspeedhtmlscroll.Value & "')")

    End Sub

    Private Sub nyhtmlscrollticker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nyhtmlscrollticker.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " Tickery('" & nyhtmlscrollticker.Value & "')")
    End Sub
    Sub enumeratefontsforall()
        On Error Resume Next
        Dim InstalledFonts As New Drawing.Text.InstalledFontCollection
        Dim fontfamilies() As FontFamily = InstalledFonts.Families()
        For Each fontFamily As FontFamily In fontfamilies
            cmbfonthtmlscroll.Items.Add(fontFamily.Name)
        Next
    End Sub
    Private Sub ucHtmlScroller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enumeratefontsforall()
    End Sub

    Private Sub cmdresetcropmixer_Click(sender As Object, e As EventArgs) Handles cmdresetcropmixer.Click
        resetcropmixer()
    End Sub
    Sub resetcropmixer()
        On Error Resume Next
        ncroptlx.Value = 0
        'ncroptly.Value = 0
        ncropbrx.Value = 1
        'ncropbry.Value = 1
    End Sub

    Sub mixercrop() Handles ncroptlx.ValueChanged, ncropbrx.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " crop " & Replace(ncroptlx.Value, ",", ".") & " " & Replace(0, ",", ".") & " " & Replace(ncropbrx.Value, ",", ".") & " " & Replace(1, ",", "."))
    End Sub
    Private Sub cmdupodateverticalscroll_Click(sender As Object, e As EventArgs) Handles cmdupodateverticalscroll.Click
        Finaltextforverticalscroll()
    End Sub

    Sub Finaltextforverticalscroll()
        On Error Resume Next
        Dim str As String
        If txtcrawlhtmlscroll.SelectedText = "" Then
            str = txtcrawlhtmlscroll.Text
        Else
            str = txtcrawlhtmlscroll.SelectedText
        End If

        'Dim xx As String = Replace(str, vbCrLf, "<br />")
        'xx = Replace(xx, " ", Chr(2))
        'xx = Replace(xx, "'", Chr(3))
        'xx = Replace(xx, """", Chr(4))
        'xx = Replace(xx, "\", Chr(5))
        Dim xx = replacestring1(str)

        If chkbase64htmlscroller.Checked Then

            Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(xx)
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " marqueedatabase64('" & System.Convert.ToBase64String(array) & "')")

        Else
            If chkwebutility.Checked Then
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " marqueedata('" & xx & "')")

            Else
                CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " marqueedata('" & xx & "')")

            End If
        End If
    End Sub
    Private Sub txtcrawlhtmlscroll_TextChanged(sender As Object, e As EventArgs) Handles txtcrawlhtmlscroll.TextChanged

    End Sub
    Private Sub txtcrawlhtmlscroll_DoubleClick(sender As Object, e As EventArgs) Handles txtcrawlhtmlscroll.DoubleClick
        txtcrawlhtmlscroll.SelectionStart = txtcrawlhtmlscroll.GetFirstCharIndexOfCurrentLine
        txtcrawlhtmlscroll.SelectionLength = txtcrawlhtmlscroll.Text.Length
    End Sub
    Private Sub cmdpauseresumehtmlscroller_Click(sender As Object, e As EventArgs) Handles cmdpauseresumehtmlscroller.Click
        pauseresumev()

    End Sub
    Sub pauseresumev()
        iPauseResumeV = iPauseResumeV + 1
        If iPauseResumeV = 1 Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " pause()")
        Else
            'CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " resume()")
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " speed('" & nspeedhtmlscroll.Value & "')")
            iPauseResumeV = 0
        End If
    End Sub
    Sub pauseresumeh()
        iPauseResumeV = iPauseResumeV + 1
        If iPauseResumeV = 1 Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " pause()")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " resume()")
            'CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " speed('" & nspeedhtmlscroll.Value & "')")
            iPauseResumeV = 0
        End If
    End Sub
    Sub senddata()

        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " [HTML] " & """" & txthtmlscollerTemplatevertical.Text & """")
        'Threading.Thread.Sleep(100)
        Finaltextforverticalscroll()

        If chkltrhtmlscroll.Checked Then
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " start2()")
        Else
            CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " start1()")
        End If


        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " fontcolor('" & ColorTranslator.ToHtml(cmdstripcolorhtmlscroll.ForeColor) & "')")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " font('" & Replace(cmbfonthtmlscroll.Text, " ", Chr(2)) & "')")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " fontsize('" & nsizehtmlscroll.Value & "')")

        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " speed('" & nspeedhtmlscroll.Value & "')")
    End Sub
    Private Sub cmdCueFromButtom_Click(sender As Object, e As EventArgs) Handles cmdCueFromButtom.Click
        On Error Resume Next

        iPauseResumeV = 1
        senddata()
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " pause()")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " cuefrombuttom()")

    End Sub

    Private Sub cmdCueFromMiddle_Click(sender As Object, e As EventArgs) Handles cmdCueFromMiddle.Click

        iPauseResumeV = 1
        senddata()
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " pause()")
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " cuefrommiddle()")
    End Sub
    Private Sub cmdStartFromButtom_Click(sender As Object, e As EventArgs) Handles cmdStartFromButtom.Click
        On Error Resume Next
        iPauseResumeV = 0
        senddata()
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " cuefrombuttom()")
    End Sub
    Private Sub cmdstartFromMiddle_Click(sender As Object, e As EventArgs) Handles cmdstartFromMiddle.Click
        On Error Resume Next
        iPauseResumeV = 0
        senddata()
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " cuefrommiddle()")
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        shuttleproRotate()
    End Sub
    Sub shuttleproRotate()
        On Error Resume Next
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " speed('" & TrackBar1.Value & "')")
    End Sub

    Private Sub TrackBar1_MouseUp(sender As Object, e As MouseEventArgs) Handles TrackBar1.MouseUp
        On Error Resume Next
        TrackBar1.Value = 0
        CasparDevice.SendString("call " & g_int_ChannelNumber & "-" & cmblayerhtmlscroll.Text & " speed('" & 0 & "')")

    End Sub
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
    Private Sub cmdpauseresumehtmlscrollerhorizontal_Click(sender As Object, e As EventArgs) Handles cmdpauseresumehtmlscrollerhorizontal.Click
        pauseresumeh()
    End Sub

    Private Sub cmdFlip2ndChannel_Click(sender As Object, e As EventArgs) Handles cmdFlip2ndChannel.Click
        On Error Resume Next
        CasparDevice.SendString(txtFlip2ndChannel.Text)
    End Sub
End Class
