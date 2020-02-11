<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMAM
    'Inherits System.Windows.Forms.UserControl
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucMAM))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstSourceDirectory = New System.Windows.Forms.ListBox()
        Me.lstDestinationDirectory = New System.Windows.Forms.ListBox()
        Me.cmdCopy = New System.Windows.Forms.Button()
        Me.cmdMove = New System.Windows.Forms.Button()
        Me.cmdshowfilesinSourcelistbox = New System.Windows.Forms.Button()
        Me.cmdshowfilesinDestinationlistbox = New System.Windows.Forms.Button()
        Me.txtSourceDirectory = New System.Windows.Forms.TextBox()
        Me.txtDestinationDirectory = New System.Windows.Forms.TextBox()
        Me.cmdmakeproxy = New System.Windows.Forms.Button()
        Me.txtDestinationDirectoryProxy = New System.Windows.Forms.TextBox()
        Me.cmdshowfilesinDestinationlistboxproxy = New System.Windows.Forms.Button()
        Me.lstDestinationDirectoryProxy = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdopensourcedirectory = New System.Windows.Forms.Button()
        Me.cmdopendestinationdirectory = New System.Windows.Forms.Button()
        Me.cmdopendestinationdirectoryproxy = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.FFMPEG = New System.Windows.Forms.TabPage()
        Me.cmdFFMpeg = New System.Windows.Forms.Button()
        Me.txtFFMpeg = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtffplay = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdFfmbcTargetTranscoding = New System.Windows.Forms.Button()
        Me.txtFfmbcTargetTranscoding = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdvideohd = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtsourcefileforalphavideosd = New System.Windows.Forms.TextBox()
        Me.txtdestinationfolderforhd = New System.Windows.Forms.TextBox()
        Me.txtfilenameforhd = New System.Windows.Forms.TextBox()
        Me.cmddestinationfolderforhd = New System.Windows.Forms.Button()
        Me.cmdvideosd = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtsourcefileforalphavideo = New System.Windows.Forms.TextBox()
        Me.txtdestinationfolderforalphaimage = New System.Windows.Forms.TextBox()
        Me.txtfilenameforimage = New System.Windows.Forms.TextBox()
        Me.cmddestinationfolderforalphaimage = New System.Windows.Forms.Button()
        Me.cmdvideoforimage = New System.Windows.Forms.Button()
        Me.cmbcodecforalpha = New System.Windows.Forms.ComboBox()
        Me.cmdaudioinsinglestream = New System.Windows.Forms.Button()
        Me.txtaudioinsinglestream = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmdaddingaudiotracktovideomam = New System.Windows.Forms.Button()
        Me.txtaddingaudiotracktovideomam = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmdvideotosequencemam = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmdsequencetovideomam = New System.Windows.Forms.Button()
        Me.txtsequencetovideomam = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.EbuCoreMetadata = New System.Windows.Forms.TabPage()
        Me.gbmetadata = New System.Windows.Forms.GroupBox()
        Me.cmbebu2mxfoption = New System.Windows.Forms.ComboBox()
        Me.cmddefaultmetadata = New System.Windows.Forms.Button()
        Me.cmdebu2mxf = New System.Windows.Forms.Button()
        Me.cmbanalyzeroption = New System.Windows.Forms.ComboBox()
        Me.lblfilenamemetadata = New System.Windows.Forms.Label()
        Me.cmdanalyse = New System.Windows.Forms.Button()
        Me.Label238 = New System.Windows.Forms.Label()
        Me.cmdclearfieldmetadata = New System.Windows.Forms.Button()
        Me.cmdwritemetadata = New System.Windows.Forms.Button()
        Me.cmdreadmetadata = New System.Windows.Forms.Button()
        Me.dgvmetadata = New System.Windows.Forms.DataGridView()
        Me.CopyandProxyProgram = New System.Windows.Forms.TabPage()
        Me.BatchTranscoder = New System.Windows.Forms.TabPage()
        Me.txtffmpegoutput = New System.Windows.Forms.TextBox()
        Me.cmdsearchdatagridbt = New System.Windows.Forms.Button()
        Me.txtsearchdatagridbt = New System.Windows.Forms.TextBox()
        Me.cmdDeSelectAllfromcurrentposition = New System.Windows.Forms.Button()
        Me.cmdDeSelectAll = New System.Windows.Forms.Button()
        Me.cmdSelectAll = New System.Windows.Forms.Button()
        Me.lbltrandingfilename = New System.Windows.Forms.Label()
        Me.cmdselectsourcefolderfortranscoding = New System.Windows.Forms.Button()
        Me.cmdselectdestinationfolderfortranscoding = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblexportclipinfobt = New System.Windows.Forms.Label()
        Me.dgvtranscoder = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cmdstoptranscoding = New System.Windows.Forms.Button()
        Me.txtdestinationdirectorybt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtsourcedirectorybt = New System.Windows.Forms.TextBox()
        Me.cmdstarttranscoding = New System.Windows.Forms.Button()
        Me.cmdfilldatgridbt = New System.Windows.Forms.Button()
        Me.WatchFolder = New System.Windows.Forms.TabPage()
        Me.cmdSelectDirectoryForAutoCopy = New System.Windows.Forms.Button()
        Me.gbdatatablesetting = New System.Windows.Forms.GroupBox()
        Me.cmdstopwatching = New System.Windows.Forms.Button()
        Me.cmdSelectDirectoryforSymlinked2Mediawatchfolder = New System.Windows.Forms.Button()
        Me.cmdSelectDirectoryformainMediawatchfolder = New System.Windows.Forms.Button()
        Me.cmdSelectDirectoryforSymlinked1Mediawatchfolder = New System.Windows.Forms.Button()
        Me.chkwithduration = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pbsearchprogress = New System.Windows.Forms.ProgressBar()
        Me.chksymlinkedalis2 = New System.Windows.Forms.CheckBox()
        Me.chksymlinkedalis1 = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtsymlinked2mediafolder = New System.Windows.Forms.TextBox()
        Me.txtsymlinkedalis2 = New System.Windows.Forms.TextBox()
        Me.txtsymlinkedalis1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtsymlinked1mediafolder = New System.Windows.Forms.TextBox()
        Me.txtmainmediafolder = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmdcreatdatatable = New System.Windows.Forms.Button()
        Me.txtfilechanged = New System.Windows.Forms.TextBox()
        Me.chktranscode = New System.Windows.Forms.CheckBox()
        Me.txttranscodedirectory = New System.Windows.Forms.TextBox()
        Me.chkmediabackup = New System.Windows.Forms.CheckBox()
        Me.txtmediabackupfplder = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmdSelectDirectoryForAutoTranscode = New System.Windows.Forms.Button()
        Me.cmdsearchdatatable = New System.Windows.Forms.Button()
        Me.labelclips = New System.Windows.Forms.Label()
        Me.txtsearchclip = New System.Windows.Forms.TextBox()
        Me.dgvclips = New System.Windows.Forms.DataGridView()
        Me.bwforexportclipbt = New System.ComponentModel.BackgroundWorker()
        Me.fswalias2 = New System.IO.FileSystemWatcher()
        Me.fsw = New System.IO.FileSystemWatcher()
        Me.fswalias1 = New System.IO.FileSystemWatcher()
        Me.cmdplayinvlc = New System.Windows.Forms.Button()
        Me.lblplayinvlc = New System.Windows.Forms.Label()
        Me.cmdshowfileinformation = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdrecord = New System.Windows.Forms.Button()
        Me.txtrecord = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdOutputToDecklink = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOutputToDecklink = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UcTranscodingProfile1 = New caspar_media_playback.ucTranscodingProfile()
        Me.TabControl1.SuspendLayout()
        Me.FFMPEG.SuspendLayout()
        Me.EbuCoreMetadata.SuspendLayout()
        Me.gbmetadata.SuspendLayout()
        CType(Me.dgvmetadata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CopyandProxyProgram.SuspendLayout()
        Me.BatchTranscoder.SuspendLayout()
        CType(Me.dgvtranscoder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WatchFolder.SuspendLayout()
        Me.gbdatatablesetting.SuspendLayout()
        CType(Me.dgvclips, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fswalias2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fsw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fswalias1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Source Directory"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(405, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Destination Directory for Copy"
        '
        'lstSourceDirectory
        '
        Me.lstSourceDirectory.FormattingEnabled = True
        Me.lstSourceDirectory.Location = New System.Drawing.Point(10, 63)
        Me.lstSourceDirectory.Name = "lstSourceDirectory"
        Me.lstSourceDirectory.Size = New System.Drawing.Size(298, 524)
        Me.lstSourceDirectory.TabIndex = 2
        '
        'lstDestinationDirectory
        '
        Me.lstDestinationDirectory.FormattingEnabled = True
        Me.lstDestinationDirectory.Location = New System.Drawing.Point(399, 88)
        Me.lstDestinationDirectory.Name = "lstDestinationDirectory"
        Me.lstDestinationDirectory.Size = New System.Drawing.Size(309, 316)
        Me.lstDestinationDirectory.TabIndex = 3
        '
        'cmdCopy
        '
        Me.cmdCopy.Location = New System.Drawing.Point(314, 147)
        Me.cmdCopy.Name = "cmdCopy"
        Me.cmdCopy.Size = New System.Drawing.Size(75, 23)
        Me.cmdCopy.TabIndex = 4
        Me.cmdCopy.Text = ">>Copy>>"
        Me.cmdCopy.UseVisualStyleBackColor = True
        '
        'cmdMove
        '
        Me.cmdMove.Location = New System.Drawing.Point(314, 176)
        Me.cmdMove.Name = "cmdMove"
        Me.cmdMove.Size = New System.Drawing.Size(75, 23)
        Me.cmdMove.TabIndex = 5
        Me.cmdMove.Text = ">>Move >>"
        Me.cmdMove.UseVisualStyleBackColor = True
        '
        'cmdshowfilesinSourcelistbox
        '
        Me.cmdshowfilesinSourcelistbox.Location = New System.Drawing.Point(205, 12)
        Me.cmdshowfilesinSourcelistbox.Name = "cmdshowfilesinSourcelistbox"
        Me.cmdshowfilesinSourcelistbox.Size = New System.Drawing.Size(75, 23)
        Me.cmdshowfilesinSourcelistbox.TabIndex = 6
        Me.cmdshowfilesinSourcelistbox.Text = "Show Files"
        Me.cmdshowfilesinSourcelistbox.UseVisualStyleBackColor = True
        '
        'cmdshowfilesinDestinationlistbox
        '
        Me.cmdshowfilesinDestinationlistbox.Location = New System.Drawing.Point(603, 37)
        Me.cmdshowfilesinDestinationlistbox.Name = "cmdshowfilesinDestinationlistbox"
        Me.cmdshowfilesinDestinationlistbox.Size = New System.Drawing.Size(75, 23)
        Me.cmdshowfilesinDestinationlistbox.TabIndex = 7
        Me.cmdshowfilesinDestinationlistbox.Text = "Show Files"
        Me.cmdshowfilesinDestinationlistbox.UseVisualStyleBackColor = True
        '
        'txtSourceDirectory
        '
        Me.txtSourceDirectory.Location = New System.Drawing.Point(10, 40)
        Me.txtSourceDirectory.Name = "txtSourceDirectory"
        Me.txtSourceDirectory.Size = New System.Drawing.Size(270, 20)
        Me.txtSourceDirectory.TabIndex = 10
        Me.txtSourceDirectory.Text = "c:/casparcg/_media/"
        '
        'txtDestinationDirectory
        '
        Me.txtDestinationDirectory.Location = New System.Drawing.Point(399, 63)
        Me.txtDestinationDirectory.Name = "txtDestinationDirectory"
        Me.txtDestinationDirectory.Size = New System.Drawing.Size(279, 20)
        Me.txtDestinationDirectory.TabIndex = 11
        Me.txtDestinationDirectory.Text = "c:/casparcg/_media/"
        '
        'cmdmakeproxy
        '
        Me.cmdmakeproxy.Location = New System.Drawing.Point(314, 453)
        Me.cmdmakeproxy.Name = "cmdmakeproxy"
        Me.cmdmakeproxy.Size = New System.Drawing.Size(67, 50)
        Me.cmdmakeproxy.TabIndex = 482
        Me.cmdmakeproxy.Text = ">>Make Proxy>>"
        Me.cmdmakeproxy.UseVisualStyleBackColor = True
        '
        'txtDestinationDirectoryProxy
        '
        Me.txtDestinationDirectoryProxy.Location = New System.Drawing.Point(399, 445)
        Me.txtDestinationDirectoryProxy.Name = "txtDestinationDirectoryProxy"
        Me.txtDestinationDirectoryProxy.Size = New System.Drawing.Size(279, 20)
        Me.txtDestinationDirectoryProxy.TabIndex = 486
        Me.txtDestinationDirectoryProxy.Text = "c:/casparcg/_media/"
        '
        'cmdshowfilesinDestinationlistboxproxy
        '
        Me.cmdshowfilesinDestinationlistboxproxy.Location = New System.Drawing.Point(603, 419)
        Me.cmdshowfilesinDestinationlistboxproxy.Name = "cmdshowfilesinDestinationlistboxproxy"
        Me.cmdshowfilesinDestinationlistboxproxy.Size = New System.Drawing.Size(75, 23)
        Me.cmdshowfilesinDestinationlistboxproxy.TabIndex = 485
        Me.cmdshowfilesinDestinationlistboxproxy.Text = "Show Files"
        Me.cmdshowfilesinDestinationlistboxproxy.UseVisualStyleBackColor = True
        '
        'lstDestinationDirectoryProxy
        '
        Me.lstDestinationDirectoryProxy.FormattingEnabled = True
        Me.lstDestinationDirectoryProxy.Location = New System.Drawing.Point(399, 470)
        Me.lstDestinationDirectoryProxy.Name = "lstDestinationDirectoryProxy"
        Me.lstDestinationDirectoryProxy.Size = New System.Drawing.Size(309, 121)
        Me.lstDestinationDirectoryProxy.TabIndex = 484
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(405, 429)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 13)
        Me.Label4.TabIndex = 483
        Me.Label4.Text = "Destination Directory for Proxy"
        '
        'cmdopensourcedirectory
        '
        Me.cmdopensourcedirectory.Location = New System.Drawing.Point(284, 38)
        Me.cmdopensourcedirectory.Name = "cmdopensourcedirectory"
        Me.cmdopensourcedirectory.Size = New System.Drawing.Size(24, 23)
        Me.cmdopensourcedirectory.TabIndex = 487
        Me.cmdopensourcedirectory.Text = ".."
        Me.cmdopensourcedirectory.UseVisualStyleBackColor = True
        '
        'cmdopendestinationdirectory
        '
        Me.cmdopendestinationdirectory.Location = New System.Drawing.Point(684, 63)
        Me.cmdopendestinationdirectory.Name = "cmdopendestinationdirectory"
        Me.cmdopendestinationdirectory.Size = New System.Drawing.Size(24, 23)
        Me.cmdopendestinationdirectory.TabIndex = 488
        Me.cmdopendestinationdirectory.Text = ".."
        Me.cmdopendestinationdirectory.UseVisualStyleBackColor = True
        '
        'cmdopendestinationdirectoryproxy
        '
        Me.cmdopendestinationdirectoryproxy.Location = New System.Drawing.Point(684, 445)
        Me.cmdopendestinationdirectoryproxy.Name = "cmdopendestinationdirectoryproxy"
        Me.cmdopendestinationdirectoryproxy.Size = New System.Drawing.Size(24, 23)
        Me.cmdopendestinationdirectoryproxy.TabIndex = 489
        Me.cmdopendestinationdirectoryproxy.Text = ".."
        Me.cmdopendestinationdirectoryproxy.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.FFMPEG)
        Me.TabControl1.Controls.Add(Me.EbuCoreMetadata)
        Me.TabControl1.Controls.Add(Me.CopyandProxyProgram)
        Me.TabControl1.Controls.Add(Me.BatchTranscoder)
        Me.TabControl1.Controls.Add(Me.WatchFolder)
        Me.TabControl1.Location = New System.Drawing.Point(6, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(820, 926)
        Me.TabControl1.TabIndex = 490
        '
        'FFMPEG
        '
        Me.FFMPEG.Controls.Add(Me.txtOutputToDecklink)
        Me.FFMPEG.Controls.Add(Me.cmdOutputToDecklink)
        Me.FFMPEG.Controls.Add(Me.Label10)
        Me.FFMPEG.Controls.Add(Me.cmdrecord)
        Me.FFMPEG.Controls.Add(Me.txtrecord)
        Me.FFMPEG.Controls.Add(Me.Label9)
        Me.FFMPEG.Controls.Add(Me.cmdFFMpeg)
        Me.FFMPEG.Controls.Add(Me.txtFFMpeg)
        Me.FFMPEG.Controls.Add(Me.Label8)
        Me.FFMPEG.Controls.Add(Me.Button1)
        Me.FFMPEG.Controls.Add(Me.txtffplay)
        Me.FFMPEG.Controls.Add(Me.Label5)
        Me.FFMPEG.Controls.Add(Me.Label3)
        Me.FFMPEG.Controls.Add(Me.cmdFfmbcTargetTranscoding)
        Me.FFMPEG.Controls.Add(Me.txtFfmbcTargetTranscoding)
        Me.FFMPEG.Controls.Add(Me.Label6)
        Me.FFMPEG.Controls.Add(Me.cmdvideohd)
        Me.FFMPEG.Controls.Add(Me.Label29)
        Me.FFMPEG.Controls.Add(Me.Label30)
        Me.FFMPEG.Controls.Add(Me.Label31)
        Me.FFMPEG.Controls.Add(Me.Label32)
        Me.FFMPEG.Controls.Add(Me.txtsourcefileforalphavideosd)
        Me.FFMPEG.Controls.Add(Me.txtdestinationfolderforhd)
        Me.FFMPEG.Controls.Add(Me.txtfilenameforhd)
        Me.FFMPEG.Controls.Add(Me.cmddestinationfolderforhd)
        Me.FFMPEG.Controls.Add(Me.cmdvideosd)
        Me.FFMPEG.Controls.Add(Me.Label28)
        Me.FFMPEG.Controls.Add(Me.Label27)
        Me.FFMPEG.Controls.Add(Me.Label26)
        Me.FFMPEG.Controls.Add(Me.Label25)
        Me.FFMPEG.Controls.Add(Me.txtsourcefileforalphavideo)
        Me.FFMPEG.Controls.Add(Me.txtdestinationfolderforalphaimage)
        Me.FFMPEG.Controls.Add(Me.txtfilenameforimage)
        Me.FFMPEG.Controls.Add(Me.cmddestinationfolderforalphaimage)
        Me.FFMPEG.Controls.Add(Me.cmdvideoforimage)
        Me.FFMPEG.Controls.Add(Me.cmbcodecforalpha)
        Me.FFMPEG.Controls.Add(Me.cmdaudioinsinglestream)
        Me.FFMPEG.Controls.Add(Me.txtaudioinsinglestream)
        Me.FFMPEG.Controls.Add(Me.Label23)
        Me.FFMPEG.Controls.Add(Me.cmdaddingaudiotracktovideomam)
        Me.FFMPEG.Controls.Add(Me.txtaddingaudiotracktovideomam)
        Me.FFMPEG.Controls.Add(Me.Label22)
        Me.FFMPEG.Controls.Add(Me.cmdvideotosequencemam)
        Me.FFMPEG.Controls.Add(Me.Label21)
        Me.FFMPEG.Controls.Add(Me.cmdsequencetovideomam)
        Me.FFMPEG.Controls.Add(Me.txtsequencetovideomam)
        Me.FFMPEG.Controls.Add(Me.Label20)
        Me.FFMPEG.Location = New System.Drawing.Point(4, 22)
        Me.FFMPEG.Name = "FFMPEG"
        Me.FFMPEG.Padding = New System.Windows.Forms.Padding(3)
        Me.FFMPEG.Size = New System.Drawing.Size(812, 900)
        Me.FFMPEG.TabIndex = 3
        Me.FFMPEG.Text = "FFMPEG"
        Me.FFMPEG.UseVisualStyleBackColor = True
        '
        'cmdFFMpeg
        '
        Me.cmdFFMpeg.Location = New System.Drawing.Point(742, 234)
        Me.cmdFFMpeg.Name = "cmdFFMpeg"
        Me.cmdFFMpeg.Size = New System.Drawing.Size(64, 124)
        Me.cmdFFMpeg.TabIndex = 841
        Me.cmdFFMpeg.Text = "Convert"
        Me.cmdFFMpeg.UseVisualStyleBackColor = True
        '
        'txtFFMpeg
        '
        Me.txtFFMpeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFFMpeg.Location = New System.Drawing.Point(6, 234)
        Me.txtFFMpeg.Multiline = True
        Me.txtFFMpeg.Name = "txtFFMpeg"
        Me.txtFFMpeg.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtFFMpeg.Size = New System.Drawing.Size(702, 124)
        Me.txtFFMpeg.TabIndex = 840
        Me.txtFFMpeg.Text = resources.GetString("txtFFMpeg.Text")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 839
        Me.Label8.Text = "FFMpeg"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(742, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 48)
        Me.Button1.TabIndex = 838
        Me.Button1.Text = "Convert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtffplay
        '
        Me.txtffplay.Location = New System.Drawing.Point(5, 382)
        Me.txtffplay.Multiline = True
        Me.txtffplay.Name = "txtffplay"
        Me.txtffplay.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtffplay.Size = New System.Drawing.Size(702, 48)
        Me.txtffplay.TabIndex = 837
        Me.txtffplay.Text = "c:/casparcg/mydata/ffmpeg/ffplay.exe udp://238.1.1.3:2000?pkt_size=1316 -ast 0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 366)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 836
        Me.Label5.Text = "FFplay"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(162, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 835
        Me.Label3.Text = "File Name like test00001.png"
        '
        'cmdFfmbcTargetTranscoding
        '
        Me.cmdFfmbcTargetTranscoding.Location = New System.Drawing.Point(742, 795)
        Me.cmdFfmbcTargetTranscoding.Name = "cmdFfmbcTargetTranscoding"
        Me.cmdFfmbcTargetTranscoding.Size = New System.Drawing.Size(64, 40)
        Me.cmdFfmbcTargetTranscoding.TabIndex = 834
        Me.cmdFfmbcTargetTranscoding.Text = "Convert"
        Me.cmdFfmbcTargetTranscoding.UseVisualStyleBackColor = True
        '
        'txtFfmbcTargetTranscoding
        '
        Me.txtFfmbcTargetTranscoding.Location = New System.Drawing.Point(5, 792)
        Me.txtFfmbcTargetTranscoding.Multiline = True
        Me.txtFfmbcTargetTranscoding.Name = "txtFfmbcTargetTranscoding"
        Me.txtFfmbcTargetTranscoding.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtFfmbcTargetTranscoding.Size = New System.Drawing.Size(702, 55)
        Me.txtFfmbcTargetTranscoding.TabIndex = 833
        Me.txtFfmbcTargetTranscoding.Text = "c:/casparcg/mydata/ffmbc/ffmbc-0.7.4-x64.exe -y -i c:/casparcg/_media/kabhi_kabhi" &
    ".mp4 -tff -target dvcpro50 c:/casparcg/_media/kabhi_kabhi_dvcpro50.mov"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 766)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 13)
        Me.Label6.TabIndex = 832
        Me.Label6.Text = "FFMBC target transcoding"
        '
        'cmdvideohd
        '
        Me.cmdvideohd.Location = New System.Drawing.Point(742, 25)
        Me.cmdvideohd.Name = "cmdvideohd"
        Me.cmdvideohd.Size = New System.Drawing.Size(64, 54)
        Me.cmdvideohd.TabIndex = 831
        Me.cmdvideohd.Text = "Convert"
        Me.cmdvideohd.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(12, 3)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(116, 15)
        Me.Label29.TabIndex = 830
        Me.Label29.Text = "SD to HD scaling"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(523, 30)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(52, 13)
        Me.Label30.TabIndex = 829
        Me.Label30.Text = "File name"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(308, 25)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(92, 13)
        Me.Label31.TabIndex = 828
        Me.Label31.Text = "Destination Folder"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(12, 25)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(60, 13)
        Me.Label32.TabIndex = 827
        Me.Label32.Text = "Source File"
        '
        'txtsourcefileforalphavideosd
        '
        Me.txtsourcefileforalphavideosd.Location = New System.Drawing.Point(5, 43)
        Me.txtsourcefileforalphavideosd.Name = "txtsourcefileforalphavideosd"
        Me.txtsourcefileforalphavideosd.Size = New System.Drawing.Size(234, 20)
        Me.txtsourcefileforalphavideosd.TabIndex = 825
        Me.txtsourcefileforalphavideosd.Text = "c:/casparcg/_media/kabhi_kabhi.mp4 "
        '
        'txtdestinationfolderforhd
        '
        Me.txtdestinationfolderforhd.Location = New System.Drawing.Point(299, 46)
        Me.txtdestinationfolderforhd.Name = "txtdestinationfolderforhd"
        Me.txtdestinationfolderforhd.Size = New System.Drawing.Size(166, 20)
        Me.txtdestinationfolderforhd.TabIndex = 826
        Me.txtdestinationfolderforhd.Text = "c:/casparcg/mydata/png/"
        '
        'txtfilenameforhd
        '
        Me.txtfilenameforhd.Location = New System.Drawing.Point(526, 46)
        Me.txtfilenameforhd.Name = "txtfilenameforhd"
        Me.txtfilenameforhd.Size = New System.Drawing.Size(145, 20)
        Me.txtfilenameforhd.TabIndex = 824
        Me.txtfilenameforhd.Text = "test"
        '
        'cmddestinationfolderforhd
        '
        Me.cmddestinationfolderforhd.Location = New System.Drawing.Point(471, 46)
        Me.cmddestinationfolderforhd.Name = "cmddestinationfolderforhd"
        Me.cmddestinationfolderforhd.Size = New System.Drawing.Size(47, 25)
        Me.cmddestinationfolderforhd.TabIndex = 823
        Me.cmddestinationfolderforhd.Text = "Open destination Directory"
        Me.cmddestinationfolderforhd.UseVisualStyleBackColor = True
        '
        'cmdvideosd
        '
        Me.cmdvideosd.Location = New System.Drawing.Point(245, 43)
        Me.cmdvideosd.Name = "cmdvideosd"
        Me.cmdvideosd.Size = New System.Drawing.Size(48, 25)
        Me.cmdvideosd.TabIndex = 822
        Me.cmdvideosd.Text = "Open Souerce File"
        Me.cmdvideosd.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(523, 100)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(52, 13)
        Me.Label28.TabIndex = 820
        Me.Label28.Text = "File name"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(669, 100)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(71, 13)
        Me.Label27.TabIndex = 819
        Me.Label27.Text = "Image Format"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(326, 91)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(92, 13)
        Me.Label26.TabIndex = 818
        Me.Label26.Text = "Destination Folder"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(12, 91)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(60, 13)
        Me.Label25.TabIndex = 817
        Me.Label25.Text = "Source File"
        '
        'txtsourcefileforalphavideo
        '
        Me.txtsourcefileforalphavideo.Location = New System.Drawing.Point(5, 109)
        Me.txtsourcefileforalphavideo.Name = "txtsourcefileforalphavideo"
        Me.txtsourcefileforalphavideo.Size = New System.Drawing.Size(234, 20)
        Me.txtsourcefileforalphavideo.TabIndex = 815
        Me.txtsourcefileforalphavideo.Text = "c:/casparcg/_media/kabhi_kabhi.mp4 "
        '
        'txtdestinationfolderforalphaimage
        '
        Me.txtdestinationfolderforalphaimage.Location = New System.Drawing.Point(299, 112)
        Me.txtdestinationfolderforalphaimage.Name = "txtdestinationfolderforalphaimage"
        Me.txtdestinationfolderforalphaimage.Size = New System.Drawing.Size(166, 20)
        Me.txtdestinationfolderforalphaimage.TabIndex = 816
        Me.txtdestinationfolderforalphaimage.Text = "c:/casparcg/mydata/png/"
        '
        'txtfilenameforimage
        '
        Me.txtfilenameforimage.Location = New System.Drawing.Point(526, 116)
        Me.txtfilenameforimage.Name = "txtfilenameforimage"
        Me.txtfilenameforimage.Size = New System.Drawing.Size(140, 20)
        Me.txtfilenameforimage.TabIndex = 814
        Me.txtfilenameforimage.Text = "test"
        '
        'cmddestinationfolderforalphaimage
        '
        Me.cmddestinationfolderforalphaimage.Location = New System.Drawing.Point(471, 112)
        Me.cmddestinationfolderforalphaimage.Name = "cmddestinationfolderforalphaimage"
        Me.cmddestinationfolderforalphaimage.Size = New System.Drawing.Size(47, 25)
        Me.cmddestinationfolderforalphaimage.TabIndex = 813
        Me.cmddestinationfolderforalphaimage.Text = "Open destination Directory"
        Me.cmddestinationfolderforalphaimage.UseVisualStyleBackColor = True
        '
        'cmdvideoforimage
        '
        Me.cmdvideoforimage.Location = New System.Drawing.Point(245, 109)
        Me.cmdvideoforimage.Name = "cmdvideoforimage"
        Me.cmdvideoforimage.Size = New System.Drawing.Size(48, 25)
        Me.cmdvideoforimage.TabIndex = 812
        Me.cmdvideoforimage.Text = "Open Souerce File"
        Me.cmdvideoforimage.UseVisualStyleBackColor = True
        '
        'cmbcodecforalpha
        '
        Me.cmbcodecforalpha.FormattingEnabled = True
        Me.cmbcodecforalpha.Items.AddRange(New Object() {"tga", "png"})
        Me.cmbcodecforalpha.Location = New System.Drawing.Point(672, 116)
        Me.cmbcodecforalpha.Name = "cmbcodecforalpha"
        Me.cmbcodecforalpha.Size = New System.Drawing.Size(52, 21)
        Me.cmbcodecforalpha.TabIndex = 811
        Me.cmbcodecforalpha.Text = "png"
        '
        'cmdaudioinsinglestream
        '
        Me.cmdaudioinsinglestream.Location = New System.Drawing.Point(742, 710)
        Me.cmdaudioinsinglestream.Name = "cmdaudioinsinglestream"
        Me.cmdaudioinsinglestream.Size = New System.Drawing.Size(64, 46)
        Me.cmdaudioinsinglestream.TabIndex = 810
        Me.cmdaudioinsinglestream.Text = "Convert"
        Me.cmdaudioinsinglestream.UseVisualStyleBackColor = True
        '
        'txtaudioinsinglestream
        '
        Me.txtaudioinsinglestream.Location = New System.Drawing.Point(5, 710)
        Me.txtaudioinsinglestream.Multiline = True
        Me.txtaudioinsinglestream.Name = "txtaudioinsinglestream"
        Me.txtaudioinsinglestream.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtaudioinsinglestream.Size = New System.Drawing.Size(702, 48)
        Me.txtaudioinsinglestream.TabIndex = 809
        Me.txtaudioinsinglestream.Text = resources.GetString("txtaudioinsinglestream.Text")
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 694)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(238, 13)
        Me.Label23.TabIndex = 808
        Me.Label23.Text = "Audio in different stream to single stream"
        '
        'cmdaddingaudiotracktovideomam
        '
        Me.cmdaddingaudiotracktovideomam.Location = New System.Drawing.Point(742, 644)
        Me.cmdaddingaudiotracktovideomam.Name = "cmdaddingaudiotracktovideomam"
        Me.cmdaddingaudiotracktovideomam.Size = New System.Drawing.Size(64, 33)
        Me.cmdaddingaudiotracktovideomam.TabIndex = 807
        Me.cmdaddingaudiotracktovideomam.Text = "Convert"
        Me.cmdaddingaudiotracktovideomam.UseVisualStyleBackColor = True
        '
        'txtaddingaudiotracktovideomam
        '
        Me.txtaddingaudiotracktovideomam.Location = New System.Drawing.Point(5, 641)
        Me.txtaddingaudiotracktovideomam.Multiline = True
        Me.txtaddingaudiotracktovideomam.Name = "txtaddingaudiotracktovideomam"
        Me.txtaddingaudiotracktovideomam.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtaddingaudiotracktovideomam.Size = New System.Drawing.Size(702, 46)
        Me.txtaddingaudiotracktovideomam.TabIndex = 806
        Me.txtaddingaudiotracktovideomam.Text = resources.GetString("txtaddingaudiotracktovideomam.Text")
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(12, 625)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(166, 13)
        Me.Label22.TabIndex = 805
        Me.Label22.Text = "Adding Audio track to Video"
        '
        'cmdvideotosequencemam
        '
        Me.cmdvideotosequencemam.Location = New System.Drawing.Point(742, 100)
        Me.cmdvideotosequencemam.Name = "cmdvideotosequencemam"
        Me.cmdvideotosequencemam.Size = New System.Drawing.Size(64, 37)
        Me.cmdvideotosequencemam.TabIndex = 804
        Me.cmdvideotosequencemam.Text = "Convert"
        Me.cmdvideotosequencemam.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 69)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(132, 15)
        Me.Label21.TabIndex = 802
        Me.Label21.Text = "Video to sequences"
        '
        'cmdsequencetovideomam
        '
        Me.cmdsequencetovideomam.Location = New System.Drawing.Point(742, 166)
        Me.cmdsequencetovideomam.Name = "cmdsequencetovideomam"
        Me.cmdsequencetovideomam.Size = New System.Drawing.Size(64, 39)
        Me.cmdsequencetovideomam.TabIndex = 801
        Me.cmdsequencetovideomam.Text = "Convert"
        Me.cmdsequencetovideomam.UseVisualStyleBackColor = True
        '
        'txtsequencetovideomam
        '
        Me.txtsequencetovideomam.Location = New System.Drawing.Point(5, 166)
        Me.txtsequencetovideomam.Multiline = True
        Me.txtsequencetovideomam.Name = "txtsequencetovideomam"
        Me.txtsequencetovideomam.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtsequencetovideomam.Size = New System.Drawing.Size(702, 39)
        Me.txtsequencetovideomam.TabIndex = 800
        Me.txtsequencetovideomam.Text = "c:/casparcg/mydata/ffmpeg/ffmpeg.exe -y -i c:/casparcg/mydata/png/test%5d.png -vc" &
    "odec png c:/casparcg/_media/video1.mov"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 150)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(148, 13)
        Me.Label20.TabIndex = 483
        Me.Label20.Text = "PNG sequences to video"
        '
        'EbuCoreMetadata
        '
        Me.EbuCoreMetadata.Controls.Add(Me.gbmetadata)
        Me.EbuCoreMetadata.Location = New System.Drawing.Point(4, 22)
        Me.EbuCoreMetadata.Name = "EbuCoreMetadata"
        Me.EbuCoreMetadata.Padding = New System.Windows.Forms.Padding(3)
        Me.EbuCoreMetadata.Size = New System.Drawing.Size(812, 900)
        Me.EbuCoreMetadata.TabIndex = 4
        Me.EbuCoreMetadata.Text = "Ebu Core Metadata"
        Me.EbuCoreMetadata.UseVisualStyleBackColor = True
        '
        'gbmetadata
        '
        Me.gbmetadata.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbmetadata.Controls.Add(Me.cmbebu2mxfoption)
        Me.gbmetadata.Controls.Add(Me.cmddefaultmetadata)
        Me.gbmetadata.Controls.Add(Me.cmdebu2mxf)
        Me.gbmetadata.Controls.Add(Me.cmbanalyzeroption)
        Me.gbmetadata.Controls.Add(Me.lblfilenamemetadata)
        Me.gbmetadata.Controls.Add(Me.cmdanalyse)
        Me.gbmetadata.Controls.Add(Me.Label238)
        Me.gbmetadata.Controls.Add(Me.cmdclearfieldmetadata)
        Me.gbmetadata.Controls.Add(Me.cmdwritemetadata)
        Me.gbmetadata.Controls.Add(Me.cmdreadmetadata)
        Me.gbmetadata.Controls.Add(Me.dgvmetadata)
        Me.gbmetadata.Location = New System.Drawing.Point(11, 7)
        Me.gbmetadata.Name = "gbmetadata"
        Me.gbmetadata.Size = New System.Drawing.Size(544, 533)
        Me.gbmetadata.TabIndex = 1173
        Me.gbmetadata.TabStop = False
        Me.gbmetadata.Text = "EBU Core Metadata"
        '
        'cmbebu2mxfoption
        '
        Me.cmbebu2mxfoption.FormattingEnabled = True
        Me.cmbebu2mxfoption.Items.AddRange(New Object() {"-l C:\casparcg\mydata\ebumxf\aa.log", "-i", "--ebu-core C:\casparcg\mydata\ebumxf\EbuCore.xml", "--force-header --ebu-core C:\casparcg\mydata\ebumxf\EbuCore.xml", "--dark --ebu-core C:\casparcg\mydata\ebumxf\EbuCore.xml", "--sidecar --ebu-core C:\casparcg\mydata\ebumxf\EbuCore.xml", "--remove"})
        Me.cmbebu2mxfoption.Location = New System.Drawing.Point(10, 464)
        Me.cmbebu2mxfoption.Name = "cmbebu2mxfoption"
        Me.cmbebu2mxfoption.Size = New System.Drawing.Size(306, 21)
        Me.cmbebu2mxfoption.TabIndex = 1175
        Me.cmbebu2mxfoption.Text = "--remove"
        '
        'cmddefaultmetadata
        '
        Me.cmddefaultmetadata.Location = New System.Drawing.Point(342, 51)
        Me.cmddefaultmetadata.Name = "cmddefaultmetadata"
        Me.cmddefaultmetadata.Size = New System.Drawing.Size(125, 24)
        Me.cmddefaultmetadata.TabIndex = 6
        Me.cmddefaultmetadata.Text = "Example metadata"
        Me.cmddefaultmetadata.UseVisualStyleBackColor = True
        '
        'cmdebu2mxf
        '
        Me.cmdebu2mxf.Location = New System.Drawing.Point(322, 464)
        Me.cmdebu2mxf.Name = "cmdebu2mxf"
        Me.cmdebu2mxf.Size = New System.Drawing.Size(108, 23)
        Me.cmdebu2mxf.TabIndex = 1174
        Me.cmdebu2mxf.Text = "ebu2mxf operation"
        Me.cmdebu2mxf.UseVisualStyleBackColor = True
        '
        'cmbanalyzeroption
        '
        Me.cmbanalyzeroption.FormattingEnabled = True
        Me.cmbanalyzeroption.Items.AddRange(New Object() {"--report C:\casparcg\mydata\ebumxf\report.xml", "--physical --report C:\casparcg\mydata\ebumxf\report.xml", "--logical --report C:\casparcg\mydata\ebumxf\report.xml", "--metadata --report C:\casparcg\mydata\ebumxf\report.xml", "--mux --report C:\casparcg\mydata\ebumxf\report.xml", "--deepindex --report C:\casparcg\mydata\ebumxf\report.xml"})
        Me.cmbanalyzeroption.Location = New System.Drawing.Point(10, 493)
        Me.cmbanalyzeroption.Name = "cmbanalyzeroption"
        Me.cmbanalyzeroption.Size = New System.Drawing.Size(306, 21)
        Me.cmbanalyzeroption.TabIndex = 1173
        Me.cmbanalyzeroption.Text = "--metadata"
        '
        'lblfilenamemetadata
        '
        Me.lblfilenamemetadata.AutoSize = True
        Me.lblfilenamemetadata.Location = New System.Drawing.Point(73, 21)
        Me.lblfilenamemetadata.Name = "lblfilenamemetadata"
        Me.lblfilenamemetadata.Size = New System.Drawing.Size(38, 13)
        Me.lblfilenamemetadata.TabIndex = 5
        Me.lblfilenamemetadata.Text = "aa.mxf"
        '
        'cmdanalyse
        '
        Me.cmdanalyse.Location = New System.Drawing.Point(322, 493)
        Me.cmdanalyse.Name = "cmdanalyse"
        Me.cmdanalyse.Size = New System.Drawing.Size(96, 23)
        Me.cmdanalyse.TabIndex = 6
        Me.cmdanalyse.Text = "Analyse"
        Me.cmdanalyse.UseVisualStyleBackColor = True
        '
        'Label238
        '
        Me.Label238.AutoSize = True
        Me.Label238.Location = New System.Drawing.Point(6, 23)
        Me.Label238.Name = "Label238"
        Me.Label238.Size = New System.Drawing.Size(54, 13)
        Me.Label238.TabIndex = 4
        Me.Label238.Text = "File Name"
        '
        'cmdclearfieldmetadata
        '
        Me.cmdclearfieldmetadata.Location = New System.Drawing.Point(270, 51)
        Me.cmdclearfieldmetadata.Name = "cmdclearfieldmetadata"
        Me.cmdclearfieldmetadata.Size = New System.Drawing.Size(65, 23)
        Me.cmdclearfieldmetadata.TabIndex = 3
        Me.cmdclearfieldmetadata.Text = "Clear Field"
        Me.cmdclearfieldmetadata.UseVisualStyleBackColor = True
        '
        'cmdwritemetadata
        '
        Me.cmdwritemetadata.Location = New System.Drawing.Point(141, 52)
        Me.cmdwritemetadata.Name = "cmdwritemetadata"
        Me.cmdwritemetadata.Size = New System.Drawing.Size(120, 23)
        Me.cmdwritemetadata.TabIndex = 2
        Me.cmdwritemetadata.Text = "Write with dark option"
        Me.cmdwritemetadata.UseVisualStyleBackColor = True
        '
        'cmdreadmetadata
        '
        Me.cmdreadmetadata.Location = New System.Drawing.Point(8, 52)
        Me.cmdreadmetadata.Name = "cmdreadmetadata"
        Me.cmdreadmetadata.Size = New System.Drawing.Size(118, 23)
        Me.cmdreadmetadata.TabIndex = 1
        Me.cmdreadmetadata.Text = "Read in Browser"
        Me.cmdreadmetadata.UseVisualStyleBackColor = True
        '
        'dgvmetadata
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmetadata.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvmetadata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmetadata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvmetadata.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvmetadata.Location = New System.Drawing.Point(8, 77)
        Me.dgvmetadata.Name = "dgvmetadata"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmetadata.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvmetadata.Size = New System.Drawing.Size(524, 344)
        Me.dgvmetadata.TabIndex = 0
        '
        'CopyandProxyProgram
        '
        Me.CopyandProxyProgram.Controls.Add(Me.cmdopendestinationdirectory)
        Me.CopyandProxyProgram.Controls.Add(Me.cmdopensourcedirectory)
        Me.CopyandProxyProgram.Controls.Add(Me.cmdopendestinationdirectoryproxy)
        Me.CopyandProxyProgram.Controls.Add(Me.txtSourceDirectory)
        Me.CopyandProxyProgram.Controls.Add(Me.Label2)
        Me.CopyandProxyProgram.Controls.Add(Me.cmdshowfilesinSourcelistbox)
        Me.CopyandProxyProgram.Controls.Add(Me.txtDestinationDirectoryProxy)
        Me.CopyandProxyProgram.Controls.Add(Me.cmdMove)
        Me.CopyandProxyProgram.Controls.Add(Me.lstDestinationDirectory)
        Me.CopyandProxyProgram.Controls.Add(Me.cmdCopy)
        Me.CopyandProxyProgram.Controls.Add(Me.lstSourceDirectory)
        Me.CopyandProxyProgram.Controls.Add(Me.cmdshowfilesinDestinationlistboxproxy)
        Me.CopyandProxyProgram.Controls.Add(Me.Label1)
        Me.CopyandProxyProgram.Controls.Add(Me.cmdshowfilesinDestinationlistbox)
        Me.CopyandProxyProgram.Controls.Add(Me.lstDestinationDirectoryProxy)
        Me.CopyandProxyProgram.Controls.Add(Me.txtDestinationDirectory)
        Me.CopyandProxyProgram.Controls.Add(Me.Label4)
        Me.CopyandProxyProgram.Controls.Add(Me.cmdmakeproxy)
        Me.CopyandProxyProgram.Location = New System.Drawing.Point(4, 22)
        Me.CopyandProxyProgram.Name = "CopyandProxyProgram"
        Me.CopyandProxyProgram.Padding = New System.Windows.Forms.Padding(3)
        Me.CopyandProxyProgram.Size = New System.Drawing.Size(812, 900)
        Me.CopyandProxyProgram.TabIndex = 0
        Me.CopyandProxyProgram.Text = "Copy and Proxy Program"
        Me.CopyandProxyProgram.UseVisualStyleBackColor = True
        '
        'BatchTranscoder
        '
        Me.BatchTranscoder.Controls.Add(Me.txtffmpegoutput)
        Me.BatchTranscoder.Controls.Add(Me.cmdsearchdatagridbt)
        Me.BatchTranscoder.Controls.Add(Me.txtsearchdatagridbt)
        Me.BatchTranscoder.Controls.Add(Me.cmdDeSelectAllfromcurrentposition)
        Me.BatchTranscoder.Controls.Add(Me.cmdDeSelectAll)
        Me.BatchTranscoder.Controls.Add(Me.cmdSelectAll)
        Me.BatchTranscoder.Controls.Add(Me.lbltrandingfilename)
        Me.BatchTranscoder.Controls.Add(Me.cmdselectsourcefolderfortranscoding)
        Me.BatchTranscoder.Controls.Add(Me.cmdselectdestinationfolderfortranscoding)
        Me.BatchTranscoder.Controls.Add(Me.Label7)
        Me.BatchTranscoder.Controls.Add(Me.Label11)
        Me.BatchTranscoder.Controls.Add(Me.lblexportclipinfobt)
        Me.BatchTranscoder.Controls.Add(Me.dgvtranscoder)
        Me.BatchTranscoder.Controls.Add(Me.cmdstoptranscoding)
        Me.BatchTranscoder.Controls.Add(Me.txtdestinationdirectorybt)
        Me.BatchTranscoder.Controls.Add(Me.Label12)
        Me.BatchTranscoder.Controls.Add(Me.txtsourcedirectorybt)
        Me.BatchTranscoder.Controls.Add(Me.cmdstarttranscoding)
        Me.BatchTranscoder.Controls.Add(Me.cmdfilldatgridbt)
        Me.BatchTranscoder.Location = New System.Drawing.Point(4, 22)
        Me.BatchTranscoder.Name = "BatchTranscoder"
        Me.BatchTranscoder.Padding = New System.Windows.Forms.Padding(3)
        Me.BatchTranscoder.Size = New System.Drawing.Size(812, 900)
        Me.BatchTranscoder.TabIndex = 1
        Me.BatchTranscoder.Text = "Batch Transcoder"
        Me.BatchTranscoder.UseVisualStyleBackColor = True
        '
        'txtffmpegoutput
        '
        Me.txtffmpegoutput.Location = New System.Drawing.Point(19, 511)
        Me.txtffmpegoutput.Multiline = True
        Me.txtffmpegoutput.Name = "txtffmpegoutput"
        Me.txtffmpegoutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtffmpegoutput.Size = New System.Drawing.Size(522, 165)
        Me.txtffmpegoutput.TabIndex = 810
        '
        'cmdsearchdatagridbt
        '
        Me.cmdsearchdatagridbt.Location = New System.Drawing.Point(244, 50)
        Me.cmdsearchdatagridbt.Name = "cmdsearchdatagridbt"
        Me.cmdsearchdatagridbt.Size = New System.Drawing.Size(69, 23)
        Me.cmdsearchdatagridbt.TabIndex = 809
        Me.cmdsearchdatagridbt.Text = "Search"
        Me.cmdsearchdatagridbt.UseVisualStyleBackColor = True
        '
        'txtsearchdatagridbt
        '
        Me.txtsearchdatagridbt.Location = New System.Drawing.Point(41, 52)
        Me.txtsearchdatagridbt.Name = "txtsearchdatagridbt"
        Me.txtsearchdatagridbt.Size = New System.Drawing.Size(197, 20)
        Me.txtsearchdatagridbt.TabIndex = 808
        '
        'cmdDeSelectAllfromcurrentposition
        '
        Me.cmdDeSelectAllfromcurrentposition.Location = New System.Drawing.Point(547, 144)
        Me.cmdDeSelectAllfromcurrentposition.Name = "cmdDeSelectAllfromcurrentposition"
        Me.cmdDeSelectAllfromcurrentposition.Size = New System.Drawing.Size(92, 39)
        Me.cmdDeSelectAllfromcurrentposition.TabIndex = 807
        Me.cmdDeSelectAllfromcurrentposition.Text = "Select All from current position"
        Me.cmdDeSelectAllfromcurrentposition.UseVisualStyleBackColor = True
        '
        'cmdDeSelectAll
        '
        Me.cmdDeSelectAll.Location = New System.Drawing.Point(547, 114)
        Me.cmdDeSelectAll.Name = "cmdDeSelectAll"
        Me.cmdDeSelectAll.Size = New System.Drawing.Size(75, 23)
        Me.cmdDeSelectAll.TabIndex = 806
        Me.cmdDeSelectAll.Text = "DeSelect All"
        Me.cmdDeSelectAll.UseVisualStyleBackColor = True
        '
        'cmdSelectAll
        '
        Me.cmdSelectAll.Location = New System.Drawing.Point(547, 85)
        Me.cmdSelectAll.Name = "cmdSelectAll"
        Me.cmdSelectAll.Size = New System.Drawing.Size(75, 23)
        Me.cmdSelectAll.TabIndex = 805
        Me.cmdSelectAll.Text = "Select All"
        Me.cmdSelectAll.UseVisualStyleBackColor = True
        '
        'lbltrandingfilename
        '
        Me.lbltrandingfilename.AutoSize = True
        Me.lbltrandingfilename.Location = New System.Drawing.Point(40, 480)
        Me.lbltrandingfilename.Name = "lbltrandingfilename"
        Me.lbltrandingfilename.Size = New System.Drawing.Size(23, 13)
        Me.lbltrandingfilename.TabIndex = 804
        Me.lbltrandingfilename.Text = "File"
        '
        'cmdselectsourcefolderfortranscoding
        '
        Me.cmdselectsourcefolderfortranscoding.Location = New System.Drawing.Point(305, 25)
        Me.cmdselectsourcefolderfortranscoding.Name = "cmdselectsourcefolderfortranscoding"
        Me.cmdselectsourcefolderfortranscoding.Size = New System.Drawing.Size(28, 23)
        Me.cmdselectsourcefolderfortranscoding.TabIndex = 803
        Me.cmdselectsourcefolderfortranscoding.Text = ".."
        Me.cmdselectsourcefolderfortranscoding.UseVisualStyleBackColor = True
        '
        'cmdselectdestinationfolderfortranscoding
        '
        Me.cmdselectdestinationfolderfortranscoding.Location = New System.Drawing.Point(594, 37)
        Me.cmdselectdestinationfolderfortranscoding.Name = "cmdselectdestinationfolderfortranscoding"
        Me.cmdselectdestinationfolderfortranscoding.Size = New System.Drawing.Size(28, 23)
        Me.cmdselectdestinationfolderfortranscoding.TabIndex = 802
        Me.cmdselectdestinationfolderfortranscoding.Text = ".."
        Me.cmdselectdestinationfolderfortranscoding.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 467)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 13)
        Me.Label7.TabIndex = 800
        Me.Label7.Text = "Transcoding Progress"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(437, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 13)
        Me.Label11.TabIndex = 796
        Me.Label11.Text = "Destination Folder"
        '
        'lblexportclipinfobt
        '
        Me.lblexportclipinfobt.AutoSize = True
        Me.lblexportclipinfobt.Location = New System.Drawing.Point(203, 469)
        Me.lblexportclipinfobt.Name = "lblexportclipinfobt"
        Me.lblexportclipinfobt.Size = New System.Drawing.Size(35, 13)
        Me.lblexportclipinfobt.TabIndex = 791
        Me.lblexportclipinfobt.Text = "status"
        '
        'dgvtranscoder
        '
        Me.dgvtranscoder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtranscoder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvtranscoder.Location = New System.Drawing.Point(41, 76)
        Me.dgvtranscoder.Name = "dgvtranscoder"
        Me.dgvtranscoder.Size = New System.Drawing.Size(500, 377)
        Me.dgvtranscoder.TabIndex = 792
        '
        'Column2
        '
        Me.Column2.FalseValue = "0"
        Me.Column2.HeaderText = "Select"
        Me.Column2.Name = "Column2"
        Me.Column2.TrueValue = "1"
        Me.Column2.Width = 50
        '
        'cmdstoptranscoding
        '
        Me.cmdstoptranscoding.Location = New System.Drawing.Point(547, 360)
        Me.cmdstoptranscoding.Name = "cmdstoptranscoding"
        Me.cmdstoptranscoding.Size = New System.Drawing.Size(107, 23)
        Me.cmdstoptranscoding.TabIndex = 798
        Me.cmdstoptranscoding.Text = "Stop Transcoding"
        Me.cmdstoptranscoding.UseVisualStyleBackColor = True
        '
        'txtdestinationdirectorybt
        '
        Me.txtdestinationdirectorybt.Enabled = False
        Me.txtdestinationdirectorybt.Location = New System.Drawing.Point(436, 39)
        Me.txtdestinationdirectorybt.Name = "txtdestinationdirectorybt"
        Me.txtdestinationdirectorybt.Size = New System.Drawing.Size(152, 20)
        Me.txtdestinationdirectorybt.TabIndex = 797
        Me.txtdestinationdirectorybt.Text = "d:\casparcg\_media\"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(33, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 795
        Me.Label12.Text = "Source folder"
        '
        'txtsourcedirectorybt
        '
        Me.txtsourcedirectorybt.Enabled = False
        Me.txtsourcedirectorybt.Location = New System.Drawing.Point(36, 27)
        Me.txtsourcedirectorybt.Name = "txtsourcedirectorybt"
        Me.txtsourcedirectorybt.Size = New System.Drawing.Size(263, 20)
        Me.txtsourcedirectorybt.TabIndex = 794
        Me.txtsourcedirectorybt.Text = "c:\casparcg\_media\"
        '
        'cmdstarttranscoding
        '
        Me.cmdstarttranscoding.Location = New System.Drawing.Point(547, 331)
        Me.cmdstarttranscoding.Name = "cmdstarttranscoding"
        Me.cmdstarttranscoding.Size = New System.Drawing.Size(109, 23)
        Me.cmdstarttranscoding.TabIndex = 793
        Me.cmdstarttranscoding.Text = "Strat Transcoding"
        Me.cmdstarttranscoding.UseVisualStyleBackColor = True
        '
        'cmdfilldatgridbt
        '
        Me.cmdfilldatgridbt.Location = New System.Drawing.Point(348, 28)
        Me.cmdfilldatgridbt.Name = "cmdfilldatgridbt"
        Me.cmdfilldatgridbt.Size = New System.Drawing.Size(69, 23)
        Me.cmdfilldatgridbt.TabIndex = 790
        Me.cmdfilldatgridbt.Text = "Fill datagrid"
        Me.cmdfilldatgridbt.UseVisualStyleBackColor = True
        '
        'WatchFolder
        '
        Me.WatchFolder.Controls.Add(Me.cmdSelectDirectoryForAutoCopy)
        Me.WatchFolder.Controls.Add(Me.gbdatatablesetting)
        Me.WatchFolder.Controls.Add(Me.txtfilechanged)
        Me.WatchFolder.Controls.Add(Me.chktranscode)
        Me.WatchFolder.Controls.Add(Me.txttranscodedirectory)
        Me.WatchFolder.Controls.Add(Me.chkmediabackup)
        Me.WatchFolder.Controls.Add(Me.txtmediabackupfplder)
        Me.WatchFolder.Controls.Add(Me.Label19)
        Me.WatchFolder.Controls.Add(Me.cmdSelectDirectoryForAutoTranscode)
        Me.WatchFolder.Controls.Add(Me.cmdsearchdatatable)
        Me.WatchFolder.Controls.Add(Me.labelclips)
        Me.WatchFolder.Controls.Add(Me.txtsearchclip)
        Me.WatchFolder.Controls.Add(Me.dgvclips)
        Me.WatchFolder.Location = New System.Drawing.Point(4, 22)
        Me.WatchFolder.Name = "WatchFolder"
        Me.WatchFolder.Padding = New System.Windows.Forms.Padding(3)
        Me.WatchFolder.Size = New System.Drawing.Size(812, 900)
        Me.WatchFolder.TabIndex = 2
        Me.WatchFolder.Text = "Watch Folder"
        Me.WatchFolder.UseVisualStyleBackColor = True
        '
        'cmdSelectDirectoryForAutoCopy
        '
        Me.cmdSelectDirectoryForAutoCopy.Location = New System.Drawing.Point(281, 527)
        Me.cmdSelectDirectoryForAutoCopy.Name = "cmdSelectDirectoryForAutoCopy"
        Me.cmdSelectDirectoryForAutoCopy.Size = New System.Drawing.Size(26, 23)
        Me.cmdSelectDirectoryForAutoCopy.TabIndex = 490
        Me.cmdSelectDirectoryForAutoCopy.Text = "..."
        Me.cmdSelectDirectoryForAutoCopy.UseVisualStyleBackColor = True
        '
        'gbdatatablesetting
        '
        Me.gbdatatablesetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbdatatablesetting.Controls.Add(Me.cmdstopwatching)
        Me.gbdatatablesetting.Controls.Add(Me.cmdSelectDirectoryforSymlinked2Mediawatchfolder)
        Me.gbdatatablesetting.Controls.Add(Me.cmdSelectDirectoryformainMediawatchfolder)
        Me.gbdatatablesetting.Controls.Add(Me.cmdSelectDirectoryforSymlinked1Mediawatchfolder)
        Me.gbdatatablesetting.Controls.Add(Me.chkwithduration)
        Me.gbdatatablesetting.Controls.Add(Me.Label13)
        Me.gbdatatablesetting.Controls.Add(Me.pbsearchprogress)
        Me.gbdatatablesetting.Controls.Add(Me.chksymlinkedalis2)
        Me.gbdatatablesetting.Controls.Add(Me.chksymlinkedalis1)
        Me.gbdatatablesetting.Controls.Add(Me.Label14)
        Me.gbdatatablesetting.Controls.Add(Me.Label15)
        Me.gbdatatablesetting.Controls.Add(Me.txtsymlinked2mediafolder)
        Me.gbdatatablesetting.Controls.Add(Me.txtsymlinkedalis2)
        Me.gbdatatablesetting.Controls.Add(Me.txtsymlinkedalis1)
        Me.gbdatatablesetting.Controls.Add(Me.Label16)
        Me.gbdatatablesetting.Controls.Add(Me.Label17)
        Me.gbdatatablesetting.Controls.Add(Me.txtsymlinked1mediafolder)
        Me.gbdatatablesetting.Controls.Add(Me.txtmainmediafolder)
        Me.gbdatatablesetting.Controls.Add(Me.Label18)
        Me.gbdatatablesetting.Controls.Add(Me.cmdcreatdatatable)
        Me.gbdatatablesetting.Location = New System.Drawing.Point(6, 6)
        Me.gbdatatablesetting.Name = "gbdatatablesetting"
        Me.gbdatatablesetting.Size = New System.Drawing.Size(696, 109)
        Me.gbdatatablesetting.TabIndex = 485
        Me.gbdatatablesetting.TabStop = False
        Me.gbdatatablesetting.Text = "Settings"
        '
        'cmdstopwatching
        '
        Me.cmdstopwatching.Location = New System.Drawing.Point(619, 10)
        Me.cmdstopwatching.Name = "cmdstopwatching"
        Me.cmdstopwatching.Size = New System.Drawing.Size(64, 73)
        Me.cmdstopwatching.TabIndex = 482
        Me.cmdstopwatching.Text = "Stop Watching"
        Me.cmdstopwatching.UseVisualStyleBackColor = True
        '
        'cmdSelectDirectoryforSymlinked2Mediawatchfolder
        '
        Me.cmdSelectDirectoryforSymlinked2Mediawatchfolder.Location = New System.Drawing.Point(307, 62)
        Me.cmdSelectDirectoryforSymlinked2Mediawatchfolder.Name = "cmdSelectDirectoryforSymlinked2Mediawatchfolder"
        Me.cmdSelectDirectoryforSymlinked2Mediawatchfolder.Size = New System.Drawing.Size(26, 23)
        Me.cmdSelectDirectoryforSymlinked2Mediawatchfolder.TabIndex = 481
        Me.cmdSelectDirectoryforSymlinked2Mediawatchfolder.Text = "..."
        Me.cmdSelectDirectoryforSymlinked2Mediawatchfolder.UseVisualStyleBackColor = True
        '
        'cmdSelectDirectoryformainMediawatchfolder
        '
        Me.cmdSelectDirectoryformainMediawatchfolder.Location = New System.Drawing.Point(307, 10)
        Me.cmdSelectDirectoryformainMediawatchfolder.Name = "cmdSelectDirectoryformainMediawatchfolder"
        Me.cmdSelectDirectoryformainMediawatchfolder.Size = New System.Drawing.Size(26, 23)
        Me.cmdSelectDirectoryformainMediawatchfolder.TabIndex = 480
        Me.cmdSelectDirectoryformainMediawatchfolder.Text = "..."
        Me.cmdSelectDirectoryformainMediawatchfolder.UseVisualStyleBackColor = True
        '
        'cmdSelectDirectoryforSymlinked1Mediawatchfolder
        '
        Me.cmdSelectDirectoryforSymlinked1Mediawatchfolder.Location = New System.Drawing.Point(307, 37)
        Me.cmdSelectDirectoryforSymlinked1Mediawatchfolder.Name = "cmdSelectDirectoryforSymlinked1Mediawatchfolder"
        Me.cmdSelectDirectoryforSymlinked1Mediawatchfolder.Size = New System.Drawing.Size(26, 23)
        Me.cmdSelectDirectoryforSymlinked1Mediawatchfolder.TabIndex = 479
        Me.cmdSelectDirectoryforSymlinked1Mediawatchfolder.Text = "..."
        Me.cmdSelectDirectoryforSymlinked1Mediawatchfolder.UseVisualStyleBackColor = True
        '
        'chkwithduration
        '
        Me.chkwithduration.AutoSize = True
        Me.chkwithduration.Location = New System.Drawing.Point(421, 19)
        Me.chkwithduration.Name = "chkwithduration"
        Me.chkwithduration.Size = New System.Drawing.Size(91, 17)
        Me.chkwithduration.TabIndex = 475
        Me.chkwithduration.Text = "With Duration"
        Me.chkwithduration.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 13)
        Me.Label13.TabIndex = 474
        Me.Label13.Text = "Search Progress"
        '
        'pbsearchprogress
        '
        Me.pbsearchprogress.Location = New System.Drawing.Point(135, 86)
        Me.pbsearchprogress.Name = "pbsearchprogress"
        Me.pbsearchprogress.Size = New System.Drawing.Size(478, 18)
        Me.pbsearchprogress.TabIndex = 473
        '
        'chksymlinkedalis2
        '
        Me.chksymlinkedalis2.AutoSize = True
        Me.chksymlinkedalis2.Location = New System.Drawing.Point(421, 61)
        Me.chksymlinkedalis2.Name = "chksymlinkedalis2"
        Me.chksymlinkedalis2.Size = New System.Drawing.Size(59, 17)
        Me.chksymlinkedalis2.TabIndex = 470
        Me.chksymlinkedalis2.Text = "Enable"
        Me.chksymlinkedalis2.UseVisualStyleBackColor = True
        '
        'chksymlinkedalis1
        '
        Me.chksymlinkedalis1.AutoSize = True
        Me.chksymlinkedalis1.Location = New System.Drawing.Point(421, 39)
        Me.chksymlinkedalis1.Name = "chksymlinkedalis1"
        Me.chksymlinkedalis1.Size = New System.Drawing.Size(59, 17)
        Me.chksymlinkedalis1.TabIndex = 469
        Me.chksymlinkedalis1.Text = "Enable"
        Me.chksymlinkedalis1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(336, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 13)
        Me.Label14.TabIndex = 468
        Me.Label14.Text = "Alias"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 13)
        Me.Label15.TabIndex = 467
        Me.Label15.Text = "Symlinked Media Folder 2"
        '
        'txtsymlinked2mediafolder
        '
        Me.txtsymlinked2mediafolder.Location = New System.Drawing.Point(135, 62)
        Me.txtsymlinked2mediafolder.Name = "txtsymlinked2mediafolder"
        Me.txtsymlinked2mediafolder.Size = New System.Drawing.Size(166, 20)
        Me.txtsymlinked2mediafolder.TabIndex = 466
        Me.txtsymlinked2mediafolder.Text = "s:/casparcg/_media/"
        '
        'txtsymlinkedalis2
        '
        Me.txtsymlinkedalis2.Location = New System.Drawing.Point(367, 60)
        Me.txtsymlinkedalis2.Name = "txtsymlinkedalis2"
        Me.txtsymlinkedalis2.Size = New System.Drawing.Size(48, 20)
        Me.txtsymlinkedalis2.TabIndex = 465
        Me.txtsymlinkedalis2.Text = "snfs"
        '
        'txtsymlinkedalis1
        '
        Me.txtsymlinkedalis1.Location = New System.Drawing.Point(367, 34)
        Me.txtsymlinkedalis1.Name = "txtsymlinkedalis1"
        Me.txtsymlinkedalis1.Size = New System.Drawing.Size(48, 20)
        Me.txtsymlinkedalis1.TabIndex = 464
        Me.txtsymlinkedalis1.Text = "gfs"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(336, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 13)
        Me.Label16.TabIndex = 463
        Me.Label16.Text = "Alias"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(5, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 13)
        Me.Label17.TabIndex = 462
        Me.Label17.Text = "Symlinked Media Folder 1"
        '
        'txtsymlinked1mediafolder
        '
        Me.txtsymlinked1mediafolder.Location = New System.Drawing.Point(135, 36)
        Me.txtsymlinked1mediafolder.Name = "txtsymlinked1mediafolder"
        Me.txtsymlinked1mediafolder.Size = New System.Drawing.Size(166, 20)
        Me.txtsymlinked1mediafolder.TabIndex = 461
        Me.txtsymlinked1mediafolder.Text = "z:/casparcg/_media/"
        '
        'txtmainmediafolder
        '
        Me.txtmainmediafolder.Location = New System.Drawing.Point(135, 10)
        Me.txtmainmediafolder.Name = "txtmainmediafolder"
        Me.txtmainmediafolder.Size = New System.Drawing.Size(166, 20)
        Me.txtmainmediafolder.TabIndex = 460
        Me.txtmainmediafolder.Text = "c:/casparcg/_media/"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(30, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 13)
        Me.Label18.TabIndex = 458
        Me.Label18.Text = "Main Media Folder"
        '
        'cmdcreatdatatable
        '
        Me.cmdcreatdatatable.Location = New System.Drawing.Point(511, 9)
        Me.cmdcreatdatatable.Name = "cmdcreatdatatable"
        Me.cmdcreatdatatable.Size = New System.Drawing.Size(102, 73)
        Me.cmdcreatdatatable.TabIndex = 457
        Me.cmdcreatdatatable.Text = "Create Datatable and Watch"
        Me.cmdcreatdatatable.UseVisualStyleBackColor = True
        '
        'txtfilechanged
        '
        Me.txtfilechanged.Location = New System.Drawing.Point(9, 411)
        Me.txtfilechanged.Multiline = True
        Me.txtfilechanged.Name = "txtfilechanged"
        Me.txtfilechanged.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtfilechanged.Size = New System.Drawing.Size(617, 67)
        Me.txtfilechanged.TabIndex = 483
        '
        'chktranscode
        '
        Me.chktranscode.AutoSize = True
        Me.chktranscode.Location = New System.Drawing.Point(15, 551)
        Me.chktranscode.Name = "chktranscode"
        Me.chktranscode.Size = New System.Drawing.Size(118, 17)
        Me.chktranscode.TabIndex = 489
        Me.chktranscode.Text = "Auto Transcode To"
        Me.chktranscode.UseVisualStyleBackColor = True
        '
        'txttranscodedirectory
        '
        Me.txttranscodedirectory.Location = New System.Drawing.Point(15, 570)
        Me.txttranscodedirectory.Name = "txttranscodedirectory"
        Me.txttranscodedirectory.Size = New System.Drawing.Size(260, 20)
        Me.txttranscodedirectory.TabIndex = 488
        Me.txttranscodedirectory.Text = "C:/casparcg/mydata/"
        '
        'chkmediabackup
        '
        Me.chkmediabackup.AutoSize = True
        Me.chkmediabackup.Location = New System.Drawing.Point(15, 509)
        Me.chkmediabackup.Name = "chkmediabackup"
        Me.chkmediabackup.Size = New System.Drawing.Size(87, 17)
        Me.chkmediabackup.TabIndex = 487
        Me.chkmediabackup.Text = "Auto Copy to"
        Me.chkmediabackup.UseVisualStyleBackColor = True
        '
        'txtmediabackupfplder
        '
        Me.txtmediabackupfplder.Location = New System.Drawing.Point(14, 527)
        Me.txtmediabackupfplder.Name = "txtmediabackupfplder"
        Me.txtmediabackupfplder.Size = New System.Drawing.Size(261, 20)
        Me.txtmediabackupfplder.TabIndex = 486
        Me.txtmediabackupfplder.Text = "C:/casparcg/mydata/"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 393)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(124, 13)
        Me.Label19.TabIndex = 484
        Me.Label19.Text = "File Changes Notification"
        '
        'cmdSelectDirectoryForAutoTranscode
        '
        Me.cmdSelectDirectoryForAutoTranscode.Location = New System.Drawing.Point(281, 567)
        Me.cmdSelectDirectoryForAutoTranscode.Name = "cmdSelectDirectoryForAutoTranscode"
        Me.cmdSelectDirectoryForAutoTranscode.Size = New System.Drawing.Size(26, 23)
        Me.cmdSelectDirectoryForAutoTranscode.TabIndex = 491
        Me.cmdSelectDirectoryForAutoTranscode.Text = "..."
        Me.cmdSelectDirectoryForAutoTranscode.UseVisualStyleBackColor = True
        '
        'cmdsearchdatatable
        '
        Me.cmdsearchdatatable.Location = New System.Drawing.Point(252, 123)
        Me.cmdsearchdatatable.Name = "cmdsearchdatatable"
        Me.cmdsearchdatatable.Size = New System.Drawing.Size(98, 23)
        Me.cmdsearchdatatable.TabIndex = 479
        Me.cmdsearchdatatable.Text = "Search Datatable"
        Me.cmdsearchdatatable.UseVisualStyleBackColor = True
        '
        'labelclips
        '
        Me.labelclips.AutoSize = True
        Me.labelclips.Location = New System.Drawing.Point(25, 127)
        Me.labelclips.Name = "labelclips"
        Me.labelclips.Size = New System.Drawing.Size(53, 13)
        Me.labelclips.TabIndex = 482
        Me.labelclips.Text = " labelclips"
        '
        'txtsearchclip
        '
        Me.txtsearchclip.Location = New System.Drawing.Point(96, 125)
        Me.txtsearchclip.Name = "txtsearchclip"
        Me.txtsearchclip.Size = New System.Drawing.Size(150, 20)
        Me.txtsearchclip.TabIndex = 481
        '
        'dgvclips
        '
        Me.dgvclips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvclips.Location = New System.Drawing.Point(9, 163)
        Me.dgvclips.Name = "dgvclips"
        Me.dgvclips.Size = New System.Drawing.Size(619, 200)
        Me.dgvclips.TabIndex = 480
        '
        'bwforexportclipbt
        '
        Me.bwforexportclipbt.WorkerSupportsCancellation = True
        '
        'fswalias2
        '
        Me.fswalias2.EnableRaisingEvents = True
        Me.fswalias2.IncludeSubdirectories = True
        Me.fswalias2.SynchronizingObject = Me.WatchFolder
        '
        'fsw
        '
        Me.fsw.EnableRaisingEvents = True
        Me.fsw.IncludeSubdirectories = True
        Me.fsw.SynchronizingObject = Me.WatchFolder
        '
        'fswalias1
        '
        Me.fswalias1.EnableRaisingEvents = True
        Me.fswalias1.IncludeSubdirectories = True
        Me.fswalias1.SynchronizingObject = Me.WatchFolder
        '
        'cmdplayinvlc
        '
        Me.cmdplayinvlc.Location = New System.Drawing.Point(839, 634)
        Me.cmdplayinvlc.Name = "cmdplayinvlc"
        Me.cmdplayinvlc.Size = New System.Drawing.Size(94, 23)
        Me.cmdplayinvlc.TabIndex = 807
        Me.cmdplayinvlc.Text = "Play in VLC"
        Me.cmdplayinvlc.UseVisualStyleBackColor = True
        '
        'lblplayinvlc
        '
        Me.lblplayinvlc.AutoSize = True
        Me.lblplayinvlc.Location = New System.Drawing.Point(845, 660)
        Me.lblplayinvlc.Name = "lblplayinvlc"
        Me.lblplayinvlc.Size = New System.Drawing.Size(54, 13)
        Me.lblplayinvlc.TabIndex = 807
        Me.lblplayinvlc.Text = "File Name"
        '
        'cmdshowfileinformation
        '
        Me.cmdshowfileinformation.Location = New System.Drawing.Point(939, 632)
        Me.cmdshowfileinformation.Name = "cmdshowfileinformation"
        Me.cmdshowfileinformation.Size = New System.Drawing.Size(118, 23)
        Me.cmdshowfileinformation.TabIndex = 808
        Me.cmdshowfileinformation.Text = "Show File Information"
        Me.cmdshowfileinformation.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.cmdshowfileinformation)
        Me.GroupBox1.Controls.Add(Me.UcTranscodingProfile1)
        Me.GroupBox1.Controls.Add(Me.cmdplayinvlc)
        Me.GroupBox1.Controls.Add(Me.lblplayinvlc)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1224, 951)
        Me.GroupBox1.TabIndex = 809
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " "
        '
        'cmdrecord
        '
        Me.cmdrecord.Location = New System.Drawing.Point(742, 451)
        Me.cmdrecord.Name = "cmdrecord"
        Me.cmdrecord.Size = New System.Drawing.Size(64, 48)
        Me.cmdrecord.TabIndex = 844
        Me.cmdrecord.Text = "Convert"
        Me.cmdrecord.UseVisualStyleBackColor = True
        '
        'txtrecord
        '
        Me.txtrecord.Location = New System.Drawing.Point(5, 451)
        Me.txtrecord.Multiline = True
        Me.txtrecord.Name = "txtrecord"
        Me.txtrecord.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtrecord.Size = New System.Drawing.Size(702, 48)
        Me.txtrecord.TabIndex = 843
        Me.txtrecord.Text = resources.GetString("txtrecord.Text")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 435)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(280, 13)
        Me.Label9.TabIndex = 842
        Me.Label9.Text = "FFMPEG continuous Record 10 second duration"
        '
        'cmdOutputToDecklink
        '
        Me.cmdOutputToDecklink.Location = New System.Drawing.Point(743, 538)
        Me.cmdOutputToDecklink.Name = "cmdOutputToDecklink"
        Me.cmdOutputToDecklink.Size = New System.Drawing.Size(64, 48)
        Me.cmdOutputToDecklink.TabIndex = 847
        Me.cmdOutputToDecklink.Text = "Convert"
        Me.cmdOutputToDecklink.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 522)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 13)
        Me.Label10.TabIndex = 845
        Me.Label10.Text = "FFMPEG Output To Decklink"
        '
        'txtOutputToDecklink
        '
        Me.txtOutputToDecklink.Location = New System.Drawing.Point(8, 538)
        Me.txtOutputToDecklink.Multiline = True
        Me.txtOutputToDecklink.Name = "txtOutputToDecklink"
        Me.txtOutputToDecklink.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOutputToDecklink.Size = New System.Drawing.Size(702, 48)
        Me.txtOutputToDecklink.TabIndex = 848
        Me.txtOutputToDecklink.Text = "c:/casparcg/mydata/goa/FFmpeg/bin/ffmpeg.exe -i udp://238.1.1.3:2000?pkt_size=131" &
    "6  -fflags nobuffer -tune zerolatency -f decklink -s 720x576 -pix_fmt uyvy422 -r" &
    " 25 ""DeckLink Duo (1)"""
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Field"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Value"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "File"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 600
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Field"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 150
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Value"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 300
        '
        'Column1
        '
        Me.Column1.HeaderText = "File"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 400
        '
        'UcTranscodingProfile1
        '
        Me.UcTranscodingProfile1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UcTranscodingProfile1.Location = New System.Drawing.Point(832, 44)
        Me.UcTranscodingProfile1.Name = "UcTranscodingProfile1"
        Me.UcTranscodingProfile1.Size = New System.Drawing.Size(387, 582)
        Me.UcTranscodingProfile1.TabIndex = 0
        '
        'ucMAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1229, 964)
        Me.Controls.Add(Me.GroupBox1)
        Me.HideOnClose = True
        Me.Name = "ucMAM"
        Me.Text = "MAM"
        Me.TabControl1.ResumeLayout(False)
        Me.FFMPEG.ResumeLayout(False)
        Me.FFMPEG.PerformLayout()
        Me.EbuCoreMetadata.ResumeLayout(False)
        Me.gbmetadata.ResumeLayout(False)
        Me.gbmetadata.PerformLayout()
        CType(Me.dgvmetadata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CopyandProxyProgram.ResumeLayout(False)
        Me.CopyandProxyProgram.PerformLayout()
        Me.BatchTranscoder.ResumeLayout(False)
        Me.BatchTranscoder.PerformLayout()
        CType(Me.dgvtranscoder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WatchFolder.ResumeLayout(False)
        Me.WatchFolder.PerformLayout()
        Me.gbdatatablesetting.ResumeLayout(False)
        Me.gbdatatablesetting.PerformLayout()
        CType(Me.dgvclips, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fswalias2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fsw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fswalias1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstSourceDirectory As System.Windows.Forms.ListBox
    Friend WithEvents lstDestinationDirectory As System.Windows.Forms.ListBox
    Friend WithEvents cmdCopy As System.Windows.Forms.Button
    Friend WithEvents cmdMove As System.Windows.Forms.Button
    Friend WithEvents cmdshowfilesinSourcelistbox As System.Windows.Forms.Button
    Friend WithEvents cmdshowfilesinDestinationlistbox As System.Windows.Forms.Button
    Friend WithEvents txtSourceDirectory As System.Windows.Forms.TextBox
    Friend WithEvents txtDestinationDirectory As System.Windows.Forms.TextBox
    Friend WithEvents cmdmakeproxy As System.Windows.Forms.Button
    Friend WithEvents txtDestinationDirectoryProxy As System.Windows.Forms.TextBox
    Friend WithEvents cmdshowfilesinDestinationlistboxproxy As System.Windows.Forms.Button
    Friend WithEvents lstDestinationDirectoryProxy As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdopensourcedirectory As System.Windows.Forms.Button
    Friend WithEvents cmdopendestinationdirectory As System.Windows.Forms.Button
    Friend WithEvents cmdopendestinationdirectoryproxy As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents CopyandProxyProgram As System.Windows.Forms.TabPage
    Friend WithEvents BatchTranscoder As System.Windows.Forms.TabPage
    Friend WithEvents WatchFolder As System.Windows.Forms.TabPage
    Friend WithEvents lbltrandingfilename As System.Windows.Forms.Label
    Friend WithEvents cmdselectsourcefolderfortranscoding As System.Windows.Forms.Button
    Friend WithEvents cmdselectdestinationfolderfortranscoding As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblexportclipinfobt As System.Windows.Forms.Label
    Friend WithEvents dgvtranscoder As System.Windows.Forms.DataGridView
    Friend WithEvents cmdstoptranscoding As System.Windows.Forms.Button
    Friend WithEvents txtdestinationdirectorybt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtsourcedirectorybt As System.Windows.Forms.TextBox
    Friend WithEvents cmdstarttranscoding As System.Windows.Forms.Button
    Friend WithEvents cmdfilldatgridbt As System.Windows.Forms.Button
    Friend WithEvents bwforexportclipbt As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmdSelectDirectoryForAutoCopy As System.Windows.Forms.Button
    Friend WithEvents gbdatatablesetting As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSelectDirectoryforSymlinked2Mediawatchfolder As System.Windows.Forms.Button
    Friend WithEvents cmdSelectDirectoryformainMediawatchfolder As System.Windows.Forms.Button
    Friend WithEvents cmdSelectDirectoryforSymlinked1Mediawatchfolder As System.Windows.Forms.Button
    Friend WithEvents chkwithduration As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents pbsearchprogress As System.Windows.Forms.ProgressBar
    Friend WithEvents chksymlinkedalis2 As System.Windows.Forms.CheckBox
    Friend WithEvents chksymlinkedalis1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtsymlinked2mediafolder As System.Windows.Forms.TextBox
    Friend WithEvents txtsymlinkedalis2 As System.Windows.Forms.TextBox
    Friend WithEvents txtsymlinkedalis1 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtsymlinked1mediafolder As System.Windows.Forms.TextBox
    Friend WithEvents txtmainmediafolder As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmdcreatdatatable As System.Windows.Forms.Button
    Friend WithEvents txtfilechanged As System.Windows.Forms.TextBox
    Friend WithEvents chktranscode As System.Windows.Forms.CheckBox
    Friend WithEvents txttranscodedirectory As System.Windows.Forms.TextBox
    Friend WithEvents chkmediabackup As System.Windows.Forms.CheckBox
    Friend WithEvents txtmediabackupfplder As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmdSelectDirectoryForAutoTranscode As System.Windows.Forms.Button
    Friend WithEvents cmdsearchdatatable As System.Windows.Forms.Button
    Friend WithEvents labelclips As System.Windows.Forms.Label
    Friend WithEvents txtsearchclip As System.Windows.Forms.TextBox
    Friend WithEvents dgvclips As System.Windows.Forms.DataGridView
    Friend WithEvents fswalias2 As System.IO.FileSystemWatcher
    Friend WithEvents fsw As System.IO.FileSystemWatcher
    Friend WithEvents fswalias1 As System.IO.FileSystemWatcher
    Friend WithEvents cmdstopwatching As System.Windows.Forms.Button
    Friend WithEvents cmdDeSelectAll As System.Windows.Forms.Button
    Friend WithEvents cmdSelectAll As System.Windows.Forms.Button
    Friend WithEvents cmdplayinvlc As System.Windows.Forms.Button
    Friend WithEvents lblplayinvlc As System.Windows.Forms.Label
    Friend WithEvents cmdshowfileinformation As System.Windows.Forms.Button
    Friend WithEvents FFMPEG As System.Windows.Forms.TabPage
    Friend WithEvents txtsequencetovideomam As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmdsequencetovideomam As System.Windows.Forms.Button
    Friend WithEvents cmdvideotosequencemam As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmdaddingaudiotracktovideomam As System.Windows.Forms.Button
    Friend WithEvents txtaddingaudiotracktovideomam As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmdaudioinsinglestream As System.Windows.Forms.Button
    Friend WithEvents txtaudioinsinglestream As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmdDeSelectAllfromcurrentposition As System.Windows.Forms.Button
    Friend WithEvents txtfilenameforimage As System.Windows.Forms.TextBox
    Friend WithEvents cmddestinationfolderforalphaimage As System.Windows.Forms.Button
    Friend WithEvents cmdvideoforimage As System.Windows.Forms.Button
    Friend WithEvents cmbcodecforalpha As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtsourcefileforalphavideo As System.Windows.Forms.TextBox
    Friend WithEvents txtdestinationfolderforalphaimage As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtsourcefileforalphavideosd As System.Windows.Forms.TextBox
    Friend WithEvents txtdestinationfolderforhd As System.Windows.Forms.TextBox
    Friend WithEvents txtfilenameforhd As System.Windows.Forms.TextBox
    Friend WithEvents cmddestinationfolderforhd As System.Windows.Forms.Button
    Friend WithEvents cmdvideosd As System.Windows.Forms.Button
    Friend WithEvents cmdvideohd As System.Windows.Forms.Button
    Friend WithEvents cmdFfmbcTargetTranscoding As System.Windows.Forms.Button
    Friend WithEvents txtFfmbcTargetTranscoding As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdsearchdatagridbt As System.Windows.Forms.Button
    Friend WithEvents txtsearchdatagridbt As System.Windows.Forms.TextBox
    Friend WithEvents EbuCoreMetadata As System.Windows.Forms.TabPage
    Friend WithEvents gbmetadata As System.Windows.Forms.GroupBox
    Friend WithEvents cmbebu2mxfoption As System.Windows.Forms.ComboBox
    Friend WithEvents cmddefaultmetadata As System.Windows.Forms.Button
    Friend WithEvents cmdebu2mxf As System.Windows.Forms.Button
    Friend WithEvents cmbanalyzeroption As System.Windows.Forms.ComboBox
    Friend WithEvents lblfilenamemetadata As System.Windows.Forms.Label
    Friend WithEvents cmdanalyse As System.Windows.Forms.Button
    Friend WithEvents Label238 As System.Windows.Forms.Label
    Friend WithEvents cmdclearfieldmetadata As System.Windows.Forms.Button
    Friend WithEvents cmdwritemetadata As System.Windows.Forms.Button
    Friend WithEvents cmdreadmetadata As System.Windows.Forms.Button
    Friend WithEvents dgvmetadata As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents UcTranscodingProfile1 As ucTranscodingProfile
    Friend WithEvents txtffmpegoutput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtffplay As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdFFMpeg As Button
    Friend WithEvents txtFFMpeg As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewCheckBoxColumn
    Friend WithEvents cmdrecord As Button
    Friend WithEvents txtrecord As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmdOutputToDecklink As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtOutputToDecklink As TextBox
End Class
