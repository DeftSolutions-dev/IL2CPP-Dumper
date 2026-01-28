// ========================================================
// Dumped by @desirepro
// Assembly: Beyond.NativeSDK.dll
// Classes:  16
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000003
    public struct PROCESS_MEMORY_COUNTERS
    {
        // Fields
        public System.UInt32 cb;        // 0x10
        public System.UInt32 PageFaultCount;        // 0x14
        public System.UInt64 PeakWorkingSetSize;        // 0x18
        public System.UInt64 WorkingSetSize;        // 0x20
        public System.UInt64 QuotaPeakPagedPoolUsage;        // 0x28
        public System.UInt64 QuotaPagedPoolUsage;        // 0x30
        public System.UInt64 QuotaPeakNonPagedPoolUsage;        // 0x38
        public System.UInt64 QuotaNonPagedPoolUsage;        // 0x40
        public System.UInt64 PagefileUsage;        // 0x48
        public System.UInt64 PeakPagefileUsage;        // 0x50

    }

    // TypeToken: 0x2000004
    public struct PDH_FMT_COUNTERVALUE
    {
        // Fields
        public System.Int32 CStatus;        // 0x10
        public System.Int64 largeValue;        // 0x18

    }

    // TypeToken: 0x2000006
    public struct STORAGE_PROPERTY_QUERY
    {
        // Fields
        public System.UInt32 PropertyId;        // 0x10
        public System.UInt32 QueryType;        // 0x14
        public System.Byte AdditionalParameters;        // 0x18

    }

    // TypeToken: 0x2000007
    public struct DEVICE_SEEK_PENALTY_DESCRIPTOR
    {
        // Fields
        public System.UInt32 Version;        // 0x10
        public System.UInt32 Size;        // 0x14
        public System.Boolean IncursSeekPenalty;        // 0x18

    }

    // TypeToken: 0x200000A
    public struct SYSTEM_POWER_STATUS
    {
        // Fields
        public System.Byte ACLineStatus;        // 0x10
        public System.Byte BatteryFlag;        // 0x11
        public System.Byte BatteryLifePercent;        // 0x12
        public System.Byte Reserved1;        // 0x13
        public System.UInt32 BatteryLifeTime;        // 0x14
        public System.UInt32 BatteryFullLifeTime;        // 0x18

    }

    // TypeToken: 0x200000C
    public struct PROCESS_MEMORY_COUNTERS
    {
        // Fields
        public System.UInt32 cb;        // 0x10
        public System.UInt32 PageFaultCount;        // 0x14
        public System.UInt64 PeakWorkingSetSize;        // 0x18
        public System.UInt64 WorkingSetSize;        // 0x20
        public System.UInt64 QuotaPeakPagedPoolUsage;        // 0x28
        public System.UInt64 QuotaPagedPoolUsage;        // 0x30
        public System.UInt64 QuotaPeakNonPagedPoolUsage;        // 0x38
        public System.UInt64 QuotaNonPagedPoolUsage;        // 0x40
        public System.UInt64 PagefileUsage;        // 0x48
        public System.UInt64 PeakPagefileUsage;        // 0x50

    }

    // TypeToken: 0x200000D
    public struct PDH_FMT_COUNTERVALUE
    {
        // Fields
        public System.Int32 CStatus;        // 0x10
        public System.Int64 largeValue;        // 0x18

    }

    // TypeToken: 0x200000E
    public struct PDH_FMT_COUNTERVALUE_ITEM
    {
        // Fields
        public System.IntPtr szName;        // 0x10
        public Beyond.NativeSDK.VideoMemoryStatus.PDH_FMT_COUNTERVALUE FmtValue;        // 0x18

    }

namespace Beyond.NativeSDK
{

