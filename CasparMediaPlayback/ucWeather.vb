
Public Class ucWeather
    Private Sub weathericon4_Enter(sender As Object, e As EventArgs) Handles weathericon4.Enter

    End Sub
    Private Sub weathericon3_Enter(sender As Object, e As EventArgs) Handles weathericon3.Enter

    End Sub
    Private Sub weathericon2_Enter(sender As Object, e As EventArgs) Handles weathericon2.Enter

    End Sub
    Private Sub weathericon1_Enter(sender As Object, e As EventArgs) Handles weathericon1.Enter

    End Sub

    Private Sub cmdhideweather_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Private Sub ucWeather_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'for weather starts
        enumweathericons()
        'fro weather ends
    End Sub
    Sub enumweathericons()
        On Error Resume Next

        Me.cmbweathericon1.Items.Clear()
        Me.cmbweathericon2.Items.Clear()
        Me.cmbweathericon3.Items.Clear()
        Me.cmbweathericon4.Items.Clear()

        For Each Filefound As String In IO.Directory.GetFiles("c:/casparcg/mydata/weather", "*.*")
            Dim stringtocut As Integer = 28
            Dim filefound1 = Mid(Filefound, stringtocut) 'Split(Mid(Filefound, stringtocut), ".")
            Me.cmbweathericon1.Items.Add(filefound1)
            Me.cmbweathericon2.Items.Add(filefound1)
            Me.cmbweathericon3.Items.Add(filefound1)
            Me.cmbweathericon4.Items.Add(filefound1)
        Next
    End Sub

    ' Weather code starts-------------------------------------------
    Sub playweather()
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()

        CasparCGDataCollection.SetData("logofilename1", Replace(weathericon1.Movie, "\", "/"))
        CasparCGDataCollection.SetData("logowidth1", nweathericon1width.Value)
        CasparCGDataCollection.SetData("logoheight1", nweathericon1height.Value)
        CasparCGDataCollection.SetData("logox1", nweathericon1x.Value)
        CasparCGDataCollection.SetData("logoy1", nweathericon1y.Value)
        CasparCGDataCollection.SetData("f1", txtweathericon1.Text)

        CasparCGDataCollection.SetData("logofilename2", Replace(weathericon2.Movie, "\", "/"))
        CasparCGDataCollection.SetData("logowidth2", nweathericon2width.Value)
        CasparCGDataCollection.SetData("logoheight2", nweathericon2height.Value)
        CasparCGDataCollection.SetData("logox2", nweathericon2x.Value)
        CasparCGDataCollection.SetData("logoy2", nweathericon2y.Value)
        CasparCGDataCollection.SetData("f2", txtweathericon2.Text)

        CasparCGDataCollection.SetData("logofilename3", Replace(weathericon3.Movie, "\", "/"))
        CasparCGDataCollection.SetData("logowidth3", nweathericon3width.Value)
        CasparCGDataCollection.SetData("logoheight3", nweathericon3height.Value)
        CasparCGDataCollection.SetData("logox3", nweathericon3x.Value)
        CasparCGDataCollection.SetData("logoy3", nweathericon3y.Value)
        CasparCGDataCollection.SetData("f3", txtweathericon3.Text)

        CasparCGDataCollection.SetData("logofilename4", Replace(weathericon4.Movie, "\", "/"))
        CasparCGDataCollection.SetData("logowidth4", nweathericon4width.Value)
        CasparCGDataCollection.SetData("logoheight4", nweathericon4height.Value)
        CasparCGDataCollection.SetData("logox4", nweathericon4x.Value)
        CasparCGDataCollection.SetData("logoy4", nweathericon4y.Value)
        CasparCGDataCollection.SetData("f4", txtweathericon4.Text)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmbweathericon1videolayer.Text), Int(cmbweathericon1videolayer.Text), txtWeatherTemplate.Text, True, CasparCGDataCollection.ToAMCPEscapedXml)


    End Sub
    Private Sub cmdweathericon1play_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdweathericon1play.Click
        On Error Resume Next
        playweather()
    End Sub

    Private Sub nweathericonvaluechange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        nweathericon1x.ValueChanged, nweathericon1y.ValueChanged, nweathericon1width.ValueChanged, nweathericon1height.ValueChanged,
        nweathericon2x.ValueChanged, nweathericon2y.ValueChanged, nweathericon2width.ValueChanged, nweathericon2height.ValueChanged,
        nweathericon3x.ValueChanged, nweathericon3y.ValueChanged, nweathericon3width.ValueChanged, nweathericon3height.ValueChanged,
        nweathericon4x.ValueChanged, nweathericon4y.ValueChanged, nweathericon4width.ValueChanged, nweathericon4height.ValueChanged
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()

        CasparCGDataCollection.SetData("logofilename1", Replace(weathericon1.Movie, "\", "/"))
        CasparCGDataCollection.SetData("logowidth1", nweathericon1width.Value)
        CasparCGDataCollection.SetData("logoheight1", nweathericon1height.Value)
        CasparCGDataCollection.SetData("logox1", nweathericon1x.Value)
        CasparCGDataCollection.SetData("logoy1", nweathericon1y.Value)
        CasparCGDataCollection.SetData("f1", txtweathericon1.Text)

        CasparCGDataCollection.SetData("logofilename2", Replace(weathericon2.Movie, "\", "/"))
        CasparCGDataCollection.SetData("logowidth2", nweathericon2width.Value)
        CasparCGDataCollection.SetData("logoheight2", nweathericon2height.Value)
        CasparCGDataCollection.SetData("logox2", nweathericon2x.Value)
        CasparCGDataCollection.SetData("logoy2", nweathericon2y.Value)
        CasparCGDataCollection.SetData("f2", txtweathericon2.Text)

        CasparCGDataCollection.SetData("logofilename3", Replace(weathericon3.Movie, "\", "/"))
        CasparCGDataCollection.SetData("logowidth3", nweathericon3width.Value)
        CasparCGDataCollection.SetData("logoheight3", nweathericon3height.Value)
        CasparCGDataCollection.SetData("logox3", nweathericon3x.Value)
        CasparCGDataCollection.SetData("logoy3", nweathericon3y.Value)
        CasparCGDataCollection.SetData("f3", txtweathericon3.Text)

        CasparCGDataCollection.SetData("logofilename4", Replace(weathericon4.Movie, "\", "/"))
        CasparCGDataCollection.SetData("logowidth4", nweathericon4width.Value)
        CasparCGDataCollection.SetData("logoheight4", nweathericon4height.Value)
        CasparCGDataCollection.SetData("logox4", nweathericon4x.Value)
        CasparCGDataCollection.SetData("logoy4", nweathericon4y.Value)
        CasparCGDataCollection.SetData("f4", txtweathericon4.Text)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmbweathericon1videolayer.Text), Int(cmbweathericon1videolayer.Text), CasparCGDataCollection)


    End Sub

    Private Sub cmdweathericon1stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdweathericon1stop.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmbweathericon1videolayer.Text), Int(cmbweathericon1videolayer.Text))

    End Sub

    Private Sub cmbweathericonchange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbweathericon1.SelectedIndexChanged, cmbweathericon2.SelectedIndexChanged, cmbweathericon3.SelectedIndexChanged, cmbweathericon4.SelectedIndexChanged

        On Error Resume Next
        weathericon1.Movie = "c:/casparcg/mydata/weather/" & cmbweathericon1.Text
        weathericon2.Movie = "c:/casparcg/mydata/weather/" & cmbweathericon2.Text
        weathericon3.Movie = "c:/casparcg/mydata/weather/" & cmbweathericon3.Text
        weathericon4.Movie = "c:/casparcg/mydata/weather/" & cmbweathericon4.Text

    End Sub

    Private Sub savetsweather_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub opentsweather_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub readfileforweather(ByVal str As String)
        On Error Resume Next
        Dim i As Integer
        Dim a As Array

        a = Split(My.Computer.FileSystem.ReadAllText(str), Chr(2) + "=")
        Dim b As Array

        For i = 0 To Me.gbweather.Controls.Count - 1
            b = Split(a(i + 1), vbCrLf)
            Me.gbweather.Controls(i).Text = b(0)
        Next
    End Sub

    Private Sub cmdrefreshmedaiforweather_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrefreshmedaiforweather.Click
        On Error Resume Next
        enumweathericons()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        On Error Resume Next
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = "c:\casparcg\mydata\weather\weather list\"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            readfileforweather(ofd2.FileName)
            lblweatherfilename.Text = ofd2.FileName
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        On Error Resume Next
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "c:\casparcg\mydata\weather\weather list\"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Dim i As Integer
            Dim a As String = ""
            For i = 0 To Me.gbweather.Controls.Count - 1
                a = a + Me.gbweather.Controls(i).Name + Chr(2) + "=" + Me.gbweather.Controls(i).Text + vbCrLf
            Next
            a = a + Chr(2) + "=  "
            My.Computer.FileSystem.WriteAllText(osd2.FileName, a, False)
            lblweatherfilename.Text = osd2.FileName
        End If
    End Sub

    Private Sub MenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip1.MouseHover
        MakeMenuDropDownWhenParrented(sender)
    End Sub
End Class
