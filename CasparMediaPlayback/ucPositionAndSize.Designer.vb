<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPositionAndSize
    Inherits System.Windows.Forms.UserControl

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucPositionAndSize))
        Me.nfillx = New System.Windows.Forms.NumericUpDown()
        Me.nfilly = New System.Windows.Forms.NumericUpDown()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.nfillwidth = New System.Windows.Forms.NumericUpDown()
        Me.nfillheight = New System.Windows.Forms.NumericUpDown()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.cmdfill = New System.Windows.Forms.Button()
        Me.cmbVideoLayerforPositionAndSize = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdhidegboscmonitor = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.nfillx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nfilly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nfillwidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nfillheight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'nfillx
        '
        Me.nfillx.DecimalPlaces = 2
        Me.nfillx.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nfillx.Location = New System.Drawing.Point(58, 30)
        Me.nfillx.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nfillx.Minimum = New Decimal(New Integer() {2, 0, 0, -2147483648})
        Me.nfillx.Name = "nfillx"
        Me.nfillx.Size = New System.Drawing.Size(46, 20)
        Me.nfillx.TabIndex = 417
        Me.nfillx.Value = Global.caspar_media_playback.My.MySettings.Default.nfillx
        '
        'nfilly
        '
        Me.nfilly.DecimalPlaces = 2
        Me.nfilly.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nfilly.Location = New System.Drawing.Point(58, 54)
        Me.nfilly.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nfilly.Minimum = New Decimal(New Integer() {2, 0, 0, -2147483648})
        Me.nfilly.Name = "nfilly"
        Me.nfilly.Size = New System.Drawing.Size(46, 20)
        Me.nfilly.TabIndex = 416
        Me.nfilly.Value = Global.caspar_media_playback.My.MySettings.Default.nfilly
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(13, 103)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(44, 13)
        Me.Label43.TabIndex = 415
        Me.Label43.Text = "Y Scale"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(13, 83)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(44, 13)
        Me.Label44.TabIndex = 414
        Me.Label44.Text = "X Scale"
        '
        'nfillwidth
        '
        Me.nfillwidth.DecimalPlaces = 2
        Me.nfillwidth.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nfillwidth.Location = New System.Drawing.Point(58, 78)
        Me.nfillwidth.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nfillwidth.Name = "nfillwidth"
        Me.nfillwidth.Size = New System.Drawing.Size(46, 20)
        Me.nfillwidth.TabIndex = 413
        Me.nfillwidth.Value = Global.caspar_media_playback.My.MySettings.Default.nfillwidth
        '
        'nfillheight
        '
        Me.nfillheight.DecimalPlaces = 2
        Me.nfillheight.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nfillheight.Location = New System.Drawing.Point(58, 102)
        Me.nfillheight.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nfillheight.Name = "nfillheight"
        Me.nfillheight.Size = New System.Drawing.Size(46, 20)
        Me.nfillheight.TabIndex = 412
        Me.nfillheight.Value = Global.caspar_media_playback.My.MySettings.Default.nfillheight
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(42, 57)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(14, 13)
        Me.Label45.TabIndex = 410
        Me.Label45.Text = "Y"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(40, 36)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(14, 13)
        Me.Label46.TabIndex = 408
        Me.Label46.Text = "X"
        '
        'cmdfill
        '
        Me.cmdfill.Location = New System.Drawing.Point(107, 28)
        Me.cmdfill.Name = "cmdfill"
        Me.cmdfill.Size = New System.Drawing.Size(21, 94)
        Me.cmdfill.TabIndex = 407
        Me.cmdfill.Text = "R"
        Me.cmdfill.UseVisualStyleBackColor = True
        '
        'cmbVideoLayerforPositionAndSize
        '
        Me.cmbVideoLayerforPositionAndSize.FormattingEnabled = True
        Me.cmbVideoLayerforPositionAndSize.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbVideoLayerforPositionAndSize.Location = New System.Drawing.Point(71, 4)
        Me.cmbVideoLayerforPositionAndSize.Name = "cmbVideoLayerforPositionAndSize"
        Me.cmbVideoLayerforPositionAndSize.Size = New System.Drawing.Size(37, 21)
        Me.cmbVideoLayerforPositionAndSize.TabIndex = 418
        Me.cmbVideoLayerforPositionAndSize.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 419
        Me.Label1.Text = "Video Layer"
        '
        'cmdhidegboscmonitor
        '
        Me.cmdhidegboscmonitor.Image = CType(resources.GetObject("cmdhidegboscmonitor.Image"), System.Drawing.Image)
        Me.cmdhidegboscmonitor.Location = New System.Drawing.Point(111, 0)
        Me.cmdhidegboscmonitor.Name = "cmdhidegboscmonitor"
        Me.cmdhidegboscmonitor.Size = New System.Drawing.Size(28, 27)
        Me.cmdhidegboscmonitor.TabIndex = 726
        Me.cmdhidegboscmonitor.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox1.Controls.Add(Me.cmdhidegboscmonitor)
        Me.GroupBox1.Controls.Add(Me.nfillwidth)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label44)
        Me.GroupBox1.Controls.Add(Me.cmbVideoLayerforPositionAndSize)
        Me.GroupBox1.Controls.Add(Me.nfillheight)
        Me.GroupBox1.Controls.Add(Me.cmdfill)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.nfillx)
        Me.GroupBox1.Controls.Add(Me.Label45)
        Me.GroupBox1.Controls.Add(Me.Label46)
        Me.GroupBox1.Controls.Add(Me.nfilly)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 126)
        Me.GroupBox1.TabIndex = 727
        Me.GroupBox1.TabStop = False
        '
        'ucPositionAndSize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ucPositionAndSize"
        Me.Size = New System.Drawing.Size(149, 130)
        CType(Me.nfillx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nfilly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nfillwidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nfillheight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbVideoLayerforPositionAndSize As ComboBox
    Friend WithEvents nfillx As NumericUpDown
    Friend WithEvents nfilly As NumericUpDown
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents nfillwidth As NumericUpDown
    Friend WithEvents nfillheight As NumericUpDown
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents cmdfill As Button
    Friend WithEvents cmdhidegboscmonitor As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
