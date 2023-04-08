
Imports Bespoke.Common.Osc
Imports System.Net
Public Class ucOSC

    Dim ttype As Integer = 1 'udp
    Dim WithEvents sOscServer As OscServer 'for osc
    Dim hh1, hh2, kk1 As Integer
    Sub oscstartandregister()
        On Error Resume Next
        If sOscServer Is Nothing Then
            OscPacket.LittleEndianByteOrder = False
            sOscServer = New OscServer(ttype, IPAddress.Any, cmboscport.Text)
            sOscServer.Start()

            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/output/port/500/type")
            If ServerVersion = 2.1 Then
                sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/output/port/601/type")
            Else
                sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/output/port/600/type")
            End If

            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/profiler/time")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/format")

            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/profiler/time")

            If ServerVersion > 2.1 Then
                sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/foreground/file/time")
            Else
                sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/file/time")
            End If


            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/file/frame")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/file/fps")


            If ServerVersion > 2.1 Then

                sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/foreground/file/path")
            Else

                sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/file/path")
            End If


            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/time")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/frame")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/type")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/background/type")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/profiler/time")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/transition/frame")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/transition/type")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/file/video/width")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/file/video/height")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/file/video/codec")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/file/audio/sample-rate")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/file/audio/channels")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/file/audio/format")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/file/audio/codec")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/loop")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/host/path")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/host/width")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/host/height")


            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/host/fps")


            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/host/buffer")

            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/mixer/audio/" & "nb_channels")

            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/mixer/audio/1/dBFS")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/mixer/audio/2/dBFS")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/mixer/audio/3/dBFS")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/mixer/audio/4/dBFS")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/mixer/audio/5/dBFS")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/mixer/audio/6/dBFS")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/mixer/audio/7/dBFS")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/mixer/audio/8/dBFS")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/mixer/audio/9/dBFS")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/mixer/audio/10/dBFS")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/mixer/audio/11/dBFS")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/mixer/audio/12/dBFS")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/mixer/audio/13/dBFS")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/mixer/audio/14/dBFS")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/mixer/audio/15/dBFS")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/mixer/audio/16/dBFS")



            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/output/port/200/frame")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/output/port/200/path")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/output/port/200/fps")

            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/paused")


            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/output/port/150/file/frame")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/output/port/150/file/path")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/output/port/150/file/fps")

            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/file/vframe")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/file/speed")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/output/file/frame")

            'for server 2.2 start
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/foreground/file/name")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/mixer/audio/volume")

            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/foreground/file/streams/0/fps")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/buffer")
            sOscServer.RegisterMethod("/channel/" & g_int_ChannelNumber & "/stage/layer/" & g_int_PlaylistLayer & "/foreground/file/stime")
            'for server 2.2  end 

            sOscServer.FilterRegisteredMethods = False 'false so that if we change by hand the method name in client it will react to new method.

            dgvosc.RowTemplate.Height = 18
            dgvosc.Rows.Clear()
            dgvosc.Rows.Add(sOscServer.RegisteredMethods.Count)

            Dim iregisteredmethods As Integer
            For iregisteredmethods = 0 To sOscServer.RegisteredMethods.Count - 1
                dgvosc.Rows(iregisteredmethods).Cells(0).Value = sOscServer.RegisteredMethods(iregisteredmethods)
            Next
        End If

        If dgvosc.Rows(7).Cells(1).Value = "" Then
            dgvosc.Rows(7).Cells(1).Value = fps
        End If

    End Sub

    Private Sub invokeControls1(ByVal e As OscMessageReceivedEventArgs)
        On Error Resume Next
        If Me.InvokeRequired Then
            Me.Invoke(New invokeControlsDelegate1(AddressOf Me.invokeControls1), e)
        Else
            Dim jregisteredmethods As Integer
            For jregisteredmethods = 0 To sOscServer.RegisteredMethods.Count - 1
                If dgvosc.Rows(jregisteredmethods).Cells(0).Value = e.Message.Address Then
                    dgvosc.Rows(jregisteredmethods).Cells(1).Value = e.Message.Data(0)
                    dgvosc.Rows(jregisteredmethods).Cells(2).Value = e.Message.Data(1)
                    dgvosc.Rows(jregisteredmethods).Cells(3).Value = e.Message.Data(2)
                    dgvosc.Rows(jregisteredmethods).Cells(4).Value = e.Message.Data(3)
                    dgvosc.Rows(jregisteredmethods).Cells(5).Value = e.Message.Data(4)
                    dgvosc.Rows(jregisteredmethods).Cells(6).Value = e.Message.Data(5)
                    dgvosc.Rows(jregisteredmethods).Cells(7).Value = e.Message.Data(6)
                    dgvosc.Rows(jregisteredmethods).Cells(8).Value = e.Message.Data(7)
                    dgvosc.Rows(jregisteredmethods).Cells(9).Value = e.Message.Data(8)
                    dgvosc.Rows(jregisteredmethods).Cells(10).Value = e.Message.Data(9)
                    dgvosc.Rows(jregisteredmethods).Cells(11).Value = e.Message.Data(10)
                    dgvosc.Rows(jregisteredmethods).Cells(12).Value = e.Message.Data(11)
                    dgvosc.Rows(jregisteredmethods).Cells(13).Value = e.Message.Data(12)
                    dgvosc.Rows(jregisteredmethods).Cells(14).Value = e.Message.Data(13)
                    dgvosc.Rows(jregisteredmethods).Cells(15).Value = e.Message.Data(14)
                    dgvosc.Rows(jregisteredmethods).Cells(16).Value = e.Message.Data(15)
                    dgvosc.Rows(jregisteredmethods).Cells(17).Value = e.Message.Data(16)
                    Exit For
                End If
            Next
            If ServerVersion > 2.1 Then
                If dgvosc.Rows(5).Cells(0).Value = e.Message.Address Then
                    hh1 = e.Message.Data(0)
                    hh2 = e.Message.Data(1)
                End If
                If dgvosc.Rows(56).Cells(0).Value = e.Message.Address Then
                    playingfilename = e.Message.Data(0)
                End If
                If dgvosc.Rows(57).Cells(0).Value = e.Message.Address Then
                    audiovalue1 = ValuetodBFS(e.Message.Data(0))
                    audiovalue2 = ValuetodBFS(e.Message.Data(1))
                End If
                If dgvosc.Rows(58).Cells(0).Value = e.Message.Address Then
                    kk1 = e.Message.Data(0) 'fps
                    fps = e.Message.Data(0)
                End If
                framesPlayed = Int(hh1 * kk1)
                framesTotal = Int(hh2 * kk1)

                dgvosc.Rows(6).Cells(1).Value = framesPlayed
                dgvosc.Rows(6).Cells(2).Value = framesTotal
            Else
                If dgvosc.Rows(30).Cells(0).Value = e.Message.Address Then
                    audiovalue1 = e.Message.Data(0)
                End If
                If dgvosc.Rows(31).Cells(0).Value = e.Message.Address Then
                    audiovalue2 = e.Message.Data(0)
                End If
                If dgvosc.Rows(6).Cells(0).Value = e.Message.Address Then
                    framesPlayed = (e.Message.Data(0))
                    If e.Message.Data(1) = 343597384 Then
                        framesTotal = 90000 '(e.Message.Data(1))
                    Else
                        framesTotal = e.Message.Data(1)
                    End If

                End If
                    If dgvosc.Rows(7).Cells(0).Value = e.Message.Address Then
                    fps = e.Message.Data(0)
                End If

                If dgvosc.Rows(8).Cells(0).Value = e.Message.Address Then
                    playingfilename = e.Message.Data(0)
                End If
            End If
        End If


    End Sub
    Private Sub invokeControls2(ByVal e As OscBundleReceivedEventArgs)
        On Error Resume Next
        If Me.InvokeRequired Then
            Me.Invoke(New invokeControlsDelegate2(AddressOf Me.invokeControls2), e)
        Else
            Dim jregisteredmethods As Integer
            For jregisteredmethods = 0 To sOscServer.RegisteredMethods.Count - 1
                If dgvosc.Rows(jregisteredmethods).Cells(0).Value = e.Bundle.Address Then
                    dgvosc.Rows(jregisteredmethods).Cells(1).Value = e.Bundle.Data(0)
                    dgvosc.Rows(jregisteredmethods).Cells(2).Value = e.Bundle.Data(1)
                    If jregisteredmethods = 6 And e.Bundle.Data(0) <> "" Then
                        dgvosc.Rows(6).Cells(1).Value = Int((dgvosc.Rows(5).Cells(1).Value) * (dgvosc.Rows(7).Cells(1).Value))
                        dgvosc.Rows(6).Cells(2).Value = Int((dgvosc.Rows(5).Cells(2).Value) * (dgvosc.Rows(7).Cells(1).Value))
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub invokeControls3(ByVal e As OscPacketReceivedEventArgs)
        On Error Resume Next
        If Me.InvokeRequired Then
            Me.Invoke(New invokeControlsDelegate3(AddressOf Me.invokeControls3), e)
        Else
            Dim jregisteredmethods As Integer
            For jregisteredmethods = 0 To sOscServer.RegisteredMethods.Count - 1
                If dgvosc.Rows(jregisteredmethods).Cells(0).Value = e.Packet.Address Then
                    dgvosc.Rows(jregisteredmethods).Cells(1).Value = e.Packet.Data(0)
                    dgvosc.Rows(jregisteredmethods).Cells(2).Value = e.Packet.Data(1)
                    If jregisteredmethods = 6 And e.Packet.Data(0) <> "" Then
                        dgvosc.Rows(6).Cells(1).Value = Int((dgvosc.Rows(5).Cells(1).Value) * (dgvosc.Rows(7).Cells(1).Value))
                        dgvosc.Rows(6).Cells(2).Value = Int((dgvosc.Rows(5).Cells(2).Value) * (dgvosc.Rows(7).Cells(1).Value))
                    End If
                End If
            Next
        End If

    End Sub
    Private Delegate Sub invokeControlsDelegate1(ByVal e As OscMessageReceivedEventArgs)
    Private Delegate Sub invokeControlsDelegate2(ByVal e As OscBundleReceivedEventArgs)
    Private Delegate Sub invokeControlsDelegate3(ByVal e As OscPacketReceivedEventArgs)

    Private Sub sOscServer_MessageReceived(ByVal sender As Object, ByVal e As OscMessageReceivedEventArgs) Handles sOscServer.MessageReceived
        On Error Resume Next
        Me.invokeControls1(e)
    End Sub

    Private Sub sOscServer_BundleReceived(ByVal sender As Object, ByVal e As OscBundleReceivedEventArgs) Handles sOscServer.BundleReceived
        On Error Resume Next
        'Me.invokeControls2(e)
    End Sub
    Private Sub sOscServer_PacketReceived(ByVal sender As Object, ByVal e As OscPacketReceivedEventArgs) Handles sOscServer.PacketReceived
        On Error Resume Next
        'Me.invokeControls3(e)
    End Sub
    Sub stoposcserver()
        On Error Resume Next
        If sOscServer IsNot Nothing Then
            sOscServer.Stop()
            sOscServer.ClearMethods()
            sOscServer = Nothing
        End If

    End Sub

    Private Sub cmdoscconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdoscconnect.Click
        oscstartandregister()
    End Sub
    Private Sub cmdoscstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdoscstop.Click, MyBase.DockStateChanged
        On Error Resume Next
        stoposcserver()
    End Sub

    Private Sub ucOSC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
