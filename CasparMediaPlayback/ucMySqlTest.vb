Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Public Class ucMySqlTest
    Dim conn
    Dim servertype As String
    Private Sub cmdsetserver_Click(sender As Object, e As EventArgs) Handles cmdsetserver.Click
        Try
            conn = New SqlConnection With {
                .ConnectionString = "server=" & txtserver.Text & ";user=" & txtuser.Text & ";database=" & txtdatabase.Text & ";password=" & txtpassword.Text & ";integrated security=" & chkIntegratedSecurity.Checked}
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        servertype = "SQL"
    End Sub
    Private Sub cmdFillTablenames_Click(sender As Object, e As EventArgs) Handles cmdFillTablenames.Click
        Try

            conn.Open()
            Dim dt = conn.GetSchema("TABLES")
            cmbTables.DataSource = dt
            cmbTables.DisplayMember = "table_name"
            cmbTables.ValueMember = "table_name"
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        conn.Close()
    End Sub
    Private Sub cmdShowContents_Click(sender As Object, e As EventArgs) Handles cmdShowContents.Click
        Try
            Dim adp
            If servertype = "MySql" Then
                conn.Open()
                adp = New MySqlDataAdapter("Select * from `" & cmbTables.Text & "`;", CType(conn, MySqlConnection))
            Else
                conn.Open()
                adp = New SqlDataAdapter("Select * from " & """" & cmbTables.Text & """" & ";", CType(conn, SqlConnection))
            End If


            Dim ds As DataSet = New DataSet()
            adp.Fill(ds)
            dgvContents.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        conn.Close()
    End Sub
    Private Sub ucMySqlTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enumeratefontsforall()
    End Sub
    Sub enumeratefontsforall()
        On Error Resume Next
        Dim InstalledFonts As New Drawing.Text.InstalledFontCollection
        Dim fontfamilies() As FontFamily = InstalledFonts.Families()
        For Each fontFamily As FontFamily In fontfamilies
            cmbfontsql.Items.Add(fontFamily.Name)
        Next
    End Sub
    Private Sub cmdhideMySqlTest_Click(sender As Object, e As EventArgs) 
        Me.Hide()
    End Sub
    Sub executequery(aa As String)
        conn.Open()
        Dim sqlc
        If servertype = "MySql" Then
            sqlc = New MySqlCommand
        Else
            sqlc = New SqlCommand
        End If
        Try
            With sqlc
                .Connection = conn
                .CommandText = aa
                '.Parameters.AddWithValue("@curstory", TextBox1.Text)
            End With
            sqlc.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        conn.Close()
    End Sub
    Private Sub cmdInsert_Click(sender As Object, e As EventArgs) Handles cmdInsert.Click
        executequery(txtInsert.Text)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        executequery(txtDelete.Text)
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        executequery(txtUpdate.Text)
    End Sub

    Private Sub cmdAny_Click(sender As Object, e As EventArgs) Handles cmdAny.Click
        executequery(txtAnyCommand.Text)
    End Sub
    Private Sub cmdShowincasparcg_Click(sender As Object, e As EventArgs) Handles cmdShowincasparcg.Click

        Dim cc, rr As Integer

        If chkAllRow.Checked Then
            rr = dgvContents.Rows.Count
        Else
            rr = txtrows.Text
        End If
        If chkAllColumns.Checked Then
            cc = dgvContents.Columns.Count
        Else
            cc = txtcolumns.Text
        End If
        Dim aa As String = "<table style='font-size:" + nFontSizesql.Value.ToString + "px; background-color: " + System.Drawing.ColorTranslator.ToHtml(cmdbgcolorsql.BackColor) & "; color: " & System.Drawing.ColorTranslator.ToHtml(cmdfontcolorsql.ForeColor) & "; font-family: " & cmbfontsql.Text & "' border='2px' align='center' >" & vbNewLine
            For h = 0 To cc - 1
            aa = aa & "<th>" & dgvContents.Columns(h).HeaderText & "</th>"
        Next
        aa = aa & vbNewLine

        For j = 0 To rr - 1
            aa = aa & "<tr>"
            For i = 0 To cc - 1
                aa = aa & "<td>" & dgvContents.Rows(j).Cells(i).Value & "</td>"
            Next
            aa = aa & "</tr>" & vbNewLine

        Next
        aa = aa & "</table>"

        CreatePage("html1", aa, "C:\casparcg\mydata\MySqlToCasparcg\html1.html")

        CasparDevice.SendString("play " & g_int_ChannelNumber & "-" & cmblayerSqlhtml.Text & " [HTML] file:///C:/casparcg/mydata/MySqlToCasparcg/html1.html")

    End Sub
    Public Sub CreatePage(ByVal HTMLTitle As String, ByVal HTMLText As String, ByVal HTMLFileName As String)
        Dim strFile As String
        strFile = "<!DOCTYPE html>" & vbNewLine
        strFile = "<html>" & vbNewLine
        strFile = strFile & "<head>" & vbNewLine
        strFile = strFile & "<meta http-equiv='Content-Type' content='text/html; charset=utf-8'/>"
        strFile = strFile & "</head>" & vbNewLine & "<body>" & vbNewLine
        strFile = strFile & "<div style ='transform: translate(0px, 300px)'>" & vbNewLine
        strFile = strFile & HTMLText & vbNewLine
        strFile = strFile & "</div>" & vbNewLine
        strFile = strFile & "</body>" & vbNewLine & "</html>"

        Dim aa As IO.StreamWriter = New IO.StreamWriter(HTMLFileName)

        aa.Write(strFile)
        aa.Close()
    End Sub

    Private Sub cmdStopSqlLayer_Click(sender As Object, e As EventArgs) Handles cmdStopSqlLayer.Click
        On Error Resume Next
        CasparDevice.SendString("stop " & g_int_ChannelNumber & "-" & cmblayerSqlhtml.Text)

    End Sub
    Private Sub cmdbgcolorsql_Click(sender As Object, e As EventArgs) Handles cmdbgcolorsql.Click
        Dim aa As New ColorDialog
        If (aa.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdfontcolorsql.BackColor = aa.Color
            cmdbgcolorsql.BackColor = aa.Color
        End If
    End Sub

    Private Sub cmdfontcolorsql_Click(sender As Object, e As EventArgs) Handles cmdfontcolorsql.Click
        Dim aa As New ColorDialog
        If (aa.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdfontcolorsql.ForeColor = aa.Color
            cmdbgcolorsql.ForeColor = aa.Color
        End If
    End Sub

    Private Sub cmdSetServerMySql_Click(sender As Object, e As EventArgs) Handles cmdSetServerMySql.Click
        Try
            conn = New MySqlConnection With {
                           .ConnectionString = "server=" & txtservermysql.Text & ";user=" & txtusemysql.Text & ";database=" & txtdatabasemysql.Text & ";port=" & txtport.Text & ";password=" & txtpasswordMysql.Text
                     }
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        servertype = "MySql"
    End Sub
End Class
