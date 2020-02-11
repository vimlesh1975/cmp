Imports System.IO
Public Class ucMetadata
    Private Sub cmdreadmetadata_Click(sender As Object, e As EventArgs) Handles cmdreadmetadata.Click
        On Error Resume Next
        Dim ofdmetadata As New OpenFileDialog
        If ofdmetadata.ShowDialog = Windows.Forms.DialogResult.OK Then
            dgvmetadata.Rows.Clear()
            dgvmetadata.Rows.Add(1)
            Process.Start("CMD", "/K " & "c:/casparcg/mydata/ffmpeg/ffmpeg.exe -y -i " & """" & ofdmetadata.FileName & """" & " -f ffmetadata " & " c:/casparcg/mydata/ffmpeg/readmetadata.txt")
            lblfilenamemetadata.Text = ofdmetadata.FileName
            Threading.Thread.Sleep(5000)
            Dim sr As StreamReader = New StreamReader("c:/casparcg/mydata/ffmpeg/readmetadata.txt")
            Dim g As Integer = dgvmetadata.CurrentRow.Index
            Dim li As String
            Do Until sr.EndOfStream = True
                li = sr.ReadLine()
                dgvmetadata.Rows.Insert(dgvmetadata.CurrentRow.Index, 1)
                Dim xyz As Array = Split(li, "=")
                dgvmetadata.Rows(g).Cells(0).Value = xyz(0)
                dgvmetadata.Rows(g).Cells(1).Value = xyz(1)
                g = g + 1
            Loop
            sr.Close()
        End If
    End Sub

    Private Sub cmdwritemetadata_Click(sender As Object, e As EventArgs) Handles cmdwritemetadata.Click
        On Error Resume Next
        Dim osdmetadata As New SaveFileDialog
        Using sw As StreamWriter = New StreamWriter("c:/casparcg/mydata/ffmpeg/metadataforwrite.txt")
            If dgvmetadata.Rows.Count = 0 Then
                sw.Write("")
            Else
                'Loop through and add list to the file.
                Dim f As Integer = 0
                Do Until f = dgvmetadata.Rows.Count - 2
                    If f = 0 Then
                        sw.WriteLine(dgvmetadata.Rows(f).Cells(0).Value)
                    Else
                        sw.WriteLine(dgvmetadata.Rows(f).Cells(0).Value & "=" & dgvmetadata.Rows(f).Cells(1).Value)
                    End If
                    f = f + 1
                Loop
            End If
            sw.Close()
        End Using

        If osdmetadata.ShowDialog = Windows.Forms.DialogResult.OK Then
            Process.Start("CMD", "/K " & "c:/casparcg/mydata/ffmpeg/ffmpeg.exe -y -i " & """" & lblfilenamemetadata.Text & """" & " -i  " & "c:/casparcg/mydata/ffmpeg/metadataforwrite.txt" & " -map_metadata 1 -c copy -id3v2_version 3 " & """" & osdmetadata.FileName & """")
        End If
    End Sub

    Private Sub cmdclearfieldmetadata_Click(sender As Object, e As EventArgs) Handles cmdclearfieldmetadata.Click
        On Error Resume Next
        dgvmetadata.Rows.Clear()
    End Sub
    Private Sub cmdhidegbmetadata_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
End Class
