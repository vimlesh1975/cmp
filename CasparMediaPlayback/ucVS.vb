Imports System.IO
Public Class ucVS
    Dim ivs As Integer = 0
    Dim iPauseResumeV As Integer = 0

    Private Sub cmdcolorV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcolorV.Click
        On Error Resume Next
        If (cd1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdcolorV.BackColor = cd1.Color

            Dim r As String = Hex(cd1.Color.R)
            If r.Substring(1) = "" Then r = "0" & r
            Dim g As String = Hex(cd1.Color.G)
            If g.Substring(1) = "" Then g = "0" & g
            Dim b As String = Hex(cd1.Color.B)
            If b.Substring(1) = "" Then b = "0" & b
            lblcolorV.Text = "0x" & r & g & b
            CasparCGDataCollection.Clear() 'cgData.Clear()
            CasparCGDataCollection.SetData("color", lblcolorV.Text)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayervs.Text), Int(cmblayervs.Text), CasparCGDataCollection)
        End If
    End Sub
    Private Sub cmbalign_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbalign.SelectedIndexChanged
        On Error Resume Next
        If Me.cmbalign.Text = "center" Then Me.txtcrawlv.TextAlign = HorizontalAlignment.Center
        If Me.cmbalign.Text = "left" Then Me.txtcrawlv.TextAlign = HorizontalAlignment.Left
        If Me.cmbalign.Text = "right" Then Me.txtcrawlv.TextAlign = HorizontalAlignment.Right
        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("align", cmbalign.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayervs.Text), Int(cmblayervs.Text), CasparCGDataCollection)

    End Sub
    Private Sub cmdpausev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpausev.Click
        On Error Resume Next
        PauseResumeV()
    End Sub

    Sub PauseResumeV()
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        If iPauseResumeV = 1 Then
            CasparCGDataCollection.SetData("speed", "0")
        Else
            CasparCGDataCollection.SetData("speed", nspeedV.Value)
        End If
        iPauseResumeV = iPauseResumeV + 1
        If iPauseResumeV > 1 Then iPauseResumeV = 0
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayervs.Text), Int(cmblayervs.Text), CasparCGDataCollection)

    End Sub
    Private Sub cmdfileV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfileV.Click
        On Error Resume Next
        ofd1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd1.InitialDirectory = "c:\casparcg\mydata\Verticalscroll\"
        If (ofd1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            If (ofd1.FileName <> "") Then
                Dim objFileInfo As FileInfo
                objFileInfo = New FileInfo(ofd1.FileName)
                ' txtcrawlv.Text = ofd1.FileName
                ReadTextFilev(objFileInfo.FullName)
            End If
        End If
    End Sub
    Private Sub ReadTextFilev(ByVal sFileName As String)
        On Error Resume Next
        Dim sLineData As String = ""
        Dim objTextReader As System.IO.TextReader
        objTextReader = New StreamReader(sFileName)
        sLineData = objTextReader.ReadToEnd
        Me.txtcrawlv.Text = sLineData
        objTextReader.Close()
    End Sub

    Private Sub cmdvsnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdvsnext.Click
        On Error Resume Next
        vsnextitem()

    End Sub
    Sub vsnextitem()
        On Error Resume Next
        Dim aa As Array = Split(txtcrawlv.Text, vbNewLine + vbNewLine)
        ivs = ivs + 1
        If ivs > aa.GetUpperBound(0) Then ivs = aa.GetUpperBound(0)
        Dim str As String = ""
        For jvs = ivs To aa.GetUpperBound(0)
            If str = "" Then
                str = aa(jvs)
            Else
                str = str + vbNewLine + vbNewLine + aa(jvs)
            End If
        Next
        vsgotoitem(str)
        iPauseResumeV = 0
    End Sub

    Private Sub cmdvsprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdvsprevious.Click
        On Error Resume Next
        vspreviousitem()
    End Sub
    Sub vspreviousitem()
        On Error Resume Next
        Dim aa As Array = Split(txtcrawlv.Text, vbNewLine + vbNewLine)
        ivs = ivs - 1
        If ivs < 0 Then ivs = 0
        Dim str As String = ""
        For jvs = ivs To aa.GetUpperBound(0)
            If str = "" Then
                str = aa(jvs)
            Else
                str = str + vbNewLine + vbNewLine + aa(jvs)
            End If
        Next
        vsgotoitem(str)

        iPauseResumeV = 0
    End Sub
    Private Sub cmdvsfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdvsfirst.Click
        On Error Resume Next
        vsfirstitem()
    End Sub
    Sub vsfirstitem()
        On Error Resume Next
        vsgotoitem(txtcrawlv.Text)
        ivs = 0

        iPauseResumeV = 0
    End Sub
    Private Sub cmdvslast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdvslast.Click
        On Error Resume Next
        vslastitem()
    End Sub
    Sub vslastitem()
        On Error Resume Next
        Dim aa As Array = Split(txtcrawlv.Text, vbNewLine + vbNewLine)
        Dim str As String = ""
        str = aa(aa.GetUpperBound(0))
        vsgotoitem(str)
        ivs = aa.GetUpperBound(0)

        iPauseResumeV = 0
    End Sub

    Private Sub cmdvsgoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdvsgoto.Click
        On Error Resume Next
        Dim aa As Array = Split(txtcrawlv.Text, vbNewLine + vbNewLine)

        Dim str As String = ""
        For jvs = Int(cmbvsitems.Text) To aa.GetUpperBound(0)
            If str = "" Then
                str = aa(jvs)
            Else
                str = str + vbNewLine + vbNewLine + aa(jvs)
            End If
        Next
        vsgotoitem(str)
        ivs = Int(cmbvsitems.Text)

        iPauseResumeV = 0
    End Sub

    Sub vsgotoitem(ByVal str As String)
        On Error Resume Next
        CasparCGDataCollection.Clear()

        If chkbase64vs.Checked Then
            Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(str)
            CasparCGDataCollection.SetData("base64", System.Convert.ToBase64String(array))
        Else
            CasparCGDataCollection.SetData("xf0", str)
            CasparCGDataCollection.SetData("font", cmbfontvs.Text)
        End If
        If rdofromcenter.Checked Then
            CasparCGDataCollection.SetData("startfromcenter", "")
        End If

        CasparCGDataCollection.SetData("speed", Int(0))
        CasparCGDataCollection.SetData("size", nsizeV.Value)
        CasparCGDataCollection.SetData("color", lblcolorV.Text)

        CasparCGDataCollection.SetData("align", cmbalign.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayervs.Text), Int(cmblayervs.Text), txtvs1Template.Text, True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub
    Private Sub cmdshowcrawlV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdshowcrawlV.Click
        On Error Resume Next
        crawlv()
    End Sub
    Sub crawlv()
        On Error Resume Next
        CasparCGDataCollection.Clear()
        Dim str As String
        If txtcrawlv.SelectedText = "" Then
            str = txtcrawlv.Text
        Else
            str = txtcrawlv.SelectedText
        End If

        If chkbase64vs.Checked Then
            Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(str)
            CasparCGDataCollection.SetData("base64", System.Convert.ToBase64String(array))
        Else
            CasparCGDataCollection.SetData("xf0", str)
            CasparCGDataCollection.SetData("font", cmbfontvs.Text)
        End If
        If rdofromcenter.Checked Then
            CasparCGDataCollection.SetData("startfromcenter", "")
        End If

        CasparCGDataCollection.SetData("speed", Int(nspeedV.Value))
        CasparCGDataCollection.SetData("size", nsizeV.Value)
        CasparCGDataCollection.SetData("color", lblcolorV.Text)

        CasparCGDataCollection.SetData("align", cmbalign.Text)

        CasparCGDataCollection.SetData("bordercolor", lblcolorborderV.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayervs.Text), Int(cmblayervs.Text), txtvs1Template.Text, True, CasparCGDataCollection.ToAMCPEscapedXml)
        If nspeedV.Value <> 0 Then iPauseResumeV = 1
    End Sub



    Private Sub cmdstopcrawlV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopcrawlV.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayervs.Text), Int(cmblayervs.Text))
    End Sub

    Private Sub nsizeV_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nsizeV.ValueChanged
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("size", nsizeV.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayervs.Text), Int(cmblayervs.Text), CasparCGDataCollection)
    End Sub

    Private Sub nspeedV_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nspeedV.ValueChanged
        On Error Resume Next
        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("speed", nspeedV.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayervs.Text), Int(cmblayervs.Text), CasparCGDataCollection)

        If nspeedV.Value <> 0 Then iPauseResumeV = 1
    End Sub

    Private Sub cmdfileSaveV_Click(sender As Object, e As EventArgs) Handles cmdfileSaveV.Click
        On Error Resume Next

        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "c:\casparcg\mydata\VerticalScroll\"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                sw.WriteLine(txtcrawlv.Text)
                sw.Close()
            End Using
            Me.lblfilenamev.Text = osd2.FileName
        End If
    End Sub

    Private Sub txtspeedchangevalue_TextChanged(sender As Object, e As EventArgs)
        On Error Resume Next
        nspeedV.Increment = txtspeedchangevalue.Text
    End Sub
    Private Sub cmbfontvs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfontvs.SelectedIndexChanged
        'for vertical
        On Error Resume Next
        Dim fontname As String = cmbfontvs.Text
        Dim fontsize As Integer = frmmediaplayer.nfontsizeforall.Value
        Dim fs As New Font(fontname, fontsize, FontStyle.Regular)
        Me.txtcrawlv.Font = fs
        CasparCGDataCollection.Clear() 'cgData.Clear()
        Dim str As String = txtcrawlv.Text
        If chkbase64vs.Checked Then
            Dim array() As Byte = System.Text.Encoding.UTF8.GetBytes(str)
            CasparCGDataCollection.SetData("base64", System.Convert.ToBase64String(array))
        Else
            CasparCGDataCollection.SetData("xf0", str)
            CasparCGDataCollection.SetData("font", cmbfontvs.Text)
        End If
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayervs.Text), Int(cmblayervs.Text), CasparCGDataCollection)

    End Sub

    Private Sub txtcrawlv_DoubleClick(sender As Object, e As EventArgs) Handles txtcrawlv.DoubleClick
        txtcrawlv.SelectionStart = txtcrawlv.GetFirstCharIndexOfCurrentLine
        txtcrawlv.SelectionLength = txtcrawlv.Text.Length

    End Sub

    Private Sub txtcrawlv_TextChanged(sender As Object, e As EventArgs) Handles txtcrawlv.TextChanged
    End Sub

    Private Sub ucVS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enumfonts()
    End Sub
    Sub enumfonts()
        On Error Resume Next
        For Each Filefound As String In Directory.GetFiles("c:/casparcg/mydata/fonts", "*.swf")
            Dim stringtocut As Integer = 26
            Dim filefound1 = Split(Mid(Filefound, stringtocut), ".")
            cmbfontvs.Items.Add(filefound1(0))
        Next
    End Sub

    Private Sub txtcrawlv_RegionChanged(sender As Object, e As EventArgs) Handles txtcrawlv.RegionChanged
    End Sub

    Private Sub cmdcolorborderV_Click(sender As Object, e As EventArgs) Handles cmdcolorborderV.Click
        On Error Resume Next
        If (cd1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdcolorborderV.BackColor = cd1.Color

            Dim r As String = Hex(cd1.Color.R)
            If r.Substring(1) = "" Then r = "0" & r
            Dim g As String = Hex(cd1.Color.G)
            If g.Substring(1) = "" Then g = "0" & g
            Dim b As String = Hex(cd1.Color.B)
            If b.Substring(1) = "" Then b = "0" & b
            lblcolorborderV.Text = "0x" & r & g & b
            CasparCGDataCollection.Clear() 'cgData.Clear()
            CasparCGDataCollection.SetData("bordercolor", lblcolorborderV.Text)
            CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayervs.Text), Int(cmblayervs.Text), CasparCGDataCollection)
        End If
    End Sub

    Private Sub cmdSwapColorV_Click(sender As Object, e As EventArgs) Handles cmdSwapColorV.Click
        On Error Resume Next
        Dim tempcolor = cmdcolorV.BackColor
        Dim tempcolorvalue = lblcolorV.Text

        cmdcolorV.BackColor = cmdcolorborderV.BackColor
        lblcolorV.Text = lblcolorborderV.Text

        cmdcolorborderV.BackColor = tempcolor
        lblcolorborderV.Text = tempcolorvalue


        CasparCGDataCollection.Clear() 'cgData.Clear()
        CasparCGDataCollection.SetData("color", lblcolorV.Text)
        CasparCGDataCollection.SetData("bordercolor", lblcolorborderV.Text)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmblayervs.Text), Int(cmblayervs.Text), CasparCGDataCollection)
    End Sub
End Class
