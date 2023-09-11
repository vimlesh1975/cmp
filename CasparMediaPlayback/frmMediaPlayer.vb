Imports Svt.Caspar
Imports Svt.Network
Imports System.Net.Sockets
Imports System.Drawing.Text
Imports System.IO

Imports System.ComponentModel

Imports System.Text
Imports System.Runtime.InteropServices
Imports WeifenLuo.WinFormsUI.Docking

Public Class frmmediaplayer

    Dim strHelppath As String = "c:/casparcg/mydata/CMPHelp/CMPHelp.chm"

    Friend WithEvents ucLogo1 As ucLogo
    Friend WithEvents ucBreakingNews1 As ucBreakingNews
    Friend WithEvents ucPreview1 As ucPreview
    Friend WithEvents ucUtility1 As ucUtility
    Friend WithEvents ucTab1 As ucTab
    Friend WithEvents ucSwfPlayer1 As ucSwfPlayer
    Friend WithEvents ucAMCPcommands1 As ucAMCPcommands
    Friend WithEvents ucPlaylistSetting1 As ucPlaylistSetting


    Friend WithEvents ucCG1 As DockContent = ucCG
    Friend WithEvents ucTimers1 As DockContent = ucTimers
    Friend WithEvents ucCG21 As DockContent = ucCG2
    Friend WithEvents ucTwoLiner1 As DockContent = ucTwoLiner
    Friend WithEvents ucOneLiner1 As DockContent = ucOneLiner
    Friend WithEvents ucQuiz1 As DockContent = ucQuiz

    Friend WithEvents ucSrtPlayer1 As DockContent = ucSrtPlayer
    Friend WithEvents ucWaterMarking1 As DockContent = ucWaterMarking
    Friend WithEvents ucScroll1 As DockContent = ucScroll
    Friend WithEvents ucMixer1 As DockContent = ucMixer
    Friend WithEvents ucVisionMixer1 As DockContent = ucVisionMixer
    Friend WithEvents ucTwitter1 As DockContent = ucTwitter
    Friend WithEvents ucFaceBook1 As DockContent = ucFaceBook
    Friend WithEvents ucRemoteLogging1 As DockContent = ucRemoteLogging
    Friend WithEvents ucImageScroll1 As DockContent = ucImageScroll
    Friend WithEvents ucHTML1 As DockContent = ucHTML
    Friend WithEvents ucChannelInfo1 As ucChannelInfo
    Friend WithEvents ucStreaming1 As DockContent = ucStreaming
    Friend WithEvents ucStreamPlayer1 As DockContent = ucStreamPlayer
    Friend WithEvents ucMetadata1 As DockContent = ucMetadata
    Friend WithEvents ucHS1 As DockContent = ucHS
    Friend WithEvents ucHS21 As DockContent = ucHS2
    Friend WithEvents ucVS1 As DockContent = ucVS
    Friend WithEvents ucVS21 As DockContent = ucVS2
    Friend WithEvents ucHtmlScroller1 As DockContent = ucHtmlScroller

    Friend WithEvents ucWeather1 As DockContent = ucWeather
    Friend WithEvents ucRssFeed1 As DockContent = ucRssFeed
    Friend WithEvents ucUdpChat1 As DockContent = ucUdpChat
    Friend WithEvents ucPowerPoint1 As DockContent = ucPowerPoint
    Friend WithEvents ucTrimmer1 As DockContent = ucTrimmer
    Friend WithEvents ucSlowMotion1 As DockContent = ucSlowMotion
    Friend WithEvents ucTemplate1 As DockContent = ucTemplate
    Friend WithEvents ucCasparcgWindow1 As ucCasparcgWindow
    Friend WithEvents ucOffAirLogger1 As DockContent = ucOffAirLogger
    Friend WithEvents ucRecorder1 As DockContent = ucRecorder

    Friend WithEvents ucPlaylist1 As DockContent = ucPlaylist
    Friend WithEvents ucOSC1 As DockContent = ucOSC
    Friend WithEvents ucPlayFromAnyWhere1 As DockContent = ucPlayFromAnyWhere
    Friend WithEvents ucMultiBulletScroll1 As DockContent = ucMultiBulletScroll
    Friend WithEvents ucSceneScroller1 As DockContent = ucSceneScroller

    Friend WithEvents ucVlcStreamTester1 As DockContent = ucVlcStreamTester
    'ucVlcStreamTester1.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document

    Friend WithEvents UcCommandScheduler1 As DockContent = UcCommandScheduler
    Friend WithEvents UcCommandSchedulerDateWise1 As DockContent = UcCommandSchedulerDateWise

    Friend WithEvents ucOSD1 As DockContent = ucOSD
    Friend WithEvents ucdBFSMeter1 As DockContent = ucdBFSMeter
    Friend WithEvents ucMySqlTest1 As DockContent = ucMySqlTest
    Friend WithEvents ucHtmlTemplate1 As DockContent = ucHtmlTemplate
    Friend WithEvents ucWebSocketServer1 As DockContent = ucWebSocketServer
    Friend WithEvents ucSilenceDetector1 As DockContent = ucSilenceDetector
    Friend WithEvents UcPlaylistScheduler1 As UcPlaylistScheduler
    Friend WithEvents ucFullPageCaption1 As DockContent = ucFullPageCaption
    Friend WithEvents ucFourChannelPreview1 As DockContent = ucFourChannelPreview
    Friend WithEvents ucOffAirLoggers1 As DockContent = ucOffAirLoggers
    Friend WithEvents uc4ChannelRecorderAndTrimmer1 As DockContent = uc4ChannelRecorderAndTrimmer
    Friend WithEvents ucCCTV1 As DockContent = ucCCTV
    Friend WithEvents ucCricket1 As DockContent = ucCricket
    Friend WithEvents ucVDCPController1 As DockContent = ucVDCPController
    Friend WithEvents ucXdcamSoapClient1 As DockContent = ucXdcamSoapClient
    Friend WithEvents ucdc1 As DockContent = ucdc
    Friend WithEvents ucNG20151 As DockContent = ucNG2015
    Friend WithEvents ucWeightLifting1 As DockContent = ucWeightLifting
    Friend WithEvents ucSG20161 As DockContent = ucSG2016
    Friend WithEvents ucSlowMotion211 As DockContent = ucSlowMotion21
    Friend WithEvents ucMAM1 As DockContent = ucMAM
    Friend WithEvents ucSongSubtitling1 As DockContent = ucSongSubtitling
    Friend WithEvents Form11 As DockContent = Form1
    Friend WithEvents ucTemplatePlaylist1 As DockContent = ucTemplatePlaylist
    Friend WithEvents ucytlive1 As DockContent = ucytlive
    Friend WithEvents ucRCCAutomation1 As DockContent = ucRCCAutomation
    Friend WithEvents ucRccBall1 As DockContent = ucRccBall
    Friend WithEvents ucOnLineCG1 As DockContent = ucOnLineCG



    Public Sub animation1()
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & ucTemplate.cmblayertemplate.Text & " fill -1 0 1 1")
    End Sub
    Public Sub animationtoscreen()
        If ucCG2.chkanimationforhdvancg2.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & ucTemplate.cmblayertemplate.Text & " fill .12 0 .76 1 50 " & "easeoutexpo")

        Else
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & ucTemplate.cmblayertemplate.Text & " fill 0 0 1 1 50 " & "easeoutexpo")
        End If
    End Sub

    Sub connectionhandler()
        On Error Resume Next
        If CasparDevice.IsConnected = True Then
            cmdconnect.BackColor = Color.Green
            cmdconnect.Text = "Connected"
            ToolTip1.SetToolTip(cmdconnect, "Click to DisConnect")
            cmbhost.Enabled = False

            ucOSC.stoposcserver()
            'ucOSC1.oscstartandregister()
        Else
            cmdconnect.BackColor = Color.Red
            cmdconnect.Text = "DisConnected"
            ToolTip1.SetToolTip(cmdconnect, "Click to Connect")
            cmbhost.Enabled = True
            ucOSC.stoposcserver()
        End If
    End Sub

    Private Sub cmdconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdconnect.Click
        On Error Resume Next
        connecttocasparcg()
    End Sub
    Sub connecttocasparcg()
        On Error Resume Next
        CasparDevice.Settings.Hostname = Trim(cmbhost.Text)
        CasparDevice.Settings.Port = txtport.Text  '
        Dim client As New TcpClient
        If CasparDevice.IsConnected = False Then
            CasparDevice.Connect()
            'for tcp
            client.Connect(cmbhost.Text, txtport.Text)
            NetStream = client.GetStream()
            getversions() 'first get version then getpath important
            getpaths()

        Else
            CasparDevice.Disconnect()
            NetStream = Nothing
        End If

        If ServerVersion > 2.1 Then
            deinterlaced = " vf yadif=1:0"
        End If

    End Sub
    Sub getnumberofchannels(cmb As ComboBox)
        cmb.Items.Clear()
        For ichannels = 0 To CasparDevice.Channels.Count - 1
            cmb.Items.Add(ichannels)
        Next
    End Sub
    '---------------- for getting casparcg process directory
    <DllImport("Kernel32.dll")>
    Private Shared Function QueryFullProcessImageName(ByVal hProcess As IntPtr, ByVal flags As UInteger, ByVal text As StringBuilder, <Out> ByRef size As UInteger) As UInteger
    End Function
    Public Function GetPathToApp(ByVal proc As System.Diagnostics.Process) As String
        Dim pathToExe As String = String.Empty
        If proc IsNot Nothing Then
            Dim nChars As UInteger = 256
            Dim Buff As StringBuilder = New StringBuilder(CInt(nChars))
            Dim success As UInteger = QueryFullProcessImageName(proc.Handle, 0, Buff, nChars)
            If 0 <> success Then
                pathToExe = Buff.ToString()
            Else
                Dim [error] As Integer = Marshal.GetLastWin32Error()
                pathToExe = ("Error = " & [error] & " when calling GetProcessImageFileName")
            End If
        End If
        Return pathToExe
    End Function
    '---------------- for getting casparcg process directory
    Sub getpaths()
        On Error Resume Next

        Dim returndata As String = ""
        'If Mid(lblserverversion.Text, 1, 3) = "2.2" Or Mid(lblserverversion.Text, 1, 3) = "2.3" Then
        If ServerVersion = 2.2 Then
            Dim xmldoc As New System.Xml.XmlDocument()
            Dim xmlnode As System.Xml.XmlNodeList
            Dim fs As New FileStream(Path.GetDirectoryName(GetPathToApp(System.Diagnostics.Process.GetProcessesByName("casparcg")(0))) & "\" & "casparcg.config", FileMode.Open, FileAccess.Read)
            xmldoc.Load(fs)
            xmlnode = xmldoc.GetElementsByTagName("paths")
            returndata = xmlnode(0).InnerXml

        Else
            SendString(NetStream, "info paths" + vbCrLf)
            Dim data(10024) As Byte
            NetStream.Read(data, 0, 10024)
            returndata = System.Text.Encoding.UTF8.GetString(data)

        End If

        Dim a As Array = Split(returndata, "<media-path>")
        Dim b As Array = Split(a(1), "</media-path>")
        mediapath = Replace(b(0), "\/", "/")

        Dim c As Array = Split(returndata, "<template-path>")
        Dim d As Array = Split(c(1), "</template-path>")
        templatepath = Replace(d(0), "\/", "/")

        If ServerVersion = 2.2 Then
            initialpath = Path.GetDirectoryName(GetPathToApp(System.Diagnostics.Process.GetProcessesByName("casparcg")(0))) & "/"
        Else
            Dim e As Array = Split(returndata, "<initial-path>")
            Dim f As Array = Split(e(1), "</initial-path>")
            initialpath = f(0)
        End If

        Dim h As Array
        If ServerVersion = 2.0 Then
            Dim g As Array = Split(returndata, "<thumbnails-path>")
            h = Split(g(1), "</thumbnails-path>")
        Else
            Dim g As Array = Split(returndata, "<thumbnail-path>")
            h = Split(g(1), "</thumbnail-path>")
        End If
        thumbnailspath = h(0)

        Dim iii As Array = Split(returndata, "<log-path>")
        Dim jjj As Array = Split(iii(1), "</log-path>")
        logpath = jjj(0)

        Dim kkk As Array = Split(returndata, "<data-path>")
        Dim lll As Array = Split(kkk(1), "</data-path>")
        datapath = lll(0)

        Dim mmm As Array = Split(returndata, "<font-path>")
        Dim nnn As Array = Split(mmm(1), "</font-path>")
        fontpath = nnn(0)

        Dim xyz = Split(templatepath, ":")
        If xyz(1) = "" Then
            templatefullpath = initialpath & d(0)
        Else
            templatefullpath = templatepath
        End If

        Dim xyz1 = Split(mediapath, ":")
        If xyz1(1) = "" Then
            mediafullpath = initialpath & b(0)
        Else
            mediafullpath = mediapath
        End If

        Dim xyz2 = Split(thumbnailspath, ":")
        If xyz2(1) = "" Then
            thumbnailsfullpath = initialpath & h(0)
        Else
            thumbnailsfullpath = thumbnailspath
        End If
        Dim xyz3 = Split(logpath, ":")
        If xyz3(1) = "" Then
            logpath = initialpath & jjj(0)
        Else
            logpath = logpath
        End If

        Dim xyz4 = Split(datapath, ":")
        If xyz4(1) = "" Then
            datapath = initialpath & lll(0)
        Else
            datapath = datapath
        End If

        Dim xyz5 = Split(fontpath, ":")
        If xyz5(1) = "" Then
            fontpath = initialpath & nnn(0)
        Else
            fontpath = fontpath
        End If

        ucOffAirLogger.UcnewOffAirLogger1.txtmediadirectoryoal.Text = mediafullpath

        ucOffAirLoggers.UcnewOffAirLogger1.txtmediadirectoryoal.Text = mediafullpath
        ucOffAirLoggers.UcnewOffAirLogger2.txtmediadirectoryoal.Text = mediafullpath
        ucOffAirLoggers.UcnewOffAirLogger4.txtmediadirectoryoal.Text = mediafullpath
        ucOffAirLoggers.UcnewOffAirLogger3.txtmediadirectoryoal.Text = mediafullpath

        ucRecorder.lblRecordingFolder.Text = mediafullpath

        uc4ChannelRecorderAndTrimmer.UcnewRecorder1.lblRecordingFolder.Text = mediafullpath
        uc4ChannelRecorderAndTrimmer.UcnewRecorder2.lblRecordingFolder.Text = mediafullpath
        uc4ChannelRecorderAndTrimmer.UcnewRecorder3.lblRecordingFolder.Text = mediafullpath
        uc4ChannelRecorderAndTrimmer.UcnewRecorder4.lblRecordingFolder.Text = mediafullpath

        With ucTab1
            .UcUtility1.dgvutility.Rows(0).Cells(1).Value = mediafullpath
            .UcUtility1.dgvutility.Rows(1).Cells(1).Value = templatefullpath
            .UcUtility1.dgvutility.Rows(2).Cells(1).Value = thumbnailsfullpath
            .UcUtility1.dgvutility.Rows(3).Cells(1).Value = initialpath
            .UcUtility1.dgvutility.Rows(4).Cells(1).Value = logpath
            .UcUtility1.dgvutility.Rows(5).Cells(1).Value = datapath

            .UcUtility1.dgvutility.Rows(7).Cells(1).Value = fontpath
        End With

        ucPlaylist.initialisetvclips()
    End Sub
    Sub getversions()
        On Error Resume Next
        Dim returndata As String
        Dim data(10024) As Byte
        SendString(NetStream, "VERSION SERVER" + vbCrLf)
        'Threading.Thread.Sleep(150)
        NetStream.Read(data, 0, 10024)
        returndata = ""
        returndata = System.Text.Encoding.UTF8.GetString(data)
        Dim ddd As Array = Split(returndata, vbNewLine)
        lblserverversion.Text = ddd(1)
        ServerVersion = Val(Mid(ddd(1), 1, 3))

        SendString(NetStream, "VERSION FLASH" + vbCrLf)
        'Threading.Thread.Sleep(150)
        NetStream.Read(data, 0, 10024)
        returndata = ""
        returndata = System.Text.Encoding.UTF8.GetString(data)
        Dim eee As Array = Split(returndata, vbNewLine)
        lblflashversion.Text = eee(1)

        SendString(NetStream, "VERSION TEMPLATEHOST" + vbCrLf)
        ' Threading.Thread.Sleep(150)
        NetStream.Read(data, 0, 10024)
        returndata = ""
        returndata = System.Text.Encoding.UTF8.GetString(data)
        Dim fff As Array = Split(returndata, vbNewLine)
        lbltemplatehostversion.Text = fff(1)


        SendString(NetStream, "info" + vbCrLf)
        ' Threading.Thread.Sleep(150)
        NetStream.Read(data, 0, 10024)
        returndata = ""
        returndata = System.Text.Encoding.UTF8.GetString(data)
        Dim ggg As Array = Split(returndata, vbNewLine)

        For pp = 0 To ggg.Length - 1
            If ggg(pp).ToString.Contains("PLAYING") Then
                g_int_NumberOfChannels = Val(Mid(ggg(pp), 1, 1))
            End If
        Next

    End Sub
    Sub LoadModuleAtStartTime()

        ucPlaylist1.Show(DockPanel1, DockState.Document)

        ucCasparcgWindow1 = New ucCasparcgWindow
        Me.Controls.Add(ucCasparcgWindow1)
        ucCasparcgWindow1.Name = "ucCasparcgWindow1"
        Dim rs3 = New clsResizeableControl(ucCasparcgWindow1)

        ucTab1 = New ucTab
        Me.Controls.Add(ucTab1)
        ucTab1.Name = "ucTab1"
        Dim rs6 = New clsResizeableControl(ucTab1)

        ' vimlesh
    End Sub

    Private Sub caspar_media_playback_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Array.FindAll(Process.GetProcesses, Function(x) x.ProcessName.Contains("caspar_media_playback")).Count > 1 Then
            If MsgBox("caspar_media_playback is already running", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Else
                Application.Exit()
            End If
        End If
        Control.CheckForIllegalCrossThreadCalls = False
        AddHandler CasparDevice.ConnectionStatusChanged, AddressOf connectionhandler

        Try
            connecttocasparcg()
            LoadModuleAtStartTime()
            makeformfittoscreen() ' MAKE form fit to screen

            enumeratefontsforall()

            formname = Me.Text

            ucCasparcgWindow1.Location = casparwindowstartpoint ' New Point(680, 60)
            ucCasparcgWindow1.Size = casparwindowssize 'New Size(692, 620)

            ucTab1.Show()
            ucTab1.Left = ucCasparcgWindow1.Location.X
            ucTab1.Top = ucCasparcgWindow1.Height + pnlServer.Height

            ucCasparcgWindow1.SetProcessParent("casparcg")
            checkExampleFilesinUsersComputerAndCopyIfNotExists()
            ChannelName = Me.Text
            Modifychannelname()

            rdoplaylist.Checked = True

            fps = ucPlaylist.txtfps.Text

            lblProcessID2.Text = System.Diagnostics.Process.GetCurrentProcess().Id

            HelpProvider1.HelpNamespace = strHelppath

            ucTab1.UcChannelInfo1.getchannelinfo()
            'LoadLayout()

            EnsureBrowserEmulationEnabled("caspar_media_playback.exe")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



    End Sub

    ' windows messaging code-----------
    Private WithEvents BS As New BuildString

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case &H400
                BS.BuildString(m.LParam)
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub

    Public Sub SB_StringOK(ByVal Result As String) Handles BS.StringOK
        If Result = "move" Then

            Me.Left = -20 ' -12
            Me.Top = -27
            'Me.Refresh()
        Else

            ucPlaylistSetting1.setchannelnumber(CType(Result, Integer))
        End If

    End Sub

    Private Sub PopulateTreeView(ByVal dir As String, ByVal parentNode As TreeNode)
        On Error Resume Next
        Dim folder As String = String.Empty
        Dim folders() As String = Directory.GetDirectories(dir)
        If folders.Length <> 0 Then
            Dim childNode As TreeNode = Nothing
            For Each folder In folders
                childNode = New TreeNode(IO.Path.GetFileName(folder))
                parentNode.Nodes.Add(childNode)
                PopulateTreeView(folder, childNode)
            Next
        End If

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        My.Settings.Save()
        DockPanel1.SaveAsXml(lastlayout)

        'This is important! If you have a child process on your form, it will terminate along with your form if you do not set its parent to Nothing
        ucCasparcgWindow1.outcasparcgwindown()
        ucTab1.UcScreenConsumer1.cmdoutcasparcgwindowrecording.PerformClick()
        ucPowerPoint.outpptorexcell()


        ucUdpChat.receivingUdpClient.Close()
        ucUdpChat.ThreadReceive.Abort()

        ucVisionMixer.cmdoutcasparcgwindowVM.PerformClick()
        ucVisionMixer.cmdoutcasparcgwindowVM3.PerformClick()
        ApplicationExit()
    End Sub

    Sub enumeratefontsforall()
        On Error Resume Next
        Dim InstalledFonts As New InstalledFontCollection
        Dim fontfamilies() As FontFamily = InstalledFonts.Families()
        For Each fontFamily As FontFamily In fontfamilies
            cmbfontsforall.Items.Add(fontFamily.Name)
        Next
    End Sub

    Sub moduleplacement(aa As Object)
        With aa
            .Show()
            .Location = modulestartpoint

            .Size = modulesize
            .BringToFront()
        End With
    End Sub
    Sub makeformfittoscreen()
        On Error Resume Next
        Dim iWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim iHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = iWidth
        Me.Height = iHeight
        Me.Location = New System.Drawing.Point(0, 0)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdstopall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopall.Click
        On Error Resume Next
        stopall()
    End Sub
    Sub stopall()
        On Error Resume Next
        CasparDevice.SendString("clear " & cmbchannel.Text)
        CasparDevice.SendString("mixer " & cmbchannel.Text & " clear")
        ucPlaylist.chkplaylistlock.Checked = False

        stopalltimer()

        ucScroll.UcBreakingNews1.tmrshowdata.Enabled = False
        ucScroll.tmrshowdatascroll.Enabled = False

        ucPowerPoint.removefilesytemwatcherforpowerpoint()

        ucOffAirLogger.UcnewOffAirLogger1.stoprecordoal()
        ucOSC.stoposcserver()
        ucPlaylist.chkcheckfilesinplaylist.Checked = False

        ucPlaylist.tmrnextclip.Enabled = False
        ucPlaylist.tmrfornotskiping.Enabled = False

        ucSrtPlayer.tmrsrt.Enabled = False


    End Sub



    Private Sub cmbfontsforall_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfontsforall.SelectedIndexChanged, nfontsizeforall.ValueChanged
        On Error Resume Next
        Dim myfont As New Font(cmbfontsforall.Text, nfontsizeforall.Value, FontStyle.Bold)
        ucOneLiner.dgvonelinesuper.Font = myfont
        ucTwoLiner.dgvtwolinesuper.Font = myfont
        ucBreakingNews1.dgvbreakingnews.Font = myfont
        ucScroll.dgvscroll.Font = myfont
        ucScroll.UcBreakingNews1.dgvbreakingnews.Font = myfont

        ucMultiBulletScroll.dgvscroll.Font = myfont
        ucSceneScroller.txtcrawl2.Font = myfont

        ucCG2.dgvinfocg2.Font = myfont

        ucPlaylist.dgv1.Columns("File_Name").DefaultCellStyle.Font = New Font("Arial Black", nfontsizeforall.Value, FontStyle.Regular)
        ucPlaylist.dgv1.Columns("Start_Time").DefaultCellStyle.Font = New Font("Arial Black", nfontsizeforall.Value, FontStyle.Regular)
        ucPlaylist.dgv1.Columns("Clip_Duration").DefaultCellStyle.Font = New Font("Arial Black", nfontsizeforall.Value, FontStyle.Regular)

        ucPlaylist.dgvclips.Columns("File_Name").DefaultCellStyle.Font = New Font("Arial Black", nfontsizeforall.Value, FontStyle.Regular)


        ucPlaylist.tvclips.Font = New Font("Arial Black", nfontsizeforall.Value, FontStyle.Regular)


        'dgvanytemplate.Font = myfont
        ucTemplate.dgvanytemplate.Columns(1).DefaultCellStyle.Font = myfont
        ucTemplate.dgvrundown.Columns(0).DefaultCellStyle.Font = myfont

        ucRssFeed.dgvrss.Font = myfont

        ucHS.txtcrawl.Font = New Font(ucHS.cmbfonths1.Text, nfontsizeforall.Value, FontStyle.Regular)
        ucHS2.txtcrawl2.Font = New Font(ucHS2.cmbfonths2.Text, nfontsizeforall.Value, FontStyle.Regular)
        ucVS.txtcrawlv.Font = New Font(ucVS.cmbfontvs.Text, nfontsizeforall.Value, FontStyle.Regular)
        ucHtmlScroller.txtcrawlhtmlscroll.Font = New Font(ucHtmlScroller.cmbfonthtmlscroll.Text, nfontsizeforall.Value, FontStyle.Regular)

        For Each cc As Control In ucCG.gbcg.Controls
            If cc.GetType.ToString = "System.Windows.Forms.TextBox" Then
                If cc.Name <> "txtTemplateDirectoryCg" Then
                    cc.Font = myfont
                End If

            End If
        Next

        For Each cc As Control In ucWeather.gbweather.Controls
            If cc.GetType.ToString = "System.Windows.Forms.TextBox" Then cc.Font = myfont
        Next
    End Sub

    Sub animation2()
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & ucTemplate.cmblayertemplate.Text & " fill 1 0 1 1 50 " & "easeoutexpo")
    End Sub
    Sub mediafilesforvisionmixer()

        On Error Resume Next

        ucdBFSMeter.cmbmediaforaudiotest.Items.Clear()
        ucMixer.cmbmediaforfilter.Items.Clear()

        CasparDevice.RefreshMediafiles()
        Threading.Thread.Sleep(250)
        With ucVisionMixer

            .cmbsource1.Items.Clear()
            .cmbsource2.Items.Clear()
            .cmbsource3.Items.Clear()
            .cmbsource4.Items.Clear()
            For Each File In CasparDevice.Mediafiles
                .cmbsource1.Items.Add(Replace(File.ToString, "\", "/"))
                .cmbsource2.Items.Add(Replace(File.ToString, "\", "/"))
                .cmbsource3.Items.Add(Replace(File.ToString, "\", "/"))
                .cmbsource4.Items.Add(Replace(File.ToString, "\", "/"))
                ucdBFSMeter.cmbmediaforaudiotest.Items.Add(Replace(File.ToString, "\", "/"))
                ucMixer.cmbmediaforfilter.Items.Add(Replace(File.ToString, "\", "/"))
            Next
        End With
    End Sub

    Private Sub cmdrefreshmediaclipsforvisionmixer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        mediafilesforvisionmixer()
    End Sub

    Sub checkExampleFilesinUsersComputerAndCopyIfNotExists()
        On Error Resume Next
        If Directory.Exists(templatefullpath & "/CMP") = False Then
            copytemplates()
        End If

        If File.Exists(mediafullpath & "/kabhi_kabhi.mp4") = False Then
            copymedia()
        End If

        If File.Exists(initialpath & "/Caspar_Cg_Configurations/22_slow_motion/casparcg.config") = False Then
            CopyConfigFiles()
        End If
    End Sub
    Sub copytemplates()
        On Error Resume Next
        My.Computer.FileSystem.CopyDirectory("C:\Casparcg\CMP", templatefullpath & "/CMP", True)
        FileCopy("c:/casparcg/cg20.fth.pal", templatefullpath & "/cg20.fth.pal")
    End Sub
    Sub copymedia()
        On Error Resume Next
        With ucUtility1
            FileCopy("c:/casparcg/_media/logobkdg.swf", mediafullpath & "/logobkdg.swf")
            FileCopy("c:/casparcg/_media/VERTICAL.png", mediafullpath & "/VERTICAL.png")
            FileCopy("c:/casparcg/_media/VERTICALPSD.psd", mediafullpath & "/VERTICALPSD.psd")
            FileCopy("c:/casparcg/_media/HORIZONTAL.png", mediafullpath & "/HORIZONTAL.png")

            FileCopy("c:/casparcg/_media/VERTICAL_RANGOLI.png", mediafullpath & "/VERTICAL_RANGOLI.png")
            FileCopy("c:/casparcg/_media/VERTICAL_RANGOLI.psd", mediafullpath & "/VERTICAL_RANGOLI.psd")

            FileCopy("c:/casparcg/_media/HORIZONTALPSD.psd", mediafullpath & "/HORIZONTALPSD.psd")

            FileCopy("c:/casparcg/_media/jpg.jpg", mediafullpath & "/jpg.jpg")
            FileCopy("c:/casparcg/_media/png.png", mediafullpath & "/png.png")

            FileCopy("c:/casparcg/_media/jpg.jpg", mediafullpath & "/jpg1.jpg")
            FileCopy("c:/casparcg/_media/png.png", mediafullpath & "/png1.png")
            FileCopy("c:/casparcg/_media/jpg.jpg", mediafullpath & "/jpg2.jpg")
            FileCopy("c:/casparcg/_media/png.png", mediafullpath & "/png2.png")

            FileCopy("c:/casparcg/_media/color_bar.png", mediafullpath & "/color_bar.png")
            FileCopy("c:/casparcg/_media/marathi.swf", mediafullpath & "/marathi.swf")
            FileCopy("c:/casparcg/_media/anchor.png", mediafullpath & "/anchor.png")
            FileCopy("c:/casparcg/_media/big_photo_bg.avi", mediafullpath & "/big_photo_bg.avi")
            FileCopy("c:/casparcg/_media/scroll_loop.mp4", mediafullpath & "/scroll_loop.mp4")
            FileCopy("c:/casparcg/_media/tone.mp4", mediafullpath & "/tone.mp4")

            FileCopy("c:/casparcg/_media/kabhi_kabhi.mp4", mediafullpath & "/kabhi_kabhi.mp4")

            FileCopy("c:/casparcg/_media/hd_frame.png", mediafullpath & "/hd_frame.png")
            FileCopy("c:/casparcg/_media/sd_frame.png", mediafullpath & "/sd_frame.png")

            FileCopy("c:/casparcg/_media/hello_doc.psd", mediafullpath & "/hello_doc.psd")
            FileCopy("c:/casparcg/_media/hello_doc.png", mediafullpath & "/hello_doc.png")

            ' for default media
            FileCopy("c:/casparcg/_media/go1080p25.mp4", mediafullpath & "/go1080p25.mp4")
            FileCopy("c:/casparcg/_media/AMB.mp4", mediafullpath & "/AMB.mp4")
            FileCopy("c:/casparcg/_media/CG1080i50.mp4", mediafullpath & "/CG1080i50.mp4")
            FileCopy("c:/casparcg/_media/CG1080i50_A.mp4", mediafullpath & "/CG1080i50_A.mp4")
            FileCopy("c:/casparcg/_media/WIPE.mov", mediafullpath & "/WIPE.mov")
            FileCopy("c:/casparcg/_media/cricket2.mp4", mediafullpath & "/cricket2.mp4")
        End With

    End Sub
    Sub CopyConfigFiles()
        On Error Resume Next
        My.Computer.FileSystem.CopyDirectory("C:\casparcg\mydata\Caspar_Cg_Configurations", initialpath & "/Caspar_Cg_Configurations", True)
    End Sub

    Sub stopalltimer()
        On Error Resume Next
        Dim timer = Me.components.Components.OfType(Of IComponent)().Where(Function(p) p.[GetType]().FullName = "System.Windows.Forms.Timer").ToList()
        For Each cmd In timer
            If Not cmd Is Nothing Then
                Dim tmp As Timer = DirectCast(cmd, Timer)
                tmp.Enabled = False
                tmp.Stop()
            End If
        Next
        ucTimers.tmrclipcountdown.Enabled = False
        ucCasparcgWindow1.tmraudio.Enabled = True 'but spare audio bar and time
        tmrGeneralInfo.Enabled = True 'but spare 
        ucPlaylist.tmrduration.Enabled = True 'but spare 
    End Sub

    Private Sub cmblayervideo_TextChanged(sender As Object, e As EventArgs) Handles cmblayervideo.TextChanged
        On Error Resume Next
        g_int_PlaylistLayer = Int(cmblayervideo.Text)
        ucOSC.stoposcserver()
    End Sub

    Private Sub cmblayervideo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblayervideo.SelectedIndexChanged
        'DUMMY CODE
    End Sub

    Sub Modifychannelname()
        On Error Resume Next
        If Me.Text <> "" Then
            Me.Text = ChannelName & "                              " & cmbhost.Text & "       Channel " & cmbchannel.Text
            g_int_ChannelNumber = Int(cmbchannel.Text)
            ucOSC.stoposcserver()
        End If

    End Sub
    Private Sub cmbchannel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbchannel.SelectedIndexChanged, cmbhost.LostFocus
        'DUMMY CODE
        'On Error Resume Next
        ' Modifychannelname()
    End Sub
    Private Sub cmbchannel_TextChanged(sender As Object, e As EventArgs) Handles cmbchannel.TextChanged
        'DUMMY CODE
        On Error Resume Next
        Modifychannelname()
    End Sub

    Private Sub tmrclipcountdown_Tick(sender As Object, e As EventArgs)
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", mstohms(clipsleftduration * 1000))

        Dim aa1 As Array = Split(Replace(ucCasparcgWindow1.lblplaying.Text, "\", "/"), "/")
        CasparCGDataCollection.SetData("f1", Split((aa1(aa1.Length - 1)), ".")(0))

        Dim aa2 As Array = Split(Replace(seconndchannelloopvideoname, "\", "/"), "/")
        CasparCGDataCollection.SetData("f2", Split((aa2(aa2.Length - 1)), ".")(0))

        CasparDevice.Channels(cmbchannel.Text).CG.Update(12, 12, CasparCGDataCollection)
    End Sub

    Private Sub cmdyadif10_Click(sender As Object, e As EventArgs) Handles cmdyadif10.Click
        On Error Resume Next
        If Mid(lblserverversion.Text, 1, 3) = "2.2" Or Mid(lblserverversion.Text, 1, 3) = "2.3" Then
            CasparDevice.SendString("play " & cmbchannel.Text & "-" & cmblayervideo.Text & " " & """" & ModifyFilename(ucOSC.dgvosc.Rows(56).Cells(1).Value) & """" & " seek " & (ucOSC.dgvosc.Rows(6).Cells(1).Value + 3) * 2 & " vf yadif=1:0")
        Else
            CasparDevice.SendString("play " & cmbchannel.Text & "-" & cmblayervideo.Text & " " & """" & ModifyFilename(ucOSC.dgvosc.Rows(8).Cells(1).Value) & """" & " seek " & ucOSC.dgvosc.Rows(6).Cells(1).Value + 12 & " filter yadif=1:0")

        End If
    End Sub

    Private Sub cmdyadif11_Click(sender As Object, e As EventArgs) Handles cmdyadif11.Click
        On Error Resume Next
        If Mid(lblserverversion.Text, 1, 3) = "2.2" Or Mid(lblserverversion.Text, 1, 3) = "2.3" Then
            CasparDevice.SendString("play " & cmbchannel.Text & "-" & cmblayervideo.Text & " " & """" & ModifyFilename(ucOSC.dgvosc.Rows(56).Cells(1).Value) & """" & " seek " & (ucOSC.dgvosc.Rows(6).Cells(1).Value + 3) * 2 & " vf yadif=1:1")

        Else
            CasparDevice.SendString("play " & cmbchannel.Text & "-" & cmblayervideo.Text & " " & """" & ModifyFilename(ucOSC.dgvosc.Rows(8).Cells(1).Value) & """" & " seek " & ucOSC.dgvosc.Rows(6).Cells(1).Value + 12 & " filter yadif=1:1")

        End If

    End Sub


    Private Sub mnuCMPSlowMotionInJStarServer_Click(sender As Object, e As EventArgs) Handles mnuCMPSlowMotionInJStarServer.Click
        ucSlowMotion1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub mnuCMPSlowMotionInServer21_Click(sender As Object, e As EventArgs) Handles mnuCMPSlowMotionInServer21.Click
        ucSlowMotion211.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub mnuCMPElection_Click(sender As Object, e As EventArgs) Handles mnuCMPElection.Click
        Process.Start("C:\Program Files (x86)\Doordarshan\Election2019Setup\Election2019.exe")
    End Sub


    Private Sub mnuCMPSRTPlayer_Click(sender As Object, e As EventArgs) Handles mnuCMPSRTPlayer.Click
        ucSrtPlayer1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub mnuCMPSongSubTitling_Click(sender As Object, e As EventArgs) Handles mnuCMPSongSubTitling.Click
        ucSongSubtitling1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub mnuCMPFacebook_Click(sender As Object, e As EventArgs) Handles mnuCMPFacebook.Click
        ucFaceBook1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub mnuCMPTwitter_Click(sender As Object, e As EventArgs) Handles mnuCMPTwitter.Click
        ucTwitter1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub mnuCMPHTMLorInternet_Click(sender As Object, e As EventArgs) Handles mnuCMPHTMLorInternet.Click
        ucHTML1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub mnuCMPVisionMixer_Click(sender As Object, e As EventArgs) Handles mnuCMPVisionMixer.Click
        ucVisionMixer1.Show(DockPanel1, DockState.Document)
    End Sub


    Private Sub mnuCMPMixer_Click(sender As Object, e As EventArgs) Handles mnuCMPMixer.Click
        ucMixer1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub mnuCMPTimers_Click(sender As Object, e As EventArgs) Handles mnuCMPTimers.Click
        ucTimers1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub mnuCMPStreaming_Click(sender As Object, e As EventArgs) Handles mnuCMPStreaming.Click
        ucStreaming1.Show(DockPanel1, DockState.Document)
    End Sub


    Private Sub mnuCMPRemoteLogging_Click(sender As Object, e As EventArgs) Handles mnuCMPRemoteLogging.Click
        ucRemoteLogging1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub mnuCMPCopyExampleTemplates_Click(sender As Object, e As EventArgs) Handles mnuCMPCopyExampleTemplates.Click
        On Error Resume Next
        If MsgBox("Are you sure to copy C:\Casparcg\CMP to your template folder", vbYesNo) = MsgBoxResult.Yes Then
            copytemplates()
        End If
    End Sub

    Private Sub mnuCMPCopyExampleMedia_Click(sender As Object, e As EventArgs) Handles mnuCMPCopyExampleMedia.Click
        On Error Resume Next
        If MsgBox("Are you sure to copy example media files to media folder", vbYesNo) = MsgBoxResult.Yes Then
            copymedia()

        End If
    End Sub

    Private Sub mnuCMPResetSettings_Click(sender As Object, e As EventArgs) Handles mnuCMPResetSettings.Click
        My.Settings.Reset()
    End Sub

    Private Sub mnuCMPAddScreen_Click(sender As Object, e As EventArgs) Handles mnuCMPAddScreen.Click
        On Error Resume Next
        'CasparDevice.SendString("add " & cmbchannel.Text & " screen")
        'Threading.Thread.Sleep(1000)
        'ucCasparcgWindow1.SetProcessParent("casparcg")  ' Removed in support of multichannel recoder

    End Sub

    Private Sub mnuCMPRemoveScreen_Click(sender As Object, e As EventArgs) Handles mnuCMPRemoveScreen.Click
        On Error Resume Next
        CasparDevice.SendString("remove " & cmbchannel.Text & " screen")
    End Sub

    Private Sub mnuCMPRestartCasparcgServer_Click(sender As Object, e As EventArgs) Handles mnuCMPRestartCasparcgServer.Click
        On Error Resume Next
        For Each p As System.Diagnostics.Process In System.Diagnostics.Process.GetProcessesByName("casparcg")
            p.Kill()
        Next
        Dim pnew As New ProcessStartInfo
        pnew.WorkingDirectory = Replace(initialpath, "/", "\")
        pnew.FileName = "casparcg.exe"
        System.Diagnostics.Process.Start(pnew)
    End Sub

    Private Sub mnuCMPQuitCasparcgServer_Click(sender As Object, e As EventArgs) Handles mnuCMPQuitCasparcgServer.Click
        On Error Resume Next
        CasparDevice.SendString("kill")
    End Sub

    Private Sub mnuCMPCasparcgDiagnosisWndow_Click(sender As Object, e As EventArgs) Handles mnuCMPCasparcgDiagnosisWndow.Click
        On Error Resume Next
        CasparDevice.SendString("diag")
    End Sub

    Private Sub mnuCMPClearTypeSwitch_Click(sender As Object, e As EventArgs) Handles mnuCMPClearTypeSwitch.Click
        On Error Resume Next
        Dim process As System.Diagnostics.Process = New System.Diagnostics.Process
        process.StartInfo.FileName = "c:/casparcg/mydata/ClearTypeSwitch/ClearTypeSwitch.exe"
        process.StartInfo.Verb = "open"
        process.Start()
    End Sub
    Private Sub mnuCMPEditConfigFile_Click(sender As Object, e As EventArgs) Handles mnuCMPEditConfigFile.Click
        On Error Resume Next
        System.Diagnostics.Process.Start("notepad.exe", initialpath & "Casparcg.config")
    End Sub

    Private Sub mnuCMPPALSD_Click(sender As Object, e As EventArgs) Handles mnuCMPPALSD.Click

        On Error Resume Next
        CasparDevice.SendString("set " & cmbchannel.Text & " mode pal")
    End Sub
    Private Sub mnuCMPHD108050i_Click(sender As Object, e As EventArgs) Handles mnuCMPHD108050i.Click

        On Error Resume Next
        CasparDevice.SendString("set " & cmbchannel.Text & " mode 1080i5000")
    End Sub

    Private Sub mnuCMPUpdatedSoftwareLink_Click(sender As Object, e As EventArgs) Handles mnuCMPUpdatedSoftwareLink.Click
        On Error Resume Next
        System.Diagnostics.Process.Start("https://casparcgforum.org/t/simple-video-playout/61")
    End Sub

    Private Sub mnuCMPOSC_Click(sender As Object, e As EventArgs) Handles mnuCMPOSC.Click
        ucOSC1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub tmrGC_Tick(sender As Object, e As EventArgs) Handles tmrGC.Tick
        On Error Resume Next
        GC.Collect()
    End Sub



    Private Sub CommandSchedulerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommandSchedulerToolStripMenuItem.Click
        UcCommandScheduler1.Show(DockPanel1, DockState.Document)
    End Sub
    Private Sub CommandSchedulerDateWiseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommandSchedulerDateWiseToolStripMenuItem.Click
        UcCommandSchedulerDateWise1.Show(DockPanel1, DockState.Document)
    End Sub
    Private Sub NewInstanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewInstanceToolStripMenuItem.Click
        System.Diagnostics.Process.Start("caspar_media_playback.exe")
    End Sub

    Private Sub TrimmerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrimmerToolStripMenuItem.Click
        ucTrimmer1.Show(DockPanel1, DockState.Document)
        ucTrimmer1.DockAreas = DockAreas.Document
    End Sub

    Private Sub RecordingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordingToolStripMenuItem.Click
        rdoRecording.Select()
    End Sub

    Private Sub OffAirLoggerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OffAirLoggerToolStripMenuItem.Click
        rdooffairlogger.Select()
    End Sub

    Private Sub StreamTesterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StreamTesterToolStripMenuItem.Click

        ucVlcStreamTester1.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document
        ucVlcStreamTester1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub ExitApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitApplicationToolStripMenuItem.Click
        ApplicationExit()
    End Sub

    Sub ApplicationExit()
        Application.Exit()
        System.Diagnostics.Process.GetCurrentProcess().Kill()
        System.Diagnostics.Process.GetProcessById(lblProcessID2.Text).Kill()
    End Sub

    Private Sub CustomeModulesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        rdoCustomControls.Select()
    End Sub

    Private Sub PositionAndSizeControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PositionAndSizeControlToolStripMenuItem.Click
        Dim ucPositionAndSize1 As New ucPositionAndSize
        Me.Controls.Add(ucPositionAndSize1)
        Dim rs1 As New clsResizeableControlnew(ucPositionAndSize1)
        ucPositionAndSize1.BringToFront()

        ucPositionAndSize1.Location = PointToClient(cmsCustomeModules.Location)
    End Sub

    Private Sub SystemAudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemAudioToolStripMenuItem.Click
        Dim ucSystemAudio1 As New ucSystemAudio
        Me.Controls.Add(ucSystemAudio1)
        Dim rs3 As New clsResizeableControlnew(ucSystemAudio1)
        ucSystemAudio1.BringToFront()
        ucSystemAudio1.Location = PointToClient(cmsCustomeModules.Location)
    End Sub

    Private Sub DifferentConfigFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DifferentConfigFilesToolStripMenuItem.Click
        On Error Resume Next
        System.Diagnostics.Process.Start("explorer.exe", "C:\casparcg\mydata\Caspar_Cg_Configurations\")
    End Sub


    Private Sub FourChannelPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FourChannelPreviewToolStripMenuItem.Click
        On Error Resume Next
        'frmFourChannelPreview.Show()
        ucFourChannelPreview1.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document
        ucFourChannelPreview1.Show(DockPanel1, DockState.Document)
    End Sub
    Private Sub cmdIMX_Click(sender As Object, e As EventArgs) Handles cmdIMX.Click
        On Error Resume Next

        If Mid(lblserverversion.Text, 1, 3) = "2.2" Or Mid(lblserverversion.Text, 1, 3) = "2.3" Then
            CasparDevice.SendString("play " & cmbchannel.Text & "-" & cmblayervideo.Text & " " & """" & ModifyFilename(ucOSC.dgvosc.Rows(56).Cells(1).Value) & """" & " seek " & (ucOSC.dgvosc.Rows(6).Cells(1).Value + 3) * 2 & " vf crop=720:576:0:32")
        Else
            CasparDevice.SendString("play " & cmbchannel.Text & "-" & cmblayervideo.Text & " " & """" & ModifyFilename(ucOSC.dgvosc.Rows(8).Cells(1).Value) & """" & " seek " & ucOSC.dgvosc.Rows(6).Cells(1).Value + 12 & " filter crop=720:576:0:32")
        End If
    End Sub

    Private Sub DBFSMeter16ChannelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DBFSMeter16ChannelToolStripMenuItem.Click
        On Error Resume Next
        ucdBFSMeter1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub MySqlTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MySqlTestToolStripMenuItem.Click
        On Error Resume Next
        ucMySqlTest1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub mnuCMPRestartwithConfigFile_Click(sender As Object, e As EventArgs) Handles mnuCMPRestartwithConfigFile.Click
        On Error Resume Next
        Dim aa As New OpenFileDialog
        aa.Filter = "config files (*.config)|*.config|All files (*.*)|*.*"
        aa.InitialDirectory = Replace(initialpath, "/", "\")
        If aa.ShowDialog = DialogResult.OK Then
            For Each p As System.Diagnostics.Process In System.Diagnostics.Process.GetProcessesByName("casparcg")
                p.Kill()
            Next

            Dim pnew As New ProcessStartInfo
            pnew.WorkingDirectory = Replace(initialpath, "/", "\")
            pnew.FileName = "casparcg.exe"
            pnew.Arguments = """" & Mid(aa.FileName, Len(initialpath) + 1) & """"    ' "casparcg.config"

            System.Diagnostics.Process.Start(pnew)
        End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        On Error Resume Next
        Help.ShowHelp(Me, HelpProvider1.HelpNamespace, HelpNavigator.TableOfContents)
    End Sub

    Private Sub pnlServer_DoubleClick(sender As Object, e As EventArgs) Handles pnlServer.DoubleClick
        Changebackcolor(sender)
    End Sub

    Private Sub gbPannel_DoubleClick(sender As Object, e As EventArgs) Handles gbPannel.DoubleClick
        Changebackcolor(sender)
    End Sub


    Private Sub ConsumerEvent(sender As Object, e As EventArgs) Handles _
                                                                            Add_Ouput_Fill_decklink_1.Click,
                                                                            Add_Ouput_Fill_decklink_2.Click,
                                                                            Add_Ouput_Fill_decklink_3.Click,
                                                                            Add_Ouput_Fill_decklink_4.Click,
                                                                            Add_Ouput_Fill_decklink_5.Click,
                                                                            Add_Ouput_Fill_decklink_6.Click,
                                                                            Add_Ouput_Fill_decklink_7.Click,
                                                                            Add_Ouput_Fill_decklink_8.Click,
                                                                            Add_Ouput_Fill_Bluefish_1.Click,
                                                                            Add_Ouput_Fill_Bluefish_2.Click,
                                                                            Add_Ouput_Fill_Bluefish_3.Click,
                                                                            Add_Ouput_Fill_Bluefish_4.Click,
                                                                            Add_Ouput_Fill_Bluefish_5.Click,
                                                                            Add_Ouput_Fill_Bluefish_6.Click,
                                                                            Add_Ouput_Fill_Bluefish_7.Click,
                                                                            Add_Ouput_Fill_Bluefish_8.Click,
                                                                            Add_Ouput_key_Decklink_1.Click,
                                                                            Add_Ouput_key_Decklink_2.Click,
                                                                            Add_Ouput_key_Decklink_3.Click,
                                                                            Add_Ouput_key_Decklink_4.Click,
                                                                            Add_Ouput_key_Decklink_5.Click,
                                                                            Add_Ouput_key_Decklink_6.Click,
                                                                            Add_Ouput_key_Decklink_7.Click,
                                                                            Add_Ouput_key_Decklink_8.Click,
                                                                            Add_Ouput_key_Bluefish_1.Click,
                                                                            Add_Ouput_key_Bluefish_2.Click,
                                                                            Add_Ouput_key_Bluefish_3.Click,
                                                                            Add_Ouput_key_Bluefish_4.Click,
                                                                            Add_Ouput_key_Bluefish_5.Click,
                                                                            Add_Ouput_key_Bluefish_6.Click,
                                                                            Add_Ouput_key_Bluefish_7.Click,
                                                                            Add_Ouput_key_Bluefish_8.Click,
                                                                            Remove_Ouput__decklink_1.Click,
                                                                            Remove_Ouput__decklink_2.Click,
                                                                            Remove_Ouput__decklink_3.Click,
                                                                            Remove_Ouput__decklink_4.Click,
                                                                            Remove_Ouput__decklink_5.Click,
                                                                            Remove_Ouput__decklink_6.Click,
                                                                            Remove_Ouput__decklink_7.Click,
                                                                            Remove_Ouput__decklink_8.Click,
                                                                            Remove_Output__Bluefish_1.Click,
                                                                            Remove_Output__Bluefish_2.Click,
                                                                            Remove_Output__Bluefish_3.Click,
                                                                            Remove_Output__Bluefish_4.Click,
                                                                            Remove_Output__Bluefish_5.Click,
                                                                            Remove_Output__Bluefish_6.Click,
                                                                            Remove_Output__Bluefish_7.Click,
                                                                            Remove_Output__Bluefish_8.Click,
                                                                            Play_Input__decklink_1.Click,
                                                                            Play_Input__decklink_2.Click,
                                                                            Play_Input__decklink_3.Click,
                                                                            Play_Input__decklink_4.Click,
                                                                            Play_Input__decklink_5.Click,
                                                                            Play_Input__decklink_6.Click,
                                                                            Play_Input__decklink_7.Click,
                                                                            Play_Input__decklink_8.Click
        On Error Resume Next

        Dim str As String = ""
        Dim strSender() As String = Split(sender.name, "_")
        If strSender(0) = "Add" Then str = "embedded_audio"
        If strSender(2) = "key" Then str = "key_only"

        If strSender(0) = "Play" Then
            CasparDevice.SendString(strSender(0) & " " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & strSender(3) & " " & strSender(4))
        Else
            CasparDevice.SendString(strSender(0) & " " & g_int_ChannelNumber & " " & strSender(3) & " " & strSender(4) & " " & str)
        End If

    End Sub
    Private Sub WebSocketServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebSocketServerToolStripMenuItem.Click
        ucWebSocketServer1.Show(DockPanel1, DockState.Document)
    End Sub
    Private Sub mnuCMP_MouseHover(sender As Object, e As EventArgs) Handles mnuCMP.MouseHover
        MakeMenuDropDownWhenParrented(sender)
    End Sub

    Private Sub HtmlTemplateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HtmlTemplateToolStripMenuItem1.Click
        On Error Resume Next
        ucHtmlTemplate1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub FlashTemplateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlashTemplateToolStripMenuItem.Click
        On Error Resume Next
        ucTemplate1.Show(DockPanel1, DockState.Document)
        rdotemplate.Checked = True
    End Sub
    Private Sub ChannelRecorderAndTrimmerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChannelRecorderAndTrimmerToolStripMenuItem.Click
        'FourChannelRecorder.Show()
        uc4ChannelRecorderAndTrimmer1.Show(DockPanel1, DockState.Document)
        uc4ChannelRecorderAndTrimmer1.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document
    End Sub

    Private Sub GeneralRecorderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralRecorderToolStripMenuItem.Click
        ucRecorder1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub OffAirLoggerToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles OffAirLoggerToolStripMenuItem2.Click
        ucOffAirLogger1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub ChannelOffAirLoggerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChannelOffAirLoggerToolStripMenuItem.Click
        On Error Resume Next
        'frmOffAirLoggers.Show()
        ucOffAirLoggers1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub VideoServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VideoServerToolStripMenuItem.Click
        ucPlaylist1.Show(DockPanel1, DockState.Document)
        ucPlaylist.cmdSmallScreen.PerformClick() '  

    End Sub

    Private Sub PlayFromAnywhreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayFromAnywhreToolStripMenuItem.Click
        On Error Resume Next
        ucPlayFromAnyWhere1.Show(DockPanel1, DockState.Document)
    End Sub


    Private Sub mnuCMPModules_Click(sender As Object, e As EventArgs) Handles mnuCMPModules.Click

    End Sub



    Private Sub lblProcessID2_Click(sender As Object, e As EventArgs) Handles lblProcessID2.Click

    End Sub
    Private Sub lblProcessID2_MouseDown(sender As Object, e As MouseEventArgs) Handles lblProcessID2.MouseDown
        DoDragDrop(lblProcessID2.Text, DragDropEffects.Copy)
    End Sub


    Private Sub mnuStreamPlayer_Click(sender As Object, e As EventArgs) Handles mnuStreamPlayer.Click
        On Error Resume Next
        ucStreamPlayer1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub WeightLiftingToolStripMenuItem_Click(sender As Object, e As EventArgs)

        rdoWeightLifting.Select()
    End Sub

    Private Sub CCTVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CCTVToolStripMenuItem.Click
        On Error Resume Next

        ucCCTV1.Show(DockPanel1, DockState.Document)

    End Sub

    Private Sub SilenceDetectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilenceDetectorToolStripMenuItem.Click
        On Error Resume Next
        ucSilenceDetector1.Show(DockPanel1, DockState.Document)
    End Sub
    Private Sub tmrGeneralInfo_Tick(sender As Object, e As EventArgs) Handles tmrGeneralInfo.Tick
        On Error Resume Next
        lbltime.Text = Format(Now, "H:mm:ss").ToString
        CpBarCPU.CPB_Text_2 = CInt(m_PerformanceCounter.NextValue())
        lblcasparMemoryValue.Text = GetProcessMemory("casparcg")
        lblCMPMemory.Text = GetProcessMemory("caspar_media_playback")
    End Sub
    Function GetProcessMemory(processname As String) As String
        On Error Resume Next
        Return Int(FormatNumber((Process.GetProcessesByName(processname)(0).WorkingSet64 / 1024) / 1024)) & "MB"
    End Function
    Private Sub FullPageCaptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullPageCaptionToolStripMenuItem.Click
        On Error Resume Next
        ucFullPageCaption1.Show(DockPanel1, DockState.Document)
    End Sub
    Private Sub rdoplaylist_CheckedChanged(sender As Object, e As EventArgs) Handles rdoplaylist.CheckedChanged

    End Sub

    Private Sub CG1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CG1ToolStripMenuItem.Click
        ucCG1.Show(DockPanel1, DockState.Document)
    End Sub
    Private Sub CG2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CG2ToolStripMenuItem.Click
        ucCG21.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub OnelinerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnelinerToolStripMenuItem.Click
        ucOneLiner1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub TwolinerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TwolinerToolStripMenuItem1.Click
        ucTwoLiner1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub PPTEXcellToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PPTEXcellToolStripMenuItem1.Click

        ucPowerPoint1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub WaterMarkingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WaterMarkingToolStripMenuItem1.Click
        ucWaterMarking1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub QuizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuizeToolStripMenuItem.Click
        ucQuiz1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub NationalGamesKerlaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NationalGamesKerlaToolStripMenuItem.Click
        ucNG20151.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub SouthAsianGamesGuwahati2016ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SouthAsianGamesGuwahati2016ToolStripMenuItem.Click
        ucSG20161.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub CricketToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CricketToolStripMenuItem1.Click
        On Error Resume Next

        ucCricket1.Show(DockPanel1, DockState.Document)
    End Sub
    Private Sub DaviceCupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaviceCupToolStripMenuItem.Click
        'frmdc.Show()
        ucdc1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub OnScreenDrawingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnScreenDrawingToolStripMenuItem.Click
        ucOSD1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub WeightLiftingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WeightLiftingToolStripMenuItem1.Click
        ucWeightLifting1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub ScrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScrollToolStripMenuItem.Click
        ucScroll1.Show(DockPanel1, DockState.Document)
    End Sub
    Private Sub HorizontalScroll1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalScroll1ToolStripMenuItem.Click
        ucHS1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub HorizontalScroll2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalScroll2ToolStripMenuItem.Click
        ucHS21.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub VerticalScroll1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalScroll1ToolStripMenuItem.Click
        ucVS1.Show(DockPanel1, DockState.Document)

    End Sub

    Private Sub VerticalScroll2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalScroll2ToolStripMenuItem.Click
        ucVS21.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub ImageScrollerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageScrollerToolStripMenuItem.Click
        ucImageScroll1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub RSSFeedAsScrollBReakingNewsAndClockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RSSFeedAsScrollBReakingNewsAndClockToolStripMenuItem.Click
        ucRssFeed1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub HTMLScrollerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HTMLScrollerToolStripMenuItem.Click
        ucHtmlScroller1.Show(DockPanel1, DockState.Document)

    End Sub

    Private Sub MultiBulletScrollerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiBulletScrollerToolStripMenuItem.Click
        ucMultiBulletScroll1.Show(DockPanel1, DockState.Document)
    End Sub
    Private Sub SceneScrollerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SceneScrollerToolStripMenuItem.Click
        ucSceneScroller1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub WeatherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeatherToolStripMenuItem.Click
        ucWeather1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub MediaAssetManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediaAssetManagementToolStripMenuItem.Click

        ucMAM1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub VDCPControllerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VDCPControllerToolStripMenuItem.Click
        On Error Resume Next

        ucVDCPController1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub MetadataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MetadataToolStripMenuItem.Click
        ucMetadata1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub XDCamSoapClientToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles XDCamSoapClientToolStripMenuItem1.Click
        'System.Diagnostics.Process.Start("XdcamSoapClient.exe")
        ucXdcamSoapClient1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub UDPChatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UDPChatToolStripMenuItem.Click
        ucUdpChat1.Show(DockPanel1, DockState.Document)
    End Sub
    Private Sub TabPagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabPagesToolStripMenuItem.Click
        ucTab1.Show()
    End Sub

    Private Sub cmdVLCPreview_Click(sender As Object, e As EventArgs) Handles cmdVLCPreview.Click
        ucCasparcgWindow1.outcasparcgwindown()

        If CntrlExistsIn("ucPreview1", ucCasparcgWindow1.Panel1) = False Then
            ucPreview1 = New ucPreview
            ucCasparcgWindow1.Panel1.Controls.Add(ucPreview1)
            ucPreview1.Name = "ucPreview1"

        End If
        ucPreview1.Location = New Point(0, 0)
    End Sub

    Private Sub cmdScreenConsumer_Click(sender As Object, e As EventArgs) Handles cmdScreenConsumer.Click
        'ucCasparcgWindow1.Panel1.Controls.Remove(ucPreview1)
        ucCasparcgWindow1.SetProcessParent("casparcg")
        If CntrlExistsIn("ucCasparcgWindow1", Me) = False Then
            Dim ucCasparcgWindow1 = New ucCasparcgWindow
            Me.Controls.Add(ucCasparcgWindow1)
            ucCasparcgWindow1.Name = "ucCasparcgWindow1"
            'Dim rs5 = New clsResizeableControl(ucCasparcgWindow1)
        End If
        ucCasparcgWindow1.Show()
    End Sub
    Protected Sub LoadLayout()
        'On Error Resume Next
        If File.Exists(lastlayout) Then
            CloseAllContents()
            DockPanel1.LoadFromXml(lastlayout, New DeserializeDockContent(AddressOf GetContentFromPersistString))
        End If
    End Sub
    Private Sub CloseAllDocuments()
        If DockPanel1.DocumentStyle = DocumentStyle.SystemMdi Then
            For Each form As Form In MdiChildren
                form.Close()
            Next
        Else
            For Each document As IDockContent In DockPanel1.DocumentsToArray()
                document.DockHandler.DockPanel = Nothing
                document.DockHandler.Close()
            Next
        End If
    End Sub
    Private Sub LoadLastLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadLastLayoutToolStripMenuItem.Click
        LoadLayout()
    End Sub

    Private Sub SaveLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveLayoutToolStripMenuItem.Click
        DockPanel1.SaveAsXml(lastlayout)
    End Sub
    Private Function GetContentFromPersistString(ByVal persistString As String) As IDockContent
        If persistString = GetType(ucCCTV).ToString() Then
            Return ucCCTV1
        ElseIf persistString = GetType(ucCG).ToString() Then
            Return ucCG1
        ElseIf persistString = GetType(ucTimers).ToString() Then
            Return ucTimers1
        ElseIf persistString = GetType(ucCG2).ToString() Then
            Return ucCG21
        ElseIf persistString = GetType(ucHS).ToString() Then
            Return ucHS1
        ElseIf persistString = GetType(ucPlaylist).ToString() Then
            Return ucPlaylist1
        ElseIf persistString = GetType(ucPlaylistSetting).ToString() Then
            Return ucPlaylistSetting1
        ElseIf persistString = GetType(UcCommandScheduler).ToString() Then
            Return UcCommandScheduler1
        ElseIf persistString = GetType(ucAMCPcommands).ToString() Then
            Return ucAMCPcommands1
        ElseIf persistString = GetType(ucHS2).ToString() Then
            Return ucHS21
        ElseIf persistString = GetType(ucCricket).ToString() Then
            Return ucCricket1
        ElseIf persistString = GetType(ucdBFSMeter).ToString() Then
            Return ucdBFSMeter1
        ElseIf persistString = GetType(ucdc).ToString() Then
            Return ucdc1
        ElseIf persistString = GetType(ucFaceBook).ToString() Then
            Return ucFaceBook1
        ElseIf persistString = GetType(ucFourChannelPreview).ToString() Then
            Return ucFourChannelPreview1
        ElseIf persistString = GetType(ucFullPageCaption).ToString() Then
            Return ucFullPageCaption1
        ElseIf persistString = GetType(ucHTML).ToString() Then
            Return ucHTML1
        ElseIf persistString = GetType(ucHtmlScroller).ToString() Then
            Return ucHtmlScroller1
        ElseIf persistString = GetType(ucHtmlTemplate).ToString() Then
            Return ucHtmlTemplate1
        ElseIf persistString = GetType(ucImageScroll).ToString() Then
            Return ucImageScroll1

        ElseIf persistString = GetType(ucMAM).ToString() Then
            Return ucMAM1
        ElseIf persistString = GetType(ucMetadata).ToString() Then
            Return ucMetadata1

        ElseIf persistString = GetType(ucMultiBulletScroll).ToString() Then
            Return ucMultiBulletScroll1
        ElseIf persistString = GetType(ucMySqlTest).ToString() Then
            Return ucMySqlTest1
        ElseIf persistString = GetType(ucNG2015).ToString() Then
            Return ucNG20151
        ElseIf persistString = GetType(ucOffAirLogger).ToString() Then
            Return ucOffAirLogger1

        ElseIf persistString = GetType(ucOffAirLoggers).ToString() Then
            Return ucOffAirLoggers1
        ElseIf persistString = GetType(uc4ChannelRecorderAndTrimmer).ToString() Then
            Return uc4ChannelRecorderAndTrimmer1
        ElseIf persistString = GetType(ucOneLiner).ToString() Then
            Return ucOneLiner1
        ElseIf persistString = GetType(ucOSC).ToString() Then
            Return ucOSC1
        ElseIf persistString = GetType(ucOSD).ToString() Then
            Return ucOSD1
        ElseIf persistString = GetType(ucQuiz).ToString() Then
            Return ucQuiz1

        ElseIf persistString = GetType(ucRecorder).ToString() Then
            Return ucRecorder1
        ElseIf persistString = GetType(ucRemoteLogging).ToString() Then
            Return ucRemoteLogging1
        ElseIf persistString = GetType(ucRssFeed).ToString() Then
            Return ucRssFeed1
        ElseIf persistString = GetType(ucSceneScroller).ToString() Then
            Return ucSceneScroller1
        ElseIf persistString = GetType(ucScroll).ToString() Then
            Return ucScroll1
        ElseIf persistString = GetType(ucSG2016).ToString() Then
            Return ucSG20161
        ElseIf persistString = GetType(ucSilenceDetector).ToString() Then
            Return ucSilenceDetector1
        ElseIf persistString = GetType(ucSlowMotion).ToString() Then
            Return ucSlowMotion1
        ElseIf persistString = GetType(ucSlowMotion21).ToString() Then
            Return ucSlowMotion211
        ElseIf persistString = GetType(ucSongSubtitling).ToString() Then
            Return ucSongSubtitling1
        ElseIf persistString = GetType(ucSrtPlayer).ToString() Then
            Return ucSrtPlayer1
        ElseIf persistString = GetType(ucStreaming).ToString() Then
            Return ucStreaming1
        ElseIf persistString = GetType(ucStreamPlayer).ToString() Then
            Return ucStreamPlayer1
        ElseIf persistString = GetType(ucSwfPlayer).ToString() Then
            Return ucSwfPlayer1
        ElseIf persistString = GetType(ucTemplate).ToString() Then
            Return ucTemplate1

        ElseIf persistString = GetType(ucTrimmer).ToString() Then
            Return ucTrimmer1
        ElseIf persistString = GetType(ucTwitter).ToString() Then
            Return ucTwitter1
        ElseIf persistString = GetType(ucTwoLiner).ToString() Then
            Return ucTwoLiner1
        ElseIf persistString = GetType(ucUdpChat).ToString() Then
            Return ucUdpChat1
        ElseIf persistString = GetType(ucVDCPController).ToString() Then
            Return ucVDCPController1
        ElseIf persistString = GetType(ucVisionMixer).ToString() Then
            Return ucVisionMixer1
        ElseIf persistString = GetType(ucVlcStreamTester).ToString() Then
            Return ucVlcStreamTester1
        ElseIf persistString = GetType(ucVS).ToString() Then
            Return ucVS1
            Return ucVlcStreamTester1
        ElseIf persistString = GetType(ucVS2).ToString() Then
            Return ucVS21

        ElseIf persistString = GetType(ucWaterMarking).ToString() Then
            Return ucWaterMarking1
        ElseIf persistString = GetType(ucWeather).ToString() Then
            Return ucWeather1
        ElseIf persistString = GetType(ucWebSocketServer).ToString() Then
            Return ucWebSocketServer1
        ElseIf persistString = GetType(ucWeightLifting).ToString() Then
            Return ucWeightLifting1
        ElseIf persistString = GetType(ucXdcamSoapClient).ToString() Then
            Return ucXdcamSoapClient1
        ElseIf persistString = GetType(ucPlayFromAnyWhere).ToString() Then
            Return ucPlayFromAnyWhere1
        ElseIf persistString = GetType(ucPowerPoint).ToString() Then
            Return ucPowerPoint1
        ElseIf persistString = GetType(form1).ToString() Then
            Return Form11
        ElseIf persistString = GetType(ucTemplatePlaylist).ToString() Then
            Return ucTemplatePlaylist1
        ElseIf persistString = GetType(ucytlive).ToString() Then
            Return ucytlive1
        ElseIf persistString = GetType(ucRCCAutomation).ToString() Then
            Return ucRCCAutomation1
        ElseIf persistString = GetType(ucRccBall).ToString() Then
            Return ucRccBall1
        End If


    End Function
    Private Sub CloseAllContents()
        ucCG1.DockPanel = Nothing
        ucCCTV1.DockPanel = Nothing
        ucTimers1.DockPanel = Nothing
        ucCG21.DockPanel = Nothing
        ucHS1.DockPanel = Nothing
        ucPlaylist1.DockPanel = Nothing

        UcCommandScheduler1.DockPanel = Nothing

        ucHS21.DockPanel = Nothing
        ucCricket1.DockPanel = Nothing
        ucdBFSMeter1.DockPanel = Nothing
        ucdc1.DockPanel = Nothing
        ucFaceBook.DockPanel = Nothing
        ucFourChannelPreview1.DockPanel = Nothing
        ucFullPageCaption1.DockPanel = Nothing
        ucHTML1.DockPanel = Nothing
        ucHtmlScroller1.DockPanel = Nothing
        ucHtmlTemplate1.DockPanel = Nothing
        ucImageScroll1.DockPanel = Nothing
        ucMAM1.DockPanel = Nothing
        ucMetadata1.DockPanel = Nothing
        ucMultiBulletScroll1.DockPanel = Nothing
        ucMySqlTest1.DockPanel = Nothing
        ucNG20151.DockPanel = Nothing
        ucOffAirLogger1.DockPanel = Nothing
        ucOffAirLoggers1.DockPanel = Nothing
        uc4ChannelRecorderAndTrimmer1.DockPanel = Nothing
        ucOneLiner1.DockPanel = Nothing
        ucOSC.DockPanel = Nothing
        ucOSD1.DockPanel = Nothing
        ucQuiz1.DockPanel = Nothing
        ucRecorder1.DockPanel = Nothing
        ucRemoteLogging1.DockPanel = Nothing
        ucRssFeed1.DockPanel = Nothing
        ucSceneScroller1.DockPanel = Nothing
        ucScroll1.DockPanel = Nothing
        ucSG20161.DockPanel = Nothing
        ucSilenceDetector1.DockPanel = Nothing
        ucSlowMotion.DockPanel = Nothing
        ucSlowMotion211.DockPanel = Nothing
        ucSongSubtitling1.DockPanel = Nothing
        ucSrtPlayer1.DockPanel = Nothing
        ucStreaming1.DockPanel = Nothing
        ucStreamPlayer1.DockPanel = Nothing

        ucTemplate1.DockPanel = Nothing
        ucTrimmer1.DockPanel = Nothing
        ucTwitter1.DockPanel = Nothing
        ucTwoLiner1.DockPanel = Nothing
        ucUdpChat1.DockPanel = Nothing
        ucVDCPController1.DockPanel = Nothing
        ucVisionMixer1.DockPanel = Nothing
        ucVlcStreamTester1.DockPanel = Nothing
        ucVS1.DockPanel = Nothing
        ucVS21.DockPanel = Nothing
        ucWaterMarking1.DockPanel = Nothing
        ucWeather1.DockPanel = Nothing
        ucWebSocketServer1.DockPanel = Nothing
        ucWeightLifting1.DockPanel = Nothing
        ucXdcamSoapClient1.DockPanel = Nothing
        ucPlayFromAnyWhere1.DockPanel = Nothing
        ucPowerPoint1.DockPanel = Nothing
        Form11.DockPanel = Nothing
        ucTemplatePlaylist1.DockPanel = Nothing
        UcCommandSchedulerDateWise1.DockPanel = Nothing
        ucytlive1.DockPanel = Nothing
        ucRCCAutomation1 = Nothing
        ucRccBall1 = Nothing

        CloseAllDocuments()
        For Each window In DockPanel1.FloatWindows.ToList()
            window.Dispose()
        Next
        System.Diagnostics.Debug.Assert(DockPanel1.Panes.Count = 0)
        System.Diagnostics.Debug.Assert(DockPanel1.Contents.Count = 0)
        System.Diagnostics.Debug.Assert(DockPanel1.FloatWindows.Count = 0)
    End Sub

    Private Sub CompositionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompositionToolStripMenuItem.Click
        Form1.Show(DockPanel1, DockState.Document)
        Form1.DockAreas = DockAreas.Document
    End Sub
    ' Clear temp file and recycle bin code starts--------------
    Private Declare Function SHEmptyRecycleBin Lib "shell32.dll" Alias "SHEmptyRecycleBinA" (ByVal hWnd As Int32, ByVal pszRootPath As String, ByVal dwFlags As Int32) As Int32
    Private Declare Function SHUpdateRecycleBinIcon Lib "shell32.dll" () As Int32

    Private Const SHERB_NOCONFIRMATION = &H1
    Private Const SHERB_NOPROGRESSUI = &H2
    Private Const SHERB_NOSOUND = &H4
    Private Sub ClearTempFileAndRecycleBinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearTempFileAndRecycleBinToolStripMenuItem.Click
        DeleteDirectory(System.IO.Path.GetTempPath)
        DeleteDirectory("c:\windows\temp\")
        EmptyRecycleBin()
    End Sub
    Private Sub DeleteDirectory(path As String)
        On Error Resume Next
        If Directory.Exists(path) Then
            'Delete all files from the Directory
            For Each filepath As String In Directory.GetFiles(path)
                File.Delete(filepath)
            Next
            'Delete all child Directories
            For Each dir As String In Directory.GetDirectories(path)
                DeleteDirectory(dir)
            Next
            'Delete a Directory
            Directory.Delete(path)
        End If
    End Sub

    Private Sub EmptyRecycleBin()
        On Error Resume Next
        SHEmptyRecycleBin(Me.Handle.ToInt32, vbNullString, SHERB_NOCONFIRMATION + SHERB_NOSOUND)
        SHUpdateRecycleBinIcon()
    End Sub
    ' Clear temp file and recycle bin code ends--------------
    Private Sub TemplatePlaylistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemplatePlaylistToolStripMenuItem.Click
        ucTemplatePlaylist1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub YouTubeLInkOfHelpVideosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YouTubeLInkOfHelpVideosToolStripMenuItem.Click
        On Error Resume Next
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLeBXICFOkFQtPK7MoKWgHAQJQMTW4Zu6r")
    End Sub

    Private Sub Channel1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Channel1ToolStripMenuItem.Click
        On Error Resume Next
        CasparDevice.SendString("add 1 screen")
    End Sub

    Private Sub Channel2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Channel2ToolStripMenuItem.Click
        On Error Resume Next
        CasparDevice.SendString("add 2 screen")
    End Sub

    Private Sub Channel3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Channel3ToolStripMenuItem.Click
        On Error Resume Next
        CasparDevice.SendString("add 3 screen")
    End Sub

    Private Sub Channel4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Channel4ToolStripMenuItem.Click
        On Error Resume Next
        CasparDevice.SendString("add 4 screen")
    End Sub

    Private Sub XDCamControllersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XDCamControllersToolStripMenuItem.Click
        frmXDCamContoller.Show()
    End Sub
    Dim aa() As String
    Private Sub MakeThumbnailForServer23ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MakeThumbnailForServer23ToolStripMenuItem.Click
        On Error Resume Next
        Dim alreadyRunning As Integer
        Dim dd As New Process
        If ServerVersion > 2.1 Then
            If IfRunning("scanner") = False Then
                alreadyRunning = 5
                dd.StartInfo.FileName = initialpath & "\scanner.exe" '"C:\Users\vimlesh\Downloads\casparcg-server-050620\scanner.exe"
                dd.StartInfo.WorkingDirectory = initialpath ' "C:\Users\vimlesh\Downloads\casparcg-server-050620\"
                dd.Start()
                Threading.Thread.Sleep(5000)
            Else
                alreadyRunning = 2
            End If


            Dim webClient As New System.Net.WebClient
            Dim result As String = webClient.DownloadString("http://" & cmbhost.Text & ":8000/thumbnail")
            Dim bb() = Split(result, vbNewLine)
            ReDim aa(bb.Count)

            For iclips = 0 To bb.Count - 3
                Dim foldername As String = ""
                Dim clipname As String = Replace(Split(bb(iclips), "  ")(0), "\", "/")
                clipname = Split(clipname, """" & " ")(0)
                clipname = Replace(clipname, """", "")
                aa(iclips) = clipname
            Next
            aa = aa.Skip(1).ToArray

            For Each item As String In aa
                'Dim webClient As New System.Net.WebClient
                result = webClient.DownloadString("http://" & cmbhost.Text & ":8000/thumbnail/" & Replace(item, "/", "%2F"))
                bb = Split(result, vbNewLine)
                Dim filename As String = thumbnailsfullpath & "/" & item & ".png"
                Dim fi As New FileInfo(filename)

                Dim path As String = fi.DirectoryName
                If (Not System.IO.Directory.Exists(path)) Then
                    System.IO.Directory.CreateDirectory(path)
                End If
                ss(bb(1)).Save(filename)
            Next
            If alreadyRunning = 5 Then dd.Kill()
        End If
    End Sub
    Function ss(ff As String) As Image
        On Error Resume Next
        Dim gg As Image = Image.FromStream(New MemoryStream(Convert.FromBase64String(ff)))
        Return gg
    End Function

    Private Sub YouTubeLiveManagemnetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YouTubeLiveManagemnetToolStripMenuItem.Click
        On Error Resume Next
        ucytlive1.Show(DockPanel1, DockState.Document)
    End Sub



    Private Sub RCCBallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RCCBallToolStripMenuItem.Click
        On Error Resume Next
        ucRccBall1.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub NewGameClientDownloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameClientDownloadToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://bit.ly/3PCcHP6")
    End Sub

    Private Sub NewCgSoftwareDownloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCgSoftwareDownloadToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://casparcgforum.org/t/react-caspar-client/4375")
    End Sub

    Private Sub OnlineCGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnlineCGToolStripMenuItem.Click
        ucOnLineCG1.Show(DockPanel1, DockState.Document)

    End Sub
End Class
