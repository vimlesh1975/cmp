Imports System.IO
Imports System.ComponentModel

Public Class ucnewTrimmer1
    Public ofdtrimmer As New OpenFileDialog
    Public osdcutfilename As New SaveFileDialog
    Dim intCut As Integer = 1
    Dim iclipsavetrimer As Integer = 1

    Dim isplaying As Boolean = False
    Private Sub cmdgototcvlc_Click(sender As Object, e As EventArgs) Handles cmdgototcvlc.Click
        On Error Resume Next
        vlc1.VlcMediaPlayer.Time = HMSFtoF(txtgototcvlc.Text) * 1000 / (fps)
        'vlc1.VlcMediaPlayer.Pause()

    End Sub

    Private Sub cmdplaylast5sectrimmer_Click(sender As Object, e As EventArgs) Handles cmdplaylast5sectrimmer.Click
        If System.IO.Path.GetExtension(lblfilenametrimmer.Text) = ".txt" Then
            vlc1.VlcMediaPlayer.Time = (txtmarkouttrimmer.Text - fps * 5) * 1000 / (fps)
            vlc1.VlcMediaPlayer.Play()
            Threading.Thread.Sleep(5000)
            vlc1.VlcMediaPlayer.Time = (txtmarkouttrimmer.Text) * 1000 / (fps)
        Else
            vlc1.VlcMediaPlayer.Time = (lblmaxtrimmer.Text - fps * 5) * 1000 / (fps)
            vlc1.VlcMediaPlayer.Play()
        End If
        'vlc1.VlcMediaPlayer.Pause()
    End Sub

    Private Sub cmdmarkintrimmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmarkintrimmer.Click
        On Error Resume Next
        txtmarkintrimmer.Text = lblcurrentframetrimmer.Text 'TrackBarseek.Value
        lbltrimmedduration.Text = FToHMSF(txtmarkouttrimmer.Text - txtmarkintrimmer.Text)

    End Sub

    Private Sub cmdgotointrimmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgotointrimmer.Click
        On Error Resume Next
        vlc1.VlcMediaPlayer.Time = (txtmarkintrimmer.Text) * 1000 / (fps)
        'vlc1.VlcMediaPlayer.Pause()
    End Sub

    Private Sub cmdcuecliptrimmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcuecliptrimmer.Click

        On Error Resume Next
        vlc1.VlcMediaPlayer.Time = 2
    End Sub

    Private Sub cmdbackoneframetrimmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbackoneframetrimmer.Click

        On Error Resume Next
        vlc1.VlcMediaPlayer.Time = vlc1.VlcMediaPlayer.Time - (1000 / fps)
    End Sub
    Private Sub cmdPlaySingleCliptrimmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlaySingleCliptrimmer.Click
        On Error Resume Next
        vlc1.VlcMediaPlayer.Play()
        tmrtrimmer.Enabled = True
    End Sub
    Private Sub cmdforwardoneframetrimmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdforwardoneframetrimmer.Click

        On Error Resume Next
        vlc1.VlcMediaPlayer.Time = vlc1.VlcMediaPlayer.Time + (1000 / fps)
    End Sub

    Private Sub cmdresumetrimmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresumetrimmer.Click

        On Error Resume Next
        vlc1.VlcMediaPlayer.Pause()
    End Sub

    Private Sub cmdstoptrimmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdstoptrimmer.Click

        On Error Resume Next
        vlc1.VlcMediaPlayer.Stop()
        tmrtrimmer.Enabled = False
    End Sub

    Private Sub TrackBarseektrimmer_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarseektrimmer.Scroll

        On Error Resume Next
        vlc1.VlcMediaPlayer.Time = TrackBarseektrimmer.Value * (1000 / fps)
    End Sub
    Private Sub nvlcspeed_ValueChanged(sender As Object, e As EventArgs) Handles nvlcspeed.ValueChanged
        On Error Resume Next
        vlcsped()
    End Sub
    Sub vlcsped()
        On Error Resume Next
        vlc1.VlcMediaPlayer.Rate = nvlcspeed.Value

    End Sub
    Dim masterfilenametrimmer As String
    Dim intrimmer As Integer
    Dim outtrimmer As Integer
    Sub readsubcliptrimmer(textfilename As String)
        On Error Resume Next
        Using sr As StreamReader = New StreamReader(textfilename)
            Dim str As Array = Split(sr.ReadLine, Chr(2))
            masterfilenametrimmer = str(0)
            intrimmer = str(1)
            outtrimmer = str(2)
        End Using
    End Sub
    Private Sub cmdopenfiletrimmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdopenfiletrimmer.Click
        On Error Resume Next
        ofdtrimmer.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"
        ofdtrimmer.DereferenceLinks = False
        If ofdtrimmer.ShowDialog = DialogResult.OK Then
            openfileintrimmer(ofdtrimmer.FileName)
            iclipsavetrimer = 1
        End If

    End Sub
    Sub openfileintrimmer(trimmerfilename As String)
        On Error Resume Next

        If vlc1.VlcMediaPlayer.IsPlaying = True Then vlc1.VlcMediaPlayer.Stop()
        intCut = 1

        If System.IO.Path.GetExtension(trimmerfilename) = ".txt" Then
            readsubcliptrimmer(trimmerfilename)
            'vlc1.playlist.add("file:///" & Replace(mediafullpath & masterfilenametrimmer, "/", "\"))
            vlc1.VlcMediaPlayer.SetMedia(New Uri(Replace(mediafullpath & masterfilenametrimmer, "/", "\")))
            ofdtrimmer.FileName = Replace(mediafullpath & masterfilenametrimmer, "/", "\")
        Else
            'vlc1.playlist.add("file:///" & trimmerfilename)
            vlc1.VlcMediaPlayer.SetMedia(New Uri(trimmerfilename))
            ofdtrimmer.FileName = trimmerfilename
        End If


        lblfilenametrimmer.Text = trimmerfilename

        vlc1.VlcMediaPlayer.Play()
        isplaying = True

        Threading.Thread.Sleep(1000)
        'fps = VLC1.input.fps
        tmrtrimmer.Enabled = True

        TrackBarseektrimmer.Maximum = (vlc1.VlcMediaPlayer.Length / 1000) * fps

        lblmintrimmer.Text = TrackBarseektrimmer.Minimum
        lblmaxtrimmer.Text = TrackBarseektrimmer.Maximum

        If System.IO.Path.GetExtension(trimmerfilename) = ".txt" Then
            txtmarkintrimmer.Text = intrimmer
            txtmarkouttrimmer.Text = outtrimmer
            lbloriginalduration.Text = FToHMSF(outtrimmer - intrimmer)
            lbltrimmedduration.Text = FToHMSF(outtrimmer - intrimmer)
        Else
            txtmarkintrimmer.Text = 0
            txtmarkouttrimmer.Text = TrackBarseektrimmer.Maximum
            lbloriginalduration.Text = FToHMSF(TrackBarseektrimmer.Maximum)
            lbltrimmedduration.Text = FToHMSF(TrackBarseektrimmer.Maximum)
        End If

        vlcplaylistpauseandgoto1stframe()
    End Sub
    Sub vlcplaylistpauseandgoto1stframe()
        On Error Resume Next

        Threading.Thread.Sleep(100)
        vlc1.VlcMediaPlayer.Pause()
        vlc1.VlcMediaPlayer.Time = 2
    End Sub

  
    Private Sub cmdclipsavetrimmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclipsavetrimmer.Click
        On Error Resume Next
        Dim osdtrimmer As New SaveFileDialog
        osdtrimmer.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"

        osdtrimmer.FileName = System.IO.Path.GetFileNameWithoutExtension(ofdtrimmer.FileName) & "_Cut" & iclipsavetrimer
        osdtrimmer.DereferenceLinks = False
        osdtrimmer.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If System.IO.Path.GetExtension(ofdtrimmer.FileName) = ".txt" Then
            readsubcliptrimmer(ofdtrimmer.FileName)
            If (osdtrimmer.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                Using sw As StreamWriter = New StreamWriter(osdtrimmer.FileName)
                    sw.WriteLine(masterfilenametrimmer & Chr(2) & txtmarkintrimmer.Text & Chr(2) & txtmarkouttrimmer.Text)
                    sw.Close()
                End Using
            End If
        Else

            If (osdtrimmer.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                Using sw As StreamWriter = New StreamWriter(osdtrimmer.FileName)
                    sw.WriteLine(Replace(Mid(ofdtrimmer.FileName, Len(mediafullpath) + 1), "\", "/") & Chr(2) & txtmarkintrimmer.Text & Chr(2) & txtmarkouttrimmer.Text)
                    sw.Close()
                End Using
                iclipsavetrimer = iclipsavetrimer + 1
            End If
        End If
    End Sub

    Private Sub cmdspeed1trimmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdspeed1trimmer.Click
        On Error Resume Next
        nvlcspeed.Value = 1

    End Sub

    Private Sub cmdmarkouttrimmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmarkouttrimmer.Click
        On Error Resume Next
        txtmarkouttrimmer.Text = lblcurrentframetrimmer.Text 'TrackBarseek.Value
        lbltrimmedduration.Text = FToHMSF(txtmarkouttrimmer.Text - txtmarkintrimmer.Text)
    End Sub

    Private Sub cmdgotoouttrimmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgotoouttrimmer.Click
        On Error Resume Next
        vlc1.VlcMediaPlayer.Time = (txtmarkouttrimmer.Text) * 1000 / (fps)
        'vlc1.VlcMediaPlayer.Pause()
    End Sub

    Private Sub cmdtrimmerfileinfo_Click(sender As Object, e As EventArgs) Handles cmdtrimmerfileinfo.Click
        On Error Resume Next
        showfileinformation(ofdtrimmer.FileName)
    End Sub

    Private Sub cmdtrimmerfileinfoencoded_Click(sender As Object, e As EventArgs) Handles cmdtrimmerfileinfoencoded.Click
        On Error Resume Next
        showfileinformation(osdcutfilename.FileName)
    End Sub

    Private Sub cmdtrimmerfilePlayencoded_Click(sender As Object, e As EventArgs) Handles cmdtrimmerfilePlayencoded.Click
        On Error Resume Next
        playinvlc(osdcutfilename.FileName)
    End Sub
    Private Sub cmdexportclipwithoutanychanges_Click(sender As Object, e As EventArgs) Handles cmdexportclipwithoutanychanges.Click

        On Error Resume Next
        osdcutfilename.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"
        osdcutfilename.FileName = System.IO.Path.GetFileNameWithoutExtension(ofdtrimmer.FileName) & "_Trimmed"
        osdcutfilename.FilterIndex = 1
        osdcutfilename.DereferenceLinks = False
        osdcutfilename.Filter = "original wrapper (*" & System.IO.Path.GetExtension(ofdtrimmer.FileName) & ")|*" & System.IO.Path.GetExtension(ofdtrimmer.FileName) & "|mp4 files (*.mp4)|*.mp4|avi files (*.avi)|*.avi|All files (*.*)|*.*"
        If (osdcutfilename.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdexportclipwithoutanychanges.Enabled = False
            bwforexportclip.RunWorkerAsync()
        End If

    End Sub
    Sub exportclipwithoutanychanges()

        Control.CheckForIllegalCrossThreadCalls = False
        Dim proc As New Process
        Dim startinfo As New System.Diagnostics.ProcessStartInfo
        Dim sr As StreamReader
        Dim strinout = " -ss " & FToHMSms(txtmarkintrimmer.Text) & " -t " & FToHMSms(txtmarkouttrimmer.Text - txtmarkintrimmer.Text)
        startinfo.FileName = "c:/casparcg/mydata/ffmpeg/ffmpeg.exe"

        Dim cmd As String
        If (System.IO.Path.GetExtension(osdcutfilename.FileName).ToUpper = ".MXF") And (System.IO.Path.GetExtension(ofdtrimmer.FileName).ToUpper = ".MXF") Then
            Process.Start("CMD", "/K " & "c:/casparcg/mydata/bmx-win32-exe-snapshot-20170814/bmxtranswrap.exe -p -o " & """" & osdcutfilename.FileName & """" & " --start " & Val(txtmarkintrimmer.Text) & " --dur " & Val(txtmarkouttrimmer.Text - txtmarkintrimmer.Text) & " " & """" & ofdtrimmer.FileName & """")
            'cmd = "-y " & strinout & " -i " & """" & ofdtrimmer.FileName & """" & " -c copy " & """" & osdcutfilename.FileName & """"
            Exit Sub
        Else
            cmd = "-y " & strinout & " -i " & """" & ofdtrimmer.FileName & """" & " -c copy  -map 0:0? -map 0:1? -map 0:2? -map 0:3? -map 0:4? -map 0:5? -map 0:6? -map 0:7? -map 0:8? " & """" & osdcutfilename.FileName & """"
        End If

        Dim ffmpegOutput As String
        startinfo.Arguments = cmd
        startinfo.UseShellExecute = False
        startinfo.WindowStyle = ProcessWindowStyle.Hidden
        startinfo.RedirectStandardError = True
        startinfo.RedirectStandardOutput = True
        startinfo.CreateNoWindow = True
        proc.StartInfo = startinfo
        proc.Start() ' start the process
        sr = proc.StandardError 'standard error is used by ffmpeg

        pbexportclip.Maximum = txtmarkouttrimmer.Text - txtmarkintrimmer.Text
        lblexportclipinfo.Text = ""
        Do
            ffmpegOutput = sr.ReadLine
            pbexportclip.Value = Val(Mid(Split(ffmpegOutput, "fps")(0), 7))
            lblexportclipinfo.Text = pbexportclip.Value & " Frames"
        Loop Until proc.HasExited And ffmpegOutput = Nothing Or ffmpegOutput = ""

    End Sub
    Private Sub cmdgotoendtrimmer_Click(sender As Object, e As EventArgs) Handles cmdgotoendtrimmer.Click
        On Error Resume Next
        vlc1.VlcMediaPlayer.Time = (Val(lblmaxtrimmer.Text) - 2) * 1000 / (fps)
    End Sub

    Private Sub tmrtrimmer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrtrimmer.Tick
        On Error Resume Next
        lblcurrentframetrimmer.Text = Int((vlc1.VlcMediaPlayer.Time / 1000) * fps)
        TrackBarseektrimmer.Value = lblcurrentframetrimmer.Text
        lblhmsftrimmer.Text = FToHMSF(lblcurrentframetrimmer.Text)

    End Sub
    Private Sub bwforexportclip_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwforexportclip.DoWork
        On Error Resume Next
        exportclipwithoutanychanges()
    End Sub

    Private Sub bwforexportclip_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwforexportclip.RunWorkerCompleted
        On Error Resume Next
        cmdexportclipwithoutanychanges.Enabled = True
        pbexportclip.Value = pbexportclip.Maximum
        lblexportclipinfo.Text = "Completed"
    End Sub

    Private Sub cmdclosenewTrimmer1_Click(sender As Object, e As EventArgs) Handles cmdclosenewTrimmer1.Click
        Parent.Controls.Remove(Me)
    End Sub

    Private Sub cmdexportmpeg2mov_Click(sender As Object, e As EventArgs) Handles cmdexportmpeg2mov.Click
        On Error Resume Next
        Dim strinout As String = " -ss " & FToHMSms(txtmarkintrimmer.Text) & " -t " & FToHMSms(txtmarkouttrimmer.Text - txtmarkintrimmer.Text)
        osdcutfilename.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"
        osdcutfilename.FileName = System.IO.Path.GetFileNameWithoutExtension(ofdtrimmer.FileName) & "_Trimmed"
        osdcutfilename.FilterIndex = 5
        osdcutfilename.DereferenceLinks = False
        osdcutfilename.Filter = "original wrapper (*" & System.IO.Path.GetExtension(ofdtrimmer.FileName) & ")|*" & System.IO.Path.GetExtension(ofdtrimmer.FileName) & "|mp4 files (*.mp4)|*.mp4|avi files (*.avi)|*.avi|mov files (*.mov)|*.mov|mxf files (*.mxf)|*.mxf|All files (*.*)|*.*"
        If (osdcutfilename.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Process.Start("CMD", "/K " & "C:/casparcg/mydata/ffmpeg/ffmpeg.exe -y " & strinout & " -i " & """" & ofdtrimmer.FileName & """" & " -b:v 25M -minrate 25M -maxrate 25M -vcodec mpeg2video -acodec pcm_s16le -alternate_scan 1 " & """" & osdcutfilename.FileName & """")

        End If
    End Sub

    Private Sub ucnewTrimmer1_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            openfileintrimmer(path)
        Next

    End Sub

    Private Sub ucnewTrimmer1_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub ucnewTrimmer1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub vlc1_Click(sender As Object, e As EventArgs) Handles vlc1.Click

    End Sub
End Class