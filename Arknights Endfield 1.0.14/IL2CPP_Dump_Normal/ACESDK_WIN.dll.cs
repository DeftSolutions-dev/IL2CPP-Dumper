// ========================================================
// Dumped by @desirepro
// Assembly: ACESDK_WIN.dll
// Classes:  29
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000007
    public class InitAceClient5Routine : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private AceSdk.AceSdkResult Invoke(System.UInt32 ver, System.IntPtr opt, System.IntPtr& client_obj_ptr) { }
        private System.IAsyncResult BeginInvoke(System.UInt32 ver, System.IntPtr opt, System.IntPtr& client_obj_ptr, System.AsyncCallback callback, System.Object object) { }
        private AceSdk.AceSdkResult EndInvoke(System.IntPtr& client_obj_ptr, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000008
    public class LogInRoutine : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private AceSdk.AceSdkResult Invoke(System.IntPtr handle, System.String account, System.UInt32 account_type, System.UInt32 world_id, System.String login_ticket) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr handle, System.String account, System.UInt32 account_type, System.UInt32 world_id, System.String login_ticket, System.AsyncCallback callback, System.Object object) { }
        private AceSdk.AceSdkResult EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000009
    public class LogOutRoutine : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private AceSdk.AceSdkResult Invoke(System.IntPtr handle) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr handle, System.AsyncCallback callback, System.Object object) { }
        private AceSdk.AceSdkResult EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200000A
    public class DeinitRoutine : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private AceSdk.AceSdkResult Invoke(System.IntPtr handle) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr handle, System.AsyncCallback callback, System.Object object) { }
        private AceSdk.AceSdkResult EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200000B
    public class GetPacketRoutine : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private AceSdk.AceSdkResult Invoke(System.IntPtr handle, AceSdk.AceSdkClient.AceSdkClientPacket& packet) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr handle, AceSdk.AceSdkClient.AceSdkClientPacket& packet, System.AsyncCallback callback, System.Object object) { }
        private AceSdk.AceSdkResult EndInvoke(AceSdk.AceSdkClient.AceSdkClientPacket& packet, System.IAsyncResult result) { }

    }

    // TypeToken: 0x200000C
    public class OnPacketReceivedRoutine : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private AceSdk.AceSdkResult Invoke(System.IntPtr handle, System.Byte[] data, System.UInt32 len) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr handle, System.Byte[] data, System.UInt32 len, System.AsyncCallback callback, System.Object object) { }
        private AceSdk.AceSdkResult EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200000D
    public class GetLightFeaturePacketRoutine : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private AceSdk.AceSdkResult Invoke(System.IntPtr handle, AceSdk.AceSdkClient.AceSdkClientLightFeaturePacket& packet) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr handle, AceSdk.AceSdkClient.AceSdkClientLightFeaturePacket& packet, System.AsyncCallback callback, System.Object object) { }
        private AceSdk.AceSdkResult EndInvoke(AceSdk.AceSdkClient.AceSdkClientLightFeaturePacket& packet, System.IAsyncResult result) { }

    }

    // TypeToken: 0x200000E
    public class OnLightFeaturePacketReceivedRoutine : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private AceSdk.AceSdkResult Invoke(System.IntPtr handle, AceSdk.AceSdkClient.AceSdkClientLightFeature& data) { }
        private System.IAsyncResult BeginInvoke(System.IntPtr handle, AceSdk.AceSdkClient.AceSdkClientLightFeature& data, System.AsyncCallback callback, System.Object object) { }
        private AceSdk.AceSdkResult EndInvoke(AceSdk.AceSdkClient.AceSdkClientLightFeature& data, System.IAsyncResult result) { }

    }

    // TypeToken: 0x200000F
    public struct AceSdkClientObject
    {
        // Fields
        public System.IntPtr handle_;        // 0x10
        public System.IntPtr _deprecated1;        // 0x18
        public AceSdk.AceSdkClient.LogOutRoutine log_out_;        // 0x20
        public AceSdk.AceSdkClient.DeinitRoutine deinit_;        // 0x28
        public AceSdk.AceSdkClient.GetPacketRoutine get_packet_;        // 0x30
        public AceSdk.AceSdkClient.OnPacketReceivedRoutine on_packet_received_;        // 0x38
        public AceSdk.AceSdkClient.LogInRoutine log_in_;        // 0x40
        public AceSdk.AceSdkClient.GetLightFeaturePacketRoutine get_light_feature_packet_;        // 0x48
        public AceSdk.AceSdkClient.OnLightFeaturePacketReceivedRoutine on_light_feature_packet_received_;        // 0x50

    }

    // TypeToken: 0x2000010
    public struct AceSdkClientPacket
    {
        // Fields
        public System.Byte[] buffer_;        // 0x10
        public System.UInt32 len_;        // 0x18

    }

    // TypeToken: 0x2000011
    public struct AceSdkClientLightFeaturePacket
    {
        // Fields
        public System.Byte[] buffer_;        // 0x10
        public System.UInt32 len_;        // 0x18

    }

    // TypeToken: 0x2000012
    public struct AceSdkClientLightFeature
    {
        // Fields
        public System.String name_;        // 0x10
        public System.IntPtr data_;        // 0x18
        public System.UInt32 data_len_;        // 0x20
        public System.UInt32 crc_;        // 0x24

    }

    // TypeToken: 0x200001B
    public struct __StaticArrayInitTypeSize=14
    {
    }

    // TypeToken: 0x200001C
    public struct __StaticArrayInitTypeSize=33
    {
    }

    // TypeToken: 0x200001D
    public struct __StaticArrayInitTypeSize=38
    {
    }