    // TypeToken: 0x2000002
    public class NativeUtil
    {
        // Fields
        private static System.Int32 s_procId;        // 0x0
        public static System.ValueTuple<System.Int64,System.Int64> s_DedicatedGpuMem;        // 0x8
        public static System.ValueTuple<System.Int64,System.Int64> s_SharedMemoryGpuMem;        // 0x18
        public static System.ValueTuple<System.Int64,System.Int64> s_CommittedMemoryGpuMem;        // 0x28
        public static System.String s_gpuMemQuery;        // 0x38
        public static System.Int32 s_frequencyCalcTimes;        // 0x40
        private static System.Int64 _calcResult;        // 0x48
        private static readonly System.Diagnostics.Stopwatch SW;        // 0x50

        // Methods
        private System.Void _Clear() { }
        private System.Boolean IsPromotionSupport() { }
        private System.Int64 GetAvailableMemory() { }
        private System.Int64 GetOOMMemory() { }
        private System.Boolean GetProcessMemoryInfo(System.IntPtr hProcess, Beyond.NativeSDK.NativeUtil.PROCESS_MEMORY_COUNTERS& counters, System.UInt32 size) { }
        private System.Int32 PdhOpenQueryA(System.IntPtr szDataSource, System.IntPtr dwUserData, System.IntPtr& phQuery) { }
        private System.Int32 PdhAddEnglishCounterA(System.IntPtr hQuery, System.String szFullCounterPath, System.UIntPtr dwUserData, System.IntPtr& phCounter) { }
        private System.Int32 PdhCollectQueryData(System.IntPtr hQuery) { }
        private System.Int32 PdhGetFormattedCounterValue(System.IntPtr hQuery, System.Int32 dwFormat, System.Int32* lpdwType, Beyond.NativeSDK.NativeUtil.PDH_FMT_COUNTERVALUE& pValue) { }
        private System.Int32 PdhCloseQuery(System.IntPtr hQuery) { }
        private System.Int32 GetProcId() { }
        private System.Int64 GetTotalMemory() { }
        private System.Int64 GetVirtualMemory() { }
        private System.Int64 GetGpuMemory() { }
        private System.Single GetCpuTemperature() { }
        private System.Single GetGpuTemperature() { }
        private System.Int64 GetCpuFrequency() { }
        private System.Single GetBatteryLevel() { }
        private System.Boolean IsLapTop() { }
        private System.Boolean IsCharge() { }
        private System.Int32 GetThermalState() { }
        private System.Boolean IsInSsd() { }
        private System.Boolean HasSsd() { }
        private System.Double GetFrequencyCalculateTime() { }
        private System.Int64 RunCpuFrequencyCalculate(System.Int32 times) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000005
    public class NativeWindowsDiskChecker
    {
        // Fields
        private static System.UInt32 STORAGEDEVICESEEKPENALTYPROPERTY;        // 0x0
        private static System.UInt32 PROPERTYSTANDARDQUERY;        // 0x0
        private static System.Int32 MAX_PATH;        // 0x0
        private static System.UInt32 FILE_SHARE_READ;        // 0x0
        private static System.UInt32 FILE_SHARE_WRITE;        // 0x0
        private static System.UInt32 FILE_SHARE_DELETE;        // 0x0
        private static System.UInt32 OPEN_EXISTING;        // 0x0
        private static System.UInt32 FILE_FLAG_BACKUP_SEMANTICS;        // 0x0
        private static System.UInt32 IOCTL_STORAGE_QUERY_PROPERTY;        // 0x0
        private static System.Object initOnceIsRunningInSSD;        // 0x0
        private static System.Object initOnceStandaloneWinHaveSSd;        // 0x8

