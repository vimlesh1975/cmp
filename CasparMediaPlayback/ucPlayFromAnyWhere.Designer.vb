<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPlayFromAnyWhere
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
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.cmdPlayFromAnywhere = New System.Windows.Forms.Button()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCue = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkloop = New System.Windows.Forms.CheckBox()
        Me.cmdOpenFromAnyWhere = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdfileinfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFileName
        '
        Me.lblFileName.Location = New System.Drawing.Point(12, 5)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(309, 48)
        Me.lblFileName.TabIndex = 0
        Me.lblFileName.Text = "FileName"
        '
        'cmdPlayFromAnywhere
        '
        Me.cmdPlayFromAnywhere.BackColor = System.Drawing.Color.Green
        Me.cmdPlayFromAnywhere.ForeColor = System.Drawing.Color.White
        Me.cmdPlayFromAnywhere.Location = New System.Drawing.Point(510, 1)
        Me.cmdPlayFromAnywhere.Name = "cmdPlayFromAnywhere"
        Me.cmdPlayFromAnywhere.Size = New System.Drawing.Size(60, 23)
        Me.cmdPlayFromAnywhere.TabIndex = 2
        Me.cmdPlayFromAnywhere.Text = "Play"
        Me.cmdPlayFromAnywhere.UseVisualStyleBackColor = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(4, 52)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(60, 23)
        Me.cmdRefresh.TabIndex = 3
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(331, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "For Scrubbing Go to ""Playlist Setting"" module and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Deselect check box ""send file " &
    "name without extension"""
        '
        'cmdCue
        '
        Me.cmdCue.Location = New System.Drawing.Point(451, 1)
        Me.cmdCue.Name = "cmdCue"
        Me.cmdCue.Size = New System.Drawing.Size(56, 23)
        Me.cmdCue.TabIndex = 713
        Me.cmdCue.Text = "Cue"
        Me.cmdCue.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(492, 13)
        Me.Label2.TabIndex = 714
        Me.Label2.Text = "Files in root drives are not shown in This Explorer.  For this, right button can " &
    "be used."
        '
        'chkloop
        '
        Me.chkloop.AutoSize = True
        Me.chkloop.Location = New System.Drawing.Point(573, 5)
        Me.chkloop.Name = "chkloop"
        Me.chkloop.Size = New System.Drawing.Size(50, 17)
        Me.chkloop.TabIndex = 715
        Me.chkloop.Text = "Loop"
        Me.chkloop.UseVisualStyleBackColor = True
        '
        'cmdOpenFromAnyWhere
        '
        Me.cmdOpenFromAnyWhere.Location = New System.Drawing.Point(520, 73)
        Me.cmdOpenFromAnyWhere.Name = "cmdOpenFromAnyWhere"
        Me.cmdOpenFromAnyWhere.Size = New System.Drawing.Size(134, 23)
        Me.cmdOpenFromAnyWhere.TabIndex = 716
        Me.cmdOpenFromAnyWhere.Text = "Open From Any Where"
        Me.ToolTip1.SetToolTip(Me.cmdOpenFromAnyWhere, "Open From Any Where")
        Me.cmdOpenFromAnyWhere.UseVisualStyleBackColor = True
        '
        'cmdfileinfo
        '
        Me.cmdfileinfo.Location = New System.Drawing.Point(327, 1)
        Me.cmdfileinfo.Name = "cmdfileinfo"
        Me.cmdfileinfo.Size = New System.Drawing.Size(121, 23)
        Me.cmdfileinfo.TabIndex = 717
        Me.cmdfileinfo.Text = "Show File Information"
        Me.cmdfileinfo.UseVisualStyleBackColor = True
        '
        'ucPlayFromAnyWhere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(1221, 749)
        Me.Controls.Add(Me.cmdfileinfo)
        Me.Controls.Add(Me.cmdOpenFromAnyWhere)
        Me.Controls.Add(Me.chkloop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdCue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.cmdPlayFromAnywhere)
        Me.Controls.Add(Me.lblFileName)
        Me.HideOnClose = True
        Me.Name = "ucPlayFromAnyWhere"
        Me.Text = "Play From Anywhere"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents cmdPlayFromAnywhere As System.Windows.Forms.Button
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdCue As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkloop As System.Windows.Forms.CheckBox
    Friend WithEvents cmdOpenFromAnyWhere As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdfileinfo As Button
End Class
