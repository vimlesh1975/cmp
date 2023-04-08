<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucVisionMixer
    'Inherits System.Windows.Forms.UserControl
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucVisionMixer))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbvisionmixer = New System.Windows.Forms.GroupBox()
        Me.cmdInitialiseNewNDISources = New System.Windows.Forms.Button()
        Me.cmdsource9pvw = New System.Windows.Forms.Button()
        Me.cmdsource9 = New System.Windows.Forms.Button()
        Me.cmbNDI = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdStopallFlash = New System.Windows.Forms.Button()
        Me.cmdPlayallflash = New System.Windows.Forms.Button()
        Me.cmdgetchannelinfo = New System.Windows.Forms.Button()
        Me.dgvchannelinfo = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmStop = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cmdStop = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cmdWipe = New System.Windows.Forms.Button()
        Me.lblpreviewSource = New System.Windows.Forms.Label()
        Me.lblPGMSource = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdMix = New System.Windows.Forms.Button()
        Me.cmdRestartCasparwithConfig = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.cmbdirection = New System.Windows.Forms.ComboBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.cmbtweentype = New System.Windows.Forms.ComboBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.ntransitionduration = New System.Windows.Forms.NumericUpDown()
        Me.cmbtransition = New System.Windows.Forms.ComboBox()
        Me.pnlrecording3 = New System.Windows.Forms.Panel()
        Me.cmbcasparcgwindowtitlerecording3 = New System.Windows.Forms.ComboBox()
        Me.cmdoutcasparcgwindowVM3 = New System.Windows.Forms.Button()
        Me.cmdshowcasparcgwindowrecording3 = New System.Windows.Forms.Button()
        Me.InitialiseActual = New System.Windows.Forms.Button()
        Me.cmdInitialiseDummy = New System.Windows.Forms.Button()
        Me.pnlrecording = New System.Windows.Forms.Panel()
        Me.cmbcasparcgwindowtitlerecording = New System.Windows.Forms.ComboBox()
        Me.cmdoutcasparcgwindowVM = New System.Windows.Forms.Button()
        Me.cmdshowcasparcgwindowrecording = New System.Windows.Forms.Button()
        Me.cmdCut = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdsource8pvw = New System.Windows.Forms.Button()
        Me.cmdsource7pvw = New System.Windows.Forms.Button()
        Me.cmdsource6pvw = New System.Windows.Forms.Button()
        Me.cmdsource5pvw = New System.Windows.Forms.Button()
        Me.cmdsource4pvw = New System.Windows.Forms.Button()
        Me.cmdsource3pvw = New System.Windows.Forms.Button()
        Me.cmdsource2pvw = New System.Windows.Forms.Button()
        Me.cmdsource1pvw = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nchromaspill = New System.Windows.Forms.NumericUpDown()
        Me.Label230 = New System.Windows.Forms.Label()
        Me.txtplaycolorbar = New System.Windows.Forms.TextBox()
        Me.cmdplaycolorbar = New System.Windows.Forms.Button()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.nchromaspread = New System.Windows.Forms.NumericUpDown()
        Me.nchromathresholdcenter = New System.Windows.Forms.NumericUpDown()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.txtchromakey = New System.Windows.Forms.TextBox()
        Me.cmdplaychroma = New System.Windows.Forms.Button()
        Me.cmbchromacolor = New System.Windows.Forms.ComboBox()
        Me.txtlayerproducer1 = New System.Windows.Forms.TextBox()
        Me.cmdplayonfirschannel = New System.Windows.Forms.Button()
        Me.cmbsource8 = New System.Windows.Forms.ComboBox()
        Me.cmbsource7 = New System.Windows.Forms.ComboBox()
        Me.cmbsource6 = New System.Windows.Forms.ComboBox()
        Me.cmbsource5 = New System.Windows.Forms.ComboBox()
        Me.cmbsource4 = New System.Windows.Forms.ComboBox()
        Me.cmbsource3 = New System.Windows.Forms.ComboBox()
        Me.cmbsource2 = New System.Windows.Forms.ComboBox()
        Me.cmbsource1 = New System.Windows.Forms.ComboBox()
        Me.cmdsource8 = New System.Windows.Forms.Button()
        Me.cmdsource7 = New System.Windows.Forms.Button()
        Me.cmdsource6 = New System.Windows.Forms.Button()
        Me.cmdsource5 = New System.Windows.Forms.Button()
        Me.gbcolorforvisionmixer = New System.Windows.Forms.GroupBox()
        Me.rdoColorPVW = New System.Windows.Forms.RadioButton()
        Me.rdoColorPGM = New System.Windows.Forms.RadioButton()
        Me.GEyeDropper4 = New caspar_media_playback.ucEyeDropper()
        Me.GEyeDropper3 = New caspar_media_playback.ucEyeDropper()
        Me.GEyeDropper2 = New caspar_media_playback.ucEyeDropper()
        Me.GEyeDropper1 = New caspar_media_playback.ucEyeDropper()
        Me.c4 = New System.Windows.Forms.CheckBox()
        Me.c3 = New System.Windows.Forms.CheckBox()
        Me.c2 = New System.Windows.Forms.CheckBox()
        Me.c1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdstripcolorvisionmixer4 = New System.Windows.Forms.Panel()
        Me.cmdstripcolorvisionmixer3 = New System.Windows.Forms.Panel()
        Me.cmdstripcolorvisionmixer2 = New System.Windows.Forms.Panel()
        Me.cmdstripcolorvisionmixer1 = New System.Windows.Forms.Panel()
        Me.cmdPlayColor = New System.Windows.Forms.Button()
        Me.cmdgreen = New System.Windows.Forms.Button()
        Me.cmdblack = New System.Windows.Forms.Button()
        Me.cmdred = New System.Windows.Forms.Button()
        Me.cmdblue = New System.Windows.Forms.Button()
        Me.cmdsource4 = New System.Windows.Forms.Button()
        Me.cmdsource3 = New System.Windows.Forms.Button()
        Me.cmdsource2 = New System.Windows.Forms.Button()
        Me.cmdsource1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbvisionmixer.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvchannelinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ntransitionduration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nchromaspill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nchromaspread, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nchromathresholdcenter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbcolorforvisionmixer.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbvisionmixer
        '
        Me.gbvisionmixer.BackColor = System.Drawing.Color.LightGreen
        Me.gbvisionmixer.Controls.Add(Me.cmdInitialiseNewNDISources)
        Me.gbvisionmixer.Controls.Add(Me.cmdsource9pvw)
        Me.gbvisionmixer.Controls.Add(Me.cmdsource9)
        Me.gbvisionmixer.Controls.Add(Me.cmbNDI)
        Me.gbvisionmixer.Controls.Add(Me.GroupBox3)
        Me.gbvisionmixer.Controls.Add(Me.cmdWipe)
        Me.gbvisionmixer.Controls.Add(Me.lblpreviewSource)
        Me.gbvisionmixer.Controls.Add(Me.lblPGMSource)
        Me.gbvisionmixer.Controls.Add(Me.Label10)
        Me.gbvisionmixer.Controls.Add(Me.Label11)
        Me.gbvisionmixer.Controls.Add(Me.cmdMix)
        Me.gbvisionmixer.Controls.Add(Me.cmdRestartCasparwithConfig)
        Me.gbvisionmixer.Controls.Add(Me.Label9)
        Me.gbvisionmixer.Controls.Add(Me.Label8)
        Me.gbvisionmixer.Controls.Add(Me.Label7)
        Me.gbvisionmixer.Controls.Add(Me.GroupBox2)
        Me.gbvisionmixer.Controls.Add(Me.pnlrecording3)
        Me.gbvisionmixer.Controls.Add(Me.cmbcasparcgwindowtitlerecording3)
        Me.gbvisionmixer.Controls.Add(Me.cmdoutcasparcgwindowVM3)
        Me.gbvisionmixer.Controls.Add(Me.cmdshowcasparcgwindowrecording3)
        Me.gbvisionmixer.Controls.Add(Me.InitialiseActual)
        Me.gbvisionmixer.Controls.Add(Me.cmdInitialiseDummy)
        Me.gbvisionmixer.Controls.Add(Me.pnlrecording)
        Me.gbvisionmixer.Controls.Add(Me.cmbcasparcgwindowtitlerecording)
        Me.gbvisionmixer.Controls.Add(Me.cmdoutcasparcgwindowVM)
        Me.gbvisionmixer.Controls.Add(Me.cmdshowcasparcgwindowrecording)
        Me.gbvisionmixer.Controls.Add(Me.cmdCut)
        Me.gbvisionmixer.Controls.Add(Me.Label6)
        Me.gbvisionmixer.Controls.Add(Me.Label5)
        Me.gbvisionmixer.Controls.Add(Me.cmdsource8pvw)
        Me.gbvisionmixer.Controls.Add(Me.cmdsource7pvw)
        Me.gbvisionmixer.Controls.Add(Me.cmdsource6pvw)
        Me.gbvisionmixer.Controls.Add(Me.cmdsource5pvw)
        Me.gbvisionmixer.Controls.Add(Me.cmdsource4pvw)
        Me.gbvisionmixer.Controls.Add(Me.cmdsource3pvw)
        Me.gbvisionmixer.Controls.Add(Me.cmdsource2pvw)
        Me.gbvisionmixer.Controls.Add(Me.cmdsource1pvw)
        Me.gbvisionmixer.Controls.Add(Me.GroupBox1)
        Me.gbvisionmixer.Controls.Add(Me.cmbsource8)
        Me.gbvisionmixer.Controls.Add(Me.cmbsource7)
        Me.gbvisionmixer.Controls.Add(Me.cmbsource6)
        Me.gbvisionmixer.Controls.Add(Me.cmbsource5)
        Me.gbvisionmixer.Controls.Add(Me.cmbsource4)
        Me.gbvisionmixer.Controls.Add(Me.cmbsource3)
        Me.gbvisionmixer.Controls.Add(Me.cmbsource2)
        Me.gbvisionmixer.Controls.Add(Me.cmbsource1)
        Me.gbvisionmixer.Controls.Add(Me.cmdsource8)
        Me.gbvisionmixer.Controls.Add(Me.cmdsource7)
        Me.gbvisionmixer.Controls.Add(Me.cmdsource6)
        Me.gbvisionmixer.Controls.Add(Me.cmdsource5)
        Me.gbvisionmixer.Controls.Add(Me.gbcolorforvisionmixer)
        Me.gbvisionmixer.Controls.Add(Me.cmdsource4)
        Me.gbvisionmixer.Controls.Add(Me.cmdsource3)
        Me.gbvisionmixer.Controls.Add(Me.cmdsource2)
        Me.gbvisionmixer.Controls.Add(Me.cmdsource1)
        Me.gbvisionmixer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbvisionmixer.Location = New System.Drawing.Point(2, 2)
        Me.gbvisionmixer.Name = "gbvisionmixer"
        Me.gbvisionmixer.Size = New System.Drawing.Size(1194, 610)
        Me.gbvisionmixer.TabIndex = 583
        Me.gbvisionmixer.TabStop = False
        Me.gbvisionmixer.Text = " "
        '
        'cmdInitialiseNewNDISources
        '
        Me.cmdInitialiseNewNDISources.Location = New System.Drawing.Point(707, 409)
        Me.cmdInitialiseNewNDISources.Name = "cmdInitialiseNewNDISources"
        Me.cmdInitialiseNewNDISources.Size = New System.Drawing.Size(140, 23)
        Me.cmdInitialiseNewNDISources.TabIndex = 1228
        Me.cmdInitialiseNewNDISources.Text = "Initialise new NDI Source"
        Me.cmdInitialiseNewNDISources.UseVisualStyleBackColor = True
        '
        'cmdsource9pvw
        '
        Me.cmdsource9pvw.BackgroundImage = CType(resources.GetObject("cmdsource9pvw.BackgroundImage"), System.Drawing.Image)
        Me.cmdsource9pvw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsource9pvw.Location = New System.Drawing.Point(686, 347)
        Me.cmdsource9pvw.Name = "cmdsource9pvw"
        Me.cmdsource9pvw.Size = New System.Drawing.Size(41, 35)
        Me.cmdsource9pvw.TabIndex = 1227
        Me.cmdsource9pvw.UseVisualStyleBackColor = True
        '
        'cmdsource9
        '
        Me.cmdsource9.BackgroundImage = CType(resources.GetObject("cmdsource9.BackgroundImage"), System.Drawing.Image)
        Me.cmdsource9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsource9.Location = New System.Drawing.Point(686, 313)
        Me.cmdsource9.Name = "cmdsource9"
        Me.cmdsource9.Size = New System.Drawing.Size(41, 35)
        Me.cmdsource9.TabIndex = 1226
        Me.cmdsource9.UseVisualStyleBackColor = True
        '
        'cmbNDI
        '
        Me.cmbNDI.FormattingEnabled = True
        Me.cmbNDI.Location = New System.Drawing.Point(586, 382)
        Me.cmbNDI.Name = "cmbNDI"
        Me.cmbNDI.Size = New System.Drawing.Size(282, 21)
        Me.cmbNDI.TabIndex = 1225
        Me.cmbNDI.Text = "NDI"
        Me.ToolTip1.SetToolTip(Me.cmbNDI, "Click for Source Listing")
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox3.Controls.Add(Me.cmdStopallFlash)
        Me.GroupBox3.Controls.Add(Me.cmdPlayallflash)
        Me.GroupBox3.Controls.Add(Me.cmdgetchannelinfo)
        Me.GroupBox3.Controls.Add(Me.dgvchannelinfo)
        Me.GroupBox3.Location = New System.Drawing.Point(481, 143)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(176, 165)
        Me.GroupBox3.TabIndex = 781
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Graphics Key"
        '
        'cmdStopallFlash
        '
        Me.cmdStopallFlash.Location = New System.Drawing.Point(136, 79)
        Me.cmdStopallFlash.Name = "cmdStopallFlash"
        Me.cmdStopallFlash.Size = New System.Drawing.Size(37, 37)
        Me.cmdStopallFlash.TabIndex = 780
        Me.cmdStopallFlash.Text = "Stop All"
        Me.cmdStopallFlash.UseVisualStyleBackColor = True
        '
        'cmdPlayallflash
        '
        Me.cmdPlayallflash.Location = New System.Drawing.Point(136, 35)
        Me.cmdPlayallflash.Name = "cmdPlayallflash"
        Me.cmdPlayallflash.Size = New System.Drawing.Size(37, 38)
        Me.cmdPlayallflash.TabIndex = 779
        Me.cmdPlayallflash.Text = "Play All"
        Me.cmdPlayallflash.UseVisualStyleBackColor = True
        '
        'cmdgetchannelinfo
        '
        Me.cmdgetchannelinfo.Location = New System.Drawing.Point(2, 12)
        Me.cmdgetchannelinfo.Name = "cmdgetchannelinfo"
        Me.cmdgetchannelinfo.Size = New System.Drawing.Size(161, 23)
        Me.cmdgetchannelinfo.TabIndex = 778
        Me.cmdgetchannelinfo.Text = "Flash in Channel 2 (Preview)"
        Me.cmdgetchannelinfo.UseVisualStyleBackColor = True
        '
        'dgvchannelinfo
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvchannelinfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvchannelinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvchannelinfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.clmStop, Me.cmdStop})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvchannelinfo.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvchannelinfo.Location = New System.Drawing.Point(2, 36)
        Me.dgvchannelinfo.Name = "dgvchannelinfo"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvchannelinfo.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvchannelinfo.RowHeadersVisible = False
        Me.dgvchannelinfo.Size = New System.Drawing.Size(133, 121)
        Me.dgvchannelinfo.TabIndex = 777
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Layer"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn10.Width = 40
        '
        'clmStop
        '
        Me.clmStop.HeaderText = "Play"
        Me.clmStop.Name = "clmStop"
        Me.clmStop.Text = "Stop"
        Me.clmStop.Width = 40
        '
        'cmdStop
        '
        Me.cmdStop.HeaderText = "Stop"
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cmdStop.Width = 40
        '
        'cmdWipe
        '
        Me.cmdWipe.Location = New System.Drawing.Point(609, 110)
        Me.cmdWipe.Name = "cmdWipe"
        Me.cmdWipe.Size = New System.Drawing.Size(48, 30)
        Me.cmdWipe.TabIndex = 774
        Me.cmdWipe.Text = "WIPE"
        Me.cmdWipe.UseVisualStyleBackColor = True
        '
        'lblpreviewSource
        '
        Me.lblpreviewSource.AutoSize = True
        Me.lblpreviewSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpreviewSource.Location = New System.Drawing.Point(75, 287)
        Me.lblpreviewSource.Name = "lblpreviewSource"
        Me.lblpreviewSource.Size = New System.Drawing.Size(48, 20)
        Me.lblpreviewSource.TabIndex = 773
        Me.lblpreviewSource.Text = "PVW"
        '
        'lblPGMSource
        '
        Me.lblPGMSource.AutoSize = True
        Me.lblPGMSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPGMSource.Location = New System.Drawing.Point(75, 260)
        Me.lblPGMSource.Name = "lblPGMSource"
        Me.lblPGMSource.Size = New System.Drawing.Size(48, 20)
        Me.lblPGMSource.TabIndex = 772
        Me.lblPGMSource.Text = "PGM"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 287)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 20)
        Me.Label10.TabIndex = 771
        Me.Label10.Text = "PVW"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 260)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 20)
        Me.Label11.TabIndex = 770
        Me.Label11.Text = "PGM"
        '
        'cmdMix
        '
        Me.cmdMix.Location = New System.Drawing.Point(609, 77)
        Me.cmdMix.Name = "cmdMix"
        Me.cmdMix.Size = New System.Drawing.Size(48, 30)
        Me.cmdMix.TabIndex = 769
        Me.cmdMix.Text = "MIX"
        Me.cmdMix.UseVisualStyleBackColor = True
        '
        'cmdRestartCasparwithConfig
        '
        Me.cmdRestartCasparwithConfig.Location = New System.Drawing.Point(484, 41)
        Me.cmdRestartCasparwithConfig.Name = "cmdRestartCasparwithConfig"
        Me.cmdRestartCasparwithConfig.Size = New System.Drawing.Size(93, 35)
        Me.cmdRestartCasparwithConfig.TabIndex = 768
        Me.cmdRestartCasparwithConfig.Text = "Restart Server with 3 Channels"
        Me.cmdRestartCasparwithConfig.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(321, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 20)
        Me.Label9.TabIndex = 767
        Me.Label9.Text = "Preview"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 20)
        Me.Label8.TabIndex = 766
        Me.Label8.Text = "Source Grid View"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(872, 386)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 20)
        Me.Label7.TabIndex = 765
        Me.Label7.Text = "Source"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox2.Controls.Add(Me.Label62)
        Me.GroupBox2.Controls.Add(Me.cmbdirection)
        Me.GroupBox2.Controls.Add(Me.Label61)
        Me.GroupBox2.Controls.Add(Me.cmbtweentype)
        Me.GroupBox2.Controls.Add(Me.Label60)
        Me.GroupBox2.Controls.Add(Me.Label59)
        Me.GroupBox2.Controls.Add(Me.ntransitionduration)
        Me.GroupBox2.Controls.Add(Me.cmbtransition)
        Me.GroupBox2.Location = New System.Drawing.Point(444, 409)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(211, 120)
        Me.GroupBox2.TabIndex = 764
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transition"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(48, 93)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(49, 13)
        Me.Label62.TabIndex = 594
        Me.Label62.Text = "Direction"
        '
        'cmbdirection
        '
        Me.cmbdirection.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbdirection", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbdirection.FormattingEnabled = True
        Me.cmbdirection.Items.AddRange(New Object() {"LEFT", "RIGHT"})
        Me.cmbdirection.Location = New System.Drawing.Point(103, 90)
        Me.cmbdirection.Name = "cmbdirection"
        Me.cmbdirection.Size = New System.Drawing.Size(103, 21)
        Me.cmbdirection.TabIndex = 593
        Me.cmbdirection.Text = Global.caspar_media_playback.My.MySettings.Default.cmbdirection
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(58, 68)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(40, 13)
        Me.Label61.TabIndex = 592
        Me.Label61.Text = "Tween"
        '
        'cmbtweentype
        '
        Me.cmbtweentype.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbtweentype", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbtweentype.FormattingEnabled = True
        Me.cmbtweentype.Items.AddRange(New Object() {"linear", "easenone", "easeinquad", "easeoutquad", "easeinoutquad", "easeoutinquad", "easeincubic", "easeoutcubic", "easeinoutcubic", "easeoutincubic", "easeinquart", "easeoutquart", "easeinoutquart", "easeoutinquart", "easeinquint", "easeoutquint", "easeinoutquint", "easeoutinquint", "easeinsine", "easeoutsine", "easeinoutsine", "easeoutinsine", "easeinexpo", "easeoutexpo", "easeinoutexpo", "easeoutinexpo", "easeincirc", "easeoutcirc", "easeinoutcirc", "easeoutincirc", "easeinelastic", "easeoutelastic", "easeinoutelastic", "easeoutinelastic", "easeinback", "easeoutback", "easeinoutback", "easeoutintback", "easeoutbounce", "easeinbounce", "easeinoutbounce", "easeoutinbounce"})
        Me.cmbtweentype.Location = New System.Drawing.Point(104, 62)
        Me.cmbtweentype.Name = "cmbtweentype"
        Me.cmbtweentype.Size = New System.Drawing.Size(103, 21)
        Me.cmbtweentype.TabIndex = 591
        Me.cmbtweentype.Text = Global.caspar_media_playback.My.MySettings.Default.cmbtweentype
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(5, 39)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(96, 13)
        Me.Label60.TabIndex = 590
        Me.Label60.Text = "Transition Duration"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(21, 18)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(80, 13)
        Me.Label59.TabIndex = 589
        Me.Label59.Text = "Transition Type"
        '
        'ntransitionduration
        '
        Me.ntransitionduration.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.caspar_media_playback.My.MySettings.Default, "ntransitionduration", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ntransitionduration.Location = New System.Drawing.Point(103, 40)
        Me.ntransitionduration.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.ntransitionduration.Name = "ntransitionduration"
        Me.ntransitionduration.Size = New System.Drawing.Size(38, 20)
        Me.ntransitionduration.TabIndex = 583
        Me.ntransitionduration.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'cmbtransition
        '
        Me.cmbtransition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbtransition", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbtransition.FormattingEnabled = True
        Me.cmbtransition.Items.AddRange(New Object() {"CUT", "MIX", "PUSH", "WIPE", "SLIDE"})
        Me.cmbtransition.Location = New System.Drawing.Point(103, 14)
        Me.cmbtransition.Name = "cmbtransition"
        Me.cmbtransition.Size = New System.Drawing.Size(103, 21)
        Me.cmbtransition.TabIndex = 583
        Me.cmbtransition.Text = Global.caspar_media_playback.My.MySettings.Default.cmbtransition
        '
        'pnlrecording3
        '
        Me.pnlrecording3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlrecording3.Location = New System.Drawing.Point(4, 65)
        Me.pnlrecording3.Name = "pnlrecording3"
        Me.pnlrecording3.Size = New System.Drawing.Size(235, 176)
        Me.pnlrecording3.TabIndex = 760
        '
        'cmbcasparcgwindowtitlerecording3
        '
        Me.cmbcasparcgwindowtitlerecording3.FormattingEnabled = True
        Me.cmbcasparcgwindowtitlerecording3.Items.AddRange(New Object() {"Screen consumer [1|PAL]", "Screen consumer [2|PAL]", "Screen consumer [3|PAL]", "Screen consumer [4|PAL]", "Screen consumer [1|NTSC]", "Screen consumer [1|1080i5000]", "Screen consumer [2|1080i5000]", "Screen consumer [3|1080i5000]", "Screen consumer [4|1080i5000]", "Screen consumer [1|1080i5994]", "Screen consumer [1|1080i6000]", "Screen consumer [1|1080p2398]", "Screen consumer [1|1080p2400]", "Screen consumer [1|1080p2500]", "Screen consumer [1|1080p2997]", "Screen consumer [1|1080p3000]", "Screen consumer [1|1080p5000]", "Screen consumer [1|1080p5994]", "Screen consumer [1|1080p6000]", "Screen consumer [1|1556p2398]", "Screen consumer [1|1556p2400]", "Screen consumer [1|1556p2500]", "Screen consumer [1|2160p2398]", "Screen consumer [1|2160p2400]", "Screen consumer [1|2160p2500]", "Screen consumer [1| 2160p2997]", "Screen consumer [1|2160p3000]", "Screen consumer [1|576p2500]", "Screen consumer [1|720p2398]", "Screen consumer [1|720p2400]", "Screen consumer [1|720p2500]", "Screen consumer [1|720p2997]", "Screen consumer [1|720p3000]", "Screen consumer [1|720p5000]", "Screen consumer [1|720p5994]", "Screen consumer [1|720p6000]"})
        Me.cmbcasparcgwindowtitlerecording3.Location = New System.Drawing.Point(6, 41)
        Me.cmbcasparcgwindowtitlerecording3.Name = "cmbcasparcgwindowtitlerecording3"
        Me.cmbcasparcgwindowtitlerecording3.Size = New System.Drawing.Size(150, 21)
        Me.cmbcasparcgwindowtitlerecording3.TabIndex = 763
        Me.cmbcasparcgwindowtitlerecording3.Text = "Screen consumer [3|PAL]"
        '
        'cmdoutcasparcgwindowVM3
        '
        Me.cmdoutcasparcgwindowVM3.Location = New System.Drawing.Point(191, 38)
        Me.cmdoutcasparcgwindowVM3.Name = "cmdoutcasparcgwindowVM3"
        Me.cmdoutcasparcgwindowVM3.Size = New System.Drawing.Size(43, 23)
        Me.cmdoutcasparcgwindowVM3.TabIndex = 762
        Me.cmdoutcasparcgwindowVM3.Text = "OUT"
        Me.cmdoutcasparcgwindowVM3.UseVisualStyleBackColor = True
        '
        'cmdshowcasparcgwindowrecording3
        '
        Me.cmdshowcasparcgwindowrecording3.Location = New System.Drawing.Point(158, 38)
        Me.cmdshowcasparcgwindowrecording3.Name = "cmdshowcasparcgwindowrecording3"
        Me.cmdshowcasparcgwindowrecording3.Size = New System.Drawing.Size(32, 23)
        Me.cmdshowcasparcgwindowrecording3.TabIndex = 761
        Me.cmdshowcasparcgwindowrecording3.Text = "IN"
        Me.cmdshowcasparcgwindowrecording3.UseVisualStyleBackColor = True
        '
        'InitialiseActual
        '
        Me.InitialiseActual.Location = New System.Drawing.Point(483, 107)
        Me.InitialiseActual.Name = "InitialiseActual"
        Me.InitialiseActual.Size = New System.Drawing.Size(93, 30)
        Me.InitialiseActual.TabIndex = 759
        Me.InitialiseActual.Text = "Initialise Actual"
        Me.InitialiseActual.UseVisualStyleBackColor = True
        '
        'cmdInitialiseDummy
        '
        Me.cmdInitialiseDummy.Location = New System.Drawing.Point(484, 76)
        Me.cmdInitialiseDummy.Name = "cmdInitialiseDummy"
        Me.cmdInitialiseDummy.Size = New System.Drawing.Size(93, 30)
        Me.cmdInitialiseDummy.TabIndex = 758
        Me.cmdInitialiseDummy.Text = "Initialise Dummy"
        Me.cmdInitialiseDummy.UseVisualStyleBackColor = True
        '
        'pnlrecording
        '
        Me.pnlrecording.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlrecording.Location = New System.Drawing.Point(243, 66)
        Me.pnlrecording.Name = "pnlrecording"
        Me.pnlrecording.Size = New System.Drawing.Size(235, 176)
        Me.pnlrecording.TabIndex = 754
        '
        'cmbcasparcgwindowtitlerecording
        '
        Me.cmbcasparcgwindowtitlerecording.FormattingEnabled = True
        Me.cmbcasparcgwindowtitlerecording.Items.AddRange(New Object() {"Screen consumer [1|PAL]", "Screen consumer [2|PAL]", "Screen consumer [3|PAL]", "Screen consumer [4|PAL]", "Screen consumer [1|NTSC]", "Screen consumer [1|1080i5000]", "Screen consumer [2|1080i5000]", "Screen consumer [3|1080i5000]", "Screen consumer [4|1080i5000]", "Screen consumer [1|1080i5994]", "Screen consumer [1|1080i6000]", "Screen consumer [1|1080p2398]", "Screen consumer [1|1080p2400]", "Screen consumer [1|1080p2500]", "Screen consumer [1|1080p2997]", "Screen consumer [1|1080p3000]", "Screen consumer [1|1080p5000]", "Screen consumer [1|1080p5994]", "Screen consumer [1|1080p6000]", "Screen consumer [1|1556p2398]", "Screen consumer [1|1556p2400]", "Screen consumer [1|1556p2500]", "Screen consumer [1|2160p2398]", "Screen consumer [1|2160p2400]", "Screen consumer [1|2160p2500]", "Screen consumer [1| 2160p2997]", "Screen consumer [1|2160p3000]", "Screen consumer [1|576p2500]", "Screen consumer [1|720p2398]", "Screen consumer [1|720p2400]", "Screen consumer [1|720p2500]", "Screen consumer [1|720p2997]", "Screen consumer [1|720p3000]", "Screen consumer [1|720p5000]", "Screen consumer [1|720p5994]", "Screen consumer [1|720p6000]"})
        Me.cmbcasparcgwindowtitlerecording.Location = New System.Drawing.Point(244, 41)
        Me.cmbcasparcgwindowtitlerecording.Name = "cmbcasparcgwindowtitlerecording"
        Me.cmbcasparcgwindowtitlerecording.Size = New System.Drawing.Size(150, 21)
        Me.cmbcasparcgwindowtitlerecording.TabIndex = 757
        Me.cmbcasparcgwindowtitlerecording.Text = "Screen consumer [2|PAL]"
        '
        'cmdoutcasparcgwindowVM
        '
        Me.cmdoutcasparcgwindowVM.Location = New System.Drawing.Point(440, 39)
        Me.cmdoutcasparcgwindowVM.Name = "cmdoutcasparcgwindowVM"
        Me.cmdoutcasparcgwindowVM.Size = New System.Drawing.Size(43, 23)
        Me.cmdoutcasparcgwindowVM.TabIndex = 756
        Me.cmdoutcasparcgwindowVM.Text = "OUT"
        Me.cmdoutcasparcgwindowVM.UseVisualStyleBackColor = True
        '
        'cmdshowcasparcgwindowrecording
        '
        Me.cmdshowcasparcgwindowrecording.Location = New System.Drawing.Point(400, 39)
        Me.cmdshowcasparcgwindowrecording.Name = "cmdshowcasparcgwindowrecording"
        Me.cmdshowcasparcgwindowrecording.Size = New System.Drawing.Size(32, 23)
        Me.cmdshowcasparcgwindowrecording.TabIndex = 755
        Me.cmdshowcasparcgwindowrecording.Text = "IN"
        Me.cmdshowcasparcgwindowrecording.UseVisualStyleBackColor = True
        '
        'cmdCut
        '
        Me.cmdCut.Location = New System.Drawing.Point(609, 46)
        Me.cmdCut.Name = "cmdCut"
        Me.cmdCut.Size = New System.Drawing.Size(48, 30)
        Me.cmdCut.TabIndex = 751
        Me.cmdCut.Text = "CUT"
        Me.cmdCut.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(872, 359)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 750
        Me.Label6.Text = "PVW"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(872, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 749
        Me.Label5.Text = "PGM"
        '
        'cmdsource8pvw
        '
        Me.cmdsource8pvw.BackgroundImage = CType(resources.GetObject("cmdsource8pvw.BackgroundImage"), System.Drawing.Image)
        Me.cmdsource8pvw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsource8pvw.Location = New System.Drawing.Point(521, 345)
        Me.cmdsource8pvw.Name = "cmdsource8pvw"
        Me.cmdsource8pvw.Size = New System.Drawing.Size(41, 35)
        Me.cmdsource8pvw.TabIndex = 748
        Me.cmdsource8pvw.UseVisualStyleBackColor = True
        '
        'cmdsource7pvw
        '
        Me.cmdsource7pvw.BackgroundImage = CType(resources.GetObject("cmdsource7pvw.BackgroundImage"), System.Drawing.Image)
        Me.cmdsource7pvw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsource7pvw.Location = New System.Drawing.Point(456, 345)
        Me.cmdsource7pvw.Name = "cmdsource7pvw"
        Me.cmdsource7pvw.Size = New System.Drawing.Size(41, 35)
        Me.cmdsource7pvw.TabIndex = 747
        Me.cmdsource7pvw.UseVisualStyleBackColor = True
        '
        'cmdsource6pvw
        '
        Me.cmdsource6pvw.BackgroundImage = CType(resources.GetObject("cmdsource6pvw.BackgroundImage"), System.Drawing.Image)
        Me.cmdsource6pvw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsource6pvw.Location = New System.Drawing.Point(383, 345)
        Me.cmdsource6pvw.Name = "cmdsource6pvw"
        Me.cmdsource6pvw.Size = New System.Drawing.Size(41, 35)
        Me.cmdsource6pvw.TabIndex = 746
        Me.cmdsource6pvw.UseVisualStyleBackColor = True
        '
        'cmdsource5pvw
        '
        Me.cmdsource5pvw.BackgroundImage = CType(resources.GetObject("cmdsource5pvw.BackgroundImage"), System.Drawing.Image)
        Me.cmdsource5pvw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsource5pvw.Location = New System.Drawing.Point(311, 345)
        Me.cmdsource5pvw.Name = "cmdsource5pvw"
        Me.cmdsource5pvw.Size = New System.Drawing.Size(41, 35)
        Me.cmdsource5pvw.TabIndex = 745
        Me.cmdsource5pvw.UseVisualStyleBackColor = True
        '
        'cmdsource4pvw
        '
        Me.cmdsource4pvw.BackgroundImage = CType(resources.GetObject("cmdsource4pvw.BackgroundImage"), System.Drawing.Image)
        Me.cmdsource4pvw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsource4pvw.Location = New System.Drawing.Point(247, 345)
        Me.cmdsource4pvw.Name = "cmdsource4pvw"
        Me.cmdsource4pvw.Size = New System.Drawing.Size(41, 35)
        Me.cmdsource4pvw.TabIndex = 744
        Me.cmdsource4pvw.UseVisualStyleBackColor = True
        '
        'cmdsource3pvw
        '
        Me.cmdsource3pvw.BackgroundImage = CType(resources.GetObject("cmdsource3pvw.BackgroundImage"), System.Drawing.Image)
        Me.cmdsource3pvw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsource3pvw.Location = New System.Drawing.Point(181, 345)
        Me.cmdsource3pvw.Name = "cmdsource3pvw"
        Me.cmdsource3pvw.Size = New System.Drawing.Size(41, 35)
        Me.cmdsource3pvw.TabIndex = 743
        Me.cmdsource3pvw.UseVisualStyleBackColor = True
        '
        'cmdsource2pvw
        '
        Me.cmdsource2pvw.BackgroundImage = CType(resources.GetObject("cmdsource2pvw.BackgroundImage"), System.Drawing.Image)
        Me.cmdsource2pvw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsource2pvw.Location = New System.Drawing.Point(114, 345)
        Me.cmdsource2pvw.Name = "cmdsource2pvw"
        Me.cmdsource2pvw.Size = New System.Drawing.Size(41, 35)
        Me.cmdsource2pvw.TabIndex = 742
        Me.cmdsource2pvw.UseVisualStyleBackColor = True
        '
        'cmdsource1pvw
        '
        Me.cmdsource1pvw.BackgroundImage = Global.caspar_media_playback.My.Resources.Resources._1
        Me.cmdsource1pvw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsource1pvw.Location = New System.Drawing.Point(51, 345)
        Me.cmdsource1pvw.Name = "cmdsource1pvw"
        Me.cmdsource1pvw.Size = New System.Drawing.Size(41, 35)
        Me.cmdsource1pvw.TabIndex = 741
        Me.cmdsource1pvw.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox1.Controls.Add(Me.nchromaspill)
        Me.GroupBox1.Controls.Add(Me.Label230)
        Me.GroupBox1.Controls.Add(Me.txtplaycolorbar)
        Me.GroupBox1.Controls.Add(Me.cmdplaycolorbar)
        Me.GroupBox1.Controls.Add(Me.Label103)
        Me.GroupBox1.Controls.Add(Me.Label102)
        Me.GroupBox1.Controls.Add(Me.nchromaspread)
        Me.GroupBox1.Controls.Add(Me.nchromathresholdcenter)
        Me.GroupBox1.Controls.Add(Me.Label101)
        Me.GroupBox1.Controls.Add(Me.txtchromakey)
        Me.GroupBox1.Controls.Add(Me.cmdplaychroma)
        Me.GroupBox1.Controls.Add(Me.cmbchromacolor)
        Me.GroupBox1.Controls.Add(Me.txtlayerproducer1)
        Me.GroupBox1.Controls.Add(Me.cmdplayonfirschannel)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 534)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(647, 68)
        Me.GroupBox1.TabIndex = 740
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chroma Key"
        '
        'nchromaspill
        '
        Me.nchromaspill.Location = New System.Drawing.Point(514, 41)
        Me.nchromaspill.Name = "nchromaspill"
        Me.nchromaspill.Size = New System.Drawing.Size(46, 20)
        Me.nchromaspill.TabIndex = 727
        Me.nchromaspill.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label230
        '
        Me.Label230.AutoSize = True
        Me.Label230.Location = New System.Drawing.Point(476, 44)
        Me.Label230.Name = "Label230"
        Me.Label230.Size = New System.Drawing.Size(26, 13)
        Me.Label230.TabIndex = 726
        Me.Label230.Text = "Spill"
        '
        'txtplaycolorbar
        '
        Me.txtplaycolorbar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtplaycolorbar", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtplaycolorbar.Location = New System.Drawing.Point(218, 18)
        Me.txtplaycolorbar.Name = "txtplaycolorbar"
        Me.txtplaycolorbar.Size = New System.Drawing.Size(100, 20)
        Me.txtplaycolorbar.TabIndex = 657
        Me.txtplaycolorbar.Text = Global.caspar_media_playback.My.MySettings.Default.txtplaycolorbar
        '
        'cmdplaycolorbar
        '
        Me.cmdplaycolorbar.Location = New System.Drawing.Point(322, 16)
        Me.cmdplaycolorbar.Name = "cmdplaycolorbar"
        Me.cmdplaycolorbar.Size = New System.Drawing.Size(75, 23)
        Me.cmdplaycolorbar.TabIndex = 656
        Me.cmdplaycolorbar.Text = "Play"
        Me.cmdplaycolorbar.UseVisualStyleBackColor = True
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Location = New System.Drawing.Point(357, 45)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(48, 13)
        Me.Label103.TabIndex = 648
        Me.Label103.Text = "Softness"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Location = New System.Drawing.Point(253, 45)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(54, 13)
        Me.Label102.TabIndex = 647
        Me.Label102.Text = "Threshold"
        '
        'nchromaspread
        '
        Me.nchromaspread.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.caspar_media_playback.My.MySettings.Default, "nchromaspread", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nchromaspread.DecimalPlaces = 2
        Me.nchromaspread.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nchromaspread.Location = New System.Drawing.Point(407, 42)
        Me.nchromaspread.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nchromaspread.Name = "nchromaspread"
        Me.nchromaspread.Size = New System.Drawing.Size(51, 20)
        Me.nchromaspread.TabIndex = 646
        Me.nchromaspread.Value = Global.caspar_media_playback.My.MySettings.Default.nchromaspread
        '
        'nchromathresholdcenter
        '
        Me.nchromathresholdcenter.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.caspar_media_playback.My.MySettings.Default, "nchromathresholdcenter", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nchromathresholdcenter.DecimalPlaces = 2
        Me.nchromathresholdcenter.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nchromathresholdcenter.Location = New System.Drawing.Point(306, 43)
        Me.nchromathresholdcenter.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nchromathresholdcenter.Name = "nchromathresholdcenter"
        Me.nchromathresholdcenter.Size = New System.Drawing.Size(46, 20)
        Me.nchromathresholdcenter.TabIndex = 645
        Me.nchromathresholdcenter.Value = Global.caspar_media_playback.My.MySettings.Default.nchromathresholdcenter
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Location = New System.Drawing.Point(1, 44)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(64, 13)
        Me.Label101.TabIndex = 643
        Me.Label101.Text = "Chroma Key"
        '
        'txtchromakey
        '
        Me.txtchromakey.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtchromakey", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtchromakey.Location = New System.Drawing.Point(67, 42)
        Me.txtchromakey.Name = "txtchromakey"
        Me.txtchromakey.Size = New System.Drawing.Size(108, 20)
        Me.txtchromakey.TabIndex = 640
        Me.txtchromakey.Text = Global.caspar_media_playback.My.MySettings.Default.txtchromakey
        '
        'cmdplaychroma
        '
        Me.cmdplaychroma.Location = New System.Drawing.Point(565, 39)
        Me.cmdplaychroma.Name = "cmdplaychroma"
        Me.cmdplaychroma.Size = New System.Drawing.Size(75, 23)
        Me.cmdplaychroma.TabIndex = 639
        Me.cmdplaychroma.Text = "Play"
        Me.cmdplaychroma.UseVisualStyleBackColor = True
        '
        'cmbchromacolor
        '
        Me.cmbchromacolor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "cmbchromacolor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbchromacolor.FormattingEnabled = True
        Me.cmbchromacolor.Items.AddRange(New Object() {"GREEN", "BLUE", "none"})
        Me.cmbchromacolor.Location = New System.Drawing.Point(179, 42)
        Me.cmbchromacolor.Name = "cmbchromacolor"
        Me.cmbchromacolor.Size = New System.Drawing.Size(74, 21)
        Me.cmbchromacolor.TabIndex = 634
        Me.cmbchromacolor.Text = Global.caspar_media_playback.My.MySettings.Default.cmbchromacolor
        '
        'txtlayerproducer1
        '
        Me.txtlayerproducer1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.caspar_media_playback.My.MySettings.Default, "txtlayerproducer1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtlayerproducer1.Location = New System.Drawing.Point(5, 16)
        Me.txtlayerproducer1.Name = "txtlayerproducer1"
        Me.txtlayerproducer1.Size = New System.Drawing.Size(129, 20)
        Me.txtlayerproducer1.TabIndex = 632
        Me.txtlayerproducer1.Text = Global.caspar_media_playback.My.MySettings.Default.txtlayerproducer1
        '
        'cmdplayonfirschannel
        '
        Me.cmdplayonfirschannel.Location = New System.Drawing.Point(138, 14)
        Me.cmdplayonfirschannel.Name = "cmdplayonfirschannel"
        Me.cmdplayonfirschannel.Size = New System.Drawing.Size(75, 23)
        Me.cmdplayonfirschannel.TabIndex = 631
        Me.cmdplayonfirschannel.Text = "Play"
        Me.cmdplayonfirschannel.UseVisualStyleBackColor = True
        '
        'cmbsource8
        '
        Me.cmbsource8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsource8.FormattingEnabled = True
        Me.cmbsource8.Items.AddRange(New Object() {"decklink 1", "decklink 2", "decklink 3", "decklink 4", "decklink 4", "decklink 5", "decklink 6", "decklink 7", "decklink 8", "decklink 9", "decklink 10", "decklink 11", "decklink 12", "decklink 13", "decklink 14", "decklink 15", "decklink 16"})
        Me.cmbsource8.Location = New System.Drawing.Point(516, 381)
        Me.cmbsource8.Name = "cmbsource8"
        Me.cmbsource8.Size = New System.Drawing.Size(64, 17)
        Me.cmbsource8.TabIndex = 739
        Me.cmbsource8.Text = "decklink 8"
        '
        'cmbsource7
        '
        Me.cmbsource7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsource7.FormattingEnabled = True
        Me.cmbsource7.Items.AddRange(New Object() {"decklink 1", "decklink 2", "decklink 3", "decklink 4", "decklink 4", "decklink 5", "decklink 6", "decklink 7", "decklink 8", "decklink 9", "decklink 10", "decklink 11", "decklink 12", "decklink 13", "decklink 14", "decklink 15", "decklink 16"})
        Me.cmbsource7.Location = New System.Drawing.Point(446, 381)
        Me.cmbsource7.Name = "cmbsource7"
        Me.cmbsource7.Size = New System.Drawing.Size(64, 17)
        Me.cmbsource7.TabIndex = 738
        Me.cmbsource7.Text = "decklink 7"
        '
        'cmbsource6
        '
        Me.cmbsource6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsource6.FormattingEnabled = True
        Me.cmbsource6.Items.AddRange(New Object() {"decklink 1", "decklink 2", "decklink 3", "decklink 4", "decklink 4", "decklink 5", "decklink 6", "decklink 7", "decklink 8", "decklink 9", "decklink 10", "decklink 11", "decklink 12", "decklink 13", "decklink 14", "decklink 15", "decklink 16"})
        Me.cmbsource6.Location = New System.Drawing.Point(373, 381)
        Me.cmbsource6.Name = "cmbsource6"
        Me.cmbsource6.Size = New System.Drawing.Size(64, 17)
        Me.cmbsource6.TabIndex = 737
        Me.cmbsource6.Text = "decklink 6"
        '
        'cmbsource5
        '
        Me.cmbsource5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsource5.FormattingEnabled = True
        Me.cmbsource5.Items.AddRange(New Object() {"decklink 1", "decklink 2", "decklink 3", "decklink 4", "decklink 4", "decklink 5", "decklink 6", "decklink 7", "decklink 8", "decklink 9", "decklink 10", "decklink 11", "decklink 12", "decklink 13", "decklink 14", "decklink 15", "decklink 16"})
        Me.cmbsource5.Location = New System.Drawing.Point(305, 381)
        Me.cmbsource5.Name = "cmbsource5"
        Me.cmbsource5.Size = New System.Drawing.Size(64, 17)
        Me.cmbsource5.TabIndex = 736
        Me.cmbsource5.Text = "decklink 5"
        '
        'cmbsource4
        '
        Me.cmbsource4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsource4.FormattingEnabled = True
        Me.cmbsource4.Items.AddRange(New Object() {"decklink 1", "decklink 2", "decklink 3", "decklink 4", "decklink 4", "decklink 5", "decklink 6", "decklink 7", "decklink 8", "decklink 9", "decklink 10", "decklink 11", "decklink 12", "decklink 13", "decklink 14", "decklink 15", "decklink 16"})
        Me.cmbsource4.Location = New System.Drawing.Point(238, 381)
        Me.cmbsource4.Name = "cmbsource4"
        Me.cmbsource4.Size = New System.Drawing.Size(64, 17)
        Me.cmbsource4.TabIndex = 735
        Me.cmbsource4.Text = "decklink 4"
        '
        'cmbsource3
        '
        Me.cmbsource3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsource3.FormattingEnabled = True
        Me.cmbsource3.Items.AddRange(New Object() {"decklink 1", "decklink 2", "decklink 3", "decklink 4", "decklink 4", "decklink 5", "decklink 6", "decklink 7", "decklink 8", "decklink 9", "decklink 10", "decklink 11", "decklink 12", "decklink 13", "decklink 14", "decklink 15", "decklink 16"})
        Me.cmbsource3.Location = New System.Drawing.Point(171, 381)
        Me.cmbsource3.Name = "cmbsource3"
        Me.cmbsource3.Size = New System.Drawing.Size(64, 17)
        Me.cmbsource3.TabIndex = 734
        Me.cmbsource3.Text = "decklink 3"
        '
        'cmbsource2
        '
        Me.cmbsource2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsource2.FormattingEnabled = True
        Me.cmbsource2.Items.AddRange(New Object() {"decklink 1", "decklink 2", "decklink 3", "decklink 4", "decklink 4", "decklink 5", "decklink 6", "decklink 7", "decklink 8", "decklink 9", "decklink 10", "decklink 11", "decklink 12", "decklink 13", "decklink 14", "decklink 15", "decklink 16"})
        Me.cmbsource2.Location = New System.Drawing.Point(105, 381)
        Me.cmbsource2.Name = "cmbsource2"
        Me.cmbsource2.Size = New System.Drawing.Size(64, 17)
        Me.cmbsource2.TabIndex = 733
        Me.cmbsource2.Text = "decklink 2"
        '
        'cmbsource1
        '
        Me.cmbsource1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsource1.FormattingEnabled = True
        Me.cmbsource1.Items.AddRange(New Object() {"decklink 1", "decklink 2", "decklink 3", "decklink 4", "decklink 4", "decklink 5", "decklink 6", "decklink 7", "decklink 8", "decklink 9", "decklink 10", "decklink 11", "decklink 12", "decklink 13", "decklink 14", "decklink 15", "decklink 16", "Vision_Mixer/Source1", "Vision_Mixer/Source2", "Vision_Mixer/Source3", "Vision_Mixer/Source4", "Vision_Mixer/Source5", "Vision_Mixer/Source6", "Vision_Mixer/Source7", "Vision_Mixer/Source8"})
        Me.cmbsource1.Location = New System.Drawing.Point(39, 381)
        Me.cmbsource1.Name = "cmbsource1"
        Me.cmbsource1.Size = New System.Drawing.Size(64, 17)
        Me.cmbsource1.TabIndex = 732
        Me.cmbsource1.Text = "decklink 1"
        '
        'cmdsource8
        '
        Me.cmdsource8.BackgroundImage = CType(resources.GetObject("cmdsource8.BackgroundImage"), System.Drawing.Image)
        Me.cmdsource8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsource8.Location = New System.Drawing.Point(521, 314)
        Me.cmdsource8.Name = "cmdsource8"
        Me.cmdsource8.Size = New System.Drawing.Size(41, 35)
        Me.cmdsource8.TabIndex = 731
        Me.cmdsource8.UseVisualStyleBackColor = True
        '
        'cmdsource7
        '
        Me.cmdsource7.BackgroundImage = CType(resources.GetObject("cmdsource7.BackgroundImage"), System.Drawing.Image)
        Me.cmdsource7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsource7.Location = New System.Drawing.Point(456, 314)
        Me.cmdsource7.Name = "cmdsource7"
        Me.cmdsource7.Size = New System.Drawing.Size(41, 35)
        Me.cmdsource7.TabIndex = 730
        Me.cmdsource7.UseVisualStyleBackColor = True
        '
        'cmdsource6
        '
        Me.cmdsource6.BackgroundImage = CType(resources.GetObject("cmdsource6.BackgroundImage"), System.Drawing.Image)
        Me.cmdsource6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsource6.Location = New System.Drawing.Point(383, 314)
        Me.cmdsource6.Name = "cmdsource6"
        Me.cmdsource6.Size = New System.Drawing.Size(41, 35)
        Me.cmdsource6.TabIndex = 729
        Me.cmdsource6.UseVisualStyleBackColor = True
        '
        'cmdsource5
        '
        Me.cmdsource5.BackgroundImage = CType(resources.GetObject("cmdsource5.BackgroundImage"), System.Drawing.Image)
        Me.cmdsource5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsource5.Location = New System.Drawing.Point(311, 314)
        Me.cmdsource5.Name = "cmdsource5"
        Me.cmdsource5.Size = New System.Drawing.Size(41, 35)
        Me.cmdsource5.TabIndex = 728
        Me.cmdsource5.UseVisualStyleBackColor = True
        '
        'gbcolorforvisionmixer
        '
        Me.gbcolorforvisionmixer.BackColor = System.Drawing.Color.MistyRose
        Me.gbcolorforvisionmixer.Controls.Add(Me.rdoColorPVW)
        Me.gbcolorforvisionmixer.Controls.Add(Me.rdoColorPGM)
        Me.gbcolorforvisionmixer.Controls.Add(Me.GEyeDropper4)
        Me.gbcolorforvisionmixer.Controls.Add(Me.GEyeDropper3)
        Me.gbcolorforvisionmixer.Controls.Add(Me.GEyeDropper2)
        Me.gbcolorforvisionmixer.Controls.Add(Me.GEyeDropper1)
        Me.gbcolorforvisionmixer.Controls.Add(Me.c4)
        Me.gbcolorforvisionmixer.Controls.Add(Me.c3)
        Me.gbcolorforvisionmixer.Controls.Add(Me.c2)
        Me.gbcolorforvisionmixer.Controls.Add(Me.c1)
        Me.gbcolorforvisionmixer.Controls.Add(Me.Label4)
        Me.gbcolorforvisionmixer.Controls.Add(Me.Label3)
        Me.gbcolorforvisionmixer.Controls.Add(Me.Label2)
        Me.gbcolorforvisionmixer.Controls.Add(Me.Label1)
        Me.gbcolorforvisionmixer.Controls.Add(Me.cmdstripcolorvisionmixer4)
        Me.gbcolorforvisionmixer.Controls.Add(Me.cmdstripcolorvisionmixer3)
        Me.gbcolorforvisionmixer.Controls.Add(Me.cmdstripcolorvisionmixer2)
        Me.gbcolorforvisionmixer.Controls.Add(Me.cmdstripcolorvisionmixer1)
        Me.gbcolorforvisionmixer.Controls.Add(Me.cmdPlayColor)
        Me.gbcolorforvisionmixer.Controls.Add(Me.cmdgreen)
        Me.gbcolorforvisionmixer.Controls.Add(Me.cmdblack)
        Me.gbcolorforvisionmixer.Controls.Add(Me.cmdred)
        Me.gbcolorforvisionmixer.Controls.Add(Me.cmdblue)
        Me.gbcolorforvisionmixer.Location = New System.Drawing.Point(6, 411)
        Me.gbcolorforvisionmixer.Name = "gbcolorforvisionmixer"
        Me.gbcolorforvisionmixer.Size = New System.Drawing.Size(437, 117)
        Me.gbcolorforvisionmixer.TabIndex = 727
        Me.gbcolorforvisionmixer.TabStop = False
        Me.gbcolorforvisionmixer.Text = "Any Color or Gradient Color in Server 2.1"
        '
        'rdoColorPVW
        '
        Me.rdoColorPVW.AutoSize = True
        Me.rdoColorPVW.Checked = True
        Me.rdoColorPVW.Location = New System.Drawing.Point(323, 51)
        Me.rdoColorPVW.Name = "rdoColorPVW"
        Me.rdoColorPVW.Size = New System.Drawing.Size(50, 17)
        Me.rdoColorPVW.TabIndex = 732
        Me.rdoColorPVW.TabStop = True
        Me.rdoColorPVW.Text = "PVW"
        Me.rdoColorPVW.UseVisualStyleBackColor = True
        '
        'rdoColorPGM
        '
        Me.rdoColorPGM.AutoSize = True
        Me.rdoColorPGM.Location = New System.Drawing.Point(323, 28)
        Me.rdoColorPGM.Name = "rdoColorPGM"
        Me.rdoColorPGM.Size = New System.Drawing.Size(49, 17)
        Me.rdoColorPGM.TabIndex = 731
        Me.rdoColorPGM.Text = "PGM"
        Me.rdoColorPGM.UseVisualStyleBackColor = True
        '
        'GEyeDropper4
        '
        Me.GEyeDropper4.BorderColor = System.Drawing.Color.Blue
        Me.GEyeDropper4.ButtonColor = System.Drawing.Color.White
        Me.GEyeDropper4.Location = New System.Drawing.Point(208, 85)
        Me.GEyeDropper4.Name = "GEyeDropper4"
        Me.GEyeDropper4.SelectedColor = System.Drawing.Color.Empty
        Me.GEyeDropper4.ShowSelectedSwatch = True
        Me.GEyeDropper4.Size = New System.Drawing.Size(22, 22)
        Me.GEyeDropper4.TabIndex = 730
        Me.ToolTip1.SetToolTip(Me.GEyeDropper4, "Eye Dropper Click hold and drag to to selec color")
        Me.GEyeDropper4.ZoomLevel = caspar_media_playback.ucEyeDropper.eZoomLevel.Level1
        Me.GEyeDropper4.ZoomWindowType = caspar_media_playback.ucEyeDropper.eZoomWindowType.ShowOnCursor
        '
        'GEyeDropper3
        '
        Me.GEyeDropper3.BorderColor = System.Drawing.Color.Blue
        Me.GEyeDropper3.ButtonColor = System.Drawing.Color.White
        Me.GEyeDropper3.Location = New System.Drawing.Point(148, 85)
        Me.GEyeDropper3.Name = "GEyeDropper3"
        Me.GEyeDropper3.SelectedColor = System.Drawing.Color.Empty
        Me.GEyeDropper3.ShowSelectedSwatch = True
        Me.GEyeDropper3.Size = New System.Drawing.Size(22, 22)
        Me.GEyeDropper3.TabIndex = 729
        Me.ToolTip1.SetToolTip(Me.GEyeDropper3, "Eye Dropper Click hold and drag to to selec color")
        Me.GEyeDropper3.ZoomLevel = caspar_media_playback.ucEyeDropper.eZoomLevel.Level1
        Me.GEyeDropper3.ZoomWindowType = caspar_media_playback.ucEyeDropper.eZoomWindowType.ShowOnCursor
        '
        'GEyeDropper2
        '
        Me.GEyeDropper2.BorderColor = System.Drawing.Color.Blue
        Me.GEyeDropper2.ButtonColor = System.Drawing.Color.White
        Me.GEyeDropper2.Location = New System.Drawing.Point(74, 85)
        Me.GEyeDropper2.Name = "GEyeDropper2"
        Me.GEyeDropper2.SelectedColor = System.Drawing.Color.Empty
        Me.GEyeDropper2.ShowSelectedSwatch = True
        Me.GEyeDropper2.Size = New System.Drawing.Size(22, 22)
        Me.GEyeDropper2.TabIndex = 728
        Me.ToolTip1.SetToolTip(Me.GEyeDropper2, "Eye Dropper Click hold and drag to to selec color")
        Me.GEyeDropper2.ZoomLevel = caspar_media_playback.ucEyeDropper.eZoomLevel.Level1
        Me.GEyeDropper2.ZoomWindowType = caspar_media_playback.ucEyeDropper.eZoomWindowType.ShowOnCursor
        '
        'GEyeDropper1
        '
        Me.GEyeDropper1.BorderColor = System.Drawing.Color.Blue
        Me.GEyeDropper1.ButtonColor = System.Drawing.Color.White
        Me.GEyeDropper1.Location = New System.Drawing.Point(5, 85)
        Me.GEyeDropper1.Name = "GEyeDropper1"
        Me.GEyeDropper1.SelectedColor = System.Drawing.Color.Empty
        Me.GEyeDropper1.ShowSelectedSwatch = True
        Me.GEyeDropper1.Size = New System.Drawing.Size(22, 22)
        Me.GEyeDropper1.TabIndex = 727
        Me.ToolTip1.SetToolTip(Me.GEyeDropper1, "Eye Dropper Click hold and drag to to selec color")
        Me.GEyeDropper1.ZoomLevel = caspar_media_playback.ucEyeDropper.eZoomLevel.Level1
        Me.GEyeDropper1.ZoomWindowType = caspar_media_playback.ucEyeDropper.eZoomWindowType.ShowOnCursor
        '
        'c4
        '
        Me.c4.AutoSize = True
        Me.c4.Checked = True
        Me.c4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.c4.Location = New System.Drawing.Point(207, 62)
        Me.c4.Name = "c4"
        Me.c4.Size = New System.Drawing.Size(38, 17)
        Me.c4.TabIndex = 26
        Me.c4.Text = "c4"
        Me.ToolTip1.SetToolTip(Me.c4, "Tick to show")
        Me.c4.UseVisualStyleBackColor = True
        '
        'c3
        '
        Me.c3.AutoSize = True
        Me.c3.Checked = True
        Me.c3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.c3.Location = New System.Drawing.Point(145, 62)
        Me.c3.Name = "c3"
        Me.c3.Size = New System.Drawing.Size(38, 17)
        Me.c3.TabIndex = 25
        Me.c3.Text = "c3"
        Me.ToolTip1.SetToolTip(Me.c3, "Tick to show")
        Me.c3.UseVisualStyleBackColor = True
        '
        'c2
        '
        Me.c2.AutoSize = True
        Me.c2.Checked = True
        Me.c2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.c2.Location = New System.Drawing.Point(73, 62)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(38, 17)
        Me.c2.TabIndex = 24
        Me.c2.Text = "c2"
        Me.ToolTip1.SetToolTip(Me.c2, "Tick to show")
        Me.c2.UseVisualStyleBackColor = True
        '
        'c1
        '
        Me.c1.AutoSize = True
        Me.c1.Checked = True
        Me.c1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.c1.Location = New System.Drawing.Point(7, 62)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(38, 17)
        Me.c1.TabIndex = 23
        Me.c1.Text = "c1"
        Me.ToolTip1.SetToolTip(Me.c1, "Tick to show")
        Me.c1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(207, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "#FFFFFF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "#0000FF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "#00FF00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "#FF0000"
        '
        'cmdstripcolorvisionmixer4
        '
        Me.cmdstripcolorvisionmixer4.BackColor = System.Drawing.Color.White
        Me.cmdstripcolorvisionmixer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cmdstripcolorvisionmixer4.Location = New System.Drawing.Point(208, 19)
        Me.cmdstripcolorvisionmixer4.Name = "cmdstripcolorvisionmixer4"
        Me.cmdstripcolorvisionmixer4.Size = New System.Drawing.Size(63, 26)
        Me.cmdstripcolorvisionmixer4.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.cmdstripcolorvisionmixer4, "Click to show standard color dialog")
        '
        'cmdstripcolorvisionmixer3
        '
        Me.cmdstripcolorvisionmixer3.BackColor = System.Drawing.Color.Blue
        Me.cmdstripcolorvisionmixer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cmdstripcolorvisionmixer3.Location = New System.Drawing.Point(142, 19)
        Me.cmdstripcolorvisionmixer3.Name = "cmdstripcolorvisionmixer3"
        Me.cmdstripcolorvisionmixer3.Size = New System.Drawing.Size(63, 26)
        Me.cmdstripcolorvisionmixer3.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.cmdstripcolorvisionmixer3, "Click to show standard color dialog")
        '
        'cmdstripcolorvisionmixer2
        '
        Me.cmdstripcolorvisionmixer2.BackColor = System.Drawing.Color.Lime
        Me.cmdstripcolorvisionmixer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cmdstripcolorvisionmixer2.Location = New System.Drawing.Point(74, 19)
        Me.cmdstripcolorvisionmixer2.Name = "cmdstripcolorvisionmixer2"
        Me.cmdstripcolorvisionmixer2.Size = New System.Drawing.Size(63, 26)
        Me.cmdstripcolorvisionmixer2.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.cmdstripcolorvisionmixer2, "Click to show standard color dialog")
        '
        'cmdstripcolorvisionmixer1
        '
        Me.cmdstripcolorvisionmixer1.BackColor = System.Drawing.Color.Red
        Me.cmdstripcolorvisionmixer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cmdstripcolorvisionmixer1.Location = New System.Drawing.Point(6, 19)
        Me.cmdstripcolorvisionmixer1.Name = "cmdstripcolorvisionmixer1"
        Me.cmdstripcolorvisionmixer1.Size = New System.Drawing.Size(63, 26)
        Me.cmdstripcolorvisionmixer1.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.cmdstripcolorvisionmixer1, "Click to show standard color dialog")
        '
        'cmdPlayColor
        '
        Me.cmdPlayColor.Location = New System.Drawing.Point(273, 18)
        Me.cmdPlayColor.Name = "cmdPlayColor"
        Me.cmdPlayColor.Size = New System.Drawing.Size(48, 93)
        Me.cmdPlayColor.TabIndex = 14
        Me.cmdPlayColor.Text = "Show"
        Me.cmdPlayColor.UseVisualStyleBackColor = True
        '
        'cmdgreen
        '
        Me.cmdgreen.BackColor = System.Drawing.Color.Green
        Me.cmdgreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdgreen.ForeColor = System.Drawing.Color.White
        Me.cmdgreen.Location = New System.Drawing.Point(373, 38)
        Me.cmdgreen.Name = "cmdgreen"
        Me.cmdgreen.Size = New System.Drawing.Size(59, 23)
        Me.cmdgreen.TabIndex = 581
        Me.cmdgreen.Text = "Green"
        Me.cmdgreen.UseVisualStyleBackColor = False
        '
        'cmdblack
        '
        Me.cmdblack.BackColor = System.Drawing.Color.Black
        Me.cmdblack.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdblack.ForeColor = System.Drawing.Color.White
        Me.cmdblack.Location = New System.Drawing.Point(369, 90)
        Me.cmdblack.Name = "cmdblack"
        Me.cmdblack.Size = New System.Drawing.Size(62, 26)
        Me.cmdblack.TabIndex = 578
        Me.cmdblack.Text = "Black"
        Me.cmdblack.UseVisualStyleBackColor = False
        '
        'cmdred
        '
        Me.cmdred.BackColor = System.Drawing.Color.Red
        Me.cmdred.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdred.ForeColor = System.Drawing.Color.White
        Me.cmdred.Location = New System.Drawing.Point(373, 8)
        Me.cmdred.Name = "cmdred"
        Me.cmdred.Size = New System.Drawing.Size(59, 23)
        Me.cmdred.TabIndex = 579
        Me.cmdred.Text = "Red"
        Me.cmdred.UseVisualStyleBackColor = False
        '
        'cmdblue
        '
        Me.cmdblue.BackColor = System.Drawing.Color.Blue
        Me.cmdblue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdblue.ForeColor = System.Drawing.Color.White
        Me.cmdblue.Location = New System.Drawing.Point(373, 65)
        Me.cmdblue.Name = "cmdblue"
        Me.cmdblue.Size = New System.Drawing.Size(59, 23)
        Me.cmdblue.TabIndex = 580
        Me.cmdblue.Text = "Blue"
        Me.cmdblue.UseVisualStyleBackColor = False
        '
        'cmdsource4
        '
        Me.cmdsource4.BackgroundImage = CType(resources.GetObject("cmdsource4.BackgroundImage"), System.Drawing.Image)
        Me.cmdsource4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsource4.Location = New System.Drawing.Point(247, 314)
        Me.cmdsource4.Name = "cmdsource4"
        Me.cmdsource4.Size = New System.Drawing.Size(41, 35)
        Me.cmdsource4.TabIndex = 577
        Me.cmdsource4.UseVisualStyleBackColor = True
        '
        'cmdsource3
        '
        Me.cmdsource3.BackgroundImage = CType(resources.GetObject("cmdsource3.BackgroundImage"), System.Drawing.Image)
        Me.cmdsource3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsource3.Location = New System.Drawing.Point(181, 314)
        Me.cmdsource3.Name = "cmdsource3"
        Me.cmdsource3.Size = New System.Drawing.Size(41, 35)
        Me.cmdsource3.TabIndex = 576
        Me.cmdsource3.UseVisualStyleBackColor = True
        '
        'cmdsource2
        '
        Me.cmdsource2.BackgroundImage = CType(resources.GetObject("cmdsource2.BackgroundImage"), System.Drawing.Image)
        Me.cmdsource2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsource2.Location = New System.Drawing.Point(114, 314)
        Me.cmdsource2.Name = "cmdsource2"
        Me.cmdsource2.Size = New System.Drawing.Size(41, 35)
        Me.cmdsource2.TabIndex = 575
        Me.cmdsource2.UseVisualStyleBackColor = True
        '
        'cmdsource1
        '
        Me.cmdsource1.BackgroundImage = Global.caspar_media_playback.My.Resources.Resources._1
        Me.cmdsource1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdsource1.Location = New System.Drawing.Point(51, 314)
        Me.cmdsource1.Name = "cmdsource1"
        Me.cmdsource1.Size = New System.Drawing.Size(41, 35)
        Me.cmdsource1.TabIndex = 574
        Me.cmdsource1.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Layer"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Producer/ Consumer"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 40
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "File Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'ucVisionMixer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1208, 921)
        Me.Controls.Add(Me.gbvisionmixer)
        Me.HideOnClose = True
        Me.Name = "ucVisionMixer"
        Me.Text = "Vision Mixer"
        Me.gbvisionmixer.ResumeLayout(False)
        Me.gbvisionmixer.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvchannelinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ntransitionduration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nchromaspill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nchromaspread, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nchromathresholdcenter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbcolorforvisionmixer.ResumeLayout(False)
        Me.gbcolorforvisionmixer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbvisionmixer As System.Windows.Forms.GroupBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents cmbdirection As System.Windows.Forms.ComboBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents cmbtweentype As System.Windows.Forms.ComboBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents ntransitionduration As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbtransition As System.Windows.Forms.ComboBox
    Friend WithEvents cmdgreen As System.Windows.Forms.Button
    Friend WithEvents cmdblue As System.Windows.Forms.Button
    Friend WithEvents cmdred As System.Windows.Forms.Button
    Friend WithEvents cmdblack As System.Windows.Forms.Button
    Friend WithEvents cmdsource4 As System.Windows.Forms.Button
    Friend WithEvents cmdsource3 As System.Windows.Forms.Button
    Friend WithEvents cmdsource2 As System.Windows.Forms.Button
    Friend WithEvents cmdsource1 As System.Windows.Forms.Button
    Friend WithEvents GEyeDropper1 As caspar_media_playback.ucEyeDropper
    Friend WithEvents gbcolorforvisionmixer As System.Windows.Forms.GroupBox
    Friend WithEvents c4 As System.Windows.Forms.CheckBox
    Friend WithEvents c3 As System.Windows.Forms.CheckBox
    Friend WithEvents c2 As System.Windows.Forms.CheckBox
    Friend WithEvents c1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdstripcolorvisionmixer4 As System.Windows.Forms.Panel
    Friend WithEvents cmdstripcolorvisionmixer3 As System.Windows.Forms.Panel
    Friend WithEvents cmdstripcolorvisionmixer2 As System.Windows.Forms.Panel
    Friend WithEvents cmdstripcolorvisionmixer1 As System.Windows.Forms.Panel
    Friend WithEvents cmdPlayColor As System.Windows.Forms.Button
    Friend WithEvents GEyeDropper4 As caspar_media_playback.ucEyeDropper
    Friend WithEvents GEyeDropper3 As caspar_media_playback.ucEyeDropper
    Friend WithEvents GEyeDropper2 As caspar_media_playback.ucEyeDropper
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmbsource1 As ComboBox
    Friend WithEvents cmdsource8 As Button
    Friend WithEvents cmdsource7 As Button
    Friend WithEvents cmdsource6 As Button
    Friend WithEvents cmdsource5 As Button
    Friend WithEvents cmbsource8 As ComboBox
    Friend WithEvents cmbsource7 As ComboBox
    Friend WithEvents cmbsource6 As ComboBox
    Friend WithEvents cmbsource5 As ComboBox
    Friend WithEvents cmbsource4 As ComboBox
    Friend WithEvents cmbsource3 As ComboBox
    Friend WithEvents cmbsource2 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents nchromaspill As NumericUpDown
    Friend WithEvents Label230 As Label
    Friend WithEvents txtplaycolorbar As TextBox
    Friend WithEvents cmdplaycolorbar As Button
    Friend WithEvents Label103 As Label
    Friend WithEvents Label102 As Label
    Friend WithEvents nchromaspread As NumericUpDown
    Friend WithEvents nchromathresholdcenter As NumericUpDown
    Friend WithEvents Label101 As Label
    Friend WithEvents txtchromakey As TextBox
    Friend WithEvents cmdplaychroma As Button
    Friend WithEvents cmbchromacolor As ComboBox
    Friend WithEvents txtlayerproducer1 As TextBox
    Friend WithEvents cmdplayonfirschannel As Button
    Friend WithEvents cmdsource8pvw As Button
    Friend WithEvents cmdsource7pvw As Button
    Friend WithEvents cmdsource6pvw As Button
    Friend WithEvents cmdsource5pvw As Button
    Friend WithEvents cmdsource4pvw As Button
    Friend WithEvents cmdsource3pvw As Button
    Friend WithEvents cmdsource2pvw As Button
    Friend WithEvents cmdsource1pvw As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdCut As Button
    Friend WithEvents pnlrecording As Panel
    Friend WithEvents cmbcasparcgwindowtitlerecording As ComboBox
    Friend WithEvents cmdoutcasparcgwindowVM As Button
    Friend WithEvents cmdshowcasparcgwindowrecording As Button
    Friend WithEvents InitialiseActual As Button
    Friend WithEvents cmdInitialiseDummy As Button
    Friend WithEvents pnlrecording3 As Panel
    Friend WithEvents cmbcasparcgwindowtitlerecording3 As ComboBox
    Friend WithEvents cmdoutcasparcgwindowVM3 As Button
    Friend WithEvents cmdshowcasparcgwindowrecording3 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmdRestartCasparwithConfig As Button
    Friend WithEvents cmdMix As Button
    Friend WithEvents lblpreviewSource As Label
    Friend WithEvents lblPGMSource As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmdWipe As Button
    Friend WithEvents rdoColorPVW As RadioButton
    Friend WithEvents rdoColorPGM As RadioButton
    Friend WithEvents cmdgetchannelinfo As Button
    Friend WithEvents dgvchannelinfo As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents clmStop As DataGridViewButtonColumn
    Friend WithEvents cmdStop As DataGridViewButtonColumn
    Friend WithEvents cmdStopallFlash As Button
    Friend WithEvents cmdPlayallflash As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmdsource9pvw As Button
    Friend WithEvents cmdsource9 As Button
    Friend WithEvents cmbNDI As ComboBox
    Friend WithEvents cmdInitialiseNewNDISources As Button
End Class