        // Methods
        private System.Boolean GetVolumePathName(System.String lpszFileName, System.IntPtr lpszVolumePathName, System.UInt32 cchBufferLength) { }
        private System.Boolean GetVolumeNameForVolumeMountPoint(System.String lpszVolumeMountPoint, System.IntPtr lpszVolumeName, System.UInt32 cchBufferLength) { }
        private System.IntPtr CreateFile(System.String lpFileName, System.UInt32 dwDesiredAccess, System.UInt32 dwShareMode, System.IntPtr lpSecurityAttributes, System.UInt32 dwCreationDisposition, System.UInt32 dwFlagsAndAttributes, System.IntPtr hTemplateFile) { }
        private System.Boolean CloseHandle(System.IntPtr hObject) { }
        private System.Int32 GetLogicalDriveStrings(System.UInt32 nBufferLength, System.Char[] lpBuffer) { }
        private System.Boolean DeviceIoControl(System.IntPtr hDevice, System.UInt32 dwIoControlCode, Beyond.NativeSDK.NativeWindowsDiskChecker.STORAGE_PROPERTY_QUERY& lpInBuffer, System.UInt32 nInBufferSize, Beyond.NativeSDK.NativeWindowsDiskChecker.DEVICE_SEEK_PENALTY_DESCRIPTOR& lpOutBuffer, System.UInt32 nOutBufferSize, System.UInt32& lpBytesReturned, System.IntPtr lpOverlapped) { }
        private System.IntPtr GetVolumeHandleForFile(System.String filePath) { }
        private System.Boolean IsFileOnSsd(System.String filePath) { }
        private System.Boolean IsRunningInSSD() { }
        private System.Boolean StandaloneWinHaveSSd() { }
        private System.Void Test() { }

    }

    // TypeToken: 0x2000009
    public class NativePower
    {
        // Methods
        private System.Boolean GetSystemPowerStatus(Beyond.NativeSDK.NativePower.SYSTEM_POWER_STATUS& sps) { }
        private System.Boolean laptop() { }

    }

    // TypeToken: 0x200000B
    public class VideoMemoryStatus
    {
        // Fields
        private static System.Int32 PDH_FMT_LARGE;        // 0x0
        private static System.Int64 PDH_MORE_DATA;        // 0x8
        private static System.String Command;        // 0x0

        // Methods
        private System.Boolean GetProcessMemoryInfo(System.IntPtr hProcess, Beyond.NativeSDK.VideoMemoryStatus.PROCESS_MEMORY_COUNTERS& counters, System.UInt32 size) { }
        private System.Int64 PdhOpenQuery(System.IntPtr szDataSource, System.IntPtr dwUserData, System.IntPtr& phQuery) { }
        private System.Int64 PdhAddCounter(System.IntPtr hQuery, System.String szFullCounterPath, System.UIntPtr dwUserData, System.IntPtr& phCounter) { }
        private System.Int64 PdhCollectQueryData(System.IntPtr hQuery) { }
        private System.Int64 PdhGetFormattedCounterArray(System.IntPtr hQuery, System.Int32 dwFormat, System.UInt32& dwBufferSize, System.UInt32& dwItemCount, System.IntPtr itemBuffer) { }
        private System.Int32 PdhCloseQuery(System.IntPtr hQuery) { }
        private System.ValueTuple<System.Int64,System.Int64> GetDedicatedMemoryStatus() { }
        private System.ValueTuple<System.Int64,System.Int64> GetSharedMemoryStatus() { }
        private System.ValueTuple<System.Int64,System.Int64> GetCommittedMemoryStatus() { }
        private System.ValueTuple<System.Int64,System.Int64> GetMemoryStatus(System.String type) { }
        private System.Void .cctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x200000F
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void __Gen_Wrap_0() { }
        private System.Boolean __Gen_Wrap_1() { }
        private System.Int64 __Gen_Wrap_2() { }
        private System.Int32 __Gen_Wrap_3() { }
        private System.ValueTuple<System.Int64,System.Int64> __Gen_Wrap_4(System.Object P0) { }
        private System.ValueTuple<System.Int64,System.Int64> __Gen_Wrap_5() { }
        private System.Single __Gen_Wrap_6() { }
        private System.IntPtr __Gen_Wrap_7(System.Object P0) { }
        private System.Boolean __Gen_Wrap_8(System.Object P0) { }
        private System.Int64 __Gen_Wrap_10(System.Int32 P0) { }
        private System.Double __Gen_Wrap_11() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000010
    public class WrappersManagerImpl
    {
        // Methods
        private IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        private System.Boolean IsPatched(System.Int32 id) { }

    }

}

