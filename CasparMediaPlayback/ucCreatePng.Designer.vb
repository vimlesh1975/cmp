<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCreatePng
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
        Me.gbCreatePNG = New System.Windows.Forms.GroupBox()
        Me.chkaaddimagetoplaylist = New System.Windows.Forms.CheckBox()
        Me.txtaddimagename = New System.Windows.Forms.TextBox()
        Me.cmdaddimage = New System.Windows.Forms.Button()
        Me.gbCreatePNG.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCreatePNG
        '
        Me.gbCreatePNG.BackColor = System.Drawing.Color.PapayaWhip
        Me.gbCreatePNG.Controls.Add(Me.chkaaddimagetoplaylist)
        Me.gbCreatePNG.Controls.Add(Me.txtaddimagename)
        Me.gbCreatePNG.Controls.Add(Me.cmdaddimage)
        Me.gbCreatePNG.Location = New System.Drawing.Point(3, 3)
        Me.gbCreatePNG.Name = "gbCreatePNG"
        Me.gbCreatePNG.Size = New System.Drawing.Size(139, 78)
        Me.gbCreatePNG.TabIndex = 732
        Me.gbCreatePNG.TabStop = False
        Me.gbCreatePNG.Text = "Create PNG"
        '
        'chkaaddimagetoplaylist
        '
        Me.chkaaddimagetoplaylist.AutoSize = True
        Me.chkaaddimagetoplaylist.Location = New System.Drawing.Point(7, 56)
        Me.chkaaddimagetoplaylist.Name = "chkaaddimagetoplaylist"
        Me.chkaaddimagetoplaylist.Size = New System.Drawing.Size(123, 17)
        Me.chkaaddimagetoplaylist.TabIndex = 730
        Me.chkaaddimagetoplaylist.Text = "Add image to Playlist"
        Me.chkaaddimagetoplaylist.UseVisualStyleBackColor = True
        '
        'txtaddimagename
        '
        Me.txtaddimagename.Location = New System.Drawing.Point(7, 14)
        Me.txtaddimagename.Name = "txtaddimagename"
        Me.txtaddimagename.Size = New System.Drawing.Size(123, 20)
        Me.txtaddimagename.TabIndex = 729
        Me.txtaddimagename.Text = "testpng"
        Me.txtaddimagename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdaddimage
        '
        Me.cmdaddimage.Location = New System.Drawing.Point(7, 34)
        Me.cmdaddimage.Name = "cmdaddimage"
        Me.cmdaddimage.Size = New System.Drawing.Size(123, 22)
        Me.cmdaddimage.TabIndex = 728
        Me.cmdaddimage.Text = "Create PNG Image"
        Me.cmdaddimage.UseVisualStyleBackColor = True
        '
        'ucCreatePng
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.gbCreatePNG)
        Me.Name = "ucCreatePng"
        Me.Size = New System.Drawing.Size(145, 85)
        Me.gbCreatePNG.ResumeLayout(False)
        Me.gbCreatePNG.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbCreatePNG As GroupBox
    Friend WithEvents chkaaddimagetoplaylist As CheckBox
    Friend WithEvents txtaddimagename As TextBox
    Friend WithEvents cmdaddimage As Button
End Class
