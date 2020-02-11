Imports System.Net.Sockets

Public Class ucRemoteLogging
    Private m_DataBuffer As Byte() = New Byte(9) {}
    Private m_asynResult As IAsyncResult
    Public pfnCallBack As AsyncCallback
    Public m_socClient As Socket
    Public Class CSocketPacket
        Public thisSocket As System.Net.Sockets.Socket
        Public dataBuffer As Byte() = New Byte(0) {}
    End Class
    Private Sub cmdConnectRemoteLogging_Click(sender As Object, e As EventArgs) Handles cmdConnectRemoteLogging.Click
        On Error Resume Next
        m_socClient = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        m_socClient.Connect(frmmediaplayer.cmbhost.Text, cmbportgbRemoteLogging.Text)
        If m_socClient.Connected Then
            cmdConnectRemoteLogging.Enabled = False
            cmddisConnectRemoteLogging.Enabled = True

            WaitForData()
        Else
            m_socClient = Nothing
        End If
    End Sub
    Public Sub OnDataReceived(asyn As IAsyncResult)
        On Error Resume Next
        Control.CheckForIllegalCrossThreadCalls = False

        Dim theSockId As CSocketPacket = DirectCast(asyn.AsyncState, CSocketPacket)
        'end receive...
        Dim iRx As Integer = 0
        iRx = theSockId.thisSocket.EndReceive(asyn)
        Dim chars As Char() = New Char(iRx) {}
        Dim d As System.Text.Decoder = System.Text.Encoding.UTF8.GetDecoder()
        Dim charLen As Integer = d.GetChars(theSockId.dataBuffer, 0, iRx, chars, 0)
        Dim szData As New System.String(chars)

        txtgbRemoteLogging.AppendText(szData)
        WaitForData()

    End Sub
    Private Sub cmddisConnectRemoteLogging_Click(sender As Object, e As EventArgs) Handles cmddisConnectRemoteLogging.Click
        On Error Resume Next
        If m_socClient IsNot Nothing Then
            m_socClient.Dispose()
            m_socClient.Close()
            m_socClient = Nothing
            cmdConnectRemoteLogging.Enabled = True
            cmddisConnectRemoteLogging.Enabled = False
        End If
    End Sub

    Public Sub WaitForData()
        On Error Resume Next
        If pfnCallBack Is Nothing Then
            pfnCallBack = New AsyncCallback(AddressOf OnDataReceived)
        End If
        Dim theSocPkt As New CSocketPacket()
        theSocPkt.thisSocket = m_socClient

        m_asynResult = m_socClient.BeginReceive(theSocPkt.dataBuffer, 0, theSocPkt.dataBuffer.Length, SocketFlags.None, pfnCallBack, theSocPkt)

    End Sub


End Class
