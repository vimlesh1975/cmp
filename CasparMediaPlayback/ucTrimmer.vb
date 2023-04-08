Imports System.IO
Imports System.ComponentModel
Imports System.Drawing.Text

Public Class ucTrimmer

    Dim iclipsavetrimer As Integer = 1
    Dim openlogoforexport As New OpenFileDialog
    Private Sub cmdffmbcexport_Click(sender As Object, e As EventArgs) Handles cmdffmbcexport.Click
        On Error Resume Next
        Dim strinout = " -ss " & FToHMSms(UcnewTrimmer11.txtmarkintrimmer.Text) & " -t " & FToHMSms(UcnewTrimmer11.txtmarkouttrimmer.Text - UcnewTrimmer11.txtmarkintrimmer.Text)
        UcnewTrimmer11.osdcutfilename.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"
        UcnewTrimmer11.osdcutfilename.FileName = System.IO.Path.GetFileNameWithoutExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "_ffmbc"
        UcnewTrimmer11.osdcutfilename.FilterIndex = 3
        UcnewTrimmer11.osdcutfilename.Filter = "original wrapper (*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & ")|*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "|mp4 files (*.mp4)|*.mp4|mxf files (*.mxf)|*.mxf|avi files (*.avi)|*.avi|All files (*.*)|*.*"
        If (UcnewTrimmer11.osdcutfilename.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Process.Start("CMD", "/K " & "C:/casparcg/mydata/ffmbc/ffmbc-0.7.4-x64.exe -y " & strinout & " -i " & """" & UcnewTrimmer11.ofdtrimmer.FileName & """" & " -threads 4 -tff -target xdcamhd422 -f mxf -an " & """" & UcnewTrimmer11.osdcutfilename.FileName & """" & " " & txtoptionsffmbc.Text)
        End If
    End Sub
    Private Sub chkvideocodeccopy_CheckedChanged(sender As Object, e As EventArgs) Handles chkvideocodeccopy.CheckedChanged
        On Error Resume Next
        If sender.checked Then
            cmbvideocodec.Text = "copy"
            cmbvideocodec.Enabled = False
        Else
            cmbvideocodec.Text = ""
            cmbvideocodec.Enabled = True
        End If
    End Sub




    Dim masterfilenametrimmer As String
    Dim intrimmer As Integer
    Dim outtrimmer As Integer
    Sub readsubcliptrimmer(textfilename As String)
        On Error Resume Next
        Using sr As StreamReader = New StreamReader(textfilename)
            Dim str As Array = Split(sr.ReadLine, ",")
            masterfilenametrimmer = str(0)
            intrimmer = str(1)
            outtrimmer = str(2)
        End Using
    End Sub














    Private Sub cmdhidegbtrimmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        On Error Resume Next
        Me.Hide()
    End Sub

    Private Sub cmdclipcuttrimmer1_Click(sender As Object, e As EventArgs) Handles cmdclipcuttrimmer1.Click

        On Error Resume Next
        UcnewTrimmer11.osdcutfilename.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"
        UcnewTrimmer11.osdcutfilename.FileName = System.IO.Path.GetFileNameWithoutExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "_proxy"
        UcnewTrimmer11.osdcutfilename.FilterIndex = 2
        UcnewTrimmer11.osdcutfilename.Filter = "original wrapper (*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & ")|*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "|mp4 files (*.mp4)|*.mp4|avi files (*.avi)|*.avi|All files (*.*)|*.*"
        If (UcnewTrimmer11.osdcutfilename.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdclipcuttrimmer1.Enabled = False
            'Process.Start("CMD", "/K " & "C:/casparcg/mydata/ffmpeg/ffmpeg.exe -y -i " & """" & ofdtrimmer.FileName & """" & " -ss " & FToHMSms(txtmarkintrimmer.Text) & " -to " & FToHMSms(txtmarkouttrimmer.Text) & " -c copy " & """" & osdcutfilename.FileName & """")
            bwforexportclip1.RunWorkerAsync()
        End If

    End Sub
    Sub exportclip1()
        Dim strinout = " -ss " & FToHMSms(UcnewTrimmer11.txtmarkintrimmer.Text) & " -t " & FToHMSms(UcnewTrimmer11.txtmarkouttrimmer.Text - UcnewTrimmer11.txtmarkintrimmer.Text)

        Control.CheckForIllegalCrossThreadCalls = False
        Dim proc As New Process
        Dim startinfo As New System.Diagnostics.ProcessStartInfo
        Dim sr As StreamReader
        Dim cmd As String = "-y " & strinout & " -i " & """" & UcnewTrimmer11.ofdtrimmer.FileName & """" & " -vcodec " & cmbvideocodec1.Text & " -acodec " & cmbaudiocodec1.Text & " -b:v " & (Val(cmbbitrate1.Text) * 1000000) & " " & txtoptionstrimmer1.Text & " " & """" & UcnewTrimmer11.osdcutfilename.FileName & """"

        Dim ffmpegOutput As String

        ' all parameters required to run the process
        startinfo.FileName = "c:/casparcg/mydata/ffmpeg/ffmpeg.exe"
        startinfo.Arguments = cmd
        startinfo.UseShellExecute = False
        startinfo.WindowStyle = ProcessWindowStyle.Hidden
        startinfo.RedirectStandardError = True
        startinfo.RedirectStandardOutput = True
        startinfo.CreateNoWindow = True
        proc.StartInfo = startinfo
        proc.Start() ' start the process
        sr = proc.StandardError 'standard error is used by ffmpeg

        pbexportclip1.Maximum = UcnewTrimmer11.txtmarkouttrimmer.Text - UcnewTrimmer11.txtmarkintrimmer.Text
        lblexportclipinfo1.Text = ""
        Do
            ffmpegOutput = sr.ReadLine
            pbexportclip1.Value = Val(Mid(Split(ffmpegOutput, "fps")(0), 7))
            lblexportclipinfo1.Text = pbexportclip1.Value & " Frames"
        Loop Until proc.HasExited And ffmpegOutput = Nothing Or ffmpegOutput = ""

    End Sub

    Sub exportclip2()
        Dim strinout = " -ss " & FToHMSms(UcnewTrimmer11.txtmarkintrimmer.Text) & " -t " & FToHMSms(UcnewTrimmer11.txtmarkouttrimmer.Text - UcnewTrimmer11.txtmarkintrimmer.Text)
        Control.CheckForIllegalCrossThreadCalls = False
        Dim proc As New Process
        Dim startinfo As New System.Diagnostics.ProcessStartInfo
        Dim sr As StreamReader
        Dim cmd As String = "-y " & strinout & " -i " & """" & UcnewTrimmer11.ofdtrimmer.FileName & """" & " -vcodec " & cmbvideocodec2.Text & " -acodec " & cmbaudiocodec2.Text & " -b:v " & (Val(cmbbitrate2.Text) * 1000000) & " " & txtoptionstrimmer2.Text & " " & """" & UcnewTrimmer11.osdcutfilename.FileName & """"

        Dim ffmpegOutput As String

        ' all parameters required to run the process
        startinfo.FileName = "c:/casparcg/mydata/ffmpeg/ffmpeg.exe"
        startinfo.Arguments = cmd
        startinfo.UseShellExecute = False
        startinfo.WindowStyle = ProcessWindowStyle.Hidden
        startinfo.RedirectStandardError = True
        startinfo.RedirectStandardOutput = True
        startinfo.CreateNoWindow = True
        proc.StartInfo = startinfo
        proc.Start() ' start the process
        sr = proc.StandardError 'standard error is used by ffmpeg

        pbexportclip2.Maximum = UcnewTrimmer11.txtmarkouttrimmer.Text - UcnewTrimmer11.txtmarkintrimmer.Text
        lblexportclipinfo2.Text = ""
        Do
            ffmpegOutput = sr.ReadLine
            pbexportclip2.Value = Val(Mid(Split(ffmpegOutput, "fps")(0), 7))
            lblexportclipinfo2.Text = pbexportclip2.Value & " Frames"
        Loop Until proc.HasExited And ffmpegOutput = Nothing Or ffmpegOutput = ""

    End Sub
    Sub exportclip3()

        Control.CheckForIllegalCrossThreadCalls = False
        Dim proc As New Process
        Dim startinfo As New System.Diagnostics.ProcessStartInfo
        Dim sr As StreamReader
        Dim cmd As String = "-i " & """" & UcnewTrimmer11.ofdtrimmer.FileName & """" & " -ss " & FToHMSms(UcnewTrimmer11.txtmarkintrimmer.Text) & " -t " & FToHMSms(UcnewTrimmer11.txtmarkouttrimmer.Text - UcnewTrimmer11.txtmarkintrimmer.Text) & " -vcodec mpeg2video -acodec pcm_s24le -vf scale=1440:1080,pad=1920:1080:240:0,setfield=tff -pix_fmt yuv422p -alternate_scan 1  -g 12 -bf 2 -b:v 50000k -minrate 50000k -maxrate 50000k -aspect 16:9 -ac 1 -map 0:0 -map 0:1 -map 0:1 -map 0:1 -map 0:1 -map 0:1 -map 0:1 -map 0:1 -map 0:1 -timecode 00:02:00:00 -metadata creation_time=now -color_primaries bt709 -color_trc 1  -colorspace 1 -f mxf pipe:1 | " & """" & "c:/casparcg/mydata/ffmbc/ffmbc-0.7.4-x64.exe" & """" & " -i - -threads 4 -tff -target xdcamhd422 -f mxf -y -an " & """" & UcnewTrimmer11.osdcutfilename.FileName & """" & " " & txtoptionstrimmer3.Text

        Dim ffmpegOutput As String

        ' all parameters required to run the process
        startinfo.FileName = "c:/casparcg/mydata/ffmpeg/ffmpeg.exe"
        startinfo.Arguments = cmd
        startinfo.UseShellExecute = False
        startinfo.WindowStyle = ProcessWindowStyle.Hidden
        startinfo.RedirectStandardError = True
        startinfo.RedirectStandardOutput = True
        startinfo.CreateNoWindow = True
        proc.StartInfo = startinfo
        proc.Start() ' start the process
        sr = proc.StandardError 'standard error is used by ffmpeg

        pbexportclip3.Maximum = UcnewTrimmer11.txtmarkouttrimmer.Text - UcnewTrimmer11.txtmarkintrimmer.Text
        lblexportclipinfo3.Text = ""
        Do
            ffmpegOutput = sr.ReadLine
            pbexportclip3.Value = Val(Mid(Split(ffmpegOutput, "fps")(0), 7))
            lblexportclipinfo3.Text = pbexportclip3.Value & " Frames"
        Loop Until proc.HasExited And ffmpegOutput = Nothing Or ffmpegOutput = ""

    End Sub

    Sub exportclip4()
        Dim strinout = " -ss " & FToHMSms(UcnewTrimmer11.txtmarkintrimmer.Text) & " -t " & FToHMSms(UcnewTrimmer11.txtmarkouttrimmer.Text - UcnewTrimmer11.txtmarkintrimmer.Text)
        Control.CheckForIllegalCrossThreadCalls = False
        Dim proc As New Process
        Dim startinfo As New System.Diagnostics.ProcessStartInfo
        Dim sr As StreamReader
        Dim cmd As String = "-y " & strinout & " -i " & """" & UcnewTrimmer11.ofdtrimmer.FileName & """" & " -vcodec " & cmbvideocodec4.Text & " -acodec " & cmbaudiocodec4.Text & " -b:v " & (Val(cmbbitrate4.Text) * 1000000) & " " & txtoptionstrimmer4.Text & " " & """" & UcnewTrimmer11.osdcutfilename.FileName & """"

        Dim ffmpegOutput As String

        ' all parameters required to run the process
        startinfo.FileName = "c:/casparcg/mydata/ffmpeg/ffmpeg.exe"
        startinfo.Arguments = cmd
        startinfo.UseShellExecute = False
        startinfo.WindowStyle = ProcessWindowStyle.Hidden
        startinfo.RedirectStandardError = True
        startinfo.RedirectStandardOutput = True
        startinfo.CreateNoWindow = True
        proc.StartInfo = startinfo
        proc.Start() ' start the process
        sr = proc.StandardError 'standard error is used by ffmpeg

        pbexportclip4.Maximum = UcnewTrimmer11.txtmarkouttrimmer.Text - UcnewTrimmer11.txtmarkintrimmer.Text
        lblexportclipinfo4.Text = ""
        Do
            ffmpegOutput = sr.ReadLine
            pbexportclip4.Value = Val(Mid(Split(ffmpegOutput, "fps")(0), 7))
            lblexportclipinfo4.Text = pbexportclip4.Value & " Frames"
        Loop Until proc.HasExited And ffmpegOutput = Nothing Or ffmpegOutput = ""

    End Sub
    Private Sub bwforexportclip1_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwforexportclip1.DoWork
        On Error Resume Next
        exportclip1()
    End Sub

    Private Sub bwforexportclip1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwforexportclip1.RunWorkerCompleted
        On Error Resume Next
        cmdclipcuttrimmer1.Enabled = True
        pbexportclip1.Value = pbexportclip1.Maximum
        lblexportclipinfo1.Text = "Completed"
    End Sub

    Private Sub cmdclipcuttrimmer2_Click(sender As Object, e As EventArgs) Handles cmdclipcuttrimmer2.Click
        On Error Resume Next
        UcnewTrimmer11.osdcutfilename.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"
        UcnewTrimmer11.osdcutfilename.FileName = System.IO.Path.GetFileNameWithoutExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "_proxy"
        UcnewTrimmer11.osdcutfilename.FilterIndex = 2
        UcnewTrimmer11.osdcutfilename.Filter = "original wrapper (*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & ")|*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "|mp4 files (*.mp4)|*.mp4|avi files (*.avi)|*.avi|All files (*.*)|*.*"
        If (UcnewTrimmer11.osdcutfilename.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdclipcuttrimmer2.Enabled = False
            bwforexportclip2.RunWorkerAsync()
        End If
    End Sub

    Private Sub bwforexportclip2_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwforexportclip2.DoWork
        On Error Resume Next
        exportclip2()
    End Sub

    Private Sub bwforexportclip2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwforexportclip2.RunWorkerCompleted
        On Error Resume Next
        cmdclipcuttrimmer2.Enabled = True
        pbexportclip2.Value = pbexportclip2.Maximum
        lblexportclipinfo2.Text = "Completed"
    End Sub


    Private Sub cmdclipcuttrimmer3_Click(sender As Object, e As EventArgs) Handles cmdclipcuttrimmer3.Click
        Dim strinout = " -ss " & FToHMSms(UcnewTrimmer11.txtmarkintrimmer.Text) & " -t " & FToHMSms(UcnewTrimmer11.txtmarkouttrimmer.Text - UcnewTrimmer11.txtmarkintrimmer.Text)

        On Error Resume Next
        UcnewTrimmer11.osdcutfilename.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"
        UcnewTrimmer11.osdcutfilename.FileName = System.IO.Path.GetFileNameWithoutExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "_ffmbc"
        UcnewTrimmer11.osdcutfilename.FilterIndex = 3
        UcnewTrimmer11.osdcutfilename.Filter = "original wrapper (*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & ")|*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "|mp4 files (*.mp4)|*.mp4|mxf files (*.mxf)|*.mxf|avi files (*.avi)|*.avi|All files (*.*)|*.*"
        If (UcnewTrimmer11.osdcutfilename.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Process.Start("CMD", "/K " & "c:\casparcg\mydata\ffmpeg\ffmpeg.exe -y " & strinout & " -i " & """" & UcnewTrimmer11.ofdtrimmer.FileName & """" & " -vcodec mpeg2video -acodec pcm_s24le -vf scale=1440:1080,pad=1920:1080:240:0,setfield=tff -pix_fmt yuv422p -alternate_scan 1  -g 12 -bf 2 -b:v 50000k -minrate 50000k -maxrate 50000k -aspect 16:9 -ac 1 -map 0:0 -map 0:1 -map 0:1 -map 0:1 -map 0:1 -map 0:1 -map 0:1 -map 0:1 -map 0:1 -timecode 00:02:00:00 -metadata creation_time=now -color_primaries bt709 -color_trc 1  -colorspace 1 -f mxf pipe:1 | " & """" & "c:/casparcg/mydata/ffmbc/ffmbc-0.7.4-x64.exe" & """" & " -i - -threads 4 -tff -target xdcamhd422 -f mxf -y -an " & """" & UcnewTrimmer11.osdcutfilename.FileName & """" & " " & txtoptionstrimmer3.Text)

        End If
    End Sub
    Private Sub bwforexportclip3_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwforexportclip3.DoWork
        On Error Resume Next
        exportclip3()
    End Sub

    Private Sub bwforexportclip3_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwforexportclip3.RunWorkerCompleted
        On Error Resume Next
        cmdclipcuttrimmer3.Enabled = True
        pbexportclip3.Value = pbexportclip3.Maximum
        lblexportclipinfo3.Text = "Completed"
    End Sub

    Private Sub cmdclipcuttrimmer4_Click(sender As Object, e As EventArgs) Handles cmdclipcuttrimmer4.Click
        On Error Resume Next
        UcnewTrimmer11.osdcutfilename.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"
        UcnewTrimmer11.osdcutfilename.FileName = System.IO.Path.GetFileNameWithoutExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "_SD"
        UcnewTrimmer11.osdcutfilename.FilterIndex = 3
        UcnewTrimmer11.osdcutfilename.Filter = "original wrapper (*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & ")|*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "|mp4 files (*.mp4)|*.mp4|mxf files (*.mxf)|*.mxf|avi files (*.avi)|*.avi|All files (*.*)|*.*"
        If (UcnewTrimmer11.osdcutfilename.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdclipcuttrimmer4.Enabled = False
            'Process.Start("CMD", "/K " & "C:/casparcg/mydata/ffmpeg/ffmpeg.exe -y -i " & """" & ofdtrimmer.FileName & """" & " -ss " & FToHMSms(txtmarkintrimmer.Text) & " -to " & FToHMSms(txtmarkouttrimmer.Text) & " -c copy " & """" & osdcutfilename.FileName & """")
            bwforexportclip4.RunWorkerAsync()
        End If
    End Sub

    Private Sub bwforexportclip4_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwforexportclip4.DoWork
        On Error Resume Next
        exportclip4()
    End Sub

    Private Sub bwforexportclip4_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwforexportclip4.RunWorkerCompleted
        On Error Resume Next
        cmdclipcuttrimmer4.Enabled = True
        pbexportclip4.Value = pbexportclip4.Maximum
        lblexportclipinfo4.Text = "Completed"
    End Sub

    Private Sub cmdtrimmerfileinfo_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        showfileinformation(UcnewTrimmer11.ofdtrimmer.FileName)
    End Sub

    Private Sub cmdtrimmerfileinfoencoded_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        showfileinformation(UcnewTrimmer11.osdcutfilename.FileName)
    End Sub

    Private Sub cmdtrimmerfilePlayencoded_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        playinvlc(UcnewTrimmer11.osdcutfilename.FileName)
    End Sub



    Private Sub cmdlogoexport_Click(sender As Object, e As EventArgs) Handles cmdlogoexport.Click
        On Error Resume Next

        Dim strinout = " -ss " & FToHMSms(UcnewTrimmer11.txtmarkintrimmer.Text) & " -t " & FToHMSms(UcnewTrimmer11.txtmarkouttrimmer.Text - UcnewTrimmer11.txtmarkintrimmer.Text)
        UcnewTrimmer11.osdcutfilename.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"
        UcnewTrimmer11.osdcutfilename.FileName = System.IO.Path.GetFileNameWithoutExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "_WithLogo"
        UcnewTrimmer11.osdcutfilename.FilterIndex = 2
        UcnewTrimmer11.osdcutfilename.Filter = "original wrapper (*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & ")|*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "|mp4 files (*.mp4)|*.mp4|mxf files (*.mxf)|*.mxf|avi files (*.avi)|*.avi|All files (*.*)|*.*"
        If (UcnewTrimmer11.osdcutfilename.ShowDialog() = Windows.Forms.DialogResult.OK) Then

            Dim str1 As String

            If rdoOnlyLogo.Checked Then
                str1 = "c:/casparcg/mydata/ffmpeg/ffmpeg.exe -y " & strinout & " -i " &
                              """" & UcnewTrimmer11.ofdtrimmer.FileName & """" & " -stream_loop -1 -i " & """" & openlogoforexport.FileName & """" & " -filter_complex " &
                               """" & "[1:v]scale=" & nlogowidthforexport.Value & ":" & nlogoheightforexport.Value & " [ovrl],[0:v][ovrl]overlay=shortest=1:x=" &
                               nlogoxposition.Value & ":y=" & nlogoyposition.Value & """" &
                               " -vcodec " & cmbvideocodec5.Text & " -acodec " & cmbaudiocodec5.Text & " -b:v " & (Val(cmbbitrate5.Text) * 1000000) & " " &
                               """" & UcnewTrimmer11.osdcutfilename.FileName & """"

            End If

            Dim aa As String
            If chkrtl.Checked Then
                aa = ":x='if(gt(x,-tw),w-mod(" & nSpeedScroll.Value & "*n,w+tw),w)':fontcolor="
            Else
                aa = ":x='if(lt(x,w),mod(" & nSpeedScroll.Value & "*n,w+tw)-tw,tw)':fontcolor="
            End If

            If rdoOnlyScroll.Checked Then



                str1 = "c:/casparcg/mydata/ffmpeg/ffmpeg.exe -y " & strinout & " -i " &
                          """" & UcnewTrimmer11.ofdtrimmer.FileName & """" & " -filter_complex drawbox=x=0:y=ih-3-" & cmbfontsizescroll.Text & "-" & nYPositionScroll.Value & ":w=iw:h=" & cmbfontsizescroll.Text & "+6:color=" & ColorTranslator.ToHtml(cmdstripcolor1.BackColor) & "@" & nstripopacity.Value & ":t=fill,drawtext=" & """" & "text=" & cmbScrollText.Text & ":fontfile='c\:/windows/fonts/" & cmbfontscroll.Text & "':y=h-line_h-3-" & nYPositionScroll.Value & aa & ColorTranslator.ToHtml(cmdfontcolor1.ForeColor) & "@" & nopacity.Value & ":fontsize=" & cmbfontsizescroll.Text & """" &
                           " -vcodec " & cmbvideocodec5.Text & " -acodec " & cmbaudiocodec5.Text & " -b:v " & (Val(cmbbitrate5.Text) * 1000000) & " " &
                           """" & UcnewTrimmer11.osdcutfilename.FileName & """"
            End If

            If rdoLogoAndScroll.Checked Then

                'str1 = "c:/casparcg/mydata/ffmpeg/ffmpeg.exe -y " & strinout & " -i " &
                '"""" & UcnewTrimmer11.ofdtrimmer.FileName & """" & " -stream_loop -1 -i " & """" & openlogoforexport.FileName & """" & " -filter_complex " &
                ' """" & "[1:v]scale=" & nlogowidthforexport.Value & ":" & nlogoheightforexport.Value & " [ovrl],[0:v][ovrl]overlay=shortest=1:x=" &
                'nlogoxposition.Value & ":y=" & nlogoyposition.Value & " [v2],[v2]drawtext=text=" & cmbScrollText.Text & ":fontfile='c\:/windows/fonts/" & cmbfontscroll.Text & "':y=h-line_h-" & nYPositionScroll.Value & ":x=w-w/" & nSpeedScroll.Value & "*mod(t\," & "" & "):fontcolor=white@" & nopacity.Value & ":fontsize=" & cmbfontsizescroll.Text & """" &
                '  " -vcodec " & cmbvideocodec5.Text & " -acodec " & cmbaudiocodec5.Text & " -b:v " & (Val(cmbbitrate5.Text) * 1000000) & " " &
                ' """" & UcnewTrimmer11.osdcutfilename.FileName & """"


                str1 = "c:/casparcg/mydata/ffmpeg/ffmpeg.exe -y " & strinout & " -i " &
                                """" & UcnewTrimmer11.ofdtrimmer.FileName & """" & " -stream_loop -1 -i " & """" & openlogoforexport.FileName & """" & " -filter_complex " &
                                 """" & "[1:v]scale=" & nlogowidthforexport.Value & ":" & nlogoheightforexport.Value & " [ovrl],[0:v][ovrl]overlay=shortest=1:x=" &
                                 nlogoxposition.Value & ":y=" & nlogoyposition.Value & " [v2],[v2]drawbox=x=0:y=ih-3-" & cmbfontsizescroll.Text & "-" & nYPositionScroll.Value & ":w=iw:h=" & cmbfontsizescroll.Text & "+6:color=" & ColorTranslator.ToHtml(cmdstripcolor1.BackColor) & "@" & nstripopacity.Value & ":t=fill " & "[v3],[v3]drawtext=text=" & cmbScrollText.Text & ":fontfile='c\:/windows/fonts/" & cmbfontscroll.Text & "':y=h-line_h-3-" & nYPositionScroll.Value & aa & ColorTranslator.ToHtml(cmdfontcolor1.ForeColor) & "@" & nopacity.Value & ":fontsize=" & cmbfontsizescroll.Text & """" &
                                 " -vcodec " & cmbvideocodec5.Text & " -acodec " & cmbaudiocodec5.Text & " -b:v " & (Val(cmbbitrate5.Text) * 1000000) & " " &
                                 """" & UcnewTrimmer11.osdcutfilename.FileName & """"



            End If
            'Dim MyValue = InputBox("", "", str1)
            Process.Start("CMD", "/K " & str1)
        End If
    End Sub









    Private Sub chkaudiocodeccopy_CheckedChanged(sender As Object, e As EventArgs) Handles chkaudiocodeccopy.CheckedChanged
        On Error Resume Next
        If sender.checked Then
            cmbaudiocodec.Text = "copy"
            cmbaudiocodec.Enabled = False
        Else
            cmbaudiocodec.Text = ""
            cmbaudiocodec.Enabled = True
        End If
    End Sub



    Private Sub chkvideocodeccopyjoin_CheckedChanged(sender As Object, e As EventArgs) Handles chkvideocodeccopyjoin.CheckedChanged
        On Error Resume Next
        If sender.checked Then
            cmbvideocodecjoin.Text = "copy"
            cmbvideocodecjoin.Enabled = False
        Else
            cmbvideocodecjoin.Text = ""
            cmbvideocodecjoin.Enabled = True
        End If
    End Sub

    Private Sub chkaudiocodeccopyjoin_CheckedChanged(sender As Object, e As EventArgs) Handles chkaudiocodeccopyjoin.CheckedChanged
        On Error Resume Next
        If sender.checked Then
            cmbaudiocodecjoin.Text = "copy"
            cmbaudiocodecjoin.Enabled = False
        Else
            cmbaudiocodecjoin.Text = ""
            cmbaudiocodecjoin.Enabled = True
        End If
    End Sub

    Private Sub cmdclipjoin_Click(sender As Object, e As EventArgs) Handles cmdclipjoin.Click
        On Error Resume Next
        Dim osdjoin1 As New SaveFileDialog

        osdjoin1.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"
        osdjoin1.FileName = "joned1.mp4" ' System.IO.Path.GetFileNameWithoutExtension(ofdtrimmer.FileName) & "_Trimmed"
        osdjoin1.Filter = "All files (*.*)|*.*|mpg files (*.mpg)|*.mpg|avi files (*.avi)|*.avi|mp4 files (*.mp4)|*.mp4"
        If (osdjoin1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Dim aa As New StreamWriter("c:/casparcg/mydata/joiner/f.txt")

            For i = 0 To dgvjoiner.RowCount - 1
                If (dgvjoiner.Rows(i).Cells("File").Value <> "" And IO.File.Exists(dgvjoiner.Rows(i).Cells("File").Value)) Then aa.WriteLine("file '" & Replace(dgvjoiner.Rows(i).Cells("File").Value, "\", "/") & "'")
            Next

            aa.Close()
            Threading.Thread.Sleep(1000)
            Process.Start("CMD", "/K c: & cd C:/casparcg/mydata/joiner & C:/casparcg/mydata/ffmpeg/ffmpeg.exe -y -f concat -safe 0 -i f.txt " & " -vcodec " & cmbvideocodecjoin.Text & " -acodec " & cmbaudiocodecjoin.Text & " " & txtoptionstrimmerjoin.Text & " " & """" & osdjoin1.FileName & """")
        End If


    End Sub


    Private Sub ucTrimmer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Control.CheckForIllegalCrossThreadCalls = False
        dgvsegmentation.Rows.Add(5)
        UcnewTrimmer11.cmdclosenewTrimmer1.Visible = False

        cmbvideocodec.Items.AddRange(System.IO.File.ReadAllLines("C:\casparcg\mydata\ffmpeg\video_codecs.txt"))
        cmbaudiocodec.Items.AddRange(System.IO.File.ReadAllLines("C:\casparcg\mydata\ffmpeg\audio_codecs.txt"))

        cmbvideocodec1.Items.AddRange(System.IO.File.ReadAllLines("C:\casparcg\mydata\ffmpeg\video_codecs.txt"))
        cmbaudiocodec1.Items.AddRange(System.IO.File.ReadAllLines("C:\casparcg\mydata\ffmpeg\audio_codecs.txt"))

        cmbvideocodec2.Items.AddRange(System.IO.File.ReadAllLines("C:\casparcg\mydata\ffmpeg\video_codecs.txt"))
        cmbaudiocodec2.Items.AddRange(System.IO.File.ReadAllLines("C:\casparcg\mydata\ffmpeg\audio_codecs.txt"))

        cmbvideocodec3.Items.AddRange(System.IO.File.ReadAllLines("C:\casparcg\mydata\ffmpeg\video_codecs.txt"))
        cmbaudiocodec3.Items.AddRange(System.IO.File.ReadAllLines("C:\casparcg\mydata\ffmpeg\audio_codecs.txt"))


        cmbvideocodec4.Items.AddRange(System.IO.File.ReadAllLines("C:\casparcg\mydata\ffmpeg\video_codecs.txt"))
        cmbaudiocodec4.Items.AddRange(System.IO.File.ReadAllLines("C:\casparcg\mydata\ffmpeg\audio_codecs.txt"))



        cmbvideocodec5.Items.AddRange(System.IO.File.ReadAllLines("C:\casparcg\mydata\ffmpeg\video_codecs.txt"))
        cmbaudiocodec5.Items.AddRange(System.IO.File.ReadAllLines("C:\casparcg\mydata\ffmpeg\audio_codecs.txt"))


        cmbvideocodec6.Items.AddRange(System.IO.File.ReadAllLines("C:\casparcg\mydata\ffmpeg\video_codecs.txt"))
        cmbaudiocodec6.Items.AddRange(System.IO.File.ReadAllLines("C:\casparcg\mydata\ffmpeg\audio_codecs.txt"))

        cmbvideocodecjoin.Items.AddRange(System.IO.File.ReadAllLines("C:\casparcg\mydata\ffmpeg\video_codecs.txt"))
        cmbaudiocodecjoin.Items.AddRange(System.IO.File.ReadAllLines("C:\casparcg\mydata\ffmpeg\audio_codecs.txt"))


        dgvjoiner.Rows.Add(10)


        vlcLogo.VlcMediaPlayer.SetMedia(New Uri("c:\casparcg\_media\sd_frame.png"))
        vlcLogo.VlcMediaPlayer.Play()
        openlogoforexport.FileName = "c:\casparcg\_media\sd_frame.png"


        UcnewTrimmer11.ofdtrimmer.FileName = "c:/casparcg/_media/kabhi_kabhi.mp4"
        UcnewTrimmer11.openfileintrimmer(UcnewTrimmer11.ofdtrimmer.FileName)

        dgvgraphics.Rows.Add(5)
        dgvgraphics.Rows(0).Cells(0).Value = "C:\casparcg\_media\K D Prasad.png"
        dgvgraphics.Rows(0).Cells(2).Value = 1
        dgvgraphics.Rows(0).Cells(3).Value = 3

        dgvgraphics.Rows(1).Cells(0).Value = "C:\casparcg\_media\vimlesh kumar.png"
        dgvgraphics.Rows(1).Cells(2).Value = 4
        dgvgraphics.Rows(1).Cells(3).Value = 6

        dgvgraphics.Rows(2).Cells(0).Value = "C:\casparcg\_media\logo1.png"
        dgvgraphics.Rows(2).Cells(2).Value = 7
        dgvgraphics.Rows(2).Cells(3).Value = 9

        dgvgraphics2.Rows.Add(5)
        dgvgraphics2.Rows(0).Cells(0).Value = "Vimlesh Kumar"
        dgvgraphics2.Rows(0).Cells(1).Value = 1
        dgvgraphics2.Rows(0).Cells(2).Value = 3

        dgvgraphics2.Rows(1).Cells(0).Value = "K D Prasad"
        dgvgraphics2.Rows(1).Cells(1).Value = 4
        dgvgraphics2.Rows(1).Cells(2).Value = 6

        dgvgraphics2.Rows(2).Cells(0).Value = "K G Rajeev"
        dgvgraphics2.Rows(2).Cells(1).Value = 7
        dgvgraphics2.Rows(2).Cells(2).Value = 9

        Dim diInfo As New DirectoryInfo("C:\windows\Fonts\")
        For Each fiInfo As FileInfo In diInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly)
            Dim sFile As Microsoft.WindowsAPICodePack.Shell.ShellFile = Microsoft.WindowsAPICodePack.Shell.ShellFile.FromFilePath(fiInfo.FullName)
            If (fiInfo.Name).Contains(".fon") = False Then
                cmbfont.Items.Add(fiInfo.Name)
                cmbfontscroll.Items.Add(fiInfo.Name)
            End If

        Next

    End Sub





    Private Sub cmdmarkINSegmentation_Click(sender As Object, e As EventArgs) Handles cmdmarkINSegmentation.Click
        On Error Resume Next
        dgvsegmentation.CurrentRow.Cells(0).Value = System.IO.Path.GetFileNameWithoutExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "_Cut" & dgvsegmentation.CurrentRow.Index + 1 'Replace(Mid(ofdtrimmer.FileName, Len(mediafullpath) + 1), "\", "/")
        dgvsegmentation.CurrentRow.Cells(1).Value = UcnewTrimmer11.lblhmsftrimmer.Text  'lblcurrentframetrimmer.Text 'TrackBarseek.Value

        dgvsegmentation.CurrentRow.Cells(3).Value = FToHMSF(HMSFtoF(dgvsegmentation.CurrentRow.Cells(2).Value) - HMSFtoF(dgvsegmentation.CurrentRow.Cells(1).Value))

    End Sub

    Private Sub cmdmarkOUTSegmentation_Click(sender As Object, e As EventArgs) Handles cmdmarkOUTSegmentation.Click
        On Error Resume Next
        dgvsegmentation.CurrentRow.Cells(0).Value = System.IO.Path.GetFileNameWithoutExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "_Cut" & dgvsegmentation.CurrentRow.Index + 1 'Replace(Mid(ofdtrimmer.FileName, Len(mediafullpath) + 1), "\", "/")
        dgvsegmentation.CurrentRow.Cells(2).Value = UcnewTrimmer11.lblhmsftrimmer.Text 'lblcurrentframetrimmer.Text 'TrackBarseek.Value

        dgvsegmentation.CurrentRow.Cells(3).Value = FToHMSF(HMSFtoF(dgvsegmentation.CurrentRow.Cells(2).Value) - HMSFtoF(dgvsegmentation.CurrentRow.Cells(1).Value))
        dgvsegmentation.CurrentCell = dgvsegmentation.Rows(dgvsegmentation.CurrentRow.Index + 1).Cells(0)
    End Sub

    Private Sub cmdGotoINSegments_Click(sender As Object, e As EventArgs) Handles cmdGotoINSegments.Click
        On Error Resume Next
        UcnewTrimmer11.vlc1.VlcMediaPlayer.Time = (HMSFtoF(dgvsegmentation.CurrentRow.Cells(1).Value)) * 1000 / (fps)



    End Sub

    Private Sub cmdGotoOUTSegments_Click(sender As Object, e As EventArgs) Handles cmdGotoOUTSegments.Click
        On Error Resume Next
        UcnewTrimmer11.vlc1.VlcMediaPlayer.Time = (HMSFtoF(dgvsegmentation.CurrentRow.Cells(2).Value)) * 1000 / (fps)



    End Sub

    Private Sub cmdMakeSegments_Click(sender As Object, e As EventArgs) Handles cmdMakeSegments.Click
        ' On Error Resume Next
        Dim osdtrimmer As New SaveFileDialog
        osdtrimmer.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"

        Dim bb As New FolderBrowserDialog
        bb.SelectedPath = osdtrimmer.InitialDirectory
        If bb.ShowDialog = DialogResult.OK Then
            For aa = 0 To dgvsegmentation.Rows.Count - 1
                If dgvsegmentation.Rows(aa).Cells(1).Value = "" Then Exit For
                osdtrimmer.FileName = System.IO.Path.GetFileNameWithoutExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "_Cut" & aa + 1
                'Using sw As StreamWriter = New StreamWriter(bb.SelectedPath & "/" & osdtrimmer.FileName & ".txt")
                Using sw As StreamWriter = New StreamWriter(bb.SelectedPath & "/" & dgvsegmentation.Rows(aa).Cells(0).Value.ToString & ".txt")
                    sw.WriteLine(Replace(Mid(UcnewTrimmer11.ofdtrimmer.FileName, Len(mediafullpath) + 1), "\", "/") & Chr(2) & HMSFtoF(dgvsegmentation.Rows(aa).Cells(1).Value) & Chr(2) & HMSFtoF(dgvsegmentation.Rows(aa).Cells(2).Value))
                    sw.Close()

                End Using

            Next
            MsgBox("Sub Clips are created in " & bb.SelectedPath)
        End If


    End Sub

    Private Sub gbsegmentation_Enter(sender As Object, e As EventArgs) Handles gbsegmentation.Enter

    End Sub


    Private Sub cmdPlayFromCurrentPosition_Click(sender As Object, e As EventArgs) Handles cmdPlayFromCurrentPosition.Click
        On Error Resume Next
        If System.IO.Path.GetExtension(UcnewTrimmer11.lblfilenametrimmer.Text) = ".txt" Then
            readsubcliptrimmer(UcnewTrimmer11.lblfilenametrimmer.Text)
            SendString(NetStream, "play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & masterfilenametrimmer & """" & " seek " & UcnewTrimmer11.lblcurrentframetrimmer.Text & " length " & (UcnewTrimmer11.txtmarkouttrimmer.Text - UcnewTrimmer11.lblcurrentframetrimmer.Text) & vbCrLf)

        Else

            SendString(NetStream, "Play " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & Replace(Replace(UcnewTrimmer11.lblfilenametrimmer.Text, ":", ":\"), "\", "/") & """" & " seek " & UcnewTrimmer11.lblcurrentframetrimmer.Text & " length " & (UcnewTrimmer11.txtmarkouttrimmer.Text - UcnewTrimmer11.lblcurrentframetrimmer.Text) & vbCrLf)
        End If
    End Sub
    Private Sub cmdCueFromCurrentPosition_Click(sender As Object, e As EventArgs) Handles cmdCueFromCurrentPosition.Click
        On Error Resume Next

        If System.IO.Path.GetExtension(UcnewTrimmer11.lblfilenametrimmer.Text) = ".txt" Then
            readsubcliptrimmer(UcnewTrimmer11.lblfilenametrimmer.Text)
            SendString(NetStream, "load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & masterfilenametrimmer & """" & " seek " & UcnewTrimmer11.lblcurrentframetrimmer.Text & vbCrLf)

        Else
            SendString(NetStream, "load " & g_int_ChannelNumber & "-" & g_int_PlaylistLayer & " " & """" & Replace(Replace(UcnewTrimmer11.lblfilenametrimmer.Text, ":", ":\"), "\", "/") & """" & " seek " & UcnewTrimmer11.lblcurrentframetrimmer.Text & vbCrLf)

        End If

    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub
    Sub savesegmentlist(filename As String)
        On Error Resume Next
        Using sw As StreamWriter = New StreamWriter(filename)
            With dgvsegmentation
                If .Rows.Count = 0 Then
                    sw.Write("")
                Else
                    'Loop through and add list to the file.
                    Dim f As Integer = 0
                    Do Until f = .Rows.Count - 1
                        sw.WriteLine(.Rows(f).Cells(0).Value & Chr(2) & .Rows(f).Cells(1).Value & Chr(2) & .Rows(f).Cells(2).Value & Chr(2) & .Rows(f).Cells(3).Value)
                        f = f + 1
                    Loop
                End If
                sw.Close()
            End With
        End Using
    End Sub

    Sub saveassegmentlist()
        On Error Resume Next
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "c:\casparcg\mydata\segments\"
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            With dgvsegmentation
                Using sw As StreamWriter = New StreamWriter(osd2.FileName)
                    If .Rows.Count = 0 Then
                        sw.Write("")
                    Else
                        'Loop through and add list to the file.
                        Dim f As Integer = 0
                        Do Until f = .Rows.Count - 1
                            sw.WriteLine(.Rows(f).Cells(0).Value & Chr(2) & .Rows(f).Cells(1).Value & Chr(2) & .Rows(f).Cells(2).Value & Chr(2) & .Rows(f).Cells(3).Value)
                            f = f + 1
                        Loop
                    End If
                    sw.Close()
                End Using
                Me.lblsegmentlist.Text = osd2.FileName
                SaveToolStripMenuItem.Enabled = True
            End With
        End If
    End Sub

    Private Sub SaveAsToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip1.MouseHover
        MakeMenuDropDownWhenParrented(sender)
    End Sub
    Sub opensegmentlist()
        On Error Resume Next
        ofd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd2.InitialDirectory = "c:\casparcg\mydata\segments\"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            SaveToolStripMenuItem.Enabled = True
            Using sr As StreamReader = New StreamReader(ofd2.FileName)
                With dgvsegmentation
                    'clear list
                    .Rows.Clear()
                    'Loop through and add list to the file.
                    Dim g As Integer = 0
                    Dim li As String
                    Do Until sr.EndOfStream = True
                        li = sr.ReadLine()
                        .Rows.Add()
                        Dim xyz As Array = Split(li, Chr(2))
                        .Rows(g).Cells(0).Value = xyz(0)
                        .Rows(g).Cells(1).Value = xyz(1)
                        .Rows(g).Cells(2).Value = xyz(2)
                        .Rows(g).Cells(3).Value = xyz(3)
                        g = g + 1
                    Loop
                    sr.Close()
                End With
            End Using
            Me.lblsegmentlist.Text = ofd2.FileName
        End If
    End Sub

    Private Sub cmdinsert_Click(sender As Object, e As EventArgs) Handles cmdinsert.Click
        dgvsegmentation.Rows.Add()
    End Sub

    Private Sub cmdTDSegmentation_Click(sender As Object, e As EventArgs) Handles cmdTDSegmentation.Click
        Dim aa As Integer = 0
        For ii = 0 To dgvsegmentation.RowCount - 1
            aa = aa + HMSFtoF(dgvsegmentation.Rows(ii).Cells(3).Value)
        Next
        lblTDSegmentation.Text = FToHMSF(aa)
    End Sub

    Private Sub cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        dgvsegmentation.Rows.RemoveAt(dgvsegmentation.CurrentRow.Index)
    End Sub

    Private Sub dgvsegmentation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsegmentation.CellContentClick

    End Sub

    Private Sub dgvsegmentation_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsegmentation.CellValidated
        Dim aa As String = dgvsegmentation.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        If (e.ColumnIndex = 1 Or e.ColumnIndex = 2) And aa <> "" And Len(aa) <> 11 Then
            dgvsegmentation.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = formatashmsf(aa)
            dgvsegmentation.CurrentRow.Cells(3).Value = FToHMSF(HMSFtoF(dgvsegmentation.CurrentRow.Cells(2).Value) - HMSFtoF(dgvsegmentation.CurrentRow.Cells(1).Value))

        End If
    End Sub
    Function formatashmsf(aa As String) As String
        Dim str As String
        Dim hrs As String = Mid(aa, 1, 2)
        Dim mnts As String = Mid(aa, 3, 2)
        Dim sec As String = Mid(aa, 5, 2)
        Dim frm As String = Mid(aa, 7, 2)
        If mnts = "" Then mnts = "00"
        If sec = "" Then sec = "00"
        If frm = "" Then frm = "00"
        str = hrs & ":" & mnts & ":" & sec & ":" & frm
        Return str
    End Function

    Private Sub cmdclipcuttrimmer6_Click(sender As Object, e As EventArgs) Handles cmdclipcuttrimmer6.Click
        On Error Resume Next
        UcnewTrimmer11.osdcutfilename.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"
        UcnewTrimmer11.osdcutfilename.FileName = System.IO.Path.GetFileNameWithoutExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "_SD_Letter_Box"
        UcnewTrimmer11.osdcutfilename.FilterIndex = 3
        UcnewTrimmer11.osdcutfilename.Filter = "original wrapper (*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & ")|*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "|mp4 files (*.mp4)|*.mp4|mxf files (*.mxf)|*.mxf|avi files (*.avi)|*.avi|All files (*.*)|*.*"
        If (UcnewTrimmer11.osdcutfilename.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            cmdclipcuttrimmer6.Enabled = False
            'Process.Start("CMD", "/K " & "C:/casparcg/mydata/ffmpeg/ffmpeg.exe -y -i " & """" & ofdtrimmer.FileName & """" & " -ss " & FToHMSms(txtmarkintrimmer.Text) & " -to " & FToHMSms(txtmarkouttrimmer.Text) & " -c copy " & """" & osdcutfilename.FileName & """")
            bwforexportclip6.RunWorkerAsync()
        End If
    End Sub

    Private Sub bwforexportclip6_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwforexportclip6.DoWork
        On Error Resume Next
        exportclip6()
    End Sub
    Sub exportclip6()

        Dim strinout = " -ss " & FToHMSms(UcnewTrimmer11.txtmarkintrimmer.Text) & " -t " & FToHMSms(UcnewTrimmer11.txtmarkouttrimmer.Text - UcnewTrimmer11.txtmarkintrimmer.Text)
        Control.CheckForIllegalCrossThreadCalls = False
        Dim proc As New Process
        Dim startinfo As New System.Diagnostics.ProcessStartInfo
        Dim sr As StreamReader
        Dim cmd As String = "-y " & strinout & " -i " & """" & UcnewTrimmer11.ofdtrimmer.FileName & """" & " -vcodec " & cmbvideocodec6.Text & " -acodec " & cmbaudiocodec6.Text & " -b:v " & (Val(cmbbitrate6.Text) * 1000000) & " " & txtoptionstrimmer6.Text & " " & """" & UcnewTrimmer11.osdcutfilename.FileName & """"

        Dim ffmpegOutput As String

        ' all parameters required to run the process
        startinfo.FileName = "c:/casparcg/mydata/ffmpeg/ffmpeg.exe"
        startinfo.Arguments = cmd
        startinfo.UseShellExecute = False
        startinfo.WindowStyle = ProcessWindowStyle.Hidden
        startinfo.RedirectStandardError = True
        startinfo.RedirectStandardOutput = True
        startinfo.CreateNoWindow = True
        proc.StartInfo = startinfo
        proc.Start() ' start the process
        sr = proc.StandardError 'standard error is used by ffmpeg

        pbexportclip6.Maximum = UcnewTrimmer11.txtmarkouttrimmer.Text - UcnewTrimmer11.txtmarkintrimmer.Text
        lblexportclipinfo6.Text = ""
        Do
            ffmpegOutput = sr.ReadLine
            pbexportclip6.Value = Val(Mid(Split(ffmpegOutput, "fps")(0), 7))
            lblexportclipinfo6.Text = pbexportclip6.Value & " Frames"
        Loop Until proc.HasExited And ffmpegOutput = Nothing Or ffmpegOutput = ""
    End Sub

    Private Sub cmdExportClipwithTranscodingProfile_Click(sender As Object, e As EventArgs) Handles cmdExportClipwithTranscodingProfile.Click
        On Error Resume Next
        UcnewTrimmer11.osdcutfilename.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"

        UcTranscodingProfile1.getextensionfortranscoding()
        UcTranscodingProfile1.getstartinfofilename()

        UcnewTrimmer11.osdcutfilename.FileName = System.IO.Path.GetFileNameWithoutExtension(UcnewTrimmer11.ofdtrimmer.FileName) & UcTranscodingProfile1.strFileExtension
        UcnewTrimmer11.osdcutfilename.FilterIndex = 7
        UcnewTrimmer11.osdcutfilename.Filter = "original wrapper (*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & ")|*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "|mp4 files (*.mp4)|*.mp4|mov files (*.mov)|*.mov|mxf files (*.mxf)|*.mxf|mpg files (*.mpg)|*.mpg|avi files (*.avi)|*.avi|All files (*.*)|*.*"

        If UcnewTrimmer11.osdcutfilename.ShowDialog = DialogResult.OK Then
            With UcTranscodingProfile1
                .strinout = " -ss " & FToHMSms(UcnewTrimmer11.txtmarkintrimmer.Text) & " -t " & FToHMSms(UcnewTrimmer11.txtmarkouttrimmer.Text - UcnewTrimmer11.txtmarkintrimmer.Text)
                .ofdtrimmer.FileName = UcnewTrimmer11.ofdtrimmer.FileName
                .osdcutfilename.FileName = UcnewTrimmer11.osdcutfilename.FileName
                .gettranscodingcommand()
                Process.Start("CMD", "/K " & .startinfofilename & " " & .cmdtranscodingcommand)
                .strinout = ""
            End With
        End If
    End Sub

    Private Sub bwforexportclip6_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwforexportclip6.RunWorkerCompleted
        On Error Resume Next
        cmdclipcuttrimmer6.Enabled = True
        pbexportclip6.Value = pbexportclip6.Maximum
        lblexportclipinfo6.Text = "Completed"
    End Sub

    Private Sub cmdclipcuttrimmer_Click(sender As Object, e As EventArgs) Handles cmdclipcuttrimmer.Click
        On Error Resume Next

        Dim strinout = " -ss " & FToHMSms(UcnewTrimmer11.txtmarkintrimmer.Text) & " -t " & FToHMSms(UcnewTrimmer11.txtmarkouttrimmer.Text - UcnewTrimmer11.txtmarkintrimmer.Text)

        UcnewTrimmer11.osdcutfilename.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"
        UcnewTrimmer11.osdcutfilename.FileName = System.IO.Path.GetFileNameWithoutExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "_Transcoded"
        UcnewTrimmer11.osdcutfilename.FilterIndex = 2
        UcnewTrimmer11.osdcutfilename.Filter = "original wrapper (*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & ")|*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "|mp4 files (*.mp4)|*.mp4|avi files (*.avi)|*.avi|All files (*.*)|*.*"
        If (UcnewTrimmer11.osdcutfilename.ShowDialog() = Windows.Forms.DialogResult.OK) Then

            Process.Start("CMD", "/K " & "C:/casparcg/mydata/ffmpeg/ffmpeg.exe -y " & strinout & " -i " & """" & UcnewTrimmer11.ofdtrimmer.FileName & """" & " -vcodec " & cmbvideocodec.Text & " -acodec " & cmbaudiocodec.Text & " -b:v " & Val(cmbbitrate.Text) * 1000000 & " " & txtoptionstrimmer.Text & " " & """" & UcnewTrimmer11.osdcutfilename.FileName & """")
        End If
    End Sub

    Private Sub cmdExportSegments_Click(sender As Object, e As EventArgs) Handles cmdExportSegments.Click
        On Error Resume Next

        Dim osdtrimmer As New SaveFileDialog
        osdtrimmer.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"

        Dim bb As New FolderBrowserDialog
        bb.SelectedPath = osdtrimmer.InitialDirectory
        If bb.ShowDialog = DialogResult.OK Then
            For aa = 0 To dgvsegmentation.Rows.Count - 1
                If dgvsegmentation.Rows(aa).Cells(1).Value = "" Then Exit For
                osdtrimmer.FileName = System.IO.Path.GetFileNameWithoutExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "_Cut" & aa + 1

                UcnewTrimmer11.osdcutfilename.FileName = (bb.SelectedPath & "/" & dgvsegmentation.Rows(aa).Cells(0).Value.ToString & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName))
                Process.Start("CMD", "/K " & "C:/casparcg/mydata/ffmpeg/ffmpeg.exe -y -i " & """" & UcnewTrimmer11.ofdtrimmer.FileName & """" & " -ss " & FToHMSms(HMSFtoF(dgvsegmentation.Rows(aa).Cells(1).Value)) & " -t " & FToHMSms(HMSFtoF(dgvsegmentation.Rows(aa).Cells(3).Value)) & " -c copy " & """" & UcnewTrimmer11.osdcutfilename.FileName & """")
            Next
            MsgBox("Sub Clips are being exported in " & bb.SelectedPath)
        End If

    End Sub

    Private Sub cmdexportsubclipsinTranscodingProfile_Click(sender As Object, e As EventArgs) Handles cmdexportsubclipsinTranscodingProfile.Click
        On Error Resume Next
        UcnewTrimmer11.osdcutfilename.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"

        UcTranscodingProfile1.getextensionfortranscoding()
        UcTranscodingProfile1.getstartinfofilename()

        UcnewTrimmer11.osdcutfilename.FileName = System.IO.Path.GetFileNameWithoutExtension(UcnewTrimmer11.ofdtrimmer.FileName) & UcTranscodingProfile1.strFileExtension
        UcnewTrimmer11.osdcutfilename.FilterIndex = 7
        UcnewTrimmer11.osdcutfilename.Filter = "original wrapper (*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & ")|*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "|mp4 files (*.mp4)|*.mp4|mov files (*.mov)|*.mov|mxf files (*.mxf)|*.mxf|mpg files (*.mpg)|*.mpg|avi files (*.avi)|*.avi|All files (*.*)|*.*"


        Dim osdtrimmer As New SaveFileDialog
        osdtrimmer.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"

        Dim bb As New FolderBrowserDialog
        bb.SelectedPath = osdtrimmer.InitialDirectory
        If bb.ShowDialog = DialogResult.OK Then
            For aa = 0 To dgvsegmentation.Rows.Count - 1
                If dgvsegmentation.Rows(aa).Cells(1).Value = "" Then Exit For
                With UcTranscodingProfile1
                    .strinout = " -ss " & FToHMSms(HMSFtoF(dgvsegmentation.Rows(aa).Cells(1).Value)) & " -t " & FToHMSms(HMSFtoF(dgvsegmentation.Rows(aa).Cells(3).Value)) '" -ss " & FToHMSms(UcnewTrimmer11.txtmarkintrimmer.Text) & " -t " & FToHMSms(UcnewTrimmer11.txtmarkouttrimmer.Text - UcnewTrimmer11.txtmarkintrimmer.Text)
                    .ofdtrimmer.FileName = UcnewTrimmer11.ofdtrimmer.FileName
                    .osdcutfilename.FileName = bb.SelectedPath & "/" & System.IO.Path.GetFileNameWithoutExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "_Cut" & aa + 1 & UcTranscodingProfile1.strFileExtension
                    .gettranscodingcommand()
                    Process.Start("CMD", "/K " & .startinfofilename & " " & .cmdtranscodingcommand)
                    .strinout = ""
                End With
            Next
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        dgvsegmentation.Rows.Clear()
        dgvsegmentation.Rows.Add(5)
        Me.lblsegmentlist.Text = ""
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        opensegmentlist()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        savesegmentlist(lblsegmentlist.Text)
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        saveassegmentlist()
    End Sub

    Private Sub UcnewTrimmer11_Load(sender As Object, e As EventArgs) Handles UcnewTrimmer11.Load

    End Sub

    Private Sub cmdBlackDetect_Click(sender As Object, e As EventArgs) Handles cmdBlackDetect.Click
        On Error Resume Next
        Process.Start("CMD", "/K " & "C:/casparcg/mydata/ffmpeg/ffmpeg.exe -i " & """" & UcnewTrimmer11.ofdtrimmer.FileName & """" & " -vf blackdetect -an -f null -")
    End Sub

    Private Sub cmdFreezeDetect_Click(sender As Object, e As EventArgs) Handles cmdFreezeDetect.Click
        On Error Resume Next
        Process.Start("CMD", "/K " & "C:/casparcg/mydata/ffmpeg/ffmpeg.exe -i " & """" & UcnewTrimmer11.ofdtrimmer.FileName & """" & " -vf freezedetect -an -f null -")
    End Sub

    Private Sub dgvjoiner_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvjoiner.CellContentClick
        On Error Resume Next
        If dgvjoiner.Columns(e.ColumnIndex).Name = "Openfile" Then

            Dim ofdjoin1 As New OpenFileDialog
            ofdjoin1.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"
            ofdjoin1.Filter = "All files (*.*)|*.*|mpg files (*.mpg)|*.mpg|avi files (*.avi)|*.avi|mp4 files (*.mp4)|*.mp4"
            If (ofdjoin1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                dgvjoiner.CurrentRow.Cells("File").Value = ofdjoin1.FileName
            End If
        End If
    End Sub

    Private Sub VlcLogo_Click(sender As Object, e As EventArgs) Handles vlcLogo.Click


    End Sub

    Private Sub CmdOpenLogo_Click(sender As Object, e As EventArgs) Handles cmdOpenLogo.Click
        On Error Resume Next
        'Dim openlogoforexport As New OpenFileDialog
        If openlogoforexport.ShowDialog = Windows.Forms.DialogResult.OK Then
            'piclogoforexport.ImageLocation = openlogoforexport.FileName
            vlcLogo.VlcMediaPlayer.SetMedia(New Uri(openlogoforexport.FileName))
            vlcLogo.VlcMediaPlayer.Play()
        End If

    End Sub

    Private Sub MarkInGraphics_Click(sender As Object, e As EventArgs) Handles markInGraphics.Click
        dgvgraphics.CurrentRow.Cells(2).Value = (UcnewTrimmer11.lblcurrentframetrimmer.Text) / fps
    End Sub

    Private Sub CmdExportGrapchics_Click(sender As Object, e As EventArgs) Handles cmdExportGrapchics.Click
        'On Error Resume Next
        Dim strinputfiles As String = ""
        Dim strfiltercomplex As String = ""
        Dim j As Integer = -1

        Dim intmaxcount As Integer = -1
        For kk = 0 To dgvgraphics.RowCount - 1
            If dgvgraphics.Rows(kk).Cells(0).Value <> "" Then
                If dgvgraphics.Rows(kk).Cells(2).Value IsNot Nothing Then
                    If dgvgraphics.Rows(kk).Cells(3) IsNot Nothing Then
                        If (dgvgraphics.Rows(kk).Cells(2).Value < dgvgraphics.Rows(kk).Cells(3).Value) Then
                            intmaxcount += 1
                        End If
                    End If
                End If
            End If
        Next

        For ii = 0 To dgvgraphics.RowCount - 1
            If dgvgraphics.Rows(ii).Cells(0).Value <> "" Then
                If dgvgraphics.Rows(ii).Cells(2).Value IsNot Nothing Then
                    If dgvgraphics.Rows(ii).Cells(3).Value IsNot Nothing Then
                        If (dgvgraphics.Rows(ii).Cells(2).Value < dgvgraphics.Rows(ii).Cells(3).Value) Then

                            j = j + 1
                            strinputfiles &= " -i " & """" & dgvgraphics.Rows(ii).Cells(0).Value & """"
                            If j = 0 Then
                                If j = intmaxcount Then
                                    strfiltercomplex &= "[" & j & "][" & (j + 1) & "]overlay=x=0:y=0:enable='between(t," & dgvgraphics.Rows(ii).Cells(2).Value & "," & dgvgraphics.Rows(ii).Cells(3).Value & ")'[v" & (j + 1) & "]"
                                Else
                                    strfiltercomplex &= "[" & j & "][" & (j + 1) & "]overlay=x=0:y=0:enable='between(t," & dgvgraphics.Rows(ii).Cells(2).Value & "," & dgvgraphics.Rows(ii).Cells(3).Value & ")'[v" & (j + 1) & "];"
                                End If
                            Else
                                If j = intmaxcount Then
                                    strfiltercomplex &= "[v" & j & "][" & (j + 1) & "]overlay=x=0:y=0:enable='between(t," & dgvgraphics.Rows(ii).Cells(2).Value & "," & dgvgraphics.Rows(ii).Cells(3).Value & ")'[v" & (j + 1) & "]"
                                Else
                                    strfiltercomplex &= "[v" & j & "][" & (j + 1) & "]overlay=x=0:y=0:enable='between(t," & dgvgraphics.Rows(ii).Cells(2).Value & "," & dgvgraphics.Rows(ii).Cells(3).Value & ")'[v" & (j + 1) & "];"
                                End If
                            End If

                        End If
                    End If
                End If
            End If
        Next


        'Process.Start("CMD", "/K " & "C:/casparcg/mydata/ffmpeg/ffmpeg.exe -y  -i " & """" & ofdtrimmer.FileName & """" & " -i " & """" & dgvjoiner.Rows(0).Cells(0).Value & """" & " -i " & """" & dgvjoiner.Rows(1).Cells(0).Value & """" & " -i " & """" & dgvjoiner.Rows(2).Cells(0).Value & """" & " -filter_complex " & """" & " [0][1]overlay=x=0:y=0:enable='between(t," & dgvjoiner.Rows(0).Cells(2).Value & "," & dgvjoiner.Rows(0).Cells(3).Value & ")'[v1];[v1][2]overlay=x=0:y=0:enable='between(t," & dgvjoiner.Rows(1).Cells(2).Value & "," & dgvjoiner.Rows(1).Cells(3).Value & ")'[v2];[v2][3]overlay=x=0:y=0:enable='between(t," & dgvjoiner.Rows(2).Cells(2).Value & "," & dgvjoiner.Rows(2).Cells(3).Value & ")'[v3]" & """" & " -map " & """" & "[v3]" & """" & " -map 0:a d:/test2.mp4")
        'Process.Start("CMD", "/K " & "C:/casparcg/mydata/ffmpeg/ffmpeg.exe -y  -i " & """" & ofdtrimmer.FileName & """" & strinputfiles & " -filter_complex " & """" & "[0][1]overlay=x=0:y=0:enable='between(t," & dgvjoiner.Rows(0).Cells(2).Value & "," & dgvjoiner.Rows(0).Cells(3).Value & ")'[v1];[v1][2]overlay=x=0:y=0:enable='between(t," & dgvjoiner.Rows(1).Cells(2).Value & "," & dgvjoiner.Rows(1).Cells(3).Value & ")'[v2];[v2][3]overlay=x=0:y=0:enable='between(t," & dgvjoiner.Rows(2).Cells(2).Value & "," & dgvjoiner.Rows(2).Cells(3).Value & ")'[v3]" & """" & " -map " & """" & "[v3]" & """" & " -map 0:a d:/test2.mp4")


        UcnewTrimmer11.osdcutfilename.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"
        UcnewTrimmer11.osdcutfilename.FileName = System.IO.Path.GetFileNameWithoutExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "_WithGraphics"
        UcnewTrimmer11.osdcutfilename.FilterIndex = 1
        UcnewTrimmer11.osdcutfilename.Filter = "original wrapper (*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & ")|*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "|mp4 files (*.mp4)|*.mp4|mxf files (*.mxf)|*.mxf|avi files (*.avi)|*.avi|All files (*.*)|*.*"

        If (UcnewTrimmer11.osdcutfilename.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Process.Start("CMD", "/K " & "C:/casparcg/mydata/ffmpeg/ffmpeg.exe -y  -i " & """" & UcnewTrimmer11.ofdtrimmer.FileName & """" & strinputfiles & " -filter_complex " & """" & strfiltercomplex & """" & " -map " & """" & "[v" & (intmaxcount + 1) & "]" & """" & " -map 0:a " & """" & UcnewTrimmer11.osdcutfilename.FileName & """")

        End If

    End Sub

    Private Sub MarkOutGraphics_Click(sender As Object, e As EventArgs) Handles markOutGraphics.Click
        dgvgraphics.CurrentRow.Cells(3).Value = (UcnewTrimmer11.lblcurrentframetrimmer.Text) / fps
    End Sub

    Private Sub GotoInGraphics_Click(sender As Object, e As EventArgs) Handles GotoInGraphics.Click
        UcnewTrimmer11.vlc1.VlcMediaPlayer.Time = (dgvgraphics.CurrentRow.Cells(2).Value) * 1000
    End Sub

    Private Sub GotoOutGraphics_Click(sender As Object, e As EventArgs) Handles gotoOutGraphics.Click
        UcnewTrimmer11.vlc1.VlcMediaPlayer.Time = (dgvgraphics.CurrentRow.Cells(3).Value) * 1000
    End Sub

    Private Sub Dgvgraphics_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvgraphics.CellContentClick
        On Error Resume Next
        If dgvgraphics.Columns(e.ColumnIndex).Name = "pngOpen" Then

            Dim ofdjoin1 As New OpenFileDialog
            ofdjoin1.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"
            ofdjoin1.Filter = "png files (*.png)|*.png|All files (*.*)|*.*|jpg files (*.jpg)|*.jpg|jpeg files (*.jpeg)|*.jpeg"
            ofdjoin1.Title = "Open a PNG file"
            If (ofdjoin1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                dgvgraphics.CurrentRow.Cells(0).Value = ofdjoin1.FileName
            End If
        End If
    End Sub
    Private Sub CmdFontColor_Click(sender As Object, e As EventArgs) Handles cmdFontColor.Click
        Dim aa As New ColorDialog
        If aa.ShowDialog = DialogResult.OK Then
            cmdStripColor.ForeColor = aa.Color
            cmdFontColor.ForeColor = aa.Color
        End If
    End Sub
    Private Sub CmdStripColor_Click(sender As Object, e As EventArgs) Handles cmdStripColor.Click
        Dim aa As New ColorDialog
        If aa.ShowDialog = DialogResult.OK Then
            cmdStripColor.BackColor = aa.Color
            cmdFontColor.BackColor = aa.Color
        End If
    End Sub
    Private Sub MarkInGraphics2_Click(sender As Object, e As EventArgs) Handles markInGraphics2.Click
        dgvgraphics2.CurrentRow.Cells(1).Value = (UcnewTrimmer11.lblcurrentframetrimmer.Text) / fps
    End Sub
    Private Sub MarkOutGraphics2_Click(sender As Object, e As EventArgs) Handles markOutGraphics2.Click
        dgvgraphics2.CurrentRow.Cells(2).Value = (UcnewTrimmer11.lblcurrentframetrimmer.Text) / fps
    End Sub

    Private Sub GotoInGraphics2_Click(sender As Object, e As EventArgs) Handles GotoInGraphics2.Click
        UcnewTrimmer11.vlc1.VlcMediaPlayer.Time = (dgvgraphics2.CurrentRow.Cells(1).Value) * 1000
    End Sub

    Private Sub GotoOutGraphics2_Click(sender As Object, e As EventArgs) Handles gotoOutGraphics2.Click
        UcnewTrimmer11.vlc1.VlcMediaPlayer.Time = (dgvgraphics2.CurrentRow.Cells(2).Value) * 1000
    End Sub

    Private Sub CmdExportGrapchics2_Click(sender As Object, e As EventArgs) Handles cmdExportGrapchics2.Click
        On Error Resume Next
        Dim strinputfiles As String = ""
        Dim strfiltercomplex As String = ""
        Dim j As Integer = -1

        Dim intmaxcount As Integer = -1
        For kk = 0 To dgvgraphics2.RowCount - 1
            If dgvgraphics2.Rows(kk).Cells(0).Value <> "" Then
                If dgvgraphics2.Rows(kk).Cells(1).Value IsNot Nothing Then
                    If dgvgraphics2.Rows(kk).Cells(2) IsNot Nothing Then
                        If (dgvgraphics2.Rows(kk).Cells(1).Value < dgvgraphics2.Rows(kk).Cells(2).Value) Then
                            intmaxcount += 1
                        End If
                    End If
                End If
            End If
        Next

        For ii = 0 To dgvgraphics2.RowCount - 1
            If dgvgraphics2.Rows(ii).Cells(0).Value <> "" Then
                If dgvgraphics2.Rows(ii).Cells(1).Value IsNot Nothing Then
                    If dgvgraphics2.Rows(ii).Cells(2).Value IsNot Nothing Then
                        If (dgvgraphics2.Rows(ii).Cells(1).Value < dgvgraphics2.Rows(ii).Cells(2).Value) Then

                            j = j + 1
                            If j = intmaxcount Then
                                strfiltercomplex += "drawtext=text='" & dgvgraphics2.Rows(ii).Cells(0).Value & "':x=(w-tw)/2:y=(h-50):fontcolor=" & ColorTranslator.ToHtml(cmdStripColor.ForeColor) & ":fontsize=" & cmbFontSize.Text & ":box=1:boxcolor=" & ColorTranslator.ToHtml(cmdStripColor.BackColor) & ":boxborderw=6:borderw=1:fontfile='c\:/windows/fonts/" & cmbfont.Text & "':enable='between(t," & dgvgraphics2.Rows(ii).Cells(1).Value & "," & dgvgraphics2.Rows(ii).Cells(2).Value & ")'"

                            Else
                                strfiltercomplex += "drawtext=text='" & dgvgraphics2.Rows(ii).Cells(0).Value & "':x=(w-tw)/2:y=(h-50):fontcolor=" & ColorTranslator.ToHtml(cmdStripColor.ForeColor) & ":fontsize=" & cmbFontSize.Text & ":box=1:boxcolor=" & ColorTranslator.ToHtml(cmdStripColor.BackColor) & ":boxborderw=6:borderw=1:fontfile='c\:/windows/fonts/" & cmbfont.Text & "':enable='between(t," & dgvgraphics2.Rows(ii).Cells(1).Value & "," & dgvgraphics2.Rows(ii).Cells(2).Value & ")',"

                            End If

                        End If
                    End If
                End If
            End If
        Next

        UcnewTrimmer11.osdcutfilename.InitialDirectory = Replace(mediafullpath, "/", "\")  '"c:\casparcg\_media\"
        UcnewTrimmer11.osdcutfilename.FileName = System.IO.Path.GetFileNameWithoutExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "_WithGraphics"
        UcnewTrimmer11.osdcutfilename.FilterIndex = 1
        UcnewTrimmer11.osdcutfilename.Filter = "original wrapper (*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & ")|*" & System.IO.Path.GetExtension(UcnewTrimmer11.ofdtrimmer.FileName) & "|mp4 files (*.mp4)|*.mp4|mxf files (*.mxf)|*.mxf|avi files (*.avi)|*.avi|All files (*.*)|*.*"

        If (UcnewTrimmer11.osdcutfilename.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Process.Start("CMD", "/K " & "C:/casparcg/mydata/ffmpeg/ffmpeg.exe -y  -i " & """" & UcnewTrimmer11.ofdtrimmer.FileName & """" & " -vf " & """" & "[in]" & strfiltercomplex & """" & " " & """" & UcnewTrimmer11.osdcutfilename.FileName & """")
            'MsgBox("CMD", "/K " & "C:/casparcg/mydata/ffmpeg/ffmpeg.exe -y  -i " & """" & UcnewTrimmer11.ofdtrimmer.FileName & """" & " -vf " & """" & "[in]" & strfiltercomplex & """" & " " & """" & UcnewTrimmer11.osdcutfilename.FileName & """")
        End If
    End Sub

    Private Sub Cmbfont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfont.SelectedIndexChanged
        On Error Resume Next
        Dim fontCol As PrivateFontCollection = New PrivateFontCollection()
        fontCol.AddFontFile("c:/windows/fonts/" & cmbfont.SelectedItem.ToString)
        Dim myfont As New Font(fontCol.Families(0).Name, 10, FontStyle.Bold)
        dgvgraphics2.Columns(0).DefaultCellStyle.Font = myfont

    End Sub

    Private Sub cmdstripcolor1_Click(sender As Object, e As EventArgs) Handles cmdstripcolor1.Click
        Dim ss As New ColorDialog
        If ss.ShowDialog = DialogResult.OK Then
            cmdstripcolor1.BackColor = ss.Color
            cmdfontcolor1.BackColor = ss.Color
        End If
    End Sub

    Private Sub cmdfontcolor1_Click(sender As Object, e As EventArgs) Handles cmdfontcolor1.Click
        Dim ss As New ColorDialog
        If ss.ShowDialog = DialogResult.OK Then
            cmdstripcolor1.ForeColor = ss.Color
            cmdfontcolor1.ForeColor = ss.Color
        End If
    End Sub
End Class



