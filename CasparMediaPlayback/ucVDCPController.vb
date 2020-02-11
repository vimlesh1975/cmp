Imports System.Net.Sockets
Imports System.Text
Imports System.IO

Public Class ucVDCPController
    Private m_DataBuffer As Byte() = New Byte(9) {}
    Private m_asynResult As IAsyncResult
    Public pfnCallBack As AsyncCallback
    Public m_socClient As Socket

    Dim client As New TcpClient
    Dim NetStream As NetworkStream

    Dim fps As Decimal = 25

    Dim currrow As Integer
    Dim tempRow As DataGridViewRow

    Public Class CSocketPacket
        Public thisSocket As System.Net.Sockets.Socket
        Public dataBuffer As Byte() = New Byte(0) {}
    End Class
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
    Private Sub cmdConnectRemoteLogging_Click(sender As Object, e As EventArgs) Handles cmdConnectRemoteLogging.Click
        On Error Resume Next
        m_socClient = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        m_socClient.Connect(cmbhost.Text, cmbportgbRemoteLogging.Text)

        If m_socClient.Connected Then
            cmdConnectRemoteLogging.Enabled = False
            cmddisConnectRemoteLogging.Enabled = True

            WaitForData()
        Else
            m_socClient = Nothing
        End If
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
    Private Sub cmdtcpsend_Click(sender As Object, e As EventArgs) Handles cmdtcpsend.Click
        On Error Resume Next
        Dim byData As [Byte]() = System.Text.Encoding.ASCII.GetBytes(txttcpsend.Text + vbCrLf)
        m_socClient.Send(byData)

    End Sub
    Sub SendString(ByVal Stream As NetworkStream, ByVal Data As String)
        On Error Resume Next
        Dim Bytes As [Byte]() = Encoding.UTF8.GetBytes(Data)
        If Stream.CanTimeout Then
            Stream.WriteTimeout = 1000 * 5
        End If
        Stream.Write(Bytes, 0, Bytes.Length)
        Return
    End Sub

    Sub GetSerialPortNames()
        On Error Resume Next
        cmbportsvtr.Items.AddRange(IO.Ports.SerialPort.GetPortNames())
    End Sub

    Private Sub initialisedatafordgvcuepointsvtr()
        dgvcuepointsvtr.Rows.Add(10)
        dgvcuepointsvtr.Rows(0).Cells(0).Value = "00:00:00:00"
        dgvcuepointsvtr.Rows(1).Cells(0).Value = "00:01:00:00"
        dgvcuepointsvtr.Rows(2).Cells(0).Value = "00:02:00:00"
        dgvcuepointsvtr.Rows(3).Cells(0).Value = "00:03:00:00"
        dgvcuepointsvtr.Rows(4).Cells(0).Value = "00:04:00:00"
        dgvcuepointsvtr.Rows(5).Cells(0).Value = "00:05:00:00"
        dgvcuepointsvtr.Rows(6).Cells(0).Value = "00:06:00:00"
        dgvcuepointsvtr.Rows(7).Cells(0).Value = "00:07:00:00"
        dgvcuepointsvtr.Rows(8).Cells(0).Value = "00:08:00:00"
        dgvcuepointsvtr.Rows(9).Cells(0).Value = "00:09:00:00"
        dgvcuepointsvtr.CurrentCell = dgvcuepointsvtr.Rows(2).Cells(0)
    End Sub
    Sub openport()
        On Error Resume Next
        If sp.IsOpen = False Then
            sp.PortName = cmbportsvtr.Text
            sp.Encoding = System.Text.Encoding.Default
            sp.Open()
        End If
        'tmrgettc.Enabled = True
    End Sub
    Sub closeport()
        On Error Resume Next
        If sp.IsOpen = True Then
            sp.PortName = cmbportsvtr.Text
            sp.Encoding = System.Text.Encoding.Default
            sp.Close()
        End If
        'tmrgettc.Enabled = False
    End Sub
    Private Sub tmrgettc_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrgettc.Tick
        On Error Resume Next
        sp.WriteLine(Chr(97) & Chr(12) & Chr(1) & Chr(110))
        Threading.Thread.Sleep(15)

        Dim timecode As String = ""
        Dim bb As String = sp.ReadExisting

        Dim str As String = ""
        For ivtr = 3 To Len(bb) - 1
            str = Mid(bb, ivtr, 1)
            Dim byteArray() As Byte
            byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(str)
            timecode = Val(Hex(byteArray(0))).ToString("00") & ":" & timecode
        Next
        lbltimecode.Text = Mid(timecode, 13, 11)
    End Sub
    Private Sub cmdopenportsvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdopenportsvtr.Click
        On Error Resume Next
        openport()
    End Sub

    Private Sub cmdplayvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplayvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(CInt("&H20")) & Chr(1) & Chr(33))
    End Sub

    Private Sub cmdstopvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstopvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(0) & Chr(32))
    End Sub

    Private Sub cmdrewindvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrewindvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(32) & Chr(64))
    End Sub
    Private Sub cmdffvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdffvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(16) & Chr(48))
    End Sub

    Private Sub cmdinpointvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdinpointvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(64) & Chr(16) & Chr(80))
        lblinpointvtr.Text = lbltimecode.Text
    End Sub

    Private Sub cmdoutpointvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdoutpointvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(64) & Chr(17) & Chr(81))
        lbloutpointvtr.Text = lbltimecode.Text
    End Sub

    Private Sub cmdPreRollvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreRollvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(48) & Chr(80))
    End Sub

    Private Sub cmdejectvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdejectvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(15) & Chr(47))
    End Sub

    Private Sub cmdstandbyonvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstandbyonvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(5) & Chr(37))
    End Sub

    Private Sub cmdstandbyoffvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstandbyoffvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(4) & Chr(36))
    End Sub

    Private Sub cmdcuevtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcuevtr.Click
        On Error Resume Next

        Dim aa As Array = Split(dgvcuepointsvtr.CurrentRow.Cells(0).Value, ":")
        Dim bb As String = Chr(36) & Chr(49) & Chr(System.Convert.ToInt32(aa(3), 16)) & Chr(System.Convert.ToInt32(aa(2), 16)) & Chr(System.Convert.ToInt32(aa(1), 16)) & Chr(System.Convert.ToInt32(aa(0), 16)) &
         Chr(36 + 49 + System.Convert.ToInt32(aa(3), 16) + System.Convert.ToInt32(aa(2), 16) + System.Convert.ToInt32(aa(1), 16) + System.Convert.ToInt32(aa(0), 16))
        sp.WriteLine(bb)
    End Sub

    Private Sub cmdmarkvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmarkvtr.Click
        On Error Resume Next
        dgvcuepointsvtr.CurrentRow.Cells(0).Value = lbltimecode.Text
        dgvcuepointsvtr.Rows.Add()
        dgvcuepointsvtr.CurrentCell = dgvcuepointsvtr.Rows(dgvcuepointsvtr.CurrentRow.Index + 1).Cells(0)

    End Sub
    Sub submouseleave() Handles HScrollBarjogvtr.MouseLeave, HScrollBarvtr.MouseLeave, HScrollBarshuttlevtr.MouseLeave
        On Error Resume Next
        HScrollBarjogvtr.Value = 0
        HScrollBarvtr.Value = 0
        HScrollBarshuttlevtr.Value = 0
    End Sub

    Private Sub HScrollBarshuttlevtr_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HScrollBarshuttlevtr.ValueChanged
        On Error Resume Next
        Dim aa As Integer = HScrollBarshuttlevtr.Value
        If aa > 0 Then
            sp.WriteLine(Chr(33) & Chr(19) & Chr(aa) & Chr(33 + 19 + aa))
        Else
            sp.WriteLine(Chr(33) & Chr(35) & Chr(Math.Abs(aa)) & Chr(33 + 35 + Math.Abs(aa)))
        End If
    End Sub

    Private Sub HScrollBarvtr_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HScrollBarvtr.ValueChanged
        On Error Resume Next
        Dim aa As Integer = HScrollBarvtr.Value
        If aa > 0 Then
            sp.WriteLine(Chr(33) & Chr(18) & Chr(aa) & Chr(33 + 18 + aa))
        Else
            sp.WriteLine(Chr(33) & Chr(34) & Chr(Math.Abs(aa)) & Chr(33 + 34 + Math.Abs(aa)))
        End If
    End Sub

    Private Sub HScrollBarjogvtr_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HScrollBarjogvtr.ValueChanged
        On Error Resume Next
        Dim aa As Integer = HScrollBarjogvtr.Value
        If aa > 0 Then
            sp.WriteLine(Chr(33) & Chr(17) & Chr(aa) & Chr(33 + 17 + aa))
        Else
            sp.WriteLine(Chr(33) & Chr(33) & Chr(Math.Abs(aa)) & Chr(33 + 33 + Math.Abs(aa)))
        End If
    End Sub

    Private Sub cmdrecordvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrecordvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(2) & Chr(32 + 2))
    End Sub

    Private Sub cmdautoeditvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdautoeditvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(66) & Chr(32 + 66))
    End Sub

    Private Sub cmdpreviewvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpreviewvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(64) & Chr(32 + 64))
    End Sub

    Private Sub cmdReviewvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReviewvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(65) & Chr(32 + 65))
    End Sub

    Private Sub cmdplusoneframevtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplusoneframevtr.Click
        On Error Resume Next

        Dim aa As Array = Split(lbltimecode.Text, ":")
        Dim bb As String = Chr(36) & Chr(49) & Chr(System.Convert.ToInt32(aa(3), 16) + 1) & Chr(System.Convert.ToInt32(aa(2), 16)) & Chr(System.Convert.ToInt32(aa(1), 16)) & Chr(System.Convert.ToInt32(aa(0), 16)) &
         Chr(36 + 49 + System.Convert.ToInt32(aa(3), 16) + 1 + System.Convert.ToInt32(aa(2), 16) + System.Convert.ToInt32(aa(1), 16) + System.Convert.ToInt32(aa(0), 16))
        sp.WriteLine(bb)
    End Sub

    Private Sub cmdminusoneframevtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdminusoneframevtr.Click
        On Error Resume Next

        Dim aa As Array = Split(lbltimecode.Text, ":")

        Dim bb As String = Chr(36) & Chr(49) & Chr(System.Convert.ToInt32(aa(3) - 1, 16)) & Chr(System.Convert.ToInt32(aa(2), 16)) & Chr(System.Convert.ToInt32(aa(1), 16)) & Chr(System.Convert.ToInt32(aa(0), 16)) &
         Chr(36 + 49 + System.Convert.ToInt32(aa(3) - 1, 16) + System.Convert.ToInt32(aa(2), 16) + System.Convert.ToInt32(aa(1), 16) + System.Convert.ToInt32(aa(0), 16))
        sp.WriteLine(bb)
    End Sub

    Private Sub cmdassembleonvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdassembleonvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(66) & Chr(48) & Chr(32) & Chr(0) & Chr(66 + 48 + 32 + 0))
    End Sub

    Private Sub cmdassembleoffvtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdassembleoffvtr.Click
        On Error Resume Next
        sp.WriteLine(Chr(66) & Chr(48) & Chr(0) & Chr(0) & Chr(66 + 48 + 0 + 0))
    End Sub

    Private Sub HScrollBarjogvtr_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBarjogvtr.Scroll

    End Sub
    Private Sub HScrollBarshuttlevtr_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBarshuttlevtr.Scroll
    End Sub
    Private Sub HScrollBarvtr_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBarvtr.Scroll
    End Sub

    Dim aaa, bbb, ccc, ddd As Integer
    Private Sub cmd422send_Click(sender As Object, e As EventArgs) Handles cmd422send.Click
        On Error Resume Next
        aaa = CInt("&H" & Val(txt422send.Text))
        bbb = CInt(Val("&H" & txt422send2.Text))
        ddd = aaa + bbb
        If ddd > 255 Then ddd = ddd Mod 256
        sp.WriteLine(Chr(aaa) & Chr(bbb) & Chr(ddd))
        Threading.Thread.Sleep(100)

        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)
        getresponsefornative(byteArray)
    End Sub

    Private Sub cmd422send3command_Click(sender As Object, e As EventArgs) Handles cmd422send3command.Click
        On Error Resume Next

        aaa = CInt("&H" & Val(txt422send3.Text))
        bbb = CInt(Val("&H" & txt422send4.Text))
        ccc = CInt(Val("&H" & txt422send5.Text))
        ddd = aaa + bbb + ccc
        If ddd > 255 Then ddd = ddd Mod 256
        sp.WriteLine(Chr(aaa) & Chr(bbb) & Chr(ddd))
        Threading.Thread.Sleep(30)

        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        getresponsefornative(byteArray)
    End Sub
    Public Function getchecksum(ByVal hexdata() As Byte) As Byte
        Dim checkSum As Byte = 0
        Dim isfirst As Boolean = True
        For iii = 0 To hexdata.Length - 4
            If isfirst Then
                isfirst = False
                checkSum = hexdata(iii)
            End If
            checkSum = checkSum Xor hexdata(iii)
        Next
        Return checkSum
    End Function
    Dim udpClient As New UdpClient
    Dim iudp = 0

    Public receivingUdpClient As UdpClient
    Public ThreadReceive As System.Threading.Thread
    Public RemoteIpEndPoint As New System.Net.IPEndPoint(System.Net.IPAddress.Any, 0)
    Private Sub cmdudpsend_Click(sender As Object, e As EventArgs) Handles cmdudpsend.Click
        On Error Resume Next
        iudp = iudp + 1
        udpClient.Send(System.Text.Encoding.ASCII.GetBytes(txtudpdata.Text), System.Text.Encoding.ASCII.GetBytes(txtudpdata.Text).Length, cmbhost.Text, txtudpport.Text)
        txtudpdata.Text = "vimlesh" & iudp
    End Sub


    Private Sub cmdudpreceive_Click(sender As Object, e As EventArgs) Handles cmdudpreceive.Click
        On Error Resume Next

        Dim rport As Integer = txtudpportreceive.Text
        receivingUdpClient = New System.Net.Sockets.UdpClient(rport)
        NewInitialize()

        sender.enabled = False
        cmdstopreceive.Enabled = True

        txtudpportreceive.Enabled = False
    End Sub

    Public Sub NewInitialize()
        On Error Resume Next
        ThreadReceive = New System.Threading.Thread(AddressOf ReceiveMessages)
        ThreadReceive.Start()
    End Sub

    Public Sub ReceiveMessages()
        On Error Resume Next
        Dim receiveBytes As [Byte]() = receivingUdpClient.Receive(RemoteIpEndPoint)
        Dim strReturnData As String = System.Text.Encoding.ASCII.GetString(receiveBytes)
        txtudprereceive.Text = strReturnData

        NewInitialize()
    End Sub


    Private Sub cmdstopreceive_Click(sender As Object, e As EventArgs) Handles cmdstopreceive.Click
        On Error Resume Next
        ThreadReceive.Abort()
        receivingUdpClient.Close()

        sender.Enabled = False
        cmdudpreceive.Enabled = True
        txtudpportreceive.Enabled = True
    End Sub

    Private Sub cmdplaytcp_Click(sender As Object, e As EventArgs) Handles cmdplaytcp.Click
        Dim aaa, bbb As Integer
        aaa = 16
        bbb = 1

        Dim aa As String = Chr(2) & Chr(2) & Chr(aaa) & Chr(bbb) & Chr(256 - (aaa + bbb))
        Dim byData As [Byte]() = System.Text.Encoding.ASCII.GetBytes(aa + vbCrLf)
        m_socClient.Send(byData)
    End Sub

    Private Sub txt422send_TextChanged(sender As Object, e As EventArgs) Handles txt422send.TextChanged

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        'sp.WriteLine(Chr(CInt("&H20")) & Chr(1) & Chr(33))

        'sp.WriteLine(Chr(32) & Chr(1) & Chr(32 + 1))
        Dim aaa, bbb As Integer
        aaa = Val(txt422send.Text)
        bbb = Val(txt422send2.Text)
        sp.WriteLine(Chr(2) & Chr(2) & Chr(aaa) & Chr(bbb) & Chr(aaa + bbb))
        Threading.Thread.Sleep(30)

        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        txt422receive.Text = Val(Hex(byteArray(0))) & " " & Val(Hex(byteArray(1))) & " " & Val(Hex(byteArray(2))) & " " & Val(Hex(byteArray(3))) & " " & Val(Hex(byteArray(4))) & " " & Val(Hex(byteArray(5))) & " " & Val(Hex(byteArray(6))) & " " & Val(Hex(byteArray(7)))

    End Sub
    Private Sub cmdopenport_Click(sender As Object, e As EventArgs) Handles cmdopenport.Click
        On Error Resume Next
        Dim aaa, bbb, ccc As Integer
        aaa = 48
        bbb = 1
        ccc = Val(cmbportvdcp.Text)
        If ccc < 0 Then ccc = 128 + Math.Abs(ccc)
        ' MsgBox(ccc)
        Dim checksuminteger As Integer = aaa + bbb + ccc
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If

        sp.WriteLine(Chr(2) & Chr(4) & Chr(aaa) & Chr(bbb) & Chr(ccc) & Chr(0) & Chr(256 - checksuminteger))
        Threading.Thread.Sleep(30)

        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        getresponse(byteArray)
    End Sub

    Private Sub cmdselectport_Click(sender As Object, e As EventArgs) Handles cmdselectport.Click
        On Error Resume Next
        Dim aaa, bbb, ccc As Integer
        aaa = 32 'CInt("&HA0") '32
        bbb = 34
        ccc = Val(cmbportvdcp.Text)

        If ccc < 0 Then ccc = 128 + Math.Abs(ccc)

        Dim checksuminteger As Integer = aaa + bbb + ccc
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If

        sp.WriteLine(Chr(2) & Chr(3) & Chr(aaa) & Chr(bbb) & Chr(ccc) & Chr(256 - checksuminteger))
        Threading.Thread.Sleep(30)

        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        getresponse(byteArray)
    End Sub
    Private Sub cmdcloseport_Click(sender As Object, e As EventArgs) Handles cmdcloseport.Click
        On Error Resume Next
        Dim aaa, bbb, ccc As Integer
        aaa = 32 ' CInt("&HA0") '32
        bbb = 33
        ccc = Val(cmbportvdcp.Text)

        If ccc < 0 Then ccc = 128 + Math.Abs(ccc)

        Dim checksuminteger As Integer = aaa + bbb + ccc
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If


        sp.WriteLine(Chr(2) & Chr(3) & Chr(aaa) & Chr(bbb) & Chr(ccc) & Chr(256 - checksuminteger))
        Threading.Thread.Sleep(30)

        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)
        getresponse(byteArray)
    End Sub


    Private Sub cmdvdcpplay_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        'Dim aaa, bbb As Integer
        'aaa = 16
        'bbb = 1
        'sp.WriteLine(Chr(2) & Chr(2) & Chr(aaa) & Chr(bbb) & Chr(256 - (aaa + bbb)))
        playcommand()
    End Sub


    Sub getactiveid()
        On Error Resume Next

        clearbuffer()
        Dim aaa, bbb, ccc As Integer
        aaa = CInt("&HB0")  '176 '48
        bbb = CInt("&H07")
        'ccc = 1
        sp.WriteLine(Chr(2) & Chr(2) & Chr(aaa) & Chr(bbb) & Chr(256 - (aaa + bbb)))
        Threading.Thread.Sleep(30)

        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        txtActiveID.Text = ""
        For aa = 0 To byteArray.Count - 10
            txtActiveID.Text = txtActiveID.Text & Chr(byteArray(6 + aa))
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        On Error Resume Next
        Dim aaa, bbb, ccc, ddd As Integer
        aaa = CInt("&H" & t1.Text)
        bbb = CInt("&H" & t2.Text)
        'ccc = 1
        ddd = aaa + bbb
        If ddd > 255 Then ddd = ddd - 256
        sp.WriteLine(Chr(2) & Chr(2) & Chr(aaa) & Chr(bbb) & Chr(256 - ddd))
        Threading.Thread.Sleep(30)

        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        getresponse(byteArray)

    End Sub

    Sub getresponse(byteArray() As Byte)
        txt422receive.Text = ""
        For i = 0 To byteArray.Count - 1
            If i = 0 Then
                txt422receive.Text = Val(Hex(byteArray(i)))
            Else
                txt422receive.Text = txt422receive.Text & " " & Val(Hex(byteArray(i)))
            End If
        Next
    End Sub
    Sub getresponsefornative(byteArray() As Byte)
        txtresponseNative.Text = ""
        For i = 0 To byteArray.Count - 1
            txtresponseNative.Text = txtresponseNative.Text & " " & Val(Hex(byteArray(i)))
        Next
    End Sub
    Private Sub cmdcueclip_Click(sender As Object, e As EventArgs) Handles cmdcueclip.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(49) & Chr(81))  'cue clip
    End Sub



    Private Sub cmdrecordvdcp_Click(sender As Object, e As EventArgs) Handles cmdrecordvdcp.Click
        ' On Error Resume Next
        Dim aaa, bbb As Integer
        aaa = CInt("&H10") '16
        bbb = CInt("&H02") '2

        sp.WriteLine(Chr(2) & Chr(2) & Chr(aaa) & Chr(bbb) & Chr(256 - (aaa + bbb)))

    End Sub


    Sub portstatus(StatusNumber As Integer)
        'On Error Resume Next

        lblPortStatus.Text = "Port Status " & StatusNumber
        Dim aaa, bbb As Integer
        aaa = 48
        bbb = 5


        Dim checksuminteger As Integer = aaa + bbb + StatusNumber
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If

        sp.WriteLine(Chr(2) & Chr(3) & Chr(aaa) & Chr(bbb) & Chr(StatusNumber) & Chr(256 - checksuminteger))
        Threading.Thread.Sleep(30)
        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)
        getresponse(byteArray)
        getresponseerror(byteArray, StatusNumber)
    End Sub
    Sub getresponseerror(byteArray() As Byte, StatusNumber As Integer)

        If StatusNumber = 3 Then
            Dim aa As String = CBin(Val(Hex(byteArray(5))))
            Do While Len(aa) < 8
                aa = "0" & aa
            Loop
            For i = 0 To 7
                dgvstatuserrovdcp.Rows(i).Cells(1).Value = Mid(aa, 8 - i, 1)
            Next

            aa = CBin(Val(Hex(byteArray(6))))
            Do While Len(aa) < 8
                aa = "0" & aa
            Loop

            For i = 8 To 15
                dgvstatuserrovdcp.Rows(i).Cells(1).Value = Mid(aa, 16 - i, 1)
            Next
            aa = CBin(Val(Hex(byteArray(7))))
            Do While Len(aa) < 8
                aa = "0" & aa
            Loop
            For i = 16 To 23
                dgvstatuserrovdcp.Rows(i).Cells(1).Value = Mid(aa, 24 - i, 1)
            Next

        ElseIf StatusNumber = 2 Then
            Dim aa As String = CBin(Val(Hex(byteArray(5))))
            Do While Len(aa) < 8
                aa = "0" & aa
            Loop
            For i = 0 To 2
                dgvstatuserrovdcp.Rows(i).Cells(1).Value = Mid(aa, 8 - i, 1)
            Next

        Else

            Dim aa As String = CBin(Val(Hex(byteArray(5))))
            Do While Len(aa) < 8
                aa = "0" & aa
            Loop
            For i = 0 To 7
                dgvstatuserrovdcp.Rows(i).Cells(1).Value = Mid(aa, 8 - i, 1)
            Next
        End If

    End Sub
    Sub cueclip()
        Dim aaa, bbb As Integer
        aaa = CInt("&HA0") 'variable length id
        bbb = CInt("&H24")
        Dim strclipname As String = dgv1.CurrentRow.Cells(0).Value
        Dim charArray() As Char = strclipname
        Dim yyy As Integer = 0
        For i = 0 To (Len(strclipname) - 1)
            charArray(i) = Mid(strclipname, i + 1, 1)
            yyy = yyy + Decimal.op_Implicit(charArray(i))
        Next
        Dim checksuminteger As Integer = aaa + bbb + Len(strclipname) + yyy
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If
        sp.WriteLine(Chr(2) & Chr(3 + Len(strclipname)) & Chr(aaa) & Chr(bbb) & Chr(Len(strclipname)) & strclipname & Chr(256 - checksuminteger))
    End Sub

    Private Sub cmdplayclipname_Click(sender As Object, e As EventArgs) Handles cmdplayclipname.Click
        cueclip()
        Threading.Thread.Sleep(500)
        playcommand()
    End Sub
    Sub playcommand()
        On Error Resume Next
        sp.WriteLine(Chr(2) & Chr(2) & Chr(16) & Chr(1) & Chr(256 - 17))
        Threading.Thread.Sleep(500)
        getactiveid()
        Threading.Thread.Sleep(500)
        getSingleIdDurationfortracbar(txtActiveID.Text)
    End Sub
    Sub clearbuffer()
        On Error Resume Next

        sp.DiscardInBuffer()
        sp.DiscardOutBuffer()
        Threading.Thread.Sleep(100)
    End Sub

    Private Sub cmdGetIdDuration_Click(sender As Object, e As EventArgs) Handles cmdGetIdDuration.Click
        On Error Resume Next
        For aa = 0 To dgvclips.RowCount - 1
            clearbuffer()
            Dim aaa, bbb, ccc, ddd, eee, fff As Integer
            aaa = CInt("&HB0")
            bbb = CInt("&H14")

            Dim strclipname As String = dgvclips.Rows(aa).Cells(0).Value

            Dim charArray() As Char = strclipname
            Dim yyy As Integer = 0
            For i = 0 To (Len(strclipname) - 1)
                charArray(i) = Mid(strclipname, i + 1, 1)
                yyy = yyy + Decimal.op_Implicit(charArray(i))
            Next
            Dim checksuminteger As Integer = aaa + bbb + Len(strclipname) + yyy
            If checksuminteger > 256 Then
                checksuminteger = checksuminteger Mod 256
            End If
            sp.WriteLine(Chr(2) & Chr(3 + Len(strclipname)) & Chr(aaa) & Chr(bbb) & Chr(Len(strclipname)) & strclipname & Chr(256 - checksuminteger))
            Threading.Thread.Sleep(50)
            Dim bb As String = sp.ReadExisting
            Dim byteArray() As Byte
            byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

            dgvclips.Rows(aa).Cells(1).Value = Format((Val(Hex(byteArray(9)))), "00") & ":" & Format((Val(Hex(byteArray(8)))), "00") & ":" & Format((Val(Hex(byteArray(7)))), "00")
        Next

    End Sub
    Sub getSingleIdDurationfortracbar(idname As String)
        clearbuffer()
        Dim aaa, bbb As Integer
        aaa = CInt("&HB0")
        bbb = CInt("&H14")

        Dim strclipname As String = idname

        Dim charArray() As Char = strclipname
        Dim yyy As Integer = 0
        For i = 0 To (Len(strclipname) - 1)
            charArray(i) = Mid(strclipname, i + 1, 1)
            yyy = yyy + Decimal.op_Implicit(charArray(i))
        Next
        Dim checksuminteger As Integer = aaa + bbb + Len(strclipname) + yyy
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If
        sp.WriteLine(Chr(2) & Chr(3 + Len(strclipname)) & Chr(aaa) & Chr(bbb) & Chr(Len(strclipname)) & strclipname & Chr(256 - checksuminteger))
        Threading.Thread.Sleep(50)
        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        tbvdcp.Maximum = HMSFtoF(Format((Val(Hex(byteArray(9)))), "00") & ":" & Format((Val(Hex(byteArray(8)))), "00") & ":" & Format((Val(Hex(byteArray(7)))), "00"))
        lbltbmax.Text = tbvdcp.Maximum

    End Sub
    Sub getSingleIdDurationforplaylist(idname As String, aa As Integer)
        clearbuffer()
        Dim aaa, bbb As Integer
        aaa = CInt("&HB0")
        bbb = CInt("&H14")

        Dim strclipname As String = idname

        Dim charArray() As Char = strclipname
        Dim yyy As Integer = 0
        For i = 0 To (Len(strclipname) - 1)
            charArray(i) = Mid(strclipname, i + 1, 1)
            yyy = yyy + Decimal.op_Implicit(charArray(i))
        Next
        Dim checksuminteger As Integer = aaa + bbb + Len(strclipname) + yyy
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If
        sp.WriteLine(Chr(2) & Chr(3 + Len(strclipname)) & Chr(aaa) & Chr(bbb) & Chr(Len(strclipname)) & strclipname & Chr(256 - checksuminteger))
        Threading.Thread.Sleep(50)
        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        dgv1.Rows(aa).Cells(3).Value = Format((Val(Hex(byteArray(9)))), "00") & ":" & Format((Val(Hex(byteArray(8)))), "00") & ":" & Format((Val(Hex(byteArray(7)))), "00")

    End Sub
    Sub getRemaingDuration()
        On Error Resume Next
        clearbuffer()
        Dim aaa, bbb, ccc, ddd, eee, fff As Integer
        aaa = CInt("&H30")
        bbb = CInt("&H06")
        If rdoRemainduration.Checked Then
            ccc = 0
        ElseIf rdoPlayedDuration.Checked Then
            ccc = 2
        Else
            ccc = 1
        End If


        Dim checksuminteger As Integer = aaa + bbb + ccc
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If
        sp.WriteLine(Chr(2) & Chr(3) & Chr(aaa) & Chr(bbb) & Chr(ccc) & Chr(256 - checksuminteger))
        Threading.Thread.Sleep(50)
        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        lblRemainingDuration.Text = Format((Val(Hex(byteArray(8)))), "00") & ":" & Format((Val(Hex(byteArray(7)))), "00") & ":" & Format((Val(Hex(byteArray(6)))), "00") & ":" & Format((Val(Hex(byteArray(5)))), "00")
        lblCurrentFrame.Text = tbvdcp.Maximum - HMSFtoF(lblRemainingDuration.Text)
        tbvdcp.Value = lblCurrentFrame.Text

    End Sub
    Private Sub tmrRemainingDuration_Tick(sender As Object, e As EventArgs) Handles tmrRemainingDuration.Tick
        On Error Resume Next
        getRemaingDuration()
    End Sub

    Private Sub frmVDCPController_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSerialPortNames()
        initialisedatafordgvcuepointsvtr()
        initialisedgvporterror3()
        openport()

        With dgv1
            .Rows.Add(10)
            .Item(0, 0).Value = "kabhi_kabhi"
            .Item(0, 1).Value = "dolby"
            .Item(0, 2).Value = "abc"
            .Item(0, 3).Value = "test"
            .Item(0, 4).Value = "abcdefgh"
            .Item(0, 5).Value = "test"
            .Item(0, 6).Value = "abcdefghi"

            .Item(2, 0).Value = 1
            .Item(2, 1).Value = 0
            .Item(2, 2).Value = 1
            .Item(2, 3).Value = 0
            .Item(2, 4).Value = 1
            .Item(2, 5).Value = 1
            .Item(2, 6).Value = 0


            .Item(3, 0).Value = "00:04:20"
            .Item(3, 1).Value = "01:04:20"
            .Item(3, 2).Value = "00:08:40"
            .Item(3, 3).Value = "00:14:20"
            .Item(3, 4).Value = "00:24:35"
            .Item(3, 5).Value = "00:14:50"
            .Item(3, 6).Value = "00:13:17"
        End With

        With dgvclips
            .Rows.Add(6)
            .Item(0, 0).Value = "kabhi_kabhi"
            .Item(0, 1).Value = "2"
            .Item(1, 1).Value = "00:04:20"
            .Item(0, 2).Value = "abc"
            .Item(1, 2).Value = "02:01:20"
        End With
        tmrRemainingDuration.Enabled = True
    End Sub
    Sub initialisedgvporterror3()
        With dgvstatuserrovdcp
            .Rows.Clear()
            .Rows.Add(24)
            .Item(0, 0).Value = "SYSTEM ERROR"
            .Item(0, 1).Value = "ILLEGAL VALUE"
            .Item(0, 2).Value = "INVALID PORT"
            .Item(0, 3).Value = "WRONG PORT TYPE"
            .Item(0, 4).Value = "COMMAND QUEUE FULL"
            .Item(0, 5).Value = "DISK FULL"
            .Item(0, 6).Value = "CMD WHILE BUSY"
            .Item(0, 7).Value = "NOTSUPPORTED"
            .Item(0, 8).Value = "INVALID ID"
            .Item(0, 9).Value = "ID NOTFOUND"
            .Item(0, 10).Value = "ID ALREADY EXISTS"
            .Item(0, 11).Value = "ID STILL RECORDING"
            .Item(0, 12).Value = "ID STILL PLAYING"
            .Item(0, 13).Value = "ID NOT TRANS-FERRED"
            .Item(0, 14).Value = "ID TRANS-FERRED"
            .Item(0, 15).Value = "ID DELETE PROTECTED"
            .Item(0, 16).Value = "NOT IN CUE/INIT STATE"
            .Item(0, 17).Value = "CUE NOT DONE"
            .Item(0, 18).Value = "PORT NOT IDLE"
            .Item(0, 19).Value = "PORT PLAYING /ACTIVE"
            .Item(0, 20).Value = "PORT NOT ACTIVE"
            .Item(0, 21).Value = "CUE OR OPERATION FAILED"
            .Item(0, 22).Value = "NETWORK ERROR"
            .Item(0, 23).Value = "SYSTEM REBOOTED"
        End With
    End Sub
    Sub initialisedgvporterror2()
        With dgvstatuserrovdcp
            .Rows.Clear()
            .Rows.Add(24)
            .Item(0, 0).Value = "PORTDOWN"
            .Item(0, 1).Value = "IDs ADDED"
            .Item(0, 2).Value = "IDs DELETED"

        End With
    End Sub
    Sub initialisedgvporterror1()

        With dgvstatuserrovdcp
            .Rows.Clear()
            .Rows.Add(24)
            .Item(0, 0).Value = "IDLE"
            .Item(0, 1).Value = "CUE/INIT"
            .Item(0, 2).Value = "PLAY OR RECORD"
            .Item(0, 3).Value = "STILL"
            .Item(0, 4).Value = "JOG"
            .Item(0, 5).Value = "VARIABLE PLAY"
            .Item(0, 6).Value = "PORT BUSY"
            .Item(0, 7).Value = "CUE/INITDONE"

        End With
    End Sub





    Private Sub dgvclips_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvclips.CellContentDoubleClick

    End Sub

    Private Sub dgvclips_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvclips.CellContentClick

    End Sub
    Private MouseDownPos As Point
    Private MouseIsDown As Boolean = False
    Private Sub dgvclips_MouseMove(sender As Object, e As MouseEventArgs) Handles dgvclips.MouseMove
        On Error Resume Next

        If e.Button = MouseButtons.Left Then
            Dim dx = e.X - MouseDownPos.X
            Dim dy = e.Y - MouseDownPos.Y
            If Math.Abs(dx) >= SystemInformation.DoubleClickSize.Width OrElse
               Math.Abs(dy) >= SystemInformation.DoubleClickSize.Height Then
                If e.Button = Windows.Forms.MouseButtons.Right Then
                    cmsdgvclips.Show(MousePosition)
                Else
                    Dim cellX, cellY As Integer

                    Dim grvScreenLocation As Point = dgvclips.PointToScreen(dgvclips.Location)
                    Dim tempX As Integer = DataGridView.MousePosition.X - grvScreenLocation.X + dgvclips.Left
                    Dim tempY As Integer = DataGridView.MousePosition.Y - grvScreenLocation.Y + dgvclips.Top
                    Dim hit As DataGridView.HitTestInfo = dgvclips.HitTest(tempX, tempY)
                    cellX = hit.RowIndex
                    cellY = hit.ColumnIndex
                    dgvclips.CurrentCell = dgvclips.Rows(cellX).Cells(0)

                    Dim datatocopy As String = dgvclips.CurrentRow.Cells(0).Value & Chr(2) & dgvclips.CurrentRow.Cells(1).Value
                    If MouseIsDown = True And dgv1.Cursor <> System.Windows.Forms.Cursors.SizeWE Then
                        dgvclips.DoDragDrop(datatocopy, DragDropEffects.Copy)
                        MouseIsDown = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dgvclips_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvclips.MouseDown
        On Error Resume Next
        MouseDownPos = e.Location
        If dgvclips.Cursor = System.Windows.Forms.Cursors.SizeWE Then
            MouseIsDown = False
        Else
            MouseIsDown = True
        End If
    End Sub

    Private Sub lblRemainingDuration_Click(sender As Object, e As EventArgs)
    End Sub


    Sub nextclipofplaylist()
        On Error Resume Next
        If HMSFtoF(lblRemainingDuration.Text) < 60 Then
