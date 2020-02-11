<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucElement
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucElement))
        Me.VlcControl1 = New Vlc.DotNet.Forms.VlcControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Decklink2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BluefishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StreamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HtmlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YoutubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendToBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BringToFrontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCaptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NDIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.VlcControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VlcControl1
        '
        Me.VlcControl1.BackColor = System.Drawing.Color.Black
        Me.VlcControl1.Location = New System.Drawing.Point(10, 16)
        Me.VlcControl1.Name = "VlcControl1"
        Me.VlcControl1.Size = New System.Drawing.Size(190, 142)
        Me.VlcControl1.Spu = -1
        Me.VlcControl1.TabIndex = 0
        Me.VlcControl1.Text = "VlcControl1"
        Me.VlcControl1.VlcLibDirectory = CType(resources.GetObject("VlcControl1.VlcLibDirectory"), System.IO.DirectoryInfo)
        Me.VlcControl1.VlcMediaplayerOptions = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "456"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(201, -2)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(15, 15)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "X"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UriToolStripMenuItem, Me.Decklink2ToolStripMenuItem, Me.BluefishToolStripMenuItem, Me.StreamToolStripMenuItem, Me.HtmlToolStripMenuItem, Me.YoutubeToolStripMenuItem, Me.SendToBackToolStripMenuItem, Me.BringToFrontToolStripMenuItem, Me.AddCaptionToolStripMenuItem, Me.NDIToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 246)
        '
        'UriToolStripMenuItem
        '
        Me.UriToolStripMenuItem.Name = "UriToolStripMenuItem"
        Me.UriToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UriToolStripMenuItem.Text = "uri"
        '
        'Decklink2ToolStripMenuItem
        '
        Me.Decklink2ToolStripMenuItem.Name = "Decklink2ToolStripMenuItem"
        Me.Decklink2ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Decklink2ToolStripMenuItem.Text = "Decklink"
        '
        'BluefishToolStripMenuItem
        '
        Me.BluefishToolStripMenuItem.Name = "BluefishToolStripMenuItem"
        Me.BluefishToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BluefishToolStripMenuItem.Text = "Bluefish"
        '
        'StreamToolStripMenuItem
        '
        Me.StreamToolStripMenuItem.Name = "StreamToolStripMenuItem"
        Me.StreamToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StreamToolStripMenuItem.Text = "Stream"
        '
        'HtmlToolStripMenuItem
        '
        Me.HtmlToolStripMenuItem.Name = "HtmlToolStripMenuItem"
        Me.HtmlToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HtmlToolStripMenuItem.Text = "html"
        '
        'YoutubeToolStripMenuItem
        '
        Me.YoutubeToolStripMenuItem.Name = "YoutubeToolStripMenuItem"
        Me.YoutubeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.YoutubeToolStripMenuItem.Text = "Youtube"
        '
        'SendToBackToolStripMenuItem
        '
        Me.SendToBackToolStripMenuItem.Name = "SendToBackToolStripMenuItem"
        Me.SendToBackToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SendToBackToolStripMenuItem.Text = "Send To Back"
        '
        'BringToFrontToolStripMenuItem
        '
        Me.BringToFrontToolStripMenuItem.Name = "BringToFrontToolStripMenuItem"
        Me.BringToFrontToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BringToFrontToolStripMenuItem.Text = "Bring To Front"
        '
        'AddCaptionToolStripMenuItem
        '
        Me.AddCaptionToolStripMenuItem.Name = "AddCaptionToolStripMenuItem"
        Me.AddCaptionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddCaptionToolStripMenuItem.Text = "Add Caption"
        '
        'NDIToolStripMenuItem
        '
        Me.NDIToolStripMenuItem.Name = "NDIToolStripMenuItem"
        Me.NDIToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NDIToolStripMenuItem.Text = "NDI"
        '
        'ucElement
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VlcControl1)
        Me.Name = "ucElement"
        Me.Size = New System.Drawing.Size(216, 167)
        CType(Me.VlcControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents VlcControl1 As Vlc.DotNet.Forms.VlcControl
    Public WithEvents Label1 As Label
    Friend WithEvents cmdClose As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents UriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Decklink2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BluefishToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StreamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HtmlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YoutubeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SendToBackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BringToFrontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCaptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NDIToolStripMenuItem As ToolStripMenuItem
End Class
