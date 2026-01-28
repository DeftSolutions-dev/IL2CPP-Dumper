// ========================================================
// Dumped by @desirepro
// Assembly: Beyond.NativeSDK.dll
// Classes:  16
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: PROCESS_MEMORY_COUNTERS
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.UInt32                   cb  // 0x10
  public            System.UInt32                   PageFaultCount  // 0x14
  public            System.UInt64                   PeakWorkingSetSize  // 0x18
  public            System.UInt64                   WorkingSetSize  // 0x20
  public            System.UInt64                   QuotaPeakPagedPoolUsage  // 0x28
  public            System.UInt64                   QuotaPagedPoolUsage  // 0x30
  public            System.UInt64                   QuotaPeakNonPagedPoolUsage  // 0x38
  public            System.UInt64                   QuotaNonPagedPoolUsage  // 0x40
  public            System.UInt64                   PagefileUsage  // 0x48
  public            System.UInt64                   PeakPagefileUsage  // 0x50
METHODS:
END_CLASS

CLASS: PDH_FMT_COUNTERVALUE
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    CStatus  // 0x10
  public            System.Int64                    largeValue  // 0x18
METHODS:
END_CLASS

CLASS: STORAGE_PROPERTY_QUERY
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.UInt32                   PropertyId  // 0x10
  public            System.UInt32                   QueryType  // 0x14
  public            System.Byte                     AdditionalParameters  // 0x18
METHODS:
END_CLASS

CLASS: DEVICE_SEEK_PENALTY_DESCRIPTOR
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.UInt32                   Version  // 0x10
  public            System.UInt32                   Size  // 0x14
  public            System.Boolean                  IncursSeekPenalty  // 0x18
METHODS:
END_CLASS

CLASS: SYSTEM_POWER_STATUS
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Byte                     ACLineStatus  // 0x10
  public            System.Byte                     BatteryFlag  // 0x11
  public            System.Byte                     BatteryLifePercent  // 0x12
  public            System.Byte                     Reserved1  // 0x13
  public            System.UInt32                   BatteryLifeTime  // 0x14
  public            System.UInt32                   BatteryFullLifeTime  // 0x18
METHODS:
END_CLASS

CLASS: PROCESS_MEMORY_COUNTERS
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.UInt32                   cb  // 0x10
  public            System.UInt32                   PageFaultCount  // 0x14
  public            System.UInt64                   PeakWorkingSetSize  // 0x18
  public            System.UInt64                   WorkingSetSize  // 0x20
  public            System.UInt64                   QuotaPeakPagedPoolUsage  // 0x28
  public            System.UInt64                   QuotaPagedPoolUsage  // 0x30
  public            System.UInt64                   QuotaPeakNonPagedPoolUsage  // 0x38
  public            System.UInt64                   QuotaNonPagedPoolUsage  // 0x40
  public            System.UInt64                   PagefileUsage  // 0x48
  public            System.UInt64                   PeakPagefileUsage  // 0x50
METHODS:
END_CLASS

CLASS: PDH_FMT_COUNTERVALUE
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            System.Int32                    CStatus  // 0x10
  public            System.Int64                    largeValue  // 0x18
METHODS:
END_CLASS

CLASS: PDH_FMT_COUNTERVALUE_ITEM
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            System.IntPtr                   szName  // 0x10
  public            Beyond.NativeSDK.VideoMemoryStatus.PDH_FMT_COUNTERVALUEFmtValue  // 0x18
METHODS:
END_CLASS

CLASS: Beyond.NativeSDK.NativeUtil
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  private   static  System.Int32                    s_procId  // 0x0
  public    static  System.ValueTuple<System.Int64,System.Int64>s_DedicatedGpuMem  // 0x8
  public    static  System.ValueTuple<System.Int64,System.Int64>s_SharedMemoryGpuMem  // 0x18
  public    static  System.ValueTuple<System.Int64,System.Int64>s_CommittedMemoryGpuMem  // 0x28
  public    static  System.String                   s_gpuMemQuery  // 0x38
  public    static  System.Int32                    s_frequencyCalcTimes  // 0x40
  private   static  System.Int64                    _calcResult  // 0x48
  private   static readonly System.Diagnostics.Stopwatch    SW  // 0x50
METHODS:
  System.Void _Clear()
  System.Boolean IsPromotionSupport()
  System.Int64 GetAvailableMemory()
  System.Int64 GetOOMMemory()
  System.Boolean GetProcessMemoryInfo(System.IntPtr hProcess, Beyond.NativeSDK.NativeUtil.PROCESS_MEMORY_COUNTERS& counters, System.UInt32 size)
  System.Int32 PdhOpenQueryA(System.IntPtr szDataSource, System.IntPtr dwUserData, System.IntPtr& phQuery)
  System.Int32 PdhAddEnglishCounterA(System.IntPtr hQuery, System.String szFullCounterPath, System.UIntPtr dwUserData, System.IntPtr& phCounter)
  System.Int32 PdhCollectQueryData(System.IntPtr hQuery)
  System.Int32 PdhGetFormattedCounterValue(System.IntPtr hQuery, System.Int32 dwFormat, System.Int32* lpdwType, Beyond.NativeSDK.NativeUtil.PDH_FMT_COUNTERVALUE& pValue)
  System.Int32 PdhCloseQuery(System.IntPtr hQuery)
  System.Int32 GetProcId()
  System.Int64 GetTotalMemory()
  System.Int64 GetVirtualMemory()
  System.Int64 GetGpuMemory()
  System.Single GetCpuTemperature()
  System.Single GetGpuTemperature()
  System.Int64 GetCpuFrequency()
  System.Single GetBatteryLevel()
  System.Boolean IsLapTop()
  System.Boolean IsCharge()
  System.Int32 GetThermalState()
  System.Boolean IsInSsd()
  System.Boolean HasSsd()
  System.Double GetFrequencyCalculateTime()
  System.Int64 RunCpuFrequencyCalculate(System.Int32 times)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.NativeSDK.NativeWindowsDiskChecker
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  private   static  System.UInt32                   STORAGEDEVICESEEKPENALTYPROPERTY  // 0x0
  private   static  System.UInt32                   PROPERTYSTANDARDQUERY  // 0x0
  private   static  System.Int32                    MAX_PATH  // 0x0
  private   static  System.UInt32                   FILE_SHARE_READ  // 0x0
  private   static  System.UInt32                   FILE_SHARE_WRITE  // 0x0
  private   static  System.UInt32                   FILE_SHARE_DELETE  // 0x0
  private   static  System.UInt32                   OPEN_EXISTING  // 0x0
  private   static  System.UInt32                   FILE_FLAG_BACKUP_SEMANTICS  // 0x0
  private   static  System.UInt32                   IOCTL_STORAGE_QUERY_PROPERTY  // 0x0
  private   static  System.Object                   initOnceIsRunningInSSD  // 0x0
  private   static  System.Object                   initOnceStandaloneWinHaveSSd  // 0x8
