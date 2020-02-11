Public Class ucLogo
    Private Sub cmdhidegblogo_Click(sender As Object, e As EventArgs) Handles cmdhidegblogo.Click
        Me.Hide()
    End Sub
    Private Sub cmdplaylogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplaylogo.Click
        playlogo()
    End Sub
    Sub playlogo()
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()

        CasparCGDataCollection.SetData("logofilename", Replace(piclogo.Movie, "\", "/"))
        CasparCGDataCollection.SetData("logowidth", nlogowidth.Value)
        CasparCGDataCollection.SetData("logoheight", nlogoheight.Value)
        CasparCGDataCollection.SetData("logox", nlogox.Value)
        CasparCGDataCollection.SetData("logoy", nlogoy.Value)
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbflashlayerforlogo.Text & " opacity " & Replace(nopacitylogo.Value, ",", "."))

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmbflashlayerforlogo.Text), Int(cmbflashlayerforlogo.Text), "CMP/logo/logo", True, CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
    Private Sub cmdresetlogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresetlogo.Click
        On Error Resume Next
        nlogox.Value = 592
        nlogoy.Value = 6
        nlogowidth.Value = 160
        nlogoheight.Value = 120
        nopacitylogo.Value = 1.0
    End Sub
    Private Sub nlogox_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nlogox.ValueChanged, nlogoy.ValueChanged, nlogowidth.ValueChanged, nlogoheight.ValueChanged, nopacitylogo.ValueChanged
        On Error Resume Next
        CasparCGDataCollection.SetData("logofilename", Replace(piclogo.Movie, "\", "/"))
        CasparCGDataCollection.SetData("logowidth", nlogowidth.Value)
        CasparCGDataCollection.SetData("logoheight", nlogoheight.Value)
        CasparCGDataCollection.SetData("logox", nlogox.Value)
        CasparCGDataCollection.SetData("logoy", nlogoy.Value)
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbflashlayerforlogo.Text & " opacity " & Replace(nopacitylogo.Value, ",", "."))

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmbflashlayerforlogo.Text), Int(cmbflashlayerforlogo.Text), CasparCGDataCollection)

    End Sub

    Private Sub cmdstoplogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstoplogo.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmbflashlayerforlogo.Text), Int(cmbflashlayerforlogo.Text))

    End Sub
    Private Sub cmdlogoopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogoopen.Click, piclogo.Enter
        On Error Resume Next
        picofd.InitialDirectory = "c:\casparcg\mydata\logo"
        If (picofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            piclogo.Movie = picofd.FileName
            txtlogolocation.Text = picofd.FileName
        End If
    End Sub
    Private Sub opentslogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Sub readfileforlogo(ByVal str As String)
        On Error Resume Next
        Dim i As Integer
        Dim a As Array

        a = Split(My.Computer.FileSystem.ReadAllText(str), Chr(2) + "=")
        Dim b As Array

        For i = 0 To Me.gblogo.Controls.Count - 1
            b = Split(a(i + 1), Chr(3) + Chr(3))
            Me.gblogo.Controls(i).Text = b(0)
        Next
    End Sub

    Private Sub savetslogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtlogolocation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlogolocation.TextChanged
        On Error Resume Next
        piclogo.Movie = txtlogolocation.Text
    End Sub

    Private Sub cmdvideoloopaslogo_Click(sender As Object, e As EventArgs) Handles cmdvideoloopaslogo.Click
        On Error Resume Next
        CasparDevice.SendString(txtvideoloopaslogo.Text)
    End Sub
    Private Sub stopvideoloopaslogo_Click(sender As Object, e As EventArgs) Handles stopvideoloopaslogo.Click
        On Error Resume Next
        CasparDevice.SendString(txtvideoloopaslogostop.Text)
    End Sub

    Private Sub ucLogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        piclogo.Movie = txtlogolocation.Text
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        On Error Resume Next
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = "c:\casparcg\mydata\logo\logo_list\"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            readfileforlogo(ofd2.FileName)
            lbllogofilename.Text = ofd2.FileName
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        On Error Resume Next
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "c:\casparcg\mydata\logo\logo_list\"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Dim i As Integer
            Dim a As String = ""
            For i = 0 To Me.gblogo.Controls.Count - 1
                a = a + Me.gblogo.Controls(i).Name + Chr(2) + "=" + Me.gblogo.Controls(i).Text + Chr(3) + Chr(3)
            Next
            a = a + Chr(2) + "=  "
            My.Computer.FileSystem.WriteAllText(osd2.FileName, a, False)
            lbllogofilename.Text = osd2.FileName
        End If
    End Sub

    Private Sub MenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip1.MouseHover
        MakeMenuDropDownWhenParrented(sender)
    End Sub
End Class
