<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmmediaplayer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Alert1 As ALERT = New ALERT()
        Dim Critical1 As CRITICAL = New CRITICAL()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmediaplayer))
        Me.lblport = New System.Windows.Forms.Label()
        Me.lblhost = New System.Windows.Forms.Label()
        Me.cmdconnect = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdstopall = New System.Windows.Forms.Button()
        Me.nfontsizeforall = New System.Windows.Forms.NumericUpDown()
        Me.cmbhost = New System.Windows.Forms.ComboBox()
        Me.txtport = New System.Windows.Forms.TextBox()
        Me.cmdyadif10 = New System.Windows.Forms.Button()
        Me.cmdyadif11 = New System.Windows.Forms.Button()
        Me.cmdIMX = New System.Windows.Forms.Button()
        Me.cmblayervideo = New System.Windows.Forms.ComboBox()
        Me.cmbchannel = New System.Windows.Forms.ComboBox()
        Me.lblremainintime = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.cmdScreenConsumer = New System.Windows.Forms.Button()
        Me.cmdVLCPreview = New System.Windows.Forms.Button()
        Me.cmbfontsforall = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rdoRecording = New System.Windows.Forms.RadioButton()
        Me.rdoplaylist = New System.Windows.Forms.RadioButton()
        Me.rdoswfplayer = New System.Windows.Forms.RadioButton()
        Me.rdoamcp = New System.Windows.Forms.RadioButton()
        Me.rdoMixer = New System.Windows.Forms.RadioButton()
        Me.rdoHorizontalScroll2 = New System.Windows.Forms.RadioButton()
        Me.rdoHorizontalScroll1 = New System.Windows.Forms.RadioButton()
        Me.rdoverticalscroll = New System.Windows.Forms.RadioButton()
        Me.rdotemplate = New System.Windows.Forms.RadioButton()
        Me.gbmodules = New System.Windows.Forms.GroupBox()
        Me.rdoSG2016 = New System.Windows.Forms.RadioButton()
        Me.rdoWeightLifting = New System.Windows.Forms.RadioButton()
        Me.rdoDavisCup = New System.Windows.Forms.RadioButton()
        Me.rdoXdCamSoapClient = New System.Windows.Forms.RadioButton()
        Me.rdoVDCP = New System.Windows.Forms.RadioButton()
        Me.rdoCricket = New System.Windows.Forms.RadioButton()
        Me.rdoCCTV = New System.Windows.Forms.RadioButton()
        Me.rdo4ChannelRecorderAndTrimmer = New System.Windows.Forms.RadioButton()
        Me.rdoOffAirLoggers = New System.Windows.Forms.RadioButton()
        Me.rdoFourChannelPreview = New System.Windows.Forms.RadioButton()
        Me.rdoFullPageCaption = New System.Windows.Forms.RadioButton()
        Me.rdoSilenceDetector = New System.Windows.Forms.RadioButton()
        Me.rdoStreamPlayer = New System.Windows.Forms.RadioButton()
        Me.rdoWebSocketServer = New System.Windows.Forms.RadioButton()
        Me.rdoHtmlTemplate = New System.Windows.Forms.RadioButton()
        Me.rdoMySqlTest = New System.Windows.Forms.RadioButton()
        Me.rdodBFSMeter = New System.Windows.Forms.RadioButton()
        Me.rdoCustomControls = New System.Windows.Forms.RadioButton()
        Me.rdoOSD = New System.Windows.Forms.RadioButton()
        Me.rdoScheduler = New System.Windows.Forms.RadioButton()
        Me.rdovlcstreamtester = New System.Windows.Forms.RadioButton()
        Me.rdoSceneScroller = New System.Windows.Forms.RadioButton()
        Me.rdoMultiBulletScroll = New System.Windows.Forms.RadioButton()
        Me.rdoPlayFromAnywhere = New System.Windows.Forms.RadioButton()
        Me.rdoPlayListSetting = New System.Windows.Forms.RadioButton()
        Me.rdoWaterMarking = New System.Windows.Forms.RadioButton()
        Me.rdoRemoteLogging = New System.Windows.Forms.RadioButton()
        Me.rdosm2 = New System.Windows.Forms.RadioButton()
        Me.rdovs2 = New System.Windows.Forms.RadioButton()
        Me.rdoMAM = New System.Windows.Forms.RadioButton()
        Me.rdometadata = New System.Windows.Forms.RadioButton()
        Me.rdochannelinfo = New System.Windows.Forms.RadioButton()
        Me.rdoudpchat = New System.Windows.Forms.RadioButton()
        Me.rdostreaming = New System.Windows.Forms.RadioButton()
        Me.rdotrimmer = New System.Windows.Forms.RadioButton()
        Me.rdogames = New System.Windows.Forms.RadioButton()
        Me.rdotimers = New System.Windows.Forms.RadioButton()
        Me.rdosrt = New System.Windows.Forms.RadioButton()
        Me.rdoquiz = New System.Windows.Forms.RadioButton()
        Me.rdocg2 = New System.Windows.Forms.RadioButton()
        Me.rdoSongSubtitling = New System.Windows.Forms.RadioButton()
        Me.rdohtmlscroller = New System.Windows.Forms.RadioButton()
        Me.rdoelection = New System.Windows.Forms.RadioButton()
        Me.rdohtml = New System.Windows.Forms.RadioButton()
        Me.rdofacebook = New System.Windows.Forms.RadioButton()
        Me.rdotwitter = New System.Windows.Forms.RadioButton()
        Me.rdorss = New System.Windows.Forms.RadioButton()
        Me.rdoweather = New System.Windows.Forms.RadioButton()
        Me.rdoutility = New System.Windows.Forms.RadioButton()
        Me.rdoosc = New System.Windows.Forms.RadioButton()
        Me.rdoimagescroll = New System.Windows.Forms.RadioButton()
        Me.rdooffairlogger = New System.Windows.Forms.RadioButton()
        Me.rdoSlowMotion = New System.Windows.Forms.RadioButton()
        Me.rdovisionmixer = New System.Windows.Forms.RadioButton()
        Me.rdocg = New System.Windows.Forms.RadioButton()
        Me.rdopowerpoint = New System.Windows.Forms.RadioButton()
        Me.rdoTwoLiner = New System.Windows.Forms.RadioButton()
        Me.rdooneliner = New System.Windows.Forms.RadioButton()
        Me.rdoscroll = New System.Windows.Forms.RadioButton()
        Me.rdoBreakingNews = New System.Windows.Forms.RadioButton()
        Me.lblserverversion = New System.Windows.Forms.Label()
        Me.Label147 = New System.Windows.Forms.Label()
        Me.Label148 = New System.Windows.Forms.Label()
        Me.lblflashversion = New System.Windows.Forms.Label()
        Me.Label150 = New System.Windows.Forms.Label()
        Me.lbltemplatehostversion = New System.Windows.Forms.Label()
        Me.mnuCMP = New System.Windows.Forms.MenuStrip()
        Me.mnuCMPPlayList = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayFromAnywhreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPTemplate = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlashTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HtmlTemplateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMP4ChannelRecordingAndTrimming = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChannelRecorderAndTrimmerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralRecorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OffAirLoggerToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChannelOffAirLoggerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrimmerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CG1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CG2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnelinerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TwolinerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PPTEXcellToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WaterMarkingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeatherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RCCAutomationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScrollersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HTMLScrollerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiBulletScrollerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageScrollerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalScroll1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalScroll2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RSSFeedAsScrollBReakingNewsAndClockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SceneScrollerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalScroll1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalScroll2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NationalGamesKerlaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SouthAsianGamesGuwahati2016ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CricketToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaviceCupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnScreenDrawingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeightLiftingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RCCBallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExternalSoftwaresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediaAssetManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XDCamSoapClientToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VDCPControllerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UDPChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetadataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XDCamControllersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YouTubeLiveManagemnetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPModules = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPStreaming = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStreamPlayer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPSubTitling = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPSRTPlayer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPSongSubTitling = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPSlowMotion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPSlowMotionInServer21 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPSlowMotionInJStarServer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPSocialMedia = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPFacebook = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPTwitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPHTMLorInternet = New System.Windows.Forms.ToolStripMenuItem()
        Me.VLCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StreamTesterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FourChannelPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPMixer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPVisionMixer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPOSC = New System.Windows.Forms.ToolStripMenuItem()
        Me.SilenceDetectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPElection = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPTimers = New System.Windows.Forms.ToolStripMenuItem()
        Me.DBFSMeter16ChannelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CCTVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandSchedulerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandSchedulerDateWiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MySqlTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebSocketServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullPageCaptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPRemoteLogging = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemplatePlaylistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPAddScreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.Channel1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Channel2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Channel3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Channel4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddOutput = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddputputFill = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddOutputFillDecklink = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_Fill_decklink_1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_Fill_decklink_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_Fill_decklink_3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_Fill_decklink_4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_Fill_decklink_5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_Fill_decklink_6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_Fill_decklink_7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_Fill_decklink_8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddOutputFillBluefish = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_Fill_Bluefish_1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_Fill_Bluefish_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_Fill_Bluefish_3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_Fill_Bluefish_4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_Fill_Bluefish_5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_Fill_Bluefish_6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_Fill_Bluefish_7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_Fill_Bluefish_8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddputputKey = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddOutputKeyDecklink = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_key_Decklink_1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_key_Decklink_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_key_Decklink_3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_key_Decklink_4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_key_Decklink_5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_key_Decklink_6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_key_Decklink_7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_key_Decklink_8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddOutputKeyBluefish = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_key_Bluefish_1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_key_Bluefish_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_key_Bluefish_3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_key_Bluefish_4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_key_Bluefish_5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_key_Bluefish_6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_key_Bluefish_7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Ouput_key_Bluefish_8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveOutput = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveOutputDecklink = New System.Windows.Forms.ToolStripMenuItem()
        Me.Remove_Ouput__decklink_1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Remove_Ouput__decklink_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Remove_Ouput__decklink_3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Remove_Ouput__decklink_4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Remove_Ouput__decklink_5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Remove_Ouput__decklink_6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Remove_Ouput__decklink_7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Remove_Ouput__decklink_8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveOutputBluefish = New System.Windows.Forms.ToolStripMenuItem()
        Me.Remove_Output__Bluefish_1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Remove_Output__Bluefish_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Remove_Output__Bluefish_3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Remove_Output__Bluefish_4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Remove_Output__Bluefish_5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Remove_Output__Bluefish_6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Remove_Output__Bluefish_7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Remove_Output__Bluefish_8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Play_Input = New System.Windows.Forms.ToolStripMenuItem()
        Me.Play_Input__decklink = New System.Windows.Forms.ToolStripMenuItem()
        Me.Play_Input__decklink_1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Play_Input__decklink_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Play_Input__decklink_3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Play_Input__decklink_4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Play_Input__decklink_5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Play_Input__decklink_6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Play_Input__decklink_7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Play_Input__decklink_8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPRemoveScreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPResetSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPEditConfigFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPRestartCasparcgServer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPRestartwithConfigFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPQuitCasparcgServer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPCopyExampleTemplates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPCopyExampleMedia = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPCasparcgDiagnosisWndow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPClearTypeSwitch = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPPALSD = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPHD108050i = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewInstanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DifferentConfigFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadLastLayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveLayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearTempFileAndRecycleBinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakeThumbnailForServer23ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCMPUpdatedSoftwareLink = New System.Windows.Forms.ToolStripMenuItem()
        Me.YouTubeLInkOfHelpVideosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrGC = New System.Windows.Forms.Timer(Me.components)
        Me.RecordingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OffAirLoggerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblProcessID1 = New System.Windows.Forms.Label()
        Me.lblProcessID2 = New System.Windows.Forms.Label()
        Me.cmsCustomeModules = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PositionAndSizeControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemAudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.pnlServer = New System.Windows.Forms.Panel()
        Me.gbPannel = New System.Windows.Forms.Panel()
        Me.tmrGeneralInfo = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCMPMemory = New System.Windows.Forms.Label()
        Me.lblcasparMemory = New System.Windows.Forms.Label()
        Me.lblcasparMemoryValue = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CpBarCPU = New CPBar()
        Me.DockPanel1 = New WeifenLuo.WinFormsUI.Docking.DockPanel()
        Me.VS2015BlueTheme1 = New WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.nfontsizeforall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbmodules.SuspendLayout()
        Me.mnuCMP.SuspendLayout()
        Me.cmsCustomeModules.SuspendLayout()
        Me.pnlServer.SuspendLayout()
        Me.gbPannel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DockPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblport
        '
        Me.lblport.AutoSize = True
        Me.lblport.Location = New System.Drawing.Point(184, 32)
        Me.lblport.Name = "lblport"
        Me.lblport.Size = New System.Drawing.Size(26, 13)
        Me.lblport.TabIndex = 76
        Me.lblport.Text = "Port"
        '
        'lblhost
        '
        Me.lblhost.AutoSize = True
        Me.lblhost.Location = New System.Drawing.Point(13, 33)
        Me.lblhost.Name = "lblhost"
        Me.lblhost.Size = New System.Drawing.Size(29, 13)
        Me.lblhost.TabIndex = 75
        Me.lblhost.Text = "Host"
        '
        'cmdconnect
        '
        Me.cmdconnect.BackColor = System.Drawing.Color.Red
        Me.cmdconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdconnect.ForeColor = System.Drawing.Color.White
        Me.cmdconnect.Location = New System.Drawing.Point(255, 26)
        Me.cmdconnect.Name = "cmdconnect"
        Me.cmdconnect.Size = New System.Drawing.Size(141, 29)
        Me.cmdconnect.TabIndex = 74
        Me.cmdconnect.Text = "Connect"
        Me.ToolTip1.SetToolTip(Me.cmdconnect, "Click To Connect")
        Me.cmdconnect.UseVisualStyleBackColor = False
        '
        'cmdstopall
        '
        Me.cmdstopall.BackColor = System.Drawing.Color.Red
        Me.cmdstopall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdstopall.ForeColor = System.Drawing.Color.White
        Me.cmdstopall.Location = New System.Drawing.Point(548, 26)
        Me.cmdstopall.Name = "cmdstopall"
        Me.cmdstopall.Size = New System.Drawing.Size(141, 29)
        Me.cmdstopall.TabIndex = 330
        Me.cmdstopall.Text = "Stop Channel"
        Me.ToolTip1.SetToolTip(Me.cmdstopall, "Stop Selected Channel, Disables all Automatic works in this client")
        Me.cmdstopall.UseVisualStyleBackColor = False
        '
        'nfontsizeforall
        '
        Me.nfontsizeforall.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.caspar_media_playback.My.MySettings.Default, "nfontsizeforall", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nfontsizeforall.Location = New System.Drawing.Point(865, 32)
        Me.nfontsizeforall.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nfontsizeforall.Name = "nfontsizeforall"
        Me.nfontsizeforall.Size = New System.Drawing.Size(38, 20)
        Me.nfontsizeforall.TabIndex = 539
        Me.ToolTip1.SetToolTip(Me.nfontsizeforall, "Only for this client; not for template")
        Me.nfontsizeforall.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'cmbhost
        '
        Me.cmbhost.FormattingEnabled = True
        Me.cmbhost.Items.AddRange(New Object() {"127.0.0.1", "192.168.1.1", "192.168.1.2", "192.168.1.3", "192.168.1.55", "CasparPlayout1", "CasparPlayout2", "CasparIngest1", "CasparIngest2", "OffAirlogger", "EndGraphics", "Casparcg1", "Casparcg2", "LocalHost"})
        Me.cmbhost.Location = New System.Drawing.Point(52, 29)
        Me.cmbhost.Name = "cmbhost"
        Me.cmbhost.Size = New System.Drawing.Size(119, 21)
        Me.cmbhost.TabIndex = 1173
        Me.cmbhost.Text = "127.0.0.1"
        Me.ToolTip1.SetToolTip(Me.cmbhost, "Host name or IP of caspacrg Server PC")
        '
        'txtport
        '
        Me.txtport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtport", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtport.Location = New System.Drawing.Point(209, 29)
        Me.txtport.Name = "txtport"
        Me.txtport.Size = New System.Drawing.Size(30, 20)
        Me.txtport.TabIndex = 78
        Me.txtport.Text = "5250"
        Me.ToolTip1.SetToolTip(Me.txtport, "Port number of Caspacrg Server to Connect")
        '
        'cmdyadif10
        '
        Me.cmdyadif10.Location = New System.Drawing.Point(221, 4)
        Me.cmdyadif10.Name = "cmdyadif10"
        Me.cmdyadif10.Size = New System.Drawing.Size(59, 23)
        Me.cmdyadif10.TabIndex = 733
        Me.cmdyadif10.Text = "yadif=1:0"
        Me.ToolTip1.SetToolTip(Me.cmdyadif10, "Apply Yadif Filter on running clip")
        Me.cmdyadif10.UseVisualStyleBackColor = True
        '
        'cmdyadif11
        '
        Me.cmdyadif11.Location = New System.Drawing.Point(221, 29)
        Me.cmdyadif11.Name = "cmdyadif11"
        Me.cmdyadif11.Size = New System.Drawing.Size(59, 23)
        Me.cmdyadif11.TabIndex = 732
        Me.cmdyadif11.Text = "yadif=1:1"
        Me.ToolTip1.SetToolTip(Me.cmdyadif11, "Apply Yadif Filter on running clip")
        Me.cmdyadif11.UseVisualStyleBackColor = True
        '
        'cmdIMX
        '
        Me.cmdIMX.Location = New System.Drawing.Point(281, 4)
        Me.cmdIMX.Name = "cmdIMX"
        Me.cmdIMX.Size = New System.Drawing.Size(53, 23)
        Me.cmdIMX.TabIndex = 1169
        Me.cmdIMX.Text = "IMX"
        Me.ToolTip1.SetToolTip(Me.cmdIMX, "Apply filter crop=720:576:0:32 on running clip")
        Me.cmdIMX.UseVisualStyleBackColor = True
        '
        'cmblayervideo
        '
        Me.cmblayervideo.FormattingEnabled = True
        Me.cmblayervideo.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmblayervideo.Location = New System.Drawing.Point(495, 30)
        Me.cmblayervideo.Name = "cmblayervideo"
        Me.cmblayervideo.Size = New System.Drawing.Size(33, 21)
        Me.cmblayervideo.TabIndex = 320
        Me.cmblayervideo.Text = "1"
        Me.ToolTip1.SetToolTip(Me.cmblayervideo, "Video layer of Playlist")
        '
        'cmbchannel
        '
        Me.cmbchannel.FormattingEnabled = True
        Me.cmbchannel.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbchannel.Location = New System.Drawing.Point(426, 30)
        Me.cmbchannel.Name = "cmbchannel"
        Me.cmbchannel.Size = New System.Drawing.Size(30, 21)
        Me.cmbchannel.TabIndex = 318
        Me.cmbchannel.Text = "1"
        Me.ToolTip1.SetToolTip(Me.cmbchannel, "Channel Numbaer")
        '
        'lblremainintime
        '
        Me.lblremainintime.AutoSize = True
        Me.lblremainintime.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.lblremainintime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblremainintime.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold)
        Me.lblremainintime.ForeColor = System.Drawing.Color.Yellow
        Me.lblremainintime.Location = New System.Drawing.Point(337, 1)
        Me.lblremainintime.Name = "lblremainintime"
        Me.lblremainintime.Size = New System.Drawing.Size(137, 35)
        Me.lblremainintime.TabIndex = 611
        Me.lblremainintime.Text = "10:20:18"
        Me.ToolTip1.SetToolTip(Me.lblremainintime, "Remaining Time of Running Clip")
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.BackColor = System.Drawing.Color.Yellow
        Me.lbltime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltime.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbltime.Location = New System.Drawing.Point(530, 9)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(137, 35)
        Me.lbltime.TabIndex = 613
        Me.lbltime.Text = "10:20:18"
        Me.ToolTip1.SetToolTip(Me.lbltime, "System Time")
        '
        'cmdScreenConsumer
        '
        Me.cmdScreenConsumer.Location = New System.Drawing.Point(307, 34)
        Me.cmdScreenConsumer.Name = "cmdScreenConsumer"
        Me.cmdScreenConsumer.Size = New System.Drawing.Size(102, 23)
        Me.cmdScreenConsumer.TabIndex = 1170
        Me.cmdScreenConsumer.Text = "Screen Consumer"
        Me.ToolTip1.SetToolTip(Me.cmdScreenConsumer, "Apply Yadif Filter on running clip")
        Me.cmdScreenConsumer.UseVisualStyleBackColor = True
        '
        'cmdVLCPreview
        '
        Me.cmdVLCPreview.Location = New System.Drawing.Point(414, 34)
        Me.cmdVLCPreview.Name = "cmdVLCPreview"
        Me.cmdVLCPreview.Size = New System.Drawing.Size(102, 23)
        Me.cmdVLCPreview.TabIndex = 1171
        Me.cmdVLCPreview.Text = "VLC Preview"
        Me.ToolTip1.SetToolTip(Me.cmdVLCPreview, "Apply Yadif Filter on running clip")
        Me.cmdVLCPreview.UseVisualStyleBackColor = True
        '
        'cmbfontsforall
        '
        Me.cmbfontsforall.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbfontsforall", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbfontsforall.FormattingEnabled = True
        Me.cmbfontsforall.Location = New System.Drawing.Point(700, 31)
        Me.cmbfontsforall.Name = "cmbfontsforall"
        Me.cmbfontsforall.Size = New System.Drawing.Size(157, 21)
        Me.cmbfontsforall.TabIndex = 538
        Me.cmbfontsforall.Text = Global.caspar_media_playback.My.MySettings.Default.cmbfontsforall
        Me.ToolTip1.SetToolTip(Me.cmbfontsforall, "Fonts of module which do not have font selection of their own.")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(403, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(22, 13)
        Me.Label15.TabIndex = 317
        Me.Label15.Text = "CH"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(462, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 319
        Me.Label7.Text = "Layer"
        '
        'rdoRecording
        '
        Me.rdoRecording.AutoSize = True
        Me.rdoRecording.Checked = True
        Me.rdoRecording.Location = New System.Drawing.Point(132, 11)
        Me.rdoRecording.Name = "rdoRecording"
        Me.rdoRecording.Size = New System.Drawing.Size(74, 17)
        Me.rdoRecording.TabIndex = 445
        Me.rdoRecording.TabStop = True
        Me.rdoRecording.Text = "Recording"
        Me.rdoRecording.UseVisualStyleBackColor = True
        '
        'rdoplaylist
        '
        Me.rdoplaylist.AutoSize = True
        Me.rdoplaylist.Location = New System.Drawing.Point(9, 11)
        Me.rdoplaylist.Name = "rdoplaylist"
        Me.rdoplaylist.Size = New System.Drawing.Size(57, 17)
        Me.rdoplaylist.TabIndex = 446
        Me.rdoplaylist.Text = "Playlist"
        Me.rdoplaylist.UseVisualStyleBackColor = True
        '
        'rdoswfplayer
        '
        Me.rdoswfplayer.AutoSize = True
        Me.rdoswfplayer.Location = New System.Drawing.Point(242, 49)
        Me.rdoswfplayer.Name = "rdoswfplayer"
        Me.rdoswfplayer.Size = New System.Drawing.Size(69, 17)
        Me.rdoswfplayer.TabIndex = 447
        Me.rdoswfplayer.Text = "swfplayer"
        Me.rdoswfplayer.UseVisualStyleBackColor = True
        '
        'rdoamcp
        '
        Me.rdoamcp.AutoSize = True
        Me.rdoamcp.Location = New System.Drawing.Point(618, 33)
        Me.rdoamcp.Name = "rdoamcp"
        Me.rdoamcp.Size = New System.Drawing.Size(55, 17)
        Me.rdoamcp.TabIndex = 452
        Me.rdoamcp.Text = "AMCP"
        Me.rdoamcp.UseVisualStyleBackColor = True
        '
        'rdoMixer
        '
        Me.rdoMixer.AutoSize = True
        Me.rdoMixer.Location = New System.Drawing.Point(366, 49)
        Me.rdoMixer.Name = "rdoMixer"
        Me.rdoMixer.Size = New System.Drawing.Size(50, 17)
        Me.rdoMixer.TabIndex = 451
        Me.rdoMixer.Text = "Mixer"
        Me.rdoMixer.UseVisualStyleBackColor = True
        '
        'rdoHorizontalScroll2
        '
        Me.rdoHorizontalScroll2.AutoSize = True
        Me.rdoHorizontalScroll2.Location = New System.Drawing.Point(393, 11)
        Me.rdoHorizontalScroll2.Name = "rdoHorizontalScroll2"
        Me.rdoHorizontalScroll2.Size = New System.Drawing.Size(46, 17)
        Me.rdoHorizontalScroll2.TabIndex = 450
        Me.rdoHorizontalScroll2.Text = "HS2"
        Me.rdoHorizontalScroll2.UseVisualStyleBackColor = True
        '
        'rdoHorizontalScroll1
        '
        Me.rdoHorizontalScroll1.AutoSize = True
        Me.rdoHorizontalScroll1.Location = New System.Drawing.Point(353, 11)
        Me.rdoHorizontalScroll1.Name = "rdoHorizontalScroll1"
        Me.rdoHorizontalScroll1.Size = New System.Drawing.Size(46, 17)
        Me.rdoHorizontalScroll1.TabIndex = 449
        Me.rdoHorizontalScroll1.Text = "HS1"
        Me.rdoHorizontalScroll1.UseVisualStyleBackColor = True
        '
        'rdoverticalscroll
        '
        Me.rdoverticalscroll.AutoSize = True
        Me.rdoverticalscroll.Location = New System.Drawing.Point(434, 11)
        Me.rdoverticalscroll.Name = "rdoverticalscroll"
        Me.rdoverticalscroll.Size = New System.Drawing.Size(39, 17)
        Me.rdoverticalscroll.TabIndex = 455
        Me.rdoverticalscroll.Text = "VS"
        Me.rdoverticalscroll.UseVisualStyleBackColor = True
        '
        'rdotemplate
        '
        Me.rdotemplate.AutoSize = True
        Me.rdotemplate.Location = New System.Drawing.Point(63, 10)
        Me.rdotemplate.Name = "rdotemplate"
        Me.rdotemplate.Size = New System.Drawing.Size(69, 17)
        Me.rdotemplate.TabIndex = 454
        Me.rdotemplate.Text = "Template"
        Me.rdotemplate.UseVisualStyleBackColor = True
        '
        'gbmodules
        '
        Me.gbmodules.Controls.Add(Me.rdoSG2016)
        Me.gbmodules.Controls.Add(Me.rdoWeightLifting)
        Me.gbmodules.Controls.Add(Me.rdoDavisCup)
        Me.gbmodules.Controls.Add(Me.rdoXdCamSoapClient)
        Me.gbmodules.Controls.Add(Me.rdoVDCP)
        Me.gbmodules.Controls.Add(Me.rdoCricket)
        Me.gbmodules.Controls.Add(Me.rdoCCTV)
        Me.gbmodules.Controls.Add(Me.rdo4ChannelRecorderAndTrimmer)
        Me.gbmodules.Controls.Add(Me.rdoOffAirLoggers)
        Me.gbmodules.Controls.Add(Me.rdoFourChannelPreview)
        Me.gbmodules.Controls.Add(Me.rdoFullPageCaption)
        Me.gbmodules.Controls.Add(Me.rdoSilenceDetector)
        Me.gbmodules.Controls.Add(Me.rdoStreamPlayer)
        Me.gbmodules.Controls.Add(Me.rdoWebSocketServer)
        Me.gbmodules.Controls.Add(Me.rdoHtmlTemplate)
        Me.gbmodules.Controls.Add(Me.rdoMySqlTest)
        Me.gbmodules.Controls.Add(Me.rdodBFSMeter)
        Me.gbmodules.Controls.Add(Me.rdoCustomControls)
        Me.gbmodules.Controls.Add(Me.rdoOSD)
        Me.gbmodules.Controls.Add(Me.rdoScheduler)
        Me.gbmodules.Controls.Add(Me.rdovlcstreamtester)
        Me.gbmodules.Controls.Add(Me.rdoSceneScroller)
        Me.gbmodules.Controls.Add(Me.rdoMultiBulletScroll)
        Me.gbmodules.Controls.Add(Me.rdoPlayFromAnywhere)
        Me.gbmodules.Controls.Add(Me.rdoPlayListSetting)
        Me.gbmodules.Controls.Add(Me.rdoWaterMarking)
        Me.gbmodules.Controls.Add(Me.rdoRemoteLogging)
        Me.gbmodules.Controls.Add(Me.rdosm2)
        Me.gbmodules.Controls.Add(Me.rdovs2)
        Me.gbmodules.Controls.Add(Me.rdoMAM)
        Me.gbmodules.Controls.Add(Me.rdometadata)
        Me.gbmodules.Controls.Add(Me.rdochannelinfo)
        Me.gbmodules.Controls.Add(Me.rdoudpchat)
        Me.gbmodules.Controls.Add(Me.rdostreaming)
        Me.gbmodules.Controls.Add(Me.rdotrimmer)
        Me.gbmodules.Controls.Add(Me.rdogames)
        Me.gbmodules.Controls.Add(Me.rdotimers)
        Me.gbmodules.Controls.Add(Me.rdosrt)
        Me.gbmodules.Controls.Add(Me.rdoquiz)
        Me.gbmodules.Controls.Add(Me.rdocg2)
        Me.gbmodules.Controls.Add(Me.rdoSongSubtitling)
        Me.gbmodules.Controls.Add(Me.rdohtmlscroller)
        Me.gbmodules.Controls.Add(Me.rdoelection)
        Me.gbmodules.Controls.Add(Me.rdohtml)
        Me.gbmodules.Controls.Add(Me.rdofacebook)
        Me.gbmodules.Controls.Add(Me.rdotwitter)
        Me.gbmodules.Controls.Add(Me.rdorss)
        Me.gbmodules.Controls.Add(Me.rdoweather)
        Me.gbmodules.Controls.Add(Me.rdoutility)
        Me.gbmodules.Controls.Add(Me.rdoosc)
        Me.gbmodules.Controls.Add(Me.rdoimagescroll)
        Me.gbmodules.Controls.Add(Me.rdooffairlogger)
        Me.gbmodules.Controls.Add(Me.rdoSlowMotion)
        Me.gbmodules.Controls.Add(Me.rdovisionmixer)
        Me.gbmodules.Controls.Add(Me.rdocg)
        Me.gbmodules.Controls.Add(Me.rdopowerpoint)
        Me.gbmodules.Controls.Add(Me.rdoTwoLiner)
        Me.gbmodules.Controls.Add(Me.rdooneliner)
        Me.gbmodules.Controls.Add(Me.rdoscroll)
        Me.gbmodules.Controls.Add(Me.rdoBreakingNews)
        Me.gbmodules.Controls.Add(Me.rdotemplate)
        Me.gbmodules.Controls.Add(Me.rdoverticalscroll)
        Me.gbmodules.Controls.Add(Me.rdoamcp)
        Me.gbmodules.Controls.Add(Me.rdoMixer)
        Me.gbmodules.Controls.Add(Me.rdoHorizontalScroll2)
        Me.gbmodules.Controls.Add(Me.rdoHorizontalScroll1)
        Me.gbmodules.Controls.Add(Me.rdoswfplayer)
        Me.gbmodules.Controls.Add(Me.rdoplaylist)
        Me.gbmodules.Controls.Add(Me.rdoRecording)
        Me.gbmodules.Location = New System.Drawing.Point(1476, 98)
        Me.gbmodules.Name = "gbmodules"
        Me.gbmodules.Size = New System.Drawing.Size(230, 73)
        Me.gbmodules.TabIndex = 456
        Me.gbmodules.TabStop = False
        Me.gbmodules.Text = "Modules"
        Me.gbmodules.Visible = False
        '
        'rdoSG2016
        '
        Me.rdoSG2016.AutoSize = True
        Me.rdoSG2016.Location = New System.Drawing.Point(513, 169)
        Me.rdoSG2016.Name = "rdoSG2016"
        Me.rdoSG2016.Size = New System.Drawing.Size(64, 17)
        Me.rdoSG2016.TabIndex = 529
        Me.rdoSG2016.Text = "SG2016"
        Me.rdoSG2016.UseVisualStyleBackColor = True
        '
        'rdoWeightLifting
        '
        Me.rdoWeightLifting.AutoSize = True
        Me.rdoWeightLifting.Location = New System.Drawing.Point(412, 167)
        Me.rdoWeightLifting.Name = "rdoWeightLifting"
        Me.rdoWeightLifting.Size = New System.Drawing.Size(87, 17)
        Me.rdoWeightLifting.TabIndex = 528
        Me.rdoWeightLifting.Text = "WeightLifting"
        Me.rdoWeightLifting.UseVisualStyleBackColor = True
        '
        'rdoDavisCup
        '
        Me.rdoDavisCup.AutoSize = True
        Me.rdoDavisCup.Location = New System.Drawing.Point(330, 167)
        Me.rdoDavisCup.Name = "rdoDavisCup"
        Me.rdoDavisCup.Size = New System.Drawing.Size(74, 17)
        Me.rdoDavisCup.TabIndex = 527
        Me.rdoDavisCup.Text = "Davis Cup"
        Me.rdoDavisCup.UseVisualStyleBackColor = True
        '
        'rdoXdCamSoapClient
        '
        Me.rdoXdCamSoapClient.AutoSize = True
        Me.rdoXdCamSoapClient.Location = New System.Drawing.Point(216, 167)
        Me.rdoXdCamSoapClient.Name = "rdoXdCamSoapClient"
        Me.rdoXdCamSoapClient.Size = New System.Drawing.Size(109, 17)
        Me.rdoXdCamSoapClient.TabIndex = 526
        Me.rdoXdCamSoapClient.Text = "XdcamSoapClient"
        Me.rdoXdCamSoapClient.UseVisualStyleBackColor = True
        '
        'rdoVDCP
        '
        Me.rdoVDCP.AutoSize = True
        Me.rdoVDCP.Location = New System.Drawing.Point(143, 167)
        Me.rdoVDCP.Name = "rdoVDCP"
        Me.rdoVDCP.Size = New System.Drawing.Size(54, 17)
        Me.rdoVDCP.TabIndex = 525
        Me.rdoVDCP.Text = "VDCP"
        Me.rdoVDCP.UseVisualStyleBackColor = True
        '
        'rdoCricket
        '
        Me.rdoCricket.AutoSize = True
        Me.rdoCricket.Location = New System.Drawing.Point(74, 167)
        Me.rdoCricket.Name = "rdoCricket"
        Me.rdoCricket.Size = New System.Drawing.Size(58, 17)
        Me.rdoCricket.TabIndex = 524
        Me.rdoCricket.Text = "Cricket"
        Me.rdoCricket.UseVisualStyleBackColor = True
        '
        'rdoCCTV
        '
        Me.rdoCCTV.AutoSize = True
        Me.rdoCCTV.Location = New System.Drawing.Point(13, 167)
        Me.rdoCCTV.Name = "rdoCCTV"
        Me.rdoCCTV.Size = New System.Drawing.Size(53, 17)
        Me.rdoCCTV.TabIndex = 523
        Me.rdoCCTV.Text = "CCTV"
        Me.rdoCCTV.UseVisualStyleBackColor = True
        '
        'rdo4ChannelRecorderAndTrimmer
        '
        Me.rdo4ChannelRecorderAndTrimmer.AutoSize = True
        Me.rdo4ChannelRecorderAndTrimmer.Location = New System.Drawing.Point(460, 146)
        Me.rdo4ChannelRecorderAndTrimmer.Name = "rdo4ChannelRecorderAndTrimmer"
        Me.rdo4ChannelRecorderAndTrimmer.Size = New System.Drawing.Size(181, 17)
        Me.rdo4ChannelRecorderAndTrimmer.TabIndex = 522
        Me.rdo4ChannelRecorderAndTrimmer.TabStop = True
        Me.rdo4ChannelRecorderAndTrimmer.Text = "4 channel Recorder And Trimmer"
        Me.rdo4ChannelRecorderAndTrimmer.UseVisualStyleBackColor = True
        '
        'rdoOffAirLoggers
        '
        Me.rdoOffAirLoggers.AutoSize = True
        Me.rdoOffAirLoggers.Location = New System.Drawing.Point(365, 147)
        Me.rdoOffAirLoggers.Name = "rdoOffAirLoggers"
        Me.rdoOffAirLoggers.Size = New System.Drawing.Size(89, 17)
        Me.rdoOffAirLoggers.TabIndex = 521
        Me.rdoOffAirLoggers.TabStop = True
        Me.rdoOffAirLoggers.Text = "OffAirLoggers"
        Me.rdoOffAirLoggers.UseVisualStyleBackColor = True
        '
        'rdoFourChannelPreview
        '
        Me.rdoFourChannelPreview.AutoSize = True
        Me.rdoFourChannelPreview.Location = New System.Drawing.Point(231, 146)
        Me.rdoFourChannelPreview.Name = "rdoFourChannelPreview"
        Me.rdoFourChannelPreview.Size = New System.Drawing.Size(123, 17)
        Me.rdoFourChannelPreview.TabIndex = 520
        Me.rdoFourChannelPreview.TabStop = True
        Me.rdoFourChannelPreview.Text = "FourChannelPreview"
        Me.rdoFourChannelPreview.UseVisualStyleBackColor = True
        '
        'rdoFullPageCaption
        '
        Me.rdoFullPageCaption.AutoSize = True
        Me.rdoFullPageCaption.Location = New System.Drawing.Point(117, 144)
        Me.rdoFullPageCaption.Name = "rdoFullPageCaption"
        Me.rdoFullPageCaption.Size = New System.Drawing.Size(108, 17)
        Me.rdoFullPageCaption.TabIndex = 519
        Me.rdoFullPageCaption.Text = "Full Page Caption"
        Me.rdoFullPageCaption.UseVisualStyleBackColor = True
        '
        'rdoSilenceDetector
        '
        Me.rdoSilenceDetector.AutoSize = True
        Me.rdoSilenceDetector.Location = New System.Drawing.Point(12, 144)
        Me.rdoSilenceDetector.Name = "rdoSilenceDetector"
        Me.rdoSilenceDetector.Size = New System.Drawing.Size(104, 17)
        Me.rdoSilenceDetector.TabIndex = 517
        Me.rdoSilenceDetector.Text = "Silence Detector"
        Me.rdoSilenceDetector.UseVisualStyleBackColor = True
        '
        'rdoStreamPlayer
        '
        Me.rdoStreamPlayer.AutoSize = True
        Me.rdoStreamPlayer.Location = New System.Drawing.Point(569, 124)
        Me.rdoStreamPlayer.Name = "rdoStreamPlayer"
        Me.rdoStreamPlayer.Size = New System.Drawing.Size(90, 17)
        Me.rdoStreamPlayer.TabIndex = 516
        Me.rdoStreamPlayer.Text = "Stream Player"
        Me.rdoStreamPlayer.UseVisualStyleBackColor = True
        '
        'rdoWebSocketServer
        '
        Me.rdoWebSocketServer.AutoSize = True
        Me.rdoWebSocketServer.Location = New System.Drawing.Point(443, 123)
        Me.rdoWebSocketServer.Name = "rdoWebSocketServer"
        Me.rdoWebSocketServer.Size = New System.Drawing.Size(113, 17)
        Me.rdoWebSocketServer.TabIndex = 515
        Me.rdoWebSocketServer.Text = "WebSocketServer"
        Me.rdoWebSocketServer.UseVisualStyleBackColor = True
        '
        'rdoHtmlTemplate
        '
        Me.rdoHtmlTemplate.AutoSize = True
        Me.rdoHtmlTemplate.Location = New System.Drawing.Point(347, 123)
        Me.rdoHtmlTemplate.Name = "rdoHtmlTemplate"
        Me.rdoHtmlTemplate.Size = New System.Drawing.Size(90, 17)
        Me.rdoHtmlTemplate.TabIndex = 514
        Me.rdoHtmlTemplate.Text = "HtmlTemplate"
        Me.rdoHtmlTemplate.UseVisualStyleBackColor = True
        '
        'rdoMySqlTest
        '
        Me.rdoMySqlTest.AutoSize = True
        Me.rdoMySqlTest.Location = New System.Drawing.Point(263, 123)
        Me.rdoMySqlTest.Name = "rdoMySqlTest"
        Me.rdoMySqlTest.Size = New System.Drawing.Size(78, 17)
        Me.rdoMySqlTest.TabIndex = 513
        Me.rdoMySqlTest.Text = "MySql Test"
        Me.rdoMySqlTest.UseVisualStyleBackColor = True
        '
        'rdodBFSMeter
        '
        Me.rdodBFSMeter.AutoSize = True
        Me.rdodBFSMeter.Location = New System.Drawing.Point(178, 122)
        Me.rdodBFSMeter.Name = "rdodBFSMeter"
        Me.rdodBFSMeter.Size = New System.Drawing.Size(81, 17)
        Me.rdodBFSMeter.TabIndex = 512
        Me.rdodBFSMeter.Text = "dBFS Meter"
        Me.rdodBFSMeter.UseVisualStyleBackColor = True
        '
        'rdoCustomControls
        '
        Me.rdoCustomControls.AutoSize = True
        Me.rdoCustomControls.Location = New System.Drawing.Point(71, 121)
        Me.rdoCustomControls.Name = "rdoCustomControls"
        Me.rdoCustomControls.Size = New System.Drawing.Size(101, 17)
        Me.rdoCustomControls.TabIndex = 511
        Me.rdoCustomControls.Text = "Custom Controls"
        Me.rdoCustomControls.UseVisualStyleBackColor = True
        '
        'rdoOSD
        '
        Me.rdoOSD.AutoSize = True
        Me.rdoOSD.Location = New System.Drawing.Point(12, 121)
        Me.rdoOSD.Name = "rdoOSD"
        Me.rdoOSD.Size = New System.Drawing.Size(48, 17)
        Me.rdoOSD.TabIndex = 510
        Me.rdoOSD.Text = "OSD"
        Me.rdoOSD.UseVisualStyleBackColor = True
        '
        'rdoScheduler
        '
        Me.rdoScheduler.AutoSize = True
        Me.rdoScheduler.Location = New System.Drawing.Point(559, 101)
        Me.rdoScheduler.Name = "rdoScheduler"
        Me.rdoScheduler.Size = New System.Drawing.Size(73, 17)
        Me.rdoScheduler.TabIndex = 509
        Me.rdoScheduler.Text = "Scheduler"
        Me.rdoScheduler.UseVisualStyleBackColor = True
        '
        'rdovlcstreamtester
        '
        Me.rdovlcstreamtester.AutoSize = True
        Me.rdovlcstreamtester.Location = New System.Drawing.Point(442, 100)
        Me.rdovlcstreamtester.Name = "rdovlcstreamtester"
        Me.rdovlcstreamtester.Size = New System.Drawing.Size(103, 17)
        Me.rdovlcstreamtester.TabIndex = 508
        Me.rdovlcstreamtester.Text = "VlcStreamTester"
        Me.rdovlcstreamtester.UseVisualStyleBackColor = True
        '
        'rdoSceneScroller
        '
        Me.rdoSceneScroller.AutoSize = True
        Me.rdoSceneScroller.Location = New System.Drawing.Point(341, 100)
        Me.rdoSceneScroller.Name = "rdoSceneScroller"
        Me.rdoSceneScroller.Size = New System.Drawing.Size(94, 17)
        Me.rdoSceneScroller.TabIndex = 507
        Me.rdoSceneScroller.Text = "Scene Scroller"
        Me.rdoSceneScroller.UseVisualStyleBackColor = True
        '
        'rdoMultiBulletScroll
        '
        Me.rdoMultiBulletScroll.AutoSize = True
        Me.rdoMultiBulletScroll.Location = New System.Drawing.Point(233, 100)
        Me.rdoMultiBulletScroll.Name = "rdoMultiBulletScroll"
        Me.rdoMultiBulletScroll.Size = New System.Drawing.Size(105, 17)
        Me.rdoMultiBulletScroll.TabIndex = 506
        Me.rdoMultiBulletScroll.Text = "Multi Bullet Scroll"
        Me.rdoMultiBulletScroll.UseVisualStyleBackColor = True
        '
        'rdoPlayFromAnywhere
        '
        Me.rdoPlayFromAnywhere.AutoSize = True
        Me.rdoPlayFromAnywhere.Location = New System.Drawing.Point(109, 99)
        Me.rdoPlayFromAnywhere.Name = "rdoPlayFromAnywhere"
        Me.rdoPlayFromAnywhere.Size = New System.Drawing.Size(121, 17)
        Me.rdoPlayFromAnywhere.TabIndex = 505
        Me.rdoPlayFromAnywhere.Text = "Play From Anywhere"
        Me.rdoPlayFromAnywhere.UseVisualStyleBackColor = True
        '
        'rdoPlayListSetting
        '
        Me.rdoPlayListSetting.AutoSize = True
        Me.rdoPlayListSetting.Location = New System.Drawing.Point(9, 100)
        Me.rdoPlayListSetting.Name = "rdoPlayListSetting"
        Me.rdoPlayListSetting.Size = New System.Drawing.Size(94, 17)
        Me.rdoPlayListSetting.TabIndex = 504
        Me.rdoPlayListSetting.Text = "PlayListSetting"
        Me.rdoPlayListSetting.UseVisualStyleBackColor = True
        '
        'rdoWaterMarking
        '
        Me.rdoWaterMarking.AutoSize = True
        Me.rdoWaterMarking.Location = New System.Drawing.Point(580, 51)
        Me.rdoWaterMarking.Name = "rdoWaterMarking"
        Me.rdoWaterMarking.Size = New System.Drawing.Size(95, 17)
        Me.rdoWaterMarking.TabIndex = 503
        Me.rdoWaterMarking.Text = "Water Marking"
        Me.rdoWaterMarking.UseVisualStyleBackColor = True
        '
        'rdoRemoteLogging
        '
        Me.rdoRemoteLogging.AutoSize = True
        Me.rdoRemoteLogging.Location = New System.Drawing.Point(559, 83)
        Me.rdoRemoteLogging.Name = "rdoRemoteLogging"
        Me.rdoRemoteLogging.Size = New System.Drawing.Size(103, 17)
        Me.rdoRemoteLogging.TabIndex = 501
        Me.rdoRemoteLogging.Text = "Remote Logging"
        Me.rdoRemoteLogging.UseVisualStyleBackColor = True
        '
        'rdosm2
        '
        Me.rdosm2.AutoSize = True
        Me.rdosm2.Location = New System.Drawing.Point(462, 85)
        Me.rdosm2.Name = "rdosm2"
        Me.rdosm2.Size = New System.Drawing.Size(91, 17)
        Me.rdosm2.TabIndex = 500
        Me.rdosm2.Text = "Slow motion 2"
        Me.rdosm2.UseVisualStyleBackColor = True
        '
        'rdovs2
        '
        Me.rdovs2.AutoSize = True
        Me.rdovs2.Location = New System.Drawing.Point(468, 11)
        Me.rdovs2.Name = "rdovs2"
        Me.rdovs2.Size = New System.Drawing.Size(45, 17)
        Me.rdovs2.TabIndex = 499
        Me.rdovs2.Text = "VS2"
        Me.rdovs2.UseVisualStyleBackColor = True
        '
        'rdoMAM
        '
        Me.rdoMAM.AutoSize = True
        Me.rdoMAM.Location = New System.Drawing.Point(478, 49)
        Me.rdoMAM.Name = "rdoMAM"
        Me.rdoMAM.Size = New System.Drawing.Size(50, 17)
        Me.rdoMAM.TabIndex = 497
        Me.rdoMAM.Text = "MAM"
        Me.rdoMAM.UseVisualStyleBackColor = True
        '
        'rdometadata
        '
        Me.rdometadata.AutoSize = True
        Me.rdometadata.Location = New System.Drawing.Point(460, 67)
        Me.rdometadata.Name = "rdometadata"
        Me.rdometadata.Size = New System.Drawing.Size(70, 17)
        Me.rdometadata.TabIndex = 495
        Me.rdometadata.Text = "Metadata"
        Me.rdometadata.UseVisualStyleBackColor = True
        '
        'rdochannelinfo
        '
        Me.rdochannelinfo.AutoSize = True
        Me.rdochannelinfo.Location = New System.Drawing.Point(375, 67)
        Me.rdochannelinfo.Name = "rdochannelinfo"
        Me.rdochannelinfo.Size = New System.Drawing.Size(85, 17)
        Me.rdochannelinfo.TabIndex = 494
        Me.rdochannelinfo.Text = "Channel Info"
        Me.rdochannelinfo.UseVisualStyleBackColor = True
        '
        'rdoudpchat
        '
        Me.rdoudpchat.AutoSize = True
        Me.rdoudpchat.Location = New System.Drawing.Point(293, 65)
        Me.rdoudpchat.Name = "rdoudpchat"
        Me.rdoudpchat.Size = New System.Drawing.Size(73, 17)
        Me.rdoudpchat.TabIndex = 493
        Me.rdoudpchat.Text = "UDP Chat"
        Me.rdoudpchat.UseVisualStyleBackColor = True
        '
        'rdostreaming
        '
        Me.rdostreaming.AutoSize = True
        Me.rdostreaming.Location = New System.Drawing.Point(219, 66)
        Me.rdostreaming.Name = "rdostreaming"
        Me.rdostreaming.Size = New System.Drawing.Size(72, 17)
        Me.rdostreaming.TabIndex = 492
        Me.rdostreaming.Text = "Streaming"
        Me.rdostreaming.UseVisualStyleBackColor = True
        '
        'rdotrimmer
        '
        Me.rdotrimmer.AutoSize = True
        Me.rdotrimmer.Location = New System.Drawing.Point(203, 11)
        Me.rdotrimmer.Name = "rdotrimmer"
        Me.rdotrimmer.Size = New System.Drawing.Size(62, 17)
        Me.rdotrimmer.TabIndex = 490
        Me.rdotrimmer.Text = "Trimmer"
        Me.rdotrimmer.UseVisualStyleBackColor = True
        '
        'rdogames
        '
        Me.rdogames.AutoSize = True
        Me.rdogames.Location = New System.Drawing.Point(9, 65)
        Me.rdogames.Name = "rdogames"
        Me.rdogames.Size = New System.Drawing.Size(64, 17)
        Me.rdogames.TabIndex = 489
        Me.rdogames.Text = "Games1"
        Me.rdogames.UseVisualStyleBackColor = True
        '
        'rdotimers
        '
        Me.rdotimers.AutoSize = True
        Me.rdotimers.Location = New System.Drawing.Point(528, 51)
        Me.rdotimers.Name = "rdotimers"
        Me.rdotimers.Size = New System.Drawing.Size(56, 17)
        Me.rdotimers.TabIndex = 488
        Me.rdotimers.Text = "Timers"
        Me.rdotimers.UseVisualStyleBackColor = True
        '
        'rdosrt
        '
        Me.rdosrt.AutoSize = True
        Me.rdosrt.Location = New System.Drawing.Point(430, 51)
        Me.rdosrt.Name = "rdosrt"
        Me.rdosrt.Size = New System.Drawing.Size(47, 17)
        Me.rdosrt.TabIndex = 487
        Me.rdosrt.Text = "SRT"
        Me.rdosrt.UseVisualStyleBackColor = True
        '
        'rdoquiz
        '
        Me.rdoquiz.AutoSize = True
        Me.rdoquiz.Location = New System.Drawing.Point(531, 66)
        Me.rdoquiz.Name = "rdoquiz"
        Me.rdoquiz.Size = New System.Drawing.Size(46, 17)
        Me.rdoquiz.TabIndex = 486
        Me.rdoquiz.Text = "Quiz"
        Me.rdoquiz.UseVisualStyleBackColor = True
        '
        'rdocg2
        '
        Me.rdocg2.AutoSize = True
        Me.rdocg2.Location = New System.Drawing.Point(459, 30)
        Me.rdocg2.Name = "rdocg2"
        Me.rdocg2.Size = New System.Drawing.Size(46, 17)
        Me.rdocg2.TabIndex = 484
        Me.rdocg2.Text = "CG2"
        Me.rdocg2.UseVisualStyleBackColor = True
        '
        'rdoSongSubtitling
        '
        Me.rdoSongSubtitling.AutoSize = True
        Me.rdoSongSubtitling.Location = New System.Drawing.Point(271, 82)
        Me.rdoSongSubtitling.Name = "rdoSongSubtitling"
        Me.rdoSongSubtitling.Size = New System.Drawing.Size(96, 17)
        Me.rdoSongSubtitling.TabIndex = 483
        Me.rdoSongSubtitling.Text = "Song Subtitling"
        Me.rdoSongSubtitling.UseVisualStyleBackColor = True
        '
        'rdohtmlscroller
        '
        Me.rdohtmlscroller.AutoSize = True
        Me.rdohtmlscroller.Location = New System.Drawing.Point(161, 31)
        Me.rdohtmlscroller.Name = "rdohtmlscroller"
        Me.rdohtmlscroller.Size = New System.Drawing.Size(93, 17)
        Me.rdohtmlscroller.TabIndex = 482
        Me.rdohtmlscroller.Text = "HTML Scroller"
        Me.rdohtmlscroller.UseVisualStyleBackColor = True
        '
        'rdoelection
        '
        Me.rdoelection.AutoSize = True
        Me.rdoelection.Location = New System.Drawing.Point(9, 82)
        Me.rdoelection.Name = "rdoelection"
        Me.rdoelection.Size = New System.Drawing.Size(63, 17)
        Me.rdoelection.TabIndex = 481
        Me.rdoelection.Text = "Election"
        Me.rdoelection.UseVisualStyleBackColor = True
        '
        'rdohtml
        '
        Me.rdohtml.AutoSize = True
        Me.rdohtml.Location = New System.Drawing.Point(74, 83)
        Me.rdohtml.Name = "rdohtml"
        Me.rdohtml.Size = New System.Drawing.Size(55, 17)
        Me.rdohtml.TabIndex = 479
        Me.rdohtml.Text = "HTML"
        Me.rdohtml.UseVisualStyleBackColor = True
        '
        'rdofacebook
        '
        Me.rdofacebook.AutoSize = True
        Me.rdofacebook.Location = New System.Drawing.Point(197, 83)
        Me.rdofacebook.Name = "rdofacebook"
        Me.rdofacebook.Size = New System.Drawing.Size(73, 17)
        Me.rdofacebook.TabIndex = 478
        Me.rdofacebook.Text = "Facebook"
        Me.rdofacebook.UseVisualStyleBackColor = True
        '
        'rdotwitter
        '
        Me.rdotwitter.AutoSize = True
        Me.rdotwitter.Location = New System.Drawing.Point(135, 82)
        Me.rdotwitter.Name = "rdotwitter"
        Me.rdotwitter.Size = New System.Drawing.Size(57, 17)
        Me.rdotwitter.TabIndex = 477
        Me.rdotwitter.Text = "Twitter"
        Me.rdotwitter.UseVisualStyleBackColor = True
        '
        'rdorss
        '
        Me.rdorss.AutoSize = True
        Me.rdorss.Location = New System.Drawing.Point(513, 13)
        Me.rdorss.Name = "rdorss"
        Me.rdorss.Size = New System.Drawing.Size(74, 17)
        Me.rdorss.TabIndex = 476
        Me.rdorss.Text = "RSS Feed"
        Me.rdorss.UseVisualStyleBackColor = True
        '
        'rdoweather
        '
        Me.rdoweather.AutoSize = True
        Me.rdoweather.Location = New System.Drawing.Point(9, 48)
        Me.rdoweather.Name = "rdoweather"
        Me.rdoweather.Size = New System.Drawing.Size(66, 17)
        Me.rdoweather.TabIndex = 470
        Me.rdoweather.Text = "Weather"
        Me.rdoweather.UseVisualStyleBackColor = True
        '
        'rdoutility
        '
        Me.rdoutility.AutoSize = True
        Me.rdoutility.Location = New System.Drawing.Point(310, 49)
        Me.rdoutility.Name = "rdoutility"
        Me.rdoutility.Size = New System.Drawing.Size(50, 17)
        Me.rdoutility.TabIndex = 468
        Me.rdoutility.Text = "Utility"
        Me.rdoutility.UseVisualStyleBackColor = True
        '
        'rdoosc
        '
        Me.rdoosc.AutoSize = True
        Me.rdoosc.Location = New System.Drawing.Point(569, 31)
        Me.rdoosc.Name = "rdoosc"
        Me.rdoosc.Size = New System.Drawing.Size(47, 17)
        Me.rdoosc.TabIndex = 467
        Me.rdoosc.Text = "OSC"
        Me.rdoosc.UseVisualStyleBackColor = True
        '
        'rdoimagescroll
        '
        Me.rdoimagescroll.AutoSize = True
        Me.rdoimagescroll.Location = New System.Drawing.Point(588, 11)
        Me.rdoimagescroll.Name = "rdoimagescroll"
        Me.rdoimagescroll.Size = New System.Drawing.Size(83, 17)
        Me.rdoimagescroll.TabIndex = 466
        Me.rdoimagescroll.Text = "Image Scroll"
        Me.rdoimagescroll.UseVisualStyleBackColor = True
        '
        'rdooffairlogger
        '
        Me.rdooffairlogger.AutoSize = True
        Me.rdooffairlogger.Location = New System.Drawing.Point(263, 11)
        Me.rdooffairlogger.Name = "rdooffairlogger"
        Me.rdooffairlogger.Size = New System.Drawing.Size(90, 17)
        Me.rdooffairlogger.TabIndex = 465
        Me.rdooffairlogger.Text = "Off Air Logger"
        Me.rdooffairlogger.UseVisualStyleBackColor = True
        '
        'rdoSlowMotion
        '
        Me.rdoSlowMotion.AutoSize = True
        Me.rdoSlowMotion.Location = New System.Drawing.Point(373, 84)
        Me.rdoSlowMotion.Name = "rdoSlowMotion"
        Me.rdoSlowMotion.Size = New System.Drawing.Size(83, 17)
        Me.rdoSlowMotion.TabIndex = 463
        Me.rdoSlowMotion.Text = "Slow Motion"
        Me.rdoSlowMotion.UseVisualStyleBackColor = True
        '
        'rdovisionmixer
        '
        Me.rdovisionmixer.AutoSize = True
        Me.rdovisionmixer.Location = New System.Drawing.Point(78, 48)
        Me.rdovisionmixer.Name = "rdovisionmixer"
        Me.rdovisionmixer.Size = New System.Drawing.Size(81, 17)
        Me.rdovisionmixer.TabIndex = 462
        Me.rdovisionmixer.Text = "Vision Mixer"
        Me.rdovisionmixer.UseVisualStyleBackColor = True
        '
        'rdocg
        '
        Me.rdocg.AutoSize = True
        Me.rdocg.Location = New System.Drawing.Point(413, 31)
        Me.rdocg.Name = "rdocg"
        Me.rdocg.Size = New System.Drawing.Size(40, 17)
        Me.rdocg.TabIndex = 461
        Me.rdocg.Text = "CG"
        Me.rdocg.UseVisualStyleBackColor = True
        '
        'rdopowerpoint
        '
        Me.rdopowerpoint.AutoSize = True
        Me.rdopowerpoint.Location = New System.Drawing.Point(160, 49)
        Me.rdopowerpoint.Name = "rdopowerpoint"
        Me.rdopowerpoint.Size = New System.Drawing.Size(77, 17)
        Me.rdopowerpoint.TabIndex = 460
        Me.rdopowerpoint.Text = "PPT/Excel"
        Me.rdopowerpoint.UseVisualStyleBackColor = True
        '
        'rdoTwoLiner
        '
        Me.rdoTwoLiner.AutoSize = True
        Me.rdoTwoLiner.Location = New System.Drawing.Point(328, 31)
        Me.rdoTwoLiner.Name = "rdoTwoLiner"
        Me.rdoTwoLiner.Size = New System.Drawing.Size(69, 17)
        Me.rdoTwoLiner.TabIndex = 459
        Me.rdoTwoLiner.Text = "TwoLiner"
        Me.rdoTwoLiner.UseVisualStyleBackColor = True
        '
        'rdooneliner
        '
        Me.rdooneliner.AutoSize = True
        Me.rdooneliner.Location = New System.Drawing.Point(256, 33)
        Me.rdooneliner.Name = "rdooneliner"
        Me.rdooneliner.Size = New System.Drawing.Size(68, 17)
        Me.rdooneliner.TabIndex = 458
        Me.rdooneliner.Text = "OneLiner"
        Me.rdooneliner.UseVisualStyleBackColor = True
        '
        'rdoscroll
        '
        Me.rdoscroll.AutoSize = True
        Me.rdoscroll.Location = New System.Drawing.Point(9, 30)
        Me.rdoscroll.Name = "rdoscroll"
        Me.rdoscroll.Size = New System.Drawing.Size(51, 17)
        Me.rdoscroll.TabIndex = 457
        Me.rdoscroll.Text = "Scroll"
        Me.rdoscroll.UseVisualStyleBackColor = True
        '
        'rdoBreakingNews
        '
        Me.rdoBreakingNews.AutoSize = True
        Me.rdoBreakingNews.Location = New System.Drawing.Point(63, 31)
        Me.rdoBreakingNews.Name = "rdoBreakingNews"
        Me.rdoBreakingNews.Size = New System.Drawing.Size(97, 17)
        Me.rdoBreakingNews.TabIndex = 456
        Me.rdoBreakingNews.Text = "Breaking News"
        Me.rdoBreakingNews.UseVisualStyleBackColor = True
        '
        'lblserverversion
        '
        Me.lblserverversion.AutoSize = True
        Me.lblserverversion.Location = New System.Drawing.Point(50, 3)
        Me.lblserverversion.Name = "lblserverversion"
        Me.lblserverversion.Size = New System.Drawing.Size(76, 13)
        Me.lblserverversion.TabIndex = 623
        Me.lblserverversion.Text = "Server Version"
        '
        'Label147
        '
        Me.Label147.AutoSize = True
        Me.Label147.Location = New System.Drawing.Point(13, 2)
        Me.Label147.Name = "Label147"
        Me.Label147.Size = New System.Drawing.Size(38, 13)
        Me.Label147.TabIndex = 624
        Me.Label147.Text = "Server"
        '
        'Label148
        '
        Me.Label148.AutoSize = True
        Me.Label148.Location = New System.Drawing.Point(19, 20)
        Me.Label148.Name = "Label148"
        Me.Label148.Size = New System.Drawing.Size(32, 13)
        Me.Label148.TabIndex = 626
        Me.Label148.Text = "Flash"
        '
        'lblflashversion
        '
        Me.lblflashversion.AutoSize = True
        Me.lblflashversion.Location = New System.Drawing.Point(50, 21)
        Me.lblflashversion.MaximumSize = New System.Drawing.Size(120, 15)
        Me.lblflashversion.Name = "lblflashversion"
        Me.lblflashversion.Size = New System.Drawing.Size(70, 13)
        Me.lblflashversion.TabIndex = 625
        Me.lblflashversion.Text = "Flash Version"
        '
        'Label150
        '
        Me.Label150.AutoSize = True
        Me.Label150.Location = New System.Drawing.Point(0, 37)
        Me.Label150.Name = "Label150"
        Me.Label150.Size = New System.Drawing.Size(51, 13)
        Me.Label150.TabIndex = 628
        Me.Label150.Text = "Template"
        '
        'lbltemplatehostversion
        '
        Me.lbltemplatehostversion.AutoSize = True
        Me.lbltemplatehostversion.Location = New System.Drawing.Point(50, 37)
        Me.lbltemplatehostversion.Name = "lbltemplatehostversion"
        Me.lbltemplatehostversion.Size = New System.Drawing.Size(89, 13)
        Me.lbltemplatehostversion.TabIndex = 627
        Me.lbltemplatehostversion.Text = "Template Version"
        '
        'mnuCMP
        '
        Me.mnuCMP.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuCMP.Dock = System.Windows.Forms.DockStyle.None
        Me.mnuCMP.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCMPPlayList, Me.mnuCMPTemplate, Me.mnuCMP4ChannelRecordingAndTrimming, Me.TrimmerToolStripMenuItem, Me.CGToolStripMenuItem, Me.ScrollersToolStripMenuItem, Me.GamesToolStripMenuItem, Me.ExternalSoftwaresToolStripMenuItem, Me.mnuCMPModules, Me.mnuCMPTools, Me.mnuCMPHelp})
        Me.mnuCMP.Location = New System.Drawing.Point(0, 0)
        Me.mnuCMP.Name = "mnuCMP"
        Me.mnuCMP.Size = New System.Drawing.Size(909, 24)
        Me.mnuCMP.TabIndex = 0
        Me.mnuCMP.TabStop = True
        Me.mnuCMP.Text = "mnuCMP"
        '
        'mnuCMPPlayList
        '
        Me.mnuCMPPlayList.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VideoServerToolStripMenuItem, Me.PlayFromAnywhreToolStripMenuItem})
        Me.mnuCMPPlayList.Name = "mnuCMPPlayList"
        Me.mnuCMPPlayList.Size = New System.Drawing.Size(84, 20)
        Me.mnuCMPPlayList.Text = "Video Player"
        '
        'VideoServerToolStripMenuItem
        '
        Me.VideoServerToolStripMenuItem.Name = "VideoServerToolStripMenuItem"
        Me.VideoServerToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.VideoServerToolStripMenuItem.Text = "Video Server"
        '
        'PlayFromAnywhreToolStripMenuItem
        '
        Me.PlayFromAnywhreToolStripMenuItem.Name = "PlayFromAnywhreToolStripMenuItem"
        Me.PlayFromAnywhreToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.PlayFromAnywhreToolStripMenuItem.Text = "Play From Anywhre"
        '
        'mnuCMPTemplate
        '
        Me.mnuCMPTemplate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FlashTemplateToolStripMenuItem, Me.HtmlTemplateToolStripMenuItem1})
        Me.mnuCMPTemplate.Name = "mnuCMPTemplate"
        Me.mnuCMPTemplate.Size = New System.Drawing.Size(67, 20)
        Me.mnuCMPTemplate.Text = "&Template"
        '
        'FlashTemplateToolStripMenuItem
        '
        Me.FlashTemplateToolStripMenuItem.Name = "FlashTemplateToolStripMenuItem"
        Me.FlashTemplateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FlashTemplateToolStripMenuItem.Text = "Flash Template"
        '
        'HtmlTemplateToolStripMenuItem1
        '
        Me.HtmlTemplateToolStripMenuItem1.Name = "HtmlTemplateToolStripMenuItem1"
        Me.HtmlTemplateToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.HtmlTemplateToolStripMenuItem1.Text = "Html Template"
        '
        'mnuCMP4ChannelRecordingAndTrimming
        '
        Me.mnuCMP4ChannelRecordingAndTrimming.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChannelRecorderAndTrimmerToolStripMenuItem, Me.GeneralRecorderToolStripMenuItem, Me.OffAirLoggerToolStripMenuItem2, Me.ChannelOffAirLoggerToolStripMenuItem})
        Me.mnuCMP4ChannelRecordingAndTrimming.Name = "mnuCMP4ChannelRecordingAndTrimming"
        Me.mnuCMP4ChannelRecordingAndTrimming.Size = New System.Drawing.Size(152, 20)
        Me.mnuCMP4ChannelRecordingAndTrimming.Text = "Recording And Trimming"
        '
        'ChannelRecorderAndTrimmerToolStripMenuItem
        '
        Me.ChannelRecorderAndTrimmerToolStripMenuItem.Name = "ChannelRecorderAndTrimmerToolStripMenuItem"
        Me.ChannelRecorderAndTrimmerToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ChannelRecorderAndTrimmerToolStripMenuItem.Text = "4 Channel Recorder And Trimmer"
        '
        'GeneralRecorderToolStripMenuItem
        '
        Me.GeneralRecorderToolStripMenuItem.Name = "GeneralRecorderToolStripMenuItem"
        Me.GeneralRecorderToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.GeneralRecorderToolStripMenuItem.Text = "General Recorder"
        '
        'OffAirLoggerToolStripMenuItem2
        '
        Me.OffAirLoggerToolStripMenuItem2.Name = "OffAirLoggerToolStripMenuItem2"
        Me.OffAirLoggerToolStripMenuItem2.Size = New System.Drawing.Size(249, 22)
        Me.OffAirLoggerToolStripMenuItem2.Text = "Off Air Logger"
        '
        'ChannelOffAirLoggerToolStripMenuItem
        '
        Me.ChannelOffAirLoggerToolStripMenuItem.Name = "ChannelOffAirLoggerToolStripMenuItem"
        Me.ChannelOffAirLoggerToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ChannelOffAirLoggerToolStripMenuItem.Text = "4 Channel Off Air Logger"
        '
        'TrimmerToolStripMenuItem
        '
        Me.TrimmerToolStripMenuItem.Name = "TrimmerToolStripMenuItem"
        Me.TrimmerToolStripMenuItem.Size = New System.Drawing.Size(142, 20)
        Me.TrimmerToolStripMenuItem.Text = "Trimming _Transcoding"
        '
        'CGToolStripMenuItem
        '
        Me.CGToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CG1ToolStripMenuItem, Me.CG2ToolStripMenuItem, Me.OnelinerToolStripMenuItem, Me.TwolinerToolStripMenuItem1, Me.PPTEXcellToolStripMenuItem1, Me.WaterMarkingToolStripMenuItem1, Me.QuizeToolStripMenuItem, Me.WeatherToolStripMenuItem, Me.RCCAutomationToolStripMenuItem})
        Me.CGToolStripMenuItem.Name = "CGToolStripMenuItem"
        Me.CGToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.CGToolStripMenuItem.Text = "CG"
        '
        'CG1ToolStripMenuItem
        '
        Me.CG1ToolStripMenuItem.Name = "CG1ToolStripMenuItem"
        Me.CG1ToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CG1ToolStripMenuItem.Text = "CG1"
        '
        'CG2ToolStripMenuItem
        '
        Me.CG2ToolStripMenuItem.Name = "CG2ToolStripMenuItem"
        Me.CG2ToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CG2ToolStripMenuItem.Text = "CG2"
        '
        'OnelinerToolStripMenuItem
        '
        Me.OnelinerToolStripMenuItem.Name = "OnelinerToolStripMenuItem"
        Me.OnelinerToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.OnelinerToolStripMenuItem.Text = "Oneliner"
        '
        'TwolinerToolStripMenuItem1
        '
        Me.TwolinerToolStripMenuItem1.Name = "TwolinerToolStripMenuItem1"
        Me.TwolinerToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.TwolinerToolStripMenuItem1.Text = "Twoliner"
        '
        'PPTEXcellToolStripMenuItem1
        '
        Me.PPTEXcellToolStripMenuItem1.Name = "PPTEXcellToolStripMenuItem1"
        Me.PPTEXcellToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.PPTEXcellToolStripMenuItem1.Text = "PPT/EXcell"
        '
        'WaterMarkingToolStripMenuItem1
        '
        Me.WaterMarkingToolStripMenuItem1.Name = "WaterMarkingToolStripMenuItem1"
        Me.WaterMarkingToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.WaterMarkingToolStripMenuItem1.Text = "Water Marking"
        '
        'QuizeToolStripMenuItem
        '
        Me.QuizeToolStripMenuItem.Name = "QuizeToolStripMenuItem"
        Me.QuizeToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.QuizeToolStripMenuItem.Text = "Quiz"
        '
        'WeatherToolStripMenuItem
        '
        Me.WeatherToolStripMenuItem.Name = "WeatherToolStripMenuItem"
        Me.WeatherToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.WeatherToolStripMenuItem.Text = "Weather"
        '
        'RCCAutomationToolStripMenuItem
        '
        Me.RCCAutomationToolStripMenuItem.Name = "RCCAutomationToolStripMenuItem"
        Me.RCCAutomationToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RCCAutomationToolStripMenuItem.Text = "RCC Automation"
        '
        'ScrollersToolStripMenuItem
        '
        Me.ScrollersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScrollToolStripMenuItem, Me.HTMLScrollerToolStripMenuItem, Me.MultiBulletScrollerToolStripMenuItem, Me.ImageScrollerToolStripMenuItem, Me.HorizontalScroll1ToolStripMenuItem, Me.HorizontalScroll2ToolStripMenuItem, Me.RSSFeedAsScrollBReakingNewsAndClockToolStripMenuItem, Me.SceneScrollerToolStripMenuItem, Me.VerticalScroll1ToolStripMenuItem, Me.VerticalScroll2ToolStripMenuItem})
        Me.ScrollersToolStripMenuItem.Name = "ScrollersToolStripMenuItem"
        Me.ScrollersToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ScrollersToolStripMenuItem.Text = "Scrollers"
        '
        'ScrollToolStripMenuItem
        '
        Me.ScrollToolStripMenuItem.Name = "ScrollToolStripMenuItem"
        Me.ScrollToolStripMenuItem.Size = New System.Drawing.Size(308, 22)
        Me.ScrollToolStripMenuItem.Text = "Scroll And Breaking News"
        '
        'HTMLScrollerToolStripMenuItem
        '
        Me.HTMLScrollerToolStripMenuItem.Name = "HTMLScrollerToolStripMenuItem"
        Me.HTMLScrollerToolStripMenuItem.Size = New System.Drawing.Size(308, 22)
        Me.HTMLScrollerToolStripMenuItem.Text = "HTML Scroller"
        '
        'MultiBulletScrollerToolStripMenuItem
        '
        Me.MultiBulletScrollerToolStripMenuItem.Name = "MultiBulletScrollerToolStripMenuItem"
        Me.MultiBulletScrollerToolStripMenuItem.Size = New System.Drawing.Size(308, 22)
        Me.MultiBulletScrollerToolStripMenuItem.Text = "MultiBullet Scroller"
        '
        'ImageScrollerToolStripMenuItem
        '
        Me.ImageScrollerToolStripMenuItem.Name = "ImageScrollerToolStripMenuItem"
        Me.ImageScrollerToolStripMenuItem.Size = New System.Drawing.Size(308, 22)
        Me.ImageScrollerToolStripMenuItem.Text = "Image Scroller"
        '
        'HorizontalScroll1ToolStripMenuItem
        '
        Me.HorizontalScroll1ToolStripMenuItem.Name = "HorizontalScroll1ToolStripMenuItem"
        Me.HorizontalScroll1ToolStripMenuItem.Size = New System.Drawing.Size(308, 22)
        Me.HorizontalScroll1ToolStripMenuItem.Text = "Horizontal Scroll1 "
        '
        'HorizontalScroll2ToolStripMenuItem
        '
        Me.HorizontalScroll2ToolStripMenuItem.Name = "HorizontalScroll2ToolStripMenuItem"
        Me.HorizontalScroll2ToolStripMenuItem.Size = New System.Drawing.Size(308, 22)
        Me.HorizontalScroll2ToolStripMenuItem.Text = "Horizontal Scroll 2"
        '
        'RSSFeedAsScrollBReakingNewsAndClockToolStripMenuItem
        '
        Me.RSSFeedAsScrollBReakingNewsAndClockToolStripMenuItem.Name = "RSSFeedAsScrollBReakingNewsAndClockToolStripMenuItem"
        Me.RSSFeedAsScrollBReakingNewsAndClockToolStripMenuItem.Size = New System.Drawing.Size(308, 22)
        Me.RSSFeedAsScrollBReakingNewsAndClockToolStripMenuItem.Text = "RSS feed as Scroll, BReaking News and Clock"
        '
        'SceneScrollerToolStripMenuItem
        '
        Me.SceneScrollerToolStripMenuItem.Name = "SceneScrollerToolStripMenuItem"
        Me.SceneScrollerToolStripMenuItem.Size = New System.Drawing.Size(308, 22)
        Me.SceneScrollerToolStripMenuItem.Text = "Scene Scroller"
        '
        'VerticalScroll1ToolStripMenuItem
        '
        Me.VerticalScroll1ToolStripMenuItem.Name = "VerticalScroll1ToolStripMenuItem"
        Me.VerticalScroll1ToolStripMenuItem.Size = New System.Drawing.Size(308, 22)
        Me.VerticalScroll1ToolStripMenuItem.Text = "Vertical Scroll 1"
        '
        'VerticalScroll2ToolStripMenuItem
        '
        Me.VerticalScroll2ToolStripMenuItem.Name = "VerticalScroll2ToolStripMenuItem"
        Me.VerticalScroll2ToolStripMenuItem.Size = New System.Drawing.Size(308, 22)
        Me.VerticalScroll2ToolStripMenuItem.Text = "Vertical Scroll 2"
        '
        'GamesToolStripMenuItem
        '
        Me.GamesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NationalGamesKerlaToolStripMenuItem, Me.SouthAsianGamesGuwahati2016ToolStripMenuItem, Me.CricketToolStripMenuItem1, Me.DaviceCupToolStripMenuItem, Me.OnScreenDrawingToolStripMenuItem, Me.WeightLiftingToolStripMenuItem1, Me.RCCBallToolStripMenuItem})
        Me.GamesToolStripMenuItem.Name = "GamesToolStripMenuItem"
        Me.GamesToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.GamesToolStripMenuItem.Text = "Games"
        '
        'NationalGamesKerlaToolStripMenuItem
        '
        Me.NationalGamesKerlaToolStripMenuItem.Name = "NationalGamesKerlaToolStripMenuItem"
        Me.NationalGamesKerlaToolStripMenuItem.Size = New System.Drawing.Size(256, 22)
        Me.NationalGamesKerlaToolStripMenuItem.Text = "National Games Kerla 2015"
        '
        'SouthAsianGamesGuwahati2016ToolStripMenuItem
        '
        Me.SouthAsianGamesGuwahati2016ToolStripMenuItem.Name = "SouthAsianGamesGuwahati2016ToolStripMenuItem"
        Me.SouthAsianGamesGuwahati2016ToolStripMenuItem.Size = New System.Drawing.Size(256, 22)
        Me.SouthAsianGamesGuwahati2016ToolStripMenuItem.Text = "South Asian Games Guwahati 2016"
        '
        'CricketToolStripMenuItem1
        '
        Me.CricketToolStripMenuItem1.Name = "CricketToolStripMenuItem1"
        Me.CricketToolStripMenuItem1.Size = New System.Drawing.Size(256, 22)
        Me.CricketToolStripMenuItem1.Text = "Cricket"
        '
        'DaviceCupToolStripMenuItem
        '
        Me.DaviceCupToolStripMenuItem.Name = "DaviceCupToolStripMenuItem"
        Me.DaviceCupToolStripMenuItem.Size = New System.Drawing.Size(256, 22)
        Me.DaviceCupToolStripMenuItem.Text = "Davice Cup"
        '
        'OnScreenDrawingToolStripMenuItem
        '
        Me.OnScreenDrawingToolStripMenuItem.Name = "OnScreenDrawingToolStripMenuItem"
        Me.OnScreenDrawingToolStripMenuItem.Size = New System.Drawing.Size(256, 22)
        Me.OnScreenDrawingToolStripMenuItem.Text = "On Screen Drawing"
        '
        'WeightLiftingToolStripMenuItem1
        '
        Me.WeightLiftingToolStripMenuItem1.Name = "WeightLiftingToolStripMenuItem1"
        Me.WeightLiftingToolStripMenuItem1.Size = New System.Drawing.Size(256, 22)
        Me.WeightLiftingToolStripMenuItem1.Text = "Weight Lifting"
        '
        'RCCBallToolStripMenuItem
        '
        Me.RCCBallToolStripMenuItem.Name = "RCCBallToolStripMenuItem"
        Me.RCCBallToolStripMenuItem.Size = New System.Drawing.Size(256, 22)
        Me.RCCBallToolStripMenuItem.Text = "RCCBall"
        '
        'ExternalSoftwaresToolStripMenuItem
        '
        Me.ExternalSoftwaresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MediaAssetManagementToolStripMenuItem, Me.XDCamSoapClientToolStripMenuItem1, Me.VDCPControllerToolStripMenuItem, Me.UDPChatToolStripMenuItem, Me.MetadataToolStripMenuItem, Me.XDCamControllersToolStripMenuItem, Me.YouTubeLiveManagemnetToolStripMenuItem})
        Me.ExternalSoftwaresToolStripMenuItem.Name = "ExternalSoftwaresToolStripMenuItem"
        Me.ExternalSoftwaresToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.ExternalSoftwaresToolStripMenuItem.Text = "External Softwares"
        '
        'MediaAssetManagementToolStripMenuItem
        '
        Me.MediaAssetManagementToolStripMenuItem.Name = "MediaAssetManagementToolStripMenuItem"
        Me.MediaAssetManagementToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.MediaAssetManagementToolStripMenuItem.Text = "Media Asset Management"
        '
        'XDCamSoapClientToolStripMenuItem1
        '
        Me.XDCamSoapClientToolStripMenuItem1.Name = "XDCamSoapClientToolStripMenuItem1"
        Me.XDCamSoapClientToolStripMenuItem1.Size = New System.Drawing.Size(221, 22)
        Me.XDCamSoapClientToolStripMenuItem1.Text = "XDCamSoapClient"
        '
        'VDCPControllerToolStripMenuItem
        '
        Me.VDCPControllerToolStripMenuItem.Name = "VDCPControllerToolStripMenuItem"
        Me.VDCPControllerToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.VDCPControllerToolStripMenuItem.Text = "VDCP Controller"
        '
        'UDPChatToolStripMenuItem
        '
        Me.UDPChatToolStripMenuItem.Name = "UDPChatToolStripMenuItem"
        Me.UDPChatToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.UDPChatToolStripMenuItem.Text = "UDP Chat"
        '
        'MetadataToolStripMenuItem
        '
        Me.MetadataToolStripMenuItem.Name = "MetadataToolStripMenuItem"
        Me.MetadataToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.MetadataToolStripMenuItem.Text = "Metadata"
        '
        'XDCamControllersToolStripMenuItem
        '
        Me.XDCamControllersToolStripMenuItem.Name = "XDCamControllersToolStripMenuItem"
        Me.XDCamControllersToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.XDCamControllersToolStripMenuItem.Text = "XDCamControllers"
        '
        'YouTubeLiveManagemnetToolStripMenuItem
        '
        Me.YouTubeLiveManagemnetToolStripMenuItem.Name = "YouTubeLiveManagemnetToolStripMenuItem"
        Me.YouTubeLiveManagemnetToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.YouTubeLiveManagemnetToolStripMenuItem.Text = "You Tube Live Managemnet"
        '
        'mnuCMPModules
        '
        Me.mnuCMPModules.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCMPStreaming, Me.mnuStreamPlayer, Me.mnuCMPSubTitling, Me.mnuCMPSlowMotion, Me.mnuCMPSocialMedia, Me.VLCToolStripMenuItem, Me.mnuCMPMixer, Me.mnuCMPVisionMixer, Me.mnuCMPOSC, Me.SilenceDetectorToolStripMenuItem, Me.mnuCMPElection, Me.mnuCMPTimers, Me.DBFSMeter16ChannelToolStripMenuItem, Me.CCTVToolStripMenuItem, Me.CommandSchedulerToolStripMenuItem, Me.CommandSchedulerDateWiseToolStripMenuItem, Me.MySqlTestToolStripMenuItem, Me.WebSocketServerToolStripMenuItem, Me.FullPageCaptionToolStripMenuItem, Me.mnuCMPRemoteLogging, Me.TabPagesToolStripMenuItem, Me.CompositionToolStripMenuItem, Me.TemplatePlaylistToolStripMenuItem})
        Me.mnuCMPModules.Name = "mnuCMPModules"
        Me.mnuCMPModules.Size = New System.Drawing.Size(98, 20)
        Me.mnuCMPModules.Text = "&Other Modules"
        '
        'mnuCMPStreaming
        '
        Me.mnuCMPStreaming.Name = "mnuCMPStreaming"
        Me.mnuCMPStreaming.Size = New System.Drawing.Size(238, 22)
        Me.mnuCMPStreaming.Text = "Streaming"
        '
        'mnuStreamPlayer
        '
        Me.mnuStreamPlayer.Name = "mnuStreamPlayer"
        Me.mnuStreamPlayer.Size = New System.Drawing.Size(238, 22)
        Me.mnuStreamPlayer.Text = "Stream Player"
        '
        'mnuCMPSubTitling
        '
        Me.mnuCMPSubTitling.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCMPSRTPlayer, Me.mnuCMPSongSubTitling})
        Me.mnuCMPSubTitling.Name = "mnuCMPSubTitling"
        Me.mnuCMPSubTitling.Size = New System.Drawing.Size(238, 22)
        Me.mnuCMPSubTitling.Text = "SubTitling"
        '
        'mnuCMPSRTPlayer
        '
        Me.mnuCMPSRTPlayer.Name = "mnuCMPSRTPlayer"
        Me.mnuCMPSRTPlayer.Size = New System.Drawing.Size(157, 22)
        Me.mnuCMPSRTPlayer.Text = "SRT Player"
        '
        'mnuCMPSongSubTitling
        '
        Me.mnuCMPSongSubTitling.Name = "mnuCMPSongSubTitling"
        Me.mnuCMPSongSubTitling.Size = New System.Drawing.Size(157, 22)
        Me.mnuCMPSongSubTitling.Text = "Song SubTitling"
        '
        'mnuCMPSlowMotion
        '
        Me.mnuCMPSlowMotion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCMPSlowMotionInServer21, Me.mnuCMPSlowMotionInJStarServer})
        Me.mnuCMPSlowMotion.Name = "mnuCMPSlowMotion"
        Me.mnuCMPSlowMotion.Size = New System.Drawing.Size(238, 22)
        Me.mnuCMPSlowMotion.Text = "Slow Motion"
        '
        'mnuCMPSlowMotionInServer21
        '
        Me.mnuCMPSlowMotionInServer21.Name = "mnuCMPSlowMotionInServer21"
        Me.mnuCMPSlowMotionInServer21.Size = New System.Drawing.Size(219, 22)
        Me.mnuCMPSlowMotionInServer21.Text = "Slow Motion In Server 2.1"
        '
        'mnuCMPSlowMotionInJStarServer
        '
        Me.mnuCMPSlowMotionInJStarServer.Name = "mnuCMPSlowMotionInJStarServer"
        Me.mnuCMPSlowMotionInJStarServer.Size = New System.Drawing.Size(219, 22)
        Me.mnuCMPSlowMotionInJStarServer.Text = "Slow Motion in J Star Server"
        '
        'mnuCMPSocialMedia
        '
        Me.mnuCMPSocialMedia.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCMPFacebook, Me.mnuCMPTwitter, Me.mnuCMPHTMLorInternet})
        Me.mnuCMPSocialMedia.Name = "mnuCMPSocialMedia"
        Me.mnuCMPSocialMedia.Size = New System.Drawing.Size(238, 22)
        Me.mnuCMPSocialMedia.Text = "Social Media"
        '
        'mnuCMPFacebook
        '
        Me.mnuCMPFacebook.Name = "mnuCMPFacebook"
        Me.mnuCMPFacebook.Size = New System.Drawing.Size(161, 22)
        Me.mnuCMPFacebook.Text = "Facebook"
        '
        'mnuCMPTwitter
        '
        Me.mnuCMPTwitter.Name = "mnuCMPTwitter"
        Me.mnuCMPTwitter.Size = New System.Drawing.Size(161, 22)
        Me.mnuCMPTwitter.Text = "Twitter"
        '
        'mnuCMPHTMLorInternet
        '
        Me.mnuCMPHTMLorInternet.Name = "mnuCMPHTMLorInternet"
        Me.mnuCMPHTMLorInternet.Size = New System.Drawing.Size(161, 22)
        Me.mnuCMPHTMLorInternet.Text = "HTMLor Internet"
        '
        'VLCToolStripMenuItem
        '
        Me.VLCToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StreamTesterToolStripMenuItem, Me.FourChannelPreviewToolStripMenuItem})
        Me.VLCToolStripMenuItem.Name = "VLCToolStripMenuItem"
        Me.VLCToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.VLCToolStripMenuItem.Text = "VLC"
        '
        'StreamTesterToolStripMenuItem
        '
        Me.StreamTesterToolStripMenuItem.Name = "StreamTesterToolStripMenuItem"
        Me.StreamTesterToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.StreamTesterToolStripMenuItem.Text = "Stream Tester"
        '
        'FourChannelPreviewToolStripMenuItem
        '
        Me.FourChannelPreviewToolStripMenuItem.Name = "FourChannelPreviewToolStripMenuItem"
        Me.FourChannelPreviewToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.FourChannelPreviewToolStripMenuItem.Text = "Four Channel Preview"
        '
        'mnuCMPMixer
        '
        Me.mnuCMPMixer.Name = "mnuCMPMixer"
        Me.mnuCMPMixer.Size = New System.Drawing.Size(238, 22)
        Me.mnuCMPMixer.Text = "Mixer"
        '
        'mnuCMPVisionMixer
        '
        Me.mnuCMPVisionMixer.Name = "mnuCMPVisionMixer"
        Me.mnuCMPVisionMixer.Size = New System.Drawing.Size(238, 22)
        Me.mnuCMPVisionMixer.Text = "Vision Mixer"
        '
        'mnuCMPOSC
        '
        Me.mnuCMPOSC.Name = "mnuCMPOSC"
        Me.mnuCMPOSC.Size = New System.Drawing.Size(238, 22)
        Me.mnuCMPOSC.Text = "OSC"
        '
        'SilenceDetectorToolStripMenuItem
        '
        Me.SilenceDetectorToolStripMenuItem.Name = "SilenceDetectorToolStripMenuItem"
        Me.SilenceDetectorToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.SilenceDetectorToolStripMenuItem.Text = "Silence Detector"
        '
        'mnuCMPElection
        '
        Me.mnuCMPElection.Name = "mnuCMPElection"
        Me.mnuCMPElection.Size = New System.Drawing.Size(238, 22)
        Me.mnuCMPElection.Text = "Election"
        '
        'mnuCMPTimers
        '
        Me.mnuCMPTimers.Name = "mnuCMPTimers"
        Me.mnuCMPTimers.Size = New System.Drawing.Size(238, 22)
        Me.mnuCMPTimers.Text = "Timers"
        '
        'DBFSMeter16ChannelToolStripMenuItem
        '
        Me.DBFSMeter16ChannelToolStripMenuItem.Name = "DBFSMeter16ChannelToolStripMenuItem"
        Me.DBFSMeter16ChannelToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.DBFSMeter16ChannelToolStripMenuItem.Text = "dBFS Meter 16 Channel"
        '
        'CCTVToolStripMenuItem
        '
        Me.CCTVToolStripMenuItem.Name = "CCTVToolStripMenuItem"
        Me.CCTVToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.CCTVToolStripMenuItem.Text = "CCTV"
        '
        'CommandSchedulerToolStripMenuItem
        '
        Me.CommandSchedulerToolStripMenuItem.Name = "CommandSchedulerToolStripMenuItem"
        Me.CommandSchedulerToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.CommandSchedulerToolStripMenuItem.Text = "Command Scheduler"
        '
        'CommandSchedulerDateWiseToolStripMenuItem
        '
        Me.CommandSchedulerDateWiseToolStripMenuItem.Name = "CommandSchedulerDateWiseToolStripMenuItem"
        Me.CommandSchedulerDateWiseToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.CommandSchedulerDateWiseToolStripMenuItem.Text = "Command Scheduler DateWise"
        '
        'MySqlTestToolStripMenuItem
        '
        Me.MySqlTestToolStripMenuItem.Name = "MySqlTestToolStripMenuItem"
        Me.MySqlTestToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.MySqlTestToolStripMenuItem.Text = "SqlTest"
        '
        'WebSocketServerToolStripMenuItem
        '
        Me.WebSocketServerToolStripMenuItem.Name = "WebSocketServerToolStripMenuItem"
        Me.WebSocketServerToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.WebSocketServerToolStripMenuItem.Text = "Web Socket Server"
        '
        'FullPageCaptionToolStripMenuItem
        '
        Me.FullPageCaptionToolStripMenuItem.Name = "FullPageCaptionToolStripMenuItem"
        Me.FullPageCaptionToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.FullPageCaptionToolStripMenuItem.Text = "FullPageCaption"
        '
        'mnuCMPRemoteLogging
        '
        Me.mnuCMPRemoteLogging.Name = "mnuCMPRemoteLogging"
        Me.mnuCMPRemoteLogging.Size = New System.Drawing.Size(238, 22)
        Me.mnuCMPRemoteLogging.Text = "Remote Logging"
        '
        'TabPagesToolStripMenuItem
        '
        Me.TabPagesToolStripMenuItem.Name = "TabPagesToolStripMenuItem"
        Me.TabPagesToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.TabPagesToolStripMenuItem.Text = "Tab Pages"
        '
        'CompositionToolStripMenuItem
        '
        Me.CompositionToolStripMenuItem.Name = "CompositionToolStripMenuItem"
        Me.CompositionToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.CompositionToolStripMenuItem.Text = "Composition"
        '
        'TemplatePlaylistToolStripMenuItem
        '
        Me.TemplatePlaylistToolStripMenuItem.Name = "TemplatePlaylistToolStripMenuItem"
        Me.TemplatePlaylistToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.TemplatePlaylistToolStripMenuItem.Text = "Template Playlist"
        '
        'mnuCMPTools
        '
        Me.mnuCMPTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCMPAddScreen, Me.AddOutput, Me.RemoveOutput, Me.Play_Input, Me.mnuCMPRemoveScreen, Me.mnuCMPResetSettings, Me.mnuCMPEditConfigFile, Me.mnuCMPRestartCasparcgServer, Me.mnuCMPRestartwithConfigFile, Me.mnuCMPQuitCasparcgServer, Me.mnuCMPCopyExampleTemplates, Me.mnuCMPCopyExampleMedia, Me.mnuCMPCasparcgDiagnosisWndow, Me.mnuCMPClearTypeSwitch, Me.mnuCMPPALSD, Me.mnuCMPHD108050i, Me.NewInstanceToolStripMenuItem, Me.ExitApplicationToolStripMenuItem, Me.DifferentConfigFilesToolStripMenuItem, Me.LoadLastLayoutToolStripMenuItem, Me.SaveLayoutToolStripMenuItem, Me.ClearTempFileAndRecycleBinToolStripMenuItem, Me.MakeThumbnailForServer23ToolStripMenuItem})
        Me.mnuCMPTools.Name = "mnuCMPTools"
        Me.mnuCMPTools.Size = New System.Drawing.Size(46, 20)
        Me.mnuCMPTools.Text = "&Tools"
        '
        'mnuCMPAddScreen
        '
        Me.mnuCMPAddScreen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Channel1ToolStripMenuItem, Me.Channel2ToolStripMenuItem, Me.Channel3ToolStripMenuItem, Me.Channel4ToolStripMenuItem})
        Me.mnuCMPAddScreen.Name = "mnuCMPAddScreen"
        Me.mnuCMPAddScreen.Size = New System.Drawing.Size(242, 22)
        Me.mnuCMPAddScreen.Text = "Add Screen"
        '
        'Channel1ToolStripMenuItem
        '
        Me.Channel1ToolStripMenuItem.Name = "Channel1ToolStripMenuItem"
        Me.Channel1ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Channel1ToolStripMenuItem.Text = "Channel 1"
        '
        'Channel2ToolStripMenuItem
        '
        Me.Channel2ToolStripMenuItem.Name = "Channel2ToolStripMenuItem"
        Me.Channel2ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Channel2ToolStripMenuItem.Text = "Channel 2"
        '
        'Channel3ToolStripMenuItem
        '
        Me.Channel3ToolStripMenuItem.Name = "Channel3ToolStripMenuItem"
        Me.Channel3ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Channel3ToolStripMenuItem.Text = "Channel 3"
        '
        'Channel4ToolStripMenuItem
        '
        Me.Channel4ToolStripMenuItem.Name = "Channel4ToolStripMenuItem"
        Me.Channel4ToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.Channel4ToolStripMenuItem.Text = "Channel 4"
        '
        'AddOutput
        '
        Me.AddOutput.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddputputFill, Me.AddputputKey})
        Me.AddOutput.Name = "AddOutput"
        Me.AddOutput.Size = New System.Drawing.Size(242, 22)
        Me.AddOutput.Text = "Add output"
        '
        'AddputputFill
        '
        Me.AddputputFill.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddOutputFillDecklink, Me.AddOutputFillBluefish})
        Me.AddputputFill.Name = "AddputputFill"
        Me.AddputputFill.Size = New System.Drawing.Size(93, 22)
        Me.AddputputFill.Text = "Fill"
        '
        'AddOutputFillDecklink
        '
        Me.AddOutputFillDecklink.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Add_Ouput_Fill_decklink_1, Me.Add_Ouput_Fill_decklink_2, Me.Add_Ouput_Fill_decklink_3, Me.Add_Ouput_Fill_decklink_4, Me.Add_Ouput_Fill_decklink_5, Me.Add_Ouput_Fill_decklink_6, Me.Add_Ouput_Fill_decklink_7, Me.Add_Ouput_Fill_decklink_8})
        Me.AddOutputFillDecklink.Name = "AddOutputFillDecklink"
        Me.AddOutputFillDecklink.Size = New System.Drawing.Size(119, 22)
        Me.AddOutputFillDecklink.Text = "Decklink"
        '
        'Add_Ouput_Fill_decklink_1
        '
        Me.Add_Ouput_Fill_decklink_1.Name = "Add_Ouput_Fill_decklink_1"
        Me.Add_Ouput_Fill_decklink_1.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_Fill_decklink_1.Text = "1"
        '
        'Add_Ouput_Fill_decklink_2
        '
        Me.Add_Ouput_Fill_decklink_2.Name = "Add_Ouput_Fill_decklink_2"
        Me.Add_Ouput_Fill_decklink_2.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_Fill_decklink_2.Text = "2"
        '
        'Add_Ouput_Fill_decklink_3
        '
        Me.Add_Ouput_Fill_decklink_3.Name = "Add_Ouput_Fill_decklink_3"
        Me.Add_Ouput_Fill_decklink_3.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_Fill_decklink_3.Text = "3"
        '
        'Add_Ouput_Fill_decklink_4
        '
        Me.Add_Ouput_Fill_decklink_4.Name = "Add_Ouput_Fill_decklink_4"
        Me.Add_Ouput_Fill_decklink_4.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_Fill_decklink_4.Text = "4"
        '
        'Add_Ouput_Fill_decklink_5
        '
        Me.Add_Ouput_Fill_decklink_5.Name = "Add_Ouput_Fill_decklink_5"
        Me.Add_Ouput_Fill_decklink_5.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_Fill_decklink_5.Text = "5"
        '
        'Add_Ouput_Fill_decklink_6
        '
        Me.Add_Ouput_Fill_decklink_6.Name = "Add_Ouput_Fill_decklink_6"
        Me.Add_Ouput_Fill_decklink_6.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_Fill_decklink_6.Text = "6"
        '
        'Add_Ouput_Fill_decklink_7
        '
        Me.Add_Ouput_Fill_decklink_7.Name = "Add_Ouput_Fill_decklink_7"
        Me.Add_Ouput_Fill_decklink_7.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_Fill_decklink_7.Text = "7"
        '
        'Add_Ouput_Fill_decklink_8
        '
        Me.Add_Ouput_Fill_decklink_8.Name = "Add_Ouput_Fill_decklink_8"
        Me.Add_Ouput_Fill_decklink_8.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_Fill_decklink_8.Text = "8"
        '
        'AddOutputFillBluefish
        '
        Me.AddOutputFillBluefish.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Add_Ouput_Fill_Bluefish_1, Me.Add_Ouput_Fill_Bluefish_2, Me.Add_Ouput_Fill_Bluefish_3, Me.Add_Ouput_Fill_Bluefish_4, Me.Add_Ouput_Fill_Bluefish_5, Me.Add_Ouput_Fill_Bluefish_6, Me.Add_Ouput_Fill_Bluefish_7, Me.Add_Ouput_Fill_Bluefish_8})
        Me.AddOutputFillBluefish.Name = "AddOutputFillBluefish"
        Me.AddOutputFillBluefish.Size = New System.Drawing.Size(119, 22)
        Me.AddOutputFillBluefish.Text = "Bluefish"
        '
        'Add_Ouput_Fill_Bluefish_1
        '
        Me.Add_Ouput_Fill_Bluefish_1.Name = "Add_Ouput_Fill_Bluefish_1"
        Me.Add_Ouput_Fill_Bluefish_1.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_Fill_Bluefish_1.Text = "1"
        '
        'Add_Ouput_Fill_Bluefish_2
        '
        Me.Add_Ouput_Fill_Bluefish_2.Name = "Add_Ouput_Fill_Bluefish_2"
        Me.Add_Ouput_Fill_Bluefish_2.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_Fill_Bluefish_2.Text = "2"
        '
        'Add_Ouput_Fill_Bluefish_3
        '
        Me.Add_Ouput_Fill_Bluefish_3.Name = "Add_Ouput_Fill_Bluefish_3"
        Me.Add_Ouput_Fill_Bluefish_3.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_Fill_Bluefish_3.Text = "3"
        '
        'Add_Ouput_Fill_Bluefish_4
        '
        Me.Add_Ouput_Fill_Bluefish_4.Name = "Add_Ouput_Fill_Bluefish_4"
        Me.Add_Ouput_Fill_Bluefish_4.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_Fill_Bluefish_4.Text = "4"
        '
        'Add_Ouput_Fill_Bluefish_5
        '
        Me.Add_Ouput_Fill_Bluefish_5.Name = "Add_Ouput_Fill_Bluefish_5"
        Me.Add_Ouput_Fill_Bluefish_5.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_Fill_Bluefish_5.Text = "5"
        '
        'Add_Ouput_Fill_Bluefish_6
        '
        Me.Add_Ouput_Fill_Bluefish_6.Name = "Add_Ouput_Fill_Bluefish_6"
        Me.Add_Ouput_Fill_Bluefish_6.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_Fill_Bluefish_6.Text = "6"
        '
        'Add_Ouput_Fill_Bluefish_7
        '
        Me.Add_Ouput_Fill_Bluefish_7.Name = "Add_Ouput_Fill_Bluefish_7"
        Me.Add_Ouput_Fill_Bluefish_7.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_Fill_Bluefish_7.Text = "7"
        '
        'Add_Ouput_Fill_Bluefish_8
        '
        Me.Add_Ouput_Fill_Bluefish_8.Name = "Add_Ouput_Fill_Bluefish_8"
        Me.Add_Ouput_Fill_Bluefish_8.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_Fill_Bluefish_8.Text = "8"
        '
        'AddputputKey
        '
        Me.AddputputKey.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddOutputKeyDecklink, Me.AddOutputKeyBluefish})
        Me.AddputputKey.Name = "AddputputKey"
        Me.AddputputKey.Size = New System.Drawing.Size(93, 22)
        Me.AddputputKey.Text = "Key"
        '
        'AddOutputKeyDecklink
        '
        Me.AddOutputKeyDecklink.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Add_Ouput_key_Decklink_1, Me.Add_Ouput_key_Decklink_2, Me.Add_Ouput_key_Decklink_3, Me.Add_Ouput_key_Decklink_4, Me.Add_Ouput_key_Decklink_5, Me.Add_Ouput_key_Decklink_6, Me.Add_Ouput_key_Decklink_7, Me.Add_Ouput_key_Decklink_8})
        Me.AddOutputKeyDecklink.Name = "AddOutputKeyDecklink"
        Me.AddOutputKeyDecklink.Size = New System.Drawing.Size(119, 22)
        Me.AddOutputKeyDecklink.Text = "Decklink"
        '
        'Add_Ouput_key_Decklink_1
        '
        Me.Add_Ouput_key_Decklink_1.Name = "Add_Ouput_key_Decklink_1"
        Me.Add_Ouput_key_Decklink_1.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_key_Decklink_1.Text = "1"
        '
        'Add_Ouput_key_Decklink_2
        '
        Me.Add_Ouput_key_Decklink_2.Name = "Add_Ouput_key_Decklink_2"
        Me.Add_Ouput_key_Decklink_2.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_key_Decklink_2.Text = "2"
        '
        'Add_Ouput_key_Decklink_3
        '
        Me.Add_Ouput_key_Decklink_3.Name = "Add_Ouput_key_Decklink_3"
        Me.Add_Ouput_key_Decklink_3.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_key_Decklink_3.Text = "3"
        '
        'Add_Ouput_key_Decklink_4
        '
        Me.Add_Ouput_key_Decklink_4.Name = "Add_Ouput_key_Decklink_4"
        Me.Add_Ouput_key_Decklink_4.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_key_Decklink_4.Text = "4"
        '
        'Add_Ouput_key_Decklink_5
        '
        Me.Add_Ouput_key_Decklink_5.Name = "Add_Ouput_key_Decklink_5"
        Me.Add_Ouput_key_Decklink_5.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_key_Decklink_5.Text = "5"
        '
        'Add_Ouput_key_Decklink_6
        '
        Me.Add_Ouput_key_Decklink_6.Name = "Add_Ouput_key_Decklink_6"
        Me.Add_Ouput_key_Decklink_6.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_key_Decklink_6.Text = "6"
        '
        'Add_Ouput_key_Decklink_7
        '
        Me.Add_Ouput_key_Decklink_7.Name = "Add_Ouput_key_Decklink_7"
        Me.Add_Ouput_key_Decklink_7.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_key_Decklink_7.Text = "7"
        '
        'Add_Ouput_key_Decklink_8
        '
        Me.Add_Ouput_key_Decklink_8.Name = "Add_Ouput_key_Decklink_8"
        Me.Add_Ouput_key_Decklink_8.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_key_Decklink_8.Text = "8"
        '
        'AddOutputKeyBluefish
        '
        Me.AddOutputKeyBluefish.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Add_Ouput_key_Bluefish_1, Me.Add_Ouput_key_Bluefish_2, Me.Add_Ouput_key_Bluefish_3, Me.Add_Ouput_key_Bluefish_4, Me.Add_Ouput_key_Bluefish_5, Me.Add_Ouput_key_Bluefish_6, Me.Add_Ouput_key_Bluefish_7, Me.Add_Ouput_key_Bluefish_8})
        Me.AddOutputKeyBluefish.Name = "AddOutputKeyBluefish"
        Me.AddOutputKeyBluefish.Size = New System.Drawing.Size(119, 22)
        Me.AddOutputKeyBluefish.Text = "Bluefish"
        '
        'Add_Ouput_key_Bluefish_1
        '
        Me.Add_Ouput_key_Bluefish_1.Name = "Add_Ouput_key_Bluefish_1"
        Me.Add_Ouput_key_Bluefish_1.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_key_Bluefish_1.Text = "1"
        '
        'Add_Ouput_key_Bluefish_2
        '
        Me.Add_Ouput_key_Bluefish_2.Name = "Add_Ouput_key_Bluefish_2"
        Me.Add_Ouput_key_Bluefish_2.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_key_Bluefish_2.Text = "2"
        '
        'Add_Ouput_key_Bluefish_3
        '
        Me.Add_Ouput_key_Bluefish_3.Name = "Add_Ouput_key_Bluefish_3"
        Me.Add_Ouput_key_Bluefish_3.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_key_Bluefish_3.Text = "3"
        '
        'Add_Ouput_key_Bluefish_4
        '
        Me.Add_Ouput_key_Bluefish_4.Name = "Add_Ouput_key_Bluefish_4"
        Me.Add_Ouput_key_Bluefish_4.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_key_Bluefish_4.Text = "4"
        '
        'Add_Ouput_key_Bluefish_5
        '
        Me.Add_Ouput_key_Bluefish_5.Name = "Add_Ouput_key_Bluefish_5"
        Me.Add_Ouput_key_Bluefish_5.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_key_Bluefish_5.Text = "5"
        '
        'Add_Ouput_key_Bluefish_6
        '
        Me.Add_Ouput_key_Bluefish_6.Name = "Add_Ouput_key_Bluefish_6"
        Me.Add_Ouput_key_Bluefish_6.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_key_Bluefish_6.Text = "6"
        '
        'Add_Ouput_key_Bluefish_7
        '
        Me.Add_Ouput_key_Bluefish_7.Name = "Add_Ouput_key_Bluefish_7"
        Me.Add_Ouput_key_Bluefish_7.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_key_Bluefish_7.Text = "7"
        '
        'Add_Ouput_key_Bluefish_8
        '
        Me.Add_Ouput_key_Bluefish_8.Name = "Add_Ouput_key_Bluefish_8"
        Me.Add_Ouput_key_Bluefish_8.Size = New System.Drawing.Size(80, 22)
        Me.Add_Ouput_key_Bluefish_8.Text = "8"
        '
        'RemoveOutput
        '
        Me.RemoveOutput.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveOutputDecklink, Me.RemoveOutputBluefish})
        Me.RemoveOutput.Name = "RemoveOutput"
        Me.RemoveOutput.Size = New System.Drawing.Size(242, 22)
        Me.RemoveOutput.Text = "Remove output"
        '
        'RemoveOutputDecklink
        '
        Me.RemoveOutputDecklink.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Remove_Ouput__decklink_1, Me.Remove_Ouput__decklink_2, Me.Remove_Ouput__decklink_3, Me.Remove_Ouput__decklink_4, Me.Remove_Ouput__decklink_5, Me.Remove_Ouput__decklink_6, Me.Remove_Ouput__decklink_7, Me.Remove_Ouput__decklink_8})
        Me.RemoveOutputDecklink.Name = "RemoveOutputDecklink"
        Me.RemoveOutputDecklink.Size = New System.Drawing.Size(119, 22)
        Me.RemoveOutputDecklink.Text = "Decklink"
        '
        'Remove_Ouput__decklink_1
        '
        Me.Remove_Ouput__decklink_1.Name = "Remove_Ouput__decklink_1"
        Me.Remove_Ouput__decklink_1.Size = New System.Drawing.Size(80, 22)
        Me.Remove_Ouput__decklink_1.Text = "1"
        '
        'Remove_Ouput__decklink_2
        '
        Me.Remove_Ouput__decklink_2.Name = "Remove_Ouput__decklink_2"
        Me.Remove_Ouput__decklink_2.Size = New System.Drawing.Size(80, 22)
        Me.Remove_Ouput__decklink_2.Text = "2"
        '
        'Remove_Ouput__decklink_3
        '
        Me.Remove_Ouput__decklink_3.Name = "Remove_Ouput__decklink_3"
        Me.Remove_Ouput__decklink_3.Size = New System.Drawing.Size(80, 22)
        Me.Remove_Ouput__decklink_3.Text = "3"
        '
        'Remove_Ouput__decklink_4
        '
        Me.Remove_Ouput__decklink_4.Name = "Remove_Ouput__decklink_4"
        Me.Remove_Ouput__decklink_4.Size = New System.Drawing.Size(80, 22)
        Me.Remove_Ouput__decklink_4.Text = "4"
        '
        'Remove_Ouput__decklink_5
        '
        Me.Remove_Ouput__decklink_5.Name = "Remove_Ouput__decklink_5"
        Me.Remove_Ouput__decklink_5.Size = New System.Drawing.Size(80, 22)
        Me.Remove_Ouput__decklink_5.Text = "5"
        '
        'Remove_Ouput__decklink_6
        '
        Me.Remove_Ouput__decklink_6.Name = "Remove_Ouput__decklink_6"
        Me.Remove_Ouput__decklink_6.Size = New System.Drawing.Size(80, 22)
        Me.Remove_Ouput__decklink_6.Text = "6"
        '
        'Remove_Ouput__decklink_7
        '
        Me.Remove_Ouput__decklink_7.Name = "Remove_Ouput__decklink_7"
        Me.Remove_Ouput__decklink_7.Size = New System.Drawing.Size(80, 22)
        Me.Remove_Ouput__decklink_7.Text = "7"
        '
        'Remove_Ouput__decklink_8
        '
        Me.Remove_Ouput__decklink_8.Name = "Remove_Ouput__decklink_8"
        Me.Remove_Ouput__decklink_8.Size = New System.Drawing.Size(80, 22)
        Me.Remove_Ouput__decklink_8.Text = "8"
        '
        'RemoveOutputBluefish
        '
        Me.RemoveOutputBluefish.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Remove_Output__Bluefish_1, Me.Remove_Output__Bluefish_2, Me.Remove_Output__Bluefish_3, Me.Remove_Output__Bluefish_4, Me.Remove_Output__Bluefish_5, Me.Remove_Output__Bluefish_6, Me.Remove_Output__Bluefish_7, Me.Remove_Output__Bluefish_8})
        Me.RemoveOutputBluefish.Name = "RemoveOutputBluefish"
        Me.RemoveOutputBluefish.Size = New System.Drawing.Size(119, 22)
        Me.RemoveOutputBluefish.Text = "Bluefish"
        '
        'Remove_Output__Bluefish_1
        '
        Me.Remove_Output__Bluefish_1.Name = "Remove_Output__Bluefish_1"
        Me.Remove_Output__Bluefish_1.Size = New System.Drawing.Size(80, 22)
        Me.Remove_Output__Bluefish_1.Text = "1"
        '
        'Remove_Output__Bluefish_2
        '
        Me.Remove_Output__Bluefish_2.Name = "Remove_Output__Bluefish_2"
        Me.Remove_Output__Bluefish_2.Size = New System.Drawing.Size(80, 22)
        Me.Remove_Output__Bluefish_2.Text = "2"
        '
        'Remove_Output__Bluefish_3
        '
        Me.Remove_Output__Bluefish_3.Name = "Remove_Output__Bluefish_3"
        Me.Remove_Output__Bluefish_3.Size = New System.Drawing.Size(80, 22)
        Me.Remove_Output__Bluefish_3.Text = "3"
        '
        'Remove_Output__Bluefish_4
        '
        Me.Remove_Output__Bluefish_4.Name = "Remove_Output__Bluefish_4"
        Me.Remove_Output__Bluefish_4.Size = New System.Drawing.Size(80, 22)
        Me.Remove_Output__Bluefish_4.Text = "4"
        '
        'Remove_Output__Bluefish_5
        '
        Me.Remove_Output__Bluefish_5.Name = "Remove_Output__Bluefish_5"
        Me.Remove_Output__Bluefish_5.Size = New System.Drawing.Size(80, 22)
        Me.Remove_Output__Bluefish_5.Text = "5"
        '
        'Remove_Output__Bluefish_6
        '
        Me.Remove_Output__Bluefish_6.Name = "Remove_Output__Bluefish_6"
        Me.Remove_Output__Bluefish_6.Size = New System.Drawing.Size(80, 22)
        Me.Remove_Output__Bluefish_6.Text = "6"
        '
        'Remove_Output__Bluefish_7
        '
        Me.Remove_Output__Bluefish_7.Name = "Remove_Output__Bluefish_7"
        Me.Remove_Output__Bluefish_7.Size = New System.Drawing.Size(80, 22)
        Me.Remove_Output__Bluefish_7.Text = "7"
        '
        'Remove_Output__Bluefish_8
        '
        Me.Remove_Output__Bluefish_8.Name = "Remove_Output__Bluefish_8"
        Me.Remove_Output__Bluefish_8.Size = New System.Drawing.Size(80, 22)
        Me.Remove_Output__Bluefish_8.Text = "8"
        '
        'Play_Input
        '
        Me.Play_Input.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Play_Input__decklink})
        Me.Play_Input.Name = "Play_Input"
        Me.Play_Input.Size = New System.Drawing.Size(242, 22)
        Me.Play_Input.Text = "Play Input"
        '
        'Play_Input__decklink
        '
        Me.Play_Input__decklink.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Play_Input__decklink_1, Me.Play_Input__decklink_2, Me.Play_Input__decklink_3, Me.Play_Input__decklink_4, Me.Play_Input__decklink_5, Me.Play_Input__decklink_6, Me.Play_Input__decklink_7, Me.Play_Input__decklink_8})
        Me.Play_Input__decklink.Name = "Play_Input__decklink"
        Me.Play_Input__decklink.Size = New System.Drawing.Size(119, 22)
        Me.Play_Input__decklink.Text = "Decklink"
        '
        'Play_Input__decklink_1
        '
        Me.Play_Input__decklink_1.Name = "Play_Input__decklink_1"
        Me.Play_Input__decklink_1.Size = New System.Drawing.Size(80, 22)
        Me.Play_Input__decklink_1.Text = "1"
        '
        'Play_Input__decklink_2
        '
        Me.Play_Input__decklink_2.Name = "Play_Input__decklink_2"
        Me.Play_Input__decklink_2.Size = New System.Drawing.Size(80, 22)
        Me.Play_Input__decklink_2.Text = "2"
        '
        'Play_Input__decklink_3
        '
        Me.Play_Input__decklink_3.Name = "Play_Input__decklink_3"
        Me.Play_Input__decklink_3.Size = New System.Drawing.Size(80, 22)
        Me.Play_Input__decklink_3.Text = "3"
        '
        'Play_Input__decklink_4
        '
        Me.Play_Input__decklink_4.Name = "Play_Input__decklink_4"
        Me.Play_Input__decklink_4.Size = New System.Drawing.Size(80, 22)
        Me.Play_Input__decklink_4.Text = "4"
        '
        'Play_Input__decklink_5
        '
        Me.Play_Input__decklink_5.Name = "Play_Input__decklink_5"
        Me.Play_Input__decklink_5.Size = New System.Drawing.Size(80, 22)
        Me.Play_Input__decklink_5.Text = "5"
        '
        'Play_Input__decklink_6
        '
        Me.Play_Input__decklink_6.Name = "Play_Input__decklink_6"
        Me.Play_Input__decklink_6.Size = New System.Drawing.Size(80, 22)
        Me.Play_Input__decklink_6.Text = "6"
        '
        'Play_Input__decklink_7
        '
        Me.Play_Input__decklink_7.Name = "Play_Input__decklink_7"
        Me.Play_Input__decklink_7.Size = New System.Drawing.Size(80, 22)
        Me.Play_Input__decklink_7.Text = "7"
        '
        'Play_Input__decklink_8
        '
        Me.Play_Input__decklink_8.Name = "Play_Input__decklink_8"
        Me.Play_Input__decklink_8.Size = New System.Drawing.Size(80, 22)
        Me.Play_Input__decklink_8.Text = "8"
        '
        'mnuCMPRemoveScreen
        '
        Me.mnuCMPRemoveScreen.Name = "mnuCMPRemoveScreen"
        Me.mnuCMPRemoveScreen.Size = New System.Drawing.Size(242, 22)
        Me.mnuCMPRemoveScreen.Text = "Remove Screen"
        '
        'mnuCMPResetSettings
        '
        Me.mnuCMPResetSettings.Name = "mnuCMPResetSettings"
        Me.mnuCMPResetSettings.Size = New System.Drawing.Size(242, 22)
        Me.mnuCMPResetSettings.Text = "Reset Settings"
        '
        'mnuCMPEditConfigFile
        '
        Me.mnuCMPEditConfigFile.Name = "mnuCMPEditConfigFile"
        Me.mnuCMPEditConfigFile.Size = New System.Drawing.Size(242, 22)
        Me.mnuCMPEditConfigFile.Text = "Edit Config File"
        '
        'mnuCMPRestartCasparcgServer
        '
        Me.mnuCMPRestartCasparcgServer.Name = "mnuCMPRestartCasparcgServer"
        Me.mnuCMPRestartCasparcgServer.Size = New System.Drawing.Size(242, 22)
        Me.mnuCMPRestartCasparcgServer.Text = "Restart Casparcg Server"
        '
        'mnuCMPRestartwithConfigFile
        '
        Me.mnuCMPRestartwithConfigFile.Name = "mnuCMPRestartwithConfigFile"
        Me.mnuCMPRestartwithConfigFile.Size = New System.Drawing.Size(242, 22)
        Me.mnuCMPRestartwithConfigFile.Text = "Restart with Config file"
        '
        'mnuCMPQuitCasparcgServer
        '
        Me.mnuCMPQuitCasparcgServer.Name = "mnuCMPQuitCasparcgServer"
        Me.mnuCMPQuitCasparcgServer.Size = New System.Drawing.Size(242, 22)
        Me.mnuCMPQuitCasparcgServer.Text = "Quit Casparcg Server"
        '
        'mnuCMPCopyExampleTemplates
        '
        Me.mnuCMPCopyExampleTemplates.Name = "mnuCMPCopyExampleTemplates"
        Me.mnuCMPCopyExampleTemplates.Size = New System.Drawing.Size(242, 22)
        Me.mnuCMPCopyExampleTemplates.Text = "Copy Example Templates"
        '
        'mnuCMPCopyExampleMedia
        '
        Me.mnuCMPCopyExampleMedia.Name = "mnuCMPCopyExampleMedia"
        Me.mnuCMPCopyExampleMedia.Size = New System.Drawing.Size(242, 22)
        Me.mnuCMPCopyExampleMedia.Text = "Copy Example Media"
        '
        'mnuCMPCasparcgDiagnosisWndow
        '
        Me.mnuCMPCasparcgDiagnosisWndow.Name = "mnuCMPCasparcgDiagnosisWndow"
        Me.mnuCMPCasparcgDiagnosisWndow.Size = New System.Drawing.Size(242, 22)
        Me.mnuCMPCasparcgDiagnosisWndow.Text = "Casparcg Diagnosis Wndow"
        '
        'mnuCMPClearTypeSwitch
        '
        Me.mnuCMPClearTypeSwitch.Name = "mnuCMPClearTypeSwitch"
        Me.mnuCMPClearTypeSwitch.Size = New System.Drawing.Size(242, 22)
        Me.mnuCMPClearTypeSwitch.Text = "Clear Type Switch"
        '
        'mnuCMPPALSD
        '
        Me.mnuCMPPALSD.Name = "mnuCMPPALSD"
        Me.mnuCMPPALSD.Size = New System.Drawing.Size(242, 22)
        Me.mnuCMPPALSD.Text = "PAL SD"
        '
        'mnuCMPHD108050i
        '
        Me.mnuCMPHD108050i.Name = "mnuCMPHD108050i"
        Me.mnuCMPHD108050i.Size = New System.Drawing.Size(242, 22)
        Me.mnuCMPHD108050i.Text = "HD 108050i"
        '
        'NewInstanceToolStripMenuItem
        '
        Me.NewInstanceToolStripMenuItem.Name = "NewInstanceToolStripMenuItem"
        Me.NewInstanceToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.NewInstanceToolStripMenuItem.Text = "New Instance"
        '
        'ExitApplicationToolStripMenuItem
        '
        Me.ExitApplicationToolStripMenuItem.Name = "ExitApplicationToolStripMenuItem"
        Me.ExitApplicationToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.ExitApplicationToolStripMenuItem.Text = "Exit Application"
        '
        'DifferentConfigFilesToolStripMenuItem
        '
        Me.DifferentConfigFilesToolStripMenuItem.Name = "DifferentConfigFilesToolStripMenuItem"
        Me.DifferentConfigFilesToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.DifferentConfigFilesToolStripMenuItem.Text = "Different Config files"
        '
        'LoadLastLayoutToolStripMenuItem
        '
        Me.LoadLastLayoutToolStripMenuItem.Name = "LoadLastLayoutToolStripMenuItem"
        Me.LoadLastLayoutToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.LoadLastLayoutToolStripMenuItem.Text = "Load Last Layout"
        '
        'SaveLayoutToolStripMenuItem
        '
        Me.SaveLayoutToolStripMenuItem.Name = "SaveLayoutToolStripMenuItem"
        Me.SaveLayoutToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.SaveLayoutToolStripMenuItem.Text = "Save Layout"
        '
        'ClearTempFileAndRecycleBinToolStripMenuItem
        '
        Me.ClearTempFileAndRecycleBinToolStripMenuItem.Name = "ClearTempFileAndRecycleBinToolStripMenuItem"
        Me.ClearTempFileAndRecycleBinToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.ClearTempFileAndRecycleBinToolStripMenuItem.Text = "Clear temp files and Recycle Bin"
        '
        'MakeThumbnailForServer23ToolStripMenuItem
        '
        Me.MakeThumbnailForServer23ToolStripMenuItem.Name = "MakeThumbnailForServer23ToolStripMenuItem"
        Me.MakeThumbnailForServer23ToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.MakeThumbnailForServer23ToolStripMenuItem.Text = "Make Thumbnail for Server 2.3"
        '
        'mnuCMPHelp
        '
        Me.mnuCMPHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.mnuCMPUpdatedSoftwareLink, Me.YouTubeLInkOfHelpVideosToolStripMenuItem})
        Me.mnuCMPHelp.Name = "mnuCMPHelp"
        Me.mnuCMPHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuCMPHelp.Text = "&Help"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.HelpToolStripMenuItem.Text = "User Manual"
        '
        'mnuCMPUpdatedSoftwareLink
        '
        Me.mnuCMPUpdatedSoftwareLink.Name = "mnuCMPUpdatedSoftwareLink"
        Me.mnuCMPUpdatedSoftwareLink.Size = New System.Drawing.Size(263, 22)
        Me.mnuCMPUpdatedSoftwareLink.Text = "Download Location of latest Version"
        '
        'YouTubeLInkOfHelpVideosToolStripMenuItem
        '
        Me.YouTubeLInkOfHelpVideosToolStripMenuItem.Name = "YouTubeLInkOfHelpVideosToolStripMenuItem"
        Me.YouTubeLInkOfHelpVideosToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.YouTubeLInkOfHelpVideosToolStripMenuItem.Text = "YouTube LInk of Help Videos"
        '
        'tmrGC
        '
        Me.tmrGC.Enabled = True
        Me.tmrGC.Interval = 1800000
        '
        'RecordingToolStripMenuItem
        '
        Me.RecordingToolStripMenuItem.Name = "RecordingToolStripMenuItem"
        Me.RecordingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RecordingToolStripMenuItem.Text = "Recording"
        '
        'OffAirLoggerToolStripMenuItem
        '
        Me.OffAirLoggerToolStripMenuItem.Name = "OffAirLoggerToolStripMenuItem"
        Me.OffAirLoggerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OffAirLoggerToolStripMenuItem.Text = "Off Air Logger"
        '
        'lblProcessID1
        '
        Me.lblProcessID1.AutoSize = True
        Me.lblProcessID1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessID1.Location = New System.Drawing.Point(2, 23)
        Me.lblProcessID1.Name = "lblProcessID1"
        Me.lblProcessID1.Size = New System.Drawing.Size(69, 13)
        Me.lblProcessID1.TabIndex = 1166
        Me.lblProcessID1.Text = "Process ID"
        '
        'lblProcessID2
        '
        Me.lblProcessID2.AutoSize = True
        Me.lblProcessID2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessID2.ForeColor = System.Drawing.Color.Maroon
        Me.lblProcessID2.Location = New System.Drawing.Point(101, 23)
        Me.lblProcessID2.Name = "lblProcessID2"
        Me.lblProcessID2.Size = New System.Drawing.Size(42, 13)
        Me.lblProcessID2.TabIndex = 1167
        Me.lblProcessID2.Text = "12345"
        '
        'cmsCustomeModules
        '
        Me.cmsCustomeModules.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem})
        Me.cmsCustomeModules.Name = "cmsCustomeModules"
        Me.cmsCustomeModules.Size = New System.Drawing.Size(97, 26)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PositionAndSizeControlToolStripMenuItem, Me.SystemAudioToolStripMenuItem})
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'PositionAndSizeControlToolStripMenuItem
        '
        Me.PositionAndSizeControlToolStripMenuItem.Name = "PositionAndSizeControlToolStripMenuItem"
        Me.PositionAndSizeControlToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.PositionAndSizeControlToolStripMenuItem.Text = "Position And Size Control"
        '
        'SystemAudioToolStripMenuItem
        '
        Me.SystemAudioToolStripMenuItem.Name = "SystemAudioToolStripMenuItem"
        Me.SystemAudioToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.SystemAudioToolStripMenuItem.Text = "System Audio"
        '
        'pnlServer
        '
        Me.pnlServer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlServer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlServer.Controls.Add(Me.cmdVLCPreview)
        Me.pnlServer.Controls.Add(Me.cmdScreenConsumer)
        Me.pnlServer.Controls.Add(Me.lbltime)
        Me.pnlServer.Controls.Add(Me.lblremainintime)
        Me.pnlServer.Controls.Add(Me.cmdIMX)
        Me.pnlServer.Controls.Add(Me.lblserverversion)
        Me.pnlServer.Controls.Add(Me.Label147)
        Me.pnlServer.Controls.Add(Me.lblflashversion)
        Me.pnlServer.Controls.Add(Me.Label148)
        Me.pnlServer.Controls.Add(Me.cmdyadif10)
        Me.pnlServer.Controls.Add(Me.lbltemplatehostversion)
        Me.pnlServer.Controls.Add(Me.cmdyadif11)
        Me.pnlServer.Controls.Add(Me.Label150)
        Me.pnlServer.Location = New System.Drawing.Point(1230, 0)
        Me.pnlServer.Name = "pnlServer"
        Me.pnlServer.Size = New System.Drawing.Size(688, 60)
        Me.pnlServer.TabIndex = 1170
        '
        'gbPannel
        '
        Me.gbPannel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gbPannel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gbPannel.Controls.Add(Me.cmbhost)
        Me.gbPannel.Controls.Add(Me.nfontsizeforall)
        Me.gbPannel.Controls.Add(Me.cmblayervideo)
        Me.gbPannel.Controls.Add(Me.mnuCMP)
        Me.gbPannel.Controls.Add(Me.cmbfontsforall)
        Me.gbPannel.Controls.Add(Me.Label7)
        Me.gbPannel.Controls.Add(Me.cmdstopall)
        Me.gbPannel.Controls.Add(Me.cmbchannel)
        Me.gbPannel.Controls.Add(Me.txtport)
        Me.gbPannel.Controls.Add(Me.Label15)
        Me.gbPannel.Controls.Add(Me.lblhost)
        Me.gbPannel.Controls.Add(Me.cmdconnect)
        Me.gbPannel.Controls.Add(Me.lblport)
        Me.gbPannel.Location = New System.Drawing.Point(1, 0)
        Me.gbPannel.Name = "gbPannel"
        Me.gbPannel.Size = New System.Drawing.Size(911, 60)
        Me.gbPannel.TabIndex = 1171
        '
        'tmrGeneralInfo
        '
        Me.tmrGeneralInfo.Enabled = True
        Me.tmrGeneralInfo.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Wheat
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblProcessID2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblCMPMemory)
        Me.Panel1.Controls.Add(Me.lblProcessID1)
        Me.Panel1.Controls.Add(Me.lblcasparMemory)
        Me.Panel1.Controls.Add(Me.lblcasparMemoryValue)
        Me.Panel1.Location = New System.Drawing.Point(916, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 60)
        Me.Panel1.TabIndex = 1174
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 1174
        Me.Label4.Text = "CMP Memory"
        '
        'lblCMPMemory
        '
        Me.lblCMPMemory.AutoSize = True
        Me.lblCMPMemory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCMPMemory.ForeColor = System.Drawing.Color.Maroon
        Me.lblCMPMemory.Location = New System.Drawing.Point(93, 4)
        Me.lblCMPMemory.Name = "lblCMPMemory"
        Me.lblCMPMemory.Size = New System.Drawing.Size(50, 13)
        Me.lblCMPMemory.TabIndex = 1175
        Me.lblCMPMemory.Text = "Memory"
        '
        'lblcasparMemory
        '
        Me.lblcasparMemory.AutoSize = True
        Me.lblcasparMemory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcasparMemory.Location = New System.Drawing.Point(2, 39)
        Me.lblcasparMemory.Name = "lblcasparMemory"
        Me.lblcasparMemory.Size = New System.Drawing.Size(93, 13)
        Me.lblcasparMemory.TabIndex = 1172
        Me.lblcasparMemory.Text = "Caspar Memory"
        '
        'lblcasparMemoryValue
        '
        Me.lblcasparMemoryValue.AutoSize = True
        Me.lblcasparMemoryValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcasparMemoryValue.ForeColor = System.Drawing.Color.Maroon
        Me.lblcasparMemoryValue.Location = New System.Drawing.Point(93, 39)
        Me.lblcasparMemoryValue.Name = "lblcasparMemoryValue"
        Me.lblcasparMemoryValue.Size = New System.Drawing.Size(50, 13)
        Me.lblcasparMemoryValue.TabIndex = 1173
        Me.lblcasparMemoryValue.Text = "Memory"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OldLace
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.CpBarCPU)
        Me.Panel2.Location = New System.Drawing.Point(1071, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(155, 60)
        Me.Panel2.TabIndex = 1175
        '
        'CpBarCPU
        '
        Me.CpBarCPU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CpBarCPU.BackColor = System.Drawing.Color.Transparent
        Alert1.From_Value = 61
        Alert1.To_Value = 75
        Me.CpBarCPU.CPB_Alert_Range = Alert1
        Me.CpBarCPU.CPB_AlertColor = System.Drawing.Color.Gold
        Me.CpBarCPU.CPB_BackColor = System.Drawing.Color.Black
        Critical1.From_Value = 76
        Critical1.To_Value = 100
        Me.CpBarCPU.CPB_Critical_Range = Critical1
        Me.CpBarCPU.CPB_CriticalColor = System.Drawing.Color.Red
        Me.CpBarCPU.CPB_SweepColor = System.Drawing.Color.Aqua
        Me.CpBarCPU.CPB_SweepMaximum = 260
        Me.CpBarCPU.CPB_SweepStartAngle = 140
        Me.CpBarCPU.CPB_Text_1 = "CPU"
        Me.CpBarCPU.CPB_Text_2 = "60"
        Me.CpBarCPU.CPB_Text_3 = "%"
        Me.CpBarCPU.Location = New System.Drawing.Point(38, -1)
        Me.CpBarCPU.Name = "CpBarCPU"
        Me.CpBarCPU.Size = New System.Drawing.Size(76, 76)
        Me.CpBarCPU.TabIndex = 1176
        '
        'DockPanel1
        '
        Me.DockPanel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.DockPanel1.DockBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.DockPanel1.Location = New System.Drawing.Point(2, 62)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Padding = New System.Windows.Forms.Padding(6)
        Me.DockPanel1.ShowAutoHideContentOnHover = False
        Me.DockPanel1.Size = New System.Drawing.Size(1224, 960)
        Me.DockPanel1.TabIndex = 1176
        Me.DockPanel1.Theme = Me.VS2015BlueTheme1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "File_Name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 210
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 210
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Remaining Time"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Start_Time"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Duration"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Audio Level"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 40
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Filter"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 500
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Method Name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Width = 250
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Method_Value"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.Width = 225
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = ""
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmmediaplayer
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1364, 749)
        Me.ContextMenuStrip = Me.cmsCustomeModules
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbPannel)
        Me.Controls.Add(Me.pnlServer)
        Me.Controls.Add(Me.gbmodules)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.Name = "frmmediaplayer"
        Me.Text = "CasparMediaPlayback080423_1"
        CType(Me.nfontsizeforall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbmodules.ResumeLayout(False)
        Me.gbmodules.PerformLayout()
        Me.mnuCMP.ResumeLayout(False)
        Me.mnuCMP.PerformLayout()
        Me.cmsCustomeModules.ResumeLayout(False)
        Me.pnlServer.ResumeLayout(False)
        Me.pnlServer.PerformLayout()
        Me.gbPannel.ResumeLayout(False)
        Me.gbPannel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DockPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblport As System.Windows.Forms.Label
    Friend WithEvents lblhost As System.Windows.Forms.Label
    Friend WithEvents cmdconnect As System.Windows.Forms.Button
    Friend WithEvents txtport As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbchannel As System.Windows.Forms.ComboBox
    Friend WithEvents cmdstopall As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmblayervideo As System.Windows.Forms.ComboBox
    Friend WithEvents rdoRecording As System.Windows.Forms.RadioButton
    Friend WithEvents rdoplaylist As System.Windows.Forms.RadioButton
    Friend WithEvents rdoswfplayer As System.Windows.Forms.RadioButton
    Friend WithEvents rdoamcp As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMixer As System.Windows.Forms.RadioButton
    Friend WithEvents rdoHorizontalScroll2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoHorizontalScroll1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoverticalscroll As System.Windows.Forms.RadioButton
    Friend WithEvents rdotemplate As System.Windows.Forms.RadioButton
    Friend WithEvents gbmodules As System.Windows.Forms.GroupBox
    Friend WithEvents rdoBreakingNews As System.Windows.Forms.RadioButton
    Friend WithEvents rdoscroll As System.Windows.Forms.RadioButton
    Friend WithEvents rdooneliner As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTwoLiner As System.Windows.Forms.RadioButton
    Friend WithEvents rdopowerpoint As System.Windows.Forms.RadioButton
    Friend WithEvents cmbfontsforall As System.Windows.Forms.ComboBox
    Friend WithEvents nfontsizeforall As System.Windows.Forms.NumericUpDown
    Friend WithEvents rdocg As System.Windows.Forms.RadioButton
    Friend WithEvents rdovisionmixer As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSlowMotion As System.Windows.Forms.RadioButton
    Friend WithEvents rdooffairlogger As System.Windows.Forms.RadioButton
    Friend WithEvents rdoimagescroll As System.Windows.Forms.RadioButton
    Friend WithEvents rdoosc As System.Windows.Forms.RadioButton
    Friend WithEvents rdoutility As System.Windows.Forms.RadioButton
    Friend WithEvents lblremainintime As System.Windows.Forms.Label
    Friend WithEvents rdoweather As System.Windows.Forms.RadioButton
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents rdorss As System.Windows.Forms.RadioButton
    Friend WithEvents rdofacebook As System.Windows.Forms.RadioButton
    Friend WithEvents rdotwitter As System.Windows.Forms.RadioButton
    Friend WithEvents lblserverversion As System.Windows.Forms.Label
    Friend WithEvents Label147 As System.Windows.Forms.Label
    Friend WithEvents Label148 As System.Windows.Forms.Label
    Friend WithEvents lblflashversion As System.Windows.Forms.Label
    Friend WithEvents Label150 As System.Windows.Forms.Label
    Friend WithEvents lbltemplatehostversion As System.Windows.Forms.Label
    Friend WithEvents rdohtml As System.Windows.Forms.RadioButton
    Friend WithEvents rdoelection As System.Windows.Forms.RadioButton
    Friend WithEvents rdohtmlscroller As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSongSubtitling As System.Windows.Forms.RadioButton
    Friend WithEvents rdocg2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoquiz As System.Windows.Forms.RadioButton
    Friend WithEvents rdosrt As System.Windows.Forms.RadioButton
    Friend WithEvents rdotimers As System.Windows.Forms.RadioButton
    Friend WithEvents rdogames As System.Windows.Forms.RadioButton
    Friend WithEvents rdotrimmer As System.Windows.Forms.RadioButton
    Friend WithEvents rdostreaming As System.Windows.Forms.RadioButton
    Friend WithEvents rdoudpchat As System.Windows.Forms.RadioButton
    Friend WithEvents cmdplaylast8seccasaprcgwindow As System.Windows.Forms.Button
    Friend WithEvents rdochannelinfo As System.Windows.Forms.RadioButton
    Friend WithEvents rdometadata As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMAM As System.Windows.Forms.RadioButton
    Friend WithEvents cmbhost As System.Windows.Forms.ComboBox
    Friend WithEvents rdovs2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdosm2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRemoteLogging As System.Windows.Forms.RadioButton
    Friend WithEvents cmdyadif10 As System.Windows.Forms.Button
    Friend WithEvents cmdyadif11 As System.Windows.Forms.Button
    Friend WithEvents rdoWaterMarking As System.Windows.Forms.RadioButton
    'Friend WithEvents ucVS21 As caspar_media_playback.ucVS2
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mnuCMP As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuCMPTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCMPEditConfigFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCMPResetSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCMPAddScreen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCMPRemoveScreen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCMPRestartCasparcgServer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCMPQuitCasparcgServer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCMPCopyExampleTemplates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCMPCopyExampleMedia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCMPCasparcgDiagnosisWndow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCMPClearTypeSwitch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCMPPALSD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCMPHD108050i As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCMPHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCMPUpdatedSoftwareLink As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rdoPlayListSetting As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPlayFromAnywhere As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMultiBulletScroll As System.Windows.Forms.RadioButton
    Friend WithEvents mnuCMPPlayList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCMPTemplate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCMP4ChannelRecordingAndTrimming As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrGC As System.Windows.Forms.Timer
    Friend WithEvents rdoSceneScroller As System.Windows.Forms.RadioButton
    Friend WithEvents rdovlcstreamtester As System.Windows.Forms.RadioButton
    Friend WithEvents rdoScheduler As System.Windows.Forms.RadioButton
    Friend WithEvents NewInstanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrimmerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rdoOSD As System.Windows.Forms.RadioButton
    Friend WithEvents RecordingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OffAirLoggerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblProcessID1 As System.Windows.Forms.Label
    Friend WithEvents lblProcessID2 As System.Windows.Forms.Label
    Friend WithEvents ExitApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rdoCustomControls As RadioButton
    Friend WithEvents cmsCustomeModules As ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PositionAndSizeControlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemAudioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DifferentConfigFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdIMX As Button
    Friend WithEvents rdodBFSMeter As RadioButton
    Friend WithEvents rdoMySqlTest As RadioButton
    Friend WithEvents mnuCMPRestartwithConfigFile As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents pnlServer As Panel
    Friend WithEvents gbPannel As Panel
    Friend WithEvents AddOutput As ToolStripMenuItem
    Friend WithEvents AddputputFill As ToolStripMenuItem
    Friend WithEvents AddOutputFillDecklink As ToolStripMenuItem
    Friend WithEvents Add_Ouput_Fill_decklink_1 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_Fill_decklink_2 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_Fill_decklink_3 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_Fill_decklink_4 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_Fill_decklink_5 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_Fill_decklink_6 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_Fill_decklink_7 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_Fill_decklink_8 As ToolStripMenuItem
    Friend WithEvents AddOutputFillBluefish As ToolStripMenuItem
    Friend WithEvents Add_Ouput_Fill_Bluefish_1 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_Fill_Bluefish_2 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_Fill_Bluefish_3 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_Fill_Bluefish_4 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_Fill_Bluefish_5 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_Fill_Bluefish_6 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_Fill_Bluefish_7 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_Fill_Bluefish_8 As ToolStripMenuItem
    Friend WithEvents AddputputKey As ToolStripMenuItem
    Friend WithEvents AddOutputKeyDecklink As ToolStripMenuItem
    Friend WithEvents Add_Ouput_key_Decklink_1 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_key_Decklink_2 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_key_Decklink_3 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_key_Decklink_4 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_key_Decklink_5 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_key_Decklink_6 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_key_Decklink_7 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_key_Decklink_8 As ToolStripMenuItem
    Friend WithEvents AddOutputKeyBluefish As ToolStripMenuItem
    Friend WithEvents Add_Ouput_key_Bluefish_1 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_key_Bluefish_2 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_key_Bluefish_3 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_key_Bluefish_4 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_key_Bluefish_5 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_key_Bluefish_6 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_key_Bluefish_7 As ToolStripMenuItem
    Friend WithEvents Add_Ouput_key_Bluefish_8 As ToolStripMenuItem
    Friend WithEvents RemoveOutput As ToolStripMenuItem
    Friend WithEvents RemoveOutputDecklink As ToolStripMenuItem
    Friend WithEvents Remove_Ouput__decklink_1 As ToolStripMenuItem
    Friend WithEvents Remove_Ouput__decklink_2 As ToolStripMenuItem
    Friend WithEvents Remove_Ouput__decklink_3 As ToolStripMenuItem
    Friend WithEvents Remove_Ouput__decklink_4 As ToolStripMenuItem
    Friend WithEvents Remove_Ouput__decklink_5 As ToolStripMenuItem
    Friend WithEvents Remove_Ouput__decklink_6 As ToolStripMenuItem
    Friend WithEvents Remove_Ouput__decklink_7 As ToolStripMenuItem
    Friend WithEvents Remove_Ouput__decklink_8 As ToolStripMenuItem
    Friend WithEvents RemoveOutputBluefish As ToolStripMenuItem
    Friend WithEvents Remove_Output__Bluefish_1 As ToolStripMenuItem
    Friend WithEvents Remove_Output__Bluefish_2 As ToolStripMenuItem
    Friend WithEvents Remove_Output__Bluefish_3 As ToolStripMenuItem
    Friend WithEvents Remove_Output__Bluefish_4 As ToolStripMenuItem
    Friend WithEvents Remove_Output__Bluefish_5 As ToolStripMenuItem
    Friend WithEvents Remove_Output__Bluefish_6 As ToolStripMenuItem
    Friend WithEvents Remove_Output__Bluefish_7 As ToolStripMenuItem
    Friend WithEvents Remove_Output__Bluefish_8 As ToolStripMenuItem
    Friend WithEvents Play_Input As ToolStripMenuItem
    Friend WithEvents Play_Input__decklink As ToolStripMenuItem
    Friend WithEvents Play_Input__decklink_1 As ToolStripMenuItem
    Friend WithEvents Play_Input__decklink_2 As ToolStripMenuItem
    Friend WithEvents Play_Input__decklink_3 As ToolStripMenuItem
    Friend WithEvents Play_Input__decklink_4 As ToolStripMenuItem
    Friend WithEvents Play_Input__decklink_5 As ToolStripMenuItem
    Friend WithEvents Play_Input__decklink_6 As ToolStripMenuItem
    Friend WithEvents Play_Input__decklink_7 As ToolStripMenuItem
    Friend WithEvents Play_Input__decklink_8 As ToolStripMenuItem
    Friend WithEvents rdoHtmlTemplate As RadioButton
    Friend WithEvents rdoWebSocketServer As RadioButton
    Friend WithEvents FlashTemplateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HtmlTemplateToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ChannelRecorderAndTrimmerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneralRecorderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OffAirLoggerToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ChannelOffAirLoggerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VideoServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayFromAnywhreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rdoStreamPlayer As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents mnuCMPModules As ToolStripMenuItem
    Friend WithEvents mnuCMPSlowMotion As ToolStripMenuItem
    Friend WithEvents mnuCMPSlowMotionInServer21 As ToolStripMenuItem
    Friend WithEvents mnuCMPSlowMotionInJStarServer As ToolStripMenuItem
    Friend WithEvents mnuCMPElection As ToolStripMenuItem
    Friend WithEvents mnuCMPSubTitling As ToolStripMenuItem
    Friend WithEvents mnuCMPSRTPlayer As ToolStripMenuItem
    Friend WithEvents mnuCMPSongSubTitling As ToolStripMenuItem
    Friend WithEvents mnuCMPSocialMedia As ToolStripMenuItem
    Friend WithEvents mnuCMPFacebook As ToolStripMenuItem
    Friend WithEvents mnuCMPTwitter As ToolStripMenuItem
    Friend WithEvents mnuCMPHTMLorInternet As ToolStripMenuItem
    Friend WithEvents mnuCMPVisionMixer As ToolStripMenuItem
    Friend WithEvents mnuCMPOSC As ToolStripMenuItem
    Friend WithEvents mnuCMPMixer As ToolStripMenuItem
    Friend WithEvents mnuCMPTimers As ToolStripMenuItem
    Friend WithEvents mnuCMPStreaming As ToolStripMenuItem
    Friend WithEvents mnuStreamPlayer As ToolStripMenuItem
    Friend WithEvents mnuCMPRemoteLogging As ToolStripMenuItem
    Friend WithEvents CommandSchedulerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VLCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StreamTesterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FourChannelPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DBFSMeter16ChannelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MySqlTestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebSocketServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CCTVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SilenceDetectorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rdoSilenceDetector As RadioButton
    Friend WithEvents tmrGeneralInfo As Timer
    Friend WithEvents FullPageCaptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rdoFullPageCaption As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScrollersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GamesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExternalSoftwaresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CG1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CG2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnelinerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TwolinerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PPTEXcellToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WaterMarkingToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents QuizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NationalGamesKerlaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SouthAsianGamesGuwahati2016ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CricketToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DaviceCupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnScreenDrawingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WeightLiftingToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ScrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorizontalScroll1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorizontalScroll2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerticalScroll1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerticalScroll2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageScrollerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RSSFeedAsScrollBReakingNewsAndClockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HTMLScrollerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultiBulletScrollerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SceneScrollerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WeatherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MediaAssetManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VDCPControllerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MetadataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UDPChatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XDCamSoapClientToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents rdoFourChannelPreview As RadioButton
    Friend WithEvents rdoOffAirLoggers As RadioButton
    Friend WithEvents rdo4ChannelRecorderAndTrimmer As RadioButton
    Friend WithEvents TabPagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rdoCCTV As RadioButton
    Friend WithEvents rdoCricket As RadioButton
    Friend WithEvents rdoVDCP As RadioButton
    Friend WithEvents rdoXdCamSoapClient As RadioButton
    Friend WithEvents rdoDavisCup As RadioButton
    Friend WithEvents rdoWeightLifting As RadioButton
    Friend WithEvents rdoSG2016 As RadioButton
    Friend WithEvents cmdVLCPreview As Button
    Friend WithEvents cmdScreenConsumer As Button
    Friend WithEvents DockPanel1 As WeifenLuo.WinFormsUI.Docking.DockPanel
    Friend WithEvents VS2015BlueTheme1 As WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme
    Friend WithEvents LoadLastLayoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveLayoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompositionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearTempFileAndRecycleBinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TemplatePlaylistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YouTubeLInkOfHelpVideosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Channel1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Channel2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Channel3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Channel4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommandSchedulerDateWiseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XDCamControllersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MakeThumbnailForServer23ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YouTubeLiveManagemnetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CpBarCPU As CPBar
    Friend WithEvents lblCMPMemory As Label
    Friend WithEvents lblcasparMemoryValue As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblcasparMemory As Label
    Friend WithEvents RCCAutomationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RCCBallToolStripMenuItem As ToolStripMenuItem
End Class