namespace AceSdk
{

    // TypeToken: 0x2000003
    public struct AceSdkAccountType
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_QQ;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_WECHAT;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_BAIDU;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_QQ_OPENID;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_VISITOR;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_GOPENID;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_GOOGLE;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_WEGAME_MAIL;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_4399;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_GARENA;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_GIANT_NETWORK;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_WEGAME;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_STEAM;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_WEGAME_COMMON_ID;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_WOODUAN;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_VK;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_COMMON_ID;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_FACEBOOK;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_SUPERCELL;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_TCOMMIC;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_UPLAY;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_PHONE_OPENID;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_LINE;        // 0x0
        public static AceSdk.AceSdkAccountType ACE_SDK_ACCOUNT_TYPE_APPLE;        // 0x0

    }

    // TypeToken: 0x2000004
    public struct AceSdkAccountPlatID
    {
        // Fields
        public System.UInt32 value__;        // 0x10
        public static AceSdk.AceSdkAccountPlatID ACE_SDK_PLAT_ID_IOS;        // 0x0
        public static AceSdk.AceSdkAccountPlatID ACE_SDK_PLAT_ID_ANDROID;        // 0x0
        public static AceSdk.AceSdkAccountPlatID ACE_SDK_PLAT_ID_PC_CLIENT;        // 0x0
        public static AceSdk.AceSdkAccountPlatID ACE_SDK_PLAT_ID_LINUX;        // 0x0
        public static AceSdk.AceSdkAccountPlatID ACE_SDK_PLAT_ID_SWITCH;        // 0x0
        public static AceSdk.AceSdkAccountPlatID ACE_SDK_PLAT_ID_MAC;        // 0x0
        public static AceSdk.AceSdkAccountPlatID ACE_SDK_PLAT_ID_PS_CLIENT;        // 0x0
        public static AceSdk.AceSdkAccountPlatID ACE_SDK_PLAT_ID_XBOX_CLIENT;        // 0x0
        public static AceSdk.AceSdkAccountPlatID ACE_SDK_PLAT_ID_PC_EMULATOR_CLIENT;        // 0x0
        public static AceSdk.AceSdkAccountPlatID ACE_SDK_PLAT_ID_HARMONY_MOBILE;        // 0x0
        public static AceSdk.AceSdkAccountPlatID ACE_SDK_PLAT_ID_HARMONY_PC;        // 0x0
        public static AceSdk.AceSdkAccountPlatID ACE_SDK_PLAT_ID_UNKNOWN;        // 0x0

    }

    // TypeToken: 0x2000005
    public class AceSdkAccount
    {
        // Fields
        public static System.Int32 ACE_SDK_MAX_ACCOUNT_LEN;        // 0x0
        public System.Text.StringBuilder account_;        // 0x10
        public AceSdk.AceSdkAccountType account_type_;        // 0x18
        public AceSdk.AceSdkAccountPlatID plat_id_;        // 0x1C
        public System.UInt32 game_id_;        // 0x20
        public System.UInt32 world_id_;        // 0x24

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class AceSdkClient
    {
        // Fields
        private AceSdk.AceSdkClient.AceSdkClientObject client_obj_;        // 0x10
        private System.Byte[] get_packet_buffer_;        // 0x58
        private System.Byte[] get_light_feature_packet_buffer_;        // 0x60

        // Methods
        private AceSdk.AceSdkResult ace_sdk_client_init(AceSdk.AceSdkClient& ace_client) { }
        private AceSdk.AceSdkResult ace_sdk_client_deinit() { }
        private AceSdk.AceSdkResult ace_sdk_client_log_in(System.String account_id, AceSdk.AceSdkAccountType account_type, System.UInt32 world_id, System.String login_ticket) { }
        private AceSdk.AceSdkResult ace_sdk_client_log_out() { }
        private AceSdk.AceSdkResult ace_sdk_client_get_packet(System.Byte[]& packet) { }
        private AceSdk.AceSdkResult ace_sdk_client_on_packet_received(System.Byte[] packet) { }
        private AceSdk.AceSdkResult ace_sdk_client_get_light_feature_packet(System.Byte[]& packet) { }
        private AceSdk.AceSdkResult ace_sdk_client_on_light_feature_packet_received(System.Byte[] lf_data, System.String name, System.UInt32 crc) { }
        private System.Void .ctor(System.IntPtr client_obj_ptr) { }
        private System.Int32 get_exe_module_path(System.Text.StringBuilder path, System.Int32 len) { }
        private System.String DecryptString(System.Byte[] encrypted, System.Byte key) { }
        private System.IntPtr LoadLibrary(System.String lpLibFileName) { }
        private System.IntPtr GetProcAddress(System.IntPtr hModule, System.String lpProcName) { }
        private System.IntPtr GetProcAddressByOrdinal(System.IntPtr hModule, System.Int32 nOrdinal) { }
        private System.UInt32 GetModuleFileName(System.IntPtr hModule, System.Text.StringBuilder lpFilename, System.Int32 nSize) { }

    }

    // TypeToken: 0x2000013
    public struct AceSdkResult
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_OK;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_NOT_SUPPORTED;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_INVALID_PARAMETER;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_CALC_PATH_FAILED;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_LOAD_LIBRARY_FAILED;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_UNLOAD_LIBRARY_FAILED;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_SYMBOL_NOT_FOUND;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_INIT_NOT_CALLED_OR_FAILED;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_INTERNAL_ERROR;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_ACCOUNT_TOO_LONG;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_ACCOUNT_ILLEGAL_CHARACTER;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_NO_PACKET_NEED_SENDING;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_ILLEGAL_LOG_IN;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_COMMON_END;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_DEVELOP_LANGUAGE_BEGIN;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_PACK_STRUCT_1BYTE_ERROR;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_UNPACK_STRUCT_1BYTE_ERROR;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_PACK_STRUCT_1BYTE_LEN_ERROR;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESLUT_JAVA_JNI_BEGIN;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESLUT_JAVA_JNI_ENV_NULL;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESLUT_JAVA_JNI_JVM_NULL;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESLUT_JAVA_JNI_JOBJECT_NULL;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESLUT_JAVA_JNI_CLASS_NULL;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESLUT_JAVA_JNI_REFLECT_BS_DATA_FAILED;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESLUT_JAVA_JNI_REFLECT_BS_OFFSET_FAILED;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESLUT_JAVA_JNI_REFLECT_BS_CAPACITY_FAILED;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESLUT_JAVA_JNI_REFLECT_BS_LENGTH_ERROR;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESLUT_JAVA_ARRAY_LENTGH_ERROR;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESLUT_JAVA_JNI_END;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_DEVELOP_LANGUAGE_END;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_BUSI_INTERFACE_BEGIN;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESLUT_LIGHT_FEATURE_BEGIN;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESLUT_LIGHT_FEATURE_NOT_OPENED;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESLUT_LIGHT_FEATURE_END;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESLUT_UIC_BEGIN;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_UIC_TEXT_INTERF_CALL_FAILED;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_UIC_TEXT_CALLBACK_HAS_NOT_SET;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_UIC_PIC_INTERF_CALL_FAILED;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_UIC_PIC_CALLBACK_HAS_NOT_SET;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESLUT_UIC_END;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_SAFEMODE_BEGIN;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_SAFEMODE_CALLBACK_HAS_NOT_SET;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_SAFEMODE_INTERF_CALL_FAILED;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_SAFEMODE_END;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_GAME_SESSION_BEGIN;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_GAME_SESSION_INTERF_CALL_FAILED;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_GAME_SESSION_END;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_BUSI_INTERFACE_END;        // 0x0
        public static AceSdk.AceSdkResult ACE_SDK_RESULT_MAX_INT32;        // 0x0

    }

    // TypeToken: 0x2000014
    public class AceSdkTool
    {
        // Methods
        private System.String get_string_from_bytearray_until_zero(System.Byte[] input_bytes) { }
        private System.Void .ctor() { }

    }

}