20:
            Dim i As Integer
            i = dgv1.CurrentRow.Index
            If i = (dgv1.Rows.Count - 1) Then
                dgv1.CurrentCell = dgv1.Rows(0).Cells(0)

            Else
                dgv1.CurrentCell = dgv1.Rows(i + 1).Cells(0)

            End If
            If dgv1.CurrentRow.Cells(0).Value = "" Then GoTo 20
            cueclip()
            Threading.Thread.Sleep(1000)
            playcommand()

            adjusttimeofplaylist()
        End If

    End Sub
    Private Function HMSFtoF(ByVal HMSF As String) As Integer
        On Error Resume Next
        Dim F As Integer
        F = (Val(Mid(HMSF, 1, 2)) * fps * 60 * 60 + Val(Mid(HMSF, 4, 2)) * fps * 60 + Val(Mid(HMSF, 7, 2)) * fps + Val(Mid(HMSF, 10, 2))).ToString
        Return F
    End Function

    Private Sub tmrNextClipofPlaylist_Tick(sender As Object, e As EventArgs) Handles tmrNextClipofPlaylist.Tick
        nextclipofplaylist()
    End Sub


    Private Sub cmdStartPlayList_Click(sender As Object, e As EventArgs) Handles cmdStartPlayList.Click
        If sender.text = "Start Playlist" Then
            cueclip()
            Threading.Thread.Sleep(1000)
            playcommand()
            tmrNextClipofPlaylist.Enabled = True
            sender.text = "Stop Playlist"

            adjusttimeofplaylist()
        Else
            tmrNextClipofPlaylist.Enabled = False
            sender.text = "Start Playlist"


            Dim aaa, bbb As Integer

            aaa = CInt("&H10")
            bbb = CInt("&H00")

            sp.WriteLine(Chr(2) & Chr(2) & Chr(aaa) & Chr(bbb) & Chr(256 - (aaa + bbb)))
        End If


    End Sub
    Sub adjusttimeofplaylist()
        On Error Resume Next
        Dim i As Integer
        Dim curRow As Integer = Me.dgv1.CurrentCell.RowIndex
        dgv1.CurrentRow.Cells(1).Value = Format(Now, "HH:mm:ss")

        For i = curRow To dgv1.RowCount - 1
            Dim aa As Date = dgv1.Rows(i).Cells(1).Value
            If dgv1.Rows(i).Cells(2).Value = 0 Then
                dgv1.Rows(i + 1).Cells(1).Value = Format(aa, "HH:mm:ss")
            Else
                Dim xxx As Integer
                xxx = (Mid(dgv1.Rows(i).Cells(3).Value, 1, 2)) * 3600 + (Mid(dgv1.Rows(i).Cells(3).Value, 4, 2)) * 60 + (Mid(dgv1.Rows(i).Cells(3).Value, 7, 2))
                dgv1.Rows(i + 1).Cells(1).Value = Format(aa.AddSeconds(xxx), "HH:mm:ss")
            End If
        Next

    End Sub
    Private Sub cmdidlistvdcp_Click(sender As Object, e As EventArgs) Handles cmdidlistvdcp.Click
        On Error Resume Next
        dgvclips.Rows.Clear()
        Dim aaa, bbb, ccc As Integer
        Dim iloopfornextcommand As Integer = 0
        'aaa = CInt("&H30") ' 8 byte 10 id
        aaa = CInt("&HB0") ' variable length id
        bbb = CInt("&H11")

