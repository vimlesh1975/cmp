'for rss
Imports System.Data.DataSet
Imports System.Web
Imports System.Data
'for rss ends
Public Class ucRssFeed
    Dim ibreakingnews As Integer
    Dim jbreakingnews As Integer
    Dim kbreakingnews As Integer

    Dim ar1() As String
    Dim ar2() As String
    Dim ar3() As String
    Dim ar4() As String
    Dim ar5() As String
    Dim ar6() As String
    Private Sub cmdhidegbrssfeed_Click(sender As Object, e As EventArgs) 
        Me.Hide()
    End Sub
    Private Sub cmdrssmanuallyadd_Click(sender As Object, e As EventArgs) Handles cmdrssmanuallyadd.Click
        On Error Resume Next
        dgvrss.Rows.Clear()
        dgvrss.Columns.Clear()

        If dgvrss.Columns.Count < 2 Then
            dgvrss.Columns.Add("title", "title")
            dgvrss.Columns.Add("description", "description")
            Dim chkBox As New DataGridViewCheckBoxColumn(False)

            dgvrss.Columns.Insert(0, chkBox)

            For jrss = 0 To dgvrss.RowCount - 1
                dgvrss.Rows(jrss).Cells(0).Value = vbTrue
            Next
            dgvrss.Columns(0).Width = 40
            dgvrss.Columns(1).Width = 500

            dgvrss.Rows.Add(1)
        End If

    End Sub

    Private Sub cmdrssread_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrssread.Click
        On Error Resume Next
        readrssdata()
    End Sub
    Sub readrssdata()
        On Error Resume Next
        Dim objDataset As DataSet = New DataSet
        dgvrss.Rows.Clear()
        dgvrss.Columns.Clear()

        If Me.txtrssaddress.Text.Trim <> vbNullString Then
            objDataset.ReadXml(Me.txtrssaddress.Text.Trim, System.Data.XmlReadMode.Auto)
            Dim aa As Integer = nrsstable.Value
            dgvrss.DataSource = objDataset.Tables(aa)
        End If
        objDataset.Dispose()
        Dim chkBox As New DataGridViewCheckBoxColumn(False)

        dgvrss.Columns.Insert(0, chkBox)

        For jrss = 0 To dgvrss.RowCount - 1
            dgvrss.Rows(jrss).Cells(0).Value = vbTrue
        Next
        dgvrss.Columns(0).Width = 25
        dgvrss.Columns(1).Width = 500
    End Sub

    Private Sub cmdselectallrssfeed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdselectallrssfeed.Click
        On Error Resume Next
        For irss = 0 To dgvrss.Rows.Count - 1
            dgvrss.Rows(irss).Cells(0).Value = vbTrue
        Next
    End Sub

    Private Sub cmddeselectallrssfedd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddeselectallrssfedd.Click
        On Error Resume Next
        For irss = 0 To dgvrss.Rows.Count - 1
            dgvrss.Rows(irss).Cells(0).Value = vbFalse
        Next
    End Sub
    Private Sub cmdrssplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrssplay.Click
        On Error Resume Next
        setdataofrss()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmbrssvideoflashlayer.Text), Int(cmbrssvideoflashlayer.Text), txtRSSTemplate.Text, True, CasparCGDataCollection.ToAMCPEscapedXml)
        tmrshowdatarss.Interval = txtrsstimerinterval.Text
        tmrshowdatarss.Enabled = True
    End Sub
    Private Sub dgvrss_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvrss.DataError
        ' dummy code 
    End Sub
    Sub setdataofrss()


        Dim str As String = ""

        If chkrsstitle.Checked = True And chkrssdescription.Checked = False Then
            For jrss = 0 To dgvrss.RowCount - 1
                If dgvrss.Rows(jrss).Cells(0).Value = vbTrue Then
                    str = str + Replace(dgvrss.Rows(jrss).Cells("title").Value, vbLf, vbNullString) + txtrssdelemeter.Text
                End If
            Next
        End If
        If chkrsstitle.Checked = False And chkrssdescription.Checked = True Then
            For jrss = 0 To dgvrss.RowCount - 1
                If dgvrss.Rows(jrss).Cells(0).Value = vbTrue Then
                    str = str + Replace(dgvrss.Rows(jrss).Cells("description").Value, vbLf, vbNullString) + txtrssdelemeter.Text
                End If
            Next
        End If
        If chkrsstitle.Checked = True And chkrssdescription.Checked = True Then
            For jrss = 0 To dgvrss.RowCount - 1
                If dgvrss.Rows(jrss).Cells(0).Value = vbTrue Then
                    str = str + Replace(dgvrss.Rows(jrss).Cells("title").Value, vbLf, vbNullString) + txtrssdelemeter.Text + Replace(dgvrss.Rows(jrss).Cells("description").Value, vbLf, vbNullString) + txtrssdelemeter.Text
                End If
            Next
        End If
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("speed", nrssspeed.Value)
        CasparCGDataCollection.SetData("scrolldata", str)
    End Sub

   

    Sub updatedatarss()
        On Error Resume Next
        setdataofrss()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmbrssvideoflashlayer.Text), Int(cmbrssvideoflashlayer.Text), CasparCGDataCollection)

    End Sub
    Private Sub cmdrsspause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrsspause.Click
        On Error Resume Next
        nrssspeed.Value = 0
    End Sub

    Private Sub cmdrssresume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrssresume.Click
        On Error Resume Next
        nrssspeed.Value = 3
    End Sub

    Private Sub cmdrssstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrssstop.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmbrssvideoflashlayer.Text), Int(cmbrssvideoflashlayer.Text))
        tmrshowdatarss.Enabled = False
    End Sub

    Private Sub nrssspeed_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nrssspeed.ValueChanged
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("speed", nrssspeed.Value)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmbrssvideoflashlayer.Text), Int(cmbrssvideoflashlayer.Text), CasparCGDataCollection)
    End Sub

   
    Private Sub tmrshowdatarss_Tick(sender As Object, e As EventArgs) Handles tmrshowdatarss.Tick
       On Error Resume Next
        If chkautomaticupdaterss.Checked Then updatedatarss()
        If chkautomaticreadrss.Checked Then readrssdata()
    End Sub

    Private Sub cmdplaybreakingnews_Click(sender As Object, e As EventArgs) Handles cmdplaybreakingnews.Click
        On Error Resume Next
        makearray()
        setdataofbreakingnews()
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmbrssvideoflashlayer.Text), Int(cmbrssvideoflashlayer.Text), txtbnTemplate.Text, True, CasparCGDataCollection.ToAMCPEscapedXml)
        tmrshowdata.Interval = Val(txtbreakingnewsupdateinterval.Text)
        tmrshowdata.Enabled = True
    End Sub
    Sub makearray()
        On Error Resume Next
        ibreakingnews = 0
        jbreakingnews = 0
        kbreakingnews = 0
        Dim ar1(dgvrss.Rows.Count - 1) As String
        Dim ar3(dgvrss.Rows.Count - 1) As String
        Dim ar5(dgvrss.Rows.Count - 1) As String

        For Me.ibreakingnews = 0 To dgvrss.Rows.Count - 1
            If dgvrss.Rows(ibreakingnews).Cells(0).Value = True Then

                ar1(jbreakingnews) = dgvrss.Rows(ibreakingnews).Cells(1).Value
                ar3(jbreakingnews) = dgvrss.Rows(ibreakingnews).Cells(2).Value
                ar5(jbreakingnews) = dgvrss.Rows(ibreakingnews).Cells(3).Value

                jbreakingnews = jbreakingnews + 1
            End If
        Next
        ar2 = ar1
        ar4 = ar3
        ar6 = ar5
    End Sub

    Sub setdataofbreakingnews()
        On Error Resume Next
        CasparCGDataCollection.Clear()
        CasparCGDataCollection.SetData("xf0", (ar4(kbreakingnews)))
        CasparCGDataCollection.SetData("xf1", (ar6(kbreakingnews)))
        CasparCGDataCollection.SetData("xf2", (ar2(kbreakingnews)))
    End Sub
    Private Sub gbrss_Enter(sender As Object, e As EventArgs) Handles gbrss.Enter

    End Sub

    Private Sub tmrshowdata_Tick(sender As Object, e As EventArgs) Handles tmrshowdata.Tick
        On Error Resume Next
        If chkautomaticupdaterss.Checked Then updatedatarss()
        If chkautomaticreadrss.Checked Then readrssdata()

        kbreakingnews = kbreakingnews + 1
        If ar2(kbreakingnews) = "" Then
            makearray()
        End If
        updatedata()
    End Sub
    Sub updatedata()
        On Error Resume Next
        setdataofbreakingnews()
        'CasparDevice.Channels(cmbchannel.Text-1).CG.Invoke(Int(cmblayerbreakingnews.Text), Int(cmblayerbreakingnews.Text), "loop")
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Update(Int(cmbrssvideoflashlayer.Text), Int(cmbrssvideoflashlayer.Text), CasparCGDataCollection)
    End Sub

    Private Sub cmdstopbrekingnews_Click(sender As Object, e As EventArgs) Handles cmdstopbrekingnews.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Invoke(Int(cmbrssvideoflashlayer.Text), Int(cmbrssvideoflashlayer.Text), "out")
        Threading.Thread.Sleep(500)
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmbrssvideoflashlayer.Text), Int(cmbrssvideoflashlayer.Text))
        tmrshowdata.Enabled = False
    End Sub

    Private Sub cmdshowtime_Click(sender As Object, e As EventArgs) Handles cmdshowtime.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Add(Int(cmblayertimerss.Text), Int(cmblayertimerss.Text), ("CMP/time/time"), True, CasparCGDataCollection.ToAMCPEscapedXml)

    End Sub

    Private Sub cmdhidetime_Click(sender As Object, e As EventArgs) Handles cmdhidetime.Click
        On Error Resume Next
        CasparDevice.Channels(g_int_ChannelNumber - 1).CG.Stop(Int(cmblayertimerss.Text), Int(cmblayertimerss.Text))

    End Sub

    Private Sub chkautomaticreadrss_CheckedChanged(sender As Object, e As EventArgs) Handles chkautomaticreadrss.CheckedChanged

    End Sub

    Private Sub chkautomaticupdaterss_CheckedChanged(sender As Object, e As EventArgs) Handles chkautomaticupdaterss.CheckedChanged

    End Sub
End Class
