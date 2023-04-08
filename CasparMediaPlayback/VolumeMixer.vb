Imports System.Runtime.InteropServices

Public Class VolumeMixer
    Public Shared Function GetApplicationVolume(ByVal pid As Integer) As Single?
        Dim volume As ISimpleAudioVolume = GetVolumeObject(pid)
        If volume Is Nothing Then Return Nothing
        Dim level As Single
        volume.GetMasterVolume(level)
        Marshal.ReleaseComObject(volume)
        Return level * 100
    End Function

    Public Shared Function GetApplicationMute(ByVal pid As Integer) As Boolean?
        Dim volume As ISimpleAudioVolume = GetVolumeObject(pid)
        If volume Is Nothing Then Return Nothing
        Dim mute As Boolean
        volume.GetMute(mute)
        Marshal.ReleaseComObject(volume)
        Return mute
    End Function

    Public Shared Sub SetApplicationVolume(ByVal pid As Integer, ByVal level As Single)
        Dim volume As ISimpleAudioVolume = GetVolumeObject(pid)
        If volume Is Nothing Then Return
        Dim guid As Guid = Guid.Empty
        volume.SetMasterVolume(level / 100, guid)
        Marshal.ReleaseComObject(volume)
    End Sub

    Public Shared Sub SetApplicationMute(ByVal pid As Integer, ByVal mute As Boolean)
        Dim volume As ISimpleAudioVolume = GetVolumeObject(pid)
        If volume Is Nothing Then Return
        Dim guid As Guid = Guid.Empty
        volume.SetMute(mute, guid)
        Marshal.ReleaseComObject(volume)
    End Sub

    Private Shared Function GetVolumeObject(ByVal pid As Integer) As ISimpleAudioVolume
        Dim deviceEnumerator As IMMDeviceEnumerator = CType((New MMDeviceEnumerator()), IMMDeviceEnumerator)
        Dim speakers As IMMDevice
        deviceEnumerator.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia, speakers)
        Dim IID_IAudioSessionManager2 As Guid = GetType(IAudioSessionManager2).GUID
        Dim o As Object
        speakers.Activate(IID_IAudioSessionManager2, 0, IntPtr.Zero, o)
        Dim mgr As IAudioSessionManager2 = CType(o, IAudioSessionManager2)
        Dim sessionEnumerator As IAudioSessionEnumerator
        mgr.GetSessionEnumerator(sessionEnumerator)
        Dim count As Integer
        sessionEnumerator.GetCount(count)
        Dim volumeControl As ISimpleAudioVolume = Nothing

        For i As Integer = 0 To count - 1
            Dim ctl As IAudioSessionControl2
            sessionEnumerator.GetSession(i, ctl)
            Dim cpid As Integer
            ctl.GetProcessId(cpid)

            If cpid = pid Then
                volumeControl = TryCast(ctl, ISimpleAudioVolume)
                Exit For
            End If

            Marshal.ReleaseComObject(ctl)
        Next

        Marshal.ReleaseComObject(sessionEnumerator)
        Marshal.ReleaseComObject(mgr)
        Marshal.ReleaseComObject(speakers)
        Marshal.ReleaseComObject(deviceEnumerator)
        Return volumeControl
    End Function
End Class


<ComImport>
<Guid("BCDE0395-E52F-467C-8E3D-C4579291692E")>
Friend Class MMDeviceEnumerator
End Class

Friend Enum EDataFlow
    eRender
    eCapture
    eAll
    EDataFlow_enum_count
End Enum

Friend Enum ERole
    eConsole
    eMultimedia
    eCommunications
    ERole_enum_count
End Enum

