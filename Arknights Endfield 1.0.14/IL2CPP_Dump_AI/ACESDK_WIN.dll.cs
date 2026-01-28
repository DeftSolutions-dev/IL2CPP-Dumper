// ========================================================
// Dumped by @desirepro
// Assembly: ACESDK_WIN.dll
// Classes:  29
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: InitAceClient5Routine
TYPE:  class
TOKEN: 0x2000007
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  AceSdk.AceSdkResult Invoke(System.UInt32 ver, System.IntPtr opt, System.IntPtr& client_obj_ptr)
  System.IAsyncResult BeginInvoke(System.UInt32 ver, System.IntPtr opt, System.IntPtr& client_obj_ptr, System.AsyncCallback callback, System.Object object)
  AceSdk.AceSdkResult EndInvoke(System.IntPtr& client_obj_ptr, System.IAsyncResult result)
END_CLASS

CLASS: LogInRoutine
TYPE:  class
TOKEN: 0x2000008
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  AceSdk.AceSdkResult Invoke(System.IntPtr handle, System.String account, System.UInt32 account_type, System.UInt32 world_id, System.String login_ticket)
  System.IAsyncResult BeginInvoke(System.IntPtr handle, System.String account, System.UInt32 account_type, System.UInt32 world_id, System.String login_ticket, System.AsyncCallback callback, System.Object object)
  AceSdk.AceSdkResult EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: LogOutRoutine
TYPE:  class
TOKEN: 0x2000009
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  AceSdk.AceSdkResult Invoke(System.IntPtr handle)
  System.IAsyncResult BeginInvoke(System.IntPtr handle, System.AsyncCallback callback, System.Object object)
  AceSdk.AceSdkResult EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: DeinitRoutine
TYPE:  class
TOKEN: 0x200000A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  AceSdk.AceSdkResult Invoke(System.IntPtr handle)
  System.IAsyncResult BeginInvoke(System.IntPtr handle, System.AsyncCallback callback, System.Object object)
  AceSdk.AceSdkResult EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GetPacketRoutine
TYPE:  class
TOKEN: 0x200000B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  AceSdk.AceSdkResult Invoke(System.IntPtr handle, AceSdk.AceSdkClient.AceSdkClientPacket& packet)
  System.IAsyncResult BeginInvoke(System.IntPtr handle, AceSdk.AceSdkClient.AceSdkClientPacket& packet, System.AsyncCallback callback, System.Object object)
  AceSdk.AceSdkResult EndInvoke(AceSdk.AceSdkClient.AceSdkClientPacket& packet, System.IAsyncResult result)
END_CLASS

CLASS: OnPacketReceivedRoutine
TYPE:  class
TOKEN: 0x200000C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  AceSdk.AceSdkResult Invoke(System.IntPtr handle, System.Byte[] data, System.UInt32 len)
  System.IAsyncResult BeginInvoke(System.IntPtr handle, System.Byte[] data, System.UInt32 len, System.AsyncCallback callback, System.Object object)
  AceSdk.AceSdkResult EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GetLightFeaturePacketRoutine
TYPE:  class
TOKEN: 0x200000D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  AceSdk.AceSdkResult Invoke(System.IntPtr handle, AceSdk.AceSdkClient.AceSdkClientLightFeaturePacket& packet)
  System.IAsyncResult BeginInvoke(System.IntPtr handle, AceSdk.AceSdkClient.AceSdkClientLightFeaturePacket& packet, System.AsyncCallback callback, System.Object object)
  AceSdk.AceSdkResult EndInvoke(AceSdk.AceSdkClient.AceSdkClientLightFeaturePacket& packet, System.IAsyncResult result)
END_CLASS

CLASS: OnLightFeaturePacketReceivedRoutine
TYPE:  class
TOKEN: 0x200000E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  AceSdk.AceSdkResult Invoke(System.IntPtr handle, AceSdk.AceSdkClient.AceSdkClientLightFeature& data)
  System.IAsyncResult BeginInvoke(System.IntPtr handle, AceSdk.AceSdkClient.AceSdkClientLightFeature& data, System.AsyncCallback callback, System.Object object)
  AceSdk.AceSdkResult EndInvoke(AceSdk.AceSdkClient.AceSdkClientLightFeature& data, System.IAsyncResult result)
END_CLASS

CLASS: AceSdkClientObject
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            System.IntPtr                   handle_  // 0x10
  public            System.IntPtr                   _deprecated1  // 0x18
  public            AceSdk.AceSdkClient.LogOutRoutinelog_out_  // 0x20
  public            AceSdk.AceSdkClient.DeinitRoutinedeinit_  // 0x28
  public            AceSdk.AceSdkClient.GetPacketRoutineget_packet_  // 0x30
  public            AceSdk.AceSdkClient.OnPacketReceivedRoutineon_packet_received_  // 0x38
  public            AceSdk.AceSdkClient.LogInRoutinelog_in_  // 0x40
  public            AceSdk.AceSdkClient.GetLightFeaturePacketRoutineget_light_feature_packet_  // 0x48
  public            AceSdk.AceSdkClient.OnLightFeaturePacketReceivedRoutineon_light_feature_packet_received_  // 0x50
