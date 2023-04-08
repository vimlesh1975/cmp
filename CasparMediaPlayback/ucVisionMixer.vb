Imports System.Xml
Public Class ucVisionMixer
    Private Sub cmdsource1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsource1.Click
        On Error Resume Next
        CasparDevice.SendString("play 1-21 route://1-1 " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text)
        lblPGMSource.Text = 1
    End Sub

    Private Sub cmdsource2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsource2.Click
        On Error Resume Next
        CasparDevice.SendString("play 1-21 route://1-2 " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text)

        lblPGMSource.Text = 2
    End Sub

    Private Sub cmdsource3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsource3.Click
        On Error Resume Next
        CasparDevice.SendString("play 1-21 route://1-3 " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text)
        lblPGMSource.Text = 3
    End Sub

    Private Sub cmdsource4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsource4.Click
        On Error Resume Next
        CasparDevice.SendString("play 1-21 route://1-4 " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text)
        lblPGMSource.Text = 4
    End Sub
    Private Sub cmdsource5_Click(sender As Object, e As EventArgs) Handles cmdsource5.Click
        On Error Resume Next
        CasparDevice.SendString("play 1-21 route://1-5 " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text)

        lblPGMSource.Text = 5
    End Sub

    Private Sub cmdsource6_Click(sender As Object, e As EventArgs) Handles cmdsource6.Click
        On Error Resume Next
        CasparDevice.SendString("play 1-21 route://1-6 " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text)

        lblPGMSource.Text = 6
    End Sub

    Private Sub cmdsource7_Click(sender As Object, e As EventArgs) Handles cmdsource7.Click
        On Error Resume Next
        CasparDevice.SendString("play 1-21 route://1-7 " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text)

        lblPGMSource.Text = 7
    End Sub

    Private Sub cmdsource8_Click(sender As Object, e As EventArgs) Handles cmdsource8.Click
        On Error Resume Next
        CasparDevice.SendString("play 1-21 route://1-8 " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text)

        lblPGMSource.Text = 8
    End Sub
    Private Sub cmdred_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdred.Click
        On Error Resume Next

        If rdoColorPGM.Checked Then
            CasparDevice.SendString("play 1-21 red " & cmbtransition.Text & " " & ntransitionduration.Value)
            lblPGMSource.Text = "red"
        Else
            CasparDevice.SendString("play 2-21 red " & cmbtransition.Text & " " & ntransitionduration.Value)
            lblpreviewSource.Text = "red"
        End If
    End Sub

    Private Sub cmdgreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgreen.Click
        On Error Resume Next
        If rdoColorPGM.Checked Then
            CasparDevice.SendString("play 1-21 green " & cmbtransition.Text & " " & ntransitionduration.Value)
            lblPGMSource.Text = "green"
        Else
            CasparDevice.SendString("play 2-21 green " & cmbtransition.Text & " " & ntransitionduration.Value)
            lblpreviewSource.Text = "green"
        End If

    End Sub

    Private Sub cmdblue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdblue.Click

        On Error Resume Next
        If rdoColorPGM.Checked Then
            CasparDevice.SendString("play 1-21 blue " & cmbtransition.Text & " " & ntransitionduration.Value)
            lblPGMSource.Text = "blue"
        Else
            CasparDevice.SendString("play 2-21 blue " & cmbtransition.Text & " " & ntransitionduration.Value)
            lblpreviewSource.Text = "blue"
        End If

    End Sub

    Private Sub cmdblack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdblack.Click

        On Error Resume Next
        If rdoColorPGM.Checked Then
            CasparDevice.SendString("play 1-21 black " & cmbtransition.Text & " " & ntransitionduration.Value)
            lblPGMSource.Text = "black"
        Else
            CasparDevice.SendString("play 2-21 black " & cmbtransition.Text & " " & ntransitionduration.Value)
            lblpreviewSource.Text = "black"
        End If

    End Sub


    Private Sub cmdhidevisionmixer_Click(sender As Object, e As EventArgs)
        Me.Hide()

        On Error Resume Next
        If Not parentedProcess1 Is Nothing Then
            SetParent(parentedProcess1.MainWindowHandle, Nothing)
        End If
    End Sub

    Function colorvalue(c1 As Color)
        Dim r As String = Hex(c1.R)
        If r.Substring(1) = "" Then r = "0" & r
        Dim g As String = Hex(c1.G)
        If g.Substring(1) = "" Then g = "0" & g
        Dim b As String = Hex(c1.B)
        If b.Substring(1) = "" Then b = "0" & b
        Return "#" & r & g & b
    End Function


    Sub chanegbackcolor(bb As Object)
        Dim aa As New ColorDialog
        If (aa.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            bb.BackColor = aa.Color
        End If
    End Sub

    Private Sub cmdstripcolorvisionmixer1_Click(sender As Object, e As EventArgs) Handles cmdstripcolorvisionmixer1.Click
        chanegbackcolor(sender)

    End Sub

    Private Sub cmdstripcolorvisionmixer1_Paint(sender As Object, e As PaintEventArgs) Handles cmdstripcolorvisionmixer1.Paint
        Label1.Text = colorvalue(sender.backcolor)
    End Sub
    Private Sub cmdstripcolorvisionmixer2_Click(sender As Object, e As EventArgs) Handles cmdstripcolorvisionmixer2.Click
        chanegbackcolor(sender)

    End Sub
    Private Sub cmdstripcolorvisionmixer2_Paint(sender As Object, e As PaintEventArgs) Handles cmdstripcolorvisionmixer2.Paint
        Label2.Text = colorvalue(sender.backcolor)
    End Sub
    Private Sub cmdstripcolorvisionmixer3_Click(sender As Object, e As EventArgs) Handles cmdstripcolorvisionmixer3.Click
        chanegbackcolor(sender)

    End Sub
    Private Sub cmdstripcolorvisionmixer3_Paint(sender As Object, e As PaintEventArgs) Handles cmdstripcolorvisionmixer3.Paint
        Label3.Text = colorvalue(sender.backcolor)
    End Sub
    Private Sub cmdstripcolorvisionmixer4_Click(sender As Object, e As EventArgs) Handles cmdstripcolorvisionmixer4.Click
        chanegbackcolor(sender)

    End Sub
    Private Sub cmdstripcolorvisionmixer4_Paint(sender As Object, e As PaintEventArgs) Handles cmdstripcolorvisionmixer4.Paint
        Label4.Text = colorvalue(sender.backcolor)
    End Sub

    Private Sub cmdPlayColor_Click(sender As Object, e As EventArgs) Handles cmdPlayColor.Click
        On Error Resume Next
        Dim ss As String = ""
        If c1.Checked Then ss = Label1.Text
        If c2.Checked Then ss = ss & " " & Label2.Text
        If c3.Checked Then ss = ss & " " & Label3.Text
        If c4.Checked Then ss = ss & " " & Label4.Text


        If rdoColorPGM.Checked Then
            CasparDevice.SendString("play 1-21 " & ss & " " & cmbtransition.Text & " " & ntransitionduration.Value)
            lblPGMSource.Text = ss
        Else
            CasparDevice.SendString("play 2-21 " & ss & " " & cmbtransition.Text & " " & ntransitionduration.Value)
            lblpreviewSource.Text = ss
        End If

    End Sub

    Private Sub GEyeDropper1_SelectedColorChanged(sender As Object, CurrColor As Color) Handles GEyeDropper1.SelectedColorChanged
        cmdstripcolorvisionmixer1.BackColor = GEyeDropper1.SelectedColor
    End Sub

    Private Sub GEyeDropper2_SelectedColorChanged(sender As Object, CurrColor As Color) Handles GEyeDropper2.SelectedColorChanged
        cmdstripcolorvisionmixer2.BackColor = GEyeDropper2.SelectedColor
    End Sub

    Private Sub GEyeDropper3_SelectedColorChanged(sender As Object, CurrColor As Color) Handles GEyeDropper3.SelectedColorChanged
        cmdstripcolorvisionmixer3.BackColor = GEyeDropper3.SelectedColor
    End Sub

    Private Sub GEyeDropper4_SelectedColorChanged(sender As Object, CurrColor As Color) Handles GEyeDropper4.SelectedColorChanged
        cmdstripcolorvisionmixer4.BackColor = GEyeDropper4.SelectedColor
    End Sub
    Private Sub cmdplayonfirschannel_Click(sender As Object, e As EventArgs) Handles cmdplayonfirschannel.Click
        CasparDevice.SendString(txtlayerproducer1.Text)
    End Sub

    Private Sub cmdplaycolorbar_Click(sender As Object, e As EventArgs) Handles cmdplaycolorbar.Click
        On Error Resume Next
        CasparDevice.SendString(txtplaycolorbar.Text)
    End Sub

    Private Sub cmdplaychroma_Click(sender As Object, e As EventArgs) Handles cmdplaychroma.Click
        On Error Resume Next
        CasparDevice.SendString(txtchromakey.Text & " " & cmbchromacolor.Text & " " & nchromathresholdcenter.Value & " " & nchromaspread.Value & " " & nchromaspill.Value)

    End Sub

    Private Sub nchromathresholdcenter_ValueChanged(sender As Object, e As EventArgs) Handles nchromathresholdcenter.ValueChanged, nchromaspread.ValueChanged, nchromaspill.ValueChanged
        On Error Resume Next
        CasparDevice.SendString(txtchromakey.Text & " " & cmbchromacolor.Text & " " & nchromathresholdcenter.Value & " " & nchromaspread.Value & " " & nchromaspill.Value)

    End Sub

    Private Sub cmdsource1pvw_Click(sender As Object, e As EventArgs) Handles cmdsource1pvw.Click
        On Error Resume Next
        CasparDevice.SendString("play 2-21 route://1-1 " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text & " loop")

        lblpreviewSource.Text = 1
    End Sub

    Private Sub cmdsource2pvw_Click(sender As Object, e As EventArgs) Handles cmdsource2pvw.Click
        On Error Resume Next
        CasparDevice.SendString("play 2-21 route://1-2 " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text & " loop")

        lblpreviewSource.Text = 2
    End Sub

    Private Sub cmdsource3pvw_Click(sender As Object, e As EventArgs) Handles cmdsource3pvw.Click
        On Error Resume Next
        CasparDevice.SendString("play 2-21 route://1-3 " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text & " loop")

        lblpreviewSource.Text = 3
    End Sub

    Private Sub cmdsource4pvw_Click(sender As Object, e As EventArgs) Handles cmdsource4pvw.Click
        On Error Resume Next
        CasparDevice.SendString("play 2-21 route://1-4 " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text & " loop")
        lblpreviewSource.Text = 4
    End Sub

    Private Sub cmdsource5pvw_Click(sender As Object, e As EventArgs) Handles cmdsource5pvw.Click
        On Error Resume Next
        CasparDevice.SendString("play 2-21 route://1-5 " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text & " loop")
        lblpreviewSource.Text = 5
    End Sub

    Private Sub cmdsource6pvw_Click(sender As Object, e As EventArgs) Handles cmdsource6pvw.Click
        On Error Resume Next
        CasparDevice.SendString("play 2-21 route://1-6 " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text & " loop")
        lblpreviewSource.Text = 6
    End Sub

    Private Sub cmdsource7pvw_Click(sender As Object, e As EventArgs) Handles cmdsource7pvw.Click
        On Error Resume Next
        CasparDevice.SendString("play 2-21 route://1-7 " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text & " loop")
        lblpreviewSource.Text = 7
    End Sub

    Private Sub cmdsource8pvw_Click(sender As Object, e As EventArgs) Handles cmdsource8pvw.Click
        On Error Resume Next
        CasparDevice.SendString("play 2-21 route://1-8 " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text & " loop")
        lblpreviewSource.Text = 8
    End Sub

    Private Sub cmdCut_Click(sender As Object, e As EventArgs) Handles cmdCut.Click
        On Error Resume Next

        CasparDevice.SendString("swap 1-21 2-21 transforms")

        changelabel()
    End Sub
    Private Sub cmdshowcasparcgwindowrecording_Click(sender As Object, e As EventArgs) Handles cmdshowcasparcgwindowrecording.Click
        On Error Resume Next
        SetProcessParentrecorder("casparcg", cmbcasparcgwindowtitlerecording, pnlrecording)

    End Sub

    Public parentedProcess1 As Process
    Public parentedProcess3 As Process
    Public Sub SetProcessParentrecorder(ByVal processName As String, ByVal cmb As ComboBox, ByVal pnl As Panel)
        On Error Resume Next
        Dim processes() As Process = Process.GetProcessesByName(processName)
        Dim iprocess As Integer

        For iprocess = 0 To processes.GetUpperBound(0)
            If processes(iprocess).MainWindowTitle = cmb.Text Then Exit For
        Next
        parentedProcess1 = processes(iprocess)
        SetParent(parentedProcess1.MainWindowHandle, pnl.Handle)
        SendMessage(parentedProcess1.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)

    End Sub
    Public Sub SetProcessParentrecorder3(ByVal processName As String, ByVal cmb As ComboBox, ByVal pnl As Panel)
        On Error Resume Next
        Dim processes() As Process = Process.GetProcessesByName(processName)
        Dim iprocess As Integer

        For iprocess = 0 To processes.GetUpperBound(0)
            If processes(iprocess).MainWindowTitle = cmb.Text Then Exit For
        Next
        parentedProcess3 = processes(iprocess)
        SetParent(parentedProcess3.MainWindowHandle, pnl.Handle)
        SendMessage(parentedProcess3.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)

    End Sub
    Private Sub cmdoutcasparcgwindowVM_Click(sender As Object, e As EventArgs) Handles cmdoutcasparcgwindowVM.Click
        On Error Resume Next
        If Not parentedProcess1 Is Nothing Then
            SetParent(parentedProcess1.MainWindowHandle, Nothing)
        End If
    End Sub

    Private Sub cmdInitialiseDummy_Click(sender As Object, e As EventArgs) Handles cmdInitialiseDummy.Click
        CasparDevice.SendString("mixer 1 clear")
        CasparDevice.SendString("play 1-21 black")
        CasparDevice.SendString("play 1-20 black")

        CasparDevice.SendString("play 1-1 Vision_Mixer/Source1")
        CasparDevice.SendString("play 1-2 Vision_Mixer/Source2")
        CasparDevice.SendString("play 1-3 Vision_Mixer/Source3")
        CasparDevice.SendString("play 1-4 Vision_Mixer/Source4")
        CasparDevice.SendString("play 1-5 Vision_Mixer/Source5")
        CasparDevice.SendString("play 1-6 Vision_Mixer/Source6")
        CasparDevice.SendString("play 1-7 Vision_Mixer/Source7")
        CasparDevice.SendString("play 1-8 Vision_Mixer/Source8")
        CasparDevice.SendString("play 1-9 [ndi] " & cmbNDI.Text)

        CasparDevice.SendString("play 3-1 route://1-1")
        CasparDevice.SendString("play 3-2 route://1-2")
        CasparDevice.SendString("play 3-3 route://1-3")
        CasparDevice.SendString("play 3-4 route://1-4")
        CasparDevice.SendString("play 3-5 route://1-5")
        CasparDevice.SendString("play 3-6 route://1-6")
        CasparDevice.SendString("play 3-7 route://1-7")
        CasparDevice.SendString("play 3-8 route://1-8")
        CasparDevice.SendString("play 3-9 route://1-9")
        'CasparDevice.SendString("play 2-9 route://1-21")

        CasparDevice.SendString("mixer 1-1 volume 0")
        CasparDevice.SendString("mixer 1-2 volume 0")
        CasparDevice.SendString("mixer 1-3 volume 0")
        CasparDevice.SendString("mixer 1-4 volume 0")
        CasparDevice.SendString("mixer 1-5 volume 0")
        CasparDevice.SendString("mixer 1-6 volume 0")
        CasparDevice.SendString("mixer 1-7 volume 0")
        CasparDevice.SendString("mixer 1-8 volume 0")
        CasparDevice.SendString("mixer 1-9 volume 0")

        CasparDevice.SendString("mixer 3 grid 3")

    End Sub

    Private Sub InitialiseActual_Click(sender As Object, e As EventArgs) Handles InitialiseActual.Click
        CasparDevice.SendString("mixer 1 clear")
        CasparDevice.SendString("play 1-21 black")
        CasparDevice.SendString("play 1-20 black")
        CasparDevice.SendString("play 1-1 " & cmbsource1.Text)
        CasparDevice.SendString("play 1-2 " & cmbsource2.Text)
        CasparDevice.SendString("play 1-3 " & cmbsource3.Text)
        CasparDevice.SendString("play 1-4 " & cmbsource4.Text)
        CasparDevice.SendString("play 1-5 " & cmbsource5.Text)
        CasparDevice.SendString("play 1-6 " & cmbsource6.Text)
        CasparDevice.SendString("play 1-7 " & cmbsource7.Text)
        CasparDevice.SendString("play 1-8 " & cmbsource8.Text)
        CasparDevice.SendString("play 1-9 [ndi] " & cmbNDI.Text)


        CasparDevice.SendString("mixer 1-1 volume 0")
        CasparDevice.SendString("mixer 1-2 volume 0")
        CasparDevice.SendString("mixer 1-3 volume 0")
        CasparDevice.SendString("mixer 1-4 volume 0")
        CasparDevice.SendString("mixer 1-5 volume 0")
        CasparDevice.SendString("mixer 1-6 volume 0")
        CasparDevice.SendString("mixer 1-7 volume 0")
        CasparDevice.SendString("mixer 1-8 volume 0")
        CasparDevice.SendString("mixer 1-9 volume 0")

    End Sub

    Private Sub cmdshowcasparcgwindowrecording3_Click(sender As Object, e As EventArgs) Handles cmdshowcasparcgwindowrecording3.Click
        On Error Resume Next
        SetProcessParentrecorder3("casparcg", cmbcasparcgwindowtitlerecording3, pnlrecording3)

    End Sub

    Private Sub cmdoutcasparcgwindowVM3_Click(sender As Object, e As EventArgs) Handles cmdoutcasparcgwindowVM3.Click
        On Error Resume Next
        If Not parentedProcess3 Is Nothing Then
            SetParent(parentedProcess3.MainWindowHandle, Nothing)
        End If
    End Sub

    Private Sub cmdRestartCasparwithConfig_Click(sender As Object, e As EventArgs) Handles cmdRestartCasparwithConfig.Click
        On Error Resume Next
        With frmmediaplayer
            Dim aa As New OpenFileDialog

            For Each p As System.Diagnostics.Process In System.Diagnostics.Process.GetProcessesByName("casparcg")
                p.Kill()
            Next

            Dim pnew As New ProcessStartInfo
            pnew.WorkingDirectory = Replace(initialpath, "/", "\")
            pnew.FileName = "casparcg.exe"
            pnew.Arguments = "Caspar_Cg_Configurations\21_vision_mixer\casparcg.config"
            'MsgBox("""" & Mid(aa.FileName, Len(ucUtility1.dgvutility.Rows(3).Cells(1).Value) + 1) & """").ToString()
            System.Diagnostics.Process.Start(pnew)
            'End If
        End With
    End Sub

    Private Sub cmdMix_Click(sender As Object, e As EventArgs) Handles cmdMix.Click
        On Error Resume Next

        Dim valueasinteger As Integer
        If Integer.TryParse(lblPGMSource.Text, valueasinteger) Then
            CasparDevice.SendString("play 2-21 route://1-" & lblPGMSource.Text & " mix " & ntransitionduration.Value)
        Else
            CasparDevice.SendString("play 2-21 " & lblPGMSource.Text & " mix " & ntransitionduration.Value)
        End If

        If Integer.TryParse(lblpreviewSource.Text, valueasinteger) Then

            CasparDevice.SendString("play 1-21 route://1-" & lblpreviewSource.Text & " mix " & ntransitionduration.Value)
        Else
            CasparDevice.SendString("play 1-21 " & lblpreviewSource.Text & " mix " & ntransitionduration.Value)


        End If

        changelabel()

    End Sub

    Sub changelabel()
        Dim aa1 As String = lblPGMSource.Text
        Dim aa2 As String = lblpreviewSource.Text
        lblPGMSource.Text = aa2
        lblpreviewSource.Text = aa1
    End Sub

    Private Sub cmdWipe_Click(sender As Object, e As EventArgs) Handles cmdWipe.Click
        On Error Resume Next

        Dim valueasinteger As Integer
        If Integer.TryParse(lblPGMSource.Text, valueasinteger) Then
            CasparDevice.SendString("play 2-21 route://1-" & lblPGMSource.Text & " " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text)
        Else
            CasparDevice.SendString("play 2-21 " & lblPGMSource.Text & " " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text)
        End If

        If Integer.TryParse(lblpreviewSource.Text, valueasinteger) Then

            CasparDevice.SendString("play 1-21 route://1-" & lblpreviewSource.Text & " " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text)
        Else
            CasparDevice.SendString("play 1-21 " & lblpreviewSource.Text & " " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text)


        End If

        changelabel()
    End Sub

    Private Sub gbcolorforvisionmixer_Enter(sender As Object, e As EventArgs) Handles gbcolorforvisionmixer.Enter

    End Sub

    Private Sub ucVisionMixer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdgetchannelinfo_Click(sender As Object, e As EventArgs) Handles cmdgetchannelinfo.Click
        On Error Resume Next
        dgvchannelinfo.Rows.Clear()
        Dim str As String
        str = "info 2"
        SendString(NetStream, str + vbCrLf)

        Threading.Thread.Sleep(100)

        Dim data(10024) As Byte
        NetStream.Read(data, 0, 10024)
        Dim xmlString As String = System.Text.Encoding.UTF8.GetString(data)

        xmlString = xmlString.Substring(xmlString.IndexOf("<"))

        Dim m_xmld As XmlDocument
        Dim m_nodelist As XmlNodeList
        Dim m_node As XmlNode
        'Create the XML Document
        m_xmld = New XmlDocument()
        'Load the Xml string
        m_xmld.LoadXml(xmlString)
        Dim ichannelinfo As Integer = 0

        m_nodelist = m_xmld.SelectNodes("/channel/stage/layers/layer")
        ichannelinfo = 0
        For Each m_node In m_nodelist
            If m_node.Item("frame-age").InnerText <> "0" And m_node.ChildNodes.Item(5).InnerText = "flash" Then
                dgvchannelinfo.Rows.Add()
                dgvchannelinfo.Rows(ichannelinfo).Cells(0).Value = m_node.Item("index").InnerText
                ichannelinfo = ichannelinfo + 1
            End If
        Next

    End Sub
    Private Sub dgvchannelinfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvchannelinfo.CellContentClick
        On Error Resume Next
        If e.ColumnIndex = 1 Then
            CasparDevice.SendString("play 1-" & dgvchannelinfo.CurrentRow.Cells(0).Value & " route://2-" & dgvchannelinfo.CurrentRow.Cells(0).Value)
        End If
        If e.ColumnIndex = 2 Then
            CasparDevice.SendString("stop 1-" & dgvchannelinfo.CurrentRow.Cells(0).Value)
        End If
    End Sub

    Private Sub cmdPlayallflash_Click(sender As Object, e As EventArgs) Handles cmdPlayallflash.Click
        For ddd = 0 To dgvchannelinfo.RowCount - 1
            CasparDevice.SendString("play 1-" & dgvchannelinfo.Rows(ddd).Cells(0).Value & " route://2-" & dgvchannelinfo.Rows(ddd).Cells(0).Value)
        Next
    End Sub

    Private Sub cmdStopallFlash_Click(sender As Object, e As EventArgs) Handles cmdStopallFlash.Click
        For ddd = 0 To dgvchannelinfo.RowCount - 1
            CasparDevice.SendString("stop 1-" & dgvchannelinfo.Rows(ddd).Cells(0).Value)
        Next
    End Sub

    Private Sub CmbNDI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNDI.SelectedIndexChanged

    End Sub

    Private Sub cmbNDI_Click(sender As Object, e As EventArgs) Handles cmbNDI.Click
        Dim str As String
        str = "ndi list"
        SendString(NetStream, str + vbCrLf)
        getresponse()
    End Sub
    Sub getresponse()
        On Error Resume Next
        Threading.Thread.Sleep(250)
        Dim data(10024) As Byte
        NetStream.Read(data, 0, 10024)
        Dim returndata As String = ""
        returndata = System.Text.Encoding.UTF8.GetString(data)
        Dim aa = Split(returndata, vbNewLine)

        cmbNDI.Items.Clear()


        For i = 1 To aa.Count - 3
            cmbNDI.Items.Add(Split(Mid(aa(i), 3), ")")(0) & ")" & """")
        Next

    End Sub

    Private Sub cmdsource9_Click(sender As Object, e As EventArgs) Handles cmdsource9.Click
        On Error Resume Next
        CasparDevice.SendString("play 1-21 route://1-9 " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text)

        lblPGMSource.Text = 9
    End Sub

    Private Sub Cmdsource9pvw_Click(sender As Object, e As EventArgs) Handles cmdsource9pvw.Click
        On Error Resume Next
        CasparDevice.SendString("play 2-21 route://1-9 " & cmbtransition.Text & " " & ntransitionduration.Value & " " & cmbtweentype.Text & " " & cmbdirection.Text & " loop")
        lblpreviewSource.Text = 9
    End Sub

    Private Sub cmdInitialiseNewNDISources_Click(sender As Object, e As EventArgs) Handles cmdInitialiseNewNDISources.Click
        On Error Resume Next
        CasparDevice.SendString("play 1-9 [ndi] " & cmbNDI.Text)
    End Sub
End Class