20:     clearbuffer()
        sp.WriteLine(Chr(2) & Chr(2) & Chr(aaa) & Chr(bbb) & Chr(256 - (aaa + bbb)))
        Threading.Thread.Sleep(100)
        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        Dim str As String = ""
        For jj = 1 To CInt(Val((byteArray(8))))
            str = str & Chr(CInt(Val((byteArray(jj + 8)))))
        Next
        dgvclips.Rows.Add()
        dgvclips.Rows(iloopfornextcommand + 0).Cells(0).Value = str

        Dim ilentgh As Integer
        Dim currentposition As Integer = 8
        ilentgh = CInt(Val((byteArray(currentposition))))

        Dim iloop As Integer
        For aa = 1 To 39
            iloop = aa
            str = ""
            currentposition = currentposition + ilentgh + 1
            If (currentposition + 1) = byteArray.Count Then
                GoTo 30            ' Exit For
            End If

            ilentgh = CInt(Val((byteArray(currentposition))))

            For jj = 1 To ilentgh
                str = str + Chr(CInt(Val((byteArray(jj + currentposition)))))
            Next
            dgvclips.Rows.Add()
            dgvclips.Rows(aa + iloopfornextcommand).Cells(0).Value = str
        Next
30:
        If CInt(Val((byteArray(7)))) > 0 Then
            bbb = CInt("&H02")
            iloopfornextcommand = iloopfornextcommand + iloop
            GoTo 20
        End If
        lblclipcount.Text = "Clip Count= " & dgvclips.Rows.Count - 1
        dgvclips.Sort(dgvclips.Columns("ClipName"), System.ComponentModel.ListSortDirection.Ascending)

    End Sub



    Private Sub cmdAddNewIDs_Click(sender As Object, e As EventArgs) Handles cmdAddNewIDs.Click
        On Error Resume Next

        'dgvclips.Rows.Clear()
        Dim aaa, bbb, ccc As Integer
        Dim iloopfornextcommand As Integer = dgvclips.RowCount
        'aaa = CInt("&H30") ' 8 byte 10 id
        aaa = CInt("&HB0") ' variable length id
        bbb = CInt("&H18")

