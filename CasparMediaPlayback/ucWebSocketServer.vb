

Imports System.Net
Imports System.Net.WebSockets
Imports System.Text
Imports System.Threading
Public Class ucWebSocketServer
    Private Sub ucWebSocketServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub cmdStartWebSocketServer_Click(sender As Object, e As EventArgs) Handles cmdStartWebSocketServer.Click
        Start(txtwsport.Text & "/")

    End Sub
    Public Async Sub Start(ByVal httpListenerPrefix As String)
        Dim httpListener As HttpListener = New HttpListener()
        httpListener.Prefixes.Add(httpListenerPrefix)
        httpListener.Start()
        Label1.Text = "listening"
        While True
            Dim httpListenerContext As HttpListenerContext = Await httpListener.GetContextAsync()
            If httpListenerContext.Request.IsWebSocketRequest Then
                ProcessRequest(httpListenerContext)
            Else
                httpListenerContext.Response.StatusCode = 400
                httpListenerContext.Response.Close()
            End If
        End While
    End Sub
    Private Async Sub ProcessRequest(ByVal httpListenerContext As HttpListenerContext)
        Dim webSocketContext As WebSocketContext = Nothing

        Try
            webSocketContext = Await httpListenerContext.AcceptWebSocketAsync(subProtocol:=Nothing)
            Dim ipAddress As String = httpListenerContext.Request.RemoteEndPoint.Address.ToString()
            Label1.Text = "Connected to " & ipAddress
        Catch e As Exception
            httpListenerContext.Response.StatusCode = 500
            httpListenerContext.Response.Close()
            Label1.Text = e.ToString
            Return
        End Try
        Dim webSocket As WebSocket = webSocketContext.WebSocket
        Try
            While webSocket.State = WebSocketState.Open
                Dim receiveBuffer As Byte() = New Byte(10023) {}
                Dim sendBuffer As Byte() = System.Text.Encoding.Unicode.GetBytes("file Playing: " & frmmediaplayer.ucCasparcgWindow1.lblplaying.Text & " Time Remaining: " & frmmediaplayer.lblremainintime.Text & " Frames Played: " & ucOSC.dgvosc.Rows(6).Cells(1).Value)
                Dim receiveResult As WebSocketReceiveResult = Await webSocket.ReceiveAsync(New ArraySegment(Of Byte)(receiveBuffer), CancellationToken.None)

                If receiveResult.MessageType = WebSocketMessageType.Close Then
                    Await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None)
                Else
                    Await webSocket.SendAsync(New ArraySegment(Of Byte)(sendBuffer, 0, sendBuffer.Count), WebSocketMessageType.Text, True, CancellationToken.None)
                    Dim aa1 = Split(Encoding.UTF8.GetString(receiveBuffer), vbLf)
                    hiddenText.Text = ""
                    For i = 0 To aa1.Count - 1
                        hiddenText.Text = hiddenText.Text & aa1(i) & vbNewLine
                    Next
                    If chkSendtoCasparCG.Checked And hiddenText.Text <> "" Then
                        CasparDevice.SendString(hiddenText.Text)
                    End If

                End If
            End While

        Catch e As Exception
            MsgBox(e.ToString)
        Finally
            If webSocket IsNot Nothing Then webSocket.Dispose()
        End Try
    End Sub
    Private Sub cmdhidews_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub cmdOpenWebSocketClientPage_Click(sender As Object, e As EventArgs) Handles cmdOpenWebSocketClientPage.Click
        Process.Start("C:\casparcg\mydata\ws\ws1.html")
    End Sub
End Class