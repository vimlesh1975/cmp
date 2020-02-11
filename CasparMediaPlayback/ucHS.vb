Imports System.IO
Public Class ucHS
    Private Sub cmdresume1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresume1.Click
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("speed", nspeed.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs1.Text), 15, CasparCGDataCollection)
    End Sub
    Private Sub cmbfonths1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfonths1.SelectedIndexChanged
        On Error Resume Next
        Dim fontname As String = cmbfonths1.Text
        Dim fontsize As Integer = frmmediaplayer.nfontsizeforall.Value
        Dim fs As New Font(fontname, fontsize, FontStyle.Regular)
        Me.txtcrawl.Font = fs
        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("font", cmbfonths1.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs1.Text), 15, CasparCGDataCollection)
    End Sub

    Private Sub cmdhidehs1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub cmdleftlogoopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdleftlogoopen.Click
        On Error Resume Next
        If (picofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            picleftlogo.Movie = picofd.FileName
            txtleftlogo.Text = picofd.FileName
        End If
    End Sub

    Private Sub cmdleftlogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdleftlogo.Click
        On Error Resume Next
        leftlogo()
    End Sub
    Sub leftlogo()
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("a", Replace(txtleftlogo.Text, "\", "/"))
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayerhs1.Text), 18, "CMP/left/left", True, CasparCGDataCollection.ToAMCPEscapedXml)
    End Sub
    Private Sub cmdstopleft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopleft.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayerhs1.Text), 18)
    End Sub
    Private Sub cmdmiddle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmiddle.Click
        On Error Resume Next
        middle()
    End Sub
    Sub middle()
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("a", Replace(txtmiddle.Text, "\", "/"))
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayerhs1.Text), 16, "CMP/middle/middle", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdstopmiddle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopmiddle.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayerhs1.Text), 16)
    End Sub

    Private Sub cmdrightlogoopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrightlogoopen.Click
        On Error Resume Next
        If (picofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            picrightlogo.Movie = picofd.FileName
            txtrightlogo.Text = picofd.FileName
        End If
    End Sub

    Private Sub cmdrightlogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrightlogo.Click
        On Error Resume Next
        rightlogo()
    End Sub
    Sub rightlogo()
        On Error Resume Next

        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("a", Replace(txtrightlogo.Text, "\", "/"))
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayerhs1.Text), 17, "CMP/right/right", True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdstopright_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopright.Click
        On Error Resume Next

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayerhs1.Text), 17)

    End Sub

    Private Sub cmdfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfile.Click
        On Error Resume Next
        ofd1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd1.InitialDirectory = "c:\casparcg\mydata\HorizontalScroll1\"
        If (ofd1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            If (ofd1.FileName <> "") Then
                Dim objFileInfo As FileInfo
                objFileInfo = New FileInfo(ofd1.FileName)

                ReadTextFile(objFileInfo.FullName, txtcrawl)
            End If
        End If
    End Sub
    Private Sub cmdshowcrawl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshowcrawl.Click
        crawl()
    End Sub

    Sub crawl()
        On Error Resume Next
        Dim a As Array
        Dim str As String = ""
        a = Split(txtcrawl.Text, vbCrLf)
        For ii = LBound(a) To UBound(a)
            str = str + " ** " + a(ii)
        Next
        CasparCGDataCollection.Clear() 'cgData.Clear(   )
        If chkbas64hs1.Checked Then
            Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(str)
            CasparCGDataCollection.SetData("base64", System.Convert.ToBase64String(array))

        Else
            CasparCGDataCollection.SetData("xf0", str)
            CasparCGDataCollection.SetData("font", cmbfonths1.Text)
        End If
        CasparCGDataCollection.SetData("speed", Int(nspeed.Value))

        CasparCGDataCollection.SetData("size", nsize.Value)
        CasparCGDataCollection.SetData("color", "0x" & String.Format("{0:X2}{1:X2}{2:X2}", cmdstripcolor.ForeColor.R, cmdstripcolor.ForeColor.G, cmdstripcolor.ForeColor.B))

        'CasparCGDataCollection.SetData("font", cmbfonths1.Text)
        CasparCGDataCollection.SetData("y", ny.Text)
        CasparCGDataCollection.SetData("stripcolor", "0x" & String.Format("{0:X2}{1:X2}{2:X2}", cmdstripcolor.BackColor.R, cmdstripcolor.BackColor.G, cmdstripcolor.BackColor.B))


        CasparCGDataCollection.SetData("opacity", nopacityhs1.Value)
        If chkclock.Checked Then CasparCGDataCollection.SetData("alfa", 1) Else CasparCGDataCollection.SetData("alfa", 0)
        If chkltrhs1.Checked Then
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayerhs1.Text), 15, txths1TemplateLtoR.Text, True, CasparCGDataCollection.ToAMCPEscapedXml)
        Else
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayerhs1.Text), 15, txths1Template.Text, True, CasparCGDataCollection.ToAMCPEscapedXml)
        End If

    End Sub

    Private Sub cmdpause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpause.Click
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("speed", "0")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs1.Text), 15, CasparCGDataCollection)

    End Sub

    Private Sub nopacityhs1_ValueChanged(sender As Object, e As EventArgs) Handles nopacityhs1.ValueChanged
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("opacity", nopacityhs1.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs1.Text), 15, CasparCGDataCollection)

    End Sub
    Private Sub cmdstopcrawl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopcrawl.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayerhs1.Text), 15)
    End Sub

    Private Sub picleftlogo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picleftlogo.Enter
        On Error Resume Next
        If (picofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            picleftlogo.Movie = picofd.FileName
            txtleftlogo.Text = picofd.FileName
        End If
    End Sub

    Private Sub picmiddle_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picmiddle.Enter
        On Error Resume Next
        If (picofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            picmiddle.Movie = picofd.FileName
            txtmiddle.Text = picofd.FileName
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next
        If (picofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            picmiddle.Movie = picofd.FileName
            txtmiddle.Text = picofd.FileName
        End If
    End Sub


    Private Sub picrightlogo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picrightlogo.Enter
        On Error Resume Next
        If (picofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            picrightlogo.Movie = picofd.FileName
            txtrightlogo.Text = picofd.FileName
        End If
    End Sub

    Private Sub nsize_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nsize.ValueChanged
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("size", nsize.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs1.Text), 15, CasparCGDataCollection)

    End Sub

    Private Sub nspeed_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nspeed.ValueChanged
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("speed", nspeed.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs1.Text), 15, CasparCGDataCollection)

    End Sub

    Private Sub ny_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ny.ValueChanged
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("y", ny.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs1.Text), 15, CasparCGDataCollection)

    End Sub

    Private Sub cmdcolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcolor.Click
        On Error Resume Next
        If (cd1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdcolor.ForeColor = cd1.Color
            cmdstripcolor.ForeColor = cd1.Color

            CasparCGDataCollection.Clear() 'cgData.Clear()
            CasparCGDataCollection.SetData("color", "0x" & String.Format("{0:X2}{1:X2}{2:X2}", cmdstripcolor.ForeColor.R, cmdstripcolor.ForeColor.G, cmdstripcolor.ForeColor.B))
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs1.Text), 15, CasparCGDataCollection)
        End If
    End Sub

    Private Sub txtcrawl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcrawl.TextChanged
        On Error Resume Next
        Dim a As Array
        Dim str As String = ""
        a = Split(txtcrawl.Text, vbCrLf)
        For ii = LBound(a) To UBound(a)
            str = str + " " + a(ii)
        Next
        CasparCGDataCollection.Clear()
        If chkbas64hs1.Checked Then
            Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(str)
            CasparCGDataCollection.SetData("base64", System.Convert.ToBase64String(array))

        Else
            CasparCGDataCollection.SetData("xf0", str)
            CasparCGDataCollection.SetData("font", cmbfonths1.Text)
        End If
        'CasparCGDataCollection.SetData("xf0", str)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs1.Text), 15, CasparCGDataCollection)
    End Sub

    Private Sub cmdstripcolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstripcolor.Click
        On Error Resume Next
        If (cd1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdstripcolor.BackColor = cd1.Color
            cmdcolor.BackColor = cd1.Color
            CasparCGDataCollection.Clear() 'cgData.Clear()
            CasparCGDataCollection.SetData("stripcolor", "0x" & String.Format("{0:X2}{1:X2}{2:X2}", cmdstripcolor.BackColor.R, cmdstripcolor.BackColor.G, cmdstripcolor.BackColor.B))
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs1.Text), 15, CasparCGDataCollection)
        End If
    End Sub
    Private Sub chkclock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkclock.CheckedChanged
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        If chkclock.Checked Then CasparCGDataCollection.SetData("alfa", 1) Else CasparCGDataCollection.SetData("alfa", 0)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayerhs1.Text), 15, CasparCGDataCollection)
    End Sub

    Sub enumfonts()
        On Error Resume Next
        For Each Filefound As String In Directory.GetFiles("c:/casparcg/mydata/fonts", "*.swf")
            Dim stringtocut As Integer = 26
            Dim filefound1 = Split(Mid(Filefound, stringtocut), ".")
            cmbfonths1.Items.Add(filefound1(0))
        Next
    End Sub
    Private Sub ucHS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enumfonts()
    End Sub
End Class