20:     clearbuffer()
        sp.WriteLine(Chr(2) & Chr(2) & Chr(aaa) & Chr(bbb) & Chr(256 - (aaa + bbb)))
        Threading.Thread.Sleep(100)
        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        If byteArray.Count = 9 Then Exit Sub

        Dim str As String = ""
        For jj = 1 To CInt(Val((byteArray(6))))
            str = str & Chr(CInt(Val((byteArray(jj + 6)))))
        Next
        dgvclips.Rows.Add()
        dgvclips.Rows(iloopfornextcommand + 0).Cells(0).Value = str

        Dim ilentgh As Integer
        Dim currentposition As Integer = 6
        ilentgh = CInt(Val((byteArray(currentposition))))

        Dim iloop As Integer
        For aa = 1 To 39
            iloop = aa
            str = ""
            currentposition = currentposition + ilentgh + 1
            If (currentposition + 3) = byteArray.Count Then
                GoTo 30            ' Exit For
            End If

            ilentgh = CInt(Val((byteArray(currentposition))))

            For jj = 1 To ilentgh
                str = str + Chr(CInt(Val((byteArray(jj + currentposition)))))
            Next
            dgvclips.Rows.Add()
            dgvclips.Rows(aa + iloopfornextcommand).Cells(0).Value = str
        Next
