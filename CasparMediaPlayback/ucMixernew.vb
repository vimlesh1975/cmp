Imports System.Xml
Public Class ucMixernew
    Private Sub cmdresetcropmixer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresetcropmixer.Click
        On Error Resume Next
        resetcropmixer()
    End Sub
    Sub resetcropmixer()
        On Error Resume Next
        ncroptlx.Value = 0
        ncroptly.Value = 0
        ncropbrx.Value = 1
        ncropbry.Value = 1
    End Sub
    Sub mixercrop() Handles ncroptlx.ValueChanged, ncroptly.ValueChanged, ncropbrx.ValueChanged, ncropbry.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " crop " & Replace(ncroptlx.Value, ",", ".") & " " & Replace(ncroptly.Value, ",", ".") & " " & Replace(ncropbrx.Value, ",", ".") & " " & Replace(ncropbry.Value, ",", "."))
    End Sub

    Private Sub chkmipmapmixer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkmipmapmixer.CheckedChanged
        If chkmipmapmixer.Checked Then
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " mipmap 1")
        Else
            CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " mipmap 0")
        End If
    End Sub
    Private Sub cmdresetperspectivemixer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresetperspectivemixer.Click
        On Error Resume Next
        resetperpectivemixer()

    End Sub
    Sub resetperpectivemixer()
        On Error Resume Next
        nperspectivetlx.Value = 0
        nperspectivetly.Value = 0

        nperspectivetrx.Value = 1
        nperspectivetry.Value = 0

        nperspectivebrx.Value = 1
        nperspectivebry.Value = 1

        nperspectiveblx.Value = 0
        nperspectivebly.Value = 1
    End Sub
    Private Sub cmdmixerclearformixemodule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmixerclearformixemodule.Click
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & " clear")
    End Sub
    Private Sub nopacity_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nopacity.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " opacity " & Replace(nopacity.Value, ",", "."))

    End Sub

    Private Sub cmdopacity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdopacity.Click
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " opacity 1")
        nopacity.Value = 1
    End Sub

    Private Sub nbrightness_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nbrightness.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " brightness " & Replace(nbrightness.Value, ",", "."))

    End Sub

    Private Sub cmdbrightness_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbrightness.Click
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " brightness 1")
        nbrightness.Value = 1
    End Sub

    Private Sub nSaturation_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nSaturation.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " saturation " & Replace(nSaturation.Value, ",", "."))

    End Sub

    Private Sub cmdSaturation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaturation.Click
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " saturation 1")
        nSaturation.Value = 1

    End Sub

    Private Sub nContrast_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nContrast.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " contrast " & Replace(nContrast.Value, ",", "."))

    End Sub

    Private Sub cmdContrast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdContrast.Click
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " contrast 1")
        nContrast.Value = 1

    End Sub

    Private Sub nmin_input_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nmin_input.ValueChanged, nmax_input.ValueChanged, ngamma.ValueChanged, nmin_output.ValueChanged, nmax_output.ValueChanged

        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " levels " & Replace(nmin_input.Value, ",", ".") & " " & Replace(nmax_input.Value, ",", ".") & " " & Replace(ngamma.Value, ",", ".") & " " & Replace(nmin_output.Value, ",", ".") & " " & Replace(nmax_output.Value, ",", "."))
    End Sub

    Private Sub cmdmixersettingopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmixersettingopen.Click
        On Error Resume Next
        mixersettingopen()
    End Sub
    Private Sub mixersettingopen()
        On Error Resume Next
        Dim ofd2 As New OpenFileDialog
        ofd2.InitialDirectory = "c:\casparcg\mydata\mixer\"
        ofd2.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
        If (ofd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Dim response As New MSXML2.DOMDocument60
            response.load(ofd2.FileName)

            Dim instance As MSXML2.IXMLDOMElement
            instance = response.getElementsByTagName("mixer").item(0)
            For Each aa As Control In gbMixer.Controls
                aa.Text = instance.getAttribute(aa.Name)
            Next

            instance = (response.getElementsByTagName("Others").item(0))
            For Each aa As Control In gbothers.Controls
                aa.Text = instance.getAttribute(aa.Name)
            Next

            instance = (response.getElementsByTagName("clip").item(0))
            For Each aa As Control In gbclip.Controls
                aa.Text = instance.getAttribute(aa.Name)
            Next

            instance = (response.getElementsByTagName("levels").item(0))
            For Each aa As Control In gblevels.Controls
                aa.Text = instance.getAttribute(aa.Name)
            Next

            instance = (response.getElementsByTagName("fill").item(0))
            For Each aa As Control In gbfill.Controls
                aa.Text = instance.getAttribute(aa.Name)
            Next

            instance = (response.getElementsByTagName("rotation").item(0))
            For Each aa As Control In gbrotationmixer.Controls
                aa.Text = instance.getAttribute(aa.Name)
            Next

            instance = (response.getElementsByTagName("anchor").item(0))
            For Each aa As Control In gbanchormixer.Controls
                aa.Text = instance.getAttribute(aa.Name)
            Next

            instance = (response.getElementsByTagName("perspective").item(0))
            For Each aa As Control In gbperspectivemixer.Controls
                aa.Text = instance.getAttribute(aa.Name)
            Next

            instance = (response.getElementsByTagName("crop").item(0))
            For Each aa As Control In gbcropmixer.Controls
                aa.Text = instance.getAttribute(aa.Name)
            Next

            instance = (response.getElementsByTagName("chkmipmapmixer").item(0))
            chkmipmapmixer.CheckState = instance.getAttribute("chkmipmapmixer")
        End If
    End Sub
    Private Sub cmdmixersettingsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmixersettingsave.Click
        mixersettingsave()
    End Sub
    Sub mixersettingsave()
        On Error Resume Next
        Dim osd2 As New SaveFileDialog
        osd2.InitialDirectory = "c:\casparcg\mydata\mixer\"
        osd2.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
        If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then


            Dim xmlsetting As New XmlWriterSettings
            xmlsetting.Indent = True
            Using writer As XmlWriter = XmlWriter.Create(osd2.FileName, xmlsetting)
                writer.WriteStartDocument() 'Document start

                writer.WriteStartElement("mixerdata") ' Root element.

                writer.WriteStartElement("mixer")
                For Each aa As Control In gbMixer.Controls
                    writer.WriteStartAttribute(aa.Name)
                    writer.WriteValue(aa.Text)
                Next
                writer.WriteEndElement()

                writer.WriteStartElement("Others")
                For Each aa As Control In gbothers.Controls
                    writer.WriteStartAttribute(aa.Name)
                    writer.WriteValue(aa.Text)
                Next
                writer.WriteEndElement()

                writer.WriteStartElement("clip")
                For Each aa As Control In gbclip.Controls
                    writer.WriteStartAttribute(aa.Name)
                    writer.WriteValue(aa.Text)
                Next
                writer.WriteEndElement()

                writer.WriteStartElement("levels")
                For Each aa As Control In gblevels.Controls
                    writer.WriteStartAttribute(aa.Name)
                    writer.WriteValue(aa.Text)
                Next
                writer.WriteEndElement()


                writer.WriteStartElement("fill")
                For Each aa As Control In gbfill.Controls
                    writer.WriteStartAttribute(aa.Name)
                    writer.WriteValue(aa.Text)
                Next
                writer.WriteEndElement()

                writer.WriteStartElement("rotation")
                For Each aa As Control In gbrotationmixer.Controls
                    writer.WriteStartAttribute(aa.Name)
                    writer.WriteValue(aa.Text)
                Next
                writer.WriteEndElement()

                writer.WriteStartElement("anchor")
                For Each aa As Control In gbanchormixer.Controls
                    writer.WriteStartAttribute(aa.Name)
                    writer.WriteValue(aa.Text)
                Next
                writer.WriteEndElement()

                writer.WriteStartElement("perspective")
                For Each aa As Control In gbperspectivemixer.Controls
                    writer.WriteStartAttribute(aa.Name)
                    writer.WriteValue(aa.Text)
                Next
                writer.WriteEndElement()


                writer.WriteStartElement("crop")
                For Each aa As Control In gbcropmixer.Controls
                    writer.WriteStartAttribute(aa.Name)
                    writer.WriteValue(aa.Text)
                Next
                writer.WriteEndElement()

                writer.WriteStartElement("chkmipmapmixer")
                writer.WriteStartAttribute("chkmipmapmixer")
                writer.WriteValue(chkmipmapmixer.CheckState)
                writer.WriteEndElement()

                writer.WriteEndElement() 'root element end

                writer.WriteEndDocument() 'Document end
            End Using
            'lblfilename.Text = osd2.FileName
        End If
    End Sub

    Private Sub cmdmixerclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmixerclear.Click
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " clear")

        mixerlevesreset()
        mixerclipreset()
        mixerfillreset()

        nVolume.Value = 1

        nopacity.Value = 1
        nbrightness.Value = 1
        nSaturation.Value = 1
        nContrast.Value = 1

        cmbblend.Text = "Normal"

        nmixermastervolume.Value = 1

        nanchorx.Value = 0
        nanchory.Value = 0
        nrotationz.Value = 0

        resetperpectivemixer()
        resetcropmixer()

    End Sub

    Private Sub cmdLevels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLevels.Click
        On Error Resume Next
        mixerlevesreset()
    End Sub
    Sub mixerlevesreset()
        On Error Resume Next
        nmin_input.Value = 0
        nmax_input.Value = 1
        ngamma.Value = 1
        nmin_output.Value = 0
        nmax_output.Value = 1
    End Sub
    Private Sub nmixermastervolume_ValueChanged(sender As Object, e As EventArgs) Handles nmixermastervolume.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & " mastervolume " & Replace(nmixermastervolume.Value, ",", "."))

    End Sub
    Private Sub nVolume_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nVolume.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " volume " & Replace(nVolume.Value, ",", "."))

    End Sub

    Private Sub cmdmastervolume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmastervolume.Click
        On Error Resume Next
        nmixermastervolume.Value = 1
    End Sub
    Private Sub cmdVolume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolume.Click
        On Error Resume Next
        nVolume.Value = 1
    End Sub

    Private Sub nfillx_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nfillx.ValueChanged, nfilly.ValueChanged, nfillwidth.ValueChanged, nfillheight.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " fill " & Replace(nfillx.Value, ",", ".") & " " & Replace(nfilly.Value, ",", ".") & " " & Replace(nfillwidth.Value, ",", ".") & " " & Replace(nfillheight.Value, ",", "."))

    End Sub

    Private Sub cmdfill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdfill.Click
        On Error Resume Next
        mixerfillreset()
    End Sub
    Sub mixerfillreset()
        On Error Resume Next
        nfillx.Value = 0
        nfilly.Value = 0
        nfillwidth.Value = 1
        nfillheight.Value = 1
    End Sub

    Private Sub nclipx_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nclipx.ValueChanged, nclipy.ValueChanged, nclipxsclae.ValueChanged, nclipyscale.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " clip " & Replace(nclipx.Value, ",", ".") & " " & Replace(nclipy.Value, ",", ".") & " " & Replace(nclipxsclae.Value, ",", ".") & " " & Replace(nclipyscale.Value, ",", "."))

    End Sub

    Private Sub cmdclipreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclipreset.Click
        On Error Resume Next
        mixerclipreset()
    End Sub
    Sub mixerclipreset()
        On Error Resume Next
        nclipx.Value = 0
        nclipy.Value = 0
        nclipxsclae.Value = 1
        nclipyscale.Value = 1
    End Sub
    Sub perspectivemixer() Handles nperspectivetlx.ValueChanged, nperspectivetly.ValueChanged, nperspectivetrx.ValueChanged, nperspectivetry.ValueChanged, nperspectivebrx.ValueChanged, nperspectivebry.ValueChanged, nperspectiveblx.ValueChanged, nperspectivebly.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " perspective " & Replace(nperspectivetlx.Value, ",", ".") & " " & Replace(nperspectivetly.Value, ",", ".") & " " & Replace(nperspectivetrx.Value, ",", ".") & " " & Replace(nperspectivetry.Value, ",", ".") & " " & Replace(nperspectivebrx.Value, ",", ".") & " " & Replace(nperspectivebry.Value, ",", ".") & " " & Replace(nperspectiveblx.Value, ",", ".") & " " & Replace(nperspectivebly.Value, ",", "."))

    End Sub
    Private Sub cmbblend_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbblend.SelectedIndexChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " blend " & cmbblend.Text)
    End Sub

    Private Sub nanchorx_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nanchorx.ValueChanged, nanchory.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " anchor " & Replace(nanchorx.Value, ",", ".") & " " & Replace(nanchory.Value, ",", "."))

    End Sub
    Private Sub nrotationz_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nrotationz.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " rotation " & Replace(nrotationz.Value, ",", "."))

    End Sub
    Private Sub cmdresetanchormixer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresetanchormixer.Click
        On Error Resume Next
        nanchorx.Value = 0
        nanchory.Value = 0
    End Sub
    Private Sub cmdresetrotationmixer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresetrotationmixer.Click
        On Error Resume Next
        nrotationz.Value = 0
    End Sub

    Private Async Sub cmdgetstatusofmixer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgetstatusofmixer.Click
        'On Error Resume Next
        getstausofmixer()
    End Sub
    Async Sub getstausofmixer()
        'On Error Resume Next
        'for fill
        Try


            SendString(NetStream, "mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " fill" + vbCrLf)

            'Threading.Thread.Sleep(150)
            Dim data(10024) As Byte
            NetStream.Read(data, 0, 10024)
            Dim returndata As String = ""
            returndata = System.Text.Encoding.UTF8.GetString(data)
            Dim a As Array = Split(returndata, vbNewLine)
            Dim b As Array = Split(a(1), " ")

            nfillx.Value = b(0)
            nfilly.Value = b(1)
            nfillwidth.Value = b(2)
            nfillheight.Value = b(3)

            'for clip
            SendString(NetStream, "mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " clip" + vbCrLf)
            'Threading.Thread.Sleep(150)
            NetStream.Read(data, 0, 10024)
            returndata = System.Text.Encoding.UTF8.GetString(data)
            a = Split(returndata, vbNewLine)
            b = Split(a(1), " ")
            nclipx.Value = b(0)
            nclipy.Value = b(1)
            nclipxsclae.Value = b(2)
            nclipyscale.Value = b(3)

            'for levels
            SendString(NetStream, "mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " levels" + vbCrLf)
            'Threading.Thread.Sleep(150)
            NetStream.Read(data, 0, 10024)
            returndata = System.Text.Encoding.UTF8.GetString(data)
            a = Split(returndata, vbNewLine)
            b = Split(a(1), " ")
            nmin_input.Value = b(0)
            nmax_input.Value = b(1)
            ngamma.Value = b(2)
            nmin_output.Value = b(3)
            nmax_output.Value = b(4)


            'for volume
            SendString(NetStream, "mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " volume" + vbCrLf)
            'Threading.Thread.Sleep(150)
            NetStream.Read(data, 0, 10024)
            returndata = System.Text.Encoding.UTF8.GetString(data)
            a = Split(returndata, vbNewLine)
            b = Split(a(1), " ")
            nVolume.Value = b(0)

            'for opacity
            SendString(NetStream, "mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " opacity" + vbCrLf)
            'Threading.Thread.Sleep(150)
            NetStream.Read(data, 0, 10024)
            returndata = System.Text.Encoding.UTF8.GetString(data)
            a = Split(returndata, vbNewLine)
            b = Split(a(1), " ")
            nopacity.Value = b(0)

            'for brightness
            SendString(NetStream, "mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " brightness" + vbCrLf)
            'Threading.Thread.Sleep(150)
            NetStream.Read(data, 0, 10024)
            returndata = System.Text.Encoding.UTF8.GetString(data)
            a = Split(returndata, vbNewLine)
            b = Split(a(1), " ")
            nbrightness.Value = b(0)

            'for saturation
            SendString(NetStream, "mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " saturation" + vbCrLf)
            'Threading.Thread.Sleep(150)
            NetStream.Read(data, 0, 10024)
            returndata = System.Text.Encoding.UTF8.GetString(data)
            a = Split(returndata, vbNewLine)
            b = Split(a(1), " ")
            nSaturation.Value = b(0)

            'for contrast
            SendString(NetStream, "mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " contrast" + vbCrLf)
            'Threading.Thread.Sleep(150)
            NetStream.Read(data, 0, 10024)
            returndata = System.Text.Encoding.UTF8.GetString(data)
            a = Split(returndata, vbNewLine)
            b = Split(a(1), " ")
            nContrast.Value = b(0)

            'for anchor
            SendString(NetStream, "mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " anchor" + vbCrLf)
            'Threading.Thread.Sleep(150)
            NetStream.Read(data, 0, 10024)
            returndata = System.Text.Encoding.UTF8.GetString(data)
            a = Split(returndata, vbNewLine)
            b = Split(a(1), " ")
            nanchorx.Value = b(0)
            nanchory.Value = b(1)

            'for rotation
            SendString(NetStream, "mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " rotation" + vbCrLf)
            'Threading.Thread.Sleep(150)
            NetStream.Read(data, 0, 10024)
            returndata = System.Text.Encoding.UTF8.GetString(data)
            a = Split(returndata, vbNewLine)
            b = Split(a(1), " ")
            nrotationz.Value = b(0)



            'for mastervolume
            SendString(NetStream, "mixer " & g_int_ChannelNumber & " mastervolume" + vbCrLf)
            'Threading.Thread.Sleep(150)
            NetStream.Read(data, 0, 10024)
            returndata = System.Text.Encoding.UTF8.GetString(data)
            a = Split(returndata, vbNewLine)
            b = Split(a(1), " ")
            nmixermastervolume.Value = b(0)

            'for blend
            SendString(NetStream, "mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " blend" + vbCrLf)
            'Threading.Thread.Sleep(150)
            NetStream.Read(data, 0, 10024)
            returndata = System.Text.Encoding.UTF8.GetString(data)
            a = Split(returndata, vbNewLine)
            b = Split(a(1), " ")
            cmbblend.Text = b(0)

            'for perspective
            SendString(NetStream, "mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " perspective" + vbCrLf)
            'Threading.Thread.Sleep(150)
            NetStream.Read(data, 0, 10024)
            returndata = System.Text.Encoding.UTF8.GetString(data)
            a = Split(returndata, vbNewLine)
            b = Split(a(1), " ")

            nperspectivetlx.Value = b(0)
            nperspectivetly.Value = b(1)

            nperspectivetrx.Value = b(2)
            nperspectivetry.Value = b(3)

            nperspectivebrx.Value = b(4)
            nperspectivebry.Value = b(5)

            nperspectiveblx.Value = b(6)
            nperspectivebly.Value = b(7)

            'for crop
            SendString(NetStream, "mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " crop" + vbCrLf)
            'Threading.Thread.Sleep(150)
            NetStream.Read(data, 0, 10024)
            returndata = System.Text.Encoding.UTF8.GetString(data)
            a = Split(returndata, vbNewLine)
            b = Split(a(1), " ")

            ncroptlx.Value = b(0)
            ncroptly.Value = b(1)

            ncropbrx.Value = b(2)
            ncropbry.Value = b(3)

            'For mipmap
            SendString(NetStream, "mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " mipmap" + vbCrLf)
                'Threading.Thread.Sleep(150)
                NetStream.Read(data, 0, 10024)
                returndata = System.Text.Encoding.UTF8.GetString(data)
                a = Split(returndata, vbNewLine)
                b = Split(a(1), " ")

                chkmipmapmixer.Checked = b(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbvideolayerformixer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvideolayerformixer.TextChanged
        On Error Resume Next
        'getstausofmixer()
    End Sub
    'Mixer code ends---------------------------
    Private Sub cmdhidegbmixer_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub ucMixer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub nscalexfromCenter_ValueChanged(sender As Object, e As EventArgs) Handles nscalexfromCenter.ValueChanged, nscaleyfromCenter.ValueChanged
        On Error Resume Next
        CasparDevice.SendString("mixer " & g_int_ChannelNumber & "-" & cmbvideolayerformixer.Text & " fill " & Replace(((1 - nscalexfromCenter.Value) / 2), ",", ".") & " " & Replace(((1 - nscaleyfromCenter.Value) / 2), ",", ".") & " " & Replace(nscalexfromCenter.Value, ",", ".") & " " & Replace(nscaleyfromCenter.Value, ",", "."))

    End Sub

    Private Sub cmdResetScalefromCenter_Click(sender As Object, e As EventArgs) Handles cmdResetScalefromCenter.Click
        On Error Resume Next
        nscalexfromCenter.Value = 1
        nscaleyfromCenter.Value = 1
    End Sub

    Private Sub GbMixer_Enter(sender As Object, e As EventArgs) Handles gbMixer.Enter

    End Sub
End Class