METHODS:
END_CLASS

CLASS: AceSdkClientPacket
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  public            System.Byte[]                   buffer_  // 0x10
  public            System.UInt32                   len_  // 0x18
METHODS:
END_CLASS

CLASS: AceSdkClientLightFeaturePacket
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  public            System.Byte[]                   buffer_  // 0x10
  public            System.UInt32                   len_  // 0x18
METHODS:
END_CLASS

CLASS: AceSdkClientLightFeature
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public            System.String                   name_  // 0x10
  public            System.IntPtr                   data_  // 0x18
  public            System.UInt32                   data_len_  // 0x20
  public            System.UInt32                   crc_  // 0x24
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=14
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=33
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=38
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
METHODS:
END_CLASS

CLASS: AceSdk.AceSdkAccountType
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_QQ  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_WECHAT  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_BAIDU  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_QQ_OPENID  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_VISITOR  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_GOPENID  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_GOOGLE  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_WEGAME_MAIL  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_4399  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_GARENA  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_GIANT_NETWORK  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_WEGAME  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_STEAM  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_WEGAME_COMMON_ID  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_WOODUAN  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_VK  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_COMMON_ID  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_FACEBOOK  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_SUPERCELL  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_TCOMMIC  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_UPLAY  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_PHONE_OPENID  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_LINE  // 0x0
  public    static  AceSdk.AceSdkAccountType        ACE_SDK_ACCOUNT_TYPE_APPLE  // 0x0
METHODS:
END_CLASS

CLASS: AceSdk.AceSdkAccountPlatID
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  AceSdk.AceSdkAccountPlatID      ACE_SDK_PLAT_ID_IOS  // 0x0
  public    static  AceSdk.AceSdkAccountPlatID      ACE_SDK_PLAT_ID_ANDROID  // 0x0
  public    static  AceSdk.AceSdkAccountPlatID      ACE_SDK_PLAT_ID_PC_CLIENT  // 0x0
  public    static  AceSdk.AceSdkAccountPlatID      ACE_SDK_PLAT_ID_LINUX  // 0x0
  public    static  AceSdk.AceSdkAccountPlatID      ACE_SDK_PLAT_ID_SWITCH  // 0x0
  public    static  AceSdk.AceSdkAccountPlatID      ACE_SDK_PLAT_ID_MAC  // 0x0
  public    static  AceSdk.AceSdkAccountPlatID      ACE_SDK_PLAT_ID_PS_CLIENT  // 0x0
  public    static  AceSdk.AceSdkAccountPlatID      ACE_SDK_PLAT_ID_XBOX_CLIENT  // 0x0
  public    static  AceSdk.AceSdkAccountPlatID      ACE_SDK_PLAT_ID_PC_EMULATOR_CLIENT  // 0x0
  public    static  AceSdk.AceSdkAccountPlatID      ACE_SDK_PLAT_ID_HARMONY_MOBILE  // 0x0
  public    static  AceSdk.AceSdkAccountPlatID      ACE_SDK_PLAT_ID_HARMONY_PC  // 0x0
  public    static  AceSdk.AceSdkAccountPlatID      ACE_SDK_PLAT_ID_UNKNOWN  // 0x0
METHODS:
END_CLASS

CLASS: AceSdk.AceSdkAccount
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  public    static  System.Int32                    ACE_SDK_MAX_ACCOUNT_LEN  // 0x0
  public            System.Text.StringBuilder       account_  // 0x10
  public            AceSdk.AceSdkAccountType        account_type_  // 0x18
  public            AceSdk.AceSdkAccountPlatID      plat_id_  // 0x1C
  public            System.UInt32                   game_id_  // 0x20
  public            System.UInt32                   world_id_  // 0x24
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: AceSdk.AceSdkClient
TYPE:  class
TOKEN: 0x2000006
FIELDS:
  private           AceSdk.AceSdkClient.AceSdkClientObjectclient_obj_  // 0x10
  private           System.Byte[]                   get_packet_buffer_  // 0x58
  private           System.Byte[]                   get_light_feature_packet_buffer_  // 0x60
METHODS:
  AceSdk.AceSdkResult ace_sdk_client_init(AceSdk.AceSdkClient& ace_client)
  AceSdk.AceSdkResult ace_sdk_client_deinit()
  AceSdk.AceSdkResult ace_sdk_client_log_in(System.String account_id, AceSdk.AceSdkAccountType account_type, System.UInt32 world_id, System.String login_ticket)
  AceSdk.AceSdkResult ace_sdk_client_log_out()
  AceSdk.AceSdkResult ace_sdk_client_get_packet(System.Byte[]& packet)
  AceSdk.AceSdkResult ace_sdk_client_on_packet_received(System.Byte[] packet)
  AceSdk.AceSdkResult ace_sdk_client_get_light_feature_packet(System.Byte[]& packet)
  AceSdk.AceSdkResult ace_sdk_client_on_light_feature_packet_received(System.Byte[] lf_data, System.String name, System.UInt32 crc)
  System.Void .ctor(System.IntPtr client_obj_ptr)
  System.Int32 get_exe_module_path(System.Text.StringBuilder path, System.Int32 len)
  System.String DecryptString(System.Byte[] encrypted, System.Byte key)
  System.IntPtr LoadLibrary(System.String lpLibFileName)
  System.IntPtr GetProcAddress(System.IntPtr hModule, System.String lpProcName)
  System.IntPtr GetProcAddressByOrdinal(System.IntPtr hModule, System.Int32 nOrdinal)
  System.UInt32 GetModuleFileName(System.IntPtr hModule, System.Text.StringBuilder lpFilename, System.Int32 nSize)