METHODS:
  System.Boolean GetVolumePathName(System.String lpszFileName, System.IntPtr lpszVolumePathName, System.UInt32 cchBufferLength)
  System.Boolean GetVolumeNameForVolumeMountPoint(System.String lpszVolumeMountPoint, System.IntPtr lpszVolumeName, System.UInt32 cchBufferLength)
  System.IntPtr CreateFile(System.String lpFileName, System.UInt32 dwDesiredAccess, System.UInt32 dwShareMode, System.IntPtr lpSecurityAttributes, System.UInt32 dwCreationDisposition, System.UInt32 dwFlagsAndAttributes, System.IntPtr hTemplateFile)
  System.Boolean CloseHandle(System.IntPtr hObject)
  System.Int32 GetLogicalDriveStrings(System.UInt32 nBufferLength, System.Char[] lpBuffer)
  System.Boolean DeviceIoControl(System.IntPtr hDevice, System.UInt32 dwIoControlCode, Beyond.NativeSDK.NativeWindowsDiskChecker.STORAGE_PROPERTY_QUERY& lpInBuffer, System.UInt32 nInBufferSize, Beyond.NativeSDK.NativeWindowsDiskChecker.DEVICE_SEEK_PENALTY_DESCRIPTOR& lpOutBuffer, System.UInt32 nOutBufferSize, System.UInt32& lpBytesReturned, System.IntPtr lpOverlapped)
  System.IntPtr GetVolumeHandleForFile(System.String filePath)
  System.Boolean IsFileOnSsd(System.String filePath)
  System.Boolean IsRunningInSSD()
  System.Boolean StandaloneWinHaveSSd()
  System.Void Test()
END_CLASS

CLASS: Beyond.NativeSDK.NativePower
TYPE:  class
TOKEN: 0x2000009
FIELDS:
METHODS:
  System.Boolean GetSystemPowerStatus(Beyond.NativeSDK.NativePower.SYSTEM_POWER_STATUS& sps)
  System.Boolean laptop()
END_CLASS

CLASS: Beyond.NativeSDK.VideoMemoryStatus
TYPE:  class
TOKEN: 0x200000B
FIELDS:
  private   static  System.Int32                    PDH_FMT_LARGE  // 0x0
  private   static  System.Int64                    PDH_MORE_DATA  // 0x8
  private   static  System.String                   Command  // 0x0
METHODS:
  System.Boolean GetProcessMemoryInfo(System.IntPtr hProcess, Beyond.NativeSDK.VideoMemoryStatus.PROCESS_MEMORY_COUNTERS& counters, System.UInt32 size)
  System.Int64 PdhOpenQuery(System.IntPtr szDataSource, System.IntPtr dwUserData, System.IntPtr& phQuery)
  System.Int64 PdhAddCounter(System.IntPtr hQuery, System.String szFullCounterPath, System.UIntPtr dwUserData, System.IntPtr& phCounter)
  System.Int64 PdhCollectQueryData(System.IntPtr hQuery)
  System.Int64 PdhGetFormattedCounterArray(System.IntPtr hQuery, System.Int32 dwFormat, System.UInt32& dwBufferSize, System.UInt32& dwItemCount, System.IntPtr itemBuffer)
  System.Int32 PdhCloseQuery(System.IntPtr hQuery)
  System.ValueTuple<System.Int64,System.Int64> GetDedicatedMemoryStatus()
  System.ValueTuple<System.Int64,System.Int64> GetSharedMemoryStatus()
  System.ValueTuple<System.Int64,System.Int64> GetCommittedMemoryStatus()
  System.ValueTuple<System.Int64,System.Int64> GetMemoryStatus(System.String type)
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x200000F
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void __Gen_Wrap_0()
  System.Boolean __Gen_Wrap_1()
  System.Int64 __Gen_Wrap_2()
  System.Int32 __Gen_Wrap_3()
  System.ValueTuple<System.Int64,System.Int64> __Gen_Wrap_4(System.Object P0)
  System.ValueTuple<System.Int64,System.Int64> __Gen_Wrap_5()
  System.Single __Gen_Wrap_6()
  System.IntPtr __Gen_Wrap_7(System.Object P0)
  System.Boolean __Gen_Wrap_8(System.Object P0)
  System.Int64 __Gen_Wrap_10(System.Int32 P0)
  System.Double __Gen_Wrap_11()
  System.Void .cctor()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000010
FIELDS:
METHODS:
  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  System.Boolean IsPatched(System.Int32 id)
END_CLASS