30:
        If CInt(Val((byteArray(5)))) > 0 Then
            bbb = CInt("&H02")
            iloopfornextcommand = iloopfornextcommand + iloop
            GoTo 20
        End If
        lblclipcount.Text = "Clip Count= " & dgvclips.Rows.Count - 1
        dgvclips.Sort(dgvclips.Columns("ClipName"), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub cmdRemoveDeletedIDs_Click(sender As Object, e As EventArgs) Handles cmdRemoveDeletedIDs.Click
        On Error Resume Next

        'dgvclips.Rows.Clear()
        Dim aaa, bbb, ccc As Integer
        Dim iloopfornextcommand As Integer = 0
        'aaa = CInt("&H30") ' 8 byte 10 id
        aaa = CInt("&HB0") ' variable length id
        bbb = CInt("&H19")

20:     clearbuffer()
        sp.WriteLine(Chr(2) & Chr(2) & Chr(aaa) & Chr(bbb) & Chr(256 - (aaa + bbb)))
        Threading.Thread.Sleep(100)
        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        If byteArray.Count = 9 Then Exit Sub

        Dim str As String = ""
        For jj = 1 To CInt(Val((byteArray(6))))
            str = str & Chr(CInt(Val((byteArray(jj + 6)))))
        Next
        For i = 0 To dgvclips.RowCount - 1
            If str = dgvclips.Rows(i).Cells(0).Value Then dgvclips.Rows.RemoveAt(i)
        Next

        Dim ilentgh As Integer
        Dim currentposition As Integer = 6
        ilentgh = CInt(Val((byteArray(currentposition))))

        Dim iloop As Integer
        For aa = 1 To 39
            iloop = aa
            str = ""
            currentposition = currentposition + ilentgh + 1
            If (currentposition + 3) = byteArray.Count Then
                GoTo 30            ' Exit For
            End If

            ilentgh = CInt(Val((byteArray(currentposition))))

            For jj = 1 To ilentgh
                str = str + Chr(CInt(Val((byteArray(jj + currentposition)))))
            Next
            For i = 0 To dgvclips.RowCount - 1
                If str = dgvclips.Rows(i).Cells(0).Value Then dgvclips.Rows.RemoveAt(i)
            Next
        Next
30:
        If CInt(Val((byteArray(5)))) > 0 Then
            bbb = CInt("&H02")
            'iloopfornextcommand = iloopfornextcommand + iloop
            GoTo 20
        End If
        lblclipcount.Text = "Clip Count= " & dgvclips.Rows.Count - 1
        dgvclips.Sort(dgvclips.Columns("ClipName"), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub cmdDeleteID_Click(sender As Object, e As EventArgs) Handles cmdDeleteID.Click
        Dim aaa, bbb As Integer
        'aaa = CInt("&H20") '8 byte  id 'play cue
        aaa = CInt("&HA0") 'variable length id
        bbb = CInt("&H26")

        Dim strclipname As String = dgvclips.CurrentRow.Cells(0).Value

        Dim charArray() As Char = strclipname
        Dim yyy As Integer = 0
        For i = 0 To (Len(strclipname) - 1)
            charArray(i) = Mid(strclipname, i + 1, 1)
            yyy = yyy + Decimal.op_Implicit(charArray(i))
        Next

        Dim checksuminteger As Integer = aaa + bbb + Len(strclipname) + yyy
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If

        sp.WriteLine(Chr(2) & Chr(3 + Len(strclipname)) & Chr(aaa) & Chr(bbb) & Chr(Len(strclipname)) & strclipname & Chr(256 - checksuminteger))
        Threading.Thread.Sleep(100)
        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        getresponse(byteArray)
    End Sub

    Private Sub cmdRenameId_Click(sender As Object, e As EventArgs) Handles cmdRenameId.Click
        Dim aaa, bbb As Integer
        'aaa = CInt("&H20") '8 byte  id 'play cue
        aaa = CInt("&HA0") 'variable length id
        bbb = CInt("&H1D")

        Dim strclipname As String = dgvclips.CurrentRow.Cells(0).Value

        Dim charArray() As Char = strclipname
        Dim yyy As Integer = 0
        For i = 0 To (Len(strclipname) - 1)
            charArray(i) = Mid(strclipname, i + 1, 1)
            yyy = yyy + Decimal.op_Implicit(charArray(i))
        Next

        Dim strclipname2 As String = txtNewName.Text
        Dim charArray2() As Char = strclipname2
        Dim yyy2 As Integer = 0
        For i = 0 To (Len(strclipname2) - 1)
            charArray2(i) = Mid(strclipname2, i + 1, 1)
            yyy2 = yyy2 + Decimal.op_Implicit(charArray2(i))
        Next

        Dim checksuminteger As Integer = aaa + bbb + Len(strclipname) + yyy + Len(strclipname2) + yyy2
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If

        sp.WriteLine(Chr(2) & Chr(4 + Len(strclipname) + Len(strclipname2)) & Chr(aaa) & Chr(bbb) & Chr(Len(strclipname)) & strclipname & Chr(Len(strclipname2)) & strclipname2 & Chr(256 - checksuminteger))
        Threading.Thread.Sleep(100)
        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        getresponse(byteArray)
    End Sub

    Private Sub cmdcuewithdata_Click(sender As Object, e As EventArgs) Handles cmdcuewithdata.Click
        'On Error Resume Next
        Dim aaa, bbb As Integer
        'aaa = CInt("&H20") '8 byte  id 'play cue
        aaa = CInt("&HA0") 'variable length id
        bbb = CInt("&H25")

        Dim strclipname As String = "kabhi_kabhi"

        Dim charArray() As Char = strclipname
        Dim yyy As Integer = 0
        For i = 0 To (Len(strclipname) - 1)
            charArray(i) = Mid(strclipname, i + 1, 1)
            yyy = yyy + Decimal.op_Implicit(charArray(i))
        Next

        Dim strclipname2 As String = Chr(CInt("&H00")) & Chr(CInt("&H20")) & Chr(CInt("&H00")) & Chr(CInt("&H00"))
        Dim charArray2() As Char = strclipname2
        Dim yyy2 As Integer = 0
        For i = 0 To (Len(strclipname2) - 1)
            charArray2(i) = Mid(strclipname2, i + 1, 1)
            yyy2 = yyy2 + Decimal.op_Implicit(charArray2(i))
        Next


        Dim strclipname3 As String = Chr(CInt("&H00")) & Chr(CInt("&H10")) & Chr(CInt("&H00")) & Chr(CInt("&H00"))
        Dim charArray3() As Char = strclipname3
        Dim yyy3 As Integer = 0
        For i = 0 To (Len(strclipname3) - 1)
            charArray3(i) = Mid(strclipname3, i + 1, 1)
            yyy3 = yyy3 + Decimal.op_Implicit(charArray3(i))
        Next



        Dim checksuminteger As Integer = aaa + bbb + Len(strclipname) + yyy + yyy2 + yyy3
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If

        sp.WriteLine(Chr(2) & Chr(3 + Len(strclipname) + 4 + 4) & Chr(aaa) & Chr(bbb) & Chr(Len(strclipname)) & strclipname & strclipname2 & strclipname3 & Chr(256 - checksuminteger))

        Threading.Thread.Sleep(50)
        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        getresponse(byteArray)

    End Sub





    Private Sub cmdloadcliptoeditvdcp_Click(sender As Object, e As EventArgs) Handles cmdloadcliptoeditvdcp.Click

        sp.WriteLine(Chr(2) & Chr(2) & Chr(16) & Chr(0) & Chr(256 - (16 + 0)))
        Threading.Thread.Sleep(30)

        Dim aaa, bbb As Integer

        aaa = CInt("&HA0") 'variable length id
        bbb = CInt("&H24")

        Dim strclipname As String = dgvclips.CurrentRow.Cells(0).Value

        Dim charArray() As Char = strclipname
        Dim yyy As Integer = 0
        For i = 0 To (Len(strclipname) - 1)
            charArray(i) = Mid(strclipname, i + 1, 1)
            yyy = yyy + Decimal.op_Implicit(charArray(i))
        Next

        Dim checksuminteger As Integer = aaa + bbb + Len(strclipname) + yyy
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If

        sp.WriteLine(Chr(2) & Chr(3 + Len(strclipname)) & Chr(aaa) & Chr(bbb) & Chr(Len(strclipname)) & strclipname & Chr(256 - checksuminteger))


        '--------------------
        On Error Resume Next
        Threading.Thread.Sleep("100")
        Dim bb As String = sp.ReadExisting
        clearbuffer()

        aaa = CInt("&HB0")
        bbb = CInt("&H14")

        sp.WriteLine(Chr(2) & Chr(3 + Len(strclipname)) & Chr(aaa) & Chr(bbb) & Chr(Len(strclipname)) & strclipname & Chr(256 - checksuminteger))
        Threading.Thread.Sleep(100)
        bb = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        Dim durationofclip As String = Format((Val(Hex(byteArray(9)))), "00") & ":" & Format((Val(Hex(byteArray(8)))), "00") & ":" & Format((Val(Hex(byteArray(7)))), "00") & ":" & Format((Val(Hex(byteArray(6)))), "00")

        tbvdcp.Maximum = HMSFtoF(durationofclip)
        lbltbmax.Text = tbvdcp.Maximum


    End Sub
    Dim oldvalue As Integer = 0
    Dim newvalue As Integer = 0
    Private Sub tbvdcp_Scroll(sender As Object, e As EventArgs) Handles tbvdcp.Scroll
        On Error Resume Next
        Dim aaa, bbb As Integer
        'jog command
        aaa = CInt("&H10")
        bbb = CInt("&H07")
        newvalue = tbvdcp.Value

        Dim change As Integer = newvalue - oldvalue

        ' If change < 0 Then change = 256 + change

        'Dim strclipname As String = Chr(change)
        oldvalue = newvalue



        Dim aa As String = Hex(change)
        Do While Len(aa) < 8
            aa = "0" & aa
        Loop

        Dim strclipname As String = Chr(CInt("&H" & Mid(aa, 1, 2))) & Chr(CInt("&H" & Mid(aa, 3, 2))) & Chr(CInt("&H" & Mid(aa, 5, 2))) & Chr(CInt("&H" & Mid(aa, 7, 2)))




        Dim charArray() As Char = strclipname
        Dim yyy As Integer = 0
        For i = 0 To (Len(strclipname) - 1)
            charArray(i) = Mid(strclipname, i + 1, 1)
            yyy = yyy + Decimal.op_Implicit(charArray(i))
        Next

        Dim checksuminteger As Integer = aaa + bbb + yyy
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If

        sp.WriteLine(Chr(2) & Chr(6) & Chr(aaa) & Chr(bbb) & strclipname & Chr(256 - checksuminteger))
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub HScrollBarjogvdcp_MouseLeave(sender As Object, e As EventArgs) Handles HScrollBarjogvdcp.MouseLeave
        HScrollBarjogvdcp.Value = 0
    End Sub

    Private Sub HScrollBarjogvdcp_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBarjogvdcp.Scroll

    End Sub

    Private Sub HScrollBarjogvdcp_ValueChanged(sender As Object, e As EventArgs) Handles HScrollBarjogvdcp.ValueChanged
        On Error Resume Next
        Dim aaa, bbb As Integer
        'aaa = CInt("&H20") '8 byte  id 'play cue
        aaa = CInt("&H10") 'variable length id
        bbb = CInt("&H07")

        Dim framecount As Integer = HScrollBarjogvdcp.Value
        If framecount < 0 Then framecount = 256 + framecount

        Dim yyy As Integer = framecount

        Dim checksuminteger As Integer = aaa + bbb + yyy
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If

        sp.WriteLine(Chr(2) & Chr(3) & Chr(aaa) & Chr(bbb) & Chr(Math.Abs(yyy)) & Chr(256 - checksuminteger))

        Threading.Thread.Sleep(50)
        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        getresponse(byteArray)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        sp.WriteLine(Chr(32) & Chr(49) & "dolby" & Chr(81))  'cue clip



        Threading.Thread.Sleep(50)
        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)
        getresponsefornative(byteArray)
    End Sub

    Private Sub cmdnewcopyvdcp_Click(sender As Object, e As EventArgs) Handles cmdnewcopyvdcp.Click
        Dim aaa, bbb As Integer

        aaa = CInt("&HA0")
        bbb = CInt("&H1F")

        Dim strclipname As String = dgvclips.CurrentRow.Cells(0).Value
        Dim charArray() As Char = strclipname
        Dim yyy As Integer = 0
        For i = 0 To (Len(strclipname) - 1)
            charArray(i) = Mid(strclipname, i + 1, 1)
            yyy = yyy + Decimal.op_Implicit(charArray(i))
        Next

        Dim strclipname2 As String = txtSubclipvdcp.Text
        Dim charArray2() As Char = strclipname2
        Dim yyy2 As Integer = 0
        For i = 0 To (Len(strclipname2) - 1)
            charArray2(i) = Mid(strclipname2, i + 1, 1)
            yyy2 = yyy2 + Decimal.op_Implicit(charArray2(i))
        Next


        Dim strclipname3 As String = Chr(CInt("&H00")) & Chr(CInt("&H10")) & Chr(CInt("&H00")) & Chr(CInt("&H00"))
        Dim charArray3() As Char = strclipname3
        Dim yyy3 As Integer = 0
        For i = 0 To (Len(strclipname3) - 1)
            charArray3(i) = Mid(strclipname3, i + 1, 1)
            yyy3 = yyy3 + Decimal.op_Implicit(charArray3(i))
        Next


        Dim strclipname4 As String = Chr(CInt("&H00")) & Chr(CInt("&H08")) & Chr(CInt("&H00")) & Chr(CInt("&H00"))
        Dim charArray4() As Char = strclipname4
        Dim yyy4 As Integer = 0
        For i = 0 To (Len(strclipname4) - 1)
            charArray4(i) = Mid(strclipname4, i + 1, 1)
            yyy4 = yyy4 + Decimal.op_Implicit(charArray4(i))
        Next



        Dim checksuminteger As Integer = aaa + bbb + Len(strclipname) + yyy + Len(strclipname2) + yyy2 + yyy3 + yyy4
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If

        sp.WriteLine(Chr(2) & Chr(2 + 2 + Len(strclipname) + Len(strclipname2) + 4 + 4) & Chr(aaa) & Chr(bbb) & Chr(Len(strclipname)) & strclipname & Chr(Len(strclipname2)) & strclipname2 & strclipname3 & strclipname4 & Chr(256 - checksuminteger))
        Threading.Thread.Sleep(100)
        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        getresponse(byteArray)
    End Sub

    Private Sub cmdrecordinitialisevdcp_Click(sender As Object, e As EventArgs) Handles cmdrecordinitialisevdcp.Click
        Dim aaa, bbb As Integer

        aaa = CInt("&HA0") 'variable length id
        bbb = CInt("&H23")

        Dim strclipname As String = txtrecordfilenamevdcp.Text
        Dim charArray() As Char = strclipname
        Dim yyy As Integer = 0
        For i = 0 To (Len(strclipname) - 1)
            charArray(i) = Mid(strclipname, i + 1, 1)
            yyy = yyy + Decimal.op_Implicit(charArray(i))
        Next


        Dim strclipname2 As String = Chr(CInt("&H00")) & Chr(CInt("&H00")) & Chr(CInt("&H00")) & Chr(CInt("&H02"))
        Dim charArray2() As Char = strclipname2
        Dim yyy2 As Integer = 0
        For i = 0 To (Len(strclipname2) - 1)
            charArray2(i) = Mid(strclipname2, i + 1, 1)
            yyy2 = yyy2 + Decimal.op_Implicit(charArray2(i))
        Next

        Dim checksuminteger As Integer = aaa + bbb + Len(strclipname) + yyy + yyy2
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If

        sp.WriteLine(Chr(2) & Chr(3 + Len(strclipname) + Len(strclipname2)) & Chr(aaa) & Chr(bbb) & Chr(Len(strclipname)) & strclipname & strclipname2 & Chr(256 - checksuminteger))

        Threading.Thread.Sleep(100)
        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        getresponse(byteArray)
    End Sub


    Private Sub cmdcloseportsvtr_Click(sender As Object, e As EventArgs) Handles cmdcloseportsvtr.Click
        On Error Resume Next
        closeport()
    End Sub





    Private Function CBin(Number As Decimal) As String
        On Error Resume Next
        CBin = ""
        Dim Temp As Object
        Temp = 1 'Can't fouble nothing
        Do Until Temp > Number 'sets starting point for Len
            Temp = Temp * 2
        Loop
        Do Until Temp < 1
            If Number >= Temp Then
                CBin = CBin + "1"
                Number = Number - Temp
            Else
                CBin = CBin + "0"
            End If
            Temp = Temp / 2
        Loop 'Loop until string is complete
        CBin = CStr(Val(CBin))
    End Function

    Private Function FToHMSF(ByVal frame As Integer) As String
        On Error Resume Next
        Dim ts As TimeSpan
        Dim totHrs As Integer
        Dim H, M, S, F, HMSF As String
        '
        ts = TimeSpan.FromSeconds(frame / fps)

        '
        totHrs = Math.Truncate(ts.TotalHours) 'strip away decimal points
        H = Format(totHrs, "0#") & ":"
        M = Format(ts.Minutes, "0#") & ":"
        S = Format(ts.Seconds, "0#") & ":"
        F = Format((ts.Milliseconds) * fps / 1000, "0#")

        HMSF = H & M & S & F
        '
        Return HMSF

    End Function

    Private Sub gbVDCP_Enter(sender As Object, e As EventArgs) Handles gbVDCP.Enter

    End Sub

    Private Sub dgvstatuserrovdcp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvstatuserrovdcp.CellContentClick

    End Sub
    Private Sub cmdEEModeOFF_Click(sender As Object, e As EventArgs) Handles cmdEEModeOFF.Click
        On Error Resume Next
        Dim aaa, bbb, ccc As Integer

        aaa = CInt("&H10")
        bbb = CInt("&H0A")
        ccc = 0
        sp.WriteLine(Chr(2) & Chr(3) & Chr(aaa) & Chr(bbb) & Chr(ccc) & Chr(256 - (aaa + bbb + ccc)))

        Threading.Thread.Sleep(30)

        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        getresponse(byteArray)
    End Sub
    Private Sub cmdEEModeON_Click(sender As Object, e As EventArgs) Handles cmdEEModeON.Click
        On Error Resume Next
        Dim aaa, bbb, ccc As Integer

        aaa = CInt("&H10")
        bbb = CInt("&H0A")
        ccc = 1
        sp.WriteLine(Chr(2) & Chr(3) & Chr(aaa) & Chr(bbb) & Chr(ccc) & Chr(256 - (aaa + bbb + ccc)))

        Threading.Thread.Sleep(30)

        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        getresponse(byteArray)
    End Sub

    Private Sub cmdEEModeAuto_Click(sender As Object, e As EventArgs) Handles cmdEEModeAuto.Click
        On Error Resume Next
        Dim aaa, bbb, ccc As Integer

        aaa = CInt("&H10")
        bbb = CInt("&H0A")
        ccc = 2
        sp.WriteLine(Chr(2) & Chr(3) & Chr(aaa) & Chr(bbb) & Chr(ccc) & Chr(256 - (aaa + bbb + ccc)))

        Threading.Thread.Sleep(30)

        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        getresponse(byteArray)
    End Sub

    Sub changespeedvdcp()
        On Error Resume Next
        Dim aaa, bbb As Integer

        aaa = CInt("&H10")
        bbb = CInt("&H08")

        Dim aa As Decimal = Format(nSpeedvdcp.Value, "000.00")
        Dim aa1 As String = Hex(Val(Split(aa, ".")(0)))
        If Len(aa1) > 2 Then aa1 = Mid(aa1, 7, 2)
        Dim aa2 As String = Hex(Val(Split(aa, ".")(1)))

        Dim strclipname As String = Chr(CInt("&H" & aa1)) & Chr(CInt("&H" & aa2)) & Chr(CInt("&H00"))
        'Dim strclipname As String = Chr(CInt("&H00")) & Chr(CInt("&H40")) & Chr(CInt("&H00"))

        Dim charArray() As Char = strclipname

        Dim yyy As Integer = 0
        For i = 0 To (Len(strclipname) - 1)
            charArray(i) = Mid(strclipname, i + 1, 1)
            yyy = yyy + Decimal.op_Implicit(charArray(i))
        Next


        Dim checksuminteger As Integer = aaa + bbb + yyy
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If

        sp.WriteLine(Chr(2) & Chr(5) & Chr(aaa) & Chr(bbb) & strclipname & Chr(256 - checksuminteger))

        'Threading.Thread.Sleep(100)
        'Dim bb As String = sp.ReadExisting
        'Dim byteArray() As Byte
        'byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        'getresponse(byteArray)
    End Sub
    Private Sub cmdVariableSpeed_Click(sender As Object, e As EventArgs) Handles cmdVariableSpeed.Click
        changespeedvdcp()
    End Sub

    Private Sub nSpeedvdcp_ValueChanged(sender As Object, e As EventArgs) Handles nSpeedvdcp.ValueChanged
        changespeedvdcp()
    End Sub

    Private Sub cmdportstatus3vdcp_Click(sender As Object, e As EventArgs) Handles cmdportstatus3vdcp.Click
        initialisedgvporterror3()
        portstatus(3)
    End Sub

    Private Sub cmdportstatus2vdcp_Click(sender As Object, e As EventArgs) Handles cmdportstatus2vdcp.Click
        initialisedgvporterror2()
        portstatus(2)
    End Sub

    Private Sub cmdportstatus1vdcp_Click(sender As Object, e As EventArgs) Handles cmdportstatus1vdcp.Click
        initialisedgvporterror1()
        portstatus(1)
    End Sub


    Private Sub dgvclips_DoubleClick(sender As Object, e As EventArgs) Handles dgvclips.DoubleClick
        On Error Resume Next

        Dim cellX, cellY As Integer
        Dim grvScreenLocation As Point = dgvclips.PointToScreen(dgvclips.Location)
        Dim tempX As Integer = DataGridView.MousePosition.X - grvScreenLocation.X + dgvclips.Left
        Dim tempY As Integer = DataGridView.MousePosition.Y - grvScreenLocation.Y + dgvclips.Top
        Dim hit As DataGridView.HitTestInfo = dgvclips.HitTest(tempX, tempY)
        cellX = hit.RowIndex
        cellY = hit.ColumnIndex
        If hit.Type <> DataGridViewHitTestType.ColumnHeader Then

        End If
        dgvclips.CurrentCell = dgvclips.Rows(cellX).Cells(0)
        If dgv1.CurrentRow.Index <> 0 And dgv1.Rows(0).Cells(0).Value = vbNull Then
            clipinsert()
            dgv1.CurrentCell = dgv1.Rows(dgv1.CurrentRow.Index + 1).Cells(0)
        End If
        dgv1.CurrentRow.Cells(0).Value = dgvclips.CurrentRow.Cells(0).Value
        dgv1.CurrentRow.Cells(2).Value = 1



        If dgvclips.CurrentRow.Cells(1).Value = "" Then
            getSingleIdDurationforplaylist(dgvclips.CurrentRow.Cells(0).Value, dgv1.CurrentRow.Index)
        Else
            dgv1.CurrentRow.Cells(3).Value = dgvclips.CurrentRow.Cells(1).Value
        End If
        adjusttimeofplaylistfornewclip(cellX)
    End Sub



    Private Sub cmdmovecommandvdcp_Click(sender As Object, e As EventArgs) Handles cmdmovecommandvdcp.Click
        'On Error Resume Next
        Dim aaa, bbb As Integer
        'jog command
        aaa = CInt("&H10")
        bbb = CInt("&H07")


        Dim aa As String = Hex(TextBox1.Text)
        Do While Len(aa) < 8
            aa = "0" & aa
        Loop

        Dim strclipname As String = Chr(CInt("&H" & Mid(aa, 1, 2))) & Chr(CInt("&H" & Mid(aa, 3, 2))) & Chr(CInt("&H" & Mid(aa, 5, 2))) & Chr(CInt("&H" & Mid(aa, 7, 2)))
        'Dim strclipname As String = Chr(CInt("&Hff")) & Chr(CInt("&Hff")) & Chr(CInt("&Hff")) & Chr(CInt("&H9c"))

        Dim charArray() As Char = strclipname

        Dim yyy As Integer = 0
        For i = 0 To (Len(strclipname) - 1)
            charArray(i) = Mid(strclipname, i + 1, 1)
            yyy = yyy + Decimal.op_Implicit(charArray(i))
        Next

        'If yyy > 256 Then
        '    yyy = yyy Mod 256
        'End If


        Dim checksuminteger As Integer = aaa + bbb + yyy
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If

        sp.WriteLine(Chr(2) & Chr(6) & Chr(aaa) & Chr(bbb) & strclipname & Chr(256 - checksuminteger))

        Threading.Thread.Sleep(100)
        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        getresponse(byteArray)
    End Sub

    Sub clipcopy()
        On Error Resume Next
        tempRow = Me.dgv1.CurrentRow
    End Sub

    Sub insertcopied()
        On Error Resume Next
        Dim curRow As Integer = Me.dgv1.CurrentCell.RowIndex
        dgv1.Rows.Insert(dgv1.CurrentRow.Index)
        dgv1.CurrentCell = dgv1.Rows(curRow).Cells(0)
        For cc = 0 To dgv1.ColumnCount - 1
            Me.dgv1.Item(cc, curRow).Value = tempRow.Cells(cc).Value
        Next
        adjusttimeofplaylistfornewclip(dgv1.CurrentRow.Index)
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        newdgv()
    End Sub
    Sub newdgv()
        On Error Resume Next
        dgv1.Rows.Clear()
        dgv1.Rows.Add(20)
        Me.lblplaylistname.Text = "playlist= " & "new playlist"

    End Sub

    Private Sub cmdmoveup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmoveup.Click
        On Error Resume Next
        clipmoveup()
    End Sub
    Sub clipmoveup()
        On Error Resume Next
        If Me.dgv1.CurrentCell.RowIndex <> 0 Then

            Dim curRow As Integer = Me.dgv1.CurrentCell.RowIndex

            Dim aaa2 As String = dgv1.Rows(curRow - 1).Cells(2).Value

            Dim myRow As DataGridViewRow = Me.dgv1.CurrentRow
            Me.dgv1.Rows.Remove(myRow)
            Me.dgv1.Rows.Insert(curRow - 1, myRow)
            dgv1.CurrentCell = dgv1.Rows(curRow - 1).Cells(0)

            'Dim aaa As Integer = dgv1.CurrentRow.Index
            dgv1.Rows(curRow - 1).Cells(2).Value = aaa2

            Dim xxx As Integer

            xxx = (Mid(dgv1.Rows(curRow - 1).Cells(7).Value, 1, 2)) * 3600 + (Mid(dgv1.Rows(curRow - 1).Cells(7).Value, 4, 2)) * 60 + (Mid(dgv1.Rows(curRow - 1).Cells(7).Value, 7, 2))
            Dim aa As Date = dgv1.Rows(curRow - 1).Cells(2).Value
            dgv1.Rows(curRow).Cells(2).Value = Format(aa.AddSeconds(xxx), "HH:mm:ss")

        End If
    End Sub
    Private Sub cmdmovedown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmovedown.Click
        clipmovedown()
    End Sub
    Sub clipmovedown()
        On Error Resume Next
        If Me.dgv1.CurrentCell.RowIndex <> dgv1.Rows.Count - 2 Then

            Dim curRow As Integer = Me.dgv1.CurrentCell.RowIndex

            Dim aaa2 As String = dgv1.Rows(curRow).Cells(2).Value

            Dim myRow As DataGridViewRow = Me.dgv1.CurrentRow
            Me.dgv1.Rows.Remove(myRow)
            Me.dgv1.Rows.Insert(curRow + 1, myRow)
            dgv1.CurrentCell = dgv1.Rows(curRow + 1).Cells(0)

            dgv1.Rows(curRow).Cells(2).Value = aaa2

            Dim xxx As Integer

            xxx = (Mid(dgv1.Rows(curRow).Cells(7).Value, 1, 2)) * 3600 + (Mid(dgv1.Rows(curRow).Cells(7).Value, 4, 2)) * 60 + (Mid(dgv1.Rows(curRow).Cells(7).Value, 7, 2))
            Dim aa As Date = dgv1.Rows(curRow).Cells(2).Value
            dgv1.Rows(curRow + 1).Cells(2).Value = Format(aa.AddSeconds(xxx), "HH:mm:ss")

        End If
    End Sub
    Private Sub cmdinsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdinsert.Click
        On Error Resume Next
        clipinsert()
    End Sub
    Sub clipinsert()
        On Error Resume Next
        If dgv1.CurrentRow.Index < currrow Then
            currrow = currrow + 1
        End If
        dgv1.Rows.Insert(dgv1.CurrentRow.Index + 1)

        dgv1.Rows(dgv1.CurrentRow.Index + 1).Cells(2).Value = 1


    End Sub
    Private Sub cmddeleteclip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddeleteclip.Click
        On Error Resume Next
        deleteclip()
    End Sub
    Sub deleteclip()
        On Error Resume Next
        If dgv1.CurrentRow.DefaultCellStyle.BackColor <> Color.Green Then
            If dgv1.CurrentRow.Index < currrow Then
                currrow = currrow - 1
            End If
            dgv1.Rows.RemoveAt(dgv1.CurrentRow.Index)
            adjusttimeofplaylistfornewclip(dgv1.CurrentRow.Index)
        Else
            MsgBox("Online clip cann't be deleted.")
        End If
    End Sub
    Sub adjusttimeofplaylistfornewclip(ByVal hitrow As Integer)
        On Error Resume Next
        Dim i As Integer
        For i = hitrow - 1 To dgv1.RowCount - 1
            Dim aa As Date = dgv1.Rows(i).Cells(1).Value
            If dgv1.Rows(i).Cells(2).Value = 0 Then
                dgv1.Rows(i + 1).Cells(1).Value = Format(aa, "HH:mm:ss")
            Else
                Dim xxx As Integer
                xxx = (Mid(dgv1.Rows(i).Cells(3).Value, 1, 2)) * 3600 + (Mid(dgv1.Rows(i).Cells(3).Value, 4, 2)) * 60 + (Mid(dgv1.Rows(i).Cells(3).Value, 7, 2))
                dgv1.Rows(i + 1).Cells(1).Value = Format(aa.AddSeconds(xxx), "HH:mm:ss")
            End If
        Next
    End Sub
    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        On Error Resume Next
        newdgv()
    End Sub
    Private Sub SaveAsToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripButton.Click
        savefile()
    End Sub
    Sub savefile()
        On Error Resume Next
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "c:\casparcg\mydata\playlist\"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                If dgv1.Rows.Count = 0 Then
                    sw.Write("")
                Else
                    'Loop through and add list to the file.
                    Dim f As Integer = 0
                    Do Until f = dgv1.Rows.Count


                        sw.WriteLine(dgv1.Rows(f).Cells(0).Value & Chr(2) & dgv1.Rows(f).Cells(1).Value & Chr(2) & dgv1.Rows(f).Cells(2).Value & Chr(2) & dgv1.Rows(f).Cells(3).Value)
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End Using
            Me.lblplaylistname.Text = "playlist=  " & osd2.FileName
            SaveToolStripButton.Enabled = True
        End If
    End Sub
    Sub saveplaylist(filename As String)
        On Error Resume Next
        Using sw As StreamWriter = New StreamWriter(Mid(filename, 11))
            If dgv1.Rows.Count = 0 Then
                sw.Write("")
            Else
                'Loop through and add list to the file.
                Dim f As Integer = 0
                Do Until f = dgv1.Rows.Count
                    sw.WriteLine(dgv1.Rows(f).Cells(0).Value & Chr(2) & dgv1.Rows(f).Cells(1).Value & Chr(2) & dgv1.Rows(f).Cells(2).Value & Chr(2) & dgv1.Rows(f).Cells(3).Value)
                    f = f + 1
                Loop
            End If
            sw.Close()
        End Using
    End Sub
    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        On Error Resume Next
        openfile()
    End Sub
    Sub openfile()
        ' On Error Resume Next
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = "c:\casparcg\mydata\playlist\"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            SaveToolStripButton.Enabled = True
            Using sr As StreamReader = New StreamReader(ofd2.FileName)
                'clear list
                dgv1.Rows.Clear()
                'Loop through and add list to the file.
                Dim g As Integer = 0
                Dim li As String
                Do Until sr.EndOfStream = True
                    li = sr.ReadLine()
                    dgv1.Rows.Add()
                    Dim xyz As Array = Split(li, Chr(2))
                    dgv1.Rows(g).Cells(0).Value = xyz(0)
                    dgv1.Rows(g).Cells(1).Value = xyz(1)
                    dgv1.Rows(g).Cells(2).Value = xyz(2)
                    dgv1.Rows(g).Cells(3).Value = xyz(3)
                    g = g + 1
                Loop
                sr.Close()
            End Using
            Me.lblplaylistname.Text = "playlist=  " & ofd2.FileName
        End If
    End Sub
    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        On Error Resume Next
        saveplaylist(lblplaylistname.Text)

    End Sub

    Private Sub dgv1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgv1.DataError

    End Sub

    Dim clipduration As String
    Private Sub dgv1_DragDrop(sender As Object, e As DragEventArgs) Handles dgv1.DragDrop

        On Error Resume Next
        Dim clientPoint As Point = dgv1.PointToClient(New Point(e.X, e.Y))
        Dim datatocopy As Array = Split(e.Data.GetData("System.String"), Chr(2))
        dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells(0).Value = datatocopy(0)
        dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells(2).Value = 1
        If datatocopy(1) <> "" Then
            dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells(3).Value = datatocopy(1)
        Else
            Dim xx As String
            getSingleIdDurationforplaylist(datatocopy(0), dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex)
            ' dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells(3).Value = clipduration
            'MsgBox(clipduration)
        End If



        Dim hitrow As Integer = dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex
        adjusttimeofplaylistfornewclip(hitrow)
    End Sub


    Private Sub dgv1_DragEnter(sender As Object, e As DragEventArgs) Handles dgv1.DragEnter
        On Error Resume Next
        e.Effect = DragDropEffects.Copy
    End Sub
    Private Sub cmdselectall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdselectall.Click
        On Error Resume Next
        Dim iplalistselectall As Integer
        For iplalistselectall = 0 To dgv1.RowCount - 1
            dgv1.Rows(iplalistselectall).Cells(2).Value = 1
        Next
    End Sub
    Private Sub cmddeselectall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddeselectall.Click
        On Error Resume Next
        Dim iplalistdeselectall As Integer
        For iplalistdeselectall = 0 To dgv1.RowCount - 1
            dgv1.Rows(iplalistdeselectall).Cells(2).Value = 0
        Next
    End Sub


    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub





    Private Sub cmdvdcpstop_Click(sender As Object, e As EventArgs) Handles cmdvdcpstop.Click

        On Error Resume Next
        Dim aaa, bbb As Integer

        aaa = CInt("&H10")
        bbb = CInt("&H00")

        sp.WriteLine(Chr(2) & Chr(2) & Chr(aaa) & Chr(bbb) & Chr(256 - (aaa + bbb)))

    End Sub

    Private Sub cmdforwardoneframe_Click(sender As Object, e As EventArgs) Handles cmdforwardoneframe.Click
        On Error Resume Next
        Dim aaa, bbb As Integer
        aaa = 16
        bbb = 5
        sp.WriteLine(Chr(2) & Chr(2) & Chr(aaa) & Chr(bbb) & Chr(256 - (aaa + bbb)))
    End Sub

    Private Sub cmdbackoneframe_Click(sender As Object, e As EventArgs) Handles cmdbackoneframe.Click
        On Error Resume Next
        Dim aaa, bbb As Integer
        'jog command
        aaa = CInt("&H10")
        bbb = CInt("&H07")


        Dim aa As String = Hex(-1)
        Do While Len(aa) < 8
            aa = "0" & aa
        Loop

        Dim strclipname As String = Chr(CInt("&H" & Mid(aa, 1, 2))) & Chr(CInt("&H" & Mid(aa, 3, 2))) & Chr(CInt("&H" & Mid(aa, 5, 2))) & Chr(CInt("&H" & Mid(aa, 7, 2)))
        Dim charArray() As Char = strclipname
        Dim yyy As Integer = 0
        For i = 0 To (Len(strclipname) - 1)
            charArray(i) = Mid(strclipname, i + 1, 1)
            yyy = yyy + Decimal.op_Implicit(charArray(i))
        Next

        Dim checksuminteger As Integer = aaa + bbb + yyy
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If
        sp.WriteLine(Chr(2) & Chr(6) & Chr(aaa) & Chr(bbb) & strclipname & Chr(256 - checksuminteger))


    End Sub

    Private Sub cmdvdcpresume_Click(sender As Object, e As EventArgs) Handles cmdvdcpresume.Click
        On Error Resume Next
        Dim aaa, bbb As Integer
        aaa = 16
        bbb = 6
        sp.WriteLine(Chr(2) & Chr(2) & Chr(aaa) & Chr(bbb) & Chr(256 - (aaa + bbb)))
    End Sub

    Private Sub cmdvdcppause_Click(sender As Object, e As EventArgs) Handles cmdvdcppause.Click
        On Error Resume Next
        Dim aaa, bbb As Integer
        aaa = 16
        bbb = 4
        sp.WriteLine(Chr(2) & Chr(2) & Chr(aaa) & Chr(bbb) & Chr(256 - (aaa + bbb)))
    End Sub

    Private Sub Cmdhide_Click(sender As Object, e As EventArgs) 
        Me.Hide()
    End Sub

    Private Sub cmdcueclipvdcp_Click(sender As Object, e As EventArgs) Handles cmdcueclipvdcp.Click
        On Error Resume Next
        Dim aaa, bbb As Integer

        aaa = CInt("&H10")
        bbb = CInt("&H00")

        sp.WriteLine(Chr(2) & Chr(2) & Chr(aaa) & Chr(bbb) & Chr(256 - (aaa + bbb)))

        cueclip()
        Threading.Thread.Sleep(250)

        getactiveid()
        Threading.Thread.Sleep(250)

        getSingleIdDurationfortracbar(dgv1.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub cmdCopyFileTovdcp_Click(sender As Object, e As EventArgs) Handles cmdCopyFileTovdcp.Click
        Dim aaa, bbb As Integer

        aaa = CInt("&HA0")
        bbb = CInt("&H50")

        Dim strclipname As String = dgvclips.CurrentRow.Cells(0).Value
        Dim charArray() As Char = strclipname
        Dim yyy As Integer = 0
        For i = 0 To (Len(strclipname) - 1)
            charArray(i) = Mid(strclipname, i + 1, 1)
            yyy = yyy + Decimal.op_Implicit(charArray(i))
        Next

        Dim strclipname2 As String = cmbSourceDriveNames.Text
        Dim charArray2() As Char = strclipname2
        Dim yyy2 As Integer = 0
        For i = 0 To (Len(strclipname2) - 1)
            charArray2(i) = Mid(strclipname2, i + 1, 1)
            yyy2 = yyy2 + Decimal.op_Implicit(charArray2(i))
        Next


        Dim strclipname3 As String = cmbDestinationDriveNames.Text
        Dim charArray3() As Char = strclipname3
        Dim yyy3 As Integer = 0
        For i = 0 To (Len(strclipname3) - 1)
            charArray3(i) = Mid(strclipname3, i + 1, 1)
            yyy3 = yyy3 + Decimal.op_Implicit(charArray3(i))
        Next

        Dim checksuminteger As Integer = aaa + bbb + yyy + yyy2 + yyy3

        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If


        sp.WriteLine(Chr(2) & Chr(1 + 1 + Len(strclipname) + Len(strclipname2) + Len(strclipname3)) & Chr(aaa) & Chr(bbb) & strclipname & strclipname2 & strclipname3 & Chr(256 - checksuminteger))

        Threading.Thread.Sleep(300)
        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        getresponse(byteArray)
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim aaa, bbb As Integer

        aaa = CInt("&H20")
        bbb = CInt("&H1F")

        Dim strclipname As String = "12345678"
        Dim charArray() As Char = strclipname
        Dim yyy As Integer = 0
        For i = 0 To (Len(strclipname) - 1)
            charArray(i) = Mid(strclipname, i + 1, 1)
            yyy = yyy + Decimal.op_Implicit(charArray(i))
        Next

        Dim strclipname2 As String = txtSubclipvdcp.Text
        Dim charArray2() As Char = strclipname2
        Dim yyy2 As Integer = 0
        For i = 0 To (Len(strclipname2) - 1)
            charArray2(i) = Mid(strclipname2, i + 1, 1)
            yyy2 = yyy2 + Decimal.op_Implicit(charArray2(i))
        Next


        Dim strclipname3 As String = Chr(CInt("&H00")) & Chr(CInt("&H10")) & Chr(CInt("&H00")) & Chr(CInt("&H00"))
        Dim charArray3() As Char = strclipname3
        Dim yyy3 As Integer = 0
        For i = 0 To (Len(strclipname3) - 1)
            charArray3(i) = Mid(strclipname3, i + 1, 1)
            yyy3 = yyy3 + Decimal.op_Implicit(charArray3(i))
        Next


        Dim strclipname4 As String = Chr(CInt("&H00")) & Chr(CInt("&H08")) & Chr(CInt("&H00")) & Chr(CInt("&H00"))
        Dim charArray4() As Char = strclipname4
        Dim yyy4 As Integer = 0
        For i = 0 To (Len(strclipname4) - 1)
            charArray4(i) = Mid(strclipname4, i + 1, 1)
            yyy4 = yyy4 + Decimal.op_Implicit(charArray4(i))
        Next



        Dim checksuminteger As Integer = aaa + bbb + yyy + yyy2 + yyy3 + yyy4
        If checksuminteger > 256 Then
            checksuminteger = checksuminteger Mod 256
        End If

        sp.WriteLine(Chr(2) & Chr(26) & Chr(aaa) & Chr(bbb) & strclipname & strclipname2 & strclipname3 & strclipname4 & Chr(256 - checksuminteger))
        Threading.Thread.Sleep(100)
        Dim bb As String = sp.ReadExisting
        Dim byteArray() As Byte
        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(bb)

        getresponse(byteArray)
    End Sub
End Class