namespace Beyond.AceSdk
{

    // TypeToken: 0x2000019
    public class AceSDKInterfaceWin
    {
        // Fields
        private static Beyond.AceSdk.AceSDKInterfaceWin instance;        // 0x0
        public AceSdk.AceSdkClient ace_client;        // 0x10
        private System.Threading.Thread m_netThread;        // 0x18
        private System.Boolean b_stopThread;        // 0x20
        private System.String s_LoginAccount;        // 0x28
        private System.Collections.Generic.HashSet<System.String> login_ids;        // 0x30
        private System.Boolean isGamePaused;        // 0x38

        // Methods
        private Beyond.AceSdk.AceSDKInterfaceWin get_Instance() { }
        private System.Void .ctor() { }
        private System.Void Finalize() { }
        private System.Void InitACESDK() { }
        private System.Void DeinitACESDK() { }
        private System.Void OnApplicationPause(System.Boolean pause) { }
        private System.Void AceSdkClientLogIn(System.String account_id, System.String ticket, System.UInt32 world_id) { }
        private System.Void AceSdkClientLogOut() { }
        private System.Void StartNetThread() { }
        private System.Void NetworkThread(AceSdk.AceSdkClient ace_client) { }
        private System.Void SendPktToGameServer(System.Byte[] pkg) { }
        private System.Void OnAceSdkPacketReceived(System.Byte[] pkt) { }
        private System.Void <StartNetThread>b__16_0() { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000015
    public class AnimatorBlackboardAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000016
    public class CameraControlConfigAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000017
    public class ECSComponentAttribute : Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;        // 0x10
        public System.Boolean isTag;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000018
    public class DataNAttribute : Attribute
    {
        // Fields
        public System.Int32 capacity;        // 0x10
        public System.Int32 tSize;        // 0x14
        public System.Boolean ring;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000002
    public class HGConstantBufferLayoutAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

