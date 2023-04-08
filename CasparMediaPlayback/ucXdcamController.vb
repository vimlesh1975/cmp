Imports System.Xml
Imports System.IO
Imports caspar_media_playback.XdcamWebReference
Public Class ucXdcamController
    Dim WithEvents aa As New MediaStationService
    Dim WithEvents aa1 As New XdcamWebReference.FileOperationEvent
    Dim str_SessionId As String
    Dim dd() As ClipInfo
    Dim int_TotalFrame As Integer
    Dim thumbnailRowindex As Integer = 0
    Dim tempRow As DataGridViewRow

    Dim appdate As String
    Dim changeoverframe As Integer = 15

    Private Sub cmdgetclipnames_Click(sender As Object, e As EventArgs) Handles cmdgetclipnames.Click
        On Error Resume Next
        ClipSerach()
    End Sub
    Sub ClipSerach()
        Try
            Dim bb As New XdcamWebReference.GetClipListRequest
            bb.DriveId = cmbClipDrive.Text
            aa.GetClipListAsync(bb)

        Catch ex As Exception
            MsgBox(ex.InnerException)
        End Try

    End Sub
    Private Sub aa_GetClipListCompleted(sender As Object, e As GetClipListCompletedEventArgs) Handles aa.GetClipListCompleted
        On Error Resume Next
        dgvclips.Rows.Clear()
        Dim iclips As Integer = 0
        For Each info As ClipInfo In e.Result

            If UCase(info.ClipName) Like "*" & UCase(txtSearch.Text) & "*" Then
                dgvclips.Rows.Add()
                dgvclips.Rows(iclips).Cells(0).Value = info.ClipName
                dgvclips.Rows(iclips).Cells(1).Value = FToHMSF(info.TotalFrames)
                dgvclips.Rows(iclips).Cells(2).Value = bytetostring(info.UMID)
                dgvclips.Rows(iclips).Cells(3).Value = timecodetohmsf(info.StartTimeCode)
                iclips = iclips + 1
            End If
        Next

        dgvclips.Sort(dgvclips.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        lblClips.Text = dgvclips.RowCount - 1 'e.Result.Count
        If chkThumbnail.Checked Then
            thumbnailRowindex = 0
            getthumbanail(cmbClipDrive.Text, dgvclips.Rows(0).Cells(0).Value)
        End If
    End Sub

    Private Sub cmdcopy_Click(sender As Object, e As EventArgs) Handles cmdcopy.Click
        On Error Resume Next
        Dim bb As New XdcamWebReference.CopyFileRequest
        bb.DstDriveId = cmbdestinationDriveNames.Text
        bb.DstFileName = txtSubClipName.Text & ".MXF"
        bb.Frames = txtmarkoutsoap.Text - txtmarkinsoap.Text
        bb.FramesSpecified = True
        ' bb.Mode = CopyMode.Transcode
        bb.ModeSpecified = True
        bb.SrcDriveId = cmbClipDrive.Text
        bb.SrcFileName = lblActiveID.Text
        bb.StartFrame = txtmarkinsoap.Text
        bb.StartFrameSpecified = True
        aa.CopyFile(bb)
    End Sub

    Sub stopclip()
        On Error Resume Next
        Dim bb As New ClosePlayerRequest
        bb.PlayerId = "Player_1"
        aa.ClosePlayer(bb)

        Dim bb2 As New StopPlayerTimeLineRequest
        bb2.PlayerId = "Player_1"
        aa.StopPlayerTimeLine(bb2)

        Dim bb1 As New DeletePlayerTimeLineAllEventRequest
        bb1.PlayerId = "Player_1"
        aa.DeletePlayerTimeLineAllEvent(bb1)

    End Sub

    Sub playcommand()
        On Error Resume Next
        Dim bb As New XdcamWebReference.PlayRequest
        bb.Mode = PlayMode.Play
        bb.ModeSpecified = True
        bb.PlayerId = "Player_1"
        aa.Play(bb)
    End Sub

    Sub pauseclip()
        On Error Resume Next
        Dim bb As New XdcamWebReference.PauseRequest
        bb.PlayerId = "Player_1"
        aa.Pause(bb)
    End Sub
    Public int_LeftFrame As Integer

    Sub getthumbanail(driveid As String, clipname As String)
        On Error Resume Next
        Dim bb As New XdcamWebReference.GetClipThumbnailRequest
        bb.DriveId = driveid
        bb.ClipName = clipname
        aa.GetClipThumbnailAsync(bb)
    End Sub
    Private Sub aa_GetClipThumbnailCompleted(sender As Object, e As GetClipThumbnailCompletedEventArgs) Handles aa.GetClipThumbnailCompleted
        On Error Resume Next
        dgvclips.Rows(thumbnailRowindex).Cells(4).Value = byteArrayToImage(e.Result.Thumbnail.Data)

        thumbnailRowindex = thumbnailRowindex + 1
        If thumbnailRowindex < dgvclips.RowCount Then
            getthumbanail(cmbClipDrive.Text, dgvclips.Rows(thumbnailRowindex).Cells(0).Value)
        End If
    End Sub
    Sub clipproperty(clipname As String)
        On Error Resume Next
        Dim bb As New GetClipPropertiesRequest
        bb.DriveId = cmbClipDrive.Text
        bb.ClipName = lblActiveID.Text
        aa.GetClipPropertiesAsync(bb)

    End Sub

    Private Sub aa_GetClipPropertiesCompleted(sender As Object, e As GetClipPropertiesCompletedEventArgs) Handles aa.GetClipPropertiesCompleted
        On Error Resume Next
        If chkPlaySMIasXMF.Checked = True And Split(dgv1.CurrentRow.Cells(0).Value, ".")(1) = "SMI" Then
            int_TotalFrame = HMSFtoF(Mid(clipEnd(0), 10)) - HMSFtoF(Mid(clipBegin(0), 10))
        Else

            int_TotalFrame = e.Result.Property.TotalFrames
        End If
        lblUMID.Text = bytetostring(e.Result.Property.UMID)

        lblMoreInfo2.Text = "AudioChannels= " & e.Result.Property.AudioChannels & vbNewLine &
       "AudioCodec= " & e.Result.Property.AudioCodec.ToString() & vbNewLine &
       "CreateDateTime= " & e.Result.Property.CreateDateTime & vbNewLine &
       "Flag= " & e.Result.Property.Flag & vbNewLine & vbNewLine &
        "KlvPackets= " & e.Result.Property.KlvPackets & vbNewLine &
        "LastModifiedDateTime= " & e.Result.Property.LastModifiedDateTime & vbNewLine &
        "NrtModifiedDateTime= " & e.Result.Property.NrtModifiedDateTime & vbNewLine &
        "Protected= " & e.Result.Property.Protected & vbNewLine &
        "ProxyExists= " & e.Result.Property.ProxyExists & vbNewLine &
        "ReadyToPlay= " & e.Result.Property.ReadyToPlay & vbNewLine &
        "ShotMark= " & e.Result.Property.ShotMark & vbNewLine &
        "StartTimeCode= " & e.Result.Property.StartTimeCode.Time & ":" & e.Result.Property.StartTimeCode.Frame & vbNewLine &
        "ThumbnailFrame= " & e.Result.Property.ThumbnailFrame & vbNewLine &
        "TimeCodeRate= " & e.Result.Property.TimeCodeRate & vbNewLine &
        "VideoCodecInfo= " & e.Result.Property.VideoCodecInfo.ToString & vbNewLine &
        "VideoFrameRate= " & e.Result.Property.VideoFrameRate.ToString


    End Sub
    Private Sub cmdOpenRecorder_Click(sender As Object, e As EventArgs) Handles cmdOpenRecorder.Click
        Try

            Dim bb As New OpenRecorderRequest
            bb.ClipName = txtRecordFileName.Text & ".MXF" ' .MXF extension is neccessary in Capital letters
            bb.DriveId = cmbRecordDrive.Text
            bb.Frames = HMSFtoF(txtRecordingDuration.Text)
            bb.FramesSpecified = True
            bb.RecorderId = "Recorder_1"
            bb.RecorderMode = OpenRecorderMode.Record
            aa.OpenRecorder(bb)

            tmrRecoderStatus.Enabled = True
            UcVTRController1.sp.WriteLine(Chr(CInt("&H20")) & Chr(1) & Chr(33))

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdCloseRecord_Click(sender As Object, e As EventArgs) Handles cmdCloseRecord.Click
        Try

            Dim bb As New CloseRecorderRequest
            bb.RecorderId = "Recorder_1"
            aa.CloseRecorder(bb)

            tmrRecoderStatus.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tmrGetTC_Tick(sender As Object, e As EventArgs) Handles tmrGetTC.Tick
        On Error Resume Next
        gettc()
        For i As Integer = 0 To dgv1.Rows.Count - 1
            If i = currrow Then
                dgv1.Rows(currrow).DefaultCellStyle.BackColor = Color.Green
            Else
                If dgv1.Rows(i).DefaultCellStyle.BackColor <> Color.Red Then dgv1.Rows(i).DefaultCellStyle.BackColor = Color.White
            End If
        Next i
    End Sub
    Sub gettc()
        On Error Resume Next
        Dim bb As New XdcamWebReference.GetPlayerStatusRequest
        bb.PlayerId = "Player_1"
        aa.GetPlayerStatusAsync(bb)

        tbsoap.Maximum = int_TotalFrame
        lbltbmax.Text = int_TotalFrame
        lbloriginalduration.Text = FToHMSF(int_TotalFrame)
        lbltrimmedduration.Text = FToHMSF(txtmarkoutsoap.Text - txtmarkinsoap.Text)

    End Sub
    Private Sub aa_GetPlayerStatusCompleted(sender As Object, e As GetPlayerStatusCompletedEventArgs) Handles aa.GetPlayerStatusCompleted

        On Error Resume Next
        If Split(lblActiveID.Text, ".")(1) = "SMI" Then

            int_LeftFrame = int_TotalFrame - timecodetoframe(e.Result.Status.Port(0).Video.LTC)
            lblRemainingDuration.Text = FToHMSF(int_LeftFrame)
            lblActiveID.Text = e.Result.Status.Port(0).ClipName
            lbltimecode.Text = Format(e.Result.Status.Port(0).Video.LTC.Time.Hour, "00") & ":" & Format(e.Result.Status.Port(0).Video.LTC.Time.Minute, "00") & ":" & Format(e.Result.Status.Port(0).Video.LTC.Time.Second, "00") & ":" & Format(e.Result.Status.Port(0).Video.LTC.Frame, "00")
            lblPlayedDuration.Text = lbltimecode.Text
            lblCurrentFrame.Text = timecodetoframe(e.Result.Status.Port(0).Video.LTC)
        Else
            If chkPlaySMIasXMF.Checked = True And Split(dgv1.Rows(currrow).Cells(0).Value, ".")(1) = "SMI" Then

                If chkTimeLinePlayBackMethod.Checked Then
                    int_LeftFrame = int_TotalFrame - (e.Result.Status.Port(0).Video.FrameCount)
                    lblRemainingDuration.Text = FToHMSF(int_LeftFrame)
                    lblActiveID.Text = e.Result.Status.Port(0).ClipName
                    lbltimecode.Text = Format(e.Result.Status.Port(0).Video.LTC.Time.Hour, "00") & ":" & Format(e.Result.Status.Port(0).Video.LTC.Time.Minute, "00") & ":" & Format(e.Result.Status.Port(0).Video.LTC.Time.Second, "00") & ":" & Format(e.Result.Status.Port(0).Video.LTC.Frame, "00")
                    lblPlayedDuration.Text = FToHMSF(e.Result.Status.Port(0).Video.FrameCount)
                    lblCurrentFrame.Text = (e.Result.Status.Port(0).Video.FrameCount)
                Else
                    int_LeftFrame = int_TotalFrame - (e.Result.Status.Port(0).Video.FrameCount - HMSFtoF(Mid(clipBegin(0), 10)))
                    lblRemainingDuration.Text = FToHMSF(int_LeftFrame)
                    lblActiveID.Text = e.Result.Status.Port(0).ClipName
                    lbltimecode.Text = Format(e.Result.Status.Port(0).Video.LTC.Time.Hour, "00") & ":" & Format(e.Result.Status.Port(0).Video.LTC.Time.Minute, "00") & ":" & Format(e.Result.Status.Port(0).Video.LTC.Time.Second, "00") & ":" & Format(e.Result.Status.Port(0).Video.LTC.Frame, "00")
                    lblPlayedDuration.Text = FToHMSF(e.Result.Status.Port(0).Video.FrameCount - HMSFtoF(Mid(clipBegin(0), 10)))
                    lblCurrentFrame.Text = (e.Result.Status.Port(0).Video.FrameCount - HMSFtoF(Mid(clipBegin(0), 10)))
                End If



            Else
                int_LeftFrame = int_TotalFrame - e.Result.Status.Port(0).Video.FrameCount
                lblRemainingDuration.Text = FToHMSF(int_LeftFrame)
                lblActiveID.Text = e.Result.Status.Port(0).ClipName
                lbltimecode.Text = Format(e.Result.Status.Port(0).Video.LTC.Time.Hour, "00") & ":" & Format(e.Result.Status.Port(0).Video.LTC.Time.Minute, "00") & ":" & Format(e.Result.Status.Port(0).Video.LTC.Time.Second, "00") & ":" & Format(e.Result.Status.Port(0).Video.LTC.Frame, "00")
                lblPlayedDuration.Text = FToHMSF(e.Result.Status.Port(0).Video.FrameCount)
                lblCurrentFrame.Text = e.Result.Status.Port(0).Video.FrameCount
            End If

        End If


        lblMoreInfo.Text = "ClipType= " & e.Result.Status.ClipType.ToString & vbNewLine &
           "EDLSubClipNumber= " & e.Result.Status.EDLSubClipNumber & vbNewLine &
           "EDLSubClipTotalNumber= " & e.Result.Status.EDLSubClipTotalNumber & vbNewLine &
          "Mode= " & e.Result.Status.Mode.ToString & vbNewLine &
          "PlayMode= " & e.Result.Status.PlayMode.ToString & vbNewLine &
           "State= " & e.Result.Status.State.ToString & vbNewLine &
           "Audio= " & e.Result.Status.Port(0).Audio.Length & vbNewLine &
        "Busy= " & e.Result.Status.Port(0).Busy.ToString & vbNewLine &
        "CueupClipName= " & e.Result.Status.Port(0).CueupClipName & vbNewLine &
        "DriveId= " & e.Result.Status.Port(0).DriveId & vbNewLine &
        "PortId= " & e.Result.Status.Port(0).PortId & vbNewLine &
        "PortType= " & e.Result.Status.Port(0).PortType.ToString & vbNewLine &
        "Speed= " & e.Result.Status.Port(0).Speed & vbNewLine &
        "Standby= " & e.Result.Status.Port(0).Standby & vbNewLine &
        "Status= " & e.Result.Status.Port(0).Video.Status.ToString & vbNewLine &
        "RefStatus= " & e.Result.Status.RefStatus.ToString



    End Sub

    Private Sub dgvclips_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvclips.CellContentClick

    End Sub

    Private Sub dgv1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgv1.DataError
        'dont delete
    End Sub
    Private Sub dgv1_DragEnter(sender As Object, e As DragEventArgs) Handles dgv1.DragEnter
        On Error Resume Next
        e.Effect = DragDropEffects.Copy
    End Sub
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
            'getSingleIdDurationforplaylist(datatocopy(0), dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex)

        End If
        dgv1.Rows(dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex).Cells(4).Value = datatocopy(2)


        Dim hitrow As Integer = dgv1.HitTest(clientPoint.X, clientPoint.Y).RowIndex
        adjusttimeofplaylistfornewclip1(hitrow)
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
                    'cmsdgvclips.Show(MousePosition)
                Else
                    Dim cellX, cellY As Integer

                    Dim grvScreenLocation As Point = dgvclips.PointToScreen(dgvclips.Location)
                    Dim tempX As Integer = DataGridView.MousePosition.X - grvScreenLocation.X + dgvclips.Left
                    Dim tempY As Integer = DataGridView.MousePosition.Y - grvScreenLocation.Y + dgvclips.Top
                    Dim hit As DataGridView.HitTestInfo = dgvclips.HitTest(tempX, tempY)
                    cellX = hit.RowIndex
                    cellY = hit.ColumnIndex
                    dgvclips.CurrentCell = dgvclips.Rows(cellX).Cells(0)

                    Dim datatocopy As String = dgvclips.CurrentRow.Cells(0).Value & Chr(2) & dgvclips.CurrentRow.Cells(1).Value & Chr(2) & dgvclips.CurrentRow.Cells(2).Value
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
            clipinsert(dgv1)
            dgv1.CurrentCell = dgv1.Rows(dgv1.CurrentRow.Index + 1).Cells(0)
        End If
        dgv1.CurrentRow.Cells(0).Value = dgvclips.CurrentRow.Cells(0).Value
        dgv1.CurrentRow.Cells(2).Value = 1

        dgv1.CurrentRow.Cells(3).Value = dgvclips.CurrentRow.Cells(1).Value
        dgv1.CurrentRow.Cells(4).Value = dgvclips.CurrentRow.Cells(2).Value
        Dim hitrow As Integer = dgv1.CurrentRow.Index
        adjusttimeofplaylistfornewclip1(hitrow)
    End Sub
    Public Sub clipinsert(dg As DataGridView)
        On Error Resume Next
        With dg
            If .CurrentRow.Index < currrow Then
                currrow = currrow + 1
            End If
            .Rows.Insert(.CurrentRow.Index + 1)
            .Rows(.CurrentRow.Index + 1).Cells(2).Value = 1
        End With
    End Sub



    Sub adjusttimeofplaylistfornewclip1(ByVal hitrow As Integer)
        On Error Resume Next
        Dim i As Integer
        For i = hitrow - 1 To dgv1.RowCount - 1
            If i = 0 Then dgv1.Rows(0).Cells(1).Value = "00:00:00:00"
            If dgv1.Rows(i).Cells(2).Value = 0 Then
                dgv1.Rows(i + 1).Cells(1).Value = dgv1.Rows(i).Cells(1).Value
            Else
                CalculateStartTimeofnextClip(i)
            End If
        Next
    End Sub


    Dim oldvalue As Integer = 0
    Dim newvalue As Integer = 0

    Private Sub tbsoap_MouseDown(sender As Object, e As MouseEventArgs) Handles tbsoap.MouseDown
        On Error Resume Next
        tmrpreview.Enabled = True
        tmrGetTC.Enabled = False
    End Sub



    Private Sub tbsoap_Scroll(sender As Object, e As EventArgs) Handles tbsoap.Scroll
        'dummy 
    End Sub

    Private Sub tbsoap_MouseUp(sender As Object, e As MouseEventArgs) Handles tbsoap.MouseUp
        On Error Resume Next
        tmrpreview.Enabled = False
        tmrGetTC.Enabled = True
    End Sub


    Private Sub tmrpreview_Tick(sender As Object, e As EventArgs) Handles tmrpreview.Tick
        On Error Resume Next
        Dim bb As New OpenPlayerRequest
        bb.ClipName = lblActiveID.Text
        bb.DriveId = cmbClipDrive.Text '"InternalDrive"
        bb.Offset = tbsoap.Value
        bb.PlayerId = "Player_1"
        bb.PlayerMode = OpenPlayerMode.Still
        aa.OpenPlayer(bb)

    End Sub
    Sub stepframe(frame As Integer)
        On Error Resume Next
        Dim bb As New StepRequest
        bb.PlayerId = "Player_1"
        bb.Frames = frame
        aa.Step(bb)
    End Sub

    Private Sub cmdSaveSubClipSopa_Click(sender As Object, e As EventArgs) Handles cmdSaveSubClipSopa.Click
        On Error Resume Next
        Dim osd2 As New SaveFileDialog
        osd2.InitialDirectory = cmbMappedDriveName.Text & "INTERNAL\Edit\"
        osd2.Filter = "SMI files (*.SMI)|*.SMI|All files (*.*)|*.*"
        osd2.FileName = Split(lblActiveID.Text, ".")(0) & "_Trimmed"
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then


            Dim xmlsetting As New XmlWriterSettings
            xmlsetting.Indent = True
            Using writer As XmlWriter = XmlWriter.Create(osd2.FileName, xmlsetting)
                writer.WriteStartDocument() 'Document start

                writer.WriteStartElement("smil", "urn:schemas-professionalDisc:edl:ver.2.00:editList") ' Root element.
                writer.WriteAttributeString("umid", "060A2B340101010501010D23130000004C218AA7D1BD48A189445B4106788745")

                writer.WriteStartElement("body")

                writer.WriteStartElement("par")
                writer.WriteStartElement("ref")
                writer.WriteAttributeString("src", "urn:smpte:umid:" & lblUMID.Text)
                writer.WriteAttributeString("clipBegin", "smpte-25=" & FToHMSF(txtmarkinsoap.Text))
                writer.WriteAttributeString("clipEnd", "smpte-25=" & FToHMSF(txtmarkoutsoap.Text))
                writer.WriteAttributeString("begin", "smpte-25=00:00:00:00")
                writer.WriteAttributeString("title", lblActiveID.Text)
                writer.WriteEndElement()

                writer.WriteEndElement()
                writer.WriteEndElement()
                writer.WriteEndElement() 'root element end
                writer.WriteEndDocument() 'Document end
            End Using
            'lblfilename.Text = osd2.FileName
        End If
    End Sub


    Sub CueClip(clipname As String, drivename As String)

        On Error Resume Next
        Dim bb As New OpenPlayerRequest
        bb.ClipName = clipname
        bb.DriveId = drivename
        bb.Offset = 0
        bb.PlayerId = "Player_1"
        bb.PlayerMode = OpenPlayerMode.Still
        aa.OpenPlayer(bb)
    End Sub

    Sub CueAndPlayClip(clipname As String, drivename As String)
        On Error Resume Next
        currrow = dgv1.CurrentRow.Index

        Dim bb As New OpenPlayerRequest
        bb.ClipName = clipname
        bb.DriveId = drivename
        bb.Offset = 0
        bb.PlayerId = "Player_1"

        bb.PlayerMode = OpenPlayerMode.Play
        aa.OpenPlayer(bb)
    End Sub

    Sub CueAndPlayClip1()
        'currrow = dgv1.CurrentRow.Index

        On Error Resume Next
        Dim bb As New StopPlayerTimeLineRequest
        bb.PlayerId = "Player_1"
        aa.StopPlayerTimeLine(bb)

        Dim bb1 As New DeletePlayerTimeLineAllEventRequest
        bb1.PlayerId = "Player_1"
        aa.DeletePlayerTimeLineAllEvent(bb1)

        Dim hh As New CueAndPlayEvent

        If Split(dgv1.Rows(nextrow).Cells(0).Value, ".")(1) = "SMI" Then
            getmxffilenameandoffset(dgv1.Rows(nextrow).Cells(0).Value, cmbClipDrive.Text)

            hh.ClipName = mxffilename(0)
            hh.CueUpPosition = HMSFtoF(Mid(clipBegin(0), 10))
        Else
            hh.ClipName = dgv1.Rows(nextrow).Cells(0).Value
            hh.CueUpPosition = 0
        End If


        hh.DriveId = "InternalDrive"
        hh.Mode = OpenPlayerMode.Play
        hh.Target = PlayTarget.Background


        Dim cc As New PlayerTimeLineEvent
        cc.Item = hh
        cc.ItemElementName = ItemChoiceType1.CueAndPlay


        Dim bb4 As New AddPlayerTimeLineEventRequest
        bb4.Event = cc
        bb4.EventId = 2
        bb4.Offset = 125
        bb4.PlayerId = "Player_1"

        aa.AddPlayerTimeLineEvent(bb4)

        Dim bb3 As New StartPlayerTimeLineRequest
        bb3.PlayerId = "Player_1"
        aa.StartPlayerTimeLine(bb3)
    End Sub
    Sub CueAndPlayinloop(clipname As String, drivename As String)
        On Error Resume Next
        currrow = dgv1.CurrentRow.Index

        Dim bb As New OpenPlayerRequest
        bb.ClipName = clipname
        bb.DriveId = drivename
        bb.Offset = 0
        bb.PlayerId = "Player_1"

        bb.PlayerMode = OpenPlayerMode.Repeat
        aa.OpenPlayer(bb)


    End Sub

    Private Sub aa_OpenPlayerCompleted(sender As Object, e As OpenPlayerCompletedEventArgs) Handles aa.OpenPlayerCompleted
        On Error Resume Next
        'clipproperty(dgvclips.CurrentRow.Cells(0).Value)
    End Sub


    Private Sub lblCurrentFrame_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblCurrentFrame_TextChanged(sender As Object, e As EventArgs) Handles lblCurrentFrame.TextChanged
        Try
            tbsoap.Value = lblCurrentFrame.Text
        Catch ex As Exception

        End Try

    End Sub
    Private Sub lblActiveID_TextChanged(sender As Object, e As EventArgs) Handles lblActiveID.TextChanged
        On Error Resume Next
        If lblActiveID.Text <> "" And lblActiveID.Text <> "Active ID" Then
            clipproperty(lblActiveID.Text)
        End If

    End Sub

    Private Sub cmdCueFromPlaylist_Click(sender As Object, e As EventArgs) 
        On Error Resume Next
        currrow = dgv1.CurrentRow.Index
        CueClip(dgv1.CurrentRow.Cells(0).Value, cmbClipDrive.Text)

    End Sub

    Private Sub cmdCueFromClipGrid_Click(sender As Object, e As EventArgs) 
        On Error Resume Next
        CueClip(dgvclips.CurrentRow.Cells(0).Value, cmbClipDrive.Text)
    End Sub
    Private Sub cmdStartPlayList_Click(sender As Object, e As EventArgs) Handles cmdStartPlayList.Click
        On Error Resume Next
        currrow = Me.dgv1.CurrentRow.Index
        If sender.text = "Start Playlist" Then
            If chkTimeLinePlayBackMethod.Checked Then
                nextrow = currrow
                CueAndPlayClip1()
                cueupcommandsend = False
            Else
                If chkPlaySMIasXMF.Checked = True And Split(dgv1.CurrentRow.Cells(0).Value, ".")(1) = "SMI" Then
                    playcommandforsmifilefromplaylist(dgv1.CurrentRow.Cells(0).Value, cmbClipDrive.Text)
                Else
                    CueAndPlayClip(dgv1.CurrentRow.Cells(0).Value, cmbClipDrive.Text)
                End If

            End If

            tmrNextClipofPlaylist.Enabled = False
            tmrfornotskipping.Enabled = True
            sender.text = "Stop Playlist"

            adjusttimeofplaylist1()

        Else
            tmrNextClipofPlaylist.Enabled = False
            tmrfornotskipping.Enabled = False
            sender.text = "Start Playlist"
            stopclip()
        End If


    End Sub
    Sub adjusttimeofplaylist1()
        On Error Resume Next
        Dim i As Integer
        For i = dgv1.CurrentRow.Index - 1 To dgv1.RowCount - 1
            Dim aa As Date = dgv1.Rows(i).Cells(1).Value
            If dgv1.Rows(i).Cells(2).Value = 0 Then
                dgv1.Rows(i + 1).Cells(1).Value = Format(Now, "HH:mm:ss:ff")
            Else
                CalculateStartTimeofnextClip(i)
            End If
        Next
    End Sub
    Private Sub tmrNextClipofPlaylist_Tick(sender As Object, e As EventArgs) Handles tmrNextClipofPlaylist.Tick
        On Error Resume Next
        If dgv1.Rows(currrow + 1).Cells(0).Value = "end" Then
            tmrNextClipofPlaylist.Enabled = False
            cmdStartPlayList.Text = "Start Playlist"
        Else
            nextclipofplaylist()
        End If
    End Sub
    Dim cueupcommandsend As Boolean = False
    Sub nextclipofplaylist()
        On Error Resume Next

        If HMSFtoF(lblRemainingDuration.Text) < 135 And chkTimeLinePlayBackMethod.Checked And cueupcommandsend = False Then
            assignnextrow()
            CueAndPlayClip1()
            cueupcommandsend = True
        End If

        If HMSFtoF(lblRemainingDuration.Text) < 15 Then 'changeoverframe Then
            SwitchToNextClip()
            cueupcommandsend = False
            If chkTimeLinePlayBackMethod.Checked Then
                'CueAndPlayClip1()
            Else
                If chkPlaySMIasXMF.Checked = True And Split(dgv1.CurrentRow.Cells(0).Value, ".")(1) = "SMI" Then
                    playcommandforsmifilefromplaylist(dgv1.CurrentRow.Cells(0).Value, cmbClipDrive.Text)
                Else
                    CueAndPlayClip(dgv1.CurrentRow.Cells(0).Value, cmbClipDrive.Text)
                End If
            End If
            adjusttimeofplaylist1()
            tmrNextClipofPlaylist.Enabled = False
            tmrfornotskipping.Enabled = True
        End If
    End Sub

    Sub SwitchToNextClip()
        On Error Resume Next
20:
        Dim i As Integer
        i = dgv1.Rows(currrow).Index
        If i = (dgv1.Rows.Count - 1) Then
            dgv1.CurrentCell = dgv1.Rows(0).Cells(0)
            currrow = 0
        Else
            dgv1.CurrentCell = dgv1.Rows(i + 1).Cells(0)
            currrow = currrow + 1
        End If
        If dgv1.CurrentRow.Cells(0).Value = "" Or dgv1.CurrentRow.Cells(2).Value = 0 Then GoTo 20


    End Sub
    Dim nextrow As Integer
    Sub assignnextrow()
        'On Error Resume Next

        Dim i As Integer
        i = dgv1.Rows(currrow).Index
        If i = (dgv1.Rows.Count - 2) Then
            'dgv1.CurrentCell = dgv1.Rows(0).Cells(0)
            nextrow = 0
        Else
            ' dgv1.CurrentCell = dgv1.Rows(i + 1).Cells(0)
            nextrow = currrow + 1
        End If
20:     If dgv1.Rows(nextrow).Cells(0).Value = "" Or dgv1.Rows(nextrow).Cells(2).Value = 0 Then
            nextrow = nextrow + 1
            GoTo 20
        End If

    End Sub

    Private Function HMSFtoF(ByVal HMSF As String) As Integer
        On Error Resume Next
        Dim F As Integer
        F = (Val(Mid(HMSF, 1, 2)) * fps * 60 * 60 + Val(Mid(HMSF, 4, 2)) * fps * 60 + Val(Mid(HMSF, 7, 2)) * fps + Val(Mid(HMSF, 10, 2))).ToString
        Return F
    End Function

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        On Error Resume Next
        dgv1.Rows.Clear()
        dgv1.Rows.Add(5)
        lblplaylistname.Text = "new playlist"
    End Sub

    Private Sub SaveAsToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripButton.Click
        On Error Resume Next
        PutFirstClipStarttime00()
        saveplaylist()
    End Sub
    Sub saveplaylist()
        Dim osd2 As New SaveFileDialog
        osd2.InitialDirectory = cmbMappedDriveName.Text & "INTERNAL\Edit\"
        osd2.Filter = "SMI files (*.SMI)|*.SMI|All files (*.*)|*.*"
        osd2.FileName = ""
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then


            Dim xmlsetting As New XmlWriterSettings
            xmlsetting.Indent = True
            Using writer As XmlWriter = XmlWriter.Create(osd2.FileName, xmlsetting)
                writer.WriteStartDocument() 'Document start

                writer.WriteStartElement("smil", "urn:schemas-professionalDisc:edl:ver.2.00:editList") ' Root element.
                writer.WriteAttributeString("umid", "060A2B340101010501010D23130000004C218AA7D1BD48A189445B4106788745")

                writer.WriteStartElement("body")

                writer.WriteStartElement("par")

                For ii = 0 To dgvclips.RowCount - 1
                    If dgv1.Rows(ii).Cells(2).Value = 1 And dgv1.Rows(ii).Cells(1).Value <> "" Then
                        writer.WriteStartElement("ref")
                        writer.WriteAttributeString("src", "urn:smpte:umid:" & dgv1.Rows(ii).Cells(4).Value)
                        writer.WriteAttributeString("clipBegin", "smpte-25=00:00:00:00")
                        writer.WriteAttributeString("clipEnd", "smpte-25=" & dgv1.Rows(ii).Cells(3).Value)
                        writer.WriteAttributeString("begin", "smpte-25=" & dgv1.Rows(ii).Cells(1).Value)
                        writer.WriteAttributeString("title", dgv1.Rows(ii).Cells(0).Value)
                        writer.WriteEndElement()
                    End If

                Next
                writer.WriteEndElement()
                writer.WriteEndElement()
                writer.WriteEndElement() 'root element end
                writer.WriteEndDocument() 'Document end
            End Using
            lblplaylistname.Text = osd2.FileName
        End If

    End Sub
    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        Try
            Dim ofd2 As New OpenFileDialog
            ofd2.InitialDirectory = cmbMappedDriveName.Text & "INTERNAL\Edit\"
            ofd2.Filter = "SMI files (*.SMI)|*.SMI|All files (*.*)|*.*"
            If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then


                Dim response1 As New XmlDocument
                response1.Load(ofd2.FileName)

                dgv1.Rows.Clear()
                Dim ii As Integer = 0
                For Each keyframe As XmlElement In response1.GetElementsByTagName("ref")
                    dgv1.Rows.Add()
                    dgv1.Rows(ii).Cells(0).Value = keyframe.GetAttribute("title")
                    dgv1.Rows(ii).Cells(1).Value = Mid(keyframe.GetAttribute("begin"), 10)
                    dgv1.Rows(ii).Cells(2).Value = 1
                    dgv1.Rows(ii).Cells(3).Value = Mid(keyframe.GetAttribute("clipEnd"), 10)
                    dgv1.Rows(ii).Cells(4).Value = Mid(keyframe.GetAttribute("src"), 16)

                    ii = ii + 1
                Next
                lblplaylistname.Text = ofd2.FileName
            End If
        Catch ex As Exception
            'MsgBox("Couldn't Save")
        End Try


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
        adjusttimeofplaylistfornewclip1(dgv1.CurrentRow.Index)
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
            Dim aaa2 As String = dgv1.Rows(curRow - 1).Cells(1).Value 'start time
            Dim myRow As DataGridViewRow = Me.dgv1.CurrentRow
            Me.dgv1.Rows.Remove(myRow)
            Me.dgv1.Rows.Insert(curRow - 1, myRow)
            dgv1.CurrentCell = dgv1.Rows(curRow - 1).Cells(0)
            dgv1.Rows(curRow - 1).Cells(1).Value = aaa2
            CalculateStartTimeofnextClip(dgv1.CurrentRow.Index)
        End If
    End Sub

    Function CalculateStartTimeofnextClip(currentrow As Integer)
        On Error Resume Next


        Dim i As Integer = currentrow
        Dim sec1 As Integer = (Mid(dgv1.Rows(i).Cells(1).Value, 1, 2)) * 3600 + (Mid(dgv1.Rows(i).Cells(1).Value, 4, 2)) * 60 + (Mid(dgv1.Rows(i).Cells(1).Value, 7, 2))
        Dim frm1 As Integer = Mid(dgv1.Rows(i).Cells(1).Value, 10, 2)
        Dim totfram1 As Integer = sec1 * fps + frm1

        Dim sec2 As Integer = (Mid(dgv1.Rows(i).Cells(3).Value, 1, 2)) * 3600 + (Mid(dgv1.Rows(i).Cells(3).Value, 4, 2)) * 60 + (Mid(dgv1.Rows(i).Cells(3).Value, 7, 2))
        Dim frm2 As Integer = Mid(dgv1.Rows(i).Cells(3).Value, 10, 2)
        Dim totfram2 As Integer = sec2 * fps + frm2
        dgv1.Rows(i + 1).Cells(1).Value = FToHMSF(totfram1 + totfram2)
        ' Next
    End Function

    Private Sub cmdmovedown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmovedown.Click
        On Error Resume Next
        clipmovedown()
    End Sub
    Sub clipmovedown()
        On Error Resume Next
        If Me.dgv1.CurrentCell.RowIndex <> dgv1.Rows.Count - 2 Then

            Dim curRow As Integer = Me.dgv1.CurrentCell.RowIndex

            Dim aaa2 As String = dgv1.Rows(curRow).Cells(1).Value

            Dim myRow As DataGridViewRow = Me.dgv1.CurrentRow
            Me.dgv1.Rows.Remove(myRow)
            Me.dgv1.Rows.Insert(curRow + 1, myRow)
            dgv1.CurrentCell = dgv1.Rows(curRow + 1).Cells(0)

            dgv1.Rows(curRow).Cells(1).Value = aaa2
            CalculateStartTimeofnextClip(dgv1.CurrentRow.Index - 1)
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
            adjusttimeofplaylistfornewclip1(dgv1.CurrentRow.Index)
        Else
            MsgBox("Online clip cann't be deleted.")
        End If
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        On Error Resume Next
        If dgv1.CurrentCell.ColumnIndex = 2 Then
            dgv1.EndEdit()
            adjusttimeofplaylistfornewclip1(dgv1.CurrentRow.Index)
        End If
    End Sub

    Private Sub dgvclips_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvclips.DataError
        'dont delete
    End Sub


    Sub PutFirstClipStarttime00()
        On Error Resume Next
        dgv1.Rows(0).Cells(1).Value = "00:00:00:00"
        For i = 0 To dgv1.Rows.Count - 1
            CalculateStartTimeofnextClip(i)
        Next
    End Sub
    Private Sub tmrfornotskipping_Tick(sender As Object, e As EventArgs) Handles tmrfornotskipping.Tick
        On Error Resume Next
        tmrNextClipofPlaylist.Enabled = True
        tmrfornotskipping.Enabled = False
    End Sub

    Private Sub StopF1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopF1ToolStripMenuItem.Click
        On Error Resume Next
        stopclip()
    End Sub

    Private Sub PlayToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem1.Click
        On Error Resume Next
        CueAndPlayClip(dgv1.CurrentRow.Cells(0).Value, cmbClipDrive.Text)
    End Sub

    Private Sub CueToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CueToolStripMenuItem1.Click
        On Error Resume Next
        currrow = dgv1.CurrentRow.Index
        CueClip(dgv1.CurrentRow.Cells(0).Value, cmbClipDrive.Text)
    End Sub

    Private Sub PauseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem1.Click
        On Error Resume Next
        pauseclip()
    End Sub

    Private Sub ResumeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ResumeToolStripMenuItem1.Click
        On Error Resume Next
        playcommand()
    End Sub

    Private Sub NextToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem1.Click
        On Error Resume Next
        SwitchToNextClip()
        CueClip(dgv1.CurrentRow.Cells(0).Value, cmbClipDrive.Text)
    End Sub


    Private Sub PlayNextF6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayNextF6ToolStripMenuItem.Click
        On Error Resume Next
        SwitchToNextClip()
        CueAndPlayClip(dgv1.CurrentRow.Cells(0).Value, cmbClipDrive.Text)
    End Sub

    Private Sub InsertBlankToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertBlankToolStripMenuItem.Click
        On Error Resume Next
        clipinsert()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        On Error Resume Next
        deleteclip()
    End Sub

    Private Sub CopyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem1.Click
        On Error Resume Next
        clipcopy()
    End Sub

    Private Sub PasteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem1.Click
        On Error Resume Next
        insertcopied()
    End Sub

    Private Sub MoveUpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MoveUpToolStripMenuItem1.Click
        On Error Resume Next
        clipmoveup()
    End Sub

    Private Sub MoveDownToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MoveDownToolStripMenuItem1.Click
        On Error Resume Next
        clipmovedown()
    End Sub

    Private Sub CueInCsparcgToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CueInCsparcgToolStripMenuItem.Click
        On Error Resume Next
        CueClip(dgvclips.CurrentRow.Cells(0).Value, cmbClipDrive.Text)
    End Sub

    Private Sub PlayInCasparcgToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayInCasparcgToolStripMenuItem.Click
        On Error Resume Next
        CueAndPlayClip(dgvclips.CurrentRow.Cells(0).Value, cmbClipDrive.Text)
    End Sub

    Private Sub InserEndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InserEndToolStripMenuItem.Click
        On Error Resume Next
        dgv1.Rows.Insert(dgv1.CurrentRow.Index + 1)
        dgv1.CurrentCell = dgv1.Rows(dgv1.CurrentRow.Index + 1).Cells(0)
        dgv1.CurrentRow.Cells(0).Value = "end"
    End Sub

    Private Sub cmdstop_Click(sender As Object, e As EventArgs) Handles cmdstop.Click
        On Error Resume Next
        stopclip()
    End Sub

    Private Sub cmdcueclip_Click(sender As Object, e As EventArgs) Handles cmdcueclip.Click
        On Error Resume Next
        CueClip(lblActiveID.Text, cmbClipDrive.Text)
    End Sub

    Private Sub cmdpausevdcp_Click(sender As Object, e As EventArgs) Handles cmdpausevdcp.Click
        On Error Resume Next
        pauseclip()
    End Sub

    Private Sub cmdresume_Click(sender As Object, e As EventArgs) Handles cmdresume.Click
        On Error Resume Next
        playcommand()
    End Sub

    Private Sub cmdbackoneframe_Click(sender As Object, e As EventArgs) Handles cmdbackoneframe.Click
        On Error Resume Next
        stepframe(-1)
    End Sub

    Private Sub cmdforwardoneframe_Click(sender As Object, e As EventArgs) Handles cmdforwardoneframe.Click
        On Error Resume Next
        stepframe(1)
    End Sub

    Private Sub cmdPlaySingleClip_Click(sender As Object, e As EventArgs) Handles cmdPlaySingleClip.Click
        On Error Resume Next
        CueAndPlayClip(lblActiveID.Text, cmbClipDrive.Text)
        playcommand()
    End Sub

    Private Sub cmdcuenext_Click(sender As Object, e As EventArgs) Handles cmdcuenext.Click
        On Error Resume Next
        SwitchToNextClip()
        CueClip(dgv1.CurrentRow.Cells(0).Value, cmbClipDrive.Text)
    End Sub

    Private Sub cmdnextplay_Click(sender As Object, e As EventArgs) Handles cmdnextplay.Click
        On Error Resume Next
        SwitchToNextClip()
        CueAndPlayClip(dgv1.CurrentRow.Cells(0).Value, cmbClipDrive.Text)
    End Sub

    Private Sub cmdmarkin_Click(sender As Object, e As EventArgs) Handles cmdmarkin.Click
        On Error Resume Next
        txtmarkinsoap.Text = lblCurrentFrame.Text

    End Sub

    Private Sub cmdmarkout_Click(sender As Object, e As EventArgs) Handles cmdmarkout.Click
        On Error Resume Next
        txtmarkoutsoap.Text = lblCurrentFrame.Text
    End Sub

    Private Sub cmdgotoend_Click(sender As Object, e As EventArgs) Handles cmdgotoend.Click
        On Error Resume Next
        gototc(lblActiveID.Text, cmbClipDrive.Text, lbltbmax.Text, OpenPlayerMode.Still)
    End Sub

    Sub gototc(clipname As String, drivename As String, offset As Integer, opm As OpenPlayerMode)
        On Error Resume Next
        Dim bb As New OpenPlayerRequest
        bb.ClipName = clipname
        bb.DriveId = drivename
        bb.Offset = offset
        bb.PlayerId = "Player_1"
        bb.PlayerMode = opm
        aa.OpenPlayer(bb)
    End Sub

    Private Sub cmdplayfromin_Click(sender As Object, e As EventArgs) Handles cmdplayfromin.Click
        On Error Resume Next
        stepframe(txtmarkinsoap.Text - lblCurrentFrame.Text)
        playcommand()
    End Sub

    Private Sub cmdgotoin_Click(sender As Object, e As EventArgs) Handles cmdgotoin.Click
        On Error Resume Next
        stepframe(txtmarkinsoap.Text - lblCurrentFrame.Text)
    End Sub

    Private Sub cmdgotoout_Click(sender As Object, e As EventArgs) Handles cmdgotoout.Click
        On Error Resume Next
        stepframe(txtmarkoutsoap.Text - lblCurrentFrame.Text)

    End Sub

    Private Sub cmdplayfromout_Click(sender As Object, e As EventArgs) Handles cmdplayfromout.Click
        On Error Resume Next
        stepframe(txtmarkoutsoap.Text - lblCurrentFrame.Text)
        playcommand()

    End Sub

    Private Sub cmdplaylast5seccasaprcgwindow_Click(sender As Object, e As EventArgs) Handles cmdplaylast5seccasaprcgwindow.Click
        On Error Resume Next
        stepframe(lbltbmax.Text - 125 - lblCurrentFrame.Text)
        ' stepframe(lbltbmax.Text - 125)
        playcommand()
    End Sub

    Private Sub cmdforwardsecond_Click(sender As Object, e As EventArgs) Handles cmdforwardsecond.Click
        On Error Resume Next
        stepframe((txtforwardsecond.Text) * 25)
    End Sub

    Private Sub cmdgototccasparcgwindow_Click(sender As Object, e As EventArgs) Handles cmdgototccasparcgwindow.Click
        On Error Resume Next
        stepframe(HMSFtoF(txtgototccasparcgwindow.Text) - HMSFtoF(lbltimecode.Text))
    End Sub

    Private Sub nvlcspeed_ValueChanged(sender As Object, e As EventArgs) Handles nvlcspeed.ValueChanged
        On Error Resume Next
        If lblActiveID.Text <> "Active ID" Then
            Dim bb As New VarRequest
            bb.PlayerId = "Player_1"
            bb.Speed = nvlcspeed.Value
            aa.Var(bb)
        End If

    End Sub

    Private Sub cmdspeed1trimmer_Click(sender As Object, e As EventArgs) Handles cmdspeed1trimmer.Click
        On Error Resume Next
        nvlcspeed.Value = 1
    End Sub


    Sub ranamefile(clipname As String, clipnewname As String, drivename As String)
        On Error Resume Next
        Dim bb As New RenameFileRequest
        bb.OldFileName = clipname
        bb.DriveId = drivename
        bb.NewFileName = clipnewname ' Split(clipname, ".")(0) & "_Renamed." & Split(clipname, ".")(1)
        aa.RenameFile(bb)
    End Sub
    Sub deletefile(clipname As String, drivename As String)
        On Error Resume Next
        Dim bb As New DeleteFileRequest
        bb.FileName = clipname
        bb.DriveId = drivename
        aa.DeleteFile(bb)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        On Error Resume Next
        deletefile(dgvclips.CurrentRow.Cells(0).Value, cmbClipDrive.Text)
        dgvclips.Rows.Remove(dgvclips.CurrentRow)
        lblClips.Text = lblClips.Text - 1
    End Sub

    Private Sub RenameFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameFileToolStripMenuItem.Click
        Dim xx As String = InputBox("New Name", "Rename File " & dgvclips.CurrentRow.Cells(0).Value, Split(dgvclips.CurrentRow.Cells(0).Value, ".")(0) & "_Renamed")
        If xx <> "" Then
            ranamefile(dgvclips.CurrentRow.Cells(0).Value, xx & "." & Split(dgvclips.CurrentRow.Cells(0).Value, ".")(1), cmbClipDrive.Text)
            dgvclips.CurrentRow.Cells(0).Value = xx & "." & Split(dgvclips.CurrentRow.Cells(0).Value, ".")(1)
        End If
    End Sub

    Private Sub lblActiveID_Click(sender As Object, e As EventArgs) Handles lblActiveID.Click

    End Sub
    Private Sub getMappedDrives()
        Dim drive As System.IO.DriveInfo
        For Each drive In System.IO.DriveInfo.GetDrives()
            If drive.DriveType = IO.DriveType.Network Then
                cmbMappedDriveName.Items.Add(drive.Name)
            End If
        Next
    End Sub
    Private Sub frmXdcamSoapClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        System.Net.ServicePointManager.Expect100Continue = False

        dgvclips.Rows.Add(5)
        dgvclips.Rows(0).Cells(0).Value = "dolby_with_stereo.MXF"

        dgv1.Rows.Add(6)
        dgv1.Rows(0).Cells(0).Value = "dolby_with_stereo.MXF"
        dgv1.Rows(0).Cells(2).Value = 1

        appdate = Me.Text


        'setxdcam()

        getMappedDrives()
        ' getsystemeventrequest()


    End Sub

    Private Sub cmdSetXdcam_Click(sender As Object, e As EventArgs) Handles cmdSetXdcam.Click
        On Error Resume Next

        setxdcam()
        tmrGetTC.Enabled = True
    End Sub


    Sub setxdcam()
        On Error Resume Next
        aa.Credentials = New System.Net.NetworkCredential(txtUsername.Text, txtPassword.Text)
        aa.Url = (txtipaddress.Text).ToString

    End Sub


    Private Sub PlayInVlcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayInVlcToolStripMenuItem.Click


        If Split(dgvclips.CurrentRow.Cells(0).Value, ".")(1) = "SMI" Then
            playinvlc(cmbMappedDriveName.Text & "INTERNAL\edit\" & dgv1.CurrentRow.Cells(0).Value)
        Else
            playinvlc(cmbMappedDriveName.Text & "INTERNAL\clip\" & dgv1.CurrentRow.Cells(0).Value)
        End If

    End Sub

    Private Sub PlayInVlcToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PlayInVlcToolStripMenuItem1.Click
        If Split(dgvclips.CurrentRow.Cells(0).Value, ".")(1) = "SMI" Then
            playinvlc(cmbMappedDriveName.Text & "INTERNAL\edit\" & dgvclips.CurrentRow.Cells(0).Value)
        Else
            playinvlc(cmbMappedDriveName.Text & "INTERNAL\clip\" & dgvclips.CurrentRow.Cells(0).Value)
        End If

    End Sub


    Private Sub cmdFastFarward_Click(sender As Object, e As EventArgs) Handles cmdFastFarward.Click
        On Error Resume Next
        Dim bb As New FastForwardRequest
        bb.PlayerId = "Player_1"
        aa.FastForward(bb)
    End Sub

    Private Sub cmdFastReverse_Click(sender As Object, e As EventArgs) Handles cmdFastReverse.Click
        On Error Resume Next
        Dim bb As New RewindRequest
        bb.PlayerId = "Player_1"
        aa.Rewind(bb)
    End Sub


    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            ClipSerach()
        End If
    End Sub
    Function readsmifile1(smifilename As String) As String
        On Error Resume Next
        Dim response1 As New XmlDocument
        response1.Load(smifilename)

        Dim mxffilename() As String = {10}
        Dim ii As Integer = 0

        For Each keyframe As XmlElement In response1.GetElementsByTagName("ref")
            mxffilename(ii) = keyframe.GetAttribute("title")
            ii = ii + 1
        Next
        Return cmbMappedDriveName.Text & "Internal\clip\" & mxffilename(0)
        'MsgBox(cmbMappedDriveName.Text & "Internal\edit\" & mxffilename(0))
    End Function
    Public Sub playinvlc(filename As String)
        On Error Resume Next
        'Dim PlayerPath As String = ""
        'If System.IO.File.Exists("C:\Program Files\VideoLAN\VLC\vlc.exe") Then
        '    PlayerPath = "C:\Program Files\VideoLAN\VLC\vlc.exe"
        'Else
        '    PlayerPath = "C:\Program Files (x86)\VideoLAN\VLC\vlc.exe"
        'End If
        Dim process As Process = New Process
        process.StartInfo.FileName = vlcplayerpath() ' PlayerPath
        process.StartInfo.Verb = "open"

        If System.IO.Path.GetExtension(filename) = ".SMI" Then
            process.StartInfo.Arguments = """" & Replace(readsmifile1(filename), "/", "\") & """"

        Else
            process.StartInfo.Arguments = """" & Replace(filename, "/", "\") & """"
        End If
        process.Start()
    End Sub

    Private Sub cmdGetRecoredrStatus_Click(sender As Object, e As EventArgs) Handles cmdGetRecoredrStatus.Click
        On Error Resume Next
        GetRecoredrStatus()
    End Sub
    Sub GetRecoredrStatus()
        On Error Resume Next
        Dim bb As New GetRecorderStatusRequest
        bb.RecorderId = "Recorder_1"
        aa.GetRecorderStatusAsync(bb)
    End Sub
    Private Sub aa_GetRecorderStatusCompleted(sender As Object, e As GetRecorderStatusCompletedEventArgs) Handles aa.GetRecorderStatusCompleted
        On Error Resume Next
        'port id="Port_1"
        lblRecorderStatus.Text = e.Result.Status.State.ToString & vbNewLine &
           "TC= " & Format(e.Result.Status.Port(0).Video.LTC.Time.Hour, "00") & ":" & Format(e.Result.Status.Port(0).Video.LTC.Time.Minute, "00") & ":" & Format(e.Result.Status.Port(0).Video.LTC.Time.Second, "00") & ":" & Format(e.Result.Status.Port(0).Video.LTC.Frame, "00") & vbNewLine &
        "Duration= " & FToHMSF(e.Result.Status.Port(0).Video.FrameCount)
    End Sub

    Private Sub tmrRecoderStatus_Tick(sender As Object, e As EventArgs) Handles tmrRecoderStatus.Tick
        On Error Resume Next
        GetRecoredrStatus()
    End Sub

    Private Sub cmdGetThumbNail_Click(sender As Object, e As EventArgs) Handles cmdGetThumbNail.Click
        thumbnailRowindex = 0
        getthumbanail(cmbClipDrive.Text, dgvclips.Rows(0).Cells(0).Value)
    End Sub

    Private Sub cmdShutDown_Click(sender As Object, e As EventArgs) Handles cmdShutDown.Click
        On Error Resume Next
        Dim bb As New ShutdownRequest
        bb.Seconds = 0
        aa.Shutdown(bb)
    End Sub


    Private Sub cdmEject_Click(sender As Object, e As EventArgs) Handles cdmEject.Click
        On Error Resume Next
        Dim bb As New EjectRequest
        bb.DriveId = cmbEjectDrive.Text
        aa.Eject(bb)
    End Sub

    Private Sub cmdGetSystemProperties_Click(sender As Object, e As EventArgs) Handles cmdGetSystemProperties.Click
        On Error Resume Next
        Dim bb As New GetSystemPropertiesRequest
        aa.GetSystemPropertiesAsync(bb)
    End Sub

    Private Sub aa_GetSystemPropertiesCompleted(sender As Object, e As GetSystemPropertiesCompletedEventArgs) Handles aa.GetSystemPropertiesCompleted
        lblSystemProperties.Text = "FirmwareVersion= " & e.Result.Device.FirmwareVersion & vbNewLine &
       "HasPDDrive= " & e.Result.Device.HasPDDrive & vbNewLine &
       "NetAPIVersion= " & e.Result.Device.NetAPIVersion & vbNewLine &
       "SerialNumber= " & e.Result.Device.SerialNumber & vbNewLine &
       "SxSRecordingEnabled= " & e.Result.Device.SxSRecordingEnabled & vbNewLine &
       "SystemFrequency= " & e.Result.Device.SystemFrequency & vbNewLine &
       "VTRMode= " & e.Result.Device.VTRMode & vbNewLine &
       "Manufacturer= " & e.Result.Model.Manufacturer & vbNewLine &
       "ModelName= " & e.Result.Model.ModelName

    End Sub

    Private Sub cmdGetSystemStatus_Click(sender As Object, e As EventArgs) Handles cmdGetSystemStatus.Click
        On Error Resume Next
        Dim bb As New GetSystemStatusRequest
        aa.GetSystemStatusAsync(bb)
    End Sub

    Private Sub aa_GetSystemStatusCompleted(sender As Object, e As GetSystemStatusCompletedEventArgs) Handles aa.GetSystemStatusCompleted
        On Error Resume Next
        lblSystemStatus.Text = "ErrorOccurred= " & e.Result.Status.ErrorOccurred & vbNewLine &
        "RaidRebuildRequired= " & e.Result.Status.Maintenance.RaidRebuildRequired & vbNewLine &
       "RepowerRequired= " & e.Result.Status.Maintenance.RepowerRequired & vbNewLine &
       "MonitorOutPort= " & e.Result.Status.MonitorOutPort & vbNewLine &
       "NetAPI.LinkCount= " & e.Result.Status.NetAPI.LinkCount & vbNewLine &
       "PortRemote(0).Enabled = " & e.Result.Status.PortRemote(0).Enabled & vbNewLine &
        "PortRemote(0).PortId= " & e.Result.Status.PortRemote(0).PortId & vbNewLine &
        "SetupChanged= " & e.Result.Status.SetupChanged & vbNewLine &
        "WarningOccurred= " & e.Result.Status.WarningOccurred & vbNewLine &
       "CopyFile.Running= " & e.Result.Status.WorkInProgress.CopyFile.Running & vbNewLine &
       "DataTransfer.Running= " & e.Result.Status.WorkInProgress.DataTransfer.Running & vbNewLine &
       "MakeThumbnail.Running= " & e.Result.Status.WorkInProgress.MakeThumbnail.Running & vbNewLine &
      "RebuildRaid.Running= " & e.Result.Status.WorkInProgress.RebuildRaid.Running & vbNewLine &
       "Shutdown.Running= " & e.Result.Status.WorkInProgress.Shutdown.Running & vbNewLine &
       "TranscodeCopy.Running= " & e.Result.Status.WorkInProgress.TranscodeCopy.Running
    End Sub

    Private Sub cmdGetSystemErrorWarning_Click(sender As Object, e As EventArgs) Handles cmdGetSystemErrorWarning.Click
        On Error Resume Next
        Dim bb As New GetSystemErrorWarningRequest
        aa.GetSystemErrorWarningAsync(bb)
    End Sub

    Private Sub aa_GetSystemErrorWarningCompleted(sender As Object, e As GetSystemErrorWarningCompletedEventArgs) Handles aa.GetSystemErrorWarningCompleted
        On Error Resume Next
        lblSystemErrorWarning.Text = ""
        For Each ee As ErrorWarningStatusItem In e.Result.ErrorWarningInfo.ErrorWarningStatus
            lblSystemErrorWarning.Text = lblSystemErrorWarning.Text & vbNewLine & ee.Name.ToString & "  " & ee.Value.ToString()
        Next
    End Sub

    Private Sub cmdAddEssenceMark_Click(sender As Object, e As EventArgs) Handles cmdAddEssenceMark.Click
        On Error Resume Next
        Dim bb As New AddEssenceMarkRequest
        bb.ClipName = dgvclips.CurrentRow.Cells(0).Value
        bb.DriveId = cmbClipDrive.Text
        bb.Offset = 10
        bb.EssenceMark = EssenceMark.WhiteBalanceChange
        aa.AddEssenceMarkAsync(bb)
    End Sub
    Private Sub aa_AddEssenceMarkCompleted(sender As Object, e As AddEssenceMarkCompletedEventArgs) Handles aa.AddEssenceMarkCompleted
        On Error Resume Next
        lblessenceMarkStatus.Text = e.Result.Offset
    End Sub
    Dim mxffilename() As String = {10}
    Dim clipBegin() As String = {10}
    Dim clipEnd() As String = {10}

    Sub playcommandforsmifilefromplaylist(smifilename As String, drivename As String)

        Dim response1 As New XmlDocument
        response1.Load(cmbMappedDriveName.Text & "internal/Edit/" & smifilename)
        Dim ii As Integer = 0

        For Each keyframe As XmlElement In response1.GetElementsByTagName("ref")
            mxffilename(ii) = keyframe.GetAttribute("title")
            clipBegin(ii) = keyframe.GetAttribute("clipBegin")
            clipEnd(ii) = keyframe.GetAttribute("clipEnd")
            ii = ii + 1
        Next
        'MsgBox(mxffilename(0))
        Dim bb As New OpenPlayerRequest
        bb.ClipName = mxffilename(0)
        bb.DriveId = drivename
        bb.Offset = HMSFtoF(Mid(clipBegin(0), 10))
        bb.PlayerId = "Player_1"

        bb.PlayerMode = OpenPlayerMode.Play
        aa.OpenPlayer(bb)

    End Sub
    Sub getmxffilenameandoffset(smifilename As String, drivename As String)
        Dim response1 As New XmlDocument

        response1.Load(cmbMappedDriveName.Text & "internal/Edit/" & smifilename)
        Dim ii As Integer = 0

        For Each keyframe As XmlElement In response1.GetElementsByTagName("ref")
            mxffilename(ii) = keyframe.GetAttribute("title")
            clipBegin(ii) = keyframe.GetAttribute("clipBegin")
            clipEnd(ii) = keyframe.GetAttribute("clipEnd")
            ii = ii + 1
        Next
        'MsgBox(mxffilename(0) & clipBegin(0))
    End Sub
    Private Sub PlayInLoopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayInLoopToolStripMenuItem.Click
        On Error Resume Next
        CueAndPlayinloop(dgv1.CurrentRow.Cells(0).Value, cmbClipDrive.Text)
    End Sub

    Private Sub PlayInLoopToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PlayInLoopToolStripMenuItem1.Click
        On Error Resume Next
        CueAndPlayinloop(dgvclips.CurrentRow.Cells(0).Value, cmbClipDrive.Text)
    End Sub

    Private Sub cmdDurationFromVtrControl_Click(sender As Object, e As EventArgs) Handles cmdDurationFromVtrControl.Click
        txtRecordingDuration.Text = FToHMSF(HMSFtoF(UcVTRController1.txtoutpointvtr.Text) - HMSFtoF(UcVTRController1.txtinpointvtr.Text))
    End Sub

    Private Sub chkTimeLinePlayBackMethod_CheckedChanged(sender As Object, e As EventArgs) Handles chkTimeLinePlayBackMethod.CheckedChanged
        If chkTimeLinePlayBackMethod.Checked Then
            'changeoverframe = 135
            chkPlaySMIasXMF.Enabled = False
        Else
            ' changeoverframe = 15
            chkPlaySMIasXMF.Enabled = True
        End If
    End Sub

    Private Sub chkPlaySMIasXMF_CheckedChanged(sender As Object, e As EventArgs) Handles chkPlaySMIasXMF.CheckedChanged

    End Sub



    Private Sub cmdRecordfrombeta_Click(sender As Object, e As EventArgs) Handles cmdRecordfrombeta.Click
        On Error Resume Next
        UcVTRController1.sp.WriteLine(Chr(CInt("&H20")) & Chr(1) & Chr(33))

        Threading.Thread.Sleep(5000)

        Dim bb As New OpenRecorderRequest
        bb.ClipName = txtRecordFileName.Text & ".MXF" ' .MXF extension is neccessary in Capital letters
        bb.DriveId = cmbRecordDrive.Text
        bb.Frames = HMSFtoF(txtRecordingDuration.Text)
        bb.FramesSpecified = True
        bb.RecorderId = "Recorder_1"
        bb.RecorderMode = OpenRecorderMode.Record
        aa.OpenRecorder(bb)

        tmrRecoderStatus.Enabled = True
    End Sub
    Public Sub savesetting()
        My.Settings.Save()
    End Sub
    Public fps As Double = 25
    Public currrow As Integer = 0
    Public Function byteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Using mStream As New MemoryStream(byteArrayIn)
            Return Image.FromStream(mStream)
        End Using
    End Function
    Public Function FToHMSF(ByVal frame As Integer) As String
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



    Function bytetostring(byteArray() As Byte) As String
        Dim str As String = ""
        Dim str1 As String = ""
        For i = 0 To byteArray.Count - 1
            str1 = (Hex(byteArray(i)))
            If str1.Length < 2 Then str1 = "0" & str1
            str = str & str1
        Next
        Return str
    End Function
    Public Function timecodetohmsf(tc As TimeCode) As String
        Return Format(tc.Time.Hour, "00") & ":" & Format(tc.Time.Minute, "00") & ":" & Format(tc.Time.Second, "00") & ":" & Format(tc.Frame, "00")
    End Function
    Public Function timecodetoframe(tc As TimeCode) As Integer
        Return (tc.Time.Hour) * 60 * 60 * fps + (tc.Time.Minute) * 60 * fps + (tc.Time.Second) * fps + (tc.Frame)
    End Function
    Public Function FToHMS(ByVal frame As Integer) As String
        On Error Resume Next
        Dim ts As TimeSpan
        Dim totHrs As Integer
        Dim H, M, S, HMS As String

        ts = TimeSpan.FromSeconds(frame / fps)

        totHrs = Math.Truncate(ts.TotalHours) 'strip away decimal points
        H = Format(totHrs, "0#") & ":"
        M = Format(ts.Minutes, "0#") & ":"
        S = Format(ts.Seconds, "0#")
        HMS = H & M & S

        Return HMS

    End Function

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class

