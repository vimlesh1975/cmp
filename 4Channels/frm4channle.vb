Public Class frm4channle
    Private Sub frm4channle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        If Not _4ChannelConnector1.parentedProcess1 Is Nothing Then
            _4ChannelConnector1.SetParent(_4ChannelConnector1.parentedProcess1.MainWindowHandle, Nothing)
        End If
        If Not _4ChannelConnector2.parentedProcess1 Is Nothing Then
            _4ChannelConnector2.SetParent(_4ChannelConnector2.parentedProcess1.MainWindowHandle, Nothing)
        End If
        If Not _4ChannelConnector3.parentedProcess1 Is Nothing Then
            _4ChannelConnector3.SetParent(_4ChannelConnector3.parentedProcess1.MainWindowHandle, Nothing)
        End If
        If Not _4ChannelConnector4.parentedProcess1 Is Nothing Then
            _4ChannelConnector4.SetParent(_4ChannelConnector4.parentedProcess1.MainWindowHandle, Nothing)
        End If
    End Sub
    Private Sub frm4channle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub _4ChannelConnector1_Load(sender As Object, e As EventArgs) Handles _4ChannelConnector1.Load
    End Sub
End Class
