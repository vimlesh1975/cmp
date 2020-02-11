
Public Class ucPlayers
    Private Sub picPhoto_Click(sender As Object, e As EventArgs) Handles picPhoto.Click
        On Error Resume Next
        Dim aa As New OpenFileDialog
        aa.InitialDirectory = "c:\casparcg\mydata\games4\player\"
        If aa.ShowDialog = Windows.Forms.DialogResult.OK Then
            sender.ImageLocation = aa.FileName
            txtName.Text = UCase(Split(aa.SafeFileName, ".")(0))
            txtName.Tag = aa.FileName
            aa.Dispose()
        End If
    End Sub
    Private Sub picflag_Click(sender As Object, e As EventArgs) Handles picflag.Click
        On Error Resume Next
        Dim aa As New OpenFileDialog
        aa.InitialDirectory = "c:\casparcg\mydata\games4\country\"
        If aa.ShowDialog = Windows.Forms.DialogResult.OK Then
            sender.ImageLocation = aa.FileName
            txtCountry.Text = UCase(Split(aa.SafeFileName, ".")(0))
            txtCountry.Tag = aa.FileName
            aa.Dispose()
        End If
    End Sub
    Private Sub ucPlayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Sub openlogoandcountryfullnamesg1(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal txt As TextBox)
        On Error Resume Next
        Dim aa As New OpenFileDialog
        aa.InitialDirectory = "c:\casparcg\mydata\games4\player\"
        If aa.ShowDialog = Windows.Forms.DialogResult.OK Then
            sender.ImageLocation = aa.FileName
            txt.Text = UCase(Split(aa.SafeFileName, ".")(0))
            txt.Tag = aa.FileName
            aa.Dispose()
        End If
    End Sub
    Private Sub cmdShowID_Click(sender As Object, e As EventArgs) Handles cmdShowID.Click
        On Error Resume Next
        If ucdc.chkanimationzym.Checked Then ucdc.animation1()
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f1", txtName.Text)
        CasparCGDataCollection.SetData("f2", txtCountry.Text)
        CasparCGDataCollection.SetData("loader1", txtCountry.Tag)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(ucdc.cmblayergames.Text), Int(ucdc.cmblayergames.Text), "cmp/games4/davis_cup/dc_namestrap", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If ucdc.chkanimationzym.Checked Then ucdc.animationtoscreen()
    End Sub
    Private Sub cmdProfile_Click(sender As Object, e As EventArgs) Handles cmdProfile.Click
        On Error Resume Next
        If ucdc.chkanimationzym.Checked Then ucdc.animation1()
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("f0", txtName.Text)
        CasparCGDataCollection.SetData("f1", txtCountry.Text)
        CasparCGDataCollection.SetData("f2", txtage.Text)
        CasparCGDataCollection.SetData("f3", txtheight.Text)
        CasparCGDataCollection.SetData("f4", txtweight.Text)
        CasparCGDataCollection.SetData("f5", txtwr.Text)
        CasparCGDataCollection.SetData("f6", txtappearance.Text)
        CasparCGDataCollection.SetData("f7", txtsinglewin.Text)
        CasparCGDataCollection.SetData("f8", txtsinglelosses.Text)
        CasparCGDataCollection.SetData("f9", txtdebut.Text)

        CasparCGDataCollection.SetData("loader1", txtCountry.Tag)

        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(ucdc.cmblayergames.Text), Int(ucdc.cmblayergames.Text), "cmp/games4/davis_cup/dc_playerprofile", True, CasparCGDataCollection.ToAMCPEscapedXml)
        If ucdc.chkanimationzym.Checked Then ucdc.animationtoscreen()
    End Sub
End Class
