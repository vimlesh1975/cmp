<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucCricket
    'Inherits System.Windows.Forms.UserControl
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucCricket))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbSubHeader = New System.Windows.Forms.ComboBox()
        Me.cmbHeader = New System.Windows.Forms.ComboBox()
        Me.cmdeventid = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbgames = New System.Windows.Forms.ComboBox()
        Me.eventlogo = New System.Windows.Forms.PictureBox()
        Me.gamelogo = New System.Windows.Forms.PictureBox()
        Me.cmdstopgym = New System.Windows.Forms.Button()
        Me.chkanimationzym = New System.Windows.Forms.CheckBox()
        Me.chkanimationforhdvan = New System.Windows.Forms.CheckBox()
        Me.cmdaddoutput = New System.Windows.Forms.Button()
        Me.cmdremoveoutput = New System.Windows.Forms.Button()
        Me.cmdsd = New System.Windows.Forms.Button()
        Me.cmdhd = New System.Windows.Forms.Button()
        Me.cmdsqueezeforsafesd = New System.Windows.Forms.Button()
        Me.cmdfillnormal = New System.Windows.Forms.Button()
        Me.tmrtimeonform = New System.Windows.Forms.Timer(Me.components)
        Me.tmrtimeupdateontemplate = New System.Windows.Forms.Timer(Me.components)
        Me.tmrupdateontemplateextra = New System.Windows.Forms.Timer(Me.components)
        Me.ofd1 = New System.Windows.Forms.OpenFileDialog()
        Me.Cricket = New System.Windows.Forms.TabPage()
        Me.txt3liner3 = New System.Windows.Forms.TextBox()
        Me.txt3liner2 = New System.Windows.Forms.TextBox()
        Me.txt3liner1 = New System.Windows.Forms.TextBox()
        Me.cmd3liner = New System.Windows.Forms.Button()
        Me.txttwoliner2 = New System.Windows.Forms.TextBox()
        Me.txttwoliner1 = New System.Windows.Forms.TextBox()
        Me.cmdtwoliner = New System.Windows.Forms.Button()
        Me.txtoneliner = New System.Windows.Forms.TextBox()
        Me.cmdonliner = New System.Windows.Forms.Button()
        Me.cmbinfo7 = New System.Windows.Forms.TextBox()
        Me.cmdscore7update = New System.Windows.Forms.Button()
        Me.txtinfo7 = New System.Windows.Forms.TextBox()
        Me.cmdscore7 = New System.Windows.Forms.Button()
        Me.cmbinfo6 = New System.Windows.Forms.TextBox()
        Me.cmdscore6update = New System.Windows.Forms.Button()
        Me.txtinfo6 = New System.Windows.Forms.TextBox()
        Me.cmdscore6 = New System.Windows.Forms.Button()
        Me.cmbinfo5 = New System.Windows.Forms.TextBox()
        Me.cmdscore5update = New System.Windows.Forms.Button()
        Me.txtinfo5 = New System.Windows.Forms.TextBox()
        Me.cmdscore5 = New System.Windows.Forms.Button()
        Me.cmbinfo4 = New System.Windows.Forms.TextBox()
        Me.cmdscore4update = New System.Windows.Forms.Button()
        Me.txtinfo4 = New System.Windows.Forms.TextBox()
        Me.cmdscore4 = New System.Windows.Forms.Button()
        Me.cmbinfo3 = New System.Windows.Forms.TextBox()
        Me.cmdscore3update = New System.Windows.Forms.Button()
        Me.txtinfo3 = New System.Windows.Forms.TextBox()
        Me.cmdscore3 = New System.Windows.Forms.Button()
        Me.dgvFOW = New System.Windows.Forms.DataGridView()
        Me.FOW1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdoB11 = New System.Windows.Forms.RadioButton()
        Me.rdoB10 = New System.Windows.Forms.RadioButton()
        Me.rdoB9 = New System.Windows.Forms.RadioButton()
        Me.rdoB8 = New System.Windows.Forms.RadioButton()
        Me.rdoB7 = New System.Windows.Forms.RadioButton()
        Me.rdoB6 = New System.Windows.Forms.RadioButton()
        Me.rdoB5 = New System.Windows.Forms.RadioButton()
        Me.rdoB4 = New System.Windows.Forms.RadioButton()
        Me.rdoB3 = New System.Windows.Forms.RadioButton()
        Me.rdoB2 = New System.Windows.Forms.RadioButton()
        Me.rdoB1 = New System.Windows.Forms.RadioButton()
        Me.rdoB0 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoP11 = New System.Windows.Forms.RadioButton()
        Me.rdoP10 = New System.Windows.Forms.RadioButton()
        Me.rdoP9 = New System.Windows.Forms.RadioButton()
        Me.rdoP8 = New System.Windows.Forms.RadioButton()
        Me.rdoP7 = New System.Windows.Forms.RadioButton()
        Me.rdoP6 = New System.Windows.Forms.RadioButton()
        Me.rdoP5 = New System.Windows.Forms.RadioButton()
        Me.rdoP4 = New System.Windows.Forms.RadioButton()
        Me.rdoP3 = New System.Windows.Forms.RadioButton()
        Me.rdoP2 = New System.Windows.Forms.RadioButton()
        Me.rdoP1 = New System.Windows.Forms.RadioButton()
        Me.rdoP0 = New System.Windows.Forms.RadioButton()
        Me.chkStrinkingPostionB = New System.Windows.Forms.CheckBox()
        Me.chkStrinkingPostionA = New System.Windows.Forms.CheckBox()
        Me.cmdscore2update = New System.Windows.Forms.Button()
        Me.cmdscore1update = New System.Windows.Forms.Button()
        Me.cmdscoreupdate = New System.Windows.Forms.Button()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.pict2logocricket = New System.Windows.Forms.PictureBox()
        Me.pict1logocricket = New System.Windows.Forms.PictureBox()
        Me.cmdclearbatsmanstatics = New System.Windows.Forms.Button()
        Me.cmdrowdeletebatsman = New System.Windows.Forms.Button()
        Me.cmdrowinsertbatsman = New System.Windows.Forms.Button()
        Me.tstwoliner = New System.Windows.Forms.ToolStrip()
        Me.newbatmandata = New System.Windows.Forms.ToolStripButton()
        Me.openbatsmandata = New System.Windows.Forms.ToolStripButton()
        Me.savebatsmandata = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdrowdownbatsman = New System.Windows.Forms.Button()
        Me.cmdrowupbatsman = New System.Windows.Forms.Button()
        Me.txtinfo1 = New System.Windows.Forms.TextBox()
        Me.txtinfo2 = New System.Windows.Forms.TextBox()
        Me.cmbinfo2 = New System.Windows.Forms.TextBox()
        Me.cmbinfo1 = New System.Windows.Forms.TextBox()
        Me.txtnb = New System.Windows.Forms.TextBox()
        Me.txtwd = New System.Windows.Forms.TextBox()
        Me.txtlb = New System.Windows.Forms.TextBox()
        Me.txtby = New System.Windows.Forms.TextBox()
        Me.txttotalextra = New System.Windows.Forms.TextBox()
        Me.txttotalbatsmanvalue = New System.Windows.Forms.TextBox()
        Me.txttotalbatsman = New System.Windows.Forms.TextBox()
        Me.txtoversbatman = New System.Windows.Forms.TextBox()
        Me.txtextrabatmanvalue = New System.Windows.Forms.TextBox()
        Me.txtextrabatman = New System.Windows.Forms.TextBox()
        Me.txtoversbatmanvalue = New System.Windows.Forms.TextBox()
        Me.txtteamnameb = New System.Windows.Forms.TextBox()
        Me.txtteamnamea = New System.Windows.Forms.TextBox()
        Me.txtthisover = New System.Windows.Forms.TextBox()
        Me.txtlastwicketat = New System.Windows.Forms.TextBox()
        Me.txtmatchover = New System.Windows.Forms.TextBox()
        Me.txt1stinningscore = New System.Windows.Forms.TextBox()
        Me.txtover = New System.Windows.Forms.TextBox()
        Me.txtinfo = New System.Windows.Forms.TextBox()
        Me.txtwicket = New System.Windows.Forms.TextBox()
        Me.txtovers = New System.Windows.Forms.TextBox()
        Me.txtrun = New System.Windows.Forms.TextBox()
        Me.txtteamname = New System.Windows.Forms.TextBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.cmdplayeridbatsman = New System.Windows.Forms.Button()
        Me.dgvbowler = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvbatsman = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.B = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.cmdscore2 = New System.Windows.Forms.Button()
        Me.cmdscore1 = New System.Windows.Forms.Button()
        Me.cmdcleardatascore = New System.Windows.Forms.Button()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.cmdcleardatabowlerstatics = New System.Windows.Forms.Button()
        Me.lblfilenamebowler = New System.Windows.Forms.Label()
        Me.cmdbowlerstatus = New System.Windows.Forms.Button()
        Me.cmdplayeridbowler = New System.Windows.Forms.Button()
        Me.cmdbatsmanstatus = New System.Windows.Forms.Button()
        Me.cmdrowupbowler = New System.Windows.Forms.Button()
        Me.cmdrowdownbowler = New System.Windows.Forms.Button()
        Me.cmdrowinsertbowler = New System.Windows.Forms.Button()
        Me.lblfilenamebatsman = New System.Windows.Forms.Label()
        Me.cmdrowdeletebowler = New System.Windows.Forms.Button()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.newdatabowler = New System.Windows.Forms.ToolStripButton()
        Me.tsopendatabowler = New System.Windows.Forms.ToolStripButton()
        Me.tssavedatabowler = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdbowlingcard = New System.Windows.Forms.Button()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.cmdbattingcard = New System.Windows.Forms.Button()
        Me.cmdteamlinupbowler = New System.Windows.Forms.Button()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.cmdteamlinupbatsman = New System.Windows.Forms.Button()
        Me.lbllastwicketat = New System.Windows.Forms.Label()
        Me.lblthisover = New System.Windows.Forms.Label()
        Me.lblmatchover = New System.Windows.Forms.Label()
        Me.lbl1stinningscore = New System.Windows.Forms.Label()
        Me.cmbinfo = New System.Windows.Forms.ComboBox()
        Me.cmdover = New System.Windows.Forms.Button()
        Me.cmdwicket = New System.Windows.Forms.Button()
        Me.cmdrun = New System.Windows.Forms.Button()
        Me.cmdscore = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.txthtmlupdateDelay = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmblayergames = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.eventlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gamelogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cricket.SuspendLayout()
        CType(Me.dgvFOW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pict2logocricket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pict1logocricket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tstwoliner.SuspendLayout()
        CType(Me.dgvbowler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvbatsman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LemonChiffon
        Me.GroupBox3.Controls.Add(Me.cmbSubHeader)
        Me.GroupBox3.Controls.Add(Me.cmbHeader)
        Me.GroupBox3.Controls.Add(Me.cmdeventid)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 46)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(370, 62)
        Me.GroupBox3.TabIndex = 1250
        Me.GroupBox3.TabStop = False
        '
        'cmbSubHeader
        '
        Me.cmbSubHeader.FormattingEnabled = True
        Me.cmbSubHeader.Items.AddRange(New Object() {"Aquatics Diving", "Aquatics MarathonSwimming", "Aquatics Swimming", "Aquatics SynchrosedSwimming", "Aquatics WaterPolo", "Archery", "Athletics", "Athletics - Marathon & Race Walks", "Badminton", "Basketball", "BeachVolleyball", "Boxing", "Canoe Slalom", "Canoe Sprint", "Cycling BMX", "Cycling Mountain Bike", "Cycling RoadRace & Time Trial", "Cycling Track", "Equestrian", "Fencing", "Football", "Gymnastics Artistic", "Gymnastics Rhythmic", "Gymnastics Trampoline", "Handball", "Hockey", "Judo", "ModernPentathlon", "Rowing", "Sailing", "Shooting", "Table Tennis", "Taekwondo", "Tennis", "Triathlon", "Volleyball", "Weightlifting", "Wrestling", "", "", "AR Archery", "Men’s Individual", "Men’s Team", "Women’s Individual", "Women’s Team", "", "AT Athletics", "Men’s 100m", "Men’s 200m", "Men’s 400m", "Men’s 800m", "Men’s 1500m", "Men’s 5000m", "Men’s 10000m", "Men’s 110m Hurdles", "Men’s 400m Hurdles", "Men’s 3000m Steeplechase", "Men’s 4x100m Relay", "Men’s 4x400m Relay", "Men’s High Jump", "Men’s Pole Vault", "Men’s Long Jump", "Men’s Triple Jump", "Men’s Shot Put", "Men’s Discus", "Men’s Hammer", "Men’s Javelin", "", "Decathlon", "Men’s Marathon", "Men’s 20km Race Walk", "Men’s 50km Race Walk", "Women’s 100m", "Women’s 200m", "Women’s 400m", "Women’s 800m", "Women’s 1500m", "Women’s 5000m", "Women’s 10000m", "Women’s 100m Hurdles", "Women’s 400m Hurdles", "Women’s 3000m Steeplechase", "Women’s 4x100m Relay", "Women’s 4x400m Relay", "Women’s High Jump", "Women’s Pole Vault", "Women’s Long Jump", "Women’s Triple Jump", "Women’s Shot Put", "Women’s Discus", "Women’s Hammer", "Women’s Javelin", "", "Heptathlon", "Women’s Marathon", "Women’s 20km Race Walk", "BD Badminton", "Men’s Singles", "Men’s Doubles", "Women’s Singles", "Women’s Doubles", "Mixed Doubles", "", "BK Basketball ", "Men’s Basketball ", "Women’s Basketball", "BV Beach Volleyball ", "Men’s Beach Volleyball ", "Women’s Beach Volleyball", "", "BX Boxing", "Men’s Light Fly 49kg", "Men’s Fly 52kg", "Men’s Bantam 56kg", "Men’s Light 60kg", "Men’s Light Welter 64kg", "Men’s Welter 69kg", "Men’s Middle 75kg", "Men’s Light Heavy 81kg", "Men’s Heavy 91kg", "Men’s Super Heavy +91kg", "Women’s Fly 51kg", "Women’s Light 60kg", "Women’s Middle 75kg", "", "CB BMX ", "Men’s BMX ", "Women’s BMX", "", "CF Canoe Sprint", "Men’s Kayak Single 200m", "Men’s Kayak Double 200m", "Men’s Kayak Single 1000m", "Men’s Kayak Double 1000m", "Men’s Kayak Four 1000m", "Men’s Canoe Single 200m", "Men’s Canoe Single 1000m", "Men’s Canoe Double 1000m", "Women’s Kayak Single 200m", "Women’s Kayak Single 500m", "Women’s Kayak Double 500m", "Women’s Kayak Four 500m", "", "CM Mountain Bike ", "Men’s Mountain Bike ", "Women’s Mountain Bike", "", "CR Cycling Road", "Men’s Road Race", "Men’s Individual Time Trial", "Women’s Road Race", "Women’s Individual Time Trial", "", "CS Canoe Slalom", "Men’s Canoe Single", "Men’s Canoe Double", "Men’s Kayak", "Women’s Kayak", "", "CT Cycling Track", "Men’s Keirin", "Men’s Omnium", "Men’s Sprint", "Men’s Team Pursuit", "Men’s Team Sprint", "Women’s Keirin", "Women’s Omnium", "Women’s Sprint", "Women’s Team Pursuit", "Women’s Team Sprint", "", "DV Diving", "Men’s 3m Springboard", "Men’s 10m Platform", "Women’s 3m Springboard", "Women’s 10m Platform", "Men’s Synchronised 3m Springboard", "Men’s Synchronised 10m Platform", "Women’s Synchronised 3m Springboard", "Women’s Synchronised 10m Platform", "", "EQ Equestrian", "Individual Dressage", "Individual Eventing", "Individual Jumping", "Team Dressage", "Team Eventing", "Team Jumping", "FB Football Men’s Football Women’s Football", "", "FE Fencing", "Men’s Individual Epee", "Men’s Individual Foil", "Men’s Individual Sabre", "Men’s Team Foil", "Men’s Team Sabre", "Women’s Individual Epee", "Women’s Individual Foil", "Women’s Individual Sabre", "Women’s Team Foil", "Women’s Team Epee", "", "GA Artistic Gymnastics", "Men’s Qualification", "Men’s Team Final", "Men’s All-Around Final", "Men’s Floor Exercise Final", "Men’s Vault Final", "Men’s Parallel Bars Final", "Men’s Horizontal Bar Final", "Men’s Rings Final", "Men’s Pommel Horse Final", "Women’s Qualification", "Women’s Team Final", "Women’s All-Around Final", "Women’s Floor Exercise Final", "Women’s Vault Final", "Women’s Uneven Bars Final", "Women’s Beam Final", "", "GR Rhythmic Gymnastics ", "Individual All-Around", "Group All-Around", "", "GT ", "Men’s Trampoline ", "Women’s Trampoline", "", "HB Handball ", "Men’s Handball ", "Women’s Handball", "", "HO Hockey ", "Men’s Hockey ", "Women’s Hockey", "", "JU Judo", "Men’s -60kg", "Men’s -66kg", "Men’s -73kg", "Men’s -81kg", "Men’s -90kg", "Men’s -100kg", "Men’s +100kg", "Women’s -48kg", "Women’s -52kg", "Women’s -57kg", "Women’s -63kg", "Women’s -70kg", "Women’s -78kg", "Women’s +78kg", "", "MP Modern Pentathlon", "Men’s Modern Pentathlon ", "Women’s Modern Pentathlon", "", "RO Rowing", "Men’s Single Sculls", "Men’s Double Sculls", "Lightweight Men’s Double Sculls", "Men’s Quadruple Sculls", "Men’s Pair", "Men’s Four", "Lightweight Men’s Four", "Men’s Eight", "Women’s Single Sculls", "Women’s Double Sculls", "Lightweight Women’s Double Sculls", "Women’s Quadruple Sculls", "Women’s Pair", "Women’s Eight", "", "SA Sailing", "Men’s Finn", "Men’s Laser", "Men’s 470", "Men’s Star", "Men’s 49er", "Men’s RS:X Windsurfer", "Women’s 470", "Women’s Laser Radial", "Women’s RS:X Windsurfer", "Women’s Elliott 6m", "", "SH Shooting", "Men’s 50m Rifle 3 Positions", "Men’s 50m Rifle Prone", "Men’s 10m Air Rifle", "Men’s 50m Pistol", "Men’s 25m Rapid Fire Pistol", "Men’s 10m Air Pistol", "Men’s Trap", "Men’s Double Trap", "Men’s Skeet", "Women’s 50m Rifle 3 Positions", "Women’s 10m Air Rifle", "Women’s 25m Pistol", "Women’s 10m Air Pistol", "Women’s Trap", "Women’s Skeet", "", "SW Swimming", "Men’s 50m Freestyle", "Men’s 100m Freestyle", "Men’s 200m Freestyle", "Men’s 400m Freestyle", "Men’s 1500m Freestyle", "Men’s 100m Butterfly", "Men’s 200m Butterfly", "Men’s 100m Breaststroke", "Men’s 200m Breaststroke", "Men’s 100m Backstroke", "Men’s 200m Backstroke", "Men’s 200m Individual Medley", "Men’s 400m Individual Medley", "Men’s 4x100m Freestyle Relay", "Men’s 4x200m Freestyle Relay", "Men’s 4x100m Medley Relay", "Men’s Marathon 10km", "Women’s 50m Freestyle", "Women’s 100m Freestyle", "Women’s 200m Freestyle", "Women’s 400m Freestyle", "Women’s 800m Freestyle", "Women’s 100m Butterfly", "Women’s 200m Butterfly", "Women’s 100m Breaststroke", "Women’s 200m Breaststroke", "Women’s 100m Backstroke", "Women’s 200m Backstroke", "Women’s 200m Individual Medley", "Women’s 400m Individual Medley", "Women’s 4x100m Freestyle Relay", "Women’s 4x200m Freestyle Relay", "Women’s 4x100m Medley Relay", "Women’s Marathon 10km", "SY Synchronised Swimming Duets Teams", "", "TE Tennis", "Men’s Singles", "Men’s Doubles", "Women’s Singles", "Women’s Doubles", "Mixed Doubles", "", "TK Taekwondo", "Men’s -58kg", "Men’s -68kg", "Men’s -80kg", "Men’s +80kg", "Women’s -49kg", "Women’s -57kg", "Women’s -67kg", "Women’s +67kg", "TR Triathlon Men’s ", "Triathlon Women’s Triathlon", "", "TT Table Tennis", "Men’s Singles", "Men’s Team", "Women’s Singles", "Women’s Team", "", "", "", "VO Volleyball ", "Men’s Volleyball ", "Women’s Volleyball", "", "WL Weightlifting", "Men’s 56kg", "Men’s 62kg", "Men’s 69kg", "Men’s 77kg", "Men’s 85kg", "Men’s 94kg", "Men’s 105kg", "Men’s +105kg", "Women’s 48kg", "Women’s 53kg", "Women’s 58kg", "Women’s 63kg", "Women’s 69kg", "Women’s 75kg", "Women’s +75kg", "WP Water Polo ", "Men’s Water Polo ", "Women’s Water Polo", "", "WR Wrestling", "Men’s Freestyle 55kg", "Men’s Freestyle 60kg", "Men’s Freestyle 66kg", "Men’s Freestyle 74kg", "Men’s Freestyle 84kg", "Men’s Freestyle 96kg", "Men’s Freestyle 120kg", "Men’s Greco-Roman 55kg", "Men’s Greco-Roman 60kg", "Men’s Greco-Roman 66kg", "Men’s Greco-Roman 74kg", "Men’s Greco-Roman 84kg", "Men’s Greco-Roman 96kg", "Men’s Greco-Roman 120kg", "", "", "", "Round 1", "Round 2", "Round 3", "Round 4", "Round 5", "Leage Match", "Preliminary Match", "Pre Quarter Final", "Quarter Final", "Semi Final", "Final", "", "Table 1 - Round 3 (Morning Session)", "Table 1 - Round 3 (After noon Session)", "Table 1 - Round 1", "Table 1 - Round 1 (First Session)", "Table 1 - Round 2", "", "Men's Singles", "Women's Singles", "Men's Doubles", "Women's Doubles", "Team Event", "", "Junior Girls Team", "Junior Boys Team", "Cadet Girls Team", "Cadet Boys Team", "", "Junior Girls", "Junior Boys", "Cadet Girls", "Cadet Boys", "", "Junior Mixed Doubles", "Junior Boys Doubles", "Junior Girls Doubles", "Qualifying  - RD1", "Position 9-13", "", "Stage 1 Round 1"})
        Me.cmbSubHeader.Location = New System.Drawing.Point(78, 35)
        Me.cmbSubHeader.Name = "cmbSubHeader"
        Me.cmbSubHeader.Size = New System.Drawing.Size(221, 21)
        Me.cmbSubHeader.TabIndex = 1201
        Me.cmbSubHeader.Text = "2nd Semifinal"
        '
        'cmbHeader
        '
        Me.cmbHeader.FormattingEnabled = True
        Me.cmbHeader.Items.AddRange(New Object() {"Aquatics Diving", "Aquatics MarathonSwimming", "Aquatics Swimming", "Aquatics SynchrosedSwimming", "Aquatics WaterPolo", "Archery", "Athletics", "Athletics - Marathon & Race Walks", "Badminton", "Basketball", "BeachVolleyball", "Boxing", "Kickboxing", "Canoe Slalom", "Canoe Sprint", "Cycling BMX", "Cycling Mountain Bike", "Cycling RoadRace & Time Trial", "Cycling Track", "Equestrian", "Fencing", "Football", "Gymnastics Artistic", "Gymnastics Rhythmic", "Gymnastics Trampoline", "Handball", "Hockey", "Judo", "ModernPentathlon", "Rowing", "Sailing", "Shooting", "Table Tennis", "Taekwondo", "Tennis", "Triathlon", "Volleyball", "Weightlifting", "Wrestling", "", "", "AR Archery", "Men’s Individual", "Men’s Team", "Women’s Individual", "Women’s Team", "", "AT Athletics", "Men’s 100m", "Men’s 200m", "Men’s 400m", "Men’s 800m", "Men’s 1500m", "Men’s 5000m", "Men’s 10000m", "Men’s 110m Hurdles", "Men’s 400m Hurdles", "Men’s 3000m Steeplechase", "Men’s 4x100m Relay", "Men’s 4x400m Relay", "Men’s High Jump", "Men’s Pole Vault", "Men’s Long Jump", "Men’s Triple Jump", "Men’s Shot Put", "Men’s Discus", "Men’s Hammer", "Men’s Javelin", "", "Decathlon", "Men’s Marathon", "Men’s 20km Race Walk", "Men’s 50km Race Walk", "Women’s 100m", "Women’s 200m", "Women’s 400m", "Women’s 800m", "Women’s 1500m", "Women’s 5000m", "Women’s 10000m", "Women’s 100m Hurdles", "Women’s 400m Hurdles", "Women’s 3000m Steeplechase", "Women’s 4x100m Relay", "Women’s 4x400m Relay", "Women’s High Jump", "Women’s Pole Vault", "Women’s Long Jump", "Women’s Triple Jump", "Women’s Shot Put", "Women’s Discus", "Women’s Hammer", "Women’s Javelin", "", "Heptathlon", "Women’s Marathon", "Women’s 20km Race Walk", "BD Badminton", "Men’s Singles", "Men’s Doubles", "Women’s Singles", "Women’s Doubles", "Mixed Doubles", "", "BK Basketball ", "Men’s Basketball ", "Women’s Basketball", "BV Beach Volleyball ", "Men’s Beach Volleyball ", "Women’s Beach Volleyball", "", "BX Boxing", "Men’s Light Fly 49kg", "Men’s Fly 52kg", "Men’s Bantam 56kg", "Men’s Light 60kg", "Men’s Light Welter 64kg", "Men’s Welter 69kg", "Men’s Middle 75kg", "Men’s Light Heavy 81kg", "Men’s Heavy 91kg", "Men’s Super Heavy +91kg", "Women’s Fly 51kg", "Women’s Light 60kg", "Women’s Middle 75kg", "", "CB BMX ", "Men’s BMX ", "Women’s BMX", "", "CF Canoe Sprint", "Men’s Kayak Single 200m", "Men’s Kayak Double 200m", "Men’s Kayak Single 1000m", "Men’s Kayak Double 1000m", "Men’s Kayak Four 1000m", "Men’s Canoe Single 200m", "Men’s Canoe Single 1000m", "Men’s Canoe Double 1000m", "Women’s Kayak Single 200m", "Women’s Kayak Single 500m", "Women’s Kayak Double 500m", "Women’s Kayak Four 500m", "", "CM Mountain Bike ", "Men’s Mountain Bike ", "Women’s Mountain Bike", "", "CR Cycling Road", "Men’s Road Race", "Men’s Individual Time Trial", "Women’s Road Race", "Women’s Individual Time Trial", "", "CS Canoe Slalom", "Men’s Canoe Single", "Men’s Canoe Double", "Men’s Kayak", "Women’s Kayak", "", "CT Cycling Track", "Men’s Keirin", "Men’s Omnium", "Men’s Sprint", "Men’s Team Pursuit", "Men’s Team Sprint", "Women’s Keirin", "Women’s Omnium", "Women’s Sprint", "Women’s Team Pursuit", "Women’s Team Sprint", "", "DV Diving", "Men’s 3m Springboard", "Men’s 10m Platform", "Women’s 3m Springboard", "Women’s 10m Platform", "Men’s Synchronised 3m Springboard", "Men’s Synchronised 10m Platform", "Women’s Synchronised 3m Springboard", "Women’s Synchronised 10m Platform", "", "EQ Equestrian", "Individual Dressage", "Individual Eventing", "Individual Jumping", "Team Dressage", "Team Eventing", "Team Jumping", "FB Football Men’s Football Women’s Football", "", "FE Fencing", "Men’s Individual Epee", "Men’s Individual Foil", "Men’s Individual Sabre", "Men’s Team Foil", "Men’s Team Sabre", "Women’s Individual Epee", "Women’s Individual Foil", "Women’s Individual Sabre", "Women’s Team Foil", "Women’s Team Epee", "", "GA Artistic Gymnastics", "Men’s Qualification", "Men’s Team Final", "Men’s All-Around Final", "Men’s Floor Exercise Final", "Men’s Vault Final", "Men’s Parallel Bars Final", "Men’s Horizontal Bar Final", "Men’s Rings Final", "Men’s Pommel Horse Final", "Women’s Qualification", "Women’s Team Final", "Women’s All-Around Final", "Women’s Floor Exercise Final", "Women’s Vault Final", "Women’s Uneven Bars Final", "Women’s Beam Final", "", "GR Rhythmic Gymnastics ", "Individual All-Around", "Group All-Around", "", "GT ", "Men’s Trampoline ", "Women’s Trampoline", "", "HB Handball ", "Men’s Handball ", "Women’s Handball", "", "HO Hockey ", "Men’s Hockey ", "Women’s Hockey", "", "JU Judo", "Men’s -60kg", "Men’s -66kg", "Men’s -73kg", "Men’s -81kg", "Men’s -90kg", "Men’s -100kg", "Men’s +100kg", "Women’s -48kg", "Women’s -52kg", "Women’s -57kg", "Women’s -63kg", "Women’s -70kg", "Women’s -78kg", "Women’s +78kg", "", "MP Modern Pentathlon", "Men’s Modern Pentathlon ", "Women’s Modern Pentathlon", "", "RO Rowing", "Men’s Single Sculls", "Men’s Double Sculls", "Lightweight Men’s Double Sculls", "Men’s Quadruple Sculls", "Men’s Pair", "Men’s Four", "Lightweight Men’s Four", "Men’s Eight", "Women’s Single Sculls", "Women’s Double Sculls", "Lightweight Women’s Double Sculls", "Women’s Quadruple Sculls", "Women’s Pair", "Women’s Eight", "", "SA Sailing", "Men’s Finn", "Men’s Laser", "Men’s 470", "Men’s Star", "Men’s 49er", "Men’s RS:X Windsurfer", "Women’s 470", "Women’s Laser Radial", "Women’s RS:X Windsurfer", "Women’s Elliott 6m", "", "SH Shooting", "Men’s 50m Rifle 3 Positions", "Men’s 50m Rifle Prone", "Men’s 10m Air Rifle", "Men’s 50m Pistol", "Men’s 25m Rapid Fire Pistol", "Men’s 10m Air Pistol", "Men’s Trap", "Men’s Double Trap", "Men’s Skeet", "Women’s 50m Rifle 3 Positions", "Women’s 10m Air Rifle", "Women’s 25m Pistol", "Women’s 10m Air Pistol", "Women’s Trap", "Women’s Skeet", "", "SW Swimming", "Men’s 50m Freestyle", "Men’s 100m Freestyle", "Men’s 200m Freestyle", "Men’s 400m Freestyle", "Men’s 1500m Freestyle", "Men’s 100m Butterfly", "Men’s 200m Butterfly", "Men’s 100m Breaststroke", "Men’s 200m Breaststroke", "Men’s 100m Backstroke", "Men’s 200m Backstroke", "Men’s 200m Individual Medley", "Men’s 400m Individual Medley", "Men’s 4x100m Freestyle Relay", "Men’s 4x200m Freestyle Relay", "Men’s 4x100m Medley Relay", "Men’s Marathon 10km", "Women’s 50m Freestyle", "Women’s 100m Freestyle", "Women’s 200m Freestyle", "Women’s 400m Freestyle", "Women’s 800m Freestyle", "Women’s 100m Butterfly", "Women’s 200m Butterfly", "Women’s 100m Breaststroke", "Women’s 200m Breaststroke", "Women’s 100m Backstroke", "Women’s 200m Backstroke", "Women’s 200m Individual Medley", "Women’s 400m Individual Medley", "Women’s 4x100m Freestyle Relay", "Women’s 4x200m Freestyle Relay", "Women’s 4x100m Medley Relay", "Women’s Marathon 10km", "SY Synchronised Swimming Duets Teams", "", "TE Tennis", "Men’s Singles", "Men’s Doubles", "Women’s Singles", "Women’s Doubles", "Mixed Doubles", "", "TK Taekwondo", "Men’s -58kg", "Men’s -68kg", "Men’s -80kg", "Men’s +80kg", "Women’s -49kg", "Women’s -57kg", "Women’s -67kg", "Women’s +67kg", "TR Triathlon Men’s ", "Triathlon Women’s Triathlon", "", "TT Table Tennis", "Men’s Singles", "Men’s Team", "Women’s Singles", "Women’s Team", "", "", "", "VO Volleyball ", "Men’s Volleyball ", "Women’s Volleyball", "", "WL Weightlifting", "Men’s 56kg", "Men’s 62kg", "Men’s 69kg", "Men’s 77kg", "Men’s 85kg", "Men’s 94kg", "Men’s 105kg", "Men’s +105kg", "Women’s 48kg", "Women’s 53kg", "Women’s 58kg", "Women’s 63kg", "Women’s 69kg", "Women’s 75kg", "Women’s +75kg", "WP Water Polo ", "Men’s Water Polo ", "Women’s Water Polo", "", "WR Wrestling", "Men’s Freestyle 55kg", "Men’s Freestyle 60kg", "Men’s Freestyle 66kg", "Men’s Freestyle 74kg", "Men’s Freestyle 84kg", "Men’s Freestyle 96kg", "Men’s Freestyle 120kg", "Men’s Greco-Roman 55kg", "Men’s Greco-Roman 60kg", "Men’s Greco-Roman 66kg", "Men’s Greco-Roman 74kg", "Men’s Greco-Roman 84kg", "Men’s Greco-Roman 96kg", "Men’s Greco-Roman 120kg", "", "", "", "Table Tennis", "Reliance 20th Asian Junior Table Tennis", "", "Table 1 - Round 3 (Morning Session)", "Table 1 - Round 3 (After noon Session)", "Table 1 - Round 1", "Table 1 - Round 1 (First Session)", "Table 1 - Round 2", "", "Men's Singles", "Women's Singles", "Men's Doubles", "Women's Doubles", "Team Event", "", "", "Round 1", "Round 2", "Round 3", "Round 4", "Round 5", "Leage Match", "Preliminary Match", "Pre Quarter Final", "Quarter Final", "Semi Final", "Final", "", "Mixed Doubles", "", "Junior Girls Team", "Junior Boys Team", "Cadet Girls Team", "Cadet Boys Team", "", "Junior Girls", "Junior Boys", "Cadet Girls", "Cadet Boys", "", "Junior Mixed Doubles", "Junior Boys Doubles", "Junior Girls Doubles", "Qualifying  - RD1", "Position 9-13", "", "Stage 1 Round 1"})
        Me.cmbHeader.Location = New System.Drawing.Point(78, 11)
        Me.cmbHeader.Name = "cmbHeader"
        Me.cmbHeader.Size = New System.Drawing.Size(221, 21)
        Me.cmbHeader.TabIndex = 1200
        Me.cmbHeader.Text = "14th D Y PATIL T20 CUP"
        '
        'cmdeventid
        '
        Me.cmdeventid.BackColor = System.Drawing.Color.Green
        Me.cmdeventid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdeventid.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdeventid.Location = New System.Drawing.Point(305, 12)
        Me.cmdeventid.Name = "cmdeventid"
        Me.cmdeventid.Size = New System.Drawing.Size(62, 45)
        Me.cmdeventid.TabIndex = 1199
        Me.cmdeventid.Text = "Event Id"
        Me.cmdeventid.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 13)
        Me.Label17.TabIndex = 1174
        Me.Label17.Text = "Sub Header"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1173
        Me.Label1.Text = "MAin Header"
        '
        'cmbgames
        '
        Me.cmbgames.FormattingEnabled = True
        Me.cmbgames.Items.AddRange(New Object() {"Aquatics", "Atheletics", "Badminton", "Basketball", "Black", "Boxing", "Cricket", "Football", "Gymnastics - Artistic", "Gymnastics - Rhythmic", "Gymnastics - Trampoline", "Handball", "hockey", "Kabaddi", "Shooting", "TableTennis", "Tennis", "Volleyball", "Weight lift", "Wrestling"})
        Me.cmbgames.Location = New System.Drawing.Point(267, 18)
        Me.cmbgames.Name = "cmbgames"
        Me.cmbgames.Size = New System.Drawing.Size(134, 21)
        Me.cmbgames.Sorted = True
        Me.cmbgames.TabIndex = 1252
        Me.cmbgames.Text = "Cricket"
        '
        'eventlogo
        '
        Me.eventlogo.BackColor = System.Drawing.SystemColors.Highlight
        Me.eventlogo.ImageLocation = "C:\casparcg\mydata\games\event logo\dyp.png"
        Me.eventlogo.Location = New System.Drawing.Point(433, 21)
        Me.eventlogo.Name = "eventlogo"
        Me.eventlogo.Size = New System.Drawing.Size(24, 17)
        Me.eventlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.eventlogo.TabIndex = 1168
        Me.eventlogo.TabStop = False
        '
        'gamelogo
        '
        Me.gamelogo.BackColor = System.Drawing.SystemColors.Highlight
        Me.gamelogo.ImageLocation = "C:/casparcg/mydata/games/games logo/cri1.png"
        Me.gamelogo.Location = New System.Drawing.Point(407, 19)
        Me.gamelogo.Name = "gamelogo"
        Me.gamelogo.Size = New System.Drawing.Size(22, 19)
        Me.gamelogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.gamelogo.TabIndex = 1166
        Me.gamelogo.TabStop = False
        '
        'cmdstopgym
        '
        Me.cmdstopgym.BackColor = System.Drawing.Color.Red
        Me.cmdstopgym.Location = New System.Drawing.Point(1169, 136)
        Me.cmdstopgym.Name = "cmdstopgym"
        Me.cmdstopgym.Size = New System.Drawing.Size(47, 743)
        Me.cmdstopgym.TabIndex = 585
        Me.cmdstopgym.Text = "Stop"
        Me.cmdstopgym.UseVisualStyleBackColor = False
        '
        'chkanimationzym
        '
        Me.chkanimationzym.AutoSize = True
        Me.chkanimationzym.Checked = True
        Me.chkanimationzym.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkanimationzym.Location = New System.Drawing.Point(113, 20)
        Me.chkanimationzym.Name = "chkanimationzym"
        Me.chkanimationzym.Size = New System.Drawing.Size(72, 17)
        Me.chkanimationzym.TabIndex = 1182
        Me.chkanimationzym.Text = "Animation"
        Me.chkanimationzym.UseVisualStyleBackColor = True
        '
        'chkanimationforhdvan
        '
        Me.chkanimationforhdvan.AutoSize = True
        Me.chkanimationforhdvan.Location = New System.Drawing.Point(182, 20)
        Me.chkanimationforhdvan.Name = "chkanimationforhdvan"
        Me.chkanimationforhdvan.Size = New System.Drawing.Size(82, 17)
        Me.chkanimationforhdvan.TabIndex = 1183
        Me.chkanimationforhdvan.Text = "For HD Van"
        Me.chkanimationforhdvan.UseVisualStyleBackColor = True
        '
        'cmdaddoutput
        '
        Me.cmdaddoutput.Location = New System.Drawing.Point(552, 18)
        Me.cmdaddoutput.Name = "cmdaddoutput"
        Me.cmdaddoutput.Size = New System.Drawing.Size(71, 22)
        Me.cmdaddoutput.TabIndex = 1254
        Me.cmdaddoutput.Text = "Add Output"
        Me.cmdaddoutput.UseVisualStyleBackColor = True
        '
        'cmdremoveoutput
        '
        Me.cmdremoveoutput.Location = New System.Drawing.Point(460, 18)
        Me.cmdremoveoutput.Name = "cmdremoveoutput"
        Me.cmdremoveoutput.Size = New System.Drawing.Size(91, 22)
        Me.cmdremoveoutput.TabIndex = 1253
        Me.cmdremoveoutput.Text = "Remove Output"
        Me.cmdremoveoutput.UseVisualStyleBackColor = True
        '
        'cmdsd
        '
        Me.cmdsd.Location = New System.Drawing.Point(626, 18)
        Me.cmdsd.Name = "cmdsd"
        Me.cmdsd.Size = New System.Drawing.Size(39, 22)
        Me.cmdsd.TabIndex = 1255
        Me.cmdsd.Text = "SD"
        Me.cmdsd.UseVisualStyleBackColor = True
        '
        'cmdhd
        '
        Me.cmdhd.Location = New System.Drawing.Point(665, 18)
        Me.cmdhd.Name = "cmdhd"
        Me.cmdhd.Size = New System.Drawing.Size(39, 22)
        Me.cmdhd.TabIndex = 1256
        Me.cmdhd.Text = "HD"
        Me.cmdhd.UseVisualStyleBackColor = True
        '
        'cmdsqueezeforsafesd
        '
        Me.cmdsqueezeforsafesd.Location = New System.Drawing.Point(706, 19)
        Me.cmdsqueezeforsafesd.Name = "cmdsqueezeforsafesd"
        Me.cmdsqueezeforsafesd.Size = New System.Drawing.Size(59, 22)
        Me.cmdsqueezeforsafesd.TabIndex = 1257
        Me.cmdsqueezeforsafesd.Text = "Squeeze"
        Me.cmdsqueezeforsafesd.UseVisualStyleBackColor = True
        '
        'cmdfillnormal
        '
        Me.cmdfillnormal.Location = New System.Drawing.Point(769, 20)
        Me.cmdfillnormal.Name = "cmdfillnormal"
        Me.cmdfillnormal.Size = New System.Drawing.Size(59, 22)
        Me.cmdfillnormal.TabIndex = 1262
        Me.cmdfillnormal.Text = "Normal"
        Me.cmdfillnormal.UseVisualStyleBackColor = True
        '
        'tmrtimeonform
        '
        Me.tmrtimeonform.Interval = 1000
        '
        'tmrtimeupdateontemplate
        '
        Me.tmrtimeupdateontemplate.Interval = 1000
        '
        'tmrupdateontemplateextra
        '
        Me.tmrupdateontemplateextra.Interval = 1000
        '
        'Cricket
        '
        Me.Cricket.Controls.Add(Me.txt3liner3)
        Me.Cricket.Controls.Add(Me.txt3liner2)
        Me.Cricket.Controls.Add(Me.txt3liner1)
        Me.Cricket.Controls.Add(Me.cmd3liner)
        Me.Cricket.Controls.Add(Me.txttwoliner2)
        Me.Cricket.Controls.Add(Me.txttwoliner1)
        Me.Cricket.Controls.Add(Me.cmdtwoliner)
        Me.Cricket.Controls.Add(Me.txtoneliner)
        Me.Cricket.Controls.Add(Me.cmdonliner)
        Me.Cricket.Controls.Add(Me.cmbinfo7)
        Me.Cricket.Controls.Add(Me.cmdscore7update)
        Me.Cricket.Controls.Add(Me.txtinfo7)
        Me.Cricket.Controls.Add(Me.cmdscore7)
        Me.Cricket.Controls.Add(Me.cmbinfo6)
        Me.Cricket.Controls.Add(Me.cmdscore6update)
        Me.Cricket.Controls.Add(Me.txtinfo6)
        Me.Cricket.Controls.Add(Me.cmdscore6)
        Me.Cricket.Controls.Add(Me.cmbinfo5)
        Me.Cricket.Controls.Add(Me.cmdscore5update)
        Me.Cricket.Controls.Add(Me.txtinfo5)
        Me.Cricket.Controls.Add(Me.cmdscore5)
        Me.Cricket.Controls.Add(Me.cmbinfo4)
        Me.Cricket.Controls.Add(Me.cmdscore4update)
        Me.Cricket.Controls.Add(Me.txtinfo4)
        Me.Cricket.Controls.Add(Me.cmdscore4)
        Me.Cricket.Controls.Add(Me.cmbinfo3)
        Me.Cricket.Controls.Add(Me.cmdscore3update)
        Me.Cricket.Controls.Add(Me.txtinfo3)
        Me.Cricket.Controls.Add(Me.cmdscore3)
        Me.Cricket.Controls.Add(Me.dgvFOW)
        Me.Cricket.Controls.Add(Me.GroupBox4)
        Me.Cricket.Controls.Add(Me.GroupBox1)
        Me.Cricket.Controls.Add(Me.chkStrinkingPostionB)
        Me.Cricket.Controls.Add(Me.chkStrinkingPostionA)
        Me.Cricket.Controls.Add(Me.cmdscore2update)
        Me.Cricket.Controls.Add(Me.cmdscore1update)
        Me.Cricket.Controls.Add(Me.cmdscoreupdate)
        Me.Cricket.Controls.Add(Me.Label97)
        Me.Cricket.Controls.Add(Me.pict2logocricket)
        Me.Cricket.Controls.Add(Me.pict1logocricket)
        Me.Cricket.Controls.Add(Me.cmdclearbatsmanstatics)
        Me.Cricket.Controls.Add(Me.cmdrowdeletebatsman)
        Me.Cricket.Controls.Add(Me.cmdrowinsertbatsman)
        Me.Cricket.Controls.Add(Me.tstwoliner)
        Me.Cricket.Controls.Add(Me.cmdrowdownbatsman)
        Me.Cricket.Controls.Add(Me.cmdrowupbatsman)
        Me.Cricket.Controls.Add(Me.txtinfo1)
        Me.Cricket.Controls.Add(Me.txtinfo2)
        Me.Cricket.Controls.Add(Me.cmbinfo2)
        Me.Cricket.Controls.Add(Me.cmbinfo1)
        Me.Cricket.Controls.Add(Me.txtnb)
        Me.Cricket.Controls.Add(Me.txtwd)
        Me.Cricket.Controls.Add(Me.txtlb)
        Me.Cricket.Controls.Add(Me.txtby)
        Me.Cricket.Controls.Add(Me.txttotalextra)
        Me.Cricket.Controls.Add(Me.txttotalbatsmanvalue)
        Me.Cricket.Controls.Add(Me.txttotalbatsman)
        Me.Cricket.Controls.Add(Me.txtoversbatman)
        Me.Cricket.Controls.Add(Me.txtextrabatmanvalue)
        Me.Cricket.Controls.Add(Me.txtextrabatman)
        Me.Cricket.Controls.Add(Me.txtoversbatmanvalue)
        Me.Cricket.Controls.Add(Me.txtteamnameb)
        Me.Cricket.Controls.Add(Me.txtteamnamea)
        Me.Cricket.Controls.Add(Me.txtthisover)
        Me.Cricket.Controls.Add(Me.txtlastwicketat)
        Me.Cricket.Controls.Add(Me.txtmatchover)
        Me.Cricket.Controls.Add(Me.txt1stinningscore)
        Me.Cricket.Controls.Add(Me.txtover)
        Me.Cricket.Controls.Add(Me.txtinfo)
        Me.Cricket.Controls.Add(Me.txtwicket)
        Me.Cricket.Controls.Add(Me.txtovers)
        Me.Cricket.Controls.Add(Me.txtrun)
        Me.Cricket.Controls.Add(Me.txtteamname)
        Me.Cricket.Controls.Add(Me.Label85)
        Me.Cricket.Controls.Add(Me.cmdplayeridbatsman)
        Me.Cricket.Controls.Add(Me.dgvbowler)
        Me.Cricket.Controls.Add(Me.dgvbatsman)
        Me.Cricket.Controls.Add(Me.Label86)
        Me.Cricket.Controls.Add(Me.cmdscore2)
        Me.Cricket.Controls.Add(Me.cmdscore1)
        Me.Cricket.Controls.Add(Me.cmdcleardatascore)
        Me.Cricket.Controls.Add(Me.Label88)
        Me.Cricket.Controls.Add(Me.cmdcleardatabowlerstatics)
        Me.Cricket.Controls.Add(Me.lblfilenamebowler)
        Me.Cricket.Controls.Add(Me.cmdbowlerstatus)
        Me.Cricket.Controls.Add(Me.cmdplayeridbowler)
        Me.Cricket.Controls.Add(Me.cmdbatsmanstatus)
        Me.Cricket.Controls.Add(Me.cmdrowupbowler)
        Me.Cricket.Controls.Add(Me.cmdrowdownbowler)
        Me.Cricket.Controls.Add(Me.cmdrowinsertbowler)
        Me.Cricket.Controls.Add(Me.lblfilenamebatsman)
        Me.Cricket.Controls.Add(Me.cmdrowdeletebowler)
        Me.Cricket.Controls.Add(Me.ToolStrip4)
        Me.Cricket.Controls.Add(Me.cmdbowlingcard)
        Me.Cricket.Controls.Add(Me.Label90)
        Me.Cricket.Controls.Add(Me.Label91)
        Me.Cricket.Controls.Add(Me.Label92)
        Me.Cricket.Controls.Add(Me.Label93)
        Me.Cricket.Controls.Add(Me.Label94)
        Me.Cricket.Controls.Add(Me.Label95)
        Me.Cricket.Controls.Add(Me.cmdbattingcard)
        Me.Cricket.Controls.Add(Me.cmdteamlinupbowler)
        Me.Cricket.Controls.Add(Me.Label96)
        Me.Cricket.Controls.Add(Me.cmdteamlinupbatsman)
        Me.Cricket.Controls.Add(Me.lbllastwicketat)
        Me.Cricket.Controls.Add(Me.lblthisover)
        Me.Cricket.Controls.Add(Me.lblmatchover)
        Me.Cricket.Controls.Add(Me.lbl1stinningscore)
        Me.Cricket.Controls.Add(Me.cmbinfo)
        Me.Cricket.Controls.Add(Me.cmdover)
        Me.Cricket.Controls.Add(Me.cmdwicket)
        Me.Cricket.Controls.Add(Me.cmdrun)
        Me.Cricket.Controls.Add(Me.cmdscore)
        Me.Cricket.Location = New System.Drawing.Point(4, 22)
        Me.Cricket.Name = "Cricket"
        Me.Cricket.Size = New System.Drawing.Size(1149, 805)
        Me.Cricket.TabIndex = 7
        Me.Cricket.Text = "Cricket"
        Me.Cricket.UseVisualStyleBackColor = True
        '
        'txt3liner3
        '
        Me.txt3liner3.Location = New System.Drawing.Point(18, 723)
        Me.txt3liner3.Name = "txt3liner3"
        Me.txt3liner3.Size = New System.Drawing.Size(219, 20)
        Me.txt3liner3.TabIndex = 734
        Me.txt3liner3.Text = "Nerul, Navi Mumbai"
        Me.txt3liner3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3liner2
        '
        Me.txt3liner2.Location = New System.Drawing.Point(18, 697)
        Me.txt3liner2.Name = "txt3liner2"
        Me.txt3liner2.Size = New System.Drawing.Size(219, 20)
        Me.txt3liner2.TabIndex = 733
        Me.txt3liner2.Text = "D YPatil Stadium"
        Me.txt3liner2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3liner1
        '
        Me.txt3liner1.Location = New System.Drawing.Point(18, 673)
        Me.txt3liner1.Name = "txt3liner1"
        Me.txt3liner1.Size = New System.Drawing.Size(219, 20)
        Me.txt3liner1.TabIndex = 732
        Me.txt3liner1.Text = "Welcome To"
        Me.txt3liner1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmd3liner
        '
        Me.cmd3liner.BackColor = System.Drawing.Color.Green
        Me.cmd3liner.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd3liner.ForeColor = System.Drawing.Color.White
        Me.cmd3liner.Location = New System.Drawing.Point(243, 670)
        Me.cmd3liner.Name = "cmd3liner"
        Me.cmd3liner.Size = New System.Drawing.Size(57, 73)
        Me.cmd3liner.TabIndex = 731
        Me.cmd3liner.Text = "Play"
        Me.cmd3liner.UseVisualStyleBackColor = False
        '
        'txttwoliner2
        '
        Me.txttwoliner2.Location = New System.Drawing.Point(18, 644)
        Me.txttwoliner2.Name = "txttwoliner2"
        Me.txttwoliner2.Size = New System.Drawing.Size(219, 20)
        Me.txttwoliner2.TabIndex = 730
        Me.txttwoliner2.Text = "Engineering Assistant, DDK Mumbai"
        Me.txttwoliner2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttwoliner1
        '
        Me.txttwoliner1.Location = New System.Drawing.Point(18, 620)
        Me.txttwoliner1.Name = "txttwoliner1"
        Me.txttwoliner1.Size = New System.Drawing.Size(219, 20)
        Me.txttwoliner1.TabIndex = 729
        Me.txttwoliner1.Text = "Vimlesh Kumar"
        Me.txttwoliner1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdtwoliner
        '
        Me.cmdtwoliner.BackColor = System.Drawing.Color.Green
        Me.cmdtwoliner.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdtwoliner.ForeColor = System.Drawing.Color.White
        Me.cmdtwoliner.Location = New System.Drawing.Point(243, 617)
        Me.cmdtwoliner.Name = "cmdtwoliner"
        Me.cmdtwoliner.Size = New System.Drawing.Size(57, 47)
        Me.cmdtwoliner.TabIndex = 728
        Me.cmdtwoliner.Text = "Play"
        Me.cmdtwoliner.UseVisualStyleBackColor = False
        '
        'txtoneliner
        '
        Me.txtoneliner.Location = New System.Drawing.Point(18, 591)
        Me.txtoneliner.Name = "txtoneliner"
        Me.txtoneliner.Size = New System.Drawing.Size(219, 20)
        Me.txtoneliner.TabIndex = 727
        Me.txtoneliner.Text = "Vimlesh Kumar"
        Me.txtoneliner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdonliner
        '
        Me.cmdonliner.BackColor = System.Drawing.Color.Green
        Me.cmdonliner.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdonliner.ForeColor = System.Drawing.Color.White
        Me.cmdonliner.Location = New System.Drawing.Point(243, 588)
        Me.cmdonliner.Name = "cmdonliner"
        Me.cmdonliner.Size = New System.Drawing.Size(57, 25)
        Me.cmdonliner.TabIndex = 726
        Me.cmdonliner.Text = "Play"
        Me.cmdonliner.UseVisualStyleBackColor = False
        '
        'cmbinfo7
        '
        Me.cmbinfo7.Location = New System.Drawing.Point(756, 85)
        Me.cmbinfo7.Name = "cmbinfo7"
        Me.cmbinfo7.Size = New System.Drawing.Size(133, 20)
        Me.cmbinfo7.TabIndex = 725
        '
        'cmdscore7update
        '
        Me.cmdscore7update.BackColor = System.Drawing.Color.Yellow
        Me.cmdscore7update.Location = New System.Drawing.Point(1084, 82)
        Me.cmdscore7update.Name = "cmdscore7update"
        Me.cmdscore7update.Size = New System.Drawing.Size(57, 25)
        Me.cmdscore7update.TabIndex = 724
        Me.cmdscore7update.Text = "Update"
        Me.cmdscore7update.UseVisualStyleBackColor = False
        '
        'txtinfo7
        '
        Me.txtinfo7.Location = New System.Drawing.Point(895, 85)
        Me.txtinfo7.Name = "txtinfo7"
        Me.txtinfo7.Size = New System.Drawing.Size(120, 20)
        Me.txtinfo7.TabIndex = 723
        '
        'cmdscore7
        '
        Me.cmdscore7.BackColor = System.Drawing.Color.Green
        Me.cmdscore7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdscore7.ForeColor = System.Drawing.Color.White
        Me.cmdscore7.Location = New System.Drawing.Point(1021, 83)
        Me.cmdscore7.Name = "cmdscore7"
        Me.cmdscore7.Size = New System.Drawing.Size(57, 25)
        Me.cmdscore7.TabIndex = 722
        Me.cmdscore7.Text = "Play"
        Me.cmdscore7.UseVisualStyleBackColor = False
        '
        'cmbinfo6
        '
        Me.cmbinfo6.Location = New System.Drawing.Point(756, 61)
        Me.cmbinfo6.Name = "cmbinfo6"
        Me.cmbinfo6.Size = New System.Drawing.Size(133, 20)
        Me.cmbinfo6.TabIndex = 721
        '
        'cmdscore6update
        '
        Me.cmdscore6update.BackColor = System.Drawing.Color.Yellow
        Me.cmdscore6update.Location = New System.Drawing.Point(1084, 55)
        Me.cmdscore6update.Name = "cmdscore6update"
        Me.cmdscore6update.Size = New System.Drawing.Size(57, 25)
        Me.cmdscore6update.TabIndex = 720
        Me.cmdscore6update.Text = "Update"
        Me.cmdscore6update.UseVisualStyleBackColor = False
        '
        'txtinfo6
        '
        Me.txtinfo6.Location = New System.Drawing.Point(895, 58)
        Me.txtinfo6.Name = "txtinfo6"
        Me.txtinfo6.Size = New System.Drawing.Size(120, 20)
        Me.txtinfo6.TabIndex = 719
        '
        'cmdscore6
        '
        Me.cmdscore6.BackColor = System.Drawing.Color.Green
        Me.cmdscore6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdscore6.ForeColor = System.Drawing.Color.White
        Me.cmdscore6.Location = New System.Drawing.Point(1021, 56)
        Me.cmdscore6.Name = "cmdscore6"
        Me.cmdscore6.Size = New System.Drawing.Size(57, 25)
        Me.cmdscore6.TabIndex = 718
        Me.cmdscore6.Text = "Play"
        Me.cmdscore6.UseVisualStyleBackColor = False
        '
        'cmbinfo5
        '
        Me.cmbinfo5.Location = New System.Drawing.Point(756, 32)
        Me.cmbinfo5.Name = "cmbinfo5"
        Me.cmbinfo5.Size = New System.Drawing.Size(133, 20)
        Me.cmbinfo5.TabIndex = 717
        Me.cmbinfo5.Text = "New Bowler"
        '
        'cmdscore5update
        '
        Me.cmdscore5update.BackColor = System.Drawing.Color.Yellow
        Me.cmdscore5update.Location = New System.Drawing.Point(1084, 29)
        Me.cmdscore5update.Name = "cmdscore5update"
        Me.cmdscore5update.Size = New System.Drawing.Size(57, 25)
        Me.cmdscore5update.TabIndex = 716
        Me.cmdscore5update.Text = "Update"
        Me.cmdscore5update.UseVisualStyleBackColor = False
        '
        'txtinfo5
        '
        Me.txtinfo5.Location = New System.Drawing.Point(895, 32)
        Me.txtinfo5.Name = "txtinfo5"
        Me.txtinfo5.Size = New System.Drawing.Size(120, 20)
        Me.txtinfo5.TabIndex = 715
        Me.txtinfo5.Text = "S K Panda"
        '
        'cmdscore5
        '
        Me.cmdscore5.BackColor = System.Drawing.Color.Green
        Me.cmdscore5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdscore5.ForeColor = System.Drawing.Color.White
        Me.cmdscore5.Location = New System.Drawing.Point(1021, 30)
        Me.cmdscore5.Name = "cmdscore5"
        Me.cmdscore5.Size = New System.Drawing.Size(57, 25)
        Me.cmdscore5.TabIndex = 714
        Me.cmdscore5.Text = "Play"
        Me.cmdscore5.UseVisualStyleBackColor = False
        '
        'cmbinfo4
        '
        Me.cmbinfo4.Location = New System.Drawing.Point(756, 6)
        Me.cmbinfo4.Name = "cmbinfo4"
        Me.cmbinfo4.Size = New System.Drawing.Size(133, 20)
        Me.cmbinfo4.TabIndex = 713
        Me.cmbinfo4.Text = "New Batsman"
        '
        'cmdscore4update
        '
        Me.cmdscore4update.BackColor = System.Drawing.Color.Yellow
        Me.cmdscore4update.Location = New System.Drawing.Point(1084, 3)
        Me.cmdscore4update.Name = "cmdscore4update"
        Me.cmdscore4update.Size = New System.Drawing.Size(57, 25)
        Me.cmdscore4update.TabIndex = 712
        Me.cmdscore4update.Text = "Update"
        Me.cmdscore4update.UseVisualStyleBackColor = False
        '
        'txtinfo4
        '
        Me.txtinfo4.Location = New System.Drawing.Point(895, 6)
        Me.txtinfo4.Name = "txtinfo4"
        Me.txtinfo4.Size = New System.Drawing.Size(120, 20)
        Me.txtinfo4.TabIndex = 711
        Me.txtinfo4.Text = "Vimlesh Kumar"
        '
        'cmdscore4
        '
        Me.cmdscore4.BackColor = System.Drawing.Color.Green
        Me.cmdscore4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdscore4.ForeColor = System.Drawing.Color.White
        Me.cmdscore4.Location = New System.Drawing.Point(1021, 4)
        Me.cmdscore4.Name = "cmdscore4"
        Me.cmdscore4.Size = New System.Drawing.Size(57, 25)
        Me.cmdscore4.TabIndex = 710
        Me.cmdscore4.Text = "Play"
        Me.cmdscore4.UseVisualStyleBackColor = False
        '
        'cmbinfo3
        '
        Me.cmbinfo3.Location = New System.Drawing.Point(358, 30)
        Me.cmbinfo3.Name = "cmbinfo3"
        Me.cmbinfo3.Size = New System.Drawing.Size(133, 20)
        Me.cmbinfo3.TabIndex = 709
        '
        'cmdscore3update
        '
        Me.cmdscore3update.BackColor = System.Drawing.Color.Yellow
        Me.cmdscore3update.Location = New System.Drawing.Point(686, 27)
        Me.cmdscore3update.Name = "cmdscore3update"
        Me.cmdscore3update.Size = New System.Drawing.Size(57, 25)
        Me.cmdscore3update.TabIndex = 708
        Me.cmdscore3update.Text = "Update"
        Me.cmdscore3update.UseVisualStyleBackColor = False
        '
        'txtinfo3
        '
        Me.txtinfo3.Location = New System.Drawing.Point(497, 30)
        Me.txtinfo3.Name = "txtinfo3"
        Me.txtinfo3.Size = New System.Drawing.Size(120, 20)
        Me.txtinfo3.TabIndex = 706
        '
        'cmdscore3
        '
        Me.cmdscore3.BackColor = System.Drawing.Color.Green
        Me.cmdscore3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdscore3.ForeColor = System.Drawing.Color.White
        Me.cmdscore3.Location = New System.Drawing.Point(623, 28)
        Me.cmdscore3.Name = "cmdscore3"
        Me.cmdscore3.Size = New System.Drawing.Size(57, 25)
        Me.cmdscore3.TabIndex = 705
        Me.cmdscore3.Text = "Play"
        Me.cmdscore3.UseVisualStyleBackColor = False
        '
        'dgvFOW
        '
        Me.dgvFOW.AllowUserToAddRows = False
        Me.dgvFOW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFOW.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FOW1, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgvFOW.Location = New System.Drawing.Point(574, 507)
        Me.dgvFOW.Name = "dgvFOW"
        Me.dgvFOW.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvFOW.Size = New System.Drawing.Size(546, 46)
        Me.dgvFOW.TabIndex = 704
        '
        'FOW1
        '
        Me.FOW1.HeaderText = "FOW1"
        Me.FOW1.Name = "FOW1"
        Me.FOW1.Width = 50
        '
        'Column1
        '
        Me.Column1.HeaderText = "FOW2"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "FOW3"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "FOW4"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 50
        '
        'Column4
        '
        Me.Column4.HeaderText = "FOW5"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 50
        '
        'Column5
        '
        Me.Column5.HeaderText = "FOW6"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 50
        '
        'Column6
        '
        Me.Column6.HeaderText = "FOW7"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 50
        '
        'Column7
        '
        Me.Column7.HeaderText = "FOW8"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 50
        '
        'Column8
        '
        Me.Column8.HeaderText = "FOW9"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 50
        '
        'Column9
        '
        Me.Column9.HeaderText = "FOW10"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 50
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightSalmon
        Me.GroupBox4.Controls.Add(Me.rdoB11)
        Me.GroupBox4.Controls.Add(Me.rdoB10)
        Me.GroupBox4.Controls.Add(Me.rdoB9)
        Me.GroupBox4.Controls.Add(Me.rdoB8)
        Me.GroupBox4.Controls.Add(Me.rdoB7)
        Me.GroupBox4.Controls.Add(Me.rdoB6)
        Me.GroupBox4.Controls.Add(Me.rdoB5)
        Me.GroupBox4.Controls.Add(Me.rdoB4)
        Me.GroupBox4.Controls.Add(Me.rdoB3)
        Me.GroupBox4.Controls.Add(Me.rdoB2)
        Me.GroupBox4.Controls.Add(Me.rdoB1)
        Me.GroupBox4.Controls.Add(Me.rdoB0)
        Me.GroupBox4.Location = New System.Drawing.Point(958, 177)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(61, 311)
        Me.GroupBox4.TabIndex = 703
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Bowler"
        '
        'rdoB11
        '
        Me.rdoB11.AutoSize = True
        Me.rdoB11.Location = New System.Drawing.Point(6, 266)
        Me.rdoB11.Name = "rdoB11"
        Me.rdoB11.Size = New System.Drawing.Size(44, 17)
        Me.rdoB11.TabIndex = 702
        Me.rdoB11.Tag = "11"
        Me.rdoB11.Text = "B11"
        Me.rdoB11.UseVisualStyleBackColor = True
        '
        'rdoB10
        '
        Me.rdoB10.AutoSize = True
        Me.rdoB10.Location = New System.Drawing.Point(6, 241)
        Me.rdoB10.Name = "rdoB10"
        Me.rdoB10.Size = New System.Drawing.Size(44, 17)
        Me.rdoB10.TabIndex = 701
        Me.rdoB10.Tag = "10"
        Me.rdoB10.Text = "B10"
        Me.rdoB10.UseVisualStyleBackColor = True
        '
        'rdoB9
        '
        Me.rdoB9.AutoSize = True
        Me.rdoB9.Location = New System.Drawing.Point(6, 218)
        Me.rdoB9.Name = "rdoB9"
        Me.rdoB9.Size = New System.Drawing.Size(38, 17)
        Me.rdoB9.TabIndex = 700
        Me.rdoB9.Tag = "9"
        Me.rdoB9.Text = "B9"
        Me.rdoB9.UseVisualStyleBackColor = True
        '
        'rdoB8
        '
        Me.rdoB8.AutoSize = True
        Me.rdoB8.Location = New System.Drawing.Point(6, 194)
        Me.rdoB8.Name = "rdoB8"
        Me.rdoB8.Size = New System.Drawing.Size(38, 17)
        Me.rdoB8.TabIndex = 699
        Me.rdoB8.Tag = "8"
        Me.rdoB8.Text = "B8"
        Me.rdoB8.UseVisualStyleBackColor = True
        '
        'rdoB7
        '
        Me.rdoB7.AutoSize = True
        Me.rdoB7.Location = New System.Drawing.Point(6, 172)
        Me.rdoB7.Name = "rdoB7"
        Me.rdoB7.Size = New System.Drawing.Size(38, 17)
        Me.rdoB7.TabIndex = 698
        Me.rdoB7.Tag = "7"
        Me.rdoB7.Text = "B7"
        Me.rdoB7.UseVisualStyleBackColor = True
        '
        'rdoB6
        '
        Me.rdoB6.AutoSize = True
        Me.rdoB6.Location = New System.Drawing.Point(6, 150)
        Me.rdoB6.Name = "rdoB6"
        Me.rdoB6.Size = New System.Drawing.Size(38, 17)
        Me.rdoB6.TabIndex = 697
        Me.rdoB6.Tag = "6"
        Me.rdoB6.Text = "B6"
        Me.rdoB6.UseVisualStyleBackColor = True
        '
        'rdoB5
        '
        Me.rdoB5.AutoSize = True
        Me.rdoB5.Location = New System.Drawing.Point(6, 127)
        Me.rdoB5.Name = "rdoB5"
        Me.rdoB5.Size = New System.Drawing.Size(38, 17)
        Me.rdoB5.TabIndex = 696
        Me.rdoB5.Tag = "5"
        Me.rdoB5.Text = "B5"
        Me.rdoB5.UseVisualStyleBackColor = True
        '
        'rdoB4
        '
        Me.rdoB4.AutoSize = True
        Me.rdoB4.Location = New System.Drawing.Point(6, 106)
        Me.rdoB4.Name = "rdoB4"
        Me.rdoB4.Size = New System.Drawing.Size(38, 17)
        Me.rdoB4.TabIndex = 695
        Me.rdoB4.Tag = "4"
        Me.rdoB4.Text = "B4"
        Me.rdoB4.UseVisualStyleBackColor = True
        '
        'rdoB3
        '
        Me.rdoB3.AutoSize = True
        Me.rdoB3.Location = New System.Drawing.Point(6, 83)
        Me.rdoB3.Name = "rdoB3"
        Me.rdoB3.Size = New System.Drawing.Size(38, 17)
        Me.rdoB3.TabIndex = 694
        Me.rdoB3.Tag = "3"
        Me.rdoB3.Text = "B3"
        Me.rdoB3.UseVisualStyleBackColor = True
        '
        'rdoB2
        '
        Me.rdoB2.AutoSize = True
        Me.rdoB2.Location = New System.Drawing.Point(6, 60)
        Me.rdoB2.Name = "rdoB2"
        Me.rdoB2.Size = New System.Drawing.Size(38, 17)
        Me.rdoB2.TabIndex = 693
        Me.rdoB2.Tag = "2"
        Me.rdoB2.Text = "B2"
        Me.rdoB2.UseVisualStyleBackColor = True
        '
        'rdoB1
        '
        Me.rdoB1.AutoSize = True
        Me.rdoB1.Location = New System.Drawing.Point(6, 39)
        Me.rdoB1.Name = "rdoB1"
        Me.rdoB1.Size = New System.Drawing.Size(38, 17)
        Me.rdoB1.TabIndex = 692
        Me.rdoB1.Tag = "1"
        Me.rdoB1.Text = "B1"
        Me.rdoB1.UseVisualStyleBackColor = True
        '
        'rdoB0
        '
        Me.rdoB0.AutoSize = True
        Me.rdoB0.Checked = True
        Me.rdoB0.Location = New System.Drawing.Point(6, 19)
        Me.rdoB0.Name = "rdoB0"
        Me.rdoB0.Size = New System.Drawing.Size(38, 17)
        Me.rdoB0.TabIndex = 691
        Me.rdoB0.TabStop = True
        Me.rdoB0.Tag = "0"
        Me.rdoB0.Text = "B0"
        Me.rdoB0.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSalmon
        Me.GroupBox1.Controls.Add(Me.rdoP11)
        Me.GroupBox1.Controls.Add(Me.rdoP10)
        Me.GroupBox1.Controls.Add(Me.rdoP9)
        Me.GroupBox1.Controls.Add(Me.rdoP8)
        Me.GroupBox1.Controls.Add(Me.rdoP7)
        Me.GroupBox1.Controls.Add(Me.rdoP6)
        Me.GroupBox1.Controls.Add(Me.rdoP5)
        Me.GroupBox1.Controls.Add(Me.rdoP4)
        Me.GroupBox1.Controls.Add(Me.rdoP3)
        Me.GroupBox1.Controls.Add(Me.rdoP2)
        Me.GroupBox1.Controls.Add(Me.rdoP1)
        Me.GroupBox1.Controls.Add(Me.rdoP0)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 177)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(57, 311)
        Me.GroupBox1.TabIndex = 692
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Player"
        '
        'rdoP11
        '
        Me.rdoP11.AutoSize = True
        Me.rdoP11.Location = New System.Drawing.Point(15, 266)
        Me.rdoP11.Name = "rdoP11"
        Me.rdoP11.Size = New System.Drawing.Size(44, 17)
        Me.rdoP11.TabIndex = 702
        Me.rdoP11.Tag = "11"
        Me.rdoP11.Text = "P11"
        Me.rdoP11.UseVisualStyleBackColor = True
        '
        'rdoP10
        '
        Me.rdoP10.AutoSize = True
        Me.rdoP10.Location = New System.Drawing.Point(15, 241)
        Me.rdoP10.Name = "rdoP10"
        Me.rdoP10.Size = New System.Drawing.Size(44, 17)
        Me.rdoP10.TabIndex = 701
        Me.rdoP10.Tag = "10"
        Me.rdoP10.Text = "P10"
        Me.rdoP10.UseVisualStyleBackColor = True
        '
        'rdoP9
        '
        Me.rdoP9.AutoSize = True
        Me.rdoP9.Location = New System.Drawing.Point(15, 218)
        Me.rdoP9.Name = "rdoP9"
        Me.rdoP9.Size = New System.Drawing.Size(38, 17)
        Me.rdoP9.TabIndex = 700
        Me.rdoP9.Tag = "9"
        Me.rdoP9.Text = "P9"
        Me.rdoP9.UseVisualStyleBackColor = True
        '
        'rdoP8
        '
        Me.rdoP8.AutoSize = True
        Me.rdoP8.Location = New System.Drawing.Point(15, 194)
        Me.rdoP8.Name = "rdoP8"
        Me.rdoP8.Size = New System.Drawing.Size(38, 17)
        Me.rdoP8.TabIndex = 699
        Me.rdoP8.Tag = "8"
        Me.rdoP8.Text = "P8"
        Me.rdoP8.UseVisualStyleBackColor = True
        '
        'rdoP7
        '
        Me.rdoP7.AutoSize = True
        Me.rdoP7.Location = New System.Drawing.Point(15, 172)
        Me.rdoP7.Name = "rdoP7"
        Me.rdoP7.Size = New System.Drawing.Size(38, 17)
        Me.rdoP7.TabIndex = 698
        Me.rdoP7.Tag = "7"
        Me.rdoP7.Text = "P7"
        Me.rdoP7.UseVisualStyleBackColor = True
        '
        'rdoP6
        '
        Me.rdoP6.AutoSize = True
        Me.rdoP6.Location = New System.Drawing.Point(15, 150)
        Me.rdoP6.Name = "rdoP6"
        Me.rdoP6.Size = New System.Drawing.Size(38, 17)
        Me.rdoP6.TabIndex = 697
        Me.rdoP6.Tag = "6"
        Me.rdoP6.Text = "P6"
        Me.rdoP6.UseVisualStyleBackColor = True
        '
        'rdoP5
        '
        Me.rdoP5.AutoSize = True
        Me.rdoP5.Location = New System.Drawing.Point(15, 127)
        Me.rdoP5.Name = "rdoP5"
        Me.rdoP5.Size = New System.Drawing.Size(38, 17)
        Me.rdoP5.TabIndex = 696
        Me.rdoP5.Tag = "5"
        Me.rdoP5.Text = "P5"
        Me.rdoP5.UseVisualStyleBackColor = True
        '
        'rdoP4
        '
        Me.rdoP4.AutoSize = True
        Me.rdoP4.Location = New System.Drawing.Point(15, 106)
        Me.rdoP4.Name = "rdoP4"
        Me.rdoP4.Size = New System.Drawing.Size(38, 17)
        Me.rdoP4.TabIndex = 695
        Me.rdoP4.Tag = "4"
        Me.rdoP4.Text = "P4"
        Me.rdoP4.UseVisualStyleBackColor = True
        '
        'rdoP3
        '
        Me.rdoP3.AutoSize = True
        Me.rdoP3.Location = New System.Drawing.Point(15, 83)
        Me.rdoP3.Name = "rdoP3"
        Me.rdoP3.Size = New System.Drawing.Size(38, 17)
        Me.rdoP3.TabIndex = 694
        Me.rdoP3.Tag = "3"
        Me.rdoP3.Text = "P3"
        Me.rdoP3.UseVisualStyleBackColor = True
        '
        'rdoP2
        '
        Me.rdoP2.AutoSize = True
        Me.rdoP2.Location = New System.Drawing.Point(15, 60)
        Me.rdoP2.Name = "rdoP2"
        Me.rdoP2.Size = New System.Drawing.Size(38, 17)
        Me.rdoP2.TabIndex = 693
        Me.rdoP2.Tag = "2"
        Me.rdoP2.Text = "P2"
        Me.rdoP2.UseVisualStyleBackColor = True
        '
        'rdoP1
        '
        Me.rdoP1.AutoSize = True
        Me.rdoP1.Location = New System.Drawing.Point(15, 39)
        Me.rdoP1.Name = "rdoP1"
        Me.rdoP1.Size = New System.Drawing.Size(38, 17)
        Me.rdoP1.TabIndex = 692
        Me.rdoP1.Tag = "1"
        Me.rdoP1.Text = "P1"
        Me.rdoP1.UseVisualStyleBackColor = True
        '
        'rdoP0
        '
        Me.rdoP0.AutoSize = True
        Me.rdoP0.Checked = True
        Me.rdoP0.Location = New System.Drawing.Point(15, 19)
        Me.rdoP0.Name = "rdoP0"
        Me.rdoP0.Size = New System.Drawing.Size(38, 17)
        Me.rdoP0.TabIndex = 691
        Me.rdoP0.TabStop = True
        Me.rdoP0.Tag = "0"
        Me.rdoP0.Text = "P0"
        Me.rdoP0.UseVisualStyleBackColor = True
        '
        'chkStrinkingPostionB
        '
        Me.chkStrinkingPostionB.AutoSize = True
        Me.chkStrinkingPostionB.Location = New System.Drawing.Point(497, 104)
        Me.chkStrinkingPostionB.Name = "chkStrinkingPostionB"
        Me.chkStrinkingPostionB.Size = New System.Drawing.Size(101, 17)
        Me.chkStrinkingPostionB.TabIndex = 690
        Me.chkStrinkingPostionB.Text = "Striking Position"
        Me.chkStrinkingPostionB.UseVisualStyleBackColor = True
        '
        'chkStrinkingPostionA
        '
        Me.chkStrinkingPostionA.AutoSize = True
        Me.chkStrinkingPostionA.Location = New System.Drawing.Point(358, 101)
        Me.chkStrinkingPostionA.Name = "chkStrinkingPostionA"
        Me.chkStrinkingPostionA.Size = New System.Drawing.Size(101, 17)
        Me.chkStrinkingPostionA.TabIndex = 689
        Me.chkStrinkingPostionA.Text = "Striking Position"
        Me.chkStrinkingPostionA.UseVisualStyleBackColor = True
        '
        'cmdscore2update
        '
        Me.cmdscore2update.BackColor = System.Drawing.Color.Yellow
        Me.cmdscore2update.Location = New System.Drawing.Point(686, 80)
        Me.cmdscore2update.Name = "cmdscore2update"
        Me.cmdscore2update.Size = New System.Drawing.Size(57, 25)
        Me.cmdscore2update.TabIndex = 688
        Me.cmdscore2update.Text = "Update"
        Me.cmdscore2update.UseVisualStyleBackColor = False
        '
        'cmdscore1update
        '
        Me.cmdscore1update.BackColor = System.Drawing.Color.Yellow
        Me.cmdscore1update.Location = New System.Drawing.Point(686, 54)
        Me.cmdscore1update.Name = "cmdscore1update"
        Me.cmdscore1update.Size = New System.Drawing.Size(57, 25)
        Me.cmdscore1update.TabIndex = 687
        Me.cmdscore1update.Text = "Update"
        Me.cmdscore1update.UseVisualStyleBackColor = False
        '
        'cmdscoreupdate
        '
        Me.cmdscoreupdate.BackColor = System.Drawing.Color.Yellow
        Me.cmdscoreupdate.Location = New System.Drawing.Point(685, 0)
        Me.cmdscoreupdate.Name = "cmdscoreupdate"
        Me.cmdscoreupdate.Size = New System.Drawing.Size(57, 25)
        Me.cmdscoreupdate.TabIndex = 686
        Me.cmdscoreupdate.Text = "Update"
        Me.cmdscoreupdate.UseVisualStyleBackColor = False
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Location = New System.Drawing.Point(89, 113)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(40, 13)
        Me.Label97.TabIndex = 685
        Me.Label97.Text = "Batting"
        '
        'pict2logocricket
        '
        Me.pict2logocricket.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pict2logocricket.ImageLocation = "C:\casparcg\mydata\games\Team_Logo\ongc.png"
        Me.pict2logocricket.Location = New System.Drawing.Point(573, 130)
        Me.pict2logocricket.Name = "pict2logocricket"
        Me.pict2logocricket.Size = New System.Drawing.Size(51, 23)
        Me.pict2logocricket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pict2logocricket.TabIndex = 684
        Me.pict2logocricket.TabStop = False
        '
        'pict1logocricket
        '
        Me.pict1logocricket.BackColor = System.Drawing.SystemColors.Control
        Me.pict1logocricket.ImageLocation = "C:\casparcg\mydata\games\Team_Logo\dypa.png"
        Me.pict1logocricket.Location = New System.Drawing.Point(31, 118)
        Me.pict1logocricket.Name = "pict1logocricket"
        Me.pict1logocricket.Size = New System.Drawing.Size(51, 27)
        Me.pict1logocricket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pict1logocricket.TabIndex = 683
        Me.pict1logocricket.TabStop = False
        '
        'cmdclearbatsmanstatics
        '
        Me.cmdclearbatsmanstatics.Location = New System.Drawing.Point(333, 146)
        Me.cmdclearbatsmanstatics.Name = "cmdclearbatsmanstatics"
        Me.cmdclearbatsmanstatics.Size = New System.Drawing.Size(75, 23)
        Me.cmdclearbatsmanstatics.TabIndex = 682
        Me.cmdclearbatsmanstatics.Text = "clear data"
        Me.cmdclearbatsmanstatics.UseVisualStyleBackColor = True
        '
        'cmdrowdeletebatsman
        '
        Me.cmdrowdeletebatsman.BackgroundImage = CType(resources.GetObject("cmdrowdeletebatsman.BackgroundImage"), System.Drawing.Image)
        Me.cmdrowdeletebatsman.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdrowdeletebatsman.Location = New System.Drawing.Point(295, 149)
        Me.cmdrowdeletebatsman.Name = "cmdrowdeletebatsman"
        Me.cmdrowdeletebatsman.Size = New System.Drawing.Size(33, 22)
        Me.cmdrowdeletebatsman.TabIndex = 681
        Me.cmdrowdeletebatsman.UseVisualStyleBackColor = True
        '
        'cmdrowinsertbatsman
        '
        Me.cmdrowinsertbatsman.Image = CType(resources.GetObject("cmdrowinsertbatsman.Image"), System.Drawing.Image)
        Me.cmdrowinsertbatsman.Location = New System.Drawing.Point(248, 148)
        Me.cmdrowinsertbatsman.Name = "cmdrowinsertbatsman"
        Me.cmdrowinsertbatsman.Size = New System.Drawing.Size(41, 23)
        Me.cmdrowinsertbatsman.TabIndex = 677
        Me.cmdrowinsertbatsman.UseVisualStyleBackColor = True
        '
        'tstwoliner
        '
        Me.tstwoliner.Dock = System.Windows.Forms.DockStyle.None
        Me.tstwoliner.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newbatmandata, Me.openbatsmandata, Me.savebatsmandata, Me.ToolStripSeparator14, Me.ToolStripSeparator15})
        Me.tstwoliner.Location = New System.Drawing.Point(86, 146)
        Me.tstwoliner.MaximumSize = New System.Drawing.Size(200, 200)
        Me.tstwoliner.Name = "tstwoliner"
        Me.tstwoliner.Size = New System.Drawing.Size(93, 25)
        Me.tstwoliner.TabIndex = 680
        Me.tstwoliner.Text = "ToolStrip3"
        '
        'newbatmandata
        '
        Me.newbatmandata.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.newbatmandata.Image = CType(resources.GetObject("newbatmandata.Image"), System.Drawing.Image)
        Me.newbatmandata.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newbatmandata.Name = "newbatmandata"
        Me.newbatmandata.Size = New System.Drawing.Size(23, 22)
        Me.newbatmandata.Text = "&New"
        '
        'openbatsmandata
        '
        Me.openbatsmandata.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.openbatsmandata.Image = CType(resources.GetObject("openbatsmandata.Image"), System.Drawing.Image)
        Me.openbatsmandata.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.openbatsmandata.Name = "openbatsmandata"
        Me.openbatsmandata.Size = New System.Drawing.Size(23, 22)
        Me.openbatsmandata.Text = "&Open"
        '
        'savebatsmandata
        '
        Me.savebatsmandata.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.savebatsmandata.Image = CType(resources.GetObject("savebatsmandata.Image"), System.Drawing.Image)
        Me.savebatsmandata.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.savebatsmandata.Name = "savebatsmandata"
        Me.savebatsmandata.Size = New System.Drawing.Size(23, 22)
        Me.savebatsmandata.Text = "&Save"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 25)
        '
        'cmdrowdownbatsman
        '
        Me.cmdrowdownbatsman.Image = CType(resources.GetObject("cmdrowdownbatsman.Image"), System.Drawing.Image)
        Me.cmdrowdownbatsman.Location = New System.Drawing.Point(211, 148)
        Me.cmdrowdownbatsman.Name = "cmdrowdownbatsman"
        Me.cmdrowdownbatsman.Size = New System.Drawing.Size(36, 23)
        Me.cmdrowdownbatsman.TabIndex = 679
        Me.cmdrowdownbatsman.UseVisualStyleBackColor = True
        '
        'cmdrowupbatsman
        '
        Me.cmdrowupbatsman.Image = CType(resources.GetObject("cmdrowupbatsman.Image"), System.Drawing.Image)
        Me.cmdrowupbatsman.Location = New System.Drawing.Point(179, 148)
        Me.cmdrowupbatsman.Name = "cmdrowupbatsman"
        Me.cmdrowupbatsman.Size = New System.Drawing.Size(28, 23)
        Me.cmdrowupbatsman.TabIndex = 678
        Me.cmdrowupbatsman.UseVisualStyleBackColor = True
        '
        'txtinfo1
        '
        Me.txtinfo1.Location = New System.Drawing.Point(497, 54)
        Me.txtinfo1.Name = "txtinfo1"
        Me.txtinfo1.Size = New System.Drawing.Size(120, 20)
        Me.txtinfo1.TabIndex = 641
        Me.txtinfo1.Text = "at D Y Patil Stadium"
        '
        'txtinfo2
        '
        Me.txtinfo2.Location = New System.Drawing.Point(497, 79)
        Me.txtinfo2.Name = "txtinfo2"
        Me.txtinfo2.Size = New System.Drawing.Size(120, 20)
        Me.txtinfo2.TabIndex = 644
        Me.txtinfo2.Text = "Vimlesh 105"
        '
        'cmbinfo2
        '
        Me.cmbinfo2.Location = New System.Drawing.Point(358, 79)
        Me.cmbinfo2.Name = "cmbinfo2"
        Me.cmbinfo2.Size = New System.Drawing.Size(133, 20)
        Me.cmbinfo2.TabIndex = 643
        Me.cmbinfo2.Text = "Suresh 45"
        '
        'cmbinfo1
        '
        Me.cmbinfo1.Location = New System.Drawing.Point(358, 54)
        Me.cmbinfo1.Name = "cmbinfo1"
        Me.cmbinfo1.Size = New System.Drawing.Size(133, 20)
        Me.cmbinfo1.TabIndex = 640
        Me.cmbinfo1.Text = "2nd Semi Final"
        '
        'txtnb
        '
        Me.txtnb.Location = New System.Drawing.Point(602, 574)
        Me.txtnb.Name = "txtnb"
        Me.txtnb.Size = New System.Drawing.Size(37, 20)
        Me.txtnb.TabIndex = 626
        Me.txtnb.Text = "5"
        Me.txtnb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtwd
        '
        Me.txtwd.Location = New System.Drawing.Point(662, 574)
        Me.txtwd.Name = "txtwd"
        Me.txtwd.Size = New System.Drawing.Size(37, 20)
        Me.txtwd.TabIndex = 625
        Me.txtwd.Text = "4"
        Me.txtwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtlb
        '
        Me.txtlb.Location = New System.Drawing.Point(718, 574)
        Me.txtlb.Name = "txtlb"
        Me.txtlb.Size = New System.Drawing.Size(37, 20)
        Me.txtlb.TabIndex = 624
        Me.txtlb.Text = "3"
        Me.txtlb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtby
        '
        Me.txtby.Location = New System.Drawing.Point(780, 574)
        Me.txtby.Name = "txtby"
        Me.txtby.Size = New System.Drawing.Size(37, 20)
        Me.txtby.TabIndex = 623
        Me.txtby.Text = "2"
        Me.txtby.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttotalextra
        '
        Me.txttotalextra.Location = New System.Drawing.Point(835, 574)
        Me.txttotalextra.Name = "txttotalextra"
        Me.txttotalextra.Size = New System.Drawing.Size(37, 20)
        Me.txttotalextra.TabIndex = 622
        Me.txttotalextra.Text = "14"
        Me.txttotalextra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttotalbatsmanvalue
        '
        Me.txttotalbatsmanvalue.Location = New System.Drawing.Point(489, 539)
        Me.txttotalbatsmanvalue.Name = "txttotalbatsmanvalue"
        Me.txttotalbatsmanvalue.Size = New System.Drawing.Size(55, 20)
        Me.txttotalbatsmanvalue.TabIndex = 616
        Me.txttotalbatsmanvalue.Text = "125/5"
        Me.txttotalbatsmanvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttotalbatsman
        '
        Me.txttotalbatsman.Location = New System.Drawing.Point(446, 539)
        Me.txttotalbatsman.Name = "txttotalbatsman"
        Me.txttotalbatsman.Size = New System.Drawing.Size(34, 20)
        Me.txttotalbatsman.TabIndex = 614
        Me.txttotalbatsman.Text = "Total"
        '
        'txtoversbatman
        '
        Me.txtoversbatman.Location = New System.Drawing.Point(274, 539)
        Me.txtoversbatman.Name = "txtoversbatman"
        Me.txtoversbatman.Size = New System.Drawing.Size(37, 20)
        Me.txtoversbatman.TabIndex = 613
        Me.txtoversbatman.Text = "Overs"
        '
        'txtextrabatmanvalue
        '
        Me.txtextrabatmanvalue.Location = New System.Drawing.Point(404, 539)
        Me.txtextrabatmanvalue.Name = "txtextrabatmanvalue"
        Me.txtextrabatmanvalue.Size = New System.Drawing.Size(36, 20)
        Me.txtextrabatmanvalue.TabIndex = 612
        Me.txtextrabatmanvalue.Text = "6"
        Me.txtextrabatmanvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtextrabatman
        '
        Me.txtextrabatman.Location = New System.Drawing.Point(361, 539)
        Me.txtextrabatman.Name = "txtextrabatman"
        Me.txtextrabatman.Size = New System.Drawing.Size(37, 20)
        Me.txtextrabatman.TabIndex = 611
        Me.txtextrabatman.Text = "Extras"
        '
        'txtoversbatmanvalue
        '
        Me.txtoversbatmanvalue.Location = New System.Drawing.Point(312, 539)
        Me.txtoversbatmanvalue.Name = "txtoversbatmanvalue"
        Me.txtoversbatmanvalue.Size = New System.Drawing.Size(43, 20)
        Me.txtoversbatmanvalue.TabIndex = 610
        Me.txtoversbatmanvalue.Text = "12.4"
        Me.txtoversbatmanvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtteamnameb
        '
        Me.txtteamnameb.Location = New System.Drawing.Point(688, 123)
        Me.txtteamnameb.Name = "txtteamnameb"
        Me.txtteamnameb.Size = New System.Drawing.Size(110, 20)
        Me.txtteamnameb.TabIndex = 609
        Me.txtteamnameb.Text = "ONGC"
        '
        'txtteamnamea
        '
        Me.txtteamnamea.Location = New System.Drawing.Point(141, 118)
        Me.txtteamnamea.Name = "txtteamnamea"
        Me.txtteamnamea.Size = New System.Drawing.Size(97, 20)
        Me.txtteamnamea.TabIndex = 606
        Me.txtteamnamea.Text = "DYPA"
        '
        'txtthisover
        '
        Me.txtthisover.Location = New System.Drawing.Point(1008, 644)
        Me.txtthisover.Name = "txtthisover"
        Me.txtthisover.Size = New System.Drawing.Size(121, 20)
        Me.txtthisover.TabIndex = 599
        Me.txtthisover.Text = "2, 4, wt, nb, wd"
        '
        'txtlastwicketat
        '
        Me.txtlastwicketat.Location = New System.Drawing.Point(1092, 717)
        Me.txtlastwicketat.Name = "txtlastwicketat"
        Me.txtlastwicketat.Size = New System.Drawing.Size(40, 20)
        Me.txtlastwicketat.TabIndex = 598
        Me.txtlastwicketat.Text = "45"
        '
        'txtmatchover
        '
        Me.txtmatchover.Location = New System.Drawing.Point(1092, 696)
        Me.txtmatchover.Name = "txtmatchover"
        Me.txtmatchover.Size = New System.Drawing.Size(40, 20)
        Me.txtmatchover.TabIndex = 597
        Me.txtmatchover.Text = "20"
        '
        'txt1stinningscore
        '
        Me.txt1stinningscore.Location = New System.Drawing.Point(1092, 670)
        Me.txt1stinningscore.Name = "txt1stinningscore"
        Me.txt1stinningscore.Size = New System.Drawing.Size(40, 20)
        Me.txt1stinningscore.TabIndex = 596
        Me.txt1stinningscore.Text = "205"
        '
        'txtover
        '
        Me.txtover.Location = New System.Drawing.Point(291, 26)
        Me.txtover.Name = "txtover"
        Me.txtover.Size = New System.Drawing.Size(38, 20)
        Me.txtover.TabIndex = 591
        Me.txtover.Text = "12.4"
        '
        'txtinfo
        '
        Me.txtinfo.Location = New System.Drawing.Point(496, 5)
        Me.txtinfo.Name = "txtinfo"
        Me.txtinfo.Size = New System.Drawing.Size(120, 20)
        Me.txtinfo.TabIndex = 590
        '
        'txtwicket
        '
        Me.txtwicket.Location = New System.Drawing.Point(168, 28)
        Me.txtwicket.Name = "txtwicket"
        Me.txtwicket.Size = New System.Drawing.Size(29, 20)
        Me.txtwicket.TabIndex = 589
        Me.txtwicket.Text = "5"
        '
        'txtovers
        '
        Me.txtovers.Location = New System.Drawing.Point(216, 27)
        Me.txtovers.Name = "txtovers"
        Me.txtovers.Size = New System.Drawing.Size(60, 20)
        Me.txtovers.TabIndex = 588
        Me.txtovers.Text = "Overs"
        '
        'txtrun
        '
        Me.txtrun.Location = New System.Drawing.Point(89, 26)
        Me.txtrun.Name = "txtrun"
        Me.txtrun.Size = New System.Drawing.Size(45, 20)
        Me.txtrun.TabIndex = 587
        Me.txtrun.Text = "125"
        '
        'txtteamname
        '
        Me.txtteamname.Location = New System.Drawing.Point(20, 27)
        Me.txtteamname.Name = "txtteamname"
        Me.txtteamname.Size = New System.Drawing.Size(52, 20)
        Me.txtteamname.TabIndex = 586
        Me.txtteamname.Text = "ONGC"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Location = New System.Drawing.Point(91, 130)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(44, 13)
        Me.Label85.TabIndex = 651
        Me.Label85.Text = "Team A"
        '
        'cmdplayeridbatsman
        '
        Me.cmdplayeridbatsman.BackColor = System.Drawing.Color.Green
        Me.cmdplayeridbatsman.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdplayeridbatsman.ForeColor = System.Drawing.Color.White
        Me.cmdplayeridbatsman.Location = New System.Drawing.Point(549, 187)
        Me.cmdplayeridbatsman.Name = "cmdplayeridbatsman"
        Me.cmdplayeridbatsman.Size = New System.Drawing.Size(47, 35)
        Me.cmdplayeridbatsman.TabIndex = 650
        Me.cmdplayeridbatsman.Text = "Name only"
        Me.cmdplayeridbatsman.UseVisualStyleBackColor = False
        '
        'dgvbowler
        '
        Me.dgvbowler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbowler.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn41})
        Me.dgvbowler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvbowler.Location = New System.Drawing.Point(624, 172)
        Me.dgvbowler.Name = "dgvbowler"
        Me.dgvbowler.Size = New System.Drawing.Size(332, 333)
        Me.dgvbowler.TabIndex = 649
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.HeaderText = "Player"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn45.Width = 150
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.HeaderText = "O"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn44.Width = 30
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.HeaderText = "M"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn43.Width = 30
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.HeaderText = "R"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn42.Width = 30
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.HeaderText = "W"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn41.Width = 30
        '
        'dgvbatsman
        '
        Me.dgvbatsman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbatsman.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn46, Me.R, Me.B})
        Me.dgvbatsman.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvbatsman.Location = New System.Drawing.Point(90, 172)
        Me.dgvbatsman.Name = "dgvbatsman"
        Me.dgvbatsman.Size = New System.Drawing.Size(447, 361)
        Me.dgvbatsman.TabIndex = 648
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.HeaderText = "Player"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn47.Width = 150
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn46.Width = 150
        '
        'R
        '
        Me.R.HeaderText = "R"
        Me.R.Name = "R"
        Me.R.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.R.Width = 50
        '
        'B
        '
        Me.B.HeaderText = "B"
        Me.B.Name = "B"
        Me.B.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.B.Width = 50
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(-35, 101)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(1423, 13)
        Me.Label86.TabIndex = 647
        Me.Label86.Text = resources.GetString("Label86.Text")
        '
        'cmdscore2
        '
        Me.cmdscore2.BackColor = System.Drawing.Color.Green
        Me.cmdscore2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdscore2.ForeColor = System.Drawing.Color.White
        Me.cmdscore2.Location = New System.Drawing.Point(623, 79)
        Me.cmdscore2.Name = "cmdscore2"
        Me.cmdscore2.Size = New System.Drawing.Size(57, 25)
        Me.cmdscore2.TabIndex = 645
        Me.cmdscore2.Text = "Play"
        Me.cmdscore2.UseVisualStyleBackColor = False
        '
        'cmdscore1
        '
        Me.cmdscore1.BackColor = System.Drawing.Color.Green
        Me.cmdscore1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdscore1.ForeColor = System.Drawing.Color.White
        Me.cmdscore1.Location = New System.Drawing.Point(623, 54)
        Me.cmdscore1.Name = "cmdscore1"
        Me.cmdscore1.Size = New System.Drawing.Size(57, 25)
        Me.cmdscore1.TabIndex = 642
        Me.cmdscore1.Text = "Play"
        Me.cmdscore1.UseVisualStyleBackColor = False
        '
        'cmdcleardatascore
        '
        Me.cmdcleardatascore.Location = New System.Drawing.Point(104, 59)
        Me.cmdcleardatascore.Name = "cmdcleardatascore"
        Me.cmdcleardatascore.Size = New System.Drawing.Size(134, 23)
        Me.cmdcleardatascore.TabIndex = 676
        Me.cmdcleardatascore.Text = "clear data"
        Me.cmdcleardatascore.UseVisualStyleBackColor = True
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Location = New System.Drawing.Point(833, 556)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(31, 13)
        Me.Label88.TabIndex = 673
        Me.Label88.Text = "Total"
        '
        'cmdcleardatabowlerstatics
        '
        Me.cmdcleardatabowlerstatics.Location = New System.Drawing.Point(866, 143)
        Me.cmdcleardatabowlerstatics.Name = "cmdcleardatabowlerstatics"
        Me.cmdcleardatabowlerstatics.Size = New System.Drawing.Size(75, 23)
        Me.cmdcleardatabowlerstatics.TabIndex = 668
        Me.cmdcleardatabowlerstatics.Text = "clear data"
        Me.cmdcleardatabowlerstatics.UseVisualStyleBackColor = True
        '
        'lblfilenamebowler
        '
        Me.lblfilenamebowler.AutoSize = True
        Me.lblfilenamebowler.Location = New System.Drawing.Point(811, 114)
        Me.lblfilenamebowler.Name = "lblfilenamebowler"
        Me.lblfilenamebowler.Size = New System.Drawing.Size(49, 13)
        Me.lblfilenamebowler.TabIndex = 667
        Me.lblfilenamebowler.Text = "Filename"
        '
        'cmdbowlerstatus
        '
        Me.cmdbowlerstatus.Location = New System.Drawing.Point(1025, 213)
        Me.cmdbowlerstatus.Name = "cmdbowlerstatus"
        Me.cmdbowlerstatus.Size = New System.Drawing.Size(46, 35)
        Me.cmdbowlerstatus.TabIndex = 666
        Me.cmdbowlerstatus.Text = "Status"
        Me.cmdbowlerstatus.UseVisualStyleBackColor = True
        '
        'cmdplayeridbowler
        '
        Me.cmdplayeridbowler.Location = New System.Drawing.Point(1025, 172)
        Me.cmdplayeridbowler.Name = "cmdplayeridbowler"
        Me.cmdplayeridbowler.Size = New System.Drawing.Size(46, 35)
        Me.cmdplayeridbowler.TabIndex = 665
        Me.cmdplayeridbowler.Text = "Name only"
        Me.cmdplayeridbowler.UseVisualStyleBackColor = True
        '
        'cmdbatsmanstatus
        '
        Me.cmdbatsmanstatus.BackColor = System.Drawing.Color.Green
        Me.cmdbatsmanstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdbatsmanstatus.ForeColor = System.Drawing.Color.White
        Me.cmdbatsmanstatus.Location = New System.Drawing.Point(544, 223)
        Me.cmdbatsmanstatus.Name = "cmdbatsmanstatus"
        Me.cmdbatsmanstatus.Size = New System.Drawing.Size(54, 35)
        Me.cmdbatsmanstatus.TabIndex = 664
        Me.cmdbatsmanstatus.Text = "Status"
        Me.cmdbatsmanstatus.UseVisualStyleBackColor = False
        '
        'cmdrowupbowler
        '
        Me.cmdrowupbowler.Image = CType(resources.GetObject("cmdrowupbowler.Image"), System.Drawing.Image)
        Me.cmdrowupbowler.Location = New System.Drawing.Point(711, 146)
        Me.cmdrowupbowler.Name = "cmdrowupbowler"
        Me.cmdrowupbowler.Size = New System.Drawing.Size(28, 23)
        Me.cmdrowupbowler.TabIndex = 658
        Me.cmdrowupbowler.UseVisualStyleBackColor = True
        '
        'cmdrowdownbowler
        '
        Me.cmdrowdownbowler.Image = CType(resources.GetObject("cmdrowdownbowler.Image"), System.Drawing.Image)
        Me.cmdrowdownbowler.Location = New System.Drawing.Point(743, 146)
        Me.cmdrowdownbowler.Name = "cmdrowdownbowler"
        Me.cmdrowdownbowler.Size = New System.Drawing.Size(36, 23)
        Me.cmdrowdownbowler.TabIndex = 659
        Me.cmdrowdownbowler.UseVisualStyleBackColor = True
        '
        'cmdrowinsertbowler
        '
        Me.cmdrowinsertbowler.Image = CType(resources.GetObject("cmdrowinsertbowler.Image"), System.Drawing.Image)
        Me.cmdrowinsertbowler.Location = New System.Drawing.Point(780, 146)
        Me.cmdrowinsertbowler.Name = "cmdrowinsertbowler"
        Me.cmdrowinsertbowler.Size = New System.Drawing.Size(41, 23)
        Me.cmdrowinsertbowler.TabIndex = 657
        Me.cmdrowinsertbowler.UseVisualStyleBackColor = True
        '
        'lblfilenamebatsman
        '
        Me.lblfilenamebatsman.AutoSize = True
        Me.lblfilenamebatsman.Location = New System.Drawing.Point(244, 121)
        Me.lblfilenamebatsman.Name = "lblfilenamebatsman"
        Me.lblfilenamebatsman.Size = New System.Drawing.Size(49, 13)
        Me.lblfilenamebatsman.TabIndex = 662
        Me.lblfilenamebatsman.Text = "Filename"
        '
        'cmdrowdeletebowler
        '
        Me.cmdrowdeletebowler.BackgroundImage = CType(resources.GetObject("cmdrowdeletebowler.BackgroundImage"), System.Drawing.Image)
        Me.cmdrowdeletebowler.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdrowdeletebowler.Location = New System.Drawing.Point(827, 147)
        Me.cmdrowdeletebowler.Name = "cmdrowdeletebowler"
        Me.cmdrowdeletebowler.Size = New System.Drawing.Size(33, 22)
        Me.cmdrowdeletebowler.TabIndex = 661
        Me.cmdrowdeletebowler.UseVisualStyleBackColor = True
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newdatabowler, Me.tsopendatabowler, Me.tssavedatabowler, Me.ToolStripSeparator17, Me.ToolStripSeparator16})
        Me.ToolStrip4.Location = New System.Drawing.Point(624, 144)
        Me.ToolStrip4.MaximumSize = New System.Drawing.Size(200, 200)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(93, 25)
        Me.ToolStrip4.TabIndex = 660
        Me.ToolStrip4.Text = "ToolStrip3"
        '
        'newdatabowler
        '
        Me.newdatabowler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.newdatabowler.Image = CType(resources.GetObject("newdatabowler.Image"), System.Drawing.Image)
        Me.newdatabowler.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newdatabowler.Name = "newdatabowler"
        Me.newdatabowler.Size = New System.Drawing.Size(23, 22)
        Me.newdatabowler.Text = "&New"
        '
        'tsopendatabowler
        '
        Me.tsopendatabowler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsopendatabowler.Image = CType(resources.GetObject("tsopendatabowler.Image"), System.Drawing.Image)
        Me.tsopendatabowler.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsopendatabowler.Name = "tsopendatabowler"
        Me.tsopendatabowler.Size = New System.Drawing.Size(23, 22)
        Me.tsopendatabowler.Text = "&Open"
        '
        'tssavedatabowler
        '
        Me.tssavedatabowler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tssavedatabowler.Image = CType(resources.GetObject("tssavedatabowler.Image"), System.Drawing.Image)
        Me.tssavedatabowler.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssavedatabowler.Name = "tssavedatabowler"
        Me.tssavedatabowler.Size = New System.Drawing.Size(23, 22)
        Me.tssavedatabowler.Text = "&Save"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 25)
        '
        'cmdbowlingcard
        '
        Me.cmdbowlingcard.BackColor = System.Drawing.Color.Green
        Me.cmdbowlingcard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdbowlingcard.ForeColor = System.Drawing.Color.White
        Me.cmdbowlingcard.Location = New System.Drawing.Point(1020, 302)
        Me.cmdbowlingcard.Name = "cmdbowlingcard"
        Me.cmdbowlingcard.Size = New System.Drawing.Size(73, 39)
        Me.cmdbowlingcard.TabIndex = 639
        Me.cmdbowlingcard.Text = "Bowling Card"
        Me.cmdbowlingcard.UseVisualStyleBackColor = False
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Location = New System.Drawing.Point(780, 556)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(33, 13)
        Me.Label90.TabIndex = 627
        Me.Label90.Text = "Byes:"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Location = New System.Drawing.Point(724, 556)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(23, 13)
        Me.Label91.TabIndex = 621
        Me.Label91.Text = "LB:"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Location = New System.Drawing.Point(660, 556)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(40, 13)
        Me.Label92.TabIndex = 620
        Me.Label92.Text = "Wides:"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Location = New System.Drawing.Point(608, 556)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(25, 13)
        Me.Label93.TabIndex = 619
        Me.Label93.Text = "NB:"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Location = New System.Drawing.Point(546, 573)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(53, 13)
        Me.Label94.TabIndex = 618
        Me.Label94.Text = "EXTRAS:"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Location = New System.Drawing.Point(630, 113)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(54, 13)
        Me.Label95.TabIndex = 617
        Me.Label95.Text = "BOWLER"
        '
        'cmdbattingcard
        '
        Me.cmdbattingcard.BackColor = System.Drawing.Color.Green
        Me.cmdbattingcard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdbattingcard.ForeColor = System.Drawing.Color.White
        Me.cmdbattingcard.Location = New System.Drawing.Point(539, 276)
        Me.cmdbattingcard.Name = "cmdbattingcard"
        Me.cmdbattingcard.Size = New System.Drawing.Size(85, 31)
        Me.cmdbattingcard.TabIndex = 615
        Me.cmdbattingcard.Text = "Batting Card"
        Me.cmdbattingcard.UseVisualStyleBackColor = False
        '
        'cmdteamlinupbowler
        '
        Me.cmdteamlinupbowler.BackColor = System.Drawing.Color.Green
        Me.cmdteamlinupbowler.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdteamlinupbowler.ForeColor = System.Drawing.Color.White
        Me.cmdteamlinupbowler.Location = New System.Drawing.Point(1020, 260)
        Me.cmdteamlinupbowler.Name = "cmdteamlinupbowler"
        Me.cmdteamlinupbowler.Size = New System.Drawing.Size(78, 36)
        Me.cmdteamlinupbowler.TabIndex = 608
        Me.cmdteamlinupbowler.Text = "Play Lineup"
        Me.cmdteamlinupbowler.UseVisualStyleBackColor = False
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Location = New System.Drawing.Point(638, 128)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(44, 13)
        Me.Label96.TabIndex = 607
        Me.Label96.Text = "Team B"
        '
        'cmdteamlinupbatsman
        '
        Me.cmdteamlinupbatsman.BackColor = System.Drawing.Color.Green
        Me.cmdteamlinupbatsman.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdteamlinupbatsman.ForeColor = System.Drawing.Color.White
        Me.cmdteamlinupbatsman.Location = New System.Drawing.Point(537, 327)
        Me.cmdteamlinupbatsman.Name = "cmdteamlinupbatsman"
        Me.cmdteamlinupbatsman.Size = New System.Drawing.Size(81, 46)
        Me.cmdteamlinupbatsman.TabIndex = 605
        Me.cmdteamlinupbatsman.Text = "Play Lineup"
        Me.cmdteamlinupbatsman.UseVisualStyleBackColor = False
        '
        'lbllastwicketat
        '
        Me.lbllastwicketat.AutoSize = True
        Me.lbllastwicketat.Location = New System.Drawing.Point(984, 724)
        Me.lbllastwicketat.Name = "lbllastwicketat"
        Me.lbllastwicketat.Size = New System.Drawing.Size(100, 13)
        Me.lbllastwicketat.TabIndex = 603
        Me.lbllastwicketat.Text = "Last Wicket At Run"
        '
        'lblthisover
        '
        Me.lblthisover.AutoSize = True
        Me.lblthisover.Location = New System.Drawing.Point(949, 647)
        Me.lblthisover.Name = "lblthisover"
        Me.lblthisover.Size = New System.Drawing.Size(53, 13)
        Me.lblthisover.TabIndex = 602
        Me.lblthisover.Text = "This Over"
        '
        'lblmatchover
        '
        Me.lblmatchover.AutoSize = True
        Me.lblmatchover.Location = New System.Drawing.Point(1005, 697)
        Me.lblmatchover.Name = "lblmatchover"
        Me.lblmatchover.Size = New System.Drawing.Size(78, 13)
        Me.lblmatchover.TabIndex = 601
        Me.lblmatchover.Text = "overs of Match"
        '
        'lbl1stinningscore
        '
        Me.lbl1stinningscore.AutoSize = True
        Me.lbl1stinningscore.Location = New System.Drawing.Point(1005, 673)
        Me.lbl1stinningscore.Name = "lbl1stinningscore"
        Me.lbl1stinningscore.Size = New System.Drawing.Size(81, 13)
        Me.lbl1stinningscore.TabIndex = 600
        Me.lbl1stinningscore.Text = "Ist Inning Score"
        '
        'cmbinfo
        '
        Me.cmbinfo.FormattingEnabled = True
        Me.cmbinfo.Items.AddRange(New Object() {"Run Rate", "Required Run Rate", "", "Target", "To Win", "Last Wicket At", "Overs Remaining", "Balls Remaining", "Wickets At Hand", "This Over", "Free Hit", "Equation"})
        Me.cmbinfo.Location = New System.Drawing.Point(357, 5)
        Me.cmbinfo.Name = "cmbinfo"
        Me.cmbinfo.Size = New System.Drawing.Size(133, 21)
        Me.cmbinfo.TabIndex = 595
        '
        'cmdover
        '
        Me.cmdover.Location = New System.Drawing.Point(277, 2)
        Me.cmdover.Name = "cmdover"
        Me.cmdover.Size = New System.Drawing.Size(75, 23)
        Me.cmdover.TabIndex = 594
        Me.cmdover.Text = "Over"
        Me.cmdover.UseVisualStyleBackColor = True
        '
        'cmdwicket
        '
        Me.cmdwicket.Location = New System.Drawing.Point(157, 2)
        Me.cmdwicket.Name = "cmdwicket"
        Me.cmdwicket.Size = New System.Drawing.Size(54, 23)
        Me.cmdwicket.TabIndex = 593
        Me.cmdwicket.Text = "Wicket"
        Me.cmdwicket.UseVisualStyleBackColor = True
        '
        'cmdrun
        '
        Me.cmdrun.Location = New System.Drawing.Point(76, 2)
        Me.cmdrun.Name = "cmdrun"
        Me.cmdrun.Size = New System.Drawing.Size(75, 23)
        Me.cmdrun.TabIndex = 592
        Me.cmdrun.Text = "Run"
        Me.cmdrun.UseVisualStyleBackColor = True
        '
        'cmdscore
        '
        Me.cmdscore.BackColor = System.Drawing.Color.Green
        Me.cmdscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdscore.ForeColor = System.Drawing.Color.White
        Me.cmdscore.Location = New System.Drawing.Point(622, 1)
        Me.cmdscore.Name = "cmdscore"
        Me.cmdscore.Size = New System.Drawing.Size(57, 25)
        Me.cmdscore.TabIndex = 585
        Me.cmdscore.Text = "Play"
        Me.cmdscore.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Cricket)
        Me.TabControl1.Location = New System.Drawing.Point(6, 114)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1157, 831)
        Me.TabControl1.TabIndex = 0
        '
        'txthtmlupdateDelay
        '
        Me.txthtmlupdateDelay.Location = New System.Drawing.Point(968, 22)
        Me.txthtmlupdateDelay.Name = "txthtmlupdateDelay"
        Me.txthtmlupdateDelay.Size = New System.Drawing.Size(43, 20)
        Me.txthtmlupdateDelay.TabIndex = 1264
        Me.txthtmlupdateDelay.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(842, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 1202
        Me.Label2.Text = "Html Update Delay (ms)"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "FOW1"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "FOW2"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "FOW3"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "FOW4"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "FOW5"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "FOW6"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 50
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "FOW7"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "FOW8"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 50
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "FOW9"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 50
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "FOW10"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 50
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Player"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn11.Width = 150
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "O"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn12.Width = 30
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "M"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn13.Width = 30
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "R"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn14.Width = 30
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "W"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn15.Width = 30
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Player"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn16.Width = 150
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn17.Width = 150
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "R"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn18.Width = 50
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "B"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn19.Width = 50
        '
        'cmblayergames
        '
        Me.cmblayergames.FormattingEnabled = True
        Me.cmblayergames.Items.AddRange(New Object() {"96", "97", "98", "99", "100"})
        Me.cmblayergames.Location = New System.Drawing.Point(59, 21)
        Me.cmblayergames.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmblayergames.Name = "cmblayergames"
        Me.cmblayergames.Size = New System.Drawing.Size(40, 21)
        Me.cmblayergames.TabIndex = 1171
        Me.cmblayergames.Text = "96"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(16, 22)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(44, 13)
        Me.Label30.TabIndex = 1172
        Me.Label30.Text = "v-f layer"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.BurlyWood
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmdsqueezeforsafesd)
        Me.GroupBox2.Controls.Add(Me.txthtmlupdateDelay)
        Me.GroupBox2.Controls.Add(Me.chkanimationzym)
        Me.GroupBox2.Controls.Add(Me.cmdfillnormal)
        Me.GroupBox2.Controls.Add(Me.cmdstopgym)
        Me.GroupBox2.Controls.Add(Me.cmdhd)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.cmblayergames)
        Me.GroupBox2.Controls.Add(Me.cmdsd)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.cmdaddoutput)
        Me.GroupBox2.Controls.Add(Me.chkanimationforhdvan)
        Me.GroupBox2.Controls.Add(Me.eventlogo)
        Me.GroupBox2.Controls.Add(Me.cmbgames)
        Me.GroupBox2.Controls.Add(Me.gamelogo)
        Me.GroupBox2.Controls.Add(Me.cmdremoveoutput)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1222, 951)
        Me.GroupBox2.TabIndex = 1265
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " "
        '
        'ucCricket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1231, 955)
        Me.Controls.Add(Me.GroupBox2)
        Me.HideOnClose = True
        Me.Name = "ucCricket"
        Me.Text = "Cricket"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.eventlogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gamelogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cricket.ResumeLayout(False)
        Me.Cricket.PerformLayout()
        CType(Me.dgvFOW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pict2logocricket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pict1logocricket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tstwoliner.ResumeLayout(False)
        Me.tstwoliner.PerformLayout()
        CType(Me.dgvbowler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvbatsman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents eventlogo As System.Windows.Forms.PictureBox
    Friend WithEvents gamelogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkanimationzym As System.Windows.Forms.CheckBox
    Friend WithEvents cmdstopgym As System.Windows.Forms.Button
    Friend WithEvents cmdeventid As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkanimationforhdvan As System.Windows.Forms.CheckBox
    Friend WithEvents cmbgames As System.Windows.Forms.ComboBox
    Friend WithEvents cmdaddoutput As System.Windows.Forms.Button
    Friend WithEvents cmdremoveoutput As System.Windows.Forms.Button
    Friend WithEvents cmdsd As System.Windows.Forms.Button
    Friend WithEvents cmdhd As System.Windows.Forms.Button
    Friend WithEvents cmdsqueezeforsafesd As System.Windows.Forms.Button
    Friend WithEvents cmdfillnormal As System.Windows.Forms.Button
    Friend WithEvents cmbSubHeader As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHeader As System.Windows.Forms.ComboBox
    Friend WithEvents tmrtimeonform As System.Windows.Forms.Timer
    Friend WithEvents tmrtimeupdateontemplate As System.Windows.Forms.Timer
    Friend WithEvents tmrupdateontemplateextra As System.Windows.Forms.Timer
    Friend WithEvents ofd1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Cricket As System.Windows.Forms.TabPage
    Friend WithEvents cmdscore2update As System.Windows.Forms.Button
    Friend WithEvents cmdscore1update As System.Windows.Forms.Button
    Friend WithEvents cmdscoreupdate As System.Windows.Forms.Button
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents pict2logocricket As System.Windows.Forms.PictureBox
    Friend WithEvents pict1logocricket As System.Windows.Forms.PictureBox
    Friend WithEvents cmdclearbatsmanstatics As System.Windows.Forms.Button
    Friend WithEvents cmdrowdeletebatsman As System.Windows.Forms.Button
    Friend WithEvents cmdrowinsertbatsman As System.Windows.Forms.Button
    Friend WithEvents tstwoliner As System.Windows.Forms.ToolStrip
    Friend WithEvents newbatmandata As System.Windows.Forms.ToolStripButton
    Friend WithEvents openbatsmandata As System.Windows.Forms.ToolStripButton
    Friend WithEvents savebatsmandata As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdrowdownbatsman As System.Windows.Forms.Button
    Friend WithEvents cmdrowupbatsman As System.Windows.Forms.Button
    Friend WithEvents txtinfo1 As System.Windows.Forms.TextBox
    Friend WithEvents txtinfo2 As System.Windows.Forms.TextBox
    Friend WithEvents cmbinfo2 As System.Windows.Forms.TextBox
    Friend WithEvents cmbinfo1 As System.Windows.Forms.TextBox
    Friend WithEvents txtnb As System.Windows.Forms.TextBox
    Friend WithEvents txtwd As System.Windows.Forms.TextBox
    Friend WithEvents txtlb As System.Windows.Forms.TextBox
    Friend WithEvents txtby As System.Windows.Forms.TextBox
    Friend WithEvents txttotalextra As System.Windows.Forms.TextBox
    Friend WithEvents txttotalbatsmanvalue As System.Windows.Forms.TextBox
    Friend WithEvents txttotalbatsman As System.Windows.Forms.TextBox
    Friend WithEvents txtoversbatman As System.Windows.Forms.TextBox
    Friend WithEvents txtextrabatmanvalue As System.Windows.Forms.TextBox
    Friend WithEvents txtextrabatman As System.Windows.Forms.TextBox
    Friend WithEvents txtoversbatmanvalue As System.Windows.Forms.TextBox
    Friend WithEvents txtteamnameb As System.Windows.Forms.TextBox
    Friend WithEvents txtteamnamea As System.Windows.Forms.TextBox
    Friend WithEvents txtthisover As System.Windows.Forms.TextBox
    Friend WithEvents txtlastwicketat As System.Windows.Forms.TextBox
    Friend WithEvents txtmatchover As System.Windows.Forms.TextBox
    Friend WithEvents txt1stinningscore As System.Windows.Forms.TextBox
    Friend WithEvents txtover As System.Windows.Forms.TextBox
    Friend WithEvents txtinfo As System.Windows.Forms.TextBox
    Friend WithEvents txtwicket As System.Windows.Forms.TextBox
    Friend WithEvents txtovers As System.Windows.Forms.TextBox
    Friend WithEvents txtrun As System.Windows.Forms.TextBox
    Friend WithEvents txtteamname As System.Windows.Forms.TextBox
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents cmdplayeridbatsman As System.Windows.Forms.Button
    Friend WithEvents dgvbowler As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvbatsman As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents B As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents cmdscore2 As System.Windows.Forms.Button
    Friend WithEvents cmdscore1 As System.Windows.Forms.Button
    Friend WithEvents cmdcleardatascore As System.Windows.Forms.Button
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents cmdcleardatabowlerstatics As System.Windows.Forms.Button
    Friend WithEvents lblfilenamebowler As System.Windows.Forms.Label
    Friend WithEvents cmdbowlerstatus As System.Windows.Forms.Button
    Friend WithEvents cmdplayeridbowler As System.Windows.Forms.Button
    Friend WithEvents cmdbatsmanstatus As System.Windows.Forms.Button
    Friend WithEvents cmdrowupbowler As System.Windows.Forms.Button
    Friend WithEvents cmdrowdownbowler As System.Windows.Forms.Button
    Friend WithEvents cmdrowinsertbowler As System.Windows.Forms.Button
    Friend WithEvents lblfilenamebatsman As System.Windows.Forms.Label
    Friend WithEvents cmdrowdeletebowler As System.Windows.Forms.Button
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents newdatabowler As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsopendatabowler As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssavedatabowler As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdbowlingcard As System.Windows.Forms.Button
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents cmdbattingcard As System.Windows.Forms.Button
    Friend WithEvents cmdteamlinupbowler As System.Windows.Forms.Button
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents cmdteamlinupbatsman As System.Windows.Forms.Button
    Friend WithEvents lbllastwicketat As System.Windows.Forms.Label
    Friend WithEvents lblthisover As System.Windows.Forms.Label
    Friend WithEvents lblmatchover As System.Windows.Forms.Label
    Friend WithEvents lbl1stinningscore As System.Windows.Forms.Label
    Friend WithEvents cmbinfo As System.Windows.Forms.ComboBox
    Friend WithEvents cmdover As System.Windows.Forms.Button
    Friend WithEvents cmdwicket As System.Windows.Forms.Button
    Friend WithEvents cmdrun As System.Windows.Forms.Button
    Friend WithEvents cmdscore As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents chkStrinkingPostionB As System.Windows.Forms.CheckBox
    Friend WithEvents chkStrinkingPostionA As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoP11 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoP10 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoP9 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoP8 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoP7 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoP6 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoP5 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoP4 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoP3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoP2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoP1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoP0 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoB11 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoB10 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoB9 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoB8 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoB7 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoB6 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoB5 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoB4 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoB3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoB2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoB1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoB0 As System.Windows.Forms.RadioButton
    Friend WithEvents dgvFOW As System.Windows.Forms.DataGridView
    Friend WithEvents FOW1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdscore3update As System.Windows.Forms.Button
    Friend WithEvents txtinfo3 As System.Windows.Forms.TextBox
    Friend WithEvents cmdscore3 As System.Windows.Forms.Button
    Friend WithEvents cmbinfo3 As System.Windows.Forms.TextBox
    Friend WithEvents cmbinfo4 As TextBox
    Friend WithEvents cmdscore4update As Button
    Friend WithEvents txtinfo4 As TextBox
    Friend WithEvents cmdscore4 As Button
    Friend WithEvents cmbinfo7 As TextBox
    Friend WithEvents cmdscore7update As Button
    Friend WithEvents txtinfo7 As TextBox
    Friend WithEvents cmdscore7 As Button
    Friend WithEvents cmbinfo6 As TextBox
    Friend WithEvents cmdscore6update As Button
    Friend WithEvents txtinfo6 As TextBox
    Friend WithEvents cmdscore6 As Button
    Friend WithEvents cmbinfo5 As TextBox
    Friend WithEvents cmdscore5update As Button
    Friend WithEvents txtinfo5 As TextBox
    Friend WithEvents cmdscore5 As Button
    Friend WithEvents txttwoliner2 As TextBox
    Friend WithEvents txttwoliner1 As TextBox
    Friend WithEvents cmdtwoliner As Button
    Friend WithEvents txtoneliner As TextBox
    Friend WithEvents cmdonliner As Button
    Friend WithEvents txt3liner3 As TextBox
    Friend WithEvents txt3liner2 As TextBox
    Friend WithEvents txt3liner1 As TextBox
    Friend WithEvents cmd3liner As Button
    Friend WithEvents txthtmlupdateDelay As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents cmblayergames As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
