﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRemoteLogging
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
        Me.gbRemoteLogging = New System.Windows.Forms.GroupBox()
        Me.Label274 = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label276 = New System.Windows.Forms.Label()
        Me.cmbportgbRemoteLogging = New System.Windows.Forms.ComboBox()
        Me.txtgbRemoteLogging = New System.Windows.Forms.TextBox()
        Me.cmddisConnectRemoteLogging = New System.Windows.Forms.Button()
        Me.cmdConnectRemoteLogging = New System.Windows.Forms.Button()
        Me.gbRemoteLogging.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbRemoteLogging
        '
        Me.gbRemoteLogging.BackColor = System.Drawing.Color.Wheat
        Me.gbRemoteLogging.Controls.Add(Me.Label274)
        Me.gbRemoteLogging.Controls.Add(Me.LinkLabel3)
        Me.gbRemoteLogging.Controls.Add(Me.Label276)
        Me.gbRemoteLogging.Controls.Add(Me.cmbportgbRemoteLogging)
        Me.gbRemoteLogging.Controls.Add(Me.txtgbRemoteLogging)
        Me.gbRemoteLogging.Controls.Add(Me.cmddisConnectRemoteLogging)
        Me.gbRemoteLogging.Controls.Add(Me.cmdConnectRemoteLogging)
        Me.gbRemoteLogging.Location = New System.Drawing.Point(2, 3)
        Me.gbRemoteLogging.Name = "gbRemoteLogging"
        Me.gbRemoteLogging.Size = New System.Drawing.Size(660, 605)
        Me.gbRemoteLogging.TabIndex = 1175
        Me.gbRemoteLogging.TabStop = False
        Me.gbRemoteLogging.Text = "Remote Logging for Server 2.1 ( Useful when server is on rempte PC)"
        '
        'Label274
        '
        Me.Label274.AutoSize = True
        Me.Label274.Location = New System.Drawing.Point(397, 9)
        Me.Label274.Name = "Label274"
        Me.Label274.Size = New System.Drawing.Size(137, 13)
        Me.Label274.TabIndex = 1178
        Me.Label274.Text = "Download server from here."
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(397, 26)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(140, 13)
        Me.LinkLabel3.TabIndex = 1177
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "http://builds.casparcg.com/"
        '
        'Label276
        '
        Me.Label276.AutoSize = True
        Me.Label276.Location = New System.Drawing.Point(9, 26)
        Me.Label276.Name = "Label276"
        Me.Label276.Size = New System.Drawing.Size(26, 13)
        Me.Label276.TabIndex = 10
        Me.Label276.Text = "Port"
        '
        'cmbportgbRemoteLogging
        '
        Me.cmbportgbRemoteLogging.FormattingEnabled = True
        Me.cmbportgbRemoteLogging.Location = New System.Drawing.Point(41, 22)
        Me.cmbportgbRemoteLogging.Name = "cmbportgbRemoteLogging"
        Me.cmbportgbRemoteLogging.Size = New System.Drawing.Size(58, 21)
        Me.cmbportgbRemoteLogging.TabIndex = 9
        Me.cmbportgbRemoteLogging.Text = "3250"
        '
        'txtgbRemoteLogging
        '
        Me.txtgbRemoteLogging.Location = New System.Drawing.Point(12, 48)
        Me.txtgbRemoteLogging.Multiline = True
        Me.txtgbRemoteLogging.Name = "txtgbRemoteLogging"
        Me.txtgbRemoteLogging.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtgbRemoteLogging.Size = New System.Drawing.Size(636, 551)
        Me.txtgbRemoteLogging.TabIndex = 8
        '
        'cmddisConnectRemoteLogging
        '
        Me.cmddisConnectRemoteLogging.Enabled = False
        Me.cmddisConnectRemoteLogging.Location = New System.Drawing.Point(183, 21)
        Me.cmddisConnectRemoteLogging.Name = "cmddisConnectRemoteLogging"
        Me.cmddisConnectRemoteLogging.Size = New System.Drawing.Size(75, 23)
        Me.cmddisConnectRemoteLogging.TabIndex = 7
        Me.cmddisConnectRemoteLogging.Text = "Disconnect"
        Me.cmddisConnectRemoteLogging.UseVisualStyleBackColor = True
        '
        'cmdConnectRemoteLogging
        '
        Me.cmdConnectRemoteLogging.Location = New System.Drawing.Point(102, 21)
        Me.cmdConnectRemoteLogging.Name = "cmdConnectRemoteLogging"
        Me.cmdConnectRemoteLogging.Size = New System.Drawing.Size(75, 23)
        Me.cmdConnectRemoteLogging.TabIndex = 6
        Me.cmdConnectRemoteLogging.Text = "Connect"
        Me.cmdConnectRemoteLogging.UseVisualStyleBackColor = True
        '
        'ucRemoteLogging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(666, 613)
        Me.Controls.Add(Me.gbRemoteLogging)
        Me.HideOnClose = True
        Me.Name = "ucRemoteLogging"
        Me.Text = "Remote Logging"
        Me.gbRemoteLogging.ResumeLayout(False)
        Me.gbRemoteLogging.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbRemoteLogging As System.Windows.Forms.GroupBox
    Friend WithEvents Label276 As System.Windows.Forms.Label
    Friend WithEvents cmbportgbRemoteLogging As System.Windows.Forms.ComboBox
    Friend WithEvents txtgbRemoteLogging As System.Windows.Forms.TextBox
    Friend WithEvents cmddisConnectRemoteLogging As System.Windows.Forms.Button
    Friend WithEvents cmdConnectRemoteLogging As System.Windows.Forms.Button
    Friend WithEvents Label274 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel

End Class