<Guid("A95664D2-9614-4F35-A746-DE8DB63617E6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
Friend Interface IMMDeviceEnumerator
    Function NotImpl1() As Integer
    <PreserveSig>
    Function GetDefaultAudioEndpoint(ByVal dataFlow As EDataFlow, ByVal role As ERole, <Out> ByRef ppDevice As IMMDevice) As Integer
End Interface

<Guid("D666063F-1587-4E43-81F1-B948E807363F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
Friend Interface IMMDevice
    <PreserveSig>
    Function Activate(ByRef iid As Guid, ByVal dwClsCtx As Integer, ByVal pActivationParams As IntPtr, <Out>
    <MarshalAs(UnmanagedType.IUnknown)> ByRef ppInterface As Object) As Integer
End Interface

<Guid("77AA99A0-1BD6-484F-8BC7-2C654C9A9B6F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
Friend Interface IAudioSessionManager2
    Function NotImpl1() As Integer
    Function NotImpl2() As Integer
    <PreserveSig>
    Function GetSessionEnumerator(<Out> ByRef SessionEnum As IAudioSessionEnumerator) As Integer
End Interface

<Guid("E2F5BB11-0570-40CA-ACDD-3AA01277DEE8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
Friend Interface IAudioSessionEnumerator
    <PreserveSig>
    Function GetCount(<Out> ByRef SessionCount As Integer) As Integer
    <PreserveSig>
    Function GetSession(ByVal SessionCount As Integer, <Out> ByRef Session As IAudioSessionControl2) As Integer
End Interface

<Guid("87CE5498-68D6-44E5-9215-6DA47EF883D8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
Friend Interface ISimpleAudioVolume
    <PreserveSig>
    Function SetMasterVolume(ByVal fLevel As Single, ByRef EventContext As Guid) As Integer
    <PreserveSig>
    Function GetMasterVolume(<Out> ByRef pfLevel As Single) As Integer
    <PreserveSig>
    Function SetMute(ByVal bMute As Boolean, ByRef EventContext As Guid) As Integer
    <PreserveSig>
    Function GetMute(<Out> ByRef pbMute As Boolean) As Integer
End Interface

<Guid("bfb7ff88-7239-4fc9-8fa2-07c950be9c6d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
Friend Interface IAudioSessionControl2
    <PreserveSig>
    Function NotImpl0() As Integer
    <PreserveSig>
    Function GetDisplayName(<Out>
    <MarshalAs(UnmanagedType.LPWStr)> ByRef pRetVal As String) As Integer
    <PreserveSig>
    Function SetDisplayName(
    <MarshalAs(UnmanagedType.LPWStr)> ByVal Value As String,
    <MarshalAs(UnmanagedType.LPStruct)> ByVal EventContext As Guid) As Integer
    <PreserveSig>
    Function GetIconPath(<Out>
    <MarshalAs(UnmanagedType.LPWStr)> ByRef pRetVal As String) As Integer
    <PreserveSig>
    Function SetIconPath(
    <MarshalAs(UnmanagedType.LPWStr)> ByVal Value As String,
    <MarshalAs(UnmanagedType.LPStruct)> ByVal EventContext As Guid) As Integer
    <PreserveSig>
    Function GetGroupingParam(<Out> ByRef pRetVal As Guid) As Integer
    <PreserveSig>
    Function SetGroupingParam(
    <MarshalAs(UnmanagedType.LPStruct)> ByVal Override As Guid,
    <MarshalAs(UnmanagedType.LPStruct)> ByVal EventContext As Guid) As Integer
    <PreserveSig>
    Function NotImpl1() As Integer
    <PreserveSig>
    Function NotImpl2() As Integer
    <PreserveSig>
    Function GetSessionIdentifier(<Out>
    <MarshalAs(UnmanagedType.LPWStr)> ByRef pRetVal As String) As Integer
    <PreserveSig>
    Function GetSessionInstanceIdentifier(<Out>
    <MarshalAs(UnmanagedType.LPWStr)> ByRef pRetVal As String) As Integer
    <PreserveSig>
    Function GetProcessId(<Out> ByRef pRetVal As Integer) As Integer
    <PreserveSig>
    Function IsSystemSoundsSession() As Integer
    <PreserveSig>
    Function SetDuckingPreference(ByVal optOut As Boolean) As Integer
End Interface
