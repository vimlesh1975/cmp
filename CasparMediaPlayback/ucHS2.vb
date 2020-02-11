Imports System.IO
Public Class ucHS2
    Private Sub cmdhidegbhs2_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Private Sub cmbfonths2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfonths2.SelectedIndexChanged
        'for 2nd
        On Error Resume Next
        Dim fontname As String = cmbfonths2.Text
        Dim fontsize As Integer = frmmediaplayer.nfontsizeforall.Value
        Dim fs As New Font(fontname, fontsize, FontStyle.Regular)
        Me.txtcrawl2.Font = fs
        CasparCGDataCollection.Clear() 'cgData.Clear()
        If chkbase64.Checked = False Then
            CasparCGDataCollection.SetData("font", cmbfonths2.Text)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs2.Text), Int(cmblayerhs2.Text), CasparCGDataCollection)
        End If
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
    Private Sub cmdshowcrawl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshowcrawl2.Click
        On Error Resume Next
        Dim a As Array
        Dim str As String = ""
        a = Split(txtcrawl2.Text, vbCrLf)
        For ii = LBound(a) To UBound(a)
            str = str + " ** " + a(ii)
        Next
        CasparCGDataCollection.Clear() 'cgData.Clear()

        If chkbase64.Checked Then
            Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(str)
            CasparCGDataCollection.SetData("base64", System.Convert.ToBase64String(array))

        Else
            CasparCGDataCollection.SetData("xf0", str)
            CasparCGDataCollection.SetData("font", cmbfonths2.Text)
        End If

        CasparCGDataCollection.SetData("speed", Int(nspeed2.Value))
        CasparCGDataCollection.SetData("size", nsize2.Value)


        CasparCGDataCollection.SetData("y", ny2.Text)
        CasparCGDataCollection.SetData("color", "0x" & String.Format("{0:X2}{1:X2}{2:X2}", cmdcolor2.ForeColor.R, cmdcolor2.ForeColor.G, cmdcolor2.ForeColor.B))
        CasparCGDataCollection.SetData("stripcolor", "0x" & String.Format("{0:X2}{1:X2}{2:X2}", cmdcolor2.BackColor.R, cmdcolor2.BackColor.G, cmdcolor2.BackColor.B))

        If chkclock2.Checked Then CasparCGDataCollection.SetData("alfa", 1) Else CasparCGDataCollection.SetData("alfa", 0)
        If chkltrhs2.Checked Then
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayerhs2.Text), Int(cmblayerhs2.Text), txths2TemplateLtoR.Text, True, CasparCGDataCollection.ToAMCPEscapedXml)
        Else
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayerhs2.Text), Int(cmblayerhs2.Text), txths2Template.Text, True, CasparCGDataCollection.ToAMCPEscapedXml)
        End If
    End Sub
    Private Sub cmdpause2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpause2.Click
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("speed", "0")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs2.Text), Int(cmblayerhs2.Text), CasparCGDataCollection)

    End Sub
    Private Sub cmdresume2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresume2.Click
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("speed", nspeed2.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs2.Text), Int(cmblayerhs2.Text), CasparCGDataCollection)
    End Sub
    Private Sub cmdstopcrawl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopcrawl2.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayerhs2.Text), Int(cmblayerhs2.Text))
    End Sub
    Private Sub chkclock2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkclock2.CheckedChanged
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        If chkclock2.Checked Then CasparCGDataCollection.SetData("alfa", 1) Else CasparCGDataCollection.SetData("alfa", 0)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs2.Text), Int(cmblayerhs2.Text), CasparCGDataCollection)
    End Sub

    Private Sub cmdstripcolor2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstripcolor2.Click
        On Error Resume Next
        If (cd1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdstripcolor2.BackColor = cd1.Color
            cmdcolor2.BackColor = cd1.Color
            CasparCGDataCollection.Clear() 'cgData.Clear()
            CasparCGDataCollection.SetData("stripcolor", "0x" & String.Format("{0:X2}{1:X2}{2:X2}", cmdcolor2.BackColor.R, cmdcolor2.BackColor.G, cmdcolor2.BackColor.B))

            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs2.Text), Int(cmblayerhs2.Text), CasparCGDataCollection)
        End If
    End Sub
    Private Sub nsize2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nsize2.ValueChanged
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("size", nsize2.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs2.Text), Int(cmblayerhs2.Text), CasparCGDataCollection)
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
        CasparCGDataCollection.Clear() 'cgData.Clear()

        If chkbase64.Checked Then
            Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(str)
            CasparCGDataCollection.SetData("base64", System.Convert.ToBase64String(array))
        Else
            CasparCGDataCollection.SetData("xf0", str)
            CasparCGDataCollection.SetData("font", cmbfonths2.Text)
        End If
        CasparDevice.Channels(Int(g_int_ChannelNumber) - 1).CG.Update(Int(cmblayerhs2.Text), Int(cmblayerhs2.Text), CasparCGDataCollection)
    End Sub
    Private Sub cmdcolor2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcolor2.Click
        On Error Resume Next
        If (cd1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdcolor2.ForeColor = cd1.Color
            cmdstripcolor2.ForeColor = cd1.Color

            CasparCGDataCollection.Clear() 'cgData.Clear()
            CasparCGDataCollection.SetData("color", "0x" & String.Format("{0:X2}{1:X2}{2:X2}", cmdcolor2.ForeColor.R, cmdcolor2.ForeColor.G, cmdcolor2.ForeColor.B))
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs2.Text), Int(cmblayerhs2.Text), CasparCGDataCollection)
        End If
    End Sub

    Private Sub ny2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ny2.ValueChanged
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("y", ny2.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs2.Text), Int(cmblayerhs2.Text), CasparCGDataCollection)
    End Sub
    Sub enumfonts()
        On Error Resume Next
        For Each Filefound As String In Directory.GetFiles("c:/casparcg/mydata/fonts", "*.swf")
            Dim stringtocut As Integer = 26
            Dim filefound1 = Split(Mid(Filefound, stringtocut), ".")
            cmbfonths2.Items.Add(filefound1(0))
        Next
    End Sub

    Private Sub ucHS2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enumfonts()
    End Sub
End Class
