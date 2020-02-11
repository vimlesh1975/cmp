<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm4channle
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me._4ChannelConnector1 = New _4Channels._4ChannelConnector()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me._4ChannelConnector2 = New _4Channels._4ChannelConnector()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me._4ChannelConnector3 = New _4Channels._4ChannelConnector()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me._4ChannelConnector4 = New _4Channels._4ChannelConnector()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(2025, 1106)
        Me.TabControl1.TabIndex = 4
        Me.TabControl1.Tag = "2"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me._4ChannelConnector1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(2017, 1080)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = "1"
        Me.TabPage1.Text = "Channel 1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        '_4ChannelConnector1
        '
        Me._4ChannelConnector1.Location = New System.Drawing.Point(0, 0)
        Me._4ChannelConnector1.Name = "_4ChannelConnector1"
        Me._4ChannelConnector1.Size = New System.Drawing.Size(576, 41)
        Me._4ChannelConnector1.TabIndex = 17
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me._4ChannelConnector2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(2017, 1080)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Tag = "2"
        Me.TabPage2.Text = "Channel 2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        '_4ChannelConnector2
        '
        Me._4ChannelConnector2.Location = New System.Drawing.Point(0, 0)
        Me._4ChannelConnector2.Name = "_4ChannelConnector2"
        Me._4ChannelConnector2.Size = New System.Drawing.Size(468, 41)
        Me._4ChannelConnector2.TabIndex = 18
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me._4ChannelConnector3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(2017, 1080)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Tag = "3"
        Me.TabPage3.Text = "Channel 3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        '_4ChannelConnector3
        '
        Me._4ChannelConnector3.Location = New System.Drawing.Point(0, 0)
        Me._4ChannelConnector3.Name = "_4ChannelConnector3"
        Me._4ChannelConnector3.Size = New System.Drawing.Size(468, 41)
        Me._4ChannelConnector3.TabIndex = 18
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me._4ChannelConnector4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(2017, 1080)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Tag = "4"
        Me.TabPage4.Text = "Channel 4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        '_4ChannelConnector4
        '
        Me._4ChannelConnector4.Location = New System.Drawing.Point(0, 0)
        Me._4ChannelConnector4.Name = "_4ChannelConnector4"
        Me._4ChannelConnector4.Size = New System.Drawing.Size(468, 41)
        Me._4ChannelConnector4.TabIndex = 18
        '
        'frm4channle
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm4channle"
        Me.Text = "4 Channel CMP"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents _4ChannelConnector1 As _4ChannelConnector
    Friend WithEvents _4ChannelConnector2 As _4ChannelConnector
    Friend WithEvents _4ChannelConnector3 As _4ChannelConnector
    Friend WithEvents _4ChannelConnector4 As _4ChannelConnector
End Class
