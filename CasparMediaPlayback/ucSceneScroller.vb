Imports System.IO
Imports Svt.Caspar
Imports Svt.Network
Public Class ucSceneScroller

    Dim casparcgdatacollection As New CasparCGDataCollection
    Dim g_int_ChannelNumber As Integer = 1
    Private Sub cmdhidegbhs2_Click(sender As Object, e As EventArgs) 
        Me.Hide()
    End Sub

    Private Sub cmdfile2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfile2.Click
        On Error Resume Next
        ofd1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd1.InitialDirectory = "c:\casparcg\mydata\HorizontalScroll2\"
        If (ofd1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            If (ofd1.FileName <> "") Then
                Dim objFileInfo As FileInfo
                objFileInfo = New FileInfo(ofd1.FileName)

                ReadTextFile(objFileInfo.FullName, txtcrawl2)
            End If
        End If
    End Sub
    Public Sub ReadTextFile(ByVal sFileName As String, ByVal ttt As TextBox)
        On Error Resume Next
        Dim sLineData As String = ""
        Dim objTextReader As System.IO.TextReader
        objTextReader = New StreamReader(sFileName)
        sLineData = objTextReader.ReadToEnd
        ttt.Text = sLineData
        objTextReader.Close()
    End Sub
    Private Sub cmdshowcrawl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshowcrawl2.Click
        On Error Resume Next
        Dim a As Array
        Dim str As String = ""
        a = Split(txtcrawl2.Text, vbCrLf)
        For ii = LBound(a) To UBound(a)
            str = str + " ** " + a(ii)
        Next
        casparcgdatacollection.Clear() 'cgData.Clear()
        casparcgdatacollection.SetData("text", str)
        casparcgdatacollection.SetData("speed", Int(nspeed2.Value))
        casparcgdatacollection.SetData("iterations", 1000000) 'no of play
        casparcgdatacollection.SetData("plateposition", ny2.Text)
        casparcgdatacollection.SetData("stripcolor", lblstripcolor2.Text)
        casparcgdatacollection.SetData("opacity", nopacity.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayerhs2.Text), Int(cmblayerhs2.Text), txtSceneTemplate.Text, True, casparcgdatacollection.ToAMCPEscapedXml)
    End Sub




    Private Sub cmdstopcrawl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopcrawl2.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayerhs2.Text), Int(cmblayerhs2.Text))
    End Sub
    Private Sub nspeed2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nspeed2.ValueChanged
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("speed", nspeed2.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs2.Text), Int(cmblayerhs2.Text), CasparCGDataCollection)
    End Sub
    Private Sub txtcrawl2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcrawl2.TextChanged
        On Error Resume Next
        Dim a As Array
        Dim str As String = ""
        a = Split(txtcrawl2.Text, vbCrLf)
        For ii = LBound(a) To UBound(a)
            str = str + " " + a(ii)
        Next
        casparcgdatacollection.Clear() 'cgData.Clear()
        casparcgdatacollection.SetData("xf0", str)
        CasparDevice.Channels(Int(g_int_ChannelNumber) - 1).CG.Update(Int(cmblayerhs2.Text), Int(cmblayerhs2.Text), CasparCGDataCollection)
    End Sub
    Private Sub ny2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ny2.ValueChanged
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        casparcgdatacollection.SetData("plateposition", ny2.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs2.Text), Int(cmblayerhs2.Text), CasparCGDataCollection)
    End Sub
    Private Sub nopacity_ValueChanged(sender As Object, e As EventArgs) Handles nopacity.ValueChanged
        On Error Resume Next
        casparcgdatacollection.Clear() 'cgData.Clear()
        casparcgdatacollection.SetData("opacity", nopacity.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs2.Text), Int(cmblayerhs2.Text), casparcgdatacollection)
    End Sub
End Class
