Imports System.Net.Sockets


Public Class ucUdpChat

    Dim udpClient As New UdpClient

    Public receivingUdpClient As UdpClient
    Public ThreadReceive As System.Threading.Thread
    Public RemoteIpEndPoint As New System.Net.IPEndPoint(System.Net.IPAddress.Any, 0)
    Private Sub cmdhidegbudp_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub cmdudpsend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdudpsend.Click
        On Error Resume Next

        udpClient.Send(System.Text.Encoding.ASCII.GetBytes(txtudpdata.Text), System.Text.Encoding.ASCII.GetBytes(txtudpdata.Text).Length, txtudpip.Text, txtudpport.Text)

    End Sub

    Private Sub cmdudpreceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdudpreceive.Click
        On Error Resume Next

        Dim rport As Integer = txtudpportreceive.Text
        receivingUdpClient = New System.Net.Sockets.UdpClient(rport)
        NewInitialize()

        sender.enabled = False
        cmdstopreceive.Enabled = True

        txtudpportreceive.Enabled = False
    End Sub
   
  
    Public Sub ReceiveMessages()
        On Error Resume Next
        Dim receiveBytes As [Byte]() = receivingUdpClient.Receive(RemoteIpEndPoint)
        Dim strReturnData As String = System.Text.Encoding.ASCII.GetString(receiveBytes)
        txtudprereceive.Text = strReturnData
      
        NewInitialize()
    End Sub
    Public Sub NewInitialize()
        On Error Resume Next
        ThreadReceive = New System.Threading.Thread(AddressOf ReceiveMessages)
        ThreadReceive.Start()
    End Sub

    Private Sub cmdInterchangeports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInterchangeports.Click
        On Error Resume Next
        Dim aaa As Integer = txtudpport.Text
        Dim bbb As Integer = txtudpportreceive.Text
        txtudpport.Text = bbb
        txtudpportreceive.Text = aaa
    End Sub

    Private Sub cmdstopreceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopreceive.Click
        On Error Resume Next
        ThreadReceive.Abort()
        receivingUdpClient.Close()

        sender.Enabled = False
        cmdudpreceive.Enabled = True
        txtudpportreceive.Enabled = True
    End Sub

    Private Sub ucUdpChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub
End Class
