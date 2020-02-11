Imports System.Xml
Public Class ucChannelInfo
    Private Sub cmdgetchannelinfo_Click(sender As Object, e As EventArgs) Handles cmdgetchannelinfo.Click
        getchannelinfo()
    End Sub
    Sub getchannelinfo()
        If ServerVersion = 2.0 Then
            getchannelinfo27()
        ElseIf ServerVersion = 2.1 Then
            getchannelinfo21()
        ElseIf ServerVersion = 2.2 Or 2.3 Then
            getchannelinfo23()
        End If
    End Sub
    Sub getchannelinfo27()
        On Error Resume Next
        dgvchannelinfo.Rows.Clear()
        Dim str As String
        str = "info " & g_int_ChannelNumber
        SendString(NetStream, str + vbCrLf)
        Threading.Thread.Sleep(100)
        Dim data(10024) As Byte
        NetStream.Read(data, 0, 10024)
        Dim xmlString As String = System.Text.Encoding.UTF8.GetString(data)

        xmlString = xmlString.Substring(xmlString.IndexOf("<"))

        Dim m_xmld As XmlDocument
        Dim m_nodelist As XmlNodeList
        Dim m_node As XmlNode
        'Create the XML Document
        m_xmld = New XmlDocument()
        'Load the Xml string
        m_xmld.LoadXml(xmlString)
        'Get the list of name nodes 
        m_nodelist = m_xmld.SelectNodes("/channel/stage/layers/layer/foreground/producer")
        Dim ichannelinfo As Integer = 0
        For Each m_node In m_nodelist
            dgvchannelinfo.Rows.Add()
            If m_node.ChildNodes.Item(0).InnerText.Contains("-producer") Then
                dgvchannelinfo.Rows(ichannelinfo).Cells(1).Value = m_node.ChildNodes.Item(0).InnerText
            Else
                dgvchannelinfo.Rows(ichannelinfo).Cells(1).Value = m_node.ChildNodes.Item(0).InnerText & "-producer"
            End If

            dgvchannelinfo.Rows(ichannelinfo).Cells(2).Value = m_node.ChildNodes.Item(1).InnerText
            ichannelinfo = ichannelinfo + 1
        Next
        m_nodelist = m_xmld.SelectNodes("/channel/output/consumers/consumer")
        For Each m_node In m_nodelist
            dgvchannelinfo.Rows.Add()
            If m_node.ChildNodes.Item(0).InnerText.Contains("-consumer") Then
                dgvchannelinfo.Rows(ichannelinfo).Cells(1).Value = m_node.ChildNodes.Item(0).InnerText
            Else
                dgvchannelinfo.Rows(ichannelinfo).Cells(1).Value = m_node.ChildNodes.Item(0).InnerText & "-consumer"
            End If

            If m_node.ChildNodes.Item(0).InnerText.Contains("-consumer") Then
                dgvchannelinfo.Rows(ichannelinfo).Cells(2).Value = m_node.Item("device").InnerText
            Else
                dgvchannelinfo.Rows(ichannelinfo).Cells(2).Value = m_node.Item("filename").InnerText
            End If
            ichannelinfo = ichannelinfo + 1
        Next

        m_nodelist = m_xmld.SelectNodes("/channel/stage/layers/layer/index")
        ichannelinfo = 0
        For Each m_node In m_nodelist
            dgvchannelinfo.Rows(ichannelinfo).Cells(0).Value = m_node.InnerText
            ichannelinfo = ichannelinfo + 1
        Next
        m_nodelist = m_xmld.SelectNodes("/channel/output/consumers/consumer/index")

        For Each m_node In m_nodelist
            dgvchannelinfo.Rows(ichannelinfo).Cells(0).Value = m_node.InnerText
            ichannelinfo = ichannelinfo + 1
        Next
    End Sub

    Sub getchannelinfo21()
        On Error Resume Next
        With dgvchannelinfo
            .Rows.Clear()
            Dim str As String
            str = "info " & g_int_ChannelNumber
            SendString(NetStream, str + vbCrLf)

            Threading.Thread.Sleep(100)

            Dim data(10024) As Byte
            NetStream.Read(data, 0, 10024)
            Dim xmlString As String = System.Text.Encoding.UTF8.GetString(data)

            xmlString = xmlString.Substring(xmlString.IndexOf("<"))
            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode
            'Create the XML Document
            m_xmld = New XmlDocument()
            'Load the Xml string
            m_xmld.LoadXml(xmlString)
            'Get the list of name nodes 
            m_nodelist = m_xmld.SelectNodes("/channel/stage/layers/layer/foreground/producer")
            Dim ichannelinfo As Integer = 0
            For Each m_node In m_nodelist
                .Rows.Add()
                If m_node.ChildNodes.Item(0).InnerText.Contains("-producer") Then
                    .Rows(ichannelinfo).Cells(1).Value = m_node.ChildNodes.Item(0).InnerText
                Else
                    .Rows(ichannelinfo).Cells(1).Value = m_node.ChildNodes.Item(0).InnerText & "-producer"
                End If
                .Rows(ichannelinfo).Cells(2).Value = m_node.ChildNodes.Item(1).InnerText
                ichannelinfo = ichannelinfo + 1
            Next
            m_nodelist = m_xmld.SelectNodes("/channel/output/consumers/consumer")
            For Each m_node In m_nodelist
                .Rows.Add()
                If m_node.ChildNodes.Item(0).InnerText.Contains("-consumer") Then
                    .Rows(ichannelinfo).Cells(1).Value = m_node.ChildNodes.Item(0).InnerText
                Else
                    .Rows(ichannelinfo).Cells(1).Value = m_node.ChildNodes.Item(0).InnerText & "-consumer"
                End If
                If m_node.ChildNodes.Item(0).InnerText.Contains("decklink") Then
                    .Rows(ichannelinfo).Cells(2).Value = m_node.Item("device").InnerText
                Else
                    .Rows(ichannelinfo).Cells(2).Value = m_node.Item("path").InnerText
                End If

                ichannelinfo = ichannelinfo + 1
            Next
            m_nodelist = m_xmld.SelectNodes("/channel/stage/layers/layer/index")
            ichannelinfo = 0
            For Each m_node In m_nodelist
                .Rows(ichannelinfo).Cells(0).Value = m_node.InnerText
                ichannelinfo = ichannelinfo + 1
            Next
            m_nodelist = m_xmld.SelectNodes("/channel/output/consumers/consumer/index")
            For Each m_node In m_nodelist
                .Rows(ichannelinfo).Cells(0).Value = m_node.InnerText
                ichannelinfo = ichannelinfo + 1
            Next
        End With
    End Sub
    Private Sub getchannelinfo23()
        On Error Resume Next
        With dgvchannelinfo
            .Rows.Clear()
            Dim str As String
            str = "info " & g_int_ChannelNumber
            SendString(NetStream, str + vbCrLf)

            Threading.Thread.Sleep(100)

            Dim data(10024) As Byte
            NetStream.Read(data, 0, 10024)
            Dim xmlString As String = System.Text.Encoding.UTF8.GetString(data)

            xmlString = xmlString.Substring(xmlString.IndexOf("<"))
            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode
            'Create the XML Document
            m_xmld = New XmlDocument()
            'Load the Xml string
            m_xmld.LoadXml(xmlString)
            'Get the list of name nodes 
            m_nodelist = m_xmld.SelectNodes("/channel/stage/layer/*/foreground")
            Dim ichannelinfo As Integer = 0
            For Each m_node In m_nodelist
                .Rows.Add()
                If m_node.Item("producer").InnerText.Contains("-producer") Then
                    .Rows(ichannelinfo).Cells(1).Value = m_node.Item("producer").InnerText
                Else
                    .Rows(ichannelinfo).Cells(1).Value = m_node.Item("producer").InnerText & "-producer"
                End If


                .Rows(ichannelinfo).Cells(2).Value = m_node.Item("file").Item("path").InnerText
                ichannelinfo = ichannelinfo + 1
            Next
            m_nodelist = m_xmld.SelectNodes("/channel/output/port/*")
            For Each m_node In m_nodelist
                .Rows.Add()
                If m_node.Item("file").Item("path").InnerText.Contains("://") Then
                    .Rows(ichannelinfo).Cells(1).Value = "streaming-consumer"
                Else
                    If m_node.ChildNodes(0).Name.Contains("-consumer") Then
                        .Rows(ichannelinfo).Cells(1).Value = m_node.ChildNodes(0).Name
                    Else
                        .Rows(ichannelinfo).Cells(1).Value = m_node.ChildNodes(0).Name & "-consumer"
                    End If

                End If
                If m_node.ChildNodes(0).Name.Contains("decklink") Then
                    .Rows(ichannelinfo).Cells(2).Value = m_node.Item("file").Item("path").InnerText
                Else
                    .Rows(ichannelinfo).Cells(2).Value = m_node.Item("file").Item("path").InnerText
                End If

                ichannelinfo = ichannelinfo + 1
            Next
            m_nodelist = m_xmld.SelectNodes("/channel/stage/layer/*")
            ichannelinfo = 0
            For Each m_node In m_nodelist
                .Rows(ichannelinfo).Cells(0).Value = Split(m_node.Name, "_")(1)
                ichannelinfo = ichannelinfo + 1
            Next
            m_nodelist = m_xmld.SelectNodes("/channel/output/port/*")
            For Each m_node In m_nodelist
                .Rows(ichannelinfo).Cells(0).Value = Split(m_node.Name, "_")(1)
                ichannelinfo = ichannelinfo + 1
            Next
        End With
    End Sub

    Private Sub cmdhidegbchannelinfo_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub ucChannelInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub dgvchannelinfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvchannelinfo.CellContentClick
        On Error Resume Next
        If e.ColumnIndex = 3 Then
            With dgvchannelinfo
                If (Split(.CurrentRow.Cells(1).Value, "-")).Count > 1 Then
                    If Split(.CurrentRow.Cells(1).Value, "-")(1) = "producer" Then
                        CasparDevice.SendString("stop " & g_int_ChannelNumber & "-" & .CurrentRow.Cells(0).Value)
                    Else 'consumer
                        CasparDevice.SendString("remove " & g_int_ChannelNumber & "-" & .CurrentRow.Cells(0).Value)
                    End If
                Else ' streaming consumer
                    CasparDevice.SendString("remove " & g_int_ChannelNumber & "-" & .CurrentRow.Cells(0).Value)
                End If
            End With
            getchannelinfo()
        End If
    End Sub
End Class