END_CLASS

CLASS: AceSdk.AceSdkResult
TYPE:  struct
TOKEN: 0x2000013
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_OK  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_NOT_SUPPORTED  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_INVALID_PARAMETER  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_CALC_PATH_FAILED  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_LOAD_LIBRARY_FAILED  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_UNLOAD_LIBRARY_FAILED  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_SYMBOL_NOT_FOUND  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_INIT_NOT_CALLED_OR_FAILED  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_INTERNAL_ERROR  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_ACCOUNT_TOO_LONG  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_ACCOUNT_ILLEGAL_CHARACTER  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_NO_PACKET_NEED_SENDING  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_ILLEGAL_LOG_IN  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_COMMON_END  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_DEVELOP_LANGUAGE_BEGIN  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_PACK_STRUCT_1BYTE_ERROR  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_UNPACK_STRUCT_1BYTE_ERROR  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_PACK_STRUCT_1BYTE_LEN_ERROR  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESLUT_JAVA_JNI_BEGIN  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESLUT_JAVA_JNI_ENV_NULL  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESLUT_JAVA_JNI_JVM_NULL  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESLUT_JAVA_JNI_JOBJECT_NULL  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESLUT_JAVA_JNI_CLASS_NULL  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESLUT_JAVA_JNI_REFLECT_BS_DATA_FAILED  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESLUT_JAVA_JNI_REFLECT_BS_OFFSET_FAILED  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESLUT_JAVA_JNI_REFLECT_BS_CAPACITY_FAILED  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESLUT_JAVA_JNI_REFLECT_BS_LENGTH_ERROR  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESLUT_JAVA_ARRAY_LENTGH_ERROR  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESLUT_JAVA_JNI_END  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_DEVELOP_LANGUAGE_END  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_BUSI_INTERFACE_BEGIN  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESLUT_LIGHT_FEATURE_BEGIN  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESLUT_LIGHT_FEATURE_NOT_OPENED  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESLUT_LIGHT_FEATURE_END  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESLUT_UIC_BEGIN  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_UIC_TEXT_INTERF_CALL_FAILED  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_UIC_TEXT_CALLBACK_HAS_NOT_SET  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_UIC_PIC_INTERF_CALL_FAILED  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_UIC_PIC_CALLBACK_HAS_NOT_SET  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESLUT_UIC_END  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_SAFEMODE_BEGIN  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_SAFEMODE_CALLBACK_HAS_NOT_SET  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_SAFEMODE_INTERF_CALL_FAILED  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_SAFEMODE_END  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_GAME_SESSION_BEGIN  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_GAME_SESSION_INTERF_CALL_FAILED  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_GAME_SESSION_END  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_BUSI_INTERFACE_END  // 0x0
  public    static  AceSdk.AceSdkResult             ACE_SDK_RESULT_MAX_INT32  // 0x0
METHODS:
END_CLASS

CLASS: AceSdk.AceSdkTool
TYPE:  class
TOKEN: 0x2000014
FIELDS:
METHODS:
  System.String get_string_from_bytearray_until_zero(System.Byte[] input_bytes)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.AceSdk.AceSDKInterfaceWin
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  private   static  Beyond.AceSdk.AceSDKInterfaceWininstance  // 0x0
  public            AceSdk.AceSdkClient             ace_client  // 0x10
  private           System.Threading.Thread         m_netThread  // 0x18
  private           System.Boolean                  b_stopThread  // 0x20
  private           System.String                   s_LoginAccount  // 0x28
  private           System.Collections.Generic.HashSet<System.String>login_ids  // 0x30
  private           System.Boolean                  isGamePaused  // 0x38
METHODS:
  Beyond.AceSdk.AceSDKInterfaceWin get_Instance()
  System.Void .ctor()
  System.Void Finalize()
  System.Void InitACESDK()
  System.Void DeinitACESDK()
  System.Void OnApplicationPause(System.Boolean pause)
  System.Void AceSdkClientLogIn(System.String account_id, System.String ticket, System.UInt32 world_id)
  System.Void AceSdkClientLogOut()
  System.Void StartNetThread()
  System.Void NetworkThread(AceSdk.AceSdkClient ace_client)
  System.Void SendPktToGameServer(System.Byte[] pkg)
  System.Void OnAceSdkPacketReceived(System.Byte[] pkt)
  System.Void <StartNetThread>b__16_0()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x2000015
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000016
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000017
EXTENDS: Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000018
EXTENDS: Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

